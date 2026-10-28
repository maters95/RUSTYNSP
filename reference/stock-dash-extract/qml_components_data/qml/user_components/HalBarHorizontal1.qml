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
	property string halFontFamily
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
	property string halChanNameText
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
		barCanvas.requestPaint();
		peakNeedleCanvas.requestPaint();
	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{
		valueCanvas.requestPaint();
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

	Canvas {
		id: valueCanvas
		width: thisComp.width
		height: thisComp.height
		z: 3

		onPaint: {

			var x_start = 0;

			//Protect against div0
			if ((halCompMaxValue - halCompMinValue) == 0)
				var percent_value = 0;
			else
				var percent_value = (halRawValue - halCompMinValue) / (halCompMaxValue - halCompMinValue);

			// Clamp to 0 - 1
			if (percent_value > 1)
				percent_value = 1;
			else if (percent_value < 0)
				percent_value = 0;

			var calc_width = percent_value * thisComp.width;

			var ctx = getContext("2d");
			ctx.reset();

			//Value Bar
			ctx.beginPath();
			ctx.rect(x_start, 0, calc_width, thisComp.height);
			ctx.fillStyle = (halRawValue >= halCompWarnMinValue && halRawValue <= halCompWarnMaxValue) ? halBarValueColour : halWarningColour;
			ctx.fill();

			if (halUnitFontSize > 0)
			{
				ctx.beginPath();
				ctx.fillStyle = halBarLabelColour;
				ctx.font='%1px "%2"'.arg(halUnitFontSize).arg(halFontFamily)

				var h_align = Math.round(halUnitFontAlign / 10);
				var unit_y = thisComp.height - (thisComp.height / 4) + (halUnitFontSize / 2);

				switch (h_align)
				{
					case 0:
						ctx.textAlign = "center";
						ctx.textBaseline = "middle";
						ctx.fillText(halUnitText, thisComp.width / 2, unit_y);
						break;
					case 1:
						ctx.textAlign = "left";
						ctx.textBaseline = "left";
						ctx.fillText(halUnitText, 10, unit_y);
						break;
					case 2:
						ctx.textAlign = "right";
						ctx.textBaseline = "right";
						ctx.fillText(halUnitText, thisComp.width - 10, unit_y);
						break;
					default:
						ctx.textAlign = "right";
						ctx.textBaseline = "right";
						ctx.fillText(halUnitText, thisComp.width - 10, unit_y);
						break;
				}

			}
		}
	}

	Canvas {
		id: peakNeedleCanvas
		width: thisComp.width
		height: thisComp.height
		z: 5
		onPaint: {
			// Peak Value
			if(halShowPeakNeedle)
			{
				var ctx = getContext("2d");
				ctx.reset();
				var bar_width = 2;
				var y_start = thisComp.height * 0.6;
				var value = (halPeakValue - halCompMinValue);
				var value_fraction = value / (halCompMaxValue - halCompMinValue);
				var valueWidth =  thisComp.width * value_fraction;
				var x_start = (halReverseNeedleDirection == 0) ? (valueWidth - bar_width / 2 ) : (thisComp.width - valueWidth + bar_width / 2);
				ctx.beginPath();
				ctx.strokeStyle = halPeakNeedleColour;
				ctx.lineWidth = bar_width;
				ctx.moveTo(x_start , y_start);
				ctx.lineTo(x_start, height);
				ctx.stroke();
			}
		}
	}
	
	Canvas {
		id: backgroundCanvas
		width: thisComp.width
		height: thisComp.height
		z: 2

		onPaint: {

			var x_start = 0;
			var y_start = 0;

			var ctx = getContext("2d");
			ctx.reset();

			//Background Bar
			ctx.beginPath();
			ctx.rect(x_start, y_start, thisComp.width, thisComp.height);
			ctx.fillStyle = halBarBackgroundColour;
			ctx.fill();
		}
	}

	Canvas {
		id: tickmarkCanvas
		width: thisComp.width
		height: thisComp.height
		z: 4

		onPaint: {

			var x_start = 0;
			var y_start = 0;

			var ctx = getContext("2d");
			ctx.reset();

			//Tick Marks & Tick Labels
			if (halCompStepSize > 0)
			{
				var num_steps = (halCompMaxValue - halCompMinValue) / halCompStepSize;

				if (num_steps > 0)
				{
					var tick_mark_offset = thisComp.width / num_steps;
					var tick_mark_width = 3;
					for (var step = 0; step <= num_steps; step++)
					{

						ctx.beginPath();
						ctx.strokeStyle = halBarTickColour;
						ctx.lineWidth = tick_mark_width;
						ctx.moveTo(step * tick_mark_offset + tick_mark_width, 0);
						ctx.lineTo(step * tick_mark_offset + tick_mark_width, thisComp.height);
						ctx.stroke();

						if (halValueFontSize > 0)
						{
							ctx.beginPath();
							ctx.fillStyle = halBarTickColour;
							ctx.font='%1px "%2"'.arg(halValueFontSize).arg(halFontFamily)
							ctx.textAlign = Common.setting_to_horizontal_align_canvas(halValueFontAlign);
							ctx.textBaseline = Common.setting_to_vertical_align_canvas(halValueFontAlign);

							var text_y_pos = (Common.isDefaultFontFamily()) ? thisComp.height -(halValueFontSize/5) : thisComp.height;
							var text_val = (step * halCompStepSize + halCompMinValue).toFixed(halDecimalPlaces);
							var text_width = ctx.measureText(text_val).width;

							if (step == num_steps)
								ctx.fillText(text_val, thisComp.width - text_width, text_y_pos - tick_mark_width);
							else if (step != 0)
								ctx.fillText(text_val, step * tick_mark_offset - text_width, text_y_pos - tick_mark_width);
						}
					}
				}
			}
		}
	}
}
