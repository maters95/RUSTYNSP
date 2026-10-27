import QtQuick 2.9

// Reusable arc gauge with a numeric readout and warning colour.
Item {
    id: root
    property string label: ""
    property string unit: ""
    property real value: 0
    property real min: 0
    property real max: 100
    property real warnHigh: max        // turn red at/above this
    property real warnLow: min         // turn red at/below this
    property int decimals: 0
    property color accent: "#39c0ed"

    implicitWidth: 160
    implicitHeight: 160

    readonly property real frac: Math.max(0, Math.min(1, (value - min) / (max - min)))
    readonly property bool warning: value >= warnHigh || value <= warnLow

    Canvas {
        id: canvas
        anchors.fill: parent
        onPaint: {
            var ctx = getContext("2d");
            ctx.reset();
            var cx = width / 2, cy = height / 2;
            var r = Math.min(width, height) / 2 - 10;
            var start = Math.PI * 0.75, end = Math.PI * 2.25;
            // track
            ctx.lineWidth = 12; ctx.lineCap = "round";
            ctx.strokeStyle = "#2a2f36";
            ctx.beginPath(); ctx.arc(cx, cy, r, start, end); ctx.stroke();
            // value
            ctx.strokeStyle = root.warning ? "#ff4040" : root.accent;
            ctx.beginPath(); ctx.arc(cx, cy, r, start, start + (end - start) * root.frac); ctx.stroke();
        }
        Component.onCompleted: requestPaint()
    }
    // repaint when the value changes
    onFracChanged: canvas.requestPaint()
    onWarningChanged: canvas.requestPaint()

    Column {
        anchors.centerIn: parent
        spacing: 2
        Text {
            anchors.horizontalCenter: parent.horizontalCenter
            text: root.value.toFixed(root.decimals)
            color: root.warning ? "#ff6060" : "white"
            font.pixelSize: 34; font.bold: true
        }
        Text {
            anchors.horizontalCenter: parent.horizontalCenter
            text: root.unit; color: "#9aa4ad"; font.pixelSize: 13
        }
        Text {
            anchors.horizontalCenter: parent.horizontalCenter
            text: root.label; color: "#cfd6dd"; font.pixelSize: 14
        }
    }
}
