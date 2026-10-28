# iC-7 GIF, MP4 and Offline Map Testbed

This testbed exercises three separate paths. It does not install firmware on a
physical iC-7 and does not turn the NSP component catalog into a new component
system.

## Files

- `zak-2.36-mapfix-media-picker-uservideo.nexmap`: based on the saved 2.36
   map, preserving all 37 original entries and `_map` settings. Adds the user's
   H.264 MP4 bytes under `ic7_video_probe.png` only, keeping the map compact.
- `ic7dash-arm-bundle.tar.gz`: standalone ARM/Linux custom-dash demo with 294
  offline map tiles, simulated GPS lap timing, and the existing CAN config.
- `CROSS-BUILD.md`: ARM/QEMU run and GPS setup notes.

The NSP Add Component window is a component catalog, not the media file picker.
Keep the existing Image component; use its **Image Source** setting. The HDEF
limits that resource picker to PNG/JPG/JPEG/BMP extensions. The saved map already
contains `u/ic7_animation_probe.png`, which is GIF bytes and previously survived
NSP save. The new `u/ic7_video_probe.png` uses the same extension workaround for
MP4, but its visibility, selection, save, and transfer through NSP still need
Windows testing. The map probe intentionally does not change `_map`, so NSP
keeps its valid checksum until you select a source and save a new map.

The PNG alias exists because the stock Image Source resource picker allows PNG,
JPG, JPEG and BMP names but not MP4. The patched `HalImage.qml` recognizes the
specific `ic7_video_*.png` alias and gives its bytes to Qt Multimedia. The alias
is MP4 data, not a PNG image. This media map leaves `_map` unchanged so NSP can
calculate a valid settings checksum itself when you save a changed selection.

## Test with NSP and the COM11 sandbox

1. Extract **all** files from `ic7-gif-only-mapfix.zip` into one folder;
   keep the `.nex`, `HalImage.qml`, and `build-report.json` together. The
   workbench uses the report hashes to decide whether it can activate the
   matching component for its isolated stock-renderer preview. Keep the
   physical dash disconnected. Start the updated workbench, select that
   extracted HDEF-assisted GIF-only NEX, select COM11, and start a session.
   NSP should use COM10. This first candidate avoids a QtMultimedia import;
   use the combined GIF/MP4 archive only for the separate MP4 test.
2. In NSP, open `zak-2.36-mapfix-media-picker-uservideo.nexmap` as a map. The map
   already has the previously tested Image component at
   `SCREEN_1_COMP_21_IMAGE_SRC`; use its **Image Source** setting instead of
   adding a new component.
3. Select `u/ic7_animation_probe.png` to test the existing two-frame GIF alias,
   or select `u/ic7_video_probe.png` to test the MP4 picker workaround. Save
   the edited map under a new filename so NSP writes its own settings checksum.
4. Apply/upload that saved map to the virtual dash through NSP. In the workbench,
   confirm the component is active in the Update tab and the GIF resource
   appears under Resources. The capture must include resource operation 6
   (upload); operations 1/2 alone mean only count/descriptor listing. If
   `component_available` or `component_active` is false, stop and fix the NEX
   sidecar selection before judging GIF behavior. If NSP warns that it
   disconnected while settings were being written, treat that map save/upload
   as incomplete and reconnect before retrying.
5. For GIF playback, start the private stock renderer from the workbench after
   the component candidate is active and the changed map resource has uploaded.
   For MP4, the private Windows NSP runtime
   must contain QtMultimedia; otherwise use the separate ARM Qt 5.9.6 test below.
   The workbench's resource preview can open MP4 in the default browser, but
   that is not proof the NSP renderer plays it.

Do not click **Upgrade Firmware Now** on a physical dash. The COM11 sandbox only
confirms transport and a return-to-main event; it does not execute target-side
resource decryption or prove a real flash.

## Test the supplied MP4 on Qt 5.9.6

On the Linux build environment with the local ARM sysroot and QEMU:

```sh
cp "ic7-custom-dash/test-assets/Android Auto Screen (phone).mp4" \
  ic7-custom-dash/build-nsp-tests/ic7_video_probe.png
qemu-arm -L "$HOME/ic7build/sysroot" \
  -E QT_QPA_PLATFORM=offscreen -E QT_QUICK_BACKEND=software \
  -E QT_PLUGIN_PATH="$HOME/ic7build/sysroot/usr/lib/plugins" \
  -E QML2_IMPORT_PATH="$HOME/ic7build/sysroot/usr/lib/qml" \
  "$HOME/ic7build/sysroot/usr/bin/qmltestrunner" \
  -input ic7-custom-dash/deploy/nsp/tests -o -,txt \
  NspImageCompatibility::test_mp4PngAliasPlaybackAndPause
```

The actual 1080p H.264 video passed this alias test under QEMU. This confirms
software playback on the Qt 5.9.6 userspace only, not i.MX6 hardware decode or
physical-panel performance.

## Test the offline road map and GPS lap timer

`ic7dash-arm-bundle.tar.gz` is a separate Linux ARM application, not an NSP
`.nex` and not a drop-in modification to stock iC-7 firmware. Its map uses the
294 bundled offline tiles; its PC/QEMU demo uses simulated GPS by default. A
real receiver requires USB/serial NMEA input. See `CROSS-BUILD.md` for its
runtime assumptions and bring-up notes. This binary has passed QEMU tests but
has not been run or installed on the physical dash.
