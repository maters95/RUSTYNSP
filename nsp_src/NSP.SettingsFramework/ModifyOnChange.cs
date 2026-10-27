using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using C;

namespace NSP.SettingsFramework;

public class ModifyOnChange
{
	private Framework aZb;

	private int aZC;

	private List<Cc> aZc = new List<Cc>();

	internal ModifyOnChange(Framework P_0, int P_1)
	{
		aZb = P_0;
		aZC = P_1;
	}

	internal void A(Cc P_0)
	{
		aZc.Add(P_0);
	}

	[SpecialName]
	internal Setting A()
	{
		return aZb.A(aZC);
	}

	internal List<Setting> A(bool P_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Setting> val = new List<Setting>();
		Enumerator<Cc> enumerator = aZc.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Cc current = enumerator.Current;
				current.A(P_0);
				Setting setting = current.A(aZb);
				if (setting != null && !val.Contains(setting))
				{
					val.Add(setting);
				}
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}
}
