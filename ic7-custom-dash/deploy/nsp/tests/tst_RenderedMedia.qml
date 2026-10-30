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
