import contextlib
import io
from pathlib import Path
import sys
import tempfile
import unittest
from unittest.mock import Mock, patch

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
import virtual_pair
from virtual_pair import (Inventory, Refusal, check_manual_port, driver_image_path, effective_name, hhd_pair_candidate,
                          hhd_ports, hhd_services, load_pair_config, parse_comdb, parse_pnputil_drivers, parse_setupc_list,
                          plan_pair, save_pair_config)


# Fixture shaped like com0com `setupc list` output; no driver is required.
SETUPC_LIST = """
       CNCA0 PortName=COM#,RealPortName=COM10,EmuBR=yes
       CNCB0 PortName=COM#,RealPortName=COM11
       CNCA1 PortName=-
       CNCB1 PortName=COM20
"""

PNPUTIL = """Microsoft PnP Utility

Published Name:     oem12.inf
Original Name:      com0com.inf
Provider Name:      Vyacheslav Frolov
Class Name:         Ports
Driver Version:     01/01/2021 3.0.0.0
Signer Name:        Microsoft Windows Hardware Compatibility Publisher

Published Name:     oem3.inf
Original Name:      usbser.inf
Provider Name:      Microsoft
"""

DASH = {"Name": "Haltech iC-7 (COM3)", "PNPDeviceID": "USB\\VID_16D0&PID_0F2B\\1"}
COM0COM_A = {"Name": "com0com - serial port emulator CNCA0 (COM10)", "PNPDeviceID": "COM0COM\\PORT\\CNCA0"}
HHD = {"Name": "HHD Virtual Serial Port (COM12)", "PNPDeviceID": "ROOT\\PORTS\\0001"}


class SetupcParsingTests(unittest.TestCase):
    def test_list_output_maps_pairs_and_visible_names(self):
        pairs = parse_setupc_list(SETUPC_LIST)
        self.assertEqual(sorted(pairs), [0, 1])
        self.assertEqual(pairs[0]["A"]["EmuBR"], "yes")
        self.assertEqual([effective_name(pairs[0][side]) for side in "AB"], ["COM10", "COM11"])
        self.assertEqual([effective_name(pairs[1][side]) for side in "AB"], [None, "COM20"])

    def test_unrelated_lines_are_ignored(self):
        self.assertEqual(parse_setupc_list("Usage: setupc ...\n\nnothing here"), {})

    def test_comdb_bitmap_decodes_reserved_numbers(self):
        self.assertEqual(parse_comdb(bytes([0b00000101, 0, 0b00000010])), {1, 3, 18})
        self.assertEqual(parse_comdb(None), set())

    def test_pnputil_reports_only_com0com_packages(self):
        packages = parse_pnputil_drivers(PNPUTIL)
        self.assertEqual(len(packages), 1)
        self.assertEqual(packages[0]["Published Name"], "oem12.inf")
        self.assertIn("Microsoft", packages[0]["Signer Name"])


class HhdDetectionTests(unittest.TestCase):
    def test_hhd_ports_exclude_com0com_and_physical_devices(self):
        pnp = [HHD, DASH, COM0COM_A,
               {"Name": "Serial Port (COM13)", "PNPDeviceID": "ROOT\\HHDVSP\\0000", "Manufacturer": "HHD Software",
                "Service": "hhdvsp"},
               {"Name": "Communications Port (COM1)", "PNPDeviceID": "ACPI\\PNP0501\\1"}]
        ports = hhd_ports(pnp)
        self.assertEqual([port[0] for port in ports], ["COM12", "COM13"])
        self.assertEqual(ports[1][2], "hhdvsp")
        self.assertEqual(hhd_pair_candidate(ports), ("COM12", "COM13"))
        self.assertIsNone(hhd_pair_candidate(ports[:1]))

    def test_serialcomm_device_name_identifies_hhd_port(self):
        pnp = [{"Name": "Port (COM20)", "PNPDeviceID": "ROOT\\PORTS\\0003"},
               {"Name": "Port (COM21)", "PNPDeviceID": "ROOT\\PORTS\\0004"}]
        ports = hhd_ports(pnp, [("\\Device\\hhdvsp21", "COM21"), ("\\Device\\Serial0", "COM20")])
        self.assertEqual([port[0] for port in ports], ["COM21"])

    def test_hhd_services_are_selected_by_name_image_or_port_service(self):
        services = {"hhdpssrv": "C:\\Program Files\\HHD Software\\Virtual Serial Port Tools\\ps_server.exe",
                    "vspdriver": "\\SystemRoot\\System32\\drivers\\vsp.sys",
                    "Serial": "\\SystemRoot\\System32\\drivers\\serial.sys"}
        self.assertEqual(hhd_services(services), ["hhdpssrv"])
        self.assertEqual(hhd_services(services, ["VSPDRIVER", None]), ["hhdpssrv", "vspdriver"])

    def test_driver_image_paths_are_normalized(self):
        with patch.dict(virtual_pair.os.environ, {"SystemRoot": "C:\\Windows"}):
            self.assertEqual(driver_image_path("\\SystemRoot\\System32\\drivers\\x.sys"),
                             Path("C:\\Windows\\System32\\drivers\\x.sys"))
            self.assertEqual(driver_image_path("System32\\drivers\\x.sys"), Path("C:\\Windows\\System32\\drivers\\x.sys"))
            self.assertEqual(driver_image_path("\\??\\C:\\drivers\\x.sys"), Path("C:\\drivers\\x.sys"))
            self.assertIsNone(driver_image_path(None))


class PairPlanTests(unittest.TestCase):
    def test_fresh_pair_is_one_ports_class_install(self):
        plan = plan_pair("COM10", "COM11", Inventory(pnp=[DASH]))
        self.assertEqual(plan.commands, [["install", "PortName=COM#,RealPortName=COM10",
                                          "PortName=COM#,RealPortName=COM11"]])
        self.assertFalse(plan.configured)

    def test_existing_pair_needs_no_commands(self):
        inventory = Inventory(pairs=parse_setupc_list(SETUPC_LIST), pnp=[COM0COM_A, DASH],
                              serialcomm=[("\\Device\\com0com10", "COM10")])
        plan = plan_pair("com11", "COM10", inventory)
        self.assertTrue(plan.configured)
        self.assertEqual(plan.pair, 0)

    def test_pair_holding_one_name_renames_only_its_other_end(self):
        inventory = Inventory(pairs=parse_setupc_list(SETUPC_LIST))
        plan = plan_pair("COM15", "COM20", inventory)
        self.assertEqual(plan.commands, [["change", "CNCA1", "PortName=COM#,RealPortName=COM15"]])

    def test_explicit_rename_of_existing_pair(self):
        inventory = Inventory(pairs=parse_setupc_list(SETUPC_LIST))
        plan = plan_pair("COM30", "COM31", inventory, rename_pair=1)
        self.assertEqual(plan.commands, [["change", "CNCA1", "PortName=COM#,RealPortName=COM30"],
                                         ["change", "CNCB1", "PortName=COM#,RealPortName=COM31"]])
        with self.assertRaisesRegex(Refusal, "does not exist"):
            plan_pair("COM30", "COM31", inventory, rename_pair=7)
        with self.assertRaisesRegex(Refusal, "belongs to com0com pair 0"):
            plan_pair("COM10", "COM31", inventory, rename_pair=1)

    def test_physical_dash_port_is_refused(self):
        with self.assertRaisesRegex(Refusal, "physical device Haltech"):
            plan_pair("COM3", "COM11", Inventory(pnp=[DASH]))

    def test_other_virtual_driver_port_is_refused(self):
        with self.assertRaisesRegex(Refusal, "non-com0com device HHD"):
            plan_pair("COM10", "COM12", Inventory(pnp=[HHD]))

    def test_serialcomm_entry_without_pnp_is_refused(self):
        with self.assertRaisesRegex(Refusal, "USBSER000"):
            plan_pair("COM10", "COM4", Inventory(serialcomm=[("\\Device\\USBSER000", "COM4")]))

    def test_names_in_different_pairs_are_refused(self):
        with self.assertRaisesRegex(Refusal, "different com0com pairs"):
            plan_pair("COM10", "COM20", Inventory(pairs=parse_setupc_list(SETUPC_LIST)))

    def test_name_reserved_by_absent_device_needs_explicit_override(self):
        inventory = Inventory(reserved={10})
        with self.assertRaisesRegex(Refusal, "reserved"):
            plan_pair("COM10", "COM11", inventory)
        self.assertEqual(plan_pair("COM10", "COM11", inventory, allow_reserved=True).commands[0][0], "install")

    def test_invalid_or_identical_names_are_refused(self):
        for nsp, emulator in (("COM10", "COM10"), ("LPT1", "COM11"), ("COM0", "COM11"), ("COM999", "COM11")):
            with self.subTest(nsp=nsp, emulator=emulator), self.assertRaises(Refusal):
                plan_pair(nsp, emulator, Inventory())


class PairConfigTests(unittest.TestCase):
    def test_config_round_trip_and_rejects_invalid_files(self):
        with tempfile.TemporaryDirectory() as temporary:
            path = Path(temporary) / "port-pair.json"
            self.assertIsNone(load_pair_config(path))
            save_pair_config("com10", "COM11", "com0com", 0, path)
            self.assertEqual(load_pair_config(path),
                             {"driver": "com0com", "nsp_port": "COM10", "emulator_port": "COM11", "pair": 0})
            for text in ("not json", '{"nsp_port": "COM10"}', '{"nsp_port": "COM1", "emulator_port": "COM1"}'):
                path.write_text(text)
                self.assertIsNone(load_pair_config(path))

    def test_manual_fallback_accepts_only_identified_virtual_ports(self):
        ports = [Mock(device="COM10", description="HHD Virtual Serial Port", manufacturer="HHD", hwid="ROOT\\PORTS\\0000"),
                 Mock(device="COM3", description="USB Serial Device", manufacturer="Microsoft",
                      hwid="USB VID:PID=16D0:0F2B"),
                 Mock(device="COM5", description="Communications Port", manufacturer="(Standard port types)",
                      hwid="ACPI\\PNP0501\\1")]
        self.assertIn("HHD", check_manual_port("COM10", ports))
        for name in ("COM3", "COM5", "COM7"):
            with self.subTest(name=name), self.assertRaises(Refusal):
                check_manual_port(name, ports)


class CommandLineTests(unittest.TestCase):
    def run_main(self, argv, **patches):
        output, errors = io.StringIO(), io.StringIO()
        defaults = {"installed_programs": Mock(return_value=[]), "elevated_setupc": Mock(return_value=0),
                    "detect_hhd": Mock(return_value={"software": [], "ports": [], "drivers": [], "pair": None})}
        defaults.update(patches)
        with contextlib.ExitStack() as stack:
            stack.enter_context(patch.object(virtual_pair.sys, "platform", "win32"))
            mocks = {name: stack.enter_context(patch.object(virtual_pair, name, value))
                     for name, value in defaults.items()}
            stack.enter_context(contextlib.redirect_stdout(output))
            stack.enter_context(contextlib.redirect_stderr(errors))
            code = virtual_pair.main(argv)
        return code, output.getvalue(), errors.getvalue(), mocks

    def signed_driver(self):
        return Mock(return_value={"sys": "com0com.sys", "present": True, "service": True, "signature": "Valid",
                                  "signer": "CN=Microsoft Windows Hardware Compatibility Publisher",
                                  "signature_type": "Catalog", "pnputil": []})

    def test_missing_driver_fails_with_options_and_changes_nothing(self):
        with tempfile.TemporaryDirectory() as temporary:
            config = Path(temporary) / "port-pair.json"
            code, _, errors, mocks = self.run_main(["--apply", "--yes", "--config", str(config)],
                                                   find_setupc=Mock(return_value=None))
            self.assertEqual(code, virtual_pair.EXIT_NO_DRIVER)
            self.assertIn("signed com0com", errors)
            self.assertIn("HHD", errors)
            mocks["elevated_setupc"].assert_not_called()
            self.assertFalse(config.exists())

    def test_unsigned_driver_is_not_used(self):
        driver = self.signed_driver()
        driver.return_value["signature"] = "NotSigned"
        code, _, errors, mocks = self.run_main(["--apply", "--yes"], find_setupc=Mock(return_value=Path("setupc.exe")),
                                               driver_status=driver)
        self.assertEqual(code, virtual_pair.EXIT_NO_DRIVER)
        self.assertIn("test signing", errors)
        mocks["elevated_setupc"].assert_not_called()

    def test_dry_run_prints_commands_without_running_them(self):
        with tempfile.TemporaryDirectory() as temporary:
            config = Path(temporary) / "port-pair.json"
            code, output, _, mocks = self.run_main(
                ["--config", str(config)], find_setupc=Mock(return_value=Path(temporary) / "setupc.exe"),
                driver_status=self.signed_driver(), inventory=Mock(return_value=(Inventory(), [])))
            self.assertEqual(code, 0)
            self.assertIn("DRY RUN", output)
            self.assertIn("setupc.exe install PortName=COM#,RealPortName=COM10 PortName=COM#,RealPortName=COM11", output)
            mocks["elevated_setupc"].assert_not_called()
            self.assertFalse(config.exists())

    def test_apply_requires_typed_confirmation(self):
        with tempfile.TemporaryDirectory() as temporary:
            config = Path(temporary) / "port-pair.json"
            code, output, _, mocks = self.run_main(
                ["--apply", "--config", str(config)], find_setupc=Mock(return_value=Path(temporary) / "setupc.exe"),
                driver_status=self.signed_driver(), inventory=Mock(return_value=(Inventory(), [])),
                confirm=Mock(return_value=False))
            self.assertEqual(code, 1)
            self.assertIn("nothing was changed", output)
            mocks["elevated_setupc"].assert_not_called()
            self.assertFalse(config.exists())

    def test_confirmed_apply_runs_setupc_then_verifies_and_saves(self):
        configured = Inventory(pairs=parse_setupc_list(SETUPC_LIST))
        with tempfile.TemporaryDirectory() as temporary:
            config = Path(temporary) / "port-pair.json"
            setupc = Path(temporary) / "setupc.exe"
            code, _, _, mocks = self.run_main(
                ["--apply", "--yes", "--config", str(config)], find_setupc=Mock(return_value=setupc),
                driver_status=self.signed_driver(),
                inventory=Mock(side_effect=[(Inventory(), []), (configured, [])]))
            self.assertEqual(code, 0)
            mocks["elevated_setupc"].assert_called_once_with(
                setupc, ["install", "PortName=COM#,RealPortName=COM10", "PortName=COM#,RealPortName=COM11"])
            self.assertEqual(load_pair_config(config)["pair"], 0)

    def test_conflict_exits_refused(self):
        code, _, errors, mocks = self.run_main(
            ["--nsp-port", "COM3", "--apply", "--yes"], find_setupc=Mock(return_value=Path("setupc.exe")),
            driver_status=self.signed_driver(), inventory=Mock(return_value=(Inventory(pnp=[DASH]), [])))
        self.assertEqual(code, virtual_pair.EXIT_REFUSED)
        self.assertIn("physical device", errors)
        mocks["elevated_setupc"].assert_not_called()


if __name__ == "__main__":
    unittest.main()
