# Test and flash plan: GIF splash and per-screen GIF alarms (2026-10-30, r3)

Each stage has a gate: do not start the next stage until every check in the
current one passes. If anything fails, stop, note which check failed, and
keep the capture or screenshots.

## What to use, and what not to use

| Use | File | SHA-256 |
|---|---|---|
| Kit (r4) | `dist/ic7-final-windows-test-2026-10-30-r4.zip` | `c1f3ae0e2da6582383f148f73d6ed9a7e6f091b806e7f7b3fcc6bafb71afe3be` |
| NEX (inside the kit) | `NSP-test-kit/firmware/ic7-2.36-screen-alarms-experimental.nex` | `dec4e3bf0651c468dc31adac3f8e791ce48c458ae7feee192d72e56404874d3c` |

**Do not flash** any earlier custom NEX:
- `3f6d26f1…` (r2): superseded by the alarm z-order fix. A full-screen custom
  GIF banner (KFC LIMITER) could cover a stock warning such as OIL PRESSURE.
- `7d3f8c96…`: has the wrong folder path. This is the one that failed.
- `9f4f449f…` and `a6c47d35…`: have the path fix, but lack the later fixes.

The folder path is the proven cause of the failed flash. The fresh QML
timestamps are only a precaution: your earlier GIF/MP4 screen flash shows the
dash does not reuse its QML cache across updates.

Delete the older kits so they cannot be mixed up with r4. The r4 NEX is the
same file as r3's.

## Stage 0: preparation (no dash connected)

1. Download the r3 kit and check its SHA-256 against the table (`Get-FileHash`
   in PowerShell). Extract it into a new, empty folder.
2. Keep these backups:
   - the original `Dash-V2-36-0-Release.nex` from Haltech, for rollback;
   - an untouched copy of your current map.
3. Alarm names:
   - Make the KFC LIMITER rule's text exactly match the dash alarm name,
     including case.
   - Keep it within 20 characters.
   - Use no `"` characters.

   The dash sends at most 20 characters, and a quote in any alarm name breaks
   the alarm display. The quote problem exists in stock too.

## Stage 1: NSP on Windows (no dash connected)

1. Run `setup-native-media.ps1` as described in the kit's `START-HERE.md`.
   Use a new destination outside the official install.
2. Launch NSP from that folder. If it fails to start or shows errors, **stop**:
   the rebuilt DLL has not yet been run on Windows by anyone.
3. Open `KFC-screen-5-restored.ic7-2-36-0.nexmap` and check:
   - **KFC LIMITER → Appearance:** the GIF animates, **GIF only** is ticked,
     Screens is `5`, and screen 5 shows behind it.
   - **Startup image:** your splash GIF is selected.
4. Save.

**Gate:** NSP runs, both previews look right, and the map saves.

## Stage 2: emulator

1. Run `ic7-emulator\start-workbench.cmd` with your virtual COM pair. Make
   sure both NSP and the workbench point at the r3 NEX (the SHA-256 is in
   `build-report.json`).
2. Start a fresh emulator session, transfer the NEX, then upload the map's
   settings and resources.
3. Check, in this order:

| # | Check | Pass |
|---|---|---|
| E1 | Reboot the emulated dash | The splash GIF animates, fills the display, and hands over at about 3.3 s |
| E2 | Remove the screen restriction from KFC LIMITER, upload, and trigger it with Simulate | The GIF banner shows on every screen and clears normally |
| E3 | Set Screens back to `5`, upload, and trigger it | The GIF shows on screen 5 only |
| E4 | Change screens while it is active | It disappears on screens 1-4 and comes back on 5. Other alarms show on every screen, and a stock banner such as OIL PRESSURE stays visible over the KFC GIF. |

**Gate:** E1-E4 all pass. If E1 or E2 fails here, the problem is in NSP or the
kit, not the dash, so do not flash.

## Stage 3: flash the physical dash

Conditions:
- stable bench power, not cranking or a weak battery;
- a direct USB cable;
- the stock NEX and your map backed up;
- nothing else running that could sleep the PC.

1. **Start a USB capture** (USBPcap/Wireshark, as for `fail.pcapng`). If
   anything fails, the capture shows exactly what reached the dash.
2. Flash the r3 NEX in NSP. **Never interrupt an active update.**
3. Upload the map's settings and resources (this sends the splash GIF, the
   manifests and the screen markers).
4. **Power the dash off completely, then on again.** A software restart alone
   is not enough, because the splash check needs a full boot.

## Stage 4: on-dash checks, in this order

Run each check before the next one. Each failure points to one layer.

| # | Check | If it fails |
|---|---|---|
| D1 | The splash GIF animates at boot for about 3.3 s | **Stock splash or static image:** the new `main.qml`/`HalSplash.qml` is not running, or `ic7_splash.json` is missing or invalid, its source is wrong, or the GIF did not decode. Send the capture. |
| D2 | KFC LIMITER with no screen restriction, triggered | **Full-screen coloured banner with text:** the rule matched (a matched rule always draws at its own rectangle) but the GIF did not decode; GIF only keeps the stock colour and text until it decodes. **Normal bottom-stacked banner:** the stock popup is still running, or the alarm name does not match the rule text; these look the same, so recheck the names first. **No banner at all:** the popup failed to load, a screen restriction hid it, or the alarm never triggered. |
| D3 | Screens `5`, triggered on screen 5 | **Missing:** screen detection failed |
| D4 | Change screens while it is active | **Shows on every screen:** screen detection failed (it fails visible by design) |
| D5 | Ordinary screen GIF/MP4 images still play | **Regression in HalImage:** report it |

For any failure, reproduce it in the emulator and read its fidelity report
(workbench **Update** tab, or `fidelity-report.txt` in the session folder): it
names the installed NEX and says why any manifest lookup failed.

Expect the earliest kernel boot logo to stay static. That is normal: it runs
before the dash software starts and cannot animate.

## Stage 5: rollback (if the dash misbehaves)

1. Flash the stock `Dash-V2-36-0-Release.nex` through NSP's normal update.
2. Re-upload the map you backed up.

This restores the stock QML. (The custom QML also carries timestamps that
differ from stock, so even a dash that kept a QML cache would recompile the
stock files.)

If the dash does not come up after an update, do not keep power-cycling it.
Retry the stock NEX update from NSP, and contact Haltech support if NSP cannot
see the dash.

## Stage 6: experimental screen add-ons (later)

The add-on NEX (animated indicators and value-driven images) is separate.
Try it only after D1-D5 have passed with the r3 NEX, and test it in the
emulator first. That way a failure can be traced to one change.
To turn an add-on off, upload its empty "off" manifest and power-cycle the dash;
deleting the file on the PC does not remove it from the dash (see
`deploy/addons/README.md`).
