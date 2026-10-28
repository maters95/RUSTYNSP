import hashlib
import json
import os
from pathlib import Path
import shutil
import subprocess
import tempfile
import unittest


ROOT = Path(__file__).resolve().parents[2]
DEPLOY = ROOT / "ic7-custom-dash/deploy/nsp"
PWSH = shutil.which("pwsh")


@unittest.skipUnless(PWSH, "PowerShell is required for setup validation")
class NativeSetupTests(unittest.TestCase):
    def test_powershell_syntax(self):
        result = subprocess.run(
            [PWSH, "-NoLogo", "-NoProfile", "-Command",
             "$tokens=$null; $errors=$null; "
             "[System.Management.Automation.Language.Parser]::ParseFile("
             f"'{DEPLOY / 'setup-native-media.ps1'}',[ref]$tokens,[ref]$errors) | Out-Null; "
             "if ($errors.Count) { $errors | Out-String | Write-Error; exit 1 }"],
            capture_output=True, text=True, timeout=30,
        )
        self.assertEqual(result.returncode, 0, result.stdout + result.stderr)

    @unittest.skipUnless(os.environ.get("IC7_QT5113_ARCHIVES"),
                         "Official Qt archives are required for offline setup validation")
    def test_offline_copy_and_manifest_rejection(self):
        archives = Path(os.environ["IC7_QT5113_ARCHIVES"])
        metadata = json.loads((DEPLOY / "qt5113-runtime.json").read_text())
        with tempfile.TemporaryDirectory(prefix="nsp-setup-test-") as directory:
            path = Path(directory)
            source = path / "original"
            source.mkdir()
            shutil.copy2(ROOT / "vendor/local-installs/haltech-nsp/NSP.dll",
                         source / "NSP.dll")
            (source / "NSP.exe").write_bytes(b"fixture launcher, not executed")
            (source / "support.dat").write_bytes(b"preserve support files")
            original_hash = hashlib.sha256((source / "NSP.dll").read_bytes()).hexdigest()
            bundle = path / "bundle"
            bundle.mkdir()
            (bundle / "NSP-test").mkdir()
            shutil.copy2(DEPLOY / "setup-native-media.ps1", bundle)
            shutil.copy2(DEPLOY / "qt5113-runtime.json", bundle)
            shutil.copy2(
                ROOT / "nsp-rebuild/bin/Release/net9.0-windows10.0.19041.0/NSP.dll",
                bundle / "NSP-test/NSP.dll",
            )
            manifest = {"artifacts": [
                {"path": name,
                 "sha256": hashlib.sha256((bundle / name).read_bytes()).hexdigest()}
                for name in ("NSP-test/NSP.dll", "qt5113-runtime.json")
            ]}
            (bundle / "test-manifest.json").write_text(json.dumps(manifest), encoding="utf-8")
            offline = path / "archives"
            offline.mkdir()
            for entry in metadata["archives"]:
                matches = list(archives.glob(entry["name"].removesuffix(".7z") + "-*.7z"))
                self.assertEqual(len(matches), 1, f"Expected one aqt archive for {entry['name']}")
                os.link(matches[0], offline / entry["name"])
            harness = path / "run-setup.ps1"
            harness.write_text(
                """
param($Setup, $Source, $Target, $Archives)
function Get-Command {
    [CmdletBinding()] param([string]$Name)
    if ($Name -eq '7z.exe') {
        return (Microsoft.PowerShell.Core\\Get-Command 7z)
    }
    if ($Name -eq 'tar.exe') { return $null }
    Microsoft.PowerShell.Core\\Get-Command @PSBoundParameters
}
& $Setup -NspInstall $Source -Destination $Target -ArchiveDirectory $Archives
""", encoding="utf-8",
            )
            target = path / "test-copy"
            command = [
                PWSH, "-NoLogo", "-NoProfile", "-File", str(harness),
                str(bundle / "setup-native-media.ps1"), str(source),
                str(target), str(offline),
            ]
            result = subprocess.run(command, capture_output=True, text=True, timeout=120)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertEqual((target / "NSP.dll").read_bytes(),
                             (bundle / "NSP-test/NSP.dll").read_bytes())
            self.assertEqual((target / "support.dat").read_bytes(), b"preserve support files")
            for item in metadata["files"]:
                data = (target / "ic7-media-runtime" / item["path"]).read_bytes()
                self.assertEqual(hashlib.sha256(data).hexdigest(), item["sha256"])
            self.assertEqual(hashlib.sha256((source / "NSP.dll").read_bytes()).hexdigest(),
                             original_hash)
            (bundle / "qt5113-runtime.json").write_text("{}", encoding="utf-8")
            command[-2] = str(path / "rejected-copy")
            result = subprocess.run(command, capture_output=True, text=True, timeout=30)
            self.assertNotEqual(result.returncode, 0)
            self.assertIn("SHA-256 mismatch", result.stderr)
            self.assertFalse((path / "rejected-copy").exists())


if __name__ == "__main__":
    unittest.main()
