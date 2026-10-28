import json
from pathlib import Path
import shutil
import subprocess
import tempfile
import unittest


ROOT = Path(__file__).resolve().parents[2]
SCRIPT = ROOT / "ic7-custom-dash/deploy/nsp/test-native-video.ps1"
PWSH = shutil.which("pwsh")


@unittest.skipUnless(PWSH, "PowerShell required")
class VideoProbeTests(unittest.TestCase):
    def test_syntax_and_csharp_compilation(self):
        source = SCRIPT.read_text().split("Add-Type -TypeDefinition @'\n", 1)[1].split("\n'@", 1)[0]
        self.assertNotIn("System.ComponentModel", source)
        self.assertNotIn("graph.Run(", source)
        self.assertNotIn("graph.Pause(", source)
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "probe.cs"
            path.write_text(source)
            result = subprocess.run(
                [PWSH, "-NoProfile", "-Command",
                 "$tokens=$null; $errors=$null; "
                 "[System.Management.Automation.Language.Parser]::ParseFile("
                 f"'{SCRIPT}',[ref]$tokens,[ref]$errors) | Out-Null; "
                 "if ($errors.Count) { $errors | Out-String | Write-Error; exit 1 }; "
                 f"Add-Type -Path '{path}' -ErrorAction Stop; "
                 "$hr=[BitConverter]::ToInt32([BitConverter]::GetBytes([uint32]2147746405),0); "
                 "$message=[NspVideoProbe.Probe]::DescribeResult($hr); "
                 "if ($message -notlike 'VFW_E_UNSUPPORTED_STREAM:*') { throw $message }; "
                 "if ([NspVideoProbe.Probe]::DescribeResult(0) -notlike 'Graph construction only*') { throw 'Success wording changed' }"],
                capture_output=True, text=True, timeout=30)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)

    def test_mocked_graph_results_and_failure_evidence(self):
        original = SCRIPT.read_text()
        start = original.index("Add-Type -TypeDefinition @'\n")
        end = original.index("\n'@", start) + len("\n'@")
        fake = """Add-Type -TypeDefinition @'
using System;
namespace NspVideoProbe {
    public class FakeResult {
        public string HResult;
        public string Status;
        public string[] Filters = new string[] { "Fixture splitter", "Fixture decoder" };
    }
    public static class Probe {
        public static FakeResult Build(string file) {
            string mode = Environment.GetEnvironmentVariable("NSP_PROBE_TEST_MODE");
            if (mode == "exception") throw new InvalidOperationException("Fixture COM error");
            return new FakeResult {
                HResult = mode == "failed" ? "0x80040218" : (mode == "partial-or-warning" ? "0x00040242" : "0x00000000"),
                Status = mode
            };
        }
    }
}
'@"""
        patched = (original[:start] + fake + original[end:]).replace(
            "[Environment]::OSVersion.Platform -ne [PlatformID]::Win32NT", "$false"
        ).replace("[Environment]::Is64BitProcess", "$false")
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            script = root / "probe.ps1"
            script.write_text(patched)
            video = root / "fixture.mp4"
            video.write_bytes(b"fixture video")
            for mode in ("graph-built", "failed", "partial-or-warning", "exception"):
                with self.subTest(mode=mode):
                    output = root / (mode + ".json")
                    command = [
                        PWSH, "-NoProfile", "-Command",
                        f"$env:NSP_PROBE_TEST_MODE='{mode}'; & '{script}' "
                        f"-VideoPath '{video}' -OutputPath '{output}'",
                    ]
                    result = subprocess.run(command, capture_output=True, text=True, timeout=30)
                    self.assertEqual(result.returncode == 0, mode != "exception",
                                     result.stdout + result.stderr)
                    report = json.loads(output.read_text(encoding="utf-8-sig"))
                    if mode == "exception":
                        self.assertIn("Fixture COM error", report["Error"])
                        self.assertIsNone(report["Result"])
                    else:
                        self.assertEqual(report["Result"]["Status"], mode)
                        self.assertIsNone(report["Error"])
                    self.assertEqual(report["Length"], 13)


if __name__ == "__main__":
    unittest.main()
