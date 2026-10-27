import argparse
from pathlib import Path
import re


def load_strings(root):
    candidates = list(root.glob("-Private*/D219*.cs"))
    if len(candidates) != 1:
        raise ValueError("Expected one NSP string-table source")
    source = candidates[0].read_text(encoding="utf-8-sig")
    initializer = re.search(r"Not supported: data\(([0-9A-Fa-f\s]+)\)", source)
    if initializer is None:
        raise ValueError("String-table byte initializer is unavailable")
    encoded = bytes.fromhex(initializer.group(1))
    if len(encoded) != 159990:
        raise ValueError(f"Unexpected string-table length: {len(encoded)}")
    decoded = bytes(value ^ (index & 255) ^ 0xAA for index, value in enumerate(encoded))
    methods = re.finditer(
        r"public static string (\w+)\(\)\s*\{\s*return _5\[\d+\] \?\? _6\(\d+, (\d+), (\d+)\);",
        source,
    )
    return {
        match.group(1): decoded[int(match.group(2)):int(match.group(2)) + int(match.group(3))].decode("utf-8")
        for match in methods
    }


def main():
    parser = argparse.ArgumentParser(description="Resolve selected obfuscated NSP source literals offline.")
    parser.add_argument("--source", type=Path, default=Path(__file__).resolve().parents[1] / "nsp_src")
    selection = parser.add_mutually_exclusive_group(required=True)
    selection.add_argument("--method", action="append")
    selection.add_argument("--match")
    args = parser.parse_args()
    strings = load_strings(args.source)
    pattern = re.compile(args.match, re.IGNORECASE) if args.match else None
    for method, value in strings.items():
        if (args.method and method in args.method) or (pattern and pattern.search(value)):
            print(f"{method}: {value!r}")


if __name__ == "__main__":
    main()