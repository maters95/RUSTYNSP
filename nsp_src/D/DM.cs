using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;

namespace D;

internal class DM : SpecialObject
{
	private List<Dl> Byx = new List<Dl>();

	internal DM(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	internal new void A()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<int> enumerator = k().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				SettingOrSpecialObject settingOrSpecialObject = m_framework.a(current);
				if (settingOrSpecialObject != null && settingOrSpecialObject is Dl)
				{
					Dl dl = settingOrSpecialObject as Dl;
					Byx.Add(dl);
					dl.A();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	[SpecialName]
	internal new List<Dl> a()
	{
		return Byx;
	}
}
internal class Dm : SpecialObject
{
	private string BZA;

	private string BZa;

	private string BZB;

	private bool BZb;

	private int BZC;

	private int BZc;

	private int BZD;

	private int BZd;

	internal Dm(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	[SpecialName]
	internal new string A()
	{
		return BZA;
	}

	[SpecialName]
	internal new void A(string P_0)
	{
		BZA = P_0;
	}

	[SpecialName]
	internal new string a()
	{
		return BZa;
	}

	[SpecialName]
	internal new void a(string P_0)
	{
		BZa = P_0;
	}

	[SpecialName]
	internal new string B()
	{
		return BZB;
	}

	[SpecialName]
	internal new void B(string P_0)
	{
		BZB = P_0;
	}

	[SpecialName]
	internal new bool b()
	{
		return BZb;
	}

	[SpecialName]
	internal new void A(bool P_0)
	{
		BZb = P_0;
	}

	[SpecialName]
	internal new int C()
	{
		return BZC;
	}

	[SpecialName]
	internal new void A(int P_0)
	{
		BZC = P_0;
	}

	[SpecialName]
	internal new int c()
	{
		return BZc;
	}

	[SpecialName]
	internal new void a(int P_0)
	{
		BZc = P_0;
	}

	[SpecialName]
	internal new int D()
	{
		return BZD;
	}

	[SpecialName]
	internal new void B(int P_0)
	{
		BZD = P_0;
	}

	[SpecialName]
	internal new int d()
	{
		return BZd;
	}

	[SpecialName]
	internal new void b(int P_0)
	{
		BZd = P_0;
	}
}
