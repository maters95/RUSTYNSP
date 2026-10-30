# iC-7 NSP Simulator

Screen-scoped alarm appearances use the same maintained root, image and popup
QML as NSP and the resource-only firmware candidate. Upload the map's settings
and resources, including its managed transparent screen markers. The native
renderer follows marker visibility, not a separately polled screen selector.
Synthetic alarm preview filters against its own selected preview screen; it
does not establish real alarm evaluation or frame-exact Windows NSP parity.

## Final test-kit workflow

The Windows workbench now opens **Dash Display** automatically using the
original NSP renderer. This is the primary display for testing screens,
fonts, GIF/MP4 media and alarm layout. **Layout Diagnostic** is explicitly
an approximation, not the dash display. Keep only one isolated renderer and
one test NSP instance open; upload the same map/resources to both.

- **Start Session** creates a new, empty virtual dash. It stays blank until
  NSP writes dashboard settings. The combined kit selects its matching
  resource-only NEX automatically.
  Extract the NSP test kit and emulator ZIPs side by side so `ic7-emulator`
  and `NSP-test-kit` share a parent folder. The screen-alarm kit selects
  `ic7-2.36-screen-alarms-experimental.nex`; older integration kits retain
  their own default. Confirm the displayed **NEX package** matches the file
  selected in NSP before starting the session.
- **Resume Dash** opens an existing saved session folder, retaining settings,
  resources and a completed, hash-matched firmware preview. Its configured
  splash runs at startup. The original selected NEX and sidecars must still
  exist; reselect the NEX if the kit has moved.
- **Power Cycle** restarts the display, replays the splash, drops incomplete
  resource transfers and saves the retained map/resources. It is disabled
  during firmware-update mode.
- NSP reboot commands restart the isolated renderer. A sandbox firmware
  change reloads verified QML rather than terminating the bridge.
- Completed sandbox updates publish every available verified sidecar
  (`main.qml`, `HalImage.qml`, `HalSplash.qml`, `HalAlarmPopup.qml`), not just
  the screen-image component. New build reports hash every sidecar.
- Live-data mirroring rejects stale publisher timestamps as well as torn
  snapshots. If NSP stops publishing, the renderer returns to emulator data.
- After **Stop**, use **Export Logs**. The ZIP includes settings, image/font
  resources, protocol capture, emulator log and **renderer.log**, with hashes.
  It excludes the copied Qt runtime. Logs may contain map and resource data;
  review them before sharing.

The workbench records renderer errors and exit status; use **Dash Display**
to retry after correcting a missing dependency. Stopping the workbench
requests a graceful bridge shutdown so its child dash process is closed too.

If NSP reports **Write Resources File**, a resource transfer block failed.
Do not treat this as successful installation or retry against a physical dash.
For a sandbox run, stop and export logs; `sandbox-update-rejected` identifies
package-byte mismatches, out-of-range writes or invalid update mode. A matching
NEX must be selected before starting a fresh session. The dialog alone does not
identify which of these conditions occurred.

### Fidelity limits

This is not a full hardware emulator: it does not execute the ARM application,
kernel, bootloader or STM32 code. CAN/ECU acquisition, LEDs, physical controls,
hardware video codecs, USB re-enumeration, hardware flashing and recovery
are not modeled. Live alarms require NSP's own live-data/Simulate panel and
the same map settings; the synthetic alert preview is not an alarm engine.
Windows integration still requires an on-PC acceptance test. Passing the
Linux/ARM-QEMU component tests is not a physical-firmware safety guarantee.

Runnable protocol simulator built from the owner's iC-7 v2.36 USB captures,
definition, stock resources and matching NSP 1.48.5 source.

**The owner has now connected Windows NSP through HHD COM10/COM11.** The
log confirms identity, full settings reads and sustained channel polling.
The original Windows renderer bridge has not been validated on Windows.
This is a runnable test build, not a
claim of complete hardware or firmware emulation. Keep the physical dash
disconnected while testing virtual ports.

## Native Workbench

For one desktop window combining the emulator session, dash preview, image
resources, sandbox update verification, serial traffic, and session log, run:

```powershell
.\start-workbench.cmd
```

Use **Choose resource-only NEX** to browse directly to the extracted `.nex`
file's actual location. Do not paste an example path such as `C:\IC7\media`
unless that folder exists on your PC. **Preview only** starts without a serial
port. To use NSP, select the emulator end of a signed virtual COM pair; the
workbench filters for identifiable virtual ports and warns before opening one.
Keep the physical dash disconnected. **Launch NSP** only starts the executable
you choose; this is an unofficial companion, not an extension injected into or
patching the installed NSP application.

The dash preview is approximate and sensor values are unavailable. GIFs can
preview in the Resources tab; selecting an MP4 opens the browser viewer with
that resource selected and video controls available, rather than playing in the
workbench panel. This workbench runtime does not include QtMultimedia. Browser
launch and playback failures are reported explicitly; playback requires a
browser-supported video codec. This asset preview is independent of the selected
NEX and does not verify firmware playback. On Windows, **Dash Display**
uses NSP's private original renderer and opens automatically by default.

The synthetic **Preview Alert** window uses the separate PyQt5 Qt 5.15
runtime. Its launcher adds that runtime's own DLL directory to the Windows
search path before loading QML and checks QtMultimedia before opening the
preview. A missing plugin now exits with a dependency error in **renderer.log**
instead of opening a window with no alarm. Do not copy NSP's Qt 5.11 DLLs into
the Python environment; the two renderers must keep their runtimes separate.

## Emulator Display Lifecycle

The desktop display starts black instead of showing the example dashboard seeded
in the simulator profile. It stays blank until NSP writes map component settings;
the emulator then renders those received settings. Entering boot mode blanks the
display. NSP's `00 00` return-to-main/reboot command resets the emulated display;
when a map is loaded, the stock renderer process is restarted so its QML startup
loader reads the selected splash manifest and plays its GIF/MP4 for at most
3.3 seconds before returning to the dashboard. It does not substitute a
dashboard background for an unconfigured or disabled splash.

The reserved kind-0 resource `u/ic7_splash.json` contains a version-1 JSON
manifest (`source` is an existing `u/` or `h/` image resource and
`durationMs` is capped at 3300). It is exposed through the normal resource RPC
and renderer resource API, not the special BMP screen-upload address. The
manifest persists after playback and across repeated reboots; an empty source
disables the overlay. This is a desktop Qt-stage simulation only; the
physical dash's earlier static kernel logo is unchanged and is not emulated.

The alerts bundle also installs the matching `HalAlarmPopup.qml`. It reads
`u/ic7_alerts.json` for exact-text GIF backgrounds and per-alert rectangles,
without replacing the application's activation or clearing logic. To preview
an active popup explicitly (after uploading map settings/resources), click the
workbench **Preview Alert** toolbar button (it lists texts from the uploaded
`u/ic7_alerts.json`), or run:

```powershell
.\.venv\Scripts\python.exe .\native_view.py --preview-alert "OIL PRESSURE"
```

Repeat the argument for multiple alerts. This is labelled **synthetic alert
preview**, uses the shared popup and emulator resource API, and does not
evaluate sensor thresholds or write device settings. Configure alert media
and drag/numeric placement in the matching NSP **Alert GIF banners and
placement...** editor, save the map, then apply/upload its resources. For real
alarm activation and acknowledgement testing, use the normal Windows stock
renderer; Linux QML/synthetic tests do not establish that behavior.

**Matching NSP exactly:** the rebuilt NSP publishes the live-data block it
sends to its own dash renderer (device data or its **Simulate** panel) to the
read-only local shared memory `HaltechNSP_iC7_LiveData`. `stock_renderer.py`
applies the newest block to the original renderer every 50 ms, so alarms
raised in NSP appear, stack, use the same GIF/GIF-only overrides and clear in
the emulator exactly as in NSP's renderer. It falls back to emulator memory
when NSP stops updating for more than one second. Alerts marked **GIF only**
hide the stock coloured banner and text unless the media fails to load.

The isolated renderer installs the same `main.qml`, `HalSplash.qml`,
`HalAlarmPopup.qml` and GIF/MP4-capable `HalImage.qml` as the combined
NSP splash/resourcefix/alerts bundle.
Run that bundle's `setup-native-media.ps1`, open an iC-7 map in the new NSP copy
once to stage its Qt add-ons, then close its renderer before starting the
emulator renderer (the isolated renderer uses a separate pipe). The bridge
copies the staged `ic7-media-qml` and `ic7-media-plugins` into its private runtime
and requires the DirectShow **dsengine** player; `wmfengine` alone is not a
video-player backend. Missing multimedia/GIF dependencies produce an explicit
startup error, not an Image-only fallback.

Validated on Linux with real PyQt5: 90 Python tests, including a real Qt 5.15
test of staged GIF and MP4 playback, muting, timeout/unloading, and two startups
per format, plus a shared GIF alert preview over HTTP with rendered-pixel
verification. Browser tests cover MP4/alias playback and splash-to-layout handoff.
Windows Qt 5.11 renderer operation and physical startup remain unverified.
Run `QT_QPA_PLATFORM=offscreen python3 -m unittest discover -s ic7-emulator/tests`
from the repository root with its Python dependencies, Qt QML test runner,
multimedia modules/plugins and ffmpeg installed; then run
`node ic7-emulator/tests/test_viewer.js`.

## Windows Setup

1. Extract the complete simulator ZIP to a normal writable folder.
2. Install Python 3.11 or newer from python.org if it is not already installed.
3. For an immediate viewer-only check, run:

   ```powershell
   .\start-emulator.cmd -ViewerOnly
   ```

   The launcher creates a private Python environment, installs dependencies,
   and opens `http://127.0.0.1:8765`. Initial setup requires internet access.
   Leave its terminal open. No virtual-port driver is needed for viewer-only mode.

4. To connect NSP, install a **signed virtual null-modem/serial-port driver**
   using its normal vendor installer. HHD Virtual Serial Ports is one example;
   a correctly signed com0com installation is another. No kernel driver is
   bundled, and disabling Windows driver-signing enforcement is not required
   or recommended. Create a paired connection, for example **COM10 <-> COM11**.
   With signed com0com, `.\setup-virtual-pair.cmd` can plan and (with `-Apply`)
   create the pair for you; with HHD, create it in HHD and record it with
   `-Manual`. See **Virtual COM Pair Setup** below.
5. With the real dash disconnected, launch `.\start-workbench.cmd`. On
  Windows, if no port is already labeled `Haltech iC-7 Simulator`, the
  workbench offers to prepare NSP discovery. Choose the NSP-facing end of the
  virtual pair (for example, COM10); it requests Administrator approval and
  runs `set-nsp-port.ps1`, which saves the old description and rejects
  physical USB ports. Later launches recognize the configured port and skip
  the prompt. Some drivers may reject this SetupAPI operation; stop on errors
  rather than relabelling the real dash. For headless use, run the helper
  manually from an administrator PowerShell in the extracted folder:

  ```powershell
  powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\set-nsp-port.ps1 -Port COM10
  ```

  `-ListOnly` reads the current description without changing it.
6. To start the protocol simulator without the workbench, stop viewer-only
  mode with Ctrl+C, then run:

   ```powershell
   .\start-emulator.cmd -Port COM11
   ```

    To select a sandbox package with a file dialog instead of typing a path,
    run `.\start-emulator.cmd -ChooseSandbox -Port COM11`. In the workbench,
    select the emulator end (COM11) and choose the package in the window.

7. Open/restart NSP. NSP should discover the **COM10** end, while the simulator
   owns **COM11**. Do not configure both applications to open the same port.
   The simulated serial is `F1C700000001`; it is intentionally not the real dash.
8. The workbench starts **Dash Display** automatically. If you are using only
   the command-line protocol simulator, start the original-renderer bridge in
   another terminal (do not launch a second bridge alongside the workbench):

   ```powershell
   .\start-stock-renderer.cmd
   ```

   This uses the verified `dash_virtual.exe` and 32-bit Qt runtime already
   installed at `%APPDATA%\Haltech\Nexus`. If your path differs, pass
   `-Runtime 'C:\path\to\Haltech\Nexus'`.

The bridge stages the maintained `main.qml`, `HalSplash.qml`, and
`HalImage.qml` into its isolated renderer tree. GIF and MP4 playback requires
the matching Qt 5.11 Multimedia QML module/runtime, GIF image-format plugin,
and DirectShow or WMF media-service plugin in that private runtime. Startup
stops with an explicit missing-dependency error if any are absent; there is no
static-image fallback that could appear to play unsupported media.

The driver installation and port-description change are Windows-local setup
steps; this container cannot install or verify them on your PC.

## Virtual COM Pair Setup (com0com or HHD)

`setup-virtual-pair.cmd` configures and records the NSP/emulator pair so the
workbench and `start-emulator.cmd` pick it up without retyping or relabelling
port names. It never downloads or installs a driver, never changes driver
signing or test-signing settings, and never opens a serial port.

Prerequisites: Windows, Python 3.11+ (the `.venv` from `start-emulator.cmd`
is used when present), and **either** a signed com0com build installed by you
with its normal installer (for example the signed 3.0.0.0 or 2.2.2.0 release)
**or** HHD Virtual Serial Port Tools / another signed driver for the manual path.
Keep the physical dash disconnected.

```powershell
.\setup-virtual-pair.cmd                                   # dry run: detect and print the plan (default)
.\setup-virtual-pair.cmd -NspPort COM10 -EmulatorPort COM11 -Apply   # run it after a typed "yes" and a UAC prompt
```

Dry run (default) is read-only. It reports installed HHD software, its
services/drivers and Authenticode signatures, any present HHD ports (two
present HHD ports are shown as a *candidate* pair; whether HHD has bridged them
cannot be read from Windows inventory), the com0com `setupc.exe` location, the
`com0com.sys` signature (`Get-AuthenticodeSignature`) and `pnputil
/enum-drivers` entry, existing com0com pairs (`setupc list`, or the com0com
service registry if `setupc list` needs elevation), and then prints the exact
`setupc` commands it would run, for example:

```text
cd "C:\Program Files (x86)\com0com"; .\setupc.exe install PortName=COM#,RealPortName=COM10 PortName=COM#,RealPortName=COM11
```

`PortName=COM#,RealPortName=COMn` asks com0com to use the Windows Ports class,
so the ports appear in Device Manager where NSP, pyserial and
`set-nsp-port.ps1` can see them. If one requested name already belongs to a
com0com pair only that pair's other end is renamed (`change CNCxN ...`);
`-RenamePair N` renames an existing pair instead of installing a new one.

Refusals (exit code 3, nothing changed): a requested name is held by any
non-com0com device (physical USB/ACPI ports, the dash, HHD ports, any
`SERIALCOMM` entry not owned by com0com), the two names are in different
com0com pairs, or the name is reserved in the Windows COM database by an absent
device (often a disconnected USB device such as the dash; override with
`-AllowReserved` only after checking Device Manager with hidden devices shown).
If no signed com0com is installed, or `com0com.sys` is not validly signed, the
helper exits with code 2 and explains the options.

`-Apply` asks you to type `yes` (skip only with `-Yes`), re-checks the driver
signature, runs each `setupc` command through `Start-Process -Verb RunAs` (a
visible UAC prompt; declining it stops the run), re-reads the pairs to verify,
and saves `port-pair.json` next to the scripts. That file is machine-local and
excluded from `package.py` builds.

**HHD/manual fallback:** create the pair in HHD Virtual Serial Port Tools (or
another signed driver) as before, then record it:

```powershell
.\setup-virtual-pair.cmd -Manual -NspPort COM10 -EmulatorPort COM11          # dry run: checks both ports look virtual
.\setup-virtual-pair.cmd -Manual -NspPort COM10 -EmulatorPort COM11 -Apply   # saves port-pair.json only
```

`-Manual` makes no system changes; it refuses ports that are absent, USB/ACPI
or not identified as virtual. Without `port-pair.json`, everything behaves as
before: `start-emulator.cmd` prompts for the port and the workbench lists all
identified virtual ports.

With `port-pair.json` present, `start-emulator.cmd` without `-Port` uses its
`emulator_port`, the workbench preselects that port, and the NSP discovery
prompt offers `nsp_port` first. **NSP discovery labelling is still a separate
step:** NSP only lists ports described as Haltech, so `set-nsp-port.ps1 -Port
COM10` (or the workbench prompt) is still needed once on the NSP end, for
either driver.

Unverified: this helper has not been run against a real com0com install
(com0com is not installed on the development machine), `-Apply` has never
been executed, the `RealPortName` parameter form, whether `setupc list` works
without elevation, whether `set-nsp-port.ps1` can relabel com0com ports, and an
NSP connection through a com0com pair are all untested. Only detection,
dry-run, refusal and no-driver paths were run, plus unit tests with fixture
`setupc` output. See `docs/COM-SETUP-TEST-CHECKLIST.md` for the manual checks. If NSP does
not connect, return `state\emulator.log` and the port-helper output. If there
is no protocol traffic, diagnose discovery/port pairing before changing maps.

## Capture NSP Traffic

Start the virtual dash with a fresh capture file while NSP is connected:

```powershell
.\start-emulator.cmd -Port COM11 -CaptureLog '.\state\media-probe.jsonl'
```

Raw request and response packets are included by default as Base64, alongside
timestamps, sequence, address, length, CRC validity, hashes, resource
operation/status, and update-region labels. Use `-MetadataOnly` only when you
want to omit payload bytes. The capture also records resources returned to the
isolated renderer through the local viewer API as `viewer_resource` events,
including status, size, SHA-256, and raw response bytes unless `-MetadataOnly`
is set. Stop with Ctrl+C after the test so the session is flushed. Raw captures
can grow quickly and include private settings, images, and package data; review
them before sharing.

The paired asset fixture is
[`zak-2.36-media-probe.nexmap`](../ic7-custom-dash/build-nsp-map/zak-2.36-media-probe.nexmap).
It preserves all original map settings and adds static, GIF, and MP4 probes.
It does not select the MP4 or install the resource `.nex`. The capture contains
only bytes exchanged with the virtual dash. NSP's embedded AES keys are not
transmitted on this serial link; the offline decoder reads its resource key
from the reference updater in memory and never saves/logs the key.

## Resource Update Sandbox

The source-confirmed `0001` command now reports boot mode in identity byte 9;
`0000` restores the normal identity. The mode change is simulated and is not
written into the persisted identity. This fixes the observed stall before
resource transfer. Windows NSP retesting of this fix is still required.

Stop any previous emulator instance and keep the physical dash disconnected.
Use the new `mapfix` candidate ZIPs; the earlier HDEF-less candidates can send
the resource bytes but fail NSP's following map-migration step. Extract the
candidate ZIP separately from the emulator ZIP. Keep its NEX,
`build-report.json`, and `HalImage.qml` together. Use the exact same NEX in NSP
and in this command, with the candidate's actual absolute path:

```powershell
.\start-emulator.cmd -Port COM11 -FreshSandbox -SandboxPackage 'C:\IC7\media\ic7-2.36-media-cfw-mapfix-alias-experimental.nex'
```

`-FreshSandbox` creates a new uniquely named directory under `sandbox-state`
without deleting existing runs or touching the normal `state` directory.
The terminal prints that directory. `protocol.jsonl` with raw bytes and
`emulator.log` are created there automatically; Ctrl+C also saves `session.json`
and `memory.zip`. Pass `-State` to choose a different parent directory.

Connect NSP to COM10 and select that same NEX for the virtual device's update.
The resource sandbox rejects full firmware packages, non-resource staging
regions, writes outside boot mode, gaps, corrupted bytes, and wrong completion
metadata. Exact duplicate fragments are accepted. Source-confirmed command
`0000` returns the emulator to main mode. If NSP returns to main after sending
the complete byte-matched resource, the workbench reports `transfer-complete`
and can load the matching QML sidecar for a **local preview**. This does not
prove target decryption, flash installation, or component execution. An
additional synthetic `0004` check is retained for offline protocol tests; the
attached NSP session did not send it, so it is not required for this observed
completion path. `0003` is Wi-Fi/Bluetooth initialization, not update status,
and is explicitly unsupported.

`session.json` and `/api/status` report the mode, expected and received byte
counts, transfer status, last error, and whether a preview component is active.
An exact full payload is saved as `sandbox/received-resource.enc`; the status
becomes `transfer-complete` only after NSP returns to main mode. This confirms
transport and mode transition, not target-side decryption or physical flash.

After return to main mode, a candidate QML sidecar is exposed to the private
renderer only if its hash and the NEX hash match the supplied build report.
This is a trusted build-sidecar simulation, not extraction of the staged
encrypted resource. The workbench reloads the private renderer after an update.
For command-line simulator sessions only, start the bridge:

```powershell
.\start-stock-renderer.cmd
```

It automatically loads an active sandbox component. Explicit `-Component` or
`-PatchedImages` overrides take precedence. If components change while the
renderer runs, the bridge validates the sidecars and restarts its child renderer
automatically to discard cached QML.
Startup playback requires QtMultimedia in the Windows preview runtime even
when a GIF-only component override is selected. Missing modules remain a reported failure,
not something the emulator can substitute for hardware.

This is a bounded resource-update test environment, not a complete machine
emulator or a security boundary for untrusted QML. Kernel/bootloader execution,
USB re-enumeration, CAN physics, target AES/decompression checks, physical
hardware codecs and recovery are not modeled. Do not use successful sandbox
verification as authorization to flash a real dash.

## NSP Component Reference

The owner's Add Component screenshot supplied on 2026-10-26 shows an Images
section with one Image tile, Numeric Gauges with Numeric and Numeric Retro
tiles, and a Dial Gauges section. It is a reference for the existing NSP UI,
not evidence that its file picker accepts GIF or MP4 files.

The saved map and serial readback already demonstrate an Image component
referencing `u/ic7_animation_probe.png` (GIF bytes). This path can use a
dash-side HalImage change without adding another NSP component tile.
Additional editor properties, file-type filters, media upload handling, or a
new tile are separate NSP-side changes and have not been implemented here.
The installed NSP executable is not patched. Its Windows preview runtime also
needs its own compatible multimedia module for MP4 preview; ARM plugins cannot
be copied into that runtime.

## Live Update Behavior

The protocol emulator acknowledges writes, changes its own memory immediately,
and provides read-back from that updated memory. Settings writes and completed
resource updates have revision counters. Unknown memory reads are logged and
return zeroes; this fallback is not a claim that every device service is modeled.

Resource RPC writes return their results inline, rather than a plain write
acknowledgement followed by a separate read. The initial Windows test exposed
this defect as repeated resource queries with roughly 1.5-second pauses.
The corrected resource-count reply has 19 bytes (header, 3-byte result, CRC),
matching NSP source and the physical capture. This correction passed local
regression tests; its Windows retest is pending.

The **original renderer bridge** follows the matching source:

- `NSP.UserInterface/VirtualDashAppPanel.cs` launches the actual preview program.
- `c/CB.cs`, class `cb`, sends individual setting bytes or complete settings
  buffers to their memory addresses and forwards the channel buffer.
- `c/CC.cs`, class `cC`, implements the named-pipe framing and acknowledgement.
- Each IPC message is command 1, three zero bytes, a big-endian 32-bit address,
  big-endian length, data and standard big-endian CRC-32.
- The bridge polls changed address ranges at 20 ms intervals, forwards exact
  bytes, and sends the source-confirmed refresh command after updates.
- The stock channel buffer is forwarded every 100 ms. Sensor data is captured,
  not a live CAN/GPS simulation; no plausible-looking readings are fabricated.
- Completed user resources are copied before setting references are forwarded.

A private copy of the renderer and its resources is created under
`state\stock-renderer`. Its pipe name is isolated as `SIM_Dash_Pipe`, and its
window name is isolated too. Installed NSP files are never changed. The private
copy's cryptographic executable signature, if present, is no longer valid
after these same-length namespace substitutions; this is not bypassing Windows
signing policy. Antivirus may flag modified executables. Do not disable it;
report the error and use the fallback viewer while investigating.

To compare the older GIF-only component in this **private renderer only**:

```powershell
.\start-stock-renderer.cmd -PatchedImages
```

The default now uses the shared GIF/MP4 component; this flag selects the older
GIF-only `HalImage.qml` instead (MP4 splash playback will not work with that
override). For a custom
component candidate, pass its source path instead:

```powershell
.\start-stock-renderer.cmd -Component 'C:\path\to\HalImage.qml'
```

The renderer checks that its private runtime contains the `QtMultimedia` QML
module before loading this media component. If the installed NSP preview runtime
lacks that module, use the Qt 5.9.6 target-stack test; do not copy ARM plugins
into the Windows runtime.
The bridge retries brief resets of the emulator's local HTTP viewer API. If it
continues to fail, verify the emulator process and viewer are still running.

The browser asset preview also plays MP4 image resources, and the private stock
renderer receives complete image/font resources from NSP. These paths test
resource behavior only. The emulator does not parse or execute firmware updates,
write flash, emulate A/B boot, or prove that NSP accepts a `.nex`. Keep the
physical dash disconnected.

## Viewer Modes

The browser displays live traffic, received 800x480 BMPs, asset previews, and
an **approximate** settings-driven layout. Its numeric placeholders are not
the original renderer and must not be mistaken for real sensor readings.

An optional native fallback uses individual stock QML components with a
partial property mapping:

```powershell
.\.venv\Scripts\python.exe .\native_view.py
```

The original-renderer bridge is the fidelity target; the fallback reports
unavailable sensor values and unsupported component types explicitly.

## Persistence and Boundaries

- State, resource files, staged writes and logs live under `state/`.
- Ctrl+C saves mutable memory. Restart with the same state directory to retain it.
- For a clean session, stop the simulator and move `state/` aside.
- Main/boot identity transitions and resource-only transfer verification can be
  simulated with `-SandboxPackage`; USB disconnect/re-enumeration and a real
  bootloader cycle are not modeled.
- Firmware writes are staged locally. They do not execute firmware, implement
  A/B flash updates, prove package installation, or validate physical recovery.
- The original renderer's full Windows connection/startup and long-running
  NSP edit behavior remain unverified until tested on the owner's PC.
- The profile includes private vehicle assets/configuration from the captures.
  Do not publish it without reviewing its contents.

Restore the virtual-port description when finished, in administrator PowerShell:

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\set-nsp-port.ps1 -Port COM10 -Restore
```

## Verification

```powershell
.\.venv\Scripts\python.exe -m unittest discover -s .\tests -v
```

`tests/test_virtual_pair.py` covers `setupc list`/`pnputil`/ComDB parsing,
HHD port/service selection, pair planning and port-conflict refusals, config
round-trips, and the dry-run/confirmation/no-driver command-line paths with
fixture data and mocks; it never runs `setupc` or requires a driver.
Local checks cover CRC rejection, fragmented/coalesced requests, write/read-back,
identity, persistence, image/font resource operations, resource checksum rejection,
uploaded BMP display, live setting writes changing scene/pixels, and the
source-derived original-renderer pipe contract. Desktop/mobile browser checks
and a fallback Qt screenshot also passed. Passing these does not establish an
NSP connection or a physical-dash match.

The optional `--tcp 127.0.0.1:54001` transport is for protocol test clients,
not an NSP network-discovery endpoint. NSP connectivity uses the virtual COM pair.