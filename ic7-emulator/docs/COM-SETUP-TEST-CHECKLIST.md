# Virtual COM Pair Setup: Windows Test Checklist

Reproducible manual checks for `setup-virtual-pair.cmd` / `virtual_pair.py`
and the NSP <-> emulator virtual connection. Keep the physical dash
**disconnected** for every step. Run from the extracted `ic7-emulator` folder
in a normal (non-administrator) PowerShell unless a step says otherwise.

Status key:

- **[EXECUTED 2026-10-27]** run on the development machine (Windows 11 Pro
  26200, HHD Virtual Serial Port Tools 7.35 installed, no com0com, no COM
  ports present, ComDB reserving COM3). Result recorded.
- **[USER]** needs the owner's machine, a real com0com/HHD pair and/or NSP.

Record for each [USER] step: date, command, full console output, exit code
(`echo $LASTEXITCODE`), and a Device Manager screenshot of *Ports (COM & LPT)*
with *View > Show hidden devices* on.

## 0. Automated tests

- [EXECUTED 2026-10-27] `python -m unittest discover -s tests` (with
  `requirements.txt` installed): 75 tests, OK. Fixture `setupc list` output
  only; no driver required.

## 1. No-driver failure path

1. [EXECUTED 2026-10-27] `.\setup-virtual-pair.cmd` with com0com not installed.
   Expected and observed: `com0com setupc.exe: not found`, the two options
   (install signed com0com yourself, or HHD/manual fallback), exit code **2**,
   no `port-pair.json` created, no UAC prompt.
2. [USER] Same with `-Apply -Yes`: must still exit 2 without a UAC prompt.
3. [USER] If an *unsigned/test-signed* com0com is installed: expect
   `does not have a valid signature`, exit 2. Do **not** enable test signing to
   make it pass.

## 2. HHD path (manual fallback)

1. [EXECUTED 2026-10-27] Detection only. Observed: HHD software
   `Virtual Serial Port Tools 7.35`; services `hhdpsipsrv` and `hhdpssrv`
   present with Authenticode status `Valid` (signer CN=MIKOM INC); **no present
   HHD virtual ports**, so no candidate pair was reported.
2. [EXECUTED 2026-10-27] `python virtual_pair.py --manual` (dry run, defaults
   COM10/COM11): `Refused: COM10 is not present`, exit **3**, nothing saved.
3. [USER] Create COM10 <-> COM11 in HHD. Rerun `.\setup-virtual-pair.cmd`;
   expect both ports listed as HHD-style and `HHD candidate pair: COM10 <->
   COM11`. Confirm in the HHD UI that they really are bridged (the helper
   cannot verify this).
4. [USER] `.\setup-virtual-pair.cmd -Manual` (dry run): expect both ports
   described, `would save ...port-pair.json`, exit 0, file not created.
5. [USER] `.\setup-virtual-pair.cmd -Manual -Apply`: expect `Saved
   ...port-pair.json` containing `"driver": "manual"`. No UAC prompt.

## 3. com0com path

Precondition [USER]: install a signed com0com build yourself with its normal
installer. Do not disable driver signature enforcement.

1. [USER] `.\setup-virtual-pair.cmd`: expect `setupc.exe` path, `com0com.sys
   present=True service=True signature=Valid`, a `pnputil` line for
   `com0com.inf`, existing pairs, and the exact command
   `setupc.exe install PortName=COM#,RealPortName=COM10 PortName=COM#,RealPortName=COM11`.
   Exit 0, nothing changed. Note whether it printed
   `setupc list could not run without elevation` (then pairs came from the
   registry).
2. [USER] `-Apply` and answer `no` at the prompt: expect `Cancelled; nothing
   was changed`, exit 1, no UAC prompt.
3. [USER] `-Apply`, answer `yes`, then **decline** UAC: expect `setupc failed
   or was cancelled`, exit 1, no `port-pair.json`.
4. [USER] `-Apply`, answer `yes`, accept UAC: expect a pair verified and
   `Saved ...port-pair.json` with `"driver": "com0com"`. Device Manager should
   show two com0com ports named COM10 and COM11 under *Ports*. If setupc
   rejects `RealPortName`, record its message (this parameter form is
   unverified).
5. [USER] Rerun the dry run: expect `already connects COM10 <-> COM11` and
   `No setupc commands are needed`.
6. [USER] `-RenamePair N -NspPort COM20 -EmulatorPort COM21` dry run on an
   existing pair: expect two `change CNCAN/CNCBN` commands. Do not apply unless
   wanted.

## 4. Port-conflict refusal

1. [EXECUTED 2026-10-27, unit tests only] Planning refuses: a name owned by a
   USB/physical device (dash fixture `USB\VID_16D0...`), a name owned by an HHD
   port, a non-com0com `SERIALCOMM` entry, names in two different com0com
   pairs, a ComDB-reserved name without `-AllowReserved`, identical or invalid
   names. All exit 3 with no setupc call.
2. [USER] With com0com installed and the dash **disconnected**, run
   `.\setup-virtual-pair.cmd -NspPort COM3` (COM3 is reserved on the dev
   machine; substitute the dash's usual port). Expect `reserved in the Windows
   COM database`, exit 3.
3. [USER] With an HHD pair present, ask com0com for one of the HHD names: expect
   `non-com0com device HHD ...`, exit 3.
4. [USER] Never test conflicts by connecting the physical dash.

## 5. NSP <-> emulator virtual connect / handshake

All [USER]; requires NSP and a working pair from section 2 or 3.

1. With `port-pair.json` present, run `.\start-emulator.cmd` without `-Port`.
   Expect `Using emulator port COM11 from port-pair.json` then
   `Listening on COM11`.
2. Or start `.\start-workbench.cmd`: the port box should preselect COM11 and
   the status bar should show `Configured pair: NSP COM10 <-> emulator COM11`.
   The NSP discovery prompt (if the NSP end is not yet labelled) should list
   COM10 first.
3. Label the NSP end once (existing step, admin):
   `set-nsp-port.ps1 -Port COM10`. For com0com, record whether SetupAPI
   accepted the description change (unverified for com0com).
4. Start/restart NSP. Expected (as previously observed with HHD): NSP lists the
   virtual device, emulator log shows identity read, settings reads and
   sustained channel polling; simulated serial `F1C700000001`.
5. Restore the description afterwards:
   `set-nsp-port.ps1 -Port COM10 -Restore`.

## What this proves / does not prove

Proves (once sections 3 and 5 pass): the pair can be created through
com0com's own CLI with explicit approval, the emulator/workbench pick it up
from `port-pair.json`, and NSP can exchange protocol traffic with the
emulator over a virtual null-modem link.

Does not prove: anything about the physical iC-7, its USB behaviour, real
sensor data, firmware/resource installation, flashing, decryption, recovery,
or that a real dash would behave the same way as the emulator.
