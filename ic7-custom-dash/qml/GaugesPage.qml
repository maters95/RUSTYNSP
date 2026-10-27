import QtQuick 2.9
import QtQuick.Layouts 1.3

// Engine page: big RPM bar + shift light up top, large SPEED, two feature
// gauges, and a strip of compact tiles. All bound to live CAN channels.
Rectangle {
    id: page
    color: "#15181c"

    function ch(name) { return channels[name] !== undefined ? channels[name] : 0 }
    readonly property real rpm: ch("ENGINE_SPEED")
    readonly property bool shift: rpm >= 7000

    // Shift-light flash border near redline.
    Rectangle {
        anchors.fill: parent; color: "transparent"
        border.width: 6; border.color: "#ff2a2a"
        visible: page.shift && blink.on
        Timer { id: blink; property bool on: true; interval: 90; running: page.shift; repeat: true; onTriggered: on = !on }
    }

    ColumnLayout {
        anchors.fill: parent; anchors.margins: 12; spacing: 10

        // Header
        RowLayout {
            Layout.fillWidth: true
            Text { text: "EK9 · ENGINE"; color: "#6b7580"; font.pixelSize: 15; font.bold: true; Layout.fillWidth: true }
            Clock {}
        }

        // RPM bar
        Item {
            Layout.fillWidth: true; Layout.preferredHeight: 92
            Rectangle { anchors.fill: parent; radius: 8; color: "#1d2127" }
            Rectangle {
                id: rpmFill
                height: parent.height; radius: 8
                width: parent.width * Math.max(0, Math.min(1, page.rpm / 8000))
                gradient: Gradient {
                    GradientStop { position: 0.0; color: "#2e7d32" }
                    GradientStop { position: 0.7; color: "#f0a000" }
                    GradientStop { position: 1.0; color: "#ff2a2a" }
                }
            }
            // redline tick at 7000
            Rectangle { x: parent.width * 7000/8000; width: 2; height: parent.height; color: "#ffffff80" }
            Row {
                anchors.left: parent.left; anchors.leftMargin: 16; anchors.verticalCenter: parent.verticalCenter; spacing: 10
                Text { text: Math.round(page.rpm); color: "white"; font.pixelSize: 54; font.bold: true }
                Text { text: "RPM"; color: "#cfd6dd"; font.pixelSize: 18; anchors.bottom: parent.bottom; anchors.bottomMargin: 10 }
            }
        }

        // Main row: big speed + two feature gauges
        RowLayout {
            Layout.fillWidth: true; Layout.fillHeight: true; spacing: 10
            Rectangle {
                Layout.preferredWidth: 280; Layout.fillHeight: true
                radius: 10; color: "#1d2127"
                Column {
                    anchors.centerIn: parent; spacing: -6
                    Text { anchors.horizontalCenter: parent.horizontalCenter; text: Math.round(page.ch("VEHICLE_SPEED")); color: "white"; font.pixelSize: 130; font.bold: true }
                    Text { anchors.horizontalCenter: parent.horizontalCenter; text: "km/h"; color: "#9aa4ad"; font.pixelSize: 22 }
                }
            }
            Gauge {
                Layout.fillWidth: true; Layout.fillHeight: true
                label: "BOOST"; unit: "psi"; min: -15; max: 30; decimals: 1
                value: page.ch("MANIFOLD_PRESSURE")
            }
            Gauge {
                Layout.fillWidth: true; Layout.fillHeight: true
                label: "AFR"; unit: "afr"; min: 10.3; max: 16.9; decimals: 1; accent: "#39c0ed"
                value: page.ch("LAMBDA") * 14.7
            }
        }

        // Compact tiles
        RowLayout {
            Layout.fillWidth: true; Layout.preferredHeight: 78; spacing: 8
            Repeater {
                model: [
                    { k: "COOLANT_TEMP",  l: "COOLANT", u: "°C",  d: 0, lo: -100, hi: 105 },
                    { k: "OIL_TEMP",      l: "OIL T",   u: "°C",  d: 0, lo: -100, hi: 125 },
                    { k: "OIL_PRESSURE",  l: "OIL P",   u: "psi", d: 0, lo: 10,   hi: 9999 },
                    { k: "FUEL_PRESSURE", l: "FUEL P",  u: "psi", d: 0, lo: 25,   hi: 9999 },
                    { k: "INTAKE_AIR_TEMP", l: "IAT",   u: "°C",  d: 0, lo: -100, hi: 60 },
                    { k: "ETHANOL",       l: "ETH",     u: "%",   d: 0, lo: -1,   hi: 9999 }
                ]
                delegate: Rectangle {
                    Layout.fillWidth: true; Layout.fillHeight: true
                    radius: 8; color: "#1d2127"
                    property real v: page.ch(modelData.k)
                    property bool warn: v <= modelData.lo || v >= modelData.hi
                    Column {
                        anchors.centerIn: parent; spacing: 0
                        Text { anchors.horizontalCenter: parent.horizontalCenter; text: v.toFixed(modelData.d); color: warn ? "#ff6060" : "white"; font.pixelSize: 30; font.bold: true }
                        Text { anchors.horizontalCenter: parent.horizontalCenter; text: modelData.u; color: "#9aa4ad"; font.pixelSize: 12 }
                        Text { anchors.horizontalCenter: parent.horizontalCenter; text: modelData.l; color: "#cfd6dd"; font.pixelSize: 13 }
                    }
                }
            }
        }
    }
}
