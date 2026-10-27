using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using C;

namespace NSP.SettingsFramework;

public class FilterOption : SpecialObject
{
	internal new class A
	{
		internal Cg bbE;

		internal CH bbe;

		internal byte bbF;

		internal ushort bbf;

		internal bool bbG;

		internal int bbg;

		internal A(uint P_0, bool P_1, int P_2)
		{
			bbE = PortFunction.A(P_0);
			bbe = PortFunction.a(P_0);
			bbF = PortFunction.B(P_0);
			bbf = PortFunction.b(P_0);
			bbG = P_1;
			bbg = P_2;
		}
	}

	private List<A> BZE = new List<A>();

	private List<A> BZe = new List<A>();

	private List<string> BZF = new List<string>();

	private HashSet<int> BZf = new HashSet<int>();

	private bool BZG;

	private bool BZg;

	internal FilterOption(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	[SpecialName]
	internal new bool A()
	{
		return BZg;
	}

	[SpecialName]
	internal new void A(bool P_0)
	{
		BZg = P_0;
	}

	protected override void RevertAllConditionalPropertiesToDefaults()
	{
		base.RevertAllConditionalPropertiesToDefaults();
		BZe.Clear();
		for (int i = 0; i < BZE.Count; i++)
		{
			A a = BZE[i];
			if (a.bbg == -1)
			{
				BZe.Add(a);
			}
		}
	}

	protected override void UpdateConditionalPropertiesValues(int cellIndex, int condPropertiesBlockIndex)
	{
		base.UpdateConditionalPropertiesValues(cellIndex, condPropertiesBlockIndex);
		if (cellIndex != 0)
		{
			return;
		}
		for (int i = 0; i < BZE.Count; i++)
		{
			A a = BZE[i];
			if (a.bbg == condPropertiesBlockIndex)
			{
				BZe.Add(a);
			}
		}
	}

	internal new void A(string P_0)
	{
		BZF.Add(P_0);
	}

	[SpecialName]
	internal new bool a()
	{
		return BZG;
	}

	internal new bool a(bool P_0)
	{
		bool flag = false;
		if (BZF.Count == 0)
		{
			flag = true;
		}
		else
		{
			for (int i = 0; i < BZF.Count; i++)
			{
				string text = BZF[i];
				List<int> val = T.A(ref text, m_framework);
				if (P_0)
				{
					for (int j = 0; j < val.Count; j++)
					{
						BZf.Add(val[j]);
						Setting setting = m_framework.A(val[j]);
						setting.r().Add(r());
						setting.S().Add(this);
					}
				}
				bool flag2 = T.A(ref text);
				flag = flag || flag2;
			}
		}
		bool result = BZG != flag;
		BZG = flag;
		return result;
	}

	[SpecialName]
	internal new HashSet<int> B()
	{
		return BZf;
	}

	internal void A(uint P_0, bool P_1, int P_2)
	{
		A a = new A(P_0, P_1, P_2);
		BZE.Add(a);
	}

	internal new List<A> b()
	{
		return BZe;
	}
}
