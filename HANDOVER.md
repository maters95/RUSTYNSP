# Handover: iC-7 custom firmware branch `ccr-95cf1bfa-g35hiz`

Status at 2026-10-31. Every commit is on `ccr-95cf1bfa-g35hiz` and mirrored to
`rustynsp-fork`; `main` is untouched. **Nothing in this branch has been run on
Windows or on the physical dash.** Everything below was verified on Linux:
Qt 5.15 desktop, the dash's own Qt 5.9.6 under QEMU, the decrypted dash
application, the stock firmware, your maps and your USB captures.

---

## 1. What to use

| Purpose | File | SHA-256 |
|---|---|---|
| **Windows test kit (use this)** | `dist/ic7-final-windows-test-2026-10-31-r5.zip` | `37659bce…180d` |
| NEX to flash (inside the kit) | `NSP-test-kit/firmware/ic7-2.36-screen-alarms-experimental.nex` | `dec4e3bf…4d3c` |
| Step-by-step test and flash plan | `ic7-custom-dash/deploy/nsp/TEST-AND-FLASH-PLAN.md` (the kit's START-HERE is `FINAL-START-HERE.md`) | |
| Swap-in files plus a stock base | `test-variants/` (README inside) | `SHA256SUMS` |
| Fixed KFC alarm GIF | `ic7-custom-dash/deploy/demo-video/fixed-media/kfc_colonel_limiter_860.gif` | |
| Demo videos | `ic7-custom-dash/deploy/demo-video/ic7-demo.mp4` (captioned), `ic7-demo-clean.mp4` | |

**Never flash** these earlier custom NEX files:
- `7d3f8c96…`: the one that failed, because of the wrong folder path.
- `9f4f449f…`, `a6c47d35…`, `3f6d26f1…` (r2): superseded.

---

## 2. What the firmware does, and the history

The custom firmware is a **resource-only NEX**:
- It replaces 3 QML files and adds 1 inside the dash's resource archive: `main.qml`, `HalImage.qml`, `HalAlarmPopup.qml` and the new `HalSplash.qml`.
- The 326 other stock files, the 44-byte wrapper and the HDEF are byte-identical to stock.
- It never replaces the dash application, kernel, bootloader or STM32 firmware. The NEX can't carry a kernel or bootloader at all; those live in NAND.

It adds:
- an animated **GIF/MP4 startup splash** (up to 3.3 s), driven by `ic7_splash.json`;
- **custom GIF/image alarm banners**, matched by alarm name, with optional **per-screen restriction** (1-based `screens`), driven by `ic7_alerts.json`;
- GIF/MP4 in screen image components, a feature already proven on your dash by the earlier "videofix" build.

### Why your first flash didn't show the splash or alarm GIFs (proven)
- `fail.pcapng` contains exactly NEX `7d3f8c96`. Every upload in that capture was acknowledged with status 0, and the two error replies on mode writes also appear in a stock Haltech update.
- That build looked for your uploaded files **three** folders up, which is NSP's Windows layout. The dash keeps them **four** up, in `/opt/applications/dtn/user_resources/images`.
- The settings files were never found, so the dash silently stayed stock.
- Screen images worked because the dash app passes their path itself.

### Fixes since then
- The four-level path.
- Fresh file timestamps on the replaced QML. This is only a precaution: your videofix flash shows the dash doesn't reuse its QML cache across updates.
- Alarm-name trimming. The dash sends at most 20 characters, copied verbatim and not escaped.
- Manifest reads limited to once every 2 s. The dash redraws alarms on every tick.
- **Stock banners always drawn above custom media**, so a full-screen GIF can't hide oil pressure.
- Alarm banners don't depend on QtMultimedia.
- The splash fills the 800×480 panel. The dash draws an 860×480 canvas squeezed onto an 800×480 panel.
- **Native-screen fallback** for screen restrictions. If screen detection fails, restricted alarms show on every screen (fail-visible).
- **Alarms stay hidden while the splash plays.** This is your decision and matches OEM. The alarm and shift LEDs are native and unaffected.

### Rebuilt NSP.dll (in the kit)
- Alarm appearance UI under **Setup > Dash Alarm Appearance**, or **Alarm Appearance...** on an alarm page, shown for iC-7 maps.
- Rejects rule names that are longer than 20 characters, contain `"`, or are padded with spaces.
- Asks for confirmation when a rule matches no alarm.
- Uses NSP's themed prompts, and hides the screen markers.
- Warns about large media (over 4 MB, or GIF frames over 860×480).
- Write all resources stops at the first failure. This is a deliberate change from stock.
- References the same 52 assemblies as before, none removed.
- One wording nit is left: a message says "v2.36 map", but NSP only checks for an iC-7.

---

## 3. Findings about your car and map (act on these)

1. **The ECU RPM channel (`0xE68`) is never filled on your car.**
   - Only the dash's **Tacho Input** or an ECU protocol (Haltech / third-party) writes it. Generic CAN never does.
   - Your map has Tacho Input disabled, Haltech CAN off and the third-party protocol set to None, so the dash thinks the engine is stopped. Verified from the alarm code and your map.
   - Consequences on the real dash today:
     - **Low Oil Pressure, Low Battery Voltage and Low Oil Temp can never fire.** They use "Disable when engine off", which needs ECU RPM above 449.
     - **The shift lights never run.** They compare against ECU RPM.
     - **The CR-V screen's big RPM dial reads 0.**
   - **KFC LIMITER does fire.** It watches Generic CAN channel 1 (above 7,900) and isn't gated, so all 14 LEDs go solid red through its own LED setting.
   - **Fix:** wire the Emtron's tacho output to the dash Tacho Input and enable **Functions > Tacho Input** (4 cylinders). That fixes all four problems at once. Until then, untick "Disable when engine off" on those three alarms.
2. **The KFC GIF has a partly transparent first frame.** The screen behind flashes through on every loop. Replace the file in NSP's user resources with the fixed copy above (same name), then write resources.
3. **Your shift lights**, from the map and the dash code:
   - 14 LEDs, lighting from the outside in: green at 6,600, 6,800 and 7,000; yellow at 7,200, 7,400 and 7,600; red at 7,800.
   - This firmware never flashes shift lights.
   - An active alarm's LED colour overrides them.
4. **CAN IDs:** your Emtron frame IDs (0x3E8–0x3EB, 0x3F2/0x3F3) clash with Haltech broadcast IDs. That only matters if Haltech CAN is ever enabled.

---

## 4. Hardware: what the iC-7 has and what's possible

Full report: `ic7-custom-dash/deploy/hardware-audit/REPORT.md`.

**What the unit has:**
- a Variscite i.MX6 (Solo or DualLite) running Qt 5.9.6;
- **one** FlexCAN bus;
- an STM32 I/O controller over UART;
- 6 buttons;
- 14 RGB LEDs on SPI;
- an ambient-light sensor;
- a PWM-driven backlight.

**Not available on the iC-7:** camera (that's uC-10 only), Wi-Fi (gated off in the app, and no kernel driver), audio, touch, a second CAN bus, screenshots (stubbed), and a battery-backed clock. The dash **never knows the real time**.

**Already exposed by NSP:** lap timer, MyLaps, GPS (on Haltech CAN only), keypads, odometer/trip, ALS brightness.

**Possible without app changes:** QML add-ons (below), more Emtron data over Generic CAN, and dash buttons sent to the Emtron over Generic CAN TX.

**Need app changes (out of reach):** new gauge types, more than 5 screens, an animated kernel boot logo.

---

## 5. Experimental add-ons (separate NEX, opt-in)

- **NEX:** `ic7-custom-dash/build-addons-experimental-236/ic7-2.36-addons-experimental.nex` (`e1ca76e7…`). Also in `test-variants/2-addons-experimental/`.
- **Base:** it's r5's NEX plus four add-ons:
  1. **Animated indicators:** GIF/MP4 when an indicator is on (`ic7_indicators.json`).
  2. **Value-driven images:** gear and fuel graphics (same file).
  3. **Warning effects:** flash or pulse on Numeric, Horizontal 1 bar and Classic circular gauges (`ic7_gauge_fx.json`).
  4. **Clock** (`ic7_clock.json`) and **GPS track map** (`ic7_track_map.json`).
- **Behaviour:** with no settings file, everything draws as stock. Turn add-ons off by uploading the "off" files (`make-addon-manifests.py --off`) and power-cycling, because NSP never deletes files from the dash.
- **Unproven:** QML reading `.json` on the real dash. r5 proves it first.

Docs: `ic7-custom-dash/deploy/addons/README.md`, `RESEARCH.md`.

---

## 6. Clock, GPS and lap timing

Docs: `ic7-custom-dash/deploy/vracer/README.md`, `GPS-OPTIONS.md`.

**Clock.** The dash has no real time of day; something has to send it on CAN.
- A Generic CAN signal using the unit "Time (min) - formatted" shows HH:MM on a stock gauge.
- The clock add-on adds 12-hour display, seconds and a UTC offset (600 for AEST, 660 for AEDT).

**Recommended GPS: ECUMaster GPS V2.**
- No phone needed.
- CAN at 1 Mbit/s, base ID 0x400 (no clashes): position, speed, heading and UTC time.
- Add it as extra Third Party Generic CAN frames, leaving the Emtron untouched.
- It feeds the track-map and clock add-ons.
- It has no lap timing; that would need a lap-timer add-on, which isn't written yet.

**Add the VRacer IC02 + app** for lap, best, predicted and delta times.
- It sends them on 0x4F0–0x4F5, so add them as Generic CAN frames.
- It needs the phone.
- The shared VRacer map's approach (Haltech CAN plus native Track Modules) **conflicts** with your Emtron Third Party setup, because NSP allows only one dash data protocol.

**Haltech HT-011310** is only a GPS **speed** pulse module: no position, time or laps.

**Android Auto:** none of these devices feeds the head unit.
- Use **OsmAnd** or Google Maps offline areas on the phone for a moving offline map.
- No lap-timer app projects to Android Auto.

**Map tiles on the dash:** the dash's Qt includes offline map tiles (tested under QEMU). A tile-map add-on is possible but untested on hardware, and the repo's tiles are Esri "do not redistribute".

**Unconfirmed:** vendor details come from search summaries, because vracer.io and ecumaster.com are blocked by this session's network allow-list.

---

## 7. Windows emulator (in the kit)

Docs: `ic7-emulator/README.md`.

**How it behaves like the dash:**
- It installs the actual NEX the way the dash watchdog does (wipe, decrypt, extract with timestamps) into the dash folder layout. The old broken NEX fails there, as on the dash.
- It answers NSP exactly as the real dash did in all your captures: 36,450 exchanges across 9 sessions, 0 differences. That includes error replies, reboot silences and the splash-status protocol.
- A fidelity report in Export Logs says why any settings file wasn't found.

**Engine simulation** (Engine simulation tab, off by default, labelled SIMULATION):
- Drives your Emtron Generic CAN signals through the dash's decode, at the USB addresses NSP polls (`0x1400` + channel).
- Evaluates your map's alarms the way the dash does.
- Has presets, per-signal holds, CAN faults, and saveable scenarios.
- Turn off **Feed ECU RPM channel** to see your car as it is wired today.

**Display:** it uses NSP's own Windows renderer (`dash_virtual.exe`), so it can't run the dash's ARM software.

**Tests:** 157 emulator tests pass.

---

## 8. Demo video

`ic7-custom-dash/deploy/demo-video/`:
- `ic7-demo.mp4` (captioned) and `ic7-demo-clean.mp4` (no text).
- The sequence is your splash, then the CR-V screen (3), then the KFC screen (5), then the limiter and the KFC GIF.
- Part 1 is the car as wired today. Part 2 is with the tacho wired.

How it was made:
- Rendered from your map and the r5 QML.
- Uses your iC-7 photo as the housing. The photo is **not** committed; pass it with `--housing`.
- Regenerate with `xvfb-run -a python3 render_demo.py --housing <photo> [--clean] --resource fixed-media/kfc_colonel_limiter_860.gif`.

It's a simulation, not a recording.

---

## 9. Your next steps, in order

1. **Wire and enable the Tacho Input,** or for now untick "Disable when engine off" on Low Oil Pressure, Low Battery Voltage and Low Oil Temp. This is a safety step, needed whatever else you do.
2. **Replace the KFC GIF** in NSP's user resources with `fixed-media/kfc_colonel_limiter_860.gif`.
3. **NSP on Windows, with the dash disconnected:**
   - Extract the r5 kit and check its SHA-256.
   - Run `setup-native-media.ps1` into a new folder, open your map, and check **Setup > Dash Alarm Appearance** (KFC LIMITER, GIF only, screen 5) and the splash selection.
   - **Stop and report** if NSP errors: nobody has run this DLL on Windows yet.
4. **Emulator:**
   - Run `start-workbench.cmd`, transfer the NEX, upload the map, and run checks E1–E4.
   - Try the low-oil preset with **Feed ECU RPM channel** off and on.
   - If anything fails, use **Export Logs**.
5. **Flash the dash:**
   - Use bench power and keep backups (`test-variants/0-base-stock`).
   - Start a USB capture, flash r5, upload the map, then do a **full power cycle**.
   - Run checks D1–D5 from the plan. **Never interrupt an update.**
6. **Report back** for each check:
   - pass or fail, and what you saw;
   - the capture;
   - a photo if something looks wrong.
7. **Only after D1–D5 pass:**
   - Try `test-variants/2-addons-experimental`, starting with an animated indicator.
   - Then buy a GPS (ECUMaster GPS V2 recommended), set up its Generic CAN frames from `GPS-OPTIONS.md`, and check the latitude scale on the bench.
   - Add the VRacer later if you want lap times.
8. **Optional:** to have vendor manuals checked directly, add `vracer.io` and `www.ecumaster.com` to the environment's network allow-list.

**Rollback at any point:** flash `test-variants/0-base-stock/firmware/ic7-2.36-stock-resources.nex` (stock screen files) or the full Haltech NEX, then re-upload your map.

---

## 10. Open questions and known limits

**Unverified on hardware:**
- the DLL on Windows;
- QML reading uploaded `.json` on the dash;
- GIF frame rate on the i.MX6;
- MP4 splash;
- alarm LEDs during the splash.

**Inferred, not captured:**
- NSP "connection lost" during the emulator's ~25 s reboot silence;
- 0x000f with no BMP pending.

**Not done, deliberately:**
- Moving HalImage's video player into a Loader. It's a cost improvement only, deferred so the hardware-proven component isn't changed.
- Clock support for separate hour/minute/second bytes.
- A lap-timer add-on.

**Repository housekeeping:**
- Kits are about 89 MB, over GitHub's 50 MB recommendation. Consider Releases or LFS.
- The scratchpad on the build machine is temporary.
