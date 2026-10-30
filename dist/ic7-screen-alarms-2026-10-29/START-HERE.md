# Screen-scoped alarms: KFC Limiter on screen 5

This is an experimental, matching NSP DLL/resource-only NEX/emulator test
bundle. It is not approval to flash a physical dash. Keep the official NSP,
working firmware and your original map unchanged.

## Set up the matching NSP

1. Extract the entire ZIP into a new directory. Disconnect the real dash.
2. From PowerShell in that directory, run:

   ```powershell
   powershell.exe -NoProfile -ExecutionPolicy Bypass -File .\NSP-test-kit\setup-native-media.ps1 `
     -NspInstall 'C:\Program Files (x86)\Haltech\Nexus Software\Haltech NSP' `
     -Destination "$env:USERPROFILE\Downloads\NSP-screen-alarms"
   ```

   Use your actual official NSP installation path. Do not select an older
   modified test installation as the source. Stop if setup reports an error.
3. Start NSP from the new destination and open
   `NSP-test-kit\map\KFC-screen-5.ic7-2-36-0.nexmap`.

## Apply the screen bridge once

1. Open Alarm 10 / KFC LIMITER and click **Appearance...**.
2. Scroll the grid right if needed. **Screens (All or 1, 3, 5)** is already `5`.
   The full-screen GIF and GIF-only option remain as in your supplied map.
3. Click **Apply**, then **OK**, and save the map normally.
4. Apply installs a transparent 1 x 1 image component in an unused slot on each
   screen. The prepared map intentionally preserves the original native
   settings and integrity bytes; NSP performs these setting edits itself.
   Do not skip Apply and assume that a JSON restriction alone is sufficient.
5. Leave Low Oil Pressure set to **All**. Other alarms retain their existing
   scope, activation, acknowledgement, clearing and LED behaviour.

For another alarm, enter `All`, a single screen such as `5`, or a list such as
`1, 3, 5`. Reapply appearance after adding, copying or replacing screen layouts
so NSP can repair the managed bridge components. Do not move/edit those components.

## Test on the emulator first

Use the included updated `ic7-emulator` and your existing verified virtual COM
pair. Do not connect its transport to the physical dash. See
`ic7-emulator\README.md` for setup.

Use only `NSP-test-kit\firmware\ic7-2.36-screen-alarms-experimental.nex` for this
test's sandbox component update, then transfer the saved map settings and
resources from the matching NSP. The emulator does not execute or physically
install the ARM firmware; a completed transfer does not verify a real flash.

With KFC LIMITER active:

- Screens 1-4: no KFC GIF, text or banner.
- Enter screen 5: show the KFC GIF without retriggering the alarm.
- Leave screen 5: hide it immediately.
- Clear the alarm and return to screen 5: it stays hidden.
- Trigger Low Oil Pressure: its warning remains available on every screen.

Screen identity is driven by native container visibility, not a polling timer.
If tracking is missing, warnings deliberately remain visible and a QML warning
is logged. This is a safety fallback, not successful screen filtering.

## What was checked

The accompanying validation report records local C# build, manifest/marker
planning, real Qt rendering, ARM Qt/QEMU component tests, emulator tests,
archive hashes and resource-preservation checks.

The NEX changes only the three shared QML files and adds the startup component,
preserving 336 other resource members and the stock HDEF. It does not patch
the application executable, alarm engine, kernel, bootloader or STM32 code.
The map changes only the alarm-appearance manifest before the native Apply
step; its images, other alarm configuration, layouts and 3.3-second splash
configuration remain unchanged.

Windows NSP GUI operation, real hardware screen switching, physical flashing,
boot and recovery have not been verified. Earlier Windows runtime/synchronization
concerns are not cleared by these local tests.
