"""Replay NSP's requests from real-dash USB captures and diff the emulator's answers.

Only fields that legitimately vary are normalised: memory contents of
non-identity reads (live data and map settings depend on the ECU and map), and
the size/CRC of user resources that were already on the dash before the
capture started (the capture only shows their names). Reboot, restart and
kernel-logo durations are calibrated per capture from the capture's own
timing, because they vary between boots; the live defaults are their medians.
"""
from pathlib import Path
import shutil
import sys
import tempfile
import unittest

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
import capture_replay
import dash_layout
from ic7_emulator import DashTiming, Device, RESOURCE_ADDRESS

REPOSITORY = Path(__file__).resolve().parents[2]
PROFILE = Path(__file__).resolve().parents[1] / "device-profile.zip"
BUILDS = REPOSITORY / "ic7-custom-dash"
CAPTURES = (
    # capture, bus, device, NEX that NSP flashed (selected as the sandbox package)
    ("fail.pcapng", 2, 10, BUILDS / "build-cfw-screen-alarms-236/ic7-2.36-screen-alarms-experimental.nex"),
    ("ic7 real flash cfw.pcapng", 2, 7, BUILDS / "build-cfw-native-media-236/ic7-2.36-native-media-experimental.nex"),
    ("ic7 real flash cfw.pcapng", 2, 8, None),
    ("ic7 real flash cfw.pcapng", 2, 9, None),
    # A full stock update (application stage too), so no resource-only sandbox.
    ("research/usb-captures/firmware updTE.pcapng", 2, 4, None),
    ("research/usb-captures/firmware updTE.pcapng", 2, 5, None),
    ("research/usb-captures/nsp-screen-upload.pcap", 2, 4, None),
    ("research/usb-captures/nsp-screen-upload1.pcap", 2, 4, None),
    ("research/usb-captures/nsp-screen-upload1.pcap", 2, 5, None),
)
RESULTS = {}


def request_fields(packet):
    return packet[0], int.from_bytes(packet[2:8], "big"), packet[12:-4]


def calibrate(exchanges):
    """Per-capture reboot/restart and logo-patch durations from the real answers."""
    timing = DashTiming()
    timing.logo_patches = []
    for index, exchange in enumerate(exchanges):
        opcode, address, payload = request_fields(exchange["request"])
        if opcode == 1 and address == 0 and payload == b"\0\0":
            later = exchanges[index + 1:]
            answered = next((item for item in later if item["response"] is not None), None)
            if answered is None:
                continue
            silent = [item for item in later if item["seconds"] < answered["seconds"] and item["response"] is None]
            last_silent = silent[-1]["seconds"] if silent else exchange["seconds"]
            duration = (last_silent + answered["seconds"]) / 2 - exchange["seconds"]
            if exchange["response"] is not None:
                timing.update_reboot = duration
            else:
                timing.app_restart = min(timing.app_restart, duration)
        if opcode == 1 and address == 0 and payload[:2] == b"\0\x0f" and exchange["response"] is not None:
            if exchange["response"][12:16] == b"\0\0\0\0":
                busy = [item for item in exchanges[:index] if request_fields(item["request"])[2][:2] == b"\0\x0f"]
                started = max(item["seconds"] for item in exchanges[:index]
                              if 0x70400000 <= request_fields(item["request"])[1] < 0x72400000)
                timing.logo_patches.append((busy[-1]["seconds"] + exchange["seconds"]) / 2 - started)
    return timing


def seed_index(device, exchanges):
    """Load the user index the dash already had, from the first listing of each kind."""
    for (kind, name) in [key for key in device.resources.items if key[1].startswith("u/")]:
        del device.resources.items[(kind, name)]
        device.resources.order[kind].remove(name)
    seen = set()
    for exchange in exchanges:
        opcode, address, payload = request_fields(exchange["request"])
        if (address == RESOURCE_ADDRESS and opcode == 1 and len(payload) == 6 and payload[0] == 2 and
                payload[1] not in seen and exchange["response"] is not None):
            seen.add(payload[1])
            body = exchange["response"][13:-4]
            for offset in range(0, len(body), 60):
                name = body[offset:offset + 50].split(b"\0", 1)[0].decode("utf-8")
                device.resources.put(name, payload[1], b"")


def listing(response):
    body = response[13:-4]
    return [(body[offset:offset + 50].split(b"\0", 1)[0].decode("utf-8"), body[offset + 52:offset + 60])
            for offset in range(0, len(body), 60)]


def difference(exchange, emulated, written):
    real = exchange["response"]
    if (real is None) != (emulated is None):
        return "dash " + ("answered" if real is not None else "stayed silent") + ", emulator " + (
            "answered" if emulated is not None else "stayed silent")
    if real is None:
        return None
    if real[:12] != emulated[:12]:
        return f"header {real[:12].hex()} != {emulated[:12].hex()}"
    if len(real) != len(emulated):
        return f"length {len(real)} != {len(emulated)}"
    opcode, address, payload = request_fields(exchange["request"])
    if opcode == 2:
        if address == 0 and real[12:24] != emulated[12:24]:
            return f"identity {real[12:24].hex()} != {emulated[12:24].hex()}"
        return None
    if address == 0 and real[12:-4] != emulated[12:-4]:
        return f"control reply {real[12:-4].hex()} != {emulated[12:-4].hex()}"
    if address == RESOURCE_ADDRESS:
        if real[12] != emulated[12]:
            return f"resource status {real[12]} != {emulated[12]}"
        if payload[0] == 1 and real[13:15] != emulated[13:15]:
            return f"resource count {int.from_bytes(real[13:15], 'big')} != {int.from_bytes(emulated[13:15], 'big')}"
        if payload[0] == 2:
            actual, expected = listing(real), listing(emulated)
            if [name for name, _ in actual] != [name for name, _ in expected]:
                return "resource index order or names differ"
            for (name, real_fields), (_, emulated_fields) in zip(actual, expected):
                if name in written and real_fields != emulated_fields:
                    return f"resource index size/CRC differs for {name}"
    return None


def replay(capture, bus, device_address, package):
    exchanges = capture_replay.extract_exchanges(REPOSITORY / capture, bus, device_address)
    timing = calibrate(exchanges)
    now = [0.0]
    with tempfile.TemporaryDirectory() as temporary:
        device = Device(PROFILE, Path(temporary) / "state", sandbox_package=package, timing=timing,
                        clock=lambda: now[0])
        seed_index(device, exchanges)
        written = set()
        differences = []
        for exchange in exchanges:
            now[0] = exchange["seconds"]
            opcode, address, payload = request_fields(exchange["request"])
            if address == RESOURCE_ADDRESS and opcode == 1 and payload[:1] == b"\x06":
                written.add(payload[4:54].split(b"\0", 1)[0].decode("utf-8"))
            if opcode == 1 and address == 0x70400000 and payload[:2] == b"BM" and timing.logo_patches:
                # Each kernel-logo patch takes its own time; use this burst's.
                device.timing.logo_patch = timing.logo_patches.pop(0)
            emulated = device.respond(exchange["request"])
            problem = difference(exchange, emulated, written)
            if problem:
                differences.append((exchange["frame"], capture_replay.classify(exchange["request"]), problem))
        result = {"exchanges": len(exchanges),
                  "silent": sum(item["response"] is None for item in exchanges),
                  "errors": sum(bool(item["response"] is not None and item["response"][0] & 0x80) for item in exchanges),
                  "differences": differences,
                  "installed_members": device.install.get("member_count"),
                  "lookups": {(Path(entry["component"]).name, entry["manifest"]): entry["status"]
                              for entry in device.fidelity_report()["lookups"]}}
        device.close()
    return result


@unittest.skipUnless(shutil.which("tshark"), "tshark is required to decode the USB captures")
@unittest.skipUnless(dash_layout.find_watchdog(), "the dash watchdog reference is required")
class CaptureConformanceTests(unittest.TestCase):
    maxDiff = None

    def test_emulator_answers_match_the_real_dash(self):
        for capture, bus, device, package in CAPTURES:
            if not (REPOSITORY / capture).is_file() or (package is not None and not package.is_file()):
                continue
            with self.subTest(capture=capture, device=device):
                result = replay(capture, bus, device, package)
                RESULTS[(capture, device)] = result
                print(f"\n{capture} device {device}: {result['exchanges']} exchanges, "
                      f"{result['silent']} unanswered and {result['errors']} error replies on the dash, "
                      f"{len(result['differences'])} differences", file=sys.stderr)
                self.assertEqual(result["differences"][:20], [])
        failed = RESULTS.get(("fail.pcapng", 10))
        if failed is not None:
            # Replaying the failed flash installs its NEX and shows why the dash failed.
            self.assertEqual(failed["installed_members"], 330)
            self.assertEqual(failed["lookups"][("HalSplash.qml", "ic7_splash.json")], "wrong-folder")
            self.assertEqual(failed["lookups"][("HalAlarmPopup.qml", "ic7_alerts.json")], "wrong-folder")


if __name__ == "__main__":
    unittest.main()
