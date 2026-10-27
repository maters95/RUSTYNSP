using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;

namespace c
{
	internal class cK : MovableResizablePanel
	{
		private const int BJa = 2;

		private Framework BJB;

		private Setting BJb;

		private int BJC = -1;

		private bool BJc = true;

		private int BJD = 1;

		private bool BJd;

		private int BJE;

		private string BJe;

		private int BJF = -2147483648;

		internal cK(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			BJB = P_0;
			((Control)this).ContextMenuStrip = B();
			global::A.A.A(new EventHandler(B));
			global::A.A.A((global::A.D)B);
			BM.D(new EventHandler(B));
			BM.E(new EventHandler(B));
			((Control)this).DoubleBuffered = true;
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected O, but got Unknown
			try
			{
				if (BJb != null)
				{
					BJb.a(new EventHandler(A));
					((SettingOrSpecialObject)BJb).a(new EventHandler(a));
				}
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(c);
					((ToolStripItem)item).Click -= new EventHandler(b);
					((ToolStripItem)item).Click -= new EventHandler(C);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(D);
				global::A.A.a(new EventHandler(B));
				global::A.A.a((global::A.D)B);
				BM.d(new EventHandler(B));
				BM.e(new EventHandler(B));
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			if (BJb != null)
			{
				text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + ((object)BJb).ToString();
			}
			return string.Concat(new string[5]
			{
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAZ(),
				((Control)this).Left.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
				((Control)this).Top.ToString()
			});
		}

		internal void a()
		{
			if (BJb != null)
			{
				string text = ((SettingOrSpecialObject)BJb).H();
				if (!string.IsNullOrWhiteSpace(text))
				{
					BJe = text;
				}
				else
				{
					BJe = ((SettingOrSpecialObject)BJb).A(bz.aYT);
				}
				((Control)this).Invalidate();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Expected O, but got Unknown
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			Stopwatch val = new Stopwatch();
			val.Start();
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = (SmoothingMode)2;
			Font val2 = new Font(((Control)this).Font.FontFamily, (float)Math.Max(((Control)this).Height / 7, 1));
			Size val3 = TextRenderer.MeasureText(BJe, val2, new Size(((Control)this).Width - 6, ((Control)this).Height - 6), (TextFormatFlags)268435472);
			int height = ((Size)(ref val3)).Height;
			Rectangle val4 = default(Rectangle);
			((Rectangle)(ref val4))._002Ector(3, 3, ((Control)this).Width - 6, height + 2);
			float num = (BJc ? ((((Control)this).Height - height <= ((Control)this).Width) ? ((float)(((Control)this).Height - (6 + height + 2) - 1)) : ((float)(((Control)this).Width - 6 - 1))) : ((((Control)this).Height <= ((Control)this).Width) ? ((float)(((Control)this).Height - 6 - 1)) : ((float)(((Control)this).Width - 6 - 1))));
			float num2 = num / 2f;
			float num3 = ((Control)this).Width / 2;
			float num4 = ((!BJc) ? ((float)(((Control)this).Height / 2)) : ((float)(height + (((Control)this).Height - height) / 2)));
			bool flag = BJb != null && ((SettingOrSpecialObject)BJb).l() && PortFunction.A(BJb);
			if (BJc && BJb != null)
			{
				Color val5 = ((!flag) ? Color.Gray : BM.te);
				TextRenderer.DrawText((IDeviceContext)(object)graphics, BJe, val2, val4, val5, (TextFormatFlags)268435473);
			}
			val2.Dispose();
			Brush val6 = null;
			if (flag)
			{
				int num5 = BJb.ax();
				bool flag2 = false;
				List<Setting.ListItems.A> val7 = BJb.d(0);
				for (int i = 0; i < val7.Count; i++)
				{
					if (val7[i].bBv == BJD)
					{
						flag2 = true;
						break;
					}
				}
				bool flag3 = ((!flag2) ? (num5 >= BJD) : (num5 == BJD));
				if (BJd)
				{
					flag3 = !flag3;
				}
				if (flag3)
				{
					if (BJE == 0)
					{
						val6 = Brushes.Green;
					}
					else if (BJE == 1)
					{
						val6 = Brushes.Red;
					}
					else if (BJE == 2)
					{
						val6 = Brushes.Orange;
					}
				}
				else
				{
					switch (BM.Tn)
					{
					case BM.r.BqG:
					case BM.r.Bqh:
						val6 = Brushes.LightGray;
						break;
					case BM.r.Bqg:
						val6 = Brushes.DarkGray;
						break;
					case BM.r.BqH:
						val6 = Brushes.DarkGray;
						break;
					default:
						val6 = Brushes.LightGray;
						break;
					}
				}
			}
			Pen val8 = new Pen(Color.White, num2 * 0.03f);
			float num6 = num * 0.97f;
			float num7 = num6 / 2f;
			if (BJb != null && val6 != null && ((BM.A(BJB.aXc, true) && !BM.aE()) || BM.C(BJb.A())))
			{
				graphics.FillEllipse(val6, num3 - num2, num4 - num2, num, num);
			}
			graphics.DrawEllipse(val8, num3 - num7, num4 - num7, num6, num6);
			val8.Dispose();
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bal(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (base.B())
			{
				int num = BJb.ax();
				if (num != BJF)
				{
					((Control)this).Invalidate();
					BJF = num;
				}
			}
			else
			{
				BJF = -2147483648;
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		private void B(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		internal void b(object P_0, EventArgs P_1)
		{
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Invalid comparison between Unknown and I4
			if (BJb == null)
			{
				return;
			}
			int num = BJb.aS();
			int num2 = BJb.@as();
			int num3 = BJb.aR();
			int num4 = BJb.ar();
			BK bK = new BK(BJD, num, num2, num3, num4, BJb.d(0));
			bK.A(BJc);
			bK.a(BJd);
			bK.A(BJE);
			if ((int)((Form)bK).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				if (bK.a() != null)
				{
					BJD = bK.B();
				}
				else
				{
					double num5 = bK.A();
					BJD = bS.A(num5, num);
				}
				BJc = bK.b();
				BJd = bK.C();
				BJE = bK.c();
				((Control)this).Invalidate();
			}
			((Component)bK).Dispose();
		}

		private void C(object P_0, EventArgs P_1)
		{
			((Component)this).Dispose();
			BM.QQ.rl.a(false);
		}

		internal void c(object P_0, EventArgs P_1)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			int num = Bx.A((IWin32Window)(object)BM.QQ, BJB, (BJb != null) ? BJb.A() : 0);
			if (num != 0)
			{
				if (BJb != null)
				{
					BJb.a(new EventHandler(A));
					((SettingOrSpecialObject)BJb).a(new EventHandler(a));
				}
				BJb = BJB.A(num);
				if (BJb != null)
				{
					BJb.A(new EventHandler(A));
					((SettingOrSpecialObject)BJb).A(new EventHandler(a));
					BJC = BJb.A();
				}
				a();
			}
			BM.QQ.rl.a(false);
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				ToolStripMenuItem val = item;
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaM())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
					break;
				}
			}
		}

		private new ContextMenuStrip B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripDropDown)val).Opened += new EventHandler(D);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaC();
			((ToolStripItem)val2).Click += new EventHandler(c);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem();
			((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((ToolStripItem)val3).Click += new EventHandler(b);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaM();
			((ToolStripItem)val4).Click += new EventHandler(C);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bam());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf() + BJC);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaN() + BJc);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ban() + BJD);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaO() + BJd);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bao() + BJE);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dd: Expected O, but got Unknown
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Expected O, but got Unknown
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Expected O, but got Unknown
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Expected O, but got Unknown
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			string text;
			int bJC = default(int);
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaN()))
				{
					BJc = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaN().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaP()))
				{
					BJc = !bool.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaP()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaP().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ban()))
				{
					BJD = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ban().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bap()))
				{
					BJD = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bap()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bap().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaO()))
				{
					BJd = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaO().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaQ()))
				{
					BJd = bool.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaQ()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaQ().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bao()))
				{
					BJE = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bao().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baq()))
				{
					int num = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baq()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baq().Length));
					Color[] obj = new Color[6]
					{
						Color.Magenta,
						Color.DodgerBlue,
						Color.Lime,
						Color.Gold,
						Color.DarkOrange,
						Color.Red
					};
					BJE = 0;
					Color[] array = (Color[])(object)obj;
					for (int i = 0; i < array.Length; i++)
					{
						Color val = array[i];
						if (num == ((Color)(ref val)).ToArgb())
						{
							if (val == Color.DodgerBlue || val == Color.Lime)
							{
								BJE = 0;
							}
							else if (val == Color.Magenta || val == Color.Red)
							{
								BJE = 1;
							}
							else if (val == Color.Gold || val == Color.DarkOrange)
							{
								BJE = 2;
							}
							break;
						}
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf()))
				{
					BJC = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf().Length));
					if (BJC != -1)
					{
						BJb = BJB.A(BJC);
						if (BJb != null)
						{
							BJb.A(new EventHandler(A));
							((SettingOrSpecialObject)BJb).A(new EventHandler(a));
						}
					}
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()))
				{
					string text2 = text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI().Length);
					if (int.TryParse(text2, ref bJC))
					{
						BJC = bJC;
					}
					else
					{
						try
						{
							text2 = text2.Substring(1, text2.Length - 2);
							BJC = (int)(bs)System.Enum.Parse(typeof(bs), text2);
						}
						catch
						{
							BJC = -1;
						}
					}
					if (BJC != -1)
					{
						BJb = BJB.A(BJC);
						if (BJb != null)
						{
							BJb.A(new EventHandler(A));
							((SettingOrSpecialObject)BJb).A(new EventHandler(a));
						}
					}
				}
				else if (!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bai()) && string.IsNullOrWhiteSpace(text))
				{
					break;
				}
			}
		}
	}
	internal class ck : MovableResizablePanel
	{
		private y BJf;

		internal ck(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			BJf = new y(P_0.awO, P_0);
			((Control)this).Controls.Add((Control)(object)BJf);
			UpdateLayout(resizingOnly: false);
			((Control)this).ContextMenuStrip = a();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			try
			{
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(A);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(a);
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			return string.Concat(new string[5]
			{
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAZ(),
				((Control)this).Left.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
				((Control)this).Top.ToString()
			});
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			((Control)BJf).Left = 10;
			((Control)BJf).Top = 10;
			((Control)BJf).Width = ((Control)this).Width - 20;
			((Control)BJf).Height = ((Control)this).Height - 20;
			((Control)BJf).Invalidate();
		}

		private void A(object P_0, EventArgs P_1)
		{
			q.A((Control)(object)this);
			BM.QQ.rl.a(false);
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				ToolStripMenuItem val = item;
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaR())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
					break;
				}
			}
		}

		private ContextMenuStrip a()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripDropDown)val).Opened += new EventHandler(a);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaR();
			((ToolStripItem)val2).Click += new EventHandler(A);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bar());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			string text;
			while ((text = ((TextReader)P_0).ReadLine()) != null && !string.IsNullOrWhiteSpace(text))
			{
			}
		}
	}
}
namespace C
{
	internal class CK
	{
		internal DataIdAndAttrId BCF;

		internal int BCf;

		internal List<byte> BCG = new List<byte>();

		internal List<byte> BCg = new List<byte>();

		public virtual string ToString()
		{
			return string.Concat(new string[6]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.atb(),
				BCF.DataId.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.atC(),
				BCF.AttrId.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.atc(),
				BCf.ToString()
			});
		}
	}
	internal class Ck
	{
		private Framework BCH;

		private List<Cj> BCh = new List<Cj>();

		private int BCI = -1;

		private bool BCi;

		internal Ck(Framework P_0)
		{
			BCH = P_0;
		}

		[SpecialName]
		internal bool A()
		{
			return BCi;
		}

		internal void a()
		{
			A(new DataIdAndAttrId(0, 0));
		}

		internal void A(int P_0)
		{
			A(new DataIdAndAttrId(P_0));
		}

		internal void A(DataIdAndAttrId P_0)
		{
			if (BCH != null && !BM.tV)
			{
				BCi = true;
				if (BCI < BCh.Count - 1)
				{
					BCh.RemoveRange(BCI + 1, BCh.Count - (BCI + 1));
				}
				BCh.Add(new Cj(P_0));
				BCI++;
			}
		}

		internal void B()
		{
			if (BCh.Count != 0 && BCh[BCh.Count - 1].A().Count == 0)
			{
				BCh.RemoveAt(BCh.Count - 1);
				BCI--;
			}
			BCi = false;
		}

		internal Cj b()
		{
			return BCh[BCh.Count - 1];
		}

		internal void C()
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			if (!e())
			{
				return;
			}
			BCH.M();
			Cj cj = BCh[BCI];
			BCI--;
			Enumerator<CK> enumerator = cj.A().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CK current = enumerator.Current;
					BCH.A(current.BCF).az();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
			for (int num = cj.A().Count - 1; num >= 0; num--)
			{
				CK cK = cj.A()[num];
				Setting setting = BCH.A(cK.BCF);
				int count = cK.BCG.Count;
				int bCf = cK.BCf;
				for (int i = 0; i < count; i++)
				{
					byte b = cK.BCG[i];
					setting.A(bCf + i, b, true);
				}
				val.Add(cK.BCF);
			}
			Enumerator<DataIdAndAttrId> enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					DataIdAndAttrId current2 = enumerator2.Current;
					BCH.A(current2).i(true);
					if (BCH.awX.ContainsKey(current2.DataId))
					{
						MenuNode menuNode = BCH.awX[current2.DataId];
						menuNode.y();
						if (!menuNode.aB())
						{
							menuNode.G(true);
						}
						BM.QQ.rL.A(true, true, true, true);
						BM.QQ.rL.B(false);
						if (BM.Qn != null)
						{
							BM.QQ.rL.b(false);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			if (cj.a().DataId != 0)
			{
				BM.qF = cj.a();
			}
			if (val.Count == 1)
			{
				Setting setting2 = BCH.A(Enumerable.Single<DataIdAndAttrId>((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)val));
				BCH.A(true, setting2);
			}
			else
			{
				BCH.A(true);
			}
			enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					BM.A(enumerator2.Current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		internal void c()
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Unknown result type (might be due to invalid IL or missing references)
			if (!F())
			{
				return;
			}
			BCH.M();
			BCI++;
			Cj cj = BCh[BCI];
			Enumerator<CK> enumerator = cj.A().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CK current = enumerator.Current;
					BCH.A(current.BCF).az();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
			enumerator = cj.A().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CK current2 = enumerator.Current;
					Setting setting = BCH.A(current2.BCF);
					int count = current2.BCg.Count;
					int bCf = current2.BCf;
					for (int i = 0; i < count; i++)
					{
						byte b = current2.BCg[i];
						setting.A(bCf + i, b, true);
					}
					val.Add(current2.BCF);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<DataIdAndAttrId> enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					DataIdAndAttrId current3 = enumerator2.Current;
					BCH.A(current3).i(true);
					if (BCH.awX.ContainsKey(current3.DataId))
					{
						MenuNode menuNode = BCH.awX[current3.DataId];
						menuNode.y();
						if (!menuNode.aB())
						{
							menuNode.G(true);
						}
						BM.QQ.rL.A(true, true, true, true);
						BM.QQ.rL.B(false);
						if (BM.Qn != null)
						{
							BM.QQ.rL.b(false);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			if (cj.a().DataId != 0)
			{
				BM.qF = cj.a();
			}
			if (val.Count == 1)
			{
				Setting setting2 = BCH.A(Enumerable.Single<DataIdAndAttrId>((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)val));
				BCH.A(true, setting2);
			}
			else
			{
				BCH.A(true);
			}
			enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					BM.A(enumerator2.Current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		internal string D()
		{
			if (e())
			{
				return BCh[BCI].A(BCH);
			}
			return string.Empty;
		}

		internal string d()
		{
			if (F())
			{
				return BCh[BCI + 1].A(BCH);
			}
			return string.Empty;
		}

		internal void E()
		{
			BCh.Clear();
			BCI = -1;
			BCi = false;
		}

		internal bool e()
		{
			if ((BCH == null || BCH.C()) && BCI != -1)
			{
				return BCh.Count != 0;
			}
			return false;
		}

		internal bool F()
		{
			if ((BCH == null || BCH.C()) && BCI < BCh.Count - 1)
			{
				return BCh.Count != 0;
			}
			return false;
		}
	}
}
