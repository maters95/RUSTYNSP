import argparse
import hashlib
import json
import math
from pathlib import Path
import zipfile

from PIL import Image, ImageDraw, ImageFont


SIZE = (860, 480)
FRAME_MS = 100
FRAME_COUNT = 24
BACKGROUND = (13, 17, 24)
WHITE = (247, 241, 220)
RED = (239, 66, 49)
YELLOW = (255, 195, 53)
FONT = Path("/usr/share/fonts/truetype/dejavu/DejaVuSans-Bold.ttf")
ALARMS = (
    ("overboost-danger-to-manifold.gif", "OVERBOOST", ("DANGER TO", "MANIFOLD"), "boost"),
    ("low-oil-pressure-cunts-fucked.gif", "LOW OIL PRESSURE", ("CUNT'S", "FUCKED"), "oil"),
    ("coolant-temp-fuck-me-its-hot.gif", "COOLANT TEMP HIGH", ("FUCK ME,", "IT'S HOT"), "heat"),
)


def font(size):
    return ImageFont.truetype(str(FONT), size)


def fitted_text(draw, text, box, colour=WHITE, maximum=104):
    left, top, right, bottom = box
    for size in range(maximum, 11, -1):
        face = font(size)
        bounds = draw.textbbox((0, 0), text, font=face)
        if bounds[2] - bounds[0] <= right - left and bounds[3] - bounds[1] <= bottom - top:
            break
    x = (left + right - bounds[2] + bounds[0]) / 2
    y = (top + bottom - bounds[3] + bounds[1]) / 2
    draw.text((x - bounds[0], y - bounds[1]), text, font=face, fill=colour)


def mechanic(draw, phase, hot):
    bob = round(3 * math.sin(phase))
    draw.rounded_rectangle((64, 305 + bob, 250, 403 + bob), 28, fill=(49, 73, 91))
    draw.polygon([(143, 318 + bob), (158, 354 + bob), (177, 318 + bob)], fill=YELLOW)
    draw.rounded_rectangle((140, 283 + bob, 178, 330 + bob), 12, fill=(201, 140, 99))
    draw.ellipse((91, 157 + bob, 226, 307 + bob), fill=(222, 164, 119))
    draw.ellipse((80, 216 + bob, 102, 248 + bob), fill=(222, 164, 119))
    draw.ellipse((217, 216 + bob, 237, 248 + bob), fill=(222, 164, 119))
    draw.pieslice((87, 136 + bob, 227, 247 + bob), 180, 360, fill=(48, 96, 103))
    draw.rounded_rectangle((78, 186 + bob, 243, 204 + bob), 8, fill=(62, 126, 128))
    draw.line((117, 219 + bob, 142, 223 + bob), fill=BACKGROUND, width=5)
    draw.line((175, 223 + bob, 202, 216 + bob), fill=BACKGROUND, width=5)
    draw.ellipse((124, 230 + bob, 137, 245 + bob), fill=BACKGROUND)
    draw.ellipse((180, 230 + bob, 193, 245 + bob), fill=BACKGROUND)
    draw.line((159, 235 + bob, 151, 260 + bob, 164, 261 + bob), fill=(161, 98, 76), width=4)
    mouth = 9 + round(5 * (1 + math.sin(phase * 2)))
    draw.ellipse((137, 269 + bob, 181, 269 + bob + mouth), fill=BACKGROUND)
    if hot:
        draw.ellipse((102, 248 + bob, 124, 261 + bob), fill=(225, 105, 83))
        draw.ellipse((192, 248 + bob, 214, 261 + bob), fill=(225, 105, 83))
        drop = round(8 * (1 + math.sin(phase)))
        draw.polygon([(231, 210 + drop), (221, 231 + drop), (240, 231 + drop)], fill=(77, 188, 226))
        draw.ellipse((221, 222 + drop, 240, 241 + drop), fill=(77, 188, 226))
        for x in (100, 158, 216):
            wave = round(5 * math.sin(phase + x))
            draw.line([(x, 136), (x + wave, 122), (x - wave, 109), (x, 96)],
                      fill=YELLOW, width=4)
    else:
        draw.line((52, 218, 34, 206), fill=YELLOW, width=5)
        draw.line((49, 243, 27, 245), fill=YELLOW, width=5)
        draw.line((263, 211, 278, 196), fill=YELLOW, width=5)


def turbo(draw, phase, accent):
    cx, cy = 156, 251
    draw.rounded_rectangle((71, 320, 219, 353), 8, fill=(63, 81, 95))
    draw.rounded_rectangle((200, 187, 259, 231), 10, fill=accent)
    draw.ellipse((55, 152, 252, 349), fill=(63, 81, 95), outline=accent, width=7)
    draw.ellipse((81, 178, 226, 323), fill=BACKGROUND, outline=(109, 127, 141), width=4)
    for index in range(6):
        angle = phase + index * math.pi / 3
        points = []
        for radius, offset in ((19, 0), (57, 0.1), (58, 0.58), (25, 0.58)):
            points.append((cx + radius * math.cos(angle + offset),
                           cy + radius * math.sin(angle + offset)))
        draw.polygon(points, fill=accent)
    draw.ellipse((140, 235, 172, 267), fill=WHITE)
    draw.arc((63, 124, 250, 311), 192, 342, fill=WHITE, width=5)
    angle = math.radians(215 + 35 * math.sin(phase))
    draw.line((156, 217, 156 + 85 * math.cos(angle), 217 + 85 * math.sin(angle)),
              fill=RED, width=7)
    fitted_text(draw, "PSI: TOO MUCH", (52, 367, 261, 401), maximum=23)


def render(kind, label, words, index):
    phase = index * 2 * math.pi / FRAME_COUNT
    blend = (1 - math.cos(phase)) / 2
    accent = tuple(round(RED[c] * (1 - blend) + YELLOW[c] * blend) for c in range(3))
    image = Image.new("RGB", SIZE, BACKGROUND)
    draw = ImageDraw.Draw(image)
    draw.rounded_rectangle((12, 12, 847, 467), 20, outline=accent, width=7)
    draw.rounded_rectangle((29, 29, 830, 84), 10, fill=accent)
    fitted_text(draw, label, (42, 37, 817, 75), BACKGROUND, 33)
    draw.line((302, 113, 302, 402), fill=(50, 59, 70), width=2)
    if kind == "boost":
        turbo(draw, phase, accent)
    else:
        mechanic(draw, phase, kind == "heat")
        fitted_text(draw, "OIL HAS LEFT THE CHAT" if kind == "oil" else "ABSOLUTELY COOKED",
                    (44, 365, 270, 398), WHITE, 18)
    fitted_text(draw, words[0], (320, 124, 814, 238), WHITE, 96)
    fitted_text(draw, words[1], (320, 238, 814, 361), accent, 110)
    fitted_text(draw, "LIFT OFF. CHECK BOOST." if kind == "boost" else
                "STOP SAFELY. CHECK OIL." if kind == "oil" else "STOP SAFELY. LET IT COOL.",
                (321, 374, 815, 403), WHITE, 24)
    for x in range(34, 825, 40):
        draw.polygon([(x, 425), (min(x + 24, 826), 425),
                      (min(x + 7, 826), 449), (max(x - 17, 34), 449)], fill=accent)
    return image


def build(output):
    if not FONT.is_file():
        raise FileNotFoundError("Install the DejaVu Sans Bold font or update FONT.")
    output.mkdir(parents=True, exist_ok=True)
    entries = []
    preview = Image.new("RGB", (860, 480 * len(ALARMS)), BACKGROUND)
    for row, (name, label, words, kind) in enumerate(ALARMS):
        frames = [render(kind, label, words, i) for i in range(FRAME_COUNT)]
        target = output / name
        if target.exists():
            raise FileExistsError(target)
        colour_samples = Image.new("RGB", (215, 120 * FRAME_COUNT))
        for index, frame in enumerate(frames):
            colour_samples.paste(frame.resize((215, 120)), (0, 120 * index))
        palette = colour_samples.quantize(colors=128)
        indexed = [frame.quantize(palette=palette, dither=Image.Dither.NONE) for frame in frames]
        indexed[0].save(target, save_all=True, append_images=indexed[1:],
                        duration=FRAME_MS, loop=0, disposal=2, optimize=False)
        with Image.open(target) as animation:
            assert animation.size == SIZE and animation.info["loop"] == 0
            assert animation.n_frames == FRAME_COUNT
            durations, hashes = [], set()
            for frame in range(animation.n_frames):
                animation.seek(frame)
                durations.append(animation.info["duration"])
                hashes.add(hashlib.sha256(animation.convert("RGB").tobytes()).hexdigest())
            assert sum(durations) == FRAME_MS * FRAME_COUNT
            assert min(durations) == FRAME_MS and len(hashes) >= FRAME_COUNT // 2
        assert target.stat().st_size < 2 * 1024 * 1024
        preview.paste(frames[6], (0, row * 480))
        entries.append({"file": name, "alarm": label, "size": list(SIZE),
                        "frames": FRAME_COUNT, "loop_ms": sum(durations),
                        "distinct_frames": len(hashes), "bytes": target.stat().st_size,
                        "sha256": hashlib.sha256(target.read_bytes()).hexdigest()})
    preview.save(output / "preview.png")
    report = {"artwork": "Original typography, turbo and cartoon mechanic; no film or cartoon footage.",
              "animation": "10 fps; gradual 2.4-second red/yellow colour cycle, no rapid full-screen flashes.",
              "usage": "NSP Alarm appearance: Choose GIF/image, choose matching file, GIF only, Apply, Save. "
                       "No map settings, alarm triggers or screen restrictions are changed by this pack.",
              "device_playback_verified": False, "assets": entries}
    (output / "manifest.json").write_text(json.dumps(report, indent=2) + "\n")
    archive_path = output.with_suffix(".zip")
    with zipfile.ZipFile(archive_path, "x", compression=zipfile.ZIP_DEFLATED) as archive:
        for path in sorted(output.iterdir()):
            archive.write(path, path.name)
    with zipfile.ZipFile(archive_path) as archive:
        assert archive.testzip() is None
        for entry in entries:
            assert hashlib.sha256(archive.read(entry["file"])).hexdigest() == entry["sha256"]
    print(json.dumps({"archive": str(archive_path), **report}, indent=2))


if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Build original looping 860x480 alarm GIF artwork.")
    parser.add_argument("--output", type=Path, required=True)
    build(parser.parse_args().output)
