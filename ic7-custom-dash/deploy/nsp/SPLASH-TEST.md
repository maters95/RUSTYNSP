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

## Fix from the 2026-10-29 physical flash

On the dash, the GIF and MP4 splash and the alert GIFs did not appear, while the
OEM and static splash worked. Static and OEM splash use NSP's stock kernel-logo
path, not these components. Cause: the components looked for
`user_resources/images` **three** folders above `user_components`. That is the
layout of NSP's Windows renderer, where `user_resources` sits beside
`qml_components_data`. On the dash, QML lives in
`/opt/applications/dtn/resources/qml_components_data` and user images in
`/opt/applications/dtn/user_resources/images`, **four** folders up. The
application's own `UIComponent::image_src_to_path` uses
`../../../../user_resources/images/`. Both manifests were therefore never
found, and the dash silently kept stock behaviour. Uploads were not the
problem: the dash's resource write path stores `.json`, `.gif` and `.mp4`
without an extension check.

This also explains why the decoders were never the problem: the owner's
2026-10-28 flash of the videofix NEX played GIF and MP4 on this same dash through
`HalImage.qml` ([baseline](../DESIGN-POSSIBILITIES.md#working-baseline-owner-report-2026-10-28)).
`HalImage` works because the application hands it a correct path; the splash and
alert components built their own. NSP's map sync (`Form23.method_226`) uploads
every file in the map's resource folders, unfiltered, and the dash's index never
lists `.json`/`.gif`/`.mp4`, so these are re-sent on each sync. That is
harmless; the files arrive by either route.

The components now look in the dash location first and fall back to the
Windows layout. A new test runtime reproduces the dash's real
`/opt/applications/dtn` tree. The previous components fail it on both splash
and alerts, matching the flash result; the fixed ones pass on desktop Qt and on
the dash's Qt 5.9.6 under QEMU. Reflash with this kit's NEX.

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
- A GIF splash is decoded with QtQuick's own GIF support. Only an MP4 splash
  loads the shared `HalImage.qml` video player. If QtMultimedia cannot load,
  a GIF splash still plays and an MP4 splash is skipped with a logged error.

## Where the splash is drawn

Stock NSP converts a static splash by fitting it into the **physical
800 x 480 panel**, centred on black, keeping its aspect ratio and never
upscaling a smaller image (`Form23.smethod_24` with `Class25.smethod_1`). The
animated splash now follows the same rule. On the dash, `main.qml` squeezes
its 860-wide canvas by 800/860, so the splash lays media out in panel pixels
and reverses that squeeze.

| Source | Earlier candidate on the panel | Now |
| --- | --- | --- |
| 800 x 480 GIF (your current splash) | 744 x 480, black bars and horizontal squash | full 800 x 480, pixel-exact |
| 860 x 480 GIF | full width, squashed like dash backgrounds | 800 x 446, correct aspect |
| 320 x 160 GIF | scaled up | 320 x 160, centred like stock |

MP4 splash keeps aspect ratio in the same panel area; unlike the GIF and
static paths, a smaller video is still scaled up to fit. NSP's Windows renderer
does not squeeze its canvas, so there an 800 x 480 splash shows narrow black
side bars; that preview difference is expected.

The desktop renderer uses the same three QML files as the NEX. Startup QML
overrides are hash-guarded against the verified v2.36 baseline, and stale
compiled caches are removed. A mismatched component produces a startup error.

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
   and select it. Save the map under a new name. Apply/upload to the emulator.
2. Trigger the existing **Reboot** action in NSP. Confirm a fresh GIF splash,
   followed by the dashboard within 3.3 seconds.
3. Repeat with `samples/video.mp4`; confirm moving, muted video and handoff.
4. Repeat the reboot twice, then close/reopen the saved map and repeat upload.
5. Select a static PNG and apply. Confirm animated startup is disabled and the
   stock static splash workflow is still used.
6. Confirm gauges, screen changes and alarms still work after handoff.
7. Open the channel selector and affected configuration panels to confirm the
   resourcefix GUI behavior is retained.

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
pass; and 18 focused Python/.NET regression tests pass. The later screens
candidate adds panel-geometry and missing-multimedia checks, run on both
desktop Qt and the firmware's Qt 5.9.6 under QEMU; see the
[alert guide](ALERTS-TEST.md) for its totals. Production root-QML
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
