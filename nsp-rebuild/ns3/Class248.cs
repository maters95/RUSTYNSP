using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns7;

namespace ns3;

internal class Class248 : SpecialObject
{
	private Class249 Byh;

	private Setting ByI;

	private Setting Byi;

	private Setting ByJ;

	private Setting Byj;

	internal Class248(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
		Byh = settingOrSpecialObject_0 as Class249;
	}

	internal void method_71()
	{
		int num = Byh.method_73().IndexOf(this);
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject.method_2().Contains(Class333.BhP() + num + Class333.Bhp()))
			{
				ByI = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2().Contains(Class333.BhP() + num + Class333.BhQ()))
			{
				Byi = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2().Contains(Class333.BhP() + num + Class333.Bhq()))
			{
				ByJ = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2().Contains(Class333.BhP() + num + Class333.BhR()))
			{
				Byj = settingOrSpecialObject as Setting;
			}
		}
	}

	[SpecialName]
	internal Setting method_72()
	{
		return ByI;
	}

	[SpecialName]
	internal Setting method_73()
	{
		return Byi;
	}

	[SpecialName]
	internal Setting method_74()
	{
		return ByJ;
	}

	[SpecialName]
	internal Setting method_75()
	{
		return Byj;
	}
}
