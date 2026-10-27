import argparse
import hashlib
import io
import json
from pathlib import Path
import struct
import tarfile
import zipfile

from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
from elftools.elf.elffile import ELFFile


def read_parameter(reference, name, index):
    with reference.open("rb") as stream:
        elf = ELFFile(stream)
        symbols = elf.get_section_by_name(".symtab")
        if symbols is None:
            raise ValueError("Reference executable has no symbol table")
        matches = symbols.get_symbol_by_name(name) or symbols.get_symbol_by_name(f"_ZL{len(name)}{name}")
        if not matches or len(matches) != 1:
            raise ValueError(f"Expected one {name} symbol")
        symbol = matches[0]
        section = elf.get_section(symbol["st_shndx"])
        offset = symbol["st_value"] - section["sh_addr"] + 16 * index
        if 16 * (index + 1) > symbol["st_size"]:
            raise ValueError(f"Parameter index exceeds {name} table")
        return section.data()[offset:offset + 16]


def decode_resource(reference, package):
    if len(package) < 44:
        raise ValueError("Resource wrapper is truncated")
    version, kind, address, alignment, block_size, timeout = struct.unpack_from("<II4xIIII", package)
    if version != 2 or address != 0x25000000:
        raise ValueError("Expected a v2 iC-7 resource payload at 0x25000000")
    body = package[44:]
    if len(body) % 16:
        raise ValueError("Resource body is not AES-block aligned")
    key = read_parameter(reference, "encryption_keys", 1)
    vector = read_parameter(reference, "initial_vectors", 1)
    decryptor = Cipher(algorithms.AES(key), modes.CBC(vector)).decryptor()
    decoded = decryptor.update(body) + decryptor.finalize()
    if zipfile.is_zipfile(io.BytesIO(decoded)):
        with zipfile.ZipFile(io.BytesIO(decoded)) as archive:
            failure = archive.testzip()
            if failure:
                raise ValueError(f"Resource archive CRC failed for {failure}")
            entries = [entry.filename for entry in archive.infolist()]
        archive_format = "zip"
    else:
        with tarfile.open(fileobj=io.BytesIO(decoded), mode="r:") as archive:
            members = archive.getmembers()
            entries = [member.name for member in members]
            for member in members:
                if member.isfile():
                    source = archive.extractfile(member)
                    if source is None or len(source.read()) != member.size:
                        raise ValueError(f"Resource archive member truncated: {member.name}")
        archive_format = "tar"
    metadata = package[28:44]
    report = {
        "wrapper_version": version, "kind": kind, "address": hex(address),
        "alignment": alignment, "block_size": block_size, "timeout": timeout,
        "encoded_bytes": len(body), "decoded_bytes": len(decoded),
        "archive_format": archive_format, "archive_integrity_valid": True, "entries": entries,
        "wrapper_metadata_matches_body_md5": hashlib.md5(body).digest() == metadata,
        "wrapper_metadata_matches_decoded_md5": hashlib.md5(decoded).digest() == metadata,
    }
    return decoded, report


def main():
    parser = argparse.ArgumentParser(description="Decode an owner's iC-7 resource payload offline using its reference updater.")
    parser.add_argument("package", type=Path)
    parser.add_argument("--reference", required=True, type=Path)
    parser.add_argument("--output", required=True, type=Path)
    args = parser.parse_args()
    decoded, report = decode_resource(args.reference, args.package.read_bytes())
    with args.output.open("xb") as destination:
        destination.write(decoded)
    print(json.dumps(report, indent=2))


if __name__ == "__main__":
    main()