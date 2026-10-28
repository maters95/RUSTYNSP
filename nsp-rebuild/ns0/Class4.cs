using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using crc;
using ns1;
using ns7;

namespace ns0;

internal class Class4 : IDisposable
{
	private enum Enum8 : byte
	{
		BFl = 1,
		BFM = 2,
		BFm = 0x80
	}

	private enum Enum9 : byte
	{
		BFN,
		BFn,
		BFO,
		BFo,
		BFP,
		BFp,
		BFQ
	}

	private Class5 class5_0 = new Class5();

	private Class9 class9_0;

	[CompilerGenerated]
	private readonly Interface2 interface2_0;

	private Dictionary<Enum10, uint> dictionary_0 = new Dictionary<Enum10, uint>();

	private Dictionary<Enum10, uint> dictionary_1 = new Dictionary<Enum10, uint>();

	internal DateTime dateTime_0 = new DateTime(0L);

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	[CompilerGenerated]
	private EventHandler eventHandler_2;

	private int int_0;

	private int int_1;

	private Stopwatch stopwatch_0 = new Stopwatch();

	private bool bool_0;

	private BackgroundWorker backgroundWorker_0;

	[CompilerGenerated]
	private EventHandler eventHandler_3;

	private const uint uint_0 = 12u;

	private const uint uint_1 = 4u;

	private const uint uint_2 = uint.MaxValue;

	private byte byte_0;

	private byte[] byte_1;

	private uint uint_3;

	[SpecialName]
	[CompilerGenerated]
	internal Interface2 method_0()
	{
		return interface2_0;
	}

	internal Class4(Enum11 enum11_0)
	{
		if (enum11_0 == Enum11.const_0)
		{
			interface2_0 = new Class8();
		}
		else if (enum11_0 == Enum11.const_1)
		{
			interface2_0 = new Class15();
		}
		else if (enum11_0 == Enum11.const_2)
		{
			interface2_0 = new Class7();
		}
		else
		{
			if (enum11_0 != Enum11.const_3)
			{
				throw new Exception(Class333.smethod_30());
			}
			interface2_0 = new Class11();
		}
		if (method_0() is Class8)
		{
			class9_0 = new Class9(method_0() as Class8);
		}
		method_0().imethod_6(method_9);
		method_0().imethod_8(method_10);
		method_0().imethod_10(method_11);
		foreach (Enum10 value in Enum.GetValues(typeof(Enum10)))
		{
			dictionary_0.Add(value, 0u);
			dictionary_1.Add(value, uint.MaxValue);
		}
	}

	public void Dispose()
	{
		if (backgroundWorker_0 != null)
		{
			backgroundWorker_0.CancelAsync();
		}
		method_0().imethod_7(method_9);
		method_0().imethod_9(method_10);
		method_0().imethod_11(method_11);
		method_0().Dispose();
	}

	public bool method_1()
	{
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(class5_0, ref lockTaken);
			if (!lockTaken)
			{
				return false;
			}
			return method_0().imethod_4();
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(class5_0);
			}
		}
	}

	public override string ToString()
	{
		return Class333.smethod_31() + class5_0.ToString() + Class333.smethod_32() + method_0().ToString();
	}

	internal Enum11 method_2()
	{
		if (method_0() is Class8)
		{
			return Enum11.const_0;
		}
		if (method_0() is Class15)
		{
			return Enum11.const_1;
		}
		if (method_0() is Class7)
		{
			return Enum11.const_2;
		}
		if (method_0() is Class11)
		{
			return Enum11.const_3;
		}
		return Enum11.const_4;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(EventHandler eventHandler_4)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_4(EventHandler eventHandler_4)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(EventHandler eventHandler_4)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_6(EventHandler eventHandler_4)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_7(EventHandler eventHandler_4)
	{
		EventHandler eventHandler = eventHandler_2;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_8(EventHandler eventHandler_4)
	{
		EventHandler eventHandler = eventHandler_2;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void method_9(object sender, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, EventArgs.Empty);
		}
	}

	private void method_10(object sender, EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, EventArgs.Empty);
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, EventArgs.Empty);
		}
	}

	[SpecialName]
	internal string method_12()
	{
		return method_0().imethod_5();
	}

	[SpecialName]
	internal Class5 method_13()
	{
		return class5_0;
	}

	internal bool method_14(List<string> list_0)
	{
		string text = method_2().ToString();
		Class1.smethod_86(Class333.smethod_33() + text + Class333.smethod_9());
		if (method_0().imethod_0(list_0))
		{
			list_0.Add(method_12());
			Class1.smethod_86(Class333.smethod_34() + text + Class333.smethod_35());
			if (method_19())
			{
				Class1.smethod_86(Class333.smethod_34() + text + Class333.smethod_37());
				if (method_0().imethod_2(class5_0))
				{
					Class1.smethod_86(Class333.smethod_34() + text + Class333.smethod_39());
					if (method_19() && method_22())
					{
						Class1.smethod_86(Class333.smethod_34() + text + Class333.smethod_41());
						Class1.smethod_86(Class333.smethod_34() + text + Class333.smethod_42());
						method_0().imethod_26();
						int_0 = 10;
						int_1 = 0;
						return true;
					}
					method_0().Dispose();
					Class1.smethod_86(Class333.smethod_34() + text + Class333.smethod_43());
					return false;
				}
				method_0().Dispose();
				Class1.smethod_86(Class333.smethod_34() + text + Class333.smethod_40());
				return false;
			}
			method_0().imethod_1();
			method_0().Dispose();
			Class1.smethod_86(Class333.smethod_34() + text + Class333.smethod_38());
			return false;
		}
		Class1.smethod_86(Class333.smethod_34() + text + Class333.smethod_36());
		return false;
	}

	internal Class5 method_15()
	{
		string text = method_2().ToString();
		Class1.smethod_86(Class333.smethod_44() + text + Class333.smethod_9());
		if (method_0().imethod_3())
		{
			Class1.smethod_86(Class333.smethod_45() + text + Class333.smethod_46());
			if (method_19())
			{
				Class1.smethod_86(Class333.smethod_45() + text + Class333.smethod_37());
				if (method_0().imethod_2(class5_0))
				{
					Class1.smethod_86(Class333.smethod_45() + text + Class333.smethod_39());
					if (method_19() && method_22())
					{
						Class1.smethod_86(Class333.smethod_45() + text + Class333.smethod_41());
						Class1.smethod_86(Class333.smethod_45() + text + Class333.smethod_42());
						return class5_0;
					}
					Class1.smethod_86(Class333.smethod_45() + text + Class333.smethod_50());
					return null;
				}
				Class1.smethod_86(Class333.smethod_45() + text + Class333.smethod_49());
				return null;
			}
			Class1.smethod_86(Class333.smethod_45() + text + Class333.smethod_48());
			return null;
		}
		Class1.smethod_86(Class333.smethod_45() + text + Class333.smethod_47());
		return null;
	}

	internal bool method_16()
	{
		return method_0().imethod_24();
	}

	internal bool method_17()
	{
		return method_0().imethod_25();
	}

	internal void method_18()
	{
		int_0 = 0;
		int_1 = 0;
		method_0().imethod_27();
	}

	internal bool method_19()
	{
		if (class5_0.bool_1)
		{
			if (method_21())
			{
				return true;
			}
			if (method_20())
			{
				return true;
			}
		}
		else
		{
			if (method_20())
			{
				return true;
			}
			if (method_21())
			{
				return true;
			}
		}
		return false;
	}

	private bool method_20()
	{
		string text = method_2().ToString();
		int num = 2;
		do
		{
			if (!method_29(0, 1, Enum10.const_0, 0u, 1024u, out var byte_, out var _))
			{
				num--;
				Class1.smethod_86(Class333.smethod_51() + text + Class333.smethod_53() + num + Class333.smethod_54());
				continue;
			}
			class5_0.bool_1 = false;
			class5_0.method_0(byte_);
			if (class5_0.struct2_0[(uint)method_2()].uint_0 != 0)
			{
				Class1.smethod_86(Class333.smethod_51() + text + Class333.smethod_42());
				return true;
			}
			Class1.smethod_86(Class333.smethod_51() + text + Class333.smethod_52());
			return false;
		}
		while (num > 0);
		return false;
	}

	private bool method_21()
	{
		if (class9_0 != null)
		{
			int num = 2;
			do
			{
				if (!class9_0.method_11(out var byte_))
				{
					num--;
					Class1.smethod_86(Class333.smethod_57() + num + Class333.smethod_54());
					continue;
				}
				class5_0.bool_1 = true;
				class5_0.method_0(byte_);
				if (class5_0.struct2_0[(uint)method_2()].uint_0 != 0)
				{
					Class1.smethod_86(Class333.smethod_55());
					return true;
				}
				Class1.smethod_86(Class333.smethod_56());
				return false;
			}
			while (num > 0);
		}
		return false;
	}

	private bool method_22()
	{
		class5_0.method_4(null);
		return true;
	}

	private void method_23(bool bool_1)
	{
		method_0().imethod_20(!bool_1);
		if (bool_1)
		{
			int_1++;
		}
		if (!stopwatch_0.IsRunning)
		{
			stopwatch_0.Start();
		}
		if (stopwatch_0.ElapsedMilliseconds >= 1000L)
		{
			method_0().imethod_28(int_0, int_1);
			int_0 = 0;
			int_1 = 0;
			stopwatch_0.Restart();
		}
	}

	internal void method_24()
	{
		if (!bool_0)
		{
			bool_0 = true;
			backgroundWorker_0 = new BackgroundWorker();
			backgroundWorker_0.WorkerReportsProgress = false;
			backgroundWorker_0.WorkerSupportsCancellation = true;
			backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
			backgroundWorker_0.RunWorkerAsync();
		}
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		bool flag = false;
		string string_ = class5_0.string_0;
		while (!backgroundWorker_0.CancellationPending && !method_0().imethod_24())
		{
			bool flag2;
			if (!(flag2 = method_19()))
			{
				flag2 = method_15() != null;
			}
			if (!flag2 || !(flag = !string.IsNullOrEmpty(class5_0.string_0) && !string.IsNullOrEmpty(string_) && class5_0.string_0 != Class333.smethod_58() && class5_0.string_0 != Class333.smethod_59() && string_ != Class333.smethod_58() && string_ != Class333.smethod_59() && class5_0.string_0 != string_))
			{
				Thread.Sleep(50);
				continue;
			}
			class5_0.string_0 = string_;
			break;
		}
		bool_0 = false;
		if (flag)
		{
			method_9(null, EventArgs.Empty);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_25(EventHandler eventHandler_4)
	{
		EventHandler eventHandler = eventHandler_3;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_26(EventHandler eventHandler_4)
	{
		EventHandler eventHandler = eventHandler_3;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private bool method_27(byte byte_2, Enum10 enum10_0, uint uint_4, uint uint_5, out byte[] byte_3)
	{
		uint num = ((enum10_0 != Enum10.const_0) ? method_13().struct1_0[(uint)enum10_0].uint_0 : 0) + uint_4;
		uint num2 = 16u;
		byte_3 = new byte[16];
		byte_3[0] = 2;
		byte_3[1] = byte_0++;
		byte_3[2] = 0;
		byte_3[3] = byte_2;
		byte_3[4] = (byte)(num >> 24);
		byte_3[5] = (byte)(num >> 16);
		byte_3[6] = (byte)(num >> 8);
		byte_3[7] = (byte)num;
		byte_3[8] = (byte)(uint_5 >> 24);
		byte_3[9] = (byte)(uint_5 >> 16);
		byte_3[10] = (byte)(uint_5 >> 8);
		byte_3[11] = (byte)uint_5;
		uint num3 = new global::crc.crc().crc_process(byte_3, 0u, 12u, uint.MaxValue, partial: false);
		byte_3[12] = (byte)(num3 >> 24);
		byte_3[13] = (byte)(num3 >> 16);
		byte_3[14] = (byte)(num3 >> 8);
		byte_3[15] = (byte)num3;
		int_0++;
		if (enum10_0 != Enum10.const_0)
		{
			dateTime_0 = DateTime.Now;
		}
		if (method_0().imethod_16(byte_3, (uint)byte_3.Length, out var num4))
		{
			return num4 == num2;
		}
		return false;
	}

	private bool method_28(byte[] byte_2, out byte[] byte_3, uint uint_4, out bool bool_1, out bool bool_2)
	{
		bool result = false;
		bool_1 = false;
		uint num = 12 + uint_4 + 4;
		global::crc.crc crc2 = new global::crc.crc();
		uint init = uint.MaxValue;
		byte[] array = new byte[num];
		uint num2 = 0u;
		byte_3 = null;
		bool_2 = false;
		if (method_0().imethod_19())
		{
			byte[] array2 = new byte[12];
			if (!method_0().imethod_17(ref array2, 12u, out num2, byte_2[1]) || num2 != 12)
			{
				Class1.smethod_86(Class333.smethod_61() + 12u + Class333.smethod_62() + num2 + Class333.smethod_63());
				bool_2 = true;
				method_23(bool_1: true);
				return false;
			}
			if ((array2[0] & 0xF0) == 128)
			{
				num -= uint_4;
				Class1.smethod_86(Class333.smethod_60());
			}
			Array.Copy(array2, array, 12L);
			init = crc2.crc_process(array, 0u, 12u, init, partial: true);
			uint num3 = num - 12;
			uint num4 = method_0().imethod_18();
			uint num5 = num3;
			for (uint num6 = 0u; num6 <= num3 / num4; num6++)
			{
				num2 = 0u;
				if (num5 <= num4)
				{
					byte[] sourceArray = new byte[num5];
					if (!method_0().imethod_17(ref sourceArray, num5, out num2, byte_2[1]) || num2 != num5)
					{
						Class1.smethod_86(Class333.smethod_64() + num5 + Class333.smethod_62() + num2 + Class333.smethod_63());
						bool_2 = true;
						method_23(bool_1: true);
						return false;
					}
					num2 = num5;
					Array.Copy(sourceArray, 0L, array, 12 + num6 * num4, num2);
					init = crc2.crc_process(array, 12 + num6 * num4, num2 - 4, init, partial: false);
				}
				else
				{
					byte[] sourceArray2 = new byte[num4];
					if (!method_0().imethod_17(ref sourceArray2, num4, out num2, byte_2[1]) || num2 != num4)
					{
						Class1.smethod_86(Class333.smethod_64() + num4 + Class333.smethod_62() + num2 + Class333.smethod_63());
						bool_2 = true;
						method_23(bool_1: true);
						return false;
					}
					num2 = num4;
					Array.Copy(sourceArray2, 0L, array, 12 + num6 * num4, num2);
					init = crc2.crc_process(array, 12 + num6 * num4, num2, init, partial: true);
				}
				num5 -= num2;
			}
		}
		else
		{
			bool flag = method_0().imethod_17(ref array, num, out num2, byte_2[1]) && num2 == num;
			if ((array[0] & 0xF0) == 128)
			{
				num -= uint_4;
				Class1.smethod_86(Class333.smethod_60());
			}
			else if (!flag)
			{
				Class1.smethod_86(Class333.smethod_65() + num + Class333.smethod_62() + num2 + Class333.smethod_63());
				bool_2 = true;
				method_23(bool_1: true);
				return false;
			}
			init = crc2.crc_process(array, 0u, num - 4, init, partial: false);
		}
		bool flag2 = true;
		for (int i = 1; i < 8L; i++)
		{
			if (array[i] != byte_2[i])
			{
				flag2 = false;
				break;
			}
		}
		bool flag3 = false;
		if (flag2)
		{
			flag3 = array[num - 4] == (byte)(init >> 24) && array[1 + num - 4] == (byte)(init >> 16) && array[2 + num - 4] == (byte)(init >> 8) && array[3 + num - 4] == (byte)init;
		}
		if (flag2 & flag3)
		{
			bool_1 = (array[0] & 0xF0) == 128;
			if (!bool_1)
			{
				uint num7 = ((array[0] != 2) ? uint_4 : ((uint)((array[8] << 24) | ((array[9] << 16) & 0xFF0000) | ((array[10] << 8) & 0xFF00) | (array[11] & 0xFF))));
				byte_3 = new byte[num7];
				Array.Copy(array, 12L, byte_3, 0L, num7);
			}
			result = !bool_1;
		}
		method_23(bool_1: false);
		return result;
	}

	internal bool method_29(byte byte_2, int int_2, Enum10 enum10_0, uint uint_4, uint uint_5, out byte[] byte_3, out bool bool_1)
	{
		byte_3 = new byte[uint_5];
		bool_1 = false;
		if (method_64(enum10_0) == 0)
		{
			return false;
		}
		uint ushort_ = method_13().struct1_0[(uint)enum10_0].ushort_2;
		ushort ushort_2 = method_13().struct1_0[(uint)enum10_0].ushort_1;
		uint num = uint_4;
		uint num2 = 0u;
		uint num3 = uint_5;
		if (ushort_2 != 0)
		{
			num = uint_4 / ushort_2 * ushort_2;
			num2 = uint_4 % ushort_2;
			num3 += num2;
		}
		if (ushort_ != 0)
		{
			if (num3 % ushort_ != 0)
			{
				num3 += ushort_ - num3 % ushort_;
			}
			else if (num3 == 0)
			{
				num3 += ushort_;
			}
		}
		uint num4 = num3;
		uint num5 = 0u;
		uint num6 = num;
		int num7;
		do
		{
			if (num4 != 0)
			{
				num7 = int_2;
				do
				{
					uint val = method_64(enum10_0);
					uint num8 = Math.Min(num4, val);
					if (ushort_2 != 0 && num8 >= ushort_2)
					{
						num8 = num8 / ushort_2 * ushort_2;
					}
					bool flag = false;
					lock (class5_0)
					{
						if (method_27(byte_2, enum10_0, num6, num8, out var byte_4))
						{
							Thread.Sleep(0);
							Stopwatch stopwatch = new Stopwatch();
							stopwatch.Start();
							bool flag2 = method_28(byte_4, out var byte_5, num8, out bool_1, out var _);
							stopwatch.Stop();
							dictionary_1[enum10_0] = (uint)stopwatch.ElapsedMilliseconds;
							dictionary_0[enum10_0] = num8;
							if (flag2)
							{
								if (byte_5.Length < num8)
								{
									byte[] sourceArray = byte_3;
									byte_3 = new byte[uint_5 - (num8 - byte_5.Length)];
									Array.Copy(sourceArray, 0, byte_3, 0, byte_3.Length);
								}
								uint num9;
								uint num10;
								uint num11;
								if (num5 == 0)
								{
									num9 = num2;
									num10 = 0u;
									num11 = Math.Min((uint)byte_5.Length - num2, (uint)(byte_3.Length - 0));
								}
								else
								{
									num9 = 0u;
									num10 = num5 - num2;
									num11 = Math.Min((uint)byte_5.Length, (uint)byte_3.Length - num10);
								}
								Array.Copy(byte_5, num9, byte_3, num10, num11);
								num4 -= num8;
								num5 += num8;
								num6 += num8;
								if (num5 - num2 >= uint_5)
								{
									return true;
								}
								flag = true;
							}
						}
						if (!flag && !bool_1)
						{
							method_0().imethod_23();
						}
					}
					if (!flag)
					{
						num7--;
						continue;
					}
					if (eventHandler_3 != null)
					{
						EventArgs1 eventArgs = new EventArgs1();
						eventArgs.uint_0 = num5;
						eventArgs.uint_1 = num4;
						eventHandler_3(this, eventArgs);
					}
					break;
				}
				while (num7 != 0);
				continue;
			}
			return true;
		}
		while (num7 != 0);
		return false;
	}

	private bool method_30(byte byte_2, Enum10 enum10_0, uint uint_4, byte[] byte_3, out byte[] byte_4)
	{
		uint num = method_13().struct1_0[(uint)enum10_0].uint_0;
		if (enum10_0 == Enum10.const_0)
		{
			num = 0u;
		}
		uint num2 = num + uint_4;
		uint num3 = (uint)(12 + byte_3.Length + 4);
		byte_4 = new byte[num3];
		byte_4[0] = 1;
		byte_4[1] = byte_0++;
		byte_4[2] = 0;
		byte_4[3] = byte_2;
		byte_4[4] = (byte)(num2 >> 24);
		byte_4[5] = (byte)(num2 >> 16);
		byte_4[6] = (byte)(num2 >> 8);
		byte_4[7] = (byte)num2;
		byte_4[8] = (byte)(byte_3.Length >> 24);
		byte_4[9] = (byte)(byte_3.Length >> 16);
		byte_4[10] = (byte)(byte_3.Length >> 8);
		byte_4[11] = (byte)byte_3.Length;
		Array.Copy(byte_3, 0L, byte_4, 12L, byte_3.Length);
		uint num4 = new global::crc.crc().crc_process(byte_4, 0u, num3 - 4, uint.MaxValue, partial: false);
		byte_4[num3 - 4] = (byte)(num4 >> 24);
		byte_4[1 + num3 - 4] = (byte)(num4 >> 16);
		byte_4[2 + num3 - 4] = (byte)(num4 >> 8);
		byte_4[3 + num3 - 4] = (byte)num4;
		int_0++;
		dateTime_0 = DateTime.Now;
		if (method_0().imethod_16(byte_4, (uint)byte_4.Length, out var num5))
		{
			return num5 == num3;
		}
		return false;
	}

	private bool method_31(byte[] byte_2, out bool bool_1, out bool bool_2)
	{
		bool flag = false;
		bool_1 = false;
		byte[] array = new byte[16];
		if (method_0().imethod_17(ref array, 16u, out var num, byte_2[1]) && num == 16)
		{
			bool_2 = false;
			flag = true;
			for (int i = 1; i < 12L; i++)
			{
				if (array[i] != byte_2[i])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				uint num2 = new global::crc.crc().crc_process(array, 0u, (uint)(array.Length - 4), uint.MaxValue, partial: false);
				if (array[array.Length - 4L] != (byte)(num2 >> 24) || array[1 + array.Length - 4L] != (byte)(num2 >> 16) || array[2 + array.Length - 4L] != (byte)(num2 >> 8) || array[3 + array.Length - 4L] != (byte)num2)
				{
					flag = false;
				}
			}
			if (flag)
			{
				bool_1 = (array[0] & 0xF0) == 128;
				if (bool_1)
				{
					flag = false;
				}
			}
		}
		else
		{
			bool_2 = true;
		}
		method_23(bool_2);
		return flag;
	}

	internal bool method_32(byte byte_2, int int_2, Enum10 enum10_0, uint uint_4, byte[] byte_3, out bool bool_1)
	{
		bool_1 = false;
		uint num = method_65(enum10_0);
		if (num == 0)
		{
			return false;
		}
		uint num2 = (uint)byte_3.Length;
		uint num3 = 0u;
		uint num4 = uint_4;
		int num5;
		do
		{
			if (num2 != 0)
			{
				num5 = int_2;
				do
				{
					uint num6 = Math.Min(num2, num);
					byte[] array = new byte[num6];
					Array.Copy(byte_3, num3, array, 0L, num6);
					bool flag = false;
					lock (class5_0)
					{
						if (method_30(byte_2, enum10_0, num4, array, out var byte_4))
						{
							Thread.Sleep(0);
							if (method_31(byte_4, out bool_1, out var _))
							{
								num2 -= num6;
								num3 += num6;
								num4 += num6;
								flag = true;
							}
						}
						if (!flag && !bool_1)
						{
							method_0().imethod_23();
						}
					}
					if (!flag)
					{
						num5--;
						continue;
					}
					if (eventHandler_3 != null)
					{
						EventArgs1 eventArgs = new EventArgs1();
						eventArgs.uint_0 = num3;
						eventArgs.uint_1 = num2;
						eventHandler_3(this, eventArgs);
					}
					break;
				}
				while (num5 != 0);
				continue;
			}
			return true;
		}
		while (num5 != 0);
		return false;
	}

	internal bool method_33(byte byte_2, int int_2, Enum10 enum10_0, uint uint_4, byte[] byte_3, uint uint_5, out byte[] byte_4, out bool bool_1)
	{
		byte_4 = new byte[uint_5];
		bool_1 = false;
		uint num = method_65(enum10_0);
		if (num != 0 && (uint)byte_3.Length <= num)
		{
			uint num2 = method_64(enum10_0);
			if (num2 != 0 && uint_5 <= num2)
			{
				int num3 = int_2;
				do
				{
					lock (class5_0)
					{
						if (method_30(byte_2, enum10_0, uint_4, byte_3, out var byte_5))
						{
							Thread.Sleep(0);
							if (method_28(byte_5, out byte_4, uint_5, out bool_1, out var _) && byte_4.Length == uint_5)
							{
								return true;
							}
						}
						if (!bool_1)
						{
							method_0().imethod_23();
						}
					}
					num3--;
				}
				while (num3 != 0);
				return false;
			}
			return false;
		}
		return false;
	}

	internal bool method_34(byte byte_2, Enum10 enum10_0, uint uint_4, byte[] byte_3)
	{
		if (method_30(byte_2, enum10_0, uint_4, byte_3, out var byte_4))
		{
			byte_1 = byte_4;
			method_0().imethod_15(bool_0: true);
			return true;
		}
		return false;
	}

	internal bool method_35(out bool bool_1)
	{
		if (byte_1 == null)
		{
			throw new Exception(Class333.smethod_66());
		}
		bool_1 = method_31(byte_1, out var _, out var bool_3);
		if (!bool_3)
		{
			method_0().imethod_15(bool_0: false);
			byte_1 = null;
		}
		return !bool_3;
	}

	internal bool method_36(byte byte_2, byte byte_3, out bool bool_1)
	{
		byte[] byte_4 = new byte[4] { 0, 14, 0, byte_3 };
		return method_32(byte_2, 2, Enum10.const_0, 0u, byte_4, out bool_1);
	}

	internal bool method_37(byte byte_2, out byte[] byte_3, out bool bool_1)
	{
		byte[] array = new byte[4] { 0, 15, 0, 0 };
		byte_3 = new byte[1];
		if (method_33(byte_2, 2, Enum10.const_0, 0u, array, (uint)array.Length, out var byte_4, out bool_1))
		{
			byte_3 = new byte[byte_4.Length];
			Array.Copy(byte_4, byte_3, byte_4.Length);
			return true;
		}
		byte_3[0] = byte.MaxValue;
		return false;
	}

	internal bool method_38(byte byte_2, out bool bool_1)
	{
		byte[] byte_3 = new byte[2] { 0, 6 };
		return method_32(byte_2, 2, Enum10.const_0, 0u, byte_3, out bool_1);
	}

	internal bool method_39(byte byte_2, out bool bool_1)
	{
		byte[] byte_3 = new byte[2] { 0, 12 };
		return method_32(byte_2, 2, Enum10.const_0, 0u, byte_3, out bool_1);
	}

	internal bool method_40(byte byte_2, out bool bool_1)
	{
		byte[] byte_3 = new byte[2] { 0, 13 };
		return method_32(byte_2, 2, Enum10.const_0, 0u, byte_3, out bool_1);
	}

	internal bool method_41(byte byte_2, out bool bool_1)
	{
		DateTime now = DateTime.Now;
		return method_32(byte_2, 2, Enum10.const_0, 0u, new byte[10]
		{
			0,
			5,
			(byte)(now.Year >> 8),
			(byte)now.Year,
			(byte)now.Month,
			(byte)now.Day,
			(byte)now.Hour,
			(byte)now.Minute,
			(byte)now.Second,
			0
		}, out bool_1);
	}

	internal bool method_42(byte byte_2, string string_0, string string_1, out bool bool_1)
	{
		Class14 @class = new Class14(1, 25, 0, 9, 0);
		Class14 class2 = new Class14(class5_0.byte_0, class5_0.byte_1, class5_0.byte_2, class5_0.byte_3, class5_0.int_0);
		bool flag;
		byte[] array = ((!(flag = class5_0.byte_4 != 8 && class5_0.byte_4 != 10 && class2 >= @class)) ? new byte[98] : new byte[99]);
		array[0] = 0;
		array[1] = 7;
		Encoding encoding = Encoding.GetEncoding(20127);
		byte[] bytes = encoding.GetBytes(string_0);
		byte[] bytes2 = encoding.GetBytes(string_1);
		for (int i = 0; i < 32; i++)
		{
			if (i < string_0.Length)
			{
				array[2 + i] = bytes[i];
			}
			else
			{
				array[2 + i] = 0;
			}
		}
		for (int j = 0; j < 64; j++)
		{
			if (j < string_1.Length)
			{
				array[34 + j] = bytes2[j];
			}
			else
			{
				array[34 + j] = 0;
			}
		}
		if (flag)
		{
			array[98] = 1;
		}
		return method_32(byte_2, 2, Enum10.const_0, 0u, array, out bool_1);
	}

	internal bool method_43(byte byte_2, out bool bool_1)
	{
		byte[] byte_3 = new byte[2] { 0, 8 };
		return method_32(byte_2, 2, Enum10.const_0, 0u, byte_3, out bool_1);
	}

	internal bool method_44(byte byte_2, out bool bool_1)
	{
		byte[] byte_3 = new byte[2] { 0, 3 };
		return method_32(byte_2, 2, Enum10.const_0, 0u, byte_3, out bool_1);
	}

	internal bool method_45(byte byte_2, byte byte_3, uint uint_4, int int_2, byte[] byte_4, out bool bool_1)
	{
		byte[] array = new byte[28]
		{
			0, 4, byte_3, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0
		};
		for (int i = 0; i < byte_4.Length; i++)
		{
			array[4 + i] = byte_4[i];
		}
		array[20] = (byte)(uint_4 >> 24);
		array[21] = (byte)(uint_4 >> 16);
		array[22] = (byte)(uint_4 >> 8);
		array[23] = (byte)uint_4;
		array[24] = (byte)(int_2 >> 24);
		array[25] = (byte)(int_2 >> 16);
		array[26] = (byte)(int_2 >> 8);
		array[27] = (byte)int_2;
		return method_32(byte_2, 2, Enum10.const_0, 0u, array, out bool_1);
	}

	internal bool method_46(byte byte_2, out bool bool_1)
	{
		byte[] byte_3 = new byte[2] { 0, 19 };
		return method_32(byte_2, 2, Enum10.const_0, 0u, byte_3, out bool_1);
	}

	internal bool method_47(byte byte_2, out bool bool_1)
	{
		byte[] byte_3 = new byte[2] { 0, 20 };
		return method_32(byte_2, 2, Enum10.const_0, 0u, byte_3, out bool_1);
	}

	internal bool method_48(byte byte_2, byte[] byte_3)
	{
		bool result = false;
		lock (class5_0)
		{
			if (!method_13().bool_1)
			{
				result = method_30(byte_2, Enum10.const_0, 0u, byte_3, out var _);
			}
		}
		return result;
	}

	internal void method_49(byte byte_2)
	{
		dateTime_0 = DateTime.Now;
		lock (class5_0)
		{
			if (method_13().bool_1)
			{
				class9_0.method_12();
				return;
			}
			byte[] byte_3 = new byte[2];
			method_30(byte_2, Enum10.const_0, 0u, byte_3, out var _);
		}
	}

	internal void method_50(byte byte_2)
	{
		dateTime_0 = DateTime.Now;
		lock (class5_0)
		{
			if (method_13().bool_1)
			{
				class9_0.method_13();
				return;
			}
			byte[] byte_3 = new byte[2] { 0, 1 };
			method_30(byte_2, Enum10.const_0, 0u, byte_3, out var _);
		}
	}

	internal void method_51(byte byte_2)
	{
		dateTime_0 = DateTime.Now;
		lock (class5_0)
		{
			if (!method_13().bool_1)
			{
				byte[] byte_3 = new byte[2] { 0, 18 };
				method_30(byte_2, Enum10.const_0, 0u, byte_3, out var _);
			}
		}
	}

	internal bool method_52(byte byte_2, Class1.Enum5 enum5_0, out Class1.Enum4 enum4_0, out ushort ushort_0, out bool bool_1)
	{
		byte[] byte_3 = new byte[2]
		{
			1,
			(byte)enum5_0
		};
		method_66(1500u);
		if (method_33(byte_2, 2, Enum10.const_14, 0u, byte_3, 3u, out var byte_4, out bool_1))
		{
			method_67();
			enum4_0 = (Class1.Enum4)byte_4[0];
			ushort_0 = (ushort)((byte_4[1] << 8) | (byte_4[2] & 0xFF));
			return true;
		}
		method_67();
		enum4_0 = Class1.Enum4.BFb;
		ushort_0 = 0;
		return false;
	}

	internal bool method_53(byte byte_2, Class1.Enum5 enum5_0, ushort ushort_0, ushort ushort_1, out Class1.Enum4 enum4_0, out Class10[] class10_0, out bool bool_1)
	{
		ushort num = (ushort)(1 + ushort_1 - ushort_0);
		class10_0 = new Class10[num];
		int num2 = 60;
		ushort num3 = (ushort)((method_64(Enum10.const_14) - 1) / 60);
		ushort num4 = ushort_0;
		ushort num5 = (ushort)Math.Min(ushort_1, num4 + num3 - 1);
		ushort num6 = 0;
		while (true)
		{
			byte[] byte_3 = new byte[6]
			{
				2,
				(byte)enum5_0,
				(byte)((num4 >> 8) & 0xFF),
				(byte)(num4 & 0xFF),
				(byte)((num5 >> 8) & 0xFF),
				(byte)(num5 & 0xFF)
			};
			ushort num7 = (ushort)(1 + num5 - num4);
			uint uint_ = (uint)(1 + num2 * num7);
			if (!method_33(byte_2, 2, Enum10.const_14, 0u, byte_3, uint_, out var byte_4, out bool_1))
			{
				break;
			}
			enum4_0 = (Class1.Enum4)byte_4[0];
			if (enum4_0 == Class1.Enum4.BFC)
			{
				for (int i = 0; i < num7; i++)
				{
					int sourceIndex = 1 + i * num2;
					byte[] destinationArray = new byte[num2];
					Array.Copy(byte_4, sourceIndex, destinationArray, 0, num2);
					Class10 @class = new Class10();
					class10_0[num6 + i] = @class;
					@class.method_1(destinationArray);
				}
				num6 += num7;
				if (num6 < num)
				{
					num4 = (ushort)(num5 + 1);
					num5 = (ushort)Math.Min(ushort_1, num4 + num3 - 1);
				}
				if (num6 >= num)
				{
					return true;
				}
				continue;
			}
			class10_0 = null;
			return false;
		}
		enum4_0 = Class1.Enum4.BFb;
		class10_0 = null;
		return false;
	}

	internal bool method_54(byte byte_2, Class10 class10_0, uint uint_4, uint uint_5, out Class1.Enum4 enum4_0, out byte[] byte_3, out bool bool_1)
	{
		byte_3 = new byte[uint_5];
		byte[] array = class10_0.method_0();
		uint num = method_64(Enum10.const_14);
		uint num2 = 0u;
		while (true)
		{
			uint num3 = Math.Min(uint_5 - num2, num - 4);
			uint num4 = uint_4 + num2;
			byte[] array2 = new byte[4 + array.Length + 4 + 4];
			array2[0] = 3;
			Array.Copy(array, 0, array2, 4, array.Length);
			array2[4 + array.Length] = (byte)((num4 >> 24) & 0xFF);
			array2[4 + array.Length + 1] = (byte)((num4 >> 16) & 0xFF);
			array2[4 + array.Length + 2] = (byte)((num4 >> 8) & 0xFF);
			array2[4 + array.Length + 3] = (byte)(num4 & 0xFF);
			array2[4 + array.Length + 4] = (byte)((num3 >> 24) & 0xFF);
			array2[4 + array.Length + 5] = (byte)((num3 >> 16) & 0xFF);
			array2[4 + array.Length + 6] = (byte)((num3 >> 8) & 0xFF);
			array2[4 + array.Length + 7] = (byte)(num3 & 0xFF);
			uint uint_6 = 4 + num3;
			if (!method_33(byte_2, 2, Enum10.const_14, 0u, array2, uint_6, out var byte_4, out bool_1))
			{
				break;
			}
			enum4_0 = (Class1.Enum4)byte_4[0];
			if (enum4_0 == Class1.Enum4.BFC)
			{
				Array.Copy(byte_4, 4L, byte_3, num2, num3);
				num2 += num3;
				if (num2 >= uint_5)
				{
					return true;
				}
				continue;
			}
			byte_3 = null;
			return false;
		}
		enum4_0 = Class1.Enum4.BFb;
		byte_3 = null;
		return false;
	}

	internal bool method_55(byte byte_2, Class10 class10_0, uint uint_4, byte[] byte_3, out Class1.Enum4 enum4_0, out bool bool_1)
	{
		byte[] array = class10_0.method_0();
		uint num = method_65(Enum10.const_14);
		uint num2 = 0u;
		while (true)
		{
			uint num3 = (uint)(4 + array.Length + 4);
			uint num4 = Math.Min((uint)byte_3.Length - num2, num - num3);
			uint num5 = uint_4 + num2;
			byte[] array2 = new byte[num3 + num4];
			array2[0] = 6;
			Array.Copy(array, 0, array2, 4, array.Length);
			array2[4 + array.Length] = (byte)((num5 >> 24) & 0xFF);
			array2[4 + array.Length + 1] = (byte)((num5 >> 16) & 0xFF);
			array2[4 + array.Length + 2] = (byte)((num5 >> 8) & 0xFF);
			array2[4 + array.Length + 3] = (byte)(num5 & 0xFF);
			Array.Copy(byte_3, num2, array2, num3, num4);
			if (!method_33(byte_2, 2, Enum10.const_14, 0u, array2, 1u, out var byte_4, out bool_1))
			{
				break;
			}
			enum4_0 = (Class1.Enum4)byte_4[0];
			if (enum4_0 == Class1.Enum4.BFC)
			{
				num2 += num4;
				if (num2 >= byte_3.Length)
				{
					return true;
				}
				continue;
			}
			return false;
		}
		enum4_0 = Class1.Enum4.BFb;
		return false;
	}

	internal bool method_56(byte byte_2, Class10 class10_0, Class10 class10_1, out Class1.Enum4 enum4_0, out bool bool_1)
	{
		byte[] array = class10_0.method_0();
		byte[] array2 = class10_1.method_0();
		byte[] array3 = new byte[4 + array.Length + array2.Length];
		array3[0] = 4;
		Array.Copy(array, 0, array3, 4, array.Length);
		Array.Copy(array2, 0, array3, 4 + array.Length, array2.Length);
		if (method_33(byte_2, 2, Enum10.const_14, 0u, array3, 1u, out var byte_3, out bool_1))
		{
			enum4_0 = (Class1.Enum4)byte_3[0];
			return true;
		}
		enum4_0 = Class1.Enum4.BFb;
		return false;
	}

	internal bool method_57(byte byte_2, Class10 class10_0, out Class1.Enum4 enum4_0, out bool bool_1)
	{
		byte[] array = class10_0.method_0();
		byte[] array2 = new byte[4 + array.Length];
		array2[0] = 5;
		Array.Copy(array, 0, array2, 4, array.Length);
		if (method_33(byte_2, 2, Enum10.const_14, 0u, array2, 1u, out var byte_3, out bool_1))
		{
			enum4_0 = (Class1.Enum4)byte_3[0];
			return true;
		}
		enum4_0 = Class1.Enum4.BFb;
		return false;
	}

	internal bool method_58(List<uint> list_0, List<byte[]> list_1, List<uint> list_2)
	{
		dateTime_0 = DateTime.Now;
		if (method_13().bool_1)
		{
			return class9_0.method_18(list_0, list_1, list_2);
		}
		return false;
	}

	internal bool method_59(byte byte_2, uint uint_4, uint uint_5, uint uint_6, byte byte_3, byte byte_4, byte byte_5, byte byte_6, out int int_2)
	{
		dateTime_0 = DateTime.Now;
		if (method_13().bool_1)
		{
			return class9_0.method_14(byte_2, uint_4, uint_5, uint_6, byte_3, byte_4, byte_5, byte_6, out int_2);
		}
		int_2 = 65535;
		return false;
	}

	internal bool method_60()
	{
		dateTime_0 = DateTime.Now;
		if (method_13().bool_1)
		{
			return class9_0.method_16();
		}
		return false;
	}

	internal bool method_61()
	{
		dateTime_0 = DateTime.Now;
		if (method_13().bool_1)
		{
			return class9_0.method_17();
		}
		return false;
	}

	internal bool method_62(byte byte_2, byte byte_3, byte byte_4, byte byte_5, byte byte_6, byte byte_7)
	{
		dateTime_0 = DateTime.Now;
		if (method_13().bool_1)
		{
			return class9_0.method_15(byte_2, byte_3, byte_4, byte_5, byte_6, byte_7);
		}
		return false;
	}

	internal void method_63(uint uint_4)
	{
		uint_3 = uint_4;
	}

	internal uint method_64(Enum10 enum10_0)
	{
		if (enum10_0 != Enum10.const_0)
		{
			if (enum10_0 == Enum10.const_12 && method_0() is Class8)
			{
				return Math.Min(val2: Class1.enum6_0 switch
				{
					Enum6.const_0 => method_13().struct1_0[40].uint_2 / 8, 
					Enum6.const_1 => method_13().struct1_0[40].uint_2 / 4, 
					Enum6.const_2 => method_13().struct1_0[40].uint_2 / 2, 
					Enum6.const_3 => method_13().struct1_0[40].uint_2, 
					_ => method_13().struct1_0[40].uint_2, 
				}, val1: Math.Max(Math.Max(method_0().imethod_22(), method_13().struct1_0[40].ushort_1), method_13().struct1_0[40].ushort_2));
			}
			if (method_13().struct2_0[(uint)method_2()].uint_0 == 0)
			{
				return 0u;
			}
			uint num = 1u;
			if (enum10_0 == Enum10.const_12 && method_0() is Class15)
			{
				switch (Class1.enum6_0)
				{
				case Enum6.const_0:
					num = 2u;
					break;
				case Enum6.const_1:
					num = 4u;
					break;
				case Enum6.const_2:
					num = 8u;
					break;
				case Enum6.const_3:
					num = 32u;
					break;
				}
			}
			method_0().imethod_21(ref num);
			uint val = num * (method_13().struct2_0[(uint)method_2()].uint_0 - 16);
			val = Math.Min(Math.Max(Math.Max(method_0().imethod_22(), method_13().struct1_0[(uint)enum10_0].ushort_1), method_13().struct1_0[(uint)enum10_0].ushort_2), val);
			if (uint_3 != 0)
			{
				val = Math.Min(val, uint_3);
			}
			return Math.Min(method_13().struct1_0[(uint)enum10_0].uint_2, val);
		}
		return 2048u;
	}

	internal uint method_65(Enum10 enum10_0)
	{
		if (method_13().struct2_0[(uint)method_2()].ushort_0 == 0)
		{
			return 0u;
		}
		return Math.Min(method_13().struct1_0[(uint)enum10_0].ushort_0, (uint)(method_13().struct2_0[(uint)method_2()].ushort_0 - 16));
	}

	internal void method_66(uint uint_4)
	{
		method_0().imethod_12(uint_4);
	}

	internal void method_67()
	{
		method_0().imethod_13();
	}

	internal void method_68(bool bool_1)
	{
		method_0().imethod_15(bool_1);
	}

	internal bool method_69(string string_0, out byte[] byte_2, out bool bool_1)
	{
		if (class5_0.byte_4 != 8 && class5_0.byte_4 != 10)
		{
			if (string_0 != null)
			{
				uint num;
				uint uint_;
				switch (string_0.Length)
				{
				case 3:
				{
					char c = string_0[0];
					if (c != 'e')
					{
						if (c != 'p' || !(string_0 == Class333.smethod_67()))
						{
							break;
						}
						num = 273u;
					}
					else
					{
						if (!(string_0 == Class333.smethod_68()))
						{
							break;
						}
						num = 277u;
					}
					goto IL_0124;
				}
				case 4:
				{
					char c = string_0[0];
					if (c != 'd')
					{
						if (c != 'f')
						{
							if (c != 'w' || !(string_0 == Class333.smethod_70()))
							{
								break;
							}
							num = 275u;
						}
						else
						{
							if (!(string_0 == Class333.smethod_71()))
							{
								break;
							}
							num = 276u;
						}
					}
					else
					{
						if (!(string_0 == Class333.smethod_72()))
						{
							break;
						}
						num = 619u;
					}
					goto IL_0124;
				}
				case 5:
					if (!(string_0 == Class333.smethod_73()))
					{
						break;
					}
					num = 277u;
					goto IL_0124;
				case 8:
					{
						if (!(string_0 == Class333.smethod_69()))
						{
							break;
						}
						num = 274u;
						goto IL_0124;
					}
					IL_0124:
					uint_ = num * 4;
					return method_29(0, 3, Enum10.const_5, uint_, 4u, out byte_2, out bool_1);
				}
			}
			byte_2 = null;
			bool_1 = true;
			return false;
		}
		byte_2 = null;
		bool_1 = true;
		return false;
	}

	internal uint method_70(Enum10 enum10_0)
	{
		return dictionary_0[enum10_0];
	}

	internal uint method_71(Enum10 enum10_0)
	{
		return dictionary_1[enum10_0];
	}

	internal uint[,] method_72()
	{
		return method_0().imethod_30();
	}

	internal uint method_73()
	{
		return method_0().imethod_31();
	}

	internal uint method_74()
	{
		return method_0().imethod_29();
	}

	internal uint method_75()
	{
		return method_0().imethod_32();
	}
}
