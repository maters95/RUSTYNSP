#!/usr/bin/env python3
"""Package a Windows NSP media-import and dash-disconnected NEX test bundle."""

import argparse
from datetime import datetime, timezone
import hashlib
import json
import os
from pathlib import Path
import struct
import tempfile
import zipfile


ROOT = Path(__file__).resolve().parents[1]
MEDIA_DIR = ROOT / "ic7-custom-dash/build-cfw-media-mapfix-alias"
MEDIA_NEX = MEDIA_DIR / "ic7-2.36-media-cfw-mapfix-alias-experimental.nex"
BUILD_REPORT = MEDIA_DIR / "build-report.json"
MAP_ARCHIVE = ROOT / "dist/ic7-nsp-media-map-test.zip"
MAP_NAME = "zak-2.36-mapfix-media-picker-uservideo.nexmap"
GUIDE = ROOT / "ic7-custom-dash/deploy/nsp/NSP-INTEGRATION-TEST.md"


def sha256(path: Path) -> str:
    digest = hashlib.sha256()
    with path.open("rb") as source:
        for block in iter(lambda: source.read(1024 * 1024), b""):
            digest.update(block)
    return digest.hexdigest()


def validate_nsp_dll(path: Path) -> None:
    with path.open("rb") as source:
        if source.read(2) != b"MZ":
            raise ValueError(f"NSP DLL is not a PE file: {path}")
        source.seek(0x3C)
        pe_offset_data = source.read(4)
        if len(pe_offset_data) != 4:
            raise ValueError(f"NSP DLL has a truncated PE header: {path}")
        source.seek(struct.unpack("<I", pe_offset_data)[0])
        if source.read(4) != b"PE\0\0":
            raise ValueError(f"NSP DLL has an invalid PE signature: {path}")
        machine_data = source.read(2)
    if len(machine_data) != 2 or struct.unpack("<H", machine_data)[0] != 0x14C:
        raise ValueError(f"NSP DLL must target Windows x86: {path}")
    assembly = path.read_bytes()
    for resource in (ROOT / "nsp-rebuild").glob("*.resx"):
        name = resource.stem + ".resources"
        if name.encode("utf-8") + b"\0" not in assembly:
            raise ValueError(f"NSP DLL is missing required form resource: {name}")


def validate_inputs(nsp_dll: Path, media_nex: Path = MEDIA_NEX,
                    build_report: Path = BUILD_REPORT, guide: Path = GUIDE) -> None:
    for path in (media_nex, build_report, MAP_ARCHIVE, guide):
        if not path.is_file():
            raise FileNotFoundError(f"required test-bundle input is missing: {path}")
    validate_nsp_dll(nsp_dll)

    with build_report.open(encoding="utf-8") as source:
        report = json.load(source)
    expected_hash = report["packages"][media_nex.name]["sha256"]
    if sha256(media_nex) != expected_hash:
        raise ValueError("media NEX does not match its build report")
    if report["changed_members"] != [
        "qml_components_data/qml/user_components/HalImage.qml"
    ] or report["preserved_members"] != 338:
        raise ValueError("NEX build report does not describe the resource-only patch")
    with zipfile.ZipFile(media_nex) as nex:
        if nex.testzip() is not None:
            raise ValueError("media NEX ZIP integrity check failed")
        if set(nex.namelist()) != {"manifest.xml", "res_ic-7.qzip", "ic-7.hdef"}:
            raise ValueError("media NEX contains an unexpected payload set")
        if b'res_ic-7.qzip' not in nex.read("manifest.xml"):
            raise ValueError("media NEX manifest does not reference its resource stage")

    with zipfile.ZipFile(MAP_ARCHIVE) as maps:
        if maps.testzip() is not None:
            raise ValueError("NSP map test archive integrity check failed")
        if MAP_NAME not in maps.namelist():
            raise ValueError(f"NSP map test archive is missing {MAP_NAME}")


def validate_native_component(nsp_dll: Path, media_nex: Path, build_report: Path) -> str:
    component = (media_nex.parent / "HalImage.qml").read_bytes()
    report = json.loads(build_report.read_text(encoding="utf-8"))
    component_hash = hashlib.sha256(component).hexdigest()
    if component_hash != report["replacement_component_sha256"]:
        raise ValueError("native media component does not match the NEX build report")
    if component != (GUIDE.parent / "HalImage.qml").read_bytes():
        raise ValueError("native media candidate is stale relative to maintained QML")
    resource_blob = struct.pack("<I", len(component)) + component
    if nsp_dll.read_bytes().count(resource_blob) != 1:
        raise ValueError("NSP DLL does not contain the matching embedded media component")
    return component_hash


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--nsp-dll", required=True, type=Path)
    parser.add_argument("--output", required=True, type=Path)
    parser.add_argument("--media-nex", type=Path, default=MEDIA_NEX)
    parser.add_argument("--build-report", type=Path, default=BUILD_REPORT)
    parser.add_argument("--native-media", action="store_true",
                        help="Include native renderer setup and pinned Qt download metadata")
    args = parser.parse_args()
    nsp_dll = args.nsp_dll.resolve()
    output = args.output.resolve()
    if output.exists():
        parser.error(f"refusing to overwrite existing output: {output}")
    guide = GUIDE.with_name("NATIVE-MEDIA-TEST.md") if args.native_media else GUIDE
    validate_inputs(nsp_dll, args.media_nex, args.build_report, guide)
    component_hash = (
        validate_native_component(nsp_dll, args.media_nex, args.build_report)
        if args.native_media else None
    )

    output.parent.mkdir(parents=True, exist_ok=True)
    temporary_path = None
    try:
        with tempfile.NamedTemporaryFile(
            prefix=f".{output.name}.", suffix=".tmp", dir=output.parent, delete=False
        ) as temporary:
            temporary_path = Path(temporary.name)

        entries = []
        with zipfile.ZipFile(temporary_path, "w", allowZip64=True) as archive:
            files = [
                (guide, "README.md"),
                (nsp_dll, "NSP-test/NSP.dll"),
                (args.media_nex, "firmware/" + args.media_nex.name),
                (args.build_report, "firmware/build-report.json"),
            ]
            if args.native_media:
                files.extend([
                    (GUIDE.with_name("setup-native-media.ps1"), "setup-native-media.ps1"),
                    (GUIDE.with_name("collect-native-media-evidence.ps1"),
                     "collect-native-media-evidence.ps1"),
                    (GUIDE.with_name("test-native-video.ps1"), "test-native-video.ps1"),
                    (GUIDE.with_name("qt5113-runtime.json"), "qt5113-runtime.json"),
                    (args.media_nex.parent / "HalImage.qml", "firmware/HalImage.qml"),
                ])
                for name in ("animated.gif", "static.png", "video.mp4"):
                    files.append((
                        ROOT / "ic7-custom-dash/build-nsp-tests" / name,
                        "samples/" + name,
                    ))
            for source, destination in files:
                archive.write(source, destination, compress_type=zipfile.ZIP_STORED)
                entries.append({
                    "path": destination,
                    "bytes": source.stat().st_size,
                    "sha256": sha256(source),
                })

            map_digest = hashlib.sha256()
            map_size = 0
            with zipfile.ZipFile(MAP_ARCHIVE) as maps:
                with maps.open(MAP_NAME) as source, archive.open(
                    "map/" + MAP_NAME, "w"
                ) as destination:
                    while block := source.read(1024 * 1024):
                        destination.write(block)
                        map_digest.update(block)
                        map_size += len(block)
            entries.append({
                "path": "map/" + MAP_NAME,
                "bytes": map_size,
                "sha256": map_digest.hexdigest(),
            })

            manifest = {
                "package_type": "dash-disconnected NSP integration test; not firmware",
                "nsp_version_target": "1.48.5",
                "firmware_reference": "Haltech iC-7 v2.36",
                "created_utc": datetime.now(timezone.utc).isoformat(),
                "physical_installation_tested": False,
                "native_renderer": args.native_media,
                "component_sha256": component_hash,
                "artifacts": entries,
            }
            manifest_bytes = (json.dumps(manifest, indent=2) + "\n").encode()
            archive.writestr("test-manifest.json", manifest_bytes)
            checksums = [f"{entry['sha256']}  {entry['path']}" for entry in entries]
            checksums.append(
                f"{hashlib.sha256(manifest_bytes).hexdigest()}  test-manifest.json"
            )
            archive.writestr("SHA256SUMS", "\n".join(checksums) + "\n")

        with zipfile.ZipFile(temporary_path) as archive:
            if archive.testzip() is not None:
                raise ValueError("generated NSP integration ZIP failed integrity validation")
        os.link(temporary_path, output)
    finally:
        if temporary_path and temporary_path.exists():
            temporary_path.unlink()

    print(f"NSP integration test: {output} ({output.stat().st_size} bytes)")
    print(f"sha256: {sha256(output)}")
    print(f"included files: {len(entries)}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
