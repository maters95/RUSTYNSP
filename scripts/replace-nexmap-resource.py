"""Replace user resources inside an authenticated NSP map, keeping every other entry byte-identical.

    python scripts/replace-nexmap-resource.py source.nexmap --output fixed.nexmap \\
        --replace user_resources/images/kfc_colonel_limiter_860.gif=path/to/fixed.gif

Only existing entries can be replaced (names are not added or removed), so the
map's settings and every alarm rule that refers to the file stay valid.
"""
import argparse
import copy
import hashlib
import json
from pathlib import Path
import runpy

import pyzipper


def main():
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("map", type=Path)
    parser.add_argument("--output", required=True, type=Path)
    parser.add_argument("--replace", action="append", required=True, metavar="ENTRY=FILE",
                        help="Map entry name and the file whose bytes replace it")
    args = parser.parse_args()

    inspector = runpy.run_path(str(Path(__file__).with_name("inspect-nexmap.py")))
    original = inspector["read_map"](args.map)
    replacements = {}
    for item in args.replace:
        name, _, source = item.partition("=")
        if name not in original:
            raise SystemExit(f"{name}: not in {args.map.name}")
        replacements[name] = Path(source).read_bytes()

    args.output.parent.mkdir(parents=True, exist_ok=True)
    with pyzipper.AESZipFile(args.map) as source:
        with pyzipper.AESZipFile(args.output, "x", compression=pyzipper.ZIP_DEFLATED,
                                encryption=pyzipper.WZ_AES) as destination:
            destination.setpassword(inspector["map_password"]())
            destination.setencryption(pyzipper.WZ_AES, nbits=256)
            destination.comment = source.comment
            for metadata in source.infolist():
                destination.writestr(copy.copy(metadata),
                                     replacements.get(metadata.filename, original[metadata.filename]))

    result = inspector["read_map"](args.output)
    if list(result) != list(original):
        raise ValueError("Entry names or order changed")
    changed = sorted(name for name in original if result[name] != original[name])
    if changed != sorted(replacements) or any(result[name] != data for name, data in replacements.items()):
        raise ValueError(f"Unexpected changes: {changed}")
    sha = lambda data: hashlib.sha256(data).hexdigest()
    report = {
        "source": args.map.name, "source_sha256": sha(args.map.read_bytes()),
        "output": args.output.name, "output_sha256": sha(args.output.read_bytes()),
        "map_settings_byte_identical": result["_map"] == original["_map"],
        "unchanged_entries": len(original) - len(changed),
        "replaced": [{"name": name, "old_sha256": sha(original[name]), "new_sha256": sha(result[name]),
                      "bytes": len(result[name])} for name in changed],
    }
    args.output.with_suffix(".report.json").write_text(json.dumps(report, indent=2) + "\n", encoding="utf-8")
    print(json.dumps(report, indent=2))


if __name__ == "__main__":
    main()
