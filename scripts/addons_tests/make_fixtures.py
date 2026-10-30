"""Build the QML test runtimes for the experimental iC-7 add-ons.

Creates, under ic7-custom-dash/deploy/addons/tests/runtime (git-ignored):
  device/    dash layout: resources/qml_components_data/qml/... + user_resources/images
  nsp/       NSP renderer layout: qml_components_data/qml/... + user_resources/images
  nomanifest/ dash layout with media but no add-on manifests
  stock/     dash layout with the unmodified v2.36 components (pixel reference)
  manifests/ manifest variants the tests point an add-on at explicitly
  preview/   dash layout with samples/upload as the user images (preview/Preview.qml)

The stock components come from the v2.36 NEX itself (not the reference extract).
"""
import argparse
import io
import json
from pathlib import Path
import runpy
import shutil
import subprocess
import tarfile
import zipfile

from PIL import Image, ImageDraw

ROOT = Path(__file__).resolve().parents[2]
ADDONS = ROOT / "ic7-custom-dash/deploy/addons"
QML_PREFIX = "qml_components_data/"


def stock_members(stock_nex, reference):
    codec = runpy.run_path(str(ROOT / "scripts/decode-nsp-resources.py"))
    with zipfile.ZipFile(stock_nex) as package:
        payload = package.read("res_ic-7.qzip")
    archive = codec["decode_resource"](reference, payload)[0]
    with tarfile.open(fileobj=io.BytesIO(archive), mode="r:") as tar:
        return {m.name: tar.extractfile(m).read() for m in tar.getmembers()
                if m.isfile() and (m.name.startswith(QML_PREFIX + "qml/") or
                                       m.name.startswith(QML_PREFIX + "images/"))}


def shape(path, colour, size=(64, 64)):
    """White-on-transparent indicator shape (the stock indicator tints its alpha)."""
    image = Image.new("RGBA", size, (0, 0, 0, 0))
    ImageDraw.Draw(image).ellipse((6, 6, size[0] - 7, size[1] - 7), fill=colour)
    image.save(path)


def solid(path, colour, size=(64, 64)):
    Image.new("RGBA", size, colour).save(path)


def gif(path, colours, size=(64, 64)):
    frames = [Image.new("RGB", size, colour) for colour in colours]
    frames[0].save(path, save_all=True, append_images=frames[1:], duration=120, loop=0, optimize=False)


INDICATORS = {
    "version": 1,
    "indicators": [
        {"image": "shift.png", "on": "u/shift_on.gif", "off": "u/shift_off.png"},
        {"image": "gear.png", "frames": [
            {"min": -0.5, "max": 0.5, "source": "u/gear_n.png"},
            {"min": 0.5, "max": 1.5, "source": "u/gear_1.png"},
            {"min": 1.5, "max": 2.5, "source": "u/gear_2.gif"}], "hysteresis": 0.2},
        {"image": "video.png", "on": "u/clip.mp4"},
        {"image": "missing.png", "on": "u/does_not_exist.gif", "off": "u/also_missing.png"},
    ],
}
GAUGE_FX = {
    "version": 1,
    "gauges": [
        {"channel": "Coolant Temp", "trigger": "warn", "effect": "solid", "colour": "#FF00FF", "width": 6},
        {"channel": "Engine Speed", "trigger": "above", "threshold": 6500, "effect": "flash", "rateHz": 5},
        {"channel": "Oil Pressure", "trigger": "below", "threshold": 100, "effect": "pulse", "rateHz": 1},
    ],
}
VARIANTS = {
    "bad-json.json": "{ this is not json",
    "bad-version.json": json.dumps({"version": 2, "indicators": INDICATORS["indicators"]}),
    "bad-entry.json": json.dumps({"version": 1, "indicators": [
        {"image": "shift.png", "on": "u/../../etc/passwd.gif"}]}),
    "bad-unknown-key.json": json.dumps({"version": 1, "indicators": [
        {"image": "shift.png", "on": "u/shift_on.gif", "colour": "red"}]}),
    "bad-frames.json": json.dumps({"version": 1, "indicators": [
        {"image": "gear.png", "frames": [{"min": 2, "max": 1, "source": "u/gear_1.png"}]}]}),
    "bad-fx.json": json.dumps({"version": 1, "gauges": [
        {"channel": "Engine Speed", "trigger": "above", "effect": "flash"}]}),
    "bad-fx-rate.json": json.dumps({"version": 1, "gauges": [
        {"channel": "Engine Speed", "trigger": "warn", "effect": "flash", "rateHz": 30}]}),
    "empty.json": "",
    # The helper's --off manifests: valid, with no entries.
    "off.json": json.dumps({"version": 1, "indicators": []}),
    "off-fx.json": json.dumps({"version": 1, "gauges": []}),
}


def populate_images(images, with_manifests):
    images.mkdir(parents=True, exist_ok=True)
    shape(images / "shift.png", (255, 255, 255, 255))
    shape(images / "gear.png", (255, 255, 255, 255))
    shape(images / "video.png", (255, 255, 255, 255))
    shape(images / "missing.png", (255, 255, 255, 255))
    shape(images / "other.png", (255, 255, 255, 255))
    gif(images / "shift_on.gif", [(250, 120, 0), (0, 0, 250)])
    solid(images / "shift_off.png", (0, 0, 255, 255))
    solid(images / "gear_n.png", (255, 255, 0, 255))
    solid(images / "gear_1.png", (0, 255, 255, 255))
    gif(images / "gear_2.gif", [(255, 0, 255), (10, 10, 10)])
    shutil.copyfile(FIXTURES / "clip.mp4", images / "clip.mp4")
    if with_manifests:
        (images / "ic7_indicators.json").write_text(json.dumps(INDICATORS))
        (images / "ic7_gauge_fx.json").write_text(json.dumps(GAUGE_FX))


def install(components, stock, use_addons):
    components.mkdir(parents=True, exist_ok=True)
    for name, data in stock.items():
        if "/user_components/" in name:
            (components / Path(name).name).write_bytes(data)
    if use_addons:
        for source in (ADDONS / "qml").iterdir():
            shutil.copyfile(source, components / source.name)


def main():
    global FIXTURES
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("--stock-nex", type=Path, default=ROOT / "fw/Dash-V2-36-0-Release.nex")
    parser.add_argument("--reference", type=Path, default=ROOT / "fw/opt/dtn/app/dash_watchdog")
    parser.add_argument("--output", type=Path, default=ADDONS / "tests/runtime")
    args = parser.parse_args()
    if args.output.exists():
        shutil.rmtree(args.output)
    FIXTURES = args.output / "media"
    FIXTURES.mkdir(parents=True)
    subprocess.run(["ffmpeg", "-nostdin", "-hide_banner", "-loglevel", "error", "-y",
                    "-f", "lavfi", "-i", "testsrc2=size=64x64:rate=15", "-t", "2", "-an",
                    "-c:v", "libx264", "-pix_fmt", "yuv420p", "-movflags", "+faststart",
                    str(FIXTURES / "clip.mp4")], check=True)
    stock = stock_members(args.stock_nex, args.reference)
    layouts = {
        "device": ("resources/qml_components_data/qml/user_components", True, True),
        "nsp": ("qml_components_data/qml/user_components", True, True),
        "nomanifest": ("resources/qml_components_data/qml/user_components", True, False),
        "stock": ("resources/qml_components_data/qml/user_components", False, False),
    }
    for layout, (components, use_addons, manifests) in layouts.items():
        base = args.output / layout
        install(base / components, stock, use_addons)
        stock_images = base / Path(components).parent.parent / "images"
        for name, data in stock.items():
            if name.startswith(QML_PREFIX + "images/"):
                target = stock_images / name[len(QML_PREFIX + "images/"):]
                target.parent.mkdir(parents=True, exist_ok=True)
                target.write_bytes(data)
        populate_images(base / "user_resources/images", manifests)
    # Owner preview: dash layout with the committed sample upload folder as user images.
    preview = args.output / "preview"
    install(preview / layouts["device"][0], stock, True)
    for name, data in stock.items():
        if name.startswith(QML_PREFIX + "images/"):
            target = preview / "resources" / name
            target.parent.mkdir(parents=True, exist_ok=True)
            target.write_bytes(data)
    shutil.copytree(ADDONS / "samples/upload", preview / "user_resources/images")
    variants = args.output / "manifests"
    variants.mkdir()
    for name, text in VARIANTS.items():
        (variants / name).write_text(text)
    print(f"Add-on test runtimes written to {args.output}")


if __name__ == "__main__":
    main()
