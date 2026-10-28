using System.Collections.Generic;
using ns7;

namespace NSP.SettingsFramework;

public class GlobalImageLibrary
{
	public Dictionary<string, ImageItem> ImageItemList = new Dictionary<string, ImageItem>();

	public override string ToString()
	{
		return Class333.aMv() + ImageItemList.Keys.Count + Class333.aMW();
	}
}
