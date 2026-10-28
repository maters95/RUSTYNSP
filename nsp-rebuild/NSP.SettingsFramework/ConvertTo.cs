using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns6;

namespace NSP.SettingsFramework;

public class ConvertTo
{
	private int ayZ;

	private int ayz = -1;

	private string aZA;

	private string aZa;

	private List<Class261> aZB = new List<Class261>();

	internal ConvertTo(int int_0, int int_1, string string_0, string string_1)
	{
		ayZ = int_0;
		ayz = int_1;
		aZA = string_0;
		aZa = string_1;
	}

	[SpecialName]
	internal int method_0()
	{
		return ayZ;
	}

	[SpecialName]
	internal int method_1()
	{
		return ayz;
	}

	[SpecialName]
	internal string method_2()
	{
		return aZA;
	}

	[SpecialName]
	internal string method_3()
	{
		return aZa;
	}

	internal void method_4(Class261 class261_0)
	{
		aZB.Add(class261_0);
	}

	internal void method_5(Setting setting_0, Framework framework_0, Framework framework_1, List<int[]> list_0, bool bool_0)
	{
		List<int[]> list_1 = new List<int[]>();
		foreach (Class261 item in aZB)
		{
			item.vmethod_1(setting_0, framework_0, framework_1, list_1, list_0, bool_0);
		}
	}
}
