import json
import hashlib
import http.server
import os
from pathlib import Path
import runpy
import shutil
import subprocess
import sys
import tempfile
import threading
import unittest
import zipfile


ROOT = Path(__file__).resolve().parents[2]
CANDIDATE = ROOT / "ic7-custom-dash/build-cfw-screen-alarms-device-paths-236"


class AlertMediaTests(unittest.TestCase):
    def test_native_refresh_reads_changed_file_at_same_path(self):
        runner = shutil.which("qmltestrunner")
        if runner is None:
            self.skipTest("Qt QML test runner is required")
        with tempfile.TemporaryDirectory(prefix="nsp-alert-live-") as directory:
            path = Path(directory)
            manifest = path / "alerts.json"
            banner = {"text": "OIL PRESSURE", "source": "", "x": 0, "y": 420,
                      "width": 860, "height": 60}
            manifest.write_text(json.dumps({"version": 1, "banners": [banner]}))

            class EditHandler(http.server.BaseHTTPRequestHandler):
                def do_POST(self):
                    if self.path not in ("/edit", "/reset"):
                        self.send_error(404)
                        return
                    changed = dict(banner, x=100, y=80, width=300, height=80)
                    staged = manifest.with_suffix(".tmp")
                    staged.write_text(json.dumps({
                        "version": 1, "banners": [changed] if self.path == "/edit" else []}))
                    staged.replace(manifest)
                    self.send_response(200)
                    self.end_headers()
                    self.wfile.write(b"ok")

                def log_message(self, *_):
                    pass

            server = http.server.ThreadingHTTPServer(("127.0.0.1", 0), EditHandler)
            worker = threading.Thread(target=server.serve_forever)
            worker.start()
            try:
                production = ROOT / "ic7-custom-dash/deploy/nsp/HalAlarmPopup.qml"
                (path / "tst_LiveResources.qml").write_text("""
import QtQuick 2.9
import QtTest 1.0
Item {
    id: window
    width: 860
    height: 480
    TestCase {
        name: "LiveAlarmResources"
        when: windowShown
        property var popup: null
        function edit(action) {
            var completed = false;
            var request = new XMLHttpRequest();
            request.onreadystatechange = function() {
                if (request.readyState === XMLHttpRequest.DONE)
                    completed = request.status === 200;
            };
            request.open("POST", "http://127.0.0.1:PORT/" + action);
            request.send();
            tryVerify(function() { return completed; });
        }
        function test_nativeRefreshWithoutReopeningOrRebooting() {
            var component = Qt.createComponent(PRODUCTION);
            compare(component.status, Component.Ready, component.errorString());
            popup = component.createObject(window, {manifestUrl: MANIFEST, halFontPath: ""});
            verify(popup !== null);
            tryVerify(function() { return popup.bannerConfig.length === 1; });
            var alarm = JSON.stringify([{text: "OIL PRESSURE", bc: "red", fc: "white", height: "60"}]);
            popup.reInitAlarmScreen(alarm);
            var original = findChild(popup, "alertBanner:OIL PRESSURE");
            compare(original.x, 0);
            edit("edit");
            popup.setGaugeProperties({});
            popup.repaintAll();
            tryCompare(original, "x", 100);
            compare(original.y, 80);
            compare(original.width, 300);
            compare(findChild(popup, "alertBanner:OIL PRESSURE"), original);
            edit("reset");
            popup.reInitAlarmScreen(alarm);
            tryCompare(original, "x", 0);
            compare(original.y, 420);
            compare(popup.activeAlarms.length, 1);
            popup.destroy();
        }
    }
}
""".replace("PRODUCTION", json.dumps(production.as_uri()))
                    .replace("MANIFEST", json.dumps(manifest.as_uri()))
                    .replace("PORT", str(server.server_port)))
                result = subprocess.run(
                    [runner, "-input", str(path), "-o", "-,txt"],
                    env={**os.environ, "QT_QPA_PLATFORM": "offscreen", "QT_QUICK_BACKEND": "software",
                         "QML_DISABLE_DISK_CACHE": "1"},
                    capture_output=True, text=True, timeout=30)
                self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
                self.assertIn("0 failed", result.stdout)
            finally:
                server.shutdown()
                worker.join(timeout=5)
                server.server_close()

    def test_alert_bundle_contains_matching_components_and_guide(self):
        nex = CANDIDATE / "ic7-2.36-screen-alarms-experimental.nex"
        if not nex.exists():
            self.skipTest("Build the alert candidate first")
        with tempfile.TemporaryDirectory(prefix="nsp-alert-package-") as directory:
            output = Path(directory) / "alerts.zip"
            command = [
                sys.executable, str(ROOT / "scripts/package-nsp-media-test.py"),
                "--nsp-dll", str(ROOT / "nsp-rebuild/bin/Release/net9.0-windows10.0.19041.0/NSP.dll"),
                "--media-nex", str(nex), "--build-report", str(CANDIDATE / "build-report.json"),
                "--native-media", "--splash", "--alerts", "--output", str(output),
            ]
            result = subprocess.run(command, capture_output=True, text=True, timeout=90)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            with zipfile.ZipFile(output) as archive:
                self.assertIsNone(archive.testzip())
                manifest = json.loads(archive.read("test-manifest.json"))
                self.assertTrue(manifest["alert_media"])
                self.assertTrue(manifest["startup_splash"])
                for entry in manifest["artifacts"]:
                    data = archive.read(entry["path"])
                    self.assertEqual(len(data), entry["bytes"])
                    self.assertEqual(hashlib.sha256(data).hexdigest(), entry["sha256"])
                self.assertEqual(archive.read("firmware/HalAlarmPopup.qml"),
                                 (ROOT / "ic7-custom-dash/deploy/nsp/HalAlarmPopup.qml").read_bytes())
                self.assertEqual(archive.read("README.md"),
                                 (ROOT / "ic7-custom-dash/deploy/nsp/ALERTS-TEST.md").read_bytes())

    def test_dll_exposes_alarm_page_entry_points(self):
        dll = ROOT / "nsp-rebuild/bin/Release/net9.0-windows10.0.19041.0/NSP.dll"
        if not dll.is_file():
            self.skipTest("Build NSP.dll first")
        data = dll.read_bytes()
        for text in ("Appearance...", "Alarm appearance...",
                     "ic7AlertBannerButton", "MP4 startup video", "Screens (All or 1, 3, 5)"):
            self.assertIn(text.encode("utf-16-le"), data, text)

    def test_manifest_validation_roundtrip(self):
        with tempfile.TemporaryDirectory(prefix="nsp-alerts-") as directory:
            path = Path(directory)
            (path / "Test.csproj").write_text(f"""
<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net9.0</TargetFramework></PropertyGroup>
<ItemGroup>
<Compile Include="{ROOT}/nsp-rebuild/NSP/AlertMedia.cs" />
<Compile Include="{ROOT}/nsp-rebuild/NSP/SplashMedia.cs" />
<Compile Include="{ROOT}/nsp-rebuild/NSP/MediaResource.cs" />
<Compile Include="{ROOT}/nsp-rebuild/NSP/AlarmScreenMarkers.cs" />
</ItemGroup></Project>
""")
            (path / "Program.cs").write_text("""
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using NSP;
var banners = new List<AlertBanner> {
    new AlertBanner { Text="OIL PRESSURE", Source="u/animation.gif", X=100, Y=80, Width=300, Height=80, GifOnly=true, MessageDataId=123, Screens=new[]{5} },
    new AlertBanner { Text="TEMP", Source="", X=0, Y=420, Width=860, Height=60 }
};
string target = Path.Combine(args[0], AlertMedia.ManifestName);
File.WriteAllBytes(target, AlertMedia.Serialize(banners));
var read = AlertMedia.Read(target);
if (read.Count != 2 || read[0].Text != "OIL PRESSURE" || read[0].X != 100 ||
    read[0].Y != 80 || read[0].Width != 300 || read[0].Height != 80 ||
    read[0].Source != "u/animation.gif" || read[1].Source != "" || !read[0].GifOnly || read[1].GifOnly ||
    read[0].MessageDataId != 123 || !read[0].Screens.SequenceEqual(new[]{5}) || read[1].Screens != null)
    throw new Exception("Manifest round trip");
if (!AlertMedia.RenameMessages(read, new Dictionary<int, string>{{123, "NEW OIL MESSAGE"}}) ||
    read[0].Text != "NEW OIL MESSAGE" || read[0].Source != banners[0].Source ||
    read[0].X != 100 || !read[0].GifOnly ||
    AlertMedia.RenameMessages(read, new Dictionary<int, string>{{123, "NEW OIL MESSAGE"}}) ||
    AlertMedia.RenameMessages(read, new Dictionary<int, string>{{999, "UNRELATED"}}))
    throw new Exception("Native alarm binding/undo must retain appearance");
if (!AlertMedia.RenameMessages(read, new Dictionary<int, string>{{123, "OIL PRESSURE"}}))
    throw new Exception("Message undo must restore the matching text");
read[1].MessageDataId = 456;
if (!AlertMedia.RenameMessages(read, new Dictionary<int, string>{{123, "TEMP"}, {456, "OIL PRESSURE"}}) ||
    read[0].Text != "TEMP" || read[1].Text != "OIL PRESSURE")
    throw new Exception("Multi-setting undo/redo must rebind the final state atomically");
foreach (AlertBanner invalid in new[] {
    new AlertBanner {Text=""}, new AlertBanner {Text="TEST", Source="u/../file.gif"},
    new AlertBanner {Text="TEST", Source="u/movie.mp4"},
    new AlertBanner {Text="TEST", X=-1}, new AlertBanner {Text="TEST", Y=421},
    new AlertBanner {Text="TEST", Width=861}, new AlertBanner {Text="TEST", Height=59},
    new AlertBanner {Text="TEST", X=int.MaxValue},
    new AlertBanner {Text="TEST", Source="", GifOnly=true},
    new AlertBanner {Text="TEST", MessageDataId=0},
    new AlertBanner {Text="TEST", Screens=Array.Empty<int>()},
    new AlertBanner {Text="TEST", Screens=new[]{0}},
    new AlertBanner {Text="TEST", Screens=new[]{6}},
    new AlertBanner {Text="TEST", Screens=new[]{1,1}}
}) {
    try { AlertMedia.Serialize(new List<AlertBanner>{invalid}); throw new Exception("Invalid entry accepted"); }
    catch (InvalidDataException) {}
}
try {
    AlertMedia.Serialize(new List<AlertBanner>{banners[0], banners[0]});
    throw new Exception("Duplicate accepted");
} catch (InvalidDataException) {}
try {
    AlertMedia.Serialize(new List<AlertBanner>{banners[0], new AlertBanner {Text="OTHER", MessageDataId=123}});
    throw new Exception("Duplicate native Message binding accepted");
} catch (InvalidDataException) {}
foreach (string invalid in new[] {"null", "{}", "{\\"version\\":1}", "{\\"version\\":2,\\"banners\\":[]}",
    "{\\"version\\":1,\\"banners\\":[{\\"text\\":\\"TEST\\"}]}",
    "{\\"version\\":1,\\"banners\\":null}"}) {
    File.WriteAllText(target, invalid);
    try { AlertMedia.Read(target); throw new Exception("Invalid manifest accepted"); }
    catch (InvalidDataException) {}
    catch (JsonException) {}
}
File.WriteAllText(target, "{\\"version\\":1,\\"banners\\":[{\\"text\\":\\"OLD\\",\\"source\\":\\"u/a.gif\\",\\"x\\":0,\\"y\\":420,\\"width\\":860,\\"height\\":60}]}");
if (AlertMedia.Read(target)[0].GifOnly) throw new Exception("Older manifests must keep the stock banner");
if (!System.Text.Encoding.UTF8.GetString(AlertMedia.Serialize(banners)).Contains("\\"gifOnly\\":true"))
    throw new Exception("gifOnly serialization");
File.WriteAllBytes(target, AlertMedia.Serialize(new List<AlertBanner>()));
if (AlertMedia.Read(target).Count != 0) throw new Exception("Removing overrides");
var selected = new AlertBanner {Text="SCREEN TEST", ScreensText="1, 3, 5"};
if (!selected.Screens.SequenceEqual(new[]{1,3,5})) throw new Exception("Screen selection");
selected.ScreensText="All";
if (selected.Screens != null) throw new Exception("All screens");
foreach (string invalid in new[]{"", "0", "6", "5,5", "1,", "1.5"}) {
    try { selected.ScreensText=invalid; throw new Exception("Invalid screen text accepted"); }
    catch (InvalidDataException) {}
}
var fields = new Dictionary<string,string>();
for (int screen=0; screen<5; screen++)
    for (int slot=0; slot<2; slot++)
        foreach (string field in new[]{"GAUGE_TYPE","IMAGE_SRC","X_POS","Y_POS","Z_POS","X_SIZE","Y_SIZE","DAY_OPACITY","NIGHT_OPACITY"})
            fields[$"SCREEN_{screen}_COMP_{slot}_{field}"] = field=="IMAGE_SRC" ? "" : "0";
fields["SCREEN_0_COMP_0_GAUGE_TYPE"]="2";
fields["SCREEN_0_COMP_0_IMAGE_SRC"]="u/existing.gif";
var original = new Dictionary<string,string>(fields);
var edits=AlarmScreenMarkers.Plan(fields,5);
if (edits.ContainsKey("SCREEN_0_COMP_0_IMAGE_SRC") ||
    edits["SCREEN_4_COMP_1_IMAGE_SRC"]!="u/ic7_screen_5.png")
    throw new Exception("Occupied component overwritten or screen numbering wrong");
foreach (var edit in edits) fields[edit.Key]=edit.Value;
if (AlarmScreenMarkers.Plan(fields,5).Count!=0) throw new Exception("Marker plan is not idempotent");
fields["SCREEN_1_COMP_0_IMAGE_SRC"]="u/ic7_screen_1.png";
fields["SCREEN_1_COMP_0_GAUGE_TYPE"]="2";
edits=AlarmScreenMarkers.Plan(fields,5);
if (edits["SCREEN_1_COMP_0_GAUGE_TYPE"]!="0") throw new Exception("Duplicate marker not removed");
original["SCREEN_0_COMP_1_GAUGE_TYPE"]="3";
try { AlarmScreenMarkers.Plan(original,5); throw new Exception("Full screen accepted"); }
catch (InvalidDataException) {}
if (original["SCREEN_0_COMP_0_IMAGE_SRC"]!="u/existing.gif") throw new Exception("Planning mutated source");
Console.WriteLine("Alert manifest geometry, matching, source, parsing and round-trip checks passed");
""")
            result = subprocess.run(
                ["dotnet", "run", "--project", str(path / "Test.csproj"), "--", str(path)],
                capture_output=True, text=True, timeout=120)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn("checks passed", result.stdout)

    def test_alert_nex_and_dll_preserve_matching_components(self):
        nex = CANDIDATE / "ic7-2.36-screen-alarms-experimental.nex"
        if not nex.exists():
            self.skipTest("Build the alert candidate first")
        codec = runpy.run_path(str(ROOT / "scripts/decode-nsp-resources.py"))
        builder = runpy.run_path(str(ROOT / "scripts/build-nsp-gif-preview.py"))
        reference = ROOT / "fw/opt/dtn/app/dash_watchdog"
        with zipfile.ZipFile(ROOT / "fw/Dash-V2-36-0-Release.nex") as stock:
            before_payload = stock.read("res_ic-7.qzip")
            hdef = stock.read("ic-7.hdef")
        with zipfile.ZipFile(nex) as candidate:
            self.assertIsNone(candidate.testzip())
            self.assertEqual(set(candidate.namelist()), {"manifest.xml", "res_ic-7.qzip", "ic-7.hdef"})
            self.assertEqual(candidate.read("ic-7.hdef"), hdef)
            after_payload = candidate.read("res_ic-7.qzip")
        self.assertEqual(before_payload[:44], after_payload[:44])
        before = builder["read_members"](codec["decode_resource"](reference, before_payload)[0])
        after = builder["read_members"](codec["decode_resource"](reference, after_payload)[0])
        for member in ("TARGET", "ROOT_TARGET", "SPLASH_TARGET", "ALERT_TARGET"):
            target = builder[member]
            self.assertEqual(after.pop(target),
                             (ROOT / "ic7-custom-dash/deploy/nsp" / Path(target).name).read_bytes())
            before.pop(target, None)
        self.assertEqual(before, after)
        self.assertEqual(len(after), 336)
        report = json.loads((CANDIDATE / "build-report.json").read_text())
        self.assertTrue(report["alert_media"])
        packager = runpy.run_path(str(ROOT / "scripts/package-nsp-media-test.py"))
        dll = ROOT / "nsp-rebuild/bin/Release/net9.0-windows10.0.19041.0/NSP.dll"
        packager["validate_native_component"](dll, nex, CANDIDATE / "build-report.json", True, True)


if __name__ == "__main__":
    unittest.main()
