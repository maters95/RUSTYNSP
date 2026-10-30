"""Pure-Python LZO1X decompressor and lzop-stream reader (enough for an ARM
zImage built with CONFIG_KERNEL_LZO). No third-party module needed.
"""
import struct


def lzo1x_decompress(src, out_len_hint=0):
    out = bytearray()
    ip = 0
    n = len(src)

    def copy_match(dist, length):
        start = len(out) - dist
        if start < 0:
            raise ValueError("lzo: lookbehind overrun")
        for k in range(length):
            out.append(out[start + k])

    t = src[ip]
    state = 0
    if t > 17:
        ip += 1
        t -= 17
        out += src[ip:ip + t]
        ip += t
        state = 4 if t >= 4 else t
    while ip < n:
        t = src[ip]
        ip += 1
        if t < 16:
            if state == 0:
                if t == 0:
                    while src[ip] == 0:
                        t += 255
                        ip += 1
                    t += 15 + src[ip]
                    ip += 1
                t += 3
                out += src[ip:ip + t]
                ip += t
                state = 4
                continue
            elif state == 4:
                dist = 1 + 0x800 + (t >> 2) + (src[ip] << 2)
                ip += 1
                copy_match(dist, 3)
                s = t & 3
            else:
                dist = 1 + (t >> 2) + (src[ip] << 2)
                ip += 1
                copy_match(dist, 2)
                s = t & 3
        elif t >= 64:
            dist = 1 + ((t >> 2) & 7) + (src[ip] << 3)
            ip += 1
            length = (t >> 5) + 1
            copy_match(dist, length)
            s = t & 3
        elif t >= 32:
            length = t & 31
            if length == 0:
                while src[ip] == 0:
                    length += 255
                    ip += 1
                length += 31 + src[ip]
                ip += 1
            length += 2
            v = src[ip] | (src[ip + 1] << 8)
            ip += 2
            dist = 1 + (v >> 2)
            copy_match(dist, length)
            s = v & 3
        else:  # 16..31
            length = t & 7
            if length == 0:
                while src[ip] == 0:
                    length += 255
                    ip += 1
                length += 7 + src[ip]
                ip += 1
            length += 2
            v = src[ip] | (src[ip + 1] << 8)
            ip += 2
            dist = ((t & 8) << 11) + (v >> 2)
            s = v & 3
            if dist == 0:
                return bytes(out)  # end marker
            dist += 0x4000
            copy_match(dist, length)
        # trailing literals
        if s:
            out += src[ip:ip + s]
            ip += s
        state = s
    return bytes(out)


def lzop_stream(data):
    """Decode an lzop container (as the kernel's unlzo expects)."""
    if data[:9] != b"\x89LZO\x00\r\n\x1a\n":
        raise ValueError("not lzop")
    p = 9
    version, lib_version = struct.unpack_from(">HH", data, p)
    p += 4
    if version >= 0x0940:
        p += 2  # version needed
    method = data[p]
    p += 1
    if version >= 0x0940:
        p += 1  # level
    flags = struct.unpack_from(">I", data, p)[0]
    p += 4
    if flags & 0x800:
        p += 4  # filter
    p += 4 + 4 + 4  # mode, mtime_low, mtime_high
    namelen = data[p]
    p += 1 + namelen
    p += 4  # header checksum
    if flags & 0x40:
        p += 4  # extra field (unlikely)
    out = bytearray()
    while True:
        dst_len = struct.unpack_from(">I", data, p)[0]
        p += 4
        if dst_len == 0:
            break
        src_len = struct.unpack_from(">I", data, p)[0]
        p += 4
        if flags & 0x1:  # adler32 d
            p += 4
        if flags & 0x100:  # crc32 d
            p += 4
        if src_len < dst_len:
            if flags & 0x2:
                p += 4
            if flags & 0x200:
                p += 4
            out += lzo1x_decompress(data[p:p + src_len], dst_len)
        else:
            out += data[p:p + src_len]
        p += src_len
    return bytes(out)
