using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace B
{
	internal class BG : Form
	{
		private double Oz;

		private string oA;

		private int oa;

		private int oB;

		private int ob;

		private int oC;

		private int oc;

		private int oD;

		private List<Setting.ListItems.A> od;

		private IContainer oE;

		private ThemedButton oe;

		private ThemedButton oF;

		private GroupBox of;

		private ThemedTextBox oG;

		private Label og;

		private Label oH;

		private Label oh;

		private Label oI;

		private ThemedComboBox oi;

		private Label oJ;

		internal BG(string P_0, Keys P_1, string P_2, int P_3, int P_4, int P_5, int P_6, int P_7, int P_8, List<Setting.ListItems.A> P_9)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Invalid comparison between Unknown and I4
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Invalid comparison between Unknown and I4
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Invalid comparison between Unknown and I4
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Invalid comparison between Unknown and I4
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Invalid comparison between Unknown and I4
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected I4, but got Unknown
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Expected I4, but got Unknown
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Invalid comparison between Unknown and I4
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected I4, but got Unknown
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Expected I4, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			b();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)of).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			((Control)oG).BackColor = BM.to;
			((Control)oG).ForeColor = BM.te;
			((Control)this).Text = P_0;
			od = P_9;
			if (od != null && od.Count != 0)
			{
				int num = 0;
				string[] array = new string[od.Count];
				Graphics val2 = ((Control)this).CreateGraphics();
				try
				{
					for (int i = 0; i < od.Count; i++)
					{
						array[i] = od[i].bBV;
						Size val3 = TextRenderer.MeasureText((IDeviceContext)(object)val2, array[i], ((Control)oi).Font);
						num = Math.Max(((Size)(ref val3)).Width, num);
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
				ObjectCollection items = ((ComboBox)oi).Items;
				object[] array2 = array;
				items.AddRange(array2);
				if (num > ((ComboBox)oi).DropDownWidth - 130)
				{
					((ComboBox)oi).DropDownWidth = num + 130;
				}
				if (((ComboBox)oi).Items.Count > 20)
				{
					((ComboBox)oi).DropDownHeight = 360;
				}
			}
			if ((int)P_1 == 0)
			{
				if (P_2 != null)
				{
					((Control)oG).Text = P_2;
					((Control)oi).Text = P_2;
				}
				else
				{
					((Control)oG).Text = string.Empty;
					((Control)oi).Text = string.Empty;
				}
			}
			else if ((int)P_1 >= 48 && (int)P_1 <= 57)
			{
				((Control)oG).Text = (P_1 - 48).ToString();
				((Control)oi).Text = (P_1 - 48).ToString();
			}
			else if ((int)P_1 >= 96 && (int)P_1 <= 105)
			{
				((Control)oG).Text = (P_1 - 96).ToString();
				((Control)oi).Text = (P_1 - 96).ToString();
			}
			else if ((int)P_1 == 189 || (int)P_1 == 109)
			{
				((Control)oG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
				((Control)oi).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
			}
			((Control)og).Text = bS.A(P_4, P_3, false, 0);
			oD = P_3;
			oB = P_5;
			ob = P_6;
			oC = P_7;
			oc = P_8;
			if (oB != oC || ob != oc)
			{
				((Control)oh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kb() + bS.a(oC, P_3, -1);
				((Control)oI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KC() + bS.a(oc, P_3, -1);
			}
			else
			{
				((Control)oh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kc() + bS.a(oC, P_3, -1);
				((Control)oI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KD() + bS.a(oc, P_3, -1);
			}
		}

		[SpecialName]
		internal double A()
		{
			return Oz;
		}

		[SpecialName]
		internal string a()
		{
			return oA;
		}

		[SpecialName]
		internal int B()
		{
			return oa;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kd();
			try
			{
				if (od != null && od.Count != 0)
				{
					text = ((Control)oi).Text;
					Enumerator<Setting.ListItems.A> enumerator = od.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Setting.ListItems.A current = enumerator.Current;
							if (text == current.bBV)
							{
								oA = current.bBV;
								oa = current.bBv;
								return;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					int num = bS.A(text, oD);
					if (num < oB || num > ob)
					{
						throw new System.Exception();
					}
					Oz = double.Parse(text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture);
				}
				else
				{
					text = ((Control)oG).Text;
					int num2 = bS.A(text, oD);
					if (num2 < oB || num2 > ob)
					{
						throw new System.Exception();
					}
					Oz = double.Parse(text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture);
				}
			}
			catch
			{
				string text2 = bS.a(oC, oD, -1);
				string text3 = bS.a(oc, oD, -1);
				if (oB != oC || ob != oc)
				{
					string text4 = bS.a(oB, oD, -1);
					string text5 = bS.a(ob, oD, -1);
					string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KE();
					cE<object> buffer = default(cE<object>);
					cc.a<cE<object>, object>(ref buffer, 0) = text;
					cc.a<cE<object>, object>(ref buffer, 1) = text2;
					cc.a<cE<object>, object>(ref buffer, 2) = text3;
					cc.a<cE<object>, object>(ref buffer, 3) = text4;
					cc.a<cE<object>, object>(ref buffer, 4) = text5;
					bE.A((IWin32Window)(object)this, string.Format(text6, cc.A<cE<object>, object>(in buffer, 5)), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					bE.A((IWin32Window)(object)this, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ke(), (object)text, (object)text2, (object)text3), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				if (od != null && od.Count != 0)
				{
					((ComboBox)oi).SelectAll();
				}
				else
				{
					((TextBoxBase)oG).SelectAll();
				}
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (od != null && od.Count != 0)
			{
				((Control)oJ).Visible = true;
				((Control)oG).Visible = false;
				((Control)oi).Visible = true;
				((Control)oi).Focus();
				((ComboBox)oi).Select(((Control)oi).Text.Length, 0);
			}
			else
			{
				((Control)oJ).Visible = false;
				((Control)oi).Visible = false;
				((Control)oG).Visible = true;
				((Control)oG).Focus();
				((TextBoxBase)oG).Select(((Control)oG).Text.Length, 0);
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

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyCode == 13)
			{
				((Button)oe).PerformClick();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && oE != null)
			{
				((System.IDisposable)oE).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void b()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_0379: Unknown result type (might be due to invalid IL or missing references)
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a6: Expected O, but got Unknown
			//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Unknown result type (might be due to invalid IL or missing references)
			//IL_0447: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Expected O, but got Unknown
			//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e3: Expected O, but got Unknown
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0520: Unknown result type (might be due to invalid IL or missing references)
			//IL_055d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0581: Unknown result type (might be due to invalid IL or missing references)
			//IL_05be: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0631: Unknown result type (might be due to invalid IL or missing references)
			//IL_063b: Expected O, but got Unknown
			//IL_0683: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Expected O, but got Unknown
			//IL_0695: Unknown result type (might be due to invalid IL or missing references)
			//IL_069f: Expected O, but got Unknown
			oe = new ThemedButton();
			oF = new ThemedButton();
			of = new GroupBox();
			oJ = new Label();
			oi = new ThemedComboBox();
			oh = new Label();
			oI = new Label();
			oG = new ThemedTextBox();
			og = new Label();
			oH = new Label();
			((Control)of).SuspendLayout();
			((Control)this).SuspendLayout();
			((Button)oe).DialogResult = (DialogResult)1;
			((Control)oe).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)oe).Location = new Point(201, 112);
			((Control)oe).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)oe).Size = new Size(95, 30);
			((Control)oe).TabIndex = 2;
			((Control)oe).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)oe).UseVisualStyleBackColor = true;
			((Button)oF).DialogResult = (DialogResult)2;
			((Control)oF).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)oF).Location = new Point(302, 112);
			((Control)oF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)oF).Size = new Size(95, 30);
			((Control)oF).TabIndex = 3;
			((Control)oF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)oF).UseVisualStyleBackColor = true;
			((Control)of).Controls.Add((Control)(object)oJ);
			((Control)of).Controls.Add((Control)(object)oi);
			((Control)of).Controls.Add((Control)(object)oh);
			((Control)of).Controls.Add((Control)(object)oI);
			((Control)of).Controls.Add((Control)(object)oG);
			((Control)of).Controls.Add((Control)(object)og);
			((Control)of).Controls.Add((Control)(object)oH);
			((Control)of).Location = new Point(7, 2);
			((Control)of).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KF();
			((Control)of).Size = new Size(390, 104);
			((Control)of).TabIndex = 7;
			of.TabStop = false;
			((Control)oJ).AutoSize = true;
			((Control)oJ).Location = new Point(210, 47);
			((Control)oJ).MaximumSize = new Size(170, 50);
			((Control)oJ).MinimumSize = new Size(170, 50);
			((Control)oJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kf();
			((Control)oJ).Size = new Size(170, 50);
			((Control)oJ).TabIndex = 15;
			((Control)oJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KG();
			((Control)oJ).Visible = false;
			((ComboBox)oi).DrawMode = (DrawMode)1;
			((ListControl)oi).FormattingEnabled = true;
			((Control)oi).Location = new Point(84, 17);
			((ComboBox)oi).MaxDropDownItems = 100;
			((Control)oi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kg();
			((Control)oi).Size = new Size(180, 23);
			((Control)oi).TabIndex = 1;
			((Control)oi).KeyPress += new KeyPressEventHandler(A);
			((Control)oh).AutoSize = true;
			((Control)oh).Location = new Point(16, 73);
			((Control)oh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KH();
			((Control)oh).Size = new Size(129, 13);
			((Control)oh).TabIndex = 13;
			((Control)oh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kh();
			((Control)oI).AutoSize = true;
			((Control)oI).Location = new Point(16, 48);
			((Control)oI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KI();
			((Control)oI).Size = new Size(131, 13);
			((Control)oI).TabIndex = 12;
			((Control)oI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ki();
			((Control)oG).Location = new Point(84, 17);
			((Control)oG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KJ();
			((Control)oG).Size = new Size(180, 22);
			((Control)oG).TabIndex = 0;
			((Control)oG).KeyDown += new KeyEventHandler(A);
			((Control)oG).KeyPress += new KeyPressEventHandler(A);
			((Control)og).AutoSize = true;
			((Control)og).Location = new Point(270, 20);
			((Control)og).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kj();
			((Control)og).Size = new Size(40, 13);
			((Control)og).TabIndex = 9;
			((Control)og).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KK();
			((Control)oH).AutoSize = true;
			((Control)oH).Location = new Point(16, 20);
			((Control)oH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)oH).Size = new Size(64, 13);
			((Control)oH).TabIndex = 7;
			((Control)oH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kk();
			((Form)this).AcceptButton = (IButtonControl)(object)oe;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)oF;
			((Form)this).ClientSize = new Size(404, 149);
			((Control)this).Controls.Add((Control)(object)of);
			((Control)this).Controls.Add((Control)(object)oF);
			((Control)this).Controls.Add((Control)(object)oe);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KL();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kl();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)of).ResumeLayout(false);
			((Control)of).PerformLayout();
			((Control)this).ResumeLayout(false);
		}
	}
	internal class Bg : Form
	{
		private static readonly string oj = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KS();

		private Setting oK;

		private MenuNode ok;

		private IContainer oL;

		private ag ol;

		private ThemedButton oM;

		private ThemedButton om;

		private aP oN;

		internal Bg(string P_0, Setting P_1, MenuNode P_2)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			A();
			((Control)this).BackColor = BM.td;
			((Control)oN).ForeColor = BM.te;
			((Control)ol).BackColor = BM.td;
			((Control)ol).ForeColor = BM.te;
			((Control)ol).Text = P_0;
			ol.A();
			oK = P_1;
			ok = P_2;
			if (oK != null)
			{
				if (!string.IsNullOrEmpty(oK.I()))
				{
					((Control)oM).Visible = false;
				}
				else
				{
					((Control)oM).Visible = true;
				}
				if (oK.A() == 14691)
				{
					((Control)oN).Visible = false;
				}
				else if (((SettingOrSpecialObject)oK).p())
				{
					((Control)oN).Visible = false;
				}
				else
				{
					((Control)oN).Visible = true;
				}
			}
			else
			{
				((Control)oM).Visible = true;
				((Control)oN).Visible = true;
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (oK == null || !((SettingOrSpecialObject)oK).p())
			{
				((CheckBox)oN).Checked = !((Control)oN).Visible;
			}
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Invalid comparison between Unknown and I4
			if (oK != null && ((SettingOrSpecialObject)oK).p())
			{
				return;
			}
			if ((int)((Form)this).DialogResult == 1 && ((CheckBox)oN).Checked)
			{
				string[] array = null;
				if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				else if (File.Exists(oj))
				{
					array = File.ReadAllLines(oj);
				}
				else
				{
					((Stream)File.Create(oj)).Close();
				}
				List<string> val = null;
				if (array != null)
				{
					val = new List<string>((System.Collections.Generic.IEnumerable<string>)array);
				}
				List<string> val2 = new List<string>();
				if (ok != null)
				{
					string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KM() + ok.A(false, true);
					if (val == null || !val.Contains(text))
					{
						val2.Add(text);
					}
				}
				if (oK != null)
				{
					if (oK.A() == 14691)
					{
						string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Km() + ((SettingOrSpecialObject)oK).A().aXc;
						if (val == null || !val.Contains(text2))
						{
							val2.Add(text2);
						}
					}
					else if (!string.IsNullOrEmpty(oK.I()))
					{
						string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KN() + oK.A();
						if (val == null || !val.Contains(text3))
						{
							val2.Add(text3);
						}
					}
					else
					{
						string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kn() + oK.A();
						if (val == null || !val.Contains(text4))
						{
							val2.Add(text4);
						}
					}
				}
				File.AppendAllLines(oj, (System.Collections.Generic.IEnumerable<string>)val2);
			}
			else
			{
				if (oK == null || oK.A() != 14691 || !File.Exists(oj))
				{
					return;
				}
				List<string> val3 = new List<string>((System.Collections.Generic.IEnumerable<string>)File.ReadAllLines(oj));
				int num = val3.Count;
				bool flag = false;
				for (int i = 0; i < num; i++)
				{
					if (val3[i] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Km() + ((SettingOrSpecialObject)oK).A().aXc)
					{
						val3.RemoveAt(i);
						num--;
						flag = true;
					}
				}
				if (flag)
				{
					File.WriteAllLines(oj, (System.Collections.Generic.IEnumerable<string>)val3);
				}
			}
		}

		internal static bool A(Setting P_0, MenuNode P_1)
		{
			if (P_0 != null && ((SettingOrSpecialObject)P_0).p())
			{
				return false;
			}
			if (File.Exists(oj))
			{
				StreamReader val = File.OpenText(oj);
				try
				{
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						if (P_1 != null)
						{
							if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KM()) && text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KM().Length) == P_1.A(false, true))
							{
								return true;
							}
						}
						else
						{
							if (P_0 == null)
							{
								continue;
							}
							if (P_0.A() == 14691)
							{
								if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Km()) && text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Km().Length) == ((SettingOrSpecialObject)P_0).A().aXc)
								{
									return true;
								}
							}
							else if (!string.IsNullOrEmpty(P_0.I()))
							{
								if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KN()) && int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KN().Length)) == P_0.A())
								{
									return true;
								}
							}
							else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kn()) && int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kn().Length)) == P_0.A())
							{
								return true;
							}
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

		private void A(object P_0, LinkClickedEventArgs P_1)
		{
			Process.Start(P_1.LinkText);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && oL != null)
			{
				((System.IDisposable)oL).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected O, but got Unknown
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Expected O, but got Unknown
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Expected O, but got Unknown
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Expected O, but got Unknown
			ol = new ag();
			oM = new ThemedButton();
			om = new ThemedButton();
			oN = new aP();
			((Control)this).SuspendLayout();
			((TextBoxBase)ol).BorderStyle = (BorderStyle)0;
			((Control)ol).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)ol).Location = new Point(13, 13);
			((Control)ol).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KO();
			((TextBoxBase)ol).ReadOnly = true;
			((RichTextBox)ol).ScrollBars = (RichTextBoxScrollBars)2;
			((Control)ol).Size = new Size(559, 408);
			((Control)ol).TabIndex = 3;
			((Control)ol).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
			((RichTextBox)ol).LinkClicked += new LinkClickedEventHandler(A);
			((Button)oM).DialogResult = (DialogResult)2;
			((Control)oM).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)oM).Location = new Point(497, 426);
			((Control)oM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ko();
			((Control)oM).Size = new Size(75, 30);
			((Control)oM).TabIndex = 0;
			((Control)oM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KP();
			((ButtonBase)oM).UseVisualStyleBackColor = true;
			((Button)om).DialogResult = (DialogResult)1;
			((Control)om).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)om).Location = new Point(416, 426);
			((Control)om).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kp();
			((Control)om).Size = new Size(75, 30);
			((Control)om).TabIndex = 1;
			((Control)om).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KQ();
			((ButtonBase)om).UseVisualStyleBackColor = true;
			((Control)oN).AutoSize = true;
			((Control)oN).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)oN).Location = new Point(16, 433);
			((Control)oN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kq();
			((Control)oN).Size = new Size(212, 17);
			((Control)oN).TabIndex = 2;
			((Control)oN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KR();
			((ButtonBase)oN).UseVisualStyleBackColor = true;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(584, 462);
			((Form)this).ControlBox = false;
			((Control)this).Controls.Add((Control)(object)oN);
			((Control)this).Controls.Add((Control)(object)om);
			((Control)this).Controls.Add((Control)(object)oM);
			((Control)this).Controls.Add((Control)(object)ol);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kr();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kr();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal class bG : Form
	{
		internal static readonly string aBJ = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBj();

		private List<ThemedComboBox> aBj = new List<ThemedComboBox>();

		private IContainer aBK;

		private ThemedButton aBk;

		private ThemedButton aBL;

		private Panel aBl;

		internal bG()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			A();
			((Control)this).BackColor = BM.td;
			((Control)aBl).BackColor = BM.tH;
			int num = 10;
			for (int i = 0; i < bS.aCw.Length; i++)
			{
				Label val = new Label();
				((Control)val).ForeColor = BM.te;
				((Control)val).Text = bS.aCw[i];
				((Control)val).Width = (((Control)aBl).Width - 20) / 2;
				((Control)val).Left = 10;
				((Control)val).Top = num + 3;
				((Control)aBl).Controls.Add((Control)(object)val);
				ThemedComboBox themedComboBox = new ThemedComboBox();
				((ComboBox)themedComboBox).DropDownStyle = (ComboBoxStyle)2;
				string[] array = bS.aCX[i];
				for (int j = 0; j < array.Length; j++)
				{
					((ComboBox)themedComboBox).Items.Add((object)array[j]);
				}
				if (File.Exists(aBJ))
				{
					StreamReader val2 = File.OpenText(aBJ);
					try
					{
						bool flag = false;
						string text;
						while ((text = ((TextReader)val2).ReadLine()) != null)
						{
							if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBi() + i + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ()))
							{
								((ListControl)themedComboBox).SelectedIndex = int.Parse(text.Substring((D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBi() + i + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ()).Length));
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							((ListControl)themedComboBox).SelectedIndex = bS.aCx[i + 1];
						}
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
				}
				else
				{
					((ListControl)themedComboBox).SelectedIndex = bS.aCx[i + 1];
				}
				((Control)themedComboBox).Width = (((Control)aBl).Width - 20) / 2;
				((Control)themedComboBox).Left = ((Control)val).Right;
				((Control)themedComboBox).Top = num;
				aBj.Add(themedComboBox);
				((Control)aBl).Controls.Add((Control)(object)themedComboBox);
				num += ((Control)themedComboBox).Height + 2;
			}
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((Form)this).DialogResult == 1)
			{
				for (int i = 0; i < aBj.Count; i++)
				{
					bS.aCx[i + 1] = ((ListControl)aBj[i]).SelectedIndex;
				}
				if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				((Stream)File.Create(aBJ)).Close();
				List<string> val = new List<string>();
				for (int j = 0; j < aBj.Count; j++)
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBi() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ() + bS.aCx[j + 1]);
				}
				File.AppendAllLines(aBJ, (System.Collections.Generic.IEnumerable<string>)val);
				BM.sX = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aBK != null)
			{
				((System.IDisposable)aBK).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Expected O, but got Unknown
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected O, but got Unknown
			aBk = new ThemedButton();
			aBL = new ThemedButton();
			aBl = new Panel();
			((Control)this).SuspendLayout();
			((Button)aBk).DialogResult = (DialogResult)2;
			((Control)aBk).Location = new Point(289, 364);
			((Control)aBk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)aBk).Size = new Size(96, 35);
			((Control)aBk).TabIndex = 1;
			((Control)aBk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)aBk).UseVisualStyleBackColor = true;
			((Button)aBL).DialogResult = (DialogResult)1;
			((Control)aBL).Location = new Point(187, 364);
			((Control)aBL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)aBL).Size = new Size(96, 35);
			((Control)aBL).TabIndex = 2;
			((Control)aBL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)aBL).UseVisualStyleBackColor = true;
			aBl.BorderStyle = (BorderStyle)1;
			((Control)aBl).Location = new Point(12, 12);
			((Control)aBl).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xy();
			((Control)aBl).Size = new Size(373, 341);
			((Control)aBl).TabIndex = 3;
			((Form)this).AcceptButton = (IButtonControl)(object)aBL;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)aBk;
			((Form)this).ClientSize = new Size(397, 407);
			((Control)this).Controls.Add((Control)(object)aBl);
			((Control)this).Controls.Add((Control)(object)aBL);
			((Control)this).Controls.Add((Control)(object)aBk);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBJ();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pF();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
		}
	}
	internal class bg : Form
	{
		private bool aBM;

		private IContainer aBm;

		private aP aBN;

		private Label aBn;

		private ThemedButton aBO;

		private ThemedButton aBo;

		private aP aBP;

		internal bg()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			aBM = true;
			B();
			((Control)this).BackColor = BM.tE;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label || val is aP)
				{
					val.ForeColor = BM.te;
				}
			}
			try
			{
				if (bj.b())
				{
					((Control)aBP).Enabled = true;
					if (bj.D())
					{
						((CheckBox)aBP).Checked = true;
					}
					else
					{
						((CheckBox)aBP).Checked = false;
					}
				}
				else
				{
					((CheckBox)aBP).Checked = false;
					((Control)aBP).Enabled = false;
				}
			}
			catch
			{
				((CheckBox)aBP).Checked = false;
				((Control)aBP).Enabled = false;
			}
			((CheckBox)aBN).Checked = a();
			aBM = false;
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Control)aBO).Focus();
		}

		private void a(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		private void B(object P_0, EventArgs P_1)
		{
			BM.QQ.a((object)null, (EventArgs)null);
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (!aBM)
			{
				try
				{
					bj.c();
				}
				catch
				{
					((CheckBox)aBP).Checked = false;
					((Control)aBP).Enabled = false;
				}
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Invalid comparison between Unknown and I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			if (((CheckBox)aBN).Checked)
			{
				if (BM.QQ.qd.UserOptInPrivacy)
				{
					A(true, out var flag);
					if (!flag)
					{
						((CheckBox)aBN).Checked = false;
					}
				}
				else if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBK(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBk(), (MessageBoxButtons)4) == 6)
				{
					bH obj = new bH();
					((Form)obj).ShowDialog((IWin32Window)(object)this);
					((Component)obj).Dispose();
					if (BM.QQ.qd.UserOptInPrivacy)
					{
						A(true, out var flag2);
						if (!flag2)
						{
							((CheckBox)aBN).Checked = false;
						}
					}
					else
					{
						((CheckBox)aBN).Checked = false;
					}
				}
				else
				{
					((CheckBox)aBN).Checked = false;
				}
			}
			else
			{
				A(false, out var _);
			}
		}

		internal static bool A()
		{
			try
			{
				string text = string.Concat(BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBL(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBl());
				if (File.Exists(text))
				{
					return File.ReadAllText(text).Trim() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBM();
				}
				return false;
			}
			catch
			{
				return false;
			}
		}

		internal static void A(bool P_0, out bool P_1)
		{
			try
			{
				string text = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBL();
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllText(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBl(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBm() + P_0);
				P_1 = true;
			}
			catch
			{
				P_1 = false;
			}
			BM.QQ.F();
		}

		internal static bool a()
		{
			if (BM.QQ.qd.UserOptInPrivacy)
			{
				return A();
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aBm != null)
			{
				((System.IDisposable)aBm).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void B()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Expected O, but got Unknown
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Expected O, but got Unknown
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Expected O, but got Unknown
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Expected O, but got Unknown
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Expected O, but got Unknown
			//IL_0416: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Expected O, but got Unknown
			ComponentResourceManager val = new ComponentResourceManager(typeof(bg));
			aBN = new aP();
			aBn = new Label();
			aBO = new ThemedButton();
			aBo = new ThemedButton();
			aBP = new aP();
			((Control)this).SuspendLayout();
			((Control)aBN).AutoSize = true;
			((Control)aBN).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)aBN).Location = new Point(11, 116);
			((Control)aBN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBN();
			((Control)aBN).Size = new Size(195, 17);
			((Control)aBN).TabIndex = 2;
			((Control)aBN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBn();
			((ButtonBase)aBN).UseVisualStyleBackColor = true;
			((CheckBox)aBN).CheckedChanged += new EventHandler(C);
			((Control)aBn).AutoSize = true;
			((Control)aBn).Location = new Point(11, 137);
			((Control)aBn).MaximumSize = new Size(300, 0);
			((Control)aBn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)aBn).Size = new Size(298, 169);
			((Control)aBn).TabIndex = 1;
			((Control)aBn).Text = ((ResourceManager)val).GetString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VH());
			((Button)aBO).DialogResult = (DialogResult)2;
			((Control)aBO).Location = new Point(123, 332);
			((Control)aBO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gu();
			((Control)aBO).Size = new Size(75, 35);
			((Control)aBO).TabIndex = 3;
			((Control)aBO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gV();
			((ButtonBase)aBO).UseVisualStyleBackColor = true;
			((Control)aBO).Click += new EventHandler(a);
			((Control)aBo).Location = new Point(85, 49);
			((Control)aBo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBO();
			((Control)aBo).Size = new Size(150, 35);
			((Control)aBo).TabIndex = 1;
			((Control)aBo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBo();
			((ButtonBase)aBo).TextImageRelation = (TextImageRelation)4;
			((ButtonBase)aBo).UseVisualStyleBackColor = true;
			((Control)aBo).Click += new EventHandler(B);
			((Control)aBP).AutoSize = true;
			((Control)aBP).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)aBP).Location = new Point(11, 14);
			((Control)aBP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBP();
			((Control)aBP).Size = new Size(247, 17);
			((Control)aBP).TabIndex = 0;
			((Control)aBP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBp();
			((ButtonBase)aBP).UseVisualStyleBackColor = true;
			((CheckBox)aBP).CheckedChanged += new EventHandler(b);
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)aBO;
			((Form)this).ClientSize = new Size(320, 381);
			((Control)this).Controls.Add((Control)(object)aBP);
			((Control)this).Controls.Add((Control)(object)aBo);
			((Control)this).Controls.Add((Control)(object)aBO);
			((Control)this).Controls.Add((Control)(object)aBn);
			((Control)this).Controls.Add((Control)(object)aBN);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBQ();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBq();
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
