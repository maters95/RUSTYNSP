"""Decode ic-7.hdef the way NSP does (scripts/inspect-nexmap.py read_definition) and
report, per hardware feature keyword, which settings (<S>) exist in the data model
and whether the NSP menu tree (<MenuNode sid=...>) exposes them.

A setting that exists but is never referenced by a MenuNode sid (directly, or as a
descendant setting of a referenced one) is "model-only": a Tier 1 candidate.

Usage:
    python3 scripts/hardware_audit/hdef_features.py --out DIR
"""
import argparse
import json
from pathlib import Path
import re
import runpy
import xml.etree.ElementTree as ET

ROOT = Path(__file__).resolve().parents[2]

KEYWORDS = {
    "camera": r"CAMERA",
    "ambient_light_night": r"AMBIENT|ALS_|_ALS|NIGHT|DAY_NIGHT|BRIGHTNESS|BACKLIGHT|DIM",
    "wifi_bt": r"WIFI|WI_FI|SSID|BLUETOOTH|_BT_|WIRELESS",
    "datalog": r"DATALOG|DATA_LOG|LOGGING",
    "lap_mylaps": r"LAP|MYLAPS|FLAG",
    "gps": r"GPS",
    "keypad": r"KEYPAD",
    "output_test": r"OUTPUT_TEST|TEST_MODE|OVERRIDE",
    "odometer_trip": r"ODOMETER|TRIP",
    "screenshot": r"SCREENSHOT",
    "buttons": r"BUTTON",
    "dpo_outputs": r"DPO|OUTPUT",
    "buzzer_led": r"BUZZ|LED|SHIFT_LIGHT|INDICATOR_LIGHT",
    "can_bus": r"CAN_?BUS|CAN[0-9]|CAN_BAUD|BAUD|TERMINATION|CAN_ECHO",
    "dash_broadcast": r"BROADCAST",
    "tacho_input": r"TACHO",
    "imu": r"IMU|ACCEL|GYRO",
    "time_rtc": r"RTC|CLOCK|TIME_ZONE|TIMEZONE",
    "power_rails": r"5V|SENSOR_POWER|EXTERNAL_5V|AVI|DPI",
}


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--out", type=Path, required=True)
    ap.add_argument("--hdef", type=Path, default=ROOT / "fw/x/ic-7.hdef")
    args = ap.parse_args()
    args.out.mkdir(parents=True, exist_ok=True)
    nexmap = runpy.run_path(str(ROOT / "scripts/inspect-nexmap.py"))
    entries = nexmap["read_definition"](args.hdef)
    xml = entries["structure.xml"]
    root = ET.fromstring(xml)

    settings = {}
    for s in root.iter("S"):
        settings[s.get("id")] = {"name": s.get("name"), "addr": s.get("addr"),
                                 "children": [c.get("id") for c in s.iter("S") if c is not s]}
    menu_sids = set()
    menu_paths = {}
    tree = root.find("MenuTree")

    def walk(node, path):
        for child in node.findall("MenuNode"):
            here = path + [child.get("name") or "?"]
            sid = child.get("sid")
            if sid:
                menu_sids.add(sid)
                menu_paths.setdefault(sid, " > ".join(here))
            walk(child, here)
    if tree is not None:
        walk(tree, [])
    # A MenuNode sid names an <O> UI object (ObjectId); its <P name="S<n>" id=...>
    # entries list the settings that page shows. Follow references transitively.
    objects = {}
    for o in root.iter("O"):
        oid = next((p.get("val") for p in o.findall("P") if p.get("name") == "ObjectId"), None)
        if oid:
            objects[oid] = [p.get("id") for p in o.findall("P")
                            if re.fullmatch(r"S\d+", p.get("name") or "") and p.get("id")]
    port_functions = set()
    if tree is not None:
        for node in tree.iter("MenuNode"):
            for p in node.findall("P"):
                if p.get("name") == "PortFunctionId":
                    port_functions.add(p.get("val"))
    exposed = set()
    pending = list(menu_sids | port_functions)
    while pending:
        sid = pending.pop()
        if sid in exposed:
            continue
        exposed.add(sid)
        exposed.update(settings.get(sid, {}).get("children", []))
        pending.extend(objects.get(sid, []))
        for child in settings.get(sid, {}).get("children", []):
            pending.extend(objects.get(child, []))
    for sid in list(exposed):
        if sid in menu_paths:
            for child in objects.get(sid, []):
                menu_paths.setdefault(child, menu_paths[sid])

    outline = []

    def outline_walk(node, depth):
        for child in node.findall("MenuNode"):
            if depth <= 2:
                outline.append("  " * depth + (child.get("name") or "?") +
                               (f"  [sid {child.get('sid')}]" if child.get("sid") else ""))
            outline_walk(child, depth + 1)
    if tree is not None:
        outline_walk(tree, 0)
    (args.out / "hdef-menu-outline.txt").write_text("\n".join(outline) + "\n")

    report = {"settings_total": len(settings), "menu_sids": len(menu_sids), "features": {}}
    for feature, pattern in KEYWORDS.items():
        rx = re.compile(pattern)
        hits = sorted(((sid, d["name"]) for sid, d in settings.items() if d["name"] and rx.search(d["name"])),
                      key=lambda x: x[1])
        report["features"][feature] = {
            "exposed": [f"{n} (S{sid}) -> {menu_paths.get(sid, 'child of exposed setting')}"
                        for sid, n in hits if sid in exposed],
            "model_only": [f"{n} (S{sid})" for sid, n in hits if sid not in exposed],
        }
    (args.out / "hdef-features.json").write_text(json.dumps(report, indent=1) + "\n")
    for f, d in report["features"].items():
        print(f"{f}: exposed {len(d['exposed'])}, model-only {len(d['model_only'])}")


if __name__ == "__main__":
    main()
