from pathlib import Path
import sys
from types import SimpleNamespace
import unittest
from unittest.mock import MagicMock, patch

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))
import native_view


class NativeViewRuntimeTests(unittest.TestCase):
    def test_selected_preview_screen_is_published_for_alarm_scoping(self):
        state = {"revision": [1, 2], "components": [],
                 "display": {"phase": "dash", "reboot_revision": 1}}
        with patch.object(native_view, "QTimer"):
            bridge = native_view.Bridge("http://127.0.0.1:8765")
        bridge.setScreen(4)
        with patch.object(native_view.urllib.request, "urlopen",
                          return_value=io.BytesIO(json.dumps(state).encode())):
            bridge.poll()
        self.assertEqual(json.loads(bridge.scene)["screen"], 4)

    def test_alarm_message_is_built_like_the_dash_unescaped_and_cut_to_20(self):
        alarm = {"height": "60", "bc": "#a00000", "fc": "#ffffff", "img": ""}
        message = native_view.native_alarm_message([{**alarm, "text": "OIL PRESSURE LOW WARNING"}])
        self.assertEqual(json.loads(message)[0]["text"], "OIL PRESSURE LOW WAR")
        self.assertEqual(list(json.loads(message)[0]), ["text", "bc", "height", "img", "fc"])
        with self.assertRaises(ValueError):
            json.loads(native_view.native_alarm_message([{**alarm, "text": 'SAY "HI"'}]))
        # The preview passes this string to the popup instead of re-encoding it.
        view = Path(__file__).resolve().parents[1] / "qml/NativeDash.qml"
        self.assertNotIn("JSON.stringify", view.read_text())

    def test_panel_view_squeezes_the_canvas_like_the_dash_panel(self):
        from PIL import Image
        from viewer import panel_view
        canvas = Image.new("RGBA", (860, 480), (0, 0, 0, 255))
        canvas.paste((255, 0, 0, 255), (800, 0, 860, 480))
        squeezed = panel_view(canvas)
        self.assertEqual(squeezed.size, (800, 480))
        self.assertEqual(squeezed.getpixel((790, 240))[:3], (255, 0, 0))
        self.assertEqual(squeezed.getpixel((700, 240))[:3], (0, 0, 0))

    def test_windows_uses_pyqt_runtime_for_both_dll_loaders(self):
        environment = {"PATH": "existing"}
        handle = MagicMock()
        windows = SimpleNamespace(name="nt", pathsep=";", environ=environment,
                                  add_dll_directory=MagicMock(return_value=handle))
        with patch.object(native_view, "os", windows), \
                patch.object(native_view.QLibraryInfo, "location", return_value="C:/PyQt5/Qt5/bin") as location, \
                patch.object(native_view.Path, "is_dir", return_value=True):
            self.assertIs(native_view.configure_qt_dll_search(), handle)
        location.assert_called_once_with(native_view.QLibraryInfo.BinariesPath)
        windows.add_dll_directory.assert_called_once_with("C:/PyQt5/Qt5/bin")
        self.assertEqual(environment["PATH"], "C:/PyQt5/Qt5/bin;existing")

    def test_missing_runtime_is_an_explicit_failure(self):
        with patch.object(native_view, "os", SimpleNamespace(name="nt")), \
                patch.object(native_view.QLibraryInfo, "location", return_value="missing"), \
                patch.object(native_view.Path, "is_dir", return_value=False):
            with self.assertRaisesRegex(FileNotFoundError, "runtime DLL directory"):
                native_view.configure_qt_dll_search()

    def test_non_windows_does_not_change_dll_search(self):
        with patch.object(native_view, "os", SimpleNamespace(name="posix")):
            self.assertIsNone(native_view.configure_qt_dll_search())

    def test_qml_dependency_failure_is_not_a_blank_success(self):
        component = MagicMock()
        component.status.return_value = native_view.QQmlComponent.Error
        component.errors.return_value = [SimpleNamespace(toString=lambda: "Missing multimedia DLL")]
        with patch.object(native_view, "QQmlComponent", return_value=component) as factory:
            factory.Ready = 1
            with self.assertRaisesRegex(RuntimeError, "Missing multimedia DLL"):
                native_view.validate_media_qml(MagicMock())


if __name__ == "__main__":
    unittest.main()
import io
import json
