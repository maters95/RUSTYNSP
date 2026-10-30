# iC-7 v2.36 firmware capability deep-dive

What else the dash can be made to do, and how much risk each option carries.
This is a research deliverable, not a build. Nothing here was flashed or run on
a physical dash.

## How this was determined

- The dash application stage `nic-7` was decrypted from
  [`fw/Dash-V2-36-0-Release.nex`](../../../fw/Dash-V2-36-0-Release.nex) (the same
  AES-CBC key/IV the resource archive uses, read from `dash_watchdog`).
  Decrypted ELF SHA-256 `d86bde81820b8b7b5efcfc7466aa994cabeacac6c6bcd725536393ab48687248`,
  reproducible with [`scripts/disassemble-nsp-app.py`](../../../scripts/disassemble-nsp-app.py).
- Its symbol table, strings and the 339-member resource archive were enumerated.
- Claims below cite the symbol or string they rest on. "Present" means the code
  is in the shipped firmware; it does **not** mean NSP currently exposes it for
  the iC-7, and it does not mean it is hardware-verified here.

## The safe extension channel (what the current CFW uses)

The firmware exposes two write paths NSP already drives, both confined to
`/opt/applications/dtn/user_resources`:

- `dash_user_spaces::DashUserResource::user_resource_read_write` with
  `filters_for_resource_type` / `get_resource_path_from_resource_type`.
  The accepted filters are **images** (`*.png *.jpg *.jpeg *.bmp`) and
  **fonts** (`*.ttf`) only — nothing else is writable at runtime.
- The full-resource NEX path (`res_ic-7.qzip`), which replaces files inside the
  firmware's own resource archive, including the QML in `qml_components_data`.

So two tiers of "custom" are possible without touching the application binary,
kernel or bootloader:

1. **User-resource uploads** (image + font bytes, plus our JSON manifests that
   ride in as image-named files). Reversible, per-map, low risk. This is how
   the splash, alert and screen media work.
2. **Resource-only NEX** that swaps QML component files. Higher risk (a bad QML
   can stop the dash starting) but still leaves the app/kernel/bootloader
   untouched. This is how `HalImage`, `HalSplash`, `HalAlarmPopup` and `main.qml`
   are replaced.

Everything in **Tier 0** below fits this channel. **Tier 1** is firmware
features that already exist but need a setting + NSP UI to use. **Tier 2** needs
real application/kernel changes and is out of the safe channel.

---

## Tier 0 — addable now, same safe channel, no new firmware

These extend files the firmware already loads. Risk is the same as the media
work already done.

- **Animated / video backgrounds on any screen.** `HalImage` already does GIF
  and muted MP4. The same `AnimatedImage`/`Video` approach can be folded into
  the other image-bearing components so a gauge's background, not just a
  standalone image, can be animated.
- **Custom fonts, live now.** Fonts are an accepted user-resource type, and the
  test map already carries `GoogleSansFlex`, `Roboto` and `eurostile`. A CFW can
  ship bespoke gauge typography through ordinary resource upload — no NEX needed.
  (`DashUserResource` font filter `*.ttf`; `FontManager` in the app.)
- **Restyled gauges.** The 23 QML components under `user_components` (bar,
  circular, numeric, retro, indicator, gear, text) can be re-skinned the way
  `HalImage` was — colours, needles, tick styling, animated needles, warning
  animations — by replacing their QML in a resource-only NEX.
- **Richer alert popups.** `HalAlarmPopup` is ours to shape: multi-line banners,
  icon animations, flashing, per-alarm sounds are out (no audio on that path)
  but per-alarm imagery, position and per-screen rules are in (done).
- **Startup splash variants.** Still bounded to the Qt/application stage (the
  earliest kernel logo stays static — see Tier 2), but the 3.3 s window can show
  anything the GIF/MP4 path supports.

Limit worth stating plainly: **you cannot add a brand-new gauge *type*.**
`ui_module::UIComponent::get_qml_file_from_gauge_type(unsigned short)` maps a
fixed `GAUGE_TYPE` enum to a fixed QML filename. You can change what an existing
type's QML draws; you cannot introduce a type the application does not already
enumerate.

---

## Tier 1 — features already in the firmware, waiting on a setting + NSP UI

These subsystems are compiled into the shipped dash. If the iC-7 HDEF already
exposes their settings, they are a configuration job in NSP. If it does not, the
rebuilt NSP.dll could add the UI to drive them — a genuine feature add that
needs no firmware flash, only the setting to exist in the data model. The HDEF
is compressed, so which are already surfaced must be confirmed in NSP itself.

- **Reversing / auxiliary camera.** `modules::dash::camera_input::CameraInput`
  with `start_camera`/`stop_camera`/`trigger_conditions_satisfied`, driving a
  GStreamer pipeline on `/dev/video1`
  (`imxv4l2videosrc … imxipuvideosink`). Three display geometries are built in:
  full `952×472`, a `360×480` right-hand strip at x=460, and `1280×480` (uC-10).
  Enums exist for `CameraInputRotate`, `CameraInputMirror`, `CameraInputFill`
  and `CameraInputPowerType`, plus `Follow Front When Reversing` and
  `On When Camera Active`. This is a complete reversing-camera feature; the big
  unknown is whether this hardware unit has the camera input populated.
- **Ambient-light auto-brightness and Night mode.** `io::ambient_light_io`
  (ALS, lux→ALS), `enum_for_BrightnessMode`, `enum_for_DayNightSource`
  (`Ambient Light` / `Auto` / `Manual`), `is_night_mode`, `brightness_table`.
  A day/night palette switch and auto-dimming screen are present.
- **Wi-Fi (and Wi-Fi/BT module).** `UnixWifiModule` runs an access point
  (`hostapd` + `udhcpd`, `192.168.5.2`, `wifi_config_ssid_password`) and
  `WifiComms` does AES-encrypted UDP. `enum_for_WiFiEnable`,
  `enum_for_WifiBTModuleStatus`. Likely wireless NSP tuning / telemetry; needs
  the module fitted.
- **USB stick datalogging.** `/mnt/usb/datalog/log%u`, `g_mass_storage` gadget
  toggled so the dash exposes its logs as a drive, `datalogger::*`. On-dash
  logging to a stick, pulled over USB.
- **Lap timer / MyLaps race control.** `can_lap_timer::CanLapTimer`,
  `can::CanMyLaps`, "MyLaps Speedhive" branding, and **28 FIA flag images
  already in the resource archive** with meanings wired in the app
  (`Blue Flag`, `Double Yellow Flag`, `Pit Entry Closed/Left/Right`,
  `Pit Lane Speed Limiter`, …). A track-day / race overlay is largely built.
- **GPS over CAN** (`can_gps::CanGPS`), **CAN keypad** (`can_keypad::CanKeypad`,
  CANopen/LSS), **Output Test** (new in 2.36, per release notes),
  **odometer / trip reset** (`odometer::reset_trip_meter`), and a built-in
  **screenshot** path (`take_screenshot_requested`, already reused for component
  rendering).

The highest-value NSP.dll work here is a small panel that lets the owner
configure whichever of camera / night-mode / Wi-Fi / datalog settings exist in
their map's data model but have no iC-7 UI — surfaced the same native way the
alert editor now is.

---

## Tier 2 — needs real application/kernel work (out of the safe channel)

High risk, not reversible through the resource channel, and not something to
attempt without a proven recovery path and a bench flash.

- **Animated *kernel* boot logo** (the frames before Qt starts). Bounded by the
  `pnmtologo` / `kernel_patch::KernelPatch` BMP→uImage path; it is a single
  static CLUT224 image, not a decoder. Animating it means patching the kernel
  image.
- **New gauge types, extra screens, or a changed alarm engine.** Screen count is
  fixed at five (`UIMain` creates exactly five `UIScreen` objects); gauge types
  are a fixed enum; the alarm engine is in the binary. All require editing
  `nic-7` itself.
- **New ECU CAN protocols.** The 22 `can_protocols/*.json` files in the resource
  archive are data the app parses, so an added/edited protocol *might* load via a
  resource NEX — but the parser's tolerance is unverified and a bad protocol
  could destabilise CAN. Treat as experimental, not Tier 0.
- **SSH / shell access.** The app actively disables `dropbear`
  (`systemctl disable dropbear.socket`). Re-enabling it is a rootfs change via
  the SWU path, not the NEX resource path.

---

## Recommendation

1. **Confirm the hardware first.** Camera, Wi-Fi/BT and the ALS are the biggest
   wins but each depends on the part being fitted. The read-only USB diagnostics
   kit and an NSP look at the map's available settings will tell you which of the
   Tier 1 features your unit can actually use before any work goes in.
2. **Cheapest real wins, no NEX:** custom fonts and additional user images are
   already accepted at runtime — ship those first.
3. **Next, in the resource-NEX channel you already trust:** animated gauge
   backgrounds and re-skinned gauges, built and validated exactly like the media
   work.
4. **If a Tier 1 setting exists but has no UI,** add it to NSP.dll — that is the
   same kind of native integration as the alert editor and carries no firmware
   risk.
5. **Leave Tier 2 alone** unless you have a working recovery flash and accept the
   risk; the payoff (animated kernel logo, new gauge types) is small next to the
   chance of a dash that will not boot.
