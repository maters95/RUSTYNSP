import runpy
from pathlib import Path
import struct
import subprocess
import sys
import tempfile
import unittest
import zipfile


ROOT = Path(__file__).resolve().parents[2]
sys.path.insert(0, str(ROOT / "ic7-emulator"))
from ic7_emulator import Device, INSTANT_TIMING, RESOURCE_ADDRESS, resource_descriptor, request


class ResourceUploadTests(unittest.TestCase):
    def test_chunk_progress_failure_and_cancellation(self):
        with tempfile.TemporaryDirectory(prefix="nsp-upload-") as directory:
            path = Path(directory)
            (path / "Test.csproj").write_text(f"""
<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net9.0</TargetFramework></PropertyGroup>
<ItemGroup><Compile Include="{ROOT}/nsp-rebuild/NSP/ResourceUpload.cs" /></ItemGroup>
</Project>
""")
            (path / "Program.cs").write_text("""
using System;
using System.Collections.Generic;
using System.IO;
using NSP;
byte[] data = new byte[10001];
new Random(7).NextBytes(data);
using var received = new MemoryStream();
var progress = new List<long>();
int writes = 0;
ResourceUpload.Send(data, 4028, (offset, fragment) => {
    if (offset != received.Length || fragment.Length > 4028) throw new Exception("Chunk shape");
    received.Write(fragment);
    writes++;
}, (offset, total) => {
    if (total != data.Length) throw new Exception("Progress total");
    progress.Add(offset);
});
if (writes != 3 || !data.AsSpan().SequenceEqual(received.ToArray()) ||
    progress.Count != 4 || progress[0] != 0 || progress[^1] != data.Length)
    throw new Exception("Transfer/progress");
foreach (int chunk in new[] {0, -1}) {
    try { ResourceUpload.Send(data, chunk, (_, _) => throw new Exception("Invalid transfer invoked")); throw new Exception("Invalid size accepted"); }
    catch (IOException) {}
}
writes = 0;
try {
    ResourceUpload.Send(data, 1000, (_, _) => { writes++; throw new IOException("Device rejected at 0"); });
    throw new Exception("Failure accepted");
} catch (IOException error) { if (error.Message != "Device rejected at 0" || writes != 1) throw; }
writes = 0;
try {
    ResourceUpload.Send(data, 1000, (_, _) => { writes++; }, cancelled: () => writes >= 1);
    throw new Exception("Cancellation ignored");
} catch (OperationCanceledException) { if (writes != 1) throw; }
writes = 0;
ResourceUpload.Send(Array.Empty<byte>(), 1000, (offset, fragment) => {
    if (offset != 0 || fragment.Length != 0) throw new Exception("Empty upload");
    writes++;
});
if (writes != 1) throw new Exception("Empty upload not finalized");
Console.WriteLine("Chunking, acknowledged progress, bounded failure and cancellation passed");
""")
            result = subprocess.run(["dotnet", "run", "--project", str(path / "Test.csproj")],
                                    capture_output=True, text=True, timeout=120)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)

    def test_actual_map_resources_and_splash_upload_complete(self):
        bundle = ROOT / "dist/ic7-nsp-native-media-alerts-test-2.36.zip"
        if not bundle.is_file():
            self.skipTest("Retain the original supplied-map test bundle")
        inspector = runpy.run_path(str(ROOT / "scripts/inspect-nexmap.py"))
        with tempfile.TemporaryDirectory(prefix="ic7-map-upload-") as directory:
            path = Path(directory)
            with zipfile.ZipFile(bundle) as archive:
                names = [name for name in archive.namelist() if name.startswith("map/") and name.endswith(".nexmap")]
                self.assertEqual(len(names), 1)
                map_path = path / "original.nexmap"
                map_path.write_bytes(archive.read(names[0]))
            entries = inspector["read_map"](map_path)
            # The dash restarts its application on 0000 (about 2 s); model it instantly.
            device = Device(ROOT / "ic7-emulator/device-profile.zip", path / "state", timing=INSTANT_TIMING)
            largest = 0
            count = 0

            def upload(name, kind, payload):
                descriptor = resource_descriptor(name, kind, payload)
                for offset in range(0, len(payload), 4028):
                    fragment = payload[offset:offset + 4028]
                    command = b"\x06\0\0\0" + descriptor + struct.pack(">I", offset) + fragment
                    packet = request(1, count % 256, RESOURCE_ADDRESS, len(command), command)
                    reply = device.respond(packet)
                    self.assertEqual(reply[12:-4], b"\0", f"{name} rejected at {offset}/{len(payload)}")
                    if offset == 4028 or offset + len(fragment) == len(payload):
                        self.assertEqual(device.respond(packet), reply, "Lost ACK retry must succeed")
                self.assertEqual(device.resources.items[(kind, name)], payload)

            for name, payload in entries.items():
                if not name.startswith("user_resources/"):
                    continue
                _, category, filename = name.split("/", 2)
                kind = {"images": 0, "fonts": 1}[category]
                upload("u/" + filename, kind, payload)
                largest = max(largest, len(payload))
                count += 1
            self.assertGreater(largest, 32 * 1024 * 1024)
            self.assertGreater(count, 30)
            upload("u/bolivian-car-bolivia.gif", 0,
                   entries["user_resources/images/bolivian-car-bolivia.gif"])
            upload("u/ic7_splash.json", 0,
                   b'{"version":1,"source":"u/bolivian-car-bolivia.gif","durationMs":3000}')
            device.map_loaded = True
            device.respond(request(1, 1, 0, 2, b"\0\0"))
            self.assertEqual(device.display_state()["splash_source"], "u/bolivian-car-bolivia.gif")
            self.assertEqual(device.display_state()["phase"], "splash")


if __name__ == "__main__":
    unittest.main()
