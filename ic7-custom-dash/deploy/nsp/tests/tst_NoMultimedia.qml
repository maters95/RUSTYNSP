import QtQuick 2.9
import QtTest 1.0

// The owner's emulator log showed "Type HalImage unavailable" taking down the
// whole alarm popup when QtMultimedia could not load. This runtime's HalImage
// imports a module that does not exist to reproduce that failure.
Item {
    id: testWindow
    width: 860
    height: 480

    TestCase {
        name: "WithoutMultimedia"
        when: windowShown
        property string components: "../../../build-nsp-tests/no-multimedia-runtime/qml_components_data/qml/user_components/"

        function test_alarmPopupStillShowsGifBanners() {
            var component = Qt.createComponent(components + "HalAlarmPopup.qml");
            compare(component.status, Component.Ready, component.errorString());
            var popup = component.createObject(testWindow, {
                manifestUrl: Qt.resolvedUrl("fixtures/alerts-gif-only.json"), halFontPath: "",
                userImageBaseUrl: Qt.resolvedUrl("../../../build-nsp-tests/no-multimedia-runtime/user_resources/images/")
            });
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            popup.reInitAlarmScreen(JSON.stringify([
                {text: "OIL PRESSURE", height: "60", bc: "#cc0000", fc: "#ffffff", img: ""},
                {text: "TEMP", height: "60", bc: "#cc0000", fc: "#ffffff", img: ""}
            ]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            tryCompare(findChild(banner, "alertBannerMedia"), "status", Image.Ready);
            compare(findChild(findChild(popup, "alertBanner:TEMP"), "alertMessage").visible, true);
            popup.destroy();
        }

        function test_gifSplashPlaysAndVideoSplashFailsOpen() {
            var component = Qt.createComponent(components + "HalSplash.qml");
            compare(component.status, Component.Ready, component.errorString());
            var base = Qt.resolvedUrl("../../../build-nsp-tests/");
            var splash = component.createObject(testWindow, {
                width: 860, height: 480, userImageBaseUrl: base, stockImageBaseUrl: base,
                manifestUrl: Qt.resolvedUrl("fixtures/gif-splash.json")
            });
            tryCompare(splash, "visible", true);
            tryCompare(findChild(splash, "animatedImage"), "status", Image.Ready);
            splash.finish();
            splash.manifestUrl = Qt.resolvedUrl("fixtures/video-splash.json");
            splash.start();
            tryCompare(splash, "completed", true, 2000);
            verify(splash.mediaError !== "");
            verify(!splash.visible);
            splash.destroy();
        }
    }
}
