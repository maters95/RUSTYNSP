import QtQuick 2.9
import QtTest 1.0

Item {
    id: testWindow
    width: 860
    height: 480
    TestCase {
        name: "AlertMedia"
        when: windowShown
        property var popup: null
        property url userImages: Qt.resolvedUrl(
            "../../../build-nsp-tests/splash-runtime/user_resources/images/")

        function createPopup(manifest) {
            var component = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/qml_components_data/qml/user_components/HalAlarmPopup.qml");
            compare(component.status, Component.Ready, component.errorString());
            popup = component.createObject(testWindow, {
                manifestUrl: Qt.resolvedUrl("fixtures/" + manifest), halFontPath: "",
                userImageBaseUrl: userImages
            });
            verify(popup !== null);
            return popup;
        }

        function cleanup() {
            if (popup) {
                popup.destroy();
                popup = null;
                wait(1);
            }
        }

        function active(text, height) {
            return {text: text, height: height || "60", bc: "#cc0000", fc: "#ffffff", img: ""};
        }

        function test_defaultStackAndClearing() {
            createPopup("disabled-splash.json");
            popup.reInitAlarmScreen(JSON.stringify([active("FIRST"), active("SECOND", "80")]));
            var first = findChild(popup, "alertBanner:FIRST");
            var second = findChild(popup, "alertBanner:SECOND");
            verify(first !== null && second !== null);
            compare(first.x, 0);
            compare(first.y, 340);
            compare(first.width, 860);
            compare(second.y, 400);
            compare(second.height, 80);
            compare(findChild(first, "alertMessage").text, "FIRST");
            verify(popup.z > 999);
            popup.reInitAlarmScreen("[]");
            wait(1);
            compare(findChild(popup, "alertBanner:FIRST"), null);
        }

        function test_stockAlarmIconUnchanged() {
            createPopup("disabled-splash.json");
            var alarm = active("ICON", "80");
            alarm.img = Qt.resolvedUrl("../../../build-nsp-tests/static.png");
            popup.reInitAlarmScreen(JSON.stringify([alarm]));
            var icon = findChild(findChild(popup, "alertBanner:ICON"), "alertIcon");
            verify(icon !== null);
            compare(icon.visible, true);
            compare(icon.fillMode, Image.PreserveAspectFit);
            compare(icon.x, 10);
            compare(icon.y, 10);
            compare(icon.width, 100);
            compare(icon.height, 60);
            tryCompare(icon, "status", Image.Ready);
            verify(icon.paintedWidth > 32);
        }

        function test_animatedBannerGeometryAndText() {
            createPopup("alerts-valid.json");
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE"), active("OTHER")]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            compare(banner.x, 100);
            compare(banner.y, 80);
            compare(banner.width, 300);
            compare(banner.height, 80);
            var image = findChild(banner, "alertBannerMedia");
            verify(image !== null);
            tryCompare(image, "status", Image.Ready);
            var frame = image.currentFrame;
            tryVerify(function() { return image.currentFrame !== frame; });
            var message = findChild(banner, "alertMessage");
            compare(message.text, "OIL PRESSURE");
            compare(message.visible, true);
            verify(message.z > findChild(banner, "alertBannerMedia").z);
            compare(findChild(popup, "alertBanner:OTHER").y, 420);
            popup.reInitAlarmScreen("[]");
            wait(1);
            compare(findChild(popup, "alertBanner:OIL PRESSURE"), null);
        }

        function test_exactMatchingAndVariantGate() {
            createPopup("alerts-valid.json");
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            popup.reInitAlarmScreen(JSON.stringify([active("oil pressure"), active("TEMP")]));
            compare(findChild(popup, "alertBanner:oil pressure").x, 0);
            compare(findChild(popup, "alertBanner:TEMP").x, 30);
            popup.setDashVariant(12);
            compare(findChild(popup, "alertBanner:TEMP").x, 0);
            compare(findChild(popup, "alertBanner:TEMP").width, 1280);
        }

        function test_invalidConfigurationKeepsWarnings() {
            createPopup("alerts-invalid.json");
            tryVerify(function() { return popup.configurationError !== ""; });
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE")]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            compare(banner.x, 0);
            compare(banner.y, 420);
            compare(findChild(banner, "alertMessage").text, "OIL PRESSURE");
            popup.reInitAlarmScreen("{invalid");
            verify(findChild(popup, "alertBanner:OIL PRESSURE") !== null);
        }

        function test_gifOnlyHidesStockBannerAndText() {
            createPopup("alerts-gif-only.json");
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE"), active("TEMP")]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            compare(banner.x, 100);
            compare(banner.y, 80);
            compare(banner.color.a, 0);
            compare(findChild(banner, "alertMessage").visible, false);
            var image = findChild(banner, "alertBannerMedia");
            tryCompare(image, "status", Image.Ready);
            compare(findChild(banner, "alertBannerMedia").visible, true);
            var stock = findChild(popup, "alertBanner:TEMP");
            compare(findChild(stock, "alertMessage").visible, true);
            compare(stock.color, Qt.rgba(0.8, 0, 0, 1));
            popup.reInitAlarmScreen("[]");
            wait(1);
            compare(findChild(popup, "alertBanner:OIL PRESSURE"), null);
        }

        function test_gifOnlyRestoresWarningWhenMediaFails() {
            createPopup("alerts-gif-only-missing.json");
            tryVerify(function() { return popup.bannerConfig.length === 1; });
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE")]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            var media = findChild(banner, "alertBannerMedia");
            tryVerify(function() { return media.mediaError !== ""; });
            compare(findChild(banner, "alertMessage").visible, true);
            compare(banner.color, Qt.rgba(0.8, 0, 0, 1));
        }

        function test_gifOnlyWithoutMediaIsRejected() {
            createPopup("alerts-gif-only-no-media.json");
            tryVerify(function() { return popup.configurationError !== ""; });
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE")]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            compare(banner.y, 420);
            compare(findChild(banner, "alertMessage").visible, true);
        }

        // Mirrors UIMain: five unnamed UIScreen containers, then the popup is
        // created unparented and setParentItem'd to the same root.
        function createNativeRoot(manifest, visibleScreen) {
            var root = Qt.createQmlObject("import QtQuick 2.9; Item { width: 860; height: 480 }",
                testWindow);
            var screens = [];
            for (var i = 0; i < 5; i++) {
                screens.push(Qt.createQmlObject("import QtQuick 2.9; Item { width: 860; height: 480 }", root));
                screens[i].visible = i === visibleScreen;
            }
            var component = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/qml_components_data/qml/user_components/HalAlarmPopup.qml");
            compare(component.status, Component.Ready, component.errorString());
            popup = component.createObject(null, {
                manifestUrl: Qt.resolvedUrl("fixtures/" + manifest), halFontPath: "",
                userImageBaseUrl: userImages
            });
            popup.parent = root;
            return {root: root, screens: screens};
        }

        function showScreen(screens, index) {
            for (var i = 0; i < screens.length; i++)
                screens[i].visible = i === index;
        }

        function test_screenSpecificBannersFollowNativeScreenChanges() {
            var dash = createNativeRoot("alerts-screens.json", 0);
            tryVerify(function() { return popup.bannerConfig.length === 3; });
            compare(popup.screenItems.length, 5);
            compare(popup.currentScreen, 0);
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE"), active("FUEL")]));
            var oil = findChild(popup, "alertBanner:OIL PRESSURE");
            compare([oil.x, oil.y, oil.width, oil.height], [100, 80, 300, 80]);
            compare(findChild(oil, "alertMessage").visible, true);
            compare(findChild(popup, "alertBanner:FUEL").y, 420);

            showScreen(dash.screens, 2);
            compare(popup.currentScreen, 2);
            oil = findChild(popup, "alertBanner:OIL PRESSURE");
            compare([oil.x, oil.y, oil.width, oil.height], [0, 0, 860, 200]);
            tryCompare(findChild(oil, "alertBannerMedia"), "status", Image.Ready);
            tryCompare(findChild(oil, "alertMessage"), "visible", false);
            compare(findChild(popup, "alertBanner:FUEL").y, 420);

            showScreen(dash.screens, 1);
            oil = findChild(popup, "alertBanner:OIL PRESSURE");
            compare([oil.x, oil.y], [100, 80]);
            var fuel = findChild(popup, "alertBanner:FUEL");
            compare([fuel.x, fuel.y, fuel.width], [500, 10, 300]);
            compare(findChild(fuel, "alertMessage").text, "FUEL");

            showScreen(dash.screens, 4);
            compare(findChild(popup, "alertBanner:OIL PRESSURE").height, 200);

            // An error/suspended UI hides every screen: only all-screens rules apply.
            showScreen(dash.screens, -1);
            compare(popup.currentScreen, -1);
            compare(findChild(popup, "alertBanner:OIL PRESSURE").y, 80);
            compare(findChild(popup, "alertBanner:FUEL").y, 420);
            popup.reInitAlarmScreen("[]");
            wait(1);
            compare(findChild(popup, "alertBanner:OIL PRESSURE"), null);
            popup.destroy();
            popup = null;
            dash.root.destroy();
        }

        function test_namedRootItemsAreNotScreens() {
            var root = Qt.createQmlObject("import QtQuick 2.9; Item {}", testWindow);
            for (var i = 0; i < 5; i++)
                Qt.createQmlObject("import QtQuick 2.9; Item { objectName: 'declared" + i + "' }", root);
            var component = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/qml_components_data/qml/user_components/HalAlarmPopup.qml");
            popup = component.createObject(null, {
                manifestUrl: Qt.resolvedUrl("fixtures/alerts-screens.json"), halFontPath: "",
                userImageBaseUrl: userImages
            });
            popup.parent = root;
            compare(popup.screenItems.length, 0);
            compare(popup.currentScreen, -1);
            tryVerify(function() { return popup.bannerConfig.length === 3; });
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE"), active("FUEL")]));
            compare(findChild(popup, "alertBanner:OIL PRESSURE").y, 80);
            compare(findChild(popup, "alertBanner:FUEL").y, 420);
            popup.destroy();
            popup = null;
            root.destroy();
        }

        function test_invalidScreenRulesKeepStockWarnings_data() {
            return [
                {tag: "overlapping screens", manifest: "alerts-screens-overlap.json"},
                {tag: "two all-screens rules", manifest: "alerts-screens-duplicate.json"},
                {tag: "screen out of range", manifest: "alerts-screens-range.json"},
                {tag: "screens in version 1", manifest: "alerts-screens-v1.json"}
            ];
        }

        function test_invalidScreenRulesKeepStockWarnings(data) {
            createPopup(data.manifest);
            tryVerify(function() { return popup.configurationError !== ""; });
            compare(popup.bannerConfig.length, 0);
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE")]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            compare([banner.x, banner.y], [0, 420]);
            compare(findChild(banner, "alertMessage").visible, true);
        }

        function test_staticImageBanner() {
            createPopup("alerts-static.json");
            tryVerify(function() { return popup.bannerConfig.length === 1; });
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE")]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            var media = findChild(banner, "alertBannerMedia");
            tryCompare(media, "status", Image.Ready);
            verify(media.paintedWidth > 0);
            compare(findChild(banner, "alertMessage").visible, false);
        }

        function test_missingMediaKeepsWarningTextAndClearsNormally() {
            createPopup("alerts-missing-media.json");
            tryVerify(function() { return popup.bannerConfig.length === 1; });
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE")]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            var media = findChild(banner, "alertBannerMedia");
            tryVerify(function() { return media.mediaError !== ""; });
            compare(findChild(banner, "alertMessage").text, "OIL PRESSURE");
            compare(findChild(banner, "alertMessage").visible, true);
            popup.reInitAlarmScreen("[]");
            wait(1);
            compare(findChild(popup, "alertBanner:OIL PRESSURE"), null);
        }
    }
}
