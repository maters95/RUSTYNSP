import QtQuick 2.9
import QtTest 1.0

// The physical dash keeps QML under /opt/applications/dtn/resources and user images
// under /opt/applications/dtn/user_resources, four levels above user_components.
// The 2026-10-29 flash showed GIF/MP4 splash and alert GIFs missing on the dash
// because the components only looked three levels up (NSP's Windows layout).
// These tests run the shipped components in both layouts with no URL overrides.
Item {
    id: testWindow
    width: 860
    height: 480

    TestCase {
        name: "DeviceLayout"
        when: windowShown
        property string device: "../../../build-nsp-tests/device-runtime/opt/applications/dtn/"
        property string windows: "../../../build-nsp-tests/splash-runtime/"

        function alarm(text) {
            return {text: text, height: "60", bc: "#cc0000", fc: "#ffffff", img: ""};
        }

        function test_splashFindsDashUserResources() {
            var component = Qt.createComponent(device + "resources/qml_components_data/qml/factory_screens/main.qml");
            compare(component.status, Component.Ready, component.errorString());
            var root = component.createObject(testWindow);
            var startup = findChild(root, "startupSplashLoader");
            tryVerify(function() { return startup.item !== null && startup.item.visible; });
            verify(String(startup.item.resolvedUserImageBaseUrl).indexOf(
                "/device-runtime/opt/applications/dtn/user_resources/images/") >= 0,
                String(startup.item.resolvedUserImageBaseUrl));
            var animation = findChild(root, "animatedImage");
            tryCompare(animation, "status", Image.Ready);
            var frame = animation.currentFrame;
            tryVerify(function() { return animation.currentFrame !== frame; });
            tryCompare(startup, "active", false, 4000);
            root.destroy();
        }

        function test_alertPopupFindsDashUserResources() {
            var component = Qt.createComponent(device + "resources/qml_components_data/qml/user_components/HalAlarmPopup.qml");
            compare(component.status, Component.Ready, component.errorString());
            var popup = component.createObject(testWindow, {halFontPath: ""});
            tryVerify(function() { return popup.bannerConfig.length === 1; });
            verify(String(popup.resolvedUserImageBaseUrl).indexOf(
                "/device-runtime/opt/applications/dtn/user_resources/images/") >= 0);
            popup.reInitAlarmScreen(JSON.stringify([alarm("OIL PRESSURE")]));
            var banner = findChild(popup, "alertBanner:OIL PRESSURE");
            compare([banner.x, banner.y, banner.width, banner.height], [100, 80, 300, 80]);
            tryCompare(findChild(banner, "alertBannerMedia"), "status", Image.Ready);
            popup.destroy();
        }

        function test_windowsRendererLayoutStillWorks() {
            var component = Qt.createComponent(windows + "qml_components_data/qml/user_components/HalAlarmPopup.qml");
            compare(component.status, Component.Ready, component.errorString());
            var popup = component.createObject(testWindow, {halFontPath: ""});
            tryVerify(function() { return popup.bannerConfig.length === 1; });
            verify(String(popup.resolvedUserImageBaseUrl).indexOf(
                "/splash-runtime/user_resources/images/") >= 0);
            popup.reInitAlarmScreen(JSON.stringify([alarm("OIL PRESSURE")]));
            tryCompare(findChild(findChild(popup, "alertBanner:OIL PRESSURE"), "alertBannerMedia"),
                "status", Image.Ready);
            popup.destroy();
        }
    }
}
