import QtQuick 2.9

Item {
    id: splash
    objectName: "startupSplash"
    visible: false
    property url manifestUrl: Qt.resolvedUrl("../../../user_resources/images/ic7_splash.json")
    property url userImageBaseUrl: Qt.resolvedUrl("../../../user_resources/images/")
    property url stockImageBaseUrl: Qt.resolvedUrl("../../images/")
    property int maximumDurationMs: 3300
    property string mediaPath: ""
    property string mediaError: ""
    property bool completed: false
    property int generation: 0
    signal finished()

    function finish() {
        if (completed)
            return;
        completed = true;
        visible = false;
        timeout.stop();
        media.active = false;
        finished();
    }

    function fail(message) {
        mediaError = message;
        console.error("HalSplash: " + message);
        finish();
    }

    function start() {
        generation++;
        var requestGeneration = generation;
        completed = false;
        visible = false;
        media.active = false;
        mediaPath = "";
        mediaError = "";
        timeout.interval = maximumDurationMs;
        timeout.restart();
        var request = new XMLHttpRequest();
        request.onreadystatechange = function() {
            if (request.readyState !== XMLHttpRequest.DONE || completed ||
                    requestGeneration !== generation)
                return;
            // An absent manifest is the normal, unconfigured stock startup.
            if (request.status === 0 && request.responseText === "") {
                finish();
                return;
            }
            if (request.status !== 0 && request.status !== 200) {
                fail("Cannot read startup manifest: " + request.status);
                return;
            }
            var config;
            try {
                config = JSON.parse(request.responseText);
            } catch (error) {
                fail("Invalid startup manifest: " + error);
                return;
            }
            if (config.version !== 1 || typeof config.source !== "string" ||
                    typeof config.durationMs !== "number" ||
                    config.durationMs < 1 || config.durationMs > maximumDurationMs) {
                fail("Unsupported startup manifest");
                return;
            }
            if (config.source === "") {
                finish();
                return;
            }
            if (!/^[uh]\/[^\/\\\x00]+$/.test(config.source) ||
                    config.source.substring(2) === "." || config.source.substring(2) === "..") {
                fail("Invalid startup resource path");
                return;
            }
            var filename = encodeURIComponent(config.source.substring(2));
            mediaPath = (config.source.charAt(0) === "u"
                ? userImageBaseUrl : stockImageBaseUrl) + filename;
            timeout.interval = config.durationMs;
            timeout.restart();
            visible = true;
            media.active = true;
        };
        request.open("GET", manifestUrl);
        request.send();
    }

    Rectangle {
        anchors.fill: parent
        color: "black"
    }

    Loader {
        id: media
        objectName: "splashMediaLoader"
        anchors.fill: parent
        active: false
        sourceComponent: Component {
            HalImage {
                objectName: "splashMedia"
                halImagePath: splash.mediaPath
                halImageOpacity: 1000
                Component.onCompleted: repaintAll()
                onMediaErrorChanged: {
                    if (mediaError !== "")
                        splash.fail(mediaError);
                }
            }
        }
    }

    Timer {
        id: timeout
        objectName: "splashTimeout"
        onTriggered: splash.finish()
    }

    Component.onCompleted: start()
}
