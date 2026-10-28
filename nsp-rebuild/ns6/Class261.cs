using System.Collections.Generic;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns7;

namespace ns6;

internal class Class261
{
	private Framework ays;

	private string ayT;

	private string ayt;

	private string ayU;

	private string ayu;

	private int ayV = -1;

	private bool ayv;

	private List<Class261> ayW = new List<Class261>();

	internal Class261(Framework framework_0, string string_0, string string_1, string string_2, string string_3, int int_0, bool bool_0)
	{
		ays = framework_0;
		ayT = string_0;
		ayt = string_1;
		ayU = string_2;
		ayu = string_3;
		ayV = int_0;
		ayv = bool_0;
	}

	internal void method_0(Class261 class261_0)
	{
		ayW.Add(class261_0);
	}

	internal Setting method_1(Framework framework_0)
	{
		if (ayV != -1)
		{
			return framework_0.method_31(ayV);
		}
		return null;
	}

	public virtual void vmethod_0(bool bool_0)
	{
		vmethod_1(null, ays, ays, null, null, bool_0);
	}

	public virtual void vmethod_1(Setting setting_0, Framework framework_0, Framework framework_1, List<int[]> list_0, List<int[]> list_1, bool bool_0)
	{
		if (ayT == null)
		{
			return;
		}
		Setting setting = method_1(framework_0);
		if (setting == null)
		{
			setting = setting_0;
		}
		if (!method_2(setting, list_1, framework_0, framework_1))
		{
			return;
		}
		if (setting != null)
		{
			int num = method_6(AxisType.Column);
			int num2 = method_6(AxisType.Row);
			int num3 = method_6(AxisType.Slice);
			int num4 = method_8(AxisType.Column);
			int num5 = method_8(AxisType.Row);
			int num6 = method_8(AxisType.Slice);
			if (num4 == -1)
			{
				num4 = setting.method_242()[2] - num;
			}
			if (num5 == -1)
			{
				num5 = setting.method_242()[1] - num2;
			}
			if (num6 == -1)
			{
				num6 = setting.method_242()[0] - num3;
			}
			if (ayU != null)
			{
				method_3(setting, framework_1, num3, num2, num, num6, num5, num4, list_0, list_1, bool_0);
			}
			else
			{
				method_4(setting, framework_0, framework_1, num3, num2, num, num6, num5, num4, list_0, list_1, bool_0);
			}
		}
		foreach (Class261 item in ayW)
		{
			item.vmethod_1(setting_0, framework_0, framework_1, list_0, list_1, bool_0);
		}
	}

	protected bool method_2(Setting setting_0, List<int[]> list_0, Framework framework_0, Framework framework_1)
	{
		bool result = true;
		if (ayt != null)
		{
			string string_ = ayt;
			if (!ayt.Contains(Class333.smethod_960() + setting_0.method_64() + Class333.smethod_960()) && !ayt.Contains(Class333.smethod_960() + setting_0.method_64() + Class333.aoj()))
			{
				Class37.smethod_0(ref string_, framework_1);
			}
			else
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (ayt.Contains(Class333.smethod_960() + setting_0.method_64() + Class333.aoj()))
				{
					int num4 = ayt.IndexOf(Class333.smethod_960() + setting_0.method_64() + Class333.aoj());
					int num5 = ayt.IndexOf(Class333.smethod_960(), num4 + 1);
					int num6 = ayt.IndexOf(Class333.aoj(), num4 + 1);
					string[] array = ayt.Substring(num6 + 1, num5 - (num6 + 1)).Split('e');
					switch (array.Length)
					{
					case 1:
						num = 0;
						num2 = 0;
						num3 = int.Parse(array[0]);
						break;
					case 2:
						num = 0;
						num2 = int.Parse(array[0]);
						num3 = int.Parse(array[1]);
						break;
					case 3:
						num = int.Parse(array[0]);
						num2 = int.Parse(array[1]);
						num3 = int.Parse(array[2]);
						break;
					}
				}
				bool flag = false;
				if (list_0 != null)
				{
					foreach (int[] item in list_0)
					{
						if (item[0] == num && item[1] == num2 && item[2] == num3)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					Class37.smethod_0(ref string_, framework_0);
				}
				else
				{
					Class37.smethod_0(ref string_, framework_1);
				}
			}
			result = Class37.smethod_10(ref string_);
		}
		return result;
	}

	private void method_3(Setting setting_0, Framework framework_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, List<int[]> list_0, List<int[]> list_1, bool bool_0)
	{
		if (ayT[0] != 's' || ayT[ayT.Length - 1] != 's' || ayT.Contains(Class333.smethod_325()) || ayT.Contains(Class333.aoj()))
		{
			return;
		}
		int int_6 = int.Parse(ayT.Substring(1, ayT.Length - 2));
		Setting setting = framework_0.method_31(int_6);
		int num = method_5(AxisType.Column);
		int num2 = method_5(AxisType.Row);
		int num3 = method_5(AxisType.Slice);
		int num4 = method_7(AxisType.Column);
		int num5 = method_7(AxisType.Row);
		int num6 = method_7(AxisType.Slice);
		if (num4 == -1)
		{
			num4 = setting.method_242()[2] - num;
		}
		if (num5 == -1)
		{
			num5 = setting.method_242()[1] - num2;
		}
		if (num6 == -1)
		{
			num6 = setting.method_242()[0] - num3;
		}
		if (num4 != int_5 || num5 != int_4 || num6 != int_3)
		{
			return;
		}
		for (int i = 0; i < int_3; i++)
		{
			for (int j = 0; j < int_4; j++)
			{
				for (int k = 0; k < int_5; k++)
				{
					bool flag = false;
					if (list_0 != null)
					{
						foreach (int[] item2 in list_0)
						{
							if (item2[0] == int_0 + i && item2[1] == int_1 + j && item2[2] == int_2 + k)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						int int_7 = setting.method_257(num + k, num2 + j, num3 + i);
						setting_0.method_273(int_2 + k, int_1 + j, int_0 + i, int_7, bool_0);
						int[] item = new int[3]
						{
							int_0 + i,
							int_1 + j,
							int_2 + k
						};
						list_0?.Add(item);
						list_1?.Add(item);
					}
				}
			}
		}
	}

	private void method_4(Setting setting_0, Framework framework_0, Framework framework_1, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, List<int[]> list_0, List<int[]> list_1, bool bool_0)
	{
		for (int i = int_0; i < int_0 + int_3; i++)
		{
			for (int j = int_1; j < int_1 + int_4; j++)
			{
				for (int k = int_2; k < int_2 + int_5; k++)
				{
					bool flag = false;
					if (list_0 != null)
					{
						foreach (int[] item2 in list_0)
						{
							if (item2[0] == i && item2[1] == j && item2[2] == k)
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						continue;
					}
					string text = ayT;
					string text2 = text;
					string oldValue = string.Format(Class333.aoK(), setting_0.method_64());
					string format = Class333.aok();
					Struct64<object> gparam_ = default;
					Class332.smethod_1<Struct64<object>, object>(ref gparam_, 0) = setting_0.method_64();
					Class332.smethod_1<Struct64<object>, object>(ref gparam_, 1) = i;
					Class332.smethod_1<Struct64<object>, object>(ref gparam_, 2) = j;
					Class332.smethod_1<Struct64<object>, object>(ref gparam_, 3) = k;
					text = text2.Replace(oldValue, string.Format(format, Class332.smethod_0<Struct64<object>, object>(in gparam_, 4)));
					bool flag2 = false;
					if (list_1 != null)
					{
						foreach (int[] item3 in list_1)
						{
							if (item3[0] == i && item3[1] == j && item3[2] == k)
							{
								flag2 = true;
								break;
							}
						}
					}
					if (flag2)
					{
						Class37.smethod_0(ref text, framework_0);
					}
					else
					{
						Class37.smethod_0(ref text, framework_1);
					}
					int int_6 = Class37.smethod_11(ref text);
					setting_0.method_273(k, j, i, int_6, bool_0);
					int[] item = new int[3] { i, j, k };
					list_0?.Add(item);
					list_1?.Add(item);
				}
			}
		}
	}

	private int method_5(AxisType axisType_0)
	{
		if (ayU == null)
		{
			return 0;
		}
		string[] array = ayU.Split(',');
		switch (axisType_0)
		{
		case AxisType.Slice:
			if (array.Length >= 3 && (array.Length != 3 || !array[0].Contains(Class333.aoL())))
			{
				string text3 = array[0].Trim();
				if (text3.EndsWith(Class333.aol()))
				{
					return int.Parse(text3.Substring(0, text3.Length - 1));
				}
				if (text3.Contains(Class333.aol()))
				{
					return int.Parse(text3.Split('+')[0]);
				}
				return int.Parse(text3);
			}
			return 0;
		case AxisType.Row:
			if (array.Length >= 2 && (array.Length < 2 || !array[^2].Contains(Class333.aoL())))
			{
				string text2 = array[^2].Trim();
				if (text2.EndsWith(Class333.aol()))
				{
					return int.Parse(text2.Substring(0, text2.Length - 1));
				}
				if (text2.Contains(Class333.aol()))
				{
					return int.Parse(text2.Split('+')[0]);
				}
				return int.Parse(text2);
			}
			return 0;
		case AxisType.Column:
		{
			if (array[^1].Contains(Class333.aoL()))
			{
				return 0;
			}
			string text = array[^1].Trim();
			if (text.EndsWith(Class333.aol()))
			{
				return int.Parse(text.Substring(0, text.Length - 1));
			}
			if (text.Contains(Class333.aol()))
			{
				return int.Parse(text.Split('+')[0]);
			}
			return int.Parse(text);
		}
		default:
			return 0;
		}
	}

	private int method_6(AxisType axisType_0)
	{
		if (ayu == null)
		{
			return 0;
		}
		string[] array = ayu.Split(',');
		switch (axisType_0)
		{
		case AxisType.Slice:
			if (array.Length >= 3 && (array.Length != 3 || !array[0].Contains(Class333.aoL())))
			{
				string text3 = array[0].Trim();
				if (text3.EndsWith(Class333.aol()))
				{
					return int.Parse(text3.Substring(0, text3.Length - 1));
				}
				if (text3.Contains(Class333.aol()))
				{
					return int.Parse(text3.Split('+')[0]);
				}
				return int.Parse(text3);
			}
			return 0;
		case AxisType.Row:
			if (array.Length >= 2 && (array.Length < 2 || !array[^2].Contains(Class333.aoL())))
			{
				string text2 = array[^2].Trim();
				if (text2.EndsWith(Class333.aol()))
				{
					return int.Parse(text2.Substring(0, text2.Length - 1));
				}
				if (text2.Contains(Class333.aol()))
				{
					return int.Parse(text2.Split('+')[0]);
				}
				return int.Parse(text2);
			}
			return 0;
		case AxisType.Column:
		{
			if (array[^1].Contains(Class333.aoL()))
			{
				return 0;
			}
			string text = array[^1].Trim();
			if (text.EndsWith(Class333.aol()))
			{
				return int.Parse(text.Substring(0, text.Length - 1));
			}
			if (text.Contains(Class333.aol()))
			{
				return int.Parse(text.Split('+')[0]);
			}
			return int.Parse(text);
		}
		default:
			return 0;
		}
	}

	private int method_7(AxisType axisType_0)
	{
		if (ayU == null)
		{
			return -1;
		}
		string[] array = ayU.Split(',');
		switch (axisType_0)
		{
		case AxisType.Slice:
		{
			if (array.Length < 3)
			{
				return 1;
			}
			if (array[0].Contains(Class333.aoL()))
			{
				return -1;
			}
			string text3 = array[0].Trim();
			if (text3.EndsWith(Class333.aol()))
			{
				return -1;
			}
			if (text3.Contains(Class333.aol()))
			{
				return int.Parse(text3.Split('+')[1]);
			}
			return 1;
		}
		case AxisType.Row:
		{
			if (array.Length < 2)
			{
				return 1;
			}
			if (array[^2].Contains(Class333.aoL()))
			{
				return -1;
			}
			string text2 = array[^2].Trim();
			if (text2.EndsWith(Class333.aol()))
			{
				return -1;
			}
			if (text2.Contains(Class333.aol()))
			{
				return int.Parse(text2.Split('+')[1]);
			}
			return 1;
		}
		case AxisType.Column:
		{
			if (array[^1].Contains(Class333.aoL()))
			{
				return -1;
			}
			string text = array[^1].Trim();
			if (text.EndsWith(Class333.aol()))
			{
				return -1;
			}
			if (text.Contains(Class333.aol()))
			{
				return int.Parse(text.Split('+')[1]);
			}
			return 1;
		}
		default:
			return 0;
		}
	}

	private int method_8(AxisType axisType_0)
	{
		if (ayu == null)
		{
			return -1;
		}
		string[] array = ayu.Split(',');
		switch (axisType_0)
		{
		case AxisType.Slice:
		{
			if (array.Length < 3)
			{
				return 1;
			}
			if (array[0].Contains(Class333.aoL()))
			{
				return -1;
			}
			string text3 = array[0].Trim();
			if (text3.EndsWith(Class333.aol()))
			{
				return -1;
			}
			if (text3.Contains(Class333.aol()))
			{
				return int.Parse(text3.Split('+')[1]);
			}
			return 1;
		}
		case AxisType.Row:
		{
			if (array.Length < 2)
			{
				return 1;
			}
			if (array[^2].Contains(Class333.aoL()))
			{
				return -1;
			}
			string text2 = array[^2].Trim();
			if (text2.EndsWith(Class333.aol()))
			{
				return -1;
			}
			if (text2.Contains(Class333.aol()))
			{
				return int.Parse(text2.Split('+')[1]);
			}
			return 1;
		}
		case AxisType.Column:
		{
			if (array[^1].Contains(Class333.aoL()))
			{
				return -1;
			}
			string text = array[^1].Trim();
			if (text.EndsWith(Class333.aol()))
			{
				return -1;
			}
			if (text.Contains(Class333.aol()))
			{
				return int.Parse(text.Split('+')[1]);
			}
			return 1;
		}
		default:
			return 0;
		}
	}
}
