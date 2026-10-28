using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns0;
using ns7;

namespace ns6;

internal class Class260
{
	private Class258 ayn;

	private Framework ayO;

	private string ayo;

	private string ayP;

	private string ayp;

	private string ayQ;

	private bool ayq;

	internal Class260(Class258 class258_0, Framework framework_0, string string_0)
	{
		ayn = class258_0;
		ayO = framework_0;
		ayo = string_0;
	}

	public override string ToString()
	{
		return Class333.aoJ() + ((!string.IsNullOrEmpty(ayo)) ? (Class333.aoh() + ayo) : string.Empty) + Class333.smethod_325() + ((!string.IsNullOrEmpty(ayP)) ? (Class333.aoi() + ayP) : string.Empty);
	}

	[SpecialName]
	internal Class258 method_0()
	{
		return ayn;
	}

	[SpecialName]
	internal string method_1()
	{
		return ayo;
	}

	[SpecialName]
	internal string method_2()
	{
		return ayp;
	}

	[SpecialName]
	internal void method_3(string string_0)
	{
		ayp = string_0;
	}

	[SpecialName]
	internal string method_4()
	{
		return ayQ;
	}

	[SpecialName]
	internal void method_5(string string_0)
	{
		ayQ = string_0;
	}

	[SpecialName]
	internal bool method_6()
	{
		return ayq;
	}

	[SpecialName]
	internal void method_7(bool bool_0)
	{
		ayq = bool_0;
	}

	[SpecialName]
	internal void method_8(string string_0)
	{
		ayP = string_0;
	}

	internal bool method_9()
	{
		if (string.IsNullOrEmpty(ayP))
		{
			return false;
		}
		string string_ = ayP;
		Class37.smethod_0(ref string_, ayO);
		return Class37.smethod_10(ref string_);
	}
}
