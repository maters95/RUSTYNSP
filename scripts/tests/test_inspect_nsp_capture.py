import importlib.util
from pathlib import Path
import struct
import unittest
from unittest.mock import Mock, patch
import zlib


SCRIPT = Path(__file__).resolve().parents[1] / "inspect-nsp-capture.py"
SPEC = importlib.util.spec_from_file_location("inspect_nsp_capture", SCRIPT)
INSPECTOR = importlib.util.module_from_spec(SPEC)
SPEC.loader.exec_module(INSPECTOR)


class CaptureReportTests(unittest.TestCase):
    def test_tshark_path_is_passed_to_subprocess(self):
        payload = b"test"
        packet = (b"\x01\x07" + (0x20000).to_bytes(6, "big") +
                  struct.pack(">I", len(payload)) + payload)
        packet += zlib.crc32(packet).to_bytes(4, "big")
        with patch.object(INSPECTOR.subprocess, "run", return_value=Mock(
                stdout=f"9\t1.5\t{packet.hex()}\n")) as run:
            counts, write_bytes, segments = INSPECTOR.inspect_capture(
                Path("capture.pcapng"), 2, 4, r"C:\Program Files\Wireshark\tshark.exe")
        self.assertEqual(run.call_args.args[0][0], r"C:\Program Files\Wireshark\tshark.exe")
        self.assertEqual(counts["write"], 1)
        self.assertEqual(write_bytes, len(payload))
        self.assertEqual(bytes(segments[0]["data"]), payload)

    def test_known_regions_are_described_conservatively(self):
        settings = INSPECTOR.describe_segment({
            "address": 0x00020000,
            "first_frame": 1,
            "last_frame": 1,
            "first_seconds": 0.0,
            "last_seconds": 0.0,
            "commands": 1,
            "data": bytearray(b"settings"),
        })
        bitmap = INSPECTOR.describe_segment({
            "address": 0x70400000,
            "first_frame": 2,
            "last_frame": 2,
            "first_seconds": 1.0,
            "last_seconds": 1.0,
            "commands": 1,
            "data": bytearray(b"BM" + bytes(20)),
        })
        self.assertEqual(settings["classification"], "previously-observed-settings-region")
        self.assertEqual(bitmap["classification"], "previously-observed-bitmap-transfer")

    def test_large_unknown_write_is_not_called_firmware(self):
        segment = INSPECTOR.describe_segment({
            "address": 0x26000000,
            "first_frame": 3,
            "last_frame": 4,
            "first_seconds": 2.0,
            "last_seconds": 2.1,
            "commands": 2,
            "data": bytearray(1024 * 1024),
        })
        self.assertEqual(segment["classification"], "large-unclassified-write")

    def test_summary_explicitly_disclaims_completion(self):
        segment = {
            "address": "0x20000", "length": 8, "commands": 1,
            "first_frame": 1, "last_frame": 1, "first_seconds": 0.0,
            "last_seconds": 0.0, "format": "unidentified",
            "classification": "previously-observed-settings-region",
        }
        report = {
            "capture": "trace.pcapng", "bus": 2, "device": 4,
            "commands": {"read": 1, "write": 0}, "write_payload_bytes": 0,
            "segments": [segment, {**segment, "first_frame": 2, "last_frame": 2,
                                   "first_seconds": 1.0, "last_seconds": 1.0}],
            "scope": {"device_responses_analyzed": False,
                      "flash_or_settings_completion_verified": False},
            "warnings": [],
        }
        summary = INSPECTOR.summarize(report)
        self.assertFalse(summary["scope"]["device_responses_analyzed"])
        self.assertFalse(summary["scope"]["flash_or_settings_completion_verified"])
        self.assertEqual(len(summary["write_regions"]), 1)
        self.assertEqual(summary["write_regions"][0]["segments"], 2)


if __name__ == "__main__":
    unittest.main()