# Experimental iC-7 GIF alert banners and placement

This combined candidate retains the verified screen GIF/MP4 component, startup
splash, and all 28 embedded resources from the resourcefix bundle. Keep the
working videofix/resourcefix/splash copies and your original map unchanged.
Windows GUI operation and a physical flash/boot have **not** been performed.

The pathfix candidate corrects splash/alarm user-resource lookup for the real
dash's directory layout while preserving the desktop preview layout. Loose QML
files beside the NEX are emulator/reference sidecars: the dash receives those
components inside the encrypted NEX resource archive, not as separate copies.
The earlier screen-alarm candidate must not be used to validate this correction.
See the [real-device audit](MEDIA-RUNTIME-AUDIT.md#real-device-resource-path-correction).

The current candidate (`build-cfw-screen-alarms-r3-236`) supersedes
`build-cfw-screen-alarms-freshmtime-236` (`3f6d26f1…`) and
`build-cfw-screen-alarms-native-236`; flash neither. It adds:

- **Stock banners draw over custom media.** A full-screen GIF-only banner
  (such as KFC LIMITER) could cover an earlier stock alarm such as OIL
  PRESSURE. Stock bottom-stacked banners now always draw above it.

It keeps from `build-cfw-screen-alarms-freshmtime-236`:

- **Fresh QML modification times**, as a precaution. Qt 5.9.6 can reuse a
  compiled QML cache entry whenever path and mtime match, but the owner's
  hardware evidence shows the cache is not reused across updates on their
  dash; the wrong folder path is the proven cause of the failed flash. See the
  [cache audit](MEDIA-RUNTIME-AUDIT.md#stale-qml-disk-cache-on-the-dash).
- **Bounded manifest reads.** `Alarm_Module::draw_alarms` calls
  `reInitAlarmScreen` on every `UIMain::update` tick and then sets the popup's
  `z` to 99; the popup re-reads `ic7_alerts.json` at most every
  `manifestRefreshMs` (2 s) on those calls. `setGaugeProperties` and
  `repaintAll` still reload at once.
- **Padded native names match.** The native alarm text is trimmed before the
  case-exact comparison with a rule, as NSP trims the rule's text when saving.
  The dash sends at most 20 characters of an alarm name, so keep rule names
  within 20 characters.

It keeps from `build-cfw-screen-alarms-native-236`:

- **Alarm banners decode with QtQuick only.** Banner GIFs and images use
  QtQuick's own `AnimatedImage` instead of `HalImage`, which imports
  QtMultimedia. In the owner's emulator log a QtMultimedia load failure made
  `HalAlarmPopup` itself fail ("Type HalImage unavailable"), removing every alarm
  banner. A GIF-only banner now also keeps its stock colour and text until its
  media has actually decoded.
- **Native screen fallback.** If no screen marker reports, the popup uses the
  dash application's own screen containers to identify the active screen (see
  [Show an alarm on selected screens](#show-an-alarm-on-selected-screens)).
- **The `fail.pcapng` flash, decoded.** Every resource reached the dash intact
  and its two mode-switch error replies also occur in a stock Haltech update; see
  the [capture analysis](MEDIA-RUNTIME-AUDIT.md#what-the-2026-10-29-flash-capture-shows).

## Install the matching pair

Extract the new native-integration test ZIP into a new directory and use
its setup script with the official NSP install as the source:

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\setup-native-media.ps1 `
  -NspInstall 'C:\Program Files (x86)\Haltech\Nexus Software\Haltech NSP' `
  -Destination "$env:USERPROFILE\Downloads\NSP-native-media-alerts"
```

Use the **new DLL and new alerts NEX together**. The earlier splash NEX does
not contain the new popup component. No firmware is flashed automatically.
See the included [startup guide](SPLASH-TEST.md) for the emulator COM pair,
Qt runtime setup, GIF/MP4 splash tests and physical-validation boundary.
Qt libraries are downloaded from the pinned official archives, not redistributed.
The included map is an optional diagnostic example; use a backup of your own map
for acceptance testing. Do not mix this DLL/NEX pair into an older test bundle.

## Configure alerts in NSP

1. Disconnect the physical dash. Open a backup iC-7 v2.36 map in the new NSP.
2. Open the editor: click **Appearance...** below the Message
   setting on an alarm's page, right-click the alarm in the tree and choose
   **Appearance...**, or use **Alarm appearance...**
   from NSP's main menu. The first two preselect that alarm.
3. Opening from an alarm page/tree edits that alarm only, keeps other alarms'
   appearances intact and locks the Message column. No manual matching is needed
   in this contextual editor. The bulk menu editor still matches the exact,
   case-sensitive text received by the stock popup:
   the alarm's **Message** setting, not its tree name. If its runtime text
   differs, enter that exact text instead. Applying appearance binds a uniquely
   named alarm to its native Message setting ID, so later Message edits and
   setting undo/redo retain its appearance without manually renaming an override.
   Older manifests acquire this binding when applied in the new editor. Alarms
   with identical Message text still share an unbound text-based appearance.
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
6. **Apply**, or **OK**, updates the map's working resources and renderer cache,
   then requests NSP's existing native preview refresh. Changed media marks the
   map modified using NSP's normal save/close prompt. **Cancel** discards unapplied
   appearance edits; images imported into the library remain there, as with the
   normal image picker. Save/Save As normally to retain the map on disk;
   no separate resource save, mandatory new filename or desktop reopen is needed.
   Editing does not silently upload to a connected physical dash: explicitly tick
   **Also upload to connected dash** when wanted. Otherwise use the normal map
   resource upload. Transfer errors are shown, not reported as success.
7. The updated popup reloads its manifest on native property/repaint/alarm updates.
   Unchanged updates retain the existing GIF instance instead of restarting its
   animation. **Stock background** keeps placement but removes the custom
   media; **Remove override**, followed by Apply, restores the
   stock bottom-stacked placement for that alert.

The screen-aware integration build is in `build-cfw-screen-alarms-236`.
The original owner-confirmed videofix bundle is unchanged; the new `HalImage.qml`
adds transparent screen tracking while retaining its media playback logic.
This build still needs Windows acceptance testing of the actual
native refresh/renderer-pipe path. A physical dash needs the matching updated
popup and transferred resources; desktop hot reload alone does not establish
hardware hot reload or authorize flashing.

By default the GIF is the banner background and the warning text is drawn
over it. Tick **GIF only (hide text/banner)** for an alert to show only the GIF
inside its rectangle: the coloured stock banner and the text are hidden (the
editor preview shows a dashed outline). GIF only needs a GIF or image source.
If that media fails to load on the dash, the stock coloured banner and warning
text come back automatically, so an alarm is never invisible. Older manifests
without this setting keep the text. Alarm
colours, alarm activation, priority/order, clear/acknowledgement logic and
LED rules remain controlled by the original application. Choose sufficient
width and contrasting colours so the warning stays readable. Stock
bottom-stacked banners always draw over custom media, and text-only custom
rectangles over custom GIF/image rectangles, so a full-screen GIF (such as
KFC LIMITER) never hides another active warning, whatever order the alarms
arrive in. Avoid overlapping custom rectangles of the same kind: those keep the
application's model order.
The popup remains above ordinary dashboard components and below startup media.
Invalid configuration logs an error and keeps stock warning banners; a failed
GIF decoder logs an error while the warning text/background remain.

Without a screen restriction, placement applies wherever that alarm normally
appears, across screen changes. This does not create a new alarm engine.
Unconfigured alerts keep their original bottom-stacked layout; other dash
variants do not use the custom rectangle manifest.

## Show an alarm on selected screens

In **Alarm appearance...**, set **Screens (All or 1, 3, 5)** to `5` for
**KFC LIMITER**. Use `1, 3, 5` for multiple screens or `All` to restore global
visibility. Screen numbers are the same one-based numbers shown in NSP.
The map must contain every selected screen. Apply and save normally.
Old manifests without `screens` retain global visibility.

The restriction hides the entire popup row, not just its GIF. An already-active
alarm appears when entering an allowed screen and disappears when leaving it,
without waiting for a new alarm trigger or reloading the manifest. Native
triggering, clearing, acknowledgement, priority and LED behaviour are unchanged.
For example, KFC LIMITER can show its full-screen GIF only on screen 5 while
Low Oil Pressure continues to show on every screen.

The stock executable does not export its selected screen to QML. Applying the
first restriction therefore installs a transparent 1 x 1 image component in one
unused component slot on each configured screen, with zero day/night opacity.
These managed `ic7_screen_1.png` through `ic7_screen_5.png` resources report
the native screen container's visibility directly, without a polling timer or
an executable patch. Existing components are not overwritten. If a screen is
full, Apply reports an error before changing any marker settings. Do not edit
or move these bridge components. After copying/replacing a screen layout or
adding screens, reapply alarm appearance to repair/recreate the bridge.
Removing all restrictions leaves the harmless bridge components in place.

On the first Apply, disconnect the physical dash or explicitly select **Also
upload to connected dash**, because the bridge requires ordinary map-setting
changes as well as image resources. On a dash, transfer both map settings and
resources using the matching screen-aware DLL and resource-only NEX. A JSON-only
edit cannot add this feature to an older renderer. The native emulator uses the
same QML; its synthetic preview also receives the selected preview screen.
If no marker reports, the popup falls back to the dash application's own
screen containers. The v2.36 `UIMain` constructor always creates five unnamed
`UIScreen` containers under the QML root before `Alarm_Module` adds the popup,
and switches screens by `QQuickItem::setVisible` on them
([disassembly](analysis/screen-switching.s)). So a marker removed by editing a
screen layout does not silently break the restriction. The markers stay the
primary source; both observe the same native visibility change.
If neither identifies the screen, restricted alarms remain visible and QML
logs a warning rather than silently hiding a potentially important warning.
Windows native operation and physical-dash acceptance still require testing.

## Place ordinary GIF/MP4 screen elements

Use the existing image component on the desired screen, choose the GIF/MP4 in
the image library, and use NSP's existing canvas drag/edge-resize controls or
component X/Y and size settings. Those settings are already per-screen and
persist in the map. This candidate reuses that editor rather than introducing
a second incompatible screen-layout format. Reserved media PNG aliases retain
the working videofix behavior. Alert banners remain overlays, not ordinary
screen components.

## Test on the Windows emulator

Use the `ic7-emulator` folder of the final Windows test kit.
Open an iC-7 map once in the new NSP copy to stage its Qt add-ons; close its
renderer. Run `.\start-workbench.cmd`; **Dash Display** opens automatically on
Windows. Do not start a second `start-stock-renderer.cmd` alongside it.
When NSP transfers the NEX, the emulator installs every member of it as the
dash watchdog does; see `ic7-emulator\README.md` (**Dash fidelity**).
It requires the matching Qt 5.11 x86 multimedia/GIF add-ons and DirectShow
`dsengine`; missing dependencies are explicit errors. Upload map settings from
NSP: the display must remain blank until those settings arrive.

**The emulator mirrors NSP's live-data input, not its rendered frames.** While this NSP is
open, it publishes the same live-data block it sends to its own dash renderer
(read-only, local shared memory `HaltechNSP_iC7_LiveData`). The workbench's
**Dash Display** window applies that block to the original renderer,
so NSP's **Simulate** panel (or live data) can drive the matching popup
with the same map/resources. The bridge polls independently at roughly 50 ms;
it does not synchronize frames, GIF clocks or clearing instants. Exact
simultaneous NSP/emulator display remains unresolved. Its console prints
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
alerts. This exercises the shared popup and GIF/rectangle manifest over the
emulator HTTP resource API. It does **not** trigger a real threshold, modify
device settings, or validate alarm evaluation/acknowledgement. The normal stock
renderer path remains separate. Test a real alarm condition and its clearing
on the Windows renderer before any separately authorized bench test.

Repeat startup with GIF and MP4, reboot twice, then test an alert GIF, a static
alert image, an empty source, and removal of the override. Reopen the saved map
and re-upload to check persistence. Open the channel selector to verify the
resourcefix GUI fix remains present. Check ordinary screen positioning and
switch screens while alerts are active.

## Integrity and automated verification

The resource-only NEX changes only `main.qml`, `HalImage.qml` and
`HalAlarmPopup.qml`, adds `HalSplash.qml`, and preserves all **336** other
decoded stock members. Its original 44-byte wrapper and migration HDEF are
byte-identical. Application, kernel, bootloader and kernel-logo tooling are
unchanged. The earliest kernel logo remains static.

Build with `scripts/build-nsp-gif-preview.py --splash --alerts --label
screen-alarms` and a new output directory; package with
`scripts/package-nsp-media-test.py --native-media --splash --alerts`. Audit a
candidate independently with `scripts/audit-nex.py --candidate <nex> --sysroot
<extracted dash rootfs>`. The audit compares the package with stock and checks
every QML import against the dash's installed Qt modules. The current candidate's
report is `build-cfw-screen-alarms-r3-236/audit-report.json`. The audit
also rejects any changed or added QML member that reuses a stock (or zero) mtime. The included
map is the supplied one, byte-for-byte.

Checks include .NET compilation and manifest validation, stock-root/alert hash
guards and cache removal, resourcefix byte equality, decoded NEX member
equality, real desktop and firmware Qt 5.9.6 ARM GIF animation/geometry/clearing,
repeated GIF/MP4 startup, and an actual HTTP-to-QML alert preview screenshot.
These checks do not prove Windows plugin loading, hardware installation,
physical alarm behavior, or a recovery method. Retain the working NEX, back
up the map and establish recovery before any bench flash; do not test while
driving.

Verified locally for the current candidate: x86 DLL build with zero compiler
errors (404 existing decompilation warnings), referencing the same 52 assemblies
as the shipped DLL with nothing removed; **46** Python/.NET regressions (8 need
PowerShell and were skipped); **76** desktop Qt 5.15 QML checks, including
painted splash pixels and a stock banner painted over a full-screen alarm GIF;
**68** QML checks on the dash's own Qt 5.9.6 under QEMU, including
markerless native screen switching, alarm z-order in both model orders, a
missing QtMultimedia, a splash that survives a 4.5 s blocked startup, and
components loaded from scheme-less absolute paths as the application loads
them; **132** emulator Python tests with real PyQt5; and an independent
NEX audit with no findings. ZIP hashes and all packaged QML bytes are
checked against the tested sources. Windows Forms editor interaction remains
an on-PC validation step, not a result of the Linux cross-build.
