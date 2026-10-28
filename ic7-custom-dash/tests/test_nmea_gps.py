#!/usr/bin/env python3
"""Feed checked and rejected NMEA sentences to the desktop app over a PTY."""

import argparse
import os
from pathlib import Path
import pty
import shutil
import signal
import subprocess
import tempfile
import time


def nmea(body: str) -> bytes:
    checksum = 0
    for byte in body.encode("ascii"):
        checksum ^= byte
    return f"${body}*{checksum:02X}\r\n".encode("ascii")


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument(
        "--app",
        type=Path,
        default=Path(__file__).resolve().parents[1] / "build-linux" / "ic7dash",
    )
    parser.add_argument(
        "--assets-dir",
        type=Path,
        default=Path(__file__).resolve().parents[1],
        help="directory containing emtron_can.json, bg.gif and tiles/",
    )
    parser.add_argument("--sysroot", type=Path)
    args = parser.parse_args()
    app = args.app.resolve()
    if not app.is_file():
        parser.error(f"application does not exist: {app}")
    sysroot = args.sysroot.resolve() if args.sysroot else None
    if sysroot and not (sysroot / "usr/lib/libQt5SerialPort.so.5").exists():
        parser.error(f"Qt SerialPort target library not found in {sysroot}")
    assets_dir = args.assets_dir.resolve()
    can_config = assets_dir / "resources/emtron_can.json"
    if not can_config.is_file():
        can_config = assets_dir / "emtron_can.json"
    if sysroot:
        required_assets = (
            can_config,
            assets_dir / "bg.gif",
            assets_dir / "tiles",
        )
        missing_assets = [path for path in required_assets if not path.exists()]
        if missing_assets:
            parser.error(
                "target test assets are missing: "
                + ", ".join(str(path) for path in missing_assets)
            )

    with tempfile.TemporaryDirectory(prefix="ic7-nmea-test-") as directory:
        test_dir = Path(directory)
        if sysroot:
            app_dir = test_dir / "app"
            app_dir.mkdir()
            shutil.copy2(app, app_dir / "ic7dash")
            shutil.copy2(can_config, app_dir / "emtron_can.json")
            shutil.copy2(assets_dir / "bg.gif", app_dir)
            shutil.copytree(assets_dir / "tiles", app_dir / "tiles")
            app = app_dir / "ic7dash"
        runtime = test_dir / "runtime"
        runtime.mkdir(mode=0o700)
        log_path = test_dir / "app.log"
        master, slave = pty.openpty()
        device = os.ttyname(slave)
        env = os.environ.copy()
        env.update({
            "IC7_SIM_GPS": "0",
            "IC7_GPS_DEVICE": device,
            "IC7_BG": "map",
            "XDG_RUNTIME_DIR": str(runtime),
            "LIBGL_ALWAYS_SOFTWARE": "1",
        })

        with log_path.open("w+", encoding="utf-8") as log:
            if sysroot:
                command = [
                    "qemu-arm", "-L", str(sysroot),
                    "-E", "QT_QPA_PLATFORM=offscreen",
                    "-E", "QT_QUICK_BACKEND=software",
                    "-E", f"QT_PLUGIN_PATH={sysroot}/usr/lib/plugins",
                    "-E", f"QML2_IMPORT_PATH={sysroot}/usr/lib/qml",
                    str(app),
                ]
            else:
                command = ["xvfb-run", "-a", str(app)]

            process = subprocess.Popen(
                command,
                cwd=app.parent,
                env=env,
                stdout=log,
                stderr=subprocess.STDOUT,
            )
            try:
                time.sleep(1)
                bad_fix = bytearray(nmea(
                    "GPRMC,123519,A,2941.418,S,15256.000,E,0.0,0.0,230326,,,A"
                ))
                bad_fix[-4] = ord("0") if bad_fix[-4] != ord("0") else ord("1")
                valid_fix = nmea(
                    "GPRMC,123519,A,2941.418,S,15256.000,E,0.0,0.0,230326,,,A"
                )
                os.write(master, bad_fix)
                time.sleep(0.3)
                log.flush()
                if "GPS: first valid NMEA fix" in log_path.read_text(encoding="utf-8"):
                    raise RuntimeError("corrupted-checksum sentence was accepted")

                deadline = time.monotonic() + 8
                while time.monotonic() < deadline:
                    if process.poll() is not None:
                        raise RuntimeError(f"dash exited unexpectedly ({process.returncode})")
                    os.write(master, valid_fix)
                    time.sleep(0.25)
                    log.flush()
                    if "GPS: first valid NMEA fix" in log_path.read_text(encoding="utf-8"):
                        break
                output = log_path.read_text(encoding="utf-8")
                if "GPS: first valid NMEA fix -29.690300 152.933333" not in output:
                    raise RuntimeError("valid Grafton fix was not accepted:\n" + output)
                qml_failures = [
                    line for line in output.splitlines()
                    if "qrc:/qml/" in line and (
                        "error" in line.lower() or "failed" in line.lower()
                    )
                ]
                if qml_failures:
                    raise RuntimeError("QML emitted an error:\n" + "\n".join(qml_failures))
                print("PASS: checksummed NMEA RMC fix reached the app at Grafton (-29.6903, 152.9333)")
                print("PASS: corrupted-checksum sentence was ignored")
                return 0
            finally:
                if process.poll() is None:
                    process.send_signal(signal.SIGTERM)
                    try:
                        process.wait(timeout=5)
                    except subprocess.TimeoutExpired:
                        process.kill()
                        process.wait()
                os.close(master)
                os.close(slave)


if __name__ == "__main__":
    raise SystemExit(main())