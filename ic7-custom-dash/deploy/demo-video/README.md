# iC-7 demo video (SIMULATION)

`ic7-demo.mp4` (about 30 s, 1080x828, H.264/yuv420p, 30 fps) and the poster frame
`ic7-demo-poster.png` show the owner's iC-7 running their map
(`KFC-screen-5-restored.ic7-2-36-0.nexmap`) with the r5 custom firmware QML.
**They are a simulation, not a recording.** Every frame carries the caption
"SIMULATION – rendered from map + firmware QML, not a recording".

## What the video shows

| Time | What | Source |
| --- | --- | --- |
| 0–3.3 s | Startup splash `image-1793238519626.gif` | `ic7_splash.json` (`durationMs` 3300) via `HalSplash.qml` |
| 3.3–6.6 s | Screen 3, the CR-V hero screen (`ek9_crv_final2_860.png`, Retro dials) | map screen index 2 |
| 6.6 s | Change to screen 5, the KFC screen | map screen index 4 |
| 9.6–13.2 s | Rev up to the limiter | engine model |
| ~12 s | **KFC LIMITER** fires: full-screen `kfc_colonel_limiter_860.gif` | `ic7_alerts.json` (`gifOnly`, `screens: [5]`) |
| 19.2 s on | Part 2, the variant: the same rev with RPM also on the ECU RPM channel | see below |

### Part 1 is what the real dash does today; part 2 is a variant

The firmware reads two different RPM sources:

* **KFC LIMITER** (alarm 10) watches channel 19803, *Third Party Bus Generic
  CAN Ch1* (the Emtron RPM signal), upper threshold 7900, clear after 1 s, LEDs
  0x3FFF (all 14) red, not flashing. Its *Disable Alarm When Engine Off* is
  **off**, so the 450 rpm gate on ECU RPM (chan_mem 0xE68) does not apply.
  **It fires on the real dash** from Generic CAN alone, and on screen 5 the r5
  popup shows the GIF banner.
* **The shift lights do not use Generic CAN.** `Alarm_Module::update_shift_lights`
  (0xf2a94) compares `chan_mem[0xE68]` (ECU RPM, setting 384) with each
  threshold. 0xE68 is never filled on this car, so **with today's wiring the
  shift-light sequence never runs**: part 1 shows the bar dark until the
  KFC LIMITER alarm lights all 14 LEDs red. Part 2 is labelled as a variant and
  feeds the same simulated RPM into 0xE68 too (as a wired tacho, or an ECU
  RPM source, would), so the shift lights climb.
* The same 0xE68 source drives the CR-V screen's big RPM dial (component 2,
  channel 384), so it also sits at 0 today. The alarms with *Disable When Engine
  Off* enabled (Low Oil Pressure, Low Battery Voltage, Low Oil Temp) can never
  fire while 0xE68 stays below 450.

## What is real

* **Map:** every setting is decoded from the owner's AES `.nexmap` with the
  repository's decoder (`scripts/inspect-nexmap.py`) and placed at
  `0x20000 + addr` from `fw/ic7_2360.hdef` (`mapdata.py`). The byte order (the
  map stores each element big-endian; the dash keeps it little-endian) was
  checked against the captured `ic7-emulator/device-profile.zip` memory.
* **QML:** the dash's own layout is staged
  (`.../dtn/resources/qml_components_data` and `.../dtn/user_resources`, four
  levels up from `user_components`): stock v2.36 resources decoded from
  `fw/Dash-V2-36-0-Release.nex`, with the r5 `main.qml`, `HalSplash.qml`,
  `HalImage.qml` and `HalAlarmPopup.qml` from `../nsp/`. Nothing is modified.
* **UIMain reproduction** (`render_demo.py`): `main.qml` root at 860x480,
  five unnamed `UIScreen` containers, components chosen by
  `get_qml_file_from_gauge_type` (0x1088a4: `type - 2` jump table; note 4 is
  HalCircularHero and 16 HalCircularClassic), geometry, palette words and fonts
  from the map, `setGaugeProperties` + `repaintAll`, screen switching with
  `setVisible`, the popup created afterwards with `setDashVariant(11)`, z = 99
  and `reInitAlarmScreen` with `draw_alarms`' message (text ≤ 20 characters,
  bc, height, img, fc). Colours follow `set_all_colour_properties`
  (0x10affc): the component palette when *Override Colours* is set, else the
  screen palette, in memory-word order, formatted like `int_to_colour`.
* **Channels and alarms:** `ic7-emulator/engine_sim.py` encodes the map's Third
  Party Generic CAN frames (7 frames, 23 signals), decodes them as
  `GenericCAN::update_signals_for_frame` does, and evaluates the map's alarms
  with its `AlarmModule` (thresholds, enables, clear-after, engine gate).
* **LED bar** (`leds.py`, from the decrypted app):
  * 14 RGB LEDs: HDEF RAM channels "LED 1 Colour" .. "LED 14 Colour",
    `SHIFT_LIGHT_0..13`, `update_led_for_shift_lights` ignores index > 13.
  * Each pass: `reset_leds`, alarms (`update_leds(_LED_ENABLED mask,
    LED_COLOUR, LED_BLINKING)`), then shift lights; an LED keeps the first colour
    written, so alarms win over shift lights.
  * Map shift-light table (enable 1, start 1, count 14): LEDs 1/14 green at 6600,
    2/13 green 6800, 3/12 green 7000, 4/11 yellow 7200, 5/10 yellow 7400,
    6/9 yellow 7600, 7/8 red 7800: a centre-in pattern.
  * Shift lights never flash in this firmware (the blink byte written is 0);
    "flashing at the limiter" therefore does not exist as a shift-light feature.
    At the limiter the KFC LIMITER alarm sets all 14 LEDs solid red.
  * Colour bits: 1 blue, 2 green, 4 red.

## What is approximated

* **Renderer:** Qt 5.15 desktop (Mesa under Xvfb) instead of the dash's Qt 5.9.6
  on the i.MX6 GPU. Font rasterisation, antialiasing and GIF decoding can differ
  slightly.
* **Properties not fully reversed:** `set_all_properties` (8 KB of ARM) was not
  translated line by line. Scales and warnings use the map's override min/max
  converted to the display unit, value text is `toFixed(dp)`, and unit strings
  come from a small table.
* **Time:** frames are rendered at a fixed 1/30 s step. GIFs are advanced from
  the simulated clock using their own frame delays (`AnimatedImage.currentFrame`),
  and HalSplash's timeout is applied at simulated 3.3 s. The dash's real update
  rate and LED refresh rate are not modelled; the alarm-LED flash period is
  assumed to be 0.5 s, but no flashing LED appears in this video.
* **Engine:** `engine_sim.EngineModel` physics, a stationary rev (speed 0). The
  ECU rev limit is not in the dash map. 8050 rpm is assumed: above KFC LIMITER
  (7900) and below *Engine RPM Overrev* (8200), which therefore does not fire.
* **Boot screen:** the video assumes the dash comes up on screen 3.
* **LED order:** LED 1 is assumed to be the left-most segment. The map's mirrored
  table (6600 at both ends, 7800 in the middle) fits that assumption.
* **Device frame:** see below. The bar glow is drawn, not measured.

## The device frame (housing layer)

`housing.py` is a separate layer with one interface, `compose(panel, leds,
caption)`:

* **Photo (used for the committed video):** pass the owner's own photo with
  `--housing photo.jpg`. **The photo is not in git.** Only its measured geometry
  is, in `housing-geometry.json`:
  * `screen_quad`: the glass opening's four corners. The 800x480 panel is
    perspective-warped into it and covers the photo's own gauge picture
    completely.
  * `led_bar`: the bar axis, plus the boundaries of each segment along it.
* **Segments in the photo:** the photo's bar shows 14 lit segments, 7 either
  side of a centre divider (mirrored rainbow). That matches the 14 LEDs in the
  HDEF and ELF one to one, so segment *n* from the left is LED *n*. The renderer
  darkens the whole bar, desaturates the coloured light it spills onto the
  bezel, and then draws the simulated LED states into the same 14 segments with
  a soft glow.
* **Fallback (no `--housing`):** a drawn, front-on iC-7-style housing. It has a
  14-segment bar above the panel and three buttons each side; the firmware's
  pin table has six buttons, on GPIO 140–145.
* **Using a different photo of your own dash:**
  1. Take it front-on or at an angle; any size works.
  2. Copy `housing-geometry.json` and measure your photo:
     * the screen opening's corners (top-left, top-right, bottom-right,
       bottom-left);
     * the bar's left end (`origin`) and its angle;
     * the segment boundaries in pixels along the bar.
  3. Render with `--housing yourphoto.jpg --geometry yourgeometry.json`.

## Rebuild

```
cd ic7-custom-dash/deploy/demo-video
xvfb-run -a -s "-screen 0 1280x1024x24" python3 render_demo.py \
    --housing /path/to/ic7-photo.jpg --crf 20
```

* **Needs:** PyQt5 (Qt 5.15 with QtQuick, QtGraphicalEffects and
  QtMultimedia QML modules), Pillow, numpy and ffmpeg, plus the repository's
  `fw/` and `dist/` inputs.
* **Options:** `--no-variant` renders part 1 only. `--hero-screen`,
  `--kfc-screen`, `--switch-at` and `--rev-limit` change the sequence.
* **Output:** temporary files go under the system temp directory (`--work`);
  delete it afterwards. Rendering takes about 2.5 minutes.

The repository contains no raw map and no extracted user images. Those are
read from the map at render time, and the only place they appear is in the
video frames.

## Clean copy

`ic7-demo-clean.mp4` is the same render with no caption text in the frame
(`render_demo.py --clean`). It is still a simulation rendered from the map and
firmware QML, not a recording; say so if you share it.
