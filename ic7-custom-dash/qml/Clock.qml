import QtQuick 2.9

// Wall clock. On a PC this is correct. On the dash the system clock only
// survives power-off if an RTC with backup is present (the stock iC-7 likely
// has none), so in the car feed this from GPS time or a CAN time channel and
// bind `epochMs` to that instead of Date.now().
Column {
    id: root
    property double epochMs: Date.now()
    spacing: 0

    Timer {
        interval: 500; running: true; repeat: true
        onTriggered: if (!root._external) root.epochMs = Date.now()
    }
    // set to true once you bind epochMs to GPS/CAN time
    property bool _external: false

    function pad(n) { return (n < 10 ? "0" : "") + n }

    Text {
        anchors.horizontalCenter: parent.horizontalCenter
        color: "white"; font.pixelSize: 30; font.bold: true
        text: {
            var d = new Date(root.epochMs);
            return root.pad(d.getHours()) + ":" + root.pad(d.getMinutes()) + ":" + root.pad(d.getSeconds());
        }
    }
    Text {
        anchors.horizontalCenter: parent.horizontalCenter
        color: "#9aa4ad"; font.pixelSize: 13
        text: {
            var d = new Date(root.epochMs);
            return d.getFullYear() + "-" + root.pad(d.getMonth() + 1) + "-" + root.pad(d.getDate());
        }
    }
}
