from pathlib import Path
import subprocess
import tempfile
import unittest
import xml.etree.ElementTree as ET


ROOT = Path(__file__).resolve().parents[2]


class NspMediaResourceTests(unittest.TestCase):
    def test_video_detection_and_stream_preservation(self):
        with tempfile.TemporaryDirectory(prefix="nsp-media-test-") as directory:
            path = Path(directory)
            project = ET.Element("Project", Sdk="Microsoft.NET.Sdk")
            properties = ET.SubElement(project, "PropertyGroup")
            ET.SubElement(properties, "OutputType").text = "Exe"
            ET.SubElement(properties, "TargetFramework").text = "net9.0"
            items = ET.SubElement(project, "ItemGroup")
            ET.SubElement(
                items,
                "Compile",
                Include=str(ROOT / "nsp-rebuild/NSP/MediaResource.cs"),
                Link="MediaResource.cs",
            )
            ET.ElementTree(project).write(path / "MediaTest.csproj")
            (path / "Program.cs").write_text(
                """
using System;
using System.IO;
using NSP;

byte[] mp4 = { 0, 0, 0, 24, 102, 116, 121, 112, 109, 112, 52, 50 };
byte[] png = { 137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 0 };
int checks = 0;
void Check(bool condition)
{
    checks++;
    if (!condition) throw new Exception($"Check {checks} failed");
}
Check(MediaResource.HasMp4Header(mp4));
Check(!MediaResource.HasMp4Header(png));
Check(!MediaResource.HasMp4Header(mp4.AsSpan(0, 11)));
using var video = new MemoryStream(mp4);
Check(MediaResource.IsVideo("movie.MP4", video));
Check(MediaResource.IsVideo("ic7_video_probe.png", video));
Check(MediaResource.IsVideo("IC7_VIDEO_PROBE.PNG", video));
Check(video.Position == 0);
Check(!MediaResource.IsVideo("ordinary.png", video));
using var image = new MemoryStream(png);
Check(!MediaResource.IsVideo("ic7_video_actual_image.png", image));
Check(image.Position == 0);
using var truncated = new MemoryStream(mp4, 0, 8);
Check(!MediaResource.IsVideo("ic7_video_short.png", truncated));
Check(truncated.Position == 0);
video.Position = 3;
Check(!MediaResource.IsVideo("ic7_video_probe.png", video));
Check(video.Position == 3);
Console.WriteLine($"{checks} media detection checks passed");
""",
                encoding="utf-8",
            )
            result = subprocess.run(
                ["dotnet", "run", "--project", str(path / "MediaTest.csproj")],
                capture_output=True,
                text=True,
                check=False,
                timeout=120,
            )
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn("14 media detection checks passed", result.stdout)


if __name__ == "__main__":
    unittest.main()
