import QtQuick 2.9
import QtTest 1.2

// A2 threshold effects on HalNumeric, HalBarHorizontal1 and HalCircularClassic.
Item {
    id: window
    width: 500
    height: 400

    readonly property var folders: ({
        device: "runtime/device/resources/qml_components_data/qml/user_components/",
        nsp: "runtime/nsp/qml_components_data/qml/user_components/",
        nomanifest: "runtime/nomanifest/resources/qml_components_data/qml/user_components/"
    })
    readonly property var types: ["HalNumeric.qml", "HalBarHorizontal1.qml", "HalCircularClassic.qml"]

    TestCase {
        name: "GaugeFx"
        when: windowShown

        property var made: []

        function cleanup() {
            for (var i = 0; i < made.length; i++)
                made[i].destroy();
            made = [];
            wait(1);
        }

        function gauge(layout, file, props) {
            var component = Qt.createComponent(folders[layout] + file);
            compare(component.status, Component.Ready, component.errorString());
            var item = component.createObject(window, {x: 20, y: 20, width: 200, height: 120});
            verify(item !== null);
            made.push(item);
            var all = {halCompMinValue: 0, halCompMaxValue: 8000, halCompWarnMinValue: 50,
                halCompWarnMaxValue: 110, halCompWarnMinEnable: true, halCompWarnMaxEnable: true,
                halRawValue: 80, halValueText: "80"};
            for (var key in props)
                all[key] = props[key];
            compare(item.setGaugeProperties(all), 1);
            try {
                item.repaintAll();
            } catch (error) {
                // Stock v2.36 HalBarHorizontal1.repaintAll references an undefined barCanvas
                // and throws on the dash too; the add-on keeps that behaviour unchanged.
                compare(file, "HalBarHorizontal1.qml", String(error));
            }
            item.repaintValue();
            return item;
        }

        function setValue(item, value) {
            compare(item.setGaugeProperties({halRawValue: value, halValueText: String(value)}), 1);
            item.repaintValue();
        }

        function fxOf(item) {
            var fx = findChild(item, "ic7GaugeFx");
            verify(fx !== null, "add-on effect must load");
            return fx;
        }

        function allTypes() {
            var rows = [];
            var layouts = ["device", "nsp"];
            for (var l = 0; l < layouts.length; l++)
                for (var t = 0; t < types.length; t++)
                    rows.push({tag: layouts[l] + ":" + types[t], layout: layouts[l], file: types[t]});
            return rows;
        }

        function test_warnTrigger_data() { return allTypes(); }

        function test_warnTrigger(data) {
            var item = gauge(data.layout, data.file, {halChanNameText: "Coolant Temp"});
            var fx = fxOf(item);
            tryVerify(function() { return fx.entries.length === 3; });
            var frame = findChild(item, "ic7GaugeFxFrame");
            compare(fx.entry.channel, "Coolant Temp");
            compare(frame.visible, false);
            setValue(item, 111);
            compare(fx.triggered, true);
            compare(frame.visible, true);
            compare(frame.border.color.toString(), "#ff00ff");
            compare(frame.border.width, 6);
            // Drawn outside the gauge's bounds and beneath its content.
            compare(frame.x, -6);
            compare(frame.width, item.width + 12);
            verify(findChild(item, "ic7AddonFxLoader").z < 0);
            setValue(item, 49);
            compare(frame.visible, true);
            setValue(item, 80);
            compare(frame.visible, false);
            // Disabled warning limits do not trigger.
            item.setGaugeProperties({halCompWarnMaxEnable: false});
            setValue(item, 200);
            compare(frame.visible, false);
        }

        function test_flashAbove_data() { return allTypes(); }

        function test_flashAbove(data) {
            var item = gauge(data.layout, data.file, {halChanNameText: "Engine Speed", halRawValue: 3000});
            var fx = fxOf(item);
            tryVerify(function() { return fx.entries.length === 3; });
            var frame = findChild(item, "ic7GaugeFxFrame");
            compare(frame.visible, false);
            setValue(item, 6500);
            compare(frame.visible, false, "threshold is exclusive");
            setValue(item, 6501);
            compare(fx.active, true);
            var seen = {on: false, off: false};
            for (var i = 0; i < 12; i++) {
                if (frame.visible) seen.on = true; else seen.off = true;
                wait(40);
            }
            verify(seen.on && seen.off, "5 Hz flash must toggle");
            setValue(item, 6000);
            compare(frame.visible, false);
            tryCompare(fx, "active", false);
        }

        function test_pulseBelow() {
            var item = gauge("device", "HalNumeric.qml", {halChanNameText: "Oil Pressure", halRawValue: 300});
            var fx = fxOf(item);
            tryVerify(function() { return fx.entries.length === 3; });
            var frame = findChild(item, "ic7GaugeFxFrame");
            setValue(item, 99);
            compare(frame.visible, true);
            var low = 1, high = 0;
            for (var i = 0; i < 12; i++) {
                low = Math.min(low, frame.opacity);
                high = Math.max(high, frame.opacity);
                wait(100);
            }
            verify(low >= 0.35 && high <= 1 && high - low > 0.3, "pulse must vary between 0.35 and 1");
        }

        function test_unmatchedChannelIsStock_data() { return allTypes(); }

        function test_unmatchedChannelIsStock(data) {
            var item = gauge(data.layout, data.file, {halChanNameText: "Fuel Level"});
            var fx = fxOf(item);
            tryVerify(function() { return fx.entries.length === 3; });
            setValue(item, 99999);
            compare(fx.entry, null);
            compare(findChild(item, "ic7GaugeFxFrame").visible, false);
        }

        function test_noManifestIsStock() {
            var item = gauge("nomanifest", "HalNumeric.qml", {halChanNameText: "Coolant Temp"});
            var fx = fxOf(item);
            wait(100);
            compare(fx.entries.length, 0);
            compare(fx.configurationError, "");
            setValue(item, 500);
            compare(findChild(item, "ic7GaugeFxFrame").visible, false);
        }

        function test_badManifest_data() {
            return [{tag: "threshold", file: "bad-fx.json"}, {tag: "rate", file: "bad-fx-rate.json"},
                    {tag: "json", file: "bad-json.json"}, {tag: "indicatorManifest", file: "bad-version.json"}];
        }

        function test_badManifest(data) {
            var item = gauge("device", "HalNumeric.qml", {halChanNameText: "Engine Speed"});
            var fx = fxOf(item);
            tryVerify(function() { return fx.entries.length === 3; });
            fx.manifestUrl = Qt.resolvedUrl("runtime/manifests/" + data.file);
            fx.reload();
            tryVerify(function() { return fx.configurationError !== ""; });
            compare(fx.entries.length, 0);
            setValue(item, 9000);
            compare(findChild(item, "ic7GaugeFxFrame").visible, false);
        }

        function test_screenshotAndHiddenStopEffect() {
            var item = gauge("device", "HalNumeric.qml", {halChanNameText: "Engine Speed"});
            var fx = fxOf(item);
            tryVerify(function() { return fx.entries.length === 3; });
            setValue(item, 7000);
            compare(fx.active, true);
            item.screenshotMode = true;
            compare(fx.active, false);
            compare(findChild(item, "ic7GaugeFxFrame").visible, false);
            item.screenshotMode = false;
            compare(fx.active, true);
            item.visible = false;
            compare(fx.active, false);
        }

        function test_stockWarningColourUnchanged() {
            var item = gauge("device", "HalNumeric.qml", {halChanNameText: "Coolant Temp",
                halWarningColour: "#ff0000", halNumericValueColour: "#ffffff"});
            var fx = fxOf(item);
            tryVerify(function() { return fx.entries.length === 3; });
            setValue(item, 150);
            compare(fx.active, true);
            var value = null;
            var texts = item.children[0].children;
            for (var i = 0; i < texts.length; i++)
                if (texts[i].text === "150")
                    value = texts[i];
            verify(value !== null);
            compare(value.color.toString(), "#ff0000");
            compare(value.visible, true);
            compare(value.opacity, 1);
        }
    }
}
