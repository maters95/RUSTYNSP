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

## Building

Requires the .NET 8 SDK (or newer) on Windows.

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

## Project layout

- `NexmapUnlocker.cs` — the core transform (archive key derivation, protection
  reset, integrity-hash recomputation, repack). Kept dependency-light and UI-free
  so it can be reused elsewhere.
- `MainForm.cs` — drag-and-drop WinForms UI.
- `Program.cs` — entry point with command-line / "Open with" support.

## Notes

- Uses **DotNetZip** for WinZip-AES ZIP handling — the same library family NSP
  itself uses, so the output format matches exactly. The tool only ever extracts
  entries into memory (never to disk by entry name), so the DotNetZip extraction
  path-traversal advisory does not apply to this usage.
