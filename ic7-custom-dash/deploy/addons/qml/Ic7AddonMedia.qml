import QtQuick 2.9

// One add-on media slot: a static image, a GIF or (via Ic7AddonVideo.qml) a muted MP4.
// It is visible only when asked to show AND its media has decoded, so the stock
// rendering underneath is never replaced by a blank or broken picture.
Item {
    id: slot
    property string source: ""
    property bool shown: false
    property bool animate: true
    readonly property string kind: source === "" ? "" :
        (/\.gif$/i.test(source) ? "gif" : (/\.mp4$/i.test(source) ? "mp4" : "image"))
    readonly property bool ready: kind === "image" ? still.status === Image.Ready :
        (kind === "gif" ? animation.status === Image.Ready :
         (kind === "mp4" ? (video.item !== null && video.item.ready === true) : false))
    readonly property bool failed: (kind === "image" && still.status === Image.Error) ||
        (kind === "gif" && animation.status === Image.Error) ||
        (kind === "mp4" && (video.status === Loader.Error ||
                            (video.item !== null && video.item.errorString !== "")))
    visible: shown && ready
    // Whether the stock rendering underneath may be hidden. Never for MP4: MediaPlayer
    // reports Loaded/Buffered before any frame is drawn, so the stock icon stays drawn
    // under the video and a warning can never go blank.
    readonly property bool covers: visible && kind !== "mp4"
    onFailedChanged: {
        if (failed)
            console.error("Ic7AddonMedia: cannot show " + source + "; stock rendering kept");
    }

    Image {
        id: still
        objectName: "ic7AddonStill"
        anchors.fill: parent
        source: slot.kind === "image" ? slot.source : ""
        fillMode: Image.PreserveAspectFit
        smooth: true
    }
    AnimatedImage {
        id: animation
        objectName: "ic7AddonAnimation"
        anchors.fill: parent
        source: slot.kind === "gif" ? slot.source : ""
        fillMode: Image.PreserveAspectFit
        smooth: true
        cache: false
        playing: slot.visible && slot.animate
    }
    // A video decoder is held only while this slot is meant to be on screen.
    Loader {
        id: video
        anchors.fill: parent
        active: slot.kind === "mp4" && slot.shown
        source: "Ic7AddonVideo.qml"
        onLoaded: {
            item.source = Qt.binding(function() { return slot.source; });
            item.playing = Qt.binding(function() { return slot.shown && slot.animate; });
        }
    }
}
