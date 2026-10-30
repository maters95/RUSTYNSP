"""Combine the NSP test kit and Windows emulator into one checksummed test package."""
import argparse
import hashlib
import json
from pathlib import Path
import zipfile

ROOT = Path(__file__).resolve().parents[1]
START_EMULATOR = '@echo off\ncd /d "%~dp0ic7-emulator"\ncall start-workbench.cmd %*\n'
LIMITATIONS = [
    "Windows NSP/serial/Qt plugin acceptance not performed here",
    "No ARM application, kernel, bootloader or STM32 execution",
    "No physical flash, recovery or safety certification",
    "No CAN/ECU acquisition, LEDs, physical controls or USB re-enumeration",
    "Live alarm parity requires matching maps and NSP publishing live/Simulate data",
]


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--nsp-kit", required=True, type=Path,
                        help="ZIP from package-nsp-media-test.py --native-media --splash --alerts")
    parser.add_argument("--emulator", required=True, type=Path, help="ZIP from ic7-emulator/package.py")
    parser.add_argument("--guide", type=Path, default=ROOT / "ic7-custom-dash/deploy/nsp/FINAL-START-HERE.md")
    parser.add_argument("--checks", required=True, type=Path,
                        help="JSON object of local verification results to record")
    parser.add_argument("--audit", type=Path, help="scripts/audit-nex.py report for the candidate NEX")
    parser.add_argument("--output", required=True, type=Path)
    args = parser.parse_args()

    files = {}
    with zipfile.ZipFile(args.nsp_kit) as kit:
        for name in kit.namelist():
            files["NSP-test-kit/" + name] = kit.read(name)
    with zipfile.ZipFile(args.emulator) as emulator:
        for name in emulator.namelist():
            if not name.startswith("ic7-emulator/"):
                raise ValueError("Unexpected emulator member: " + name)
            files[name] = emulator.read(name)
    firmware = [name for name in files
                if name.startswith("NSP-test-kit/firmware/") and name.endswith("-experimental.nex")]
    if len(firmware) != 1:
        raise ValueError("Expected exactly one candidate NEX in the NSP kit")
    report = json.loads(files["NSP-test-kit/firmware/build-report.json"])
    package = report["packages"][Path(firmware[0]).name]
    if hashlib.sha256(files[firmware[0]]).hexdigest() != package["sha256"]:
        raise ValueError("Candidate NEX does not match its build report")
    for name, checksum in report["runtime_components"].items():
        if hashlib.sha256(files["NSP-test-kit/firmware/" + name]).hexdigest() != checksum:
            raise ValueError("Packaged component does not match the build report: " + name)

    if args.audit:
        audit = json.loads(args.audit.read_text(encoding="utf-8"))
        if not audit.get("suitable") or audit.get("candidate_sha256") != package["sha256"]:
            raise ValueError("The NEX audit report does not pass for this exact candidate")
        files["NSP-test-kit/firmware/audit-report.json"] = args.audit.read_bytes()

    files["START-HERE.md"] = args.guide.read_bytes()
    files["START-EMULATOR.cmd"] = START_EMULATOR.encode()
    files["validation-report.json"] = (json.dumps({
        "kit": args.output.stem,
        "status": "locally verified test kit; Windows and physical hardware acceptance pending",
        "checks": json.loads(args.checks.read_text(encoding="utf-8")),
        "firmware": {
            "package": firmware[0],
            "sha256": package["sha256"],
            "stock_members_preserved": report["preserved_members"],
            "qml_changed": len(report["changed_members"]),
            "qml_added": len(report["added_members"]),
            "wrapper_and_hdef_identical_to_stock": report["wrapper_preserved"],
            "application_kernel_bootloader_stm32_replaced": False,
            "runtime_components": report["runtime_components"],
        },
        "limitations": LIMITATIONS,
    }, indent=2) + "\n").encode()
    files["SHA256SUMS"] = "".join(
        f"{hashlib.sha256(data).hexdigest()}  {name}\n" for name, data in sorted(files.items())).encode()

    args.output.parent.mkdir(parents=True, exist_ok=True)
    temporary = args.output.with_suffix(".tmp")
    with zipfile.ZipFile(temporary, "w", compression=zipfile.ZIP_DEFLATED) as archive:
        for name in sorted(files):
            archive.writestr(name, files[name])
    with zipfile.ZipFile(temporary) as archive:
        if archive.testzip() is not None:
            raise ValueError("Package integrity check failed")
    temporary.replace(args.output)
    digest = hashlib.sha256(args.output.read_bytes()).hexdigest()
    args.output.with_name(args.output.name + ".sha256").write_text(f"{digest}  {args.output.name}\n")
    print(f"{args.output} ({args.output.stat().st_size} bytes, {len(files)} files)\nsha256: {digest}")


if __name__ == "__main__":
    main()
