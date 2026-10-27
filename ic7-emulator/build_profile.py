import argparse
import json
from pathlib import Path
import subprocess
import tarfile
import zipfile
import zlib

from ic7_emulator import HEADER, Memory, PAGE_SIZE


def captured_exchanges(path, bus=2, devices=(4, 5)):
    selection = " || ".join(f"usb.device_address == {device}" for device in devices)
    display_filter = f"usb.bus_id == {bus} && ({selection}) && usb.transfer_type == 3 && usb.capdata"
    command = ["tshark", "-r", str(path), "-Y", display_filter, "-T", "fields",
               "-e", "frame.number", "-e", "usb.device_address", "-e", "usb.endpoint_address",
               "-e", "usb.irp_info", "-e", "usb.capdata"]
    result = subprocess.run(command, check=True, capture_output=True, text=True)
    pending = {}
    for row in result.stdout.splitlines():
        frame, device, endpoint, info, encoded = row.split("\t")
        payload = bytes.fromhex(encoded.replace(":", ""))
        if endpoint == "0x01" and info == "0x00":
            if len(payload) < 16 or payload[0] not in (1, 2):
                continue
            length = int.from_bytes(payload[8:12], "big")
            if len(payload) != 16 + (length if payload[0] == 1 else 0):
                continue
            if zlib.crc32(payload[:-4]) != int.from_bytes(payload[-4:], "big"):
                continue
            pending[device] = (int(frame), payload, bytearray())
        elif endpoint == "0x81" and info == "0x01" and device in pending:
            request_frame, request, reply = pending[device]
            reply.extend(payload)
            expected = 16 + int.from_bytes(request[8:12], "big") if request[0] == 2 else 16
            if len(reply) >= expected:
                del pending[device]
                if len(reply) == expected and reply[:12] == request[:12] and zlib.crc32(reply[:-4]) == int.from_bytes(reply[-4:], "big"):
                    yield request_frame, request, bytes(reply)


def build_profile(captures, destination, definition, resources, user_resources):
    memory = Memory()
    coverage = {}
    samples = {}
    counts = []

    def seed(address, payload):
        for offset, value in enumerate(payload):
            current = address + offset
            base = current - current % PAGE_SIZE
            within = current - base
            known = coverage.setdefault(base, bytearray(PAGE_SIZE))
            if not known[within]:
                memory.pages.setdefault(base, bytearray(PAGE_SIZE))[within] = value
                known[within] = 1

    for capture in captures:
        count = 0
        for _, request, reply in captured_exchanges(capture):
            opcode, _, raw_address, length = HEADER.unpack_from(request)
            address = int.from_bytes(raw_address, "big")
            count += 1
            if opcode == 2 and address < 0x70000000:
                seed(address, reply[12:-4])
                samples.setdefault((address, length), reply[12:-4])
            elif opcode == 1 and 0 < address < 0x70000000:
                seed(address, request[12:-4])
        counts.append({"capture": capture.name, "valid_exchanges": count})
    identity = memory.read(0, 1024)
    if identity[8] != 21 or tuple(identity[:3]) != (2, 36, 0):
        raise ValueError("No captured iC-7 v2.36 identity")
    if definition:
        memory.write(0x1800000, definition.read_bytes())
    manifest = {
        "format": 1, "segments": [], "resources": [], "samples": [],
        "summary": {"firmware": "2.36.0", "product": identity[8], "variant": identity[11],
                    "pages": len(memory.pages), "captures": counts,
                    "definition_seeded": bool(definition), "captured_hdef_id": identity[32:48].hex(),
                    "scope": "protocol simulation, not physical firmware execution"},
    }
    destination.parent.mkdir(parents=True, exist_ok=True)
    with zipfile.ZipFile(destination, "x", compression=zipfile.ZIP_DEFLATED) as archive:
        for address, payload in sorted(memory.pages.items()):
            filename = f"memory/{address:012x}.bin"
            archive.writestr(filename, payload)
            manifest["segments"].append({"address": address, "file": filename})
        for index, ((address, length), payload) in enumerate(sorted(samples.items())):
            filename = f"samples/{index:04d}.bin"
            archive.writestr(filename, payload)
            manifest["samples"].append({"address": address, "length": length, "file": filename})
        if resources:
            with tarfile.open(resources) as source:
                for member in source.getmembers():
                    for kind, prefix in ((0, "qml_components_data/images/"), (1, "qml_components_data/fonts/")):
                        if member.isfile() and member.name.startswith(prefix):
                            name = "h/" + member.name[len(prefix):]
                            if len(name.encode("utf-8")) >= 50:
                                continue
                            filename = f"resources/{kind}/{name}"
                            archive.writestr(filename, source.extractfile(member).read())
                            manifest["resources"].append({"kind": kind, "name": name, "file": filename})
        if user_resources:
            for kind, folder in ((0, "images"), (1, "fonts")):
                for source in sorted((user_resources / folder).rglob("*")):
                    if source.is_file():
                        name = "u/" + source.relative_to(user_resources / folder).as_posix()
                        if len(name.encode("utf-8")) >= 50:
                            continue
                        filename = f"resources/{kind}/{name}"
                        archive.writestr(filename, source.read_bytes())
                        manifest["resources"].append({"kind": kind, "name": name, "file": filename})
        archive.writestr("profile.json", json.dumps(manifest, indent=2))
    return manifest["summary"]


def main():
    parser = argparse.ArgumentParser(description="Build private iC-7 profile from validated USB exchanges.")
    parser.add_argument("captures", nargs="+", type=Path)
    parser.add_argument("--output", required=True, type=Path)
    parser.add_argument("--definition", type=Path)
    parser.add_argument("--resources", type=Path)
    parser.add_argument("--user-resources", type=Path)
    args = parser.parse_args()
    print(json.dumps(build_profile(args.captures, args.output, args.definition, args.resources, args.user_resources), indent=2))


if __name__ == "__main__":
    main()