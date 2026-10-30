import io
import hashlib
import json
import math
from http.server import BaseHTTPRequestHandler, ThreadingHTTPServer
from pathlib import Path, PurePosixPath
import threading
from urllib.parse import parse_qs, urlparse

from PIL import Image, ImageDraw, ImageFont, ImageOps
import time


def font(size):
    for name in ("DejaVuSans.ttf", "C:/Windows/Fonts/segoeui.ttf"):
        try:
            return ImageFont.truetype(name, size)
        except OSError:
            continue
    return ImageFont.load_default()


def is_video_resource(name):
    filename = name.rsplit("/", 1)[-1].lower()
    return filename.endswith(".mp4") or (filename.startswith("ic7_video_") and filename.endswith(".png"))


def scene_state(device, screen):
    schema_path = Path(__file__).with_name("viewer-schema.json")
    schema = json.loads(schema_path.read_text(encoding="utf-8")) if schema_path.exists() else {"components": []}
    with device.lock:
        settings = device.memory.read(0x20000, 651264)
        display = device.display_state()
        revision = [device.settings_revision, device.resources.revision]

    def value(field, default=0):
        if field is None:
            return default
        address = field["address"]
        data = settings[address:address + field["bytes"]]
        if field.get("string"):
            return data.split(b"\0", 1)[0].decode("utf-8", errors="replace")
        return int.from_bytes(data, "little", signed=field.get("signed", False))

    components = [component for component in schema["components"] if component["screen"] == screen]
    return {"screen": screen, "revision": revision, "display": display, "components": [
        {"index": component["component"], "values": {name: value(field) for name, field in component["fields"].items()}}
        for component in components if display["phase"] == "dash"
    ]}


# GAUGE_TYPE groupings (match native_view COMPONENTS mapping).
CIRCULAR_TYPES = {4, 5, 6, 16}
NUMERIC_TYPES = {3, 17}
BAR_H_TYPES = {13, 14, 15, 19}
BAR_V_TYPES = {9, 10, 20, 21}
INDICATOR_TYPES = {7}
TEXT_TYPES = {18}

# NSP-like palette.
COL_TILE = (17, 23, 28)
COL_TILE_EDGE = (44, 60, 54)
COL_LABEL = (138, 160, 160)
COL_VALUE = (233, 242, 236)
COL_ACCENT = (63, 216, 200)
COL_TRACK = (36, 46, 44)
COL_WARN = (255, 92, 77)

# Keyword -> (unit, vmin, vmax, base, amplitude, period_s, decimals, warn_above|None).
# These are SIMULATED display values only; the emulator holds no live ECU telemetry.
_PROFILES = [
    (("rpm", "engine speed"), ("rpm", 0, 8000, 2600, 1600, 5.0, 0, 7200)),
    (("coolant",), ("°C", 40, 120, 88, 4, 11.0, 0, 108)),
    (("oil temp",), ("°C", 40, 150, 97, 6, 13.0, 0, 130)),
    (("intake", "iat", "air temp"), ("°C", 0, 90, 34, 5, 9.0, 0, None)),
    (("ethanol",), ("%", 0, 100, 10, 0, 1.0, 0, None)),
    (("oil press",), ("psi", 0, 120, 62, 10, 4.0, 0, None)),
    (("fuel press",), ("psi", 0, 100, 43, 3, 4.0, 0, None)),
    (("boost", "manifold", "map"), ("psi", -15, 30, 7, 11, 3.5, 1, 26)),
    (("air fuel", "afr"), ("", 10, 20, 14.2, 1.3, 2.5, 1, None)),
    (("lambda",), ("λ", 0.7, 1.3, 0.99, 0.08, 2.5, 2, None)),
    (("battery", "volt"), ("V", 10, 16, 13.9, 0.2, 6.0, 1, None)),
    (("speed",), ("km/h", 0, 220, 64, 42, 8.0, 0, None)),
    (("throttle", "tps", "pedal"), ("%", 0, 100, 28, 26, 4.0, 0, None)),
    (("egt", "exhaust"), ("°C", 0, 1000, 640, 120, 6.0, 0, 950)),
    (("fuel level",), ("%", 0, 100, 56, 1, 20.0, 0, None)),
    (("gear",), ("", 0, 6, 3, 2, 6.0, 0, None)),
]
_DEFAULT_PROFILE = ("", 0, 100, 50, 22, 6.0, 0, None)


def simulate(label, channel, now):
    text = (label or "").lower()
    profile = next((spec for keys, spec in _PROFILES if any(key in text for key in keys)), _DEFAULT_PROFILE)
    unit, vmin, vmax, base, amp, period, decimals, warn = profile
    phase = (channel % 97) / 97.0 * 6.283185
    value = base + amp * math.sin(now / period * 6.283185 + phase)
    value = max(vmin, min(vmax, value))
    if decimals == 0:
        value = round(value)
    frac = (value - vmin) / (vmax - vmin) if vmax > vmin else 0.0
    return {"value": value, "min": vmin, "max": vmax, "unit": unit, "decimals": decimals,
            "frac": max(0.0, min(1.0, frac)), "warn": warn is not None and value >= warn}


def _fmt(value, decimals):
    return f"{value:.{decimals}f}" if decimals else str(int(round(value)))


def _centered(draw, box, text, fnt, fill):
    left, top, right, bottom = box
    bbox = draw.textbbox((0, 0), text, font=fnt)
    tw, th = bbox[2] - bbox[0], bbox[3] - bbox[1]
    draw.text((left + (right - left - tw) / 2 - bbox[0], top + (bottom - top - th) / 2 - bbox[1]), text, font=fnt, fill=fill)


def _tile(draw, box, radius=6):
    draw.rounded_rectangle(box, radius=radius, fill=COL_TILE, outline=COL_TILE_EDGE, width=1)


def _draw_numeric(draw, box, label, sim):
    left, top, right, bottom = box
    _tile(draw, box)
    height = bottom - top
    value_col = COL_WARN if sim["warn"] else COL_VALUE
    if label:
        draw.text((left + 8, top + 5), label[:26], fill=COL_LABEL, font=font(max(10, min(14, height // 4))))
        draw.line((left + 8, top + 20, right - 8, top + 20), fill=COL_TILE_EDGE, width=1)
    num = _fmt(sim["value"], sim["decimals"])
    unit = sim["unit"]
    value_font = font(max(16, min(40, int(height * 0.5))))
    unit_font = font(max(10, min(16, int(height * 0.24))))
    num_w = draw.textlength(num, font=value_font)
    unit_w = draw.textlength(unit, font=unit_font) + 5 if unit else 0
    nbox = draw.textbbox((0, 0), num, font=value_font)
    num_h = nbox[3] - nbox[1]
    x = left + (right - left - (num_w + unit_w)) / 2
    y = top + (height - num_h) / 2 + height * 0.10 - nbox[1]
    draw.text((x, y), num, font=value_font, fill=value_col)
    if unit:
        ubox = draw.textbbox((0, 0), unit, font=unit_font)
        uy = y + nbox[1] + num_h - (ubox[3] - ubox[1]) - ubox[1]
        draw.text((x + num_w + 5, uy), unit, font=unit_font, fill=COL_LABEL)


def _draw_bar(draw, box, label, sim, vertical):
    left, top, right, bottom = box
    _tile(draw, box)
    fill_col = COL_WARN if sim["warn"] else COL_ACCENT
    if label:
        draw.text((left + 7, top + 4), label[:24], fill=COL_LABEL, font=font(12))
    pad = 8
    if vertical:
        track = (left + pad, top + 22, right - pad, bottom - 20)
        draw.rounded_rectangle(track, radius=4, fill=COL_TRACK)
        h = (track[3] - track[1]) * sim["frac"]
        draw.rounded_rectangle((track[0], track[3] - h, track[2], track[3]), radius=4, fill=fill_col)
    else:
        track = (left + pad, bottom - 24, right - pad, bottom - 12)
        draw.rounded_rectangle(track, radius=4, fill=COL_TRACK)
        w = (track[2] - track[0]) * sim["frac"]
        draw.rounded_rectangle((track[0], track[1], track[0] + w, track[3]), radius=4, fill=fill_col)
    vtext = _fmt(sim["value"], sim["decimals"]) + (" " + sim["unit"] if sim["unit"] else "")
    draw.text((right - 7 - draw.textlength(vtext, font=font(15)), top + 3), vtext, fill=COL_VALUE, font=font(15))


def _draw_circular(canvas, draw, box, label, sim):
    left, top, right, bottom = box
    size = min(right - left, bottom - top)
    cx, cy = (left + right) / 2, (top + bottom) / 2
    r = size / 2 - 4
    start, sweep = 135, 270  # NSP-style 270-degree sweep
    draw.arc((cx - r, cy - r, cx + r, cy + r), start, start + sweep, fill=COL_TRACK, width=max(4, int(r / 7)))
    end = start + sweep * sim["frac"]
    draw.arc((cx - r, cy - r, cx + r, cy + r), start, end, fill=COL_WARN if sim["warn"] else COL_ACCENT, width=max(4, int(r / 7)))
    angle = math.radians(end)
    draw.line((cx, cy, cx + (r - 6) * math.cos(angle), cy + (r - 6) * math.sin(angle)), fill=COL_VALUE, width=max(2, int(r / 16)))
    draw.ellipse((cx - 4, cy - 4, cx + 4, cy + 4), fill=COL_VALUE)
    _centered(draw, (left, int(cy + r / 3), right, bottom), _fmt(sim["value"], sim["decimals"]), font(max(14, int(r / 2))), COL_VALUE)
    if label:
        _centered(draw, (left, top - 2, right, top + 18), label[:22], font(12), COL_LABEL)
    if sim["unit"]:
        _centered(draw, (left, int(cy + r / 3 + r / 2), right, bottom - 2), sim["unit"], font(12), COL_LABEL)


def _draw_indicator(canvas, draw, box, label, resources, source, on):
    left, top, right, bottom = box
    payload = resources.get((0, source)) or resources.get((0, "h/" + source)) if source else None
    if payload:
        try:
            with Image.open(io.BytesIO(payload)) as image:
                item = ImageOps.contain(image.convert("RGBA"), (right - left, bottom - top))
                if not on:
                    item.putalpha(item.getchannel("A").point(lambda a: a * 55 // 255))
                canvas.alpha_composite(item, (int(left + (right - left - item.width) / 2), int(top + (bottom - top - item.height) / 2)))
            return
        except (OSError, ValueError):
            pass
    colour = COL_ACCENT if on else COL_TRACK
    draw.ellipse(box, fill=colour, outline=COL_TILE_EDGE)
    if label:
        _centered(draw, box, label[:3].upper(), font(12), COL_TILE)


def _seek_frame(image, now):
    """Advance an animated GIF/APNG to the frame for the current time (in place)."""
    try:
        count = getattr(image, "n_frames", 1)
        if count <= 1:
            return
        durations = []
        for index in range(count):
            image.seek(index)
            durations.append(image.info.get("duration") or 100)
        total = sum(durations) or count * 100
        elapsed = (now * 1000) % total
        accumulated = 0
        target = 0
        for index, duration in enumerate(durations):
            accumulated += duration
            if elapsed < accumulated:
                target = index
                break
        image.seek(target)
    except (EOFError, OSError, ValueError):
        pass


def render_layout(device, screen):
    scene = scene_state(device, screen)
    with device.lock:
        resources = dict(device.resources.items)
    now = time.monotonic()
    canvas = Image.new("RGBA", (860, 480), (0, 0, 0, 255))
    display = scene["display"]
    if display["phase"] == "splash":
        payload = resources.get((0, display["splash_source"]))
        if payload:
            try:
                with Image.open(io.BytesIO(payload)) as image:
                    _seek_frame(image, now)
                    item = ImageOps.contain(image.convert("RGBA"), canvas.size)
                    canvas.alpha_composite(item, ((canvas.width - item.width) // 2,
                                                  (canvas.height - item.height) // 2))
            except (OSError, ValueError):
                pass
        return canvas.convert("RGB").resize((800, 480), Image.Resampling.LANCZOS)
    if display["phase"] == "blank":
        return canvas.convert("RGB").resize((800, 480), Image.Resampling.LANCZOS)
    draw = ImageDraw.Draw(canvas)
    components = sorted(scene["components"], key=lambda component: component["values"].get("Z_POS", 0))
    for component in components:
        values = component["values"]
        kind = values.get("GAUGE_TYPE", 0)
        if kind == 0:
            continue
        left = values.get("X_POS", 0)
        top = values.get("Y_POS", 0)
        width = min(1720, max(1, values.get("X_SIZE", 100)))
        height = min(960, max(1, values.get("Y_SIZE", 60)))
        if left > 860 or top > 480 or left + width < 0 or top + height < 0:
            continue
        box = (left, top, left + width, top + height)
        source = values.get("IMAGE_SRC", "")
        label = values.get("LABEL_TEXT", "")
        channel = values.get("CHANNEL", 0)
        if kind == 2:  # image / background
            opacity = min(255, max(0, round(values.get("DAY_OPACITY", 1000) * 255 / 1000)))
            payload = resources.get((0, source)) or resources.get((0, "h/" + source))
            if payload:
                try:
                    with Image.open(io.BytesIO(payload)) as image:
                        _seek_frame(image, now)
                        item = ImageOps.contain(image.convert("RGBA"), (width, height))
                        item.putalpha(item.getchannel("A").point(lambda alpha: alpha * opacity // 255))
                        canvas.alpha_composite(item, (left + (width - item.width) // 2, top + (height - item.height) // 2))
                except (OSError, ValueError):
                    draw.rectangle(box, outline=COL_TILE_EDGE, width=1)
            continue
        if kind in INDICATOR_TYPES:
            _draw_indicator(canvas, draw, box, label, resources, source, (channel + int(now)) % 5 != 0)
            continue
        sim = simulate(label, channel, now)
        if kind in CIRCULAR_TYPES:
            _draw_circular(canvas, draw, box, label, sim)
        elif kind in BAR_H_TYPES:
            _draw_bar(draw, box, label, sim, vertical=False)
        elif kind in BAR_V_TYPES:
            _draw_bar(draw, box, label, sim, vertical=True)
        elif kind in TEXT_TYPES:
            _tile(draw, box)
            _centered(draw, box, label[:30] or f"CH {channel}", font(16), COL_VALUE)
        else:  # numeric and any unmapped active gauge
            _draw_numeric(draw, box, label, sim)
    return canvas.convert("RGB").resize((800, 480), Image.Resampling.LANCZOS)


def start_viewer(device, port=8765):
    class Handler(BaseHTTPRequestHandler):
        def send(self, payload, content_type="application/json", status=200):
            try:
                self.send_response(status)
                self.send_header("Content-Type", content_type)
                self.send_header("Content-Length", str(len(payload)))
                self.send_header("Cache-Control", "no-store")
                self.end_headers()
                self.wfile.write(payload)
                return True
            except ConnectionError:
                self.close_connection = True
                return False

        def do_GET(self):
            parsed = urlparse(self.path)
            query = parse_qs(parsed.query)
            if parsed.path == "/":
                self.send(Path(__file__).with_name("viewer.html").read_bytes(), "text/html; charset=utf-8")
            elif parsed.path == "/api/status":
                with device.lock:
                    display = device.display_state()
                    recent = device.last_activity is not None and time.monotonic() - device.last_activity < 3
                    result = {"requests": device.requests, "connection": device.connection if recent else "Waiting for NSP",
                              "revision": [device.settings_revision, device.resources.revision],
                              "received_screen": device.last_screen is not None,
                              "received_screen_revision": hashlib.sha256(device.last_screen).hexdigest() if device.last_screen else None,
                              "events": list(reversed(device.events[-20:])),
                              "assets": [{"kind": kind, "name": name, "bytes": len(payload),
                                          "sha256": device.resources.digests[(kind, name)]}
                                         for (kind, name), payload in sorted(device.resources.items.items())],
                              "staged_regions": sorted(device.staged),
                              "mode": "boot" if device.boot_mode else "main",
                              "display": display,
                              "sandbox_update": device.sandbox.summary() if device.sandbox else None,
                              "firmware_execution": False}
                self.send(json.dumps(result).encode("utf-8"))
            elif parsed.path == "/api/scene":
                try:
                    screen = min(15, max(0, int(query.get("screen", ["0"])[0])))
                    self.send(json.dumps(scene_state(device, screen)).encode("utf-8"))
                except ValueError:
                    self.send(b"Invalid screen", "text/plain", 400)
            elif parsed.path == "/api/memory":
                try:
                    address = int(query.get("address", ["0"])[0])
                    length = int(query.get("length", ["0"])[0])
                    if address < 0 or not 0 < length <= 16384 or address + length > (1 << 48):
                        raise ValueError("Invalid memory range")
                    with device.lock:
                        payload = device.memory.read(address, length)
                    self.send(payload, "application/octet-stream")
                except ValueError:
                    self.send(b"Invalid memory range", "text/plain", 400)
            elif parsed.path == "/api/changes":
                try:
                    after = int(query.get("after", ["-1"])[0])
                    with device.lock:
                        events = device.dirty_settings
                        full = after < 0 or after > device.settings_revision or (events and after < events[0]["revision"] - 1)
                        result = {"revision": device.settings_revision, "resource_revision": device.resources.revision,
                                  "install": {"revision": device.install.get("revision", 0),
                                              "source": device.install.get("source"),
                                              "payload_sha256": device.install.get("payload_sha256")},
                                  "full_refresh": bool(full), "ranges": [event for event in events if event["revision"] > after]}
                    self.send(json.dumps(result).encode("utf-8"))
                except ValueError:
                    self.send(b"Invalid revision", "text/plain", 400)
            elif parsed.path == "/api/install":
                with device.lock:
                    manifest = dict(device.install)
                self.send(json.dumps(manifest).encode("utf-8"))
            elif parsed.path == "/api/install/file":
                name = query.get("name", [""])[0]
                with device.lock:
                    listed = any(entry["name"] == name and entry["type"] == "file"
                                 for entry in device.install.get("members", []))
                    path = device.resources_root.joinpath(*PurePosixPath(name).parts) if listed else None
                    payload = path.read_bytes() if path is not None and path.is_file() else None
                self.send(payload if payload is not None else b"not installed",
                          "application/octet-stream", 200 if payload is not None else 404)
            elif parsed.path == "/api/fidelity":
                with device.lock:
                    report = device.fidelity_report()
                if query.get("format", ["json"])[0] == "text":
                    from dash_layout import render_report_text
                    self.send(render_report_text(report).encode("utf-8"), "text/plain; charset=utf-8")
                else:
                    self.send(json.dumps(report).encode("utf-8"))
            elif parsed.path == "/api/resource":
                try:
                    kind = int(query.get("kind", ["0"])[0])
                    name = query.get("name", [""])[0]
                    with device.lock:
                        payload = device.resources.items.get((kind, name))
                    status = 200 if payload is not None else 404
                    body = payload if payload is not None else b"not found"
                    sent = self.send(body, "application/octet-stream", status)
                    if sent and device.capture is not None:
                        try:
                            device.capture.record_viewer_resource(name, kind, status, body)
                        except OSError:
                            device.log.exception("protocol-capture-write-failed; disabling capture")
                            device.capture.close()
                            device.capture = None
                except ValueError:
                    self.send(b"Invalid resource type", "text/plain", 400)
            elif parsed.path == "/asset":
                name = query.get("name", [""])[0]
                with device.lock:
                    payload = device.resources.items.get((0, name))
                if payload is None:
                    self.send(b"not found", "text/plain", 404)
                elif is_video_resource(name):
                    self.send(payload, "video/mp4")
                else:
                    try:
                        with Image.open(io.BytesIO(payload)) as image:
                            content_type = Image.MIME.get(image.format, "application/octet-stream")
                        self.send(payload, content_type)
                    except OSError:
                        self.send(b"unsupported image", "text/plain", 415)
            elif parsed.path in ("/layout.png", "/received.png"):
                try:
                    if parsed.path == "/layout.png":
                        screen = min(15, max(0, int(query.get("screen", ["0"])[0])))
                        image = render_layout(device, screen)
                    else:
                        with device.lock:
                            payload = device.last_screen
                        if payload is None:
                            self.send(b"No screen image received", "text/plain", 404)
                            return
                        image = Image.open(io.BytesIO(payload)).convert("RGB")
                    output = io.BytesIO()
                    image.save(output, format="PNG")
                    self.send(output.getvalue(), "image/png")
                except (OSError, ValueError):
                    self.send(b"Invalid image request", "text/plain", 400)
            else:
                self.send(b"not found", "text/plain", 404)

        def log_message(self, *_):
            pass

    server = ThreadingHTTPServer(("127.0.0.1", port), Handler)
    server.daemon_threads = True
    threading.Thread(target=server.serve_forever, daemon=True).start()
    return server