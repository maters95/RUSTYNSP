import argparse
import copy
import hashlib
import io
import json
from pathlib import Path
import runpy

from PIL import Image, ImageDraw
import pyzipper


def make_assets(video=None, include_image_probes=True):
    frames = []
    for colour, label in (((26, 139, 91), "FRAME 1"), ((197, 55, 66), "FRAME 2")):
        image = Image.new("RGB", (320, 160), (20, 22, 25))
        drawing = ImageDraw.Draw(image)
        drawing.rectangle((12, 12, 308, 148), outline=colour, width=8)
        drawing.rectangle((28, 40, 90, 120), fill=colour)
        drawing.text((112, 56), "IC7 ASSET PROBE", fill=(245, 245, 245))
        drawing.text((112, 88), label, fill=(245, 245, 245))
        frames.append(image)
    still = io.BytesIO()
    frames[0].save(still, format="PNG")
    animation = io.BytesIO()
    frames[0].save(animation, format="GIF", save_all=True, append_images=frames[1:],
                   duration=500, loop=0, optimize=False)
    assets = {}
    if include_image_probes:
        assets.update({
            "user_resources/images/ic7_static_probe.png": still.getvalue(),
            "user_resources/images/ic7_animation_probe.gif": animation.getvalue(),
            "user_resources/images/ic7_animation_probe.png": animation.getvalue(),
        })
    if video is not None:
        payload = video.read_bytes()
        if len(payload) < 12 or payload[4:8] != b"ftyp":
            raise ValueError("Video asset must be an ISO-BMFF/MP4 file")
        if include_image_probes:
            assets["user_resources/images/ic7_media_probe.mp4"] = payload
        assets["user_resources/images/ic7_video_probe.png"] = payload
    return assets


def main():
    parser = argparse.ArgumentParser(description="Merge media test assets into an authenticated NSP map without changing settings.")
    parser.add_argument("map", type=Path)
    parser.add_argument("--output", required=True, type=Path)
    parser.add_argument("--video", type=Path, help="Add an MP4 resource for the emulator and renderer preview")
    parser.add_argument("--media-only", action="store_true", help="Add only the MP4 and PNG-extension MP4 alias; requires --video")
    args = parser.parse_args()
    if args.media_only and args.video is None:
        parser.error("--media-only requires --video")
    inspector = runpy.run_path(str(Path(__file__).with_name("inspect-nexmap.py")))
    original = inspector["read_map"](args.map)
    assets = make_assets(args.video, include_image_probes=not args.media_only)
    if set(original) & set(assets):
        raise ValueError("Probe resource names already exist")
    password = inspector["map_password"]()
    args.output.parent.mkdir(parents=True, exist_ok=True)
    with pyzipper.AESZipFile(args.map) as source:
        with pyzipper.AESZipFile(args.output, "x", compression=pyzipper.ZIP_DEFLATED,
                                encryption=pyzipper.WZ_AES) as destination:
            destination.setpassword(password)
            destination.setencryption(pyzipper.WZ_AES, nbits=256)
            destination.comment = source.comment
            for metadata in source.infolist():
                destination.writestr(copy.copy(metadata), original[metadata.filename])
            for name, payload in assets.items():
                destination.writestr(name, payload)
    result = inspector["read_map"](args.output)
    if set(result) != set(original) | set(assets):
        raise ValueError("Generated map entry set differs from expected")
    changed = [name for name in original if original[name] != result[name]]
    if changed:
        raise ValueError(f"Existing map entries changed: {changed}")
    gif_alias = "user_resources/images/ic7_animation_probe.png"
    gif_resource = "user_resources/images/ic7_animation_probe.gif"
    if not args.media_only:
        with Image.open(io.BytesIO(result[gif_resource])) as image:
            if image.n_frames != 2 or image.info.get("loop") != 0:
                raise ValueError("GIF fixture is not a two-frame looping animation")
    if gif_alias in result and gif_resource in result and result[gif_alias] != result[gif_resource]:
        raise ValueError("PNG-extension animation alias differs from the GIF fixture")
    if not args.media_only and (gif_alias not in result or gif_resource not in result):
        raise ValueError("GIF probe resources are missing from the generated map")
    if args.video is not None:
        video_alias = result["user_resources/images/ic7_video_probe.png"]
        if video_alias != args.video.read_bytes():
            raise ValueError("PNG-extension video alias differs from the MP4 fixture")
        mp4_resource = result.get("user_resources/images/ic7_media_probe.mp4")
        if mp4_resource is not None and video_alias != mp4_resource:
            raise ValueError("MP4 resource differs from its PNG-extension alias")
    report = {
        "source": args.map.name, "output": args.output.name,
        "source_sha256": hashlib.sha256(args.map.read_bytes()).hexdigest(),
        "output_sha256": hashlib.sha256(args.output.read_bytes()).hexdigest(),
        "original_entries_preserved": len(original), "changed_existing_entries": changed,
        "map_settings_byte_identical": original["_map"] == result["_map"],
        "added_assets": [{"name": name, "bytes": len(payload),
                          "sha256": hashlib.sha256(payload).hexdigest()} for name, payload in assets.items()],
        "status": "offline authenticated; NSP import, resource listing and device transfer untested",
    }
    args.output.with_suffix(".report.json").write_text(json.dumps(report, indent=2) + "\n", encoding="utf-8")
    print(json.dumps(report, indent=2))


if __name__ == "__main__":
    main()