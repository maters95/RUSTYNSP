import base64
from pathlib import Path
import unittest
import xml.etree.ElementTree as ET


ROOT = Path(__file__).resolve().parents[2]
RESOURCE_FILE = ROOT / "nsp-rebuild/ns2.Control3.resx"


class NspResourceSerializationTests(unittest.TestCase):
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
