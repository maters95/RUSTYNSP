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
- [`nexmap-web/`](nexmap-web/README.md) — free, account-free browser-based map
  recovery; files are processed locally and never uploaded.
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

## Read-Only iC-7 USB Diagnostics

The [Windows diagnostic kit](dist/ic7-usb-diagnostics.zip) collects host/device
inventory, supports bounded passive USBPcap captures, and offers one explicit
read-only identity query with NSP closed. The offline analyzer preserves both
traffic directions, validates protocol CRCs and reports unknown/incomplete
data. It does not scan addresses or send settings/firmware/update commands.
Passive capture cannot stop NSP from independently writing.

See [setup, commands and verification limits](ic7-custom-dash/deploy/USB-INSTALL.md#read-only-usb-diagnostics-kit).
The analyzer was checked against a recorded physical-device capture; live
Windows capture/query operation is not yet hardware-validated. USB identity
and traffic do not enumerate every physical component or prove unused hardware.

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

## Screen Alarms, Splash and Real-Dash Fixes (2026-10-30)

Use the [combined Windows test kit, revision 6](dist/ic7-final-windows-test-2026-10-31-r6.zip)
(SHA-256 `28ad7ae5bc545c44d9e4a73a2c00aaadb0b9fee5d57f64281b5f2251940e8185`) and its `START-HERE.md`. It
carries the same NEX as r3 and the same reviewed NSP DLL as r4 (NSP-convention
alarm appearance UI, 20-character name validation), with the emulator's opt-in
Generic CAN engine simulation now writing at the USB addresses NSP polls, and
the accuracy-reviewed guides, and your KFC map with its alarm GIF's
transparent first frame removed (only that file changed). Interchangeable files for swap testing, with a
stock base, are in [`test-variants/`](test-variants/). It supersedes r5, r4, r3, r2 (NEX `3f6d26f1…`, which must not
be flashed), the first 2026-10-30 kit and the 2026-10-29 kits.
Its NEX is `build-cfw-screen-alarms-r3-236` (SHA-256 `dec4e3bf…`). It combines
main's native **Alarm appearance** editor and screen-restricted alarms with:

- **Stock banners over custom media.** A full-screen GIF-only banner (KFC
  LIMITER) could cover an earlier stock alarm such as OIL PRESSURE; stock
  bottom-stacked banners now always draw above custom media.
- **Real-dash emulator.** The emulator installs the NEX as the dash watchdog
  does, uses the dash's folder layout, answers NSP as the captures show
  (36,450 exchanges, 0 differences) and writes a fidelity report that says why
  any manifest lookup failed. On Windows its launcher installs the new
  `cryptography` requirement ([emulator README](ic7-emulator/README.md#dash-fidelity)).
- **Fresh QML modification times**, a precaution only: the owner's videofix
  flash shows the dash does not reuse its QML cache across updates, so the
  wrong resource path is the proven cause of the failed flash
  ([cache audit](ic7-custom-dash/deploy/nsp/MEDIA-RUNTIME-AUDIT.md#stale-qml-disk-cache-on-the-dash)).
  The alarm popup also re-reads its manifest at most every 2 s instead of on
  every native UI tick.

- **Real-dash path fix.** The dash keeps uploaded media in
  `/opt/applications/dtn/user_resources/images`; the splash and alarm components
  had looked in NSP's Windows layout. Decoding the 2026-10-29 `fail.pcapng` showed
  every resource and the NEX body arrived intact, and its two device error replies
  also occur in a stock Haltech update
  ([capture analysis](ic7-custom-dash/deploy/nsp/MEDIA-RUNTIME-AUDIT.md#what-the-2026-10-29-flash-capture-shows)).
- **Alarm banners without QtMultimedia**, a **stock-matching splash placement**
  (an 800 x 480 GIF now fills the panel), a **native screen fallback** for
  restricted alarms, and an alarm-appearance preview over the real screen.
- An independent NEX audit (`scripts/audit-nex.py`) and the restored full NEX
  builder.

See the [alert guide](ic7-custom-dash/deploy/nsp/ALERTS-TEST.md) and
[startup guide](ic7-custom-dash/deploy/nsp/SPLASH-TEST.md). Not flashed or tested
on hardware; Windows NSP/emulator acceptance is still required.

For what else the firmware could be made to do — camera, Wi-Fi, night mode,
datalogging, lap timer, custom fonts and more, ranked by risk — see the
[firmware capability deep-dive](ic7-custom-dash/deploy/nsp/FIRMWARE-CAPABILITIES.md).

## Build Results (2026-10-28)

For **native dash-canvas GIF/MP4 testing**, use the
[native media video-fix bundle](dist/ic7-nsp-native-media-test-2.36-videofix.zip) and its
[Windows setup and test guide](ic7-custom-dash/deploy/nsp/NATIVE-MEDIA-TEST.md).
Unlike the older picker-only bundles, it hooks NSP's actual Qt renderer and
downloads matching Qt 5.11.3 x86 media add-ons. The bundle contains a matching
resource-only NEX candidate, not a fully hardware-validated CFW. Desktop rendered
pixels and ARM playback lifecycle are tested separately; Windows GUI playback
and installation on the real unit still require validation. The owner's real
stock-update USB capture confirms stock payload layout, not this new candidate.
The original native-media ZIP omitted the form resources and crashes at startup.
Use the startup-fix bundle: all 25 form resource sets are retained alongside the
shared QML, with build and packaging guards against their omission.
The video-fix bundle also supplies Qt 5.11's actual DirectShow player backend
and Qt Widgets dependency; the earlier audio-decoder-only plugin could not
create a video service. Owner testing confirms GIF playback on the Windows
canvas; MP4 playback with the corrected runtime still needs confirmation.

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
- [Windows NSP integration test bundle with startup and video-alias preview fixes](dist/ic7-nsp-media-integration-test-2.36-previewfix.zip):
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