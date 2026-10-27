# Map-Based Asset Integration

## Current Result

The supplied `2026-10-26_0134pm.ic7-2-36-0.nexmap` was decoded offline using
the matching NSP source. All 34 AES-ZIP entries authenticated successfully.
It contains the settings XML, a Hero layout, a Diagnostics layout, a pressure
sensor definition, fonts and user images. Each nested `.nexcfg` also decoded;
the layouts contain parameter XML and preview images, not QML source.

The matching v2.36 `.hdef` decoded as well, and all 306 ZIP entries passed
integrity checks. Its actual resource selectors allow `png,jpg,jpeg,bmp`,
not `gif`. The background selector in this map is setting `1048659`, named
`SCREEN_0_COMP_0_IMAGE_SRC`; no value was changed in the test map.

The map checksum is computed from NSP's reconstructed settings buffer, not
simply XML text. Rather than fabricate a replacement checksum, the test map
retains the original `_map`, all embedded definitions and all existing assets
byte-for-byte. Its source SHA256 remains:

```text
29b831dd6a148c630dd304d8eeb4a5d1ccde917b847f26f5152a2e41389cc5fe
```

## Matched Artifacts

Use the newer files in `build-nsp-map/`, not the earlier `build-nsp/` drafts.

- [Asset-only map probe](../build-nsp-map/zak-2.36-map-assets-v2-experimental.nexmap).
- [Map preservation report](../build-nsp-map/zak-2.36-map-assets-v2-experimental.report.json).
- [Matching component candidate](../build-nsp-map/ic7-2.36-gif-preview-experimental.nex).
- [Stock-resource counterpart](../build-nsp-map/ic7-2.36-stock-resources-experimental.nex).
- [Resource build report](../build-nsp-map/build-report.json).

## Windows Round-Trip Confirmed

The owner opened the asset map in Windows NSP and supplied a screenshot of
both the static probe and PNG-extension animation alias in the image picker.
The saved map was returned as the workspace-root
`zak-2.36-map-assets-v2-experimental.nexmap`. It is distinct from the generated
file with the same basename under `build-nsp-map/`.

All 38 returned entries authenticated. The three probe assets, including the
GIF bytes under the PNG extension, are unchanged. The alias still has two
frames and an infinite loop. All other user resources are unchanged as well.
NSP added `BasicRace_860x480_1.0.14.nexcfg` and changed the main settings XML.

The matching v2.36 definition classifies all 1,153 changed settings:

- 1,150 settings are under `SCREEN_4_*` (zero-based screen index 4, UI screen 5).
- Three others are `NUM_SCREENS`, `_SCREEN_4_DASH_SCREEN_CAL_ID`, and
  `_SCREEN_4_DASH_SCREEN_NAME`.
- No changed setting is outside display configuration, and none is unclassified.
- `SCREEN_4_COMP_5_IMAGE_SRC` is `u/ic7_static_probe.png`.
- `SCREEN_4_COMP_6_IMAGE_SRC` is `u/ic7_animation_probe.png`.

Thus Windows import, picker listing, selection, and saved-map asset/reference
preservation are proven. This does not prove live USB resource transfer,
physical animation, or installation of the component patch.
The reproducible comparison is saved under `scratchpad/map-roundtrip/`.

```sh
/home/codespace/ic7build/map-venv/bin/python scripts/inspect-nexmap.py \
  zak-2.36-map-assets-v2-experimental.nexmap \
  --definition fw/ic7_2360.hdef \
  --compare ic7-custom-dash/build-nsp-map/zak-2.36-map-assets-v2-experimental.nexmap
```

## Source-Confirmed Firmware File Chooser

The hash-matched NSP 1.48.5 source does include local `.nex` selection in its
firmware dialog, separate from online firmware discovery:

- `B/BI.cs`: control `PJ`, text resolved as **Open File Browser**. Its click
  handler `b(object, EventArgs)` opens the local NEX chooser, parses the package,
  and updates the firmware selection. No device write is started by that handler.
- A separate button `Pi` is labelled **Upgrade Firmware Now**. The actual
  update dispatch is in the dialog's closing/confirmation path.
- The earlier descriptions of a generic Browse button were not exact UI labels.
  The code establishes a local-file mechanism, but its visibility and behavior
  in the owner's current screen have not been visually confirmed.

The next check, when hardware is available, is to open that firmware dialog
and use **Open File Browser** to inspect acceptance of the matching resource
candidate. Do not click **Upgrade Firmware Now** during this check. Capture
the displayed package selection/stages or rejection. If that button is absent,
inspect the real dialog rather than assuming a modifier key or hidden gesture.

The map probe has 37 authenticated, AES-256-encrypted entries. It preserves all
34 originals and adds only:

| Resource | Content |
| --- | --- |
| `ic7_static_probe.png` | Ordinary 320x160 PNG control image |
| `ic7_animation_probe.gif` | Two-frame looping GIF |
| `ic7_animation_probe.png` | The same GIF bytes, with an explicitly named PNG-extension alias |

All three are under `user_resources/images/`. The alias is not a PNG-encoded
animation: it is GIF data. NSP's map restoration and user-resource upload code
copy bytes directly; this is distinct from the external-image import dialog,
which validates extension/format agreement and can convert images. Do not
re-import the alias through that external-image import dialog.

The patched image component recognizes `.gif` URLs and specifically named
`ic7_animation_*.png` URLs. Other PNGs keep the existing static `Image` path.
The current media candidate also recognizes `.mp4` and provides muted looping
playback. Desktop Qt 5.15 and stock ARM Qt 5.9.6 both passed eight QML tests,
including GIF frame advance and video playback/pause with the supplied 1080p
H.264 MP4 under QEMU.

The final resource package was decoded again and its component compared with
the tested source. Only `HalImage.qml` differs from the original resource
archive; the other 338 members retain identical contents. No raw password or
key material was logged or written separately.

The current resource candidate is
[`ic7-2.36-media-preview-experimental.nex`](../build-nsp-media/ic7-2.36-media-preview-experimental.nex).
Its exact QML component is adjacent as `HalImage.qml` for the emulator's
isolated stock-renderer mode. The authenticated map probe
[`zak-2.36-media-probe.nexmap`](../build-nsp-map/zak-2.36-media-probe.nexmap)
adds static, animated GIF and MP4 assets while preserving all 34 original map
entries and keeping `_map` settings byte-identical. It does not select any probe
asset. MP4 import, listing and transfer through NSP remain unverified.
The stock image selector's definition filter is limited to PNG/JPG/JPEG/BMP,
so the MP4 probe is not selectable through the ordinary picker. The map's
settings checksum covers NSP's reconstructed binary settings buffer; changing
only the XML would invalidate it. A selector bypass needs either a checksum-safe
map writer or an NSP-supported workflow, neither of which has been verified.

This is not live map support. The standalone app's offline moving map depends on
executable code and a local tile server, neither of which is carried by this
resource-only `.nex`. Static map images can be asset-tested; live map/GPS
behavior needs a separate app/runtime integration.

## Remaining Limits

- The test map does not select or enable the added assets automatically.
- Windows NSP 1.48.5 import and save are owner-confirmed; it was not executed
  inside this Linux environment.
- Windows preview Qt 5.11.3 itself was not executed here.
- The filename filter permits `.png`, and the listed browser code decodes
  existing images by contents, but the full Windows selection/save flow may
  have further constraints on live transfer. The returned map confirms that
  import/selection/save did not reject, omit or convert it.
- An unmodified stock image component is static. Loading the map does not
  install the component patch, and is not expected to enable animation.
- The firmware/resource update route remains untested in the owner's
  online-update-only NSP interface. Do not upload the experimental `.nex`
  merely because the asset map opens.
- This is an asset-path compatibility test, not completed maps/GPS/clock
  integration or a validated custom-firmware installation.

## Completed Windows Test: Dash Disconnected

1. Download the asset-only map probe. Keep the original map as your working copy.
2. Disconnect the dash and open NSP in its normal offline/map-editing mode.
3. Open the probe `.nexmap` using the same file-open workflow as the original.
4. Confirm that the existing layout opens without a checksum or format error.
5. In the image resource picker for an image component, look for
   `ic7_static_probe.png` and `ic7_animation_probe.png`. Their exact display
   location depends on the active layout's existing image controls; no
   unverified menu names are assumed here.
6. Try the static control first, then the animation alias in this offline
   copy only. A still frame in the stock preview is expected and is not
   proof that animation support failed.
7. Save any selection changes under a new filename. Returning that saved map
   will let us inspect whether NSP preserved the GIF bytes and image reference.

If the map is rejected, or either image is absent, record the error or picker
contents rather than changing firmware. No car, ECU connection, factory reset,
or USB capture is required for this first test.

## Reproduce Offline

Use a Python virtual environment with `pyzipper`, `Pillow` and `cryptography`.
System packages already used for ELF/resource inspection remain necessary for
the separate resource-package builder.

```sh
/home/codespace/ic7build/map-venv/bin/python scripts/inspect-nexmap.py \
  2026-10-26_0134pm.ic7-2-36-0.nexmap --definition fw/ic7_2360.hdef
/home/codespace/ic7build/map-venv/bin/python scripts/build-nexmap-asset-probe.py \
  2026-10-26_0134pm.ic7-2-36-0.nexmap \
  --output /tmp/ic7-asset-probe.nexmap
bash scripts/test-nsp-image.sh
IC7_SYSROOT="$HOME/ic7build/sysroot" bash scripts/test-nsp-image.sh
```

Source path: `c/cQ.cs` restores map assets; `c/cR.cs` saves map settings and
resources; `B/BM.cs` stores restored bytes and writes user resources;
`B/BW.cs` lists resources by definition-provided extensions. The definition
contains the actual `ResourcePicker` extension lists.