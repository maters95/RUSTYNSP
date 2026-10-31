# iC-7 v2.36: time of day, VRacer IC02 lap timing and a GPS track map

Research report, 2026-10-30. Nothing here has been flashed or run on a dash. Evidence
is from the decrypted v2.36 app (`nic-7`, ELF sha256 `d86bde81…7248`, disassembled with
`scripts/disassemble-nsp-app.py`), the v2.36 definition `fw/ic7_2360.hdef`, the dash
root filesystem and device trees, the shared VRacer map (summary only, see
`vracer-map-summary.json`) and the owner's 2026-10-26 map. Public VRacer pages could
only be read through search-engine summaries (the sites are outside this session's
network allow-list), so every VRacer claim below is marked as vendor-stated or
unverified.

## Short answers

| Question | Answer |
|---|---|
| Does the dash know the time of day? | **No, not reliably.** Nothing on the iC-7 ever sets the clock. |
| Native time-of-day channel? | **None.** But Generic CAN signals can use the units "Time (min) - formatted" (`HH:MM`) or "Time (s) - formatted" (`HH:MM:SS`), so a time-of-day value on CAN displays natively in a Numeric gauge. |
| How does the shared map get VRacer timing? | **Haltech CAN bus** with the native **Lap Timer Module** and **GPS** "Track Modules": the IC02 sends Haltech-module frames 0x4F0-0x4F5 at 1 Mbit/s. |
| Does that work with the owner's Emtron setup? | **Not as the map does it.** The native track modules only listen on the Haltech CAN bus, NSP refuses Haltech CAN and Third Party CAN together, and the owner's Emtron is on Third Party Generic CAN. Two workable options below. |
| GPS for a map? | The native GPS decoder gives latitude, longitude, altitude, speed, satellites and accuracies, **no heading and no time**. A position map is QML-feasible with two gauges; prototyped as an add-on. |
| "Disable when engine off" alarms | **Confirmed: they cannot fire** on the owner's map. The gate needs the native RPM channel (0xE68) above 449. Only the Tacho Input, the Haltech ECU protocol and the third-party ECU protocols write it, and all three are off in that map; Generic CAN never writes it. Fix: wire and enable the dash's Tacho Input, or turn the option off. |

## 1. Clock

### What the dash has

- **RTC hardware:** the device trees boot only the i.MX6 on-chip SNVS low-power RTC
  (`snvs-rtc-lp` in every `fw/root/boot/devicetree-uImage-imx6*-var-som-*.dtb`). The
  kernel also has the DS1307, MC13xxx and MXC drivers (`CONFIG_RTC_DRV_*`), but no DTB
  has a DS1307 node. There is no evidence of a coin cell. Whether SNVS keeps time across
  power-off is unconfirmed (it needs a backup supply).
- **Nothing sets the clock:** the app imports no `settimeofday`, `clock_settime`,
  `stime` or `adjtimex`, and contains no `/dev/rtc` or `hwclock` strings. Its only
  wall-clock use is `QDateTime::currentDateTime()` for log timestamps (`myMessageHandler`,
  0x1191ac); everything else is `currentMSecsSinceEpoch()` used as a timer. The rootfs
  enables `systemd-timesyncd`, but the dash has no network (the app runs `ifconfig eth0
  down`, Wi-Fi is dead on the iC-7, see `../hardware-audit/REPORT.md`). The time zone is
  `Universal` (`/etc/timezone`, `/etc/localtime`).
- **NSP does not set it:** neither `nsp_src/` nor `nsp-rebuild/` writes a time to the
  device; the definition has no RTC, clock, time-zone or date setting.
- **The CAN sources don't carry time:** `CanGPS::handle` (0x5cd20) decodes only
  0x4F3-0x4F5 (below), with no UTC field. The Emtron layout in
  `resources/emtron_can.json` has no time signal.

So QML `new Date()` shows whatever the SNVS counter holds, in UTC. That is never set,
so it is meaningless, even if it survives power-off.

### Native formatting already exists

The Generic CAN signal unit list (`GENERIC_CAN_*_SIGNAL_UNITS`) includes
`2305 Time (s) - formatted`, `30209 Time (min) - formatted` and `2561 Time - formatted`
(ms). In the app:

- `convert_to_str_time_s_formatted` (0xba180) prints `%1:%2:%3`, as hours = v/3600,
  minutes and seconds, each zero-padded to 2 digits;
- `convert_to_str_time_h_m_formatted` (0xbb154) prints `%1:%2` (hours, minutes), with a
  `-` prefix for negative values;
- `convert_to_float_*` for both units passes the raw seconds through, so a gauge's
  `halRawValue` is seconds.

A Generic CAN signal that carries **seconds since midnight**, with unit
`Time (min) - formatted`, shows as `HH:MM` (24-hour) in a stock Numeric gauge. It needs
no firmware change. The hours don't wrap at 24, and there is no 12-hour mode or time zone.

### Options compared

| Option | Reliable? | Notes |
|---|---|---|
| QML `new Date()` | **No** | Unset clock in UTC; at best a diagnostic. |
| Time channel on CAN, native unit | **Yes, if a source exists** | 24-hour `HH:MM[:SS]`, no add-on needed. |
| Time channel on CAN plus clock add-on | **Yes, if a source exists** | Adds a fixed UTC offset, 12-hour, seconds, wrap at 24 h, and fails closed on "Device Time Out". |

**Possible sources, best first:**

1. **The VRacer app through the IC02.** The phone has the correct local time. Vendor
   pages say "CAN transmit features" and "custom CAN channels" exist; whether a time of
   day can be sent is **unverified**. Ask VRacer for a frame with seconds since
   midnight (local time).
2. **The Emtron**, if it has a time-of-day or RTC channel that can go into a CAN TX
   stream. Unverified: check in Emtron's software.
3. **A small CAN node** with GNSS (UTC, so it needs the add-on's offset) or an RTC.

**Recommendation:** use a CAN time channel. Show it natively, or with
`ic7_clock.json` for 12-hour display or an offset. GPS gives UTC: set `offsetMinutes`
by hand, because a time of day alone can't tell when DST applies. A source that already
sends local time avoids this. Use `"source": "system"` only once, to see what the dash
clock holds (it also shows the date) and whether it survives a night powered off.

### The clock add-on (prototype)

`../addons/qml/Ic7Clock.qml`, loaded by the add-on `HalNumeric.qml`. Upload
`ic7_clock.json` as a user resource, like the other add-on manifests:

```json
{"version": 1, "clocks": [
  {"channel": "VRacer Time", "offsetMinutes": 0, "hour12": true},
  {"channel": "GPS UTC Seconds", "offsetMinutes": 600, "seconds": true},
  {"channel": "Device Battery Voltage", "source": "system", "showDate": true}]}
```

- `channel`: the Numeric gauge's channel name, as shown. `source`: `channel` (default:
  raw x `scale` = seconds since midnight, any value wraps) or `system` (dash clock,
  diagnostic only).
- `offsetMinutes` -720..840, `hour12`, `seconds`; `scale` (0 to 86400, channel only, for
  example 0.001 for ms); `showDate` (system only).
- It draws in place of the stock value and unit text, with the gauge's own font, size,
  alignment and value colour, and keeps the channel label. It falls back to stock for any
  bad manifest, a non-matching channel, a Haltech status value (No I/O, Device Time Out,
  …) or a value in warning.
- Only the system clock ticks (1 Hz, while visible). A channel clock follows value
  updates. The manifest is read once per dash start, and shared by all gauges.

## 2. VRacer lap timing

### What the shared 2.35.1 map configures (decoded; summary only)

- **Bus:** Haltech CAN Bus **enabled** on CAN port 1. The Haltech bus bitrate is
  fixed at **1 Mbit/s** (`CanBusFactory::CanBusFactory` 0x56894 passes 1 000 000). The
  Third Party bus is disabled and no Generic CAN is used. The map was made for a car with
  a Haltech ECU: its gauges show native ECU channels.
- **Devices > Lap Timing: Lap Timer Module Enable = 1; Devices > GPS: GPS Enable = 1.**
  MyLaps X2 flagging is disabled. These are NSP's "CAN > Haltech CAN System > Track
  Modules".
- **Display units:** the lap-time channels use "Time - formatted" (ms) with 3 decimal
  places. Best Lap Time Delta has a ±10 000 ms range.
- **Screen 3 is the timing screen:** two horizontal continuous bars on Best Lap Time
  Delta across the top (one reversed: gain/loss), and Numerics for Best Lap Time Delta,
  Last, Best and Predicted Lap Time, Number of Laps and Session Time, around a gear
  numeric and the usual engine numerics, on a custom background. **No GPS channel is
  shown anywhere**: GPS is enabled but not displayed.

### What the dash decodes (v2.36 app)

The decoders register only when enabled, and **only on the Haltech CAN bus**:
`CanGPS::CanGPS` and `CanLapTimer::CanLapTimer` call `CanBusFactory::get(1)` (selection
1 = Haltech CAN, created only when HALTECH_BUS = 1). The frames are 11-bit, and every
value is big-endian:

| ID | Bytes | Channel |
|---|---|---|
| 0x4F0 | 0-3 / 4-7 (u32) | Current Lap Time / Last Lap Time (ms) |
| 0x4F1 | 0-3 / 4-7 (u32) | Best Lap Time / Predicted Lap Time (ms) |
| 0x4F2 | 0-1 (u16), 2-3 (s16), 4-7 (u32) | Number of Laps, Best Lap Time Delta (ms), Session Time (ms) |
| 0x4F3 | 0-1, 2-3, 4-5 (x10 000), 6-7 (u16) | GPS Speed, Satellites, Position Accuracy, Speed Accuracy |
| 0x4F4 | 0-3 / 4-7 (s32) | GPS Latitude / GPS Longitude |
| 0x4F5 | 0-3 (s32) | GPS Altitude |

Sources: `can_lap_timer::lap_timer_rx_ids` = {0x4F0,0x4F1,0x4F2} and
`can_gps::gps_rx_ids` = {0x4F3,0x4F4,0x4F5}. The byte layouts come from `CanLapTimer::handle`
(0x66a24) and `CanGPS::handle` (0x5cd20), and the channel addresses (22656-22708) from
the HDEF. A latitude/longitude channel is stored as the raw int32. The dash prints it as
raw/1e8 with 8 decimals (`convert_to_str_latitude_latitude`, 0xbad54); the IC02's
encoding is unverified, so check the shown value against a known position.

There are **no** heading, sector, UTC-time, pit-message or "position in race" fields.
"Sectors" and "pit messages" in VRacer's marketing are not native iC-7 channels.

### Push-back on the framing

- **"Only the IC02 can do this"** is true of the phone-app side (a two-way Bluetooth
  link to CAN). On the dash side, the iC-7 decodes ordinary Haltech module frames
  (0x4F0-0x4F5). Any CAN node that sends them works, and the dash cannot tell who sent
  them. The Dragy is just the phone app's GPS source.
- **The shared map is not a drop-in for the owner.** Loading it would replace the whole
  configuration, and its approach (Haltech CAN bus) conflicts with the owner's Third
  Party Generic CAN Emtron setup. Copy the relevant settings by hand. The setting IDs
  are the same in 2.36: every one of the map's settings resolves in the 2.36
  definition, and `CanGPS`/`CanLapTimer` exist in 2.36 with the IDs above.

### One FlexCAN, two "buses"

**Correction (owner report, 2026-10-31):** the owner runs Haltech CAN and Third Party CAN together. The v2.36 definition only flags the pair (HALTECH_BUS `LegalOn`, group `aa`: `s10363s == 1`, `s16033s == 1`, no severity attribute, so NSP's default level 0 "Error"), and the dash app starts each decoder independently (`can::can_protocol::run` starts `CANProtocolEcu` when HALTECH_BUS = 1 and `CANThirdParty` when THIRD_PARTY_BUS = 1). So both run at once on the one wire. With Haltech CAN on, the native Track Modules (0x4F0-0x4F5) work alongside the Emtron's Generic CAN frames, but the Haltech broadcast decoder also reads the Emtron's 0x3E8-0x3EB and 0x3F2/0x3F3 as Haltech channels, so don't use those Haltech channels.

The iC-7 has one physical CAN port, and every node shares the wire. The dash's logical
buses are just decoders on it:

- `can::can_protocol::run` (0x7333c) starts `CANThirdParty` when THIRD_PARTY_BUS = 1, and
  `CANProtocolEcu` (the Haltech broadcast decoder, reading
  `/opt/applications/dtn/resources/can_protocols/haltech-can-protocol.json`) when
  HALTECH_BUS = 1.
- NSP's definition forbids enabling both: HALTECH_BUS `LegalOn` = "Only one dash data
  protocol can be enabled at a time."
- `CanBus::register_rx` keeps a set of listeners per ID, so a colliding ID reaches every
  decoder that registered it.

**Bitrate:** Emtron 1 Mbit/s, Haltech bus fixed 1 Mbit/s, and the IC02 supports up to
1 Mbit/s (vendor). That is compatible. **IC02 vs Emtron IDs** (0x3E8-0x3EB, 0x3F2-0x3F4):
no overlap with 0x4F0-0x4F5.

### Two ways to fit the IC02 alongside the Emtron

**Option B, recommended (least disruptive; depends on VRacer):** keep Third Party
Generic CAN for the Emtron, and add the IC02's frames as extra Generic CAN receive
frames on the same bus. The table above gives a ready signal layout: big-endian,
`Time - formatted` for the lap times, signed 16-bit for the delta, and the
`Latitude`/`Longitude` units exist in the signal unit list. Owner usage is 7 of 30
frames and about 23 of 200 signals. Native lap channels stay empty. The values appear as
"Third Party Bus Generic CAN ChN", renameable in NSP. Nothing existing changes. If VRacer
can also send a time of day, the clock comes for free.

**Option A (what the shared map does):** disable Third Party CAN, enable Haltech CAN Bus
and the Lap Timer and GPS modules, and move the Emtron frames to Haltech Generic CAN.
The costs:

- every gauge and alarm that points at a "Third Party Bus Generic CAN" channel must be
  re-pointed;
- Emtron IDs 0x3E8-0x3EB, 0x3F2 and 0x3F3 collide with Haltech broadcast IDs that
  `CANProtocolEcu` then also decodes (in the v2.36 `haltech-can-protocol.json`: Generic
  Sensor 5-10, Target Lambda, the nitrous and water-injection output states, Torque
  Management Knob, Gearbox Line Pressure, Injection Stage 3/4, Crank Case Pressure, Race
  Timer, Ignition Angle Bank 1/2, and the front and rear ride-height sensors). Only
  0x3F4 is free. Those channels would show garbage, so either don't use them or move the
  Emtron IDs.

The upside: native lap and GPS channels, the stock timing-screen layout, and, if the
Emtron also sends Haltech-format 0x360 (RPM in bytes 0-1), a native RPM.

**Owner to-do, either way:** wire the IC02 to CAN H/L, ground and switched 12 V on the
same bus. Leave its 120 Ω resistor **off**: the bus already has two (the dash port 1
termination is on in the owner's map, plus the Emtron end). Set it to 1 Mbit/s. Ask
VRacer which IDs and layout it sends, whether they are configurable, and whether a
time-of-day frame is available.

## 3. GPS and a track map

- The data exists as native channels (Option A) or Generic CAN channels (Option B).
  There is no heading: the map gets direction from the path.
- **Feasible in QML, prototyped** (`../addons/qml/Ic7TrackMap.qml`). The design:
  - two Numeric gauges on the same screen, one per channel (latitude, longitude);
  - each publishes its value into `ic7addons.js`, a `.pragma library` that is one
    shared instance per QML engine (this needs no `main.qml` change, unlike the
    screen-marker trick);
  - the gauge named by `mapChannel` hides its stock text and draws the map.
- **Track outline:** an `outline` of [lat, lon] points in raw channel units in the
  manifest, and/or `learn` (the default), which records the driven path. A learned path
  is lost at power-off, because QML cannot write files.
- **i.MX6 cost:**
  - the car marker is a Rectangle moved at 5 Hz;
  - the Canvas repaints at most once a second and only while the path or view changes:
    at most 1 500 learned and 2 000 outline segments, then no repaints at all;
  - a float32 `halRawValue` costs about 1 m of precision at 1e-7 degree units;
  - positions stay in raw units with one aspect correction (`trackLatitude`), so the
    unknown scale doesn't matter.
- Loss of GPS arrives as a Haltech status value (for example Device Time Out), which
  hides the marker. The dash only delivers changed values, so the map applies no age
  limit (a parked car stays drawn).

```json
{"version": 1, "maps": [
  {"latChannel": "GPS Latitude", "lonChannel": "GPS Longitude", "mapChannel": "GPS Longitude",
   "trackLatitude": -33.9, "learn": true, "colour": "#FFFFFF", "carColour": "#FF3030", "lineWidth": 3}]}
```

Make the map gauge large (for example 300x300) and the latitude gauge small. Its stock
value stays visible, so give it a dark font colour or tuck it away. 0-4 maps; a channel
may belong to only one map. `{"version": 1, "maps": []}` is the "off" manifest.

## 4. Other things the integration enables

- **Delta, predicted and best lap:** native channels, already on the shared map's
  screen 3. Add-on A2 can flash the delta Numeric (`ic7_gauge_fx.json`, `above`/`below`
  0), and A3 can switch an image on delta sign.
- **Pit messages:** the iC-7 can't show arbitrary text from CAN. Workable:
  - a numeric "message code" Generic CAN signal driving the A3 value-driven indicator
    images (one picture per message: BOX, FUEL, …);
  - the native MyLaps X2 flag path (`can::CanMyLaps`, which draws the stock FIA flag
    images), if VRacer can emulate it (unverified; the shared map has it disabled).
- **Alarms on timing data:** for example, an alarm on Number of Laps for a stint length.

## The "Disable when engine off" finding

- `Alarm_Module::process_alarms_and_shift_lights` (0xf4324) checks, per alarm,
  `ALARMS_COMP_n_REQUIRE_ENGINE_RUNNING` (settings +0x745DC = 476636, stride 0x4C). When
  it is set, the alarm is only raised if live channel **0xE68 > 449** (`movw r2,#0x1c1;
  cmp; ble`).
- 0xE68 (3688) is `Settings/Trigger/TRIGGER_SYSTEM/RPM` (channel id 384), the native
  ECU RPM.
- The base register is `data_manager::channels::chan_mem` (GOT entry 0x1d0ab8 ->
  0x287b24), the same block NSP polls at USB 0x1400 + address. A scan of every function
  for `[reg, #0xe68]` finds only two stores: `TachoInput::handle` (0x8e354/0x8e36c) and a
  `can_third_party` protocol lambda (#10, 0xe7674). The other path is the JSON
  `CanNode::process_frame`, called only by `CANProtocolEcu::handle` and
  `CANThirdParty::handle`; `haltech-can-protocol.json` maps ID 384 to 0x360 bytes 0-1.
- Every one of these is switched off by a setting:
  - `TachoInput::handle` returns without writing unless Tacho Input Enable (setting
    16357, address 34188) is set.
  - `CANProtocolEcu::init` (0xe0c20) attaches to the Haltech bus only when HALTECH_BUS
    (address 12) is 1.
  - `CANThirdParty::init` (0xe5254) becomes a zombie when
    `get_dash_can_protocol()` returns 0xff, which it does when THIRD_PARTY_BUS is 0 or
    CAN_THIRD_PARTY_ECU is None (255).
- Generic CAN signals write only their own fixed output channels
  (`update_signals_for_frame` 0x750c4 stores at `chan_mem + 0x6250 + 800 * bus +
  4 * signal`, never 0xe68). No setting routes one to RPM: the signal "OUTPUT" settings
  only override the unit. `channels_init` zeroes `chan_mem` at start-up, so with no
  writer the gate reads 0.
- **In the owner's map, Low Oil Pressure, Low Battery Voltage and Low Oil Temp have the
  gate on, so they cannot fire.** In `KFC-screen-5-restored.ic7-2-36-0.nexmap`:
  Tacho Input Enable 0 (engine type 4 cylinders), HALTECH_BUS 0, THIRD_PARTY_BUS 1 with
  protocol None (255), Third Party Generic CAN on. The gated alarms are:
  - Alarm 4 Low Oil Pressure: Third Party Generic CAN Ch5 (signal 4), below 1703
    (170.3 kPa abs, about 10 psi gauge);
  - Alarm 6 Low Battery Voltage: Device Battery Voltage (setting 387, the dash's own
    supply input), below 12000 (12.0 V);
  - Alarm 9 Low Oil Temp: Third Party Generic CAN Ch9 (signal 8), below 3331
    (333.1 K, 60 C).
  All three use only the lower threshold and clear after 5 s.
- **The captures cannot settle it.** NSP reads ECU RPM at USB 0x2268. It is 0 on every
  poll in every capture (2,534 polls in `fail.pcapng`), but so is the Emtron RPM signal
  (USB 0x7c90): all the captures are bench sessions with no CAN traffic. The verdict
  rests on the code and the map settings above.

**Fixes, best first:**

1. **Wire the Emtron's tacho output (or the ECU tach signal) to the dash's tacho input,
   then enable Functions > Tacho Input with the correct cylinder count.**
   `TachoInput::handle` then writes RPM to 0xE68 (it computes RPM when Tacho Input
   Enable, setting 16357 at address 34188, is on, a period is measured and the engine
   type is set; with the input enabled but no pulses it writes 0), and the gate works. Check that the
   dash's RPM matches the Emtron's.
2. Or untick "Disable when engine off" for those three alarms. The cost: Low Oil
   Pressure and Low Battery Voltage alarms with the key on and the engine stopped.
3. Option A above with Emtron-sent Haltech 0x360 also fills RPM.

The IC02 does not change this unless it, too, sends Haltech 0x360 on an enabled Haltech
bus. Its lap and GPS frames don't touch RPM.

## Prototype status

| Item | Result |
|---|---|
| Desktop Qt 5.15 (`scripts/addons_tests/run.sh`) | 96 passed (was 71), including the existing pixel and stock-API tests |
| Dash Qt 5.9.6 under QEMU (`IC7_SYSROOT=… run.sh`) | 81 passed (was 56): Clock 14, TrackMap 11, GaugeFx 29, Indicator 21, StockApi 6 |
| Builder/helper unit tests | 16 passed |
| Add-on NEX (rebuilt on base `dec4e3bf…4d3c`) | `ic7-custom-dash/build-addons-experimental-236/ic7-2.36-addons-experimental.nex`, sha256 `e1ca76e7…fc59f`, builder report `suitable: true` |
| Hardware | **None.** Not flashed. Reading a `.json` user resource from QML on the dash is still unproven, as for every add-on. |
