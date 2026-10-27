import io
import hashlib
import json
from http.server import BaseHTTPRequestHandler, ThreadingHTTPServer
from pathlib import Path
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
    return {"screen": screen, "revision": revision, "components": [
        {"index": component["component"], "values": {name: value(field) for name, field in component["fields"].items()}}
        for component in components
    ]}


def render_layout(device, screen):
    scene = scene_state(device, screen)
    with device.lock:
        resources = dict(device.resources.items)
    canvas = Image.new("RGBA", (860, 480), (16, 19, 20, 255))
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
        source = values.get("IMAGE_SRC", "")
        label = values.get("LABEL_TEXT", "")
        opacity = min(255, max(0, round(values.get("DAY_OPACITY", 1000) * 255 / 1000)))
        payload = resources.get((0, source)) or resources.get((0, "h/" + source))
        if payload:
            try:
                with Image.open(io.BytesIO(payload)) as image:
                    item = ImageOps.contain(image.convert("RGBA"), (width, height))
                    item.putalpha(item.getchannel("A").point(lambda alpha: alpha * opacity // 255))
                    canvas.alpha_composite(item, (left + (width - item.width) // 2, top + (height - item.height) // 2))
            except (OSError, ValueError):
                pass
        if kind not in (2, 7) or not payload:
            draw.rectangle((left, top, left + width, top + height), outline=(76, 108, 96), width=1)
            if label:
                draw.text((left + 5, top + 4), label[:40], fill=(224, 232, 228), font=font(14))
            draw.text((left + 5, top + 25), f"CH {values.get('CHANNEL', 0)}",
                      fill=(116, 213, 160), font=font(18))
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
                    recent = device.last_activity is not None and time.monotonic() - device.last_activity < 3
                    result = {"requests": device.requests, "connection": device.connection if recent else "Waiting for NSP",
                              "revision": [device.settings_revision, device.resources.revision],
                              "received_screen": device.last_screen is not None,
                              "received_screen_revision": hashlib.sha256(device.last_screen).hexdigest() if device.last_screen else None,
                              "events": list(reversed(device.events[-20:])),
                              "assets": [{"kind": kind, "name": name, "bytes": len(payload),
                                          "sha256": hashlib.sha256(payload).hexdigest()}
                                         for (kind, name), payload in sorted(device.resources.items.items())],
                              "staged_regions": sorted(device.staged),
                              "mode": "boot" if device.boot_mode else "main",
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
                                  "component_sha256": device.sandbox.component_sha256() if device.sandbox else None,
                                  "full_refresh": bool(full), "ranges": [event for event in events if event["revision"] > after]}
                    self.send(json.dumps(result).encode("utf-8"))
                except ValueError:
                    self.send(b"Invalid revision", "text/plain", 400)
            elif parsed.path == "/api/component":
                with device.lock:
                    payload = device.sandbox.component if device.sandbox and device.sandbox.component_active else None
                self.send(payload if payload is not None else b"No active sandbox component",
                          "application/octet-stream", 200 if payload is not None else 404)
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