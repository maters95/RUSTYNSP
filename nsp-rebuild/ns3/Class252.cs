using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns7;

namespace ns3;

internal class Class252 : SpecialObject
{
	private Setting ByX;

	internal Class252(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	internal void method_71()
	{
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject.method_2().Contains(Class333.BIf()) && settingOrSpecialObject.method_2().Contains(Class333.BIG()))
			{
				ByX = settingOrSpecialObject as Setting;
			}
		}
	}

	[SpecialName]
	internal Setting method_72()
	{
		return ByX;
	}
}
