using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace B
{
	internal class BI : Form
	{
		private List<CY> ov;

		private List<CY> oW;

		private F ow;

		private k oX;

		private k ox;

		private k oY;

		private Framework oy;

		private byte[] oZ;

		private Dictionary<bt, string> oz = new Dictionary<bt, string>();

		private string PA;

		private string Pa;

		private bt PB;

		private bool Pb;

		private Dictionary<bt, k> PC = new Dictionary<bt, k>();

		private Dictionary<bt, k> Pc = new Dictionary<bt, k>();

		private Dictionary<bt, bool> PD = new Dictionary<bt, bool>();

		private List<aP> Pd = new List<aP>();

		private int PE;

		private int Pe;

		private IContainer PF;

		private TreeViewWithThemedScrollBars Pf;

		private Label PG;

		private Label Pg;

		private Label PH;

		private Label Ph;

		private ThemedButton PI;

		private ThemedButton Pi;

		private ThemedButton PJ;

		private ProgressBar Pj;

		private ThemedComboBox PK;

		private aq Pk;

		private Label PL;

		internal BI(List<CY> P_0, List<CY> P_1, F P_2, k P_3, k P_4, string P_5)
		{
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			d();
			A();
			ov = P_0;
			oW = P_1;
			ow = P_2;
			oX = P_3;
			ox = P_4;
			Pa = P_5;
			if (CZ.A(ow, true))
			{
				((Control)Pg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kf();
			}
			else
			{
				((Control)Pg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kG() + (object)oX;
			}
			Pf.A(new DrawTreeNodeEventHandler(A));
			PE = ((Control)Pf).Bottom;
			Pe = ((Control)Pf).Height;
			b();
			Enumerator<MenuNode> enumerator = BM.ST.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					bu bu = enumerator.Current.B();
					if (CZ.A(bu.A()))
					{
						A(bu);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			((Control)PL).Visible = ow.aH != 21;
		}

		internal BI(List<CY> P_0, F P_1, bt P_2, k P_3, bool P_4)
		{
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			d();
			A();
			ov = P_0;
			PB = P_2;
			Pb = P_4;
			PC.Add(P_2, P_3);
			PD.Add(P_2, P_4);
			ow = P_1;
			oX = P_3;
			((Control)Pg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kG() + (object)oX;
			Pf.A(new DrawTreeNodeEventHandler(A));
			b();
			((Control)PL).Visible = ow.aH != 21;
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			if (PB == bt.avK && ow.aH != 22)
			{
				B();
			}
			a();
			BM.C(new EventHandler(C));
		}

		private void A()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					((val is Label) ? val : null).ForeColor = BM.te;
				}
			}
			((Control)Pf).BackColor = BM.tg;
			((Control)Pf).ForeColor = BM.te;
			((Control)Pk).BackColor = BM.tH;
			((Control)Pk).ForeColor = BM.te;
		}

		private void a()
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected O, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			while (((TabControl)Pk).TabCount != 0)
			{
				q.A((Control)(object)((TabControl)Pk).TabPages[0]);
			}
			((Control)Pk).Top = ((Control)Pf).Top;
			((Control)Pk).Height = ((Control)Pf).Height;
			string text = ((PB != 0) ? (bu.B(PB) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kg()) : (bx.b(ow.aH, ow.ah) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kg()));
			TabPage val = new TabPage(text);
			((Panel)val).BorderStyle = (BorderStyle)0;
			((Control)val).BackColor = BM.tH;
			ag ag = new ag();
			((TextBoxBase)ag).BorderStyle = (BorderStyle)0;
			((Control)ag).BackColor = BM.tH;
			((Control)ag).ForeColor = BM.te;
			((Control)val).Controls.Add((Control)(object)ag);
			((TabControl)Pk).TabPages.Add(val);
			((Control)ag).Width = ((Control)val).Width;
			((Control)ag).Height = ((Control)val).Height;
			ag.A();
			((Control)ag).Invalidate();
			((Control)val).Invalidate();
			if (PB == bt.avK)
			{
				Enumerator<aP> enumerator = Pd.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						aP current = enumerator.Current;
						if (((Control)current).Visible)
						{
							bu bu = (bu)(((Control)current).Tag as List<object>)[0];
							TabPage val2 = new TabPage(bu.g() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kg());
							((Control)val2).Tag = bu;
							((Panel)val2).BorderStyle = (BorderStyle)0;
							((Control)val2).BackColor = BM.tH;
							ag ag2 = new ag();
							((TextBoxBase)ag2).BorderStyle = (BorderStyle)0;
							((Control)ag2).BackColor = BM.tH;
							((Control)ag2).ForeColor = BM.te;
							((Control)val2).Controls.Add((Control)(object)ag2);
							((TabControl)Pk).TabPages.Add(val2);
							((Control)ag2).Width = ((Control)val2).Width;
							((Control)ag2).Height = ((Control)val2).Height;
							ag2.A();
							((Control)ag2).Invalidate();
							((Control)val2).Invalidate();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			((TabControl)Pk).SelectedIndex = 0;
			((Control)Pk).Invalidate();
		}

		private void A(bu P_0)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			aP aP = new aP();
			((Control)aP).BackColor = ((Control)this).BackColor;
			((Control)aP).ForeColor = BM.te;
			List<object> obj = new List<object>();
			obj.Add((object)P_0);
			obj.Add((object)null);
			((Control)aP).Tag = obj;
			((Control)aP).AutoSize = false;
			((Control)aP).Width = ((Control)this).Width - 50;
			((Control)aP).Height = (int)((float)((Control)aP).Height * 0.75f);
			((Control)aP).Left = ((Control)PH).Left;
			((Control)aP).Visible = false;
			((CheckBox)aP).CheckedChanged += new EventHandler(a);
			Pd.Add(aP);
			((Control)this).Controls.Add((Control)(object)aP);
		}

		private void a(object P_0, EventArgs P_1)
		{
			aP obj = P_0 as aP;
			bu bu = (bu)(((Control)obj).Tag as List<object>)[0];
			k k = bu.a();
			k k2 = (k)(((Control)obj).Tag as List<object>)[1];
			if (((CheckBox)obj).Checked)
			{
				if (!PC.ContainsKey(bu.A()))
				{
					PC.Add(bu.A(), k);
				}
				if (!PD.ContainsKey(bu.A()))
				{
					PD.Add(bu.A(), bu.E());
				}
				Pc[bu.A()] = k2;
				return;
			}
			if (PC.ContainsKey(bu.A()))
			{
				PC.Remove(bu.A());
			}
			if (PD.ContainsKey(bu.A()))
			{
				PD.Remove(bu.A());
			}
			if (Pc.ContainsKey(bu.A()))
			{
				Pc.Remove(bu.A());
			}
		}

		private void B()
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			if (PB != 0 || ow.aH == 22)
			{
				return;
			}
			PC.Clear();
			PD.Clear();
			Pc.Clear();
			Enumerator<aP> enumerator;
			if (CZ.A(ow, true))
			{
				enumerator = Pd.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						aP current = enumerator.Current;
						((CheckBox)current).Checked = false;
						((Control)current).Visible = false;
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			else if (((ComboBox)PK).Items.Count != 0 && ((ListControl)PK).SelectedIndex >= 0 && PA != null)
			{
				List<Cw> val = CZ.A(PA);
				Enumerator<MenuNode> enumerator2 = BM.ST.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						bu bu = enumerator2.Current.B();
						aP aP = null;
						enumerator = Pd.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								aP current2 = enumerator.Current;
								if (((bu)(((Control)current2).Tag as List<object>)[0]).A() == bu.A())
								{
									aP = current2;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						if ((CZ.A(ow.aH, ow.ah, oY) && CZ.A(bu.A())) || bu.A() == bt.avU || bu.A() == bt.avu || bu.A() == bt.avV || bu.A() == bt.avv)
						{
							bool flag = false;
							Enumerator<Cw> enumerator3 = val.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									Cw current3 = enumerator3.Current;
									k bdB = current3.BdB;
									if (current3.Bda != bu.A() || !CZ.A(bu.A(), bu.a(), bdB, bu.E()))
									{
										continue;
									}
									flag = true;
									if (aP == null)
									{
										break;
									}
									if (bu.c() && bu.D())
									{
										if (bu.a() != bdB)
										{
											((Control)aP).Text = string.Concat(new string[7]
											{
												D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kH(),
												bu.g(),
												D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kh(),
												((object)bu.a())?.ToString(),
												D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kI(),
												((object)bdB)?.ToString(),
												D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
											});
											(((Control)aP).Tag as List<object>)[1] = bdB;
											((Control)aP).Visible = true;
											((CheckBox)aP).Checked = true;
										}
										else
										{
											((CheckBox)aP).Checked = false;
											((Control)aP).Visible = false;
										}
									}
									else
									{
										((CheckBox)aP).Checked = false;
										((Control)aP).Visible = false;
									}
									break;
								}
							}
							finally
							{
								((System.IDisposable)enumerator3).Dispose();
							}
							if (!flag && (bu.A() == bt.avU || bu.A() == bt.avu || bu.A() == bt.avV || bu.A() == bt.avv) && oW != null && oW.Count != 0)
							{
								flag = true;
								if (aP != null)
								{
									if (bu.D())
									{
										k axT = oW[0].BdF[0].BdC.axT;
										if (bu.a() != axT)
										{
											k k = CZ.A(true);
											k k2 = CZ.A(false);
											bool flag2 = false;
											if (bu.E())
											{
												if (bu.a() >= k && axT < k2)
												{
													flag2 = true;
												}
											}
											else if (bu.a() >= k2 && axT < k2)
											{
												flag2 = true;
											}
											if (flag2)
											{
												((CheckBox)aP).Checked = false;
												((Control)aP).Visible = false;
											}
											else
											{
												((Control)aP).Text = string.Concat(new string[7]
												{
													D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kH(),
													bu.g(),
													D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kh(),
													((object)bu.a())?.ToString(),
													D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kI(),
													((object)axT)?.ToString(),
													D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
												});
												(((Control)aP).Tag as List<object>)[1] = axT;
												((Control)aP).Visible = true;
												((CheckBox)aP).Checked = true;
											}
										}
										else
										{
											((CheckBox)aP).Checked = false;
											((Control)aP).Visible = false;
										}
									}
									else
									{
										((CheckBox)aP).Checked = false;
										((Control)aP).Visible = false;
									}
								}
							}
							if (!flag && aP != null)
							{
								((CheckBox)aP).Checked = false;
								((Control)aP).Visible = false;
							}
						}
						else if (aP != null)
						{
							((CheckBox)aP).Checked = false;
							((Control)aP).Visible = false;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			else
			{
				enumerator = Pd.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						aP current4 = enumerator.Current;
						((CheckBox)current4).Checked = false;
						((Control)current4).Visible = false;
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			int num = 0;
			enumerator = Pd.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (((Control)enumerator.Current).Visible)
					{
						num++;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			A(num);
		}

		private void A(int P_0)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 == 0)
			{
				((Control)Pf).Height = Pe;
			}
			else
			{
				int num = P_0 * ((Control)Pd[0]).Height;
				num -= ((Control)Pi).Height;
				if (num < 0)
				{
					num = 0;
				}
				((Control)Pf).Height = Pe - (10 + num);
				int num2 = 0;
				Enumerator<aP> enumerator = Pd.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						aP current = enumerator.Current;
						if (((Control)current).Visible)
						{
							((Control)current).Top = ((Control)Pf).Top + ((Control)Pf).Height + 10 + num2 * ((Control)current).Height;
							num2++;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			((Control)Pf).Invalidate();
			Pf.I();
		}

		private void b()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			((ComboBox)PK).Items.Clear();
			((ListControl)PK).SelectedIndex = -1;
			if (ov.Count == 0)
			{
				return;
			}
			Enumerator<CY> enumerator = ov.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CY current = enumerator.Current;
					if (PB == bt.avK)
					{
						k k = current.A(ow.aH, ow.ah);
						if (k != null)
						{
							((ComboBox)PK).Items.Add((object)((object)k).ToString());
						}
						else
						{
							((ComboBox)PK).Items.Add((object)((object)current.BdF[0].BdC.axT).ToString());
						}
					}
					else
					{
						Cx cx = CZ.A(current.Bdf, PB, oX, Pb);
						if (cx != null)
						{
							((ComboBox)PK).Items.Add((object)((object)cx.Bdd).ToString());
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			k k2 = null;
			if (PB == bt.avK)
			{
				k k3 = ov[0].A(ow.aH, ow.ah);
				k2 = ((!(k3 != null)) ? ov[0].BdF[0].BdC.axT : k3);
			}
			else
			{
				Cx cx2 = CZ.A(ov[0].Bdf, PB, oX, Pb);
				if (cx2 != null)
				{
					k2 = cx2.Bdd;
				}
			}
			if (k2 != null && k2 > oX)
			{
				((ListControl)PK).SelectedIndex = 0;
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			if (((ComboBox)PK).Items.Count == 0 || ((ListControl)PK).SelectedIndex < 0)
			{
				return;
			}
			CY cY = ov[((ListControl)PK).SelectedIndex];
			PA = cY.BdE;
			List<CW> val = null;
			if (PB == bt.avK)
			{
				val = CZ.a(PA);
			}
			List<Cw> val2 = CZ.A(PA);
			oz.Clear();
			if (PB == bt.avK)
			{
				int aH = ow.aH;
				int num = ow.ah;
				if (aH == 22 && num == 14)
				{
					num = 13;
				}
				else if (aH == 22 && num == 14)
				{
					num = 20;
				}
				oY = cY.BdF[0].BdC.axT;
				oz.Add(bt.avK, val[0].BDz);
				oZ = null;
				for (int i = 0; i < cY.BdF.Count; i++)
				{
					CX cX = cY.BdF[i];
					if (cX.BdC.axS == aH && cX.BdC.axs == num)
					{
						oY = cX.BdC.axT;
						oZ = cX.BdC.axt;
						if (i < val.Count && !string.IsNullOrEmpty(val[i].BDz))
						{
							oz[bt.avK] = val[i].BDz;
						}
						break;
					}
				}
				Enumerator<MenuNode> enumerator = BM.ST.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						bu bu = enumerator.Current.B();
						bool flag = false;
						Enumerator<Cw> enumerator2 = val2.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								Cw current = enumerator2.Current;
								if (current.Bda == bu.A() && CZ.A(bu.A(), bu.a(), current.BdB, bu.E()))
								{
									oz.Add(bu.A(), current.Bdb);
									flag = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
						if (!flag && (bu.A() == bt.avU || bu.A() == bt.avu || bu.A() == bt.avV || bu.A() == bt.avv) && oW != null && oW.Count != 0)
						{
							List<CW> val3 = CZ.a(oW[0].BdE);
							if (val3 != null && val3.Count != 0)
							{
								oz.Add(bu.A(), val3[0].BDz);
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
				Enumerator<Cw> enumerator2 = val2.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Cw current2 = enumerator2.Current;
						if (current2.Bda == PB && CZ.A(PB, oX, current2.BdB, Pb))
						{
							oY = current2.BdB;
							oz.Add(PB, current2.Bdb);
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			((Control)Pi).Enabled = true;
			C();
			if (PB == bt.avK && ow.aH != 22)
			{
				B();
			}
			a();
		}

		private void b(object P_0, EventArgs P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Invalid comparison between Unknown and I4
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0379: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Invalid comparison between Unknown and I4
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).InitialDirectory = CZ.Bdl;
			((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ki();
			((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kJ();
			if (Directory.Exists(((FileDialog)val).InitialDirectory))
			{
				string[] files = Directory.GetFiles(((FileDialog)val).InitialDirectory);
				foreach (string text in files)
				{
					if (Path.GetFileName(text) == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kj())
					{
						((FileDialog)val).FileName = text;
						break;
					}
				}
			}
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
			{
				string fileName = ((FileDialog)val).FileName;
				((Component)val).Dispose();
				List<CW> val2 = CZ.a(fileName);
				List<Cw> val3 = CZ.A(fileName);
				CY cY = CZ.A(fileName, val2, val3);
				if (cY.BdF.Count == 0 && cY.Bdf.Count == 0)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kK(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				CX cX = null;
				if (cY.BdF.Count == 0 && PB != 0 && cY.Bdf.Count != 0)
				{
					if (CZ.A(cY.Bdf, PB, oX, Pb) != null)
					{
						flag4 = true;
					}
					flag = true;
					flag2 = true;
					flag3 = true;
				}
				else
				{
					Enumerator<CX> enumerator = cY.BdF.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CX current = enumerator.Current;
							bool flag5 = false;
							flag5 = current.BdC != null && (current.BdC.axs == ow.ah || current.BdC.axS == 22);
							if (!(current.BdC != null && current.BdC.axS == ow.aH && flag5))
							{
								continue;
							}
							flag = true;
							if (ox == null || current.BdC.axT >= ox)
							{
								flag2 = true;
								if (CZ.b(ow.ao) || current.Bdc.Contains(ow.aJ))
								{
									flag3 = true;
									cX = current;
									break;
								}
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					if (PB != 0 && flag && flag2 && flag3 && CZ.A(cY.Bdf, PB, oX, Pb) != null)
					{
						flag4 = true;
					}
				}
				string text2;
				bool flag6;
				if (!flag)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kk(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (!flag2 || !flag3)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kL(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (PB != 0 && !flag4)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kl(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (cX != null && Ct.A(cX, out text2, out flag6))
				{
					string text3 = (string.IsNullOrEmpty(text2) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.km() : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kM() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()));
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kN() + text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kn(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (cX != null && !bg.a() && !cX.BdC.axT.d())
				{
					string text4 = cX.BdC.axT.D();
					if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kO() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ko(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kP(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 1)
					{
						bg bg = new bg();
						((Form)bg).ShowDialog((IWin32Window)(object)this);
						((Component)bg).Dispose();
						if (bg.a())
						{
							A(fileName, cY);
						}
					}
				}
				else
				{
					A(fileName, cY);
				}
			}
			else
			{
				((Component)val).Dispose();
			}
		}

		private void A(string P_0, CY P_1)
		{
			if (ov.Count == ((ComboBox)PK).Items.Count)
			{
				for (int i = 0; i < ov.Count; i++)
				{
					if (PB == bt.avK)
					{
						if (ov[i].BdF[0].BdC.axT == P_1.BdF[0].BdC.axT)
						{
							((ListControl)PK).SelectedIndex = i;
							PA = P_0;
							CZ.B(P_0);
							return;
						}
						continue;
					}
					Cx cx = CZ.A(ov[i].Bdf, PB, oX, Pb);
					Cx cx2 = CZ.A(P_1.Bdf, PB, oX, Pb);
					if (cx != null && cx2 != null && cx.Bdd == cx2.Bdd)
					{
						((ListControl)PK).SelectedIndex = i;
						PA = P_0;
						CZ.B(P_0);
						return;
					}
				}
			}
			a(P_0, P_1);
		}

		private void a(string P_0, CY P_1)
		{
			((ListControl)PK).SelectedIndex = -1;
			if (ov.Count != ((ComboBox)PK).Items.Count)
			{
				return;
			}
			k k = null;
			if (PB == bt.avK)
			{
				k k2 = P_1.A(ow.aH, ow.ah);
				k = ((!(k2 != null)) ? P_1.BdF[0].BdC.axT : k2);
			}
			else
			{
				Cx cx = CZ.A(P_1.Bdf, PB, oX, Pb);
				if (cx != null)
				{
					k = cx.Bdd;
				}
			}
			if (!(k != null))
			{
				return;
			}
			if (ov.Count == 0)
			{
				ov.Add(P_1);
				((ComboBox)PK).Items.Add((object)((object)k).ToString());
				((ListControl)PK).SelectedIndex = 0;
				PA = P_0;
				return;
			}
			for (int i = 0; i < ov.Count; i++)
			{
				k k3 = null;
				if (PB == bt.avK)
				{
					k k4 = ov[i].A(ow.aH, ow.ah);
					k3 = ((!(k4 != null)) ? ov[i].BdF[0].BdC.axT : k4);
				}
				else
				{
					Cx cx2 = CZ.A(ov[i].Bdf, PB, oX, Pb);
					if (cx2 != null)
					{
						k3 = cx2.Bdd;
					}
				}
				if (k3 != null)
				{
					if (k > k3)
					{
						ov.Insert(i, P_1);
						((ComboBox)PK).Items.Insert(i, (object)((object)k).ToString());
						((ListControl)PK).SelectedIndex = i;
						PA = P_0;
						break;
					}
					if (i == ov.Count - 1)
					{
						ov.Add(P_1);
						((ComboBox)PK).Items.Add((object)((object)k).ToString());
						((ListControl)PK).SelectedIndex = ((ComboBox)PK).Items.Count - 1;
						PA = P_0;
						break;
					}
				}
			}
		}

		private void C()
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			Pj.Value = 0;
			((Control)Pj).Visible = true;
			((Control)Pj).BringToFront();
			Pf.a().Clear();
			((Control)Pf).Invalidate();
			Pf.I();
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.ProgressChanged += new ProgressChangedEventHandler(A);
			val.DoWork += new DoWorkEventHandler(A);
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
			val.RunWorkerAsync();
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			if (oY != null && oZ != null && PB == bt.avK && !CZ.A(ow, true))
			{
				if (ow.aH == 22)
				{
					P_1.Result = null;
				}
				else
				{
					string text = bT.A(ow.aH, ow.ah, oY, oZ, true);
					val.ReportProgress(30);
					if (!string.IsNullOrEmpty(text))
					{
						Framework framework = new Framework(text, ow.aH, ow.ah, oY);
						val.ReportProgress(50);
						if (framework.a() == bV.A.Brc)
						{
							P_1.Result = framework;
						}
						else
						{
							P_1.Result = null;
						}
						val.ReportProgress(90);
						Thread.Sleep(100);
					}
					else
					{
						P_1.Result = null;
					}
				}
			}
			else
			{
				val.ReportProgress(50);
				Thread.Sleep(100);
				val.ReportProgress(100);
				Thread.Sleep(500);
				P_1.Result = null;
			}
			val.ReportProgress(100);
		}

		private void A(object P_0, ProgressChangedEventArgs P_1)
		{
			Pj.Value = P_1.ProgressPercentage;
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			try
			{
				((Control)Pj).Visible = false;
			}
			catch
			{
			}
			if (P_1.Result != null)
			{
				oy = (Framework)P_1.Result;
			}
			else
			{
				oy = null;
			}
			if (P_1.Result == null && PB == bt.avK && ow.aH != 22)
			{
				return;
			}
			try
			{
				D();
				if (oy != null)
				{
					c();
				}
			}
			catch
			{
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0542: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_0526: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0447: Unknown result type (might be due to invalid IL or missing references)
			//IL_0451: Expected O, but got Unknown
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Invalid comparison between Unknown and I4
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Invalid comparison between Unknown and I4
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0477: Expected O, but got Unknown
			//IL_049d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a7: Expected O, but got Unknown
			//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d2: Invalid comparison between Unknown and I4
			if ((int)((Form)this).DialogResult != 1)
			{
				BM.c(new EventHandler(C));
				Enumerator<aP> enumerator = Pd.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						((CheckBox)enumerator.Current).CheckedChanged -= new EventHandler(a);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				Pf.a(new DrawTreeNodeEventHandler(A));
				oy = null;
			}
			else if (!string.IsNullOrEmpty(PA))
			{
				if (ox == null || oy == null || oy.aXA >= ox)
				{
					if (PC.Count != 0 && BM.Qz != null && BM.Qz.o())
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kp(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kQ(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						((CancelEventArgs)P_1).Cancel = true;
						return;
					}
					if (PB == bt.avK)
					{
						List<CW> val = CZ.a(PA);
						if (val.Count != 0 && val[0].BDy != null)
						{
							CX cX = new CX();
							cX.BdC = new bW
							{
								axS = ow.aH,
								axs = ow.ah,
								axT = val[0].BDy.axT
							};
							cX.Bdc = new List<ushort>();
							cX.Bdc.Add(ow.aJ);
							if (Ct.A(cX, out var text, out var _))
							{
								string text2 = (string.IsNullOrEmpty(text) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.km() : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kM() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()));
								if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kN() + text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kn(), (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
								{
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kq(),
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV()
								}) == 2)
								{
									((CancelEventArgs)P_1).Cancel = true;
									return;
								}
							}
							if (!cX.BdC.axT.d())
							{
								string text3 = cX.BdC.axT.D();
								if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kR() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kO() + text3, (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
								{
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kq(),
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV()
								}) == 2)
								{
									((CancelEventArgs)P_1).Cancel = true;
									return;
								}
							}
						}
					}
					bool flag2 = oy != null && BM.Qz != null && oy.aXA < BM.Qz.aXA;
					bool flag3 = false;
					bool flag4 = false;
					bool flag5 = false;
					if (PB == bt.avK)
					{
						bool flag6 = CZ.A(ow, true);
						if (oX != null && oY != null && ow.aH == 22)
						{
							k k = CZ.A(true);
							k k2 = CZ.A(false);
							if ((flag6 && oX < k && oY >= k2) || (!flag6 && oX < k2 && oY >= k2))
							{
								System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 3);
								defaultInterpolatedStringHandler.AppendFormatted<int>(k2.A());
								defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq());
								defaultInterpolatedStringHandler.AppendFormatted<int>(k2.a());
								defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq());
								defaultInterpolatedStringHandler.AppendFormatted<int>(k2.B());
								string text4 = defaultInterpolatedStringHandler.ToStringAndClear();
								if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kr() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 2)
								{
									((CancelEventArgs)P_1).Cancel = true;
									return;
								}
							}
						}
						flag3 = flag6;
						k k3 = ((oy != null) ? oy.aXA : null);
						flag4 = BM.A(ow, oX, k3, out flag5);
						if (flag5)
						{
							((CancelEventArgs)P_1).Cancel = true;
							return;
						}
						ca.A((IWin32Window)(object)this, ow, oX, oY, out flag5);
						if (flag5)
						{
							((CancelEventArgs)P_1).Cancel = true;
							return;
						}
					}
					BM.c(new EventHandler(C));
					Enumerator<aP> enumerator = Pd.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							((CheckBox)enumerator.Current).CheckedChanged -= new EventHandler(a);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					Pf.a(new DrawTreeNodeEventHandler(A));
					oy = null;
					CZ.A(ow, PA, flag2, false, flag3, Pa, flag4, false, PB, (PB != 0) ? oX : null, (PB != 0) ? oY : null, PB != 0 && Pb, PC, Pc, PD, true, null);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kL(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)P_1).Cancel = true;
				}
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kT(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		private void A(object P_0, DrawTreeNodeEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			Rectangle bounds = P_1.Bounds;
			if (((Rectangle)(ref bounds)).Y < -10)
			{
				return;
			}
			bounds = P_1.Bounds;
			if (((Rectangle)(ref bounds)).Y <= ((Control)Pf).Height)
			{
				Font font = ((Control)Pf).Font;
				SolidBrush val = new SolidBrush(((Control)Pf).BackColor);
				try
				{
					Graphics graphics = P_1.Graphics;
					bounds = P_1.Bounds;
					int right = ((Rectangle)(ref bounds)).Right;
					bounds = P_1.Bounds;
					int top = ((Rectangle)(ref bounds)).Top;
					int width = ((Control)Pf).Width;
					bounds = P_1.Bounds;
					int num = width - ((Rectangle)(ref bounds)).Right - 1;
					bounds = P_1.Bounds;
					graphics.FillRectangle((Brush)(object)val, right, top, num, ((Rectangle)(ref bounds)).Height);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				bounds = P_1.Bounds;
				int top2 = ((Rectangle)(ref bounds)).Top;
				int num2 = ((Control)Pf).Width - 450 - 1;
				bounds = P_1.Bounds;
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(450, top2, num2, ((Rectangle)(ref bounds)).Height);
				if (P_1.Node.Tag != null && P_1.Node.Tag is string)
				{
					TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, P_1.Node.Tag as string, font, val2, P_1.Node.ForeColor, (TextFormatFlags)2048);
				}
			}
		}

		private void c()
		{
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			Pf.a().Clear();
			((Control)Pf).Invalidate();
			if (BM.Qz == null || oy == null)
			{
				return;
			}
			Pf.b();
			if (oy.aXA > BM.Qz.aXA)
			{
				new List<int>();
				Enumerator<MenuNode> enumerator = oy.awj.GetEnumerator();
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
			}
			else if (oy.aXA < BM.Qz.aXA)
			{
				TreeNode val = new TreeNode(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kt());
				val.ForeColor = BM.te;
				Pf.a().Add(val);
			}
			else
			{
				TreeNode val2 = new TreeNode(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kU());
				val2.ForeColor = BM.te;
				Pf.a().Add(val2);
			}
			Pf.C();
			Pf.I();
		}

		private void A(MenuNode P_0, TreeNode P_1)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_048e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0493: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_0773: Unknown result type (might be due to invalid IL or missing references)
			//IL_0778: Unknown result type (might be due to invalid IL or missing references)
			//IL_0672: Unknown result type (might be due to invalid IL or missing references)
			//IL_0677: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c4: Expected O, but got Unknown
			//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
			string text = P_0.E();
			int num = P_0.b();
			int num2 = P_0.H();
			TreeNode val = new TreeNode(text);
			if (P_1 != null && P_1.ForeColor == Color.Gray)
			{
				val.ForeColor = Color.Gray;
			}
			else
			{
				val.ForeColor = BM.te;
			}
			SettingOrSpecialObject settingOrSpecialObject = oy.a(num);
			SettingOrSpecialObject settingOrSpecialObject2 = oy.a(num2);
			if (P_0.A(out var setting))
			{
				if (setting.am())
				{
					return;
				}
				val.ForeColor = Color.Gray;
			}
			else if (settingOrSpecialObject != null)
			{
				if (settingOrSpecialObject.J().Count != 0 || settingOrSpecialObject.K().A().Count != 0)
				{
					return;
				}
			}
			else if (val.ForeColor != Color.Gray && settingOrSpecialObject2 != null)
			{
				int num3 = 0;
				Enumerator<SettingOrSpecialObject> enumerator = settingOrSpecialObject2.a().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						SettingOrSpecialObject current = enumerator.Current;
						if ((current is Setting && current.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ff())) || current.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FG()) || current.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fg()))
						{
							num3 = (current as Setting).A();
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (num3 != 0)
				{
					Setting setting2 = BM.Qz.A(num3);
					if (setting2 != null)
					{
						bool flag = setting2.ax() != 1;
						if (flag)
						{
							if (setting2.am())
							{
								return;
							}
						}
						else
						{
							HashSet<DataIdAndAttrId> obj = P_0.j(false);
							bool flag2 = true;
							Enumerator<DataIdAndAttrId> enumerator2 = obj.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									DataIdAndAttrId current2 = enumerator2.Current;
									Setting setting3 = BM.Qz.A(current2);
									if (setting3 != null && setting3 != setting2 && ((SettingOrSpecialObject)setting3).l() && !setting3.am() && !setting3.aN() && !setting3.al())
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
							flag = flag2;
						}
						if (flag)
						{
							val.ForeColor = Color.Gray;
						}
					}
				}
			}
			Enumerator<MenuNode> enumerator3 = P_0.c().GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					MenuNode current3 = enumerator3.Current;
					A(current3, val);
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			if (val.GetNodeCount(true) == 0 && settingOrSpecialObject == null && settingOrSpecialObject2 == null && P_0.h() == 0)
			{
				return;
			}
			if (P_0.C() != null && P_0.C().h() == 0 && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count != 0)
			{
				bool flag3 = true;
				Enumerator<UIListSettingDataIdAndIndent> enumerator4 = (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.GetEnumerator();
				try
				{
					while (enumerator4.MoveNext())
					{
						UIListSettingDataIdAndIndent current4 = enumerator4.Current;
						if (!oy.aWZ.Contains(current4.DataId))
						{
							flag3 = false;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator4).Dispose();
				}
				if (flag3)
				{
					return;
				}
			}
			bool skipThisTreeNode = false;
			if (settingOrSpecialObject2 != null)
			{
				List<Do> val2 = new List<Do>();
				PortFunction.A(settingOrSpecialObject2, false, true, val2);
				Enumerator<Do> enumerator5 = val2.GetEnumerator();
				try
				{
					while (enumerator5.MoveNext())
					{
						Do current5 = enumerator5.Current;
						if (BM.Qz.A(current5.A()) == null)
						{
							A(current5, val, null);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator5).Dispose();
				}
				List<Dn> val3 = new List<Dn>();
				PortFunction.A(settingOrSpecialObject2, false, val3, true);
				Enumerator<Dn> enumerator6 = val3.GetEnumerator();
				try
				{
					while (enumerator6.MoveNext())
					{
						Dn current6 = enumerator6.Current;
						if (BM.Qz.A(((Setting)current6).A()) == null && !current6.am())
						{
							A(current6, val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ku());
						}
						List<Setting> val4 = new List<Setting>();
						PortFunction.A(current6, val4, false);
						Enumerator<Setting> enumerator7 = val4.GetEnumerator();
						try
						{
							while (enumerator7.MoveNext())
							{
								Setting current7 = enumerator7.Current;
								if (BM.Qz.A(current7.A()) == null)
								{
									A(current7, val, null);
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator7).Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator6).Dispose();
				}
			}
			else if (settingOrSpecialObject != null)
			{
				CG cG = settingOrSpecialObject.e();
				if (cG != null)
				{
					cG.InitReleaseNotesNode(val, BM.Qz, ref skipThisTreeNode);
				}
				else if (settingOrSpecialObject.a().Count != 0)
				{
					if (!(settingOrSpecialObject is SpecialObject) || !(settingOrSpecialObject as SpecialObject).b().EachListRowIsAnObject())
					{
						Enumerator<SettingOrSpecialObject> enumerator = settingOrSpecialObject.a().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								SettingOrSpecialObject current8 = enumerator.Current;
								if (!(current8 is Setting))
								{
									continue;
								}
								Setting setting4 = current8 as Setting;
								if (setting4.am() || setting4.al() || setting4.aN() || oy.aWZ.Contains(setting4.A()))
								{
									continue;
								}
								Setting setting5 = BM.Qz.A(setting4.A());
								if (setting5 == null)
								{
									A(setting4, val, null);
								}
								else
								{
									if (setting4.aJ() || setting4.U())
									{
										continue;
									}
									List<Setting.ListItems.A> val5 = setting4.d(0);
									for (int i = 0; i < val5.Count; i++)
									{
										bool flag4 = false;
										List<Setting.ListItems.A> val6 = setting5.d(0);
										for (int j = 0; j < val6.Count; j++)
										{
											if (val6[j].bBv == val5[i].bBv || val6[j].bBV.Equals(val5[i].bBV))
											{
												flag4 = true;
												break;
											}
										}
										if (!flag4)
										{
											TreeNode val7 = new TreeNode(((SettingOrSpecialObject)setting4).A(true));
											val7.ForeColor = val.ForeColor;
											val7.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kV() + val5[i].bBV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kv();
											val.Nodes.Add(val7);
										}
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
					if (settingOrSpecialObject.R() != null)
					{
						string text2 = settingOrSpecialObject.R();
						if (oy.aWW.ErrorDefs.ContainsKey(text2))
						{
							Enumerator<ErrorPanelItem> enumerator8 = oy.aWW.ErrorPanel.GetEnumerator();
							try
							{
								int num4 = default(int);
								while (enumerator8.MoveNext())
								{
									ErrorPanelItem current9 = enumerator8.Current;
									if (current9.Type != DataTableColumnType.Enum || !int.TryParse(oy.aWW.ErrorDefs[text2][D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KX()], ref num4) || current9.DataId == -1)
									{
										continue;
									}
									Setting setting6 = oy.A(current9.DataId);
									if (setting6 != null && !setting6.am())
									{
										bool flag5 = false;
										Setting setting7 = BM.Qz.A(setting6.A());
										if (setting7 == null || !BM.Qz.aWW.IsValid || oy.aWW.ErrorToSettingMap[num4] >= setting7.Ba())
										{
											A(setting6, val, null);
										}
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator8).Dispose();
							}
						}
					}
					else
					{
						Enumerator<string> enumerator9 = settingOrSpecialObject.Q().GetEnumerator();
						try
						{
							while (enumerator9.MoveNext())
							{
								string current10 = enumerator9.Current;
								if (!oy.aWv.ContainsKey(current10))
								{
									continue;
								}
								Enumerator<SettingOrSpecialObject> enumerator = ((SettingOrSpecialObject)oy.aWv[current10]).a().GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										SettingOrSpecialObject current11 = enumerator.Current;
										if (!(current11 is Setting))
										{
											continue;
										}
										Setting setting8 = current11 as Setting;
										if (((SettingOrSpecialObject)setting8).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kW())
										{
											if (!setting8.am() && BM.Qz.A(setting8.A()) == null)
											{
												A(setting8, val, null);
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
						finally
						{
							((System.IDisposable)enumerator9).Dispose();
						}
					}
				}
			}
			if (!skipThisTreeNode && (val.GetNodeCount(true) != 0 || (val.Tag != null && val.Tag is string)))
			{
				if (P_1 != null)
				{
					P_1.Nodes.Add(val);
					return;
				}
				val.Expand();
				Pf.a().Add(val);
			}
		}

		private void A(Setting P_0, TreeNode P_1, string P_2)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			string text = ((!string.IsNullOrEmpty(P_2)) ? (((SettingOrSpecialObject)P_0).A(true) + P_2) : ((SettingOrSpecialObject)P_0).A(true));
			TreeNode val = new TreeNode(text);
			val.ForeColor = P_1.ForeColor;
			val.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kw();
			P_1.Nodes.Add(val);
		}

		private void D()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			foreach (TabPage tabPage in ((TabControl)Pk).TabPages)
			{
				TabPage val = tabPage;
				if (((ArrangedElementCollection)((Control)val).Controls).Count == 0 || !(((Control)val).Controls[0] is ag))
				{
					continue;
				}
				ag ag = ((Control)val).Controls[0] as ag;
				((TextBoxBase)ag).Clear();
				ag.A();
				if (((Control)val).Tag == null)
				{
					if (oz.ContainsKey(PB))
					{
						if (PB == bt.avK)
						{
							if (ow.aH == 22)
							{
								if (string.IsNullOrEmpty(oz[PB]))
								{
									break;
								}
							}
							else if (BM.Qz == null || oy == null || oy.aXA <= BM.Qz.aXA || string.IsNullOrEmpty(oz[PB]))
							{
								break;
							}
						}
						else if (oY <= oX || string.IsNullOrEmpty(oz[PB]))
						{
							break;
						}
						ag.A(oz[PB]);
					}
				}
				else if (((Control)val).Tag is bu)
				{
					bt bt = (((Control)val).Tag as bu).A();
					if (oz.ContainsKey(bt))
					{
						if (PB != 0 || oY <= oX || string.IsNullOrEmpty(oz[bt]))
						{
							break;
						}
						ag.A(oz[bt]);
					}
				}
				ag.A();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && PF != null)
			{
				((System.IDisposable)PF).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void d()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0425: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Expected O, but got Unknown
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0466: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0518: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Expected O, but got Unknown
			//IL_053b: Unknown result type (might be due to invalid IL or missing references)
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_0649: Unknown result type (might be due to invalid IL or missing references)
			//IL_072d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0737: Expected O, but got Unknown
			//IL_077f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0789: Expected O, but got Unknown
			//IL_0791: Unknown result type (might be due to invalid IL or missing references)
			//IL_079b: Expected O, but got Unknown
			Pf = new TreeViewWithThemedScrollBars();
			PG = new Label();
			Pg = new Label();
			PH = new Label();
			Ph = new Label();
			PI = new ThemedButton();
			Pi = new ThemedButton();
			PJ = new ThemedButton();
			Pj = new ProgressBar();
			PK = new ThemedComboBox();
			Pk = new aq();
			PL = new Label();
			((Control)this).SuspendLayout();
			Pf.a(true);
			((ScrollableControl)Pf).AutoScroll = true;
			Pf.A(false);
			Pf.A(aW.kP);
			((Control)Pf).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f);
			Pf.A((List<Image>)null);
			((Control)Pf).Location = new Point(12, 79);
			((Control)Pf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kX();
			Pf.A((TreeNode)null);
			((Control)Pf).Size = new Size(856, 500);
			((Control)Pf).TabIndex = 4;
			((Control)PG).AutoSize = true;
			((Control)PG).Location = new Point(12, 32);
			((Control)PG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kx();
			((Control)PG).Size = new Size(68, 13);
			((Control)PG).TabIndex = 13;
			((Control)PG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kY();
			((Control)Pg).AutoSize = true;
			((Control)Pg).Location = new Point(12, 8);
			((Control)Pg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ky();
			((Control)Pg).Size = new Size(86, 13);
			((Control)Pg).TabIndex = 12;
			((Control)Pg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kG();
			((Control)PH).AutoSize = true;
			((Control)PH).Location = new Point(12, 63);
			((Control)PH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)PH).Size = new Size(155, 13);
			((Control)PH).TabIndex = 14;
			((Control)PH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kZ();
			((Control)Ph).AutoSize = true;
			((Control)Ph).Location = new Point(883, 63);
			((Control)Ph).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)Ph).Size = new Size(156, 13);
			((Control)Ph).TabIndex = 15;
			((Control)Ph).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kz();
			((Button)PI).DialogResult = (DialogResult)2;
			((Control)PI).Location = new Point(1128, 584);
			((Control)PI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)PI).Size = new Size(100, 38);
			((Control)PI).TabIndex = 1;
			((Control)PI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)PI).UseVisualStyleBackColor = true;
			((Button)Pi).DialogResult = (DialogResult)1;
			((Control)Pi).Enabled = false;
			((Control)Pi).Location = new Point(950, 584);
			((Control)Pi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)Pi).Size = new Size(171, 38);
			((Control)Pi).TabIndex = 0;
			((Control)Pi).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LA();
			((ButtonBase)Pi).UseVisualStyleBackColor = true;
			((Control)PJ).Location = new Point(290, 25);
			((Control)PJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.La();
			((Control)PJ).Size = new Size(120, 26);
			((Control)PJ).TabIndex = 3;
			((Control)PJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LB();
			((ButtonBase)PJ).UseVisualStyleBackColor = true;
			((Control)PJ).Click += new EventHandler(b);
			((Control)Pj).Location = new Point(520, 302);
			((Control)Pj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lb();
			((Control)Pj).Size = new Size(200, 22);
			Pj.Step = 1;
			Pj.Style = (ProgressBarStyle)1;
			((Control)Pj).TabIndex = 6;
			((Control)Pj).Visible = false;
			((ComboBox)PK).DrawMode = (DrawMode)1;
			((ComboBox)PK).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)PK).FormattingEnabled = true;
			((Control)PK).Location = new Point(81, 28);
			((Control)PK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LC();
			((Control)PK).Size = new Size(200, 23);
			((Control)PK).TabIndex = 2;
			((ComboBox)PK).SelectedIndexChanged += new EventHandler(B);
			((TabControl)Pk).DrawMode = (TabDrawMode)1;
			((Control)Pk).Location = new Point(882, 79);
			((Control)Pk).Margin = new Padding(0);
			((TabControl)Pk).Multiline = true;
			((Control)Pk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lc();
			((TabControl)Pk).SelectedIndex = 0;
			((Control)Pk).Size = new Size(346, 500);
			((Control)Pk).TabIndex = 5;
			((Control)PL).AutoSize = true;
			((Control)PL).Location = new Point(440, 8);
			((Control)PL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LD();
			((Control)PL).Size = new Size(486, 13);
			((Control)PL).TabIndex = 17;
			((Control)PL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ld();
			((Form)this).AcceptButton = (IButtonControl)(object)Pi;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)PI;
			((Form)this).ClientSize = new Size(1240, 630);
			((Control)this).Controls.Add((Control)(object)PL);
			((Control)this).Controls.Add((Control)(object)Pk);
			((Control)this).Controls.Add((Control)(object)PK);
			((Control)this).Controls.Add((Control)(object)Pj);
			((Control)this).Controls.Add((Control)(object)PJ);
			((Control)this).Controls.Add((Control)(object)PI);
			((Control)this).Controls.Add((Control)(object)Pi);
			((Control)this).Controls.Add((Control)(object)Ph);
			((Control)this).Controls.Add((Control)(object)PH);
			((Control)this).Controls.Add((Control)(object)PG);
			((Control)this).Controls.Add((Control)(object)Pg);
			((Control)this).Controls.Add((Control)(object)Pf);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LE();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gn();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Bi : Form
	{
		private Setting Pl;

		private int PM;

		private int Pm;

		private int PN;

		private int Pn;

		private IContainer PO;

		private ThemedButton Po;

		private ThemedButton PP;

		private Label Pp;

		private ThemedTextBox PQ;

		private ThemedTextBox Pq;

		private Label PR;

		private Label Pr;

		private Label PS;

		private Label Ps;

		private ThemedTextBox PT;

		private ThemedTextBox Pt;

		private Label PU;

		private aP Pu;

		private Label PV;

		internal Bi()
		{
			c();
		}

		internal Bi(Setting P_0, int P_1, int P_2, int P_3, int P_4)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			c();
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
			Pl = P_0;
			PM = P_1;
			Pm = P_2;
			PN = P_3;
			Pn = P_4;
			if (Pl != null)
			{
				int num = Pl.aS();
				string text = ((SettingOrSpecialObject)Pl).H();
				if (!string.IsNullOrWhiteSpace(text))
				{
					if (num != 0 && num != 82)
					{
						((Control)Pp).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(Pl.@as(), num, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					else
					{
						((Control)Pp).Text = text;
					}
				}
				else if (num != 0 && num != 82)
				{
					((Control)Pp).Text = ((SettingOrSpecialObject)Pl).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(Pl.@as(), num, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
				}
				else
				{
					((Control)Pp).Text = ((SettingOrSpecialObject)Pl).A(bz.aYT);
				}
				((Control)PQ).Text = bS.a(PM, num, -1);
				((Control)Pq).Text = bS.a(Pm, num, -1);
				((Control)Pt).Text = bS.a(PN, num, -1);
				((Control)PT).Text = bS.a(Pn, num, -1);
				((Control)PQ).Visible = true;
				((Control)Pq).Visible = true;
				((Control)Pt).Visible = true;
				((Control)PT).Visible = true;
			}
			else
			{
				((Control)Pp).Text = string.Empty;
				((Control)PQ).Visible = false;
				((Control)Pq).Visible = false;
				((Control)Pt).Visible = false;
				((Control)PT).Visible = false;
			}
		}

		[SpecialName]
		internal bool A()
		{
			return ((CheckBox)Pu).Checked;
		}

		[SpecialName]
		internal int a()
		{
			return PM;
		}

		[SpecialName]
		internal int B()
		{
			return Pm;
		}

		[SpecialName]
		internal int b()
		{
			return PN;
		}

		[SpecialName]
		internal int C()
		{
			return Pn;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult != 1 || Pl == null)
			{
				return;
			}
			int num = Pl.aS();
			int num2 = Pl.aR();
			int num3 = Pl.ar();
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			try
			{
				int num4 = bS.A(((Control)PQ).Text, num);
				int num5 = bS.A(((Control)Pq).Text, num);
				int num6 = bS.A(((Control)Pt).Text, num);
				int num7 = bS.A(((Control)PT).Text, num);
				if (num4 >= num5)
				{
					flag = true;
					throw new System.Exception();
				}
				if (num2 != 0 || num3 != 0)
				{
					if (num4 < num2)
					{
						flag2 = true;
						throw new System.Exception();
					}
					if (num5 > num3)
					{
						flag3 = true;
						throw new System.Exception();
					}
					if (num6 < num2 || num6 > num3)
					{
						flag4 = true;
						throw new System.Exception();
					}
					if (num7 < num2 || num7 > num3)
					{
						flag5 = true;
						throw new System.Exception();
					}
				}
				PM = num4;
				Pm = num5;
				PN = num6;
				Pn = num7;
			}
			catch
			{
				if (flag)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Le(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					string text = (flag2 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LF() : (flag3 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lf() : (flag4 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LG() : ((!flag5) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LH() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lg()))));
					string text2 = bS.a(num2, num, -1);
					string text3 = bS.a(num3, num, -1);
					bE.A((IWin32Window)(object)this, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lh() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LI(), (object)text2, (object)text3), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && PO != null)
			{
				((System.IDisposable)PO).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void c()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0365: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_055a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0598: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d0: Expected O, but got Unknown
			//IL_0718: Unknown result type (might be due to invalid IL or missing references)
			//IL_0722: Expected O, but got Unknown
			Po = new ThemedButton();
			PP = new ThemedButton();
			Pp = new Label();
			PQ = new ThemedTextBox();
			Pq = new ThemedTextBox();
			PR = new Label();
			Pr = new Label();
			PS = new Label();
			Ps = new Label();
			PT = new ThemedTextBox();
			Pt = new ThemedTextBox();
			PU = new Label();
			Pu = new aP();
			PV = new Label();
			((Control)this).SuspendLayout();
			((Button)Po).DialogResult = (DialogResult)1;
			((Control)Po).Location = new Point(30, 256);
			((Control)Po).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)Po).Size = new Size(89, 34);
			((Control)Po).TabIndex = 5;
			((Control)Po).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)Po).UseVisualStyleBackColor = true;
			((Button)PP).DialogResult = (DialogResult)2;
			((Control)PP).Location = new Point(126, 256);
			((Control)PP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)PP).Size = new Size(89, 34);
			((Control)PP).TabIndex = 6;
			((Control)PP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)PP).UseVisualStyleBackColor = true;
			((Control)Pp).AutoSize = true;
			((Control)Pp).Location = new Point(10, 10);
			((Control)Pp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Li();
			((Control)Pp).Size = new Size(98, 13);
			((Control)Pp).TabIndex = 2;
			((Control)Pp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LJ();
			((Control)PQ).Location = new Point(19, 54);
			((Control)PQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lj();
			((Control)PQ).Size = new Size(100, 22);
			((Control)PQ).TabIndex = 0;
			((Control)Pq).Location = new Point(125, 54);
			((Control)Pq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LK();
			((Control)Pq).Size = new Size(100, 22);
			((Control)Pq).TabIndex = 1;
			((Control)PR).AutoSize = true;
			((Control)PR).Location = new Point(21, 38);
			((Control)PR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GE();
			((Control)PR).Size = new Size(95, 13);
			((Control)PR).TabIndex = 32;
			((Control)PR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lk();
			((Control)Pr).AutoSize = true;
			((Control)Pr).Location = new Point(127, 38);
			((Control)Pr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GF();
			((Control)Pr).Size = new Size(96, 13);
			((Control)Pr).TabIndex = 33;
			((Control)Pr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LL();
			((Control)PS).AutoSize = true;
			((Control)PS).Location = new Point(127, 198);
			((Control)PS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)PS).Size = new Size(80, 13);
			((Control)PS).TabIndex = 37;
			((Control)PS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ll();
			((Control)Ps).AutoSize = true;
			((Control)Ps).Location = new Point(21, 198);
			((Control)Ps).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)Ps).Size = new Size(76, 13);
			((Control)Ps).TabIndex = 36;
			((Control)Ps).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LM();
			((Control)PT).Location = new Point(125, 214);
			((Control)PT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lm();
			((Control)PT).Size = new Size(100, 22);
			((Control)PT).TabIndex = 4;
			((Control)Pt).Location = new Point(19, 214);
			((Control)Pt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LN();
			((Control)Pt).Size = new Size(100, 22);
			((Control)Pt).TabIndex = 3;
			((Control)PU).Location = new Point(10, 137);
			((Control)PU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)PU).Size = new Size(231, 58);
			((Control)PU).TabIndex = 38;
			((Control)PU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ln();
			((Control)Pu).Location = new Point(26, 91);
			((Control)Pu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LO();
			((Control)Pu).Size = new Size(20, 17);
			((Control)Pu).TabIndex = 2;
			((ButtonBase)Pu).UseVisualStyleBackColor = true;
			((Control)PV).Location = new Point(50, 80);
			((Control)PV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)PV).Size = new Size(180, 49);
			((Control)PV).TabIndex = 40;
			((Control)PV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lo();
			((Form)this).AcceptButton = (IButtonControl)(object)Po;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)PP;
			((Form)this).ClientSize = new Size(244, 297);
			((Control)this).Controls.Add((Control)(object)PV);
			((Control)this).Controls.Add((Control)(object)Pu);
			((Control)this).Controls.Add((Control)(object)PU);
			((Control)this).Controls.Add((Control)(object)PS);
			((Control)this).Controls.Add((Control)(object)Ps);
			((Control)this).Controls.Add((Control)(object)PT);
			((Control)this).Controls.Add((Control)(object)Pt);
			((Control)this).Controls.Add((Control)(object)Pr);
			((Control)this).Controls.Add((Control)(object)PR);
			((Control)this).Controls.Add((Control)(object)Pq);
			((Control)this).Controls.Add((Control)(object)PQ);
			((Control)this).Controls.Add((Control)(object)Pp);
			((Control)this).Controls.Add((Control)(object)PP);
			((Control)this).Controls.Add((Control)(object)Po);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LP();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal class bI : Form
	{
		[CompilerGenerated]
		private sealed class A
		{
			public string BRP;

			public bI BRp;

			internal void A()
			{
				((Control)BRp.aBZ).Text = aBX + BRP;
			}
		}

		private BackgroundWorker aBw = new BackgroundWorker();

		internal static string aBX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBZ();

		internal const uint aBx = 5u;

		private static uint aBY = 5u;

		private IContainer aBy;

		private ThemedButton aBZ;

		private Label aBz;

		internal bI()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected O, but got Unknown
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			A();
			aBY = 5u;
			((Control)aBZ).Text = aBX + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh() + 5u;
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			aBw.WorkerSupportsCancellation = true;
			aBw.DoWork += new DoWorkEventHandler(A);
			aBw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
			aBw.RunWorkerAsync();
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			while (!global::A.A.b(BM.Qz.aXc) || aBY >= 2)
			{
				global::A.A.A(BM.Qz.aXc, f.aX, 0u, 4u, out var _, out var _);
				Thread.Sleep(1000);
				if (aBw.CancellationPending)
				{
					P_1.Result = false;
					return;
				}
				try
				{
					string BRP = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
					if (aBY > 1)
					{
						aBY--;
						BRP = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh() + aBY;
					}
					else
					{
						((Control)aBZ).Invoke((Action)([CompilerGenerated] () =>
						{
							((Control)aBZ).Enabled = true;
						}));
					}
					((Control)aBZ).Invoke((Action)delegate
					{
						((Control)aBZ).Text = aBX + BRP;
					});
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBw() + ex.Message, true);
				}
			}
			P_1.Result = true;
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			if ((bool)P_1.Result)
			{
				((Form)this).DialogResult = (DialogResult)1;
			}
			else
			{
				((Form)this).DialogResult = (DialogResult)2;
			}
			((Form)this).Close();
		}

		private void A(object P_0, EventArgs P_1)
		{
			aBw.CancelAsync();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aBy != null)
			{
				((System.IDisposable)aBy).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			aBZ = new ThemedButton();
			aBz = new Label();
			((Control)this).SuspendLayout();
			((Control)aBZ).Enabled = false;
			((Control)aBZ).Location = new Point(56, 46);
			((Control)aBZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)aBZ).Size = new Size(128, 38);
			((Control)aBZ).TabIndex = 0;
			((Control)aBZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBX();
			((ButtonBase)aBZ).UseVisualStyleBackColor = true;
			((Control)aBZ).Click += new EventHandler(A);
			((Control)aBz).AutoSize = true;
			((Control)aBz).Location = new Point(52, 14);
			((Control)aBz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)aBz).Size = new Size(135, 13);
			((Control)aBz).TabIndex = 1;
			((Control)aBz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBx();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(240, 98);
			((Form)this).ControlBox = false;
			((Control)this).Controls.Add((Control)(object)aBz);
			((Control)this).Controls.Add((Control)(object)aBZ);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBY();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBy();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}

		[CompilerGenerated]
		private void a()
		{
			((Control)aBZ).Enabled = true;
		}
	}
	internal class bi : Form
	{
		[CompilerGenerated]
		private sealed class A
		{
			public string BRQ;

			public bi BRq;

			internal void A()
			{
				((Control)BRq.abC).Text = bI.aBX + BRQ;
			}
		}

		private BackgroundWorker abA = new BackgroundWorker();

		private uint aba = 5u;

		private IContainer abB;

		private Label abb;

		private ThemedButton abC;

		internal bi()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			A();
			aba = 5u;
			((Control)abC).Text = bI.aBX + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh() + aba;
			((Control)abC).Enabled = false;
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			abA.WorkerSupportsCancellation = true;
			abA.DoWork += new DoWorkEventHandler(A);
			abA.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
			abA.RunWorkerAsync();
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			while (!global::A.A.b(BM.Qz.aXc))
			{
				global::A.A.A(BM.Qz.aXc, f.aX, 0u, 4u, out var _, out var _);
				Thread.Sleep(1000);
				if (abA.CancellationPending)
				{
					P_1.Result = false;
					return;
				}
				try
				{
					string BRQ = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
					if (aba > 1)
					{
						aba--;
						BRQ = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh() + aba;
					}
					else
					{
						((Control)abC).Invoke((Action)([CompilerGenerated] () =>
						{
							((Control)abC).Enabled = true;
						}));
					}
					((Control)abC).Invoke((Action)delegate
					{
						((Control)abC).Text = bI.aBX + BRQ;
					});
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBz() + ex.Message, true);
				}
			}
			P_1.Result = true;
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			if ((bool)P_1.Result)
			{
				((Form)this).DialogResult = (DialogResult)1;
			}
			else
			{
				((Form)this).DialogResult = (DialogResult)2;
			}
			((Form)this).Close();
		}

		private void A(object P_0, EventArgs P_1)
		{
			abA.CancelAsync();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && abB != null)
			{
				((System.IDisposable)abB).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			ComponentResourceManager val = new ComponentResourceManager(typeof(bi));
			abb = new Label();
			abC = new ThemedButton();
			((Control)this).SuspendLayout();
			((Control)abb).AutoSize = true;
			((Control)abb).Location = new Point(5, 9);
			((Control)abb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)abb).Size = new Size(328, 65);
			((Control)abb).TabIndex = 0;
			((Control)abb).Text = ((ResourceManager)val).GetString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VH());
			((Control)abC).Enabled = false;
			((Control)abC).Location = new Point(116, 83);
			((Control)abC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abA();
			((Control)abC).Size = new Size(128, 38);
			((Control)abC).TabIndex = 3;
			((Control)abC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBX();
			((ButtonBase)abC).UseVisualStyleBackColor = true;
			((Control)abC).Click += new EventHandler(A);
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(360, 133);
			((Form)this).ControlBox = false;
			((Control)this).Controls.Add((Control)(object)abC);
			((Control)this).Controls.Add((Control)(object)abb);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aba();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abB();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}

		[CompilerGenerated]
		private void a()
		{
			((Control)abC).Enabled = true;
		}
	}
}
