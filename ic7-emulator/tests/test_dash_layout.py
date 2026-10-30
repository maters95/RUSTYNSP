import hashlib
import json
import os
from pathlib import Path
import shutil
import subprocess
import sys
import tempfile
import unittest
from unittest.mock import patch
import zipfile

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
import dash_layout
from ic7_emulator import Device, INSTANT_TIMING, request
import stock_renderer
from viewer import start_viewer

REPOSITORY = Path(__file__).resolve().parents[2]
PROFILE = Path(__file__).resolve().parents[1] / "device-profile.zip"
# 7d3f8c96: the NEX that failed on the dash (splash/alarm QML looked three folders up).
FAILED_NEX = REPOSITORY / "ic7-custom-dash/build-cfw-screen-alarms-236/ic7-2.36-screen-alarms-experimental.nex"
# 3f6d26f1: the current r2/r3 kit NEX, which detects the dash tree and looks four folders up.
CURRENT_NEX = REPOSITORY / "ic7-custom-dash/build-cfw-screen-alarms-freshmtime-236/ic7-2.36-screen-alarms-experimental.nex"
CURRENT_SHA256 = "3f6d26f1505180a1f2f238020ae71b65bc5ca8a276fcb5fa165b8702ca919838"
ADDON_NEX = REPOSITORY / "ic7-custom-dash/build-addons-experimental-236/ic7-2.36-addons-experimental.nex"


def nex_members(package):
    with zipfile.ZipFile(package) as archive:
        wrapped = archive.read("res_ic-7.qzip")
    return dash_layout.decode_stage(wrapped[44:], dash_layout.find_watchdog())[1]


def gif_bytes(path):
    from PIL import Image
    Image.new("RGB", (32, 20), "red").save(path, save_all=True,
                                           append_images=[Image.new("RGB", (32, 20), "green")],
                                           duration=120, loop=0)
    return path.read_bytes()


def upload(work, name, payload, kind=0):
    """Place an upload exactly as the bridge does for dash_virtual."""
    namespace, _, relative = name.partition("/")
    for target in stock_renderer._resource_targets(work, kind, namespace, relative):
        target.parent.mkdir(parents=True, exist_ok=True)
        target.write_bytes(payload)


def push_nex(device, package):
    with zipfile.ZipFile(package) as archive:
        payload = archive.read("res_ic-7.qzip")[44:]
    device.respond(request(1, 1, 0, 2, b"\0\x01"))
    for sequence, offset in enumerate(range(0, len(payload), 4096), 2):
        fragment = payload[offset:offset + 4096]
        response = device.respond(request(1, sequence % 256, 0x25000000 + offset, len(fragment), fragment))
        assert not response[0] & 0x80, "the emulator refused a byte-exact NEX block"
    return device.respond(request(1, 0, 0, 2, b"\0\0"))


@unittest.skipUnless(dash_layout.find_watchdog() and FAILED_NEX.is_file() and CURRENT_NEX.is_file(),
                     "dash watchdog reference and NEX builds are required")
class DashLayoutTests(unittest.TestCase):
    def test_tree_paths_match_the_dash_and_dash_virtual(self):
        name = "qml_components_data/qml/user_components/HalSplash.qml"
        self.assertEqual(dash_layout.resolve_user_folder(name, "../../../../"),
                         "/opt/applications/dtn/user_resources/images")
        self.assertEqual(dash_layout.resolve_user_folder(name, "../../../"),
                         "/opt/applications/dtn/resources/user_resources/images")
        # dash_virtual.exe's own literals: ./user_resources and 3 levels up, relative to its cwd.
        renderer = (REPOSITORY / "reference/stock-dash-extract/dash_virtual.exe").read_bytes()
        self.assertIn(b"../../../user_resources/images/", renderer)
        self.assertNotIn(b"../../../../user_resources/images/", renderer)
        self.assertIn(b"./user_resources/fonts/", renderer)
        self.assertTrue(dash_layout.is_manifest("ic7_splash.json"))
        self.assertTrue(dash_layout.is_manifest("ic7_gauge_fx.json"))
        self.assertFalse(dash_layout.is_manifest("ic7_screen_1.png"))

    def test_install_wipes_and_keeps_archived_mtimes(self):
        members = nex_members(CURRENT_NEX)
        with tempfile.TemporaryDirectory() as temporary:
            target = Path(temporary) / "dtn/resources"
            (target / "leftover").mkdir(parents=True)
            dash_layout.install_members(members, target)
            self.assertFalse((target / "leftover").exists())
            files = [member for member in members if member["type"] == "file"]
            self.assertEqual(len(files), sum(path.is_file() for path in target.rglob("*")))
            for member in files:
                path = target / member["name"]
                self.assertEqual(int(path.stat().st_mtime), member["mtime"], member["name"])
            splash = target / "qml_components_data/qml/user_components/HalSplash.qml"
            self.assertEqual(splash.read_bytes(), (REPOSITORY / "ic7-custom-dash/deploy/nsp/HalSplash.qml").read_bytes())

    def test_lookup_audit_explains_the_failed_nex(self):
        uploads = {"u/ic7_splash.json": json.dumps({"version": 1, "source": "u/clip.gif", "durationMs": 3000}).encode(),
                   "u/clip.gif": b"GIF89a",
                   "u/ic7_alerts.json": json.dumps({"version": 1, "banners": [
                       {"text": "TEST ALERT", "source": "u/missing.gif"}]}).encode()}
        failed = {entry["manifest"]: entry for entry in dash_layout.audit_user_lookups(nex_members(FAILED_NEX), uploads)}
        self.assertEqual(failed["ic7_splash.json"]["status"], "wrong-folder")
        self.assertIn("does not exist on the dash", failed["ic7_splash.json"]["reason"])
        self.assertEqual(failed["ic7_alerts.json"]["status"], "wrong-folder")
        current = {entry["manifest"]: entry for entry in dash_layout.audit_user_lookups(nex_members(CURRENT_NEX), uploads)}
        self.assertEqual(current["ic7_splash.json"]["status"], "ok")
        self.assertEqual(current["ic7_alerts.json"]["status"], "media-missing")
        self.assertEqual(current["ic7_alerts.json"]["missing_media"], ["u/missing.gif"])

    @unittest.skipUnless(shutil.which("qmltestrunner"), "qmltestrunner is required")
    def test_old_three_level_components_fail_and_current_ones_find_their_manifests(self):
        """Key acceptance test: the emulator fails the way the dash failed."""
        with tempfile.TemporaryDirectory(prefix="ic7-dash-layout-") as temporary:
            root = Path(temporary)
            clip = gif_bytes(root / "clip.gif")
            urls = {}
            for label, package in (("failed", FAILED_NEX), ("current", CURRENT_NEX)):
                work = root / label
                dash_layout.install_members(nex_members(package), stock_renderer.resources_root(work))
                upload(work, "u/clip.gif", clip)
                upload(work, "u/ic7_splash.json", json.dumps(
                    {"version": 1, "source": "u/clip.gif", "durationMs": 2500}).encode())
                upload(work, "u/ic7_alerts.json", json.dumps({"version": 1, "banners": [
                    {"text": "TEST ALERT", "source": "u/clip.gif", "x": 0, "y": 0, "width": 860, "height": 120}]}).encode())
                components = stock_renderer.resources_root(work) / "qml_components_data/qml/user_components"
                # The NSP-layout copy exists (dash_virtual needs it) but has no manifest.
                self.assertTrue((work / "dtn/resources/user_resources/images/clip.gif").is_file())
                self.assertFalse((work / "dtn/resources/user_resources/images/ic7_splash.json").exists())
                urls[label] = {name: (components / (name + ".qml")).as_uri()
                               for name in ("HalSplash", "HalAlarmPopup")}
            test = root / "tst_DashLayout.qml"
            test.write_text("""
import QtQuick 2.9
import QtTest 1.0
Item {
    id: window
    width: 860
    height: 480
    TestCase {
        name: "DashLayout"
        when: windowShown
        function test_splash_data() {
            return [{tag: "failed", url: %(failed_splash)s, found: false},
                    {tag: "current", url: %(current_splash)s, found: true}];
        }
        function test_splash(data) {
            var component = Qt.createComponent(data.url);
            compare(component.status, Component.Ready, component.errorString());
            var splash = component.createObject(window);
            splash.start();
            if (data.found) {
                tryVerify(function() { return splash.mediaPath !== ""; }, 2000);
                verify(splash.mediaPath.indexOf("/dtn/user_resources/images/clip.gif") >= 0, splash.mediaPath);
            } else {
                tryVerify(function() { return splash.completed; }, 2000);
                compare(splash.mediaPath, "");
            }
            splash.destroy();
        }
        function test_alarm_data() {
            return [{tag: "failed", url: %(failed_popup)s, found: false},
                    {tag: "current", url: %(current_popup)s, found: true}];
        }
        function test_alarm(data) {
            var component = Qt.createComponent(data.url);
            compare(component.status, Component.Ready, component.errorString());
            var popup = component.createObject(window);
            if (data.found) {
                tryVerify(function() { return popup.bannerConfig.length === 1; }, 3000);
                compare(popup.bannerConfig[0].text, "TEST ALERT");
            } else {
                wait(1500);
                compare(popup.bannerConfig.length, 0);
                compare(popup.loadedManifest, "");
            }
            popup.destroy();
        }
    }
}
""" % {"failed_splash": json.dumps(urls["failed"]["HalSplash"]),
       "current_splash": json.dumps(urls["current"]["HalSplash"]),
       "failed_popup": json.dumps(urls["failed"]["HalAlarmPopup"]),
       "current_popup": json.dumps(urls["current"]["HalAlarmPopup"])})
            environment = os.environ.copy()
            environment.update(QT_QPA_PLATFORM="offscreen", QT_QUICK_BACKEND="software",
                               QML_DISABLE_DISK_CACHE="1")
            result = subprocess.run([shutil.which("qmltestrunner"), "-input", str(test), "-o", "-,txt"],
                                    env=environment, capture_output=True, text=True, timeout=60)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn("6 passed, 0 failed", result.stdout)

    def test_current_kit_nex_is_accepted_and_installed_through_the_protocol(self):
        self.assertEqual(hashlib.sha256(CURRENT_NEX.read_bytes()).hexdigest(), CURRENT_SHA256)
        with tempfile.TemporaryDirectory() as temporary:
            device = Device(PROFILE, Path(temporary) / "state", sandbox_package=CURRENT_NEX, timing=INSTANT_TIMING)
            # The kit's sidecars are checked against the NEX members, not installed.
            self.assertEqual({check["name"] for check in device.sandbox.crosscheck},
                             {"HalImage.qml", "HalSplash.qml", "HalAlarmPopup.qml", "main.qml"})
            self.assertEqual(push_nex(device, CURRENT_NEX)[0], 0x81)
            self.assertEqual(device.sandbox.status, "transfer-complete")
            # 326 unchanged stock files, 3 changed QML and the added HalSplash.qml (audit-report.json).
            self.assertEqual(device.install["member_count"], 330)
            self.assertEqual(device.install["added"], ["qml_components_data/qml/user_components/HalSplash.qml"])
            self.assertEqual(device.install["mtimes"]["qml_components_data/qml/factory_screens/main.qml"], 1767313730)
            for member in nex_members(CURRENT_NEX):
                if member["type"] == "file":
                    self.assertEqual((device.resources_root / member["name"]).read_bytes(), member["data"])
            text = (device.state / "fidelity-report.txt").read_text()
            self.assertIn(device.install["payload_sha256"], text)
            self.assertIn(CURRENT_SHA256, text)

    @unittest.skipUnless(ADDON_NEX.is_file(), "the add-on NEX build is required")
    def test_addon_nex_installs_generically_into_the_renderer_tree(self):
        added = ["Ic7IndicatorAddon.qml", "Ic7GaugeFx.qml", "Ic7AddonMedia.qml", "Ic7AddonVideo.qml", "ic7addons.js"]
        replaced = ["HalIndicator.qml", "HalNumeric.qml", "HalBarHorizontal1.qml", "HalCircularClassic.qml"]
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            # Its build report is not the r2 kind and it has no sidecars: no cross-check, still accepted.
            device = Device(PROFILE, root / "state", sandbox_package=ADDON_NEX, timing=INSTANT_TIMING)
            self.assertEqual(device.sandbox.crosscheck, [])
            push_nex(device, ADDON_NEX)
            self.assertTrue(device.sandbox.installed)
            folder = "qml_components_data/qml/user_components/"
            self.assertEqual(set(device.install["added"]) - {folder + "HalSplash.qml"},
                             {folder + name for name in added})
            self.assertTrue({folder + name for name in replaced}.issubset(device.install["changed"]))
            server = start_viewer(device, 0)
            try:
                work = root / "renderer"
                stock_renderer.install_factory_resources(work)
                stock_renderer.install_dash_resources(f"http://127.0.0.1:{server.server_port}", work)
            finally:
                server.shutdown()
                server.server_close()
            for member in nex_members(ADDON_NEX):
                if member["type"] == "file":
                    path = stock_renderer.resources_root(work) / member["name"]
                    self.assertEqual(path.read_bytes(), member["data"], member["name"])
                    self.assertEqual(int(path.stat().st_mtime), member["mtime"])
            for name in added:
                self.assertTrue((stock_renderer.resources_root(work) / folder / name).is_file())
            report = json.loads((device.state / "fidelity-report.json").read_text())
            statuses = {(Path(entry["component"]).name, entry["manifest"]): entry["status"]
                        for entry in report["lookups"]}
            self.assertEqual(statuses[("Ic7IndicatorAddon.qml", "ic7_indicators.json")], "manifest-not-uploaded")
            self.assertEqual(statuses[("Ic7GaugeFx.qml", "ic7_gauge_fx.json")], "manifest-not-uploaded")

    def test_bridge_skips_manifests_in_the_three_level_copy_only(self):
        with tempfile.TemporaryDirectory() as temporary:
            work = Path(temporary)
            status = {"assets": [{"kind": 0, "name": "u/ic7_indicators.json", "sha256": "a"},
                                 {"kind": 0, "name": "u/ic7_screen_1.png", "sha256": "b"},
                                 {"kind": 1, "name": "u/impact.ttf", "sha256": "c"}]}
            with patch("stock_renderer.get", side_effect=[json.dumps(status).encode(), b"m", b"marker", b"font"]):
                stock_renderer.sync_resources("http://emulator", work, {})
            self.assertTrue((work / "dtn/user_resources/images/ic7_indicators.json").is_file())
            self.assertFalse((work / "dtn/resources/user_resources/images/ic7_indicators.json").exists())
            self.assertTrue((work / "dtn/resources/user_resources/images/ic7_screen_1.png").is_file())
            self.assertTrue((work / "dtn/user_resources/fonts/impact.ttf").is_file())
            self.assertTrue((work / "dtn/resources/user_resources/fonts/impact.ttf").is_file())


if __name__ == "__main__":
    unittest.main()
