"""Build dash-channels.json: the iC-7 v2.36 live channels and where they live in dash memory.

Development tool (needs the repository's decoded firmware definition). The
definition's RAM settings (no ``_memType``) are 32-bit channels at their
``addr`` in the live block NSP polls (0x1400-0x7fe4); map settings
(``MRAM_EE``) live at 0x20000 + ``addr``. The alarm module stores a channel
by this id, so the emulator needs the id -> address table to evaluate alarms
as the dash does.
"""
import argparse
import hashlib
import json
from pathlib import Path
import re
import runpy

ROOT = Path(__file__).resolve().parent
LIVE_END = 0x8000


def channels(structure):
    table = {}
    for match in re.finditer(r'<S id="(\d+)" name="([^"]+)" addr="(\d+)">', structure):
        end = structure.find("</S>", match.end())
        body = structure[match.end():end]
        if "_memType=" in body or 'name="Type" val="-32"' not in re.sub(r"<A .*?</A>", "", body, flags=re.S):
            continue
        address = int(match.group(3))
        if address + 4 > LIVE_END:
            continue
        own = re.sub(r"<A .*?</A>", "", body, flags=re.S)
        long_name = re.search(r'name="LongName" type="string">([^<]*)<', own)
        table[match.group(1)] = [address, match.group(2), long_name.group(1) if long_name else ""]
    return table


def main():
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("--definition", type=Path, default=ROOT.parent / "fw/ic7_2360.hdef")
    parser.add_argument("--output", type=Path, default=ROOT / "dash-channels.json")
    args = parser.parse_args()
    reader = runpy.run_path(str(ROOT.parent / "scripts/inspect-nexmap.py"))["read_definition"]
    structure = reader(args.definition)["structure.xml"].decode("utf-8-sig")
    table = channels(structure)
    report = {"definition": args.definition.name,
              "definition_md5": hashlib.md5(args.definition.read_bytes()).hexdigest(),
              "note": "Live channels (32-bit, little-endian) by setting id: [address, name, long name]",
              "channels": table}
    args.output.write_text(json.dumps(report, separators=(",", ":")) + "\n", encoding="utf-8")
    print(f"{len(table)} channels -> {args.output}")


if __name__ == "__main__":
    main()
