using System.Runtime.CompilerServices;

namespace ns2;

internal class Class142
{
	private string string_0;

	private int int_0;

	private Enum41 enum41_0;

	[SpecialName]
	internal string method_0()
	{
		return string_0;
	}

	[SpecialName]
	internal void method_1(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	internal int method_2()
	{
		return int_0;
	}

	[SpecialName]
	internal void method_3(int int_1)
	{
		int_0 = int_1;
	}

	[SpecialName]
	internal Enum41 method_4()
	{
		return enum41_0;
	}

	[SpecialName]
	internal void method_5(Enum41 enum41_1)
	{
		enum41_0 = enum41_1;
	}

	internal Class142(string string_1, int int_1, Enum41 enum41_1)
	{
		string_0 = string_1;
		int_0 = int_1;
		enum41_0 = enum41_1;
	}
}
