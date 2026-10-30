# Experimental iC-7 startup-media test

This bundle extends the owner-confirmed videofix baseline. Keep that working
bundle and your original map unchanged. This candidate has automated desktop
tests, not physical cold-boot validation.

The DLL also retains the **resourcefix** bundle's Windows form-resource
corrections, including the channel selector's
`EnumConverter cannot convert from System.Byte[]` fix and the existing binary
image-list resource. Regression checks compare every embedded resource from
that bundle byte-for-byte and verify the startup QML resources are present.
Use this combined splash build rather than copying the older resourcefix DLL
over it, which would remove startup-media support. No reflash is needed for
the Windows resourcefix alone.

## What it changes

- The rebuilt NSP DLL preserves selected GIF/MP4 splash bytes, uploads them
  through the existing image-resource service, and writes a small
  `u/ic7_splash.json` selection manifest. Offline splash selection saves the
  manifest into the map's user resources for the next normal map upload.
- The resource-only NEX retains the working `HalImage.qml`, replaces the stock
  root QML, and adds `HalSplash.qml`. It leaves the application executable,
  kernel, bootloader and existing kernel-logo tools unchanged.
- Startup media plays muted over a black background for at most **three
  seconds**, then its player is destroyed and the normal dash is revealed.
  Missing configuration skips the overlay; invalid configuration/media is
  logged and releases it. Gauges continue loading underneath.
- **This is the Qt/application stage of startup.** The earliest kernel logo
  remains static. It is not GIF/H.264 decoding inside the kernel. A GIF/MP4
  selection does not write media bytes into the fixed-size BMP/kernel path.
- Choosing a static splash disables the animated overlay and retains NSP's
  existing static BMP upload. Other products retain their original workflow.

The desktop renderer uses the same three QML files as the NEX. Startup QML
overrides are hash-guarded against the verified v2.36 baseline, and stale
compiled caches are removed. A mismatched component produces a startup error.
On the dash, the NEX gives each replaced QML file a new modification time so
Qt 5.9.6's QML disk cache cannot keep serving the stock `main.qml`
([cache audit](MEDIA-RUNTIME-AUDIT.md#stale-qml-disk-cache-on-the-dash)). The
application builds its screens and alarm popup after loading `main.qml` and
before its event loop runs; the splash's playback countdown restarts when its
manifest arrives, which a QEMU test shows happens after such a block, so a slow
startup does not cut the splash short.

## Where the splash is drawn

Stock NSP converts a static splash by fitting it into the **physical
800 x 480 panel**, centred on black, keeping its aspect ratio and never
upscaling a smaller image (`Form23.smethod_24` with `Class25.smethod_1`). The
animated splash follows the same rule. On the dash, `main.qml` squeezes its
860-wide canvas by 800/860, so the splash lays media out in panel pixels and
reverses that squeeze.

| Source | Before | Now |
| --- | --- | --- |
| 800 x 480 GIF (your current splash) | 744 x 480, black side bars and squashed | full 800 x 480, pixel-exact |
| 860 x 480 GIF | full width, squashed like dash backgrounds | 800 x 446, correct aspect |
| 320 x 160 GIF | scaled up | 320 x 160, centred like stock |

PNG/JPEG and GIF splashes decode with QtQuick only; just an MP4 splash loads
`HalImage`'s video player, so a QtMultimedia failure can no longer blank a GIF
splash. An MP4 keeps its aspect ratio in the same area but, unlike the stock
rule, a smaller video is scaled up. NSP's Windows renderer does not squeeze its
canvas, so there an 800 x 480 splash shows narrow side bars; that is expected.

## Set up the new desktop NSP copy

Close NSP and all renderers; disconnect the physical dash. Extract the whole
bundle. Use the existing native-media setup script, with a NEW destination:

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\setup-native-media.ps1 `
  -NspInstall 'C:\Program Files (x86)\Haltech\Nexus Software\Haltech NSP' `
  -Destination "$env:USERPROFILE\Downloads\NSP-native-media-splash"
```

This downloads the same pinned official Qt 5.11.3 x86 add-ons as videofix.
Qt libraries are not redistributed here; the setup downloads official archives.
See [Qt source](https://download.qt.io/archive/qt/5.11/5.11.3/single/) and
[Qt open-source licensing](https://www.qt.io/licensing/open-source-lgpl-obligations).
Do not replace files in the official install or run official and test NSP
simultaneously: the native-renderer cache under AppData is shared.

## Test with the updated desktop emulator first

Use the separately supplied `ic7-emulator-windows-nexmap-splash.zip` bundle
and its README. Keep it separate from the NSP bundle.
From its extracted folder, run `.\start-workbench.cmd`, then
`.\start-stock-renderer.cmd` in a second terminal. Connect NSP to the other
end of the configured virtual COM pair. **Preview only** is not the native
renderer test.
First open an iC-7 map in the new NSP copy once so its shared AppData runtime
receives the matching Qt media add-ons, then close that NSP renderer before
launching the emulator renderer. Missing multimedia dependencies are reported
explicitly. Do not select the emulator's legacy GIF-only component override.
Start a fresh session with no map; the virtual panel should remain black.
Open the included copy of your map in the new NSP copy, then apply/upload it
to the virtual device. Loading a map in NSP and uploading settings to the
emulator are distinct events; the emulator cannot observe a file-open action
in a different Windows process without NSP communicating it.
The emulator recognizes the first NSP write overlapping a dashboard-component
setting; it does not have a separate whole-map-upload-complete signal.

1. In NSP's existing splash resource selector, import `samples/animated.gif`
   and select it. The startup manifest is stored in both the working map and
   NSP's renderer resource cache. Save/Save As normally; upload the resources
   to the emulator. No desktop map reopen is required to persist the selection.
2. Trigger the existing **Reboot** action in NSP. Confirm a fresh GIF splash,
   followed by the dashboard within 3.3 seconds.
3. Repeat with `samples/video.mp4`; confirm moving, muted video and handoff.
4. Repeat the reboot twice, then close/reopen the saved map and repeat upload.
5. Select a static PNG and apply. Confirm animated startup is disabled and the
   stock static splash workflow is still used.
6. Confirm gauges, screen changes and alarms still work after handoff.
7. Open the channel selector and affected configuration panels to confirm the
   resourcefix GUI behavior is retained.

Clearing the startup-image setting now also disables the animated manifest.
It does not modify the early kernel logo or automatically flash anything.
Startup playback itself is still a reboot-time action, not an alarm preview.

The bundled user map is included byte-for-byte, not edited or preconfigured
with a new splash. The samples provide small deterministic baselines; start
with them before trying larger media. MP4 codec support remains the same as
the working screen component.

Emulator reboot and rendering are protocol/UI simulation, not execution of
the physical updater, kernel-logo writer or a complete i.MX6 boot. A passing
emulator test does not establish physical boot timing, installation or recovery.

## Physical validation boundary

The firmware candidate changes more resource members than videofix. Back up
the working map and retain the exact working NEX. Establish a recovery method
before a separately authorized bench flash. No script in this bundle flashes
or connects to a physical dash automatically. Test only on stable bench power,
not while driving. A stock-resource package is not guaranteed recovery if the
main application no longer provides NSP connectivity.

## Reproduce the build and automated checks

From the repository root, with the existing .NET, Python codec and Qt test
dependencies installed:

```sh
dotnet build nsp-rebuild/NSP.csproj -c Release \
  -p:EnableWindowsTargeting=true -p:NoWarn=WFO1000
python scripts/build-nsp-gif-preview.py \
  --stock-nex fw/Dash-V2-36-0-Release.nex \
  --reference fw/opt/dtn/app/dash_watchdog \
  --component ic7-custom-dash/deploy/nsp/HalImage.qml \
  --splash --label native-media-splash --output /tmp/ic7-splash-candidate
bash scripts/test-nsp-image.sh
IC7_SYSROOT=/path/to/stock/sysroot bash scripts/test-nsp-image.sh
python -m unittest scripts.tests.test_nsp_splash_media \
  scripts.tests.test_nsp_native_renderer scripts.tests.test_nsp_media_resource \
  scripts.tests.test_nsp_packaging
```

The NEX output directory must be new. Packaging uses
`scripts/package-nsp-media-test.py --native-media --splash`, with
`--media-nex`, `--build-report`, `--nsp-dll`, `--output`, and optionally
`--test-map` pointing at an existing map. The map is authenticated with the
existing inspector and included unchanged, never rewritten.

Verified locally: the x86 DLL builds with zero compiler errors; 25 desktop
QML checks pass (including rendered media pixels); 21 ARM Qt 5.9.6/QEMU checks
pass; and 18 focused Python/.NET regression tests pass. Production root-QML
tests exercise the real relative resource paths and repeated startup/handoff.
The decoded candidate preserves all 337 other stock resource members and the
original resource wrapper. Windows GUI operation and physical startup timing
still need the desktop/bench checks above.

The emulator additionally passes 88 Python tests using real PyQt5, browser
checks and ZIP integrity checks. Its staged renderer uses the exact shared
QML, tested with real Qt 5.15 GIF/MP4 playback, muting, unloading and two
startups per format. The selected manifest survives playback and repeated
reboots; no dashboard background is silently substituted. These Linux checks
do not establish Windows Qt 5.11 renderer operation. Run the Windows
emulator/NSP sequence before any physical test.
