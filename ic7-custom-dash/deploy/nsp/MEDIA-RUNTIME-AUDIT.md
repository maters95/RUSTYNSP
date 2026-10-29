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

- Its `NSP-test/NSP.dll` matches the maintained rebuild output, SHA-256
  `5f726f93fa67fefa95ded5a8670ad79a715bd0998e34ae61e913586e87b12478`.
- Its `firmware/HalImage.qml` matches the maintained media component, SHA-256
  `8c9f2fc49765471e115053a7a50a7efb4453a5545bcdd4e36782ca42ee64d6c7`.
- The decoded NEX resource archive has 339 members. Only
  `qml_components_data/qml/user_components/HalImage.qml` differs from stock.

## Actual v2.36 Startup Splash Path

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