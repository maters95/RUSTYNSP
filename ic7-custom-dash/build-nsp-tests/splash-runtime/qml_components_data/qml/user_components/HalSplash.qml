import QtQuick 2.9

Item {
    id: splash
    objectName: "startupSplash"
    visible: false
    // The dash keeps user images at /opt/applications/dtn/user_resources, four levels
    // above user_components (UIComponent::image_src_to_path). NSP's Windows renderer
    // keeps user_resources beside qml_components_data, three levels up. Try the dash
    // first. An explicit manifestUrl/userImageBaseUrl (tests, previews) skips the search.
    property var userImageBaseCandidates: [Qt.resolvedUrl("../../../../user_resources/images/"),
                                           Qt.resolvedUrl("../../../user_resources/images/")]
    property url manifestUrl: ""
    property url userImageBaseUrl: ""
    // The user-image folder the manifest was found in; media resolves against it.
    property url resolvedUserImageBaseUrl: ""
    property url stockImageBaseUrl: Qt.resolvedUrl("../../images/")
    property int maximumDurationMs: 3300
    property string mediaPath: ""
    property string mediaError: ""
    property bool completed: false
    property int generation: 0
    // On the dash main.qml squeezes the 860-wide canvas into the 800-pixel panel.
    readonly property real panelXScale: Qt.platform.os === "windows" ? 1.0 : 800 / 860
    readonly property bool videoMedia: /(?:\.mp4|\/ic7_video_[^\/]*\.png)$/i.test(mediaPath)
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
        fetchManifest(function(request, base) {
            if (completed || requestGeneration !== generation)
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
            resolvedUserImageBaseUrl = base;
            var filename = encodeURIComponent(config.source.substring(2));
            mediaPath = (config.source.charAt(0) === "u"
                ? base : stockImageBaseUrl) + filename;
            timeout.interval = config.durationMs;
            timeout.restart();
            visible = true;
            video.active = videoMedia;
        });
    }

    // Reads ic7_splash.json from the first user-image folder that has it, then calls
    // done(request, folder). A missing file reads as status 0 with no text.
    function fetchManifest(done) {
        var urls = [];
        var bases = [];
        if (String(manifestUrl) !== "") {
            urls.push(manifestUrl);
            bases.push(String(userImageBaseUrl) !== "" ? userImageBaseUrl : userImageBaseCandidates[0]);
        } else {
            for (var i = 0; i < userImageBaseCandidates.length; i++) {
                urls.push(userImageBaseCandidates[i] + "ic7_splash.json");
                bases.push(String(userImageBaseUrl) !== "" ? userImageBaseUrl : userImageBaseCandidates[i]);
            }
        }
        var attempt = function(index) {
            var request = new XMLHttpRequest();
            request.onreadystatechange = function() {
                if (request.readyState !== XMLHttpRequest.DONE)
                    return;
                if (request.status === 0 && request.responseText === "" && index + 1 < urls.length) {
                    attempt(index + 1);
                    return;
                }
                done(request, bases[index]);
            };
            request.open("GET", urls[index]);
            request.send();
        };
        attempt(0);
    }

    Rectangle {
        anchors.fill: parent
        color: "black"
    }

    // Stock NSP converts a static splash by fitting it, centred on black and never
    // upscaled, into the physical 800 x 480 panel (Form23.smethod_24). Lay media out
    // in panel pixels and undo main.qml's squeeze so animated media matches it.
    Item {
        id: panel
        objectName: "splashPanel"
        width: splash.width * splash.panelXScale
        height: splash.height
        transform: Scale { xScale: 1 / splash.panelXScale }

        // QtQuick-only decoding: a GIF splash never depends on QtMultimedia.
        AnimatedImage {
            id: animation
            objectName: "animatedImage"
            readonly property real fit: implicitWidth > 0 && implicitHeight > 0
                ? Math.min(1, panel.width / implicitWidth, panel.height / implicitHeight) : 1
            anchors.centerIn: parent
            width: implicitWidth * fit
            height: implicitHeight * fit
            source: splash.videoMedia ? "" : splash.mediaPath
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
