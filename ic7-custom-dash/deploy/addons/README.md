# iC-7 v2.36 experimental add-ons

**EXPERIMENTAL and separate.** This is an optional layer on top of the main
splash/alarm candidate NEX. It is not part of that NEX, has never been installed on
a physical dash, and should only be tried after the main candidate is confirmed
working on yours. Nothing here flashes anything.

With no add-on manifest uploaded, every touched gauge draws exactly as stock.

## What it adds

| Add-on | Component | Configured by | What it does |
|---|---|---|---|
| A1 Animated indicators | Indicator | `ic7_indicators.json` | While the indicator is ON, show a GIF or muted MP4 (full colour) instead of the tinted icon. Optional still/GIF image while OFF. |
| A3 Value-driven images | Indicator | `ic7_indicators.json` | While the indicator is OFF, pick an image by value range (gear, fuel or temperature icons), with optional hysteresis. |
| A2 Threshold effects | Numeric, Bar "Horizontal 1", Circular "Classic" | `ic7_gauge_fx.json` | A coloured frame drawn just outside the gauge that flashes, pulses or stays solid when the value passes the warning limits or a threshold (for example a shift flash on RPM). |

Not implemented: animated gauge backgrounds (A4: bars have no background image and
the circular "image" is the needle) and trend sparklines (A5: per-value Canvas
repaints are a real CPU risk on the i.MX6, for little benefit). See `RESEARCH.md`.

### Safety rules built in

- **Warnings are never weakened.** While an indicator is in warning, only an `on`
  media you chose replaces the tinted icon, and the stock glow still draws around it.
  Value frames and `off` media are never shown during a warning. Effects only add a
  frame outside the gauge; they never cover, dim or recolour the value or the
  stock warning colour (pixel-tested).
- **Fails closed to stock.** A missing, unreadable or invalid manifest (any bad entry
  rejects the whole file), missing media, a media decode error, or a missing add-on
  file all leave the stock drawing. Add-on media replaces the stock icon only after it
  has decoded, so the icon is never blank.
- **Bounded cost.** Each component reads its manifest once when it loads (no per-value
  file access). Frame choice is at most 32 comparisons per value update. Effects
  update at 10 Hz or less and only while triggered and on screen. An MP4 decoder is held
  only while that indicator is showing it. GIFs use `cache: false` and pause when hidden.

## Configure

1. Write a spec like `samples/spec.json`: media as local file paths, the image you
   select for each indicator in NSP (`image`, optionally shipped with `image_file`),
   and the channel names exactly as the gauges show them.
2. Validate and write the upload folder (Windows, macOS or Linux, Python 3 only):

   ```
   python make-addon-manifests.py samples\spec.json --output my-upload
   python make-addon-manifests.py --check my-upload
   ```

### `ic7_indicators.json` (version 1)

```json
{"version": 1, "indicators": [
  {"image": "ic7_shift_light.png", "on": "u/shift_on.gif", "off": "u/shift_off.png"},
  {"image": "ic7_check_engine.png", "on": "u/check_engine.mp4"},
  {"image": "ic7_gear.png", "hysteresis": 0.1, "frames": [
    {"min": -0.5, "max": 0.5, "source": "u/gear_n.png"},
    {"min": 0.5, "max": 1.5, "source": "u/gear_1.png"}]}]}
```

- `image`: filename of the picture selected for the indicator in NSP (png/jpg/bmp).
  Indicators showing any other image stay stock.
- `on` / `off`: `u/<file>` (uploaded) or `h/<file>` (stock dash image); gif, png, jpg,
  bmp or mp4. `off` applies only when no frame range matches.
- `frames`: 1-32 ranges, `min <= value < max`, first match wins; gif/png/jpg/bmp.
  `hysteresis` keeps the current range until the value leaves it by that much.
- For a gear-style indicator, set its NSP warning limits outside the gear range, or it
  will show the stock warning instead of the frames.

### `ic7_gauge_fx.json` (version 1)

```json
{"version": 1, "gauges": [
  {"channel": "Engine Speed", "trigger": "above", "threshold": 6800, "effect": "flash", "rateHz": 3},
  {"channel": "Coolant Temp", "trigger": "warn", "effect": "pulse", "colour": "#FF2020", "width": 6}]}
```

- `trigger`: `warn` (above the enabled warning max or below the enabled warning
  min), `above` or `below` a `threshold`.
- `effect`: `flash`, `pulse` or `solid`; `rateHz` 0.5-5 (default 2); `width` 2-12 px
  (default 4); `colour` `#RRGGBB` (default: the gauge's warning colour).
- Applies to every Numeric, Bar "Horizontal 1" and Circular "Classic" gauge showing
  that channel. The frame sits just outside the gauge and may overlap a neighbour.

Unknown fields, duplicates, path separators and out-of-range values are rejected,
both by the helper and on the dash.

## Upload (owner steps; Windows steps not verified)

The manifests and media go up as ordinary map user resources, like `ic7_alerts.json`.
NSP's **Write Settings and Resources** sends every file in its working
`%APPDATA%\Haltech\Nexus\user_resources\images` folder as `u/<filename>`
(`Form23.method_226`, no extension filter), skipping files the dash already has.

1. Close NSP. Keep a backup of your map.
2. Copy everything in your upload folder into
   `%APPDATA%\Haltech\Nexus\user_resources\images` **and** into the vehicle's own
   `user_resources\images` folder (under `Documents\Haltech\Nexus Maps and Data Logs\<vehicle>\`),
   so it is kept with the map. These are the two folders the rebuilt NSP writes
   `ic7_alerts.json` to (`Form23.SaveMediaResource`).
3. Open the map, select the indicator images listed in `image` for your indicators,
   save, then connect and **Write Settings and Resources**.
4. Flash the add-on NEX (below) only when you accept the risk.
5. To turn an add-on off, delete its manifest from both folders, or upload a manifest
   without that entry, and write resources again.

## Try it first

- **Desktop preview** (not the dash): `python3 scripts/addons_tests/make_fixtures.py`
  then `QML_XHR_ALLOW_FILE_READ=1 qmlscene ic7-custom-dash/deploy/addons/preview/Preview.qml`.
  It drives the real stock-derived components with the sample manifests.
- **NSP and the emulator do not show these add-ons.** The emulator publishes a fixed set
  of components (`main.qml`, `HalImage.qml`, `HalSplash.qml`, `HalAlarmPopup.qml`) and
  NSP's renderer re-extracts stock components from the map definition. On those you
  will see stock indicators and gauges; that is expected.

## Build

```
python3 scripts/build-ic7-addons.py \
  --base ic7-custom-dash/build-cfw-screen-alarms-freshmtime-236/ic7-2.36-screen-alarms-experimental.nex \
  --sysroot <extracted dash rootfs>
```

`--base` is required and its SHA-256 is recorded. Output in
`ic7-custom-dash/build-addons-experimental-236/`: the NEX, `build-report.json` and
`audit-report.json` (plus `audit-nex-report.json` from `scripts/audit-nex.py`). The builder refuses a base that already changes one of the add-on
members. Only the add-on QML differs from the base; the wrapper, `manifest.xml`,
`ic-7.hdef` and every other member (bytes and tar metadata) are copied. Add-on members
get a fresh mtime so a stale Qt disk cache cannot run old code. `scripts/audit-nex.py`
also runs cleanly on the output, apart from its expected "does not match maintained
source" lines (it compares against the main work's `deploy/nsp` folder).

## Rollback

- Remove the manifests (see Upload step 5): every component is stock again.
- Re-flash the **base** NEX you built from (its SHA-256 is in `build-report.json`) to
  drop the add-on QML entirely, or the stock `fw/Dash-V2-36-0-Release.nex` to drop
  everything custom. Never interrupt an update; keep stable bench power.

## Risks and limits

- New QML in the firmware resources: a component that failed to load would show as a
  gauge error. The add-on code sits in separately loaded files so a failure there leaves
  the stock gauge, but the four changed gauge files themselves must still load.
- The manifest/media path depends on the dash storing and serving `.json`, `.gif` and
  `.mp4` user resources, which is still unproven on hardware (same as the main work).
- GPU/CPU: GIF decoding is on the CPU; many large or fast GIFs, or several MP4s at once,
  can slow the display. Keep media small (about 96 x 96, few frames); the helper warns
  above 2 MB GIF / 8 MB MP4. MP4 on the i.MX6 goes through GStreamer and was only tested
  with software decoding under QEMU.
- Not possible from QML: new gauge types, more than 5 screens, combining channels in
  one component, buttons/touch, sound, shift-light LEDs, the kernel boot logo.
- Effects frame only these three gauge types; other types stay stock.

## Validation

| Check | Result |
|---|---|
| Desktop Qt 5.15 (`scripts/addons_tests/run.sh`) | 69 passed: both folder layouts, no manifest, 9 bad-manifest cases, missing media, GIF and MP4, threshold transitions with hysteresis, stock API equality, pixel comparisons |
| Dash Qt 5.9.6 under QEMU (`IC7_SYSROOT=... run.sh`) | 54 passed (no pixel tests: offscreen grab is black on ARM); MP4 decoded |
| Builder/helper (`python3 -m unittest discover -s scripts/addons_tests`) | 15 passed |
| Hardware | **None.** Not flashed, not run on a dash or in NSP. |
