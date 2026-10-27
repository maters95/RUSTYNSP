using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
	internal class BR : Form
	{
		private MenuNode Vf;

		private IContainer VG;

		private ThemedButton Vg;

		private ThemedButton VH;

		private aG Vh;

		internal BR(MenuNode P_0)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			a();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					((val is Label) ? val : null).ForeColor = BM.te;
				}
			}
			Vf = P_0;
			Setting setting = Vf.a().A(Vf.W());
			((Control)this).Text = Cn.A(Vf.a(), Vf, setting);
			Vh.A(Vf);
			Vh.B(new EventHandler(a));
			((Control)Vg).BringToFront();
			((Control)VH).BringToFront();
			BM.C(new EventHandler(b));
		}

		internal BR()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			a();
			((Control)Vg).BringToFront();
			((Control)VH).BringToFront();
			BM.C(new EventHandler(b));
		}

		private void A(object P_0, EventArgs P_1)
		{
			Vh.e();
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (!string.IsNullOrWhiteSpace(Vh.c()))
			{
				((Form)this).DialogResult = (DialogResult)1;
				((Form)this).Close();
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			((Control)Vh).Size = ((Form)this).ClientSize;
			ThemedButton vH = VH;
			Size clientSize = ((Form)this).ClientSize;
			((Control)vH).Left = ((Size)(ref clientSize)).Width - 9 - ((Control)VH).Width;
			ThemedButton vH2 = VH;
			clientSize = ((Form)this).ClientSize;
			((Control)vH2).Top = ((Size)(ref clientSize)).Height - 8 - ((Control)VH).Height;
			((Control)Vg).Left = ((Control)VH).Left - 9 - ((Control)Vg).Width;
			((Control)Vg).Top = ((Control)VH).Top;
		}

		private void b(object P_0, EventArgs P_1)
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Invalid comparison between Unknown and I4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			BM.c(new EventHandler(b));
			if ((int)((Form)this).DialogResult == 1)
			{
				if (string.IsNullOrWhiteSpace(Vh.c()))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uJ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)P_1).Cancel = true;
				}
				else if (A())
				{
					Vh.F();
				}
				else
				{
					((CancelEventArgs)P_1).Cancel = true;
				}
			}
		}

		private bool A()
		{
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Invalid comparison between Unknown and I4
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Invalid comparison between Unknown and I4
			if (!string.IsNullOrWhiteSpace(Vh.c()) && Vh.c() != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV())
			{
				if (Vf.l() && Vf.a().awP.E()[Vf.m()].B() == 0)
				{
					return true;
				}
				Cn cn = null;
				lock (BM.qb)
				{
					if (BM.qB.ContainsKey(Vh.c()))
					{
						cn = BM.qB[Vh.c()].BcF;
					}
				}
				if (cn != null)
				{
					List<Setting> obj = cn.A(Vf, true, true);
					List<Setting> val = new List<Setting>();
					Enumerator<Setting> enumerator = obj.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Setting current = enumerator.Current;
							if (!((SettingOrSpecialObject)current).l())
							{
								continue;
							}
							int[] array = cn.a(current);
							bool flag = false;
							if (array != null)
							{
								int num = Math.Min(current.Ba(), array.Length);
								if (((SettingOrSpecialObject)current).D() != null)
								{
									if (((SettingOrSpecialObject)current).D() is Table)
									{
										Table table = ((SettingOrSpecialObject)current).D() as Table;
										if (((SettingOrSpecialObject)table).l() && current == table.TableDataSetting)
										{
											int num2 = table.ColumnCount();
											int num3 = table.RowCount();
											int num4 = table.SliceCount();
											for (int i = 0; i < num4; i++)
											{
												for (int j = 0; j < num3; j++)
												{
													for (int k = 0; k < num2; k++)
													{
														int num5 = current.A(k, j, i);
														if (num5 >= array.Length || current.m(num5) != array[num5])
														{
															flag = true;
															break;
														}
													}
													if (flag)
													{
														break;
													}
												}
												if (flag)
												{
													break;
												}
											}
										}
									}
									else
									{
										if (((SettingOrSpecialObject)current).D() is TableAxis && ((SettingOrSpecialObject)current).D().D() is Table)
										{
											Table obj2 = ((SettingOrSpecialObject)current).D().D() as Table;
											TableAxis tableAxis = ((SettingOrSpecialObject)current).D() as TableAxis;
											if (((SettingOrSpecialObject)obj2).l() && tableAxis.l() && current == tableAxis.G() && tableAxis.f() != null)
											{
												num = Math.Min(num, tableAxis.f().ax());
											}
										}
										else if (((SettingOrSpecialObject)current).D() is SensorCalibration)
										{
											SensorCalibration sensorCalibration = ((SettingOrSpecialObject)current).D() as SensorCalibration;
											if (((SettingOrSpecialObject)sensorCalibration).l() && (current == sensorCalibration.CalibrationValuesSetting || current == sensorCalibration.CalibrationVoltagesSetting) && sensorCalibration.CalibrationValueCountSetting != null)
											{
												num = Math.Min(num, sensorCalibration.CalibrationValueCountSetting.ax());
											}
										}
										for (int l = 0; l < num; l++)
										{
											if (current.m(l) != array[l])
											{
												flag = true;
												break;
											}
										}
									}
								}
								else
								{
									for (int m = 0; m < num; m++)
									{
										if (current.m(m) != array[m])
										{
											flag = true;
											break;
										}
									}
								}
							}
							if (flag)
							{
								val.Add(current);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					if (val.Count != 0)
					{
						if (Vf.l())
						{
							if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uK(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 2)
							{
								return false;
							}
						}
						else
						{
							string empty = string.Empty;
							List<Setting> val2 = new List<Setting>();
							A(ref empty, val, val2);
							a(ref empty, val, val2);
							B(ref empty, val, val2);
							b(ref empty, val, val2);
							if ((int)bE.A((IWin32Window)(object)this, empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uK(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 2)
							{
								return false;
							}
						}
					}
				}
			}
			return true;
		}

		private void A(ref string P_0, List<Setting> P_1, List<Setting> P_2)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			Enumerator<Setting> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (((SettingOrSpecialObject)current).D() == null || (!(((SettingOrSpecialObject)current).D() is Table) && !(((SettingOrSpecialObject)current).D() is TableAxis)))
					{
						continue;
					}
					if (((SettingOrSpecialObject)current).D() is Table && current == (((SettingOrSpecialObject)current).D() as Table).TableDataSetting)
					{
						Table table = ((SettingOrSpecialObject)current).D() as Table;
						if (!flag)
						{
							P_0 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uk();
							flag = true;
						}
						string text = ((SettingOrSpecialObject)table).A(bz.aYt);
						if (string.IsNullOrWhiteSpace(text))
						{
							text = ((SettingOrSpecialObject)table).B();
						}
						P_0 = P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uL() + text;
					}
					P_2.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void a(ref string P_0, List<Setting> P_1, List<Setting> P_2)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			Enumerator<Setting> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (!(((SettingOrSpecialObject)current).D() is SensorCalibration))
					{
						continue;
					}
					SensorCalibration sensorCalibration = ((SettingOrSpecialObject)current).D() as SensorCalibration;
					if ((current == sensorCalibration.CalibrationValuesSetting || current == sensorCalibration.CalibrationVoltagesSetting || current == sensorCalibration.CalibrationValueCountSetting) && !P_2.Contains(sensorCalibration.CalibrationValuesSetting) && !P_2.Contains(sensorCalibration.CalibrationVoltagesSetting) && !P_2.Contains(sensorCalibration.CalibrationValueCountSetting))
					{
						if (!flag)
						{
							if (!string.IsNullOrWhiteSpace(P_0))
							{
								P_0 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
							}
							P_0 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ul();
							flag = true;
						}
						string text = ((SettingOrSpecialObject)sensorCalibration).A(bz.aYt);
						if (string.IsNullOrWhiteSpace(text))
						{
							text = ((SettingOrSpecialObject)sensorCalibration).B();
						}
						P_0 = P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uL() + text;
					}
					P_2.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void B(ref string P_0, List<Setting> P_1, List<Setting> P_2)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			Enumerator<Setting> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (!(current is Dn))
					{
						continue;
					}
					if (!flag)
					{
						if (!string.IsNullOrWhiteSpace(P_0))
						{
							P_0 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
						}
						P_0 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uM();
						flag = true;
					}
					string text = ((SettingOrSpecialObject)current).A(bz.aYt);
					if (string.IsNullOrWhiteSpace(text))
					{
						text = ((SettingOrSpecialObject)current).B();
					}
					P_0 = P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uL() + text;
					P_2.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void b(ref string P_0, List<Setting> P_1, List<Setting> P_2)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			Enumerator<Setting> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (P_2.Contains(current))
					{
						continue;
					}
					if (!flag)
					{
						if (!string.IsNullOrWhiteSpace(P_0))
						{
							P_0 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
						}
						P_0 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.um();
						flag = true;
					}
					string text = ((SettingOrSpecialObject)current).A(bz.aYt);
					if (string.IsNullOrWhiteSpace(text))
					{
						text = ((SettingOrSpecialObject)current).B();
					}
					P_0 = P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uL() + text;
					P_2.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			Vh.b(new EventHandler(a));
			if (disposing && VG != null)
			{
				((System.IDisposable)VG).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected O, but got Unknown
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected O, but got Unknown
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Expected O, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected O, but got Unknown
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected O, but got Unknown
			Vg = new ThemedButton();
			VH = new ThemedButton();
			Vh = new aG();
			((Control)this).SuspendLayout();
			((Button)Vg).DialogResult = (DialogResult)1;
			((Control)Vg).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9.5f);
			((Control)Vg).Location = new Point(896, 577);
			((Control)Vg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)Vg).Size = new Size(135, 36);
			((Control)Vg).TabIndex = 5;
			((Control)Vg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)Vg).UseVisualStyleBackColor = true;
			((Button)VH).DialogResult = (DialogResult)2;
			((Control)VH).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9.5f);
			((Control)VH).Location = new Point(1040, 577);
			((Control)VH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)VH).Size = new Size(135, 36);
			((Control)VH).TabIndex = 6;
			((Control)VH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)VH).UseVisualStyleBackColor = true;
			((Control)Vh).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)Vh).Location = new Point(0, 0);
			((Control)Vh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uN();
			((Control)Vh).Size = new Size(1184, 621);
			((Form)this).AcceptButton = (IButtonControl)(object)Vg;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)VH;
			((Form)this).ClientSize = new Size(1184, 621);
			((Control)this).Controls.Add((Control)(object)VH);
			((Control)this).Controls.Add((Control)(object)Vg);
			((Control)this).Controls.Add((Control)(object)Vh);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.un();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uO();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).Resize += new EventHandler(B);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Br : Form
	{
		private IContainer VI;

		private TreeViewWithThemedScrollBars Vi;

		private ThemedTextBox VJ;

		private ThemedTextBox Vj;

		private Label VK;

		private Label Vk;

		private Label VL;

		private ThemedButton Vl;

		private ThemedButton VM;

		private Label Vm;

		private ThemedButton VN;

		internal Br()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			a();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					((val is Label) ? val : null).ForeColor = BM.te;
				}
				if (val is TreeViewWithThemedScrollBars)
				{
					((Control)(val as TreeViewWithThemedScrollBars)).BackColor = BM.tg;
					((Control)(val as TreeViewWithThemedScrollBars)).ForeColor = BM.te;
				}
			}
			((Control)VJ).BackColor = BM.to;
			((Control)VJ).ForeColor = BM.te;
			((Control)Vj).BackColor = BM.to;
			((Control)Vj).ForeColor = BM.te;
			if (BM.Qz.B())
			{
				((Control)VM).Enabled = true;
				((Control)VL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uo();
			}
			else
			{
				((Control)VM).Enabled = false;
				((Control)VL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uP();
			}
			if (BM.Qz.A(9496) != null)
			{
				A();
			}
			BM.C(new EventHandler(b));
		}

		private void A()
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			Vi.b();
			Enumerator<MenuNode> enumerator = BM.Qz.awj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					A(current, null);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Vi.C();
			Vi.I();
		}

		private void A(MenuNode P_0, TreeNode P_1)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_038d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			string text = P_0.E();
			int num = P_0.b();
			int num2 = P_0.H();
			TreeNode val = new TreeNode(text);
			val.Tag = P_0;
			val.ForeColor = BM.te;
			SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(num);
			SettingOrSpecialObject settingOrSpecialObject2 = BM.Qz.a(num2);
			if (settingOrSpecialObject != null && (settingOrSpecialObject.J().Count != 0 || settingOrSpecialObject.K().A().Count != 0))
			{
				return;
			}
			bool flag = false;
			if (P_0.h() != 0)
			{
				Setting setting = BM.Qz.A(P_0.h());
				if (setting != null)
				{
					if (setting.am() && setting.ax() == 0)
					{
						return;
					}
					A(setting, val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lz(), ref flag);
				}
			}
			Enumerator<MenuNode> enumerator = P_0.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					A(current, val);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (val.GetNodeCount(true) == 0 && settingOrSpecialObject == null && settingOrSpecialObject2 == null && P_0.h() == 0 && P_0.aE().Count == 0)
			{
				return;
			}
			if (P_0.C() != null && P_0.C().h() == 0 && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count != 0)
			{
				bool flag2 = true;
				Enumerator<UIListSettingDataIdAndIndent> enumerator2 = (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						UIListSettingDataIdAndIndent current2 = enumerator2.Current;
						if (!BM.Qz.aWZ.Contains(current2.DataId))
						{
							flag2 = false;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				if (flag2)
				{
					return;
				}
			}
			bool skipThisTreeNode = false;
			if (settingOrSpecialObject2 != null)
			{
				List<Do> val2 = new List<Do>();
				PortFunction.A(settingOrSpecialObject2, false, true, val2);
				Enumerator<Do> enumerator3 = val2.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						Do current3 = enumerator3.Current;
						A(current3, val, null, ref flag);
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
				List<Dn> val3 = new List<Dn>();
				PortFunction.A(settingOrSpecialObject2, false, val3, true);
				Enumerator<Dn> enumerator4 = val3.GetEnumerator();
				try
				{
					while (enumerator4.MoveNext())
					{
						Dn current4 = enumerator4.Current;
						if (!current4.am())
						{
							A(current4, val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ku(), ref flag);
						}
						List<Setting> val4 = new List<Setting>();
						PortFunction.A(current4, val4, false);
						Enumerator<Setting> enumerator5 = val4.GetEnumerator();
						try
						{
							while (enumerator5.MoveNext())
							{
								Setting current5 = enumerator5.Current;
								A(current5, val, null, ref flag);
							}
						}
						finally
						{
							((System.IDisposable)enumerator5).Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator4).Dispose();
				}
			}
			else if (settingOrSpecialObject != null)
			{
				CG cG = settingOrSpecialObject.e();
				if (cG != null)
				{
					cG.InitPasswordProtectionNode(val, ref skipThisTreeNode);
					if (!skipThisTreeNode)
					{
						flag = true;
					}
				}
				else if (settingOrSpecialObject.a().Count != 0)
				{
					if (settingOrSpecialObject is SpecialObject && !(settingOrSpecialObject as SpecialObject).b().EachListRowIsAnObject())
					{
						Enumerator<SettingOrSpecialObject> enumerator6 = settingOrSpecialObject.a().GetEnumerator();
						try
						{
							while (enumerator6.MoveNext())
							{
								SettingOrSpecialObject current6 = enumerator6.Current;
								if (current6 is Setting)
								{
									Setting setting2 = current6 as Setting;
									if (!setting2.am() && !setting2.al() && !setting2.aN() && !BM.Qz.aWZ.Contains(setting2.A()))
									{
										A(setting2, val, null, ref flag);
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator6).Dispose();
						}
					}
					Enumerator<string> enumerator7 = settingOrSpecialObject.Q().GetEnumerator();
					try
					{
						while (enumerator7.MoveNext())
						{
							string current7 = enumerator7.Current;
							if (!BM.Qz.aWv.ContainsKey(current7))
							{
								continue;
							}
							Enumerator<SettingOrSpecialObject> enumerator6 = ((SettingOrSpecialObject)BM.Qz.aWv[current7]).a().GetEnumerator();
							try
							{
								while (enumerator6.MoveNext())
								{
									SettingOrSpecialObject current8 = enumerator6.Current;
									if (!(current8 is Setting))
									{
										continue;
									}
									Setting setting3 = current8 as Setting;
									if (((SettingOrSpecialObject)setting3).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kW())
									{
										if (!setting3.am())
										{
											A(setting3, val, null, ref flag);
										}
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator6).Dispose();
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator7).Dispose();
					}
				}
			}
			Enumerator<int> enumerator8 = P_0.aE().GetEnumerator();
			try
			{
				while (enumerator8.MoveNext())
				{
					int current9 = enumerator8.Current;
					Setting setting4 = BM.Qz.A(current9);
					if (setting4 != null)
					{
						A(setting4, val, null, ref flag);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator8).Dispose();
			}
			if (val.GetNodeCount(true) == 0 && !flag)
			{
				skipThisTreeNode = true;
			}
			if (!skipThisTreeNode)
			{
				if (P_1 != null)
				{
					P_1.Nodes.Add(val);
					return;
				}
				val.Expand();
				Vi.a().Add(val);
			}
		}

		private void A(Setting P_0, TreeNode P_1, string P_2, ref bool P_3)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			string text = ((!string.IsNullOrEmpty(P_2)) ? (((SettingOrSpecialObject)P_0).A(true) + P_2) : ((SettingOrSpecialObject)P_0).A(true));
			TreeNode val = new TreeNode(text);
			val.Checked = P_0.J();
			val.ForeColor = BM.te;
			val.Tag = P_0;
			P_1.Nodes.Add(val);
			P_3 = true;
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz.B())
			{
				if (((Control)VJ).Text == null || ((Control)VJ).Text.Length == 0)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.up(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (((Control)VJ).Text != ((Control)Vj).Text)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (!BM.Qz.b(((Control)VJ).Text))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uq(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
			}
			else
			{
				if (((Control)VJ).Text == null || ((Control)VJ).Text.Length == 0)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uR(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (((Control)VJ).Text != ((Control)Vj).Text)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
			}
			BM.d();
			if (BM.Qz.A(9496) != null)
			{
				A(Vi.a());
			}
			BM.Qz.C(((Control)VJ).Text);
			BM.a(false);
			((Form)this).Close();
		}

		private void A(List<TreeNode> P_0)
		{
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			for (int i = 0; i < P_0.Count; i++)
			{
				TreeNode val = P_0[i];
				if (val.Tag is Setting)
				{
					(val.Tag as Setting).c(val.Checked);
				}
				else if (val.Tag is MenuNode)
				{
					MenuNode menuNode = val.Tag as MenuNode;
					int num = menuNode.b();
					SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(num);
					if (BM.Qz.a(menuNode.H()) == null)
					{
						settingOrSpecialObject?.e()?.UpdateSettingsIncludedInPasswordProtection(val);
					}
					if (menuNode.x())
					{
						BM.Qz.A(menuNode.W())?.c(val.Checked);
					}
				}
				List<TreeNode> val2 = new List<TreeNode>();
				foreach (TreeNode node in val.Nodes)
				{
					TreeNode val3 = node;
					val2.Add(val3);
				}
				A(val2);
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)VJ).Text == null || ((Control)VJ).Text.Length == 0)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ur(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (((Control)VJ).Text != ((Control)Vj).Text)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (!BM.Qz.b(((Control)VJ).Text))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.us(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			BM.d();
			BM.Qz.n();
			BM.a(false);
			((Form)this).Close();
		}

		private void B(object P_0, EventArgs P_1)
		{
			bool visible = BM.Qz.A(9496) != null;
			((Control)Vm).Visible = visible;
			((Control)VJ).Focus();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			BM.c(new EventHandler(b));
		}

		private void b(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && VI != null)
			{
				((System.IDisposable)VI).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0354: Expected O, but got Unknown
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Expected O, but got Unknown
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Expected O, but got Unknown
			//IL_0605: Unknown result type (might be due to invalid IL or missing references)
			//IL_060f: Expected O, but got Unknown
			//IL_0617: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Expected O, but got Unknown
			VJ = new ThemedTextBox();
			Vj = new ThemedTextBox();
			VK = new Label();
			Vk = new Label();
			VL = new Label();
			Vl = new ThemedButton();
			VM = new ThemedButton();
			Vm = new Label();
			VN = new ThemedButton();
			Vi = new TreeViewWithThemedScrollBars();
			((Control)this).SuspendLayout();
			((Control)VJ).Location = new Point(120, 33);
			((TextBoxBase)VJ).MaxLength = 100;
			((Control)VJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uT();
			((TextBox)VJ).PasswordChar = '*';
			((Control)VJ).Size = new Size(452, 22);
			((Control)VJ).TabIndex = 1;
			((Control)Vj).Location = new Point(120, 59);
			((TextBoxBase)Vj).MaxLength = 100;
			((Control)Vj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ut();
			((TextBox)Vj).PasswordChar = '*';
			((Control)Vj).Size = new Size(452, 22);
			((Control)Vj).TabIndex = 2;
			((Control)VK).AutoSize = true;
			((Control)VK).Location = new Point(12, 36);
			((Control)VK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uU();
			((Control)VK).Size = new Size(90, 13);
			((Control)VK).TabIndex = 3;
			((Control)VK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uu();
			((Control)Vk).AutoSize = true;
			((Control)Vk).Location = new Point(12, 62);
			((Control)Vk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uV();
			((Control)Vk).Size = new Size(107, 13);
			((Control)Vk).TabIndex = 4;
			((Control)Vk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uv();
			((Control)VL).AutoSize = true;
			((Control)VL).Location = new Point(12, 9);
			((Control)VL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uW();
			((Control)VL).Size = new Size(115, 13);
			((Control)VL).TabIndex = 5;
			((Control)VL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uw();
			((Button)Vl).DialogResult = (DialogResult)2;
			((Control)Vl).Location = new Point(472, 594);
			((Control)Vl).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)Vl).Size = new Size(100, 38);
			((Control)Vl).TabIndex = 7;
			((Control)Vl).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)Vl).UseVisualStyleBackColor = true;
			((Control)VM).Enabled = false;
			((Control)VM).Location = new Point(316, 594);
			((Control)VM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uX();
			((Control)VM).Size = new Size(139, 38);
			((Control)VM).TabIndex = 6;
			((Control)VM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ux();
			((ButtonBase)VM).UseVisualStyleBackColor = true;
			((Control)VM).Click += new EventHandler(a);
			((Control)Vm).AutoSize = true;
			((Control)Vm).Location = new Point(12, 101);
			((Control)Vm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)Vm).Size = new Size(291, 13);
			((Control)Vm).TabIndex = 8;
			((Control)Vm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uY();
			((Control)VN).Location = new Point(151, 594);
			((Control)VN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uy();
			((Control)VN).Size = new Size(159, 38);
			((Control)VN).TabIndex = 9;
			((Control)VN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uZ();
			((ButtonBase)VN).UseVisualStyleBackColor = true;
			((Control)VN).Click += new EventHandler(A);
			((ScrollableControl)Vi).AutoScroll = true;
			Vi.A(true);
			Vi.A(aW.kP);
			Vi.A((List<Image>)null);
			((Control)Vi).Location = new Point(12, 117);
			((Control)Vi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uz();
			Vi.A((TreeNode)null);
			((Control)Vi).Size = new Size(560, 468);
			((Control)Vi).TabIndex = 0;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)Vl;
			((Form)this).ClientSize = new Size(584, 642);
			((Control)this).Controls.Add((Control)(object)VN);
			((Control)this).Controls.Add((Control)(object)Vm);
			((Control)this).Controls.Add((Control)(object)Vl);
			((Control)this).Controls.Add((Control)(object)VM);
			((Control)this).Controls.Add((Control)(object)VL);
			((Control)this).Controls.Add((Control)(object)Vk);
			((Control)this).Controls.Add((Control)(object)VK);
			((Control)this).Controls.Add((Control)(object)Vj);
			((Control)this).Controls.Add((Control)(object)VJ);
			((Control)this).Controls.Add((Control)(object)Vi);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VA();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ph();
			((Form)this).Shown += new EventHandler(B);
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal enum bR
	{
		aCt,
		aCU
	}
	internal enum br
	{
		aCu,
		aCV
	}
}
