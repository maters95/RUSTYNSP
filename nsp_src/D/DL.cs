using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using NSP.SettingsFramework;

namespace D;

internal class DL : SpecialObject
{
	private Setting Byw;

	internal DL(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	internal new void A()
	{
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIF())
			{
				Byw = settingOrSpecialObject as Setting;
				break;
			}
		}
	}

	[SpecialName]
	internal new Setting a()
	{
		return Byw;
	}
}
internal class Dl : SpecialObject
{
	private Setting ByX;

	internal Dl(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	internal new void A()
	{
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject.B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIf()) && settingOrSpecialObject.B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIG()))
			{
				ByX = settingOrSpecialObject as Setting;
			}
		}
	}

	[SpecialName]
	internal new Setting a()
	{
		return ByX;
	}
}
