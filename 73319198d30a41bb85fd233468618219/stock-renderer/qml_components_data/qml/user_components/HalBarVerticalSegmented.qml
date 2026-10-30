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
	clip: true

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
		tickmarkCanvas.requestPaint();
		current_bar = -1; // Redraw all the value bars
		peakNeedleCanvas.requestPaint();
		repaintValue();
	}

	property int current_bar
	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText


	function repaintValue()
	{

		var max_value = (halCompStepSize == 0) ? halCompMaxValue : new_max_value;
		var value = ((halReverseNeedleDirection == 1)) ? (halRawValue - halCompMinValue) : (max_value - halRawValue);
		var value_fraction = value / (max_value - halCompMinValue);
		var visibility = (halReverseNeedleDirection == 1);
		Common.calcVisibleSegments(value_fraction,visibility)
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

	function getBarStartX(alignment,text_width)
	{
		var x = 0;
		switch(alignment)
		{
			case 0: // Centre
			case 2: // Right
				x = 0;
				break;
			case 1: // Left
				x = text_width;
				break;
		}
		return x;
	}

	function getTextStartX(alignment,text_width,bar_start_x,bar_width)
	{
		var x = 0;
		switch(alignment)
		{
			case 0: // Centre
				x = bar_start_x + (bar_width - text_width)/2;
				break;
			case 2: // Right
				x = thisComp.width - text_width -bar_spacing;
				break;
			case 1: // Left
				x =  bar_start_x - text_width -bar_spacing;
				break;
		}
		return x;
	}

	function getBarWidth(alignment,text_width)
	{
		var w = 0;
		switch(alignment)
		{
			case 0: // Centre
				w = thisComp.width;
				break;
			case 2: // Right
			case 1: // Left
				w = thisComp.width -text_width;
				break;
		}
		return Math.max(w,3);
	}

	property real compHeight: thisComp.height - ((halValueFontAlign == 0) ? 0:  halValueFontSize)
	property real num_major_bars: (halCompStepSize == 0) ? 10 :  ((halCompMaxValue - halCompMinValue) / halCompStepSize)
	property int num_bars: Math.ceil(num_major_bars * (halCompMinorTickCount +1))
	property real new_max_value: ((halCompStepSize / (halCompMinorTickCount +1)) * num_bars) + halCompMinValue
	property real bar_spacing: (( (compHeight) / (num_bars) ) < 4) ? 1 : 2
	property int computed_text_width: halValueFontSize * 1.5 + bar_spacing // init Value
	property real bar_height: (((compHeight) / (num_bars)) < bar_spacing) ? 1 : (((compHeight) / (num_bars)) - bar_spacing)
	property real bar_width: getBarWidth(halValueFontAlign)
	property real bar_radius: 2

	Repeater {
		id: bar_repeater
		model: num_bars
		Rectangle {
			x: getBarStartX(halValueFontAlign,computed_text_width)
			y: (bar_height + bar_spacing) * (num_bars - modelData -1 ) + ((halValueFontAlign == 0) ? 0 : halValueFontSize/2)
			width: bar_width
			height: bar_height
			color: (halRawValue >= halCompWarnMinValue && halRawValue <= halCompWarnMaxValue) ? halBarValueColour : halWarningColour;
			visible: false
			radius: bar_radius
			z: 3
		}
	}

	function compute_max_text_width(ctx)
	{
			computed_text_width = halValueFontSize * 1.5 + bar_spacing;
			var maxvalue_text_width = ctx.measureText(halCompMaxValue.toFixed(halDecimalPlaces)).width;
			var minvalue_text_width = ctx.measureText(halCompMinValue.toFixed(halDecimalPlaces)).width;
			var new_text_width = Math.max(minvalue_text_width,maxvalue_text_width, computed_text_width);
			computed_text_width = new_text_width;
	}
	  //Background Rectangle,tick marks, tick labels
	Canvas {
		id: backgroundCanvas
		width: thisComp.width
		height: compHeight + halValueFontSize / 2
		z: 2

		onPaint: {
			var ctx = getContext("2d");
			ctx.reset();
 			ctx.font='%1px "%2"'.arg(halValueFontSize).arg(halFontFamily);
			ctx.textAlign = "left";
			compute_max_text_width(ctx);
			var x_start = getBarStartX(halValueFontAlign,computed_text_width);
			var y_start = (halValueFontAlign == 0) ? 0 : halValueFontSize / 2;
			bar_width = getBarWidth(halValueFontAlign,computed_text_width);

			//Background Bar
			ctx.beginPath();
			ctx.rect(x_start, y_start, bar_width, height);
			ctx.fillStyle = halBarBackgroundColour;
			ctx.fill();
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
				ctx.font='%1px "%2"'.arg(halValueFontSize).arg(halFontFamily);
				ctx.textAlign = (halValueFontAlign == 1) ? "right" : "left";
				compute_max_text_width(ctx);
				var x_start = getBarStartX(halValueFontAlign,computed_text_width);
				var value = (halPeakValue - halCompMinValue);
				var value_fraction = value / (halCompMaxValue - halCompMinValue);
				var valueHeight = compHeight * value_fraction;
				var edge_offset = ((halValueFontAlign == 0) ? 0: halValueFontSize/2);
				var y_start = (halReverseNeedleDirection == 1) ? (edge_offset + valueHeight -bar_spacing /2) : (compHeight + edge_offset - valueHeight + bar_spacing /2);
				ctx.beginPath();
				ctx.strokeStyle = halPeakNeedleColour;
				ctx.lineWidth = bar_spacing;
				ctx.moveTo(x_start , y_start);
				ctx.lineTo(x_start + bar_width, y_start);
				ctx.stroke();
			}
		}
	}

	Canvas {
		id: tickmarkCanvas
		width: thisComp.width
		height: thisComp.height
		z: 4

		onPaint: {

			var edge_offset = ((halValueFontAlign == 0) ? 0: halValueFontSize/2);

			var ctx = getContext("2d");
			ctx.reset();
 			ctx.font='%1px "%2"'.arg(halValueFontSize).arg(halFontFamily);
			ctx.textAlign = "left";
			compute_max_text_width(ctx);
			var x_start = getBarStartX(halValueFontAlign,computed_text_width);
			var y_start = edge_offset;

			bar_width = getBarWidth(halValueFontAlign,computed_text_width);
			//Tick Marks & Tick Labels
			if (halCompStepSize > 0)
			{
				var num_steps = (new_max_value - halCompMinValue) / halCompStepSize;

				if (num_steps > 0)
				{
					var tick_mark_offset = (compHeight / num_steps);
					var tick_mark_width = bar_spacing;
					for (var nstep = 0; nstep <= num_steps; nstep++)
					{
						var step = (halReverseNeedleDirection == 1) ? nstep : num_steps - nstep;
						ctx.beginPath();
						ctx.strokeStyle = halBarTickColour;
						ctx.lineWidth = tick_mark_width;
						if(step == num_steps) // Due to rounding errors it can be one pixel away. Fixed it to the end
						{
							ctx.moveTo(x_start,compHeight + edge_offset);
							ctx.lineTo(x_start + bar_width, compHeight + edge_offset);
						}
						else
						{
							ctx.moveTo(x_start, step * tick_mark_offset - tick_mark_width + edge_offset);
							ctx.lineTo(x_start + bar_width, step * tick_mark_offset - tick_mark_width + edge_offset);
						}
						ctx.stroke();

						if (halValueFontSize > 0)
						{
							ctx.beginPath();
							ctx.fillStyle = halBarMarkingsColour;
							ctx.textAlign = "left";
							var step_val = (halReverseNeedleDirection == 0) ? (num_steps - step) : step;
							var text_val = (step_val * halCompStepSize + halCompMinValue).toFixed(halDecimalPlaces);
							var text_width = ctx.measureText(text_val).width;
							var text_x_pos = getTextStartX(halValueFontAlign,text_width,x_start,bar_width);
							if(halValueFontAlign == 0)
							{
								var yoffset = (halReverseNeedleDirection == 0) ? (2* tick_mark_width -halValueFontSize): 2 *tick_mark_width;
								if (step == num_steps)
									ctx.fillText(text_val, text_x_pos, thisComp.height - yoffset);
								else
									ctx.fillText(text_val, text_x_pos,  step * tick_mark_offset - yoffset);
							}
							else
							{
								var text_y_pos = step * tick_mark_offset + halValueFontSize - 2 *bar_spacing;
								ctx.fillText(text_val, text_x_pos, text_y_pos - tick_mark_width);
							}
						}
					}
				}
			}
		}
	}
}
