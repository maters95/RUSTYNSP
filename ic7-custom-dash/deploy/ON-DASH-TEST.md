# Scratch-running ic7dash on the dash — WITHOUT flashing (untested)

This procedure is intended to run the app from writable scratch storage without
installing firmware. It has **not** been verified on the owner's unit. Stopping
the display/watchdog services or launching an incompatible Qt app can leave the
screen unavailable until a power cycle; do not treat this as zero risk.

Do not attempt permanent installation. The update packaging and recovery route
are still unverified.

## Why this is safe
- The commands below target `/mnt/usb` scratch and do not intentionally write
  firmware partitions. Verify the mount and service names on the exact unit
  before running anything.
- A power cycle is expected to return to stock only if the stock boot path and
  watchdog behave as documented; this has not been tested on the owner's unit.
- The app only owns the screen and reads CAN/GPS; its only writes are map tiles
  cache under `/mnt/usb`.

## Prerequisites (confirm on YOUR unit first)
1. **An ARM build of ic7dash** — cross-compiled per `CROSS-BUILD.md` on a Linux
   box. (It could not be built on the Windows analysis PC; that's expected.)
2. **An officially supported shell on the dash.** Rootfs evidence of Dropbear
  does not mean SSH is enabled. The owner's unit is currently accessible only
  through NSP USB; that is not an app-upload shell. If you do not already have
  vendor-authorized shell access, stop and ask Haltech/Ingenuity for the
  supported development path. Do not attempt to bypass access controls.
3. **Network to the dash** — e.g. its Wi-Fi or Ethernet. Confirm the officially
  supported shell works before preparing to run the app.
4. The other NSP session isn't actively using the dash while you test.

## Steps
```sh
# 1. Only after vendor-supported shell access is confirmed, copy the app bundle
#    from your Linux build box to the dash's scratch area.
#    (replace dash-ip / user with yours)
scp -r build-arm/ic7dash emtron_can.json tiles deploy/bringup-can.sh \
    root@dash-ip:/mnt/usb/ic7test/

# 2. SSH in
ssh root@dash-ip

# 3. On the dash: stop the stock UI + its watchdog so they release the screen.
systemctl stop watchdog-launcher gui-launcher

# 4. Run the app on the framebuffer. CAN is optional — if can0 isn't up the app
#    falls back to a simulated feed, so the UI still comes up.
cd /mnt/usb/ic7test
chmod +x ic7dash bringup-can.sh
./bringup-can.sh can0 1000000        # optional: only if you've wired CAN
QT_QPA_PLATFORM=eglfs \
QT_NMEA_SERIAL_PORT=/dev/ttyUSB0 \
IC7_CAN=can0 \
./ic7dash
# -> you should see the gauges page; swipe/second screen shows the map + laps.

# 5. Stop and restore the stock dash:
#    Ctrl-C to quit the app, then:
systemctl start gui-launcher watchdog-launcher
#    (or just power-cycle the dash — nothing was changed.)
```

## If something's off (all harmless)
- **App errors on eglfs** (`Failed to create...`): the board may need a specific
  integration. Check what the stock app used: `systemctl cat gui-launcher` and
  match its `QT_QPA_*` environment, then re-run step 4 with those.
- **Screen stays black / app exits**: read the error it printed; missing Qt
  plugins mean the ARM build can't find them — fix on the build side,
  re-copy, retry. Firmware is still untouched.
- **Watchdog reboots the dash** when you stop gui-launcher: harmless — it boots
  the stock firmware. If it's disruptive, stop `watchdog-launcher` first (step 3
  already does).
- **No CAN data**: expected if `can0` isn't wired/up — the app shows the
  simulated feed. Wire CAN and re-run to see live values.

## What this proves
That the app actually runs on *your* hardware, with your Qt/eglfs, and reads your
CAN — before any firmware change. Once this is solid, `DEPLOY.md` covers making
it permanent safely (flash the PASSIVE partition, keep the good one, verify i.MX6
USB recovery first). Leave the STM32 I/O firmware alone throughout.
```
