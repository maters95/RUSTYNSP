using System.Collections.Generic;
using NSP.SettingsFramework;
using ns6;

namespace ns1;

internal class Class262 : Class261
{
	internal Class262(Framework framework_0, string string_0)
		: base(framework_0, null, string_0, null, null, -1, bool_0: false)
	{
	}

	public override void vmethod_1(Setting setting_0, Framework framework_0, Framework framework_1, List<int[]> list_0, List<int[]> list_1, bool bool_0)
	{
		if (method_2(setting_0, list_1, framework_0, framework_1) && setting_0.method_6() != null && setting_0.method_6().method_6() != null && setting_0.method_6() is TableAxis && setting_0.method_6().method_6() is Table)
		{
			TableAxis tableAxis = setting_0.method_6() as TableAxis;
			if (setting_0 == tableAxis.method_89())
			{
				(setting_0.method_6().method_6() as Table).SortByAxis(tableAxis.method_71(), bool_0);
			}
		}
	}
}
