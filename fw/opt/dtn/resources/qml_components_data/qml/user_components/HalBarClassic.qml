import QtQuick 2.9

Item {
	// START Common Properties
	// Common properties should not be changed unless they are changed in ALL qml files and ui_components.cpp
	// x,y,z,width & height are not "hal" properties as they are intrinsic to the top level item in this file
	// and can be referenced by thisComp.x

	id: thisComp
	x : 0
	y: 0
	z: 1
	width: 135
	height: 70

	// Raw Values
	property real   halRawValue: 5
	property string halValueText
	property string halUnitText: "RPM"

	// Settings
	property real   halCompMinValue: 0
	property real   halCompMaxValue: 10
	property real   halCompWarnMinValue
	property real   halCompWarnMaxValue

	property int    halCompOpacity
	property string halImagePath
	property real   halCompStepSize: 1000
	property int    halCompMinorTickCount
	property int    halValueFontSize: 20
	property int    halValueFontAlign
	property int    halChanNameFontSize: 12
	property int    halChanNameFontAlign
	property int    halUnitFontSize: 10
	property int    halUnitFontAlign
	property int    halTickFontSize: 50
	property int    halTickFontAlign
	property string halChanNameText
	property int    halRawUnitType
	property int    halDecimalPlaces: 0

	//Colours
	property color  halWarningColour

	property color  halNumericValueColour: "#FFFFFF"
	property color  halNumericLabelColour: "#FFFFFF"
	property color  halNumericUnitColour: "#FFFFFF"

	property color  halBarValueColour: "#00FF00"
	property color  halBarLabelColour: "#000000"
	property color  halBarTickColour : "#FFFFFF"
	property color  halBarBackgroundColour: "#FFFFFF"

	property color  halCircularNeedleColour
	property color  halCircularMarkingsColour
	property color  halCircularMarkingsWarnColour
	property color  halCircularTickColour
	property color  halCircularBackgroundColour

	property color  halIndicatorOnColour
	property color  halIndicatorOffColour

	// END Common Properties

	// START Common Event Handlers

	onHalRawValueChanged: { repaintValue(); }
	onHalValueTextChanged: { repaintValue(); }
	onHalUnitTextChanged: { repaintValue(); }

	// END Common Event Handles

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
		backgroundImage.source = halImagePath;
		backgroundColour.color = halBarBackgroundColour;
		text_label.text = halChanNameText;
		valueCanvas.requestPaint();
	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{
		valueCanvas.requestPaint();
		text_value.text = halValueText;
		text_unit.text = halUnitText;
	}

	// END Common Functions

	FontLoader {
		id: dinFont
		//source: "qrc:/DINCondensed-Bold.ttf" //Just for testing
		source: "../../styles/DINCondensed-Bold.ttf"
	}

	Canvas {
		id: valueCanvas
		width: thisComp.width
		height: thisComp.height
		z: 1

		onPaint: {

			var bar_width = thisComp.width * 0.05;
			var bar_height = thisComp.height * 0.42;
			var bar_color = halBarValueColour;
			var bar_y = thisComp.height - bar_height;

			var bar_x_min_val = thisComp.width * 0.05;
			var bar_x_max_val = thisComp.width * 0.9;

			if (halRawValue > halCompWarnMaxValue || halRawValue < halCompWarnMinValue)
				bar_color = halWarningColour;
			else
				bar_color = halBarValueColour;

			//Protect against div0
			if ((halCompMaxValue - halCompMinValue) == 0)
				var value_percent = 0;
			else
				var value_percent = (halRawValue - halCompMinValue) / (halCompMaxValue - halCompMinValue);

			// Clamp to 0 - 1
			if (value_percent > 1)
				value_percent = 1;
			else if (value_percent < 0)
				value_percent = 0;

			var bar_x = bar_x_min_val + (value_percent * (bar_x_max_val - bar_x_min_val));

			var ctx = getContext("2d");
			ctx.reset();

			//Background Bar
			ctx.beginPath();
			ctx.rect(bar_x, bar_y, bar_width, bar_height);
			ctx.fillStyle = bar_color;
			ctx.fill();

		}
	}

	Image {
		id: backgroundImage
		z:2
		smooth: true
		width: thisComp.width
		height: thisComp.height
		source: halImagePath
	}

	Rectangle {
		id: backgroundColour
		x: thisComp.width * 0.05
		y: thisComp.height * 0.31
		width: thisComp.width * 0.9
		height: thisComp.height * 0.66
		color: halBarBackgroundColour
		z: 0

	}

	Text {
		id: text_label
		y: thisComp.height * 0.3
		z: 3
		anchors.centerIn: thisComp
		font.weight: Font.Medium
		font.family: dinFont.name
		font.pixelSize: Math.max(1, halChanNameFontSize)
		horizontalAlignment: Text.AlignHCenter
		color: halNumericLabelColour
		text: "Fuel Pressure"
	}

	//This makes justifying value and units easier by putting them inside a "container" rectangle
	Rectangle {
		id: value_unit_bounds
		x: thisComp.width * 0.33
		y: thisComp.height * 0.05
		z: 3
		width: thisComp.width * 0.33
		height: thisComp.height * 0.31
		color: "transparent"

		Text {
			id: text_value
			z: 3
			anchors.fill: parent
			font.weight: Font.Medium
			font.family: dinFont.name
			font.pixelSize: Math.max(1, halValueFontSize)
			horizontalAlignment: Text.AlignLeft
			verticalAlignment: Text.AlignVCenter
			color: halNumericValueColour
			text: "1000"
		}

		Text {
			id: text_unit
			z: 3
			anchors.fill: parent
			font.weight: Font.Medium
			font.family: dinFont.name
			font.pixelSize: Math.max(1, halUnitFontSize)
			horizontalAlignment: Text.AlignRight
			verticalAlignment: Text.AlignTop
			color: halNumericUnitColour
			text: "RPM"
		}
	}


}
