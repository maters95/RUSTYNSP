from pathlib import Path
import runpy
import subprocess
import tempfile
import unittest
import zipfile


ROOT = Path(__file__).resolve().parents[2]


class SplashMediaTests(unittest.TestCase):
    def test_built_resources_retain_resourcefix_bundle(self):
        baseline = ROOT / "dist/ic7-nsp-native-media-test-2.36-resourcefix.zip"
        candidate = ROOT / "nsp-rebuild/bin/Release/net9.0-windows10.0.19041.0/NSP.dll"
        if not baseline.exists() or not candidate.exists():
            self.skipTest("Build NSP and retain the resourcefix bundle first")
        with tempfile.TemporaryDirectory(prefix="nsp-resourcefix-") as directory:
            path = Path(directory)
            with zipfile.ZipFile(baseline) as archive:
                (path / "baseline.dll").write_bytes(archive.read("NSP-test/NSP.dll"))
            (path / "Test.csproj").write_text("""
<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net9.0</TargetFramework></PropertyGroup>
</Project>
""")
            (path / "Program.cs").write_text("""
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
static Dictionary<string, byte[]> Resources(string path) {
    using FileStream stream = File.OpenRead(path);
    using PEReader pe = new PEReader(stream);
    MetadataReader metadata = pe.GetMetadataReader();
    var resources = new Dictionary<string, byte[]>();
    foreach (ManifestResourceHandle handle in metadata.ManifestResources) {
        ManifestResource item = metadata.GetManifestResource(handle);
        if (!item.Implementation.IsNil) throw new Exception("External resource");
        BlobReader blob = pe.GetSectionData(pe.PEHeaders.CorHeader.ResourcesDirectory.RelativeVirtualAddress).GetReader();
        blob.Offset = checked((int)item.Offset);
        resources.Add(metadata.GetString(item.Name), blob.ReadBytes(blob.ReadInt32()));
    }
    return resources;
}
var baseline = Resources(args[0]);
var candidate = Resources(args[1]);
if (baseline.Count < int.Parse(args[2])) throw new Exception("Incomplete resourcefix baseline: " + baseline.Count);
// Startup and alert components are intentionally updated; they must match the shipped deploy sources.
foreach (string name in new[] {"main.qml", "HalSplash.qml", "HalAlarmPopup.qml", "HalImage.qml"}) {
    if (!candidate.TryGetValue("NSP.Media." + name, out byte[] media) ||
        !media.AsSpan().SequenceEqual(File.ReadAllBytes(Path.Combine(args[3], name))))
        throw new Exception("Media component differs from deploy source: " + name);
}
foreach (var entry in baseline) {
    if (entry.Key == "NSP.Media.main.qml" || entry.Key == "NSP.Media.HalSplash.qml") continue;
    if (!candidate.TryGetValue(entry.Key, out byte[] value) ||
        !entry.Value.AsSpan().SequenceEqual(value)) throw new Exception("Resourcefix mismatch: " + entry.Key);
}
if (candidate.Count != int.Parse(args[2]) + 3 ||
    !candidate.ContainsKey("NSP.Media.main.qml") ||
    !candidate.ContainsKey("NSP.Media.HalAlarmPopup.qml") ||
    !candidate.ContainsKey("NSP.Media.HalSplash.qml")) throw new Exception("Unexpected splash resource set");
Console.WriteLine("All " + baseline.Count + " resourcefix resources retained byte-for-byte");
""")
            result = subprocess.run(
                ["dotnet", "run", "--project", str(path / "Test.csproj"), "--",
                 str(path / "baseline.dll"), str(candidate),
                 str(len(list((ROOT / "nsp-rebuild").glob("*.resx"))) + 1),
                 str(ROOT / "ic7-custom-dash/deploy/nsp")],
                capture_output=True, text=True, timeout=120)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn("resourcefix resources retained byte-for-byte", result.stdout)

    def test_splash_nex_preserves_every_other_resource(self):
        # The current candidate carries the splash alongside the alert/screen components.
        nex = ROOT / "ic7-custom-dash/build-cfw-native-media-screens-236/ic7-2.36-native-media-screens-experimental.nex"
        if not nex.exists():
            self.skipTest("Build the splash NEX first")
        codec = runpy.run_path(str(ROOT / "scripts/decode-nsp-resources.py"))
        builder = runpy.run_path(str(ROOT / "scripts/build-nsp-gif-preview.py"))
        reference = ROOT / "fw/opt/dtn/app/dash_watchdog"
        with zipfile.ZipFile(ROOT / "fw/Dash-V2-36-0-Release.nex") as archive:
            stock_payload = archive.read("res_ic-7.qzip")
        with zipfile.ZipFile(nex) as archive:
            candidate_payload = archive.read("res_ic-7.qzip")
            self.assertEqual(set(archive.namelist()), {"manifest.xml", "res_ic-7.qzip", "ic-7.hdef"})
        self.assertEqual(stock_payload[:44], candidate_payload[:44])
        before = builder["read_members"](codec["decode_resource"](reference, stock_payload)[0])
        after = builder["read_members"](codec["decode_resource"](reference, candidate_payload)[0])
        for member, filename in (
            (builder["TARGET"], "HalImage.qml"),
            (builder["ROOT_TARGET"], "main.qml"),
            (builder["SPLASH_TARGET"], "HalSplash.qml"),
            (builder["ALERT_TARGET"], "HalAlarmPopup.qml"),
        ):
            self.assertEqual(after.pop(member), (ROOT / "ic7-custom-dash/deploy/nsp" / filename).read_bytes())
            before.pop(member, None)
        self.assertEqual(after, before)
        self.assertEqual(len(after), 336)

    def test_manifest_validation_and_persistence(self):
        with tempfile.TemporaryDirectory(prefix="nsp-splash-") as directory:
            path = Path(directory)
            (path / "Test.csproj").write_text(f"""
<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net9.0</TargetFramework></PropertyGroup>
<ItemGroup>
<Compile Include="{ROOT}/nsp-rebuild/NSP/SplashMedia.cs" />
<Compile Include="{ROOT}/nsp-rebuild/NSP/MediaResource.cs" />
</ItemGroup></Project>
""")
            (path / "Program.cs").write_text("""
using System;
using System.IO;
using System.Text.Json;
using NSP;
byte[] gif = "GIF89a"u8.ToArray();
byte[] mp4 = {0,0,0,24,102,116,121,112,109,112,52,50};
if (!SplashMedia.IsAnimated("movie.gif", gif) ||
    !SplashMedia.IsAnimated("movie.mp4", mp4) ||
    !SplashMedia.IsAnimated("ic7_animation_probe.png", gif) ||
    !SplashMedia.IsAnimated("IC7_VIDEO_probe.PNG", mp4) ||
    SplashMedia.IsAnimated("static.png", new byte[12])) throw new Exception("Classification");
try { SplashMedia.IsAnimated("bad.mp4", gif); throw new Exception("Invalid header accepted"); }
catch (InvalidDataException) {}
foreach (string name in new[] {"unexpected.png", "ic7_video_probe.png", "movie.jpg"}) {
    try { SplashMedia.IsAnimated(name, gif); throw new Exception("Unsupported GIF dispatch accepted"); }
    catch (InvalidDataException) {}
}
foreach (string name in new[] {"unexpected.png", "ic7_animation_probe.png", "movie.jpg"}) {
    try { SplashMedia.IsAnimated(name, mp4); throw new Exception("Unsupported MP4 dispatch accepted"); }
    catch (InvalidDataException) {}
}
foreach (string name in new[] {"", "../bad", "u/../bad", "u/..", "x/foo", "u/ic7_splash.json"}) {
    try { SplashMedia.CreateManifest(name, true); throw new Exception("Invalid path accepted"); }
    catch (InvalidDataException) {}
}
byte[] manifest = SplashMedia.CreateManifest("u/clip with spaces.mp4", true);
using JsonDocument doc = JsonDocument.Parse(manifest);
if (doc.RootElement.GetProperty("source").GetString() != "u/clip with spaces.mp4" ||
    doc.RootElement.GetProperty("durationMs").GetInt32() != 3300) throw new Exception("Manifest");
SplashMedia.SaveManifest(args[0], manifest);
if (!File.ReadAllBytes(Path.Combine(args[0], SplashMedia.ManifestName)).AsSpan().SequenceEqual(manifest))
    throw new Exception("Persisted bytes");
SplashMedia.SaveManifest(args[0], SplashMedia.CreateManifest("h/static.png", false));
using JsonDocument disabled = JsonDocument.Parse(File.ReadAllBytes(Path.Combine(args[0], SplashMedia.ManifestName)));
if (disabled.RootElement.GetProperty("source").GetString() != "") throw new Exception("Disable");
if (File.Exists(Path.Combine(args[0], SplashMedia.ManifestName + ".tmp"))) throw new Exception("Temp retained");
Console.WriteLine("Splash manifest checks passed");
""")
            result = subprocess.run(
                ["dotnet", "run", "--project", str(path / "Test.csproj"), "--", str(path / "images")],
                capture_output=True, text=True, timeout=120)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn("Splash manifest checks passed", result.stdout)


if __name__ == "__main__":
    unittest.main()
