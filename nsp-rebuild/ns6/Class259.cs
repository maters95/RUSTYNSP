using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns0;
using ns7;

namespace ns6;

internal class Class259
{
	private Class258 ayK;

	private Framework ayk;

	private string ayL;

	private string ayl;

	private string ayM;

	private string aym;

	private bool ayN;

	internal Class259(Class258 class258_0, Framework framework_0, string string_0)
	{
		ayK = class258_0;
		ayk = framework_0;
		ayL = string_0;
	}

	public override string ToString()
	{
		return Class333.aoI() + ((!string.IsNullOrEmpty(ayL)) ? (Class333.aoh() + ayL) : string.Empty) + Class333.smethod_325() + ((!string.IsNullOrEmpty(ayl)) ? (Class333.aoi() + ayl) : string.Empty);
	}

	[SpecialName]
	internal Class258 method_0()
	{
		return ayK;
	}

	[SpecialName]
	internal string method_1()
	{
		return ayL;
	}

	[SpecialName]
	internal string method_2()
	{
		return ayM;
	}

	[SpecialName]
	internal void method_3(string string_0)
	{
		ayM = string_0;
	}

	[SpecialName]
	internal string method_4()
	{
		return aym;
	}

	[SpecialName]
	internal void method_5(string string_0)
	{
		aym = string_0;
	}

	[SpecialName]
	internal bool method_6()
	{
		return ayN;
	}

	[SpecialName]
	internal void method_7(bool bool_0)
	{
		ayN = bool_0;
	}

	[SpecialName]
	internal void method_8(string string_0)
	{
		ayl = string_0;
	}

	internal bool method_9()
	{
		if (string.IsNullOrEmpty(ayl))
		{
			return false;
		}
		string string_ = ayl;
		Class37.smethod_0(ref string_, ayk);
		return Class37.smethod_10(ref string_);
	}
}
