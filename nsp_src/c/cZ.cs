using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace c
{
	internal class cZ : cq
	{
		[CompilerGenerated]
		private new static class A
		{
			public static ProgressChangedEventHandler bAY;
		}

		[CompilerGenerated]
		private new sealed class a
		{
			public BackgroundWorker bAy;

			public string bAZ;

			internal void A()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJF());
				bAy.ReportProgress(0);
			}

			internal void a()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJf() + bAZ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJG());
				bAy.ReportProgress(0);
			}

			internal void B()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJg());
				bAy.ReportProgress(0);
			}

			internal void b()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJH() + bAZ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJh());
				bAy.ReportProgress(0);
			}
		}

		private const int Btp = 5;

		private const int BtQ = 5;

		private const int Btq = 20;

		private const int BtR = 10;

		private const int Btr = 220;

		private const int BtS = 370;

		private const int Bts = 22;

		private const int BtT = 350;

		private const int Btt = 300;

		private Framework BtU;

		private Rectangle Btu;

		private Label BtV;

		private ThemedComboBox Btv;

		private ThemedButton BtW;

		private Label Btw;

		private Label BtX;

		private Label Btx;

		private Label BtY;

		private Label Bty;

		private Dictionary<int, Label> BtZ = new Dictionary<int, Label>();

		private Label Btz;

		private ag BUA;

		private BackgroundWorker BUa;

		internal cZ(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			BtU = P_0;
			Btu = P_1;
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			if (BtW != null)
			{
				((Control)BtW).Click -= new EventHandler(B);
			}
			BtZ.Clear();
			base.Dispose(disposing);
		}

		internal new void B()
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected O, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Expected O, but got Unknown
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_0483: Expected O, but got Unknown
			//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ba: Expected O, but got Unknown
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Expected O, but got Unknown
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Expected O, but got Unknown
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0648: Unknown result type (might be due to invalid IL or missing references)
			//IL_0652: Expected O, but got Unknown
			//IL_0658: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Expected O, but got Unknown
			//IL_0449: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected O, but got Unknown
			//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0968: Unknown result type (might be due to invalid IL or missing references)
			//IL_096d: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0752: Unknown result type (might be due to invalid IL or missing references)
			//IL_075c: Expected O, but got Unknown
			//IL_0772: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e7: Expected O, but got Unknown
			//IL_0830: Unknown result type (might be due to invalid IL or missing references)
			//IL_0837: Expected O, but got Unknown
			//IL_092e: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).SuspendLayout();
			((Control)base.B()).SuspendLayout();
			if (Btz == null)
			{
				Btz = new Label();
				((Control)Btz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEu() + ((object)BtU.aXA)?.ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
				((Control)Btz).ForeColor = BM.te;
				((Control)Btz).AutoSize = true;
				((Control)Btz).Left = 370;
				((Control)Btz).Top = 5;
				((Control)base.B()).Controls.Add((Control)(object)Btz);
			}
			if (BUA == null)
			{
				BUA = new ag();
				((Control)BUA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEV();
				((Control)BUA).BackColor = BM.tH;
				((Control)BUA).ForeColor = BM.te;
				((Control)BUA).Left = 370;
				((Control)BUA).Top = 22;
				((TextBoxBase)BUA).ReadOnly = true;
				((Control)BUA).Size = new Size(350, 300);
				((Control)base.B()).Controls.Add((Control)(object)BUA);
			}
			if (BUa == null)
			{
				BUa = new BackgroundWorker();
				BUa.DoWork += new DoWorkEventHandler(A);
				BUa.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
				BUa.RunWorkerAsync();
			}
			int top = 5;
			if (BtV == null)
			{
				BtV = new Label();
				((Control)BtV).Font = new Font(((Control)this).Font.FontFamily, 8f, (FontStyle)1);
				((Control)BtV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gY();
				((Control)BtV).ForeColor = BM.tf;
				((Control)BtV).AutoSize = true;
				((Control)BtV).Left = 5;
				((Control)base.B()).Controls.Add((Control)(object)BtV);
			}
			((Control)BtV).Top = top;
			top = ((Control)BtV).Bottom + 20;
			if (BtU.aXL.Count >= 2 && BM.A(BtU.aXc, true) && CZ.b(BtU.aXc))
			{
				if (Btv == null)
				{
					Btv = new ThemedComboBox();
					((Control)Btv).Font = new Font(((Control)Btv).Font.FontFamily, 8.25f);
					((ComboBox)Btv).DropDownStyle = (ComboBoxStyle)2;
					((ComboBox)Btv).Items.Clear();
					int selectedIndex = -1;
					Enumerator<ValueTuple<byte, byte>> enumerator = BtU.aXL.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ValueTuple<byte, byte> current = enumerator.Current;
							((ComboBox)Btv).Items.Add((object)bx.b(current.Item1, current.Item2));
							if (current.Item1 == BtU.awZ && current.Item2 == BtU.awz)
							{
								selectedIndex = ((ComboBox)Btv).Items.Count - 1;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					((ListControl)Btv).SelectedIndex = selectedIndex;
					((Control)Btv).Width = 220;
					((Control)Btv).Left = 5;
					((Control)base.B()).Controls.Add((Control)(object)Btv);
				}
				((Control)Btv).Top = top;
				if (BtW == null)
				{
					BtW = new ThemedButton();
					((Control)BtW).Font = new Font(((Control)BtW).Font.FontFamily, 8.25f);
					((Control)BtW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEv();
					((Control)BtW).Width = 120;
					((Control)BtW).Height = 25;
					((Control)BtW).Left = ((Control)Btv).Right + 10;
					((Control)base.B()).Controls.Add((Control)(object)BtW);
					((Control)BtW).Click += new EventHandler(B);
				}
				((Control)BtW).Top = top - 3;
				top = ((Control)BtW).Bottom + 10;
			}
			if (Btw == null)
			{
				Btw = new Label();
				((Control)Btw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM() + BtU.awy;
				((Control)Btw).ForeColor = BM.te;
				((Control)Btw).AutoSize = true;
				((Control)Btw).Left = 5;
				((Control)base.B()).Controls.Add((Control)(object)Btw);
			}
			((Control)Btw).Top = top;
			top = ((Control)Btw).Bottom + 10;
			if (!BtU.aXA.d())
			{
				if (BtX == null)
				{
					BtX = new Label();
					((Control)BtX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEW() + BtU.aXA.D() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ro();
					((Control)BtX).ForeColor = Color.Orange;
					((Control)BtX).AutoSize = true;
					((Control)BtX).Left = 5;
					((Control)base.B()).Controls.Add((Control)(object)BtX);
				}
				((Control)BtX).Top = top;
				top = ((Control)BtX).Bottom + 10;
			}
			if (Btx == null)
			{
				Btx = new Label();
				((Control)Btx).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEw() + (object)BtU.aXA;
				((Control)Btx).ForeColor = BM.te;
				((Control)Btx).AutoSize = true;
				((Control)Btx).Left = 5;
				((Control)base.B()).Controls.Add((Control)(object)Btx);
			}
			((Control)Btx).Top = top;
			top = ((Control)Btx).Bottom + 10;
			if (BtY == null)
			{
				BtY = new Label();
				((Control)BtY).ForeColor = BM.te;
				((Control)BtY).AutoSize = true;
				((Control)BtY).Left = 5;
				((Control)base.B()).Controls.Add((Control)(object)BtY);
			}
			((Control)BtY).Top = top;
			if (BM.A(BtU.aXc, true))
			{
				((Control)BtY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEX() + BtU.aXc;
			}
			else
			{
				((Control)BtY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEX();
			}
			Setting setting = BtU.A(1127);
			if (setting != null && bx.A(BtU.awZ) && (setting.m(2) & 0x8000) == 32768 && BM.A(BtU.aXc, true))
			{
				top = ((Control)BtY).Bottom + 10;
				if (Bty == null)
				{
					Bty = new Label();
					((Control)Bty).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEx();
					((Control)Bty).ForeColor = BM.te;
					((Control)Bty).AutoSize = true;
					((Control)Bty).Left = 5;
					((Control)base.B()).Controls.Add((Control)(object)Bty);
				}
				((Control)Bty).Top = top;
				top = ((Control)Bty).Bottom + 20;
			}
			else
			{
				top = ((Control)BtY).Bottom + 20;
			}
			if (BtU.awI != null)
			{
				Enumerator<int> enumerator2 = BtU.awI.A().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						int current2 = enumerator2.Current;
						Setting setting2 = BtU.A(current2);
						if (setting2 == null)
						{
							continue;
						}
						if (!BtZ.ContainsKey(current2))
						{
							Label val = new Label();
							BtZ.Add(current2, val);
							((Control)val).AutoSize = true;
							((Control)val).Left = 5;
							((Control)base.B()).Controls.Add((Control)(object)val);
						}
						Label val2 = BtZ[current2];
						((Control)val2).Text = ((SettingOrSpecialObject)setting2).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ();
						if (BM.A(BtU.aXc, true))
						{
							if (setting2.c() != 0)
							{
								((Control)val2).Text = ((Control)val2).Text + setting2.ay();
							}
							else
							{
								int num = setting2.ax();
								int num2 = (num >>> 24) & 0xFF;
								int num3 = (num >>> 16) & 0xFF;
								int num4 = (num >>> 8) & 0xFF;
								int num5 = num & 0xFF;
								k k = new k(num2, num3, num4, num5, 0);
								((Control)val2).Text = ((Control)val2).Text + (object)k;
							}
						}
						((Control)val2).ForeColor = BM.te;
						((Control)val2).Top = top;
						top = ((Control)val2).Bottom + 10;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			if (Btu != Rectangle.Empty)
			{
				((Control)this).Width = ((Rectangle)(ref Btu)).Width;
				((Control)this).Height = ((Rectangle)(ref Btu)).Height;
				((Control)this).Left = ((Rectangle)(ref Btu)).Left;
				((Control)this).Top = ((Rectangle)(ref Btu)).Top;
			}
			else
			{
				int num6 = 0;
				int num7 = 0;
				foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
				{
					Control val3 = item;
					num6 = Math.Max(num6, val3.Right + 10);
					num7 = Math.Max(num7, val3.Bottom + 10);
				}
				((Control)this).Width = num6;
				((Control)this).Height = num7;
			}
			((Control)base.B()).ResumeLayout(true);
			((Control)this).ResumeLayout(true);
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			bW bW = new bW
			{
				axS = BtU.awZ,
				axs = BtU.awz,
				axT = BtU.aXA,
				axt = BtU.F()
			};
			P_1.Result = CZ.A(bW);
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			if (BUA == null || ((Control)BUA).IsDisposed)
			{
				return;
			}
			if (P_1.Result != null)
			{
				((TextBoxBase)BUA).Clear();
				string text = P_1.Result as string;
				if (!string.IsNullOrEmpty(text))
				{
					((RichTextBox)BUA).ScrollBars = (RichTextBoxScrollBars)0;
					BUA.A(text);
					((RichTextBox)BUA).ScrollBars = (RichTextBoxScrollBars)2;
					BUA.A();
				}
			}
			else
			{
				((Control)BUA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEY();
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Invalid comparison between Unknown and I4
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Expected O, but got Unknown
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			if (((ListControl)Btv).SelectedIndex == -1 || (int)BM.A((IWin32Window)(object)BM.QQ, true) == 2)
			{
				return;
			}
			byte item = BtU.aXL[((ListControl)Btv).SelectedIndex].Item1;
			byte item2 = BtU.aXL[((ListControl)Btv).SelectedIndex].Item2;
			string text = bT.A(item, item2, BtU.aXA, null, true);
			string text2 = bx.b(item, item2);
			if (string.IsNullOrEmpty(text))
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEy() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEZ() + ((object)BtU.aXA).ToString(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			byte[] array = null;
			try
			{
				array = File.ReadAllBytes(text);
			}
			catch (System.Exception ex)
			{
				array = null;
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEz() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeA() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			if (array != null)
			{
				BM.QQ.w();
				BM.d();
				((Control)BM.QQ).Refresh();
				BackgroundWorker val = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				object obj = cZ.A.bAY;
				if (obj == null)
				{
					ProgressChangedEventHandler val2 = BM.a;
					cZ.A.bAY = val2;
					obj = (object)val2;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj;
				val.DoWork += new DoWorkEventHandler(a);
				val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(a);
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bea() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC());
				val.RunWorkerAsync((object)new ValueTuple<byte, byte, byte[]>(item, item2, array));
			}
		}

		private unsafe void a(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected O, but got Unknown
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			BackgroundWorker bAy = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			bAy.ReportProgress(0);
			_003F val = (ValueTuple<byte, byte, byte[]>)P_1.Argument;
			byte item = ((ValueTuple<byte, byte, byte[]>*)(&val))->Item1;
			byte item2 = ((ValueTuple<byte, byte, byte[]>*)(&val))->Item2;
			byte[] item3 = ((ValueTuple<byte, byte, byte[]>*)(&val))->Item3;
			byte[] array = new byte[10] { 0, 24, 0, 0, 0, item, 0, 0, 0, item2 };
			P_1.Result = string.Empty;
			if (!global::A.A.A(BtU.aXc, global::A.f.au, 0u, array, out var flag) || flag)
			{
				P_1.Result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeB();
				return;
			}
			bAy.ReportProgress(100);
			Thread.Sleep(1000);
			F f = global::A.A.e(BtU.aXc);
			if (f == null)
			{
				P_1.Result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Beb();
				return;
			}
			((Control)BM.QQ).Invoke((Action)delegate
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJF());
				bAy.ReportProgress(0);
			});
			if (!CZ.a(f))
			{
				P_1.Result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayC();
				return;
			}
			BtU.D();
			bAy.ReportProgress(100);
			Thread.Sleep(500);
			string bAZ = bx.b(item, item2);
			((Control)BM.QQ).Invoke((Action)delegate
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJf() + bAZ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJG());
				bAy.ReportProgress(0);
			});
			if (!A(bAy, P_1, f, item3))
			{
				P_1.Result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeC();
				return;
			}
			f = global::A.A.e(BtU.aXc);
			if (f == null)
			{
				P_1.Result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Beb();
				return;
			}
			((Control)BM.QQ).Invoke((Action)delegate
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJg());
				bAy.ReportProgress(0);
			});
			if (!CZ.A(f))
			{
				P_1.Result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bec();
				return;
			}
			bAy.ReportProgress(100);
			Thread.Sleep(500);
			((Control)BM.QQ).Invoke((Action)delegate
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJH() + bAZ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJh());
				bAy.ReportProgress(0);
			});
			string text = bT.A(item, item2, BtU.aXA, null, true);
			if (string.IsNullOrEmpty(text))
			{
				P_1.Result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEy() + bAZ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEZ() + ((object)BtU.aXA).ToString();
				return;
			}
			bAy.ReportProgress(20);
			Framework framework = new Framework(text, item, item2, BtU.aXA);
			framework.aXc = f.ao;
			if (framework.a() == bV.A.Brc)
			{
				BM.Qz = framework;
				bAy.ReportProgress(100);
				Thread.Sleep(500);
			}
			else
			{
				P_1.Result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeD() + bAZ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bed() + ((object)BtU.aXA).ToString();
			}
		}

		private bool A(BackgroundWorker P_0, DoWorkEventArgs P_1, F P_2, byte[] P_3)
		{
			byte[] array = new byte[4 + P_3.Length];
			array[0] = (byte)(((uint)P_3.Length >> 24) & 0xFFu);
			array[1] = (byte)(((uint)P_3.Length >> 16) & 0xFFu);
			array[2] = (byte)(((uint)P_3.Length >> 8) & 0xFFu);
			array[3] = (byte)((uint)P_3.Length & 0xFFu);
			System.Array.Copy((System.Array)P_3, 0, (System.Array)array, 4, P_3.Length);
			global::A.A.a(BtU.aXc, 1000u);
			uint be = P_2.@as[3].Be;
			uint num = 8192u;
			uint num2;
			for (num2 = 0u; num2 < array.Length / num; num2++)
			{
				byte[] array2 = new byte[num];
				System.Array.Copy((System.Array)array, (long)(num2 * num), (System.Array)array2, 0L, (long)num);
				if (!global::A.A.A(BtU.aXc, f.au, be + num2 * num, array2, out var flag) || flag)
				{
					return false;
				}
				P_0.ReportProgress((int)(num2 * num * 90) / array.Length);
			}
			uint num3 = (uint)array.Length % num;
			if (num3 != 0)
			{
				byte[] array3 = new byte[num3];
				System.Array.Copy((System.Array)array, (long)(num2 * num), (System.Array)array3, 0L, (long)num3);
				if (!global::A.A.A(BtU.aXc, f.au, be + num2 * num, array3, out var flag2) || flag2)
				{
					return false;
				}
			}
			P_0.ReportProgress(100);
			Thread.Sleep(200);
			return true;
		}

		private void a(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			BM.P();
			global::A.A.I(BtU.aXc);
			BtU = null;
			if ((string)P_1.Result == string.Empty)
			{
				BM.QQ.A(null, -1);
				return;
			}
			BM.b(true);
			bE.A((IWin32Window)(object)BM.QQ, (string)P_1.Result, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}
	internal class cz : cq
	{
		private const int BUB = 5;

		private const int BUb = 2;

		private const int BUC = 300;

		private const int BUc = 300;

		private const int BUD = 5;

		private const int BUd = 10;

		private const int BUE = 30;

		private Framework BUe;

		private Framework BUF;

		private PictureBox BUf = new PictureBox();

		private ThemedTextBox BUG = new ThemedTextBox();

		private ThemedButton BUg = new ThemedButton();

		private Timer BUH = new Timer();

		private ab BUh = new ab();

		private DF BUI;

		private ThemedButton BUi = new ThemedButton();

		private SortedList<string, ListViewItem> BUJ = new SortedList<string, ListViewItem>();

		internal cz(Rectangle P_0, Framework P_1, Framework P_2, bool P_3)
			: base(P_0, P_3, false)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected O, but got Unknown
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Expected O, but got Unknown
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Expected O, but got Unknown
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Expected O, but got Unknown
			//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected O, but got Unknown
			//IL_0456: Unknown result type (might be due to invalid IL or missing references)
			//IL_0460: Expected O, but got Unknown
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Expected O, but got Unknown
			BUe = P_1;
			BUF = P_2;
			((Control)BUf).BackColor = ((Control)this).BackColor;
			if (BUf.Image != null)
			{
				BUf.Image.Dispose();
			}
			BUf.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
			((Control)BUf).Width = 24;
			((Control)BUf).Height = 24;
			((Control)BUf).Left = 5;
			((Control)BUf).Top = 2;
			((Control)BUg).Width = 22;
			((Control)BUG).BackColor = BM.to;
			((Control)BUG).ForeColor = BM.te;
			((Control)BUG).TextChanged += new EventHandler(C);
			BUG.A(A);
			((Control)BUG).Left = ((Control)BUf).Left + ((Control)BUf).Width + 1;
			((Control)BUG).Top = 2;
			((Control)BUG).Width = 296 - (((Control)BUf).Width + ((Control)BUg).Width + 6);
			((Control)BUg).Click += new EventHandler(b);
			((Control)BUg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
			((Control)BUg).Font = new Font(((Control)BUg).Font.FontFamily, 8f, (FontStyle)1);
			((Control)BUg).Left = ((Control)BUG).Left + ((Control)BUG).Width + 3;
			((Control)BUg).Top = ((Control)BUG).Top - 2;
			((Control)BUg).Height = ((Control)BUG).Height + 2;
			BUH.Interval = 400;
			BUH.Tick += new EventHandler(c);
			((ListView)BUh).Columns.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wk(), 278);
			((Control)BUh).Left = 5;
			((Control)BUh).Top = ((Control)BUG).Top + ((Control)BUG).Height + 5;
			((Control)BUh).Width = 300;
			((Control)BUh).Height = 300;
			((Control)BUh).BackColor = BM.tH;
			((Control)BUh).ForeColor = BM.te;
			((Control)BUh).Font = new Font(((Control)this).Font.FontFamily, 8.5f);
			((ListView)BUh).MultiSelect = false;
			((ListView)BUh).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)BUh).View = (View)1;
			((ListView)BUh).FullRowSelect = true;
			((ListView)BUh).HideSelection = false;
			((Control)BUi).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeE();
			((Control)BUi).Left = 5;
			((Control)BUi).Top = ((Control)BUh).Bottom + 10;
			((Control)BUi).Width = 300;
			((Control)BUi).Height = 25;
			((Control)BUi).Click += new EventHandler(D);
			((Control)base.B()).Controls.Add((Control)(object)BUf);
			((Control)base.B()).Controls.Add((Control)(object)BUG);
			((Control)base.B()).Controls.Add((Control)(object)BUg);
			((Control)base.B()).Controls.Add((Control)(object)BUh);
			((Control)base.B()).Controls.Add((Control)(object)BUi);
			B();
			b();
			((ListView)BUh).SelectedIndexChanged += new EventHandler(B);
			((Control)BUG).Focus();
			if (P_0 != Rectangle.Empty)
			{
				((Control)this).Width = ((Rectangle)(ref P_0)).Width;
				((Control)this).Height = ((Rectangle)(ref P_0)).Height;
				((Control)this).Left = ((Rectangle)(ref P_0)).Left;
				((Control)this).Top = ((Rectangle)(ref P_0)).Top;
				return;
			}
			int num = 0;
			int num2 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val = item;
				num = Math.Max(num, val.Right + 10);
				num2 = Math.Max(num2, val.Bottom + 10);
			}
			((Control)this).Width = num;
			((Control)this).Height = num2;
		}

		private new void B()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			BUJ.Clear();
			List<string> val = new List<string>();
			Enumerator<Setting> enumerator = BUe.aWt.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (!((SettingOrSpecialObject)current).l() || !current.aC() || current.al() || !PortFunction.A(current))
					{
						continue;
					}
					string text = ((SettingOrSpecialObject)current).A(bz.aYt);
					if (text == null)
					{
						text = ((SettingOrSpecialObject)current).B();
					}
					string text2 = ((SettingOrSpecialObject)current).H();
					if (!string.IsNullOrWhiteSpace(text2))
					{
						text = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					ListViewItem val2 = new ListViewItem(new string[1] { text });
					val2.Tag = current.A();
					if (BUJ.ContainsKey(text))
					{
						if (!val.Contains(text))
						{
							val.Add(text);
						}
					}
					else
					{
						BUJ.Add(text, val2);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (val.Count == 0)
			{
				return;
			}
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yo();
			Enumerator<string> enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					string current2 = enumerator2.Current;
					text3 = text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy() + current2;
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			bE.A((IWin32Window)(object)this, text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}

		private new void b()
		{
			string text = ((Control)BUG).Text.ToUpper();
			string[] array = text.Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
			((ListView)BUh).BeginUpdate();
			((ListView)BUh).Items.Clear();
			System.Collections.Generic.IEnumerator<ListViewItem> enumerator = ((System.Collections.Generic.IEnumerable<ListViewItem>)BUJ.Values).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ListViewItem current = enumerator.Current;
					int num = (int)current.Tag;
					Setting setting = BUe.A(num);
					if (setting != null && A(setting, out var flag, text, array))
					{
						if (((ListView)BUh).Items.Count != 0 && flag)
						{
							((ListView)BUh).Items.Insert(0, current);
						}
						else
						{
							((ListView)BUh).Items.Add(current);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			((ListView)BUh).EndUpdate();
			BUh.a();
		}

		private bool A(Setting P_0, out bool P_1, string P_2, string[] P_3)
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			string text = ((SettingOrSpecialObject)P_0).A(true);
			string text2 = string.Empty;
			if (((SettingOrSpecialObject)P_0).s() != null)
			{
				text2 = ((SettingOrSpecialObject)P_0).s();
			}
			string text3 = ((SettingOrSpecialObject)P_0).A(bz.aYT);
			if (text3 == null)
			{
				text3 = ((SettingOrSpecialObject)P_0).B();
			}
			string text4 = text3.ToUpper();
			string text5 = text.ToUpper();
			string text6 = text2.ToUpper();
			bool result = true;
			P_1 = false;
			if (P_2 == text5 || P_2 == text4)
			{
				P_1 = true;
			}
			else
			{
				Enumerator<string> enumerator = ((SettingOrSpecialObject)P_0).i().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						if (P_2 == current.ToUpper())
						{
							P_1 = true;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (!P_1)
			{
				foreach (string text7 in P_3)
				{
					if (text5.Contains(text7) || text4.Contains(text7) || text6.Contains(text7))
					{
						continue;
					}
					bool flag = false;
					Enumerator<string> enumerator = ((SettingOrSpecialObject)P_0).i().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.ToUpper().Contains(text7))
							{
								flag = true;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					if (!flag)
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			if (((ListView)BUh).SelectedItems.Count == 0)
			{
				return;
			}
			int num = (int)((ListView)BUh).SelectedItems[0].Tag;
			Setting setting = BUe.A(num);
			if (setting != null)
			{
				if (BUI != null)
				{
					((Component)BUI).Dispose();
				}
				BUI = new DF(setting, ((SettingOrSpecialObject)setting).A(true), BUe, BUF, Rectangle.Empty, false, true);
				((Control)BUI).Left = ((Control)BUh).Left + ((Control)BUh).Width + 30;
				((Control)BUI).Top = ((Control)BUh).Top;
				((Control)base.B()).Controls.Add((Control)(object)BUI);
				BUI.A(true);
			}
		}

		[SpecialName]
		internal new ThemedTextBox C()
		{
			return BUG;
		}

		private void b(object P_0, EventArgs P_1)
		{
			((Control)BUG).Text = string.Empty;
		}

		private void C(object P_0, EventArgs P_1)
		{
			BUH.Stop();
			BUH.Start();
		}

		private void A(object P_0, ThemedTextBox.B P_1)
		{
			BUH.Stop();
			BUH.Start();
		}

		private void c(object P_0, EventArgs P_1)
		{
			BUH.Stop();
			b();
		}

		internal void A(string P_0)
		{
			ListViewItem val = ((ListView)BUh).FindItemWithText(P_0);
			if (val != null)
			{
				((ListView)BUh).SelectedItems.Clear();
				val.Selected = true;
				val.Focused = true;
				val.EnsureVisible();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Invalid comparison between Unknown and I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bee(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeF(), (MessageBoxButtons)1, (MessageBoxIcon)48) != 1)
			{
				return;
			}
			Ck ck2 = BM.aM();
			ck2?.a();
			BUe.M();
			Enumerator<Setting> enumerator = BUe.aWt.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					BUe.A(new DataIdAndAttrId(current.A(), 4))?.a((current.aS() << 8) | bS.a(current.aS()), true);
					BUe.A(new DataIdAndAttrId(current.A(), 5))?.a(bS.D(current.aS()), true);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			BM.Z();
			BUe.A(true);
			ck2?.B();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			((Control)BUG).TextChanged -= new EventHandler(C);
			BUG.a(A);
			((Control)BUg).Click -= new EventHandler(b);
			BUH.Tick -= new EventHandler(c);
			((ListView)BUh).SelectedIndexChanged -= new EventHandler(B);
			((Control)BUi).Click -= new EventHandler(D);
			try
			{
				((Component)BUf).Dispose();
				((Component)BUG).Dispose();
				((Component)BUg).Dispose();
				((Component)BUH).Dispose();
				((Component)BUh).Dispose();
				((Component)BUi).Dispose();
				if (BUI != null)
				{
					((Component)BUI).Dispose();
				}
			}
			catch
			{
			}
			try
			{
				base.Dispose(disposing);
			}
			catch
			{
			}
		}
	}
}
namespace C
{
	internal static class CZ
	{
		internal class A
		{
			internal string BTM;

			internal F BTm;

			internal bW BTN;

			internal bool BTn;

			internal bool BTO;

			internal bool BTo;

			internal string BTP;

			internal bool BTp;

			internal bool BTQ;

			internal bt BTq;

			internal k BTR;

			internal k BTr;

			internal bool BTS;

			internal Dictionary<bt, k> BTs;

			internal Dictionary<bt, k> BTT;

			internal Dictionary<bt, bool> BTt;

			internal bool BTU;

			internal List<string> BTu;

			internal List<Cy> BTV;

			internal int BTv;

			internal List<string> BTW = new List<string>();

			internal bool BTw;

			internal bool BTX;

			internal bool BTx;

			internal bool BTY;

			internal bool BTy;
		}

		private enum a
		{
			BTZ,
			BTz,
			BtA,
			Bta,
			BtB,
			Btb
		}

		internal class B
		{
			internal bool BtC;

			internal bool Btc;

			internal bool BtD;

			internal string Btd;

			internal string BtE;

			internal bool Bte;

			internal bt BtF;

			internal k Btf;

			internal k BtG;

			internal Dictionary<bt, k> Btg;

			internal Dictionary<bt, k> BtH;

			internal string Bth;

			internal bool BtI;

			internal int Bti;

			internal F BtJ;
		}

		[CompilerGenerated]
		private static class b
		{
			public static DoWorkEventHandler Btj;

			public static ProgressChangedEventHandler BtK;

			public static RunWorkerCompletedEventHandler Btk;

			public static DoWorkEventHandler BtL;

			public static ProgressChangedEventHandler Btl;

			public static RunWorkerCompletedEventHandler BtM;
		}

		internal static readonly string Bdl = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZe();

		private static bool BdM = false;

		private static Point Bdm;

		internal const uint BdN = 2u;

		internal static readonly object Bdn = new object();

		internal static bool BdO = false;

		[CompilerGenerated]
		private static EventHandler Bdo;

		private static Cy A(Stream P_0, F P_1, string P_2, string P_3, bool P_4, byte P_5, bt P_6, string P_7, bool P_8, string P_9)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			Cy result = null;
			try
			{
				if (P_7 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYQ())
				{
					P_0 = CT.A(P_0);
					if (P_0 == null)
					{
						return null;
					}
				}
				Cv cv = new Cv();
				byte[] array = null;
				BinaryReader val = new BinaryReader(P_0);
				try
				{
					cv.BDU = val.ReadUInt32();
					uint num = val.ReadUInt32();
					if (cv.BDU < 2)
					{
						cv.BDu = (CV)num;
						cv.BDV = 0;
					}
					else
					{
						cv.BDu = CV.BDk;
						cv.BDV = (byte)num;
					}
					byte b = val.ReadByte();
					byte b2 = val.ReadByte();
					byte b3 = val.ReadByte();
					byte b4 = val.ReadByte();
					cv.BDv = new k(b, b2, b3, b4, 0);
					cv.BDW = val.ReadUInt32();
					cv.BDw = val.ReadUInt32();
					cv.BDX = val.ReadUInt32();
					cv.BDx = val.ReadUInt32();
					cv.BDY = val.ReadBytes(16);
					array = new byte[val.BaseStream.Length - val.BaseStream.Position];
					uint num2 = 0u;
					while (val.BaseStream.Position != val.BaseStream.Length)
					{
						array[num2] = val.ReadByte();
						num2++;
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				if (array != null)
				{
					if (P_1 != null)
					{
						if (bx.A(P_1.aH))
						{
							uint num3 = ((cv.BDU < 2) ? 4294967295u : cv.BDX);
							result = new Cy(cv, array, P_7, num3, 255, P_2, P_3, P_4, P_6, P_8, P_9);
						}
						else
						{
							uint num4 = cv.BDX;
							uint bDw = cv.BDw;
							while (num4 > bDw)
							{
								if (num4 <= global::A.A.a(P_1.ao, f.au))
								{
									result = new Cy(cv, array, P_7, num4, P_5, P_2, P_3, P_4, P_6, P_8, P_9);
									break;
								}
								num4 >>= 1;
							}
						}
					}
					else
					{
						result = new Cy(cv, array, P_7, 0u, 255, P_2, P_3, P_4, P_6, P_8, P_9);
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYq() + ex.Message, true);
				result = null;
			}
			return result;
		}

		private static Cy A(string P_0, F P_1, string P_2, string P_3, bool P_4, byte P_5, bt P_6, string P_7, bool P_8, string P_9)
		{
			return A((Stream)(object)File.Open(P_0, (FileMode)3), P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, P_9);
		}

		private static Cy A(Stream P_0, F P_1, string P_2, ref bW P_3, string P_4, ref string P_5)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected O, but got Unknown
			Cy result = null;
			try
			{
				BinaryReader val = new BinaryReader(P_0);
				byte[] array;
				try
				{
					array = val.ReadBytes((int)val.BaseStream.Length);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				P_5 = bT.A(array, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYR() + P_4, out var bW);
				if (P_5 != null)
				{
					P_3 = bW;
				}
				if (P_1 != null)
				{
					byte[] array2 = new byte[array.Length + 4];
					array2[0] = (byte)(((uint)array.Length >> 24) & 0xFFu);
					array2[1] = (byte)(((uint)array.Length >> 16) & 0xFFu);
					array2[2] = (byte)(((uint)array.Length >> 8) & 0xFFu);
					array2[3] = (byte)((uint)array.Length & 0xFFu);
					System.Array.Copy((System.Array)array, 0, (System.Array)array2, 4, array.Length);
					Cv cv = new Cv
					{
						BDU = ((P_2 != null) ? 2u : 0u),
						BDu = CV.BDp,
						BDV = 0,
						BDv = new k(0, 0, 0, 0, 0),
						BDW = P_1.@as[3].Be,
						BDw = 256u,
						BDX = 8192u,
						BDx = 1000u,
						BDY = new byte[16]
					};
					uint num = cv.BDX;
					uint bDw = cv.BDw;
					while (num > bDw)
					{
						if (global::A.A.a(P_1.ao, f.aW) >= num)
						{
							result = new Cy(cv, array2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYr(), num, 255, P_2, null, true, bt.avK, true, null);
							break;
						}
						num >>= 1;
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYS() + ex.Message, true);
			}
			return result;
		}

		internal static bool A(byte P_0, byte P_1, k P_2)
		{
			if (P_2 == null)
			{
				return false;
			}
			if (bx.A(P_0))
			{
				return P_2 >= new k(3, 5, 0, 2, 0);
			}
			switch (P_0)
			{
			case 20:
				return P_2 >= new k(1, 18, 0, 2, 0);
			case 21:
			case 24:
			case 25:
				return true;
			default:
				return false;
			}
		}

		internal static bool A(bt P_0)
		{
			switch (P_0)
			{
			case bt.avk:
			case bt.avL:
				return true;
			case bt.avR:
				return false;
			case bt.avl:
			case bt.avM:
			case bt.avm:
			case bt.avN:
				return true;
			case bt.avn:
			case bt.avO:
			case bt.avp:
			case bt.avQ:
			case bt.avq:
				return true;
			case bt.avr:
			case bt.avS:
			case bt.avs:
			case bt.avT:
				return false;
			case bt.avt:
				return false;
			case bt.avU:
			case bt.avu:
			case bt.avV:
			case bt.avv:
				return true;
			case bt.avW:
			case bt.avw:
			case bt.avX:
			case bt.avx:
			case bt.avY:
			case bt.avy:
				return true;
			case bt.aWA:
				return false;
			default:
				return false;
			}
		}

		internal static bool A(bt P_0, k P_1, k P_2, bool P_3)
		{
			switch (P_0)
			{
			case bt.avn:
			case bt.avO:
			case bt.avp:
			case bt.avQ:
			case bt.avq:
				if (P_1 == null || P_2 == null)
				{
					return false;
				}
				if (P_1.A() != 1)
				{
					return P_1.A() == P_2.A();
				}
				return false;
			case bt.avU:
			case bt.avu:
			case bt.avV:
			case bt.avv:
				if (P_1 == null || P_2 == null)
				{
					return false;
				}
				if (P_1 >= A(P_3))
				{
					return P_2 >= A(false);
				}
				return false;
			default:
				return true;
			}
		}

		internal static k A(bool P_0)
		{
			if (P_0)
			{
				return new k(1, 1, 7, 0, 0);
			}
			return new k(1, 12, 0, 1, 0);
		}

		internal static List<Cw> A(string P_0)
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			List<Cw> val = new List<Cw>();
			try
			{
				FileStream val2 = File.OpenRead(P_0);
				try
				{
					List<string> val3 = R.A((Stream)(object)val2, null);
					if (val3.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYs()))
					{
						Cu cu = null;
						try
						{
							if (R.A((Stream)(object)val2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYs(), out var val4, null))
							{
								cu = new Cu(val4);
							}
						}
						catch
						{
							cu = null;
						}
						if (cu != null)
						{
							Enumerator<Cu.B> enumerator = cu.BDj.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									Cu.B current = enumerator.Current;
									string text = null;
									text = ((current.BTJ == null) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYT() : current.BTJ);
									string bdb = null;
									if (val3.Contains(text))
									{
										Stream val5 = null;
										if (R.A((Stream)(object)val2, text, out val5, null))
										{
											BinaryReader val6 = new BinaryReader(val5);
											byte[] array;
											try
											{
												array = val6.ReadBytes((int)val6.BaseStream.Length);
											}
											finally
											{
												((System.IDisposable)val6)?.Dispose();
											}
											bdb = Encoding.GetEncoding(65001).GetString(array).TrimEnd('\0');
											bdb = bdb.Replace('\r', ' ');
										}
									}
									k k = null;
									Enumerator<Cu.A> enumerator2 = current.BTj.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											Cu.A current2 = enumerator2.Current;
											if (string.IsNullOrEmpty(current2.BTB) || !val3.Contains(current2.BTB))
											{
												continue;
											}
											Stream val7 = null;
											if (R.A((Stream)(object)val2, current2.BTB, out val7, null))
											{
												Cy cy = A(val7, null, null, null, false, 255, bt.avK, null, false, null);
												if (cy != null)
												{
													k = cy.BdG.BDv;
													break;
												}
											}
										}
									}
									finally
									{
										((System.IDisposable)enumerator2).Dispose();
									}
									if (!(k != null))
									{
										continue;
									}
									Enumerator<bt> enumerator3 = current.BTi.GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											bt current3 = enumerator3.Current;
											Cw cw = new Cw();
											cw.Bda = current3;
											cw.BdB = k;
											cw.Bdb = bdb;
											val.Add(cw);
										}
									}
									finally
									{
										((System.IDisposable)enumerator3).Dispose();
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator).Dispose();
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYt() + ex.Message, true);
			}
			return val;
		}

		internal static List<CW> a(string P_0)
		{
			List<CW> val = new List<CW>();
			FileStream val2 = File.OpenRead(P_0);
			try
			{
				List<string> val3 = R.A((Stream)(object)val2, null);
				if (val3.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYs()))
				{
					A(val2, val3, val);
				}
				else
				{
					a(val2, val3, val);
				}
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			return val;
		}

		private static void A(FileStream P_0, List<string> P_1, List<CW> P_2)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected O, but got Unknown
			Cu cu = null;
			try
			{
				if (R.A((Stream)(object)P_0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYs(), out var val, null))
				{
					cu = new Cu(val);
				}
			}
			catch
			{
				cu = null;
			}
			if (cu == null)
			{
				return;
			}
			bool flag = false;
			Enumerator<Cu.a> enumerator = cu.BDJ.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.BTH != null)
					{
						flag = true;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = cu.BDJ.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Cu.a current = enumerator.Current;
					string text = null;
					bW bW = null;
					if (current.BTg != null)
					{
						if (!P_1.Contains(current.BTg))
						{
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYv());
						}
						Stream val2 = null;
						if (R.A((Stream)(object)P_0, current.BTg, out val2, null))
						{
							A(val2, null, null, ref bW, current.BTg, ref text);
							if (bW == null)
							{
								text = null;
								throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYU());
							}
							if (bW.axS != current.BTF || bW.axs != current.BTf)
							{
								text = null;
								throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYu());
							}
							if (bW.axT != cu.BDi)
							{
								text = null;
								throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYV());
							}
						}
					}
					string text2 = null;
					if (current.BTH != null)
					{
						text2 = current.BTH;
					}
					else if (!flag)
					{
						text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYT();
					}
					string bDz = null;
					if (text2 != null && P_1.Contains(text2))
					{
						Stream val3 = null;
						if (R.A((Stream)(object)P_0, text2, out val3, null))
						{
							BinaryReader val4 = new BinaryReader(val3);
							byte[] array;
							try
							{
								array = val4.ReadBytes((int)val4.BaseStream.Length);
							}
							finally
							{
								((System.IDisposable)val4)?.Dispose();
							}
							bDz = Encoding.GetEncoding(65001).GetString(array).TrimEnd('\0');
							bDz = bDz.Replace('\r', ' ');
						}
					}
					bW bW2 = new bW
					{
						axS = current.BTF,
						axs = current.BTf
					};
					if (current.BTg != null)
					{
						bW2.axT = cu.BDi;
					}
					else if (cu.BDJ.Count == 1)
					{
						bW2.axT = cu.BDi;
					}
					else
					{
						for (int num = current.BTh.Count - 1; num >= 0; num--)
						{
							Cu.A a = current.BTh[num];
							if (string.IsNullOrEmpty(a.BTc) && !string.IsNullOrEmpty(a.BTB) && P_1.Contains(a.BTB) && a.BTb != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYW() && a.BTb != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYw())
							{
								if (R.A((Stream)(object)P_0, a.BTB, out var val5, null))
								{
									Cy cy = A(val5, null, a.BTa, a.BTc, a.BTD, a.BTC, bt.avK, a.BTb, a.BTd, a.BTE);
									if (cy != null)
									{
										bW2.axT = cy.BdG.BDv;
									}
								}
								break;
							}
						}
					}
					if (bW == null || bW.axt == null)
					{
						if (text != null)
						{
							bW2.axt = N.a(text);
						}
					}
					else
					{
						bW2.axt = bW.axt;
					}
					CW cW = new CW
					{
						BDy = bW2,
						BDZ = current.BTG,
						BDz = bDz,
						BdA = text
					};
					P_2.Add(cW);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private static void a(FileStream P_0, List<string> P_1, List<CW> P_2)
		{
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected O, but got Unknown
			k k = null;
			int num = -1;
			int num2 = -1;
			string text = null;
			string text2 = null;
			bW bW = null;
			for (int i = 0; i < P_1.Count; i++)
			{
				string text3 = P_1[i];
				Stream val = null;
				if (!R.A((Stream)(object)P_0, text3, out val, null))
				{
					continue;
				}
				if (text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
				{
					A(val, null, null, ref bW, text3, ref text2);
					if (bW == null)
					{
						throw new System.Exception();
					}
					num = bW.axS;
					num2 = bW.axs;
					k = bW.axT;
					if (text != null)
					{
						break;
					}
				}
				else if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYT())
				{
					BinaryReader val2 = new BinaryReader(val);
					byte[] array;
					try
					{
						array = val2.ReadBytes((int)val2.BaseStream.Length);
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
					text = Encoding.GetEncoding(65001).GetString(array).TrimEnd('\0');
					text = text.Replace('\r', ' ');
					if (k != null)
					{
						break;
					}
				}
			}
			if (k == null)
			{
				text2 = null;
				for (int j = 0; j < P_1.Count; j++)
				{
					string text4 = P_1[j];
					Stream val3 = null;
					if (R.A((Stream)(object)P_0, text4, out val3, null))
					{
						Cy cy = A(val3, null, null, null, false, 255, bt.avK, null, false, null);
						if (cy != null && cy.BdG.BDu == CV.BDs)
						{
							num = 22;
							num2 = 13;
							k = cy.BdG.BDv;
							break;
						}
						if (cy != null && cy.BdG.BDu == CV.BDt)
						{
							num = 22;
							num2 = 2;
							k = cy.BdG.BDv;
							break;
						}
					}
				}
			}
			if (!(k != null))
			{
				return;
			}
			bW bW2 = new bW
			{
				axS = num,
				axs = num2,
				axT = k
			};
			if (bW == null || bW.axt == null)
			{
				if (text2 != null)
				{
					bW2.axt = N.a(text2);
				}
			}
			else
			{
				bW2.axt = bW.axt;
			}
			List<ushort> bDZ = A((byte)num, (byte)num2);
			CW cW = new CW
			{
				BDy = bW2,
				BDZ = bDZ,
				BDz = text,
				BdA = text2
			};
			P_2.Add(cW);
		}

		private static List<ushort> A(byte P_0, byte P_1)
		{
			List<ushort> val = new List<ushort>();
			switch (P_0)
			{
			case 8:
				switch (P_1)
				{
				case 2:
				{
					List<ushort> obj4 = new List<ushort>();
					obj4.Add((ushort)2);
					obj4.Add((ushort)6);
					obj4.Add((ushort)18);
					val.AddRange((System.Collections.Generic.IEnumerable<ushort>)obj4);
					break;
				}
				case 11:
				{
					List<ushort> obj3 = new List<ushort>();
					obj3.Add((ushort)2);
					obj3.Add((ushort)6);
					obj3.Add((ushort)18);
					val.AddRange((System.Collections.Generic.IEnumerable<ushort>)obj3);
					break;
				}
				case 3:
				{
					List<ushort> obj2 = new List<ushort>();
					obj2.Add((ushort)3);
					obj2.Add((ushort)7);
					obj2.Add((ushort)19);
					val.AddRange((System.Collections.Generic.IEnumerable<ushort>)obj2);
					break;
				}
				case 5:
				{
					List<ushort> obj = new List<ushort>();
					obj.Add((ushort)3);
					obj.Add((ushort)7);
					obj.Add((ushort)19);
					val.AddRange((System.Collections.Generic.IEnumerable<ushort>)obj);
					break;
				}
				case 14:
					val.Add((ushort)9);
					break;
				case 7:
					val.Add((ushort)8);
					break;
				case 6:
					val.Add((ushort)8);
					break;
				case 19:
					val.Add((ushort)17);
					break;
				case 20:
					val.Add((ushort)17);
					break;
				}
				break;
			case 10:
				switch (P_1)
				{
				case 12:
				{
					List<ushort> obj5 = new List<ushort>();
					obj5.Add((ushort)16);
					obj5.Add((ushort)48);
					val.AddRange((System.Collections.Generic.IEnumerable<ushort>)obj5);
					break;
				}
				case 15:
					val.Add((ushort)32);
					break;
				}
				break;
			case 20:
				if (P_1 == 3)
				{
					val.Add((ushort)33280);
				}
				break;
			case 22:
				val.Add((ushort)37888);
				break;
			}
			val.Add((ushort)65535);
			return val;
		}

		internal static bool A(string P_0, bW P_1, out bool P_2, out bool P_3, out k P_4, out string P_5)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			List<CW> obj = a(P_0);
			bool result = false;
			P_2 = false;
			P_3 = false;
			P_4 = null;
			P_5 = null;
			Enumerator<CW> enumerator = obj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CW current = enumerator.Current;
					if (current.BDy != null)
					{
						bW bDy = current.BDy;
						P_4 = bDy.axT;
						if (bDy == P_1)
						{
							result = true;
							P_2 = true;
							P_3 = true;
							P_5 = current.BdA;
							break;
						}
						if (bDy.axS == P_1.axS && bDy.axs == P_1.axs)
						{
							P_2 = true;
						}
						if (bDy.axT == P_1.axT)
						{
							P_3 = true;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return result;
		}

		internal static string A(bW P_0, ushort P_1)
		{
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			if (!Directory.Exists(Bdl))
			{
				return null;
			}
			string[] files = Directory.GetFiles(Bdl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCe());
			foreach (string text in files)
			{
				CY cY = CU.A(text);
				if (cY == null)
				{
					Enumerator<CW> enumerator = a(text).GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CW current = enumerator.Current;
							if (current.BDy == P_0 && current.BDZ.Contains(P_1))
							{
								return text;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					continue;
				}
				Enumerator<CX> enumerator2 = cY.BdF.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						CX current2 = enumerator2.Current;
						if (!(current2.BdC == P_0) || !current2.Bdc.Contains(P_1))
						{
							continue;
						}
						Enumerator<CW> enumerator = a(text).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								CW current3 = enumerator.Current;
								if (current3.BDy == P_0 && current3.BDZ.Contains(P_1))
								{
									return text;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						break;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			return null;
		}

		internal static string A(bW P_0)
		{
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			if (!Directory.Exists(Bdl))
			{
				return null;
			}
			string[] files = Directory.GetFiles(Bdl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCe());
			foreach (string text in files)
			{
				CY cY = CU.A(text);
				if (cY == null)
				{
					Enumerator<CW> enumerator = a(text).GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CW current = enumerator.Current;
							if (current.BDy == P_0)
							{
								return current.BDz;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					continue;
				}
				Enumerator<CX> enumerator2 = cY.BdF.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						if (!(enumerator2.Current.BdC == P_0))
						{
							continue;
						}
						Enumerator<CW> enumerator = a(text).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								CW current2 = enumerator.Current;
								if (current2.BDy == P_0)
								{
									return current2.BDz;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						break;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			return null;
		}

		internal static void B(string P_0)
		{
			try
			{
				if (!Directory.Exists(Bdl))
				{
					Directory.CreateDirectory(Bdl);
				}
				if (Directory.Exists(Bdl))
				{
					string text = Bdl + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + Path.GetFileName(P_0);
					if (Path.GetFullPath(text) != Path.GetFullPath(P_0))
					{
						File.Copy(P_0, text, true);
					}
				}
			}
			catch
			{
			}
		}

		internal static void A(F P_0, int P_1, int P_2, k P_3, byte[] P_4, ushort P_5, bool P_6, bool P_7, bool P_8, string P_9, bool P_10, bt P_11, k P_12, k P_13, bool P_14, Dictionary<bt, k> P_15, Dictionary<bt, k> P_16, Dictionary<bt, bool> P_17)
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Invalid comparison between Unknown and I4
			string text = null;
			if (P_3 != null)
			{
				text = A(new bW
				{
					axS = P_1,
					axs = P_2,
					axT = P_3,
					axt = P_4
				}, P_5);
			}
			if (text == null)
			{
				OpenFileDialog val = new OpenFileDialog();
				((FileDialog)val).InitialDirectory = Bdl;
				((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ki();
				((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kJ();
				if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
				{
					text = ((FileDialog)val).FileName;
				}
				((Component)val).Dispose();
			}
			if (text != null)
			{
				A(P_0, text, P_6, P_7, P_8, P_9, P_10, false, P_11, P_12, P_13, P_14, P_15, P_16, P_17, true, null);
			}
		}

		internal static void A(F P_0, string P_1, bool P_2, bool P_3, bool P_4, string P_5, bool P_6, bool P_7, bt P_8, k P_9, k P_10, bool P_11, Dictionary<bt, k> P_12, Dictionary<bt, k> P_13, Dictionary<bt, bool> P_14, bool P_15, List<string> P_16)
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			BM.QQ.qd.StorePendingStats();
			if (P_8 == bt.avK)
			{
				BM.A((IWin32Window)(object)BM.QQ, false);
			}
			B(P_1);
			A a = new A
			{
				BTm = P_0,
				BTM = P_1,
				BTn = P_2,
				BTO = P_3,
				BTo = P_4,
				BTP = P_5,
				BTp = P_6,
				BTQ = P_7,
				BTq = P_8,
				BTR = P_9,
				BTr = P_10,
				BTS = P_11,
				BTs = P_12,
				BTT = P_13,
				BTt = P_14,
				BTU = P_15,
				BTu = P_16
			};
			GC.Collect();
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true,
				WorkerSupportsCancellation = false
			};
			object obj = CZ.b.Btj;
			if (obj == null)
			{
				DoWorkEventHandler val2 = A;
				CZ.b.Btj = val2;
				obj = (object)val2;
			}
			val.DoWork += (DoWorkEventHandler)obj;
			object obj2 = CZ.b.BtK;
			if (obj2 == null)
			{
				ProgressChangedEventHandler val3 = BM.a;
				CZ.b.BtK = val3;
				obj2 = (object)val3;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj2;
			object obj3 = CZ.b.Btk;
			if (obj3 == null)
			{
				RunWorkerCompletedEventHandler val4 = A;
				CZ.b.Btk = val4;
				obj3 = (object)val4;
			}
			val.RunWorkerCompleted += (RunWorkerCompletedEventHandler)obj3;
			BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYX());
			val.RunWorkerAsync((object)a);
		}

		internal static void A(F P_0, string P_1, bt P_2)
		{
			A(P_0, P_1, false, true, false, null, false, true, P_2, null, null, false, null, null, null, false, null);
		}

		private static void A(object P_0, DoWorkEventArgs P_1)
		{
			if (P_1.Argument is A)
			{
				A result = (A)P_1.Argument;
				a a = A((BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null), ref result);
				if (a == a.BTZ)
				{
					P_1.Result = result;
				}
				else
				{
					P_1.Result = a;
				}
			}
			else
			{
				P_1.Result = null;
			}
		}

		private static a A(BackgroundWorker P_0, ref A P_1)
		{
			if (string.IsNullOrEmpty(P_1.BTM))
			{
				return a.BtA;
			}
			P_1.BTV = new List<Cy>();
			P_0.ReportProgress(0, (object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYX());
			P_1.BTw = false;
			P_1.BTX = false;
			P_1.BTx = false;
			P_1.BTY = false;
			P_1.BTy = false;
			bW bTN = null;
			P_1.BTv = 0;
			FileStream val = File.OpenRead(P_1.BTM);
			try
			{
				List<string> val2;
				try
				{
					val2 = R.A((Stream)(object)val, null);
				}
				catch
				{
					return a.BtA;
				}
				P_0.ReportProgress(30);
				if (val2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYs()))
				{
					a a = A(P_0, ref P_1, val, ref bTN);
					if (a != 0)
					{
						return a;
					}
				}
				else if (P_1.BTq == bt.avK)
				{
					a a2 = A(P_0, ref P_1, val, ref bTN, val2);
					if (a2 != 0)
					{
						return a2;
					}
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			P_1.BTN = bTN;
			Thread.Sleep(400);
			return a.BTZ;
		}

		private static a A(BackgroundWorker P_0, ref A P_1, FileStream P_2, ref bW P_3)
		{
			Cu cu = null;
			try
			{
				if (R.A((Stream)(object)P_2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYs(), out var val, null))
				{
					cu = new Cu(val);
				}
			}
			catch
			{
				cu = null;
			}
			if (cu != null)
			{
				if (P_1.BTq != 0)
				{
					return CZ.a(P_0, ref P_1, P_2, cu);
				}
				a a = A(P_0, ref P_1, P_2, ref P_3, cu);
				if (a != 0)
				{
					return a;
				}
				return a.BTZ;
			}
			return a.Bta;
		}

		private static a A(BackgroundWorker P_0, ref A P_1, FileStream P_2, ref bW P_3, Cu P_4)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0512: Unknown result type (might be due to invalid IL or missing references)
			//IL_0517: Unknown result type (might be due to invalid IL or missing references)
			List<Cu.A> val = null;
			string text = null;
			Enumerator<Cu.a> enumerator = P_4.BDJ.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Cu.a current = enumerator.Current;
					bool flag = current.BTf == P_1.BTm.ah || (BM.QQ.qP != null && (P_1.BTm.ah == 0 || P_1.BTm.ah == 255)) || current.BTF == 22;
					if ((current.BTF == P_1.BTm.aH || (BM.QQ.qP != null && (P_1.BTm.aH == 0 || P_1.BTm.aH == 255))) && flag && (b(P_1.BTm.ao) || current.BTG.Contains(P_1.BTm.aJ)))
					{
						val = current.BTh;
						text = current.BTg;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (val != null)
			{
				bool flag2 = false;
				List<string> val2 = new List<string>();
				for (int i = 0; i < val.Count; i++)
				{
					Cu.A a = val[i];
					if (a.BTb != null && !val2.Contains(a.BTb))
					{
						val2.Add(a.BTb);
					}
				}
				List<string> val3 = new List<string>();
				for (int j = 0; j < val.Count; j++)
				{
					Cu.A a2 = val[j];
					Stream val4;
					if (string.IsNullOrEmpty(a2.BTB))
					{
						if (!string.IsNullOrEmpty(a2.BTc) && (P_1.BTu == null || P_1.BTu.Count == 0 || a2.BTb == null || P_1.BTu.Contains(a2.BTb)))
						{
							Cy cy = new Cy(null, null, a2.BTb, 0u, a2.BTC, a2.BTa, a2.BTc, a2.BTD, bt.avK, a2.BTd, a2.BTE);
							P_1.BTV.Add(cy);
						}
					}
					else if (R.A((Stream)(object)P_2, a2.BTB, out val4, null))
					{
						Cy cy2 = null;
						if (P_1.BTu == null || P_1.BTu.Count == 0 || a2.BTb == null || P_1.BTu.Contains(a2.BTb))
						{
							if (!string.IsNullOrEmpty(a2.BTB) && (a2.BTB.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()) || a2.BTB.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agQ())))
							{
								flag2 = true;
								string text2 = null;
								cy2 = A(val4, P_1.BTm, a2.BTa, ref P_3, a2.BTB, ref text2);
								if (A(P_3, text2))
								{
									return CZ.a.BTz;
								}
							}
							else
							{
								cy2 = A(val4, P_1.BTm, a2.BTa, a2.BTc, a2.BTD, a2.BTC, bt.avK, a2.BTb, a2.BTd, a2.BTE);
								if (P_1.BTU)
								{
									k k = null;
									if (a2.BTb != null && !A(P_1.BTm, true))
									{
										k = ((!global::A.A.A(P_1.BTm.ao, a2.BTb, out var array, out var flag3) || flag3 || array == null || array.Length < 4) ? null : ((P_1.BTm.aH != 21) ? new k(array[0], array[1], array[2], array[3], 0) : new k(array[3], array[2], array[1], array[0], 0)));
									}
									if (k != null && cy2.BdG.BDv == k && a2.BTb != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ah() && a2.BTb != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aK() && a2.BTb != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aj() && val2.Count > 1)
									{
										cy2 = null;
										val3.Add(a2.BTb);
									}
								}
								if (a2.BTb == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYW())
								{
									k k2 = new k(P_1.BTm.aM, P_1.BTm.am, P_1.BTm.aN, P_1.BTm.an, 0);
									if (cy2.BdG.BDv <= k2)
									{
										cy2 = null;
										val3.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYW());
										val3.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYw());
									}
								}
							}
						}
						if (cy2 != null)
						{
							if (cy2.BdG.BDU < 2)
							{
								return CZ.a.Btb;
							}
							P_1.BTV.Add(cy2);
						}
					}
					P_0.ReportProgress(30 + (j + 1) * 70 / val.Count);
				}
				Enumerator<string> enumerator2 = val3.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						for (int num = P_1.BTV.Count - 1; num >= 0; num--)
						{
							if (P_1.BTV[num].BdH != null && P_1.BTV[num].BdH == current2)
							{
								P_1.BTV.RemoveAt(num);
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				if (P_1.BTs != null && P_1.BTs.Count != 0)
				{
					A(P_0, ref P_1, P_2, P_4);
				}
				if (text != null && (P_3 == null || !flag2))
				{
					Stream val5 = null;
					if (R.A((Stream)(object)P_2, text, out val5, null))
					{
						string text3 = null;
						A(val5, null, null, ref P_3, text, ref text3);
						if (A(P_3, text3))
						{
							return CZ.a.BTz;
						}
					}
				}
				return CZ.a.BTZ;
			}
			return CZ.a.BtB;
		}

		private static void A(BackgroundWorker P_0, ref A P_1, FileStream P_2, Cu P_3)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<Cu.B> enumerator = P_3.BDj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Cu.B current = enumerator.Current;
					Enumerator<bt> enumerator2 = current.BTi.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							bt current2 = enumerator2.Current;
							if (P_1.BTs.ContainsKey(current2) && P_1.BTt.ContainsKey(current2))
							{
								for (int i = 0; i < current.BTj.Count; i++)
								{
									A(current.BTj[i], current2, P_1.BTs[current2], P_1.BTt[current2], ref P_1, P_2);
									P_0.ReportProgress((i + 1) * 100 / current.BTj.Count);
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

		private static a a(BackgroundWorker P_0, ref A P_1, FileStream P_2, Cu P_3)
		{
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (P_1.BTQ)
			{
				Enumerator<Cu.b> enumerator = P_3.BDK.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Cu.b current = enumerator.Current;
						if (current.BTk.Contains(P_1.BTq))
						{
							int num = BM.Qz.A(19236).ax();
							if (current.BTL.Contains(num) && A(P_0, ref P_1, P_2, current.BTl))
							{
								return CZ.a.BTZ;
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			else
			{
				Enumerator<Cu.B> enumerator2 = P_3.BDj.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Cu.B current2 = enumerator2.Current;
						if (current2.BTi.Contains(P_1.BTq) && A(P_0, ref P_1, P_2, current2.BTj))
						{
							return CZ.a.BTZ;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			return CZ.a.BtB;
		}

		private static bool A(BackgroundWorker P_0, ref A P_1, FileStream P_2, List<Cu.A> P_3)
		{
			bool result = false;
			for (int i = 0; i < P_3.Count; i++)
			{
				if (A(P_3[i], P_1.BTq, P_1.BTR, P_1.BTS, ref P_1, P_2))
				{
					result = true;
				}
				P_0.ReportProgress(30 + (i + 1) * 70 / P_3.Count);
			}
			return result;
		}

		private static bool A(Cu.A P_0, bt P_1, k P_2, bool P_3, ref A P_4, FileStream P_5)
		{
			bool result = false;
			if (!string.IsNullOrEmpty(P_0.BTB) && R.A((Stream)(object)P_5, P_0.BTB, out var val, null))
			{
				Cy cy = A(val, P_4.BTm, P_0.BTa, P_0.BTc, P_0.BTD, P_0.BTC, P_1, null, false, null);
				if (cy != null && (P_4.BTQ || A(P_1, P_2, cy.BdG.BDv, P_3)))
				{
					result = true;
					P_4.BTV.Add(cy);
					P_4.BTv++;
				}
			}
			return result;
		}

		private static a A(BackgroundWorker P_0, ref A P_1, FileStream P_2, ref bW P_3, List<string> P_4)
		{
			for (int i = 0; i < P_4.Count; i++)
			{
				string text = P_4[i];
				Stream val = null;
				if (!R.A((Stream)(object)P_2, text, out val, null))
				{
					continue;
				}
				Cy cy = null;
				if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
				{
					string text2 = null;
					cy = A(val, P_1.BTm, null, ref P_3, text, ref text2);
					if (A(P_3, text2))
					{
						return CZ.a.BTz;
					}
				}
				else if (!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYT()))
				{
					cy = A(val, P_1.BTm, null, null, true, 255, bt.avK, null, true, null);
				}
				P_0.ReportProgress(30 + (i + 1) * 70 / P_4.Count);
				if (cy == null)
				{
					continue;
				}
				if (cy.BdG.BDu == CV.BDL)
				{
					if (!P_1.BTw)
					{
						if (P_1.BTX)
						{
							P_1.BTV.Insert(P_1.BTV.Count - 1, cy);
						}
						else
						{
							P_1.BTV.Add(cy);
						}
						P_1.BTw = true;
					}
				}
				else if (cy.BdG.BDu == CV.BDl)
				{
					if (!P_1.BTX)
					{
						P_1.BTV.Add(cy);
						P_1.BTX = true;
					}
				}
				else if (cy.BdG.BDu == CV.BDo)
				{
					if (!P_1.BTx)
					{
						P_1.BTV.Add(cy);
						P_1.BTx = true;
					}
				}
				else if (cy.BdG.BDu == CV.BDQ)
				{
					if (!P_1.BTY)
					{
						P_1.BTV.Add(cy);
						P_1.BTY = true;
					}
				}
				else if (cy.BdG.BDu == CV.BDs)
				{
					if (!P_1.BTy)
					{
						P_1.BTV.Add(cy);
						P_1.BTy = true;
					}
				}
				else if (P_1.BTV.Count != 0)
				{
					P_1.BTV.Insert(0, cy);
				}
				else
				{
					P_1.BTV.Add(cy);
				}
			}
			return CZ.a.BTZ;
		}

		private static bool A(bW P_0, string P_1)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			if (!string.IsNullOrEmpty(P_1))
			{
				string text;
				try
				{
					text = bT.a(P_1);
				}
				catch
				{
					text = null;
				}
				if (!string.IsNullOrEmpty(text))
				{
					Version version = Assembly.GetEntryAssembly().GetName().Version;
					Version val = new Version(text);
					if (version < val)
					{
						return true;
					}
				}
			}
			return false;
		}

		private static void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Expected O, but got Unknown
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Expected O, but got Unknown
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			BM.P();
			GC.Collect();
			if (P_1.Result is a)
			{
				a a = (a)P_1.Result;
				string text = string.Empty;
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm();
				switch (a)
				{
				case a.BtA:
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYx();
					break;
				case a.Bta:
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYY();
					break;
				case a.BtB:
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYy();
					break;
				case a.Btb:
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYZ();
					break;
				case a.BTz:
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYz();
					text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayA();
					break;
				}
				if (BM.qW)
				{
					Console.WriteLine();
					Console.WriteLine(text);
					Environment.Exit(1);
				}
				else
				{
					bE.A((IWin32Window)(object)BM.QQ, text, text2, (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				BM.QQ.qP = null;
				BM.QQ.qp = false;
				BM.QQ.qQ = false;
				BM.QQ.qq = true;
				BM.QQ.qR.Clear();
				global::A.A.D();
				global::A.A.d();
				return;
			}
			A a2 = null;
			bool flag = false;
			if (P_1.Result is A)
			{
				a2 = (A)P_1.Result;
				if (!A(a2))
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				if (!BM.qW)
				{
					BM.QQ.w();
					BM.d();
					((Control)BM.QQ).Refresh();
				}
				bool flag2 = a2.BTq != 0 || a2.BTV.Count - a2.BTv == 0;
				if (flag2 && A(a2.BTm, true))
				{
					if (!BM.qW)
					{
						bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aya(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
				else if (flag2 || A(a2.BTm, false) || CZ.a(a2.BTm))
				{
					if (BM.Qz != null)
					{
						BM.Qz.D();
					}
					if (!BM.qW)
					{
						if (BM.RA != null && ((Control)BM.RA).Visible)
						{
							((Form)BM.RA).Close();
						}
						if (BM.qz != null && ((Control)BM.qz).Visible)
						{
							Bdm = ((Form)BM.qz).Location;
							((Form)BM.qz).Close();
							BdM = true;
						}
						else
						{
							BdM = false;
						}
					}
					BackgroundWorker val = new BackgroundWorker
					{
						WorkerReportsProgress = true,
						WorkerSupportsCancellation = false
					};
					object obj = CZ.b.BtL;
					if (obj == null)
					{
						DoWorkEventHandler val2 = CZ.a;
						CZ.b.BtL = val2;
						obj = (object)val2;
					}
					val.DoWork += (DoWorkEventHandler)obj;
					object obj2 = CZ.b.Btl;
					if (obj2 == null)
					{
						ProgressChangedEventHandler val3 = BM.B;
						CZ.b.Btl = val3;
						obj2 = (object)val3;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj2;
					object obj3 = CZ.b.BtM;
					if (obj3 == null)
					{
						RunWorkerCompletedEventHandler val4 = CZ.a;
						CZ.b.BtM = val4;
						obj3 = (object)val4;
					}
					val.RunWorkerCompleted += (RunWorkerCompletedEventHandler)obj3;
					if (a2.BTn)
					{
						BM.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayB(), a2.BTW);
					}
					else
					{
						BM.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayb(), a2.BTW);
					}
					val.RunWorkerAsync((object)a2);
				}
				else
				{
					if (BM.qW)
					{
						Console.WriteLine();
						Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayC());
						Environment.Exit(1);
					}
					else
					{
						bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					BM.QQ.qP = null;
					BM.QQ.qp = false;
					BM.QQ.qQ = false;
					BM.QQ.qq = true;
					BM.QQ.qR.Clear();
					global::A.A.D();
					global::A.A.d();
				}
			}
			else
			{
				if (BM.qW)
				{
					Console.WriteLine();
					Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayc());
					Environment.Exit(1);
				}
				else
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayc(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				BM.QQ.qP = null;
				BM.QQ.qp = false;
				BM.QQ.qQ = false;
				BM.QQ.qq = true;
				BM.QQ.qR.Clear();
				global::A.A.D();
				global::A.A.d();
			}
		}

		private static bool A(A P_0)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			bool flag2 = false;
			Enumerator<Cy> enumerator = P_0.BTV.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Cy current = enumerator.Current;
					bool flag3 = current.BdK != bt.avK;
					if (!string.IsNullOrEmpty(current.BdJ))
					{
						if (current.Bdj && !flag3)
						{
							P_0.BTW.Add(current.Bdi + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo());
						}
						continue;
					}
					if (current.Bdg != null)
					{
						if (flag3)
						{
							if (!flag2 && !flag && !P_0.BTO && P_0.BTW.Count != 0 && P_0.BTq == bt.avK && P_0.BTm.aH != 22)
							{
								a(P_0);
								B(P_0);
								b(P_0);
								flag2 = true;
							}
							P_0.BTW.Add(current.Bdi + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo());
							continue;
						}
						if (current.BdG.BDU >= 2)
						{
							P_0.BTW.Add(current.Bdi + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo());
							continue;
						}
						switch (current.BdG.BDu)
						{
						case CV.BDM:
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayD());
							break;
						case CV.BDP:
						case CV.BDq:
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayd());
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayE());
							break;
						case CV.BDm:
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aye());
							break;
						case CV.BDn:
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayF());
							break;
						case CV.BDp:
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayf());
							break;
						case CV.BDN:
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayG());
							break;
						case CV.BDL:
						case CV.BDo:
						case CV.BDQ:
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayg());
							if (P_0.BTw && P_0.BTX)
							{
								P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayH());
							}
							else
							{
								P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayh());
							}
							break;
						case CV.BDl:
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayI());
							break;
						case CV.BDs:
							P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayi());
							break;
						}
						continue;
					}
					flag = true;
					break;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (!flag2 && !flag && !P_0.BTO && P_0.BTW.Count != 0 && P_0.BTq == bt.avK && (P_0.BTu == null || P_0.BTu.Count == 0 || P_0.BTu.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ah()) || P_0.BTu.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYr())) && P_0.BTm.aH != 22)
			{
				a(P_0);
				B(P_0);
				b(P_0);
			}
			return !flag;
		}

		private static void a(A P_0)
		{
			if (P_0.BTn)
			{
				P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayJ());
			}
			else
			{
				P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayj());
			}
		}

		private static void B(A P_0)
		{
			P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayK());
		}

		private static void b(A P_0)
		{
			if (P_0.BTm.aH == 21)
			{
				P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayk());
			}
			else
			{
				P_0.BTW.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayL());
			}
		}

		private static void a(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			lock (BM.qh)
			{
				BM.qI |= 512;
			}
			B b = new B();
			b.BtC = false;
			b.Btc = false;
			b.BtD = false;
			if (P_1.Argument is A)
			{
				A a = (A)P_1.Argument;
				F f = (b.BtJ = a.BTm);
				b.Bti = 0;
				if (a.BTs != null)
				{
					Enumerator<bt, k> enumerator = a.BTs.Keys.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							bt current = enumerator.Current;
							if (current == bt.avU || current == bt.avu || current == bt.avV || current == bt.avv)
							{
								k k = a.BTs[current];
								bool flag = false;
								if (a.BTt.ContainsKey(current))
								{
									flag = a.BTt[current];
								}
								if (k < A(flag))
								{
									b.Bti++;
								}
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				b.BtI = a.BTp;
				b.Bte = a.BTQ;
				b.BtF = a.BTq;
				b.Btf = a.BTR;
				b.BtG = a.BTr;
				b.Btg = a.BTs;
				b.BtH = a.BTT;
				BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
				if (a.BTV.Count - a.BTv != 0)
				{
					if (bx.A(f.aH))
					{
						b.Btc = cA.A(a, f, val, P_1, b, out b.BtC);
						if (!b.Btc)
						{
							return;
						}
					}
					else
					{
						b.Btc = Cz.A(a, f, val, P_1, b, out b.BtC);
						if (!b.Btc)
						{
							return;
						}
					}
					Thread.Sleep(200);
					global::A.A.I(f.ao);
					if ((a.BTu == null || a.BTu.Count == 0 || a.BTu.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ah()) || a.BTu.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYr())) && f.aH != 22)
					{
						if (!A(a, a.BTN, val, out var flag2))
						{
							if (a.BTO)
							{
								b.BtC = false;
								b.Btc = false;
								b.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayN();
								P_1.Result = b;
								global::A.A.I(f.ao);
							}
							else
							{
								b.BtC = false;
								b.Btc = false;
								b.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayn();
								P_1.Result = b;
								global::A.A.I(f.ao);
							}
							return;
						}
						if (flag2)
						{
							string text;
							if (a.BTP != null)
							{
								b.Bth = a.BTP;
								text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayl() + a.BTP + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayM();
							}
							else
							{
								text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aym();
							}
							if (string.IsNullOrEmpty(b.Btd))
							{
								b.Btd = text;
							}
							else
							{
								b.Btd = b.Btd + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv() + text;
							}
						}
					}
				}
				else
				{
					b.BtC = true;
					b.Btc = true;
				}
				if (a.BTv != 0)
				{
					if (a.BTq == bt.avK && !A(f, null, -1))
					{
						b.BtE = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tJ();
						P_1.Result = b;
						global::A.A.I(f.ao);
						return;
					}
					if (Cz.A(a, f, val, P_1, b))
					{
						b.BtD = true;
					}
					else
					{
						b.BtD = false;
					}
				}
				else
				{
					b.BtD = true;
				}
				P_1.Result = b;
				Thread.Sleep(100);
				global::A.A.I(f.ao);
			}
			else
			{
				b.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayO();
				P_1.Result = b;
			}
		}

		private static void a(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Invalid comparison between Unknown and I4
			//IL_0568: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0641: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
			BM.P();
			BM.Q();
			GC.Collect();
			BM.QQ.qP = null;
			BM.QQ.qp = false;
			BM.QQ.qQ = false;
			BM.QQ.qq = true;
			BM.QQ.qR.Clear();
			global::A.A.D();
			global::A.A.d();
			B b = (B)P_1.Result;
			string text = string.Empty;
			if (!string.IsNullOrEmpty(b.BtE))
			{
				text += b.BtE;
			}
			if (!string.IsNullOrEmpty(b.Btd))
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
				}
				if (b.BtI && BM.Qz != null && BM.a(BM.Qz))
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayo();
				}
				text += b.Btd;
			}
			bool flag = false;
			if (BM.qW)
			{
				if (!string.IsNullOrEmpty(text))
				{
					Console.WriteLine();
					Console.WriteLine(text);
				}
			}
			else if (b.BtC && !string.IsNullOrEmpty(b.Btd) && b.Bth != null)
			{
				string text2 = ((!b.BtD) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayP());
				if ((int)bE.A((IWin32Window)(object)BM.QQ, text, text2, (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
				{
					flag = true;
				}
			}
			else if (!string.IsNullOrEmpty(text))
			{
				string text3;
				if (b.BtC && b.BtD)
				{
					text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayP();
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayp() + text;
				}
				else
				{
					text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm();
				}
				bE.A((IWin32Window)(object)BM.QQ, text, text3, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			if (b.Btc)
			{
				if (b.Bte || A(b.BtJ, null, -1))
				{
					if (b.BtI)
					{
						A(b.BtJ);
					}
					lock (BM.qh)
					{
						BM.qI &= -513;
					}
					if (flag)
					{
						bW bW = Cq.a(b.Bth);
						if (bW != null)
						{
							BM.QQ.a(null, b.Bth, bW);
						}
						else
						{
							bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						}
					}
					else if (b.BtJ.aH == 22)
					{
						if (!BM.qW)
						{
							bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayP(), (MessageBoxButtons)0);
						}
					}
					else
					{
						if (BM.Qz != null)
						{
							BM.Qz.D();
						}
						if (BM.QQ.qi)
						{
							bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayq(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayP(), (MessageBoxButtons)0);
							BM.QQ.qi = false;
							global::A.A.b();
						}
						if (!BM.qW)
						{
							if (BM.Qz != null)
							{
								BM.Qz.A((IWin32Window)(object)BM.QQ);
							}
							bool flag2 = false;
							bool flag3 = false;
							bool flag4 = false;
							bool flag5 = false;
							if (BM.Qz.C())
							{
								flag5 = Bz.A(BM.Qz, out flag2, out flag3, out flag4);
							}
							if (flag2)
							{
								BM.b(true);
							}
							else if (!flag4)
							{
								BM.a(true);
								((ToolStripItem)BM.QQ.rm).Enabled = true;
								((ToolStripItem)BM.QQ.rN).Enabled = true;
								((ToolStripItem)BM.QQ.rM).Enabled = true;
								((ToolStripItem)BM.QQ.rR).Enabled = true;
								((ToolStripItem)BM.QQ.rt).Enabled = true;
								((ToolStripItem)BM.QQ.Ri).Enabled = true;
								((ToolStripItem)BM.QQ.RZ).Enabled = true;
								((ToolStripItem)BM.QQ.Sb).Enabled = true;
								((ToolStripItem)BM.QQ.Sc).Enabled = true;
								((ToolStripItem)BM.QQ.SC).Enabled = true;
								BM.E();
								BM.QZ = string.Empty;
								BM.A(true);
								if (Be.nv && (BM.qI & 0x800) == 0)
								{
									BM.TG.A();
								}
								if (flag5 && ((ToolStripItem)BM.QQ.rc).Enabled && !flag3)
								{
									((ToolStripItem)BM.QQ.rc).PerformClick();
								}
							}
							if (b.Bti > 1)
							{
								bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayR() + ((b.BtJ.aH == 21) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHl() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSF()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayr(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayS(), (MessageBoxButtons)0);
							}
							else if (b.Bti == 1)
							{
								bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ays() + ((b.BtJ.aH == 21) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHl() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSF()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayT(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayS(), (MessageBoxButtons)0);
							}
							else if (ca.A(b.BtF, b.Btf, b.BtG, b.Btg, b.BtH))
							{
								bE.A((IWin32Window)(object)BM.QQ, ca.A(false, false, true), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayt(), (MessageBoxButtons)0, (MessageBoxIcon)48);
							}
						}
					}
				}
				else
				{
					lock (BM.qh)
					{
						BM.qI &= -513;
					}
					if (BM.qW)
					{
						Console.WriteLine();
						Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tJ());
						Environment.Exit(1);
					}
					else
					{
						bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tJ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
			}
			else
			{
				lock (BM.qh)
				{
					BM.qI &= -513;
				}
				if (b.BtJ.aH != 21 && !A(b.BtJ, true) && !a(b.BtJ) && !BM.qW)
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				if (BM.qW)
				{
					Environment.Exit(1);
				}
			}
			if (BdM && !BM.qW)
			{
				if (BM.qz != null)
				{
					((Component)BM.qz).Dispose();
				}
				BM.qz = new BX();
				((Form)BM.qz).Show((IWin32Window)(object)BM.QQ);
				((Form)BM.qz).Location = Bdm;
				BdM = false;
			}
			if (BM.qW)
			{
				if (b.BtC && b.Btc && b.BtD)
				{
					Environment.Exit(0);
				}
				else
				{
					Environment.Exit(1);
				}
			}
		}

		private static void A(F P_0)
		{
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz == null || !BM.a(BM.Qz))
			{
				return;
			}
			if (BM.Qz.A(9500).ax() == 0)
			{
				if (!global::A.A.b(P_0.ao, out var _))
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayu(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayV(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayu(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private static bool A(A P_0, bW P_1, BackgroundWorker P_2, out bool P_3)
		{
			F bTm = P_0.BTm;
			if (P_0.BTO)
			{
				P_3 = false;
				if (A(bTm, null, -1))
				{
					if (BM.Qz != null)
					{
						BM.Qz.D();
					}
					return true;
				}
				return false;
			}
			bool flag = false;
			P_3 = false;
			if (P_1 != null)
			{
				int num = P_0.BTW.Count - P_0.BTv - 3;
				int num2 = num + 1;
				int num3 = num + 2;
				P_2.ReportProgress(0, (object)num);
				string text = bT.A(P_1.axS, P_1.axs, P_1.axT, P_1.axt, true);
				P_2.ReportProgress(10, (object)num);
				if (!string.IsNullOrEmpty(text))
				{
					bool flag2 = BM.QQ.qi && !string.IsNullOrEmpty(BM.QQ.qj);
					if (flag2)
					{
						bW bW = Cq.a(BM.QQ.qj);
						if (bW != null)
						{
							string text2 = bT.A(bW.axS, bW.axs, bW.axT, bW.axt, true);
							if (!string.IsNullOrEmpty(text2))
							{
								Framework framework = new Framework(text, P_1.axS, P_1.axs, P_1.axT);
								framework.aXc = bTm.ao;
								Framework framework2 = new Framework(text2, bW.axS, bW.axs, bW.axT);
								framework2.aXc = bTm.ao;
								P_2.ReportProgress(20, (object)num);
								if (framework2.a() == bV.A.Brc)
								{
									P_2.ReportProgress(40, (object)num);
									if (framework.a() == bV.A.Brc)
									{
										P_2.ReportProgress(60, (object)num);
										new Cq(BM.QQ.qj, framework2).A(out var _);
										framework.C(framework.aWS);
										framework.A(framework2, framework.aWS, true, false);
										framework.A(framework2, false);
										P_2.ReportProgress(80, (object)num);
										framework.c(framework.aWS);
										framework.N();
										framework.a(framework.awj);
										framework.a((HashSet<DataIdAndAttrId>)null);
										P_2.ReportProgress(100, (object)num);
										BM.Qz = framework;
										if (A(bTm, P_2, num2))
										{
											try
											{
												if (BM.Qz != null)
												{
													BM.Qz.D();
												}
												BM.QQ.A(P_2, num3, false);
												flag = true;
											}
											catch
											{
											}
										}
									}
								}
							}
						}
					}
					else if (BM.Qz != null && !P_0.BTo)
					{
						Framework framework3 = new Framework(text, P_1.axS, P_1.axs, P_1.axT);
						framework3.aXc = bTm.ao;
						if (framework3.a() == bV.A.Brc)
						{
							P_2.ReportProgress(50, (object)num);
							framework3.C(framework3.aWS);
							framework3.A(BM.Qz, framework3.aWS, true, false);
							framework3.A(BM.Qz, false);
							P_2.ReportProgress(70, (object)num);
							framework3.c(framework3.aWS);
							framework3.N();
							framework3.a(framework3.awj);
							framework3.a((HashSet<DataIdAndAttrId>)null);
							if (framework3.awZ == 21)
							{
								P_2.ReportProgress(90, (object)num);
								if (framework3.f())
								{
									cb.A(framework3, null);
									cb.a();
									if (framework3.awP.h())
									{
										cb.B();
									}
								}
							}
							P_2.ReportProgress(100, (object)num);
							BM.Qz = framework3;
							if (A(bTm, P_2, num2))
							{
								try
								{
									if (BM.Qz != null)
									{
										BM.Qz.D();
									}
									BM.QQ.A(P_2, num3, false);
									flag = true;
								}
								catch
								{
								}
							}
						}
					}
					if (!flag || (!flag2 && BM.Qz == null))
					{
						Framework framework4 = new Framework(text, P_1.axS, P_1.axs, P_1.axT);
						if (framework4.a() == bV.A.Brc)
						{
							P_2.ReportProgress(60, (object)num);
							framework4.A(framework4.aWS);
							P_2.ReportProgress(70, (object)num);
							framework4.a(framework4.awj);
							framework4.a((HashSet<DataIdAndAttrId>)null);
							if (framework4.awZ == 21)
							{
								P_2.ReportProgress(90, (object)num);
								if (framework4.f())
								{
									cb.A(framework4, null);
									cb.a();
									if (framework4.awP.h())
									{
										cb.B();
									}
								}
							}
							P_2.ReportProgress(100, (object)num);
							framework4.aXc = bTm.ao;
							BM.Qz = framework4;
							if (A(bTm, P_2, num2))
							{
								try
								{
									if (BM.Qz != null)
									{
										BM.Qz.D();
									}
									BM.QQ.A(P_2, num3, false);
									flag = true;
									P_3 = true;
								}
								catch
								{
								}
							}
						}
					}
				}
			}
			return flag;
		}

		internal static List<CY> A(BackgroundWorker P_0, int P_1, int P_2, k P_3, ushort P_4, string P_5, k P_6, bool P_7, bt P_8, k P_9, bool P_10)
		{
			lock (Bdn)
			{
				if (P_0 != null && P_0.WorkerReportsProgress)
				{
					P_0.ReportProgress(0);
				}
				List<CY> val = new List<CY>();
				if (!Directory.Exists(Bdl))
				{
					return val;
				}
				string[] files = Directory.GetFiles(Bdl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCe());
				for (int i = 0; i < files.Length; i++)
				{
					string text = files[i];
					if (P_0 != null && P_0.CancellationPending)
					{
						break;
					}
					CY cY = A(text, P_1, P_2, P_4, P_5, P_6, P_8, P_9, P_10);
					if (cY != null)
					{
						if (val.Count == 0)
						{
							if (P_8 == bt.avK)
							{
								if (!P_7 || cY.BdF[0].BdC.axT.d())
								{
									val.Add(cY);
								}
							}
							else
							{
								Cx cx = A(cY.Bdf, P_8, P_9, P_10);
								if (cx != null && (!P_7 || cx.Bdd.d()))
								{
									val.Add(cY);
								}
							}
						}
						else
						{
							for (int j = 0; j < val.Count; j++)
							{
								if (P_8 == bt.avK)
								{
									if (!P_7 || cY.BdF[0].BdC.axT.d())
									{
										if (cY.BdF[0].BdC.axT > val[j].BdF[0].BdC.axT)
										{
											val.Insert(j, cY);
											break;
										}
										if (j == val.Count - 1)
										{
											val.Add(cY);
											break;
										}
									}
									continue;
								}
								Cx cx2 = A(cY.Bdf, P_8, P_9, P_10);
								Cx cx3 = A(val[j].Bdf, P_8, P_9, P_10);
								if (cx2 == null || cx3 == null || (P_7 && !cx2.Bdd.d()))
								{
									continue;
								}
								if (cx2.Bdd > cx3.Bdd)
								{
									if (j == 0)
									{
										val.Insert(j, cY);
									}
									else if (A(val[j - 1].Bdf, P_8, P_9, P_10).Bdd != cx2.Bdd)
									{
										val.Insert(j, cY);
									}
									break;
								}
								if (j == val.Count - 1)
								{
									if (cx2.Bdd != cx3.Bdd)
									{
										val.Add(cY);
									}
									break;
								}
							}
						}
					}
					if (P_0 != null && P_0.WorkerReportsProgress)
					{
						P_0.ReportProgress((i + 1) * 90 / files.Length);
					}
				}
				if (P_0 != null && P_0.CancellationPending)
				{
					val.Clear();
				}
				else
				{
					CU.a();
					if (P_0 != null && P_0.WorkerReportsProgress)
					{
						P_0.ReportProgress(100);
					}
				}
				return val;
			}
		}

		internal static CY A(string P_0, int P_1, int P_2, ushort P_3, string P_4, k P_5, bt P_6, k P_7, bool P_8)
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			CY cY = CU.A(P_0);
			if (cY == null)
			{
				List<CW> val = a(P_0);
				List<Cw> val2 = A(P_0);
				if (val.Count == 0 && val2.Count == 0)
				{
					return null;
				}
				cY = A(P_0, val, val2);
				CU.A(cY, false);
			}
			if (cY.BdF.Count == 0 && P_6 != 0 && cY.Bdf.Count != 0)
			{
				if (A(cY.Bdf, P_6, P_7, P_8) == null)
				{
					return null;
				}
			}
			else
			{
				bool flag = false;
				Enumerator<CX> enumerator = cY.BdF.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CX current = enumerator.Current;
						if (!Ct.A(current, out var _, out var _))
						{
							bool flag3 = false;
							if (current.BdC != null)
							{
								flag3 = current.BdC.axs == P_2 || current.BdC.axS == 22;
							}
							if (current.BdC != null && current.BdC.axS == P_1 && flag3 && (P_5 == null || current.BdC.axT >= P_5) && (b(P_4) || current.Bdc.Contains(P_3)))
							{
								flag = true;
								break;
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (!flag)
				{
					return null;
				}
				if (P_6 != 0 && A(cY.Bdf, P_6, P_7, P_8) == null)
				{
					return null;
				}
			}
			return cY;
		}

		internal static CY A(string P_0, List<CW> P_1, List<Cw> P_2)
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			CY cY = new CY();
			cY.BdE = P_0;
			try
			{
				System.DateTime creationTime = File.GetCreationTime(P_0);
				System.DateTime lastWriteTime = File.GetLastWriteTime(P_0);
				System.DateTime dateTime = ((lastWriteTime > creationTime) ? lastWriteTime : creationTime);
				cY.Bde = N.A(dateTime, true, false);
			}
			catch
			{
			}
			Enumerator<CW> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CW current = enumerator.Current;
					CX cX = new CX
					{
						BdC = current.BDy,
						Bdc = new List<ushort>()
					};
					if (current.BDZ != null)
					{
						cX.Bdc.AddRange((System.Collections.Generic.IEnumerable<ushort>)current.BDZ);
					}
					cY.BdF.Add(cX);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<Cw> enumerator2 = P_2.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					Cw current2 = enumerator2.Current;
					Cx cx = new Cx();
					cx.BdD = current2.Bda;
					cx.Bdd = current2.BdB;
					cY.Bdf.Add(cx);
				}
				return cY;
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		internal static Cx A(List<Cx> P_0, bt P_1, k P_2, bool P_3)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<Cx> enumerator = P_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Cx current = enumerator.Current;
					if (current.BdD == P_1 && A(P_1, P_2, current.Bdd, P_3))
					{
						return current;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return null;
		}

		internal static ValueTuple<string, string> A(BackgroundWorker P_0, bt P_1, int P_2)
		{
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			P_0.ReportProgress(0);
			try
			{
				if (!Directory.Exists(Bdl))
				{
					return new ValueTuple<string, string>((string)null, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayv());
				}
				k k = null;
				string text = null;
				bool flag = false;
				string[] files = Directory.GetFiles(Bdl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCe());
				for (int i = 0; i < files.Length; i++)
				{
					string text2 = files[i];
					CY cY = CU.A(text2);
					if (cY == null || (cY.BdF.Count == 0 && cY.Bdf.Count == 0))
					{
						FileStream val = File.OpenRead(text2);
						try
						{
							if (R.A((Stream)(object)val, null).Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYs()))
							{
								Cu cu = null;
								try
								{
									if (R.A((Stream)(object)val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYs(), out var val2, null))
									{
										cu = new Cu(val2);
									}
								}
								catch
								{
									cu = null;
								}
								if (cu != null && cu.BDK.Count != 0)
								{
									Enumerator<Cu.b> enumerator = cu.BDK.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											Cu.b current = enumerator.Current;
											if (!current.BTk.Contains(P_1))
											{
												continue;
											}
											flag = true;
											if (current.BTL.Contains(P_2))
											{
												if (k == null || cu.BDi > k)
												{
													k = cu.BDi;
													text = text2;
												}
												break;
											}
										}
									}
									finally
									{
										((System.IDisposable)enumerator).Dispose();
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)val)?.Dispose();
						}
					}
					P_0.ReportProgress((i + 1) * 100 / files.Length);
				}
				if (text == null)
				{
					if (flag)
					{
						return new ValueTuple<string, string>((string)null, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayW());
					}
					return new ValueTuple<string, string>((string)null, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayw());
				}
				return new ValueTuple<string, string>(text, (string)null);
			}
			catch (System.Exception ex)
			{
				string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayX() + ex.Message;
				return new ValueTuple<string, string>((string)null, text3);
			}
		}

		internal static bool b(string P_0)
		{
			if (P_0 != null && P_0.Length == 12)
			{
				return P_0.Substring(4, 2) == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayx();
			}
			return false;
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void A(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = Bdo;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Bdo, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void a(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = Bdo;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Bdo, val3, val2);
			}
			while (val != val2);
		}

		internal static bool a(F P_0)
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayY() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
			EventHandler bdo = Bdo;
			if (bdo != null)
			{
				bdo.Invoke((object)null, EventArgs.Empty);
			}
			Stopwatch val = new Stopwatch();
			val.Start();
			while (BM.C(false))
			{
				Thread.Sleep(100);
				if (val.ElapsedMilliseconds > 2000)
				{
					val.Stop();
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayy() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayZ(), true);
					return false;
				}
			}
			val.Stop();
			BdO = true;
			lock (BM.qh)
			{
				BM.qI |= 256;
			}
			Thread.Sleep(300);
			global::A.A.G(P_0.ao);
			bool flag = bx.A(P_0.aH);
			if (flag)
			{
				P_0.aS = true;
			}
			bool flag2 = false;
			int num = 3;
			do
			{
				num--;
				global::A.A.B(P_0.ao);
				if (flag)
				{
					Thread.Sleep(1000);
				}
				else if (P_0.aH == 22 || P_0.aH == 21)
				{
					Thread.Sleep(1500);
					global::A.A.B(P_0.ao);
					Thread.Sleep(1500);
				}
				else
				{
					Thread.Sleep(200);
				}
				F f = global::A.A.F(P_0.ao);
				if (f != null)
				{
					if (A(f, false))
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayz() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
						flag2 = true;
						continue;
					}
					N.A(string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZA(),
						P_0.ao,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZa(),
						num.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZB()
					}), true);
				}
				else
				{
					N.A(string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZA(),
						P_0.ao,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZb(),
						num.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZB()
					}), true);
				}
			}
			while (num != 0 && !flag2);
			if (!flag2)
			{
				BM.b(false);
			}
			BdO = false;
			return flag2;
		}

		internal static bool A(F P_0, BackgroundWorker P_1 = null, int P_2 = -1)
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZC() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
			EventHandler bdo = Bdo;
			if (bdo != null)
			{
				bdo.Invoke((object)null, EventArgs.Empty);
			}
			if (P_1 != null)
			{
				if (P_2 == -1)
				{
					P_1.ReportProgress(0);
				}
				else
				{
					P_1.ReportProgress(0, (object)P_2);
				}
			}
			Stopwatch val = new Stopwatch();
			val.Start();
			while (BM.C(false))
			{
				Thread.Sleep(100);
				if (val.ElapsedMilliseconds > 2000)
				{
					val.Stop();
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZc() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayZ(), true);
					return false;
				}
			}
			val.Stop();
			bool num = global::A.A.E(P_0.ao) == g.BI || global::A.A.E(P_0.ao) == g.Bj;
			global::A.A.A(P_0.ao, true);
			global::A.A.f(P_0.ao);
			if (global::A.A.E(P_0.ao) == g.Bj)
			{
				Thread.Sleep(2000);
			}
			bool flag = false;
			if (num)
			{
				int num2 = ((P_0.aH != 21) ? 3 : 50);
				int num3 = num2;
				do
				{
					num3--;
					global::A.A.B(P_0.ao);
					Thread.Sleep(700);
					F f = global::A.A.F(P_0.ao);
					if (f != null)
					{
						if (!A(f, true))
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZD() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
							flag = true;
						}
						else
						{
							N.A(string.Concat(new string[5]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZd(),
								P_0.ao,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZE(),
								num3.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZB()
							}), true);
						}
					}
					else
					{
						N.A(string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZd(),
							P_0.ao,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZb(),
							num3.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZB()
						}), true);
					}
					if (P_1 != null)
					{
						int num4 = Math.Min(100, (num2 - num3) * 100 / (num2 / 2));
						if (P_2 == -1)
						{
							P_1.ReportProgress(num4);
						}
						else
						{
							P_1.ReportProgress(num4, (object)P_2);
						}
					}
				}
				while (num3 != 0 && !flag);
				if (flag && P_1 != null)
				{
					if (P_2 == -1)
					{
						P_1.ReportProgress(100);
					}
					else
					{
						P_1.ReportProgress(100, (object)P_2);
					}
				}
			}
			global::A.A.A(P_0.ao, false);
			return flag;
		}

		internal static bool A(F P_0, bool P_1 = true)
		{
			bool flag = P_0.a() || (P_1 && P_0.A());
			if (flag)
			{
				lock (BM.qh)
				{
					BM.qI |= 256;
					BM.qI &= -5;
					BM.qI &= -33;
					BM.qI &= -9;
					BM.qI &= -65;
					BM.qI &= -17;
					BM.qI &= -129;
				}
				if (((uint)BM.qI & 0x400u) != 0)
				{
					BM.QQ.ae(null, null);
				}
			}
			else
			{
				lock (BM.qh)
				{
					BM.qI &= -257;
				}
			}
			return flag;
		}
	}
	internal static class Cz
	{
		internal static bool A(CZ.A P_0, F P_1, BackgroundWorker P_2, DoWorkEventArgs P_3, CZ.B P_4, out bool P_5)
		{
			return A(true, false, P_0, P_1, P_2, P_3, P_4, out P_5);
		}

		internal static bool A(CZ.A P_0, F P_1, BackgroundWorker P_2, DoWorkEventArgs P_3, CZ.B P_4)
		{
			bool flag;
			return A(false, true, P_0, P_1, P_2, P_3, P_4, out flag);
		}

		private static bool A(bool P_0, bool P_1, CZ.A P_2, F P_3, BackgroundWorker P_4, DoWorkEventArgs P_5, CZ.B P_6, out bool P_7)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_067d: Unknown result type (might be due to invalid IL or missing references)
			//IL_068a: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			System.DateTime now = System.DateTime.Now;
			bool flag = false;
			P_7 = true;
			Enumerator<Cy> enumerator = P_2.BTV.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Cy current = enumerator.Current;
					bool flag2 = current.BdK != bt.avK;
					if (!string.IsNullOrEmpty(current.BdJ))
					{
						if (P_1)
						{
							continue;
						}
						int num = P_2.BTV.IndexOf(current);
						int num2 = 0;
						for (int i = 0; i < num; i++)
						{
							if (!P_2.BTV[i].Bdj)
							{
								num2++;
							}
						}
						int num3 = num - num2;
						if (current.BdJ == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZF())
						{
							continue;
						}
						if (current.BdJ == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZf())
						{
							flag = true;
						}
						else if (current.BdJ == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZG())
						{
							if (current.Bdj)
							{
								P_4.ReportProgress(0, (object)num3);
							}
							if (!CZ.A(P_3, false))
							{
								CZ.a(P_3);
							}
							if (current.Bdj)
							{
								P_4.ReportProgress(100, (object)num3);
								Thread.Sleep(500);
							}
						}
						else if (current.BdJ == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZg())
						{
							if (current.Bdj)
							{
								P_4.ReportProgress(0, (object)num3);
							}
							if (CZ.A(P_3, false))
							{
								CZ.A(P_3);
							}
							if (current.Bdj)
							{
								P_4.ReportProgress(100, (object)num3);
								Thread.Sleep(500);
							}
						}
						else if (current.BdJ == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZH())
						{
							if (current.Bdj)
							{
								P_4.ReportProgress(0, (object)num3);
							}
							if (!A(current, P_2))
							{
								P_7 = false;
								string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZh();
								if (string.IsNullOrEmpty(P_6.Btd))
								{
									P_6.Btd = text;
								}
								else
								{
									P_6.Btd = P_6.Btd + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv() + text;
								}
								P_5.Result = P_6;
								global::A.A.I(P_3.ao);
								return false;
							}
							if (current.Bdj)
							{
								P_4.ReportProgress(100, (object)num3);
								Thread.Sleep(500);
							}
						}
						else
						{
							if (!(current.BdJ == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZI()))
							{
								continue;
							}
							if (current.Bdj)
							{
								P_4.ReportProgress(0, (object)num3);
							}
							if (num3 == 0 || System.DateTime.Now - now < TimeSpan.FromMilliseconds(2000L, 0L))
							{
								Thread.Sleep(2000);
							}
							global::A.A.a(P_3.ao, 20000u);
							if (global::A.A.D(P_3.ao, out var _))
							{
								if (current.Bdj)
								{
									P_4.ReportProgress(100, (object)num3);
									Thread.Sleep(500);
								}
								continue;
							}
							P_7 = false;
							string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZi();
							if (string.IsNullOrEmpty(P_6.Btd))
							{
								P_6.Btd = text2;
							}
							else
							{
								P_6.Btd = P_6.Btd + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv() + text2;
							}
							if (current.Bdk)
							{
								P_5.Result = P_6;
								global::A.A.I(P_3.ao);
								return false;
							}
							Thread.Sleep(500);
						}
						continue;
					}
					if (current.Bdg != null)
					{
						if ((P_0 && flag2) || (P_1 && !flag2))
						{
							continue;
						}
						string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSX();
						int num6;
						if (current.BdG.BDU >= 2)
						{
							int num4 = P_2.BTV.IndexOf(current);
							int num5 = 0;
							for (int j = 0; j < num4; j++)
							{
								if (!P_2.BTV[j].Bdj)
								{
									num5++;
								}
							}
							num6 = num4 - num5;
							if (flag2 && P_2.BTq == bt.avK && P_2.BTV.Count - P_2.BTv != 0 && !P_2.BTO)
							{
								num6 += 3;
							}
							if (flag && num4 >= 1 && P_2.BTV[num4 - 1].Bdj)
							{
								num6--;
							}
							P_4.ReportProgress(0, (object)num6);
							text3 = P_2.BTW[num6];
							if ((!flag2) ? A(current, P_2, ref flag, P_4, ref num6) : A(current, P_2, P_4, num6))
							{
								P_4.ReportProgress(100, (object)num6);
								Thread.Sleep(500);
								continue;
							}
							P_7 = false;
							string text4 = (text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo()) ? text3.Substring(0, text3.Length - 1) : text3);
							if (flag2)
							{
								string text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZJ() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZj();
								if (string.IsNullOrEmpty(P_6.BtE))
								{
									P_6.BtE = text5;
								}
								else
								{
									P_6.BtE = P_6.BtE + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv() + text5;
								}
								continue;
							}
							if (current.Bdk)
							{
								string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZK() + text4;
								if (string.IsNullOrEmpty(P_6.Btd))
								{
									P_6.Btd = text6;
								}
								else
								{
									P_6.Btd = P_6.Btd + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv() + text6;
								}
								P_5.Result = P_6;
								global::A.A.I(P_3.ao);
								return false;
							}
							string text7 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZJ() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZj();
							if (!string.IsNullOrEmpty(current.BdL))
							{
								text7 = text7 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy() + current.BdL;
							}
							if (string.IsNullOrEmpty(P_6.Btd))
							{
								P_6.Btd = text7;
							}
							else
							{
								P_6.Btd = P_6.Btd + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv() + text7;
							}
							Thread.Sleep(500);
							continue;
						}
						if (flag2)
						{
							P_7 = false;
							P_6.BtE = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZk();
							P_5.Result = P_6;
							global::A.A.I(P_3.ao);
							return false;
						}
						flag = false;
						int num7 = P_2.BTV.IndexOf(current);
						if (current.BdG.BDu == CV.BDL)
						{
							flag = true;
							num6 = num7;
							P_4.ReportProgress(0, (object)num6);
						}
						else
						{
							num6 = ((!P_2.BTw || !P_2.BTX) ? num7 : ((num7 >= P_2.BTW.Count - 5) ? (1 + num7) : num7));
							if (current.BdG.BDu == CV.BDn)
							{
								if (num6 == 0 || System.DateTime.Now - now < TimeSpan.FromMilliseconds(2000L, 0L))
								{
									Thread.Sleep(2000);
								}
								global::A.A.a(P_3.ao, 20000u);
								if (!global::A.A.D(P_3.ao, out var _))
								{
									P_7 = false;
									P_6.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZL();
									P_5.Result = P_6;
									global::A.A.I(P_3.ao);
									return false;
								}
							}
							P_4.ReportProgress(0, (object)num6);
						}
						text3 = P_2.BTW[num6];
						if (A(current, P_2, ref flag, P_4, ref num6))
						{
							P_4.ReportProgress(100, (object)num6);
							Thread.Sleep(500);
							if (A(current, P_2))
							{
								continue;
							}
							P_7 = false;
							P_6.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZM();
							P_5.Result = P_6;
							global::A.A.I(P_3.ao);
							return false;
						}
						P_7 = false;
						string text8 = (text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo()) ? text3.Substring(0, text3.Length - 1) : text3);
						P_6.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZl() + text8;
						P_5.Result = P_6;
						global::A.A.I(P_3.ao);
						return false;
					}
					if (flag2)
					{
						P_6.BtE = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZm();
					}
					else
					{
						P_6.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZN();
					}
					P_7 = false;
					P_5.Result = P_6;
					global::A.A.I(P_3.ao);
					return false;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (P_1)
			{
				return P_7;
			}
			return true;
		}

		private static bool A(Cy P_0, CZ.A P_1, ref bool P_2, BackgroundWorker P_3, ref int P_4)
		{
			uint num = (uint)P_0.Bdg.Length;
			uint bDW = P_0.BdG.BDW;
			uint bdh = P_0.Bdh;
			uint bDx = P_0.BdG.BDx;
			F bTm = P_1.BTm;
			global::A.A.a(bTm.ao, bDx);
			uint num2;
			for (num2 = 0u; num2 < num / bdh; num2++)
			{
				byte[] array = new byte[bdh];
				System.Array.Copy((System.Array)P_0.Bdg, (long)(num2 * bdh), (System.Array)array, 0L, (long)bdh);
				bool flag2;
				if (P_2)
				{
					lock (bTm)
					{
						global::A.A.a(bTm.ao, f.au, bDW + num2 * bdh, array, out var _);
						flag2 = false;
						for (int i = 0; i < 13; i++)
						{
							if (global::A.A.A(bTm.ao, out flag2))
							{
								break;
							}
							P_3.ReportProgress(i * 3, (object)P_4);
						}
					}
					P_3.ReportProgress(100, (object)P_4);
					Thread.Sleep(500);
					P_2 = false;
					P_4++;
				}
				else
				{
					flag2 = global::A.A.A(bTm.ao, f.au, bDW + num2 * bdh, array, out var _);
				}
				if (flag2)
				{
					int num3 = (int)((long)(100 * num2) * (long)bdh / num);
					P_3.ReportProgress(num3, (object)P_4);
					continue;
				}
				return false;
			}
			uint num4 = num % bdh;
			if (num4 != 0)
			{
				byte[] array2 = new byte[num4];
				System.Array.Copy((System.Array)P_0.Bdg, (long)(num2 * bdh), (System.Array)array2, 0L, (long)num4);
				if (!global::A.A.A(bTm.ao, f.au, bDW + num2 * bdh, array2, out var _))
				{
					return false;
				}
			}
			return true;
		}

		private static bool A(Cy P_0, CZ.A P_1)
		{
			if (P_0.BdI != 255 || (P_0.BdG != null && (P_0.BdG.BDu == CV.BDL || P_0.BdG.BDu == CV.BDl || P_0.BdG.BDu == CV.BDs)))
			{
				F bTm = P_1.BTm;
				global::A.A.a(bTm.ao, 2000u);
				byte b = 255;
				uint num = 0u;
				int num2 = 0;
				byte[] array = null;
				if (P_0.BdI != 255)
				{
					b = P_0.BdI;
					for (int num3 = P_1.BTV.IndexOf(P_0) - 1; num3 >= 0; num3--)
					{
						if (P_1.BTV[num3].Bdg != null && P_1.BTV[num3].BdG != null)
						{
							num = P_1.BTV[num3].BdG.BDW;
							num2 = P_1.BTV[num3].Bdg.Length;
							array = P_1.BTV[num3].BdG.BDY;
							break;
						}
					}
				}
				else
				{
					b = ((P_0.BdG.BDu == CV.BDl) ? ((byte)1) : ((byte)0));
					num = P_0.BdG.BDW;
					num2 = P_0.Bdg.Length;
					array = P_0.BdG.BDY;
				}
				if (array == null || !global::A.A.A(bTm.ao, b, num, num2, array, out var _))
				{
					return false;
				}
			}
			return true;
		}

		internal static uint A(bt P_0, bool P_1)
		{
			if (P_0 == bt.avx && P_1)
			{
				return 393216u;
			}
			switch (P_0)
			{
			case bt.avk:
			case bt.avL:
			case bt.avl:
			case bt.avM:
			case bt.avm:
			case bt.avN:
			case bt.avU:
			case bt.avu:
			case bt.avV:
			case bt.avv:
			case bt.avW:
			case bt.avw:
			case bt.avX:
			case bt.avx:
				return 0u;
			case bt.avn:
			case bt.avO:
			case bt.avp:
			case bt.avQ:
			case bt.avq:
				return 262144u;
			default:
				return 0u;
			}
		}

		private static bool A(Cy P_0, CZ.A P_1, BackgroundWorker P_2, int P_3)
		{
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			F bTm = P_1.BTm;
			uint num = (uint)P_0.Bdg.Length;
			uint num2 = A(P_0.BdK, P_1.BTQ);
			uint num3 = num2;
			bool flag = false;
			byte[] array = null;
			byte[] array2 = new byte[14]
			{
				0,
				16,
				(byte)(num2 >> 24),
				(byte)(num2 >> 16),
				(byte)(num2 >> 8),
				(byte)num2,
				(byte)(num >> 24),
				(byte)(num >> 16),
				(byte)(num >> 8),
				(byte)num,
				(byte)(num3 >> 24),
				(byte)(num3 >> 16),
				(byte)(num3 >> 8),
				(byte)num3
			};
			if (global::A.A.A(bTm.ao, (byte)P_0.BdK, f.au, 0u, array2, out flag))
			{
				Stopwatch val = new Stopwatch();
				val.Restart();
				while (true)
				{
					if (val.ElapsedMilliseconds >= 10000)
					{
						array = null;
						break;
					}
					if (global::A.A.A(bTm.ao, (byte)P_0.BdK, out array, out flag) && array.Length != 0)
					{
						if (array[0] != 2)
						{
							P_2.ReportProgress(5, (object)P_3);
							break;
						}
						P_2.ReportProgress(Math.Min(5, (int)(val.ElapsedMilliseconds * 5 / 1000)), (object)P_3);
						Thread.Sleep(10);
						continue;
					}
					return false;
				}
			}
			if (array == null || array.Length == 0 || array[0] != 0)
			{
				return false;
			}
			uint bdh = P_0.Bdh;
			uint bDx = P_0.BdG.BDx;
			uint bDW = P_0.BdG.BDW;
			global::A.A.a(bTm.ao, bDx);
			uint num4;
			for (num4 = 0u; num4 < num / bdh; num4++)
			{
				byte[] array3 = new byte[bdh];
				System.Array.Copy((System.Array)P_0.Bdg, (long)(num4 * bdh), (System.Array)array3, 0L, (long)bdh);
				if (global::A.A.A(bTm.ao, (byte)P_0.BdK, f.au, bDW + num4 * bdh, array3, out flag))
				{
					int num5 = 5 + (int)((long)(95 * num4) * (long)bdh / num);
					P_2.ReportProgress(num5, (object)P_3);
					continue;
				}
				return false;
			}
			uint num6 = num % bdh;
			if (num6 != 0)
			{
				byte[] array4 = new byte[num6];
				System.Array.Copy((System.Array)P_0.Bdg, (long)(num4 * bdh), (System.Array)array4, 0L, (long)num6);
				if (!global::A.A.A(bTm.ao, (byte)P_0.BdK, f.au, bDW + num4 * bdh, array4, out flag))
				{
					return false;
				}
			}
			return true;
		}
	}
}
