import hashlib
import json
from pathlib import Path
import runpy
import subprocess
import sys
import tempfile
import unittest
import zipfile


ROOT = Path(__file__).resolve().parents[2]
PACKAGER = ROOT / "scripts/package-nsp-media-test.py"
NSP_DLL = ROOT / "nsp-rebuild/bin/Release/net9.0-windows10.0.19041.0/NSP.dll"
STOCK = ROOT / "fw/Dash-V2-36-0-Release.nex"
GUIDE = ROOT / "ic7-custom-dash/deploy/nsp/NATIVE-MEDIA-TEST.md"
# A HalImage-only candidate is built from the maintained component for these tests.
# The archived owner-confirmed videofix NEX keeps its original HalImage, so it no
# longer matches the current DLL's embedded component and must not be repackaged
# with it; it stays untouched as the historical baseline.
_BUILD = tempfile.TemporaryDirectory(prefix="nsp-native-candidate-")
NATIVE = Path(_BUILD.name) / "candidate"
NEX = NATIVE / "ic7-2.36-native-media-experimental.nex"
REPORT = NATIVE / "build-report.json"


def setUpModule():
    if not (NSP_DLL.is_file() and STOCK.is_file()) or NEX.is_file():
        return
    subprocess.run([
        sys.executable, str(ROOT / "scripts/build-nsp-gif-preview.py"), "--stock-nex", str(STOCK),
        "--reference", str(ROOT / "fw/opt/dtn/app/dash_watchdog"),
        "--component", str(GUIDE.parent / "HalImage.qml"),
        "--label", "native-media", "--output", str(NATIVE)], check=True, capture_output=True, timeout=300)


def tearDownModule():
    _BUILD.cleanup()


@unittest.skipUnless(NSP_DLL.is_file() and STOCK.is_file(), "Build native NSP first")
class NativePackagingTests(unittest.TestCase):
    def test_existing_and_custom_validation_call_signatures(self):
        packager = runpy.run_path(str(PACKAGER))
        packager["validate_inputs"](NSP_DLL)
        packager["validate_inputs"](NSP_DLL, NEX, REPORT, GUIDE)

    def test_missing_form_resource_is_rejected(self):
        validate = runpy.run_path(str(PACKAGER))["validate_nsp_dll"]
        with tempfile.TemporaryDirectory(prefix="nsp-missing-resource-") as directory:
            dll = Path(directory) / "NSP.dll"
            original = NSP_DLL.read_bytes()
            name = b"ns4.Form27.resources\0"
            self.assertIn(name, original)
            dll.write_bytes(original.replace(name, b"xxx.Form27.resources\0"))
            with self.assertRaisesRegex(ValueError, "missing required form resource"):
                validate(dll)

    def test_component_equality_and_mismatch_rejection(self):
        validate = runpy.run_path(str(PACKAGER))["validate_native_component"]
        expected = hashlib.sha256((NATIVE / "HalImage.qml").read_bytes()).hexdigest()
        self.assertEqual(validate(NSP_DLL, NEX, REPORT), expected)
        with tempfile.TemporaryDirectory(prefix="nsp-package-test-") as directory:
            path = Path(directory)
            (path / "HalImage.qml").write_text("stale component", encoding="utf-8")
            with self.assertRaisesRegex(ValueError, "does not match the NEX"):
                validate(NSP_DLL, path / "candidate.nex", REPORT)
            (path / "NSP.dll").write_bytes(b"not the matching DLL")
            with self.assertRaisesRegex(ValueError, "matching embedded"):
                validate(path / "NSP.dll", NEX, REPORT)

    def test_decoded_nex_changes_only_the_matching_component(self):
        decode = runpy.run_path(str(ROOT / "scripts/decode-nsp-resources.py"))["decode_resource"]
        build = runpy.run_path(str(ROOT / "scripts/build-nsp-gif-preview.py"))
        reference = ROOT / "fw/opt/dtn/app/dash_watchdog"
        with zipfile.ZipFile(ROOT / "fw/Dash-V2-36-0-Release.nex") as stock:
            original, _ = decode(reference, stock.read("res_ic-7.qzip"))
        with zipfile.ZipFile(NEX) as candidate:
            updated, _ = decode(reference, candidate.read("res_ic-7.qzip"))
        old_members = build["read_members"](original)
        new_members = build["read_members"](updated)
        target = build["TARGET"]
        self.assertEqual(new_members.pop(target), (GUIDE.parent / "HalImage.qml").read_bytes())
        old_members.pop(target)
        self.assertEqual(len(old_members), 338)
        self.assertEqual(new_members, old_members)

    def test_native_zip_manifest_and_no_overwrite(self):
        with tempfile.TemporaryDirectory(prefix="nsp-package-test-") as directory:
            output = Path(directory) / "native.zip"
            command = [
                sys.executable, str(PACKAGER), "--nsp-dll", str(NSP_DLL),
                "--media-nex", str(NEX), "--build-report", str(REPORT),
                "--native-media", "--output", str(output),
            ]
            result = subprocess.run(command, capture_output=True, text=True, timeout=60)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            with zipfile.ZipFile(output) as archive:
                self.assertIsNone(archive.testzip())
                manifest = json.loads(archive.read("test-manifest.json"))
                self.assertTrue(manifest["native_renderer"])
                self.assertFalse(manifest["physical_installation_tested"])
                for item in manifest["artifacts"]:
                    data = archive.read(item["path"])
                    self.assertEqual(len(data), item["bytes"])
                    self.assertEqual(hashlib.sha256(data).hexdigest(), item["sha256"])
                self.assertIn("samples/video.mp4", archive.namelist())
                self.assertIn("setup-native-media.ps1", archive.namelist())
                self.assertEqual(
                    archive.read("collect-native-media-evidence.ps1"),
                    (GUIDE.parent / "collect-native-media-evidence.ps1").read_bytes(),
                )
            original = hashlib.sha256(output.read_bytes()).hexdigest()
            result = subprocess.run(command, capture_output=True, text=True, timeout=60)
            self.assertNotEqual(result.returncode, 0)
            self.assertIn("refusing to overwrite", result.stderr)
            self.assertEqual(hashlib.sha256(output.read_bytes()).hexdigest(), original)


if __name__ == "__main__":
    unittest.main()
