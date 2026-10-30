import QtQuick 2.9
import QtTest 1.0

// The v2.36 application loads main.qml with QQuickView::setSource and the popup with
// QQmlComponent(engine, QUrl(path)) from scheme-less absolute paths such as
// "/opt/applications/dtn/resources/qml_components_data/qml/user_components/HalAlarmPopup.qml".
// Those resolve against a file: base, so relative lookups and manifest reads are local files.
Item {
    id: testWindow
    width: 860
    height: 480

    TestCase {
        name: "DeviceUrls"
        when: windowShown

        function devicePath(relative) {
            var url = Qt.resolvedUrl(
                "../../../build-nsp-tests/splash-runtime/resources/qml_components_data/qml/" + relative).toString();
            verify(url.indexOf("file:///") === 0, url);
            return url.substring("file://".length);
        }

        function test_schemeLessPopupReadsDeviceManifest() {
            var component = Qt.createComponent(devicePath("user_components/HalAlarmPopup.qml"));
            compare(component.status, Component.Ready, component.errorString());
            var popup = component.createObject(null, {halFontPath: ""});
            popup.parent = testWindow;
            verify(popup.userImageBaseUrl.toString().indexOf("file:///") === 0);
            verify(/\/splash-runtime\/user_resources\/images\/$/.test(popup.userImageBaseUrl.toString()),
                   popup.userImageBaseUrl.toString());
            tryVerify(function() { return popup.bannerConfig.length === 2; });
            popup.reInitAlarmScreen(JSON.stringify([{text: "KFC LIMITER", height: "60", bc: "red", fc: "white"}]));
            popup.z = 99;
            var banner = findChild(popup, "alertBanner:KFC LIMITER");
            verify(banner !== null);
            tryCompare(findChild(banner, "animatedImage"), "status", Image.Ready);
            popup.destroy();
            wait(1);
        }

        function test_schemeLessRootLoadsSplash() {
            var component = Qt.createComponent(devicePath("factory_screens/main.qml"));
            compare(component.status, Component.Ready, component.errorString());
            var root = component.createObject(testWindow);
            var startup = findChild(root, "startupSplashLoader");
            tryVerify(function() { return startup.item !== null && startup.item.visible; });
            verify(/\/splash-runtime\/user_resources\/images\/animated\.gif$/.test(startup.item.mediaPath),
                   startup.item.mediaPath);
            tryCompare(findChild(root, "animatedImage"), "status", Image.Ready);
            root.destroy();
            wait(1);
        }
    }
}
