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

        function createPopup(manifest) {
            var component = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/resources/qml_components_data/qml/user_components/HalAlarmPopup.qml");
            compare(component.status, Component.Ready, component.errorString());
            popup = component.createObject(testWindow, {
                manifestUrl: Qt.resolvedUrl("fixtures/" + manifest), halFontPath: ""
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
            var image = findChild(banner, "animatedImage");
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

        function test_nativeAlarmUpdateReloadsAppearanceWithoutReopening() {
            createPopup("alerts-valid.json");
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            var message = JSON.stringify([active("OIL PRESSURE")]);
            popup.reInitAlarmScreen(message);
            compare(findChild(popup, "alertBanner:OIL PRESSURE").x, 100);
            popup.manifestUrl = Qt.resolvedUrl("fixtures/alerts-gif-only.json");
            popup.reInitAlarmScreen(message);
            tryVerify(function() {
                var banner = findChild(popup, "alertBanner:OIL PRESSURE");
                return banner !== null && banner.mediaOnly;
            });
            compare(popup.activeAlarms.length, 1);
        }

        function test_repeatedNativeUpdatesKeepAnimationInstance() {
            createPopup("alerts-valid.json");
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            var message = JSON.stringify([active("OIL PRESSURE")]);
            popup.reInitAlarmScreen(message);
            var image = findChild(popup, "animatedImage");
            verify(image !== null);
            tryCompare(image, "status", Image.Ready);
            for (var index = 0; index < 5; index++) {
                popup.reInitAlarmScreen(message);
                popup.repaintAll();
                wait(40);
                compare(findChild(popup, "animatedImage"), image);
            }
            var frame = image.currentFrame;
            tryVerify(function() { return image.currentFrame !== frame; });
        }

        function test_nativePropertyRefreshReloadsAppearance() {
            createPopup("alerts-valid.json");
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            popup.manifestUrl = Qt.resolvedUrl("fixtures/alerts-gif-only.json");
            popup.setGaugeProperties({});
            tryVerify(function() { return popup.bannerConfig.length === 2 && popup.bannerConfig[0].gifOnly; });
            compare(popup.bannerConfig[0].gifOnly, true);
        }

        function test_otherAlarmChangesDoNotRestartExistingMedia() {
            createPopup("alerts-valid.json");
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE")]));
            var image = findChild(popup, "animatedImage");
            verify(image !== null);
            tryCompare(image, "status", Image.Ready);
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE"), active("OTHER")]));
            wait(40);
            compare(findChild(popup, "animatedImage"), image);
            popup.reInitAlarmScreen(JSON.stringify([active("OIL PRESSURE")]));
            wait(40);
            compare(findChild(popup, "animatedImage"), image);
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
            var image = findChild(banner, "animatedImage");
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
