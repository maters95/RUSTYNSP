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
	width: 175
	height: 85

	// Raw Values
	property real   halRawValue: 0
	property string halValueText: halRawValue
	property string halUnitText: ""

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
	property real   halCompStepSize: 1000
	property int    halCompMinorTickCount
	property int    halValueFontSize: 60
	property int    halValueFontAlign: 0
	property int    halChanNameFontSize: 20
	property int    halChanNameFontAlign: 2
	property int    halUnitFontSize: 20
	property int    halUnitFontAlign: 21
	property int    halTickFontSize: 50
	property int    halTickFontAlign
	property string halChanNameText: "Chan Name"
	property int    halRawUnitType
	property int    halDecimalPlaces: 0
	property int    halReverseNeedleDirection:0
	property int    halNeedleImageOffset: 0
	property string halPeakImagePath
	property int    halPeakNeedleImageOffset: 0

	//Colours
	property color  halWarningColour

	property color  halNumericValueColour: "#00FF00"
	property color  halNumericLabelColour: "#00FF00"
	property color  halNumericUnitColour: "#00FF00"

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

	property bool halShowPeakNeedle: false
	property real halPeakValue: halCompMinValue
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

	//Request a repaint on every canvas
		backgroundCanvas.requestPaint();

		//Value
		value_text.text = halValueText;
		value_text.horizontalAlignment = Common.setting_to_horizontal_align_text(halValueFontAlign);
		value_text.verticalAlignment = Common.setting_to_vertical_align_text(halValueFontAlign);

		//Unit
		unit_text.text = halUnitText;
		unit_text.horizontalAlignment = Common.setting_to_horizontal_align_text(halUnitFontAlign);
		unit_text.verticalAlignment = Common.setting_to_vertical_align_text(halUnitFontAlign);

		//Value
		label_text.text = halChanNameText;
		label_text.horizontalAlignment = Common.setting_to_horizontal_align_text(halChanNameFontAlign);
		label_text.verticalAlignment = Common.setting_to_vertical_align_text(halChanNameFontAlign);
		peakNeedleCanvas.requestPaint();
	}

	property string current_unit_text: ""
	property int current_bar
	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{

		value_text.text = halValueText;

		if (halUnitText != current_unit_text)
		{
			current_unit_text = halUnitText;
			unit_text.text = halUnitText;
		}

		var percent_of_range = (halRawValue - halCompMinValue) / (halCompMaxValue - halCompMinValue);
		var num_bars_float = percent_of_range * num_bars;
		var new_bar = Math.round(num_bars_float);

		if (new_bar != current_bar)
		{
			current_bar = new_bar;
			//Update the bars
			for (var bar = 0; bar < num_bars; bar++)
			{
				var bar_obj = bar_repeater.itemAt(bar);

				if (bar_obj !== null)
				{
					bar_obj.visible = ((num_bars - bar - 1) < current_bar) ? true : false;
				}
			}
		}
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

	property real fixed_bar_width: 34
	property real numeric_offset: 10

	Canvas {
		id: backgroundCanvas
		width: fixed_bar_width //Fixed for now
		height: thisComp.height
		z: 2

		onPaint: {

			var x_start = 0;
			var y_start = 0;

			var ctx = getContext("2d");
			ctx.reset();

			//Background Bar
			ctx.beginPath();
			ctx.rect(x_start, y_start, backgroundCanvas.width, backgroundCanvas.height);
			ctx.fillStyle = halBarBackgroundColour;
			ctx.fill();

		}
	}

	property real bar_current_value: 0
	property int num_bars: 10
	property real bar_spacing: 2
	property real bar_width: fixed_bar_width
	property real bar_height: ( (thisComp.height) / (num_bars) ) - bar_spacing
	property real bar_radius: 2

	Repeater {
		id: bar_repeater
		model: num_bars
		Rectangle {
			x: 0
			y: modelData * (thisComp.height / num_bars)
			width: bar_width
			height: bar_height
			color: (halRawValue >= halCompWarnMinValue && halRawValue <= halCompWarnMaxValue) ? halBarValueColour : halWarningColour;
			visible: false
			radius: bar_radius
			z: 3
		}
	}

	Canvas {
		id: peakNeedleCanvas
		x: 0
		y: 0
		width: bar_width
		height: thisComp.height
		z: 5
		onPaint: {
			// Peak Value
			if (halShowPeakNeedle)
			{
				visible = true;
				var ctx = getContext("2d");
				ctx.reset();
				var x_start = 0;
				var value = (halPeakValue - halCompMinValue);
				var value_fraction = value / (halCompMaxValue - halCompMinValue);
				var valueHeight = thisComp.height * value_fraction;
				var y_start = Math.max(thisComp.height - valueHeight -bar_spacing /2, bar_spacing/2); // To make needle show when peak value >= max
				ctx.beginPath();
				ctx.strokeStyle = halPeakNeedleColour;
				ctx.lineWidth = bar_spacing;
				ctx.moveTo(x_start , y_start);
				ctx.lineTo(x_start + bar_width, y_start);
				ctx.stroke();
			}
			else
				visible = false;
		}
	}

	Rectangle {
		id: numeric_bounds
		color: "#00000000"
		x: bar_width + numeric_offset
		y: 0
		width: (thisComp.width - bar_width - numeric_offset)
		height: thisComp.height

		Text {
			id: value_text
			z: 3
			topPadding: (Common.isDefaultFontFamily()) ? -(halValueFontSize/15) : 0
			font: Qt.font({
				   family: halFontFamily,
				   pixelSize: Math.max(1, halValueFontSize),
				   weight: Font.DemiBold })
			color: (halRawValue >= halCompWarnMinValue && halRawValue <= halCompWarnMaxValue) ? halNumericValueColour : halWarningColour;
			anchors.fill: parent
			fontSizeMode: Text.Fit
		}

		Text {
			id: unit_text
			z: 3
			font: Qt.font({
				   family: halFontFamily,
				   pixelSize: Math.max(1, halUnitFontSize),
				   weight: Font.DemiBold })
			color: halNumericUnitColour
			anchors.fill: parent
		}

		Text {
			id: label_text
			z: 3
			font: Qt.font({
				   family: halFontFamily,
				   pixelSize: Math.max(1, halChanNameFontSize),
				   weight: Font.DemiBold })
			color: halNumericLabelColour
			anchors.fill: parent
		}
	}
}
