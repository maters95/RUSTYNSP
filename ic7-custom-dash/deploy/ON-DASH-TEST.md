# Scratch-running ic7dash on the dash — WITHOUT flashing (untested on hardware)

This procedure runs the standalone app from scratch storage using the
SCRATCH-TEST bundle. It is **not firmware**, not a flash image and not an
NSP package, and it has **never been run on a real iC-7**. Everything below
has only been exercised under QEMU user-mode emulation on a Linux build host.
The stock firmware and the stock/NSP workflow are unchanged by it.

Do not attempt permanent installation. Update packaging and recovery are
still unverified (see `DEPLOY.md`).

## Scope of the bundle
- `dist-scratch/ic7dash-scratch-test-<date>.tar.gz`, built by
  `deploy/bundle-scratch-test.sh`. Top level: `SCRATCH-TEST-NOT-FIRMWARE.txt`
  and `ic7dash-scratch/` (binary, `emtron_can.json`, `bg.gif`, optional
  `bg.mp4`, `tiles/`, `run-scratch.sh`, `PROVENANCE.txt`, `SHA256SUMS`).
- `run-scratch.sh` never installs anything, never starts/stops services, never
  remounts filesystems and never configures CAN/network interfaces. It writes
  only the app's `tilecache/` inside its own folder and
  `/tmp/ic7dash-scratch/` (logs, screenshots, redirected HOME/XDG caches).
  This write scope was checked on the build host under QEMU.
- Left out on purpose because they change system state: `bringup-can.sh`
  (`ip link set`), `ic7-mode.sh` (systemctl), `ic7-overlay.service`.

## Prerequisites (confirm on YOUR unit first)
1. **Vendor-supported shell access.** The owner's unit is currently reachable
   only through NSP over USB, which is not an app-upload shell. Rootfs evidence
   of Dropbear does not mean SSH is enabled. If you do not already have
   vendor-authorized shell access, stop here; do not bypass access controls.
2. A way to copy the archive to writable scratch storage (`/tmp`, or a USB
   stick mount) — confirm the mount and free space first.
3. Expected on the target (present in the stock rootfs image; not confirmed on
   a running unit): ARMv7 hard-float Linux with glibc ≥ 2.4 symbol versions,
   Qt 5.9.x Core/Gui/Network/Qml/Quick/QuickControls2/Positioning/Location
   (osm)/Multimedia + GStreamer 1.x mediaservice, the `gif` imageformat plugin,
   and the `offscreen` (selftest) and `eglfs` (on-screen) platform plugins.

## Steps
```sh
# 1. Copy the archive to the dash's scratch area and extract it there.
mkdir -p /tmp/ic7scratch && cd /tmp/ic7scratch
tar xzf ic7dash-scratch-test-<date>.tar.gz
cd ic7dash-scratch
sha256sum -c SHA256SUMS

# 2. Headless self-test: offscreen platform, draws nothing, leaves the stock UI
#    alone, exits by itself (~1 min per mode on a PC under QEMU; unknown on the
#    dash). Runs map, gif and video (if bg.mp4 is present).
./run-scratch.sh selftest
#    -> per-mode "OK"/"PROBLEM", logs + PNGs in /tmp/ic7dash-scratch/
#    Look for: "qml: ic7bg: gif ready", "qml: ic7bg: video playing",
#    "tileserver: 200 /z/x/y.png", and no "qrc:/qml/..." error lines.

# 3. Optional interactive run (offscreen unless you choose otherwise):
./run-scratch.sh map        # or gif / video; Ctrl-C to quit
```

An **on-screen** run needs `QT_QPA_PLATFORM=eglfs` and a free display. eglfs
allows one display owner, so the stock UI would have to be stopped first
(earlier notes used `systemctl stop watchdog-launcher gui-launcher`). That step
changes running services until reboot, is **not** part of the scratch bundle,
and has never been tested on the owner's unit — stopping the display/watchdog
services or starting an incompatible Qt app may leave the screen unusable until
a power cycle. Only do it with vendor guidance.

CAN is simulated unless you export `IC7_CAN=can0` for an interface that is
already up; the app only reads it. The bundle will not bring the bus up.

## Remove
```sh
rm -rf /tmp/ic7scratch /tmp/ic7dash-scratch
```
Nothing else is created.

## If something's off
- **Missing Qt plugin / module errors** in the selftest log: the target's Qt
  differs from the extracted sysroot — report the exact error; nothing was
  changed on the dash.
- **`ic7bg: video error ...`** or no `video playing`: the GStreamer stack or
  codec on the target differs from the sysroot; GIF and map modes still work.
- **No CAN data**: expected unless `can0` is up and `IC7_CAN=can0` is set.

## What remains unverified
Real display/eglfs integration and orientation (QEMU captures are vertically
flipped), i.MX6 VPU vs software decode and video performance, GIF/map
performance, real CAN input, GPS, coexistence with the stock dash application,
watchdog and NSP.
