# iC-7 Windows test package - 2026-10-30, revision 4

This package combines the rebuilt NSP DLL, the Windows emulator/workbench, the
resource-only v2.36 NEX, your restored KFC map, samples and setup scripts. It
supersedes r3, r2 and every earlier kit. The NEX is the same as r3; r2 and
earlier NEX files must not be flashed (see below). Use this clean package instead of mixing files from earlier downloads.
This is a TEST package, not a verified physical-flash release. Disconnect the
physical dash during desktop/emulator setup; nothing here flashes it automatically.

## What changed since r3

- **NSP alarm appearance UI follows NSP's own conventions.** Open it from
  **Setup > Dash Alarm Appearance** or the alarm page's **Alarm
  Appearance...** button (iC-7 v2.36 maps only). Rule names longer than 20
  characters, containing `"` or padded with spaces are rejected, because the
  dash sends at most 20 characters; rules that match no alarm in the map ask
  for confirmation; unsaved edits prompt before closing; prompts use NSP's
  themed dialogs; the 1x1 screen markers are hidden from the image library;
  large media (over 4 MB, or GIF frames over 860x480) asks for confirmation.
  Write all resources now stops at the first failed file instead of reporting
  a half-written map as complete.
- **Emulator engine simulation (off by default, labelled SIMULATION).** The
  workbench **Engine simulation** tab drives your Emtron Generic CAN signals
  through the dash's own decode, so NSP's gauges, live data, raw CAN view and
  your map's alarms behave as with a running engine. Presets include low oil
  pressure, overheat, over-rev, low fuel pressure and low battery; per-signal
  holds and CAN faults are available. The emulator now also works offline after
  its first setup and reports a busy COM port clearly.
- **Check your "Disable when engine off" alarms.** On the dash that option
  needs the ECU RPM channel above 449 rpm, which Generic CAN does not fill, so
  Low Oil Pressure, Low Battery Voltage and Low Oil Temp may never fire with
  only Generic CAN. The emulator's low-oil and battery presets feed that channel
  so you can see the alarm; clear **Feed ECU RPM channel** to see what the
  real dash would do.

## Carried over from r3

- **Stock alarm banners always draw over custom media.** In r2 a positioned
  custom banner later in the alarm list, such as your full-screen GIF-only
  KFC LIMITER on screen 5, was drawn over an earlier bottom-stacked stock
  banner such as OIL PRESSURE, hiding it. The r2 NEX (`3f6d26f1…`) must not
  be flashed.
- **The emulator behaves like the real dash.** It installs the NEX the way the
  dash watchdog does, uses the dash's folder layout, answers NSP as the
  captures show (36,450 captured exchanges replayed, 0 differences) and writes
  a fidelity report that explains any failed manifest lookup. Its launcher
  installs the new `cryptography` requirement on Windows (`start-workbench.cmd`
  runs `pip install -r requirements.txt`; if that fails, run
  `.venv\Scripts\python.exe -m pip install -r requirements.txt` in
  `ic7-emulator`).
- Kept from r2: the dash's `/opt/applications/dtn/user_resources/images` path
  fix (the proven cause of the failed flash), bounded alarm-manifest reads,
  padded alarm-name matching, QtMultimedia-free alarm banners, the
  panel-filling splash, native-screen tracking, and fresh QML modification
  times. The fresh times are a precaution only: your earlier GIF/MP4 flash
  shows the dash does not reuse its QML cache across updates.

## 1. Make a separate test NSP copy

Extract the entire ZIP into a new folder; keep `NSP-test-kit` and
`ic7-emulator` side by side. Close NSP and its renderers, then from PowerShell:

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\NSP-test-kit\setup-native-media.ps1 `
  -NspInstall 'C:\Program Files (x86)\Haltech\Nexus Software\Haltech NSP' `
  -Destination "$env:USERPROFILE\Downloads\NSP-screen-alarms-native"
```

Use your official installation path. The destination must be new and outside
the official install. Do not copy this DLL into the official install.

## 2. Check the map in NSP

Launch NSP from the new destination and open
`NSP-test-kit\map\KFC-screen-5-restored.ic7-2-36-0.nexmap`.
Open **Setup > Dash Alarm Appearance** and select KFC LIMITER (or **Alarm
Appearance...** on its alarm page). Confirm the GIF, **GIF only** and
Screens `5`; the preview should show screen 5 behind it. Apply -> OK -> Save.
Your splash GIF is selected in the normal startup-image setting.

## 3. Emulator test first

Run `ic7-emulator\start-workbench.cmd`, select your verified virtual COM pair,
and confirm the workbench and NSP both select
`NSP-test-kit\firmware\ic7-2.36-screen-alarms-experimental.nex`
(SHA-256 in `NSP-test-kit\firmware\build-report.json`). Start a fresh session,
transfer the NEX, then upload the map's settings and resources. Check:

1. Reboot: the splash GIF animates, fills the display area, and hands off to
   the dash at about 3.3 seconds.
2. Trigger KFC LIMITER with NSP's Simulate panel: its GIF shows on screen 5
   only, and the alarm clears normally.
3. Change screens while it is active: it disappears on screens 1-4 and returns
   on 5. Other alarms show on every screen, and a stock banner such as OIL
   PRESSURE stays visible over the KFC GIF.

If anything is missing, the workbench **Update** tab and the session's
`fidelity-report.txt` show the installed NEX and any manifest lookup that
failed, with the reason.

## 4. On the physical dash

Only when you accept the risk, on stable bench power, with the original NEX
and a map backup kept: flash this NEX and upload the map's settings and
resources. Then check the same three things as above and tell me which pass.
If something does not appear, note exactly what you see instead:

- **Static or stock splash:** `main.qml`/`HalSplash.qml` is not running, or
  `ic7_splash.json` is missing or invalid, its source is wrong, or the GIF did
  not decode. Each of these falls back to the normal startup.
- **KFC LIMITER as a full-screen coloured banner with its text:** the rule
  matched (a matched rule always draws at its own rectangle) but the GIF did
  not decode. GIF only keeps the stock colour and text until the GIF decodes.
- **A normal bottom-stacked banner:** either the stock alarm popup is still
  running or the alarm name does not match the rule text. Both look the same.
- **No banner at all:** the popup failed to load, a screen restriction hid it
  (check you are on screen 5), or the alarm never triggered.

Reproduce it in the emulator before flashing again: its fidelity report
(**Update** tab, or `fidelity-report.txt` in the session folder) says which
manifest lookup failed and why.
Re-flashing the stock resources restores the stock QML.
Never interrupt an active update. The earliest kernel boot logo is not
animated by this work; with a GIF splash selected it keeps its previous image.

## Limits

Not installed or cold-boot tested on hardware. Windows GUI operation, physical
alarm switching and recovery are unverified. ARM/QEMU checks run the dash's Qt
5.9.6 but cannot prove GPU output. Screen restrictions hide the whole alarm
popup on other screens; do not restrict safety alarms such as oil pressure.

## Verification

| Check | Result |
|---|---|
| NSP build | 0 errors; 404 existing decompilation warnings; same 52 referenced assemblies as the shipped DLL, none removed |
| NSP/.NET regression and UI-convention tests | 51 passed; 8 skipped (need PowerShell) |
| Desktop QML (Qt 5.15) | 76 passed, including painted splash pixels and a stock banner painted over a full-screen alarm GIF |
| Dash Qt 5.9.6 under QEMU | 68 passed, including alarm z-order in both orders, markerless screen switching, missing QtMultimedia, a 4.5 s blocked startup and application-style scheme-less component paths |
| Emulator Python tests | 157 passed, including capture conformance (36,450 exchanges, 0 differences) and engine-simulation alarms |
| NEX audit vs stock | 326 stock files unchanged, none removed; 3 QML changed, 1 added, all with fresh non-stock mtimes; wrapper/HDEF identical; all imports present on the dash |
| `fail.pcapng` decode | all resources and the NEX body acknowledged complete |

`SHA256SUMS` lists every file in this kit; `validation-report.json` records the
tested scope and the firmware payload hash.
