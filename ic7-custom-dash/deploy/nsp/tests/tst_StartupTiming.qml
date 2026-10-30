import QtQuick 2.9
import QtTest 1.0

Item {
    id: testWindow
    width: 860
    height: 480

    TestCase {
        name: "StartupTiming"
        when: windowShown

        // The application builds its screens and alarm popup on the GUI thread
        // after QQuickView::setSource and before its event loop runs, so the
        // splash must survive a long block straight after main.qml is created.
        function test_splashSurvivesBlockedStartup() {
            var component = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/resources/qml_components_data/qml/factory_screens/main.qml");
            compare(component.status, Component.Ready, component.errorString());
            var root = component.createObject(testWindow);
            verify(root !== null);
            root.setScreenSize(860, 480);
            root.setDashVariant(11);
            var startup = findChild(root, "startupSplashLoader");
            verify(startup.item !== null);
            var blockedUntil = Date.now() + 4500;
            while (Date.now() < blockedUntil) {}
            var shownAt = 0;
            tryVerify(function() {
                if (startup.item !== null && startup.item.visible && shownAt === 0)
                    shownAt = Date.now();
                return shownAt !== 0;
            }, 3000, "Splash never became visible after a blocked start");
            tryCompare(startup, "active", false, 4000);
            // The fixture manifest asks for 1500 ms of playback.
            verify(Date.now() - shownAt >= 1200, "Splash shown for " + (Date.now() - shownAt) + " ms");
            root.destroy();
            wait(1);
        }
    }
}
