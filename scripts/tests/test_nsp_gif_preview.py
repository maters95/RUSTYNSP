from pathlib import Path
import unittest


ROOT = Path(__file__).resolve().parents[2]


class NspGifPreviewSourceTests(unittest.TestCase):
    def test_both_preview_modes_use_retained_image(self):
        source = (ROOT / "nsp-rebuild/ns4/Form40.cs").read_text(encoding="utf-8-sig")
        self.assertIn("Image image2 = LoadPreviewImage(class226_0.method_1());", source)
        self.assertIn("Image image3 = LoadPreviewImage(class226_0.method_1());", source)
        self.assertIn("previewImage.SelectActiveFrame(FrameDimension.Time, previewFrame)", source)
        self.assertIn("previewImage.GetPropertyItem(0x5100).Value", source)
        self.assertIn("previewTimer.Tick += AdvancePreviewFrame;", source)
        self.assertIn("previewTimer.Interval = PreviewFrameInterval();", source)

    def test_dispose_releases_animation_resources(self):
        source = (ROOT / "nsp-rebuild/ns4/Form40.cs").read_text(encoding="utf-8-sig")
        cleanup = source.split("private void ClearAnimatedPreview()", 1)[1].split(
            "private int PreviewFrameInterval()", 1
        )[0]
        for resource in ("previewTimer", "previewImage", "previewStream"):
            self.assertIn(resource + "?.Dispose();", cleanup)
        dispose = source.split("protected override void Dispose(bool disposing)", 1)[1]
        self.assertIn("ClearAnimatedPreview();", dispose.split("base.Dispose", 1)[0])


if __name__ == "__main__":
    unittest.main()
