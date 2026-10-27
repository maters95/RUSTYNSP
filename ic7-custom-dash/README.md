# iC-7 Custom Dash — proof of concept

A standalone Qt/QML dash you fully own: live engine gauges, a map, GPS lap
timing, and a clock. It runs on a PC with simulated data (no hardware needed),
then targets the iC-7's SoM (Variscite VAR-SOM-MX6, i.MX6) or any Linux board.

> Status (2026-10-26): **rebuilt for Linux desktop and ARMv7 hard-float**.
> Both builds ran the screenshot workflow, including ARM under QEMU with the
> stock Qt 5.9.6 runtime. Bundle: `build-arm/ic7dash-arm-bundle.tar.gz`.
> Not tested on physical hardware or flashed. See [build results](../README.md)
> for reproducible commands and emulation limitations. Set IC7_SHOT=<dir>
> to grab page PNGs and exit.

## What's inside
```
CMakeLists.txt            build (Qt5 or Qt6; SocketCAN auto-enabled on Linux)
src/
  main.cpp                wires channels + decoder + CAN source + lap timer, loads QML
  channelmodel.*          live channels exposed to QML as `channels.NAME`
  emtrondecoder.*         table-driven CAN decode (layout from JSON, no recompile)
  cansource.*             SimulatedCanSource (PC) + SocketCanSource (Linux/dash)
  laptimer.*              GPS finish-line crossing -> lap/last/best times
resources/emtron_can.json the CAN frame/signal map — EDIT THIS to match your ECU
qml/                      Main, GaugesPage, TrackPage (map+laps), Gauge, Clock
```

## Build & run on a PC (simulated data)
1. Install Qt (5.15 or 6.x) with **Qt Quick, Positioning, Location** modules, plus
   CMake and a compiler. Easiest: open the folder in **Qt Creator** and press Run.
2. CLI alternative:
   ```bash
   cmake -S . -B build -DCMAKE_PREFIX_PATH=/path/to/Qt/<ver>/<kit>
   cmake --build build
   ./build/ic7dash
   ```
3. You should see gauges sweeping (simulated feed) on page 1, and a map with a
   car driving a loop and lap times ticking on page 2 (swipe between pages).
   - The map needs internet for OpenStreetMap tiles on a PC. No net = blank map,
     everything else still works.

## Point it at real CAN
- **Linux PC with a USB-CAN adapter**, or the dash itself:
  ```bash
  sudo ip link set can0 type can bitrate 1000000
  sudo ip link set up can0
  IC7_CAN=can0 ./ic7dash
  ```
- **Decode map:** `resources/emtron_can.json` now holds all 23 signals copied from
  your NSP Generic CAN setup (0x3E8–0x3EB, 0x3F2–0x3F4; 16-bit LE unsigned, same
  multipliers/offsets/units as NSP). The simulator emits the same layout. Only
  `VEHICLE_SPEED` ×0.1 is still unconfirmed on the road. The file is read at
  startup, so edits need no rebuild (copy it next to the exe to override the
  bundled one).

## Lap timing & clock in the car
- Lap timing wants a real GPS (USB/serial u-blox is simplest). In `TrackPage.qml`
  set `useSimulatedGps: false`; QML's `PositionSource` then feeds `lapTimer`.
  Capture your finish line once by driving across it and recording the two posts,
  then pass them to `lapTimer.setFinishLine(...)`.
- The i.MX6 likely has no battery-backed RTC, so system time resets at power-off.
  Feed the clock from **GPS time** or a **CAN time channel** and bind `Clock.epochMs`
  to it (set `_external: true`). GPS also gives date.

## Nav-screen background: map, GIF, or looping video
The second screen's background is selectable with the `IC7_BG` env var:
- `IC7_BG=map` (default) — the offline moving map below.
- `IC7_BG=gif` — plays `bg.gif` (next to the binary) full-screen, e.g. an
  Android-Auto-style animated backdrop. Any animated GIF works.
- `IC7_BG=video` — loops `bg.mp4` (next to the binary) via QtMultimedia (muted).
  The dash image ships GStreamer, so hardware-friendly H.264 is the safe choice.
In every mode the lap-timing panel and clock stay on top, and GPS lap timing
keeps running. Drop your own `bg.gif` / `bg.mp4` beside `ic7dash`. (The bundled
`bg.gif` is a bright placeholder — replace it with yours.)

The stock-resource `HalImage.qml` candidate also supports muted looping MP4.
Its QML tests generate a small H.264 fixture with `ffmpeg`:

```sh
bash scripts/test-nsp-image.sh
IC7_SYSROOT="$HOME/ic7build/sysroot" bash scripts/test-nsp-image.sh
```

The supplied 1080p H.264 MP4 passed the target Qt 5.9.6 test under QEMU. This
validates software decoding, not i.MX6 hardware performance or the physical
screen.

## Maps — offline, built in
The app ships a tiny loopback tile server (`src/tileserver.cpp`) that serves
`tiles/<z>/<x>/<y>.png` from next to the binary, and the map reads from it over
`http://127.0.0.1` — so maps work with **no internet and no TLS**. Seed tiles for
your area with `deploy/seed-tiles.ps1`, put them in `tiles/` next to the exe, and
run. (Verified on desktop with ESRI street tiles; see the page-2 screenshot.)
If `tiles/` is empty the map falls back to online OSM.

## Getting it onto the dash (when you're ready — separate step)
This repo is just the app. Flashing is deliberate and done by you, not here.
Before the first flash, see `ic7-custom-firmware-feasibility.md`:
- **Route A** — build a Variscite VAR-SOM-MX6 Boot2Qt image and run this app on it.
- **Route B** — drop this app into Haltech's unencrypted reference rootfs and run
  it from `gui-launcher.service` (personal use on your own device).
- Have i.MX6 USB recovery working first; flash the passive A/B partition and
  boot-test before overwriting the good one; leave the STM32 I/O firmware alone.
- Confirm whether i.MX6 HAB secure boot is fuse-enforced on your unit before
  relying on a modified boot chain.
```
