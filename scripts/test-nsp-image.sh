#!/usr/bin/env bash
set -euo pipefail

HERE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
SRC="$(cd "$HERE/../ic7-custom-dash" && pwd)"
FIXTURES="$SRC/build-nsp-tests"
mkdir -p "$FIXTURES"

/usr/bin/python3 - "$FIXTURES" <<'PY'
import sys
import json
import shutil
from pathlib import Path
from PIL import Image

destination = Path(sys.argv[1])
first = Image.new("RGB", (32, 20), (220, 40, 50))
second = Image.new("RGB", (32, 20), (40, 210, 100))
first.save(destination / "static.png")
first.save(destination / "animated.gif", save_all=True, append_images=[second],
           duration=120, loop=0, optimize=False)
with Image.open(destination / "animated.gif") as animation:
    assert animation.n_frames == 2
(destination / "ic7_animation_probe.png").write_bytes((destination / "animated.gif").read_bytes())

runtime = destination / "splash-runtime"
qml = runtime / "qml_components_data/qml"
for folder in ("factory_screens", "user_components"):
    (qml / folder).mkdir(parents=True, exist_ok=True)
maintained = destination.parent / "deploy/nsp"
for filename, folder in (("main.qml", "factory_screens"),
                         ("HalImage.qml", "user_components"),
                         ("HalSplash.qml", "user_components"),
                         ("HalAlarmPopup.qml", "user_components")):
    shutil.copyfile(maintained / filename, qml / folder / filename)
(runtime / "qml_components_data/fonts").mkdir(exist_ok=True)
images = runtime / "user_resources/images"
images.mkdir(parents=True, exist_ok=True)
shutil.copyfile(destination / "animated.gif", images / "animated.gif")
(images / "ic7_splash.json").write_text(json.dumps({
    "version": 1, "source": "u/animated.gif", "durationMs": 1500
}))
PY

if ! command -v ffmpeg >/dev/null; then
    echo "ffmpeg is required for the MP4 component playback test." >&2
    exit 1
fi
ffmpeg -nostdin -hide_banner -loglevel error -y \
    -f lavfi -i "testsrc2=size=160x90:rate=15" -t 2 -an \
    -c:v libx264 -pix_fmt yuv420p -movflags +faststart "$FIXTURES/video.mp4"
cp "$FIXTURES/video.mp4" "$FIXTURES/ic7_video_probe.png"

if [[ -n "${IC7_SYSROOT:-}" ]]; then
    for test in tst_HalImage.qml tst_HalSplash.qml tst_StartupRoot.qml tst_HalAlarmPopup.qml; do
        qemu-arm -L "$IC7_SYSROOT" \
            -E QML_DISABLE_DISK_CACHE=1 \
            -E QT_QPA_PLATFORM=offscreen -E QT_QUICK_BACKEND=software \
            -E QT_PLUGIN_PATH="$IC7_SYSROOT/usr/lib/plugins" \
            -E QML2_IMPORT_PATH="$IC7_SYSROOT/usr/lib/qml" \
            "$IC7_SYSROOT/usr/bin/qmltestrunner" -input "$SRC/deploy/nsp/tests/$test" -o -,txt
    done
else
    xvfb-run -a env LIBGL_ALWAYS_SOFTWARE=1 QML_DISABLE_DISK_CACHE=1 \
        qmltestrunner -input "$SRC/deploy/nsp/tests" -o -,txt
fi