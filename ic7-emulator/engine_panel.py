"""Workbench panel for the opt-in engine simulation. Everything it shows is SIMULATED."""
from pathlib import Path

from PyQt5.QtCore import Qt, pyqtSignal
from PyQt5.QtWidgets import (QCheckBox, QComboBox, QDoubleSpinBox, QFileDialog, QHBoxLayout, QHeaderView,
                             QLabel, QMessageBox, QPushButton, QSlider, QTableWidget, QTableWidgetItem,
                             QVBoxLayout, QWidget)

import engine_sim

SLIDER_STEPS = 1000
# Slider spans in the model's canonical units, converted to each signal's own units.
RANGES = {"rpm": (0, 9500), "map": (20, 260), "coolant": (-20, 140), "iat": (-20, 90),
          "oil_pressure": (101.3, 900), "fuel_pressure": (101.3, 700), "oil_temp": (-20, 160),
          "ethanol": (0, 100), "lambda": (0.6, 1.4), "lambda_target": (0.6, 1.4), "tps": (0, 100),
          "stft": (-25, 25), "ltft": (-25, 25), "ign_angle": (-10, 50), "ign_base": (-10, 50),
          "inj_duty": (0, 100), "cam_pos": (-50, 60), "cam_target": (-50, 60), "speed": (0, 300),
          "gear": (0, 6), "battery": (8, 16)}
WARNING = ("SIMULATION - the emulator generates these engine values and CAN frames. Nothing comes "
           "from a real engine or CAN bus. Alarms raised here use the dash's alarm logic on "
           "simulated values; never treat them as real warnings.")


def signal_range(signal):
    quantity, canonical = engine_sim.quantity_for(signal["name"])
    if quantity in RANGES:
        low, high = (engine_sim.canonical_to_units(value, canonical, signal["units_code"])
                     for value in RANGES[quantity])
        return min(low, high), max(low, high)
    return 0.0, 100.0


class EnginePanel(QWidget):
    """Start/stop, presets, JSON scenarios, per-signal overrides and fault injection."""
    request = pyqtSignal(object)   # a callable run against the session's Device in its worker thread

    def __init__(self, parent=None):
        super().__init__(parent)
        self.scenario = engine_sim.preset("idle")
        self.signals = []
        self.rows = {}
        self.running = False
        self.session_active = False
        layout = QVBoxLayout(self)
        banner = QLabel(WARNING)
        banner.setWordWrap(True)
        banner.setStyleSheet("background:#7a4b00; color:#fff; font-weight:bold; padding:8px;")
        layout.addWidget(banner)
        controls = QHBoxLayout()
        controls.addWidget(QLabel("Scenario"))
        self.preset = QComboBox()
        self.preset.addItems(engine_sim.PRESETS)
        self.preset.currentTextChanged.connect(self.choose_preset)
        controls.addWidget(self.preset)
        self.load_button = QPushButton("Load JSON...")
        self.load_button.clicked.connect(self.load_file)
        controls.addWidget(self.load_button)
        self.save_button = QPushButton("Save JSON...")
        self.save_button.clicked.connect(self.save_file)
        controls.addWidget(self.save_button)
        controls.addWidget(QLabel("Speed x"))
        self.speed = QDoubleSpinBox()
        self.speed.setRange(0.1, 50.0)
        self.speed.setSingleStep(0.5)
        self.speed.setValue(1.0)
        self.speed.valueChanged.connect(self.change_speed)
        controls.addWidget(self.speed)
        self.ecu_rpm = QCheckBox("Feed ECU RPM channel (alarm engine-running gate)")
        self.ecu_rpm.setToolTip("The dash only raises 'Disable Alarm When Engine Off' alarms when its ECU RPM "
                                "channel (not a Generic CAN signal) is above 449 rpm.")
        self.ecu_rpm.toggled.connect(self.change_ecu_rpm)
        controls.addWidget(self.ecu_rpm)
        controls.addStretch()
        self.start_button = QPushButton("Start simulation")
        self.start_button.clicked.connect(self.start)
        controls.addWidget(self.start_button)
        self.stop_button = QPushButton("Stop")
        self.stop_button.clicked.connect(self.stop)
        controls.addWidget(self.stop_button)
        layout.addLayout(controls)
        self.description = QLabel()
        self.description.setWordWrap(True)
        layout.addWidget(self.description)
        faults = QHBoxLayout()
        faults.addWidget(QLabel("Fault"))
        self.fault = QComboBox()
        self.fault.addItems(engine_sim.FAULT_TYPES)
        faults.addWidget(self.fault)
        faults.addWidget(QLabel("Signal"))
        self.fault_signal = QComboBox()
        self.fault_signal.setMinimumWidth(160)
        faults.addWidget(self.fault_signal)
        faults.addWidget(QLabel("Seconds"))
        self.fault_duration = QDoubleSpinBox()
        self.fault_duration.setRange(0.5, 3600)
        self.fault_duration.setValue(5)
        faults.addWidget(self.fault_duration)
        self.inject_button = QPushButton("Inject fault")
        self.inject_button.clicked.connect(self.inject)
        faults.addWidget(self.inject_button)
        self.clear_button = QPushButton("Clear faults")
        self.clear_button.clicked.connect(lambda: self.request.emit(lambda device: device.engine and device.engine.clear_faults()))
        faults.addWidget(self.clear_button)
        faults.addStretch()
        layout.addLayout(faults)
        self.status = QLabel("Engine simulation is off (default).")
        self.status.setWordWrap(True)
        layout.addWidget(self.status)
        self.alarms = QLabel("")
        self.alarms.setWordWrap(True)
        self.alarms.setStyleSheet("color:#ff8a65; font-weight:bold;")
        layout.addWidget(self.alarms)
        self.table = QTableWidget(0, 6)
        self.table.setHorizontalHeaderLabels(["Signal", "Frame", "Sent (signal units)", "Dash channel",
                                              "Override", "Hold"])
        self.table.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)
        self.table.verticalHeader().hide()
        self.table.setEditTriggers(QTableWidget.NoEditTriggers)
        layout.addWidget(self.table, 1)
        self.choose_preset(self.preset.currentText())
        self.set_session(False)

    # Scenario selection ------------------------------------------------------------------
    def choose_preset(self, name):
        self.apply_scenario(engine_sim.preset(name))

    def apply_scenario(self, scenario):
        self.scenario = engine_sim.normalise_scenario(scenario)
        self.speed.blockSignals(True)
        self.speed.setValue(self.scenario["speed"])
        self.speed.blockSignals(False)
        self.ecu_rpm.blockSignals(True)
        self.ecu_rpm.setChecked(self.scenario["ecu_rpm_channel"])
        self.ecu_rpm.blockSignals(False)
        self.description.setText(f"{self.scenario['name']}: {self.scenario['description']}")

    def load_file(self):
        path, _ = QFileDialog.getOpenFileName(self, "Load engine-simulation scenario", "", "Scenario (*.json)")
        if not path:
            return
        try:
            self.apply_scenario(engine_sim.load_scenario(path))
        except ValueError as error:
            QMessageBox.warning(self, "Engine simulation", str(error))

    def current_document(self, status=None):
        document = dict(self.scenario)
        document["speed"] = self.speed.value()
        document["ecu_rpm_channel"] = self.ecu_rpm.isChecked()
        if status and status.get("running"):
            document["overrides"] = status.get("overrides", {})
        return document

    def save_file(self):
        path, _ = QFileDialog.getSaveFileName(self, "Save engine-simulation scenario",
                                              self.scenario["name"] + ".json", "Scenario (*.json)")
        if path:
            try:
                engine_sim.save_scenario(self.current_document(getattr(self, "last_status", None)), Path(path))
            except (OSError, ValueError) as error:
                QMessageBox.warning(self, "Engine simulation", str(error))

    # Requests to the running session -------------------------------------------------------
    def start(self):
        document = self.current_document()
        self.request.emit(lambda device: device.start_engine_sim(document))

    def stop(self):
        self.request.emit(lambda device: device.stop_engine_sim())

    def change_speed(self, value):
        def apply(device):
            if device.engine:
                device.engine.speed = float(value)
        self.request.emit(apply)

    def change_ecu_rpm(self, enabled):
        def apply(device):
            if device.engine:
                device.engine.ecu_rpm_channel = bool(enabled)
        self.request.emit(apply)

    def inject(self):
        kind, signal, duration = self.fault.currentText(), self.fault_signal.currentText(), self.fault_duration.value()
        self.request.emit(lambda device: device.engine and device.engine.inject(kind, signal or None, duration))

    def override(self, name):
        row = self.rows[name]
        if row["hold"].isChecked():
            low, high = row["range"]
            value = low + (high - low) * row["slider"].value() / SLIDER_STEPS
            self.request.emit(lambda device: device.engine and device.engine.set_override(name, value))
        else:
            self.request.emit(lambda device: device.engine and device.engine.set_override(name, None))

    # Status --------------------------------------------------------------------------------
    def set_session(self, active):
        self.session_active = active
        if not active:
            self.running = False
        self.start_button.setEnabled(active and not self.running)
        self.stop_button.setEnabled(active and self.running)
        for widget in (self.inject_button, self.clear_button):
            widget.setEnabled(active and self.running)
        if not active:
            self.status.setText("Engine simulation is off (start a session first; off by default).")
            self.alarms.setText("")

    def show_status(self, status):
        self.last_status = status
        self.running = bool(status.get("running"))
        self.set_session(self.session_active)
        if not self.running:
            self.status.setText("Engine simulation is off.")
            self.alarms.setText("")
            return
        layout = status.get("layout") or {}
        faults = [fault for fault in status.get("faults", []) if fault.get("active")]
        self.status.setText(
            f"SIMULATION RUNNING | {status['scenario']} | phase {status.get('phase')} | "
            f"{status['elapsed']:.1f} s simulated (x{status['speed']:g}) | {status['frames_sent']:,} frames | "
            f"layout: {layout.get('source', '?')}" +
            (" | faults: " + ", ".join(f"{fault['type']} {fault.get('signal', '')}" for fault in faults) if faults else ""))
        alarms = status.get("alarms") or []
        self.alarms.setText("Dash alarms active (SIMULATED values): " + ", ".join(alarm["text"] for alarm in alarms)
                            if alarms else "")
        signals = status.get("signals") or {}
        names = [name for frame in layout.get("frames", []) for name in frame["signals"]]
        if names != self.signals:
            self.build_rows(names, layout, signals)
        for name in names:
            entry = signals.get(name, {})
            row = self.rows[name]["index"]
            sent = entry.get("value")
            dash = entry.get("dash")
            self.table.item(row, 2).setText("--" if sent is None else f"{sent:.2f} {entry.get('units', '')}")
            self.table.item(row, 3).setText(dash if isinstance(dash, str) else "--" if dash is None else f"{dash:.2f}")

    def build_rows(self, names, layout, signals):
        self.signals = names
        self.rows = {}
        self.table.setRowCount(len(names))
        self.fault_signal.clear()
        self.fault_signal.addItems(names)
        frames = {name: frame["name"] for frame in layout.get("frames", []) for name in frame["signals"]}
        for index, name in enumerate(names):
            entry = signals.get(name, {})
            units = next((code for code, label in engine_sim.UNIT_NAMES.items() if label == entry.get("units")), 0)
            span = signal_range({"name": name, "units_code": units})
            for column, text in enumerate((name, frames.get(name, ""), "", "")):
                self.table.setItem(index, column, QTableWidgetItem(text))
            slider = QSlider(Qt.Horizontal)
            slider.setRange(0, SLIDER_STEPS)
            hold = QCheckBox("hold")
            slider.valueChanged.connect(lambda _value, signal=name: self.override(signal))
            hold.toggled.connect(lambda _checked, signal=name: self.override(signal))
            self.table.setCellWidget(index, 4, slider)
            self.table.setCellWidget(index, 5, hold)
            self.rows[name] = {"index": index, "slider": slider, "hold": hold, "range": span}
