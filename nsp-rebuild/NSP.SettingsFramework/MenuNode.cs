using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class MenuNode
{
	private List<MenuNode> aXq = new List<MenuNode>();

	private string aXR;

	private bool aXr;

	private bool aXS;

	private bool aXs = true;

	private bool aXT;

	private int aXt = -1;

	private int aXU = -1;

	private bool aXu;

	private bool aXV;

	private bool aXv;

	private bool aXW;

	private int aXw = -1;

	private int aXX = -1;

	private int aXx = -1;

	private bool aXY;

	private bool aXy;

	private string aXZ;

	private int aXz;

	private int axA = -1;

	private int axa;

	private string axB;

	private string axb;

	private string axC;

	private string axc;

	private string axD;

	private List<string> axd = new List<string>();

	private int axE = -1;

	private bool axe;

	private bool axF;

	private bool axf;

	private bool axG = true;

	private bool axg = true;

	private bool axH;

	private bool axh = true;

	private bool axI;

	private string axi;

	private Class287 axJ;

	private int axj;

	private bool axK;

	private MenuNode axk;

	private string axL;

	private HashSet<DataIdAndAttrId> axl = new HashSet<DataIdAndAttrId>();

	private HashSet<DataIdAndAttrId> axM = new HashSet<DataIdAndAttrId>();

	private List<int> axm = new List<int>();

	private Framework axN;

	private Class235 axn;

	private int axO;

	private bool axo = true;

	private int axP = -1;

	private List<ModifyOnChange> axp = new List<ModifyOnChange>();

	[CompilerGenerated]
	private readonly Class280 axQ;

	[SpecialName]
	[CompilerGenerated]
	internal Class280 method_0()
	{
		return axQ;
	}

	internal MenuNode(Framework framework_0, Class235 class235_0, MenuNode menuNode_0, bool bool_0, bool bool_1, string string_0)
	{
		axN = framework_0;
		axn = class235_0;
		axk = menuNode_0;
		aXr = bool_0;
		aXS = bool_1;
		aXZ = string_0;
		axQ = new Class280(framework_0);
	}

	public override string ToString()
	{
		if (method_28())
		{
			return aXR + Class333.aMX() + aXt + Class333.aMx() + aXU + Class333.aMY() + aXq.Count + Class333.aMy() + (aXu ? Class333.aMz() : (aXV ? Class333.aMZ() : string.Empty));
		}
		return aXR + Class333.aMY() + aXq.Count + Class333.aMy() + (aXu ? Class333.aMz() : (aXV ? Class333.aMZ() : string.Empty));
	}

	[SpecialName]
	internal Framework method_1()
	{
		return axN;
	}

	[SpecialName]
	internal Class235 method_2()
	{
		return axn;
	}

	[SpecialName]
	internal int method_3()
	{
		return aXz;
	}

	[SpecialName]
	internal void method_4(int int_0)
	{
		aXz = int_0;
	}

	[SpecialName]
	internal MenuNode method_5()
	{
		return axk;
	}

	[SpecialName]
	internal List<MenuNode> method_6()
	{
		return aXq;
	}

	internal bool method_7()
	{
		return aXr;
	}

	[SpecialName]
	internal string method_8()
	{
		return axB;
	}

	[SpecialName]
	internal void method_9(string string_0)
	{
		axB = string_0;
	}

	[SpecialName]
	internal string method_10()
	{
		if (aXR == null)
		{
			return Class333.smethod_102();
		}
		if (axN != null)
		{
			bool flag = true;
			for (int i = 0; i < aXR.Length; i++)
			{
				if (aXR[i] < '0' || aXR[i] > '9')
				{
					flag = false;
					break;
				}
			}
			if (flag && aXR != string.Empty)
			{
				int num = int.Parse(aXR);
				if (num != 0 && num == aXz)
				{
					SettingOrSpecialObject settingOrSpecialObject = axN.method_33(num);
					aXR = settingOrSpecialObject.method_22(bool_0: true);
				}
			}
		}
		return aXR;
	}

	[SpecialName]
	internal void method_11(string string_0)
	{
		aXR = string_0;
	}

	[SpecialName]
	internal int method_12()
	{
		return axj;
	}

	[SpecialName]
	internal void method_13(int int_0)
	{
		axj = int_0;
	}

	[SpecialName]
	internal bool method_14()
	{
		return axK;
	}

	[SpecialName]
	internal void method_15(bool bool_0)
	{
		axK = bool_0;
	}

	[SpecialName]
	internal bool method_16()
	{
		return aXS;
	}

	[SpecialName]
	internal bool method_17()
	{
		return aXT;
	}

	[SpecialName]
	internal void method_18(bool bool_0)
	{
		aXT = bool_0;
	}

	[SpecialName]
	internal string method_19()
	{
		return aXZ;
	}

	[SpecialName]
	internal int method_20()
	{
		return axA;
	}

	[SpecialName]
	internal void method_21(int int_0)
	{
		axA = int_0;
	}

	[SpecialName]
	internal int method_22()
	{
		return axa;
	}

	[SpecialName]
	internal void method_23(int int_0)
	{
		axa = int_0;
	}

	[SpecialName]
	internal int method_24()
	{
		return aXt;
	}

	[SpecialName]
	internal void method_25(int int_0)
	{
		aXt = int_0;
	}

	[SpecialName]
	internal int method_26()
	{
		return aXU;
	}

	[SpecialName]
	internal void method_27(int int_0)
	{
		aXU = int_0;
	}

	internal bool method_28()
	{
		if (aXt != -1)
		{
			return aXU != -1;
		}
		return false;
	}

	[SpecialName]
	internal bool method_29()
	{
		return aXu;
	}

	[SpecialName]
	internal void method_30(bool bool_0)
	{
		aXu = bool_0;
	}

	[SpecialName]
	internal bool method_31()
	{
		return aXV;
	}

	[SpecialName]
	internal void method_32(bool bool_0)
	{
		aXV = bool_0;
	}

	[SpecialName]
	internal bool method_33()
	{
		return aXv;
	}

	[SpecialName]
	internal void method_34(bool bool_0)
	{
		aXv = bool_0;
	}

	[SpecialName]
	internal bool method_35()
	{
		return aXW;
	}

	[SpecialName]
	internal void method_36(bool bool_0)
	{
		aXW = bool_0;
	}

	[SpecialName]
	internal bool method_37()
	{
		return aXw != -1;
	}

	[SpecialName]
	internal bool method_38()
	{
		return aXX != -1;
	}

	[SpecialName]
	internal int method_39()
	{
		return aXw;
	}

	[SpecialName]
	internal void method_40(int int_0)
	{
		aXw = int_0;
	}

	[SpecialName]
	internal int method_41()
	{
		return aXX;
	}

	[SpecialName]
	internal void method_42(int int_0)
	{
		aXX = int_0;
	}

	[SpecialName]
	internal bool method_43()
	{
		return this == axN.awS;
	}

	[SpecialName]
	internal bool method_44()
	{
		return this == axN.awR;
	}

	[SpecialName]
	internal bool method_45()
	{
		return aXx != -1;
	}

	[SpecialName]
	internal int method_46()
	{
		return aXx;
	}

	[SpecialName]
	internal void method_47(int int_0)
	{
		aXx = int_0;
	}

	[SpecialName]
	internal string method_48()
	{
		return axL;
	}

	[SpecialName]
	internal void method_49(string string_0)
	{
		axL = string_0;
	}

	[SpecialName]
	internal bool method_50()
	{
		return aXs;
	}

	[SpecialName]
	internal void method_51(bool bool_0)
	{
		aXs = bool_0;
	}

	[SpecialName]
	internal bool method_52()
	{
		return aXY;
	}

	[SpecialName]
	internal void method_53(bool bool_0)
	{
		aXY = bool_0;
	}

	[SpecialName]
	internal bool method_54()
	{
		return aXy;
	}

	[SpecialName]
	internal void method_55(bool bool_0)
	{
		aXy = bool_0;
	}

	[SpecialName]
	internal int method_56()
	{
		return axO;
	}

	[SpecialName]
	internal void method_57(int int_0)
	{
		axO = int_0;
	}

	[SpecialName]
	internal bool method_58()
	{
		return axo;
	}

	[SpecialName]
	internal void method_59(bool bool_0)
	{
		axo = bool_0;
	}

	[SpecialName]
	internal int method_60()
	{
		return axP;
	}

	[SpecialName]
	internal void method_61(int int_0)
	{
		axP = int_0;
	}

	[SpecialName]
	internal string method_62()
	{
		return axb;
	}

	[SpecialName]
	internal void method_63(string string_0)
	{
		axb = string_0;
	}

	[SpecialName]
	internal string method_64()
	{
		return axC;
	}

	[SpecialName]
	internal void method_65(string string_0)
	{
		axC = string_0;
	}

	[SpecialName]
	internal string method_66()
	{
		return axc;
	}

	[SpecialName]
	internal void method_67(string string_0)
	{
		axc = string_0;
	}

	[SpecialName]
	internal string method_68()
	{
		return axD;
	}

	[SpecialName]
	internal void method_69(string string_0)
	{
		axD = string_0;
	}

	[SpecialName]
	internal List<string> method_70()
	{
		return axd;
	}

	[SpecialName]
	internal string method_71()
	{
		return axi;
	}

	[SpecialName]
	internal void method_72(string string_0)
	{
		axi = string_0;
	}

	[SpecialName]
	internal int method_73()
	{
		return axE;
	}

	[SpecialName]
	internal void method_74(int int_0)
	{
		axE = int_0;
	}

	[SpecialName]
	internal bool method_75()
	{
		return axe;
	}

	[SpecialName]
	internal void method_76(bool bool_0)
	{
		axe = bool_0;
	}

	[SpecialName]
	internal bool method_77()
	{
		return axF;
	}

	[SpecialName]
	internal void method_78(bool bool_0)
	{
		axF = bool_0;
	}

	[SpecialName]
	internal bool method_79()
	{
		return axE != -1;
	}

	[SpecialName]
	internal Class287 method_80()
	{
		return axJ;
	}

	internal void method_81()
	{
		lock (Form23.object_0)
		{
			axJ = null;
			if (!method_79())
			{
				return;
			}
			Setting setting = axN.method_31(axE);
			if (setting != null)
			{
				string key = Class24.smethod_0(setting.method_259());
				if (Form23.dictionary_1.ContainsKey(key))
				{
					axJ = Form23.dictionary_1[key];
				}
			}
		}
	}

	internal bool method_82()
	{
		if (axJ != null && axJ.BcF != null)
		{
			HashSet<DataIdAndAttrId> hashSet = smethod_1(this);
			foreach (DataIdAndAttrId key in axJ.BcF.Bcc.Keys)
			{
				hashSet.Add(key);
			}
			foreach (DataIdAndAttrId item in hashSet)
			{
				Setting setting = axN.method_32(item);
				if (setting != null && !setting.method_76() && !setting.method_219() && !setting.method_207())
				{
					int[] array = axJ.BcF.method_3(setting);
					if (array != null && !setting.method_283(array))
					{
						axI = true;
						return true;
					}
				}
			}
		}
		axI = false;
		return false;
	}

	internal MenuNode method_83(Setting setting_0)
	{
		MenuNode menuNode = this;
		bool flag = false;
		do
		{
			if (!menuNode.method_79() || menuNode.method_80() == null || menuNode.method_80().BcF == null || menuNode.method_80().BcF.method_3(setting_0) == null)
			{
				if (menuNode.method_5() != null)
				{
					menuNode = menuNode.method_5();
				}
				else
				{
					flag = true;
				}
				continue;
			}
			return menuNode;
		}
		while (!flag);
		foreach (MenuNode value in axN.awX.Values)
		{
			if (value.method_80() != null && value.method_80().BcF != null && value.method_80().BcF.Bcc.ContainsKey(setting_0.method_69()))
			{
				return value;
			}
		}
		return null;
	}

	[SpecialName]
	internal bool method_84()
	{
		return axg;
	}

	[SpecialName]
	internal void method_85(bool bool_0)
	{
		axg = bool_0;
	}

	[SpecialName]
	internal bool method_86()
	{
		return axf;
	}

	[SpecialName]
	internal void method_87(bool bool_0)
	{
		axf = bool_0;
	}

	[SpecialName]
	internal bool method_88()
	{
		return axG;
	}

	[SpecialName]
	internal void method_89(bool bool_0)
	{
		axG = bool_0;
	}

	[SpecialName]
	internal bool method_90()
	{
		return axH;
	}

	[SpecialName]
	internal void method_91(bool bool_0)
	{
		axH = bool_0;
		if (axH)
		{
			axg = false;
		}
	}

	[SpecialName]
	internal bool method_92()
	{
		return axh;
	}

	[SpecialName]
	internal void method_93(bool bool_0)
	{
		axh = bool_0;
	}

	[SpecialName]
	internal bool method_94()
	{
		return axI;
	}

	[SpecialName]
	internal void method_95(bool bool_0)
	{
		axI = bool_0;
	}

	internal void method_96(ModifyOnChange modifyOnChange_0)
	{
		axp.Add(modifyOnChange_0);
	}

	[SpecialName]
	internal List<ModifyOnChange> method_97()
	{
		return axp;
	}

	internal bool method_98(out Setting setting_0)
	{
		setting_0 = null;
		bool result = false;
		if (axa != 0)
		{
			setting_0 = axN.method_31(axa);
			result = ((axa != 10195) ? (setting_0 != null && setting_0.method_256() != 1) : (setting_0 != null && setting_0.method_256() == 0));
		}
		return result;
	}

	internal void method_99()
	{
		for (int i = 0; i < aXq.Count; i++)
		{
			aXq[i].method_99();
		}
		method_0().method_10();
	}

	internal string method_100(bool bool_0, bool bool_1)
	{
		if (axn != null)
		{
			return method_10();
		}
		string text = string.Empty;
		List<MenuNode> list = new List<MenuNode>();
		list.Add(this);
		MenuNode menuNode = this;
		bool flag = false;
		do
		{
			if (menuNode.method_5() == null)
			{
				flag = true;
				continue;
			}
			list.Insert(0, menuNode.method_5());
			menuNode = menuNode.method_5();
		}
		while (!flag);
		for (int i = 0; i < list.Count; i++)
		{
			if ((i != 0) | bool_0)
			{
				MenuNode menuNode2 = list[i];
				if (text != string.Empty)
				{
					text = ((!bool_1) ? (text + Class333.smethod_536()) : (text + Class333.smethod_176()));
				}
				text += menuNode2.method_10();
			}
		}
		return text;
	}

	internal bool method_101(bool bool_0)
	{
		foreach (DataIdAndAttrId item in method_104(bool_0: false))
		{
			Setting setting = axN.method_32(item);
			if (setting != null && (setting.method_35() || !bool_0) && ((!setting.method_212() && !setting.method_219() && !setting.method_220()) || axN.awX.ContainsKey(setting.method_64())))
			{
				return false;
			}
		}
		return true;
	}

	internal bool method_102()
	{
		if (!string.IsNullOrEmpty(method_8()) && axN.awn.ContainsKey(method_8()))
		{
			return axN.awn[method_8()].method_18();
		}
		return false;
	}

	internal static bool smethod_0(MenuNode menuNode_0)
	{
		if (menuNode_0.method_102())
		{
			return true;
		}
		foreach (MenuNode item in menuNode_0.method_6())
		{
			if (smethod_0(item))
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	internal List<int> method_103()
	{
		return axm;
	}

	internal HashSet<DataIdAndAttrId> method_104(bool bool_0)
	{
		if (bool_0)
		{
			return axM;
		}
		return axl;
	}

	internal static HashSet<DataIdAndAttrId> smethod_1(MenuNode menuNode_0, bool bool_0 = false)
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		hashSet.UnionWith(menuNode_0.method_104(bool_0: false));
		if (bool_0)
		{
			foreach (int item in menuNode_0.method_103())
			{
				hashSet.Add(new DataIdAndAttrId(item));
			}
		}
		foreach (MenuNode item2 in menuNode_0.method_6())
		{
			HashSet<DataIdAndAttrId> other = smethod_1(item2, bool_0);
			hashSet.UnionWith(other);
		}
		return hashSet;
	}

	internal static MenuNode smethod_2(List<MenuNode> list_0, DataIdAndAttrId dataIdAndAttrId_0)
	{
		int num = 0;
		MenuNode menuNode2;
		while (true)
		{
			if (num < list_0.Count)
			{
				MenuNode menuNode = list_0[num];
				if (menuNode == null || !menuNode.method_104(bool_0: false).Contains(dataIdAndAttrId_0))
				{
					menuNode2 = smethod_2(list_0[num].method_6(), dataIdAndAttrId_0);
					if (menuNode2 != null)
					{
						break;
					}
					num++;
					continue;
				}
				return menuNode;
			}
			return null;
		}
		return menuNode2;
	}

	internal void method_105()
	{
		axl.Clear();
		axM.Clear();
		if (this == Form23.menuNode_0)
		{
			axl.Add(new DataIdAndAttrId(1501));
			axM.Add(new DataIdAndAttrId(1501));
			return;
		}
		if (axa != 0)
		{
			axl.Add(new DataIdAndAttrId(axa));
			axM.Add(new DataIdAndAttrId(axa));
		}
		if (axN == null)
		{
			return;
		}
		SettingOrSpecialObject settingOrSpecialObject = axN.method_33(aXz);
		SettingOrSpecialObject settingOrSpecialObject2 = axN.method_33(axA);
		if (settingOrSpecialObject2 != null)
		{
			List<Class245> list = new List<Class245>();
			PortFunction.smethod_23(settingOrSpecialObject2, bool_0: false, bool_1: true, list, bool_2: true);
			for (int i = 0; i < list.Count; i++)
			{
				Class245 @class = list[i];
				axl.Add(@class.method_69());
				axM.Add(@class.method_69());
			}
			List<Class244> list2 = new List<Class244>();
			PortFunction.smethod_24(settingOrSpecialObject2, bool_0: false, list2, bool_1: true);
			for (int j = 0; j < list2.Count; j++)
			{
				Class244 class2 = list2[j];
				axl.Add(class2.method_69());
				axM.Add(class2.method_69());
				List<Setting> list3 = new List<Setting>();
				PortFunction.smethod_31(class2, list3, bool_0: false, bool_1: true);
				for (int k = 0; k < list3.Count; k++)
				{
					Setting setting = list3[k];
					axl.Add(setting.method_69());
					axM.Add(setting.method_69());
				}
			}
			List<Table> list4 = new List<Table>();
			PortFunction.smethod_25(settingOrSpecialObject2, bool_0: false, list4, bool_1: false);
			for (int l = 0; l < list4.Count; l++)
			{
				Table table = list4[l];
				HashSet<DataIdAndAttrId> idsContained = table.GetIdsContained();
				axl.UnionWith(idsContained);
				HashSet<DataIdAndAttrId> idsContainedForShowingDiffs = table.GetIdsContainedForShowingDiffs();
				axM.UnionWith(idsContainedForShowingDiffs);
			}
			return;
		}
		if (settingOrSpecialObject != null)
		{
			Interface4 @interface = settingOrSpecialObject.method_11();
			if (@interface != null)
			{
				HashSet<DataIdAndAttrId> idsContained2 = @interface.GetIdsContained();
				axl.UnionWith(idsContained2);
				HashSet<DataIdAndAttrId> idsContainedForShowingDiffs2 = @interface.GetIdsContainedForShowingDiffs();
				axM.UnionWith(idsContainedForShowingDiffs2);
			}
			else
			{
				if (settingOrSpecialObject.method_1().Count == 0)
				{
					return;
				}
				for (int m = 0; m < settingOrSpecialObject.method_1().Count; m++)
				{
					SettingOrSpecialObject settingOrSpecialObject3 = settingOrSpecialObject.method_1()[m];
					if (settingOrSpecialObject3 is Setting)
					{
						DataIdAndAttrId item = (settingOrSpecialObject3 as Setting).method_69();
						axM.Add(item);
						axl.Add(item);
					}
				}
			}
			return;
		}
		for (int n = 0; n < aXq.Count; n++)
		{
			MenuNode menuNode = aXq[n];
			bool flag;
			if (!(flag = aXu || menuNode.method_28()))
			{
				MenuNode menuNode2 = this;
				bool flag2 = false;
				do
				{
					if (!menuNode2.aXV)
					{
						if (menuNode2.method_5() != null)
						{
							menuNode2 = menuNode2.method_5();
						}
						else
						{
							flag2 = true;
						}
					}
					else
					{
						flag = true;
					}
				}
				while (!flag2 && !flag);
			}
			if (flag)
			{
				axl.UnionWith(menuNode.method_104(bool_0: false));
				axM.UnionWith(menuNode.method_104(bool_0: true));
			}
		}
	}
}
