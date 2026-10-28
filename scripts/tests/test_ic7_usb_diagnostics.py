import importlib.util
import json
from pathlib import Path
import shutil
import tempfile
from types import SimpleNamespace
import unittest
from unittest.mock import Mock, patch
import zlib


SPEC = importlib.util.spec_from_file_location(
    "ic7_usb_diagnostics", Path(__file__).resolve().parents[1] / "ic7-usb-diagnostics.py")
DIAG = importlib.util.module_from_spec(SPEC)
SPEC.loader.exec_module(DIAG)


def packet(opcode=2, sequence=1, address=0, length=1024, payload=b""):
    body = DIAG.HEADER.pack(opcode, sequence, address.to_bytes(6, "big"), length) + payload
    return body + zlib.crc32(body).to_bytes(4, "big")


def identity():
    result = bytearray(1024)
    result[:3] = bytes((2, 36, 0))
    result[8] = 21
    result[11] = 11
    return bytes(result)


def record(payload, response=False, device="4", frame="1", truncated=False):
    result = dict.fromkeys(DIAG.FIELDS, "")
    result.update({
        "frame.number": frame, "frame.time_relative": "0.1",
        "usb.bus_id": "2", "usb.device_address": device,
        "usb.endpoint_address": "0x81" if response else "0x01",
        "usb.irp_info": "0x01" if response else "0x00",
        "frame.len": "101" if truncated else "100", "frame.cap_len": "100",
        "usb.capdata": payload.hex(),
    })
    return result


class AnalysisTests(unittest.TestCase):
    def test_request_is_exactly_one_read_at_zero(self):
        request = DIAG.identity_request()
        self.assertEqual(len(request), 16)
        self.assertEqual(request, packet())
        self.assertEqual(zlib.crc32(request[:-4]), int.from_bytes(request[-4:], "big"))

    def test_split_and_coalesced_replies(self):
        stream = DIAG.PacketStream(response=True)
        reply = packet(payload=identity())
        self.assertEqual(stream.feed(reply[:10]), [])
        self.assertEqual(stream.feed(reply[10:500]), [])
        self.assertEqual(stream.feed(reply[500:] + reply), [reply, reply])
        self.assertFalse(stream.buffer)

    def test_write_ack_and_crc_delimited_rpc_reply(self):
        ack = packet(opcode=1, length=7)
        rpc = packet(opcode=1, length=2, payload=b"\0\0\3")
        stream = DIAG.PacketStream(response=True)
        self.assertEqual(stream.feed(ack + rpc[:17]), [ack])
        self.assertEqual(stream.feed(rpc[17:]), [rpc])

    def test_corrupt_read_and_unknown_prefix_are_reported(self):
        stream = DIAG.PacketStream(response=True)
        bad = bytearray(packet(payload=identity()))
        bad[-1] ^= 1
        decoded = stream.feed(b"unrecognized" + bad)
        self.assertEqual(decoded, [])
        self.assertGreater(stream.crc_failures, 0)
        self.assertEqual(stream.skipped + len(stream.buffer), len(bad) + 12)

    def test_identity_matching_device_isolation_and_writes(self):
        analysis = DIAG.Analysis()
        analysis.feed(record(packet()))
        event = analysis.feed(record(packet(payload=identity()), True, device="5"))[0]
        self.assertFalse(event["matched_request"])
        self.assertFalse(analysis.identities)
        event = analysis.feed(record(packet(payload=identity()), True))[0]
        self.assertTrue(event["matched_request"])
        self.assertEqual(analysis.identities[0]["firmware"], "2.36.0")
        analysis.feed(record(packet(1, length=3, payload=b"abc"), truncated=True))
        report = analysis.report()
        self.assertEqual(report["counts"]["write_requests"], 1)
        self.assertEqual(report["truncated_frames"], 1)
        self.assertFalse(report["scope"]["all_hardware_enumerated"])

    def test_error_response_and_unanswered_request(self):
        analysis = DIAG.Analysis()
        analysis.feed(record(packet()))
        event = analysis.feed(record(packet(opcode=0x82), True))[0]
        self.assertTrue(event["device_error"])
        self.assertTrue(event["matched_request"])
        self.assertFalse(analysis.identities)
        analysis.feed(record(packet(sequence=2)))
        self.assertEqual(analysis.report()["unanswered_requests"], 1)

    def test_superseded_request_and_unmatched_reply(self):
        analysis = DIAG.Analysis()
        analysis.feed(record(packet()))
        analysis.feed(record(packet()))
        event = analysis.feed(record(packet(address=16, payload=identity()), True))[0]
        self.assertFalse(event["matched_request"])
        self.assertEqual(analysis.report()["counts"]["superseded_requests"], 1)

    def test_non_ic7_identity_is_not_inventoried(self):
        with self.assertRaisesRegex(ValueError, "product 21"):
            DIAG.decode_identity(bytes(1024))

    def test_recorded_physical_capture_end_to_end(self):
        capture = Path(__file__).resolve().parents[2] / "research/usb-captures/nsp-screen-upload1.pcap"
        tshark = shutil.which("tshark")
        if not tshark or not capture.is_file():
            self.skipTest("Physical capture fixture and tshark are optional")
        with capture.open("rb") as source:
            if source.read(4) == b"vers":
                self.skipTest("Physical capture fixture is an unfetched Git LFS pointer")
        with tempfile.TemporaryDirectory() as root:
            output = Path(root) / "analysis"
            report = DIAG.analyze(capture, output, 2, [4, 5], tshark)
            self.assertEqual(report["counts"]["read_requests"], 1160)
            self.assertEqual(report["counts"]["write_requests"], 1016)
            self.assertEqual(report["counts"]["responses"], 2175)
            self.assertEqual(report["unanswered_requests"], 1)
            self.assertEqual(report["undecoded_bytes"], 0)
            self.assertEqual(report["crc_failure_candidates"], 0)
            self.assertEqual(report["identities"][0]["firmware"], "2.36.0")
            with (output / "usb-records.jsonl").open() as source:
                self.assertEqual(sum(1 for _ in source), 16491)
            with (output / "protocol.jsonl").open() as source:
                self.assertEqual(sum(1 for _ in source), 4351)


class IdentityQueryTests(unittest.TestCase):
    def query(self, root, response, **connection_options):
        connection = Mock(**connection_options)
        if "write" not in connection_options:
            connection.write.return_value = 16
        if "read" not in connection_options:
            connection.read.side_effect = [response[:12], response[12:]]
        serial_module = SimpleNamespace(Serial=Mock(return_value=connection), SerialException=OSError)
        ports = [SimpleNamespace(device="COM3", vid=0x16D0, pid=1)]
        return connection, serial_module, ports

    def test_query_sends_no_write_opcode_and_saves_raw_reply(self):
        response = packet(payload=identity())
        with tempfile.TemporaryDirectory() as root:
            connection, serial_module, ports = self.query(root, response)
            output = Path(root) / "identity"
            report = DIAG.query_identity("COM3", output, serial_module, ports)
            self.assertEqual(report["status"], "validated")
            connection.write.assert_called_once_with(DIAG.identity_request())
            self.assertEqual((output / "response.bin").read_bytes(), response)
            self.assertFalse(connection.dtr)
            self.assertFalse(connection.rts)
            connection.close.assert_called_once()

    def test_wrong_device_does_not_open_or_create_output(self):
        with tempfile.TemporaryDirectory() as root:
            connection, serial_module, ports = self.query(root, b"")
            ports[0].vid = 0x1234
            output = Path(root) / "identity"
            with self.assertRaisesRegex(ValueError, "no port opened"):
                DIAG.query_identity("COM3", output, serial_module, ports)
            serial_module.Serial.assert_not_called()
            self.assertFalse(output.exists())

    def test_corrupt_reply_fails_and_preserves_partial_evidence(self):
        response = packet(payload=identity())[:-1] + b"\0"
        with tempfile.TemporaryDirectory() as root:
            connection, serial_module, ports = self.query(root, response)
            output = Path(root) / "identity"
            with self.assertRaisesRegex(ValueError, "CRC mismatch"):
                DIAG.query_identity("COM3", output, serial_module, ports)
            saved = json.loads((output / "report.json").read_text())
            self.assertEqual(saved["status"], "incomplete")
            self.assertIsNone(saved["identity"])
            connection.write.assert_called_once()
            connection.close.assert_called_once()

    def test_timeout_is_not_retried(self):
        with tempfile.TemporaryDirectory() as root:
            connection, serial_module, ports = self.query(root, b"")
            with patch.object(DIAG.time, "monotonic", side_effect=[0, 6]):
                with self.assertRaises(TimeoutError):
                    DIAG.query_identity("COM3", Path(root) / "identity", serial_module, ports)
            connection.write.assert_called_once()

    def test_error_reply_is_rejected_without_waiting_for_payload(self):
        with tempfile.TemporaryDirectory() as root:
            response = packet(opcode=0x82)
            connection, serial_module, ports = self.query(root, response)
            with self.assertRaisesRegex(ValueError, "rejected"):
                DIAG.query_identity("COM3", Path(root) / "identity", serial_module, ports)
            self.assertEqual(connection.read.call_count, 2)

    def test_short_write_is_not_retried(self):
        with tempfile.TemporaryDirectory() as root:
            connection, serial_module, ports = self.query(root, b"", write=Mock(return_value=8))
            with self.assertRaisesRegex(OSError, "Short request"):
                DIAG.query_identity("COM3", Path(root) / "identity", serial_module, ports)
            connection.read.assert_not_called()
            connection.write.assert_called_once()


if __name__ == "__main__":
    unittest.main()
