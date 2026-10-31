# GPS map, lap timing and clock: three hardware routes compared

Research report, 2026-10-31. It builds on [`README.md`](README.md) (VRacer, the clock and
the track-map add-on) and [`../hardware-audit/REPORT.md`](../hardware-audit/REPORT.md).
Nothing here has been flashed or wired. The car: iC-7 on firmware 2.36 with the
resource-only custom firmware, an Emtron on **Third Party Generic CAN at 1 Mbit/s**, and
**one physical CAN bus**.

**Source caveat.** vracer.io, ecumaster.com, ecumaster.cz, ecumasterusa.com, manuals.plus
and sqsolutions.co.nz all fail to resolve from this session, because they are outside its
network allow-list. Every vendor claim below therefore comes from search-engine summaries
and is marked *vendor (summary)*. The Haltech claims come from the owner's install sheet,
which was read in full. The iC-7 claims come from the v2.36 ELF, the HDEF and the rootfs, as
in the earlier reports. To verify the open points, **add `vracer.io` and `www.ecumaster.com`
to the environment's network allow-list**.

## Bottom line

1. **ECUMaster GPS V2: top pick.** It is a CAN-native GPS that needs no phone and defaults
   to 1 Mbit/s. Its base ID (default 0x400) is configurable and clashes with nothing on the
   owner's bus. It goes on the existing Third Party bus as extra Generic CAN frames, and the
   Emtron is not touched. It gives the dash position (for the track-map add-on), speed,
   heading and **UTC time** (for the clock). It does **no lap timing**: the GPS only reports
   position.
2. **VRacer IC02 + VRacer app (+ Dragy): add it for track days if lap timing and delta
   matter.** It is the only option of the three that puts lap, best, predicted and delta
   times on CAN. Those numbers are computed **in the phone app** and sent over Bluetooth to
   the IC02, so they stop when the phone, the app or the Bluetooth link stops. Its frames
   (0x4F0-0x4F5) coexist with both the Emtron and the ECUMaster on the one bus.
3. **Haltech HT-011310: not suitable. It is the wrong product for this goal.** The attached
   install sheet is for the **"GPS Speed Input Module"**. It has three wires (12 V, pulse
   output, ground) and sends **speed as pulses, 5000 per km, into an SPI/DPI input**. It has
   **no CAN, no position, no time and no lap timing.** At most it is a GPS speedo/odometer
   source.

**Best combination:** the ECUMaster always fitted (map, clock, GPS speed), plus the IC02 on
track days (lap timing). Put both on the Third Party bus through Generic CAN. The Haltech
CAN bus is not needed.

## Corrections to the premises

**Correction (owner report, 2026-10-31):** the owner runs Haltech CAN and Third Party CAN together. The v2.36 definition only flags the pair (HALTECH_BUS `LegalOn`, group `aa`: `s10363s == 1`, `s16033s == 1`, no severity attribute, so NSP's default level 0 "Error"), and the dash app starts each decoder independently (`can::can_protocol::run` starts `CANProtocolEcu` when HALTECH_BUS = 1 and `CANThirdParty` when THIRD_PARTY_BUS = 1). So both run at once on the one wire. With Haltech CAN on, the native Track Modules (0x4F0-0x4F5) work alongside the Emtron's Generic CAN frames, but the Haltech broadcast decoder also reads the Emtron's 0x3E8-0x3EB and 0x3F2/0x3F3 as Haltech channels, so don't use those Haltech channels.

- **"Haltech's GPS/track module".** HT-011310 is not a track module: see above, and
  *Sources*. The NSP "Track Modules" (GPS, Lap Timer) are decoders for Haltech-protocol
  frames 0x4F0-0x4F5 on the **Haltech CAN bus**. HT-011310 sends none of those, so the
  question of it conflicting with the Emtron never arises.
- **"Haltech-protocol termination arrangement or a second bus".** Termination is two 120 Ω
  resistors at the ends of the wire. It has nothing to do with protocols. The iC-7 has
  **one FlexCAN**: the second is disabled in every DTB and the app opens only `can0`. Its
  "Haltech bus" and "Third Party bus" are **decoders on the same wire**, and NSP allows only
  one of them ("Only one dash data protocol can be enabled at a time"). A second bus is
  impossible without app and device-tree changes.
- **"The iC-7 cannot show map tiles natively".** That is true of the stock gauges, but there
  is a new finding: the dash rootfs ships **QtLocation 5.9.6 with the `osm` geoservices
  plugin**, and that plugin supports **`osm.mapping.offline.directory`**. A test run under
  QEMU with the dash's own Qt libraries (a QML `Map`, no network, no tile server) **opened
  tiles named `osm_100-l-1-<z>-<x>-<y>.png` from the offline directory**. A QML add-on in the
  resource NEX could therefore show real map tiles, without the old native app's loopback
  server. Still unproven:
  - actual rendering on the i.MX6, because offscreen grabs are black under QEMU;
  - memory and GPU cost;
  - NEX size, at a few MB per track area;
  - tile licensing: the repo's `tiles/` are Esri tiles marked "do not redistribute".

  This is a Tier 0 experiment, not a feature yet. Without it, the track-outline add-on
  (`Ic7TrackMap.qml`) is the map.
- **The "Android Auto Screen (phone).mp4" and `nsp_src/Documents/Haltech/Icons/aa/*.html`**
  are **mock-ups styled like Android Auto**: 860x480 pages made as iC-7 backgrounds, with
  Grafton NSW streets and "CR-V Type R". They are not evidence of a working Android Auto
  app showing Emtron data. **The repo does not identify the head unit.**
- **Android Auto runs no arbitrary apps.** It projects phone apps from approved categories:
  navigation, media, messaging and a few others. Search found no lap timer (RaceChrono,
  Harry's, VRacer) with Android Auto projection. The only DIY route uses developer mode,
  which Google is restricting. **Lap timing belongs on the iC-7, not on the head unit.**

## Comparison

| | ECUMaster GPS V2 | VRacer IC02 + app (+ Dragy) | Haltech HT-011310 |
|---|---|---|---|
| What it is | GNSS (+IMU) to CAN module | Bluetooth-to-CAN bridge for a phone app | GPS-to-speed-pulse converter |
| Output | CAN 11-bit, big-endian; base ID default **0x400**, configurable (multiple of 8), ID+1… for further frames *vendor (summary)* | CAN; for Haltech dashes the frames **0x4F0-0x4F5** (layout in `README.md`); custom CAN TX in the app *vendor (summary)* | **Pulses** on one wire, 0-12 V, 5000/km (83 Hz at 60 km/h) |
| Bitrate | 1 Mbit/s default (also 500/250/125 k) *vendor (summary)* | up to 1 Mbit/s *vendor (summary)* | n/a |
| Rate | 20-25 Hz (sources disagree; 10 Hz GPS-only on V1) *vendor (summary)* | CAN 25 Hz; positions from phone GPS (about 1 Hz) or an external 10 Hz receiver *vendor (summary)* | continuous pulse train |
| Position | lat/long s32 ×1e-7 deg | lat/long (0x4F4) | **no** |
| Heading | **yes** (motion and vehicle, 0-360°) *vendor (summary)* | not in 0x4F0-0x4F5 | no |
| UTC time | **yes**; frame and format depend on the firmware revision *vendor (summary)* | not in 0x4F0-0x4F5; phone time via custom TX is **unverified** | no |
| Lap/sector timing on the device | **no** | yes, **in the phone app**: lap, last, best, predicted, delta (sectors in the app only) | no |
| Needs a phone | **no** | **yes**, with the app running and connected over Bluetooth | no |
| On the owner's bus | Generic CAN on Third Party; 0x400-0x407 clashes with neither the Emtron (0x3E8-0x3EB, 0x3F2-0x3F4) nor the IC02 | Generic CAN on Third Party (Option B); no clash | not CAN; uses a dash DPI input (`Sensors > Vehicle Speed`, GPS pulses/km) |
| Termination | DT version: none; AS version: optional (bridge pins 3-4). **Leave it off.** | switchable 120 Ω. **Leave it off.** | n/a |
| What the iC-7 shows | lat/long/speed/heading/sats as Generic CAN channels, the track-outline add-on, the **clock** (add-on), no lap times | lap/last/best/predicted/delta/laps/session as Generic CAN channels (stock Numerics, delta bars), the track-outline add-on | vehicle speed and odometer only |
| Android Auto | no (CAN only) | no; the VRacer app does not project. The phone could run OsmAnd on Android Auto separately | no |
| Effort | PC + USB-to-CAN adapter to configure once; about 10 NSP signals | about 14 NSP signals; app setup and a phone every session; ask VRacer for the layout | trivial, but it doesn't meet the goal |
| Cost | not stated by any source reached | not stated by any source reached | not stated |

## Per option

### 1. ECUMaster GPS V2

- **Frames.** The search summaries agree on the following:
  - an "Ecumaster output" at **base 0x400**, configurable as a multiple of 8;
  - **lat/long in the base frame** (s32, ×1e-7°, big-endian, bytes 0-3 / 4-7);
  - speed, height, satellites, status, **heading** (u16, 0-360°) and **UTC date/time** in
    ID+1…ID+4.

  They **disagree** on which frame holds heading and UTC between manual revisions:
  `gpsV2Manual.pdf` (firmware 1.x) against `gps2Manual.pdf` (document 3.3, firmware 2.0+).
  **Use the manual that matches the unit's firmware** and fill in the table under "Top-pick
  configuration".
- **Config:** ECUMaster Light Client on a PC, through a USB-to-CAN interface. It sets the
  bitrate, enables the outputs and sets the base ID.
- **Fit on the bus.** It runs at 1 Mbit/s like the Emtron. 0x400-0x407 is free. Four or five
  frames at 20 Hz add about 1 % bus load. Disable any output format or IMU frames you don't
  decode.
- **On the iC-7:**
  - Generic CAN signals → Numerics, plus `Ic7TrackMap.qml` (outline or learned path, car
    dot). Heading is a bonus: the map currently infers direction from the path.
  - **No lap timing natively.** A QML lap-timer add-on could compute it from lat/long by
    porting the start/finish-line logic of `src/laptimer.cpp`, but that has **not been
    written**.
  - The dash only receives values; it cannot write them back to CAN for NSP alarms.
- **Precision.** Generic CAN does `raw × multiplier + offset` in **float32**. A latitude of
  about 3.4e8 raw units keeps a resolution of about 32 units, about 0.35 m. That is fine for
  a map. A frame unheard for 2 s reads "Device Time Out", which the map treats as no fix.

### 2. VRacer IC02 + app (+ Dragy)

- **Frames:** as already decoded from the shared map (`README.md` §2):
  - 0x4F0 current/last lap;
  - 0x4F1 best/predicted;
  - 0x4F2 laps, delta (s16 ms), session;
  - 0x4F3 speed, satellites, accuracies;
  - 0x4F4 lat/long;
  - 0x4F5 altitude.

  All are big-endian. There is no heading and no UTC. Whether VRacer can also send a
  time-of-day frame through "IC02 CAN transmit features" is **unverified**.
- **Phone dependence.** Lap timing, prediction and delta are computed in the app. Vendor
  (summary): two GPS modes, the phone's own GPS or an external receiver (XGPS150/160 named),
  at up to 10 Hz. **Dragy support was not confirmed by any source reached.** Check it on
  vracer.io/devices.
- **On the iC-7 (Option B):** add 0x4F0-0x4F5 as Third Party Generic CAN receive frames
  (layout in `README.md`). The Emtron is untouched and nothing clashes.
  - Lap-time signals: unit "Time - formatted" (ms).
  - Delta: s16, ±10 000 ms, on a bar plus a Numeric. Add-on A2 can flash it on sign.
  - Lat/long: feed the track-map add-on.
  - Leave the IC02's 120 Ω **off**.
- **Option A** (Haltech CAN bus + native Track Modules, as in the shared map) works, but it
  means moving the Emtron to Haltech Generic CAN and re-pointing every gauge. Emtron
  0x3E8-0x3EB and 0x3F2/0x3F3 collide with Haltech broadcast IDs. **Not worth it.**

### 3. Haltech HT-011310 GPS Speed Input Module

- **Install sheet (HT-011310 Rev 3):**
  - "Converts GPS Speed signal to a pulsed digital output (0-12v). Default output is 5000
    pulses per kilometre";
  - pins: 1 Red +12 V switched, 2 Green "Signal Output … connect to spare SPI / DPI",
    3 Black ground;
  - NSP setup: Sensors > Vehicle Speed, Main Source = GPS, Edge Falling, Hall Effect,
    pull-up off, 5000 pulses/km;
  - status LED and a calibration button.
- **It does not use CAN**, so it doesn't need the Haltech CAN bus and cannot conflict with
  the Emtron. It also cannot feed `CanGPS`/`CanLapTimer`, a map, a clock or lap timing. The
  iC-7 HDEF does have `GPS_STORED_RATE` under Sensors > Vehicle Speed > Calibration, so the
  dash can take it on a DPI as a speed/odometer source. That is its only use here.
- No Haltech CAN GPS or lap-timer product that sends 0x4F0-0x4F5 was found. The native
  decoders exist, but **the hardware Haltech sells under that name is not this module.**

## Android Auto: a moving offline map and lap timing

- **None of the three feeds the head unit.** Android Auto shows phone apps.
- **A moving offline map:** **OsmAnd** states Android Auto support and fully offline maps.
  Google Maps offline areas also work on Android Auto. Both use the **phone's location**.
  Using an external Bluetooth GPS needs a mock-location app (for example "Bluetooth GPS"),
  and whether Android Auto honours a mock provider is **unverified**. Neither the ECUMaster
  (CAN only) nor the Dragy (proprietary) is a plain NMEA Bluetooth source.
- **Lap timing on Android Auto:** no evidence that any of RaceChrono, Harry's LapTimer or
  VRacer projects. RaceChrono supports external GPS receivers on the phone. Treat lap timing
  on the head unit as **not available**, and show it on the iC-7.
- A practical split: the phone runs OsmAnd on Android Auto for the map; the iC-7 shows lap
  timing (via the IC02) and the track outline. A phone running VRacer in the background
  while projecting OsmAnd may work, but it is untested.

## Clock (time of day)

| Option | Time source | Into Generic CAN "Time - formatted" | Time zone |
|---|---|---|---|
| ECUMaster | GNSS **UTC** | Works **if** the firmware sends time of day as one field (seconds or ms since midnight): unit `Time (s) - formatted` or `Time - formatted` (ms). If it sends **separate H, M, S bytes**, Generic CAN can't combine them (one field per signal, linear scale only), so `Ic7Clock.qml` would need a small three-channel extension (**not written**). | Do **not** use the Generic CAN `offset`: the native formatter doesn't wrap at 24 h (it shows 34:15). Use `ic7_clock.json` `offsetMinutes` (Grafton NSW: 600 AEST, 660 AEDT, changed by hand at DST). |
| VRacer IC02 | phone local time, **if** custom TX can send it | as above, as one field of seconds since midnight | none needed (local time); only while the phone is connected |
| HT-011310 | none | — | — |

**Only the ECUMaster gives a reliable, phone-free clock.** The dash itself has no
real-time source (README §1).

## Why the old native app (`src/tileserver.*`, `nmeagpssource.*`, `laptimer.*`, `qml/TrackPage.qml`, `tiles/`) can't be deployed

1. **It is a different program.** It is a C++ Qt app that **replaces `nic-7`**. The
   resource-only NEX carries only `res_ic-7.qzip` (QML and resources) and has no app stage
   (hardware audit §2.2). Replacing the app would also drop the stock CAN, alarms, LEDs and
   NSP support.
2. **The C++ parts can't be QML.** The loopback tile server needs `QTcpServer`, and the NMEA
   reader needs `QSerialPort`. Resource-NEX QML cannot open sockets or serial ports, and the
   rootfs has **no `serialnmea` positioning plugin** (only geoclue and positionpoll).
3. **The GPS input path doesn't exist.** NMEA needs a USB/serial receiver on `/dev/ttyUSB0`.
   USB host 1 may not be routed to a connector (audit §6). The supported way to get data
   into the stock app is **CAN**.
4. **What carries over:**
   - The tile server is unnecessary on Qt 5.9.6, because `osm.mapping.offline.directory`
     works (see the QEMU test above).
   - The lap-timer logic can be ported to a QML add-on fed by lat/long channels.

## Top-pick configuration: ECUMaster GPS V2 on Third Party Generic CAN

**Wiring and termination**

- Splice CAN H/L into the existing bus with short stubs (under about 30 cm, twisted).
  Connect switched +12 V and ground at the same point as the dash.
- **Add no termination.** The bus already has two: dash port 1 termination is on in the
  owner's map, plus the Emtron end.
  - DT version: has none.
  - AS version: leave pins 3-4 open.
  - IC02 (if added): switch its 120 Ω off.

  Check: with power off, CAN H to CAN L should measure about 60 Ω. About 40 Ω means a third
  terminator.
- Mount the antenna with a clear view of the sky.

**On the device (Light Client, PC + USB-to-CAN, bench, once)**

- Bitrate **1 Mbit/s**. Ecumaster output enabled, base ID **0x400**. Disable other output
  formats and the IMU frames unless they are wanted.
- Rate 20 Hz (or 10 Hz). If the firmware offers it, choose a time-of-day field in seconds or
  ms since midnight.

**NSP: Connections > CAN > Third Party CAN Bus > Generic CAN** (the Emtron frames stay as
they are)

| Frame ID | Signal | Start byte / length | Order | Signed | Multiplier | Unit | Rename to |
|---|---|---|---|---|---|---|---|
| 0x400 | latitude | 0 / 32 | Motorola (big) | yes | 1 (see note) | Latitude | GPS Lat |
| 0x400 | longitude | 4 / 32 | Motorola | yes | 1 | Longitude | GPS Lon |
| 0x401…0x404 (per manual) | speed | per manual / 16 | Motorola | no | per manual (km/h) | Speed | GPS Speed |
| per manual | heading | per manual / 16 | Motorola | no | per manual | none | GPS Heading |
| per manual | satellites, fix | per manual / 8 | — | no | 1 | none | GPS Sats |
| per manual | UTC time of day (single field only) | per manual | Motorola | no | 1 (s) or 0.001 (ms → s) | Time (s) - formatted | GPS UTC |

- Use 4-5 of the 30 frames (the owner uses 7) and about 10 of the 200 signals.
- **Note on lat/long scale:** the native Latitude unit prints raw/1e8. Bench-check the shown
  value against a known position and adjust the multiplier (for example ×10). The track-map
  add-on works in raw units, so its scale doesn't matter. Only `trackLatitude` (about −29.7
  for Grafton) sets the aspect ratio.

**Screens and add-ons**

- A Numeric on GPS Lon, sized about 300x300, as the map. A small Numeric on GPS Lat, with a
  dark font.
- `ic7_track_map.json`:

  ```json
  {"version": 1, "maps": [{"latChannel": "GPS Lat", "lonChannel": "GPS Lon",
    "mapChannel": "GPS Lon", "trackLatitude": -29.7, "learn": true}]}
  ```

- A Numeric on GPS UTC, with `ic7_clock.json`:

  ```json
  {"version": 1, "clocks": [{"channel": "GPS UTC", "offsetMinutes": 600}]}
  ```

  Use 660 during DST.
- Optionally an alarm on GPS Sats below 4.

**Adding the IC02 for track days:** frames 0x4F0-0x4F5 as in `README.md` Option B, on the
same bus, IC02 terminator off. Show the lap/delta Numerics and the delta bars from the shared
map's screen 3, re-pointed to the Generic CAN channels.

## Open points (owner)

1. Allow **vracer.io** and **www.ecumaster.com** in the session's network allow-list, then
   confirm:
   - the ECUMaster V2 frame table for the unit's firmware: heading and UTC placement, time
     format, rate;
   - the IC02 operating modes, the exact 0x4F0-0x4F5 layout, Dragy support, and whether
     custom TX can send the time of day;
   - prices.
2. Bench-check the latitude scale on the dash (see the note above).
3. Optional experiment: a QtLocation offline-tile add-on. It needs an on-dash render test and
   a tile source whose licence allows offline bundling.

## Sources

- Owner's install sheet `HT-011310_IS.pdf` (Rev 3), read in full.
- Search-engine summaries, because the pages themselves were blocked:
  - [ECUMASTER GPStoCAN V2 manual (fw 1.x)](https://www.ecumaster.com/files/devices/gps/gpsV2Manual.pdf)
  - [GPStoCAN manual 3.3 (fw 2.0+)](https://www.ecumaster.com/files/devices/gps2/gps2Manual.pdf)
  - [ECUMaster GPS to CAN with IMU V2](https://ecumasterusa.com/products/gps-to-can-with-imu-v2)
  - [xtramotorsport GPS CAN V2](https://xtramotorsport.com/product/ecumaster-gps-can-v2/)
  - [VRacer devices](https://vracer.io/devices)
  - [VRacer FAQs](https://vracer.io/faqs)
  - [VRACER IC02 (SQ Solutions)](https://sqsolutions.co.nz/products/vracer-ic02)
  - [VRacer on Google Play](https://play.google.com/store/apps/details?id=io.velocitysoft.vracer&hl=en)
  - [Pac Performance HT-011310](https://www.pacperformance.com.au/haltech-gps-input-module)
  - [OsmAnd](https://osmand.net/)
  - [RaceChrono](https://racechrono.com/)
  - [Running Lap Timer on Android Auto](https://did-it-myself.com/running-lap-timer-on-android-auto/)
  - [Android mock location](https://github.com/warren-bank/Android-Mock-Location)
- iC-7 side:
  - this folder's `README.md` and `../hardware-audit/REPORT.md`;
  - `ic7-emulator/README.md` (Generic CAN float32 and the 2 s timeout);
  - `fw/list_rootfs.txt` (QtLocation, osm plugin, no serialnmea);
  - the QEMU strace test of `libqtgeoservices_osm.so` (Qt 5.9.6) described above.
