import QtQuick 2.9
import QtMultimedia 5.9
import QtTest 1.0
import ".." as Candidate

Item {
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
