import QtQuick 2.9
import QtMultimedia 5.9

// Muted, looping MP4 for an add-on media slot. Kept in its own file and loaded only
// while the slot is shown, so QtMultimedia problems or a busy video decoder can only
// disable this add-on media (the stock indicator is then drawn instead).
Item {
    id: videoSlot
    objectName: "ic7AddonVideo"
    property string source: ""
    property bool playing: false
    readonly property bool ready: source !== "" && player.error === MediaPlayer.NoError &&
        (player.status === MediaPlayer.Loaded || player.status === MediaPlayer.Buffered ||
         player.status === MediaPlayer.Buffering)
    readonly property string errorString: player.error === MediaPlayer.NoError ? "" : player.errorString

    function sync() {
        if (playing && source !== "")
            player.play();
        else
            player.pause();
    }
    onPlayingChanged: sync()
    onSourceChanged: sync()

    MediaPlayer {
        id: player
        source: videoSlot.source
        autoPlay: false
        muted: true
        loops: MediaPlayer.Infinite
        onErrorChanged: {
            if (error !== MediaPlayer.NoError)
                console.error("Ic7AddonVideo: " + videoSlot.source + ": " + errorString);
        }
    }
    VideoOutput {
        anchors.fill: parent
        source: player
        fillMode: VideoOutput.PreserveAspectFit
    }
    Component.onCompleted: sync()
}
