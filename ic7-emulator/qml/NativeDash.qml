import QtQuick 2.9
import QtQuick.Window 2.3
import QtQuick.Controls 2.2

ApplicationWindow {
    id: window
    visible: true
    width: 800
    height: 530
    minimumWidth: 640
    minimumHeight: 410
    title: "iC-7 Live QML Simulator"
    color: "black"
    property var items: ({})
    property string statusText: "Connecting"
    property string displayPhase: "blank"
    property string splashManifest: ""
    property string userImageBase: ""
    property string stockImageBase: ""
    property int rebootRevision: -1
    property string alertManifest: ""
    property var previewAlerts: []
    property int activeScreenNumber: 0
    property bool alarmScreenTrackingEnabled: true
    Component.onDestruction: alarmScreenTrackingEnabled = false

    function reportAlarmScreen(number, shown) {
        if (shown)
            activeScreenNumber = number;
        else if (activeScreenNumber === number)
            activeScreenNumber = 0;
    }

    Rectangle {
        id: toolbar
        width: parent.width
        height: 50
        color: "#f3f6f4"
        ComboBox {
            id: screenPicker
            width: 120
            height: 38
            anchors.left: parent.left
            anchors.leftMargin: 8
            anchors.verticalCenter: parent.verticalCenter
            model: ["Screen 1", "Screen 2", "Screen 3", "Screen 4", "Screen 5", "Screen 6", "Screen 7", "Screen 8", "Screen 9", "Screen 10"]
            onActivated: simulator.setScreen(currentIndex)
        }
        Text {
            anchors.left: screenPicker.right
            anchors.leftMargin: 12
            anchors.right: parent.right
            anchors.rightMargin: 8
            anchors.verticalCenter: parent.verticalCenter
            text: window.statusText
            color: "#243b2d"
            font.pixelSize: 12
            elide: Text.ElideRight
        }
    }
    Item {
        anchors.top: toolbar.bottom
        anchors.bottom: parent.bottom
        width: parent.width
        clip: true
        Item {
            id: dash
            width: 860
            height: 480
            transform: Scale { xScale: dash.parent.width / 860; yScale: dash.parent.height / 480 }
            Rectangle {
                anchors.fill: parent
                color: "black"
                z: -1
            }
            Loader {
                id: alertLoader
                objectName: "alertPreviewLoader"
                anchors.fill: parent
                z: 9000
                active: false
                onLoaded: {
                    item.manifestUrl = window.alertManifest;
                    item.userImageBaseUrl = window.userImageBase;
                    item.stockImageBaseUrl = window.stockImageBase;
                    item.halFontPath = "";
                    item.activeScreenNumber = Qt.binding(function() { return window.activeScreenNumber; });
                    item.reloadAlertMedia();
                    item.reInitAlarmScreen(JSON.stringify(window.previewAlerts));
                }
                onStatusChanged: {
                    if (status === Loader.Error)
                        window.statusText = "Alert preview QML failed to load";
                }
            }
            Loader {
                id: splashLoader
                anchors.fill: parent
                z: 10000
                active: false
                source: Qt.resolvedUrl("stock_renderer/HalSplash.qml")
                onLoaded: {
                    item.manifestUrl = window.splashManifest;
                    item.userImageBaseUrl = window.userImageBase;
                    item.stockImageBaseUrl = window.stockImageBase;
                    item.start();
                }
                onStatusChanged: {
                    if (status === Loader.Error)
                        window.statusText = "Splash media unavailable: QtMultimedia runtime failed to load";
                }
            }
        }
    }

    function update() {
        var scene = JSON.parse(simulator.scene);
        statusText = scene.status;
        if (rebootRevision !== scene.display.reboot_revision)
            splashLoader.active = false;
        rebootRevision = scene.display.reboot_revision;
        splashManifest = scene.display.splash_manifest || "";
        userImageBase = scene.display.user_image_base || "";
        stockImageBase = scene.display.stock_image_base || "";
        displayPhase = scene.display.phase;
        splashLoader.active = displayPhase === "splash";
        alertManifest = scene.display.alert_manifest || "";
        previewAlerts = scene.display.preview_alerts || [];
        alertLoader.source = scene.display.alert_component || "";
        alertLoader.active = displayPhase !== "blank" && previewAlerts.length > 0;
        if (alertLoader.item)
            alertLoader.item.reInitAlarmScreen(JSON.stringify(previewAlerts));
        var alive = {};
        for (var index = 0; index < scene.components.length; index++) {
            var record = scene.components[index];
            var key = "c" + record.index;
            alive[key] = true;
            var existing = items[key];
            if (existing && existing.source !== record.source) {
                existing.item.destroy();
                delete items[key];
                existing = null;
            }
            if (!existing) {
                var component = Qt.createComponent(record.source);
                if (component.status !== Component.Ready) {
                    console.warn(component.errorString());
                    continue;
                }
                var instance = component.createObject(dash);
                if (!instance) continue;
                existing = {item: instance, source: record.source};
                items[key] = existing;
            }
            existing.item.setGaugeProperties(record.props);
            existing.item.repaintAll();
            existing.item.repaintValue();
        }
        for (var name in items) {
            if (!alive[name]) {
                items[name].item.destroy();
                delete items[name];
            }
        }
        activeScreenNumber = scene.screen === undefined ? 0 : scene.screen + 1;
    }
    Connections { target: simulator; onChanged: window.update() }
}