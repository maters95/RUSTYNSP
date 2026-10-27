import QtQuick 2.9
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

	property bool   halCompWarnMinEnable: true
	property bool   halCompWarnMaxEnable: true

	property int    halImageOpacity
	property string halImagePath
	property string halFontFamily
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
	property int    halReverseNeedleDirection:0
	property int    halNeedleImageOffset: 0
	property string halPeakImagePath
	property int    halPeakNeedleImageOffset: 0

	//Colours
	property color  halWarningColour

	property color  halNumericValueColour
	property color  halNumericLabelColour
	property color  halNumericUnitColour: "#FF0000"

	property color  halBarValueColour: "#C0C0C0"
	property color  halBarLabelColour: "#FFFFFF"
	property color  halBarTickColour : "#FFFFFF"
	property color  halBarMarkingsColour : "#FFFFFF"
	property color  halBarBackgroundColour: "#808080"

	property color  halPeakNeedleColour
	property color  halCircularNeedleColour
	property color  halCircularMarkingsColour
	property color  halCircularMarkingsWarnColour
	property color  halCircularTickColour
	property color  halCircularBackgroundColour

	property color  halIndicatorOnColour
	property color  halIndicatorOffColour

	property bool screenshotMode: false

	// END Common Properties
	// START Common Event Handlers

	onHalFontFamilyChanged: { repaintAll(); }

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
		//Value
		label_text.text = halChanNameText;
		label_text.horizontalAlignment = Common.setting_to_horizontal_align_text(halChanNameFontAlign);
		label_text.verticalAlignment = Common.setting_to_vertical_align_text(halChanNameFontAlign);

	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{
	}

	// END Common Functions

	Rectangle {
		id: numeric_bounds
		color: "#00000000"
		border.color: "#00000000"
		x: 0
		y: 0
		width: thisComp.width
		height: thisComp.height

		Text {
			id: label_text
			z: 3
			horizontalAlignment: Text.AlignRight
			verticalAlignment: Text.AlignTop
			font: Qt.font({
				   family: halFontFamily,
				   pixelSize: Math.max(1, halChanNameFontSize),
				   weight: Font.DemiBold })
			color: halNumericLabelColour
			anchors.fill: parent
			wrapMode: Text.Wrap
			clip: true
		}
	}
}
