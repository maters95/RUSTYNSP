# iC-7 Custom Dash — Master Guide & Handover

Everything learned and built for the Haltech iC-7 custom-dash project, in one
place, so work can continue in a new session or on another machine. Written
2026-10-26. All analysis was read-only; nothing has been flashed to the dash.

---

## 1. Goal
Add features the stock iC-7 / NSP can't do — **maps, GPS lap timing, a clock,
and an animated (GIF/video) background** — on the owner's own dash, while
**keeping Haltech's stock firmware and NSP working** ("Route B"). Owner has
Haltech's verbal blessing; this is a personal project.

## 2. The dash hardware & OS (confirmed)
- **SoM:** Variscite **VAR-SOM-MX6** — NXP **i.MX6** (Cortex-A9, armv7-hf).
- **OS:** **Boot to Qt for Embedded Linux 2.2.4 ("morty")**, Linux 4.1.15,
  systemd, **glibc 2.24**, **Qt 5.9.6** (eglfs).
- **Panel:** 800x480 (the 860-wide NSP layout is scaled 800/860 at runtime).
- **Storage:** eMMC, **A/B rootfs** (`mmcblk0p1`/`p2`), `/opt/applications`
  (p3) = the dash app, `/mnt/usb` (p4) = datalogs + `/mnt/usb/upgrade`.
- **I/O:** FTDI USB (device-mode, the NSP link `/dev/ttyGS0`), socketcan,
  an STM32 I/O coprocessor, camera input, PWM backlight. Firmware includes
  Bluetooth LE/Classic support, but a fitted, usable onboard radio has not
  been confirmed on the owner's unit. See the
  [RaceBox/Bluetooth investigation](deploy/RACEBOX-FEASIBILITY.md).
- **No usable RTC** (only the i.MX6 SNVS, no backup cell evident) → the clock
  needs GPS/CAN time. The observed **NSP USB connection is device-mode**;
  that does not establish an accessible host port. Do not infer a BLE-only
  radio or Android Auto capability from the SoM's generic specifications.
  The stock runtime is Boot2Qt Linux, not Android.

## 3. Firmware: structure & what's accessible
- NSP downloads firmware to `C:\ProgramData\Haltech\Nexus\Firmware\Dash-V2-*.nex`
  and definitions to `...\Definitions\IC7_*.hdef`. The current/matching version
  is **v2.36.0** (`Dash-V2-36-0-Release.nex`).
- A `.nex` is a plain ZIP containing `ic-7.hdef`, `res_ic-7.qzip` (QML/resources),
  `nic-7` (the dash app), `dstm` (STM32 firmware), `manifest.xml`, release notes.
  Payloads use encoded formats. **Update, 2026-10-26:** the actual v2.36
  `res_ic-7.qzip` was decoded offline using the owner's reference updater:
  it contains a POSIX tar with 339 resource entries. A resource-only GIF
  candidate was rebuilt without changing the stock executable or STM32 stage.
  See [USB installation findings](deploy/USB-INSTALL.md) for exact scope,
  verification, and the remaining NSP/hardware acceptance checks.
- **Unencrypted reference exists:** the legacy ICC install
  `C:\Program Files\Haltech\Haltech ICC\Firmware\Haltech-NSP-1.3.2.swu` is a
  SWUpdate package with a **full, unencrypted rootfs** (DTN v2.26.9) — Qt 5.9.6,
  the OS, `/opt/applications/dtn/app/dash_application`, CAN protocol JSONs, etc.
  This is the sysroot/reference source for cross-building.
- `.nexmap` / `.nexcfg` = ZIP with **WinZip-AES-256** entries (DotNetZip) — that's
  why .NET's ZipArchive can't open them; the password lives (obfuscated) in NSP.
  Not extracted; not needed for the app.

## 4. NSP ↔ dash protocol (for "NSP-native" CFW, documented, not required by the app)
- The dash runs `ConnectionHandle::perform_action()` over USB (FTDI). NSP reads/
  writes **named address spaces**: `id_and_command`, `channel` (live values),
  `settings` (+sync counter), `hdef`, `dash_qmldata` (screen push),
  `dash_datalog`, `dash_camera`, `dash_app_upgrade`, `dash_swu_upgrade`,
  `dash_stm`, `device_list`. Bodies guarded by **standard CRC-32** (reflected
  in/out, xorout 0xFFFFFFFF). Source: ILSpy decompile of `NSP.dll` + symbols from
  the unencrypted `dash_application`. (Ghidra wouldn't launch on this PC.)
- For **Route B you do NOT need any of this** — you keep the stock app, which
  already speaks NSP.

## 5. Feature parity v2.26.9 → v2.36.0
Full changelog in `deploy/FEATURE-PARITY.md`. Bottom line: **Route B keeps stock
v2.36 whole, so nothing is lost.** The only new dash-CAN capability in 2.36
("little-endian bitstring over multiple bytes") is already how the custom app's
decoder works. Stock firmware has had native GPS + lap-timing since v2.31.

## 6. The custom app (`ic7-custom-dash/`) — BUILT & VERIFIED ON DESKTOP
A standalone Qt/QML dash you own; runs alongside the stock firmware (Route B).
**Status: compiles and runs on PC (verified via screenshots), AND cross-built
for the dash — an armv7 ELF binary (`ic7dash`) was produced via WSL2/Ubuntu +
`g++-arm-linux-gnueabihf`, linked against the dash's own Qt 5.9 libraries
(from the `.swu`), using a version-matched Qt 5.9 moc/rcc. Statically verified:
max glibc symbol GLIBC_2.4 (dash has 2.24), static libstdc++ (no C++ ABI dep),
needs only libs present on the dash. Deployable bundle:
`build-arm/ic7dash-arm-bundle.tar.gz` (binary + CAN map + tiles + bg.gif +
bringup-can.sh). NOT yet run on the dash / flashed — next step is the reversible
on-dash test (§10). Reproduce the build with `deploy/wsl-build.sh`.**

Features:
- **Gauges page:** big RPM bar with redline + shift-light flash, large speed,
  boost/AFR gauges, compact tiles (coolant/oil temp/oil & fuel pressure/IAT/
  ethanol). Bound to live CAN via your real Emtron map.
- **Nav page:** background selectable by `IC7_BG` = `map` | `gif` | `video`.
  - `map`: offline moving map (embedded loopback tile server; see below).
  - `gif`: full-screen `bg.gif` (Android-Auto-style animated backdrop).
  - `video`: loops `bg.mp4` (QtMultimedia, muted).
  Lap-timing panel + clock always on top; GPS lap timing always runs.
- **GPS lap timing:** finish-line crossing → current/last/best; verified.
- **Clock:** system time on PC; feed from GPS/CAN time on the dash (no RTC).

Key source files:
- `src/main.cpp` — wires channels/decoder/CAN source/lap timer/tile server; env:
  `IC7_CAN` (SocketCAN iface), `IC7_BG` (bg mode), `IC7_SHOT` (screenshot+quit).
- `src/emtrondecoder.*` — table-driven CAN decode from `resources/emtron_can.json`
  (no recompile to change). Handles arbitrary start-bit/length/endian/scale.
- `src/cansource.*` — `SimulatedCanSource` (PC) + `SocketCanSource` (Linux/dash);
  falls back to simulator if `can0` isn't up.
- `src/channelmodel.*` — live channels exposed to QML as `channels.NAME`.
- `src/laptimer.*` — GPS finish-line crossing lap timer.
- `src/tileserver.*` — tiny loopback HTTP server serving `tiles/<z>/<x>/<y>.png`
  so the map works fully offline (no internet, no TLS).
- `qml/` — Main (SwipeView), GaugesPage, TrackPage (map/gif/video + laps), Gauge,
  Clock.
- `resources/emtron_can.json` — YOUR Emtron CAN map (see §7).
- `tiles/` — 294 seeded offline map tiles (ESRI street, demo area ~Sydney).
- `bg.gif` — placeholder animated background (replace with your own).

Build & run on a PC (what was done here):
```
cmake -S . -B build -G "MinGW Makefiles" -DCMAKE_PREFIX_PATH=<Qt>/mingw81_64
cmake --build build -j
# run: set QT_PLUGIN_PATH / QML2_IMPORT_PATH to the Qt kit, then build/ic7dash.exe
# IC7_SHOT=<dir> grabs page PNGs and exits (how screenshots were made)
```

## 7. Your Emtron CAN map (`resources/emtron_can.json`)
Read from NSP (Generic CAN) by the EK9 session. All signals 16-bit little-endian
unsigned; physical = raw*scale+offset; pressures in psi (Emtron sends kPa×10):
- 0x3E8: ENGINE_SPEED(b0-1,×1), MANIFOLD_PRESSURE(b2-3,×0.0145038,-14.696 psi),
  COOLANT_TEMP(b4-5,×0.1,-50°C), INTAKE_AIR_TEMP(b6-7,×0.1,-50°C)
- 0x3E9: OIL_PRESSURE(b0-1 psi), FUEL_PRESSURE(b2-3 psi), ETHANOL(b4-5 %),
  LAMBDA(b6-7,×0.001)
- 0x3EA: OIL_TEMP(b0-1,×0.1,-50°C), DTC_CODES(b2-3), IGN_BASE(b4-5,×0.1,-100°),
  VTEC(b6-7)
- 0x3EB: VEHICLE_SPEED(b0-1,×0.1 km/h) — ×0.1 UNCONFIRMED on the road
- 0x3F2: TPS(×0.1,-100%), STFT(×0.01,-100%), LTFT(×0.01,-100%), LAMBDA_TARGET(×0.001)
- 0x3F3: IGN_ANGLE(×0.1,-100°), INJ_DUTY(×0.1 %), DTC_COUNT, KNOCK_COUNT
- 0x3F4: CAM_POS(×0.1,-200°), CAM_TARGET(×0.1,-200°)
AFR shown = LAMBDA × 14.7 (petrol), matching NSP.

## 8. The remaining step: cross-compile for the dash (ARM / Qt 5.9)
Completed on Ubuntu 24.04 on 2026-10-26, including a clean rebuild directly
from the stock `.swu` and an ARM QEMU screenshot run. Run
`bash ic7-custom-dash/deploy/wsl-build.sh` from the repository root, then
`bash ic7-custom-dash/deploy/bundle.sh`. See [build results](../README.md)
for verification details and remaining hardware limitations.
The older alternatives below are retained for reference:

**(a) Any Linux box / Mac+Docker (≈15 min) — recommended.** Follow
`deploy/CROSS-BUILD.md`: get the Variscite VAR-SOM-MX6 Boot2Qt 2.2.x SDK (or
`bitbake meta-toolchain-qt5`), `source environment-setup-*`, then
`qmake ../ic7dash.pro && make` (or the CMake toolchain-file route). The
`ic7dash.pro` qmake project is validated building on desktop. `file ic7dash`
should say ELF 32-bit ARM EABI5.

**(b) WSL on this PC (when you're back at it).** WSL core is installed but:
WSL2 needs CPU virtualization enabled in BIOS (currently off), and WSL1 needs the
"Windows Subsystem for Linux" optional feature (enable via, as admin,
`dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all`
then reboot). Then import Ubuntu, `apt install g++-arm-linux-gnueabihf cmake`,
build against the dash sysroot.

**(c) No-admin portable toolchain on this PC (long shot, in progress).** SysGCC
`raspberry-gcc6.3.0-r5.exe` (GCC 6.3, Raspbian **Stretch = glibc 2.24**, matches
the dash) from gnutoolchains.com — unzip (7z the installer, no admin). Combine
with: the dash's Qt 5.9 libs+headers as a sysroot (extract from the unencrypted
`.swu`, fix the `.so` symlinks that Windows extraction breaks by copying the
versioned target over the dev symlink), and a Qt **5.9** host `moc`/`rcc`/`uic`
for Windows (via `aqt install-qt windows desktop 5.9.9 win32_mingw53`) so moc
output matches the 5.9 target. Then qmake/cmake cross. Many failure points; the
result can't be verified here and must be tested on the dash (safely, §10).

## 9. Deploy — keep NSP native (Route B)
`deploy/`:
- `ic7-overlay.service` + `ic7-mode.sh` + `bringup-can.sh` — a **mode switch**:
  eglfs lets one app own the screen, so *stock mode* = Haltech dash (NSP-native),
  *overlay mode* = your app. `Conflicts=` guarantees one at a time. Stock stays
  the boot default.
- Stage onto a COPY of the stock rootfs: binary + `emtron_can.json` + `tiles/` +
  `bg.gif`/`bg.mp4` at `/opt/applications/ic7overlay/`; `ic7-mode` to `/usr/bin`;
  the `.service` to `/etc/systemd/system`. Do NOT `systemctl enable` it.
- `deploy/CROSS-BUILD.md`, `deploy/DEPLOY.md`, `deploy/seed-tiles.ps1` (seed your
  own map regions), `deploy/FEATURE-PARITY.md`.

## 10. Scratch testing + recovery (CRITICAL — see deploy/ON-DASH-TEST.md & RECOVERY.md)
- The documented scratch test does not intentionally write firmware partitions,
  but it has not been run on the owner's unit and requires vendor-supported
  shell access. This unit is currently accessible only through NSP USB, which
  does not provide app upload. Do not try to bypass that restriction.
- Recovery and permanent installation remain unverified. Before any flash:
  confirm you can enter i.MX6 USB download mode (`uuu`/`imx_usb_loader`) or boot a
  Variscite recovery SD; take a full `dd` eMMC backup; flash only the PASSIVE A/B
  partition; leave `dash_stm` (STM32) alone. On a sealed dash the recovery
  boot-strap may need opening the case / Haltech's service procedure — if you
  can't confirm recovery, DON'T flash; use the reversible test only.

## 11. Tooling installed on this PC (session scratch)
In the session's `scratch...\tools` (mapped to `T:` via `subst` to beat Windows'
260-char path limit — the scratch path is very deep): .NET 8 SDK, `ilspycmd`
(NSP decompiled → `nsp_src/`), JDK 21 + Ghidra 12.2 (Ghidra wouldn't launch),
Qt 5.15.2 MinGW + CMake + the MinGW compiler (used for the desktop build), Qt
OpenSSL (ABI-mismatched, unused). NOTE: the deep scratch path breaks native-exe
launching and symlink extraction — use a `subst` short drive for any tool work.

## 12. Hard boundaries kept
Offline analysis/builds only; nothing flashed. v2.36 resources were decoded
and rebuilt using the owner's supplied reference updater, with no key material
logged or saved separately. The resulting resource-only candidate is not yet
accepted by NSP or tested on hardware. No SSH access or device security
settings were changed. Standard tools were used for interoperability analysis.

## 13. Immediate next steps
1. Use the rebuilt `build-arm/ic7dash-arm-bundle.tar.gz` for the on-dash test.
2. Set the final `emtron_can.json` offsets if any need confirming; confirm the
   0x3EB speed scale on the road.
3. Seed `tiles/` for your actual routes (`deploy/seed-tiles.ps1`).
4. Reversible on-dash test (§10) → then, only if recovery is confirmed, flash.
```
