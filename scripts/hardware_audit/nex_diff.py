"""Independent byte-level comparison of iC-7 resource NEX candidates against stock v2.36.

Decodes each package's res_ic-7.qzip with scripts/decode-nsp-resources.py (the
same codec scripts/audit-nex.py uses), then compares the ZIP container, the
manifest, the 44-byte wrapper, the HDEF and every tar member header
(name, type, mode, owner, mtime, size, content) with stock.

Usage:
    python3 -I scripts/hardware_audit/nex_diff.py --out DIR CANDIDATE.nex [...]
"""
import argparse
import hashlib
import io
import json
from pathlib import Path
import runpy
import struct
import tarfile
import zipfile

ROOT = Path(__file__).resolve().parents[2]
STOCK = ROOT / "fw/Dash-V2-36-0-Release.nex"
REFERENCE = ROOT / "fw/opt/dtn/app/dash_watchdog"


def decode(codec, package):
    with zipfile.ZipFile(package) as z:
        payload = z.read("res_ic-7.qzip")
        info = {i.filename: {"size": i.file_size, "compress": i.compress_type,
                             "crc": hex(i.CRC), "flag_bits": i.flag_bits,
                             "create_system": i.create_system, "extract_version": i.extract_version}
                for i in z.infolist()}
        manifest = z.read("manifest.xml")
        hdef = z.read("ic-7.hdef")
        bad = z.testzip()
    decoded, report = codec["decode_resource"](REFERENCE, payload)
    wrapper = struct.unpack_from("<7I", payload)
    return {"payload": payload, "decoded": decoded, "report": report, "zip": info,
            "manifest": manifest, "hdef": hdef, "zip_crc_ok": bad is None,
            "wrapper_words": [hex(w) for w in wrapper], "wrapper_md5": payload[28:44].hex()}


def tar_index(data):
    out = {}
    with tarfile.open(fileobj=io.BytesIO(data), mode="r:") as tar:
        for m in tar.getmembers():
            body = tar.extractfile(m).read() if m.isfile() else b""
            out[m.name] = {"type": m.type.decode(), "mode": oct(m.mode), "uid": m.uid, "gid": m.gid,
                           "uname": m.uname, "gname": m.gname, "mtime": m.mtime, "size": m.size,
                           "sha256": hashlib.sha256(body).hexdigest() if m.isfile() else None}
    return out


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("candidates", nargs="+", type=Path)
    ap.add_argument("--out", type=Path, required=True)
    args = ap.parse_args()
    args.out.mkdir(parents=True, exist_ok=True)
    codec = runpy.run_path(str(ROOT / "scripts/decode-nsp-resources.py"))
    stock = decode(codec, STOCK)
    stock_tar = tar_index(stock["decoded"])
    (args.out / "stock.tar").write_bytes(stock["decoded"])
    result = {"stock": {"sha256": hashlib.sha256(STOCK.read_bytes()).hexdigest(),
                        "wrapper": stock["wrapper_words"], "wrapper_md5": stock["wrapper_md5"],
                        "decoded_bytes": len(stock["decoded"]), "members": len(stock_tar),
                        "first_member_magic": stock["decoded"][257:265].hex()}}
    for cand in args.candidates:
        c = decode(codec, cand)
        (args.out / (cand.stem + ".tar")).write_bytes(c["decoded"])
        ct = tar_index(c["decoded"])
        diff = {"changed": {}, "added": {}, "removed": sorted(stock_tar.keys() - ct.keys()),
                "header_only_changes": {}}
        for name, h in ct.items():
            s = stock_tar.get(name)
            if s is None:
                diff["added"][name] = h
            elif s["sha256"] != h["sha256"]:
                diff["changed"][name] = {"stock": s, "candidate": h}
            elif s != h:
                diff["header_only_changes"][name] = {"stock": s, "candidate": h}
        order_stock = list(stock_tar)
        order_cand = [n for n in ct if n in stock_tar]
        result[str(cand.resolve().relative_to(ROOT))] = {
            "sha256": hashlib.sha256(cand.read_bytes()).hexdigest(),
            "zip_entries": c["zip"], "zip_crc_ok": c["zip_crc_ok"],
            "manifest": c["manifest"].decode("utf-8-sig"),
            "hdef_identical_to_stock": c["hdef"] == stock["hdef"],
            "hdef_sha256": hashlib.sha256(c["hdef"]).hexdigest(),
            "wrapper_words": c["wrapper_words"],
            "wrapper_first_28_identical": c["payload"][:28] == stock["payload"][:28],
            "wrapper_md5_field": c["wrapper_md5"],
            "wrapper_md5_matches_body": c["report"]["wrapper_metadata_matches_body_md5"],
            "wrapper_md5_matches_decoded": c["report"]["wrapper_metadata_matches_decoded_md5"],
            "decoded_bytes": len(c["decoded"]), "decoded_mod_10240": len(c["decoded"]) % 10240,
            "first_member_magic": c["decoded"][257:265].hex(),
            "stock_member_order_preserved": order_cand == order_stock,
            "members": len(ct), "diff": diff,
        }
    text = json.dumps(result, indent=1, sort_keys=False)
    (args.out / "nex-diff.json").write_text(text + "\n")
    print(text)


if __name__ == "__main__":
    main()
