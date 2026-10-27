using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace B
{
	internal enum BF
	{
		OT,
		Ot,
		OU,
		Ou
	}
	internal class Bf : Form
	{
		private delegate void A(object P_0, EventArgs P_1);

		private delegate void a(object P_0, E P_1);

		private class B : Button
		{
			protected bool BPe;

			protected Bf BPF;

			protected override void OnMouseEnter(EventArgs e)
			{
				((Button)this).OnMouseEnter(e);
				BPe = true;
				((Control)this).Invalidate();
			}

			protected override void OnMouseLeave(EventArgs e)
			{
				((Button)this).OnMouseLeave(e);
				BPe = false;
				((Control)this).Invalidate();
			}

			protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_0010: Invalid comparison between Unknown and I4
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_001a: Invalid comparison between Unknown and I4
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Invalid comparison between Unknown and I4
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Invalid comparison between Unknown and I4
				((Control)this).OnPreviewKeyDown(e);
				e.IsInputKey = (int)e.KeyData == 37 || (int)e.KeyData == 38 || (int)e.KeyData == 39 || (int)e.KeyData == 40;
			}

			protected override void OnKeyDown(KeyEventArgs e)
			{
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Expected O, but got Unknown
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fe: Invalid comparison between Unknown and I4
				//IL_0101: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Invalid comparison between Unknown and I4
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected O, but got Unknown
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Invalid comparison between Unknown and I4
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Invalid comparison between Unknown and I4
				List<B> val = new List<B>();
				int num = -1;
				foreach (Control item in (ArrangedElementCollection)((Control)BPF).Controls)
				{
					Control val2 = item;
					if (val2 is Panel)
					{
						foreach (Control item2 in (ArrangedElementCollection)val2.Controls)
						{
							Control val3 = item2;
							if (val3 is B && val3.Enabled)
							{
								if (val3.Focused)
								{
									num = val.Count;
								}
								val.Add(val3 as B);
							}
						}
					}
					else if (val2 is B && val2.Enabled)
					{
						if (val2.Focused)
						{
							num = val.Count;
						}
						val.Add(val2 as B);
					}
				}
				if (val.Count > 1)
				{
					if ((int)e.KeyData == 37 || (int)e.KeyData == 38)
					{
						if (num == -1)
						{
							((Control)this).Focus();
						}
						else if (((Control)val[0]).Focused)
						{
							((Control)val[val.Count - 1]).Focus();
						}
						else
						{
							((Control)val[num - 1]).Focus();
						}
					}
					else if ((int)e.KeyData == 39 || (int)e.KeyData == 40)
					{
						if (num == -1)
						{
							((Control)this).Focus();
						}
						else if (((Control)val[val.Count - 1]).Focused)
						{
							((Control)val[0]).Focus();
						}
						else
						{
							((Control)val[num + 1]).Focus();
						}
					}
					else
					{
						((ButtonBase)this).OnKeyDown(e);
					}
				}
				else
				{
					((ButtonBase)this).OnKeyDown(e);
				}
			}
		}

		private class b : B
		{
			internal b(Bf P_0)
			{
				BPF = P_0;
			}

			internal bool A()
			{
				string text = string.Empty;
				if (((Control)this).Tag is F)
				{
					text = (((Control)this).Tag as F).ao;
				}
				if (!string.IsNullOrEmpty(BPF.Ox) && text == BPF.Ox && BM.Qz != null && BM.Qz.c() && BM.Qz.E())
				{
					return true;
				}
				return false;
			}

			protected override void OnClick(EventArgs e)
			{
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0012: Invalid comparison between Unknown and I4
				bool flag = A();
				if (flag || (int)BM.A((IWin32Window)(object)this, true) != 2)
				{
					if (flag)
					{
						BPF.OY = BF.Ot;
					}
					else
					{
						BPF.OY = BF.OU;
					}
					BPF.Ox = string.Empty;
					if (((Control)this).Tag is F)
					{
						BPF.Ox = (((Control)this).Tag as F).ao;
					}
					((Form)BPF).DialogResult = (DialogResult)1;
					((Form)BPF).Close();
				}
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Expected O, but got Unknown
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Expected O, but got Unknown
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Expected O, but got Unknown
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Expected O, but got Unknown
				//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Expected O, but got Unknown
				//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Expected O, but got Unknown
				SolidBrush val = new SolidBrush(((Control)this).BackColor);
				try
				{
					e.Graphics.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).Width, ((Control)this).Height);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				if (((Control)this).Focused)
				{
					Pen val2 = new Pen(Color.DodgerBlue, 3f);
					try
					{
						e.Graphics.DrawRectangle(val2, 1, 1, ((Control)this).Width - 3, ((Control)this).Height - 3);
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
				}
				else if (BPe)
				{
					Pen val3 = new Pen(Color.DodgerBlue, 1f);
					try
					{
						e.Graphics.DrawRectangle(val3, 0, 0, ((Control)this).Width - 1, ((Control)this).Height - 1);
					}
					finally
					{
						((System.IDisposable)val3)?.Dispose();
					}
				}
				SolidBrush val4 = new SolidBrush(BM.te);
				try
				{
					Font val5 = new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)0);
					try
					{
						StringFormat val6 = new StringFormat();
						try
						{
							val6.Alignment = (StringAlignment)1;
							val6.LineAlignment = (StringAlignment)1;
							if (A())
							{
								e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhE(), val5, (Brush)(object)val4, (float)(((Control)this).Width / 2), 19f, val6);
								e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhe(), val5, (Brush)(object)val4, (float)(((Control)this).Width / 2), 33f, val6);
							}
							else
							{
								e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhF(), val5, (Brush)(object)val4, (float)(((Control)this).Width / 2), 19f, val6);
								e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhf(), val5, (Brush)(object)val4, (float)(((Control)this).Width / 2), 33f, val6);
							}
						}
						finally
						{
							((System.IDisposable)val6)?.Dispose();
						}
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
		}

		private class C : B
		{
			internal C(Bf P_0)
			{
				BPF = P_0;
			}

			protected override void OnClick(EventArgs e)
			{
				if (!((Control)this).Enabled)
				{
					return;
				}
				BM.Qz.A((IWin32Window)(object)BPF);
				BM.E();
				if (BM.Qz.C())
				{
					BPF.OY = BF.Ou;
					BPF.Ox = string.Empty;
					if (((Control)this).Tag is F)
					{
						BPF.Ox = (((Control)this).Tag as F).ao;
					}
					((Form)BPF).DialogResult = (DialogResult)1;
					((Form)BPF).Close();
				}
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Expected O, but got Unknown
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Expected O, but got Unknown
				//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Expected O, but got Unknown
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Expected O, but got Unknown
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Expected O, but got Unknown
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fe: Expected O, but got Unknown
				SolidBrush val = new SolidBrush(((Control)this).BackColor);
				try
				{
					e.Graphics.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).Width, ((Control)this).Height);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				if (((Control)this).Enabled)
				{
					if (((Control)this).Focused)
					{
						Pen val2 = new Pen(Color.DodgerBlue, 3f);
						try
						{
							e.Graphics.DrawRectangle(val2, 1, 1, ((Control)this).Width - 3, ((Control)this).Height - 3);
						}
						finally
						{
							((System.IDisposable)val2)?.Dispose();
						}
					}
					else if (BPe)
					{
						Pen val3 = new Pen(Color.DodgerBlue, 1f);
						try
						{
							e.Graphics.DrawRectangle(val3, 0, 0, ((Control)this).Width - 1, ((Control)this).Height - 1);
						}
						finally
						{
							((System.IDisposable)val3)?.Dispose();
						}
					}
				}
				Color val4 = ((!((Control)this).Enabled) ? BM.tq : BM.te);
				SolidBrush val5 = new SolidBrush(val4);
				try
				{
					Font val6 = new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)0);
					try
					{
						StringFormat val7 = new StringFormat();
						try
						{
							val7.Alignment = (StringAlignment)1;
							val7.LineAlignment = (StringAlignment)1;
							e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhG(), val6, (Brush)(object)val5, (float)(((Control)this).Width / 2), 19f, val7);
							e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhe(), val6, (Brush)(object)val5, (float)(((Control)this).Width / 2), 33f, val7);
						}
						finally
						{
							((System.IDisposable)val7)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val6)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val5)?.Dispose();
				}
			}
		}

		private class c : B
		{
			internal c(Bf P_0)
			{
				BPF = P_0;
			}

			protected override void OnClick(EventArgs e)
			{
				BPF.Ox = string.Empty;
				BPF.OY = BF.OT;
				((Form)BPF).DialogResult = (DialogResult)2;
				((Form)BPF).Close();
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Expected O, but got Unknown
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Expected O, but got Unknown
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0135: Expected O, but got Unknown
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Expected O, but got Unknown
				SolidBrush val = new SolidBrush(((Control)this).BackColor);
				try
				{
					e.Graphics.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).Width, ((Control)this).Height);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				if (((Control)this).Focused)
				{
					Pen val2 = new Pen(Color.DodgerBlue, 3f);
					try
					{
						e.Graphics.DrawRectangle(val2, 1, 1, ((Control)this).Width - 3, ((Control)this).Height - 3);
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
				}
				else if (BPe)
				{
					Pen val3 = new Pen(Color.DodgerBlue, 1f);
					try
					{
						e.Graphics.DrawRectangle(val3, 0, 0, ((Control)this).Width - 1, ((Control)this).Height - 1);
					}
					finally
					{
						((System.IDisposable)val3)?.Dispose();
					}
				}
				Image val4 = (Image)(object)O.A((Image)(object)GeneralResources.IconOffline, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f);
				e.Graphics.DrawImage(val4, 50 - val4.Width / 2, 50 - val4.Height / 2, val4.Width, val4.Height);
				val4.Dispose();
				Font val5 = new Font(((Control)this).Font.FontFamily, 13f, (FontStyle)1);
				try
				{
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhg(), val5, Brushes.Red, 110f, 35f);
				}
				finally
				{
					((System.IDisposable)val5)?.Dispose();
				}
			}
		}

		private const int OV = 33;

		private const int Ov = 100;

		private const int OW = 120;

		private List<Panel> Ow = new List<Panel>();

		private c OX;

		private string Ox = string.Empty;

		private BF OY;

		private IContainer Oy;

		private Label OZ;

		internal Bf(List<F> P_0, string P_1)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			b();
			((Control)this).BackColor = BM.tE;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			OX = new c(this);
			Ox = P_1;
			A(P_0, P_1);
			OY = BF.OT;
			global::A.A.A(new EventHandler(a));
			global::A.A.A((global::A.D)A);
		}

		private void A(List<F> P_0, string P_1)
		{
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Unknown
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cb: Expected O, but got Unknown
			if (((Control)this).Controls.Contains((Control)(object)OX))
			{
				((Control)this).Controls.Remove((Control)(object)OX);
			}
			Ow.Clear();
			while (((ArrangedElementCollection)((Control)this).Controls).Count != 1)
			{
				foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val = item;
					if (!(val is Panel))
					{
						continue;
					}
					Panel val2 = (Panel)(object)((val is Panel) ? val : null);
					((Control)val2).Paint -= new PaintEventHandler(A);
					((Control)val2).Tag = null;
					foreach (Control item2 in (ArrangedElementCollection)((Control)val2).Controls)
					{
						item2.Tag = null;
						((Component)item2).Dispose();
					}
					((Component)val2).Dispose();
					break;
				}
			}
			bool flag = false;
			Enumerator<F> enumerator3 = P_0.GetEnumerator();
			Rectangle clientRectangle;
			try
			{
				while (enumerator3.MoveNext())
				{
					F current = enumerator3.Current;
					Panel val4 = new Panel();
					((Control)val4).Tag = current;
					((Control)val4).BackColor = ((Control)this).BackColor;
					((Control)val4).Left = 0;
					clientRectangle = ((Control)this).ClientRectangle;
					((Control)val4).Width = ((Rectangle)(ref clientRectangle)).Width;
					((Control)val4).Height = 100;
					((Control)val4).Paint += new PaintEventHandler(A);
					b b = new b(this);
					((Control)b).Tag = current;
					((Control)b).BackColor = ((Control)this).BackColor;
					((Control)b).Left = ((Control)val4).Width - 120;
					((Control)b).Top = 0;
					((Control)b).Width = 120;
					((Control)b).Height = 50;
					((Control)val4).Controls.Add((Control)(object)b);
					if (b.A())
					{
						((Form)this).CancelButton = (IButtonControl)(object)b;
						flag = true;
					}
					C c = new C(this);
					((Control)c).Tag = current;
					((Control)c).BackColor = ((Control)this).BackColor;
					((Control)c).Left = ((Control)val4).Width - 120;
					((Control)c).Top = 50;
					((Control)c).Width = 120;
					((Control)c).Height = 50;
					((Control)val4).Controls.Add((Control)(object)c);
					bW bW = new bW
					{
						axS = current.aH,
						axs = current.ah,
						axt = current.aO,
						axT = new k(current.ae, current.aF, current.af, current.aG, current.ag)
					};
					bW bW2 = null;
					if (BM.Qz != null)
					{
						bW2 = new bW
						{
							axS = BM.Qz.awZ,
							axs = BM.Qz.awz,
							axT = BM.Qz.aXA,
							axt = BM.Qz.F()
						};
					}
					int num;
					if (!string.IsNullOrEmpty(P_1))
					{
						num = ((current.ao == P_1) ? 1 : 0);
						if (num != 0)
						{
							goto IL_0357;
						}
					}
					else
					{
						num = 0;
					}
					if (BM.Qz == null || !BM.Qz.c() || !BM.Qz.E() || !(bW == bW2) || current.aq != 1 || ((uint)BM.qI & 2u) != 0 || ((uint)BM.qI & 0x100u) != 0 || ((uint)BM.qI & 0x20u) != 0)
					{
						goto IL_0357;
					}
					((Control)c).Enabled = true;
					goto IL_035f;
					IL_035f:
					if (num != 0)
					{
						((Control)val4).Top = 33;
						if (Ow.Count == 0)
						{
							Ow.Add(val4);
						}
						else
						{
							Enumerator<Panel> enumerator4 = Ow.GetEnumerator();
							try
							{
								while (enumerator4.MoveNext())
								{
									Panel current2 = enumerator4.Current;
									((Control)current2).Top = ((Control)current2).Top + 100;
									foreach (Control item3 in (ArrangedElementCollection)((Control)current2).Controls)
									{
										Control val5 = item3;
										if (val5 is Button)
										{
											val5.TabIndex += 2;
										}
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator4).Dispose();
							}
							Ow.Insert(0, val4);
						}
						((Control)b).TabIndex = 0;
						((Control)c).TabIndex = 1;
					}
					else
					{
						((Control)val4).Top = 33 + Ow.Count * 100;
						int count = Ow.Count;
						Ow.Add(val4);
						((Control)b).TabIndex = count * 2;
						((Control)c).TabIndex = count * 2 + 1;
					}
					((Control)this).Controls.Add((Control)(object)val4);
					continue;
					IL_0357:
					((Control)c).Enabled = false;
					goto IL_035f;
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			((Control)OX).BackColor = ((Control)this).BackColor;
			((Control)OX).Left = 0;
			((Control)OX).Top = 33 + Ow.Count * 100;
			c oX = OX;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)oX).Width = ((Rectangle)(ref clientRectangle)).Width;
			((Control)OX).Height = 100;
			((Control)OX).TabIndex = Ow.Count * 2;
			((Control)this).Controls.Add((Control)(object)OX);
			if (!flag)
			{
				((Form)this).CancelButton = (IButtonControl)(object)OX;
			}
			((Control)this).Height = 75 + (P_0.Count + 1) * 100;
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			c oX = OX;
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			((Control)oX).Width = ((Rectangle)(ref clientRectangle)).Width;
			Enumerator<Panel> enumerator = Ow.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Panel current = enumerator.Current;
					clientRectangle = ((Control)this).ClientRectangle;
					((Control)current).Width = ((Rectangle)(ref clientRectangle)).Width;
					foreach (Control item in (ArrangedElementCollection)((Control)current).Controls)
					{
						Control val = item;
						if (val is Button)
						{
							val.Left = ((Control)current).Width - 120;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			A();
			if (BM.qG != null && !((Control)BM.qG).IsDisposed && ((Control)BM.qG).Visible)
			{
				((Control)BM.qG).Hide();
			}
			if (BM.qg != null && !((Control)BM.qg).IsDisposed && ((Control)BM.qg).Visible)
			{
				((Control)BM.qg).Hide();
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = this.a;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			List<F> val = global::A.A.c();
			A(val, Ox);
			A();
		}

		private void A(object P_0, E P_1)
		{
			try
			{
				if (((Control)this).IsDisposed)
				{
					return;
				}
				if (((Control)this).InvokeRequired)
				{
					try
					{
						a a = A;
						((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
						return;
					}
					catch
					{
						return;
					}
				}
				if (P_0 is string)
				{
					string obj2 = P_0 as string;
					d t = P_1.t;
					string text = string.Empty;
					if (obj2 != Ox || t == d.S)
					{
						text = Ox;
					}
					else
					{
						Ox = string.Empty;
					}
					List<F> val = global::A.A.c();
					A(val, text);
					A();
				}
			}
			catch
			{
			}
		}

		private void A()
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			if (Ow.Count == 1 || !string.IsNullOrEmpty(Ox))
			{
				bool flag = false;
				Enumerator<Panel> enumerator = Ow.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Panel current = enumerator.Current;
						F f = ((Control)current).Tag as F;
						if ((Ow.Count == 1 || (!string.IsNullOrEmpty(Ox) && f.ao == Ox)) && ((ArrangedElementCollection)((Control)current).Controls).Count != 0 && ((Control)current).Controls[0] is b)
						{
							((Control)(((Control)current).Controls[0] as b)).Focus();
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
					((Control)OX).Focus();
				}
			}
			else
			{
				((Control)OX).Focus();
			}
		}

		private void A(object P_0, PaintEventArgs P_1)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected O, but got Unknown
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Expected O, but got Unknown
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected O, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected O, but got Unknown
			Panel val = (Panel)((P_0 is Panel) ? P_0 : null);
			SolidBrush val2 = new SolidBrush(((Control)this).BackColor);
			try
			{
				P_1.Graphics.FillRectangle((Brush)(object)val2, 0, 0, ((Control)val).Width, ((Control)val).Height);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			F f = ((Control)val).Tag as F;
			int aH = f.aH;
			int ah = f.ah;
			k k = new k(f.ae, f.aF, f.af, f.aG, f.ag);
			Image val3 = bx.c(aH, ah);
			if (val3 != null)
			{
				P_1.Graphics.DrawImage(val3, 10, 10, 80, 80);
			}
			string text = string.Empty;
			switch (global::A.A.E(f.ao))
			{
			case g.BI:
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jx();
				break;
			case g.Bj:
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jx();
				break;
			case g.BJ:
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jx();
				break;
			case g.Bi:
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jY();
				break;
			}
			if (!string.IsNullOrEmpty(Ox) && f.ao == Ox)
			{
				SolidBrush val4 = new SolidBrush(Color.FromArgb(255, 0, 128, 0));
				try
				{
					Font val5 = new Font(((Control)this).Font.FontFamily, 13f, (FontStyle)1);
					try
					{
						P_1.Graphics.DrawString(bx.C(aH, ah) + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jy(), val5, (Brush)(object)val4, 110f, 10f);
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
			else
			{
				SolidBrush val6 = new SolidBrush(BM.te);
				try
				{
					Font val7 = new Font(((Control)this).Font.FontFamily, 13f, (FontStyle)1);
					try
					{
						P_1.Graphics.DrawString(bx.C(aH, ah) + text, val7, (Brush)(object)val6, 110f, 10f);
					}
					finally
					{
						((System.IDisposable)val7)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val6)?.Dispose();
				}
			}
			SolidBrush val8 = new SolidBrush(BM.te);
			try
			{
				Font val9 = new Font(((Control)this).Font.FontFamily, 13f, (FontStyle)0);
				try
				{
					P_1.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jZ() + (object)k, val9, (Brush)(object)val8, 110f, 35f);
					P_1.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jz() + f.ao, val9, (Brush)(object)val8, 110f, 60f);
				}
				finally
				{
					((System.IDisposable)val9)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val8)?.Dispose();
			}
		}

		[SpecialName]
		internal string a()
		{
			return Ox;
		}

		[SpecialName]
		internal BF B()
		{
			return OY;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			global::A.A.a(new EventHandler(a));
			global::A.A.a((global::A.D)A);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && Oy != null)
			{
				((System.IDisposable)Oy).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void b()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			OZ = new Label();
			((Control)this).SuspendLayout();
			((Control)OZ).AutoSize = true;
			((Control)OZ).Location = new Point(7, 9);
			((Control)OZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)OZ).Size = new Size(343, 13);
			((Control)OZ).TabIndex = 2;
			((Control)OZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KA();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(554, 61);
			((Form)this).ControlBox = false;
			((Control)this).Controls.Add((Control)(object)OZ);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ka();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KB();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal class bF : Form
	{
		private const int aAx = 5;

		private List<Setting> aAY;

		private double aAy;

		private double aAZ;

		private Dictionary<int, int> aAz = new Dictionary<int, int>();

		private Dictionary<int, int> aaA = new Dictionary<int, int>();

		private Dictionary<int, int> aaa = new Dictionary<int, int>();

		private int aaB;

		private List<Label> aab = new List<Label>();

		private List<TextBox> aaC = new List<TextBox>();

		private List<TextBox> aac = new List<TextBox>();

		private List<cY> aaD = new List<cY>();

		private IContainer aad;

		private ThemedButton aaE;

		private ThemedButton aae;

		private Label aaF;

		private Label aaf;

		private Label aaG;

		private Label aag;

		private Label aaH;

		private Label aah;

		private Label aaI;

		private Label aai;

		private Label aaJ;

		private Label aaj;

		private ThemedTextBox aaK;

		private ThemedTextBox aak;

		private ThemedTextBox aaL;

		private ThemedTextBox aal;

		private ThemedTextBox aaM;

		private ThemedTextBox aam;

		private ThemedTextBox aaN;

		private ThemedTextBox aan;

		private ThemedTextBox aaO;

		private ThemedTextBox aao;

		private ThemedTextBox aaP;

		private ThemedTextBox aap;

		private ThemedTextBox aaQ;

		private ThemedTextBox aaq;

		private ThemedTextBox aaR;

		private ThemedTextBox aar;

		private ThemedTextBox aaS;

		private ThemedTextBox aas;

		private ThemedTextBox aaT;

		private ThemedTextBox aat;

		private Label aaU;

		private Label aau;

		private NumericUpDown aaV;

		private Label aav;

		private Label aaW;

		private Label aaw;

		private cY aaX;

		private cY aax;

		private cY aaY;

		private cY aay;

		private cY aaZ;

		private cY aaz;

		private cY aBA;

		private cY aBa;

		private cY aBB;

		private cY aBb;

		private aP aBC;

		private Label aBc;

		private Label aBD;

		private ThemedTextBox aBd;

		private ThemedTextBox aBE;

		internal bF()
		{
			d();
		}

		internal bF(List<Setting> P_0, bool P_1, double P_2, double P_3, Dictionary<int, int> P_4, Dictionary<int, int> P_5, Dictionary<int, int> P_6, int P_7)
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0744: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_079a: Unknown result type (might be due to invalid IL or missing references)
			//IL_079f: Unknown result type (might be due to invalid IL or missing references)
			//IL_080b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0810: Unknown result type (might be due to invalid IL or missing references)
			d();
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
			aAy = P_2;
			aAZ = P_3;
			aAY = P_0;
			Enumerator<int, int> enumerator2 = P_4.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, int> current = enumerator2.Current;
					aAz.Add(current.Key, current.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			enumerator2 = P_5.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, int> current2 = enumerator2.Current;
					aaA.Add(current2.Key, current2.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			enumerator2 = P_6.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, int> current3 = enumerator2.Current;
					aaa.Add(current3.Key, current3.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			aaB = P_7;
			aab.Add(aaF);
			aab.Add(aaf);
			aab.Add(aaG);
			aab.Add(aag);
			aab.Add(aaH);
			aab.Add(aah);
			aab.Add(aaI);
			aab.Add(aai);
			aab.Add(aaJ);
			aab.Add(aaj);
			aaC.Add((TextBox)(object)aaK);
			aaC.Add((TextBox)(object)aak);
			aaC.Add((TextBox)(object)aaL);
			aaC.Add((TextBox)(object)aal);
			aaC.Add((TextBox)(object)aaM);
			aaC.Add((TextBox)(object)aam);
			aaC.Add((TextBox)(object)aaN);
			aaC.Add((TextBox)(object)aan);
			aaC.Add((TextBox)(object)aaO);
			aaC.Add((TextBox)(object)aao);
			aac.Add((TextBox)(object)aat);
			aac.Add((TextBox)(object)aaT);
			aac.Add((TextBox)(object)aas);
			aac.Add((TextBox)(object)aaS);
			aac.Add((TextBox)(object)aar);
			aac.Add((TextBox)(object)aaR);
			aac.Add((TextBox)(object)aaq);
			aac.Add((TextBox)(object)aaQ);
			aac.Add((TextBox)(object)aap);
			aac.Add((TextBox)(object)aaP);
			aaD.Add(aaX);
			aaD.Add(aax);
			aaD.Add(aaY);
			aaD.Add(aay);
			aaD.Add(aaZ);
			aaD.Add(aaz);
			aaD.Add(aBA);
			aaD.Add(aBa);
			aaD.Add(aBB);
			aaD.Add(aBb);
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < co.BKu.Length; j++)
				{
					((ComboBox)aaD[i]).Items.Add((object)((object)(Color)(ref co.BKu[j])).ToString());
				}
			}
			int num = 0;
			for (int k = 0; k < 10; k++)
			{
				if (aAY.Count > k)
				{
					Setting setting = aAY[k];
					int num2 = setting.aS();
					string text = ((SettingOrSpecialObject)setting).H();
					if (!string.IsNullOrWhiteSpace(text))
					{
						if (num2 != 0 && num2 != 82)
						{
							((Control)aab[k]).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting.@as(), num2, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
						}
						else
						{
							((Control)aab[k]).Text = text;
						}
					}
					else if (num2 != 0 && num2 != 82)
					{
						((Control)aab[k]).Text = ((SettingOrSpecialObject)setting).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting.@as(), num2, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					else
					{
						((Control)aab[k]).Text = ((SettingOrSpecialObject)setting).A(bz.aYt);
					}
					((Control)aaC[k]).Text = bS.a(aAz[setting.A()], num2, -1);
					((Control)aac[k]).Text = bS.a(aaA[setting.A()], num2, -1);
					((Control)aaC[k]).Visible = true;
					((Control)aac[k]).Visible = true;
					((Control)aaD[k]).Visible = true;
					((ListControl)aaD[k]).SelectedIndex = aaa[setting.A()];
					Size val2 = TextRenderer.MeasureText(((Control)aab[k]).Text, ((Control)this).Font);
					int width = ((Size)(ref val2)).Width;
					if (width > num)
					{
						num = width;
					}
				}
				else
				{
					((Control)aab[k]).Text = string.Empty;
					((Control)aaC[k]).Visible = false;
					((Control)aac[k]).Visible = false;
					((Control)aaD[k]).Visible = false;
				}
			}
			num += 75;
			int num3 = 0;
			int num4 = 5 + num;
			((Control)aaU).Left = 2 + num4;
			Enumerator<TextBox> enumerator3 = aaC.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					((Control)enumerator3.Current).Left = num4;
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			int num5 = 5 + num + ((Control)aaC[0]).Width + 5;
			((Control)aau).Left = 2 + num5;
			enumerator3 = aac.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					((Control)enumerator3.Current).Left = num5;
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			int num6 = 5 + num + ((Control)aaC[0]).Width + 5 + ((Control)aac[0]).Width + 5;
			((Control)aaw).Left = 2 + num6;
			Enumerator<cY> enumerator4 = aaD.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					cY current4 = enumerator4.Current;
					((Control)current4).Left = num6;
					num3 = ((Control)current4).Right + 20;
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			((Control)aBC).Top = ((Control)aaK).Top + aAY.Count * (((Control)aak).Top - ((Control)aaK).Top) + 10;
			((Control)aBD).Top = ((Control)aBC).Top + 20;
			((Control)aBc).Top = ((Control)aBD).Top;
			((Control)aBE).Top = ((Control)aBD).Top + 18;
			((Control)aBd).Top = ((Control)aBE).Top;
			((Control)aaV).Top = ((Control)aBE).Top + 38;
			((Control)aav).Top = ((Control)aaV).Top + 3;
			((Control)aaW).Top = ((Control)aav).Top;
			decimal num7 = decimal.op_Implicit(aaB) / 1000m;
			num7 = Math.Min(Math.Max(num7, aaV.Minimum), aaV.Maximum);
			aaV.Value = num7;
			((Control)aaE).Top = ((Control)aBC).Top + 67;
			((Control)aae).Top = ((Control)aaE).Top;
			((Control)aae).Left = num3 - ((Control)aae).Width - 20;
			((Control)aaE).Left = ((Control)aae).Left - ((Control)aaE).Width - 5;
			((Control)this).Width = num3;
			((Control)this).Height = ((Control)aaE).Bottom + 50;
			((Control)aBE).Text = aAy.ToString();
			((Control)aBd).Text = aAZ.ToString();
			((CheckBox)aBC).Checked = P_1;
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			((Control)aBE).Enabled = ((CheckBox)aBC).Checked;
			((Control)aBd).Enabled = ((CheckBox)aBC).Checked;
			Enumerator<TextBox> enumerator = aaC.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Enabled = !((CheckBox)aBC).Checked;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = aac.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Enabled = !((CheckBox)aBC).Checked;
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
			return ((CheckBox)aBC).Checked;
		}

		[SpecialName]
		internal double a()
		{
			return aAy;
		}

		[SpecialName]
		internal double B()
		{
			return aAZ;
		}

		[SpecialName]
		internal Dictionary<int, int> b()
		{
			return aAz;
		}

		[SpecialName]
		internal Dictionary<int, int> C()
		{
			return aaA;
		}

		[SpecialName]
		internal Dictionary<int, int> c()
		{
			return aaa;
		}

		[SpecialName]
		internal int D()
		{
			return aaB;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			string text = null;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			string text2 = string.Empty;
			string text3 = string.Empty;
			try
			{
				if (((CheckBox)aBC).Checked)
				{
					double num = double.Parse(((Control)aBE).Text);
					double num2 = double.Parse(((Control)aBd).Text);
					if (num >= num2)
					{
						flag = true;
						throw new System.Exception();
					}
					aAy = num;
					aAZ = num2;
				}
				else
				{
					for (int i = 0; i < aAY.Count; i++)
					{
						Setting setting = aAY[i];
						int num3 = setting.aS();
						int num4 = setting.aR();
						int num5 = setting.ar();
						flag = false;
						flag2 = false;
						flag3 = false;
						text2 = bS.a(num4, num3, -1);
						text3 = bS.a(num5, num3, -1);
						text = ((Control)aab[i]).Text;
						int num6 = bS.A(((Control)aaC[i]).Text, num3);
						int num7 = bS.A(((Control)aac[i]).Text, num3);
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
						}
						aAz[setting.A()] = num6;
						aaA[setting.A()] = num7;
					}
				}
				for (int j = 0; j < aAY.Count; j++)
				{
					aaa[aAY[j].A()] = ((ListControl)aaD[j]).SelectedIndex;
				}
				aaB = (int)(aaV.Value * 1000m);
			}
			catch
			{
				if (flag)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Le(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (flag2 || flag3)
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

		private void A(cY P_0, int P_1, DrawItemEventArgs P_2)
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			if (((ComboBox)P_0).DroppedDown)
			{
				SolidBrush val = new SolidBrush(co.BKu[P_2.Index]);
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
			SolidBrush val2 = new SolidBrush(co.BKu[((ListControl)aaD[P_1]).SelectedIndex]);
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
			A(P_0 as cY, 0, P_1);
		}

		private void a(object P_0, DrawItemEventArgs P_1)
		{
			A(P_0 as cY, 1, P_1);
		}

		private void B(object P_0, DrawItemEventArgs P_1)
		{
			A(P_0 as cY, 2, P_1);
		}

		private void b(object P_0, DrawItemEventArgs P_1)
		{
			A(P_0 as cY, 3, P_1);
		}

		private void C(object P_0, DrawItemEventArgs P_1)
		{
			A(P_0 as cY, 4, P_1);
		}

		private void c(object P_0, DrawItemEventArgs P_1)
		{
			A(P_0 as cY, 5, P_1);
		}

		private void D(object P_0, DrawItemEventArgs P_1)
		{
			A(P_0 as cY, 6, P_1);
		}

		private void d(object P_0, DrawItemEventArgs P_1)
		{
			A(P_0 as cY, 7, P_1);
		}

		private void E(object P_0, DrawItemEventArgs P_1)
		{
			A(P_0 as cY, 8, P_1);
		}

		private void e(object P_0, DrawItemEventArgs P_1)
		{
			A(P_0 as cY, 9, P_1);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aad != null)
			{
				((System.IDisposable)aad).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void d()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected O, but got Unknown
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Expected O, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Expected O, but got Unknown
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Expected O, but got Unknown
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected O, but got Unknown
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_0496: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_0598: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_061f: Unknown result type (might be due to invalid IL or missing references)
			//IL_065f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0683: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_071b: Unknown result type (might be due to invalid IL or missing references)
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0762: Unknown result type (might be due to invalid IL or missing references)
			//IL_0786: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0814: Unknown result type (might be due to invalid IL or missing references)
			//IL_0838: Unknown result type (might be due to invalid IL or missing references)
			//IL_085c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0883: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0919: Unknown result type (might be due to invalid IL or missing references)
			//IL_093d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0964: Unknown result type (might be due to invalid IL or missing references)
			//IL_0988: Unknown result type (might be due to invalid IL or missing references)
			//IL_09af: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fee: Expected O, but got Unknown
			//IL_101f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1050: Unknown result type (might be due to invalid IL or missing references)
			//IL_1073: Unknown result type (might be due to invalid IL or missing references)
			//IL_107d: Expected O, but got Unknown
			//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_10df: Unknown result type (might be due to invalid IL or missing references)
			//IL_1103: Unknown result type (might be due to invalid IL or missing references)
			//IL_110d: Expected O, but got Unknown
			//IL_113e: Unknown result type (might be due to invalid IL or missing references)
			//IL_116f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1193: Unknown result type (might be due to invalid IL or missing references)
			//IL_119d: Expected O, but got Unknown
			//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1223: Unknown result type (might be due to invalid IL or missing references)
			//IL_122d: Expected O, but got Unknown
			//IL_1261: Unknown result type (might be due to invalid IL or missing references)
			//IL_1292: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c0: Expected O, but got Unknown
			//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1325: Unknown result type (might be due to invalid IL or missing references)
			//IL_1349: Unknown result type (might be due to invalid IL or missing references)
			//IL_1353: Expected O, but got Unknown
			//IL_1387: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_13dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e6: Expected O, but got Unknown
			//IL_141a: Unknown result type (might be due to invalid IL or missing references)
			//IL_144b: Unknown result type (might be due to invalid IL or missing references)
			//IL_146f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1479: Expected O, but got Unknown
			//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_14de: Unknown result type (might be due to invalid IL or missing references)
			//IL_1502: Unknown result type (might be due to invalid IL or missing references)
			//IL_150c: Expected O, but got Unknown
			//IL_1525: Unknown result type (might be due to invalid IL or missing references)
			//IL_154c: Unknown result type (might be due to invalid IL or missing references)
			//IL_158c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1596: Expected O, but got Unknown
			//IL_15af: Unknown result type (might be due to invalid IL or missing references)
			//IL_15d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1613: Unknown result type (might be due to invalid IL or missing references)
			//IL_1637: Unknown result type (might be due to invalid IL or missing references)
			//IL_1677: Unknown result type (might be due to invalid IL or missing references)
			//IL_169b: Unknown result type (might be due to invalid IL or missing references)
			//IL_16cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_171d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1745: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ae2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aec: Expected O, but got Unknown
			//IL_1b34: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b3e: Expected O, but got Unknown
			aaE = new ThemedButton();
			aae = new ThemedButton();
			aaF = new Label();
			aaf = new Label();
			aaG = new Label();
			aag = new Label();
			aaH = new Label();
			aah = new Label();
			aaI = new Label();
			aai = new Label();
			aaJ = new Label();
			aaj = new Label();
			aaK = new ThemedTextBox();
			aak = new ThemedTextBox();
			aaL = new ThemedTextBox();
			aal = new ThemedTextBox();
			aaM = new ThemedTextBox();
			aam = new ThemedTextBox();
			aaN = new ThemedTextBox();
			aan = new ThemedTextBox();
			aaO = new ThemedTextBox();
			aao = new ThemedTextBox();
			aaP = new ThemedTextBox();
			aap = new ThemedTextBox();
			aaQ = new ThemedTextBox();
			aaq = new ThemedTextBox();
			aaR = new ThemedTextBox();
			aar = new ThemedTextBox();
			aaS = new ThemedTextBox();
			aas = new ThemedTextBox();
			aaT = new ThemedTextBox();
			aat = new ThemedTextBox();
			aaU = new Label();
			aau = new Label();
			aaV = new NumericUpDown();
			aav = new Label();
			aaW = new Label();
			aaw = new Label();
			aaX = new cY();
			aax = new cY();
			aaY = new cY();
			aay = new cY();
			aaZ = new cY();
			aaz = new cY();
			aBA = new cY();
			aBa = new cY();
			aBB = new cY();
			aBb = new cY();
			aBC = new aP();
			aBc = new Label();
			aBD = new Label();
			aBd = new ThemedTextBox();
			aBE = new ThemedTextBox();
			((ISupportInitialize)aaV).BeginInit();
			((Control)this).SuspendLayout();
			((Button)aaE).DialogResult = (DialogResult)1;
			((Control)aaE).Location = new Point(388, 317);
			((Control)aaE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)aaE).Size = new Size(89, 34);
			((Control)aaE).TabIndex = 0;
			((Control)aaE).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)aaE).UseVisualStyleBackColor = true;
			((Button)aae).DialogResult = (DialogResult)2;
			((Control)aae).Location = new Point(483, 317);
			((Control)aae).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)aae).Size = new Size(89, 34);
			((Control)aae).TabIndex = 1;
			((Control)aae).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)aae).UseVisualStyleBackColor = true;
			((Control)aaF).AutoSize = true;
			((Control)aaF).Location = new Point(9, 24);
			((Control)aaF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)aaF).Size = new Size(38, 13);
			((Control)aaF).TabIndex = 2;
			((Control)aaF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)aaf).AutoSize = true;
			((Control)aaf).Location = new Point(9, 46);
			((Control)aaf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)aaf).Size = new Size(38, 13);
			((Control)aaf).TabIndex = 3;
			((Control)aaf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)aaG).AutoSize = true;
			((Control)aaG).Location = new Point(9, 68);
			((Control)aaG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)aaG).Size = new Size(38, 13);
			((Control)aaG).TabIndex = 4;
			((Control)aaG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)aag).AutoSize = true;
			((Control)aag).Location = new Point(9, 90);
			((Control)aag).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)aag).Size = new Size(38, 13);
			((Control)aag).TabIndex = 5;
			((Control)aag).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)aaH).AutoSize = true;
			((Control)aaH).Location = new Point(9, 112);
			((Control)aaH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Io();
			((Control)aaH).Size = new Size(38, 13);
			((Control)aaH).TabIndex = 6;
			((Control)aaH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Io();
			((Control)aah).AutoSize = true;
			((Control)aah).Location = new Point(9, 134);
			((Control)aah).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ip();
			((Control)aah).Size = new Size(38, 13);
			((Control)aah).TabIndex = 7;
			((Control)aah).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ip();
			((Control)aaI).AutoSize = true;
			((Control)aaI).Location = new Point(9, 156);
			((Control)aaI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iq();
			((Control)aaI).Size = new Size(38, 13);
			((Control)aaI).TabIndex = 8;
			((Control)aaI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iq();
			((Control)aai).AutoSize = true;
			((Control)aai).Location = new Point(9, 178);
			((Control)aai).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GB();
			((Control)aai).Size = new Size(38, 13);
			((Control)aai).TabIndex = 9;
			((Control)aai).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GB();
			((Control)aaJ).AutoSize = true;
			((Control)aaJ).Location = new Point(9, 200);
			((Control)aaJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GC();
			((Control)aaJ).Size = new Size(38, 13);
			((Control)aaJ).TabIndex = 10;
			((Control)aaJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GC();
			((Control)aaj).AutoSize = true;
			((Control)aaj).Location = new Point(9, 222);
			((Control)aaj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GD();
			((Control)aaj).Size = new Size(44, 13);
			((Control)aaj).TabIndex = 11;
			((Control)aaj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GD();
			((Control)aaK).Location = new Point(308, 21);
			((Control)aaK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aal();
			((Control)aaK).Size = new Size(100, 22);
			((Control)aaK).TabIndex = 2;
			((Control)aak).Location = new Point(308, 43);
			((Control)aak).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaM();
			((Control)aak).Size = new Size(100, 22);
			((Control)aak).TabIndex = 5;
			((Control)aaL).Location = new Point(308, 65);
			((Control)aaL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aam();
			((Control)aaL).Size = new Size(100, 22);
			((Control)aaL).TabIndex = 8;
			((Control)aal).Location = new Point(308, 87);
			((Control)aal).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaN();
			((Control)aal).Size = new Size(100, 22);
			((Control)aal).TabIndex = 11;
			((Control)aaM).Location = new Point(308, 109);
			((Control)aaM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aan();
			((Control)aaM).Size = new Size(100, 22);
			((Control)aaM).TabIndex = 14;
			((Control)aam).Location = new Point(308, 131);
			((Control)aam).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaO();
			((Control)aam).Size = new Size(100, 22);
			((Control)aam).TabIndex = 17;
			((Control)aaN).Location = new Point(308, 153);
			((Control)aaN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aao();
			((Control)aaN).Size = new Size(100, 22);
			((Control)aaN).TabIndex = 20;
			((Control)aan).Location = new Point(308, 175);
			((Control)aan).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaP();
			((Control)aan).Size = new Size(100, 22);
			((Control)aan).TabIndex = 23;
			((Control)aaO).Location = new Point(308, 197);
			((Control)aaO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aap();
			((Control)aaO).Size = new Size(100, 22);
			((Control)aaO).TabIndex = 26;
			((Control)aao).Location = new Point(308, 219);
			((Control)aao).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaQ();
			((Control)aao).Size = new Size(100, 22);
			((Control)aao).TabIndex = 29;
			((Control)aaP).Location = new Point(414, 219);
			((Control)aaP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaq();
			((Control)aaP).Size = new Size(100, 22);
			((Control)aaP).TabIndex = 30;
			((Control)aap).Location = new Point(414, 197);
			((Control)aap).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaR();
			((Control)aap).Size = new Size(100, 22);
			((Control)aap).TabIndex = 27;
			((Control)aaQ).Location = new Point(414, 175);
			((Control)aaQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aar();
			((Control)aaQ).Size = new Size(100, 22);
			((Control)aaQ).TabIndex = 24;
			((Control)aaq).Location = new Point(414, 153);
			((Control)aaq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaS();
			((Control)aaq).Size = new Size(100, 22);
			((Control)aaq).TabIndex = 21;
			((Control)aaR).Location = new Point(414, 131);
			((Control)aaR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aas();
			((Control)aaR).Size = new Size(100, 22);
			((Control)aaR).TabIndex = 18;
			((Control)aar).Location = new Point(414, 109);
			((Control)aar).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaT();
			((Control)aar).Size = new Size(100, 22);
			((Control)aar).TabIndex = 15;
			((Control)aaS).Location = new Point(414, 87);
			((Control)aaS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aat();
			((Control)aaS).Size = new Size(100, 22);
			((Control)aaS).TabIndex = 12;
			((Control)aas).Location = new Point(414, 65);
			((Control)aas).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaU();
			((Control)aas).Size = new Size(100, 22);
			((Control)aas).TabIndex = 9;
			((Control)aaT).Location = new Point(414, 43);
			((Control)aaT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aau();
			((Control)aaT).Size = new Size(100, 22);
			((Control)aaT).TabIndex = 6;
			((Control)aat).Location = new Point(414, 21);
			((Control)aat).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaV();
			((Control)aat).Size = new Size(100, 22);
			((Control)aat).TabIndex = 3;
			((Control)aaU).AutoSize = true;
			((Control)aaU).Location = new Point(310, 5);
			((Control)aaU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aav();
			((Control)aaU).Size = new Size(55, 13);
			((Control)aaU).TabIndex = 32;
			((Control)aaU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ts();
			((Control)aau).AutoSize = true;
			((Control)aau).Location = new Point(416, 5);
			((Control)aau).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaW();
			((Control)aau).Size = new Size(56, 13);
			((Control)aau).TabIndex = 33;
			((Control)aau).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jp();
			aaV.DecimalPlaces = 1;
			((Control)aaV).Location = new Point(75, 324);
			aaV.Maximum = new decimal(new int[4] { 60, 0, 0, 0 });
			aaV.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			((Control)aaV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaw();
			((Control)aaV).Size = new Size(72, 22);
			((Control)aaV).TabIndex = 32;
			aaV.Value = new decimal(new int[4] { 10, 0, 0, 0 });
			((Control)aav).AutoSize = true;
			((Control)aav).Location = new Point(9, 327);
			((Control)aav).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gf();
			((Control)aav).Size = new Size(63, 13);
			((Control)aav).TabIndex = 35;
			((Control)aav).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaX();
			((Control)aaW).AutoSize = true;
			((Control)aaW).Location = new Point(154, 327);
			((Control)aaW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gg();
			((Control)aaW).Size = new Size(50, 13);
			((Control)aaW).TabIndex = 36;
			((Control)aaW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tP();
			((Control)aaw).AutoSize = true;
			((Control)aaw).Location = new Point(525, 5);
			((Control)aaw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aax();
			((Control)aaw).Size = new Size(42, 13);
			((Control)aaw).TabIndex = 37;
			((Control)aaw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tR();
			((ComboBox)aaX).DrawMode = (DrawMode)1;
			((ComboBox)aaX).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aaX).FormattingEnabled = true;
			((Control)aaX).Location = new Point(523, 20);
			((ComboBox)aaX).MaxDropDownItems = 10;
			((Control)aaX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaY();
			((Control)aaX).Size = new Size(47, 23);
			((Control)aaX).TabIndex = 4;
			((ComboBox)aaX).DrawItem += new DrawItemEventHandler(A);
			((ComboBox)aax).DrawMode = (DrawMode)1;
			((ComboBox)aax).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aax).FormattingEnabled = true;
			((Control)aax).Location = new Point(523, 42);
			((ComboBox)aax).MaxDropDownItems = 10;
			((Control)aax).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aay();
			((Control)aax).Size = new Size(47, 23);
			((Control)aax).TabIndex = 7;
			((ComboBox)aax).DrawItem += new DrawItemEventHandler(a);
			((ComboBox)aaY).DrawMode = (DrawMode)1;
			((ComboBox)aaY).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aaY).FormattingEnabled = true;
			((Control)aaY).Location = new Point(523, 64);
			((ComboBox)aaY).MaxDropDownItems = 10;
			((Control)aaY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaZ();
			((Control)aaY).Size = new Size(47, 23);
			((Control)aaY).TabIndex = 10;
			((ComboBox)aaY).DrawItem += new DrawItemEventHandler(B);
			((ComboBox)aay).DrawMode = (DrawMode)1;
			((ComboBox)aay).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aay).FormattingEnabled = true;
			((Control)aay).Location = new Point(523, 86);
			((ComboBox)aay).MaxDropDownItems = 10;
			((Control)aay).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaz();
			((Control)aay).Size = new Size(47, 23);
			((Control)aay).TabIndex = 13;
			((ComboBox)aay).DrawItem += new DrawItemEventHandler(b);
			((ComboBox)aaZ).DrawMode = (DrawMode)1;
			((ComboBox)aaZ).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aaZ).FormattingEnabled = true;
			((Control)aaZ).Location = new Point(523, 108);
			((ComboBox)aaZ).MaxDropDownItems = 10;
			((Control)aaZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBA();
			((Control)aaZ).Size = new Size(47, 23);
			((Control)aaZ).TabIndex = 16;
			((ComboBox)aaZ).DrawItem += new DrawItemEventHandler(C);
			((ComboBox)aaz).DrawMode = (DrawMode)1;
			((ComboBox)aaz).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aaz).FormattingEnabled = true;
			((Control)aaz).Location = new Point(523, 130);
			((ComboBox)aaz).MaxDropDownItems = 10;
			((Control)aaz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBa();
			((Control)aaz).Size = new Size(47, 23);
			((Control)aaz).TabIndex = 19;
			((ComboBox)aaz).DrawItem += new DrawItemEventHandler(c);
			((ComboBox)aBA).DrawMode = (DrawMode)1;
			((ComboBox)aBA).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aBA).FormattingEnabled = true;
			((Control)aBA).Location = new Point(523, 152);
			((ComboBox)aBA).MaxDropDownItems = 10;
			((Control)aBA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBB();
			((Control)aBA).Size = new Size(47, 23);
			((Control)aBA).TabIndex = 22;
			((ComboBox)aBA).DrawItem += new DrawItemEventHandler(D);
			((ComboBox)aBa).DrawMode = (DrawMode)1;
			((ComboBox)aBa).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aBa).FormattingEnabled = true;
			((Control)aBa).Location = new Point(523, 174);
			((ComboBox)aBa).MaxDropDownItems = 10;
			((Control)aBa).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBb();
			((Control)aBa).Size = new Size(47, 23);
			((Control)aBa).TabIndex = 25;
			((ComboBox)aBa).DrawItem += new DrawItemEventHandler(d);
			((ComboBox)aBB).DrawMode = (DrawMode)1;
			((ComboBox)aBB).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aBB).FormattingEnabled = true;
			((Control)aBB).Location = new Point(523, 196);
			((ComboBox)aBB).MaxDropDownItems = 10;
			((Control)aBB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBC();
			((Control)aBB).Size = new Size(47, 23);
			((Control)aBB).TabIndex = 28;
			((ComboBox)aBB).DrawItem += new DrawItemEventHandler(E);
			((ComboBox)aBb).DrawMode = (DrawMode)1;
			((ComboBox)aBb).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aBb).FormattingEnabled = true;
			((Control)aBb).Location = new Point(523, 218);
			((ComboBox)aBb).MaxDropDownItems = 10;
			((Control)aBb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBc();
			((Control)aBb).Size = new Size(47, 23);
			((Control)aBb).TabIndex = 31;
			((ComboBox)aBb).DrawItem += new DrawItemEventHandler(e);
			((Control)aBC).AutoSize = true;
			((Control)aBC).Location = new Point(10, 252);
			((Control)aBC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tV();
			((Control)aBC).Size = new Size(220, 17);
			((Control)aBC).TabIndex = 38;
			((Control)aBC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tv();
			((ButtonBase)aBC).UseVisualStyleBackColor = true;
			((CheckBox)aBC).CheckedChanged += new EventHandler(A);
			((Control)aBc).AutoSize = true;
			((Control)aBc).Location = new Point(120, 272);
			((Control)aBc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tT();
			((Control)aBc).Size = new Size(56, 13);
			((Control)aBc).TabIndex = 42;
			((Control)aBc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jp();
			((Control)aBD).AutoSize = true;
			((Control)aBD).Location = new Point(14, 272);
			((Control)aBD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tt();
			((Control)aBD).Size = new Size(55, 13);
			((Control)aBD).TabIndex = 41;
			((Control)aBD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ts();
			((Control)aBd).Enabled = false;
			((Control)aBd).Location = new Point(118, 288);
			((Control)aBd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tU();
			((Control)aBd).Size = new Size(100, 22);
			((Control)aBd).TabIndex = 40;
			((Control)aBE).Enabled = false;
			((Control)aBE).Location = new Point(12, 288);
			((Control)aBE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tu();
			((Control)aBE).Size = new Size(100, 22);
			((Control)aBE).TabIndex = 39;
			((Form)this).AcceptButton = (IButtonControl)(object)aaE;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)aae;
			((Form)this).ClientSize = new Size(584, 361);
			((Control)this).Controls.Add((Control)(object)aBc);
			((Control)this).Controls.Add((Control)(object)aBD);
			((Control)this).Controls.Add((Control)(object)aBd);
			((Control)this).Controls.Add((Control)(object)aBE);
			((Control)this).Controls.Add((Control)(object)aBC);
			((Control)this).Controls.Add((Control)(object)aBb);
			((Control)this).Controls.Add((Control)(object)aBB);
			((Control)this).Controls.Add((Control)(object)aBa);
			((Control)this).Controls.Add((Control)(object)aBA);
			((Control)this).Controls.Add((Control)(object)aaz);
			((Control)this).Controls.Add((Control)(object)aaZ);
			((Control)this).Controls.Add((Control)(object)aay);
			((Control)this).Controls.Add((Control)(object)aaY);
			((Control)this).Controls.Add((Control)(object)aax);
			((Control)this).Controls.Add((Control)(object)aaX);
			((Control)this).Controls.Add((Control)(object)aaw);
			((Control)this).Controls.Add((Control)(object)aaW);
			((Control)this).Controls.Add((Control)(object)aav);
			((Control)this).Controls.Add((Control)(object)aaV);
			((Control)this).Controls.Add((Control)(object)aau);
			((Control)this).Controls.Add((Control)(object)aaU);
			((Control)this).Controls.Add((Control)(object)aaP);
			((Control)this).Controls.Add((Control)(object)aap);
			((Control)this).Controls.Add((Control)(object)aaQ);
			((Control)this).Controls.Add((Control)(object)aaq);
			((Control)this).Controls.Add((Control)(object)aaR);
			((Control)this).Controls.Add((Control)(object)aar);
			((Control)this).Controls.Add((Control)(object)aaS);
			((Control)this).Controls.Add((Control)(object)aas);
			((Control)this).Controls.Add((Control)(object)aaT);
			((Control)this).Controls.Add((Control)(object)aat);
			((Control)this).Controls.Add((Control)(object)aao);
			((Control)this).Controls.Add((Control)(object)aaO);
			((Control)this).Controls.Add((Control)(object)aan);
			((Control)this).Controls.Add((Control)(object)aaN);
			((Control)this).Controls.Add((Control)(object)aam);
			((Control)this).Controls.Add((Control)(object)aaM);
			((Control)this).Controls.Add((Control)(object)aal);
			((Control)this).Controls.Add((Control)(object)aaL);
			((Control)this).Controls.Add((Control)(object)aak);
			((Control)this).Controls.Add((Control)(object)aaK);
			((Control)this).Controls.Add((Control)(object)aaj);
			((Control)this).Controls.Add((Control)(object)aaJ);
			((Control)this).Controls.Add((Control)(object)aai);
			((Control)this).Controls.Add((Control)(object)aaI);
			((Control)this).Controls.Add((Control)(object)aah);
			((Control)this).Controls.Add((Control)(object)aaH);
			((Control)this).Controls.Add((Control)(object)aag);
			((Control)this).Controls.Add((Control)(object)aaG);
			((Control)this).Controls.Add((Control)(object)aaf);
			((Control)this).Controls.Add((Control)(object)aaF);
			((Control)this).Controls.Add((Control)(object)aae);
			((Control)this).Controls.Add((Control)(object)aaE);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBD();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBd();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((ISupportInitialize)aaV).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class bf : Form
	{
		private bool aBe;

		private float[] aBF;

		private IContainer aBf;

		private ThemedComboBox aBG;

		private Label aBg;

		private ThemedButton aBH;

		private Label aBh;

		private ThemedComboBox aBI;

		private aP aBi;

		internal bf()
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			float[] array = new float[17];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			aBF = array;
			((Form)this)._002Ector();
			aBe = true;
			A();
			((Control)this).BackColor = BM.tE;
			((Control)aBi).ForeColor = BM.te;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			((ListControl)aBG).SelectedIndex = (int)BM.QQ.rL.A().A();
			int selectedIndex = -1;
			for (int i = 0; i < aBF.Length; i++)
			{
				float num = aBF[i];
				((ComboBox)aBI).Items.Add((object)num.ToString());
				if (((Control)BM.QQ.rL.A()).Font.Size > num - 0.0001f && ((Control)BM.QQ.rL.A()).Font.Size < num + 0.0001f)
				{
					selectedIndex = i;
				}
			}
			((ListControl)aBI).SelectedIndex = selectedIndex;
			((CheckBox)aBi).Checked = !BM.QQ.rL.C();
			aBe = false;
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (!aBe && ((ListControl)aBG).SelectedIndex != -1)
			{
				BM.QQ.rL.A().A((aW)((ListControl)aBG).SelectedIndex);
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			if (!aBe && ((ListControl)aBI).SelectedIndex != -1)
			{
				((Control)BM.QQ.rL.A()).Font = new Font(((Control)BM.QQ.rL.A()).Font.FontFamily, aBF[((ListControl)aBI).SelectedIndex]);
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			if (!aBe)
			{
				BM.QQ.rL.a(!((CheckBox)aBi).Checked);
				BM.QQ.rL.A(true, false, false, false);
				BM.QQ.rL.B(false);
				if (BM.Qn != null)
				{
					BM.QQ.rL.b(false);
				}
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aBf != null)
			{
				((System.IDisposable)aBf).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Expected O, but got Unknown
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_034f: Expected O, but got Unknown
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0416: Expected O, but got Unknown
			aBG = new ThemedComboBox();
			aBg = new Label();
			aBH = new ThemedButton();
			aBh = new Label();
			aBI = new ThemedComboBox();
			aBi = new aP();
			((Control)this).SuspendLayout();
			((ComboBox)aBG).DrawMode = (DrawMode)1;
			((ComboBox)aBG).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aBG).FormattingEnabled = true;
			((ComboBox)aBG).Items.AddRange(new object[3]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBE(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBe(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBF()
			});
			((Control)aBG).Location = new Point(176, 11);
			((Control)aBG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBf();
			((Control)aBG).Size = new Size(152, 23);
			((Control)aBG).TabIndex = 0;
			((ComboBox)aBG).SelectedIndexChanged += new EventHandler(A);
			((Control)aBg).AutoSize = true;
			((Control)aBg).Location = new Point(10, 15);
			((Control)aBg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)aBg).Size = new Size(163, 13);
			((Control)aBg).TabIndex = 3;
			((Control)aBg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBG();
			((Button)aBH).DialogResult = (DialogResult)2;
			((Control)aBH).Location = new Point(126, 99);
			((Control)aBH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gu();
			((Control)aBH).Size = new Size(105, 34);
			((Control)aBH).TabIndex = 3;
			((Control)aBH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gV();
			((ButtonBase)aBH).UseVisualStyleBackColor = true;
			((Control)aBH).Click += new EventHandler(b);
			((Control)aBh).AutoSize = true;
			((Control)aBh).Location = new Point(10, 45);
			((Control)aBh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)aBh).Size = new Size(140, 13);
			((Control)aBh).TabIndex = 4;
			((Control)aBh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBg();
			((ComboBox)aBI).DrawMode = (DrawMode)1;
			((ComboBox)aBI).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aBI).FormattingEnabled = true;
			((Control)aBI).Location = new Point(176, 41);
			((Control)aBI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAP();
			((Control)aBI).Size = new Size(152, 23);
			((Control)aBI).TabIndex = 1;
			((ComboBox)aBI).SelectedIndexChanged += new EventHandler(a);
			((Control)aBi).AutoSize = true;
			((Control)aBi).Location = new Point(12, 74);
			((Control)aBi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBH();
			((Control)aBi).Size = new Size(235, 17);
			((Control)aBi).TabIndex = 2;
			((Control)aBi).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBh();
			((ButtonBase)aBi).UseVisualStyleBackColor = true;
			((CheckBox)aBi).CheckedChanged += new EventHandler(B);
			((Form)this).AcceptButton = (IButtonControl)(object)aBH;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)aBH;
			((Form)this).ClientSize = new Size(343, 141);
			((Control)this).Controls.Add((Control)(object)aBi);
			((Control)this).Controls.Add((Control)(object)aBh);
			((Control)this).Controls.Add((Control)(object)aBI);
			((Control)this).Controls.Add((Control)(object)aBH);
			((Control)this).Controls.Add((Control)(object)aBg);
			((Control)this).Controls.Add((Control)(object)aBG);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBI();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fq();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
