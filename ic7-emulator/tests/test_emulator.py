import base64
import io
import json
from pathlib import Path
import struct
import sys
import tempfile
import threading
import unittest
from unittest.mock import MagicMock, Mock, patch
import urllib.request
import zipfile
import zlib

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
from ic7_emulator import Device, Memory, ProtocolCapture, RequestStream, Resources, request, resource_descriptor
from ic7_emulator import serve_stream, UpdateSandbox
from workbench import SessionOptions, configured_nsp_port, virtual_ports
from viewer import start_viewer, render_layout, scene_state
from stock_renderer import get, install_component_override, pe_machine, pipe_message, renderer_environment
from stock_renderer import stage_windows_platform_plugin, validate_ack
from stock_renderer import install_sandbox_component
import package as emulator_package


class ProtocolTests(unittest.TestCase):
    def test_workbench_sessions_preserve_existing_state(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            profile = root / "profile.zip"
            profile.write_bytes(b"fixture")
            options = SessionOptions(profile, root / "sessions")
            first = options.create_state()
            (first / "session.json").write_text("preserved")
            self.assertNotEqual(first, options.create_state())
            self.assertEqual((first / "session.json").read_text(), "preserved")
            with self.assertRaisesRegex(ValueError, "actual extracted location"):
                SessionOptions(profile, root, root / "missing.nex").create_state()

    def test_workbench_only_lists_identified_virtual_ports(self):
        ports = [Mock(device="COM11", description="HHD Virtual Serial Port", manufacturer="HHD", hwid=""),
                 Mock(device="COM10", description="Haltech iC-7 Simulator", manufacturer="", hwid=""),
                 Mock(device="COM3", description="Haltech iC-7", manufacturer="Haltech", hwid="USB")]
        self.assertEqual(virtual_ports(ports), ["COM10", "COM11"])

    def test_workbench_recognizes_only_the_configured_nsp_port(self):
        ports = [Mock(device="COM10", description="Haltech iC-7 Simulator"),
                 Mock(device="COM11", description="HHD Virtual Serial Port"),
                 Mock(device="COM3", description="Haltech iC-7")]
        self.assertEqual(configured_nsp_port(ports), "COM10")
        self.assertIsNone(configured_nsp_port(ports[1:]))

    def test_missing_sandbox_package_has_actionable_error(self):
        with tempfile.TemporaryDirectory() as temporary:
            with self.assertRaisesRegex(ValueError, "Select the extracted NEX"):
                UpdateSandbox(Path(temporary) / "missing.nex", Path(temporary) / "state")

    def test_package_excludes_normal_and_sandbox_state(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary) / "emulator"
            root.mkdir()
            (root / "module.py").write_text("value = 1\n")
            for folder in ("state", "sandbox-state", "workbench-state", ".venv"):
                directory = root / folder
                directory.mkdir()
                (directory / "private.jsonl").write_text("private\n")
            output = Path(temporary) / "download.zip"
            with patch.object(emulator_package, "__file__", str(root / "package.py")), patch.object(
                    sys, "argv", ["package.py", "--output", str(output)]):
                emulator_package.main()
            with zipfile.ZipFile(output) as archive:
                self.assertEqual(archive.namelist(), ["ic7-emulator/module.py"])

    def test_renderer_installs_hash_verified_sandbox_component(self):
        import hashlib
        with tempfile.TemporaryDirectory() as temporary:
            destination = Path(temporary)
            target = destination / "qml_components_data/qml/user_components/HalImage.qml"
            target.parent.mkdir(parents=True)
            target.write_bytes(b"Item {}")
            component = b"import QtQuick 2.9\nItem { objectName: 'sandbox' }"
            checksum = hashlib.sha256(component).hexdigest()
            status = json.dumps({"component_sha256": checksum}).encode()
            with patch("stock_renderer.get", side_effect=[status, component]):
                self.assertEqual(install_sandbox_component("http://127.0.0.1", destination), checksum)
            self.assertEqual(target.read_bytes(), component)
            with patch("stock_renderer.get", side_effect=[status, b"corrupt"]):
                with self.assertRaisesRegex(ValueError, "hash mismatch"):
                    install_sandbox_component("http://127.0.0.1", destination)
            self.assertEqual(target.read_bytes(), component)

    def test_renderer_http_get_retries_connection_reset(self):
        response = MagicMock()
        response.__enter__.return_value = response
        response.read.return_value = b"{}"
        reset = urllib.error.URLError(ConnectionResetError("reset"))
        with patch("stock_renderer.time.sleep") as sleep, patch(
                "stock_renderer.urllib.request.urlopen", side_effect=[reset, response]) as urlopen:
            self.assertEqual(get("http://127.0.0.1:8765", "/api/changes"), b"{}")
        self.assertEqual(urlopen.call_count, 2)
        sleep.assert_called_once_with(0.2)

    def test_renderer_http_get_reports_persistent_viewer_disconnect(self):
        reset = urllib.error.URLError(ConnectionResetError("reset"))
        with patch("stock_renderer.time.sleep"), patch(
                "stock_renderer.urllib.request.urlopen", side_effect=reset):
            with self.assertRaisesRegex(ConnectionError, "keep the emulator running"):
                get("http://127.0.0.1:8765", "/api/changes")

    def test_component_override_targets_only_isolated_renderer(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            source = root / "candidate" / "HalImage.qml"
            source.parent.mkdir()
            source.write_text("Item { objectName: 'candidate' }", encoding="utf-8")
            isolated = root / "renderer"
            target = isolated / "qml_components_data/qml/user_components/HalImage.qml"
            target.parent.mkdir(parents=True)
            target.write_text("Item { objectName: 'stock' }", encoding="utf-8")

            result = install_component_override(isolated, source)

            self.assertEqual(result, target)
            self.assertEqual(target.read_text(encoding="utf-8"), source.read_text(encoding="utf-8"))
            self.assertEqual(source.read_text(encoding="utf-8"), "Item { objectName: 'candidate' }")

    def test_component_override_rejects_other_qml_files(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            source = root / "Other.qml"
            source.write_text("Item {}", encoding="utf-8")
            with self.assertRaises(ValueError):
                install_component_override(root, source)

    def test_component_override_checks_multimedia_runtime(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            source = root / "candidate" / "HalImage.qml"
            source.parent.mkdir()
            source.write_text("import QtMultimedia 5.9\nItem {}", encoding="utf-8")
            target = root / "renderer/qml_components_data/qml/user_components/HalImage.qml"
            target.parent.mkdir(parents=True)
            target.write_text("Item {}", encoding="utf-8")

            with self.assertRaisesRegex(RuntimeError, "QtMultimedia QML module"):
                install_component_override(target.parents[3], source)

            module = target.parents[3] / "qml/QtMultimedia"
            module.mkdir(parents=True)
            (module / "qmldir").write_text("module QtMultimedia", encoding="utf-8")
            install_component_override(target.parents[3], source)
            self.assertIn("QtMultimedia", target.read_text(encoding="utf-8"))

    def test_bundled_gif_component_needs_no_multimedia_plugin(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            target = root / "renderer/qml_components_data/qml/user_components/HalImage.qml"
            target.parent.mkdir(parents=True)
            target.write_text("Item {}", encoding="utf-8")
            source = Path(__file__).resolve().parents[1] / "qml/patched-gif/HalImage.qml"

            install_component_override(root / "renderer", source)

            self.assertNotIn("QtMultimedia", target.read_text(encoding="utf-8"))

    def test_renderer_uses_isolated_qt_plugin_paths(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            platform = root / "plugins/platforms"
            platform.mkdir(parents=True)
            (platform / "qwindows.dll").write_bytes(b"fixture")
            environment = renderer_environment(root)
            self.assertEqual(environment["QT_PLUGIN_PATH"], str(root))
            self.assertEqual(environment["QT_QPA_PLATFORM_PLUGIN_PATH"], str(platform))
            self.assertEqual(environment["QML2_IMPORT_PATH"], str(root / "qml"))

    def test_renderer_reports_missing_windows_platform_plugin(self):
        with tempfile.TemporaryDirectory() as temporary:
            with self.assertRaisesRegex(FileNotFoundError, "qwindows.dll"):
                renderer_environment(temporary)

    def test_nested_qwindows_plugin_is_staged_for_matching_architecture(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            runtime = root / "runtime"
            renderer = runtime / "dash_virtual.exe"
            plugin = runtime / "Qt/5.11/plugins/platforms/qwindows.dll"
            destination = root / "isolated"
            plugin.parent.mkdir(parents=True)

            def write_pe(path, machine):
                header = bytearray(0x86)
                header[:2] = b"MZ"
                struct.pack_into("<I", header, 0x3C, 0x80)
                header[0x80:0x84] = b"PE\0\0"
                struct.pack_into("<H", header, 0x84, machine)
                path.write_bytes(header)

            write_pe(renderer, 0x14C)
            write_pe(plugin, 0x14C)
            self.assertEqual(pe_machine(renderer), 0x14C)

            staged = stage_windows_platform_plugin(runtime, destination)

            self.assertEqual(staged, destination / "platforms/qwindows.dll")
            self.assertEqual(staged.read_bytes(), plugin.read_bytes())

    def test_sibling_haltech_plugins_directory_is_searched(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary) / "Haltech"
            runtime = root / "Nexus"
            plugin = root / "plugins/platforms/qwindows.dll"
            runtime.mkdir(parents=True)
            plugin.parent.mkdir(parents=True)

            def write_pe(path, machine):
                header = bytearray(0x86)
                header[:2] = b"MZ"
                struct.pack_into("<I", header, 0x3C, 0x80)
                header[0x80:0x84] = b"PE\0\0"
                struct.pack_into("<H", header, 0x84, machine)
                path.write_bytes(header)

            write_pe(runtime / "dash_virtual.exe", 0x14C)
            write_pe(plugin, 0x14C)
            destination = root / "state/stock-renderer"

            staged = stage_windows_platform_plugin(runtime, destination)

            self.assertEqual(staged.read_bytes(), plugin.read_bytes())

    def test_original_preview_pipe_contract(self):
        packet = pipe_message(0x20000, b"test")
        self.assertEqual(packet[:12], bytes.fromhex("010000000002000000000004"))
        self.assertEqual(packet[12:-4], b"test")
        acknowledgement = packet[:12] + zlib.crc32(packet[:12]).to_bytes(4, "big")
        validate_ack(acknowledgement)
        with self.assertRaises(ValueError):
            validate_ack(acknowledgement[:-1] + bytes((acknowledgement[-1] ^ 1,)))

    def test_fragmented_and_coalesced_requests(self):
        first = request(2, 7, 0x1400, 13312)
        second = request(1, 8, 0x20000, 4, b"test")
        stream = RequestStream()
        self.assertEqual(stream.feed(first[:9]), [])
        self.assertEqual(stream.feed(first[9:] + second), [first, second])

    def test_rejects_bad_crc(self):
        packet = bytearray(request(2, 7, 0, 1024))
        packet[-1] ^= 1
        stream = RequestStream()
        self.assertEqual(stream.feed(packet), [])
        self.assertGreater(stream.rejected, 0)

    def test_memory_crosses_page_boundary(self):
        memory = Memory()
        memory.write(4094, b"abcdef")
        self.assertEqual(memory.read(4092, 10), b"\0\0abcdef\0\0")

    def test_device_ack_and_readback(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            profile = root / "profile.zip"
            with zipfile.ZipFile(profile, "w") as archive:
                archive.writestr("profile.json", json.dumps({"segments": [{"address": 0, "file": "id.bin"}]}))
                archive.writestr("id.bin", bytes((2, 36, 0)) + bytes(1021))
            device = Device(profile, root / "state")
            write = request(1, 3, 0x20000, 4, b"test")
            ack = device.respond(write)
            self.assertEqual(ack[:12], write[:12])
            self.assertEqual(len(ack), 16)
            read = request(2, 4, 0x20000, 4)
            reply = device.respond(read)
            self.assertEqual(reply[:12], read[:12])
            self.assertEqual(reply[12:-4], b"test")
            self.assertEqual(zlib.crc32(reply[:-4]), int.from_bytes(reply[-4:], "big"))
            device.respond(request(1, 5, 0, 2, b"\0\1"))
            self.assertEqual(device.memory.read(0, 3), bytes((2, 36, 0)))
            device.save()
            restored = Device(profile, root / "state")
            self.assertEqual(restored.memory.read(0x20000, 4), b"test")


class ResourceTests(unittest.TestCase):
    def test_resource_roundtrip(self):
        with tempfile.TemporaryDirectory() as temporary:
            resources = Resources(temporary)
            payload = b"GIF89a-test-fixture"
            descriptor = resource_descriptor("u/probe.png", 0, payload)
            command = b"\x06\0\0\0" + descriptor + struct.pack(">I", 0) + payload
            self.assertEqual(resources.command(command), b"\0")
            self.assertEqual(resources.command(b"\x01\0"), b"\0\0\1")
            listing = resources.command(b"\x02\0\0\0\0\0")
            self.assertEqual(listing, b"\0" + descriptor)
            read = b"\x03\0\0\0" + descriptor + struct.pack(">II", 0, len(payload))
            self.assertEqual(resources.command(read), bytes(4) + payload)
            new_descriptor = resource_descriptor("u/renamed.png", 0, payload)
            self.assertEqual(resources.command(b"\x04\0\0\0" + descriptor + new_descriptor), b"\0")
            self.assertEqual(resources.command(b"\x05\0\0\0" + new_descriptor), b"\0")
            self.assertEqual(resources.command(b"\x01\0"), b"\0\0\0")

    def test_bad_resource_checksum_is_not_success(self):
        with tempfile.TemporaryDirectory() as temporary:
            resources = Resources(temporary)
            descriptor = resource_descriptor("u/probe.png", 0, b"valid")
            command = b"\x06\0\0\0" + descriptor + bytes(4) + b"wrong"
            self.assertEqual(resources.command(command), b"\x01")
            self.assertEqual(resources.items, {})

    def test_rejects_directory_escape(self):
        with tempfile.TemporaryDirectory() as temporary:
            resources = Resources(temporary)
            descriptor = resource_descriptor("../../escape", 0, b"x")
            command = b"\x06\0\0\0" + descriptor + bytes(4) + b"x"
            self.assertEqual(resources.command(command), b"\x01")
            self.assertEqual(resources.items, {})


class IntegrationTests(unittest.TestCase):
    def setUp(self):
        self.temporary = tempfile.TemporaryDirectory()
        self.root = Path(self.temporary.name)
        self.device = Device(Path(__file__).resolve().parents[1] / "device-profile.zip", self.root)

    def tearDown(self):
        self.temporary.cleanup()

    def test_real_profile_identity(self):
        response = self.device.respond(request(2, 1, 0, 1024))
        self.assertEqual(response[12:15], bytes((2, 36, 0)))
        self.assertEqual(response[20], 21)
        self.assertEqual(response[12 + 256:12 + 262], bytes.fromhex("F1C700000001"))

    def test_boot_mode_identity_roundtrip(self):
        original = self.device.respond(request(2, 1, 0, 1024))[12:-4]
        command = request(1, 2, 0, 2, b"\0\x01")
        acknowledgement = self.device.respond(command)
        self.assertEqual(acknowledgement[:12], command[:12])
        self.assertEqual(len(acknowledgement), 16)
        boot = self.device.respond(request(2, 3, 0, 1024))[12:-4]
        self.assertEqual(boot, original[:9] + b"\x01" + original[10:])
        self.assertEqual(boot[8], 21)
        self.assertEqual(self.device.respond(request(2, 4, 9, 1))[12:-4], b"\x01")
        self.assertEqual(self.device.memory.read(0, 1024), original)
        self.device.respond(request(1, 5, 0, 2, b"\0\0"))
        restored = self.device.respond(request(2, 6, 0, 1024))[12:-4]
        self.assertEqual(restored, original)
        self.assertFalse(self.device.boot_mode)

    def test_boot_mode_does_not_persist_as_identity(self):
        self.device.respond(request(1, 1, 0, 2, b"\0\x01"))
        self.device.save()
        session = json.loads((self.root / "session.json").read_text())
        self.assertEqual(session["mode"], "boot")
        self.assertFalse(session["firmware_execution"])
        restored = Device(Path(__file__).resolve().parents[1] / "device-profile.zip", self.root)
        self.assertFalse(restored.boot_mode)
        self.assertEqual(restored.respond(request(2, 2, 9, 1))[12:-4],
                         self.device.memory.read(9, 1))

    def sandbox_device(self):
        payload = bytes(range(32))
        metadata = bytes(range(16))
        wrapped = struct.pack("<II4sIIII", 2, 0, bytes(4), 0x25000000, 128, 16384, 4000) + metadata + payload
        package = self.root / "test.nex"
        manifest = ('<NEX_FILE><PRODUCT pid="21" vid="11" hdefFile="ic-7.hdef">'
                    '<FILE name="res_ic-7.qzip" /></PRODUCT></NEX_FILE>')
        with zipfile.ZipFile(package, "w") as archive:
            archive.writestr("manifest.xml", manifest)
            archive.writestr("res_ic-7.qzip", wrapped)
            archive.writestr("ic-7.hdef", b"test migration definition")
        device = Device(Path(__file__).resolve().parents[1] / "device-profile.zip",
                        self.root / "sandbox-state", sandbox_package=package)
        finish = b"\0\x04\0\0" + metadata + struct.pack(">II", 0x25000000, len(payload))
        return device, payload, finish

    def test_sandbox_update_requires_boot_and_exact_payload(self):
        device, payload, finish = self.sandbox_device()
        refused = device.respond(request(1, 1, 0x25000000, 16, payload[:16]))
        self.assertTrue(refused[0] & 0x80)
        self.assertEqual(device.sandbox.received, b"")
        device.respond(request(1, 2, 0, 2, b"\0\x01"))
        for sequence, offset in enumerate((0, 0, 16), 3):
            response = device.respond(request(1, sequence, 0x25000000 + offset, 16, payload[offset:offset + 16]))
            self.assertFalse(response[0] & 0x80)
        response = device.respond(request(1, 6, 0, len(finish), finish))
        self.assertFalse(response[0] & 0x80)
        self.assertEqual(device.sandbox.status, "verified")
        self.assertEqual((device.state / "sandbox/received-resource.enc").read_bytes(), payload)
        status = device.respond(request(1, 7, 0, 2, b"\0\x03"))
        self.assertTrue(status[0] & 0x80)
        self.assertEqual(device.sandbox.status, "verified")
        device.save()
        session = json.loads((device.state / "session.json").read_text())
        self.assertEqual(session["sandbox_update"]["received_bytes"], len(payload))
        self.assertFalse(session["firmware_execution"])

    def test_sandbox_update_rejects_gaps_corruption_and_incomplete_finish(self):
        device, payload, finish = self.sandbox_device()
        device.respond(request(1, 1, 0, 2, b"\0\x01"))
        for address, fragment in ((0x25000010, payload[16:]),
                                  (0x25000000, bytes(16)),
                                  (0x29000000, payload[:16])):
            with self.subTest(address=address, fragment=fragment):
                response = device.respond(request(1, 2, address, len(fragment), fragment))
                self.assertTrue(response[0] & 0x80)
                self.assertEqual(device.sandbox.received, b"")
        response = device.respond(request(1, 3, 0, len(finish), finish))
        self.assertTrue(response[0] & 0x80)
        self.assertFalse((device.state / "sandbox/received-resource.enc").exists())

    def test_sandbox_update_is_reported_by_viewer(self):
        device, payload, finish = self.sandbox_device()
        server = start_viewer(device, 0)
        try:
            base = f"http://127.0.0.1:{server.server_port}"
            before = json.loads(urllib.request.urlopen(base + "/api/status").read())
            self.assertEqual(before["mode"], "main")
            self.assertEqual(before["sandbox_update"]["expected_bytes"], len(payload))
            self.assertFalse(before["firmware_execution"])
            device.respond(request(1, 1, 0, 2, b"\0\x01"))
            after = json.loads(urllib.request.urlopen(base + "/api/status").read())
            self.assertEqual(after["mode"], "boot")
        finally:
            server.shutdown()
            server.server_close()

    def test_nsp_main_return_marks_exact_resource_transfer_complete(self):
        import hashlib
        device, payload, _ = self.sandbox_device()
        package = device.sandbox.package
        candidate = package.with_name("ic7-2.36-test-experimental.nex")
        package.rename(candidate)
        component = b"import QtQuick 2.9\nItem { objectName: 'sandbox' }"
        candidate.with_name("HalImage.qml").write_bytes(component)
        report = {"label": "test", "packages": {candidate.name: {
            "sha256": hashlib.sha256(candidate.read_bytes()).hexdigest()}},
            "replacement_component_sha256": hashlib.sha256(component).hexdigest()}
        candidate.with_name("build-report.json").write_text(json.dumps(report))
        device = Device(Path(__file__).resolve().parents[1] / "device-profile.zip",
                        self.root / "main-return-state", sandbox_package=candidate)
        device.respond(request(1, 1, 0, 2, b"\0\x01"))
        for sequence, offset in enumerate(range(0, len(payload), 16), 2):
            fragment = payload[offset:offset + 16]
            response = device.respond(request(1, sequence % 256, 0x25000000 + offset,
                                              len(fragment), fragment))
            self.assertFalse(response[0] & 0x80)
        self.assertEqual(device.sandbox.status, "received")
        device.respond(request(1, 253, 0, 2, b"\0\0"))
        self.assertEqual(device.sandbox.status, "transfer-complete")
        self.assertTrue(device.sandbox.main_returned)
        self.assertTrue(device.sandbox.component_active)
        self.assertEqual((device.state / "sandbox/received-resource.enc").read_bytes(), payload)
        summary = device.sandbox.summary()
        self.assertIn("target install unverified", summary["verification"])
        self.assertEqual(device.memory.read(0, 1024)[8], 21)
        self.assertFalse(device.boot_mode)
        device.save()
        session = json.loads((device.state / "session.json").read_text())
        self.assertEqual(session["sandbox_update"]["status"], "transfer-complete")
        self.assertFalse(session["firmware_execution"])

    def test_sandbox_update_activates_only_a_hash_matched_sidecar_after_reboot(self):
        import hashlib
        device, payload, finish = self.sandbox_device()
        package = device.sandbox.package
        candidate = package.with_name("ic7-2.36-test-experimental.nex")
        package.rename(candidate)
        component = b"import QtQuick 2.9\nItem { objectName: 'sandbox' }"
        candidate.with_name("HalImage.qml").write_bytes(component)
        report = {"label": "test", "packages": {candidate.name: {
            "sha256": hashlib.sha256(candidate.read_bytes()).hexdigest()}},
            "replacement_component_sha256": hashlib.sha256(component).hexdigest()}
        candidate.with_name("build-report.json").write_text(json.dumps(report))
        device = Device(Path(__file__).resolve().parents[1] / "device-profile.zip",
                        self.root / "activation-state", sandbox_package=candidate)
        self.assertEqual(device.sandbox.component, component)
        device.respond(request(1, 1, 0, 2, b"\0\0"))
        self.assertFalse(device.sandbox.component_active)
        device.respond(request(1, 2, 0, 2, b"\0\x01"))
        device.respond(request(1, 3, 0x25000000, len(payload), payload))
        device.respond(request(1, 4, 0, len(finish), finish))
        self.assertFalse(device.sandbox.component_active)
        device.respond(request(1, 5, 0, 2, b"\0\0"))
        self.assertTrue(device.sandbox.component_active)
        server = start_viewer(device, 0)
        try:
            base = f"http://127.0.0.1:{server.server_port}"
            self.assertEqual(urllib.request.urlopen(base + "/api/component").read(), component)
            changes = json.loads(urllib.request.urlopen(base + "/api/changes").read())
            self.assertEqual(changes["component_sha256"], hashlib.sha256(component).hexdigest())
        finally:
            server.shutdown()
            server.server_close()
        candidate.with_name("HalImage.qml").write_bytes(b"changed")
        restored = Device(Path(__file__).resolve().parents[1] / "device-profile.zip",
                          self.root / "mismatched-state", sandbox_package=candidate)
        self.assertIsNone(restored.sandbox.component)
        candidate.with_name("HalImage.qml").write_bytes(component)
        stock = candidate.with_name("ic7-2.36-stock-resources-experimental.nex")
        candidate.rename(stock)
        report["packages"][stock.name] = report["packages"].pop(candidate.name)
        stock.with_name("build-report.json").write_text(json.dumps(report))
        rollback = Device(Path(__file__).resolve().parents[1] / "device-profile.zip",
                          self.root / "rollback-state", sandbox_package=stock)
        self.assertIsNone(rollback.sandbox.component)

    def test_sandbox_update_rejects_wrong_completion_metadata(self):
        device, payload, finish = self.sandbox_device()
        device.respond(request(1, 1, 0, 2, b"\0\x01"))
        device.respond(request(1, 2, 0x25000000, len(payload), payload))
        for offset in (4, 20, 24):
            wrong = bytearray(finish)
            wrong[offset] ^= 1
            response = device.respond(request(1, 3, 0, len(wrong), bytes(wrong)))
            self.assertTrue(response[0] & 0x80)
            self.assertNotEqual(device.sandbox.status, "verified")
        response = device.respond(request(1, 4, 0, len(finish), finish))
        self.assertFalse(response[0] & 0x80)
        self.assertEqual(device.sandbox.status, "verified")

    def test_sandbox_update_without_expected_package_cannot_verify(self):
        self.device.respond(request(1, 1, 0, 2, b"\0\x01"))
        finish = b"\0\x04\0\0" + bytes(16) + struct.pack(">II", 0x25000000, 16)
        response = self.device.respond(request(1, 2, 0, len(finish), finish))
        self.assertTrue(response[0] & 0x80)

    def test_sandbox_rejects_resource_package_without_map_migration_hdef(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            wrapped = struct.pack("<II4sIIII", 2, 0, bytes(4), 0x25000000, 128, 16384, 4000) + bytes(16) + bytes(16)
            package = root / "old-resource-only.nex"
            manifest = ('<NEX_FILE><PRODUCT pid="21" vid="11">'
                        '<FILE name="res_ic-7.qzip" /></PRODUCT></NEX_FILE>')
            with zipfile.ZipFile(package, "w") as archive:
                archive.writestr("manifest.xml", manifest)
                archive.writestr("res_ic-7.qzip", wrapped)
            with self.assertRaisesRegex(ValueError, "hdefFile required for NSP map migration"):
                UpdateSandbox(package, root / "state")

    def test_resource_query_returns_inline_reply_like_nsp(self):
        query = request(1, 152, 0x70000000, 2, b"\x01\0")
        response = self.device.respond(query)
        self.assertEqual(len(response), 19)
        self.assertEqual(response[:12], query[:12])
        self.assertEqual(response[12], 0)
        count = int.from_bytes(response[13:15], "big")
        self.assertEqual(count, sum(kind == 0 for kind, _ in self.device.resources.items))
        self.assertEqual(zlib.crc32(response[:-4]), int.from_bytes(response[-4:], "big"))
        listing = request(1, 153, 0x70000000, 6, b"\x02\0\0\0\0\1")
        listed = self.device.respond(listing)
        self.assertEqual(len(listed), 16 + 1 + 2 * 60)
        self.assertEqual(listed[:12], listing[:12])
        self.assertEqual(listed[12], 0)

    def test_nsp_resource_listing_and_image_read(self):
        images = sorted((name, data) for (kind, name), data in self.device.resources.items.items() if kind == 0)
        name, image = min(images, key=lambda item: len(item[1]))
        index = next(position for position, entry in enumerate(images) if entry[0] == name)
        listing = request(1, 21, 0x70000000, 6, b"\x02\0" + struct.pack(">HH", index, index))
        listed = self.device.respond(listing)
        descriptor = listed[13:73]
        self.assertEqual(descriptor, resource_descriptor(name, 0, image))

        command = b"\x03\0\0\0" + descriptor + struct.pack(">II", 0, len(image))
        response = self.device.respond(request(1, 22, 0x70000000, len(command), command))
        self.assertEqual(response[12:16], bytes(4))
        self.assertEqual(response[16:-4], image)
        self.assertEqual(zlib.crc32(response[:-4]), int.from_bytes(response[-4:], "big"))

    def test_raw_capture_records_resource_and_firmware_stage_packets(self):
        capture_path = self.root / "protocol.jsonl"
        device = Device(Path(__file__).resolve().parents[1] / "device-profile.zip",
                        self.root / "capture-state", capture_path=capture_path)
        resource_request = request(1, 41, 0x70000000, 2, b"\x01\0")
        resource_response = device.respond(resource_request)
        stage_request = request(1, 42, 0x25000000, 4, b"data")
        stage_response = device.respond(stage_request)
        device.close()

        records = [json.loads(line) for line in capture_path.read_text(encoding="utf-8").splitlines()]
        self.assertEqual(records[0]["event"], "capture_started")
        self.assertTrue(records[0]["raw_packets"])
        self.assertEqual(records[1]["region"], "resource_rpc")
        self.assertEqual(records[1]["resource_operation"], 1)
        self.assertEqual(records[1]["resource_status"], 0)
        self.assertEqual(base64.b64decode(records[1]["request_b64"]), resource_request)
        self.assertEqual(base64.b64decode(records[1]["response_b64"]), resource_response)
        self.assertEqual(records[2]["region"], "resource_update_stage")
        self.assertEqual(base64.b64decode(records[2]["request_b64"]), stage_request)
        self.assertEqual(base64.b64decode(records[2]["response_b64"]), stage_response)

    def test_metadata_only_capture_omits_packet_bytes(self):
        capture_path = self.root / "metadata.jsonl"
        device = Device(Path(__file__).resolve().parents[1] / "device-profile.zip",
                        self.root / "metadata-state", capture_path=capture_path,
                        capture_payloads=False)
        device.respond(request(2, 43, 0, 16))
        device.close()
        records = [json.loads(line) for line in capture_path.read_text(encoding="utf-8").splitlines()]
        self.assertFalse(records[0]["raw_packets"])
        self.assertNotIn("request_b64", records[1])
        self.assertNotIn("response_b64", records[1])

    def test_capture_preserves_fragmented_and_unparsed_transport_bytes(self):
        capture_path = self.root / "wire.jsonl"
        device = Device(Path(__file__).resolve().parents[1] / "device-profile.zip",
                        self.root / "wire-state", capture_path=capture_path)
        packet = request(2, 44, 0, 32)
        chunks = iter((b"bad", packet[:5], packet[5:], b""))
        responses = []
        serve_stream(device, lambda: next(chunks), responses.append)
        device.close()

        records = [json.loads(line) for line in capture_path.read_text(encoding="utf-8").splitlines()]
        received = b"".join(base64.b64decode(event["data_b64"]) for event in records
                            if event["event"] == "transport_chunk" and event["direction"] == "rx")
        sent = b"".join(base64.b64decode(event["data_b64"]) for event in records
                         if event["event"] == "transport_chunk" and event["direction"] == "tx")
        parsed = next(event for event in records if event["event"] == "packet")
        self.assertEqual(received, b"bad" + packet)
        self.assertEqual(sent, responses[0])
        self.assertTrue(parsed["response_crc_valid"])
        self.assertEqual(records[-1]["event"], "capture_stopped")
        self.assertEqual(records[-1]["packets"], 1)

    def test_mp4_resource_is_served_for_emulator_preview(self):
        payload = bytes.fromhex("000000186674797069736f6d") + b"mp42\0\0\0\0"
        self.device.resources.put("u/video.mp4", 0, payload)
        self.device.resources.put("u/ic7_video_probe.png", 0, payload)
        server = start_viewer(self.device, 0)
        try:
            for name in ("u/video.mp4", "u/ic7_video_probe.png"):
                url = f"http://127.0.0.1:{server.server_port}/asset?name=" + urllib.parse.quote(name)
                with urllib.request.urlopen(url) as response:
                    self.assertEqual(response.headers.get_content_type(), "video/mp4")
                    self.assertEqual(response.read(), payload)
        finally:
            server.shutdown()
            server.server_close()

    def test_renderer_resource_fetch_is_captured(self):
        import hashlib
        payload = b"GIF89a-renderer-fixture"
        self.device.resources.put("u/probe.gif", 0, payload)
        capture_path = self.root / "renderer-resource.jsonl"
        self.device.capture = ProtocolCapture(capture_path)
        server = start_viewer(self.device, 0)
        try:
            url = f"http://127.0.0.1:{server.server_port}/api/resource?kind=0&name=u%2Fprobe.gif"
            with urllib.request.urlopen(url) as response:
                self.assertEqual(response.status, 200)
                self.assertEqual(response.read(), payload)
        finally:
            server.shutdown()
            server.server_close()
            self.device.close()

        records = [json.loads(line) for line in capture_path.read_text(encoding="utf-8").splitlines()]
        event = next(record for record in records if record["event"] == "viewer_resource")
        self.assertEqual(event["source"], "renderer_resource_api")
        self.assertEqual(event["name"], "u/probe.gif")
        self.assertEqual(event["kind"], 0)
        self.assertEqual(event["status"], 200)
        self.assertEqual(event["bytes"], len(payload))
        self.assertEqual(event["sha256"], hashlib.sha256(payload).hexdigest())
        self.assertEqual(base64.b64decode(event["payload_b64"]), payload)

    def test_resource_read_error_still_matches_expected_reply_length(self):
        descriptor = resource_descriptor("u/missing.png", 0, bytes(20))
        payload = b"\x03\0\0\0" + descriptor + struct.pack(">II", 0, 20)
        response = self.device.respond(request(1, 1, 0x70000000, len(payload), payload))
        self.assertEqual(len(response), 16 + 4 + 20)
        self.assertEqual(response[12], 1)

    def test_cancelled_image_response_does_not_send_second_response(self):
        server = start_viewer(self.device, 0)
        try:
            for phase in ("headers", "body"):
                with self.subTest(phase=phase):
                    handler = server.RequestHandlerClass.__new__(server.RequestHandlerClass)
                    handler.path = "/layout.png?screen=0"
                    handler.send_response = Mock()
                    handler.send_header = Mock()
                    handler.end_headers = Mock()
                    handler.wfile = Mock()
                    failure = ConnectionAbortedError(10053, "Browser cancelled request")
                    if phase == "headers":
                        handler.end_headers.side_effect = failure
                    else:
                        handler.wfile.write.side_effect = failure
                    handler.do_GET()
                    handler.send_response.assert_called_once_with(200)
                    self.assertTrue(handler.close_connection)
        finally:
            server.shutdown()
            server.server_close()

    def test_invalid_image_request_still_returns_error(self):
        server = start_viewer(self.device, 0)
        try:
            handler = server.RequestHandlerClass.__new__(server.RequestHandlerClass)
            handler.path = "/layout.png?screen=invalid"
            handler.send = Mock()
            handler.do_GET()
            handler.send.assert_called_once_with(b"Invalid image request", "text/plain", 400)
        finally:
            server.shutdown()
            server.server_close()

    def test_uploaded_bitmap_reaches_viewer(self):
        from PIL import Image
        image = Image.new("RGB", (800, 480), (26, 140, 80))
        encoded = io.BytesIO()
        image.save(encoded, format="BMP")
        payload = encoded.getvalue()
        for offset in range(0, len(payload), 4096):
            fragment = payload[offset:offset + 4096]
            self.device.respond(request(1, offset // 4096 % 256, 0x70400000 + offset, len(fragment), fragment))
        self.assertEqual(self.device.last_screen, payload)
        server = start_viewer(self.device, 0)
        try:
            base = f"http://127.0.0.1:{server.server_port}"
            with Image.open(io.BytesIO(urllib.request.urlopen(base + "/received.png").read())) as received:
                self.assertEqual(received.size, (800, 480))
                self.assertEqual(received.getpixel((100, 100)), (26, 140, 80))
            status = json.load(urllib.request.urlopen(base + "/api/status"))
            self.assertTrue(status["received_screen"])
        finally:
            server.shutdown()
            server.server_close()

    def test_socket_transport_fragmentation(self):
        import socket
        server_socket, client = socket.socketpair()
        client.settimeout(3)
        worker = threading.Thread(target=lambda: serve_stream(self.device, lambda: server_socket.recv(65536), server_socket.sendall))
        worker.start()
        try:
            packet = request(2, 11, 0, 1024)
            client.sendall(packet[:5])
            client.sendall(packet[5:])
            response = bytearray()
            while len(response) < 1040:
                response.extend(client.recv(1040 - len(response)))
            self.assertEqual(response[:12], packet[:12])
            self.assertEqual(response[12:15], bytes((2, 36, 0)))
        finally:
            client.close()
            worker.join(timeout=3)
            server_socket.close()
        self.assertFalse(worker.is_alive())

    def test_protocol_settings_writes_update_scene_and_pixels(self):
        schema = json.loads((Path(__file__).resolve().parents[1] / "viewer-schema.json").read_text())
        component = next(item for item in schema["components"] if item["screen"] == 0 and item["component"] == 0)
        fields = component["fields"]
        before = render_layout(self.device, 0).tobytes()
        changes = {"GAUGE_TYPE": 2, "X_POS": 23, "Y_POS": 31, "X_SIZE": 320,
                   "Y_SIZE": 160, "DAY_OPACITY": 1000, "IMAGE_SRC": "u/ic7_static_probe.png",
                   "LABEL_TEXT": "LIVE UPDATE"}
        for sequence, (name, value) in enumerate(changes.items()):
            field = fields[name]
            payload = value.encode().ljust(field["bytes"], b"\0") if isinstance(value, str) else value.to_bytes(field["bytes"], "little", signed=field["signed"])
            self.device.respond(request(1, sequence, 0x20000 + field["address"], len(payload), payload))
        updated = scene_state(self.device, 0)
        actual = next(item["values"] for item in updated["components"] if item["index"] == 0)
        for name, value in changes.items():
            self.assertEqual(actual[name], value)
        self.assertEqual(updated["revision"][0], len(changes))
        self.assertNotEqual(before, render_layout(self.device, 0).tobytes())


if __name__ == "__main__":
    unittest.main()