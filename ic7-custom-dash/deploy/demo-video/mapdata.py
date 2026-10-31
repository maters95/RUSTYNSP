"""SIMULATION SUPPORT: the owner's .nexmap as the dash's settings memory.

Reads the AES map with the repository's own decoder (scripts/inspect-nexmap.py),
decodes the v2.36 definition (fw/ic7_2360.hdef) for each setting's MRAM
address, type and dimensions, and writes every ``attrId="0"`` value at
``0x20000 + addr`` the way NSP does: the map stores each element big-endian,
the dash keeps it little-endian (verified against the captured
ic7-emulator/device-profile.zip memory: 4394 four-byte and 1900 two-byte
settings match only when reversed per element, one-byte and string values
match as stored).

Nothing here is written back to the map or to any dash.
"""
import json
from pathlib import Path
import re
import runpy
import sys
import xml.etree.ElementTree as ElementTree

ROOT = Path(__file__).resolve().parents[3]
sys.path.insert(0, str(ROOT / "ic7-emulator"))
from ic7_emulator import Memory  # noqa: E402

SETTINGS_BASE = 0x20000
DEFAULT_MAP = ROOT / "dist/ic7-real-dash-pathfix-2026-10-29/KFC-screen-5-restored.ic7-2-36-0.nexmap"
DEFAULT_HDEF = ROOT / "fw/ic7_2360.hdef"


def _inspector():
    return runpy.run_path(str(ROOT / "scripts/inspect-nexmap.py"))


def definition_settings(hdef=DEFAULT_HDEF, cache=None):
    """{setting id: {name, addr, type, dims, mem, units, lists}} from the HDEF structure."""
    if cache and Path(cache).is_file():
        return json.loads(Path(cache).read_text(encoding="utf-8"))
    structure = _inspector()["read_definition"](Path(hdef))["structure.xml"]
    root = ElementTree.fromstring(structure)
    settings = {}
    for element in root.iter("S"):
        entry = {"name": element.get("name"), "addr": int(element.get("addr") or -1),
                 "type": None, "dims": None, "mem": None, "long": "", "lists": {}}
        for prop in element:
            if prop.tag != "P":
                continue
            name = prop.get("name")
            if name == "Type":
                entry["type"] = int(prop.get("val"))
            elif name == "Dimensions":
                entry["dims"] = prop.get("val")
            elif name == "_sgid":
                entry["mem"] = prop.get("_memType")
            elif name == "LongName":
                entry["long"] = prop.text or ""
            elif name and name.startswith("ListItem_") and prop.get("_text") is not None:
                entry["lists"][prop.get("val")] = prop.get("_text")
        settings[element.get("id")] = entry
    if cache:
        Path(cache).write_text(json.dumps(settings), encoding="utf-8")
    return settings


def read_map(path=DEFAULT_MAP):
    return _inspector()["read_map"](Path(path))


def element_size(entry, payload_length):
    kind = entry.get("type")
    if kind is None:
        return payload_length if payload_length <= 4 else 1
    return max(1, abs(kind) // 8)


def map_memory(entries, settings):
    """A Memory holding every map setting at its MRAM address, as NSP writes it."""
    memory = Memory()
    data = ElementTree.fromstring(entries["_map"]).find("Data")
    written = 0
    for element in data:
        if element.get("attrId") != "0":
            continue
        entry = settings.get(element.get("id"))
        if not entry or entry["mem"] != "MRAM_EE" or entry["addr"] < 0:
            continue
        payload = bytes.fromhex(element.text or "")
        size = element_size(entry, len(payload))
        if size > 1 and len(payload) % size == 0:
            payload = b"".join(payload[i:i + size][::-1] for i in range(0, len(payload), size))
        memory.write(SETTINGS_BASE + entry["addr"], payload)
        written += 1
    return memory, written


class MapSettings:
    """Named access to the decoded map settings."""

    def __init__(self, memory, settings):
        self.memory = memory
        self.settings = settings
        self.by_name = {}
        for key, entry in settings.items():
            if entry["mem"] == "MRAM_EE":
                self.by_name.setdefault(entry["name"], dict(entry, id=int(key)))

    def entry(self, name):
        return self.by_name[name]

    def raw(self, name, length=None):
        entry = self.by_name[name]
        if length is None:
            length = element_size(entry, 4)
            match = re.findall(r"\d+", entry.get("dims") or "")
            if match:
                count = 1
                for part in match:
                    count *= int(part)
                length *= count
        return self.memory.read(SETTINGS_BASE + entry["addr"], length)

    def int(self, name):
        entry = self.by_name[name]
        size = element_size(entry, 4)
        return int.from_bytes(self.raw(name, size), "little", signed=(entry.get("type") or 0) < 0)

    def text(self, name):
        return self.raw(name).split(b"\0", 1)[0].decode("utf-8", "replace")

    def list_text(self, name):
        return self.by_name[name]["lists"].get(str(self.int(name)))


def load(map_path=DEFAULT_MAP, hdef=DEFAULT_HDEF, cache=None):
    settings = definition_settings(hdef, cache)
    entries = read_map(map_path)
    memory, written = map_memory(entries, settings)
    return entries, MapSettings(memory, settings), written
