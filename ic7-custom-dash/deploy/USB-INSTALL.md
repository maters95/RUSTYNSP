# NSP-Only USB Deployment Investigation

## Latest Map-Based Result

The owner's actual `.nexmap` and its nested layouts have now been decoded,
along with the matching v2.36 definition. A separate asset-only test map keeps
all 34 original entries byte-identical and adds three test images. Map probes
are in `build-nsp-map/`; the maintained media resource candidate is in
`build-cfw-media-mapfix-alias/`.
See [map integration](NEXMAP-INTEGRATION.md) for verified scope, limitations
and the next Windows-only check with the dash disconnected. Resource-package
acceptance is still unverified; a successful map import does not establish it.

## Actual Requirement

The owner's dash runs firmware 2.36, is reachable only through NSP over USB,
and should retain existing NSP features. SSH-based deployment is not an
available installation method on this unit. The rebuilt standalone ARM bundle
is not yet an NSP-installable package.

## Resource-Only Candidate Built

The v2.36 resource payload has now been decoded and rebuilt offline using the
reference updater supplied by the owner. The `.qzip` name is misleading: its
body decodes to a POSIX tar archive, not a ZIP. All 339 tar entries validated.
The device's `HalImage.qml` matches the Windows evidence byte-for-byte, and
there is no adjacent compiled `HalImage.qmlc` in this resource archive.

The maintained candidate is under
`ic7-custom-dash/build-cfw-media-mapfix-alias/`:

- `ic7-2.36-media-cfw-mapfix-alias-experimental.nex`: adds GIF and muted MP4
  handling plus NSP's PNG-picker alias support.
- `ic7-2.36-stock-resources-experimental.nex`: carries the original stock
  resource payload byte-for-byte in the same reduced manifest.
- `build-report.json`: hashes, exact changed-member list, and round-trip results.

The candidate is still resource-only; NSP acceptance and hardware installation
are untested.

Both packages contain only `manifest.xml` and `res_ic-7.qzip`. The iC-7
product/hardware identifiers and version are copied from the stock manifest;
other products, app executable, definition and STM32 stages are omitted.
The payload wrapper is preserved, including the 16-byte field whose full
meaning is not established. Source inspection shows that field's legacy
pre-upload branch is bypassed for this v2 default payload type. Its MD5
interpretation was tested and not confirmed; it is not replaced with a guess.

**Status:** offline integrity and runtime checks passed; actual NSP acceptance,
device-side installation, reboot behavior and persistence have not been tested.
The stock-resource counterpart is not a proven recovery mechanism if NSP or
the UI becomes inaccessible. No device was connected or flashed here.

This first patch adds GIF capability to the existing image component. It does
not turn the splash-screen BMP uploader into a GIF player, alter the current
image selection, or add maps/GPS/lap features. A GIF must still reach a path
used by a normal image component. The stock resource browser's import path
handles static image formats; raw GIF delivery and asset selection remain
separate integration work. Do not infer those are solved by the package build.

### Reproduce Offline

Dependencies on Ubuntu: `python3-cryptography`, `python3-pyelftools`, plus the
existing Qt/QEMU test dependencies. Use the system Python with these apt packages.

```sh
python3 scripts/resolve-nsp-strings.py --match 'qml|dash_virtual'
/usr/bin/python3 scripts/decode-nsp-resources.py fw/x/res_ic-7.qzip \
  --reference fw/opt/dtn/app/dash_watchdog --output /tmp/ic7-resources.tar
/usr/bin/python3 scripts/build-nsp-gif-preview.py \
  --stock-nex fw/Dash-V2-36-0-Release.nex \
  --reference fw/opt/dtn/app/dash_watchdog \
  --component ic7-custom-dash/deploy/nsp/HalImage.qml \
  --output /tmp/ic7-resource-candidates
bash scripts/test-nsp-image.sh
IC7_SYSROOT="$HOME/ic7build/sysroot" bash scripts/test-nsp-image.sh
```

Output paths must not already exist. The decoder uses standard ELF and AES
libraries and validates archive headers/member lengths before writing a file.
Parameters are read from the provided reference updater in memory; no key
material is printed or saved separately. The builder decodes its own finished
payload again, checks every member, and verifies that the changed-member set
contains exactly `qml_components_data/qml/user_components/HalImage.qml`.
The packaged component matches the source that passed both Qt test suites.

### Next Windows Check

When the dash is available, first back up its working configuration. Open
NSP's existing firmware-file selection workflow and select the experimental
candidate only to inspect whether NSP accepts it and what update stages it
proposes. Do not confirm the update as part of this acceptance check. Record
any rejection or the stage preview; if NSP does not provide a preview before
writing, cancel. This check must not be reported as an installed/tested patch.

### Source Findings

- `NSP.SettingsFramework/Framework.cs` method `f()` extracts the Windows
  preview executable/QML from a definition package, deleting the existing
  `qml_components_data` directory first. Local preview edits are not a durable
  device deployment method.
- `B/BM.cs` user-resource writer and `A/E.cs` resource service support image
  and font descriptors, not a documented general QML install command.
- `A/J.cs` descriptor `j` has a 50-byte UTF-8 name, type, size and CRC in
  60 bytes. Resource commands include list/read/write/rename/delete, with
  user files named `u/...`.
- `c/cZ.cs` queues manifest entries and reads each payload's 44-byte wrapper:
  format, kind, version, destination, alignment, chunk size, timeout and a
  16-byte field. The resource destination is `0x25000000`; executable data
  has a different destination, `0x29000000`.
- Reference watchdog `do_resource_upgrade()` calls `aes_decrypt_start()`
  with file type 1 before unpacking. Its tables successfully decoded the
  actual v2.36 resources, so that compatibility is tested, not assumed.

## Windows Evidence Verified (2026-10-26)

The returned
`research/usb-evidence/nsp-usb-20261026-131550/report.json` and QML copies show:

- NSP version **1.48.5**, using a running `dash_virtual` process.
- Dash enumerated as **COM3**, USB VID **16D0**, PID **0001**, driver `usbser`.
- Virtual-dash Qt version **5.11.3**. This is the Windows preview runtime,
  not evidence of the physical dash's Qt version.
- `NSP.dll` SHA256:
  `8D99E028044491FC5C6970AB2B48D7A192F646A2A423F1CF6DEB2C6887E4FBCA`.
- `dash_virtual.exe` SHA256:
  `5A5D74FE029178398512A5622D480FED213F4FD8F58E70B85CA169BB5A62303B`.
- Both binary hashes exactly match the archived files, so the existing NSP
  decompilation corresponds to this installed binary.
- All four collected QML files (`main.qml`, `HalImage.qml`, `HalText.qml`,
  `QML_TEMPLATE.qml`) match their archived copies byte-for-byte.
- The collector reported no errors. It did not query live firmware version
  or record USB protocol traffic; firmware 2.36 remains owner-reported.

The actual installed component directory is
`%APPDATA%\Haltech\Nexus\qml_components_data\qml\user_components`.
This is separate from the NSP program directory under Program Files.

## Captured USB Transfers

The first capture, `research/usb-captures/nsp-screen-upload.pcap`, was recorded during connection
and reboot, as confirmed by the owner. It contains 2,101 read commands and
14 write commands, totaling only 78 bytes of outbound write payload.

The second capture, `research/usb-captures/nsp-screen-upload1.pcap`, contains substantial transfers:

- Duration: 96.67 seconds. Haltech enumerates on bus 2, device 4, then device 5.
- Device 4: 1,129 reads and 1,016 writes, with 3,607,166 write-payload bytes.
- Device 5: 31 additional reads after re-enumeration.
- All 2,176 outbound commands have valid lengths and CRCs. Neither capture
  contains packets truncated by the configured capture length; this does not
  establish that the capture driver dropped no packets.
- Two contiguous writes to `0x00020000`, each 651,264 bytes, carry binary
  settings data. Their hashes differ.
- Two contiguous writes to `0x70400000`, each 1,152,054 bytes, decode as
  complete 800x480 RGB BMP images. The first is the Haltech startup logo;
  the second is the owner's custom CR-V startup screen, not a gauge layout.
- These two BMP transfers are not ZIP/QML archives. No QML resource archive
  has been identified in this operation. Do not infer that normal configuration
  upload delivers modified `HalImage.qml` or that the entire dashboard is
  rendered as a single bitmap.

The host source at `nsp_src/B/BM.cs` includes bitmap rendering and image
encoding before transfer; `nsp_src/B/BW.cs` also handles static BMP/PNG/JPEG
image imports. Those observations support static-image handling, not GIF
playback or arbitrary QML delivery through the observed image path.

Verified outbound protocol framing for these recordings:

| Bytes | Meaning |
| --- | --- |
| 0 | Command: 1 = write, 2 = read |
| 1 | Sequence byte |
| 2-7 | Big-endian 48-bit address |
| 8-11 | Big-endian 32-bit requested/write length |
| 12 onward | Write payload only; read requests have no payload |
| Last 4 | Standard CRC-32 over preceding bytes, stored big-endian |

This documents validated outbound frames only, not response statuses or an
upload/replay implementation. Successful device-side installation has not
been inferred merely from valid outbound CRCs.

`scripts/inspect-nsp-capture.py` uses tshark to select outbound USBPcap submit
records on endpoint 0x01, validates complete command lengths/CRCs, and groups
contiguous writes. It rejects fragmented/multiple-command USB payloads and
empty device selections rather than guessing. It never opens a COM port,
changes packets, or replays traffic. Device responses are not analyzed, so
valid outbound CRCs do not show whether NSP or the dash accepted or completed
a write. Unknown large writes remain unclassified; do not label them firmware
based on size/address alone.

```sh
python3 scripts/inspect-nsp-capture.py research/usb-captures/nsp-screen-upload1.pcap --bus 2 --device 4 --summary
```

On Windows, pass Wireshark's executable if `tshark.exe` is not on `PATH`:

```powershell
py -3 scripts\inspect-nsp-capture.py C:\captures\nsp-screen-upload.pcapng `
  --bus 2 --device 4 --summary `
  --tshark 'C:\Program Files\Wireshark\tshark.exe'
```

`--output <new-directory>` writes a JSON report only. Raw high-address payloads
are written only with the additional `--extract-high-address-payloads` option;
`--include-prefix` adds the first 32 payload bytes to the full report. Keep
these opt-ins off unless needed, and inspect outputs before sharing. The tool
does not upload anything. Reconstructed BMP payloads and viewable PNG versions are in
`research/scratchpad/capture1-analysis/`. Avoid sharing configuration/capture data
publicly without reviewing its contents.

The remaining integration question is which NSP or firmware-resource path
can deliver changed QML while keeping the stock executable. Repeating the
same ordinary configuration upload is not needed to establish the above.

## Confirmed From the Archive

These binary addresses apply to the unencrypted reference firmware, not to
the encrypted v2.36 app. Compatibility with the live device remains unproven.

- `fw/opt/scripts/swupdate-scripts/check_updates.sh` loads `g_serial` with
  VID `16D0`, PID `0001`, removes `g_multi`/`g_ether`, and disables/stops
  Dropbear. Its presence in the rootfs does not make SSH usable.
- `nsp_src/c/cF.cs`, nested class `cf`, opens a .NET `SerialPort`, with
  32,768-byte read and write buffers. A COM port is not a shell.
- `dash_application` USB address-space wrappers call a shared file writer:

| Space | Reference write-handler address | Staged file |
| --- | --- | --- |
| `dash_swu_upgrade` | `0x0008d360` | `/mnt/usb/upgrade/dash.enc` |
| `dash_app_upgrade` | `0x0008d3bc` | `/opt/applications/dtn/dash_app.upgrade` |
| `dash_qmldata` | `0x0008d41c` | `/opt/applications/dtn/dash.zip` |

- `dash_watchdog` owns `do_dash_app_upgrade()` at `0x00016cdc`. It calls
  `aes_decrypt_start()` at call site `0x00016fb8`. The app-upgrade channel
  therefore cannot be assumed to accept a plain ELF or our tar.gz bundle.
- The v2.36 `fw/x/manifest.xml` lists `hdef`, `qzip`, `nic-7`, and `dstm`
  payload stages separately. That describes normal vendor updates, not proof
  that NSP can install an arbitrary third-party package.
- `nsp_src/A/R.cs` uses DotNetZip and checks manifest metadata and entry CRCs.
  Host container parsing and device package processing are different layers.
- `fw/opt/dtn/upgrade/swu_upgrade.sh` can update both rootfs slots over
  successive reboots. It is not an inactive-slot-only installation recipe.

No key material was logged or saved separately. No USB commands or device
writes were performed. Resource decoding and candidate assembly were offline.

## Preserve NSP First

Replacing `dash_application` with `ic7dash` would remove the stock process that
implements NSP USB services. The custom app currently has no NSP protocol
server. Keeping the original binary is therefore the preferred integration
direction, subject to verifying its resource upload behavior.

The supplied NSP resources expose editable QML screens and components:

- `reference/stock-dash-extract/Dash/qmlroot/qml/user_screens/Screen_01.qml`
  and neighboring screens.
- `reference/stock-dash-extract/Dash/qmlroot/data/ScreenMap.json` maps screen
  identities to layouts.
- `reference/stock-dash-extract/qml_components_data/qml/user_components/QML_TEMPLATE.qml` defines
  the common `hal*` component contract and `setGaugeProperties()` interface.
- `HalImage.qml` currently uses a static Qt Quick `Image`, driven by
  `halImagePath`. Animated GIF support is a small candidate experiment, but
  persistence through NSP generation/upload has not been verified.

These files are not proof that v2.36 loads arbitrary replacement QML. Some
archived layouts are older, and `.qmlc` caches accompany sources. Before
changing a live installation, identify current resources and establish what
NSP generates, transfers, and overwrites. Maps, GPS and timing need their
stock data interfaces verified; the standalone app's C++ objects cannot just
be referenced from stock QML.

## Local Image Integration Prototype

`deploy/nsp/HalImage.qml` is an isolated candidate, not an installed patch.
It retains the collected component's `hal*` properties,
`setGaugeProperties()`, `repaintAll()`, and `repaintValue()` interfaces.
Static formats retain an ordinary `Image`; GIF URLs select an `AnimatedImage`
with matching opacity. Animation pauses while hidden or in screenshot mode.
This requires no replacement dash executable or custom C++ object.

`scripts/test-nsp-image.sh` generates PNG and two-frame looping GIF fixtures
in `build-nsp-tests/` and runs focused QML tests. On Ubuntu, install
`qml-module-qttest`, `python3-pil`, `xvfb`, and the existing Qt dependencies.
From the repository root:

```sh
bash scripts/test-nsp-image.sh
IC7_SYSROOT="$HOME/ic7build/sysroot" bash scripts/test-nsp-image.sh
```

For the second command, QEMU and the stock rootfs's `usr/bin/qmltestrunner`
must be present; the cross-build sysroot already includes its libraries,
plugins, and QtTest QML module. Six tests passed on both Qt 5.15 desktop and
the stock ARM Qt 5.9.6 runtime, exercising static rendering, frame advancement,
property assignment, opacity, screenshot pause and GIF-to-static switching.
Windows preview Qt 5.11.3 itself has not been run here.

The supplied app's `bg.gif` was parsed and contains **one frame**. It is not
an animation test fixture; do not interpret a stationary image as a playback
failure. The tests deliberately generate a real looping animation instead.

No installed Windows resources, archived inputs or physical dash were changed.
The prototype has not been delivered through NSP. Next, establish whether an
ordinary layout upload includes source components, cached QML, generated QML
or references to resources already installed on the dash. A successful local
QML test alone does not answer that question.

## Collect the Windows Baseline

On the Windows PC running NSP, with the dash connected normally:

```powershell
powershell.exe -NoProfile -File .\scripts\collect-nsp-usb-evidence.ps1
```

For a nonstandard installation, add `-NspInstallPath 'C:\path\to\NSP'`.
The collector inventories USB/serial devices, NSP processes and binary
versions, hashes relevant files, and copies selected QML source files into a
new evidence directory. It does not open COM ports, modify NSP resources,
read firmware keys, or send device commands. The report includes local paths
and USB identifiers; inspect it before sharing.

Return that evidence directory and the exact NSP version. Next, compare the
installed components with the archive, reproduce the existing layout in the
virtual dash, and capture one ordinary NSP screen upload using USBPcap and
Wireshark on Windows. Do not initiate a firmware update just to get a trace.
A normal screen-upload capture should let us verify framing, address-space
selection and resource packaging before implementing any uploader.

The baseline collection and archive comparison above are now complete.
For a passive capture:

1. Install Wireshark with its optional USBPcap driver on the NSP Windows PC;
   restart Windows if the driver installer requests it.
2. Use USBPcap's controller/device listing to identify the USB controller
   containing `VID_16D0&PID_0001`. Capture that USBPcap interface in Wireshark.
   COM3 is not a Wireshark capture interface. Capture the controller without
   a narrow capture filter so device re-enumeration is retained.
3. Start capture before the ordinary NSP operation you want to inspect. Use a
   routine screen/layout upload first; do not initiate a firmware update just
   to get a trace.
4. Stop capture promptly and save as `nsp-screen-upload.pcapng`. Record what
   operation was performed and whether NSP reported success. If a USBPcap
   interface is missing, launch Wireshark as administrator on the Windows PC.
5. In Wireshark, locate the dash using `usb.idVendor == 0x16d0` and
   `usb.device_address`; bus/device addresses can change after re-enumeration.
   Analyze each address interval separately. Example display filter:
   `usb.bus_id == 2 && usb.device_address == 4`.
6. Copy the capture into the workspace and run the offline analyzer above.
   Keep the original pcapng; a controller capture may include unrelated USB
   devices and private settings, so review it before sharing.

Only capture an actual firmware update if it is already vendor-authorized and
independently planned, with stable power and a recovery path verified on that
exact dash. The current unit's recovery path is unverified; do not flash it
solely to produce a trace. A capture is passive observation, not evidence that
the update succeeded, and this analyzer cannot certify installation.

This container cannot access the Windows COM3 device or record that transfer.

## Read-Only USB Diagnostics Kit

The diagnostic collector separates **Windows inventory**, **passive capture**,
and **one active identity read**. It is not a hardware scanner, firmware
installer, uploader, or shell. All evidence stays local.

### What it can establish

- Windows USB/COM identifiers, device/driver versions, NSP process and binary
  information, plus the existing baseline QML copies.
- The raw USB traffic present in a USBPcap capture, including enumeration and
  vendor/control transfers retained in the original capture.
- CRC-validated application requests and replies in both directions, including
  fragmented/coalesced packets, writes issued by NSP, and device errors.
- Firmware version, product ID, raw variant/hardware fields, definition ID and
  serial from a complete, validated iC-7 identity block.
- Observed addresses and lengths, unanswered/superseded requests, unmatched
  replies, truncated frames and undecoded bytes. A CRC-failure count concerns
  candidate protocol frames, not a diagnosis of bad physical USB hardware.

This cannot prove BLE/camera/GPS/RTC/extra GPIO are fitted, accessible, or
unused. Drivers, generic SoM device trees and library files alone do not prove
physical population. Full component verification needs vendor board/BOM
information, authorized physical inspection, or vendor-authorized shell access
to the *running unit* (active device tree, bound drivers, device enumeration,
processes and hardware-specific tests). There is no verified "dump everything
about the hardware" USB command here. Earlier hardware claims in the master
guide should be treated as leads rather than an independently verified BOM.

### Windows inventory (no Python or Wireshark required)

From the repository or extracted diagnostic ZIP root:

```powershell
powershell.exe -NoProfile -File .\scripts\start-ic7-usb-diagnostics.ps1 -Mode Inventory
```

Every run requires a new output directory; existing evidence is never
overwritten. Inspect `session.json` and `inventory/report.json` for errors.
If Windows blocks a downloaded script, review its contents and use your
organization's approved script-unblocking/signing process; the kit does not
change execution policy or install drivers.

### Passive capture while NSP runs

Install Wireshark with its optional USBPcap driver using the vendor installer.
Restart Windows if requested. Run an elevated PowerShell if capture permissions
require it. Start with:

```powershell
powershell.exe -NoProfile -File .\scripts\start-ic7-usb-diagnostics.ps1 -Mode Capture
```

This lists capture interfaces and deliberately stops without starting a
capture. Use USBPcap's controller/device listing to find the controller
containing `VID_16D0&PID_0001`. Select its full interface name from the list,
for example `\\.\USBPcap2` (**the number is an example, not autodetection**):

```powershell
powershell.exe -NoProfile -File .\scripts\start-ic7-usb-diagnostics.ps1 `
  -Mode Capture -CaptureInterface '\\.\USBPcap2' -Seconds 120 `
  -ConfirmControllerCapture -OutputDirectory .\ic7-passive-01
```

The bounded capture uses unlimited packet snap length, no capture filter and
retains re-enumeration on that controller. For enumeration evidence, start
before connecting the dash/NSP. Observe the normal connection, device
information and live channels. Do not edit/apply settings, upload layouts,
clear logs, reset or update firmware for this investigation. **NSP may write
automatically on connection**; this tool records those writes but cannot block
them. If absolutely no host writes are acceptable, leave NSP closed and do
inventory/authorized identity collection only. Passive capture itself sends
no application requests.

Keep the original `usb.pcapng` private: other devices on the controller can
appear, including keyboard/storage traffic. It can contain configuration,
serial numbers and GPS data. The kit does not upload anything. Capture end
statistics from tshark should be retained separately if reporting drops;
the analyzer cannot prove that the capture driver dropped no packets.
The wrapper saves tshark's output/statistics in `capture-stdout.txt` and
`capture-stderr.txt`; a nonzero capture exit code fails the session.

### Offline bidirectional analysis

Requires Python 3.10+ and Wireshark's tshark; no Python packages are needed for
offline analysis. Find bus and device addresses in Wireshark from enumeration
(`usb.idVendor == 0x16d0 && usb.idProduct == 0x0001`). Include every dash address
after re-enumeration. Example, using bus 2 and devices 4/5:

```powershell
py .\scripts\ic7-usb-diagnostics.py analyze .\ic7-passive-01\usb.pcapng `
  --bus 2 --devices 4 5 --tshark 'C:\Program Files\Wireshark\tshark.exe' `
  --output .\ic7-analysis-01
```

Outputs:

- `report.json`: identity, request coverage, errors/unknowns and limitations.
- `usb-records.jsonl`: selected USB record metadata and all exported
  `usb.capdata`, including undecoded bytes. Descriptor fields are not a full
  raw-frame export; retain the original capture for complete USB records.
- `protocol.jsonl`: validated packets in both directions, packet hex,
  completed-at frame, and matched request frame where available.

Only the previously observed USBPcap application endpoints (`0x01` submit /
`0x81` completion) are protocol-decoded. Other transfers remain in the capture.
Opcode-1 RPC response boundaries are inferred by CRC, not by a fully decoded
resource-service schema. Unknown addresses are not labeled physical memory,
hardware registers or firmware. Identity decoding does not interpret raw
hardware bytes as a component list.

### Optional direct identity read (exit NSP first)

The only active operation is the same address-zero, 1,024-byte identity read
used by NSP (`nsp_src/A/E.cs`, identity parser in `nsp_src/A/F.cs`). It uses
opcode 2 with CRC and validates the echoed header, reply CRC and product 21.
There is no arbitrary address/length option, protocol opcode-1 transmit path,
resource RPC, reset, scan or automatic retry.

Install the optional serial dependency only for this mode, preferably in an
isolated Python environment:

```powershell
py -m venv .ic7-diagnostics-venv
.\.ic7-diagnostics-venv\Scripts\python.exe -m pip install pyserial==3.5
```

Close NSP/Nexus and virtual dash processes. Substitute the current COM port
from inventory; COM3 is only the previously observed value:

```powershell
powershell.exe -NoProfile -File .\scripts\start-ic7-usb-diagnostics.ps1 `
  -Mode Identity -Port COM3 -ConfirmNspClosed `
  -Python .\.ic7-diagnostics-venv\Scripts\python.exe `
  -OutputDirectory .\ic7-identity-01
```

The wrapper refuses detected NSP processes; the port must enumerate with the
previously observed VID/PID. The client sets DTR/RTS false before opening, uses
115200/8-N-1 with no flow control, and closes the port on completion/failure.
Opening a serial port can still cause OS/driver line-control activity; this
is not electrically passive or a guarantee of zero device-side effects.
Unknown identity formats, changed USB IDs, busy ports, CRC errors and timeouts
stop the operation rather than enabling a bypass or fallback.

`identity/request.bin`, `identity/response.bin` and `identity/report.json`
retain the request, complete/partial reply and success/error. A failed
attempt is marked incomplete and not retried. Reopen NSP normally afterwards.
This identifies the device; it does not download all firmware/settings.

### Verification status

The parser was exercised against the existing physical-device capture
`research/usb-captures/nsp-screen-upload1.pcap`: 16,491 selected USB records,
1,160 reads, 1,016 writes, 2,175 validated replies, one unanswered request,
zero undecoded protocol bytes, zero CRC-failure candidates, zero
capture-length-truncated frames, and recovered firmware 2.36.0.
The historical capture contains writes; these are observations, not operations
performed by the diagnostic client.

Focused tests cover framing/reassembly, RPC reply boundaries, errors, device
isolation, identity validation, port allowlisting, read-only transmission,
partial failure evidence and no-retry behavior. PowerShell was syntax-parsed.
Live Windows USB capture and active serial querying remain **unverified on
the connected dash**; Linux/offline tests do not establish physical safety or
runtime compatibility.