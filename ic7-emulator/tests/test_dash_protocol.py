"""Real-dash protocol behaviour, from the USB captures and id_and_command_space_write."""
from pathlib import Path
import struct
import sys
import tempfile
import unittest

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
from ic7_emulator import DashTiming, Device, SPLASH_RESOURCE, request, resource_descriptor, serve_stream

PROFILE = Path(__file__).resolve().parents[1] / "device-profile.zip"


class DashProtocolFidelityTests(unittest.TestCase):
    def setUp(self):
        self.temporary = tempfile.TemporaryDirectory()
        self.now = [100.0]
        self.device = Device(PROFILE, Path(self.temporary.name), clock=lambda: self.now[0])

    def tearDown(self):
        self.temporary.cleanup()

    def test_update_mode_switches_are_refused_and_the_install_reboot_is_silent(self):
        self.device.map_loaded = True
        self.device.resources.put("u/clip.gif", 0, b"GIF89a")
        self.device.resources.put(SPLASH_RESOURCE, 0, b'{"version":1,"source":"u/clip.gif","durationMs":3000}')
        entered = self.device.respond(request(1, 1, 0, 2, b"\0\x01"))
        self.assertEqual(entered[0], 0x81)
        self.assertTrue(self.device.boot_mode)
        self.assertEqual(self.device.respond(request(2, 2, 0, 1024))[12 + 9], 1)
        left = self.device.respond(request(1, 3, 0, 2, b"\0\0"))
        self.assertEqual(left[0], 0x81)
        self.assertFalse(self.device.boot_mode)
        self.assertEqual(self.device.display_state()["phase"], "blank")
        self.now[0] += 24.9
        self.assertIsNone(self.device.respond(request(2, 4, 0, 1024)))
        self.now[0] += 0.2
        answer = self.device.respond(request(2, 5, 0, 1024))
        self.assertEqual(answer[12 + 9], 11)
        self.assertEqual(self.device.display_state()["phase"], "splash")
        self.assertEqual(self.device.protocol_events[-1]["reason"], "resource update install and reboot")

    def test_normal_mode_reboot_command_is_unanswered_and_restarts_the_application(self):
        self.assertIsNone(self.device.respond(request(1, 1, 0, 2, b"\0\0")))
        self.now[0] += 1.9
        self.assertIsNone(self.device.respond(request(2, 2, 0, 4)))
        self.now[0] += 0.8
        self.assertIsNotNone(self.device.respond(request(2, 3, 0, 4)))
        self.assertEqual(self.device.reboot_revision, 1)

    def test_static_splash_bmp_reports_kernel_logo_patch_then_full_reboot(self):
        poll = request(1, 1, 0, 4, b"\0\x0f\0\0")
        idle = self.device.respond(poll)
        self.assertEqual(idle[0], 0x81)
        header = b"BM" + struct.pack("<I", 1152054) + bytes(1152048)
        for offset in range(0, len(header), 4096):
            fragment = header[offset:offset + 4096]
            self.assertEqual(self.device.respond(request(1, 2, 0x70400000 + offset, len(fragment), fragment))[0], 1)
        busy = self.device.respond(poll)
        self.assertEqual(len(busy), 20)
        self.assertEqual(busy[12:16], b"\x02\0\0\0")
        self.now[0] += DashTiming().logo_patch
        done = self.device.respond(poll)
        self.assertEqual(done[12:16], b"\0\0\0\0")
        self.assertIsNone(self.device.respond(request(1, 3, 0, 2, b"\0\0")))
        self.assertIn("kernel logo", self.device.quiet_reason)
        self.now[0] += 12.9
        self.assertIsNone(self.device.respond(request(2, 4, 0, 4)))
        self.now[0] += 0.2
        self.assertIsNotNone(self.device.respond(request(2, 5, 0, 4)))
        self.assertEqual(self.device.respond(poll)[0], 0x81)

    def test_user_index_lists_every_upload_in_write_order(self):
        for kind, name in [key for key in self.device.resources.items if key[1].startswith("u/")]:
            deleted = self.device.resources.command(
                b"\x05\0\0\0" + resource_descriptor(name, kind, self.device.resources.items[(kind, name)]))
            self.assertEqual(deleted, b"\0")
        for name in ("u/zz.png", "u/clip.gif", "u/ic7_splash.json", "u/drive.mp4", "u/aa.png"):
            self.device.resources.put(name, 0, name.encode())
        self.device.resources.put("u/eurostile.TTF", 1, b"font")
        count = self.device.respond(request(1, 1, 0x70000000, 2, b"\x01\0"))
        self.assertEqual(int.from_bytes(count[13:15], "big"), 5)
        listed = self.device.respond(request(1, 2, 0x70000000, 6, b"\x02\0\0\0\0\x04"))
        names = [listed[13 + offset:13 + offset + 50].split(b"\0", 1)[0].decode() for offset in range(0, 300, 60)]
        self.assertEqual(names, ["u/zz.png", "u/clip.gif", "u/ic7_splash.json", "u/drive.mp4", "u/aa.png"])
        fonts = self.device.respond(request(1, 3, 0x70000000, 2, b"\x01\x01"))
        self.assertEqual(int.from_bytes(fonts[13:15], "big"), 1)
        restored = Device(PROFILE, Path(self.temporary.name))
        self.assertEqual([name for name, _ in restored.resources.index(0)], names)

    def test_unanswered_requests_write_nothing_to_the_port(self):
        written = []
        chunks = [request(1, 1, 0, 2, b"\0\0"), request(2, 2, 0, 4), b""]
        serve_stream(self.device, lambda: chunks.pop(0), written.append)
        self.assertEqual(written, [])

    def test_legacy_acknowledgements_remain_available_for_diagnosis(self):
        device = Device(PROFILE, Path(self.temporary.name) / "legacy", legacy_acks=True, clock=lambda: self.now[0])
        self.assertEqual(device.respond(request(1, 1, 0, 2, b"\0\x01"))[0], 1)
        self.assertEqual(device.respond(request(1, 2, 0, 2, b"\0\0"))[0], 1)
        self.assertEqual(device.respond(request(1, 3, 0, 2, b"\0\0"))[0], 1)


if __name__ == "__main__":
    unittest.main()
