using System.Runtime.CompilerServices;

namespace ns4;

internal class Class223
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private Enum64 enum64_0;

	[SpecialName]
	[CompilerGenerated]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_2()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(string string_2)
	{
		string_1 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum64 method_4()
	{
		return enum64_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(Enum64 enum64_1)
	{
		enum64_0 = enum64_1;
	}

	public override int GetHashCode()
	{
		return (391 + (method_0()?.GetHashCode() ?? 0)) * 23 + method_4().GetHashCode();
	}
}
