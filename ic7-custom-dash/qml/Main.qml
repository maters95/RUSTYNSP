import QtQuick 2.9
import QtQuick.Controls 2.2
import QtQuick.Window 2.3

ApplicationWindow {
    id: win
    visible: true
    width: 800          // iC-7 native panel is driven at 800x480
    height: 480
    title: "iC-7 Custom Dash (POC)"
    color: "#000"

    SwipeView {
        id: view
        anchors.fill: parent
        currentIndex: 0
        GaugesPage { }
        TrackPage { }
    }

    // Screenshot mode (IC7_SHOT): page 1 after 4 s, page 2 after 8 s more, quit.
    Timer {
        id: shotTimer
        property int step: 0
        interval: 4000; repeat: true; running: shotDir !== ""
        onTriggered: {
            var page = step;
            view.grabToImage(function(r) {
                r.saveToFile(shotDir + "/page" + (page + 1) + ".png");
            });
            step++;
            if (step < view.count) { view.currentIndex = step; interval = 16000; }
            else { stop(); quitTimer.start(); }
        }
    }
    Timer { id: quitTimer; interval: 1000; onTriggered: Qt.quit() }

    PageIndicator {
        anchors.bottom: parent.bottom
        anchors.horizontalCenter: parent.horizontalCenter
        anchors.bottomMargin: 4
        count: view.count
        currentIndex: view.currentIndex
    }
}
