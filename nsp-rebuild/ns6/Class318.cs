using System.Collections.Generic;
using ns0;
using ns7;

namespace ns6;

internal class Class318
{
	internal string BdE;

	internal string Bde;

	internal List<Class316> BdF = new List<Class316>();

	internal List<Class317> Bdf = new List<Class317>();

	internal Class14 method_0(int int_0, int int_1)
	{
		if (int_0 == 22 && int_1 == 14)
		{
			int_1 = 13;
		}
		else if (int_0 == 22 && int_1 == 14)
		{
			int_1 = 20;
		}
		foreach (Class316 item in BdF)
		{
			if (item.BdC != null && item.BdC.axS == int_0 && item.BdC.axs == int_1)
			{
				return item.BdC.axT;
			}
		}
		return null;
	}

	public override string ToString()
	{
		return Class333.aYP() + BdE;
	}
}
