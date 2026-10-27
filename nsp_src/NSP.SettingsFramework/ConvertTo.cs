using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using C;

namespace NSP.SettingsFramework;

public class ConvertTo
{
	private int ayZ;

	private int ayz = -1;

	private string aZA;

	private string aZa;

	private List<Cc> aZB = new List<Cc>();

	internal ConvertTo(int P_0, int P_1, string P_2, string P_3)
	{
		ayZ = P_0;
		ayz = P_1;
		aZA = P_2;
		aZa = P_3;
	}

	[SpecialName]
	internal int A()
	{
		return ayZ;
	}

	[SpecialName]
	internal int a()
	{
		return ayz;
	}

	[SpecialName]
	internal string B()
	{
		return aZA;
	}

	[SpecialName]
	internal string b()
	{
		return aZa;
	}

	internal void A(Cc P_0)
	{
		aZB.Add(P_0);
	}

	internal void A(Setting P_0, Framework P_1, Framework P_2, List<int[]> P_3, bool P_4)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<int[]> val = new List<int[]>();
		Enumerator<Cc> enumerator = aZB.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.A(P_0, P_1, P_2, val, P_3, P_4);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}
}
