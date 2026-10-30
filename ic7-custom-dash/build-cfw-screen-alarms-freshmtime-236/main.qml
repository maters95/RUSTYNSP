import QtQuick 2.9
import QtQuick.Controls 2.2
import QtQuick.Window 2.3

Item {
    id: mainWindowId
    objectName: "mainWindow"
    property int userScalePercentage: 100
    property int dashVariantId: 11
    property int activeScreenNumber: 0
    property bool alarmScreenTrackingEnabled: true
    Component.onDestruction: alarmScreenTrackingEnabled = false
    visible: true
    z: 100
    x: 0
    y: 0
    width: 860
    height: 480
    transform: [
        Scale {
            id: scale
            xScale: (Qt.platform.os == "windows") ? userScalePercentage / 100.0 : (dashVariantId != 11) ? 1.0 : 800/860.0
            yScale: (Qt.platform.os == "windows") ? userScalePercentage / 100.0 : 1.0
        },
        Translate { x: 0; y: 0 }
    ]

    // Root items declared here are named so HalAlarmPopup's native screen fallback
    // can tell them apart from the application's unnamed UIScreen containers.
    Rectangle {
        id: selectionRect
        objectName: "selectionRect"
        height: 70
        width: 140
        x: 100
        y: 100
        z: 100
        color: "transparent"
        border.color: "aqua"
        border.width: 3
        visible: false
    }

    Rectangle {
        id: hoverRect
        objectName: "hoverRect"
        height: 70
        width: 140
        x: 100
        y: 100
        z: 100
        color: "transparent"
        border.color: "whitesmoke"
        border.width: 2
        visible: false
    }

    Rectangle {
        id: bg_rect
        objectName: "bg_rect"
        x: 0
        y: 0
        z: 0
        width: parent.width
        height: parent.height
        color: "transparent"
    }

    Rectangle {
        id: fg_tint
        objectName: "fg_tint"
        x: 0
        y: 0
        z: 999
        width: parent.width
        height: parent.height
        color: "#00000000"
        visible: (Qt.platform.os != "windows")
    }

    Loader {
        id: startup
        objectName: "startupSplashLoader"
        anchors.fill: parent
        z: 10000
        source: "../user_components/HalSplash.qml"
        active: dashVariantId === 11
        onStatusChanged: {
            if (status === Loader.Error)
                console.error("Startup splash component could not be loaded");
        }
    }

    Connections {
        target: startup.item
        onFinished: startup.active = false
    }

    function setScreenSize(width, height) {
        mainWindowId.width = width;
        mainWindowId.height = height;
    }

    function reportAlarmScreen(number, shown) {
        if (shown)
            activeScreenNumber = number;
        else if (activeScreenNumber === number)
            activeScreenNumber = 0;
    }

    function setBgColour(colour) {
        bg_rect.color = colour;
    }

    function setFgTintColour(colour) {
        console.log("Tint set to " + colour);
        fg_tint.color = colour;
    }

    function setScreenScale(param) {
        mainWindowId.userScalePercentage = param;
        return "";
    }

    function setDashVariant(param) {
        mainWindowId.dashVariantId = param;
        return "";
    }

    function showSelectionRectangle(param) {
        if (param == "") {
            selectionRect.visible = false;
        } else {
            var params = param.split(',');
            selectionRect.x = params[0];
            selectionRect.y = params[1];
            selectionRect.width = params[2];
            selectionRect.height = params[3];
            selectionRect.radius = 5;
            selectionRect.visible = true;
        }
        return "";
    }

    function showHoverRectangle(param) {
        if (param == "") {
            hoverRect.visible = false;
        } else {
            var params = param.split(',');
            hoverRect.x = params[0];
            hoverRect.y = params[1];
            hoverRect.width = params[2];
            hoverRect.height = params[3];
            hoverRect.radius = 5;
            hoverRect.visible = true;
        }
        return "";
    }
}
