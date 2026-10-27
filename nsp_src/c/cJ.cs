using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
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
	internal class cJ : MovableResizablePanel
	{
		private Framework BiN;

		private Setting Bin;

		private int BiO = -1;

		private string Bio;

		private long BiP;

		private long Bip;

		private long BiQ;

		private long Biq;

		private long BiR;

		private long Bir;

		private int BiS;

		private bool Bis = true;

		private int BiT = -2147483648;

		internal cJ(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			BiN = P_0;
			((Control)this).ContextMenuStrip = c();
			global::A.A.A(new EventHandler(C));
			global::A.A.A((global::A.D)C);
			BM.D(new EventHandler(C));
			BM.E(new EventHandler(C));
			BM.A(new EventHandler(b));
			((Control)this).DoubleBuffered = true;
		}

		protected override void Dispose(bool disposing)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			try
			{
				C();
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(d);
					((ToolStripItem)item).Click -= new EventHandler(E);
					((ToolStripItem)item).Click -= new EventHandler(c);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(e);
				global::A.A.a(new EventHandler(C));
				global::A.A.a((global::A.D)C);
				BM.d(new EventHandler(C));
				BM.e(new EventHandler(C));
				BM.a(new EventHandler(b));
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			if (Bin != null)
			{
				text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + ((object)Bin).ToString();
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

		[SpecialName]
		internal int a()
		{
			return BiO;
		}

		internal new void B()
		{
			A(false);
		}

		internal new void A(bool P_0)
		{
			if (Bin == null)
			{
				return;
			}
			string text = ((SettingOrSpecialObject)Bin).H();
			if (!string.IsNullOrWhiteSpace(text))
			{
				Bio = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + ((SettingOrSpecialObject)Bin).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
			else
			{
				Bio = ((SettingOrSpecialObject)Bin).A(bz.aYT);
			}
			if (BM.Qj.ContainsKey(Bin.A()))
			{
				Bl bl = BM.Qj[Bin.A()];
				BiR = bl.Qi;
				Bir = bl.QJ;
			}
			else
			{
				BiR = Bin.aP();
				Bir = Bin.ap();
			}
			if (P_0 || (BiP == 0L && Bip == 0L))
			{
				int num;
				int num2;
				if (BM.Qj.ContainsKey(Bin.A()))
				{
					Bl bl2 = BM.Qj[Bin.A()];
					num = bl2.Qh;
					num2 = bl2.QI;
				}
				else
				{
					num = Bin.aQ();
					num2 = Bin.aq();
				}
				BiP = num;
				Bip = num2;
			}
			if (P_0 || (BiQ == 0L && Biq == 0L) || BiS == 0)
			{
				int num3 = Bin.aS();
				double num4 = bS.A((int)BiP, num3, -1);
				double num5 = bS.A((int)Bip, num3, -1);
				if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 1.01)
				{
					BiQ = bS.A(0.0, num3);
					Biq = bS.A(1.0, num3);
					BiS = 11;
				}
				else if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 1.41)
				{
					BiQ = bS.A(0.0, num3);
					Biq = bS.A(1.4, num3);
					BiS = 15;
				}
				else if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 2.01)
				{
					BiQ = bS.A(0.0, num3);
					Biq = bS.A(2.0, num3);
					BiS = 11;
				}
				else if (num5 - num4 <= 10.01)
				{
					int num6 = (int)Math.Round(num4);
					int num7 = (int)Math.Round(num5);
					BiQ = bS.A((double)num6, num3, -1);
					Biq = bS.A((double)num7, num3, -1);
					BiS = num7 - num6 + 1;
				}
				else
				{
					long num8 = (long)Math.Ceiling(num4);
					long num9 = (long)Math.Floor(num5);
					long num10 = num9 - num8;
					long num11 = 5L;
					do
					{
						if (num9 < 0)
						{
							num9 = -((-num9 - (num11 - 1)) / num11) * num11;
						}
						else if (num9 > 0)
						{
							num9 = (num9 + (num11 - 1)) / num11 * num11;
						}
						if (num8 < 0)
						{
							num8 = -((-num8 + (num11 - 1)) / num11) * num11;
						}
						else if (num8 > 0)
						{
							num8 = (num8 - (num11 - 1)) / num11 * num11;
						}
						if (num9 == num8)
						{
							num8 = num9 - num11;
						}
						BiS = (int)((num9 - num8) / num11 + 1);
						if (BiS > 11)
						{
							num11 = num11 switch
							{
								5L => 10L, 
								10L => 25L, 
								25L => 50L, 
								50L => 100L, 
								100L => 200L, 
								200L => 500L, 
								500L => 1000L, 
								1000L => 2000L, 
								2000L => 5000L, 
								5000L => 10000L, 
								10000L => 50000L, 
								50000L => 100000L, 
								100000L => 500000L, 
								_ => num11 * 2, 
							};
						}
					}
					while (BiS > 11 && num11 <= num10);
					BiQ = bS.A(num8, num3);
					Biq = bS.A(num9, num3);
				}
			}
			((Control)this).Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected O, but got Unknown
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0322: Expected O, but got Unknown
			//IL_0322: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Expected O, but got Unknown
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_0446: Unknown result type (might be due to invalid IL or missing references)
			//IL_044b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Expected O, but got Unknown
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_052b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Expected O, but got Unknown
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ce: Expected O, but got Unknown
			//IL_0544: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fc: Expected O, but got Unknown
			//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fd: Expected O, but got Unknown
			//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0701: Unknown result type (might be due to invalid IL or missing references)
			//IL_0706: Unknown result type (might be due to invalid IL or missing references)
			//IL_0710: Unknown result type (might be due to invalid IL or missing references)
			//IL_0717: Expected O, but got Unknown
			//IL_071a: Unknown result type (might be due to invalid IL or missing references)
			Stopwatch val = new Stopwatch();
			val.Start();
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = (SmoothingMode)2;
			Pen val2 = new Pen(Color.Black, 1.5f);
			try
			{
				graphics.DrawRectangle(val2, 3, 3, ((Control)this).Width - 6 - 1, ((Control)this).Height - 6 - 1);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			bool flag = Bin != null && ((SettingOrSpecialObject)Bin).l() && PortFunction.A(Bin);
			bool flag2 = flag && ((BM.A(BiN.aXc, true) && !BM.aE()) || BM.C(Bin.A()));
			Rectangle val8 = default(Rectangle);
			if (Bin != null)
			{
				int num = Bin.ax();
				Font val3 = new Font(((Control)this).Font.FontFamily, (float)((Control)this).Width * 0.1f);
				SolidBrush val4 = ((!flag) ? new SolidBrush(Color.Gray) : new SolidBrush(BM.te));
				SizeF val5 = graphics.MeasureString(Bio, val3);
				if (Bis)
				{
					graphics.TranslateTransform(6f, (float)(((Control)this).Height - 6));
				}
				else
				{
					graphics.TranslateTransform(6f, 6f + ((SizeF)(ref val5)).Width);
				}
				graphics.RotateTransform(-90f);
				graphics.DrawString(Bio, val3, (Brush)(object)val4, 0f, 0f);
				graphics.ResetTransform();
				if (Bis && flag && ((BM.A(BiN.aXc, true) && !BM.aE()) || BM.C(Bin.A())))
				{
					ValueTuple<string, string, bool> val6 = Bin.A(num, -1);
					SizeF val7 = graphics.MeasureString(val6.Item1, val3);
					graphics.TranslateTransform(6f, 6f + ((SizeF)(ref val7)).Width);
					graphics.RotateTransform(-90f);
					graphics.DrawString(val6.Item1, val3, (Brush)(object)val4, 0f, 0f);
					graphics.ResetTransform();
				}
				((Brush)val4).Dispose();
				val3.Dispose();
				int num2 = 3 + (int)((SizeF)(ref val5)).Height + 8;
				((Rectangle)(ref val8))._002Ector(num2, 5, ((Control)this).Width - (num2 + 3 + 2 + 1), ((Control)this).Height - 11);
				if (flag)
				{
					if (flag2 && (BiR != 0L || Bir != 0L) && (num < BiR || num > Bir))
					{
						graphics.FillRectangle(Brushes.Maroon, val8);
					}
					else
					{
						graphics.FillRectangle(Brushes.Black, val8);
					}
				}
				else
				{
					graphics.FillRectangle(Brushes.Gray, val8);
				}
				try
				{
					int num3 = ((Rectangle)(ref val8)).Top + 10;
					int num4 = ((Rectangle)(ref val8)).Bottom - 10;
					int num5 = num4 - num3;
					Font val9 = new Font(((Control)this).Font.FontFamily, (float)((Control)this).Width * 0.08f);
					StringFormat val10 = new StringFormat();
					val10.Alignment = (StringAlignment)1;
					float[] array = new float[BiS];
					string[] array2 = new string[BiS];
					float num6 = 0f;
					int num7 = Bin.aS();
					for (long num8 = 0L; num8 < BiS; num8++)
					{
						long num9 = BiQ + num8 * (Biq - BiQ) / ((long)BiS - 1L);
						array[num8] = num4 - num5 * (num9 - BiQ) / (Biq - BiQ);
						string text = bS.a((int)num9, num7, -1);
						if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaA()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baa()))
						{
							text = text.Substring(0, text.Length - 2);
						}
						array2[num8] = text;
						SizeF val11 = graphics.MeasureString(text, val9);
						float width = ((SizeF)(ref val11)).Width;
						if (width > num6)
						{
							num6 = width;
						}
					}
					int num10 = (int)num6 + 10;
					for (int i = 0; i < BiS; i++)
					{
						SizeF val12 = graphics.MeasureString(array2[i], val9);
						SolidBrush val13 = new SolidBrush(BM.Ty);
						try
						{
							graphics.DrawString(array2[i], val9, (Brush)(object)val13, (float)(((Rectangle)(ref val8)).Right - num10 + 5) + ((SizeF)(ref val12)).Width / 2f, array[i] - ((SizeF)(ref val12)).Height / 2f, val10);
						}
						finally
						{
							((System.IDisposable)val13)?.Dispose();
						}
					}
					val10.Dispose();
					val9.Dispose();
					if (BiR != 0L || Bir != 0L)
					{
						if (BiR >= BiQ)
						{
							long num11 = num4 - num5 * (BiR - BiQ) / (Biq - BiQ);
							Rectangle val14 = default(Rectangle);
							((Rectangle)(ref val14))._002Ector(((Rectangle)(ref val8)).Left, (int)num11, ((Rectangle)(ref val8)).Width - num10, ((Rectangle)(ref val8)).Bottom - (int)num11);
							LinearGradientBrush val15 = new LinearGradientBrush(val14, Color.Red, Color.Black, 90f);
							try
							{
								graphics.FillRectangle((Brush)(object)val15, val14);
							}
							finally
							{
								((System.IDisposable)val15)?.Dispose();
							}
						}
						if (Bir <= Biq)
						{
							long num12 = num3 + num5 * (Biq - Bir) / (Biq - BiQ);
							Rectangle val16 = default(Rectangle);
							((Rectangle)(ref val16))._002Ector(((Rectangle)(ref val8)).Left, ((Rectangle)(ref val8)).Top, ((Rectangle)(ref val8)).Width - num10, (int)num12 - ((Rectangle)(ref val8)).Top);
							LinearGradientBrush val17 = new LinearGradientBrush(val16, Color.Red, Color.Black, 270f);
							try
							{
								graphics.FillRectangle((Brush)(object)val17, val16);
							}
							finally
							{
								((System.IDisposable)val17)?.Dispose();
							}
						}
					}
					for (int j = 0; j < BiS; j++)
					{
						Pen val18 = new Pen(Color.White, 1f);
						try
						{
							val18.DashStyle = (DashStyle)1;
							graphics.DrawLine(val18, (float)((Rectangle)(ref val8)).Left, array[j], (float)(((Rectangle)(ref val8)).Right - num10), array[j]);
						}
						finally
						{
							((System.IDisposable)val18)?.Dispose();
						}
					}
					if (flag && flag2)
					{
						long num13 = num4 - num5 * (num - BiQ) / (Biq - BiQ);
						int num14 = (int)((float)(((Rectangle)(ref val8)).Width - num10) * 0.6f);
						int num15 = ((Rectangle)(ref val8)).Left + (((Rectangle)(ref val8)).Width - num10 - num14) / 2;
						Rectangle val19 = default(Rectangle);
						((Rectangle)(ref val19))._002Ector(num15, (int)num13, num14, num4 - (int)num13);
						if (((Rectangle)(ref val19)).Height > 0)
						{
							LinearGradientBrush val20 = (((BiR == 0L && Bir == 0L) || (num >= BiR && num <= Bir)) ? new LinearGradientBrush(val19, Color.Gray, Color.LightGray, 180f) : new LinearGradientBrush(val19, Color.Red, Color.Pink, 180f));
							graphics.FillRectangle((Brush)(object)val20, val19);
							((Brush)val20).Dispose();
						}
					}
				}
				catch
				{
				}
				val.Stop();
				N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaB(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
			}
			else
			{
				int num16 = 26;
				((Rectangle)(ref val8))._002Ector(num16, 5, ((Control)this).Width - (num16 + 3 + 2 + 1), ((Control)this).Height - 11);
				graphics.FillRectangle(Brushes.Black, val8);
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (base.B())
			{
				int num = Bin.ax();
				if (num != BiT)
				{
					((Control)this).Invalidate();
					BiT = num;
				}
			}
			else
			{
				BiT = -2147483648;
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			bool flag = !BM.Qj.ContainsKey(Bin.A());
			A(flag);
		}

		private void B(object P_0, EventArgs P_1)
		{
			bool flag = !BM.Qj.ContainsKey(Bin.A());
			A(flag);
		}

		private void b(object P_0, EventArgs P_1)
		{
			A(false);
		}

		private void C(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		private void c(object P_0, EventArgs P_1)
		{
			((Component)this).Dispose();
			BM.QQ.rl.a(false);
		}

		private void D(object P_0, EventArgs P_1)
		{
			Bis = !Bis;
			((Control)this).Invalidate();
		}

		private new void b()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Expected O, but got Unknown
			if (Bin == null)
			{
				return;
			}
			Bin.A(new EventHandler(A));
			((SettingOrSpecialObject)Bin).A(new EventHandler(a));
			int num = Bin.B(bZ.aYm);
			if (num != -1)
			{
				Setting setting = BiN.A(num);
				if (setting != null)
				{
					setting.A(new EventHandler(B));
					((SettingOrSpecialObject)setting).A(new EventHandler(B));
				}
			}
			int num2 = Bin.B(bZ.aYN);
			if (num2 != -1)
			{
				Setting setting2 = BiN.A(num2);
				if (setting2 != null)
				{
					setting2.A(new EventHandler(B));
					((SettingOrSpecialObject)setting2).A(new EventHandler(B));
				}
			}
			int num3 = Bin.B(bZ.aYl);
			if (num3 != -1)
			{
				Setting setting3 = BiN.A(num3);
				if (setting3 != null)
				{
					setting3.A(new EventHandler(B));
					((SettingOrSpecialObject)setting3).A(new EventHandler(B));
				}
			}
			int num4 = Bin.B(bZ.aYM);
			if (num4 != -1)
			{
				Setting setting4 = BiN.A(num4);
				if (setting4 != null)
				{
					setting4.A(new EventHandler(B));
					((SettingOrSpecialObject)setting4).A(new EventHandler(B));
				}
			}
			int num5 = Bin.B(bZ.aYn);
			if (num5 != -1)
			{
				Setting setting5 = BiN.A(num5);
				if (setting5 != null)
				{
					setting5.A(new EventHandler(B));
					((SettingOrSpecialObject)setting5).A(new EventHandler(B));
				}
			}
			int num6 = Bin.B(bZ.aYO);
			if (num6 != -1)
			{
				Setting setting6 = BiN.A(num6);
				if (setting6 != null)
				{
					setting6.A(new EventHandler(B));
					((SettingOrSpecialObject)setting6).A(new EventHandler(B));
				}
			}
		}

		private void C()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Expected O, but got Unknown
			if (Bin == null)
			{
				return;
			}
			Bin.a(new EventHandler(A));
			((SettingOrSpecialObject)Bin).a(new EventHandler(a));
			int num = Bin.B(bZ.aYm);
			if (num != -1)
			{
				Setting setting = BiN.A(num);
				if (setting != null)
				{
					setting.a(new EventHandler(B));
					((SettingOrSpecialObject)setting).a(new EventHandler(B));
				}
			}
			int num2 = Bin.B(bZ.aYN);
			if (num2 != -1)
			{
				Setting setting2 = BiN.A(num2);
				if (setting2 != null)
				{
					setting2.a(new EventHandler(B));
					((SettingOrSpecialObject)setting2).a(new EventHandler(B));
				}
			}
			int num3 = Bin.B(bZ.aYl);
			if (num3 != -1)
			{
				Setting setting3 = BiN.A(num3);
				if (setting3 != null)
				{
					setting3.a(new EventHandler(B));
					((SettingOrSpecialObject)setting3).a(new EventHandler(B));
				}
			}
			int num4 = Bin.B(bZ.aYM);
			if (num4 != -1)
			{
				Setting setting4 = BiN.A(num4);
				if (setting4 != null)
				{
					setting4.a(new EventHandler(B));
					((SettingOrSpecialObject)setting4).a(new EventHandler(B));
				}
			}
			int num5 = Bin.B(bZ.aYn);
			if (num5 != -1)
			{
				Setting setting5 = BiN.A(num5);
				if (setting5 != null)
				{
					setting5.a(new EventHandler(B));
					((SettingOrSpecialObject)setting5).a(new EventHandler(B));
				}
			}
			int num6 = Bin.B(bZ.aYO);
			if (num6 != -1)
			{
				Setting setting6 = BiN.A(num6);
				if (setting6 != null)
				{
					setting6.a(new EventHandler(B));
					((SettingOrSpecialObject)setting6).a(new EventHandler(B));
				}
			}
		}

		internal void d(object P_0, EventArgs P_1)
		{
			int num = Bx.A((IWin32Window)(object)BM.QQ, BiN, (Bin != null) ? Bin.A() : 0);
			if (num != 0)
			{
				C();
				Bin = BiN.A(num);
				if (Bin != null)
				{
					BiO = Bin.A();
				}
				b();
				A(true);
			}
			BM.QQ.rl.a(false);
		}

		private void E(object P_0, EventArgs P_1)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Invalid comparison between Unknown and I4
			Bi bi = new Bi(Bin, (int)BiP, (int)Bip, (int)BiR, (int)Bir);
			if ((int)((Form)bi).ShowDialog((IWin32Window)(object)BM.QQ) == 1 && Bin != null)
			{
				BM.A(Bin.A(), bi.a(), bi.B(), bi.b(), bi.C());
				A(true);
				if (bi.A())
				{
					BM.QQ.rl.a(Bin.A());
				}
				BM.a();
			}
			((Component)bi).Dispose();
		}

		private void e(object P_0, EventArgs P_1)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				ToolStripMenuItem val = item;
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp())
				{
					((ToolStripItem)val).Enabled = Bin != null;
				}
				else if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bab())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
				}
			}
		}

		private ContextMenuStrip c()
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
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripDropDown)val).Opened += new EventHandler(e);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaC();
			((ToolStripItem)val2).Click += new EventHandler(d);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem();
			((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((ToolStripItem)val3).Click += new EventHandler(E);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bac();
			((ToolStripItem)val4).Click += new EventHandler(D);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
			ToolStripMenuItem val5 = new ToolStripMenuItem();
			((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bab();
			((ToolStripItem)val5).Click += new EventHandler(c);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaD());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf() + BiO);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaG() + Bis);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag() + BiP);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH() + Bip);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bah() + BiS);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			string text;
			int biO = default(int);
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf()))
				{
					BiO = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf().Length));
					if (BiO != -1)
					{
						Bin = BiN.A(BiO);
						if (Bin != null)
						{
							b();
						}
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag()))
				{
					if (Bin != null)
					{
						int num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag().Length));
						BiP = num;
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH()))
				{
					if (Bin != null)
					{
						int num2 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH().Length));
						Bip = num2;
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bah()))
				{
					if (Bin != null)
					{
						int biS = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bah().Length));
						BiS = biS;
					}
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()))
				{
					string text2 = text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI().Length);
					if (int.TryParse(text2, ref biO))
					{
						BiO = biO;
					}
					else
					{
						try
						{
							text2 = text2.Substring(1, text2.Length - 2);
							BiO = (int)(bs)System.Enum.Parse(typeof(bs), text2);
						}
						catch
						{
							BiO = -1;
						}
					}
					if (BiO != -1)
					{
						Bin = BiN.A(BiO);
						if (Bin != null)
						{
							b();
						}
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaG()))
				{
					Bis = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaG().Length));
				}
				else if (!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bai()) && string.IsNullOrWhiteSpace(text))
				{
					break;
				}
			}
		}
	}
	internal class cj : MovableResizablePanel
	{
		private Framework Bit;

		private Setting BiU;

		private int Biu = -1;

		private string BiV;

		private long Biv;

		private long BiW;

		private long Biw;

		private long BiX;

		private long Bix;

		private long BiY;

		private int Biy;

		private int BiZ = 1;

		private bool Biz = true;

		private int BJA = -2147483648;

		internal cj(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			Bit = P_0;
			((Control)this).ContextMenuStrip = c();
			global::A.A.A(new EventHandler(C));
			global::A.A.A((global::A.D)C);
			BM.D(new EventHandler(C));
			BM.E(new EventHandler(C));
			BM.A(new EventHandler(b));
			((Control)this).DoubleBuffered = true;
		}

		protected override void Dispose(bool disposing)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			try
			{
				C();
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(d);
					((ToolStripItem)item).Click -= new EventHandler(E);
					((ToolStripItem)item).Click -= new EventHandler(c);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(e);
				global::A.A.a(new EventHandler(C));
				global::A.A.a((global::A.D)C);
				BM.d(new EventHandler(C));
				BM.e(new EventHandler(C));
				BM.a(new EventHandler(b));
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			if (BiU != null)
			{
				text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + ((object)BiU).ToString();
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

		[SpecialName]
		internal int a()
		{
			return Biu;
		}

		internal new void B()
		{
			A(false);
		}

		internal new void A(bool P_0)
		{
			if (BiU == null)
			{
				return;
			}
			string text = ((SettingOrSpecialObject)BiU).H();
			if (!string.IsNullOrWhiteSpace(text))
			{
				BiV = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + ((SettingOrSpecialObject)BiU).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
			else
			{
				BiV = ((SettingOrSpecialObject)BiU).A(bz.aYT);
			}
			if (BM.Qj.ContainsKey(BiU.A()))
			{
				Bl bl = BM.Qj[BiU.A()];
				Bix = bl.Qi;
				BiY = bl.QJ;
			}
			else
			{
				Bix = BiU.aP();
				BiY = BiU.ap();
			}
			if (P_0 || (Biv == 0L && BiW == 0L))
			{
				int num;
				int num2;
				if (BM.Qj.ContainsKey(BiU.A()))
				{
					Bl bl2 = BM.Qj[BiU.A()];
					num = bl2.Qh;
					num2 = bl2.QI;
				}
				else
				{
					num = BiU.aQ();
					num2 = BiU.aq();
				}
				Biv = num;
				BiW = num2;
			}
			if (P_0 || (Biw == 0L && BiX == 0L) || Biy == 0)
			{
				int num3 = BiU.aS();
				double num4 = bS.A((int)Biv, num3, -1);
				double num5 = bS.A((int)BiW, num3, -1);
				if (bS.A(0.0, num3) == 0 && (num4 >= 1000.0 || num5 >= 1000.0))
				{
					BiZ = 1000;
				}
				else
				{
					BiZ = 1;
				}
				if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 1.01)
				{
					Biw = bS.A(0.0, num3);
					BiX = bS.A(1.0, num3);
					Biy = 11;
				}
				else if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 1.41)
				{
					Biw = bS.A(0.0, num3);
					BiX = bS.A(1.4, num3);
					Biy = 8;
				}
				else if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 2.01)
				{
					Biw = bS.A(0.0, num3);
					BiX = bS.A(2.0, num3);
					Biy = 11;
				}
				else if (num5 - num4 <= 10.01)
				{
					int num6 = (int)Math.Round(num4);
					int num7 = (int)Math.Round(num5);
					Biw = bS.A((double)num6, num3, -1);
					BiX = bS.A((double)num7, num3, -1);
					Biy = num7 - num6 + 1;
				}
				else
				{
					long num8 = (long)Math.Ceiling(num4);
					long num9 = (long)Math.Floor(num5);
					long num10 = num9 - num8;
					long num11 = 5L;
					do
					{
						if (num9 < 0)
						{
							num9 = -((-num9 - (num11 - 1)) / num11) * num11;
						}
						else if (num9 > 0)
						{
							num9 = (num9 + (num11 - 1)) / num11 * num11;
						}
						if (num8 < 0)
						{
							num8 = -((-num8 + (num11 - 1)) / num11) * num11;
						}
						else if (num8 > 0)
						{
							num8 = (num8 - (num11 - 1)) / num11 * num11;
						}
						if (num9 == num8)
						{
							num8 = num9 - num11;
						}
						Biy = (int)((num9 - num8) / num11 + 1);
						if (Biy > 11)
						{
							num11 = num11 switch
							{
								5L => 10L, 
								10L => 25L, 
								25L => 50L, 
								50L => 100L, 
								100L => 200L, 
								200L => 500L, 
								500L => 1000L, 
								1000L => 2000L, 
								2000L => 5000L, 
								5000L => 10000L, 
								10000L => 50000L, 
								50000L => 100000L, 
								100000L => 500000L, 
								_ => num11 * 2, 
							};
						}
					}
					while (Biy > 11 && num11 <= num10);
					Biw = bS.A(num8, num3);
					BiX = bS.A(num9, num3);
				}
			}
			((Control)this).Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected O, but got Unknown
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Expected O, but got Unknown
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_031e: Expected O, but got Unknown
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Expected O, but got Unknown
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Expected O, but got Unknown
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Expected O, but got Unknown
			//IL_060e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0615: Expected O, but got Unknown
			//IL_061e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0623: Unknown result type (might be due to invalid IL or missing references)
			//IL_0634: Unknown result type (might be due to invalid IL or missing references)
			//IL_0639: Unknown result type (might be due to invalid IL or missing references)
			//IL_0640: Expected O, but got Unknown
			//IL_0686: Unknown result type (might be due to invalid IL or missing references)
			//IL_068b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0503: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Expected O, but got Unknown
			//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_070e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0715: Expected O, but got Unknown
			//IL_0716: Unknown result type (might be due to invalid IL or missing references)
			//IL_071f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0724: Unknown result type (might be due to invalid IL or missing references)
			//IL_0736: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c3: Expected O, but got Unknown
			Stopwatch val = new Stopwatch();
			val.Start();
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = (SmoothingMode)2;
			float num = ((((Control)this).Height <= ((Control)this).Width) ? ((float)(((Control)this).Height - 3)) : ((float)(((Control)this).Width - 3)));
			float num2 = num / 2f;
			float num3 = (float)(((Control)this).Width / 2) - 1.5f;
			float num4 = (float)(((Control)this).Height / 2) - 1.5f;
			int num5 = 0;
			if (BiU != null)
			{
				num5 = BiU.ax();
			}
			bool flag = BiU != null && ((SettingOrSpecialObject)BiU).l() && PortFunction.A(BiU);
			bool flag2 = flag && ((BM.A(Bit.aXc, true) && !BM.aE()) || BM.C(BiU.A()));
			Brush val2 = ((!flag) ? Brushes.Gray : ((!flag2 || (Bix == 0L && BiY == 0L) || (num5 >= Bix && num5 <= BiY)) ? Brushes.Black : Brushes.Maroon));
			float num6 = num * 0.97f;
			float num7 = num6 / 2f;
			Pen val3 = new Pen(Color.White, num2 * 0.03f);
			try
			{
				graphics.FillEllipse(val2, num3 - num2, num4 - num2, num, num);
				graphics.DrawEllipse(val3, num3 - num7, num4 - num7, num6, num6);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
			SolidBrush val4 = new SolidBrush(Color.Gray);
			try
			{
				float num8 = num / 7.5f;
				float num9 = num8 / 2f;
				graphics.FillEllipse((Brush)(object)val4, num3 - num9, num4 - num9, num8, num8);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
			if (BiU == null)
			{
				return;
			}
			try
			{
				if (Bix != 0L || BiY != 0L)
				{
					float num10 = num * 0.85f;
					if (Bix >= Biw)
					{
						Pen val5 = new Pen(Color.Red, num2 * 0.03f);
						try
						{
							float num11 = -210f + (float)(Bix - Biw) / (float)(BiX - Biw) * 240f;
							graphics.DrawArc(val5, num3 - num10 / 2f, num4 - num10 / 2f, num10, num10, -210f, num11 - -210f);
						}
						finally
						{
							((System.IDisposable)val5)?.Dispose();
						}
					}
					if (BiY <= BiX)
					{
						Pen val6 = new Pen(Color.Red, num2 * 0.03f);
						try
						{
							float num12 = -210f + (float)(BiY - Biw) / (float)(BiX - Biw) * 240f;
							graphics.DrawArc(val6, num3 - num10 / 2f, num4 - num10 / 2f, num10, num10, num12, 30f - num12);
						}
						finally
						{
							((System.IDisposable)val6)?.Dispose();
						}
					}
				}
				Font val7 = new Font(((Control)this).Font.FontFamily, num2 * 0.1f, (FontStyle)3);
				StringFormat val8 = new StringFormat();
				val8.Alignment = (StringAlignment)1;
				Pen val9 = new Pen(BM.Ty, num2 * 0.01f);
				Pen val10 = new Pen(BM.Ty, num2 * 0.03f);
				float num13 = num2 * 0.08f;
				float num14 = num2 * 0.12f;
				float num15 = num7 * 0.99f;
				int num16 = BiU.aS();
				SizeF val11;
				for (long num17 = 0L; num17 < Biy * 2 - 1; num17++)
				{
					float num18 = (-210f + (float)num17 * (240f / (float)((Biy - 1) * 2))) * ((float)Math.PI * 2f) / 360f;
					if ((num17 & 1) == 0L)
					{
						graphics.DrawLine(val10, num3 + (num15 - num14) * (float)Math.Cos((double)num18), num4 + (num15 - num14) * (float)Math.Sin((double)num18), num3 + num15 * (float)Math.Cos((double)num18), num4 + num15 * (float)Math.Sin((double)num18));
						long num19 = Biw + num17 / 2 * (BiX - Biw) / ((long)Biy - 1L);
						string text;
						if (BiZ != 1)
						{
							double num20 = bS.A((int)num19, num16, -1) / (double)BiZ;
							text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eH(), (object)num20);
							while (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn()))
							{
								text = text.Substring(0, text.Length - 1);
							}
							if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ()))
							{
								text = text.Substring(0, text.Length - 1);
							}
						}
						else
						{
							text = bS.a((int)num19, num16, -1);
							if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaA()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baa()))
							{
								text = text.Substring(0, text.Length - 2);
							}
						}
						val11 = graphics.MeasureString(text, val7);
						float num21 = ((SizeF)(ref val11)).Height / 2f;
						SolidBrush val12 = new SolidBrush(BM.Ty);
						try
						{
							float num22 = 2.1f;
							if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ()))
							{
								num22 = 2.5f;
							}
							graphics.DrawString(text, val7, (Brush)(object)val12, num3 + (num15 - num22 * num14) * (float)Math.Cos((double)num18), num4 + (num15 - num22 * num14) * (float)Math.Sin((double)num18) - num21, val8);
						}
						finally
						{
							((System.IDisposable)val12)?.Dispose();
						}
					}
					else
					{
						graphics.DrawLine(val9, num3 + (num15 - num13) * (float)Math.Cos((double)num18), num4 + (num15 - num13) * (float)Math.Sin((double)num18), num3 + num15 * (float)Math.Cos((double)num18), num4 + num15 * (float)Math.Sin((double)num18));
					}
				}
				val10.Dispose();
				val9.Dispose();
				val8.Dispose();
				val7.Dispose();
				Font val13 = new Font(((Control)this).Font.FontFamily, num2 * 0.1f);
				try
				{
					val11 = graphics.MeasureString(BiV, val13);
					float num23 = ((SizeF)(ref val11)).Width / 2f;
					SolidBrush val14 = new SolidBrush(BM.Ty);
					try
					{
						graphics.DrawString(BiV, val13, (Brush)(object)val14, num3 - num23, num4 - num2 + num * 0.75f);
						if (BiZ != 1)
						{
							string text2 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaJ(), (object)BiZ);
							val11 = graphics.MeasureString(text2, val13);
							num23 = ((SizeF)(ref val11)).Width / 2f;
							graphics.DrawString(text2, val13, (Brush)(object)val14, num3 - num23, num4 - num2 + num * 0.3f);
						}
					}
					finally
					{
						((System.IDisposable)val14)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val13)?.Dispose();
				}
				if (flag && flag2)
				{
					if (Biz)
					{
						ValueTuple<string, string, bool> val15 = BiU.A(num5, -1);
						Font val16 = new Font(((Control)this).Font.FontFamily, num2 * 0.1f, (FontStyle)1);
						try
						{
							val11 = graphics.MeasureString(val15.Item1, val16);
							float num24 = ((SizeF)(ref val11)).Width / 2f;
							graphics.DrawString(val15.Item1, val16, Brushes.White, num3 - num24, num4 - num2 + num * 0.62f);
						}
						finally
						{
							((System.IDisposable)val16)?.Dispose();
						}
					}
					float num25 = -210f + (float)(num5 - Biw) / (float)(BiX - Biw) * 240f;
					if (num25 < -240f)
					{
						num25 = -240f;
					}
					if (num25 > 60f)
					{
						num25 = 60f;
					}
					Pen val17 = new Pen(Color.Red, num2 * 0.04f);
					try
					{
						float num26 = num2 * 0.9f;
						float num27 = num25 * ((float)Math.PI * 2f) / 360f;
						graphics.DrawLine(val17, num3, num4, num3 + num26 * (float)Math.Cos((double)num27), num4 + num26 * (float)Math.Sin((double)num27));
					}
					finally
					{
						((System.IDisposable)val17)?.Dispose();
					}
				}
			}
			catch
			{
			}
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baj(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (base.B())
			{
				int num = BiU.ax();
				if (num != BJA)
				{
					((Control)this).Invalidate();
					BJA = num;
				}
			}
			else
			{
				BJA = -2147483648;
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			bool flag = !BM.Qj.ContainsKey(BiU.A());
			A(flag);
		}

		private void B(object P_0, EventArgs P_1)
		{
			bool flag = !BM.Qj.ContainsKey(BiU.A());
			A(flag);
		}

		private void b(object P_0, EventArgs P_1)
		{
			A(false);
		}

		private void C(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		private void c(object P_0, EventArgs P_1)
		{
			((Component)this).Dispose();
			BM.QQ.rl.a(false);
		}

		private void D(object P_0, EventArgs P_1)
		{
			Biz = !Biz;
			((Control)this).Invalidate();
		}

		private new void b()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Expected O, but got Unknown
			if (BiU == null)
			{
				return;
			}
			BiU.A(new EventHandler(A));
			((SettingOrSpecialObject)BiU).A(new EventHandler(a));
			int num = BiU.B(bZ.aYm);
			if (num != -1)
			{
				Setting setting = Bit.A(num);
				if (setting != null)
				{
					setting.A(new EventHandler(B));
					((SettingOrSpecialObject)setting).A(new EventHandler(B));
				}
			}
			int num2 = BiU.B(bZ.aYN);
			if (num2 != -1)
			{
				Setting setting2 = Bit.A(num2);
				if (setting2 != null)
				{
					setting2.A(new EventHandler(B));
					((SettingOrSpecialObject)setting2).A(new EventHandler(B));
				}
			}
			int num3 = BiU.B(bZ.aYl);
			if (num3 != -1)
			{
				Setting setting3 = Bit.A(num3);
				if (setting3 != null)
				{
					setting3.A(new EventHandler(B));
					((SettingOrSpecialObject)setting3).A(new EventHandler(B));
				}
			}
			int num4 = BiU.B(bZ.aYM);
			if (num4 != -1)
			{
				Setting setting4 = Bit.A(num4);
				if (setting4 != null)
				{
					setting4.A(new EventHandler(B));
					((SettingOrSpecialObject)setting4).A(new EventHandler(B));
				}
			}
			int num5 = BiU.B(bZ.aYn);
			if (num5 != -1)
			{
				Setting setting5 = Bit.A(num5);
				if (setting5 != null)
				{
					setting5.A(new EventHandler(B));
					((SettingOrSpecialObject)setting5).A(new EventHandler(B));
				}
			}
			int num6 = BiU.B(bZ.aYO);
			if (num6 != -1)
			{
				Setting setting6 = Bit.A(num6);
				if (setting6 != null)
				{
					setting6.A(new EventHandler(B));
					((SettingOrSpecialObject)setting6).A(new EventHandler(B));
				}
			}
		}

		private void C()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Expected O, but got Unknown
			if (BiU == null)
			{
				return;
			}
			BiU.a(new EventHandler(A));
			((SettingOrSpecialObject)BiU).a(new EventHandler(a));
			int num = BiU.B(bZ.aYm);
			if (num != -1)
			{
				Setting setting = Bit.A(num);
				if (setting != null)
				{
					setting.a(new EventHandler(B));
					((SettingOrSpecialObject)setting).a(new EventHandler(B));
				}
			}
			int num2 = BiU.B(bZ.aYN);
			if (num2 != -1)
			{
				Setting setting2 = Bit.A(num2);
				if (setting2 != null)
				{
					setting2.a(new EventHandler(B));
					((SettingOrSpecialObject)setting2).a(new EventHandler(B));
				}
			}
			int num3 = BiU.B(bZ.aYl);
			if (num3 != -1)
			{
				Setting setting3 = Bit.A(num3);
				if (setting3 != null)
				{
					setting3.a(new EventHandler(B));
					((SettingOrSpecialObject)setting3).a(new EventHandler(B));
				}
			}
			int num4 = BiU.B(bZ.aYM);
			if (num4 != -1)
			{
				Setting setting4 = Bit.A(num4);
				if (setting4 != null)
				{
					setting4.a(new EventHandler(B));
					((SettingOrSpecialObject)setting4).a(new EventHandler(B));
				}
			}
			int num5 = BiU.B(bZ.aYn);
			if (num5 != -1)
			{
				Setting setting5 = Bit.A(num5);
				if (setting5 != null)
				{
					setting5.a(new EventHandler(B));
					((SettingOrSpecialObject)setting5).a(new EventHandler(B));
				}
			}
			int num6 = BiU.B(bZ.aYO);
			if (num6 != -1)
			{
				Setting setting6 = Bit.A(num6);
				if (setting6 != null)
				{
					setting6.a(new EventHandler(B));
					((SettingOrSpecialObject)setting6).a(new EventHandler(B));
				}
			}
		}

		internal void d(object P_0, EventArgs P_1)
		{
			int num = Bx.A((IWin32Window)(object)BM.QQ, Bit, (BiU != null) ? BiU.A() : 0);
			if (num != 0)
			{
				C();
				BiU = Bit.A(num);
				if (BiU != null)
				{
					Biu = BiU.A();
				}
				b();
				A(true);
			}
			BM.QQ.rl.a(false);
		}

		private void E(object P_0, EventArgs P_1)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Invalid comparison between Unknown and I4
			Bi bi = new Bi(BiU, (int)Biv, (int)BiW, (int)Bix, (int)BiY);
			if ((int)((Form)bi).ShowDialog((IWin32Window)(object)BM.QQ) == 1 && BiU != null)
			{
				BM.A(BiU.A(), bi.a(), bi.B(), bi.b(), bi.C());
				A(true);
				if (bi.A())
				{
					BM.QQ.rl.a(BiU.A());
				}
				BM.a();
			}
			((Component)bi).Dispose();
		}

		private void e(object P_0, EventArgs P_1)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				ToolStripMenuItem val = item;
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp())
				{
					((ToolStripItem)val).Enabled = BiU != null;
				}
				else if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaK())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
				}
			}
		}

		private ContextMenuStrip c()
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
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripDropDown)val).Opened += new EventHandler(e);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaC();
			((ToolStripItem)val2).Click += new EventHandler(d);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem();
			((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((ToolStripItem)val3).Click += new EventHandler(E);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bac();
			((ToolStripItem)val4).Click += new EventHandler(D);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
			ToolStripMenuItem val5 = new ToolStripMenuItem();
			((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaK();
			((ToolStripItem)val5).Click += new EventHandler(c);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bak());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf() + Biu);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaG() + Biz);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag() + Biv);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH() + BiW);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bah() + Biy);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaL() + BiZ);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			string text;
			int biu = default(int);
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf()))
				{
					Biu = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf().Length));
					if (Biu != -1)
					{
						BiU = Bit.A(Biu);
						if (BiU != null)
						{
							b();
						}
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag()))
				{
					if (BiU != null)
					{
						int num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag().Length));
						Biv = num;
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH()))
				{
					if (BiU != null)
					{
						int num2 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH().Length));
						BiW = num2;
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bah()))
				{
					if (BiU != null)
					{
						int biy = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bah().Length));
						Biy = biy;
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaL()))
				{
					if (BiU != null)
					{
						int biZ = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaL().Length));
						BiZ = biZ;
					}
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()))
				{
					string text2 = text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI().Length);
					if (int.TryParse(text2, ref biu))
					{
						Biu = biu;
					}
					else
					{
						try
						{
							text2 = text2.Substring(1, text2.Length - 2);
							Biu = (int)(bs)System.Enum.Parse(typeof(bs), text2);
						}
						catch
						{
							Biu = -1;
						}
					}
					if (Biu != -1)
					{
						BiU = Bit.A(Biu);
						if (BiU != null)
						{
							b();
						}
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaG()))
				{
					Biz = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaG().Length));
				}
				else if (!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bai()) && string.IsNullOrWhiteSpace(text))
				{
					break;
				}
			}
		}
	}
}
namespace C
{
	internal class CJ
	{
		private Framework BbK;

		private Setting Bbk;

		private Setting BbL;

		private Setting Bbl;

		private Setting BbM;

		private Setting Bbm;

		private Setting BbN;

		private Setting Bbn;

		private Setting BbO;

		private Setting Bbo;

		internal CJ(Framework P_0)
		{
			BbK = P_0;
		}

		internal void A()
		{
			Bbk = BbK.A(15171);
			BbL = BbK.A(15172);
			Bbl = BbK.A(15181);
			BbM = BbK.A(15182);
			Bbm = BbK.A(15254);
			BbN = BbK.A(15255);
			Bbn = BbK.A(15256);
			BbO = BbK.A(15257);
			Bbo = BbK.A(15258);
		}

		internal void A(int P_0)
		{
			a(P_0)?.a(0, true);
			B(P_0)?.a(0, true);
			b(P_0)?.a(0, true);
		}

		internal Setting a(int P_0)
		{
			Setting result = null;
			switch (P_0)
			{
			case 6447:
				result = Bbk;
				break;
			case 8279:
				result = BbM;
				break;
			case 6437:
				result = Bbn;
				break;
			}
			return result;
		}

		internal Setting B(int P_0)
		{
			Setting result = null;
			switch (P_0)
			{
			case 6447:
				result = BbL;
				break;
			case 8279:
				result = Bbm;
				break;
			case 6437:
				result = BbO;
				break;
			}
			return result;
		}

		internal Setting b(int P_0)
		{
			Setting result = null;
			switch (P_0)
			{
			case 6447:
				result = Bbl;
				break;
			case 8279:
				result = BbN;
				break;
			case 6437:
				result = Bbo;
				break;
			}
			return result;
		}
	}
	internal class Cj
	{
		private List<CK> BCE = new List<CK>();

		private DataIdAndAttrId BCe;

		internal Cj(DataIdAndAttrId P_0)
		{
			BCe = P_0;
		}

		internal Cj()
		{
		}

		internal string A(Framework P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			StringBuilder val = new StringBuilder();
			if (BCE.Count != 0)
			{
				HashSet<DataIdAndAttrId> val2 = new HashSet<DataIdAndAttrId>();
				Enumerator<CK> enumerator = BCE.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CK current = enumerator.Current;
						val2.Add(current.BCF);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTZ() + ((val2.Count > 1) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTz());
				Enumerator<DataIdAndAttrId> enumerator2 = val2.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						DataIdAndAttrId current2 = enumerator2.Current;
						Setting setting = P_0.A(current2);
						val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.atA() + ((SettingOrSpecialObject)setting).A(true));
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			return ((object)val).ToString();
		}

		internal void A(Setting P_0)
		{
			CK cK = new CK();
			cK.BCF = P_0.C();
			BCE.Add(cK);
		}

		internal void A(Setting P_0, int P_1, int P_2)
		{
			CK cK = BCE[BCE.Count - 1];
			for (int i = 0; i < P_2; i++)
			{
				byte b = P_0.l(P_1 + i);
				cK.BCG.Add(b);
			}
			cK.BCf = P_1;
		}

		internal void a(Setting P_0, int P_1, int P_2)
		{
			CK cK = BCE[BCE.Count - 1];
			for (int i = 0; i < P_2; i++)
			{
				byte b = P_0.l(P_1 + i);
				cK.BCg.Add(b);
			}
			cK.BCf = P_1;
		}

		[SpecialName]
		internal List<CK> A()
		{
			return BCE;
		}

		[SpecialName]
		internal DataIdAndAttrId a()
		{
			return BCe;
		}

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ata() + BCE.Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.atB();
		}
	}
}
