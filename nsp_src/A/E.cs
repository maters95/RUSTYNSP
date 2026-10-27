using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using c;
using crc;

namespace A;

internal class E : EventArgs
{
	public d t;
}
internal class e : System.IDisposable
{
	private enum A : byte
	{
		BFl = 1,
		BFM = 2,
		BFm = 0x80
	}

	private enum a : byte
	{
		BFN,
		BFn,
		BFO,
		BFo,
		BFP,
		BFp,
		BFQ
	}

	private F U = new F();

	private J u;

	[CompilerGenerated]
	private readonly i V;

	private Dictionary<f, uint> v = new Dictionary<f, uint>();

	private Dictionary<f, uint> W = new Dictionary<f, uint>();

	internal System.DateTime w = new System.DateTime(0L);

	[CompilerGenerated]
	private EventHandler X;

	[CompilerGenerated]
	private EventHandler x;

	[CompilerGenerated]
	private EventHandler Y;

	private int y;

	private int Z;

	private Stopwatch z = new Stopwatch();

	private bool aA;

	private BackgroundWorker aa;

	[CompilerGenerated]
	private EventHandler aB;

	private const uint ab = 12u;

	private const uint aC = 4u;

	private const uint ac = 4294967295u;

	private byte aD;

	private byte[] ad;

	private uint aE;

	[SpecialName]
	[CompilerGenerated]
	internal i A()
	{
		return V;
	}

	internal e(g P_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		switch (P_0)
		{
		case global::A.g.BI:
			V = new cF();
			break;
		case global::A.g.Bi:
			V = new cG();
			break;
		case global::A.g.BJ:
			V = new ce();
			break;
		case global::A.g.Bj:
			V = new cf();
			break;
		default:
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.o());
		}
		if (A() is cF)
		{
			u = new J(A() as cF);
		}
		A().A(new EventHandler(A));
		A().B(new EventHandler(a));
		A().C(new EventHandler(B));
		foreach (f value in System.Enum.GetValues(typeof(f)))
		{
			v.Add(value, 0u);
			W.Add(value, 4294967295u);
		}
	}

	public void Dispose()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		if (aa != null)
		{
			aa.CancelAsync();
		}
		A().a(new EventHandler(A));
		A().b(new EventHandler(a));
		A().c(new EventHandler(B));
		((System.IDisposable)A()).Dispose();
	}

	public bool a()
	{
		bool flag = false;
		try
		{
			Monitor.TryEnter((object)U, ref flag);
			if (!flag)
			{
				return false;
			}
			return A().B();
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit((object)U);
			}
		}
	}

	public virtual string ToString()
	{
		return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.P() + ((object)U).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.p() + ((object)A()).ToString();
	}

	internal g B()
	{
		if (A() is cF)
		{
			return global::A.g.BI;
		}
		if (A() is cG)
		{
			return global::A.g.Bi;
		}
		if (A() is ce)
		{
			return global::A.g.BJ;
		}
		if (A() is cf)
		{
			return global::A.g.Bj;
		}
		return global::A.g.BK;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = X;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref X, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = X;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref X, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void B(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = x;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref x, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void b(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = x;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref x, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void C(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = Y;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref Y, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void c(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = Y;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref Y, val3, val2);
		}
		while (val != val2);
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (X != null)
		{
			X.Invoke((object)this, EventArgs.Empty);
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		if (x != null)
		{
			x.Invoke((object)this, EventArgs.Empty);
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (Y != null)
		{
			Y.Invoke((object)this, EventArgs.Empty);
		}
	}

	[SpecialName]
	internal string b()
	{
		return A().b();
	}

	[SpecialName]
	internal F C()
	{
		return U;
	}

	internal bool A(List<string> P_0)
	{
		string text = ((object)B()).ToString();
		global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
		if (A().A(P_0))
		{
			P_0.Add(b());
			global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.R());
			if (e())
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.S());
				if (A().A(U))
				{
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.T());
					if (e() && G())
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.U());
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.u());
						A().G();
						y = 10;
						Z = 0;
						return true;
					}
					((System.IDisposable)A()).Dispose();
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.V());
					return false;
				}
				((System.IDisposable)A()).Dispose();
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.t());
				return false;
			}
			A().A();
			((System.IDisposable)A()).Dispose();
			global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.s());
			return false;
		}
		global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.q() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.r());
		return false;
	}

	internal F c()
	{
		string text = ((object)B()).ToString();
		global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.v() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
		if (A().a())
		{
			global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.W() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.w());
			if (e())
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.W() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.S());
				if (A().A(U))
				{
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.W() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.T());
					if (e() && G())
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.W() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.U());
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.W() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.u());
						return U;
					}
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.W() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.y());
					return null;
				}
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.W() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Y());
				return null;
			}
			global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.W() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.x());
			return null;
		}
		global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.W() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.X());
		return null;
	}

	internal bool D()
	{
		return A().F();
	}

	internal bool d()
	{
		return A().f();
	}

	internal void E()
	{
		y = 0;
		Z = 0;
		A().g();
	}

	internal bool e()
	{
		if (U.aS)
		{
			if (f())
			{
				return true;
			}
			if (F())
			{
				return true;
			}
		}
		else
		{
			if (F())
			{
				return true;
			}
			if (f())
			{
				return true;
			}
		}
		return false;
	}

	private bool F()
	{
		string text = ((object)B()).ToString();
		int num = 2;
		do
		{
			if (A(0, 1, global::A.f.au, 0u, 1024u, out var array, out var _))
			{
				U.aS = false;
				U.A(array);
				if (U.aT[(uint)B()].BL != 0)
				{
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Z() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.u());
					return true;
				}
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Z() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.z());
				return false;
			}
			num--;
			global::A.A.k(string.Concat(new string[5]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Z(),
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aA(),
				num.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aa()
			}));
		}
		while (num > 0);
		return false;
	}

	private bool f()
	{
		if (u != null)
		{
			int num = 2;
			do
			{
				if (u.A(out var array))
				{
					U.aS = true;
					U.A(array);
					if (U.aT[(uint)B()].BL != 0)
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aB());
						return true;
					}
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ab());
					return false;
				}
				num--;
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aC() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aa());
			}
			while (num > 0);
		}
		return false;
	}

	private bool G()
	{
		U.a(null);
		return true;
	}

	private void A(bool P_0)
	{
		A().a(!P_0);
		if (P_0)
		{
			Z++;
		}
		if (!z.IsRunning)
		{
			z.Start();
		}
		if (z.ElapsedMilliseconds >= 1000)
		{
			A().A(y, Z);
			y = 0;
			Z = 0;
			z.Restart();
		}
	}

	internal void g()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		if (!aA)
		{
			aA = true;
			aa = new BackgroundWorker();
			aa.WorkerReportsProgress = false;
			aa.WorkerSupportsCancellation = true;
			aa.DoWork += new DoWorkEventHandler(A);
			aa.RunWorkerAsync();
		}
	}

	private void A(object P_0, DoWorkEventArgs P_1)
	{
		bool flag = false;
		string ao = U.ao;
		while (!aa.CancellationPending && !A().F())
		{
			bool flag2 = e();
			if (!flag2)
			{
				flag2 = c() != null;
			}
			if (flag2)
			{
				flag = !string.IsNullOrEmpty(U.ao) && !string.IsNullOrEmpty(ao) && U.ao != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ac() && U.ao != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aD() && ao != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ac() && ao != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aD() && U.ao != ao;
				if (flag)
				{
					U.ao = ao;
					break;
				}
			}
			Thread.Sleep(50);
		}
		aA = false;
		if (flag)
		{
			A(null, EventArgs.Empty);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void D(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = aB;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref aB, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void d(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = aB;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref aB, val3, val2);
		}
		while (val != val2);
	}

	private bool A(byte P_0, f P_1, uint P_2, uint P_3, out byte[] P_4)
	{
		uint num = ((P_1 != 0) ? C().@as[(uint)P_1].Be : 0) + P_2;
		uint num2 = 16u;
		P_4 = new byte[num2];
		P_4[0] = 2;
		P_4[1] = aD++;
		P_4[2] = 0;
		P_4[3] = P_0;
		P_4[4] = (byte)(num >> 24);
		P_4[5] = (byte)(num >> 16);
		P_4[6] = (byte)(num >> 8);
		P_4[7] = (byte)num;
		P_4[8] = (byte)(P_3 >> 24);
		P_4[9] = (byte)(P_3 >> 16);
		P_4[10] = (byte)(P_3 >> 8);
		P_4[11] = (byte)P_3;
		uint num3 = new global::crc.crc().crc_process(P_4, 0u, num2 - 4, 4294967295u, partial: false);
		P_4[12] = (byte)(num3 >> 24);
		P_4[13] = (byte)(num3 >> 16);
		P_4[14] = (byte)(num3 >> 8);
		P_4[15] = (byte)num3;
		y++;
		if (P_1 != 0)
		{
			w = System.DateTime.Now;
		}
		if (A().A(P_4, (uint)P_4.Length, out var num4))
		{
			return num4 == num2;
		}
		return false;
	}

	private bool A(byte[] P_0, out byte[] P_1, uint P_2, out bool P_3, out bool P_4)
	{
		bool result = false;
		P_3 = false;
		uint num = 12 + P_2 + 4;
		global::crc.crc crc = new global::crc.crc();
		uint init = 4294967295u;
		byte[] array = new byte[num];
		uint num2 = 0u;
		P_1 = null;
		P_4 = false;
		if (A().d())
		{
			byte[] array2 = new byte[12];
			if (!A().A(ref array2, 12u, out num2, P_0[1]) || num2 != 12)
			{
				global::A.A.k(string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aE(),
					12u.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ae(),
					num2.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aF()
				}));
				P_4 = true;
				A(true);
				return false;
			}
			if ((array2[0] & 0xF0) == 128)
			{
				num -= P_2;
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ad());
			}
			System.Array.Copy((System.Array)array2, (System.Array)array, 12L);
			init = crc.crc_process(array, 0u, 12u, init, partial: true);
			uint num3 = num - 12;
			uint num4 = A().D();
			uint num5 = num3;
			for (uint num6 = 0u; num6 <= num3 / num4; num6++)
			{
				num2 = 0u;
				if (num5 <= num4)
				{
					byte[] array3 = new byte[num5];
					if (!A().A(ref array3, num5, out num2, P_0[1]) || num2 != num5)
					{
						global::A.A.k(string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.af(),
							num5.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ae(),
							num2.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aF()
						}));
						P_4 = true;
						A(true);
						return false;
					}
					num2 = num5;
					System.Array.Copy((System.Array)array3, 0L, (System.Array)array, (long)(12 + num6 * num4), (long)num2);
					init = crc.crc_process(array, 12 + num6 * num4, num2 - 4, init, partial: false);
				}
				else
				{
					byte[] array4 = new byte[num4];
					if (!A().A(ref array4, num4, out num2, P_0[1]) || num2 != num4)
					{
						global::A.A.k(string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.af(),
							num4.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ae(),
							num2.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aF()
						}));
						P_4 = true;
						A(true);
						return false;
					}
					num2 = num4;
					System.Array.Copy((System.Array)array4, 0L, (System.Array)array, (long)(12 + num6 * num4), (long)num2);
					init = crc.crc_process(array, 12 + num6 * num4, num2, init, partial: true);
					if (num2 != num4)
					{
						break;
					}
				}
				num5 -= num2;
			}
		}
		else
		{
			bool flag = A().A(ref array, num, out num2, P_0[1]) && num2 == num;
			if ((array[0] & 0xF0) == 128)
			{
				num -= P_2;
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ad());
			}
			else if (!flag)
			{
				global::A.A.k(string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aG(),
					num.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ae(),
					num2.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aF()
				}));
				P_4 = true;
				A(true);
				return false;
			}
			init = crc.crc_process(array, 0u, num - 4, init, partial: false);
		}
		bool flag2 = true;
		for (int num7 = 1; (long)num7 < 8L; num7++)
		{
			if (array[num7] != P_0[num7])
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
		if (flag2 && flag3)
		{
			P_3 = (array[0] & 0xF0) == 128;
			if (!P_3)
			{
				uint num8 = ((array[0] != 2) ? P_2 : ((uint)(array[8] << 24) | ((uint)(array[9] << 16) & 0xFF0000u) | ((uint)(array[10] << 8) & 0xFF00u) | (array[11] & 0xFFu)));
				P_1 = new byte[num8];
				System.Array.Copy((System.Array)array, 12L, (System.Array)P_1, 0L, (long)num8);
			}
			result = !P_3;
		}
		A(false);
		return result;
	}

	internal bool A(byte P_0, int P_1, f P_2, uint P_3, uint P_4, out byte[] P_5, out bool P_6)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		P_5 = new byte[P_4];
		P_6 = false;
		if (A(P_2) == 0)
		{
			return false;
		}
		uint bH = C().@as[(uint)P_2].BH;
		ushort bg = C().@as[(uint)P_2].Bg;
		uint num = P_3;
		uint num2 = 0u;
		uint num3 = P_4;
		if (bg != 0)
		{
			num = P_3 / bg * bg;
			num2 = P_3 % bg;
			num3 += num2;
		}
		if (bH != 0)
		{
			if (num3 % bH != 0)
			{
				num3 += bH - num3 % bH;
			}
			else if (num3 == 0)
			{
				num3 += bH;
			}
		}
		uint num4 = num3;
		uint num5 = 0u;
		uint num6 = num;
		while (num4 != 0)
		{
			int num7 = P_1;
			do
			{
				uint num8 = A(P_2);
				uint num9 = Math.Min(num4, num8);
				if (bg != 0 && num9 >= bg)
				{
					num9 = num9 / bg * bg;
				}
				bool flag = false;
				lock (U)
				{
					if (A(P_0, P_2, num6, num9, out var array))
					{
						Thread.Sleep(0);
						Stopwatch val = new Stopwatch();
						val.Start();
						byte[] array2;
						bool flag2;
						bool num10 = A(array, out array2, num9, out P_6, out flag2);
						val.Stop();
						W[P_2] = (uint)val.ElapsedMilliseconds;
						v[P_2] = num9;
						if (num10)
						{
							if (array2.Length < num9)
							{
								byte[] obj = P_5;
								P_5 = new byte[P_4 - (num9 - array2.Length)];
								System.Array.Copy((System.Array)obj, 0, (System.Array)P_5, 0, P_5.Length);
							}
							uint num11;
							uint num12;
							uint num13;
							if (num5 == 0)
							{
								num11 = num2;
								num12 = 0u;
								num13 = Math.Min((uint)array2.Length - num2, (uint)P_5.Length - num12);
							}
							else
							{
								num11 = 0u;
								num12 = num5 - num2;
								num13 = Math.Min((uint)array2.Length, (uint)P_5.Length - num12);
							}
							System.Array.Copy((System.Array)array2, (long)num11, (System.Array)P_5, (long)num12, (long)num13);
							num4 -= num9;
							num5 += num9;
							num6 += num9;
							if (num5 - num2 >= P_4)
							{
								return true;
							}
							flag = true;
						}
					}
					if (!flag && !P_6)
					{
						A().e();
					}
				}
				if (flag)
				{
					if (aB != null)
					{
						c c2 = new c();
						c2.R = num5;
						c2.r = num4;
						aB.Invoke((object)this, (EventArgs)(object)c2);
					}
					break;
				}
				num7--;
			}
			while (num7 != 0);
			if (num7 == 0)
			{
				return false;
			}
		}
		return true;
	}

	private bool A(byte P_0, f P_1, uint P_2, byte[] P_3, out byte[] P_4)
	{
		uint num = C().@as[(uint)P_1].Be;
		if (P_1 == global::A.f.au)
		{
			num = 0u;
		}
		uint num2 = num + P_2;
		uint num3 = (uint)(12 + P_3.Length + 4);
		P_4 = new byte[num3];
		P_4[0] = 1;
		P_4[1] = aD++;
		P_4[2] = 0;
		P_4[3] = P_0;
		P_4[4] = (byte)(num2 >> 24);
		P_4[5] = (byte)(num2 >> 16);
		P_4[6] = (byte)(num2 >> 8);
		P_4[7] = (byte)num2;
		P_4[8] = (byte)(P_3.Length >> 24);
		P_4[9] = (byte)(P_3.Length >> 16);
		P_4[10] = (byte)(P_3.Length >> 8);
		P_4[11] = (byte)P_3.Length;
		System.Array.Copy((System.Array)P_3, 0L, (System.Array)P_4, 12L, (long)P_3.Length);
		uint num4 = new global::crc.crc().crc_process(P_4, 0u, num3 - 4, 4294967295u, partial: false);
		P_4[num3 - 4] = (byte)(num4 >> 24);
		P_4[1 + num3 - 4] = (byte)(num4 >> 16);
		P_4[2 + num3 - 4] = (byte)(num4 >> 8);
		P_4[3 + num3 - 4] = (byte)num4;
		y++;
		w = System.DateTime.Now;
		if (A().A(P_4, (uint)P_4.Length, out var num5))
		{
			return num5 == num3;
		}
		return false;
	}

	private bool A(byte[] P_0, out bool P_1, out bool P_2)
	{
		bool flag = false;
		P_1 = false;
		byte[] array = new byte[16];
		if (A().A(ref array, 16u, out var num, P_0[1]) && num == 16)
		{
			P_2 = false;
			flag = true;
			for (int num2 = 1; (long)num2 < 12L; num2++)
			{
				if (array[num2] != P_0[num2])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				uint num3 = new global::crc.crc().crc_process(array, 0u, (uint)(array.Length - 4), 4294967295u, partial: false);
				if (array[(long)array.Length - 4L] != (byte)(num3 >> 24) || array[(long)(1 + array.Length) - 4L] != (byte)(num3 >> 16) || array[(long)(2 + array.Length) - 4L] != (byte)(num3 >> 8) || array[(long)(3 + array.Length) - 4L] != (byte)num3)
				{
					flag = false;
				}
			}
			if (flag)
			{
				P_1 = (array[0] & 0xF0) == 128;
				if (P_1)
				{
					flag = false;
				}
			}
		}
		else
		{
			P_2 = true;
		}
		A(P_2);
		return flag;
	}

	internal bool A(byte P_0, int P_1, f P_2, uint P_3, byte[] P_4, out bool P_5)
	{
		P_5 = false;
		uint num = a(P_2);
		if (num == 0)
		{
			return false;
		}
		uint num2 = (uint)P_4.Length;
		uint num3 = 0u;
		uint num4 = P_3;
		while (num2 != 0)
		{
			int num5 = P_1;
			do
			{
				uint num6 = Math.Min(num2, num);
				byte[] array = new byte[num6];
				System.Array.Copy((System.Array)P_4, (long)num3, (System.Array)array, 0L, (long)num6);
				bool flag = false;
				lock (U)
				{
					if (A(P_0, P_2, num4, array, out var array2))
					{
						Thread.Sleep(0);
						if (A(array2, out P_5, out var _))
						{
							num2 -= num6;
							num3 += num6;
							num4 += num6;
							flag = true;
						}
					}
					if (!flag && !P_5)
					{
						A().e();
					}
				}
				if (flag)
				{
					if (aB != null)
					{
						c c2 = new c();
						c2.R = num3;
						c2.r = num2;
						aB.Invoke((object)this, (EventArgs)(object)c2);
					}
					break;
				}
				num5--;
			}
			while (num5 != 0);
			if (num5 == 0)
			{
				return false;
			}
		}
		return true;
	}

	internal bool A(byte P_0, int P_1, f P_2, uint P_3, byte[] P_4, uint P_5, out byte[] P_6, out bool P_7)
	{
		P_6 = new byte[P_5];
		P_7 = false;
		uint num = a(P_2);
		if (num == 0 || (uint)P_4.Length > num)
		{
			return false;
		}
		uint num2 = A(P_2);
		if (num2 == 0 || P_5 > num2)
		{
			return false;
		}
		int num3 = P_1;
		do
		{
			lock (U)
			{
				if (A(P_0, P_2, P_3, P_4, out var array))
				{
					Thread.Sleep(0);
					if (A(array, out P_6, P_5, out P_7, out var _) && P_6.Length == P_5)
					{
						return true;
					}
				}
				if (!P_7)
				{
					A().e();
				}
			}
			num3--;
		}
		while (num3 != 0);
		return false;
	}

	internal bool A(byte P_0, f P_1, uint P_2, byte[] P_3)
	{
		if (A(P_0, P_1, P_2, P_3, out var array))
		{
			ad = array;
			A().A(true);
			return true;
		}
		return false;
	}

	internal bool A(out bool P_0)
	{
		if (ad == null)
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ag());
		}
		P_0 = A(ad, out var _, out var flag2);
		if (!flag2)
		{
			A().A(false);
			ad = null;
		}
		return !flag2;
	}

	internal bool A(byte P_0, byte P_1, out bool P_2)
	{
		byte[] array = new byte[4] { 0, 14, 0, P_1 };
		return A(P_0, 2, global::A.f.au, 0u, array, out P_2);
	}

	internal bool A(byte P_0, out byte[] P_1, out bool P_2)
	{
		byte[] array = new byte[4] { 0, 15, 0, 0 };
		P_1 = new byte[1];
		if (A(P_0, 2, global::A.f.au, 0u, array, (uint)array.Length, out var array2, out P_2))
		{
			P_1 = new byte[array2.Length];
			System.Array.Copy((System.Array)array2, (System.Array)P_1, array2.Length);
			return true;
		}
		P_1[0] = 255;
		return false;
	}

	internal bool A(byte P_0, out bool P_1)
	{
		byte[] array = new byte[2] { 0, 6 };
		return A(P_0, 2, global::A.f.au, 0u, array, out P_1);
	}

	internal bool a(byte P_0, out bool P_1)
	{
		byte[] array = new byte[2] { 0, 12 };
		return A(P_0, 2, global::A.f.au, 0u, array, out P_1);
	}

	internal bool B(byte P_0, out bool P_1)
	{
		byte[] array = new byte[2] { 0, 13 };
		return A(P_0, 2, global::A.f.au, 0u, array, out P_1);
	}

	internal bool b(byte P_0, out bool P_1)
	{
		System.DateTime now = System.DateTime.Now;
		return A(P_0, 2, global::A.f.au, 0u, new byte[10]
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
		}, out P_1);
	}

	internal bool A(byte P_0, string P_1, string P_2, out bool P_3)
	{
		k k2 = new k(1, 25, 0, 9, 0);
		k k3 = new k(U.ae, U.aF, U.af, U.aG, U.ag);
		bool flag = U.aH != 8 && U.aH != 10 && k3 >= k2;
		byte[] array = ((!flag) ? new byte[98] : new byte[99]);
		array[0] = 0;
		array[1] = 7;
		Encoding encoding = Encoding.GetEncoding(20127);
		byte[] bytes = encoding.GetBytes(P_1);
		byte[] bytes2 = encoding.GetBytes(P_2);
		for (int num = 0; num < 32; num++)
		{
			if (num < P_1.Length)
			{
				array[2 + num] = bytes[num];
			}
			else
			{
				array[2 + num] = 0;
			}
		}
		for (int num2 = 0; num2 < 64; num2++)
		{
			if (num2 < P_2.Length)
			{
				array[34 + num2] = bytes2[num2];
			}
			else
			{
				array[34 + num2] = 0;
			}
		}
		if (flag)
		{
			array[98] = 1;
		}
		return A(P_0, 2, global::A.f.au, 0u, array, out P_3);
	}

	internal bool C(byte P_0, out bool P_1)
	{
		byte[] array = new byte[2] { 0, 8 };
		return A(P_0, 2, global::A.f.au, 0u, array, out P_1);
	}

	internal bool c(byte P_0, out bool P_1)
	{
		byte[] array = new byte[2] { 0, 3 };
		return A(P_0, 2, global::A.f.au, 0u, array, out P_1);
	}

	internal bool A(byte P_0, byte P_1, uint P_2, int P_3, byte[] P_4, out bool P_5)
	{
		byte[] array = new byte[28]
		{
			0, 4, P_1, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0
		};
		for (int num = 0; num < P_4.Length; num++)
		{
			array[4 + num] = P_4[num];
		}
		array[20] = (byte)(P_2 >> 24);
		array[21] = (byte)(P_2 >> 16);
		array[22] = (byte)(P_2 >> 8);
		array[23] = (byte)P_2;
		array[24] = (byte)(P_3 >> 24);
		array[25] = (byte)(P_3 >> 16);
		array[26] = (byte)(P_3 >> 8);
		array[27] = (byte)P_3;
		return A(P_0, 2, global::A.f.au, 0u, array, out P_5);
	}

	internal bool D(byte P_0, out bool P_1)
	{
		byte[] array = new byte[2] { 0, 19 };
		return A(P_0, 2, global::A.f.au, 0u, array, out P_1);
	}

	internal bool d(byte P_0, out bool P_1)
	{
		byte[] array = new byte[2] { 0, 20 };
		return A(P_0, 2, global::A.f.au, 0u, array, out P_1);
	}

	internal bool A(byte P_0, byte[] P_1)
	{
		bool result = false;
		lock (U)
		{
			if (!C().aS)
			{
				result = A(P_0, global::A.f.au, 0u, P_1, out var _);
			}
		}
		return result;
	}

	internal void A(byte P_0)
	{
		w = System.DateTime.Now;
		lock (U)
		{
			if (C().aS)
			{
				u.a();
				return;
			}
			byte[] array = new byte[2];
			A(P_0, global::A.f.au, 0u, array, out var _);
		}
	}

	internal void a(byte P_0)
	{
		w = System.DateTime.Now;
		lock (U)
		{
			if (C().aS)
			{
				u.B();
				return;
			}
			byte[] array = new byte[2] { 0, 1 };
			A(P_0, global::A.f.au, 0u, array, out var _);
		}
	}

	internal void B(byte P_0)
	{
		w = System.DateTime.Now;
		lock (U)
		{
			if (!C().aS)
			{
				byte[] array = new byte[2] { 0, 18 };
				A(P_0, global::A.f.au, 0u, array, out var _);
			}
		}
	}

	internal bool A(byte P_0, global::A.A.C P_1, out global::A.A.b P_2, out ushort P_3, out bool P_4)
	{
		byte[] array = new byte[2]
		{
			1,
			(byte)P_1
		};
		uint num = 3u;
		a(1500u);
		if (A(P_0, 2, global::A.f.Bb, 0u, array, num, out var array2, out P_4))
		{
			I();
			P_2 = (global::A.A.b)array2[0];
			P_3 = (ushort)((uint)(array2[1] << 8) | (array2[2] & 0xFFu));
			return true;
		}
		I();
		P_2 = global::A.A.b.BFb;
		P_3 = 0;
		return false;
	}

	internal bool A(byte P_0, global::A.A.C P_1, ushort P_2, ushort P_3, out global::A.A.b P_4, out j[] P_5, out bool P_6)
	{
		ushort num = (ushort)(1 + P_3 - P_2);
		P_5 = new j[num];
		int num2 = 60;
		ushort num3 = (ushort)((A(global::A.f.Bb) - 1) / (uint)num2);
		ushort num4 = P_2;
		ushort num5 = (ushort)Math.Min((int)P_3, num4 + num3 - 1);
		ushort num6 = 0;
		do
		{
			byte[] array = new byte[6]
			{
				2,
				(byte)P_1,
				(byte)((uint)(num4 >> 8) & 0xFFu),
				(byte)(num4 & 0xFFu),
				(byte)((uint)(num5 >> 8) & 0xFFu),
				(byte)(num5 & 0xFFu)
			};
			ushort num7 = (ushort)(1 + num5 - num4);
			uint num8 = (uint)(1 + num2 * num7);
			if (A(P_0, 2, global::A.f.Bb, 0u, array, num8, out var array2, out P_6))
			{
				P_4 = (global::A.A.b)array2[0];
				if (P_4 != 0)
				{
					P_5 = null;
					return false;
				}
				for (int num9 = 0; num9 < num7; num9++)
				{
					int num10 = 1 + num9 * num2;
					byte[] array3 = new byte[num2];
					System.Array.Copy((System.Array)array2, num10, (System.Array)array3, 0, num2);
					j j2 = new j();
					P_5[num6 + num9] = j2;
					j2.A(array3);
				}
				num6 += num7;
				if (num6 < num)
				{
					num4 = (ushort)(num5 + 1);
					num5 = (ushort)Math.Min((int)P_3, num4 + num3 - 1);
				}
				continue;
			}
			P_4 = global::A.A.b.BFb;
			P_5 = null;
			return false;
		}
		while (num6 < num);
		return true;
	}

	internal bool A(byte P_0, j P_1, uint P_2, uint P_3, out global::A.A.b P_4, out byte[] P_5, out bool P_6)
	{
		P_5 = new byte[P_3];
		byte[] array = P_1.A();
		uint num = A(global::A.f.Bb);
		uint num2 = 0u;
		do
		{
			uint num3 = Math.Min(P_3 - num2, num - 4);
			uint num4 = P_2 + num2;
			byte[] array2 = new byte[4 + array.Length + 4 + 4];
			array2[0] = 3;
			System.Array.Copy((System.Array)array, 0, (System.Array)array2, 4, array.Length);
			array2[4 + array.Length] = (byte)((num4 >> 24) & 0xFFu);
			array2[4 + array.Length + 1] = (byte)((num4 >> 16) & 0xFFu);
			array2[4 + array.Length + 2] = (byte)((num4 >> 8) & 0xFFu);
			array2[4 + array.Length + 3] = (byte)(num4 & 0xFFu);
			array2[4 + array.Length + 4] = (byte)((num3 >> 24) & 0xFFu);
			array2[4 + array.Length + 5] = (byte)((num3 >> 16) & 0xFFu);
			array2[4 + array.Length + 6] = (byte)((num3 >> 8) & 0xFFu);
			array2[4 + array.Length + 7] = (byte)(num3 & 0xFFu);
			uint num5 = 4 + num3;
			if (A(P_0, 2, global::A.f.Bb, 0u, array2, num5, out var array3, out P_6))
			{
				P_4 = (global::A.A.b)array3[0];
				if (P_4 != 0)
				{
					P_5 = null;
					return false;
				}
				System.Array.Copy((System.Array)array3, 4L, (System.Array)P_5, (long)num2, (long)num3);
				num2 += num3;
				continue;
			}
			P_4 = global::A.A.b.BFb;
			P_5 = null;
			return false;
		}
		while (num2 < P_3);
		return true;
	}

	internal bool A(byte P_0, j P_1, uint P_2, byte[] P_3, out global::A.A.b P_4, out bool P_5)
	{
		byte[] array = P_1.A();
		uint num = a(global::A.f.Bb);
		uint num2 = 0u;
		do
		{
			uint num3 = (uint)(4 + array.Length + 4);
			uint num4 = Math.Min((uint)P_3.Length - num2, num - num3);
			uint num5 = P_2 + num2;
			byte[] array2 = new byte[num3 + num4];
			array2[0] = 6;
			System.Array.Copy((System.Array)array, 0, (System.Array)array2, 4, array.Length);
			array2[4 + array.Length] = (byte)((num5 >> 24) & 0xFFu);
			array2[4 + array.Length + 1] = (byte)((num5 >> 16) & 0xFFu);
			array2[4 + array.Length + 2] = (byte)((num5 >> 8) & 0xFFu);
			array2[4 + array.Length + 3] = (byte)(num5 & 0xFFu);
			System.Array.Copy((System.Array)P_3, (long)num2, (System.Array)array2, (long)num3, (long)num4);
			uint num6 = 1u;
			if (A(P_0, 2, global::A.f.Bb, 0u, array2, num6, out var array3, out P_5))
			{
				P_4 = (global::A.A.b)array3[0];
				if (P_4 != 0)
				{
					return false;
				}
				num2 += num4;
				continue;
			}
			P_4 = global::A.A.b.BFb;
			return false;
		}
		while (num2 < P_3.Length);
		return true;
	}

	internal bool A(byte P_0, j P_1, j P_2, out global::A.A.b P_3, out bool P_4)
	{
		byte[] array = P_1.A();
		byte[] array2 = P_2.A();
		byte[] array3 = new byte[4 + array.Length + array2.Length];
		array3[0] = 4;
		System.Array.Copy((System.Array)array, 0, (System.Array)array3, 4, array.Length);
		System.Array.Copy((System.Array)array2, 0, (System.Array)array3, 4 + array.Length, array2.Length);
		uint num = 1u;
		if (A(P_0, 2, global::A.f.Bb, 0u, array3, num, out var array4, out P_4))
		{
			P_3 = (global::A.A.b)array4[0];
			return true;
		}
		P_3 = global::A.A.b.BFb;
		return false;
	}

	internal bool A(byte P_0, j P_1, out global::A.A.b P_2, out bool P_3)
	{
		byte[] array = P_1.A();
		byte[] array2 = new byte[4 + array.Length];
		array2[0] = 5;
		System.Array.Copy((System.Array)array, 0, (System.Array)array2, 4, array.Length);
		uint num = 1u;
		if (A(P_0, 2, global::A.f.Bb, 0u, array2, num, out var array3, out P_3))
		{
			P_2 = (global::A.A.b)array3[0];
			return true;
		}
		P_2 = global::A.A.b.BFb;
		return false;
	}

	internal bool A(List<uint> P_0, List<byte[]> P_1, List<uint> P_2)
	{
		w = System.DateTime.Now;
		if (C().aS)
		{
			return u.A(P_0, P_1, P_2);
		}
		return false;
	}

	internal bool A(byte P_0, uint P_1, uint P_2, uint P_3, byte P_4, byte P_5, byte P_6, byte P_7, out int P_8)
	{
		w = System.DateTime.Now;
		if (C().aS)
		{
			return u.A(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, out P_8);
		}
		P_8 = 65535;
		return false;
	}

	internal bool H()
	{
		w = System.DateTime.Now;
		if (C().aS)
		{
			return u.b();
		}
		return false;
	}

	internal bool h()
	{
		w = System.DateTime.Now;
		if (C().aS)
		{
			return u.C();
		}
		return false;
	}

	internal bool A(byte P_0, byte P_1, byte P_2, byte P_3, byte P_4, byte P_5)
	{
		w = System.DateTime.Now;
		if (C().aS)
		{
			return u.A(P_0, P_1, P_2, P_3, P_4, P_5);
		}
		return false;
	}

	internal void A(uint P_0)
	{
		aE = P_0;
	}

	internal uint A(f P_0)
	{
		if (P_0 != 0)
		{
			if (P_0 == global::A.f.Ba && A() is cF)
			{
				uint num = global::A.A.n switch
				{
					global::A.b.P => C().@as[40].Bf / 8, 
					global::A.b.p => C().@as[40].Bf / 4, 
					global::A.b.Q => C().@as[40].Bf / 2, 
					global::A.b.q => C().@as[40].Bf, 
					_ => C().@as[40].Bf, 
				};
				return Math.Min(Math.Max(Math.Max(A().E(), (uint)C().@as[40].Bg), (uint)C().@as[40].BH), num);
			}
			if (C().aT[(uint)B()].BL == 0)
			{
				return 0u;
			}
			uint num2 = 1u;
			if (P_0 == global::A.f.Ba && A() is cG)
			{
				switch (global::A.A.n)
				{
				case global::A.b.P:
					num2 = 2u;
					break;
				case global::A.b.p:
					num2 = 4u;
					break;
				case global::A.b.Q:
					num2 = 8u;
					break;
				case global::A.b.q:
					num2 = 32u;
					break;
				}
			}
			A().A(ref num2);
			uint num3 = num2 * (C().aT[(uint)B()].BL - 16);
			num3 = Math.Min(Math.Max(Math.Max(A().E(), (uint)C().@as[(uint)P_0].Bg), (uint)C().@as[(uint)P_0].BH), num3);
			if (aE != 0)
			{
				num3 = Math.Min(num3, aE);
			}
			return Math.Min(C().@as[(uint)P_0].Bf, num3);
		}
		return 2048u;
	}

	internal uint a(f P_0)
	{
		if (C().aT[(uint)B()].Bl == 0)
		{
			return 0u;
		}
		return Math.Min((uint)C().@as[(uint)P_0].BG, (uint)(C().aT[(uint)B()].Bl - 16));
	}

	internal void a(uint P_0)
	{
		A().A(P_0);
	}

	internal void I()
	{
		A().C();
	}

	internal void a(bool P_0)
	{
		A().A(P_0);
	}

	internal bool A(string P_0, out byte[] P_1, out bool P_2)
	{
		if (U.aH == 8 || U.aH == 10)
		{
			P_1 = null;
			P_2 = true;
			return false;
		}
		if (P_0 != null)
		{
			uint num;
			uint num2;
			switch (P_0.Length)
			{
			case 3:
			{
				char c2 = P_0[0];
				if (c2 != 'e')
				{
					if (c2 != 'p' || !(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aH()))
					{
						break;
					}
					num = 273u;
				}
				else
				{
					if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ah()))
					{
						break;
					}
					num = 277u;
				}
				goto IL_0139;
			}
			case 4:
			{
				char c2 = P_0[0];
				if (c2 != 'd')
				{
					if (c2 != 'f')
					{
						if (c2 != 'w' || !(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ai()))
						{
							break;
						}
						num = 275u;
					}
					else
					{
						if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJ()))
						{
							break;
						}
						num = 276u;
					}
				}
				else
				{
					if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aj()))
					{
						break;
					}
					num = 619u;
				}
				goto IL_0139;
			}
			case 8:
				if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aI()))
				{
					break;
				}
				num = 274u;
				goto IL_0139;
			case 5:
				{
					if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aK()))
					{
						break;
					}
					num = 277u;
					goto IL_0139;
				}
				IL_0139:
				num2 = num * 4;
				return A(0, 3, global::A.f.aX, num2, 4u, out P_1, out P_2);
			}
		}
		P_1 = null;
		P_2 = true;
		return false;
	}

	internal uint B(f P_0)
	{
		return v[P_0];
	}

	internal uint b(f P_0)
	{
		return W[P_0];
	}

	internal uint[,] i()
	{
		return A().h();
	}

	internal uint J()
	{
		return A().I();
	}

	internal uint j()
	{
		return A().H();
	}

	internal uint K()
	{
		return A().i();
	}
}
