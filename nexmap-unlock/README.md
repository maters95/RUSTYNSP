# Nexmap Password Remover

A small Windows utility that removes **password protection** from Haltech NSP
`.nexmap` calibration files. Its purpose is recovery: when a tuner closes shop or
becomes uncontactable, owners can still open and edit maps they have already paid
for, instead of being permanently locked out.

> Use this only on maps you own or are authorised to modify.

## What it does

A `.nexmap` is a ZIP archive whose entries are encrypted with WinZip **AES-256**
using a single fixed, application-embedded password (the same for every file NSP
produces). The per-tuner "protection" is **not** the ZIP password — it lives
inside the plaintext `_map` XML entry:

| Field | Meaning | Open state |
|-------|---------|-----------|
| `<IsProtected id="8">` | protection flag | `00` |
| `<Password id="1503">` | `MD5` of the tuner's chosen password | all zero |
| `<G id="9496">` | 4096-byte bitmap of which settings are locked | all zero |
| `<MD5>` | integrity hash over every setting's raw bytes | recomputed |

Unlocking resets the three protection fields to their "open" state and
**recomputes the `<MD5>` integrity hash** so NSP accepts the file. The archive is
then repacked with the same AES-256 password, so NSP opens the result normally
with no prompt.

The transform was validated against a genuine protected/unprotected map pair: the
tool's output reproduces the authentic unprotected file byte-for-byte (every
non-`_map` entry identical, and the recomputed integrity hash matching the real
unprotected map exactly).

## Usage

1. Run `NexmapUnlock.exe`.
2. **Drag one or more `.nexmap` files** onto the window (or click *Choose files…*).
3. By default it writes `<name> (unlocked).nexmap` next to the original. Uncheck
   the box to overwrite the original in place instead.
4. Open the result in NSP — it loads without asking for a password.

You can also pass file paths on the command line (or use "Open with"); each is
unlocked next to the original.

## Interface

- The title bar places **Minimise** to the left of **Close**, with Close at the
  far right.
- The drop area, copy/overwrite toggle, and activity log stay within the window
  when it is resized. Layout and custom controls support Windows DPI scaling.
- A matching yellow unlock/N logo appears in the title bar and drop area, and
  is embedded in the EXE for Explorer, the taskbar, and Alt+Tab.
- Completion and error messages use colons rather than em dashes.

The current self-contained Windows x64 build is
`dist/NexmapUnlock-v1.0.1-win-x64.zip`. Extract it and run `NexmapUnlock.exe`.

## Building

Requires the .NET 8 SDK (or newer) on Windows.
Cross-publishing from Linux also works with the same `dotnet publish` command.

Self-contained single-file exe (no .NET install needed on the target machine,
~63 MB):

```cmd
build-windows.cmd
```

or manually:

```cmd
dotnet publish -c Release -r win-x64 --self-contained ^
  -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true
```

Smaller framework-dependent build (~2 MB, requires the
[.NET Desktop Runtime](https://dotnet.microsoft.com/download) on the target):

```cmd
dotnet publish -c Release -r win-x64 --no-self-contained -p:PublishSingleFile=true
```

### UI regression checks

On Windows with the .NET 8 SDK and Desktop Runtime:

```cmd
dotnet run --project tests/UiSmokeTests.csproj -c Release
```

The checks cover default/minimum/enlarged layouts at 100%, 150%, and 200%
layout scales, control and label bounds, painting, title-bar button order and
actions, the logo, and copy/overwrite toggle behavior. Scaling in these checks
is simulated; also check the app on a high-DPI Windows display.

### Logo assets

`Assets/logo.svg` is the editable logo source. The generated `logo.png` is
embedded in the app, and `app.ico` supplies Windows icon sizes from 16 to 256 px.
To regenerate them (Python with Pillow and CairoSVG installed):

```sh
python Assets/generate-icons.py
```

## Project layout

- `NexmapUnlocker.cs` — the core transform (archive key derivation, protection
  reset, integrity-hash recomputation, repack). Kept dependency-light and UI-free
  so it can be reused elsewhere.
- `MainForm.cs` — drag-and-drop WinForms UI.
- `Program.cs` — entry point with command-line / "Open with" support.

## Browser version

The [self-contained website](../nexmap-web/README.md) provides the same recovery
workflow without installing the Windows app. Users choose a file, confirm
permission, and download an unlocked copy. All processing happens locally in
the browser, with no account, payment, or file upload. See its README for local
development, static hosting, limits, and validation.

## Notes

- Uses **DotNetZip** for WinZip-AES ZIP handling — the same library family NSP
  itself uses, so the output format matches exactly. The tool only ever extracts
  entries into memory (never to disk by entry name), so the DotNetZip extraction
  path-traversal advisory does not apply to this usage.
