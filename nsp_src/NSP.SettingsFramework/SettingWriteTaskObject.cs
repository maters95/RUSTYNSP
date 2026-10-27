using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using b;

namespace NSP.SettingsFramework;

public class SettingWriteTaskObject
{
	private string BbH;

	private string Bbh;

	private string BbI;

	private List<int> Bbi = new List<int>();

	private List<string> BbJ = new List<string>();

	private Framework Bbj;

	internal SettingWriteTaskObject(Framework P_0)
	{
		Bbj = P_0;
	}

	[SpecialName]
	internal void A(string P_0)
	{
		BbH = P_0;
	}

	[SpecialName]
	internal void a(string P_0)
	{
		Bbh = P_0;
	}

	[SpecialName]
	internal void B(string P_0)
	{
		BbI = P_0;
	}

	internal void A(int P_0, string P_1)
	{
		Bbi.Add(P_0);
		BbJ.Add(P_1);
	}

	[SpecialName]
	internal List<int> A()
	{
		return Bbi;
	}

	internal bool a()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<int> enumerator = Bbi.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				Setting setting = Bbj.A(current);
				if (setting != null && Bbj.B() && Bbj.b() && setting.J())
				{
					return true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return false;
	}

	internal void B()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		string bbI = BbI;
		bool flag;
		if (bbI != null)
		{
			T.A(ref bbI, Bbj);
			flag = T.A(ref bbI);
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			bE.A((IWin32Window)(object)BM.QQ, Bbh, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			if ((int)bE.A((IWin32Window)(object)BM.QQ, BbH, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)1, (MessageBoxIcon)48) != 1)
			{
				return;
			}
			Ck ck = BM.aM();
			ck?.a();
			for (int i = 0; i < Bbi.Count; i++)
			{
				string text = BbJ[i];
				T.A(ref text, Bbj);
				int num = T.a(ref text);
				Setting setting = Bbj.A(Bbi[i]);
				for (int j = 0; j < setting.av()[2]; j++)
				{
					for (int k = 0; k < setting.av()[1]; k++)
					{
						for (int l = 0; l < setting.av()[0]; l++)
						{
							setting.A(j, k, l, num, true);
						}
					}
				}
			}
			ck?.B();
		}
	}
}
