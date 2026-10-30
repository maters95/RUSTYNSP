"""Checks that the media/alarm additions to the rebuilt NSP behave like NSP's own UI.

The Windows Forms UI cannot run on Linux, so the dialog conventions are checked in the
source; the name/size rules the dialogs rely on run as a small .NET program.
"""
import re
import subprocess
import tempfile
import unittest
from pathlib import Path


ROOT = Path(__file__).resolve().parents[2]
SRC = ROOT / "nsp-rebuild"
ADDED_UI = [
    SRC / "NSP.UserInterface/AlertBannerEditor.cs",
    SRC / "ns1/Control14.cs",
    SRC / "ns2/Control4.cs",
    SRC / "ns3/Class117.cs",
    SRC / "ns4/Form23.cs",
    SRC / "ns4/Form40.cs",
]


class NspUiConventionTests(unittest.TestCase):
    def test_messages_use_nsp_themed_message_box(self):
        # Stock NSP shows every message through its themed Form54, never MessageBox.Show.
        for path in ADDED_UI:
            self.assertNotIn("MessageBox.Show(", path.read_text(encoding="utf-8-sig"), path.name)

    def test_alarm_appearance_dialog_follows_nsp_dialog_conventions(self):
        source = (SRC / "NSP.UserInterface/AlertBannerEditor.cs").read_text()
        for snippet in ("ShowIcon = false", "ShowInTaskbar = false", "MinimizeBox = false",
                        "Font = Form23.form23_0?.Font", "grid.DefaultCellStyle.BackColor = Form23.color_32",
                        "grid.EnableHeadersVisualStyles = false", "FormClosing += ConfirmDiscard",
                        "AcceptButton = ok", "CancelButton = cancel", "NSP.AlertMedia.NameProblem(",
                        "MaxInputLength = name == \"Text\" ? NSP.AlertMedia.DashNameLength"):
            self.assertIn(snippet, source)
        # OK, Cancel, Apply in the Windows order, after the editing actions.
        order = [source.index('"OK"'), source.index('"Cancel"'), source.index('"Apply"')]
        self.assertEqual(order, sorted(order))
        self.assertGreater(order[0], source.index('"Remove override"'))
        # Opening an alarm's appearance and pressing OK must not add a positioned rule.
        self.assertIn("banner != placeholder || !IsDefaultRule(banner)", source)

    def test_entry_points_are_gated_to_the_ic7_media_context(self):
        form23 = (SRC / "ns4/Form23.cs").read_text()
        self.assertIn('new ToolStripMenuItem("Dash Alarm Appearance")', form23)
        self.assertIn("IndexOf(toolStripMenuItem_59) + 1, alertMediaMenu", form23)
        self.assertRegex(form23, r"alertMediaMenu\.Available = SupportsDashMedia\(framework_1\)")
        self.assertIn('alertBannerItem.Available = Form23.SupportsDashMedia(Form23.framework_1)',
                      (SRC / "ns2/Control4.cs").read_text())

    def test_picker_hides_managed_markers_and_warns_about_large_media(self):
        form40 = (SRC / "ns4/Form40.cs").read_text(encoding="utf-8-sig")
        self.assertIn("list.RemoveAll(path => NSP.MediaResource.IsManagedResource(", form40)
        self.assertIn("NSP.MediaResource.LargeMediaWarning(fileName", form40)
        # The marker name rule matches the one the markers are created with.
        markers = (SRC / "NSP/AlarmScreenMarkers.cs").read_text()
        self.assertIn('"u/ic7_screen_" + screen + ".png"', markers)

    def test_name_and_media_rules(self):
        with tempfile.TemporaryDirectory(prefix="nsp-ui-") as directory:
            path = Path(directory)
            (path / "Test.csproj").write_text(f"""
<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net9.0</TargetFramework></PropertyGroup>
<ItemGroup>
<Compile Include="{SRC}/NSP/AlertMedia.cs" />
<Compile Include="{SRC}/NSP/SplashMedia.cs" />
<Compile Include="{SRC}/NSP/MediaResource.cs" />
</ItemGroup></Project>
""")
            (path / "Program.cs").write_text("""
using System;
using NSP;
void Check(bool ok, string what) { if (!ok) throw new Exception(what); }
Check(AlertMedia.DashName("OIL PRESSURE\\0\\0\\0") == "OIL PRESSURE", "null padding");
Check(AlertMedia.DashName("  KFC LIMITER  ") == "KFC LIMITER", "trim");
Check(AlertMedia.DashName("ABCDEFGHIJKLMNOPQRSTUVWXYZ") == "ABCDEFGHIJKLMNOPQRST", "20-character dash text");
Check(AlertMedia.DashName("ABCDEFGHIJKLMNOPQRS  TAIL") == "ABCDEFGHIJKLMNOPQRS", "truncate then trim");
Check(AlertMedia.DashName(null) == "", "null");
Check(AlertMedia.NameProblem("KFC LIMITER") == null, "valid name");
Check(AlertMedia.NameProblem("ABCDEFGHIJKLMNOPQRST") == null, "exactly 20");
Check(AlertMedia.NameProblem("ABCDEFGHIJKLMNOPQRSTU")?.Contains("ABCDEFGHIJKLMNOPQRST") == true, "over 20 suggests dash text");
Check(AlertMedia.NameProblem("SAY \\"HI\\"") != null, "quote");
Check(AlertMedia.NameProblem(" PAD") != null, "padding");
Check(AlertMedia.NameProblem("") != null && AlertMedia.NameProblem("   ") != null, "empty");
Check(MediaResource.LargeMediaWarning("a.gif", 1000, 860, 480, 30) == null, "canvas-sized GIF");
Check(MediaResource.LargeMediaWarning("b.gif", 1000, 1920, 1080, 30) != null, "oversized frames");
Check(MediaResource.LargeMediaWarning("c.png", 1000, 1920, 1080, 1) == null, "static image is scaled once");
Check(MediaResource.LargeMediaWarning("d.mp4", 5L << 20, 0, 0, 0)?.Contains("5.0 MB") == true, "large file");
Check(MediaResource.IsManagedResource("ic7_screen_3.png") && !MediaResource.IsManagedResource("ic7_screen_6.png")
    && !MediaResource.IsManagedResource("my_ic7_screen_1.png"), "managed marker names");
Console.WriteLine("UI name and media rules passed");
""")
            result = subprocess.run(
                ["dotnet", "run", "--project", str(path / "Test.csproj")],
                capture_output=True, text=True, timeout=180)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn("rules passed", result.stdout)


if __name__ == "__main__":
    unittest.main()
