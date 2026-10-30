import QtQuick 2.9
import "ic7addons.js" as Addons

// Experimental HalIndicator add-on (A1 animated indicators, A3 value-driven frames).
// Configured by ic7_indicators.json in the user images, keyed by the filename of the
// image selected for the indicator in NSP. Without a manifest, or for an indicator not
// listed, or while add-on media is not decoded, covering stays false and the stock
// tinted indicator is drawn unchanged. MP4 media never covers: it plays over the
// stock indicator, which stays drawn underneath.
//
// Warning rule: while the stock indicator is ON (warning), only an explicit "on" media
// may replace the tinted image, and the stock glow keeps drawing around it. Value frames
// and "off" media are used only while the stock indicator is OFF.
Item {
    id: addon
    objectName: "ic7IndicatorAddon"
    // Sized by the Loader in the stock gauge.

    property var host: null
    // Same detection as HalAlarmPopup: on the dash, QML is under dtn/resources and the
    // uploads are under dtn/user_resources (four levels up); NSP's renderer keeps
    // user_resources beside qml_components_data (three levels up).
    property url userImageBaseUrl: Qt.resolvedUrl(
        Qt.resolvedUrl(".").toString().indexOf("/resources/qml_components_data/") >= 0
        ? "../../../../user_resources/images/" : "../../../user_resources/images/")
    property url stockImageBaseUrl: Qt.resolvedUrl("../../images/")
    property url manifestUrl: userImageBaseUrl + "ic7_indicators.json"

    property var entries: []
    property string configurationError: ""
    property int frame: -1

    readonly property string imageKey: host ? Addons.imageKey(host.halImagePath) : ""
    readonly property var entry: Addons.findIndicator(entries, imageKey)
    // Identical to HalIndicator.repaintValue's state.
    readonly property bool warning: host !== null &&
        (host.halRawValue >= host.halCompWarnMaxValue || host.halRawValue < host.halCompWarnMinValue)
    readonly property bool animate: host !== null && host.screenshotMode !== true

    readonly property bool covering: entry !== null &&
        ((warning && onMedia.covers) || (!warning && (frameMedia.covers || (frame < 0 && offMedia.covers))))

    function fail(message) {
        configurationError = message;
        entries = [];
        console.error("Ic7IndicatorAddon: " + message + "; stock indicators kept");
    }

    function updateFrame() {
        try {
            frame = (entry && entry.frames) ?
                Addons.frameIndex(entry.frames, host.halRawValue, frame, entry.hysteresis) : -1;
        } catch (error) {
            frame = -1;
        }
    }

    function reload() {
        Addons.readText(manifestUrl, function(status, text) {
            try {
                if (status === 0 && text === "") {
                    configurationError = "";
                    entries = [];
                    return;
                }
                if (status !== 0 && status !== 200) {
                    fail("cannot read " + manifestUrl + ": " + status);
                    return;
                }
                var parsed = Addons.parseIndicators(text);
                if (parsed.error !== "") {
                    fail(parsed.error);
                    return;
                }
                configurationError = "";
                entries = parsed.entries;
                updateFrame();
            } catch (error) {
                console.error("Ic7IndicatorAddon: " + error);
            }
        });
    }

    // Frame selection follows every value the app pushes (cheap: at most 32 comparisons).
    readonly property real value: host ? host.halRawValue : 0
    onValueChanged: updateFrame()
    onEntryChanged: updateFrame()

    Ic7AddonMedia {
        id: onMedia
        objectName: "ic7IndicatorOn"
        anchors.fill: parent
        source: addon.entry && addon.entry.on ?
            Addons.resolve(addon.entry.on, addon.userImageBaseUrl, addon.stockImageBaseUrl) : ""
        shown: addon.warning
        animate: addon.animate
    }
    Ic7AddonMedia {
        id: offMedia
        objectName: "ic7IndicatorOff"
        anchors.fill: parent
        source: addon.entry && addon.entry.off ?
            Addons.resolve(addon.entry.off, addon.userImageBaseUrl, addon.stockImageBaseUrl) : ""
        shown: !addon.warning && addon.frame < 0
        animate: addon.animate
    }
    Ic7AddonMedia {
        id: frameMedia
        objectName: "ic7IndicatorFrame"
        anchors.fill: parent
        source: addon.entry && addon.entry.frames && addon.frame >= 0 && addon.frame < addon.entry.frames.length ?
            Addons.resolve(addon.entry.frames[addon.frame].source, addon.userImageBaseUrl, addon.stockImageBaseUrl) : ""
        shown: !addon.warning && addon.frame >= 0
        animate: addon.animate
    }

    Component.onCompleted: reload()
}
