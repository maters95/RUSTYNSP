"""SIMULATION ONLY: a simulated running engine fed to the virtual dash as Generic CAN frames.

Nothing here comes from a real engine. The emulator generates engine values,
encodes them as the CAN frames the map's Generic CAN settings describe, and
decodes those frames the way the iC-7 v2.36 application does
(``can::GenericCAN::update_signals_for_frame``): raw bits, then
``raw * multiplier + offset`` in float32, then the unit's
``convert_from_float_*`` into the 32-bit channel the dash stores at
``0x6250 + 800 * bus + 4 * signal``. NSP reads those channels with its normal
live-data polling of 0x1400-0x7fe4, and the renderer receives the same block.

The dash's alarm module (``Alarm_Module::process_alarms_and_shift_lights``)
is reproduced from the same ELF: thresholds, enables, the 450 rpm engine gate
on the ECU RPM channel (0xe68), clear-after-seconds, manual clear mode, the
alarm-active channels at 0x5818 and the popup message ``draw_alarms`` builds.
"""
from dataclasses import dataclass, field
import json
import logging
import math
from pathlib import Path
import random
import re
import struct
import threading
import time


SETTINGS_BASE = 0x20000
LIVE_START, LIVE_END = 0x1400, 0x7FE4
# The definition gives live channels as offsets into the dash's chan_mem; NSP reads chan_mem
# through USB address 0x1400 + offset (memory space 33 base 5120; battery voltage at 0x3CF8 is
# polled at 0x5014 in the captures). Every channel address below is the USB address.
CHANNEL_BASE = 0x1400
RPM_CHANNEL = CHANNEL_BASE + 0x0E68      # setting 384 RPM (TRIGGER_SYSTEM), the alarm module's engine gate
BATTERY_CHANNEL = CHANNEL_BASE + 0x3CF8  # setting 387 "Device Battery Voltage" (the dash's own supply input)
ALARM_ACTIVE = CHANNEL_BASE + 0x5818     # settings 60005-60029 "Current state of alarm N"
ALARM_COUNT = 25
ALARM_STRIDE = 76
ALARM_BASE = 476564             # ALARMS_COMP_0_NAME (MRAM offset)
ENGINE_RUNNING_RPM = 450        # "Disable this alarm when engine below 450RPM": rpm > 449
RX_TIMEOUT_MS = 2000            # check_for_rx_timeouts: 0x7d0
DEVICE_TIME_OUT = 0x80000004    # ListItem_device_time_out
SETTING_INVALID = 0x8000001E    # ListItem_setting_invalid (no converter for the units)
NO_SIGNAL = 0x8000001F          # ListItem_no_signal
SIMULATION_LABEL = "ENGINE SIMULATION"
DEFAULT_LAYOUT = Path(__file__).resolve().parent.parent / "ic7-custom-dash/resources/emtron_can.json"
BUNDLED_LAYOUT = Path(__file__).resolve().with_name("emtron_can.json")
CHANNEL_TABLE = Path(__file__).resolve().with_name("dash-channels.json")
log = logging.getLogger("ic7")


@dataclass(frozen=True)
class BusLayout:
    """Where one Generic CAN bus keeps its settings (MRAM offsets) and channels."""
    name: str
    nsp_bus: int
    enable: int
    frame_name: int
    frame_can_id: int
    frame_enabled_length: int
    frame_transmit_rate: int
    signal_name: int
    signal_id: int
    signal_channel_type: int
    signal_start_bit: int
    signal_bit_length: int
    signal_format: int
    signal_sign: int
    signal_multiplier: int
    signal_offset: int
    signal_units: int
    outputs: int
    realtime_data: int
    realtime_can_id: int


def _bus(index, name, nsp_bus):
    return BusLayout(name, nsp_bus, 6740 + 4 * index, 610744 + 900 * index, 478552 + 180 * index,
                     478672 + 180 * index, 478702 + 180 * index, 613444 + 6000 * index,
                     479092 + 4200 * index, 479492 + 4200 * index, 480492 + 4200 * index,
                     480692 + 4200 * index, 480892 + 4200 * index, 481092 + 4200 * index,
                     481292 + 4200 * index, 482092 + 4200 * index, 482892 + 4200 * index,
                     CHANNEL_BASE + 0x6250 + 800 * index, CHANNEL_BASE + 0x6BB0 + 12 * index,
                     CHANNEL_BASE + 0x6BB8 + 12 * index)


# GENERIC_CAN_HALTECH_*, GENERIC_CAN_VEHICLE_*, GENERIC_CAN_THIRD_PARTY_* in the v2.36 definition.
BUSES = (_bus(0, "Haltech CAN", 0), _bus(1, "Vehicle CAN", 1), _bus(2, "Third Party CAN", 4))
FRAMES_PER_BUS = 30
SIGNALS_PER_BUS = 200


def f32(value):
    return struct.unpack("<f", struct.pack("<f", value))[0]


# convert_from_float_<unit>: internal = trunc(post + (value + pre) * scale), all in float32.
CONVERTERS = {
    0: (0.0, None, 0.0), 256: (0.0, None, 0.0), 512: (0.0, 10.0, 0.0),
    768: (101.30000305175781, 10.0, 0.0), 769: (0.0, 10.0, 0.0), 770: (0.0, None, 0.0),
    771: (0.0, 1000.0, 0.0), 772: (0.0, 980.661376953125, 1013.0),
    773: (14.692319869995117, 68.94758605957031, 0.0), 774: (0.0, 68.94758605957031, 1013.0),
    775: (0.0, 68.94744873046875, 0.0), 1024: (0.0, 10.0, 0.0), 1025: (0.0, 16.09343910217285, 0.0),
    1280: (0.0, 10.0, 2731.0), 1281: (-32.0, 5.55555534362793, 2731.0), 1536: (0.0, 1000.0, 0.0),
    1537: (0.0, 68.02721405029297, 0.0), 1538: (0.0, 154.55950927734375, 0.0),
    1539: (0.0, 111.11111450195312, 0.0), 2048: (0.0, 1000.0, 0.0), 3328: (0.0, 10.0, 0.0),
}
UNIT_NAMES = {0: "", 256: "rpm", 512: "%", 768: "kPa", 769: "kPa abs", 770: "mbar abs", 771: "bar abs",
              772: "kg/cm2", 773: "psi", 774: "psi/inHg", 775: "psi abs", 1024: "km/h", 1025: "mph",
              1280: "C", 1281: "F", 1536: "lambda", 1537: "AFR-P", 1538: "AFR-M", 1539: "AFR-E",
              2048: "V", 3328: "deg"}
# emtron_can.json unit strings -> NSP unit list values (the units NSP shows for that signal).
JSON_UNITS = {"rpm": 256, "psi": 773, "c": 1280, "%": 512, "lambda": 1536, "deg": 3328, "km/h": 1024,
              "kpa": 768, "v": 2048, "": 0, "f": 1281, "mph": 1025}


def truncate_int32(value):
    if math.isnan(value):
        return 0
    return int(max(-2147483648, min(2147483647, math.trunc(value))))


def to_internal(value, units):
    """The dash's convert_from_float for a unit, or None when it has no converter."""
    if units not in CONVERTERS:
        return None
    pre, scale, post = CONVERTERS[units]
    value = f32(f32(value) + f32(pre))
    if scale is not None:
        value = f32(f32(post) + f32(value * f32(scale)))
    return truncate_int32(value)


def from_internal(value, units):
    """Engineering value of a stored channel (display only)."""
    if units not in CONVERTERS or value >= 0x80000000 or value < -0x7FFFFF00:
        return None
    pre, scale, post = CONVERTERS[units]
    return (value - post) / (scale or 1.0) - pre


def signed32(value):
    return value - (1 << 32) if value & 0x80000000 else value


def channel_error(value):
    names = {DEVICE_TIME_OUT: "Device Time Out", SETTING_INVALID: "Setting has invalid value",
             NO_SIGNAL: "No Signal", 0x80000002: "No I/O", 0x80000005: "Error"}
    return names.get(value & 0xFFFFFFFF)


# --- Signal bit layout (NSP CANSignalModel.RawValue and the dash's extract/insert) ---

def extract(data, start, length, big_endian, signed):
    word = int.from_bytes(bytes(data).ljust(8, b"\0")[:8], "little")
    if not big_endian:
        raw = (word >> start) & ((1 << length) - 1) if length < 64 else word
    else:
        raw, bit = 0, start
        for _ in range(length):
            raw = (raw << 1) | ((word >> (bit // 8 * 8 + bit % 8)) & 1)
            bit = bit - 1 if bit % 8 else bit + 15
    if signed and length and raw & (1 << (length - 1)):
        raw -= 1 << length
    return raw


def insert(data, start, length, big_endian, raw):
    word = int.from_bytes(bytes(data).ljust(8, b"\0")[:8], "little")
    raw &= (1 << length) - 1
    if not big_endian:
        mask = ((1 << length) - 1) << start
        word = (word & ~mask) | (raw << start)
    else:
        bit = start
        for index in range(length):
            value = (raw >> (length - 1 - index)) & 1
            position = bit // 8 * 8 + bit % 8
            word = (word & ~(1 << position)) | (value << position)
            bit = bit - 1 if bit % 8 else bit + 15
    return bytearray(word.to_bytes(8, "little"))


@dataclass
class Signal:
    name: str
    index: int
    frame: int
    start: int
    length: int
    big_endian: bool
    signed: bool
    multiplier: float
    offset: float
    units: int
    channel: int
    channel_id: int | None = None

    @property
    def unit_name(self):
        return UNIT_NAMES.get(self.units, f"unit {self.units}")

    def raw_limits(self):
        if self.signed:
            return -(1 << (self.length - 1)), (1 << (self.length - 1)) - 1
        return 0, (1 << self.length) - 1

    def encode(self, value):
        """Raw integer an ECU would send for an engineering value in this signal's units."""
        if not self.multiplier:
            return 0
        low, high = self.raw_limits()
        return int(max(low, min(high, round((value - self.offset) / self.multiplier))))

    def decode(self, data):
        """The dash's update_signals_for_frame for this signal: the stored channel value."""
        raw = extract(data, self.start, self.length, self.big_endian, self.signed and self.length <= 32)
        value = f32(f32(self.offset) + f32(f32(float(raw)) * f32(self.multiplier)))
        stored = to_internal(value, self.units)
        return SETTING_INVALID if stored is None else stored & 0xFFFFFFFF

    def physical(self, data):
        raw = extract(data, self.start, self.length, self.big_endian, self.signed and self.length <= 32)
        return raw * self.multiplier + self.offset


@dataclass
class Frame:
    name: str
    index: int
    can_id: int
    extended: bool
    length: int
    signals: list = field(default_factory=list)

    @property
    def id_setting(self):
        return self.can_id | (0x80000000 if self.extended else 0)


@dataclass
class CanLayout:
    bus: BusLayout
    frames: list
    source: str

    @property
    def signals(self):
        return [signal for frame in self.frames for signal in frame.signals]

    def summary(self):
        return {"bus": self.bus.name, "source": self.source,
                "frames": [{"name": frame.name, "id": f"0x{frame.can_id:X}", "extended": frame.extended,
                            "length": frame.length, "signals": [signal.name for signal in frame.signals]}
                           for frame in self.frames]}


def _read(memory, offset, size):
    return memory.read(SETTINGS_BASE + offset, size)


def _text(data):
    return data.split(b"\0", 1)[0].decode("utf-8", "replace").strip()


def layout_from_memory(memory, channel_ids=None):
    """Generic CAN receive layout from the map settings NSP wrote into dash memory.

    Returns the first enabled bus that has enabled receive frames with receive
    signals, or None. A frame is used when its enabled bit (0x80) is set, its
    transmit bit (0x80 of the rate byte) is clear; a signal when its channel
    type is 0 (Receive) and its frame id names an enabled frame.
    """
    for bus in BUSES:
        if _read(memory, bus.enable, 1) != b"\x01":
            continue
        ids = struct.unpack(f"<{FRAMES_PER_BUS}I", _read(memory, bus.frame_can_id, 4 * FRAMES_PER_BUS))
        enabled = _read(memory, bus.frame_enabled_length, FRAMES_PER_BUS)
        rates = _read(memory, bus.frame_transmit_rate, FRAMES_PER_BUS)
        names = _read(memory, bus.frame_name, 30 * FRAMES_PER_BUS)
        frames = {}
        for index in range(FRAMES_PER_BUS):
            if enabled[index] & 0x80 and not rates[index] & 0x80:
                can_id = ids[index]
                extended = bool(can_id & 0x80000000)
                frames[index] = Frame(_text(names[30 * index:30 * index + 30]) or f"Frame {index + 1}", index,
                                      can_id & (0x1FFFFFFF if extended else 0x7FF), extended,
                                      min(8, enabled[index] & 0x3F))
        if not frames:
            continue
        signal_ids = struct.unpack(f"<{SIGNALS_PER_BUS}h", _read(memory, bus.signal_id, 2 * SIGNALS_PER_BUS))
        types = _read(memory, bus.signal_channel_type, SIGNALS_PER_BUS)
        starts = _read(memory, bus.signal_start_bit, SIGNALS_PER_BUS)
        lengths = _read(memory, bus.signal_bit_length, SIGNALS_PER_BUS)
        formats = _read(memory, bus.signal_format, SIGNALS_PER_BUS)
        signs = _read(memory, bus.signal_sign, SIGNALS_PER_BUS)
        # Floats are stored big-endian (GenericCAN::get_signal_multiplier byte-swaps them).
        multipliers = struct.unpack(f">{SIGNALS_PER_BUS}f", _read(memory, bus.signal_multiplier, 4 * SIGNALS_PER_BUS))
        offsets = struct.unpack(f">{SIGNALS_PER_BUS}f", _read(memory, bus.signal_offset, 4 * SIGNALS_PER_BUS))
        units = struct.unpack(f"<{SIGNALS_PER_BUS}H", _read(memory, bus.signal_units, 2 * SIGNALS_PER_BUS))
        names = _read(memory, bus.signal_name, 30 * SIGNALS_PER_BUS)
        for index in range(SIGNALS_PER_BUS):
            frame = frames.get(signal_ids[index])
            if frame is None or types[index] != 0 or not 0 < lengths[index] <= 64:
                continue
            frame.signals.append(Signal(
                _text(names[30 * index:30 * index + 30]) or f"Signal {index + 1}", index, frame.index,
                starts[index], lengths[index], formats[index] == 0, signs[index] == 1,
                multipliers[index], offsets[index], units[index], bus.outputs + 4 * index,
                channel_ids.get(bus.outputs + 4 * index) if channel_ids else None))
        used = [frame for frame in frames.values() if frame.signals]
        if used:
            return CanLayout(bus, used, f"map settings ({bus.name} Generic CAN)")
    return None


def layout_from_json(path, channel_ids=None):
    """emtron_can.json (the owner's NSP Generic CAN setup) as a Third Party bus layout."""
    document = json.loads(Path(path).read_text(encoding="utf-8"))
    bus = BUSES[2]
    frames, index = [], 0
    for number, entry in enumerate(document["frames"]):
        can_id = int(str(entry["id"]), 0)
        frame = Frame(entry.get("name") or f"0x{can_id:X}", number, can_id & 0x1FFFFFFF, can_id > 0x7FF,
                      int(entry.get("length", 8)))
        for item in entry["signals"]:
            unit = str(item.get("unit", "")).casefold()
            units = item.get("units", JSON_UNITS.get(unit, 0))
            channel = bus.outputs + 4 * index
            frame.signals.append(Signal(item["name"], index, number, int(item["startBit"]), int(item["length"]),
                                        item.get("format", "little") == "big", bool(item.get("signed", False)),
                                        float(item.get("scale", 1)), float(item.get("offset", 0)), int(units),
                                        channel, channel_ids.get(channel) if channel_ids else None))
            index += 1
        frames.append(frame)
    return CanLayout(bus, frames, f"{Path(path).name} (default Emtron layout)")


def default_layout_path():
    for candidate in (DEFAULT_LAYOUT, BUNDLED_LAYOUT):
        if candidate.is_file():
            return candidate
    return None


def load_channel_table(path=CHANNEL_TABLE):
    """{setting id: (USB address, name, long name)} for the dash's live channels."""
    try:
        table = json.loads(Path(path).read_text(encoding="utf-8"))["channels"]
    except (OSError, ValueError, KeyError):
        return {}
    return {int(key): (CHANNEL_BASE + value[0], value[1], value[2]) for key, value in table.items()}


# --- Engine model -------------------------------------------------------------------------

QUANTITIES = (
    # (quantity, canonical unit, pattern on the normalised signal name); first match wins.
    ("lambda_target", "lambda", r"LAMBDA_?T(GT|ARGET)|AFR_?T(GT|ARGET)"),
    ("cam_target", "deg", r"CAM_?T(GT|ARGET)"),
    ("ign_base", "deg", r"IGN_?BASE"),
    ("rpm", "rpm", r"ENGINE_?SPEED|\bRPM\b|^RPM"),
    ("map", "kpa_abs", r"MANIFOLD|\bMAP\b|BOOST"),
    ("coolant", "c", r"COOLANT|ENG(INE)?_?TEMP|\bECT\b|WATER"),
    ("iat", "c", r"INTAKE_?AIR|INLET_?AIR|\bIAT\b|AIR_?TEMP"),
    ("oil_pressure", "kpa_abs", r"OIL_?PRES"),
    ("fuel_pressure", "kpa_abs", r"FUEL_?PRES"),
    ("oil_temp", "c", r"OIL_?TEMP"),
    ("ethanol", "%", r"ETHANOL|FLEX"),
    ("lambda", "lambda", r"LAMBDA|\bAFR\b|\bO2\b"),
    ("tps", "%", r"\bTPS\b|THROTTLE"),
    ("stft", "%", r"STFT|SHORT_?TERM"),
    ("ltft", "%", r"LTFT|LONG_?TERM"),
    ("ign_angle", "deg", r"IGN|TIMING|SPARK"),
    ("inj_duty", "%", r"INJ|DUTY"),
    ("dtc_count", "raw", r"DTC_?COUNT"),
    ("dtc_codes", "raw", r"DTC"),
    ("knock_count", "raw", r"KNOCK"),
    ("cam_pos", "deg", r"CAM"),
    ("vtec", "raw", r"VTEC"),
    ("speed", "kmh", r"SPEED|\bVSS\b"),
    ("gear", "raw", r"GEAR"),
    ("battery", "v", r"BATT|VOLT"),
)


def quantity_for(name):
    normalised = re.sub(r"[^A-Z0-9]+", "_", name.upper()).strip("_")
    spaced = normalised.replace("_", " ")
    for quantity, unit, pattern in QUANTITIES:
        if re.search(pattern, normalised) or re.search(pattern, spaced):
            return quantity, unit
    return None, None


def canonical_to_units(value, canonical, units):
    """A model value (kPa abs, C, km/h, ...) in the units a signal is configured for."""
    if canonical == "kpa_abs":
        return {768: value - 101.3, 769: value, 770: value * 10, 771: value / 100,
                772: (value - 101.3) / 98.0665, 773: value / 6.894758 - 14.6923,
                774: (value - 101.3) / 6.894758, 775: value / 6.894745}.get(units, value)
    if canonical == "c":
        return value * 9 / 5 + 32 if units == 1281 else value
    if canonical == "kmh":
        return value / 1.609344 if units == 1025 else value
    if canonical == "lambda":
        return {1537: value * 14.7, 1538: value * 6.47, 1539: value * 9.0}.get(units, value)
    return value


GEAR_RATIOS = (3.23, 1.90, 1.36, 1.03, 0.79)
FINAL_DRIVE = 4.4
TYRE_METRES = 1.9
TRACK_LAP = ((8, 185), (4, 75), (6, 150), (3, 65), (9, 205), (5, 90), (6, 140), (4, 60), (5, 120))
DRIVE_CYCLE = ((12, 50), (10, 80), (8, 60), (14, 100), (10, 40), (6, 0), (8, 0))


def speed_for(rpm, gear):
    return rpm / (GEAR_RATIOS[gear - 1] * FINAL_DRIVE) * TYRE_METRES * 60 / 1000


def rpm_for(speed, gear):
    return speed / (TYRE_METRES * 60 / 1000) * GEAR_RATIOS[gear - 1] * FINAL_DRIVE


def _profile(table, elapsed):
    total = sum(duration for duration, _ in table)
    elapsed %= total
    for duration, value in table:
        if elapsed < duration:
            return value
        elapsed -= duration
    return table[-1][1]


DEFAULT_ENGINE = {"idle_rpm": 850, "rev_limit": 7800, "ambient_c": 22.0, "thermostat_c": 88.0,
                  "boost_kpa": 190.0, "fuel_base_kpa": 300.0, "battery_running_v": 14.2, "battery_off_v": 12.5,
                  "ethanol_pct": 10.0}
MODIFIERS = ("oil_pressure_scale", "fuel_pressure_scale", "coolant_target_c", "battery_v", "rev_limit",
             "boost_kpa", "iat_offset_c")


class EngineModel:
    """Deterministic engine physics driving every quantity a dash usually shows."""

    def __init__(self, engine=None, start_coolant_c=None, seed=1):
        self.engine = dict(DEFAULT_ENGINE, **(engine or {}))
        ambient = self.engine["ambient_c"]
        self.random = random.Random(seed)
        self.rpm = 0.0
        self.tps = 0.0
        self.map = 101.3
        self.speed = 0.0
        self.gear = 1
        self.coolant = ambient if start_coolant_c is None else float(start_coolant_c)
        self.oil_temp = self.coolant
        self.iat = ambient
        self.oil_pressure = 0.0
        self.fuel_pressure = 0.0
        self.lambda_value = 1.0
        self.phase_time = 0.0
        self.values = {}

    def prime(self, phase):
        """Start with the engine already idling (a scenario begins with a running engine)."""
        cold = max(0.0, min(1.0, (60.0 - self.coolant) / 40.0))
        self.rpm = float(phase.get("idle_rpm", self.engine["idle_rpm"])) + 300.0 * cold
        self.tps = 2.0
        self.map = 35.0
        viscosity = 1.0 + max(0.0, min(0.6, (80.0 - self.oil_temp) / 80.0))
        self.oil_pressure = (70.0 + self.rpm * 0.085) * viscosity
        self.fuel_pressure = float(self.engine["fuel_base_kpa"]) + self.map - 101.3

    def _noise(self, size):
        return self.random.uniform(-size, size)

    def step(self, dt, phase, modifiers):
        engine = dict(self.engine)
        engine.update({key: modifiers[key] for key in ("rev_limit", "boost_kpa") if key in modifiers})
        mode = phase.get("mode", "idle")
        self.phase_time += dt
        limit = float(engine["rev_limit"])
        cold = max(0.0, min(1.0, (60.0 - self.coolant) / 40.0))
        idle = float(phase.get("idle_rpm", engine["idle_rpm"])) + 300.0 * cold
        target_rpm, target_tps, target_speed = idle, 2.0, 0.0
        if mode == "off":
            target_rpm, target_tps = 0.0, 0.0
        elif mode == "rev":
            period = float(phase.get("period", 4.0))
            peak = float(phase.get("rpm", 5000))
            within = self.phase_time % period
            rising = within < period * 0.4
            target_rpm, target_tps = (peak, 65.0) if rising else (idle, 2.0)
        elif mode == "hold":
            target_rpm = float(phase.get("rpm", idle))
            target_tps = float(phase.get("tps", 15.0))
            target_speed = float(phase.get("speed", 0.0))
        elif mode in ("drive", "track"):
            table = TRACK_LAP if mode == "track" else DRIVE_CYCLE
            target_speed = float(_profile(phase.get("profile", table), self.phase_time))
            error = target_speed - self.speed
            tau = 2.2 if mode == "track" else 4.0
            accel = error / tau
            self.speed = max(0.0, self.speed + accel * dt)
            if mode == "track":
                upshift, downshift = limit * 0.93, 4200.0
            else:
                upshift, downshift = 3000.0, 1500.0
            if rpm_for(self.speed, self.gear) > upshift and self.gear < len(GEAR_RATIOS):
                self.gear += 1
            elif rpm_for(self.speed, self.gear) < downshift and self.gear > (2 if mode == "track" else 1):
                self.gear -= 1
            target_rpm = max(idle, rpm_for(self.speed, self.gear))
            target_tps = max(0.0, min(100.0, (8.0 if self.speed > 1 else 2.0) + 18.0 * max(0.0, accel) +
                                      self.speed / (4.0 if mode == "track" else 6.0)))
            if accel < -2:
                target_tps = 0.0
        if mode not in ("drive", "track"):
            self.speed += (target_speed - self.speed) * min(1.0, dt / 2.0)
        if target_rpm > limit:
            target_rpm = limit - self.random.uniform(0, 150)  # the ECU's limiter bounces off the cut
        tau = 0.18 if target_rpm > self.rpm else 0.35
        self.rpm += (target_rpm - self.rpm) * min(1.0, dt / tau)
        if mode == "off" and self.rpm < 50:
            self.rpm = 0.0
        self.tps += (target_tps - self.tps) * min(1.0, dt / 0.08)
        running = self.rpm > 300
        load = self.tps / 100.0
        if running:
            vacuum = 32.0 + 69.3 * min(1.0, load * 1.6)
            spool = max(0.0, min(1.0, (self.rpm - 2500.0) / 2500.0))
            target_map = vacuum + max(0.0, load - 0.55) / 0.45 * spool * (float(engine["boost_kpa"]) - 101.3)
        else:
            target_map = 101.3
        self.map += (target_map - self.map) * min(1.0, dt / 0.15)
        thermostat = float(modifiers.get("coolant_target_c", engine["thermostat_c"]))
        ambient = float(engine["ambient_c"])
        if running:
            if self.coolant < thermostat:
                self.coolant = min(thermostat, self.coolant + (0.16 + 0.9 * load) * dt)
            else:
                self.coolant += (thermostat - self.coolant) * min(1.0, dt / 25.0)
        else:
            self.coolant += (ambient - self.coolant) * min(1.0, dt / 900.0)
        oil_target = (self.coolant + 6.0 + 18.0 * load) if running else self.coolant
        self.oil_temp += (oil_target - self.oil_temp) * min(1.0, dt / 90.0)
        iat_target = ambient + float(modifiers.get("iat_offset_c", 0.0)) + (
            12.0 * (1.0 - min(1.0, self.speed / 60.0)) + 14.0 * load if running else 4.0)
        self.iat += (iat_target - self.iat) * min(1.0, dt / 30.0)
        viscosity = 1.0 + max(0.0, min(0.6, (80.0 - self.oil_temp) / 80.0))
        oil_gauge = min(520.0, 70.0 + self.rpm * 0.085) * viscosity if running else 0.0
        oil_gauge *= float(modifiers.get("oil_pressure_scale", 1.0))
        self.oil_pressure += (oil_gauge - self.oil_pressure) * min(1.0, dt / 0.3)
        fuel_gauge = (float(engine["fuel_base_kpa"]) + (self.map - 101.3)) if running else 0.0
        fuel_gauge *= float(modifiers.get("fuel_pressure_scale", 1.0))
        self.fuel_pressure += (fuel_gauge - self.fuel_pressure) * min(1.0, dt / 0.2)
        lambda_target = 0.82 if self.map > 110 else (1.0 if running else 1.0)
        self.lambda_value += (lambda_target - self.lambda_value) * min(1.0, dt / 0.25)
        if running and "battery_v" in modifiers:
            battery = float(modifiers["battery_v"])
        elif running:
            battery = float(engine["battery_running_v"]) - 0.25 * load
        else:
            battery = float(modifiers.get("battery_v", engine["battery_off_v"]))
        ign = (12.0 + 18.0 * min(1.0, self.rpm / 4000.0) - max(0.0, self.map - 101.3) * 0.12) if running else 0.0
        self.values = {
            "rpm": max(0.0, self.rpm + (self._noise(8) if running else 0.0)),
            "map": self.map + self._noise(0.3), "coolant": self.coolant, "iat": self.iat,
            "oil_pressure": 101.3 + max(0.0, self.oil_pressure + (self._noise(2) if running else 0.0)),
            "fuel_pressure": 101.3 + max(0.0, self.fuel_pressure + (self._noise(1.5) if running else 0.0)),
            "oil_temp": self.oil_temp, "ethanol": float(engine["ethanol_pct"]),
            "lambda": self.lambda_value + (self._noise(0.008) if running else 0.0),
            "lambda_target": lambda_target, "tps": self.tps,
            "stft": self._noise(2.0) if running else 0.0, "ltft": 1.5 if running else 0.0,
            "ign_angle": ign, "ign_base": ign, "inj_duty": min(100.0, self.rpm / limit * self.map / 2.0) if running else 0.0,
            "dtc_count": 0.0, "dtc_codes": 0.0, "knock_count": 0.0,
            "cam_pos": 20.0 + 20.0 * load if running else 0.0, "cam_target": 20.0 + 20.0 * load if running else 0.0,
            "vtec": 1.0 if self.rpm > 5500 else 0.0, "speed": self.speed,
            "gear": float(self.gear if self.speed > 2 else 0), "battery": battery,
        }
        return self.values


# --- Scenarios ----------------------------------------------------------------------------

SCENARIO_FORMAT = "ic7-engine-sim"


def preset(name):
    """Built-in scenarios. Every preset is labelled as a simulation."""
    warm = {"start_coolant_c": 85.0}
    presets = {
        "idle": {"description": "Warm engine idling", **warm, "phases": [{"mode": "idle", "duration": 60}]},
        "warm-up": {"description": "Cold start idling while coolant and oil warm up to the thermostat",
                    "start_coolant_c": 18.0, "phases": [{"mode": "idle", "duration": 600}], "loop": False},
        "track-lap": {"description": "Warm engine on a track lap: gear changes, boost, near the limiter",
                      **warm, "phases": [{"mode": "idle", "duration": 5}, {"mode": "track", "duration": 54}]},
        "low-oil-pressure": {
            "description": ("Warm engine, then oil pressure collapses while driving. The dash's "
                            "engine-running gate (rpm > 449) reads the ECU RPM channel, so this preset "
                            "also feeds that channel; clear 'ECU RPM channel' to see a map with only "
                            "Generic CAN, where gated alarms never fire."),
            **warm, "ecu_rpm_channel": True,
            "phases": [{"mode": "idle", "duration": 8},
                       {"mode": "drive", "duration": 40, "modifiers": {"oil_pressure_scale": 0.08}}]},
        "overheat": {"description": "Coolant climbs past 105 C while driving", "start_coolant_c": 95.0,
                     "phases": [{"mode": "drive", "duration": 120, "modifiers": {"coolant_target_c": 118.0}}]},
        "over-rev": {"description": "Revving to 8600 rpm (limiter raised for the test)", **warm,
                     "phases": [{"mode": "idle", "duration": 3},
                                {"mode": "rev", "duration": 20, "rpm": 8600, "period": 5,
                                 "modifiers": {"rev_limit": 9000}}]},
        "low-fuel-pressure": {"description": "Fuel pressure sags to half while driving", **warm,
                              "phases": [{"mode": "idle", "duration": 5},
                                         {"mode": "drive", "duration": 60, "modifiers": {"fuel_pressure_scale": 0.45}}]},
        "battery-low": {"description": ("Charging failure: 11.4 V with the engine running. The battery "
                                        "channel is the dash's own supply input, not CAN."),
                        **warm, "ecu_rpm_channel": True,
                        "phases": [{"mode": "idle", "duration": 60, "modifiers": {"battery_v": 11.4}}]},
    }
    if name not in presets:
        raise ValueError(f"Unknown engine-simulation preset {name!r}; choose one of {', '.join(presets)}")
    return normalise_scenario({"format": SCENARIO_FORMAT, "version": 1, "name": name, **presets[name]})


PRESETS = ("idle", "warm-up", "track-lap", "low-oil-pressure", "overheat", "over-rev", "low-fuel-pressure",
           "battery-low")
FAULT_TYPES = ("signal_dropout", "stuck", "frame_dropout", "can_timeout", "no_frames")


def normalise_scenario(document):
    if not isinstance(document, dict) or document.get("format", SCENARIO_FORMAT) != SCENARIO_FORMAT:
        raise ValueError("Not an iC-7 engine-simulation scenario")
    phases = document.get("phases") or [{"mode": "idle", "duration": 60}]
    for phase in phases:
        if not isinstance(phase, dict) or phase.get("mode", "idle") not in ("off", "idle", "rev", "drive", "track", "hold"):
            raise ValueError(f"Invalid scenario phase: {phase!r}")
        if not float(phase.get("duration", 0)) > 0:
            raise ValueError("Every scenario phase needs a positive duration in seconds")
        unknown = set(phase.get("modifiers", {})) - set(MODIFIERS)
        if unknown:
            raise ValueError(f"Unknown phase modifiers: {', '.join(sorted(unknown))}")
    for fault in document.get("faults", []):
        if fault.get("type") not in FAULT_TYPES:
            raise ValueError(f"Unknown fault type {fault.get('type')!r}; choose one of {', '.join(FAULT_TYPES)}")
    speed = float(document.get("speed", 1.0))
    if not 0 < speed <= 100:
        raise ValueError("Scenario speed multiplier must be between 0 and 100")
    return {"format": SCENARIO_FORMAT, "version": 1, "name": str(document.get("name", "custom")),
            "description": str(document.get("description", "")), "speed": speed,
            "loop": bool(document.get("loop", True)), "frame_rate_hz": float(document.get("frame_rate_hz", 50)),
            "ecu_rpm_channel": bool(document.get("ecu_rpm_channel", False)),
            "battery_channel": bool(document.get("battery_channel", True)),
            "start_coolant_c": document.get("start_coolant_c"), "engine": dict(document.get("engine", {})),
            "modifiers": dict(document.get("modifiers", {})), "phases": [dict(phase) for phase in phases],
            "overrides": dict(document.get("overrides", {})), "faults": [dict(item) for item in document.get("faults", [])],
            "seed": int(document.get("seed", 1))}


def load_scenario(source):
    """A preset name or a scenario JSON file."""
    if str(source) in PRESETS:
        return preset(str(source))
    path = Path(source)
    if not path.is_file():
        raise ValueError(f"Engine-simulation scenario not found: {source} (or use a preset: {', '.join(PRESETS)})")
    try:
        return normalise_scenario(json.loads(path.read_text(encoding="utf-8")))
    except (ValueError, TypeError, AttributeError) as error:
        raise ValueError(f"Invalid engine-simulation scenario {path.name}: {error}") from error


def save_scenario(scenario, path):
    document = normalise_scenario(scenario)
    temporary = Path(path).with_suffix(".tmp")
    temporary.write_text(json.dumps(document, indent=2) + "\n", encoding="utf-8")
    temporary.replace(path)


class Timeline:
    def __init__(self, scenario):
        self.scenario = scenario
        self.total = sum(float(phase["duration"]) for phase in scenario["phases"])

    def at(self, elapsed):
        """(phase index, phase, finished) at a scenario time."""
        if self.scenario["loop"]:
            elapsed %= self.total
        elif elapsed >= self.total:
            return len(self.scenario["phases"]) - 1, self.scenario["phases"][-1], True
        for index, phase in enumerate(self.scenario["phases"]):
            if elapsed < float(phase["duration"]):
                return index, phase, False
            elapsed -= float(phase["duration"])
        return len(self.scenario["phases"]) - 1, self.scenario["phases"][-1], False


# --- Dash alarm module ----------------------------------------------------------------------

def color_string(value):
    """Alarm_Module::compute_color_string: '#' + the 8 hex digits in reversed byte order."""
    digits = f"{value & 0xFFFFFFFF:08x}"
    return "#" + digits[6:8] + digits[4:6] + digits[2:4] + digits[0:2]


def alarm_message(alarms):
    """draw_alarms' popup message: unescaped concatenation, names cut to 20, height 60, no image."""
    entries = [' { "text":"' + alarm["text"][:20] + '", "bc": "' + alarm["bc"] + '", "height": "60'
               '", "img": "' + '' + '", "fc": "' + alarm["fc"] + '" }' for alarm in alarms]
    return "[" + ",".join(entries) + "]"


class AlarmModule:
    """The dash's alarm evaluation over channel values and the map's alarm settings."""

    def __init__(self, channels):
        self.channels = channels
        self.active = [False] * ALARM_COUNT
        self.started = [0] * ALARM_COUNT
        self.last_index = None

    def settings(self, memory, index):
        base = ALARM_BASE + ALARM_STRIDE * index
        block = _read(memory, base, ALARM_STRIDE)
        return {"name": _text(block[0:20]), "channel": struct.unpack_from("<H", block, 20)[0],
                "upper_enabled": block[22] != 0, "upper": struct.unpack_from("<i", block, 24)[0],
                "lower_enabled": block[32] != 0, "lower": struct.unpack_from("<i", block, 36)[0],
                "clear_after": block[44], "text_colour": struct.unpack_from("<I", block, 48)[0],
                "background": struct.unpack_from("<I", block, 52)[0], "manual_clear": block[56] != 0,
                "enabled": block[57] != 0, "require_engine": block[72] != 0}

    def evaluate(self, memory, now_ms):
        """One process_alarms_and_shift_lights pass; returns newly raised alarm names."""
        rpm = struct.unpack("<i", memory.read(RPM_CHANNEL, 4))[0]
        raised = []
        for index in range(ALARM_COUNT):
            alarm = self.settings(memory, index)
            channel = self.channels.get(alarm["channel"])
            if channel is None or not alarm["enabled"]:
                self.active[index] = False
            else:
                value = struct.unpack("<i", memory.read(channel[0], 4))[0]
                triggered = ((alarm["upper_enabled"] and value > alarm["upper"]) or
                             (alarm["lower_enabled"] and value < alarm["lower"]))
                if triggered and alarm["require_engine"] and rpm < ENGINE_RUNNING_RPM:
                    triggered = False
                if triggered:
                    if not self.active[index]:
                        self.active[index] = True
                        self.started[index] = now_ms
                        self.last_index = index
                        raised.append(alarm["name"])
                elif (self.active[index] and not alarm["manual_clear"] and
                      now_ms - self.started[index] > 1000 * alarm["clear_after"]):
                    self.active[index] = False
            memory.write(ALARM_ACTIVE + 4 * index, struct.pack("<i", int(self.active[index])))
        return raised

    def popup(self, memory):
        alarms = []
        for index in range(ALARM_COUNT):
            if self.active[index]:
                alarm = self.settings(memory, index)
                alarms.append({"index": index, "text": alarm["name"], "bc": color_string(alarm["background"]),
                               "fc": color_string(alarm["text_colour"]), "height": "60", "img": ""})
        return alarms

    def clear(self, memory):
        self.active = [False] * ALARM_COUNT
        for index in range(ALARM_COUNT):
            memory.write(ALARM_ACTIVE + 4 * index, b"\0\0\0\0")


# --- Simulation driving a Device -----------------------------------------------------------

class EngineSimulation:
    """Runs a scenario against a Device: frames in, dash decode, alarms, all labelled SIMULATION."""

    def __init__(self, device, scenario, layout_path=None, clock=time.monotonic):
        self.device = device
        self.clock = clock
        self.lock = threading.RLock()
        self.channels = load_channel_table()
        self.channel_ids = {address: key for key, (address, _, _) in self.channels.items()}
        self.layout_path = layout_path
        self.alarms = AlarmModule(self.channels)
        self.thread = None
        self.stop_event = threading.Event()
        self.running = False
        self.overrides = {}
        self.faults = []
        self.frames_sent = 0
        self.last_rx = {}
        self.stuck = {}
        self.latest = {}
        self.alarm_message_cache = ""
        self.dash_ms = 0          # the dash application's own monotonic time; never reset by a new scenario
        self.load(scenario)

    # Configuration -------------------------------------------------------------------------
    def load(self, scenario):
        with self.lock:
            self.scenario = normalise_scenario(scenario)
            self.timeline = Timeline(self.scenario)
            self.model = EngineModel(self.scenario["engine"], self.scenario["start_coolant_c"], self.scenario["seed"])
            if self.scenario["phases"][0].get("mode", "idle") != "off":
                self.model.prime(self.scenario["phases"][0])
            self.speed = self.scenario["speed"]
            self.ecu_rpm_channel = self.scenario["ecu_rpm_channel"]
            self.overrides = {name: dict(value) for name, value in self.scenario["overrides"].items()}
            self.faults = [dict(fault) for fault in self.scenario["faults"]]
            self.elapsed = 0.0
            self.phase_index = None
            self.finished = False

    def scenario_document(self):
        with self.lock:
            document = dict(self.scenario)
            document.update({"speed": self.speed, "ecu_rpm_channel": self.ecu_rpm_channel,
                             "overrides": {key: dict(value) for key, value in self.overrides.items()},
                             "faults": [dict(fault) for fault in self.faults]})
            return normalise_scenario(document)

    def layout(self):
        with self.device.lock:
            layout = layout_from_memory(self.device.memory, self.channel_ids)
        if layout is not None:
            return layout
        path = Path(self.layout_path) if self.layout_path else default_layout_path()
        if path is None:
            raise ValueError("No Generic CAN layout: upload a map with Generic CAN signals, or keep "
                             "emtron_can.json next to the emulator")
        return layout_from_json(path, self.channel_ids)

    def set_override(self, signal, value=None, stuck=False):
        with self.lock:
            if value is None and not stuck:
                self.overrides.pop(signal, None)
            else:
                self.overrides[signal] = {"stuck": True} if stuck else {"value": float(value)}

    def inject(self, kind, signal=None, duration=5.0):
        if kind not in FAULT_TYPES:
            raise ValueError(f"Unknown fault type {kind!r}")
        with self.lock:
            fault = {"type": kind, "start": self.elapsed, "duration": float(duration)}
            if signal:
                fault["signal"] = signal
            self.faults.append(fault)
        log.warning("%s: fault injected type=%s signal=%s duration=%.1fs (simulated, not a real fault)",
                    SIMULATION_LABEL, kind, signal or "-", float(duration))

    def clear_faults(self):
        with self.lock:
            self.faults = []

    # Lifecycle -----------------------------------------------------------------------------
    def start(self, threaded=True):
        with self.lock:
            if self.running:
                return
            self.layout_now = self.layout()
            self.running = True
            self.started_at = self.clock()
            self.last_tick = self.started_at
            self.saved = {}
            with self.device.lock:
                for address in (RPM_CHANNEL, BATTERY_CHANNEL):
                    self.saved[address] = self.device.memory.read(address, 4)
                for signal in self.layout_now.signals:
                    self.device.memory.write(signal.channel, struct.pack("<I", NO_SIGNAL))
        log.warning("%s started: scenario=%s layout=%s frames=%d signals=%d speed=x%.2f ecu_rpm_channel=%s "
                    "(simulated values, no real engine or CAN bus)", SIMULATION_LABEL, self.scenario["name"],
                    self.layout_now.source, len(self.layout_now.frames), len(self.layout_now.signals),
                    self.speed, self.ecu_rpm_channel)
        if threaded:
            self.stop_event.clear()
            self.thread = threading.Thread(target=self._run, name="engine-sim", daemon=True)
            self.thread.start()

    def _run(self):
        period = 1.0 / max(1.0, min(200.0, self.scenario["frame_rate_hz"]))
        while not self.stop_event.wait(period):
            try:
                self.tick()
            except Exception:
                log.exception("%s tick failed; stopping the simulation", SIMULATION_LABEL)
                self.stop()
                return

    def stop(self):
        self.stop_event.set()
        if self.thread is not None and self.thread is not threading.current_thread():
            self.thread.join(timeout=2)
        self.thread = None
        with self.lock:
            if not self.running:
                return
            self.running = False
            with self.device.lock:
                memory = self.device.memory
                # The bus goes quiet: the dash marks every received signal Device Time Out.
                for signal in self.layout_now.signals:
                    memory.write(signal.channel, struct.pack("<I", DEVICE_TIME_OUT))
                for frame in self.layout_now.frames:
                    memory.write(self.layout_now.bus.realtime_data, bytes(8))
                for address, payload in self.saved.items():
                    memory.write(address, payload)
                self.alarms.clear(memory)
            self.alarm_message_cache = ""
        log.warning("%s stopped after %.1f s simulated, %d frames", SIMULATION_LABEL, self.elapsed, self.frames_sent)

    # Simulation step -----------------------------------------------------------------------
    def _fault_active(self, fault):
        start = float(fault.get("start", 0))
        duration = fault.get("duration")
        return start <= self.elapsed and (duration is None or self.elapsed < start + float(duration))

    def tick(self, dt=None):
        with self.lock:
            if not self.running:
                return
            now = self.clock()
            real_dt = (now - self.last_tick) if dt is None else dt
            self.last_tick = now
            device = self.device
            with device.lock:
                if device.boot_mode or device.rebooting():
                    return  # the dash application (and its CAN decoding) is not running
            sim_dt = max(0.0, min(0.5, real_dt)) * self.speed
            steps = max(1, int(math.ceil(sim_dt / 0.05)))
            self.dash_ms += max(1, int(round(sim_dt * 1000)))
            for _ in range(steps):
                self.elapsed += sim_dt / steps
                index, phase, finished = self.timeline.at(self.elapsed)
                modifiers = dict(self.scenario["modifiers"], **phase.get("modifiers", {}))
                values = self.model.step(sim_dt / steps, phase, modifiers)
            if index != self.phase_index:
                self.phase_index = index
                log.info("%s phase %d/%d mode=%s duration=%ss", SIMULATION_LABEL, index + 1,
                         len(self.scenario["phases"]), phase.get("mode"), phase.get("duration"))
            self.finished = finished
            self._send_frames(values)
            with device.lock:
                memory = device.memory
                self._check_timeouts(memory)
                if self.ecu_rpm_channel:
                    memory.write(RPM_CHANNEL, struct.pack("<i", int(values["rpm"])))
                if self.scenario["battery_channel"]:
                    memory.write(BATTERY_CHANNEL, struct.pack("<i", to_internal(values["battery"], 2048)))
                raised = self.alarms.evaluate(memory, self.dash_ms)
                popup = self.alarms.popup(memory)
            self.alarm_message_cache = alarm_message(popup) if popup else ""
            for name in raised:
                log.warning("%s: dash alarm raised by simulated values: %s", SIMULATION_LABEL, name)

    def _send_frames(self, values):
        layout = self.layout_now
        active = [fault for fault in self.faults if self._fault_active(fault)]
        # A silent bus: frames already received time out after 2 s; never-received ones stay "No Signal".
        silent = any(fault["type"] in ("can_timeout", "no_frames") for fault in active)
        dropped_frames = {self._frame_of(fault.get("signal")) for fault in active if fault["type"] == "frame_dropout"}
        zeroed = {fault.get("signal") for fault in active if fault["type"] == "signal_dropout"}
        stuck = {fault.get("signal") for fault in active if fault["type"] == "stuck"}
        stuck |= {name for name, override in self.overrides.items() if override.get("stuck")}
        latest = {}
        for frame in layout.frames:
            data = bytearray(8)
            for signal in frame.signals:
                quantity, canonical = quantity_for(signal.name)
                override = self.overrides.get(signal.name, {})
                if "value" in override:
                    value = override["value"]
                elif quantity is not None:
                    value = canonical_to_units(values[quantity], canonical, signal.units)
                else:
                    value = 0.0
                raw = signal.encode(value)
                if signal.name in zeroed:
                    raw = 0
                if signal.name in stuck:
                    raw = self.stuck.setdefault(signal.name, raw)
                else:
                    self.stuck.pop(signal.name, None)
                data = insert(data, signal.start, signal.length, signal.big_endian, raw)
                latest[signal.name] = {"value": value, "raw": raw, "frame": frame.name,
                                       "quantity": quantity, "units": signal.unit_name}
            if silent or frame.index in dropped_frames:
                continue
            self.receive(frame, bytes(data[:max(frame.length, 1)]))
        with self.device.lock:
            for signal in layout.signals:
                stored = struct.unpack("<I", self.device.memory.read(signal.channel, 4))[0]
                entry = latest.setdefault(signal.name, {})
                entry["stored"] = signed32(stored)
                entry["dash"] = channel_error(stored) or from_internal(signed32(stored), signal.units)
        self.latest = latest

    def _frame_of(self, signal_name):
        for frame in self.layout_now.frames:
            if signal_name == frame.name or any(signal.name == signal_name for signal in frame.signals):
                return frame.index
        return None

    def receive(self, frame, data):
        """The dash receiving one frame: decode its signals and refresh NSP's raw CAN view."""
        layout = self.layout_now
        with self.device.lock:
            memory = self.device.memory
            for signal in frame.signals:
                memory.write(signal.channel, struct.pack("<I", signal.decode(data)))
            realtime = struct.unpack("<I", memory.read(layout.bus.realtime_can_id, 4))[0]
            if realtime != 0xFFFFFFFF and realtime == frame.id_setting:
                memory.write(layout.bus.realtime_data, bytes(data).ljust(8, b"\0")[:8])
        self.last_rx[frame.index] = self.dash_ms
        self.frames_sent += 1

    def _check_timeouts(self, memory):
        layout = self.layout_now
        realtime = struct.unpack("<I", memory.read(layout.bus.realtime_can_id, 4))[0]
        for frame in layout.frames:
            last = self.last_rx.get(frame.index)
            if last and self.dash_ms - last >= RX_TIMEOUT_MS:
                for signal in frame.signals:
                    memory.write(signal.channel, struct.pack("<I", DEVICE_TIME_OUT))
                if realtime == 0xFFFFFFFF or realtime == frame.id_setting:
                    memory.write(layout.bus.realtime_data, bytes(8))

    # Reporting -----------------------------------------------------------------------------
    def status(self):
        with self.lock:
            layout = getattr(self, "layout_now", None)
            phase = self.scenario["phases"][self.phase_index] if self.phase_index is not None else None
            with self.device.lock:
                popup = self.alarms.popup(self.device.memory) if self.running else []
            return {"simulation": True, "label": SIMULATION_LABEL, "running": self.running,
                    "scenario": self.scenario["name"], "description": self.scenario["description"],
                    "elapsed": round(self.elapsed, 2), "speed": self.speed, "finished": self.finished,
                    "phase": phase.get("mode") if phase else None, "ecu_rpm_channel": self.ecu_rpm_channel,
                    "layout": layout.summary() if layout else None, "frames_sent": self.frames_sent,
                    "signals": self.latest, "overrides": {key: dict(value) for key, value in self.overrides.items()},
                    "faults": [dict(fault, active=self._fault_active(fault)) for fault in self.faults],
                    "alarms": popup, "alarm_message": alarm_message(popup) if popup else ""}
