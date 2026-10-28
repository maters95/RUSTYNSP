using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns6;

namespace ns3;

internal class Class256 : SpecialObject
{
	private int Bzi;

	private List<int> BzJ = new List<int>();

	private List<int> Bzj = new List<int>();

	private Dictionary<int, List<int>> BzK = new Dictionary<int, List<int>>();

	private Dictionary<int, List<int>> Bzk = new Dictionary<int, List<int>>();

	private List<string> BzL = new List<string>();

	private List<string> Bzl = new List<string>();

	private List<string> BzM = new List<string>();

	private Dictionary<string, string[]> Bzm = new Dictionary<string, string[]>();

	private string BzN;

	private bool Bzn;

	private string BzO;

	private Dictionary<int, string[]> Bzo = new Dictionary<int, string[]>();

	internal Class256(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	[SpecialName]
	internal int method_71()
	{
		return Bzi;
	}

	[SpecialName]
	internal void method_72(int int_0)
	{
		Bzi = int_0;
	}

	[SpecialName]
	internal List<int> method_73()
	{
		return BzJ;
	}

	[SpecialName]
	internal List<int> method_74()
	{
		return Bzj;
	}

	[SpecialName]
	internal Dictionary<int, List<int>> method_75()
	{
		return BzK;
	}

	[SpecialName]
	internal Dictionary<int, List<int>> method_76()
	{
		return Bzk;
	}

	[SpecialName]
	internal List<string> method_77()
	{
		return BzL;
	}

	[SpecialName]
	internal List<string> method_78()
	{
		return Bzl;
	}

	[SpecialName]
	internal List<string> method_79()
	{
		return BzM;
	}

	[SpecialName]
	internal Dictionary<string, string[]> method_80()
	{
		return Bzm;
	}

	[SpecialName]
	internal string method_81()
	{
		return BzN;
	}

	[SpecialName]
	internal void method_82(string string_0)
	{
		BzN = string_0;
	}

	[SpecialName]
	internal bool method_83()
	{
		return Bzn;
	}

	[SpecialName]
	internal void method_84(bool bool_0)
	{
		Bzn = bool_0;
	}

	[SpecialName]
	internal string method_85()
	{
		return BzO;
	}

	[SpecialName]
	internal void method_86(string string_0)
	{
		BzO = string_0;
	}

	[SpecialName]
	internal Dictionary<int, string[]> method_87()
	{
		return Bzo;
	}

	internal List<Setting> method_88(MenuNode menuNode_0, bool bool_0 = false)
	{
		List<Setting> list = new List<Setting>();
		foreach (int item in method_74())
		{
			Setting setting = m_framework.method_31(item);
			if (setting == null)
			{
				continue;
			}
			list.Add(setting);
			if (!bool_0 || !m_framework.awX.ContainsKey(setting.method_64()))
			{
				continue;
			}
			MenuNode menuNode_1 = m_framework.awX[setting.method_64()];
			if (!m_framework.awF.ContainsKey(setting.method_8()))
			{
				continue;
			}
			foreach (Setting item2 in m_framework.awF[setting.method_8()].method_88(menuNode_1, bool_0: true))
			{
				list.Add(item2);
			}
		}
		if (method_73().Count != 0 || method_75().Count != 0 || method_76().Count != 0)
		{
			HashSet<DataIdAndAttrId> hashSet = MenuNode.smethod_1(menuNode_0);
			foreach (int item3 in method_73())
			{
				Setting setting2 = Class286.smethod_0(m_framework, hashSet, item3);
				if (setting2 != null)
				{
					list.Add(setting2);
				}
			}
			foreach (int key in method_75().Keys)
			{
				foreach (int item4 in method_75()[key])
				{
					Setting setting3 = Class286.smethod_1(m_framework, hashSet, item4, key, 0);
					if (setting3 != null)
					{
						list.Add(setting3);
					}
				}
			}
			foreach (int key2 in method_76().Keys)
			{
				Class244 class244_ = m_framework.method_31(key2) as Class244;
				List<Setting> list2 = new List<Setting>();
				PortFunction.smethod_31(class244_, list2, bool_0: false);
				foreach (Setting item5 in list2)
				{
					hashSet.Add(item5.method_69());
				}
				List<Table> list3 = new List<Table>();
				PortFunction.smethod_34(class244_, list3, bool_0: false);
				foreach (Table item6 in list3)
				{
					foreach (DataIdAndAttrId item7 in item6.GetIdsContained())
					{
						hashSet.Add(item7);
					}
				}
				foreach (int item8 in method_76()[key2])
				{
					Setting setting4 = Class286.smethod_1(m_framework, hashSet, item8, 0, key2);
					if (setting4 != null)
					{
						list.Add(setting4);
					}
				}
			}
		}
		return list;
	}
}
