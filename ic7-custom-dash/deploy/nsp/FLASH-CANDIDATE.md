# iC-7 v2.36 Media Resource Candidates

These are experimental resource-only NEX packages, not a full custom operating
system. They rebuild the existing media experiments; a new filename does not
establish a new or proven installation method. No physical dash was flashed.

## Packages

Use the `mapfix` v2 candidates below. The original `build-cfw-gif` and
`build-cfw-media` candidates omitted NSP's HDEF map-migration reference and
should not be retried.

Paths are relative to the repository root:

- GIF-only mapfix: `ic7-custom-dash/build-cfw-gif-mapfix/ic7-2.36-gif-cfw-mapfix-experimental.nex`
- GIF and MP4 mapfix with NSP PNG-picker alias support: `ic7-custom-dash/build-cfw-media-mapfix-alias/ic7-2.36-media-cfw-mapfix-alias-experimental.nex`
- Earlier GIF and MP4 mapfix: `ic7-custom-dash/build-cfw-media-mapfix/ic7-2.36-media-cfw-mapfix-experimental.nex`
- Stock resources mapfix: `ic7-custom-dash/build-cfw-media-mapfix/ic7-2.36-stock-resources-experimental.nex`
- Original full vendor package: `Dash-V2-36-0-Release.nex`

Each mapfix candidate keeps the stock product's `hdefFile="ic-7.hdef"` link
and embeds the matching stock HDEF solely as an NSP map-migration dependency.
The HDEF is **not** listed as a device-update `<FILE>`. The only update entry
remains `res_ic-7.qzip` for product 21, variant 11, with stock hardware-ID
restrictions. Inside the decrypted resource archive, only
`qml_components_data/qml/user_components/HalImage.qml` changes. The other 338
members are unchanged. App, kernel, bootloader, definition and I/O firmware
are not updated by the resource file. The stock-resource package contains the
original encrypted resource payload byte for byte, with the HDEF available for
NSP's map migration.

## Virtual NSP Results

The first HDEF-less GIF candidate transferred all 17,377,280 resource bytes,
then NSP displayed "Failed to upgrade the map!". NSP source places that dialog
in the follow-on map-migration step. That package omitted `hdefFile` and
`ic-7.hdef`.

The follow-up COM11 emulator capture used the new HDEF-assisted media mapfix
candidate. It received all 17,377,280 resource bytes with no rejected protocol
responses, then NSP sent its return-to-main command. The session ended in
`MAIN`; the capture does not establish physical installation or decoder
behavior. It is consistent with the mapfix resolving the prior migration
failure. The emulator now labels this `transfer-complete`, not `verified`.

## Verified Offline

- NEX ZIP integrity, encrypted-resource decode/encode round trip, archive member
  set, single-component diff, and unchanged stock wrapper fields.
- Media component: 8 passing Qt 5.9.6 ARM QML tests under QEMU, including GIF
  frame advancement and MP4 playback position advancing and pausing.
- GIF-only component: 7 passing applicable tests on the same userspace.
- GIF-only imports QtQuick without importing QtMultimedia.

QEMU does not establish physical video decode performance or boot behavior.
The wrapper's 16-byte metadata field is preserved, not independently validated
against the target updater. It is not the MD5 of the stock encrypted or plaintext
payload. There is no HalImage.qmlc cache in the stock resource archive.

## Before A Physical Attempt

1. Keep the real dash disconnected for NSP testing. Attach NSP to the virtual
   dash, select the GIF-only mapfix candidate, and verify that
   the update queue contains only the resource file for the correct device.
   Record errors and the raw capture. Emulator acknowledgements and staged
   writes do not prove that the physical watchdog can install or recover it.
2. Establish a recovery method that works when the normal dash application does
   not start. Keep the original vendor package and a backup of the current map.
   The stock-resource NEX is not a guaranteed recovery method: NSP connectivity
   may depend on the application that a bad QML resource can prevent starting.
   Do not assume an A/B rootfs switch restores shared resources.
3. A physical attempt requires stable bench power, the exact compatible device
   and firmware, and acceptance of display/boot failure risk. Do not use a
   vehicle being driven as the test environment. No physical flash is authorized
   or performed automatically by these build scripts.
4. Prove GIF-only behavior before considering the combined media candidate.
   MP4 adds a QtMultimedia dependency. A failed import can affect every image
   component, including otherwise static images.

## Assets Are Separate

These NEX files install a renderer component, not a user map or media file.
The saved test map selects `u/ic7_animation_probe.png`, which contains GIF data.
That selection and resource descriptor were confirmed in the serial capture.
The emulator preloaded that resource, so that session did not prove upload.

The combined component recognizes `.mp4` paths and the GIF/animation-PNG paths.
NSP accepting and transferring an MP4 map asset to a physical dash remains
unverified. Do not infer MP4 installation from desktop or QEMU playback alone.
The alias-enabled component also recognizes `/ic7_video_*.png`, since NSP's
resource picker only allows PNG/JPG/JPEG/BMP names. Add MP4 bytes through the
authenticated test map's PNG alias; the normal external-image importer validates
PNG file content and is not the MP4 import path.