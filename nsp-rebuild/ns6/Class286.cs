using System;
using System.Collections.Generic;
using System.Linq;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns6;

internal class Class286
{
	internal struct Struct48
	{
		internal string BsP;

		internal string Bsp;

		internal string BsQ;
	}

	internal const string BCW = "00000000000000000000000000000000";

	internal string BCw;

	internal string BCX;

	internal int BCx;

	internal Version BCY;

	internal string BCy;

	internal Class14 BCZ;

	internal int BCz;

	internal int BcA;

	internal string Bca;

	internal string BcB;

	internal Dictionary<string, string> Bcb = new Dictionary<string, string>();

	internal Dictionary<string, Struct48> BcC = new Dictionary<string, Struct48>();

	internal Dictionary<DataIdAndAttrId, byte[]> Bcc = new Dictionary<DataIdAndAttrId, byte[]>();

	internal Dictionary<int, byte[]> BcD = new Dictionary<int, byte[]>();

	internal Dictionary<int, Dictionary<int, byte[]>> Bcd = new Dictionary<int, Dictionary<int, byte[]>>();

	internal Dictionary<int, Dictionary<int, byte[]>> BcE = new Dictionary<int, Dictionary<int, byte[]>>();

	internal Dictionary<int, string> Bce = new Dictionary<int, string>();

	private string method_0(int int_0)
	{
		if (Bce.ContainsKey(int_0))
		{
			return Bce[int_0];
		}
		return null;
	}

	public override string ToString()
	{
		if (BcC.ContainsKey(Class333.smethod_562()) && BCY != null)
		{
			return Class333.avg() + BcC[Class333.smethod_562()].Bsp + Class333.smethod_880() + BCY.ToString();
		}
		return base.ToString();
	}

	internal byte[] method_1(Setting setting_0)
	{
		byte[] result = null;
		if (setting_0.method_0().awF.ContainsKey(BCx))
		{
			Class256 @class = setting_0.method_0().awF[BCx];
			if (Bcc.ContainsKey(setting_0.method_69()))
			{
				if (@class.method_74().Contains(setting_0.method_69().DataId))
				{
					result = Bcc[setting_0.method_69()];
				}
			}
			else if (BcD.ContainsKey(setting_0.method_74()))
			{
				if (@class.method_73().Contains(setting_0.method_74()))
				{
					result = BcD[setting_0.method_74()];
				}
			}
			else
			{
				result = method_4(setting_0, @class);
			}
		}
		return result;
	}

	internal int[] method_2(Setting setting_0, byte[] byte_0)
	{
		if (setting_0.method_277() == 1 && byte_0.Length < setting_0.method_278())
		{
			int num = Class23.smethod_5(byte_0, 0, byte_0.Length, setting_0.method_201(), bool_2: true);
			return new int[1] { num };
		}
		return Class23.smethod_4(byte_0, setting_0.method_199(), setting_0.method_201(), bool_2: true);
	}

	internal int[] method_3(Setting setting_0)
	{
		byte[] array = method_1(setting_0);
		if (array == null)
		{
			return null;
		}
		return method_2(setting_0, array);
	}

	private byte[] method_4(Setting setting_0, Class256 class256_0)
	{
		byte[] result = null;
		PortFunction.Class273 @class = PortFunction.smethod_28(setting_0, bool_0: true);
		if (@class != null)
		{
			List<Class244> list = PortFunction.smethod_44(setting_0.method_0(), @class.BSQ, @class.BSq, @class.BSR, @class.BSr, bool_0: false);
			if (list != null && list.Count != 0)
			{
				foreach (Class244 item in list)
				{
					int key = item.method_74();
					if (BcE.ContainsKey(key))
					{
						if (list.Count == 1 || MenuNode.smethod_2(setting_0.method_0().awj, item.method_69()) == MenuNode.smethod_2(setting_0.method_0().awj, setting_0.method_69()))
						{
							Dictionary<int, byte[]> dictionary = BcE[key];
							if (dictionary.ContainsKey(setting_0.method_74()) && class256_0.method_75().ContainsKey(key) && class256_0.method_75()[key].Contains(setting_0.method_74()))
							{
								result = dictionary[setting_0.method_74()];
							}
							break;
						}
					}
					else if (Bcd.ContainsKey(item.method_64()))
					{
						Dictionary<int, byte[]> dictionary2 = Bcd[item.method_64()];
						if (dictionary2.ContainsKey(setting_0.method_74()) && class256_0.method_76().ContainsKey(item.method_64()) && class256_0.method_76()[item.method_64()].Contains(setting_0.method_74()))
						{
							result = dictionary2[setting_0.method_74()];
						}
						break;
					}
				}
			}
		}
		return result;
	}

	internal static Setting smethod_0(Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0, int int_0)
	{
		foreach (DataIdAndAttrId item in hashSet_0)
		{
			Setting setting = framework_0.method_32(item);
			if (setting != null && setting.method_74() == int_0)
			{
				return setting;
			}
		}
		return null;
	}

	internal static Setting smethod_1(Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0, int int_0, int int_1, int int_2)
	{
		foreach (DataIdAndAttrId item in hashSet_0)
		{
			Setting setting = framework_0.method_32(item);
			if (setting == null || setting.method_74() != int_0)
			{
				continue;
			}
			PortFunction.Class273 @class = PortFunction.smethod_28(setting, bool_0: true);
			if (@class == null)
			{
				continue;
			}
			List<Class244> list = PortFunction.smethod_44(setting.method_0(), @class.BSQ, @class.BSq, @class.BSR, @class.BSr, bool_0: false);
			if (list == null || list.Count == 0)
			{
				continue;
			}
			foreach (Class244 item2 in list)
			{
				if (((int_1 != 0 && item2.method_74() == int_1) || (int_2 != 0 && item2.method_64() == int_2)) && (int_2 != 0 || list.Count == 1 || MenuNode.smethod_2(setting.method_0().awj, item2.method_69()) == MenuNode.smethod_2(setting.method_0().awj, setting.method_69())))
				{
					return setting;
				}
			}
		}
		return null;
	}

	internal void method_5(MenuNode menuNode_0)
	{
		HashSet<DataIdAndAttrId> hashSet_ = MenuNode.smethod_1(menuNode_0);
		Framework framework = menuNode_0.method_1();
		if (framework.awZ == 21 && !Form23.bool_14)
		{
			Class329.smethod_12();
			if (Form23.smethod_28(framework.aXc, bool_53: true))
			{
				Class1.smethod_66(framework.aXc, out var _);
			}
		}
		method_6(framework, hashSet_);
		if (Bcd.Count != 0 || BcE.Count != 0)
		{
			Form23.form23_0.method_131();
			hashSet_ = MenuNode.smethod_1(menuNode_0);
			foreach (int key in Bcd.Keys)
			{
				Class244 class244_ = framework.method_31(key) as Class244;
				List<Setting> list = new List<Setting>();
				PortFunction.smethod_31(class244_, list, bool_0: false);
				foreach (Setting item in list)
				{
					hashSet_.Add(item.method_69());
				}
				List<Table> list2 = new List<Table>();
				PortFunction.smethod_34(class244_, list2, bool_0: false);
				foreach (Table item2 in list2)
				{
					foreach (DataIdAndAttrId item3 in item2.GetIdsContained())
					{
						hashSet_.Add(item3);
					}
				}
			}
			method_6(framework, hashSet_);
		}
		menuNode_0.method_81();
		menuNode_0.method_95(bool_0: false);
		if (!menuNode_0.method_90())
		{
			menuNode_0.method_85(bool_0: true);
		}
	}

	private void method_6(Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0)
	{
		if (!framework_0.awF.ContainsKey(BCx))
		{
			return;
		}
		Class256 @class = framework_0.awF[BCx];
		foreach (DataIdAndAttrId key in Bcc.Keys)
		{
			if (@class.method_74().Contains(key.DataId))
			{
				Setting setting_ = framework_0.method_32(key);
				method_7(setting_, Bcc[key]);
			}
		}
		if (BcD.Keys.Count != 0 || Bcd.Keys.Count != 0 || BcE.Keys.Count != 0)
		{
			foreach (DataIdAndAttrId item in hashSet_0)
			{
				if (Bcc.Keys.Contains(item))
				{
					continue;
				}
				Setting setting = framework_0.method_32(item);
				if (setting != null && !setting.method_219() && !setting.method_207())
				{
					byte[] array = method_1(setting);
					if (array != null)
					{
						method_7(setting, array);
					}
				}
			}
		}
		method_11(@class, framework_0, hashSet_0);
	}

	private void method_7(Setting setting_0, byte[] byte_0)
	{
		if (byte_0 != null && setting_0 != null && !setting_0.method_219() && !setting_0.method_207())
		{
			int[] int_ = method_2(setting_0, byte_0);
			if (setting_0.method_276(int_, bool_0: true) || setting_0.method_134().Count != 0)
			{
				Form23.smethod_75(setting_0.method_69());
			}
			if (setting_0.method_0().awX.ContainsKey(setting_0.method_64()))
			{
				string string_ = method_0(setting_0.method_64());
				smethod_3(setting_0, string_);
			}
		}
	}

	internal List<Setting> method_8(MenuNode menuNode_0, bool bool_0, bool bool_1)
	{
		HashSet<DataIdAndAttrId> hashSet_ = MenuNode.smethod_1(menuNode_0);
		Framework framework = menuNode_0.method_1();
		List<Setting> list = method_9(framework, hashSet_, bool_0, bool_1);
		if (Bcd.Count != 0 || BcE.Count != 0)
		{
			foreach (int key in Bcd.Keys)
			{
				bool flag = false;
				foreach (Setting item in list)
				{
					if (item is Class244 && item.method_64() == key)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
				Class244 @class = framework.method_31(key) as Class244;
				int[] array = method_3(@class);
				if (array == null)
				{
					continue;
				}
				int int_ = array[0];
				List<Setting> list2 = new List<Setting>();
				PortFunction.smethod_30(int_, @class.method_212(), @class.method_220(), framework, list2, bool_2: false);
				foreach (Setting item2 in list2)
				{
					if (item2.method_74() != 0 && Bcd[key].ContainsKey(item2.method_74()) && !list.Contains(item2))
					{
						list.Add(item2);
					}
				}
				List<Table> list3 = new List<Table>();
				PortFunction.smethod_33(int_, framework, list3, bool_0: false);
				foreach (Table item3 in list3)
				{
					foreach (DataIdAndAttrId item4 in item3.GetIdsContained())
					{
						Setting setting = framework.method_32(item4);
						if (setting != null && setting.method_74() != 0 && Bcd[key].ContainsKey(setting.method_74()) && !list.Contains(setting))
						{
							list.Add(setting);
						}
					}
				}
			}
		}
		return list.Distinct().ToList();
	}

	private List<Setting> method_9(Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0, bool bool_0, bool bool_1)
	{
		List<Setting> list = new List<Setting>();
		if (framework_0.awF.ContainsKey(BCx))
		{
			Class256 @class = framework_0.awF[BCx];
			foreach (DataIdAndAttrId key in Bcc.Keys)
			{
				if (@class.method_74().Contains(key.DataId))
				{
					Setting setting_ = framework_0.method_32(key);
					method_10(list, setting_, Bcc[key], bool_0, bool_1);
				}
			}
			if (BcD.Keys.Count != 0 || Bcd.Keys.Count != 0 || BcE.Keys.Count != 0)
			{
				foreach (DataIdAndAttrId item in hashSet_0)
				{
					if (Bcc.Keys.Contains(item))
					{
						continue;
					}
					Setting setting = framework_0.method_32(item);
					if (setting != null && (!setting.method_219() || !bool_0) && !setting.method_207())
					{
						byte[] array = method_1(setting);
						if (array != null)
						{
							method_10(list, setting, array, bool_0, bool_1);
						}
					}
				}
			}
			method_12(list, @class, framework_0, hashSet_0, bool_0, bool_1);
		}
		return list;
	}

	private void method_10(List<Setting> list_0, Setting setting_0, byte[] byte_0, bool bool_0, bool bool_1)
	{
		if (byte_0 != null && setting_0 != null && (!setting_0.method_219() || !bool_0) && !setting_0.method_207())
		{
			list_0.Add(setting_0);
			if (bool_1 && setting_0.method_0().awX.ContainsKey(setting_0.method_64()))
			{
				string string_ = method_0(setting_0.method_64());
				smethod_4(list_0, setting_0, string_, bool_0, byte_0);
			}
		}
	}

	private void method_11(Class256 class256_0, Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0)
	{
		foreach (int item in class256_0.method_74())
		{
			DataIdAndAttrId dataIdAndAttrId = new DataIdAndAttrId(item);
			if (!Bcc.ContainsKey(dataIdAndAttrId))
			{
				method_13(framework_0, dataIdAndAttrId);
			}
		}
		foreach (int item2 in class256_0.method_73())
		{
			if (!BcD.ContainsKey(item2))
			{
				method_15(framework_0, hashSet_0, item2);
			}
		}
		foreach (int key in class256_0.method_75().Keys)
		{
			foreach (int item3 in class256_0.method_75()[key])
			{
				if (!BcE.ContainsKey(key) || !BcE[key].ContainsKey(item3))
				{
					method_17(framework_0, hashSet_0, item3, key, 0);
				}
			}
		}
		foreach (int key2 in class256_0.method_76().Keys)
		{
			foreach (int item4 in class256_0.method_76()[key2])
			{
				if (!Bcd.ContainsKey(key2) || !Bcd[key2].ContainsKey(item4))
				{
					method_17(framework_0, hashSet_0, item4, 0, key2);
				}
			}
		}
	}

	private void method_12(List<Setting> list_0, Class256 class256_0, Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0, bool bool_0, bool bool_1)
	{
		foreach (int item in class256_0.method_74())
		{
			DataIdAndAttrId dataIdAndAttrId = new DataIdAndAttrId(item);
			if (!Bcc.ContainsKey(dataIdAndAttrId))
			{
				method_14(list_0, framework_0, dataIdAndAttrId, bool_0, bool_1);
			}
		}
		foreach (int item2 in class256_0.method_73())
		{
			if (!BcD.ContainsKey(item2))
			{
				method_16(list_0, framework_0, hashSet_0, item2, bool_0, bool_1);
			}
		}
		foreach (int key in class256_0.method_75().Keys)
		{
			foreach (int item3 in class256_0.method_75()[key])
			{
				if (!BcE.ContainsKey(key) || !BcE[key].ContainsKey(item3))
				{
					method_18(list_0, framework_0, hashSet_0, item3, key, 0);
				}
			}
		}
		foreach (int key2 in class256_0.method_76().Keys)
		{
			foreach (int item4 in class256_0.method_76()[key2])
			{
				if (!Bcd.ContainsKey(key2) || !Bcd[key2].ContainsKey(item4))
				{
					method_18(list_0, framework_0, hashSet_0, item4, 0, key2);
				}
			}
		}
	}

	private void method_13(Framework framework_0, DataIdAndAttrId dataIdAndAttrId_0)
	{
		Setting setting = framework_0.method_32(dataIdAndAttrId_0);
		if (setting != null)
		{
			if (setting.method_246(bool_0: true) || setting.method_134().Count != 0)
			{
				Form23.smethod_75(setting.method_69());
			}
			if (framework_0.awX.ContainsKey(dataIdAndAttrId_0.DataId))
			{
				string string_ = method_0(dataIdAndAttrId_0.DataId);
				smethod_3(setting, string_);
			}
		}
	}

	private void method_14(List<Setting> list_0, Framework framework_0, DataIdAndAttrId dataIdAndAttrId_0, bool bool_0, bool bool_1)
	{
		Setting setting = framework_0.method_32(dataIdAndAttrId_0);
		if (setting != null)
		{
			list_0.Add(setting);
			if (bool_1 && framework_0.awX.ContainsKey(dataIdAndAttrId_0.DataId))
			{
				byte[] byte_ = (framework_0.aWR ? setting.method_244() : Class23.smethod_7(setting.method_244(), setting.method_199()));
				string string_ = method_0(dataIdAndAttrId_0.DataId);
				smethod_4(list_0, setting, string_, bool_0, byte_);
			}
		}
	}

	private void method_15(Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0, int int_0)
	{
		Setting setting = smethod_0(framework_0, hashSet_0, int_0);
		if (setting != null)
		{
			if (setting.method_246(bool_0: true) || setting.method_134().Count != 0)
			{
				Form23.smethod_75(setting.method_69());
			}
			if (framework_0.awX.ContainsKey(setting.method_64()))
			{
				string string_ = method_0(setting.method_64());
				smethod_3(setting, string_);
			}
		}
	}

	private void method_16(List<Setting> list_0, Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0, int int_0, bool bool_0, bool bool_1)
	{
		Setting setting = smethod_0(framework_0, hashSet_0, int_0);
		if (setting != null)
		{
			list_0.Add(setting);
			if (bool_1 && framework_0.awX.ContainsKey(setting.method_64()))
			{
				byte[] byte_ = (framework_0.aWR ? setting.method_244() : Class23.smethod_7(setting.method_244(), setting.method_199()));
				string string_ = method_0(setting.method_64());
				smethod_4(list_0, setting, string_, bool_0, byte_);
			}
		}
	}

	private void method_17(Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0, int int_0, int int_1, int int_2)
	{
		Setting setting = smethod_1(framework_0, hashSet_0, int_0, int_1, int_2);
		if (setting != null && (setting.method_246(bool_0: true) || setting.method_134().Count != 0))
		{
			Form23.smethod_75(setting.method_69());
		}
	}

	private void method_18(List<Setting> list_0, Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0, int int_0, int int_1, int int_2)
	{
		Setting setting = smethod_1(framework_0, hashSet_0, int_0, int_1, int_2);
		if (setting != null)
		{
			list_0.Add(setting);
		}
	}

	internal bool method_19(Class286 class286_0)
	{
		if (BCx != class286_0.BCx)
		{
			return false;
		}
		if (!string.IsNullOrEmpty(BCy) && !string.IsNullOrEmpty(class286_0.BCy) && !(BCy != class286_0.BCy))
		{
			if (BCX != class286_0.BCX)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	internal bool method_20()
	{
		lock (Form23.object_0)
		{
			foreach (Class287 value in Form23.dictionary_1.Values)
			{
				if (value.BcF != this && method_19(value.BcF) && value.BcF.BCY > BCY)
				{
					return false;
				}
			}
		}
		return true;
	}

	internal static Class286 smethod_2(int int_0, string string_0)
	{
		Version version = null;
		Class286 result = null;
		lock (Form23.object_0)
		{
			foreach (Class287 value in Form23.dictionary_1.Values)
			{
				if (value.BcF.BCx == int_0 && value.BcF.BCX == string_0 && (version == null || value.BcF.BCY > version))
				{
					version = value.BcF.BCY;
					result = value.BcF;
				}
			}
			return result;
		}
	}

	private static bool smethod_3(Setting setting_0, string string_0)
	{
		lock (Form23.object_0)
		{
			MenuNode menuNode_ = setting_0.method_0().awX[setting_0.method_64()];
			if (!string.IsNullOrEmpty(string_0))
			{
				Class286 @class = smethod_2(setting_0.method_8(), string_0);
				if (@class != null)
				{
					byte[] byte_ = Class24.smethod_1(@class.BCw);
					if (setting_0.method_275(byte_, bool_0: true))
					{
						Form23.smethod_75(setting_0.method_69());
					}
					@class.method_5(menuNode_);
					return true;
				}
			}
			else
			{
				string key = Class24.smethod_0(setting_0.method_259());
				if (Form23.dictionary_1.ContainsKey(key))
				{
					Form23.dictionary_1[key].BcF.method_5(menuNode_);
					return true;
				}
			}
		}
		return false;
	}

	private static void smethod_4(List<Setting> list_0, Setting setting_0, string string_0, bool bool_0, byte[] byte_0)
	{
		if (byte_0.Length != setting_0.method_278())
		{
			return;
		}
		lock (Form23.object_0)
		{
			MenuNode menuNode_ = setting_0.method_0().awX[setting_0.method_64()];
			if (!string.IsNullOrEmpty(string_0))
			{
				Class286 @class = smethod_2(setting_0.method_8(), string_0);
				if (@class != null)
				{
					list_0.AddRange(@class.method_8(menuNode_, bool_0, bool_1: true));
				}
			}
			else
			{
				string key = Class24.smethod_0(byte_0);
				if (Form23.dictionary_1.ContainsKey(key))
				{
					list_0.AddRange(Form23.dictionary_1[key].BcF.method_8(menuNode_, bool_0, bool_1: true));
				}
			}
		}
	}

	internal static bool smethod_5(Setting setting_0)
	{
		Framework framework = setting_0.method_0();
		if (framework.method_2() && framework.method_3())
		{
			if (setting_0.method_96())
			{
				return true;
			}
			if (framework.awX.ContainsKey(setting_0.method_64()) && framework.awF.ContainsKey(setting_0.method_8()))
			{
				MenuNode menuNode = framework.awX[setting_0.method_64()];
				Class256 @class = framework.awF[setting_0.method_8()];
				if (menuNode != null && @class != null)
				{
					foreach (Setting item in @class.method_88(menuNode))
					{
						if (item.method_96())
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	internal static bool smethod_6(Framework framework_0, Class286 class286_0)
	{
		if (!(class286_0.BCZ == null) && !Class242.smethod_12(framework_0.awZ) && class286_0.BCZ.method_1() > 30)
		{
			return framework_0.aXA.method_1() >= class286_0.BCZ.method_1();
		}
		return true;
	}

	internal static bool smethod_7(Setting setting_0)
	{
		try
		{
			if (setting_0 != null)
			{
				lock (Form23.object_0)
				{
					foreach (string key in Form23.dictionary_1.Keys)
					{
						Class286 bcF = Form23.dictionary_1[key].BcF;
						if (bcF.BCx == setting_0.method_8() && smethod_6(setting_0.method_0(), bcF))
						{
							if (setting_0.method_10() == null || setting_0.method_10().Count == 0)
							{
								return true;
							}
							if (smethod_8(setting_0, bcF))
							{
								return true;
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.avH() + ex.Message);
		}
		return false;
	}

	private static bool smethod_8(Setting setting_0, Class286 class286_0)
	{
		foreach (string key in setting_0.method_10().Keys)
		{
			if (class286_0.Bcb.ContainsKey(key))
			{
				string[] array = setting_0.method_10()[key].Split(',');
				bool flag = false;
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (class286_0.Bcb[key] == text)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
				continue;
			}
			return false;
		}
		return true;
	}

	internal static List<(Class287 PartialMapDataAndPath, string IllegalityReasons)> smethod_9(MenuNode menuNode_0, Setting setting_0, bool bool_0)
	{
		List<(Class287, string)> list = new List<(Class287, string)>();
		lock (Form23.object_0)
		{
			foreach (Class287 value in Form23.dictionary_1.Values)
			{
				if (value.BcF.BCx == setting_0.method_8())
				{
					string text = smethod_10(menuNode_0, setting_0, value.BcF);
					if (bool_0 || string.IsNullOrEmpty(text))
					{
						list.Add((value, text));
					}
				}
			}
			return list;
		}
	}

	internal static string smethod_10(MenuNode menuNode_0, Setting setting_0, Class286 class286_0)
	{
		string text = string.Empty;
		if (!smethod_6(setting_0.method_0(), class286_0))
		{
			text = text + Class333.avh() + class286_0.BCZ.ToString() + Class333.avI();
		}
		if (setting_0.method_10() != null && setting_0.method_10().Count != 0 && !smethod_8(setting_0, class286_0))
		{
			if (text != string.Empty)
			{
				text += Class333.smethod_1812();
			}
			text += Class333.avi();
		}
		if (smethod_11(setting_0.method_0()))
		{
			List<Setting> list = class286_0.method_8(menuNode_0, bool_0: false, bool_1: true);
			List<Setting> list2 = new List<Setting>();
			foreach (Setting item in list)
			{
				List<Setting.ListItems.Struct45> list3 = item.method_103();
				if (list3.Count == 0)
				{
					continue;
				}
				int[] array = class286_0.method_3(item);
				if (array == null || array.Length != 1)
				{
					continue;
				}
				bool flag = false;
				for (int i = 0; i < list3.Count; i++)
				{
					if (list3[i].bBv == array[0])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list2.Add(item);
				}
			}
			if (list2.Count != 0)
			{
				if (text != string.Empty)
				{
					text += Class333.smethod_1812();
				}
				text += Class333.avJ();
				foreach (Setting item2 in list2)
				{
					text = text + Class333.avj() + item2.method_60(Enum96.aYt);
				}
			}
		}
		return text;
	}

	private static bool smethod_11(Framework framework_0)
	{
		if (framework_0.awZ != 21 && framework_0.awZ != 20 && framework_0.awZ != 25)
		{
			return true;
		}
		if ((framework_0.awZ == 20 || framework_0.awZ == 25) && framework_0.aXA >= new Class14(1, 27, 0, 1, 0))
		{
			return true;
		}
		if (framework_0.awZ == 21 && framework_0.aXA >= new Class14(2, 27, 0, 1, 0))
		{
			return true;
		}
		return false;
	}

	internal static string smethod_12(string string_0, string string_1)
	{
		string result = string_0;
		if (string_0 != null)
		{
			switch (string_0.Length)
			{
			case 4:
				switch (string_0[0])
				{
				case 'l':
					if (string_0 == Class333.avl())
					{
						result = Class333.aWM();
					}
					break;
				case 'h':
					if (string_0 == Class333.avL())
					{
						result = Class333.aWg();
					}
					break;
				case 'y':
					if (string_0 == Class333.avk())
					{
						result = Class333.aWc();
					}
					break;
				case 't':
					if (string_0 == Class333.aIB())
					{
						result = Class333.aiv();
					}
					break;
				case 'm':
					if (string_0 == Class333.avK())
					{
						result = Class333.aWB();
					}
					break;
				}
				break;
			case 5:
				if (string_0 == Class333.avn())
				{
					result = Class333.aWb();
				}
				break;
			case 6:
				switch (string_0[0])
				{
				case 's':
					if (string_0 == Class333.avP())
					{
						result = Class333.aWN();
					}
					break;
				case 'l':
					if (string_0 == Class333.avo())
					{
						result = Class333.aWh();
					}
					break;
				case 'e':
					if (string_0 == Class333.avO())
					{
						result = Class333.aWC();
					}
					break;
				}
				break;
			case 7:
				switch (string_0[0])
				{
				case 'v':
					if (string_0 == Class333.agI())
					{
						result = Class333.agg();
					}
					break;
				case 't':
					if (string_0 == Class333.avV())
					{
						result = Class333.aTB();
					}
					break;
				case 'g':
					if (string_0 == Class333.avv())
					{
						result = Class333.aWL();
					}
					break;
				}
				break;
			case 8:
				switch (string_0[0])
				{
				case 'd':
					if (string_0 == Class333.avx())
					{
						result = Class333.smethod_941();
					}
					break;
				case 'c':
					if (string_0 == Class333.avX())
					{
						result = Class333.aWf();
					}
					break;
				}
				break;
			case 9:
				if (string_0 == Class333.avY())
				{
					result = Class333.aWH();
				}
				break;
			case 10:
				switch (string_0[0])
				{
				case 'y':
					if (string_0 == Class333.avp())
					{
						result = Class333.aWc();
					}
					break;
				case 'r':
					if (string_0 == Class333.ajH())
					{
						result = Class333.aWm();
					}
					break;
				case 'g':
					if (string_0 == Class333.avQ())
					{
						result = Class333.aWe();
					}
					break;
				}
				break;
			case 11:
				switch (string_0[0])
				{
				case 's':
					if (string_0 == Class333.avM())
					{
						result = Class333.aWA();
					}
					break;
				case 'p':
					if (string_0 == Class333.avm())
					{
						result = Class333.aWd();
					}
					break;
				}
				break;
			case 12:
				switch (string_0[0])
				{
				case 't':
					if (string_0 == Class333.avr())
					{
						result = Class333.aWl();
					}
					break;
				case 'm':
					if (string_0 == Class333.avq())
					{
						result = Class333.aWD();
					}
					break;
				case 'i':
					if (string_0 == Class333.avR())
					{
						result = Class333.aWk();
					}
					break;
				}
				break;
			case 13:
				switch (string_0[0])
				{
				case 't':
					if (string_0 == Class333.avU())
					{
						result = Class333.aWK();
					}
					break;
				case 's':
					if (string_0 == Class333.avt())
					{
						result = Class333.aWE();
					}
					break;
				case 'e':
					if (string_0 == Class333.avu())
					{
						result = Class333.aWn();
					}
					break;
				}
				break;
			case 14:
				switch (string_0[0])
				{
				case 'c':
					if (string_0 == Class333.avw())
					{
						result = Class333.aka();
					}
					break;
				case 'b':
					if (string_0 == Class333.avW())
					{
						result = Class333.aWF();
					}
					break;
				}
				break;
			case 15:
				if (string_0 == Class333.avN())
				{
					result = Class333.aWa();
				}
				break;
			case 16:
				if (string_0 == Class333.avy())
				{
					result = Class333.aWI();
				}
				break;
			case 17:
				switch (string_0[0])
				{
				case 'p':
					if (string_0 == Class333.avS())
					{
						result = Class333.aWD();
					}
					break;
				case 'm':
					if (string_0 == Class333.avT())
					{
						result = Class333.aWi();
					}
					break;
				case 'c':
					if (string_0 == Class333.avs())
					{
						result = Class333.aWG();
					}
					break;
				}
				break;
			case 18:
				if (string_0 == Class333.avZ())
				{
					result = Class333.aWJ();
				}
				break;
			case 19:
				if (string_0 == Class333.avz())
				{
					result = Class333.aWj();
				}
				break;
			}
		}
		return result;
	}

	internal static string smethod_13(Framework framework_0, MenuNode menuNode_0, Setting setting_0)
	{
		if (setting_0 != null)
		{
			string text = setting_0.method_60(Enum96.aYu);
			if (!string.IsNullOrEmpty(text) && !Class242.smethod_12(framework_0.awZ) && ((framework_0.awZ == 21 && framework_0.aXA >= new Class14(2, 33, 0, 3, 0)) || (framework_0.awZ != 21 && framework_0.aXA >= new Class14(1, 33, 0, 3, 0))))
			{
				return text;
			}
		}
		if (!string.IsNullOrEmpty(menuNode_0.method_71()))
		{
			return menuNode_0.method_71();
		}
		return Class333.aWO() + menuNode_0.method_10();
	}
}
