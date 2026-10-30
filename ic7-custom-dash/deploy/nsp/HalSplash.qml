import QtQuick 2.9

Item {
    id: splash
    objectName: "startupSplash"
    visible: false
    property url manifestUrl: userImageBaseUrl + "ic7_splash.json"
    // On the dash, QML lives under dtn/resources; user_resources is under dtn.
    property url userImageBaseUrl: Qt.resolvedUrl(
        Qt.resolvedUrl(".").toString().indexOf("/resources/qml_components_data/") >= 0
        ? "../../../../user_resources/images/" : "../../../user_resources/images/")
    property url stockImageBaseUrl: Qt.resolvedUrl("../../images/")
    property int maximumDurationMs: 3300
    property string mediaPath: ""
    property string mediaError: ""
    property bool completed: false
    property int generation: 0
    // On the dash main.qml squeezes the 860-wide canvas into the 800-pixel panel.
    readonly property real panelXScale: Qt.platform.os === "windows" ? 1.0 : 800 / 860
    // Same source classification as HalImage.
    readonly property bool videoMedia: /(?:\.mp4|\/ic7_video_[^\/]*\.png)(?:[?#].*)?$/i.test(mediaPath)
    readonly property bool animatedMedia: /(?:\.gif|\/ic7_animation_[^\/]*\.png)(?:[?#].*)?$/i.test(mediaPath)
    signal finished()

    function finish() {
        if (completed)
            return;
        completed = true;
        visible = false;
        timeout.stop();
        video.active = false;
        mediaPath = "";
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
        video.active = false;
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
            video.active = videoMedia;
        };
        request.open("GET", manifestUrl);
        request.send();
    }

    Rectangle {
        anchors.fill: parent
        color: "black"
    }

    // Stock NSP converts a static splash by fitting it, centred on black and never
    // upscaled, into the physical 800 x 480 panel (Form23.smethod_24 with
    // Class25.smethod_1). Lay media out in panel pixels and undo main.qml's squeeze so
    // animated media lands where the stock splash would; an 800 x 480 source fills it.
    Item {
        id: panel
        objectName: "splashPanel"
        width: splash.width * splash.panelXScale
        height: splash.height
        transform: Scale { xScale: 1 / splash.panelXScale }

        // QtQuick-only decoding: PNG/JPEG and GIF splashes never depend on QtMultimedia.
        Image {
            id: still
            objectName: "staticImage"
            readonly property real fit: implicitWidth > 0 && implicitHeight > 0
                ? Math.min(1, panel.width / implicitWidth, panel.height / implicitHeight) : 1
            anchors.centerIn: parent
            width: implicitWidth * fit
            height: implicitHeight * fit
            source: splash.animatedMedia || splash.videoMedia ? "" : splash.mediaPath
            cache: false
            smooth: true
            onStatusChanged: {
                if (status === Image.Error)
                    splash.fail("Startup image could not be decoded");
            }
        }

        AnimatedImage {
            id: animation
            objectName: "animatedImage"
            readonly property real fit: implicitWidth > 0 && implicitHeight > 0
                ? Math.min(1, panel.width / implicitWidth, panel.height / implicitHeight) : 1
            anchors.centerIn: parent
            width: implicitWidth * fit
            height: implicitHeight * fit
            source: splash.animatedMedia ? splash.mediaPath : ""
            cache: false
            smooth: true
            playing: splash.visible
            onStatusChanged: {
                if (status === Image.Error)
                    splash.fail("Startup GIF could not be decoded");
            }
        }

        // Loaded by URL so only MP4 startup media needs the multimedia component.
        Loader {
            id: video
            objectName: "splashMediaLoader"
            anchors.fill: parent
            active: false
            source: "HalImage.qml"
            onLoaded: {
                item.objectName = "splashMedia";
                item.halImageOpacity = 1000;
                item.halImagePath = splash.mediaPath;
                item.repaintAll();
            }
            onStatusChanged: {
                if (status === Loader.Error)
                    splash.fail("Startup video component could not be loaded");
            }
        }

        Connections {
            target: video.item
            ignoreUnknownSignals: true
            onMediaErrorChanged: {
                if (video.item.mediaError !== "")
                    splash.fail(video.item.mediaError);
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
