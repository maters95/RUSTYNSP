using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;

namespace A;

internal class T
{
	internal class A
	{
		internal a BHe;

		internal A(ref string P_0)
		{
			BHe = A(P_0);
		}

		internal a A(string P_0)
		{
			a a2 = new a();
			int num = 0;
			int num2 = 20;
			bool flag = false;
			if (P_0.Length == 0)
			{
				return null;
			}
			if (P_0[P_0.Length - 1] == ')')
			{
				int num3 = 0;
				for (int num4 = P_0.Length - 1; num4 >= 0; num4--)
				{
					switch (P_0[num4])
					{
					case '(':
						num3--;
						break;
					case ')':
						num3++;
						break;
					}
					if (num4 == 0)
					{
						return A(P_0.Substring(1, P_0.Length - 2));
					}
					if (num3 == 0)
					{
						while (num4 > 0 && A(P_0[num4 - 1]))
						{
							num4--;
						}
						if (A(P_0[0]) && num4 == 0)
						{
							a2.BHG = A(P_0.Substring(1, P_0.Length - 1));
							a2.BHg = P_0[num4];
						}
						else
						{
							if (P_0[num4 - 1] != ':')
							{
								if (a(P_0[num4 - 1]) == 0)
								{
									return null;
								}
								a a3 = A(P_0.Substring(num4, P_0.Length - num4));
								if (a3 == null)
								{
									return null;
								}
								string text = P_0.Substring(0, num4);
								string text2 = ((a3.BHH >= 0) ? string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGj(), (object)a3.BHH) : string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAn(), (object)(-a3.BHH)));
								return A(text + text2);
							}
							int num5 = num4 - 1;
							while (num5 > 0 && P_0[num5] != '?')
							{
								num5--;
							}
							if (num5 == 0)
							{
								return null;
							}
							if (A(P_0.Substring(0, num5)).BHH != 0L)
							{
								a2.BHG = A(P_0.Substring(num5 + 1, num4 - num5 - 2));
							}
							else
							{
								a2.BHG = A(P_0.Substring(num4, P_0.Length - num4));
							}
							a2.BHg = 'P';
						}
						if (a2.BHG == null && (a2.BHF == null || a2.BHf == null))
						{
							return null;
						}
						a2.A();
						return a2;
					}
				}
			}
			int num6 = 0;
			for (int num4 = P_0.Length - 1; num4 >= 0; num4--)
			{
				switch (P_0[num4])
				{
				case '(':
					num6--;
					break;
				case ')':
					num6++;
					break;
				}
				if (num6 == 0)
				{
					int num7 = a(P_0[num4]);
					if (num7 != 0 && !A(P_0[num4]))
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
				if (!A(P_0[0]))
				{
					return null;
				}
				flag = false;
			}
			if (flag)
			{
				if (P_0[num] == ':')
				{
					int num8 = num;
					while (num8 > 0 && P_0[num8] != '?')
					{
						num8--;
					}
					if (num8 == 0)
					{
						return null;
					}
					if (A(P_0.Substring(0, num8)).BHH != 0L)
					{
						a2.BHG = A(P_0.Substring(num8 + 1, num - num8 - 1));
					}
					else
					{
						a2.BHG = A(P_0.Substring(num + 1, P_0.Length - num - 1));
					}
					a2.BHg = 'P';
				}
				else
				{
					a2.BHF = A(P_0.Substring(0, num));
					a2.BHf = A(P_0.Substring(num + 1, P_0.Length - num - 1));
					if (a2.BHF == null || a2.BHf == null)
					{
						return null;
					}
					a2.BHg = P_0[num];
				}
				if (a2.BHG == null && (a2.BHF == null || a2.BHf == null))
				{
					return null;
				}
				a2.A();
				return a2;
			}
			if (A(P_0[0]))
			{
				a2.BHg = P_0[0];
				a2.BHG = A(P_0.Substring(1, P_0.Length - 1));
				if (a2.BHG == null)
				{
					return null;
				}
				a2.A();
			}
			else if (P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()))
			{
				float num9 = float.Parse(P_0, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.InvariantCulture);
				a2.BHH = (int)num9;
			}
			else
			{
				a2.BHH = long.Parse(P_0);
			}
			return a2;
		}

		internal static bool A(char P_0)
		{
			if (P_0 != 'P' && P_0 != 'M' && P_0 != '!')
			{
				return P_0 == '~';
			}
			return true;
		}

		internal static int a(char P_0)
		{
			switch (P_0)
			{
			case '!':
			case 'M':
			case 'P':
			case '~':
				return 12;
			case '%':
			case '*':
			case '/':
				return 11;
			case '+':
			case '-':
				return 10;
			case 'L':
			case 'R':
				return 9;
			case '<':
			case '>':
			case 'G':
			case 'S':
				return 8;
			case '=':
			case 'N':
				return 7;
			case '&':
				return 6;
			case '^':
				return 5;
			case '|':
				return 4;
			case 'A':
				return 3;
			case 'O':
				return 2;
			case ':':
				return 1;
			default:
				return 0;
			}
		}
	}

	internal class a
	{
		internal a BHF;

		internal a BHf;

		internal a BHG;

		internal char BHg;

		internal long BHH;

		internal void A()
		{
			switch (BHg)
			{
			case '!':
				BHH = ((BHG.BHH == 0) ? 1 : 0);
				break;
			case '~':
				BHH = ~BHG.BHH;
				break;
			case 'P':
				BHH = BHG.BHH;
				break;
			case 'M':
				BHH = -BHG.BHH;
				break;
			case '*':
				BHH = BHF.BHH * BHf.BHH;
				break;
			case '/':
				if (BHf.BHH != 0L)
				{
					BHH = BHF.BHH / BHf.BHH;
				}
				break;
			case '%':
				BHH = BHF.BHH % BHf.BHH;
				break;
			case '+':
				BHH = BHF.BHH + BHf.BHH;
				break;
			case '-':
				BHH = BHF.BHH - BHf.BHH;
				break;
			case 'R':
				BHH = BHF.BHH >> (int)BHf.BHH;
				break;
			case 'L':
				BHH = BHF.BHH << (int)BHf.BHH;
				break;
			case '>':
				BHH = ((BHF.BHH > BHf.BHH) ? 1 : 0);
				break;
			case 'G':
				BHH = ((BHF.BHH >= BHf.BHH) ? 1 : 0);
				break;
			case '<':
				BHH = ((BHF.BHH < BHf.BHH) ? 1 : 0);
				break;
			case 'S':
				BHH = ((BHF.BHH <= BHf.BHH) ? 1 : 0);
				break;
			case '=':
				BHH = ((BHF.BHH == BHf.BHH) ? 1 : 0);
				break;
			case 'N':
				BHH = ((BHF.BHH != BHf.BHH) ? 1 : 0);
				break;
			case '&':
				BHH = BHF.BHH & BHf.BHH;
				break;
			case '^':
				BHH = BHF.BHH ^ BHf.BHH;
				break;
			case '|':
				BHH = BHF.BHH | BHf.BHH;
				break;
			case 'A':
				BHH = ((BHF.BHH != 0L && BHf.BHH != 0L) ? 1 : 0);
				break;
			case 'O':
				BHH = ((BHF.BHH != 0L || BHf.BHH != 0L) ? 1 : 0);
				break;
			}
		}
	}

	private enum B
	{
		BHh,
		BHI,
		BHi,
		BHJ
	}

	internal static List<int> A(ref string P_0, Framework P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		for (int num = 0; num < P_0.Length; num++)
		{
			if (!char.IsWhiteSpace(P_0[num]))
			{
				val.Append(P_0[num]);
			}
		}
		P_0 = ((object)val).ToString();
		a(ref P_0, P_1);
		B(ref P_0, P_1);
		b(ref P_0, P_1);
		C(ref P_0, P_1);
		StringBuilder val2 = new StringBuilder(100);
		StringBuilder val3 = new StringBuilder();
		StringBuilder[] array = (StringBuilder[])(object)new StringBuilder[3];
		StringBuilder val4 = new StringBuilder();
		StringBuilder val5 = new StringBuilder();
		StringBuilder val6 = new StringBuilder();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		int num2 = 0;
		for (int num3 = 0; num3 < array.Length; num3++)
		{
			array[num3] = new StringBuilder();
		}
		List<int> val7 = new List<int>();
		for (int num = 0; num < P_0.Length; num++)
		{
			if (P_0[num] == 's')
			{
				flag = !flag;
				if (flag)
				{
					continue;
				}
				int num4 = int.Parse(((object)val3).ToString());
				Setting setting = P_1.A(num4);
				val7.Add(num4);
				int num5 = 0;
				for (int num3 = 0; num3 < array.Length; num3++)
				{
					if (array[num3].Length != 0)
					{
						num5++;
					}
				}
				int num6;
				int num7;
				int num8;
				switch (num5)
				{
				case 1:
					num6 = 0;
					num7 = 0;
					num8 = int.Parse(((object)array[0]).ToString());
					break;
				case 2:
					num6 = 0;
					num7 = int.Parse(((object)array[0]).ToString());
					num8 = int.Parse(((object)array[1]).ToString());
					break;
				case 3:
					num6 = int.Parse(((object)array[0]).ToString());
					num7 = int.Parse(((object)array[1]).ToString());
					num8 = int.Parse(((object)array[2]).ToString());
					break;
				default:
					num6 = 0;
					num7 = 0;
					num8 = 0;
					break;
				}
				if (flag3)
				{
					A(P_1, setting, ((object)val4).ToString(), val2);
				}
				else if (flag4)
				{
					A(P_1, setting, ushort.Parse(((object)val5).ToString()), val2);
				}
				else if (flag5)
				{
					A(P_1, setting, flag6, int.Parse(((object)val6).ToString()), val2);
				}
				else
				{
					A(P_1, setting, flag6, num8, num7, num6, val2);
				}
				num2 = 0;
				flag2 = false;
				flag3 = false;
				flag4 = false;
				flag5 = false;
				flag6 = false;
				val3.Clear();
				val4.Clear();
				val5.Clear();
				val6.Clear();
				for (int num3 = 0; num3 < array.Length; num3++)
				{
					array[num3].Clear();
				}
			}
			else if (flag && !flag3 && P_0[num] == 'e')
			{
				num2++;
				flag2 = true;
			}
			else if (flag && ((P_0[num] == '-' && P_0.Length > num + 1 && P_0[num + 1] == '>') || (P_0[num] == '>' && num > 0 && P_0[num - 1] == '-')))
			{
				flag3 = true;
			}
			else if (flag && !flag3 && ((P_0[num] == 'c' && P_0.Length > num + 1 && P_0[num + 1] == 'f') || (P_0[num] == 'f' && num > 0 && P_0[num - 1] == 'c')))
			{
				flag4 = true;
			}
			else if (flag && !flag3 && ((P_0[num] == 'u' && P_0.Length > num + 1 && P_0[num + 1] == 't') || (P_0[num] == 't' && num > 0 && P_0[num - 1] == 'u')))
			{
				flag5 = true;
			}
			else if (flag && !flag3 && ((P_0[num] == 'p' && P_0.Length > num + 2 && P_0[num + 1] == 't' && P_0[num + 2] == 'r') || (P_0[num] == 't' && num > 0 && P_0[num - 1] == 'p' && P_0.Length > num + 1 && P_0[num + 1] == 'r') || (P_0[num] == 'r' && num > 1 && P_0[num - 2] == 'p' && P_0[num - 1] == 't')))
			{
				flag6 = true;
			}
			else if (flag)
			{
				if (flag2)
				{
					array[num2 - 1].Append(P_0[num]);
				}
				else if (flag3)
				{
					val4.Append(P_0[num]);
				}
				else if (flag4)
				{
					val5.Append(P_0[num]);
				}
				else if (flag5)
				{
					val6.Append(P_0[num]);
				}
				else
				{
					val3.Append(P_0[num]);
				}
			}
			else
			{
				A(ref P_0, num, val2);
			}
		}
		P_0 = ((object)val2).ToString();
		return val7;
	}

	private static void A(ref string P_0, int P_1, StringBuilder P_2)
	{
		if (P_1 > 0)
		{
			if (P_0[P_1 - 1] == '>' && P_0[P_1] == '>')
			{
				P_2[P_2.Length - 1] = 'R';
			}
			else if (P_0[P_1 - 1] == '<' && P_0[P_1] == '<')
			{
				P_2[P_2.Length - 1] = 'L';
			}
			else if (P_0[P_1 - 1] == '&' && P_0[P_1] == '&')
			{
				P_2[P_2.Length - 1] = 'A';
			}
			else if (P_0[P_1 - 1] == '|' && P_0[P_1] == '|')
			{
				P_2[P_2.Length - 1] = 'O';
			}
			else if (P_0[P_1 - 1] == '>' && P_0[P_1] == '=')
			{
				P_2[P_2.Length - 1] = 'G';
			}
			else if (P_0[P_1 - 1] == '<' && P_0[P_1] == '=')
			{
				P_2[P_2.Length - 1] = 'S';
			}
			else if (P_0[P_1 - 1] == '!' && P_0[P_1] == '=')
			{
				P_2[P_2.Length - 1] = 'N';
			}
			else if (P_0[P_1 - 1] == '=' && P_0[P_1] == '=')
			{
				P_2[P_2.Length - 1] = '=';
			}
			else if (P_0[P_1] == '+' && (T.A.a(P_0[P_1 - 1]) != 0 || P_0[P_1 - 1] == '('))
			{
				P_2.Append('P');
			}
			else if (P_0[P_1] == '-' && (T.A.a(P_0[P_1 - 1]) != 0 || P_0[P_1 - 1] == '('))
			{
				P_2.Append('M');
			}
			else
			{
				P_2.Append(P_0[P_1]);
			}
		}
		else if (P_0[P_1] == '+')
		{
			P_2.Append('P');
		}
		else if (P_0[P_1] == '-')
		{
			P_2.Append('M');
		}
		else
		{
			P_2.Append(P_0[P_1]);
		}
	}

	private static void A(Framework P_0, Setting P_1, bool P_2, int P_3, int P_4, int P_5, StringBuilder P_6)
	{
		int num = 0;
		if (P_1 != null)
		{
			if (P_2)
			{
				int num2 = P_1.ax();
				if (num2 > 0)
				{
					Setting setting = P_0.A(num2);
					if (setting != null)
					{
						num = setting.B(P_3, P_4, P_5);
					}
				}
			}
			else
			{
				num = P_1.B(P_3, P_4, P_5);
			}
		}
		string text = num.ToString().Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ce());
		P_6.Append(text);
	}

	private static void A(Framework P_0, Setting P_1, string P_2, StringBuilder P_3)
	{
		Setting setting = null;
		if (P_1 is Dn dn)
		{
			int num = dn.ax();
			Cg cg = PortFunction.A((uint)num);
			CH cH = PortFunction.a((uint)num);
			byte b2 = PortFunction.B((uint)num);
			ushort num2 = PortFunction.b((uint)num);
			SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(P_0, cg, cH, b2, num2);
			if (settingOrSpecialObject != null)
			{
				for (int num3 = 0; num3 < settingOrSpecialObject.a().Count; num3++)
				{
					SettingOrSpecialObject settingOrSpecialObject2 = settingOrSpecialObject.a()[num3];
					if (settingOrSpecialObject2 is Setting setting2 && settingOrSpecialObject2.l() && settingOrSpecialObject2.B() == P_2)
					{
						setting = setting2;
						break;
					}
				}
			}
		}
		int num4 = 0;
		if (setting != null)
		{
			num4 = setting.ax();
		}
		string text = num4.ToString().Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ce());
		P_3.Append(text);
	}

	private static void A(Framework P_0, Setting P_1, ushort P_2, StringBuilder P_3)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (P_1 != null && ((SettingOrSpecialObject)P_1).D() != null && PortFunction.a(((SettingOrSpecialObject)P_1).D()))
		{
			PortFunction.B b2 = ((SettingOrSpecialObject)P_1).D().F().E();
			List<Dn> val = PortFunction.A(P_0, b2.BSQ, b2.BSq, b2.BSR, b2.BSr, false);
			if (val != null && val.Count == 1)
			{
				Dn dn = val[0];
				if (((SettingOrSpecialObject)dn).F().F().Count == 0)
				{
					num = 1;
				}
				else
				{
					Ch ch = PortFunction.A(P_2);
					CI cI = PortFunction.a(P_2);
					Enumerator<PortFunction.A> enumerator = ((SettingOrSpecialObject)dn).F().F().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							PortFunction.A current = enumerator.Current;
							if (current.BSK == ch && current.BSk == cI)
							{
								num = 1;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
		}
		string text = num.ToString();
		P_3.Append(text);
	}

	private static void A(Framework P_0, Setting P_1, bool P_2, int P_3, StringBuilder P_4)
	{
		int num = 0;
		if (P_1 != null)
		{
			if (P_2)
			{
				int num2 = P_1.ax();
				if (num2 > 0)
				{
					Setting setting = P_0.A(num2);
					if (setting != null && setting.aS() == P_3)
					{
						num = 1;
					}
				}
			}
			else if (P_1.aS() == P_3)
			{
				num = 1;
			}
		}
		string text = num.ToString();
		P_4.Append(text);
	}

	private static void a(ref string P_0, Framework P_1)
	{
		while (P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CF()))
		{
			int num = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CF());
			int num2 = num + 5;
			int num3 = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cf(), num2);
			int num4 = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CG(), num2);
			string text;
			int num5;
			if (num3 != -1)
			{
				text = P_0.Substring(num2, num3 - num2);
				num5 = num3 + 2;
			}
			else
			{
				if (num4 == -1)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cg());
				}
				text = P_0.Substring(num2, num4 - num2);
				num5 = num4 + 2;
			}
			if (P_1.awn.ContainsKey(text))
			{
				CB cB = P_1.awn[text];
				int num6 = P_0.IndexOf(')', num5);
				if (num6 != -1)
				{
					string text2 = P_0.Substring(num, num6 + 1 - num);
					string text3 = P_0.Substring(num5, num6 - num5);
					Ca ca = Ca.ayB;
					if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CH())
					{
						ca = Ca.ayc;
					}
					else if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ch())
					{
						ca = Ca.ayD;
					}
					else if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CI())
					{
						ca = Ca.ayb;
					}
					else
					{
						if (!(text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ci()))
						{
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cg());
						}
						ca = Ca.ayC;
					}
					if (num4 != -1)
					{
						if (cB.a() != ca)
						{
							P_0 = P_0.Replace(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ());
						}
						else
						{
							P_0 = P_0.Replace(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
						}
					}
					else if (cB.a() == ca)
					{
						P_0 = P_0.Replace(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ());
					}
					else
					{
						P_0 = P_0.Replace(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
					}
					continue;
				}
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cg());
			}
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cg());
		}
	}

	private static void B(ref string P_0, Framework P_1)
	{
		while (P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cj()))
		{
			int num = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cj());
			int num2 = num + 4;
			int num3 = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cf(), num2);
			int num4 = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CG(), num2);
			string text;
			int num5;
			if (num3 != -1)
			{
				text = P_0.Substring(num2, num3 - num2);
				num5 = num3 + 2;
			}
			else
			{
				if (num4 == -1)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CK());
				}
				text = P_0.Substring(num2, num4 - num2);
				num5 = num4 + 2;
			}
			int num6 = P_0.IndexOf(')', num5);
			if (num6 != -1)
			{
				string text2 = P_0.Substring(num, num6 + 1 - num);
				string text3 = P_0.Substring(num5, num6 - num5);
				bool flag = BM.a(text);
				bool flag2 = BM.B(text);
				bool flag3;
				if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ck())
				{
					flag3 = flag;
				}
				else if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CL())
				{
					flag3 = flag2;
				}
				else
				{
					if (!(text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cl()))
					{
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CK());
					}
					flag3 = !flag && !flag2;
				}
				if (num4 != -1)
				{
					if (!flag3)
					{
						P_0 = P_0.Replace(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ());
					}
					else
					{
						P_0 = P_0.Replace(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
					}
				}
				else if (flag3)
				{
					P_0 = P_0.Replace(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ());
				}
				else
				{
					P_0 = P_0.Replace(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
				}
				continue;
			}
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CK());
		}
	}

	private static void b(ref string P_0, Framework P_1)
	{
		int num8 = default(int);
		while (P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CM()))
		{
			int num = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CM());
			int num2 = num + 5;
			int num3 = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cm(), num2);
			if (num3 == -1)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CN());
			}
			int num4 = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cn(), num3);
			if (num4 == -1)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CN());
			}
			int num5 = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cf(), num4);
			if (num5 == -1)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CN());
			}
			int num6 = num5 + 2;
			string text = P_0.Substring(num2, num3 - num2);
			string text2 = P_0.Substring(num3 + 2, num4 - (num3 + 2));
			if (P_1.awn.ContainsKey(text))
			{
				CB cB = P_1.awn[text];
				int num7 = P_0.IndexOf(')', num6);
				if (num7 != -1)
				{
					string text3 = P_0.Substring(num, num7 + 1 - num);
					string text4 = P_0.Substring(num6, num7 - num6);
					if (text2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CH())
					{
						if (cB.F() != null)
						{
							if (cB.F().b() != null && cB.F().b().ToLower() == text4.ToLower())
							{
								P_0 = P_0.Replace(text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ());
							}
							else
							{
								P_0 = P_0.Replace(text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
							}
							continue;
						}
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CN());
					}
					if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ch()))
					{
						if (int.TryParse(text2.Substring(4), ref num8) && num8 < cB.f().Count)
						{
							if (cB.f()[num8].b() != null && cB.f()[num8].b().ToLower() == text4.ToLower())
							{
								P_0 = P_0.Replace(text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ());
							}
							else
							{
								P_0 = P_0.Replace(text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
							}
							continue;
						}
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CN());
					}
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CN());
				}
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CN());
			}
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CN());
		}
	}

	private static void C(ref string P_0, Framework P_1)
	{
		while (P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CO()))
		{
			int num = P_0.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CO());
			int num2 = num + 6;
			int num3 = P_0.IndexOf(',', num2);
			if (num3 == -1)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Co());
			}
			string text = P_0.Substring(num2, num3 - num2).Trim();
			bool flag = false;
			if (text.StartsWith('s'))
			{
				int num4 = text.IndexOf('s', 1);
				if (num4 == -1)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CP());
				}
				int num5 = int.Parse(text.Substring(1, num4 - 1));
				Setting setting = P_1.A(num5);
				if (setting == null)
				{
					flag = true;
				}
				else
				{
					text = setting.ay();
				}
			}
			else
			{
				if (!text.StartsWith('\''))
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cp());
				}
				int num6 = text.IndexOf('\'');
				int num7 = text.IndexOf('\'', num6 + 1);
				if (num7 == -1)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CP());
				}
				text = text.Substring(num6 + 1, num7 - num6 - 1);
			}
			int num8 = P_0.IndexOf(',', num2);
			if (num8 == -1)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CQ());
			}
			int num9 = P_0.IndexOf(',', num8 + 1);
			if (num9 == -1)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cq());
			}
			B b2 = (B)int.Parse(P_0.Substring(num8 + 1, num9 - num8 - 1));
			if (!System.Enum.IsDefined(typeof(B), (object)b2))
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CR());
			}
			int num10 = P_0.IndexOf(')', num9 + 1);
			string text2 = P_0.Substring(num9 + 1, num10 - num9 - 1).Trim();
			if (text2.StartsWith('s'))
			{
				int num11 = text2.IndexOf('s', 1);
				if (num11 == -1)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cr());
				}
				int num12 = int.Parse(text2.Substring(1, num11 - 1));
				Setting setting2 = P_1.A(num12);
				if (setting2 == null)
				{
					flag = true;
				}
				else
				{
					text2 = setting2.ay();
				}
			}
			else if (text2.StartsWith('\''))
			{
				int num13 = text2.IndexOf('\'');
				int num14 = text2.IndexOf('\'', num13 + 1);
				if (num14 == -1)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cr());
				}
				text2 = text2.Substring(num13 + 1, num14 - num13 - 1);
			}
			string text3 = P_0.Substring(num, num10 - num + 1);
			if (!flag)
			{
				switch (b2)
				{
				case T.B.BHh:
					if (text == text2)
					{
						flag = true;
					}
					break;
				case T.B.BHI:
					if (text.Contains(text2))
					{
						flag = true;
					}
					break;
				case T.B.BHi:
					if (text.StartsWith(text2))
					{
						flag = true;
					}
					break;
				case T.B.BHJ:
					if (text.EndsWith(text2))
					{
						flag = true;
					}
					break;
				}
			}
			if (flag)
			{
				P_0 = P_0.Replace(text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ());
			}
			else
			{
				P_0 = P_0.Replace(text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
			}
		}
	}

	internal static bool A(ref string P_0)
	{
		A a2 = new A(ref P_0);
		if (a2 != null && a2.BHe != null)
		{
			return a2.BHe.BHH != 0;
		}
		a2 = new A(ref P_0);
		throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CS());
	}

	internal static int a(ref string P_0)
	{
		A a2 = new A(ref P_0);
		if (a2 != null && a2.BHe != null)
		{
			return (int)a2.BHe.BHH;
		}
		a2 = new A(ref P_0);
		throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CS());
	}
}
internal class t : Panel
{
	private delegate void A(object P_0, ElapsedEventArgs P_1);

	private const int Dl = 250;

	private const int DM = 8;

	private const int Dm = 23;

	private const int DN = 3;

	private const int Dn = 300;

	private const int DO = 5000;

	private Stopwatch Do = new Stopwatch();

	private Timer DP = new Timer();

	private bool Dp;

	private static readonly object DQ = new object();

	internal t()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		((Control)this).Visible = false;
		((Control)this).Width = 250;
		((Control)this).Left = -((Control)this).Width;
		((Control)this).DoubleBuffered = true;
		((Control)this).Paint += new PaintEventHandler(A);
		((Control)this).MouseDown += new MouseEventHandler(A);
		global::A.A.A(new EventHandler(A));
		global::A.A.A((D)A);
	}

	internal void A()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (!Dp)
		{
			Dp = true;
			DP.Interval = 20.0;
			DP.Elapsed -= new ElapsedEventHandler(A);
			DP.Elapsed += new ElapsedEventHandler(A);
			if (!DP.Enabled)
			{
				DP.Start();
			}
			((Control)this).Width = a();
			((Control)this).Height = B();
			((Control)this).Visible = true;
			((Control)this).BringToFront();
			((Control)this).Invalidate();
		}
	}

	private int a()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		List<F> val = global::A.A.c();
		int num = 0;
		for (int num2 = 0; num2 < val.Count; num2++)
		{
			string text = bx.C(val[num2].aH, val[num2].ah);
			Font val2 = new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)1);
			try
			{
				int num3 = num;
				Size val3 = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cs() + text, val2);
				num = Math.Max(num3, ((Size)(ref val3)).Width);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		return Math.Max(250, num + 16 + 6);
	}

	private int B()
	{
		return 6 + 23 * global::A.A.c().Count;
	}

	private void A(object P_0, ElapsedEventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a2 = A;
				((Control)this).Invoke((System.Delegate)a2, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		bool flag = false;
		bool flag2 = false;
		try
		{
			Monitor.TryEnter(DQ, ref flag);
			if (!flag)
			{
				return;
			}
			DP.Stop();
			DP.Enabled = false;
			if (Dp)
			{
				if (((Control)this).Left < 0)
				{
					((Control)this).Left = ((Control)this).Left + ((Control)this).Width / (300 / (int)DP.Interval);
				}
				if (((Control)this).Left > 0)
				{
					((Control)this).Left = 0;
				}
				if (((Control)this).Left == 0)
				{
					Dp = false;
					Do.Restart();
				}
				((Control)this).Invalidate();
				return;
			}
			if (Do.ElapsedMilliseconds <= 5000)
			{
				((Control)this).Invalidate();
				return;
			}
			if (((Control)this).Left > -((Control)this).Width)
			{
				((Control)this).Left = ((Control)this).Left - ((Control)this).Width / (300 / (int)DP.Interval);
				((Control)this).Invalidate();
			}
			if (((Control)this).Left < -((Control)this).Width)
			{
				((Control)this).Left = -((Control)this).Width;
			}
			if (((Control)this).Left == -((Control)this).Width && Do.IsRunning)
			{
				((Control)this).Visible = false;
				Do.Stop();
				flag2 = true;
			}
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(DQ);
				if (!flag2)
				{
					DP.Enabled = true;
					DP.Start();
				}
			}
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		b();
	}

	private void A(object P_0, E P_1)
	{
		b();
	}

	private void b()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		if (((Control)this).InvokeRequired)
		{
			((Control)this).BeginInvoke((Action)([CompilerGenerated] () =>
			{
				((Control)this).Width = a();
			}));
			((Control)this).BeginInvoke((Action)([CompilerGenerated] () =>
			{
				((Control)this).Height = B();
			}));
		}
		else
		{
			((Control)this).Width = a();
			((Control)this).Height = B();
		}
		((Control)this).Invalidate();
	}

	private void A(object P_0, PaintEventArgs P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		SolidBrush val = new SolidBrush(BM.td);
		try
		{
			P_1.Graphics.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).Width, ((Control)this).Height);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
		P_1.Graphics.SmoothingMode = (SmoothingMode)2;
		GraphicsPath val2 = ThemedButton.A(new Rectangle(1, 1, ((Control)this).Width - 3, ((Control)this).Height - 3), 6);
		try
		{
			Pen val3 = new Pen(Color.DodgerBlue, 3f);
			try
			{
				P_1.Graphics.DrawPath(val3, val2);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
		P_1.Graphics.SmoothingMode = (SmoothingMode)0;
		List<F> obj = global::A.A.c();
		string text = string.Empty;
		if (BM.SI.Count == 1)
		{
			text = BM.SI[0].BpS.ao;
		}
		List<F> val4 = new List<F>(obj.Count);
		Enumerator<F> enumerator = obj.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				F current = enumerator.Current;
				if (!string.IsNullOrEmpty(text) && current.ao == text)
				{
					val4.Insert(0, current);
				}
				else
				{
					val4.Add(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		for (int num = 0; num < val4.Count; num++)
		{
			F f2 = val4[num];
			P_1.Graphics.SmoothingMode = (SmoothingMode)2;
			GraphicsPath val5 = ThemedButton.A(new Rectangle(5, 3 + 23 * num + 1, ((Control)this).Width - 10, 20), 3);
			try
			{
				P_1.Graphics.DrawPath(Pens.Gray, val5);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
			P_1.Graphics.SmoothingMode = (SmoothingMode)0;
			SolidBrush val6 = new SolidBrush(BM.te);
			try
			{
				StringFormat val7 = new StringFormat();
				try
				{
					val7.Alignment = (StringAlignment)1;
					val7.LineAlignment = (StringAlignment)1;
					if (!string.IsNullOrEmpty(text) && f2.ao == text)
					{
						Font val8 = new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)1);
						try
						{
							int num2 = (int)Math.Round((double)((float)(5000 - (int)Do.ElapsedMilliseconds) / 1000f), 0);
							P_1.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CT() + num2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ct(), val8, (Brush)(object)val6, (float)(((Control)this).Width / 2), (float)(3 + 23 * num + 11 + 2), val7);
						}
						finally
						{
							((System.IDisposable)val8)?.Dispose();
						}
					}
					else
					{
						Font val9 = new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)1);
						try
						{
							P_1.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cs() + bx.C(f2.aH, f2.ah), val9, (Brush)(object)val6, (float)(((Control)this).Width / 2), (float)(3 + 23 * num + 11 + 2), val7);
						}
						finally
						{
							((System.IDisposable)val9)?.Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val6)?.Dispose();
			}
		}
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		List<F> obj = global::A.A.c();
		string text = string.Empty;
		if (BM.SI.Count == 1)
		{
			text = BM.SI[0].BpS.ao;
		}
		List<F> val = new List<F>(obj.Count);
		Enumerator<F> enumerator = obj.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				F current = enumerator.Current;
				if (!string.IsNullOrEmpty(text) && current.ao == text)
				{
					val.Insert(0, current);
				}
				else
				{
					val.Add(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		string text2 = null;
		for (int num = 1; num <= val.Count; num++)
		{
			if (P_1.Y > 3 && P_1.Y < 3 + num * 23)
			{
				text2 = val[num - 1].ao;
				break;
			}
		}
		if (text2 == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(text) || !(text2 == text))
		{
			F f2 = global::A.A.e(text2);
			if (f2 != null)
			{
				BM.QQ.A(f2, BF.OU);
				if (!string.IsNullOrEmpty(text))
				{
					BM.QQ.A(text);
				}
			}
			else
			{
				BM.b(true);
			}
		}
		((Control)this).Visible = false;
	}

	[CompilerGenerated]
	private void C()
	{
		((Control)this).Width = a();
	}

	[CompilerGenerated]
	private void c()
	{
		((Control)this).Height = B();
	}
}
