import QtQuick 2.9
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
	width: 40
	height: 40

	// Raw Values
	property real   halRawValue: 0
	property string halValueText
	property string halUnitText: "RPM x1000"

	// Settings
	property real   halCompMinValue: 0
	property real   halCompMaxValue: 10
	property real   halCompWarnMinValue
	property real   halCompWarnMaxValue

	property int    halCompOpacity
	property string halImagePath
	property real   halCompStepSize: 1000
	property int    halCompMinorTickCount
	property int    halValueFontSize
	property int    halValueFontAlign
	property int    halChanNameFontSize
	property int    halChanNameFontAlign
	property int    halUnitFontSize: 16
	property int    halUnitFontAlign
	property int    halTickFontSize: 50
	property int    halTickFontAlign
	property string halChanNameText: "Battery"
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

	property color  halCircularNeedleColour
	property color  halCircularMarkingsColour
	property color  halCircularMarkingsWarnColour
	property color  halCircularTickColour
	property color  halCircularBackgroundColour

	property color  halIndicatorOnColour: "#FF0000"
	property color  halIndicatorOffColour: "#00FF00"

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
		imageValue.source = halImagePath;
		imageValue.opacity = halCompOpacity / 1000;

		// These settings get sent as doubles, which mean a warning value of "1" might appear as "1.0000000000000002"
		// We clamp all min/max settings to 3 dp.
		var min = halCompMinValue;
		halCompMinValue = Common.roundDp(min, 3);

		var max = halCompMaxValue;
		halCompMaxValue = Common.roundDp(max, 3);

		var warn_min = halCompWarnMinValue;
		halCompWarnMinValue = Common.roundDp(warn_min, 3);

		var warn_max = halCompWarnMaxValue;
		halCompWarnMaxValue = Common.roundDp(warn_max, 3);
	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{
		var state = 0;
		if (halRawValue >= halCompWarnMaxValue || halRawValue < halCompWarnMinValue)
			state = 1;
		else
			state = 0;

		glow.visible = (state > 0);
		overlay.color = (state > 0) ? halIndicatorOnColour : halIndicatorOffColour;
	}

	// END Common Functions

	Image {
		id: imageValue
		width: thisComp.width
		height: thisComp.height
		smooth: true
		antialiasing: true
		visible: false
	}

	Glow {
		id: glow
		opacity: 0.5
		anchors.fill: imageValue
		radius: 15
		samples: 20
		spread: 0.4
		color: halIndicatorOnColour
		source: imageValue
		visible: false
		transparentBorder: true
	}

	Rectangle {
		id: overlay
		width: thisComp.width
		height: thisComp.height
		color: halIndicatorOffColour
		visible: false
	}

	OpacityMask {
		anchors.fill: overlay
		source: overlay
		maskSource: imageValue
		invert: false
	}
}
