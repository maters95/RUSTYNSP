# Review of the rebuilt NSP DLL's media features

Scope: the animated GIF/MP4 startup splash, the custom alarm-banner editor with
per-screen restriction, and native screen media in `nsp-rebuild/`. The review
compared against the decompiled stock NSP 1.48.5 and the iC-7 v2.36 QML in this
folder. The changes were found by diffing the first `nsp-rebuild` import
(`faf1208`) with the current tip, because `nsp_src/` uses different obfuscated
names.

The Windows Forms UI cannot run in the Linux build container. Everything below
about layout, theming and dialog behaviour comes from reading the code, not from
running it. NSP's obfuscated UI strings were decoded from `Class333` so that the
new text could match NSP's own wording.

## Findings

Severity: **High** means the feature misbehaves silently on the dash.
**Medium** means it is visibly non-native or a workflow is incomplete.
**Low** is polish.

| # | Sev. | Finding | Status |
|---|------|---------|--------|
| 1 | High | A rule's name was accepted at up to 200 characters, but the dash sends at most 20. Any longer rule could never match. A Message longer than 20 characters was also offered verbatim in the alarm list. | Fixed. `AlertMedia.DashName` gives the dash-visible text (first 20 characters, trimmed), and both the list and the Message-ID binding use it. `NameProblem` rejects names over 20 characters (and suggests the 20-character form), names containing `"`, and names with leading or trailing spaces. The check runs in the grid, in **Add alarm** and on Apply. |
| 2 | High | Opening **Appearance...** for an alarm with no rule, then pressing OK, saved a default rule (`0,420 860x60`). That turned a bottom-stacked stock alarm into a positioned one, so it no longer stacked with other alarms. | Fixed. The untouched placeholder row is not saved. |
| 3 | Medium | Nothing warned about rules that match no alarm in the map. They never show. | Fixed. **Add alarm** and Apply ask for confirmation (themed OK/Cancel). |
| 4 | Medium | All new messages used `MessageBox.Show` (7 calls). Stock NSP has none: it always uses its themed `Form54`, which follows dark mode. | Fixed. Every new message now goes through `Form54`. Titles follow NSP's style, for example `Error` in the splash panel. |
| 5 | Medium | The dialog chrome was not native. It had a default WinForms icon and its own taskbar button. It did not use NSP's font. Its grid was white in the dark theme. OK and Cancel sat in the middle of the editing buttons. | Fixed. Same conventions as NSP's image-library dialog: `Font = form23_0.Font`, no icon, not in the taskbar, no minimize button. The grid uses NSP's CAN-editor theme colours and has no row headers. Editing actions are on the left; **OK / Cancel / Apply** sit bottom-right in Windows order at NSP's 92 x 30 size, beside the status line. |
| 6 | Medium | **Cancel** or the window's close button discarded edits silently. With an invalid cell, WinForms validation could also block closing. **Apply** was always enabled. A failed cell produced two messages. | Fixed. A themed Yes/No prompt asks before discarding unapplied edits, and a cancelled edit cannot block closing. **Apply** is enabled only when something changed (or upload is ticked). The duplicate message is removed. |
| 7 | Medium | The tree's **Appearance...** item appeared for alarms on every device, which then only got an info box. The main-menu item was appended to the end of Setup, always visible, and named in a different style from its neighbours. | Fixed. The tree item and the menu item show only for iC-7 v2.36 maps (`Form23.SupportsDashMedia`). The menu item is now **Setup > Dash Alarm Appearance**, after **Dash Images Library / Dash Fonts Library**, with the same visibility rule and enabled state as **Dash Images Library**. The page button and the tree item are **Alarm Appearance...** (title case, like **Duplicate Alarm** / **Remove Alarm**). |
| 8 | Medium | The 1 x 1 screen-tracking markers (`ic7_screen_N.png`) appeared in the user image library, where they could be picked or deleted. | Fixed. The library hides them. The QML's native-screen fallback still covers a deleted marker. |
| 9 | Medium | Large media had no warning. | Fixed, as advice only. On iC-7 maps, the import picker asks for OK/Cancel confirmation for media over 4 MB and for animated GIFs whose frames exceed 860 x 480. The thresholds are a judgement, not measured i.MX6 limits. |
| 10 | Medium | **Also upload to connected dash** sends the alert media synchronously on the UI thread, with no progress display. A large GIF freezes the dialog until the transfer ends. The transport is per-request locked (`Class4`), so this is not a data race. | Left unchanged. A progress/background design needs NSP's progress form and Windows testing. Documented here. The normal map resource upload, which uses a background worker, is unaffected. |
| 11 | Low | `method_226` (WriteUserResources) now stops at the first failed resource. Stock NSP collected the errors and carried on. Neither the startup splash nor the remaining resources are sent after a failure. | Left unchanged. Stopping avoids reporting a half-written map as complete. This is a behaviour change from stock. |
| 12 | Low | Files upload in `Directory.GetFiles` order, so a manifest can arrive before its GIF. Until the next start the banner shows its stock background (by design); the dash restarts its application after a map upload. | Left unchanged (graceful). |
| 13 | Low | `SyncAlertMessage` runs on every string-setting change notification. Bulk reads can call it many times. It reads a small JSON file and, only if something was renamed, refreshes the renderer pipe. The thread that calls it during device reads was not established. | Left unchanged; unverified on Windows. |
| 14 | Info | The splash duration has no user control. It is fixed at 3300 ms, the maximum the QML accepts. The choice between static and animated splash follows the file type picked in NSP's existing startup-image selector. | Left unchanged, by design. |

These were checked and found correct:

- **Manifest formats.** `ic7_splash.json` is version 1 with `source` and `durationMs` ≤ 3300. `ic7_alerts.json` has camelCase `text/source/x/y/width/height`, plus optional `gifOnly` and `screens`. Both match what `HalSplash.qml` and `HalAlarmPopup.qml` validate. The extra `messageDataId` field is ignored by the QML.
- **Disabling.** Turning features off uploads a replacement manifest: an empty splash `source`, or an empty `banners` list.
- **Uploads.** Device resources are skipped by CRC (`UploadImageResource` checks a live device listing) and all go under `u/`.
- **Renderer staging and gating.** Renderer staging is gated to the iC-7 v2.36 context, and a staging failure falls back to the stock renderer.
- **Bad input.** A malformed manifest raises `InvalidDataException`, which the editor's opener catches and shows.

## Changed files

- `nsp-rebuild/NSP/AlertMedia.cs`: `DashNameLength`, `DashName`, `NameProblem`.
- `nsp-rebuild/NSP/MediaResource.cs`: `LargeMediaWarning`, `IsManagedResource`.
- `nsp-rebuild/NSP.UserInterface/AlertBannerEditor.cs`: dialog conventions, validation, dirty state and discard prompt, placeholder handling, themed messages.
- `nsp-rebuild/ns4/Form23.cs`: `SupportsDashMedia`, the Setup menu placement and visibility, themed messages, `DashName` in `SyncAlertMessage`.
- `nsp-rebuild/ns4/Form40.cs`: hides the marker images, adds the large-media prompt.
- `nsp-rebuild/ns2/Control4.cs`: gated **Alarm Appearance...** tree item.
- `nsp-rebuild/ns3/Class117.cs`: page button label.
- `nsp-rebuild/ns1/Control14.cs`: themed error message.
- `nsp-rebuild/README.md`, `ALERTS-TEST.md`, `SPLASH-TEST.md`: UI steps.
- `scripts/tests/test_nsp_ui_conventions.py` (new) and `scripts/tests/test_nsp_alert_media.py` (updated label strings).

No QML change is needed. `FINAL-START-HERE.md` line 50 still says
**KFC LIMITER -> Appearance...**. It should now say **Alarm Appearance...**. That
file was outside the editable set, so it is unchanged.

## Not verifiable without Windows

- Actual rendering: dialog layout and DPI scaling, the theme in light and dark mode, tab order, Form54 prompts, and the Setup menu's visibility toggle.
- The editor and picker GIF animation.
- Renderer staging and the `.qmlc` deletion, Qt plugin loading, and the renderer-pipe refresh.
- Synchronous upload from the dialog, and every behaviour on a physical dash.
