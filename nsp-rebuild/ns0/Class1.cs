using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ns7;

namespace ns0;

internal static class Class1
{
	private struct Struct0(Enum11 enum11_0)
	{
		public Enum11 Bek = enum11_0;

		public Dictionary<string, Class4> BeL = new Dictionary<string, Class4>();

		public List<string> Bel = new List<string>();

		public List<string> BeM = new List<string>();
	}

	internal enum Enum2 : byte
	{
		Bem = 0,
		BeN = 1,
		Ben = 2,
		BeO = 3,
		Beo = 4,
		BeP = 5,
		Bep = 6,
		BeQ = 7,
		Beq = 8,
		BeR = 9,
		Ber = 10,
		BeS = 11,
		Bes = 12,
		BeT = 13,
		Bet = 14,
		BeU = 15,
		Beu = 18,
		BeV = 19,
		Bev = 20
	}

	internal enum Enum3
	{
		BeW = 0,
		Bew = 1,
		BeX = 2,
		Bex = 128,
		BeY = 129,
		Bey = 130,
		BeZ = 131,
		Bez = 132,
		BFA = 144,
		BFa = 145,
		BFB = 146
	}

	internal enum Enum4 : byte
	{
		BFb = byte.MaxValue,
		BFC = 0,
		BFc = 1,
		BFD = 2,
		BFd = 3,
		BFE = 4,
		BFe = 5,
		BFF = 6,
		BFf = 7,
		BFG = 8,
		BFg = 9
	}

	internal enum Enum5 : byte
	{
		BFH = 0,
		BFh = 1,
		BFI = byte.MaxValue
	}

	[CompilerGenerated]
	private static class Class2
	{
		public static EventHandler BFi;

		public static EventHandler BFJ;

		public static EventHandler BFj;

		public static EventHandler BFK;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class3
	{
		public static readonly Class3 BFk = new Class3();

		public static ThreadStart BFL;

		internal void method_0()
		{
			smethod_4(cancellationTokenSource_0.Token);
		}
	}

	private static List<Struct0> list_0;

	private static Class4 class4_0;

	private static bool bool_0;

	private static Thread thread_0;

	private static Stopwatch stopwatch_0;

	private static CancellationTokenSource cancellationTokenSource_0;

	private static string string_0;

	private const string string_1 = "PlaceholderForDetection";

	[CompilerGenerated]
	private static EventHandler eventHandler_0;

	[CompilerGenerated]
	private static Delegate2 delegate2_0;

	internal static byte byte_0;

	internal static byte byte_1;

	[CompilerGenerated]
	private static Delegate1 delegate1_0;

	internal const int int_0 = 3;

	internal const int int_1 = 2;

	internal static Enum6 enum6_0;

	[CompilerGenerated]
	private static Delegate0 delegate0_0;

	static Class1()
	{
		list_0 = new List<Struct0>();
		class4_0 = null;
		bool_0 = false;
		thread_0 = null;
		stopwatch_0 = new Stopwatch();
		cancellationTokenSource_0 = null;
		string_0 = null;
		byte_0 = 0;
		byte_1 = 0;
		enum6_0 = Enum6.const_2;
		list_0.Add(new Struct0(Enum11.const_0));
		list_0.Add(new Struct0(Enum11.const_3));
		list_0.Add(new Struct0(Enum11.const_2));
		list_0.Add(new Struct0(Enum11.const_1));
	}

	internal static bool smethod_0()
	{
		bool_0 = false;
		class4_0 = null;
		try
		{
			if (thread_0 == null || !thread_0.IsAlive)
			{
				try
				{
					if (cancellationTokenSource_0 != null)
					{
						cancellationTokenSource_0.Dispose();
					}
				}
				catch
				{
				}
				cancellationTokenSource_0 = new CancellationTokenSource();
				thread_0 = new Thread(() =>
				{
					smethod_4(cancellationTokenSource_0.Token);
				});
				thread_0.Start();
			}
			stopwatch_0.Restart();
			return true;
		}
		catch
		{
			return false;
		}
	}

	internal static bool smethod_1(Enum11 enum11_0)
	{
		bool_0 = true;
		Class4 @class = new Class4(enum11_0);
		if (@class.method_14(new List<string>()))
		{
			smethod_86(Class333.smethod_1() + enum11_0.ToString() + Class333.smethod_2());
			class4_0 = @class;
			class4_0.method_3(smethod_14);
			class4_0.method_5(smethod_15);
			class4_0.method_7(smethod_16);
			class4_0.method_25(smethod_35);
			smethod_9(new List<Class4> { class4_0 });
			return true;
		}
		class4_0 = null;
		return false;
	}

	internal static void smethod_2()
	{
		if (bool_0)
		{
			if (class4_0 != null)
			{
				smethod_14(class4_0, EventArgs.Empty);
				class4_0 = null;
			}
			bool_0 = false;
			return;
		}
		stopwatch_0.Reset();
		try
		{
			if (thread_0 != null && cancellationTokenSource_0 != null)
			{
				cancellationTokenSource_0.Cancel();
				thread_0 = null;
			}
		}
		catch
		{
		}
		foreach (Struct0 item in list_0)
		{
			try
			{
				if (item.BeL.Count == 0)
				{
					continue;
				}
				List<string> list = new List<string>(item.BeL.Count);
				foreach (string key in item.BeL.Keys)
				{
					list.Add(key);
				}
				foreach (string item2 in list)
				{
					Class4 @class = item.BeL[item2];
					if (@class != null)
					{
						if (item2 == Class333.smethod_3())
						{
							item.BeL.Remove(Class333.smethod_3());
							@class.Dispose();
						}
						else
						{
							smethod_14(@class, EventArgs.Empty);
						}
					}
				}
			}
			catch
			{
			}
		}
	}

	internal static bool smethod_3()
	{
		if (thread_0 != null)
		{
			return thread_0.IsAlive;
		}
		return false;
	}

	private static void smethod_4(CancellationToken cancellationToken_0)
	{
		Thread.CurrentThread.Name = Class333.smethod_4();
		while (!cancellationToken_0.IsCancellationRequested)
		{
			bool flag = false;
			List<Class4> list = new List<Class4>();
			foreach (Struct0 item in list_0)
			{
				if (!cancellationToken_0.IsCancellationRequested)
				{
					smethod_7(item, list);
					if (!cancellationToken_0.IsCancellationRequested)
					{
						smethod_8(item.Bek, item.BeL);
						if (item.BeM.Count != 0)
						{
							flag = true;
						}
						continue;
					}
					break;
				}
				break;
			}
			if (cancellationToken_0.IsCancellationRequested)
			{
				break;
			}
			if (list.Count != 0)
			{
				smethod_9(list);
			}
			if (cancellationToken_0.IsCancellationRequested)
			{
				break;
			}
			if (stopwatch_0.ElapsedMilliseconds < 4000L && !flag)
			{
				Thread.Sleep(100);
				continue;
			}
			if (string.IsNullOrEmpty(string_0))
			{
				if (!flag)
				{
					Thread.Sleep(700);
				}
				else
				{
					Thread.Sleep(2000);
				}
			}
			else if (!flag)
			{
				Thread.Sleep(700);
			}
			else
			{
				Thread.Sleep(3000);
			}
			if (!cancellationToken_0.IsCancellationRequested)
			{
				smethod_18();
				continue;
			}
			break;
		}
	}

	internal static void smethod_5(string string_2)
	{
		string_0 = string_2;
	}

	internal static void smethod_6()
	{
		string_0 = null;
	}

	private static void smethod_7(Struct0 struct0_0, List<Class4> list_1)
	{
		while (true)
		{
			Enum11 bek = struct0_0.Bek;
			Class4 @class;
			if (struct0_0.BeL.Count != 0)
			{
				@class = struct0_0.BeL[Class333.smethod_3()];
			}
			else
			{
				@class = new Class4(bek);
				struct0_0.BeL.Add(Class333.smethod_3(), @class);
			}
			int num = 0;
			foreach (string item in struct0_0.Bel)
			{
				if (!struct0_0.BeM.Contains(item))
				{
					num++;
				}
			}
			bool flag = @class.method_14(struct0_0.Bel);
			int num2 = 0;
			foreach (string item2 in struct0_0.Bel)
			{
				if (!struct0_0.BeM.Contains(item2))
				{
					num2++;
				}
			}
			if (num2 == num)
			{
				struct0_0.Bel.Clear();
				foreach (string item3 in struct0_0.BeM)
				{
					struct0_0.Bel.Add(item3);
				}
			}
			if (!flag)
			{
				break;
			}
			string text = @class.method_13().string_0;
			smethod_86(Class333.smethod_5() + bek.ToString() + Class333.smethod_6() + text);
			if (string.IsNullOrEmpty(string_0) || text == string_0)
			{
				struct0_0.BeM.Add(@class.method_12());
				if (!struct0_0.BeL.ContainsKey(text))
				{
					struct0_0.BeL.Add(text, @class);
					struct0_0.BeL[Class333.smethod_3()] = new Class4(bek);
					@class.method_3(smethod_14);
					@class.method_5(smethod_15);
					@class.method_7(smethod_16);
					@class.method_25(smethod_35);
					list_1.Add(@class);
					if (!string.IsNullOrEmpty(string_0) && text == string_0)
					{
						break;
					}
				}
			}
			Thread.Sleep(0);
		}
	}

	private static void smethod_8(Enum11 enum11_0, Dictionary<string, Class4> dictionary_0)
	{
		try
		{
			foreach (KeyValuePair<string, Class4> item in dictionary_0)
			{
				if (item.Key != Class333.smethod_3())
				{
					Class4 value = item.Value;
					if (!value.method_16())
					{
						value.method_24();
					}
				}
			}
		}
		catch
		{
		}
	}

	private static void smethod_9(List<Class4> list_1)
	{
		List<Class5> list = new List<Class5>(list_1.Count);
		foreach (Class4 item in list_1)
		{
			list.Add(item.method_13());
		}
		if (eventHandler_0 != null)
		{
			eventHandler_0(list, EventArgs.Empty);
		}
		if (bool_0)
		{
			return;
		}
		foreach (Class4 item2 in list_1)
		{
			Enum11 @enum = item2.method_2();
			foreach (Struct0 item3 in list_0)
			{
				if (item3.Bek == @enum)
				{
					continue;
				}
				try
				{
					foreach (KeyValuePair<string, Class4> item4 in item3.BeL)
					{
						if (item4.Key != Class333.smethod_3())
						{
							Class4 value = item4.Value;
							if (item4.Key == item2.method_13().string_0 && !value.method_16())
							{
								smethod_14(value, EventArgs.Empty);
							}
						}
					}
				}
				catch
				{
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_10(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_11(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_12(Delegate2 delegate2_1)
	{
		Delegate2 @delegate = delegate2_0;
		Delegate2 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate2 value = (Delegate2)Delegate.Combine(delegate2, delegate2_1);
			@delegate = Interlocked.CompareExchange(ref delegate2_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_13(Delegate2 delegate2_1)
	{
		Delegate2 @delegate = delegate2_0;
		Delegate2 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate2 value = (Delegate2)Delegate.Remove(delegate2, delegate2_1);
			@delegate = Interlocked.CompareExchange(ref delegate2_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	private static void smethod_14(object sender, EventArgs e)
	{
		Class4 @class = sender as Class4;
		if (!bool_0)
		{
			Enum11 @enum = @class.method_2();
			foreach (Struct0 item in list_0)
			{
				if (item.Bek == @enum)
				{
					if (item.BeL.ContainsKey(@class.method_13().string_0))
					{
						item.BeL.Remove(@class.method_13().string_0);
					}
					if (item.Bel.Contains(@class.method_12()))
					{
						item.Bel.Remove(@class.method_12());
					}
					if (item.BeM.Contains(@class.method_12()))
					{
						item.BeM.Remove(@class.method_12());
					}
				}
			}
		}
		if (delegate2_0 != null)
		{
			EventArgs2 eventArgs = new EventArgs2();
			eventArgs.enum7_0 = Enum7.const_2;
			smethod_86(Class333.smethod_7() + eventArgs.enum7_0.ToString() + Class333.smethod_8() + @class.method_13().string_0 + Class333.smethod_9());
			delegate2_0(@class.method_13().string_0, eventArgs);
		}
		@class.method_4(smethod_14);
		@class.method_6(smethod_15);
		@class.method_8(smethod_16);
		@class.method_26(smethod_35);
		@class.Dispose();
		if (bool_0)
		{
			class4_0 = null;
		}
	}

	private static void smethod_15(object sender, EventArgs e)
	{
		Class4 @class = sender as Class4;
		if (delegate2_0 != null)
		{
			EventArgs2 eventArgs = new EventArgs2();
			eventArgs.enum7_0 = Enum7.const_1;
			smethod_86(Class333.smethod_7() + eventArgs.enum7_0.ToString() + Class333.smethod_8() + @class.method_13().string_0 + Class333.smethod_9());
			delegate2_0(@class.method_13().string_0, eventArgs);
		}
	}

	private static void smethod_16(object sender, EventArgs e)
	{
		Class4 @class = sender as Class4;
		if (delegate2_0 != null)
		{
			EventArgs2 eventArgs = new EventArgs2();
			eventArgs.enum7_0 = Enum7.const_0;
			smethod_86(Class333.smethod_7() + eventArgs.enum7_0.ToString() + Class333.smethod_8() + @class.method_13().string_0 + Class333.smethod_9());
			delegate2_0(@class.method_13().string_0, eventArgs);
		}
	}

	internal static void smethod_17(string string_2)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			smethod_14(@class, EventArgs.Empty);
		}
	}

	internal static void smethod_18()
	{
		if (bool_0)
		{
			return;
		}
		foreach (Class5 item in smethod_27())
		{
			Class4 @class = smethod_23(item.string_0);
			if (@class != null && !@class.method_0().imethod_14() && (@class.dateTime_0 == new DateTime(0L) || (DateTime.Now - @class.dateTime_0).TotalMilliseconds > 3000.0))
			{
				smethod_86(Class333.smethod_10() + @class.method_2().ToString() + Class333.smethod_11() + item.string_0);
				if (@class.method_19())
				{
					smethod_86(Class333.smethod_12() + @class.method_2().ToString() + Class333.smethod_11() + item.string_0);
					@class.method_1();
				}
				else
				{
					smethod_14(@class, EventArgs.Empty);
				}
			}
		}
	}

	internal static void smethod_19(string string_2)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			@class.dateTime_0 = DateTime.Now;
		}
	}

	internal static bool smethod_20(string string_2)
	{
		return smethod_23(string_2)?.method_16() ?? false;
	}

	internal static bool smethod_21(string string_2)
	{
		return smethod_23(string_2)?.method_17() ?? false;
	}

	internal static void smethod_22(string string_2)
	{
		smethod_23(string_2)?.method_18();
	}

	private static Class4 smethod_23(string string_2)
	{
		if (string.IsNullOrEmpty(string_2))
		{
			return null;
		}
		if (bool_0)
		{
			return class4_0;
		}
		foreach (Struct0 item in list_0)
		{
			if (item.BeL.TryGetValue(string_2, out var value))
			{
				return value;
			}
		}
		return null;
	}

	private static Class4 smethod_24(string string_2)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			if (!@class.method_16())
			{
				return null;
			}
			return @class;
		}
		return null;
	}

	internal static Enum11 smethod_25(string string_2)
	{
		return smethod_23(string_2)?.method_2() ?? Enum11.const_4;
	}

	internal static Class5 smethod_26(string string_2)
	{
		return smethod_23(string_2)?.method_13();
	}

	internal static List<Class5> smethod_27()
	{
		List<Class5> list = new List<Class5>();
		try
		{
			if (bool_0)
			{
				if (class4_0 != null)
				{
					list.Add(class4_0.method_13());
				}
			}
			else
			{
				List<string> list2 = new List<string>();
				foreach (Struct0 item in list_0)
				{
					foreach (KeyValuePair<string, Class4> item2 in item.BeL)
					{
						if (item2.Key != Class333.smethod_3())
						{
							Class4 value = item2.Value;
							if (value != null && !list2.Contains(item2.Key))
							{
								list2.Add(item2.Key);
								list.Add(value.method_13());
							}
						}
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	internal static Class5 smethod_28(string string_2)
	{
		return smethod_23(string_2)?.method_15();
	}

	internal static void smethod_29(byte byte_2)
	{
		byte_0 = byte_2;
	}

	internal static void smethod_30()
	{
		byte_0 = 0;
	}

	internal static void smethod_31(byte byte_2)
	{
		byte_1 = byte_2;
	}

	internal static void smethod_32()
	{
		byte_1 = 0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_33(Delegate1 delegate1_1)
	{
		Delegate1 @delegate = delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_1);
			@delegate = Interlocked.CompareExchange(ref delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_34(Delegate1 delegate1_1)
	{
		Delegate1 @delegate = delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Remove(delegate2, delegate1_1);
			@delegate = Interlocked.CompareExchange(ref delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	private static void smethod_35(object sender, EventArgs e)
	{
		if (sender is Class4 && e is EventArgs1)
		{
			Class4 @class = sender as Class4;
			EventArgs1 e2 = e as EventArgs1;
			if (delegate1_0 != null)
			{
				delegate1_0(@class.method_13().string_0, e2);
			}
		}
	}

	internal static bool smethod_36(string string_2, byte byte_2, Enum10 enum10_0, uint uint_0, uint uint_1, out byte[] byte_3, out bool bool_1)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			if (!@class.method_16())
			{
				if (enum10_0 != Enum10.const_0)
				{
					@class.dateTime_0 = DateTime.Now;
				}
				bool_1 = false;
				byte_3 = null;
				return false;
			}
			return @class.method_29(byte_2, 3, enum10_0, uint_0, uint_1, out byte_3, out bool_1);
		}
		bool_1 = false;
		byte_3 = null;
		return false;
	}

	internal static bool smethod_37(string string_2, Enum10 enum10_0, uint uint_0, uint uint_1, out byte[] byte_2, out bool bool_1)
	{
		return smethod_36(string_2, 0, enum10_0, uint_0, uint_1, out byte_2, out bool_1);
	}

	internal static bool smethod_38(string string_2, byte byte_2, Enum10 enum10_0, uint uint_0, byte[] byte_3, out bool bool_1)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			if (!@class.method_16())
			{
				@class.dateTime_0 = DateTime.Now;
				bool_1 = false;
				return false;
			}
			return @class.method_32(byte_2, 2, enum10_0, uint_0, byte_3, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_39(string string_2, Enum10 enum10_0, uint uint_0, byte[] byte_2, out bool bool_1)
	{
		return smethod_38(string_2, 0, enum10_0, uint_0, byte_2, out bool_1);
	}

	internal static bool smethod_40(string string_2, byte byte_2, Enum10 enum10_0, uint uint_0, byte[] byte_3, uint uint_1, out byte[] byte_4, out bool bool_1)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			if (!@class.method_16())
			{
				@class.dateTime_0 = DateTime.Now;
				bool_1 = false;
				byte_4 = null;
				return false;
			}
			return @class.method_33(byte_2, 2, enum10_0, uint_0, byte_3, uint_1, out byte_4, out bool_1);
		}
		bool_1 = false;
		byte_4 = null;
		return false;
	}

	internal static bool smethod_41(string string_2, Enum10 enum10_0, uint uint_0, byte[] byte_2, uint uint_1, out byte[] byte_3, out bool bool_1)
	{
		return smethod_40(string_2, 0, enum10_0, uint_0, byte_2, uint_1, out byte_3, out bool_1);
	}

	internal static bool smethod_42(string string_2, Enum10 enum10_0, uint uint_0, byte[] byte_2, out bool bool_1)
	{
		bool_1 = false;
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			if (!@class.method_16())
			{
				@class.dateTime_0 = DateTime.Now;
				bool_1 = false;
				return false;
			}
			return @class.method_34(0, enum10_0, uint_0, byte_2);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_43(string string_2, out bool bool_1)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			return @class.method_35(out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static void smethod_44(string string_2)
	{
		smethod_24(string_2)?.method_49(0);
	}

	internal static void smethod_45(string string_2)
	{
		smethod_24(string_2)?.method_50(0);
	}

	internal static void smethod_46(string string_2)
	{
		smethod_24(string_2)?.method_51(0);
	}

	internal static bool smethod_47(string string_2, byte[] byte_2)
	{
		return smethod_24(string_2)?.method_48(0, byte_2) ?? false;
	}

	internal static bool smethod_48(string string_2, byte byte_2, byte byte_3, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_36(byte_2, byte_3, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_49(string string_2, byte byte_2, out byte[] byte_3, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_37(byte_2, out byte_3, out bool_1);
		}
		byte_3 = new byte[1];
		bool_1 = false;
		byte_3[0] = byte.MaxValue;
		return false;
	}

	internal static string smethod_50(Enum4 enum4_0)
	{
		return enum4_0 switch
		{
			Enum4.BFb => Class333.smethod_13(), 
			Enum4.BFC => Class333.smethod_14(), 
			Enum4.BFc => Class333.smethod_15(), 
			Enum4.BFD => Class333.smethod_16(), 
			Enum4.BFd => Class333.smethod_17(), 
			Enum4.BFE => Class333.smethod_18(), 
			Enum4.BFe => Class333.smethod_19(), 
			Enum4.BFF => Class333.smethod_20(), 
			Enum4.BFf => Class333.smethod_21(), 
			Enum4.BFG => Class333.smethod_22(), 
			Enum4.BFg => Class333.smethod_23(), 
			_ => Class333.smethod_24(), 
		};
	}

	internal static bool smethod_51(string string_2, Enum5 enum5_0, out Enum4 enum4_0, out ushort ushort_0, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_52(0, enum5_0, out enum4_0, out ushort_0, out bool_1);
		}
		bool_1 = false;
		enum4_0 = Enum4.BFb;
		ushort_0 = 0;
		return false;
	}

	internal static bool smethod_52(string string_2, Enum5 enum5_0, ushort ushort_0, ushort ushort_1, out Enum4 enum4_0, out Class10[] class10_0, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_53(0, enum5_0, ushort_0, ushort_1, out enum4_0, out class10_0, out bool_1);
		}
		bool_1 = false;
		enum4_0 = Enum4.BFb;
		class10_0 = null;
		return false;
	}

	internal static bool smethod_53(string string_2, Class10 class10_0, uint uint_0, uint uint_1, out Enum4 enum4_0, out byte[] byte_2, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_54(0, class10_0, uint_0, uint_1, out enum4_0, out byte_2, out bool_1);
		}
		bool_1 = false;
		enum4_0 = Enum4.BFb;
		byte_2 = null;
		return false;
	}

	internal static bool smethod_54(string string_2, Class10 class10_0, uint uint_0, byte[] byte_2, out Enum4 enum4_0, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_55(0, class10_0, uint_0, byte_2, out enum4_0, out bool_1);
		}
		bool_1 = false;
		enum4_0 = Enum4.BFb;
		return false;
	}

	internal static bool smethod_55(string string_2, Class10 class10_0, Class10 class10_1, out Enum4 enum4_0, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_56(0, class10_0, class10_1, out enum4_0, out bool_1);
		}
		bool_1 = false;
		enum4_0 = Enum4.BFb;
		return false;
	}

	internal static bool smethod_56(string string_2, Class10 class10_0, out Enum4 enum4_0, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_57(0, class10_0, out enum4_0, out bool_1);
		}
		bool_1 = false;
		enum4_0 = Enum4.BFb;
		return false;
	}

	internal static bool smethod_57(string string_2, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_38(0, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_58(string string_2, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_39(0, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_59(string string_2, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_40(0, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_60(string string_2, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_41(0, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_61(string string_2, string string_3, string string_4, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			bool flag = false;
			if (@class.method_13().byte_4 == 21)
			{
				@class.method_66(5000u);
				flag = @class.method_42(0, string_3, string_4, out bool_1);
				@class.method_67();
			}
			else
			{
				flag = @class.method_42(0, string_3, string_4, out bool_1);
			}
			return flag;
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_62(string string_2, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_43(0, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_63(string string_2, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_44(0, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_64(string string_2, byte byte_2, byte byte_3, uint uint_0, int int_2, byte[] byte_4, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_45(byte_2, byte_3, uint_0, int_2, byte_4, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_65(string string_2, byte byte_2, uint uint_0, int int_2, byte[] byte_3, out bool bool_1)
	{
		return smethod_64(string_2, 0, byte_2, uint_0, int_2, byte_3, out bool_1);
	}

	internal static bool smethod_66(string string_2, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_46(0, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_67(string string_2, out bool bool_1)
	{
		Class4 @class = smethod_24(string_2);
		if (@class != null)
		{
			return @class.method_47(0, out bool_1);
		}
		bool_1 = false;
		return false;
	}

	internal static bool smethod_68(string string_2, List<uint> list_1, List<byte[]> list_2, List<uint> list_3)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			return @class.method_58(list_1, list_2, list_3);
		}
		smethod_86(Class333.smethod_25());
		return false;
	}

	internal static bool smethod_69(string string_2, byte byte_2, uint uint_0, uint uint_1, uint uint_2, byte byte_3, byte byte_4, byte byte_5, byte byte_6, out int int_2)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			return @class.method_59(byte_2, uint_0, uint_1, uint_2, byte_3, byte_4, byte_5, byte_6, out int_2);
		}
		smethod_86(Class333.smethod_26());
		int_2 = 65535;
		return false;
	}

	internal static bool smethod_70(string string_2)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			return @class.method_60();
		}
		smethod_86(Class333.smethod_27());
		return false;
	}

	internal static bool smethod_71(string string_2)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			return @class.method_61();
		}
		smethod_86(Class333.smethod_28());
		return false;
	}

	internal static bool smethod_72(string string_2, byte byte_2, byte byte_3, byte byte_4, byte byte_5, byte byte_6, byte byte_7)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			return @class.method_62(byte_2, byte_3, byte_4, byte_5, byte_6, byte_7);
		}
		smethod_86(Class333.smethod_29());
		return false;
	}

	internal static uint smethod_73(string string_2, Enum10 enum10_0)
	{
		return smethod_23(string_2)?.method_64(enum10_0) ?? 0;
	}

	internal static uint smethod_74(string string_2, Enum10 enum10_0)
	{
		return smethod_23(string_2)?.method_65(enum10_0) ?? 0;
	}

	internal static void smethod_75(string string_2, uint uint_0)
	{
		smethod_23(string_2)?.method_63(uint_0);
	}

	internal static void smethod_76(string string_2, uint uint_0)
	{
		smethod_23(string_2)?.method_66(uint_0);
	}

	internal static void smethod_77(string string_2)
	{
		smethod_23(string_2)?.method_67();
	}

	internal static void smethod_78(string string_2, bool bool_1)
	{
		smethod_23(string_2)?.method_68(bool_1);
	}

	internal static bool smethod_79(string string_2, string string_3, out byte[] byte_2, out bool bool_1)
	{
		Class4 @class = smethod_23(string_2);
		if (@class != null)
		{
			return @class.method_69(string_3, out byte_2, out bool_1);
		}
		bool_1 = false;
		byte_2 = null;
		return false;
	}

	internal static uint smethod_80(string string_2, Enum10 enum10_0)
	{
		return smethod_23(string_2)?.method_70(enum10_0) ?? 0;
	}

	internal static uint smethod_81(string string_2, Enum10 enum10_0)
	{
		return (uint)(((int?)smethod_23(string_2)?.method_71(enum10_0)) ?? (-1));
	}

	internal static uint smethod_82(string string_2)
	{
		return smethod_23(string_2)?.method_74() ?? 0;
	}

	internal static uint smethod_83(string string_2)
	{
		return smethod_23(string_2)?.method_75() ?? 0;
	}

	internal static uint[,] smethod_84(string string_2)
	{
		return smethod_23(string_2)?.method_72();
	}

	internal static uint smethod_85(string string_2)
	{
		return smethod_23(string_2)?.method_73() ?? 0;
	}

	internal static void smethod_86(string string_2)
	{
		if (delegate0_0 != null)
		{
			EventArgs0 e = new EventArgs0
			{
				string_0 = string_2
			};
			delegate0_0(null, e);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_87(Delegate0 delegate0_1)
	{
		Delegate0 @delegate = delegate0_0;
		Delegate0 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_1);
			@delegate = Interlocked.CompareExchange(ref delegate0_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_88(Delegate0 delegate0_1)
	{
		Delegate0 @delegate = delegate0_0;
		Delegate0 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate0 value = (Delegate0)Delegate.Remove(delegate2, delegate0_1);
			@delegate = Interlocked.CompareExchange(ref delegate0_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}
}
