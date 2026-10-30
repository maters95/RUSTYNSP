import QtQuick 2.9
import "ic7addons.js" as Addons
import "common.js" as Common

// Experimental clock add-on for HalNumeric. Configured by ic7_clock.json, keyed by the
// gauge's channel name (halChanNameText). For a matching gauge it draws the time of day
// in place of the stock value and unit text, using the gauge's own font, size, alignment
// and value colour:
//   source "channel": the channel carries seconds since midnight (raw x scale), for
//                     example a Generic CAN signal from the ECU or a GPS/CAN clock node;
//   source "system":  the dash's system clock (diagnostic only: nothing on the iC-7
//                     sets it, see deploy/vracer/README.md).
// Fails closed: no manifest, a bad manifest, no matching channel, a Haltech status value
// (No I/O, Device Time Out, ...) or a gauge value in warning all leave the stock drawing.
Item {
    id: clock
    objectName: "ic7Clock"
    // Sized by the Loader in the stock gauge.

    property var host: null
    property url userImageBaseUrl: Qt.resolvedUrl(
        Qt.resolvedUrl(".").toString().indexOf("/resources/qml_components_data/") >= 0
        ? "../../../../user_resources/images/" : "../../../user_resources/images/")
    property url manifestUrl: userImageBaseUrl + "ic7_clock.json"

    property var entries: []
    property string configurationError: ""
    property var now: new Date()
    readonly property var entry: host ? Addons.findGauge(entries, host.halChanNameText) : null
    readonly property bool inWarning: entry !== null &&
        Addons.numericWarning(host.halRawValue, host.halCompWarnMinValue, host.halCompWarnMaxValue)
    readonly property string text: entry !== null ? Addons.clockText(entry, host.halRawValue, now) : ""
    // Read by the host gauge to hide its stock value and unit text.
    readonly property bool replacesValue: entry !== null && text !== "" && !inWarning

    function fail(message) {
        configurationError = message;
        entries = [];
        console.error("Ic7Clock: " + message + "; stock gauges kept");
    }

    function reload() {
        Addons.readTextCached(manifestUrl, function(status, text) {
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
                var parsed = Addons.parseClock(text);
                if (parsed.error !== "") {
                    fail(parsed.error);
                    return;
                }
                configurationError = "";
                entries = parsed.entries;
            } catch (error) {
                console.error("Ic7Clock: " + error);
            }
        });
    }

    Timer {
        // Only the system clock needs ticking; a channel clock follows its value updates.
        interval: 1000
        repeat: true
        running: clock.entry !== null && clock.entry.source === "system" && clock.host.visible === true
        onTriggered: clock.now = new Date()
    }

    Text {
        id: timeText
        objectName: "ic7ClockText"
        visible: clock.replacesValue
        anchors.fill: parent
        text: clock.text
        color: clock.host ? clock.host.halNumericValueColour : "white"
        horizontalAlignment: clock.host ? Common.setting_to_horizontal_align_text(clock.host.halValueFontAlign) : Text.AlignRight
        verticalAlignment: clock.host ? Common.setting_to_vertical_align_text(clock.host.halValueFontAlign) : Text.AlignVCenter
        font: Qt.font({
               family: clock.host ? clock.host.halFontFamily : "",
               pixelSize: Math.max(1, clock.host ? clock.host.halValueFontSize : 20),
               weight: Font.DemiBold })
        fontSizeMode: Text.Fit
    }

    Text {
        id: dateLine
        objectName: "ic7ClockDate"
        visible: clock.replacesValue && clock.entry.showDate === true
        anchors.fill: parent
        text: visible ? Addons.dateText(clock.now, clock.entry.offsetMinutes) : ""
        color: clock.host ? clock.host.halNumericUnitColour : "white"
        horizontalAlignment: Text.AlignRight
        verticalAlignment: Text.AlignBottom
        font: Qt.font({
               family: clock.host ? clock.host.halFontFamily : "",
               pixelSize: Math.max(1, clock.host ? clock.host.halUnitFontSize : 12),
               weight: Font.DemiBold })
    }

    Component.onCompleted: reload()
}
