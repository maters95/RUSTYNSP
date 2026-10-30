import hashlib
import json
import shutil
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
from ic7_emulator import Device, INSTANT_TIMING, request
import stock_renderer
sys.path.insert(0, str(Path(__file__).resolve().parent))
import nex_fixtures


PROFILE = Path(__file__).resolve().parents[1] / "device-profile.zip"


class RendererLifecycleTests(unittest.TestCase):
    def test_settings_updates_are_coalesced_without_losing_coverage(self):
        ranges = [{"address": 120, "length": 30}, {"address": 100, "length": 30},
                  {"address": 150, "length": 10}, {"address": 300, "length": 5},
                  {"address": 310, "length": 0}]
        self.assertEqual(stock_renderer.merge_settings_ranges(ranges),
                         [{"address": 100, "length": 60}, {"address": 300, "length": 5}])
        self.assertEqual(ranges[0], {"address": 120, "length": 30})

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
                    "install": {"revision": 2 if iteration >= 3 else 1},
                    "revision": 1, "resource_revision": 1, "full_refresh": True, "ranges": [],
                }).encode()
            if path.startswith("/api/memory"):
                return bytes(int(parse_qs(urlsplit(path).query)["length"][0]))
            raise AssertionError(path)

        launches = []

        def make_process(*args, **kwargs):
            launches.append((args, kwargs))
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
                    patch.object(stock_renderer, "install_startup_qml") as maintained, \
                    patch.object(stock_renderer, "install_dash_resources") as install, \
                    patch.object(stock_renderer, "sync_resources", return_value={}), \
                    patch.object(stock_renderer, "renderer_environment", return_value={}), \
                    patch.object(stock_renderer, "NspLiveMirror", return_value=mirror), \
                    patch.object(stock_renderer.time, "sleep"):
                stock_renderer.main()
        self.assertEqual(len(processes), 3)
        # Once at start and once when the emulator reports a new NEX install.
        self.assertEqual(install.call_count, 2)
        maintained.assert_not_called()
        # dash_virtual runs from the mirrored dtn/resources folder, like the dash's QML root.
        for args, kwargs in launches:
            self.assertEqual(Path(kwargs["cwd"]).parts[-2:], ("dtn", "resources"))
            self.assertEqual(args[0][1], "./qml_components_data/qml")
        for process, pipe in zip(processes, pipes):
            process.terminate.assert_called_once()
            pipe.connect.assert_called_once()
            pipe.close.assert_called_once()
        pipes[-1].update.assert_any_call(0x1400, b"NSP channel block")
        mirror.close.assert_called_once()

    def test_complete_sandbox_install_survives_saved_session_restart(self):
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            members = {"qml_components_data/qml/user_components/HalImage.qml": b"Item { objectName: 'nex' }",
                       "qml_components_data/qml/user_components/Ic7New.qml": b"Item {}"}
            package = root / "ic7-2.36-test-experimental.nex"
            payload, _ = nex_fixtures.write_nex(package, members)
            device = Device(PROFILE, root / "state", sandbox_package=package, timing=INSTANT_TIMING)
            device.respond(request(1, 0, 0, 2, b"\0\x01"))
            device.respond(request(1, 1, 0x25000000, len(payload), payload))
            device.respond(request(1, 2, 0, 2, b"\0\0"))
            device.save()
            shutil.rmtree(device.resources_root)
            (device.dash_root / "install.json").unlink()
            restored = Device(PROFILE, root / "state")
            self.assertTrue(restored.sandbox.installed)
            self.assertEqual(restored.install["payload_sha256"], hashlib.sha256(payload).hexdigest())
            for name, data in members.items():
                self.assertEqual((restored.resources_root / name).read_bytes(), data)
            from viewer import start_viewer
            from urllib.request import urlopen
            server = start_viewer(restored, 0)
            try:
                base = f"http://127.0.0.1:{server.server_port}"
                with urlopen(base + "/api/changes") as response:
                    self.assertEqual(json.load(response)["install"]["payload_sha256"],
                                     hashlib.sha256(payload).hexdigest())
                work = root / "renderer"
                stock_renderer.install_dash_resources(base, work)
                for name, data in members.items():
                    self.assertEqual((stock_renderer.resources_root(work) / name).read_bytes(), data)
            finally:
                server.shutdown()
                server.server_close()


if __name__ == "__main__":
    unittest.main()
