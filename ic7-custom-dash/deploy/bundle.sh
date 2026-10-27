#!/usr/bin/env bash
# Assemble the deployable ARM bundle after wsl-build.sh has produced build-arm/ic7dash.
set -euo pipefail
HERE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
SRC="${SRC:-$(cd "$HERE/.." && pwd)}"
OUT="$SRC/build-arm"
cd "$OUT"

echo "unstripped: $(stat -c%s ic7dash) bytes"
arm-linux-gnueabihf-strip ic7dash || true
echo "stripped:   $(stat -c%s ic7dash) bytes"

rm -rf ic7test
mkdir -p ic7test
cp ic7dash                      ic7test/
cp "$SRC/resources/emtron_can.json" ic7test/
cp -r "$SRC/tiles"              ic7test/
cp "$SRC/bg.gif"                ic7test/
cp "$SRC/deploy/bringup-can.sh" ic7test/
chmod +x ic7test/ic7dash ic7test/bringup-can.sh

tar czf ic7dash-arm-bundle.tar.gz ic7test
echo "bundle: $(stat -c%s ic7dash-arm-bundle.tar.gz) bytes -> $OUT/ic7dash-arm-bundle.tar.gz"
echo "contents:"; tar tzf ic7dash-arm-bundle.tar.gz | grep -v '/tiles/' ; echo "   (+ $(tar tzf ic7dash-arm-bundle.tar.gz | grep -c '/tiles/.*\.png') map tiles)"
