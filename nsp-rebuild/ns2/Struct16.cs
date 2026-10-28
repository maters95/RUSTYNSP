using System.Runtime.CompilerServices;
using NSP.SettingsFramework;

namespace ns2;

internal struct Struct16
{
	internal int int_0;

	internal Setting setting_0;

	internal static readonly Struct16 struct16_0 = new Struct16(0, null);

	[SpecialName]
	internal bool method_0()
	{
		return int_0 != 0;
	}

	internal Struct16(int int_1, Setting setting_1)
	{
		int_0 = int_1;
		setting_0 = setting_1;
	}
}
