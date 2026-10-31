# iC-7 v2.36 hardware and firmware audit

Offline, evidence-based audit, 2026-10-30. Nothing was flashed and no device
was connected. "App" is the decrypted `nic-7` ELF (sha256 `d86bde81…7248`), and
addresses are its virtual addresses. The scripts are in
[`scripts/hardware_audit/`](../../../scripts/hardware_audit/) and their outputs
in [`evidence/`](evidence/).

## 1. Verdict

- **r3 NEX (`dec4e3bf…4d3c`): correct, no blocking defect.**
  - Only the intended four members differ from stock.
  - The wrapper, HDEF and manifest identity are right.
  - Every contract the four QML files rely on matches the app.
  - Two observations (§2.4): F1, resource cost in every HalImage, and F2,
    the splash covering the alarm popup at boot. F2 is kept by owner
    decision.
- **Add-on NEX: correct.** It inherits F1 and F2 from its r3 base. This audit
  examined the earlier add-on build `1f6e36c7…8167` (5 added files); the
  current one, `e1ca76e7…c59f`, also adds `Ic7Clock.qml` and `Ic7TrackMap.qml`,
  and its counts below were re-checked on 2026-10-31.

## 2. NEX correctness

Reproduce with `python3 scripts/hardware_audit/nex_diff.py --out <dir> <nex>...`
(→ `evidence/nex-diff.json`). `scripts/audit-nex.py` was also run against the
dash sysroot.

### 2.1 Package, wrapper, HDEF, tar

| Check | Stock | r3 | Add-on |
|---|---|---|---|
| ZIP | 24 members | manifest.xml, res_ic-7.qzip, ic-7.hdef; stored, CRC ok | same |
| ic-7.hdef | b89bdab9…a715 | identical | identical |
| Wrapper words 0-6 | 2,0,0,0x25000000,0x80,0x4000,0xfa0 | identical | identical |
| Wrapper bytes 28-44 | a9dfc896…9954 | stock copy | stock copy |
| Tar | 339 entries (329 files) | 340: 326 identical, 3 changed, 1 added, 0 removed, order kept | 347 (337 files: 322 identical, 7 changed, 8 added) |
| New mtimes | stock 1790648083/84 | 1767313730, 1710892354, 1711391189, 1759212789 (unique) | unique |

- **The 16-byte wrapper field** matches no MD5 of the body or the plaintext,
  even in stock. NSP never sends it: no outbound URB in "ic7 real flash
  cfw.pcapng" or fail.pcapng contains it. Only the body goes to 0x25000000;
  the real flash wrote exactly 17,377,280 bytes there.
- **Tar format:** the candidates use GNU tar headers, while stock uses POSIX
  headers. The watchdog applies the archive with `tar -xf`, the rootfs has GNU
  tar, and the earlier GIF/MP4 flash already extracted this format on
  hardware.
- **File mode:** HalSplash is added with mode 0644, which is harmless because
  the app reads it as root.

### 2.2 Manifest fields

| Field | Value | Checked against |
|---|---|---|
| pid/vid | 21 / 11 | HDEF `<Framework product="21" variant="11" version="2.36.0 - Release:0">`; NSP Class237.method_0 rejects a mismatch; the app's `read_variant_id()==0xb` gates |
| hwid | 1,2,40960 | `init_uart` 0x415f0 selects the iC-7 UART for 1, 2 and 0xa000; `get_chip_status` 0x32cd8 treats 0xa200/0xa600/0xac00 as uC-10. The list covers every iC-7 hwid. |
| version | 2.36.0.0.0 | equals the running app; no app stage is listed, so nothing is downgraded |
| omitted fields | releaseNotesFile; hdef, nic-7 and dstm stages | NSP accepted this shape in the real capture; the watchdog's `do_resource_upgrade()` (0x17e14) applies it via `aes_decrypt_start(…, type 1)` |

The v2.36 NEX has **no kernel or bootloader stage**. The iC-7 product lists
ic-7.hdef, res_ic-7.qzip, nic-7 (app) and dstm (STM32). The kernel, U-Boot and
DTB live in NAND (U-Boot `nandboot`: kernel at 0x400000, DTB at 0x3e0000).

### 2.3 Contracts re-derived from the ELF

Listings are in `evidence/app-qml-contracts.s`.

- **Load order:** `UIMain::UIMain` 0x11728c calls `setSource(main.qml)` before
  it creates the screens and the popup.
- **Canvas and panel:** the canvas is 860×480 (QSize literal 0x117008,
  `setScreenSize` 0x117654). The panel is 800×480 (bootargs
  `mxcfb0:dev=hdmi,800x480M@60`). So xScale 800/860 is correct, and the
  splash's inverse scale fills 800 physical pixels.
- **Dash variant:** `setDashVariant(11)` is called on the root (0x1177a0) and
  on the popup (0xf4b70).
- **Screens:** `UIScreen` 0x1188e4 does `new QQuickItem(nullptr)` then
  0x1188fc `setParentItem(rootObject)`, five times (0x117850–0x117890). Next
  comes the popup, from `Alarm_Module` (0x1178c4). The native-screen fallback
  is therefore sound.
- **Popup path:** `Alarm_Module` (0xf46ec) loads
  "/opt/applications/dtn/resources/qml_components_data/qml" +
  "/user_components/HalAlarmPopup.qml" as a scheme-less QUrl (0xf49a0) and
  parents it to the root (0xf4a10). The working directory is
  /opt/applications/dtn/app. The 4-level user_resources path is therefore
  correct.
- **Alarm message:** `draw_alarms` 0xf3efc calls `reInitAlarmScreen` with
  text, bc, height, img and fc (0x12a838–0x12a884). The name is copied with
  `strncpy` into a fixed-width field, so trimming it before the exact match is
  required. The app then sets z = 99 (0xf3f08 `mov r1,#0x63`; 0xf3f28
  `setProperty("z")`). That places the popup above the screens, below fg_tint
  (z 999, as in stock) and below the splash (z 10000, see F2).
- **QtMultimedia** is not in the app's NEEDED libraries; it is reached only
  through QML. HalSplash, HalAlarmPopup and main.qml use QtQuick only. The
  add-ons load Video through a Loader.

### 2.4 Issues found

- **F1: a QtMultimedia `Video` in every HalImage.**
  - Each image component, static PNGs included, creates a QMediaPlayer in
    `classBegin()` and with it a GStreamer playbin session. A QtMultimedia
    fault could affect every image.
  - Suggested fix: move the Video into a Loader-loaded `HalImageVideo.qml`.
  - Assessment: this is the hardware-proven videofix design, and the owner's
    screens with images work, so it is a cost and robustness improvement, not
    a defect. It is deferred until r3 has been confirmed on the dash, because
    it changes the one component proven on hardware.
- **F2: the splash covers the alarm popup at boot. Kept as designed (owner
  decision).**
  - The splash (z 10000) is above the popup (z 99), so the on-screen popup
    for an alarm active at key-on appears up to 3.3 s after the app starts.
  - This matches the OEM experience, where no alarms show during the stock
    splash (the kernel logo shows before the app runs).
  - The app drives the alarm and shift LEDs natively, so the QML splash does
    not hide them.
  - The alternative, if wanted later: end the splash from
    `HalAlarmPopup.rebuildAlarms()` when an alarm is active.

Low-risk observations, needing no change:
- The native fallback returns no screens if an extra unnamed item comes before
  the popup. Restricted alarms then show, which fails safe.
- Dropping `import "../../fonts"` has no effect.

### 2.5 Add-on NEX

- **Base:** main, HalSplash, HalImage and HalAlarmPopup are identical to r3.
- **Gauges:** the 4 changed gauges are stock plus `IC7-ADDON` blocks.
- **Added files:** the 7 add-on files (besides r3's HalSplash) equal
  `deploy/addons/qml`.
- **Imports:** all exist on the dash, and common.js is a stock member.
- **Package:** the wrapper, HDEF and manifest are identical to r3.
- **Audit report:** its "does not match maintained source" lines are expected,
  because the audit only compares with deploy/nsp.

## 3. Hardware inventory

**SoC and board.** A Variscite VAR-SOM-MX6, i.MX6 DualLite or Solo (U-Boot
"Board: Variscite VAR-SOM-MX6", DTBs, vpu_fw_imx6d), running kernel 4.1.15
(LZO uImage with an embedded .config).

**Device tree.** The DTB that actually boots is in NAND and isn't available
here. The 13 rootfs DTBs were built on the same host and date as the kernel
and agree with the app's device use. They are strong evidence, not proof.

**Pin tables.** The iC-7 pin tables `io::dash_arch_v1`/`v2` contain als, avi,
backlight, button, can_main_connector, dpi, dpo and tacho. Only
`dash_arch_uc10_v1` adds camera_supply, alt_excite and ext_5V0.

Columns: **stock app** = the stock app uses it on the iC-7; **NSP (iC-7)** =
NSP exposes it for the iC-7; **CFW** = our firmware uses it.

| Peripheral | Evidence | Stock app | NSP (iC-7) | CFW |
|---|---|---|---|---|
| LCD 800×480, Vivante GPU | bootargs; galcore.ko | yes | Screens | yes |
| VPU/IPU/G2D | CONFIG_MXC_VPU; gst imxvpu/imxipu/imxg2d | uC-10 camera only | no | MP4 |
| One FlexCAN (can0) | only flexcan@02090000 enabled; only "can0" in app | yes | CAN, Generic CAN | no |
| Second FlexCAN | DT disabled; never opened | no | no | no |
| STM32 I/O on UART4 (ttymxc3) | `init_uart` 0x418cc; dstm app at 0x08010000 | yes | indirect | no |
| AVI 1-4 (+5/6), DPI/SPI, DPO 1-4, tacho, battery/rail/temp, CAN termination | `io::dash_uart::*`; pin tables; HDEF ports | yes | Wiring/Sensors/Outputs | no |
| 6 buttons, GPIO 140-145 | `button_pins`; `PortConnection_Button1-6` | yes | Wiring/functions | no (QML gets no input) |
| LED bar, alarm LEDs and shift lights (spidev0.0) | `ProcessDashLed`; HDEF ALARMS_COMP_n_LED_*, SHIFT_LIGHT_0..13 | yes | Alarms > Lights; Shift Lights | no |
| ALS, I2C 0x52 | `reset_als` ioctl(I2C_SLAVE,0x52); `ALS::read_hardware` 0x3f264 | yes | Screens > Brightness | no |
| Backlight PWM (pwmchip1) | DT pwm-backlight; `backlight_off()` | yes | Brightness Table | no |
| 2 more PWMs | backlight_pins (50,2), (50,0) | yes (purpose unconfirmed) | indirect | no |
| USB OTG gadget | g_serial 16D0:0001; mass_storage/ether only unloaded | yes | NSP link | transport |
| USB host 1 | DT okay; usb-storage/uvcvideo/ftdi/acm present | no | no | no |
| eMMC p1/p2 rootfs A/B, p3 /opt/applications, p4 /mnt/usb | fstab, update.sh | datalog | Datalog Manager | no |
| NAND (SPL, U-Boot, kernel, DTB) | U-Boot env | boot | no | no |
| Ethernet FEC | DT okay; app runs `ifconfig eth0 down` | disabled | no | no |
| UART5 | DT okay; no app use | no | no | no |
| Wi-Fi/BT | WL1835 node in all 13 DTBs; no cfg80211/wlcore/TI firmware; vid-11 gates 0xda6a4, 0xebdb4 | no | settings, no UI | no |
| Camera | uC-10-only supply pin and HDEF settings; `io::func::run` 0x87820 skips on vid 11 | no | no | no |
| Audio/buzzer | no codec node; no audio linked; no buzzer pin | no | no | no |
| RTC | SNVS, DS1307 driver; app sets no time | no | no | no |
| CPU temperature, OTP UID | `CPUTemp`, `read_processor_uid` | yes | channels | no |
| Touch | U-Boot probes I2C 0x38; no app support | no | no | no |

Native app features:
- **Already exposed by NSP for the iC-7:** lap timer, MyLaps and GPS (CAN >
  Haltech CAN System > Track Modules; `CanGPS` IDs 0x4F3-0x4F5; these need
  Haltech modules), keypads, odometer/trip, Generic CAN TX, and Output Test
  (new in 2.36, handled by NSP's own code).
- **Not available:** screenshot is stubbed in v2.36 (0x115f80, 0x1190f8).
- **Dash broadcast:** `CANProtocolDashBroadcast` sends on Haltech CAN and has
  no setting.

## 4. Unused capability, by tier

- **Tier 0:** QML in the resource NEX.
- **Tier 1:** the setting exists but has no NSP UI, so the NSP DLL could
  expose it.
- **Tier 2:** needs app, kernel or rootfs changes.

| Item | Tier | Value | Risk | Confirm first |
|---|---|---|---|---|
| Value-driven indicator images from Emtron Generic CAN data (add-on A3: flags, gear, lap delta) | 0 | High | Low-Med | — |
| Emtron data into channels (Generic CAN RX) | configuration | Med-High | Low | Emtron data set |
| Dash buttons to Emtron (Generic CAN TX) | configuration | Med | Low-Med | free CAN IDs |
| UVC camera in QML (uvcvideo, camerabin) | 0 (conditional) | Med | High | USB host routed to a connector |
| Wi-Fi/BT settings | 1, useless (dead on vid 11) | — | — | — |
| Brightness up/down input descriptors | 1 (unconfirmed) | Low | Low | NSP Wiring |
| UART5, Ethernet, USB host GNSS | 2 | Med | High | routing |
| Wi-Fi/BT radio | 2 (likely impossible) | — | High | fitted? |

**Impossible on the iC-7:** native camera, audio, a second CAN bus, touch.

**App work required:** new gauge types or more than 5 screens, and an animated
kernel logo.

## 5. Corrections to earlier documents

- **Camera:** the reversing camera is uC-10 only, not iC-7.
- **Wi-Fi:** dead on the iC-7 (gated off in the app and no kernel support).
  The WL1835 node is generic to every DTB and isn't evidence of a fitted
  radio.
- **"USB datalogging":** /mnt/usb is eMMC partition 4, not a USB stick.
- **Screenshot:** stubbed.
- **"Waiting on UI":** lap timer, MyLaps, GPS, keypads, odometer/trip and
  ALS/night mode are already exposed by NSP.
- **Backlight:** PWM, not GPIO.
- **NEX contents:** the NEX carries no kernel or bootloader stage.

## 6. Needs physical confirmation

1. The DTB that actually boots and the SoC (Solo or DualLite).
2. Whether USB host 1, UART5 and Ethernet are routed to a connector or pad.
3. Whether a WL1835 is fitted.
4. What the two extra PWMs drive.
5. That NSP's Output Test dialog appears for the iC-7.
6. On the r3 flash: that the alarm LEDs light during the splash (F2), and
   screen-load time with many images (F1).

## 7. Recommended next builds

1. **Flash and confirm r3** (or r4, if the NSP DLL review's changes are
   packaged). F1 waits until it is confirmed on hardware.
2. **Add-on A3**, value-driven indicator images.
3. **Generic CAN configuration with the Emtron**: no build, bench only.
4. **Physical survey** (§6).
5. **UVC camera experiment**, only if USB host is routed: bench only.
