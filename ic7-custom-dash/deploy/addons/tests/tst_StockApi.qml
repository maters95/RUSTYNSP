import QtQuick 2.9
import QtTest 1.2

// Every stock property, function, objectName and return value is preserved.
Item {
    id: window
    width: 400
    height: 300

    readonly property string stockFolder: "runtime/stock/resources/qml_components_data/qml/user_components/"
    readonly property string addonFolder: "runtime/device/resources/qml_components_data/qml/user_components/"

    TestCase {
        name: "StockApi"
        when: windowShown

        function create(folder, file) {
            var component = Qt.createComponent(folder + file);
            compare(component.status, Component.Ready, component.errorString());
            var item = component.createObject(window);
            verify(item !== null);
            return item;
        }

        function keys(object) {
            var result = [];
            for (var key in object)
                result.push(key + ":" + typeof object[key]);
            return result.sort();
        }

        function outcome(callable) {
            try {
                return "returned " + JSON.stringify(callable());
            } catch (error) {
                return "threw " + String(error);
            }
        }

        function test_api_data() {
            return [{tag: "HalIndicator", file: "HalIndicator.qml"}, {tag: "HalNumeric", file: "HalNumeric.qml"},
                    {tag: "HalBarHorizontal1", file: "HalBarHorizontal1.qml"},
                    {tag: "HalCircularClassic", file: "HalCircularClassic.qml"}];
        }

        function test_api(data) {
            var stock = create(stockFolder, data.file);
            var addon = create(addonFolder, data.file);
            try {
                verify(keys(stock).length > 40, "stock API enumerated");
                compare(keys(addon).join(","), keys(stock).join(","));
                compare(addon.objectName, stock.objectName);
                compare(addon.width, stock.width);
                compare(addon.height, stock.height);
                compare(addon.z, stock.z);
                var calls = [
                    function(item) { return item.setGaugeProperties({halRawValue: 3, halChanNameText: "Coolant Temp"}); },
                    function(item) { return item.setGaugeProperties({halRawValue: 4, notAHalProperty: 1}); },
                    function(item) { return item.setGaugeProperties({ic7AddonFx: 1, ic7AddonIndicator: 1, host: 1}); },
                    function(item) { return item.repaintAll(); },
                    function(item) { return item.repaintValue(); },
                    function(item) { return item.hidePeakNeedle(); },
                    function(item) { return typeof item.showPeakNeedle === "function" ? item.showPeakNeedle(2) : "absent"; }
                ];
                for (var i = 0; i < calls.length; i++)
                    compare(outcome(function() { return calls[i](addon); }),
                            outcome(function() { return calls[i](stock); }), "call " + i);
                // Property values after the same calls are identical.
                for (var key in stock) {
                    if (typeof stock[key] === "function" || key === "parent" || key === "data" ||
                            key === "resources" || key === "children" || key === "visibleChildren" ||
                            key === "anchors" || key === "transform" || key === "states" ||
                            key === "transitions" || key === "childrenRect" || key === "layer" ||
                            key === "objectName")
                        continue;
                    compare(String(addon[key]), String(stock[key]), key);
                }
            } finally {
                stock.destroy();
                addon.destroy();
                wait(1);
            }
        }
    }
}
