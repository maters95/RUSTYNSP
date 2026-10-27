#!/usr/bin/env bash
# Cross-compile ic7dash for the iC-7 (armv7hf, Qt 5.9.6) from Ubuntu/WSL.
# No Boot2Qt SDK needed: uses apt's arm cross-compiler + the dash's OWN Qt 5.9
# libraries (from the unencrypted Haltech .swu) as the sysroot. Host moc/rcc
# must match the target Qt 5.9 libraries.
#
# Usage (inside WSL Ubuntu):
#   bash wsl-build.sh
# Override paths with env vars if needed:
#   SRC=<project dir> SWU=<path to Haltech-NSP-1.3.2.swu> bash wsl-build.sh
set -euo pipefail

# --- paths (defaults assume this script is run from the project's deploy/) ---
HERE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
SRC="${SRC:-$(cd "$HERE/.." && pwd)}"
SWU="${SWU:-$SRC/../fw/Haltech-NSP-1.3.2.swu}"
ROOTFS="${ROOTFS:-$SRC/../fw/swu_nsp/var-image-swupdate-var-som-mx6-20240621065410.rootfs.tar}"
WORK="${WORK:-$HOME/ic7build}"
SYSROOT="$WORK/sysroot"
OUT="$SRC/build-arm"
XCXX="${XCXX:-arm-linux-gnueabihf-g++-11}"

echo "== 1. Install toolchain + extractors + Qt 5.9 HOST moc/rcc (version-matched)"
if [[ "${SKIP_INSTALL:-0}" != 1 ]]; then
  sudo -n apt-get update -y
  sudo -n apt-get install -y g++-11-arm-linux-gnueabihf p7zip-full file python3-venv xz-utils libgl1
fi
mkdir -p "$WORK"
# Ubuntu's own moc is Qt 5.15 and emits macros Qt 5.9 lacks (QT_INIT_METAOBJECT).
# Install a matching Qt 5.9.9 host build via aqt and use ITS moc/rcc.
QT59="${QT59:-$WORK/qt59/5.9.9/gcc_64}"
if [[ ! -x "$QT59/bin/moc" ]]; then
  python3 -m venv "$WORK/aqt-venv"
  "$WORK/aqt-venv/bin/pip" install --quiet aqtinstall
  "$WORK/aqt-venv/bin/aqt" install-qt linux desktop 5.9.9 gcc_64 -O "$WORK/qt59" --archives qtbase
fi
export LD_LIBRARY_PATH="$QT59/lib:${LD_LIBRARY_PATH:-}"
MOC="$QT59/bin/moc"; RCC="$QT59/bin/rcc"
"$MOC" -v; "$RCC" -v
echo "   xcc=$(command -v $XCXX)"

echo "== 2. Extract the dash Qt 5.9 sysroot (symlinks preserved)"
mkdir -p "$WORK" "$SYSROOT"
cd "$WORK"
if [[ ! -f "$SYSROOT/usr/lib/libQt5Core.so.5" ]]; then
  if [[ ! -f "$ROOTFS" ]]; then
    7z x -y "$SWU" >/dev/null
    rootfs_archives=("$WORK"/var-image-*.tar.gz)
    gzip -dkf "${rootfs_archives[0]}"
    ROOTFS="${rootfs_archives[0]%.gz}"
  fi
  tar -xf "$ROOTFS" -C "$SYSROOT" ./usr/include ./usr/lib ./lib
  echo "   sysroot ready: $(du -sh "$SYSROOT" | cut -f1)"
fi
QTINC="$SYSROOT/usr/include/qt5"
[[ -d "$QTINC/QtCore" ]] || { echo "ERROR: Qt headers not found in sysroot ($QTINC)"; exit 1; }

echo "== 3. moc the Q_OBJECT headers + rcc the resources (host tools)"
mkdir -p "$OUT"; cd "$OUT"
INCS="-I$QTINC -I$QTINC/QtCore -I$QTINC/QtGui -I$QTINC/QtQml -I$QTINC/QtQuick \
      -I$QTINC/QtNetwork -I$QTINC/QtPositioning -I$QTINC/QtLocation -I$QTINC/QtMultimedia -I$SRC/src"
for h in channelmodel emtrondecoder cansource laptimer tileserver; do
  "$MOC" -DHAVE_SOCKETCAN "$SRC/src/$h.h" -o "moc_$h.cpp"
done
"$RCC" -name qml "$SRC/qml.qrc" -o qrc_qml.cpp

echo "== 4. Cross-compile + link against the dash sysroot"
GCCINC="$("$XCXX" -print-file-name=include)"
CXXINC="${CXXINC:-/usr/arm-linux-gnueabihf/include/c++/$("$XCXX" -dumpversion)}"
CXXFLAGS="-O2 -std=gnu++14 -fPIC -DQT_NO_DEBUG -DHAVE_SOCKETCAN --sysroot=$SYSROOT $INCS"
SYSTEM_INCLUDES=(-nostdinc -isystem "$CXXINC" -isystem "$CXXINC/arm-linux-gnueabihf"
                 -isystem "$CXXINC/backward" -isystem "$GCCINC" -isystem "$SYSROOT/usr/include")
LIBS="-lQt5Quick -lQt5Qml -lQt5Network -lQt5Location -lQt5Positioning \
      -lQt5Multimedia -lQt5Gui -lQt5Core -lpthread -ldl -lrt"
# gcc-11's static libstdc++ references __libc_single_threaded (glibc>=2.32);
# the dash is glibc 2.24. Provide it (0 = assume multithreaded, the safe path).
printf 'char __libc_single_threaded = 0;\n' > compat_stub.c
"$XCXX" $CXXFLAGS "${SYSTEM_INCLUDES[@]}" -B"$SYSROOT/usr/lib/" \
  compat_stub.c \
  "$SRC/src/main.cpp" "$SRC/src/cansource.cpp" "$SRC/src/emtrondecoder.cpp" \
  "$SRC/src/channelmodel.cpp" "$SRC/src/laptimer.cpp" "$SRC/src/tileserver.cpp" \
  moc_channelmodel.cpp moc_emtrondecoder.cpp moc_cansource.cpp moc_laptimer.cpp \
  moc_tileserver.cpp qrc_qml.cpp \
  --sysroot="$SYSROOT" -L"$SYSROOT/usr/lib" -L"$SYSROOT/lib" \
  -Wl,-rpath-link,"$SYSROOT/usr/lib" -Wl,--allow-shlib-undefined \
  -static-libstdc++ -static-libgcc \
  $LIBS -o ic7dash

echo "== 5. Result"
file ic7dash
echo "   -> $OUT/ic7dash"
echo "Next: copy ic7dash + resources/emtron_can.json + tiles/ + bg.gif to the dash"
echo "      (see deploy/ON-DASH-TEST.md) and run it the reversible way."
