using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using C;

namespace NSP.SettingsFramework;

public class ConvertFrom
{
	private int ayw;

	private int ayX = -1;

	private string ayx;

	private string ayY;

	private List<Cc> ayy = new List<Cc>();

	internal ConvertFrom(int P_0, int P_1, string P_2, string P_3)
	{
		ayw = P_0;
		ayX = P_1;
		ayx = P_2;
		ayY = P_3;
	}

	[SpecialName]
	internal int A()
	{
		return ayw;
	}

	[SpecialName]
	internal int a()
	{
		return ayX;
	}

	[SpecialName]
	internal string B()
	{
		return ayx;
	}

	[SpecialName]
	internal string b()
	{
		return ayY;
	}

	internal void A(Cc P_0)
	{
		ayy.Add(P_0);
	}

	internal void A(Setting P_0, Framework P_1, Framework P_2, List<int[]> P_3, bool P_4)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<int[]> val = new List<int[]>();
		Enumerator<Cc> enumerator = ayy.GetEnumerator();
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
