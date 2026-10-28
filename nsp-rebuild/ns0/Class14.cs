using System.Runtime.CompilerServices;
using ns1;
using ns7;

namespace ns0;

internal class Class14
{
	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	internal Class14(string string_0, bool bool_0)
	{
		string text = string_0.ToLower();
		string text2 = ((text == null || text.Length <= 1 || text[0] != 'v') ? text : text.Substring(1, text.Length - 1));
		string[] array = text2.Split(Class333.smethod_125().ToCharArray());
		int num = 0;
		if (bool_0)
		{
			num = 1;
		}
		int_0 = int.Parse(array[num++].Trim());
		int_1 = int.Parse(array[num++].Trim());
		int_2 = 0;
		if (array.Length > num)
		{
			int_2 = int.Parse(array[num++].Trim());
		}
		if (array.Length > num)
		{
			if (int.TryParse(array[num++].Trim(), out var result))
			{
				int_3 = result;
			}
			else if (text2.Contains(Class333.smethod_126()))
			{
				int_3 = 0;
			}
			else
			{
				string text3 = null;
				int num2 = 0;
				if (text2.Contains(Class333.smethod_127()))
				{
					text3 = text2.Substring(text2.IndexOf(Class333.smethod_127()) + 5);
				}
				else if (text2.Contains(Class333.smethod_128()))
				{
					text3 = text2.Substring(text2.IndexOf(Class333.smethod_128()) + 4);
					num2 = 100;
				}
				else if (text2.Contains(Class333.smethod_129()))
				{
					text3 = text2.Substring(text2.IndexOf(Class333.smethod_129()) + 12);
					num2 = 200;
				}
				if (text3 != null)
				{
					if (text3.Contains(':'))
					{
						text3 = text3.Substring(0, text3.IndexOf(':'));
					}
					else if (text3.Contains('-'))
					{
						text3 = text3.Substring(0, text3.IndexOf('-'));
					}
					int_3 = int.Parse(text3.Trim()) + num2;
				}
			}
		}
		else
		{
			int_3 = 0;
		}
		int num3 = 0;
		if (text2.Contains(':'))
		{
			num3 = int.Parse(text2.Substring(text2.IndexOf(':') + 1).Trim());
		}
		else if (array.Length == 5)
		{
			num3 = int.Parse(array[4]);
		}
		int_4 = num3;
	}

	internal Class14(int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		int_0 = int_5;
		int_1 = int_6;
		int_2 = int_7;
		int_3 = int_8;
		int_4 = int_9;
	}

	public override string ToString()
	{
		string text;
		if (int_3 == 0)
		{
			text = Class333.smethod_130();
		}
		else if (int_3 <= 100)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_131());
			defaultInterpolatedStringHandler.AppendFormatted(int_3);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else if (int_3 <= 200)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_132());
			defaultInterpolatedStringHandler.AppendFormatted(int_3 - 100);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_133());
			defaultInterpolatedStringHandler.AppendFormatted(int_3 - 200);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		string text2 = string.Empty;
		if (int_4 != 0)
		{
			text2 = Class333.smethod_134() + int_4;
		}
		string format = Class333.smethod_135();
		Struct65<object> gparam_ = default;
		Class332.smethod_1<Struct65<object>, object>(ref gparam_, 0) = int_0;
		Class332.smethod_1<Struct65<object>, object>(ref gparam_, 1) = int_1.ToString(Class333.smethod_136());
		Class332.smethod_1<Struct65<object>, object>(ref gparam_, 2) = int_2;
		Class332.smethod_1<Struct65<object>, object>(ref gparam_, 3) = text;
		Class332.smethod_1<Struct65<object>, object>(ref gparam_, 4) = text2;
		return string.Format(format, Class332.smethod_0<Struct65<object>, object>(in gparam_, 5));
	}

	[SpecialName]
	internal int method_0()
	{
		return int_0;
	}

	[SpecialName]
	internal int method_1()
	{
		return int_1;
	}

	[SpecialName]
	internal int method_2()
	{
		return int_2;
	}

	[SpecialName]
	internal int method_3()
	{
		return int_3;
	}

	[SpecialName]
	internal int method_4()
	{
		return int_4;
	}

	[SpecialName]
	internal string method_5()
	{
		if (int_3 == 0)
		{
			return Class333.smethod_130();
		}
		if (int_3 <= 100)
		{
			return string.Format(Class333.smethod_137(), int_3);
		}
		if (int_3 <= 200)
		{
			return string.Format(Class333.smethod_138(), int_3 - 100);
		}
		return string.Format(Class333.smethod_139(), int_3 - 200);
	}

	[SpecialName]
	internal string method_6()
	{
		if (int_3 == 0)
		{
			return Class333.smethod_140();
		}
		if (int_3 <= 100)
		{
			return Class333.smethod_141();
		}
		if (int_3 <= 200)
		{
			return Class333.smethod_142();
		}
		return Class333.smethod_143();
	}

	[SpecialName]
	internal bool method_7()
	{
		return int_3 == 0;
	}

	[SpecialName]
	internal bool method_8()
	{
		if (int_0 == 0 && int_1 == 0 && int_2 == 0 && int_3 == 0)
		{
			return int_2 == 0;
		}
		return false;
	}

	public static bool operator ==(Class14 class14_0, Class14 class14_1)
	{
		if ((object)class14_0 != null && (object)class14_1 != null)
		{
			if (class14_0.method_0() == class14_1.method_0() && class14_0.method_1() == class14_1.method_1() && class14_0.method_2() == class14_1.method_2() && class14_0.method_3() == class14_1.method_3())
			{
				return class14_0.method_4() == class14_1.method_4();
			}
			return false;
		}
		return (object)class14_0 == class14_1;
	}

	public static bool operator !=(Class14 class14_0, Class14 class14_1)
	{
		return !(class14_0 == class14_1);
	}

	private static int smethod_0(int int_5)
	{
		int num = int_5;
		if (num == 0)
		{
			num = 201;
		}
		else if (num >= 201)
		{
			num++;
		}
		return num;
	}

	public static bool operator >(Class14 class14_0, Class14 class14_1)
	{
		if (class14_0.method_0() <= class14_1.method_0() && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() <= class14_1.method_1()) && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() != class14_1.method_1() || class14_0.method_2() <= class14_1.method_2()) && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() != class14_1.method_1() || class14_0.method_2() != class14_1.method_2() || smethod_0(class14_0.method_3()) <= smethod_0(class14_1.method_3())))
		{
			if (class14_0.method_0() == class14_1.method_0() && class14_0.method_1() == class14_1.method_1() && class14_0.method_2() == class14_1.method_2() && smethod_0(class14_0.method_3()) == smethod_0(class14_1.method_3()))
			{
				return class14_0.method_4() > class14_1.method_4();
			}
			return false;
		}
		return true;
	}

	public static bool operator >=(Class14 class14_0, Class14 class14_1)
	{
		if (class14_0.method_0() <= class14_1.method_0() && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() <= class14_1.method_1()) && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() != class14_1.method_1() || class14_0.method_2() <= class14_1.method_2()) && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() != class14_1.method_1() || class14_0.method_2() != class14_1.method_2() || smethod_0(class14_0.method_3()) <= smethod_0(class14_1.method_3())))
		{
			if (class14_0.method_0() == class14_1.method_0() && class14_0.method_1() == class14_1.method_1() && class14_0.method_2() == class14_1.method_2() && smethod_0(class14_0.method_3()) == smethod_0(class14_1.method_3()))
			{
				return class14_0.method_4() >= class14_1.method_4();
			}
			return false;
		}
		return true;
	}

	public static bool operator <(Class14 class14_0, Class14 class14_1)
	{
		if (class14_0.method_0() >= class14_1.method_0() && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() >= class14_1.method_1()) && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() != class14_1.method_1() || class14_0.method_2() >= class14_1.method_2()) && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() != class14_1.method_1() || class14_0.method_2() != class14_1.method_2() || smethod_0(class14_0.method_3()) >= smethod_0(class14_1.method_3())))
		{
			if (class14_0.method_0() == class14_1.method_0() && class14_0.method_1() == class14_1.method_1() && class14_0.method_2() == class14_1.method_2() && smethod_0(class14_0.method_3()) == smethod_0(class14_1.method_3()))
			{
				return class14_0.method_4() < class14_1.method_4();
			}
			return false;
		}
		return true;
	}

	public static bool operator <=(Class14 class14_0, Class14 class14_1)
	{
		if (class14_0.method_0() >= class14_1.method_0() && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() >= class14_1.method_1()) && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() != class14_1.method_1() || class14_0.method_2() >= class14_1.method_2()) && (class14_0.method_0() != class14_1.method_0() || class14_0.method_1() != class14_1.method_1() || class14_0.method_2() != class14_1.method_2() || smethod_0(class14_0.method_3()) >= smethod_0(class14_1.method_3())))
		{
			if (class14_0.method_0() == class14_1.method_0() && class14_0.method_1() == class14_1.method_1() && class14_0.method_2() == class14_1.method_2() && smethod_0(class14_0.method_3()) == smethod_0(class14_1.method_3()))
			{
				return class14_0.method_4() <= class14_1.method_4();
			}
			return false;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (obj == null)
		{
			return false;
		}
		if (obj is Class14)
		{
			return this == obj as Class14;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((byte)method_0() << 24) | ((byte)method_1() << 16) | ((byte)method_2() << 8) | (byte)method_3();
	}
}
