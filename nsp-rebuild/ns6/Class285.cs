using System.Collections.Generic;
using System.Text;
using NSP.SettingsFramework;
using ns0;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns6;

internal static class Class285
{
	internal static List<string> smethod_0(Class286 class286_0)
	{
		List<string> list = new List<string>();
		string text = ((class286_0.BCY != null) ? class286_0.BCY.ToString() : string.Empty);
		list.Add(Class333.aVy() + text);
		string text2 = ((class286_0.BCy != null) ? class286_0.BCy : string.Empty);
		list.Add(Class333.aVZ() + text2);
		foreach (KeyValuePair<string, string> item in class286_0.Bcb)
		{
			string text3 = ((item.Value != null) ? item.Value : string.Empty);
			list.Add(Class286.smethod_12(item.Key, Class333.smethod_562()) + Class333.smethod_189() + text3);
		}
		string bsP = class286_0.BcC[Class333.smethod_562()].BsP;
		bsP = ((bsP != null) ? bsP : string.Empty);
		list.Add(Class333.aVz() + bsP);
		string bsp = class286_0.BcC[Class333.smethod_562()].Bsp;
		bsp = ((bsp != null) ? bsp : string.Empty);
		list.Add(Class333.avA() + bsp);
		string bsQ = class286_0.BcC[Class333.smethod_562()].BsQ;
		bsQ = ((bsQ != null) ? bsQ : string.Empty);
		list.Add(Class333.ava() + bsQ);
		return list;
	}

	internal static List<string> smethod_1(Class286 class286_0, MenuNode menuNode_0, bool bool_0)
	{
		return smethod_2(class286_0, menuNode_0, class286_0.method_8(menuNode_0, bool_0: false, bool_1: false), bool_0);
	}

	internal static List<string> smethod_2(Class286 class286_0, MenuNode menuNode_0, List<Setting> list_0, bool bool_0)
	{
		List<string> list_1 = new List<string>();
		List<Setting> list_2 = new List<Setting>();
		smethod_3(ref list_1, list_0, list_2);
		smethod_4(ref list_1, list_0, list_2);
		smethod_5(ref list_1, list_0, list_2, class286_0, menuNode_0, bool_0);
		smethod_6(ref list_1, list_0, list_2, class286_0, menuNode_0, bool_0);
		return list_1;
	}

	private static void smethod_3(ref List<string> list_0, List<Setting> list_1, List<Setting> list_2)
	{
		bool flag = false;
		foreach (Setting item in list_1)
		{
			if (item.method_6() == null || (!(item.method_6() is Table) && !(item.method_6() is TableAxis)))
			{
				continue;
			}
			if (item.method_6() is Table && item == (item.method_6() as Table).TableDataSetting)
			{
				Table table = item.method_6() as Table;
				if (!flag)
				{
					if (list_0.Count != 0)
					{
						list_0.Add(string.Empty);
					}
					list_0.Add(Class333.avB());
					flag = true;
				}
				string text = table.method_60(Enum96.aYt);
				if (string.IsNullOrWhiteSpace(text))
				{
					text = table.method_2();
				}
				list_0.Add(text);
			}
			list_2.Add(item);
		}
	}

	private static void smethod_4(ref List<string> list_0, List<Setting> list_1, List<Setting> list_2)
	{
		bool flag = false;
		foreach (Setting item in list_1)
		{
			if (!(item.method_6() is SensorCalibration))
			{
				continue;
			}
			SensorCalibration sensorCalibration = item.method_6() as SensorCalibration;
			if ((item == sensorCalibration.CalibrationValuesSetting || item == sensorCalibration.CalibrationVoltagesSetting || item == sensorCalibration.CalibrationValueCountSetting) && !list_2.Contains(sensorCalibration.CalibrationValuesSetting) && !list_2.Contains(sensorCalibration.CalibrationVoltagesSetting) && !list_2.Contains(sensorCalibration.CalibrationValueCountSetting))
			{
				if (!flag)
				{
					if (list_0.Count != 0)
					{
						list_0.Add(string.Empty);
					}
					list_0.Add(Class333.avb());
					flag = true;
				}
				string text = sensorCalibration.method_60(Enum96.aYt);
				if (string.IsNullOrWhiteSpace(text))
				{
					text = sensorCalibration.method_2();
				}
				list_0.Add(text);
			}
			list_2.Add(item);
		}
	}

	private static void smethod_5(ref List<string> list_0, List<Setting> list_1, List<Setting> list_2, Class286 class286_0, MenuNode menuNode_0, bool bool_0)
	{
		bool flag = false;
		foreach (Setting item in list_1)
		{
			if (!(item is Class244))
			{
				continue;
			}
			if (!flag)
			{
				if (list_0.Count != 0)
				{
					list_0.Add(string.Empty);
				}
				list_0.Add(Class333.avC());
				flag = true;
			}
			string text = item.method_60(Enum96.aYt);
			if (string.IsNullOrWhiteSpace(text))
			{
				text = item.method_2();
			}
			string text2 = null;
			int num = 0;
			if (bool_0)
			{
				num = item.method_256();
			}
			else
			{
				int[] array = class286_0.method_3(item);
				if (array != null && array.Length == 1)
				{
					num = array[0];
				}
				else
				{
					text2 = Class333.avc();
				}
			}
			if (text2 == null)
			{
				if (num == 0)
				{
					text2 = Class333.avD();
				}
				else
				{
					Enum104 enum104_ = PortFunction.smethod_12((uint)num);
					Enum105 @enum = PortFunction.smethod_13((uint)num);
					byte byte_ = PortFunction.smethod_14((uint)num);
					ushort ushort_ = PortFunction.smethod_15((uint)num);
					if (@enum == Enum105.Bal)
					{
						text2 = Class333.avd();
					}
					else
					{
						SettingOrSpecialObject settingOrSpecialObject = PortFunction.smethod_36(menuNode_0.method_1(), enum104_, @enum, byte_, ushort_);
						if (settingOrSpecialObject != null)
						{
							string text3 = PortFunction.smethod_37(settingOrSpecialObject);
							text2 = Class333.avE() + text3;
						}
						else
						{
							text2 = Class333.ave();
						}
					}
				}
			}
			list_0.Add(text + Class333.smethod_189() + text2);
			list_2.Add(item);
		}
	}

	private static void smethod_6(ref List<string> list_0, List<Setting> list_1, List<Setting> list_2, Class286 class286_0, MenuNode menuNode_0, bool bool_0)
	{
		bool flag = false;
		foreach (Setting item in list_1)
		{
			if (list_2.Contains(item))
			{
				continue;
			}
			if (!flag)
			{
				if (list_0.Count != 0)
				{
					list_0.Add(string.Empty);
				}
				list_0.Add(Class333.avF());
				flag = true;
			}
			if (menuNode_0.method_1().awX.ContainsKey(item.method_64()))
			{
				smethod_9(ref list_0, item, class286_0, menuNode_0, bool_0);
			}
			else if (item.method_70() != 0)
			{
				smethod_8(ref list_0, item, class286_0, bool_0);
			}
			else
			{
				smethod_7(ref list_0, item, class286_0, bool_0);
			}
			list_2.Add(item);
		}
	}

	private static void smethod_7(ref List<string> list_0, Setting setting_0, Class286 class286_0, bool bool_0)
	{
		string text = setting_0.method_60(Enum96.aYt);
		if (string.IsNullOrWhiteSpace(text))
		{
			text = setting_0.method_2();
		}
		string text2 = string.Empty;
		int num = 0;
		int[] array = null;
		if (bool_0)
		{
			num = setting_0.method_277();
		}
		else
		{
			array = class286_0.method_3(setting_0);
			if (array != null)
			{
				num = array.Length;
			}
		}
		if (!bool_0 && array == null)
		{
			text2 = Class333.avf();
		}
		else
		{
			for (int i = 0; i < num; i++)
			{
				int int_ = ((!bool_0) ? array[i] : setting_0.method_258(i));
				(string, string, bool) tuple = setting_0.method_253(int_);
				if (i <= 0)
				{
					(text2, _, _) = tuple;
				}
				else
				{
					text2 = text2 + Class333.aMY() + tuple.Item1;
				}
				if (!string.IsNullOrEmpty(tuple.Item2))
				{
					text2 = text2 + Class333.smethod_325() + tuple.Item2;
				}
			}
		}
		string text3 = text2;
		list_0.Add(text + Class333.smethod_189() + text3);
	}

	private static void smethod_8(ref List<string> list_0, Setting setting_0, Class286 class286_0, bool bool_0)
	{
		string text = setting_0.method_60(Enum96.aYt);
		if (string.IsNullOrWhiteSpace(text))
		{
			text = setting_0.method_2();
		}
		string text2;
		if (bool_0)
		{
			text2 = setting_0.method_260();
		}
		else
		{
			byte[] array = class286_0.method_1(setting_0);
			text2 = ((array == null) ? Class333.avf() : Encoding.GetEncoding(setting_0.method_70()).GetString(array).TrimEnd('\0'));
		}
		list_0.Add(text + Class333.smethod_189() + text2);
	}

	private static void smethod_9(ref List<string> list_0, Setting setting_0, Class286 class286_0, MenuNode menuNode_0, bool bool_0)
	{
		string text = setting_0.method_60(Enum96.aYt);
		if (string.IsNullOrWhiteSpace(text))
		{
			text = setting_0.method_2();
		}
		string text2;
		if (bool_0)
		{
			MenuNode menuNode = menuNode_0.method_1().awX[setting_0.method_64()];
			text2 = ((menuNode.method_80() == null || menuNode.method_80().BcF == null || setting_0.method_280()) ? Class333.avG() : menuNode.method_80().BcF.BcC[Class333.smethod_562()].Bsp);
		}
		else
		{
			text2 = Class333.avf();
			byte[] array = class286_0.method_1(setting_0);
			if (array != null && array.Length == setting_0.method_278())
			{
				bool flag = true;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != 0)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					text2 = Class333.avG();
				}
				else
				{
					lock (Form23.object_0)
					{
						string key = Class24.smethod_0(array);
						if (Form23.dictionary_1.ContainsKey(key))
						{
							text2 = Form23.dictionary_1[key].BcF.BcC[Class333.smethod_562()].Bsp;
						}
					}
				}
			}
		}
		list_0.Add(text + Class333.smethod_189() + text2);
	}
}
