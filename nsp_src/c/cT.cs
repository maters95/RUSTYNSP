using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace c
{
	internal class cT : aj
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private new delegate void a(object P_0, EventArgs P_1);

		internal const int Bmj = 158;

		internal const int BmK = 220;

		internal const int Bmk = 320;

		internal const int BmL = 100;

		internal const int Bml = 70;

		internal const int BmM = 240;

		private Label Bmm = new Label();

		private ThemedButton BmN = new ThemedButton();

		private ThemedButton Bmn = new ThemedButton();

		private PictureBox BmO;

		private string Bmo = string.Empty;

		private Cn BmP;

		private bool Bmp;

		private bool BmQ;

		private string Bmq = string.Empty;

		internal cT(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3, bool P_4, bool P_5)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			A(P_0, P_1, P_2, P_3, P_4, P_5);
		}

		private void A(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3, bool P_4, bool P_5)
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Expected O, but got Unknown
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Expected O, but got Unknown
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Expected O, but got Unknown
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Expected O, but got Unknown
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Expected O, but got Unknown
			//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Expected O, but got Unknown
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Expected O, but got Unknown
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Expected O, but got Unknown
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Expected O, but got Unknown
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Expected O, but got Unknown
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Expected O, but got Unknown
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Expected O, but got Unknown
			//IL_0456: Unknown result type (might be due to invalid IL or missing references)
			//IL_0460: Expected O, but got Unknown
			//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Expected O, but got Unknown
			A(P_1, P_2);
			A(P_0);
			BmP = P_3;
			if (BmP != null)
			{
				BmQ = P_4;
				Bmp = P_5;
				int[] array = BmP.a(ic);
				if (array != null)
				{
					Encoding encoding = Encoding.GetEncoding(ic.c());
					byte[] array2 = new byte[array.Length];
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i] = (byte)array[i];
					}
					Bmq = encoding.GetString(array2).TrimEnd('\0');
				}
				else
				{
					BmP = null;
				}
			}
			C();
			bool flag = c();
			BM.QQ.B(new EventHandler(b));
			((Control)Bmm).Font = new Font(((Control)Bmm).Font.FontFamily, 8.25f, ((Control)Bmm).Font.Style);
			((Control)this).SuspendLayout();
			bool flag2 = BM.QO == BM.b.BpF && (iF || @if) && ib != null;
			if (flag2)
			{
				((Control)Bmm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bci() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
			}
			else if (flag)
			{
				((Control)Bmm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
			}
			else
			{
				((Control)Bmm).Text = ((SettingOrSpecialObject)ic).A(false);
			}
			((Control)BmN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcJ();
			((Control)BmN).Width = 100;
			((Control)Bmn).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcj();
			((Control)Bmn).Width = 70;
			((Control)Bmm).Left = 0;
			((Control)Bmm).Top = 3;
			((Control)Bmm).Height = 16;
			((Control)Bmm).Width = b();
			((Control)BmN).Left = ((Control)Bmm).Right + 10;
			((Control)BmN).Top = 0;
			((Control)Bmn).Left = ((Control)BmN).Right + 10;
			((Control)Bmn).Top = 0;
			((Control)this).Controls.Add((Control)(object)Bmm);
			if (ic.aA())
			{
				if (BmO == null)
				{
					BmO = new PictureBox();
				}
				((Control)BmO).BackColor = Color.Black;
				BmO.BorderStyle = (BorderStyle)1;
				BmO.SizeMode = (PictureBoxSizeMode)1;
				((Control)BmO).Left = 0;
				((Control)BmO).Top = ((Control)BmN).Height + 20;
				((Control)BmO).Height = 240;
				PictureBox bmO = BmO;
				Size val = ic.aa();
				int num = 240 * ((Size)(ref val)).Width;
				val = ic.aa();
				((Control)bmO).Width = num / ((Size)(ref val)).Height;
				((Control)this).Controls.Add((Control)(object)BmO);
			}
			if (!flag && !flag2)
			{
				ic.A(new EventHandler(c));
				((SettingOrSpecialObject)ic).A(new EventHandler(C));
				((Control)BmN).Click += new EventHandler(D);
				((Control)this).Controls.Add((Control)(object)BmN);
				((Control)Bmn).Click += new EventHandler(d);
				((Control)this).Controls.Add((Control)(object)Bmn);
				((Control)this).MouseEnter += new EventHandler(((aj)this).A);
				((Control)Bmm).MouseEnter += new EventHandler(((aj)this).A);
				((Control)BmN).MouseEnter += new EventHandler(((aj)this).A);
				((Control)Bmn).MouseEnter += new EventHandler(((aj)this).A);
				((Control)iG).MouseEnter += new EventHandler(((aj)this).A);
				((Control)BmN).MouseLeave += new EventHandler(((aj)this).a);
				((Control)Bmn).MouseLeave += new EventHandler(((aj)this).a);
				((Control)this).MouseLeave += new EventHandler(((aj)this).a);
			}
			((Control)this).AutoSize = false;
			((Control)Bmn).Visible = !ic.aA();
			bool flag3 = ib != null && (iF || @if);
			if (flag3)
			{
				if (ic.aA())
				{
					((Control)this).Width = Math.Max(b() + 10 + ((Control)BmN).Width, ((Control)BmO).Width);
				}
				else
				{
					((Control)this).Width = b() + 10 + ((Control)BmN).Width + 10 + ((Control)Bmn).Width;
				}
			}
			else if (ic.aA())
			{
				((Control)this).Width = Math.Max(((Control)BmN).Right, ((Control)BmO).Width);
			}
			else
			{
				((Control)this).Width = ((Control)Bmn).Right;
			}
			if (ic.aA())
			{
				((Control)this).Height = ((Control)BmO).Top + ((Control)BmO).Height;
			}
			else
			{
				((Control)this).Height = ((Control)BmN).Height;
			}
			if (!flag && !flag2)
			{
				((Control)iG).Tag = ic;
				((Control)iG).Width = 18;
				((Control)iG).Height = 18;
				((Control)iG).Left = ((Control)this).Width;
				((Control)iG).Top = 1;
				iG.SizeMode = (PictureBoxSizeMode)1;
				((Control)iG).Click += new EventHandler(B);
				((Control)this).Controls.Add((Control)(object)iG);
				if (!flag3)
				{
					((Control)this).Width = ((Control)iG).Right;
				}
				((Control)iG).Visible = false;
			}
			C();
			D();
			((Control)this).ResumeLayout(true);
		}

		private new int b()
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			if (string.IsNullOrWhiteSpace(((Control)Bmm).Text))
			{
				return 2;
			}
			Size val = TextRenderer.MeasureText(((Control)Bmm).Text, ((Control)Bmm).Font);
			int width = ((Size)(ref val)).Width;
			if (width < 158)
			{
				return 158;
			}
			if (width < 220)
			{
				return 220;
			}
			return 320;
		}

		private new void C()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			if (((SettingOrSpecialObject)ic).l() && iB.C())
			{
				((Control)Bmm).ForeColor = BM.te;
			}
			else
			{
				((Control)Bmm).ForeColor = BM.tq;
			}
			bool flag;
			string text;
			if (BM.QO == BM.b.BpG && iD != null)
			{
				flag = false;
				text = iD.ay();
			}
			else
			{
				flag = ((SettingOrSpecialObject)ic).l() && iB.C();
				text = ic.ay();
			}
			string bmo = (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG()) ? text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length) : ((!text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh())) ? text : text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh().Length)));
			Bmo = bmo;
			c();
			if (flag && !ic.O())
			{
				((Control)BmN).Enabled = true;
				((Control)Bmn).Enabled = !string.IsNullOrWhiteSpace(Bmo);
				switch (ic.P())
				{
				case IllegalitySeverityLevel.Error:
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				case IllegalitySeverityLevel.Warning:
					iG.Image = (Image)(object)GeneralResources.YellowWarning;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (BM.A(iB.aXc, true))
					{
						iG.Image = (Image)(object)GeneralResources.RedError;
					}
					else
					{
						iG.Image = (Image)(object)GeneralResources.YellowWarning;
					}
					break;
				default:
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				}
				((Control)iG).Visible = true;
			}
			else
			{
				((Control)BmN).Enabled = flag;
				((Control)Bmn).Enabled = flag && !string.IsNullOrWhiteSpace(Bmo);
				((Control)iG).Visible = false;
				iG.Image = (Image)(object)GeneralResources.QuestionMark;
			}
			((Control)this).TabStop = ((Control)BmN).Enabled;
			((Control)BmN).TabStop = ((Control)this).TabStop;
			((Control)Bmn).TabStop = ((Control)this).TabStop;
		}

		private new void B(object P_0, EventArgs P_1)
		{
			BM.A(ic, (Control)(object)this);
		}

		private new void b(object P_0, EventArgs P_1)
		{
			if (iF || @if)
			{
				A();
			}
			else
			{
				C();
			}
		}

		private new void C(object P_0, EventArgs P_1)
		{
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
			C();
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
			D();
			if (BM.QO != BM.b.BpG)
			{
				string text = ic.ay();
				string text2 = (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG()) ? text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length) : ((!text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh())) ? text : text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh().Length)));
				if (Bmo != text2)
				{
					Bmo = text2;
					BM.b(ic.A());
					c();
				}
				if (iD != null)
				{
					C();
				}
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Invalid comparison between Unknown and I4
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			if (BM.QP || BM.QO == BM.b.BpG)
			{
				return;
			}
			BW bW = new BW(iB, false, ic.aA(), ic.Z(), ic.z());
			string text = ic.ay();
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG()))
			{
				bW.Wy = true;
				bW.WY = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length);
			}
			else
			{
				bW.Wy = false;
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh()))
				{
					bW.WY = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh().Length);
				}
				else
				{
					bW.WY = text;
				}
			}
			DialogResult val = ((Form)bW).ShowDialog((IWin32Window)(object)BM.QQ);
			string wY = bW.WY;
			bool wy = bW.Wy;
			((Component)bW).Dispose();
			if ((int)val != 2)
			{
				string text2 = ((!wy) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh() + wY) : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG() + wY));
				Ck ck2 = BM.aM();
				ck2?.A(ic.A());
				if (text == text2)
				{
					ic.A(string.Empty, true);
					BackgroundWorker val2 = new BackgroundWorker();
					val2.DoWork += new DoWorkEventHandler(A);
					val2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
					val2.RunWorkerAsync((object)text2);
				}
				else
				{
					ic.A(text2, true);
					ck2?.B();
					BM.b(ic.A());
				}
			}
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			do
			{
				Thread.Sleep(10);
			}
			while (iB.q());
			string result = P_1.Argument as string;
			P_1.Result = result;
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			string text = P_1.Result as string;
			ic.A(text, true);
			BM.aM()?.B();
			BM.b(ic.A());
		}

		private void d(object P_0, EventArgs P_1)
		{
			if (!BM.QP && BM.QO != BM.b.BpG && (!string.IsNullOrWhiteSpace(Bmo) || !string.IsNullOrWhiteSpace(ic.ay())))
			{
				Ck ck2 = BM.aM();
				ck2?.A(ic.A());
				ic.A(string.Empty, true);
				ck2?.B();
				BM.b(ic.A());
			}
		}

		private new void c()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			if (!ic.aA())
			{
				return;
			}
			Image image = BmO.Image;
			Bitmap val = new Bitmap(((Control)BmO).Width, ((Control)BmO).Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.Clear(Color.Black);
				string text = ic.ay();
				bool flag;
				string text2;
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG()))
				{
					flag = true;
					text2 = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length);
				}
				else
				{
					flag = false;
					text2 = ((!text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh())) ? text : text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh().Length));
				}
				try
				{
					string text3 = ((!flag) ? (BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oi() + text2) : (BM.Qu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OI() + text2));
					FileStream val3 = File.OpenRead(text3);
					try
					{
						Image val4 = Image.FromStream((Stream)(object)val3);
						try
						{
							float num = ((Control)BmO).Width;
							Size val5 = ic.aa();
							float num2 = num / (float)((Size)(ref val5)).Width;
							Size val6 = O.A(new Size((int)((float)val4.Width * num2), (int)((float)val4.Height * num2)), ((Control)BmO).Size);
							val2.InterpolationMode = (InterpolationMode)7;
							val2.SmoothingMode = (SmoothingMode)2;
							val2.CompositingQuality = (CompositingQuality)2;
							val2.PixelOffsetMode = (PixelOffsetMode)2;
							val2.DrawImage(val4, ((Control)BmO).Width / 2 - ((Size)(ref val6)).Width / 2, ((Control)BmO).Height / 2 - ((Size)(ref val6)).Height / 2, ((Size)(ref val6)).Width, ((Size)(ref val6)).Height);
						}
						finally
						{
							((System.IDisposable)val4)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val3)?.Dispose();
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcK() + ex.Message, true);
				}
				BmO.Image = (Image)(object)val;
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			if (image != null)
			{
				image.Dispose();
			}
		}

		private void D()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			FontStyle val = (FontStyle)0;
			if (BmP != null && BmQ)
			{
				Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
				if (setting.ay() != Bmq)
				{
					val = (FontStyle)2;
				}
			}
			if (((Control)Bmm).Font.Style != val)
			{
				Font font = ((Control)Bmm).Font;
				((Control)Bmm).Font = new Font(((Control)Bmm).Font.FontFamily, ((Control)Bmm).Font.Size, val);
				font.Dispose();
			}
		}

		public override string ToString()
		{
			return ((SettingOrSpecialObject)ic).A(true);
		}

		protected override void A()
		{
			d();
			int width = ((Control)this).Width;
			int height = ((Control)this).Height;
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.SuspendLayout();
			}
			((Control)this).SuspendLayout();
			((Control)this).Controls.Clear();
			((Control)this).ResumeLayout(true);
			A(iC, iB, ib, BmP, BmQ, Bmp);
			if (!((Control)this).AutoSize)
			{
				((Control)this).Width = width;
				((Control)this).Height = height;
			}
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.ResumeLayout(true);
			}
		}

		protected override ContextMenuStrip a()
		{
			if (ic.aA())
			{
				return null;
			}
			return base.a();
		}

		private void d()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Unknown
			try
			{
				((Control)BmN).Click -= new EventHandler(D);
				((Control)Bmn).Click -= new EventHandler(d);
				((Control)this).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)Bmm).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)BmN).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)Bmn).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)iG).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)BmN).MouseLeave -= new EventHandler(((aj)this).a);
				((Control)Bmn).MouseLeave -= new EventHandler(((aj)this).a);
				((Control)this).MouseLeave -= new EventHandler(((aj)this).a);
				((Control)iG).Click -= new EventHandler(B);
				ic.a(new EventHandler(c));
				((SettingOrSpecialObject)ic).a(new EventHandler(C));
				if (iE != null)
				{
					((SettingOrSpecialObject)iE).a(new EventHandler(((aj)this).B));
				}
				if (ie != null)
				{
					ie.a(new EventHandler(((aj)this).b));
				}
				BM.QQ.b(new EventHandler(b));
			}
			catch
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			d();
			if (BM.SR == iG)
			{
				BM.SR = null;
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
	internal class ct : aj
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private new delegate void a(object P_0, EventArgs P_1);

		private aP BmR = new aP();

		private LinkLabel Bmr = new LinkLabel();

		private Label BmS = new Label();

		private Cn Bms;

		private bool BmT;

		private int Bmt;

		internal ct(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3, bool P_4)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			A(P_0, P_1, P_2, P_3, P_4);
		}

		private void A(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3, bool P_4)
		{
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected O, but got Unknown
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Expected O, but got Unknown
			//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Expected O, but got Unknown
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0356: Expected O, but got Unknown
			//IL_046e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Expected O, but got Unknown
			//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Expected O, but got Unknown
			//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04df: Expected O, but got Unknown
			//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Expected O, but got Unknown
			//IL_0505: Unknown result type (might be due to invalid IL or missing references)
			//IL_050f: Expected O, but got Unknown
			//IL_051d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0527: Expected O, but got Unknown
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Expected O, but got Unknown
			//IL_0548: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Expected O, but got Unknown
			//IL_0605: Unknown result type (might be due to invalid IL or missing references)
			//IL_060a: Unknown result type (might be due to invalid IL or missing references)
			A(P_1, P_2);
			A(P_0);
			Bms = P_3;
			if (Bms != null)
			{
				BmT = P_4;
				int[] array = Bms.a(ic);
				if (array != null && array.Length == 1)
				{
					Bmt = array[0];
				}
				else
				{
					Bms = null;
				}
			}
			C();
			bool flag = c();
			List<Control> val = new List<Control>();
			BM.QQ.B(new EventHandler(C));
			ic.A(new EventHandler(D));
			((SettingOrSpecialObject)ic).A(new EventHandler(c));
			b();
			bool flag2 = BM.QO == BM.b.BpF && (iF || @if) && ib != null;
			Size val2;
			if (flag || flag2)
			{
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
				val2 = TextRenderer.MeasureText(text, ((Control)BmS).Font);
				int width = ((Size)(ref val2)).Width;
				if (flag2)
				{
					((Control)BmS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bci() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
				}
				else
				{
					((Control)BmS).Text = text;
				}
				((Control)BmS).ForeColor = BM.te;
				((Control)BmS).Left = 0;
				((Control)BmS).Top = 2;
				((Control)BmS).AutoSize = true;
				val.Add((Control)(object)BmS);
				if (!((Control)this).Controls.Contains((Control)(object)BmS))
				{
					((Control)this).Controls.Add((Control)(object)BmS);
				}
				((Control)this).AutoSize = false;
				((Control)this).Height = 18;
				((Control)this).Width = width;
			}
			else
			{
				bool num = ic.aE() != 0 || ic.ae() != 0;
				((Control)BmR).Font = new Font(((Control)BmR).Font.FontFamily, 8.25f, ((Control)BmR).Font.Style);
				((Control)BmR).Left = 0;
				((Control)BmR).Top = 1;
				if (num)
				{
					((Control)BmR).Width = 400;
					((Control)BmR).Height = 18;
				}
				else
				{
					((Control)BmR).AutoSize = true;
				}
				if (BM.QO == BM.b.BpG && iD != null)
				{
					BmR.jd = true;
					((CheckBox)BmR).Checked = iD.ax() != 0;
				}
				else
				{
					BmR.jd = false;
					((CheckBox)BmR).Checked = ic.ax() != 0;
				}
				((CheckBox)BmR).CheckedChanged += new EventHandler(d);
				((Control)BmR).GotFocus += new EventHandler(b);
				val.Add((Control)(object)BmR);
				if (!((Control)this).Controls.Contains((Control)(object)BmR))
				{
					((Control)this).Controls.Add((Control)(object)BmR);
				}
				((Control)Bmr).Font = new Font(((Control)BmR).Font.FontFamily, 8.25f, ((Control)BmR).Font.Style);
				((Control)Bmr).Left = 18;
				((Control)Bmr).Top = 2;
				((Control)Bmr).AutoSize = true;
				((Control)Bmr).Tag = ic.A();
				val.Add((Control)(object)Bmr);
				if (!((Control)this).Controls.Contains((Control)(object)Bmr))
				{
					((Control)this).Controls.Add((Control)(object)Bmr);
				}
				if (iB.aWZ.Contains(ic.A()))
				{
					((Control)Bmr).Visible = true;
					((Control)Bmr).BringToFront();
				}
				else
				{
					((Control)Bmr).Visible = false;
				}
				((Control)iG).Tag = ic;
				((Control)iG).Width = 18;
				((Control)iG).Height = 18;
				((Control)iG).Left = ((Control)BmR).Width;
				((Control)iG).Top = 0;
				iG.SizeMode = (PictureBoxSizeMode)1;
				((Control)iG).Click += new EventHandler(B);
				val.Add((Control)(object)iG);
				if (!((Control)this).Controls.Contains((Control)(object)iG))
				{
					((Control)this).Controls.Add((Control)(object)iG);
				}
				((Control)iG).Visible = false;
				((Control)this).MouseEnter += new EventHandler(A);
				((Control)BmR).MouseEnter += new EventHandler(A);
				((Control)Bmr).MouseEnter += new EventHandler(A);
				((Control)iG).MouseEnter += new EventHandler(A);
				((Control)Bmr).MouseLeave += new EventHandler(a);
				((Control)BmR).MouseLeave += new EventHandler(a);
				((Control)this).MouseLeave += new EventHandler(a);
			}
			for (int num2 = ((ArrangedElementCollection)((Control)this).Controls).Count - 1; num2 >= 0; num2--)
			{
				if (!val.Contains(((Control)this).Controls[num2]))
				{
					((Control)this).Controls.RemoveAt(num2);
				}
			}
			c();
			D();
			if (!flag && !flag2)
			{
				((Control)this).AutoSize = false;
				((Control)this).Height = ((Control)iG).Height;
				if (ib != null && (iF || @if))
				{
					val2 = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO(), ((Control)BmR).Font);
					((Control)this).Width = ((Size)(ref val2)).Width;
				}
				else
				{
					((Control)this).Width = ((Control)iG).Right;
				}
			}
		}

		private new void b()
		{
			string text = ((SettingOrSpecialObject)ic).A(false);
			if (ic.aE() != 0 || ic.ae() != 0)
			{
				text = ((ic.ax() != 0) ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcL()) : (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bck()));
			}
			((Control)BmR).Text = text;
			((Control)Bmr).Text = text;
		}

		[SpecialName]
		internal new LinkLabel C()
		{
			return Bmr;
		}

		protected override void A(object P_0, EventArgs P_1)
		{
			base.A(P_0, P_1);
			((Control)BmR).Invalidate();
		}

		protected override void a(object P_0, EventArgs P_1)
		{
			base.a(P_0, P_1);
			((Control)BmR).Invalidate();
		}

		private new void c()
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			Setting setting = ic;
			if (BM.QO == BM.b.BpG)
			{
				((Control)BmR).Enabled = false;
				if (iD != null)
				{
					setting = iD;
				}
			}
			else
			{
				((Control)BmR).Enabled = ((SettingOrSpecialObject)ic).l() && iB.C();
			}
			((Control)BmR).BackColor = BM.tE;
			((Control)Bmr).BackColor = Color.Transparent;
			((Control)iG).BackColor = BM.tE;
			if (((CheckBox)BmR).Checked)
			{
				Bmr.LinkBehavior = (LinkBehavior)1;
			}
			else
			{
				Bmr.LinkBehavior = (LinkBehavior)3;
			}
			if (((SettingOrSpecialObject)setting).l() && !setting.O())
			{
				switch (setting.P())
				{
				case IllegalitySeverityLevel.Error:
					iG.Image = (Image)(object)GeneralResources.RedError;
					((Control)BmR).ForeColor = BM.tC;
					Bmr.LinkColor = BM.tC;
					break;
				case IllegalitySeverityLevel.Warning:
					iG.Image = (Image)(object)GeneralResources.YellowWarning;
					((Control)BmR).ForeColor = Color.Orange;
					Bmr.LinkColor = Color.Orange;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (BM.A(iB.aXc, true))
					{
						iG.Image = (Image)(object)GeneralResources.RedError;
						((Control)BmR).ForeColor = BM.tC;
						Bmr.LinkColor = BM.tC;
					}
					else
					{
						iG.Image = (Image)(object)GeneralResources.YellowWarning;
						((Control)BmR).ForeColor = Color.Orange;
						Bmr.LinkColor = Color.Orange;
					}
					break;
				default:
					iG.Image = (Image)(object)GeneralResources.RedError;
					((Control)BmR).ForeColor = BM.tC;
					Bmr.LinkColor = BM.tC;
					break;
				}
				((Control)iG).Visible = true;
			}
			else
			{
				((Control)iG).Visible = false;
				iG.Image = (Image)(object)GeneralResources.QuestionMark;
				bool flag = iF || @if;
				if (iD != null && !flag && !ic.A(iD))
				{
					((Control)BmR).ForeColor = BM.tD;
					Bmr.LinkColor = BM.tD;
				}
				else if (!((CheckBox)BmR).Checked)
				{
					((Control)BmR).ForeColor = BM.tq;
					Bmr.LinkColor = BM.tq;
				}
				else
				{
					((Control)BmR).ForeColor = BM.te;
					Bmr.LinkColor = BM.tF;
				}
			}
			((Control)this).TabStop = ((Control)BmR).Enabled;
			((Control)BmR).TabStop = ((Control)this).TabStop;
		}

		private new void B(object P_0, EventArgs P_1)
		{
			BM.A(ic, (Control)(object)this);
		}

		private new void b(object P_0, EventArgs P_1)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			BM.QQ.rL.A(ic);
			if (ib != null && ((Control)BmR).ForeColor == BM.tD)
			{
				BM.A(ic, (Control)(object)this);
			}
		}

		private new void C(object P_0, EventArgs P_1)
		{
			if (iF || @if)
			{
				A();
			}
			else if (BM.QO == BM.b.BpG)
			{
				if (iD != null)
				{
					BmR.jd = true;
					if (((CheckBox)BmR).Checked != (iD.ax() != 0))
					{
						((CheckBox)BmR).Checked = iD.ax() != 0;
					}
					c();
				}
			}
			else
			{
				BmR.jd = false;
				if (((CheckBox)BmR).Checked != (ic.ax() != 0))
				{
					((CheckBox)BmR).Checked = ic.ax() != 0;
				}
				c();
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = c;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			c();
		}

		private void D(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = D;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			D();
			if (BM.QO != BM.b.BpG)
			{
				int num = ic.ax();
				if (((CheckBox)BmR).Checked != (num != 0))
				{
					((CheckBox)BmR).Checked = num != 0;
				}
				c();
				b();
			}
		}

		private void D()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			FontStyle val = (FontStyle)0;
			if (Bms != null && BmT)
			{
				Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
				if (setting.ax() != Bmt)
				{
					val = (FontStyle)2;
				}
			}
			if (((Control)BmR).Font.Style != val)
			{
				Font font = ((Control)BmR).Font;
				((Control)BmR).Font = new Font(((Control)BmR).Font.FontFamily, ((Control)BmR).Font.Size, val);
				font.Dispose();
			}
		}

		private void d(object P_0, EventArgs P_1)
		{
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Invalid comparison between Unknown and I4
			if (BM.QO == BM.b.BpG)
			{
				return;
			}
			if (!BM.QP)
			{
				aP aP = P_0 as aP;
				if ((((CheckBox)aP).Checked && ic.ax() == 1) || (!((CheckBox)aP).Checked && ic.ax() == 0))
				{
					return;
				}
				if (((CheckBox)aP).Checked)
				{
					Setting setting = null;
					MenuNode menuNode = null;
					string text = ((SettingOrSpecialObject)ic).P();
					if (text == null)
					{
						if (((SettingOrSpecialObject)ic).D() != null && ((SettingOrSpecialObject)ic).D().o() != null)
						{
							text = ((SettingOrSpecialObject)ic).D().o().t();
							if (text != null)
							{
								menuNode = ((SettingOrSpecialObject)ic).D().o();
							}
							else if (ic.t() != null)
							{
								text = ic.t().t();
								if (text != null)
								{
									menuNode = ic.t();
								}
							}
						}
					}
					else
					{
						setting = ic;
					}
					Ck ck2 = BM.aM();
					if (text != null && !Bg.A(setting, menuNode))
					{
						Bg bg = new Bg(text, setting, menuNode);
						if ((int)((Form)bg).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
						{
							ck2?.A(ic.C());
							ic.a(1, true);
						}
						else
						{
							((CheckBox)aP).Checked = false;
						}
						((Component)bg).Dispose();
					}
					else
					{
						ck2?.A(ic.C());
						ic.a(1, true);
					}
					if (((CheckBox)aP).Checked)
					{
						if (iB.aWZ.Contains(ic.A()) && ((SettingOrSpecialObject)ic).D() != null)
						{
							PortFunction.A(((SettingOrSpecialObject)ic).D(), false);
						}
						ck2?.B();
					}
				}
				else
				{
					Ck ck3 = BM.aM();
					ck3?.A(ic.C());
					ic.a(0, true);
					ck3?.B();
				}
			}
			BM.A(ic.C());
		}

		public override string ToString()
		{
			return ((Control)BmR).Text;
		}

		protected override void A()
		{
			d();
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.SuspendLayout();
			}
			A(iC, iB, ib, Bms, BmT);
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.ResumeLayout(true);
			}
		}

		private void d()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Expected O, but got Unknown
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			try
			{
				((CheckBox)BmR).CheckedChanged -= new EventHandler(d);
				((Control)BmR).GotFocus -= new EventHandler(b);
				((Control)this).MouseEnter -= new EventHandler(A);
				((Control)BmR).MouseEnter -= new EventHandler(A);
				((Control)Bmr).MouseEnter -= new EventHandler(A);
				((Control)iG).MouseEnter -= new EventHandler(A);
				((Control)Bmr).MouseLeave -= new EventHandler(a);
				((Control)BmR).MouseLeave -= new EventHandler(a);
				((Control)this).MouseLeave -= new EventHandler(a);
				((Control)iG).Click -= new EventHandler(B);
				ic.a(new EventHandler(D));
				((SettingOrSpecialObject)ic).a(new EventHandler(c));
				if (iE != null)
				{
					((SettingOrSpecialObject)iE).a(new EventHandler(((aj)this).B));
				}
				if (ie != null)
				{
					ie.a(new EventHandler(((aj)this).b));
				}
				BM.QQ.b(new EventHandler(C));
			}
			catch
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			d();
			if (BM.SR == iG)
			{
				BM.SR = null;
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
	internal class CT
	{
		private static readonly byte[] BDE;

		private static readonly byte[] BDe;

		internal static Stream A(Stream P_0)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Invalid comparison between Unknown and I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axP(), (MessageBoxButtons)3, (MessageBoxIcon)48, (MessageBoxDefaultButton)256) == 6)
			{
				if (A())
				{
					string text = BM.Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axp();
					return A(P_0, text);
				}
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axQ());
			}
			return null;
		}

		internal static bool A()
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			bool result = false;
			try
			{
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				for (int i = 0; i < allNetworkInterfaces.Length; i++)
				{
					string text = ((object)allNetworkInterfaces[i].GetPhysicalAddress()).ToString().ToUpper();
					if (text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axq() || text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axR() || text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axr())
					{
						result = true;
						break;
					}
				}
			}
			catch (System.Exception ex)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axS() + ex.Message);
			}
			return result;
		}

		internal static void A(string P_0, string P_1)
		{
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			try
			{
				string text = P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axs();
				Aes val = Aes.Create();
				try
				{
					byte[] key = ((P_1 != null) ? A(P_1) : BDe);
					((SymmetricAlgorithm)val).Key = key;
					((SymmetricAlgorithm)val).IV = BDE;
					((SymmetricAlgorithm)val).Padding = (PaddingMode)2;
					ICryptoTransform val2 = ((SymmetricAlgorithm)val).CreateEncryptor(((SymmetricAlgorithm)val).Key, ((SymmetricAlgorithm)val).IV);
					FileStream val3 = new FileStream(text, (FileMode)2);
					try
					{
						FileStream val4 = new FileStream(P_0, (FileMode)3);
						try
						{
							CryptoStream val5 = new CryptoStream((Stream)(object)val3, val2, (CryptoStreamMode)1);
							try
							{
								((Stream)val4).CopyTo((Stream)(object)val5);
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
					}
					finally
					{
						((System.IDisposable)val3)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			catch (System.Exception ex)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axT() + ex.Message);
			}
		}

		internal static Stream A(Stream P_0, string P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			MemoryStream val = new MemoryStream();
			try
			{
				if (P_1 == null)
				{
					return null;
				}
				Aes val2 = Aes.Create();
				try
				{
					((SymmetricAlgorithm)val2).Key = A(P_1);
					((SymmetricAlgorithm)val2).IV = BDE;
					((SymmetricAlgorithm)val2).Padding = (PaddingMode)2;
					ICryptoTransform val3 = ((SymmetricAlgorithm)val2).CreateDecryptor(((SymmetricAlgorithm)val2).Key, ((SymmetricAlgorithm)val2).IV);
					CryptoStream val4 = new CryptoStream(P_0, val3, (CryptoStreamMode)0);
					try
					{
						((Stream)val4).CopyTo((Stream)(object)val);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
					((Stream)val).Position = 0L;
					return (Stream)(object)val;
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			catch
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axt());
			}
			return null;
		}

		private static byte[] A(string P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			MemoryStream val = new MemoryStream();
			Aes val2 = Aes.Create();
			try
			{
				((SymmetricAlgorithm)val2).Key = BDe;
				((SymmetricAlgorithm)val2).IV = BDE;
				((SymmetricAlgorithm)val2).Padding = (PaddingMode)2;
				ICryptoTransform val3 = ((SymmetricAlgorithm)val2).CreateDecryptor(((SymmetricAlgorithm)val2).Key, ((SymmetricAlgorithm)val2).IV);
				FileStream val4 = new FileStream(P_0, (FileMode)3);
				try
				{
					CryptoStream val5 = new CryptoStream((Stream)(object)val4, val3, (CryptoStreamMode)0);
					try
					{
						((Stream)val5).CopyTo((Stream)(object)val);
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
				((Stream)val).Position = 0L;
				return val.ToArray();
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}

		static CT()
		{
			byte[] array = new byte[16];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			BDE = array;
			byte[] array2 = new byte[16];
			RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			BDe = array2;
		}
	}
	internal static class Ct
	{
		private class A
		{
			internal int BsY;

			internal List<int> Bsy = new List<int>();

			internal List<int> BsZ = new List<int>();

			internal k Bsz;

			internal string BTA;

			public virtual string ToString()
			{
				string text = (string.IsNullOrEmpty(BTA) ? string.Empty : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEq() + BTA));
				return string.Concat(new string[7]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BER(),
					BsY.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEr(),
					Bsy.Count.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BES(),
					((object)Bsz).ToString(),
					text
				});
			}
		}

		private static readonly string BDF = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axw();

		private static readonly string BDf = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axX();

		private static List<A> BDG = new List<A>();

		private static readonly object BDg = new object();

		internal static void A()
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			lock (BDg)
			{
				BDG.Clear();
				try
				{
					if (File.Exists(BDf))
					{
						byte[] array = File.ReadAllBytes(BDf);
						byte[] array2 = new byte[12];
						System.Array.Copy((System.Array)array, 0, (System.Array)array2, 0, 12);
						int num = array.Length - 12 - 16;
						byte[] array3 = new byte[num];
						byte[] array4 = new byte[16];
						System.Array.Copy((System.Array)array, 12, (System.Array)array3, 0, num);
						System.Array.Copy((System.Array)array, 12 + num, (System.Array)array4, 0, 16);
						byte[] array5 = new byte[num];
						byte[] array6 = new byte[16];
						RuntimeHelpers.InitializeArray((System.Array)array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						AesGcm val = new AesGcm(array6, 16);
						try
						{
							val.Decrypt(array2, array3, array4, array5, (byte[])null);
						}
						finally
						{
							((System.IDisposable)val)?.Dispose();
						}
						MemoryStream val2 = new MemoryStream(array5);
						A((Stream)val2);
						((Stream)val2).Close();
					}
					else if (File.Exists(BDF))
					{
						FileStream val3 = new FileStream(BDF, (FileMode)3);
						A((Stream)val3);
						((Stream)val3).Close();
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axU() + ex.Message, true);
				}
			}
		}

		private static void A(Stream P_0)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Invalid comparison between Unknown and I4
			XmlReader val = XmlReader.Create(P_0);
			val.Read();
			while ((int)val.NodeType != 1)
			{
				val.Read();
			}
			if (!val.IsEmptyElement)
			{
				val.Read();
				while (val.IsStartElement())
				{
					bool flag = true;
					if (val.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axu())
					{
						A(val);
					}
					else
					{
						flag = false;
					}
					if (!flag)
					{
						val.Skip();
					}
					else
					{
						val.Read();
					}
				}
			}
			val.Close();
		}

		private static void A(XmlReader P_0)
		{
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Invalid comparison between Unknown and I4
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Invalid comparison between Unknown and I4
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Invalid comparison between Unknown and I4
			A a = new A();
			a.BsY = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acm()));
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acN());
			if (!string.IsNullOrEmpty(attribute))
			{
				string[] array = attribute.Split(',', (StringSplitOptions)0);
				foreach (string text in array)
				{
					a.Bsy.Add(int.Parse(text));
				}
			}
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axV());
			if (!string.IsNullOrEmpty(attribute2))
			{
				string[] array = attribute2.Split(',', (StringSplitOptions)0);
				foreach (string text2 in array)
				{
					a.BsZ.Add(int.Parse(text2));
				}
			}
			a.Bsz = new k(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axv()), false);
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axu()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axW())
				{
					A(P_0, a);
				}
				P_0.Read();
			}
			BDG.Add(a);
		}

		private static void A(XmlReader P_0, A P_1)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Invalid comparison between Unknown and I4
			P_0.Read();
			if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axW() && (int)P_0.NodeType == 15)
			{
				P_1.BTA = string.Empty;
				return;
			}
			P_1.BTA = P_0.Value;
			P_0.Skip();
		}

		internal static bool A(CX P_0, out string P_1, out bool P_2)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			lock (BDg)
			{
				P_1 = string.Empty;
				P_2 = true;
				Enumerator<A> enumerator = BDG.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						A current = enumerator.Current;
						if (current.BsY == P_0.BdC.axS && current.Bsz == P_0.BdC.axT && (current.Bsy.Count == 0 || current.Bsy.Contains(P_0.BdC.axs)))
						{
							bool flag = false;
							if (current.BsZ.Count == 0 || P_0.Bdc.Count == 0)
							{
								flag = true;
							}
							else
							{
								P_2 = false;
								Enumerator<ushort> enumerator2 = P_0.Bdc.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										int current2 = enumerator2.Current;
										if (current.BsZ.Contains(current2))
										{
											flag = true;
											break;
										}
									}
								}
								finally
								{
									((System.IDisposable)enumerator2).Dispose();
								}
							}
							if (flag)
							{
								if (!string.IsNullOrWhiteSpace(current.BTA))
								{
									P_1 = current.BTA;
								}
								return true;
							}
						}
						P_2 = true;
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				return false;
			}
		}

		internal static void a()
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			if (!Directory.Exists(CZ.Bdl) || BDG.Count == 0)
			{
				return;
			}
			string[] files = Directory.GetFiles(CZ.Bdl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCe());
			for (int num = files.Length - 1; num >= 0; num--)
			{
				string text = files[num];
				CY cY = CU.A(text);
				if (cY != null)
				{
					Enumerator<CX> enumerator = cY.BdF.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							if (A(enumerator.Current, out var _, out var flag) && flag)
							{
								CU.A(text, false);
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
			CU.a();
		}
	}
}
