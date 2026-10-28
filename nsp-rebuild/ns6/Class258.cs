using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns7;

namespace ns6;

internal class Class258
{
	private Enum98 ayd;

	private List<string> ayE = new List<string>();

	private Framework aye;

	private string ayF;

	private string ayf;

	private Enum97 ayG;

	private int ayg;

	private List<int> ayH = new List<int>();

	private List<int> ayh = new List<int>();

	private List<string> ayI = new List<string>();

	private Class260 ayi;

	private List<Class259> ayJ = new List<Class259>();

	[CompilerGenerated]
	private EventHandler ayj;

	internal Class258(Framework framework_0, string string_0, string string_1, Enum97 enum97_0)
	{
		aye = framework_0;
		ayF = string_0;
		ayf = string_1;
		ayG = enum97_0;
	}

	public override string ToString()
	{
		return Class333.aog() + ayG.ToString() + Class333.smethod_325() + ((!string.IsNullOrEmpty(ayF)) ? (Class333.aoH() + ayF) : string.Empty) + Class333.smethod_325() + ((!string.IsNullOrEmpty(ayf)) ? (Class333.aoh() + ayf) : string.Empty);
	}

	internal void method_0()
	{
		if (ayd != Enum98.ayB || ayE.Count != 0)
		{
			ayd = Enum98.ayB;
			ayE.Clear();
			if (ayj != null)
			{
				ayj(this, null);
			}
		}
	}

	[SpecialName]
	internal Enum98 method_1()
	{
		return ayd;
	}

	[SpecialName]
	internal List<string> method_2()
	{
		return ayE;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = ayj;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref ayj, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_4(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = ayj;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref ayj, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void method_5()
	{
		bool flag = false;
		List<string> list = new List<string>();
		bool flag2 = method_18();
		bool flag3 = false;
		if (flag2 && !Form23.smethod_80())
		{
			if (ayd == Enum98.ayb)
			{
				flag = true;
				ayd = Enum98.ayB;
				flag3 = true;
			}
		}
		else if (ayd != Enum98.ayb || ayE.Count != 0)
		{
			flag = true;
			ayd = Enum98.ayb;
		}
		bool flag4 = false;
		if (flag2)
		{
			if (ayG == Enum97.aYz)
			{
				flag4 = true;
			}
			else if (ayG == Enum97.ayA)
			{
				if (ayi != null && ayi.method_6())
				{
					flag4 = true;
				}
				else
				{
					foreach (Class259 item in ayJ)
					{
						if (item.method_6())
						{
							flag4 = true;
							break;
						}
					}
				}
			}
			else if (ayG == Enum97.aya && flag3)
			{
				flag4 = true;
			}
		}
		if (flag4)
		{
			foreach (Class259 item2 in ayJ)
			{
				if (item2.method_9())
				{
					list.Add(item2.method_1());
				}
			}
			if (ayi != null)
			{
				if (list.Count != 0)
				{
					if (ayd != Enum98.ayD || method_6(list))
					{
						flag = true;
						ayd = Enum98.ayD;
					}
				}
				else if (ayi.method_9())
				{
					if (ayd != Enum98.ayc || method_6(list))
					{
						flag = true;
						ayd = Enum98.ayc;
					}
				}
				else if (ayJ.Count == 0)
				{
					if (ayd != Enum98.ayD || method_6(list))
					{
						flag = true;
						ayd = Enum98.ayD;
					}
				}
				else if (ayd != Enum98.ayC || method_6(list))
				{
					flag = true;
					ayd = Enum98.ayC;
				}
			}
			else if (list.Count != 0)
			{
				if (ayd != Enum98.ayD || method_6(list))
				{
					flag = true;
					ayd = Enum98.ayD;
				}
			}
			else if (ayd != Enum98.ayc || method_6(list))
			{
				flag = true;
				ayd = Enum98.ayc;
			}
		}
		if (flag)
		{
			ayE = list;
			if (ayj != null)
			{
				ayj(this, null);
			}
		}
	}

	private bool method_6(List<string> list_0)
	{
		if (list_0.Count != ayE.Count)
		{
			return true;
		}
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (list_0[num] != ayE[num])
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	internal string method_7()
	{
		return ayF;
	}

	[SpecialName]
	internal string method_8()
	{
		return ayf;
	}

	[SpecialName]
	internal Enum97 method_9()
	{
		return ayG;
	}

	[SpecialName]
	internal int method_10()
	{
		return ayg;
	}

	[SpecialName]
	internal void method_11(int int_0)
	{
		ayg = int_0;
	}

	[SpecialName]
	internal List<int> method_12()
	{
		return ayH;
	}

	[SpecialName]
	internal List<int> method_13()
	{
		return ayh;
	}

	[SpecialName]
	internal Class260 method_14()
	{
		return ayi;
	}

	[SpecialName]
	internal void method_15(Class260 class260_0)
	{
		ayi = class260_0;
	}

	[SpecialName]
	internal List<Class259> method_16()
	{
		return ayJ;
	}

	internal void method_17(string string_0)
	{
		ayI.Add(string_0);
	}

	internal bool method_18()
	{
		if (ayI.Count != 0)
		{
			int num = 0;
			while (true)
			{
				if (num < ayI.Count)
				{
					string string_ = ayI[num];
					Class37.smethod_0(ref string_, aye);
					if (Class37.smethod_10(ref string_))
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
		return true;
	}
}
