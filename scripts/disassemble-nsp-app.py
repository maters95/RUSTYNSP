"""Decrypt the iC-7 application stage of a NEX and disassemble named functions.

Example:
    python scripts/disassemble-nsp-app.py --stage fw/x/nic-7 \
        --reference fw/opt/dtn/app/dash_watchdog "ui_module::UIMain::UIMain(QObject*)"

Read-only: nothing is written unless --save-elf is given.
"""
import argparse
import hashlib
import io
from pathlib import Path
import runpy
import subprocess

import capstone
from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
from elftools.elf.elffile import ELFFile
from elftools.elf.relocation import RelocationSection

ROOT = Path(__file__).resolve().parent


def decrypt_stage(stage, reference):
    read_parameter = runpy.run_path(str(ROOT / "decode-nsp-resources.py"))["read_parameter"]
    body = stage[44:]
    body = body[:len(body) // 16 * 16]
    for index in range(2):
        key = read_parameter(reference, "encryption_keys", index)
        vector = read_parameter(reference, "initial_vectors", index)
        decoded = Cipher(algorithms.AES(key), modes.CBC(vector)).decryptor().update(body)
        if decoded.startswith(b"\x7fELF"):
            return decoded
    raise ValueError("No known key decrypts this stage to an ELF")


def demangle(names):
    result = subprocess.run(["c++filt"], input="\n".join(names), capture_output=True, text=True, check=True)
    return dict(zip(names, result.stdout.splitlines()))


class Disassembler:
    def __init__(self, data):
        self.elf = ELFFile(io.BytesIO(data))
        symbols = [s for s in self.elf.get_section_by_name(".symtab").iter_symbols()
                   if s["st_value"] and s.name and not s.name.startswith("$")]
        readable = demangle([s.name for s in symbols])
        self.names = {}
        self.functions = {}
        for symbol in symbols:
            address = symbol["st_value"] & ~1
            self.names.setdefault(address, readable[symbol.name])
            self.functions[readable[symbol.name]] = (address, symbol["st_size"], symbol["st_value"] & 1)
        self.plt = self._plt_targets()

    def _plt_targets(self):
        dynamic = self.elf.get_section_by_name(".dynsym")
        relocations = next(s for s in self.elf.iter_sections()
                           if isinstance(s, RelocationSection) and s.name == ".rel.plt")
        slots = {r["r_offset"]: dynamic.get_symbol(r["r_info_sym"]).name for r in relocations.iter_relocations()}
        readable = demangle(sorted(set(slots.values())))
        plt = self.elf.get_section_by_name(".plt")
        code, base = plt.data(), plt["sh_addr"]
        arm = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_ARM)
        targets = {}
        # Each entry is: add ip, pc, #a; add ip, ip, #b; ldr pc, [ip, #c]!
        for offset in range(20, len(code) - 11, 12):
            entry = list(arm.disasm(code[offset:offset + 12], base + offset))
            try:
                slot = base + offset + 8
                for instruction in entry[:2]:
                    slot += int(instruction.op_str.split("#")[-1], 0)
                slot += int(entry[2].op_str.split("#")[-1].rstrip("]!"), 0)
            except (IndexError, ValueError):
                continue
            if slot in slots:
                targets[base + offset] = readable[slots[slot]]
        return targets

    def read(self, address, size):
        for section in self.elf.iter_sections():
            start = section["sh_addr"]
            if section["sh_type"] == "SHT_PROGBITS" and start <= address < start + section["sh_size"]:
                return section.data()[address - start:address - start + size]
        return b""

    def listing(self, name):
        address, size, thumb = self.functions[name]
        engine = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_THUMB if thumb else capstone.CS_MODE_ARM)
        lines = [f"; {name} @ 0x{address:x}, {size} bytes"]
        for instruction in engine.disasm(self.read(address, size), address):
            note = ""
            if instruction.mnemonic in ("bl", "blx", "b") and instruction.op_str.startswith("#"):
                target = int(instruction.op_str[1:], 0)
                note = self.plt.get(target) or self.names.get(target, "")
            lines.append(f"{instruction.address:08x}  {instruction.mnemonic:7} {instruction.op_str:28} {note}".rstrip())
        return "\n".join(lines)


def main():
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("--stage", type=Path, default=Path("fw/x/nic-7"))
    parser.add_argument("--reference", type=Path, default=Path("fw/opt/dtn/app/dash_watchdog"))
    parser.add_argument("--save-elf", type=Path)
    parser.add_argument("functions", nargs="+", help="Demangled function names")
    args = parser.parse_args()
    data = decrypt_stage(args.stage.read_bytes(), args.reference)
    print(f"; decrypted ELF sha256 {hashlib.sha256(data).hexdigest()}")
    if args.save_elf:
        args.save_elf.write_bytes(data)
    disassembler = Disassembler(data)
    for name in args.functions:
        print(disassembler.listing(name))


if __name__ == "__main__":
    main()
