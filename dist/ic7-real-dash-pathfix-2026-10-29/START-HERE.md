# Real-dash resource-path correction

This is a new, experimental matching NSP/NEX/emulator kit, not a verified
physical-flash release. Keep your original map, working NSP and firmware.
The physical dash must be disconnected during desktop/emulator setup.

## What was wrong

The prior splash and alarm components looked for user resources one directory
too low on the real dash. The desktop preview directory layout is different.
This kit resolves both layouts. The hardware-layout startup test failed before
the correction and passes afterward.

The capture proves the previous NEX resource body, splash GIF/manifest and KFC
GIF/manifest were transferred. It does not prove installation or cold-boot
success. Two mode-switch commands received device error replies.

Your attached map lacks the KFC GIF and alarm manifest uploaded later in the
capture. The included restored copy adds only those two resources, recovered
from CRC-checked transfers. All existing archive members, including native
settings and integrity data, remain byte-identical.

## Set up the matching NSP

1. Extract this entire ZIP into a new folder. Its `NSP-test-kit` and
   `ic7-emulator` directories must remain beside each other.
2. From PowerShell in that folder, run:

   ```powershell
   powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\NSP-test-kit\setup-native-media.ps1 `
     -NspInstall 'C:\Program Files (x86)\Haltech\Nexus Software\Haltech NSP' `
     -Destination "$env:USERPROFILE\Downloads\NSP-device-paths"
   ```

   Use your actual official installation path, not an earlier modified test
   install. Stop if setup reports an error.
3. Launch NSP from the new destination and open
   `NSP-test-kit\map\KFC-screen-5-restored.ic7-2-36-0.nexmap`.
4. Open KFC LIMITER -> Appearance. Confirm the GIF, GIF-only mode and Screens
   value `5`, then Apply -> OK -> Save. The map already contains the native
   transparent screen markers.

## Emulator test first

Start `ic7-emulator\start-workbench.cmd` using your verified virtual COM pair.
Confirm its NEX package matches
`NSP-test-kit\firmware\ic7-2.36-screen-alarms-experimental.nex` before starting
a fresh session. NSP must select that exact same file.

The filename is the same as the prior candidate; this corrected NEX has SHA-256:

`9f4f449f57b2aba20088fdee3ca5c14503fce5956bdfec1fb500259e2d084683`

Upload settings/resources from the restored map. Check animated startup on
restart and active KFC visibility only on screen 5. The emulator does not execute
ARM firmware or establish physical-flash safety.

## Why QML files accompany the NEX

The loose QML files and build report are hash-checked emulator/reference
sidecars. Keep them beside the NEX for the emulator. The physical dash receives
the QML inside the NEX encrypted resource archive; do not copy loose QML files
separately to the dash.

## Verification and remaining limits

- 49 desktop Qt checks, including the actual dash directory layout.
- 45 ARM Qt/QEMU checks.
- 116 emulator tests and 9 manifest/native-renderer/package tests.
- Matching NSP build: zero errors, 402 existing warnings.
- NEX round-trip and stock-resource preservation checks.
- Restored-map authentication and byte preservation checks.

The corrected NEX has not been installed or cold-boot tested on physical
hardware. Live physical alarm switching, Windows acceptance and frame-exact
synchronization remain unverified.

Static PNG selection in NSP still uses the original BMP/kernel-logo workflow;
the Qt-stage PNG playback check does not validate that kernel update. This
capture contains the GIF-resource upload, not a static BMP splash upload.
Do not treat this correction as proof the reported static boot-logo failure
is resolved, or as approval to flash the dash. Never interrupt an active update.
