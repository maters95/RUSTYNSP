# iC-7 Windows test package - 2026-10-30

This package combines the rebuilt NSP DLL, the Windows emulator/workbench, the
resource-only v2.36 NEX, your restored KFC map, samples and setup scripts. It
supersedes the 2026-10-29 screen-alarm, path-fix and replacement kits. Use this
clean package instead of mixing files from earlier downloads.
This is a TEST package, not a verified physical-flash release. Disconnect the
physical dash during desktop/emulator setup; nothing here flashes it automatically.

## What changed since the 2026-10-29 kits

- **Splash and alarm media now load on the real dash.** The components
  previously looked for your uploaded files in NSP's Windows folder layout. The
  dash keeps them at `/opt/applications/dtn/user_resources/images`.
- **The failed flash was decoded.** Every file reached the dash intact: the
  NEX body, the splash GIF and manifest, the screen markers, and the KFC GIF and
  alarm manifest. The two device error replies are normal (a stock Haltech
  update shows the same two). The failure was the folder path.
- **Alarm banners no longer depend on QtMultimedia**, so a multimedia failure
  cannot remove every alarm banner.
- **Your 800 x 480 splash GIF fills the panel**, placed the way stock NSP
  places a static splash, instead of showing at 744 pixels wide with bars.
- **Screen-restricted alarms also follow the dash's native screens** when no
  screen marker reports.
- **Alarm appearance preview** shows the rule's real screen (background and
  gauges from your map) behind the GIF.
- The NEX passed an independent audit against the stock package
  (`NSP-test-kit/firmware/audit-report.json`).

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
| NSP/.NET regression tests | 43 passed; 9 skipped (need PowerShell or tshark) |
| Desktop QML (Qt 5.15) | 63 passed, including painted splash pixels |
| Dash Qt 5.9.6 under QEMU | 57 passed, including markerless screen switching and missing QtMultimedia |
| Emulator Python tests | 116 passed |
| NEX audit vs stock | 326 stock files unchanged, none removed; 3 QML changed, 1 added; wrapper/HDEF identical; all imports present on the dash |
| `fail.pcapng` decode | all resources and the NEX body acknowledged complete |

`SHA256SUMS` lists every file in this kit; `validation-report.json` records the
tested scope and the firmware payload hash.
