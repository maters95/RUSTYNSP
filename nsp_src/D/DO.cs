using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using C;
using NSP.SettingsFramework;

namespace D;

internal class DO : SpecialObject
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

	internal DO(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	[SpecialName]
	internal new int A()
	{
		return Bzi;
	}

	[SpecialName]
	internal new void A(int P_0)
	{
		Bzi = P_0;
	}

	[SpecialName]
	internal new List<int> a()
	{
		return BzJ;
	}

	[SpecialName]
	internal new List<int> B()
	{
		return Bzj;
	}

	[SpecialName]
	internal new Dictionary<int, List<int>> b()
	{
		return BzK;
	}

	[SpecialName]
	internal new Dictionary<int, List<int>> C()
	{
		return Bzk;
	}

	[SpecialName]
	internal new List<string> c()
	{
		return BzL;
	}

	[SpecialName]
	internal new List<string> D()
	{
		return Bzl;
	}

	[SpecialName]
	internal new List<string> d()
	{
		return BzM;
	}

	[SpecialName]
	internal new Dictionary<string, string[]> E()
	{
		return Bzm;
	}

	[SpecialName]
	internal new string e()
	{
		return BzN;
	}

	[SpecialName]
	internal new void A(string P_0)
	{
		BzN = P_0;
	}

	[SpecialName]
	internal new bool F()
	{
		return Bzn;
	}

	[SpecialName]
	internal new void A(bool P_0)
	{
		Bzn = P_0;
	}

	[SpecialName]
	internal new string f()
	{
		return BzO;
	}

	[SpecialName]
	internal new void a(string P_0)
	{
		BzO = P_0;
	}

	[SpecialName]
	internal new Dictionary<int, string[]> G()
	{
		return Bzo;
	}

	internal List<Setting> A(MenuNode P_0, bool P_1 = false)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		List<Setting> val = new List<Setting>();
		Enumerator<int> enumerator = B().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				Setting setting = m_framework.A(current);
				if (setting == null)
				{
					continue;
				}
				val.Add(setting);
				if (!P_1 || !m_framework.awX.ContainsKey(setting.A()))
				{
					continue;
				}
				MenuNode menuNode = m_framework.awX[setting.A()];
				if (!m_framework.awF.ContainsKey(((SettingOrSpecialObject)setting).d()))
				{
					continue;
				}
				Enumerator<Setting> enumerator2 = m_framework.awF[((SettingOrSpecialObject)setting).d()].A(menuNode, true).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Setting current2 = enumerator2.Current;
						val.Add(current2);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (a().Count != 0 || b().Count != 0 || C().Count != 0)
		{
			HashSet<DataIdAndAttrId> val2 = MenuNode.A(P_0, false);
			enumerator = a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current3 = enumerator.Current;
					Setting setting2 = Cn.A(m_framework, val2, current3);
					if (setting2 != null)
					{
						val.Add(setting2);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<int, List<int>> enumerator3 = b().Keys.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					int current4 = enumerator3.Current;
					enumerator = b()[current4].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current5 = enumerator.Current;
							Setting setting3 = Cn.A(m_framework, val2, current5, current4, 0);
							if (setting3 != null)
							{
								val.Add(setting3);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			enumerator3 = C().Keys.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					int current6 = enumerator3.Current;
					Dn dn = m_framework.A(current6) as Dn;
					List<Setting> val3 = new List<Setting>();
					PortFunction.A(dn, val3, false);
					Enumerator<Setting> enumerator2 = val3.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							Setting current7 = enumerator2.Current;
							val2.Add(current7.C());
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
					List<Table> val4 = new List<Table>();
					PortFunction.A(dn, val4, false);
					Enumerator<Table> enumerator4 = val4.GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							Enumerator<DataIdAndAttrId> enumerator5 = enumerator4.Current.GetIdsContained().GetEnumerator();
							try
							{
								while (enumerator5.MoveNext())
								{
									DataIdAndAttrId current8 = enumerator5.Current;
									val2.Add(current8);
								}
							}
							finally
							{
								((System.IDisposable)enumerator5).Dispose();
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator4).Dispose();
					}
					enumerator = C()[current6].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current9 = enumerator.Current;
							Setting setting4 = Cn.A(m_framework, val2, current9, 0, current6);
							if (setting4 != null)
							{
								val.Add(setting4);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
		}
		return val;
	}
}
internal class Do : Setting
{
	internal Do(Framework P_0, string P_1, int P_2, int P_3, SettingOrSpecialObject P_4, string P_5)
		: base(P_0, false, P_1, P_2, P_3, P_4, P_5)
	{
	}
}
