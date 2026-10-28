#!/usr/bin/env python3
"""Assemble a non-flashable iC-7 media/map bench-test kit."""

import argparse
from datetime import datetime, timezone
import hashlib
import json
import os
from pathlib import Path
import tarfile
import tempfile
import zipfile


ROOT = Path(__file__).resolve().parents[1]


def sha256(path: Path) -> str:
    digest = hashlib.sha256()
    with path.open("rb") as source:
        for block in iter(lambda: source.read(1024 * 1024), b""):
            digest.update(block)
    return digest.hexdigest()


def add_file(archive: zipfile.ZipFile, source: Path, destination: str) -> dict:
    if not source.is_file():
        raise FileNotFoundError(f"required test-kit input is missing: {source}")
    archive.write(source, destination, compress_type=zipfile.ZIP_STORED)
    return {
        "path": destination,
        "bytes": source.stat().st_size,
        "sha256": sha256(source),
    }


def validate_inputs() -> tuple[Path, Path, Path, Path]:
    media_dir = ROOT / "ic7-custom-dash/build-cfw-media-mapfix-alias"
    media_nex = media_dir / "ic7-2.36-media-cfw-mapfix-alias-experimental.nex"
    report_path = media_dir / "build-report.json"
    with report_path.open(encoding="utf-8") as report_file:
        report = json.load(report_file)
    media_digest = report["packages"][media_nex.name]["sha256"]
    if sha256(media_nex) != media_digest:
        raise ValueError("media NEX does not match its offline build report")
    if report["changed_members"] != [
        "qml_components_data/qml/user_components/HalImage.qml"
    ] or report["preserved_members"] != 338:
        raise ValueError("media NEX report does not describe the expected resource-only patch")
    with zipfile.ZipFile(media_nex) as package:
        if package.testzip() is not None:
            raise ValueError("media NEX ZIP integrity check failed")
        expected = {"manifest.xml", "res_ic-7.qzip", "ic-7.hdef"}
        if set(package.namelist()) != expected:
            raise ValueError("media NEX contains an unexpected payload set")

    map_test = ROOT / "dist/ic7-nsp-media-map-test.zip"
    with zipfile.ZipFile(map_test) as package:
        if package.testzip() is not None:
            raise ValueError("NSP map test archive integrity check failed")
        if "zak-2.36-mapfix-media-picker-uservideo.nexmap" not in package.namelist():
            raise ValueError("NSP map test archive is missing the expected test map")

    app_bundle = ROOT / "ic7-custom-dash/build-arm/ic7dash-arm-bundle.tar.gz"
    with tarfile.open(app_bundle, "r:gz") as package:
        names = {member.name for member in package.getmembers() if member.isfile()}
        if not any(name.endswith("/ic7dash") for name in names):
            raise ValueError("ARM app bundle does not contain ic7dash")
        if not any(name.endswith("/tiles/ATTRIBUTION.txt") for name in names):
            raise ValueError("ARM app bundle is missing the map attribution file")
        if any(name.lower().endswith((".swu", ".img", ".ext4")) for name in names):
            raise ValueError("ARM app bundle unexpectedly contains firmware or disk images")
    return media_nex, report_path, map_test, app_bundle


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument(
        "--output",
        type=Path,
        default=ROOT / "dist/ic7-cfw-bench-test-kit-2.36.zip",
    )
    args = parser.parse_args()
    output = args.output.resolve()
    if output.exists():
        parser.error(f"refusing to overwrite existing output: {output}")

    media_nex, report_path, map_test, app_bundle = validate_inputs()
    files = [
        (ROOT / "ic7-custom-dash/deploy/CFW-TEST-KIT.md", "README.md"),
        (media_nex, "media/" + media_nex.name),
        (ROOT / "ic7-custom-dash/build-cfw-media-mapfix-alias/HalImage.qml",
         "media/HalImage.qml"),
        (report_path, "media/build-report.json"),
        (map_test, "map/ic7-nsp-media-map-test.zip"),
        (app_bundle, "app/ic7dash-arm-bundle.tar.gz"),
        (ROOT / "ic7-custom-dash/deploy/NEXMAP-INTEGRATION.md",
         "docs/NEXMAP-INTEGRATION.md"),
        (ROOT / "ic7-custom-dash/deploy/USB-INSTALL.md", "docs/USB-INSTALL.md"),
        (ROOT / "ic7-custom-dash/deploy/nsp/MEDIA-MAP-TEST.md",
         "docs/MEDIA-MAP-TEST.md"),
        (ROOT / "ic7-custom-dash/deploy/CROSS-BUILD.md", "docs/CROSS-BUILD.md"),
        (ROOT / "ic7-custom-dash/tests/test_nmea_gps.py", "tests/test_nmea_gps.py"),
        (ROOT / "ic7-custom-dash/deploy/qemu-smoke-test.sh",
         "tests/qemu-smoke-test.sh"),
    ]
    for source, _ in files:
        if not source.is_file():
            raise FileNotFoundError(f"required test-kit input is missing: {source}")

    output.parent.mkdir(parents=True, exist_ok=True)
    temporary_path = None
    try:
        with tempfile.NamedTemporaryFile(
            prefix=f".{output.name}.", suffix=".tmp", dir=output.parent, delete=False
        ) as temporary:
            temporary_path = Path(temporary.name)

        entries = []
        with zipfile.ZipFile(temporary_path, "w", allowZip64=True) as archive:
            for source, destination in files:
                entries.append(add_file(archive, source, destination))
            manifest = {
                "package_type": "bench-test kit; not firmware and not flashable",
                "firmware_reference": "Haltech iC-7 v2.36",
                "created_utc": datetime.now(timezone.utc).isoformat(),
                "contains_grafton_map_tiles": False,
                "contains_physical_installation_instructions": False,
                "artifacts": entries,
            }
            archive.writestr(
                "test-kit-manifest.json",
                json.dumps(manifest, indent=2) + "\n",
                compress_type=zipfile.ZIP_DEFLATED,
            )
            checksum_lines = [
                f"{entry['sha256']}  {entry['path']}" for entry in entries
            ]
            checksum_lines.append(
                f"{hashlib.sha256(json.dumps(manifest, sort_keys=True).encode()).hexdigest()}  "
                "test-kit-manifest.json (canonical JSON)"
            )
            archive.writestr(
                "SHA256SUMS",
                "\n".join(checksum_lines) + "\n",
                compress_type=zipfile.ZIP_DEFLATED,
            )

        with zipfile.ZipFile(temporary_path) as archive:
            if archive.testzip() is not None:
                raise ValueError("generated test-kit ZIP failed integrity validation")
        os.link(temporary_path, output)
    finally:
        if temporary_path and temporary_path.exists():
            temporary_path.unlink()

    print(f"test kit: {output} ({output.stat().st_size} bytes)")
    print(f"sha256: {sha256(output)}")
    print(f"included files: {len(entries)}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
