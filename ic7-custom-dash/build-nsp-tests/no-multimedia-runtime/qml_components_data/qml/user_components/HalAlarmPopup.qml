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
    property string configurationError: ""
    property int requestGeneration: 0
    // v2.36 UIMain always creates five UIScreen containers in screen order, then
    // Alarm_Module parents this popup to the same root item. Screen changes are
    // QQuickItem::setVisible calls on those containers, so the five preceding
    // siblings identify the native active screen without patching the application.
    readonly property int nativeScreenCount: 5
    property var screenItems: []
    property int currentScreen: -1

    ListModel { id: alarmModel }

    function setGaugeProperties(params) {
        for (var k in params) {
            if (alertPopup.hasOwnProperty(k))
                alertPopup[k] = params[k];
        }
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

    function findNativeScreens() {
        if (!parent)
            return [];
        var siblings = parent.children;
        var index = -1;
        for (var i = 0; i < siblings.length; i++) {
            if (siblings[i] === alertPopup) {
                index = i;
                break;
            }
        }
        if (index < nativeScreenCount)
            return [];
        var screens = [];
        for (var s = index - nativeScreenCount; s < index; s++) {
            // QML-declared root items are named; UIScreen containers are not.
            if (siblings[s].objectName !== "")
                return [];
            screens.push(siblings[s]);
        }
        return screens;
    }

    function attachNativeScreens() {
        for (var i = 0; i < screenItems.length; i++)
            screenItems[i].visibleChanged.disconnect(updateCurrentScreen);
        screenItems = findNativeScreens();
        for (i = 0; i < screenItems.length; i++)
            screenItems[i].visibleChanged.connect(updateCurrentScreen);
        updateCurrentScreen();
    }

    function updateCurrentScreen() {
        var active = -1;
        for (var i = 0; i < screenItems.length; i++) {
            if (!screenItems[i].visible)
                continue;
            if (active >= 0) {
                active = -1;
                break;
            }
            active = i;
        }
        if (active !== currentScreen) {
            currentScreen = active;
            rebuildAlarms();
        }
    }

    function validScreens(entry) {
        if (entry.screens === undefined)
            return true;
        if (!Array.isArray(entry.screens) || entry.screens.length < 1 ||
                entry.screens.length > nativeScreenCount)
            return false;
        for (var i = 0; i < entry.screens.length; i++) {
            var screen = entry.screens[i];
            if (typeof screen !== "number" || Math.floor(screen) !== screen || screen < 0 ||
                    screen >= nativeScreenCount || entry.screens.indexOf(screen) !== i)
                return false;
        }
        return true;
    }

    // Per alarm text: at most one all-screens entry, and screen-specific entries
    // must not claim the same screen twice.
    function overlapsExisting(entry, previous) {
        for (var i = 0; i < previous.length; i++) {
            var other = previous[i];
            if (other.text !== entry.text)
                continue;
            if (entry.screens === undefined && other.screens === undefined)
                return true;
            if (entry.screens === undefined || other.screens === undefined)
                continue;
            for (var j = 0; j < entry.screens.length; j++) {
                if (other.screens.indexOf(entry.screens[j]) >= 0)
                    return true;
            }
        }
        return false;
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
        requestGeneration++;
        var generation = requestGeneration;
        var request = new XMLHttpRequest();
        request.onreadystatechange = function() {
            if (request.readyState !== XMLHttpRequest.DONE || generation !== requestGeneration)
                return;
            if (request.status === 0 && request.responseText === "") {
                configurationError = "";
                bannerConfig = [];
                rebuildAlarms();
                return;
            }
            if (request.status !== 0 && request.status !== 200) {
                configurationFailed("Cannot read alert-media manifest: " + request.status);
                return;
            }
            var config;
            try {
                config = JSON.parse(request.responseText);
            } catch (error) {
                configurationFailed("Invalid alert-media JSON: " + error);
                return;
            }
            if (!config || (config.version !== 1 && config.version !== 2) ||
                    !Array.isArray(config.banners) || config.banners.length > 100) {
                configurationFailed("Unsupported alert-media manifest");
                return;
            }
            var accepted = [];
            for (var i = 0; i < config.banners.length; i++) {
                var entry = config.banners[i];
                // Same as NSP's reader: a null screen list means every screen.
                if (entry && entry.screens === null)
                    delete entry.screens;
                if (!entry || typeof entry.text !== "string" || entry.text.trim() === "" ||
                        entry.text.length > 200 ||
                        (config.version === 1 && entry.screens !== undefined) ||
                        !validScreens(entry) || overlapsExisting(entry, accepted) ||
                        typeof entry.source !== "string" || !validRectangle(entry) ||
                        (entry.gifOnly !== undefined && typeof entry.gifOnly !== "boolean") ||
                        (entry.gifOnly === true && entry.source === "") ||
                        (entry.source !== "" && !/^[uh]\/[^\/\\\x00]+\.(gif|png|jpe?g|bmp)$/i.test(entry.source))) {
                    configurationFailed("Invalid alert-media entry " + i);
                    return;
                }
                accepted.push(entry);
            }
            configurationError = "";
            bannerConfig = config.banners;
            rebuildAlarms();
        };
        request.open("GET", manifestUrl);
        request.send();
    }

    function resolveImage(source) {
        if (source === "")
            return "";
        var base = source.charAt(0) === "u" ? userImageBaseUrl : stockImageBaseUrl;
        return base + encodeURIComponent(source.substring(2));
    }

    // A rule for the active native screen wins over the alarm's all-screens rule.
    function bannerFor(text) {
        var general = null;
        for (var i = 0; i < bannerConfig.length; i++) {
            var entry = bannerConfig[i];
            if (entry.text !== text)
                continue;
            if (entry.screens === undefined) {
                general = entry;
            } else if (currentScreen >= 0 && entry.screens.indexOf(currentScreen) >= 0) {
                return entry;
            }
        }
        return general;
    }

    function rebuildAlarms() {
        alarmModel.clear();
        var offset = 0;
        var rows = [];
        for (var i = 0; i < activeAlarms.length; i++) {
            var alarm = activeAlarms[i];
            var rowHeight = parseInt(alarm.height);
            if (!isFinite(rowHeight) || rowHeight < alertHeight)
                rowHeight = alertHeight;
            var custom = dashVariant === 11 ? bannerFor(alarm.text) : null;
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
        for (var index = 0; index < rows.length; index++) {
            if (!rows[index].positioned)
                rows[index].rowY += startLocation;
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
        activeAlarms = alarms;
        rebuildAlarms();
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
                // GIF-only hides the stock banner only once its media has decoded.
                property bool mediaOnly: model.gifOnly && bannerMedia.status === Image.Ready
                color: mediaOnly ? "transparent" : model.bc
                radius: alarmRadius
                clip: true

                // QtQuick-only decoding: alarm warnings never depend on QtMultimedia.
                AnimatedImage {
                    id: bannerMedia
                    objectName: "alertBannerMedia"
                    anchors.fill: parent
                    source: model.banner
                    fillMode: Image.PreserveAspectFit
                    smooth: true
                    cache: false
                    visible: model.banner !== ""
                    playing: visible && alertPopup.visible
                    property string mediaError: status === Image.Error
                        ? "Alert media could not be decoded" : ""
                    onStatusChanged: {
                        if (status === Image.Error)
                            console.error("HalAlarmPopup: " + model.banner + ": " + mediaError);
                    }
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
    onParentChanged: attachNativeScreens()
    Component.onCompleted: reloadAlertMedia()
}
