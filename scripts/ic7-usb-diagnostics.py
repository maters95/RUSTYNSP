import argparse
from collections import Counter
from datetime import datetime, timezone
import hashlib
import json
from pathlib import Path
import struct
import subprocess
import sys
import tempfile
import time
import zlib


HEADER = struct.Struct(">BB6sI")
IDENTITY_LENGTH = 1024
MAX_PASSIVE_LENGTH = 16 * 1024 * 1024
FIELDS = (
    "frame.number", "frame.time_relative", "usb.bus_id", "usb.device_address",
    "usb.endpoint_address", "usb.irp_info", "usb.transfer_type",
    "frame.len", "frame.cap_len", "usb.idVendor", "usb.idProduct", "usb.capdata",
)


def identity_request():
    body = HEADER.pack(2, 1, bytes(6), IDENTITY_LENGTH)
    return body + zlib.crc32(body).to_bytes(4, "big")


def decode_identity(payload):
    if len(payload) != IDENTITY_LENGTH or payload[8] != 21:
        raise ValueError("Not a complete iC-7 identity block (expected product 21)")
    return {
        "firmware": ".".join(str(value) for value in payload[:3]),
        "firmware_revision_raw": payload[3],
        "firmware_build_raw": int.from_bytes(payload[4:8], "big"),
        "product_id": payload[8],
        "hardware_fields_raw": payload[9:12].hex(),
        "variant_raw": payload[11],
        "definition_id_hex": payload[32:48].hex(),
        "serial_hex": payload[256:262].hex().upper(),
        "sha256": hashlib.sha256(payload).hexdigest(),
        "source": "NSP A/F.cs identity parser; raw fields are not hardware inventory",
    }


class PacketStream:
    def __init__(self, response=False):
        self.response = response
        self.buffer = bytearray()
        self.skipped = 0
        self.crc_failures = 0

    def feed(self, chunk):
        self.buffer.extend(chunk)
        packets = []
        while len(self.buffer) >= 16:
            opcode, _, _, length = HEADER.unpack_from(self.buffer)
            error = self.response and opcode & 0xF0 == 0x80
            if (opcode & 0x0F not in (1, 2) or
                    (opcode not in (1, 2) and not error) or
                    length > MAX_PASSIVE_LENGTH):
                del self.buffer[0]
                self.skipped += 1
                continue
            has_payload = not error and (
                (self.response and opcode == 2) or (not self.response and opcode == 1))
            size = 16 + (length if has_payload else 0)
            if len(self.buffer) < size:
                break
            packet = bytes(self.buffer[:size])
            if self.response and opcode == 1 and (
                    zlib.crc32(packet[:-4]) != int.from_bytes(packet[-4:], "big")):
                # Resource RPC replies do not advertise their payload size.
                crc = zlib.crc32(self.buffer[:12])
                size = 16
                while size <= len(self.buffer):
                    if crc == int.from_bytes(self.buffer[size - 4:size], "big"):
                        break
                    crc = zlib.crc32(self.buffer[size - 4:size - 3], crc)
                    size += 1
                if size > len(self.buffer):
                    if len(self.buffer) <= MAX_PASSIVE_LENGTH:
                        break
                    del self.buffer[0]
                    self.skipped += 1
                    self.crc_failures += 1
                    continue
                packet = bytes(self.buffer[:size])
            if zlib.crc32(packet[:-4]) != int.from_bytes(packet[-4:], "big"):
                del self.buffer[0]
                self.skipped += 1
                self.crc_failures += 1
                continue
            del self.buffer[:size]
            packets.append(packet)
        return packets


def packet_details(packet):
    opcode, sequence, raw_address, length = HEADER.unpack_from(packet)
    return {
        "opcode": opcode, "sequence": sequence,
        "address": hex(int.from_bytes(raw_address, "big")), "length": length,
        "operation": "read" if opcode & 0x0F == 2 else "write",
        "device_error": opcode & 0xF0 == 0x80,
        "wire_payload_bytes": len(packet) - 16,
    }


class Analysis:
    def __init__(self):
        self.streams = {}
        self.pending = {}
        self.counts = Counter()
        self.identities = []
        self.regions = Counter()
        self.truncated = 0

    def feed(self, record):
        self.counts["usb_records"] += 1
        if int(record["frame.cap_len"]) < int(record["frame.len"]):
            self.truncated += 1
        endpoint = record["usb.endpoint_address"]
        info = record["usb.irp_info"]
        if not record["usb.capdata"] or not endpoint or not info:
            return []
        endpoint, info = int(endpoint, 0), int(info, 0)
        if (endpoint, info) not in ((0x01, 0), (0x81, 1)):
            return []
        response = endpoint == 0x81
        device = (record["usb.bus_id"], record["usb.device_address"])
        stream = self.streams.setdefault((device, response), PacketStream(response))
        events = []
        for packet in stream.feed(bytes.fromhex(record["usb.capdata"].replace(":", ""))):
            details = packet_details(packet)
            event = {
                **details, "completed_at_frame": int(record["frame.number"]),
                "bus": device[0], "device": device[1],
                "direction": "device_to_host" if response else "host_to_device",
                "packet_hex": packet.hex(), "crc_valid": True,
            }
            key = (*device, details["sequence"])
            if not response:
                self.counts[details["operation"] + "_requests"] += 1
                self.regions[(details["operation"], details["address"], details["length"])] += 1
                if key in self.pending:
                    self.counts["superseded_requests"] += 1
                self.pending[key] = (packet[:12], event["completed_at_frame"])
            else:
                self.counts["responses"] += 1
                pending = self.pending.get(key)
                matched = pending is not None and packet[1:8] == pending[0][1:8]
                event["matched_request"] = matched
                if matched:
                    event["request_frame"] = self.pending.pop(key)[1]
                else:
                    self.counts["unmatched_responses"] += 1
                if details["device_error"]:
                    self.counts["device_errors"] += 1
                if (matched and packet[0] == 2 and details["address"] == "0x0" and
                        details["length"] == IDENTITY_LENGTH):
                    try:
                        identity = decode_identity(packet[12:-4])
                    except ValueError as error:
                        event["identity_error"] = str(error)
                    else:
                        if identity not in self.identities:
                            self.identities.append(identity)
            events.append(event)
        return events

    def report(self):
        skipped = sum(stream.skipped for stream in self.streams.values())
        remaining = sum(len(stream.buffer) for stream in self.streams.values())
        return {
            "counts": dict(self.counts),
            "identities": self.identities,
            "observed_requests": [
                {"operation": key[0], "address": key[1], "length": key[2], "count": count}
                for key, count in sorted(self.regions.items())
            ],
            "unanswered_requests": len(self.pending),
            "undecoded_bytes": skipped + remaining,
            "crc_failure_candidates": sum(s.crc_failures for s in self.streams.values()),
            "truncated_frames": self.truncated,
            "scope": {
                "raw_usb_records": "All selected device records exported; original capture is authoritative",
                "protocol_decode": "USBPcap endpoint 0x01 submit / 0x81 completion; CRC-validated frames",
                "rpc_reply_boundaries": "Opcode-1 payload boundaries inferred by CRC, not a decoded RPC schema",
                "all_hardware_enumerated": False,
                "capture_driver_drops_known": False,
                "device_writes_sent_by_analyzer": False,
            },
            "warnings": [
                "A capture only reveals observed traffic, not every supported command or fitted component.",
                "NSP may write automatically; passive capture does not prevent or authorize those writes.",
                "Unknown/truncated bytes remain in usb-records.jsonl and the original capture.",
                "Identity blocks and captures may contain serial numbers, settings and unrelated private data.",
            ],
        }


def analyze(capture, output, bus, devices, tshark):
    selection = " || ".join(f"usb.device_address == {device}" for device in devices)
    command = [
        tshark, "-n", "-r", str(capture), "-Y",
        f"usb.bus_id == {bus} && ({selection})", "-T", "fields",
        "-E", "occurrence=f",
    ]
    for field in FIELDS:
        command.extend(("-e", field))
    output.mkdir(parents=True, exist_ok=False)
    analysis = Analysis()
    with tempfile.TemporaryFile(mode="w+t", encoding="utf-8") as errors:
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=errors,
                              text=True, encoding="utf-8") as process:
            try:
                with (output / "usb-records.jsonl").open("x", encoding="utf-8") as raw, (
                        output / "protocol.jsonl").open("x", encoding="utf-8") as protocol:
                    for line in process.stdout:
                        values = line.rstrip("\r\n").split("\t")
                        if len(values) != len(FIELDS):
                            raise ValueError("Unexpected tshark field count")
                        record = dict(zip(FIELDS, values))
                        raw.write(json.dumps(record) + "\n")
                        for event in analysis.feed(record):
                            protocol.write(json.dumps(event) + "\n")
            except BaseException:
                process.terminate()
                process.wait()
                raise
        errors.seek(0)
        stderr = errors.read()
        if process.returncode:
            raise RuntimeError(f"tshark failed ({process.returncode}): {stderr}")
    if not analysis.counts["usb_records"]:
        raise ValueError("No matching USB records; check bus/device selection and retain all re-enumerated addresses")
    report = {
        "capture": str(capture.resolve()), "bus": bus, "devices": devices,
        "tshark_diagnostics": stderr, **analysis.report(),
    }
    write_json(output / "report.json", report)
    return report


def write_json(path, value):
    path.write_text(json.dumps(value, indent=2) + "\n", encoding="utf-8")


def query_identity(port, output, serial_module, ports):
    matching = [item for item in ports if item.device.casefold() == port.casefold()]
    if len(matching) != 1 or (matching[0].vid, matching[0].pid) != (0x16D0, 0x0001):
        raise ValueError("Port is not the previously observed iC-7 VID 16D0 / PID 0001; no port opened")
    output.mkdir(parents=True, exist_ok=False)
    request = identity_request()
    reply = bytearray()
    report = {
        "started_utc": datetime.now(timezone.utc).isoformat(),
        "port": port, "status": "incomplete", "identity": None,
        "scope": "One opcode-2 read at address 0, length 1024; no protocol writes or scans",
        "physical_hardware_validated": False,
    }
    try:
        connection = serial_module.Serial(
            port=None, baudrate=115200, timeout=0.25, write_timeout=2)
        try:
            connection.dtr = False
            connection.rts = False
            connection.port = port
            connection.open()
            (output / "request.bin").write_bytes(request)
            if connection.write(request) != len(request):
                raise IOError("Short request transmission; not retried")
            deadline = time.monotonic() + 5
            expected = 16 + IDENTITY_LENGTH
            while len(reply) < expected:
                if time.monotonic() >= deadline:
                    raise TimeoutError(f"Identity timeout: received {len(reply)} bytes; not retried")
                chunk = connection.read(expected - len(reply))
                reply.extend(chunk)
                if len(reply) >= 12 and reply[0] & 0xF0 == 0x80:
                    expected = 16
            if zlib.crc32(reply[:-4]) != int.from_bytes(reply[-4:], "big"):
                raise ValueError("Identity response CRC mismatch")
            if reply[0] & 0xF0 == 0x80:
                raise ValueError(f"Device rejected identity request: opcode {reply[0]:#x}")
            if reply[:12] != request[:12]:
                raise ValueError("Identity response does not echo the requested header")
            report["identity"] = decode_identity(bytes(reply[12:-4]))
            report["status"] = "validated"
        finally:
            connection.close()
    except (OSError, ValueError, serial_module.SerialException) as error:
        report["error"] = str(error)
        raise
    finally:
        (output / "response.bin").write_bytes(reply)
        write_json(output / "report.json", report)
    return report


def main():
    parser = argparse.ArgumentParser(description="Local iC-7 USB evidence collection; no firmware writes.")
    commands = parser.add_subparsers(dest="command", required=True)
    offline = commands.add_parser("analyze", help="Decode both directions of an existing USBPcap capture")
    offline.add_argument("capture", type=Path)
    offline.add_argument("--bus", required=True, type=int)
    offline.add_argument("--devices", required=True, nargs="+", type=int)
    offline.add_argument("--tshark", default="tshark")
    offline.add_argument("--output", required=True, type=Path)
    active = commands.add_parser("identity", help="One bounded identity read; close NSP first")
    active.add_argument("--port", required=True)
    active.add_argument("--output", required=True, type=Path)
    active.add_argument("--confirm-nsp-closed", required=True, action="store_true")
    args = parser.parse_args()
    try:
        if args.command == "analyze":
            report = analyze(args.capture, args.output, args.bus, args.devices, args.tshark)
        else:
            if sys.platform != "win32":
                raise ValueError("Active collection is restricted to the Windows USB host")
            try:
                import serial
                from serial.tools import list_ports
            except ImportError as error:
                raise RuntimeError("Identity mode requires pyserial: py -m pip install pyserial") from error
            report = query_identity(args.port, args.output, serial, list_ports.comports())
    except (OSError, ValueError, RuntimeError) as error:
        parser.exit(1, f"ERROR: {error}\n")
    print(json.dumps({key: value for key, value in report.items()
                      if key != "observed_requests"}, indent=2))


if __name__ == "__main__":
    main()
