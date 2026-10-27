using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;
using c;

namespace c
{
	internal class cN : MovableResizablePanel
	{
		private const int Bjo = 4;

		private bool BjP;

		private int Bjp;

		private bool BjQ = true;

		private bool Bjq;

		private Timer BjR = new Timer();

		private Stopwatch Bjr = new Stopwatch();

		private int BjS;

		private bool Bjs = true;

		private bool BjT;

		private Stopwatch Bjt = new Stopwatch();

		private bool BjU = true;

		private Framework Bju;

		private Setting BjV;

		private int Bjv = -1;

		private string BjW;

		private bool Bjw = true;

		private int BjX;

		private int Bjx;

		private int BjY = -2147483648;

		internal cN(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected O, but got Unknown
			Bju = P_0;
			((Control)this).ContextMenuStrip = B();
			global::A.A.A(new EventHandler(B));
			global::A.A.A((global::A.D)B);
			BM.D(new EventHandler(B));
			BM.E(new EventHandler(B));
			BM.A(new EventHandler(b));
			((Control)this).DoubleBuffered = true;
			BjR.Interval = 40.0;
			BjR.SynchronizingObject = (ISynchronizeInvoke)(object)this;
			BjR.Elapsed += new ElapsedEventHandler(A);
			BjR.AutoReset = true;
		}

		protected override void Dispose(bool disposing)
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			try
			{
				if (BjV != null)
				{
					BjV.a(new EventHandler(A));
					((SettingOrSpecialObject)BjV).a(new EventHandler(a));
				}
				global::A.A.a(new EventHandler(B));
				global::A.A.a((global::A.D)B);
				BM.d(new EventHandler(B));
				BM.e(new EventHandler(B));
				BM.a(new EventHandler(b));
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(D);
					((ToolStripItem)item).Click -= new EventHandler(d);
					((ToolStripItem)item).Click -= new EventHandler(c);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(E);
				BjR.Elapsed -= new ElapsedEventHandler(A);
				((Component)BjR).Dispose();
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			if (BjV != null)
			{
				text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + ((object)BjV).ToString();
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
			if (BjV != null)
			{
				BjW = string.Empty;
				if (BM.Qj.ContainsKey(BjV.A()))
				{
					Bl bl = BM.Qj[BjV.A()];
					BjX = bl.Qi;
					Bjx = bl.QJ;
				}
				else
				{
					BjX = BjV.aP();
					Bjx = BjV.ap();
				}
				((Control)this).Invalidate();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0431: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Unknown result type (might be due to invalid IL or missing references)
			//IL_040b: Expected O, but got Unknown
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0501: Expected O, but got Unknown
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_050c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0516: Unknown result type (might be due to invalid IL or missing references)
			//IL_051b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0322: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08eb: Expected O, but got Unknown
			//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0900: Unknown result type (might be due to invalid IL or missing references)
			//IL_0905: Unknown result type (might be due to invalid IL or missing references)
			//IL_0839: Unknown result type (might be due to invalid IL or missing references)
			//IL_0840: Expected O, but got Unknown
			//IL_0846: Unknown result type (might be due to invalid IL or missing references)
			//IL_0850: Unknown result type (might be due to invalid IL or missing references)
			//IL_0855: Unknown result type (might be due to invalid IL or missing references)
			//IL_0884: Unknown result type (might be due to invalid IL or missing references)
			//IL_0889: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06be: Expected O, but got Unknown
			//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a99: Expected O, but got Unknown
			//IL_0656: Unknown result type (might be due to invalid IL or missing references)
			//IL_067e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0683: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0704: Unknown result type (might be due to invalid IL or missing references)
			//IL_070e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0761: Unknown result type (might be due to invalid IL or missing references)
			//IL_0768: Expected O, but got Unknown
			//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b39: Expected O, but got Unknown
			//IL_0792: Unknown result type (might be due to invalid IL or missing references)
			//IL_079d: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
			Stopwatch val = new Stopwatch();
			val.Start();
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = (SmoothingMode)2;
			bool flag = BjV != null && ((SettingOrSpecialObject)BjV).l() && PortFunction.A(BjV);
			Color val2 = ((!flag) ? Color.Gray : BM.te);
			int num = 0;
			int num2 = 0;
			string text = null;
			if (BjV != null)
			{
				num = BjV.ax();
				num2 = BjV.aS();
				text = bS.A(BjV.@as(), num2, true, num);
			}
			int num3 = 0;
			Size val7;
			Rectangle val8 = default(Rectangle);
			if (Bjw)
			{
				if (BjV != null)
				{
					string text2 = ((SettingOrSpecialObject)BjV).H();
					string text3 = (string.IsNullOrWhiteSpace(text2) ? ((SettingOrSpecialObject)BjV).A(bz.aYT) : (text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + ((SettingOrSpecialObject)BjV).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()));
					Font val3 = new Font(((Control)this).Font.FontFamily, (float)((Control)this).Height * 0.14f, (FontStyle)0);
					try
					{
						Size val4 = TextRenderer.MeasureText(text, val3, new Size(0, 0), (TextFormatFlags)268435456);
						int num4 = ((Control)this).Width - 3 - ((Size)(ref val4)).Width;
						Rectangle val5 = default(Rectangle);
						((Rectangle)(ref val5))._002Ector(3, 0, num4 - 10, ((Control)this).Height);
						if (BjP)
						{
							Size val6 = TextRenderer.MeasureText(text3 + BjW, val3, new Size(0, 0), (TextFormatFlags)268435456);
							num3 = ((Size)(ref val6)).Height;
							int width = ((Size)(ref val6)).Width;
							if (width <= ((Rectangle)(ref val5)).Width)
							{
								Bjp = 0;
								Bjr.Reset();
							}
							else if (Bjp > ((Rectangle)(ref val5)).Width - width)
							{
								if (!BjQ)
								{
									if (!Bjr.IsRunning)
									{
										Bjr.Restart();
										Bjp = 0;
									}
									else if (Bjr.ElapsedMilliseconds < 500)
									{
										Bjp = 0;
									}
								}
								else
								{
									Bjr.Reset();
								}
								Bjq = true;
							}
							else
							{
								Bjp = ((Rectangle)(ref val5)).Width - width;
								if (Bjq)
								{
									Bjr.Restart();
									Bjq = false;
								}
								else if (Bjr.ElapsedMilliseconds >= 800)
								{
									Bjp = 0;
									Bjr.Reset();
								}
								BjQ = false;
							}
						}
						else
						{
							Bjp = 0;
							Bjr.Reset();
							BjW = string.Empty;
							val7 = TextRenderer.MeasureText(text3, val3, new Size(0, 0), (TextFormatFlags)268435456);
							num3 = ((Size)(ref val7)).Height;
						}
						graphics.SetClip(val5, (CombineMode)0);
						if (BjP)
						{
							TextRenderer.DrawText((IDeviceContext)(object)graphics, text3 + BjW, val3, new Point(3 + Bjp, 3), val2, (TextFormatFlags)285212672);
						}
						else
						{
							TextRenderer.DrawText((IDeviceContext)(object)graphics, text3, val3, new Point(3 + Bjp, 3), val2, (TextFormatFlags)285212672);
						}
						graphics.ResetClip();
						TextRenderer.DrawText((IDeviceContext)(object)graphics, text, val3, new Point(num4, 3), val2, (TextFormatFlags)268435456);
					}
					finally
					{
						((System.IDisposable)val3)?.Dispose();
					}
				}
				((Rectangle)(ref val8))._002Ector(3, 3 + num3, ((Control)this).Width - 6 - 1, ((Control)this).Height - 6 - num3 - 1);
			}
			else
			{
				((Rectangle)(ref val8))._002Ector(3, 3, ((Control)this).Width - 6 - 1, ((Control)this).Height - 6 - 1);
			}
			bool flag2 = flag && ((BM.A(Bju.aXc, true) && !BM.aE()) || BM.C(BjV.A()));
			Color val9 = BM.tI;
			if (flag)
			{
				if (flag2 && (BjX != 0 || Bjx != 0) && (num < BjX || num > Bjx))
				{
					graphics.FillRectangle(Brushes.Maroon, val8);
					val9 = BM.Ty;
				}
				else
				{
					SolidBrush val10 = new SolidBrush(BM.th);
					graphics.FillRectangle((Brush)(object)val10, val8);
					((Brush)val10).Dispose();
				}
			}
			else
			{
				graphics.FillRectangle(Brushes.Gray, val8);
			}
			graphics.DrawRectangle(Pens.White, val8);
			if (flag2 && flag)
			{
				Rectangle val11 = default(Rectangle);
				((Rectangle)(ref val11))._002Ector(((Rectangle)(ref val8)).X + 4, ((Rectangle)(ref val8)).Y + 4, ((Rectangle)(ref val8)).Width - 8, ((Rectangle)(ref val8)).Height - 8);
				ValueTuple<string, string, bool> val12 = BjV.A(num, -1);
				int num5 = BjV.aR();
				int num6 = BjV.ar();
				string text4 = bS.a(num5, num2, -1);
				string text5 = bS.a(num6, num2, -1);
				graphics.SetClip(val11, (CombineMode)0);
				if (Bjw)
				{
					Font val13;
					if (val12.Item3 || BjV.c() != 0)
					{
						float num7 = 0.6f;
						val13 = new Font(((Control)this).Font.FontFamily, (float)Math.Max(((Rectangle)(ref val11)).Height, 1) * num7);
						val7 = TextRenderer.MeasureText(val12.Item1, val13, new Size(0, 0), (TextFormatFlags)268435456);
						int width2 = ((Size)(ref val7)).Width;
						if (width2 <= ((Rectangle)(ref val11)).Width)
						{
							BjU = true;
							BjS = 0;
							Bjt.Reset();
						}
						else if (BjS > ((Rectangle)(ref val11)).Width - width2)
						{
							if (!Bjs)
							{
								if (!Bjt.IsRunning)
								{
									Bjt.Restart();
									BjS = 0;
								}
								else if (Bjt.ElapsedMilliseconds < 500)
								{
									BjS = 0;
								}
							}
							else
							{
								Bjt.Reset();
							}
							BjT = true;
							BjU = false;
							if (!BjR.Enabled)
							{
								BjR.Enabled = true;
							}
						}
						else
						{
							BjS = ((Rectangle)(ref val11)).Width - width2;
							if (BjT)
							{
								Bjt.Restart();
								BjT = false;
							}
							else if (Bjt.ElapsedMilliseconds >= 800)
							{
								BjS = 0;
								Bjt.Reset();
							}
							Bjs = false;
							BjU = false;
							if (!BjR.Enabled)
							{
								BjR.Enabled = true;
							}
						}
						TextRenderer.DrawText((IDeviceContext)(object)graphics, val12.Item1, val13, new Point(((Rectangle)(ref val11)).Left + BjS, (((Rectangle)(ref val11)).Top + ((Rectangle)(ref val11)).Bottom) / 2), val9, (TextFormatFlags)285212676);
					}
					else
					{
						float num8 = 0.85f;
						val13 = new Font(((Control)this).Font.FontFamily, (float)Math.Max(((Rectangle)(ref val11)).Height, 1) * num8);
						BjU = true;
						BjS = 0;
						Bjt.Reset();
						Bjs = true;
						int width3;
						int width4;
						do
						{
							val7 = TextRenderer.MeasureText(text4, val13, new Size(0, 0), (TextFormatFlags)268435456);
							width3 = ((Size)(ref val7)).Width;
							val7 = TextRenderer.MeasureText(text5, val13, new Size(0, 0), (TextFormatFlags)268435456);
							width4 = ((Size)(ref val7)).Width;
							if (width3 > ((Rectangle)(ref val11)).Width || width4 > ((Rectangle)(ref val11)).Width)
							{
								val13.Dispose();
								num8 *= 0.9f;
								val13 = new Font(((Control)this).Font.FontFamily, (float)Math.Max(((Rectangle)(ref val11)).Height, 1) * num8);
								if (val13.Size < 8f)
								{
									break;
								}
							}
						}
						while (width3 > ((Rectangle)(ref val11)).Width || width4 > ((Rectangle)(ref val11)).Width);
						val7 = TextRenderer.MeasureText(val12.Item1, val13, new Size(0, 0), (TextFormatFlags)268435456);
						int width5 = ((Size)(ref val7)).Width;
						TextRenderer.DrawText((IDeviceContext)(object)graphics, val12.Item1, val13, new Point(((Rectangle)(ref val11)).Right - width5, (((Rectangle)(ref val11)).Top + ((Rectangle)(ref val11)).Bottom) / 2), val9, (TextFormatFlags)285212676);
					}
					val13.Dispose();
				}
				else
				{
					int num9 = 0;
					if (num2 != 0 && num2 != 82)
					{
						float num10 = Math.Min((float)Math.Max(((Rectangle)(ref val11)).Height, 1) * 0.2f, 16f);
						Font val14 = new Font(((Control)this).Font.FontFamily, num10);
						val7 = TextRenderer.MeasureText(text, val14, new Size(0, 0), (TextFormatFlags)268435456);
						num9 = ((Size)(ref val7)).Width + 4;
						TextRenderer.DrawText((IDeviceContext)(object)graphics, text, val14, new Point(((Rectangle)(ref val11)).Right + 4 - num9, ((Rectangle)(ref val11)).Top + ((Rectangle)(ref val11)).Height / 7), val9, (TextFormatFlags)285212672);
						val14.Dispose();
					}
					int num11 = ((Rectangle)(ref val11)).Width - num9;
					Font val15;
					if (val12.Item3 || BjV.c() != 0)
					{
						float num12 = 0.6f;
						val15 = new Font(((Control)this).Font.FontFamily, (float)Math.Max(((Rectangle)(ref val11)).Height, 1) * num12);
						val7 = TextRenderer.MeasureText(val12.Item1, val15, new Size(0, 0), (TextFormatFlags)268435456);
						int width6 = ((Size)(ref val7)).Width;
						if (width6 <= num11)
						{
							BjU = true;
							BjS = 0;
							Bjt.Reset();
						}
						else if (BjS > num11 - width6)
						{
							if (!Bjs)
							{
								if (!Bjt.IsRunning)
								{
									Bjt.Restart();
									BjS = 0;
								}
								else if (Bjt.ElapsedMilliseconds < 500)
								{
									BjS = 0;
								}
							}
							else
							{
								Bjt.Reset();
							}
							BjT = true;
							BjU = false;
							if (!BjR.Enabled)
							{
								BjR.Enabled = true;
							}
						}
						else
						{
							BjS = num11 - width6;
							if (BjT)
							{
								Bjt.Restart();
								BjT = false;
							}
							else if (Bjt.ElapsedMilliseconds >= 800)
							{
								BjS = 0;
								Bjt.Reset();
							}
							Bjs = false;
							BjU = false;
							if (!BjR.Enabled)
							{
								BjR.Enabled = true;
							}
						}
						TextRenderer.DrawText((IDeviceContext)(object)graphics, val12.Item1, val15, new Point(((Rectangle)(ref val11)).Left + BjS, (((Rectangle)(ref val11)).Top + ((Rectangle)(ref val11)).Bottom) / 2), val9, (TextFormatFlags)285212676);
					}
					else
					{
						float num13 = 0.85f;
						val15 = new Font(((Control)this).Font.FontFamily, (float)Math.Max(((Rectangle)(ref val11)).Height, 1) * num13);
						BjU = true;
						BjS = 0;
						Bjt.Reset();
						Bjs = true;
						int width7;
						int width8;
						do
						{
							val7 = TextRenderer.MeasureText(text4, val15, new Size(0, 0), (TextFormatFlags)268435456);
							width7 = ((Size)(ref val7)).Width;
							val7 = TextRenderer.MeasureText(text5, val15, new Size(0, 0), (TextFormatFlags)268435456);
							width8 = ((Size)(ref val7)).Width;
							if (width7 > num11 || width8 > num11)
							{
								val15.Dispose();
								num13 *= 0.9f;
								val15 = new Font(((Control)this).Font.FontFamily, (float)Math.Max(((Rectangle)(ref val11)).Height, 1) * num13);
								if (val15.Size < 8f)
								{
									break;
								}
							}
						}
						while (width7 > num11 || width8 > num11);
						val7 = TextRenderer.MeasureText(val12.Item1, val15, new Size(0, 0), (TextFormatFlags)268435456);
						int width9 = ((Size)(ref val7)).Width;
						TextRenderer.DrawText((IDeviceContext)(object)graphics, val12.Item1, val15, new Point(((Rectangle)(ref val8)).Right - num9 - width9, (((Rectangle)(ref val11)).Top + ((Rectangle)(ref val11)).Bottom) / 2), val9, (TextFormatFlags)285212676);
					}
					val15.Dispose();
				}
				graphics.ResetClip();
			}
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBF(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (base.B())
			{
				int num = BjV.ax();
				if (num != BjY)
				{
					((Control)this).Invalidate();
					BjY = num;
				}
			}
			else
			{
				BjY = -2147483648;
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

		private void b(object P_0, EventArgs P_1)
		{
			a();
		}

		internal void C(object P_0, EventArgs P_1)
		{
			Bjw = !Bjw;
			((Control)this).Invalidate();
			BM.QQ.rl.a(false);
		}

		private void A(object P_0, ElapsedEventArgs P_1)
		{
			if (BjP && base.B())
			{
				Bjp -= Math.Min(15, ((Control)this).Width / 25);
			}
			if (base.B())
			{
				BjS -= Math.Min(15, ((Control)this).Width / 25);
				if (BjP || !BjU)
				{
					((Control)this).Invalidate();
				}
			}
		}

		protected override void MouseMoveHandler(object sender, MouseEventArgs e)
		{
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			if (BjV != null && e.X > 3 && e.X < ((Control)this).Width - 3 && e.Y > 3 && e.Y < ((Control)this).Height - 3)
			{
				BjP = true;
				if (((SettingOrSpecialObject)BjV).D() != null)
				{
					if (PortFunction.a(((SettingOrSpecialObject)BjV).D()))
					{
						SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)BjV).D();
						Cg bSQ = settingOrSpecialObject.F().E().BSQ;
						CH bSq = settingOrSpecialObject.F().E().BSq;
						byte bSR = settingOrSpecialObject.F().E().BSR;
						ushort bSr = settingOrSpecialObject.F().E().BSr;
						List<bool> val = new List<bool>();
						List<string> val2 = PortFunction.A(Bju, bSQ, bSq, bSR, bSr, true, val);
						if (val2 != null && val2.Count == 1)
						{
							BjW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + val2[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
						}
						else
						{
							BjW = string.Empty;
						}
					}
					else if (Bju.aWY.Contains(((SettingOrSpecialObject)BjV).D()))
					{
						Dn dn = null;
						Enumerator<SettingOrSpecialObject> enumerator = ((SettingOrSpecialObject)BjV).D().a().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								SettingOrSpecialObject current = enumerator.Current;
								if (current is Dn)
								{
									if (dn != null)
									{
										dn = null;
										break;
									}
									dn = current as Dn;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						if (dn != null)
						{
							int num = dn.ax();
							Cg cg2 = PortFunction.A((uint)num);
							CH cH2 = PortFunction.a((uint)num);
							byte b = PortFunction.B((uint)num);
							ushort num2 = PortFunction.b((uint)num);
							string text = PortFunction.B(PortFunction.A(Bju, cg2, cH2, b, num2));
							if (text != null)
							{
								BjW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
							}
							else
							{
								BjW = string.Empty;
							}
						}
						else
						{
							BjW = string.Empty;
						}
					}
					else
					{
						BjW = string.Empty;
					}
				}
				else
				{
					BjW = string.Empty;
				}
				if (!BjR.Enabled)
				{
					BjR.Enabled = true;
				}
			}
			else
			{
				BjP = false;
				Bjp = 0;
				Bjr.Reset();
				BjW = string.Empty;
				BjQ = true;
			}
			base.MouseMoveHandler(sender, e);
		}

		protected override void MouseLeaveHandler(object sender, EventArgs e)
		{
			base.MouseLeaveHandler(sender, e);
			BjP = false;
			Bjp = 0;
			Bjr.Reset();
			BjW = string.Empty;
			BjQ = true;
			if (BjR.Enabled)
			{
				BjR.Enabled = false;
			}
			((Control)this).Invalidate();
		}

		private void c(object P_0, EventArgs P_1)
		{
			((Component)this).Dispose();
			BM.QQ.rl.a(false);
		}

		internal void D(object P_0, EventArgs P_1)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			int num = Bx.A((IWin32Window)(object)BM.QQ, Bju, (BjV != null) ? BjV.A() : 0);
			if (num != 0)
			{
				if (BjV != null)
				{
					BjV.a(new EventHandler(A));
					((SettingOrSpecialObject)BjV).a(new EventHandler(a));
				}
				BjV = Bju.A(num);
				if (BjV != null)
				{
					BjV.A(new EventHandler(A));
					((SettingOrSpecialObject)BjV).A(new EventHandler(a));
					Bjv = BjV.A();
				}
				a();
			}
			BjS = 0;
			Bjt.Reset();
			Bjs = true;
			BM.QQ.rl.a(false);
		}

		private void d(object P_0, EventArgs P_1)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Invalid comparison between Unknown and I4
			BQ bQ = new BQ(BjV, BjX, Bjx);
			if ((int)((Form)bQ).ShowDialog((IWin32Window)(object)BM.QQ) == 1 && BjV != null)
			{
				int num;
				int num2;
				if (BM.Qj.ContainsKey(BjV.A()))
				{
					Bl bl = BM.Qj[BjV.A()];
					num = bl.Qh;
					num2 = bl.QI;
				}
				else
				{
					num = BjV.aQ();
					num2 = BjV.aq();
				}
				BM.A(BjV.A(), num, num2, bQ.A(), bQ.a());
				a();
				BM.a();
			}
			((Component)bQ).Dispose();
		}

		private void E(object P_0, EventArgs P_1)
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
					((ToolStripItem)val).Enabled = BjV != null;
				}
				else if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBf())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
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
			((ToolStripDropDown)val).Opened += new EventHandler(E);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaC();
			((ToolStripItem)val2).Click += new EventHandler(D);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem();
			((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((ToolStripItem)val3).Click += new EventHandler(d);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBG();
			((ToolStripItem)val4).Click += new EventHandler(C);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
			ToolStripMenuItem val5 = new ToolStripMenuItem();
			((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBf();
			((ToolStripItem)val5).Click += new EventHandler(c);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBg());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf() + Bjv);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaN() + Bjw);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Expected O, but got Unknown
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected O, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			string text;
			int bjv = default(int);
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaN()))
				{
					Bjw = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaN().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaP()))
				{
					Bjw = !bool.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaP()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaP().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf()))
				{
					Bjv = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf().Length));
					if (Bjv != -1)
					{
						BjV = Bju.A(Bjv);
						if (BjV != null)
						{
							BjV.A(new EventHandler(A));
							((SettingOrSpecialObject)BjV).A(new EventHandler(a));
						}
					}
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()))
				{
					string text2 = text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI().Length);
					if (int.TryParse(text2, ref bjv))
					{
						Bjv = bjv;
					}
					else
					{
						try
						{
							text2 = text2.Substring(1, text2.Length - 2);
							Bjv = (int)(bs)System.Enum.Parse(typeof(bs), text2);
						}
						catch
						{
							Bjv = -1;
						}
					}
					if (Bjv != -1)
					{
						BjV = Bju.A(Bjv);
						if (BjV != null)
						{
							BjV.A(new EventHandler(A));
							((SettingOrSpecialObject)BjV).A(new EventHandler(a));
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
	internal class cn : MovableResizablePanel
	{
		private Table Bjy;

		private int BjZ = -1;

		private Setting Bjz;

		private Setting BKA;

		private Pen BKa;

		private Pen BKB;

		private Pen BKb;

		private Framework BKC;

		private bool BKc;

		internal cn(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			BKC = P_0;
			((Control)this).DoubleBuffered = true;
		}

		internal void A(int P_0)
		{
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected O, but got Unknown
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected O, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Expected O, but got Unknown
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Expected O, but got Unknown
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Expected O, but got Unknown
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected O, but got Unknown
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected O, but got Unknown
			Setting setting = BKC.A(P_0);
			if (setting != null)
			{
				Bjy = setting as Table;
			}
			else
			{
				Bjy = null;
			}
			if (Bjy != null)
			{
				BjZ = ((Setting)Bjy).A();
				if (!((SettingOrSpecialObject)Bjy).l())
				{
					Bjy = null;
				}
			}
			if (BKC.B() && BKC.b() && Bjy != null && Bjy.J())
			{
				Label val = new Label();
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)Bjy).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
				((Control)val).ForeColor = BM.te;
				((Control)val).BackColor = Color.Transparent;
				((Control)val).AutoSize = true;
				((Control)val).Left = 10;
				((Control)val).Top = 10;
				((Control)this).Controls.Add((Control)(object)val);
				BKc = true;
				return;
			}
			if (Bjy != null)
			{
				((Setting)Bjy).A(new EventHandler(c));
				Bjy.TableDataSetting.A(new EventHandler(c));
				Bjy.OnUserSelectionChanged += new EventHandler(a);
				Bjy.OnInvertRows += new EventHandler(B);
				Bjy.OnSwapColumnsAndRows += new EventHandler(b);
				Bjy.OnUserSliceIndexChanged += new EventHandler(A);
			}
			((Control)this).Paint += new PaintEventHandler(A);
			global::A.A.A(new EventHandler(D));
			global::A.A.A((global::A.D)D);
			BM.D(new EventHandler(D));
			BM.E(new EventHandler(D));
			switch (BM.Tn)
			{
			case BM.r.Bqg:
				BKa = Pens.Gray;
				if (BKB != null)
				{
					BKB.Dispose();
				}
				BKB = new Pen(Color.Gray, 1f);
				if (BKb != null)
				{
					BKb.Dispose();
				}
				BKb = new Pen(Color.White, 7f);
				break;
			case BM.r.BqH:
				BKa = Pens.Gray;
				if (BKB != null)
				{
					BKB.Dispose();
				}
				BKB = new Pen(Color.Gray, 1f);
				if (BKb != null)
				{
					BKb.Dispose();
				}
				BKb = new Pen(Color.White, 7f);
				break;
			default:
				BKa = Pens.Black;
				if (BKB != null)
				{
					BKB.Dispose();
				}
				BKB = new Pen(Color.Gray, 1f);
				if (BKb != null)
				{
					BKb.Dispose();
				}
				BKb = new Pen(Color.Black, 7f);
				break;
			}
			BKB.DashStyle = (DashStyle)1;
			UpdateLayout(resizingOnly: false);
			((Control)this).ContextMenuStrip = B();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Expected O, but got Unknown
			//IL_0322: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Expected O, but got Unknown
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Expected O, but got Unknown
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Expected O, but got Unknown
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Expected O, but got Unknown
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected O, but got Unknown
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected O, but got Unknown
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Expected O, but got Unknown
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Expected O, but got Unknown
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Expected O, but got Unknown
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Expected O, but got Unknown
			try
			{
				if (BKB != null)
				{
					BKB.Dispose();
				}
				if (BKb != null)
				{
					BKb.Dispose();
				}
				if (!BKc)
				{
					((Control)this).Paint -= new PaintEventHandler(A);
					if (Bjy != null)
					{
						Bjy.a(new EventHandler(c));
						Bjy.TableDataSetting.a(new EventHandler(c));
						Bjy.OnUserSelectionChanged -= new EventHandler(a);
						Bjy.OnInvertRows -= new EventHandler(B);
						Bjy.OnSwapColumnsAndRows -= new EventHandler(b);
						Bjy.OnUserSliceIndexChanged -= new EventHandler(A);
						if (Bjy.HorizAxis != null && Bjy.HorizAxis.F() != null)
						{
							Bjy.HorizAxis.F().a(new EventHandler(c));
						}
						if (Bjy.VertAxis != null && Bjy.VertAxis.F() != null)
						{
							Bjy.VertAxis.F().a(new EventHandler(c));
						}
						if (Bjy.HorizAxis != null && Bjy.HorizAxis.f() != null)
						{
							Bjy.HorizAxis.f().a(new EventHandler(c));
						}
						if (Bjy.VertAxis != null && Bjy.VertAxis.f() != null)
						{
							Bjy.VertAxis.f().a(new EventHandler(c));
						}
						if (Bjy.HorizAxis != null && Bjy.HorizAxis.G() != null)
						{
							Bjy.HorizAxis.G().a(new EventHandler(c));
						}
						if (Bjy.VertAxis != null && Bjy.VertAxis.G() != null)
						{
							Bjy.VertAxis.G().a(new EventHandler(c));
						}
						if (Bjy.HorizAxis != null && Bjy.HorizAxis.g() != null)
						{
							Bjy.HorizAxis.g().a(new EventHandler(C));
						}
						if (Bjy.VertAxis != null && Bjy.VertAxis.g() != null)
						{
							Bjy.VertAxis.g().a(new EventHandler(C));
						}
					}
					if (Bjz != null)
					{
						Bjz.a(new EventHandler(c));
					}
					if (BKA != null)
					{
						BKA.a(new EventHandler(c));
					}
					global::A.A.a(new EventHandler(D));
					global::A.A.a((global::A.D)D);
					BM.d(new EventHandler(D));
					BM.e(new EventHandler(D));
					if (((Control)this).ContextMenuStrip != null)
					{
						foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
						{
							((ToolStripItem)item).Click -= new EventHandler(d);
						}
						((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(E);
					}
				}
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		[SpecialName]
		internal Table a()
		{
			return Bjy;
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			if (Bjy != null)
			{
				text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + ((object)Bjy).ToString();
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

		public override void UpdateLayout(bool resizingOnly)
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got Unknown
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected O, but got Unknown
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Expected O, but got Unknown
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected O, but got Unknown
			//IL_0294: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected O, but got Unknown
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Expected O, but got Unknown
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Expected O, but got Unknown
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Expected O, but got Unknown
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected O, but got Unknown
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected O, but got Unknown
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a7: Expected O, but got Unknown
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03be: Expected O, but got Unknown
			if (BKc || Bjy == null)
			{
				return;
			}
			if (Bjy.HorizAxis != null && Bjy.HorizAxis.F() != null)
			{
				Bjy.HorizAxis.F().a(new EventHandler(c));
				Bjy.HorizAxis.F().A(new EventHandler(c));
			}
			if (Bjy.VertAxis != null && Bjy.VertAxis.F() != null)
			{
				Bjy.VertAxis.F().a(new EventHandler(c));
				Bjy.VertAxis.F().A(new EventHandler(c));
			}
			if (Bjy.HorizAxis != null && Bjy.HorizAxis.f() != null)
			{
				Bjy.HorizAxis.f().a(new EventHandler(c));
				Bjy.HorizAxis.f().A(new EventHandler(c));
			}
			if (Bjy.VertAxis != null && Bjy.VertAxis.f() != null)
			{
				Bjy.VertAxis.f().a(new EventHandler(c));
				Bjy.VertAxis.f().A(new EventHandler(c));
			}
			if (Bjy.HorizAxis != null && Bjy.HorizAxis.G() != null)
			{
				Bjy.HorizAxis.G().a(new EventHandler(c));
				Bjy.HorizAxis.G().A(new EventHandler(c));
			}
			if (Bjy.VertAxis != null && Bjy.VertAxis.G() != null)
			{
				Bjy.VertAxis.G().a(new EventHandler(c));
				Bjy.VertAxis.G().A(new EventHandler(c));
			}
			if (Bjy.HorizAxis != null && Bjy.HorizAxis.g() != null)
			{
				Bjy.HorizAxis.g().a(new EventHandler(C));
				Bjy.HorizAxis.g().A(new EventHandler(C));
				Bjz = Bjy.HorizAxis.h();
				if (Bjz != null)
				{
					Bjz.a(new EventHandler(c));
					Bjz.A(new EventHandler(c));
				}
			}
			if (Bjy.VertAxis != null && Bjy.VertAxis.g() != null)
			{
				Bjy.VertAxis.g().a(new EventHandler(C));
				Bjy.VertAxis.g().A(new EventHandler(C));
				BKA = Bjy.VertAxis.h();
				if (BKA != null)
				{
					BKA.a(new EventHandler(c));
					BKA.A(new EventHandler(c));
				}
			}
			((Control)this).Invalidate();
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		private void a(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		private void B(object P_0, EventArgs P_1)
		{
			UpdateLayout(resizingOnly: false);
		}

		private void b(object P_0, EventArgs P_1)
		{
			UpdateLayout(resizingOnly: false);
		}

		private void C(object P_0, EventArgs P_1)
		{
			UpdateLayout(resizingOnly: false);
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (base.B())
			{
				((Control)this).Invalidate();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		private void A(object P_0, PaintEventArgs P_1)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0603: Unknown result type (might be due to invalid IL or missing references)
			//IL_060a: Expected O, but got Unknown
			if (Bjy == null)
			{
				return;
			}
			Stopwatch val = new Stopwatch();
			val.Start();
			try
			{
				Graphics graphics = P_1.Graphics;
				graphics.SmoothingMode = (SmoothingMode)2;
				SolidBrush val2 = new SolidBrush(BM.te);
				int num2;
				try
				{
					Font val3 = new Font(((Control)this).Font.FontFamily, 10f);
					try
					{
						int num = Bjy.aS();
						string text = string.Empty;
						if (num != 0 && num != 82)
						{
							text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(Bjy.@as(), num, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
						}
						string text2 = ((SettingOrSpecialObject)Bjy).H();
						string text3 = (string.IsNullOrWhiteSpace(text2) ? ((SettingOrSpecialObject)Bjy).A(bz.aYt) : text2);
						string text4 = text3 + text;
						SizeF val4 = graphics.MeasureString(text4, val3, ((Control)this).Width - 10);
						num2 = (int)((SizeF)(ref val4)).Height;
						Rectangle val5 = default(Rectangle);
						((Rectangle)(ref val5))._002Ector(8, 8, ((Control)this).Width - 10, num2);
						graphics.DrawString(text4, val3, (Brush)(object)val2, RectangleF.op_Implicit(val5));
					}
					finally
					{
						((System.IDisposable)val3)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
				int num3 = 8 + num2 + 10;
				int num4 = ((Control)this).Height - 10;
				int num5 = num4 - num3;
				int num6 = 10;
				int num7 = ((Control)this).Width - 10;
				int num8 = num7 - num6;
				int num9 = ((Control)this).Width / 2;
				int num10 = num3 + num5 / 2;
				graphics.DrawRectangle(BKa, num6, num3, num8, num5);
				graphics.DrawLine(BKB, num9 - 10, num3, num9 - 10, num4);
				graphics.DrawLine(BKB, num9 + 10, num3, num9 + 10, num4);
				graphics.DrawLine(BKB, num6, num10 - 10, num7, num10 - 10);
				graphics.DrawLine(BKB, num6, num10 + 10, num7, num10 + 10);
				if (Bjy == null)
				{
					return;
				}
				bool flag = Bjy.HorizAxisEnabled();
				bool flag2 = Bjy.VertAxisEnabled();
				if (((BM.A(BKC.aXc, true) && !BM.aE()) || (BM.C(Bjz.A()) && BM.C(BKA.A()))) && Bjy.HorizVertIndexPerUserSelectedCell.Count != 0 && (flag || flag2))
				{
					int num11 = Bjy.HorizAxisCount();
					int num12 = Bjy.VertAxisCount();
					int num13 = 2147483647;
					int num14 = -2147483648;
					int num15 = 2147483647;
					int num16 = -2147483648;
					Enumerator<Point> enumerator = Bjy.HorizVertIndexPerUserSelectedCell.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Point current = enumerator.Current;
							num13 = Math.Min(num13, ((Point)(ref current)).X);
							num14 = Math.Max(num14, ((Point)(ref current)).X);
							num15 = Math.Min(num15, ((Point)(ref current)).Y);
							num16 = Math.Max(num16, ((Point)(ref current)).Y);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					int num17 = Math.Max(0, num13 - 1);
					int num18 = Math.Min(num11 - 1, num14 + 1);
					int num19 = Math.Max(0, num15 - 1);
					int num20 = Math.Min(num12 - 1, num16 + 1);
					int num21 = Bjy.HorizAxis.G().m(num17);
					int num22 = Bjy.HorizAxis.G().m(num18);
					int num23;
					int num24;
					if (Bjy.InvertRows)
					{
						num23 = Bjy.VertAxis.G().m(num12 - 1 - num19);
						num24 = Bjy.VertAxis.G().m(num12 - 1 - num20);
					}
					else
					{
						num23 = Bjy.VertAxis.G().m(num19);
						num24 = Bjy.VertAxis.G().m(num20);
					}
					int num25 = (Bjy.HorizAxis.G().m(num13) + Bjy.HorizAxis.G().m(num14)) / 2;
					int num26 = ((!Bjy.InvertRows) ? ((Bjy.VertAxis.G().m(num15) + Bjy.VertAxis.G().m(num16)) / 2) : ((Bjy.VertAxis.G().m(num12 - 1 - num15) + Bjy.VertAxis.G().m(num12 - 1 - num16)) / 2));
					int num27 = num9 - num6;
					int num28 = num25 - num21;
					if (num28 == 0)
					{
						num28 = num22 - num25;
					}
					int num29 = num10 - num3;
					int num30 = num26 - num23;
					if (num30 == 0)
					{
						num30 = num24 - num26;
					}
					int num31 = Bjz.ax();
					int num32 = BKA.ax();
					int num33 = ((num28 != 0 && flag) ? (num9 - (num25 - num31) * num27 / num28) : num9);
					int num34 = ((num30 != 0 && flag2) ? (num10 - (num26 - num32) * num29 / num30) : num10);
					BKb.EndCap = (LineCap)20;
					if (num33 != num9 || num34 != num10)
					{
						graphics.DrawLine(BKb, num33, num34, num9, num10);
					}
					if (num31 >= num21 && num31 <= num22 && ((!Bjy.InvertRows && num32 >= num23 && num32 <= num24) || (Bjy.InvertRows && num32 <= num23 && num32 >= num24)))
					{
						if ((!flag || (num31 >= num25 - num25 / 80 && num31 <= num25 + num25 / 80)) && (!flag2 || (num32 >= num26 - num26 / 80 && num32 <= num26 + num26 / 80)))
						{
							graphics.FillEllipse(Brushes.Green, num33 - 10, num34 - 10, 20, 20);
						}
						else
						{
							Pen val6 = new Pen(Color.Red, 3f);
							try
							{
								graphics.DrawEllipse(val6, num33 - 10, num34 - 10, 20, 20);
							}
							finally
							{
								((System.IDisposable)val6)?.Dispose();
							}
						}
					}
				}
			}
			catch
			{
			}
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBH(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
		}

		private void d(object P_0, EventArgs P_1)
		{
			q.A((Control)(object)this);
			BM.QQ.rl.a(false);
		}

		private void E(object P_0, EventArgs P_1)
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
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBh())
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
			//IL_005e: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripDropDown)val).Opened += new EventHandler(E);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBh();
			((ToolStripItem)val2).Click += new EventHandler(d);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBI());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi() + BjZ);
			if (Bjy != null)
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ() + Bjy.InvertRows);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj() + Bjy.SwapColumnsAndRows);
			}
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			string text;
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi()))
				{
					BjZ = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi().Length));
					if (BKC.A(BjZ) != null)
					{
						A(BjZ);
					}
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK()))
				{
					BjZ = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK().Length));
					if (BKC.A(BjZ) != null)
					{
						A(BjZ);
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ()))
				{
					if (Bjy != null)
					{
						Bjy.InvertRows = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ().Length));
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj()))
				{
					if (Bjy != null)
					{
						Bjy.SwapColumnsAndRows = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj().Length));
					}
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
	internal static class CN
	{
		internal static List<string> A(Cn P_0)
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			List<string> val = new List<string>();
			string text = ((P_0.BCY != (Version)null) ? ((object)P_0.BCY).ToString() : string.Empty);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVy() + text);
			string text2 = ((P_0.BCy != null) ? P_0.BCy : string.Empty);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVZ() + text2);
			Enumerator<string, string> enumerator = P_0.Bcb.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> current = enumerator.Current;
					string text3 = ((current.Value != null) ? current.Value : string.Empty);
					val.Add(Cn.A(current.Key, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + text3);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			string bsP = P_0.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP;
			bsP = ((bsP != null) ? bsP : string.Empty);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVz() + bsP);
			string bsp = P_0.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].Bsp;
			bsp = ((bsp != null) ? bsp : string.Empty);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avA() + bsp);
			string bsQ = P_0.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsQ;
			bsQ = ((bsQ != null) ? bsQ : string.Empty);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ava() + bsQ);
			return val;
		}

		internal static List<string> A(Cn P_0, MenuNode P_1, bool P_2)
		{
			return A(P_0, P_1, P_0.A(P_1, false, false), P_2);
		}

		internal static List<string> A(Cn P_0, MenuNode P_1, List<Setting> P_2, bool P_3)
		{
			List<string> result = new List<string>();
			List<Setting> val = new List<Setting>();
			A(ref result, P_2, val);
			a(ref result, P_2, val);
			A(ref result, P_2, val, P_0, P_1, P_3);
			a(ref result, P_2, val, P_0, P_1, P_3);
			return result;
		}

		private static void A(ref List<string> P_0, List<Setting> P_1, List<Setting> P_2)
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
							if (P_0.Count != 0)
							{
								P_0.Add(string.Empty);
							}
							P_0.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avB());
							flag = true;
						}
						string text = ((SettingOrSpecialObject)table).A(bz.aYt);
						if (string.IsNullOrWhiteSpace(text))
						{
							text = ((SettingOrSpecialObject)table).B();
						}
						P_0.Add(text);
					}
					P_2.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private static void a(ref List<string> P_0, List<Setting> P_1, List<Setting> P_2)
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
							if (P_0.Count != 0)
							{
								P_0.Add(string.Empty);
							}
							P_0.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avb());
							flag = true;
						}
						string text = ((SettingOrSpecialObject)sensorCalibration).A(bz.aYt);
						if (string.IsNullOrWhiteSpace(text))
						{
							text = ((SettingOrSpecialObject)sensorCalibration).B();
						}
						P_0.Add(text);
					}
					P_2.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private static void A(ref List<string> P_0, List<Setting> P_1, List<Setting> P_2, Cn P_3, MenuNode P_4, bool P_5)
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
						if (P_0.Count != 0)
						{
							P_0.Add(string.Empty);
						}
						P_0.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avC());
						flag = true;
					}
					string text = ((SettingOrSpecialObject)current).A(bz.aYt);
					if (string.IsNullOrWhiteSpace(text))
					{
						text = ((SettingOrSpecialObject)current).B();
					}
					string text2 = null;
					int num = 0;
					if (P_5)
					{
						num = current.ax();
					}
					else
					{
						int[] array = P_3.a(current);
						if (array != null && array.Length == 1)
						{
							num = array[0];
						}
						else
						{
							text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avc();
						}
					}
					if (text2 == null)
					{
						if (num == 0)
						{
							text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avD();
						}
						else
						{
							Cg cg = PortFunction.A((uint)num);
							CH cH = PortFunction.a((uint)num);
							byte b = PortFunction.B((uint)num);
							ushort num2 = PortFunction.b((uint)num);
							if (cH == CH.Bal)
							{
								text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avd();
							}
							else
							{
								SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(P_4.a(), cg, cH, b, num2);
								if (settingOrSpecialObject != null)
								{
									string text3 = PortFunction.B(settingOrSpecialObject);
									text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avE() + text3;
								}
								else
								{
									text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ave();
								}
							}
						}
					}
					P_0.Add(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + text2);
					P_2.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private static void a(ref List<string> P_0, List<Setting> P_1, List<Setting> P_2, Cn P_3, MenuNode P_4, bool P_5)
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
						if (P_0.Count != 0)
						{
							P_0.Add(string.Empty);
						}
						P_0.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avF());
						flag = true;
					}
					if (P_4.a().awX.ContainsKey(current.A()))
					{
						A(ref P_0, current, P_3, P_4, P_5);
					}
					else if (current.c() != 0)
					{
						a(ref P_0, current, P_3, P_5);
					}
					else
					{
						A(ref P_0, current, P_3, P_5);
					}
					P_2.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private static void A(ref List<string> P_0, Setting P_1, Cn P_2, bool P_3)
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			string text = ((SettingOrSpecialObject)P_1).A(bz.aYt);
			if (string.IsNullOrWhiteSpace(text))
			{
				text = ((SettingOrSpecialObject)P_1).B();
			}
			string text2 = string.Empty;
			int num = 0;
			int[] array = null;
			if (P_3)
			{
				num = P_1.Ba();
			}
			else
			{
				array = P_2.a(P_1);
				if (array != null)
				{
					num = array.Length;
				}
			}
			if (P_3 || array != null)
			{
				for (int i = 0; i < num; i++)
				{
					int num2 = ((!P_3) ? array[i] : P_1.m(i));
					ValueTuple<string, string, bool> val = P_1.A(num2, -1);
					text2 = ((i <= 0) ? val.Item1 : (text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + val.Item1));
					if (!string.IsNullOrEmpty(val.Item2))
					{
						text2 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + val.Item2;
					}
				}
			}
			else
			{
				text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avf();
			}
			string text3 = text2;
			P_0.Add(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + text3);
		}

		private static void a(ref List<string> P_0, Setting P_1, Cn P_2, bool P_3)
		{
			string text = ((SettingOrSpecialObject)P_1).A(bz.aYt);
			if (string.IsNullOrWhiteSpace(text))
			{
				text = ((SettingOrSpecialObject)P_1).B();
			}
			string text2;
			if (P_3)
			{
				text2 = P_1.ay();
			}
			else
			{
				byte[] array = P_2.A(P_1);
				text2 = ((array == null) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avf() : Encoding.GetEncoding(P_1.c()).GetString(array).TrimEnd('\0'));
			}
			P_0.Add(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + text2);
		}

		private static void A(ref List<string> P_0, Setting P_1, Cn P_2, MenuNode P_3, bool P_4)
		{
			string text = ((SettingOrSpecialObject)P_1).A(bz.aYt);
			if (string.IsNullOrWhiteSpace(text))
			{
				text = ((SettingOrSpecialObject)P_1).B();
			}
			string text2;
			if (P_4)
			{
				MenuNode menuNode = P_3.a().awX[P_1.A()];
				text2 = ((menuNode.Y() != null && menuNode.Y().BcF != null && !P_1.Bb()) ? menuNode.Y().BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].Bsp : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avG());
			}
			else
			{
				text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avf();
				byte[] array = P_2.A(P_1);
				if (array != null && array.Length == P_1.BB())
				{
					bool flag = true;
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i] != 0)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avG();
					}
					else
					{
						lock (BM.qb)
						{
							string text3 = n.A(array);
							if (BM.qB.ContainsKey(text3))
							{
								text2 = BM.qB[text3].BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].Bsp;
							}
						}
					}
				}
			}
			P_0.Add(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + text2);
		}
	}
	internal class Cn
	{
		internal struct A
		{
			internal string BsP;

			internal string Bsp;

			internal string BsQ;
		}

		internal const string BCW = "00000000000000000000000000000000";

		internal string BCw;

		internal string BCX;

		internal int BCx;

		internal Version BCY;

		internal string BCy;

		internal k BCZ;

		internal int BCz;

		internal int BcA;

		internal string Bca;

		internal string BcB;

		internal Dictionary<string, string> Bcb = new Dictionary<string, string>();

		internal Dictionary<string, A> BcC = new Dictionary<string, A>();

		internal Dictionary<DataIdAndAttrId, byte[]> Bcc = new Dictionary<DataIdAndAttrId, byte[]>();

		internal Dictionary<int, byte[]> BcD = new Dictionary<int, byte[]>();

		internal Dictionary<int, Dictionary<int, byte[]>> Bcd = new Dictionary<int, Dictionary<int, byte[]>>();

		internal Dictionary<int, Dictionary<int, byte[]>> BcE = new Dictionary<int, Dictionary<int, byte[]>>();

		internal Dictionary<int, string> Bce = new Dictionary<int, string>();

		private string A(int P_0)
		{
			if (Bce.ContainsKey(P_0))
			{
				return Bce[P_0];
			}
			return null;
		}

		public virtual string ToString()
		{
			if (BcC.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()) && BCY != (Version)null)
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avg() + BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].Bsp + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ix() + ((object)BCY).ToString();
			}
			return base.ToString();
		}

		internal byte[] A(Setting P_0)
		{
			byte[] result = null;
			if (((SettingOrSpecialObject)P_0).A().awF.ContainsKey(BCx))
			{
				DO dO = ((SettingOrSpecialObject)P_0).A().awF[BCx];
				if (Bcc.ContainsKey(P_0.C()))
				{
					if (dO.B().Contains(P_0.C().DataId))
					{
						result = Bcc[P_0.C()];
					}
				}
				else if (BcD.ContainsKey(P_0.d()))
				{
					if (dO.a().Contains(P_0.d()))
					{
						result = BcD[P_0.d()];
					}
				}
				else
				{
					result = A(P_0, dO);
				}
			}
			return result;
		}

		internal int[] A(Setting P_0, byte[] P_1)
		{
			if (P_0.Ba() == 1 && P_1.Length < P_0.BB())
			{
				int num = N.A(P_1, 0, P_1.Length, P_0.ag(), true);
				return new int[1] { num };
			}
			return N.A(P_1, P_0.aG(), P_0.ag(), true);
		}

		internal int[] a(Setting P_0)
		{
			byte[] array = A(P_0);
			if (array == null)
			{
				return null;
			}
			return A(P_0, array);
		}

		private byte[] A(Setting P_0, DO P_1)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			byte[] result = null;
			PortFunction.B b = PortFunction.A(P_0, true);
			if (b != null)
			{
				List<Dn> val = PortFunction.A(((SettingOrSpecialObject)P_0).A(), b.BSQ, b.BSq, b.BSR, b.BSr, false);
				if (val != null && val.Count != 0)
				{
					Enumerator<Dn> enumerator = val.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Dn current = enumerator.Current;
							int num = current.d();
							if (BcE.ContainsKey(num))
							{
								if (val.Count == 1 || MenuNode.A(((SettingOrSpecialObject)P_0).A().awj, current.C()) == MenuNode.A(((SettingOrSpecialObject)P_0).A().awj, P_0.C()))
								{
									Dictionary<int, byte[]> val2 = BcE[num];
									if (val2.ContainsKey(P_0.d()) && P_1.b().ContainsKey(num) && P_1.b()[num].Contains(P_0.d()))
									{
										result = val2[P_0.d()];
									}
									break;
								}
							}
							else if (Bcd.ContainsKey(((Setting)current).A()))
							{
								Dictionary<int, byte[]> val3 = Bcd[((Setting)current).A()];
								if (val3.ContainsKey(P_0.d()) && P_1.C().ContainsKey(((Setting)current).A()) && P_1.C()[((Setting)current).A()].Contains(P_0.d()))
								{
									result = val3[P_0.d()];
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
			return result;
		}

		internal static Setting A(Framework P_0, HashSet<DataIdAndAttrId> P_1, int P_2)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<DataIdAndAttrId> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataIdAndAttrId current = enumerator.Current;
					Setting setting = P_0.A(current);
					if (setting != null && setting.d() == P_2)
					{
						return setting;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return null;
		}

		internal static Setting A(Framework P_0, HashSet<DataIdAndAttrId> P_1, int P_2, int P_3, int P_4)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<DataIdAndAttrId> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataIdAndAttrId current = enumerator.Current;
					Setting setting = P_0.A(current);
					if (setting == null || setting.d() != P_2)
					{
						continue;
					}
					PortFunction.B b = PortFunction.A(setting, true);
					if (b == null)
					{
						continue;
					}
					List<Dn> val = PortFunction.A(((SettingOrSpecialObject)setting).A(), b.BSQ, b.BSq, b.BSR, b.BSr, false);
					if (val == null || val.Count == 0)
					{
						continue;
					}
					Enumerator<Dn> enumerator2 = val.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							Dn current2 = enumerator2.Current;
							if (((P_3 != 0 && current2.d() == P_3) || (P_4 != 0 && ((Setting)current2).A() == P_4)) && (P_4 != 0 || val.Count == 1 || MenuNode.A(((SettingOrSpecialObject)setting).A().awj, current2.C()) == MenuNode.A(((SettingOrSpecialObject)setting).A().awj, setting.C())))
							{
								return setting;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return null;
		}

		internal void A(MenuNode P_0)
		{
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			HashSet<DataIdAndAttrId> val = MenuNode.A(P_0, false);
			Framework framework = P_0.a();
			if (framework.awZ == 21 && !BM.qW)
			{
				cb.b();
				if (BM.A(framework.aXc, true))
				{
					global::A.A.d(framework.aXc, out var _);
				}
			}
			A(framework, val);
			if (Bcd.Count != 0 || BcE.Count != 0)
			{
				BM.QQ.aa();
				val = MenuNode.A(P_0, false);
				Enumerator<int, Dictionary<int, byte[]>> enumerator = Bcd.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						Dn dn = framework.A(current) as Dn;
						List<Setting> val2 = new List<Setting>();
						PortFunction.A(dn, val2, false);
						Enumerator<Setting> enumerator2 = val2.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								Setting current2 = enumerator2.Current;
								val.Add(current2.C());
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
						List<Table> val3 = new List<Table>();
						PortFunction.A(dn, val3, false);
						Enumerator<Table> enumerator3 = val3.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								Enumerator<DataIdAndAttrId> enumerator4 = enumerator3.Current.GetIdsContained().GetEnumerator();
								try
								{
									while (enumerator4.MoveNext())
									{
										DataIdAndAttrId current3 = enumerator4.Current;
										val.Add(current3);
									}
								}
								finally
								{
									((System.IDisposable)enumerator4).Dispose();
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator3).Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				A(framework, val);
			}
			P_0.y();
			P_0.i(false);
			if (!P_0.aB())
			{
				P_0.G(true);
			}
		}

		private void A(Framework P_0, HashSet<DataIdAndAttrId> P_1)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			if (!P_0.awF.ContainsKey(BCx))
			{
				return;
			}
			DO dO = P_0.awF[BCx];
			Enumerator<DataIdAndAttrId, byte[]> enumerator = Bcc.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataIdAndAttrId current = enumerator.Current;
					if (dO.B().Contains(current.DataId))
					{
						Setting setting = P_0.A(current);
						a(setting, Bcc[current]);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (BcD.Keys.Count != 0 || Bcd.Keys.Count != 0 || BcE.Keys.Count != 0)
			{
				Enumerator<DataIdAndAttrId> enumerator2 = P_1.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						DataIdAndAttrId current2 = enumerator2.Current;
						if (Bcc.Keys.Contains(current2))
						{
							continue;
						}
						Setting setting2 = P_0.A(current2);
						if (setting2 != null && !setting2.am() && !setting2.aJ())
						{
							byte[] array = A(setting2);
							if (array != null)
							{
								a(setting2, array);
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			A(dO, P_0, P_1);
		}

		private void a(Setting P_0, byte[] P_1)
		{
			if (P_1 != null && P_0 != null && !P_0.am() && !P_0.aJ())
			{
				int[] array = A(P_0, P_1);
				if (P_0.A(array, true) || P_0.S().Count != 0)
				{
					BM.A(P_0.C());
				}
				if (((SettingOrSpecialObject)P_0).A().awX.ContainsKey(P_0.A()))
				{
					string text = A(P_0.A());
					A(P_0, text);
				}
			}
		}

		internal List<Setting> A(MenuNode P_0, bool P_1, bool P_2)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			HashSet<DataIdAndAttrId> val = MenuNode.A(P_0, false);
			Framework framework = P_0.a();
			List<Setting> val2 = A(framework, val, P_1, P_2);
			if (Bcd.Count != 0 || BcE.Count != 0)
			{
				Enumerator<int, Dictionary<int, byte[]>> enumerator = Bcd.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						bool flag = false;
						Enumerator<Setting> enumerator2 = val2.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								Setting current2 = enumerator2.Current;
								if (current2 is Dn && current2.A() == current)
								{
									flag = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
						if (!flag)
						{
							continue;
						}
						Dn dn = framework.A(current) as Dn;
						int[] array = a(dn);
						if (array == null)
						{
							continue;
						}
						int num = array[0];
						List<Setting> val3 = new List<Setting>();
						PortFunction.A(num, dn.al(), dn.aN(), framework, val3, false);
						enumerator2 = val3.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								Setting current3 = enumerator2.Current;
								if (current3.d() != 0 && Bcd[current].ContainsKey(current3.d()) && !val2.Contains(current3))
								{
									val2.Add(current3);
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
						List<Table> val4 = new List<Table>();
						PortFunction.A(num, framework, val4, false);
						Enumerator<Table> enumerator3 = val4.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								Enumerator<DataIdAndAttrId> enumerator4 = enumerator3.Current.GetIdsContained().GetEnumerator();
								try
								{
									while (enumerator4.MoveNext())
									{
										DataIdAndAttrId current4 = enumerator4.Current;
										Setting setting = framework.A(current4);
										if (setting != null && setting.d() != 0 && Bcd[current].ContainsKey(setting.d()) && !val2.Contains(setting))
										{
											val2.Add(setting);
										}
									}
								}
								finally
								{
									((System.IDisposable)enumerator4).Dispose();
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator3).Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			return Enumerable.ToList<Setting>(Enumerable.Distinct<Setting>((System.Collections.Generic.IEnumerable<Setting>)val2));
		}

		private List<Setting> A(Framework P_0, HashSet<DataIdAndAttrId> P_1, bool P_2, bool P_3)
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			List<Setting> val = new List<Setting>();
			if (P_0.awF.ContainsKey(BCx))
			{
				DO dO = P_0.awF[BCx];
				Enumerator<DataIdAndAttrId, byte[]> enumerator = Bcc.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataIdAndAttrId current = enumerator.Current;
						if (dO.B().Contains(current.DataId))
						{
							Setting setting = P_0.A(current);
							A(val, setting, Bcc[current], P_2, P_3);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (BcD.Keys.Count != 0 || Bcd.Keys.Count != 0 || BcE.Keys.Count != 0)
				{
					Enumerator<DataIdAndAttrId> enumerator2 = P_1.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							DataIdAndAttrId current2 = enumerator2.Current;
							if (Bcc.Keys.Contains(current2))
							{
								continue;
							}
							Setting setting2 = P_0.A(current2);
							if (setting2 != null && (!setting2.am() || !P_2) && !setting2.aJ())
							{
								byte[] array = A(setting2);
								if (array != null)
								{
									A(val, setting2, array, P_2, P_3);
								}
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				A(val, dO, P_0, P_1, P_2, P_3);
			}
			return val;
		}

		private void A(List<Setting> P_0, Setting P_1, byte[] P_2, bool P_3, bool P_4)
		{
			if (P_2 != null && P_1 != null && (!P_1.am() || !P_3) && !P_1.aJ())
			{
				P_0.Add(P_1);
				if (P_4 && ((SettingOrSpecialObject)P_1).A().awX.ContainsKey(P_1.A()))
				{
					string text = A(P_1.A());
					A(P_0, P_1, text, P_3, P_2);
				}
			}
		}

		private void A(DO P_0, Framework P_1, HashSet<DataIdAndAttrId> P_2)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<int> enumerator = P_0.B().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					DataIdAndAttrId dataIdAndAttrId = new DataIdAndAttrId(current);
					if (!Bcc.ContainsKey(dataIdAndAttrId))
					{
						A(P_1, dataIdAndAttrId);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = P_0.a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current2 = enumerator.Current;
					if (!BcD.ContainsKey(current2))
					{
						a(P_1, P_2, current2);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<int, List<int>> enumerator2 = P_0.b().Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current3 = enumerator2.Current;
					enumerator = P_0.b()[current3].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current4 = enumerator.Current;
							if (!BcE.ContainsKey(current3) || !BcE[current3].ContainsKey(current4))
							{
								a(P_1, P_2, current4, current3, 0);
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
				((System.IDisposable)enumerator2).Dispose();
			}
			enumerator2 = P_0.C().Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current5 = enumerator2.Current;
					enumerator = P_0.C()[current5].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current6 = enumerator.Current;
							if (!Bcd.ContainsKey(current5) || !Bcd[current5].ContainsKey(current6))
							{
								a(P_1, P_2, current6, 0, current5);
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
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		private void A(List<Setting> P_0, DO P_1, Framework P_2, HashSet<DataIdAndAttrId> P_3, bool P_4, bool P_5)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<int> enumerator = P_1.B().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					DataIdAndAttrId dataIdAndAttrId = new DataIdAndAttrId(current);
					if (!Bcc.ContainsKey(dataIdAndAttrId))
					{
						A(P_0, P_2, dataIdAndAttrId, P_4, P_5);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = P_1.a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current2 = enumerator.Current;
					if (!BcD.ContainsKey(current2))
					{
						A(P_0, P_2, P_3, current2, P_4, P_5);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<int, List<int>> enumerator2 = P_1.b().Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current3 = enumerator2.Current;
					enumerator = P_1.b()[current3].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current4 = enumerator.Current;
							if (!BcE.ContainsKey(current3) || !BcE[current3].ContainsKey(current4))
							{
								A(P_0, P_2, P_3, current4, current3, 0);
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
				((System.IDisposable)enumerator2).Dispose();
			}
			enumerator2 = P_1.C().Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current5 = enumerator2.Current;
					enumerator = P_1.C()[current5].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current6 = enumerator.Current;
							if (!Bcd.ContainsKey(current5) || !Bcd[current5].ContainsKey(current6))
							{
								A(P_0, P_2, P_3, current6, 0, current5);
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
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		private void A(Framework P_0, DataIdAndAttrId P_1)
		{
			Setting setting = P_0.A(P_1);
			if (setting != null)
			{
				if (setting.I(true) || setting.S().Count != 0)
				{
					BM.A(setting.C());
				}
				if (P_0.awX.ContainsKey(P_1.DataId))
				{
					string text = A(P_1.DataId);
					A(setting, text);
				}
			}
		}

		private void A(List<Setting> P_0, Framework P_1, DataIdAndAttrId P_2, bool P_3, bool P_4)
		{
			Setting setting = P_1.A(P_2);
			if (setting != null)
			{
				P_0.Add(setting);
				if (P_4 && P_1.awX.ContainsKey(P_2.DataId))
				{
					byte[] array = (P_1.aWR ? setting.aW() : N.A(setting.aW(), setting.aG()));
					string text = A(P_2.DataId);
					A(P_0, setting, text, P_3, array);
				}
			}
		}

		private void a(Framework P_0, HashSet<DataIdAndAttrId> P_1, int P_2)
		{
			Setting setting = A(P_0, P_1, P_2);
			if (setting != null)
			{
				if (setting.I(true) || setting.S().Count != 0)
				{
					BM.A(setting.C());
				}
				if (P_0.awX.ContainsKey(setting.A()))
				{
					string text = A(setting.A());
					A(setting, text);
				}
			}
		}

		private void A(List<Setting> P_0, Framework P_1, HashSet<DataIdAndAttrId> P_2, int P_3, bool P_4, bool P_5)
		{
			Setting setting = A(P_1, P_2, P_3);
			if (setting != null)
			{
				P_0.Add(setting);
				if (P_5 && P_1.awX.ContainsKey(setting.A()))
				{
					byte[] array = (P_1.aWR ? setting.aW() : N.A(setting.aW(), setting.aG()));
					string text = A(setting.A());
					A(P_0, setting, text, P_4, array);
				}
			}
		}

		private void a(Framework P_0, HashSet<DataIdAndAttrId> P_1, int P_2, int P_3, int P_4)
		{
			Setting setting = A(P_0, P_1, P_2, P_3, P_4);
			if (setting != null && (setting.I(true) || setting.S().Count != 0))
			{
				BM.A(setting.C());
			}
		}

		private void A(List<Setting> P_0, Framework P_1, HashSet<DataIdAndAttrId> P_2, int P_3, int P_4, int P_5)
		{
			Setting setting = A(P_1, P_2, P_3, P_4, P_5);
			if (setting != null)
			{
				P_0.Add(setting);
			}
		}

		internal bool A(Cn P_0)
		{
			if (BCx != P_0.BCx)
			{
				return false;
			}
			if (string.IsNullOrEmpty(BCy) || string.IsNullOrEmpty(P_0.BCy) || BCy != P_0.BCy)
			{
				return false;
			}
			if (BCX != P_0.BCX)
			{
				return false;
			}
			return true;
		}

		internal bool A()
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			lock (BM.qb)
			{
				Enumerator<string, CO> enumerator = BM.qB.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CO current = enumerator.Current;
						if (current.BcF != this && A(current.BcF) && current.BcF.BCY > BCY)
						{
							return false;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			return true;
		}

		internal static Cn A(int P_0, string P_1)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			Version val = null;
			Cn result = null;
			lock (BM.qb)
			{
				Enumerator<string, CO> enumerator = BM.qB.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CO current = enumerator.Current;
						if (current.BcF.BCx == P_0 && current.BcF.BCX == P_1 && (val == (Version)null || current.BcF.BCY > val))
						{
							val = current.BcF.BCY;
							result = current.BcF;
						}
					}
					return result;
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}

		private static bool A(Setting P_0, string P_1)
		{
			lock (BM.qb)
			{
				MenuNode menuNode = ((SettingOrSpecialObject)P_0).A().awX[P_0.A()];
				if (!string.IsNullOrEmpty(P_1))
				{
					Cn cn = A(((SettingOrSpecialObject)P_0).d(), P_1);
					if (cn != null)
					{
						byte[] array = n.A(cn.BCw);
						if (P_0.A(array, true))
						{
							BM.A(P_0.C());
						}
						cn.A(menuNode);
						return true;
					}
				}
				else
				{
					string text = n.A(P_0.aY());
					if (BM.qB.ContainsKey(text))
					{
						BM.qB[text].BcF.A(menuNode);
						return true;
					}
				}
			}
			return false;
		}

		private static void A(List<Setting> P_0, Setting P_1, string P_2, bool P_3, byte[] P_4)
		{
			if (P_4.Length != P_1.BB())
			{
				return;
			}
			lock (BM.qb)
			{
				MenuNode menuNode = ((SettingOrSpecialObject)P_1).A().awX[P_1.A()];
				if (!string.IsNullOrEmpty(P_2))
				{
					Cn cn = A(((SettingOrSpecialObject)P_1).d(), P_2);
					if (cn != null)
					{
						P_0.AddRange((System.Collections.Generic.IEnumerable<Setting>)cn.A(menuNode, P_3, true));
					}
				}
				else
				{
					string text = n.A(P_4);
					if (BM.qB.ContainsKey(text))
					{
						P_0.AddRange((System.Collections.Generic.IEnumerable<Setting>)BM.qB[text].BcF.A(menuNode, P_3, true));
					}
				}
			}
		}

		internal static bool B(Setting P_0)
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			Framework framework = ((SettingOrSpecialObject)P_0).A();
			if (framework.B() && framework.b())
			{
				if (P_0.J())
				{
					return true;
				}
				if (framework.awX.ContainsKey(P_0.A()) && framework.awF.ContainsKey(((SettingOrSpecialObject)P_0).d()))
				{
					MenuNode menuNode = framework.awX[P_0.A()];
					DO dO = framework.awF[((SettingOrSpecialObject)P_0).d()];
					if (menuNode != null && dO != null)
					{
						Enumerator<Setting> enumerator = dO.A(menuNode).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.J())
								{
									return true;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
				}
			}
			return false;
		}

		internal static bool A(Framework P_0, Cn P_1)
		{
			if (!(P_1.BCZ == null) && !bx.A(P_0.awZ) && P_1.BCZ.a() > 30)
			{
				return P_0.aXA.a() >= P_1.BCZ.a();
			}
			return true;
		}

		internal static bool b(Setting P_0)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (P_0 != null)
				{
					lock (BM.qb)
					{
						Enumerator<string, CO> enumerator = BM.qB.Keys.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string current = enumerator.Current;
								Cn bcF = BM.qB[current].BcF;
								if (bcF.BCx == ((SettingOrSpecialObject)P_0).d() && A(((SettingOrSpecialObject)P_0).A(), bcF))
								{
									if (((SettingOrSpecialObject)P_0).E() == null || ((SettingOrSpecialObject)P_0).E().Count == 0)
									{
										return true;
									}
									if (A(P_0, bcF))
									{
										return true;
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avH() + ex.Message, true);
			}
			return false;
		}

		private static bool A(Setting P_0, Cn P_1)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<string, string> enumerator = ((SettingOrSpecialObject)P_0).E().Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!P_1.Bcb.ContainsKey(current))
					{
						return false;
					}
					string[] array = ((SettingOrSpecialObject)P_0).E()[current].Split(',', (StringSplitOptions)0);
					bool flag = false;
					string[] array2 = array;
					foreach (string text in array2)
					{
						if (P_1.Bcb[current] == text)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						return false;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return true;
		}

		internal static List<ValueTuple<CO, string>> A(MenuNode P_0, Setting P_1, bool P_2)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			List<ValueTuple<CO, string>> val = new List<ValueTuple<CO, string>>();
			lock (BM.qb)
			{
				Enumerator<string, CO> enumerator = BM.qB.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CO current = enumerator.Current;
						if (current.BcF.BCx == ((SettingOrSpecialObject)P_1).d())
						{
							string text = A(P_0, P_1, current.BcF);
							if (P_2 || string.IsNullOrEmpty(text))
							{
								val.Add(new ValueTuple<CO, string>(current, text));
							}
						}
					}
					return val;
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}

		internal static string A(MenuNode P_0, Setting P_1, Cn P_2)
		{
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			string text = string.Empty;
			if (!A(((SettingOrSpecialObject)P_1).A(), P_2))
			{
				text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avh() + ((object)P_2.BCZ).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avI();
			}
			if (((SettingOrSpecialObject)P_1).E() != null && ((SettingOrSpecialObject)P_1).E().Count != 0 && !A(P_1, P_2))
			{
				if (text != string.Empty)
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
				}
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avi();
			}
			if (A(((SettingOrSpecialObject)P_1).A()))
			{
				List<Setting> obj = P_2.A(P_0, false, true);
				List<Setting> val = new List<Setting>();
				Enumerator<Setting> enumerator = obj.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Setting current = enumerator.Current;
						List<Setting.ListItems.A> val2 = current.L();
						if (val2.Count == 0)
						{
							continue;
						}
						int[] array = P_2.a(current);
						if (array == null || array.Length != 1)
						{
							continue;
						}
						bool flag = false;
						for (int i = 0; i < val2.Count; i++)
						{
							if (val2[i].bBv == array[0])
							{
								flag = true;
								break;
							}
						}
						if (!flag)
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
					if (text != string.Empty)
					{
						text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
					}
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avJ();
					enumerator = val.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Setting current2 = enumerator.Current;
							text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avj() + ((SettingOrSpecialObject)current2).A(bz.aYt);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			return text;
		}

		private static bool A(Framework P_0)
		{
			if (P_0.awZ != 21 && P_0.awZ != 20 && P_0.awZ != 25)
			{
				return true;
			}
			if ((P_0.awZ == 20 || P_0.awZ == 25) && P_0.aXA >= new k(1, 27, 0, 1, 0))
			{
				return true;
			}
			if (P_0.awZ == 21 && P_0.aXA >= new k(2, 27, 0, 1, 0))
			{
				return true;
			}
			return false;
		}

		internal static string A(string P_0, string P_1)
		{
			string result = P_0;
			if (P_0 != null)
			{
				switch (P_0.Length)
				{
				case 4:
					switch (P_0[0])
					{
					case 't':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIB())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiv();
						}
						break;
					case 'm':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avK())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWB();
						}
						break;
					case 'y':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avk())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWc();
						}
						break;
					case 'h':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avL())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWg();
						}
						break;
					case 'l':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avl())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWM();
						}
						break;
					}
					break;
				case 11:
					switch (P_0[0])
					{
					case 's':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avM())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWA();
						}
						break;
					case 'p':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avm())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWd();
						}
						break;
					}
					break;
				case 6:
					switch (P_0[0])
					{
					case 'e':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avO())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWC();
						}
						break;
					case 'l':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avo())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWh();
						}
						break;
					case 's':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avP())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWN();
						}
						break;
					}
					break;
				case 10:
					switch (P_0[0])
					{
					case 'y':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avp())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWc();
						}
						break;
					case 'g':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avQ())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWe();
						}
						break;
					case 'r':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajH())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWm();
						}
						break;
					}
					break;
				case 12:
					switch (P_0[0])
					{
					case 'm':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avq())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWD();
						}
						break;
					case 'i':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avR())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWk();
						}
						break;
					case 't':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avr())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWl();
						}
						break;
					}
					break;
				case 17:
					switch (P_0[0])
					{
					case 'p':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avS())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWD();
						}
						break;
					case 'c':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avs())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWG();
						}
						break;
					case 'm':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avT())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWi();
						}
						break;
					}
					break;
				case 13:
					switch (P_0[0])
					{
					case 's':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avt())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWE();
						}
						break;
					case 't':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avU())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWK();
						}
						break;
					case 'e':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avu())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWn();
						}
						break;
					}
					break;
				case 7:
					switch (P_0[0])
					{
					case 'v':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agI())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agg();
						}
						break;
					case 't':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avV())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTB();
						}
						break;
					case 'g':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avv())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWL();
						}
						break;
					}
					break;
				case 14:
					switch (P_0[0])
					{
					case 'b':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avW())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWF();
						}
						break;
					case 'c':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avw())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aka();
						}
						break;
					}
					break;
				case 8:
					switch (P_0[0])
					{
					case 'c':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avX())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWf();
						}
						break;
					case 'd':
						if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avx())
						{
							result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JC();
						}
						break;
					}
					break;
				case 15:
					if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avN())
					{
						result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWa();
					}
					break;
				case 5:
					if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avn())
					{
						result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWb();
					}
					break;
				case 9:
					if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avY())
					{
						result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWH();
					}
					break;
				case 16:
					if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avy())
					{
						result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWI();
					}
					break;
				case 18:
					if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avZ())
					{
						result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWJ();
					}
					break;
				case 19:
					if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avz())
					{
						result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWj();
					}
					break;
				}
			}
			return result;
		}

		internal static string A(Framework P_0, MenuNode P_1, Setting P_2)
		{
			if (P_2 != null)
			{
				string text = ((SettingOrSpecialObject)P_2).A(bz.aYu);
				if (!string.IsNullOrEmpty(text) && !bx.A(P_0.awZ) && ((P_0.awZ == 21 && P_0.aXA >= new k(2, 33, 0, 3, 0)) || (P_0.awZ != 21 && P_0.aXA >= new k(1, 33, 0, 3, 0))))
				{
					return text;
				}
			}
			if (!string.IsNullOrEmpty(P_1.v()))
			{
				return P_1.v();
			}
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWO() + P_1.E();
		}
	}
}
