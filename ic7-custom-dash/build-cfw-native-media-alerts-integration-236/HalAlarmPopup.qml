import QtQuick 2.9
import QtQuick.Controls 2.2
import QtQuick.Controls.Styles 1.4
import QtGraphicalEffects 1.0
import QtQuick.Layouts 1.3

Item {
    objectName: "HalAlarmPopup"
    id: alertPopup
    x: 0
    y: 0
    z: 9000
    width: 860
    height: 480
    visible: true
    property int currentSelection: 2
    property int alertHeight: 60
    property int dashVariant: 11
    property int alertWidth: 860
    property int alertFontSize: alertHeight * 0.75
    property int repeatCount: 5
    property int alarmRadius: 2
    property int startLocation: 0
    property real alertOpacity: 1.0
    property real imageMargin: 10
    property string halFontPath: "../../fonts/D-DINCondensed-Bold-Dash.ttf"
    property url manifestUrl: Qt.resolvedUrl("../../../user_resources/images/ic7_alerts.json")
    property url userImageBaseUrl: Qt.resolvedUrl("../../../user_resources/images/")
    property url stockImageBaseUrl: Qt.resolvedUrl("../../images/")
    property var bannerConfig: []
    property var activeAlarms: []
    property string activeAlarmMessage: ""
    property string configurationError: ""
    property int requestGeneration: 0
    property bool mediaRequestPending: false
    property bool mediaReloadQueued: false
    property string loadedManifest: ""

    ListModel { id: alarmModel }

    function setGaugeProperties(params) {
        for (var k in params) {
            if (alertPopup.hasOwnProperty(k))
                alertPopup[k] = params[k];
        }
        reloadAlertMedia();
        return 0;
    }

    function setDashVariant(params) {
        dashVariant = params;
        switch (true) {
        case dashVariant === 41:
            alertWidth = 2560;
            height = 720;
            break;
        case dashVariant === 12:
            alertWidth = 1280;
            break;
        default:
            alertWidth = 860;
        }
        rebuildAlarms();
    }

    function configurationFailed(message) {
        configurationError = message;
        console.error("HalAlarmPopup: " + message);
        bannerConfig = [];
        rebuildAlarms();
    }

    function validRectangle(entry) {
        var fields = ["x", "y", "width", "height"];
        for (var i = 0; i < fields.length; i++) {
            var value = entry[fields[i]];
            if (typeof value !== "number" || !isFinite(value) || Math.floor(value) !== value)
                return false;
        }
        return entry.x >= 0 && entry.y >= 0 && entry.width > 0 && entry.height >= 60 &&
            entry.width <= 860 && entry.height <= 480 &&
            entry.x <= 860 - entry.width && entry.y <= 480 - entry.height;
    }

    function reloadAlertMedia() {
        if (mediaRequestPending) {
            mediaReloadQueued = true;
            return;
        }
        mediaRequestPending = true;
        requestGeneration++;
        var generation = requestGeneration;
        var request = new XMLHttpRequest();
        request.onreadystatechange = function() {
            if (request.readyState !== XMLHttpRequest.DONE || generation !== requestGeneration)
                return;
            mediaRequestPending = false;
            if (mediaReloadQueued) {
                mediaReloadQueued = false;
                Qt.callLater(reloadAlertMedia);
            }
            if (request.status === 0 && request.responseText === "") {
                if (loadedManifest === "" && configurationError === "")
                    return;
                loadedManifest = "";
                configurationError = "";
                bannerConfig = [];
                rebuildAlarms();
                return;
            }
            if (request.status !== 0 && request.status !== 200) {
                configurationFailed("Cannot read alert-media manifest: " + request.status);
                return;
            }
            if (request.responseText === loadedManifest)
                return;
            loadedManifest = request.responseText;
            var config;
            try {
                config = JSON.parse(request.responseText);
            } catch (error) {
                configurationFailed("Invalid alert-media JSON: " + error);
                return;
            }
            if (!config || config.version !== 1 || !Array.isArray(config.banners) ||
                    config.banners.length > 100) {
                configurationFailed("Unsupported alert-media manifest");
                return;
            }
            var names = [];
            for (var i = 0; i < config.banners.length; i++) {
                var entry = config.banners[i];
                if (!entry || typeof entry.text !== "string" || entry.text.trim() === "" ||
                        entry.text.length > 200 || names.indexOf(entry.text) >= 0 ||
                        typeof entry.source !== "string" || !validRectangle(entry) ||
                        (entry.gifOnly !== undefined && typeof entry.gifOnly !== "boolean") ||
                        (entry.gifOnly === true && entry.source === "") ||
                        (entry.source !== "" && !/^[uh]\/[^\/\\\x00]+\.(gif|png|jpe?g|bmp)$/i.test(entry.source))) {
                    configurationFailed("Invalid alert-media entry " + i);
                    return;
                }
                names.push(entry.text);
            }
            configurationError = "";
            bannerConfig = config.banners;
            rebuildAlarms();
        };
        request.open("GET", manifestUrl);
        request.send();
    }

    function repaintAll() {
        reloadAlertMedia();
    }

    function resolveImage(source) {
        if (source === "")
            return "";
        var base = source.charAt(0) === "u" ? userImageBaseUrl : stockImageBaseUrl;
        return base + encodeURIComponent(source.substring(2));
    }

    function rebuildAlarms() {
        var offset = 0;
        var rows = [];
        for (var i = 0; i < activeAlarms.length; i++) {
            var alarm = activeAlarms[i];
            var rowHeight = parseInt(alarm.height);
            if (!isFinite(rowHeight) || rowHeight < alertHeight)
                rowHeight = alertHeight;
            var custom = null;
            if (dashVariant === 11) {
                for (var j = 0; j < bannerConfig.length; j++) {
                    if (bannerConfig[j].text === alarm.text) {
                        custom = bannerConfig[j];
                        break;
                    }
                }
            }
            rows.push({text: alarm.text || "", bc: alarm.bc || "black",
                fc: alarm.fc || "white", icon: alarm.img || "",
                banner: custom ? resolveImage(custom.source) : "",
                gifOnly: custom !== null && custom.gifOnly === true,
                positioned: custom !== null, rowX: custom ? custom.x : 0,
                rowY: custom ? custom.y : offset,
                rowWidth: custom ? custom.width : alertWidth,
                rowHeight: custom ? custom.height : rowHeight});
            if (!custom)
                offset += rowHeight;
        }
        startLocation = height - offset;
        if (alarmModel.count > rows.length)
            alarmModel.remove(rows.length, alarmModel.count - rows.length);
        for (var index = 0; index < rows.length; index++) {
            if (!rows[index].positioned)
                rows[index].rowY += startLocation;
            if (index < alarmModel.count)
                alarmModel.set(index, rows[index]);
            else
                alarmModel.append(rows[index]);
        }
    }

    function reInitAlarmScreen(msg) {
        var alarms;
        try {
            alarms = JSON.parse(msg);
        } catch (error) {
            console.error("HalAlarmPopup: invalid active-alarm update: " + error);
            return;
        }
        if (!Array.isArray(alarms)) {
            console.error("HalAlarmPopup: active alarms must be an array");
            return;
        }
        for (var index = 0; index < alarms.length; index++) {
            if (!alarms[index] || typeof alarms[index].text !== "string") {
                console.error("HalAlarmPopup: invalid active-alarm entry " + index);
                return;
            }
        }
        if (msg !== activeAlarmMessage) {
            activeAlarmMessage = msg;
            activeAlarms = alarms;
            rebuildAlarms();
        }
        reloadAlertMedia();
    }

    FontLoader { id: dinFont; source: halFontPath }

    Item {
        objectName: "AlertGauge"
        id: alertGauge
        x: 0
        y: 0
        z: 8
        opacity: alertOpacity
        width: alertWidth
        height: alertPopup.height

        Repeater {
            model: alarmModel
            Rectangle {
                objectName: "alertBanner:" + model.text
                x: model.rowX
                y: model.rowY
                width: model.rowWidth
                height: model.rowHeight
                // GIF-only hides the stock banner, but restores it if the media cannot load.
                property bool mediaOnly: model.gifOnly && bannerMedia.mediaError === ""
                color: mediaOnly ? "transparent" : model.bc
                radius: alarmRadius
                clip: true

                HalImage {
                    id: bannerMedia
                    objectName: "alertBannerMedia"
                    anchors.fill: parent
                    halImagePath: model.banner
                    halImageOpacity: 1000
                    visible: model.banner !== ""
                    Component.onCompleted: repaintAll()
                }
                // Same element and geometry as the stock popup's alarm icon.
                Image {
                    objectName: "alertIcon"
                    source: model.icon
                    verticalAlignment: Text.AlignVCenter
                    horizontalAlignment: Text.AlignLeft
                    x: imageMargin
                    y: imageMargin
                    height: model.rowHeight - 2 * imageMargin
                    width: model.rowHeight + 2 * imageMargin
                    fillMode: Image.PreserveAspectFit
                    visible: model.banner === "" && model.icon !== ""
                    z: 10
                }
                Text {
                    objectName: "alertMessage"
                    anchors.fill: parent
                    font: Qt.font({family: dinFont.name, pixelSize: alertFontSize,
                        weight: Font.DemiBold, italic: false, capitalization: Font.AllUppercase})
                    color: model.fc
                    text: model.text
                    visible: !parent.mediaOnly
                    horizontalAlignment: TextInput.AlignHCenter
                    verticalAlignment: TextInput.AlignVCenter
                    z: 20
                }
            }
        }
    }
    Component.onCompleted: reloadAlertMedia()
}
