import QtQuick 2.9
import QtQuick.Layouts 1.3
import QtPositioning 5.9
import QtLocation 5.9
import QtMultimedia 5.9

// Moving map + GPS lap timing.
// PC demo: a simulated car drives a loop so lap timing works with no GPS.
// In the car: set `useSimulatedGps: false` to use the real PositionSource,
// and provide offline map tiles (see README) since there's usually no network.
Rectangle {
    id: page
    color: "#15181c"
    property bool useSimulatedGps: true

    // Finish line: two posts a little apart, straddling the loop's east side.
    readonly property var trackCenter: QtPositioning.coordinate(-33.8356, 151.0820) // demo: Sydney Motorsport Park-ish
    readonly property real loopRadius: 0.0035 // degrees (~350 m)

    Component.onCompleted: {
        // Finish line at the east point of the loop, oriented E-W (constant lat)
        // so the car — travelling N there — crosses it transversally each lap.
        lapTimer.setFinishLine(trackCenter.latitude, trackCenter.longitude + loopRadius - 0.0005,
                               trackCenter.latitude, trackCenter.longitude + loopRadius + 0.0005)
    }

    // Maps come from the app's bundled tiles over loopback HTTP (fully offline).
    // If no tiles are bundled (tileBaseUrl empty), fall back to online OSM.
    readonly property bool localTiles: typeof tileBaseUrl !== "undefined" && tileBaseUrl !== ""
    Plugin {
        id: mapPlugin
        name: "osm"
        PluginParameter { name: "osm.mapping.providersrepository.disabled"; value: page.localTiles }
        PluginParameter { name: "osm.mapping.custom.host"; value: page.localTiles ? tileBaseUrl : "" }
        PluginParameter { name: "osm.mapping.cache.directory"; value: tileCacheDir }
    }

    Map {
        id: map
        anchors.fill: parent
        plugin: mapPlugin
        center: carMarker.coordinate
        zoomLevel: 15
        copyrightsVisible: false
        visible: bgMode === "map"
        Component.onCompleted: {
            if (!page.localTiles) return;
            for (var i = 0; i < supportedMapTypes.length; i++)
                if (supportedMapTypes[i].name.toLowerCase().indexOf("custom") !== -1)
                    activeMapType = supportedMapTypes[i];
        }

        MapQuickItem {
            id: carMarker
            coordinate: page.trackCenter
            anchorPoint.x: dot.width / 2; anchorPoint.y: dot.height / 2
            sourceItem: Rectangle {
                id: dot; width: 16; height: 16; radius: 8
                color: "#39c0ed"; border.color: "white"; border.width: 2
            }
        }
    }

    // Optional animated backgrounds (instead of the map) for an Android-Auto
    // style look. IC7_BG=gif plays bg.gif; IC7_BG=video loops bg.mp4. Files live
    // next to the binary. The lap/clock overlay stays on top in every mode.
    AnimatedImage {
        id: bgGif
        anchors.fill: parent
        visible: bgMode === "gif"
        playing: visible
        fillMode: Image.PreserveAspectCrop
        source: visible ? (bgDir + "/bg.gif") : ""
        cache: false
    }
    Video {
        id: bgVid
        anchors.fill: parent
        visible: bgMode === "video"
        autoPlay: visible
        muted: true
        fillMode: VideoOutput.PreserveAspectCrop
        source: visible ? (bgDir + "/bg.mp4") : ""
        loops: MediaPlayer.Infinite
        onStopped: if (visible) play()   // belt-and-braces loop
    }

    // --- Simulated GPS: drive the loop at ~speed from the CAN feed ---
    property real _angle: 0
    Timer {
        interval: 100; running: page.useSimulatedGps; repeat: true
        onTriggered: {
            // Demo pacing: fixed brisk rate so a lap completes in ~5 s and lap
            // times populate. In the car this is driven by real GPS instead.
            page._angle += 0.12;
            var lat = page.trackCenter.latitude + page.loopRadius * Math.sin(page._angle);
            var lon = page.trackCenter.longitude + page.loopRadius * Math.cos(page._angle);
            carMarker.coordinate = QtPositioning.coordinate(lat, lon);
            lapTimer.addFix(lat, lon);
        }
    }

    // --- Real GPS (used when useSimulatedGps is false) ---
    PositionSource {
        id: gps
        active: !page.useSimulatedGps
        updateInterval: 200
        onPositionChanged: {
            if (position.latitudeValid && position.longitudeValid) {
                carMarker.coordinate = position.coordinate;
                lapTimer.addFix(position.coordinate.latitude, position.coordinate.longitude);
            }
        }
    }

    // --- Lap timing overlay ---
    function fmt(ms) {
        if (ms <= 0) return "--:--.---";
        var m = Math.floor(ms / 60000);
        var s = Math.floor((ms % 60000) / 1000);
        var mil = Math.floor(ms % 1000);
        function p(n, w) { n = "" + n; while (n.length < w) n = "0" + n; return n; }
        return p(m, 2) + ":" + p(s, 2) + "." + p(mil, 3);
    }

    Rectangle {
        anchors.right: parent.right; anchors.top: parent.top
        anchors.margins: 10
        width: 230; height: col.implicitHeight + 24
        color: "#cc15181c"; radius: 10; border.color: "#2a2f36"

        Column {
            id: col
            anchors.centerIn: parent; spacing: 6
            Row {
                spacing: 12
                Text { text: "LAP " + lapTimer.lapCount; color: "#6b7580"; font.pixelSize: 14; font.bold: true }
                Clock { }
            }
            Text { text: "Now   " + page.fmt(lapTimer.currentLapMs); color: "white"; font.pixelSize: 26; font.bold: true }
            Text { text: "Last   " + page.fmt(lapTimer.lastLapMs); color: "#cfd6dd"; font.pixelSize: 18 }
            Text {
                text: "Best  " + page.fmt(lapTimer.bestLapMs)
                color: "#49d17a"; font.pixelSize: 18; font.bold: true
            }
        }
    }

    Text {
        anchors.bottom: parent.bottom; anchors.left: parent.left; anchors.margins: 8
        color: "#6b7580"; font.pixelSize: 11
        text: page.useSimulatedGps ? "simulated GPS — set useSimulatedGps:false in the car" : "live GPS"
    }
}
