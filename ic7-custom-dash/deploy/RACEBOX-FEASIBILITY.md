# RaceBox on iC-7: application and Bluetooth feasibility

Investigation: 2026-10-29. Offline analysis of the supplied application and
firmware, relevant accessible conversations, and primary public documentation.
No dash, ECU, CAN bus, or RaceBox configuration was changed. No physical
Bluetooth controller was interrogated. This is not a ready-to-flash package.

## Verdict

| Question | Finding |
| --- | --- |
| Install the supplied XAPK as one iC-7 page? | No, not on the stock Linux/Qt runtime. It is an Android application, not a QML component. |
| Build a native page with RaceBox-style telemetry, track trace and timing? | Technically plausible. Requires a telemetry source, new Qt/QML UI and integration work; not demonstrated on hardware. |
| Read a RaceBox Mini/Mini S/Micro without the Android app? | Yes in principle: the device exposes BLE telemetry. RaceBox explicitly offers protocol documentation for third-party applications. |
| Does the firmware support Bluetooth? | Yes. Both inspected kernel configurations enable LE, Classic, UART HCI and USB Bluetooth. The reference rootfs includes BlueZ and a real Qt Bluetooth backend. |
| Does this owner's physical iC-7 contain a usable onboard radio? | Not established. Generic device trees, installed packages and shared application symbols are insufficient proof. |
| Is Bluetooth merely a disabled NSP option? | Not established. No verified RaceBox input or working onboard-controller initialization path was found. |
| Least invasive practical data route? | RaceBox BLE -> external BLE/CAN gateway -> verified iC-7 CAN channels. A complete native track page remains separate UI work. |

Interpret "screen" here as a selectable dashboard page, not replacement of the
physical LCD. A literal Android UI requires Android execution or an external
renderer/transport; the APK cannot supply native Qt widgets.

## Inputs and provenance

- Supplied `RaceBox_2.3.0_APKPure.xapk`, found in the repository root despite
  the attachment URI error.
  SHA-256:
  `fee95e51befe2bec5fb581754f24e3cf4f2a7c97a4b16458f2697cb5ef8d2c7e`.
- Base APK: `pro.RaceBox.androidapp.apk`; native split:
  `config.armeabi_v7a.apk`. Language/density splits are also present.
- Current application: the decoded `nic-7` stage from
  `fw/Dash-V2-36-0-Release.nex`, SHA-256
  `d86bde81820b8b7b5efcfc7466aa994cabeacac6c6bcd725536393ab48687248`.
  This matches the provenance in the [runtime audit](nsp/MEDIA-RUNTIME-AUDIT.md).
  The older SWU dash executable was not substituted for this application.
- Reference OS:
  `fw/swu_nsp/var-image-swupdate-var-som-mx6.tar.gz` and extracted
  `fw/root/boot/uImage`.
- v2.36 resource snapshot:
  `research/scratchpad/ic7-236-resources.tar`, member
  `upgrade_files/uImage.src`; member SHA-256:
  `db6a0c90e0837cf3ef62e5b0e8cedddaac093590b770705f922c5b9ab71643b6`.
  A packaged kernel template is not proof of the kernel currently booted on
  the owner's unit.
- The reference kernel and v2.36 template contain byte-identical embedded
  configurations, SHA-256:
  `a4ae07e06f1128a61b6ef7966b4ec58cc76008364bf06d9eea10f537023ea70a`.

Private local analysis output, including recovered assemblies, decompilation,
kernel configurations, disassemblies and synthetic checks, is under:
`/home/codespace/.copilot/session-state/56cf74b3-5c64-4fbf-a484-b3c03aee8e80/files/racebox-analysis/`.
Proprietary application source, assets and credentials are not copied into
this repository or sent to external analysis services. Downloaded tools ran
locally.

## 1. What the Android application actually contains

The decoded manifest establishes package `pro.RaceBox.androidapp`, version
`2.3.0`, version code `245`, **minimum Android API 29 (Android 10)** and target
API 36. It requests BLE scan/connect, location, network/Wi-Fi, camera and media
permissions, and declares Google Maps dependencies.

This is **.NET MAUI on .NET 10 for Android**, not a portable web page, Flutter
bundle or Qt application. The recovered project target is
`net10.0-android36.0`. The ARMv7 split contains Mono/Android runtime libraries,
AOT images and an ELF `libassembly-store.so` with a v3 ARM XABA payload.
Matching ARM instruction sets do not make Android and glibc Linux runtimes
interchangeable.

Analysis completed:

1. JADX decoded the manifest and Java wrappers. It reported 26 Java-method
   decompilation errors; this was not represented as a clean full Java recovery.
2. The managed store was parsed using the format documented in dotnet/android:
   208 assemblies were extracted, LZ4-decompressed where needed, and checked
   for PE signatures and expected lengths.
3. ILSpy 11.2 successfully decompiled `RaceBox.BLE`, `RaceBox.Core` and
   `RaceBox` into 977 C# files. The existing older ILSpy failed on these newer
   assemblies; the compatible version was used instead.
4. Important recovered assemblies include `RaceBox.BLE`, `RaceBox.Core`,
   `RaceBox.Data`, `RaceBox.WiFi`, `Plugin.BLE`, MAUI and Google Maps bindings.
   `RaceBox.Data.dll` alone expands to 56,236,544 bytes; application/track
   resources are not evidence of an offline native map implementation.

### Actual data and screen separation

Observed application flow:

```text
BLEDeviceManager
  -> Nordic-UART-style BLE service
  -> UARTOverBLE notification buffer
  -> Connection / UBXPacket framing and checksum
  -> RaceBoxData
  -> IMUProcessor calibration and smoothing
  -> LiveData
  -> session/timing processors and MAUI view models
  -> MAUI track/drag pages and custom graphics
```

Recovered implementations include `MiniTrackLivePage`, `MiniDragLivePage`,
track and drag live models, a G-G graph, track/session analysis, and
`TrackRealTimeProcessor` with sectors, crossing interpolation and predictive
processing. These are client-side functions, not ready-made images streamed
from the RaceBox sensor.

A native page can therefore implement selected functions without porting the
entire phone application. Reimplement the desired behavior against the
documented protocol; do not assume permission to redistribute RaceBox source,
branding, assets or track databases.

### Verified BLE framing

The supplied app uses:

| Role | UUID |
| --- | --- |
| Service | `6e400001-b5a3-f393-e0a9-e50e24dcca9e` |
| Command RX characteristic | `6e400002-b5a3-f393-e0a9-e50e24dcca9e` |
| Telemetry TX characteristic | `6e400003-b5a3-f393-e0a9-e50e24dcca9e` |

`UARTOverBLE.ConnectAsync()` requests MTU 247 and subscribes to notifications.
It buffers received bytes, so an implementation must not equate one
notification with one complete packet. MTU 247 is an observed request, not
proof that every supported controller must negotiate precisely that value.

Live telemetry has sync bytes `B5 62`, class/ID `FF 01`, a little-endian
payload length, an 80-byte payload and two UBX-style checksum bytes: **88 bytes
total**. At 25 updates/second that is 2,200 application bytes/second, excluding
BLE overhead. Throughput is modest; controller support and reliable packet
handling matter more than headline Bluetooth speed.

Selected payload facts confirmed in the recovered parser:

| Payload offset | Field | Decode |
| --- | --- | --- |
| 0 | GNSS time of week | uint32 little-endian, milliseconds |
| 20-23 | Fix status, flags, satellites | Preserve validity; coordinates alone do not prove a valid fix |
| 24 / 28 | Longitude / latitude | int32 little-endian / 10,000,000 degrees |
| 48 | Ground speed | int32 little-endian mm/s; app clamps negative values to zero |
| 52 | Heading | int32 little-endian / 100,000 degrees |
| 68 / 70 / 72 | Acceleration X/Y/Z | int16 little-endian / 1,000 G |
| 74 / 76 / 78 | Gyro X/Y/Z | int16 little-endian / 100 degrees/second |

Offsets are relative to the payload, not the complete packet. Raw sensor axes
are not automatically vehicle axes: the app applies calibration and smoothing.
The advertised 1 kHz internal IMU sampling rate is not a 1 kHz BLE stream.
GNSS course-over-ground is also not interchangeable with gyro yaw rate,
particularly at low speed.

### Executable verification

A small .NET 10 host program called the **original recovered DLLs**, not
recompiled decompiler output. Eleven synthetic checks passed:
88-byte framing, valid GNSS fix, signed latitude, longitude, speed, heading,
signed acceleration, signed gyro, checksum rejection, partial-frame rejection,
and invalid live-payload-length rejection.

This demonstrates that the recovered parser and interpreted scales work on
synthetic data. It does not validate BLE reception, physical measurement
accuracy, a Linux UI port, real lap timing or a firmware installation.

## 2. Bluetooth: confirmed support versus unconfirmed hardware

### Kernel evidence, including the v2.36 kernel template

Both embedded configurations contain:

```text
CONFIG_BT=y
CONFIG_BT_BREDR=y
CONFIG_BT_LE=y
CONFIG_BT_HCIBTUSB=y
CONFIG_BT_HCIUART=y
CONFIG_BT_HCIUART_H4=y
CONFIG_BT_HCIUART_LL=y
# CONFIG_RFKILL is not set
# CONFIG_CFG80211 is not set
# CONFIG_WL_TI is not set
# CONFIG_TI_ST is not set
```

Consequences:

- The kernel already supports LE and Classic. Earlier "BLE-only" claims are
  not justified by these images.
- UART Bluetooth and USB Bluetooth are compiled in, but neither proves a
  controller is fitted, powered, connected to an accessible bus or initialized.
- `rfkill unblock bluetooth` is not a demonstrated solution: these kernels
  lack RF-kill support.
- Wi-Fi is not enabled just by the existence of a Wi-Fi/Bluetooth combo-module
  device-tree node. The TI Wi-Fi and cfg80211 paths are disabled here.
- Disabled `TI_ST` does not itself rule out TI Bluetooth: the separate UART
  H4/LL transports are enabled. Correct chip-specific initialization is still
  required.

The reference compressed kernel was decoded from its valid LZO stream, then
its embedded gzip configuration was recovered. An earlier LZO-magic occurrence
is a decompressor literal, not a valid archive. The valid stream has trailing
image data, which the decoder reported explicitly. The v2.36 template exposes
its embedded configuration directly. No kernel bytes were patched.

### Userspace and startup

The reference rootfs contains BlueZ **5.41**, `bluetoothd`, `bluetoothctl`,
`hciconfig`, `hcitool`, `hciattach`, `libbluetooth`, Qt Bluetooth **5.9.6** and
the QtBluetooth QML module. The Qt library contains BlueZ interfaces and
low-energy code, not just development headers.

The image includes a `bluetooth.target.wants/bluetooth.service` enablement
symlink. The service has
`ConditionPathIsDirectory=/sys/class/bluetooth`. Enablement in an image is
neither proof that the daemon is active nor proof of an `hci0` controller.
The inspected systemd units and rootfs startup script did not establish a
board-specific onboard HCI attach/firmware sequence.

Repository inventory anchors:
[`fw/list_rootfs.txt`](../../fw/list_rootfs.txt), lines 18583, 26346, 26740,
26868, 26902, 30458 and 31118.

### Device tree and actual application

The reference `imx6dl-var-som-solo-res` device tree includes an enabled SDIO
controller and a `ti,wl1835` child. Multiple generic board DTBs ship together;
the booted tree and fitted SoM option have not been identified.

The actual v2.36 application contains `UnixWifiModule`, `WifiComms` and
`enum_for_WifiBTModuleStatus`. Disassembly shows a configured enable check,
Wi-Fi configuration/up/down functions, and status labels including Disabled,
Initialising, Connected and Error. This is evidence of wireless-related code,
not proof that iC-7 exposes a usable BLE client. Its direct dependencies do
not include Qt Bluetooth, and targeted strings/symbol inspection did not find
a RaceBox or `QLowEnergy` implementation. Dynamically loaded code cannot be
excluded merely from the direct dependency list.

Variscite's current VAR-SOM-MX6 ordering information makes Wi-Fi/Bluetooth a
selectable module option. TI documents WL1835 as dual-mode Bluetooth plus
Wi-Fi, with Bluetooth HCI over UART. Neither vendor's current catalog proves
which part, revision, antenna or firmware is in this particular dash.

**Hardware conclusion: plausible, but unproven.** Do not buy parts, change
device-tree GPIOs, or promise a Bluetooth unlock on the basis of bundled
software alone. No credible unit-specific public teardown found in this
investigation settled the fitted-radio question.

## 3. Ways to implement a selectable page

### A. Native page inside the stock Qt application: preferred UI direction

Retain the stock application as display owner and add a deliberately scoped
native component/page. The existing resource-only media work proves that
selected stock QML components can be replaced; it does not prove arbitrary
application installation or telemetry-service integration.

Still required:

- BLE input via a proven controller, or a separately verified CAN input.
- A data bridge exposing timestamped values, fix quality and stale status to
  the page. A backend helper/plugin may be needed; QML files alone do not
  establish a working BLE central.
- Native UI for track trace, speed, G-ball, current/last/best laps and optional
  sectors/delta; bounded storage and suitable offline map content.
- Physical-button/CAN-button navigation. Haltech documents front-panel
  buttons; phone-style touch interaction must not be assumed.
- Preservation of alarm priority, acknowledgement, page switching, shift
  lights, CAN reception and NSP servicing under load.

RaceBox lap/drag result equivalence requires more than drawing similar gauges.
Use GNSS sample timestamps and crossing interpolation, then validate against
recorded/reference runs. The current project's `LapTimer` uses elapsed host
time at received crossings; it is not already equivalent to RaceBox's timing
engine.

### B. External BLE-to-CAN gateway: preferred first data proof

```text
RaceBox -> BLE central gateway -> automotive CAN transceiver
        -> iC-7 verified CAN inputs -> native dashboard page
```

This avoids dependence on an undocumented onboard radio and does not require
the exposed dash USB connection to become a host port. Use hardware and power
conditioning suitable for the vehicle; an ESP32 alone is not a CAN electrical
interface.

The actual v2.36 ELF provides a concrete stock GPS lead:
`can_gps::CanGPS::handle` at `0x0005cd20` handles standard IDs `0x4F3`,
`0x4F4` and `0x4F5`; a stock CAN lap-timer class is also present.
This is **not a validated gateway transmit specification**. Complete field
meanings/scales, module selection, update rates, timeouts, bus selection and
coexistence must be verified before sending any frames.

A Generic CAN mapping is another candidate for individual displayed channels.
It must be checked for the required signedness, precision, destinations and
timeout behavior. Generic channel values do not automatically feed every
built-in GPS/lap function.

Do not duplicate IDs from a real module or the ECU, replace the working Emtron
dataset, or inject test traffic on an operational vehicle. Start isolated on
a bench. GPS and G readings do not by themselves provide a drawn track page.

### C. Standalone Qt app: useful prototype, not transparent page replacement

The existing custom app has a map/track page, NMEA serial input and a simple
lap timer. It is a useful prototype base, but contains no completed RaceBox BLE
transport. Its NMEA input is a serial-port reader, not BLE UART automatically.

The [scratch-test procedure](ON-DASH-TEST.md) requires authorized shell access
and states it has not run on the owner's physical iC-7. The
[display ownership notes](DEPLOY.md) explain that eglfs normally has one
display owner: running the standalone app means a mode switch, not embedding
one new page while all stock warning behavior automatically remains visible.
Desktop/QEMU screenshots cannot prove those properties.

### D. Run or mirror the Android app: not the sensible first route

The stock dash is Boot2Qt Linux, not Android 10+. MAUI's documented platforms
do not include a stock embedded glibc Linux target. Copying DLLs/ARM shared
objects, renaming an APK, or importing it through NSP cannot supply Android,
MAUI handlers, Google services or Android BLE APIs.

A new Android BSP or external Android renderer would add boot/display/input,
driver, update, recovery, communication and warning-integration work. Mirroring
also requires a proven video transport and control path; neither BLE telemetry
nor the working GIF/MP4 patch establishes one.

The i.MX6 and its kernel support host/OTG capabilities, but the project's
observed NSP USB connection is device-side. Do not promise that plugging a
Bluetooth dongle into that connector will work.

## 4. Prior conversations reconciled

Accessible relevant conversations were reviewed through VS Code's session
context tools: "Next steps after CFW on dash" and "Splash screen gif and mp4
playback", plus the repository's handover, runtime audit, design notes and
deployment notes. The separate session-store database returned no history;
the VS Code session tool did expose the relevant conversations. This is not
a claim to have retrieved every historical conversation on every machine.

- GIF/MP4 screen playback has an owner-confirmed physical baseline. It proves
  media rendering, not arbitrary Android apps or onboard Bluetooth.
- Recent splash/alert/emulator work is separate from sensor transport and
  hardware discovery. No concurrent worktree changes were used as evidence
  that RaceBox integration already works.
- SL4 acceleration over CAN remains useful without another sensor, but earlier
  evidence did not establish an SL4 gyro or GPS. A RaceBox can add actual GNSS
  and gyro data rather than relying on an acceleration-derived track sketch.
- The old master guide's "BLE radio" and "BLE only" assertions were too strong
  and have been corrected to distinguish firmware support from fitted hardware.

## 5. The decisive next checks

First obtain the exact RaceBox model/firmware and the iC-7 hardware revision.
The Mini/Mini S specifications advertise BLE 5.2, certified down to 4.2.
Do not infer compatibility from an old SoM family name or today's catalog:
identify the actual controller and test service discovery/notifications.

With **already authorized shell access on the actual dash**, collect these
read-only diagnostics while stationary:

```sh
uname -a
tr '\000' '\n' < /proc/device-tree/model
tr '\000' '\n' < /proc/device-tree/compatible
ls -l /sys/class/bluetooth
bluetoothctl list
hciconfig -a
systemctl status bluetooth --no-pager -l
journalctl -b -u bluetooth --no-pager
dmesg | grep -Ei 'bluetooth|hci[0-9]|ttymxc|wl18|wlcore|firmware'
ls -l /sys/bus/sdio/devices
```

Missing commands/paths are diagnostic results, not proof of hardware absence.
These commands have **not** been run on the owner's dash. NSP's USB protocol
is not a Linux shell; do not imply this block can be pasted into NSP.

Interpretation:

- A live `hci0` and controller identity establish an enumerated controller.
  Next prove LE capability, RaceBox discovery, service/characteristic discovery,
  notification framing and reconnect after a power cycle.
- No `hci0` is inconclusive for a UART radio: it may be absent, held in reset,
  missing chip firmware or not attached. Identify the fitted SoM part number
  and antenna or obtain manufacturer confirmation before changing anything.
- Do not run `hciattach` against guessed UARTs or toggle guessed GPIOs:
  they may belong to the STM32, console or other hardware.
- Physical inspection is optional and should be vendor-guided because opening
  the enclosure can compromise sealing/warranty.

Recommended order: establish real telemetry reception on a PC/gateway, resolve
onboard radio identity in parallel if authorized access exists, build a native
page with recorded/synthetic data, then bench-test integration and recovery.
Keep the known-good NSP/map/firmware baseline unchanged until then.

## Primary public references

Checked 2026-10-29:

1. [RaceBox Mini/Mini S specifications](https://www.racebox.pro/products/racebox-mini/tech-specs):
   25 Hz GNSS, BLE specifications and internal IMU rates.
2. [RaceBox protocol documentation request](https://www.racebox.pro/products/mini-micro-protocol-documentation):
   explicit third-party sensor-access support. Obtain documentation through
   the normal request process; no form was submitted or gated access bypassed.
3. [Variscite VAR-SOM-MX6](https://variscite.com/system-on-module-som/i-mx-6/var-som-mx6/):
   platform interfaces and selectable wireless ordering options, not a dash BOM.
4. [TI WL1835MOD](https://www.ti.com/product/WL1835MOD):
   dual-mode Bluetooth and UART HCI, not identification of the owner's radio.
5. [Haltech iC-7 product specification](https://www.haltech.com/product/ht-067010-haltech-ic-7-digital-dash-kit/):
   CAN connectivity, USB configuration, front-panel buttons; no advertised
   RaceBox BLE feature.
6. [Qt 5.9 Bluetooth](https://doc.qt.io/archives/qt-5.9/qtbluetooth-index.html):
   Linux/BlueZ LE central support.
7. [MAUI supported platforms](https://learn.microsoft.com/en-us/dotnet/maui/supported-platforms?view=net-maui-10.0):
   no standard Boot2Qt/Linux target.
8. [dotnet/android assembly-store format](https://github.com/dotnet/android/blob/main/Documentation/project-docs/AssemblyStores.md)
   and [reader implementation](https://github.com/dotnet/android/blob/main/.github/skills/read-assembly-store/src/AssemblyStore/StoreReader_V2.cs):
   basis for extracting the supplied application's managed payload.

Independent interoperability reference:
[ESP32-RaceBox](https://github.com/lademeister/ESP32-RaceBox). It demonstrates a
third-party BLE client approach, not a validated Haltech gateway. Treat example
code as reference material requiring review, not production-ready vehicle code.
