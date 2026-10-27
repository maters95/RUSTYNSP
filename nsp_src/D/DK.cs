using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using NSP.SettingsFramework;

namespace D;

internal class DK : SpecialObject
{
	private Di ByL;

	private List<Dk> Byl = new List<Dk>();

	internal DK(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
		ByL = P_2 as Di;
	}

	public override string ToString()
	{
		return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhS() + B();
	}

	internal new void A()
	{
		ByL.E().IndexOf(this);
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject is Dk)
			{
				Dk dk = settingOrSpecialObject as Dk;
				Byl.Add(dk);
				dk.A();
			}
		}
	}

	[SpecialName]
	internal new List<Dk> a()
	{
		return Byl;
	}

	internal new int B()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		Enumerator<Dk> enumerator = Byl.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.B().ax() != 0)
				{
					num++;
				}
			}
			return num;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal new void A(bool P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<Dk> enumerator = Byl.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.B().a(0, P_0);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		int num = ByL.E().IndexOf(this);
		for (int i = 0; i < m_framework.awR.c().Count; i++)
		{
			MenuNode menuNode = m_framework.awR.c()[i];
			if (menuNode.l() && menuNode.m() == num)
			{
				m_framework.A(menuNode.W())?.J(P_0);
				break;
			}
		}
	}

	private void A(List<SettingOrSpecialObject> P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<SettingOrSpecialObject> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (current is Setting)
				{
					(current as Setting).aT();
				}
				if (current.a().Count != 0)
				{
					A(current.a());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal new void b()
	{
		if (((SettingOrSpecialObject)this).a().Count != 0)
		{
			A(((SettingOrSpecialObject)this).a());
		}
	}

	internal bool A(int P_0, int P_1)
	{
		List<SettingOrSpecialObject> val = Enumerable.ToList<SettingOrSpecialObject>(Enumerable.Cast<SettingOrSpecialObject>((System.Collections.IEnumerable)Byl));
		return SettingOrSpecialObject.A(m_framework, val, P_0, P_1);
	}
}
internal class Dk : Setting
{
	private DK ByM;

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

	internal Dk(Framework P_0, string P_1, int P_2, int P_3, SettingOrSpecialObject P_4, string P_5)
		: base(P_0, false, P_1, P_2, P_3, P_4, P_5)
	{
		ByM = P_4 as DK;
	}

	public override string ToString()
	{
		if (ByN != null && Byn != null && Byt != null)
		{
			return string.Concat(new string[8]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhs(),
				B().ax().ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhT(),
				Byt.ay(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bht(),
				ByN.ax().ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhU(),
				Byn.ax().ToString()
			});
		}
		return base.ToString();
	}

	internal new void A()
	{
		int num = m_framework.awP.E().IndexOf(ByM);
		int num2 = ByM.a().IndexOf(this);
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIT() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhu() + num2;
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhV())
			{
				Bym = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhv())
			{
				ByN = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhW())
			{
				Byn = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhw())
			{
				ByO = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhX())
			{
				Byo = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhx())
			{
				ByP = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhY())
			{
				Byp = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhy())
			{
				Byt = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhZ())
			{
				ByQ = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhz())
			{
				Byq = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIA())
			{
				ByR = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIa())
			{
				Byr = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIB())
			{
				ByS = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIb())
			{
				Bys = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIC())
			{
				ByT = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIc())
			{
				ByU = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BID())
			{
				Byu = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BId())
			{
				ByV = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIE())
			{
				Byv = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIe())
			{
				ByW = settingOrSpecialObject as Setting;
			}
		}
		if (ByT != null)
		{
			if (Byq != null && Byq.w().DataId == 0)
			{
				Byq.A(ByT.C());
			}
			if (ByR != null && ByR.w().DataId == 0)
			{
				ByR.A(ByT.C());
			}
			if (Byr != null && Byr.w().DataId == 0)
			{
				Byr.A(ByT.C());
			}
			if (ByS != null && ByS.w().DataId == 0)
			{
				ByS.A(ByT.C());
			}
		}
		if (Byt != null)
		{
			((SettingOrSpecialObject)this).B(Byt.A());
		}
	}

	internal new void a()
	{
		aT();
		if (((SettingOrSpecialObject)this).a().Count != 0)
		{
			A(((SettingOrSpecialObject)this).a());
		}
	}

	private void A(List<SettingOrSpecialObject> P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<SettingOrSpecialObject> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (current is Setting)
				{
					(current as Setting).aT();
				}
				if (current.a().Count != 0)
				{
					A(current.a());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	[SpecialName]
	internal new Setting B()
	{
		return this;
	}

	[SpecialName]
	internal new Setting b()
	{
		return Bym;
	}

	[SpecialName]
	internal new Setting C()
	{
		return ByN;
	}

	[SpecialName]
	internal new Setting c()
	{
		return Byn;
	}

	[SpecialName]
	internal new Setting D()
	{
		return ByO;
	}

	[SpecialName]
	internal new Setting d()
	{
		return Byo;
	}

	[SpecialName]
	internal new Setting E()
	{
		return ByP;
	}

	[SpecialName]
	internal new Setting e()
	{
		return Byt;
	}

	[SpecialName]
	internal new Setting F()
	{
		return Byp;
	}

	[SpecialName]
	internal new Setting f()
	{
		return ByQ;
	}

	[SpecialName]
	internal new Setting G()
	{
		return Byq;
	}

	[SpecialName]
	internal new Setting g()
	{
		return ByR;
	}

	[SpecialName]
	internal new Setting H()
	{
		return Byr;
	}

	[SpecialName]
	internal new Setting h()
	{
		return ByS;
	}

	[SpecialName]
	internal new Setting I()
	{
		return Bys;
	}

	[SpecialName]
	internal new Setting i()
	{
		return ByT;
	}

	[SpecialName]
	internal new Setting J()
	{
		return Byv;
	}

	[SpecialName]
	internal new Setting j()
	{
		return ByW;
	}

	[SpecialName]
	internal new Setting K()
	{
		return ByU;
	}

	[SpecialName]
	internal new Setting k()
	{
		return Byu;
	}

	[SpecialName]
	internal new Setting L()
	{
		return ByV;
	}
}
