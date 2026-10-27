using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace c
{
	internal class cG : i, System.IDisposable
	{
		private Stopwatch BGz = new Stopwatch();

		private Stopwatch BgA = new Stopwatch();

		private const uint Bga = 2000u;

		private static readonly uint[] BgB;

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

		private K Bgh = new K(global::A.g.Bi, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAh(), 54000);

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

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAH() + Bgi;
		}

		public bool A(List<string> P_0)
		{
			try
			{
				if (!BGz.IsRunning)
				{
					BGz.Start();
				}
				if (BGz.ElapsedMilliseconds >= 800)
				{
					return Bgh.A(P_0, ref Bgi);
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

		public bool F()
		{
			return BgI;
		}

		public bool f()
		{
			return true;
		}

		public void G()
		{
			BgF = 3u;
			for (int i = 0; (long)i < 5L; i++)
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
					BgK.Invoke((object)this, EventArgs.Empty);
				}
			}
		}

		public void g()
		{
			J();
			if (BgI)
			{
				BgI = false;
				if (Bgj != null)
				{
					Bgj.Invoke((object)this, EventArgs.Empty);
				}
			}
		}

		public void A(int P_0, int P_1)
		{
			if (BgI && BgG >= 2000)
			{
				J();
				BgI = false;
				if (Bgj != null)
				{
					Bgj.Invoke((object)this, EventArgs.Empty);
				}
				return;
			}
			Bgd[BgE, 0] = (uint)P_0;
			Bgd[BgE, 1] = (uint)P_1;
			BgE = (BgE + 1) % 5;
			uint num = 0u;
			uint num2 = 0u;
			for (int i = 0; (long)i < 5L; i++)
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
				J();
				BgI = false;
				if (Bgj != null)
				{
					Bgj.Invoke((object)this, EventArgs.Empty);
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
							BgK.Invoke((object)this, EventArgs.Empty);
						}
					}
				}
				else
				{
					BgF = 0u;
				}
			}
		}

		public uint H()
		{
			return Bge;
		}

		public uint[,] h()
		{
			return Bgd;
		}

		public uint I()
		{
			return BgE;
		}

		public uint i()
		{
			return BgF;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BgJ;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BgJ, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void a(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BgJ;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BgJ, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void B(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bgj;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Bgj, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void b(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bgj;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Bgj, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void C(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BgK;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BgK, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void c(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BgK;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BgK, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		public string b()
		{
			return Bgi;
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
			return Bgk;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(bool P_0)
		{
			Bgk = P_0;
		}

		public bool A(byte[] P_0, uint P_1, out uint P_2)
		{
			return Bgh.A(P_0, P_1, out P_2, BgA);
		}

		public bool A(ref byte[] P_0, uint P_1, out uint P_2, byte P_3)
		{
			return Bgh.A(ref P_0, P_1, out P_2, P_3, Bgf);
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
			BgF = 0u;
			for (int i = 0; (long)i < 5L; i++)
			{
				Bgd[i, 0] = 0u;
				Bgd[i, 1] = 0u;
			}
			Bge = 0u;
		}

		public void A(ref uint P_0)
		{
			P_0 >>= BgH / 4;
			if (P_0 < 1)
			{
				P_0 = 1u;
			}
			if (P_0 >= 16)
			{
				Bgf = BgB[2];
			}
			else if (P_0 >= 4)
			{
				Bgf = BgB[1];
			}
			else
			{
				Bgf = BgB[0];
			}
		}

		public uint E()
		{
			return 4294967295u;
		}

		public void e()
		{
			if (Bgh != null)
			{
				Bgh.A(0);
			}
		}

		public bool B()
		{
			return false;
		}

		public void Dispose()
		{
			if (Bgh != null)
			{
				Bgh.A();
			}
		}

		static cG()
		{
			uint[] array = new uint[3];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			BgB = array;
		}
	}
	internal class cg : MovableResizablePanel, Y
	{
		private new delegate void A(object P_0, OutputTestStateChangeEventArgs P_1);

		private new delegate void a(object P_0, EventArgs P_1);

		private new delegate void B(object P_0, EventArgs P_1);

		private Framework BHj;

		private Framework BHK;

		private SpecialObject BHk;

		private List<Setting> BHL = new List<Setting>();

		private Setting BHl;

		private Rectangle BHM;

		private bool BHm;

		private bool BHN;

		private bool BHn;

		private ThemedButton BHO;

		private string BHo;

		internal int BHP;

		[SpecialName]
		internal int a()
		{
			return BHk.C().ProcessId;
		}

		[SpecialName]
		internal new SpecialObject B()
		{
			return BHk;
		}

		internal cg(SpecialObject P_0, Framework P_1, Framework P_2, Rectangle P_3, bool P_4)
			: base(P_3, P_4, false, false)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			BHj = P_1;
			BHK = P_2;
			BHk = P_0;
			BHM = P_3;
			Enumerator<int> enumerator = BHk.C().PreApplySettingDataIds.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					BHL.Add(BHj.A(current));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			BHl = BHj.A(BHk.C().StatusChannelDataId);
			BHl.A(new EventHandler(B));
			BHk.A(new EventHandler(A));
			ad.c();
			ad.A(new EventHandler(A));
			ad.A((EventHandler<OutputTestStateChangeEventArgs>)A);
			BM.QQ.B(new EventHandler(a));
			BHn = BHL.Count == 0 && PortFunction.a(BHk.D());
			if (BHk.D() != null)
			{
				PortFunction.B b = BHk.D().F().E();
				BHP = (int)PortFunction.A(b.BSQ, b.BSq, b.BSR);
				bool flag = ad.A(BHP, BHl);
				ad.A(BHl, BHP, flag);
			}
		}

		private void A(object P_0, OutputTestStateChangeEventArgs P_1)
		{
			if (P_1.PortValue != BHP)
			{
				return;
			}
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = A;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (BHO != null && !((Control)BHO).Disposing && !((Control)BHO).IsDisposed)
			{
				if (P_1.State && BHl.ax() != 0 && P_1.PortValue == BHl.ax())
				{
					((Control)BHO).Text = BHk.C().ActiveText;
				}
				else if (BHo != null)
				{
					((Control)BHO).Text = BHo;
				}
				else
				{
					((Control)BHO).Text = BHk.C().IdleText;
				}
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = A;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			b();
		}

		private void a(object P_0, EventArgs P_1)
		{
			while (((ArrangedElementCollection)((Control)this).Controls).Count != 0)
			{
				q.A(((Control)this).Controls[0]);
			}
			A(false, true, null, 0);
		}

		internal void A(bool P_0 = false, bool P_1 = true, string P_2 = null, int P_3 = 0)
		{
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_062d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0634: Expected O, but got Unknown
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Expected O, but got Unknown
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_041a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0424: Expected O, but got Unknown
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected O, but got Unknown
			//IL_0321: Unknown result type (might be due to invalid IL or missing references)
			//IL_032b: Expected O, but got Unknown
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected O, but got Unknown
			//IL_059b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a5: Expected O, but got Unknown
			//IL_056b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0575: Expected O, but got Unknown
			//IL_0582: Unknown result type (might be due to invalid IL or missing references)
			//IL_058c: Expected O, but got Unknown
			((Control)this).SuspendLayout();
			int left = 5;
			int top = 5;
			HashSet<DataIdAndAttrId> idsContained = BHk.C().GetIdsContained();
			BHm = BHj.B() && BHj.b() && idsContained.Count != 0 && BHj.A(Enumerable.First<DataIdAndAttrId>((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)idsContained)).J();
			BHN = BHK != null && BHK.B() && BHK.b() && idsContained.Count != 0 && BHK.A(Enumerable.First<DataIdAndAttrId>((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)idsContained)).J();
			if ((BM.QO != BM.b.BpG || BHK == null) ? BHm : BHN)
			{
				Label val = new Label();
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + BHk.A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
				((Control)val).ForeColor = BM.te;
				((Control)val).BackColor = Color.Transparent;
				((Control)val).AutoSize = true;
				((Control)val).Left = left;
				((Control)val).Top = top;
				((Control)this).Controls.Add((Control)(object)val);
			}
			else
			{
				if (BHO == null || ((Control)BHO).Disposing || ((Control)BHO).IsDisposed)
				{
					BHO = new ThemedButton();
				}
				if (!P_1)
				{
					BHP |= P_3;
				}
				if (BHn)
				{
					bool flag = ((SettingOrSpecialObject)BHk).B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia());
					((Control)this).BackColor = BM.tG;
					((Control)this).BackColor = BM.tG;
					((Control)BHO).AutoSize = false;
					((Control)BHO).Left = 0;
					if (P_0)
					{
						((Control)BHO).Width = 55;
						((Control)BHO).Height = 20;
						((Control)BHO).Top = 0;
					}
					else
					{
						((Control)BHO).Width = (flag ? 60 : 120);
						((Control)BHO).Height = 23;
						((Control)BHO).Top = 10;
					}
					if (!P_1)
					{
						BHo = P_2;
						if (BHo != null)
						{
							((Control)BHO).Text = BHo;
						}
						else
						{
							((Control)BHO).Text = BHk.C().IdleText;
						}
					}
					else if (ad.A(BHP, BHl))
					{
						((Control)BHO).Text = BHk.C().ActiveText;
					}
					else
					{
						((Control)BHO).Text = BHk.C().IdleText;
					}
					if (BHo == null)
					{
						if (ad.A(BHP, BHl))
						{
							((Control)BHO).Text = BHk.C().ActiveText;
						}
						else
						{
							((Control)BHO).Text = BHk.C().IdleText;
						}
					}
					b();
					if (BHk.C().HoldToExecuteOutputTest)
					{
						((Control)BHO).MouseDown += new MouseEventHandler(C);
						((Control)BHO).MouseUp += new MouseEventHandler(c);
					}
					else
					{
						((Control)BHO).Click += new EventHandler(b);
					}
					((Control)this).Controls.Add((Control)(object)BHO);
				}
				else
				{
					string text = BHk.A(bz.aYu);
					if (string.IsNullOrEmpty(text))
					{
						text = BHk.A(bz.aYt);
					}
					if (BHk.C().InjectorStageIndex != -1 && BHk.C().InjectorOutputWithinStage != -1)
					{
						text = PortFunction.A(BHj, BHk.C().InjectorStageIndex, BHk.C().InjectorOutputWithinStage, text);
					}
					if (!string.IsNullOrEmpty(text))
					{
						Label val2 = new Label();
						((Control)val2).ForeColor = BM.tf;
						((Control)val2).Font = new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)1);
						((Control)val2).AutoSize = true;
						((Control)val2).Text = text;
						((Control)val2).Left = left;
						((Control)val2).Top = top;
						((Control)this).Controls.Add((Control)(object)val2);
						top = ((Control)val2).Bottom + 10;
					}
					Enumerator<Setting> enumerator = BHL.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Setting current = enumerator.Current;
							if (current != null)
							{
								DE dE = new DE(current.C(), BHj, BHK, null, false, false, false);
								((Control)dE).Left = left;
								((Control)dE).Top = top;
								((Control)this).Controls.Add((Control)(object)dE);
								top = ((Control)dE).Bottom + 8;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					((Control)BHO).AutoSize = true;
					if (ad.A(BHP, BHl))
					{
						((Control)BHO).Text = BHk.C().ActiveText;
					}
					else
					{
						((Control)BHO).Text = BHk.C().IdleText;
					}
					((Control)BHO).Left = left;
					((Control)BHO).Top = top;
					b();
					if (BHk.C().HoldToExecuteOutputTest)
					{
						((Control)BHO).MouseDown += new MouseEventHandler(C);
						((Control)BHO).MouseUp += new MouseEventHandler(c);
					}
					else
					{
						((Control)BHO).Click += new EventHandler(b);
					}
					((Control)this).Controls.Add((Control)(object)BHO);
				}
			}
			if (BHM != Rectangle.Empty)
			{
				((Control)this).Width = ((Rectangle)(ref BHM)).Width;
				((Control)this).Height = ((Rectangle)(ref BHM)).Height;
				((Control)this).Left = ((Rectangle)(ref BHM)).Left;
				((Control)this).Top = ((Rectangle)(ref BHM)).Top;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val3 = item;
					num = Math.Max(num, val3.Right + (BHn ? 1 : 5));
					num2 = Math.Max(num2, val3.Bottom + (BHn ? 1 : 5));
				}
				((Control)this).Width = num;
				((Control)this).Height = num2;
			}
			((Control)this).ResumeLayout(true);
		}

		internal new void b()
		{
			bool flag = ((SettingOrSpecialObject)BHk).B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia());
			((Control)BHO).Enabled = BHj.C() && BHk.l() && (BM.QO != BM.b.BpG || BHK == null) && (!flag || !ad.A());
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			try
			{
				BHl.a(new EventHandler(B));
				BHk.a(new EventHandler(A));
				ad.a((EventHandler<OutputTestStateChangeEventArgs>)A);
				ad.a(new EventHandler(A));
				ad.D();
				foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val = item;
					if (val is Button)
					{
						((val is Button) ? val : null).MouseUp -= new MouseEventHandler(c);
						((val is Button) ? val : null).MouseDown -= new MouseEventHandler(C);
						((val is Button) ? val : null).Click -= new EventHandler(b);
					}
				}
				BM.QQ.b(new EventHandler(a));
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			if (BHn)
			{
				e.Graphics.Clear(((Control)this).BackColor);
			}
			else
			{
				base.OnPaint(e);
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					B b = B;
					((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (BHO == null || ((Control)BHO).Disposing || ((Control)BHO).IsDisposed)
			{
				return;
			}
			if (((SettingOrSpecialObject)BHk).B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia()))
			{
				if (ad.A(BHP, BHl))
				{
					((Control)BHO).Text = BHk.C().ActiveText;
				}
				else if (BHo != null)
				{
					((Control)BHO).Text = BHo;
				}
				else
				{
					((Control)BHO).Text = BHk.C().IdleText;
				}
			}
			else if (BHl.ax() == 1)
			{
				((Control)BHO).Text = BHk.C().ActiveText;
			}
			else
			{
				((Control)BHO).Text = BHk.C().IdleText;
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Invalid comparison between Unknown and I4
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Invalid comparison between Unknown and I4
			if (!BM.A(BHj.aXc, true) || !BHj.C() || BHl.ax() == 1)
			{
				return;
			}
			bool flag = ((SettingOrSpecialObject)BHk).B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia());
			string confirmationText = BHk.C().ConfirmationText;
			if (flag && BHl.ax() == BHP)
			{
				ad.A(BHl, BHP, false);
			}
			else if (BHl.ax() == 0)
			{
				if (string.IsNullOrEmpty(confirmationText) || (int)bE.A((IWin32Window)(object)BM.QQ, confirmationText, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
				{
					if (flag)
					{
						ad.A(BHl, BHP, true);
					}
					else
					{
						BHl.a(1, true);
					}
				}
			}
			else if (flag && BHl.ax() != BHP && (string.IsNullOrEmpty(confirmationText) || (int)bE.A((IWin32Window)(object)BM.QQ, confirmationText, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6))
			{
				ad.A(BHl, BHP, true);
			}
		}

		public void C(object P_0, EventArgs P_1)
		{
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Invalid comparison between Unknown and I4
			if (!BM.A(BHj.aXc, true) || !BHj.C())
			{
				return;
			}
			if (((SettingOrSpecialObject)BHk).B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia()))
			{
				ad.A(BHl, BHP, true);
			}
			else if (BHl.ax() != 1)
			{
				string confirmationText = BHk.C().ConfirmationText;
				if (string.IsNullOrEmpty(confirmationText) || (int)bE.A((IWin32Window)(object)BM.QQ, confirmationText, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
				{
					BHl.a(1, true);
				}
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (((SettingOrSpecialObject)BHk).B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia()))
			{
				ad.A(BHl, BHP, false);
			}
		}

		public Control A(DataIdAndAttrId P_0)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is DE && ((aj)(val as DE)).b().C() == P_0)
				{
					return val;
				}
			}
			return null;
		}

		public Control A()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is DE)
				{
					return val;
				}
			}
			return null;
		}
	}
}
namespace C
{
	internal interface CG
	{
		HashSet<DataIdAndAttrId> GetIdsContained();

		HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs();

		void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch);

		void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode);

		void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode);

		void UpdateSettingsIncludedInPasswordProtection(TreeNode node);

		void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll);

		void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap);

		bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework);

		void ImportFromAnotherFramework(Framework importFramework, bool markForWrite);
	}
	internal enum Cg : byte
	{
		BAB = 0,
		BAb = 1,
		BAC = 2,
		BAc = 3,
		BAD = 4,
		BAd = 5,
		BAE = 6,
		BAe = 7,
		BAF = 8,
		BAf = 9,
		BAG = 10,
		BAg = 11,
		BAH = 12,
		BAh = 13,
		BAI = 14,
		BAi = 15,
		BAJ = 16,
		BAj = 17,
		BAK = 18,
		BAk = 19,
		BAL = 20,
		BAl = 21,
		BAM = 22,
		BAm = 23,
		BAN = 24,
		BAn = 25,
		BAO = 26,
		BAo = 27,
		BAP = 28,
		BAp = 29,
		BAQ = 31,
		BAq = 32,
		BAR = 33,
		BAr = 34,
		BAS = 35,
		BAs = 36,
		BAT = 37,
		BAt = 38
	}
}
