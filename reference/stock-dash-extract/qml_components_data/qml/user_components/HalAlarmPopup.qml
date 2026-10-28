import QtQuick 2.9
import QtQuick.Controls 2.2
import QtQuick.Controls.Styles 1.4
import QtGraphicalEffects 1.0
import QtQuick.Layouts 1.3
import "../../fonts"

Item {
	objectName: "HalAlarmPopup"
	id: alertPopup
	x: 0
	y: 0
	z: 5
	width: 860
	height: 480
	visible:true
	property int currentSelection: 2

	property int alertHeight: 60
	property int dashVariant : 11
	property int alertWidth : 860
	property int alertFontSize: alertHeight * 0.75
	property int repeatCount : 5
	property int alarmRadius: 2
	property int startLocation: 0
	property real alertOpacity: 1.0
	property real imageMargin: 10
	property string halFontPath: "../../fonts/D-DINCondensed-Bold-Dash.ttf"

	ListModel{
		id:alarmModel
	}

	function setGaugeProperties(params)
	{

		for(var k in params)
		{
			if (alertPopup.hasOwnProperty(k))
			{
				//console.log("Property[" + k + "]=" + params[k]);
				alertPopup[k] = params[k];
			}
		}

		return 0;
	}

	function setDashVariant(params)
	{
		dashVariant = params;

		switch (true) {
			case (dashVariant == 41): // uC-15
				alertWidth = 2560;
				height = 720;
				break;

			case (dashVariant == 12):  // uC-10
				alertWidth = 1280;
				break;

			default: // iC-7
				alertWidth = 860;
		}
	}

	function reInitAlarmScreen(msg)
	{
		var jsonObj  = JSON.parse(msg);
		var i;
		var startOffset = 0;
		alarmModel.clear();
		for(i=0; i< jsonObj.length; i++)
		{
			if (!jsonObj[i].height || parseInt(jsonObj[i].height) < alertHeight)
				jsonObj[i].height = alertHeight.toString();

			jsonObj[i].y_pos = startOffset;

			alarmModel.append(jsonObj[i]);
			startOffset += parseInt(jsonObj[i].height);

		}
		startLocation = height - startOffset;
	}

	FontLoader {
		id: dinFont
		source:  halFontPath
	}
	Item {
		objectName: "AlertGauge"
		id: alertGauge
		x: 0
		y: alertPopup.startLocation
		z: 8
		opacity: alertOpacity
		width: alertWidth
		height: alertHeight
		visible: true

		Repeater {
			id: alarmRepeater
			model: alarmModel

			Rectangle{
				id : myRect
				x: 0
				y: model.y_pos
				height : parseInt(model.height)
				width  : alertWidth
				color: model.bc
				radius: alarmRadius

				Image {
					source: model.img ? model.img : ""
					verticalAlignment: Text.AlignVCenter
					horizontalAlignment: Text.AlignLeft
					x: imageMargin
					y: imageMargin
					height: parseInt(model.height) - (2 * imageMargin)
					width: parseInt(model.height) + (2 * imageMargin)
					fillMode: Image.PreserveAspectFit
					z: 10
				}

				Text {
					id: myMessage
					font: Qt.font({ family: dinFont.name, pixelSize: alertFontSize, weight: Font.DemiBold, italic: false, capitalization: Font.AllUppercase })
					z: 3
					color: model.fc
					text: model.text
					anchors.fill: parent
					anchors.centerIn: parent
					horizontalAlignment : TextInput.AlignHCenter
					verticalAlignment: TextInput.AlignVCenter
				}
			}
		}
	}
}
