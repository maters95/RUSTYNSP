#!/usr/bin/env bash
# Run the experimental add-on QML tests.
#   Desktop Qt 5.15 (default): every tst_*.qml, including pixel comparisons.
#   Dash Qt 5.9.6 under QEMU:  IC7_SYSROOT=/path/to/sysroot scripts/addons_tests/run.sh
#     (pixel tests are skipped there: offscreen grabImage returns black on ARM).
set -euo pipefail

HERE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
ROOT="$(cd "$HERE/../.." && pwd)"
TESTS="$ROOT/ic7-custom-dash/deploy/addons/tests"

if ! command -v ffmpeg >/dev/null; then
    echo "ffmpeg is required to build the MP4 fixture." >&2
    exit 1
fi
/usr/bin/python3 "$HERE/make_fixtures.py"

if [[ -n "${IC7_SYSROOT:-}" ]]; then
    status=0
    for test in "$TESTS"/tst_*.qml; do
        [[ "$(basename "$test")" == tst_Pixels.qml ]] && continue
        qemu-arm -L "$IC7_SYSROOT" \
            -E QML_DISABLE_DISK_CACHE=1 \
            -E QT_QPA_PLATFORM=offscreen -E QT_QUICK_BACKEND=software \
            -E QT_PLUGIN_PATH="$IC7_SYSROOT/usr/lib/plugins" \
            -E QML2_IMPORT_PATH="$IC7_SYSROOT/usr/lib/qml" \
            "$IC7_SYSROOT/usr/bin/qmltestrunner" -input "$test" -o -,txt || status=1
    done
    exit $status
else
    xvfb-run -a env LIBGL_ALWAYS_SOFTWARE=1 QML_DISABLE_DISK_CACHE=1 QML_XHR_ALLOW_FILE_READ=1 \
        qmltestrunner -input "$TESTS" -o -,txt
fi
