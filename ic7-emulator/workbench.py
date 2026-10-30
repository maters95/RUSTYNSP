import argparse
import base64
from dataclasses import dataclass
import io
import hashlib
import json
import logging
from pathlib import Path
import re
import sys
import threading
import time
import urllib.error
import urllib.parse
import urllib.request
import uuid
import zipfile

from PyQt5.QtCore import QByteArray, QBuffer, QIODevice, QProcess, Qt, QThread, QTimer, QUrl, pyqtSignal
from PyQt5.QtGui import QDesktopServices, QFont, QMovie, QPixmap
from PyQt5.QtWidgets import (QAction, QApplication, QCheckBox, QComboBox, QFileDialog, QFormLayout,
                            QHBoxLayout, QHeaderView, QInputDialog, QLabel, QLineEdit, QListWidget,
                            QMainWindow, QMessageBox, QPlainTextEdit, QProgressBar,
                            QPushButton, QSizePolicy, QSplitter, QStyle, QTabWidget,
                            QTableWidget, QTableWidgetItem, QToolBar, QVBoxLayout, QWidget)

from ic7_emulator import ALERT_RESOURCE, Device, SPLASH_RESOURCE, serve_stream
from viewer import is_video_resource, render_layout, start_viewer
from virtual_pair import load_pair_config


ROOT = Path(__file__).resolve().parent
PAIR_CONFIG = ROOT / "port-pair.json"


def export_session_archive(state, destination):
    state, destination = Path(state), Path(destination)
    if not (state / "session.json").is_file() or not (state / "memory.zip").is_file():
        raise ValueError("Stop the session first so its settings and logs are saved.")
    names = ("session.json", "memory.zip", "emulator.log", "protocol.jsonl", "renderer.log",
             "received-screen.bmp")
    sources = [state / name for name in names if (state / name).is_file()]
    for folder in ("resources", "sandbox"):
        sources.extend(path for path in (state / folder).rglob("*") if path.is_file())
    if any(path.is_symlink() or destination.resolve() == path.resolve() for path in sources):
        raise ValueError("Export must not overwrite session files or follow symbolic links.")
    temporary = destination.with_suffix(".zip.tmp")
    try:
        with zipfile.ZipFile(temporary, "w", zipfile.ZIP_DEFLATED) as archive:
            checksums = []
            for path in sorted(sources):
                name = path.relative_to(state).as_posix()
                archive.write(path, name)
                with path.open("rb") as stream:
                    digest = hashlib.file_digest(stream, "sha256").hexdigest()
                checksums.append(f"{digest}  {name}\n")
            archive.writestr("SHA256SUMS", "".join(checksums))
        temporary.replace(destination)
    finally:
        temporary.unlink(missing_ok=True)


def preferred_first(candidates, preferred):
    """Keep the virtual-port list order but move the configured pair end to the front."""
    return sorted(candidates, key=lambda name: name != preferred)


def bundled_package():
    firmware = ROOT.parent / "NSP-test-kit/firmware"
    for name in ("ic7-2.36-screen-alarms-experimental.nex",
                 "ic7-2.36-native-media-alerts-experimental.nex"):
        candidate = firmware / name
        if candidate.is_file():
            return candidate
    return None


def virtual_ports(ports):
    markers = ("virtual", "com0com", "hhd", "simulator")
    return sorted(port.device for port in ports
                  if any(marker in " ".join(str(getattr(port, field, ""))
                         for field in ("description", "manufacturer", "hwid")).lower()
                         for marker in markers))


def alert_preview_texts(payload):
    """Return configured alert texts from an uploaded ic7_alerts.json manifest."""
    if not payload:
        return []
    manifest = json.loads(payload.decode("utf-8"))
    if not isinstance(manifest, dict) or manifest.get("version") != 1 or not isinstance(manifest.get("banners"), list):
        raise ValueError("Unsupported alert manifest")
    texts = []
    for banner in manifest["banners"]:
        text = banner.get("text") if isinstance(banner, dict) else None
        if isinstance(text, str) and text.strip() and text not in texts:
            texts.append(text)
    return texts


def configured_nsp_port(ports):
    for port in ports:
        description = str(getattr(port, "description", "")).strip().casefold()
        if description == "haltech ic-7 simulator":
            return port.device
    return None


@dataclass(frozen=True)
class SessionOptions:
    profile: Path
    root: Path
    package: Path | None = None
    port: str | None = None
    resume: Path | None = None

    def create_state(self):
        if not self.profile.is_file():
            raise ValueError("Device profile was not found")
        if self.package is not None and not self.package.is_file():
            raise ValueError("NEX package not found. Select its actual extracted location.")
        if self.resume is not None:
            if not (self.resume / "memory.zip").is_file() or not (self.resume / "session.json").is_file():
                raise ValueError("Choose a saved session containing memory.zip and session.json.")
            return self.resume
        destination = self.root / uuid.uuid4().hex
        destination.mkdir(parents=True, exist_ok=False)
        return destination


class SignalLog(logging.Handler):
    def __init__(self, signal):
        super().__init__()
        self.signal = signal
        self.setFormatter(logging.Formatter("%(asctime)s %(levelname)s %(message)s"))

    def emit(self, record):
        self.signal.emit(self.format(record))


class SessionWorker(QThread):
    snapshot = pyqtSignal(dict)
    frame = pyqtSignal(bytes)
    asset = pyqtSignal(dict)
    message = pyqtSignal(str)
    failed = pyqtSignal(str)

    def __init__(self, options, parent=None):
        super().__init__(parent)
        self.options = options
        self.screen = 0
        self.selected_asset = None
        self.state = None
        self.url = None
        self.last_publish = 0
        self.asset_revision = None
        self.assets = []
        self.power_cycle_requested = threading.Event()

    def service_controls(self, device):
        if self.power_cycle_requested.is_set():
            self.power_cycle_requested.clear()
            try:
                device.power_cycle()
            except (OSError, ValueError) as error:
                self.failed.emit("Power cycle failed: " + str(error))

    def publish(self, device):
        self.service_controls(device)
        if time.monotonic() - self.last_publish < 0.5:
            return
        self.last_publish = time.monotonic()
        with device.lock:
            if self.asset_revision != device.resources.revision:
                self.assets = [{"kind": kind, "name": name, "bytes": len(payload)}
                               for (kind, name), payload in sorted(device.resources.items.items())
                               if name not in (SPLASH_RESOURCE, ALERT_RESOURCE)]
                self.asset_revision = device.resources.revision
            update = device.sandbox.summary() if device.sandbox else None
            state = {"mode": "boot" if device.boot_mode else "main", "requests": device.requests,
                     "update": update, "assets": self.assets, "events": list(reversed(device.events[-40:])),
                     "state": str(self.state), "url": self.url,
                     "display": device.display_state(),
                     "component": device.sandbox.component_sha256() if device.sandbox else None}
            selection = self.selected_asset
            self.selected_asset = None
            payload = device.resources.items.get(selection) if selection else None
        self.snapshot.emit(state)
        if selection and payload is not None:
            self.asset.emit({"name": selection[1], "payload": payload, "url": self.url})
        output = io.BytesIO()
        render_layout(device, self.screen).save(output, format="PNG")
        self.frame.emit(output.getvalue())

    def run(self):
        device = None
        server = None
        serial_port = None
        handlers = []
        logger = logging.getLogger("ic7")
        previous_level = logger.level
        try:
            if self.options.port:
                from serial.tools.list_ports import comports
                if self.options.port not in virtual_ports(comports()):
                    raise ValueError("Selected port is not identified as virtual. Physical serial ports are not supported.")
            self.state = self.options.create_state()
            handlers = [logging.FileHandler(self.state / "emulator.log", encoding="utf-8"), SignalLog(self.message)]
            handlers[0].setFormatter(logging.Formatter("%(asctime)s %(levelname)s %(message)s"))
            for handler in handlers:
                logger.addHandler(handler)
            logger.setLevel(logging.INFO)
            device = Device(self.options.profile, self.state, capture_path=self.state / "protocol.jsonl",
                            sandbox_package=self.options.package)
            server = start_viewer(device, 0)
            self.url = f"http://127.0.0.1:{server.server_port}"
            logger.info("workbench-session state=%s transport=%s", self.state, self.options.port or "preview-only")
            if self.options.port:
                import serial
                serial_port = serial.Serial(self.options.port, baudrate=9600, timeout=0.1, write_timeout=5)

                def read():
                    if self.isInterruptionRequested():
                        return b""
                    self.publish(device)
                    return serial_port.read(min(65536, max(1, serial_port.in_waiting))) or None

                serve_stream(device, read, serial_port.write)
            else:
                while not self.isInterruptionRequested():
                    self.publish(device)
                    self.msleep(50)
        except Exception as error:
            self.failed.emit(str(error))
        finally:
            if serial_port is not None:
                serial_port.close()
            if server is not None:
                server.shutdown()
                server.server_close()
            if device is not None:
                try:
                    device.save()
                except Exception as error:
                    self.failed.emit("Session save failed: " + str(error))
                finally:
                    device.close()
            for handler in handlers:
                logger.removeHandler(handler)
                handler.close()
            logger.setLevel(previous_level)


class DashPreview(QLabel):
    def __init__(self):
        super().__init__("No session")
        self.image = QPixmap()
        self.setAlignment(Qt.AlignCenter)
        self.setMinimumSize(320, 192)
        self.setSizePolicy(QSizePolicy.Expanding, QSizePolicy.Expanding)
        self.setStyleSheet("background:#111; color:#aaa;")

    def show_bytes(self, payload):
        self.image.loadFromData(payload)
        self.refresh()

    def refresh(self):
        if not self.image.isNull():
            self.setPixmap(self.image.scaled(self.size(), Qt.KeepAspectRatio, Qt.SmoothTransformation))

    def resizeEvent(self, event):
        self.refresh()
        super().resizeEvent(event)


class Workbench(QMainWindow):
    def __init__(self, package=None, state_root=None):
        super().__init__()
        self.worker = None
        self.renderer = None
        self.state_root = state_root or ROOT / "workbench-state"
        self.state = None
        self.snapshot = None
        self.movie = None
        self.movie_buffer = None
        self.player = None
        self.resource_signature = None
        self.closing = False
        self.available_ports = []
        self.port_setup_process = None
        self.alert_previews = []
        self.resume_state = None
        self.auto_renderer_started = False
        self.setWindowTitle("iC-7 NSP Sandbox | Unofficial Workbench")
        self.resize(1200, 800)
        self.setMinimumSize(800, 600)
        self.setStyleSheet("""
            QMainWindow, QWidget { background:#292929; color:#e3e3e3; }
            QToolBar { background:#202020; spacing:8px; padding:7px; border-bottom:1px solid #555; }
            QLineEdit, QComboBox, QPlainTextEdit, QListWidget, QTableWidget { background:#202020; border:1px solid #555; selection-background-color:#526269; padding:4px; }
            QPushButton { background:#404040; border:1px solid #666; padding:6px 12px; border-radius:3px; }
            QPushButton:disabled { color:#777; }
            QTabBar::tab { background:#202020; padding:9px 18px; border-bottom:2px solid #202020; }
            QTabBar::tab:selected { border-bottom:2px solid #dfbd36; background:#333; }
            QHeaderView::section { background:#383838; padding:5px; border:0; }
            QProgressBar { border:1px solid #666; background:#202020; text-align:center; min-height:22px; }
            QProgressBar::chunk { background:#377c68; }
            QStatusBar { background:#202020; }
        """)
        toolbar = QToolBar("Session", self)
        toolbar.setMovable(False)
        toolbar.setToolButtonStyle(Qt.ToolButtonTextBesideIcon)
        self.addToolBar(toolbar)
        self.start_action = self.action(toolbar, "Start Session", QStyle.SP_MediaPlay, self.start_session)
        self.resume_action = self.action(toolbar, "Resume Dash", QStyle.SP_DialogOpenButton, self.resume_session)
        self.stop_action = self.action(toolbar, "Stop", QStyle.SP_MediaStop, self.stop_session)
        self.stop_action.setEnabled(False)
        self.power_action = self.action(toolbar, "Power Cycle", QStyle.SP_BrowserReload, self.power_cycle)
        self.power_action.setEnabled(False)
        toolbar.addSeparator()
        self.renderer_action = self.action(toolbar, "Dash Display", QStyle.SP_ComputerIcon, self.start_renderer)
        self.renderer_action.setEnabled(False)
        self.alert_action = self.action(toolbar, "Preview Alert", QStyle.SP_MessageBoxWarning, self.preview_alert)
        self.alert_action.setEnabled(False)
        self.action(toolbar, "Launch NSP", QStyle.SP_DesktopIcon, self.launch_nsp)
        self.folder_action = self.action(toolbar, "Session Folder", QStyle.SP_DirOpenIcon, self.open_state)
        self.folder_action.setEnabled(False)
        self.export_action = self.action(toolbar, "Export Logs", QStyle.SP_DialogSaveButton, self.export_session)
        self.export_action.setEnabled(False)
        central = QWidget()
        layout = QVBoxLayout(central)
        configuration = QHBoxLayout()
        configuration.addWidget(QLabel("Virtual port"))
        self.port = QComboBox()
        self.port.setMinimumWidth(150)
        configuration.addWidget(self.port)
        self.refresh_ports = QPushButton()
        self.refresh_ports.setIcon(self.style().standardIcon(QStyle.SP_BrowserReload))
        self.refresh_ports.setToolTip("Refresh virtual serial ports")
        self.refresh_ports.clicked.connect(self.scan_ports)
        configuration.addWidget(self.refresh_ports)
        configuration.addWidget(QLabel("NEX package"))
        self.package = QLineEdit(str(package) if package else "")
        self.package.setReadOnly(True)
        self.package.setPlaceholderText("No package selected")
        configuration.addWidget(self.package, 1)
        self.browse = QPushButton()
        self.browse.setIcon(self.style().standardIcon(QStyle.SP_DialogOpenButton))
        self.browse.setToolTip("Choose a resource-only NEX package")
        self.browse.clicked.connect(self.choose_package)
        configuration.addWidget(self.browse)
        self.clear_package = QPushButton()
        self.clear_package.setIcon(self.style().standardIcon(QStyle.SP_DialogResetButton))
        self.clear_package.setToolTip("Clear selected package")
        self.clear_package.clicked.connect(self.package.clear)
        configuration.addWidget(self.clear_package)
        layout.addLayout(configuration)
        self.auto_renderer = QCheckBox("Open the real NSP dash renderer automatically (Windows)")
        self.auto_renderer.setChecked(sys.platform == "win32")
        self.auto_renderer.setEnabled(sys.platform == "win32")
        layout.addWidget(self.auto_renderer)
        self.tabs = QTabWidget()
        self.preview = DashPreview()
        dash = QWidget()
        dash_layout = QVBoxLayout(dash)
        screen_row = QHBoxLayout()
        screen_row.addWidget(QLabel("Screen"))
        self.screen = QComboBox()
        self.screen.addItems([str(index + 1) for index in range(16)])
        self.screen.currentIndexChanged.connect(self.change_screen)
        screen_row.addWidget(self.screen)
        screen_row.addStretch()
        screen_row.addWidget(QLabel("Layout approximation | sensor values unavailable"))
        dash_layout.addLayout(screen_row)
        dash_layout.addWidget(self.preview, 1)
        self.tabs.addTab(dash, "Layout Diagnostic (not dash display)")
        resources = QSplitter()
        self.resources = QListWidget()
        self.resources.currentRowChanged.connect(self.select_resource)
        resources.addWidget(self.resources)
        resource_view = QWidget()
        resource_layout = QVBoxLayout(resource_view)
        self.resource_preview = DashPreview()
        resource_layout.addWidget(self.resource_preview, 1)
        self.resource_details = QLabel()
        self.resource_details.setWordWrap(True)
        resource_layout.addWidget(self.resource_details)
        resources.addWidget(resource_view)
        resources.setSizes([300, 700])
        self.tabs.addTab(resources, "Resources")
        update_page = QWidget()
        update_layout = QVBoxLayout(update_page)
        form = QFormLayout()
        self.update_fields = {}
        for title in ("Mode", "Package", "Transfer", "Sandbox status", "Preview", "Error"):
            label = QLabel("--")
            label.setWordWrap(True)
            label.setTextInteractionFlags(Qt.TextSelectableByMouse)
            self.update_fields[title] = label
            form.addRow(title, label)
        update_layout.addLayout(form)
        self.progress = QProgressBar()
        update_layout.addWidget(self.progress)
        update_layout.addStretch()
        self.tabs.addTab(update_page, "Update")
        self.traffic = QTableWidget(0, 4)
        self.traffic.setHorizontalHeaderLabels(["Time", "Operation", "Address", "Bytes"])
        self.traffic.setEditTriggers(QTableWidget.NoEditTriggers)
        self.traffic.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)
        self.traffic.verticalHeader().hide()
        self.tabs.addTab(self.traffic, "Traffic")
        self.log = QPlainTextEdit()
        self.log.setReadOnly(True)
        self.log.setMaximumBlockCount(3000)
        self.log.setFont(QFont("Consolas", 9))
        self.tabs.addTab(self.log, "Log")
        layout.addWidget(self.tabs, 1)
        self.setCentralWidget(central)
        self.mode_label = QLabel("Stopped")
        self.statusBar().addWidget(self.mode_label, 1)
        self.statusBar().addPermanentWidget(QLabel("Unofficial | Virtual device | Hardware execution off"))
        self.scan_ports()

    def action(self, toolbar, title, icon, callback):
        action = QAction(self.style().standardIcon(icon), title, self)
        action.setToolTip(title)
        action.triggered.connect(callback)
        toolbar.addAction(action)
        return action

    def scan_ports(self):
        previous = self.port.currentData()
        self.port.clear()
        self.port.addItem("Preview only", None)
        try:
            from serial.tools.list_ports import comports
            self.available_ports = list(comports())
            for name in virtual_ports(self.available_ports):
                self.port.addItem(name, name)
        except ImportError:
            self.available_ports = []
            self.statusBar().showMessage("pyserial is unavailable; preview only")
        pair = load_pair_config(PAIR_CONFIG)
        if previous:
            self.port.setCurrentIndex(max(0, self.port.findData(previous)))
        elif pair and self.port.findData(pair["emulator_port"]) > 0:
            self.port.setCurrentIndex(self.port.findData(pair["emulator_port"]))
            self.statusBar().showMessage(
                f"Configured pair: NSP {pair['nsp_port']} <-> emulator {pair['emulator_port']} ({pair.get('driver')})")

    def prepare_nsp_port(self):
        if sys.platform != "win32":
            return
        configured = configured_nsp_port(self.available_ports)
        if configured:
            self.statusBar().showMessage(f"NSP discovery is ready on {configured}")
            return
        pair = load_pair_config(PAIR_CONFIG)
        candidates = preferred_first(virtual_ports(self.available_ports), pair and pair["nsp_port"])
        if not candidates:
            return
        answer = QMessageBox.question(
            self, "Prepare NSP discovery",
            "NSP only discovers ports labeled Haltech. Prepare the NSP-facing virtual COM port now? "
            "This requests Administrator approval once. Keep the physical dash disconnected.",
            QMessageBox.Yes | QMessageBox.No, QMessageBox.Yes)
        if answer != QMessageBox.Yes:
            return
        port, accepted = QInputDialog.getItem(
            self, "Select NSP port",
            "Choose the virtual COM port NSP will open, not the workbench's emulator port:",
            candidates, 0, False)
        if accepted:
            self.label_nsp_port(port)

    def label_nsp_port(self, port):
        if not re.fullmatch(r"COM\d+", port, re.IGNORECASE):
            QMessageBox.warning(self, "NSP port setup", "Select a valid virtual COM port.")
            return
        script_path = str(ROOT / "set-nsp-port.ps1")
        arguments = f'-NoProfile -ExecutionPolicy Bypass -File "{script_path}" -Port {port}'
        arguments = arguments.replace("'", "''")
        command = (
            "$ErrorActionPreference = 'Stop'; "
            f"$arguments = '{arguments}'; "
            "try { $result = Start-Process -FilePath 'powershell.exe' -Verb RunAs -Wait -PassThru "
            "-ErrorAction Stop -ArgumentList $arguments; exit $result.ExitCode } "
            "catch { [Console]::Error.WriteLine($_.Exception.Message); exit 1 }"
        )
        encoded = base64.b64encode(command.encode("utf-16le")).decode("ascii")
        process = QProcess(self)
        self.port_setup_process = process
        process.finished.connect(self.nsp_port_setup_finished)
        process.errorOccurred.connect(lambda _: self.nsp_port_setup_failed(process.errorString()))
        process.start("powershell.exe", ["-NoProfile", "-EncodedCommand", encoded])
        self.statusBar().showMessage(f"Waiting for Administrator approval to prepare {port} for NSP")

    def nsp_port_setup_finished(self, exit_code, exit_status):
        process = self.port_setup_process
        if process is None:
            return
        errors = bytes(process.readAllStandardError()).decode("utf-8", "replace").strip()
        process.deleteLater()
        self.port_setup_process = None
        if exit_code != 0 or exit_status != QProcess.NormalExit:
            self.nsp_port_setup_failed(errors or "Port setup was cancelled or failed.")
            return
        self.scan_ports()
        self.statusBar().showMessage("NSP port prepared. Restart NSP, then select the other COM port for the workbench.")

    def nsp_port_setup_failed(self, message):
        if self.port_setup_process is not None:
            self.port_setup_process.deleteLater()
            self.port_setup_process = None
        QMessageBox.warning(self, "NSP port setup", message or "Port setup was cancelled or failed.")

    def choose_package(self):
        path, _ = QFileDialog.getOpenFileName(self, "Select resource-only NEX", "", "NEX packages (*.nex)")
        if path:
            self.package.setText(path)

    def start_session(self, checked=False):
        if self.worker is not None:
            return
        port = self.port.currentData()
        if port and QMessageBox.warning(self, "Virtual device only",
                f"Start on {port}? NSP must use the other end of the virtual pair. Disconnect the physical dash.",
                QMessageBox.Ok | QMessageBox.Cancel, QMessageBox.Cancel) != QMessageBox.Ok:
            return
        package = Path(self.package.text()) if self.package.text() else None
        options = SessionOptions(ROOT / "device-profile.zip", self.state_root, package, port, self.resume_state)
        self.resume_state = None
        self.worker = SessionWorker(options, self)
        self.worker.snapshot.connect(self.receive_snapshot)
        self.worker.frame.connect(self.preview.show_bytes)
        self.worker.asset.connect(self.show_resource)
        self.worker.message.connect(self.log.appendPlainText)
        self.worker.failed.connect(self.session_error)
        self.worker.finished.connect(self.session_finished)
        self.log.clear()
        self.resources.clear()
        self.resource_signature = None
        self.snapshot = None
        self.auto_renderer_started = False
        self.set_running(True)
        self.mode_label.setText("Starting session")
        self.worker.start()

    def resume_session(self):
        folder = QFileDialog.getExistingDirectory(self, "Resume a saved dash session", str(self.state_root))
        if folder:
            self.resume_state = Path(folder)
            self.start_session()
            self.resume_state = None

    def power_cycle(self):
        if self.worker:
            self.worker.power_cycle_requested.set()

    def export_session(self):
        if self.worker or self.renderer or self.alert_previews or not self.state:
            return
        filename, _ = QFileDialog.getSaveFileName(
            self, "Export complete emulator logs", str(self.state.parent / (self.state.name + "-logs.zip")),
            "ZIP files (*.zip)")
        if not filename:
            return
        try:
            export_session_archive(self.state, Path(filename))
        except (OSError, ValueError, zipfile.BadZipFile) as error:
            self.session_error("Cannot export session: " + str(error))
            return
        self.statusBar().showMessage("Complete session exported: " + filename)

    def set_running(self, running):
        self.start_action.setEnabled(not running)
        self.resume_action.setEnabled(not running)
        self.stop_action.setEnabled(running)
        self.power_action.setEnabled(running)
        self.update_export_action()
        for widget in (self.port, self.refresh_ports, self.package, self.browse, self.clear_package):
            widget.setEnabled(not running)

    def stop_session(self):
        if self.worker:
            self.worker.requestInterruption()
            self.stop_action.setEnabled(False)
            self.mode_label.setText("Saving session")
        if self.renderer is not None:
            try:
                (self.state / "renderer.stop").touch()
            except OSError as error:
                self.session_error("Cannot request dash display shutdown: " + str(error))
        for process in list(self.alert_previews):
            process.terminate()

    def session_finished(self):
        self.worker.deleteLater()
        self.worker = None
        self.set_running(False)
        self.renderer_action.setEnabled(False)
        self.alert_action.setEnabled(False)
        self.mode_label.setText("Stopped | session saved" if self.state else "Stopped")
        if self.closing:
            self.close()

    def session_error(self, message):
        self.log.appendPlainText("ERROR " + message)
        self.statusBar().showMessage(message)
        if not self.closing:
            QMessageBox.critical(self, "Session error", message)

    def receive_snapshot(self, state):
        self.snapshot = state
        self.state = Path(state["state"])
        self.folder_action.setEnabled(True)
        self.renderer_action.setEnabled(sys.platform == "win32" and self.renderer is None)
        self.alert_action.setEnabled(True)
        self.power_action.setEnabled(state["mode"] == "main")
        self.mode_label.setText(f"{state['mode'].upper()} | {state['requests']:,} requests | {self.state.name[:8]}")
        update = state["update"] or {}
        values = {"Mode": state["mode"].upper(), "Package": update.get("package", "None"),
                  "Transfer": f"{update.get('received_bytes', 0):,} / {update.get('expected_bytes', 0):,} bytes",
              "Sandbox status": update.get("status", "No update package selected"),
              "Preview": "Local sidecar preview" if update.get("component_active") else "Not loaded",
                  "Error": update.get("error") or "None"}
        for title, text in values.items():
            self.update_fields[title].setText(text)
        expected = update.get("expected_bytes", 0)
        self.progress.setValue(int(100 * update.get("received_bytes", 0) / expected) if expected else 0)
        signature = [(item["kind"], item["name"], item["bytes"]) for item in state["assets"]]
        if signature != self.resource_signature:
            self.resource_signature = signature
            self.resources.clear()
            self.resources.addItems([f"{item['name']}    {item['bytes']:,} B" for item in state["assets"]])
        self.traffic.setRowCount(len(state["events"]))
        for row, event in enumerate(state["events"]):
            for column, field in enumerate(("time", "operation", "address", "bytes")):
                self.traffic.setItem(row, column, QTableWidgetItem(str(event[field])))
        if self.auto_renderer.isChecked() and not self.auto_renderer_started:
            self.auto_renderer_started = True
            self.start_renderer()

    def change_screen(self, screen):
        if self.worker:
            self.worker.screen = screen

    def select_resource(self, row):
        if self.worker and self.snapshot and 0 <= row < len(self.snapshot["assets"]):
            resource = self.snapshot["assets"][row]
            self.worker.selected_asset = (resource["kind"], resource["name"])

    def show_resource(self, resource):
        if self.movie:
            self.movie.stop()
            self.resource_preview.setMovie(None)
            self.movie = None
            self.movie_buffer.close()
        if self.player:
            self.player.stop()
        payload = resource["payload"]
        self.resource_details.setText(f"{resource['name']} | {len(payload):,} bytes")
        self.resource_preview.clear()
        self.resource_preview.image = QPixmap()
        if payload.startswith((b"GIF87a", b"GIF89a")):
            self.movie_buffer = QBuffer(self)
            self.movie_buffer.setData(QByteArray(payload))
            self.movie_buffer.open(QIODevice.ReadOnly)
            self.movie = QMovie(self.movie_buffer, b"gif", self)
            self.resource_preview.setMovie(self.movie)
            self.movie.start()
        elif is_video_resource(resource["name"]):
            url = QUrl(resource["url"] + "/?asset=" + QUrl.toPercentEncoding(resource["name"]).data().decode())
            if QDesktopServices.openUrl(url):
                self.resource_preview.setText(
                    "MP4 playback opened in the browser viewer (not in this panel).")
            else:
                self.session_error("Could not open MP4 browser preview: " + url.toString())
        else:
            self.resource_preview.show_bytes(payload)
            if self.resource_preview.image.isNull():
                self.resource_preview.setText("No image preview")

    def start_renderer(self):
        if not self.snapshot or self.renderer is not None:
            return
        process = QProcess(self)
        process.setProcessChannelMode(QProcess.MergedChannels)
        process.readyReadStandardOutput.connect(lambda: self.renderer_output(process))
        process.finished.connect(self.renderer_finished)
        process.errorOccurred.connect(self.renderer_error)
        self.renderer = process
        self.renderer_action.setEnabled(False)
        stop_file = self.state / "renderer.stop"
        stop_file.unlink(missing_ok=True)
        process.start(sys.executable, ["-u", str(ROOT / "stock_renderer.py"), "--url", self.snapshot["url"],
                                      "--work", str(self.state / "stock-renderer"), "--stop-file", str(stop_file)])

    def renderer_message(self, message):
        self.log.appendPlainText(message.rstrip())
        try:
            with (self.state / "renderer.log").open("a", encoding="utf-8") as stream:
                stream.write(message.rstrip() + "\n")
        except OSError as error:
            self.statusBar().showMessage("Cannot save renderer log: " + str(error))

    def renderer_error(self, error):
        self.renderer_message("Renderer error: " + self.renderer.errorString())
        if error == QProcess.FailedToStart:
            self.renderer.deleteLater()
            self.renderer = None
            self.renderer_action.setEnabled(self.worker is not None and sys.platform == "win32")
            self.update_export_action()
            if self.closing and self.worker is None:
                self.close()

    def renderer_output(self, process):
        text = bytes(process.readAllStandardOutput()).decode("utf-8", "replace")
        if text:
            self.renderer_message(text)

    def renderer_finished(self, exit_code=0, exit_status=QProcess.NormalExit):
        self.renderer_output(self.renderer)
        if exit_code or exit_status != QProcess.NormalExit:
            self.renderer_message(f"Dash display stopped (exit {exit_code}); check renderer.log, then click Dash Display to retry.")
        self.renderer.deleteLater()
        self.renderer = None
        self.renderer_action.setEnabled(self.worker is not None and sys.platform == "win32")
        self.update_export_action()
        if self.closing and self.worker is None and not self.alert_previews:
            self.close()

    def update_export_action(self):
        self.export_action.setEnabled(self.worker is None and self.renderer is None and
                                      not self.alert_previews and self.state is not None)

    def alert_finished(self, process):
        self.renderer_output(process)
        if process in self.alert_previews:
            self.alert_previews.remove(process)
        process.deleteLater()
        self.update_export_action()
        if self.closing and self.worker is None and self.renderer is None and not self.alert_previews:
            self.close()

    def alert_error(self, process, error):
        self.renderer_message("Alert preview: " + process.errorString())
        if error == QProcess.FailedToStart:
            self.alert_finished(process)

    def preview_alert(self):
        if not self.snapshot:
            return
        url = self.snapshot["url"]
        texts = []
        try:
            query = urllib.parse.urlencode({"kind": 0, "name": ALERT_RESOURCE})
            with urllib.request.urlopen(url.rstrip("/") + "/api/resource?" + query, timeout=2) as response:
                texts = alert_preview_texts(response.read())
        except urllib.error.HTTPError as error:
            if error.code != 404:
                self.session_error("Could not read the uploaded alert configuration: " + str(error))
                return
        except (OSError, ValueError) as error:
            self.session_error("Could not read the uploaded alert configuration: " + str(error))
            return
        prompt = ("Exact alarm Message text to display (uploaded overrides listed). "
                  "This is a synthetic preview; it does not evaluate thresholds."
                  if texts else
                  "No alert overrides have been uploaded yet; the stock bottom banner will be shown. "
                  "Enter the exact alarm Message text:")
        text, accepted = QInputDialog.getItem(self, "Preview alert", prompt, texts or ["ENGINE RPM OVERREV"], 0, True)
        if not accepted or not text.strip():
            return
        process = QProcess(self)
        process.setProcessChannelMode(QProcess.MergedChannels)
        process.readyReadStandardOutput.connect(lambda: self.renderer_output(process))
        process.errorOccurred.connect(lambda error: self.alert_error(process, error))
        process.finished.connect(lambda *_: self.alert_finished(process))
        self.alert_previews.append(process)
        self.log.appendPlainText("Synthetic alert preview: " + text)
        process.start(sys.executable, [str(ROOT / "native_view.py"), "--url", url, "--preview-alert", text])

    def launch_nsp(self):
        path, _ = QFileDialog.getOpenFileName(self, "Select installed NSP executable", "", "Windows executable (*.exe)")
        if path and not QProcess.startDetached(path, [], str(Path(path).parent))[0]:
            QMessageBox.warning(self, "NSP", "Could not launch the selected application.")

    def open_state(self):
        if self.state:
            QDesktopServices.openUrl(QUrl.fromLocalFile(str(self.state)))

    def closeEvent(self, event):
        if self.worker is not None:
            self.closing = True
            self.stop_session()
            event.ignore()
        elif self.renderer is not None or self.alert_previews:
            self.closing = True
            event.ignore()
        else:
            event.accept()


def main():
    parser = argparse.ArgumentParser(description="Native, unofficial iC-7 NSP sandbox workbench")
    parser.add_argument("--package", type=Path, default=bundled_package())
    parser.add_argument("--state-root", type=Path)
    parser.add_argument("--screenshot", type=Path)
    args = parser.parse_args()
    app = QApplication(sys.argv[:1])
    app.setApplicationName("iC-7 NSP Sandbox")
    app.setFont(QFont("Segoe UI", 10))
    window = Workbench(args.package, args.state_root)
    window.show()
    if args.screenshot:
        window.start_session()

        def capture():
            window.grab().save(str(args.screenshot))
            window.close()

        QTimer.singleShot(3000, capture)
    else:
        QTimer.singleShot(0, window.prepare_nsp_port)
    return app.exec_()


if __name__ == "__main__":
    sys.exit(main())