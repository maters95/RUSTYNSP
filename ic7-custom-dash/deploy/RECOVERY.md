# Recovery & brick-safety for the iC-7 (READ BEFORE FLASHING)

## The most important point
**Testing does not risk a brick.** The `ON-DASH-TEST.md` method copies the app
to `/mnt/usb` scratch and runs it by hand — it writes NOTHING to firmware. Worst
case is "it didn't launch; power-cycle; you're back to stock." So you can prove
the app works on your dash with **zero** brick risk, and you never have to flash
to do that.

Brick risk exists ONLY at the permanent-install step (flashing firmware,
`DEPLOY.md`). Everything below is about making THAT step recoverable. Do not
flash until the recovery path is confirmed on your unit.

## How the hardware can be recovered (i.MX6 / VAR-SOM-MX6)
The SoM is a Variscite VAR-SOM-MX6 (NXP i.MX6). Two standard recovery routes:

1. **USB Serial Download (SDP)** — the i.MX6 boot ROM has a built-in download
   mode. With the SoC in download mode you reflash eMMC from a PC using NXP's
   `uuu` (Universal Update Utility) or `imx_usb_loader`. Needs the board put into
   SDP boot mode (a boot-mode strap / recovery button on the carrier).

2. **Recovery SD card** — Variscite publishes a recovery SD image for the
   VAR-SOM-MX6. Boot the SOM from SD and reflash eMMC (`install_yocto.sh` /
   partition tool). Needs the board able to boot from SD (boot-mode select).

Both reflash the eMMC completely, so a bad eMMC image becomes "reflash", not
"dead". The A/B layout adds a second safety net (below).

## The one thing you MUST confirm first (honest unknown)
Both routes need the board in a NON-eMMC boot mode (SDP or SD). On a sealed
aftermarket dash, the boot-mode strap/recovery access **may not be reachable
without opening the enclosure**, and the iC-7's carrier wiring isn't documented
publicly. So, before trusting any flash:

- Determine whether you can put YOUR unit into download mode or SD boot. If you
  can't confirm it, **do not flash** — Haltech is the right source for the
  official recovery/service procedure (ask them; they blessed the project).
- If you can confirm it, do a dry run of recovery on the bench once, so you know
  it works, before you depend on it.

## Pre-flight checklist (all must be true before flashing)
1. [ ] Reversible on-dash test (ON-DASH-TEST.md) passed — the app runs on your
       dash and behaves.
2. [ ] You can enter i.MX6 download mode OR boot a Variscite recovery SD on your
       unit (verified, not assumed).
3. [ ] You have the tools: `uuu`/`imx_usb_loader` + the Variscite VAR-SOM-MX6
       BSP/recovery image for the matching release.
4. [ ] Full eMMC backup taken: from a root shell or SD boot,
       `dd if=/dev/mmcblk0 of=/mnt/usb/emmc-backup.img bs=4M` (store it off-device).
       A brick is then restorable by `dd` of this image back.
5. [ ] You flash the **PASSIVE** A/B rootfs partition only; the known-good
       partition stays bootable. Boot-test the passive one before promoting it.
6. [ ] You leave the **STM32 I/O firmware (`dash_stm`) untouched** — it drives
       real outputs and is the risky half; irrelevant to a display project.
7. [ ] (If unsure of HAB) check at a U-Boot console whether i.MX6 secure boot is
       fuse-enforced before relying on a modified boot chain. The rootfs update
       path isn't signature-checked, but confirm.

## If a flash goes wrong
- It won't boot the new partition → the bootloader/other A-B slot should still
  boot the good one. Select it, or power-cycle.
- Both slots bad → enter download mode / SD recovery (step 2) and reflash, or
  `dd` your backup image back (step 4).
- Can't enter recovery at all → stop; this is where you need Haltech's service
  procedure. Don't keep trying to flash.

## TL;DR on where the safety line is
- **Test = safe, always** (no firmware write). Do this first and freely.
- **Flash = only after** steps 1-7, especially #2 (you can actually recover) and
  #4 (you have a full backup). If #2 can't be confirmed on your sealed unit, run
  the app the reversible way and get the recovery procedure from Haltech before
  ever flashing.
