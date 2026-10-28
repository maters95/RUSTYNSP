using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;

namespace ns3;

internal class Class246 : SpecialObject
{
	private List<int> BYG = new List<int>();

	internal Class246(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	[SpecialName]
	internal List<int> method_71()
	{
		return BYG;
	}

	[SpecialName]
	internal void method_72(List<int> list_0)
	{
		BYG = list_0;
	}
}
