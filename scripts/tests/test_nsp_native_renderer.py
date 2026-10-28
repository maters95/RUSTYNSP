import hashlib
import json
import os
from pathlib import Path
import subprocess
import tempfile
import unittest
import xml.etree.ElementTree as ET


ROOT = Path(__file__).resolve().parents[2]
DEPLOY = ROOT / "ic7-custom-dash/deploy/nsp"


class NativeRendererTests(unittest.TestCase):
    def test_component_install_and_runtime_validation(self):
        with tempfile.TemporaryDirectory(prefix="nsp-native-test-") as directory:
            path = Path(directory)
            project = ET.Element("Project", Sdk="Microsoft.NET.Sdk")
            properties = ET.SubElement(project, "PropertyGroup")
            ET.SubElement(properties, "OutputType").text = "Exe"
            ET.SubElement(properties, "TargetFramework").text = "net9.0"
            items = ET.SubElement(project, "ItemGroup")
            ET.SubElement(items, "Compile",
                          Include=str(ROOT / "nsp-rebuild/NSP/NativeMediaRenderer.cs"))
            resource = ET.SubElement(items, "EmbeddedResource",
                                     Include=str(DEPLOY / "HalImage.qml"))
            ET.SubElement(resource, "LogicalName").text = "NSP.Media.HalImage.qml"
            ET.ElementTree(project).write(path / "NativeTest.csproj")
            (path / "Program.cs").write_text(
                """
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using NSP;

string root = args[0];
string runtime = Path.Combine(args[1], "runtime");
string target = Path.Combine(runtime, "qml_components_data/qml/user_components/HalImage.qml");
Directory.CreateDirectory(Path.GetDirectoryName(target));
File.Copy(Path.Combine(root, "reference/stock-dash-extract/qml_components_data/qml/user_components/HalImage.qml"), target);
byte[] stock = File.ReadAllBytes(target);
File.WriteAllText(target + "c", "stale compiled QML");
NativeMediaRenderer.InstallComponent(runtime);
byte[] patched = File.ReadAllBytes(target);
if (stock.AsSpan().SequenceEqual(patched)) throw new Exception("Component was not replaced");
if (File.Exists(target + "c")) throw new Exception("Stale compiled QML was retained");
NativeMediaRenderer.InstallComponent(runtime);
if (!patched.AsSpan().SequenceEqual(File.ReadAllBytes(target))) throw new Exception("Not idempotent");
File.WriteAllText(target, "unexpected component");
try {
    NativeMediaRenderer.InstallComponent(runtime);
    throw new Exception("Unknown component accepted");
} catch (InvalidDataException) {}
if (File.ReadAllText(target) != "unexpected component") throw new Exception("Unknown component overwritten");

string sdk = Environment.GetEnvironmentVariable("IC7_QT5113_SDK");
if (!string.IsNullOrEmpty(sdk)) {
    string addon = Path.Combine(args[1], "addon");
    File.Copy(Path.Combine(sdk, "bin/Qt5Core.dll"), Path.Combine(runtime, "Qt5Core.dll"));
    foreach (string file in NativeMediaRenderer.RuntimeFiles) {
        string destination = Path.Combine(addon, file);
        Directory.CreateDirectory(Path.GetDirectoryName(destination));
        File.Copy(Path.Combine(sdk, file), destination);
    }
    File.WriteAllBytes(target, stock);
    ProcessStartInfo info = new ProcessStartInfo("dash_virtual.exe") { WorkingDirectory = runtime };
    info.Environment["QML2_IMPORT_PATH"] = "existing-qml";
    info.Environment["QT_PLUGIN_PATH"] = "existing-plugins";
    NativeMediaRenderer.Prepare(info, addon);
    foreach (string file in NativeMediaRenderer.RuntimeFiles) {
        string destination = file.StartsWith("bin/") ? file.Substring(4) : "ic7-media-" + file;
        if (!File.ReadAllBytes(Path.Combine(addon, file)).AsSpan().SequenceEqual(
            File.ReadAllBytes(Path.Combine(runtime, destination)))) throw new Exception("Staging mismatch");
    }
    if (!info.Environment["QML2_IMPORT_PATH"].StartsWith(Path.Combine(runtime, "ic7-media-qml")) ||
        !info.Environment["QT_PLUGIN_PATH"].StartsWith(Path.Combine(runtime, "ic7-media-plugins")))
        throw new Exception("Qt search paths not wired");
    if (!info.Environment["QML2_IMPORT_PATH"].EndsWith(Path.PathSeparator + "existing-qml") ||
        !info.Environment["QT_PLUGIN_PATH"].EndsWith(Path.PathSeparator + "existing-plugins"))
        throw new Exception("Original Qt paths lost");
    File.Delete(Path.Combine(addon, "plugins/mediaservice/dsengine.dll"));
    File.WriteAllBytes(target, stock);
    try {
        NativeMediaRenderer.Prepare(info, addon);
        throw new Exception("Missing media backend accepted");
    } catch (FileNotFoundException) {}
    if (!stock.AsSpan().SequenceEqual(File.ReadAllBytes(target))) throw new Exception("Partial runtime changed QML");
    File.WriteAllText(Path.Combine(runtime, "invalid.dll"), "not a Qt library");
    try {
        NativeMediaRenderer.ValidateLibrary(Path.Combine(runtime, "invalid.dll"));
        throw new Exception("Invalid DLL accepted");
    } catch (BadImageFormatException) {}
    byte[] wrongArchitecture = File.ReadAllBytes(Path.Combine(sdk, "bin/Qt5Core.dll"));
    int peOffset = BinaryPrimitives.ReadInt32LittleEndian(wrongArchitecture.AsSpan(0x3c, 4));
    wrongArchitecture[peOffset + 4] = 0x64;
    wrongArchitecture[peOffset + 5] = 0x86;
    File.WriteAllBytes(Path.Combine(runtime, "wrong-architecture.dll"), wrongArchitecture);
    try {
        NativeMediaRenderer.ValidateLibrary(Path.Combine(runtime, "wrong-architecture.dll"));
        throw new Exception("Wrong architecture accepted");
    } catch (InvalidDataException) {}
    byte[] wrongVersion = File.ReadAllBytes(Path.Combine(sdk, "bin/Qt5Core.dll"));
    bool changed = false;
    for (int i = 0; i < wrongVersion.Length - 16; i++) {
        if (BinaryPrimitives.ReadUInt32LittleEndian(wrongVersion.AsSpan(i, 4)) == 0xFEEF04BD) {
            wrongVersion[i + 8] = 12;
            changed = true;
            break;
        }
    }
    if (!changed) throw new Exception("Version fixture missing");
    File.WriteAllBytes(Path.Combine(runtime, "wrong-version.dll"), wrongVersion);
    try {
        NativeMediaRenderer.ValidateLibrary(Path.Combine(runtime, "wrong-version.dll"));
        throw new Exception("Wrong Qt version accepted");
    } catch (InvalidDataException) {}
    Console.WriteLine("Qt runtime staging and rejection checks passed");
}
Console.WriteLine("Native component installation checks passed");
string builtDll = Path.Combine(root, "nsp-rebuild/bin/Release/net9.0-windows10.0.19041.0/NSP.dll");
if (File.Exists(builtDll)) {
    using FileStream assembly = File.OpenRead(builtDll);
    using PEReader pe = new PEReader(assembly);
    MetadataReader metadata = pe.GetMetadataReader();
    bool found = false;
    HashSet<string> resourceNames = new HashSet<string>();
    foreach (ManifestResourceHandle handle in metadata.ManifestResources) {
        ManifestResource item = metadata.GetManifestResource(handle);
        resourceNames.Add(metadata.GetString(item.Name));
        if (metadata.GetString(item.Name) != NativeMediaRenderer.ComponentResource) continue;
        if (!item.Implementation.IsNil) throw new Exception("Component is not embedded");
        BlobReader reader = pe.GetSectionData(pe.PEHeaders.CorHeader.ResourcesDirectory.RelativeVirtualAddress).GetReader();
        reader.Offset = checked((int)item.Offset);
        byte[] actual = reader.ReadBytes(reader.ReadInt32());
        if (!patched.AsSpan().SequenceEqual(actual)) throw new Exception("Built NSP manifest resource mismatch");
        found = true;
    }
    if (!found) throw new Exception("Built NSP manifest resource missing");
    foreach (string resx in Directory.GetFiles(Path.Combine(root, "nsp-rebuild"), "*.resx")) {
        string name = Path.GetFileNameWithoutExtension(resx) + ".resources";
        if (!resourceNames.Contains(name)) throw new Exception("Missing original form resource: " + name);
    }
    Console.WriteLine("Built NSP manifest resource matches maintained QML");
}
""", encoding="utf-8")
            result = subprocess.run(
                ["dotnet", "run", "--project", str(path / "NativeTest.csproj"),
                 "--", str(ROOT), str(path)],
                capture_output=True, text=True, timeout=120, check=False,
            )
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn("Native component installation checks passed", result.stdout)
            if os.environ.get("IC7_QT5113_SDK"):
                self.assertIn("Qt runtime staging and rejection checks passed", result.stdout)
            if (ROOT / "nsp-rebuild/bin/Release/net9.0-windows10.0.19041.0/NSP.dll").is_file():
                self.assertIn("Built NSP manifest resource matches maintained QML", result.stdout)

    def test_pinned_runtime_files(self):
        manifest = json.loads((DEPLOY / "qt5113-runtime.json").read_text())
        helper = (ROOT / "nsp-rebuild/NSP/NativeMediaRenderer.cs").read_text()
        for entry in manifest["files"]:
            self.assertIn('"' + entry["path"] + '"', helper)
            if sdk := os.environ.get("IC7_QT5113_SDK"):
                payload = (Path(sdk) / entry["path"]).read_bytes()
                self.assertEqual(hashlib.sha256(payload).hexdigest(), entry["sha256"])

    def test_video_backend_advertises_media_player(self):
        manifest = json.loads((DEPLOY / "qt5113-runtime.json").read_text())
        paths = {entry["path"] for entry in manifest["files"]}
        self.assertIn("plugins/mediaservice/dsengine.dll", paths)
        self.assertIn("bin/Qt5Widgets.dll", paths)
        if sdk := os.environ.get("IC7_QT5113_SDK"):
            backend = (Path(sdk) / "plugins/mediaservice/dsengine.dll").read_bytes()
            self.assertIn(b"org.qt-project.qt.mediaplayer", backend)

    def test_override_runs_on_the_native_launch_path(self):
        launcher = (ROOT / "nsp-rebuild/NSP.UserInterface/VirtualDashAppPanel.cs").read_text()
        self.assertLess(launcher.index("NativeMediaRenderer.Prepare("),
                        launcher.index("renderer = Process.Start("))
        self.assertIn("framework_0.awZ == 21 && framework_0.awz == 11", launcher)
        project = ET.parse(ROOT / "nsp-rebuild/NSP.csproj").getroot()
        self.assertTrue(any(
            item.get("LogicalName") == "NSP.Media.HalImage.qml"
            for item in project.iter("EmbeddedResource")
        ))


if __name__ == "__main__":
    unittest.main()
