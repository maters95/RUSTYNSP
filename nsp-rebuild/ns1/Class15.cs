using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ns0;
using ns7;

namespace ns1;

internal class Class15 : IDisposable, Interface2
{
	private Stopwatch BGz = new Stopwatch();

	private Stopwatch BgA = new Stopwatch();

	private const uint Bga = 2000u;

	private static readonly uint[] BgB = new uint[3] { 150u, 250u, 350u };

	private const uint Bgb = 5u;

	private const uint BgC = 150u;

	private const uint Bgc = 400u;

	private const uint BgD = 3u;

	private uint[,] Bgd = new uint[5, 2];

	private uint BgE;

	private uint Bge;

	private uint BgF;

	private uint Bgf = BgB[0];

	private uint BgG;

	private const int Bgg = 4;

	private int BgH = 3;

	private Class12 Bgh = new Class12(Enum11.const_1, Class333.BAh(), 54000);

	private bool BgI = true;

	private string Bgi;

	[CompilerGenerated]
	private EventHandler BgJ;

	[CompilerGenerated]
	private EventHandler Bgj;

	[CompilerGenerated]
	private EventHandler BgK;

	[CompilerGenerated]
	private bool Bgk;

	public override string ToString()
	{
		return Class333.BAH() + Bgi;
	}

	public bool imethod_0(List<string> list_0)
	{
		try
		{
			if (!BGz.IsRunning)
			{
				BGz.Start();
			}
			if (BGz.ElapsedMilliseconds >= 800L)
			{
				return Bgh.method_1(list_0, ref Bgi);
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void imethod_1()
	{
	}

	public bool imethod_2(Class5 class5_0)
	{
		return true;
	}

	public bool imethod_3()
	{
		return true;
	}

	public void imethod_20(bool bool_0)
	{
		if (bool_0)
		{
			BgG = 0u;
			if (BgH > 3)
			{
				BgH--;
			}
		}
		else
		{
			BgG += (uint)(int)BgA.ElapsedMilliseconds;
			if (BgH < 40)
			{
				BgH += 4;
			}
		}
	}

	public bool imethod_24()
	{
		return BgI;
	}

	public bool imethod_25()
	{
		return true;
	}

	public void imethod_26()
	{
		BgF = 3u;
		for (int i = 0; i < 5L; i++)
		{
			Bgd[i, 0] = 10u;
			Bgd[i, 1] = 0u;
		}
		Bge = 1000u;
		if (!BgI)
		{
			BgI = true;
			if (BgK != null)
			{
				BgK(this, EventArgs.Empty);
			}
		}
	}

	public void imethod_27()
	{
		method_0();
		if (BgI)
		{
			BgI = false;
			if (Bgj != null)
			{
				Bgj(this, EventArgs.Empty);
			}
		}
	}

	public void imethod_28(int int_0, int int_1)
	{
		if (BgI && BgG >= 2000)
		{
			method_0();
			BgI = false;
			if (Bgj != null)
			{
				Bgj(this, EventArgs.Empty);
			}
			return;
		}
		Bgd[BgE, 0] = (uint)int_0;
		Bgd[BgE, 1] = (uint)int_1;
		BgE = (BgE + 1) % 5;
		uint num = 0u;
		uint num2 = 0u;
		for (int i = 0; i < 5L; i++)
		{
			num += Bgd[i, 0];
			num2 += Bgd[i, 1];
		}
		if (num != 0)
		{
			uint num3 = 0u;
			if (num2 <= num)
			{
				num3 = num - num2;
			}
			Bge = num3 * 1000 / num;
		}
		else
		{
			Bge = 0u;
		}
		if (BgI && Bge < 150)
		{
			method_0();
			BgI = false;
			if (Bgj != null)
			{
				Bgj(this, EventArgs.Empty);
			}
		}
		else
		{
			if (BgI)
			{
				return;
			}
			if (Bge >= 400)
			{
				BgF++;
				if (BgF >= 3)
				{
					BgI = true;
					if (BgK != null)
					{
						BgK(this, EventArgs.Empty);
					}
				}
			}
			else
			{
				BgF = 0u;
			}
		}
	}

	public uint imethod_29()
	{
		return Bge;
	}

	public uint[,] imethod_30()
	{
		return Bgd;
	}

	public uint imethod_31()
	{
		return BgE;
	}

	public uint imethod_32()
	{
		return BgF;
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_6(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BgJ;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BgJ, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_7(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BgJ;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BgJ, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_8(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = Bgj;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref Bgj, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_9(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = Bgj;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref Bgj, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_10(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BgK;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BgK, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_11(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BgK;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BgK, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	public string imethod_5()
	{
		return Bgi;
	}

	public void imethod_12(uint uint_0)
	{
	}

	public void imethod_13()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	public bool imethod_14()
	{
		return Bgk;
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_15(bool bool_0)
	{
		Bgk = bool_0;
	}

	public bool imethod_16(byte[] byte_0, uint uint_0, out uint uint_1)
	{
		return Bgh.method_6(byte_0, uint_0, out uint_1, BgA);
	}

	public bool imethod_17(ref byte[] byte_0, uint uint_0, out uint uint_1, byte byte_1)
	{
		return Bgh.method_7(ref byte_0, uint_0, out uint_1, byte_1, Bgf);
	}

	public uint imethod_18()
	{
		return uint.MaxValue;
	}

	public bool imethod_19()
	{
		return false;
	}

	private void method_0()
	{
		BgF = 0u;
		for (int i = 0; i < 5L; i++)
		{
			Bgd[i, 0] = 0u;
			Bgd[i, 1] = 0u;
		}
		Bge = 0u;
	}

	public void imethod_21(ref uint uint_0)
	{
		uint_0 >>= BgH / 4;
		if (uint_0 < 1)
		{
			uint_0 = 1u;
		}
		if (uint_0 >= 16)
		{
			Bgf = BgB[2];
		}
		else if (uint_0 >= 4)
		{
			Bgf = BgB[1];
		}
		else
		{
			Bgf = BgB[0];
		}
	}

	public uint imethod_22()
	{
		return uint.MaxValue;
	}

	public void imethod_23()
	{
		if (Bgh != null)
		{
			Bgh.method_5();
		}
	}

	public bool imethod_4()
	{
		return false;
	}

	public void Dispose()
	{
		if (Bgh != null)
		{
			Bgh.method_10();
		}
	}
}
