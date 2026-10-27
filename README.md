# RUSTYNSP

Haltech iC-7 custom Qt/QML dash application and firmware reference material.
The supplied `iC7-Custom-Dash-Project.7z` has been extracted into this workspace.
The decompiled source and ILSpy are at `nsp_src/` and `ilspy/`, respectively
(not under `tools/` in this archive).

## Runnable Simulator

[Download the updated Windows workbench](dist/ic7-emulator-windows-workbench-nsp-autosetup.zip) and read
[ic7-emulator/README.md](ic7-emulator/README.md) for setup. It includes a
capture-derived device profile, virtual-COM protocol runtime, live viewers,
and a source-derived bridge to an isolated copy of NSP's actual dash renderer.
Windows NSP discovery and the original-renderer runtime still need testing
on the owner's PC; physical firmware execution is not emulated.
For the virtual GIF test, use the [updated map test kit](dist/ic7-nsp-media-map-test-autosetup.zip)
with the matching [GIF-only resource candidate](dist/ic7-gif-only-mapfix.zip).

## Build Results (2026-10-27)

**Deployment blocker:** the owner's firmware-2.36 dash is accessible only via
NSP over USB, not SSH. The standalone app does not implement NSP USB services.
The [ARM app scratch-test bundle](dist/ic7dash-arm-scratch-test.tar.gz) is for
vendor-authorized shell access only; it is not an NSP-installable package or a
flashable CFW image. Its app was freshly cross-built and smoke-tested in QEMU,
not on the physical dash.
An experimental resource-only media patch now supports GIF and muted looping
MP4 in `HalImage.qml`, preserving the stock executable. NSP acceptance and
hardware installation remain untested. See
[USB investigation and Windows diagnostics](ic7-custom-dash/deploy/USB-INSTALL.md).

The owner's map has now been decoded and an asset-only test copy built, with
all original settings/layouts preserved. The next test can be performed in
Windows NSP **with the dash disconnected**. See
[map integration and offline test](ic7-custom-dash/deploy/NEXMAP-INTEGRATION.md).

Candidate: [experimental media resource package](ic7-custom-dash/build-nsp-media/ic7-2.36-media-preview-experimental.nex).
Stock counterpart: [experimental stock-resource package](ic7-custom-dash/build-nsp-media/ic7-2.36-stock-resources-experimental.nex).
[Build report](ic7-custom-dash/build-nsp-media/build-report.json) verifies that
only `HalImage.qml` changed and all other 338 resource entries retain their
contents. [MP4/GIF map asset probe](ic7-custom-dash/build-nsp-map/zak-2.36-media-probe.nexmap)
preserves the original map entries/settings. Neither candidate contains an app
executable, OS image, definition, or STM32 firmware. Live map/GPS integration
and physical firmware installation remain separate, untested work.

- Linux desktop build: `ic7-custom-dash/build-linux/ic7dash`.
- Hardware build: `ic7-custom-dash/build-arm/ic7dash`, ARMv7 hard-float EABI5,
	108,112 bytes after stripping.
- Deployment bundle: [ic7dash-arm-bundle.tar.gz](ic7-custom-dash/build-arm/ic7dash-arm-bundle.tar.gz),
	containing the binary, CAN configuration, GIF, CAN setup script and 294 tiles.
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
The QML component suite passed eight tests on desktop Qt 5.15 and stock ARM Qt
5.9.6 under QEMU, including GIF frame advance and playback of the supplied
1080p H.264 MP4. QEMU does not validate i.MX6 hardware decode or physical
display performance.

For the hardware run procedure, see
[ON-DASH-TEST.md](ic7-custom-dash/deploy/ON-DASH-TEST.md).
For architecture and deployment details, see
[MASTER-GUIDE.md](ic7-custom-dash/MASTER-GUIDE.md).