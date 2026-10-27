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

	property int    halCompOpacity
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

	//Colours
	property color  halWarningColour: "#FF0000"

	property color  halNumericValueColour
	property color  halNumericLabelColour
	property color  halNumericUnitColour

	property color  halBarValueColour: "#C0C0C0"
	property color  halBarLabelColour: "#FFFFFF"
	property color  halBarTickColour : "#FFFFFF"
	property color  halBarBackgroundColour: "#808080"

	property color  halCircularNeedleColour: "#FF0000"
	property color  halCircularMarkingsColour: "#000000"
	property color  halCircularMarkingsWarnColour: "#FFFFFF"
	property color  halCircularTickColour: "#000000"
	property color  halCircularBackgroundColour: "#E0B32E"

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

		if (num_maj_ticks > 20)
		{
			num_maj_ticks = 20;
			halCompStepSize = (halCompMaxValue - halCompMinValue) / num_maj_ticks;
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

	// END Common Functions

	FontLoader {
		id: dinFont
		source: "../../styles/DINCondensed-Bold.ttf"
	}

	property real minAngle: -180
	property real maxAngle: 94

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
			var redEndAngle = 105;
			var outerRadius = thisComp.width / 2;

			// Background Arc
			ctx.beginPath();
			ctx.strokeStyle = halCircularBackgroundColour;
			ctx.lineWidth = toPixels(redThickness, thisComp.width);
			var radius = outerRadius - (ctx.lineWidth )/ 2;
			ctx.arc(xCenter, yCenter, radius,
					degToRad(minAngle + 265),degToRad(redEndAngle +263 ));
			ctx.stroke();

			// Upper Warning
			if(Common.roundDp(halCompWarnMaxValue, 3) < Common.roundDp(halCompMaxValue, 3)) {
				ctx.beginPath();
				ctx.strokeStyle = halWarningColour;
				ctx.lineWidth = toPixels(redThickness, thisComp.width);
				radius = outerRadius - (ctx.lineWidth )/ 2;
				ctx.arc(xCenter, yCenter, radius,
						degToRad(valueToAngle(halCompWarnMaxValue) +270), degToRad(redEndAngle + 263));
				ctx.stroke();
			}

			// Lower Warning
			if(Common.roundDp(halCompWarnMinValue, 3) > Common.roundDp(halCompMinValue, 3)) {
				ctx.beginPath();
				ctx.strokeStyle = halWarningColour;
				ctx.lineWidth = toPixels(redThickness, thisComp.width);
				radius = outerRadius - (ctx.lineWidth )/ 2;
				ctx.arc(xCenter, yCenter, radius,
						degToRad((minAngle) +265), degToRad(valueToAngle(halCompWarnMinValue) +270 ));
				ctx.stroke();
			}

			// Outer part of the inner "pacman" ring
			ctx.beginPath();
			ctx.strokeStyle = Qt.darker(halCircularBackgroundColour,1.5);
			ctx.lineWidth = toPixels(0.035, thisComp.width);
			radius = outerRadius * 0.61;
			var anglestart = degToRad(minAngle + 263);
			var angleend = degToRad(redEndAngle + 266)
			ctx.arc(xCenter, yCenter, radius, anglestart, angleend);
			ctx.stroke();

			//Inner "pacman" ring
			ctx.beginPath();
			ctx.lineWidth = toPixels(0.005, thisComp.width);
			radius = outerRadius * 0.51;
			anglestart = degToRad(minAngle + 260);
			angleend = degToRad(redEndAngle + 270);
			var horizstart = xCenter + radius * Math.cos (anglestart);
			var vertstart = yCenter + radius * Math.sin (anglestart);
			var vertend = yCenter + radius * Math.sin (angleend);
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
			ctx.arc(xCenter, yCenter, outerRadius * 0.97,
					degToRad(minAngle + 269) , degToRad(maxAngle + 271));
			ctx.stroke();

		}
	}

	CircularGauge {
		id: hero_gauge
		width: thisComp.width
		height: thisComp.height
		anchors.centerIn: parent
		z: 2

		minimumValue: halCompMinValue
		maximumValue: halCompMaxValue

		style: CircularGaugeStyle {
			tickmarkInset: toPixels(0.03, thisComp.width)
			minorTickmarkInset: toPixels(0.02, thisComp.width)
			labelInset: (thisComp.width * 0.5 * 0.18)
			tickmarkStepSize: halCompStepSize
			labelStepSize: halCompStepSize
			minorTickmarkCount: halCompMinorTickCount
			minimumValueAngle: minAngle
			maximumValueAngle: maxAngle

			tickmark: Rectangle {
				width: (thisComp.width / 2) * 0.05
				height: (thisComp.height / 2) * 0.04
				color: "transparent"
				anchors.bottomMargin : (thisComp.width / 2) * -0.01
				property color tickColor: halCircularMarkingsColour
				onTickColorChanged:
				{
					tickmarkCanvas.requestPaint();
				}
				Canvas {
					id: tickmarkCanvas
					anchors.fill:parent
					onPaint:{
						var context = getContext("2d");
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
				color: halCircularMarkingsColour
			}

			tickmarkLabel: Text {
				y: 0
				id: tickText
				font.pixelSize: Math.max(20, halValueFontSize)
				font.weight: Font.Medium
				font.family: dinFont.name
				text: styleData.value.toFixed(halDecimalPlaces)
				color:  tickmarkLabelColor(styleData.value)
				antialiasing: true
				layer.enabled: true
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
			}}

			needle: Canvas {
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
		var percentage_of_value = (val - halCompMinValue) / (halCompMaxValue - halCompMinValue);
		var angle_range = maxAngle - minAngle;

		return minAngle + (percentage_of_value * angle_range);
	}

	function tickmarkLabelColor(value) {
		if( (Common.roundDp(value, 3) < Common.roundDp(halCompWarnMinValue, 3) ) ||
				(Common.roundDp(value, 3) > Common.roundDp(halCompWarnMaxValue, 3) ) )
			return halCircularMarkingsWarnColour;
		else
			return halCircularMarkingsColour;
	}
}