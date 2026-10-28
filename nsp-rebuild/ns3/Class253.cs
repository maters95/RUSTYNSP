using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;

namespace ns3;

internal class Class253 : SpecialObject
{
	private List<Class252> Byx = new List<Class252>();

	internal Class253(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	internal void method_71()
	{
		foreach (int item in method_27())
		{
			SettingOrSpecialObject settingOrSpecialObject = m_framework.method_33(item);
			if (settingOrSpecialObject != null && settingOrSpecialObject is Class252)
			{
				Class252 @class = settingOrSpecialObject as Class252;
				Byx.Add(@class);
				@class.method_71();
			}
		}
	}

	[SpecialName]
	internal List<Class252> method_72()
	{
		return Byx;
	}
}
