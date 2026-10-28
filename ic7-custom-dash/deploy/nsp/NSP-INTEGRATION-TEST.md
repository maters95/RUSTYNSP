# NSP 1.48.5 Media Integration Test

This is a dash-disconnected test bundle for the NSP desktop importer and the
matching iC-7 v2.36 resource candidate. It is not a firmware installer. The
included `.nex` changes the stock `HalImage.qml` resource only; the live map
companion app is separate and is not installed or launched by NSP.

## Test prerequisites

- Windows and a complete copy of the owner's NSP 1.48.5 installation.
- The dash physically disconnected for the initial checks.
- A copy of the full NSP install directory for testing. Do not overwrite the
  installed NSP files.

The patched `NSP.dll` is unsigned. Keep the original DLL and all other NSP
files together in the copied install directory. Replace only the copy's
`NSP.dll`; do not replace `NSP.exe`, runtime configuration, drivers, or
dependencies. Launch the copied `NSP.exe`. If it fails to start or reports a
load/runtime error, restore the copied DLL and stop.

## Check media import and map save

1. Open the included `zak-2.36-mapfix-media-picker-uservideo.nexmap` in the
   copied NSP.
2. In an Image component's **Image Source** picker, confirm GIF and MP4 are
   listed. Import a valid animated GIF and MP4 and confirm they retain their
   original bytes and extensions in the map resource list.
3. Save as a new map file. Reopen it and confirm the image references and
   resources remain present. Do not overwrite the owner's original map.
4. If testing USB transfer, use only a virtual dash/sandbox first. A completed
   transfer event in a simulator does not prove target-side installation.

The included source map contains PNG-extension aliases for GIF and MP4 as
fallback probes. The patched NSP also adds the `gif` and `mp4` extensions to
resource pickers and passes valid GIF/MP4 bytes through without image
conversion.

## Check firmware-candidate parsing only

Use NSP's local firmware-file selection workflow (**Open File Browser**) to
select the included experimental resource-only `.nex`. Inspect the proposed
product and update stages only. Do **not** click **Upgrade Firmware Now**.
If NSP starts writing without a separate confirmation/preview, cancel the
workflow.

The package is expected to contain a single `res_ic-7.qzip` resource stage.
This only verifies local package selection/parsing when observed in NSP; the
candidate has not been accepted by NSP or installed on hardware in this
environment.

## Limitations

- The NSP DLL has been rebuilt from the included matching source, but this
  Linux environment cannot execute the Windows GUI. Confirm application
  startup, import, save, and local NEX selection on Windows.
- No physical iC-7 has been updated. The resource candidate is experimental;
  no vendor-supported recovery method is confirmed for it.
- The NEX does not include the companion app, map runtime, or a Grafton tile
  set. NSP integration here covers media resource import and package selection,
  not live-map firmware integration.
- Do not connect or flash a physical dash without a recovery method confirmed
  for that exact unit. Never test while driving.
