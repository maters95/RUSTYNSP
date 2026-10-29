# Deploying the overlay dash to the iC-7 (Route B)

Keeps Haltech's stock firmware as the NSP-facing layer and adds the custom
maps/laps/clock app beside it. NSP stays 100% native. Your hardware, personal
use. **Nothing here is done remotely by the assistant** — these are the steps
you run on the bench. Read the whole file before touching the dash.

## Why "mode switch" and not a true overlay
The dash renders with Qt **eglfs**, where only one process can own the display
at a time. So you don't literally layer on top of the running Haltech UI — you
switch which app owns the screen:
- **stock mode** = Haltech `dash_application` (use this for NSP: config, screen
  design, firmware updates, and normal driving warnings).
- **overlay mode** = your `ic7dash` (maps / lap timing / clock).
`deploy/ic7-mode.sh` flips between them via systemd; `ic7-overlay.service`
declares `Conflicts=gui-launcher.service` so they can never both run.
Trigger the switch from a steering/dash button wired to a GPIO or a CAN message,
or over SSH while developing.

> Advanced (validate on bench): run `ic7dash` as the permanent screen owner and
> start the stock `dash_application` with `QT_QPA_PLATFORM=offscreen` so it keeps
> servicing NSP over USB with no display. Only pursue this once the simple mode
> switch works and you've confirmed the stock app tolerates offscreen.

## 1. Cross-build for the dash (ARM, Qt 5.9)
The dash is armv7 (Cortex-A9), Boot2Qt 2.2.4, Qt 5.9.6. Build with the matching
Boot2Qt / Yocto SDK so your binary links against the same Qt:
1. Get the Variscite VAR-SOM-MX6 Boot2Qt 2.2.x SDK (or build the SDK from the
   Yocto BSP: `bitbake meta-toolchain-qt5`). This gives an `environment-setup-*`
   script with the cross `g++`, sysroot and `qmake`.
2. `source environment-setup-cortexa9hf-neon-poky-linux-gnueabi`
3. From the project root:
   ```
   mkdir build-arm && cd build-arm
   cmake -DCMAKE_TOOLCHAIN_FILE=$OECORE_NATIVE_SYSROOT/usr/share/cmake/OEToolchainConfig.cmake ..
   cmake --build .
   ```
   You get an armv7 `ic7dash`. `CMakeLists.txt` already enables SocketCAN on Linux
   and links Positioning + Location.
4. GPS: a USB NMEA receiver works through QtPositioning's **serialnmea** plugin;
   the service sets `QT_NMEA_SERIAL_PORT=/dev/ttyUSB0` and `IC7_SIM_GPS=0`.
   Change the serial device for your receiver. Without `IC7_SIM_GPS=0`, the app
   uses its simulated route for desktop demos. Confirm the plugin is in your Qt
   build (`qml/QtPositioning` was present in the dash rootfs).
5. Offline maps: the bundle's current 294 tiles are only a test area. Seed an
   offline tile tree for the area you plan to drive and bundle it with the app
   (see app README); GPS can move the marker, but areas without tiles remain
   blank. The car has no internet.

## 2. Stage it on a COPY of the rootfs first (no dash yet)
Work on the extracted Haltech rootfs, never the live dash:
```
/opt/applications/ic7overlay/ic7dash          # your binary
/opt/applications/ic7overlay/bringup-can.sh    # deploy/bringup-can.sh (chmod +x)
/opt/applications/ic7overlay/emtron_can.json   # resources/emtron_can.json, offsets set
/usr/bin/ic7-mode                               # deploy/ic7-mode.sh (chmod +x)
/etc/systemd/system/ic7-overlay.service         # deploy/ic7-overlay.service
```
Do NOT `systemctl enable ic7-overlay` — leave stock mode as boot default so a bad
overlay never costs you the NSP-managed dash. Switch on demand with `ic7-mode`.

## 3. Firmware installation is not ready
No modified rootfs image or Haltech-format `.swu` has been produced or tested.
The presence of an A/B layout and an unencrypted migration `.swu` does not prove
that a hand-built update will be accepted, boot, preserve NSP, or be recoverable.
Do not write a rootfs tar directly to either partition. This document is not a
flash procedure; installation needs a verified vendor-compatible packaging
path and a recovery method demonstrated on the exact unit.

## 4. Recovery (DO THIS BEFORE FLASHING)
- i.MX6 boot ROM has USB **Serial Download** mode. With Variscite's recovery SD
  image + NXP `uuu`/`imx_usb`, a bad eMMC is re-flashable over USB — so this is
  "reflash", not "brick" — *if* you can enter download mode. Verify the
  boot-mode strap/recovery button on your carrier works before you need it.
- Keep a full `dd` image of the good eMMC if you can get a root shell.
- Leave the STM32 I/O firmware (`dash_stm`) untouched — it drives real outputs
  and is the risky half; irrelevant to a display project.
- Confirm whether i.MX6 **HAB secure boot** is fuse-enforced (`hab_status` at a
  U-Boot console). The update path isn't signature-checked, but confirm before
  trusting any modified boot chain.

## Status (2026-10-27)
The current deliverable is a **SCRATCH-TEST bundle**, not an installation:
`dist-scratch/ic7dash-scratch-test-<date>.tar.gz`, built by
`deploy/bundle-scratch-test.sh`. It runs from any scratch folder (e.g. `/tmp`)
and is removed with `rm -rf`. The stock firmware and the stock/NSP workflow are
unchanged; nothing in sections 2–4 above was performed.

Prerequisites, as built and tested:
- Build host: the `ic7build` WSL distro (Ubuntu 22.04) with
  `g++-11-arm-linux-gnueabihf`, Qt 5.9.9 host `moc`/`rcc` (aqtinstall, qtbase
  only), and the stock rootfs's Qt 5.9.6 / glibc 2.24 headers+libs as sysroot.
  `deploy/wsl-build.sh` drives this; the stripped binary is ~112 KB, links
  libstdc++/libgcc statically and needs no glibc symbol newer than GLIBC_2.4.
- Test host extras: `qemu-user` (qemu-arm), `ffmpeg` (fixtures), and for the
  NSP image suite `python3-pil` plus `usr/bin/qmltestrunner` in the sysroot.
- Expected on the target (present in the stock rootfs image, never confirmed on
  a running unit): Qt 5.9.x Core/Gui/Network/Qml/Quick/QuickControls2/
  Positioning/Location (osm geoservice)/Multimedia with the GStreamer 1.x
  mediaservice plugin, the `gif` imageformat plugin, and the `offscreen` and
  `eglfs` platform plugins.

What was verified, only under QEMU user-mode with the offscreen platform:
the app starts, loads all QML without errors, loads the 7-frame CAN map,
renders the map from bundled tiles via the loopback tile server (no online
provider), loads and animates a multi-frame GIF, and plays H.264 MP4 (a small
fixture and the supplied 1080p file) through the stock GStreamer stack in
software. `deploy/qemu-smoke-test.sh` reproduces this.

Unverified: anything on real iC-7 hardware — eglfs/display integration and
orientation (QEMU captures are vertically flipped), i.MX6 VPU decode and video
performance, real CAN input, GPS, behaviour alongside the stock dash
application/watchdog, and NSP coexistence.

This remains a standalone app test bundle, not custom firmware: no
modified rootfs or flashable `.swu` has been built, no on-dash test has run, and
the unit is reachable only through NSP USB rather than the SSH method described
for scratch testing. Recovery access is unverified. Do not flash; obtain an
official app-deployment and recovery procedure for this exact dash first.

Separately, the resource-only `.nex` candidate adds GIF/MP4 rendering to stock
image components; the offline moving map is in this standalone app. The `.nex`
is experimental and is not a sideloaded application or complete firmware.
