import QtQuick 2.9
import "ic7addons.js" as Addons

// Experimental track/position map for HalNumeric, configured by ic7_track_map.json.
// A gauge receives only ONE channel, so the map needs two Numeric gauges on the screen:
// one on the latitude channel and one on the longitude channel (for example the native
// "GPS Latitude"/"GPS Longitude" channels that CanGPS fills from CAN IDs 0x4F4).
// Both publish their value into ic7addons.js (a .pragma library: one shared instance per
// QML engine); the gauge named by mapChannel hides its stock text and draws the map.
// The track line comes from an outline in the manifest and/or is learned from the driven
// path (lost at power-off: QML cannot write files). Positions stay in raw channel units,
// so the map works whatever scale the dash uses for latitude/longitude.
// Cost: the car marker is a Rectangle moved at 5 Hz; the Canvas repaints at most once a
// second and only after the path or the view changed (no per-frame Canvas work).
Item {
    id: trackMap
    objectName: "ic7TrackMap"

    property var host: null
    property url userImageBaseUrl: Qt.resolvedUrl(
        Qt.resolvedUrl(".").toString().indexOf("/resources/qml_components_data/") >= 0
        ? "../../../../user_resources/images/" : "../../../user_resources/images/")
    property url manifestUrl: userImageBaseUrl + "ic7_track_map.json"
    // 0: no age limit (see Addons.freshPosition); loss of GPS arrives as a status value.
    property int maxAgeMs: 0

    property var entries: []
    property string configurationError: ""
    readonly property var config: host ? Addons.findMap(entries, host.halChanNameText) : null
    readonly property string role: host ? Addons.mapRole(config, host.halChanNameText) : ""
    readonly property bool isMap: role !== "" && String(host.halChanNameText).trim() === config.mapChannel.trim()
    readonly property bool inWarning: role !== "" &&
        Addons.numericWarning(host.halRawValue, host.halCompWarnMinValue, host.halCompWarnMaxValue)
    // Read by the host gauge to hide its stock value and unit text.
    readonly property bool replacesValue: isMap && !inWarning
    readonly property real cosLat: config && config.trackLatitude !== undefined
        ? Math.cos(config.trackLatitude * Math.PI / 180) : 1

    property var outline: []
    property var learned: []
    property var bounds: Addons.emptyBounds()
    property var view: null
    property bool dirty: false
    property bool carVisible: false
    property real carX: 0
    property real carY: 0

    function fail(message) {
        configurationError = message;
        entries = [];
        console.error("Ic7TrackMap: " + message + "; stock gauges kept");
    }

    // Project the configured outline of this gauge's map (once per manifest or channel change).
    function prepare() {
        var parsed = config;
        var points = [];
        var b = Addons.emptyBounds();
        var source = parsed && parsed.outline ? parsed.outline : [];
        var c = parsed && parsed.trackLatitude !== undefined ? Math.cos(parsed.trackLatitude * Math.PI / 180) : 1;
        for (var i = 0; i < source.length; i++) {
            var p = Addons.project(source[i][0], source[i][1], c);
            points.push(p);
            b = Addons.growBounds(b, p);
        }
        outline = points;
        learned = [];
        bounds = b;
        refit();
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
                var parsed = Addons.parseTrackMap(text);
                if (parsed.error !== "") {
                    fail(parsed.error);
                    return;
                }
                configurationError = "";
                entries = parsed.entries;
            } catch (error) {
                console.error("Ic7TrackMap: " + error);
            }
        });
    }

    function refit() {
        var margin = 6 + (config && config.lineWidth !== undefined ? config.lineWidth : 3);
        var next = Addons.fitView(bounds, width, height, margin);
        if (JSON.stringify(next) !== JSON.stringify(view)) {
            view = next;
            dirty = true;
        }
    }

    // One step of the map: read the shared position, learn the path, move the marker.
    function tick(nowMs) {
        var fix = Addons.freshPosition(nowMs, maxAgeMs);
        if (fix === null) {
            carVisible = false;
            return;
        }
        var point = Addons.project(fix.lat, fix.lon, cosLat);
        if (config.learn !== false && Addons.shouldLearn(learned, bounds, point)) {
            var next = learned.slice();
            next.push(point);
            learned = next;
            var grown = Addons.growBounds(bounds, point);
            if (!Addons.sameBounds(grown, bounds)) {
                bounds = grown;
                refit();
            }
            dirty = true;
        }
        if (view === null) {
            carVisible = false;
            return;
        }
        var screen = Addons.toScreen(view, point);
        carX = screen.x;
        carY = screen.y;
        carVisible = true;
    }

    onConfigChanged: prepare()
    onWidthChanged: refit()
    onHeightChanged: refit()

    // Every gauge on the latitude or longitude channel publishes, map or not.
    readonly property real publishedValue: role !== "" ? host.halRawValue : NaN
    onPublishedValueChanged: if (role !== "") Addons.publishPosition(role, publishedValue, Date.now())

    Timer {
        interval: 200
        repeat: true
        running: trackMap.isMap && trackMap.host.visible === true
        onTriggered: trackMap.tick(Date.now())
    }

    Timer {
        interval: 1000
        repeat: true
        running: trackMap.isMap && trackMap.dirty && trackMap.host.visible === true
        onTriggered: {
            trackMap.dirty = false;
            canvas.requestPaint();
        }
    }

    Canvas {
        id: canvas
        objectName: "ic7TrackMapCanvas"
        anchors.fill: parent
        visible: trackMap.replacesValue
        property int paints: 0
        onPaint: {
            var ctx = getContext("2d");
            ctx.clearRect(0, 0, width, height);
            paints++;
            var v = trackMap.view;
            if (v === null)
                return;
            ctx.lineWidth = trackMap.config && trackMap.config.lineWidth !== undefined ? trackMap.config.lineWidth : 3;
            ctx.lineJoin = "round";
            ctx.strokeStyle = trackMap.config && trackMap.config.colour !== undefined ? trackMap.config.colour : "#FFFFFF";
            var paths = [trackMap.outline, trackMap.learned];
            for (var k = 0; k < paths.length; k++) {
                var path = paths[k];
                if (path.length < 2)
                    continue;
                ctx.beginPath();
                var first = Addons.toScreen(v, path[0]);
                ctx.moveTo(first.x, first.y);
                for (var i = 1; i < path.length; i++) {
                    var p = Addons.toScreen(v, path[i]);
                    ctx.lineTo(p.x, p.y);
                }
                ctx.stroke();
            }
        }
    }

    Rectangle {
        id: car
        objectName: "ic7TrackMapCar"
        readonly property int size: 12
        visible: trackMap.replacesValue && trackMap.carVisible
        width: size
        height: size
        radius: size / 2
        x: trackMap.carX - size / 2
        y: trackMap.carY - size / 2
        color: trackMap.config && trackMap.config.carColour !== undefined ? trackMap.config.carColour : "#FF3030"
        border.color: "black"
        border.width: 1
    }

    Component.onCompleted: reload()
}
