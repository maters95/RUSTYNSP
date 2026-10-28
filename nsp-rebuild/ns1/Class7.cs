using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ns0;
using ns7;

namespace ns1;

internal class Class7 : IDisposable, Interface2
{
	private Stopwatch BFq = new Stopwatch();

	private Stopwatch BFR = new Stopwatch();

	private const uint BFr = 2000u;

	private static readonly uint[] BFS = new uint[3] { 1000u, 1500u, 2000u };

	private const uint BFs = 5u;

	private const uint BFT = 150u;

	private const uint BFt = 400u;

	private const uint BFU = 3u;

	private uint[,] BFu = new uint[5, 2];

	private uint BFV;

	private uint BFv;

	private uint BFW;

	private uint BFw = BFS[0];

	private uint BFX;

	private const int BFx = 4;

	private int BFY = 3;

	private Class12 BFy = new Class12(Enum11.const_2, Class333.azL(), 54000);

	private bool BFZ = true;

	private string BFz;

	[CompilerGenerated]
	private EventHandler BfA;

	[CompilerGenerated]
	private EventHandler Bfa;

	[CompilerGenerated]
	private EventHandler BfB;

	[CompilerGenerated]
	private bool Bfb;

	public override string ToString()
	{
		return Class333.azk() + BFz;
	}

	public bool imethod_0(List<string> list_0)
	{
		try
		{
			if (!BFq.IsRunning)
			{
				BFq.Start();
			}
			if (BFq.ElapsedMilliseconds >= 800L)
			{
				return BFy.method_1(list_0, ref BFz);
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
			BFX = 0u;
			if (BFY > 3)
			{
				BFY--;
			}
		}
		else
		{
			BFX += (uint)(int)BFR.ElapsedMilliseconds;
			if (BFY < 40)
			{
				BFY += 4;
			}
		}
	}

	public bool imethod_24()
	{
		return BFZ;
	}

	public bool imethod_25()
	{
		return true;
	}

	public void imethod_26()
	{
		BFW = 3u;
		for (int i = 0; i < 5L; i++)
		{
			BFu[i, 0] = 10u;
			BFu[i, 1] = 0u;
		}
		BFv = 1000u;
		if (!BFZ)
		{
			BFZ = true;
			if (BfB != null)
			{
				BfB(this, EventArgs.Empty);
			}
		}
	}

	public void imethod_27()
	{
		method_0();
		if (BFZ)
		{
			BFZ = false;
			if (Bfa != null)
			{
				Bfa(this, EventArgs.Empty);
			}
		}
	}

	public void imethod_28(int int_0, int int_1)
	{
		if (BFZ && BFX >= 2000)
		{
			method_0();
			BFZ = false;
			if (Bfa != null)
			{
				Bfa(this, EventArgs.Empty);
			}
			return;
		}
		BFu[BFV, 0] = (uint)int_0;
		BFu[BFV, 1] = (uint)int_1;
		BFV = (BFV + 1) % 5;
		uint num = 0u;
		uint num2 = 0u;
		for (int i = 0; i < 5L; i++)
		{
			num += BFu[i, 0];
			num2 += BFu[i, 1];
		}
		if (num != 0)
		{
			uint num3 = 0u;
			if (num2 <= num)
			{
				num3 = num - num2;
			}
			BFv = num3 * 1000 / num;
		}
		else
		{
			BFv = 0u;
		}
		if (BFZ && BFv < 150)
		{
			method_0();
			BFZ = false;
			if (Bfa != null)
			{
				Bfa(this, EventArgs.Empty);
			}
		}
		else
		{
			if (BFZ)
			{
				return;
			}
			if (BFv >= 400)
			{
				BFW++;
				if (BFW >= 3)
				{
					BFZ = true;
					if (BfB != null)
					{
						BfB(this, EventArgs.Empty);
					}
				}
			}
			else
			{
				BFW = 0u;
			}
		}
	}

	public uint imethod_29()
	{
		return BFv;
	}

	public uint[,] imethod_30()
	{
		return BFu;
	}

	public uint imethod_31()
	{
		return BFV;
	}

	public uint imethod_32()
	{
		return BFW;
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_6(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BfA;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BfA, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_7(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BfA;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BfA, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_8(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = Bfa;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref Bfa, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_9(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = Bfa;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref Bfa, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_10(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BfB;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BfB, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_11(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BfB;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BfB, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	public string imethod_5()
	{
		return BFz;
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
		return Bfb;
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_15(bool bool_0)
	{
		Bfb = bool_0;
	}

	public bool imethod_16(byte[] byte_0, uint uint_0, out uint uint_1)
	{
		return BFy.method_6(byte_0, uint_0, out uint_1, BFR);
	}

	public bool imethod_17(ref byte[] byte_0, uint uint_0, out uint uint_1, byte byte_1)
	{
		return BFy.method_7(ref byte_0, uint_0, out uint_1, byte_1, BFw);
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
		BFW = 0u;
		for (int i = 0; i < 5L; i++)
		{
			BFu[i, 0] = 0u;
			BFu[i, 1] = 0u;
		}
		BFv = 0u;
	}

	public void imethod_21(ref uint uint_0)
	{
		uint_0 >>= BFY / 4;
		if (uint_0 < 1)
		{
			uint_0 = 1u;
		}
		if (uint_0 >= 16)
		{
			BFw = BFS[2];
		}
		else if (uint_0 >= 4)
		{
			BFw = BFS[1];
		}
		else
		{
			BFw = BFS[0];
		}
	}

	public uint imethod_22()
	{
		return uint.MaxValue;
	}

	public void imethod_23()
	{
		if (BFy != null)
		{
			BFy.method_5();
		}
	}

	public bool imethod_4()
	{
		return false;
	}

	public void Dispose()
	{
		if (BFy != null)
		{
			BFy.method_10();
		}
	}
}
