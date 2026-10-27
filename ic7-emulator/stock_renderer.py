import argparse
import ctypes
from ctypes import wintypes
import hashlib
import json
import os
from pathlib import Path
import shutil
import struct
import subprocess
import threading
import time
import urllib.parse
import urllib.request
import zipfile
import zlib


PIPE_NAME = "SIM_Dash_Pipe"


def pe_machine(path):
    try:
        with Path(path).open("rb") as stream:
            dos_header = stream.read(64)
            if len(dos_header) < 64 or dos_header[:2] != b"MZ":
                return None
            pe_offset = struct.unpack_from("<I", dos_header, 0x3C)[0]
            stream.seek(pe_offset)
            header = stream.read(6)
            if len(header) != 6 or header[:4] != b"PE\0\0":
                return None
            return struct.unpack_from("<H", header, 4)[0]
    except OSError:
        return None


def stage_windows_platform_plugin(runtime, destination):
    runtime = Path(runtime)
    destination = Path(destination)
    renderer_machine = pe_machine(runtime / "dash_virtual.exe")
    if renderer_machine is None:
        raise ValueError("Cannot determine the NSP renderer's Windows architecture")
    plugin_roots = (runtime, runtime.parent / "plugins")
    candidates = sorted(path for root in plugin_roots if root.is_dir()
                        for path in root.rglob("qwindows.dll"))
    matching = [path for path in candidates if pe_machine(path) == renderer_machine]
    if not matching:
        raise FileNotFoundError(
            "No architecture-matched qwindows.dll was found under "
            f"{runtime} or {runtime.parent / 'plugins'}; point -Runtime at the installed NSP Qt runtime"
        )
    target = destination / "platforms" / "qwindows.dll"
    target.parent.mkdir(parents=True, exist_ok=True)
    shutil.copy2(matching[0], target)
    return target


def pipe_message(address, payload):
    body = struct.pack(">B3xII", 1, address, len(payload)) + payload
    return body + struct.pack(">I", zlib.crc32(body))


def validate_ack(payload):
    if len(payload) != 16 or zlib.crc32(payload[:12]) != int.from_bytes(payload[12:], "big"):
        raise ValueError("Stock renderer acknowledgement CRC or length failed")
    if payload[0] & 0x80:
        raise ValueError("Stock renderer rejected update")


class WindowsPipe:
    def __init__(self):
        if os.name != "nt":
            raise RuntimeError("The original Windows dash renderer must run on Windows")
        self.api = ctypes.WinDLL("kernel32", use_last_error=True)
        self.api.CreateNamedPipeW.argtypes = [wintypes.LPCWSTR, wintypes.DWORD, wintypes.DWORD,
                                              wintypes.DWORD, wintypes.DWORD, wintypes.DWORD,
                                              wintypes.DWORD, wintypes.LPVOID]
        self.api.CreateNamedPipeW.restype = wintypes.HANDLE
        self.api.ConnectNamedPipe.argtypes = [wintypes.HANDLE, wintypes.LPVOID]
        self.api.ConnectNamedPipe.restype = wintypes.BOOL
        self.api.WriteFile.argtypes = [wintypes.HANDLE, wintypes.LPCVOID, wintypes.DWORD,
                                       ctypes.POINTER(wintypes.DWORD), wintypes.LPVOID]
        self.api.ReadFile.argtypes = [wintypes.HANDLE, wintypes.LPVOID, wintypes.DWORD,
                                      ctypes.POINTER(wintypes.DWORD), wintypes.LPVOID]
        self.api.PeekNamedPipe.argtypes = [wintypes.HANDLE, wintypes.LPVOID, wintypes.DWORD,
                                           wintypes.LPVOID, ctypes.POINTER(wintypes.DWORD), wintypes.LPVOID]
        self.api.CloseHandle.argtypes = [wintypes.HANDLE]
        self.handle = self.api.CreateNamedPipeW("\\\\.\\pipe\\" + PIPE_NAME, 3, 8, 1, 65536, 65536, 1000, None)
        if self.handle == wintypes.HANDLE(-1).value:
            raise ctypes.WinError(ctypes.get_last_error())

    def connect(self, timeout=10):
        result = []
        def accept():
            accepted = self.api.ConnectNamedPipe(self.handle, None)
            result.append(bool(accepted) or ctypes.get_last_error() == 535)
        worker = threading.Thread(target=accept, daemon=True)
        worker.start()
        worker.join(timeout)
        if worker.is_alive() or not result or not result[0]:
            raise TimeoutError("The stock renderer did not connect to its private named pipe")

    def update(self, address, payload):
        packet = pipe_message(address, payload)
        written = wintypes.DWORD()
        if not self.api.WriteFile(self.handle, packet, len(packet), ctypes.byref(written), None) or written.value != len(packet):
            raise ctypes.WinError(ctypes.get_last_error())
        received = bytearray()
        deadline = time.monotonic() + 2
        while len(received) < 16:
            available = wintypes.DWORD()
            if not self.api.PeekNamedPipe(self.handle, None, 0, None, ctypes.byref(available), None):
                raise ctypes.WinError(ctypes.get_last_error())
            if available.value:
                size = min(16 - len(received), available.value)
                buffer = ctypes.create_string_buffer(size)
                count = wintypes.DWORD()
                if not self.api.ReadFile(self.handle, buffer, size, ctypes.byref(count), None):
                    raise ctypes.WinError(ctypes.get_last_error())
                received.extend(buffer.raw[:count.value])
            elif time.monotonic() >= deadline:
                raise TimeoutError("Stock renderer update acknowledgement timed out")
            else:
                time.sleep(0.002)
        validate_ack(bytes(received))

    def close(self):
        self.api.CloseHandle(self.handle)


def get(base, path):
    attempts = 4
    for attempt in range(attempts):
        try:
            with urllib.request.urlopen(base + path, timeout=5) as response:
                return response.read()
        except urllib.error.HTTPError:
            raise
        except (urllib.error.URLError, ConnectionError, TimeoutError) as error:
            if attempt + 1 == attempts:
                raise ConnectionError(
                    f"Emulator viewer {base} unavailable at {path}; keep the emulator running"
                ) from error
            time.sleep(0.2 * (2 ** attempt))
    raise ConnectionError(f"Emulator viewer {base} unavailable at {path}")


def prepare_runtime(runtime, destination, patched):
    destination.mkdir(parents=True, exist_ok=True)
    original = runtime / "dash_virtual.exe"
    binary = original.read_bytes()
    expected = "5a5d74fe029178398512a5622d480fed213f4fd8f58e70b85ca169bb5a62303b"
    if hashlib.sha256(binary).hexdigest() != expected:
        raise ValueError("Installed renderer differs from the verified NSP 1.48.5 baseline")
    needle = b"NSP_Dash_Pipe"
    if binary.count(needle) != 1 or len(PIPE_NAME.encode()) != len(needle):
        raise ValueError("Expected exactly one compatible pipe-name literal")
    executable = destination / "ic7_dash_renderer.exe"
    isolated = binary.replace(needle, PIPE_NAME.encode(), 1)
    isolated = isolated.replace("dash_virtual".encode("utf-16le"), "ic7_sim_view".encode("utf-16le"))
    executable.write_bytes(isolated)
    for library in runtime.glob("*.dll"):
        target = destination / library.name
        if not target.exists() or target.stat().st_size != library.stat().st_size:
            shutil.copy2(library, target)
    if (runtime / "qt.conf").exists():
        shutil.copy2(runtime / "qt.conf", destination / "qt.conf")
    for name in ("platforms", "imageformats", "bearer", "styles", "qml", "plugins"):
        if (runtime / name).is_dir():
            shutil.copytree(runtime / name, destination / name, dirs_exist_ok=True)
    stage_windows_platform_plugin(runtime, destination)
    resource_archive = Path(__file__).with_name("renderer-resources.zip")
    with zipfile.ZipFile(resource_archive) as archive:
        for entry in archive.infolist():
            relative = Path(entry.filename)
            if relative.is_absolute() or ".." in relative.parts:
                raise ValueError("Invalid renderer resource path")
            target = destination / relative
            target.parent.mkdir(parents=True, exist_ok=True)
            target.write_bytes(archive.read(entry))
    if patched:
        install_component_override(destination, Path(__file__).with_name("qml") / "patched-gif" / "HalImage.qml")
    return executable


def sync_resources(base, destination, previous):
    state = json.loads(get(base, "/api/status"))
    current = {}
    for resource in state["assets"]:
        name = resource["name"]
        if not name.startswith("u/"):
            continue
        key = (resource["kind"], name)
        current[key] = resource["sha256"]
        if previous.get(key) == resource["sha256"]:
            continue
        folder = "images" if resource["kind"] == 0 else "fonts"
        target = destination / "user_resources" / folder / name[2:]
        target.parent.mkdir(parents=True, exist_ok=True)
        encoded = urllib.parse.urlencode({"kind": resource["kind"], "name": name})
        target.write_bytes(get(base, "/api/resource?" + encoded))
    for kind, name in previous.keys() - current.keys():
        folder = "images" if kind == 0 else "fonts"
        (destination / "user_resources" / folder / name[2:]).unlink(missing_ok=True)
    return current


def install_component_override(destination, component):
    source = Path(component)
    if source.name != "HalImage.qml" or not source.is_file():
        raise ValueError("Component override must be an existing HalImage.qml")
    if b"import QtMultimedia" in source.read_bytes() and not (destination / "qml/QtMultimedia/qmldir").is_file():
        raise RuntimeError("The isolated NSP preview runtime lacks the QtMultimedia QML module")
    target = destination / "qml_components_data/qml/user_components/HalImage.qml"
    if not target.is_file():
        raise FileNotFoundError("Isolated renderer's HalImage.qml is missing")
    shutil.copyfile(source, target)
    return target


def install_sandbox_component(base, destination):
    changes = json.loads(get(base, "/api/changes?after=-1"))
    checksum = changes.get("component_sha256")
    if checksum is None:
        return None
    payload = get(base, "/api/component")
    if hashlib.sha256(payload).hexdigest() != checksum:
        raise ValueError("Sandbox component response hash mismatch")
    candidate = destination / "sandbox-component" / "HalImage.qml"
    candidate.parent.mkdir(parents=True, exist_ok=True)
    candidate.write_bytes(payload)
    install_component_override(destination, candidate)
    return checksum


def renderer_environment(work):
    work = Path(work)
    platform_dirs = (work / "platforms", work / "plugins" / "platforms")
    platform_dir = next((path for path in platform_dirs if (path / "qwindows.dll").is_file()), None)
    if platform_dir is None:
        raise FileNotFoundError("The isolated Qt runtime has no qwindows.dll platform plugin")
    environment = os.environ.copy()
    environment["QT_PLUGIN_PATH"] = str(work)
    environment["QT_QPA_PLATFORM_PLUGIN_PATH"] = str(platform_dir)
    environment["QML2_IMPORT_PATH"] = str(work / "qml")
    return environment


def main():
    parser = argparse.ArgumentParser(description="Drive an isolated original NSP dash renderer from emulator memory.")
    parser.add_argument("--url", default="http://127.0.0.1:8765")
    parser.add_argument("--runtime", type=Path, default=Path(os.environ.get("APPDATA", ".")) / "Haltech/Nexus")
    parser.add_argument("--work", type=Path, default=Path(__file__).with_name("state") / "stock-renderer")
    parser.add_argument("--patched-images", action="store_true")
    parser.add_argument("--component", type=Path, help="HalImage.qml to load in the isolated renderer")
    args = parser.parse_args()
    if os.name != "nt":
        raise SystemExit("Run the original renderer bridge on Windows")
    base = args.url.rstrip("/")
    if args.patched_images and args.component:
        parser.error("Use either --patched-images or --component, not both")
    executable = prepare_runtime(args.runtime, args.work, args.patched_images)
    if args.component:
        install_component_override(args.work, args.component)
    explicit_component = args.component is not None or args.patched_images
    component_checksum = None if explicit_component else install_sandbox_component(base, args.work)
    resources = sync_resources(base, args.work, {})
    pipe = WindowsPipe()
    process = None
    try:
        process = subprocess.Popen([str(executable.resolve()), "./qml_components_data/qml", "54000", "21", "11"],
                                   cwd=args.work, env=renderer_environment(args.work))
        pipe.connect()
        print("Original dash renderer connected to isolated SIM_Dash_Pipe.", flush=True)
        revision = -1
        resource_revision = None
        last_channels = 0
        while process.poll() is None:
            changes = json.loads(get(base, f"/api/changes?after={revision}"))
            if not explicit_component and changes.get("component_sha256") != component_checksum:
                print("Sandbox component changed. Restart the renderer to reload its QML.", flush=True)
                break
            resources_changed = changes["resource_revision"] != resource_revision
            if resources_changed:
                resources = sync_resources(base, args.work, resources)
                resource_revision = changes["resource_revision"]
            if changes["full_refresh"]:
                ranges = [{"address": 0x20000, "length": 651264}]
            else:
                ranges = changes["ranges"]
            for entry in ranges:
                for offset in range(0, entry["length"], 16384):
                    count = min(16384, entry["length"] - offset)
                    address = entry["address"] + offset
                    payload = get(base, f"/api/memory?address={address}&length={count}")
                    pipe.update(address, payload)
            revision = changes["revision"]
            if ranges or resources_changed:
                pipe.update(0, b"\0\x17")
            if time.monotonic() - last_channels >= 0.1:
                for offset in (0, 16384):
                    payload = get(base, f"/api/memory?address={0x1400 + offset}&length=16384")
                    pipe.update(0x1400 + offset, payload)
                last_channels = time.monotonic()
            time.sleep(0.02)
    except KeyboardInterrupt:
        pass
    finally:
        pipe.close()
        if process and process.poll() is None:
            process.terminate()


if __name__ == "__main__":
    main()