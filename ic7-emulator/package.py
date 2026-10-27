import argparse
import hashlib
import json
from pathlib import Path
import zipfile


def main():
    root = Path(__file__).resolve().parent
    parser = argparse.ArgumentParser(description="Package the Windows iC-7 emulator.")
    parser.add_argument("--output", type=Path,
                        default=root.parent / "dist" / "ic7-emulator-windows.zip")
    destination = parser.parse_args().output.resolve()
    destination.parent.mkdir(parents=True, exist_ok=True)
    included = []
    with zipfile.ZipFile(destination, "w", compression=zipfile.ZIP_DEFLATED) as archive:
        for source in sorted(root.rglob("*")):
            relative = source.relative_to(root)
            if not source.is_file() or any(part in ("__pycache__", "state", "sandbox-state", "workbench-state", ".venv") for part in relative.parts):
                continue
            if source.name.startswith("port-") or source.suffix in (".pyc", ".jsc", ".qmlc"):
                continue
            archive.write(source, "ic7-emulator/" + relative.as_posix())
            included.append(relative.as_posix())
    with zipfile.ZipFile(destination) as archive:
        if archive.testzip() is not None:
            raise ValueError("Distribution integrity check failed")
    report = {"file": destination.name, "bytes": destination.stat().st_size,
              "sha256": hashlib.sha256(destination.read_bytes()).hexdigest(), "files": len(included),
              "status": "Main/boot identity and exact-package resource sandbox locally tested; Windows NSP update retest, target decryption, hardware flash and recovery unverified"}
    destination.with_suffix(".json").write_text(json.dumps(report, indent=2) + "\n", encoding="utf-8")
    print(json.dumps(report, indent=2))


if __name__ == "__main__":
    main()