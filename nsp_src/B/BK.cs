using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using NSP.SettingsFramework;
using NSP.UnitConversion;
using NSP.UserInterface;
using a;
using b;

namespace B
{
	internal class BK : Form
	{
		private double pK;

		private string pk;

		private int pL;

		private int pl;

		private int pM;

		private int pm;

		private List<Setting.ListItems.A> pN;

		private IContainer pn;

		private ThemedButton pO;

		private ThemedButton po;

		private GroupBox pP;

		private ThemedComboBox pp;

		private Label pQ;

		private Label pq;

		private ThemedTextBox pR;

		private Label pr;

		private Label pS;

		private Label ps;

		private Label pT;

		private aP pt;

		private aP pU;

		private Label pu;

		private ThemedComboBox pV;

		internal BK(int P_0, int P_1, int P_2, int P_3, int P_4, List<Setting.ListItems.A> P_5)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			D();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)pP).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val2 = item2;
				if (val2 is Label || val2 is CheckBox)
				{
					val2.ForeColor = BM.te;
				}
			}
			((Control)pR).BackColor = BM.to;
			((Control)pR).ForeColor = BM.te;
			pN = P_5;
			if (pN != null && pN.Count != 0)
			{
				int num = 0;
				string[] array = new string[pN.Count];
				Graphics val3 = ((Control)this).CreateGraphics();
				try
				{
					for (int i = 0; i < pN.Count; i++)
					{
						array[i] = pN[i].bBV;
						Size val4 = TextRenderer.MeasureText((IDeviceContext)(object)val3, array[i], ((Control)pp).Font);
						num = Math.Max(((Size)(ref val4)).Width, num);
					}
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
				ObjectCollection items = ((ComboBox)pp).Items;
				object[] array2 = array;
				items.AddRange(array2);
				if (num > ((ComboBox)pp).DropDownWidth - 130)
				{
					((ComboBox)pp).DropDownWidth = num + 130;
				}
				if (((ComboBox)pp).Items.Count > 20)
				{
					((ComboBox)pp).DropDownHeight = 360;
				}
			}
			((Control)pS).Text = bS.A(P_2, P_1, false, 0);
			pm = P_1;
			pl = P_3;
			pM = P_4;
			((Control)pQ).Text = bS.a(pl, P_1, -1);
			((Control)pq).Text = bS.a(pM, P_1, -1);
			if (pN != null && pN.Count != 0)
			{
				((Control)pp).Text = bS.a(P_0, P_1, -1);
				Enumerator<Setting.ListItems.A> enumerator2 = pN.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Setting.ListItems.A current = enumerator2.Current;
						if (current.bBv == P_0)
						{
							((Control)pp).Text = current.bBV;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				((Control)pp).Visible = true;
				((Control)pp).Focus();
				((ComboBox)pp).Select(((Control)pp).Text.Length, 0);
				((Control)pR).Visible = false;
			}
			else
			{
				((Control)pR).Visible = true;
				((Control)pR).Text = bS.a(P_0, P_1, -1);
				((Control)pR).Focus();
				((TextBoxBase)pR).Select(((Control)pR).Text.Length, 0);
				((Control)pp).Visible = false;
			}
		}

		[SpecialName]
		internal double A()
		{
			return pK;
		}

		[SpecialName]
		internal string a()
		{
			return pk;
		}

		[SpecialName]
		internal int B()
		{
			return pL;
		}

		[SpecialName]
		internal bool b()
		{
			return ((CheckBox)pU).Checked;
		}

		[SpecialName]
		internal void A(bool P_0)
		{
			((CheckBox)pU).Checked = P_0;
		}

		[SpecialName]
		internal bool C()
		{
			return ((CheckBox)pt).Checked;
		}

		[SpecialName]
		internal void a(bool P_0)
		{
			((CheckBox)pt).Checked = P_0;
		}

		[SpecialName]
		internal int c()
		{
			return ((ListControl)pV).SelectedIndex;
		}

		[SpecialName]
		internal void A(int P_0)
		{
			((ListControl)pV).SelectedIndex = P_0;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			try
			{
				if (pN != null && pN.Count != 0)
				{
					Enumerator<Setting.ListItems.A> enumerator = pN.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Setting.ListItems.A current = enumerator.Current;
							if (((Control)pp).Text == current.bBV)
							{
								pk = current.bBV;
								pL = current.bBv;
								return;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					int num = bS.A(((Control)pp).Text, pm);
					if (num < pl || num > pM)
					{
						throw new System.Exception();
					}
					pK = double.Parse(((Control)pp).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture);
				}
				else
				{
					string text = ((Control)pR).Text;
					int num2 = bS.A(text, pm);
					if (num2 < pl || num2 > pM)
					{
						throw new System.Exception();
					}
					if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI()))
					{
						text.Remove(0, 2);
						pK = Convert.ToInt32(text, 16);
					}
					else
					{
						pK = double.Parse(text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture);
					}
				}
			}
			catch (System.Exception)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ll(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				if (pN != null && pN.Count != 0)
				{
					((ComboBox)pp).SelectAll();
				}
				else
				{
					((TextBoxBase)pR).SelectAll();
				}
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && pn != null)
			{
				((System.IDisposable)pn).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void D()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Expected O, but got Unknown
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Expected O, but got Unknown
			//IL_0393: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0407: Expected O, but got Unknown
			//IL_0411: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Expected O, but got Unknown
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04df: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e9: Expected O, but got Unknown
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0517: Unknown result type (might be due to invalid IL or missing references)
			//IL_055d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0567: Expected O, but got Unknown
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_0598: Unknown result type (might be due to invalid IL or missing references)
			//IL_05de: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e8: Expected O, but got Unknown
			//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0616: Unknown result type (might be due to invalid IL or missing references)
			//IL_065b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0665: Expected O, but got Unknown
			//IL_066f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0693: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e2: Expected O, but got Unknown
			//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0710: Unknown result type (might be due to invalid IL or missing references)
			//IL_0761: Unknown result type (might be due to invalid IL or missing references)
			//IL_076b: Expected O, but got Unknown
			//IL_0775: Unknown result type (might be due to invalid IL or missing references)
			//IL_0799: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f4: Expected O, but got Unknown
			//IL_0801: Unknown result type (might be due to invalid IL or missing references)
			//IL_0828: Unknown result type (might be due to invalid IL or missing references)
			//IL_087a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0884: Expected O, but got Unknown
			//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_091f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0947: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e0: Expected O, but got Unknown
			//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a32: Expected O, but got Unknown
			pO = new ThemedButton();
			po = new ThemedButton();
			pP = new GroupBox();
			pp = new ThemedComboBox();
			pQ = new Label();
			pq = new Label();
			pR = new ThemedTextBox();
			pr = new Label();
			pS = new Label();
			ps = new Label();
			pT = new Label();
			pt = new aP();
			pU = new aP();
			pu = new Label();
			pV = new ThemedComboBox();
			((Control)pP).SuspendLayout();
			((Control)this).SuspendLayout();
			((Button)pO).DialogResult = (DialogResult)1;
			((Control)pO).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pO).Location = new Point(217, 210);
			((Control)pO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)pO).Size = new Size(100, 30);
			((Control)pO).TabIndex = 2;
			((Control)pO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)pO).UseVisualStyleBackColor = true;
			((Button)po).DialogResult = (DialogResult)2;
			((Control)po).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)po).Location = new Point(331, 210);
			((Control)po).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)po).Size = new Size(100, 30);
			((Control)po).TabIndex = 3;
			((Control)po).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)po).UseVisualStyleBackColor = true;
			((Control)pP).Controls.Add((Control)(object)pp);
			((Control)pP).Controls.Add((Control)(object)pQ);
			((Control)pP).Controls.Add((Control)(object)pq);
			((Control)pP).Controls.Add((Control)(object)pR);
			((Control)pP).Controls.Add((Control)(object)pr);
			((Control)pP).Controls.Add((Control)(object)pS);
			((Control)pP).Controls.Add((Control)(object)ps);
			((Control)pP).Controls.Add((Control)(object)pT);
			((Control)pP).Location = new Point(16, 60);
			((Control)pP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KF();
			((Control)pP).Size = new Size(415, 104);
			((Control)pP).TabIndex = 2;
			pP.TabStop = false;
			((ComboBox)pp).DrawMode = (DrawMode)1;
			((Control)pp).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListControl)pp).FormattingEnabled = true;
			((Control)pp).Location = new Point(114, 17);
			((ComboBox)pp).MaxDropDownItems = 100;
			((Control)pp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kg();
			((Control)pp).Size = new Size(180, 23);
			((Control)pp).TabIndex = 0;
			((Control)pQ).AutoSize = true;
			((Control)pQ).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pQ).Location = new Point(83, 72);
			((Control)pQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KH();
			((Control)pQ).Size = new Size(65, 13);
			((Control)pQ).TabIndex = 13;
			((Control)pQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lM();
			((Control)pq).AutoSize = true;
			((Control)pq).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pq).Location = new Point(83, 46);
			((Control)pq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KI();
			((Control)pq).Size = new Size(66, 13);
			((Control)pq).TabIndex = 12;
			((Control)pq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lm();
			((Control)pR).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pR).Location = new Point(114, 17);
			((Control)pR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KJ();
			((Control)pR).Size = new Size(180, 22);
			((Control)pR).TabIndex = 0;
			((Control)pr).AutoSize = true;
			((Control)pr).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pr).Location = new Point(16, 72);
			((Control)pr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)pr).Size = new Size(30, 13);
			((Control)pr).TabIndex = 10;
			((Control)pr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lN();
			((Control)pS).AutoSize = true;
			((Control)pS).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pS).Location = new Point(300, 20);
			((Control)pS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kj();
			((Control)pS).Size = new Size(40, 13);
			((Control)pS).TabIndex = 9;
			((Control)pS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KK();
			((Control)ps).AutoSize = true;
			((Control)ps).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)ps).Location = new Point(16, 46);
			((Control)ps).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)ps).Size = new Size(31, 13);
			((Control)ps).TabIndex = 8;
			((Control)ps).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ln();
			((Control)pT).AutoSize = true;
			((Control)pT).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pT).Location = new Point(16, 20);
			((Control)pT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)pT).Size = new Size(93, 13);
			((Control)pT).TabIndex = 7;
			((Control)pT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lO();
			((Control)pt).AutoSize = true;
			((Control)pt).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pt).Location = new Point(16, 39);
			((Control)pt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lo();
			((Control)pt).Size = new Size(55, 17);
			((Control)pt).TabIndex = 1;
			((Control)pt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lP();
			((ButtonBase)pt).UseVisualStyleBackColor = true;
			((Control)pU).AutoSize = true;
			((Control)pU).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pU).Location = new Point(16, 12);
			((Control)pU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lp();
			((Control)pU).Size = new Size(85, 17);
			((Control)pU).TabIndex = 0;
			((Control)pU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lQ();
			((ButtonBase)pU).UseVisualStyleBackColor = true;
			((Control)pu).AutoSize = true;
			((Control)pu).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pu).Location = new Point(13, 177);
			((Control)pu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)pu).Size = new Size(138, 13);
			((Control)pu).TabIndex = 11;
			((Control)pu).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lq();
			((ComboBox)pV).DrawMode = (DrawMode)1;
			((ComboBox)pV).DropDownStyle = (ComboBoxStyle)2;
			((Control)pV).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListControl)pV).FormattingEnabled = true;
			((ComboBox)pV).Items.AddRange(new object[3]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lR(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lr(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lS()
			});
			((Control)pV).Location = new Point(154, 174);
			((Control)pV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ls();
			((Control)pV).Size = new Size(121, 23);
			((Control)pV).TabIndex = 3;
			((Form)this).AcceptButton = (IButtonControl)(object)pO;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)po;
			((Form)this).ClientSize = new Size(447, 249);
			((Control)this).Controls.Add((Control)(object)pV);
			((Control)this).Controls.Add((Control)(object)pu);
			((Control)this).Controls.Add((Control)(object)pU);
			((Control)this).Controls.Add((Control)(object)pt);
			((Control)this).Controls.Add((Control)(object)pP);
			((Control)this).Controls.Add((Control)(object)po);
			((Control)this).Controls.Add((Control)(object)pO);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lT();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lt();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)pP).ResumeLayout(false);
			((Control)pP).PerformLayout();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Bk : Form
	{
		private const int pv = 3;

		private const int pW = 3;

		private const int pw = 3;

		internal Color pX = Color.Black;

		internal Color px = Color.White;

		private IContainer pY;

		private ab py;

		private ColumnHeader pZ;

		private ColumnHeader pz;

		private ImageList QA;

		private ab Qa;

		private ColumnHeader QB;

		private ColumnHeader Qb;

		internal Bk()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			a();
			((ListView)py).DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(A);
			((ListView)py).DrawItem += new DrawListViewItemEventHandler(A);
			((ListView)py).DrawSubItem += new DrawListViewSubItemEventHandler(A);
			((ListView)Qa).DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(A);
			((ListView)Qa).DrawItem += new DrawListViewItemEventHandler(A);
			((ListView)Qa).DrawSubItem += new DrawListViewSubItemEventHandler(A);
		}

		private void A(object P_0, EventArgs P_1)
		{
			A((ListView)(object)py, 20);
			A((ListView)(object)Qa, 20);
			A();
			_ = new string[2];
			ListViewItem obj = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lU());
			obj.UseItemStyleForSubItems = false;
			obj.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lu());
			ListViewItem obj2 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lV());
			obj2.UseItemStyleForSubItems = false;
			obj2.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lv());
			ListViewItem obj3 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lW());
			obj3.UseItemStyleForSubItems = false;
			obj3.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lw());
			ListViewItem obj4 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lX());
			obj4.UseItemStyleForSubItems = false;
			obj4.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lx());
			ListViewItem obj5 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lY());
			obj5.UseItemStyleForSubItems = false;
			obj5.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ly());
			ListViewItem obj6 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lZ());
			obj6.UseItemStyleForSubItems = false;
			obj6.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lz());
			ListViewItem obj7 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MA());
			obj7.UseItemStyleForSubItems = false;
			obj7.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ma());
			ListViewItem obj8 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MB());
			obj8.UseItemStyleForSubItems = false;
			obj8.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mb());
			ListViewItem obj9 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MC());
			obj9.UseItemStyleForSubItems = false;
			obj9.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mc());
			ListViewItem obj10 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MD());
			obj10.UseItemStyleForSubItems = false;
			obj10.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Md());
			ListViewItem obj11 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ME());
			obj11.UseItemStyleForSubItems = false;
			obj11.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Me());
			ListViewItem obj12 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MF());
			obj12.UseItemStyleForSubItems = false;
			obj12.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mf());
			ListViewItem obj13 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MG());
			obj13.UseItemStyleForSubItems = false;
			obj13.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mg());
			ListViewItem obj14 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MH());
			obj14.UseItemStyleForSubItems = false;
			obj14.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mh());
			ListViewItem obj15 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MI());
			obj15.UseItemStyleForSubItems = false;
			obj15.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mi());
			ListViewItem obj16 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MJ());
			obj16.UseItemStyleForSubItems = false;
			obj16.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mj());
			ListViewItem obj17 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MK());
			obj17.UseItemStyleForSubItems = false;
			obj17.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mk());
			ListViewItem obj18 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ML());
			obj18.UseItemStyleForSubItems = false;
			obj18.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ml());
			ListViewItem obj19 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MM());
			obj19.UseItemStyleForSubItems = false;
			obj19.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mm());
			ListViewItem obj20 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MN());
			obj20.UseItemStyleForSubItems = false;
			obj20.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mn());
			ListViewItem obj21 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MO());
			obj21.UseItemStyleForSubItems = false;
			obj21.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mo());
			ListViewItem obj22 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MP());
			obj22.UseItemStyleForSubItems = false;
			obj22.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mp());
			ListViewItem obj23 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MQ());
			obj23.UseItemStyleForSubItems = false;
			obj23.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mq());
			ListViewItem obj24 = ((ListView)py).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MR());
			obj24.UseItemStyleForSubItems = false;
			obj24.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mr());
			ListViewItem obj25 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MS());
			obj25.UseItemStyleForSubItems = false;
			obj25.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ms());
			ListViewItem obj26 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MT());
			obj26.UseItemStyleForSubItems = false;
			obj26.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mt());
			ListViewItem obj27 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MU());
			obj27.UseItemStyleForSubItems = false;
			obj27.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mu());
			ListViewItem obj28 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MV());
			obj28.UseItemStyleForSubItems = false;
			obj28.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mv());
			ListViewItem obj29 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MW());
			obj29.UseItemStyleForSubItems = false;
			obj29.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mw());
			ListViewItem obj30 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MX());
			obj30.UseItemStyleForSubItems = false;
			obj30.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mx());
			ListViewItem obj31 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MY());
			obj31.UseItemStyleForSubItems = false;
			obj31.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.My());
			ListViewItem obj32 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MZ());
			obj32.UseItemStyleForSubItems = false;
			obj32.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mz());
			ListViewItem obj33 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mA());
			obj33.UseItemStyleForSubItems = false;
			obj33.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			ListViewItem obj34 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ma());
			obj34.UseItemStyleForSubItems = false;
			obj34.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mB());
			ListViewItem obj35 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mb());
			obj35.UseItemStyleForSubItems = false;
			obj35.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			ListViewItem obj36 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mC());
			obj36.UseItemStyleForSubItems = false;
			obj36.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mc());
			ListViewItem obj37 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mD());
			obj37.UseItemStyleForSubItems = false;
			obj37.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			ListViewItem obj38 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md());
			obj38.UseItemStyleForSubItems = false;
			obj38.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mE());
			ListViewItem obj39 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.me());
			obj39.UseItemStyleForSubItems = false;
			obj39.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mF());
			ListViewItem obj40 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bO());
			obj40.UseItemStyleForSubItems = false;
			obj40.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mf());
			ListViewItem obj41 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jZ());
			obj41.UseItemStyleForSubItems = false;
			obj41.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mG());
			ListViewItem obj42 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mg());
			obj42.UseItemStyleForSubItems = false;
			obj42.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mH());
			ListViewItem obj43 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mh());
			obj43.UseItemStyleForSubItems = false;
			obj43.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mI());
			ListViewItem obj44 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mi());
			obj44.UseItemStyleForSubItems = false;
			obj44.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mJ());
			ListViewItem obj45 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mj());
			obj45.UseItemStyleForSubItems = false;
			obj45.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mK());
			ListViewItem obj46 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di());
			obj46.UseItemStyleForSubItems = false;
			obj46.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mk());
			ListViewItem obj47 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mL());
			obj47.UseItemStyleForSubItems = false;
			obj47.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ml());
			ListViewItem obj48 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mM());
			obj48.UseItemStyleForSubItems = false;
			obj48.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mm());
			ListViewItem obj49 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mN());
			obj49.UseItemStyleForSubItems = false;
			obj49.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mn());
			ListViewItem obj50 = ((ListView)Qa).Items.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mO());
			obj50.UseItemStyleForSubItems = false;
			obj50.SubItems.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mo());
		}

		internal void A()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).BackColor = BM.td;
			((Control)py).BackColor = BM.tH;
			((Control)py).ForeColor = BM.te;
			((Control)Qa).BackColor = BM.tH;
			((Control)Qa).ForeColor = BM.te;
			_ = Color.Black;
			_ = Color.White;
			((Control)this).Refresh();
		}

		private void A(ListView P_0, int P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			ImageList val = new ImageList();
			val.ImageSize = new Size(1, P_1);
			P_0.SmallImageList = val;
		}

		private Size A(string P_0, Font P_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			SizeF val = Graphics.FromImage((Image)new Bitmap(1, 1)).MeasureString(P_0, P_1);
			return ((SizeF)(ref val)).ToSize();
		}

		private Size A(Size P_0)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			int num = ((Size)(ref P_0)).Width + 6;
			int num2 = ((Size)(ref P_0)).Height + 6;
			return new Size(num, num2);
		}

		private Bitmap A(string[] P_0, Font P_1)
		{
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0571: Unknown result type (might be due to invalid IL or missing references)
			//IL_0576: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ce: Expected O, but got Unknown
			//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Expected O, but got Unknown
			//IL_0604: Unknown result type (might be due to invalid IL or missing references)
			//IL_0609: Unknown result type (might be due to invalid IL or missing references)
			//IL_059b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b2: Expected O, but got Unknown
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Expected O, but got Unknown
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected O, but got Unknown
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0354: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Expected O, but got Unknown
			//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d0: Expected O, but got Unknown
			//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Expected O, but got Unknown
			//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Expected O, but got Unknown
			//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Unknown result type (might be due to invalid IL or missing references)
			//IL_053c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Unknown result type (might be due to invalid IL or missing references)
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a9: Expected O, but got Unknown
			int num = 0;
			int num2 = 0;
			List<Size> val = new List<Size>();
			foreach (string text in P_0)
			{
				Size val2 = ((!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MT())) ? A(text, P_1) : A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP(), P_1));
				Size val3 = A(val2);
				val.Add(val3);
				num = ((!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MT())) ? (num + ((Size)(ref val3)).Width) : (num + ((Size)(ref val3)).Width * 4));
				if (((Size)(ref val3)).Height > num2)
				{
					num2 = ((Size)(ref val3)).Height;
				}
			}
			Bitmap val4 = new Bitmap(num + 3 * (P_0.Length - 1) + 5, num2);
			Graphics val5 = Graphics.FromImage((Image)(object)val4);
			try
			{
				val5.SmoothingMode = (SmoothingMode)2;
				StringFormat val6 = new StringFormat();
				val6.LineAlignment = (StringAlignment)1;
				val6.Alignment = (StringAlignment)1;
				Pen val7 = new Pen(pX, 1f);
				try
				{
					int num3 = 5;
					Rectangle val9 = default(Rectangle);
					Rectangle val11 = default(Rectangle);
					Rectangle val12 = default(Rectangle);
					Rectangle val13 = default(Rectangle);
					Rectangle val14 = default(Rectangle);
					Rectangle val15 = default(Rectangle);
					for (int j = 0; j < P_0.Length; j++)
					{
						Size val8;
						if (P_0[j].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mp()))
						{
							int num4 = num3;
							val8 = val[j];
							((Rectangle)(ref val9))._002Ector(num4, 1, ((Size)(ref val8)).Width - 1, num2 - 1);
							val5.FillRectangle((Brush)new SolidBrush(BM.tH), val9);
							val5.DrawString(P_0[j].TrimStart(new char[1] { '&' }), P_1, (Brush)new SolidBrush(BM.te), RectangleF.op_Implicit(val9), val6);
							int num5 = num3;
							val8 = val[j];
							num3 = num5 + (((Size)(ref val8)).Width + 3);
						}
						else if (P_0[j].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MT()))
						{
							PointF[] array = (PointF[])(object)new PointF[3];
							Size val10 = A(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP(), P_1));
							((Rectangle)(ref val11))._002Ector(num3, 1, ((Size)(ref val10)).Width - 1, num2 - 2);
							if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
							{
								val5.FillPath((Brush)new SolidBrush(px), A(val11, 3));
							}
							else
							{
								val5.DrawPath(new Pen(Color.Black), A(val11, 3));
							}
							array[0] = new PointF((float)(num3 + ((Size)(ref val10)).Width / 2), (float)(num2 / 2 - 3));
							array[1] = new PointF((float)(num3 + ((Size)(ref val10)).Width / 2 - 3), (float)(num2 / 2 + 3));
							array[2] = new PointF((float)(num3 + ((Size)(ref val10)).Width / 2 + 3), (float)(num2 / 2 + 3));
							val5.FillPolygon(Brushes.Black, array);
							((Rectangle)(ref val12))._002Ector(num3 + ((Size)(ref val10)).Width, 1, ((Size)(ref val10)).Width - 1, num2 - 2);
							if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
							{
								val5.FillPath((Brush)new SolidBrush(px), A(val12, 3));
							}
							else
							{
								val5.DrawPath(new Pen(Color.Black), A(val12, 3));
							}
							array[0] = new PointF((float)(num3 + ((Size)(ref val10)).Width + ((Size)(ref val10)).Width / 2 - 3), (float)(num2 / 2));
							array[1] = new PointF((float)(num3 + ((Size)(ref val10)).Width + ((Size)(ref val10)).Width / 2 + 3), (float)(num2 / 2 + 3));
							array[2] = new PointF((float)(num3 + ((Size)(ref val10)).Width + ((Size)(ref val10)).Width / 2 + 3), (float)(num2 / 2 - 3));
							val5.FillPolygon(Brushes.Black, array);
							((Rectangle)(ref val13))._002Ector(num3 + ((Size)(ref val10)).Width * 2, 1, ((Size)(ref val10)).Width - 1, num2 - 2);
							if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
							{
								val5.FillPath((Brush)new SolidBrush(px), A(val13, 3));
							}
							else
							{
								val5.DrawPath(new Pen(Color.Black), A(val13, 3));
							}
							array[0] = new PointF((float)(num3 + ((Size)(ref val10)).Width * 2 + ((Size)(ref val10)).Width / 2 + 3), (float)(num2 / 2));
							array[1] = new PointF((float)(num3 + ((Size)(ref val10)).Width * 2 + ((Size)(ref val10)).Width / 2 - 3), (float)(num2 / 2 + 3));
							array[2] = new PointF((float)(num3 + ((Size)(ref val10)).Width * 2 + ((Size)(ref val10)).Width / 2 - 3), (float)(num2 / 2 - 3));
							val5.FillPolygon(Brushes.Black, array);
							((Rectangle)(ref val14))._002Ector(num3 + ((Size)(ref val10)).Width * 3, 1, ((Size)(ref val10)).Width - 1, num2 - 2);
							if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
							{
								val5.FillPath((Brush)new SolidBrush(px), A(val14, 3));
							}
							else
							{
								val5.DrawPath(new Pen(Color.Black), A(val14, 3));
							}
							array[0] = new PointF((float)(num3 + ((Size)(ref val10)).Width * 3 + ((Size)(ref val10)).Width / 2), (float)(num2 / 2 + 3));
							array[1] = new PointF((float)(num3 + ((Size)(ref val10)).Width * 3 + ((Size)(ref val10)).Width / 2 - 3), (float)(num2 / 2 - 3));
							array[2] = new PointF((float)(num3 + ((Size)(ref val10)).Width * 3 + ((Size)(ref val10)).Width / 2 + 3), (float)(num2 / 2 - 3));
							val5.FillPolygon(Brushes.Black, array);
							num3 += ((Size)(ref val10)).Width * 4 + 3;
						}
						else
						{
							int num6 = num3;
							val8 = val[j];
							((Rectangle)(ref val15))._002Ector(num6, 1, ((Size)(ref val8)).Width - 1, num2 - 2);
							if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
							{
								val5.FillPath((Brush)new SolidBrush(px), A(val15, 3));
							}
							else
							{
								val5.FillPath((Brush)new SolidBrush(px), A(val15, 3));
								val5.DrawPath(val7, A(val15, 3));
							}
							val5.DrawString(P_0[j], P_1, (Brush)new SolidBrush(pX), RectangleF.op_Implicit(val15), val6);
							int num7 = num3;
							val8 = val[j];
							num3 = num7 + (((Size)(ref val8)).Width + 3);
						}
					}
					return val4;
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
		}

		private static GraphicsPath A(Rectangle P_0, int P_1)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			int num = P_1 * 2;
			Size val = default(Size);
			((Size)(ref val))._002Ector(num, num);
			Rectangle val2 = default(Rectangle);
			((Rectangle)(ref val2))._002Ector(((Rectangle)(ref P_0)).Location, val);
			GraphicsPath val3 = new GraphicsPath();
			if (P_1 == 0)
			{
				val3.AddRectangle(P_0);
				return val3;
			}
			val3.AddArc(val2, 180f, 90f);
			((Rectangle)(ref val2)).X = ((Rectangle)(ref P_0)).Right - num;
			val3.AddArc(val2, 270f, 90f);
			((Rectangle)(ref val2)).Y = ((Rectangle)(ref P_0)).Bottom - num;
			val3.AddArc(val2, 0f, 90f);
			((Rectangle)(ref val2)).X = ((Rectangle)(ref P_0)).Left;
			val3.AddArc(val2, 90f, 90f);
			val3.CloseFigure();
			return val3;
		}

		private void A(object P_0, DrawListViewColumnHeaderEventArgs P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Invalid comparison between Unknown and I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Invalid comparison between Unknown and I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			StringFormat val = new StringFormat();
			try
			{
				HorizontalAlignment textAlign = P_1.Header.TextAlign;
				if ((int)textAlign != 1)
				{
					if ((int)textAlign == 2)
					{
						val.Alignment = (StringAlignment)1;
					}
				}
				else
				{
					val.Alignment = (StringAlignment)2;
				}
				val.LineAlignment = (StringAlignment)0;
				Rectangle bounds = P_1.Bounds;
				int num = ((Rectangle)(ref bounds)).Left - 1;
				bounds = P_1.Bounds;
				int num2 = ((Rectangle)(ref bounds)).Top - 1;
				bounds = P_1.Bounds;
				int num3 = ((Rectangle)(ref bounds)).Width - 1;
				bounds = P_1.Bounds;
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(num, num2, num3, ((Rectangle)(ref bounds)).Height - 1);
				P_1.Graphics.FillRectangle((Brush)new SolidBrush(BM.td), P_1.Bounds);
				P_1.Graphics.DrawRectangle(new Pen(BM.te), val2);
				bounds = P_1.Bounds;
				int num4 = ((Rectangle)(ref bounds)).Left + 10;
				bounds = P_1.Bounds;
				int top = ((Rectangle)(ref bounds)).Top;
				bounds = P_1.Bounds;
				int num5 = ((Rectangle)(ref bounds)).Width - 10;
				bounds = P_1.Bounds;
				Rectangle val3 = default(Rectangle);
				((Rectangle)(ref val3))._002Ector(num4, top, num5, ((Rectangle)(ref bounds)).Height);
				Font val4 = new Font(((Control)this).Font.FontFamily, 9f);
				try
				{
					P_1.Graphics.DrawString(P_1.Header.Text, val4, (Brush)new SolidBrush(BM.te), RectangleF.op_Implicit(val3), val);
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}

		private void A(object P_0, DrawListViewSubItemEventArgs P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Invalid comparison between Unknown and I4
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected O, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			StringFormat val = new StringFormat();
			try
			{
				val.LineAlignment = (StringAlignment)1;
				HorizontalAlignment textAlign = P_1.Header.TextAlign;
				if ((int)textAlign != 1)
				{
					if ((int)textAlign == 2)
					{
						val.Alignment = (StringAlignment)1;
					}
				}
				else
				{
					val.Alignment = (StringAlignment)2;
				}
				Rectangle bounds;
				if (P_1.ColumnIndex == 0)
				{
					Font val2 = new Font(((Control)this).Font.FontFamily, 8f, (FontStyle)1);
					try
					{
						Graphics graphics = P_1.Graphics;
						Bitmap obj = A(P_1.SubItem.Text.Split('$', (StringSplitOptions)0), val2);
						bounds = P_1.Bounds;
						int left = ((Rectangle)(ref bounds)).Left;
						bounds = P_1.Bounds;
						graphics.DrawImage((Image)(object)obj, left, ((Rectangle)(ref bounds)).Top);
						return;
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
				}
				bounds = P_1.Bounds;
				int num = ((Rectangle)(ref bounds)).Left + 10;
				bounds = P_1.Bounds;
				int top = ((Rectangle)(ref bounds)).Top;
				bounds = P_1.Bounds;
				int num2 = ((Rectangle)(ref bounds)).Width - 10;
				bounds = P_1.Bounds;
				Rectangle val3 = default(Rectangle);
				((Rectangle)(ref val3))._002Ector(num, top, num2, ((Rectangle)(ref bounds)).Height);
				Font val4 = new Font(((Control)this).Font.FontFamily, 8f);
				try
				{
					P_1.Graphics.DrawString(P_1.SubItem.Text, val4, (Brush)new SolidBrush(BM.te), RectangleF.op_Implicit(val3), val);
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}

		private void A(object P_0, DrawListViewItemEventArgs P_1)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Invalid comparison between Unknown and I4
			if ((int)((ListView)py).View != 1)
			{
				P_1.DrawText();
			}
		}

		private void A(object P_0, ColumnWidthChangingEventArgs P_1)
		{
			((CancelEventArgs)P_1).Cancel = true;
			ab ab = P_0 as ab;
			P_1.NewWidth = ((ListView)ab).Columns[P_1.ColumnIndex].Width;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && pY != null)
			{
				((System.IDisposable)pY).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Expected O, but got Unknown
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Expected O, but got Unknown
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Expected O, but got Unknown
			pY = (IContainer)new Container();
			QA = new ImageList(pY);
			Qa = new ab();
			QB = new ColumnHeader();
			Qb = new ColumnHeader();
			py = new ab();
			pZ = new ColumnHeader();
			pz = new ColumnHeader();
			((Control)this).SuspendLayout();
			QA.ColorDepth = (ColorDepth)8;
			QA.ImageSize = new Size(16, 16);
			QA.TransparentColor = Color.Transparent;
			((ListView)Qa).Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[2] { QB, Qb });
			((Control)Qa).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((ListView)Qa).FullRowSelect = true;
			((ListView)Qa).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)Qa).HideSelection = false;
			((Control)Qa).Location = new Point(488, 12);
			((Control)Qa).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mQ();
			((ListView)Qa).OwnerDraw = true;
			((ListView)Qa).Scrollable = false;
			((Control)Qa).Size = new Size(470, 638);
			((Control)Qa).TabIndex = 2;
			((ListView)Qa).UseCompatibleStateImageBehavior = false;
			((ListView)Qa).View = (View)1;
			((ListView)Qa).ColumnWidthChanging += new ColumnWidthChangingEventHandler(A);
			QB.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mq();
			QB.Width = 200;
			Qb.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mR();
			Qb.Width = 400;
			((ListView)py).Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[2] { pZ, pz });
			((Control)py).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((ListView)py).FullRowSelect = true;
			((ListView)py).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)py).HideSelection = false;
			((Control)py).Location = new Point(12, 12);
			((Control)py).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mr();
			((ListView)py).OwnerDraw = true;
			((ListView)py).Scrollable = false;
			((Control)py).Size = new Size(470, 638);
			((Control)py).TabIndex = 1;
			((ListView)py).UseCompatibleStateImageBehavior = false;
			((ListView)py).View = (View)1;
			((ListView)py).ColumnWidthChanging += new ColumnWidthChangingEventHandler(A);
			pZ.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mq();
			pZ.Width = 200;
			pz.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mR();
			pz.Width = 278;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(968, 661);
			((Control)this).Controls.Add((Control)(object)Qa);
			((Control)this).Controls.Add((Control)(object)py);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mS();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)0;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ms();
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
		}
	}
}
namespace b
{
	internal class bK
	{
		internal class A
		{
			internal int BRX;

			internal double BRx;

			internal string BRY;

			internal string BRy;

			internal string BRZ;

			internal string BRz;

			internal A(int P_0, double P_1, string P_2)
			{
				BRX = P_0;
				BRx = P_1;
				BRY = P_2;
				BRy = P_2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acw();
				BRZ = P_2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acX();
				BRz = P_2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acx();
			}

			internal A(int P_0, double P_1, string P_2, string P_3, string P_4, string P_5)
			{
				BRX = P_0;
				BRx = P_1;
				BRY = P_2;
				BRy = P_3;
				BRZ = P_4;
				BRz = P_5;
			}
		}

		internal UnitType abq;

		internal UnitsGroup abR;

		internal int abr;

		internal string abS;

		internal string abs;

		internal string abT;

		internal string abt;

		internal string abU;

		internal int abu = 100;

		internal int abV = 10;

		internal int abv = 1;

		internal int abW;

		internal List<A> abw = new List<A>(2);

		internal bK(UnitType P_0, UnitsGroup P_1, int P_2, string P_3, string P_4)
		{
			abq = P_0;
			abR = P_1;
			abr = P_2;
			abS = P_3;
			abs = P_4;
			abT = P_4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acw();
			abt = P_4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acX();
			abU = P_4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acx();
		}

		internal bK(UnitType P_0, UnitsGroup P_1, int P_2, string P_3, string P_4, string P_5, string P_6, string P_7)
		{
			abq = P_0;
			abR = P_1;
			abr = P_2;
			abS = P_3;
			abs = P_4;
			abT = P_5;
			abt = P_6;
			abU = P_7;
		}
	}
	internal enum bk
	{
		abX,
		abx,
		abY,
		aby,
		abZ,
		abz
	}
}
