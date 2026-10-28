using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns7;

namespace ns3;

internal class Class243 : Setting
{
	private Class250 ByM;

	private Setting Bym;

	private Setting ByN;

	private Setting Byn;

	private Setting ByO;

	private Setting Byo;

	private Setting ByP;

	private Setting Byp;

	private Setting ByQ;

	private Setting Byq;

	private Setting ByR;

	private Setting Byr;

	private Setting ByS;

	private Setting Bys;

	private Setting ByT;

	private Setting Byt;

	private Setting ByU;

	private Setting Byu;

	private Setting ByV;

	private Setting Byv;

	private Setting ByW;

	internal Class243(Framework framework_0, string string_0, int int_0, int int_1, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, bool_0: false, string_0, int_0, int_1, settingOrSpecialObject_0, string_1)
	{
		ByM = settingOrSpecialObject_0 as Class250;
	}

	public override string ToString()
	{
		if (ByN != null && Byn != null && Byt != null)
		{
			return Class333.Bhs() + method_297().method_256() + Class333.BhT() + Byt.method_260() + Class333.Bht() + ByN.method_256() + Class333.BhU() + Byn.method_256();
		}
		return base.ToString();
	}

	internal void method_294()
	{
		int num = m_framework.awP.method_79().IndexOf(ByM);
		int num2 = ByM.method_72().IndexOf(this);
		string text = Class333.aIT() + num + Class333.Bhu() + num2;
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject.method_2() == text + Class333.BhV())
			{
				Bym = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.Bhv())
			{
				ByN = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BhW())
			{
				Byn = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.Bhw())
			{
				ByO = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BhX())
			{
				Byo = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.Bhx())
			{
				ByP = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BhY())
			{
				Byp = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.Bhy())
			{
				Byt = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BhZ())
			{
				ByQ = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.Bhz())
			{
				Byq = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BIA())
			{
				ByR = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BIa())
			{
				Byr = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BIB())
			{
				ByS = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BIb())
			{
				Bys = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BIC())
			{
				ByT = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BIc())
			{
				ByU = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BID())
			{
				Byu = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BId())
			{
				ByV = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BIE())
			{
				Byv = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == text + Class333.BIe())
			{
				ByW = settingOrSpecialObject as Setting;
			}
		}
		if (ByT != null)
		{
			if (Byq != null && Byq.method_163().DataId == 0)
			{
				Byq.method_164(ByT.method_69());
			}
			if (ByR != null && ByR.method_163().DataId == 0)
			{
				ByR.method_164(ByT.method_69());
			}
			if (Byr != null && Byr.method_163().DataId == 0)
			{
				Byr.method_164(ByT.method_69());
			}
			if (ByS != null && ByS.method_163().DataId == 0)
			{
				ByS.method_164(ByT.method_69());
			}
		}
		if (Byt != null)
		{
			method_21(Byt.method_64());
		}
	}

	internal void method_295()
	{
		method_234();
		if (method_1().Count != 0)
		{
			method_296(method_1());
		}
	}

	private void method_296(List<SettingOrSpecialObject> list_0)
	{
		foreach (SettingOrSpecialObject item in list_0)
		{
			if (item is Setting)
			{
				(item as Setting).method_234();
			}
			if (item.method_1().Count != 0)
			{
				method_296(item.method_1());
			}
		}
	}

	[SpecialName]
	internal Setting method_297()
	{
		return this;
	}

	[SpecialName]
	internal Setting method_298()
	{
		return Bym;
	}

	[SpecialName]
	internal Setting method_299()
	{
		return ByN;
	}

	[SpecialName]
	internal Setting method_300()
	{
		return Byn;
	}

	[SpecialName]
	internal Setting method_301()
	{
		return ByO;
	}

	[SpecialName]
	internal Setting method_302()
	{
		return Byo;
	}

	[SpecialName]
	internal Setting method_303()
	{
		return ByP;
	}

	[SpecialName]
	internal Setting method_304()
	{
		return Byt;
	}

	[SpecialName]
	internal Setting method_305()
	{
		return Byp;
	}

	[SpecialName]
	internal Setting method_306()
	{
		return ByQ;
	}

	[SpecialName]
	internal Setting method_307()
	{
		return Byq;
	}

	[SpecialName]
	internal Setting method_308()
	{
		return ByR;
	}

	[SpecialName]
	internal Setting method_309()
	{
		return Byr;
	}

	[SpecialName]
	internal Setting method_310()
	{
		return ByS;
	}

	[SpecialName]
	internal Setting method_311()
	{
		return Bys;
	}

	[SpecialName]
	internal Setting method_312()
	{
		return ByT;
	}

	[SpecialName]
	internal Setting method_313()
	{
		return Byv;
	}

	[SpecialName]
	internal Setting method_314()
	{
		return ByW;
	}

	[SpecialName]
	internal Setting method_315()
	{
		return ByU;
	}

	[SpecialName]
	internal Setting method_316()
	{
		return Byu;
	}

	[SpecialName]
	internal Setting method_317()
	{
		return ByV;
	}
}
