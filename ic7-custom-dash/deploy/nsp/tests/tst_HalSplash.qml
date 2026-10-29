import QtQuick 2.9
import QtTest 1.0
import QtMultimedia 5.9
import ".." as Candidate

Item {
    width: 800
    height: 480

    Candidate.HalSplash {
        id: candidate
        width: 800
        height: 480
        manifestUrl: Qt.resolvedUrl("fixtures/disabled-splash.json")
        userImageBaseUrl: Qt.resolvedUrl("../../../build-nsp-tests/")
        stockImageBaseUrl: userImageBaseUrl
    }

    TestCase {
        name: "StartupSplash"
        when: windowShown

        function start(name) {
            candidate.manifestUrl = Qt.resolvedUrl("fixtures/" + name);
            candidate.start();
        }

        function cleanup() {
            candidate.finish();
        }

        function test_disabledAndMissing() {
            start("disabled-splash.json");
            tryCompare(candidate, "completed", true);
            verify(!candidate.visible);
            compare(findChild(candidate, "splashMediaLoader").item, null);
            start("absent-splash.json");
            tryCompare(candidate, "completed", true);
            compare(candidate.mediaError, "");
        }

        function test_invalidManifestAndTraversal() {
            start("invalid-splash.json");
            tryCompare(candidate, "completed", true);
            verify(candidate.mediaError !== "");
            start("traversal-splash.json");
            tryCompare(candidate, "completed", true);
            verify(candidate.mediaError !== "");
        }

        function test_gifAndBoundedHandoff() {
            start("gif-splash.json");
            tryCompare(candidate, "visible", true);
            var animation = findChild(candidate, "animatedImage");
            verify(animation !== null);
            tryCompare(animation, "status", Image.Ready);
            var first = animation.currentFrame;
            tryVerify(function() { return animation.currentFrame !== first; });
            tryCompare(candidate, "completed", true, 4000);
            verify(!candidate.visible);
            compare(findChild(candidate, "splashMediaLoader").item, null);
        }

        function test_videoAndRestart() {
            start("video-splash.json");
            tryCompare(candidate, "visible", true);
            var video = findChild(candidate, "videoPlayer");
            verify(video !== null);
            tryCompare(video, "playbackState", MediaPlayer.PlayingState);
            tryVerify(function() { return video.position > 0; });
            candidate.finish();
            compare(findChild(candidate, "splashMediaLoader").item, null);
            start("gif-splash.json");
            tryCompare(candidate, "visible", true);
            verify(findChild(candidate, "animatedImage") !== null);
        }

        function test_durationLimitIs3300Ms() {
            compare(candidate.maximumDurationMs, 3300);
            start("gif-3300-splash.json");
            tryCompare(candidate, "visible", true);
            compare(findChild(candidate, "splashTimeout").interval, 3300);
            wait(3000);
            verify(!candidate.completed);
            tryCompare(candidate, "completed", true, 1500);
            start("too-long-splash.json");
            tryCompare(candidate, "completed", true);
            verify(candidate.mediaError !== "");
        }

        function test_invalidMediaUnblocksStartup() {
            start("missing-media-splash.json");
            tryCompare(candidate, "completed", true);
            verify(candidate.mediaError !== "");
            verify(!candidate.visible);
        }
    }
}
