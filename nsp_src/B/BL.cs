using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;

namespace B
{
	internal class BL : Form
	{
		private const int QC = 5;

		private List<Setting> Qc;

		private List<int> QD = new List<int>();

		private List<int> Qd = new List<int>();

		private IContainer QE;

		private ThemedButton Qe;

		private ThemedButton QF;

		private Label Qf;

		private Label QG;

		private Label Qg;

		internal BL()
		{
			b();
		}

		internal BL(List<Setting> P_0, List<int> P_1, List<int> P_2)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			b();
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
			Qc = P_0;
			Enumerator<int> enumerator2 = P_1.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current = enumerator2.Current;
					QD.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			enumerator2 = P_2.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current2 = enumerator2.Current;
					Qd.Add(current2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			A();
		}

		private void A()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Expected O, but got Unknown
			//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			List<string> val = new List<string>();
			int num = 0;
			Enumerator<Setting> enumerator = Qc.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					string empty = string.Empty;
					int num2 = current.aS();
					string text = ((SettingOrSpecialObject)current).H();
					empty = ((!string.IsNullOrWhiteSpace(text)) ? ((num2 == 0 || num2 == 82) ? text : (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(current.@as(), num2, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E())) : ((num2 == 0 || num2 == 82) ? ((SettingOrSpecialObject)current).A(bz.aYt) : (((SettingOrSpecialObject)current).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(current.@as(), num2, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E())));
					val.Add(empty);
					Size val2 = TextRenderer.MeasureText(empty, ((Control)this).Font);
					int width = ((Size)(ref val2)).Width;
					if (width > num)
					{
						num = width;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			num += 50;
			int num3 = ((Control)QG).Bottom + 5;
			int num4 = 0;
			enumerator = Qc.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current2 = enumerator.Current;
					int num5 = current2.aS();
					int num6 = Qc.IndexOf(current2);
					int left = 5;
					Label val3 = new Label();
					((Control)val3).Left = left;
					((Control)val3).Top = num3;
					((Control)val3).Text = val[num6];
					((Control)val3).AutoSize = true;
					((Control)val3).Tag = num6;
					left = num;
					((Control)this).Controls.Add((Control)(object)val3);
					ThemedTextBox themedTextBox = new ThemedTextBox();
					((Control)themedTextBox).Left = left;
					((Control)themedTextBox).Top = num3;
					((Control)themedTextBox).Width = 100;
					((Control)themedTextBox).Tag = num6;
					((Control)themedTextBox).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mT() + num6;
					((Control)themedTextBox).Text = bS.a(QD[num6], num5, -1);
					((Control)QG).Left = left;
					((Control)this).Controls.Add((Control)(object)themedTextBox);
					left += ((Control)themedTextBox).Width + 5;
					ThemedTextBox themedTextBox2 = new ThemedTextBox();
					((Control)themedTextBox2).Left = left;
					((Control)themedTextBox2).Top = num3;
					((Control)themedTextBox2).Width = 100;
					((Control)themedTextBox2).Tag = num6;
					((Control)themedTextBox2).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mt() + num6;
					((Control)themedTextBox2).Text = bS.a(Qd[num6], num5, -1);
					((Control)Qf).Left = left;
					((Control)this).Controls.Add((Control)(object)themedTextBox2);
					num3 += ((Control)val3).Height + 10;
					num4 = ((Control)themedTextBox2).Right + 20;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			num3 += 10;
			((Control)Qg).Top = num3;
			((Control)Qg).Width = num4 - ((Control)Qg).Left * 4;
			num3 = ((Control)Qg).Bottom;
			((Control)QF).Top = num3;
			((Control)Qe).Top = ((Control)QF).Top;
			((Control)Qe).Left = num4 - ((Control)Qe).Width - 20;
			((Control)QF).Left = ((Control)Qe).Left - ((Control)QF).Width - 5;
			((Control)this).Width = num4;
			((Control)this).Height = ((Control)QF).Bottom + 45;
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val4 = item;
				if (val4 is Label)
				{
					val4.ForeColor = BM.te;
				}
				if (val4 is ThemedTextBox)
				{
					val4.BackColor = BM.to;
					val4.ForeColor = BM.te;
				}
			}
		}

		[SpecialName]
		internal List<int> a()
		{
			return QD;
		}

		[SpecialName]
		internal List<int> B()
		{
			return Qd;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected O, but got Unknown
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			string text = null;
			bool flag = false;
			bool flag2 = false;
			string text2 = string.Empty;
			string text3 = string.Empty;
			try
			{
				for (int i = 0; i < Qc.Count; i++)
				{
					Setting setting = Qc[i];
					int num = setting.aS();
					int num2 = setting.aR();
					int num3 = setting.ar();
					int num4 = -2147483648;
					int num5 = -2147483648;
					flag = false;
					flag2 = false;
					text2 = bS.a(num2, num, -1);
					text3 = bS.a(num3, num, -1);
					text = null;
					foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
					{
						Control val = item;
						if (val.Tag is int && (int)val.Tag == i && val is Label)
						{
							text = ((val is Label) ? val : null).Text;
							break;
						}
					}
					foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
					{
						Control val2 = item2;
						if (val2.Tag is int && (int)val2.Tag == i && val2 is ThemedTextBox)
						{
							ThemedTextBox themedTextBox = val2 as ThemedTextBox;
							if (((Control)themedTextBox).Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mT()))
							{
								num4 = bS.A(((Control)themedTextBox).Text, num);
							}
							if (((Control)themedTextBox).Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mt()))
							{
								num5 = bS.A(((Control)themedTextBox).Text, num);
							}
						}
					}
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
					QD[i] = num4;
					Qd[i] = num5;
				}
			}
			catch
			{
				if (flag || flag2)
				{
					string text4 = string.Empty;
					if (flag)
					{
						text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LG();
					}
					else if (flag2)
					{
						text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lg();
					}
					if (text == null)
					{
						bE.A((IWin32Window)(object)this, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mU() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mu(), (object)text2, (object)text3), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						bE.A((IWin32Window)(object)this, string.Format(string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mU(),
							text4,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mV(),
							text,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mu()
						}), (object)text2, (object)text3), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
				else if (text == null)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mv() + text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && QE != null)
			{
				((System.IDisposable)QE).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void b()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected O, but got Unknown
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected O, but got Unknown
			Qf = new Label();
			QG = new Label();
			Qe = new ThemedButton();
			QF = new ThemedButton();
			Qg = new Label();
			((Control)this).SuspendLayout();
			((Control)Qf).AutoSize = true;
			((Control)Qf).Location = new Point(66, 9);
			((Control)Qf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mW();
			((Control)Qf).Size = new Size(80, 13);
			((Control)Qf).TabIndex = 87;
			((Control)Qf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ll();
			((Control)QG).AutoSize = true;
			((Control)QG).Location = new Point(12, 9);
			((Control)QG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mw();
			((Control)QG).Size = new Size(76, 13);
			((Control)QG).TabIndex = 86;
			((Control)QG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LM();
			((Button)Qe).DialogResult = (DialogResult)2;
			((Control)Qe).Location = new Point(107, 404);
			((Control)Qe).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)Qe).Size = new Size(89, 34);
			((Control)Qe).TabIndex = 39;
			((Control)Qe).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)Qe).UseVisualStyleBackColor = true;
			((Button)QF).DialogResult = (DialogResult)1;
			((Control)QF).Location = new Point(12, 404);
			((Control)QF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)QF).Size = new Size(89, 34);
			((Control)QF).TabIndex = 38;
			((Control)QF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)QF).UseVisualStyleBackColor = true;
			((Control)Qg).Location = new Point(9, 348);
			((Control)Qg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mX();
			((Control)Qg).Size = new Size(333, 53);
			((Control)Qg).TabIndex = 88;
			((Control)Qg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ln();
			((Form)this).AcceptButton = (IButtonControl)(object)QF;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)Qe;
			((Form)this).ClientSize = new Size(800, 450);
			((Control)this).Controls.Add((Control)(object)Qg);
			((Control)this).Controls.Add((Control)(object)Qf);
			((Control)this).Controls.Add((Control)(object)QG);
			((Control)this).Controls.Add((Control)(object)Qe);
			((Control)this).Controls.Add((Control)(object)QF);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mx();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Bl
	{
		internal int QH;

		internal int Qh;

		internal int QI;

		internal int Qi;

		internal int QJ;
	}
}
namespace b
{
	internal enum bL
	{
		aCA,
		aCa,
		aCB,
		aCb,
		aCC,
		aCc,
		aCD,
		aCd
	}
	internal enum bl
	{
		aCE,
		aCe,
		aCF,
		aCf,
		aCG
	}
}
