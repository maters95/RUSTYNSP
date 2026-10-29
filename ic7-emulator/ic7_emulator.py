import argparse
import base64
from functools import lru_cache
import hashlib
import io
import json
import logging
import os
from pathlib import Path, PurePosixPath
import socket
import struct
import sys
import threading
import time
import uuid
import xml.etree.ElementTree as ElementTree
import zipfile
import zlib


HEADER = struct.Struct(">BB6sI")
MAX_TRANSFER = 16384
MAX_RESOURCE_SIZE = 128 * 1024 * 1024
PAGE_SIZE = 4096
RESOURCE_ADDRESS = 0x70000000
RESOURCE_STAGE_ADDRESS = 0x25000000
SETTINGS_BASE = 0x20000
SPLASH_RESOURCE = "u/ic7_splash.json"
ALERT_RESOURCE = "u/ic7_alerts.json"
SPLASH_DURATION_MS = 3300
RUNTIME_COMPONENT_PATHS = {
    "HalImage.qml": "qml_components_data/qml/user_components/HalImage.qml",
    "HalSplash.qml": "qml_components_data/qml/user_components/HalSplash.qml",
    "HalAlarmPopup.qml": "qml_components_data/qml/user_components/HalAlarmPopup.qml",
    "main.qml": "qml_components_data/qml/factory_screens/main.qml",
}


@lru_cache(maxsize=1)
def dashboard_setting_spans():
    schema_path = Path(__file__).with_name("viewer-schema.json")
    if not schema_path.is_file():
        return ()
    schema = json.loads(schema_path.read_text(encoding="utf-8"))
    return tuple(
        (SETTINGS_BASE + field["address"], SETTINGS_BASE + field["address"] + field["bytes"])
        for component in schema.get("components", [])
        for field in component.get("fields", {}).values()
    )


def overlaps_dashboard_settings(address, length):
    end = address + length
    return length > 0 and any(address < span_end and span_start < end
                              for span_start, span_end in dashboard_setting_spans())


class UpdateSandbox:
    def __init__(self, package, destination):
        self.package = Path(package)
        self.destination = Path(destination)
        if not self.package.is_file():
            raise ValueError("NEX package not found. Select the extracted NEX file from its actual folder.")
        with zipfile.ZipFile(self.package) as archive:
            names = set(archive.namelist())
            if (len(archive.infolist()) not in (2, 3) or
                    not {"manifest.xml", "res_ic-7.qzip"}.issubset(names)):
                raise ValueError("Sandbox requires a resource-only NEX package")
            if (archive.getinfo("manifest.xml").file_size > 65536 or
                    archive.getinfo("res_ic-7.qzip").file_size > 32 * 1024 * 1024 or
                    archive.testzip() is not None):
                raise ValueError("Sandbox archive size or integrity check failed")
            manifest = ElementTree.fromstring(archive.read("manifest.xml"))
            products = manifest.findall("PRODUCT")
            if (len(products) != 1 or products[0].get("pid") != "21" or
                    products[0].get("vid") != "11" or
                    [entry.get("name") for entry in products[0].findall("FILE")] != ["res_ic-7.qzip"]):
                raise ValueError("Sandbox requires one iC-7 variant 11 resource entry")
            hdef_name = products[0].get("hdefFile")
            if not hdef_name:
                raise ValueError("NEX lacks hdefFile required for NSP map migration; use the mapfix candidate")
            expected_names = {"manifest.xml", "res_ic-7.qzip"}
            relative_hdef = PurePosixPath(hdef_name)
            if (relative_hdef.is_absolute() or ".." in relative_hdef.parts or
                    "\\" in hdef_name or ":" in hdef_name):
                raise ValueError("Sandbox HDEF reference is invalid")
            expected_names.add(hdef_name)
            if hdef_name not in names or archive.getinfo(hdef_name).file_size > 16 * 1024 * 1024:
                raise ValueError("Sandbox migration HDEF is missing or oversized")
            if names != expected_names:
                raise ValueError("Sandbox NEX contains unexpected files")
            self.migration_definition = hdef_name
            wrapped = archive.read("res_ic-7.qzip")
        if not 44 < len(wrapped) <= 32 * 1024 * 1024:
            raise ValueError("Sandbox resource payload size is invalid")
        fields = struct.unpack_from("<II4xIIII", wrapped)
        if fields[0] != 2 or fields[1] != 0 or fields[2] != RESOURCE_STAGE_ADDRESS:
            raise ValueError("Sandbox requires the stock v2 resource staging address")
        if (len(wrapped) - 44) % 16:
            raise ValueError("Sandbox encrypted resource is not block aligned")
        self.metadata = wrapped[28:44]
        self.expected = wrapped[44:]
        self.expected_sha256 = hashlib.sha256(self.expected).hexdigest()
        self.received = bytearray()
        self.status = "ready"
        self.error = None
        self.main_returned = False
        self.component = None
        self.component_active = False
        self.components = {}
        report_path = self.package.with_name("build-report.json")
        component_path = self.package.with_name("HalImage.qml")
        if report_path.is_file() and component_path.is_file():
            report = json.loads(report_path.read_text(encoding="utf-8"))
            details = report.get("packages", {}).get(self.package.name, {})
            component = component_path.read_bytes()
            matches_name = self.package.name == f"ic7-2.36-{report.get('label')}-experimental.nex"
            matches_package = details.get("sha256") == hashlib.sha256(self.package.read_bytes()).hexdigest()
            matches_component = report.get("replacement_component_sha256") == hashlib.sha256(component).hexdigest()
            if matches_name and matches_package and matches_component:
                self.component = component
                hashes = report.get("runtime_components", {})
                if hashes:
                    if not isinstance(hashes, dict) or set(hashes) - RUNTIME_COMPONENT_PATHS.keys():
                        raise ValueError("Unsupported sandbox runtime component set")
                    for name, checksum in hashes.items():
                        data = self.package.with_name(name).read_bytes()
                        if hashlib.sha256(data).hexdigest() != checksum:
                            raise ValueError(f"Sandbox runtime component hash mismatch: {name}")
                        self.components[name] = data
                    if self.components.get("HalImage.qml") != component:
                        raise ValueError("Sandbox runtime is missing the verified image component")
                else:
                    self.components["HalImage.qml"] = component
        saved = self.destination / "received-resource.enc"
        if saved.is_file():
            received = saved.read_bytes()
            if received == self.expected:
                self.received = bytearray(received)
                self.status = "transfer-complete"
                self.main_returned = True
                self.activate_component()
            else:
                logging.getLogger("ic7").warning("Saved sandbox payload differs from the selected NEX; not activating")

    def reject(self, message):
        self.error = message
        self.status = "rejected"
        raise ValueError(message)

    def write(self, address, payload):
        offset = address - RESOURCE_STAGE_ADDRESS
        end = offset + len(payload)
        if offset < 0 or not payload or end > len(self.expected):
            self.reject("Resource write exceeds the selected package")
        if offset > len(self.received):
            self.reject("Resource write leaves a gap")
        if payload != self.expected[offset:end]:
            self.reject("Resource bytes differ from the selected package")
        if offset < len(self.received) and end > len(self.received):
            self.reject("Resource write partially overlaps a previous fragment")
        if offset == len(self.received):
            self.received.extend(payload)
        self.error = None
        self.status = "received" if len(self.received) == len(self.expected) else "receiving"

    def finish(self, command):
        if (len(command) != 28 or command[:4] != b"\0\x04\0\0" or
                command[4:20] != self.metadata or
                int.from_bytes(command[20:24], "big") != RESOURCE_STAGE_ADDRESS or
                int.from_bytes(command[24:28], "big") != len(self.expected)):
            self.reject("Resource completion metadata does not match the selected package")
        if bytes(self.received) != self.expected:
            self.reject("Resource transfer is incomplete")
        self.destination.mkdir(parents=True, exist_ok=True)
        (self.destination / "received-resource.enc").write_bytes(self.received)
        self.status = "verified"
        self.error = None

    def returned_to_main(self):
        self.main_returned = True
        if self.status == "received":
            self.status = "transfer-complete"
            self.error = None
            self.destination.mkdir(parents=True, exist_ok=True)
            (self.destination / "received-resource.enc").write_bytes(self.received)
        self.activate_component()

    def activate_component(self):
        if self.status in ("verified", "transfer-complete") and self.component is not None:
            (self.destination / "HalImage.qml").write_bytes(self.component)
            self.component_active = True

    def component_sha256(self):
        if self.component_active:
            return hashlib.sha256(self.component).hexdigest()
        return None

    def runtime_hashes(self):
        return {name: hashlib.sha256(data).hexdigest() for name, data in self.components.items()
                if self.component_active}

    def summary(self):
        return {"package": self.package.name, "status": self.status, "error": self.error,
                "migration_definition": self.migration_definition,
                "expected_bytes": len(self.expected), "received_bytes": len(self.received),
                "expected_sha256": self.expected_sha256,
            "main_returned": self.main_returned,
                "component_available": self.component is not None,
                "component_active": self.component_active,
            "verification": ("NSP returned to main after an exact payload transfer; target install unverified"
                      if self.status == "transfer-complete" else
                      "sandbox metadata check only; no target-side decryption or execution")}


def header(opcode, sequence, address, length):
    return HEADER.pack(opcode, sequence, address.to_bytes(6, "big"), length)


def seal(payload):
    return payload + struct.pack(">I", zlib.crc32(payload))


def request(opcode, sequence, address, length, payload=b""):
    if opcode not in (1, 2) or (opcode == 1 and len(payload) != length) or (opcode == 2 and payload):
        raise ValueError("Invalid request payload")
    return seal(header(opcode, sequence, address, length) + payload)


class RequestStream:
    def __init__(self):
        self.buffer = bytearray()
        self.rejected = 0

    def feed(self, data):
        self.buffer.extend(data)
        packets = []
        while len(self.buffer) >= 12:
            opcode, sequence, address, length = HEADER.unpack_from(self.buffer)
            if opcode not in (1, 2) or length > MAX_TRANSFER:
                del self.buffer[0]
                self.rejected += 1
                continue
            size = 16 + (length if opcode == 1 else 0)
            if len(self.buffer) < size:
                break
            packet = bytes(self.buffer[:size])
            if zlib.crc32(packet[:-4]) != int.from_bytes(packet[-4:], "big"):
                del self.buffer[0]
                self.rejected += 1
                continue
            del self.buffer[:size]
            packets.append(packet)
        return packets


class Memory:
    def __init__(self):
        self.pages = {}

    def write(self, address, payload):
        if address < 0 or address + len(payload) > (1 << 48):
            raise ValueError("Address out of range")
        position = 0
        while position < len(payload):
            current = address + position
            base = current - current % PAGE_SIZE
            offset = current - base
            count = min(PAGE_SIZE - offset, len(payload) - position)
            self.pages.setdefault(base, bytearray(PAGE_SIZE))[offset:offset + count] = payload[position:position + count]
            position += count

    def read(self, address, length):
        output = bytearray(length)
        position = 0
        while position < length:
            current = address + position
            base = current - current % PAGE_SIZE
            offset = current - base
            count = min(PAGE_SIZE - offset, length - position)
            if base in self.pages:
                output[position:position + count] = self.pages[base][offset:offset + count]
            position += count
        return bytes(output)

    def save(self, destination):
        temporary = destination.with_suffix(".tmp")
        with zipfile.ZipFile(temporary, "w", compression=zipfile.ZIP_DEFLATED) as archive:
            for address, payload in sorted(self.pages.items()):
                archive.writestr(f"pages/{address:012x}.bin", payload)
        os.replace(temporary, destination)

    def load(self, source):
        with zipfile.ZipFile(source) as archive:
            for entry in archive.infolist():
                if entry.filename.startswith("pages/") and entry.filename.endswith(".bin"):
                    self.write(int(Path(entry.filename).stem, 16), archive.read(entry))


def resource_descriptor(name, kind, payload):
    encoded = name.encode("utf-8")
    if len(encoded) >= 50 or kind not in (0, 1):
        raise ValueError("Invalid resource descriptor")
    return encoded.ljust(50, b"\0") + bytes((kind, 0)) + struct.pack(">II", len(payload), zlib.crc32(payload))


def parse_descriptor(payload):
    if len(payload) != 60:
        raise ValueError("Resource descriptor must contain 60 bytes")
    name = payload[:50].split(b"\0", 1)[0].decode("utf-8")
    relative = PurePosixPath(name)
    if not name or relative.is_absolute() or ".." in relative.parts or "\\" in name or ":" in name:
        raise ValueError("Invalid resource name")
    if payload[50] not in (0, 1):
        raise ValueError("Unknown resource type")
    return name, payload[50], int.from_bytes(payload[52:56], "big"), int.from_bytes(payload[56:60], "big")


class ProtocolCapture:
    def __init__(self, path, include_payloads=True):
        self.path = Path(path)
        self.path.parent.mkdir(parents=True, exist_ok=True)
        self.stream = self.path.open("a", encoding="utf-8")
        self.include_payloads = include_payloads
        self.lock = threading.Lock()
        self.session_id = uuid.uuid4().hex
        self.packet_count = 0
        self.stream_chunk_count = 0
        self._write({"event": "capture_started", "format": 1, "session_id": self.session_id,
                 "raw_packets": include_payloads, "time_ns": time.time_ns()})

    @staticmethod
    def region(address, length):
        if address == RESOURCE_ADDRESS:
            return "resource_rpc"
        if address == 0:
            return "control"
        if 0x25000000 <= address < 0x26000000:
            return "resource_update_stage"
        if 0x29000000 <= address < 0x2A000000:
            return "app_update_stage"
        if address < 0xBF000 and address + length > 0x20000:
            return "settings"
        if 0x70400000 <= address < 0x72400000:
            return "splash_image"
        if 0x1800000 <= address < 0x60000000:
            return "firmware_staging"
        return "memory"

    def _write(self, event):
        with self.lock:
            self.stream.write(json.dumps(event, separators=(",", ":")) + "\n")
            self.stream.flush()

    def record(self, packet, response):
        opcode, sequence, raw_address, length = HEADER.unpack_from(packet)
        address = int.from_bytes(raw_address, "big")
        payload = packet[12:-4] if opcode == 1 else b""
        response_payload = response[12:-4]
        event = {
            "event": "packet",
            "session_id": self.session_id,
            "time_ns": time.time_ns(),
            "opcode": opcode,
            "operation": "write" if opcode == 1 else "read",
            "sequence": sequence,
            "address": f"0x{address:012x}",
            "length": length,
            "request_bytes": len(packet),
            "region": self.region(address, length),
            "request_crc_valid": zlib.crc32(packet[:-4]) == int.from_bytes(packet[-4:], "big"),
            "response_bytes": len(response),
            "response_payload_bytes": len(response_payload),
            "response_crc_valid": zlib.crc32(response[:-4]) == int.from_bytes(response[-4:], "big"),
            "response_error": bool(response[0] & 0x80),
            "request_payload_sha256": hashlib.sha256(payload).hexdigest(),
            "response_payload_sha256": hashlib.sha256(response_payload).hexdigest(),
        }
        if address == RESOURCE_ADDRESS and opcode == 1 and payload:
            event["resource_operation"] = payload[0]
            if response_payload:
                event["resource_status"] = response_payload[0]
        if self.include_payloads:
            event["request_b64"] = base64.b64encode(packet).decode("ascii")
            event["response_b64"] = base64.b64encode(response).decode("ascii")
        self._write(event)
        self.packet_count += 1

    def record_stream_chunk(self, direction, payload):
        event = {
            "event": "transport_chunk",
            "session_id": self.session_id,
            "time_ns": time.time_ns(),
            "direction": direction,
            "bytes": len(payload),
            "sha256": hashlib.sha256(payload).hexdigest(),
        }
        if self.include_payloads:
            event["data_b64"] = base64.b64encode(payload).decode("ascii")
        self._write(event)
        self.stream_chunk_count += 1

    def record_viewer_resource(self, name, kind, status, payload):
        event = {
            "event": "viewer_resource",
            "session_id": self.session_id,
            "time_ns": time.time_ns(),
            "source": "renderer_resource_api",
            "name": name,
            "kind": kind,
            "status": status,
            "bytes": len(payload),
            "sha256": hashlib.sha256(payload).hexdigest(),
        }
        if self.include_payloads:
            event["payload_b64"] = base64.b64encode(payload).decode("ascii")
        self._write(event)

    def close(self):
        if self.stream.closed:
            return
        self._write({"event": "capture_stopped", "session_id": self.session_id,
                     "time_ns": time.time_ns(), "packets": self.packet_count,
                     "transport_chunks": self.stream_chunk_count})
        with self.lock:
            self.stream.flush()
            self.stream.close()


class Resources:
    def __init__(self, root):
        self.root = Path(root)
        self.root.mkdir(parents=True, exist_ok=True)
        self.items = {}
        self.checksums = {}
        self.pending = {}
        self.revision = 0
        for kind in (0, 1):
            folder = self.root / str(kind)
            if folder.exists():
                for path in folder.rglob("*"):
                    if path.is_file():
                        key = (kind, path.relative_to(folder).as_posix())
                        payload = path.read_bytes()
                        self.items[key] = payload
                        self.checksums[key] = zlib.crc32(payload)

    def put(self, name, kind, payload):
        parse_descriptor(resource_descriptor(name, kind, payload))
        destination = self.root / str(kind) / name
        destination.parent.mkdir(parents=True, exist_ok=True)
        destination.write_bytes(payload)
        self.items[(kind, name)] = payload
        self.checksums[(kind, name)] = zlib.crc32(payload)
        self.revision += 1

    def command(self, payload):
        try:
            return self._command(payload)
        except (ValueError, KeyError, IndexError, struct.error, UnicodeError) as error:
            logging.getLogger("ic7").warning("resource-command-rejected: %s", error)
            return b"\x01"

    def _command(self, payload):
        operation = payload[0]
        if operation in (1, 2):
            kind = payload[1]
            entries = sorted((name, data) for (category, name), data in self.items.items() if category == kind)
            if kind not in (0, 1):
                return b"\x01"
            if operation == 1 and len(payload) == 2:
                return b"\0" + len(entries).to_bytes(2, "big")
            if operation == 2 and len(payload) == 6:
                first, last = struct.unpack(">HH", payload[2:])
                if first > last or last >= len(entries):
                    return b"\x01"
                return b"\0" + b"".join(resource_descriptor(name, kind, data) for name, data in entries[first:last + 1])
            return b"\x01"
        if len(payload) < 64:
            return b"\x01"
        name, kind, size, checksum = parse_descriptor(payload[4:64])
        key = (kind, name)
        if operation == 3 and len(payload) == 72:
            offset, length = struct.unpack(">II", payload[64:72])
            data = self.items[key]
            if offset + length > len(data):
                return b"\x01"
            return b"\0\0\0\0" + data[offset:offset + length]
        if operation == 6 and len(payload) >= 68:
            offset = int.from_bytes(payload[64:68], "big")
            fragment = payload[68:]
            if size > MAX_RESOURCE_SIZE or offset + len(fragment) > size or (size and not fragment):
                raise ValueError(f"Resource {name} has invalid size/offset: size={size} offset={offset} "
                                 f"fragment={len(fragment)} limit={MAX_RESOURCE_SIZE}")
            committed = self.items.get(key)
            if (committed is not None and len(committed) == size and self.checksums.get(key) == checksum and
                    committed[offset:offset + len(fragment)] == fragment):
                return b"\0"
            previous = self.pending.get(key)
            if offset == 0 and (previous is None or previous[:2] != (size, checksum) or
                                previous[2][:len(fragment)] != fragment):
                self.pending[key] = (size, checksum, bytearray())
            expected_size, expected_checksum, pending = self.pending[key]
            if (size, checksum) != (expected_size, expected_checksum):
                raise ValueError(f"Resource descriptor changed during upload: {name}")
            if offset < len(pending) and offset + len(fragment) <= len(pending):
                if pending[offset:offset + len(fragment)] == fragment:
                    return b"\0"
                raise ValueError(f"Conflicting resource retry: {name} offset={offset}")
            if offset != len(pending):
                raise ValueError(f"Noncontiguous resource fragment: {name} offset={offset} expected={len(pending)}")
            pending.extend(fragment)
            if len(pending) == size:
                if zlib.crc32(pending) != checksum:
                    del self.pending[key]
                    raise ValueError(f"Resource CRC mismatch: {name}")
                self.put(name, kind, bytes(pending))
                del self.pending[key]
            return b"\0"
        if operation == 5 and len(payload) == 64:
            del self.items[key]
            self.checksums.pop(key, None)
            (self.root / str(kind) / name).unlink(missing_ok=True)
            self.revision += 1
            return b"\0"
        if operation == 4 and len(payload) == 124:
            new_name, new_kind, _, _ = parse_descriptor(payload[64:124])
            if (new_kind, new_name) in self.items:
                return b"\x01"
            self.put(new_name, new_kind, self.items[key])
            del self.items[key]
            self.checksums.pop(key, None)
            (self.root / str(kind) / name).unlink(missing_ok=True)
            return b"\0"
        return b"\x01"


class Device:
    def __init__(self, profile, state, serial_number="F1C700000001", capture_path=None,
                 capture_payloads=True, sandbox_package=None):
        self.state = Path(state)
        self.state.mkdir(parents=True, exist_ok=True)
        self.memory = Memory()
        self.resources = Resources(self.state / "resources")
        self.rpc_response = b"\0"
        self.requests = 0
        self.settings_revision = 0
        self.dirty_settings = []
        self.last_activity = None
        self.lock = threading.RLock()
        self.boot_mode = False
        self.map_loaded = False
        self.reboot_revision = 0
        self.splash_started_at = None
        self.sandbox = None
        self.last_screen = None
        self.screen_buffer = bytearray()
        self.events = []
        self.connection = "Waiting for NSP"
        self.log = logging.getLogger("ic7")
        self.staged = set()
        self.capture = None
        with zipfile.ZipFile(profile) as archive:
            self.manifest = json.loads(archive.read("profile.json"))
            for segment in self.manifest["segments"]:
                self.memory.write(segment["address"], archive.read(segment["file"]))
            for resource in self.manifest.get("resources", []):
                key = (resource["kind"], resource["name"])
                if key not in self.resources.items:
                    self.resources.put(resource["name"], resource["kind"], archive.read(resource["file"]))
        if (self.state / "memory.zip").exists():
            self.memory.load(self.state / "memory.zip")
        session_path = self.state / "session.json"
        if session_path.is_file():
            try:
                saved_session = json.loads(session_path.read_text(encoding="utf-8"))
                self.map_loaded = saved_session.get("map_loaded") is True
                if sandbox_package is None:
                    sandbox_package = saved_session.get("sandbox_package")
            except (OSError, ValueError, UnicodeError, AttributeError) as error:
                raise ValueError(f"Cannot restore saved dash session: {session_path}: {error}") from error
        self.sandbox = UpdateSandbox(sandbox_package, self.state / "sandbox") if sandbox_package else None
        identity = bytes.fromhex(serial_number)
        if len(identity) != 6:
            raise ValueError("Serial number must be twelve hexadecimal digits")
        self.memory.write(256, identity)
        if self.map_loaded:
            self._prepare_splash()
        if capture_path is not None:
            self.capture = ProtocolCapture(capture_path, capture_payloads)

    def respond(self, packet):
        with self.lock:
            response = self._respond(packet)
            if self.capture is not None:
                try:
                    self.capture.record(packet, response)
                except OSError:
                    self.log.exception("protocol-capture-write-failed; disabling capture")
                    self.capture.close()
                    self.capture = None
            return response

    def _prepare_splash(self):
        self.splash_started_at = time.monotonic()

    def power_cycle(self):
        with self.lock:
            if self.boot_mode:
                raise ValueError("Finish or cancel the update before power cycling the emulator")
            self.resources.pending.clear()
            self.rpc_response = b"\0"
            self.reboot_revision += 1
            if self.map_loaded:
                self._prepare_splash()
            self.save()
            self.log.info("emulator-power-cycle revision=%d map_loaded=%s",
                          self.reboot_revision, self.map_loaded)

    def display_state(self, now=None):
        if now is None:
            now = time.monotonic()
        source = None
        if self.boot_mode or not self.map_loaded:
            phase = "blank"
        else:
            manifest = self.resources.items.get((0, SPLASH_RESOURCE))
            duration_ms = SPLASH_DURATION_MS
            if manifest:
                try:
                    info = json.loads(manifest)
                    if not isinstance(info, dict):
                        raise ValueError("Splash manifest must be an object")
                    candidate = info.get("source", "")
                    duration = info.get("durationMs")
                    if (info.get("version") == 1 and isinstance(candidate, str) and
                            isinstance(duration, (int, float)) and not isinstance(duration, bool) and
                            0 < duration <= SPLASH_DURATION_MS and
                            candidate.startswith(("u/", "h/")) and (0, candidate) in self.resources.items and
                            "/" not in candidate[2:] and "\\" not in candidate[2:] and "\0" not in candidate and
                            candidate != SPLASH_RESOURCE and
                            candidate.rsplit("/", 1)[-1].lower().endswith(
                                (".png", ".jpg", ".jpeg", ".gif", ".mp4", ".webp", ".bmp"))):
                        source = candidate
                        duration_ms = duration
                except (TypeError, ValueError, UnicodeError):
                    self.log.exception("invalid-startup-splash-manifest")
                    source = None
            splash_active = (source is not None and self.splash_started_at is not None and
                             now - self.splash_started_at < duration_ms / 1000)
            if source is not None and not splash_active and self.splash_started_at is not None:
                self.splash_started_at = None
            phase = "splash" if splash_active else "dash"
            if phase != "splash":
                source = None
        return {"phase": phase, "map_loaded": self.map_loaded, "reboot_revision": self.reboot_revision,
                "splash_source": source, "duration_ms": SPLASH_DURATION_MS}

    def _respond(self, packet):
        opcode, sequence, raw_address, length = HEADER.unpack_from(packet)
        address = int.from_bytes(raw_address, "big")
        if opcode not in (1, 2) or len(packet) != 16 + (length if opcode == 1 else 0):
            raise ValueError("Invalid command")
        if zlib.crc32(packet[:-4]) != int.from_bytes(packet[-4:], "big"):
            raise ValueError("Invalid command CRC")
        self.requests += 1
        self.last_activity = time.monotonic()
        self.events.append({"time": time.strftime("%H:%M:%S"), "operation": "read" if opcode == 2 else "write",
                    "address": hex(address), "bytes": length})
        self.events = self.events[-100:]
        self.connection = "Receiving NSP traffic"
        if opcode == 2:
            if address == RESOURCE_ADDRESS:
                payload = self.rpc_response[:length].ljust(length, b"\0")
            else:
                payload = self.memory.read(address, length)
                if self.boot_mode and address <= 9 < address + length:
                    offset = 9 - address
                    payload = payload[:offset] + b"\x01" + payload[offset + 1:]
                if address - address % PAGE_SIZE not in self.memory.pages:
                    self.log.warning("unseeded-read address=%#x length=%d returning-zeroes", address, length)
            self.log.info("read seq=%d address=%#x length=%d", sequence, address, length)
            return seal(packet[:12] + payload)
        payload = packet[12:-4]
        if address == RESOURCE_ADDRESS:
            self.rpc_response = self.resources.command(payload)
            expected = 1
            if len(payload) == 2 and payload[0] == 1:
                expected = 3
            elif len(payload) == 6 and payload[0] == 2:
                first, last = struct.unpack(">HH", payload[2:])
                if last >= first:
                    expected = 1 + 60 * (last - first + 1)
            elif len(payload) == 72 and payload[0] == 3:
                expected = 4 + int.from_bytes(payload[68:72], "big")
            if expected <= 65536:
                self.rpc_response = self.rpc_response.ljust(expected, b"\0")
            self.log.info("resource-command operation=%d status=%d bytes=%d", payload[0] if payload else -1,
                          self.rpc_response[0], len(payload))
            return seal(packet[:12] + self.rpc_response)
        elif address == 0:
            if payload[:2] in (b"\0\x04", b"\0\x03"):
                try:
                    if payload[:2] == b"\0\x03":
                        raise ValueError("Wi-Fi/Bluetooth initialization is outside the resource sandbox")
                    if not self.boot_mode or self.sandbox is None:
                        raise ValueError("Update validation requires boot mode and --sandbox-package")
                    self.sandbox.finish(payload)
                    self.log.info("sandbox-resource-verified bytes=%d sha256=%s no-target-execution",
                                  len(self.sandbox.received), self.sandbox.expected_sha256)
                except ValueError as error:
                    self.log.error("sandbox-update-rejected: %s", error)
                    return seal(bytes((opcode | 0x80,)) + packet[1:12])
            if payload in (b"\0\x01", b"\0\0"):
                self.boot_mode = payload == b"\0\x01"
                if self.boot_mode:
                    self.splash_started_at = None
                else:
                    self.reboot_revision += 1
                    if self.map_loaded:
                        self._prepare_splash()
                if not self.boot_mode and self.sandbox is not None:
                    self.sandbox.returned_to_main()
                    if self.sandbox.component_active:
                        self.log.info("sandbox-component-preview-loaded sha256=%s local-preview-only",
                                      self.sandbox.component_sha256())
                    if self.sandbox.status == "transfer-complete":
                        self.log.info("sandbox-transfer-complete bytes=%d sha256=%s target-install-unverified",
                                      len(self.sandbox.received), self.sandbox.expected_sha256)
                self.log.info("control-command bytes=%s mode=%s simulated-no-hardware-action",
                              payload.hex(), "boot" if self.boot_mode else "main")
            else:
                self.log.info("control-command bytes=%s simulated-no-hardware-action", payload.hex())
        else:
            if self.sandbox is not None and 0x1800000 <= address < 0x60000000:
                try:
                    if not self.boot_mode:
                        raise ValueError("Sandbox firmware writes require boot mode")
                    self.sandbox.write(address, payload)
                except ValueError as error:
                    self.log.error("sandbox-update-rejected: %s", error)
                    return seal(bytes((opcode | 0x80,)) + packet[1:12])
            self.memory.write(address, payload)
            if address < 0xBF000 and address + len(payload) > 0x20000:
                self.settings_revision += 1
                self.dirty_settings.append({"revision": self.settings_revision, "address": address, "length": len(payload)})
                self.dirty_settings = self.dirty_settings[-4096:]
                if overlaps_dashboard_settings(address, len(payload)) and not self.map_loaded:
                    self.map_loaded = True
                    self.log.info("nexmap-settings-loaded address=%#x bytes=%d", address, length)
            if address == 0x70400000 and payload.startswith(b"BM"):
                self.screen_buffer = bytearray()
            if address == 0x70400000 + len(self.screen_buffer):
                self.screen_buffer.extend(payload)
                if len(self.screen_buffer) >= 6:
                    image_size = int.from_bytes(self.screen_buffer[2:6], "little")
                    if 54 <= image_size <= 32 * 1024 * 1024 and len(self.screen_buffer) == image_size:
                        self.last_screen = bytes(self.screen_buffer)
                        (self.state / "received-screen.bmp").write_bytes(self.last_screen)
            if 0x1800000 <= address < 0x60000000:
                self.staged.add(address - address % 0x1000000)
                self.log.warning("staging-only address=%#x bytes=%d no-firmware-execution", address, length)
        self.log.info("write seq=%d address=%#x length=%d sha256=%s", sequence, address, length,
                      hashlib.sha256(payload).hexdigest())
        return seal(packet[:12])

    def save(self):
        self.memory.save(self.state / "memory.zip")
        temporary = self.state / "session.tmp"
        temporary.write_text(json.dumps({
            "requests": self.requests, "staged_regions": sorted(self.staged),
            "mode": "boot" if self.boot_mode else "main",
            "map_loaded": self.map_loaded,
            "sandbox_update": self.sandbox.summary() if self.sandbox else None,
            "sandbox_package": str(self.sandbox.package.resolve()) if self.sandbox else None,
            "firmware_execution": False,
        }, indent=2) + "\n", encoding="utf-8")
        os.replace(temporary, self.state / "session.json")
        if self.capture is not None:
            self.capture.stream.flush()

    def close(self):
        if self.capture is not None:
            self.capture.close()


def serve_stream(device, read, write):
    stream = RequestStream()
    while True:
        data = read()
        if data is None:
            continue
        if not data:
            return
        if device.capture is not None:
            try:
                device.capture.record_stream_chunk("rx", data)
            except OSError:
                device.log.exception("protocol-capture-write-failed; disabling capture")
                device.capture.close()
                device.capture = None
        for packet in stream.feed(data):
            response = device.respond(packet)
            write(response)
            if device.capture is not None:
                try:
                    device.capture.record_stream_chunk("tx", response)
                except OSError:
                    device.log.exception("protocol-capture-write-failed; disabling capture")
                    device.capture.close()
                    device.capture = None


def main():
    parser = argparse.ArgumentParser(description="iC-7 serial protocol simulator. No hardware firmware execution.")
    parser.add_argument("--profile", type=Path, default=Path(__file__).with_name("device-profile.zip"))
    parser.add_argument("--state", type=Path, help="Persistent state directory; sandbox updates use a separate default")
    parser.add_argument("--serial-number", default="F1C700000001")
    parser.add_argument("--viewer-port", type=int, default=8765)
    parser.add_argument("--capture-log", type=Path, help="Append protocol exchanges to a JSONL file; raw packets are included")
    parser.add_argument("--metadata-only", action="store_true", help="Omit raw packets from --capture-log")
    parser.add_argument("--sandbox-package", type=Path, help="Resource-only NEX expected during a simulated update")
    parser.add_argument("--fresh-sandbox", action="store_true", help="Create a new sandbox directory without deleting old runs")
    parser.add_argument("--no-browser", action="store_true")
    transport = parser.add_mutually_exclusive_group(required=True)
    transport.add_argument("--port", help="Emulator end of a virtual null-modem pair, not the physical dash")
    transport.add_argument("--tcp", help="Loopback host:port for protocol testing; NSP does not connect to this directly")
    transport.add_argument("--check-profile", action="store_true")
    transport.add_argument("--viewer-only", action="store_true")
    args = parser.parse_args()
    if args.fresh_sandbox and not args.sandbox_package:
        parser.error("--fresh-sandbox requires --sandbox-package")
    if args.state is None:
        args.state = Path(__file__).with_name("sandbox-state" if args.sandbox_package else "state")
    if args.fresh_sandbox:
        args.state = args.state / uuid.uuid4().hex
    if args.sandbox_package and args.capture_log is None:
        args.capture_log = args.state / "protocol.jsonl"
    args.state.mkdir(parents=True, exist_ok=True)
    logging.basicConfig(level=logging.INFO, format="%(asctime)s %(levelname)s %(message)s", handlers=[
        logging.StreamHandler(), logging.FileHandler(args.state / "emulator.log", encoding="utf-8"),
    ])
    capture_path = None if args.check_profile else args.capture_log
    try:
        device = Device(args.profile, args.state, args.serial_number, capture_path,
                        not args.metadata_only, args.sandbox_package)
    except (OSError, ValueError, zipfile.BadZipFile, ElementTree.ParseError) as error:
        parser.error(str(error))
    identity = device.memory.read(0, 1024)
    print(f"iC-7 simulator: firmware {identity[0]}.{identity[1]}.{identity[2]}, product {identity[8]}, serial {args.serial_number}", flush=True)
    print("Firmware writes are recorded locally only; bootloader/flash execution is not emulated.", flush=True)
    print(f"State: {args.state.resolve()}", flush=True)
    if device.sandbox is not None:
        print(f"Resource sandbox: {device.sandbox.package.name}; exact payload comparison enabled", flush=True)
    if args.check_profile:
        print(json.dumps(device.manifest.get("summary", {}), indent=2))
        return
    if device.capture is not None:
        print(f"Protocol capture: {device.capture.path} (raw packets: {'no' if args.metadata_only else 'yes'})", flush=True)
    from viewer import start_viewer
    viewer = start_viewer(device, args.viewer_port)
    viewer_url = f"http://127.0.0.1:{viewer.server_port}"
    print(f"Viewer: {viewer_url}", flush=True)
    if not args.no_browser:
        import webbrowser
        webbrowser.open(viewer_url)
    try:
        if args.viewer_only:
            while True:
                time.sleep(1)
        elif args.port:
            import serial
            with serial.Serial(args.port, baudrate=9600, timeout=0.2, write_timeout=5) as port:
                print(f"Listening on {args.port}. Connect NSP to the OTHER end of the virtual pair.", flush=True)
                serve_stream(device, lambda: port.read(max(1, port.in_waiting)) or None, port.write)
        else:
            host, port_number = args.tcp.rsplit(":", 1)
            if host not in ("127.0.0.1", "localhost", "::1"):
                raise ValueError("TCP test listener must bind to loopback")
            with socket.create_server((host, int(port_number))) as server:
                print(f"Protocol test listener: {args.tcp}", flush=True)
                while True:
                    connection, _ = server.accept()
                    with connection:
                        serve_stream(device, lambda: connection.recv(65536), connection.sendall)
                    device.save()
    except KeyboardInterrupt:
        pass
    finally:
        viewer.shutdown()
        viewer.server_close()
        device.save()
        device.close()


if __name__ == "__main__":
    main()