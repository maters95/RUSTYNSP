import QtQuick 2.9
import QtTest 1.0

Item {
    id: testWindow
    width: 860
    height: 480

    TestCase {
        name: "StartupRootIntegration"
        when: windowShown

        function test_productionPathsAndReboot() {
            var component = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/qml_components_data/qml/factory_screens/main.qml");
            compare(component.status, Component.Ready, component.errorString());
            for (var boot = 0; boot < 2; boot++) {
                var root = component.createObject(testWindow);
                verify(root !== null);
                var startup = findChild(root, "startupSplashLoader");
                verify(startup !== null);
                tryVerify(function() {
                    return startup.item !== null && startup.item.visible;
                });
                var animation = findChild(root, "animatedImage");
                verify(animation !== null);
                tryCompare(animation, "status", Image.Ready);
                var frame = animation.currentFrame;
                tryVerify(function() { return animation.currentFrame !== frame; });
                tryCompare(startup, "active", false, 4000);
                compare(startup.item, null);
                root.setScreenSize(860, 480);
                root.setBgColour("#112233");
                root.setFgTintColour("#00000000");
                root.setScreenScale(80);
                compare(root.userScalePercentage, 80);
                root.setDashVariant(11);
                root.showSelectionRectangle("1,2,30,40");
                root.showSelectionRectangle("");
                root.showHoverRectangle("1,2,30,40");
                root.showHoverRectangle("");
                root.destroy();
                wait(1);
            }
        }
    }
}
