# Replacement-only patch for the screen-alarm test kit

This ZIP is a patch for `ic7-screen-alarms-2026-10-29.zip`, not a standalone
NSP installation. It contains only changed runtime files, the restored map,
updated checksums/manifest, this guide and the validation report. No Qt runtime,
unchanged media components, samples, test suites or full emulator distribution
are repeated.

## Replace the desktop files

1. Disconnect the real dash. Close test NSP, its preview and the emulator.
2. Back up your existing extracted screen-alarm kit and isolated test NSP.
3. Extract this ZIP over the original extracted kit, preserving the
   `NSP-test-kit` / `ic7-emulator` folder structure, and allow file replacement.
4. Copy `NSP-test-kit\NSP-test\NSP.dll` into the isolated test NSP directory
   you actually launch, replacing its `NSP.dll`. Do not replace the official
   Haltech installation's DLL. Alternatively, rerun the merged kit's original
   setup script into a new isolated destination using official NSP as source.
5. Launch that test NSP and reopen
   `NSP-test-kit\map\KFC-screen-5-restored.ic7-2-36-0.nexmap`.
   Keep your original map; it is not deleted or overwritten.
6. KFC LIMITER -> Appearance: confirm the GIF, GIF only and Screens `5`.
   Apply -> OK -> Save. The restored map already has native screen markers.

## Matching NEX

Use the replacement
`NSP-test-kit\firmware\ic7-2.36-screen-alarms-experimental.nex`,
not a same-named copy from an earlier download. Its SHA-256 is:

`9f4f449f57b2aba20088fdee3ca5c14503fce5956bdfec1fb500259e2d084683`

The NEX is selected in NSP's updater, not copied to the dash as an ordinary
file. Loose QML and `build-report.json` beside it are reference/emulator
sidecars; leave the unchanged `main.qml` and `HalImage.qml` there too.
The physical dash receives all changed QML inside the NEX resource archive.
There is no separate manual QML installation on the dash.

## Emulator test

Restart the updated workbench and start a fresh session with your verified
virtual COM pair. Confirm the workbench and NSP both select the replacement
NEX before transferring anything. Upload the restored map's settings/resources.
Check the GIF startup on reboot and KFC popup only on screen 5. Export logs
after stopping if any step fails.

## What this fixes, and what it does not prove

The previous startup and alarm components looked for user resources at the
desktop preview's relative path on the real dash. The corrected code handles
both layouts. The hardware-layout startup regression failed before this
correction. The saved map also lacked the KFC GIF/manifest uploaded later in
the capture; the restored copy adds only those two resources while preserving
all original members, native settings and integrity bytes.

Verified locally:

- 51 desktop Qt checks, including visible PNG/GIF pixels over the splash
  background, changing GIF pixels, default device paths and screen filtering.
- 45 ARM Qt/QEMU checks for paths, decoding, timing and screen logic.
- 116 emulator tests and 18 C#/resource/package regressions.
- Matching embedded DLL/NEX components and archive hashes.
- Comparison against the owner-confirmed videofix baseline: 336 unchanged
  resource members; three changed QML files and one added splash component.

ARM offscreen image-grabbing returns black even for a plain red control
rectangle, so the ARM results are NOT proof of rendered pixels or GPU output.
Physical installation, cold boot, Windows acceptance and live physical alarm
switching remain unverified. The USB capture establishes transfer, not a
successful target-side installation.

Static PNG selection in NSP still uses the stock BMP/kernel-logo updater.
This capture contains no such static BMP upload. The Qt-stage PNG pixel test
does not validate or fix that kernel workflow. A black physical display alone
cannot identify which startup stage was visible.

This is a reviewed correction, not a claim that every reported physical
symptom is fixed or that flashing is safe. Hold off on further physical
flashes until the static-splash/update outcome is understood; never interrupt
an active update.
