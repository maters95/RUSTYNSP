# Experimental iC-7 GIF alert banners, placement and per-screen rules

This combined candidate retains the verified screen GIF/MP4 component, startup
splash, and all 28 embedded resources from the resourcefix bundle. It adds
alert rules for specific dash screens and removes the alarm popup's
dependency on QtMultimedia. Keep the working videofix/resourcefix/splash
copies and your original map unchanged.
Windows GUI operation and a physical flash/boot have **not** been performed.

## What changed from the alerts candidate

- **Alert GIFs per dash screen.** An alarm can have one "All" rule plus rules
  for particular screens (for example a full-screen GIF on screen 3 only).
- **Alarm banners no longer depend on QtMultimedia.** The owner's emulator log
  showed `HalAlarmPopup.qml:223 Type HalImage unavailable`: when the
  multimedia plugin failed to load, the earlier popup failed as a whole, so
  *no* alarm banners could appear. Alert media now decodes with QtQuick's own
  GIF/image support. A regression test reproduces that failure.
- **Startup splash is placed like stock NSP's splash** and a GIF splash no
  longer needs QtMultimedia either. See the [startup guide](SPLASH-TEST.md).
- `HalImage.qml`, the owner-confirmed screen GIF/MP4 component, is
  byte-for-byte unchanged.

## Install the matching pair

Extract `ic7-nsp-native-media-alerts-test-2.36.zip` into a new directory and use
its setup script with the official NSP install as the source:

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\setup-native-media.ps1 `
  -NspInstall 'C:\Program Files (x86)\Haltech\Nexus Software\Haltech NSP' `
  -Destination "$env:USERPROFILE\Downloads\NSP-native-media-alerts"
```

Use the **new DLL and new screens NEX together**
(`firmware/ic7-2.36-native-media-screens-experimental.nex`). Earlier NEX
files do not understand per-screen rules: they reject such a manifest and show
stock alarm banners instead. No firmware is flashed automatically.
See the included [startup guide](SPLASH-TEST.md) for the emulator COM pair,
Qt runtime setup, GIF/MP4 splash tests and physical-validation boundary.
Qt libraries are downloaded from the pinned official archives, not redistributed.

## Configure alerts in NSP

1. Disconnect the physical dash. Open a backup iC-7 v2.36 map in the new NSP.
2. Open the editor: click **Banner GIF & position...** below the Message
   setting on an alarm's page, right-click the alarm in the tree and choose
   **Banner GIF & position...**, or use **Alert GIF banners and placement...**
   from NSP's main menu. The first two preselect that alarm.
3. Matching is the exact, case-sensitive text received by the stock popup:
   the alarm's **Message** setting, not its tree name. If its runtime text
   differs, enter that exact text instead. Changing the Message requires
   updating its override. Alarms with identical Message text share it.
4. **Choose GIF/image** opens NSP's existing image library/import picker.
   Start with the bundled `samples/animated.gif`. GIF bytes are preserved;
   static PNG/JPEG/BMP images also work. MP4 is supported on screens and at
   startup, **not in this alert-banner selector**.
5. Move the rectangle in the layout preview; drag its bottom-right corner
   to resize. Or edit **X / Y / Width / Height** numerically in the grid.
   Coordinates use the dash's **860 x 480 logical canvas**, scaled to the
   physical 800 x 480 display. Rectangles must fit and be at least 60 pixels
   tall. The editor canvas animates the GIF with the text over it; it is
   not an alarm trigger.
6. **Save / apply** writes `u/ic7_alerts.json` into user image resources.
   Online, selected user images and the manifest are uploaded via the normal
   resource RPC. Offline, upload/apply the normal map resources afterward.
   **Save the map under a new name**; it is not saved automatically.
7. Reopen the desktop map renderer or reboot the emulator/dash to reload the
   manifest. **Stock background** keeps placement but removes the custom
   media; **Remove override**, followed by saving/applying, restores the
   stock bottom-stacked placement for that alert.

By default the GIF is the banner background and the warning text is drawn
over it. Tick **GIF only (hide text/banner)** for an alert to show only the GIF
inside its rectangle: the coloured stock banner and the text are hidden (the
editor preview shows a dashed outline). GIF only needs a GIF or image source.
If that media fails to load on the dash, the stock coloured banner and warning
text come back automatically, so an alarm is never invisible. Older manifests
without this setting keep the text. Alarm
colours, alarm activation, priority/order, clear/acknowledgement logic and
LED rules remain controlled by the original application. Choose sufficient
width and contrasting colours so the warning stays readable. Avoid overlapping
alert rectangles: overlapping alerts retain the application's model order.
The popup remains above ordinary dashboard components and below startup media.
Invalid configuration logs an error and keeps stock warning banners; a failed
GIF decoder logs an error while the warning text/background remain.

## Different alert GIFs on different screens

The **Screens** column holds `All` or one-based screen numbers such as
`1, 3`. On a listed screen that rule replaces the alarm's `All` rule; on
other screens the `All` rule applies, or the stock bottom banner if there is
none. A rule never hides an alarm: per-screen rules change only its media and
placement. An alarm may have one `All` rule, and each screen may be claimed by
only one rule for that alarm; the editor and the dash both reject overlaps.

To add a screen-only rule, choose **Preview: Screen N**, enter the alarm
text and click **Add alarm**. If the alarm already has a rule, the new rule
applies to screen N only. The layout preview always shows what the dash draws
on the chosen screen; selecting a row switches to a screen where that rule is
drawn. Manifests without screen rules are still saved as version 1.

### How the dash knows the active screen

This uses the stock v2.36 application's own screen switching, with no
application patch. Disassembly of the decoded `nic-7` ELF (SHA-256
`d86bde81...7248`) shows `ui_module::UIMain::UIMain` always creating exactly
five `UIScreen` objects in screen order (`cmp r4, #5`). Each constructor
creates an unnamed `QQuickItem` and parents it to `QQuickView::rootObject()`.
The constructor then creates `Alarm_Module`, which parents `HalAlarmPopup`
to the same root. `UIMain::handle_screen_change` switches screens through
`UIScreen::set_visibility`, a tail call to `QQuickItem::setVisible`. The
per-screen settings stride is `0xab08` bytes, matching the emulator's settings
schema of five screens 43,784 bytes apart.

The popup therefore takes its five preceding siblings as the screens and
follows their `visibleChanged` signals. The named items declared in `main.qml`
are never mistaken for screens. If the layout does not match, for example in
another renderer, or no single screen is visible (an error screen), only
`All` rules apply. Other dash variants do not use the custom rectangle manifest.

## Place ordinary GIF/MP4 screen elements

Use the existing image component on the desired screen, choose the GIF/MP4 in
the image library, and use NSP's existing canvas drag/edge-resize controls or
component X/Y and size settings. Those settings are already per-screen and
persist in the map. This candidate reuses that editor rather than introducing
a second incompatible screen-layout format. Reserved media PNG aliases retain
the working videofix behavior. Alert banners remain overlays, not ordinary
screen components.

## Test on the Windows emulator

Use the emulator from the same combined kit, in a separate directory.
Open an iC-7 map once in the new NSP copy to stage its Qt add-ons; close its
renderer. Run `.\start-workbench.cmd`; **Dash Display** opens automatically on
Windows. Do not start a second `start-stock-renderer.cmd` alongside it.
The isolated renderer installs the exact four QML components from this NEX.
It requires the matching Qt 5.11 x86 multimedia/GIF add-ons and DirectShow
`dsengine`; missing dependencies are explicit errors. Upload map settings from
NSP: the display must remain blank until those settings arrive.

**The emulator renderer mirrors exactly what NSP shows.** While this NSP is
open, it publishes the same live-data block it sends to its own dash renderer
(read-only, local shared memory `HaltechNSP_iC7_LiveData`). The workbench's
**Dash Display** window applies that block to the original renderer,
so when NSP's **Simulate** panel (or live data) raises an alarm, the emulator
shows the same stock popup with the same colours, stacking, GIF override and
GIF-only setting, and clears it at the same time. Its console prints
`Live channels and alarms now follow NSP Simulate` (or `NSP live data`); when
NSP stops updating for a second it falls back to emulator memory. Nothing is
written to a dash.

For a clearly labelled **synthetic alert preview** without NSP, after uploading map resources,
click **Preview Alert** in the workbench toolbar and pick an uploaded alert
text, or run:

```powershell
.\.venv\Scripts\python.exe .\native_view.py --preview-alert "OIL PRESSURE"
```

Use the exact text configured in NSP; repeat `--preview-alert` to show multiple
alerts. The preview window's screen selector switches screens like the dash,
so per-screen rules change as you select screens; `--screen 3` starts on
screen 3. This exercises the shared popup and GIF/rectangle manifest over the
emulator HTTP resource API. It does **not** trigger a real threshold, modify
device settings, or validate alarm evaluation/acknowledgement. The normal stock
renderer path remains separate. Test a real alarm condition and its clearing
on the Windows renderer before any separately authorized bench test.

Repeat startup with GIF and MP4, reboot twice, then test an alert GIF, a static
alert image, an empty source, and removal of the override. Add a rule for one
screen, raise the alarm with NSP's **Simulate** panel, and change screens
while it is active: the GIF and placement should change on that screen only,
and the alarm must stay visible on every screen. Reopen the saved map
and re-upload to check persistence. Open the channel selector to verify the
resourcefix GUI fix remains present. Check ordinary screen positioning and
switch screens while alerts are active.

## Integrity and automated verification

The resource-only NEX changes only `main.qml`, `HalImage.qml` and
`HalAlarmPopup.qml`, adds `HalSplash.qml`, and preserves all **336** other
decoded stock members. Its original 44-byte wrapper and migration HDEF are
byte-identical. Application, kernel, bootloader and kernel-logo tooling are
unchanged. The earliest kernel logo remains static.

Build with `scripts/build-nsp-gif-preview.py --splash --alerts` and a new output
directory (this candidate: `ic7-custom-dash/build-cfw-native-media-screens-236/`);
package with `scripts/package-nsp-media-test.py --native-media
--splash --alerts`. The included map is the supplied original, byte-for-byte,
not preconfigured with new alert rules.

Checks include .NET compilation and manifest validation, stock-root/alert hash
guards and cache removal, resourcefix byte equality, decoded NEX member
equality, real desktop and firmware Qt 5.9.6 ARM GIF animation/geometry/clearing,
repeated GIF/MP4 startup, and an actual HTTP-to-QML alert preview screenshot.
These checks do not prove Windows plugin loading, hardware installation,
physical alarm behavior, or a recovery method. Retain the working NEX, back
up the map and establish recovery before any bench flash; do not test while
driving.

Verified locally: x86 DLL build with zero compiler errors (404 existing
decompilation warnings); its external references are the shipped DLL's
52 assemblies, 728 types and 2,549 members with none removed, plus four .NET
base-library members and two `System.Text.Json` types; **42** Python/.NET
regressions passed (9 need PowerShell or tshark and were skipped); **51**
desktop Qt 5.15 QML checks; **47** QML checks on the firmware's own
Qt 5.9.6 ARM userspace under QEMU, including per-screen switching and the
missing-multimedia case; and **111** emulator Python tests with real PyQt5,
including rendered per-screen alert previews. ZIP hashes and all packaged QML
bytes are checked against the tested sources. Windows Forms editor
interaction remains an on-PC validation step, not a result of the Linux
cross-build.
