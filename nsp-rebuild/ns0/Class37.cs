using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using NSP.SettingsFramework;
using ns3;
using ns4;
using ns6;
using ns7;

namespace ns0;

internal class Class37
{
	internal class Class38
	{
		internal Class39 BHe;

		internal Class38(ref string string_0)
		{
			BHe = method_0(string_0);
		}

		internal Class39 method_0(string string_0)
		{
			Class39 @class = new Class39();
			int num = 0;
			int num2 = 20;
			bool flag = false;
			if (string_0.Length == 0)
			{
				return null;
			}
			if (string_0[string_0.Length - 1] == ')')
			{
				int num3 = 0;
				int num4 = string_0.Length - 1;
				while (num4 >= 0)
				{
					switch (string_0[num4])
					{
					case ')':
						num3++;
						break;
					case '(':
						num3--;
						break;
					}
					if (num4 != 0)
					{
						if (num3 != 0)
						{
							num4--;
							continue;
						}
						while (num4 > 0 && smethod_0(string_0[num4 - 1]))
						{
							num4--;
						}
						if (smethod_0(string_0[0]) && num4 == 0)
						{
							@class.BHG = method_0(string_0.Substring(1, string_0.Length - 1));
							@class.BHg = string_0[num4];
						}
						else
						{
							if (string_0[num4 - 1] != ':')
							{
								if (smethod_1(string_0[num4 - 1]) == 0)
								{
									return null;
								}
								Class39 class2 = method_0(string_0.Substring(num4, string_0.Length - num4));
								if (class2 == null)
								{
									return null;
								}
								string text = string_0.Substring(0, num4);
								string text2 = ((class2.BHH >= 0L) ? string.Format(Class333.aGj(), class2.BHH) : string.Format(Class333.BAn(), -class2.BHH));
								return method_0(text + text2);
							}
							int num5 = num4 - 1;
							while (num5 > 0 && string_0[num5] != '?')
							{
								num5--;
							}
							if (num5 == 0)
							{
								return null;
							}
							if (method_0(string_0.Substring(0, num5)).BHH != 0L)
							{
								@class.BHG = method_0(string_0.Substring(num5 + 1, num4 - num5 - 2));
							}
							else
							{
								@class.BHG = method_0(string_0.Substring(num4, string_0.Length - num4));
							}
							@class.BHg = 'P';
						}
						if (@class.BHG == null && (@class.BHF == null || @class.BHf == null))
						{
							return null;
						}
						@class.method_0();
						return @class;
					}
					return method_0(string_0.Substring(1, string_0.Length - 2));
				}
			}
			int num6 = 0;
			for (int num4 = string_0.Length - 1; num4 >= 0; num4--)
			{
				switch (string_0[num4])
				{
				case ')':
					num6++;
					break;
				case '(':
					num6--;
					break;
				}
				if (num6 == 0)
				{
					int num7 = smethod_1(string_0[num4]);
					if (num7 != 0 && !smethod_0(string_0[num4]))
					{
						flag = true;
						if (num7 < num2)
						{
							num = num4;
							num2 = num7;
						}
					}
				}
			}
			if (flag && num == 0)
			{
				if (!smethod_0(string_0[0]))
				{
					return null;
				}
				flag = false;
			}
			if (flag)
			{
				if (string_0[num] == ':')
				{
					int num8 = num;
					while (num8 > 0 && string_0[num8] != '?')
					{
						num8--;
					}
					if (num8 == 0)
					{
						return null;
					}
					if (method_0(string_0.Substring(0, num8)).BHH != 0L)
					{
						@class.BHG = method_0(string_0.Substring(num8 + 1, num - num8 - 1));
					}
					else
					{
						@class.BHG = method_0(string_0.Substring(num + 1, string_0.Length - num - 1));
					}
					@class.BHg = 'P';
				}
				else
				{
					@class.BHF = method_0(string_0.Substring(0, num));
					@class.BHf = method_0(string_0.Substring(num + 1, string_0.Length - num - 1));
					if (@class.BHF == null || @class.BHf == null)
					{
						return null;
					}
					@class.BHg = string_0[num];
				}
				if (@class.BHG == null && (@class.BHF == null || @class.BHf == null))
				{
					return null;
				}
				@class.method_0();
				return @class;
			}
			if (smethod_0(string_0[0]))
			{
				@class.BHg = string_0[0];
				@class.BHG = method_0(string_0.Substring(1, string_0.Length - 1));
				if (@class.BHG == null)
				{
					return null;
				}
				@class.method_0();
			}
			else if (string_0.Contains(Class333.smethod_190()))
			{
				float num9 = float.Parse(string_0, NumberStyles.Any, CultureInfo.InvariantCulture);
				@class.BHH = (int)num9;
			}
			else
			{
				@class.BHH = long.Parse(string_0);
			}
			return @class;
		}

		internal static bool smethod_0(char char_0)
		{
			if (char_0 != 'P' && char_0 != 'M' && char_0 != '!')
			{
				return char_0 == '~';
			}
			return true;
		}

		internal static int smethod_1(char char_0)
		{
			switch (char_0)
			{
			case ':':
				return 1;
			case 'A':
				return 3;
			case '&':
				return 6;
			case '+':
			case '-':
				return 10;
			case '%':
			case '*':
			case '/':
				return 11;
			case '^':
				return 5;
			case '=':
			case 'N':
				return 7;
			case 'O':
				return 2;
			case 'L':
			case 'R':
				return 9;
			case '<':
			case '>':
			case 'G':
			case 'S':
				return 8;
			case '!':
			case 'M':
			case 'P':
			case '~':
				return 12;
			default:
				return 0;
			case '|':
				return 4;
			}
		}
	}

	internal class Class39
	{
		internal Class39 BHF;

		internal Class39 BHf;

		internal Class39 BHG;

		internal char BHg;

		internal long BHH;

		internal void method_0()
		{
			switch (BHg)
			{
			case '<':
				BHH = ((BHF.BHH < BHf.BHH) ? 1 : 0);
				break;
			case '=':
				BHH = ((BHF.BHH == BHf.BHH) ? 1 : 0);
				break;
			case '>':
				BHH = ((BHF.BHH > BHf.BHH) ? 1 : 0);
				break;
			case 'A':
				BHH = ((BHF.BHH != 0L && BHf.BHH != 0L) ? 1 : 0);
				break;
			case '%':
				BHH = BHF.BHH % BHf.BHH;
				break;
			case '&':
				BHH = BHF.BHH & BHf.BHH;
				break;
			case '*':
				BHH = BHF.BHH * BHf.BHH;
				break;
			case '+':
				BHH = BHF.BHH + BHf.BHH;
				break;
			case '-':
				BHH = BHF.BHH - BHf.BHH;
				break;
			case '/':
				if (BHf.BHH != 0L)
				{
					BHH = BHF.BHH / BHf.BHH;
				}
				break;
			case '!':
				BHH = ((BHG.BHH == 0L) ? 1 : 0);
				break;
			case '^':
				BHH = BHF.BHH ^ BHf.BHH;
				break;
			case 'G':
				BHH = ((BHF.BHH >= BHf.BHH) ? 1 : 0);
				break;
			case 'L':
				BHH = BHF.BHH << (int)BHf.BHH;
				break;
			case 'M':
				BHH = -BHG.BHH;
				break;
			case 'N':
				BHH = ((BHF.BHH != BHf.BHH) ? 1 : 0);
				break;
			case 'O':
				BHH = ((BHF.BHH != 0L || BHf.BHH != 0L) ? 1 : 0);
				break;
			case 'P':
				BHH = BHG.BHH;
				break;
			case 'R':
				BHH = BHF.BHH >> (int)BHf.BHH;
				break;
			case 'S':
				BHH = ((BHF.BHH <= BHf.BHH) ? 1 : 0);
				break;
			case '~':
				BHH = ~BHG.BHH;
				break;
			case '|':
				BHH = BHF.BHH | BHf.BHH;
				break;
			}
		}
	}

	private enum Enum21
	{
		BHh,
		BHI,
		BHi,
		BHJ
	}

	internal static List<int> smethod_0(ref string string_0, Framework framework_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < string_0.Length; i++)
		{
			if (!char.IsWhiteSpace(string_0[i]))
			{
				stringBuilder.Append(string_0[i]);
			}
		}
		string_0 = stringBuilder.ToString();
		smethod_6(ref string_0, framework_0);
		smethod_7(ref string_0, framework_0);
		smethod_8(ref string_0, framework_0);
		smethod_9(ref string_0, framework_0);
		StringBuilder stringBuilder2 = new StringBuilder(100);
		StringBuilder stringBuilder3 = new StringBuilder();
		StringBuilder[] array = new StringBuilder[3];
		StringBuilder stringBuilder4 = new StringBuilder();
		StringBuilder stringBuilder5 = new StringBuilder();
		StringBuilder stringBuilder6 = new StringBuilder();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool bool_ = false;
		int num = 0;
		for (int j = 0; j < array.Length; j++)
		{
			array[j] = new StringBuilder();
		}
		List<int> list = new List<int>();
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] == 's')
			{
				if (flag = !flag)
				{
					continue;
				}
				int num2 = int.Parse(stringBuilder3.ToString());
				Setting setting_ = framework_0.method_31(num2);
				list.Add(num2);
				int num3 = 0;
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Length != 0)
					{
						num3++;
					}
				}
				int int_;
				int int_2;
				int int_3;
				switch (num3)
				{
				default:
					int_ = 0;
					int_2 = 0;
					int_3 = 0;
					break;
				case 1:
					int_ = 0;
					int_2 = 0;
					int_3 = int.Parse(array[0].ToString());
					break;
				case 2:
					int_ = 0;
					int_2 = int.Parse(array[0].ToString());
					int_3 = int.Parse(array[1].ToString());
					break;
				case 3:
					int_ = int.Parse(array[0].ToString());
					int_2 = int.Parse(array[1].ToString());
					int_3 = int.Parse(array[2].ToString());
					break;
				}
				if (flag3)
				{
					smethod_3(framework_0, setting_, stringBuilder4.ToString(), stringBuilder2);
				}
				else if (flag4)
				{
					smethod_4(framework_0, setting_, ushort.Parse(stringBuilder5.ToString()), stringBuilder2);
				}
				else if (flag5)
				{
					smethod_5(framework_0, setting_, bool_, int.Parse(stringBuilder6.ToString()), stringBuilder2);
				}
				else
				{
					smethod_2(framework_0, setting_, bool_, int_3, int_2, int_, stringBuilder2);
				}
				num = 0;
				flag2 = false;
				flag3 = false;
				flag4 = false;
				flag5 = false;
				bool_ = false;
				stringBuilder3.Clear();
				stringBuilder4.Clear();
				stringBuilder5.Clear();
				stringBuilder6.Clear();
				for (int j = 0; j < array.Length; j++)
				{
					array[j].Clear();
				}
			}
			else if (flag && !flag3 && string_0[i] == 'e')
			{
				num++;
				flag2 = true;
			}
			else if (flag && ((string_0[i] == '-' && string_0.Length > i + 1 && string_0[i + 1] == '>') || (string_0[i] == '>' && i > 0 && string_0[i - 1] == '-')))
			{
				flag3 = true;
			}
			else if (flag && !flag3 && ((string_0[i] == 'c' && string_0.Length > i + 1 && string_0[i + 1] == 'f') || (string_0[i] == 'f' && i > 0 && string_0[i - 1] == 'c')))
			{
				flag4 = true;
			}
			else if (flag && !flag3 && ((string_0[i] == 'u' && string_0.Length > i + 1 && string_0[i + 1] == 't') || (string_0[i] == 't' && i > 0 && string_0[i - 1] == 'u')))
			{
				flag5 = true;
			}
			else if (flag && !flag3 && ((string_0[i] == 'p' && string_0.Length > i + 2 && string_0[i + 1] == 't' && string_0[i + 2] == 'r') || (string_0[i] == 't' && i > 0 && string_0[i - 1] == 'p' && string_0.Length > i + 1 && string_0[i + 1] == 'r') || (string_0[i] == 'r' && i > 1 && string_0[i - 2] == 'p' && string_0[i - 1] == 't')))
			{
				bool_ = true;
			}
			else if (flag)
			{
				if (flag2)
				{
					array[num - 1].Append(string_0[i]);
				}
				else if (flag3)
				{
					stringBuilder4.Append(string_0[i]);
				}
				else if (flag4)
				{
					stringBuilder5.Append(string_0[i]);
				}
				else if (flag5)
				{
					stringBuilder6.Append(string_0[i]);
				}
				else
				{
					stringBuilder3.Append(string_0[i]);
				}
			}
			else
			{
				smethod_1(ref string_0, i, stringBuilder2);
			}
		}
		string_0 = stringBuilder2.ToString();
		return list;
	}

	private static void smethod_1(ref string string_0, int int_0, StringBuilder stringBuilder_0)
	{
		if (int_0 > 0)
		{
			if (string_0[int_0 - 1] == '>' && string_0[int_0] == '>')
			{
				stringBuilder_0[stringBuilder_0.Length - 1] = 'R';
			}
			else if (string_0[int_0 - 1] == '<' && string_0[int_0] == '<')
			{
				stringBuilder_0[stringBuilder_0.Length - 1] = 'L';
			}
			else if (string_0[int_0 - 1] == '&' && string_0[int_0] == '&')
			{
				stringBuilder_0[stringBuilder_0.Length - 1] = 'A';
			}
			else if (string_0[int_0 - 1] == '|' && string_0[int_0] == '|')
			{
				stringBuilder_0[stringBuilder_0.Length - 1] = 'O';
			}
			else if (string_0[int_0 - 1] == '>' && string_0[int_0] == '=')
			{
				stringBuilder_0[stringBuilder_0.Length - 1] = 'G';
			}
			else if (string_0[int_0 - 1] == '<' && string_0[int_0] == '=')
			{
				stringBuilder_0[stringBuilder_0.Length - 1] = 'S';
			}
			else if (string_0[int_0 - 1] == '!' && string_0[int_0] == '=')
			{
				stringBuilder_0[stringBuilder_0.Length - 1] = 'N';
			}
			else if (string_0[int_0 - 1] == '=' && string_0[int_0] == '=')
			{
				stringBuilder_0[stringBuilder_0.Length - 1] = '=';
			}
			else if (string_0[int_0] == '+' && (Class38.smethod_1(string_0[int_0 - 1]) != 0 || string_0[int_0 - 1] == '('))
			{
				stringBuilder_0.Append('P');
			}
			else if (string_0[int_0] == '-' && (Class38.smethod_1(string_0[int_0 - 1]) != 0 || string_0[int_0 - 1] == '('))
			{
				stringBuilder_0.Append('M');
			}
			else
			{
				stringBuilder_0.Append(string_0[int_0]);
			}
		}
		else if (string_0[int_0] == '+')
		{
			stringBuilder_0.Append('P');
		}
		else if (string_0[int_0] == '-')
		{
			stringBuilder_0.Append('M');
		}
		else
		{
			stringBuilder_0.Append(string_0[int_0]);
		}
	}

	private static void smethod_2(Framework framework_0, Setting setting_0, bool bool_0, int int_0, int int_1, int int_2, StringBuilder stringBuilder_0)
	{
		int num = 0;
		if (setting_0 != null)
		{
			if (bool_0)
			{
				int num2 = setting_0.method_256();
				if (num2 > 0)
				{
					Setting setting = framework_0.method_31(num2);
					if (setting != null)
					{
						num = setting.method_257(int_0, int_1, int_2);
					}
				}
			}
			else
			{
				num = setting_0.method_257(int_0, int_1, int_2);
			}
		}
		string value = num.ToString().Replace(Class333.smethod_186(), Class333.smethod_218());
		stringBuilder_0.Append(value);
	}

	private static void smethod_3(Framework framework_0, Setting setting_0, string string_0, StringBuilder stringBuilder_0)
	{
		Setting setting = null;
		if (setting_0 is Class244 @class)
		{
			int uint_ = @class.method_256();
			Enum104 enum104_ = PortFunction.smethod_12((uint)uint_);
			Enum105 enum105_ = PortFunction.smethod_13((uint)uint_);
			byte byte_ = PortFunction.smethod_14((uint)uint_);
			ushort ushort_ = PortFunction.smethod_15((uint)uint_);
			SettingOrSpecialObject settingOrSpecialObject = PortFunction.smethod_36(framework_0, enum104_, enum105_, byte_, ushort_);
			if (settingOrSpecialObject != null)
			{
				for (int i = 0; i < settingOrSpecialObject.method_1().Count; i++)
				{
					SettingOrSpecialObject settingOrSpecialObject2 = settingOrSpecialObject.method_1()[i];
					if (settingOrSpecialObject2 is Setting setting2 && settingOrSpecialObject2.method_35() && settingOrSpecialObject2.method_2() == string_0)
					{
						setting = setting2;
						break;
					}
				}
			}
		}
		int num = 0;
		if (setting != null)
		{
			num = setting.method_256();
		}
		string value = num.ToString().Replace(Class333.smethod_186(), Class333.smethod_218());
		stringBuilder_0.Append(value);
	}

	private static void smethod_4(Framework framework_0, Setting setting_0, ushort ushort_0, StringBuilder stringBuilder_0)
	{
		int num = 0;
		if (setting_0 != null && setting_0.method_6() != null && PortFunction.smethod_27(setting_0.method_6()))
		{
			PortFunction.Class273 @class = setting_0.method_6().method_12().method_12();
			List<Class244> list = PortFunction.smethod_44(framework_0, @class.BSQ, @class.BSq, @class.BSR, @class.BSr, bool_0: false);
			if (list != null && list.Count == 1)
			{
				Class244 class2 = list[0];
				if (class2.method_12().method_16().Count == 0)
				{
					num = 1;
				}
				else
				{
					Enum106 @enum = PortFunction.smethod_18(ushort_0);
					Enum107 enum2 = PortFunction.smethod_19(ushort_0);
					foreach (PortFunction.Class271 item in class2.method_12().method_16())
					{
						if (item.BSK == @enum && item.BSk == enum2)
						{
							num = 1;
							break;
						}
					}
				}
			}
		}
		string value = num.ToString();
		stringBuilder_0.Append(value);
	}

	private static void smethod_5(Framework framework_0, Setting setting_0, bool bool_0, int int_0, StringBuilder stringBuilder_0)
	{
		int num = 0;
		if (setting_0 != null)
		{
			if (bool_0)
			{
				int num2 = setting_0.method_256();
				if (num2 > 0)
				{
					Setting setting = framework_0.method_31(num2);
					if (setting != null && setting.method_231() == int_0)
					{
						num = 1;
					}
				}
			}
			else if (setting_0.method_231() == int_0)
			{
				num = 1;
			}
		}
		string value = num.ToString();
		stringBuilder_0.Append(value);
	}

	private static void smethod_6(ref string string_0, Framework framework_0)
	{
		while (true)
		{
			if (!string_0.Contains(Class333.smethod_219()))
			{
				return;
			}
			int num = string_0.IndexOf(Class333.smethod_219());
			int num2 = num + 5;
			int num3 = string_0.IndexOf(Class333.smethod_220(), num2);
			int num4 = string_0.IndexOf(Class333.smethod_221(), num2);
			string key;
			int num5;
			if (num3 != -1)
			{
				key = string_0.Substring(num2, num3 - num2);
				num5 = num3 + 2;
			}
			else
			{
				if (num4 == -1)
				{
					break;
				}
				key = string_0.Substring(num2, num4 - num2);
				num5 = num4 + 2;
			}
			if (framework_0.awn.ContainsKey(key))
			{
				Class258 @class = framework_0.awn[key];
				int num6 = string_0.IndexOf(')', num5);
				if (num6 != -1)
				{
					string oldValue = string_0.Substring(num, num6 + 1 - num);
					string text = string_0.Substring(num5, num6 - num5);
					Enum98 @enum = Enum98.ayB;
					if (text == Class333.smethod_223())
					{
						@enum = Enum98.ayc;
					}
					else if (text == Class333.smethod_224())
					{
						@enum = Enum98.ayD;
					}
					else if (text == Class333.smethod_225())
					{
						@enum = Enum98.ayb;
					}
					else
					{
						if (!(text == Class333.smethod_226()))
						{
							throw new Exception(Class333.smethod_222());
						}
						@enum = Enum98.ayC;
					}
					if (num4 != -1)
					{
						if (@class.method_1() != @enum)
						{
							string_0 = string_0.Replace(oldValue, Class333.smethod_227());
						}
						else
						{
							string_0 = string_0.Replace(oldValue, Class333.smethod_184());
						}
					}
					else if (@class.method_1() == @enum)
					{
						string_0 = string_0.Replace(oldValue, Class333.smethod_227());
					}
					else
					{
						string_0 = string_0.Replace(oldValue, Class333.smethod_184());
					}
					continue;
				}
				throw new Exception(Class333.smethod_222());
			}
			throw new Exception(Class333.smethod_222());
		}
		throw new Exception(Class333.smethod_222());
	}

	private static void smethod_7(ref string string_0, Framework framework_0)
	{
		while (true)
		{
			if (!string_0.Contains(Class333.smethod_228()))
			{
				return;
			}
			int num = string_0.IndexOf(Class333.smethod_228());
			int num2 = num + 4;
			int num3 = string_0.IndexOf(Class333.smethod_220(), num2);
			int num4 = string_0.IndexOf(Class333.smethod_221(), num2);
			string string_1;
			int num5;
			if (num3 != -1)
			{
				string_1 = string_0.Substring(num2, num3 - num2);
				num5 = num3 + 2;
			}
			else
			{
				if (num4 == -1)
				{
					break;
				}
				string_1 = string_0.Substring(num2, num4 - num2);
				num5 = num4 + 2;
			}
			int num6 = string_0.IndexOf(')', num5);
			if (num6 != -1)
			{
				string oldValue = string_0.Substring(num, num6 + 1 - num);
				string text = string_0.Substring(num5, num6 - num5);
				bool flag = Form23.smethod_38(string_1);
				bool flag2 = Form23.smethod_39(string_1);
				bool flag3;
				if (text == Class333.smethod_230())
				{
					flag3 = flag;
				}
				else if (text == Class333.smethod_231())
				{
					flag3 = flag2;
				}
				else
				{
					if (!(text == Class333.smethod_232()))
					{
						throw new Exception(Class333.smethod_229());
					}
					flag3 = !flag && !flag2;
				}
				if (num4 != -1)
				{
					if (!flag3)
					{
						string_0 = string_0.Replace(oldValue, Class333.smethod_227());
					}
					else
					{
						string_0 = string_0.Replace(oldValue, Class333.smethod_184());
					}
				}
				else if (flag3)
				{
					string_0 = string_0.Replace(oldValue, Class333.smethod_227());
				}
				else
				{
					string_0 = string_0.Replace(oldValue, Class333.smethod_184());
				}
				continue;
			}
			throw new Exception(Class333.smethod_229());
		}
		throw new Exception(Class333.smethod_229());
	}

	private static void smethod_8(ref string string_0, Framework framework_0)
	{
		while (true)
		{
			if (!string_0.Contains(Class333.smethod_233()))
			{
				return;
			}
			int num = string_0.IndexOf(Class333.smethod_233());
			int num2 = num + 5;
			int num3 = string_0.IndexOf(Class333.smethod_234(), num2);
			if (num3 != -1)
			{
				int num4 = string_0.IndexOf(Class333.smethod_236(), num3);
				if (num4 != -1)
				{
					int num5 = string_0.IndexOf(Class333.smethod_220(), num4);
					if (num5 != -1)
					{
						int num6 = num5 + 2;
						string key = string_0.Substring(num2, num3 - num2);
						string text = string_0.Substring(num3 + 2, num4 - (num3 + 2));
						if (!framework_0.awn.ContainsKey(key))
						{
							break;
						}
						Class258 @class = framework_0.awn[key];
						int num7 = string_0.IndexOf(')', num6);
						if (num7 != -1)
						{
							string oldValue = string_0.Substring(num, num7 + 1 - num);
							string text2 = string_0.Substring(num6, num7 - num6);
							if (text == Class333.smethod_223())
							{
								if (@class.method_14() != null)
								{
									if (@class.method_14().method_4() != null && @class.method_14().method_4().ToLower() == text2.ToLower())
									{
										string_0 = string_0.Replace(oldValue, Class333.smethod_227());
									}
									else
									{
										string_0 = string_0.Replace(oldValue, Class333.smethod_184());
									}
									continue;
								}
								throw new Exception(Class333.smethod_235());
							}
							if (text.StartsWith(Class333.smethod_224()))
							{
								if (int.TryParse(text.Substring(4), out var result) && result < @class.method_16().Count)
								{
									if (@class.method_16()[result].method_4() != null && @class.method_16()[result].method_4().ToLower() == text2.ToLower())
									{
										string_0 = string_0.Replace(oldValue, Class333.smethod_227());
									}
									else
									{
										string_0 = string_0.Replace(oldValue, Class333.smethod_184());
									}
									continue;
								}
								throw new Exception(Class333.smethod_235());
							}
							throw new Exception(Class333.smethod_235());
						}
						throw new Exception(Class333.smethod_235());
					}
					throw new Exception(Class333.smethod_235());
				}
				throw new Exception(Class333.smethod_235());
			}
			throw new Exception(Class333.smethod_235());
		}
		throw new Exception(Class333.smethod_235());
	}

	private static void smethod_9(ref string string_0, Framework framework_0)
	{
		while (true)
		{
			if (!string_0.Contains(Class333.smethod_237()))
			{
				return;
			}
			int num = string_0.IndexOf(Class333.smethod_237());
			int num2 = num + 6;
			int num3 = string_0.IndexOf(',', num2);
			if (num3 != -1)
			{
				string text = string_0.Substring(num2, num3 - num2).Trim();
				bool flag = false;
				if (text.StartsWith('s'))
				{
					int num4 = text.IndexOf('s', 1);
					if (num4 == -1)
					{
						throw new Exception(Class333.smethod_239());
					}
					int int_ = int.Parse(text.Substring(1, num4 - 1));
					Setting setting = framework_0.method_31(int_);
					if (setting == null)
					{
						flag = true;
					}
					else
					{
						text = setting.method_260();
					}
				}
				else
				{
					if (!text.StartsWith('\''))
					{
						break;
					}
					int num5 = text.IndexOf('\'');
					int num6 = text.IndexOf('\'', num5 + 1);
					if (num6 == -1)
					{
						throw new Exception(Class333.smethod_239());
					}
					text = text.Substring(num5 + 1, num6 - num5 - 1);
				}
				int num7 = string_0.IndexOf(',', num2);
				if (num7 != -1)
				{
					int num8 = string_0.IndexOf(',', num7 + 1);
					if (num8 != -1)
					{
						Enum21 @enum = (Enum21)int.Parse(string_0.Substring(num7 + 1, num8 - num7 - 1));
						if (Enum.IsDefined(typeof(Enum21), @enum))
						{
							int num9 = string_0.IndexOf(')', num8 + 1);
							string text2 = string_0.Substring(num8 + 1, num9 - num8 - 1).Trim();
							if (text2.StartsWith('s'))
							{
								int num10 = text2.IndexOf('s', 1);
								if (num10 == -1)
								{
									throw new Exception(Class333.smethod_244());
								}
								int int_2 = int.Parse(text2.Substring(1, num10 - 1));
								Setting setting2 = framework_0.method_31(int_2);
								if (setting2 == null)
								{
									flag = true;
								}
								else
								{
									text2 = setting2.method_260();
								}
							}
							else if (text2.StartsWith('\''))
							{
								int num11 = text2.IndexOf('\'');
								int num12 = text2.IndexOf('\'', num11 + 1);
								if (num12 == -1)
								{
									throw new Exception(Class333.smethod_244());
								}
								text2 = text2.Substring(num11 + 1, num12 - num11 - 1);
							}
							string oldValue = string_0.Substring(num, num9 - num + 1);
							if (!flag)
							{
								switch (@enum)
								{
								case Enum21.BHh:
									if (text == text2)
									{
										flag = true;
									}
									break;
								case Enum21.BHI:
									if (text.Contains(text2))
									{
										flag = true;
									}
									break;
								case Enum21.BHi:
									if (text.StartsWith(text2))
									{
										flag = true;
									}
									break;
								case Enum21.BHJ:
									if (text.EndsWith(text2))
									{
										flag = true;
									}
									break;
								}
							}
							if (flag)
							{
								string_0 = string_0.Replace(oldValue, Class333.smethod_227());
							}
							else
							{
								string_0 = string_0.Replace(oldValue, Class333.smethod_184());
							}
							continue;
						}
						throw new Exception(Class333.smethod_243());
					}
					throw new Exception(Class333.smethod_242());
				}
				throw new Exception(Class333.smethod_241());
			}
			throw new Exception(Class333.smethod_238());
		}
		throw new Exception(Class333.smethod_240());
	}

	internal static bool smethod_10(ref string string_0)
	{
		Class38 @class = new Class38(ref string_0);
		if (@class == null || @class.BHe == null)
		{
			@class = new Class38(ref string_0);
			throw new Exception(Class333.smethod_245());
		}
		return (ulong)@class.BHe.BHH > 0uL;
	}

	internal static int smethod_11(ref string string_0)
	{
		Class38 @class = new Class38(ref string_0);
		if (@class == null || @class.BHe == null)
		{
			@class = new Class38(ref string_0);
			throw new Exception(Class333.smethod_245());
		}
		return (int)@class.BHe.BHH;
	}
}
