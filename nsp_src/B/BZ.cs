using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace B
{
	internal class BZ : Form
	{
		private delegate void A(object P_0, ElapsedEventArgs P_1);

		private delegate void a(object P_0, EventArgs P_1);

		private Framework yB;

		private ThemedButton yb = new ThemedButton();

		private ThemedButton yC = new ThemedButton();

		private ProgressBar yc = new ProgressBar();

		private int yD = -1;

		internal static MenuNode yd = null;

		private Timer yE = new Timer();

		private static object ye = new object();

		private IContainer yF;

		internal BZ()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Expected O, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Expected O, but got Unknown
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Expected O, but got Unknown
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Expected O, but got Unknown
			c();
			((Control)yb).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yB();
			((Control)yb).AutoSize = false;
			((Control)yb).Width = 100;
			((Control)yb).Height = 25;
			((Control)yb).Left = 5;
			ThemedButton themedButton = yb;
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			((Control)themedButton).Top = ((Rectangle)(ref clientRectangle)).Height - 5 - ((Control)yb).Height;
			((Control)this).Controls.Add((Control)(object)yb);
			((Control)yb).Click += new EventHandler(C);
			((Control)yC).AutoSize = false;
			((Control)yC).Width = 100;
			((Control)yC).Height = 25;
			ThemedButton themedButton2 = yC;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)themedButton2).Left = ((Rectangle)(ref clientRectangle)).Width - 5 - ((Control)yC).Width;
			ThemedButton themedButton3 = yC;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)themedButton3).Top = ((Rectangle)(ref clientRectangle)).Height - 5 - ((Control)yC).Height;
			((Control)this).Controls.Add((Control)(object)yC);
			((Control)yC).Click += new EventHandler(c);
			yc.Minimum = 0;
			((Control)yc).Width = ((Control)yC).Left - 70 - (((Control)yb).Right + 70);
			((Control)yc).Height = 10;
			((Control)yc).Left = ((Control)yb).Right + 70;
			ProgressBar obj = yc;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)obj).Top = ((Rectangle)(ref clientRectangle)).Height - 22;
			((Control)this).Controls.Add((Control)(object)yc);
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			yD = b();
			C();
			BM.C(new EventHandler(a));
			BM.E(new EventHandler(b));
			yE.Interval = 200.0;
			yE.SynchronizingObject = (ISynchronizeInvoke)(object)this;
			yE.Elapsed += new ElapsedEventHandler(A);
			yE.Start();
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			BM.V(null, null);
			BM.c(new EventHandler(a));
			BM.C(new EventHandler(a));
			BM.e(new EventHandler(b));
			BM.E(new EventHandler(b));
			yE.Elapsed -= new ElapsedEventHandler(A);
			yE.Elapsed += new ElapsedEventHandler(A);
			C();
		}

		private void a(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			BM.c(new EventHandler(a));
			BM.e(new EventHandler(b));
			yE.Elapsed -= new ElapsedEventHandler(A);
			yd = null;
			BM.V(null, null);
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			if (!((Control)this).Visible)
			{
				BM.c(new EventHandler(a));
				BM.e(new EventHandler(b));
				yE.Elapsed -= new ElapsedEventHandler(A);
				yd = null;
			}
			BM.V(null, null);
		}

		[SpecialName]
		internal static bool A()
		{
			return yd != null;
		}

		[SpecialName]
		internal Framework a()
		{
			return yB;
		}

		[SpecialName]
		internal void A(Framework P_0)
		{
			yB = P_0;
			if (yB != null)
			{
				((Control)this).Text = yB.awm.E();
				yc.Maximum = yB.awm.c().Count;
				if (yD == -1)
				{
					yD = b();
				}
				C();
			}
		}

		private void A(object P_0, ElapsedEventArgs P_1)
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			if (yB == null)
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
			bool flag = false;
			try
			{
				Monitor.TryEnter(ye, ref flag);
				if (!flag)
				{
					return;
				}
				Enumerator<string, CB> enumerator = yB.awn.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.b();
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(ye);
				}
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = b;
					((Control)this).BeginInvoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			C();
		}

		private int B()
		{
			if (yB != null)
			{
				for (int num = yD - 1; num >= 0; num--)
				{
					if (!yB.awm.c()[num].J(true) || MenuNode.A(yB.awm.c()[num]))
					{
						return num;
					}
				}
			}
			return yD;
		}

		private int b()
		{
			if (yB != null)
			{
				for (int i = yD + 1; i < yB.awm.c().Count; i++)
				{
					if (!yB.awm.c()[i].J(true) || MenuNode.A(yB.awm.c()[i]))
					{
						return i;
					}
				}
			}
			return yD;
		}

		private void C(object P_0, EventArgs P_1)
		{
			int num = yD;
			yD = B();
			if (yD < num)
			{
				C();
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			int num = yD;
			yD = b();
			if (yD > num)
			{
				C();
			}
			else
			{
				((Control)this).Hide();
			}
		}

		private void C()
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Unknown
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Expected O, but got Unknown
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
			if (yD < 0)
			{
				return;
			}
			if (yD <= yc.Maximum)
			{
				yc.Value = yD;
			}
			((Control)this).SuspendLayout();
			while (((ArrangedElementCollection)((Control)this).Controls).Count > 3)
			{
				foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val = item;
					if (val != yb && val != yC && val != yc)
					{
						((Component)val).Dispose();
						break;
					}
				}
			}
			((Control)this).ResumeLayout(true);
			if (yB == null || yB.awm.c().Count <= yD)
			{
				return;
			}
			((Control)this).SuspendLayout();
			if (yD == b())
			{
				((Control)yC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yb();
			}
			else
			{
				((Control)yC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yC();
			}
			MenuNode menuNode = (yd = yB.awm.c()[yD]);
			if (BM.aE())
			{
				Label val2 = new Label();
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yc();
				((Control)val2).ForeColor = BM.tC;
				((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 8f, (FontStyle)1);
				((Control)val2).BackColor = Color.Transparent;
				((Control)val2).AutoSize = true;
				((Control)val2).Left = 20;
				((Control)val2).Top = 20;
				((Control)this).Controls.Add((Control)(object)val2);
				Label val3 = new Label();
				((Control)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yD();
				((Control)val3).ForeColor = BM.tC;
				((Control)val3).Font = new Font(((Control)val3).Font.FontFamily, 8f, (FontStyle)1);
				((Control)val3).BackColor = Color.Transparent;
				((Control)val3).AutoSize = true;
				((Control)val3).Left = 20;
				((Control)val3).Top = 50;
				((Control)this).Controls.Add((Control)(object)val3);
				((Control)yb).Enabled = false;
				((Control)yC).Enabled = false;
			}
			else
			{
				string text = menuNode.d();
				int num = menuNode.b();
				SettingOrSpecialObject settingOrSpecialObject = yB.a(num);
				Rectangle clientRectangle = ((Control)this).ClientRectangle;
				int num2 = ((Rectangle)(ref clientRectangle)).Width - 10;
				clientRectangle = ((Control)this).ClientRectangle;
				Rectangle val4 = default(Rectangle);
				((Rectangle)(ref val4))._002Ector(5, 5, num2, ((Rectangle)(ref clientRectangle)).Height - 15 - ((Control)yb).Height);
				if (!string.IsNullOrEmpty(text))
				{
					if (yB.awn.ContainsKey(text))
					{
						DA dA = new DA(yB.awn[text], yB, val4, false, false, 2f);
						((Control)this).Controls.Add((Control)(object)dA);
						dA.A(true);
					}
				}
				else if (settingOrSpecialObject != null)
				{
					CG cG = settingOrSpecialObject.e();
					if (cG != null)
					{
						if (cG is UIListObject)
						{
							DF dF = new DF(settingOrSpecialObject as SpecialObject, string.Empty, menuNode, yB, null, val4, false, false, 2f);
							((Control)this).Controls.Add((Control)(object)dF);
							dF.A(true);
						}
						else if (cG is StateMachine)
						{
							De de = new De(settingOrSpecialObject as StateMachine, yB, null, val4, false);
							((Control)this).Controls.Add((Control)(object)de);
							de.b();
						}
					}
					else if (settingOrSpecialObject.a().Count != 0)
					{
						DF dF2 = new DF(settingOrSpecialObject as SpecialObject, string.Empty, menuNode, yB, null, val4, false, false, 2f);
						((Control)this).Controls.Add((Control)(object)dF2);
						dF2.A(true);
					}
				}
				else
				{
					Enumerator<MenuNode> enumerator2 = menuNode.c().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.J())
							{
								Df df = new Df(yB, null, val4, false, false, false, 2f);
								df.A(menuNode);
								((Control)this).Controls.Add((Control)(object)df);
								df.A(true);
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				((Control)yb).Enabled = B() < yD;
				((Control)yC).Enabled = true;
			}
			((Control)this).ResumeLayout(true);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return q.A((Form)(object)this, keyData);
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			((Control)yb).Click -= new EventHandler(C);
			((Control)yC).Click -= new EventHandler(c);
			BM.e(new EventHandler(b));
			yE.Elapsed -= new ElapsedEventHandler(A);
			yE.Stop();
			((Component)yE).Dispose();
			yd = null;
			if (disposing && yF != null)
			{
				((System.IDisposable)yF).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void c()
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			((Control)this).SuspendLayout();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(604, 641);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yd();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)0;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PD();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).VisibleChanged += new EventHandler(B);
			((Control)this).ResumeLayout(false);
		}
	}
	internal class Bz : Form
	{
		private delegate void A(object P_0, EventArgs P_1);

		private delegate void a(object P_0, EventArgs P_1);

		private delegate void B(object P_0, EventArgs P_1);

		private Framework yf;

		private Setting yG;

		private ThemedButton yg = new ThemedButton();

		private ThemedButton yH = new ThemedButton();

		private ProgressBar yh = new ProgressBar();

		private ToolTip yI = new ToolTip();

		private bool yi;

		private int yJ;

		private HashSet<DataIdAndAttrId> yj = new HashSet<DataIdAndAttrId>();

		private List<Control> yK = new List<Control>();

		private List<ModifyOnChange> yk = new List<ModifyOnChange>();

		internal static MenuNode yL;

		private IContainer yl;

		internal static bool A(Framework P_0)
		{
			if (P_0.awl != null)
			{
				Setting setting = P_0.A(16035);
				if (setting != null)
				{
					return setting.ax() != 255;
				}
				return false;
			}
			return false;
		}

		internal static bool A(Framework P_0, out bool P_1, out bool P_2, out bool P_3)
		{
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Invalid comparison between Unknown and I4
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Invalid comparison between Unknown and I4
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Invalid comparison between Unknown and I4
			P_1 = false;
			P_2 = false;
			P_3 = false;
			if (A(P_0))
			{
				Setting setting = P_0.A(16035);
				if (setting.ax() == 0)
				{
					Setting setting2 = P_0.A(14691);
					int num = 0;
					if (setting2 != null)
					{
						num = setting2.ax();
					}
					P_0.A(P_0.aWS);
					setting2?.a(num, true);
					P_0.p();
				}
				if (BM.A(P_0.aXc, true))
				{
					Dh.A(P_0, out var flag);
					if (flag)
					{
						P_1 = true;
						return false;
					}
				}
				Bz bz = new Bz(P_0, setting);
				DialogResult val = ((Form)bz).ShowDialog((IWin32Window)(object)BM.QQ);
				((Component)bz).Dispose();
				if ((int)val == 3)
				{
					P_1 = true;
				}
				else
				{
					BM.QQ.i();
					if ((int)val == 2)
					{
						P_2 = true;
					}
					else if ((int)val == 5)
					{
						P_3 = true;
					}
				}
				return true;
			}
			return false;
		}

		[SpecialName]
		internal static bool A()
		{
			return yL != null;
		}

		internal Bz(Framework P_0, Setting P_1)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected O, but got Unknown
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Expected O, but got Unknown
			e();
			yf = P_0;
			yG = P_1;
			((Control)yg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yB();
			((Control)yg).AutoSize = false;
			((Control)yg).Width = 100;
			((Control)yg).Height = 25;
			((Control)yg).Left = 5;
			ThemedButton themedButton = yg;
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			((Control)themedButton).Top = ((Rectangle)(ref clientRectangle)).Height - 5 - ((Control)yg).Height;
			((Control)yg).Click += new EventHandler(B);
			((Control)this).Controls.Add((Control)(object)yg);
			((Control)yH).AutoSize = false;
			((Control)yH).Width = 100;
			((Control)yH).Height = 25;
			ThemedButton themedButton2 = yH;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)themedButton2).Left = ((Rectangle)(ref clientRectangle)).Width - 5 - ((Control)yH).Width;
			ThemedButton themedButton3 = yH;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)themedButton3).Top = ((Rectangle)(ref clientRectangle)).Height - 5 - ((Control)yH).Height;
			((Control)yH).Click += new EventHandler(b);
			((Control)this).Controls.Add((Control)(object)yH);
			yh.Minimum = 0;
			yh.Maximum = yf.awl.c().Count;
			((Control)yh).Width = ((Control)yH).Left - 70 - (((Control)yg).Right + 70);
			((Control)yh).Height = 10;
			((Control)yh).Left = ((Control)yg).Right + 70;
			ProgressBar obj = yh;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)obj).Top = ((Rectangle)(ref clientRectangle)).Height - 22;
			((Control)this).Controls.Add((Control)(object)yh);
			((Control)this).Text = yf.awl.E();
			((Control)this).MouseMove += new MouseEventHandler(A);
			BM.C(new EventHandler(a));
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			int num = yG.ax();
			yJ = num;
			C();
		}

		private void a(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Invalid comparison between Unknown and I4
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Invalid comparison between Unknown and I4
			bool flag;
			if (yG.ax() != 255)
			{
				if (BM.qY)
				{
					((Form)this).DialogResult = (DialogResult)5;
					flag = true;
				}
				else
				{
					DialogResult val = bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yE(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ye(), (MessageBoxButtons)3, (MessageBoxIcon)48, (MessageBoxDefaultButton)512, new string[3]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yF(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yf(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yG()
					});
					if ((int)val == 6)
					{
						((Form)this).DialogResult = (DialogResult)3;
						flag = true;
					}
					else if ((int)val == 7)
					{
						((Form)this).DialogResult = (DialogResult)2;
						flag = true;
						yG.a(255, true);
						BM.b(yG.A());
					}
					else
					{
						flag = false;
					}
				}
			}
			else
			{
				((Form)this).DialogResult = (DialogResult)1;
				flag = true;
			}
			if (flag)
			{
				b();
				yK.Clear();
				yL = null;
			}
			else
			{
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		private int a()
		{
			if (yf != null)
			{
				for (int num = yJ - 1; num >= 0; num--)
				{
					if (!yf.awl.c()[num].J(true))
					{
						return num;
					}
				}
			}
			return yJ;
		}

		private int B()
		{
			if (yf != null)
			{
				for (int i = yJ + 1; i <= yf.awl.c().Count; i++)
				{
					if (i >= yf.awl.c().Count || !yf.awl.c()[i].J(true))
					{
						return i;
					}
				}
			}
			return yJ;
		}

		private void B(object P_0, EventArgs P_1)
		{
			int num = yJ;
			yJ = a();
			if (yJ < num)
			{
				yG.a(yJ, true);
				BM.b(yG.A());
				C();
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			int num = yJ;
			yJ = B();
			if (yJ > num)
			{
				yG.a(yJ, true);
				BM.b(yG.A());
				C();
			}
			else
			{
				yG.a(255, true);
				BM.b(yG.A());
				((Form)this).Close();
			}
		}

		private void b()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			Enumerator<DataIdAndAttrId> enumerator = yj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataIdAndAttrId current = enumerator.Current;
					Setting setting = yf.A(current);
					if (setting != null)
					{
						setting.a(new EventHandler(C));
						((SettingOrSpecialObject)setting).a(new EventHandler(c));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<Control> enumerator2 = yK.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					Control current2 = enumerator2.Current;
					if (current2 is aG)
					{
						(current2 as aG).a(new EventHandler(D));
					}
					else if (current2 is af)
					{
						(current2 as af).a(new EventHandler(D));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			Enumerator<ModifyOnChange> enumerator3 = yk.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					enumerator3.Current.A().a(new EventHandler(C));
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
		}

		private void C()
		{
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected O, but got Unknown
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected O, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_0416: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected O, but got Unknown
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected O, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b0: Expected O, but got Unknown
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Expected O, but got Unknown
			if (yJ <= yh.Maximum)
			{
				yh.Value = yJ;
			}
			((Control)this).SuspendLayout();
			while (((ArrangedElementCollection)((Control)this).Controls).Count > 3)
			{
				foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val = item;
					if (val != yg && val != yH && val != yh)
					{
						((Component)val).Dispose();
						break;
					}
				}
			}
			((Control)this).ResumeLayout(true);
			b();
			if (yf.awl.c().Count < yJ)
			{
				return;
			}
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			int num = ((Rectangle)(ref clientRectangle)).Width - 10;
			clientRectangle = ((Control)this).ClientRectangle;
			Rectangle val2 = default(Rectangle);
			((Rectangle)(ref val2))._002Ector(5, 5, num, ((Rectangle)(ref clientRectangle)).Height - 15 - ((Control)yg).Height);
			MenuNode menuNode = null;
			if (yJ < yf.awl.c().Count)
			{
				menuNode = yf.awl.c()[yJ];
				yj.Clear();
				yj.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)menuNode.j(false));
				Enumerator<DataIdAndAttrId> enumerator2 = yj.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						DataIdAndAttrId current = enumerator2.Current;
						Setting setting = yf.A(current);
						if (setting != null)
						{
							setting.A(new EventHandler(C));
							((SettingOrSpecialObject)setting).A(new EventHandler(c));
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				yk.Clear();
				Enumerator<ModifyOnChange> enumerator3 = menuNode.ac().GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						ModifyOnChange current2 = enumerator3.Current;
						if (current2.A() == null)
						{
							continue;
						}
						yk.Add(current2);
						current2.A().a(new EventHandler(C));
						current2.A().A(new EventHandler(C));
						Enumerator<Setting> enumerator4 = current2.A(true).GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								BM.b(enumerator4.Current.A());
							}
						}
						finally
						{
							((System.IDisposable)enumerator4).Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
			}
			else
			{
				yK.Clear();
				yj.Clear();
				yk.Clear();
			}
			if (yJ == yf.awl.c().Count)
			{
				((Control)yH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yb();
				A(val2);
			}
			else
			{
				((Control)this).SuspendLayout();
				((Control)yH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yC();
				yL = menuNode;
				int num2 = menuNode.b();
				SettingOrSpecialObject settingOrSpecialObject = yf.a(num2);
				if (settingOrSpecialObject != null)
				{
					CG cG = settingOrSpecialObject.e();
					if (cG != null)
					{
						if (cG is UIListObject)
						{
							DF dF = new DF(settingOrSpecialObject as SpecialObject, string.Empty, menuNode, yf, null, val2, false, false);
							((Control)this).Controls.Add((Control)(object)dF);
							dF.A(true);
						}
						else if (cG is StateMachine)
						{
							De de = new De(settingOrSpecialObject as StateMachine, yf, null, val2, false);
							((Control)this).Controls.Add((Control)(object)de);
							de.b();
						}
					}
					else if (settingOrSpecialObject.a().Count != 0)
					{
						DF dF2 = new DF(settingOrSpecialObject as SpecialObject, string.Empty, menuNode, yf, null, val2, false, false);
						((Control)this).Controls.Add((Control)(object)dF2);
						dF2.A(true);
					}
				}
				else
				{
					Enumerator<MenuNode> enumerator5 = menuNode.c().GetEnumerator();
					try
					{
						while (enumerator5.MoveNext())
						{
							if (enumerator5.Current.J())
							{
								Df df = new Df(yf, null, val2, false, false, false);
								df.A(menuNode);
								((Control)this).Controls.Add((Control)(object)df);
								df.A(true);
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator5).Dispose();
					}
				}
				((Control)this).ResumeLayout(true);
				c();
				yK = d();
				Enumerator<Control> enumerator6 = yK.GetEnumerator();
				try
				{
					while (enumerator6.MoveNext())
					{
						Control current3 = enumerator6.Current;
						if (current3 is aG)
						{
							(current3 as aG).A(new EventHandler(D));
						}
						else if (current3 is af)
						{
							(current3 as af).A(new EventHandler(D));
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator6).Dispose();
				}
			}
			E();
			D();
		}

		private void A(Rectangle P_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected O, but got Unknown
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_0677: Expected O, but got Unknown
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b6: Expected O, but got Unknown
			//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05de: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e8: Expected O, but got Unknown
			//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0569: Unknown result type (might be due to invalid IL or missing references)
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0580: Unknown result type (might be due to invalid IL or missing references)
			//IL_0595: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).SuspendLayout();
			cq cq = new cq(P_0, false, false);
			((Control)cq).Left = ((Rectangle)(ref P_0)).Left;
			((Control)cq).Top = ((Rectangle)(ref P_0)).Top;
			((Control)cq).Width = ((Rectangle)(ref P_0)).Width;
			((Control)cq).Height = ((Rectangle)(ref P_0)).Height;
			int num = 10;
			int num2 = 10;
			int num3 = 0;
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yg();
			((Control)val).ForeColor = BM.tf;
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, 12f, (FontStyle)1);
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = num2;
			((Control)val).Top = num;
			((Control)cq.B()).Controls.Add((Control)(object)val);
			num += ((Control)val).Height + 10;
			int num4 = num;
			Enumerator<MenuNode> enumerator = yf.awl.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					if (current.J(true))
					{
						continue;
					}
					MovableResizablePanel movableResizablePanel = new MovableResizablePanel(Rectangle.Empty, false, true, true);
					int num5 = 10;
					Label val2 = new Label();
					((Control)val2).Text = current.E();
					((Control)val2).ForeColor = BM.tf;
					((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 10f, (FontStyle)1);
					((Control)val2).BackColor = Color.Transparent;
					((Control)val2).AutoSize = true;
					((Control)val2).Left = 10;
					((Control)val2).Top = num5;
					((Control)movableResizablePanel).Controls.Add((Control)(object)val2);
					num5 += ((Control)val2).Height + 10;
					Enumerator<DataIdAndAttrId> enumerator2 = current.j(false).GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							DataIdAndAttrId current2 = enumerator2.Current;
							Setting setting = yf.A(current2);
							if (setting == null || !((SettingOrSpecialObject)setting).l() || setting.am() || setting.aN())
							{
								continue;
							}
							if (PortFunction.a(((SettingOrSpecialObject)setting).D()))
							{
								SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)setting).D();
								if (!settingOrSpecialObject.l() || ((SettingOrSpecialObject)setting).D() is Table || ((SettingOrSpecialObject)setting).D() is TableAxis)
								{
									continue;
								}
								Cg bSQ = settingOrSpecialObject.F().E().BSQ;
								CH bSq = settingOrSpecialObject.F().E().BSq;
								byte bSR = settingOrSpecialObject.F().E().BSR;
								ushort bSr = settingOrSpecialObject.F().E().BSr;
								PortFunction.a a = PortFunction.a(yf, bSQ, bSq, bSR, bSr);
								List<Dn> val3 = PortFunction.A(yf, bSQ, bSq, bSR, bSr, false);
								if ((a == null && (val3 == null || val3.Count != 1)) || !PortFunction.A(setting, val3[0], a))
								{
									continue;
								}
							}
							string text = string.Empty;
							if (yf.awX.ContainsKey(setting.A()))
							{
								MenuNode menuNode = yf.awX[setting.A()];
								if (menuNode.Y() != null && menuNode.Y().BcF != null)
								{
									MenuNode menuNode2 = MenuNode.A(current.c(), setting.C());
									if (menuNode2 != null)
									{
										Cn bcF = menuNode.Y().BcF;
										if (menuNode2.Q() && !string.IsNullOrWhiteSpace(menuNode2.E()))
										{
											string text2 = (menuNode2.E().ToLower().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yH()) ? menuNode2.E().Substring(menuNode2.E().ToLower().IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yH()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yH().Length) : ((!menuNode2.E().ToLower().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yh())) ? menuNode2.E() : menuNode2.E().Substring(menuNode2.E().ToLower().IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yh()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yh().Length)));
											text = text + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fT();
										}
										string bsP = bcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP;
										if (bsP.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()) && !string.IsNullOrWhiteSpace(text))
										{
											text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
										}
										text += bsP;
									}
								}
							}
							else
							{
								text = text + ((SettingOrSpecialObject)setting).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fT();
								if (setting.al())
								{
									continue;
								}
								if (setting.c() != 0)
								{
									string text3 = setting.ay();
									if (text3.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()))
									{
										text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
									}
									text += text3;
								}
								else if (setting is Dn)
								{
									int num6 = setting.ax();
									if (num6 == 0)
									{
										text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yI();
									}
									else
									{
										CH cH = PortFunction.a((uint)num6);
										if (cH == CH.Bal)
										{
											text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IZ();
										}
										else
										{
											Cg cg = PortFunction.A((uint)num6);
											byte b = PortFunction.B((uint)num6);
											ushort num7 = PortFunction.b((uint)num6);
											SettingOrSpecialObject settingOrSpecialObject2 = PortFunction.A(yf, cg, cH, b, num7);
											if (settingOrSpecialObject2 != null)
											{
												text += PortFunction.B(settingOrSpecialObject2);
											}
										}
									}
								}
								else
								{
									ValueTuple<string, string, bool> val4 = setting.aX();
									text += val4.Item1;
									if (!string.IsNullOrEmpty(val4.Item2))
									{
										text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + val4.Item2;
									}
								}
							}
							if (!string.IsNullOrWhiteSpace(text))
							{
								Label val5 = new Label();
								((Control)val5).Text = text;
								((Control)val5).ForeColor = BM.te;
								((Control)val5).Font = new Font(((Control)val5).Font.FontFamily, 10f);
								((Control)val5).BackColor = Color.Transparent;
								((Control)val5).AutoSize = true;
								((Control)val5).Left = 10;
								((Control)val5).Top = num5;
								((Control)movableResizablePanel).Controls.Add((Control)(object)val5);
								((Control)this).ResumeLayout(true);
								((Control)this).SuspendLayout();
								num5 += ((Control)val5).Height + 5;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
					int num8 = 0;
					int num9 = 0;
					foreach (Control item in (ArrangedElementCollection)((Control)movableResizablePanel).Controls)
					{
						Control val6 = item;
						num8 = Math.Max(num8, val6.Left + val6.Width + 10);
						num9 = Math.Max(num9, val6.Top + val6.Height + 10);
					}
					((Control)movableResizablePanel).Width = num8;
					((Control)movableResizablePanel).Height = num9;
					if (num + num9 + 10 > ((Control)cq).Height)
					{
						num2 += num3 + 20;
						num = num4;
						num3 = num8;
					}
					else
					{
						num3 = Math.Max(num3, num8);
					}
					((Control)movableResizablePanel).Left = num2;
					((Control)movableResizablePanel).Top = num;
					((Control)cq.B()).Controls.Add((Control)(object)movableResizablePanel);
					num += num9 + 10;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			((Control)this).Controls.Add((Control)(object)cq);
			((Control)this).ResumeLayout(true);
			cq.C();
		}

		private void C(object P_0, EventArgs P_1)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = C;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			E();
			Enumerator<ModifyOnChange> enumerator = yk.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ModifyOnChange current = enumerator.Current;
					if (current.A() != P_0 as Setting)
					{
						continue;
					}
					Enumerator<Setting> enumerator2 = current.A(true).GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							BM.b(enumerator2.Current.A());
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

		private void c(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = c;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			E();
		}

		private void D(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					B b = D;
					((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			E();
		}

		private void c()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val.Visible)
				{
					if (val is DF)
					{
						(val as DF).b();
					}
					else if (val is Df)
					{
						(val as Df).c();
					}
				}
			}
		}

		private void D()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected O, but got Unknown
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected O, but got Unknown
			if (((Control)yH).Enabled)
			{
				((Control)yH).Focus();
				return;
			}
			Control val = null;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val2 = item;
				if (!val2.Visible)
				{
					continue;
				}
				if (val2 is DF)
				{
					DF dF = val2 as DF;
					if (((ArrangedElementCollection)((Control)dF.B()).Controls).Count == 0)
					{
						continue;
					}
					foreach (Control item2 in (ArrangedElementCollection)((Control)dF.B()).Controls)
					{
						Control val3 = item2;
						if (!(val3 is Label))
						{
							val = val3;
							break;
						}
					}
					break;
				}
				if (!(val2 is Df))
				{
					continue;
				}
				Df df = val2 as Df;
				int num = 2147483647;
				int num2 = 2147483647;
				foreach (Control item3 in (ArrangedElementCollection)((Control)df.B()).Controls)
				{
					Control val4 = item3;
					if (val4.Visible && val4 is DF && ((ArrangedElementCollection)((Control)(val4 as DF).B()).Controls).Count != 0)
					{
						num = Math.Min(num, val4.Left);
						num2 = Math.Min(num2, val4.Top);
					}
				}
				foreach (Control item4 in (ArrangedElementCollection)((Control)df.B()).Controls)
				{
					Control val5 = item4;
					if (!val5.Visible || val5.Left != num || val5.Top != num2 || !(val5 is DF))
					{
						continue;
					}
					DF dF2 = val5 as DF;
					if (((ArrangedElementCollection)((Control)dF2.B()).Controls).Count == 0)
					{
						continue;
					}
					foreach (Control item5 in (ArrangedElementCollection)((Control)dF2.B()).Controls)
					{
						Control val6 = item5;
						if (!(val6 is Label))
						{
							val = val6;
							break;
						}
					}
					break;
				}
				break;
			}
			if (val != null)
			{
				val.Focus();
			}
			else
			{
				((Control)yH).Focus();
			}
		}

		private List<Control> d()
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected O, but got Unknown
			List<Control> val = new List<Control>();
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val2 = item;
				if (!val2.Visible)
				{
					continue;
				}
				if (val2 is DF)
				{
					foreach (Control item2 in (ArrangedElementCollection)((Control)(val2 as DF).B()).Controls)
					{
						Control val3 = item2;
						if (val3.Visible && (val3 is aG || val3 is af))
						{
							val.Add(val3);
						}
					}
				}
				else
				{
					if (!(val2 is Df))
					{
						continue;
					}
					foreach (Control item3 in (ArrangedElementCollection)((Control)(val2 as Df).B()).Controls)
					{
						Control val4 = item3;
						if (!val4.Visible)
						{
							continue;
						}
						if (val4 is DF)
						{
							foreach (Control item4 in (ArrangedElementCollection)((Control)(val4 as DF).B()).Controls)
							{
								Control val5 = item4;
								if (val5.Visible && (val5 is aG || val5 is af))
								{
									val.Add(val5);
								}
							}
						}
						else if (val4 is aG)
						{
							val.Add(val4);
						}
						else if (val4 is af)
						{
							val.Add(val4);
						}
					}
				}
			}
			return val;
		}

		private void E()
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			((Control)yg).Enabled = a() < yJ;
			string text = null;
			Enumerator<DataIdAndAttrId> enumerator = yj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataIdAndAttrId current = enumerator.Current;
					Setting setting = yf.A(current);
					if (setting == null || setting.O() || setting.P() == IllegalitySeverityLevel.Warning)
					{
						continue;
					}
					string text2 = ((SettingOrSpecialObject)setting).A(bz.aYt);
					Enumerator<string> enumerator2 = setting.o().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							string current2 = enumerator2.Current;
							if (text == null)
							{
								text = string.Empty;
							}
							text = string.Concat(new string[5]
							{
								text,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yi(),
								text2,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq(),
								current2
							});
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
			bool flag = false;
			Enumerator<Control> enumerator3 = yK.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					Control current3 = enumerator3.Current;
					if (current3 is aG)
					{
						if (string.IsNullOrWhiteSpace((current3 as aG).c()))
						{
							flag = true;
							break;
						}
					}
					else if (current3 is af && string.IsNullOrWhiteSpace((current3 as af).b()))
					{
						flag = true;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			if (text != null && flag)
			{
				((Control)yH).Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yJ() + text;
				((Control)yH).Enabled = false;
				return;
			}
			if (text != null)
			{
				((Control)yH).Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yj() + text;
				((Control)yH).Enabled = false;
				return;
			}
			if (flag)
			{
				((Control)yH).Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yK();
				((Control)yH).Enabled = false;
				return;
			}
			((Control)yH).Tag = null;
			((Control)yH).Enabled = true;
			yI.Active = false;
			yI.Hide((IWin32Window)(object)this);
			yi = false;
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			if (((Control)this).GetChildAtPoint(P_1.Location) == yH && ((Control)yH).Tag != null)
			{
				if (!yi)
				{
					yi = true;
					yI.ShowAlways = true;
					yI.InitialDelay = 500;
					yI.ReshowDelay = 500;
					yI.Active = true;
					yI.Popup -= new PopupEventHandler(A);
					yI.Popup += new PopupEventHandler(A);
					yI.Show(((Control)yH).Tag as string, (IWin32Window)(object)this, P_1.X, P_1.Y);
				}
			}
			else
			{
				yI.Active = false;
				yI.Hide((IWin32Window)(object)this);
				yi = false;
			}
		}

		private void A(object P_0, PopupEventArgs P_1)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)yH).Tag != null)
			{
				Size val = TextRenderer.MeasureText(((Control)yH).Tag as string, ((Control)this).Font, new Size(250, -1), (TextFormatFlags)16);
				P_1.ToolTipSize = new Size(((Size)(ref val)).Width, ((Size)(ref val)).Height + 50);
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return q.A((Form)(object)this, keyData);
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			((Control)yg).Click -= new EventHandler(B);
			((Control)yH).Click -= new EventHandler(b);
			yI.Popup -= new PopupEventHandler(A);
			((Control)this).MouseMove -= new MouseEventHandler(A);
			BM.c(new EventHandler(a));
			try
			{
				((Component)yI).Dispose();
			}
			catch
			{
			}
			if (disposing && yl != null)
			{
				((System.IDisposable)yl).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void e()
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			((Control)this).SuspendLayout();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(1224, 641);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yk();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yL();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
		}
	}
}
namespace b
{
	internal enum bZ
	{
		aYL,
		aYl,
		aYM,
		aYm,
		aYN,
		aYn,
		aYO,
		aYo,
		aYP,
		aYp,
		aYQ,
		aYq,
		aYR,
		aYr,
		aYS,
		aYs
	}
	internal enum bz
	{
		aYT,
		aYt,
		aYU,
		aYu,
		aYV,
		aYv,
		aYW,
		aYw
	}
}
