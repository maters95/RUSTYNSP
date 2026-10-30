"""Dump the bytes of data symbols matching a regex from an ELF, as 16-bit and
32-bit little-endian words (used for io::dash_arch_* pin tables and similar).

Usage:
    python3 scripts/hardware_audit/dump_symbols.py ELF REGEX
"""
import re
import struct
import subprocess
import sys

from elftools.elf.elffile import ELFFile


def main():
    path, pattern = sys.argv[1], re.compile(sys.argv[2])
    with open(path, "rb") as f:
        elf = ELFFile(f)
        symtab = elf.get_section_by_name(".symtab")
        syms = [s for s in symtab.iter_symbols() if s["st_info"]["type"] == "STT_OBJECT" and s["st_size"]]
        names = subprocess.run(["c++filt"], input="\n".join(s.name for s in syms),
                               capture_output=True, text=True).stdout.splitlines()
        for sym, name in sorted(zip(syms, names), key=lambda x: x[1]):
            if not pattern.search(name):
                continue
            sec = elf.get_section(sym["st_shndx"])
            if sec["sh_type"] == "SHT_NOBITS":
                print(f"{name} @0x{sym['st_value']:x} size {sym['st_size']} (.bss, runtime-filled)")
                continue
            off = sym["st_value"] - sec["sh_addr"]
            data = sec.data()[off:off + sym["st_size"]]
            h = struct.unpack(f"<{len(data)//2}H", data[:len(data)//2*2])
            w = struct.unpack(f"<{len(data)//4}I", data[:len(data)//4*4])
            print(f"{name} @0x{sym['st_value']:x} size {sym['st_size']} [{sec.name}]")
            print("   u8 :", list(data[:64]))
            print("   u16:", list(h[:32]))
            print("   u32:", [hex(x) for x in w[:16]])


if __name__ == "__main__":
    main()
