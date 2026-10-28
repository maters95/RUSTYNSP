using System.Drawing;
using System.Runtime.CompilerServices;
using ns4;

namespace ns2;

internal class Class80
{
	[CompilerGenerated]
	private Color color_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[SpecialName]
	[CompilerGenerated]
	internal Color method_0()
	{
		return color_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(Color color_1)
	{
		color_0 = color_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool method_2()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(bool bool_2)
	{
		bool_0 = bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool method_4()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(bool bool_2)
	{
		bool_1 = bool_2;
	}

	internal Class80()
	{
		method_1(smethod_0(0));
		method_3(bool_2: false);
		method_5(bool_2: false);
	}

	public static Color smethod_0(int int_0)
	{
		return (Enum33)int_0 switch
		{
			Enum33.const_1 => Color.Blue, 
			Enum33.const_2 => Color.FromArgb(0, 255, 0), 
			Enum33.const_3 => Color.Cyan, 
			Enum33.const_4 => Color.Red, 
			Enum33.const_5 => Color.Magenta, 
			Enum33.const_6 => Color.Yellow, 
			Enum33.const_7 => Color.White, 
			_ => Form23.color_10, 
		};
	}
}
