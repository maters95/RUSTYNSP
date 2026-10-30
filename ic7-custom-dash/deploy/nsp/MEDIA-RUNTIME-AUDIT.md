# iC-7 GIF/MP4 Runtime Audit

The original runtime audit inspected the rootfs archive
`fw/swu_nsp/var-image-swupdate-var-som-mx6.tar.gz` and the stock ARM
`fw/opt/dtn/app/dash_application` binary. That application is the older SWU
baseline, **not** the application shipped in the v2.36 NEX. Use the decoded
`nic-7` stage from `fw/Dash-V2-36-0-Release.nex` for v2.36 application analysis.
No firmware files were changed during either investigation.

## Confirmed Working Baseline

The owner reported successful GIF and MP4 playback on the physical dash using
`NSP-native-media-videofix` and the NEX inside
`dist/ic7-nsp-native-media-test-2.36-videofix.zip`. This is owner-confirmed
screen playback, not evidence that an animated startup splash works.

Offline comparison of that exact ZIP confirmed:

- At the time of the screen-playback audit, its `NSP-test/NSP.dll` matched
  the maintained rebuild output, SHA-256
  `5f726f93fa67fefa95ded5a8670ad79a715bd0998e34ae61e913586e87b12478`.
- Its `firmware/HalImage.qml` matches the maintained media component, SHA-256
  `8c9f2fc49765471e115053a7a50a7efb4453a5545bcdd4e36782ca42ee64d6c7`.
- The decoded NEX resource archive has 339 members. Only
  `qml_components_data/qml/user_components/HalImage.qml` differs from stock.

### Subsequent native integration build

The videofix ZIP was decoded and compared against stock again before the native
integration work. The maintained `HalImage.qml` still matches that exact
owner-confirmed component. The new DLL adds native contextual alarm appearance
editing, normal map-modified/save handling, Message-setting bindings and native
preview-refresh notification. Atomic manifest/cache writes avoid partial reads;
unchanged media is not rewritten while the renderer may hold it open.

The separate resource-only candidate in
`build-cfw-native-media-alerts-integration-236` retains 336 stock archive members,
changes `HalImage.qml`, `main.qml` and `HalAlarmPopup.qml`, and adds `HalSplash.qml`.
It retains the stock HDEF and resource wrapper and does not replace the app,
kernel, bootloader or STM32 code. Older working packages are not overwritten.
Hot-reload component tests include updating a manifest at the same path without
recreating the popup and retaining active GIF instances across native updates.
ARM/QEMU Qt tests do not establish Windows GUI acceptance, exact simultaneous
emulator output, physical flashing or cold-boot safety.

### Screen-scoped alarm extension

The screen-aware candidate extends `HalImage.qml` with a reserved transparent
marker path; ordinary GIF/MP4 playback logic is retained, but this component is
no longer byte-identical to the owner-confirmed videofix baseline. Native
v2.36 `UIMain::handle_screen_change` (`0x00116a14`) switches screen containers
through `UIScreen::set_visibility` (`0x00117f20`). The bridge uses inherited QML
visibility changes on explicitly numbered marker images, not inferred container
ordering or the old SWU application's layout. The application executable, HDEF,
bootloader, kernel and alarm engine remain unchanged. A missing bridge fails
visible and logs a warning. See the [screen-scoping instructions](ALERTS-TEST.md).

## Actual v2.36 Startup Splash Path

### Real-device resource-path correction

The 2026-10-29 `fail.pcapng` capture contains an exact 17,397,760-byte
transfer of the screen-alarm candidate's encrypted resource body. It also
contains successful resource-RPC acknowledgements for the splash GIF and
manifest, followed later by the KFC GIF and its screen-5-only manifest.
This proves transfer, not target-side installation or cold-boot success.

The actual v2.36 binary names QML under
`/opt/applications/dtn/resources/qml_components_data/qml` and user images under
`/opt/applications/dtn/user_resources/images/`. From a user-component QML file,
the latter needs **four** parent traversals, not the Windows preview's three.
The earlier splash and alarm components incorrectly used the Windows path on
the dash, preventing their manifests from being found. Both now select the
appropriate relative path from the component's resource-directory layout;
manifest and media URLs share one base. This also preserves Linux-hosted
desktop-layout emulator tests without pretending that they use the dash layout.
Stock-image paths are unchanged.

The old integration fixture also used the Windows layout on Linux. Moving it
to the dash's `resources/qml_components_data` layout reproduced the startup
failure before the fix. Tests now load default splash/alarm URLs in that layout,
including decoded PNG/GIF media and an active alarm moving onto/off screen 5.
ARM/QEMU success still does not verify physical installation or kernel-logo
behaviour. Static splash selection in NSP continues to use its stock BMP/kernel
workflow; a PNG tested as Qt-stage media is not a test of that kernel workflow.

Loose QML files next to a packaged NEX are hash-checked emulator/reference
sidecars. The dash receives the QML inside the NEX's encrypted resource archive;
the loose copies do not need to be copied separately to the dash.

The subsequent surgical review additionally confirmed in the decoded v2.36
binary that `UIScreen` constructs a `QQuickItem` container, parents it to
`QQuickView::rootObject()` (`0x001188f0` / `0x001188fc`), and changes its
visibility with `QQuickItem::setVisible()` (`0x00117f20`). Component reload
parents the QML item to that container (`0x0010ef68` / `0x0010ef70`).
Thus the screen marker's visual-parent traversal and inherited visibility have
a native-code basis; they are not established solely by a fabricated test tree.
This still does not verify installed components on the physical dash.

Desktop tests now assert PNG/GIF pixels actually paint over the splash
background and that GIF pixels change, in addition to decode status. ARM Qt
5.9.6/QEMU offscreen tests verify paths, decoding, timing and screen logic only:
its image-grab API returns black even for an independent plain red rectangle.
The desktop pixel tests are not reported as ARM pixel verification.
Black on the physical display alone does not establish that `HalSplash` was
visible: the kernel-logo path is separate, and no display/console output is
present in the USB capture.

The decompiled NSP and the actual v2.36 application establish this chain:

1. [Class237.cs](../../../nsp-rebuild/ns5/Class237.cs) adds GIF/MP4 extensions
   to Image resource pickers; [Form40.cs](../../../nsp-rebuild/ns4/Form40.cs)
   preserves imported media bytes and handles the splash-picker preview too.
   The picker is not the final splash uploader.
2. [Form23.cs](../../../nsp-rebuild/ns4/Form23.cs), `smethod_24`, separately
   renders the selected splash into a static BMP. `smethod_25` uploads it to
   address space 43 (`0x70400000`), then `smethod_26` polls completion.
3. In the NEX's decoded `nic-7` ELF,
   `data_manager::dash_firmware_spaces::dash_splash_image_write`
   (`0x000ef714`) writes the input to
   `/opt/applications/dtn/resources/upgrade_files/splash.bmp`. It starts the
   asynchronous apply operation when the upload reaches the expected size.
4. `splash_screen::get_splash_size` (`0x00089820`) returns **1,152,054 bytes**
   for iC-7 variant 11: an 800x480, 24-bit BMP plus its 54-byte header.
   A shorter GIF/MP4 would not trigger the same completion branch merely
   because the DLL sent its bytes unchanged.
5. `splash_screen::apply_splash_image` (`0x00089890`) invokes the resource
   `bmptopnm` tool to produce `splash.ppm`, then calls
   `kernel_patch::KernelPatch::apply_kernel_patch` (`0x00087984`).
6. The supplied `pnmtologo` is a custom **kernel-image patcher**. Its help
   explicitly documents `-p <newlogo>` as replacing the logo in `uImage`,
   alongside GPIO and backlight patches. The application contains the
   argument fragment `-p splash.ppm -t clut224 -o`. This is a Linux kernel
   logo path, not `HalImage.qml` or the generic U-Boot BMP splash.

The exact stock resource archive already includes:

| Member | Bytes |
| --- | ---: |
| `upgrade_files/bmptopnm` | 25,668 |
| `upgrade_files/pnmtologo` | 45,104 |
| `upgrade_files/rc.local` | 512 |
| `upgrade_files/reference_image.ppm` | 2,805,495 |
| `upgrade_files/uImage.src` | 11,862,080 |

The decoded v2.36 application SHA-256, including its package padding, is
`d86bde81820b8b7b5efcfc7466aa994cabeacac6c6bcd725536393ab48687248`.
The older extracted SWU app hashes to
`ccdc0711399696e23e70835110c7aa45cdd6110a7aa78c46d835632761de7219`
and lacks these splash functions. Do not infer the v2.36 splash behavior
from that older ELF or the reference `SplashScreen.qml`.

### Implications For Animated Startup

Modifying the rebuilt DLL and resource-only NEX is the established workflow;
neither stock NSP nor a bootloader replacement is inherently required just to
develop another resource candidate. However, simply bypassing BMP conversion
or changing the picker's extension list does not implement startup playback.
The fixed-size receiver and kernel-logo conversion must also be accounted for.

Reusing Qt's working GIF/MP4 renderer requires a userspace startup stage.
Retaining a static early kernel logo and handing off to animated media once
Qt can run avoids inventing GIF/H.264 support in the kernel logo patcher.
That design still needs selected-media persistence, startup/display ownership,
bounded handoff to the dash, error handling, and cold-boot validation.
It is not implemented or hardware-validated by this investigation. The stock
`rc.local` member only handles bus-frequency power management and backlight
release; it is not an existing media launcher.

## Runtime Components Present

- Qt 5.9.6 Multimedia: `/usr/lib/libQt5Multimedia.so.5.9.6`.
- QML module: `/usr/lib/qml/QtMultimedia/qmldir` and
  `libdeclarative_multimedia.so`.
- Qt GStreamer player service: `/usr/lib/plugins/mediaservice/libgstmediaplayer.so`.
- Animated GIF image plugin: `/usr/lib/plugins/imageformats/libqgif.so`.
- GStreamer MP4 and video path: `libgstplayback.so`, `libgstisomp4.so`,
  `libgstvideoparsersbad.so`, `libgstlibav.so`, and `libgstimxvpu.so` under
  `/usr/lib/gstreamer-1.0/`. The `libgstlibav` binary contains H.264 decoder
  code; the i.MX VPU plugin depends on `libimxvpuapi.so.0`.
- GStreamer plugin scanner: `/usr/libexec/gstreamer-1.0/gst-plugin-scanner`.

The stock dash binary dynamically loads QML components. Ghidra 12.2 analysis
confirmed the component root at
`/opt/applications/dtn/resources/qml_components_data/qml/user_components/`,
the image resource root at
`/opt/applications/dtn/resources/qml_components_data/images/`, and a
`QQmlComponent` load/create path that checks the QML file and logs component
errors. The patched `HalImage.qml` imports `QtMultimedia 5.9`, uses Qt's
`AnimatedImage` for GIF and `Video` for MP4, matching the installed Qt/QML
runtime.

## Verification Boundary

The Qt 5.9.6 ARM QML suite passed 11 tests under QEMU, including GIF frame
advance, MP4 looping, source switching, decode errors and playback position.
The desktop Qt suite passed 15 tests, including comparisons of changing GIF
and MP4 **rendered pixels**. Headless ARM pixel capture is not reliable and is
not represented as a passing physical rendering check.
Those automated checks verify the QML component against the
extracted software stack, not the physical dash. The later owner confirmation
above establishes screen playback for the exact videofix baseline; it does not
establish cold-boot reliability or animated splash behavior. Plugin registry success,
available memory, i.MX6 hardware decode, thermal/performance behavior, and
display integration still require a physical bench test. The NSP modified
source builds; the newer [native media setup](NATIVE-MEDIA-TEST.md) installs
the shared component before NSP's native renderer launches, using the matching
Windows x86 Qt 5.11.3 add-ons. Thirteen focused tests cover component/runtime
staging, the actual assembly manifest resource, NEX equality and offline setup.
Earlier picker-only owner logs established import/save behavior, not native
dash playback or installation; the later owner report supersedes that boundary
for the identified videofix baseline only.

Ghidra's analysis database is under `/tmp/ghidra-projects/IC7Dash`; the focused
decompilation export is
`ic7-custom-dash/deploy/nsp/analysis/media-functions.c`. The reusable export
script is `scripts/ghidra/ExportMediaFunctions.java`. This is a focused
decompilation of the dash application and media/resource paths, not a claim
that every OS binary or all firmware source has been recovered.