import QtQuick 2.9
import QtTest 1.0

Item {
    id: testWindow
    width: 860
    height: 480
    TestCase {
        name: "AlarmScreens"
        when: windowShown
        property var root: null
        property var popup: null
        property var screens: []
        property var markers: []

        function create(componentName, parent, props) {
            var folder = componentName === "main.qml" ? "factory_screens/" : "user_components/";
            var component = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/resources/qml_components_data/qml/" + folder + componentName);
            compare(component.status, Component.Ready, component.errorString());
            var item = component.createObject(parent, props);
            verify(item !== null);
            return item;
        }

        function init() {
            root = create("main.qml", testWindow, {dashVariantId: 12});
            popup = create("HalAlarmPopup.qml", root, {
                halFontPath: ""
            });
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            screens = [];
            markers = [];
            for (var index = 1; index <= 5; index++) {
                var screen = Qt.createQmlObject("import QtQuick 2.9; Item { visible: false }", root);
                screens.push(screen);
                markers.push(create("HalImage.qml", screen, {
                    width: 1, height: 1, halImageOpacity: 0,
                    halImagePath: Qt.resolvedUrl("../../../build-nsp-tests/ic7_screen_" + index + ".png")
                }));
            }
        }

        function cleanup() {
            root.destroy();
            root = null;
            popup = null;
            screens = [];
            markers = [];
            wait(1);
        }

        function select(index) {
            for (var i = 0; i < screens.length; i++)
                screens[i].visible = false;
            screens[index - 1].visible = true;
            compare(root.activeScreenNumber, index);
            compare(popup.activeScreenNumber, index);
        }

        function alarms() {
            popup.reInitAlarmScreen(JSON.stringify([
                {text: "OIL PRESSURE", height: "60", bc: "red", fc: "white"},
                {text: "KFC LIMITER", height: "60", bc: "red", fc: "white"}
            ]));
        }

        function test_nativeVisibilitySwitchesWithoutAlarmRefresh() {
            select(1);
            alarms();
            var oil = findChild(popup, "alertBanner:OIL PRESSURE");
            verify(oil !== null);
            for (var screen = 1; screen <= 4; screen++) {
                select(screen);
                compare(findChild(popup, "alertBanner:KFC LIMITER"), null);
                compare(findChild(popup, "alertBanner:OIL PRESSURE"), oil);
            }
            select(5);
            var kfc = findChild(popup, "alertBanner:KFC LIMITER");
            verify(kfc !== null);
            compare(kfc.width, 860);
            compare(kfc.height, 480);
            tryCompare(findChild(kfc, "animatedImage"), "status", Image.Ready);
            verify(kfc.mediaOnly);
            var frame = findChild(kfc, "animatedImage").currentFrame;
            tryVerify(function() { return findChild(kfc, "animatedImage").currentFrame !== frame; });
            select(2);
            compare(findChild(popup, "alertBanner:KFC LIMITER"), null);
            compare(findChild(popup, "alertBanner:OIL PRESSURE"), oil);
            select(5);
            verify(findChild(popup, "alertBanner:KFC LIMITER") !== null);
            popup.reInitAlarmScreen("[]");
            select(1);
            select(5);
            compare(findChild(popup, "alertBanner:KFC LIMITER"), null);
        }

        function test_unknownScreenFailsVisibleAndMarkersAreTransparent() {
            alarms();
            verify(findChild(popup, "alertBanner:KFC LIMITER") !== null);
            compare(popup.activeScreenNumber, 0);
            verify(popup.screenWarningReported);
            select(1);
            compare(findChild(popup, "alertBanner:KFC LIMITER"), null);
            markers[0].repaintAll();
            compare(findChild(markers[0], "staticImage").opacity, 0);
            tryCompare(findChild(markers[0], "staticImage"), "status", Image.Ready);
            markers[0].destroy();
            tryCompare(root, "activeScreenNumber", 0);
            verify(findChild(popup, "alertBanner:KFC LIMITER") !== null);
        }

        function test_screenshotsDoNotSelectAnotherScreen() {
            select(1);
            alarms();
            markers[4].screenshotMode = true;
            screens[4].visible = true;
            compare(root.activeScreenNumber, 1);
            compare(findChild(popup, "alertBanner:KFC LIMITER"), null);
            screens[4].visible = false;
            markers[4].screenshotMode = false;
            compare(root.activeScreenNumber, 1);
        }

        function test_multipleScreensAndLegacyDefault() {
            select(1);
            popup.bannerConfig = [{text: "KFC LIMITER", source: "", x: 0, y: 0,
                width: 860, height: 60, screens: [1, 3, 5]}];
            alarms();
            for (var screen = 1; screen <= 5; screen++) {
                select(screen);
                compare(findChild(popup, "alertBanner:KFC LIMITER") !== null, screen % 2 === 1);
                verify(findChild(popup, "alertBanner:OIL PRESSURE") !== null);
            }
        }

        function test_validation() {
            verify(popup.validScreens(undefined));
            verify(popup.validScreens(null));
            verify(popup.validScreens([5]));
            verify(popup.validScreens([1, 3, 5]));
            var invalid = [[], [0], [6], [1, 1], ["5"], [true], [1.5], "5", {}];
            for (var i = 0; i < invalid.length; i++)
                verify(!popup.validScreens(invalid[i]), JSON.stringify(invalid[i]));
        }
    }
}
