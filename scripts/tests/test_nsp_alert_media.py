import json
import hashlib
from pathlib import Path
import runpy
import subprocess
import sys
import tempfile
import unittest
import zipfile


ROOT = Path(__file__).resolve().parents[2]
CANDIDATE = ROOT / "ic7-custom-dash/build-cfw-native-media-screens-236"


class AlertMediaTests(unittest.TestCase):
    def test_alert_bundle_contains_matching_components_and_guide(self):
        nex = CANDIDATE / "ic7-2.36-native-media-screens-experimental.nex"
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
        for text in ("Banner GIF && position...", "Alert GIF banners and placement...",
                     "ic7AlertBannerButton", "MP4 startup video"):
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
</ItemGroup></Project>
""")
            (path / "Program.cs").write_text("""
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using NSP;
var banners = new List<AlertBanner> {
    new AlertBanner { Text="OIL PRESSURE", Source="u/animation.gif", X=100, Y=80, Width=300, Height=80, GifOnly=true },
    new AlertBanner { Text="TEMP", Source="", X=0, Y=420, Width=860, Height=60 }
};
string target = Path.Combine(args[0], AlertMedia.ManifestName);
File.WriteAllBytes(target, AlertMedia.Serialize(banners));
var read = AlertMedia.Read(target);
if (read.Count != 2 || read[0].Text != "OIL PRESSURE" || read[0].X != 100 ||
    read[0].Y != 80 || read[0].Width != 300 || read[0].Height != 80 ||
    read[0].Source != "u/animation.gif" || read[1].Source != "" || !read[0].GifOnly || read[1].GifOnly)
    throw new Exception("Manifest round trip");
foreach (AlertBanner invalid in new[] {
    new AlertBanner {Text=""}, new AlertBanner {Text="TEST", Source="u/../file.gif"},
    new AlertBanner {Text="TEST", Source="u/movie.mp4"},
    new AlertBanner {Text="TEST", X=-1}, new AlertBanner {Text="TEST", Y=421},
    new AlertBanner {Text="TEST", Width=861}, new AlertBanner {Text="TEST", Height=59},
    new AlertBanner {Text="TEST", X=int.MaxValue},
    new AlertBanner {Text="TEST", Source="", GifOnly=true}
}) {
    try { AlertMedia.Serialize(new List<AlertBanner>{invalid}); throw new Exception("Invalid entry accepted"); }
    catch (InvalidDataException) {}
}
try {
    AlertMedia.Serialize(new List<AlertBanner>{banners[0], banners[0]});
    throw new Exception("Duplicate accepted");
} catch (InvalidDataException) {}
foreach (string invalid in new[] {"null", "{}", "{\\"version\\":1}", "{\\"version\\":3,\\"banners\\":[]}",
    "{\\"version\\":1,\\"banners\\":[{\\"text\\":\\"T\\",\\"source\\":\\"\\",\\"x\\":0,\\"y\\":0,\\"width\\":860,\\"height\\":60,\\"screens\\":[0]}]}",
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
if (!System.Text.Encoding.UTF8.GetString(AlertMedia.Serialize(banners)).StartsWith("{\\"version\\":1,")
    || System.Text.Encoding.UTF8.GetString(AlertMedia.Serialize(banners)).Contains("screens"))
    throw new Exception("Manifests without screen rules must stay version 1");
var screenRules = new List<AlertBanner> {
    new AlertBanner { Text="OIL", Source="", X=0, Y=420, Width=860, Height=60 },
    new AlertBanner { Text="OIL", Source="u/a.gif", X=0, Y=0, Width=860, Height=200, GifOnly=true, ScreensText="3, 5" },
    new AlertBanner { Text="OIL", Source="", X=10, Y=10, Width=300, Height=60, ScreensText="1" }
};
File.WriteAllBytes(target, AlertMedia.Serialize(screenRules));
var screenRead = AlertMedia.Read(target);
if (!File.ReadAllText(target).StartsWith("{\\"version\\":2,") || screenRead[0].Screens != null
    || string.Join(",", screenRead[1].Screens) != "2,4" || screenRead[1].ScreensText != "3, 5")
    throw new Exception("Screen rule round trip");
if (AlertMedia.Resolve(screenRead, "OIL", 2) != screenRead[1] || AlertMedia.Resolve(screenRead, "OIL", 0) != screenRead[2]
    || AlertMedia.Resolve(screenRead, "OIL", 1) != screenRead[0] || AlertMedia.Resolve(screenRead, "OIL", -1) != screenRead[0]
    || AlertMedia.Resolve(screenRead, "OTHER", 2) != null)
    throw new Exception("Screen rule resolution");
foreach (var invalid in new[] {
    new List<AlertBanner> { new AlertBanner { Text="OIL", Source="", Height=60, ScreensText="1, 2" },
                            new AlertBanner { Text="OIL", Source="", Height=60, ScreensText="2" } },
    new List<AlertBanner> { new AlertBanner { Text="OIL", Source="", Height=60, Screens=new List<int>{5} } },
    new List<AlertBanner> { new AlertBanner { Text="OIL", Source="", Height=60, Screens=new List<int>() } },
    new List<AlertBanner> { new AlertBanner { Text="OIL", Source="", Height=60, Screens=new List<int>{1, 1} } } }) {
    try { AlertMedia.Serialize(invalid); throw new Exception("Invalid screen rule accepted"); }
    catch (InvalidDataException) {}
}
foreach (string invalid in new[] {"0", "6", "1,1", "x", "1;2"}) {
    try { AlertMedia.ParseScreens(invalid); throw new Exception("Invalid screen text accepted: " + invalid); }
    catch (FormatException) {}
}
if (AlertMedia.ParseScreens(" all ") != null || AlertMedia.ParseScreens("") != null)
    throw new Exception("All-screens text");
File.WriteAllBytes(target, AlertMedia.Serialize(new List<AlertBanner>()));
if (AlertMedia.Read(target).Count != 0) throw new Exception("Removing overrides");
Console.WriteLine("Alert manifest geometry, matching, source, parsing and round-trip checks passed");
""")
            result = subprocess.run(
                ["dotnet", "run", "--project", str(path / "Test.csproj"), "--", str(path)],
                capture_output=True, text=True, timeout=120)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn("checks passed", result.stdout)

    def test_alert_nex_and_dll_preserve_matching_components(self):
        nex = CANDIDATE / "ic7-2.36-native-media-screens-experimental.nex"
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
