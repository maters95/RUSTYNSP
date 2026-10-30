"""Build small resource-only NEX packages encrypted the way the dash expects."""
import hashlib
import io
from pathlib import Path
import struct
import sys
import tarfile
import zipfile

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
import dash_layout

REPOSITORY = Path(__file__).resolve().parents[2]
MANIFEST = ('<NEX_FILE><PRODUCT pid="21" vid="11" hdefFile="ic-7.hdef">'
            '<FILE name="res_ic-7.qzip" /></PRODUCT></NEX_FILE>')


def watchdog():
    path = dash_layout.find_watchdog()
    if path is None:
        raise FileNotFoundError("The dash watchdog reference is required for NEX fixtures")
    return path


def encrypted_resources(members):
    """members: {name: bytes or (bytes, mtime)}; returns the encrypted stage body."""
    from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
    output = io.BytesIO()
    with tarfile.open(fileobj=output, mode="w", format=tarfile.GNU_FORMAT) as archive:
        for name, value in members.items():
            data, mtime = value if isinstance(value, tuple) else (value, 1790648083)
            info = tarfile.TarInfo(name)
            info.size = len(data)
            info.mtime = mtime
            info.mode = 0o666
            archive.addfile(info, io.BytesIO(data))
    body = output.getvalue()
    body += bytes(-len(body) % 16)
    key, vector = dash_layout.watchdog_parameters(watchdog())
    encryptor = Cipher(algorithms.AES(key), modes.CBC(vector)).encryptor()
    return encryptor.update(body) + encryptor.finalize()


def write_nex(path, members):
    """Write a resource-only NEX; returns (encrypted body, 16-byte wrapper metadata)."""
    body = encrypted_resources(members)
    metadata = hashlib.md5(body).digest()
    wrapped = struct.pack("<II4sIIII", 2, 0, bytes(4), 0x25000000, 128, 16384, 4000) + metadata + body
    with zipfile.ZipFile(path, "w") as archive:
        archive.writestr("manifest.xml", MANIFEST)
        archive.writestr("res_ic-7.qzip", wrapped)
        archive.writestr("ic-7.hdef", b"test migration definition")
    return body, metadata
