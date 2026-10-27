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
	width: 432
	height: 432

	// Raw Values
	property real   halRawValue: 0
	property string halValueText
	property string halUnitText: ""

	// Settings
	property real   halCompMinValue: 0
	property real   halCompMaxValue: 10
	property real   halCompWarnMinValue: 0
	property real   halCompWarnMaxValue: 5

	property bool   halCompWarnMinEnable: true
	property bool   halCompWarnMaxEnable: true

	property int    halImageOpacity
	property string halImagePath
	property real   halCompStepSize: 1000
	property int    halCompMinorTickCount: 3
	property int    halValueFontSize: 45
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
	property int	halReverseNeedleDirection:0
	property int    halNeedleImageOffset: 0
	property string halPeakImagePath
	property int    halPeakNeedleImageOffset: 0

	property string halFontFamily

	//Colours
	property color  halWarningColour: "#FF0000"

	property color  halNumericValueColour
	property color  halNumericLabelColour
	property color  halNumericUnitColour

	property color  halBarValueColour: "#C0C0C0"
	property color  halBarLabelColour: "#FFFFFF"
	property color  halBarTickColour : "#FFFFFF"
	property color  halBarMarkingsColour : "#FFFFFF"
	property color  halBarBackgroundColour: "#808080"

	property color  halPeakNeedleColour
	property color  halCircularNeedleColour: "#FF0000"
	property color  halCircularMarkingsColour: "#000000"
	property color  halCircularMarkingsWarnColour: "#FFFFFF"
	property color  halCircularTickColour: "#000000"
	property color  halCircularBackgroundColour: "#E0B32E"

	property color  halIndicatorOnColour
	property color  halIndicatorOffColour

	property bool halShowPeakNeedle: false
	property real halPeakValue: halCompMinValue

	property real gaugeMinValue:0
	property real gaugeMaxValue:10
	property real gaugeStepSize:1000


	property real halStartAngle: -180
	property real halEndAngle: 94

	property real minAngle: (halStartAngle != halEndAngle) ? ((halReverseNeedleDirection == 0) ? halStartAngle : halEndAngle ) : -135.0
	property real maxAngle: (halStartAngle != halEndAngle) ? ((halReverseNeedleDirection == 0) ? halEndAngle : halStartAngle ) : 135.0

	property bool screenshotMode: false

	// END Common Properties

	// When the step values are float, the last value calculated is slightly bigger than halCompMaxValue
	// So, the last step value does not get written or a previous value (possibly 0.0) remains
	// To avoid that we ask the system to calculate steps for a max value slightly bigger than halCompMaxValue
	// namely halCompMaxValue + floatCorrection
	readonly property real floatCorrection: 0.00001


	// START Common Event Handlers

	onHalFontFamilyChanged: { repaintAll(); }

	onHalPeakImagePathChanged: {
			repaintAll();
	 }

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
				console.log("Trying to set a property that doesn't exist " + prop);
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
	}

	// Repaint only things that change on every raw value change
	// Keep this functions and its canvas's as light weight as possible
	// Automatically triggered by changes to halRawValue, halValueText and halUnitText
	function repaintValue()
	{
		hero_gauge.value = halRawValue;
	}

	function showPeakNeedle(value)
	{
		halShowPeakNeedle = true;
		halPeakValue = Math.min(halCompMaxValue,Math.max(value,halCompMinValue));
		backgroundCanvas.requestPaint();
	}

	function hidePeakNeedle()
	{
		halShowPeakNeedle = false;
		backgroundCanvas.requestPaint();
	}

	// END Common Functions

	property real minAngleOffset: 0

	Image{
		id:peakNeedleImage
		source: halPeakImagePath
		visible: false
	}


	Canvas {
		id: backgroundCanvas
		width: thisComp.width
		height: thisComp.height
		z: 1

		onPaint: {

			var ctx = getContext("2d");
			ctx.reset();

			var redThickness = 0.3;
			var outRadius = thisComp.width / 2;
			var xCenter = (thisComp.width * 0.5);
			var yCenter = xCenter;

			var outerRadius = thisComp.width / 2;

			// The longer the text of the minimum value label,
			// the bigger the offset to make sure its not exceeding its bounds.
			// This acts like a "end" justify for the last label (but also moves the tick mark)
			var minValueLen = halCompMinValue.toString().length;
			minAngleOffset = minValueLen * 1.75 - 0.75;

			// Background Arc
			ctx.beginPath();
			ctx.strokeStyle = halCircularBackgroundColour;
			ctx.lineWidth = toPixels(redThickness, thisComp.width);
			var radius = outerRadius - (ctx.lineWidth )/ 2;

			// In Dial gauge, needle sweepes from minimum value to maximum value. We internally set the minimum
			// value associated with start angle and maximum value associated with end angle
			// When we want to reverse needle direction, we swap the start and end angles of the dial gauge
			// But we do not want the user to confuse their start and end angle specifications as they see it
			// So, user defined Start angle and End angle remain the same.
			// The constant angles 263, 265, 270, 274, 277, 280 are all based on specific rendering requirements

			if(halReverseNeedleDirection == 0)
				ctx.arc(xCenter, yCenter, radius, degToRad(minAngle + 265),degToRad(maxAngle + 274 ));
			else
				ctx.arc(xCenter, yCenter, radius, degToRad(maxAngle + 265), degToRad(minAngle + 274));

			ctx.stroke();

			// Upper Warning
			if(Common.roundDp(halCompWarnMaxValue, 3) < Common.roundDp(gaugeMaxValue, 3) && halCompWarnMaxEnable) {
				ctx.beginPath();
				ctx.strokeStyle = halWarningColour;
				ctx.lineWidth = toPixels(redThickness, thisComp.width);
				radius = outerRadius - (ctx.lineWidth )/ 2;
				if(halReverseNeedleDirection == 0)
					ctx.arc(xCenter, yCenter, radius,degToRad(valueToAngle(halCompWarnMaxValue) + 270), degToRad(maxAngle + 274));
				else
					ctx.arc(xCenter, yCenter,radius, degToRad(maxAngle + 265),degToRad(valueToAngle(halCompWarnMaxValue) + 270) );
				ctx.stroke();
			}

			// Lower Warning
			if(Common.roundDp(halCompWarnMinValue, 3) > Common.roundDp(gaugeMinValue, 3) && halCompWarnMinEnable) {
				ctx.beginPath();
				ctx.strokeStyle = halWarningColour;
				ctx.lineWidth = toPixels(redThickness, thisComp.width);
				radius = outerRadius - (ctx.lineWidth )/ 2;
				if(halReverseNeedleDirection == 0)
					ctx.arc(xCenter, yCenter, radius, degToRad((minAngle) +265), degToRad(valueToAngle(halCompWarnMinValue) +270 ));
				else
					ctx.arc(xCenter, yCenter,radius ,degToRad(valueToAngle(halCompWarnMinValue) +270), degToRad(minAngle + 274) );
				ctx.stroke();
			}

			// Outer part of the inner "pacman" ring
			ctx.beginPath();
			ctx.strokeStyle = Qt.darker(halCircularBackgroundColour,1.5);
			ctx.lineWidth = toPixels(0.035, thisComp.width);
			radius = outerRadius * 0.61;
			var anglestart = degToRad(minAngle + 263);
			var angleend = degToRad(maxAngle + 277);
			if(halReverseNeedleDirection == 1)
			{
				anglestart = degToRad(maxAngle + 263);
				angleend = degToRad(minAngle + 277);
			}
			ctx.arc(xCenter, yCenter, radius, anglestart, angleend);
			ctx.stroke();

			//Inner "pacman" ring
			ctx.beginPath();
			ctx.lineWidth = toPixels(0.005, thisComp.width);
			radius = outerRadius * 0.51;
			anglestart = degToRad(minAngle + 260);
			angleend = degToRad(maxAngle + 280);
			var horizstart = xCenter + radius * Math.cos (anglestart);
			var vertstart = yCenter + radius * Math.sin (anglestart);
			var vertend = yCenter + radius * Math.sin (angleend);
			if(halReverseNeedleDirection == 1)
			{
				anglestart = degToRad(maxAngle + 260);
				angleend = degToRad(minAngle + 280);
				horizstart = xCenter + radius * Math.cos (anglestart);
				vertstart = yCenter + radius * Math.sin (anglestart);
				vertend = yCenter + radius * Math.sin (angleend);
			}
			ctx.arc(xCenter, yCenter, radius, anglestart, angleend);
			ctx.lineTo(horizstart, vertend);
			ctx.lineTo(horizstart, vertstart);
			ctx.stroke();

			//Outer tickmark ring
			ctx.beginPath();
			ctx.strokeStyle = halCircularTickColour;
			ctx.lineWidth = toPixels(0.01, thisComp.width);
			if(ctx.lineWidth < 1){
				ctx.lineWidth = 1;
			}
			if(halReverseNeedleDirection == 0)
				ctx.arc(xCenter, yCenter, outerRadius * 0.97,degToRad(minAngle + 269) , degToRad(maxAngle + 271));
			else
				ctx.arc(xCenter, yCenter, outerRadius * 0.97,degToRad(maxAngle + 269) , degToRad(minAngle + 271));
			ctx.stroke();

			// Peak Value
			if(halShowPeakNeedle)
			{
				var peakAngle = valueToAngle(halPeakValue);
				if(halPeakImagePath == "")
				{
					ctx.beginPath();
					ctx.strokeStyle = halPeakNeedleColour;
					ctx.lineWidth = toPixels(0.27, thisComp.width);
					var radius = outerRadius * 0.97 - (ctx.lineWidth )/ 2;
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
			ctx.restore();
		}
	}

	CircularGauge {
		id: hero_gauge
		width: thisComp.width
		height: thisComp.height
		anchors.centerIn: parent
		z: 2

		minimumValue: gaugeMinValue
		maximumValue: gaugeMaxValue

		style: CircularGaugeStyle {
			id: style
			tickmarkInset: toPixels(0.03, thisComp.width)
			minorTickmarkInset: toPixels(0.02, thisComp.width)
			labelInset: (thisComp.width * 0.5 * 0.18)
			tickmarkStepSize: gaugeStepSize
			labelStepSize: gaugeStepSize
			minorTickmarkCount: halCompMinorTickCount
			minimumValueAngle: (minAngle + minAngleOffset)
			maximumValueAngle: maxAngle

			tickmark: Rectangle {
				width: (thisComp.width / 2) * 0.05
				height: (thisComp.height / 2) * 0.04
				color: "transparent"
				anchors.bottomMargin : (thisComp.width / 2) * -0.01
				property color tickColor: halCircularTickColour
				onTickColorChanged:
				{
					tickmarkCanvas.requestPaint();
				}
				Canvas {
					id: tickmarkCanvas
					anchors.fill:parent
					onPaint:{
						var context = getContext("2d");
						context.reset();
						context.beginPath();
						context.moveTo(0,0);
						context.lineTo(width,0);
						context.lineTo(width/2,height);
						context.closePath();
						context.fillStyle = tickColor;
						context.fill();
					}
				}
			}

			minorTickmark: Rectangle {
				y: (thisComp.width / 2) * 0.02
				implicitWidth: (thisComp.width / 2) * 0.005
				implicitHeight: (thisComp.width / 2) * 0.03
				antialiasing: true
				color: halCircularTickColour
			}

			tickmarkLabel: Text {
				y: (Common.isDefaultFontFamily()) ? 0 : (halValueFontSize/7)
				id: tickText
				font.pixelSize: halValueFontSize
				font.weight: Font.Medium
				font.family: halFontFamily
				text: styleData.value.toFixed(halDecimalPlaces)
				color:  tickmarkLabelColor(styleData.value)
				antialiasing: true
				layer.enabled:  !screenshotMode
				horizontalAlignment: Text.AlignHCenter
				verticalAlignment: Text.AlignVCenter
				z: 6
				layer.effect: DropShadow {
					verticalOffset: 1
					horizontalOffset: 2
					color: "#40000000"
					radius: 2
					samples: 8
					cached: true
				}
			}

			// Needle center "nub"
			foreground: Item { Rectangle {
				property real needleCenterDia: (thisComp.width * 0.12)
				width: needleCenterDia * 0.5
				height: needleCenterDia * 0.5
				radius: (needleCenterDia * 0.5) / 2
				color: halCircularNeedleColour
				anchors.centerIn: parent
				visible: (halImagePath == "") ? true : false
			}}

			needle: Component
			{
				id: needleComponent
				Loader {
					Component {
						id: canvasComponent
						Canvas {
							z: 10
							id: needle_canvas
							implicitWidth: needleBaseWidth
							implicitHeight: needleLength

							property real needleLength: toPixels(0.95, thisComp.width)
							property real needleTipWidth: toPixels(0.02, thisComp.width)
							property real needleBaseWidth: toPixels(0.09, thisComp.width)
							property real xCenter: width / 2
							property real yCenter: height / 2
							property color needleColor: halCircularNeedleColour

							onNeedleColorChanged:
							{
								requestPaint();
							}

							onPaint: {
								var ctx = getContext("2d");
								ctx.reset();

								var xCenter = (needleBaseWidth / 2);
								var yCenter = xCenter;

								ctx.beginPath();
								ctx.moveTo(xCenter, height);
								ctx.lineTo(xCenter - needleBaseWidth / 2, height - needleBaseWidth / 2);
								ctx.lineTo(xCenter - needleTipWidth / 2, 0);
								ctx.lineTo(xCenter, yCenter - needleLength);
								ctx.lineTo(xCenter, 0);
								ctx.closePath();
								ctx.fillStyle = halCircularNeedleColour;
								ctx.fill();

								ctx.beginPath();
								ctx.moveTo(xCenter, height);
								ctx.lineTo(width, height - needleBaseWidth / 2);
								ctx.lineTo(xCenter + needleTipWidth / 2, 0);
								ctx.lineTo(xCenter, 0);
								ctx.closePath();
								ctx.fillStyle = Qt.lighter(halCircularNeedleColour,1.5);
								ctx.fill();
							}
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

					sourceComponent: (halImagePath == "") ? canvasComponent : imageComponent
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
		var angle_range = maxAngle - minAngle - minAngleOffset;
		return minAngle + minAngleOffset + (percentage_of_value * angle_range);
	}

	function tickmarkLabelColor(value) {
		var decimals = (halDecimalPlaces < 3 ) ? 3 : halDecimalPlaces;
		if( (halCompWarnMinEnable && (Common.roundDp(value, decimals) < Common.roundDp(halCompWarnMinValue, decimals))) ||
			(halCompWarnMaxEnable && (Common.roundDp(value, decimals) > Common.roundDp(halCompWarnMaxValue, decimals))) )
			return halCircularMarkingsWarnColour;
		else
			return halCircularMarkingsColour;
	}
}
