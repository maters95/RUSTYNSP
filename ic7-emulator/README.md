# iC-7 NSP Simulator

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
NEX and does not verify firmware playback. On Windows, **Stock Renderer**
uses NSP's private original renderer when its installed runtime is available.

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
8. In another terminal, start the original-renderer bridge:

   ```powershell
   .\start-stock-renderer.cmd
   ```

   This uses the verified `dash_virtual.exe` and 32-bit Qt runtime already
   installed at `%APPDATA%\Haltech\Nexus`. If your path differs, pass
   `-Runtime 'C:\path\to\Haltech\Nexus'`.

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
encrypted resource. Start the private renderer after the update:

```powershell
.\start-stock-renderer.cmd
```

It automatically loads an active sandbox component. Explicit `-Component` or
`-PatchedImages` overrides take precedence. If the component changes while the
renderer runs, the bridge stops and asks for a restart because QML is cached.
The GIF/MP4 candidate requires QtMultimedia in the Windows preview runtime;
the GIF-only candidate does not. Missing modules remain a reported failure,
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

To compare the bundled GIF/MP4-capable component in this **private renderer only**:

```powershell
.\start-stock-renderer.cmd -PatchedImages
```

This selects the candidate `HalImage.qml` in the isolated runtime. For a custom
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