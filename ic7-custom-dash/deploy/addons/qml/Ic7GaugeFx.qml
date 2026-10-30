import QtQuick 2.9
import "ic7addons.js" as Addons

// Experimental threshold effect (A2) for HalNumeric, HalBarHorizontal1 and
// HalCircularClassic. Configured by ic7_gauge_fx.json, keyed by the gauge's channel
// name (halChanNameText). It only ADDS a coloured frame drawn just outside the gauge's
// bounds and beneath its content: it never covers, dims or recolours the stock value,
// warning colour or markings. Without a manifest or a matching channel it stays hidden.
// Updates are timer driven at no more than 10 Hz and only while triggered and visible.
Item {
    id: fx
    objectName: "ic7GaugeFx"
    // Sized by the Loader in the stock gauge.

    property var host: null
    property url userImageBaseUrl: Qt.resolvedUrl(
        Qt.resolvedUrl(".").toString().indexOf("/resources/qml_components_data/") >= 0
        ? "../../../../user_resources/images/" : "../../../user_resources/images/")
    property url manifestUrl: userImageBaseUrl + "ic7_gauge_fx.json"

    property var entries: []
    property string configurationError: ""
    readonly property var entry: host ? Addons.findGauge(entries, host.halChanNameText) : null
    readonly property bool triggered: entry !== null && host !== null &&
        Addons.triggered(entry, host.halRawValue, host.halCompWarnMinValue, host.halCompWarnMaxValue,
                         host.halCompWarnMinEnable, host.halCompWarnMaxEnable)
    readonly property bool active: triggered && host.visible === true && host.screenshotMode !== true
    readonly property real rateHz: entry && entry.rateHz !== undefined ? entry.rateHz : 2
    property int phase: 0

    function fail(message) {
        configurationError = message;
        entries = [];
        console.error("Ic7GaugeFx: " + message + "; stock gauges kept");
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
                var parsed = Addons.parseGaugeFx(text);
                if (parsed.error !== "") {
                    fail(parsed.error);
                    return;
                }
                configurationError = "";
                entries = parsed.entries;
            } catch (error) {
                console.error("Ic7GaugeFx: " + error);
            }
        });
    }

    onActiveChanged: phase = 0

    Timer {
        id: ticker
        // flash: one toggle per half period; pulse: 10 Hz opacity steps.
        interval: fx.entry && fx.entry.effect === "flash" ? Math.round(500 / fx.rateHz) : 100
        repeat: true
        running: fx.active && fx.entry !== null && fx.entry.effect !== "solid"
        onTriggered: fx.phase = (fx.phase + 1) % 1000000
    }

    Rectangle {
        id: frame
        objectName: "ic7GaugeFxFrame"
        readonly property int lineWidth: fx.entry && fx.entry.width !== undefined ? fx.entry.width : 4
        anchors.fill: parent
        anchors.margins: -lineWidth
        color: "transparent"
        border.width: lineWidth
        border.color: fx.entry && fx.entry.colour !== undefined ? fx.entry.colour
            : (fx.host ? fx.host.halWarningColour : "red")
        visible: fx.active && (fx.entry.effect !== "flash" || fx.phase % 2 === 0)
        opacity: {
            if (!fx.entry || fx.entry.effect !== "pulse")
                return 1;
            // Triangle wave between 0.35 and 1 with the configured period.
            var steps = Math.max(2, Math.round(10 / fx.rateHz));
            var position = (fx.phase % steps) / steps;
            return 0.35 + 0.65 * (position < 0.5 ? 1 - 2 * position : 2 * position - 1);
        }
    }

    Component.onCompleted: reload()
}
