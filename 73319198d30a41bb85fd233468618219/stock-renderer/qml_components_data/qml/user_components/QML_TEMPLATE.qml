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
	width: 840
	height: 80

	// Raw Values
	property real   halRawValue: 0
	property string halValueText
	property string halUnitText: "RPM x1000"

	// Settings
	property real   halCompMinValue: 0
	property real   halCompMaxValue: 10
	property real   halCompWarnMinValue
	property real   halCompWarnMaxValue

	property bool   halCompWarnMinEnable: true
	property bool   halCompWarnMaxEnable: true

	property int    halImageOpacity
	property string halImagePath
	property real   halCompStepSize: 1
	property int    halCompMinorTickCount
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
	property string halPeakImagePath
	property int    halPeakNeedleImageOffset: 0

	//Colours
	property color  halWarningColour

	property color  halNumericValueColour
	property color  halNumericLabelColour
	property color  halNumericUnitColour

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

	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{

	}

	// END Common Functions

}
