import base64
from pathlib import Path
import unittest
import xml.etree.ElementTree as ET


ROOT = Path(__file__).resolve().parents[2]
RESOURCE_FILE = ROOT / "nsp-rebuild/ns2.Control3.resx"


class NspResourceSerializationTests(unittest.TestCase):
    def test_text_converter_values_are_not_serialized_as_byte_arrays(self):
        textual_types = {
            "System.Drawing.Size", "System.Drawing.SizeF", "System.Drawing.Point",
            "System.Drawing.ContentAlignment", "System.Windows.Forms.Padding",
            "System.Windows.Forms.FormStartPosition", "System.Windows.Forms.ImeMode",
            "System.Windows.Forms.AutoSizeMode", "System.Windows.Forms.AnchorStyles",
            "System.Windows.Forms.RichTextBoxScrollBars",
            "System.Windows.Forms.TableLayoutSettings",
        }
        checked = 0
        for path in (ROOT / "nsp-rebuild").glob("*.resx"):
            for resource in ET.parse(path).getroot().findall("data"):
                if resource.get("type", "").split(",")[0] in textual_types:
                    with self.subTest(file=path.name, name=resource.get("name")):
                        self.assertNotIn("mimetype", resource.attrib)
                        self.assertTrue(resource.findtext("value"))
                    checked += 1
        self.assertGreater(checked, 100)

    def test_channel_selector_enum_values_use_strings(self):
        resources = {
            item.get("name"): item
            for item in ET.parse(ROOT / "nsp-rebuild/ns2.Control8.resx").getroot().findall("data")
        }
        for name, value in {
            "selectedChannelName.ImeMode": "NoControl",
            "selectedChannelName.TextAlign": "MiddleLeft",
            "$this.AutoSizeMode": "GrowAndShrink",
            "selectedChannelName.Anchor": "Left",
        }.items():
            with self.subTest(name=name):
                self.assertEqual(resources[name].findtext("value"), value)
                self.assertNotIn("mimetype", resources[name].attrib)

    def test_image_list_stream_uses_binary_object_serialization(self):
        root = ET.parse(RESOURCE_FILE).getroot()
        resource = next(
            item
            for item in root.findall("data")
            if item.get("name") == "LogPlaybackImgList.ImageStream"
        )

        self.assertEqual(
            resource.get("mimetype"),
            "application/x-microsoft.net.object.binary.base64",
        )
        self.assertNotIn("type", resource.attrib)

        payload = base64.b64decode(resource.findtext("value"))
        self.assertIn(b"System.Windows.Forms.ImageListStreamer", payload)


if __name__ == "__main__":
    unittest.main()
