import QtQuick 2.9

// Desktop preview of the sample add-ons (not the dash, not NSP):
//   python3 scripts/addons_tests/make_fixtures.py
//   QML_XHR_ALLOW_FILE_READ=1 qmlscene ic7-custom-dash/deploy/addons/preview/Preview.qml
// Values sweep automatically; the stock components are driven the way the app drives
// them (setGaugeProperties, repaintAll, then setGaugeProperties + repaintValue per value).
Rectangle {
    id: root
    width: 860
    height: 480
    color: "black"

    readonly property string folder: "../tests/runtime/preview/resources/qml_components_data/qml/user_components/"
    readonly property string images: "../../../../user_resources/images/"
    property real t: 0
    property var gauges: []

    function make(file, x, y, w, h, props) {
        var component = Qt.createComponent(folder + file);
        if (component.status !== Component.Ready) {
            console.error(component.errorString());
            return;
        }
        var item = component.createObject(root, {x: x, y: y, width: w, height: h});
        props.halIndicatorOnColour = "#ff2020";
        props.halIndicatorOffColour = "#404040";
        props.halWarningColour = "#ff0000";
        props.halNumericValueColour = "#ffffff";
        props.halNumericLabelColour = "#a0a0a0";
        props.halNumericUnitColour = "#a0a0a0";
        props.halValueFontSize = 48;
        props.halChanNameFontSize = 16;
        props.halUnitFontSize = 16;
        item.setGaugeProperties(props);
        try { item.repaintAll(); } catch (error) { /* stock HalBarHorizontal1 */ }
        gauges.push({item: item});
    }

    function push(entry, value) {
        entry.item.setGaugeProperties({halRawValue: value, halValueText: String(Math.round(value))});
        entry.item.repaintValue();
    }

    Component.onCompleted: {
        var rpm = {halChanNameText: "Engine Speed", halUnitText: "RPM", halCompMinValue: 0, halCompMaxValue: 8000,
                   halCompWarnMinValue: -1, halCompWarnMaxValue: 6800, halCompStepSize: 1000};
        make("HalIndicator.qml", 40, 40, 96, 96, Object.assign({halImagePath: images + "ic7_shift_light.png"}, rpm));
        make("HalIndicator.qml", 160, 40, 96, 96, {halImagePath: images + "ic7_check_engine.png",
             halCompWarnMinValue: -1, halCompWarnMaxValue: 1});
        make("HalIndicator.qml", 280, 40, 96, 96, {halImagePath: images + "ic7_gear.png",
             halCompWarnMinValue: -5, halCompWarnMaxValue: 10});
        make("HalNumeric.qml", 420, 40, 380, 110, rpm);
        make("HalBarHorizontal1.qml", 40, 200, 380, 80, {halChanNameText: "Coolant Temp", halCompMinValue: 0,
             halCompMaxValue: 140, halCompWarnMinValue: 0, halCompWarnMaxValue: 105, halCompStepSize: 20});
        make("HalCircularClassic.qml", 520, 180, 260, 260, {halChanNameText: "Oil Pressure", halCompMinValue: 0,
             halCompMaxValue: 800, halCompWarnMinValue: 150, halCompWarnMaxValue: 700, halCompStepSize: 100});
    }

    Timer {
        interval: 100
        repeat: true
        running: true
        onTriggered: {
            root.t += 0.1;
            var phase = (root.t % 10) / 10;
            var rpm = 1000 + 6600 * phase;
            if (gauges.length < 6)
                return;
            push(gauges[0], rpm);
            push(gauges[1], phase > 0.5 ? 2 : 0);
            push(gauges[2], Math.floor(phase * 8) - 1);
            push(gauges[3], rpm);
            push(gauges[4], 60 + 60 * phase);
            push(gauges[5], 100 + 700 * Math.abs(Math.sin(root.t / 3)));
        }
    }

    Text {
        x: 40; y: 440
        color: "#808080"
        font.pixelSize: 14
        text: "EXPERIMENTAL add-on preview (desktop Qt, sample manifests) - not the dash"
    }
}
