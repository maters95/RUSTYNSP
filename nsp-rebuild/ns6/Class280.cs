using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns4;

namespace ns6;

internal class Class280
{
	private Framework BCH;

	private List<Class278> BCh = new List<Class278>();

	private int BCI = -1;

	private bool BCi;

	internal Class280(Framework framework_0)
	{
		BCH = framework_0;
	}

	[SpecialName]
	internal bool method_0()
	{
		return BCi;
	}

	internal void method_1()
	{
		method_3(new DataIdAndAttrId(0, 0));
	}

	internal void method_2(int int_0)
	{
		method_3(new DataIdAndAttrId(int_0));
	}

	internal void method_3(DataIdAndAttrId dataIdAndAttrId_0)
	{
		if (BCH != null && !Form23.bool_52)
		{
			BCi = true;
			if (BCI < BCh.Count - 1)
			{
				BCh.RemoveRange(BCI + 1, BCh.Count - (BCI + 1));
			}
			BCh.Add(new Class278(dataIdAndAttrId_0));
			BCI++;
		}
	}

	internal void method_4()
	{
		if (BCh.Count != 0 && BCh[BCh.Count - 1].method_4().Count == 0)
		{
			BCh.RemoveAt(BCh.Count - 1);
			BCI--;
		}
		BCi = false;
	}

	internal Class278 method_5()
	{
		return BCh[BCh.Count - 1];
	}

	internal void method_6()
	{
		if (!method_11())
		{
			return;
		}
		BCH.method_55();
		Class278 @class = BCh[BCI];
		BCI--;
		foreach (Class279 item in @class.method_4())
		{
			BCH.method_32(item.BCF).method_268();
		}
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		for (int num = @class.method_4().Count - 1; num >= 0; num--)
		{
			Class279 class2 = @class.method_4()[num];
			Setting setting = BCH.method_32(class2.BCF);
			int count = class2.BCG.Count;
			int bCf = class2.BCf;
			for (int i = 0; i < count; i++)
			{
				byte byte_ = class2.BCG[i];
				setting.method_270(bCf + i, byte_, bool_0: true);
			}
			hashSet.Add(class2.BCF);
		}
		foreach (DataIdAndAttrId item2 in hashSet)
		{
			BCH.method_32(item2).method_267(bool_0: true);
			if (BCH.awX.ContainsKey(item2.DataId))
			{
				MenuNode menuNode = BCH.awX[item2.DataId];
				menuNode.method_81();
				if (!menuNode.method_90())
				{
					menuNode.method_85(bool_0: true);
				}
				Form23.form23_0.control4_0.method_14(bool_7: true, bool_8: true, bool_9: true, bool_10: true);
				Form23.form23_0.control4_0.method_39(bool_7: false);
				if (Form23.framework_0 != null)
				{
					Form23.form23_0.control4_0.method_40(bool_7: false);
				}
			}
		}
		if (@class.method_5().DataId != 0)
		{
			Form23.dataIdAndAttrId_0 = @class.method_5();
		}
		if (hashSet.Count == 1)
		{
			Setting setting_ = BCH.method_32(hashSet.Single());
			BCH.method_54(bool_0: true, setting_);
		}
		else
		{
			BCH.method_54(bool_0: true);
		}
		foreach (DataIdAndAttrId item3 in hashSet)
		{
			Form23.smethod_75(item3);
		}
	}

	internal void method_7()
	{
		if (!method_12())
		{
			return;
		}
		BCH.method_55();
		BCI++;
		Class278 @class = BCh[BCI];
		foreach (Class279 item in @class.method_4())
		{
			BCH.method_32(item.BCF).method_268();
		}
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		foreach (Class279 item2 in @class.method_4())
		{
			Setting setting = BCH.method_32(item2.BCF);
			int count = item2.BCg.Count;
			int bCf = item2.BCf;
			for (int i = 0; i < count; i++)
			{
				byte byte_ = item2.BCg[i];
				setting.method_270(bCf + i, byte_, bool_0: true);
			}
			hashSet.Add(item2.BCF);
		}
		foreach (DataIdAndAttrId item3 in hashSet)
		{
			BCH.method_32(item3).method_267(bool_0: true);
			if (BCH.awX.ContainsKey(item3.DataId))
			{
				MenuNode menuNode = BCH.awX[item3.DataId];
				menuNode.method_81();
				if (!menuNode.method_90())
				{
					menuNode.method_85(bool_0: true);
				}
				Form23.form23_0.control4_0.method_14(bool_7: true, bool_8: true, bool_9: true, bool_10: true);
				Form23.form23_0.control4_0.method_39(bool_7: false);
				if (Form23.framework_0 != null)
				{
					Form23.form23_0.control4_0.method_40(bool_7: false);
				}
			}
		}
		if (@class.method_5().DataId != 0)
		{
			Form23.dataIdAndAttrId_0 = @class.method_5();
		}
		if (hashSet.Count == 1)
		{
			Setting setting_ = BCH.method_32(hashSet.Single());
			BCH.method_54(bool_0: true, setting_);
		}
		else
		{
			BCH.method_54(bool_0: true);
		}
		foreach (DataIdAndAttrId item4 in hashSet)
		{
			Form23.smethod_75(item4);
		}
	}

	internal string method_8()
	{
		if (method_11())
		{
			return BCh[BCI].method_0(BCH);
		}
		return string.Empty;
	}

	internal string method_9()
	{
		if (method_12())
		{
			return BCh[BCI + 1].method_0(BCH);
		}
		return string.Empty;
	}

	internal void method_10()
	{
		BCh.Clear();
		BCI = -1;
		BCi = false;
	}

	internal bool method_11()
	{
		if ((BCH == null || BCH.method_4()) && BCI != -1)
		{
			return BCh.Count != 0;
		}
		return false;
	}

	internal bool method_12()
	{
		if ((BCH == null || BCH.method_4()) && BCI < BCh.Count - 1)
		{
			return BCh.Count != 0;
		}
		return false;
	}
}
