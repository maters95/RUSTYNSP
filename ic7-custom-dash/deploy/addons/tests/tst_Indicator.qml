import QtQuick 2.9
import QtTest 1.2

// A1 animated indicators and A3 value-driven frames, in both folder layouts.
Item {
    id: window
    width: 400
    height: 300

    readonly property var layouts: ({
        device: {folder: "runtime/device/resources/qml_components_data/qml/user_components/",
                 images: "../../../../user_resources/images/"},
        nsp: {folder: "runtime/nsp/qml_components_data/qml/user_components/",
              images: "../../../user_resources/images/"},
        nomanifest: {folder: "runtime/nomanifest/resources/qml_components_data/qml/user_components/",
                     images: "../../../../user_resources/images/"}
    })

    TestCase {
        name: "Indicator"
        when: windowShown

        property var made: []

        function cleanup() {
            for (var i = 0; i < made.length; i++)
                made[i].destroy();
            made = [];
            wait(1);
        }

        // Mirrors the app: setGaugeProperties, repaintAll, then value updates + repaintValue.
        function indicator(layout, image) {
            var component = Qt.createComponent(layouts[layout].folder + "HalIndicator.qml");
            compare(component.status, Component.Ready, component.errorString());
            var item = component.createObject(window, {width: 64, height: 64});
            verify(item !== null);
            made.push(item);
            compare(item.setGaugeProperties({halImagePath: layouts[layout].images + image,
                halCompWarnMinValue: -1000, halCompWarnMaxValue: 5, halRawValue: 0}), 1);
            item.repaintAll();
            item.repaintValue();
            return item;
        }

        function setValue(item, value) {
            item.setGaugeProperties({halRawValue: value, halValueText: String(value)});
            item.repaintValue();
        }

        function addonOf(item) {
            var addon = findChild(item, "ic7IndicatorAddon");
            verify(addon !== null, "add-on component must load");
            return addon;
        }

        function test_layouts_data() {
            return [{tag: "device", layout: "device"}, {tag: "nsp", layout: "nsp"}];
        }

        function test_layouts(data) {
            var item = indicator(data.layout, "shift.png");
            var addon = addonOf(item);
            tryVerify(function() { return addon.entries.length === 4; });
            compare(addon.configurationError, "");
            compare(addon.imageKey, "shift.png");
            var mask = findChild(item, "ic7StockMask");
            var off = findChild(item, "ic7IndicatorOff");
            var on = findChild(item, "ic7IndicatorOn");
            // OFF: the "off" image replaces the tinted stock image once decoded.
            tryCompare(off, "visible", true);
            compare(addon.covering, true);
            compare(mask.visible, false);
            // Crossing the warning threshold: the GIF shows and the stock glow stays on.
            setValue(item, 6);
            compare(addon.warning, true);
            tryCompare(on, "visible", true);
            compare(off.visible, false);
            compare(mask.visible, false);
            var glow = null;
            for (var i = 0; i < item.children.length; i++)
                if (item.children[i].toString().indexOf("Glow") === 0)
                    glow = item.children[i];
            verify(glow !== null);
            compare(glow.visible, true, "stock warning glow must still draw");
            var animation = findChild(on, "ic7AddonAnimation");
            compare(animation.playing, true);
            // Back below the threshold.
            setValue(item, 4.9);
            compare(addon.warning, false);
            tryCompare(off, "visible", true);
            compare(on.visible, false);
            compare(glow.visible, false);
        }

        function test_imageResolvesInLayout_data() {
            return test_layouts_data();
        }

        function test_imageResolvesInLayout(data) {
            var item = indicator(data.layout, "shift.png");
            var off = findChild(item, "ic7IndicatorOff");
            var still = findChild(off, "ic7AddonStill");
            tryCompare(still, "status", Image.Ready);
            verify(still.source.toString().indexOf("user_resources/images/shift_off.png") > 0);
            // The add-on resolves the same folder the stock image does.
            var stockSource = item.children[0].source.toString();
            compare(stockSource.substring(0, stockSource.lastIndexOf("/")),
                    still.source.toString().substring(0, still.source.toString().lastIndexOf("/")));
        }

        function test_unlistedImageIsStock() {
            var item = indicator("device", "other.png");
            var addon = addonOf(item);
            tryVerify(function() { return addon.entries.length === 4; });
            compare(addon.entry, null);
            setValue(item, 9);
            wait(50);
            compare(addon.covering, false);
            compare(findChild(item, "ic7StockMask").visible, true);
        }

        function test_noManifestIsStock() {
            var item = indicator("nomanifest", "shift.png");
            var addon = addonOf(item);
            wait(100);
            compare(addon.entries.length, 0);
            compare(addon.configurationError, "");
            setValue(item, 9);
            wait(50);
            compare(addon.covering, false);
            compare(findChild(item, "ic7StockMask").visible, true);
        }

        function test_frames_data() {
            return test_layouts_data();
        }

        function test_frames(data) {
            var item = indicator(data.layout, "gear.png");
            var addon = addonOf(item);
            tryVerify(function() { return addon.entries.length === 4; });
            var frame = findChild(item, "ic7IndicatorFrame");
            compare(addon.frame, 0);
            tryCompare(frame, "visible", true);
            verify(frame.source.indexOf("gear_n.png") > 0);
            setValue(item, 1);
            compare(addon.frame, 1);
            verify(frame.source.indexOf("gear_1.png") > 0);
            tryCompare(frame, "visible", true);
            // Hysteresis 0.2: 1.6 stays on frame 1, 1.8 moves to frame 2 (a GIF).
            setValue(item, 1.6);
            compare(addon.frame, 1);
            setValue(item, 1.8);
            compare(addon.frame, 2);
            tryCompare(frame, "visible", true);
            compare(frame.kind, "gif");
            // Back down within the band keeps frame 2, then below it returns to 1.
            setValue(item, 1.4);
            compare(addon.frame, 2);
            setValue(item, 1.2);
            compare(addon.frame, 1);
            // Outside every range: stock.
            setValue(item, 4);
            compare(addon.frame, -1);
            tryCompare(addon, "covering", false);
            compare(findChild(item, "ic7StockMask").visible, true);
            // Warning with no "on" media: the stock tinted warning is drawn, never a frame.
            setValue(item, 1);
            tryCompare(addon, "covering", true);
            setValue(item, 7);
            compare(addon.warning, true);
            tryCompare(addon, "covering", false);
            compare(findChild(item, "ic7StockMask").visible, true);
            compare(frame.visible, false);
        }

        function test_badManifest_data() {
            return [
                {tag: "json", file: "bad-json.json"},
                {tag: "version", file: "bad-version.json"},
                {tag: "path", file: "bad-entry.json"},
                {tag: "unknownKey", file: "bad-unknown-key.json"},
                {tag: "frames", file: "bad-frames.json"}
            ];
        }

        function test_badManifest(data) {
            var item = indicator("device", "shift.png");
            var addon = addonOf(item);
            tryVerify(function() { return addon.entries.length === 4; });
            addon.manifestUrl = Qt.resolvedUrl("runtime/manifests/" + data.file);
            addon.reload();
            tryVerify(function() { return addon.configurationError !== ""; });
            compare(addon.entries.length, 0);
            tryCompare(addon, "covering", false);
            compare(findChild(item, "ic7StockMask").visible, true);
            setValue(item, 9);
            compare(addon.covering, false);
        }

        function test_emptyManifestIsStock() {
            var item = indicator("device", "shift.png");
            var addon = addonOf(item);
            tryVerify(function() { return addon.entries.length === 4; });
            addon.manifestUrl = Qt.resolvedUrl("runtime/manifests/empty.json");
            addon.reload();
            tryVerify(function() { return addon.entries.length === 0; });
            compare(addon.configurationError, "");
            tryCompare(addon, "covering", false);
        }

        function test_offManifestIsStock() {
            var item = indicator("device", "shift.png");
            var addon = addonOf(item);
            tryVerify(function() { return addon.entries.length === 4; });
            tryCompare(addon, "covering", true);
            addon.manifestUrl = Qt.resolvedUrl("runtime/manifests/off.json");
            addon.reload();
            tryVerify(function() { return addon.entries.length === 0; });
            compare(addon.configurationError, "");
            tryCompare(addon, "covering", false);
            compare(findChild(item, "ic7StockMask").visible, true);
            setValue(item, 9);
            compare(addon.covering, false);
        }

        function test_missingMediaFallsBackToStock() {
            var item = indicator("device", "missing.png");
            var addon = addonOf(item);
            tryVerify(function() { return addon.entries.length === 4; });
            verify(addon.entry !== null);
            var off = findChild(item, "ic7IndicatorOff");
            tryCompare(off, "failed", true);
            compare(addon.covering, false);
            compare(findChild(item, "ic7StockMask").visible, true);
            setValue(item, 9);
            var on = findChild(item, "ic7IndicatorOn");
            tryCompare(on, "failed", true);
            compare(addon.covering, false);
            compare(findChild(item, "ic7StockMask").visible, true);
        }

        function test_mp4OnMedia() {
            var item = indicator("device", "video.png");
            var addon = addonOf(item);
            tryVerify(function() { return addon.entries.length === 4; });
            var on = findChild(item, "ic7IndicatorOn");
            compare(on.kind, "mp4");
            // No decoder is held while the indicator is off.
            compare(findChild(on, "ic7AddonVideo"), null);
            compare(addon.covering, false);
            var mask = findChild(item, "ic7StockMask");
            setValue(item, 9);
            // MediaPlayer reports Loaded/Buffered before a frame is drawn, so MP4 never
            // hides the stock warning: it stays drawn underneath while loading, playing
            // or after a failure.
            compare(addon.warning, true);
            compare(mask.visible, true);
            compare(addon.covering, false);
            tryVerify(function() { return on.visible || on.failed; }, 8000);
            console.log("mp4 outcome: " + (on.visible ? "decoded and shown" : "failed, stock warning kept"));
            if (on.visible) {
                verify(findChild(on, "ic7AddonVideo").ready);
                compare(on.covers, false);
            }
            for (var tick = 0; tick < 5; tick++) {
                compare(mask.visible, true);
                compare(addon.covering, false);
                wait(100);
            }
            setValue(item, 0);
            tryCompare(on, "visible", false);
            tryCompare(findChild(item, "ic7StockMask"), "visible", true);
            tryVerify(function() { return findChild(on, "ic7AddonVideo") === null; });
        }

        function test_screenshotModeFreezesMedia() {
            var item = indicator("device", "shift.png");
            var addon = addonOf(item);
            tryVerify(function() { return addon.entries.length === 4; });
            setValue(item, 9);
            var on = findChild(item, "ic7IndicatorOn");
            tryCompare(on, "visible", true);
            item.screenshotMode = true;
            compare(findChild(on, "ic7AddonAnimation").playing, false);
        }

        function test_brokenAddonFileKeepsStock() {
            // Simulate a missing/broken add-on file: the Loader errors, the gauge is stock.
            var component = Qt.createComponent(layouts.device.folder + "HalIndicator.qml");
            var item = component.createObject(window, {width: 64, height: 64});
            made.push(item);
            var loader = findChild(item, "ic7AddonIndicatorLoader");
            loader.source = "DoesNotExist.qml";
            compare(loader.item, null);
            compare(findChild(item, "ic7StockMask").visible, true);
            compare(item.setGaugeProperties({halRawValue: 3}), 1);
            item.repaintAll();
            item.repaintValue();
        }
    }
}
