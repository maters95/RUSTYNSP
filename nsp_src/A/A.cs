using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace A;

internal static class A
{
	private struct A
	{
		public g Bek;

		public Dictionary<string, e> BeL;

		public List<string> Bel;

		public List<string> BeM;

		public A(g P_0)
		{
			Bek = P_0;
			BeL = new Dictionary<string, e>();
			Bel = new List<string>();
			BeM = new List<string>();
		}
	}

	internal enum a : byte
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

	internal enum B
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

	internal enum b : byte
	{
		BFb = 255,
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

	internal enum C : byte
	{
		BFH = 0,
		BFh = 1,
		BFI = 255
	}

	[CompilerGenerated]
	private static class c
	{
		public static EventHandler BFi;

		public static EventHandler BFJ;

		public static EventHandler BFj;

		public static EventHandler BFK;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class D
	{
		public static readonly D BFk = new D();

		public static ThreadStart BFL;

		internal void A()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			global::A.A.A(global::A.A.m_i.Token);
		}
	}

	private static List<A> m_G;

	private static e m_g;

	private static bool m_H;

	private static Thread m_h;

	private static Stopwatch m_I;

	private static CancellationTokenSource m_i;

	private static string m_J;

	private const string m_j = "PlaceholderForDetection";

	[CompilerGenerated]
	private static EventHandler m_K;

	[CompilerGenerated]
	private static global::A.D m_k;

	internal static byte L;

	internal static byte l;

	[CompilerGenerated]
	private static global::A.C M;

	internal const int m = 3;

	internal const int N = 2;

	internal static global::A.b n;

	[CompilerGenerated]
	private static global::A.a O;

	static A()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		global::A.A.m_G = new List<A>();
		global::A.A.m_g = null;
		global::A.A.m_H = false;
		global::A.A.m_h = null;
		global::A.A.m_I = new Stopwatch();
		global::A.A.m_i = null;
		global::A.A.m_J = null;
		L = 0;
		l = 0;
		n = global::A.b.Q;
		global::A.A.m_G.Add(new A(global::A.g.BI));
		global::A.A.m_G.Add(new A(global::A.g.Bj));
		global::A.A.m_G.Add(new A(global::A.g.BJ));
		global::A.A.m_G.Add(new A(global::A.g.Bi));
	}

	internal static bool A()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		global::A.A.m_H = false;
		global::A.A.m_g = null;
		try
		{
			if (global::A.A.m_h == null || !global::A.A.m_h.IsAlive)
			{
				try
				{
					if (global::A.A.m_i != null)
					{
						global::A.A.m_i.Dispose();
					}
				}
				catch
				{
				}
				global::A.A.m_i = new CancellationTokenSource();
				object obj2 = global::A.A.D.BFL;
				if (obj2 == null)
				{
					ThreadStart val = delegate
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						A(global::A.A.m_i.Token);
					};
					global::A.A.D.BFL = val;
					obj2 = (object)val;
				}
				global::A.A.m_h = new Thread((ThreadStart)obj2);
				global::A.A.m_h.Start();
			}
			global::A.A.m_I.Restart();
			return true;
		}
		catch
		{
			return false;
		}
	}

	internal static bool A(g P_0)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		global::A.A.m_H = true;
		e e2 = new e(P_0);
		if (e2.A(new List<string>()))
		{
			k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.A() + ((object)P_0).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.a());
			global::A.A.m_g = e2;
			e obj = global::A.A.m_g;
			object obj2 = global::A.A.c.BFi;
			if (obj2 == null)
			{
				EventHandler val = A;
				global::A.A.c.BFi = val;
				obj2 = (object)val;
			}
			obj.A((EventHandler)obj2);
			e obj3 = global::A.A.m_g;
			object obj4 = global::A.A.c.BFJ;
			if (obj4 == null)
			{
				EventHandler val2 = a;
				global::A.A.c.BFJ = val2;
				obj4 = (object)val2;
			}
			obj3.B((EventHandler)obj4);
			e obj5 = global::A.A.m_g;
			object obj6 = global::A.A.c.BFj;
			if (obj6 == null)
			{
				EventHandler val3 = B;
				global::A.A.c.BFj = val3;
				obj6 = (object)val3;
			}
			obj5.C((EventHandler)obj6);
			e obj7 = global::A.A.m_g;
			object obj8 = global::A.A.c.BFK;
			if (obj8 == null)
			{
				EventHandler val4 = b;
				global::A.A.c.BFK = val4;
				obj8 = (object)val4;
			}
			obj7.D((EventHandler)obj8);
			List<e> obj9 = new List<e>();
			obj9.Add(global::A.A.m_g);
			A(obj9);
			return true;
		}
		global::A.A.m_g = null;
		return false;
	}

	internal static void a()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		if (global::A.A.m_H)
		{
			if (global::A.A.m_g != null)
			{
				A(global::A.A.m_g, EventArgs.Empty);
				global::A.A.m_g = null;
			}
			global::A.A.m_H = false;
			return;
		}
		global::A.A.m_I.Reset();
		try
		{
			if (global::A.A.m_h != null && global::A.A.m_i != null)
			{
				global::A.A.m_i.Cancel();
				global::A.A.m_h = null;
			}
		}
		catch
		{
		}
		Enumerator<A> enumerator = global::A.A.m_G.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				try
				{
					if (current.BeL.Count == 0)
					{
						continue;
					}
					List<string> val = new List<string>(current.BeL.Count);
					Enumerator<string, e> enumerator2 = current.BeL.Keys.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							string current2 = enumerator2.Current;
							val.Add(current2);
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
					Enumerator<string> enumerator3 = val.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							string current3 = enumerator3.Current;
							e e2 = current.BeL[current3];
							if (e2 != null)
							{
								if (current3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.B())
								{
									current.BeL.Remove(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.B());
									e2.Dispose();
								}
								else
								{
									A(e2, EventArgs.Empty);
								}
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator3).Dispose();
					}
				}
				catch
				{
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static bool B()
	{
		if (global::A.A.m_h != null)
		{
			return global::A.A.m_h.IsAlive;
		}
		return false;
	}

	private static void A(CancellationToken P_0)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.b();
		while (!((CancellationToken)(ref P_0)).IsCancellationRequested)
		{
			bool flag = false;
			List<e> val = new List<e>();
			Enumerator<A> enumerator = global::A.A.m_G.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					A current = enumerator.Current;
					if (((CancellationToken)(ref P_0)).IsCancellationRequested)
					{
						break;
					}
					A(current, val);
					if (((CancellationToken)(ref P_0)).IsCancellationRequested)
					{
						break;
					}
					A(current.Bek, current.BeL);
					if (current.BeM.Count != 0)
					{
						flag = true;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (((CancellationToken)(ref P_0)).IsCancellationRequested)
			{
				break;
			}
			if (val.Count != 0)
			{
				A(val);
			}
			if (((CancellationToken)(ref P_0)).IsCancellationRequested)
			{
				break;
			}
			if (global::A.A.m_I.ElapsedMilliseconds < 4000 && !flag)
			{
				Thread.Sleep(100);
				continue;
			}
			if (string.IsNullOrEmpty(global::A.A.m_J))
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
			if (!((CancellationToken)(ref P_0)).IsCancellationRequested)
			{
				C();
				continue;
			}
			break;
		}
	}

	internal static void A(string P_0)
	{
		global::A.A.m_J = P_0;
	}

	internal static void b()
	{
		global::A.A.m_J = null;
	}

	private static void A(A P_0, List<e> P_1)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		while (true)
		{
			g bek = P_0.Bek;
			e e2;
			if (P_0.BeL.Count == 0)
			{
				e2 = new e(bek);
				P_0.BeL.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.B(), e2);
			}
			else
			{
				e2 = P_0.BeL[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.B()];
			}
			int num = 0;
			Enumerator<string> enumerator = P_0.Bel.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!P_0.BeM.Contains(current))
					{
						num++;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			bool flag = e2.A(P_0.Bel);
			int num2 = 0;
			enumerator = P_0.Bel.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current2 = enumerator.Current;
					if (!P_0.BeM.Contains(current2))
					{
						num2++;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (num2 == num)
			{
				P_0.Bel.Clear();
				enumerator = P_0.BeM.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current3 = enumerator.Current;
						P_0.Bel.Add(current3);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (!flag)
			{
				break;
			}
			string ao = e2.C().ao;
			k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.C() + ((object)bek).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.c() + ao);
			if (string.IsNullOrEmpty(global::A.A.m_J) || ao == global::A.A.m_J)
			{
				P_0.BeM.Add(e2.b());
				if (!P_0.BeL.ContainsKey(ao))
				{
					P_0.BeL.Add(ao, e2);
					P_0.BeL[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.B()] = new e(bek);
					e obj = e2;
					object obj2 = global::A.A.c.BFi;
					if (obj2 == null)
					{
						EventHandler val = A;
						global::A.A.c.BFi = val;
						obj2 = (object)val;
					}
					obj.A((EventHandler)obj2);
					e obj3 = e2;
					object obj4 = global::A.A.c.BFJ;
					if (obj4 == null)
					{
						EventHandler val2 = a;
						global::A.A.c.BFJ = val2;
						obj4 = (object)val2;
					}
					obj3.B((EventHandler)obj4);
					e obj5 = e2;
					object obj6 = global::A.A.c.BFj;
					if (obj6 == null)
					{
						EventHandler val3 = B;
						global::A.A.c.BFj = val3;
						obj6 = (object)val3;
					}
					obj5.C((EventHandler)obj6);
					e obj7 = e2;
					object obj8 = global::A.A.c.BFK;
					if (obj8 == null)
					{
						EventHandler val4 = b;
						global::A.A.c.BFK = val4;
						obj8 = (object)val4;
					}
					obj7.D((EventHandler)obj8);
					P_1.Add(e2);
					if (!string.IsNullOrEmpty(global::A.A.m_J) && ao == global::A.A.m_J)
					{
						break;
					}
				}
			}
			Thread.Sleep(0);
		}
	}

	private static void A(g P_0, Dictionary<string, e> P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Enumerator<string, e> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, e> current = enumerator.Current;
					if (current.Key != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.B())
					{
						e value = current.Value;
						if (!value.D())
						{
							value.g();
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		catch
		{
		}
	}

	private static void A(List<e> P_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		List<F> val = new List<F>(P_0.Count);
		Enumerator<e> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				e current = enumerator.Current;
				val.Add(current.C());
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (global::A.A.m_K != null)
		{
			global::A.A.m_K.Invoke((object)val, EventArgs.Empty);
		}
		if (global::A.A.m_H)
		{
			return;
		}
		enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				e current2 = enumerator.Current;
				g g2 = current2.B();
				Enumerator<A> enumerator2 = global::A.A.m_G.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						A current3 = enumerator2.Current;
						if (current3.Bek == g2)
						{
							continue;
						}
						try
						{
							Enumerator<string, e> enumerator3 = current3.BeL.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									KeyValuePair<string, e> current4 = enumerator3.Current;
									if (current4.Key != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.B())
									{
										e value = current4.Value;
										if (current4.Key == current2.C().ao && !value.D())
										{
											A(value, EventArgs.Empty);
										}
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator3).Dispose();
							}
						}
						catch
						{
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void A(EventHandler P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		EventHandler val = global::A.A.m_K;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref global::A.A.m_K, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void a(EventHandler P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		EventHandler val = global::A.A.m_K;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref global::A.A.m_K, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void A(global::A.D P_0)
	{
		global::A.D d2 = global::A.A.m_k;
		global::A.D d3;
		do
		{
			d3 = d2;
			global::A.D d4 = (global::A.D)System.Delegate.Combine((System.Delegate)d3, (System.Delegate)P_0);
			d2 = Interlocked.CompareExchange<global::A.D>(ref global::A.A.m_k, d4, d3);
		}
		while (d2 != d3);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void a(global::A.D P_0)
	{
		global::A.D d2 = global::A.A.m_k;
		global::A.D d3;
		do
		{
			d3 = d2;
			global::A.D d4 = (global::A.D)System.Delegate.Remove((System.Delegate)d3, (System.Delegate)P_0);
			d2 = Interlocked.CompareExchange<global::A.D>(ref global::A.A.m_k, d4, d3);
		}
		while (d2 != d3);
	}

	private static void A(object P_0, EventArgs P_1)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		e e2 = P_0 as e;
		if (!global::A.A.m_H)
		{
			g g2 = e2.B();
			Enumerator<A> enumerator = global::A.A.m_G.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					A current = enumerator.Current;
					if (current.Bek == g2)
					{
						if (current.BeL.ContainsKey(e2.C().ao))
						{
							current.BeL.Remove(e2.C().ao);
						}
						if (current.Bel.Contains(e2.b()))
						{
							current.Bel.Remove(e2.b());
						}
						if (current.BeM.Contains(e2.b()))
						{
							current.BeM.Remove(e2.b());
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		if (global::A.A.m_k != null)
		{
			E e3 = new E();
			e3.t = global::A.d.T;
			k(string.Concat(new string[5]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.D(),
				((object)e3.t).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.d(),
				e2.C().ao,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
			}));
			global::A.A.m_k(e2.C().ao, e3);
		}
		object obj = global::A.A.c.BFi;
		if (obj == null)
		{
			EventHandler val = A;
			global::A.A.c.BFi = val;
			obj = (object)val;
		}
		e2.a((EventHandler)obj);
		object obj2 = global::A.A.c.BFJ;
		if (obj2 == null)
		{
			EventHandler val2 = a;
			global::A.A.c.BFJ = val2;
			obj2 = (object)val2;
		}
		e2.b((EventHandler)obj2);
		object obj3 = global::A.A.c.BFj;
		if (obj3 == null)
		{
			EventHandler val3 = B;
			global::A.A.c.BFj = val3;
			obj3 = (object)val3;
		}
		e2.c((EventHandler)obj3);
		object obj4 = global::A.A.c.BFK;
		if (obj4 == null)
		{
			EventHandler val4 = b;
			global::A.A.c.BFK = val4;
			obj4 = (object)val4;
		}
		e2.d((EventHandler)obj4);
		e2.Dispose();
		if (global::A.A.m_H)
		{
			global::A.A.m_g = null;
		}
	}

	private static void a(object P_0, EventArgs P_1)
	{
		e e2 = P_0 as e;
		if (global::A.A.m_k != null)
		{
			E e3 = new E();
			e3.t = global::A.d.s;
			k(string.Concat(new string[5]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.D(),
				((object)e3.t).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.d(),
				e2.C().ao,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
			}));
			global::A.A.m_k(e2.C().ao, e3);
		}
	}

	private static void B(object P_0, EventArgs P_1)
	{
		e e2 = P_0 as e;
		if (global::A.A.m_k != null)
		{
			E e3 = new E();
			e3.t = global::A.d.S;
			k(string.Concat(new string[5]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.D(),
				((object)e3.t).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.d(),
				e2.C().ao,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
			}));
			global::A.A.m_k(e2.C().ao, e3);
		}
	}

	internal static void a(string P_0)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			A(e2, EventArgs.Empty);
		}
	}

	internal static void C()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (global::A.A.m_H)
		{
			return;
		}
		Enumerator<F> enumerator = c().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				F current = enumerator.Current;
				e e2 = D(current.ao);
				if (e2 == null || e2.A().c())
				{
					continue;
				}
				if (!(e2.w == new System.DateTime(0L)))
				{
					TimeSpan val = System.DateTime.Now - e2.w;
					if (!(((TimeSpan)(ref val)).TotalMilliseconds > 3000.0))
					{
						continue;
					}
				}
				k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.e() + ((object)e2.B()).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.F() + current.ao);
				if (e2.e())
				{
					k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.f() + ((object)e2.B()).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.F() + current.ao);
					e2.a();
				}
				else
				{
					A(e2, EventArgs.Empty);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static void B(string P_0)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			e2.w = System.DateTime.Now;
		}
	}

	internal static bool b(string P_0)
	{
		return D(P_0)?.D() ?? false;
	}

	internal static bool C(string P_0)
	{
		return D(P_0)?.d() ?? false;
	}

	internal static void c(string P_0)
	{
		D(P_0)?.E();
	}

	private static e D(string P_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		if (global::A.A.m_H)
		{
			return global::A.A.m_g;
		}
		Enumerator<A> enumerator = global::A.A.m_G.GetEnumerator();
		try
		{
			e result = default(e);
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.BeL.TryGetValue(P_0, ref result))
				{
					return result;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return null;
	}

	private static e d(string P_0)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			if (!e2.D())
			{
				return null;
			}
			return e2;
		}
		return null;
	}

	internal static g E(string P_0)
	{
		return D(P_0)?.B() ?? global::A.g.BK;
	}

	internal static F e(string P_0)
	{
		return D(P_0)?.C();
	}

	internal static List<F> c()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<F> val = new List<F>();
		try
		{
			if (global::A.A.m_H)
			{
				if (global::A.A.m_g != null)
				{
					val.Add(global::A.A.m_g.C());
				}
			}
			else
			{
				List<string> val2 = new List<string>();
				Enumerator<A> enumerator = global::A.A.m_G.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Enumerator<string, e> enumerator2 = enumerator.Current.BeL.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								KeyValuePair<string, e> current = enumerator2.Current;
								if (current.Key != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.B())
								{
									e value = current.Value;
									if (value != null && !val2.Contains(current.Key))
									{
										val2.Add(current.Key);
										val.Add(value.C());
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}
		catch
		{
		}
		return val;
	}

	internal static F F(string P_0)
	{
		return D(P_0)?.c();
	}

	internal static void A(byte P_0)
	{
		L = P_0;
	}

	internal static void D()
	{
		L = 0;
	}

	internal static void a(byte P_0)
	{
		l = P_0;
	}

	internal static void d()
	{
		l = 0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void A(global::A.C P_0)
	{
		global::A.C c2 = M;
		global::A.C c3;
		do
		{
			c3 = c2;
			global::A.C c4 = (global::A.C)System.Delegate.Combine((System.Delegate)c3, (System.Delegate)P_0);
			c2 = Interlocked.CompareExchange<global::A.C>(ref M, c4, c3);
		}
		while (c2 != c3);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void a(global::A.C P_0)
	{
		global::A.C c2 = M;
		global::A.C c3;
		do
		{
			c3 = c2;
			global::A.C c4 = (global::A.C)System.Delegate.Remove((System.Delegate)c3, (System.Delegate)P_0);
			c2 = Interlocked.CompareExchange<global::A.C>(ref M, c4, c3);
		}
		while (c2 != c3);
	}

	private static void b(object P_0, EventArgs P_1)
	{
		if (P_0 is e && P_1 is global::A.c)
		{
			e e2 = P_0 as e;
			global::A.c c2 = P_1 as global::A.c;
			if (M != null)
			{
				M(e2.C().ao, c2);
			}
		}
	}

	internal static bool A(string P_0, byte P_1, f P_2, uint P_3, uint P_4, out byte[] P_5, out bool P_6)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			if (!e2.D())
			{
				if (P_2 != 0)
				{
					e2.w = System.DateTime.Now;
				}
				P_6 = false;
				P_5 = null;
				return false;
			}
			return e2.A(P_1, 3, P_2, P_3, P_4, out P_5, out P_6);
		}
		P_6 = false;
		P_5 = null;
		return false;
	}

	internal static bool A(string P_0, f P_1, uint P_2, uint P_3, out byte[] P_4, out bool P_5)
	{
		return A(P_0, 0, P_1, P_2, P_3, out P_4, out P_5);
	}

	internal static bool A(string P_0, byte P_1, f P_2, uint P_3, byte[] P_4, out bool P_5)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			if (!e2.D())
			{
				e2.w = System.DateTime.Now;
				P_5 = false;
				return false;
			}
			return e2.A(P_1, 2, P_2, P_3, P_4, out P_5);
		}
		P_5 = false;
		return false;
	}

	internal static bool A(string P_0, f P_1, uint P_2, byte[] P_3, out bool P_4)
	{
		return A(P_0, 0, P_1, P_2, P_3, out P_4);
	}

	internal static bool A(string P_0, byte P_1, f P_2, uint P_3, byte[] P_4, uint P_5, out byte[] P_6, out bool P_7)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			if (!e2.D())
			{
				e2.w = System.DateTime.Now;
				P_7 = false;
				P_6 = null;
				return false;
			}
			return e2.A(P_1, 2, P_2, P_3, P_4, P_5, out P_6, out P_7);
		}
		P_7 = false;
		P_6 = null;
		return false;
	}

	internal static bool A(string P_0, f P_1, uint P_2, byte[] P_3, uint P_4, out byte[] P_5, out bool P_6)
	{
		return A(P_0, 0, P_1, P_2, P_3, P_4, out P_5, out P_6);
	}

	internal static bool a(string P_0, f P_1, uint P_2, byte[] P_3, out bool P_4)
	{
		P_4 = false;
		e e2 = D(P_0);
		if (e2 != null)
		{
			if (!e2.D())
			{
				e2.w = System.DateTime.Now;
				P_4 = false;
				return false;
			}
			return e2.A(0, P_1, P_2, P_3);
		}
		P_4 = false;
		return false;
	}

	internal static bool A(string P_0, out bool P_1)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			return e2.A(out P_1);
		}
		P_1 = false;
		return false;
	}

	internal static void f(string P_0)
	{
		d(P_0)?.A((byte)0);
	}

	internal static void G(string P_0)
	{
		d(P_0)?.a((byte)0);
	}

	internal static void g(string P_0)
	{
		d(P_0)?.B((byte)0);
	}

	internal static bool A(string P_0, byte[] P_1)
	{
		return d(P_0)?.A(0, P_1) ?? false;
	}

	internal static bool A(string P_0, byte P_1, byte P_2, out bool P_3)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(P_1, P_2, out P_3);
		}
		P_3 = false;
		return false;
	}

	internal static bool A(string P_0, byte P_1, out byte[] P_2, out bool P_3)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(P_1, out P_2, out P_3);
		}
		P_2 = new byte[1];
		P_3 = false;
		P_2[0] = 255;
		return false;
	}

	internal static string A(b P_0)
	{
		return P_0 switch
		{
			global::A.A.b.BFb => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.G(), 
			global::A.A.b.BFC => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g(), 
			global::A.A.b.BFc => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.H(), 
			global::A.A.b.BFD => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.h(), 
			global::A.A.b.BFd => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.I(), 
			global::A.A.b.BFE => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.i(), 
			global::A.A.b.BFe => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.J(), 
			global::A.A.b.BFF => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.j(), 
			global::A.A.b.BFf => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.K(), 
			global::A.A.b.BFG => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.k(), 
			global::A.A.b.BFg => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.L(), 
			_ => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.l(), 
		};
	}

	internal static bool A(string P_0, C P_1, out b P_2, out ushort P_3, out bool P_4)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(0, P_1, out P_2, out P_3, out P_4);
		}
		P_4 = false;
		P_2 = global::A.A.b.BFb;
		P_3 = 0;
		return false;
	}

	internal static bool A(string P_0, C P_1, ushort P_2, ushort P_3, out b P_4, out j[] P_5, out bool P_6)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(0, P_1, P_2, P_3, out P_4, out P_5, out P_6);
		}
		P_6 = false;
		P_4 = global::A.A.b.BFb;
		P_5 = null;
		return false;
	}

	internal static bool A(string P_0, j P_1, uint P_2, uint P_3, out b P_4, out byte[] P_5, out bool P_6)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(0, P_1, P_2, P_3, out P_4, out P_5, out P_6);
		}
		P_6 = false;
		P_4 = global::A.A.b.BFb;
		P_5 = null;
		return false;
	}

	internal static bool A(string P_0, j P_1, uint P_2, byte[] P_3, out b P_4, out bool P_5)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(0, P_1, P_2, P_3, out P_4, out P_5);
		}
		P_5 = false;
		P_4 = global::A.A.b.BFb;
		return false;
	}

	internal static bool A(string P_0, j P_1, j P_2, out b P_3, out bool P_4)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(0, P_1, P_2, out P_3, out P_4);
		}
		P_4 = false;
		P_3 = global::A.A.b.BFb;
		return false;
	}

	internal static bool A(string P_0, j P_1, out b P_2, out bool P_3)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(0, P_1, out P_2, out P_3);
		}
		P_3 = false;
		P_2 = global::A.A.b.BFb;
		return false;
	}

	internal static bool a(string P_0, out bool P_1)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(0, out P_1);
		}
		P_1 = false;
		return false;
	}

	internal static bool B(string P_0, out bool P_1)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.a(0, out P_1);
		}
		P_1 = false;
		return false;
	}

	internal static bool b(string P_0, out bool P_1)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.B(0, out P_1);
		}
		P_1 = false;
		return false;
	}

	internal static bool C(string P_0, out bool P_1)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.b(0, out P_1);
		}
		P_1 = false;
		return false;
	}

	internal static bool A(string P_0, string P_1, string P_2, out bool P_3)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			bool flag = false;
			if (e2.C().aH == 21)
			{
				e2.a(5000u);
				flag = e2.A(0, P_1, P_2, out P_3);
				e2.I();
			}
			else
			{
				flag = e2.A(0, P_1, P_2, out P_3);
			}
			return flag;
		}
		P_3 = false;
		return false;
	}

	internal static bool c(string P_0, out bool P_1)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.C(0, out P_1);
		}
		P_1 = false;
		return false;
	}

	internal static bool D(string P_0, out bool P_1)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.c(0, out P_1);
		}
		P_1 = false;
		return false;
	}

	internal static bool A(string P_0, byte P_1, byte P_2, uint P_3, int P_4, byte[] P_5, out bool P_6)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.A(P_1, P_2, P_3, P_4, P_5, out P_6);
		}
		P_6 = false;
		return false;
	}

	internal static bool A(string P_0, byte P_1, uint P_2, int P_3, byte[] P_4, out bool P_5)
	{
		return A(P_0, 0, P_1, P_2, P_3, P_4, out P_5);
	}

	internal static bool d(string P_0, out bool P_1)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.D(0, out P_1);
		}
		P_1 = false;
		return false;
	}

	internal static bool E(string P_0, out bool P_1)
	{
		e e2 = d(P_0);
		if (e2 != null)
		{
			return e2.d(0, out P_1);
		}
		P_1 = false;
		return false;
	}

	internal static bool A(string P_0, List<uint> P_1, List<byte[]> P_2, List<uint> P_3)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			return e2.A(P_1, P_2, P_3);
		}
		k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.M());
		return false;
	}

	internal static bool A(string P_0, byte P_1, uint P_2, uint P_3, uint P_4, byte P_5, byte P_6, byte P_7, byte P_8, out int P_9)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			return e2.A(P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, out P_9);
		}
		k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.m());
		P_9 = 65535;
		return false;
	}

	internal static bool H(string P_0)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			return e2.H();
		}
		k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.N());
		return false;
	}

	internal static bool h(string P_0)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			return e2.h();
		}
		k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.n());
		return false;
	}

	internal static bool A(string P_0, byte P_1, byte P_2, byte P_3, byte P_4, byte P_5, byte P_6)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			return e2.A(P_1, P_2, P_3, P_4, P_5, P_6);
		}
		k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.O());
		return false;
	}

	internal static uint A(string P_0, f P_1)
	{
		return D(P_0)?.A(P_1) ?? 0;
	}

	internal static uint a(string P_0, f P_1)
	{
		return D(P_0)?.a(P_1) ?? 0;
	}

	internal static void A(string P_0, uint P_1)
	{
		D(P_0)?.A(P_1);
	}

	internal static void a(string P_0, uint P_1)
	{
		D(P_0)?.a(P_1);
	}

	internal static void I(string P_0)
	{
		D(P_0)?.I();
	}

	internal static void A(string P_0, bool P_1)
	{
		D(P_0)?.a(P_1);
	}

	internal static bool A(string P_0, string P_1, out byte[] P_2, out bool P_3)
	{
		e e2 = D(P_0);
		if (e2 != null)
		{
			return e2.A(P_1, out P_2, out P_3);
		}
		P_3 = false;
		P_2 = null;
		return false;
	}

	internal static uint B(string P_0, f P_1)
	{
		return D(P_0)?.B(P_1) ?? 0;
	}

	internal static uint b(string P_0, f P_1)
	{
		return (uint)(((int?)D(P_0)?.b(P_1)) ?? (-1));
	}

	internal static uint i(string P_0)
	{
		return D(P_0)?.j() ?? 0;
	}

	internal static uint J(string P_0)
	{
		return D(P_0)?.K() ?? 0;
	}

	internal static uint[,] j(string P_0)
	{
		return D(P_0)?.i();
	}

	internal static uint K(string P_0)
	{
		return D(P_0)?.J() ?? 0;
	}

	internal static void k(string P_0)
	{
		if (O != null)
		{
			global::A.B b2 = new global::A.B
			{
				o = P_0
			};
			O(null, b2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void A(global::A.a P_0)
	{
		global::A.a a2 = O;
		global::A.a a3;
		do
		{
			a3 = a2;
			global::A.a a4 = (global::A.a)System.Delegate.Combine((System.Delegate)a3, (System.Delegate)P_0);
			a2 = Interlocked.CompareExchange<global::A.a>(ref O, a4, a3);
		}
		while (a2 != a3);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void a(global::A.a P_0)
	{
		global::A.a a2 = O;
		global::A.a a3;
		do
		{
			a3 = a2;
			global::A.a a4 = (global::A.a)System.Delegate.Remove((System.Delegate)a3, (System.Delegate)P_0);
			a2 = Interlocked.CompareExchange<global::A.a>(ref O, a4, a3);
		}
		while (a2 != a3);
	}
}
internal delegate void a(object P_0, B P_1);
