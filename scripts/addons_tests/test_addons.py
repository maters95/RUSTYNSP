"""Offline tests for the experimental iC-7 add-on builder and manifest helper.

    python3 -m unittest discover -s scripts/addons_tests -p "test_*.py"
"""
import io
import json
import os
from pathlib import Path
import runpy
import shutil
import subprocess
import sys
import tarfile
import tempfile
import unittest
import zipfile

ROOT = Path(__file__).resolve().parents[2]
ADDONS = ROOT / "ic7-custom-dash/deploy/addons"
STOCK_NEX = ROOT / "fw/Dash-V2-36-0-Release.nex"
REFERENCE = ROOT / "fw/opt/dtn/app/dash_watchdog"
BASE_NEX = ROOT / "ic7-custom-dash/build-cfw-screen-alarms-freshmtime-236/ic7-2.36-screen-alarms-experimental.nex"
SYSROOT = os.environ.get("IC7_SYSROOT")
BUILDER = runpy.run_path(str(ROOT / "scripts/build-ic7-addons.py"))
HELPER = runpy.run_path(str(ADDONS / "make-addon-manifests.py"))
FIXTURES = runpy.run_path(str(ROOT / "scripts/addons_tests/make_fixtures.py"))
COMPONENTS = "qml_components_data/qml/user_components/"


def stock_components():
    codec = runpy.run_path(str(ROOT / "scripts/decode-nsp-resources.py"))
    with zipfile.ZipFile(STOCK_NEX) as package:
        archive = codec["decode_resource"](REFERENCE, package.read("res_ic-7.qzip"))[0]
    with tarfile.open(fileobj=io.BytesIO(archive)) as tar:
        return {m.name: tar.extractfile(m).read() for m in tar.getmembers()
                if m.isfile() and m.name.startswith(COMPONENTS)}


class StockPreservation(unittest.TestCase):
    @classmethod
    def setUpClass(cls):
        cls.stock = stock_components()

    def test_addon_gauges_are_stock_plus_marked_insertions(self):
        for name in BUILDER["REPLACED"]:
            source = (ADDONS / "qml" / name).read_bytes().decode("utf-8")
            self.assertIn("IC7-ADDON-BEGIN", source)
            self.assertEqual(BUILDER["strip_to_stock"](source).encode("utf-8"), self.stock[COMPONENTS + name], name)

    def test_insertions_add_no_root_properties_or_functions(self):
        for name in BUILDER["REPLACED"]:
            source = (ADDONS / "qml" / name).read_text(encoding="utf-8")
            for block in BUILDER["MARKER"].findall(source):
                self.assertNotRegex(block, r"(?m)^\t(property|function|signal) ", name)

    def test_new_members_do_not_shadow_stock(self):
        for name in BUILDER["ADDED"]:
            self.assertNotIn(COMPONENTS + name, self.stock)


class ManifestHelper(unittest.TestCase):
    def build(self, spec, files=None):
        folder = Path(tempfile.mkdtemp())
        self.addCleanup(shutil.rmtree, folder, True)
        for name, data in (files or {}).items():
            (folder / name).write_bytes(data)
        return HELPER["build"](spec, folder, folder / "out")

    def test_sample_spec_builds_and_checks(self):
        with tempfile.TemporaryDirectory() as out:
            spec = json.loads((ADDONS / "samples/spec.json").read_text())
            written, _ = HELPER["build"](spec, ADDONS / "samples", Path(out))
            self.assertIn("ic7_indicators.json", written)
            self.assertEqual(HELPER["check"](Path(out)), [])
            committed = ADDONS / "samples/upload"
            for name in written:
                self.assertEqual((Path(out) / name).read_bytes(), (committed / name).read_bytes(), name)

    def test_test_fixture_manifests_are_valid(self):
        HELPER["validate_indicators"](FIXTURES["INDICATORS"])
        HELPER["validate_gauge_fx"](FIXTURES["GAUGE_FX"])

    def test_test_fixture_bad_manifests_rejected(self):
        for name, text in FIXTURES["VARIANTS"].items():
            if name == "empty.json" or name.startswith("off"):
                continue
            validate = HELPER["validate_gauge_fx"] if "-fx" in name else HELPER["validate_indicators"]
            with self.assertRaises((ValueError, HELPER["SpecError"]), msg=name):
                validate(json.loads(text))

    def test_off_manifests_are_valid_and_match_the_fixtures(self):
        with tempfile.TemporaryDirectory() as out:
            result = subprocess.run([sys.executable, str(ADDONS / "make-addon-manifests.py"), "--off",
                                     "--output", out], capture_output=True, text=True)
            self.assertEqual(result.returncode, 0, result.stderr)
            self.assertIn("power-cycle", result.stdout)
            self.assertEqual(HELPER["check"](Path(out)), [])
            indicators = json.loads((Path(out) / "ic7_indicators.json").read_text())
            gauges = json.loads((Path(out) / "ic7_gauge_fx.json").read_text())
            self.assertEqual(indicators, json.loads(FIXTURES["VARIANTS"]["off.json"]))
            self.assertEqual(gauges, json.loads(FIXTURES["VARIANTS"]["off-fx.json"]))
        with tempfile.TemporaryDirectory() as out:
            self.assertEqual(HELPER["write_off"](Path(out), "gauge_fx"), ["ic7_gauge_fx.json"])
            self.assertFalse((Path(out) / "ic7_indicators.json").exists())

    def test_rejects_wrong_content_type(self):
        with self.assertRaisesRegex(HELPER["SpecError"], "content is .png"):
            self.build({"indicators": [{"image": "a.png", "on": "x.gif"}]},
                       {"x.gif": b"\x89PNG\r\n\x1a\n" + b"0" * 20})

    def test_rejects_unsafe_filename_and_missing_file(self):
        with self.assertRaisesRegex(HELPER["SpecError"], "rename"):
            self.build({"indicators": [{"image": "a.png", "on": "my file.gif"}]},
                       {"my file.gif": b"GIF89a" + b"0" * 20})
        with self.assertRaisesRegex(HELPER["SpecError"], "not found"):
            self.build({"indicators": [{"image": "a.png", "on": "nope.gif"}]})

    def test_rejects_mp4_frames(self):
        mp4 = b"\x00\x00\x00\x18ftypisom" + b"0" * 20
        with self.assertRaisesRegex(HELPER["SpecError"], "not MP4"):
            self.build({"indicators": [{"image": "a.png", "frames": [{"min": 0, "max": 1, "file": "v.mp4"}]}]},
                       {"v.mp4": mp4})

    def test_rejects_bad_effects(self):
        for entry in ({"channel": "RPM", "trigger": "above", "effect": "flash"},
                      {"channel": "RPM", "trigger": "warn", "effect": "strobe"},
                      {"channel": "RPM", "trigger": "warn", "effect": "flash", "rateHz": 9},
                      {"channel": "RPM", "trigger": "warn", "effect": "flash", "hide": True}):
            with self.assertRaises(HELPER["SpecError"], msg=str(entry)):
                self.build({"gauge_fx": [entry]})

    def test_passes_through_uploaded_and_stock_references(self):
        written, _ = self.build({"indicators": [{"image": "a.png", "on": "u/already.gif", "off": "h/stock.png"}]})
        self.assertEqual(written, ["ic7_indicators.json"])

    def test_cli_check_reports_missing_media(self):
        with tempfile.TemporaryDirectory() as folder:
            (Path(folder) / "ic7_indicators.json").write_text(json.dumps(
                {"version": 1, "indicators": [{"image": "a.png", "on": "u/missing.gif"}]}))
            result = subprocess.run([sys.executable, str(ADDONS / "make-addon-manifests.py"), "--check", folder],
                                    capture_output=True, text=True)
            self.assertEqual(result.returncode, 1)
            self.assertIn("u/missing.gif", result.stderr)


@unittest.skipUnless(BASE_NEX.is_file(), "base candidate NEX not present")
class Builder(unittest.TestCase):
    def run_builder(self, *extra):
        out = Path(tempfile.mkdtemp())
        self.addCleanup(shutil.rmtree, out, True)
        command = [sys.executable, str(ROOT / "scripts/build-ic7-addons.py"), "--base", str(BASE_NEX),
                   "--output", str(out), *extra]
        if SYSROOT:
            command += ["--sysroot", SYSROOT]
        return subprocess.run(command, capture_output=True, text=True), out

    def test_build_self_check(self):
        result, out = self.run_builder()
        report = json.loads((out / "build-report.json").read_text())
        self.assertTrue(all(report["checks"].values()), report["checks"])
        expected = sorted(COMPONENTS + n for n in BUILDER["REPLACED"])
        self.assertEqual(report["vs_base"]["changed"], expected)
        self.assertEqual(report["vs_base"]["added"], sorted(COMPONENTS + n for n in BUILDER["ADDED"]))
        self.assertEqual(report["vs_base"]["removed"], [])
        # Reproducible: a second build of the same inputs is byte-identical.
        _, again = self.run_builder()
        self.assertEqual((out / "ic7-2.36-addons-experimental.nex").read_bytes(),
                         (again / "ic7-2.36-addons-experimental.nex").read_bytes())
        if SYSROOT:
            self.assertEqual(report["problems"], [])
            self.assertEqual(result.returncode, 0, result.stderr)
        # The base package files other than the resource archive are byte-identical.
        with zipfile.ZipFile(BASE_NEX) as base, zipfile.ZipFile(out / "ic7-2.36-addons-experimental.nex") as new:
            for name in ("manifest.xml", "ic-7.hdef"):
                self.assertEqual(base.read(name), new.read(name))
            self.assertEqual(base.read("res_ic-7.qzip")[:44], new.read("res_ic-7.qzip")[:44])

    def test_refuses_stale_mtime(self):
        result, _ = self.run_builder("--mtime", "1790648083")  # a stock member's mtime
        self.assertNotEqual(result.returncode, 0)
        self.assertIn("must differ", result.stderr)
        result, _ = self.run_builder("--mtime", "0")
        self.assertNotEqual(result.returncode, 0)

    def test_refuses_base_that_already_changes_an_addon_member(self):
        # A base built from the add-on output itself already changes HalIndicator.qml.
        _, first = self.run_builder()
        out = Path(tempfile.mkdtemp())
        self.addCleanup(shutil.rmtree, out, True)
        result = subprocess.run([sys.executable, str(ROOT / "scripts/build-ic7-addons.py"), "--base",
                                 str(first / "ic7-2.36-addons-experimental.nex"), "--output", str(out)],
                                capture_output=True, text=True)
        self.assertNotEqual(result.returncode, 0)
        self.assertIn("refusing to overwrite", result.stderr)


if __name__ == "__main__":
    unittest.main()
