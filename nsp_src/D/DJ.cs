using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using NSP.SettingsFramework;

namespace D;

internal class DJ : SpecialObject
{
	private Dj Byh;

	private Setting ByI;

	private Setting Byi;

	private Setting ByJ;

	private Setting Byj;

	internal DJ(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
		Byh = P_2 as Dj;
	}

	internal new void A()
	{
		int num = Byh.B().IndexOf(this);
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject.B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhP() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhp()))
			{
				ByI = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhP() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhQ()))
			{
				Byi = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhP() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhq()))
			{
				ByJ = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhP() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhR()))
			{
				Byj = settingOrSpecialObject as Setting;
			}
		}
	}

	[SpecialName]
	internal new Setting a()
	{
		return ByI;
	}

	[SpecialName]
	internal new Setting B()
	{
		return Byi;
	}

	[SpecialName]
	internal new Setting b()
	{
		return ByJ;
	}

	[SpecialName]
	internal new Setting C()
	{
		return Byj;
	}
}
internal class Dj : SpecialObject
{
	private List<DJ> ByK = new List<DJ>();

	private Setting Byk;

	internal Dj(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	internal new void A()
	{
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhr())
			{
				Byk = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject is DJ)
			{
				DJ dJ = settingOrSpecialObject as DJ;
				ByK.Add(dJ);
				dJ.A();
			}
		}
	}

	[SpecialName]
	internal new Setting a()
	{
		return Byk;
	}

	[SpecialName]
	internal new List<DJ> B()
	{
		return ByK;
	}

	internal new void b()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DJ> enumerator = ByK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DJ current = enumerator.Current;
				if (current.a().ax() == 0)
				{
					Ck ck = BM.aM();
					ck?.a();
					current.h().A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gt(), true);
					current.a().a(1, true);
					ck?.B();
					BM.b(current.a().A());
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal new void A(int P_0)
	{
		DJ dJ = ByK[P_0];
		if (dJ.a().ax() != 0)
		{
			Ck ck = BM.aM();
			ck?.a();
			dJ.a().a(0, true);
			ck?.B();
			BM.b(dJ.a().A());
		}
	}

	internal new void a(int P_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		DJ dJ = null;
		Enumerator<DJ> enumerator = ByK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DJ current = enumerator.Current;
				if (current.a().ax() == 0)
				{
					dJ = current;
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (dJ != null)
		{
			Ck ck = BM.aM();
			ck?.a();
			DJ dJ2 = ByK[P_0];
			dJ.a(dJ2, true);
			dJ.a().a(1, true);
			ck?.B();
			BM.b(dJ.a().A());
		}
	}

	internal new void B(int P_0)
	{
		if (Byk != null)
		{
			Byk.a(P_0, false);
		}
	}

	internal bool A(int P_0, int P_1)
	{
		List<SettingOrSpecialObject> val = Enumerable.ToList<SettingOrSpecialObject>(Enumerable.Cast<SettingOrSpecialObject>((System.Collections.IEnumerable)ByK));
		return SettingOrSpecialObject.A(m_framework, val, P_0, P_1);
	}
}
