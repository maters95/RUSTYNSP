using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using b;

namespace NSP.SettingsFramework;

public class TableAxis : SpecialObject
{
	private AxisType bAr;

	private Setting bAS;

	private Setting bAs;

	private Setting bAT;

	private Setting bAt;

	private Setting bAU;

	private bool bAu;

	private bool bAV;

	private int bAv;

	private int bAW;

	private int bAw;

	private int bAX;

	internal TableAxis(Framework P_0, AxisType P_1, string P_2, SettingOrSpecialObject P_3, string P_4)
		: base(P_0, P_2, P_3, P_4)
	{
		bAr = P_1;
	}

	[SpecialName]
	internal new AxisType A()
	{
		return bAr;
	}

	[SpecialName]
	internal new bool a()
	{
		if (m_parentSettingOrSpecialObject is Table && (m_parentSettingOrSpecialObject as Table).TableDataSetting != null)
		{
			int num = (m_parentSettingOrSpecialObject as Table).TableDataSetting.aV();
			return bAr switch
			{
				AxisType.Column => num > 0, 
				AxisType.Row => num > 1, 
				AxisType.Slice => num > 2, 
				_ => true, 
			};
		}
		return false;
	}

	internal new bool B()
	{
		bool result = false;
		if (F() != null && G() != null && a())
		{
			result = F().ax() != 0;
		}
		return result;
	}

	internal new int b()
	{
		int result = 1;
		if (B() && f() != null)
		{
			result = f().ax();
		}
		return result;
	}

	[SpecialName]
	internal new void A(bool P_0)
	{
		bAu = P_0;
	}

	[SpecialName]
	internal new bool C()
	{
		return bAu;
	}

	[SpecialName]
	internal new void a(bool P_0)
	{
		bAV = P_0;
	}

	[SpecialName]
	internal new bool c()
	{
		return bAV;
	}

	[SpecialName]
	internal new void A(int P_0)
	{
		bAv = P_0;
	}

	[SpecialName]
	internal new int D()
	{
		return bAv;
	}

	[SpecialName]
	internal new void a(int P_0)
	{
		bAW = P_0;
	}

	[SpecialName]
	internal new int d()
	{
		return bAW;
	}

	[SpecialName]
	internal new void B(int P_0)
	{
		bAw = P_0;
	}

	[SpecialName]
	internal new int E()
	{
		return bAw;
	}

	[SpecialName]
	internal new void b(int P_0)
	{
		bAX = P_0;
	}

	[SpecialName]
	internal new int e()
	{
		return bAX;
	}

	[SpecialName]
	internal new Setting F()
	{
		return bAS;
	}

	[SpecialName]
	internal new Setting f()
	{
		return bAs;
	}

	[SpecialName]
	internal new Setting G()
	{
		return bAT;
	}

	[SpecialName]
	internal new Setting g()
	{
		return bAt;
	}

	[SpecialName]
	internal new Setting H()
	{
		return bAU;
	}

	internal new Setting h()
	{
		int num = bAt.ax();
		return m_framework.A(num);
	}

	internal new AxisBehaviour I()
	{
		Setting setting = h();
		if (setting != null && setting.x() != -1)
		{
			return (AxisBehaviour)setting.x();
		}
		if (bAU != null)
		{
			return (AxisBehaviour)bAU.ax();
		}
		return AxisBehaviour.Continuous;
	}

	internal new void i()
	{
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject is Setting)
			{
				if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eb())
				{
					bAS = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hj())
				{
					bAs = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh())
				{
					bAT = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hq() || settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajW())
				{
					bAt = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiv())
				{
					bAU = settingOrSpecialObject as Setting;
				}
			}
		}
		if (bAS == null && bAv != 0)
		{
			bAS = m_framework.A(bAv);
		}
		if (bAs == null && bAW != 0)
		{
			bAs = m_framework.A(bAW);
		}
		if (bAT == null && bAw != 0)
		{
			bAT = m_framework.A(bAw);
		}
		if (bAt == null && bAX != 0)
		{
			bAt = m_framework.A(bAX);
		}
	}

	internal new int C(int P_0)
	{
		return A(P_0, null, 0);
	}

	internal int A(int P_0, string P_1, int P_2)
	{
		bool flag = false;
		if (F() != null && G() != null && f() != null && a())
		{
			flag = F().ax() != 0;
		}
		if (flag)
		{
			int num = f().ax();
			for (int i = 0; i < num; i++)
			{
				int num2 = G().m(i);
				if (num2 == P_0)
				{
					return i;
				}
				if (!string.IsNullOrEmpty(P_1) && bS.a(num2, P_2, -1) == P_1)
				{
					return i;
				}
			}
		}
		return -1;
	}

	internal static bool A(int P_0, Setting P_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 != null)
		{
			Enumerator<Setting.ListItems.A> enumerator = P_1.d(0).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (P_0 == enumerator.Current.bBv)
					{
						return false;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			P_1.A(ref num, ref num2, ref num3, ref num4);
			if (P_0 < num3 || P_0 > num4)
			{
				return true;
			}
		}
		return false;
	}
}
