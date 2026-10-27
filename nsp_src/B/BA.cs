using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Layout;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.Properties;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace B
{
	internal class BA : Form
	{
		private Table ML;

		private az Ml;

		private IContainer MM;

		private ThemedButton Mm;

		private ThemedButton MN;

		private RadioButton Mn;

		private RadioButton MO;

		private RadioButton Mo;

		internal BA(Table P_0, bool P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			B();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label || val is RadioButton)
				{
					val.ForeColor = BM.te;
				}
			}
			BM.C(new EventHandler(b));
			ML = P_0;
			if (P_1)
			{
				((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hX();
			}
			else
			{
				((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hx();
			}
			((Control)Mn).Paint += new PaintEventHandler(A);
			((Control)MO).Paint += new PaintEventHandler(A);
			((Control)Mo).Paint += new PaintEventHandler(A);
			if (ML.HorizAxisEnabled() && ML.HorizAxis.g() != null)
			{
				Setting setting = ML.HorizAxis.h();
				if (setting != null)
				{
					int num = setting.aS();
					if (num != 0 && num != 82)
					{
						string text = bS.A(setting.@as(), num, false, 0);
						((Control)Mn).Text = ((SettingOrSpecialObject)setting).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					else
					{
						((Control)Mn).Text = ((SettingOrSpecialObject)setting).A(bz.aYt);
					}
				}
				else
				{
					((Control)Mn).Enabled = false;
				}
			}
			else
			{
				((Control)Mn).Enabled = false;
			}
			if (ML.VertAxisEnabled() && ML.VertAxis.g() != null)
			{
				Setting setting2 = ML.VertAxis.h();
				if (setting2 != null)
				{
					int num2 = setting2.aS();
					if (num2 != 0 && num2 != 82)
					{
						string text2 = bS.A(setting2.@as(), num2, false, 0);
						((Control)MO).Text = ((SettingOrSpecialObject)setting2).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					else
					{
						((Control)MO).Text = ((SettingOrSpecialObject)setting2).A(bz.aYt);
					}
				}
				else
				{
					((Control)MO).Enabled = false;
				}
			}
			else
			{
				((Control)MO).Enabled = false;
			}
			if (ML.SlicesEnabled() && ML.SliceAxis.g() != null)
			{
				Setting setting3 = ML.SliceAxis.h();
				if (setting3 != null)
				{
					int num3 = setting3.aS();
					if (num3 != 0 && num3 != 82)
					{
						string text3 = bS.A(setting3.@as(), num3, false, 0);
						((Control)Mo).Text = ((SettingOrSpecialObject)setting3).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					else
					{
						((Control)Mo).Text = ((SettingOrSpecialObject)setting3).A(bz.aYt);
					}
				}
				else
				{
					((Control)Mo).Enabled = false;
				}
			}
			else
			{
				((Control)Mo).Enabled = false;
			}
			if (((Control)Mn).Enabled)
			{
				Mn.Checked = true;
			}
			else if (((Control)MO).Enabled)
			{
				MO.Checked = true;
			}
			else if (((Control)Mo).Enabled)
			{
				Mo.Checked = true;
			}
			a();
		}

		internal BA()
		{
			B();
		}

		[SpecialName]
		internal az A()
		{
			return Ml;
		}

		private void a()
		{
			if (Mn.Checked)
			{
				Ml = az.Mj;
			}
			else if (MO.Checked)
			{
				Ml = az.MK;
			}
			else if (Mo.Checked)
			{
				Ml = az.Mk;
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			a();
		}

		private void a(object P_0, EventArgs P_1)
		{
			a();
		}

		private void B(object P_0, EventArgs P_1)
		{
			a();
		}

		private void A(object P_0, PaintEventArgs P_1)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
			{
				return;
			}
			RadioButton val = (RadioButton)((P_0 is RadioButton) ? P_0 : null);
			if (!((Control)val).Enabled)
			{
				SolidBrush val2 = new SolidBrush(((Control)this).BackColor);
				try
				{
					P_1.Graphics.FillRectangle((Brush)(object)val2, 17, 0, ((Control)val).Width - 17, ((Control)val).Height);
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
				Point val3 = default(Point);
				((Point)(ref val3))._002Ector(17, 2);
				TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, ((Control)val).Text, ((Control)val).Font, val3, Color.Gray, (TextFormatFlags)2048);
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			BM.c(new EventHandler(b));
			((Control)Mn).Paint -= new PaintEventHandler(A);
			((Control)MO).Paint -= new PaintEventHandler(A);
			((Control)Mo).Paint -= new PaintEventHandler(A);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && MM != null)
			{
				((System.IDisposable)MM).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void B()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Expected O, but got Unknown
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_033f: Expected O, but got Unknown
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Expected O, but got Unknown
			Mm = new ThemedButton();
			MN = new ThemedButton();
			Mn = new RadioButton();
			MO = new RadioButton();
			Mo = new RadioButton();
			((Control)this).SuspendLayout();
			((Button)Mm).DialogResult = (DialogResult)1;
			((Control)Mm).Location = new Point(82, 93);
			((Control)Mm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)Mm).Size = new Size(101, 37);
			((Control)Mm).TabIndex = 3;
			((Control)Mm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)Mm).UseVisualStyleBackColor = true;
			((Button)MN).DialogResult = (DialogResult)2;
			((Control)MN).Location = new Point(191, 93);
			((Control)MN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)MN).Size = new Size(101, 37);
			((Control)MN).TabIndex = 4;
			((Control)MN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)MN).UseVisualStyleBackColor = true;
			((Control)Mn).AutoSize = true;
			Mn.Checked = true;
			((Control)Mn).Location = new Point(12, 12);
			((Control)Mn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hZ();
			((Control)Mn).Size = new Size(14, 13);
			((Control)Mn).TabIndex = 0;
			Mn.TabStop = true;
			((ButtonBase)Mn).UseVisualStyleBackColor = true;
			Mn.CheckedChanged += new EventHandler(A);
			((Control)MO).AutoSize = true;
			((Control)MO).Location = new Point(12, 35);
			((Control)MO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hz();
			((Control)MO).Size = new Size(14, 13);
			((Control)MO).TabIndex = 1;
			((ButtonBase)MO).UseVisualStyleBackColor = true;
			MO.CheckedChanged += new EventHandler(a);
			((Control)Mo).AutoSize = true;
			((Control)Mo).Location = new Point(12, 58);
			((Control)Mo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IA();
			((Control)Mo).Size = new Size(14, 13);
			((Control)Mo).TabIndex = 2;
			((ButtonBase)Mo).UseVisualStyleBackColor = true;
			Mo.CheckedChanged += new EventHandler(B);
			((Form)this).AcceptButton = (IButtonControl)(object)Mm;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)MN;
			((Form)this).ClientSize = new Size(304, 142);
			((Control)this).Controls.Add((Control)(object)Mo);
			((Control)this).Controls.Add((Control)(object)MO);
			((Control)this).Controls.Add((Control)(object)Mn);
			((Control)this).Controls.Add((Control)(object)MN);
			((Control)this).Controls.Add((Control)(object)Mm);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ia();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IB();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Ba : Form
	{
		[CompilerGenerated]
		private sealed class A
		{
			public uint BOd;

			public uint BOE;

			public Ba BOe;

			internal void A()
			{
				((Control)BOe.mC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcV() + BOd / 10 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq() + BOd % 10;
			}

			internal void a()
			{
				((Control)BOe.mF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcv() + BOE;
			}
		}

		[CompilerGenerated]
		private sealed class a
		{
			public uint BOF;

			public uint BOf;

			public uint BOG;

			public uint BOg;

			public uint BOH;

			public uint BOh;

			public uint BOI;

			public uint BOi;

			public uint BOJ;

			public A BOj;

			internal void A()
			{
				((Control)BOj.BOe.mf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcW() + BOF;
			}

			internal void a()
			{
				((Control)BOj.BOe.mG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcw() + ((BOf != 4294967295u) ? (BOf + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcX() + BOG + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcx()) : string.Empty);
			}

			internal void B()
			{
				((Control)BOj.BOe.mg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcY() + ((BOg != 4294967295u) ? (BOg + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcX() + BOH + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcx()) : string.Empty);
			}

			internal void b()
			{
				((Control)BOj.BOe.mH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcy() + ((BOh != 4294967295u) ? (BOh + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcX() + BOI + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcx()) : string.Empty);
			}

			internal void C()
			{
				((Control)BOj.BOe.mh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcZ() + ((BOi != 4294967295u) ? (BOi + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcX() + BOJ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcx()) : string.Empty);
			}
		}

		[CompilerGenerated]
		private sealed class B
		{
			public int BOK;

			public int BOk;

			public int BOL;

			public int BOl;

			public A BOM;

			internal void A()
			{
				((Control)BOM.BOe.mD).Text = string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcz(),
					BOL.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IY(),
					BOl.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTV()
				});
			}
		}

		[CompilerGenerated]
		private sealed class b
		{
			public string BOm;

			public string BON;

			public B BOn;

			internal void A()
			{
				Label mc = BOn.BOM.BOe.mc;
				((Control)mc).Text = string.Concat(new string[6]
				{
					((Control)mc).Text,
					BOm,
					BOn.BOK.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IY(),
					BOn.BOk.ToString(),
					BON
				});
			}
		}

		[CompilerGenerated]
		private sealed class C
		{
			public int BOO;

			public B BOo;

			internal void A()
			{
				((Collection<DataPoint>)((Collection<Series>)BOo.BOM.BOe.md.Series)[BOO].Points).Clear();
			}
		}

		[CompilerGenerated]
		private sealed class c
		{
			public int BOP;

			public B BOp;

			internal void A()
			{
				BOp.BOM.BOe.md.Series[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IK()].Points.AddY(BOp.BOM.BOe.MZ[BOP]);
			}

			internal void a()
			{
				BOp.BOM.BOe.md.Series[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ik()].Points.AddY(BOp.BOM.BOe.Mz[BOP]);
			}

			internal void B()
			{
				BOp.BOM.BOe.md.Series[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IL()].Points.AddY(BOp.BOM.BOe.mA[BOP]);
			}

			internal void b()
			{
				BOp.BOM.BOe.md.Series[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Il()].Points.AddY(BOp.BOM.BOe.ma[BOP]);
			}
		}

		private BackgroundWorker Mx = new BackgroundWorker();

		private uint MY;

		private const int My = 20;

		private int[] MZ = new int[20];

		private int[] Mz = new int[20];

		private int[] mA = new int[20];

		private int[] ma = new int[20];

		private static int mB;

		private IContainer mb;

		private Label mC;

		private Label mc;

		private Label mD;

		private Chart md;

		private Button mE;

		private Button me;

		private Label mF;

		private Label mf;

		private Label mG;

		private Label mg;

		private Label mH;

		private Label mh;

		internal Ba()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			A();
			((Collection<ChartArea>)md.ChartAreas)[0].AxisX.Maximum = 20.0;
			((Collection<ChartArea>)md.ChartAreas)[0].AxisX.Minimum = 0.0;
			((Collection<ChartArea>)md.ChartAreas)[0].AxisY.Maximum = 400.0;
			((Collection<ChartArea>)md.ChartAreas)[0].AxisY.Minimum = 0.0;
			Mx.DoWork += new DoWorkEventHandler(A);
			Mx.RunWorkerAsync();
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected O, but got Unknown
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected O, but got Unknown
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected O, but got Unknown
			//IL_0332: Unknown result type (might be due to invalid IL or missing references)
			//IL_033c: Expected O, but got Unknown
			//IL_034f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Expected O, but got Unknown
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Expected O, but got Unknown
			//IL_0471: Unknown result type (might be due to invalid IL or missing references)
			//IL_047b: Expected O, but got Unknown
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04da: Expected O, but got Unknown
			//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f2: Expected O, but got Unknown
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Expected O, but got Unknown
			//IL_0518: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Expected O, but got Unknown
			while (true)
			{
				try
				{
					if (BM.Qz != null)
					{
						string aXc = BM.Qz.aXc;
						if (!((Control)this).Disposing && !((Control)this).IsDisposed && ((Control)this).Visible)
						{
							uint BOF = global::A.A.A(aXc, f.aX);
							((Control)mf).Invoke((Action)delegate
							{
								((Control)mf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcW() + BOF;
							});
							uint BOG = global::A.A.B(aXc, f.aX);
							uint BOf = global::A.A.b(aXc, f.aX);
							uint BOH = global::A.A.B(aXc, f.aw);
							uint BOg = global::A.A.b(aXc, f.aw);
							uint BOI = global::A.A.B(aXc, f.Ba);
							uint BOh = global::A.A.b(aXc, f.Ba);
							uint BOJ = global::A.A.B(aXc, f.ax);
							uint BOi = global::A.A.b(aXc, f.ax);
							((Control)mG).Invoke((Action)delegate
							{
								((Control)mG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcw() + ((BOf != 4294967295u) ? (BOf + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcX() + BOG + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcx()) : string.Empty);
							});
							((Control)mg).Invoke((Action)delegate
							{
								((Control)mg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcY() + ((BOg != 4294967295u) ? (BOg + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcX() + BOH + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcx()) : string.Empty);
							});
							((Control)mH).Invoke((Action)delegate
							{
								((Control)mH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcy() + ((BOh != 4294967295u) ? (BOh + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcX() + BOI + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcx()) : string.Empty);
							});
							((Control)mh).Invoke((Action)delegate
							{
								((Control)mh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcZ() + ((BOi != 4294967295u) ? (BOi + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcX() + BOJ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcx()) : string.Empty);
							});
						}
						uint num = global::A.A.K(aXc);
						uint BOd = global::A.A.i(aXc);
						uint[,] array = global::A.A.j(aXc);
						uint BOE = global::A.A.J(aXc);
						if (array != null && num != MY)
						{
							if (!((Control)this).Disposing && !((Control)this).IsDisposed && ((Control)this).Visible)
							{
								((Control)mC).Invoke((Action)delegate
								{
									((Control)mC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcV() + BOd / 10 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq() + BOd % 10;
								});
								((Control)mc).Invoke((Action)([CompilerGenerated] () =>
								{
									((Control)mc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.It();
								}));
							}
							int BOL = 0;
							int BOl = 0;
							int BOK = 0;
							int BOk = 0;
							for (int i = 0; i < ((System.Array)array).GetLength(0); i++)
							{
								BOK = (int)array[i, 0];
								BOk = (int)array[i, 1];
								BOL += BOK;
								BOl += BOk;
								string BOm = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ie();
								string BON = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IF();
								if (i == num)
								{
									BOm = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.If();
									BON = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IG();
								}
								if (!((Control)this).Disposing && !((Control)this).IsDisposed && ((Control)this).Visible)
								{
									((Control)mc).Invoke((Action)delegate
									{
										Label val = mc;
										((Control)val).Text = string.Concat(new string[6]
										{
											((Control)val).Text,
											BOm,
											BOK.ToString(),
											D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IY(),
											BOk.ToString(),
											BON
										});
									});
								}
							}
							if (!((Control)this).Disposing && !((Control)this).IsDisposed && ((Control)this).Visible)
							{
								((Control)mD).Invoke((Action)delegate
								{
									((Control)mD).Text = string.Concat(new string[5]
									{
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcz(),
										BOL.ToString(),
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IY(),
										BOl.ToString(),
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTV()
									});
								});
								((Control)mF).Invoke((Action)delegate
								{
									((Control)mF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcv() + BOE;
								});
							}
							if (mB >= 20)
							{
								System.Array.Copy((System.Array)MZ, 1, (System.Array)MZ, 0, 19);
								System.Array.Copy((System.Array)Mz, 1, (System.Array)Mz, 0, 19);
								System.Array.Copy((System.Array)mA, 1, (System.Array)mA, 0, 19);
								System.Array.Copy((System.Array)ma, 1, (System.Array)ma, 0, 19);
							}
							mB++;
							if (mB >= 20)
							{
								mB = 20;
							}
							MZ[mB - 1] = BOL;
							Mz[mB - 1] = BOl;
							mA[mB - 1] = (int)array[num, 0];
							ma[mB - 1] = (int)array[num, 1];
							if (!((Control)this).Disposing && !((Control)this).IsDisposed && ((Control)this).Visible)
							{
								int BOO;
								for (BOO = 0; BOO < ((Collection<Series>)md.Series).Count; BOO++)
								{
									((Control)md).Invoke((Action)delegate
									{
										((Collection<DataPoint>)((Collection<Series>)md.Series)[BOO].Points).Clear();
									});
								}
								int BOP;
								for (BOP = 0; BOP < mB; BOP++)
								{
									((Control)md).Invoke((Action)delegate
									{
										md.Series[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IK()].Points.AddY(MZ[BOP]);
									});
									((Control)md).Invoke((Action)delegate
									{
										md.Series[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ik()].Points.AddY(Mz[BOP]);
									});
									((Control)md).Invoke((Action)delegate
									{
										md.Series[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IL()].Points.AddY(mA[BOP]);
									});
									((Control)md).Invoke((Action)delegate
									{
										md.Series[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Il()].Points.AddY(ma[BOP]);
									});
								}
							}
							MY = num;
						}
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ig() + ex.Message, true);
				}
				Thread.Sleep(200);
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			((Control)md).Invoke((Action)([CompilerGenerated] () =>
			{
				((Control)md).Show();
			}));
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			((Control)md).Invoke((Action)([CompilerGenerated] () =>
			{
				((Control)md).Hide();
			}));
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && mb != null)
			{
				((System.IDisposable)mb).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_043b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Expected O, but got Unknown
			//IL_0455: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c2: Expected O, but got Unknown
			//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0523: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Unknown result type (might be due to invalid IL or missing references)
			//IL_057d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0632: Unknown result type (might be due to invalid IL or missing references)
			//IL_0659: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0702: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ed: Expected O, but got Unknown
			ChartArea chartArea = new ChartArea();
			Legend legend = new Legend();
			Series series = new Series();
			Series series2 = new Series();
			Series series3 = new Series();
			Series series4 = new Series();
			mC = new Label();
			mc = new Label();
			mD = new Label();
			md = new Chart();
			mE = new Button();
			me = new Button();
			mF = new Label();
			mf = new Label();
			mG = new Label();
			mg = new Label();
			mH = new Label();
			mh = new Label();
			((ISupportInitialize)md).BeginInit();
			((Control)this).SuspendLayout();
			((Control)mC).Location = new Point(12, 9);
			((Control)mC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)mC).Size = new Size(530, 17);
			((Control)mC).TabIndex = 0;
			((Control)mC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IH();
			((Control)mc).Location = new Point(12, 33);
			((Control)mc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)mc).Size = new Size(530, 17);
			((Control)mc).TabIndex = 1;
			((Control)mc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ih();
			((Control)mD).Location = new Point(12, 57);
			((Control)mD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)mD).Size = new Size(530, 17);
			((Control)mD).TabIndex = 2;
			((Control)mD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.II();
			chartArea.AxisX.Interval = 1.0;
			chartArea.AxisX.IntervalOffsetType = DateTimeIntervalType.Number;
			chartArea.AxisX.IsLabelAutoFit = false;
			chartArea.AxisX.Maximum = 20.0;
			chartArea.AxisX.Minimum = 0.0;
			chartArea.AxisX2.IntervalOffsetType = DateTimeIntervalType.Number;
			chartArea.AxisY.Maximum = 300.0;
			chartArea.AxisY.Minimum = 0.0;
			chartArea.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ii();
			((Collection<ChartArea>)md.ChartAreas).Add(chartArea);
			legend.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IJ();
			((Collection<Legend>)md.Legends).Add(legend);
			((Control)md).Location = new Point(13, 265);
			((Control)md).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ij();
			series.ChartArea = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ii();
			series.ChartType = SeriesChartType.Line;
			series.Legend = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IJ();
			series.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IK();
			series2.ChartArea = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ii();
			series2.ChartType = SeriesChartType.Line;
			series2.Legend = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IJ();
			series2.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ik();
			series3.ChartArea = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ii();
			series3.ChartType = SeriesChartType.Line;
			series3.Legend = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IJ();
			series3.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IL();
			series4.ChartArea = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ii();
			series4.ChartType = SeriesChartType.Line;
			series4.Legend = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IJ();
			series4.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Il();
			((Collection<Series>)md.Series).Add(series);
			((Collection<Series>)md.Series).Add(series2);
			((Collection<Series>)md.Series).Add(series3);
			((Collection<Series>)md.Series).Add(series4);
			md.Size = new Size(533, 262);
			((Control)md).TabIndex = 3;
			((Control)md).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ij();
			((Control)mE).Location = new Point(91, 233);
			((Control)mE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IM();
			((Control)mE).Size = new Size(75, 23);
			((Control)mE).TabIndex = 4;
			((Control)mE).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Im();
			((ButtonBase)mE).UseVisualStyleBackColor = true;
			((Control)mE).Click += new EventHandler(A);
			((Control)me).Location = new Point(183, 233);
			((Control)me).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IN();
			((Control)me).Size = new Size(75, 23);
			((Control)me).TabIndex = 5;
			((Control)me).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.In();
			((ButtonBase)me).UseVisualStyleBackColor = true;
			((Control)me).Click += new EventHandler(a);
			((Control)mF).Location = new Point(12, 81);
			((Control)mF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)mF).Size = new Size(530, 17);
			((Control)mF).TabIndex = 6;
			((Control)mF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IO();
			((Control)mf).Location = new Point(12, 105);
			((Control)mf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Io();
			((Control)mf).Size = new Size(530, 17);
			((Control)mf).TabIndex = 7;
			((Control)mf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IP();
			((Control)mG).Location = new Point(12, 129);
			((Control)mG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ip();
			((Control)mG).Size = new Size(530, 17);
			((Control)mG).TabIndex = 8;
			((Control)mG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IQ();
			((Control)mg).Location = new Point(12, 153);
			((Control)mg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iq();
			((Control)mg).Size = new Size(530, 17);
			((Control)mg).TabIndex = 9;
			((Control)mg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IR();
			((Control)mH).Location = new Point(12, 177);
			((Control)mH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GB();
			((Control)mH).Size = new Size(530, 17);
			((Control)mH).TabIndex = 10;
			((Control)mH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ir();
			((Control)mh).Location = new Point(12, 201);
			((Control)mh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GC();
			((Control)mh).Size = new Size(530, 17);
			((Control)mh).TabIndex = 11;
			((Control)mh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IS();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(560, 539);
			((Control)this).Controls.Add((Control)(object)mh);
			((Control)this).Controls.Add((Control)(object)mH);
			((Control)this).Controls.Add((Control)(object)mg);
			((Control)this).Controls.Add((Control)(object)mG);
			((Control)this).Controls.Add((Control)(object)mf);
			((Control)this).Controls.Add((Control)(object)mF);
			((Control)this).Controls.Add((Control)(object)me);
			((Control)this).Controls.Add((Control)(object)mE);
			((Control)this).Controls.Add((Control)(object)md);
			((Control)this).Controls.Add((Control)(object)mD);
			((Control)this).Controls.Add((Control)(object)mc);
			((Control)this).Controls.Add((Control)(object)mC);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Is();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)0;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IT();
			((ISupportInitialize)md).EndInit();
			((Control)this).ResumeLayout(false);
		}

		[CompilerGenerated]
		private void a()
		{
			((Control)mc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.It();
		}

		[CompilerGenerated]
		private void B()
		{
			((Control)md).Show();
		}

		[CompilerGenerated]
		private void b()
		{
			((Control)md).Hide();
		}
	}
}
namespace b
{
	internal class bA : Form
	{
		private string yM;

		private Version ym;

		private Version yN;

		private IContainer yn;

		private ag yO;

		private Label yo;

		private Label yP;

		private ThemedButton yp;

		private ThemedButton yQ;

		private ThemedButton yq;

		private aP yR;

		private LinkLabel yr;

		internal bA(Version P_0, Version P_1)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			a();
			ym = P_0;
			yN = P_1;
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					((val is Label) ? val : null).ForeColor = BM.te;
				}
			}
			((Control)yO).BackColor = BM.tH;
			((Control)yO).ForeColor = BM.te;
			((Control)yR).ForeColor = BM.te;
			if (ym != (Version)null && yN != (Version)null)
			{
				((Control)yo).Text = string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yl(),
					aY.A(ym),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yM(),
					aY.A(yN),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ym()
				});
			}
			else if (ym != (Version)null && yN == (Version)null)
			{
				((Control)yo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yN() + aY.A(ym) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yn();
			}
			else if (ym == (Version)null && yN != (Version)null)
			{
				((Control)yo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yO() + aY.A(yN) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yn();
			}
			bool num = BM.QQ.qd.UserPrivacyOptionRegistryExists();
			bool flag = false;
			if (num)
			{
				flag = BM.QQ.qd.UserOptInPrivacy;
			}
			bool flag2 = false;
			if (!flag)
			{
				if (BM.QQ.qd.LastAgreedPrivacyDocVerRegistryEntryExists())
				{
					Version lastAgreedPrivacyDocumentVer = BM.QQ.qd.LastAgreedPrivacyDocumentVer;
					if (Bh.A() > lastAgreedPrivacyDocumentVer)
					{
						flag2 = true;
					}
				}
				else
				{
					flag2 = true;
				}
			}
			if (flag2)
			{
				((Control)yR).Visible = true;
				((Control)yR).Enabled = true;
				((Control)yr).Visible = true;
				((Control)yr).Enabled = true;
				((Control)yp).Enabled = false;
				((Control)yQ).Enabled = false;
				((Control)yO).Height = ((Control)yr).Top - ((Control)yO).Top - 5;
			}
			else
			{
				((Control)yp).Enabled = true;
				((Control)yQ).Enabled = true;
				((Control)yO).Height = ((Control)yp).Top - ((Control)yO).Top - 5;
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Control)this).Refresh();
			try
			{
				string text = aY.a(ym);
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				StreamReader val = File.OpenText(text);
				try
				{
					yM = ((TextReader)val).ReadToEnd();
					int num = yM.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yo());
					if (num != -1)
					{
						yM = yM.Substring(0, num);
					}
					A();
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yP() + ex.Message, true);
			}
		}

		private void A()
		{
			if (!string.IsNullOrEmpty(yM))
			{
				if (!((Control)yp).Focused)
				{
					((Control)yp).Focus();
				}
				((RichTextBox)yO).ScrollBars = (RichTextBoxScrollBars)0;
				yO.A(yM);
				((RichTextBox)yO).ScrollBars = (RichTextBoxScrollBars)2;
				yO.A();
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (((CheckBox)yR).Checked)
			{
				((Control)yp).Enabled = true;
				((Control)yQ).Enabled = true;
			}
			else
			{
				((Control)yp).Enabled = false;
				((Control)yQ).Enabled = false;
			}
		}

		private void A(object P_0, LinkLabelLinkClickedEventArgs P_1)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((Form)new Bh()).ShowDialog((IWin32Window)(object)this);
		}

		private void A(object P_0, LinkClickedEventArgs P_1)
		{
			Process.Start(P_1.LinkText);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && yn != null)
			{
				((System.IDisposable)yn).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d1: Expected O, but got Unknown
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0423: Unknown result type (might be due to invalid IL or missing references)
			//IL_047b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Expected O, but got Unknown
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a8: Expected O, but got Unknown
			yO = new ag();
			yo = new Label();
			yP = new Label();
			yp = new ThemedButton();
			yQ = new ThemedButton();
			yq = new ThemedButton();
			yR = new aP();
			yr = new LinkLabel();
			((Control)this).SuspendLayout();
			((TextBoxBase)yO).BorderStyle = (BorderStyle)0;
			((Control)yO).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			((Control)yO).Location = new Point(14, 63);
			((Control)yO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gs();
			((TextBoxBase)yO).ReadOnly = true;
			((RichTextBox)yO).ScrollBars = (RichTextBoxScrollBars)2;
			((Control)yO).Size = new Size(367, 186);
			((Control)yO).TabIndex = 3;
			((Control)yO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
			((RichTextBox)yO).LinkClicked += new LinkClickedEventHandler(A);
			((Control)yo).Location = new Point(12, 9);
			((Control)yo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GA();
			((Control)yo).Size = new Size(369, 38);
			((Control)yo).TabIndex = 7;
			((Control)yo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yp();
			((Control)yP).AutoSize = true;
			((Control)yP).Location = new Point(14, 47);
			((Control)yP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)yP).Size = new Size(80, 13);
			((Control)yP).TabIndex = 8;
			((Control)yP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yQ();
			((Button)yp).DialogResult = (DialogResult)6;
			((Control)yp).Enabled = false;
			((Control)yp).Location = new Point(14, 321);
			((Control)yp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yq();
			((Control)yp).Size = new Size(90, 25);
			((Control)yp).TabIndex = 0;
			((Control)yp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yR();
			((ButtonBase)yp).UseVisualStyleBackColor = true;
			((Button)yQ).DialogResult = (DialogResult)7;
			((Control)yQ).Enabled = false;
			((Control)yQ).Location = new Point(124, 321);
			((Control)yQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yr();
			((Control)yQ).Size = new Size(160, 25);
			((Control)yQ).TabIndex = 1;
			((Control)yQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yS();
			((ButtonBase)yQ).UseVisualStyleBackColor = true;
			((Button)yq).DialogResult = (DialogResult)2;
			((Control)yq).Location = new Point(301, 321);
			((Control)yq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)yq).Size = new Size(80, 25);
			((Control)yq).TabIndex = 2;
			((Control)yq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)yq).UseVisualStyleBackColor = true;
			((Control)yR).Enabled = false;
			((Control)yR).Location = new Point(15, 289);
			((Control)yR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ys();
			((Control)yR).Size = new Size(366, 26);
			((Control)yR).TabIndex = 9;
			((Control)yR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yT();
			((ButtonBase)yR).TextAlign = (ContentAlignment)1;
			((ButtonBase)yR).UseVisualStyleBackColor = true;
			((Control)yR).Visible = false;
			((CheckBox)yR).CheckedChanged += new EventHandler(a);
			((Control)yr).Enabled = false;
			yr.LinkArea = new LinkArea(4, 4);
			((Control)yr).Location = new Point(15, 253);
			((Control)yr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yt();
			((Control)yr).Size = new Size(366, 40);
			((Control)yr).TabIndex = 10;
			yr.TabStop = true;
			((Control)yr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yU();
			yr.UseCompatibleTextRendering = true;
			((Control)yr).Visible = false;
			yr.LinkClicked += new LinkLabelLinkClickedEventHandler(A);
			((Form)this).AcceptButton = (IButtonControl)(object)yp;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)yq;
			((Form)this).ClientSize = new Size(393, 355);
			((Control)this).Controls.Add((Control)(object)yr);
			((Control)this).Controls.Add((Control)(object)yR);
			((Control)this).Controls.Add((Control)(object)yq);
			((Control)this).Controls.Add((Control)(object)yQ);
			((Control)this).Controls.Add((Control)(object)yp);
			((Control)this).Controls.Add((Control)(object)yP);
			((Control)this).Controls.Add((Control)(object)yo);
			((Control)this).Controls.Add((Control)(object)yO);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yu();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yV();
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class ba : Form
	{
		private Framework yS;

		private string ys;

		private IContainer yT;

		private ThemedButton yt;

		private ThemedButton yU;

		private ThemedTextBox yu;

		private ThemedTextBox yV;

		private ThemedTextBox yv;

		private ThemedTextBox yW;

		private ThemedTextBox yw;

		private ThemedTextBox yX;

		private Label yx;

		private Label yY;

		private Label yy;

		private Label yZ;

		private Label yz;

		private Label ZA;

		private Label Za;

		internal ba(Framework P_0, string P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			B();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
				else if (val is ThemedTextBox)
				{
					val.BackColor = BM.to;
					val.ForeColor = BM.te;
				}
			}
			yS = P_0;
			ys = P_1;
			a();
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			try
			{
				if (string.IsNullOrWhiteSpace(((Control)yu).Text))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yv(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yW(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				try
				{
					if (new MailAddress(((Control)yu).Text).Address != ((Control)yu).Text)
					{
						throw new FormatException();
					}
				}
				catch (FormatException)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yX(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (string.IsNullOrWhiteSpace(((Control)yw).Text))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yx(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yY(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (string.IsNullOrWhiteSpace(((Control)yX).Text))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yy(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yZ(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				A();
				A(ys + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yz());
				bool flag = false;
				try
				{
					WebClient val2 = new WebClient();
					try
					{
						Stream val3 = val2.OpenRead(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZA());
						try
						{
							flag = true;
						}
						finally
						{
							((System.IDisposable)val3)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
				}
				catch
				{
					flag = false;
				}
				if (flag)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Za(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZB(), (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zb(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZB(), (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				((Form)this).DialogResult = (DialogResult)1;
				((Form)this).Close();
			}
			catch (System.Exception ex)
			{
				bE.A((IWin32Window)(object)this, ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void A()
		{
			try
			{
				if (((Control)yu).Text != null)
				{
					Settings.Default.UserEmail = ((Control)yu).Text;
				}
				if (((Control)yV).Text != null)
				{
					Settings.Default.UserFirstName = ((Control)yV).Text;
				}
				if (((Control)yv).Text != null)
				{
					Settings.Default.UserLastName = ((Control)yv).Text;
				}
				if (((Control)yW).Text != null)
				{
					Settings.Default.UserPhone = ((Control)yW).Text;
				}
				((SettingsBase)Settings.Default).Save();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZC() + ex.Message, true);
			}
		}

		private void a()
		{
			try
			{
				((Control)yu).Text = Settings.Default.UserEmail;
				((Control)yV).Text = Settings.Default.UserFirstName;
				((Control)yv).Text = Settings.Default.UserLastName;
				((Control)yW).Text = Settings.Default.UserPhone;
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zc() + ex.Message, true);
			}
		}

		private void A(string P_0)
		{
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected O, but got Unknown
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected O, but got Unknown
			bool flag = true;
			string text = ((Control)yu).Text;
			string text2 = ((Control)yV).Text;
			string text3 = ((Control)yv).Text;
			string text4 = ((Control)yW).Text;
			string text5 = ((Control)yw).Text;
			string text6 = ((Control)yX).Text;
			string text7 = aY.A(Assembly.GetEntryAssembly().GetName().Version);
			string text8 = bx.C(yS.awZ, yS.awz);
			string aXc = yS.aXc;
			string text9 = ((object)yS.aXA).ToString();
			Dictionary<string, string> obj = new Dictionary<string, string>();
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZD(), flag.ToString());
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zd(), text);
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZE(), text2);
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ze(), text3);
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZF(), text4);
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zf(), text5);
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT(), text6);
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZG(), text7);
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zg(), text8);
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZH(), aXc);
			obj.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zh(), text9);
			MemoryStream val = new MemoryStream();
			XmlWriterSettings val2 = new XmlWriterSettings();
			val2.ConformanceLevel = (ConformanceLevel)2;
			val2.CloseOutput = false;
			val2.Indent = true;
			val2.NewLineChars = Environment.NewLine;
			XmlWriter val3 = XmlWriter.Create((Stream)(object)val, val2);
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZI());
			Enumerator<string, string> enumerator = obj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> current = enumerator.Current;
					val3.WriteStartElement(current.Key);
					val3.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LH(), current.Value);
					val3.WriteEndElement();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			val3.WriteEndElement();
			val3.Close();
			((Stream)val).Flush();
			StreamWriter val4 = new StreamWriter(P_0);
			try
			{
				((Stream)val).Position = 0L;
				StreamReader val5 = new StreamReader((Stream)(object)val);
				try
				{
					string text10 = ((TextReader)val5).ReadToEnd();
					((TextWriter)val4).Write(text10);
				}
				finally
				{
					((System.IDisposable)val5)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
			((Stream)val).Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && yT != null)
			{
				((System.IDisposable)yT).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void B()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected O, but got Unknown
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0523: Unknown result type (might be due to invalid IL or missing references)
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_0587: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0615: Unknown result type (might be due to invalid IL or missing references)
			//IL_0647: Unknown result type (might be due to invalid IL or missing references)
			//IL_066f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0783: Unknown result type (might be due to invalid IL or missing references)
			//IL_078d: Expected O, but got Unknown
			yt = new ThemedButton();
			yU = new ThemedButton();
			yu = new ThemedTextBox();
			yV = new ThemedTextBox();
			yv = new ThemedTextBox();
			yW = new ThemedTextBox();
			yw = new ThemedTextBox();
			yX = new ThemedTextBox();
			yx = new Label();
			yY = new Label();
			yy = new Label();
			yZ = new Label();
			yz = new Label();
			ZA = new Label();
			Za = new Label();
			((Control)this).SuspendLayout();
			((Control)yt).Location = new Point(440, 339);
			((Control)yt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zi();
			((Control)yt).Size = new Size(100, 35);
			((Control)yt).TabIndex = 6;
			((Control)yt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZJ();
			((ButtonBase)yt).UseVisualStyleBackColor = true;
			((Control)yt).Click += new EventHandler(a);
			((Button)yU).DialogResult = (DialogResult)2;
			((Control)yU).Location = new Point(546, 339);
			((Control)yU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)yU).Size = new Size(100, 35);
			((Control)yU).TabIndex = 7;
			((Control)yU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)yU).UseVisualStyleBackColor = true;
			((Control)yU).Click += new EventHandler(A);
			((Control)yu).Location = new Point(146, 6);
			((Control)yu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zj();
			((Control)yu).Size = new Size(500, 22);
			((Control)yu).TabIndex = 0;
			((Control)yV).Location = new Point(146, 34);
			((Control)yV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZK();
			((Control)yV).Size = new Size(500, 22);
			((Control)yV).TabIndex = 1;
			((Control)yv).Location = new Point(146, 62);
			((Control)yv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zk();
			((Control)yv).Size = new Size(500, 22);
			((Control)yv).TabIndex = 2;
			((Control)yW).Location = new Point(146, 90);
			((Control)yW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZL();
			((Control)yW).Size = new Size(500, 22);
			((Control)yW).TabIndex = 3;
			((Control)yw).Location = new Point(146, 118);
			((Control)yw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zl();
			((Control)yw).Size = new Size(500, 22);
			((Control)yw).TabIndex = 4;
			((TextBox)yX).AcceptsReturn = true;
			((Control)yX).Location = new Point(146, 146);
			((TextBoxBase)yX).Multiline = true;
			((Control)yX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZM();
			((Control)yX).Size = new Size(500, 150);
			((Control)yX).TabIndex = 5;
			((Control)yx).AutoSize = true;
			((Control)yx).Location = new Point(12, 10);
			((Control)yx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)yx).Size = new Size(86, 13);
			((Control)yx).TabIndex = 8;
			((Control)yx).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zm();
			((Control)yY).AutoSize = true;
			((Control)yY).Location = new Point(12, 38);
			((Control)yY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)yY).Size = new Size(61, 13);
			((Control)yY).TabIndex = 9;
			((Control)yY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZN();
			((Control)yy).AutoSize = true;
			((Control)yy).Location = new Point(12, 66);
			((Control)yy).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)yy).Size = new Size(59, 13);
			((Control)yy).TabIndex = 10;
			((Control)yy).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zn();
			((Control)yZ).AutoSize = true;
			((Control)yZ).Location = new Point(12, 94);
			((Control)yZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)yZ).Size = new Size(84, 13);
			((Control)yZ).TabIndex = 11;
			((Control)yZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZO();
			((Control)yz).AutoSize = true;
			((Control)yz).Location = new Point(12, 122);
			((Control)yz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Io();
			((Control)yz).Size = new Size(53, 13);
			((Control)yz).TabIndex = 12;
			((Control)yz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zo();
			((Control)ZA).AutoSize = true;
			((Control)ZA).Location = new Point(12, 150);
			((Control)ZA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ip();
			((Control)ZA).Size = new Size(120, 13);
			((Control)ZA).TabIndex = 13;
			((Control)ZA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZP();
			((Control)Za).AutoSize = true;
			((Control)Za).Location = new Point(143, 309);
			((Control)Za).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iq();
			((Control)Za).Size = new Size(470, 13);
			((Control)Za).TabIndex = 14;
			((Control)Za).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zp();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)yU;
			((Form)this).ClientSize = new Size(664, 388);
			((Control)this).Controls.Add((Control)(object)Za);
			((Control)this).Controls.Add((Control)(object)ZA);
			((Control)this).Controls.Add((Control)(object)yz);
			((Control)this).Controls.Add((Control)(object)yZ);
			((Control)this).Controls.Add((Control)(object)yy);
			((Control)this).Controls.Add((Control)(object)yY);
			((Control)this).Controls.Add((Control)(object)yx);
			((Control)this).Controls.Add((Control)(object)yX);
			((Control)this).Controls.Add((Control)(object)yw);
			((Control)this).Controls.Add((Control)(object)yW);
			((Control)this).Controls.Add((Control)(object)yv);
			((Control)this).Controls.Add((Control)(object)yV);
			((Control)this).Controls.Add((Control)(object)yu);
			((Control)this).Controls.Add((Control)(object)yU);
			((Control)this).Controls.Add((Control)(object)yt);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZQ();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pM();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
