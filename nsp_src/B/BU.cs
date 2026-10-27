using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using C;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace B
{
	internal class BU : Form
	{
		private static readonly string vw = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WB();

		private IContainer vX;

		private aP vx;

		private ThemedButton vY;

		private ThemedButton vy;

		private Label vZ;

		internal BU()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			a();
			((Control)this).BackColor = BM.td;
			((Control)vx).ForeColor = BM.te;
			((Control)vZ).ForeColor = BM.te;
		}

		private void A(object P_0, EventArgs P_1)
		{
			((CheckBox)vx).Checked = false;
			((Control)vY).Focus();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((Form)this).DialogResult == 1 && ((CheckBox)vx).Checked)
			{
				if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				else if (!File.Exists(vw))
				{
					((Stream)File.Create(vw)).Close();
				}
				List<string> val = new List<string>();
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ks() + ((CheckBox)vx).Checked);
				File.AppendAllLines(vw, (System.Collections.Generic.IEnumerable<string>)val);
			}
		}

		internal static bool A()
		{
			if (File.Exists(vw))
			{
				StreamReader val = File.OpenText(vw);
				try
				{
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ks()) && bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ks().Length)))
						{
							return true;
						}
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && vX != null)
			{
				((System.IDisposable)vX).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Expected O, but got Unknown
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dc: Expected O, but got Unknown
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected O, but got Unknown
			vx = new aP();
			vY = new ThemedButton();
			vy = new ThemedButton();
			vZ = new Label();
			((Control)this).SuspendLayout();
			((Control)vx).AutoSize = true;
			((Control)vx).Location = new Point(27, 39);
			((Control)vx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KT();
			((Control)vx).Size = new Size(212, 17);
			((Control)vx).TabIndex = 2;
			((Control)vx).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KR();
			((ButtonBase)vx).UseVisualStyleBackColor = true;
			((Button)vY).DialogResult = (DialogResult)1;
			((Control)vY).Location = new Point(266, 32);
			((Control)vY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vy();
			((Control)vY).Size = new Size(102, 30);
			((Control)vY).TabIndex = 0;
			((Control)vY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vZ();
			((ButtonBase)vY).UseVisualStyleBackColor = true;
			((Button)vy).DialogResult = (DialogResult)2;
			((Control)vy).Location = new Point(383, 32);
			((Control)vy).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)vy).Size = new Size(103, 30);
			((Control)vy).TabIndex = 1;
			((Control)vy).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)vy).UseVisualStyleBackColor = true;
			((Control)vZ).AutoSize = true;
			((Control)vZ).Location = new Point(8, 9);
			((Control)vZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)vZ).Size = new Size(491, 13);
			((Control)vZ).TabIndex = 7;
			((Control)vZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vz();
			((Form)this).AcceptButton = (IButtonControl)(object)vY;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)vy;
			((Form)this).ClientSize = new Size(506, 74);
			((Form)this).ControlBox = false;
			((Control)this).Controls.Add((Control)(object)vZ);
			((Control)this).Controls.Add((Control)(object)vx);
			((Control)this).Controls.Add((Control)(object)vY);
			((Control)this).Controls.Add((Control)(object)vy);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WA();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wa();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Bu : Form
	{
		private const int vz = 10;

		private const int WA = 10;

		private Bu Wa;

		private Cs WB;

		private bool Wb;

		private IContainer WC;

		private Label Wc;

		private Label WD;

		private Label Wd;

		private ThemedButton WE;

		private LinkLabel We;

		private aF WF;

		private Label Wf;

		internal ProgressBar WG;

		internal Bu(Cs P_0, bool P_1)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected O, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			B();
			Wa = this;
			WB = P_0;
			Wb = P_1;
			((Control)this).BackColor = BM.td;
			((Control)WF).BackColor = BM.tH;
			((Control)WD).ForeColor = BM.te;
			((Control)Wc).Font = new Font(((Control)Wc).Font.FontFamily, ((Control)Wc).Font.Size, (FontStyle)4);
			((Control)Wc).ForeColor = BM.te;
			((Control)Wd).ForeColor = BM.te;
			((Control)We).ForeColor = BM.te;
			((Control)Wf).ForeColor = BM.te;
			((Control)WG).BackColor = BM.tE;
			((Control)WG).ForeColor = BM.te;
			((Control)Wc).Text = WB.BcX;
			((Control)Wd).Text = WB.Bcx;
			A();
		}

		private void A()
		{
			((Control)WD).Width = ((Control)this).Width - 20;
			((Control)Wd).Width = ((Control)this).Width - 20;
			((Control)We).Width = ((Control)this).Width - 20;
			((Control)Wf).Width = ((Control)this).Width - 20;
			((Control)WD).Left = ((Control)WF).Width / 2 - ((Control)WD).Width / 2;
			((Control)WD).Top = 10;
			((Control)WG).Left = ((Control)WF).Width / 2 - ((Control)WG).Width / 2;
			((Control)WG).Top = ((Control)WF).Height / 2 - ((Control)WG).Height * 2 - 10;
			((Control)Wc).Left = ((Control)WF).Width / 2 - ((Control)Wc).Width / 2;
			((Control)Wc).Top = ((Control)WD).Bottom;
			((Control)Wd).Left = ((Control)WF).Width / 2 - ((Control)Wd).Width / 2;
			((Control)Wd).Top = ((Control)WG).Bottom + 10;
			((Control)We).Left = ((Control)WF).Width / 2 - ((Control)We).Width / 2;
			((Control)We).Top = ((Control)WF).Height - ((Control)We).Height - 10;
			((Control)WE).Top = ((Control)We).Top - 10 - ((Control)WE).Height;
			((Control)WE).Left = ((Control)WF).Width / 2 - ((Control)WE).Width / 2;
			((Control)Wf).Top = ((Control)WE).Top - 10 - ((Control)Wf).Height;
			((Control)Wf).Left = ((Control)WF).Width / 2 - ((Control)Wf).Width / 2;
		}

		internal void a()
		{
			((Control)Wc).Text = WB.BcX;
			((Control)Wd).Text = WB.Bcx;
			((Control)We).Text = (WB.BcY ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WC() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wb());
			((Control)this).Refresh();
		}

		internal void A(bool P_0)
		{
			if (P_0)
			{
				((Control)WD).Visible = false;
				((Control)Wc).Visible = false;
				((Control)We).Visible = false;
				((Control)WE).Visible = false;
				((Control)Wf).Visible = false;
				((Control)WG).Visible = true;
				((Control)Wd).Visible = true;
			}
			else
			{
				((Control)WD).Visible = true;
				((Control)Wc).Visible = true;
				((Control)We).Visible = true;
				((Control)WE).Visible = true;
				((Control)Wf).Visible = true;
				((Control)WG).Visible = false;
				((Control)Wd).Visible = false;
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			if (Wb)
			{
				A(false);
				return;
			}
			A(true);
			if (!WB.A(Wa))
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wc(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((Form)this).Close();
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			A();
		}

		private void A(object P_0, LinkLabelLinkClickedEventArgs P_1)
		{
			Process.Start(((Control)We).Text);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && WC != null)
			{
				((System.IDisposable)WC).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void B()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected O, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Unknown result type (might be due to invalid IL or missing references)
			//IL_0370: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Expected O, but got Unknown
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Expected O, but got Unknown
			//IL_04db: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e5: Expected O, but got Unknown
			WF = new aF();
			Wf = new Label();
			WG = new ProgressBar();
			Wc = new Label();
			WD = new Label();
			Wd = new Label();
			WE = new ThemedButton();
			We = new LinkLabel();
			((Control)WF).SuspendLayout();
			((Control)this).SuspendLayout();
			((ScrollableControl)WF).AutoScroll = true;
			((Control)WF).Controls.Add((Control)(object)Wf);
			((Control)WF).Controls.Add((Control)(object)WG);
			((Control)WF).Controls.Add((Control)(object)Wc);
			((Control)WF).Controls.Add((Control)(object)WD);
			((Control)WF).Controls.Add((Control)(object)Wd);
			((Control)WF).Controls.Add((Control)(object)WE);
			((Control)WF).Controls.Add((Control)(object)We);
			((Control)WF).Dock = (DockStyle)5;
			((Control)WF).Location = new Point(0, 0);
			((Control)WF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WD();
			((Control)WF).Size = new Size(384, 261);
			((Control)WF).TabIndex = 8;
			((Control)Wf).Location = new Point(15, 149);
			((Control)Wf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wd();
			((Control)Wf).Size = new Size(269, 20);
			((Control)Wf).TabIndex = 8;
			((Control)Wf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WE();
			Wf.TextAlign = (ContentAlignment)32;
			((Control)WG).Location = new Point(36, 29);
			((Control)WG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.We();
			((Control)WG).Size = new Size(217, 23);
			((Control)WG).TabIndex = 0;
			((Control)Wc).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WF(), 72f, (FontStyle)4, (GraphicsUnit)3, (byte)0);
			((Control)Wc).Location = new Point(3, 92);
			((Control)Wc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wf();
			((Control)Wc).Size = new Size(223, 120);
			((Control)Wc).TabIndex = 1;
			((Control)Wc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WG();
			Wc.TextAlign = (ContentAlignment)32;
			((Control)WD).Location = new Point(207, 92);
			((Control)WD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wg();
			((Control)WD).Size = new Size(165, 20);
			((Control)WD).TabIndex = 2;
			((Control)WD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WH();
			WD.TextAlign = (ContentAlignment)32;
			((Control)Wd).Location = new Point(33, 29);
			((Control)Wd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wh();
			((Control)Wd).Size = new Size(203, 20);
			((Control)Wd).TabIndex = 3;
			((Control)Wd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WI();
			Wd.TextAlign = (ContentAlignment)32;
			((Button)WE).DialogResult = (DialogResult)1;
			((Control)WE).Location = new Point(0, 0);
			((Control)WE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)WE).Size = new Size(75, 23);
			((Control)WE).TabIndex = 6;
			((Control)WE).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)WE).UseVisualStyleBackColor = true;
			((Control)We).Location = new Point(88, 69);
			((Control)We).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wi();
			((Control)We).Size = new Size(184, 20);
			((Control)We).TabIndex = 7;
			We.TabStop = true;
			((Control)We).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WJ();
			((Label)We).TextAlign = (ContentAlignment)32;
			We.LinkClicked += new LinkLabelLinkClickedEventHandler(A);
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(384, 261);
			((Control)this).Controls.Add((Control)(object)WF);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wj();
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WK();
			((Form)this).Shown += new EventHandler(A);
			((Control)this).Resize += new EventHandler(a);
			((Control)WF).ResumeLayout(false);
			((Control)this).ResumeLayout(false);
		}
	}
}
namespace b
{
	internal enum bU : byte
	{
		aWc = 0,
		aWD = 1,
		aWd = 2,
		aWE = 4,
		aWe = 8,
		aWF = 0x10
	}
	internal class bu
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A BrA = new A();

			public static Func<byte, string> Bra;

			internal string A(byte P_0)
			{
				return P_0.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di());
			}
		}

		private bt aWf;

		private k aWG;

		private byte aWg;

		private byte[] aWH;

		internal bu(bt P_0)
		{
			aWf = P_0;
		}

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agu() + ((object)aWf).ToString();
		}

		[SpecialName]
		internal bt A()
		{
			return aWf;
		}

		[SpecialName]
		internal k a()
		{
			return aWG;
		}

		[SpecialName]
		internal void A(k P_0)
		{
			aWG = P_0;
		}

		[SpecialName]
		internal string B()
		{
			if (aWH == null)
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
			}
			return string.Join(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), Enumerable.Select<byte, string>((System.Collections.Generic.IEnumerable<byte>)aWH, (Func<byte, string>)((byte P_0) => P_0.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di()))));
		}

		[SpecialName]
		internal void A(byte[] P_0)
		{
			aWH = Enumerable.ToArray<byte>((System.Collections.Generic.IEnumerable<byte>)P_0);
		}

		[SpecialName]
		internal byte b()
		{
			return aWg;
		}

		[SpecialName]
		internal void A(byte P_0)
		{
			aWg = P_0;
		}

		internal bool C()
		{
			return aWg == 0;
		}

		internal bool c()
		{
			return (aWg & 1) != 0;
		}

		internal bool D()
		{
			return (aWg & 2) != 0;
		}

		internal bool d()
		{
			return (aWg & 4) != 0;
		}

		internal bool E()
		{
			return (aWg & 8) != 0;
		}

		internal bool e()
		{
			return (aWg & 0x10) != 0;
		}

		internal bool F()
		{
			if (e())
			{
				return d();
			}
			return false;
		}

		internal string f()
		{
			return aWf switch
			{
				bt.avk => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agV(), 
				bt.avL => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agv(), 
				bt.avR => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agW(), 
				bt.avl => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agw(), 
				bt.avM => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agX(), 
				bt.avm => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agx(), 
				bt.avN => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agY(), 
				bt.avt => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agy(), 
				bt.avO => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agZ(), 
				bt.avn => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agz(), 
				bt.avp => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHA(), 
				bt.avQ => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHa(), 
				bt.avq => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHB(), 
				bt.avr => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHb(), 
				bt.avS => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHb(), 
				bt.avs => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHC(), 
				bt.avT => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHC(), 
				bt.aWA => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHc(), 
				bt.avU => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHD(), 
				bt.avu => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHd(), 
				bt.avV => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHE(), 
				bt.avv => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHe(), 
				bt.avW => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHF(), 
				bt.avw => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHf(), 
				bt.avX => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHG(), 
				bt.avx => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHg(), 
				bt.avY => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHH(), 
				bt.avy => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHh(), 
				_ => null, 
			};
		}

		internal static Cg A(bt P_0)
		{
			return P_0 switch
			{
				bt.avk => Cg.BAC, 
				bt.avL => Cg.BAc, 
				bt.avR => Cg.BAj, 
				bt.avl => Cg.BAD, 
				bt.avM => Cg.BAd, 
				bt.avm => Cg.BAE, 
				bt.avN => Cg.BAe, 
				bt.avO => Cg.BAf, 
				bt.avn => Cg.BAF, 
				bt.avp => Cg.BAh, 
				bt.avQ => Cg.BAI, 
				bt.avq => Cg.BAi, 
				bt.avo => Cg.BAH, 
				bt.avr => Cg.BAK, 
				bt.avS => Cg.BAk, 
				bt.avs => Cg.BAL, 
				bt.avT => Cg.BAl, 
				bt.avU => Cg.BAm, 
				bt.avu => Cg.BAN, 
				bt.avV => Cg.BAn, 
				bt.avv => Cg.BAO, 
				bt.avW => Cg.BAQ, 
				bt.avw => Cg.BAq, 
				bt.avX => Cg.BAR, 
				bt.avx => Cg.BAR, 
				bt.avY => Cg.BAR, 
				bt.avy => Cg.BAR, 
				bt.aWA => Cg.BAr, 
				_ => Cg.BAB, 
			};
		}

		internal string G()
		{
			return a(aWf);
		}

		internal string g()
		{
			return B(aWf);
		}

		internal static string a(bt P_0)
		{
			return P_0 switch
			{
				bt.avk => PortFunction.B(Cg.BAC, null), 
				bt.avL => PortFunction.B(Cg.BAc, null), 
				bt.avR => PortFunction.B(Cg.BAj, null), 
				bt.avl => PortFunction.B(Cg.BAD, null), 
				bt.avM => PortFunction.B(Cg.BAd, null), 
				bt.avm => PortFunction.B(Cg.BAE, null), 
				bt.avN => PortFunction.B(Cg.BAe, null), 
				bt.avO => PortFunction.B(Cg.BAf, null), 
				bt.avn => PortFunction.B(Cg.BAF, null), 
				bt.avp => PortFunction.B(Cg.BAh, null), 
				bt.avQ => PortFunction.B(Cg.BAI, null), 
				bt.avq => PortFunction.B(Cg.BAi, null), 
				bt.avo => PortFunction.B(Cg.BAH, null), 
				bt.avr => PortFunction.B(Cg.BAK, null), 
				bt.avS => PortFunction.B(Cg.BAk, null), 
				bt.avs => PortFunction.B(Cg.BAL, null), 
				bt.avT => PortFunction.B(Cg.BAl, null), 
				bt.avt => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHI(), 
				bt.aWA => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHi(), 
				bt.avU => PortFunction.B(Cg.BAm, null), 
				bt.avu => PortFunction.B(Cg.BAN, null), 
				bt.avV => PortFunction.B(Cg.BAn, null), 
				bt.avv => PortFunction.B(Cg.BAO, null), 
				bt.avW => PortFunction.B(Cg.BAQ, null), 
				bt.avw => PortFunction.B(Cg.BAq, null), 
				bt.avX => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHJ(), 
				bt.avx => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHj(), 
				bt.avY => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHK(), 
				bt.avy => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHk(), 
				_ => string.Empty, 
			};
		}

		internal static string B(bt P_0)
		{
			return P_0 switch
			{
				bt.avk => PortFunction.b(Cg.BAC, null), 
				bt.avL => PortFunction.b(Cg.BAc, null), 
				bt.avR => PortFunction.b(Cg.BAj, null), 
				bt.avl => PortFunction.b(Cg.BAD, null), 
				bt.avM => PortFunction.b(Cg.BAd, null), 
				bt.avm => PortFunction.b(Cg.BAE, null), 
				bt.avN => PortFunction.b(Cg.BAe, null), 
				bt.avO => PortFunction.b(Cg.BAf, null), 
				bt.avn => PortFunction.b(Cg.BAF, null), 
				bt.avp => PortFunction.b(Cg.BAh, null), 
				bt.avQ => PortFunction.b(Cg.BAI, null), 
				bt.avq => PortFunction.b(Cg.BAi, null), 
				bt.avo => PortFunction.b(Cg.BAH, null), 
				bt.avr => PortFunction.b(Cg.BAK, null), 
				bt.avS => PortFunction.b(Cg.BAk, null), 
				bt.avs => PortFunction.b(Cg.BAL, null), 
				bt.avT => PortFunction.b(Cg.BAl, null), 
				bt.avt => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHL(), 
				bt.aWA => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHl(), 
				bt.avU => PortFunction.b(Cg.BAm, null), 
				bt.avu => PortFunction.b(Cg.BAN, null), 
				bt.avV => PortFunction.b(Cg.BAn, null), 
				bt.avv => PortFunction.b(Cg.BAO, null), 
				bt.avW => PortFunction.b(Cg.BAQ, null), 
				bt.avw => PortFunction.b(Cg.BAq, null), 
				bt.avX => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHM(), 
				bt.avx => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHm(), 
				bt.avY => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHN(), 
				bt.avy => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHn(), 
				_ => string.Empty, 
			};
		}
	}
}
