using System;
using System.Runtime.CompilerServices;
using System.Threading;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns4;
using ns6;

namespace ns2;

internal static class Class128
{
	[CompilerGenerated]
	private static class Class129
	{
		public static EventHandler BlE;

		public static EventHandler Ble;

		public static Delegate2 BlF;

		public static EventHandler Blf;
	}

	private static Struct16 struct16_0 = Struct16.struct16_0;

	[CompilerGenerated]
	private static EventHandler<OutputTestStateChangeEventArgs> eventHandler_0;

	[CompilerGenerated]
	private static EventHandler eventHandler_1;

	[CompilerGenerated]
	private static bool bool_0 = false;

	private static int int_0 = 0;

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_0(EventHandler<OutputTestStateChangeEventArgs> eventHandler_2)
	{
		EventHandler<OutputTestStateChangeEventArgs> eventHandler = eventHandler_0;
		EventHandler<OutputTestStateChangeEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<OutputTestStateChangeEventArgs> value = (EventHandler<OutputTestStateChangeEventArgs>)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_1(EventHandler<OutputTestStateChangeEventArgs> eventHandler_2)
	{
		EventHandler<OutputTestStateChangeEventArgs> eventHandler = eventHandler_0;
		EventHandler<OutputTestStateChangeEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<OutputTestStateChangeEventArgs> value = (EventHandler<OutputTestStateChangeEventArgs>)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_2(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_3(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static bool smethod_4()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_5(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public static bool smethod_6(int int_1, Setting setting_0)
	{
		if (struct16_0.int_0 == int_1)
		{
			return struct16_0.setting_0 == setting_0;
		}
		return false;
	}

	private static void smethod_7()
	{
		if (Form23.framework_1 != null)
		{
			Setting setting = Form23.framework_1.method_31(20064);
			if (setting != null)
			{
				int_0 = setting.method_256();
				setting.method_264(smethod_11);
			}
		}
	}

	private static void smethod_8()
	{
		if (Form23.framework_1 != null)
		{
			Form23.framework_1.method_31(20064)?.method_265(smethod_11);
			int_0 = 0;
		}
	}

	public static void smethod_9()
	{
		Form23.smethod_30(smethod_15);
		Class320.smethod_44(smethod_15);
		Class1.smethod_12(smethod_15);
		Form8.smethod_3(smethod_15);
		Form7.smethod_3(smethod_15);
	}

	public static void smethod_10()
	{
		Form23.smethod_31(smethod_15);
		Class320.smethod_45(smethod_15);
		Class1.smethod_13(smethod_15);
		Form8.smethod_4(smethod_15);
		Form7.smethod_4(smethod_15);
	}

	private static void smethod_11(object sender, EventArgs e)
	{
		int num = (sender as Setting).method_256();
		if (int_0 == 1 && num == 0)
		{
			smethod_14();
		}
		int_0 = num;
	}

	public static void smethod_12()
	{
		if (Form23.framework_1 != null)
		{
			Form23.framework_1.method_31(384)?.method_264(smethod_16);
		}
	}

	public static void smethod_13()
	{
		if (Form23.framework_1 != null)
		{
			Form23.framework_1.method_31(384)?.method_265(smethod_16);
		}
	}

	public static void smethod_14()
	{
		if (struct16_0.method_0())
		{
			eventHandler_0?.Invoke(null, new OutputTestStateChangeEventArgs(null, struct16_0.int_0, state: false));
			struct16_0 = Struct16.struct16_0;
			smethod_8();
			smethod_10();
		}
	}

	public static void smethod_15(object sender, EventArgs e)
	{
		if (sender is Form8 || sender is Form7)
		{
			smethod_18(struct16_0.setting_0, struct16_0.int_0, bool_1: false);
		}
		smethod_14();
	}

	private static void smethod_16(object sender, EventArgs e)
	{
		bool flag;
		if (flag = (sender as Setting).method_256() > 0)
		{
			smethod_14();
		}
		if (smethod_4() != flag)
		{
			smethod_5(flag);
			eventHandler_1?.Invoke(null, EventArgs.Empty);
		}
	}

	public static int smethod_17()
	{
		return struct16_0.int_0;
	}

	public static void smethod_18(Setting setting_0, int int_1, bool bool_1)
	{
		bool flag;
		if (Form23.framework_1 == null || (flag = struct16_0.int_0 == int_1 && struct16_0.setting_0 == setting_0) == bool_1)
		{
			return;
		}
		Setting setting = Form23.framework_1.method_31(20064);
		if (setting == null)
		{
			return;
		}
		bool flag3;
		bool flag2 = (flag3 = setting.method_256() == 1) && !flag;
		if (bool_1)
		{
			if (flag2 || struct16_0.setting_0 == null || struct16_0.setting_0 == setting_0)
			{
				Setting setting_1 = struct16_0.setting_0;
				struct16_0 = new Struct16(int_1, setting_0);
				smethod_7();
				if (!flag3)
				{
					smethod_9();
				}
				if (setting_1 != null && setting_1 != setting_0)
				{
					setting_1.method_272(0, bool_0: true);
				}
				setting_0.method_272(struct16_0.int_0, bool_0: true);
				eventHandler_0?.Invoke(null, new OutputTestStateChangeEventArgs(setting_0, int_1, bool_1));
			}
		}
		else
		{
			smethod_14();
			setting_0?.method_272(0, bool_0: true);
		}
	}
}
