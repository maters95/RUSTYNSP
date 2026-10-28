using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns7;

namespace ns3;

internal class Class251 : SpecialObject
{
	private Setting Byw;

	internal Class251(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	internal void method_71()
	{
		int num = 0;
		SettingOrSpecialObject settingOrSpecialObject;
		while (true)
		{
			if (num < method_1().Count)
			{
				settingOrSpecialObject = method_1()[num];
				if (settingOrSpecialObject.method_2() == Class333.BIF())
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Byw = settingOrSpecialObject as Setting;
	}

	[SpecialName]
	internal Setting method_72()
	{
		return Byw;
	}
}
