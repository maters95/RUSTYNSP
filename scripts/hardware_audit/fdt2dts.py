"""Minimal flattened-device-tree to DTS-like text decompiler (no dtc on the build host).

Prints every node and property; strings are shown quoted, cells as <0x..>,
phandles are annotated with the target node path.

Usage:
    python3 -I scripts/hardware_audit/fdt2dts.py FILE.dtb > out.dts
"""
import struct
import sys

FDT_BEGIN_NODE, FDT_END_NODE, FDT_PROP, FDT_NOP, FDT_END = 1, 2, 3, 4, 9


def parse(blob):
    magic, total, off_struct, off_strings, off_rsv, version, _, _, size_strings, size_struct = \
        struct.unpack_from(">10I", blob)
    if magic != 0xD00DFEED:
        raise ValueError("not an FDT")
    strings = blob[off_strings:off_strings + size_strings]
    pos = off_struct
    root = None
    stack = []
    while True:
        tok = struct.unpack_from(">I", blob, pos)[0]
        pos += 4
        if tok == FDT_BEGIN_NODE:
            end = blob.index(b"\0", pos)
            name = blob[pos:end].decode()
            pos = (end + 4) & ~3
            node = {"name": name, "props": [], "children": []}
            if stack:
                stack[-1]["children"].append(node)
            else:
                root = node
            stack.append(node)
        elif tok == FDT_END_NODE:
            stack.pop()
        elif tok == FDT_PROP:
            length, nameoff = struct.unpack_from(">II", blob, pos)
            pos += 8
            value = blob[pos:pos + length]
            pos = (pos + length + 3) & ~3
            pname = strings[nameoff:strings.index(b"\0", nameoff)].decode()
            stack[-1]["props"].append((pname, value))
        elif tok == FDT_NOP:
            continue
        elif tok == FDT_END:
            break
    return root


def phandles(node, path="", out=None):
    out = {} if out is None else out
    here = path + "/" + node["name"] if node["name"] else ""
    for name, value in node["props"]:
        if name in ("phandle", "linux,phandle") and len(value) == 4:
            out[struct.unpack(">I", value)[0]] = here or "/"
    for child in node["children"]:
        phandles(child, here, out)
    return out


def fmt(name, value, ph):
    if not value:
        return ""
    parts = value.split(b"\0")
    if value.endswith(b"\0") and all(p and all(32 <= c < 127 for c in p) for p in parts[:-1]):
        return " = " + ", ".join('"%s"' % p.decode() for p in parts[:-1])
    if len(value) % 4 == 0:
        cells = struct.unpack(">%dI" % (len(value) // 4), value)
        shown = []
        for c in cells:
            note = ""
            if name not in ("reg", "ranges", "clock-frequency") and c in ph and c > 0 and (
                    name.endswith("s") or name.endswith("-gpio") or name.endswith("-gpios") or "parent" in name
                    or name in ("pinctrl-0", "pinctrl-1", "pwms", "dmas", "phy-handle", "regulator", "clocks", "resets")
                    or name.endswith("-supply") or name.endswith("-handle")):
                note = "/*%s*/" % ph[c]
            shown.append("0x%x%s" % (c, note))
        return " = <" + " ".join(shown) + ">"
    return " = [" + value.hex(" ") + "]"


def dump(node, ph, depth=0, out=None):
    out = [] if out is None else out
    ind = "\t" * depth
    out.append(f"{ind}{node['name'] or '/'} {{")
    for name, value in node["props"]:
        out.append(f"{ind}\t{name}{fmt(name, value, ph)};")
    for child in node["children"]:
        dump(child, ph, depth + 1, out)
    out.append(f"{ind}}};")
    return out


def main():
    blob = open(sys.argv[1], "rb").read()
    root = parse(blob)
    print("\n".join(dump(root, phandles(root))))


if __name__ == "__main__":
    main()
