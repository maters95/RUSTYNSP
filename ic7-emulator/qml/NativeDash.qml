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
    color: "#101314"
    property var items: ({})
    property string statusText: "Connecting"

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
        }
    }

    function update() {
        var scene = JSON.parse(simulator.scene);
        statusText = scene.status;
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
    }
    Connections { target: simulator; onChanged: window.update() }
}