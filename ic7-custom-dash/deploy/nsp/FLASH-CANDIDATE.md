# iC-7 v2.36 Media Resource Candidates

The maintained v2.36 candidates are experimental, resource-only NEX packages.
They are not a full custom operating system or a supported installation method.
No physical dash was flashed.

## Maintained packages

Paths are relative to the repository root:

- GIF-only mapfix:
  `ic7-custom-dash/build-cfw-gif-mapfix/ic7-2.36-gif-cfw-mapfix-experimental.nex`
- GIF and MP4 with NSP PNG-picker alias support:
  `ic7-custom-dash/build-cfw-media-mapfix-alias/ic7-2.36-media-cfw-mapfix-alias-experimental.nex`
- Matching stock-resource package:
  `ic7-custom-dash/build-cfw-media-mapfix-alias/ic7-2.36-stock-resources-experimental.nex`
- Original vendor package: [fw/Dash-V2-36-0-Release.nex](../../../fw/Dash-V2-36-0-Release.nex)

Each mapfix candidate keeps the stock product's `hdefFile="ic-7.hdef"` link and
embeds the matching stock HDEF solely as an NSP map-migration dependency. The
HDEF is **not** listed as a device-update `<FILE>`. The only update entry is
`res_ic-7.qzip` for product 21, variant 11, with stock hardware-ID
restrictions. Inside the decrypted resource archive, only
`qml_components_data/qml/user_components/HalImage.qml` changes. The other 338
members are unchanged. The stock-resource package is not a proven recovery
mechanism.

## Validation scope

- NEX ZIP integrity, encrypted-resource decode/encode round trip, archive
  member set, single-component diff, and unchanged stock wrapper fields passed.
- The media component passed eight Qt 5.9.6 ARM QML tests under QEMU, including
  GIF frame advancement and MP4 playback position advancing and pausing.
- The GIF-only component passed seven applicable tests under QEMU and imports
  QtQuick without importing QtMultimedia.
- A COM11 emulator session transferred the HDEF-assisted media resource:
  NSP sent and the sandbox received exactly 17,377,280 bytes, with SHA-256
  `56e7c8c32b3d8e3f05a488ae763d20dcf023a414651f012c61403e90177c05a2`.
  The sandbox reported `transfer-complete` and NSP returned to its main state.
  Firmware execution did not occur, and no component was available or active.
  This is a transport result, not proof of physical installation, decoder
  behavior, or recovery; the raw protocol trace is not retained in the cleaned
  workspace.

QEMU does not establish physical video decode performance or boot behavior.
The wrapper's 16-byte metadata field is preserved but not independently
validated against the target updater.

## Physical-device limitation

Physical installation and a recovery method for this exact dash have not been
verified. Do not select **Upgrade Firmware Now** on a physical dash. NSP
connectivity may depend on the stock application, and an incompatible resource
could prevent that application from starting. Do not assume the stock-resource
package or an A/B rootfs switch can recover shared resources.

Any future physical test requires a vendor-supported recovery method, the
exact compatible device and firmware, stable bench power, and a stationary
test environment. These build scripts do not authorize or perform a physical
flash.

## Media assets are separate

The NEX files update a renderer component, not a user map or media file. The
combined component recognizes `.mp4` paths and GIF/animation-PNG paths. NSP's
resource picker only allows PNG/JPG/JPEG/BMP names, so the test map carries MP4
bytes through an `ic7_video_*.png` alias. Physical MP4 import, transfer, and
playback remain unverified. Do not infer installation from desktop or QEMU
playback.
