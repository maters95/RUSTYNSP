using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;

namespace c
{
	internal class ce : i, System.IDisposable
	{
		private Stopwatch BFq = new Stopwatch();

		private Stopwatch BFR = new Stopwatch();

		private const uint BFr = 2000u;

		private static readonly uint[] BFS;

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

		private K BFy = new K(global::A.g.BJ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azL(), 54000);

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

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azk() + BFz;
		}

		public bool A(List<string> P_0)
		{
			try
			{
				if (!BFq.IsRunning)
				{
					BFq.Start();
				}
				if (BFq.ElapsedMilliseconds >= 800)
				{
					return BFy.A(P_0, ref BFz);
				}
				return false;
			}
			catch
			{
				return false;
			}
		}

		public void A()
		{
		}

		public bool A(F P_0)
		{
			return true;
		}

		public bool a()
		{
			return true;
		}

		public void a(bool P_0)
		{
			if (P_0)
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

		public bool F()
		{
			return BFZ;
		}

		public bool f()
		{
			return true;
		}

		public void G()
		{
			BFW = 3u;
			for (int i = 0; (long)i < 5L; i++)
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
					BfB.Invoke((object)this, EventArgs.Empty);
				}
			}
		}

		public void g()
		{
			J();
			if (BFZ)
			{
				BFZ = false;
				if (Bfa != null)
				{
					Bfa.Invoke((object)this, EventArgs.Empty);
				}
			}
		}

		public void A(int P_0, int P_1)
		{
			if (BFZ && BFX >= 2000)
			{
				J();
				BFZ = false;
				if (Bfa != null)
				{
					Bfa.Invoke((object)this, EventArgs.Empty);
				}
				return;
			}
			BFu[BFV, 0] = (uint)P_0;
			BFu[BFV, 1] = (uint)P_1;
			BFV = (BFV + 1) % 5;
			uint num = 0u;
			uint num2 = 0u;
			for (int i = 0; (long)i < 5L; i++)
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
				J();
				BFZ = false;
				if (Bfa != null)
				{
					Bfa.Invoke((object)this, EventArgs.Empty);
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
							BfB.Invoke((object)this, EventArgs.Empty);
						}
					}
				}
				else
				{
					BFW = 0u;
				}
			}
		}

		public uint H()
		{
			return BFv;
		}

		public uint[,] h()
		{
			return BFu;
		}

		public uint I()
		{
			return BFV;
		}

		public uint i()
		{
			return BFW;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BfA;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BfA, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void a(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BfA;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BfA, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void B(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bfa;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Bfa, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void b(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bfa;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Bfa, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void C(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BfB;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BfB, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void c(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BfB;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BfB, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		public string b()
		{
			return BFz;
		}

		public void A(uint P_0)
		{
		}

		public void C()
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public bool c()
		{
			return Bfb;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(bool P_0)
		{
			Bfb = P_0;
		}

		public bool A(byte[] P_0, uint P_1, out uint P_2)
		{
			return BFy.A(P_0, P_1, out P_2, BFR);
		}

		public bool A(ref byte[] P_0, uint P_1, out uint P_2, byte P_3)
		{
			return BFy.A(ref P_0, P_1, out P_2, P_3, BFw);
		}

		public uint D()
		{
			return 4294967295u;
		}

		public bool d()
		{
			return false;
		}

		private void J()
		{
			BFW = 0u;
			for (int i = 0; (long)i < 5L; i++)
			{
				BFu[i, 0] = 0u;
				BFu[i, 1] = 0u;
			}
			BFv = 0u;
		}

		public void A(ref uint P_0)
		{
			P_0 >>= BFY / 4;
			if (P_0 < 1)
			{
				P_0 = 1u;
			}
			if (P_0 >= 16)
			{
				BFw = BFS[2];
			}
			else if (P_0 >= 4)
			{
				BFw = BFS[1];
			}
			else
			{
				BFw = BFS[0];
			}
		}

		public uint E()
		{
			return 4294967295u;
		}

		public void e()
		{
			if (BFy != null)
			{
				BFy.A(0);
			}
		}

		public bool B()
		{
			return false;
		}

		public void Dispose()
		{
			if (BFy != null)
			{
				BFy.A();
			}
		}

		static ce()
		{
			uint[] array = new uint[3];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			BFS = array;
		}
	}
}
namespace C
{
	internal enum CE
	{
		azP = -1,
		azp = 1,
		azQ = 2
	}
	internal enum Ce
	{
		azq,
		azR,
		azr
	}
}
namespace c
{
	[StructLayout(3)]
	[InlineArray(5)]
	internal struct cE<A>
	{
		[CompilerGenerated]
		private A BEU;
	}
}
