import argparse
import copy
import hashlib
import io
import json
from pathlib import Path
import runpy
import tarfile
import xml.etree.ElementTree as ElementTree
import zipfile

from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes


TARGET = "qml_components_data/qml/user_components/HalImage.qml"


def digest(payload):
    return hashlib.sha256(payload).hexdigest()


def read_members(payload):
    with tarfile.open(fileobj=io.BytesIO(payload), mode="r:") as archive:
        result = {}
        for member in archive.getmembers():
            result[member.name] = (
                archive.extractfile(member).read() if member.isfile() else None
            )
        return result


def replace_component(payload, replacement):
    output = io.BytesIO()
    with tarfile.open(fileobj=io.BytesIO(payload), mode="r:") as source:
        with tarfile.open(fileobj=output, mode="w", format=tarfile.GNU_FORMAT) as destination:
            for member in source.getmembers():
                metadata = copy.copy(member)
                contents = source.extractfile(member) if member.isfile() else None
                if member.name == TARGET:
                    metadata.size = len(replacement)
                    contents = io.BytesIO(replacement)
                destination.addfile(metadata, contents)
    return output.getvalue()


def manifest_for_resource(stock_manifest, resource_name):
    root = ElementTree.fromstring(stock_manifest)
    products = [product for product in root.findall("PRODUCT")
                if product.get("pid") == "21" and product.get("vid") == "11"]
    if len(products) != 1:
        raise ValueError("Expected one iC-7 product in stock manifest")
    product = products[0]
    hdef_name = product.get("hdefFile")
    if not hdef_name:
        raise ValueError("Stock iC-7 product does not name its map definition file")
    files = [entry for entry in product.findall("FILE") if entry.get("name") == resource_name]
    if len(files) != 1:
        raise ValueError("Expected one stock iC-7 resource entry")
    result = ElementTree.Element(root.tag)
    for name in ("FW_PACKAGE_VERSION", "FILE_FORMAT_VERSION"):
        source = root.find(name)
        if source is None:
            raise ValueError(f"Missing manifest element {name}")
        result.append(copy.deepcopy(source))
    attributes = {name: value for name, value in product.attrib.items()
                  if name != "releaseNotesFile"}
    selected = ElementTree.SubElement(result, "PRODUCT", attributes)
    selected.append(copy.deepcopy(files[0]))
    ElementTree.indent(result)
    return ElementTree.tostring(result, encoding="utf-8", xml_declaration=True), hdef_name


def main():
    parser = argparse.ArgumentParser(description="Build offline, experimental iC-7 resource-only QML packages.")
    parser.add_argument("--stock-nex", required=True, type=Path)
    parser.add_argument("--reference", required=True, type=Path)
    parser.add_argument("--component", required=True, type=Path)
    parser.add_argument("--output", required=True, type=Path)
    parser.add_argument("--label", default="gif-preview")
    args = parser.parse_args()
    if not args.label or any(not (character.islower() or character.isdigit() or character == "-")
                             for character in args.label):
        parser.error("--label may contain only lowercase letters, digits, and hyphens")
    codec = runpy.run_path(str(Path(__file__).with_name("decode-nsp-resources.py")))
    resource_name = "res_ic-7.qzip"
    with zipfile.ZipFile(args.stock_nex) as stock:
        if stock.testzip() is not None:
            raise ValueError("Stock NEX ZIP integrity failed")
        original = stock.read(resource_name)
        manifest, hdef_name = manifest_for_resource(stock.read("manifest.xml"), resource_name)
        migration_definition = stock.read(hdef_name)
    decoded, original_report = codec["decode_resource"](args.reference, original)
    original_members = read_members(decoded)
    expected = "32baf88ac62d670e905bc30fd6c4dcb7abdbfc4a9c3b248254b98fdd07f5c6fb"
    if digest(original_members[TARGET]) != expected:
        raise ValueError("Target component does not match the verified v2.36 baseline")
    replacement = args.component.read_bytes()
    rebuilt = replace_component(decoded, replacement)
    rebuilt_members = read_members(rebuilt)
    if original_members.keys() != rebuilt_members.keys():
        raise ValueError("Resource archive member set changed")
    changed = [name for name in original_members if original_members[name] != rebuilt_members[name]]
    if changed != [TARGET]:
        raise ValueError(f"Unexpected resource changes: {changed}")
    key = codec["read_parameter"](args.reference, "encryption_keys", 1)
    vector = codec["read_parameter"](args.reference, "initial_vectors", 1)
    encryptor = Cipher(algorithms.AES(key), modes.CBC(vector)).encryptor()
    candidate = original[:44] + encryptor.update(rebuilt) + encryptor.finalize()
    roundtrip, rebuilt_report = codec["decode_resource"](args.reference, candidate)
    if roundtrip != rebuilt:
        raise ValueError("Encoded resource round-trip mismatch")
    args.output.mkdir(parents=True, exist_ok=False)
    (args.output / "HalImage.qml").write_bytes(replacement)
    packages = {}
    for package_label, payload in ((args.label, candidate), ("stock-resources", original)):
        name = f"ic7-2.36-{package_label}-experimental.nex"
        destination = args.output / name
        with zipfile.ZipFile(destination, "w", compression=zipfile.ZIP_STORED) as archive:
            archive.writestr("manifest.xml", manifest)
            archive.writestr(resource_name, payload)
            archive.writestr(hdef_name, migration_definition)
        with zipfile.ZipFile(destination) as archive:
            parsed_manifest = ElementTree.fromstring(archive.read("manifest.xml"))
            selected_product = parsed_manifest.find("PRODUCT")
            if (archive.testzip() is not None or
                    set(archive.namelist()) != {"manifest.xml", resource_name, hdef_name} or
                    selected_product is None or selected_product.get("hdefFile") != hdef_name or
                    [entry.get("name") for entry in selected_product.findall("FILE")] != [resource_name]):
                raise ValueError("Generated NEX integrity or payload set failed")
        packages[name] = {"bytes": destination.stat().st_size, "sha256": digest(destination.read_bytes())}
    report = {
        "status": "offline-validated; NSP acceptance and hardware installation untested",
        "label": args.label,
        "changed_members": changed, "preserved_members": len(original_members) - 1,
        "original_component_sha256": expected, "replacement_component_sha256": digest(replacement),
        "wrapper_preserved": candidate[:44] == original[:44],
        "migration_definition": {"name": hdef_name, "bytes": len(migration_definition),
                     "sha256": digest(migration_definition),
                     "listed_for_device_update": False},
        "archive_format": original_report["archive_format"],
        "roundtrip_integrity_valid": rebuilt_report["archive_integrity_valid"],
        "packages": packages,
    }
    (args.output / "build-report.json").write_text(json.dumps(report, indent=2) + "\n", encoding="utf-8")
    print(json.dumps(report, indent=2))


if __name__ == "__main__":
    main()