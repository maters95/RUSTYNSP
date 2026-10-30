# iC-7 Windows test package - 2026-10-30

This package combines the rebuilt NSP DLL, Windows emulator/workbench,
resource-only v2.36 NEX, unchanged supplied map, samples and setup scripts.
It includes resourcefix, screen GIF/MP4 playback, a 3.3-second application-stage
splash, positioned alert GIFs, per-alert GIF-only mode and alert rules for
specific dash screens.

New since the 2026-10-29 package:

- **Fixes the 2026-10-29 flash result.** GIF/MP4 splash and alert GIFs were
  missing on the dash because the components looked for your uploaded files in
  the Windows renderer's folder layout, not the dash's. They now look in the
  dash's `/opt/applications/dtn/user_resources/images` first. Static/OEM splash
  worked because those use NSP's stock path, not these components.
- Alert GIF rules per dash screen (section 5).
- Alarm banners and GIF splash no longer depend on QtMultimedia. Your last
  emulator log showed `HalAlarmPopup.qml:223 Type HalImage unavailable`: the
  multimedia plugin failed to load, so no alarm banner could appear at all.
- The splash is placed like stock NSP's static splash, so your 800 x 480 GIF
  fills the physical panel instead of being shown at 744 pixels wide with
  black side bars. NSP's Windows renderer still shows narrow side bars.

Use this clean package instead of mixing files from previous downloads.
This is a final TEST package, not hardware-equivalence certification.
Disconnect the physical dash. Nothing automatically flashes a real device.

## 1. Extract and prepare

Extract the entire ZIP into a new writable folder, for example
`Downloads\IC7-Final`. Do not run tools inside the ZIP.

You need your complete official NSP 1.48.5 installation, Python 3.11 or newer
with the Windows Python launcher, internet for verified Qt/Python dependencies,
and 7-Zip or Windows tar that can read 7z archives.

Use a signed virtual serial driver such as HHD or signed com0com to create a
COM10 <-> COM11 pair. Never disable signing or use a physical device port.

## 2. Make a separate test NSP copy

Close NSP and its dashboard renderers. In PowerShell, from the extracted kit:

```powershell
cd .\NSP-test-kit
powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\setup-native-media.ps1 `
  -NspInstall 'C:\Program Files (x86)\Haltech\Nexus Software\Haltech NSP' `
  -Destination "$env:USERPROFILE\Downloads\NSP-native-media-final"
```

Adjust the official installation path if necessary. The destination must be
NEW and outside the official installation. Do not copy this DLL into your
official install. If setup reports an error, retain it and stop.

Launch NSP.exe from the new `NSP-native-media-final` folder. Open a backup
iC-7 v2.36 map (or the supplied `NSP-test-kit\map` map). Open its dashboard
editor once to stage the matching Qt runtime, then close NSP and its renderer.
The supplied map is unchanged, not preconfigured for the new features.

## 3. Start the virtual dash

Run `ic7-emulator\start-workbench.cmd`. First launch installs its private
Python dependencies. Configure the NSP-facing virtual COM10 description if
prompted, and select virtual COM11 in the workbench.

The matching NEX is selected automatically in this combined kit. Leave
**Open the real NSP dash renderer automatically** ticked. Click **Start Session**.

The real **Dash Display** bridge starts automatically; its display remains
blank until map settings arrive. Do NOT also run start-stock-renderer.cmd.
The **Layout Diagnostic** tab is only an approximation, not the dash display.

Launch the new test NSP, connect to COM10, and check the simulated serial
`F1C700000001`. Apply/upload the map settings AND its resources. Opening a map
file alone is not an upload. Large maps may take several minutes.

If the renderer reports missing Qt dependencies, open the map in the new NSP
once, close its renderer, then click **Dash Display** to retry. Check the Log
tab and `renderer.log`; failures are not hidden.

## 4. Test startup and simulated firmware updates

In the new NSP splash selector, reselect/import a GIF or MP4. This generates
the new 3300 ms manifest; old saved 3000 ms manifests remain 3000 until
reselected. Save the map under a new name and upload/apply its resources.

Trigger Reboot in NSP, or click **Power Cycle** in the workbench.
Expect moving startup media followed by the dashboard at about 3.3 seconds.
Repeat twice. The earliest physical kernel logo is not animated by this work.

For a firmware-transfer test, select this exact NEX in NSP's updater:
`NSP-test-kit\firmware\ic7-2.36-native-media-screens-experimental.nex`.
The workbench already expects it. A completed sandbox transfer validates the
bytes and reloads all hash-verified preview QML automatically. It does NOT
execute or physically install ARM firmware. An older NEX does not support
per-screen alert rules: it falls back to stock banners for the whole manifest.

## 5. Alerts, placement and matching NSP

Open an alarm page in NSP and click **Banner GIF & position...**, or right-click
an alarm in the tree. Match its exact case-sensitive Message text.

Choose GIF/image, then drag or enter X/Y/Width/Height (860 x 480 logical canvas).
Tick **GIF only (hide text/banner)** to hide the stock colour and text for that
alert. Unticked keeps text over the GIF. If the media fails to load, the warning
colour and text return automatically. Alert banners accept GIF/static images,
not MP4; screen components and startup still support MP4.

For a different GIF on particular screens, set the **Screens** column to
`All` or to numbers such as `1, 3`. Or choose **Preview: Screen N** and
**Add alarm** for an alarm that already has a rule, which adds a rule for that
screen only. A screen rule replaces the alarm's `All` rule on that screen.
No rule ever hides an alarm.

Save / apply, save the map and upload its resources. Reboot or reopen the
renderer to reload the manifest. Use NSP's Simulate controls to create an
existing alarm condition. Keep the same map/settings in NSP and the emulator.

The bridge consumes the same live-data block sent to NSP's own renderer.
Its log should say `Live channels and alarms now follow NSP Simulate`.
This is intended to give matching alarm activation, stacking, media placement
and clearing through the original renderer, rather than a second alarm engine.
Keep only one test NSP and one isolated renderer running.

If NSP stops publishing for one second, the bridge falls back to emulator
memory, which has no CAN/ECU sensor inputs. **Preview Alert** is a separately
labelled synthetic check, not threshold/acknowledgement validation. Its screen
selector switches screens like the dash, so per-screen rules change with it.

To check per-screen rules with the real renderer, raise the alarm with
Simulate and change screens on the emulated dash while it is active. The
GIF and placement should change only on the configured screens.

## 6. Retain the dash and collect useful logs

- **Power Cycle** replays startup while retaining settings/resources and drops
  incomplete resource uploads. It is disabled during firmware-update mode.
- **Stop** saves the session. **Resume Dash** opens that saved session folder,
  retaining the map, resources and a completed matching firmware preview.
  Keep the original NEX and sidecars in place, or reselect the moved NEX.
- **Start Session** always creates a NEW empty dash; it does not erase older
  sessions.
- After Stop, click **Export Logs**. Send this ZIP rather than selecting only
  the top-level files. It contains memory, resources, protocol capture,
  emulator.log and renderer.log with checksums, excluding the copied Qt runtime.
  Review logs before sharing: they contain map/resource data.

For ordinary screen GIF/MP4 elements, use NSP's existing image component,
position/resize it, save the map and upload it normally.

## Verification and limits

Local checks passed:

| Check | Result |
|---|---|
| NSP build | 0 errors; 404 existing decompilation warnings |
| NSP.dll external references | Same as the previous DLL (52 assemblies); none removed, 4 .NET members and 2 JSON types added |
| Emulator Python tests | 111 passed (includes rendered per-screen previews) |
| NSP/.NET regression tests | 42 passed; 9 skipped (need PowerShell or tshark) |
| Desktop QML (Qt 5.15) | 56 passed (includes the dash's real folder layout) |
| Firmware Qt 5.9.6 ARM/QEMU QML | 52 passed (includes the dash's real folder layout) |
| Resource-only NEX audit | 336 stock members unchanged; 3 QML changed, 1 added |

The NEX preserves the stock wrapper/HDEF and does not replace the application,
kernel, bootloader or STM32 code. That structural check is NOT a guarantee
of physical flash safety.

Windows GUI/serial/plugin operation still requires your on-PC acceptance test.
This simulator does not model ARM execution, CAN/ECU acquisition, LEDs,
physical buttons, USB re-enumeration, hardware codecs, physical flashing or
recovery. Alarm acknowledgement and real sensor behavior are not hardware-tested.
Do not treat successful sandbox playback as authorisation to flash a real dash.

`SHA256SUMS` lists every file in this combined kit. `validation-report.json`
records the tested scope, firmware payload hash and known limitations.
