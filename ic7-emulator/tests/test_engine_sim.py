"""The opt-in engine simulation: Generic CAN encode/decode as the dash, scenarios, alarms, faults."""
import io
import json
from pathlib import Path
import struct
import sys
import tempfile
import unittest
import urllib.request
from unittest.mock import patch

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
import engine_sim as E
from ic7_emulator import Device, request

PROFILE = Path(__file__).resolve().parents[1] / "device-profile.zip"
LAYOUT = E.default_layout_path()


class FakeClock:
    def __init__(self):
        self.now = 1000.0

    def __call__(self):
        return self.now


def run(simulation, clock, seconds, step=0.05):
    for _ in range(int(round(seconds / step))):
        clock.now += step
        simulation.tick()


def int32(device, address):
    return struct.unpack("<i", device.memory.read(address, 4))[0]


@unittest.skipUnless(LAYOUT is not None, "emtron_can.json is required")
class CanCodingTests(unittest.TestCase):
    def test_emtron_layout_round_trips_every_signal(self):
        layout = E.layout_from_json(LAYOUT)
        self.assertEqual(len(layout.signals), 23)
        self.assertEqual([frame.can_id for frame in layout.frames][:2], [0x3E8, 0x3E9])
        for signal in layout.signals:
            low, high = signal.raw_limits()
            for raw in (low, (low + high) // 3, high):
                value = raw * signal.multiplier + signal.offset
                data = E.insert(bytearray(8), signal.start, signal.length, signal.big_endian, signal.encode(value))
                self.assertEqual(E.extract(data, signal.start, signal.length, signal.big_endian, signal.signed), raw,
                                 signal.name)
                self.assertAlmostEqual(signal.physical(data), value, places=3)

    def test_decoded_channels_use_the_dash_converters(self):
        signals = {signal.name: signal for signal in E.layout_from_json(LAYOUT).signals}

        def stored(name, value):
            signal = signals[name]
            data = E.insert(bytearray(8), signal.start, signal.length, signal.big_endian, signal.encode(value))
            return E.signed32(signal.decode(data))

        self.assertEqual(stored("ENGINE_SPEED", 3000), 3000)                     # rpm as is
        self.assertEqual(stored("COOLANT_TEMP", 90.0), 3631)                     # 0.1 K
        self.assertEqual(stored("VEHICLE_SPEED", 100.0), 1000)                   # 0.1 km/h
        self.assertEqual(stored("LAMBDA", 1.0), 1000)
        oil = stored("OIL_PRESSURE", 50.0)                                       # psi gauge -> 0.1 kPa abs
        self.assertAlmostEqual(oil / 10, 50 * 6.894758 + 101.3, delta=0.6)
        self.assertEqual(E.to_internal(1.0, 0xFFFF), None)
        signal = signals["OIL_PRESSURE"]
        bad = E.Signal("X", 0, 0, 0, 16, False, False, 1.0, 0.0, 0xFFFF, 0)
        self.assertEqual(bad.decode(bytes(8)), E.SETTING_INVALID)
        self.assertEqual(signal.unit_name, "psi")

    def test_motorola_signals_round_trip(self):
        for start, length in ((7, 16), (23, 12), (39, 8), (63, 1)):
            data = E.insert(bytearray(8), start, length, True, 0xABC & ((1 << length) - 1))
            self.assertEqual(E.extract(data, start, length, True, False), 0xABC & ((1 << length) - 1))
        data = E.insert(bytearray(8), 7, 16, True, 0x1234)
        self.assertEqual(bytes(data[:2]), b"\x12\x34")

    def test_map_layout_is_read_from_dash_memory_like_the_dash(self):
        with tempfile.TemporaryDirectory() as directory:
            device = Device(PROFILE, directory)
            layout = E.layout_from_memory(device.memory)
        self.assertIsNotNone(layout)
        self.assertEqual(layout.bus.name, "Third Party CAN")
        reference = E.layout_from_json(LAYOUT)
        self.assertEqual(sorted(frame.can_id for frame in layout.frames),
                         sorted(frame.can_id for frame in reference.frames))
        signals = {signal.name: signal for signal in layout.signals}
        self.assertEqual(signals["RPM"].channel, 0x7C90)
        self.assertEqual(signals["OIL PRES"].units, 773)
        self.assertAlmostEqual(signals["MAP"].multiplier, 0.0145038, places=6)
        self.assertAlmostEqual(signals["MAP"].offset, -14.696, places=3)
        self.assertFalse(signals["RPM"].big_endian)


class ScenarioTests(unittest.TestCase):
    def test_timeline_selects_and_loops_phases(self):
        scenario = E.normalise_scenario({"phases": [{"mode": "idle", "duration": 5}, {"mode": "rev", "duration": 5}]})
        timeline = E.Timeline(scenario)
        self.assertEqual(timeline.at(2)[1]["mode"], "idle")
        self.assertEqual(timeline.at(7)[1]["mode"], "rev")
        self.assertEqual(timeline.at(12)[1]["mode"], "idle")
        scenario["loop"] = False
        self.assertTrue(E.Timeline(scenario).at(12)[2])

    def test_presets_drive_realistic_values(self):
        model = E.EngineModel(start_coolant_c=18)
        phase = {"mode": "idle", "duration": 600}
        temperatures = [model.step(1.0, phase, {})["coolant"] for _ in range(300)]
        self.assertTrue(all(b >= a for a, b in zip(temperatures, temperatures[1:])))
        self.assertGreater(temperatures[-1], 60)
        self.assertGreater(model.values["oil_pressure"] - 101.3, 100)    # kPa gauge at idle
        model = E.EngineModel(start_coolant_c=85)
        gears, rpms, speeds = set(), [], []
        for _ in range(int(54 / 0.05)):
            values = model.step(0.05, {"mode": "track"}, {})
            gears.add(values["gear"])
            rpms.append(values["rpm"])
            speeds.append(values["speed"])
        self.assertGreaterEqual(len(gears - {0}), 3)
        self.assertLess(max(rpms), 7800 + 50)
        self.assertGreater(max(speeds), 150)
        over = E.EngineModel(start_coolant_c=85)
        peak = max(over.step(0.05, {"mode": "rev", "rpm": 8600, "period": 5}, {"rev_limit": 9000})["rpm"]
                   for _ in range(100))
        self.assertGreater(peak, 8200)

    def test_every_preset_is_valid_and_saveable(self):
        with tempfile.TemporaryDirectory() as directory:
            for name in E.PRESETS:
                scenario = E.preset(name)
                path = Path(directory) / f"{name}.json"
                E.save_scenario(scenario, path)
                self.assertEqual(E.load_scenario(path), scenario)
            with self.assertRaises(ValueError):
                E.load_scenario(Path(directory) / "missing.json")
            (Path(directory) / "bad.json").write_text('{"phases": [{"mode": "fly", "duration": 1}]}')
            with self.assertRaises(ValueError):
                E.load_scenario(Path(directory) / "bad.json")

    def test_signal_names_bind_to_engine_quantities(self):
        for name, quantity in (("RPM", "rpm"), ("ENGINE_SPEED", "rpm"), ("MAP", "map"), ("ENG TEMP", "coolant"),
                               ("INLET AIR TEMP", "iat"), ("OIL PRES", "oil_pressure"), ("OIL TEMP", "oil_temp"),
                               ("LAMBDA TGT", "lambda_target"), ("LAMBDA", "lambda"), ("SPEED", "speed"),
                               ("IGN BASE", "ign_base"), ("IGN ANGLE", "ign_angle"), ("CAM TGT", "cam_target"),
                               ("FLEX", "ethanol"), ("DTC COUNT", "dtc_count")):
            self.assertEqual(E.quantity_for(name)[0], quantity, name)


class DashBehaviourTests(unittest.TestCase):
    def setUp(self):
        self.directory = tempfile.TemporaryDirectory()
        self.clock = FakeClock()
        self.device = Device(PROFILE, self.directory.name, clock=self.clock)

    def tearDown(self):
        self.device.close()
        self.directory.cleanup()

    def read_packet(self, address, length):
        return self.device.respond(request(2, 1, address, length))[12:-4]

    def test_default_is_off_and_leaves_memory_unchanged(self):
        before = self.device.memory.read(0x1400, 0x7FE4 - 0x1400)
        self.assertIsNone(self.device.engine)
        self.assertNotIn("engine_simulation", self.device.display_state())
        self.assertFalse(self.device.engine_status()["running"])
        self.assertEqual(self.read_packet(0x1400, 13312), before[:13312])

    def test_low_oil_pressure_raises_the_maps_alarm_for_nsp_and_the_renderer(self):
        simulation = self.device.start_engine_sim("low-oil-pressure", threaded=False)
        run(simulation, self.clock, 6)
        self.assertEqual(int32(self.device, E.ALARM_ACTIVE + 4 * 3), 0, "no alarm while oil pressure is healthy")
        run(simulation, self.clock, 20)
        status = simulation.status()
        self.assertIn("Low Oil Pressure", [alarm["text"] for alarm in status["alarms"]])
        # NSP sees the alarm-active channel and the low oil channel through its normal live-data polling.
        polled = self.read_packet(0x4800, 13312)
        self.assertEqual(struct.unpack_from("<i", polled, E.ALARM_ACTIVE + 12 - 0x4800)[0], 1)
        # Third Party Generic CAN channels sit in NSP's third poll block (0x7C00, 996 bytes).
        oil = struct.unpack_from("<i", self.read_packet(0x7C00, 996), 0x7C90 + 4 * 4 - 0x7C00)[0]
        self.assertLess(oil, 1703)   # below the map's Low Oil Pressure threshold (10 psi)
        self.assertGreater(int32(self.device, E.RPM_CHANNEL), 449)
        # The renderer receives the dash's own popup message.
        message = self.device.display_state()["engine_alarm_message"]
        self.assertEqual(json.loads(message)[0]["text"], "Low Oil Pressure")
        self.assertEqual(list(json.loads(message)[0]), ["text", "bc", "height", "img", "fc"])

    def test_engine_gate_reads_the_ecu_rpm_channel_like_the_dash(self):
        scenario = E.preset("low-oil-pressure")
        scenario["ecu_rpm_channel"] = False   # only Generic CAN: the dash's RPM channel stays 0
        simulation = self.device.start_engine_sim(scenario, threaded=False)
        run(simulation, self.clock, 26)
        self.assertEqual(int32(self.device, E.ALARM_ACTIVE + 12), 0)
        self.assertEqual(simulation.status()["alarms"], [])

    def test_upper_threshold_alarm_and_clear_after_seconds(self):
        simulation = self.device.start_engine_sim("over-rev", threaded=False)
        run(simulation, self.clock, 6)
        self.assertEqual(int32(self.device, E.ALARM_ACTIVE), 1)   # Engine RPM Overrev, upper 8200
        clear_after = simulation.alarms.settings(self.device.memory, 0)["clear_after"]
        self.assertEqual(clear_after, 10)
        simulation.load(E.preset("idle"))
        run(simulation, self.clock, 0.5)
        self.assertEqual(int32(self.device, E.ALARM_ACTIVE), 1, "the alarm holds for its clear time")
        run(simulation, self.clock, clear_after + 1)
        self.assertEqual(int32(self.device, E.ALARM_ACTIVE), 0)

    def test_frame_dropout_times_out_like_the_dash(self):
        simulation = self.device.start_engine_sim("idle", threaded=False)
        run(simulation, self.clock, 1)
        self.assertGreater(int32(self.device, 0x7C90), 600)
        simulation.inject("frame_dropout", "RPM", 10)
        run(simulation, self.clock, 1.5)
        self.assertGreater(int32(self.device, 0x7C90), 600, "still within the 2 s receive timeout")
        run(simulation, self.clock, 1)
        self.assertEqual(int32(self.device, 0x7C90) & 0xFFFFFFFF, E.DEVICE_TIME_OUT)
        self.assertGreater(int32(self.device, 0x7C90 + 4 * 4), 0, "other frames keep updating")
        run(simulation, self.clock, 8)
        self.assertGreater(int32(self.device, 0x7C90), 600, "recovers when frames return")

    def test_signal_dropout_stuck_and_hold(self):
        simulation = self.device.start_engine_sim("track-lap", threaded=False)
        run(simulation, self.clock, 3)
        simulation.inject("signal_dropout", "OIL PRES", 2)
        run(simulation, self.clock, 0.5)
        self.assertEqual(simulation.status()["signals"]["OIL PRES"]["raw"], 0)
        simulation.inject("stuck", "RPM", 5)
        run(simulation, self.clock, 0.2)
        first = int32(self.device, 0x7C90)
        run(simulation, self.clock, 3)
        self.assertEqual(int32(self.device, 0x7C90), first)
        simulation.set_override("ENG TEMP", 120.0)
        run(simulation, self.clock, 0.2)
        self.assertEqual(int32(self.device, 0x7C90 + 8), 120 * 10 + 2731)

    def test_can_timeout_and_no_frames(self):
        scenario = E.preset("idle")
        scenario["faults"] = [{"type": "no_frames", "start": 0, "duration": 3}]
        simulation = self.device.start_engine_sim(scenario, threaded=False)
        run(simulation, self.clock, 2.5)
        self.assertEqual(int32(self.device, 0x7C90) & 0xFFFFFFFF, E.NO_SIGNAL)
        run(simulation, self.clock, 1)
        self.assertGreater(int32(self.device, 0x7C90), 600)
        simulation.inject("can_timeout", None, 30)
        run(simulation, self.clock, 2.1)
        self.assertTrue(all(int32(self.device, 0x7C90 + 4 * index) & 0xFFFFFFFF == E.DEVICE_TIME_OUT
                            for index in range(23)))

    @unittest.skipUnless(LAYOUT is not None, "emtron_can.json is required")
    def test_without_generic_can_in_the_map_the_emtron_layout_is_the_fallback(self):
        for bus in E.BUSES:
            self.device.memory.write(E.SETTINGS_BASE + bus.enable, b"\0")
        simulation = self.device.start_engine_sim("idle", threaded=False)
        self.assertIn("emtron_can.json", simulation.layout_now.source)
        run(simulation, self.clock, 0.5)
        self.assertGreater(int32(self.device, 0x7C90), 600)   # ENGINE_SPEED, the first signal

    def test_raw_can_view_follows_nsps_realtime_id(self):
        simulation = self.device.start_engine_sim("idle", threaded=False)
        bus = simulation.layout_now.bus
        self.device.respond(request(1, 2, bus.realtime_can_id, 4, struct.pack("<I", 0x3E8)))
        run(simulation, self.clock, 0.2)
        data = self.read_packet(bus.realtime_data, 8)
        self.assertEqual(int.from_bytes(data[:2], "little"), simulation.status()["signals"]["RPM"]["raw"])

    def test_stop_marks_signals_timed_out_and_restores_dash_inputs(self):
        rpm_before = self.device.memory.read(E.RPM_CHANNEL, 4)
        simulation = self.device.start_engine_sim("low-oil-pressure", threaded=False)
        run(simulation, self.clock, 2)
        self.device.stop_engine_sim()
        self.assertEqual(self.device.memory.read(E.RPM_CHANNEL, 4), rpm_before)
        self.assertEqual(int32(self.device, 0x7C90) & 0xFFFFFFFF, E.DEVICE_TIME_OUT)
        self.assertEqual(int32(self.device, E.ALARM_ACTIVE + 12), 0)
        self.assertNotIn("engine_simulation", self.device.display_state())

    def test_decoding_pauses_while_the_dash_reboots(self):
        simulation = self.device.start_engine_sim("idle", threaded=False)
        run(simulation, self.clock, 0.5)
        sent = simulation.frames_sent
        self.device._go_quiet(2.0, "application restart")
        run(simulation, self.clock, 1)
        self.assertEqual(simulation.frames_sent, sent)
        run(simulation, self.clock, 2)
        self.assertGreater(simulation.frames_sent, sent)

    def test_status_api_and_saved_scenario_are_labelled_simulation(self):
        from viewer import start_viewer
        self.device.start_engine_sim("overheat", threaded=False)
        server = start_viewer(self.device, 0)
        try:
            with urllib.request.urlopen(f"http://127.0.0.1:{server.server_port}/api/engine") as response:
                status = json.load(response)
        finally:
            server.shutdown()
            server.server_close()
        self.assertTrue(status["simulation"])
        self.assertEqual(status["label"], "ENGINE SIMULATION")
        self.device.save()
        saved = json.loads((Path(self.directory.name) / "engine-simulation.json").read_text())
        self.assertTrue(saved["simulation"])
        self.assertEqual(saved["name"], "overheat")


class AlarmFormattingTests(unittest.TestCase):
    def test_colour_and_message_match_draw_alarms(self):
        self.assertEqual(E.color_string(0x14DDFF99), "#99ffdd14")
        alarm = {"text": "A VERY LONG ALARM NAME HERE", "bc": "#1", "fc": "#2"}
        import native_view
        self.assertEqual(E.alarm_message([alarm]),
                         native_view.native_alarm_message([{**alarm, "height": "60", "img": ""}]))

    def test_native_view_shows_live_engine_alarms_not_a_synthetic_preview(self):
        import native_view
        state = {"revision": [1, 2], "components": [],
                 "display": {"phase": "dash", "reboot_revision": 1, "engine_simulation": "low-oil-pressure",
                             "engine_alarm_message": '[ { "text":"Low Oil Pressure" } ]'}}
        with patch.object(native_view, "QTimer"):
            bridge = native_view.Bridge("http://127.0.0.1:8765")
        with patch.object(native_view.urllib.request, "urlopen",
                          return_value=io.BytesIO(json.dumps(state).encode())):
            bridge.poll()
        scene = json.loads(bridge.scene)
        self.assertTrue(scene["display"]["live_alarms"])
        self.assertEqual(scene["display"]["preview_alarm_message"], '[ { "text":"Low Oil Pressure" } ]')
        self.assertIn("ENGINE SIMULATION", scene["status"])
        self.assertNotIn("SYNTHETIC", scene["status"])


class ThreadedAndPanelTests(unittest.TestCase):
    def test_threaded_simulation_runs_and_stops_with_the_device(self):
        import time
        with tempfile.TemporaryDirectory() as directory:
            device = Device(PROFILE, directory)
            simulation = device.start_engine_sim("idle")
            deadline = time.monotonic() + 5
            while simulation.frames_sent < 50 and time.monotonic() < deadline:
                time.sleep(0.02)
            device.close()
            self.assertGreaterEqual(simulation.frames_sent, 50)
            self.assertFalse(simulation.running)
            self.assertIsNone(device.engine)

    def test_workbench_panel_is_off_by_default_and_requests_overrides(self):
        from PyQt5.QtWidgets import QApplication
        application = QApplication.instance() or QApplication([])
        from engine_panel import EnginePanel, WARNING
        panel = EnginePanel()
        self.assertIn("SIMULATION", WARNING)
        self.assertFalse(panel.start_button.isEnabled(), "off until a session runs")
        requests = []
        panel.request.connect(requests.append)
        panel.set_session(True)
        self.assertTrue(panel.start_button.isEnabled())
        with tempfile.TemporaryDirectory() as directory:
            clock = FakeClock()
            device = Device(PROFILE, directory, clock=clock)
            panel.preset.setCurrentText("low-oil-pressure")
            panel.start_button.click()
            requests.pop()(device)
            run(device.engine, clock, 1)
            panel.show_status(device.engine_status())
            self.assertIn("SIMULATION RUNNING", panel.status.text())
            self.assertEqual(panel.table.rowCount(), 23)
            row = panel.rows["OIL PRES"]
            row["slider"].setValue(0)
            row["hold"].setChecked(True)
            requests[-1](device)
            self.assertIn("OIL PRES", device.engine.overrides)
            panel.stop_button.click()
            requests[-1](device)
            self.assertIsNone(device.engine)
            device.close()
        application.processEvents()


class EngineCommandLineTests(unittest.TestCase):
    def test_unknown_scenario_is_refused_with_the_presets_listed(self):
        with self.assertRaises(ValueError) as caught:
            E.load_scenario("not-a-preset")
        self.assertIn("low-oil-pressure", str(caught.exception))


if __name__ == "__main__":
    unittest.main()
