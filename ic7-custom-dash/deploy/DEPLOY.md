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
   the service sets `QT_NMEA_SERIAL_PORT=/dev/ttyUSB0`. Confirm the plugin is in
   your Qt build (`qml/QtPositioning` was present in the dash rootfs).
5. Offline maps: bundle an MBTiles/offline tile tree and point the `osm` plugin
   at it (see app README) — the car has no internet.

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

## Status
The app has now been freshly cross-compiled against the extracted Qt 5.9.6
sysroot and ARM hard-float toolchain in an isolated temporary tree. It starts
under QEMU and produces nonblank page captures; the offscreen captures are
vertically flipped, so they do not verify physical display orientation. The
reproducible app/test bundle is linked from the repository README.

This remains a standalone app test bundle, not a complete custom firmware: no
modified rootfs or flashable `.swu` has been built, no on-dash test has run, and
the unit is reachable only through NSP USB rather than the SSH method described
for scratch testing. Recovery access is unverified. Do not flash; obtain an
official app-deployment and recovery procedure for this exact dash first.
