using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns6;

namespace NSP.SettingsFramework;

public class ConvertFrom
{
	private int ayw;

	private int ayX = -1;

	private string ayx;

	private string ayY;

	private List<Class261> ayy = new List<Class261>();

	internal ConvertFrom(int int_0, int int_1, string string_0, string string_1)
	{
		ayw = int_0;
		ayX = int_1;
		ayx = string_0;
		ayY = string_1;
	}

	[SpecialName]
	internal int method_0()
	{
		return ayw;
	}

	[SpecialName]
	internal int method_1()
	{
		return ayX;
	}

	[SpecialName]
	internal string method_2()
	{
		return ayx;
	}

	[SpecialName]
	internal string method_3()
	{
		return ayY;
	}

	internal void method_4(Class261 class261_0)
	{
		ayy.Add(class261_0);
	}

	internal void method_5(Setting setting_0, Framework framework_0, Framework framework_1, List<int[]> list_0, bool bool_0)
	{
		List<int[]> list_1 = new List<int[]>();
		foreach (Class261 item in ayy)
		{
			item.vmethod_1(setting_0, framework_0, framework_1, list_1, list_0, bool_0);
		}
	}
}
