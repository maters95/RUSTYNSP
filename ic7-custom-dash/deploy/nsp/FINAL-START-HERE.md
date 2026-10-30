# iC-7 Windows test package - 2026-10-30, revision 2

This package combines the rebuilt NSP DLL, the Windows emulator/workbench, the
resource-only v2.36 NEX, your restored KFC map, samples and setup scripts. It
supersedes `ic7-final-windows-test-2026-10-30.zip` and every earlier kit; that
kit's NEX must not be flashed (see below). Use this clean package instead of
mixing files from earlier downloads.
This is a TEST package, not a verified physical-flash release. Disconnect the
physical dash during desktop/emulator setup; nothing here flashes it automatically.

## What changed since the first 2026-10-30 kit

- **The dash could have kept running the stock QML.** The dash's Qt 5.9.6
  keeps compiled QML in a cache outside the resources folder that a NEX update
  wipes, and reuses a cached file whenever its path and modification time
  match; it never compares the content (reproduced on the dash's own Qt under
  QEMU). Every earlier custom NEX kept the stock times on `main.qml` and
  `HalAlarmPopup.qml`, which the dash compiles on every boot, so it would keep
  running the stock root (no splash at all) and the stock alarm popup (plain
  banners) even with correct paths. The replaced QML now carries new,
  content-derived times, and the audit rejects any NEX that reuses a stock time.
- **Alarm manifest reads are bounded.** The dash redraws alarms on every UI
  tick; the popup now re-reads `ic7_alerts.json` at most every 2 seconds
  instead of on every tick.
- **Padded alarm names still match** their banner rule (the comparison stays
  case-exact).
- **Ordinary image components** run none of the screen-marker code.
- Kept from the first 2026-10-30 kit: the dash's
  `/opt/applications/dtn/user_resources/images` path fix, QtMultimedia-free
  alarm banners, the panel-filling splash and native-screen tracking.

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
Open **KFC LIMITER -> Appearance...** Confirm the GIF, **GIF only** and
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
   on 5. Other alarms show on every screen.

## 4. On the physical dash

Only when you accept the risk, on stable bench power, with the original NEX
and a map backup kept: flash this NEX and upload the map's settings and
resources. Then check the same three things as above and tell me which pass.
If the splash or GIF banner still does not appear, note whether the alarm row
looks stock (text only) or customised, and whether the earlier static splash
image is shown; that tells the stale-cache, path and media causes apart.
Re-flashing the stock resources later restores stock `main.qml` and alarm
popup; the dash may keep its cached copy of an earlier custom `HalImage.qml`
for image components, which only affects GIF/MP4 image playback.
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
| NSP/.NET regression tests | 46 passed, including the stale-cache reproduction on the dash's Qt; 8 skipped (need PowerShell) |
| Desktop QML (Qt 5.15) | 72 passed, including painted splash pixels |
| Dash Qt 5.9.6 under QEMU | 66 passed, including markerless screen switching, missing QtMultimedia, a 4.5 s blocked startup and application-style scheme-less component paths |
| Emulator Python tests | 116 passed |
| NEX audit vs stock | 326 stock files unchanged, none removed; 3 QML changed, 1 added, all with fresh non-stock mtimes; wrapper/HDEF identical; all imports present on the dash |
| `fail.pcapng` decode | all resources and the NEX body acknowledged complete |

`SHA256SUMS` lists every file in this kit; `validation-report.json` records the
tested scope and the firmware payload hash.
