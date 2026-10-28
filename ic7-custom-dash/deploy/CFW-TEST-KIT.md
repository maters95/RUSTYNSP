# iC-7 Media and Map Bench-Test Kit

This is a test kit for the existing v2.36 stock resources and a separate ARM
companion app. It is **not complete custom firmware**, a flashable `.swu`, or a
validated NSP installation package. Do not select the resource `.nex` on the
physical dash's firmware-update screen.

## What is and is not included

- The experimental resource-only `.nex` changes only the stock `HalImage.qml`
  component to render GIF and muted looping MP4. Its build report verifies the
  other 338 resource members were preserved.
- The `.nexmap` test assets exercise NSP's media resource picker and transfer
  workflow. They do not add a map runtime or real GPS to the stock application.
- The ARM companion app supplies a moving offline map, the MAP/GIF/MP4 selector
  and lap timing. It is a separate display-owner process: the OEM UI and its
  warnings are not drawn at the same time. The resource `.nex` leaves the stock
  executable and other resources unchanged, but no supported handoff/installation
  path has been confirmed for the physical unit.
- No Grafton map tiles are bundled. Add tiles only from a provider/license that
  explicitly permits offline extraction and caching. The seeder defaults to
  Grafton, NSW, approximately 290 tiles at zoom 13–15, and requires both an
  authorized URL template and required attribution.
- No internal GPS hardware is confirmed. The companion app requires a serial
  NMEA receiver for real fixes. It defaults to a simulated route unless
  `IC7_SIM_GPS=0` is set; `IC7_GPS_DEVICE` defaults to `/dev/ttyUSB0`, 9600 baud.

## Local verification

From the repository root, with the ARM Qt 5.9.6 sysroot at
`$HOME/ic7build/sysroot`:

```sh
bash scripts/test-nsp-image.sh
IC7_SYSROOT="$HOME/ic7build/sysroot" bash scripts/test-nsp-image.sh
IC7_SYSROOT="$HOME/ic7build/sysroot" \
  bash ic7-custom-dash/deploy/qemu-smoke-test.sh \
  ic7-custom-dash/build-arm/ic7dash
python3 ic7-custom-dash/tests/test_nmea_gps.py
python3 ic7-custom-dash/tests/test_nmea_gps.py \
  --app ic7-custom-dash/build-arm/ic7dash \
  --sysroot "$HOME/ic7build/sysroot"
```

To run the bundled ARM test from an extracted bench-test kit, first extract its
nested app bundle, then provide both the app and its runtime assets:

```sh
mkdir -p app
tar -xzf app/ic7dash-arm-bundle.tar.gz -C app
python3 tests/test_nmea_gps.py \
  --app app/ic7test/ic7dash \
  --assets-dir app/ic7test \
  --sysroot "$HOME/ic7build/sysroot"
```

These tests cover the QML component on desktop and target Qt, map rendering
from the existing local demo tiles, GIF and MP4 playback under QEMU, and valid
versus bad-checksum NMEA fixes over a virtual serial port. They do not confirm
physical GPS reception, video performance, display orientation, NSP acceptance,
or device installation.

## Windows NSP test

Use the dash-disconnected/virtual-dash procedure in
[`nsp/MEDIA-MAP-TEST.md`](./nsp/MEDIA-MAP-TEST.md). The component candidate,
test map, and exact package build report must stay matched. An emulator
`transfer-complete` result is not proof of installation on the physical dash.

## Physical hardware boundary

The unit in this project is reachable only through NSP USB; there is no
vendor-supported app sideload path or recovery method confirmed for it.
Resource updates can affect the stock display and NSP connectivity. Stable
bench power and a recovery method proven on this exact dash are prerequisites
for any physical update. Until those exist, stop at desktop/QEMU and the
dash-disconnected virtual NSP test. Never test while driving.

## Preparing the Grafton offline tiles

Obtain a raster tile source with explicit permission for offline extraction and
local caching. Do not use the example endpoint from earlier drafts or scrape a
public tile server. Then, on Windows PowerShell, provide the provider's
documented URL template and complete attribution:

```powershell
pwsh ic7-custom-dash/deploy/seed-tiles.ps1 `
  -UrlTemplate 'https://authorized-provider.example/{z}/{x}/{y}.png' `
  -Attribution 'Attribution text required by your provider'
```

The output tree contains `ATTRIBUTION.txt`; bundle that file with the tiles so
the app can display the credit. Confirm the provider's coordinate order, zoom
limits, export rights, rate limits and attribution requirements before use.
The 294 existing Sydney demo tiles are only for software testing and do not
cover Grafton.
