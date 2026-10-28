# iC-7 GIF/MP4 Runtime Audit

Audited the firmware 2.36 rootfs archive
`fw/swu_nsp/var-image-swupdate-var-som-mx6.tar.gz` and the stock ARM
`fw/opt/dtn/app/dash_application` binary. No firmware files were changed.

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
This verifies the QML component against the
extracted software stack, not the physical dash. Plugin registry success,
available memory, i.MX6 hardware decode, thermal/performance behavior, and
display integration still require a physical bench test. The NSP modified
source builds; the newer [native media setup](NATIVE-MEDIA-TEST.md) installs
the shared component before NSP's native renderer launches, using the matching
Windows x86 Qt 5.11.3 add-ons. Thirteen focused tests cover component/runtime
staging, the actual assembly manifest resource, NEX equality and offline setup.
Windows Qt plugin loading and canvas playback still need owner testing.
Earlier picker-only owner logs established import/save behavior, not native
dash playback or installation of the new media candidate.

Ghidra's analysis database is under `/tmp/ghidra-projects/IC7Dash`; the focused
decompilation export is
`ic7-custom-dash/deploy/nsp/analysis/media-functions.c`. The reusable export
script is `scripts/ghidra/ExportMediaFunctions.java`. This is a focused
decompilation of the dash application and media/resource paths, not a claim
that every OS binary or all firmware source has been recovered.