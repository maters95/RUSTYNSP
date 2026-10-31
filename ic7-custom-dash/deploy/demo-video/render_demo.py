"""Render the owner's iC-7 demo video: SIMULATION, rendered from their map + the firmware QML.

Reproduces what the v2.36 application (ui_module::UIMain, decrypted nic-7) does:

* QQuickView with the dash's main.qml (r5) as root, canvas 860x480, setScreenSize,
  setDashVariant(11). On Linux main.qml itself squeezes x by 800/860, so the
  grabbed 860-wide window holds the 800-pixel panel image in its left 800 columns.
* Five unnamed UIScreen containers (QQuickItem parented to the root object),
  one per map screen, then each component's QML chosen by
  UIComponent::get_qml_file_from_gauge_type, parented to its screen, given its
  geometry and setGaugeProperties(...) + repaintAll() from the map settings.
* HalAlarmPopup.qml created after the screens (Alarm_Module), parented to the
  root, setDashVariant(11), z = 99, and reInitAlarmScreen(msg) every update with
  draw_alarms' message format.
* Screen changes: QQuickItem::setVisible(i == active) on the five containers.

Channel values come from ic7-emulator/engine_sim.py: the engine model encodes
the map's Generic CAN frames, the dash decode stores the channels, and the
alarm module evaluates the map's alarms. LED states follow leds.py (from the ELF).

Time is stepped at a fixed 1/FPS: GIFs (AnimatedImage) are advanced by their
own frame delays from the simulated clock, and HalSplash's 3.3 s timeout is
applied at simulated t = durationMs. Nothing depends on wall-clock speed.

Usage (needs an X server or xvfb-run for OpenGL):
    xvfb-run -a -s "-screen 0 1280x1024x24" python3 render_demo.py \
        [--housing PHOTO.jpg] [--geometry housing-geometry.json] [--out ic7-demo.mp4]
"""
import argparse
import json
import math
import os
from pathlib import Path
import struct
import subprocess
import sys
import tempfile
import urllib.parse

HERE = Path(__file__).resolve().parent
ROOT = HERE.parents[2]
sys.path.insert(0, str(HERE))
sys.path.insert(0, str(ROOT / "ic7-emulator"))

os.environ.setdefault("QML_XHR_ALLOW_FILE_READ", "1")
os.environ.setdefault("QT_QUICK_BACKEND", "")

from PIL import Image  # noqa: E402
from PyQt5.QtCore import QObject, QUrl, QVariant, QMetaObject, Q_ARG, Q_RETURN_ARG, Qt  # noqa: E402
from PyQt5.QtGui import QGuiApplication, QFontDatabase  # noqa: E402
from PyQt5.QtQml import QQmlComponent  # noqa: E402
from PyQt5.QtQuick import QQuickView, QQuickItem  # noqa: E402

import engine_sim  # noqa: E402
import housing as housing_module  # noqa: E402
import leds  # noqa: E402
import mapdata  # noqa: E402
import stage_dash  # noqa: E402

FPS = 30
CANVAS = (860, 480)
PANEL = (800, 480)

# ui_module::UIComponent::get_qml_file_from_gauge_type (0x1088a4): switch on type - 2.
GAUGE_QML = {2: "HalImage", 3: "HalNumeric", 4: "HalCircularHero", 5: "HalCircularRetro",
             6: "HalCircularRetro2", 7: "HalIndicator", 9: "HalBarLeft", 10: "HalBarRight",
             13: "HalBarHorizontalContinuous", 14: "HalBarHorizontal2", 15: "HalBarClassic",
             16: "HalCircularClassic", 17: "HalRetroNumeric", 18: "HalText",
             19: "HalBarHorizontalSegmented", 20: "HalBarVerticalSegmented",
             21: "HalBarVerticalContinuous"}
# set_all_colour_properties (0x10affc): property <- palette word at offset 4*i.
COLOUR_PROPS = ["halWarningColour", "halNumericValueColour", "halNumericLabelColour", "halNumericUnitColour",
                "halBarValueColour", "halBarLabelColour", "halBarTickColour", "halBarBackgroundColour",
                "halBarMarkingsColour", "halPeakNeedleColour", "halCircularNeedleColour",
                "halCircularMarkingsColour", "halCircularMarkingsWarnColour", "halCircularTickColour",
                "halCircularBackgroundColour", "halIndicatorOnColour", "halIndicatorOffColour"]
# Display unit strings (APPROXIMATION: the app's unit names come from virtual converters).
UNIT_TEXT = {256: "RPM", 512: "%", 768: "kPa", 769: "kPa", 773: "psi", 775: "psi", 1024: "km/h",
             1025: "mph", 1280: "°C", 1281: "°F", 1536: "λ", 1537: "AFR", 2048: "V",
             3328: "°", 0: ""}


def colour_string(word):
    """UIComponent::int_to_colour: '#' + the 32-bit word's bytes in memory order (AARRGGBB)."""
    return engine_sim.color_string(word)


class Device:
    """The minimal Device surface engine_sim.EngineSimulation needs."""

    def __init__(self, memory):
        import threading
        self.memory = memory
        self.lock = threading.RLock()
        self.boot_mode = False

    def rebooting(self):
        return False


def invoke(item, method, *args):
    qargs = [Q_ARG(QVariant, QVariant(a)) for a in args]
    return QMetaObject.invokeMethod(item, method, Qt.DirectConnection, Q_RETURN_ARG(QVariant), *qargs)


class Dash:
    def __init__(self, staged, settings, channels):
        self.staged = staged
        self.settings = settings
        self.channels = channels
        self.view = QQuickView()
        self.view.setResizeMode(QQuickView.SizeRootObjectToView)
        self.view.resize(*CANVAS)
        self.view.setColor(Qt.black)
        self.view.setFlags(Qt.FramelessWindowHint)
        self.view.show()
        self.view.setSource(QUrl.fromLocalFile(str(staged["main_qml"])))
        if self.view.status() != QQuickView.Ready:
            raise RuntimeError("main.qml failed: " + "; ".join(e.toString() for e in self.view.errors()))
        self.root = self.view.rootObject()
        invoke(self.root, "setScreenSize", CANVAS[0], CANVAS[1])
        invoke(self.root, "setDashVariant", 11)
        self.engine = self.view.engine()
        self.fonts = {}
        self.screens, self.components = [], []
        self.active = None
        for number in range(5):
            screen = QQuickItem()
            screen.setParentItem(self.root)
            screen.setVisible(False)
            self.view.engine().setObjectOwnership(screen, self.engine.CppOwnership)
            self.screens.append(screen)
        self._keep = []
        for number in range(5):
            for index in range(40):
                self._make_component(number, index)
        component = QQmlComponent(self.engine, QUrl.fromLocalFile(
            str(staged["user_components"] / "HalAlarmPopup.qml")))
        self.popup = component.create()
        if self.popup is None:
            raise RuntimeError("HalAlarmPopup failed: " + "; ".join(e.toString() for e in component.errors()))
        self._keep.append(component)
        self.popup.setParentItem(self.root)
        invoke(self.popup, "setDashVariant", 11)
        self.popup.setProperty("z", 99)

    # -- components -------------------------------------------------------------------------
    def _font_family(self, source, gauge_type):
        if not source:
            source = "h/CaviarDreams-Bold.ttf" if gauge_type == 5 else "h/D-DINCondensed-Bold-Dash.ttf"
        if source not in self.fonts:
            base = (self.staged["user_resources"] / "fonts") if source.startswith("u/") else \
                (self.staged["resources"] / "qml_components_data/fonts")
            font_id = QFontDatabase.addApplicationFont(str(base / source[2:]))
            families = QFontDatabase.applicationFontFamilies(font_id) if font_id >= 0 else []
            self.fonts[source] = families[0] if families else ""
        return self.fonts[source]

    @staticmethod
    def _image_path(source):
        # UIComponent::image_src_to_path: "../../../../user_resources/images/" for u/, stock images for h/.
        if not source:
            return ""
        if source.startswith("u/"):
            return "../../../../user_resources/images/" + source[2:]
        return "../../images/" + source[2:]

    def _make_component(self, screen, index):
        s = self.settings
        p = f"SCREEN_{screen}_COMP_{index}_"
        kind = s.int(p + "GAUGE_TYPE")
        name = GAUGE_QML.get(kind)
        if not name:
            return
        url = QUrl.fromLocalFile(str(self.staged["user_components"] / (name + ".qml")))
        component = QQmlComponent(self.engine, url)
        item = component.create()
        if item is None:
            raise RuntimeError(f"{name} failed: " + "; ".join(e.toString() for e in component.errors()))
        self._keep.append(component)
        item.setParentItem(self.screens[screen])
        item.setX(s.int(p + "X_POS")); item.setY(s.int(p + "Y_POS")); item.setZ(s.int(p + "Z_POS"))
        item.setWidth(s.int(p + "X_SIZE")); item.setHeight(s.int(p + "Y_SIZE"))
        units = s.int(p + "OVERRIDE_UNIT_TYPE")
        dp = s.int(p + "OVERRIDE_NUM_DP")
        conv = lambda raw: engine_sim.from_internal(raw, units) if units in engine_sim.CONVERTERS else raw  # noqa: E731
        props = {
            "halImageOpacity": s.int(p + "DAY_OPACITY"),
            "halImagePath": self._image_path(s.text(p + "IMAGE_SRC")),
            "halChanNameText": s.text(p + "LABEL_TEXT"),
            "halCompMinValue": conv(s.int(p + "OVERRIDE_DISPLAY_MIN")),
            "halCompMaxValue": conv(s.int(p + "OVERRIDE_DISPLAY_MAX")),
            "halCompWarnMinValue": conv(s.int(p + "OVERRIDE_WARN_MIN")),
            "halCompWarnMaxValue": conv(s.int(p + "OVERRIDE_WARN_MAX")),
            "halCompMinorTickCount": s.int(p + "MINOR_TICKS"),
            "halDecimalPlaces": dp,
            "halRawUnitType": units,
            "halUnitText": UNIT_TEXT.get(units, ""),
            "halFontFamily": self._font_family(s.text(p + "FONT_SRC"), kind),
            "halValueFontSize": s.int(p + "VALUE_FONT_SIZE"), "halValueFontAlign": s.int(p + "VALUE_ALIGNMENT"),
            "halChanNameFontSize": s.int(p + "LABEL_FONT_SIZE"), "halChanNameFontAlign": s.int(p + "LABEL_ALIGNMENT"),
            "halUnitFontSize": s.int(p + "UNIT_FONT_SIZE"), "halUnitFontAlign": s.int(p + "UNIT_ALIGNMENT"),
            "halTickFontSize": s.int(p + "TICKS_FONT_SIZE"), "halTickFontAlign": s.int(p + "TICKS_ALIGNMENT"),
            "halReverseNeedleDirection": s.int(p + "REVERSE_NEEDLE_DIRECTION"),
        }
        if s.int(p + "STEP_SIZE"):
            props["halCompStepSize"] = conv(s.int(p + "STEP_SIZE")) - conv(0) if units else s.int(p + "STEP_SIZE")
        if s.int(p + "START_ANGLE") != s.int(p + "END_ANGLE"):
            props["halStartAngle"] = s.int(p + "START_ANGLE") / 10.0
            props["halEndAngle"] = s.int(p + "END_ANGLE") / 10.0
        # Colours: the component palette when OVERRIDE_COLOURS, else the screen palette (day).
        if s.int(p + "OVERRIDE_COLOURS"):
            words = [s.memory.read(0x20000 + s.entry(p + "PALETTE_0_COLOUR_0")["addr"] + 4 * i, 4) for i in range(17)]
        else:
            base = s.entry(f"SCREEN_{screen}_PALETTE_0_COLOUR_0")["addr"]
            words = [s.memory.read(0x20000 + base + 4 * i, 4) for i in range(17)]
        for prop, word in zip(COLOUR_PROPS, words):
            props[prop] = colour_string(struct.unpack("<I", word)[0])
        props = {key: value for key, value in props.items() if value is not None}
        invoke(item, "setGaugeProperties", props)
        invoke(item, "repaintAll")
        channel = self.channels.get(s.int(p + "CHANNEL"))
        self.components.append({"item": item, "screen": screen, "channel": channel, "units": units,
                                "dp": dp, "kind": kind, "label": props["halChanNameText"]})

    # -- runtime --------------------------------------------------------------------------
    def set_screen(self, number):
        """UIMain::handle_screen_change: setVisible(i == active) on the five UIScreens."""
        self.active = number
        for index, screen in enumerate(self.screens):
            screen.setVisible(index == number)
        palette = self.settings.entry(f"SCREEN_{number}_PALETTE_0_COLOUR_0")["addr"]
        word = struct.unpack("<I", self.settings.memory.read(0x20000 + palette + 4 * 17, 4))[0]
        invoke(self.root, "setBgColour", colour_string(word))

    def update_values(self, memory):
        for comp in self.components:
            if comp["screen"] != self.active or comp["channel"] is None or comp["kind"] == 2:
                continue
            raw = struct.unpack("<i", memory.read(comp["channel"][0], 4))[0]
            error = engine_sim.channel_error(raw)
            value = engine_sim.from_internal(raw, comp["units"]) if comp["units"] in engine_sim.CONVERTERS else raw
            if error or value is None:
                value, text = 0.0, "---"
            else:
                text = f"{value:.{comp['dp']}f}"
            invoke(comp["item"], "setGaugeProperties", {"halRawValue": float(value), "halValueText": text})
            invoke(comp["item"], "repaintValue")


class GifClock:
    """Advance every AnimatedImage from the simulated clock using the GIF's own delays."""

    def __init__(self):
        self.delays = {}
        self.started = {}

    def _delays(self, url):
        if url not in self.delays:
            path = urllib.parse.unquote(QUrl(url).toLocalFile())
            frames = []
            try:
                with Image.open(path) as image:
                    while True:
                        frames.append(max(20, int(image.info.get("duration") or 100)))
                        image.seek(image.tell() + 1)
            except EOFError:
                pass
            except OSError:
                frames = [100]
            self.delays[url] = frames
        return self.delays[url]

    def step(self, root, now_ms):
        seen = set()
        for item in root.findChildren(QQuickItem, "animatedImage"):
            source = item.property("source").toString()
            if not source or item.property("status") != 1:  # Image.Ready
                continue
            visible = item.isVisible()
            key = id(item)
            seen.add(key)
            if not visible:
                self.started.pop(key, None)
                continue
            item.setProperty("playing", False)
            if key not in self.started or self.started[key][0] != source:
                self.started[key] = (source, now_ms)
            delays = self._delays(source)
            elapsed = (now_ms - self.started[key][1]) % sum(delays)
            frame = 0
            while elapsed >= delays[frame]:
                elapsed -= delays[frame]
                frame += 1
            if item.property("frameCount") and frame < item.property("frameCount"):
                item.setProperty("currentFrame", frame)
        for key in list(self.started):
            if key not in seen:
                del self.started[key]


IDLE_S, CLIMB_S, HOLD_S, TAIL_S = 9.6, 3.6, 3.4, 2.6


def scenario(rev_limit, tacho):
    """Idle, then a rev up to the limiter, held there, then back to idle (SIMULATED)."""
    phases = [{"mode": "idle", "duration": IDLE_S}]
    for step in range(9):    # 1.35 s: idle to ~6000 rpm
        phases.append({"mode": "hold", "duration": 0.15, "rpm": 1000 + 560 * (step + 1), "tps": 70})
    for step in range(15):   # 2.25 s: slower through the shift-light band up to the cut
        phases.append({"mode": "hold", "duration": 0.15, "rpm": 6000 + 150 * (step + 1), "tps": 100})
    phases.append({"mode": "hold", "duration": HOLD_S, "rpm": rev_limit + 600, "tps": 100})
    phases.append({"mode": "idle", "duration": TAIL_S})
    return engine_sim.normalise_scenario({
        "name": "demo-rev-to-limiter", "description": "SIMULATED idle and rev to the limiter",
        "start_coolant_c": 86.0, "loop": False, "ecu_rpm_channel": tacho,
        "engine": {"rev_limit": rev_limit, "idle_rpm": 900}, "phases": phases, "seed": 3})


def render(args):
    work = Path(args.work)
    work.mkdir(parents=True, exist_ok=True)
    entries, settings, written = mapdata.load(args.map, cache=work / "settings-cache.json")
    staged = stage_dash.stage(work / "dash", entries)
    channels = engine_sim.load_channel_table()
    app = QGuiApplication.instance() or QGuiApplication(sys.argv)
    house = housing_module.make_housing(args.housing, args.geometry)
    kfc = next(i for i in range(25) if settings.text(f"ALARMS_COMP_{i}_NAME").strip() == "KFC LIMITER")

    timeline = []  # (label, tacho)
    parts = [("as wired today: ECU RPM channel (0xE68) empty", False)]
    if not args.no_variant:
        parts.append(("variant: RPM also on the ECU RPM channel (e.g. tacho wired)", True))
    ffmpeg = subprocess.Popen(
        ["ffmpeg", "-y", "-loglevel", "error", "-f", "rawvideo", "-pix_fmt", "rgb24",
         "-s", f"{house.size[0]}x{house.size[1]}", "-r", str(FPS), "-i", "-",
         "-c:v", "libx264", "-preset", "slow", "-crf", str(args.crf), "-pix_fmt", "yuv420p",
         "-movflags", "+faststart", str(args.out)], stdin=subprocess.PIPE)
    poster = None
    log = []
    for part_index, (label, tacho) in enumerate(parts):
        dash = Dash(staged, settings, channels)
        memory_settings = settings.memory
        device = Device(memory_settings)
        # Fresh dash memory per part: map settings only, live channels empty (0).
        device.memory = mapdata.map_memory(entries, settings.settings)[0]
        sim = engine_sim.EngineSimulation(device, scenario(args.rev_limit, tacho))
        sim.start(threaded=False)
        gifs = GifClock()
        kfc_since = None
        splash_ms = 3300
        splash = dash.root.findChild(QObject, "startupSplash")
        timer = dash.root.findChild(QObject, "splashTimeout")
        dash.set_screen(args.hero_screen - 1)
        skip_s = 0.0 if part_index == 0 else IDLE_S - 1.5   # the variant starts on screen 5, just before the rev
        total_s = IDLE_S + CLIMB_S + HOLD_S + TAIL_S - skip_s
        frames = int(round((total_s) * FPS))
        if part_index > 0:
            # Fast-forward the simulation and splash (not recorded) to just before the rev.
            dash.set_screen(args.kfc_screen - 1)
            for _ in range(int(skip_s * FPS)):
                sim.tick(1.0 / FPS)
            if splash is not None:
                QMetaObject.invokeMethod(splash, "finish", Qt.DirectConnection)
        for frame_index in range(frames):
            t = skip_s + frame_index / FPS
            now_ms = int(round(t * 1000))
            if timer is not None and timer.property("running"):
                timer.setProperty("running", False)  # HalSplash's timeout, applied on the simulated clock
            if part_index == 0 and splash is not None and now_ms >= splash_ms and not splash.property("completed"):
                QMetaObject.invokeMethod(splash, "finish", Qt.DirectConnection)
            if part_index == 0 and t >= args.switch_at and dash.active != args.kfc_screen - 1:
                dash.set_screen(args.kfc_screen - 1)
            sim.tick(1.0 / FPS)
            dash.update_values(device.memory)
            message = sim.alarm_message_cache or "[]"
            invoke(dash.popup, "reInitAlarmScreen", message)
            dash.popup.setProperty("z", 99)
            app.processEvents()
            gifs.step(dash.root, now_ms)
            app.processEvents()
            image = dash.view.grabWindow()
            panel = Image.frombytes("RGBA", (image.width(), image.height()),
                                    image.convertToFormat(image.Format_RGBA8888).bits().asstring(
                                        image.width() * image.height() * 4)).convert("RGB")
            panel = panel.crop((0, 0, PANEL[0], PANEL[1]))
            active = [i for i in range(25) if sim.alarms.active[i]]
            led_colours = leds.led_states(device.memory, active, t)
            kfc_channel = channels[settings.int(f"ALARMS_COMP_{kfc}_CHANNEL")][0]
            rpm_can = engine_sim.from_internal(struct.unpack("<i", device.memory.read(kfc_channel, 4))[0], 256)
            phase = ("splash (HalSplash, ic7_splash.json)" if part_index == 0 and now_ms < splash_ms else
                     f"screen {dash.active + 1}")
            caption = [housing_module.CAPTION,
                       f"part {part_index + 1}: {label}",
                       f"{phase}  |  simulated RPM {rpm_can:.0f}" if isinstance(rpm_can, (int, float))
                       else f"{phase}"]
            frame = house.compose(panel, led_colours, [] if args.clean else caption)
            ffmpeg.stdin.write(frame.tobytes())
            if frame_index % 15 == 0:
                log.append({"part": part_index + 1, "t": round(t, 2), "screen": dash.active + 1,
                            "rpm": rpm_can, "alarms": [settings.text(f"ALARMS_COMP_{i}_NAME") for i in active],
                            "leds": sum(1 for c in led_colours if c)})
            if part_index == 0 and kfc in active:
                kfc_since = t if kfc_since is None else kfc_since
                # 0.6 s in: the banner GIF is past its partly transparent first frame.
                if poster is None and t >= kfc_since + 0.6:
                    poster = frame
            if args.frames_dir and frame_index % 30 == 0:
                Path(args.frames_dir).mkdir(parents=True, exist_ok=True)
                frame.save(Path(args.frames_dir) / f"p{part_index + 1}_{frame_index:04d}.png")
        sim.stop()
        dash.view.close()
        dash.view.deleteLater()
        app.processEvents()
    ffmpeg.stdin.close()
    if ffmpeg.wait() != 0:
        raise RuntimeError("ffmpeg failed")
    if poster is not None and args.poster:
        poster.save(args.poster, optimize=True)
    if args.log:
        Path(args.log).write_text(json.dumps(log, indent=1) + "\n", encoding="utf-8")


def main():
    parser = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    parser.add_argument("--map", type=Path, default=mapdata.DEFAULT_MAP)
    parser.add_argument("--housing", type=Path, help="Photo of the owner's iC-7 (not committed); default: drawn frame")
    parser.add_argument("--geometry", type=Path, default=HERE / "housing-geometry.json")
    parser.add_argument("--out", type=Path, default=HERE / "ic7-demo.mp4")
    parser.add_argument("--poster", type=Path, default=HERE / "ic7-demo-poster.png")
    parser.add_argument("--log", type=Path)
    parser.add_argument("--frames-dir", type=Path)
    parser.add_argument("--work", default=os.path.join(tempfile.gettempdir(), "ic7-demo-video-work"))
    parser.add_argument("--hero-screen", type=int, default=3, help="1-based screen with the CR-V image")
    parser.add_argument("--kfc-screen", type=int, default=5)
    parser.add_argument("--switch-at", type=float, default=6.6, help="Simulated time of the change to the KFC screen")
    parser.add_argument("--rev-limit", type=float, default=8050,
                        help="ECU rev limit (ASSUMPTION; not in the dash map; between KFC LIMITER 7900 and Overrev 8200)")
    parser.add_argument("--no-variant", action="store_true")
    parser.add_argument("--clean", action="store_true",
                        help="No caption text in the frame (for sharing; the README states it is a simulation)")
    parser.add_argument("--crf", type=int, default=24)
    render(parser.parse_args())


if __name__ == "__main__":
    main()
