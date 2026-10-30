"""Extract NSP request/response exchanges from a USB capture of a real iC-7.

The real dash answers every command on bulk endpoint 0x81 in order. Its
responses are split across arbitrary USB transfers, so the IN stream is
reassembled and cut at each response's CRC. The result is replayed through
the emulator by ``tests/test_capture_conformance.py``.
"""
import argparse
import collections
import json
from pathlib import Path
import shutil
import subprocess
import zlib


RESOURCE_ADDRESS = 0x70000000


def usb_transfers(capture, bus, device, tshark="tshark"):
    """Yield (frame, seconds, endpoint, data) for one USB device's bulk payloads."""
    display_filter = f"usb.bus_id == {bus} && usb.device_address == {device} && usb.capdata"
    command = [str(tshark), "-r", str(capture), "-Y", display_filter, "-T", "fields",
               "-e", "frame.number", "-e", "frame.time_relative",
               "-e", "usb.endpoint_address", "-e", "usb.capdata"]
    result = subprocess.run(command, check=True, capture_output=True, text=True)
    for row in result.stdout.splitlines():
        frame, seconds, endpoint, data = row.split("\t")
        yield int(frame), float(seconds), int(endpoint, 16), bytes.fromhex(data.replace(":", ""))


def capture_devices(capture, tshark="tshark"):
    """Return {(bus, device): first_seconds} for devices carrying bulk data."""
    command = [str(tshark), "-r", str(capture), "-Y", "usb.capdata", "-T", "fields",
               "-e", "usb.bus_id", "-e", "usb.device_address", "-e", "frame.time_relative"]
    result = subprocess.run(command, check=True, capture_output=True, text=True)
    devices = {}
    for row in result.stdout.splitlines():
        bus, device, seconds = row.split("\t")
        key = (int(bus), int(device))
        devices.setdefault(key, [float(seconds), float(seconds)])[1] = float(seconds)
    return {key: tuple(value) for key, value in devices.items()}


def expected_response_length(request):
    """Response size for a successful answer, as NSP's reader expects it."""
    opcode = request[0]
    address = int.from_bytes(request[2:8], "big")
    length = int.from_bytes(request[8:12], "big")
    if opcode == 2:
        return 16 + length
    if address != RESOURCE_ADDRESS:
        return 16
    payload = request[12:-4]
    if len(payload) == 2 and payload[0] == 1:
        return 16 + 3
    if len(payload) == 6 and payload[0] == 2:
        first, last = int.from_bytes(payload[2:4], "big"), int.from_bytes(payload[4:6], "big")
        return 16 + 1 + 60 * (last - first + 1)
    if len(payload) == 72 and payload[0] == 3:
        return 16 + 4 + int.from_bytes(payload[68:72], "big")
    return 16 + 1


def _sealed(stream, start, length):
    end = start + length
    return (end <= len(stream) and
            zlib.crc32(stream[start:end - 4]) == int.from_bytes(stream[end - 4:end], "big"))


def split_responses(requests, stream):
    """Pair each request with the response cut from the reassembled IN stream."""
    position = 0
    exchanges = []
    for frame, seconds, request in requests:
        if position >= len(stream):
            exchanges.append({"frame": frame, "seconds": seconds, "request": request, "response": None})
            continue
        candidates = [expected_response_length(request), 16]
        length = next((size for size in candidates if _sealed(stream, position, size)), None)
        if length is None:
            # Fall back to a CRC scan for an unexpected response size.
            crc = zlib.crc32(stream[position:position + 12])
            for size in range(16, min(len(stream) - position, 70000) + 1):
                if crc == int.from_bytes(stream[position + size - 4:position + size], "big"):
                    length = size
                    break
                crc = zlib.crc32(stream[position + size - 4:position + size - 3], crc)
        response = None if length is None else stream[position:position + length]
        if response is None or response[1] != request[1] or response[2:8] != request[2:8]:
            # The dash never answered this request (it was rebooting or the
            # host gave up); the next response belongs to a later request.
            exchanges.append({"frame": frame, "seconds": seconds, "request": request, "response": None})
            continue
        exchanges.append({"frame": frame, "seconds": seconds, "request": request, "response": response})
        position += length
    if position != len(stream):
        raise ValueError(f"{len(stream) - position} unpaired response bytes remain")
    return exchanges


def extract_exchanges(capture, bus, device, tshark="tshark"):
    requests = []
    pending = bytearray()
    stream = bytearray()
    for frame, seconds, endpoint, data in usb_transfers(capture, bus, device, tshark):
        if endpoint & 0x80:
            if requests or pending:
                # IN data before the first captured request answers a request
                # that started before the capture did.
                stream.extend(data)
            continue
        pending.extend(data)
        while len(pending) >= 12:
            opcode = pending[0]
            length = int.from_bytes(pending[8:12], "big")
            size = 16 + (length if opcode == 1 else 0)
            if len(pending) < size:
                break
            requests.append((frame, seconds, bytes(pending[:size])))
            del pending[:size]
    if pending:
        raise ValueError("Capture ends inside a request")
    return split_responses(requests, bytes(stream))


def classify(request):
    opcode = request[0]
    address = int.from_bytes(request[2:8], "big")
    payload = request[12:-4]
    if address == RESOURCE_ADDRESS:
        return f"resource-op-{payload[0]}" if opcode == 1 and payload else "resource-read"
    if address == 0 and opcode == 1:
        return "control-" + payload[:2].hex()
    if 0x25000000 <= address < 0x26000000:
        return "resource-stage"
    if 0x1800000 <= address < 0x25000000:
        return "firmware-stage"
    if 0x70400000 <= address < 0x72400000:
        return "splash-bmp"
    if address < 0xBF000 and address + int.from_bytes(request[8:12], "big") > 0x20000:
        return "settings-" + ("write" if opcode == 1 else "read")
    return ("write" if opcode == 1 else "read") + "-memory"


def summarize(exchanges):
    counts = collections.Counter()
    errors = collections.Counter()
    for exchange in exchanges:
        kind = classify(exchange["request"])
        counts[kind] += 1
        if exchange["response"] is not None and exchange["response"][0] & 0x80:
            errors[kind] += 1
    return {"exchanges": len(exchanges), "kinds": dict(sorted(counts.items())),
            "error_responses": dict(sorted(errors.items()))}


def main():
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("capture", type=Path)
    parser.add_argument("--bus", type=int)
    parser.add_argument("--device", type=int)
    parser.add_argument("--tshark", default=shutil.which("tshark") or "tshark")
    args = parser.parse_args()
    if args.bus is None or args.device is None:
        print(json.dumps({f"{bus}.{device}": span for (bus, device), span
                          in capture_devices(args.capture, args.tshark).items()}, indent=2))
        return
    print(json.dumps(summarize(extract_exchanges(args.capture, args.bus, args.device, args.tshark)), indent=2))


if __name__ == "__main__":
    main()
