"""Disassemble named functions of any ARM ELF (watchdog, app, kernel modules) with
PLT/symbol call names and resolved PC-relative literals (strings shown inline).

Reuses the Disassembler class from scripts/disassemble-nsp-app.py.

Usage:
    python3 scripts/hardware_audit/elfdis.py ELF "demangled fn" [...]
    python3 scripts/hardware_audit/elfdis.py ELF --grep REGEX     # list matching symbols
    python3 scripts/hardware_audit/elfdis.py ELF --xref-string TEXT  # functions referencing a string
"""
import argparse
from pathlib import Path
import re
import runpy
import struct

import capstone

HERE = Path(__file__).resolve().parent
Disassembler = runpy.run_path(str(HERE.parent / "disassemble-nsp-app.py"))["Disassembler"]


def cstring(dis, address):
    raw = dis.read(address, 160)
    if not raw:
        return None
    end = raw.find(b"\0")
    text = raw[:end if end >= 0 else 160]
    if len(text) >= 3 and all(32 <= b < 127 or b in (9, 10) for b in text):
        return text.decode()
    return None


def qstring_literal(dis, address):
    """A QStaticStringData: QArrayData header (ref,size,alloc,offset) then UTF-16."""
    raw = dis.read(address, 16)
    if len(raw) < 16:
        return None
    ref, size, alloc, offset = struct.unpack("<iIIi", raw)
    if ref != -1 or not (0 < size < 200) or not (8 <= offset <= 64):
        return None
    body = dis.read(address + offset, size * 2)
    try:
        return "Q:" + body.decode("utf-16-le")
    except UnicodeDecodeError:
        return None


def listing(dis, name):
    address, size, thumb = dis.functions[name]
    engine = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_THUMB if thumb else capstone.CS_MODE_ARM)
    engine.detail = False
    out = [f"; {name} @ 0x{address:x}, {size} bytes"]
    regs = {}
    for ins in engine.disasm(dis.read(address, size), address):
        note = ""
        if ins.mnemonic.startswith("add") and ", pc, " in ins.op_str:
            parts = [p.strip() for p in ins.op_str.split(",")]
            if len(parts) == 3 and parts[2] in regs:
                target = (regs[parts[2]] + ins.address + (4 if thumb else 8)) & 0xFFFFFFFF
                text = cstring(dis, target) or qstring_literal(dis, target)
                note = f"-> 0x{target:x}" + (f' "{text}"' if text else "") + \
                    (f" <{dis.names[target]}>" if target in dis.names else "")
        if ins.mnemonic in ("bl", "blx", "b") and ins.op_str.startswith("#"):
            target = int(ins.op_str[1:], 0)
            note = dis.plt.get(target) or dis.names.get(target, "")
        m = re.match(r"(\w+), \[pc, #(-?0x[0-9a-f]+|-?\d+)\]", ins.op_str)
        if ins.mnemonic.startswith("ldr") and m:
            pc = (ins.address + (4 if thumb else 8)) & ~3
            lit = pc + int(m.group(2), 0)
            raw = dis.read(lit, 4)
            if len(raw) == 4:
                value = struct.unpack("<I", raw)[0]
                regs[m.group(1)] = value
                text = cstring(dis, value)
                note = f"=0x{value:x}" + (f' "{text}"' if text else "") + (f" <{dis.names[value]}>" if value in dis.names else "")
        out.append(f"{ins.address:08x}  {ins.mnemonic:7} {ins.op_str:30} {note}".rstrip())
    return "\n".join(out)


_CONSTANTS = None


def constants(dis):
    """Per function: every 32-bit value it materialises (literal-pool words,
    movw/movt pairs, and pc-relative add/adr results)."""
    global _CONSTANTS
    if _CONSTANTS is not None:
        return _CONSTANTS
    _CONSTANTS = {}
    arm = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_ARM)
    thumb_cs = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_THUMB)
    for fn, (addr, size, thumb) in dis.functions.items():
        if size < 4:
            continue
        code = dis.read(addr, size)
        values = set()
        low = {}
        for ins in (thumb_cs if thumb else arm).disasm(code, addr):
            ops = ins.op_str
            if ins.mnemonic.startswith("movw"):
                reg, imm = ops.split(", #")
                low[reg] = int(imm, 0)
                values.add(int(imm, 0))
            elif ins.mnemonic.startswith("movt"):
                reg, imm = ops.split(", #")
                values.add((int(imm, 0) << 16) | low.get(reg, 0))
            elif ins.mnemonic.startswith("ldr") and "[pc, #" in ops:
                pc = (ins.address + (4 if thumb else 8)) & ~3
                lit = pc + int(ops.split("#")[-1].rstrip("]"), 0)
                raw = dis.read(lit, 4)
                if len(raw) == 4:
                    v = struct.unpack("<I", raw)[0]
                    values.add(v)
                    low[ops.split(",")[0]] = v
            elif ins.mnemonic.startswith("add") and ", pc, " in ops:
                parts = [p.strip() for p in ops.split(",")]
                rn = parts[2] if len(parts) == 3 else None
                if rn in low:
                    values.add((low[rn] + ins.address + (4 if thumb else 8)) & 0xFFFFFFFF)
        _CONSTANTS[fn] = values
    return _CONSTANTS


def xref(dis, data, text):
    """Functions whose literal pool (or movw/movt pair) holds the address of TEXT."""
    needles = [text.encode() + b"\0", text.encode("utf-16-le")]
    addrs = set()
    for sec in dis.elf.iter_sections():
        if sec["sh_type"] != "SHT_PROGBITS" or not sec["sh_addr"]:
            continue
        blob = sec.data()
        for needle in needles:
            start = 0
            while True:
                i = blob.find(needle, start)
                if i < 0:
                    break
                addrs.add(sec["sh_addr"] + i)
                start = i + 1
    hits = []
    # QStringLiteral data sits 16..24 bytes after its QArrayData header
    targets = {a - d for a in addrs for d in (0, 8, 12, 16, 20, 24)}
    for fn, values in constants(dis).items():
        if values & targets:
            hits.append((dis.functions[fn][0], fn))
    print(f"; xref {text!r} at {[hex(a) for a in sorted(addrs)]}")
    for addr, fn in sorted(set(hits)):
        print(f"   0x{addr:08x} {fn}")


def callers(dis, name):
    """Functions containing a direct bl/blx/b to NAME."""
    target = dis.functions[name][0]
    arm = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_ARM)
    thumb_cs = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_THUMB)
    print(f"; callers of {name} @0x{target:x}")
    for fn, (addr, size, thumb) in sorted(dis.functions.items(), key=lambda kv: kv[1][0]):
        if size < 4:
            continue
        for ins in (thumb_cs if thumb else arm).disasm(dis.read(addr, size), addr):
            if ins.mnemonic.split(".")[0] in ("bl", "blx", "b", "bleq", "blne", "beq", "bne") \
                    and ins.op_str == f"#0x{target:x}":
                print(f"   0x{ins.address:08x} in {fn}")
                break


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("elf", type=Path)
    ap.add_argument("functions", nargs="*")
    ap.add_argument("--grep")
    ap.add_argument("--xref-string", action="append", default=[])
    ap.add_argument("--callers", action="append", default=[])
    args = ap.parse_args()
    data = args.elf.read_bytes()
    dis = Disassembler(data)
    for text in args.xref_string:
        xref(dis, data, text)
    for name in args.callers:
        callers(dis, name)
    if args.grep:
        for fn, (addr, size, thumb) in sorted(dis.functions.items(), key=lambda kv: kv[1][0]):
            if re.search(args.grep, fn):
                print(f"0x{addr:08x} {size:6d} {fn}")
    for fn in args.functions:
        print(listing(dis, fn))


if __name__ == "__main__":
    main()
