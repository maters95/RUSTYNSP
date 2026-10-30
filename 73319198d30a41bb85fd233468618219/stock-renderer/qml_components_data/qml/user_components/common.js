function roundDp(value, num_dp) {
	return Math.round(value * Math.pow(10, num_dp)) / Math.pow(10, num_dp);
}

//import "common.js" as Common

// When trying to align text created on a canvas, use this function
function setting_to_horizontal_align_canvas(inval)
{
	var align = "center";
	var val = Math.round(inval /10);
	switch(val)
	{
		case 0:
			align = "center";
			break;
		case 1:
			align = "left";
			break;
		case 2:
			align = "right";
			break;
		case 3:
			align = "center";
			break;
	}
	return align;
}

// When trying to align text created on a canvas, use this function
function setting_to_vertical_align_canvas(inval)
{
	var align = "middle";
	var val = inval % 10;
	switch(val)
	{
		case 0:
			align = "middle";
			break;
		case 1:
			align = "top";
			break;
		case 2:
			align = "bottom";
			break;
	}
	return align;
}

// When trying to align a qml text object, use this function
function setting_to_horizontal_align_text(inval)
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

// When trying to align a qml text object, use this function
function setting_to_vertical_align_text(inval)
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

// common value repaint for vertical and horizontal segmented bars
function calcVisibleSegments(value_fraction,visibility)
	{

		var cont_rep = value_fraction * num_bars;
		var new_bar = Math.round(cont_rep);
		var min_bar		= Math.floor(cont_rep);
		var max_bar		= Math.min(num_bars, min_bar+1);
		var fract		= cont_rep - min_bar;
		if((current_bar != min_bar && current_bar != max_bar) || (current_bar != min_bar && fract < 0.4) || (current_bar != max_bar && fract > 0.6))
		/*
		// This code to be used if no hysterisis is required
		var num_bars_float = value_fraction * num_bars;
		var new_bar = Math.round(num_bars_float);
		if (new_bar != current_bar)
		*/
		{
			current_bar = new_bar;
			//Update the bars
			for (var bar = 0; bar < num_bars; bar++)
			{
				var bar_obj = bar_repeater.itemAt(bar);

				if (bar_obj !== null)
				{
					bar_obj.visible = ((num_bars - bar - 1) < current_bar) ? visibility : !visibility;
				}
			}
		}
	}



//Is it default Font

function isDefaultFontFamily()
{
	if (halFontFamily.includes("D-DIN Condensed"))
		return true;
	else
		return false;
}
