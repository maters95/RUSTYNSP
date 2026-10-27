#!/bin/sh
# SCRATCH-TEST launcher for ic7dash -- a standalone test app, NOT firmware.
#
# What this script does NOT do: install anything, enable/start/stop services,
# remount any filesystem, configure CAN or network interfaces, or write outside
# this directory and /tmp/ic7dash-scratch. The only file the app itself writes
# is its map tile cache in ./tilecache/ (next to the binary).
#
#   ./run-scratch.sh selftest   headless (offscreen) check of map, gif and video
#                               backgrounds; screenshots + logs go to
#                               /tmp/ic7dash-scratch/, then it exits
#   ./run-scratch.sh map|gif|video
#                               run the app with that nav-screen background.
#                               Platform defaults to offscreen (nothing drawn);
#                               set QT_QPA_PLATFORM yourself (e.g. eglfs) only if
#                               you know the display is free -- this script
#                               never stops the stock UI to free it.
#
# CAN: simulated unless YOU export IC7_CAN=can0 for an interface that is
# already up; the app then only reads frames, it never configures the bus.
# Remove everything: rm -rf "<this directory>" /tmp/ic7dash-scratch
set -eu

HERE=$(CDPATH= cd -- "$(dirname -- "$0")" && pwd)
TMPBASE=/tmp/ic7dash-scratch

usage() {
    echo "usage: $0 {selftest|map|gif|video}" >&2
    exit 2
}
MODE=${1:-}
case "$MODE" in
    selftest|map|gif|video) ;;
    *) usage ;;
esac

if [ ! -x "$HERE/ic7dash" ]; then
    echo "ic7dash missing or not executable in $HERE" >&2
    exit 1
fi

# Keep every Qt/GStreamer/QML cache under /tmp, never in the real $HOME.
mkdir -p "$TMPBASE/home" "$TMPBASE/run"
chmod 700 "$TMPBASE/run"
HOME="$TMPBASE/home"
XDG_RUNTIME_DIR="$TMPBASE/run"
XDG_CACHE_HOME="$TMPBASE/home/.cache"
XDG_CONFIG_HOME="$TMPBASE/home/.config"
XDG_DATA_HOME="$TMPBASE/home/.local/share"
QML_DISABLE_DISK_CACHE=1
QT_QPA_PLATFORM=${QT_QPA_PLATFORM:-offscreen}
export HOME XDG_RUNTIME_DIR XDG_CACHE_HOME XDG_CONFIG_HOME XDG_DATA_HOME \
       QML_DISABLE_DISK_CACHE QT_QPA_PLATFORM

cd "$HERE"
# IC7_EXEC_PREFIX lets a build host run this ARM binary via qemu-arm for testing.
EXEC_PREFIX=${IC7_EXEC_PREFIX:-}

if [ "$MODE" != selftest ]; then
    if [ "$MODE" = video ] && [ ! -r "$HERE/bg.mp4" ]; then
        echo "bg.mp4 missing in $HERE" >&2; exit 1
    fi
    IC7_BG=$MODE
    export IC7_BG
    # shellcheck disable=SC2086
    exec $EXEC_PREFIX ./ic7dash
fi

# --- selftest: headless, screenshot-and-quit per background mode ---
QT_QPA_PLATFORM=offscreen
QT_QUICK_BACKEND=${QT_QUICK_BACKEND:-software}
IC7_TILE_LOG=1
export QT_QPA_PLATFORM QT_QUICK_BACKEND IC7_TILE_LOG
failures=0
for m in map gif video; do
    if [ "$m" = video ] && [ ! -r "$HERE/bg.mp4" ]; then
        echo "video: SKIP (no bg.mp4)"; continue
    fi
    log="$TMPBASE/selftest-$m.log"
    shots="$TMPBASE/shots-$m"
    rm -rf "$shots"; mkdir -p "$shots"
    echo "== $m (log: $log)"
    rc=0
    # shellcheck disable=SC2086
    IC7_BG=$m IC7_SHOT=$shots $EXEC_PREFIX ./ic7dash >"$log" 2>&1 || rc=$?
    qmlerr=$(grep -c 'qrc:/qml/' "$log" || true)
    tiles=$(grep -c 'tileserver: 200 ' "$log" || true)
    echo "   exit=$rc  qml-errors=$qmlerr  local-tiles-served=$tiles  shots=$(ls "$shots" | tr '\n' ' ')"
    grep 'ic7bg:' "$log" | sed 's/^/   /' || true
    ok=1
    [ "$rc" = 0 ] || ok=0
    [ "$qmlerr" = 0 ] || ok=0
    [ -s "$shots/page2.png" ] || ok=0
    case $m in
        map)   [ "$tiles" -gt 0 ] || ok=0 ;;
        gif)   grep -q 'ic7bg: gif ready' "$log" || ok=0 ;;
        video) grep -q 'ic7bg: video playing' "$log" || ok=0
               if grep -q 'ic7bg: video error' "$log"; then ok=0; fi ;;
    esac
    if [ "$ok" = 1 ]; then echo "   $m: OK"; else echo "   $m: PROBLEM"; failures=$((failures+1)); fi
done
echo "selftest finished with $failures problem(s); outputs in $TMPBASE"
[ "$failures" = 0 ]
