import QtQuick 2.9
import QtTest 1.2
import "runtime/device/resources/qml_components_data/qml/user_components/ic7addons.js" as Addons

// Track/position map add-on on HalNumeric (ic7_track_map.json): two gauges, one channel each.
Item {
    id: window
    width: 600
    height: 400

    readonly property string device: "runtime/device/resources/qml_components_data/qml/user_components/"
    readonly property string nomanifest: "runtime/nomanifest/resources/qml_components_data/qml/user_components/"

    TestCase {
        name: "TrackMap"
        when: windowShown

        property var made: []

        function init() {
            Addons.resetPosition();
        }

        function cleanup() {
            for (var i = 0; i < made.length; i++)
                made[i].destroy();
            made = [];
            wait(1);
        }

        function gauge(folder, channel, value, size) {
            var component = Qt.createComponent(folder + "HalNumeric.qml");
            compare(component.status, Component.Ready, component.errorString());
            var item = component.createObject(window, {x: 10, y: 10, width: size || 100, height: size || 60});
            verify(item !== null);
            made.push(item);
            compare(item.setGaugeProperties({halChanNameText: channel, halRawValue: value,
                halValueText: String(value), halCompWarnMinValue: -2147483647,
                halCompWarnMaxValue: 2147483647}), 1);
            item.repaintAll();
            item.repaintValue();
            return item;
        }

        function mapOf(item) {
            var map = findChild(item, "ic7TrackMap");
            verify(map !== null, "track map add-on must load");
            return map;
        }

        function stockValue(item) {
            return item.children[0].children[0];
        }

        function test_parse_data() {
            return [{tag: "host not lat/lon", file: "bad-map-host.json"},
                    {tag: "one-point outline", file: "bad-map-outline.json"},
                    {tag: "bad json", file: "bad-json.json"}];
        }

        function test_parse(data) {
            var item = gauge(nomanifest, "GPS Longitude", 1510000000, 200);
            var map = mapOf(item);
            map.manifestUrl = Qt.resolvedUrl("runtime/manifests/" + data.file);
            map.reload();
            tryVerify(function() { return map.configurationError !== ""; });
            compare(map.config, null);
            compare(map.replacesValue, false);
            verify(stockValue(item).visible);
        }

        function test_geometry() {
            var b = Addons.emptyBounds();
            b = Addons.growBounds(b, {x: 0, y: 0});
            b = Addons.growBounds(b, {x: 100, y: 50});
            var v = Addons.fitView(b, 220, 220, 10);
            compare(v.scale, 2);
            var p = Addons.toScreen(v, {x: 100, y: 50});
            compare(p.x, 210);
            compare(p.y, 160);
            compare(Addons.project(-10, 20, 0.5).x, 10);
            compare(Addons.project(-10, 20, 0.5).y, 10);
            verify(Addons.shouldLearn([], b, {x: 1, y: 1}));
            verify(!Addons.shouldLearn([{x: 1, y: 1}], b, {x: 1.1, y: 1}), "below 1/250 of the extent");
            verify(Addons.shouldLearn([{x: 1, y: 1}], b, {x: 2, y: 1}));
            Addons.publishPosition("lat", 5, 1000);
            compare(Addons.freshPosition(1000, 3000), null, "needs both halves");
            Addons.publishPosition("lon", -2147483644, 1000);
            compare(Addons.freshPosition(1000, 3000), null, "status values are not positions");
            Addons.publishPosition("lon", 7, 1500);
            compare(Addons.freshPosition(2000, 3000).lon, 7);
            compare(Addons.freshPosition(4100, 3000), null, "stale after maxAge");
        }

        function test_outlineAndCar() {
            var lat = gauge(device, "GPS Latitude", -339005000);
            var lon = gauge(device, "GPS Longitude", 1510005000, 240);
            var latMap = mapOf(lat), lonMap = mapOf(lon);
            tryVerify(function() { return lonMap.config !== null && latMap.config !== null; });
            compare(latMap.role, "lat");
            compare(latMap.isMap, false);
            verify(stockValue(lat).visible, "the latitude gauge stays stock");
            compare(lonMap.role, "lon");
            verify(lonMap.isMap);
            verify(lonMap.replacesValue);
            verify(!stockValue(lon).visible, "the map gauge hides its stock text");
            compare(lonMap.outline.length, 5);
            verify(lonMap.view !== null);
            // Values published by the two gauges place the car.
            lat.setGaugeProperties({halRawValue: -339000000});
            lon.setGaugeProperties({halRawValue: 1510000000});
            lonMap.tick(Date.now());
            verify(lonMap.carVisible);
            var car = findChild(lon, "ic7TrackMapCar");
            verify(car.visible);
            var start = Addons.toScreen(lonMap.view, lonMap.outline[0]);
            fuzzyCompare(lonMap.carX, start.x, 0.01);
            fuzzyCompare(lonMap.carY, start.y, 0.01);
            verify(lonMap.carX >= 0 && lonMap.carX <= 240 && lonMap.carY >= 0 && lonMap.carY <= 240);
            // Loss of GPS (a Haltech status value such as Device Time Out) hides the car.
            lat.setGaugeProperties({halRawValue: -2147483644});
            lonMap.tick(Date.now());
            verify(!lonMap.carVisible);
            verify(!car.visible);
            // The Canvas repaints on its own, rate limited, once the view is dirty.
            var canvas = findChild(lon, "ic7TrackMapCanvas");
            tryVerify(function() { return canvas.paints >= 1; }, 3000);
        }

        function test_learn() {
            var lat = gauge(device, "Learn Lat", 0);
            var lon = gauge(device, "Learn Lon", 0, 200);
            var latMap = mapOf(lat), lonMap = mapOf(lon);
            latMap.manifestUrl = Qt.resolvedUrl("runtime/manifests/learn-map.json");
            lonMap.manifestUrl = latMap.manifestUrl;
            latMap.reload();
            lonMap.reload();
            tryVerify(function() { return lonMap.isMap && latMap.role === "lat"; });
            compare(lonMap.outline.length, 0);
            var now = Date.now();
            for (var i = 0; i < 100; i++) {
                var a = i / 100 * 2 * Math.PI;
                lat.setGaugeProperties({halRawValue: Math.round(1000 * Math.sin(a))});
                lon.setGaugeProperties({halRawValue: Math.round(1000 * Math.cos(a))});
                lonMap.tick(now);
            }
            verify(lonMap.learned.length > 50, "path learned: " + lonMap.learned.length);
            verify(lonMap.learned.length <= 100);
            verify(lonMap.view !== null);
            verify(lonMap.carVisible);
            verify(lonMap.carX >= 0 && lonMap.carX <= 200);
        }

        function test_otherGaugesUntouched() {
            var item = gauge(device, "Coolant Temp", 80);
            var map = mapOf(item);
            tryVerify(function() { return map.entries.length === 1; });
            compare(map.config, null);
            compare(map.role, "");
            verify(stockValue(item).visible);
            verify(!findChild(item, "ic7TrackMapCanvas").visible);
        }

        function test_noManifest() {
            var item = gauge(nomanifest, "GPS Longitude", 1510000000, 200);
            var map = mapOf(item);
            wait(50);
            compare(map.entries.length, 0);
            compare(map.configurationError, "");
            verify(stockValue(item).visible);
        }

        function test_offManifest() {
            var item = gauge(device, "GPS Longitude", 1510000000, 200);
            var map = mapOf(item);
            map.manifestUrl = Qt.resolvedUrl("runtime/manifests/off-map.json");
            map.reload();
            tryVerify(function() { return map.entries.length === 0; });
            compare(map.configurationError, "");
            verify(stockValue(item).visible);
        }
    }
}
