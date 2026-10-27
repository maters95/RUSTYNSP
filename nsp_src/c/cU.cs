using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.Properties;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace c
{
	internal class cU : aj
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private new delegate void a(object P_0, EventArgs P_1);

		private const int BmU = 20;

		internal const int Bmu = 160;

		internal const int BmV = 220;

		internal const int Bmv = 320;

		private const int BmW = 40;

		private bool Bmw;

		private Label BmX = new Label();

		private Panel Bmx = new Panel();

		private ThemedTextBox BmY = new ThemedTextBox();

		private Label Bmy = new Label();

		private Cn BmZ;

		private int Bmz;

		private bool BNA;

		[SpecialName]
		internal new int b()
		{
			return ((Control)BmX).Width;
		}

		internal cU(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			A(P_0, P_1, P_2, P_3);
		}

		private void A(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3)
		{
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_031d: Expected O, but got Unknown
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Expected O, but got Unknown
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Expected O, but got Unknown
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Expected O, but got Unknown
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0379: Expected O, but got Unknown
			//IL_0386: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Expected O, but got Unknown
			A(P_1, P_2);
			A(P_0);
			BmZ = P_3;
			if (BmZ != null)
			{
				int[] array = BmZ.a(ic);
				if (array != null && array.Length == 1)
				{
					Bmz = array[0];
				}
				else
				{
					BmZ = null;
				}
			}
			C();
			bool flag = c();
			List<Control> val = new List<Control>();
			BM.QQ.B(new EventHandler(B));
			Bmw = false;
			((Control)this).SuspendLayout();
			((Control)BmX).Font = new Font(((Control)BmX).Font.FontFamily, 8.25f, ((Control)BmX).Font.Style);
			((Control)BmY).Font = new Font(((Control)BmY).Font.FontFamily, 8.25f, ((Control)BmY).Font.Style);
			((Control)Bmy).Font = new Font(((Control)Bmy).Font.FontFamily, 8.25f, ((Control)Bmy).Font.Style);
			bool flag2 = BM.QO == BM.b.BpF && (iF || @if) && ib != null;
			if (flag2)
			{
				((Control)BmX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bci() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
			}
			else if (flag)
			{
				((Control)BmX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
			}
			else
			{
				((Control)BmX).Text = ((SettingOrSpecialObject)ic).A(false);
			}
			((Control)Bmx).Width = 20;
			((Control)Bmx).Height = 20;
			Bmx.BorderStyle = (BorderStyle)1;
			((Control)BmX).Left = 0;
			((Control)BmX).Top = 3;
			((Control)BmX).Height = 16;
			((Control)BmX).Width = C();
			((Control)Bmx).Left = ((Control)BmX).Right + 10;
			((Control)Bmx).Top = 0;
			((Control)BmY).Left = ((Control)BmX).Right + 10 + 20 + 10;
			((Control)BmY).Top = 0;
			((Control)BmY).Width = 40;
			((Control)Bmy).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC();
			((Control)Bmy).Left = ((Control)BmX).Right + 10 + 20 + 10 + 40 + 10;
			((Control)Bmy).Top = 3;
			((Control)Bmy).Height = 16;
			((Control)Bmy).Width = 15;
			val.Add((Control)(object)BmX);
			if (!((Control)this).Controls.Contains((Control)(object)BmX))
			{
				((Control)this).Controls.Add((Control)(object)BmX);
			}
			if (!flag && !flag2)
			{
				((Control)BmY).KeyDown += new KeyEventHandler(A);
				((Control)BmY).KeyPress += new KeyPressEventHandler(A);
				((Control)BmY).Leave += new EventHandler(c);
				ic.A(new EventHandler(D));
				((SettingOrSpecialObject)ic).A(new EventHandler(C));
				((Control)Bmx).Click += new EventHandler(b);
				val.Add((Control)(object)Bmx);
				if (!((Control)this).Controls.Contains((Control)(object)Bmx))
				{
					((Control)this).Controls.Add((Control)(object)Bmx);
				}
				val.Add((Control)(object)BmY);
				if (!((Control)this).Controls.Contains((Control)(object)BmY))
				{
					((Control)this).Controls.Add((Control)(object)BmY);
				}
				val.Add((Control)(object)Bmy);
				if (!((Control)this).Controls.Contains((Control)(object)Bmy))
				{
					((Control)this).Controls.Add((Control)(object)Bmy);
				}
			}
			for (int num = ((ArrangedElementCollection)((Control)this).Controls).Count - 1; num >= 0; num--)
			{
				if (!val.Contains(((Control)this).Controls[num]))
				{
					((Control)this).Controls.RemoveAt(num);
				}
			}
			((Control)this).AutoSize = false;
			bool flag3 = ib != null && (iF || @if);
			if (flag3)
			{
				((Control)this).Width = C() + 10 + ((Control)Bmx).Width + 10 + 40 + 10 + 15;
			}
			((Control)this).Height = ((Control)BmY).Height;
			if (!flag3)
			{
				((Control)this).Width = ((Control)Bmy).Right;
			}
			if (!flag && !flag2 && !flag3)
			{
				((Control)this).Width = ((Control)Bmy).Right + 10;
			}
			c();
			((Control)this).ResumeLayout(true);
		}

		private new int C()
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			if (string.IsNullOrWhiteSpace(((Control)BmX).Text))
			{
				return 2;
			}
			Size val = TextRenderer.MeasureText(((Control)BmX).Text, ((Control)BmX).Font);
			int width = ((Size)(ref val)).Width;
			if (width < 160)
			{
				return 160;
			}
			if (width < 220)
			{
				return 220;
			}
			return 320;
		}

		internal void A(int P_0)
		{
			int num = P_0 - ((Control)BmX).Width;
			if (num > 0)
			{
				Label bmX = BmX;
				((Control)bmX).Width = ((Control)bmX).Width + num;
				Panel bmx = Bmx;
				((Control)bmx).Left = ((Control)bmx).Left + num;
				((Control)this).Width = ((Control)this).Width + num;
			}
		}

		private new void c()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			if (((SettingOrSpecialObject)ic).l() && iB.C())
			{
				((Control)BmX).ForeColor = BM.te;
			}
			else
			{
				((Control)BmX).ForeColor = BM.tq;
			}
			((Control)Bmy).ForeColor = ((Control)BmX).ForeColor;
			bool flag;
			if (BM.QO == BM.b.BpG && iD != null)
			{
				flag = false;
				((Control)Bmx).Enabled = false;
				((Control)Bmx).BackColor = A(iD);
				((Control)BmY).Enabled = false;
				((Control)BmY).Text = a(iD);
			}
			else
			{
				flag = ((SettingOrSpecialObject)ic).l() && iB.C();
				((Control)Bmx).Enabled = flag;
				((Control)Bmx).BackColor = A(ic);
				((Control)BmY).Enabled = flag;
				((Control)BmY).Text = a(ic);
			}
			if (flag && !ic.O())
			{
				switch (ic.P())
				{
				case IllegalitySeverityLevel.Error:
					((Control)BmY).BackColor = Color.Red;
					break;
				case IllegalitySeverityLevel.Warning:
					((Control)BmY).BackColor = Color.Orange;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (BM.A(iB.aXc, true))
					{
						((Control)BmY).BackColor = Color.Red;
					}
					else
					{
						((Control)BmY).BackColor = Color.Orange;
					}
					break;
				default:
					((Control)BmY).BackColor = Color.Red;
					break;
				}
			}
			else
			{
				bool flag2 = iF || @if;
				if (iD != null && !flag2 && !ic.A(iD))
				{
					((Control)BmY).BackColor = BM.tD;
				}
				else if (flag)
				{
					((Control)BmY).BackColor = BM.to;
				}
				else
				{
					((Control)BmY).BackColor = BM.tQ;
				}
			}
			if (((Control)BmY).Enabled || ((Control)BmY).BackColor == BM.tD)
			{
				((Control)BmY).ForeColor = BM.te;
			}
			else
			{
				((Control)BmY).ForeColor = BM.tq;
			}
			((Control)this).TabStop = ((Control)Bmx).Enabled;
			Bmx.TabStop = ((Control)this).TabStop;
			((Control)BmY).TabStop = ((Control)this).TabStop;
			((Control)Bmx).Invalidate();
			((Control)BmY).Invalidate();
		}

		private new void B(object P_0, EventArgs P_1)
		{
			if (iF || @if)
			{
				A();
			}
			else
			{
				c();
			}
		}

		private new void b(object P_0, EventArgs P_1)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Invalid comparison between Unknown and I4
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)Bmx).Disposing || BM.QP || BM.QO == BM.b.BpG)
			{
				return;
			}
			Color color = A(ic);
			ColorDialog val = new ColorDialog();
			val.Color = color;
			val.AllowFullOpen = true;
			val.FullOpen = true;
			val.AnyColor = true;
			val.ShowHelp = false;
			val.SolidColorOnly = false;
			val.CustomColors = Settings.Default.ColourPickerCustomColors;
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				Settings.Default.ColourPickerCustomColors = val.CustomColors;
				((SettingsBase)Settings.Default).Save();
				if (!BM.QP)
				{
					Ck ck2 = BM.aM();
					ck2?.A(ic.C());
					iB.M();
					Setting setting = ic;
					Color color2 = val.Color;
					setting.A(1, ((Color)(ref color2)).R, true);
					Setting setting2 = ic;
					color2 = val.Color;
					setting2.A(2, ((Color)(ref color2)).G, true);
					Setting setting3 = ic;
					color2 = val.Color;
					setting3.A(3, ((Color)(ref color2)).B, true);
					iB.A(true, ic);
					Panel bmx = Bmx;
					color2 = val.Color;
					byte r = ((Color)(ref color2)).R;
					color2 = val.Color;
					byte g = ((Color)(ref color2)).G;
					color2 = val.Color;
					((Control)bmx).BackColor = Color.FromArgb(255, (int)r, (int)g, (int)((Color)(ref color2)).B);
					ck2?.B();
				}
				BM.A(ic.C());
			}
			((Component)val).Dispose();
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
			c();
		}

		private Color A(Setting P_0)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			byte b = P_0.l(1);
			byte b2 = P_0.l(2);
			byte b3 = P_0.l(3);
			return Color.FromArgb(255, (int)b, (int)b2, (int)b3);
		}

		private string a(Setting P_0)
		{
			byte b = P_0.l(0);
			return ((int)Math.Round((double)(100f * (float)(int)b / 255f), 0)).ToString();
		}

		internal void D()
		{
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)BmY).Disposing || BM.QP || BM.QO == BM.b.BpG || BM.sX)
			{
				return;
			}
			string text = ((Control)BmY).Text;
			Bmw = false;
			string text2 = a(ic);
			if (text2 == text)
			{
				return;
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				((Control)BmY).Text = text2;
				return;
			}
			try
			{
				byte b = (byte)Math.Min(Math.Max((int)(255f * float.Parse(text) / 100f), 0), 255);
				Ck ck2 = BM.aM();
				ck2?.A(ic.C());
				ic.A(0, b, true);
				ck2?.B();
				BM.A(ic.C());
			}
			catch
			{
				BNA = true;
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				BNA = false;
				((Control)BmY).Text = text2;
			}
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyCode == 13 || (int)P_1.KeyCode == 13)
			{
				D();
			}
			else if (!P_1.Control)
			{
				Bmw = true;
			}
		}

		private void A(object P_0, KeyPressEventArgs P_1)
		{
			if (P_1.KeyChar == '.')
			{
				if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq())
				{
					P_1.Handled = true;
				}
			}
			else if (P_1.KeyChar == ',' && CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ())
			{
				P_1.Handled = true;
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (!BNA)
			{
				D();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
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
			if (BM.QO != BM.b.BpG && !Bmw)
			{
				int selectionStart = ((TextBoxBase)BmY).SelectionStart;
				int selectionLength = ((TextBoxBase)BmY).SelectionLength;
				Color val = A(ic);
				string text = this.a(ic);
				if (((Control)Bmx).BackColor != val || ((Control)BmY).Text != text)
				{
					((Control)Bmx).BackColor = val;
					((Control)BmY).Text = text;
					BM.A(ic.C());
				}
				((TextBoxBase)BmY).SelectionStart = selectionStart;
				((TextBoxBase)BmY).SelectionLength = selectionLength;
				if (iD != null)
				{
					c();
				}
			}
		}

		public override string ToString()
		{
			return ((SettingOrSpecialObject)ic).A(true);
		}

		protected override void A()
		{
			d();
			int width = ((Control)BmX).Width;
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.SuspendLayout();
			}
			A(iC, iB, ib, BmZ);
			A(Math.Max(width, ((Control)BmX).Width));
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
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			try
			{
				((Control)BmY).KeyDown -= new KeyEventHandler(A);
				((Control)BmY).KeyPress -= new KeyPressEventHandler(A);
				((Control)BmY).Leave -= new EventHandler(c);
				ic.a(new EventHandler(D));
				((SettingOrSpecialObject)ic).a(new EventHandler(C));
				((Control)Bmx).Click -= new EventHandler(b);
				if (iE != null)
				{
					((SettingOrSpecialObject)iE).a(new EventHandler(((aj)this).B));
				}
				if (ie != null)
				{
					ie.a(new EventHandler(((aj)this).b));
				}
				BM.QQ.b(new EventHandler(B));
			}
			catch
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			d();
			try
			{
				base.Dispose(disposing);
			}
			catch
			{
			}
		}
	}
	internal class cu : aj
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private new delegate void a(object P_0, EventArgs P_1);

		internal const int BNa = 100;

		internal const int BNB = 160;

		internal const int BNb = 220;

		internal const int BNC = 320;

		internal const int BNc = 60;

		internal const int BND = 130;

		internal const int BNd = 200;

		internal const int BNE = 260;

		private const int BNe = 350;

		private const int BNF = 200;

		private bool BNf;

		private Label BNG = new Label();

		private ThemedComboBox BNg = new ThemedComboBox();

		private ag BNH;

		private int BNh;

		private bool BNI;

		private bool BNi;

		private Cn BNJ;

		private bool BNj;

		private int BNK;

		private int BNk;

		private int BNL;

		private Label BNl;

		private bool BNM;

		[SpecialName]
		internal new int b()
		{
			return ((Control)BNG).Width;
		}

		internal cu(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3, bool P_4, bool P_5, bool P_6, int P_7 = -1, int P_8 = -1, Label P_9 = null)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			BNk = P_7;
			BNL = P_8;
			BNl = P_9;
			A(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		}

		private void A(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3, bool P_4, bool P_5, bool P_6)
		{
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected O, but got Unknown
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Expected O, but got Unknown
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dd: Expected O, but got Unknown
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Expected O, but got Unknown
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_049c: Expected O, but got Unknown
			//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04eb: Expected O, but got Unknown
			//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0503: Expected O, but got Unknown
			//IL_0511: Unknown result type (might be due to invalid IL or missing references)
			//IL_051b: Expected O, but got Unknown
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Expected O, but got Unknown
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_054b: Expected O, but got Unknown
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_055e: Expected O, but got Unknown
			//IL_0831: Unknown result type (might be due to invalid IL or missing references)
			//IL_0836: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0600: Unknown result type (might be due to invalid IL or missing references)
			//IL_0605: Unknown result type (might be due to invalid IL or missing references)
			//IL_060a: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0692: Unknown result type (might be due to invalid IL or missing references)
			//IL_069c: Expected O, but got Unknown
			//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
			A(P_1, P_2);
			A(P_0);
			BNJ = P_3;
			if (BNJ != null)
			{
				BNj = P_4;
				int[] array = BNJ.a(ic);
				if (array != null && array.Length == 1)
				{
					BNK = array[0];
				}
				else
				{
					BNJ = null;
				}
			}
			C();
			bool flag = c();
			List<Control> val = new List<Control>();
			BM.QQ.B(new EventHandler(C));
			BNf = ic.au();
			ic.A(new EventHandler(D));
			((SettingOrSpecialObject)ic).A(new EventHandler(c));
			if (BNL != -1)
			{
				iB.A(BNL)?.A(new EventHandler(c));
			}
			Enumerator<Setting> enumerator = ic.BC().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.A(new EventHandler(c));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			((Control)BNG).Font = new Font(((Control)BNG).Font.FontFamily, 8.25f, ((Control)BNG).Font.Style);
			((Control)BNg).Font = new Font(((Control)BNg).Font.FontFamily, 8.25f, ((Control)BNg).Font.Style);
			((ComboBox)BNg).DropDownStyle = (ComboBoxStyle)2;
			((Control)this).SuspendLayout();
			bool flag2 = BM.QO == BM.b.BpF && (iF || @if) && ib != null;
			if (flag2)
			{
				BNI = true;
				((Control)BNG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bci() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
			}
			else if (flag)
			{
				BNI = true;
				((Control)BNG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
			}
			else if (P_5)
			{
				BNI = true;
				((Control)BNG).Text = ((SettingOrSpecialObject)ic).A(false);
			}
			else
			{
				BNI = false;
			}
			Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
			a(setting);
			BNi = P_6;
			((Control)BNg).Width = c();
			if (BNI)
			{
				((Control)BNG).Left = 0;
				((Control)BNG).Top = 3;
				if (BNi)
				{
					((Control)BNG).AutoSize = true;
					((Control)BNG).MinimumSize = new Size(130, 0);
					((Control)BNG).MaximumSize = new Size(0, 0);
					((Control)BNg).Left = 0;
					((Control)BNg).Top = ((Control)BNG).Top + 14;
				}
				else
				{
					((Control)BNG).Height = 16;
					((Control)BNG).Width = C();
					((Control)BNg).Left = ((Control)BNG).Right + 10;
					((Control)BNg).Top = 0;
				}
				val.Add((Control)(object)BNG);
				if (!((Control)this).Controls.Contains((Control)(object)BNG))
				{
					((Control)this).Controls.Add((Control)(object)BNG);
				}
			}
			else
			{
				((Control)BNg).Left = 0;
				((Control)BNg).Top = 0;
			}
			if (!flag && !flag2)
			{
				((ComboBox)BNg).SelectedIndexChanged += new EventHandler(d);
				((Control)BNg).GotFocus += new EventHandler(b);
				((Control)iG).Tag = ic;
				((Control)iG).Width = 18;
				((Control)iG).Height = 18;
				if (BNI && BNi)
				{
					((Control)iG).Left = Math.Max(((Control)BNg).Right, ((Control)BNG).Right);
				}
				else
				{
					((Control)iG).Left = ((Control)BNg).Right;
				}
				((Control)iG).Top = 1;
				iG.SizeMode = (PictureBoxSizeMode)1;
				((Control)iG).Click += new EventHandler(B);
				val.Add((Control)(object)iG);
				if (!((Control)this).Controls.Contains((Control)(object)iG))
				{
					((Control)this).Controls.Add((Control)(object)iG);
				}
				((Control)iG).Visible = false;
				((Control)this).MouseEnter += new EventHandler(((aj)this).A);
				((Control)BNG).MouseEnter += new EventHandler(((aj)this).A);
				((Control)BNg).MouseEnter += new EventHandler(((aj)this).A);
				((Control)iG).MouseEnter += new EventHandler(((aj)this).A);
				((Control)BNg).MouseLeave += new EventHandler(((aj)this).a);
				((Control)this).MouseLeave += new EventHandler(((aj)this).a);
			}
			D();
			if (!flag && !flag2)
			{
				val.Add((Control)(object)BNg);
				if (!((Control)this).Controls.Contains((Control)(object)BNg))
				{
					((Control)this).Controls.Add((Control)(object)BNg);
				}
			}
			int num = B(setting);
			int num2 = 0;
			if (!flag && !flag2)
			{
				string text = null;
				List<Setting.ValDescs.A> val2 = setting.E((BNk != -1) ? BNk : 0);
				for (int i = 0; i < val2.Count; i++)
				{
					string bBy = val2[i].bBy;
					if (!string.IsNullOrEmpty(bBy))
					{
						SizeF val3 = Size.op_Implicit(TextRenderer.MeasureText(bBy, ((Control)this).Font, new Size(330, -1)));
						num2 = Math.Max(num2, (int)Math.Ceiling((double)((SizeF)(ref val3)).Height) + 25);
						if (val2[i].bBZ == num)
						{
							text = bBy;
						}
					}
				}
				if (num2 != 0)
				{
					if (BNH == null)
					{
						BNH = new ag();
						((Control)BNH).Font = new Font(((Control)BNH).Font.FontFamily, 8.25f, ((Control)BNH).Font.Style);
						((Control)BNH).BackColor = BM.tH;
						((Control)BNH).ForeColor = BM.te;
						((TextBoxBase)BNH).ReadOnly = true;
					}
					else
					{
						((TextBoxBase)BNH).Clear();
					}
					((RichTextBox)BNH).ScrollBars = (RichTextBoxScrollBars)0;
					if (!string.IsNullOrEmpty(text))
					{
						((Control)BNH).Text = text;
					}
					((Control)BNH).Left = ((Control)iG).Right + 5;
					((Control)BNH).Top = 3;
					((Control)BNH).AutoSize = false;
					((Control)BNH).Width = 350;
					((Control)BNH).Height = ((num2 > 200) ? 200 : num2);
					val.Add((Control)(object)BNH);
					if (!((Control)this).Controls.Contains((Control)(object)BNH))
					{
						((Control)this).Controls.Add((Control)(object)BNH);
					}
					((RichTextBox)BNH).ScrollBars = (RichTextBoxScrollBars)2;
					BNH.A();
				}
			}
			for (int num3 = ((ArrangedElementCollection)((Control)this).Controls).Count - 1; num3 >= 0; num3--)
			{
				if (!val.Contains(((Control)this).Controls[num3]))
				{
					((Control)this).Controls.RemoveAt(num3);
				}
			}
			((Control)this).AutoSize = false;
			bool flag3 = ib != null && (iF || @if);
			if (flag3)
			{
				if (BNi)
				{
					Size val4 = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO(), ((Control)BNG).Font);
					((Control)this).Width = ((Size)(ref val4)).Width;
				}
				else
				{
					((Control)this).Width = C() + 10 + c();
				}
			}
			if (flag || flag2)
			{
				if (BNi)
				{
					if (flag3)
					{
						((Control)this).Height = 17 + ((Control)BNg).Height;
					}
					else
					{
						((Control)this).Width = ((Control)BNG).Width;
						((Control)this).Height = ((Control)BNG).Height * 2;
					}
				}
				else if (flag3)
				{
					((Control)this).Height = ((Control)BNg).Height;
				}
				else
				{
					((Control)this).Width = ((Control)BNG).Width;
					((Control)this).Height = ((Control)BNG).Height;
				}
			}
			else if (BNI)
			{
				if (BNi)
				{
					if (flag3)
					{
						((Control)this).Height = 17 + ((Control)BNg).Height;
					}
					else
					{
						((Control)this).Width = Math.Max(((Control)BNG).Width, ((Control)iG).Right);
						((Control)this).Height = ((Control)BNg).Bottom;
					}
				}
				else if (flag3)
				{
					if (num2 != 0)
					{
						((Control)this).Height = ((Control)BNH).Bottom;
						((Control)this).Width = Math.Max(((Control)BNH).Right, ((Control)this).Width);
					}
					else
					{
						((Control)this).Height = ((Control)BNg).Height;
					}
				}
				else if (num2 != 0)
				{
					((Control)this).Height = ((Control)BNH).Bottom;
					((Control)this).Width = ((Control)BNH).Right;
				}
				else
				{
					((Control)this).Width = ((Control)iG).Right;
					((Control)this).Height = ((Control)BNg).Height;
				}
			}
			else
			{
				((Control)this).Width = ((Control)iG).Right;
				((Control)this).Height = ((Control)BNg).Height;
			}
			e();
			((Control)this).ResumeLayout(true);
		}

		private new int C()
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			if (string.IsNullOrWhiteSpace(((Control)BNG).Text))
			{
				return 2;
			}
			Size val = TextRenderer.MeasureText(((Control)BNG).Text, ((Control)BNG).Font);
			int width = ((Size)(ref val)).Width;
			if (width < 100)
			{
				return 100;
			}
			if (width < 160)
			{
				return 160;
			}
			if (width < 220)
			{
				return 220;
			}
			return 320;
		}

		private new int c()
		{
			bool flag = BNh <= 35;
			bool flag2 = BNh <= 105 && !flag;
			bool flag3 = BNh <= 175 && !flag && !flag2;
			if (BNI)
			{
				if (BNi)
				{
					return 130;
				}
				if (flag)
				{
					return 60;
				}
				if (flag2)
				{
					return 130;
				}
				if (flag3)
				{
					return 200;
				}
				return 260;
			}
			if (flag)
			{
				return 60;
			}
			if (flag2)
			{
				return 130;
			}
			if (flag3)
			{
				return 200;
			}
			return 260;
		}

		internal void A(int P_0)
		{
			if (BNi)
			{
				return;
			}
			int num = P_0 - ((Control)BNG).Width;
			if (num > 0)
			{
				Label bNG = BNG;
				((Control)bNG).Width = ((Control)bNG).Width + num;
				ThemedComboBox bNg = BNg;
				((Control)bNg).Left = ((Control)bNg).Left + num;
				PictureBox obj = iG;
				((Control)obj).Left = ((Control)obj).Left + num;
				if (BNH != null)
				{
					ag bNH = BNH;
					((Control)bNH).Left = ((Control)bNH).Left + num;
					BNH.A();
				}
				((Control)this).Width = ((Control)this).Width + num;
			}
		}

		private void D()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			if (((SettingOrSpecialObject)ic).l() && iB.C())
			{
				((Control)BNG).ForeColor = BM.te;
			}
			else
			{
				((Control)BNG).ForeColor = BM.tq;
			}
			bool flag;
			if (BM.QO == BM.b.BpG && iD != null)
			{
				flag = false;
			}
			else if (BNL != -1)
			{
				Setting setting = iB.A(BNL);
				if (setting != null)
				{
					flag = setting.ax() != 0 && ((SettingOrSpecialObject)setting).l();
					if (BNl != null)
					{
						((Control)BNl).ForeColor = (flag ? BM.te : BM.tq);
					}
				}
				else
				{
					flag = true;
				}
				((Control)BNG).ForeColor = (flag ? BM.te : BM.tq);
			}
			else
			{
				flag = ((SettingOrSpecialObject)ic).l() && iB.C();
			}
			if (flag && !ic.O())
			{
				((Control)BNg).Enabled = true;
				switch (ic.P())
				{
				case IllegalitySeverityLevel.Error:
					((Control)BNg).BackColor = Color.Red;
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				case IllegalitySeverityLevel.Warning:
					((Control)BNg).BackColor = Color.Orange;
					iG.Image = (Image)(object)GeneralResources.YellowWarning;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (BM.A(iB.aXc, true))
					{
						((Control)BNg).BackColor = Color.Red;
						iG.Image = (Image)(object)GeneralResources.RedError;
					}
					else
					{
						((Control)BNg).BackColor = Color.Orange;
						iG.Image = (Image)(object)GeneralResources.YellowWarning;
					}
					break;
				default:
					((Control)BNg).BackColor = Color.Red;
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				}
				((Control)iG).Visible = true;
			}
			else
			{
				((Control)BNg).Enabled = flag;
				bool flag2 = iF || @if;
				if (iD != null && !flag2 && !ic.A(iD))
				{
					((Control)BNg).BackColor = BM.tD;
				}
				else if (((Control)BNg).Enabled)
				{
					((Control)BNg).BackColor = BM.to;
				}
				else
				{
					((Control)BNg).BackColor = BM.tQ;
				}
				((Control)iG).Visible = false;
				iG.Image = (Image)(object)GeneralResources.QuestionMark;
			}
			((Control)this).TabStop = ((Control)BNg).Enabled;
			((Control)BNg).TabStop = ((Control)this).TabStop;
			((Control)BNg).Invalidate();
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
			if (ib != null && ((Control)BNg).BackColor == BM.tD)
			{
				BM.A(ic, (Control)(object)this);
			}
		}

		private new void C(object P_0, EventArgs P_1)
		{
			if (iF || @if)
			{
				A();
				return;
			}
			d();
			E();
			D();
		}

		private void d()
		{
			if (((ComboBox)BNg).DroppedDown)
			{
				return;
			}
			Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
			List<Setting.ListItems.A> val = setting.d((BNk != -1) ? BNk : 0);
			int num = B(setting);
			int num2 = -1;
			if (BNf)
			{
				for (int i = 0; i < val.Count; i++)
				{
					for (int j = 0; j < ((ComboBox)BNg).Items.Count; j++)
					{
						if (val[i].bBV == (string)((ComboBox)BNg).Items[j] && val[i].bBv == num)
						{
							num2 = j;
							break;
						}
					}
					if (num2 != -1)
					{
						break;
					}
				}
			}
			else
			{
				for (int k = 0; k < val.Count; k++)
				{
					if (val[k].bBv == num)
					{
						num2 = k;
						break;
					}
				}
			}
			if (((ListControl)BNg).SelectedIndex != num2 && num2 < ((ComboBox)BNg).Items.Count)
			{
				((ListControl)BNg).SelectedIndex = num2;
			}
		}

		private void E()
		{
			if (BNH == null)
			{
				return;
			}
			Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
			int num = B(setting);
			((TextBoxBase)BNH).Clear();
			((RichTextBox)BNH).ScrollBars = (RichTextBoxScrollBars)0;
			List<Setting.ValDescs.A> val = setting.E((BNk != -1) ? BNk : 0);
			for (int i = 0; i < val.Count; i++)
			{
				if (val[i].bBZ == num)
				{
					string bBy = val[i].bBy;
					if (bBy != null && bBy.Length != 0)
					{
						((Control)BNH).Text = bBy;
					}
					break;
				}
			}
			((RichTextBox)BNH).ScrollBars = (RichTextBoxScrollBars)2;
			BNH.A();
		}

		private List<string> A(Setting P_0, int P_1, out int P_2)
		{
			int num = ((BNk != -1) ? BNk : 0);
			List<Setting.ListItems.A> val = P_0.d(num);
			List<string> val2 = new List<string>(val.Count);
			P_2 = -1;
			for (int i = 0; i < val.Count; i++)
			{
				if (BNf)
				{
					string bBV = val[i].bBV;
					string text = bBV.ToLower();
					bool flag = false;
					for (int j = 0; j < val2.Count; j++)
					{
						string text2 = val2[j].ToLower();
						for (int k = 0; k < Math.Min(text.Length, text2.Length); k++)
						{
							if (text[k] != text2[k])
							{
								if (text[k] > text2[k])
								{
									break;
								}
								if (text[k] < text2[k])
								{
									val2.Insert(j, bBV);
									flag = true;
									break;
								}
							}
						}
						if (flag)
						{
							break;
						}
					}
					if (!flag)
					{
						val2.Add(bBV);
					}
				}
				else
				{
					val2.Add(P_0.a(val[i].bBv, num));
					if (val[i].bBv == P_1)
					{
						P_2 = i;
					}
				}
			}
			A(P_0);
			if (id != null)
			{
				A(id);
			}
			return val2;
		}

		private void A(Setting P_0)
		{
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 != id)
			{
				BNh = 0;
			}
			List<Setting.ListItems.A> val = P_0.L();
			for (int i = 0; i < val.Count; i++)
			{
				Size val2;
				if (val[i].bBW != 0)
				{
					Setting setting = iB.A(val[i].bBW);
					if (setting != null)
					{
						string text = string.Empty;
						int num = setting.Ba();
						for (int j = 0; j < num; j++)
						{
							text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
						}
						int bNh = BNh;
						val2 = TextRenderer.MeasureText(text, ((Control)BNg).Font);
						BNh = Math.Max(bNh, ((Size)(ref val2)).Width);
					}
				}
				int bNh2 = BNh;
				val2 = TextRenderer.MeasureText(val[i].bBV, ((Control)BNg).Font);
				BNh = Math.Max(bNh2, ((Size)(ref val2)).Width);
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
			int num = B(ic);
			int num2;
			List<string> val = A(ic, num, out num2);
			bool flag = false;
			if (val.Count != ((ComboBox)BNg).Items.Count)
			{
				flag = true;
			}
			else
			{
				for (int i = 0; i < ((ComboBox)BNg).Items.Count; i++)
				{
					if (val[i] != (string)((ComboBox)BNg).Items[i])
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
				if (setting.l().Count != 0)
				{
					A();
					return;
				}
				this.a(setting);
				D();
				e();
			}
			else
			{
				D();
			}
		}

		private void a(Setting P_0)
		{
			int num = B(P_0);
			((ComboBox)BNg).Items.Clear();
			int num2;
			List<string> val = A(P_0, num, out num2);
			ObjectCollection items = ((ComboBox)BNg).Items;
			object[] array = val.ToArray();
			items.AddRange(array);
			if (BNf)
			{
				List<Setting.ListItems.A> val2 = P_0.d((BNk != -1) ? BNk : 0);
				for (int i = 0; i < val2.Count; i++)
				{
					for (int j = 0; j < ((ComboBox)BNg).Items.Count; j++)
					{
						if (val2[i].bBV == (string)((ComboBox)BNg).Items[j] && val2[i].bBv == num)
						{
							num2 = j;
							break;
						}
					}
					if (num2 != -1)
					{
						break;
					}
				}
			}
			((ListControl)BNg).SelectedIndex = ((num2 < ((ComboBox)BNg).Items.Count) ? num2 : (-1));
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
			e();
			if (BM.QO != BM.b.BpG)
			{
				d();
				E();
				if (iD != null)
				{
					D();
				}
			}
		}

		private void e()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			FontStyle val = (FontStyle)0;
			if (BNJ != null && BNj)
			{
				Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
				if (B(setting) != BNK)
				{
					val = (FontStyle)2;
				}
			}
			if (((Control)BNg).Font.Style != val)
			{
				Font font = ((Control)BNg).Font;
				((Control)BNg).Font = new Font(((Control)BNg).Font.FontFamily, ((Control)BNg).Font.Size, val);
				font.Dispose();
			}
			if (((Control)BNG).Font.Style != val)
			{
				Font font2 = ((Control)BNG).Font;
				((Control)BNG).Font = new Font(((Control)BNG).Font.FontFamily, ((Control)BNG).Font.Size, val);
				font2.Dispose();
			}
		}

		private void d(object P_0, EventArgs P_1)
		{
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Invalid comparison between Unknown and I4
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0356: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			if (BM.QO == BM.b.BpG)
			{
				return;
			}
			if (BM.QP)
			{
				BM.A(ic.C());
				E();
			}
			else if (BNM)
			{
				BNM = false;
			}
			else
			{
				if (((ListControl)BNg).SelectedIndex == -1)
				{
					return;
				}
				List<Setting.ListItems.A> val = ic.d((BNk != -1) ? BNk : 0);
				int num = -1;
				if (BNf)
				{
					for (int i = 0; i < val.Count; i++)
					{
						if (val[i].bBV == (string)((ComboBox)BNg).Items[((ListControl)BNg).SelectedIndex])
						{
							num = i;
							break;
						}
					}
				}
				else
				{
					num = ((ListControl)BNg).SelectedIndex;
				}
				int num2 = B(ic);
				int bBv = val[num].bBv;
				if (bBv == num2)
				{
					return;
				}
				bool flag = !((SettingOrSpecialObject)ic).j();
				if (!flag)
				{
					string text = ((SettingOrSpecialObject)ic).P();
					if (text != null && bBv != 0 && !Bg.A(ic, null))
					{
						Bg bg = new Bg(text, ic, null);
						if ((int)((Form)bg).ShowDialog((IWin32Window)(object)BM.QQ) != 1)
						{
							flag = true;
						}
						((Component)bg).Dispose();
					}
				}
				List<Table> val2 = null;
				if (!flag)
				{
					List<Table> val3 = new List<Table>();
					if (ic.A() == 9364)
					{
						if (iB.A(9365) is Table table)
						{
							val3.Add(table);
						}
					}
					else if (ic.A() == 9465)
					{
						if (iB.A(9466) is Table table2)
						{
							val3.Add(table2);
						}
						if (iB.A(9476) is Table table3)
						{
							val3.Add(table3);
						}
					}
					if (val3.Count != 0 && A(val3, ref flag, num2, bBv))
					{
						val2 = val3;
					}
				}
				List<Table> val4 = null;
				if (!flag && ic.A() == 2083)
				{
					val4 = A(ref flag, num2, bBv);
				}
				if (flag)
				{
					if (BNf)
					{
						for (int j = 0; j < val.Count; j++)
						{
							for (int k = 0; k < ((ComboBox)BNg).Items.Count; k++)
							{
								if (val[j].bBV == (string)((ComboBox)BNg).Items[k] && val[j].bBv == num2)
								{
									BNM = true;
									((ListControl)BNg).SelectedIndex = k;
									break;
								}
							}
							if (BNM)
							{
								break;
							}
						}
						return;
					}
					for (int l = 0; l < val.Count; l++)
					{
						if (val[l].bBv == num2)
						{
							BNM = true;
							((ListControl)BNg).SelectedIndex = ((l < ((ComboBox)BNg).Items.Count) ? l : (-1));
							break;
						}
					}
					return;
				}
				Ck ck2 = BM.aM();
				ck2?.A(ic.C());
				A(ic, bBv);
				if (val2 != null)
				{
					Enumerator<Table> enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.A(num2, bBv);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				else if (val4 != null)
				{
					Enumerator<Table> enumerator = val4.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.B();
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				ck2?.B();
				BM.A(ic.C());
				E();
			}
		}

		private bool A(List<Table> P_0, ref bool P_1, int P_2, int P_3)
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Invalid comparison between Unknown and I4
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Invalid comparison between Unknown and I4
			Setting setting = iB.A(714);
			Setting setting2 = iB.A(720);
			Setting setting3 = iB.A(464);
			Setting setting4 = iB.A(6481);
			if (setting != null && setting2 != null && setting3 != null && setting4 != null)
			{
				string text = string.Empty;
				Enumerator<Table> enumerator = P_0.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string text2 = ((SettingOrSpecialObject)enumerator.Current).A(bz.aYt);
						if (!text2.ToLower().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcl()))
						{
							text2 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcM();
						}
						text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcm() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu();
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				string text3 = null;
				if (setting.ax() == 1)
				{
					if (setting2.ax() == 1)
					{
						if (setting3.ax() > 0 && setting3.O())
						{
							if (setting4.ax() > 0 && setting4.O())
							{
								if ((P_2 == 6469 && P_3 == 6750) || (P_2 == 6469 && P_3 == 463) || (P_2 == 463 && P_3 == 6469) || (P_2 == 6750 && P_3 == 6469))
								{
									if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Concat(new string[7]
									{
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcN(),
										ic.a(P_2, 0),
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcn(),
										ic.a(P_3, 0),
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcO(),
										text,
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bco()
									}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)256) == 1)
									{
										return true;
									}
									P_1 = true;
								}
								else if ((P_2 != 6750 || P_3 != 463) && (P_2 != 463 || P_3 != 6750))
								{
									text3 = string.Concat(new string[6]
									{
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcP(),
										ic.a(P_2, 0),
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcn(),
										ic.a(P_3, 0),
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcO(),
										text
									});
								}
							}
							else
							{
								text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcp() + text;
							}
						}
						else
						{
							text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcQ() + text;
						}
					}
					else
					{
						text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcq() + text;
					}
				}
				else
				{
					text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcR() + text;
				}
				if (!string.IsNullOrWhiteSpace(text3) && (int)bE.A((IWin32Window)(object)BM.QQ, text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NY(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV()
				}) == 2)
				{
					P_1 = true;
				}
			}
			return false;
		}

		private List<Table> A(ref bool P_0, int P_1, int P_2)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Invalid comparison between Unknown and I4
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Invalid comparison between Unknown and I4
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			List<Table> val = null;
			List<Table> val2 = new List<Table>();
			Enumerator<Table> enumerator = iB.aWV.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Table current = enumerator.Current;
					if (current.GetAxisUsingChannel(407) != null && ((SettingOrSpecialObject)current).l())
					{
						val2.Add(current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (val2.Count != 0)
			{
				string text = string.Empty;
				enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Table current2 = enumerator.Current;
						text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uL() + ((SettingOrSpecialObject)current2).A(bz.aYt);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				Setting setting = iB.A(15995);
				Setting setting2 = iB.A(17);
				Table table = iB.A(128) as Table;
				bool flag = false;
				if (P_1 == 4 && P_2 == 0 && setting != null && setting2 != null && table != null && setting2.ax() == 0)
				{
					List<int> dataIdsOfChannelsPerEnabledAxis = table.GetDataIdsOfChannelsPerEnabledAxis();
					if (dataIdsOfChannelsPerEnabledAxis.Contains(15985) || dataIdsOfChannelsPerEnabledAxis.Contains(224))
					{
						flag = true;
					}
					else if (dataIdsOfChannelsPerEnabledAxis.Contains(385))
					{
						Setting setting3 = iB.A(2082);
						flag = setting3 != null && setting3.ax() == 0;
					}
				}
				if (flag)
				{
					if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcr() + text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 1)
					{
						val = new List<Table>();
						enumerator = val2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Table current3 = enumerator.Current;
								val.Add(current3);
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
					else
					{
						P_0 = true;
					}
				}
				else if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcS() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcs(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 2)
				{
					P_0 = true;
				}
			}
			return val;
		}

		public override string ToString()
		{
			return ((SettingOrSpecialObject)ic).A(true);
		}

		protected override void A()
		{
			F();
			int width = ((Control)BNG).Width;
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.SuspendLayout();
			}
			A(iC, iB, ib, BNJ, BNj, BNI, BNi);
			A(Math.Max(width, ((Control)BNG).Width));
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.ResumeLayout(true);
			}
		}

		private int B(Setting P_0)
		{
			if (BNk != -1)
			{
				return P_0.m(BNk);
			}
			return P_0.ax();
		}

		private void A(Setting P_0, int P_1)
		{
			if (BNk != -1)
			{
				P_0.a(BNk, P_1, true);
			}
			else
			{
				P_0.a(P_1, true);
			}
		}

		private void F()
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
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected O, but got Unknown
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected O, but got Unknown
			try
			{
				((ComboBox)BNg).SelectedIndexChanged -= new EventHandler(d);
				((Control)BNg).GotFocus -= new EventHandler(b);
				((Control)this).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)BNG).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)BNg).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)iG).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)BNg).MouseLeave -= new EventHandler(((aj)this).a);
				((Control)this).MouseLeave -= new EventHandler(((aj)this).a);
				((Control)iG).Click -= new EventHandler(B);
				ic.a(new EventHandler(D));
				Enumerator<Setting> enumerator = ic.BC().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.a(new EventHandler(c));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
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
			F();
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
	internal static class CU
	{
		private static readonly string BDH = CZ.Bdl + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYc();

		private static List<CY> BDh = new List<CY>();

		internal static CY A(string P_0)
		{
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < BDh.Count; i++)
			{
				CY cY = BDh[i];
				try
				{
					if (!(cY.BdE == P_0))
					{
						continue;
					}
					if (File.Exists(P_0))
					{
						string bde = cY.Bde;
						System.DateTime creationTime = File.GetCreationTime(P_0);
						System.DateTime lastWriteTime = File.GetLastWriteTime(P_0);
						string text = N.A((lastWriteTime > creationTime) ? lastWriteTime : creationTime, true, false);
						if (bde != text)
						{
							BDh.RemoveAt(i);
							return null;
						}
						bool flag = false;
						Enumerator<CX> enumerator = cY.BdF.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								CX current = enumerator.Current;
								if (current.BdC != null && current.BdC.axt != null)
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
						if (flag)
						{
							return cY;
						}
						BDh.RemoveAt(i);
						return null;
					}
					BDh.RemoveAt(i);
					return null;
				}
				catch
				{
				}
			}
			return null;
		}

		internal static void A(CY P_0, bool P_1)
		{
			BDh.Add(P_0);
			if (P_1)
			{
				a();
			}
		}

		internal static void A(string P_0, bool P_1)
		{
			for (int num = BDh.Count - 1; num >= 0; num--)
			{
				if (BDh[num].BdE == P_0)
				{
					BDh.RemoveAt(num);
					break;
				}
			}
			try
			{
				File.Delete(P_0);
			}
			catch
			{
			}
			if (P_1)
			{
				a();
			}
		}

		internal static void A()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Invalid comparison between Unknown and I4
			BDh.Clear();
			if (!File.Exists(BDH))
			{
				return;
			}
			try
			{
				FileStream val = new FileStream(BDH, (FileMode)3);
				XmlReader val2 = XmlReader.Create((Stream)(object)val);
				val2.Read();
				while ((int)val2.NodeType != 1)
				{
					val2.Read();
				}
				if (!val2.IsEmptyElement)
				{
					val2.Read();
					while (val2.IsStartElement())
					{
						bool flag = true;
						if (val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axx())
						{
							A(val2);
						}
						else
						{
							flag = false;
						}
						if (!flag)
						{
							val2.Skip();
						}
						else
						{
							val2.Read();
						}
					}
				}
				val2.Close();
				((Stream)val).Close();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axY() + ex.Message, true);
			}
		}

		private static void A(XmlReader P_0)
		{
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Invalid comparison between Unknown and I4
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Invalid comparison between Unknown and I4
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Invalid comparison between Unknown and I4
			CY cY = new CY();
			cY.BdE = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axy());
			cY.Bde = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axZ());
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axx()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axz())
				{
					A(P_0, cY);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYA())
				{
					a(P_0, cY);
				}
				P_0.Read();
			}
			BDh.Add(cY);
		}

		private static void A(XmlReader P_0, CY P_1)
		{
			CX cX = new CX();
			cX.BdC = new bW
			{
				axS = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acm())),
				axs = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acN())),
				axT = new k(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axv()), false)
			};
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYa());
			if (!string.IsNullOrEmpty(attribute))
			{
				cX.BdC.axt = n.A(attribute);
			}
			cX.Bdc = new List<ushort>();
			string[] array = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axV()).Split(',', (StringSplitOptions)0);
			foreach (string text in array)
			{
				cX.Bdc.Add(ushort.Parse(text));
			}
			P_1.BdF.Add(cX);
		}

		private static void a(XmlReader P_0, CY P_1)
		{
			Cx cx = new Cx();
			cx.BdD = (bt)byte.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYB()));
			cx.Bdd = new k(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axv()), false);
			P_1.Bdf.Add(cx);
		}

		internal static void a()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (File.Exists(BDH))
				{
					File.Delete(BDH);
				}
				if (BDh.Count == 0)
				{
					return;
				}
				MemoryStream val = new MemoryStream();
				XmlWriterSettings val2 = new XmlWriterSettings();
				val2.ConformanceLevel = (ConformanceLevel)2;
				val2.CloseOutput = false;
				val2.Indent = true;
				val2.NewLineChars = Environment.NewLine;
				XmlWriter val3 = XmlWriter.Create((Stream)(object)val, val2);
				val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYb());
				Enumerator<CY> enumerator = BDh.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CY current = enumerator.Current;
						A(val3, current);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				val3.WriteEndElement();
				val3.Close();
				((Stream)val).Flush();
				StreamWriter val4 = new StreamWriter(BDH);
				try
				{
					((Stream)val).Position = 0L;
					string text = ((TextReader)new StreamReader((Stream)(object)val)).ReadToEnd();
					((TextWriter)val4).Write(text);
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
				File.SetAttributes(BDH, (FileAttributes)2);
				((Stream)val).Close();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYC() + ex.Message, true);
			}
		}

		private static void A(XmlWriter P_0, CY P_1)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axx());
			P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axy(), P_1.BdE);
			P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axZ(), P_1.Bde);
			Enumerator<CX> enumerator = P_1.BdF.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CX current = enumerator.Current;
					P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axz());
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acm(), current.BdC.axS.ToString());
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acN(), current.BdC.axs.ToString());
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axv(), ((object)current.BdC.axT).ToString());
					if (current.BdC.axt != null)
					{
						P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYa(), n.A(current.BdC.axt));
					}
					string text = string.Empty;
					Enumerator<ushort> enumerator2 = current.Bdc.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							ushort current2 = enumerator2.Current;
							text = ((!string.IsNullOrEmpty(text)) ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + current2) : (text + current2));
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axV(), text);
					P_0.WriteEndElement();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<Cx> enumerator3 = P_1.Bdf.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					Cx current3 = enumerator3.Current;
					P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYA());
					string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYB();
					byte bdD = (byte)current3.BdD;
					P_0.WriteAttributeString(text2, bdD.ToString());
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axv(), ((object)current3.Bdd).ToString());
					P_0.WriteEndElement();
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			P_0.WriteEndElement();
		}
	}
	internal class Cu
	{
		internal class A
		{
			internal string BTa;

			internal string BTB;

			internal string BTb;

			internal byte BTC = 255;

			internal string BTc;

			internal bool BTD;

			internal bool BTd = true;

			internal string BTE;

			public virtual string ToString()
			{
				return BTa;
			}
		}

		internal class a
		{
			internal string BTe;

			internal int BTF;

			internal int BTf;

			internal List<ushort> BTG = new List<ushort>();

			internal string BTg;

			internal string BTH;

			internal List<A> BTh = new List<A>();

			public virtual string ToString()
			{
				return ((!string.IsNullOrEmpty(BTe)) ? BTe : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEs() + BTF + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.al() + BTf)) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + BTh.Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BET();
			}
		}

		internal class B
		{
			internal string BTI;

			internal List<bt> BTi = new List<bt>();

			internal string BTJ;

			internal List<A> BTj = new List<A>();

			public virtual string ToString()
			{
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Unknown result type (might be due to invalid IL or missing references)
				string text = ((!string.IsNullOrEmpty(BTI)) ? (BTI + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY()) : string.Empty);
				Enumerator<bt> enumerator = BTi.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						bt current = enumerator.Current;
						text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEt() + ((object)current).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY();
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				return text + BTj.Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BET();
			}
		}

		internal class b
		{
			internal string BTK;

			internal List<bt> BTk = new List<bt>();

			internal List<int> BTL = new List<int>();

			internal List<A> BTl = new List<A>();

			public virtual string ToString()
			{
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				string text = ((!string.IsNullOrEmpty(BTK)) ? (BTK + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY()) : string.Empty);
				Enumerator<bt> enumerator = BTk.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						bt current = enumerator.Current;
						text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEt() + ((object)current).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY();
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				Enumerator<int> enumerator2 = BTL.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						int current2 = enumerator2.Current;
						text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEU() + current2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY();
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				return text + BTl.Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BET();
			}
		}

		internal byte BDI;

		internal k BDi;

		internal List<a> BDJ = new List<a>();

		internal List<B> BDj = new List<B>();

		internal List<b> BDK = new List<b>();

		public virtual string ToString()
		{
			return string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYD(),
				((object)BDi)?.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY(),
				BDJ.Count.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYd(),
				BDj.Count.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYE(),
				BDK.Count.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYe()
			});
		}

		internal Cu(Stream P_0)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Invalid comparison between Unknown and I4
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
					string name = val.Name;
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYF()))
					{
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYf()))
						{
							if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axz()))
							{
								if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYA()))
								{
									if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYG())
									{
										B(val);
									}
									else
									{
										flag = false;
									}
								}
								else
								{
									a(val);
								}
							}
							else
							{
								A(val);
							}
						}
						else
						{
							val.Read();
							BDi = new k(val.Value, false);
							val.Skip();
						}
					}
					else
					{
						val.Read();
						BDI = byte.Parse(val.Value);
						val.Skip();
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
			P_0.Close();
		}

		private void A(XmlReader P_0)
		{
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Invalid comparison between Unknown and I4
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Invalid comparison between Unknown and I4
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Invalid comparison between Unknown and I4
			a a = new a();
			a.BTe = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			a.BTF = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acm()));
			a.BTf = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acN()));
			string[] array = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axV()).Split(',', (StringSplitOptions)0);
			foreach (string text in array)
			{
				a.BTG.Add(ushort.Parse(text));
			}
			a.BTg = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYg());
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYH());
			if (!string.IsNullOrEmpty(attribute))
			{
				a.BTH = attribute;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axz()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYh())
				{
					A(P_0, a.BTh, false);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYI())
				{
					A a2 = A(P_0, false);
					a.BTh.Add(a2);
				}
				P_0.Read();
			}
			BDJ.Add(a);
		}

		private void a(XmlReader P_0)
		{
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Invalid comparison between Unknown and I4
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Invalid comparison between Unknown and I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Invalid comparison between Unknown and I4
			B b = new B();
			b.BTI = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			string[] array = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYi()).Split(',', (StringSplitOptions)0);
			foreach (string text in array)
			{
				b.BTi.Add((bt)byte.Parse(text));
			}
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYH());
			if (!string.IsNullOrEmpty(attribute))
			{
				b.BTJ = attribute;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYA()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYh())
				{
					A(P_0, b.BTj, true);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYI())
				{
					A a = A(P_0, true);
					b.BTj.Add(a);
				}
				P_0.Read();
			}
			BDj.Add(b);
		}

		private void B(XmlReader P_0)
		{
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Invalid comparison between Unknown and I4
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Invalid comparison between Unknown and I4
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Invalid comparison between Unknown and I4
			b b = new b();
			b.BTK = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			string[] array = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYi()).Split(',', (StringSplitOptions)0);
			foreach (string text in array)
			{
				b.BTk.Add((bt)byte.Parse(text));
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYG()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYh())
				{
					A(P_0, b.BTl, true);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYI())
				{
					A a = A(P_0, true);
					b.BTl.Add(a);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYJ())
				{
					A(P_0, b);
				}
				P_0.Read();
			}
			BDK.Add(b);
		}

		private void A(XmlReader P_0, List<A> P_1, bool P_2)
		{
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Invalid comparison between Unknown and I4
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Invalid comparison between Unknown and I4
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Invalid comparison between Unknown and I4
			A a = new A();
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYj());
			if (string.IsNullOrEmpty(attribute))
			{
				a.BTd = !P_2;
			}
			else
			{
				a.BTd = bool.Parse(attribute);
			}
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYK());
			if (!string.IsNullOrEmpty(attribute2))
			{
				a.BTE = attribute2;
			}
			a.BTD = true;
			a.BTB = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			a.BTa = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYk());
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIB());
			if (!string.IsNullOrEmpty(attribute3))
			{
				a.BTb = attribute3;
			}
			P_1.Add(a);
			int num = P_1.Count - 1;
			if (P_0.IsEmptyElement)
			{
				return;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYh()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYL())
				{
					A a2 = A(P_0, P_2);
					if (a2.BTb == null)
					{
						a2.BTb = a.BTb;
					}
					P_1.Insert(num, a2);
					num++;
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYl())
				{
					A a3 = A(P_0, P_2);
					if (a3.BTb == null)
					{
						a3.BTb = a.BTb;
					}
					P_1.Add(a3);
				}
				P_0.Read();
			}
		}

		private A A(XmlReader P_0, bool P_1)
		{
			A a = new A();
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYj());
			if (string.IsNullOrEmpty(attribute))
			{
				a.BTd = !P_1;
			}
			else
			{
				a.BTd = bool.Parse(attribute);
			}
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYK());
			if (!string.IsNullOrEmpty(attribute2))
			{
				a.BTE = attribute2;
			}
			a.BTa = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYk());
			a.BTD = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYM()));
			a.BTc = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIB());
			if (!string.IsNullOrEmpty(attribute3))
			{
				a.BTb = attribute3;
			}
			string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYm());
			if (!string.IsNullOrEmpty(attribute4))
			{
				a.BTC = byte.Parse(attribute4);
			}
			return a;
		}

		private void A(XmlReader P_0, b P_1)
		{
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Invalid comparison between Unknown and I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Invalid comparison between Unknown and I4
			P_0.Read();
			int num = default(int);
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYJ()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYN() && int.TryParse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LH()), ref num))
				{
					P_1.BTL.Add(num);
				}
				P_0.Read();
			}
		}
	}
}
