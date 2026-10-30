import QtQuick 2.9
import QtMultimedia 5.9

Item {
    id: thisComp
    x: 0
    y: 0
    z: 1
    width: 840
    height: 80

    property real halRawValue: 0
    property string halValueText
    property string halUnitText: "RPM x1000"
    property real halCompMinValue: 0
    property real halCompMaxValue: 10
    property real halCompWarnMinValue
    property real halCompWarnMaxValue
    property bool halCompWarnMinEnable: true
    property bool halCompWarnMaxEnable: true
    property int halImageOpacity
    property string halImagePath
    property real halCompStepSize: 1000
    property int halCompMinorTickCount
    property int halValueFontSize
    property int halValueFontAlign
    property int halChanNameFontSize
    property int halChanNameFontAlign
    property int halUnitFontSize: 16
    property int halUnitFontAlign
    property int halTickFontSize: 50
    property int halTickFontAlign
    property string halChanNameText
    property int halRawUnitType
    property int halDecimalPlaces: 0
    property string halPeakImagePath
    property int halPeakNeedleImageOffset: 0
    property color halWarningColour
    property color halNumericValueColour
    property color halNumericLabelColour
    property color halNumericUnitColour
    property color halBarValueColour: "#C0C0C0"
    property color halBarLabelColour: "#FFFFFF"
    property color halBarTickColour: "#FFFFFF"
    property color halBarMarkingsColour: "#FFFFFF"
    property color halBarBackgroundColour: "#808080"
    property color halPeakNeedleColour
    property color halCircularNeedleColour
    property color halCircularMarkingsColour
    property color halCircularMarkingsWarnColour
    property color halCircularTickColour
    property color halCircularBackgroundColour
    property color halIndicatorOnColour
    property color halIndicatorOffColour
    property bool screenshotMode: false
    property string mediaError: ""

    readonly property bool animatedSource: /(?:\.gif|\/ic7_animation_[^/]*\.png)(?:[?#].*)?$/i.test(halImagePath)
    readonly property bool videoSource: /(?:\.mp4|\/ic7_video_[^/]*\.png)(?:[?#].*)?$/i.test(halImagePath)
    readonly property int alarmScreenMarker: {
        if (width !== 1 || height !== 1 || halImageOpacity !== 0)
            return 0;
        var match = /\/ic7_screen_([1-5])\.png(?:[?&#].*)?$/.exec(halImagePath);
        return match ? Number(match[1]) : 0;
    }
    property var alarmScreenRoot: null
    property int reportedAlarmScreen: 0

    function reportAlarmScreen(shown) {
        if (screenshotMode)
            return;
        var root = parent;
        while (root && typeof root.reportAlarmScreen !== "function")
            root = root.parent;
        if (reportedAlarmScreen && alarmScreenRoot && alarmScreenRoot.alarmScreenTrackingEnabled === true &&
                (!shown || root !== alarmScreenRoot || alarmScreenMarker !== reportedAlarmScreen))
            alarmScreenRoot.reportAlarmScreen(reportedAlarmScreen, false);
        reportedAlarmScreen = 0;
        alarmScreenRoot = root;
        if (!alarmScreenMarker || !shown)
            return;
        if (root && root.alarmScreenTrackingEnabled === true) {
            root.reportAlarmScreen(alarmScreenMarker, shown);
            reportedAlarmScreen = alarmScreenMarker;
        } else if (!root) {
            console.error("HalImage: alarm screen marker has no screen-aware root");
        }
    }

    onAlarmScreenMarkerChanged: if (thisComp) reportAlarmScreen(visible)
    onParentChanged: if (thisComp) reportAlarmScreen(visible)
    Component.onDestruction: if (thisComp) reportAlarmScreen(false)

    function syncVideoPlayback() {
        if (videoSource && visible && !screenshotMode)
            video_obj.play();
        else
            video_obj.pause();
    }

    onVideoSourceChanged: syncVideoPlayback()
    onVisibleChanged: {
        if (thisComp) {
            syncVideoPlayback();
            reportAlarmScreen(visible);
        }
    }
    onScreenshotModeChanged: {
        syncVideoPlayback();
        reportAlarmScreen(visible);
    }
    onHalImagePathChanged: mediaError = ""

    function reportMediaError(message) {
        mediaError = message;
        console.error("HalImage: " + halImagePath + ": " + message);
    }

    function setGaugeProperties(props) {
        var success = 1;
        for (var prop in props) {
            if (thisComp.hasOwnProperty(prop)) {
                thisComp[prop] = props[prop];
            } else {
                success = 0;
            }
        }
        return success;
    }

    function repaintAll() {
        image_obj.opacity = halImageOpacity / 1000;
        syncVideoPlayback();
    }

    function repaintValue() {
    }

    Image {
        id: image_obj
        objectName: "staticImage"
        source: thisComp.animatedSource || thisComp.videoSource ? "" : thisComp.halImagePath
        sourceSize: Qt.size(parent.width, parent.height)
        smooth: true
        antialiasing: true
        anchors.centerIn: parent
        cache: false
        visible: !thisComp.animatedSource && !thisComp.videoSource
        onStatusChanged: {
            if (status === Image.Error)
                thisComp.reportMediaError("Image could not be decoded");
        }
    }

    AnimatedImage {
        objectName: "animatedImage"
        source: thisComp.animatedSource ? thisComp.halImagePath : ""
        width: parent.width
        height: parent.height
        fillMode: Image.PreserveAspectFit
        smooth: true
        antialiasing: true
        anchors.centerIn: parent
        cache: false
        opacity: image_obj.opacity
        visible: thisComp.animatedSource
        playing: visible && thisComp.visible && !thisComp.screenshotMode
        onStatusChanged: {
            if (status === Image.Error)
                thisComp.reportMediaError("GIF could not be decoded");
        }
    }

    Video {
        id: video_obj
        objectName: "videoPlayer"
        source: thisComp.videoSource ? thisComp.halImagePath : ""
        width: parent.width
        height: parent.height
        fillMode: VideoOutput.PreserveAspectFit
        anchors.centerIn: parent
        opacity: image_obj.opacity
        muted: true
        autoPlay: false
        loops: MediaPlayer.Infinite
        visible: thisComp.videoSource
        onSourceChanged: thisComp.syncVideoPlayback()
        onErrorChanged: {
            if (error !== MediaPlayer.NoError)
                thisComp.reportMediaError(errorString);
        }
    }

    Text {
        anchors.fill: parent
        visible: thisComp.mediaError !== ""
        text: "Media error: " + thisComp.mediaError
        color: "#ff6060"
        wrapMode: Text.Wrap
        font.pixelSize: 16
    }
}