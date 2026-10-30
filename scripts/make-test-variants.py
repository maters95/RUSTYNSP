"""Assemble interchangeable test variants (and a stock base) from the verified builds.

Each variant folder holds only the files that are swapped between tests: the
NEX to flash, the NSP.dll to run in the test NSP copy, and the user-resource
manifests/media to upload. Everything is copied byte-for-byte from its tracked
source and listed with its SHA-256 in variants.json and SHA256SUMS.

    python scripts/make-test-variants.py [--output test-variants]
"""
import argparse
import hashlib
import json
from pathlib import Path
import shutil
import subprocess
import sys

ROOT = Path(__file__).resolve().parents[1]
R3 = ROOT / "ic7-custom-dash/build-cfw-screen-alarms-r3-236"
ADDONS = ROOT / "ic7-custom-dash/build-addons-experimental-236"
SAMPLES = ROOT / "ic7-custom-dash/deploy/addons/samples/upload"
HELPER = ROOT / "ic7-custom-dash/deploy/addons/make-addon-manifests.py"
REBUILT_DLL = ROOT / "nsp-rebuild/bin/Release/net9.0-windows10.0.19041.0/NSP.dll"

VARIANTS = {
    "0-base-stock": {
        "purpose": "Stock baseline and rollback. Flash the stock-resources NEX (resource-only, "
                   "restores the stock QML) or the full Haltech NEX; run the OEM NSP.dll.",
        "files": {
            "firmware/Dash-V2-36-0-Release.nex": ROOT / "fw/Dash-V2-36-0-Release.nex",
            "firmware/ic7-2.36-stock-resources.nex": R3 / "ic7-2.36-stock-resources-experimental.nex",
            "nsp/NSP.dll": ROOT / "reference/stock-dash-extract/NSP.dll",
        },
    },
    "1-splash-alarms-r4": {
        "purpose": "GIF/MP4 splash and per-screen alarm media (the r4 kit's NEX and DLL). "
                   "Upload the map's resources from NSP as usual.",
        "files": {
            "firmware/ic7-2.36-screen-alarms-experimental.nex": R3 / "ic7-2.36-screen-alarms-experimental.nex",
            "firmware/build-report.json": R3 / "build-report.json",
            "firmware/audit-report.json": R3 / "audit-report.json",
            "nsp/NSP.dll": REBUILT_DLL,
        },
    },
    "2-addons-experimental": {
        "purpose": "Variant 1 plus the experimental gauge add-ons. Upload the 'on' manifests and "
                   "media to enable them; upload the 'off' manifests and power-cycle to disable.",
        "files": {
            "firmware/ic7-2.36-addons-experimental.nex": ADDONS / "ic7-2.36-addons-experimental.nex",
            "firmware/build-report.json": ADDONS / "build-report.json",
            "nsp/NSP.dll": REBUILT_DLL,
            **{f"upload-on/{path.name}": path for path in sorted(SAMPLES.iterdir()) if path.is_file()},
        },
        # Written by the add-on helper so they always match what the add-ons accept.
        "off_manifests": "upload-off",
    },
}


def sha256(data):
    return hashlib.sha256(data).hexdigest()


def main():
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("--output", type=Path, default=ROOT / "test-variants")
    parser.add_argument("--preserve", type=Path, action="append", default=[],
                        help="Extra file to keep under preserved/ (e.g. an alternative DLL build)")
    args = parser.parse_args()

    commit = subprocess.run(["git", "rev-parse", "--short", "HEAD"], cwd=ROOT,
                            capture_output=True, text=True, check=True).stdout.strip()
    index, sums = {"source_commit": commit, "variants": {}}, []
    for name, variant in VARIANTS.items():
        entries = {}
        for relative, source in variant["files"].items():
            data = source.read_bytes()
            target = args.output / name / relative
            target.parent.mkdir(parents=True, exist_ok=True)
            target.write_bytes(data)
            entries[relative] = {"source": source.relative_to(ROOT).as_posix(), "sha256": sha256(data)}
        if "off_manifests" in variant:
            folder = args.output / name / variant["off_manifests"]
            shutil.rmtree(folder, ignore_errors=True)
            subprocess.run([sys.executable, str(HELPER), "--off", "all", "--output", str(folder)],
                           cwd=ROOT, check=True, capture_output=True)
            for path in sorted(folder.iterdir()):
                entries[f"{variant['off_manifests']}/{path.name}"] = {
                    "source": "make-addon-manifests.py --off all", "sha256": sha256(path.read_bytes())}
        index["variants"][name] = {"purpose": variant["purpose"], "files": entries}
        sums += [f"{entry['sha256']}  {name}/{relative}" for relative, entry in entries.items()]
    # preserved/ is never cleared: earlier preserved builds stay listed on every regeneration.
    preserved = args.output / "preserved"
    for source in args.preserve:
        target = preserved / source.name
        target.parent.mkdir(parents=True, exist_ok=True)
        if source.resolve() != target.resolve():
            shutil.copyfile(source, target)
    if preserved.is_dir():
        sums += [f"{sha256(path.read_bytes())}  preserved/{path.name}"
                 for path in sorted(preserved.iterdir()) if path.is_file()]
    (args.output / "variants.json").write_text(json.dumps(index, indent=2) + "\n")
    (args.output / "SHA256SUMS").write_text("\n".join(sorted(sums, key=lambda line: line[66:])) + "\n")
    print(json.dumps(index, indent=2))


if __name__ == "__main__":
    main()
