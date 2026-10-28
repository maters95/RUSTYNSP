# Native NSP dash media test (iC-7 v2.36 / NSP 1.48.5)

Use the **videofix** download rather than the earlier native-media ZIPs.
GIF playback was confirmed on the owner's Windows dashboard canvas. The
following video error, `The QMediaPlayer object does not have a valid service`,
exposed an incorrect backend selection: Qt 5.11.3's `wmfengine` provides audio
decoding, not the media-player service. This bundle installs `dsengine` (the
DirectShow player) and its Qt Widgets dependency. Windows video playback still
requires confirmation.

For this video fix, rerun setup from this bundle using the original official NSP
installation as `NspInstall` and a NEW destination, for example
`"$env:USERPROFILE\Downloads\NSP-native-media-videofix"`. Replacing the DLL
alone is insufficient because this fix adds runtime dependencies. Close every
NSP window before setup and launch only the new copy afterward.

The original DLL omitted the standard form resources and crashed on startup
with `MissingManifestResourceException` for `ns4.Form27.resources`.
The corrected build embeds all original resource sets plus the media QML;
build and packaging checks now reject missing form resources.
Do not copy the replacement DLL into the official installation. The matching
NEX is unchanged; no firmware flash is needed for either Windows runtime fix.

This bundle changes the **actual embedded dash renderer**, not just the Image
Source picker or a browser preview. GIF and muted, looping MP4 use the same
`HalImage.qml` in NSP's native Qt renderer and the included resource-only NEX.
It is experimental: Windows GUI execution and installation/playback on a real
dash have not been verified. Do not test while driving.

## Prepare a separate NSP copy on Windows

Disconnect the dash and close **all** NSP and `dash_virtual` windows.
Extract this ZIP into its own folder. In PowerShell, from that folder
(replace `NspInstall` with the folder containing your existing `NSP.exe`):

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\setup-native-media.ps1 `
  -NspInstall 'C:\Program Files (x86)\Haltech\Nexus Software\Haltech NSP' `
  -Destination "$env:USERPROFILE\Downloads\NSP-native-media-videofix"
```

The destination must not exist. The script copies your full NSP 1.48.5 install,
replaces only the copied NSP DLL, and downloads the official Qt **5.11.3 x86
MSVC2015** base/multimedia archives (about 25 MB). Archives and the eight
selected runtime files are SHA-256 checked against the pinned manifest.
Windows tar or 7-Zip must be installed. If tar cannot read the archives, install
7-Zip and rerun. No Qt binaries are redistributed in this ZIP.
The execution-policy option applies only to this setup process, not your
machine's permanent policy.

For offline setup, download the two URLs from `qt5113-runtime.json`, name them
`qtbase.7z` and `qtmultimedia.7z`, and supply `-ArchiveDirectory 'C:\Qt-archives'`.
Qt source and licensing information are available from
<https://download.qt.io/archive/qt/5.11/5.11.3/single/> and
<https://www.qt.io/licensing/open-source-lgpl-obligations>. The downloaded
libraries are dynamically loaded and may be replaced with compatible builds.

Launch **the new copy's** `NSP.exe`, not the original shortcut. Open an iC-7
v2.36 map. Each renderer launch reinstalls the embedded media QML after NSP has
extracted the stock component from the map's HDEF. Its adjacent stale compiled
QML cache is removed. The override is restricted
to iC-7 product 21/vendor 11 and the verified v2.36 component. A mismatched
component, Qt version, architecture, or missing library is a reported renderer
startup error, not a static-image fallback.

**Shared cache:** NSP uses `%APPDATA%\Haltech\Nexus` for its renderer. Opening a
map in this test copy modifies that cache's component and adds media libraries;
it does not modify the official install directory. Do not run official and test
NSP simultaneously. To return to stock, close the test copy and open your stock
v2.36 map in official NSP, which re-extracts its original component. The
`ic7-media-qml` and `ic7-media-plugins` cache directories are only activated by
the test copy's process environment.

## Verify the actual dash canvas

1. Open a copy of the included map, select an Image component, and import
   `samples/animated.gif` (red/green frames).
   Close the picker. Confirm changing frames **on the dash canvas itself**.
2. Select an Image component and import `samples/video.mp4` (a two-second
   H.264, 8-bit YUV420 test pattern). Close the
   picker. Confirm moving video **on the dash canvas itself**. Windows DirectShow
   and Media Foundation components must be available; Windows N editions may need the Media Feature
   Pack. MP4 is a container, not a guarantee of support for every codec.
3. Use a short clip: observe at least two loops, change opacity, resize the
   component, change screens, switch MP4 to PNG and back, and reopen the map.
   Video stays muted. Hidden/screenshot-mode components pause.
4. Save as a new map, close/reopen NSP, and repeat. GIF/MP4 bytes are preserved
   rather than converted to PNG. The old picker still uses an MP4 placeholder;
   video playback is in the actual native dash canvas.
5. Return the new map, NSP/Qt logs, and a short recording of the canvas if
   anything is blank or static. Decode failures are logged and shown as
   `Media error` on the component.

The supplied static PNG provides a baseline. Start with these small samples
before importing your own media. Reserved `ic7_animation_*.png` and
`ic7_video_*.png` names remain supported for existing map resources; do not use
those prefixes for ordinary PNG images.

### If video stays black

Do not flash the dash or install random codec packs to diagnose Windows preview.
The owner's returned `vid test.ic7-2-36-0.nexmap` was inspected offline:
Screen 4 / component 1 selects `u/video.mp4`; that member contains the intact
two-second, 160x90, 15 fps, H.264 High / 8-bit YUV420 test clip. Its component is
860x480 at (0,0), with both opacities at 1000/1000. This rules out a missing
saved clip, reserved-PNG filename mismatch, zero size or zero configured
opacity for that component. It does not prove that the Windows renderer has
loaded the correct QML/backend or produced video frames.

Leave NSP open on the failing screen and run the standalone collector on
Windows (no Python, downloads, runtime patching or device connection needed):

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\collect-native-media-evidence.ps1
```

Return the generated `nsp-media-evidence-*` directory after reviewing it for
private data. It records the actual NSP/renderer process paths, loaded modules,
runtime hashes/versions, cached `HalImage.qml` and existing logs. This distinguishes
the launched build and loaded backend from files merely present on disk.
Collection errors remain in `report.json` and are printed. Run 64-bit PowerShell
with matching process permissions if module enumeration is denied. Environment
values belong to the collector/user/machine, not a readout of the renderer's
private process environment. The collector does not start/stop processes, open
COM ports or send device commands. No playback fix is claimed until Windows
evidence establishes the failing stage.

The execution-policy option applies only to this PowerShell process; do not
override organization-managed policies. Use 64-bit PowerShell on 64-bit Windows.
The updated collector records its architecture and retries incomplete renderer
module enumeration through read-only PSAPI `EnumProcessModulesEx` with
`LIST_MODULES_ALL`. If Qt5Core still cannot be enumerated it explicitly marks
module evidence incomplete. Missing logs are also reported, rather than a
success-shaped empty error list.

The helper no longer references `System.ComponentModel.Win32Exception`, which
failed to resolve in the owner's Windows PowerShell compiler. Native-call
failures report the operation and numeric Win32 error using a core exception
type. The missing-log warning is emitted once, after all roots are searched.

The returned `nsp-media-evidence-20261028-214349` evidence confirms that NSP.dll
matches the videofix ZIP and the cached QML matches the maintained component.
The DirectShow DLL and staged Qt DLLs have the expected hashes **on disk**.
Its module list contains only WOW64 loader modules and no Qt modules, so it
does not establish which media backend is loaded. It includes no application
log. The renderer executable references `dash_app.log`; the collector now
includes hidden logs in its search. The QML cache was created after the source
was installed during this launch, so its existence alone does not demonstrate
that a stale stock component was used.

The subsequent `nsp-media-evidence-20261028-214841` report successfully lists
140 renderer modules using PSAPI. Qt Multimedia 5.11.3, `dsengine.dll`, EVR,
Quartz and Intel OpenGL are loaded. This rules out the missing-player-plugin
failure in this run, but does not prove a clip was opened or decoded. No
identifiable H.264 decoder is listed in that snapshot; that is a lead, not a
codec-failure diagnosis. No renderer/application logs were found.

To isolate the system DirectShow decoding path from Qt presentation, extract
the small video-probe kit and run the test in **32-bit Windows PowerShell**,
matching the renderer's architecture:

```powershell
& "$env:WINDIR\SysWOW64\WindowsPowerShell\v1.0\powershell.exe" `
  -NoProfile -ExecutionPolicy Bypass -File .\test-native-video.ps1 `
  -VideoPath .\video.mp4
```

The probe builds a separate DirectShow graph for the supplied local clip and
reports its HRESULT and filter names to a new `nsp-video-probe-*.json`.
It does not call Run/Pause, change NSP, install/register codecs, or contact the
dash. Registered DirectShow filters execute during graph construction.
Use only a trusted local clip. Negative HRESULTs are failures; positive ones
remain partial/warning results, not full success. A zero result verifies
default DirectShow graph construction only, not decoded pixels or Qt's
custom video-output integration. Return the JSON. This probe's C# compiles
and report/error handling is tested with mocks; actual Windows COM graph
construction remains unverified until run on the owner's PC.

The owner subsequently ran the 32-bit probe on the exact test clip and received
`0x80040265` with no graph filters. Microsoft defines this as
[`VFW_E_UNSUPPORTED_STREAM`](https://learn.microsoft.com/en-us/windows/win32/directshow/error-and-success-codes):
“Cannot play back the file: the format is not supported.” The earlier probe's
generic COM message (“Class not registered”) was misleading; it now reports the
documented meaning for this HRESULT. The result establishes a Windows
DirectShow format-support blocker outside NSP, not a particular missing codec,
nor proof that all Qt presentation issues are solved.

A targeted remediation is the **32-bit/x86 LAV Splitter and LAV Video decoder**
from the [official LAV Filters releases](https://github.com/Nevcairiel/LAVFilters/releases/latest).
This is an optional system-wide DirectShow installation, not an NSP DLL patch;
it can affect other DirectShow applications and may require administrator
approval. Use the official installer and ensure x86 components are installed
even on 64-bit Windows. Do not copy AX files into NSP or install broad third-party
codec packs. After installation, rerun the same 32-bit probe: expect zero HRESULT
and a graph containing a suitable MP4 splitter and H.264 decoder. Only then
restart NSP and check actual moving frames. A graph success alone does not
verify Qt playback. No physical dash change is involved.

## Matching NEX: bench candidate, not confirmed safe firmware

`firmware/ic7-2.36-native-media-experimental.nex` contains the exact same QML
embedded in the matching NSP DLL. It changes only `HalImage.qml` in the stock
resource archive, preserves the other 338 members, and includes the original
HDEF for NSP's migration step. It does **not** replace the bootloader, kernel,
dash executable, or controller firmware. The map/GPS companion is not included.

The build report records component/package hashes, archive membership and
encryption round-trip verification. This is not a hardware installation test
or a recovery guarantee. Keep a backup of your original map and official
firmware. Do not flash until you have a recovery method confirmed for your
exact unit. First check local package parsing and the disconnected virtual
transfer; only then arrange an attended bench test with stable power.

The owner's real-dash Wireshark capture from 2026-10-27 contains a stock v2.36
update: the captured resource, dash executable and controller payloads match
the supplied stock NEX bodies byte-for-byte, with their 44-byte wrappers removed.
It also shows a following settings/bitmap transfer. It is physical update-path
evidence, **not** evidence that this modified NEX has been installed or that
GIF/MP4 playback works on the unit. Reply reassembly and installation-completion
status were not established by that outbound-payload comparison.

## Developer validation and remaining boundary

- The NSP x86 rebuild succeeds; native-runtime staging, component installation,
  idempotence, baseline rejection, and missing-dependency behavior are tested.
- Fifteen focused regression tests pass, including player-service advertisement,
  all original DLL form resources,
  named DLL manifest-resource
  equality, decoded-NEX equality, ZIP checksums, and offline setup with real
  pinned Qt archives. Setup file operations were exercised under PowerShell 7
  on Linux with Windows executable discovery mapped to Linux 7-Zip; this is not
  a Windows installation or GUI test.
- Desktop Qt tests compare changing **rendered pixels** for GIF and H.264 MP4,
  in addition to opacity, looping, source switching, visibility and errors.
- Stock ARM Qt 5.9.6/QEMU tests exercise GIF frame advance and MP4 playback,
  looping, and pause/resume. The ARM headless/software stack cannot capture the
  rendered frames reliably; pixel tests run separately on desktop Qt.
- These are not Windows Qt 5.11.3 GUI or i.MX6 hardware/display tests. Those
  checks remain required; do not infer them from a successful build or transfer.
