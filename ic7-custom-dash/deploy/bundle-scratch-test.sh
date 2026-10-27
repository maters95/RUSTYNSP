#!/usr/bin/env bash
# Package an ARM ic7dash build as a clearly labelled SCRATCH-TEST tarball.
# Not firmware: no .nex/.swu/rootfs/image is produced, and the bundle contains
# no script that installs services, remounts filesystems or touches CAN/network.
#
# Usage: bash deploy/bundle-scratch-test.sh [path/to/ic7dash] [path/to/bg.mp4]
#   OUTDIR=<dir> overrides the output folder (default: <project>/dist-scratch).
set -euo pipefail

HERE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
SRC="$(cd "$HERE/.." && pwd)"
APP="${1:-$SRC/build-arm/ic7dash}"
MP4="${2:-}"
OUTDIR="${OUTDIR:-$SRC/dist-scratch}"
NAME="ic7dash-scratch-test-$(date +%F)"
DIR=ic7dash-scratch
ARCHIVE="$OUTDIR/$NAME.tar.gz"

[[ -f "$APP" ]] || { echo "ARM binary not found: $APP" >&2; exit 1; }
file "$APP" | grep -q 'ELF 32-bit LSB.*ARM, EABI5' || { echo "not an ARM EABI5 ELF: $APP" >&2; exit 1; }
[[ -z "$MP4" || -f "$MP4" ]] || { echo "video not found: $MP4" >&2; exit 1; }
[[ ! -e "$ARCHIVE" ]] || { echo "refusing to overwrite $ARCHIVE" >&2; exit 1; }

STAGE="$(mktemp -d)"
trap 'rm -rf "$STAGE"' EXIT
B="$STAGE/$DIR"
mkdir -p "$B"

cp "$APP" "$B/ic7dash"
cp "$SRC/resources/emtron_can.json" "$B/"
cp "$SRC/bg.gif" "$B/"
cp -r "$SRC/tiles" "$B/tiles"
[[ -n "$MP4" ]] && cp "$MP4" "$B/bg.mp4"
cp "$HERE/scratch/run-scratch.sh" "$B/"
cp "$HERE/scratch/SCRATCH-TEST-NOT-FIRMWARE.txt" "$B/"
cp "$HERE/scratch/SCRATCH-TEST-NOT-FIRMWARE.txt" "$STAGE/"
# A Windows checkout may carry CRLF; the target shell needs LF.
sed -i 's/\r$//' "$B/run-scratch.sh" "$B/SCRATCH-TEST-NOT-FIRMWARE.txt" "$STAGE/SCRATCH-TEST-NOT-FIRMWARE.txt"
find "$STAGE" -type d -exec chmod 755 {} +
find "$STAGE" -type f -exec chmod 644 {} +
chmod 755 "$B/ic7dash" "$B/run-scratch.sh"

{
    echo "ic7dash scratch-test bundle, packaged $(date -u +%FT%TZ)"
    echo "binary sha256: $(sha256sum "$B/ic7dash" | cut -d' ' -f1)"
    echo "binary: $(file -b "$B/ic7dash")"
    echo "source git rev: $(git -C "$SRC" rev-parse --short HEAD 2>/dev/null || echo unknown)" \
         "(working tree may contain uncommitted changes)"
    echo "built with deploy/wsl-build.sh: GCC 11 armhf, Qt 5.9.9 host moc/rcc,"
    echo "stock Qt 5.9.6 / glibc 2.24 sysroot. Tested only under QEMU user-mode."
} >"$B/PROVENANCE.txt"

# Guard rails: nothing flashable, nothing that changes system state.
if find "$STAGE" -iname '*.nex' -o -iname '*.nexmap' -o -iname '*.swu' -o -iname '*.img' \
        -o -iname '*.ext4' -o -iname '*.service' | grep -q .; then
    echo "refusing: flashable/service file in bundle" >&2; exit 1
fi
if grep -nE '(^|[^#]*[;&|[:space:]])(systemctl|mount|ip link|ifconfig|swupdate|fw_setenv|dd if=)' \
        "$B/run-scratch.sh" | grep -v '^[0-9]*:#'; then
    echo "refusing: run-scratch.sh contains a system-modifying command" >&2; exit 1
fi

(cd "$B" && find . -type f ! -name SHA256SUMS -print0 | sort -z | xargs -0 sha256sum >SHA256SUMS)
mkdir -p "$OUTDIR"
tar czf "$ARCHIVE" -C "$STAGE" SCRATCH-TEST-NOT-FIRMWARE.txt "$DIR"
(cd "$OUTDIR" && sha256sum "$NAME.tar.gz" >"$NAME.tar.gz.sha256")
echo "bundle: $ARCHIVE ($(stat -c%s "$ARCHIVE") bytes)"
echo "sha256: $(cut -d' ' -f1 "$ARCHIVE.sha256")"
tar tzvf "$ARCHIVE" | grep -v '/tiles/.*\.png$'
echo "   (+ $(tar tzf "$ARCHIVE" | grep -c '/tiles/.*\.png$') map tiles)"
