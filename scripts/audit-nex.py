"""Audit a resource-only iC-7 candidate NEX against the stock v2.36 package.

Independent of the builder's own report: compares package structure, manifest,
wrapper and HDEF with stock, lists every changed/added/removed resource member,
checks the replaced QML against maintained sources, and, given the dash's
extracted root filesystem, checks that every QML import exists there and that
every file the components load is inside the archive.

Example:
    python scripts/audit-nex.py --candidate path/to/candidate.nex \\
        --sysroot path/to/extracted-rootfs --output report.json
"""
import argparse
import hashlib
import io
import json
from pathlib import Path
import re
import runpy
import sys
import tarfile
import xml.etree.ElementTree as ElementTree
import zipfile

ROOT = Path(__file__).resolve().parents[1]
COMPONENTS = ROOT / "ic7-custom-dash/deploy/nsp"
QML_ROOT = "qml_components_data/qml/"
# Files the customised components load by relative path, from their own folder.
LOADED_FILES = {
    "factory_screens/main.qml": ["../user_components/HalSplash.qml"],
    "user_components/HalSplash.qml": ["HalImage.qml"],
    "user_components/HalAlarmPopup.qml": ["../../fonts/D-DINCondensed-Bold-Dash.ttf"],
}


def sha256(data):
    return hashlib.sha256(data).hexdigest()


def members(codec, reference, payload):
    archive = codec["decode_resource"](reference, payload)[0]
    with tarfile.open(fileobj=io.BytesIO(archive), mode="r:") as tar:
        return {member.name: tar.extractfile(member).read()
                for member in tar.getmembers() if member.isfile()}


def manifest(package):
    root = ElementTree.fromstring(package.read("manifest.xml").decode("utf-8-sig"))
    products = []
    for product in root.iter("PRODUCT"):
        products.append({**product.attrib, "files": [dict(item.attrib) for item in product.iter("FILE")]})
    return {"version": root.findtext("FW_PACKAGE_VERSION"), "products": products}


def qml_imports(text):
    return sorted(set(re.findall(r"^\s*import\s+([A-Za-z][\w.]*)\s+(\d+\.\d+)", text, re.M)))


def module_available(sysroot, module, version):
    folder = sysroot / "usr/lib/qml" / module.replace(".", "/")
    if module == "QtQuick":
        return (sysroot / "usr/lib/qml/QtQuick.2/qmldir").is_file()
    candidates = [folder / "qmldir", Path(str(folder) + "." + version.split(".")[0]) / "qmldir"]
    return any(path.is_file() for path in candidates)


def main():
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("--candidate", required=True, type=Path)
    parser.add_argument("--stock", type=Path, default=ROOT / "fw/Dash-V2-36-0-Release.nex")
    parser.add_argument("--reference", type=Path, default=ROOT / "fw/opt/dtn/app/dash_watchdog")
    parser.add_argument("--sysroot", type=Path, help="Extracted dash root filesystem")
    parser.add_argument("--output", type=Path)
    args = parser.parse_args()

    codec = runpy.run_path(str(ROOT / "scripts/decode-nsp-resources.py"))
    problems = []
    report = {"candidate": str(args.candidate), "candidate_sha256": sha256(args.candidate.read_bytes())}
    with zipfile.ZipFile(args.stock) as stock_zip, zipfile.ZipFile(args.candidate) as candidate_zip:
        if candidate_zip.testzip() is not None:
            problems.append("Candidate ZIP CRC failure")
        names = sorted(candidate_zip.namelist())
        report["package_files"] = names
        if names != ["ic-7.hdef", "manifest.xml", "res_ic-7.qzip"]:
            problems.append("Unexpected package files: " + ", ".join(names))
        stock_manifest, candidate_manifest = manifest(stock_zip), manifest(candidate_zip)
        stock_ic7 = next(p for p in stock_manifest["products"] if p.get("vid") == "11")
        report["manifest"] = candidate_manifest
        if len(candidate_manifest["products"]) != 1:
            problems.append("Candidate must target exactly one product")
        product = candidate_manifest["products"][0]
        for key in ("name", "pid", "vid", "hwid", "hdefFile"):
            if product.get(key) != stock_ic7.get(key):
                problems.append(f"Manifest {key} {product.get(key)!r} differs from stock {stock_ic7.get(key)!r}")
        if [item.get("name") for item in product["files"]] != ["res_ic-7.qzip"]:
            problems.append("Only the resource archive may be listed for device update")
        if candidate_zip.read("ic-7.hdef") != stock_zip.read("ic-7.hdef"):
            problems.append("Migration HDEF differs from stock")
        stock_payload = stock_zip.read("res_ic-7.qzip")
        candidate_payload = candidate_zip.read("res_ic-7.qzip")
        if stock_payload[:44] != candidate_payload[:44]:
            problems.append("44-byte resource wrapper differs from stock")
        before = members(codec, args.reference, stock_payload)
        after = members(codec, args.reference, candidate_payload)

    changed = sorted(name for name in before.keys() & after.keys() if before[name] != after[name])
    added = sorted(after.keys() - before.keys())
    removed = sorted(before.keys() - after.keys())
    report["resources"] = {"stock_files": len(before), "candidate_files": len(after),
                           "unchanged": len(before.keys() & after.keys()) - len(changed),
                           "changed": changed, "added": added, "removed": removed}
    if removed:
        problems.append("Stock resources removed: " + ", ".join(removed))
    for name in changed + added:
        if not name.startswith(QML_ROOT):
            problems.append("Non-QML resource modified: " + name)
            continue
        maintained = COMPONENTS / Path(name).name
        if not maintained.is_file() or maintained.read_bytes() != after[name]:
            problems.append("Packaged QML does not match maintained source: " + name)

    checks = []
    for name in changed + added:
        relative = name[len(QML_ROOT):]
        text = after[name].decode("utf-8")
        entry = {"file": name, "imports": [f"{module} {version}" for module, version in qml_imports(text)]}
        folder = Path(QML_ROOT + relative).parent
        for loaded in LOADED_FILES.get(relative, []):
            target = (folder / loaded).as_posix()
            parts = []
            for part in target.split("/"):
                if part == "..":
                    parts.pop()
                elif part != ".":
                    parts.append(part)
            resolved = "/".join(parts)
            entry.setdefault("loads", []).append(resolved)
            if resolved not in after:
                problems.append(f"{name} loads {resolved}, which is not in the archive")
        if args.sysroot:
            missing = [f"{module} {version}" for module, version in qml_imports(text)
                       if not module_available(args.sysroot, module, version)]
            entry["imports_missing_on_dash"] = missing
            problems.extend(f"{name} imports {item}, not installed on the dash" for item in missing)
        checks.append(entry)
    report["component_checks"] = checks
    report["problems"] = problems
    report["suitable"] = not problems
    text = json.dumps(report, indent=2) + "\n"
    if args.output:
        args.output.write_text(text)
    print(text)
    return 0 if not problems else 1


if __name__ == "__main__":
    sys.exit(main())
