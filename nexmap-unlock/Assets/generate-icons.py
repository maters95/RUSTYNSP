"""Regenerate the app image and multi-resolution Windows icon from logo.svg."""

from io import BytesIO
from pathlib import Path

import cairosvg
from PIL import Image


assets = Path(__file__).resolve().parent
png = cairosvg.svg2png(url=str(assets / "logo.svg"), output_width=1024, output_height=1024)
with Image.open(BytesIO(png)) as source:
    image = source.convert("RGBA")
    image.resize((256, 256), Image.Resampling.LANCZOS).save(assets / "logo.png")
    image.save(
        assets / "app.ico",
        sizes=[(size, size) for size in (16, 20, 24, 32, 40, 48, 64, 128, 256)],
    )
