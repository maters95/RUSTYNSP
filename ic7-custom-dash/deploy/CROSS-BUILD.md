# Cross-building ic7dash for the iC-7 (ARM / Boot2Qt)

Target: Variscite VAR-SOM-MX6 (i.MX6, armv7hf, Cortex-A9), Boot2Qt 2.2.4,
Qt 5.9.6, eglfs. You build on a Linux host with the matching SDK, then stage the
binary into the rootfs and flash per `DEPLOY.md`.

## Verified Ubuntu 24.04 Build

Rebuilt on 2026-10-26 using GCC 11 and the stock firmware's Qt 5.9.6 sysroot.
From the repository root:

```sh
bash ic7-custom-dash/deploy/wsl-build.sh
bash ic7-custom-dash/deploy/bundle.sh
```

Despite its name, `wsl-build.sh` works on native Ubuntu and this dev container.
It uses the local `fw/` archive inputs, installs only Qt 5.9 qtbase host tools,
and selects the target's libc headers and startup files explicitly. Set
`SKIP_INSTALL=1` after initial setup to avoid repeating apt installation.
Both rootfs-tar and stock `.swu` extraction paths were built successfully.
The resulting ARM executable also ran under QEMU with the stock Qt runtime;
physical hardware has not been tested. See [build results](../../README.md).

The full Boot2Qt SDK instructions below are an alternative, not a requirement
for the verified build above.

## 1. Get the cross SDK (pick one)
**A. Prebuilt Boot2Qt SDK** (fastest): install the Qt 5.9 / Boot2Qt toolchain for
the i.MX6 / VAR-SOM-MX6 target from your Qt for Device Creation setup. It gives an
installer that drops an `environment-setup-cortexa9hf-neon-poky-linux-gnueabi`.

**B. Build the SDK from the Variscite Yocto BSP** (matches the dash exactly):
```
# Variscite morty BSP, b2qt manifest for var-som-mx6 (see Variscite wiki)
repo init -u <variscite-b2qt-manifest> -b morty
repo sync
MACHINE=var-som-mx6 source setup-environment build
bitbake meta-toolchain-qt5        # produces the SDK installer
./tmp/deploy/sdk/*-toolchain-*.sh  # install it
```
Either way you end up with an `environment-setup-*` script + sysroot + cross qmake.

## 2. Build (same project as desktop)
```
source /opt/.../environment-setup-cortexa9hf-neon-poky-linux-gnueabi
cd ic7-custom-dash
mkdir build-arm && cd build-arm
qmake ../ic7dash.pro        # cross qmake from the SDK
make -j$(nproc)
file ic7dash                # => ELF 32-bit LSB, ARM, EABI5  (sanity check)
```
`HAVE_SOCKETCAN` turns on automatically for the Linux/ARM build, so the dash reads
real CAN; the desktop build stays on the simulator. (CMake route works too:
`cmake -DCMAKE_TOOLCHAIN_FILE=$OECORE_NATIVE_SYSROOT/usr/share/cmake/OEToolchainConfig.cmake ..`)

## 3. Stage into the rootfs
Copy onto a COPY of Haltech's extracted rootfs (never the live dash):
```
/opt/applications/ic7overlay/ic7dash          # the ARM binary
/opt/applications/ic7overlay/emtron_can.json   # resources/emtron_can.json (your offsets)
/opt/applications/ic7overlay/bringup-can.sh    # deploy/bringup-can.sh   (chmod +x)
/opt/applications/ic7overlay/tiles/            # offline map tiles (step 5)
/usr/bin/ic7-mode                               # deploy/ic7-mode.sh      (chmod +x)
/etc/systemd/system/ic7-overlay.service         # deploy/ic7-overlay.service
```
The app also reads an `emtron_can.json` sitting next to the binary in preference to
the bundled copy, so you tune CAN offsets on the dash without rebuilding.
Do NOT `systemctl enable` the overlay — leave stock mode as the boot default.

## 4. Runtime bits specific to the dash
- **Display:** the service sets `QT_QPA_PLATFORM=eglfs` (the stock app's platform).
  If eglfs needs a specific integration on this board, match what the stock
  `gui-launcher` used (check its environment / the b2qt image defaults).
- **GPS:** USB NMEA receiver via QtPositioning serialnmea; service sets
  `QT_NMEA_SERIAL_PORT=/dev/ttyUSB0` — adjust to your receiver's node.
- **CAN:** `bringup-can.sh` sets `can0` to 1 Mbit/s; the app reads `IC7_CAN=can0`.

## 5. Offline map tiles (no network in the car)
The app embeds a tiny loopback HTTP tile server (`src/tileserver.cpp`) that
serves `tiles/<z>/<x>/<y>.png` from next to the binary, and `TrackPage.qml`
points QtLocation's osm plugin at `http://127.0.0.1:<port>/`. So the map renders
fully offline — no internet, and no HTTPS/OpenSSL needed on the dash.
- Seed tiles with `deploy/seed-tiles.ps1` (or any z/x/y downloader) for the
  tracks/roads you use; keep zoom ~12–16 to bound the size (294 tiles ≈ 5 MB for
  one circuit). Verified working on the desktop build against ESRI tiles.
- Deploy the `tiles/` tree to `/opt/applications/ic7overlay/tiles/`.
- Missing tiles just render blank; present ones are served instantly.
- To refresh tiles after reseeding, clear the app's `tilecache/` folder (the osm
  plugin caches on disk; the app sets its cache dir next to the binary).

## 6. Flash + test
Follow `DEPLOY.md` §3–4: verify i.MX6 USB recovery first, flash the PASSIVE A/B
partition, boot-test (stock mode → NSP connects; `ic7-mode overlay` → your app),
then promote. Leave the STM32 (`dash_stm`) firmware untouched.
