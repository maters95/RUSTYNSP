import hashlib
import json
from pathlib import Path
import struct
import sys
import tempfile
from types import SimpleNamespace
import unittest
from unittest.mock import MagicMock, patch
from urllib.parse import parse_qs, urlsplit
import zipfile

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
from ic7_emulator import Device, RUNTIME_COMPONENT_PATHS, request
import stock_renderer


class RendererLifecycleTests(unittest.TestCase):
    def test_reboots_and_firmware_changes_restart_instead_of_exiting(self):
        iteration = 0
        pipes, processes = [], []

        def get(base, path):
            nonlocal iteration
            if path == "/api/status":
                iteration += 1
                if iteration == 5:
                    raise KeyboardInterrupt()
                return json.dumps({"display": {
                    "phase": "dash", "reboot_revision": 0 if iteration == 1 else 1}}).encode()
            if path.startswith("/api/changes"):
                return json.dumps({
                    "component_sha256": "new" if iteration >= 3 else "old",
                    "runtime_components": {"HalImage.qml": "new" if iteration >= 3 else "old"},
                    "revision": 1, "resource_revision": 1, "full_refresh": True, "ranges": [],
                }).encode()
            if path.startswith("/api/memory"):
                return bytes(int(parse_qs(urlsplit(path).query)["length"][0]))
            raise AssertionError(path)

        def make_process(*args, **kwargs):
            process = MagicMock()
            process.poll.return_value = None
            processes.append(process)
            return process

        def make_pipe():
            pipe = MagicMock()
            pipes.append(pipe)
            return pipe

        mirror = MagicMock()
        mirror.latest.return_value = {"address": 0x1400, "data": b"NSP channel block", "simulating": True}
        with tempfile.TemporaryDirectory() as directory:
            with patch.object(sys, "argv", ["stock_renderer.py", "--work", directory]), \
                    patch.object(stock_renderer, "os", SimpleNamespace(name="nt", environ={})), \
                    patch.object(stock_renderer, "prepare_runtime", return_value=Path(directory) / "dash.exe"), \
                    patch.object(stock_renderer, "get", side_effect=get), \
                    patch.object(stock_renderer, "WindowsPipe", side_effect=make_pipe), \
                    patch.object(stock_renderer.subprocess, "Popen", side_effect=make_process), \
                    patch.object(stock_renderer, "install_startup_qml"), \
                    patch.object(stock_renderer, "install_sandbox_runtime", side_effect=["old", "new"]) as install, \
                    patch.object(stock_renderer, "sync_resources", return_value={}), \
                    patch.object(stock_renderer, "renderer_environment", return_value={}), \
                    patch.object(stock_renderer, "NspLiveMirror", return_value=mirror), \
                    patch.object(stock_renderer.time, "sleep"):
                stock_renderer.main()
        self.assertEqual(len(processes), 3)
        self.assertEqual(install.call_count, 2)
        for process, pipe in zip(processes, pipes):
            process.terminate.assert_called_once()
            pipe.connect.assert_called_once()
            pipe.close.assert_called_once()
        pipes[-1].update.assert_any_call(0x1400, b"NSP channel block")
        mirror.close.assert_called_once()

    def test_all_runtime_sidecars_are_checked_before_any_are_written(self):
        components = {"HalImage.qml": b"new-image", "HalSplash.qml": b"new-splash"}
        changes = {"component_sha256": hashlib.sha256(components["HalImage.qml"]).hexdigest(),
                   "runtime_components": {name: hashlib.sha256(data).hexdigest()
                                          for name, data in components.items()}}
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            for name in components:
                target = root / RUNTIME_COMPONENT_PATHS[name]
                target.parent.mkdir(parents=True, exist_ok=True)
                target.write_bytes(b"old")
            with patch.object(stock_renderer, "get", side_effect=[b"new-image", b"corrupt"]):
                with self.assertRaisesRegex(ValueError, "hash mismatch"):
                    stock_renderer.install_sandbox_runtime("", root, changes)
            for name in components:
                self.assertEqual((root / RUNTIME_COMPONENT_PATHS[name]).read_bytes(), b"old")
            with patch.object(stock_renderer, "get", side_effect=list(components.values())):
                stock_renderer.install_sandbox_runtime("", root, changes)
            for name, data in components.items():
                self.assertEqual((root / RUNTIME_COMPONENT_PATHS[name]).read_bytes(), data)

    def test_complete_sandbox_runtime_survives_saved_session_restart(self):
        profile = Path(__file__).resolve().parents[1] / "device-profile.zip"
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            payload = bytes(range(32))
            metadata = bytes(range(16))
            wrapped = struct.pack("<II4sIIII", 2, 0, bytes(4), 0x25000000, 128, 16384, 4000) + metadata + payload
            package = root / "ic7-2.36-test-experimental.nex"
            with zipfile.ZipFile(package, "w") as archive:
                archive.writestr("manifest.xml",
                                '<NEX_FILE><PRODUCT pid="21" vid="11" hdefFile="ic-7.hdef">'
                                '<FILE name="res_ic-7.qzip" /></PRODUCT></NEX_FILE>')
                archive.writestr("res_ic-7.qzip", wrapped)
                archive.writestr("ic-7.hdef", b"definition")
            components = {name: ("Item { property string name: '" + name + "' }").encode()
                          for name in RUNTIME_COMPONENT_PATHS}
            for name, data in components.items():
                (root / name).write_bytes(data)
            (root / "build-report.json").write_text(json.dumps({
                "label": "test",
                "packages": {package.name: {"sha256": hashlib.sha256(package.read_bytes()).hexdigest()}},
                "replacement_component_sha256": hashlib.sha256(components["HalImage.qml"]).hexdigest(),
                "runtime_components": {name: hashlib.sha256(data).hexdigest()
                                       for name, data in components.items()},
            }))
            device = Device(profile, root / "state", sandbox_package=package)
            device.respond(request(1, 0, 0, 2, b"\0\x01"))
            device.respond(request(1, 1, 0x25000000, len(payload), payload))
            device.respond(request(1, 2, 0, 2, b"\0\0"))
            device.save()
            restored = Device(profile, root / "state")
            self.assertTrue(restored.sandbox.component_active)
            self.assertEqual(restored.sandbox.components, components)
            self.assertEqual(restored.sandbox.runtime_hashes(), device.sandbox.runtime_hashes())
            (root / "HalSplash.qml").write_bytes(b"bad")
            with self.assertRaisesRegex(ValueError, "hash mismatch"):
                Device(profile, root / "state")


if __name__ == "__main__":
    unittest.main()
