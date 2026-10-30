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
    // On the dash Alarm_Module::draw_alarms sets z to 99 after every reInitAlarmScreen,
    // which still stacks the popup above the five UIScreen containers (z 0).
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
    property url manifestUrl: userImageBaseUrl + "ic7_alerts.json"
    // On the dash, QML lives under dtn/resources; user_resources is under dtn.
    property url userImageBaseUrl: Qt.resolvedUrl(
        Qt.resolvedUrl(".").toString().indexOf("/resources/qml_components_data/") >= 0
        ? "../../../../user_resources/images/" : "../../../user_resources/images/")
    property url stockImageBaseUrl: Qt.resolvedUrl("../../images/")
    property var bannerConfig: []
    property var activeAlarms: []
    property string activeAlarmMessage: ""
    property string configurationError: ""
    property int requestGeneration: 0
    property bool mediaRequestPending: false
    property bool mediaReloadQueued: false
    property string loadedManifest: ""
    // draw_alarms calls reInitAlarmScreen on every UIMain::update tick (update reschedules
    // itself with QTimer::singleShot), so native updates re-read the manifest at most this often.
    property int manifestRefreshMs: 2000
    property real lastManifestRequest: 0
    property int manifestRequestCount: 0
    property int activeScreenNumber: parent && typeof parent.activeScreenNumber === "number"
        ? parent.activeScreenNumber : 0
    property bool screenWarningReported: false
    onActiveScreenNumberChanged: rebuildAlarms()
    // Fallback when no screen marker reports: v2.36 UIMain always creates five unnamed
    // UIScreen containers in screen order, then Alarm_Module parents this popup to the
    // same root, and screen changes are QQuickItem::setVisible calls on those containers
    // (analysis/screen-switching.s). The visible one of the five preceding siblings is
    // the active screen. Named items declared in main.qml are never taken as screens.
    readonly property int nativeScreenCount: 5
    property var nativeScreenItems: []
    property int nativeScreenNumber: 0
    onNativeScreenNumberChanged: {
        if (activeScreenNumber < 1)
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
            if (siblings[s].objectName !== "")
                return [];
            screens.push(siblings[s]);
        }
        return screens;
    }

    function attachNativeScreens() {
        for (var i = 0; i < nativeScreenItems.length; i++)
            nativeScreenItems[i].visibleChanged.disconnect(updateNativeScreen);
        nativeScreenItems = findNativeScreens();
        for (i = 0; i < nativeScreenItems.length; i++)
            nativeScreenItems[i].visibleChanged.connect(updateNativeScreen);
        updateNativeScreen();
    }

    function updateNativeScreen() {
        var shown = 0;
        for (var i = 0; i < nativeScreenItems.length; i++) {
            if (!nativeScreenItems[i].visible)
                continue;
            if (shown > 0) {
                shown = 0;
                break;
            }
            shown = i + 1;
        }
        nativeScreenNumber = shown;
    }

    onParentChanged: attachNativeScreens()

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

    function validScreens(screens) {
        if (screens === undefined || screens === null)
            return true;
        if (!Array.isArray(screens) || screens.length < 1 || screens.length > 5)
            return false;
        for (var index = 0; index < screens.length; index++) {
            var screen = screens[index];
            if (typeof screen !== "number" || Math.floor(screen) !== screen ||
                    screen < 1 || screen > 5 || screens.indexOf(screen) !== index)
                return false;
        }
        return true;
    }

    function reloadAlertMedia() {
        if (mediaRequestPending) {
            mediaReloadQueued = true;
            return;
        }
        mediaRequestPending = true;
        lastManifestRequest = Date.now();
        manifestRequestCount++;
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
                        !validScreens(entry.screens) ||
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
                // The app copies the map's fixed-width alarm text verbatim; NSP saves the
                // banner's text trimmed, so padding must not defeat the (case-exact) match.
                var key = alarm.text.trim();
                for (var j = 0; j < bannerConfig.length; j++) {
                    if (bannerConfig[j].text === key) {
                        custom = bannerConfig[j];
                        break;
                    }
                }
            }
            if (custom && custom.screens !== undefined && custom.screens !== null) {
                var screen = activeScreenNumber >= 1 ? activeScreenNumber : nativeScreenNumber;
                if (screen >= 1 && screen <= 5) {
                    if (custom.screens.indexOf(screen) < 0)
                        continue;
                } else if (!screenWarningReported) {
                    console.warn("HalAlarmPopup: active screen unavailable; showing restricted alarms for safety");
                    screenWarningReported = true;
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
        var elapsed = Date.now() - lastManifestRequest;
        if (elapsed < 0 || elapsed >= manifestRefreshMs)
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
                // Stock bottom-stacked banners always draw above positioned custom rows, and
                // text-only custom rows above custom media, so a large custom animation (e.g.
                // a full-screen GIF-only banner) can never cover another active warning,
                // whatever order the alarms arrive in.
                z: !model.positioned ? 2 : (model.banner === "" ? 1 : 0)
                // GIF-only hides the stock banner only once its media has decoded, so a
                // banner is never blank while loading or after a decode failure.
                property bool mediaOnly: model.gifOnly && bannerMedia.status === Image.Ready
                color: mediaOnly ? "transparent" : model.bc
                radius: alarmRadius
                clip: true

                // QtQuick-only decoding: alarm warnings never depend on QtMultimedia, so a
                // multimedia load failure cannot take the whole popup down.
                Item {
                    id: bannerMedia
                    objectName: "alertBannerMedia"
                    anchors.fill: parent
                    visible: model.banner !== ""
                    readonly property alias status: bannerAnimation.status
                    readonly property string mediaError: bannerAnimation.status === Image.Error
                        ? "Alert media could not be decoded" : ""
                    AnimatedImage {
                        id: bannerAnimation
                        objectName: "animatedImage"
                        anchors.fill: parent
                        source: model.banner
                        fillMode: Image.PreserveAspectFit
                        smooth: true
                        cache: false
                        playing: bannerMedia.visible && alertPopup.visible
                        onStatusChanged: {
                            if (status === Image.Error)
                                console.error("HalAlarmPopup: " + model.banner + ": " + bannerMedia.mediaError);
                        }
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
    Component.onCompleted: reloadAlertMedia()
}
