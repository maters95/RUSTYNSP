using System.Collections.Generic;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal static class Class326
{
	private static readonly Class14 BdP = new Class14(1, 22, 0, 103, 0);

	private static readonly Class14 Bdp = new Class14(3, 9, 0, 0, 0);

	private static readonly Class14 BdQ = new Class14(3, 10, 0, 0, 0);

	internal static bool smethod_0(IWin32Window iwin32Window_0, Class5 class5_0, Class14 class14_0, Class14 class14_1, out bool bool_0)
	{
		bool_0 = false;
		bool flag = false;
		if (Form23.framework_1 != null && Form23.framework_1.method_5() && Form23.framework_1.method_9())
		{
			if (!Class320.smethod_48(class5_0) && class5_0.byte_4 == 20 && class5_0.byte_5 == 3 && class14_0 != null && class14_1 != null && class14_0 < BdP && class14_1 >= BdP && smethod_4(Form23.framework_1, bool_0: true, null))
			{
				flag = true;
			}
			if (flag && Form54.smethod_6(iwin32Window_0, smethod_2(bool_0: true, bool_1: false, bool_2: false), Class333.aZs(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
			{
				bool_0 = true;
			}
		}
		return flag;
	}

	internal static bool smethod_1(IWin32Window iwin32Window_0, bool bool_0, bool bool_1, Framework framework_0, Framework framework_1, out bool bool_2)
	{
		bool_2 = false;
		bool flag = false;
		if (framework_0.awZ == 20 && framework_0.awz == 3 && framework_1.awZ == 20)
		{
			Class14 aXA = framework_0.aXA;
			Class14 aXA2 = framework_1.aXA;
			if (aXA < BdP && aXA2 >= BdP && smethod_4(Form23.framework_1, bool_0: true, null))
			{
				flag = true;
			}
		}
		if (flag && Form54.smethod_6(iwin32Window_0, ((bool_0 | bool_1) ? string.Empty : Class333.aZT()) + smethod_2(bool_0: false, bool_1: true, bool_2: false), Class333.aZt(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
		{
			bool_2 = true;
		}
		return flag;
	}

	internal static string smethod_2(bool bool_0, bool bool_1, bool bool_2)
	{
		string text = string.Empty;
		if (bool_0)
		{
			text += Class333.aZU();
		}
		else if (bool_1)
		{
			text += Class333.aZu();
		}
		else if (bool_2)
		{
			text += Class333.aZV();
		}
		text += Class333.aZv();
		if (bool_0)
		{
			text += Class333.aZW();
		}
		else if (bool_1)
		{
			text += Class333.aZw();
		}
		else if (bool_2)
		{
			text += Class333.aZX();
		}
		text += Class333.aZx();
		if (!bool_2)
		{
			text += Class333.aZY();
		}
		return text;
	}

	internal static bool smethod_3(Enum88 enum88_0, Class14 class14_0, Class14 class14_1, Dictionary<Enum88, Class14> dictionary_0, Dictionary<Enum88, Class14> dictionary_1)
	{
		bool result = false;
		if (enum88_0 != Enum88.avn && enum88_0 != Enum88.avp && enum88_0 != Enum88.avQ && enum88_0 != Enum88.avq && enum88_0 != Enum88.avO)
		{
			if (dictionary_0 != null && dictionary_1 != null)
			{
				List<Enum88> list = new List<Enum88>();
				foreach (Enum88 key in dictionary_0.Keys)
				{
					if ((key == Enum88.avn || key == Enum88.avp || key == Enum88.avQ || key == Enum88.avq || key == Enum88.avO) && dictionary_1.ContainsKey(key))
					{
						Class14 @class = dictionary_0[key];
						Class14 class2 = dictionary_1[key];
						if (@class != null && class2 != null && @class < Bdp && class2 >= BdQ)
						{
							list.Add(key);
						}
					}
				}
				if (list.Count != 0 && smethod_4(Form23.framework_1, bool_0: false, list))
				{
					result = true;
				}
			}
		}
		else if (class14_0 != null && class14_1 != null && class14_0 < Bdp && class14_1 >= BdQ)
		{
			List<Enum88> list2 = new List<Enum88>();
			list2.Add(enum88_0);
			if (smethod_4(Form23.framework_1, bool_0: false, list2))
			{
				result = true;
			}
		}
		return result;
	}

	private static bool smethod_4(Framework framework_0, bool bool_0, List<Enum88> list_0)
	{
		if (framework_0 == null)
		{
			return false;
		}
		Setting setting = framework_0.method_31(14163);
		if (setting == null || setting.method_256() != 0)
		{
			int[] array = new int[12]
			{
				2084, 2088, 2119, 2123, 7834, 7835, 7836, 7837, 7838, 7839,
				7840, 7841
			};
			int[] array2 = new int[12]
			{
				781, 782, 783, 784, 7666, 7682, 7698, 7714, 7730, 7746,
				7762, 7778
			};
			int[] array3 = new int[12]
			{
				2018, 2019, 2027, 2028, 7667, 7683, 7699, 7715, 7731, 7747,
				7763, 7779
			};
			for (int i = 0; i < 12; i++)
			{
				Setting setting2 = framework_0.method_31(array[i]);
				Setting setting3 = framework_0.method_31(array2[i]);
				Setting setting4 = framework_0.method_31(array3[i]);
				if (setting2 == null || setting3 == null || setting4 == null || setting2.method_256() == 0 || setting3.method_256() != 1292)
				{
					continue;
				}
				int uint_ = setting4.method_256();
				Enum104 @enum = PortFunction.smethod_12((uint)uint_);
				Enum105 enum2 = PortFunction.smethod_13((uint)uint_);
				byte b = PortFunction.smethod_14((uint)uint_);
				if (bool_0 && @enum == Enum104.BAb && enum2 == Enum105.Baj)
				{
					Setting setting5 = null;
					switch (b)
					{
					case 0:
						setting5 = framework_0.method_31(9877);
						break;
					case 1:
						setting5 = framework_0.method_31(9893);
						break;
					}
					if (setting5 != null)
					{
						string text = setting5.method_286();
						if (!string.IsNullOrEmpty(text) && text.Contains(Class333.aZy()))
						{
							return true;
						}
					}
				}
				if (list_0 == null)
				{
					continue;
				}
				Setting setting6 = null;
				Setting setting7 = null;
				if (@enum == Enum104.BAf && list_0.Contains(Enum88.avO))
				{
					setting6 = framework_0.method_31(12129);
				}
				else if (@enum == Enum104.BAF && list_0.Contains(Enum88.avn))
				{
					setting6 = framework_0.method_31(12121);
					setting7 = framework_0.method_31(12122);
				}
				else if (@enum == Enum104.BAh && list_0.Contains(Enum88.avp))
				{
					setting6 = framework_0.method_31(12123);
					setting7 = framework_0.method_31(12124);
				}
				else if (@enum == Enum104.BAI && list_0.Contains(Enum88.avQ))
				{
					setting6 = framework_0.method_31(12125);
					setting7 = framework_0.method_31(12126);
				}
				else if (@enum == Enum104.BAi && list_0.Contains(Enum88.avq))
				{
					setting6 = framework_0.method_31(12127);
					setting7 = framework_0.method_31(12128);
				}
				if (setting6 != null)
				{
					string text2 = setting6.method_286();
					if (!string.IsNullOrEmpty(text2) && text2.Contains(Class333.aZy()))
					{
						return true;
					}
				}
				if (setting7 != null)
				{
					string text3 = setting7.method_286();
					if (!string.IsNullOrEmpty(text3) && text3.Contains(Class333.aZy()))
					{
						return true;
					}
				}
			}
		}
		return false;
	}
}
