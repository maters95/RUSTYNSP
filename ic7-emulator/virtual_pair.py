"""Plan and, with explicit approval, configure the NSP/emulator virtual COM pair.

Only a signed com0com installation is configured, through its documented
setupc.exe CLI. Detection is read-only. Without --apply nothing is changed.
No driver is downloaded or installed and driver signing policy is never touched.
HHD Virtual Serial Port Tools (or any other signed driver) remains a manual
fallback: create the pair in its own UI, then record it with --manual.
"""
import argparse
from dataclasses import dataclass, field
import json
import ntpath
import os
from pathlib import Path
import re
import subprocess
import sys


ROOT = Path(__file__).resolve().parent
CONFIG = ROOT / "port-pair.json"
PORT_PATTERN = re.compile(r"COM([1-9]\d{0,2})", re.IGNORECASE)
PHYSICAL_MARKERS = ("USB\\", "FTDIBUS\\", "ACPI\\", "PCI\\", "BTHENUM\\", "VID_16D0")
VIRTUAL_MARKERS = ("virtual", "com0com", "hhd", "simulator")
EXIT_NO_DRIVER = 2
EXIT_REFUSED = 3


class Refusal(Exception):
    pass


def port_name(value):
    match = PORT_PATTERN.fullmatch(str(value or "").strip())
    if not match or int(match.group(1)) > 256:
        raise Refusal(f"Invalid COM port name: {value!r}")
    return f"COM{int(match.group(1))}"


def parse_setupc_list(text):
    """Parse `setupc list` output into {pair index: {"A": params, "B": params}}."""
    pairs = {}
    for line in text.splitlines():
        match = re.match(r"\s*CNC([AB])(\d+)\s+(\S.*)?$", line)
        if not match:
            continue
        side, index, rest = match.group(1), int(match.group(2)), (match.group(3) or "").strip()
        params = {"id": f"CNC{side}{index}"}
        for item in rest.split(","):
            if "=" in item:
                key, value = item.split("=", 1)
                params[key.strip()] = value.strip()
        pairs.setdefault(index, {})[side] = params
    return pairs


def effective_name(params):
    """Return the COM name Windows applications see for one com0com port, or None."""
    name = params.get("RealPortName") if params.get("PortName", "").upper() == "COM#" else params.get("PortName")
    try:
        return port_name(name)
    except Refusal:
        return None


def parse_comdb(data):
    """Decode the COM Name Arbiter ComDB bitmap into reserved COM numbers."""
    return {byte_index * 8 + bit + 1 for byte_index, byte in enumerate(data or b"")
            for bit in range(8) if byte & (1 << bit)}


def parse_pnputil_drivers(text):
    blocks, current = [], {}
    for line in text.splitlines():
        if not line.strip():
            if current:
                blocks.append(current)
            current = {}
            continue
        if ":" in line:
            key, value = line.split(":", 1)
            current[key.strip()] = value.strip()
    if current:
        blocks.append(current)
    return [block for block in blocks if block.get("Original Name", "").casefold() == "com0com.inf"]


def port_parameters(name):
    # PortName=COM# uses the Windows Ports class, so the port gets a Device Manager
    # entry that NSP discovery, pyserial and set-nsp-port.ps1 can see.
    return f"PortName=COM#,RealPortName={name}"


@dataclass
class Inventory:
    pairs: dict = field(default_factory=dict)
    pnp: list = field(default_factory=list)
    serialcomm: list = field(default_factory=list)
    reserved: set = field(default_factory=set)


@dataclass
class Plan:
    nsp_port: str
    emulator_port: str
    pair: int | None
    commands: list
    notes: list = field(default_factory=list)

    @property
    def configured(self):
        return not self.commands


def foreign_owners(name, inventory):
    """Describe present non-com0com devices holding a COM name."""
    owners = []
    for entity in inventory.pnp:
        if re.search(r"\(" + re.escape(name) + r"\)\s*$", str(entity.get("Name", "")), re.IGNORECASE):
            device_id = str(entity.get("PNPDeviceID", ""))
            if not device_id.upper().startswith("COM0COM\\"):
                kind = "physical" if any(marker in device_id.upper() for marker in PHYSICAL_MARKERS) else "non-com0com"
                owners.append(f"{kind} device {entity.get('Name')} [{device_id}]")
    for device, value in inventory.serialcomm:
        if str(value).upper() == name and "com0com" not in str(device).casefold():
            owners.append(f"serial device {device}")
    return owners


def plan_pair(nsp_port, emulator_port, inventory, rename_pair=None, allow_reserved=False):
    nsp_port, emulator_port = port_name(nsp_port), port_name(emulator_port)
    if nsp_port == emulator_port:
        raise Refusal("The NSP and emulator ends must be different COM ports.")
    for name in (nsp_port, emulator_port):
        owners = foreign_owners(name, inventory)
        if owners:
            raise Refusal(f"{name} is already used by {'; '.join(owners)}. Choose other names; "
                          "only com0com virtual ports are changed by this helper.")
    located = {}
    for index, sides in inventory.pairs.items():
        for side, params in sides.items():
            name = effective_name(params)
            if name:
                located[name] = (index, side)
    nsp, emulator = located.get(nsp_port), located.get(emulator_port)
    if nsp and emulator:
        if nsp[0] == emulator[0] and nsp[1] != emulator[1]:
            return Plan(nsp_port, emulator_port, nsp[0], [], [f"com0com pair {nsp[0]} already connects {nsp_port} <-> {emulator_port}."])
        raise Refusal(f"{nsp_port} and {emulator_port} belong to different com0com pairs; "
                      "they are not connected to each other. Rename them manually or choose other names.")
    for name in (nsp_port, emulator_port):
        if name not in located and int(name[3:]) in inventory.reserved and not allow_reserved:
            raise Refusal(f"{name} is reserved in the Windows COM database by a device that is not present "
                          "(possibly the disconnected dash or an old virtual port). Choose other names, "
                          "or pass --allow-reserved after confirming in Device Manager (show hidden devices).")
    if rename_pair is not None:
        if rename_pair not in inventory.pairs or set(inventory.pairs[rename_pair]) != {"A", "B"}:
            raise Refusal(f"com0com pair {rename_pair} does not exist.")
        for name, place in ((nsp_port, nsp), (emulator_port, emulator)):
            if place and place[0] != rename_pair:
                raise Refusal(f"{name} already belongs to com0com pair {place[0]}.")
        commands = [["change", f"CNCA{rename_pair}", port_parameters(nsp_port)],
                    ["change", f"CNCB{rename_pair}", port_parameters(emulator_port)]]
        return Plan(nsp_port, emulator_port, rename_pair, commands, [f"Renames existing com0com pair {rename_pair}."])
    if nsp or emulator:
        (index, side), missing = (nsp, emulator_port) if nsp else (emulator, nsp_port)
        other = "B" if side == "A" else "A"
        return Plan(nsp_port, emulator_port, index, [["change", f"CNC{other}{index}", port_parameters(missing)]],
                    [f"Renames the other end of com0com pair {index}, which already holds one requested name."])
    return Plan(nsp_port, emulator_port, None,
                [["install", port_parameters(nsp_port), port_parameters(emulator_port)]],
                ["Creates a new com0com pair; existing pairs are left unchanged."])


def hhd_ports(pnp, serialcomm=()):
    """Return [(COM name, device name, driver service)] for present HHD-style virtual ports."""
    devices = {str(value).upper(): str(device) for device, value in serialcomm}
    found = []
    for entity in pnp:
        name = str(entity.get("Name", ""))
        text = " ".join(str(entity.get(key, "")) for key in ("Name", "Manufacturer", "PNPDeviceID")).casefold()
        device_id = str(entity.get("PNPDeviceID", "")).upper()
        match = re.search(r"\((COM\d+)\)\s*$", name, re.IGNORECASE)
        if not match or device_id.startswith("COM0COM\\") or any(marker in device_id for marker in PHYSICAL_MARKERS):
            continue
        if "hhd" in text or "virtual serial" in text or "hhd" in devices.get(match.group(1).upper(), "").casefold():
            found.append((match.group(1).upper(), name, entity.get("Service") or None))
    return sorted(found, key=lambda item: int(item[0][3:]))


def hhd_services(services, port_services=()):
    """Pick HHD services/drivers from {service name: ImagePath}, plus services named by present HHD ports."""
    wanted = {str(name).casefold() for name in port_services if name}
    return sorted(name for name, image in services.items()
                  if name.casefold().startswith("hhd") or "hhd software" in str(image or "").casefold()
                  or name.casefold() in wanted)


def hhd_pair_candidate(ports):
    """Two HHD ports are reported as a candidate pair; Windows inventory cannot prove they are bridged."""
    return (ports[0][0], ports[1][0]) if len(ports) == 2 else None


def driver_image_path(path):
    path = str(path or "").strip().strip('"')
    if not path:
        return None
    system_root = os.environ.get("SystemRoot", r"C:\Windows")
    if path.lower().startswith("\\systemroot\\"):
        path = ntpath.normpath(system_root + path[len("\\SystemRoot"):])
    elif path.lower().startswith("system32\\"):
        path = ntpath.normpath(ntpath.join(system_root, path))
    elif path.startswith("\\??\\"):
        path = ntpath.normpath(path[4:])
    else:
        path = ntpath.normpath(path)
    return Path(path) if path else None


def check_manual_port(name, ports):
    """Accept a manually created port only if pyserial identifies it as virtual."""
    port = next((port for port in ports if str(port.device).upper() == name), None)
    if port is None:
        raise Refusal(f"{name} is not present. Create the pair in your virtual serial driver first.")
    text = " ".join(str(getattr(port, item, "")) for item in ("description", "manufacturer", "hwid")).strip()
    if any(marker in text.upper() for marker in PHYSICAL_MARKERS + ("VID:PID",)) or not any(
            marker in text.casefold() for marker in VIRTUAL_MARKERS):
        raise Refusal(f"{name} ({text}) is not identified as a virtual port.")
    return text


def load_pair_config(path=CONFIG):
    """Return the configured {nsp_port, emulator_port, driver, pair} or None."""
    try:
        data = json.loads(Path(path).read_text(encoding="utf-8"))
        data["nsp_port"], data["emulator_port"] = port_name(data["nsp_port"]), port_name(data["emulator_port"])
    except (OSError, ValueError, KeyError, TypeError, Refusal):
        return None
    if data["nsp_port"] == data["emulator_port"]:
        return None
    return data


def save_pair_config(nsp_port, emulator_port, driver, pair=None, path=CONFIG):
    data = {"driver": driver, "nsp_port": port_name(nsp_port), "emulator_port": port_name(emulator_port), "pair": pair}
    Path(path).write_text(json.dumps(data, indent=2) + "\n", encoding="utf-8")
    return data


# ---- Read-only Windows detection -------------------------------------------------

def powershell_json(script):
    result = subprocess.run(["powershell.exe", "-NoProfile", "-NonInteractive", "-Command",
                             script + " | ConvertTo-Json -Compress -Depth 3"],
                            capture_output=True, text=True, timeout=60)
    if result.returncode != 0 or not result.stdout.strip():
        return []
    value = json.loads(result.stdout)
    return value if isinstance(value, list) else [value]


def quoted(path):
    return "'" + str(path).replace("'", "''") + "'"


def registry_values(root, key_path, views=(0,)):
    import winreg
    values = {}
    for view in views:
        try:
            with winreg.OpenKey(root, key_path, 0, winreg.KEY_READ | view) as key:
                index = 0
                while True:
                    try:
                        name, value, _ = winreg.EnumValue(key, index)
                    except OSError:
                        break
                    values[name] = value
                    index += 1
        except OSError:
            continue
    return values


def registry_subkeys(root, key_path, views=(0,)):
    import winreg
    names = []
    for view in views:
        try:
            with winreg.OpenKey(root, key_path, 0, winreg.KEY_READ | view) as key:
                index = 0
                while True:
                    try:
                        names.append((view, winreg.EnumKey(key, index)))
                    except OSError:
                        break
                    index += 1
        except OSError:
            continue
    return names


def installed_programs():
    import winreg
    views = (winreg.KEY_WOW64_64KEY, winreg.KEY_WOW64_32KEY)
    base = r"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"
    programs = []
    for view, name in registry_subkeys(winreg.HKEY_LOCAL_MACHINE, base, (views)):
        values = registry_values(winreg.HKEY_LOCAL_MACHINE, base + "\\" + name, (view,))
        if values.get("DisplayName"):
            programs.append(values)
    return programs


def find_setupc(explicit=None, programs=None):
    if explicit:
        return Path(explicit) if Path(explicit).is_file() else None
    candidates = []
    for program in programs or []:
        if str(program.get("DisplayName", "")).casefold().startswith("com0com"):
            if program.get("InstallLocation"):
                candidates.append(Path(program["InstallLocation"]) / "setupc.exe")
            uninstall = str(program.get("UninstallString", "")).strip().strip('"')
            if uninstall:
                candidates.append(Path(uninstall.split('"')[0]).parent / "setupc.exe")
    for variable in ("ProgramFiles", "ProgramFiles(x86)", "ProgramW6432"):
        if os.environ.get(variable):
            candidates.append(Path(os.environ[variable]) / "com0com" / "setupc.exe")
    return next((candidate for candidate in candidates if candidate.is_file()), None)


def hhd_installed(programs):
    return [program["DisplayName"] for program in programs
            if "hhd" in str(program.get("Publisher", "")).casefold()
            or "virtual serial port tools" in str(program.get("DisplayName", "")).casefold()]


def file_signature(path):
    signature = powershell_json(
        f"Get-AuthenticodeSignature -LiteralPath {quoted(path)} | Select-Object "
        "@{n='Status';e={[string]$_.Status}},@{n='Signer';e={[string]$_.SignerCertificate.Subject}},"
        "@{n='Type';e={[string]$_.SignatureType}}")
    if not signature:
        return {"signature": None, "signer": None, "signature_type": None}
    return {"signature": signature[0].get("Status"), "signer": signature[0].get("Signer"),
            "signature_type": signature[0].get("Type")}


def pnp_ports():
    return powershell_json("Get-CimInstance -ClassName Win32_PnPEntity | Where-Object { $_.Name -match '\\(COM\\d+\\)' } "
                           "| Select-Object Name,PNPDeviceID,Manufacturer,Service")


def detect_hhd(programs):
    """Read-only report of HHD software, present HHD ports and their driver signature."""
    import winreg
    serialcomm = list(registry_values(winreg.HKEY_LOCAL_MACHINE, r"HARDWARE\DEVICEMAP\SERIALCOMM").items())
    ports = hhd_ports(pnp_ports(), serialcomm)
    base = r"SYSTEM\CurrentControlSet\Services"
    services = {}
    for _, name in registry_subkeys(winreg.HKEY_LOCAL_MACHINE, base):
        values = registry_values(winreg.HKEY_LOCAL_MACHINE, base + "\\" + name)
        services[name] = (values.get("ImagePath"), values.get("Type"))
    drivers = []
    for service in hhd_services({name: value[0] for name, value in services.items()}, [port[2] for port in ports]):
        image, kind = services.get(service, (None, None))
        path = driver_image_path(image)
        status = {"service": service, "kind": "kernel driver" if kind in (1, 2) else "service",
                  "path": str(path) if path else None, "present": bool(path and path.is_file())}
        if status["present"]:
            status.update(file_signature(path))
        drivers.append(status)
    return {"software": hhd_installed(programs), "ports": ports, "drivers": drivers,
            "pair": hhd_pair_candidate(ports)}


def driver_status():
    import winreg
    system_root = os.environ.get("SystemRoot", r"C:\Windows")
    sys_path = Path(system_root) / "System32" / "drivers" / "com0com.sys"
    service = registry_values(winreg.HKEY_LOCAL_MACHINE, r"SYSTEM\CurrentControlSet\Services\com0com")
    status = {"sys": str(sys_path), "present": sys_path.is_file(), "service": bool(service),
              "signature": None, "signer": None, "signature_type": None, "pnputil": []}
    if status["present"]:
        status.update(file_signature(sys_path))
    try:
        result = subprocess.run(["pnputil.exe", "/enum-drivers"], capture_output=True, text=True, timeout=60)
        status["pnputil"] = parse_pnputil_drivers(result.stdout)
    except (OSError, subprocess.SubprocessError):
        pass
    return status


def registry_pairs():
    """Read com0com port parameters from its service registry (fallback when setupc list cannot run)."""
    import winreg
    base = r"SYSTEM\CurrentControlSet\Services\com0com\Parameters"
    text = []
    for _, name in registry_subkeys(winreg.HKEY_LOCAL_MACHINE, base):
        if re.fullmatch(r"CNC[AB]\d+", name, re.IGNORECASE):
            values = registry_values(winreg.HKEY_LOCAL_MACHINE, base + "\\" + name)
            params = ",".join(f"{key}={value}" for key, value in values.items() if isinstance(value, str))
            text.append(f"{name.upper()} {params or 'PortName=-'}")
    return parse_setupc_list("\n".join(text))


def setupc_list(setupc):
    try:
        result = subprocess.run([str(setupc), "list"], cwd=str(setupc.parent), capture_output=True,
                                text=True, timeout=60)
    except (OSError, subprocess.SubprocessError) as error:
        return None, f"setupc list could not run without elevation ({error}); using com0com registry parameters"
    if result.returncode != 0:
        return None, f"setupc list exited {result.returncode}; using com0com registry parameters"
    return parse_setupc_list(result.stdout), None


def inventory(setupc=None):
    import winreg
    notes = []
    pairs = {}
    if setupc is not None:
        pairs, note = setupc_list(setupc)
        if note:
            notes.append(note)
    if not pairs:
        pairs = registry_pairs()
    pnp = pnp_ports()
    serialcomm = list(registry_values(winreg.HKEY_LOCAL_MACHINE, r"HARDWARE\DEVICEMAP\SERIALCOMM").items())
    comdb = registry_values(winreg.HKEY_LOCAL_MACHINE, r"SYSTEM\CurrentControlSet\Control\COM Name Arbiter").get("ComDB")
    present = {int(m.group(1)) for _, value in serialcomm if (m := PORT_PATTERN.fullmatch(str(value)))}
    reserved = parse_comdb(comdb if isinstance(comdb, bytes) else b"") - present
    return Inventory(pairs, pnp, serialcomm, reserved), notes


# ---- Apply (explicit approval only) ---------------------------------------------

def elevated_setupc(setupc, arguments):
    """Run one setupc command through a visible UAC prompt and return its exit code."""
    argument_text = " ".join(arguments)
    script = ("$ErrorActionPreference = 'Stop'; try { "
              f"$p = Start-Process -FilePath {quoted(setupc)} -WorkingDirectory {quoted(setupc.parent)} "
              f"-ArgumentList {quoted(argument_text)} -Verb RunAs -Wait -PassThru; exit $p.ExitCode }} "
              "catch { [Console]::Error.WriteLine($_.Exception.Message); exit 1 }")
    return subprocess.run(["powershell.exe", "-NoProfile", "-Command", script]).returncode


def describe(plan, setupc):
    lines = [f"Requested pair: NSP end {plan.nsp_port} <-> emulator end {plan.emulator_port}"]
    lines += [f"  {note}" for note in plan.notes]
    if plan.configured:
        lines.append("No setupc commands are needed.")
    else:
        lines.append("setupc commands (each needs Administrator approval through a UAC prompt):")
        lines += [f'  cd "{setupc.parent}"; .\\setupc.exe {" ".join(command)}' for command in plan.commands]
    return lines


def confirm(prompt):
    try:
        return input(prompt).strip().casefold() in ("y", "yes")
    except EOFError:
        return False


def main(argv=None):
    parser = argparse.ArgumentParser(description="Configure the iC-7 NSP virtual COM pair. Dry run unless --apply.")
    parser.add_argument("--nsp-port", default="COM10", help="Pair end NSP opens (default COM10)")
    parser.add_argument("--emulator-port", default="COM11", help="Pair end the emulator/workbench opens (default COM11)")
    parser.add_argument("--setupc", help="Path to an installed com0com setupc.exe")
    parser.add_argument("--rename-pair", type=int, help="Rename this existing com0com pair instead of installing a new one")
    parser.add_argument("--allow-reserved", action="store_true", help="Allow names reserved by absent devices")
    parser.add_argument("--manual", action="store_true",
                        help="Record a pair you created yourself (HHD or another signed driver); changes nothing else")
    parser.add_argument("--apply", action="store_true", help="Run the planned setupc commands and save port-pair.json")
    parser.add_argument("--yes", action="store_true", help="Skip the interactive confirmation (UAC still appears)")
    parser.add_argument("--config", type=Path, default=CONFIG)
    args = parser.parse_args(argv)
    for stream in (sys.stdout, sys.stderr):
        if hasattr(stream, "reconfigure"):
            stream.reconfigure(line_buffering=True)  # keep report and error lines in order
    if sys.platform != "win32":
        print("Virtual COM pair setup is only supported on Windows.", file=sys.stderr)
        return 1
    mode = "APPLY" if args.apply else "DRY RUN (no changes; pass --apply to make them)"
    print(f"Mode: {mode}")
    programs = installed_programs()
    hhd = hhd_installed(programs)
    setupc = find_setupc(args.setupc, programs)
    report_hhd(detect_hhd(programs))
    try:
        if args.manual:
            return manual(args, hhd)
        if setupc is None:
            print("com0com setupc.exe: not found", file=sys.stderr)
            return no_driver(hhd)
        print(f"com0com setupc.exe: {setupc}")
        driver = driver_status()
        print(f"com0com driver: {driver['sys']} present={driver['present']} service={driver['service']} "
              f"signature={driver['signature']} type={driver['signature_type']} signer={driver['signer']}")
        for block in driver["pnputil"]:
            print(f"  pnputil: {block.get('Published Name')} {block.get('Original Name')} "
                  f"version={block.get('Driver Version')} signer={block.get('Signer Name')}")
        if not driver["present"] or not driver["service"]:
            print("setupc.exe was found, but the com0com driver is not installed.", file=sys.stderr)
            return no_driver(hhd)
        if driver["signature"] != "Valid":
            print("The installed com0com.sys does not have a valid signature. Unsigned/test-signed builds are not "
                  "supported; do not enable test signing. Install a signed com0com build instead.", file=sys.stderr)
            return no_driver(hhd)
        found, notes = inventory(setupc)
        for note in notes:
            print(f"Note: {note}")
        for index in sorted(found.pairs):
            sides = found.pairs[index]
            print(f"  com0com pair {index}: {effective_name(sides.get('A', {})) or '-'} <-> "
                  f"{effective_name(sides.get('B', {})) or '-'}")
        plan = plan_pair(args.nsp_port, args.emulator_port, found, args.rename_pair, args.allow_reserved)
    except Refusal as error:
        print(f"Refused: {error}", file=sys.stderr)
        return EXIT_REFUSED
    for line in describe(plan, setupc):
        print(line)
    print(f"Then saves {args.config} so the workbench and start-emulator use {plan.emulator_port} without prompting.")
    print(f"NSP discovery still needs the existing label step on {plan.nsp_port}: set-nsp-port.ps1 -Port {plan.nsp_port}")
    if not args.apply:
        return 0
    if plan.commands:
        if not args.yes and not confirm("Run these commands with Administrator approval? Type yes to continue: "):
            print("Cancelled; nothing was changed.")
            return 1
        if not driver_status()["signature"] == "Valid":
            print("Driver signature check failed on re-check; nothing was changed.", file=sys.stderr)
            return EXIT_NO_DRIVER
        for command in plan.commands:
            print(f"Running (UAC): setupc {' '.join(command)}")
            code = elevated_setupc(setupc, command)
            if code != 0:
                print(f"setupc failed or was cancelled (exit {code}). Stopping.", file=sys.stderr)
                return 1
        found, _ = inventory(setupc)
        try:
            check = plan_pair(plan.nsp_port, plan.emulator_port, found, allow_reserved=True)
        except Refusal as error:
            print(f"Verification failed after setupc: {error}", file=sys.stderr)
            return 1
        if not check.configured:
            print("Verification failed: the pair is not visible after setupc. Check Device Manager.", file=sys.stderr)
            return 1
        plan = check
    save_pair_config(plan.nsp_port, plan.emulator_port, "com0com", plan.pair, args.config)
    print(f"Saved {args.config}.")
    return 0


def report_hhd(found):
    print(f"HHD/other virtual serial software: {', '.join(found['software']) if found['software'] else 'not detected'}")
    for port, name, service in found["ports"]:
        print(f"  HHD-style virtual port: {port} ({name}) service={service or '-'}")
    for driver in found["drivers"]:
        print(f"  HHD {driver['kind']}: {driver['service']} {driver['path']} present={driver['present']} "
              f"signature={driver.get('signature')} signer={driver.get('signer')}")
    if found["pair"]:
        print(f"  HHD candidate pair: {found['pair'][0]} <-> {found['pair'][1]} (bridging not verifiable from "
              "Windows inventory; confirm in HHD, then record with -Manual)")
    elif found["ports"]:
        print("  HHD ports present, but not exactly two; choose the pair yourself with -Manual.")
    else:
        print("  No present HHD virtual ports detected.")


def no_driver(hhd):
    print("No supported signed com0com installation was found. Nothing was changed. Options:\n"
          "  1. Install a signed com0com release yourself from its official project page using its normal\n"
          "     installer (do not enable test signing or disable driver signature enforcement), then rerun.\n"
          "  2. Use the manual fallback: create the pair in HHD Virtual Serial Port Tools (or another signed\n"
          "     driver), then record it with: setup-virtual-pair.cmd -Manual -NspPort COM10 -EmulatorPort COM11"
          + ("\n  HHD software appears to be installed, so option 2 is available." if hhd else ""), file=sys.stderr)
    return EXIT_NO_DRIVER


def manual(args, hhd):
    try:
        from serial.tools.list_ports import comports  # pyserial, installed by start-emulator
    except ImportError:
        raise Refusal("pyserial is not installed; run start-emulator.cmd -ViewerOnly once to create .venv.")
    nsp_port, emulator_port = port_name(args.nsp_port), port_name(args.emulator_port)
    if nsp_port == emulator_port:
        raise Refusal("The NSP and emulator ends must be different COM ports.")
    for name in (nsp_port, emulator_port):
        print(f"  {name}: {check_manual_port(name, comports())}")
    print(f"Manual pair: NSP end {nsp_port} <-> emulator end {emulator_port}. Pairing itself cannot be verified here.")
    if not args.apply:
        print(f"Dry run: would save {args.config}. Pass --apply to save it (no system changes).")
        return 0
    save_pair_config(nsp_port, emulator_port, "manual", None, args.config)
    print(f"Saved {args.config}.")
    return 0


if __name__ == "__main__":
    sys.exit(main())
