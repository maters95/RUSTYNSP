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
    }

    TestCase {
        name: "NspImageCompatibility"
        when: windowShown

        function init() {
            candidate.halImagePath = "";
            candidate.halImageOpacity = 1000;
            candidate.screenshotMode = false;
            candidate.visible = true;
            candidate.repaintAll();
        }

        function test_propertyContract() {
            compare(candidate.setGaugeProperties({halImageOpacity: 500, halUnitText: "psi"}), 1);
            compare(candidate.halUnitText, "psi");
            candidate.repaintAll();
            compare(findChild(candidate, "staticImage").opacity, 0.5);
            compare(findChild(candidate, "animatedImage").opacity, 0.5);
            compare(candidate.setGaugeProperties({unknownProperty: true}), 0);
        }

        function test_staticImage() {
            candidate.halImagePath = Qt.resolvedUrl("../../../build-nsp-tests/static.png");
            candidate.repaintAll();
            var image = findChild(candidate, "staticImage");
            tryCompare(image, "status", Image.Ready);
            verify(image.visible);
            verify(!findChild(candidate, "animatedImage").visible);
        }

        function test_gifPlayback() {
            candidate.halImagePath = Qt.resolvedUrl("../../../build-nsp-tests/animated.gif");
            candidate.repaintAll();
            var animation = findChild(candidate, "animatedImage");
            tryCompare(animation, "status", Image.Ready);
            verify(animation.visible);
            verify(!findChild(candidate, "staticImage").visible);
            var firstFrame = animation.currentFrame;
            tryVerify(function() { return animation.currentFrame !== firstFrame; }, 3000);
            candidate.screenshotMode = true;
            tryCompare(animation, "playing", false);
            candidate.screenshotMode = false;
            tryCompare(animation, "playing", true);
            candidate.visible = false;
            tryCompare(animation, "playing", false);
        }

        function test_gifToStatic() {
            candidate.halImagePath = Qt.resolvedUrl("../../../build-nsp-tests/animated.gif");
            candidate.repaintAll();
            tryCompare(findChild(candidate, "animatedImage"), "status", Image.Ready);
            test_staticImage();
        }

        function test_animationPngAlias() {
            candidate.halImagePath = Qt.resolvedUrl("../../../build-nsp-tests/ic7_animation_probe.png");
            candidate.repaintAll();
            var animation = findChild(candidate, "animatedImage");
            tryCompare(animation, "status", Image.Ready);
            verify(animation.visible);
            var firstFrame = animation.currentFrame;
            tryVerify(function() { return animation.currentFrame !== firstFrame; }, 3000);
        }

        function test_mp4PlaybackAndPause() {
            candidate.halImagePath = Qt.resolvedUrl("../../../build-nsp-tests/video.mp4");
            candidate.repaintAll();
            var video = findChild(candidate, "videoPlayer");
            tryVerify(function() {
                return video.status === MediaPlayer.Loaded || video.status === MediaPlayer.Buffered ||
                       video.status === MediaPlayer.Buffering;
            }, 10000);
            verify(video.visible);
            verify(!findChild(candidate, "staticImage").visible);
            compare(video.muted, true);
            compare(video.loops, MediaPlayer.Infinite);
            tryCompare(video, "playbackState", MediaPlayer.PlayingState);
            var startPosition = video.position;
            tryVerify(function() { return video.position > startPosition; }, 3000);

            candidate.screenshotMode = true;
            tryCompare(video, "playbackState", MediaPlayer.PausedState);
            candidate.screenshotMode = false;
            tryCompare(video, "playbackState", MediaPlayer.PlayingState);
            candidate.visible = false;
            tryCompare(video, "playbackState", MediaPlayer.PausedState);
        }
            function test_mp4PngAliasPlaybackAndPause() {
                candidate.halImagePath = Qt.resolvedUrl("../../../build-nsp-tests/ic7_video_probe.png");
                verify(candidate.videoSource);
                verifyVideoPlayback();
            }

            function verifyVideoPlayback() {
                candidate.repaintAll();
                var video = findChild(candidate, "videoPlayer");
                tryVerify(function() {
                    return video.status === MediaPlayer.Loaded || video.status === MediaPlayer.Buffered ||
                           video.status === MediaPlayer.Buffering;
                }, 10000);
                verify(video.visible);
                verify(!findChild(candidate, "staticImage").visible);
                compare(video.muted, true);
                compare(video.loops, MediaPlayer.Infinite);
                tryCompare(video, "playbackState", MediaPlayer.PlayingState);
                var startPosition = video.position;
                tryVerify(function() { return video.position > startPosition; }, 3000);
                candidate.screenshotMode = true;
                tryCompare(video, "playbackState", MediaPlayer.PausedState);
                candidate.screenshotMode = false;
                tryCompare(video, "playbackState", MediaPlayer.PlayingState);
                candidate.visible = false;
                tryCompare(video, "playbackState", MediaPlayer.PausedState);
            }
    }
}