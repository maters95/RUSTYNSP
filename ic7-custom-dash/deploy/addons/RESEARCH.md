# iC-7 v2.36 experimental add-on features: research report

> **Corrections after implementation (2026-10-30).** The original report follows
> unchanged below this box; where it disagrees with the evidence here, this box wins.
>
> 1. **`halImagePath` is not passed verbatim.** `ui_module::UIComponent::image_src_to_path`
>    (decrypted `nic-7`, 0x10974c) turns NSP's `u/<name>` into
>    `../../../../user_resources/images/<name>` and `h/<name>` into a path under
>    `../../images/`, after checking the absolute `/opt/applications/dtn/...` file with
>    `QDir::exists` (it logs "Component image file does not exist" otherwise). Only the
>    **filename** survives, so the add-ons key on the basename, never the whole path.
> 2. **"Already-proven" configuration channel is only partly proven on hardware.** The
>    dash stores and serves `.gif`/`.mp4` user resources: the owner has played uploaded
>    GIF and MP4 files in screen `HalImage` components on the dash, and the captures show
>    the dash's user index listing `.gif`, `.mp4` and `.json` uploads (the 2026-10-29
>    capture also shows `.json`/`.gif` writes acknowledged). What is unproven is QML on
>    the dash reading a `.json` user resource: the flash that carried `ic7_alerts.json`
>    failed because the components looked in the wrong folder, and the corrected path
>    has not yet been seen working on a dash. It is the same unverified dependency the
>    main splash/alarm work has. (`FIRMWARE-CAPABILITIES.md` says only `*.png *.jpg
>    *.jpeg *.bmp` and fonts are writable; the hardware playback and captures show the
>    write handler stores any extension, as `MEDIA-RUNTIME-AUDIT.md` says.)
> 3. **How an arbitrary-name file reaches the dash** (`nsp-rebuild/ns4/Form23.cs`,
>    `method_226`, "WriteUserResources"): for every sub-folder of
>    `%APPDATA%\Haltech\Nexus\user_resources` (`string_10`), `Directory.GetFiles(folder)`
>    with **no filter**, each file sent as `"u/" + fileName` unless the device already has
>    the same CRC. So any file placed in the `images` folder is uploaded by **Write
>    Settings and Resources**, whatever its extension. NSP's image picker is a separate
>    UI and was not verified to list GIF/MP4/JSON, which is why manifests are keyed by the
>    still image the owner selects.
> 4. **A4's premise is wrong.** No bar component uses `halImagePath` (it is only declared),
>    and in all four circular types it is the **needle** image, not a background. There is
>    no gauge "background image" to animate. A4 is not implemented.
> 5. **A2 cannot touch "many gauge files" safely.** Four bar types (`HalBar*Continuous`,
>    `HalBar*Segmented`) set `clip: true` on the root, which would clip an effect drawn
>    outside the gauge. A2 is implemented for `HalNumeric`, `HalBarHorizontal1` (no clip)
>    and `HalCircularClassic` only, as an isolated `Loader`, never inside stock code.
> 6. **Value delivery** (`UIComponent::update_value`): only components with a channel
>    pointer get values. Each update is one `setGaugeProperties({halRawValue,
>    halValueText, halUnitText})` followed by `repaintValue()` through
>    `QMetaObject::invokeMethod`. `HalIndicator` is channel-driven (its stock
>    `repaintValue` uses `halRawValue`), so A1/A3 have a live value.
> 7. **Stock indicator semantics** (what "ON" means): `halRawValue >= warnMax ||
>    halRawValue < warnMin`, ignoring the enable flags. A1/A3 reuse exactly this test.
> 8. **Stock defects found (preserved, not fixed):** `HalBarHorizontal1.repaintAll`
>    throws `ReferenceError: barCanvas is not defined` after repainting the background,
>    and its value canvas references an undefined `halShowPeakNeedle`. The add-on copy
>    keeps both byte-for-byte; the tests assert identical behaviour.
> 9. **"Byte-for-byte like stock" is provable for the source, not exactly for pixels.**
>    The add-on gauge files are stock plus marked insertions (stripping the
>    `IC7-ADDON` blocks yields the stock bytes; tested). Pixel comparisons on desktop
>    llvmpipe are exact in every state except one `HalCircularClassic` state, which
>    differs by one anti-aliased pixel by one LSB; stock-vs-stock renders are exact, so
>    the extra invisible node is the likely cause. The pixel test allows at most that.
> 10. **NSP cannot preview these add-ons**: its renderer re-extracts stock components from
>    the HDEF. When this was written the emulator published a fixed list of sidecars
>    (`main.qml`, `HalImage.qml`, `HalSplash.qml`, `HalAlarmPopup.qml`); it now installs
>    every NEX member, add-on files included, into its renderer tree, but add-on drawing
>    there is untested. Validation is the desktop + QEMU tests and a desktop preview
>    scene.
> 11. **Disk-cache precaution.** Qt 5.9.6 reuses compiled QML whenever path and mtime
>    match. The add-on builder gives every replaced/added member a content-derived mtime
>    that no stock or base member uses (same scheme as the main builder). The main work
>    later recorded owner evidence that the cache was not reused across an update on the
>    dash, so this is a precaution, applied anyway. The earlier `*-native-236` base kept
>    stock mtimes on its own replaced files; the builder reports that for any base, and
>    the `*-freshmtime-236` and current `*-r3-236` bases have none.
> 12. Minor: the stock resource archive has 329 files (339 tar entries with directories).

Status: research and plan only. Nothing here has been flashed. This builds on
`ic7-custom-dash/deploy/nsp/FIRMWARE-CAPABILITIES.md` (Tier 0/1/2), focusing on
what the screen components can actually receive from the native app, which
decides which "new features" are real.

## What a screen component gets from the dash app (hard limit)

- The app talks to each component only through `setGaugeProperties(props)`,
  `repaintAll()`, `repaintValue()`, `showPeakNeedle`/`hidePeakNeedle` (plus
  the main/popup methods already documented). The complete property vocabulary
  in the v2.36 app (strings in the decrypted `nic-7`) is:
  `halRawValue halValueText halUnitText halChanNameText halRawUnitType
  halDecimalPlaces halCompMin/MaxValue halCompWarnMin/MaxValue
  halCompWarnMin/MaxEnable halCompStepSize halCompMinorTickCount halImagePath
  halImageOpacity halPeakImagePath halPeakNeedleImageOffset halNeedleImageOffset
  halStartAngle halEndAngle halReverseNeedleDirection halFontFamily`, the font
  size/align properties and the colour properties (`halWarningColour`,
  `halIndicatorOn/OffColour`, bar/circular/numeric colours).
- So each component sees **one channel's value and text, its thresholds, its
  colours and one or two image paths**. It cannot read other channels, the
  current screen (except through our marker trick), physical buttons, or the
  alarm state.
- Gauge types are a fixed enum mapped to fixed QML files
  (`UIComponent::get_qml_file_from_gauge_type`). There are 5 screens. Neither
  can be extended from QML.
- Already-proven configuration channel: a user resource uploaded as an
  image-named file (JSON manifest) read by the component via XMLHttpRequest from
  `/opt/applications/dtn/user_resources/images` (4 levels up from
  `user_components`). The **selected image filename** is also a usable key: the
  app passes `halImagePath` verbatim, and NSP lets the owner pick any uploaded
  image.

## Hardware facts relevant to screens (from `nic-7` symbols)

- STM32 co-processor over `io::dash_uart`: battery, rail, AVI, DPO, DPI/SPI,
  LCD backlight voltages, internal temperature sensor, tacho input state, DPO
  output override, camera output power. These surface as normal dash channels,
  so a "dash health" screen needs no code at all, just existing gauges.
- Buttons and backlight are GPIO pins owned by the app
  (`io::dash_arch_v1/v2::button_pins/backlight_pins`). **QML receives no input.**
  Interactive or touch features are not possible without app changes.
- Ambient light sensor (`io::ambient_light_io`) and day/night mode exist
  natively (Tier 1 setting, not QML).
- No evidence of a speaker/buzzer path reachable from QML (a QtMultimedia
  audio plugin exists in the rootfs, but no audio output device is known).
  Treat sound as not available.
- GPU: i.MX6 (Vivante) with Qt 5.9.6 eglfs. QtGraphicalEffects is installed
  and the stock HalIndicator already uses Glow plus OpacityMask, so modest
  shader effects are OK. Full-screen effects, many concurrent decoders and
  per-frame Canvas repaints are the main performance risk.
- Qt modules on the dash (`/usr/lib/qml`): QtQuick 2.9, QtGraphicalEffects,
  QtMultimedia, Qt3D, QtSensors, QtPositioning, QtLocation, QtBluetooth,
  QtWebSockets, QtSystemInfo and others. Available does not mean useful: no
  sensors or GPS are wired to QML.

## Candidate add-ons, ranked (all resource-NEX QML, opt-in, default = stock)

| # | Feature | Component(s) | How it is configured | Value | Risk |
|---|---|---|---|---|---|
| A1 | **Animated indicators**: an indicator shows a GIF/MP4 (full colour, no mask) while ON, the stock tinted image while OFF | HalIndicator | `ic7_indicators.json` keyed by the selected indicator image filename → on-media, optional off-media | High: animated warning/flame/shift icons | Low-Med |
| A2 | **Threshold effects**: flash/pulse/colour-cycle when the value is beyond the warn limits; "shift light" flash for RPM | HalNumeric, bars, circular | `ic7_gauge_fx.json` keyed by channel name (`halChanNameText`), optional screens | High | Med (touches many gauge files) |
| A3 | **Value-driven image sets**: an indicator/image picks a frame by value ranges (gear graphics, fuel/temperature icons, custom tachos) | HalIndicator | manifest ranges → image list | Med-High | Low-Med |
| A4 | **Animated gauge backgrounds**: GIF where a gauge's background image is a .gif | bars/circular using halImagePath | by extension or manifest | Med | Med (GPU) |
| A5 | **Trend sparkline**: short history line drawn on a numeric gauge | HalNumeric | manifest keyed by channel | Med | Med-High (Canvas CPU on i.MX6) |

Out of scope for QML (state plainly to the owner): new gauge types, more than
5 screens, cross-channel logic inside one component, button/touch interaction,
sound, shift-light LEDs (STM32/app-native), and the kernel boot logo.

Tier 1 (NSP-side, no NEX): confirm from `ic-7.hdef` and NSP which camera,
night-mode, Wi-Fi and datalog settings exist for the iC-7 but have no UI, as a
read-only findings list.

## Design rules for the add-on

1. **Separate and opt-in.** A separate experimental NEX layered on the main
   splash/alarm candidate, never altering it. With no add-on manifest present,
   every touched component must behave byte-for-byte like its stock
   counterpart (proved by tests and pixel comparisons).
2. **Additive to stock QML.** Edit stock files minimally; keep every stock
   property, function, objectName and return value. Wrap all add-on code so an
   exception, missing file or bad manifest falls back to stock rendering.
3. **Never hide or weaken a warning.** Effects may add emphasis but must not
   make a warning state less visible than stock (no effect that hides the
   value or warning colour).
4. **Bounded cost.** One manifest read per component load (no per-value XHR),
   no per-frame Canvas repaint faster than about 10 Hz, at most a few
   concurrent animated decoders, and `cache: false` for large GIFs.
5. **Same validation bar** as the main work: desktop Qt 5.15 plus Qt 5.9.6
   under QEMU with the dash sysroot, the audit against stock, and the emulator.
