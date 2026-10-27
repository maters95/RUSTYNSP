import QtQuick 2.9

Item {
	id: errorItem
	width: 860
	height: 480

	Rectangle {
		id: background
		width: parent.width
		height: parent.height
		color: "#202020"
	}

	function setGaugeProperties(params)
	{

		for(var k in params)
		{
			if (errorItem.hasOwnProperty(k))
			{
				errorItem[k] = params[k];
			}
		}

		return 0;
	}

	function setErrorText(text)
	{
		errorText.text = text;
	}

	Text {
		id: errorText
		width: parent.width
		height: parent.height
		text: "Internal Error: IO"
		font.pixelSize: 40
		anchors.fill: parent
		anchors.centerIn: parent
		color: "white"
		horizontalAlignment : TextInput.AlignHCenter
		verticalAlignment: TextInput.AlignVCenter
	}

}