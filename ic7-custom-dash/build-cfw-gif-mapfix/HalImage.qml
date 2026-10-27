import QtQuick 2.9

Item {
    id: thisComp
    x: 0
    y: 0
    z: 1
    width: 840
    height: 80

    property real halRawValue: 0
    property string halValueText
    property string halUnitText: "RPM x1000"
    property real halCompMinValue: 0
    property real halCompMaxValue: 10
    property real halCompWarnMinValue
    property real halCompWarnMaxValue
    property bool halCompWarnMinEnable: true
    property bool halCompWarnMaxEnable: true
    property int halImageOpacity
    property string halImagePath
    property real halCompStepSize: 1000
    property int halCompMinorTickCount
    property int halValueFontSize
    property int halValueFontAlign
    property int halChanNameFontSize
    property int halChanNameFontAlign
    property int halUnitFontSize: 16
    property int halUnitFontAlign
    property int halTickFontSize: 50
    property int halTickFontAlign
    property string halChanNameText
    property int halRawUnitType
    property int halDecimalPlaces: 0
    property string halPeakImagePath
    property int halPeakNeedleImageOffset: 0
    property color halWarningColour
    property color halNumericValueColour
    property color halNumericLabelColour
    property color halNumericUnitColour
    property color halBarValueColour: "#C0C0C0"
    property color halBarLabelColour: "#FFFFFF"
    property color halBarTickColour: "#FFFFFF"
    property color halBarMarkingsColour: "#FFFFFF"
    property color halBarBackgroundColour: "#808080"
    property color halPeakNeedleColour
    property color halCircularNeedleColour
    property color halCircularMarkingsColour
    property color halCircularMarkingsWarnColour
    property color halCircularTickColour
    property color halCircularBackgroundColour
    property color halIndicatorOnColour
    property color halIndicatorOffColour
    property bool screenshotMode: false

    readonly property bool animatedSource: /(?:\.gif|\/ic7_animation_[^/]*\.png)(?:[?#].*)?$/i.test(image_obj.source.toString())

    function setGaugeProperties(props) {
        var success = 1;
        for (var prop in props) {
            if (thisComp.hasOwnProperty(prop)) {
                thisComp[prop] = props[prop];
            } else {
                success = 0;
            }
        }
        return success;
    }

    function repaintAll() {
        image_obj.opacity = halImageOpacity / 1000;
        image_obj.source = halImagePath;
    }

    function repaintValue() {
    }

    Image {
        id: image_obj
        objectName: "staticImage"
        sourceSize: Qt.size(parent.width, parent.height)
        smooth: true
        antialiasing: true
        anchors.centerIn: parent
        cache: false
        visible: !thisComp.animatedSource
    }

    AnimatedImage {
        objectName: "animatedImage"
        source: thisComp.animatedSource ? image_obj.source : ""
        width: parent.width
        height: parent.height
        fillMode: Image.PreserveAspectFit
        smooth: true
        antialiasing: true
        anchors.centerIn: parent
        cache: false
        opacity: image_obj.opacity
        visible: thisComp.animatedSource
        playing: visible && thisComp.visible && !thisComp.screenshotMode
    }
}