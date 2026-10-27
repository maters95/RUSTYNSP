#!/usr/bin/env bash
set -euo pipefail

HERE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
SRC="$(cd "$HERE/.." && pwd)"
OUT="$SRC/build-arm"

if [[ $# -lt 1 || $# -gt 2 ]]; then
    echo "Usage: $0 <video.mp4> [output.tar.gz]" >&2
    exit 2
fi

VIDEO="$(realpath "$1")"
ARCHIVE="${2:-$OUT/ic7dash-video-test-bundle.tar.gz}"
ARCHIVE="$(realpath -m "$ARCHIVE")"

[[ -f "$VIDEO" ]] || { echo "Video not found: $VIDEO" >&2; exit 1; }
[[ -x "$OUT/ic7dash" ]] || { echo "ARM app missing: $OUT/ic7dash" >&2; exit 1; }
[[ ! -e "$ARCHIVE" ]] || { echo "Refusing to overwrite: $ARCHIVE" >&2; exit 1; }

STAGE="$(mktemp -d)"
trap 'rm -rf "$STAGE"' EXIT
APP="$STAGE/ic7test"
mkdir -p "$APP"

cp "$OUT/ic7dash" "$APP/"
cp "$SRC/resources/emtron_can.json" "$APP/"
cp -r "$SRC/tiles" "$APP/"
cp "$SRC/deploy/bringup-can.sh" "$APP/"
cp "$HERE/run-video.sh" "$APP/"
cp "$VIDEO" "$APP/bg.mp4"
chmod +x "$APP/ic7dash" "$APP/bringup-can.sh" "$APP/run-video.sh"

mkdir -p "$(dirname "$ARCHIVE")"
tar czf "$ARCHIVE" -C "$STAGE" ic7test
echo "Video test bundle: $ARCHIVE"
echo "MP4: $(stat -c%s "$APP/bg.mp4") bytes"
echo "ARM executable: $(stat -c%s "$APP/ic7dash") bytes"