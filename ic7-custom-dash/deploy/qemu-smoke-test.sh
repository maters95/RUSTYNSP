#!/usr/bin/env bash
# QEMU user-mode smoke test for the ARM ic7dash build (no hardware involved).
#
# Runs build-arm/ic7dash under qemu-arm against the stock Qt 5.9.6 sysroot with
# the offscreen platform, once per background mode (map, gif, video), using the
# app's own IC7_SHOT screenshot-and-quit mode. Checks:
#   all    : exits 0, writes page1/page2 PNGs, loads the CAN map, no QML errors
#   map    : tiles are served by the built-in loopback tile server from the
#            local tiles/ tree, and every tile QtLocation cached is byte-identical
#            to the local tile (proves no online provider was used)
#   gif    : bg.gif reaches Ready with >1 frame and the frame counter advances
#   video  : bg.mp4 loads with no MediaPlayer error, reaches PlayingState and
#            its position advances (software GStreamer decode under QEMU; this
#            says nothing about i.MX6 VPU decode or speed on the real dash)
#
# Usage:
#   IC7_SYSROOT=$HOME/ic7build/sysroot bash deploy/qemu-smoke-test.sh \
#       [path/to/ic7dash] [path/to/video.mp4]
# Without a video argument a 2 s 160x90 H.264 fixture is generated with ffmpeg
# (video mode is skipped, and reported as SKIP, if ffmpeg is unavailable).
# Everything is staged in a mktemp directory; nothing in the checkout is written.
set -uo pipefail

HERE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
SRC="$(cd "$HERE/.." && pwd)"
SYSROOT="${IC7_SYSROOT:?set IC7_SYSROOT to the extracted dash sysroot (Qt 5.9.6 armhf)}"
APP="${1:-$SRC/build-arm/ic7dash}"
VIDEO="${2:-}"
TIMEOUT="${IC7_TEST_TIMEOUT:-180}"
QEMU="${QEMU_ARM:-qemu-arm}"

command -v "$QEMU" >/dev/null || { echo "qemu-arm not found (apt install qemu-user)" >&2; exit 2; }
[[ -f "$SYSROOT/usr/lib/libQt5Core.so.5" ]] || { echo "no Qt5 in $SYSROOT" >&2; exit 2; }
[[ -f "$APP" ]] || { echo "ARM binary not found: $APP" >&2; exit 2; }
file "$APP" | grep -q 'ARM, EABI5' || { echo "not an ARM EABI5 ELF: $APP" >&2; exit 2; }

WORK="$(mktemp -d /tmp/ic7dash-smoke.XXXXXX)"
[[ -n "${IC7_KEEP:-}" ]] || trap 'rm -rf "$WORK"' EXIT
echo "work dir: $WORK"

pass=0; fail=0; skip=0
ok()   { echo "PASS: $*"; pass=$((pass+1)); }
bad()  { echo "FAIL: $*"; fail=$((fail+1)); }
skp()  { echo "SKIP: $*"; skip=$((skip+1)); }
check() { local name="$1"; shift; if "$@"; then ok "$name"; else bad "$name"; fi; }

if [[ -z "$VIDEO" ]] && command -v ffmpeg >/dev/null; then
    VIDEO="$WORK/fixture.mp4"
    ffmpeg -nostdin -hide_banner -loglevel error -y \
        -f lavfi -i "testsrc2=size=160x90:rate=15" -t 2 -an \
        -c:v libx264 -pix_fmt yuv420p -movflags +faststart "$VIDEO"
fi
# The shipped bg.gif is a single-frame placeholder, so frame advance needs an
# animated fixture: IC7_TEST_GIF=<file>, else a generated 10-frame GIF, else bg.gif.
GIF="${IC7_TEST_GIF:-}"
if [[ -z "$GIF" ]] && command -v ffmpeg >/dev/null; then
    GIF="$WORK/fixture.gif"
    ffmpeg -nostdin -hide_banner -loglevel error -y \
        -f lavfi -i "testsrc2=size=160x90:rate=5" -t 2 -loop 0 "$GIF"
fi
GIF="${GIF:-$SRC/bg.gif}"
echo "gif fixture: $GIF"; echo "video fixture: ${VIDEO:-<none>}"

stage() {   # stage <mode> -> prints app dir
    local d="$WORK/$1/app"
    mkdir -p "$d" "$WORK/$1/shots" "$WORK/$1/home" "$WORK/$1/run"
    chmod 700 "$WORK/$1/run"
    cp "$APP" "$d/ic7dash"; chmod +x "$d/ic7dash"
    cp "$SRC/resources/emtron_can.json" "$d/"
    cp -r "$SRC/tiles" "$d/tiles"
    cp "$GIF" "$d/bg.gif"
    [[ -n "$VIDEO" ]] && cp "$VIDEO" "$d/bg.mp4"
    echo "$d"
}

run_mode() {   # run_mode <mode> ; leaves log in $WORK/<mode>/log.txt
    local m="$1" d; d="$(stage "$m")"
    ( cd "$d" && timeout "$TIMEOUT" "$QEMU" -L "$SYSROOT" \
        -E QT_QPA_PLATFORM=offscreen -E QT_QUICK_BACKEND=software \
        -E QT_PLUGIN_PATH="$SYSROOT/usr/lib/plugins" \
        -E QML2_IMPORT_PATH="$SYSROOT/usr/lib/qml" \
        -E HOME="$WORK/$m/home" -E XDG_RUNTIME_DIR="$WORK/$m/run" \
        -E QML_DISABLE_DISK_CACHE=1 \
        -E IC7_BG="$m" -E IC7_SHOT="$WORK/$m/shots" -E IC7_TILE_LOG=1 \
        ./ic7dash ) >"$WORK/$m/log.txt" 2>&1
    echo $? >"$WORK/$m/rc"
}

common_checks() {
    local m="$1" log="$WORK/$1/log.txt"
    check "$m: app exited 0 (rc=$(cat "$WORK/$m/rc"))" test "$(cat "$WORK/$m/rc")" = 0
    check "$m: page1.png and page2.png written" \
        test -s "$WORK/$m/shots/page1.png" -a -s "$WORK/$m/shots/page2.png"
    check "$m: CAN map loaded (7 frames)" grep -q 'EmtronDecoder: loaded 7 frames' "$log"
    # QML load/runtime errors are reported as qrc:/qml/<file>:<line>: ...
    if grep -E 'qrc:/qml/|QQmlApplicationEngine failed|module ".*" is not installed' "$log" \
            | grep -vE 'grabToImage: item has no QML engine' >"$WORK/$m/qml-errors.txt"; then
        bad "$m: no QML errors (see below)"; sed 's/^/    /' "$WORK/$m/qml-errors.txt"
    else
        ok "$m: no QML errors"
    fi
}

echo "== map"
run_mode map; common_checks map
served=$(grep -c 'tileserver: 200 ' "$WORK/map/log.txt" || true)
check "map: local tile server served tiles ($served x 200)" test "$served" -gt 0
cached=0; same=0
for f in "$WORK"/map/app/tilecache/osm_100-l-*.png; do
    [[ -e "$f" ]] || continue
    cached=$((cached+1))
    # osm_100-l-<v>-<z>-<x>-<y>.png  ->  tiles/<z>/<x>/<y>.png
    IFS=- read -r _ _ _ z x y <<<"$(basename "$f" .png)"
    cmp -s "$f" "$WORK/map/app/tiles/$z/$x/$y.png" && same=$((same+1))
done
check "map: $cached cached tiles, $same byte-identical to local tiles/" \
    test "$cached" -gt 0 -a "$cached" = "$same"

echo "== gif"
run_mode gif; common_checks gif
check "gif: bg.gif Ready with >1 frame ($(grep -o 'ic7bg: gif ready frames=[0-9]*' "$WORK/gif/log.txt" | head -1))" \
    grep -qE 'ic7bg: gif ready frames=([2-9]|[1-9][0-9]+)' "$WORK/gif/log.txt"
check "gif: frame advanced" grep -q 'ic7bg: gif frame advanced' "$WORK/gif/log.txt"

echo "== video"
if [[ -z "$VIDEO" ]]; then
    skp "video: no video given and ffmpeg unavailable"
else
    run_mode video; common_checks video
    vlog="$WORK/video/log.txt"
    if grep -qE 'ic7bg: video error|no service found|defaultServiceProvider' "$vlog"; then
        bad "video: no MediaPlayer error"; grep -E 'ic7bg: video error|service' "$vlog" | sed 's/^/    /'
    else
        ok "video: no MediaPlayer error"
    fi
    check "video: reached PlayingState" grep -q 'ic7bg: video playing' "$vlog"
    check "video: playback position advanced ($(grep -o 'ic7bg: video position advanced ms=[0-9]*' "$vlog" | head -1))" \
        grep -q 'ic7bg: video position advanced' "$vlog"
fi

echo "== app log excerpts (ic7bg / tileserver / warnings)"
for m in map gif video; do
    [[ -f "$WORK/$m/log.txt" ]] || continue
    echo "-- $m"
    grep -E 'ic7bg:|tileserver:|EmtronDecoder|CAN source|qrc:/qml' "$WORK/$m/log.txt" \
        | awk '/tileserver: 200/{t++; if (t>3) next} {print "    " $0}'
done
echo "Totals: $pass passed, $fail failed, $skip skipped"
[[ "$fail" = 0 ]]
