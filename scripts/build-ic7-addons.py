"""Layer the EXPERIMENTAL iC-7 add-on QML onto an existing candidate NEX.

The base NEX (for example the main splash/alarm candidate) is never modified. The
output is a new NEX in which only the add-on QML members differ from the base; the
44-byte resource wrapper, manifest.xml and ic-7.hdef are copied byte-for-byte, and
every other archive member keeps its exact bytes and tar metadata. Replaced and added
members get a fresh mtime (content-derived, reproducible, never a stock or base value)
because Qt 5.9.6 reuses compiled QML whenever path and mtime match.

Example:
    python scripts/build-ic7-addons.py \\
        --base ic7-custom-dash/build-cfw-screen-alarms-freshmtime-236/ic7-2.36-screen-alarms-experimental.nex \\
        --sysroot /path/to/dash/sysroot
"""
import argparse
import copy
import datetime
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

from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes

ROOT = Path(__file__).resolve().parents[1]
ADDON_QML = ROOT / "ic7-custom-dash/deploy/addons/qml"
COMPONENTS = "qml_components_data/qml/user_components/"
RESOURCE = "res_ic-7.qzip"
# Stock components the add-ons extend (pure insertions; must be stock in the base).
REPLACED = ["HalIndicator.qml", "HalNumeric.qml", "HalBarHorizontal1.qml", "HalCircularClassic.qml"]
# New files, loaded only through Loaders/imports inside the add-on code.
ADDED = ["Ic7IndicatorAddon.qml", "Ic7GaugeFx.qml", "Ic7AddonMedia.qml", "Ic7AddonVideo.qml", "ic7addons.js"]
# Relative files each add-on member loads (checked to exist in the output archive).
LOADS = {
    "HalIndicator.qml": ["Ic7IndicatorAddon.qml", "common.js"],
    "HalNumeric.qml": ["Ic7GaugeFx.qml", "common.js"],
    "HalBarHorizontal1.qml": ["Ic7GaugeFx.qml", "common.js"],
    "HalCircularClassic.qml": ["Ic7GaugeFx.qml", "common.js"],
    "Ic7IndicatorAddon.qml": ["ic7addons.js", "Ic7AddonMedia.qml"],
    "Ic7GaugeFx.qml": ["ic7addons.js"],
    "Ic7AddonMedia.qml": ["Ic7AddonVideo.qml"],
    "Ic7AddonVideo.qml": [],
    "ic7addons.js": [],
}
MTIME_BASE = 1700000000
MTIME_SPAN = 90000000
MARKER = re.compile(r"[ \t]*// IC7-ADDON-BEGIN.*?// IC7-ADDON-END\r?\n", re.S)


def shown(path):
    """Repository-relative path for reports, so they do not leak a local folder layout."""
    try:
        return Path(path).resolve().relative_to(ROOT).as_posix()
    except ValueError:
        return str(path)


def sha256(data):
    return hashlib.sha256(data).hexdigest()


def strip_to_stock(text):
    """Remove the marked insertions; for a valid add-on file this yields the stock file exactly."""
    stripped = MARKER.sub("", text)
    # The trailing-Loader insertion is preceded by one blank line.
    index = stripped.rfind("\r\n\r\n}")
    if index >= 0 and stripped[index + 4:].strip() == "}":
        stripped = stripped[:index + 2] + stripped[index + 4:]
    return stripped


def read_package(path):
    with zipfile.ZipFile(path) as package:
        if package.testzip() is not None:
            raise ValueError(f"{path}: ZIP CRC failure")
        infos = package.infolist()
        return infos, {info.filename: package.read(info.filename) for info in infos}


def decode_members(codec, reference, payload):
    archive = codec["decode_resource"](reference, payload)[0]
    with tarfile.open(fileobj=io.BytesIO(archive), mode="r:") as tar:
        members = tar.getmembers()
        data = {m.name: (tar.extractfile(m).read() if m.isfile() else None) for m in members}
    return archive, members, data


def header(member):
    return (member.name, member.mode, member.uid, member.gid, member.size, member.mtime, member.type,
            member.linkname, member.uname, member.gname)


def qml_imports(text):
    return sorted(set(re.findall(r"^\s*import\s+([A-Za-z][\w.]*)\s+(\d+\.\d+)", text, re.M)))


def module_available(sysroot, module, version):
    if module == "QtQuick":
        return (sysroot / "usr/lib/qml/QtQuick.2/qmldir").is_file()
    folder = sysroot / "usr/lib/qml" / module.replace(".", "/")
    return any(p.is_file() for p in (folder / "qmldir", Path(f"{folder}.{version.split('.')[0]}") / "qmldir"))


def product_of(manifest):
    root = ElementTree.fromstring(manifest.decode("utf-8-sig"))
    products = [p for p in root.iter("PRODUCT") if p.get("vid") == "11" and p.get("pid") == "21"]
    return root, products


def main():
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("--base", required=True, type=Path,
                        help="Candidate NEX to layer onto (recorded with its SHA-256)")
    parser.add_argument("--stock", type=Path, default=ROOT / "fw/Dash-V2-36-0-Release.nex")
    parser.add_argument("--reference", type=Path, default=ROOT / "fw/opt/dtn/app/dash_watchdog")
    parser.add_argument("--addons", type=Path, default=ADDON_QML)
    parser.add_argument("--sysroot", type=Path, help="Extracted dash root filesystem (import check)")
    parser.add_argument("--output", type=Path, default=ROOT / "ic7-custom-dash/build-addons-experimental-236")
    parser.add_argument("--label", default="addons-experimental")
    parser.add_argument("--mtime", type=int,
                        help="Override: one mtime for all add-on members (default: content-derived)")
    parser.add_argument("--force", action="store_true", help="Overwrite an existing output folder's files")
    args = parser.parse_args()
    if not re.fullmatch(r"[a-z0-9-]+", args.label):
        parser.error("--label may contain only lowercase letters, digits and hyphens")

    codec = runpy.run_path(str(ROOT / "scripts/decode-nsp-resources.py"))
    problems = []
    base_bytes = args.base.read_bytes()
    stock_bytes = args.stock.read_bytes()
    base_infos, base_files = read_package(args.base)
    _, stock_files = read_package(args.stock)
    if sorted(base_files) != ["ic-7.hdef", "manifest.xml", RESOURCE]:
        raise ValueError("Base NEX must be a resource-only package (manifest.xml, ic-7.hdef, res_ic-7.qzip)")

    _, stock_members, stock_data = decode_members(codec, args.reference, stock_files[RESOURCE])
    base_archive, base_members, base_data = decode_members(codec, args.reference, base_files[RESOURCE])
    stock_headers = {m.name: m for m in stock_members}

    sources = {name: (args.addons / name).read_bytes() for name in REPLACED + ADDED}
    for name in REPLACED:
        member = COMPONENTS + name
        if base_data.get(member) != stock_data.get(member):
            raise ValueError(f"Base already changes {member}; refusing to overwrite another build's work")
        if strip_to_stock(sources[name].decode("utf-8")).encode("utf-8") != stock_data[member]:
            raise ValueError(f"{name} is not stock plus marked IC7-ADDON insertions")
    for name in ADDED:
        if COMPONENTS + name in base_data:
            raise ValueError(f"Base already contains {COMPONENTS + name}")

    # Same scheme as scripts/build-nsp-gif-preview.py: reproducible, content-derived and
    # never equal to an mtime already used by stock or the base (or zero).
    stock_mtimes = {m.mtime for m in stock_members}
    avoid = {0} | stock_mtimes | {m.mtime for m in base_members}
    if args.mtime is not None and args.mtime in avoid:
        raise ValueError(f"--mtime {args.mtime} must differ from every stock/base member mtime and 0")
    mtimes = {}
    for name in REPLACED + ADDED:
        value = args.mtime if args.mtime is not None else \
            MTIME_BASE + int(sha256(sources[name])[:12], 16) % MTIME_SPAN
        while args.mtime is None and value in avoid:
            value += 1
        mtimes[name] = value

    # Rebuild the tar: unchanged members are copied with their original headers.
    output = io.BytesIO()
    template = next(m for m in base_members if m.name == COMPONENTS + "HalIndicator.qml")
    with tarfile.open(fileobj=io.BytesIO(base_archive), mode="r:") as source, \
            tarfile.open(fileobj=output, mode="w", format=tarfile.GNU_FORMAT) as destination:
        for member in source.getmembers():
            info = copy.copy(member)
            contents = source.extractfile(member) if member.isfile() else None
            name = member.name[len(COMPONENTS):] if member.name.startswith(COMPONENTS) else None
            if name in REPLACED:
                info.size = len(sources[name])
                info.mtime = mtimes[name]
                contents = io.BytesIO(sources[name])
            destination.addfile(info, contents)
        for name in ADDED:
            info = copy.copy(template)
            info.name = COMPONENTS + name
            info.size = len(sources[name])
            info.mtime = mtimes[name]
            destination.addfile(info, io.BytesIO(sources[name]))
    rebuilt = output.getvalue()

    key = codec["read_parameter"](args.reference, "encryption_keys", 1)
    vector = codec["read_parameter"](args.reference, "initial_vectors", 1)
    encryptor = Cipher(algorithms.AES(key), modes.CBC(vector)).encryptor()
    payload = base_files[RESOURCE][:44] + encryptor.update(rebuilt) + encryptor.finalize()

    args.output.mkdir(parents=True, exist_ok=True)
    nex_name = f"ic7-2.36-{args.label}.nex"
    nex_path = args.output / nex_name
    if nex_path.exists() and not args.force:
        raise FileExistsError(f"{nex_path} exists; pass --force to replace it")
    with zipfile.ZipFile(nex_path, "w") as package:
        for info in base_infos:
            entry = zipfile.ZipInfo(info.filename, date_time=info.date_time)
            entry.compress_type = info.compress_type
            entry.external_attr = info.external_attr
            entry.create_system = info.create_system
            package.writestr(entry, payload if info.filename == RESOURCE else base_files[info.filename])

    # ---- Self-check: decode the written file from disk, independent of the build state.
    out_infos, out_files = read_package(nex_path)
    checks = {}
    checks["package_files_same_as_base"] = [i.filename for i in out_infos] == [i.filename for i in base_infos]
    checks["manifest_identical_to_base"] = out_files["manifest.xml"] == base_files["manifest.xml"]
    checks["hdef_identical_to_base"] = out_files["ic-7.hdef"] == base_files["ic-7.hdef"]
    checks["hdef_identical_to_stock"] = out_files["ic-7.hdef"] == stock_files["ic-7.hdef"]
    checks["wrapper_identical_to_base"] = out_files[RESOURCE][:44] == base_files[RESOURCE][:44]
    checks["wrapper_identical_to_stock"] = out_files[RESOURCE][:44] == stock_files[RESOURCE][:44]
    _, stock_root_products = product_of(stock_files["manifest.xml"])
    _, out_products = product_of(out_files["manifest.xml"])
    stock_product = stock_root_products[0]
    checks["manifest_targets_stock_ic7_product"] = len(out_products) == 1 and all(
        out_products[0].get(k) == stock_product.get(k) for k in ("name", "pid", "vid", "hwid", "hdefFile")) and \
        [f.get("name") for f in out_products[0].iter("FILE")] == [RESOURCE]
    roundtrip, out_members, out_data = decode_members(codec, args.reference, out_files[RESOURCE])
    checks["archive_roundtrip_exact"] = roundtrip == rebuilt
    out_headers = {m.name: m for m in out_members}
    expected = {COMPONENTS + n for n in REPLACED + ADDED}
    vs_base_changed = sorted(n for n in out_data if n in base_data and out_data[n] != base_data[n])
    vs_base_added = sorted(set(out_data) - set(base_data))
    vs_base_removed = sorted(set(base_data) - set(out_data))
    checks["only_addon_members_differ_from_base"] = set(vs_base_changed) | set(vs_base_added) == expected \
        and not vs_base_removed
    base_headers = {m.name: m for m in base_members}
    metadata_drift = [n for n in base_headers if n not in expected and
                      header(base_headers[n]) != header(out_headers[n])]
    checks["unchanged_members_keep_tar_metadata"] = not metadata_drift
    checks["member_order_preserved"] = [m.name for m in out_members][:len(base_members)] == \
        [m.name for m in base_members]
    checks["addon_members_fresh_mtime"] = all(
        out_headers[COMPONENTS + n].mtime == mtimes[n] and mtimes[n] not in avoid for n in REPLACED + ADDED)
    checks["addon_members_match_sources"] = all(
        out_data[COMPONENTS + n] == sources[n] for n in REPLACED + ADDED)
    vs_stock_changed = sorted(n for n in out_data if n in stock_data and out_data[n] != stock_data[n])
    vs_stock_added = sorted(set(out_data) - set(stock_data))
    vs_stock_removed = sorted(set(stock_data) - set(out_data))
    base_vs_stock = {n for n in base_data if n not in stock_data or base_data[n] != stock_data[n]}
    checks["differs_from_stock_only_by_base_and_addons"] = \
        set(vs_stock_changed) | set(vs_stock_added) == base_vs_stock | expected and not vs_stock_removed
    checks["no_non_qml_member_changed_vs_stock"] = all(
        n.startswith("qml_components_data/qml/") for n in vs_stock_changed + vs_stock_added)
    stale_base = sorted(n for n in base_vs_stock if n in stock_headers and
                        base_headers[n].mtime == stock_headers[n].mtime)

    component_checks = []
    for name in REPLACED + ADDED:
        text = sources[name].decode("utf-8")
        entry = {"file": COMPONENTS + name, "sha256": sha256(sources[name]),
                 "imports": [f"{m} {v}" for m, v in qml_imports(text)], "loads": LOADS[name]}
        missing_loads = [f for f in LOADS[name] if COMPONENTS + f not in out_data]
        for loaded in LOADS[name]:
            as_type = loaded.endswith(".qml") and re.search(r"^\s*" + re.escape(loaded[:-4]) + r"\s*\{", text, re.M)
            if f'"{loaded}"' not in text and not as_type:
                problems.append(f"{name}: expected reference to {loaded} not found")
        if missing_loads:
            problems.append(f"{name} loads missing members: {missing_loads}")
        if args.sysroot:
            missing = [f"{m} {v}" for m, v in qml_imports(text) if not module_available(args.sysroot, m, v)]
            entry["imports_missing_on_dash"] = missing
            problems.extend(f"{name} imports {item}, not installed on the dash" for item in missing)
        component_checks.append(entry)
    if not args.sysroot:
        problems.append("No --sysroot given: QML imports were not checked against the dash")
    problems.extend(f"self-check failed: {name}" for name, ok in checks.items() if not ok)

    nex_sha = sha256(nex_path.read_bytes())
    for name in REPLACED + ADDED:
        (args.output / name).write_bytes(sources[name])
    report = {
        "status": "EXPERIMENTAL, offline-validated only; not installed or tested on a physical dash",
        "built_utc": datetime.datetime.now(datetime.timezone.utc).isoformat(timespec="seconds"),
        "base": {"path": shown(args.base), "sha256": sha256(base_bytes)},
        "stock": {"path": shown(args.stock), "sha256": sha256(stock_bytes)},
        "output": {"path": shown(nex_path), "sha256": nex_sha, "bytes": nex_path.stat().st_size},
        "addon_member_mtimes": {COMPONENTS + n: mtimes[n] for n in REPLACED + ADDED},
        "replaced_members": [COMPONENTS + n for n in REPLACED],
        "added_members": [COMPONENTS + n for n in ADDED],
        "archive_members": {"base": len(base_data), "output": len(out_data), "stock": len(stock_data)},
        "vs_base": {"changed": vs_base_changed, "added": vs_base_added, "removed": vs_base_removed},
        "vs_stock": {"changed": vs_stock_changed, "added": vs_stock_added, "removed": vs_stock_removed},
        "base_members_with_stock_mtime": stale_base,
        "checks": checks,
        "component_checks": component_checks,
        "problems": problems,
        "suitable": not problems,
    }
    if stale_base:
        report["warnings"] = [
            "The base NEX replaced these members but kept the stock mtime, so a stale Qt QML disk "
            "cache could run old code for them (not changed here; the base is copied verbatim): "
            + ", ".join(stale_base)]
    audit = {key: report[key] for key in ("base", "output", "vs_base", "vs_stock", "checks",
                                          "component_checks", "problems", "suitable")}
    (args.output / "build-report.json").write_text(json.dumps(report, indent=2) + "\n")
    (args.output / "audit-report.json").write_text(json.dumps(audit, indent=2) + "\n")
    print(json.dumps(report, indent=2))
    return 0 if not problems else 1


if __name__ == "__main__":
    sys.exit(main())
