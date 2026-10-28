import QtQuick 2.9
import QtQuick.Extras 1.4
import QtQuick.Controls.Styles 1.4
import QtGraphicalEffects 1.0
import "common.js" as Common

Item {
    // START Common Properties
    // Common properties should not be changed unless they are changed in ALL qml files and ui_components.cpp
    // x,y,z,width & height are not "hal" properties as they are intrinsic to the top level item in this file
    // and can be referenced by thisComp.x

    id: thisComp
    x : 0
    y: 0
    z: 1
    width: 395
    height: 395

    // Raw Values
    property real   halRawValue: 0
    property string halValueText
    property string halUnitText: "RPM x1000"

    // Settings
    property real   halCompMinValue: 0
    property real   halCompMaxValue: 320
    property real   halCompWarnMinValue: 0
    property real   halCompWarnMaxValue: 200

	property bool   halCompWarnMinEnable: true
	property bool   halCompWarnMaxEnable: true

    property int    halImageOpacity
    property string halImagePath
	property string halFontFamily
    property real   halCompStepSize: 20
    property int    halCompMinorTickCount: 1
    property int    halValueFontSize
    property int    halValueFontAlign
    property int    halChanNameFontSize
    property int    halChanNameFontAlign
    property int    halUnitFontSize: 16
    property int    halUnitFontAlign
    property int    halTickFontSize: 50
    property int    halTickFontAlign
    property string halChanNameText
    property int    halRawUnitType
    property int    halDecimalPlaces: 0
	property int	halReverseNeedleDirection:0
	property int    halNeedleImageOffset: 0
	property string halPeakImagePath
	property int    halPeakNeedleImageOffset: 0


    //Colours
    property color  halWarningColour

    property color  halNumericValueColour
    property color  halNumericLabelColour
    property color  halNumericUnitColour: "#C0C0C0"

    property color  halBarValueColour: "#C0C0C0"
    property color  halBarLabelColour: "#FFFFFF"
    property color  halBarTickColour : "#FFFFFF"
	property color  halBarMarkingsColour : "#FFFFFF"
    property color  halBarBackgroundColour: "#808080"

	property color  halPeakNeedleColour
    property color  halCircularNeedleColour: "#EAECD5"
    property color  halCircularMarkingsColour: "#EAECD5"
    property color  halCircularMarkingsWarnColour: "#FDCF8C"
    property color  halCircularTickColour: "#EAECD5"
    property color  halCircularBackgroundColour: "#F0F0F0"

    property color  halIndicatorOnColour
    property color  halIndicatorOffColour

	property bool halShowPeakNeedle: false
	property real halPeakValue: halCompMinValue

	property real halStartAngle: -60
	property real halEndAngle: 60

	property real minAngle: (halStartAngle != halEndAngle) ? ((halReverseNeedleDirection == 0) ? halStartAngle : halEndAngle ) : -60.0
	property real maxAngle: (halStartAngle != halEndAngle) ? ((halReverseNeedleDirection == 0) ? halEndAngle : halStartAngle ) : 60.0

	property bool screenshotMode: false

    // END Common Properties

	// When the step values are float, the last value calculated is slightly bigger than halCompMaxValue
	// So, the last step value does not get written or a previous value (possibly 0.0) remains
	// To avoid that we ask the system to calculate steps for a max value slightly bigger than halCompMaxValue
	// namely halCompMaxValue + floatCorrection
	readonly property real floatCorrection: 0.00001

	// START Common Event Handlers

	onHalFontFamilyChanged: { repaintAll(); }
	onHalPeakImagePathChanged: {repaintAll(); }

	// END Common Event Handles

    // START Common Functions

    onHalRawValueChanged: {
        repaintValue();
    }

    // Just like common properties, common functions should not be changed unless they are changed everywhere

    function setGaugeProperties(props)
    {
        var success = 1;
        for (var prop in props)
        {
            if (thisComp.hasOwnProperty(prop))
            {
                thisComp[prop] = props[prop];
            }
            else
            {
                success = 0;
            }
        }
        return success;
    }

    // Repaint everything, this will be relatively slow so use it cautiously
    // This should be called from C++ code only after the required properties are set to avoid
    // event handlers triggering repaints on every property change
    function repaintAll()
    {
       var num_maj_ticks = (halCompMaxValue - halCompMinValue) / halCompStepSize;

        if (num_maj_ticks > 20)
        {
            num_maj_ticks = 20;
            halCompStepSize = (halCompMaxValue - halCompMinValue) / num_maj_ticks;
        }

        backgroundCanvas.requestPaint();
		peakNeedleCanvas.requestPaint();
    }

    // Repaint only things that change on every raw value change
    // Keep this functions and its canvas's as light weight as possible
    // Automatically triggered by changes to halRawValue, halValueText and halUnitText
    function repaintValue()
    {
        retro_gauge.value = halRawValue;
        label_text.text = halChanNameText;
    }

	function showPeakNeedle(value)
	{
		halShowPeakNeedle = true;
		halPeakValue = Math.min(halCompMaxValue,Math.max(value,halCompMinValue));
		peakNeedleCanvas.visible = true;
		peakNeedleCanvas.requestPaint();
	}

	function hidePeakNeedle()
	{
		halShowPeakNeedle = false;
		peakNeedleCanvas.visible = false;
	}

    // END Common Functions

	Image{
		id:peakNeedleImage
		source: halPeakImagePath
		visible: false
	}

    Text {
        id: label_text
        y: thisComp.height * 0.31
        z: 3
        text: halChanNameText
        color: halNumericLabelColour
        font.family: halFontFamily
        font.pixelSize: halChanNameFontSize
        horizontalAlignment: Common.setting_to_horizontal_align_text(halChanNameFontAlign)
		verticalAlignment: Common.setting_to_vertical_align_text(halChanNameFontAlign)
        anchors.left: parent.left
        anchors.right: parent.right
    }

	Canvas {
		id: backgroundCanvas
		width: thisComp.width
		height: thisComp.height
		z: 2

		onPaint: {

			var ctx = getContext("2d");
			ctx.reset();

			var xCenter = (thisComp.width * 0.5);
			var yCenter = xCenter;

			var outerRadius = (thisComp.width / 2) - 5;
			var innerRadius = outerRadius - 15;
			var startAngle = (halReverseNeedleDirection == 0) ? minAngle : maxAngle;
			var endAngle = (halReverseNeedleDirection == 0) ? maxAngle : minAngle;

			ctx.beginPath();
			ctx.strokeStyle = halCircularBackgroundColour;
			ctx.lineWidth = outerRadius ;
			ctx.arc(xCenter, yCenter, outerRadius * 0.5,
					degToRad(startAngle + 265),degToRad(endAngle+275));
			ctx.stroke();
		}
	}

	Canvas {
		id: peakNeedleCanvas
		width: thisComp.width
		height: thisComp.height
		z: 3

		onPaint: {

			var ctx = getContext("2d");
			ctx.reset();

			var xCenter = (thisComp.width * 0.5);
			var yCenter = xCenter;
			var outerRadius = thisComp.width / 2;

			// Peak Value
			if(halShowPeakNeedle)
			{
				var peakAngle = valueToAngle(halPeakValue);
				if(halPeakImagePath == "")
				{
					ctx.beginPath();
					ctx.strokeStyle = halPeakNeedleColour;
					ctx.lineWidth = toPixels(0.15, thisComp.width);
					var radius = outerRadius  - (ctx.lineWidth )/ 2;
					ctx.arc(xCenter, yCenter, radius,degToRad(peakAngle + 269.5) , degToRad(peakAngle + 270.5));
					ctx.stroke();
				}
				else
				{
					var peakNeedleAngleInRadians = degToRad(peakAngle);
					ctx.translate(thisComp.width /2 , thisComp.width /2);
					ctx.rotate(peakNeedleAngleInRadians);
					ctx.drawImage(halPeakImagePath, -peakNeedleImage.width/2, -peakNeedleImage.height + toPixels(halPeakNeedleImageOffset/1000, width) );
				}
			}
		}
	}
    CircularGauge {
        id: retro_gauge
        width: thisComp.width
        height: thisComp.height
        anchors.centerIn: parent
        z: 4

        minimumValue: halCompMinValue
        maximumValue: halCompMaxValue + floatCorrection

        style: CircularGaugeStyle {
            tickmarkInset: toPixels(0.088, thisComp.width)
            minorTickmarkInset: toPixels(0.11, thisComp.width)
            labelInset: (thisComp.width * 0.5 * 0.275)
            tickmarkStepSize: halCompStepSize
            labelStepSize: halCompStepSize
            minorTickmarkCount: halCompMinorTickCount
            minimumValueAngle: minAngle
            maximumValueAngle: maxAngle

            property real outerRadius: (thisComp.width / 2)
            property real innerRadius: outerRadius - 10

            tickmark: Rectangle {
                width: innerRadius * 0.02
                height: innerRadius * 0.075
                color: tickmarkColor(styleData.value)
                anchors.bottomMargin : -outerRadius * 0.04
                antialiasing: true
                smooth: true
            }

            minorTickmark: Rectangle {
                y: innerRadius * 0.02
                implicitWidth: innerRadius * 0.02
                implicitHeight: innerRadius * 0.035
                antialiasing: true
                smooth: true
                color: tickmarkColor(styleData.value)
            }

            tickmarkLabel: Text {
                y: 0
                id: tickText
                font.weight: Font.Medium
                font.pixelSize: halValueFontSize
                font.family: halFontFamily
                text: styleData.value.toFixed(halDecimalPlaces)
                color: tickmarkValueColor(styleData.value)
                antialiasing: true
                horizontalAlignment: Text.AlignHCenter
                verticalAlignment: Text.AlignVCenter
                z: 6
            }

            // Needle center "nub"
            foreground: Item {
				Rectangle {
						width: outerRadius * 0.15
						height: width
						radius: width / 2
						color: halCircularNeedleColour
						visible: (halImagePath == "") ? true : false
						anchors.centerIn: parent
		            }}

            property real needleLength: toPixels(0.85, thisComp.width)
            property real needleBaseWidth: toPixels(0.025, thisComp.width)
            property real xCenter: width / 2
            property real yCenter: height / 2

			needle: Component
			{
				id: needleComponent
				Loader {
					Component {
						id: canvasComponent
						Canvas {
							z: 10
							id: needle_canvas
							implicitWidth: needleBaseWidth
							implicitHeight: needleLength

							property real needleLength: toPixels(0.95, thisComp.width)
							property real needleTipWidth: toPixels(0.02, thisComp.width)
							property real needleBaseWidth: toPixels(0.09, thisComp.width)
							property real xCenter: width / 2
							property real yCenter: height / 2
							property color needleColor: halCircularNeedleColour

							onNeedleColorChanged:
							{
								requestPaint();
							}
							onPaint: {
								var ctx = getContext("2d");
								ctx.reset();

								var xCenter = (needleBaseWidth / 2);
								var yCenter = xCenter;

								ctx.beginPath();
								ctx.moveTo(xCenter, height);
								ctx.lineTo(xCenter - needleBaseWidth / 2, height - needleBaseWidth / 2);
								ctx.lineTo(xCenter - needleTipWidth / 2, 0);
								ctx.lineTo(xCenter, yCenter - needleLength);
								ctx.lineTo(xCenter, 0);
								ctx.closePath();
								ctx.fillStyle = halCircularNeedleColour;
								ctx.fill();

								ctx.beginPath();
								ctx.moveTo(xCenter, height);
								ctx.lineTo(width, height - needleBaseWidth / 2);
								ctx.lineTo(xCenter + needleTipWidth / 2, 0);
								ctx.lineTo(xCenter, 0);
								ctx.closePath();
								ctx.fillStyle = Qt.lighter(halCircularNeedleColour,1.5);
								ctx.fill();
							}
						}
					}

					Component{
						id: imageComponent
						Image{
							id:needleImage
							z: 10
							source: halImagePath
							y:toPixels(halNeedleImageOffset/1000.0, thisComp.width)
							height:toPixels((halNeedleImageOffset/1000.0 + 0.95), thisComp.width)
							fillMode:Image.PreserveAspectFit
							clip:true
							cache:false
						}
					}

					sourceComponent: (halImagePath == "") ? canvasComponent : imageComponent
				}
			}

        }

    }

    function toPixels(percent, diameter) {
        if (diameter === 0)
            return 0;
        else
            return percent * (diameter / 2 );
    }

    function degToRad(degrees) {
        return degrees * (Math.PI / 180);
    }

    function valueToAngle(val) {
        var percentage_of_value = (val - halCompMinValue) / (halCompMaxValue - halCompMinValue);
        var angle_range = maxAngle - minAngle;

        return minAngle + (percentage_of_value * angle_range);
    }

    function tickmarkColor(value) {
 		var decimals = (halDecimalPlaces < 3 ) ? 3 : halDecimalPlaces;
		// putting the enable conditions first to make evaluation a bit more efficient
		if( (halCompWarnMinEnable && (Common.roundDp(value, decimals) < Common.roundDp(halCompWarnMinValue, decimals))) ||
			(halCompWarnMaxEnable && (Common.roundDp(value, decimals) > Common.roundDp(halCompWarnMaxValue, decimals))) )
            return halWarningColour;
        else
            return halCircularTickColour;
    }

    function tickmarkValueColor(value) {
		var decimals = (halDecimalPlaces < 3 ) ? 3 : halDecimalPlaces;
		// putting the enable conditions first to make evaluation a bit more efficient
		if( (halCompWarnMinEnable && (Common.roundDp(value, decimals) < Common.roundDp(halCompWarnMinValue, decimals))) ||
			(halCompWarnMaxEnable && (Common.roundDp(value, decimals) > Common.roundDp(halCompWarnMaxValue, decimals))) )
			return halCircularMarkingsWarnColour;
		else
			return halCircularMarkingsColour;
    }
}
