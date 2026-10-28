import json
from pathlib import Path
import shutil
import subprocess
import sys
import tempfile
import unittest


ROOT = Path(__file__).resolve().parents[2]
SCRIPT = ROOT / "ic7-custom-dash/deploy/nsp/collect-native-media-evidence.ps1"
PWSH = shutil.which("pwsh")


@unittest.skipUnless(PWSH, "PowerShell required")
class MediaEvidenceTests(unittest.TestCase):
    def test_powershell_syntax(self):
        result = subprocess.run(
            [PWSH, "-NoProfile", "-Command",
             "$tokens=$null; $errors=$null; "
             "[System.Management.Automation.Language.Parser]::ParseFile("
             f"'{SCRIPT}',[ref]$tokens,[ref]$errors) | Out-Null; "
             "if ($errors.Count) { $errors | Out-String | Write-Error; exit 1 }"],
            capture_output=True, text=True, timeout=30)
        self.assertEqual(result.returncode, 0, result.stdout + result.stderr)

    @unittest.skipIf(sys.platform == "win32", "Non-Windows guard test")
    def test_wrong_host_is_rejected(self):
        result = subprocess.run(
            [PWSH, "-NoProfile", "-File", str(SCRIPT)],
            capture_output=True, text=True, timeout=30)
        self.assertNotEqual(result.returncode, 0)
        self.assertIn("Run this collector on Windows", result.stderr)

    def test_collection_with_mocked_windows_processes(self):
        with tempfile.TemporaryDirectory(prefix="nsp-media-evidence-test-") as directory:
            root = Path(directory)
            runtime = root / "runtime"
            runtime.mkdir()
            for name in ("NSP.exe", "NSP.dll", "HalImage.qml", "HaltechDashWin.log",
                         "dsengine.dll", "Qt5Core.dll"):
                (runtime / name).write_text("fixture " + name)
            collector = root / "collector.ps1"
            original = SCRIPT.read_text()
            guard = "[Environment]::OSVersion.Platform -ne [PlatformID]::Win32NT"
            self.assertEqual(original.count(guard), 1)
            collector.write_text(original.replace(guard, "$false"))
            harness = root / "harness.ps1"
            harness.write_text("""
param($Collector, $Runtime, $OutputPath, $ModuleMode = 'normal')
$env:APPDATA = $null
$env:LOCALAPPDATA = $null
if ($ModuleMode -eq 'no-logs') {
    $env:APPDATA = Join-Path $Runtime 'appdata'
    New-Item -ItemType Directory -Path (Join-Path $env:APPDATA 'Haltech/Nexus') -Force | Out-Null
}
$env:NSP_TEST_MODULE_DIRECTORY = $Runtime
if ($ModuleMode -ne 'normal') {
    Add-Type -TypeDefinition @'
using System;
using System.IO;
namespace NspMediaDiagnostics {
    public static class ModuleReader {
        public static string[] Read(int id) {
            if (id != 123) throw new Exception("Wrong process ID");
            string root = Environment.GetEnvironmentVariable("NSP_TEST_MODULE_DIRECTORY");
            if (Environment.GetEnvironmentVariable("NSP_TEST_MODULE_MODE") == "incomplete")
                return new string[] { Path.Combine(root, "dsengine.dll") };
            return new string[] { Path.Combine(root, "Qt5Core.dll"), Path.Combine(root, "dsengine.dll") };
        }
    }
}
'@
}
$env:NSP_TEST_MODULE_MODE = $ModuleMode
function Get-CimInstance {
    [pscustomobject]@{ Caption='Fixture Windows'; Version='10'; BuildNumber='1'; OSArchitecture='64-bit' }
}
function Get-Process {
    [pscustomobject]@{
        ProcessName=$(if ($ModuleMode -eq 'normal') { 'NSP' } else { 'dash_virtual' })
        Id=123; Path=(Join-Path $Runtime 'NSP.exe')
        StartTime=[datetime]::UtcNow
        Modules=@([pscustomobject]@{
            ModuleName='dsengine.dll'; FileName=(Join-Path $Runtime 'dsengine.dll')
            FileVersionInfo=[pscustomobject]@{ FileVersion='5.11.3' }
        })
    }
}
& $Collector -OutputDirectory $OutputPath
""")
            output = root / "evidence"
            command = [PWSH, "-NoProfile", "-File", str(harness),
                       str(collector), str(runtime), str(output)]
            result = subprocess.run(command, capture_output=True, text=True, timeout=30)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            report = json.loads((output / "report.json").read_text(encoding="utf-8-sig"))
            self.assertFalse(report["Errors"])
            self.assertEqual(report["Processes"][0]["Modules"][0]["Name"], "dsengine.dll")
            files = {Path(item["Path"]).name: item for item in report["Files"]}
            self.assertEqual(len(files), 6)
            for name in ("HalImage.qml", "HaltechDashWin.log"):
                self.assertEqual((output / files[name]["Copy"]).read_bytes(),
                                 (runtime / name).read_bytes())
            for name in ("NSP.exe", "NSP.dll", "dsengine.dll"):
                self.assertIsNone(files[name]["Copy"])
            result = subprocess.run(command, capture_output=True, text=True, timeout=30)
            self.assertNotEqual(result.returncode, 0)
            self.assertIn("Output directory already exists", result.stderr)
            for mode in ("native-fallback", "incomplete", "no-logs"):
                with self.subTest(mode=mode):
                    if mode == "no-logs":
                        (runtime / "HaltechDashWin.log").unlink()
                    target = root / mode
                    result = subprocess.run(
                        command[:-1] + [str(target), mode],
                        capture_output=True, text=True, timeout=30)
                    self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
                    report = json.loads((target / "report.json").read_text(encoding="utf-8-sig"))
                    self.assertEqual(report["Processes"][0]["ModuleEnumeration"],
                                     "PSAPI EnumProcessModulesEx LIST_MODULES_ALL")
                    self.assertEqual(report["Processes"][0]["ModuleEvidenceComplete"],
                                     mode != "incomplete")
                    self.assertEqual(bool(report["Errors"]), mode != "native-fallback")
                    if mode == "no-logs":
                        self.assertEqual(len(report["Errors"]), 1)
                        self.assertEqual(result.stdout.count("No renderer/application logs found"), 1)

    def test_native_module_reader_compiles(self):
        source = SCRIPT.read_text().split("Add-Type -TypeDefinition @'\n", 1)[1].split("\n'@", 1)[0]
        self.assertNotIn("System.ComponentModel", source)
        self.assertNotIn("Win32Exception", source)
        self.assertIn('NativeError("OpenProcess")', source)
        self.assertIn('NativeError("EnumProcessModulesEx")', source)
        self.assertIn('NativeError("GetModuleFileNameEx")', source)
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "reader.cs"
            path.write_text(source)
            result = subprocess.run(
                [PWSH, "-NoProfile", "-Command", f"Add-Type -Path '{path}' -ErrorAction Stop"],
                capture_output=True, text=True, timeout=30)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)


if __name__ == "__main__":
    unittest.main()
