using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace B
{
	internal class BQ : Form
	{
		private Setting uk;

		private int uL;

		private int ul;

		private IContainer uM;

		private ThemedButton um;

		private ThemedButton uN;

		private Label un;

		private Label uO;

		private Label uo;

		private ThemedTextBox uP;

		private ThemedTextBox up;

		private Label uQ;

		internal BQ()
		{
			B();
		}

		internal BQ(Setting P_0, int P_1, int P_2)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			B();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
				if (val is ThemedTextBox)
				{
					val.BackColor = BM.to;
					val.ForeColor = BM.te;
				}
			}
			uk = P_0;
			uL = P_1;
			ul = P_2;
			if (uk != null)
			{
				int num = uk.aS();
				string text = ((SettingOrSpecialObject)uk).H();
				if (!string.IsNullOrWhiteSpace(text))
				{
					if (num != 0 && num != 82)
					{
						((Control)un).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(uk.@as(), num, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					else
					{
						((Control)un).Text = text;
					}
				}
				else if (num != 0 && num != 82)
				{
					((Control)un).Text = ((SettingOrSpecialObject)uk).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(uk.@as(), num, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
				}
				else
				{
					((Control)un).Text = ((SettingOrSpecialObject)uk).A(bz.aYT);
				}
				((Control)up).Text = bS.a(uL, num, -1);
				((Control)uP).Text = bS.a(ul, num, -1);
				((Control)up).Visible = true;
				((Control)uP).Visible = true;
			}
			else
			{
				((Control)un).Text = string.Empty;
				((Control)up).Visible = false;
				((Control)uP).Visible = false;
			}
		}

		[SpecialName]
		internal int A()
		{
			return uL;
		}

		[SpecialName]
		internal int a()
		{
			return ul;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult != 1 || uk == null)
			{
				return;
			}
			int num = uk.aS();
			int num2 = uk.aR();
			int num3 = uk.ar();
			bool flag = false;
			bool flag2 = false;
			try
			{
				int num4 = bS.A(((Control)up).Text, num);
				int num5 = bS.A(((Control)uP).Text, num);
				if (num2 != 0 || num3 != 0)
				{
					if (num4 < num2 || num4 > num3)
					{
						flag = true;
						throw new System.Exception();
					}
					if (num5 < num2 || num5 > num3)
					{
						flag2 = true;
						throw new System.Exception();
					}
				}
				uL = num4;
				ul = num5;
			}
			catch
			{
				string text = (flag ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LG() : ((!flag2) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LH() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lg()));
				string text2 = bS.a(num2, num, -1);
				string text3 = bS.a(num3, num, -1);
				bE.A((IWin32Window)(object)this, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lh() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LI(), (object)text2, (object)text3), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && uM != null)
			{
				((System.IDisposable)uM).Dispose();
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
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Expected O, but got Unknown
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Expected O, but got Unknown
			um = new ThemedButton();
			uN = new ThemedButton();
			un = new Label();
			uO = new Label();
			uo = new Label();
			uP = new ThemedTextBox();
			up = new ThemedTextBox();
			uQ = new Label();
			((Control)this).SuspendLayout();
			((Button)um).DialogResult = (DialogResult)1;
			((Control)um).Location = new Point(30, 163);
			((Control)um).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)um).Size = new Size(89, 34);
			((Control)um).TabIndex = 2;
			((Control)um).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)um).UseVisualStyleBackColor = true;
			((Button)uN).DialogResult = (DialogResult)2;
			((Control)uN).Location = new Point(125, 163);
			((Control)uN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)uN).Size = new Size(89, 34);
			((Control)uN).TabIndex = 3;
			((Control)uN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)uN).UseVisualStyleBackColor = true;
			((Control)un).AutoSize = true;
			((Control)un).Location = new Point(10, 10);
			((Control)un).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Li();
			((Control)un).Size = new Size(98, 13);
			((Control)un).TabIndex = 2;
			((Control)un).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LJ();
			((Control)uO).AutoSize = true;
			((Control)uO).Location = new Point(127, 106);
			((Control)uO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)uO).Size = new Size(80, 13);
			((Control)uO).TabIndex = 37;
			((Control)uO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ll();
			((Control)uo).AutoSize = true;
			((Control)uo).Location = new Point(21, 106);
			((Control)uo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)uo).Size = new Size(76, 13);
			((Control)uo).TabIndex = 36;
			((Control)uo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LM();
			((Control)uP).Location = new Point(125, 122);
			((Control)uP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lm();
			((Control)uP).Size = new Size(100, 22);
			((Control)uP).TabIndex = 1;
			((Control)up).Location = new Point(19, 122);
			((Control)up).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LN();
			((Control)up).Size = new Size(100, 22);
			((Control)up).TabIndex = 0;
			((Control)uQ).Location = new Point(10, 39);
			((Control)uQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)uQ).Size = new Size(231, 62);
			((Control)uQ).TabIndex = 38;
			((Control)uQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ln();
			((Form)this).AcceptButton = (IButtonControl)(object)um;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)uN;
			((Form)this).ClientSize = new Size(244, 207);
			((Control)this).Controls.Add((Control)(object)uQ);
			((Control)this).Controls.Add((Control)(object)uO);
			((Control)this).Controls.Add((Control)(object)uo);
			((Control)this).Controls.Add((Control)(object)uP);
			((Control)this).Controls.Add((Control)(object)up);
			((Control)this).Controls.Add((Control)(object)un);
			((Control)this).Controls.Add((Control)(object)uN);
			((Control)this).Controls.Add((Control)(object)um);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UM();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Bq : Form
	{
		private struct A
		{
			internal ThemedTextBox Bqx;

			internal ThemedTextBox BqY;

			internal ThemedTextBox Bqy;
		}

		private DO uq;

		private MenuNode uR;

		private Setting ur;

		private List<Control> uS = new List<Control>();

		private Dictionary<string, A> us = new Dictionary<string, A>();

		private Image uT;

		private string ut;

		private PictureBox uU;

		private int uu;

		private Version uV;

		private string uv;

		private IContainer uW;

		private ThemedTextBox uw;

		private Label uX;

		private ThemedTextBox ux;

		private Label uY;

		private ThemedTextBox uy;

		private Label uZ;

		private ThemedTextBox uz;

		private ThemedButton VA;

		private ThemedButton Va;

		private Label VB;

		private Label Vb;

		private ThemedTextBox VC;

		private ThemedButton Vc;

		private ThemedButton VD;

		private ab Vd;

		private ColumnHeader VE;

		private ColumnHeader Ve;

		private ThemedButton VF;

		internal Bq(DO P_0, MenuNode P_1)
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected O, but got Unknown
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected O, but got Unknown
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Expected O, but got Unknown
			//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f2: Expected O, but got Unknown
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Expected O, but got Unknown
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0789: Unknown result type (might be due to invalid IL or missing references)
			//IL_0790: Expected O, but got Unknown
			//IL_0550: Unknown result type (might be due to invalid IL or missing references)
			//IL_093e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0945: Expected O, but got Unknown
			//IL_0955: Unknown result type (might be due to invalid IL or missing references)
			//IL_0966: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0982: Unknown result type (might be due to invalid IL or missing references)
			this.a();
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Um() + P_1.E() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu();
			((Control)this).BackColor = BM.td;
			uq = P_0;
			uR = P_1;
			ur = uR.a().A(uR.W());
			A();
			int num = ((Control)uX).Top - ((Control)VB).Top;
			int num2 = ((Control)Vb).Top + num;
			int num3 = ((Control)VC).Top + num;
			int num4 = ((Control)VC).TabIndex + 1;
			for (int i = 0; i < uq.c().Count; i++)
			{
				string text = uq.c()[i];
				Label val = new Label();
				((Control)val).Font = ((Control)VB).Font;
				((Control)val).AutoSize = true;
				((Control)val).Text = Cn.A(text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
				((Control)val).Left = ((Control)VB).Left;
				((Control)val).Top = num2;
				num2 += num;
				((Control)this).Controls.Add((Control)(object)val);
				Control val2;
				if (uq.E().ContainsKey(text))
				{
					val2 = (Control)(object)new ThemedComboBox();
					((ComboBox)(val2 as ThemedComboBox)).DropDownStyle = (ComboBoxStyle)1;
					ObjectCollection items = ((ComboBox)(val2 as ThemedComboBox)).Items;
					object[] array = uq.E()[text];
					items.AddRange(array);
					if (uq.E()[text].Length == 1)
					{
						val2.Text = uq.E()[text][0];
					}
				}
				else
				{
					val2 = (Control)(object)new ThemedTextBox();
				}
				val2.Font = ((Control)uy).Font;
				val2.Size = ((Control)uy).Size;
				val2.Tag = text;
				val2.Left = ((Control)uy).Left;
				val2.Top = num3;
				num3 += num;
				val2.TabIndex = num4;
				num4++;
				uS.Add(val2);
				((Control)this).Controls.Add(val2);
			}
			for (int j = 0; j < uq.D().Count; j++)
			{
				string text2 = uq.D()[j];
				if (uq.c().Contains(text2))
				{
					continue;
				}
				Label val3 = new Label();
				((Control)val3).Font = ((Control)VB).Font;
				((Control)val3).AutoSize = true;
				((Control)val3).Text = Cn.A(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
				((Control)val3).Left = ((Control)VB).Left;
				((Control)val3).Top = num2;
				num2 += num;
				((Control)this).Controls.Add((Control)(object)val3);
				Control val4;
				if (uq.E().ContainsKey(text2))
				{
					val4 = (Control)(object)new ThemedComboBox();
					((ComboBox)(val4 as ThemedComboBox)).DropDownStyle = (ComboBoxStyle)1;
					ObjectCollection items2 = ((ComboBox)(val4 as ThemedComboBox)).Items;
					object[] array = uq.E()[text2];
					items2.AddRange(array);
					if (uq.E()[text2].Length == 1)
					{
						val4.Text = uq.E()[text2][0];
					}
				}
				else
				{
					val4 = (Control)(object)new ThemedTextBox();
				}
				val4.Font = ((Control)uy).Font;
				val4.Size = ((Control)uy).Size;
				val4.Tag = text2;
				val4.Left = ((Control)uy).Left;
				val4.Top = num3;
				num3 += num;
				val4.TabIndex = num4;
				num4++;
				uS.Add(val4);
				((Control)this).Controls.Add(val4);
			}
			for (int k = 0; k < uq.d().Count; k++)
			{
				string text3 = uq.d()[k];
				if (uq.c().Contains(text3))
				{
					continue;
				}
				Label val5 = new Label();
				((Control)val5).Font = ((Control)VB).Font;
				((Control)val5).AutoSize = true;
				((Control)val5).Text = Cn.A(text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
				((Control)val5).Left = ((Control)VB).Left;
				((Control)val5).Top = num2;
				num2 += num;
				((Control)this).Controls.Add((Control)(object)val5);
				Control val6;
				if (uq.E().ContainsKey(text3))
				{
					val6 = (Control)(object)new ThemedComboBox();
					((ComboBox)(val6 as ThemedComboBox)).DropDownStyle = (ComboBoxStyle)1;
					ObjectCollection items3 = ((ComboBox)(val6 as ThemedComboBox)).Items;
					object[] array = uq.E()[text3];
					items3.AddRange(array);
					if (uq.E()[text3].Length == 1)
					{
						val6.Text = uq.E()[text3][0];
					}
				}
				else
				{
					val6 = (Control)(object)new ThemedTextBox();
				}
				val6.Font = ((Control)uy).Font;
				val6.Size = ((Control)uy).Size;
				val6.Tag = text3;
				val6.Left = ((Control)uy).Left;
				val6.Top = num3;
				num3 += num;
				val6.TabIndex = num4;
				num4++;
				uS.Add(val6);
				((Control)this).Controls.Add(val6);
			}
			string[] array2 = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu() };
			foreach (string text4 in array2)
			{
				A a = default(A);
				Label val7 = new Label();
				((Control)val7).Font = ((Control)VB).Font;
				((Control)val7).AutoSize = true;
				((Control)val7).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UN() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Un();
				((Control)val7).Left = ((Control)VB).Left;
				((Control)val7).Top = num2;
				num2 += num;
				((Control)this).Controls.Add((Control)(object)val7);
				ThemedTextBox themedTextBox = new ThemedTextBox();
				((Control)themedTextBox).Font = ((Control)uy).Font;
				((Control)themedTextBox).Size = ((Control)uy).Size;
				((Control)themedTextBox).Left = ((Control)uy).Left;
				((Control)themedTextBox).Top = num3;
				num3 += num;
				((Control)themedTextBox).TabIndex = num4;
				num4++;
				a.Bqx = themedTextBox;
				((Control)this).Controls.Add((Control)(object)themedTextBox);
				Label val8 = new Label();
				((Control)val8).Font = ((Control)VB).Font;
				((Control)val8).AutoSize = true;
				((Control)val8).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UO() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Un();
				((Control)val8).Left = ((Control)VB).Left;
				((Control)val8).Top = num2;
				num2 += num;
				((Control)this).Controls.Add((Control)(object)val8);
				ThemedTextBox themedTextBox2 = new ThemedTextBox();
				((Control)themedTextBox2).Font = ((Control)uy).Font;
				((Control)themedTextBox2).Size = ((Control)uy).Size;
				((Control)themedTextBox2).Left = ((Control)uy).Left;
				((Control)themedTextBox2).Top = num3;
				num3 += num;
				((Control)themedTextBox2).TabIndex = num4;
				num4++;
				a.BqY = themedTextBox2;
				((Control)this).Controls.Add((Control)(object)themedTextBox2);
				Label val9 = new Label();
				((Control)val9).Font = ((Control)VB).Font;
				((Control)val9).AutoSize = true;
				((Control)val9).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uo() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Un();
				((Control)val9).Left = ((Control)VB).Left;
				((Control)val9).Top = num2;
				num2 += num * 4;
				((Control)this).Controls.Add((Control)(object)val9);
				ThemedTextBox themedTextBox3 = new ThemedTextBox();
				((Control)themedTextBox3).Font = ((Control)uy).Font;
				((TextBoxBase)themedTextBox3).Multiline = true;
				((TextBox)themedTextBox3).AcceptsReturn = true;
				((Control)themedTextBox3).Width = ((Control)uy).Width;
				((Control)themedTextBox3).Height = num * 4 - (num - ((Control)uy).Height);
				((Control)themedTextBox3).Left = ((Control)uy).Left;
				((Control)themedTextBox3).Top = num3;
				num3 += num * 4;
				((Control)themedTextBox3).TabIndex = num4;
				num4++;
				a.Bqy = themedTextBox3;
				((Control)this).Controls.Add((Control)(object)themedTextBox3);
				us.Add(text4, a);
			}
			((Control)VA).TabIndex = num4;
			((Control)Va).TabIndex = ((Control)VA).TabIndex + 1;
			((Control)VF).TabIndex = ((Control)Va).TabIndex + 1;
			((Control)Vc).TabIndex = ((Control)VF).TabIndex + 1;
			((Control)VD).TabIndex = ((Control)Vc).TabIndex + 1;
			((Control)Vd).TabIndex = ((Control)VD).TabIndex + 1;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val10 = item;
				if (val10 is ThemedTextBox)
				{
					((Control)(val10 as ThemedTextBox)).BackColor = BM.to;
					((Control)(val10 as ThemedTextBox)).ForeColor = BM.te;
				}
				else if (val10 is Label)
				{
					((val10 is Label) ? val10 : null).ForeColor = BM.te;
				}
			}
			((Control)Vd).BackColor = BM.tH;
			((Control)Vd).ForeColor = BM.te;
			Size clientSize = ((Form)this).ClientSize;
			uu = ((Size)(ref clientSize)).Width;
			if (uR.Y() != null && uR.Y().BcF != null)
			{
				A(uR.Y());
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Invalid comparison between Unknown and I4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			Guid val;
			if (string.IsNullOrEmpty(uv))
			{
				val = Guid.NewGuid();
				uv = ((object)(Guid)(ref val)).ToString();
				uV = null;
				Version val2 = new Version(uq.A(), 0, 0);
				((Control)uw).Text = ((object)val2).ToString();
			}
			else if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UP(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Up(), (MessageBoxButtons)4, (MessageBoxIcon)32, new string[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.og(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UQ()
			}) == 6)
			{
				val = Guid.NewGuid();
				uv = ((object)(Guid)(ref val)).ToString();
				uV = null;
				Version val3 = new Version(uq.A(), 0, 0);
				((Control)uw).Text = ((object)val3).ToString();
			}
			else
			{
				((Control)ux).Enabled = false;
				if (uR.aC())
				{
					Version val4 = new Version(uV.Major, uV.Minor + 1, 0);
					((Control)uw).Text = ((object)val4).ToString();
				}
				else
				{
					Version val5 = new Version(uV.Major, uV.Minor, uV.Build + 1);
					((Control)uw).Text = ((object)val5).ToString();
				}
			}
			((Control)uz).Focus();
		}

		private void A(CO P_0)
		{
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			uv = P_0.BcF.BCX;
			uV = P_0.BcF.BCY;
			((Control)uz).Text = Path.GetFileNameWithoutExtension(P_0.Bcf);
			((Control)ux).Text = P_0.BcF.BCy;
			((Control)uy).Text = P_0.BcF.Bca;
			if (!string.IsNullOrEmpty(P_0.BcF.BcB))
			{
				uT = Co.A(P_0);
				if (uT != null)
				{
					ut = P_0.BcF.BcB;
					if (uU == null)
					{
						uU = new PictureBox();
						((Control)this).Controls.Add((Control)(object)uU);
					}
					((Control)uU).Top = 10;
					((Control)uU).Left = ((Control)Vd).Left + ((Control)Vd).Width + 20;
					PictureBox obj = uU;
					Size clientSize = ((Form)this).ClientSize;
					((Control)obj).Height = Math.Min(((Size)(ref clientSize)).Height - 20, uT.Height);
					((Control)uU).Width = uT.Width * ((Control)uU).Height / uT.Height;
					uU.SizeMode = (PictureBoxSizeMode)4;
					uU.Image = uT;
					int num = ((Control)uU).Left + ((Control)uU).Width + 10;
					clientSize = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num, ((Size)(ref clientSize)).Height);
					((Control)uU).Visible = true;
				}
			}
			Enumerator<Control> enumerator = uS.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Control current = enumerator.Current;
					string text = current.Tag as string;
					if (P_0.BcF.Bcb.ContainsKey(text))
					{
						current.Text = P_0.BcF.Bcb[text];
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<string, A> enumerator2 = us.Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					string current2 = enumerator2.Current;
					if (P_0.BcF.BcC.ContainsKey(current2))
					{
						Cn.A a = P_0.BcF.BcC[current2];
						((Control)us[current2].Bqx).Text = a.BsP;
						((Control)us[current2].BqY).Text = a.Bsp;
						((Control)us[current2].Bqy).Text = a.BsQ;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		private void A()
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			List<Setting> val = uq.A(uR);
			Enumerator<string> enumerator = CN.A(null, uR, val, true).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					string[] array = new string[2];
					if (current.Contains(','))
					{
						array[0] = current.Substring(0, current.IndexOf(','));
						array[1] = current.Substring(current.IndexOf(',') + 1);
					}
					else
					{
						array[0] = current;
						array[1] = string.Empty;
					}
					((ListView)Vd).Items.Add(new ListViewItem(array));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Invalid comparison between Unknown and I4
			string text;
			Cn cn = A(out text);
			if (cn == null)
			{
				return;
			}
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uq();
			((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UR();
			((FileDialog)val).InitialDirectory = Path.GetFullPath(BM.QY + uq.e());
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
			{
				List<string> val2 = CN.A(cn);
				val2.Add(string.Empty);
				val2.AddRange((System.Collections.Generic.IEnumerable<string>)CN.A(cn, uR, true));
				try
				{
					File.WriteAllLines(((FileDialog)val).FileName, (System.Collections.Generic.IEnumerable<string>)val2);
				}
				catch (System.Exception ex)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ur() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			((Component)val).Dispose();
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Invalid comparison between Unknown and I4
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.US();
			string text = BM.QY + uq.e() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK();
			if (Directory.Exists(text))
			{
				((FileDialog)val).InitialDirectory = text;
			}
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
			{
				((Control)VC).Text = ((FileDialog)val).FileName;
				Size clientSize;
				try
				{
					uT = Image.FromFile(((Control)VC).Text);
					ut = Path.GetFileName(((Control)VC).Text);
					if (uU == null)
					{
						uU = new PictureBox();
						((Control)this).Controls.Add((Control)(object)uU);
					}
					((Control)uU).Top = 10;
					((Control)uU).Left = ((Control)Vd).Left + ((Control)Vd).Width + 20;
					PictureBox obj = uU;
					clientSize = ((Form)this).ClientSize;
					((Control)obj).Height = Math.Min(((Size)(ref clientSize)).Height - 20, uT.Height);
					((Control)uU).Width = uT.Width * ((Control)uU).Height / uT.Height;
					uU.SizeMode = (PictureBoxSizeMode)4;
					uU.Image = uT;
					int num = ((Control)uU).Left + ((Control)uU).Width + 10;
					clientSize = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num, ((Size)(ref clientSize)).Height);
					((Control)uU).Visible = true;
				}
				catch
				{
					if (uU != null)
					{
						((Control)uU).Visible = false;
						uU.Image = null;
						int num2 = uu;
						clientSize = ((Form)this).ClientSize;
						((Form)this).ClientSize = new Size(num2, ((Size)(ref clientSize)).Height);
					}
					uT = null;
					ut = null;
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Us() + ((Control)VC).Text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)VC).Text = string.Empty;
				}
			}
			((Component)val).Dispose();
		}

		private void b(object P_0, EventArgs P_1)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			if (uU != null)
			{
				((Control)uU).Visible = false;
				uU.Image = null;
				int num = uu;
				Size clientSize = ((Form)this).ClientSize;
				((Form)this).ClientSize = new Size(num, ((Size)(ref clientSize)).Height);
			}
			uT = null;
			ut = null;
			((Control)VC).Text = string.Empty;
		}

		private Cn A(out string P_0)
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Expected O, but got Unknown
			//IL_0294: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0423: Unknown result type (might be due to invalid IL or missing references)
			//IL_045f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			Cn cn = new Cn();
			string text = ((Control)uz).Text;
			P_0 = null;
			try
			{
				if (string.IsNullOrEmpty(text))
				{
					throw new System.Exception();
				}
				if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU()))
				{
					text = text.Substring(0, text.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU().Length);
				}
			}
			catch
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UT(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return null;
			}
			if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bk()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bL()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bm()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bM()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bN()))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ut(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return null;
			}
			string text2 = BM.QY + uq.e();
			P_0 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU();
			if (Directory.Exists(text2))
			{
				if (File.Exists(P_0))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return null;
				}
			}
			else
			{
				try
				{
					Directory.CreateDirectory(text2);
				}
				catch
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uu() + text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return null;
				}
			}
			cn.BCx = ((SettingOrSpecialObject)ur).d();
			cn.BCZ = BM.Qz.aXA;
			cn.BCz = BM.Qz.awZ;
			cn.BcA = BM.Qz.awz;
			if (string.IsNullOrEmpty(uv))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UV(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return null;
			}
			cn.BCX = uv;
			if (string.IsNullOrEmpty(((Control)uw).Text))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uv(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return null;
			}
			Version val = null;
			try
			{
				val = new Version(((Control)uw).Text);
			}
			catch
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UW(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return null;
			}
			if (uV != (Version)null && val <= uV)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return null;
			}
			cn.BCY = val;
			if (string.IsNullOrEmpty(((Control)ux).Text))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UX(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return null;
			}
			cn.BCy = ((Control)ux).Text;
			if (string.IsNullOrEmpty(((Control)VC).Text))
			{
				if (uT != null && !string.IsNullOrEmpty(ut))
				{
					cn.BcB = ut;
				}
			}
			else
			{
				try
				{
					uT = Image.FromFile(((Control)VC).Text);
					ut = Path.GetFileName(((Control)VC).Text);
					cn.BcB = ut;
				}
				catch
				{
					if (uU != null)
					{
						((Control)uU).Visible = false;
						uU.Image = null;
						int num = uu;
						Size clientSize = ((Form)this).ClientSize;
						((Form)this).ClientSize = new Size(num, ((Size)(ref clientSize)).Height);
					}
					uT = null;
					ut = null;
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Us() + ((Control)VC).Text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)VC).Text = string.Empty;
					return null;
				}
			}
			cn.Bca = ((Control)uy).Text;
			Enumerator<Control> enumerator = uS.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Control current = enumerator.Current;
					cn.Bcb.Add(current.Tag as string, current.Text);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<string, A> enumerator2 = us.Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					string current2 = enumerator2.Current;
					if (string.IsNullOrEmpty(((Control)us[current2].Bqx).Text))
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ux(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						return null;
					}
					if (string.IsNullOrEmpty(((Control)us[current2].BqY).Text))
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UY(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						return null;
					}
					if (string.IsNullOrEmpty(((Control)us[current2].Bqy).Text))
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uy(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						return null;
					}
					Cn.A a = default(Cn.A);
					a.BsP = ((Control)us[current2].Bqx).Text;
					a.Bsp = ((Control)us[current2].BqY).Text;
					a.BsQ = ((Control)us[current2].Bqy).Text;
					Cn.A a2 = a;
					cn.BcC.Add(current2, a2);
				}
				return cn;
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			string text;
			Cn cn = A(out text);
			if (cn != null)
			{
				lock (BM.qb)
				{
					new CP(text, cn, BM.Qz, uR, true, uT).A();
					Cn cn2 = new Co(text).A();
					if (cn2 != null)
					{
						CO cO = new CO();
						cO.BcF = cn2;
						cO.Bcf = text;
						BM.A(cn2.BCw, cO);
					}
				}
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UZ() + text;
				bE.A((IWin32Window)(object)this, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uz(), (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else
			{
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && uW != null)
			{
				((System.IDisposable)uW).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0401: Unknown result type (might be due to invalid IL or missing references)
			//IL_0428: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0493: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0511: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_0575: Unknown result type (might be due to invalid IL or missing references)
			//IL_057f: Expected O, but got Unknown
			//IL_058c: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fa: Expected O, but got Unknown
			//IL_0652: Unknown result type (might be due to invalid IL or missing references)
			//IL_0688: Unknown result type (might be due to invalid IL or missing references)
			//IL_0707: Unknown result type (might be due to invalid IL or missing references)
			//IL_072e: Unknown result type (might be due to invalid IL or missing references)
			//IL_076e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0778: Expected O, but got Unknown
			//IL_078f: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e9: Expected O, but got Unknown
			//IL_0931: Unknown result type (might be due to invalid IL or missing references)
			//IL_093b: Expected O, but got Unknown
			//IL_0943: Unknown result type (might be due to invalid IL or missing references)
			//IL_094d: Expected O, but got Unknown
			uw = new ThemedTextBox();
			uX = new Label();
			ux = new ThemedTextBox();
			uY = new Label();
			uy = new ThemedTextBox();
			uZ = new Label();
			uz = new ThemedTextBox();
			VB = new Label();
			VA = new ThemedButton();
			Va = new ThemedButton();
			Vb = new Label();
			VC = new ThemedTextBox();
			Vc = new ThemedButton();
			VD = new ThemedButton();
			Vd = new ab();
			VE = new ColumnHeader();
			Ve = new ColumnHeader();
			VF = new ThemedButton();
			((Control)this).SuspendLayout();
			((Control)uw).Location = new Point(136, 32);
			((Control)uw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uA();
			((Control)uw).Size = new Size(386, 22);
			((Control)uw).TabIndex = 1;
			((Control)uX).AutoSize = true;
			((Control)uX).Location = new Point(6, 35);
			((Control)uX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)uX).Size = new Size(109, 13);
			((Control)uX).TabIndex = 2;
			((Control)uX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ua();
			((Control)ux).Location = new Point(136, 58);
			((Control)ux).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uB();
			((Control)ux).Size = new Size(386, 22);
			((Control)ux).TabIndex = 2;
			((Control)uY).AutoSize = true;
			((Control)uY).Location = new Point(6, 61);
			((Control)uY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)uY).Size = new Size(80, 13);
			((Control)uY).TabIndex = 4;
			((Control)uY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ub();
			((Control)uy).Location = new Point(136, 84);
			((Control)uy).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uC();
			((Control)uy).Size = new Size(386, 22);
			((Control)uy).TabIndex = 3;
			((Control)uZ).AutoSize = true;
			((Control)uZ).Location = new Point(6, 87);
			((Control)uZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)uZ).Size = new Size(101, 13);
			((Control)uZ).TabIndex = 6;
			((Control)uZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uc();
			((Control)uz).Location = new Point(136, 6);
			((Control)uz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jr();
			((Control)uz).Size = new Size(386, 22);
			((Control)uz).TabIndex = 0;
			((Control)VB).AutoSize = true;
			((Control)VB).Location = new Point(6, 9);
			((Control)VB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)VB).Size = new Size(121, 13);
			((Control)VB).TabIndex = 9;
			((Control)VB).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uD();
			((Button)VA).DialogResult = (DialogResult)1;
			((Control)VA).Location = new Point(706, 561);
			((Control)VA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IM();
			((Control)VA).Size = new Size(128, 42);
			((Control)VA).TabIndex = 5;
			((Control)VA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)VA).UseVisualStyleBackColor = true;
			((Button)Va).DialogResult = (DialogResult)2;
			((Control)Va).Location = new Point(844, 561);
			((Control)Va).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IN();
			((Control)Va).Size = new Size(128, 42);
			((Control)Va).TabIndex = 6;
			((Control)Va).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)Va).UseVisualStyleBackColor = true;
			((Control)Vb).AutoSize = true;
			((Control)Vb).Location = new Point(6, 113);
			((Control)Vb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Io();
			((Control)Vb).Size = new Size(117, 13);
			((Control)Vb).TabIndex = 10;
			((Control)Vb).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ud();
			((Control)VC).Location = new Point(135, 110);
			((Control)VC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uE();
			((Control)VC).Size = new Size(194, 22);
			((Control)VC).TabIndex = 4;
			((Control)Vc).Location = new Point(335, 108);
			((Control)Vc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ue();
			((Control)Vc).Size = new Size(81, 25);
			((Control)Vc).TabIndex = 11;
			((Control)Vc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NF();
			((ButtonBase)Vc).UseVisualStyleBackColor = true;
			((Control)Vc).Click += new EventHandler(B);
			((Control)VD).Location = new Point(421, 108);
			((Control)VD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uF();
			((Control)VD).Size = new Size(98, 25);
			((Control)VD).TabIndex = 12;
			((Control)VD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uf();
			((ButtonBase)VD).UseVisualStyleBackColor = true;
			((Control)VD).Click += new EventHandler(b);
			((ListView)Vd).BorderStyle = (BorderStyle)1;
			((ListView)Vd).Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[2] { VE, Ve });
			((ListView)Vd).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)Vd).LabelWrap = false;
			((Control)Vd).Location = new Point(528, 6);
			((ListView)Vd).MultiSelect = false;
			((Control)Vd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uG();
			((Control)Vd).Size = new Size(450, 549);
			((Control)Vd).TabIndex = 13;
			((ListView)Vd).UseCompatibleStateImageBehavior = false;
			((ListView)Vd).View = (View)1;
			VE.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ug();
			VE.Width = 270;
			Ve.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gd();
			Ve.Width = 150;
			((Control)VF).Location = new Point(528, 561);
			((Control)VF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uH();
			((Control)VF).Size = new Size(128, 42);
			((Control)VF).TabIndex = 14;
			((Control)VF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uh();
			((ButtonBase)VF).UseVisualStyleBackColor = true;
			((Control)VF).Click += new EventHandler(a);
			((Form)this).AcceptButton = (IButtonControl)(object)VA;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)Va;
			((Form)this).ClientSize = new Size(984, 611);
			((Control)this).Controls.Add((Control)(object)VF);
			((Control)this).Controls.Add((Control)(object)Vd);
			((Control)this).Controls.Add((Control)(object)VD);
			((Control)this).Controls.Add((Control)(object)Vc);
			((Control)this).Controls.Add((Control)(object)VC);
			((Control)this).Controls.Add((Control)(object)Vb);
			((Control)this).Controls.Add((Control)(object)Va);
			((Control)this).Controls.Add((Control)(object)VA);
			((Control)this).Controls.Add((Control)(object)VB);
			((Control)this).Controls.Add((Control)(object)uz);
			((Control)this).Controls.Add((Control)(object)uy);
			((Control)this).Controls.Add((Control)(object)uZ);
			((Control)this).Controls.Add((Control)(object)ux);
			((Control)this).Controls.Add((Control)(object)uY);
			((Control)this).Controls.Add((Control)(object)uw);
			((Control)this).Controls.Add((Control)(object)uX);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uI();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ui();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal enum bQ
	{
		aCR,
		aCr
	}
	internal enum bq
	{
		aCS,
		aCs,
		aCT
	}
}
