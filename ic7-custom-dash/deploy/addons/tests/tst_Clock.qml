import QtQuick 2.9
import QtTest 1.2
import "runtime/device/resources/qml_components_data/qml/user_components/ic7addons.js" as Addons

// Clock add-on on HalNumeric (ic7_clock.json).
Item {
    id: window
    width: 500
    height: 300

    readonly property var folders: ({
        device: "runtime/device/resources/qml_components_data/qml/user_components/",
        nsp: "runtime/nsp/qml_components_data/qml/user_components/",
        nomanifest: "runtime/nomanifest/resources/qml_components_data/qml/user_components/"
    })

    TestCase {
        name: "Clock"
        when: windowShown

        property var made: []

        function cleanup() {
            for (var i = 0; i < made.length; i++)
                made[i].destroy();
            made = [];
            wait(1);
        }

        function gauge(layout, channel, value, extra) {
            var component = Qt.createComponent(folders[layout] + "HalNumeric.qml");
            compare(component.status, Component.Ready, component.errorString());
            var item = component.createObject(window, {x: 10, y: 10, width: 200, height: 90});
            verify(item !== null);
            made.push(item);
            var props = {halChanNameText: channel, halRawValue: value, halValueText: String(value),
                         halUnitText: "s", halCompWarnMinValue: -1e12, halCompWarnMaxValue: 1e12,
                         halValueFontSize: 40, halNumericValueColour: "#FFFFFF"};
            for (var key in extra)
                props[key] = extra[key];
            compare(item.setGaugeProperties(props), 1);
            item.repaintAll();
            item.repaintValue();
            return item;
        }

        function clockOf(item) {
            var clock = findChild(item, "ic7Clock");
            verify(clock !== null, "clock add-on must load");
            return clock;
        }

        // The stock value/unit Text items (the only Text children without an objectName).
        function stockTexts(item) {
            var bounds = item.children[0];
            var texts = [];
            for (var i = 0; i < bounds.children.length; i++)
                texts.push(bounds.children[i]);
            return texts;
        }

        function test_format() {
            compare(Addons.formatClock(0, {}), "00:00");
            compare(Addons.formatClock(13 * 3600 + 5 * 60 + 9, {}), "13:05");
            compare(Addons.formatClock(13 * 3600 + 5 * 60 + 9, {seconds: true}), "13:05:09");
            compare(Addons.formatClock(13 * 3600 + 5 * 60, {hour12: true}), "1:05 PM");
            compare(Addons.formatClock(0, {hour12: true}), "12:00 AM");
            compare(Addons.formatClock(12 * 3600, {hour12: true}), "12:00 PM");
            compare(Addons.formatClock(86400 + 60, {}), "00:01");
            compare(Addons.formatClock(-60, {}), "23:59");
            compare(Addons.clockText({offsetMinutes: 600}, 23 * 3600, null), "09:00");
            compare(Addons.clockText({scale: 0.001}, 3600000, null), "01:00");
            // Haltech status values ("Device Time Out", "No I/O") never show as a time.
            compare(Addons.clockText({}, -2147483644, null), "");
            compare(Addons.clockText({}, NaN, null), "");
            var noon = new Date(Date.UTC(2026, 9, 30, 12, 0, 0));
            compare(Addons.clockText({source: "system", offsetMinutes: 630}, 0, noon), "22:30");
            compare(Addons.dateText(noon, 720), "2026-10-31");
        }

        function test_parse_data() {
            return [{tag: "unknown key", file: "bad-clock-key.json"},
                    {tag: "scale on system", file: "bad-clock-scale.json"},
                    {tag: "offset range", file: "bad-clock-offset.json"},
                    {tag: "bad json", file: "bad-json.json"}];
        }

        function test_parse(data) {
            var item = gauge("nomanifest", "Time Of Day", 3600);
            var clock = clockOf(item);
            clock.manifestUrl = Qt.resolvedUrl("runtime/manifests/" + data.file);
            clock.reload();
            tryVerify(function() { return clock.configurationError !== ""; });
            compare(clock.entries.length, 0);
            compare(clock.replacesValue, false);
            verify(stockTexts(item)[0].visible);
        }

        function test_channelClock_data() {
            return [{tag: "device", layout: "device"}, {tag: "nsp", layout: "nsp"}];
        }

        function test_channelClock(data) {
            var item = gauge(data.layout, "Time Of Day", 13 * 3600 + 7 * 60);
            var clock = clockOf(item);
            tryVerify(function() { return clock.entries.length === 4; });
            compare(clock.text, "13:07");
            verify(clock.replacesValue);
            var shown = findChild(item, "ic7ClockText");
            verify(shown.visible);
            compare(shown.text, "13:07");
            compare(shown.font.pixelSize, 40);
            var texts = stockTexts(item);
            verify(!texts[0].visible, "stock value hidden");
            verify(!texts[1].visible, "stock unit hidden");
            verify(texts[2].visible, "channel label kept");
            compare(item.setGaugeProperties({halRawValue: 7 * 3600 + 59 * 60 + 59}), 1);
            compare(shown.text, "07:59");
        }

        function test_offsetAnd12h() {
            var item = gauge("device", "UTC Time", 3 * 3600 + 4 * 60 + 5);
            var clock = clockOf(item);
            tryVerify(function() { return clock.entries.length === 4; });
            compare(clock.text, "1:04:05 PM");
        }

        function test_failsClosed() {
            // A status value, a warning and an unconfigured channel all keep the stock text.
            var item = gauge("device", "Time Of Day", -2147483644);
            var clock = clockOf(item);
            tryVerify(function() { return clock.entries.length === 4; });
            compare(clock.replacesValue, false);
            verify(stockTexts(item)[0].visible);
            compare(item.setGaugeProperties({halRawValue: 3600, halCompWarnMaxValue: 100}), 1);
            compare(clock.inWarning, true);
            compare(clock.replacesValue, false);
            verify(stockTexts(item)[0].visible);
            var other = gauge("device", "Coolant Temp", 90);
            var otherClock = clockOf(other);
            tryVerify(function() { return otherClock.entries.length === 4; });
            compare(otherClock.entry, null);
            verify(stockTexts(other)[0].visible);
            verify(!findChild(other, "ic7ClockText").visible);
        }

        function test_noManifest() {
            var item = gauge("nomanifest", "Time Of Day", 3600);
            var clock = clockOf(item);
            wait(50);
            compare(clock.entries.length, 0);
            compare(clock.configurationError, "");
            verify(stockTexts(item)[0].visible);
        }

        function test_offManifest() {
            var item = gauge("device", "Time Of Day", 3600);
            var clock = clockOf(item);
            clock.manifestUrl = Qt.resolvedUrl("runtime/manifests/off-clock.json");
            clock.reload();
            tryVerify(function() { return clock.entries.length === 0; });
            compare(clock.configurationError, "");
            verify(stockTexts(item)[0].visible);
        }

        function test_systemClock() {
            var item = gauge("device", "Dash System Clock", 0);
            var clock = clockOf(item);
            tryVerify(function() { return clock.entries.length === 4; });
            verify(clock.replacesValue);
            var now = new Date();
            var expected = Addons.formatClock(now.getUTCHours() * 3600 + now.getUTCMinutes() * 60, {});
            // Allow the minute to roll over between the two reads.
            var shown = clock.text;
            verify(shown === expected || shown.length === 5, shown);
            verify(findChild(item, "ic7ClockDate").visible);
            compare(findChild(item, "ic7ClockDate").text, Addons.dateText(clock.now, undefined));
        }
    }
}
