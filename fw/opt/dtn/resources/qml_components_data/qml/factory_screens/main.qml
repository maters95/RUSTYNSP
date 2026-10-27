import QtQuick 2.9
import QtQuick.Controls 2.2
import QtQuick.Window 2.3


Item {
        id: mainWindowId
        objectName: "mainWindow"
        property int userScalePercentage : 100
        property int dashVariantId : 11		
        visible: true
		z:100
		x: 0
		y: 0
        width: 860
        height: 480
        transform: [
              Scale {
                         id: scale
                         xScale: (Qt.platform.os == "windows") ? userScalePercentage / 100.0 : (dashVariantId != 11) ? 1.0 : 800/860.0
                         yScale: (Qt.platform.os == "windows") ? userScalePercentage / 100.0 : 1.0
                    },
              Translate {
                         x: 0
                         y: 0
                    }
        ]		
		Rectangle{
			id: selectionRect
			height: 70
			width: 140
			x: 100
			y: 100
			z: 100
			color: "transparent"
			border.color: "aqua"
			border.width: 3
			visible: false
		}

		Rectangle {
			id: bg_rect
			x: 0
			y: 0
			z: 0
			width: parent.width
			height: parent.height
			color: "transparent"
		}
		
		function setScreenSize(width, height)
		{
			mainWindowId.width = width;
			mainWindowId.height = height;
		}

		function setBgColour(colour)
		{
			bg_rect.color = colour;
		}

		function setScreenScale(param)
        {
	       var scale = param;
	       mainWindowId.userScalePercentage = scale;
	       return "";
        }

        function setDashVariant(param)
        {
           mainWindowId.dashVariantId = param;
           return "";
        }
	
		function showSelectionRectangle(param)
		{
		  if(param == "")
		  {
		     selectionRect.visible = false;
			//console.log("selectionRectangle visibility set to false");
		  }
		  else
		  {
		    var params = param.split(',');
			//console.log("selectionRectangle called with " + params);
			selectionRect.x = params[0];
			selectionRect.y = params[1];
			selectionRect.width = params[2];
			selectionRect.height = params[3];
			selectionRect.radius = 5;
			selectionRect.visible = true;
		  }
		  return "";
		}
}
