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
	height: 50

	// Raw Values
	property real   halRawValue: 4
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
	property int    halTickFontSize: 20
	property int    halTickFontAlign
	property string halChanNameText
	property int    halRawUnitType
	property int    halDecimalPlaces: 0

	//Colours
	property color  halWarningColour

	property color  halNumericValueColour
	property color  halNumericLabelColour
	property color  halNumericUnitColour

	property color  halBarValueColour: "#FFDD14"
	property color  halBarLabelColour: "#FFFFFF"
	property color  halBarTickColour : "#FFFFFF"
	property color  halBarBackgroundColour: "#7F6E0A"

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
		//Request a repaint on every canvas
		backgroundCanvas.requestPaint();
		barCanvas.requestPaint();
	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{
		barCanvas.requestPaint();
	}

	// END Common Functions

	FontLoader {
		id: dinFont
		source: "../../styles/DINCondensed-Bold.ttf"
	}

	Canvas {
		id: barCanvas
		width: thisComp.width
		height: thisComp.height
		z: 3

		onPaint: {

			var x_start = 0;
			var y_start = thisComp.y / 2;

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
			ctx.rect(x_start, y_start, calc_width, thisComp.height - y_start);
			ctx.fillStyle = (halRawValue >= halCompWarnMinValue && halRawValue <= halCompWarnMaxValue) ? halBarValueColour : halWarningColour;
			ctx.fill();

			//Unit text (halUnitText)
			if (halUnitFontSize > 0)
			{
				ctx.beginPath();
				ctx.fillStyle = halBarLabelColour;
				ctx.font='%1px "%2"'.arg(halUnitFontSize).arg(dinFont.name)

				var h_align = Math.round(halUnitFontAlign / 10);
				var unit_y = thisComp.y - (thisComp.y / 4);

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

	//Background Rectangle,tick bars, tick labels
	Canvas {
		id: backgroundCanvas
		width: thisComp.width
		height: thisComp.height
		z: 2

		onPaint: {

			var x_start = 0;
			var y_start = thisComp.y / 2;

			var ctx = getContext("2d");
			ctx.reset();

			//Background Bar
			ctx.beginPath();
			ctx.rect(x_start, y_start, thisComp.width, thisComp.height - y_start);
			ctx.fillStyle = halBarBackgroundColour;
			ctx.fill();

			//Tick Bars & Tick Labels
			var tick_bar_y = thisComp.y / 3;
			var tick_bar_height = thisComp.y / 12;

			if (halCompStepSize > 0)
			{
				var num_steps = (halCompMaxValue - halCompMinValue) / halCompStepSize;

				if (num_steps > 0)
				{
					var tick_bar_width = thisComp.width / num_steps;
					var tick_bar_offset = thisComp.width / 100;

					for (var step = 0; step <= num_steps; step++)
					{
						ctx.beginPath();
						ctx.rect(step * tick_bar_width + tick_bar_offset, tick_bar_y, tick_bar_width - tick_bar_offset , tick_bar_height);
						ctx.fillStyle = halBarTickColour;
						ctx.fill();

						if (halTickFontSize > 0)
						{
							ctx.beginPath();
							ctx.fillStyle = halBarTickColour;
							ctx.font='italic %1px "%2"'.arg(halTickFontSize).arg(dinFont.name)
							ctx.textAlign = "center";
							ctx.textBaseline = "top";

							var text_val = (step * halCompStepSize + halCompMinValue).toFixed(halDecimalPlaces);
							var text_width = ctx.measureText(text_val).width;
							var text_y_pos = 0;

							if (step == 0)
								ctx.fillText(text_val, step * tick_bar_width + tick_bar_offset, text_y_pos);
							else if (step == num_steps)
								ctx.fillText(text_val, thisComp.width - text_width, text_y_pos);
							else
								ctx.fillText(text_val, step * tick_bar_width + tick_bar_offset - text_width, text_y_pos);

						}
					}
				}
			}
		}
	}
}
