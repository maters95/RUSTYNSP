import QtQuick 2.9
import QtMultimedia 5.9
import QtTest 1.0
import ".." as Candidate

Item {
    id: testWindow
    width: 800
    height: 480

    Candidate.HalImage {
        id: candidate
        width: 320
        height: 200
        halImageOpacity: 1000
    }

    TestCase {
        name: "RenderedMediaPixels"
        when: windowShown

        function test_deviceLayoutStartupPixels_data() {
            return [{tag: "gif", staticImage: false}, {tag: "png", staticImage: true}];
        }

        function test_deviceLayoutStartupPixels(data) {
            var component = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/resources/qml_components_data/qml/user_components/HalSplash.qml");
            compare(component.status, Component.Ready, component.errorString());
            var props = {width: 860, height: 480};
            if (data.staticImage)
                props.manifestUrl = Qt.resolvedUrl("fixtures/png-splash.json");
            var splash = component.createObject(testWindow, props);
            verify(splash !== null);
            try {
                tryCompare(splash, "visible", true);
                var media = findChild(splash, data.staticImage ? "staticImage" : "animatedImage");
                verify(media !== null);
                tryCompare(media, "status", Image.Ready);
                if (!data.staticImage) {
                    media.playing = false;
                    media.currentFrame = 0;
                }
                waitForRendering(media);
                var pixels = grabImage(splash);
                verify(pixels.red(430, 240) > 150, "Startup media must paint over black");
                if (!data.staticImage) {
                    media.currentFrame = 1;
                    waitForRendering(media);
                    verify(!pixels.equals(grabImage(splash)), "Startup GIF pixels must change");
                }
            } finally {
                splash.finish();
                splash.destroy();
                wait(1);
            }
        }

        function test_stockWarningPixelsOverFullScreenAlarmMedia_data() {
            return [{tag: "oil-first", kfcFirst: false}, {tag: "kfc-first", kfcFirst: true}];
        }

        function test_stockWarningPixelsOverFullScreenAlarmMedia(data) {
            var component = Qt.createComponent(
                "../../../build-nsp-tests/splash-runtime/resources/qml_components_data/qml/user_components/HalAlarmPopup.qml");
            compare(component.status, Component.Ready, component.errorString());
            var popup = component.createObject(testWindow, {
                manifestUrl: Qt.resolvedUrl("fixtures/alerts-screens.json"), halFontPath: ""
            });
            verify(popup !== null);
            try {
                tryVerify(function() { return popup.bannerConfig.length === 2; });
                // Only the full-screen KFC GIF rule: OIL PRESSURE is a stock bottom banner.
                popup.manifestRefreshMs = 1000000000;
                popup.bannerConfig = [popup.bannerConfig[0]];
                var oilAlarm = {text: "OIL PRESSURE", height: "60", bc: "#0000ff", fc: "white"};
                var kfcAlarm = {text: "KFC LIMITER", height: "60", bc: "#0000ff", fc: "white"};
                popup.reInitAlarmScreen(JSON.stringify(data.kfcFirst ? [kfcAlarm, oilAlarm] : [oilAlarm, kfcAlarm]));
                var kfc = findChild(popup, "alertBanner:KFC LIMITER");
                verify(kfc !== null);
                var media = findChild(kfc, "animatedImage");
                tryCompare(media, "status", Image.Ready);
                media.playing = false;
                media.currentFrame = 0;
                waitForRendering(media);
                var pixels = grabImage(popup);
                // The GIF's first frame is red; the OIL banner is blue at y 420-480.
                verify(pixels.red(430, 100) > 150, "The full-screen GIF must paint");
                verify(pixels.blue(100, 440) > 150 && pixels.red(100, 440) < 80,
                       "The stock OIL PRESSURE banner must be visible over the GIF");
            } finally {
                popup.destroy();
                wait(1);
            }
        }

        function test_gifPixelsChange() {
            candidate.halImagePath = Qt.resolvedUrl("../../../build-nsp-tests/animated.gif");
            candidate.repaintAll();
            var animation = findChild(candidate, "animatedImage");
            tryCompare(animation, "status", Image.Ready);
            animation.playing = false;
            animation.currentFrame = 0;
            wait(100);
            waitForRendering(animation);
            var first = grabImage(candidate);
            animation.currentFrame = 1;
            wait(100);
            waitForRendering(animation);
            verify(!first.equals(grabImage(candidate)), "The rendered GIF pixels must change");
        }

        function test_mp4PixelsChange() {
            candidate.halImagePath = Qt.resolvedUrl("../../../build-nsp-tests/video.mp4");
            candidate.repaintAll();
            var video = findChild(candidate, "videoPlayer");
            tryCompare(video, "playbackState", MediaPlayer.PlayingState);
            wait(400);
            waitForRendering(video);
            var first = grabImage(candidate);
            wait(500);
            waitForRendering(video);
            verify(!first.equals(grabImage(candidate)), "Decoded video must change the rendered pixels");
        }
    }
}
