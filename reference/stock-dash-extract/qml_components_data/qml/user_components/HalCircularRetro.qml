import QtQuick 2.9
import QtQuick.Extras 1.4
import QtQuick.Controls.Styles 1.4
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
	width: 395
	height: 395

	// Raw Values
	property real   halRawValue: 0
	property string halValueText
	property string halUnitText: "RPM x1000"

	// Settings
	property real   halCompMinValue: 0
	property real   halCompMaxValue: 320
	property real   halCompWarnMinValue: 0
	property real   halCompWarnMaxValue: 200

	property bool   halCompWarnMinEnable: true
	property bool   halCompWarnMaxEnable: true

	property int    halImageOpacity
	property string halImagePath
	property string halFontFamily
	property real   halCompStepSize: 20
	property int    halCompMinorTickCount: 1
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
	property int	halReverseNeedleDirection:0
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
	property color  halCircularNeedleColour: "#EAECD5"
	property color  halCircularMarkingsColour: "#EAECD5"
	property color  halCircularMarkingsWarnColour: "#FDCF8C"
	property color  halCircularTickColour: "#EAECD5"
	property color  halCircularBackgroundColour: "#00000000"

	property color  halIndicatorOnColour
	property color  halIndicatorOffColour

	property bool halShowPeakNeedle: false
	property real halPeakValue: halCompMinValue

	property real gaugeMinValue:0
	property real gaugeMaxValue:320
	property real gaugeStepSize:20

	property bool screenshotMode: false

	// END Common Properties

	// When the step values are float, the last value calculated is slightly bigger than halCompMaxValue
	// So, the last step value does not get written or a previous value (possibly 0.0) remains
	// To avoid that we ask the system to calculate steps for a max value slightly bigger than halCompMaxValue
	// namely halCompMaxValue + floatCorrection
	readonly property real floatCorrection: 0.00001


	// START Common Event Handlers

	onHalFontFamilyChanged: { repaintAll(); }
	onHalPeakImagePathChanged: {repaintAll(); }

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

		var num_maj_ticks = (halCompMaxValue - halCompMinValue) / halCompStepSize;

		if (num_maj_ticks < 1)
		{
			num_maj_ticks = 1;
			halCompStepSize = (halCompMaxValue - halCompMinValue) / num_maj_ticks;
		}
		else if (num_maj_ticks > 20)
		{
			num_maj_ticks = 20;
			halCompStepSize = (halCompMaxValue - halCompMinValue) / num_maj_ticks;
		}

			// The following logic is added because when the gauge range (MaxValue - MinValue) changes,
			// the Circular gauge tick marks re-render based on StepSize. The order in which
			// the Max, Min values and StepSize are changed results in different Tickmark numbers being
			// created intermediately even though the final number is same. This is because of the property
			// binding of these values to Gauge properties.
			// When large number of Tick marks are created in an intermediate step, this slows down
			// gauge rendering considerably.So, we are setting the StepSize value in different order to minimize
			// this effect based on if previous range to current range change is smaller or bigger.

		if((halCompMaxValue - halCompMinValue) < (gaugeMaxValue - gaugeMinValue))
		{
			gaugeMinValue = halCompMinValue;
			gaugeMaxValue = halCompMaxValue + floatCorrection;
			gaugeStepSize = halCompStepSize;
		}
		else
		{
			gaugeStepSize = halCompStepSize;
			gaugeMinValue = halCompMinValue;
			gaugeMaxValue = halCompMaxValue + floatCorrection;
		}
		backgroundCanvas.requestPaint();
		if (halShowPeakNeedle) peakNeedleCanvas.requestPaint();
	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{
		retro_gauge.value = halRawValue;
		unit_text.text = halUnitText;
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

	property real halStartAngle: -135
	property real halEndAngle: 135

	property real minAngle: (halStartAngle != halEndAngle) ? ((halReverseNeedleDirection == 0) ? halStartAngle : halEndAngle ) : -135.0
	property real maxAngle: (halStartAngle != halEndAngle) ? ((halReverseNeedleDirection == 0) ? halEndAngle : halStartAngle ) : 135.0

	Image{
		id:peakNeedleImage
		source: halPeakImagePath
		visible: false
	}

	Canvas {
		id: backgroundCanvas
		width: thisComp.width
		height: thisComp.height
		visible: (halImagePath == "") ? true : false
		z: 1

		onPaint: {

			var ctx = getContext("2d");
			ctx.reset();

			var xCenter = (thisComp.width * 0.5);
			var yCenter = xCenter;

			var nubRadius = (thisComp.width / 2) * 0.1;

			//Center needle "nub"
			ctx.beginPath();
			ctx.strokeStyle = "#111111";
			ctx.arc(xCenter, yCenter, nubRadius,
					2 * Math.PI , 0);
			ctx.fill();

		}
	}

	Canvas {
		id: peakNeedleCanvas
		width: thisComp.width
		height: thisComp.height
		z: 3

		onPaint: {

			var ctx = getContext("2d");
			ctx.reset();

			var xCenter = (thisComp.width * 0.5);
			var yCenter = xCenter;
			var outerRadius = thisComp.width / 2;

			var peakAngle = valueToAngle(halPeakValue);
			if(halPeakImagePath == "")
			{
				ctx.beginPath();
				ctx.strokeStyle = halPeakNeedleColour;
				ctx.lineWidth = toPixels(0.15, thisComp.width);
				var radius = outerRadius  - (ctx.lineWidth )/ 2;
				ctx.arc(xCenter, yCenter, radius,degToRad(peakAngle + 269.5) , degToRad(peakAngle + 270.5));
				ctx.stroke();
			}
			else
			{
				var peakNeedleAngleInRadians = degToRad(peakAngle);
				ctx.translate(thisComp.width /2 , thisComp.width /2);
				ctx.rotate(peakNeedleAngleInRadians);
				ctx.drawImage(halPeakImagePath, -peakNeedleImage.width/2, -peakNeedleImage.height + toPixels(halPeakNeedleImageOffset/1000, width) );
			}

		}
	}

	Text {
		id: unit_text
		y: thisComp.height * 0.62
		text: halUnitText
		color: halNumericUnitColour
		font.family: halFontFamily
		font.pixelSize: halUnitFontSize
		horizontalAlignment: Text.AlignHCenter
		anchors.left: parent.left
		anchors.right: parent.right
	}

	CircularGauge {
		id: retro_gauge
		width: thisComp.width
		height: thisComp.height
		anchors.centerIn: parent
		z: 2

		minimumValue: gaugeMinValue
		maximumValue: gaugeMaxValue

		style: CircularGaugeStyle {
			tickmarkInset: toPixels(0.01, thisComp.width)
			minorTickmarkInset: toPixels(0.01, thisComp.width)
			labelInset: (thisComp.width * 0.5 * 0.26)
			tickmarkStepSize: gaugeStepSize
			labelStepSize: gaugeStepSize
			minorTickmarkCount: halCompMinorTickCount
			minimumValueAngle: minAngle
			maximumValueAngle: maxAngle

			tickmark: Rectangle {
				width: 5  // Jono - Fixing constant tickmark width (thisComp.width / 2) * 0.025
				height: (thisComp.height / 2) * 0.12
				color: tickmarkColor(styleData.value)
				anchors.bottomMargin : -height
				antialiasing: true
				smooth: true
			}

			minorTickmark: Rectangle {
				implicitWidth: 3 // Jono - Fixing constant minorTickmark width (thisComp.width / 2) * 0.015
				implicitHeight: (thisComp.height / 2) * 0.1
				anchors.bottomMargin : -height
				antialiasing: true
				smooth: true
				color: tickmarkColor(styleData.value)
			}

			tickmarkLabel: Text {
				y: 0
				id: tickText
				font.weight: Font.Medium
				font.pixelSize: halValueFontSize
				font.family: halFontFamily
				text: styleData.value.toFixed(halDecimalPlaces)
				color: tickmarkLabelColor(styleData.value)
				antialiasing: true
				horizontalAlignment: Text.AlignHCenter
				verticalAlignment: Text.AlignVCenter
				z: 6
			}

			// Needle center "nub"
			foreground: Item { Rectangle {
				color: "transparent"
			}}

            property real needleLength: (thisComp.width/2)*0.86 + 30 // Jono - toPixels(1.025, thisComp.width)
            property real needleBaseWidth: 5 // Jono - toPixels(0.025, thisComp.width)
            property real xCenter: width / 2
            property real yCenter: height / 2

			needle: Component
			{
				id: needleComponent
				Loader {
					Component {
						id: defaultComponent
						Rectangle {
							y: 30
							implicitWidth: needleBaseWidth
							implicitHeight: needleLength
							antialiasing: true
							smooth: true
							color: halCircularNeedleColour
						}
					}

					Component{
						id: imageComponent
						Image{
							id:needleImage
							z: 10
							source: halImagePath
							y:toPixels(halNeedleImageOffset/1000.0, thisComp.width)
							height:toPixels((halNeedleImageOffset/1000.0 + 0.95), thisComp.width)
							fillMode:Image.PreserveAspectFit
							clip:true
							cache:false
						}
					}

					sourceComponent: (halImagePath == "") ? defaultComponent : imageComponent
				}
			}
		}

	}

	function toPixels(percent, diameter) {
		if (diameter === 0)
			return 0;
		else
			return percent * (diameter / 2 );
	}

	function degToRad(degrees) {
		return degrees * (Math.PI / 180);
	}

	function valueToAngle(val) {
		var percentage_of_value = (val - gaugeMinValue) / (gaugeMaxValue - gaugeMinValue);
		var angle_range = maxAngle - minAngle;

		return minAngle + (percentage_of_value * angle_range);
	}

	function tickmarkLabelColor(value) {
		var decimals = (halDecimalPlaces < 3 ) ? 3 : halDecimalPlaces;
		// putting the enable conditions first to make evaluation a bit more efficient
		if( (halCompWarnMinEnable && (Common.roundDp(value, decimals) < Common.roundDp(halCompWarnMinValue, decimals))) ||
			(halCompWarnMaxEnable && (Common.roundDp(value, decimals) > Common.roundDp(halCompWarnMaxValue, decimals))) )
			return halCircularMarkingsWarnColour;
		else
			return halCircularMarkingsColour;
	}

    function tickmarkColor(value) {
		var decimals = (halDecimalPlaces < 3 ) ? 3 : halDecimalPlaces;
		// putting the enable conditions first to make evaluation a bit more efficient
		if( (halCompWarnMinEnable && (Common.roundDp(value, decimals) < Common.roundDp(halCompWarnMinValue, decimals))) ||
			(halCompWarnMaxEnable && (Common.roundDp(value, decimals) > Common.roundDp(halCompWarnMaxValue, decimals))) )
            return halWarningColour;
        else
            return halCircularTickColour;
    }

	// Keep for future, too hard for now
	// function tickmarkLabelFontSize(index, fontSize)
	// {
	//     if (index % 2)
	//         return fontSize * 0.65;
	//     else
	//         return fontSize;
	// }

}
