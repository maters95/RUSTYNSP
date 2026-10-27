using System;
using System.Runtime.CompilerServices;
using System.Threading;
using A;
using B;
using C;
using NSP.SettingsFramework;
using NSP.UserInterface;
using c;

namespace a;

internal struct aD
{
	internal int Hp;

	internal Setting HQ;

	internal static readonly aD Hq = new aD(0, null);

	[SpecialName]
	internal bool A()
	{
		return Hp != 0;
	}

	internal aD(int P_0, Setting P_1)
	{
		Hp = P_0;
		HQ = P_1;
	}
}
internal static class ad
{
	[CompilerGenerated]
	private static class A
	{
		public static EventHandler BlE;

		public static EventHandler Ble;

		public static global::A.D BlF;

		public static EventHandler Blf;
	}

	private static aD HR = aD.Hq;

	[CompilerGenerated]
	private static EventHandler<OutputTestStateChangeEventArgs> Hr;

	[CompilerGenerated]
	private static EventHandler HS;

	[CompilerGenerated]
	private static bool Hs = false;

	private static int HT = 0;

	[SpecialName]
	[CompilerGenerated]
	internal static void A(EventHandler<OutputTestStateChangeEventArgs> P_0)
	{
		EventHandler<OutputTestStateChangeEventArgs> val = Hr;
		EventHandler<OutputTestStateChangeEventArgs> val2;
		do
		{
			val2 = val;
			EventHandler<OutputTestStateChangeEventArgs> val3 = (EventHandler<OutputTestStateChangeEventArgs>)(object)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler<OutputTestStateChangeEventArgs>>(ref Hr, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void a(EventHandler<OutputTestStateChangeEventArgs> P_0)
	{
		EventHandler<OutputTestStateChangeEventArgs> val = Hr;
		EventHandler<OutputTestStateChangeEventArgs> val2;
		do
		{
			val2 = val;
			EventHandler<OutputTestStateChangeEventArgs> val3 = (EventHandler<OutputTestStateChangeEventArgs>)(object)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler<OutputTestStateChangeEventArgs>>(ref Hr, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void A(EventHandler P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		EventHandler val = HS;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref HS, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void a(EventHandler P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		EventHandler val = HS;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref HS, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static bool A()
	{
		return Hs;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void A(bool P_0)
	{
		Hs = P_0;
	}

	public static bool A(int P_0, Setting P_1)
	{
		if (HR.Hp == P_0)
		{
			return HR.HQ == P_1;
		}
		return false;
	}

	private static void a()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		if (BM.Qz == null)
		{
			return;
		}
		Setting setting = BM.Qz.A(20064);
		if (setting != null)
		{
			HT = setting.ax();
			object obj = ad.A.BlE;
			if (obj == null)
			{
				EventHandler val = A;
				ad.A.BlE = val;
				obj = (object)val;
			}
			setting.A((EventHandler)obj);
		}
	}

	private static void B()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (BM.Qz == null)
		{
			return;
		}
		Setting setting = BM.Qz.A(20064);
		if (setting != null)
		{
			object obj = ad.A.BlE;
			if (obj == null)
			{
				EventHandler val = A;
				ad.A.BlE = val;
				obj = (object)val;
			}
			setting.a((EventHandler)obj);
		}
		HT = 0;
	}

	public static void b()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		object obj = ad.A.Ble;
		if (obj == null)
		{
			EventHandler val = a;
			ad.A.Ble = val;
			obj = (object)val;
		}
		BM.D((EventHandler)obj);
		object obj2 = ad.A.Ble;
		if (obj2 == null)
		{
			EventHandler val2 = a;
			ad.A.Ble = val2;
			obj2 = (object)val2;
		}
		CZ.A((EventHandler)obj2);
		global::A.A.A((global::A.D)a);
		object obj3 = ad.A.Ble;
		if (obj3 == null)
		{
			EventHandler val3 = a;
			ad.A.Ble = val3;
			obj3 = (object)val3;
		}
		cx.A((EventHandler)obj3);
		object obj4 = ad.A.Ble;
		if (obj4 == null)
		{
			EventHandler val4 = a;
			ad.A.Ble = val4;
			obj4 = (object)val4;
		}
		cX.A((EventHandler)obj4);
	}

	public static void C()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		object obj = ad.A.Ble;
		if (obj == null)
		{
			EventHandler val = a;
			ad.A.Ble = val;
			obj = (object)val;
		}
		BM.d((EventHandler)obj);
		object obj2 = ad.A.Ble;
		if (obj2 == null)
		{
			EventHandler val2 = a;
			ad.A.Ble = val2;
			obj2 = (object)val2;
		}
		CZ.a((EventHandler)obj2);
		global::A.A.a((global::A.D)a);
		object obj3 = ad.A.Ble;
		if (obj3 == null)
		{
			EventHandler val3 = a;
			ad.A.Ble = val3;
			obj3 = (object)val3;
		}
		cx.a((EventHandler)obj3);
		object obj4 = ad.A.Ble;
		if (obj4 == null)
		{
			EventHandler val4 = a;
			ad.A.Ble = val4;
			obj4 = (object)val4;
		}
		cX.a((EventHandler)obj4);
	}

	private static void A(object P_0, EventArgs P_1)
	{
		int num = (P_0 as Setting).ax();
		if (HT == 1 && num == 0)
		{
			d();
		}
		HT = num;
	}

	public static void c()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (BM.Qz == null)
		{
			return;
		}
		Setting setting = BM.Qz.A(384);
		if (setting != null)
		{
			object obj = ad.A.Blf;
			if (obj == null)
			{
				EventHandler val = B;
				ad.A.Blf = val;
				obj = (object)val;
			}
			setting.A((EventHandler)obj);
		}
	}

	public static void D()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (BM.Qz == null)
		{
			return;
		}
		Setting setting = BM.Qz.A(384);
		if (setting != null)
		{
			object obj = ad.A.Blf;
			if (obj == null)
			{
				EventHandler val = B;
				ad.A.Blf = val;
				obj = (object)val;
			}
			setting.a((EventHandler)obj);
		}
	}

	public static void d()
	{
		if (HR.A())
		{
			Hr?.Invoke((object)null, new OutputTestStateChangeEventArgs(null, HR.Hp, state: false));
			HR = aD.Hq;
			B();
			C();
		}
	}

	public static void a(object P_0, EventArgs P_1)
	{
		if (P_0 is cx || P_0 is cX)
		{
			A(HR.HQ, HR.Hp, false);
		}
		d();
	}

	private static void B(object P_0, EventArgs P_1)
	{
		bool flag = (P_0 as Setting).ax() > 0;
		if (flag)
		{
			d();
		}
		if (A() != flag)
		{
			A(flag);
			EventHandler hS = HS;
			if (hS != null)
			{
				hS.Invoke((object)null, EventArgs.Empty);
			}
		}
	}

	public static int E()
	{
		return HR.Hp;
	}

	public static void A(Setting P_0, int P_1, bool P_2)
	{
		if (BM.Qz == null)
		{
			return;
		}
		bool flag = HR.Hp == P_1 && HR.HQ == P_0;
		if (flag == P_2)
		{
			return;
		}
		Setting setting = BM.Qz.A(20064);
		if (setting == null)
		{
			return;
		}
		bool flag2 = setting.ax() == 1;
		bool flag3 = flag2 && !flag;
		if (P_2)
		{
			if (flag3 || HR.HQ == null || HR.HQ == P_0)
			{
				Setting hQ = HR.HQ;
				HR = new aD(P_1, P_0);
				a();
				if (!flag2)
				{
					b();
				}
				if (hQ != null && hQ != P_0)
				{
					hQ.a(0, true);
				}
				P_0.a(HR.Hp, true);
				Hr?.Invoke((object)null, new OutputTestStateChangeEventArgs(P_0, P_1, P_2));
			}
		}
		else
		{
			d();
			P_0?.a(0, true);
		}
	}
}
