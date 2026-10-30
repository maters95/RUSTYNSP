"""Unpack a legacy U-Boot uImage (ARM zImage) and pull out the decompressed kernel,
its embedded .config (CONFIG_IKCONFIG), any appended/embedded FDT blobs and the
built-in command line.

Usage:
    python3 -I scripts/hardware_audit/kernel_extract.py fw/root/boot/uImage OUTDIR
"""
import gzip
import lzma
import struct
import sys
import zlib
from pathlib import Path


def try_decompress(data):
    for magic, fn in ((b"\x89LZO", "lzo"), (b"\x1f\x8b\x08", "gzip"), (b"\xfd7zXZ\x00", "xz"),
                      (b"\x5d\x00\x00", "lzma")):
        start = 0
        while True:
            i = data.find(magic, start)
            if i < 0:
                break
            try:
                if fn == "gzip":
                    d = zlib.decompressobj(31)
                    out = d.decompress(data[i:])
                elif fn == "xz":
                    out = lzma.LZMADecompressor().decompress(data[i:])
                elif fn == "lzma":
                    out = lzma.LZMADecompressor(format=lzma.FORMAT_ALONE).decompress(data[i:])
                else:
                    import runpy, os
                    lz = runpy.run_path(os.path.join(os.path.dirname(os.path.abspath(__file__)), "lzo1x.py"))
                    out = lz["lzop_stream"](data[i:])
                if len(out) > 1_000_000:
                    return fn, i, out
            except Exception:
                pass
            start = i + 1
    return None, None, None


def main():
    src, outdir = Path(sys.argv[1]), Path(sys.argv[2])
    outdir.mkdir(parents=True, exist_ok=True)
    blob = src.read_bytes()
    magic, hcrc, ts, size, load, ep, dcrc, os_, arch, typ, comp = struct.unpack_from(">7I4B", blob)
    name = blob[32:64].rstrip(b"\0").decode(errors="replace")
    print(f"uImage magic={magic:#x} size={size} load={load:#x} ep={ep:#x} type={typ} comp={comp} name={name!r}")
    zimage = blob[64:64 + size]
    method, offset, kernel = try_decompress(zimage)
    print(f"zImage payload: {method} at +{offset:#x}, {len(kernel)} bytes")
    (outdir / "Image").write_bytes(kernel)
    # IKCONFIG: "IKCFG_ST" + gzip + "IKCFG_ED"
    i = kernel.find(b"IKCFG_ST")
    if i >= 0:
        cfg = gzip.decompress(kernel[i + 8:kernel.find(b"IKCFG_ED", i)])
        (outdir / "kernel.config").write_bytes(cfg)
        print(f"embedded .config: {len(cfg)} bytes")
    else:
        print("no embedded .config")
    # FDTs anywhere in zImage or kernel
    n = 0
    for region, label in ((zimage, "zimage"), (kernel, "kernel")):
        start = 0
        while True:
            j = region.find(b"\xd0\x0d\xfe\xed", start)
            if j < 0:
                break
            total = struct.unpack_from(">I", region, j + 4)[0]
            if 0x100 < total < 0x40000 and struct.unpack_from(">I", region, j + 20)[0] in (16, 17):
                (outdir / f"{label}-fdt-{j:#x}.dtb").write_bytes(region[j:j + total])
                print(f"FDT in {label} at {j:#x}, {total} bytes")
                n += 1
            start = j + 4
    print(f"{n} FDT blobs")


if __name__ == "__main__":
    main()
