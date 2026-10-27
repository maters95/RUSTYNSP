import argparse
from collections import Counter
import hashlib
import io
import json
from pathlib import Path, PurePosixPath
import runpy
import xml.etree.ElementTree as ElementTree
import zipfile

import pyzipper
from cryptography.hazmat.primitives import padding
from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes


def map_password(definition=False):
    resolver = runpy.run_path(str(Path(__file__).with_name("resolve-nsp-strings.py")))
    literals = resolver["load_strings"](Path(__file__).resolve().parents[1] / "nsp_src")
    base_name, first, second, third, fourth = (
        ("bi", "BAk", "BAL", "BAl", "BAM") if definition
        else ("bI", "BAi", "BAJ", "BAj", "BAK")
    )
    base = literals[base_name]
    combined = literals["BAI"].format(literals[third] + base,
                                      literals[first] + base,
                                      literals[fourth] + base)
    value = (literals[second] + combined).encode("ascii")
    return hashlib.md5(value).hexdigest().upper().encode("ascii")


def read_map(path):
    with pyzipper.AESZipFile(path) as archive:
        archive.setpassword(map_password())
        entries = {}
        for entry in archive.infolist():
            if entry.filename in entries:
                raise ValueError(f"Duplicate archive member: {entry.filename}")
            entries[entry.filename] = archive.read(entry)
    return entries


def read_definition(path):
    resolver = runpy.run_path(str(Path(__file__).with_name("resolve-nsp-strings.py")))
    literals = resolver["load_strings"](Path(__file__).resolve().parents[1] / "nsp_src")
    encoded = path.read_bytes()
    if encoded[:5] != b"HEPS\x00" or int.from_bytes(encoded[5:9], "little") != 16:
        raise ValueError("Unsupported definition wrapper")
    key = hashlib.pbkdf2_hmac("sha1", map_password(definition=True),
                             literals["bz"].encode("ascii"), 1000, dklen=32)
    decoder = Cipher(algorithms.AES(key), modes.CBC(encoded[9:25])).decryptor()
    padded = decoder.update(encoded[25:]) + decoder.finalize()
    unpadder = padding.PKCS7(128).unpadder()
    decoded = unpadder.update(padded) + unpadder.finalize()
    with zipfile.ZipFile(io.BytesIO(decoded)) as archive:
        if archive.testzip() is not None:
            raise ValueError("Definition ZIP integrity failed")
        return {entry.filename: archive.read(entry) for entry in archive.infolist()}


def xml_summary(payload):
    try:
        root = ElementTree.fromstring(payload)
    except ElementTree.ParseError:
        return {"xml": False, "prefix_hex": payload[:16].hex()}
    return {
        "xml": True, "root": root.tag,
        "element_counts": dict(Counter(element.tag for element in root.iter())),
        "top_level": [{"tag": element.tag, "attributes": element.attrib} for element in root],
    }


def compare_maps(baseline, saved, definition=None):
    def settings(payload):
        root = ElementTree.fromstring(payload)
        return {(element.get("id"), element.get("attrId")): element.text
                for element in root.find("Data")}

    before = settings(baseline["_map"])
    after = settings(saved["_map"])
    schema = {}
    if definition is not None:
        structure = ElementTree.fromstring(definition["structure.xml"])
        schema = {element.get("id"): element.get("name", "") for element in structure.iter("S")}
    changes = []
    for key in sorted(before.keys() | after.keys(), key=lambda item: (int(item[0]), int(item[1]))):
        if before.get(key) != after.get(key):
            name = schema.get(key[0])
            display_only = None if name is None else (
                name.startswith("SCREEN_") or name.startswith("_SCREEN_") or name == "NUM_SCREENS"
            )
            changes.append({"id": key[0], "attribute": key[1], "name": name, "display_only": display_only})
    resources = []
    for name in sorted(saved):
        if name.startswith("user_resources/"):
            resources.append({"name": name, "unchanged": baseline.get(name) == saved[name],
                              "sha256": hashlib.sha256(saved[name]).hexdigest()})
    return {
        "added_entries": sorted(saved.keys() - baseline.keys()),
        "removed_entries": sorted(baseline.keys() - saved.keys()),
        "changed_entries": sorted(name for name in baseline.keys() & saved.keys()
                                  if baseline[name] != saved[name]),
        "changed_settings": changes,
        "non_display_changes": [change for change in changes if change["display_only"] is False],
        "unclassified_changes": [change for change in changes if change["display_only"] is None],
        "resources": resources,
    }


def main():
    parser = argparse.ArgumentParser(description="Inspect an owner's NSP map offline; never connect to a dash.")
    parser.add_argument("map", type=Path)
    parser.add_argument("--output", type=Path)
    parser.add_argument("--definition", type=Path)
    parser.add_argument("--compare", type=Path)
    args = parser.parse_args()
    entries = read_map(args.map)
    report = {
        "source": args.map.name, "sha256": hashlib.sha256(args.map.read_bytes()).hexdigest(),
        "authenticated_entries": len(entries),
        "entries": [{"name": name, "bytes": len(payload), "sha256": hashlib.sha256(payload).hexdigest()}
                    for name, payload in entries.items()],
        "layouts": {name: xml_summary(payload) for name, payload in entries.items()
                    if name == "_map" or name.endswith(".nexcfg")},
    }
    definition = read_definition(args.definition) if args.definition else None
    if definition is not None:
        report["definition_entries"] = list(definition)
        report["definition_xml"] = {name: xml_summary(payload) for name, payload in definition.items()
                                    if name.startswith("_") or name.lower().endswith(".xml")}
    if args.compare:
        report["comparison"] = compare_maps(read_map(args.compare), entries, definition)
    if args.output:
        destinations = {}
        for name in entries:
            relative = PurePosixPath(name.replace("\\", "/"))
            if relative.is_absolute() or ".." in relative.parts or ":" in name:
                raise ValueError(f"Non-relative archive member: {name}")
            destination = args.output.joinpath(*relative.parts)
            if destination in destinations.values():
                raise ValueError(f"Colliding archive member: {name}")
            destinations[name] = destination
        args.output.mkdir(parents=True, exist_ok=False)
        for name, payload in entries.items():
            destination = destinations[name]
            destination.parent.mkdir(parents=True, exist_ok=True)
            destination.write_bytes(payload)
        (args.output / "inspection.json").write_text(json.dumps(report, indent=2) + "\n", encoding="utf-8")
    print(json.dumps(report, indent=2))


if __name__ == "__main__":
    main()