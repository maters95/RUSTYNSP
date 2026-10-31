"""The device-frame layer: a swappable housing around the rendered 800x480 panel.

Two implementations share one interface (``compose(panel, leds, caption)``):

* ``PhotoHousing`` - a photo of an iC-7 (``--housing photo.jpg`` plus a JSON
  geometry file). The panel is perspective-warped into the photo's screen
  opening, the photo's own LED bar is darkened and its coloured light spill
  desaturated, and the simulated LED states are drawn into the same 14
  segments with a soft glow.
* ``ProceduralHousing`` - a clean drawn iC-7-style housing (no photo needed),
  laid out like the photo: 14-segment bar above the panel (7 + 7 either side
  of a centre divider), three buttons each side.

The photo is never committed; only its measured geometry (housing-geometry.json)
is, so a different photo just needs a new geometry file.
"""
import json
import math
from pathlib import Path

import numpy as np
from PIL import Image, ImageDraw, ImageFilter, ImageFont

HERE = Path(__file__).resolve().parent
CAPTION = "SIMULATION – rendered from map + firmware QML, not a recording"


def _font(size, bold=False):
    for name in (("DejaVuSans-Bold.ttf" if bold else "DejaVuSans.ttf"),
                 "/usr/share/fonts/truetype/dejavu/DejaVuSans.ttf"):
        try:
            return ImageFont.truetype(name, size)
        except OSError:
            continue
    return ImageFont.load_default()


def perspective_coefficients(quad, width, height):
    """PIL PERSPECTIVE coefficients mapping output (photo) pixels back to panel pixels."""
    source = [(0, 0), (width, 0), (width, height), (0, height)]
    matrix, vector = [], []
    for (x, y), (u, v) in zip(quad, source):
        matrix.append([x, y, 1, 0, 0, 0, -u * x, -u * y]); vector.append(u)
        matrix.append([0, 0, 0, x, y, 1, -v * x, -v * y]); vector.append(v)
    return np.linalg.solve(np.array(matrix, float), np.array(vector, float)).tolist()


def _caption(draw, size, text_lines, anchor="br"):
    font = _font(15)
    w, h = size
    y = h - 10
    for line in reversed(text_lines):
        box = draw.textbbox((0, 0), line, font=font)
        tw, th = box[2] - box[0], box[3] - box[1]
        x = w - tw - 14
        y -= th + 6
        draw.rectangle((x - 6, y - 3, x + tw + 6, y + th + 5), fill=(0, 0, 0, 150))
        draw.text((x - box[0], y - box[1]), line, font=font, fill=(235, 235, 235, 255))


def _glow_layer(shape_size, segments, colours, blur):
    """Additive LED light: lit segment cores plus a gaussian halo, as float RGB."""
    core = Image.new("RGB", shape_size, (0, 0, 0))
    draw = ImageDraw.Draw(core)
    any_lit = False
    for polygon, colour in zip(segments, colours):
        if colour is None:
            continue
        any_lit = True
        draw.polygon(polygon, fill=colour)
    if not any_lit:
        return None, None
    halo = core.filter(ImageFilter.GaussianBlur(blur))
    wide = core.filter(ImageFilter.GaussianBlur(blur * 3))
    light = (np.asarray(halo, np.float32) * 1.6 + np.asarray(wide, np.float32) * 0.9)
    return np.asarray(core, np.float32), light


def _segment_polygons(origin, angle_deg, bounds, top, bottom, gap):
    ux, uy = math.cos(math.radians(angle_deg)), math.sin(math.radians(angle_deg))
    nx, ny = -uy, ux
    polygons = []
    for start, end in zip(bounds[:-1], bounds[1:]):
        a, b = start + gap / 2, end - gap / 2
        corners = [(a, top), (b, top), (b, bottom), (a, bottom)]
        polygons.append([(origin[0] + s * ux + t * nx, origin[1] + s * uy + t * ny) for s, t in corners])
    return polygons


class PhotoHousing:
    def __init__(self, photo, geometry):
        self.geometry = json.loads(Path(geometry).read_text(encoding="utf-8"))
        image = Image.open(photo).convert("RGB")
        g = self.geometry
        w, h = image.size
        self.size = (w + w % 2, h + h % 2)
        base = Image.new("RGB", self.size, (0, 0, 0))
        base.paste(image, (0, 0))
        bar = g["led_bar"]
        self.segments = _segment_polygons(bar["origin"], bar["angle_deg"], bar["bounds"],
                                          bar["top"], bar["bottom"], bar["gap"])
        whole = _segment_polygons(bar["origin"], bar["angle_deg"], [bar["bounds"][0] - 3, bar["bounds"][-1] + 3],
                                  bar["top"] - 3, bar["bottom"] + 3, 0)[0]
        # 1. Desaturate the coloured light the photo's lit bar spills onto the bezel.
        spill = Image.new("L", self.size, 0)
        ImageDraw.Draw(spill).polygon(whole, fill=255)
        spill = spill.filter(ImageFilter.MaxFilter(41)).filter(ImageFilter.GaussianBlur(14))
        array = np.asarray(base, np.float32)
        grey = array.mean(axis=2, keepdims=True)
        weight = np.asarray(spill, np.float32)[..., None] / 255.0
        # Spill also brightened the bezel: pull it back towards the surrounding texture.
        array = array * (1 - weight) + np.minimum(grey, grey * 0.75 + 8) * weight
        # 2. Replace every LED segment with an unlit diffuser.
        lens = Image.new("L", self.size, 0)
        ImageDraw.Draw(lens).polygon(whole, fill=255)
        lens = np.asarray(lens.filter(ImageFilter.GaussianBlur(1.2)), np.float32)[..., None] / 255.0
        unlit = np.full_like(array, 0)
        unlit[..., 0], unlit[..., 1], unlit[..., 2] = 20, 21, 24
        diffuser = Image.new("RGB", self.size, (0, 0, 0))
        dd = ImageDraw.Draw(diffuser)
        for polygon in self.segments:
            dd.polygon(polygon, fill=(34, 35, 40))
        unlit = np.maximum(unlit, np.asarray(diffuser.filter(ImageFilter.GaussianBlur(0.8)), np.float32))
        array = array * (1 - lens) + unlit * lens
        self.base = array
        quad = [tuple(p) for p in g["screen_quad"]]
        self.coefficients = perspective_coefficients(quad, 800, 480)
        mask = Image.new("L", self.size, 0)
        ImageDraw.Draw(mask).polygon(quad, fill=255)
        self.mask = np.asarray(mask.filter(ImageFilter.GaussianBlur(0.6)), np.float32)[..., None] / 255.0
        # A faint, fixed glass reflection so the panel sits behind a cover lens.
        gloss = Image.new("L", self.size, 0)
        gd = ImageDraw.Draw(gloss)
        (x0, y0), (x1, y1), (x2, y2), (x3, y3) = quad
        gd.polygon([(x0, y0), (x0 + (x1 - x0) * 0.55, y0 + (y1 - y0) * 0.55),
                    (x3 + (x2 - x3) * 0.15, y3 + (y2 - y3) * 0.15), (x3, y3)], fill=16)
        self.gloss = np.asarray(gloss.filter(ImageFilter.GaussianBlur(30)), np.float32)[..., None] * self.mask
        self.blur = g.get("glow_blur", 4)

    def compose(self, panel, leds, caption_lines):
        warped = panel.transform(self.size, Image.PERSPECTIVE, self.coefficients, Image.BICUBIC)
        frame = self.base * (1 - self.mask) + np.asarray(warped, np.float32) * self.mask + self.gloss
        core, light = _glow_layer(self.size, self.segments, leds, self.blur)
        if core is not None:
            frame = np.maximum(frame, core * 0.92) + light * 0.55
        image = Image.fromarray(np.clip(frame, 0, 255).astype(np.uint8))
        overlay = Image.new("RGBA", self.size, (0, 0, 0, 0))
        _caption(ImageDraw.Draw(overlay), self.size, caption_lines)
        image.paste(overlay, (0, 0), overlay)
        return image


class ProceduralHousing:
    """A drawn, front-on iC-7-style housing (fallback when no photo is supplied)."""

    def __init__(self):
        self.size = (1080, 760)
        w, h = self.size
        image = Image.new("RGB", self.size, (14, 14, 16))
        d = ImageDraw.Draw(image)
        # Body with side "ears" carrying the buttons.
        body = (110, 70, w - 110, h - 70)
        d.rounded_rectangle((60, 150, w - 60, h - 150), radius=46, fill=(38, 38, 41))
        d.rounded_rectangle(body, radius=58, fill=(44, 44, 47))
        noise = np.random.default_rng(7).normal(0, 6, (h, w, 1)).astype(np.float32)
        array = np.asarray(image, np.float32) + noise * (np.asarray(image, np.float32).mean(2, keepdims=True) > 30)
        image = Image.fromarray(np.clip(array, 0, 255).astype(np.uint8))
        d = ImageDraw.Draw(image)
        # Panel opening (800 x 480 panel, thin black glass border).
        self.panel_box = (140 + 0, 150, 140 + 800, 150 + 480)
        px0, py0, px1, py1 = self.panel_box
        d.rounded_rectangle((px0 - 14, py0 - 14, px1 + 14, py1 + 14), radius=12, fill=(6, 6, 7))
        d.rounded_rectangle((px0 - 15, py0 - 15, px1 + 15, py1 + 15), radius=13, outline=(70, 70, 74), width=1)
        # LED bar: 14 segments, 7 + 7 around a centre divider, above the panel.
        bx0, bx1, by0, by1 = 200, 880, 96, 110
        d.rounded_rectangle((bx0 - 6, by0 - 5, bx1 + 6, by1 + 5), radius=6, fill=(10, 10, 12))
        seg = (bx1 - bx0) / 14.0
        self.segments = []
        for i in range(14):
            a = bx0 + i * seg + (3 if i != 7 else 6)
            b = bx0 + (i + 1) * seg - (3 if i != 6 else 6)
            polygon = [(a, by0), (b, by0), (b, by1), (a, by1)]
            self.segments.append(polygon)
            d.polygon(polygon, fill=(30, 31, 36))
        # Six buttons (GPIO 140-145 in the firmware pin table), three per side.
        for side, x in (("l", 78), ("r", w - 78)):
            for j, y in enumerate((260, 380, 500)):
                d.rounded_rectangle((x - 26, y - 26, x + 26, y + 26), radius=10, fill=(16, 16, 18),
                                    outline=(80, 80, 84), width=2)
        self.base = np.asarray(image, np.float32)
        self.blur = 4

    def compose(self, panel, leds, caption_lines):
        frame = self.base.copy()
        px0, py0, px1, py1 = self.panel_box
        frame[py0:py1, px0:px1] = np.asarray(panel, np.float32)
        core, light = _glow_layer(self.size, self.segments, leds, self.blur)
        if core is not None:
            frame = np.maximum(frame, core * 0.92) + light * 0.55
        image = Image.fromarray(np.clip(frame, 0, 255).astype(np.uint8))
        overlay = Image.new("RGBA", self.size, (0, 0, 0, 0))
        _caption(ImageDraw.Draw(overlay), self.size, caption_lines)
        image.paste(overlay, (0, 0), overlay)
        return image


def make_housing(photo=None, geometry=None):
    if photo:
        return PhotoHousing(photo, geometry or HERE / "housing-geometry.json")
    return ProceduralHousing()
