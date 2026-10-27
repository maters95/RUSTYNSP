using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using C;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace B
{
	internal class BO : Form
	{
		internal class A : ThemedComboBox
		{
			protected override void OnPaint(PaintEventArgs e)
			{
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Expected O, but got Unknown
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Expected O, but got Unknown
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				if (((ListControl)this).SelectedIndex >= 0)
				{
					SolidBrush val = new SolidBrush(cm.BjA[((ListControl)this).SelectedIndex]);
					try
					{
						e.Graphics.FillRectangle((Brush)(object)val, e.ClipRectangle);
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
				}
				Pen val2 = new Pen(Brushes.Black, 1f);
				try
				{
					Graphics graphics = e.Graphics;
					Rectangle clipRectangle = e.ClipRectangle;
					int x = ((Rectangle)(ref clipRectangle)).X;
					clipRectangle = e.ClipRectangle;
					int y = ((Rectangle)(ref clipRectangle)).Y;
					clipRectangle = e.ClipRectangle;
					int num = ((Rectangle)(ref clipRectangle)).Width - 1;
					clipRectangle = e.ClipRectangle;
					graphics.DrawRectangle(val2, x, y, num, ((Rectangle)(ref clipRectangle)).Height - 1);
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
		}

		private const int Uc = 5;

		private List<Setting> UD;

		private double Ud;

		private double UE;

		private double Ue;

		private double UF;

		private Dictionary<int, int> Uf = new Dictionary<int, int>();

		private Dictionary<int, int> UG = new Dictionary<int, int>();

		private Dictionary<int, int> Ug = new Dictionary<int, int>();

		private List<int> UH = new List<int>();

		private List<int> Uh = new List<int>();

		private int UI;

		private List<TextBox> Ui = new List<TextBox>();

		private List<TextBox> UJ = new List<TextBox>();

		private List<TextBox> Uj = new List<TextBox>();

		private List<TextBox> UK = new List<TextBox>();

		private List<A> Uk = new List<A>();

		private IContainer UL;

		private Label Ul;

		private Label UM;

		private NumericUpDown Um;

		private ThemedButton UN;

		private ThemedButton Un;

		private Label UO;

		private Label Uo;

		private Label UP;

		private Label Up;

		private Label UQ;

		private Label Uq;

		private Label UR;

		private ThemedTextBox Ur;

		private ThemedTextBox US;

		private aP Us;

		private Label UT;

		private Label Ut;

		private ThemedTextBox UU;

		private ThemedTextBox Uu;

		internal BO()
		{
			f();
		}

		internal BO(List<Setting> P_0, bool P_1, double P_2, double P_3, double P_4, double P_5, Dictionary<int, int> P_6, Dictionary<int, int> P_7, List<int> P_8, List<int> P_9, Dictionary<int, int> P_10, int P_11)
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			f();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
				else if (val is aP)
				{
					val.ForeColor = BM.te;
				}
				else if (val is ThemedTextBox)
				{
					val.BackColor = BM.to;
					val.ForeColor = BM.te;
				}
			}
			Ud = P_2;
			UE = P_3;
			Ue = P_4;
			UF = P_5;
			UD = P_0;
			Enumerator<int, int> enumerator2 = P_6.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, int> current = enumerator2.Current;
					Uf.Add(current.Key, current.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			enumerator2 = P_7.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, int> current2 = enumerator2.Current;
					UG.Add(current2.Key, current2.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			enumerator2 = P_10.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, int> current3 = enumerator2.Current;
					Ug.Add(current3.Key, current3.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			Enumerator<int> enumerator3 = P_8.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					int current4 = enumerator3.Current;
					UH.Add(current4);
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			enumerator3 = P_9.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					int current5 = enumerator3.Current;
					Uh.Add(current5);
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			UI = P_11;
			A(P_1);
		}

		private void A(bool P_0)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_0703: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Expected O, but got Unknown
			//IL_0723: Unknown result type (might be due to invalid IL or missing references)
			//IL_072a: Expected O, but got Unknown
			//IL_0735: Unknown result type (might be due to invalid IL or missing references)
			//IL_074c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0763: Unknown result type (might be due to invalid IL or missing references)
			//IL_076f: Unknown result type (might be due to invalid IL or missing references)
			List<string> val = new List<string>();
			int num = 0;
			Enumerator<Setting> enumerator = UD.GetEnumerator();
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
			int num3 = ((Control)UP).Bottom + 5;
			int num4 = 0;
			enumerator = UD.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current2 = enumerator.Current;
					int num5 = current2.aS();
					int num6 = UD.IndexOf(current2);
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
					((Control)themedTextBox).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tn() + num6;
					((Control)themedTextBox).Text = bS.a(Uf[current2.A()], num5, -1);
					((Control)UP).Left = left;
					((Control)this).Controls.Add((Control)(object)themedTextBox);
					Ui.Add((TextBox)(object)themedTextBox);
					left += ((Control)themedTextBox).Width + 5;
					ThemedTextBox themedTextBox2 = new ThemedTextBox();
					((Control)themedTextBox2).Left = left;
					((Control)themedTextBox2).Top = num3;
					((Control)themedTextBox2).Width = 100;
					((Control)themedTextBox2).Tag = num6;
					((Control)themedTextBox2).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tO() + num6;
					((Control)themedTextBox2).Text = bS.a(UG[current2.A()], num5, -1);
					((Control)Uo).Left = left;
					((Control)this).Controls.Add((Control)(object)themedTextBox2);
					UJ.Add((TextBox)(object)themedTextBox2);
					left += ((Control)themedTextBox2).Width + 5;
					ThemedTextBox themedTextBox3 = new ThemedTextBox();
					((Control)themedTextBox3).Left = left;
					((Control)themedTextBox3).Top = num3;
					((Control)themedTextBox3).Width = 100;
					((Control)themedTextBox3).Tag = num6;
					((Control)themedTextBox3).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mT() + num6;
					((Control)themedTextBox3).Text = bS.a(UH[num6], num5, -1);
					((Control)UQ).Left = left;
					((Control)this).Controls.Add((Control)(object)themedTextBox3);
					Uj.Add((TextBox)(object)themedTextBox3);
					left += ((Control)themedTextBox3).Width + 5;
					ThemedTextBox themedTextBox4 = new ThemedTextBox();
					((Control)themedTextBox4).Left = left;
					((Control)themedTextBox4).Top = num3;
					((Control)themedTextBox4).Width = 100;
					((Control)themedTextBox4).Tag = num6;
					((Control)themedTextBox4).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mt() + num6;
					((Control)themedTextBox4).Text = bS.a(Uh[num6], num5, -1);
					((Control)Up).Left = left;
					((Control)this).Controls.Add((Control)(object)themedTextBox4);
					UK.Add((TextBox)(object)themedTextBox4);
					left += ((Control)themedTextBox4).Width + 5;
					A a = new A();
					((Control)a).Left = left;
					((Control)a).Top = num3;
					((Control)a).Width = 47;
					((Control)a).Tag = num6;
					((Control)a).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.to() + num6;
					for (int i = 0; i < cm.BjA.Length; i++)
					{
						((ComboBox)a).Items.Add((object)((object)(Color)(ref cm.BjA[i])).ToString());
					}
					((ListControl)a).SelectedIndex = Ug[current2.A()];
					((ComboBox)a).DrawMode = (DrawMode)1;
					((ComboBox)a).DropDownStyle = (ComboBoxStyle)2;
					((ComboBox)a).DrawItem += new DrawItemEventHandler(A);
					((Control)UO).Left = left;
					((Control)this).Controls.Add((Control)(object)a);
					Uk.Add(a);
					num3 += ((Control)val3).Height + 10;
					num4 = ((Control)a).Right + 20;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			num3 += 10;
			((Control)Us).Top = num3;
			((Control)UR).Top = ((Control)Us).Top + 20;
			((Control)Uq).Top = ((Control)UR).Top;
			((Control)Ut).Top = ((Control)UR).Top;
			((Control)UT).Top = ((Control)UR).Top;
			((Control)US).Top = ((Control)UR).Top + 18;
			((Control)Ur).Top = ((Control)US).Top;
			((Control)Uu).Top = ((Control)US).Top;
			((Control)UU).Top = ((Control)US).Top;
			((Control)Um).Top = ((Control)US).Top + 38;
			((Control)UM).Left = 5;
			((Control)UM).Top = ((Control)Um).Top + 3;
			((Control)Ul).Top = ((Control)UM).Top;
			((Control)Um).Left = ((Control)UM).Right + 5;
			((Control)Ul).Left = ((Control)Um).Right + 5;
			((Control)Un).Top = ((Control)Us).Top + 67;
			((Control)UN).Top = ((Control)Un).Top;
			((Control)UN).Left = num4 - ((Control)UN).Width - 20;
			((Control)Un).Left = ((Control)UN).Left - ((Control)Un).Width - 5;
			Um.Value = decimal.op_Implicit(UI);
			((Control)this).Width = num4;
			((Control)this).Height = ((Control)Un).Bottom + 50;
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val4 = item;
				if (val4 is Label)
				{
					val4.ForeColor = BM.te;
				}
				else if (val4 is aP)
				{
					val4.ForeColor = BM.te;
				}
				else if (val4 is ThemedTextBox)
				{
					val4.BackColor = BM.to;
					val4.ForeColor = BM.te;
				}
			}
			((Control)US).Text = Ud.ToString();
			((Control)Ur).Text = UE.ToString();
			((Control)Uu).Text = Ue.ToString();
			((Control)UU).Text = UF.ToString();
			((CheckBox)Us).Checked = P_0;
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			((Control)US).Enabled = ((CheckBox)Us).Checked;
			((Control)Ur).Enabled = ((CheckBox)Us).Checked;
			((Control)Uu).Enabled = ((CheckBox)Us).Checked;
			((Control)UU).Enabled = ((CheckBox)Us).Checked;
			Enumerator<TextBox> enumerator = Ui.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Enabled = !((CheckBox)Us).Checked;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = UJ.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Enabled = !((CheckBox)Us).Checked;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = Uj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Enabled = !((CheckBox)Us).Checked;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = UK.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Enabled = !((CheckBox)Us).Checked;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		[SpecialName]
		internal bool A()
		{
			return ((CheckBox)Us).Checked;
		}

		[SpecialName]
		internal double a()
		{
			return Ud;
		}

		[SpecialName]
		internal double B()
		{
			return UE;
		}

		[SpecialName]
		internal double b()
		{
			return Ue;
		}

		[SpecialName]
		internal double C()
		{
			return UF;
		}

		[SpecialName]
		internal Dictionary<int, int> c()
		{
			return Uf;
		}

		[SpecialName]
		internal Dictionary<int, int> D()
		{
			return UG;
		}

		[SpecialName]
		internal Dictionary<int, int> d()
		{
			return Ug;
		}

		[SpecialName]
		internal List<int> E()
		{
			return UH;
		}

		[SpecialName]
		internal List<int> e()
		{
			return Uh;
		}

		[SpecialName]
		internal int F()
		{
			return UI;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0449: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Expected O, but got Unknown
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			string text = null;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			string text2 = string.Empty;
			string text3 = string.Empty;
			try
			{
				if (((CheckBox)Us).Checked)
				{
					double num = double.Parse(((Control)US).Text);
					double num2 = double.Parse(((Control)Ur).Text);
					double ue = double.Parse(((Control)Uu).Text);
					double uF = double.Parse(((Control)UU).Text);
					if (num >= num2)
					{
						flag = true;
						throw new System.Exception();
					}
					Ud = num;
					UE = num2;
					Ue = ue;
					UF = uF;
				}
				else
				{
					for (int i = 0; i < UD.Count; i++)
					{
						Setting setting = UD[i];
						int num3 = setting.aS();
						int num4 = setting.aR();
						int num5 = setting.ar();
						int num6 = -2147483648;
						int num7 = -2147483648;
						int num8 = -2147483648;
						int num9 = -2147483648;
						flag = false;
						flag2 = false;
						flag3 = false;
						flag4 = false;
						flag5 = false;
						text2 = bS.a(num4, num3, -1);
						text3 = bS.a(num5, num3, -1);
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
								if (((Control)themedTextBox).Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tn()))
								{
									num6 = bS.A(((Control)themedTextBox).Text, num3);
								}
								if (((Control)themedTextBox).Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tO()))
								{
									num7 = bS.A(((Control)themedTextBox).Text, num3);
								}
								if (((Control)themedTextBox).Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mT()))
								{
									num8 = bS.A(((Control)themedTextBox).Text, num3);
								}
								if (((Control)themedTextBox).Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mt()))
								{
									num9 = bS.A(((Control)themedTextBox).Text, num3);
								}
							}
						}
						if (num6 >= num7)
						{
							flag = true;
							throw new System.Exception();
						}
						if (num4 != 0 || num5 != 0)
						{
							if (num6 < num4)
							{
								flag2 = true;
								throw new System.Exception();
							}
							if (num7 > num5)
							{
								flag3 = true;
								throw new System.Exception();
							}
							if (num8 < num4 || num8 > num5)
							{
								flag4 = true;
								throw new System.Exception();
							}
							if (num9 < num4 || num9 > num5)
							{
								flag5 = true;
								throw new System.Exception();
							}
						}
						Uf[setting.A()] = num6;
						UG[setting.A()] = num7;
						UH[i] = num8;
						Uh[i] = num9;
					}
				}
				for (int j = 0; j < UD.Count; j++)
				{
					Ug[UD[j].A()] = ((ListControl)Uk[j]).SelectedIndex;
				}
				UI = (int)Um.Value;
			}
			catch
			{
				if (flag)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Le(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (flag2 || flag3 || flag4 || flag5)
				{
					string text4 = string.Empty;
					if (flag2)
					{
						text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LF();
					}
					else if (flag3)
					{
						text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lf();
					}
					else if (flag4)
					{
						text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LG();
					}
					else if (flag5)
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

		private void A(A P_0, int P_1, DrawItemEventArgs P_2)
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			if (((ComboBox)P_0).DroppedDown)
			{
				SolidBrush val = new SolidBrush(cm.BjA[P_2.Index]);
				try
				{
					P_2.Graphics.FillRectangle((Brush)(object)val, P_2.Bounds);
					return;
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			SolidBrush val2 = new SolidBrush(cm.BjA[((ListControl)P_0).SelectedIndex]);
			try
			{
				P_2.Graphics.FillRectangle((Brush)(object)val2, P_2.Bounds);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			Pen val3 = new Pen(Brushes.Black, 1f);
			try
			{
				Graphics graphics = P_2.Graphics;
				Rectangle bounds = P_2.Bounds;
				int x = ((Rectangle)(ref bounds)).X;
				bounds = P_2.Bounds;
				int y = ((Rectangle)(ref bounds)).Y;
				bounds = P_2.Bounds;
				int num = ((Rectangle)(ref bounds)).Width - 1;
				bounds = P_2.Bounds;
				graphics.DrawRectangle(val3, x, y, num, ((Rectangle)(ref bounds)).Height - 1);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}

		private void A(object P_0, DrawItemEventArgs P_1)
		{
			A a = P_0 as A;
			A(P_0 as A, (int)((Control)a).Tag, P_1);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && UL != null)
			{
				((System.IDisposable)UL).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void f()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
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
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Unknown result type (might be due to invalid IL or missing references)
			//IL_03de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0402: Unknown result type (might be due to invalid IL or missing references)
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0513: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_059b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_062f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0653: Unknown result type (might be due to invalid IL or missing references)
			//IL_0683: Unknown result type (might be due to invalid IL or missing references)
			//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f4: Expected O, but got Unknown
			//IL_0710: Unknown result type (might be due to invalid IL or missing references)
			//IL_0734: Unknown result type (might be due to invalid IL or missing references)
			//IL_0777: Unknown result type (might be due to invalid IL or missing references)
			//IL_079b: Unknown result type (might be due to invalid IL or missing references)
			//IL_07de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0802: Unknown result type (might be due to invalid IL or missing references)
			//IL_0835: Unknown result type (might be due to invalid IL or missing references)
			//IL_0859: Unknown result type (might be due to invalid IL or missing references)
			//IL_0887: Unknown result type (might be due to invalid IL or missing references)
			//IL_08af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a14: Expected O, but got Unknown
			//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a66: Expected O, but got Unknown
			Ul = new Label();
			UM = new Label();
			Um = new NumericUpDown();
			UO = new Label();
			Uo = new Label();
			UP = new Label();
			UN = new ThemedButton();
			Un = new ThemedButton();
			Up = new Label();
			UQ = new Label();
			Uq = new Label();
			UR = new Label();
			Ur = new ThemedTextBox();
			US = new ThemedTextBox();
			Us = new aP();
			UT = new Label();
			Ut = new Label();
			UU = new ThemedTextBox();
			Uu = new ThemedTextBox();
			((ISupportInitialize)Um).BeginInit();
			((Control)this).SuspendLayout();
			((Control)Ul).AutoSize = true;
			((Control)Ul).Location = new Point(275, 378);
			((Control)Ul).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gg();
			((Control)Ul).Size = new Size(50, 13);
			((Control)Ul).TabIndex = 84;
			((Control)Ul).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tP();
			((Control)UM).AutoSize = true;
			((Control)UM).Location = new Point(9, 378);
			((Control)UM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gf();
			((Control)UM).Size = new Size(192, 13);
			((Control)UM).TabIndex = 83;
			((Control)UM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tp();
			((Control)Um).Location = new Point(197, 376);
			Um.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
			((Control)Um).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tQ();
			((Control)Um).Size = new Size(72, 22);
			((Control)Um).TabIndex = 80;
			Um.Value = new decimal(new int[4] { 5, 0, 0, 0 });
			((Control)UO).AutoSize = true;
			((Control)UO).Location = new Point(275, 9);
			((Control)UO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tq();
			((Control)UO).Size = new Size(42, 13);
			((Control)UO).TabIndex = 88;
			((Control)UO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tR();
			((Control)Uo).AutoSize = true;
			((Control)Uo).Location = new Point(66, 9);
			((Control)Uo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tr();
			((Control)Uo).Size = new Size(56, 13);
			((Control)Uo).TabIndex = 87;
			((Control)Uo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jp();
			((Control)UP).AutoSize = true;
			((Control)UP).Location = new Point(12, 9);
			((Control)UP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tS();
			((Control)UP).Size = new Size(55, 13);
			((Control)UP).TabIndex = 86;
			((Control)UP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ts();
			((Button)UN).DialogResult = (DialogResult)2;
			((Control)UN).Location = new Point(107, 404);
			((Control)UN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)UN).Size = new Size(89, 34);
			((Control)UN).TabIndex = 39;
			((Control)UN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)UN).UseVisualStyleBackColor = true;
			((Button)Un).DialogResult = (DialogResult)1;
			((Control)Un).Location = new Point(12, 404);
			((Control)Un).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)Un).Size = new Size(89, 34);
			((Control)Un).TabIndex = 38;
			((Control)Un).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)Un).UseVisualStyleBackColor = true;
			((Control)Up).AutoSize = true;
			((Control)Up).Location = new Point(195, 9);
			((Control)Up).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mW();
			((Control)Up).Size = new Size(80, 13);
			((Control)Up).TabIndex = 90;
			((Control)Up).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ll();
			((Control)UQ).AutoSize = true;
			((Control)UQ).Location = new Point(122, 9);
			((Control)UQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mw();
			((Control)UQ).Size = new Size(76, 13);
			((Control)UQ).TabIndex = 89;
			((Control)UQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LM();
			((Control)Uq).AutoSize = true;
			((Control)Uq).Location = new Point(122, 324);
			((Control)Uq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tT();
			((Control)Uq).Size = new Size(56, 13);
			((Control)Uq).TabIndex = 95;
			((Control)Uq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jp();
			((Control)UR).AutoSize = true;
			((Control)UR).Location = new Point(16, 324);
			((Control)UR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tt();
			((Control)UR).Size = new Size(55, 13);
			((Control)UR).TabIndex = 94;
			((Control)UR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ts();
			((Control)Ur).Enabled = false;
			((Control)Ur).Location = new Point(120, 340);
			((Control)Ur).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tU();
			((Control)Ur).Size = new Size(100, 22);
			((Control)Ur).TabIndex = 93;
			((Control)US).Enabled = false;
			((Control)US).Location = new Point(14, 340);
			((Control)US).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tu();
			((Control)US).Size = new Size(100, 22);
			((Control)US).TabIndex = 92;
			((Control)Us).AutoSize = true;
			((Control)Us).Location = new Point(12, 304);
			((Control)Us).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tV();
			((Control)Us).Size = new Size(220, 17);
			((Control)Us).TabIndex = 91;
			((Control)Us).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tv();
			((ButtonBase)Us).UseVisualStyleBackColor = true;
			((CheckBox)Us).CheckedChanged += new EventHandler(A);
			((Control)UT).AutoSize = true;
			((Control)UT).Location = new Point(343, 324);
			((Control)UT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tW();
			((Control)UT).Size = new Size(80, 13);
			((Control)UT).TabIndex = 99;
			((Control)UT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ll();
			((Control)Ut).AutoSize = true;
			((Control)Ut).Location = new Point(237, 324);
			((Control)Ut).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tw();
			((Control)Ut).Size = new Size(76, 13);
			((Control)Ut).TabIndex = 98;
			((Control)Ut).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LM();
			((Control)UU).Enabled = false;
			((Control)UU).Location = new Point(341, 340);
			((Control)UU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tX();
			((Control)UU).Size = new Size(100, 22);
			((Control)UU).TabIndex = 97;
			((Control)Uu).Enabled = false;
			((Control)Uu).Location = new Point(235, 340);
			((Control)Uu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tx();
			((Control)Uu).Size = new Size(100, 22);
			((Control)Uu).TabIndex = 96;
			((Form)this).AcceptButton = (IButtonControl)(object)Un;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)UN;
			((Form)this).ClientSize = new Size(800, 450);
			((Control)this).Controls.Add((Control)(object)UT);
			((Control)this).Controls.Add((Control)(object)Ut);
			((Control)this).Controls.Add((Control)(object)UU);
			((Control)this).Controls.Add((Control)(object)Uu);
			((Control)this).Controls.Add((Control)(object)Uq);
			((Control)this).Controls.Add((Control)(object)UR);
			((Control)this).Controls.Add((Control)(object)Ur);
			((Control)this).Controls.Add((Control)(object)US);
			((Control)this).Controls.Add((Control)(object)Us);
			((Control)this).Controls.Add((Control)(object)Up);
			((Control)this).Controls.Add((Control)(object)UQ);
			((Control)this).Controls.Add((Control)(object)UO);
			((Control)this).Controls.Add((Control)(object)Uo);
			((Control)this).Controls.Add((Control)(object)UP);
			((Control)this).Controls.Add((Control)(object)Ul);
			((Control)this).Controls.Add((Control)(object)UM);
			((Control)this).Controls.Add((Control)(object)Um);
			((Control)this).Controls.Add((Control)(object)UN);
			((Control)this).Controls.Add((Control)(object)Un);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tY();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ty();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((ISupportInitialize)Um).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Bo : Form
	{
		private struct A
		{
			internal string Bqw;

			internal string BqX;

			internal A(string P_0, string P_1)
			{
				Bqw = P_0;
				BqX = P_1;
			}
		}

		private string UV;

		private List<List<A>> Uv = new List<List<A>>();

		private IContainer UW;

		private ThemedButton Uw;

		private ThemedButton UX;

		private ThemedComboBox Ux;

		private ab UY;

		private ColumnHeader Uy;

		private Label UZ;

		private PictureBox Uz;

		internal Bo()
		{
			a();
		}

		[SpecialName]
		internal string A()
		{
			return UV;
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).BackColor = BM.td;
			((Control)UY).BackColor = BM.tH;
			((Control)UY).ForeColor = BM.te;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			List<string> val2 = bT.b();
			if (val2 == null)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tZ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			Enumerator<string> enumerator2 = val2.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					string current = enumerator2.Current;
					A(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			UY.a();
			if (((ListView)UY).Items.Count == 1)
			{
				((ListView)UY).Items[0].Selected = true;
			}
		}

		private void A(string P_0)
		{
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			bv bv = bT.A(P_0);
			if (bv == null || (bx.A(bv.axq) && bv.axr.A() < 3))
			{
				return;
			}
			bW bdC = new bW
			{
				axS = bv.axq,
				axs = bv.axR,
				axT = bv.axr,
				axt = null
			};
			CX cX = new CX
			{
				BdC = bdC,
				Bdc = new List<ushort>()
			};
			if (Ct.A(cX, out var _, out var _) || (!cX.BdC.axT.d() && !bg.a()))
			{
				return;
			}
			int num = -1;
			for (int i = 0; i < ((ListView)UY).Items.Count; i++)
			{
				bv bv2 = (bv)((ListView)UY).Items[i].Tag;
				if (bv2.axq == bv.axq && bv2.axR == bv.axR)
				{
					num = i;
					break;
				}
			}
			A a = new A(P_0, ((object)bv.axr).ToString());
			if (num == -1)
			{
				ListViewItem val = new ListViewItem(new string[1] { bx.C(bv.axq, bv.axR) });
				bv bv3 = new bv();
				bv3.axq = bv.axq;
				bv3.axR = bv.axR;
				bv3.axr = bv.axr;
				val.Tag = bv3;
				List<A> val2 = new List<A>();
				val2.Add(a);
				if (((ListView)UY).Items.Count == 0)
				{
					((ListView)UY).Items.Add(val);
					Uv.Add(val2);
					return;
				}
				int num2 = bx.a(bv3.axq, bv3.axR);
				bool flag2 = false;
				for (int j = 0; j < ((ListView)UY).Items.Count; j++)
				{
					int axq = ((bv)((ListView)UY).Items[j].Tag).axq;
					int axR = ((bv)((ListView)UY).Items[j].Tag).axR;
					int num3 = bx.a(axq, axR);
					if (num2 < num3)
					{
						((ListView)UY).Items.Insert(j, val);
						Uv.Insert(j, val2);
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					((ListView)UY).Items.Add(val);
					Uv.Add(val2);
				}
				return;
			}
			List<A> val3 = Uv[num];
			k k = new k(a.BqX, false);
			if (val3.Count == 0)
			{
				val3.Add(a);
				return;
			}
			for (int num4 = val3.Count - 1; num4 >= 0; num4--)
			{
				k k2 = new k(val3[num4].BqX, false);
				if (k < k2 || (k == k2 && File.GetLastWriteTime(P_0) < File.GetLastWriteTime(val3[num4].Bqw)))
				{
					if (num4 == val3.Count - 1)
					{
						val3.Add(a);
					}
					else
					{
						val3.Insert(num4 + 1, a);
					}
					break;
				}
				if (num4 == 0)
				{
					val3.Insert(0, a);
				}
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (((ListView)UY).SelectedIndices.Count != 1)
				{
					return;
				}
				bv obj = (bv)((ListView)UY).Items[((ListView)UY).SelectedIndices[0]].Tag;
				int axq = obj.axq;
				int axR = obj.axR;
				Uz.Image = bx.c(axq, axR);
				((ComboBox)Ux).Items.Clear();
				Enumerator<A> enumerator = Uv[((ListView)UY).SelectedIndices[0]].GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						A current = enumerator.Current;
						((ComboBox)Ux).Items.Add((object)current.BqX);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				((ListControl)Ux).SelectedIndex = 0;
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tz() + ex.Message, true);
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			((Form)this).DialogResult = (DialogResult)1;
			((Form)this).Close();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			try
			{
				int num = ((ListView)UY).SelectedIndices[0];
				int selectedIndex = ((ListControl)Ux).SelectedIndex;
				if (num != -1 && selectedIndex != -1)
				{
					UV = Uv[num][selectedIndex].Bqw;
				}
				else
				{
					((CancelEventArgs)P_1).Cancel = true;
				}
			}
			catch
			{
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && UW != null)
			{
				((System.IDisposable)UW).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected O, but got Unknown
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected O, but got Unknown
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0460: Unknown result type (might be due to invalid IL or missing references)
			//IL_046a: Expected O, but got Unknown
			//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Expected O, but got Unknown
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Expected O, but got Unknown
			Uw = new ThemedButton();
			UX = new ThemedButton();
			Ux = new ThemedComboBox();
			UY = new ab();
			Uy = new ColumnHeader();
			UZ = new Label();
			Uz = new PictureBox();
			((ISupportInitialize)Uz).BeginInit();
			((Control)this).SuspendLayout();
			((Button)Uw).DialogResult = (DialogResult)1;
			((Control)Uw).Location = new Point(300, 320);
			((Control)Uw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)Uw).Size = new Size(100, 30);
			((Control)Uw).TabIndex = 2;
			((Control)Uw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)Uw).UseVisualStyleBackColor = true;
			((Button)UX).DialogResult = (DialogResult)2;
			((Control)UX).Location = new Point(418, 320);
			((Control)UX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)UX).Size = new Size(100, 30);
			((Control)UX).TabIndex = 3;
			((Control)UX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)UX).UseVisualStyleBackColor = true;
			((ComboBox)Ux).DrawMode = (DrawMode)1;
			((ComboBox)Ux).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)Ux).FormattingEnabled = true;
			((Control)Ux).Location = new Point(326, 39);
			((ComboBox)Ux).MaxDropDownItems = 40;
			((Control)Ux).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UA();
			((Control)Ux).Size = new Size(190, 23);
			((Control)Ux).TabIndex = 1;
			((ListView)UY).BorderStyle = (BorderStyle)1;
			((ListView)UY).Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[1] { Uy });
			((ListView)UY).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)UY).HideSelection = false;
			((Control)UY).Location = new Point(12, 12);
			((ListView)UY).MultiSelect = false;
			((Control)UY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ua();
			((ListView)UY).ShowGroups = false;
			((Control)UY).Size = new Size(300, 289);
			((Control)UY).TabIndex = 0;
			((ListView)UY).UseCompatibleStateImageBehavior = false;
			((ListView)UY).View = (View)1;
			((ListView)UY).SelectedIndexChanged += new EventHandler(a);
			((Control)UY).DoubleClick += new EventHandler(B);
			Uy.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UB();
			Uy.Width = 280;
			((Control)UZ).AutoSize = true;
			((Control)UZ).Location = new Point(323, 23);
			((Control)UZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)UZ).Size = new Size(48, 13);
			((Control)UZ).TabIndex = 15;
			((Control)UZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ub();
			((Control)Uz).Location = new Point(326, 81);
			((Control)Uz).Margin = new Padding(0);
			((Control)Uz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fO();
			((Control)Uz).Size = new Size(190, 200);
			Uz.SizeMode = (PictureBoxSizeMode)2;
			Uz.TabIndex = 16;
			Uz.TabStop = false;
			((Form)this).AcceptButton = (IButtonControl)(object)Uw;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)UX;
			((Form)this).ClientSize = new Size(529, 362);
			((Control)this).Controls.Add((Control)(object)Uz);
			((Control)this).Controls.Add((Control)(object)UZ);
			((Control)this).Controls.Add((Control)(object)UY);
			((Control)this).Controls.Add((Control)(object)Ux);
			((Control)this).Controls.Add((Control)(object)UX);
			((Control)this).Controls.Add((Control)(object)Uw);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UC();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mh();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((ISupportInitialize)Uz).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal enum bO
	{
		aCM,
		aCm
	}
	internal enum bo
	{
		aCN,
		aCn,
		aCO
	}
}
