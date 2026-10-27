import argparse
import hashlib
import io
import json
from pathlib import Path
import subprocess
import zipfile
import zlib


def inspect_capture(capture, bus, device, tshark="tshark"):
    display_filter = (
        f"usb.bus_id == {bus} && usb.device_address == {device} && "
        "usb.endpoint_address == 0x01 && usb.irp_info == 0 && usb.capdata"
    )
    command = [
        str(tshark), "-r", str(capture), "-Y", display_filter, "-T", "fields",
        "-e", "frame.number", "-e", "frame.time_relative", "-e", "usb.capdata",
    ]
    result = subprocess.run(command, check=True, capture_output=True, text=True)
    counts = {"read": 0, "write": 0}
    segments = []
    write_bytes = 0
    for row in result.stdout.splitlines():
        frame, seconds, hex_payload = row.split("\t")
        packet = bytes.fromhex(hex_payload.replace(":", ""))
        if len(packet) < 16 or packet[0] not in (1, 2):
            raise ValueError(f"Unsupported or fragmented command at frame {frame}")
        opcode = packet[0]
        address = int.from_bytes(packet[2:8], "big")
        length = int.from_bytes(packet[8:12], "big")
        expected = 16 + length if opcode == 1 else 16
        if len(packet) != expected:
            raise ValueError(f"Command length mismatch at frame {frame}")
        if zlib.crc32(packet[:-4]) != int.from_bytes(packet[-4:], "big"):
            raise ValueError(f"Command CRC mismatch at frame {frame}")
        counts["read" if opcode == 2 else "write"] += 1
        if opcode != 1:
            continue
        write_bytes += length
        payload = packet[12:-4]
        if segments and address == segments[-1]["address"] + len(segments[-1]["data"]):
            segments[-1]["data"].extend(payload)
            segments[-1]["last_frame"] = int(frame)
            segments[-1]["last_seconds"] = float(seconds)
            segments[-1]["commands"] += 1
        else:
            segments.append({
                "address": address,
                "first_frame": int(frame), "last_frame": int(frame),
                "first_seconds": float(seconds), "last_seconds": float(seconds),
                "commands": 1, "data": bytearray(payload),
            })
    if not sum(counts.values()):
        raise ValueError("No matching outbound commands; check USB bus and device address")
    return counts, write_bytes, segments


def describe_segment(segment):
    payload = bytes(segment["data"])
    description = {key: value for key, value in segment.items() if key != "data"}
    description["address"] = hex(segment["address"])
    description["length"] = len(payload)
    description["sha256"] = hashlib.sha256(payload).hexdigest()
    description["format"] = "unidentified"
    if payload.startswith(b"BM"):
        description["format"] = "bmp"
    elif zipfile.is_zipfile(io.BytesIO(payload)):
        with zipfile.ZipFile(io.BytesIO(payload)) as archive:
            description["format"] = "zip"
            description["entries"] = [
                {"name": entry.filename, "size": entry.file_size,
                 "compressed_size": entry.compress_size, "encrypted": bool(entry.flag_bits & 1)}
                for entry in archive.infolist()
            ]
            if not any(entry.flag_bits & 1 for entry in archive.infolist()):
                description["zip_crc_failure"] = archive.testzip()
    if segment["address"] == 0x00020000:
        description["classification"] = "previously-observed-settings-region"
    elif segment["address"] == 0x70400000 and description["format"] == "bmp":
        description["classification"] = "previously-observed-bitmap-transfer"
    elif len(payload) >= 1024 * 1024:
        description["classification"] = "large-unclassified-write"
    else:
        description["classification"] = "unclassified-write"
    return description


def summarize(report):
    regions = {}
    for segment in report["segments"]:
        key = (segment["address"], segment["classification"], segment["format"])
        region = regions.setdefault(key, {
            "address": segment["address"],
            "classification": segment["classification"],
            "format": segment["format"],
            "segments": 0,
            "commands": 0,
            "bytes": 0,
            "first_frame": segment["first_frame"],
            "last_frame": segment["last_frame"],
            "first_seconds": segment["first_seconds"],
            "last_seconds": segment["last_seconds"],
        })
        region["segments"] += 1
        region["commands"] += segment["commands"]
        region["bytes"] += segment["length"]
        region["first_frame"] = min(region["first_frame"], segment["first_frame"])
        region["last_frame"] = max(region["last_frame"], segment["last_frame"])
        region["first_seconds"] = min(region["first_seconds"], segment["first_seconds"])
        region["last_seconds"] = max(region["last_seconds"], segment["last_seconds"])
    return {
        "capture": report["capture"],
        "bus": report["bus"],
        "device": report["device"],
        "commands": report["commands"],
        "write_payload_bytes": report["write_payload_bytes"],
        "write_regions": sorted(regions.values(), key=lambda region: region["first_frame"]),
        "scope": report["scope"],
        "warnings": report["warnings"],
    }


def main():
    parser = argparse.ArgumentParser(description="Inspect outbound NSP USBPcap commands offline.")
    parser.add_argument("capture", type=Path)
    parser.add_argument("--bus", required=True, type=int)
    parser.add_argument("--device", required=True, type=int)
    parser.add_argument("--tshark", default="tshark", help="Path to tshark or tshark.exe")
    parser.add_argument("--output", type=Path)
    parser.add_argument("--summary", action="store_true", help="Print a concise report without payload prefixes")
    parser.add_argument("--include-prefix", action="store_true", help="Include the first 32 payload bytes in full reports")
    parser.add_argument("--extract-high-address-payloads", action="store_true",
                        help="Write large high-address segments under --output")
    args = parser.parse_args()
    if args.extract_high_address_payloads and not args.output:
        parser.error("--extract-high-address-payloads requires --output")
    counts, write_bytes, segments = inspect_capture(args.capture, args.bus, args.device, args.tshark)
    report = {
        "capture": args.capture.name, "bus": args.bus, "device": args.device,
        "commands": counts, "write_payload_bytes": write_bytes,
        "outbound_crc_and_lengths_valid": True,
        "segments": [describe_segment(segment) for segment in segments],
        "scope": {
            "records": "outbound USBPcap submit commands on endpoint 0x01",
            "device_responses_analyzed": False,
            "flash_or_settings_completion_verified": False,
        },
        "warnings": [],
    }
    if any(segment["classification"] == "large-unclassified-write" for segment in report["segments"]):
        report["warnings"].append("Large write regions are unclassified; size and address do not prove firmware content.")
    if args.include_prefix:
        for segment, description in zip(segments, report["segments"]):
            description["prefix_hex"] = bytes(segment["data"][:32]).hex()
    if args.output:
        args.output.mkdir(parents=True, exist_ok=False)
        if args.extract_high_address_payloads:
            for index, (segment, description) in enumerate(zip(segments, report["segments"])):
                if segment["address"] >= 0x70000000 and len(segment["data"]) > 1024:
                    filename = f"segment-{index:03d}.bin"
                    (args.output / filename).write_bytes(segment["data"])
                    description["payload_file"] = filename
        (args.output / "report.json").write_text(json.dumps(report, indent=2) + "\n", encoding="utf-8")
    print(json.dumps(summarize(report) if args.summary else report, indent=2))


if __name__ == "__main__":
    main()