# RUSTYNSP

Haltech iC-7 custom Qt/QML dash application and firmware reference material.
The supplied project archive is retained in `vendor/source-archives/`;
the extracted stock dash resources are organized under
`reference/stock-dash-extract/`. The decompiled NSP source is in `nsp_src/`,
and the ILSpy command-line tool is in `tools/ilspy/`.

## Repository Layout

- `ic7-custom-dash/` — companion dash application, deployment guides, tests,
  and experimental resource builds.
- `ic7-emulator/` — isolated Windows NSP protocol and renderer workbench.
- `nsp_src/` and `nsp-rebuild/` — NSP source snapshot and rebuild project.
- `fw/` — firmware packages, definitions, and extracted firmware references.
- `reference/stock-dash-extract/` — extracted stock QML/resources used for
  read-only comparison.
- `research/` — captured USB evidence, map inputs, analysis scratch work,
  emulator session data, and decompiled updater research.
- `vendor/` — original source archive and local vendor application installs.
  `vendor/local-installs/` is intentionally ignored by Git.
- `scripts/` — repository-level inspection and packaging scripts.
- `dist/` — generated test bundles and candidate packages.

## Repository Storage

Large firmware, archive and capture files use Git LFS. Install Git LFS before
cloning, or initialize it and download the content in an existing clone:

```bash
git lfs install
git lfs pull
```

Pushing the initial LFS history requires approximately 3.25 GiB of available
GitHub LFS storage and upload bandwidth. Keep at least 2 GiB of free local
space for LFS temporary files in addition to the checkout and LFS object cache.

The canonical stock v2.36 package is [fw/Dash-V2-36-0-Release.nex](fw/Dash-V2-36-0-Release.nex).
Generated map probes and their reports are retained under
[build-nsp-map/](ic7-custom-dash/build-nsp-map/).
Desktop CMake/qmake build directories and Python bytecode caches are not
versioned; regenerate desktop builds using the commands below.

The extracted root filesystem is also omitted because it is byte-for-byte
reproducible from the retained compressed archive. If needed, restore it with:

```bash
gzip -dc fw/swu_nsp/var-image-swupdate-var-som-mx6.tar.gz \
  > fw/swu_nsp/var-image-swupdate-var-som-mx6-20240621065410.rootfs.tar
```

## Runnable Simulator

[Download the updated Windows workbench](dist/ic7-emulator-windows-workbench-nsp-autosetup.zip) and read
[ic7-emulator/README.md](ic7-emulator/README.md) for setup. It includes a
capture-derived device profile, virtual-COM protocol runtime, live viewers,
and a source-derived bridge to an isolated copy of NSP's actual dash renderer.
Windows NSP discovery and the original-renderer runtime still need testing
on the owner's PC; physical firmware execution is not emulated.
For the virtual GIF test, use the [updated map test kit](dist/ic7-nsp-media-map-test-autosetup.zip)
with the matching [GIF-only resource candidate](dist/ic7-gif-only-mapfix.zip).

## Build Results (2026-10-28)

**Deployment blocker:** the owner's firmware-2.36 dash is accessible only via
NSP over USB, not SSH. The standalone app does not implement NSP USB services.
The [ARM app scratch-test bundle](dist/ic7dash-arm-scratch-test.tar.gz) is for
vendor-authorized shell access only; its [SHA-256 checksum](dist/ic7dash-arm-scratch-test.tar.gz.sha256)
is provided alongside it. The bundle is not an NSP-installable package or a
flashable CFW image. Its app was freshly cross-built and smoke-tested in QEMU,
not on the physical dash.
An experimental resource-only media patch supports GIF and muted looping MP4
in `HalImage.qml`, preserving the stock executable and the other 338 package
members. The current [HDEF-assisted media candidate](ic7-custom-dash/build-cfw-media-mapfix-alias/ic7-2.36-media-cfw-mapfix-alias-experimental.nex)
and [build report](ic7-custom-dash/build-cfw-media-mapfix-alias/build-report.json)
are not NSP- or hardware-validated. See
[USB investigation and Windows diagnostics](ic7-custom-dash/deploy/USB-INSTALL.md).

The companion Qt app includes an offline map, GIF/MP4 selector, and checksummed
NMEA RMC/GGA input over a serial GPS receiver. No internal GPS was confirmed;
real tracking requires an external receiver, and Grafton tiles require a
lawfully licensed, attributed provider. The app owns the display separately
from the OEM UI, so OEM warnings are not visible at the same time. See
[map integration and offline test](ic7-custom-dash/deploy/NEXMAP-INTEGRATION.md)
and the [CFW bench-test kit guide](ic7-custom-dash/deploy/CFW-TEST-KIT.md).

The bench-test kit is explicitly **not firmware and not flashable**. It groups
the resource candidate, test map, ARM demo bundle, checksums and test guidance.
Neither the resource package nor map package contains the standalone app or
provides a verified installation/recovery route.

- [Bench-test kit (not firmware or flashable)](dist/ic7-cfw-bench-test-kit-2.36.zip)
- [Windows NSP integration test bundle](dist/ic7-nsp-media-integration-test-2.36.zip):
  use only with a complete copy of NSP while the physical dash is disconnected.
  The included DLL is an unsigned test build; the bundle does not initiate a
  firmware update.
- [SHA-256 checksums](dist/ic7-test-bundles.sha256) for both test bundles.

- Linux desktop build: recreate using the commands in Desktop Verification.
- Hardware build: `ic7-custom-dash/build-arm/ic7dash`, ARMv7 hard-float EABI5,
	124,496 bytes after stripping.
- Deployment bundle: [ic7dash-arm-bundle.tar.gz](ic7-custom-dash/build-arm/ic7dash-arm-bundle.tar.gz),
	containing the binary and 294 Sydney demo tiles; it does not contain Grafton
	map data or a GPS receiver.
- Cross-build uses GCC 11, Qt 5.9.9 host moc/rcc, and the stock firmware's
	Qt 5.9.6 headers/libraries and glibc 2.24 sysroot. The executable directly
	requires no glibc symbol version newer than GLIBC_2.4.
- Both the pre-extracted rootfs path and a fresh extraction from
	`fw/Haltech-NSP-1.3.2.swu` compiled successfully.
- Desktop and QEMU ARM runs loaded all seven CAN frame definitions, rendered
	both pages, and exited normally through the screenshot workflow.

This is a rebuilt application bundle, not a flashable replacement firmware
image. No device was connected or flashed. The custom image component passed
GIF and supplied 1080p H.264 MP4 tests on desktop Qt 5.15 and the extracted ARM
Qt 5.9.6 software stack under QEMU. Physical eglfs display, decoder performance,
CAN, GPS, and NSP coexistence still require hardware verification. GPS and CAN
default to simulated data; the GPS demo route and finish line must be configured
for actual use. Clock synchronization from GPS/CAN is not wired up.
ARM offscreen captures are vertically flipped and have uncovered map areas;
do not treat emulation as confirmation of physical display behavior.

## Rebuild for the Dash

On Ubuntu 24.04, from this repository root:

```bash
bash ic7-custom-dash/deploy/wsl-build.sh
bash ic7-custom-dash/deploy/bundle.sh
```

The first script installs its required apt dependencies using noninteractive
sudo and downloads only Qt 5.9's qtbase host tools into `~/ic7build` using an
isolated Python environment. Subsequent builds can skip package installation:

```bash
SKIP_INSTALL=1 bash ic7-custom-dash/deploy/wsl-build.sh
```

`SRC`, `SWU`, `ROOTFS`, `WORK`, `QT59`, and `XCXX` can override build inputs.
The script prioritizes the firmware's libc headers and startup objects over
Ubuntu's cross headers. Using Ubuntu's default GCC 13 without this setup
introduced unresolved `__isoc23_strtoul` and `__ioctl_time64` symbols.
Ghidra, a JDK, .NET, Windows Qt, and a WSL disk image are not needed to build
this application in Linux.

## Desktop Verification

The installed Qt 5 development/runtime packages support this clean build:

```bash
cmake -S ic7-custom-dash -B ic7-custom-dash/build-linux -DCMAKE_BUILD_TYPE=Release
cmake --build ic7-custom-dash/build-linux -j 2
cp -a ic7-custom-dash/tiles ic7-custom-dash/bg.gif ic7-custom-dash/build-linux/
mkdir -p ic7-custom-dash/shots/linux-map
xvfb-run -a env LIBGL_ALWAYS_SOFTWARE=1 \
	IC7_SHOT="$PWD/ic7-custom-dash/shots/linux-map" \
	ic7-custom-dash/build-linux/ic7dash
```

Desktop captures: [gauges](ic7-custom-dash/shots/linux-map/page1.png),
[offline map and laps](ic7-custom-dash/shots/linux-map/page2.png).
ARM offscreen captures are under `ic7-custom-dash/shots/arm-map/`.
The QML component suite passed nine tests on desktop Qt 5.15 and stock ARM Qt
5.9.6 under QEMU. ARM QEMU smoke tests covered the local-tile map, animated GIF,
and H.264 MP4; a PTY test accepted a valid Grafton NMEA fix and rejected a bad
checksum. QEMU does not validate i.MX6 hardware decode, GPS reception, or
physical display performance.

For the hardware run procedure, see
[ON-DASH-TEST.md](ic7-custom-dash/deploy/ON-DASH-TEST.md).
For architecture and deployment details, see
[MASTER-GUIDE.md](ic7-custom-dash/MASTER-GUIDE.md).