import QtQuick 2.9
import QtQuick.Extras 1.4
import QtQuick.Controls.Styles 1.4
import QtGraphicalEffects 1.0

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

	property int    halCompOpacity
	property string halImagePath
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

	//Colours
	property color  halWarningColour

	property color  halNumericValueColour
	property color  halNumericLabelColour
	property color  halNumericUnitColour

	property color  halBarValueColour: "#C0C0C0"
	property color  halBarLabelColour: "#FFFFFF"
	property color  halBarTickColour : "#FFFFFF"
	property color  halBarBackgroundColour: "#808080"

	property color  halCircularNeedleColour: "#EAECD5"
	property color  halCircularMarkingsColour: "#EAECD5"
	property color  halCircularMarkingsWarnColour: "#FDCF8C"
	property color  halCircularTickColour: "#EAECD5"
	property color  halCircularBackgroundColour: "#00000000"

	property color  halIndicatorOnColour
	property color  halIndicatorOffColour

	// END Common Properties

	// START Common Functions
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
		
	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{
		retro_gauge.value = halRawValue;
		unit_text.text = halUnitText;
	}

	// END Common Functions

	FontLoader {
		id: caviar
		//source: "qrc:/CaviarDreams-Bold.ttf" //Just for testing
		source: "../../styles/CaviarDreams-Bold.ttf"
	}

	property real minAngle: -135
	property real maxAngle: 135

	Canvas {
		id: backgroundCanvas
		width: thisComp.width
		height: thisComp.height
		z: 1

		onPaint: {

			var ctx = getContext("2d");
			ctx.reset();

			var xCenter = (thisComp.width * 0.5);
			var yCenter = xCenter;

			var nubRadius = (thisComp.width / 2) * 0.1;

			//Center needle "nub"
			ctx.beginPath();
			ctx.strokeStyle = "#111111";
			ctx.arc(xCenter, yCenter, nubRadius,
					2 * Math.PI , 0);
			ctx.fill();

		}
	}

	Text {
		id: unit_text
		y: thisComp.height * 0.62
		text: halUnitText
		color: halNumericUnitColour
		font.family: caviar.name
		font.pixelSize: halUnitFontSize
		horizontalAlignment: Text.AlignHCenter
		anchors.left: parent.left
		anchors.right: parent.right
	}

	CircularGauge {
		id: retro_gauge
		width: thisComp.width
		height: thisComp.height
		anchors.centerIn: parent
		z: 2

		minimumValue: halCompMinValue
		maximumValue: halCompMaxValue

		style: CircularGaugeStyle {
			tickmarkInset: toPixels(0.01, thisComp.width)
			minorTickmarkInset: toPixels(0.01, thisComp.width)
			labelInset: (thisComp.width * 0.5 * 0.25)
			tickmarkStepSize: halCompStepSize
			labelStepSize: halCompStepSize
			minorTickmarkCount: halCompMinorTickCount
			minimumValueAngle: minAngle
			maximumValueAngle: maxAngle

			tickmark: Rectangle {
				width: (thisComp.width / 2) * 0.025
				height: (thisComp.height / 2) * 0.12
				color: tickmarkColor(styleData.value)
				anchors.bottomMargin : -height
				antialiasing: true
				smooth: true
			}

			minorTickmark: Rectangle {
				implicitWidth: (thisComp.width / 2) * 0.015
				implicitHeight: (thisComp.height / 2) * 0.1
				anchors.bottomMargin : -height
				antialiasing: true
				smooth: true
				color: tickmarkColor(styleData.value)
			}

			tickmarkLabel: Text {
				y: 0
				id: tickText
				font.weight: Font.Medium
				//font.pixelSize: tickmarkLabelFontSize(styleData.index, Math.max(20, halValueFontSize))
				font.pixelSize: Math.max(20, halValueFontSize)
				font.family: caviar.name
				text: styleData.value.toFixed(halDecimalPlaces)
				color: halCircularMarkingsColour
				antialiasing: true
				horizontalAlignment: Text.AlignHCenter
				verticalAlignment: Text.AlignVCenter
				z: 6
			}

			// Needle center "nub"
			foreground: Item { Rectangle {
				color: "#00000000"
			}}

            property real needleLength: toPixels(1.025, thisComp.width)
            property real needleBaseWidth: toPixels(0.025, thisComp.width)
            property real xCenter: width / 2
            property real yCenter: height / 2

            needle: Rectangle {
                y: 30
                implicitWidth: needleBaseWidth
                implicitHeight: needleLength
                antialiasing: true
				smooth: true
                color: halCircularNeedleColour
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
		var str = "";
		if((value < halCompWarnMinValue ) ||
				(value > halCompWarnMaxValue ) )
		{
			str = halCircularMarkingsWarnColour;
		}
		else
		{
			str = halCircularMarkingsColour;
		}
		return str;
	}

	// Keep for future, too hard for now
	// function tickmarkLabelFontSize(index, fontSize)
	// {
	//     if (index % 2)
	//         return fontSize * 0.65;
	//     else
	//         return fontSize;
	// }

}
