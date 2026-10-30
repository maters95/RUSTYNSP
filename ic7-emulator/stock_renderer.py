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
from ic7_emulator import RUNTIME_COMPONENT_PATHS


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


def renderer_ready(display):
    return display.get("phase") in ("dash", "splash")


def renderer_restart_required(display, launched_reboot_revision):
    return (display.get("phase") == "blank" or
            display.get("reboot_revision") != launched_reboot_revision)


def merge_settings_ranges(ranges):
    merged = []
    for start, end in sorted((entry["address"], entry["address"] + entry["length"])
                             for entry in ranges if entry["length"] > 0):
        if merged and start <= merged[-1]["address"] + merged[-1]["length"]:
            merged[-1]["length"] = max(end, merged[-1]["address"] + merged[-1]["length"]) - merged[-1]["address"]
        else:
            merged.append({"address": start, "length": end - start})
    return merged


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


NSP_LIVE_MAPPING = "Local\\HaltechNSP_iC7_LiveData"
NSP_LIVE_MAGIC = 0x4C374349
NSP_LIVE_HEADER = 32
NSP_LIVE_CAPACITY = NSP_LIVE_HEADER + 65536
NSP_LIVE_STALE_SECONDS = 1.0


def decode_live_mirror(header, payload, header_after, utc_ticks=None):
    """Decode one consistent NSP live-data snapshot, or return None while NSP is writing."""
    if len(header) < NSP_LIVE_HEADER or header != header_after:
        return None
    magic, version, sequence, address, length, simulating = struct.unpack_from("<IIIIII", header)
    if magic != NSP_LIVE_MAGIC or version != 1 or sequence == 0 or sequence & 1:
        return None
    if not 0 < length <= NSP_LIVE_CAPACITY - NSP_LIVE_HEADER or len(payload) < length:
        return None
    if address < 0x1000 or address + length > 0x20000:
        return None
    written = struct.unpack_from("<q", header, 24)[0]
    if utc_ticks is None:
        utc_ticks = int((time.time() + 62135596800) * 10000000)
    if not 0 <= utc_ticks - written <= int(NSP_LIVE_STALE_SECONDS * 10000000):
        return None
    return {"sequence": sequence, "address": address, "data": bytes(payload[:length]),
            "simulating": bool(simulating)}


class NspLiveMirror:
    """Read-only view of the live-data block NSP sends to its own dash renderer."""

    def __init__(self, clock=time.monotonic):
        self.clock = clock
        self.view = None
        self.handle = None
        self.last_sequence = None
        self.changed_at = 0.0
        self.api = ctypes.WinDLL("kernel32", use_last_error=True) if os.name == "nt" else None
        if self.api:
            self.api.OpenFileMappingW.argtypes = [wintypes.DWORD, wintypes.BOOL, wintypes.LPCWSTR]
            self.api.OpenFileMappingW.restype = wintypes.HANDLE
            self.api.MapViewOfFile.argtypes = [wintypes.HANDLE, wintypes.DWORD, wintypes.DWORD,
                                               wintypes.DWORD, ctypes.c_size_t]
            self.api.MapViewOfFile.restype = ctypes.c_void_p
            self.api.UnmapViewOfFile.argtypes = [ctypes.c_void_p]
            self.api.CloseHandle.argtypes = [wintypes.HANDLE]

    def _snapshot(self):
        if self.api is None:
            return None
        if self.view is None:
            handle = self.api.OpenFileMappingW(4, False, NSP_LIVE_MAPPING)  # FILE_MAP_READ
            if not handle:
                return None
            view = self.api.MapViewOfFile(handle, 4, 0, 0, NSP_LIVE_CAPACITY)
            if not view:
                self.api.CloseHandle(handle)
                return None
            self.handle, self.view = handle, view
        header = ctypes.string_at(self.view, NSP_LIVE_HEADER)
        length = struct.unpack_from("<I", header, 16)[0]
        payload = ctypes.string_at(self.view + NSP_LIVE_HEADER,
                                   min(length, NSP_LIVE_CAPACITY - NSP_LIVE_HEADER))
        return header, payload, ctypes.string_at(self.view, NSP_LIVE_HEADER)

    def latest(self, snapshot=None):
        """Return the newest NSP block while NSP is actively updating it, else None."""
        snapshot = snapshot if snapshot is not None else self._snapshot()
        block = decode_live_mirror(*snapshot) if snapshot else None
        now = self.clock()
        if block is None:
            if self.view is not None:
                self.close()
            return None
        if block["sequence"] != self.last_sequence:
            self.last_sequence = block["sequence"]
            self.changed_at = now
        return block if now - self.changed_at <= NSP_LIVE_STALE_SECONDS else None

    def close(self):
        if self.view:
            self.api.UnmapViewOfFile(self.view)
            self.api.CloseHandle(self.handle)
        self.view = self.handle = None


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
        shutil.copy2(library, target)
    if (runtime / "qt.conf").exists():
        shutil.copy2(runtime / "qt.conf", destination / "qt.conf")
    for name in ("platforms", "imageformats", "bearer", "styles", "qml", "plugins"):
        if (runtime / name).is_dir():
            shutil.copytree(runtime / name, destination / name, dirs_exist_ok=True)
    stage_multimedia_addons(runtime, destination)
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
    install_startup_qml(destination)
    if patched:
        install_component_override(destination, Path(__file__).with_name("qml") / "patched-gif" / "HalImage.qml")
    validate_multimedia_runtime(destination)
    return executable


def stage_multimedia_addons(runtime, destination):
    for source_name, target_name in (("ic7-media-qml", "qml"),
                                     ("ic7-media-plugins", "plugins")):
        source = Path(runtime) / source_name
        if source.is_dir():
            shutil.copytree(source, Path(destination) / target_name, dirs_exist_ok=True)


def shared_component_source(name):
    maintained = Path(__file__).resolve().parent.parent / "ic7-custom-dash/deploy/nsp" / name
    return maintained if maintained.is_file() else Path(__file__).with_name("qml") / "stock_renderer" / name


def alert_component_source():
    return shared_component_source("HalAlarmPopup.qml")


def install_startup_qml(destination):
    destination = Path(destination)
    sources = {
        destination / "qml_components_data/qml/factory_screens/main.qml":
            shared_component_source("main.qml"),
        destination / "qml_components_data/qml/user_components/HalSplash.qml":
            shared_component_source("HalSplash.qml"),
        destination / "qml_components_data/qml/user_components/HalImage.qml":
            shared_component_source("HalImage.qml"),
        destination / "qml_components_data/qml/user_components/HalAlarmPopup.qml": alert_component_source(),
    }
    for target, source in sources.items():
        if not source.is_file() or not target.parent.is_dir():
            raise FileNotFoundError(f"Stock renderer startup QML is missing: {source if not source.is_file() else target.parent}")
        shutil.copyfile(source, target)
        target.with_suffix(target.suffix + "c").unlink(missing_ok=True)
    return tuple(sources)


def validate_multimedia_runtime(destination):
    destination = Path(destination)
    required = (
        ("qml/QtMultimedia/qmldir", "QtMultimedia QML module"),
        ("qml/QtMultimedia/Video.qml", "QtMultimedia Video component"),
        ("qml/QtMultimedia/declarative_multimedia.dll", "QtMultimedia QML plugin"),
        ("Qt5Multimedia.dll", "QtMultimedia runtime"),
        ("Qt5MultimediaQuick.dll", "QtMultimedia Quick runtime"),
        ("Qt5Widgets.dll", "Qt Widgets runtime"),
    )
    missing = [label for relative, label in required if not (destination / relative).is_file()]
    image_plugin_paths = (destination / "plugins/imageformats", destination / "imageformats")
    if not any((folder / "qgif.dll").is_file() or (folder / "libqgif.dll").is_file()
               for folder in image_plugin_paths):
        missing.append("Qt GIF image-format plugin (imageformats/qgif.dll)")
    media_plugins = destination / "plugins/mediaservice"
    if not (media_plugins / "dsengine.dll").is_file():
        missing.append("Qt Multimedia DirectShow media-player plugin (dsengine.dll)")
    if missing:
        raise RuntimeError(
            "The isolated NSP renderer cannot load the maintained GIF/MP4 splash QML; "
            "the Qt 5.11 Multimedia runtime is incomplete: " + ", ".join(missing) +
            ". Run the combined NSP bundle's setup-native-media.ps1, open an iC-7 map "
            "in that NSP copy to stage its runtime, close its renderer, then retry."
        )
    return True


def sync_resources(base, destination, previous):
    state = json.loads(get(base, "/api/status"))
    current = {}
    for resource in state["assets"]:
        name = resource["name"]
        namespace, separator, relative_name = name.partition("/")
        if not separator or namespace not in ("h", "u") or not relative_name:
            continue
        key = (resource["kind"], name)
        current[key] = resource["sha256"]
        if previous.get(key) == resource["sha256"]:
            continue
        target = _resource_target(destination, resource["kind"], namespace, relative_name)
        target.parent.mkdir(parents=True, exist_ok=True)
        encoded = urllib.parse.urlencode({"kind": resource["kind"], "name": name})
        target.write_bytes(get(base, "/api/resource?" + encoded))
    for kind, name in previous.keys() - current.keys():
        namespace, separator, relative_name = name.partition("/")
        if not separator or namespace not in ("h", "u") or not relative_name:
            continue
        target = _resource_target(destination, kind, namespace, relative_name)
        if namespace == "h":
            archive_name = target.relative_to(destination).as_posix()
            with zipfile.ZipFile(Path(__file__).with_name("renderer-resources.zip")) as archive:
                if archive_name in archive.namelist():
                    target.write_bytes(archive.read(archive_name))
                    continue
        target.unlink(missing_ok=True)
    return current


def _resource_target(destination, kind, namespace, relative_name):
    folder = "images" if kind == 0 else "fonts"
    base_folder = "user_resources" if namespace == "u" else "qml_components_data"
    return Path(destination) / base_folder / folder / relative_name


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


def install_sandbox_runtime(base, destination, changes):
    """Validate every sidecar before replacing any runtime component."""
    hashes = changes.get("runtime_components", {})
    if not hashes:
        return install_sandbox_component(base, destination)
    if set(hashes) - RUNTIME_COMPONENT_PATHS.keys():
        raise ValueError("Unsupported sandbox runtime components")
    pending = {}
    for name, checksum in hashes.items():
        payload = get(base, "/api/component?" + urllib.parse.urlencode({"name": name}))
        if hashlib.sha256(payload).hexdigest() != checksum:
            raise ValueError("Sandbox runtime component hash mismatch: " + name)
        target = Path(destination) / RUNTIME_COMPONENT_PATHS[name]
        if not target.parent.is_dir():
            raise FileNotFoundError("Sandbox runtime directory is missing: " + str(target.parent))
        pending[target] = payload
    for target, payload in pending.items():
        target.write_bytes(payload)
        target.with_suffix(target.suffix + "c").unlink(missing_ok=True)
    return changes.get("component_sha256")


def renderer_environment(work):
    work = Path(work)
    platform_dirs = (work / "platforms", work / "plugins" / "platforms")
    platform_dir = next((path for path in platform_dirs if (path / "qwindows.dll").is_file()), None)
    if platform_dir is None:
        raise FileNotFoundError("The isolated Qt runtime has no qwindows.dll platform plugin")
    environment = os.environ.copy()
    environment["QT_PLUGIN_PATH"] = os.pathsep.join((str(work / "plugins"), str(work)))
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
    parser.add_argument("--stop-file", type=Path, help="Stop gracefully when this workbench signal file exists")
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
    initial_changes = json.loads(get(base, "/api/changes?after=-1"))
    component_checksum = (None if explicit_component else
                          install_sandbox_runtime(base, args.work, initial_changes))
    runtime_hashes = initial_changes.get("runtime_components", {})
    resources = {}
    pipe = None
    process = None
    launched_reboot_revision = None
    revision = -1
    resource_revision = None
    last_channels = 0
    live_mirror = NspLiveMirror()
    live_source = None
    try:
        while True:
            if args.stop_file is not None and args.stop_file.exists():
                print("Workbench requested dash display shutdown.", flush=True)
                break
            if process is not None and process.poll() is not None:
                raise RuntimeError(f"Dash renderer exited with code {process.returncode}; "
                                   "see renderer.log, then use Dash Display to retry")
            status = json.loads(get(base, "/api/status"))
            display = status.get("display", {"phase": "blank", "reboot_revision": 0})
            changes = json.loads(get(base, f"/api/changes?after={revision}"))
            runtime_changed = not explicit_component and (
                changes.get("component_sha256") != component_checksum or
                changes.get("runtime_components", {}) != runtime_hashes)
            if process is not None and (renderer_restart_required(display, launched_reboot_revision) or runtime_changed):
                print("Stopping the isolated renderer for the emulator display lifecycle change.", flush=True)
                pipe.close()
                pipe = None
                if process.poll() is None:
                    process.terminate()
                    process.wait(timeout=5)
                process = None
                revision = -1
                resource_revision = None
                last_channels = 0
                if display["phase"] == "blank":
                    time.sleep(0.05)
                    continue
            if runtime_changed:
                install_startup_qml(args.work)
                component_checksum = install_sandbox_runtime(base, args.work, changes)
                runtime_hashes = changes.get("runtime_components", {})
                print("Verified firmware preview components reloaded.", flush=True)
            if process is None:
                if not renderer_ready(display):
                    time.sleep(0.05)
                    continue
                resources = sync_resources(base, args.work, resources)
                pipe = WindowsPipe()
                process = subprocess.Popen(
                    [str(executable.resolve()), "./qml_components_data/qml", "54000", "21", "11"],
                    cwd=args.work, env=renderer_environment(args.work))
                try:
                    pipe.connect()
                except Exception:
                    pipe.close()
                    pipe = None
                    if process.poll() is None:
                        process.terminate()
                        process.wait(timeout=5)
                    process = None
                    raise
                launched_reboot_revision = display["reboot_revision"]
                revision = -1
                resource_revision = None
                last_channels = 0
                print("Original dash renderer connected to isolated SIM_Dash_Pipe.", flush=True)
                continue
            resources_changed = changes["resource_revision"] != resource_revision
            if resources_changed:
                resources = sync_resources(base, args.work, resources)
                resource_revision = changes["resource_revision"]
            if changes["full_refresh"]:
                ranges = [{"address": 0x20000, "length": 651264}]
            else:
                ranges = merge_settings_ranges(changes["ranges"])
            for entry in ranges:
                for offset in range(0, entry["length"], 16384):
                    count = min(16384, entry["length"] - offset)
                    address = entry["address"] + offset
                    payload = get(base, f"/api/memory?address={address}&length={count}")
                    pipe.update(address, payload)
            revision = changes["revision"]
            if ranges or resources_changed:
                pipe.update(0, b"\0\x17")
            if time.monotonic() - last_channels >= 0.05:
                block = live_mirror.latest()
                source = ("NSP Simulate" if block and block["simulating"] else
                          "NSP live data" if block else "emulator memory")
                if source != live_source:
                    print(f"Live channels and alarms now follow {source}.", flush=True)
                    live_source = source
                if block:
                    for offset in range(0, len(block["data"]), 16384):
                        pipe.update(block["address"] + offset, block["data"][offset:offset + 16384])
                    last_channels = time.monotonic()
                elif time.monotonic() - last_channels >= 0.1:
                    for offset in (0, 16384):
                        payload = get(base, f"/api/memory?address={0x1400 + offset}&length=16384")
                        pipe.update(0x1400 + offset, payload)
                    last_channels = time.monotonic()
            time.sleep(0.02)
    except KeyboardInterrupt:
        pass
    finally:
        live_mirror.close()
        if pipe is not None:
            pipe.close()
        if process and process.poll() is None:
            process.terminate()
            try:
                process.wait(timeout=5)
            except subprocess.TimeoutExpired:
                process.kill()
                process.wait()


if __name__ == "__main__":
    main()