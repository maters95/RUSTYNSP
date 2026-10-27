import QtQuick 2.9
import QtQuick.Controls 2.2
import QtQuick.Controls.Styles 1.4
import QtGraphicalEffects 1.0
import QtQuick.Layouts 1.3
import "../../styles"

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
		
		if(dashVariant == 12)
		{
			alertWidth = 1280;
		}
		else
		{
			alertWidth = 860;
		}
		
	}
	
	function reInitAlarmScreen(msg)
	{
		var jsonObj  = JSON.parse(msg);
		var i;
		alarmModel.clear();
		for(i=0; i< jsonObj.length; i++)
		{
			alarmModel.append(jsonObj[i]);
		}
		startLocation = 480 - alarmModel.count * alertHeight;
		if(alarmModel.count > 0)
		{
			//console.log("alarmModel length now:" + alarmModel.count);
		}
	}

	FontLoader {
		id: dinFont
		source: "../../styles/DINCondensed-Bold.ttf"
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
			model: alarmModel
			Rectangle{
				id : myRect
				x: 0
				y:  alertHeight * (index )
				height : alertHeight
				width  : alertWidth
				color: model.bc
				radius: alarmRadius
				Text{
					id:myMessage
					font: Qt.font({ family: dinFont.name, pixelSize: alertFontSize, weight: Font.DemiBold, italic: false, capitalization: Font.AllUppercase })
					z: 3
					topPadding : alertHeight / 5
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



