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
	width: 100
	height: 90

	// Raw Values
	property real   halRawValue: 0
	property string halValueText
	property string halUnitText

	// Settings
	property real   halCompMinValue: 0
	property real   halCompMaxValue: 10
	property real   halCompWarnMinValue
	property real   halCompWarnMaxValue

	property int    halCompOpacity
	property string halImagePath
	property real   halCompStepSize: 1
	property int    halCompMinorTickCount
	property int    halValueFontSize: 60
	property int    halValueFontAlign: 20
	property int    halChanNameFontSize: 20
	property int    halChanNameFontAlign: 21
	property int    halUnitFontSize: 20
	property int    halUnitFontAlign: 22
	property int    halTickFontSize
	property int    halTickFontAlign
	property string halChanNameText: "Engine RPM"
	property int    halRawUnitType
	property int    halDecimalPlaces: 0

	//Colours
	property color  halWarningColour

	property color  halNumericValueColour
	property color  halNumericLabelColour
	property color  halNumericUnitColour: "#FF0000"

	property color  halBarValueColour: "#C0C0C0"
	property color  halBarLabelColour: "#FFFFFF"
	property color  halBarTickColour : "#FFFFFF"
	property color  halBarBackgroundColour: "#808080"

	property color  halCircularNeedleColour
	property color  halCircularMarkingsColour
	property color  halCircularMarkingsWarnColour
	property color  halCircularTickColour
	property color  halCircularBackgroundColour

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
		//Value
		value_text.text = halValueText;
		value_text.horizontalAlignment = setting_to_horizontal_align(halValueFontAlign);
		value_text.verticalAlignment = setting_to_vertical_align(halValueFontAlign);

		//Unit
		unit_text.text = halUnitText;
		unit_text.horizontalAlignment = setting_to_horizontal_align(halUnitFontAlign);
		unit_text.verticalAlignment = setting_to_vertical_align(halUnitFontAlign);

		//Value
		label_text.text = halChanNameText;
		label_text.horizontalAlignment = setting_to_horizontal_align(halChanNameFontAlign);
		label_text.verticalAlignment = setting_to_vertical_align(halChanNameFontAlign);

	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{
		value_text.text = halValueText;
		unit_text.text = halUnitText;
	}

	// END Common Functions

	FontLoader {
		id: dinFont
		source: "../../styles/DINCondensed-Bold.ttf"
	}

	function setting_to_horizontal_align(inval)
	{
		var align = Text.AlignHCenter;
		var val = Math.round(inval /10);
		switch(val)
		{
			case 0:
				align = Text.AlignHCenter;
				break;
			case 1:
				align = Text.AlignLeft;
				break;
			case 2:
				align = Text.AlignRight;
				break;
			case 3:
				align = Text.AlignJustify;
				break;
		}
		return align;
	}

	function setting_to_vertical_align(inval)
	{
		var align = Text.AlignVCenter;
		var val = inval % 10;
		switch(val)
		{
			case 0:
				align = Text.AlignVCenter;
				break;
			case 1:
				align = Text.AlignTop;
				break;
			case 2:
				align = Text.AlignBottom;
				break;
		}
		return align;
	}

	Rectangle {
		id: numeric_bounds
		color: "#00000000"
		border.color: "#00000000"
		x: 0
		y: 0
		width: thisComp.width
		height: thisComp.height

		Text {
			id: value_text
			z: 3
			horizontalAlignment: Text.AlignRight
			verticalAlignment: Text.AlignVCenter
			font: Qt.font({
				   family: dinFont.name,
				   pixelSize: Math.max(1, halValueFontSize),
				   weight: Font.DemiBold })
			color: (halRawValue >= halCompWarnMinValue && halRawValue <= halCompWarnMaxValue) ? halNumericValueColour : halWarningColour;
			anchors.fill: parent
			fontSizeMode: Text.Fit
		}

		Text {
			id: unit_text
			z: 3
			horizontalAlignment: Text.AlignRight
			verticalAlignment: Text.AlignBottom
			font: Qt.font({
				   family: dinFont.name,
				   pixelSize: Math.max(1, halUnitFontSize),
				   weight: Font.DemiBold })
			color: halNumericUnitColour
			anchors.fill: parent
		}

		Text {
			id: label_text
			z: 3
			horizontalAlignment: Text.AlignRight
			verticalAlignment: Text.AlignTop
			font: Qt.font({
				   family: dinFont.name,
				   pixelSize: Math.max(1, halChanNameFontSize),
				   weight: Font.DemiBold })
			color: halNumericLabelColour
			anchors.fill: parent
		}
	}
}
