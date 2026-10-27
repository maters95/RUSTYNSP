# Feature parity: v2.26.9 (analysed) → v2.36.0 (your dash)

Built from the public firmware release notes (the `releasenotes` entry in each
`Dash-V2-*.nex`), no decryption. Purpose: make sure the custom-dash project
doesn't quietly lose anything the latest firmware added.

## Bottom line
**Route B loses nothing.** You keep Haltech's stock v2.36 firmware and run the
custom app *alongside* it. In "stock mode" the dash IS the full v2.36 — every
feature below is present and untouched. The custom overlay only *adds* maps,
GPS lap timing and a clock. The v2.26.9 image was only ever a protocol reference,
never the base you ship.

Two things worth knowing from the changelog:
- **The v2.36 "CAN integration" feature is already covered by your app.** The
  only new dash-CAN capability in 2.36 is *"Dash CAN protocol supports Little
  endian data bitstring over multiple bytes."* Your `emtrondecoder` already
  decodes arbitrary little-endian, multi-byte signals (any startBit/length), so
  nothing to add — the EK9 CAN map in `emtron_can.json` uses exactly that.
- **Stock firmware has had native GPS + lap timing since v2.31.** So your dash
  already supports a Haltech GPS/lap-timing module; the custom app adds the map
  and a self-contained lap timer on top.

## Delta by area (what 2.27→2.36 added)

### Display / gauges / screens (relevant to a custom dash)
- v2.29 Custom images for components (upload/download, replace Haltech images).
- v2.29 User-definable splash screen.
- v2.30 Circular gauge: custom **Needle Image**, Needle Offset, Reverse Needle
  Direction, **Gauge Start/End Angle**; custom **Font Source**; resizable/
  draggable gauges; new icons.
- v2.31 **Text Component**; GPS + Lap-Timing module support; min font size removed.
- v2.32 Four new bar gauges (H/V × segmented/continuous) with value-text align,
  reverse direction, step size, bars-per-step; **Day/Night opacity** for images.
- v2.33 **Peak-needle** display for dial/bar/numeric; separate bar-markings and
  peak-needle colours.
- v2.35 Separate **Day/Night needle images**.
> Custom-app status: the custom app reimplements its own gauges/map/laps, so it
> isn't bound by these, and stock mode keeps them all. If you later want any of
> these looks in the custom app (e.g. custom needle images, peak needle), say so
> — they're straightforward to add to the QML.

### CAN (your area of interest)
- v2.27 Third-Party CAN: configurable + auto baud rate; GM E38; Holley EFI.
- v2.28 **CAN Port Bus Load** channel (per port).
- v2.29 New Haltech-CAN broadcast channels (torque-converter / transfer-case /
  A-C / power-steering pressures, fuel economy, pre-intercooler IAT & boost,
  Generic Output 1-4).
- v2.31 ECUMaster protocol; GM E38 fuel level.
- v2.32 Improved OBDII (timeout/recovery).
- v2.34 Haltech CAN: Oil Level, Clutch Pressure, Nitrous Enable 1-4, NOS bottle
  opener / exhaust cutout states; Turbo Speed & Specific Humidity scaling fixes.
- v2.36 **Dash CAN protocol: little-endian bitstring over multiple bytes.**
> Custom-app status: your app reads raw CAN (`can0`) and decodes with your own
> table, so it's independent of the stock protocol version. The 2.36 little-
> endian-multi-byte capability is already how your decoder works. The new
> Haltech-CAN *broadcast* channels are the dash→ECU protocol (stock mode), not
> something the Emtron-fed custom app needs.

### Vehicle functions / channels (stock-firmware features)
- v2.31 Dual Fuel Transfer.
- v2.32 Thermofan; Washer/Wipers; Service Indicator; Hour Meter; Brake Pedal.
- v2.33 Intercooler System; Nitrous Bottle Opener; Exhaust Cutout; Humidity
  sensors; Average/Instantaneous Fuel Mileage channels.
- v2.35 IAT Pre-Intercooler Differential; Speedometer (Discrete) for pulse
  clusters; Electrical Load voltage input.
- v2.36 Thermo-fan 3D mapping; Output Test; Cat Temp Indicator.
> These are engine/vehicle control + I/O features that live in the stock app and
> are driven through NSP. Route B keeps every one of them (stock mode). They are
> out of scope for a display overlay and nothing the custom app would remove.

## What this means for you
- Nothing is lost by running the custom overlay — stock v2.36 stays whole.
- The CAN capability you were worried about is already in your build.
- If you want the custom app itself to gain any of the display features above
  (peak needle, custom needle images, extra bar styles), those are small QML
  additions — name the ones you want and I'll add them.
