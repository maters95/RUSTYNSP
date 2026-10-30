import json
import os
from pathlib import Path
import shutil
import subprocess
import sys
import tempfile
import unittest

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
from stock_renderer import install_startup_qml


class StartupQmlTests(unittest.TestCase):
    def test_synthetic_alert_preview_over_http_renders_selected_gif(self):
        from PIL import Image
        from ic7_emulator import ALERT_RESOURCE, Device
        from viewer import start_viewer

        root = Path(__file__).resolve().parents[1]
        with tempfile.TemporaryDirectory(prefix="ic7-alert-preview-") as directory:
            path = Path(directory)
            image = path / "alert.gif"
            Image.new("RGB", (32, 20), "red").save(
                image, save_all=True, append_images=[Image.new("RGB", (32, 20), "green")],
                duration=120, loop=0)
            device = Device(root / "device-profile.zip", path / "state")
            device.map_loaded = True
            device.resources.put("u/alert.gif", 0, image.read_bytes())
            server = start_viewer(device, 0)
            try:
                screenshot = path / "preview.png"
                environment = os.environ.copy()
                environment.update(QT_QPA_PLATFORM="offscreen", QT_QUICK_BACKEND="software",
                                   QML_DISABLE_DISK_CACHE="1")
                baseline = subprocess.run([
                    sys.executable, str(root / "native_view.py"),
                    "--url", "http://127.0.0.1:" + str(server.server_port),
                    "--screenshot", str(screenshot)
                ], env=environment, capture_output=True, text=True, timeout=30)
                self.assertEqual(baseline.returncode, 0, baseline.stdout + baseline.stderr)
                with Image.open(screenshot) as captured:
                    background = captured.convert("RGB").getpixel((400, 60))
                for screens in (None, [1], [5]):
                    with self.subTest(screens=screens):
                        banner = {"text": "TEST ALERT", "source": "u/alert.gif",
                                  "x": 0, "y": 0, "width": 860, "height": 120}
                        if screens is not None:
                            banner["screens"] = screens
                        device.resources.put(ALERT_RESOURCE, 0, json.dumps({
                            "version": 1, "banners": [banner]}).encode())
                        result = subprocess.run([
                            sys.executable, str(root / "native_view.py"),
                            "--url", "http://127.0.0.1:" + str(server.server_port),
                            "--preview-alert", "TEST ALERT", "--screenshot", str(screenshot)
                        ], env=environment, capture_output=True, text=True, timeout=30)
                        self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
                        self.assertNotIn("failed to load", result.stderr.lower())
                        with Image.open(screenshot) as captured:
                            red, green, blue = captured.convert("RGB").getpixel((400, 60))
                            if screens == [5]:
                                self.assertEqual((red, green, blue), background)
                            else:
                                self.assertTrue((red > 180 and green < 100 and blue < 100) or
                                                (green > 80 and red < 100 and blue < 100),
                                                f"Selected GIF pixel not rendered: {(red, green, blue)}\n{result.stderr}")
            finally:
                server.shutdown()
                server.server_close()

    def test_staged_shared_media_replays_gif_and_mp4(self):
        from PIL import Image

        root = Path(__file__).resolve().parents[2]
        with tempfile.TemporaryDirectory(prefix="ic7-startup-qml-") as directory:
            path = Path(directory)
            for name in ("gif", "mp4"):
                runtime = path / name
                for folder in ("factory_screens", "user_components"):
                    (runtime / "qml_components_data/qml" / folder).mkdir(parents=True)
                targets = install_startup_qml(runtime)
                for target in targets:
                    self.assertEqual(target.read_bytes(),
                                     (root / "ic7-custom-dash/deploy/nsp" / target.name).read_bytes())
                images = runtime / "user_resources/images"
                images.mkdir(parents=True)
                if name == "gif":
                    Image.new("RGB", (32, 20), "red").save(
                        images / "clip.gif", save_all=True,
                        append_images=[Image.new("RGB", (32, 20), "green")], duration=120, loop=0)
                else:
                    subprocess.run([
                        "ffmpeg", "-nostdin", "-hide_banner", "-loglevel", "error", "-y",
                        "-f", "lavfi", "-i", "testsrc2=size=160x90:rate=15", "-t", "2",
                        "-an", "-c:v", "libx264", "-pix_fmt", "yuv420p",
                        str(images / "clip.mp4")], check=True, timeout=30)
                (images / "ic7_splash.json").write_text(json.dumps({
                    "version": 1, "source": "u/clip." + name, "durationMs": 2500}))
            template = """
import QtQuick 2.9
import QtTest 1.0
Item {
    id: testWindow
    width: 860
    height: 480
    TestCase {
        name: "EmulatorStagedStartup"
        when: windowShown
        function test_media_data() {
            return [{tag:"gif", url:GIF_URL, object:"animatedImage"},
                    {tag:"mp4", url:MP4_URL, object:"videoPlayer"}];
        }
        function test_media(data) {
            var component = Qt.createComponent(data.url);
            compare(component.status, Component.Ready, component.errorString());
            for (var boot = 0; boot < 2; boot++) {
                var root = component.createObject(testWindow);
                verify(root !== null);
                var loader = findChild(root, "startupSplashLoader");
                tryVerify(function() { return loader.item !== null && loader.item.visible; });
                var player = findChild(root, data.object);
                verify(player !== null);
                if (data.tag === "gif") {
                    tryCompare(player, "status", Image.Ready);
                    var frame = player.currentFrame;
                    tryVerify(function() { return player.currentFrame !== frame; });
                } else {
                    tryVerify(function() { return player.position > 0; }, 2000);
                    compare(player.muted, true);
                }
                tryCompare(loader, "active", false, 3500);
                compare(loader.item, null);
                root.destroy();
                wait(1);
            }
        }
    }
}
"""
            for name in ("gif", "mp4"):
                url = (path / name / "qml_components_data/qml/factory_screens/main.qml").as_uri()
                template = template.replace(name.upper() + "_URL", json.dumps(url))
            test = path / "tst_Startup.qml"
            test.write_text(template)
            environment = os.environ.copy()
            environment.update(QT_QPA_PLATFORM="offscreen", QT_QUICK_BACKEND="software",
                               QML_DISABLE_DISK_CACHE="1")
            runner = shutil.which("qmltestrunner")
            self.assertIsNotNone(runner, "qmltestrunner is required for startup-media validation")
            result = subprocess.run([runner, "-input", str(test), "-o", "-,txt"],
                                    env=environment, capture_output=True, text=True, timeout=45)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn("4 passed, 0 failed", result.stdout)


if __name__ == "__main__":
    unittest.main()
