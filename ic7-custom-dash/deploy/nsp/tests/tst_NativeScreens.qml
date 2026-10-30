import QtQuick 2.9
import QtTest 1.0

// Screen-restricted alarms without screen markers. The v2.36 UIMain creates five
// unnamed UIScreen containers under the QML root, then Alarm_Module creates the
// popup and parents it to the same root; screen changes toggle container visibility
// (analysis/screen-switching.s). The popup uses that when no marker reports.
Item {
    id: testWindow
    width: 860
    height: 480

    TestCase {
        name: "NativeScreens"
        when: windowShown
        property var root: null
        property var popup: null
        property var screens: []

        function component(path) {
            var made = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/resources/qml_components_data/qml/" + path);
            compare(made.status, Component.Ready, made.errorString());
            return made;
        }

        function build(popupFirst) {
            root = component("factory_screens/main.qml").createObject(testWindow, {dashVariantId: 12});
            var alarmComponent = component("user_components/HalAlarmPopup.qml");
            if (popupFirst)
                popup = alarmComponent.createObject(root, {halFontPath: ""});
            screens = [];
            for (var index = 0; index < 5; index++)
                screens.push(Qt.createQmlObject("import QtQuick 2.9; Item { visible: false }", root));
            if (!popupFirst) {
                // Created unparented, then setParentItem'd, as Alarm_Module does.
                popup = alarmComponent.createObject(null, {halFontPath: ""});
                popup.parent = root;
            }
            tryVerify(function() { return popup.bannerConfig.length === 2; });
        }

        function cleanup() {
            if (popup)
                popup.destroy();
            if (root)
                root.destroy();
            popup = null;
            root = null;
            screens = [];
            wait(1);
        }

        function show(number) {
            for (var i = 0; i < screens.length; i++)
                screens[i].visible = i === number - 1;
        }

        function alarms() {
            popup.reInitAlarmScreen(JSON.stringify([
                {text: "OIL PRESSURE", height: "60", bc: "red", fc: "white"},
                {text: "KFC LIMITER", height: "60", bc: "red", fc: "white"}
            ]));
            popup.z = 99;  // as Alarm_Module::draw_alarms does after every update
        }

        function test_restrictedAlarmFollowsNativeScreensWithoutMarkers() {
            build(false);
            compare(popup.nativeScreenItems.length, 5);
            show(1);
            alarms();
            compare(popup.activeScreenNumber, 0);
            for (var screen = 1; screen <= 4; screen++) {
                show(screen);
                compare(popup.nativeScreenNumber, screen);
                compare(findChild(popup, "alertBanner:KFC LIMITER"), null);
                verify(findChild(popup, "alertBanner:OIL PRESSURE") !== null);
            }
            show(5);
            var kfc = findChild(popup, "alertBanner:KFC LIMITER");
            verify(kfc !== null);
            tryCompare(findChild(kfc, "animatedImage"), "status", Image.Ready);
            show(2);
            compare(findChild(popup, "alertBanner:KFC LIMITER"), null);
        }

        function test_noVisibleScreenFailsVisible() {
            build(false);
            show(0);
            alarms();
            compare(popup.nativeScreenNumber, 0);
            verify(findChild(popup, "alertBanner:KFC LIMITER") !== null);
            verify(popup.screenWarningReported);
        }

        function test_declaredRootItemsAreNotScreens() {
            // Popup created before the screens: its preceding siblings are main.qml's own items.
            build(true);
            compare(popup.nativeScreenItems.length, 0);
            show(5);
            compare(popup.nativeScreenNumber, 0);
        }
    }
}
