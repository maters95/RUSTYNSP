using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns6;

namespace NSP.SettingsFramework;

public class ModifyOnChange
{
	private Framework aZb;

	private int aZC;

	private List<Class261> aZc = new List<Class261>();

	internal ModifyOnChange(Framework framework_0, int int_0)
	{
		aZb = framework_0;
		aZC = int_0;
	}

	internal void method_0(Class261 class261_0)
	{
		aZc.Add(class261_0);
	}

	[SpecialName]
	internal Setting method_1()
	{
		return aZb.method_31(aZC);
	}

	internal List<Setting> method_2(bool bool_0)
	{
		List<Setting> list = new List<Setting>();
		foreach (Class261 item in aZc)
		{
			item.vmethod_0(bool_0);
			Setting setting = item.method_1(aZb);
			if (setting != null && !list.Contains(setting))
			{
				list.Add(setting);
			}
		}
		return list;
	}
}
