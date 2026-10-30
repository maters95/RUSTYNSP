#!/usr/bin/env python3
"""Validate and write the EXPERIMENTAL iC-7 add-on manifests from a simple spec.

    python make-addon-manifests.py spec.json --output upload-folder
    python make-addon-manifests.py --check upload-folder
    python make-addon-manifests.py --off [indicators|gauge_fx] --output off-folder

The spec is JSON with optional "indicators" and "gauge_fx" lists (see
samples/spec.json). Media may be given as a local file path (copied into the output
folder and referenced as "u/<filename>") or as "u/<name>" / "h/<name>" for a file
already uploaded / a stock dash image. The output folder then holds exactly the files
to put in the map's user_resources\\images folder: ic7_indicators.json,
ic7_gauge_fx.json and the media. Standard library only; works on Windows, macOS and
Linux. The rules match ic7addons.js on the dash: anything it would reject is rejected
here first.

--off writes empty "off" manifests (all, or just one kind). NSP's resource write never
deletes a file from the dash, so turning an add-on off means uploading one of these in
place of the old manifest, then power-cycling the dash.
"""
import argparse
import json
import math
from pathlib import Path
import re
import shutil
import sys

VERSION = 1
MAX_ENTRIES = 64
MAX_FRAMES = 32
NAME = re.compile(r"^[^/\\\x00-\x1f]{1,120}$")
SELECTED_IMAGE = re.compile(r"\.(png|jpe?g|bmp)$", re.I)
MEDIA = re.compile(r"^[uh]/[^/\\\x00-\x1f]{1,120}\.(gif|png|jpe?g|bmp|mp4)$", re.I)
FRAME_MEDIA = re.compile(r"^[uh]/[^/\\\x00-\x1f]{1,120}\.(gif|png|jpe?g|bmp)$", re.I)
COLOUR = re.compile(r"^#[0-9A-Fa-f]{6}$")
SAFE_FILENAME = re.compile(r"^[A-Za-z0-9][A-Za-z0-9._-]{0,119}$")
INDICATOR_KEYS = {"image", "on", "off", "frames", "hysteresis"}
FRAME_KEYS = {"min", "max", "source"}
FX_KEYS = {"channel", "trigger", "threshold", "effect", "colour", "rateHz", "width"}
# Sizes above these work but cost decode time/memory on the i.MX6; above the hard
# limit the helper refuses.
SIZE_WARN = {".gif": 2 * 1024 * 1024, ".mp4": 8 * 1024 * 1024}
SIZE_LIMIT = 24 * 1024 * 1024
RESERVED = {"ic7_indicators.json", "ic7_gauge_fx.json", "ic7_alerts.json", "ic7_splash.json"}
# Valid manifests with no entries: every component they configure draws as stock.
OFF_MANIFESTS = {
    "indicators": ("ic7_indicators.json", {"version": VERSION, "indicators": []}),
    "gauge_fx": ("ic7_gauge_fx.json", {"version": VERSION, "gauges": []}),
}


class SpecError(ValueError):
    pass


def number(value):
    return isinstance(value, (int, float)) and not isinstance(value, bool) and math.isfinite(value)


def validate_indicators(manifest):
    if not isinstance(manifest, dict) or manifest.get("version") != VERSION or \
            set(manifest) != {"version", "indicators"} or not isinstance(manifest["indicators"], list) or \
            len(manifest["indicators"]) > MAX_ENTRIES:
        raise SpecError("indicators manifest needs version 1 and 0-64 indicators")
    names = set()
    for i, entry in enumerate(manifest["indicators"]):
        where = f"indicator {i}"
        if not isinstance(entry, dict) or not set(entry) <= INDICATOR_KEYS or "image" not in entry:
            raise SpecError(f"{where}: unknown or missing fields (allowed: {sorted(INDICATOR_KEYS)})")
        image = entry["image"]
        if not isinstance(image, str) or not NAME.match(image) or not SELECTED_IMAGE.search(image) or image in names:
            raise SpecError(f"{where}: image must be a unique png/jpg/bmp filename")
        names.add(image)
        for role in ("on", "off"):
            if role in entry and (not isinstance(entry[role], str) or not MEDIA.match(entry[role])):
                raise SpecError(f"{where}: invalid {role} media {entry[role]!r}")
        if "frames" in entry:
            frames = entry["frames"]
            if not isinstance(frames, list) or not 1 <= len(frames) <= MAX_FRAMES:
                raise SpecError(f"{where}: frames must hold 1-32 ranges")
            for f, frame in enumerate(frames):
                if not isinstance(frame, dict) or set(frame) != FRAME_KEYS or not number(frame["min"]) or \
                        not number(frame["max"]) or not frame["min"] < frame["max"] or \
                        not isinstance(frame["source"], str) or not FRAME_MEDIA.match(frame["source"]):
                    raise SpecError(f"{where} frame {f}: need min < max and a gif/png/jpg/bmp source")
        if "hysteresis" in entry and ("frames" not in entry or not number(entry["hysteresis"]) or
                                      entry["hysteresis"] < 0):
            raise SpecError(f"{where}: hysteresis must be >= 0 and needs frames")
        if not {"on", "off", "frames"} & set(entry):
            raise SpecError(f"{where}: needs on, off or frames")


def validate_gauge_fx(manifest):
    if not isinstance(manifest, dict) or manifest.get("version") != VERSION or \
            set(manifest) != {"version", "gauges"} or not isinstance(manifest["gauges"], list) or \
            len(manifest["gauges"]) > MAX_ENTRIES:
        raise SpecError("gauge_fx manifest needs version 1 and 0-64 gauges")
    names = set()
    for i, entry in enumerate(manifest["gauges"]):
        where = f"gauge {i}"
        if not isinstance(entry, dict) or not set(entry) <= FX_KEYS:
            raise SpecError(f"{where}: unknown fields (allowed: {sorted(FX_KEYS)})")
        channel = entry.get("channel")
        if not isinstance(channel, str) or not channel.strip() or len(channel) > 64 or channel.strip() in names:
            raise SpecError(f"{where}: channel must be a unique, nonempty name (as shown on the gauge)")
        names.add(channel.strip())
        if entry.get("trigger") not in ("warn", "above", "below"):
            raise SpecError(f"{where}: trigger must be warn, above or below")
        if (entry["trigger"] == "warn") != ("threshold" not in entry) or \
                ("threshold" in entry and not number(entry["threshold"])):
            raise SpecError(f"{where}: above/below need a numeric threshold; warn takes none")
        if entry.get("effect") not in ("flash", "pulse", "solid"):
            raise SpecError(f"{where}: effect must be flash, pulse or solid")
        if "colour" in entry and (not isinstance(entry["colour"], str) or not COLOUR.match(entry["colour"])):
            raise SpecError(f"{where}: colour must be #RRGGBB")
        if "rateHz" in entry and (not number(entry["rateHz"]) or not 0.5 <= entry["rateHz"] <= 5):
            raise SpecError(f"{where}: rateHz must be 0.5-5")
        if "width" in entry and (not isinstance(entry["width"], int) or isinstance(entry["width"], bool) or
                                 not 2 <= entry["width"] <= 12):
            raise SpecError(f"{where}: width must be an integer 2-12")


def sniff(data):
    if data[:6] in (b"GIF87a", b"GIF89a"):
        return ".gif"
    if data[:8] == b"\x89PNG\r\n\x1a\n":
        return ".png"
    if data[:3] == b"\xff\xd8\xff":
        return ".jpg"
    if data[:2] == b"BM":
        return ".bmp"
    if len(data) >= 12 and data[4:8] == b"ftyp":
        return ".mp4"
    return None


class Collector:
    """Copies local media into the output folder, once per filename."""

    def __init__(self, spec_dir, output, warnings):
        self.spec_dir, self.output, self.warnings = spec_dir, output, warnings
        self.files = {}

    def media(self, value, where, allow_video=True):
        if not isinstance(value, str) or not value:
            raise SpecError(f"{where}: media must be a file path or u/<name> or h/<name>")
        if re.match(r"^[uh]/", value):
            return value
        path = Path(value)
        if not path.is_absolute():
            path = self.spec_dir / path
        if not path.is_file():
            raise SpecError(f"{where}: media file not found: {path}")
        name = path.name
        if not SAFE_FILENAME.match(name) or name.lower() in RESERVED:
            raise SpecError(f"{where}: rename {name!r} to letters, digits, '.', '_' or '-' only "
                            "(and not a manifest name)")
        data = path.read_bytes()
        kind = sniff(data)
        extension = path.suffix.lower().replace(".jpeg", ".jpg")
        if kind is None or kind != extension:
            raise SpecError(f"{where}: {name} content is {kind or 'unknown'}, not {extension}")
        if kind == ".mp4" and not allow_video:
            raise SpecError(f"{where}: value frames take gif/png/jpg/bmp, not MP4")
        if len(data) > SIZE_LIMIT:
            raise SpecError(f"{where}: {name} is {len(data)} bytes; keep media under {SIZE_LIMIT} bytes")
        if len(data) > SIZE_WARN.get(kind, SIZE_LIMIT):
            self.warnings.append(f"{name}: {len(data) // 1024} KiB is large for the dash; "
                                 "prefer small, short, low-frame-rate media")
        if name in self.files and self.files[name] != data:
            raise SpecError(f"{where}: two different files are both named {name}")
        self.files[name] = data
        return "u/" + name

    def write(self):
        for name, data in self.files.items():
            (self.output / name).write_bytes(data)


def build(spec, spec_dir, output):
    if not isinstance(spec, dict) or not set(spec) <= {"indicators", "gauge_fx"} or not spec:
        raise SpecError('spec must be an object with "indicators" and/or "gauge_fx"')
    warnings = []
    collector = Collector(spec_dir, output, warnings)
    manifests = {}
    if "indicators" in spec:
        indicators = []
        for i, item in enumerate(spec["indicators"] if isinstance(spec["indicators"], list) else [None]):
            if not isinstance(item, dict):
                raise SpecError(f"indicator {i}: must be an object")
            entry = {key: value for key, value in item.items() if key not in ("on", "off", "frames", "image_file")}
            if "image_file" in item:
                # Optional: also ship the image to select for the indicator in NSP.
                copied = collector.media(item["image_file"], f"indicator {i} image_file", allow_video=False)
                if copied != "u/" + str(item.get("image")):
                    raise SpecError(f"indicator {i}: image_file must be named {item.get('image')!r}")
            for role in ("on", "off"):
                if role in item:
                    entry[role] = collector.media(item[role], f"indicator {i} {role}")
            if "frames" in item:
                if not isinstance(item["frames"], list):
                    raise SpecError(f"indicator {i}: frames must be a list")
                entry["frames"] = []
                for f, frame in enumerate(item["frames"]):
                    if not isinstance(frame, dict) or "file" not in frame and "source" not in frame:
                        raise SpecError(f"indicator {i} frame {f}: needs min, max and file")
                    source = collector.media(frame.get("file", frame.get("source")),
                                             f"indicator {i} frame {f}", allow_video=False)
                    entry["frames"].append({"min": frame.get("min"), "max": frame.get("max"), "source": source})
            indicators.append(entry)
        manifests["ic7_indicators.json"] = {"version": VERSION, "indicators": indicators}
        validate_indicators(manifests["ic7_indicators.json"])
    if "gauge_fx" in spec:
        manifests["ic7_gauge_fx.json"] = {"version": VERSION, "gauges": spec["gauge_fx"]}
        validate_gauge_fx(manifests["ic7_gauge_fx.json"])
        for entry in spec["gauge_fx"]:
            if entry["effect"] == "flash" and entry.get("rateHz", 2) > 3:
                warnings.append(f"{entry['channel']}: flashing faster than 3 Hz can be distracting; "
                                "the stock warning colour is never changed by the effect")
    output.mkdir(parents=True, exist_ok=True)
    collector.write()
    for name, manifest in manifests.items():
        (output / name).write_text(json.dumps(manifest, indent=2) + "\n", encoding="utf-8")
    return sorted(manifests) + sorted(collector.files), warnings


def write_off(output, which="all"):
    output.mkdir(parents=True, exist_ok=True)
    written = []
    for kind, (name, manifest) in OFF_MANIFESTS.items():
        if which in ("all", kind):
            (output / name).write_text(json.dumps(manifest, indent=2) + "\n", encoding="utf-8")
            written.append(name)
    return written


def check(folder):
    problems = []
    found = False
    for name, validate in (("ic7_indicators.json", validate_indicators), ("ic7_gauge_fx.json", validate_gauge_fx)):
        path = folder / name
        if not path.is_file():
            continue
        found = True
        try:
            manifest = json.loads(path.read_text(encoding="utf-8"))
            validate(manifest)
        except (ValueError, SpecError) as error:
            problems.append(f"{name}: {error}")
            continue
        sources = []
        for entry in manifest.get("indicators", []):
            sources += [entry[r] for r in ("on", "off") if r in entry]
            sources += [frame["source"] for frame in entry.get("frames", [])]
        for source in sources:
            if source.startswith("u/") and not (folder / source[2:]).is_file():
                problems.append(f"{name}: {source} is not in {folder}")
    if not found:
        problems.append(f"no add-on manifest in {folder}")
    return problems


def main(argv=None):
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("spec", nargs="?", type=Path, help="Spec JSON (see samples/spec.json)")
    parser.add_argument("--output", type=Path, help="Folder to write manifests and media into")
    parser.add_argument("--check", type=Path, metavar="FOLDER", help="Validate manifests already in FOLDER")
    parser.add_argument("--off", nargs="?", const="all", choices=["all", *OFF_MANIFESTS],
                        help="Write empty 'off' manifests (all, or one kind) into --output")
    args = parser.parse_args(argv)
    if args.off:
        if not args.output or args.spec or args.check:
            parser.error("--off takes only --output")
        written = write_off(args.output, args.off)
        print(f"Wrote {len(written)} off manifests to {args.output}: {', '.join(written)}")
        print("Upload them in place of the old manifests, then power-cycle the dash.")
        return 0
    if args.check:
        problems = check(args.check)
        for problem in problems:
            print("ERROR: " + problem, file=sys.stderr)
        if not problems:
            print(f"{args.check}: add-on manifests valid")
        return 1 if problems else 0
    if not args.spec or not args.output:
        parser.error("give a spec and --output, or --check FOLDER")
    try:
        spec = json.loads(args.spec.read_text(encoding="utf-8"))
        written, warnings = build(spec, args.spec.resolve().parent, args.output)
    except (OSError, ValueError, SpecError) as error:
        print("ERROR: " + str(error), file=sys.stderr)
        return 1
    for warning in warnings:
        print("WARNING: " + warning, file=sys.stderr)
    print(f"Wrote {len(written)} files to {args.output}:")
    for name in written:
        print("  " + name)
    return 0


if __name__ == "__main__":
    sys.exit(main())
