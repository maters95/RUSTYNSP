# Interchangeable test variants

Each folder holds only the files you swap between tests: the NEX to flash, the
`NSP.dll` for the separate test NSP copy, and any resources to upload. Every
file is a byte-for-byte copy of a tracked, verified build. `SHA256SUMS` and
`variants.json` list each file, its hash and its source. Regenerate the folder
with `python scripts/make-test-variants.py` and check it with
`sha256sum -c SHA256SUMS`.

| Folder | Flash | Test NSP copy | Upload |
|---|---|---|---|
| `0-base-stock` | `firmware/ic7-2.36-stock-resources.nex` (resource-only; restores the stock QML), or `firmware/Dash-V2-36-0-Release.nex` (full Haltech package) | `nsp/NSP.dll` (OEM) | your normal map |
| `1-splash-alarms-r4` | `firmware/ic7-2.36-screen-alarms-experimental.nex` (`dec4e3bf…`) | `nsp/NSP.dll` (r4 rebuild) | the map's resources (splash, alarm GIFs, markers) |
| `2-addons-experimental` | `firmware/ic7-2.36-addons-experimental.nex` (variant 1 plus the gauge add-ons) | `nsp/NSP.dll` (r4 rebuild) | `upload-on/` to enable; `upload-off/` and a power cycle to disable |

**How to swap:**
- Replace only `NSP.dll` in your *test* NSP copy (made by
  `setup-native-media.ps1`), never in the official install.
- Flash one NEX at a time, and re-upload the map's resources after each
  flash.
- To return to stock, flash `0-base-stock`.
- Test in this order: base, then variant 1, then variant 2. A failure then
  points to one change.

`preserved/` keeps builds that exist nowhere else, for comparison only:
- `NSP-review-build-814dd33.dll`: the NSP review's own build, from the same
  source as r4. Its bytes differ only because .NET builds embed build-specific
  IDs.
- `NSP-previous-custom-build.dll`: the custom DLL that the binding checks
  compare against.

The full NEX for the r4 kit (the Windows test package with the emulator) is
in `dist/ic7-final-windows-test-2026-10-30-r4.zip`. These folders are for
swapping files on a setup that already exists.
