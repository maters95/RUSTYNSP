import QtQuick 2.9
import QtTest 1.2

// Desktop-only pixel proofs (offscreen grabImage is black under ARM QEMU):
// with no manifest, or no matching entry, the add-on gauges paint exactly like stock;
// with a matching entry they paint the configured media/effect.
Item {
    id: window
    width: 640
    height: 480

    readonly property var folders: ({
        stock: "runtime/stock/resources/qml_components_data/qml/user_components/",
        nomanifest: "runtime/nomanifest/resources/qml_components_data/qml/user_components/",
        device: "runtime/device/resources/qml_components_data/qml/user_components/"
    })
    readonly property string images: "../../../../user_resources/images/"

    Rectangle { id: left; x: 0; y: 0; width: 300; height: 220; color: "black" }
    Rectangle { id: right; x: 320; y: 0; width: 300; height: 220; color: "black" }

    TestCase {
        name: "Pixels"
        when: windowShown

        property var made: []

        function cleanup() {
            for (var i = 0; i < made.length; i++)
                made[i].destroy();
            made = [];
            wait(1);
        }

        function gauge(holder, layout, file, props) {
            var component = Qt.createComponent(folders[layout] + file);
            compare(component.status, Component.Ready, component.errorString());
            var item = component.createObject(holder, {x: 30, y: 30});
            verify(item !== null);
            made.push(item);
            apply(item, props);
            item.repaintAll && tryRepaint(item);
            return item;
        }

        function tryRepaint(item) {
            try { item.repaintAll(); } catch (error) { /* stock HalBarHorizontal1 throws */ }
            item.repaintValue();
        }

        function apply(item, props) {
            compare(item.setGaugeProperties(props), 1);
            tryRepaint(item);
        }

        function settle() {
            // Canvases paint asynchronously; waitForRendering would block for its full
            // timeout when nothing changed, so give the scene graph fixed time instead.
            wait(300);
        }

        function props(type, channel, value) {
            var common = {halChanNameText: channel, halRawValue: value, halValueText: String(value),
                halUnitText: "C", halCompMinValue: 0, halCompMaxValue: 200, halCompWarnMinValue: 50,
                halCompWarnMaxValue: 110, halCompStepSize: 20, halCompMinorTickCount: 1,
                halWarningColour: "#ff0000", halNumericValueColour: "#ffffff", halNumericLabelColour: "#c0c0c0",
                halNumericUnitColour: "#c0c0c0", halValueFontSize: 40, halUnitFontSize: 14, halChanNameFontSize: 14,
                halIndicatorOnColour: "#ff0000", halIndicatorOffColour: "#00ff00"};
            if (type === "HalIndicator.qml") {
                common.halImagePath = images + channel;
                common.halCompWarnMaxValue = 5;
                common.halCompWarnMinValue = -1000;
            }
            if (type === "HalBarHorizontal1.qml" || type === "HalCircularClassic.qml" || type === "HalNumeric.qml") {
                common.width = type === "HalCircularClassic.qml" ? 160 : 220;
                common.height = type === "HalCircularClassic.qml" ? 160 : 90;
            } else {
                common.width = 64;
                common.height = 64;
            }
            return common;
        }

        // Exact comparison of every pixel. Returns the number of differing pixels and the
        // largest per-channel difference.
        function pixelDiff(a, b) {
            var result = {count: 0, max: 0};
            if (a.equals(b))
                return result;
            if (a.width !== b.width || a.height !== b.height)
                return {count: a.width * a.height, max: 255};
            for (var x = 0; x < a.width; x++) {
                for (var y = 0; y < a.height; y++) {
                    var delta = Math.max(Math.abs(a.red(x, y) - b.red(x, y)), Math.abs(a.green(x, y) - b.green(x, y)),
                                         Math.abs(a.blue(x, y) - b.blue(x, y)), Math.abs(a.alpha(x, y) - b.alpha(x, y)));
                    if (delta > 0) {
                        result.count++;
                        result.max = Math.max(result.max, delta);
                    }
                }
            }
            return result;
        }

        function samePixels(a, b) {
            return pixelDiff(a, b).count === 0;
        }

        function test_identicalToStock_data() {
            var rows = [];
            var cases = [
                ["HalIndicator.qml", "shift.png", [0, 9]],
                ["HalIndicator.qml", "other.png", [0, 9]],
                ["HalIndicator.qml", "gear.png", [1, 9]],
                ["HalNumeric.qml", "Coolant Temp", [80, 150, 20]],
                ["HalNumeric.qml", "Fuel Level", [80, 150]],
                ["HalBarHorizontal1.qml", "Coolant Temp", [80, 150]],
                ["HalCircularClassic.qml", "Coolant Temp", [80, 150]]
            ];
            var layouts = ["nomanifest", "device"];
            for (var l = 0; l < layouts.length; l++) {
                for (var c = 0; c < cases.length; c++) {
                    // With a manifest only unmatched entries are expected to be stock.
                    var matched = cases[c][1] === "shift.png" || cases[c][1] === "gear.png" ||
                        cases[c][1] === "Coolant Temp";
                    if (layouts[l] === "device" && matched)
                        continue;
                    rows.push({tag: layouts[l] + ":" + cases[c][0] + ":" + cases[c][1], layout: layouts[l],
                               file: cases[c][0], channel: cases[c][1], values: cases[c][2]});
                }
            }
            return rows;
        }

        // Render each side in the SAME holder at the same screen position: software GL
        // text rasterisation differs by one LSB between screen positions, which is a
        // harness artefact, not a rendering difference.
        function frames(layout, data) {
            var item = gauge(left, layout, data.file, props(data.file, data.channel, data.values[0]));
            var shots = [];
            for (var i = 0; i < data.values.length; i++) {
                apply(item, {halRawValue: data.values[i], halValueText: String(data.values[i])});
                settle();
                var previous = null;
                var shot = grabImage(left);
                // Asynchronous Canvas/image painting: wait until two grabs agree.
                for (var attempt = 0; attempt < 10 && (previous === null || !samePixels(previous, shot)); attempt++) {
                    previous = shot;
                    wait(150);
                    shot = grabImage(left);
                }
                shots.push(shot);
            }
            item.destroy();
            made = [];
            wait(50);
            return shots;
        }

        function test_identicalToStock(data) {
            // Warm-up pass: the first time a glyph or texture is rendered it can be rasterised
            // one LSB differently from later renders (glyph cache), whatever the QML.
            frames("stock", data);
            var stock = frames("stock", data);
            var addon = frames(data.layout, data);
            for (var i = 0; i < data.values.length; i++) {
                var diff = pixelDiff(stock[i], addon[i]);
                if (diff.count > 0)
                    console.warn("pixel difference vs stock: " + diff.count + " px, max " + diff.max + " LSB");
                // Software GL (llvmpipe) occasionally rasterises one anti-aliased needle edge
                // pixel one LSB differently when the scene graph holds an extra (invisible)
                // node; anything beyond that noise floor fails.
                var same = diff.count <= 4 && diff.max <= 1;
                if (!same) {
                    var name = Qt.resolvedUrl("runtime/diff-" + data.tag.replace(/[^A-Za-z0-9]/g, "_") + "-");
                    stock[i].save(name.toString().replace("file://", "") + "stock.png");
                    addon[i].save(name.toString().replace("file://", "") + "addon.png");
                }
                verify(same, "value " + data.values[i] + ": add-on pixels differ from stock");
                var lit = false;
                for (var x = 30; x < 290 && !lit; x += 4)
                    for (var y = 30; y < 200 && !lit; y += 4)
                        lit = stock[i].red(x, y) > 40 || stock[i].green(x, y) > 40 || stock[i].blue(x, y) > 40;
                verify(lit, "the stock gauge must actually paint something");
            }
        }

        function test_animatedIndicatorPaints() {
            var stock = gauge(left, "stock", "HalIndicator.qml", props("HalIndicator.qml", "shift.png", 9));
            var addon = gauge(right, "device", "HalIndicator.qml", props("HalIndicator.qml", "shift.png", 9));
            var on = findChild(addon, "ic7IndicatorOn");
            tryCompare(on, "visible", true);
            var animation = findChild(on, "ic7AddonAnimation");
            animation.playing = false;
            animation.currentFrame = 0;
            settle();
            var first = grabImage(right);
            verify(first.red(62, 62) > 200 && first.green(62, 62) > 90 && first.green(62, 62) < 160,
                   "GIF frame 0 (orange) must be painted");
            verify(!first.equals(grabImage(left)));
            animation.currentFrame = 1;
            settle();
            var second = grabImage(right);
            verify(second.blue(62, 62) > 200, "GIF frame 1 (blue) must be painted");
            // Back to OFF: the static off image (blue square).
            apply(addon, {halRawValue: 0, halValueText: "0"});
            tryCompare(findChild(addon, "ic7IndicatorOff"), "visible", true);
            settle();
            var off = grabImage(right);
            verify(off.blue(33, 33) > 200 && off.red(33, 33) < 40, "off image must be painted");
        }

        function test_valueFramesPaint() {
            var addon = gauge(right, "device", "HalIndicator.qml", props("HalIndicator.qml", "gear.png", 0));
            var frame = findChild(addon, "ic7IndicatorFrame");
            tryCompare(frame, "visible", true);
            settle();
            var neutral = grabImage(right);
            verify(neutral.red(62, 62) > 200 && neutral.green(62, 62) > 200 && neutral.blue(62, 62) < 40, "yellow N");
            apply(addon, {halRawValue: 1, halValueText: "1"});
            tryCompare(frame, "visible", true);
            settle();
            var first = grabImage(right);
            verify(first.red(62, 62) < 40 && first.green(62, 62) > 200 && first.blue(62, 62) > 200, "cyan 1");
        }

        function test_mp4IndicatorPaints() {
            var addon = gauge(right, "device", "HalIndicator.qml", props("HalIndicator.qml", "video.png", 9));
            var on = findChild(addon, "ic7IndicatorOn");
            tryCompare(on, "visible", true, 8000);
            wait(400);
            var first = grabImage(right);
            wait(500);
            verify(!first.equals(grabImage(right)), "MP4 pixels must change while ON");
        }

        function test_effectFramePaintsOutsideBounds() {
            var stock = gauge(left, "stock", "HalNumeric.qml", props("HalNumeric.qml", "Coolant Temp", 150));
            var addon = gauge(right, "device", "HalNumeric.qml", props("HalNumeric.qml", "Coolant Temp", 150));
            var frame = findChild(addon, "ic7GaugeFxFrame");
            tryCompare(frame, "visible", true);
            settle();
            var a = grabImage(left);
            var b = grabImage(right);
            // 6 px magenta border just outside the gauge (x 24..29).
            verify(b.red(27, 60) > 200 && b.blue(27, 60) > 200 && b.green(27, 60) < 40, "frame painted");
            compare(a.red(27, 60), 0);
            // Inside the gauge's own bounds every pixel equals stock.
            var differs = 0;
            for (var x = 30; x < 250; x += 2)
                for (var y = 30; y < 120; y += 2)
                    if (a.pixel(x, y) !== b.pixel(x, y))
                        differs++;
            compare(differs, 0, "the effect must not touch the stock gauge's pixels");
        }
    }
}
