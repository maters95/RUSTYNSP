import argparse
import json
import os
from pathlib import Path
import sys
import time
import urllib.request

from PyQt5.QtCore import QLibraryInfo, QObject, QTimer, QUrl, pyqtProperty, pyqtSignal, pyqtSlot
from PyQt5.QtGui import QGuiApplication
from PyQt5.QtQml import QQmlApplicationEngine, QQmlComponent


def configure_qt_dll_search():
    if os.name != "nt":
        return None
    binaries = QLibraryInfo.location(QLibraryInfo.BinariesPath)
    if not Path(binaries).is_dir():
        raise FileNotFoundError("The PyQt5 runtime DLL directory is missing: " + binaries)
    # QML's native plugin loader also needs PATH, unlike Python's extension loader.
    os.environ["PATH"] = binaries + os.pathsep + os.environ.get("PATH", "")
    return os.add_dll_directory(binaries)


def validate_media_qml(engine):
    component = QQmlComponent(engine)
    component.setData(b"import QtQuick 2.9\nimport QtMultimedia 5.9\nVideo {}", QUrl())
    if component.status() != QQmlComponent.Ready:
        errors = "\n".join(error.toString() for error in component.errors())
        raise RuntimeError(
            "The Python preview cannot load its own QtMultimedia runtime. "
            "Repair the emulator's PyQt5 environment; do not copy NSP's Qt 5.11 "
            "DLLs into the Python Qt 5.15 runtime.\n" + errors
        )


COMPONENTS = {
    2: "HalImage", 3: "HalNumeric", 4: "HalCircularClassic", 5: "HalCircularRetro",
    6: "HalCircularRetro2", 7: "HalIndicator", 9: "HalBarLeft", 10: "HalBarRight",
    13: "HalBarHorizontalContinuous", 14: "HalBarHorizontal2", 15: "HalBarClassic",
    16: "HalCircularHero", 17: "HalRetroNumeric", 18: "HalText",
    19: "HalBarHorizontalSegmented", 20: "HalBarVerticalSegmented", 21: "HalBarVerticalContinuous",
}


def component_record(record, base_url, revision, patched=False):
    values = record["values"]
    kind = values.get("GAUGE_TYPE", 0)
    component = COMPONENTS.get(kind)
    if not component:
        return None
    source = Path(__file__).with_name("qml") / "user_components" / (component + ".qml")
    if kind == 2 and patched:
        source = Path(__file__).with_name("qml") / "patched" / "HalImage.qml"

    def asset(name):
        if not name:
            return ""
        from urllib.parse import quote
        return base_url + "/asset?name=" + quote(name if name.startswith(("u/", "h/")) else "h/" + name) + "&revision=" + str(revision)

    props = {
        "x": values.get("X_POS", 0), "y": values.get("Y_POS", 0), "z": values.get("Z_POS", 0),
        "width": max(1, values.get("X_SIZE", 100)), "height": max(1, values.get("Y_SIZE", 60)),
        "halImageOpacity": values.get("DAY_OPACITY", 1000), "halImagePath": asset(values.get("IMAGE_SRC", "")),
        "halChanNameText": values.get("LABEL_TEXT", ""), "halValueText": "--", "halRawValue": 0,
        "halCompMinValue": 0, "halCompMaxValue": 100, "halUnitText": "",
    }
    mapping = {
        "VALUE_FONT_SIZE": "halValueFontSize", "VALUE_ALIGNMENT": "halValueFontAlign",
        "LABEL_FONT_SIZE": "halChanNameFontSize", "LABEL_ALIGNMENT": "halChanNameFontAlign",
        "UNIT_FONT_SIZE": "halUnitFontSize", "UNIT_ALIGNMENT": "halUnitFontAlign",
        "TICKS_FONT_SIZE": "halTickFontSize", "TICKS_ALIGNMENT": "halTickFontAlign",
        "STEP_SIZE": "halCompStepSize", "MINOR_TICKS": "halCompMinorTickCount",
        "OVERRIDE_NUM_DP": "halDecimalPlaces",
    }
    for field, prop in mapping.items():
        if field in values:
            props[prop] = values[field]
    colours = ["halWarningColour", "halNumericValueColour", "halNumericLabelColour", "halNumericUnitColour",
               "halBarValueColour", "halBarLabelColour", "halBarTickColour", "halBarMarkingsColour",
               "halBarBackgroundColour", "halPeakNeedleColour", "halCircularNeedleColour",
               "halCircularMarkingsColour", "halCircularMarkingsWarnColour", "halCircularTickColour",
               "halCircularBackgroundColour", "halIndicatorOnColour", "halIndicatorOffColour"]
    for index, prop in enumerate(colours):
        value = values.get(f"PALETTE_0_COLOUR_{index}")
        if value is not None:
            red, green, blue, alpha = (value & 0xFFFFFFFF).to_bytes(4, "little")
            props[prop] = f"#{alpha:02x}{red:02x}{green:02x}{blue:02x}"
    return {"index": record["index"], "source": QUrl.fromLocalFile(str(source.resolve())).toString(), "props": props}


NATIVE_ALARM_TEXT_LIMIT = 20


def native_alarm_message(alarms):
    """The popup message as Alarm_Module::draw_alarms builds it on the dash.

    Plain string concatenation (no JSON escaping) in the dash's field order,
    with at most 20 characters of each alarm name, so a quote in a name breaks
    the popup's JSON.parse exactly as it does on the dash. NSP's own renderer
    builds the same fields in a different order (text, bc, fc, height, img).
    """
    entries = [' { "text":"' + str(alarm["text"])[:NATIVE_ALARM_TEXT_LIMIT] + '", "bc": "' + alarm["bc"] +
               '", "height": "' + alarm["height"] + '", "img": "' + alarm["img"] + '", "fc": "' + alarm["fc"] + '" }'
               for alarm in alarms]
    return "[" + ",".join(entries) + "]"


def resource_url(name, base_url, revision):
    from urllib.parse import quote
    return base_url.rstrip("/") + "/asset?name=" + quote(name) + "&revision=" + str(revision)


def resource_api_url(name, base_url):
    from urllib.parse import urlencode
    return base_url.rstrip("/") + "/api/resource?" + urlencode({"kind": 0, "name": name})


class Bridge(QObject):
    changed = pyqtSignal()

    def __init__(self, url, patched=False, preview_alerts=(), alarm_tick_ms=50):
        super().__init__()
        self.alarm_tick_ms = alarm_tick_ms
        self.url = url.rstrip("/")
        self.patched = patched
        self.preview_alerts = tuple(preview_alerts)
        self.screen = 0
        self.value = json.dumps({"components": [], "display": {"phase": "blank"}, "status": "Connecting"})
        self.last = None
        self.last_poll = 0
        self.timer = QTimer(self)
        self.timer.timeout.connect(self.poll)
        self.timer.start(50)

    @pyqtProperty(str, notify=changed)
    def scene(self):
        return self.value

    @pyqtSlot(int)
    def setScreen(self, screen):
        self.screen = screen
        self.last = None

    def poll(self):
        try:
            with urllib.request.urlopen(self.url + f"/api/scene?screen={self.screen}", timeout=0.3) as response:
                state = json.load(response)
            display = state["display"]
            signature = (self.screen, tuple(state["revision"]), display["phase"], display["reboot_revision"])
            if signature == self.last:
                return
            display["splash_manifest"] = resource_api_url("u/ic7_splash.json", self.url)
            display["user_image_base"] = self.url + "/asset?name=u%2F"
            display["stock_image_base"] = self.url + "/asset?name=h%2F"
            if self.preview_alerts:
                from stock_renderer import alert_component_source
                source = alert_component_source()
                if not source.is_file():
                    raise FileNotFoundError("The shared alert-preview QML is missing: " + str(source))
                display["alert_component"] = QUrl.fromLocalFile(str(source.resolve())).toString()
                display["alert_manifest"] = resource_api_url("u/ic7_alerts.json", self.url)
                display["preview_alerts"] = [
                    {"text": name, "height": "60", "bc": "#a00000", "fc": "#ffffff", "img": ""}
                    for name in self.preview_alerts
                ]
                display["preview_alarm_message"] = native_alarm_message(display["preview_alerts"])
                display["alarm_tick_ms"] = self.alarm_tick_ms
            components = []
            unsupported = []
            for item in state["components"]:
                record = component_record(item, self.url, state["revision"][1], self.patched)
                if record:
                    components.append(record)
                elif item["values"].get("GAUGE_TYPE", 0):
                    unsupported.append(item["values"]["GAUGE_TYPE"])
            if display["phase"] == "blank":
                status = "Waiting for NSP to load a NEX map"
            elif display["phase"] == "splash":
                status = "Rebooting - splash"
            else:
                status = ("Stock QML - sensor values unavailable" if not self.patched
                          else "GIF candidate QML - sensor values unavailable")
            if unsupported and display["phase"] == "dash":
                status += " - unsupported types " + ",".join(map(str, sorted(set(unsupported))))
            if self.preview_alerts:
                status += " - SYNTHETIC ALERT PREVIEW (not live alarm evaluation)"
            self.value = json.dumps({"screen": self.screen, "components": components, "display": display, "status": status})
            self.last = signature
            self.changed.emit()
        except Exception as error:
            self.value = json.dumps({"components": [], "display": {"phase": "blank"},
                                     "status": "Disconnected: " + str(error)})
            self.last = None
            if time.monotonic() - self.last_poll > 2:
                self.changed.emit()
                self.last_poll = time.monotonic()


def main():
    parser = argparse.ArgumentParser(description="Live stock-QML component view of the iC-7 protocol simulator.")
    parser.add_argument("--url", default="http://127.0.0.1:8765")
    parser.add_argument("--patched-images", action="store_true")
    parser.add_argument("--screenshot", type=Path)
    parser.add_argument("--preview-alert", action="append", default=[],
                        help="Preview this exact active-alert text using the shared popup; synthetic, no device writes")
    parser.add_argument("--alarm-tick-ms", type=int, default=50,
                        help="Interval between reInitAlarmScreen calls (the dash calls it on every UIMain "
                             "update; its interval is a runtime value, so this is an approximation)")
    args = parser.parse_args()
    dll_directory = configure_qt_dll_search()
    app = QGuiApplication(sys.argv)
    engine = QQmlApplicationEngine()
    validate_media_qml(engine)
    bridge = Bridge(args.url, args.patched_images, args.preview_alert, args.alarm_tick_ms)
    engine.rootContext().setContextProperty("simulator", bridge)
    engine.load(QUrl.fromLocalFile(str(Path(__file__).with_name("qml") / "NativeDash.qml")))
    if not engine.rootObjects():
        return 1
    if args.screenshot:
        def screenshot():
            window = engine.rootObjects()[0]
            image = window.screen().grabWindow(window.winId())
            app.exit(0 if image.save(str(args.screenshot)) else 1)
        QTimer.singleShot(2500, screenshot)
    try:
        return app.exec_()
    finally:
        if dll_directory is not None:
            dll_directory.close()


if __name__ == "__main__":
    sys.exit(main())