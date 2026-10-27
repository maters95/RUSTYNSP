using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
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
using a;
using b;

namespace c
{
	internal class cM : MovableResizablePanel
	{
		private const int BJH = 10;

		private const int BJh = 70;

		private const int BJI = 70;

		private const int BJi = 20;

		private const int BJJ = 20;

		[CompilerGenerated]
		private readonly int BJj = 116;

		[CompilerGenerated]
		private readonly int BJK = 60;

		private int BJk;

		private int BJL;

		private int BJl;

		private int BJM;

		private int BJm = -1;

		private int BJN;

		private bool BJn = true;

		private bool BJO;

		private Timer BJo = new Timer();

		private Stopwatch BJP = new Stopwatch();

		private Framework BJp;

		private List<Setting> BJQ = new List<Setting>();

		private List<int> BJq = new List<int>();

		private string BJR = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wk();

		private string BJr;

		private List<int> BJS = new List<int>();

		private List<int> BJs = new List<int>();

		private bool BJT;

		private bool BJt;

		private int BJU;

		private int BJu;

		private int BJV;

		protected override int MIN_WIDTH
		{
			[CompilerGenerated]
			get
			{
				return BJj;
			}
		}

		protected override int MIN_HEIGHT
		{
			[CompilerGenerated]
			get
			{
				return BJK;
			}
		}

		internal cM(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			BJp = P_0;
			((Control)this).ContextMenuStrip = B();
			global::A.A.A(new EventHandler(B));
			global::A.A.A((global::A.D)B);
			BM.D(new EventHandler(B));
			BM.E(new EventHandler(B));
			BM.A(new EventHandler(b));
			((Control)this).DoubleBuffered = true;
			BJo.Interval = 40.0;
			BJo.SynchronizingObject = (ISynchronizeInvoke)(object)this;
			BJo.Elapsed += new ElapsedEventHandler(A);
			BJo.AutoReset = true;
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected O, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			try
			{
				if (BJQ != null)
				{
					Enumerator<Setting> enumerator = BJQ.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Setting current = enumerator.Current;
							current.a(new EventHandler(A));
							((SettingOrSpecialObject)current).a(new EventHandler(a));
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(D);
					((ToolStripItem)item).Click -= new EventHandler(d);
					((ToolStripItem)item).Click -= new EventHandler(C);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(E);
				global::A.A.a(new EventHandler(B));
				global::A.A.a((global::A.D)B);
				BM.d(new EventHandler(B));
				BM.e(new EventHandler(B));
				BM.a(new EventHandler(b));
				BJo.Elapsed -= new ElapsedEventHandler(A);
				((Component)BJo).Dispose();
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			return string.Concat(new string[7]
			{
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY(),
				BJQ.Count.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaU(),
				((Control)this).Left.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
				((Control)this).Top.ToString()
			});
		}

		internal void a()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			BJS.Clear();
			BJs.Clear();
			BJr = string.Empty;
			Enumerator<Setting> enumerator = BJQ.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (BM.Qj.ContainsKey(current.A()))
					{
						Bl bl = BM.Qj[current.A()];
						BJS.Add(bl.Qi);
						BJs.Add(bl.QJ);
					}
					else
					{
						BJS.Add(current.aP());
						BJs.Add(current.ap());
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			((Control)this).Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected O, but got Unknown
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Expected O, but got Unknown
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_0480: Expected O, but got Unknown
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0464: Unknown result type (might be due to invalid IL or missing references)
			//IL_046b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_063c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0540: Unknown result type (might be due to invalid IL or missing references)
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_0688: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0665: Unknown result type (might be due to invalid IL or missing references)
			//IL_066a: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0739: Unknown result type (might be due to invalid IL or missing references)
			//IL_073e: Unknown result type (might be due to invalid IL or missing references)
			Stopwatch val = new Stopwatch();
			val.Start();
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = (SmoothingMode)2;
			int num = 3;
			Font val2 = new Font(((Control)this).Font.FontFamily, 12f);
			Size val3;
			try
			{
				TextRenderer.DrawText((IDeviceContext)(object)graphics, BJR, val2, new Point(3, num), BM.te);
				int num2 = num;
				val3 = TextRenderer.MeasureText(BJR, val2);
				num = num2 + (((Size)(ref val3)).Height + 2);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			BJM = num;
			Rectangle val4 = default(Rectangle);
			((Rectangle)(ref val4))._002Ector(3, num, ((Control)this).Width - 6 - 1, ((Control)this).Height - num - 3 - 1);
			Pen val5 = new Pen(Color.Black, 1f);
			try
			{
				graphics.DrawRectangle(val5, val4);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
			if (BJQ.Count == 0)
			{
				return;
			}
			List<string> val6 = new List<string>();
			List<string> val7 = new List<string>();
			Enumerator<Setting> enumerator = BJQ.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					string text = ((SettingOrSpecialObject)current).H();
					if (!string.IsNullOrWhiteSpace(text))
					{
						val6.Add(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + ((SettingOrSpecialObject)current).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
						val7.Add(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + ((SettingOrSpecialObject)current).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
					}
					else
					{
						val6.Add(((SettingOrSpecialObject)current).A(bz.aYT));
						val7.Add(((SettingOrSpecialObject)current).A(bz.aYt));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			int num3 = 0;
			Font val8 = null;
			int num4;
			int num5;
			int num6;
			if (BJk <= 0 || BJL <= 0)
			{
				bool flag = false;
				do
				{
					num3 = ((!flag) ? Math.Min(((Rectangle)(ref val4)).Height / BJQ.Count, 70) : (num3 * 95 / 100));
					if (num3 < 10)
					{
						num3 = 10;
					}
					num4 = (int)((float)num3 * 5.91f);
					num5 = (int)((float)num4 * 0.54f);
					num6 = ((Rectangle)(ref val4)).Width - 2 - num4;
					num6 = Math.Max(num6, 70);
					if (val8 != null)
					{
						val8.Dispose();
					}
					val8 = new Font(((Control)this).Font.FontFamily, (float)num3 * 0.6f);
					flag = false;
					if (num3 <= 10)
					{
						continue;
					}
					for (int i = 0; i < val6.Count; i++)
					{
						val3 = TextRenderer.MeasureText(val6[i], val8);
						if (((Size)(ref val3)).Width > num6)
						{
							flag = true;
							break;
						}
					}
				}
				while (flag);
				int num7 = ((Control)this).Width - 6 - 2 - num6;
				BJk = (int)((float)num7 * 0.65f);
				BJL = num7 - BJk;
			}
			else
			{
				num4 = BJk + BJL;
				num5 = BJL;
				num6 = Math.Max(((Rectangle)(ref val4)).Width - 2 - BJk - BJL, 70);
				bool flag2 = false;
				do
				{
					num3 = ((!flag2) ? Math.Min(((Rectangle)(ref val4)).Height / BJQ.Count, 70) : (num3 * 95 / 100));
					if (num3 < 10)
					{
						num3 = 10;
					}
					if (val8 != null)
					{
						val8.Dispose();
					}
					val8 = new Font(((Control)this).Font.FontFamily, (float)num3 * 0.6f);
					flag2 = false;
					if (num3 <= 10)
					{
						continue;
					}
					for (int j = 0; j < val6.Count; j++)
					{
						val3 = TextRenderer.MeasureText(val6[j], val8);
						if (((Size)(ref val3)).Width > num6)
						{
							flag2 = true;
							break;
						}
					}
				}
				while (flag2);
			}
			BJl = num3;
			Rectangle val10 = default(Rectangle);
			Rectangle val12 = default(Rectangle);
			for (int k = 0; k < BJQ.Count; k++)
			{
				Setting setting = BJQ[k];
				int num8 = setting.ax();
				bool num9 = ((SettingOrSpecialObject)setting).l() && PortFunction.A(setting);
				bool flag3 = (BM.A(BJp.aXc, true) && !BM.aE()) || BM.C(setting.A());
				Color val9 = BM.tI;
				((Rectangle)(ref val10))._002Ector(((Rectangle)(ref val4)).Left + 2, num + 1, num6, num3 - 2);
				if (num9)
				{
					if (flag3 && (BJS[k] != 0 || BJs[k] != 0) && (num8 < BJS[k] || num8 > BJs[k]))
					{
						graphics.FillRectangle(Brushes.Maroon, val10);
						val9 = BM.Ty;
					}
					else
					{
						SolidBrush val11 = new SolidBrush(BM.th);
						graphics.FillRectangle((Brush)(object)val11, val10);
						((Brush)val11).Dispose();
					}
				}
				else
				{
					graphics.FillRectangle(Brushes.Gray, val10);
				}
				((Rectangle)(ref val12))._002Ector(((Rectangle)(ref val4)).Left + 2, ((Rectangle)(ref val4)).Y, num6, ((Rectangle)(ref val4)).Height);
				val3 = TextRenderer.MeasureText(val7[k], val8);
				string text2 = ((((Size)(ref val3)).Width > num6) ? val6[k] : val7[k]);
				if (BJm == -1)
				{
					BJN = 0;
					BJP.Reset();
					BJr = string.Empty;
				}
				else if (k == BJm)
				{
					text2 += BJr;
					val3 = TextRenderer.MeasureText(text2, val8);
					int width = ((Size)(ref val3)).Width;
					if (width <= ((Rectangle)(ref val12)).Width)
					{
						BJN = 0;
						BJP.Reset();
					}
					else if (BJN > ((Rectangle)(ref val12)).Width - width)
					{
						if (!BJn)
						{
							if (!BJP.IsRunning)
							{
								BJP.Restart();
								BJN = 0;
							}
							else if (BJP.ElapsedMilliseconds < 500)
							{
								BJN = 0;
							}
						}
						else
						{
							BJP.Reset();
						}
						BJO = true;
					}
					else
					{
						BJN = ((Rectangle)(ref val12)).Width - width;
						if (BJO)
						{
							BJP.Restart();
							BJO = false;
						}
						else if (BJP.ElapsedMilliseconds >= 800)
						{
							BJN = 0;
							BJP.Reset();
						}
						BJn = false;
					}
				}
				int num10 = num3 / 2;
				graphics.SetClip(val12, (CombineMode)0);
				if (k == BJm)
				{
					TextRenderer.DrawText((IDeviceContext)(object)graphics, text2, val8, new Point(((Rectangle)(ref val10)).Left + BJN, num + num10), val9, (TextFormatFlags)16777220);
				}
				else
				{
					TextRenderer.DrawText((IDeviceContext)(object)graphics, text2, val8, new Point(((Rectangle)(ref val10)).Left, num + num10), val9, (TextFormatFlags)16777220);
				}
				graphics.ResetClip();
				if (num9)
				{
					int num11 = setting.aS();
					graphics.SetClip(val4, (CombineMode)0);
					bool flag4 = false;
					if (flag3)
					{
						ValueTuple<string, string, bool> val13 = setting.A(num8, -1);
						flag4 = val13.Item3;
						TextRenderer.DrawText((IDeviceContext)(object)graphics, val13.Item1, val8, new Point(((Rectangle)(ref val4)).Right - num4, num + num10), BM.te, (TextFormatFlags)16777220);
					}
					if (num11 != 0 && num11 != 82 && !flag4)
					{
						TextRenderer.DrawText((IDeviceContext)(object)graphics, bS.A(BJQ[k].@as(), num11, true, num8), val8, new Point(((Rectangle)(ref val4)).Right - num5, num + num10), BM.te, (TextFormatFlags)16777220);
					}
					graphics.ResetClip();
				}
				num += num3;
			}
			val8.Dispose();
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bau(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (base.B())
			{
				((Control)this).Invalidate();
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

		private void A(object P_0, ElapsedEventArgs P_1)
		{
			if (BJm != -1 && base.B())
			{
				BJN -= Math.Min(15, ((Control)this).Width / 50);
				((Control)this).Invalidate();
			}
		}

		protected override void MouseDownHandler(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)e.Button != 1048576)
			{
				return;
			}
			BJU = e.X;
			BJu = BJk;
			BJV = BJL;
			if (e.Y > 23 && e.Y < ((Control)this).Height - 3)
			{
				if (BJU > ((Control)this).Width - 3 - BJk - BJL - 10 && BJU < ((Control)this).Width - 3 - BJk - BJL + 10)
				{
					BJT = true;
				}
				else if (BJU > ((Control)this).Width - 3 - BJL - 10 && BJU < ((Control)this).Width - 3 - BJL + 10)
				{
					BJt = true;
				}
				else
				{
					base.MouseDownHandler(sender, e);
				}
			}
			else
			{
				base.MouseDownHandler(sender, e);
			}
		}

		protected override void MouseMoveHandler(object sender, MouseEventArgs e)
		{
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Invalid comparison between Unknown and I4
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			if (BJM != 0 && BJl != 0)
			{
				int num = -1;
				for (int i = 0; i < BJQ.Count; i++)
				{
					if (e.X <= 3 || e.X >= ((Control)this).Width - 3 || e.Y <= BJM + i * BJl || e.Y >= BJM + (i + 1) * BJl)
					{
						continue;
					}
					num = i;
					if (((SettingOrSpecialObject)BJQ[i]).D() != null)
					{
						if (PortFunction.a(((SettingOrSpecialObject)BJQ[i]).D()))
						{
							SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)BJQ[i]).D();
							Cg bSQ = settingOrSpecialObject.F().E().BSQ;
							CH bSq = settingOrSpecialObject.F().E().BSq;
							byte bSR = settingOrSpecialObject.F().E().BSR;
							ushort bSr = settingOrSpecialObject.F().E().BSr;
							List<bool> val = new List<bool>();
							List<string> val2 = PortFunction.A(BJp, bSQ, bSq, bSR, bSr, true, val);
							if (val2 != null && val2.Count == 1)
							{
								BJr = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + val2[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
							}
							else
							{
								BJr = string.Empty;
							}
						}
						else if (BJp.aWY.Contains(((SettingOrSpecialObject)BJQ[i]).D()))
						{
							Dn dn = null;
							Enumerator<SettingOrSpecialObject> enumerator = ((SettingOrSpecialObject)BJQ[i]).D().a().GetEnumerator();
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
								int num2 = dn.ax();
								Cg cg2 = PortFunction.A((uint)num2);
								CH cH2 = PortFunction.a((uint)num2);
								byte b = PortFunction.B((uint)num2);
								ushort num3 = PortFunction.b((uint)num2);
								string text = PortFunction.B(PortFunction.A(BJp, cg2, cH2, b, num3));
								if (text != null)
								{
									BJr = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
								}
								else
								{
									BJr = string.Empty;
								}
							}
							else
							{
								BJr = string.Empty;
							}
						}
						else
						{
							BJr = string.Empty;
						}
					}
					else
					{
						BJr = string.Empty;
					}
					break;
				}
				if (num == -1)
				{
					BJN = 0;
					BJP.Reset();
					BJr = string.Empty;
					BJn = true;
				}
				else if (!BJo.Enabled)
				{
					BJo.Enabled = true;
				}
				BJm = num;
			}
			if ((int)e.Button != 1048576 || (!BJT && !BJt))
			{
				base.MouseMoveHandler(sender, e);
				if (e.Y > 23 && e.Y < ((Control)this).Height - 3)
				{
					if (e.X > ((Control)this).Width - 3 - BJk - BJL - 10 && e.X < ((Control)this).Width - 3 - BJk - BJL + 10)
					{
						((Control)this).Cursor = Cursors.SizeWE;
					}
					else if (e.X > ((Control)this).Width - 3 - BJL - 10 && e.X < ((Control)this).Width - 3 - BJL + 10)
					{
						((Control)this).Cursor = Cursors.SizeWE;
					}
				}
				return;
			}
			((Control)this).BringToFront();
			int num4 = e.X - BJU;
			if (BJT)
			{
				int num5 = ((Control)this).Width - 6 - BJL - 70;
				BJk = Math.Min(num5, Math.Max(BJu - num4, 20));
			}
			else if (BJt)
			{
				int num6 = ((Control)this).Width - 6 - BJk - 70;
				BJL = Math.Min(num6, Math.Max(BJV - num4, 20));
			}
			((Control)this).Cursor = Cursors.SizeWE;
			((Control)this).Invalidate();
		}

		protected override void MouseUpHandler(object sender, MouseEventArgs e)
		{
			base.MouseUpHandler(sender, e);
			BJT = false;
			BJt = false;
		}

		protected override void MouseLeaveHandler(object sender, EventArgs e)
		{
			base.MouseLeaveHandler(sender, e);
			BJm = -1;
			BJN = 0;
			BJP.Reset();
			BJr = string.Empty;
			BJn = true;
			if (BJo.Enabled)
			{
				BJo.Enabled = false;
			}
			((Control)this).Invalidate();
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			if (((Control)this).Width - 6 - BJk - BJL < 70)
			{
				BJk = (BJL = (((Control)this).Width - 6 - 70) / 2);
				((Control)this).Invalidate();
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			((Component)this).Dispose();
			BM.QQ.rl.a(false);
		}

		private void c(object P_0, EventArgs P_1)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Invalid comparison between Unknown and I4
			BV bV = new BV();
			bV.A(BJR);
			if ((int)((Form)bV).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				BJR = bV.A();
			}
			((Component)bV).Dispose();
			((Control)this).Invalidate();
		}

		internal void D(object P_0, EventArgs P_1)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			List<int> val = new List<int>();
			Enumerator<Setting> enumerator = BJQ.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					val.Add(current.A());
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			List<int> val2 = BY.A((IWin32Window)(object)BM.QQ, BJp, val, 0);
			if (val2 != null)
			{
				enumerator = BJQ.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Setting current2 = enumerator.Current;
						current2.a(new EventHandler(A));
						((SettingOrSpecialObject)current2).a(new EventHandler(a));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				BJQ.Clear();
				BJq.Clear();
				bool flag = false;
				Enumerator<int> enumerator2 = val2.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						int current3 = enumerator2.Current;
						Setting setting = BJp.A(current3);
						if (setting != null)
						{
							BJQ.Add(setting);
							BJq.Add(current3);
							if (!flag)
							{
								setting.A(new EventHandler(A));
								flag = true;
							}
							((SettingOrSpecialObject)setting).A(new EventHandler(a));
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				a();
			}
			BM.QQ.rl.a(false);
		}

		private void d(object P_0, EventArgs P_1)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Invalid comparison between Unknown and I4
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			BL bL = new BL(BJQ, BJS, BJs);
			if ((int)((Form)bL).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				Enumerator<Setting> enumerator = BJQ.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Setting current = enumerator.Current;
						int num = BJQ.IndexOf(current);
						int num2;
						int num3;
						if (BM.Qj.ContainsKey(current.A()))
						{
							Bl bl = BM.Qj[current.A()];
							num2 = bl.Qh;
							num3 = bl.QI;
						}
						else
						{
							num2 = current.aQ();
							num3 = current.aq();
						}
						BM.A(current.A(), num2, num3, bL.a()[num], bL.B()[num]);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				a();
				BM.a();
			}
			((Component)bL).Dispose();
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
					((ToolStripItem)val).Enabled = BJQ.Count != 0;
				}
				else if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaV())
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
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ev();
			((ToolStripItem)val2).Click += new EventHandler(D);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem();
			((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((ToolStripItem)val3).Click += new EventHandler(d);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bav();
			((ToolStripItem)val4).Click += new EventHandler(c);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
			ToolStripMenuItem val5 = new ToolStripMenuItem();
			((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaV();
			((ToolStripItem)val5).Click += new EventHandler(C);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaW());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baw() + BJR);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaX() + BJk);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bax() + BJL);
			Enumerator<int> enumerator = BJq.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf() + current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Expected O, but got Unknown
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Expected O, but got Unknown
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected O, but got Unknown
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected O, but got Unknown
			bool flag = false;
			string text;
			int num2 = default(int);
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baw()))
				{
					BJR = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baw().Length);
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaY()))
				{
					string text2 = text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaY()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaY().Length);
					BJR = text2.Substring(1, text2.Length - 2);
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaX()))
				{
					BJk = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaX().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bay()))
				{
					BJk = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bay()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bay().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bax()))
				{
					BJL = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bax().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaZ()))
				{
					BJL = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaZ()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaZ().Length));
				}
				else
				{
					if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baz()))
					{
						continue;
					}
					if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf()))
					{
						int num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf().Length));
						BJq.Add(num);
						Setting setting = BJp.A(num);
						if (setting != null)
						{
							BJQ.Add(setting);
							if (!flag)
							{
								setting.A(new EventHandler(A));
								flag = true;
							}
							((SettingOrSpecialObject)setting).A(new EventHandler(a));
						}
					}
					else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()))
					{
						string text3 = text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI().Length);
						if (string.IsNullOrEmpty(text3))
						{
							continue;
						}
						string[] array = text3.Split(',', (StringSplitOptions)0);
						for (int i = 0; i < array.Length; i++)
						{
							string text4 = array[i].Trim();
							if (!int.TryParse(text4, ref num2))
							{
								string text5 = text4.Substring(1, text4.Length - 2);
								try
								{
									num2 = (int)(bs)System.Enum.Parse(typeof(bs), text5);
								}
								catch
								{
									num2 = -1;
								}
							}
							if (num2 != -1)
							{
								BJq.Add(num2);
								Setting setting2 = BJp.A(num2);
								if (setting2 != null)
								{
									BJQ.Add(setting2);
									setting2.A(new EventHandler(A));
									((SettingOrSpecialObject)setting2).A(new EventHandler(a));
								}
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
	}
	internal class cm : MovableResizablePanel
	{
		internal const int BJv = 20;

		internal const int BJW = 10;

		private const int BJw = 100;

		private const int BJX = 28;

		private const int BJx = 50;

		private const int BJY = 10;

		private const int BJy = 8;

		private const int BJZ = 10;

		private const int BJz = 30;

		internal static Color[] BjA = (Color[])(object)new Color[20];

		private Framework Bja;

		private int BjB = 5000;

		private bool Bjb;

		private double BjC;

		private double Bjc;

		private double BjD;

		private double Bjd;

		private List<Setting> BjE = new List<Setting>();

		private List<int> Bje = new List<int>();

		private Dictionary<int, int> BjF = new Dictionary<int, int>();

		private Dictionary<int, int> Bjf = new Dictionary<int, int>();

		private Dictionary<int, int> BjG = new Dictionary<int, int>();

		private List<o> Bjg = new List<o>();

		private List<int> BjH = new List<int>();

		private List<int> Bjh = new List<int>();

		private List<List<int>> BjI = new List<List<int>>();

		private List<int> Bji = new List<int>();

		private List<Timer> BjJ = new List<Timer>();

		private List<int> Bjj = new List<int>();

		private List<int> BjK = new List<int>();

		private int Bjk;

		private bool BjL = true;

		private bool Bjl;

		private bool BjM;

		private bool Bjm;

		private int BjN;

		private int Bjn;

		private int BjO;

		internal cm(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			Bja = P_0;
			((Control)this).ContextMenuStrip = b();
			global::A.A.A(new EventHandler(a));
			global::A.A.A((global::A.D)a);
			BM.D(new EventHandler(a));
			BM.E(new EventHandler(a));
			BM.A(new EventHandler(B));
			((Control)this).DoubleBuffered = true;
			BjA[0] = Color.Red;
			BjA[1] = Color.SkyBlue;
			BjA[2] = Color.LightGreen;
			BjA[3] = Color.Yellow;
			BjA[4] = Color.PeachPuff;
			BjA[5] = Color.LightCoral;
			BjA[6] = Color.PaleTurquoise;
			BjA[7] = Color.White;
			BjA[8] = Color.Orange;
			BjA[9] = Color.Pink;
			BjA[10] = Color.Red;
			BjA[11] = Color.SkyBlue;
			BjA[12] = Color.LightGreen;
			BjA[13] = Color.Yellow;
			BjA[14] = Color.PeachPuff;
			BjA[15] = Color.LightCoral;
			BjA[16] = Color.PaleTurquoise;
			BjA[17] = Color.White;
			BjA[18] = Color.Orange;
			BjA[19] = Color.Pink;
			a();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			try
			{
				Enumerator<Setting> enumerator = BjE.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.a(new EventHandler(A));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(D);
					((ToolStripItem)item).Click -= new EventHandler(C);
					((ToolStripItem)item).Click -= new EventHandler(b);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(d);
				global::A.A.a(new EventHandler(a));
				global::A.A.a((global::A.D)a);
				BM.d(new EventHandler(a));
				BM.e(new EventHandler(a));
				BM.a(new EventHandler(B));
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			return string.Concat(new string[7]
			{
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY(),
				BjE.Count.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaU(),
				((Control)this).Left.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
				((Control)this).Top.ToString()
			});
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Expected O, but got Unknown
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_060d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0614: Expected O, but got Unknown
			//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0606: Expected O, but got Unknown
			//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0619: Unknown result type (might be due to invalid IL or missing references)
			//IL_061e: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_0887: Unknown result type (might be due to invalid IL or missing references)
			//IL_088c: Unknown result type (might be due to invalid IL or missing references)
			//IL_088f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0891: Unknown result type (might be due to invalid IL or missing references)
			//IL_089b: Expected O, but got Unknown
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Expected O, but got Unknown
			//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b9: Expected O, but got Unknown
			//IL_089f: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ab: Expected O, but got Unknown
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f9: Expected O, but got Unknown
			//IL_0941: Unknown result type (might be due to invalid IL or missing references)
			//IL_0946: Unknown result type (might be due to invalid IL or missing references)
			//IL_0949: Unknown result type (might be due to invalid IL or missing references)
			//IL_0952: Unknown result type (might be due to invalid IL or missing references)
			//IL_0957: Unknown result type (might be due to invalid IL or missing references)
			//IL_0702: Unknown result type (might be due to invalid IL or missing references)
			//IL_0707: Unknown result type (might be due to invalid IL or missing references)
			//IL_06be: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0989: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Expected O, but got Unknown
			//IL_0865: Unknown result type (might be due to invalid IL or missing references)
			//IL_0867: Unknown result type (might be due to invalid IL or missing references)
			//IL_086e: Expected O, but got Unknown
			//IL_0871: Unknown result type (might be due to invalid IL or missing references)
			//IL_077d: Unknown result type (might be due to invalid IL or missing references)
			//IL_077f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0784: Unknown result type (might be due to invalid IL or missing references)
			//IL_078e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0795: Expected O, but got Unknown
			//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b9: Expected O, but got Unknown
			//IL_0798: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0835: Unknown result type (might be due to invalid IL or missing references)
			//IL_0837: Unknown result type (might be due to invalid IL or missing references)
			//IL_083c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0846: Unknown result type (might be due to invalid IL or missing references)
			//IL_084d: Expected O, but got Unknown
			//IL_0850: Unknown result type (might be due to invalid IL or missing references)
			//IL_056b: Unknown result type (might be due to invalid IL or missing references)
			//IL_056d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_0576: Unknown result type (might be due to invalid IL or missing references)
			//IL_0578: Unknown result type (might be due to invalid IL or missing references)
			//IL_0582: Unknown result type (might be due to invalid IL or missing references)
			//IL_0589: Expected O, but got Unknown
			//IL_058c: Unknown result type (might be due to invalid IL or missing references)
			Stopwatch val = new Stopwatch();
			val.Start();
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = (SmoothingMode)0;
			int num = 10;
			int num2 = ((Control)this).Height - 10 - 1;
			int num3 = num2 - num;
			int num4 = 10;
			int num5 = ((Control)this).Width - 10 - 1;
			int num6 = num5 - num4;
			int num7 = num + 8;
			int num8 = num2 - 28;
			int num9 = num8 - num7;
			int num10 = num5 - 60 - num4;
			graphics.FillRectangle(Brushes.Black, num4, num, num6, num3);
			Pen val2 = new Pen(Color.Gray, 1f);
			try
			{
				graphics.DrawRectangle(val2, num4, num, num6, num3);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			Pen val3 = new Pen(Color.White, 1f);
			try
			{
				graphics.DrawLine(val3, num5 - 60, num, num5 - 60, num2);
				graphics.DrawLine(val3, num5 - 10, num, num5 - 10, num2);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
			if (Bjk < BjE.Count && BjG.ContainsKey(BjE[Bjk].A()))
			{
				Font val4 = new Font(((Control)this).Font.FontFamily, 8f);
				try
				{
					SolidBrush val5 = new SolidBrush(BjA[BjG[BjE[Bjk].A()]]);
					try
					{
						Pen val6 = new Pen(Color.DimGray, 1f);
						try
						{
							val6.DashStyle = (DashStyle)2;
							for (int i = 0; i < Bjg[Bjk].F().Length; i++)
							{
								float num11 = Bjg[Bjk].e()[i];
								int num12 = (int)Bjg[Bjk].F()[i];
								if (num12 >= num + 1)
								{
									graphics.SmoothingMode = (SmoothingMode)3;
									graphics.DrawLine(val6, num4, num12, num5 - 60 + 4, num12);
									graphics.SmoothingMode = (SmoothingMode)2;
								}
								if (num12 - 6 >= num + 1)
								{
									graphics.DrawString(num11.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAQ()), val4, (Brush)(object)val5, (float)(num5 - 60 + 7), (float)(num12 - 6));
								}
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
				if (!Bjb)
				{
					try
					{
						A(out var num13, out var num14);
						int num15 = num5 - 10 + 2;
						int num16 = num5 - 2;
						SolidBrush val7 = new SolidBrush(BjA[BjG[BjE[Bjk].A()]]);
						try
						{
							graphics.FillRectangle((Brush)(object)val7, num15, num13, num16 - num15, num14 - num13);
						}
						finally
						{
							((System.IDisposable)val7)?.Dispose();
						}
						graphics.DrawLine(Pens.Black, num15, num13 + 10, num16, num13 + 10);
						graphics.DrawLine(Pens.Black, num15, num14 - 10, num16, num14 - 10);
						graphics.DrawLine(Pens.Gray, num5 - 10, num + 10, num5, num + 10);
						graphics.DrawLine(Pens.Gray, num5 - 10, num2 - 10, num5, num2 - 10);
					}
					catch
					{
					}
				}
			}
			if (BjE.Count == 0)
			{
				return;
			}
			int num17 = num10 / BjE.Count;
			Rectangle val9 = default(Rectangle);
			Rectangle val10 = default(Rectangle);
			Rectangle val16 = default(Rectangle);
			for (int j = 0; j < BjE.Count; j++)
			{
				if (num17 <= 0)
				{
					continue;
				}
				int num18 = num4 + 1 + j * num17;
				Setting setting = BjE[j];
				Color val8 = BjA[BjG[setting.A()]];
				if (setting == null)
				{
					continue;
				}
				int num19 = setting.ax();
				long num20 = 0L;
				bool flag = ((SettingOrSpecialObject)setting).l() && PortFunction.A(setting);
				bool flag2 = BM.aE();
				int num21 = 0;
				int num22 = 0;
				int num23;
				if (Bjb)
				{
					num21 = bS.A(BjC, setting.aS());
					num22 = bS.A(Bjc, setting.aS());
					num23 = num22 - num21;
				}
				else
				{
					num23 = Bjf[setting.A()] - BjF[setting.A()];
				}
				if (flag && BjK[j] >= 0 && num23 != 0 && ((BM.A(Bja.aXc, true) && !flag2) || (BM.C(setting.A()) && aC.gF != 0)) && BjI[j].Count >= 30 && BjB > 0)
				{
					int num24 = Bji[j];
					long num25 = ((!Bjb) ? (num8 - num9 * ((long)num24 - (long)BjF[setting.A()]) / num23) : (num8 - num9 * ((long)num24 - (long)num21) / num23));
					int num26 = 10;
					if (num25 + 10 <= num8 && num25 >= num)
					{
						((Rectangle)(ref val9))._002Ector(num18, (int)num25, num17, num26);
						((Rectangle)(ref val10))._002Ector(num18, (int)num25, num17, num26 + 1);
						if (((Rectangle)(ref val9)).Height > 0)
						{
							Color val11 = Color.FromArgb(BjK[j], val8);
							try
							{
								LinearGradientBrush val12 = new LinearGradientBrush(val10, val11, Color.Black, 90f);
								try
								{
									graphics.FillRectangle((Brush)(object)val12, val9);
								}
								finally
								{
									((System.IDisposable)val12)?.Dispose();
								}
							}
							catch
							{
							}
						}
					}
				}
				string text = ((SettingOrSpecialObject)setting).H();
				string text2 = (string.IsNullOrWhiteSpace(text) ? ((SettingOrSpecialObject)setting).A(bz.aYT) : (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + ((SettingOrSpecialObject)setting).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()));
				Font val13 = new Font(((Control)this).Font.FontFamily, 8f);
				SolidBrush val14 = ((!flag) ? new SolidBrush(Color.White) : new SolidBrush(Color.White));
				SizeF val15 = graphics.MeasureString(text2, val13);
				graphics.TranslateTransform((float)num18, (float)num8);
				graphics.RotateTransform(-90f);
				graphics.DrawString(text2, val13, (Brush)(object)val14, 0f, 0f);
				graphics.ResetTransform();
				((Brush)val14).Dispose();
				((Rectangle)(ref val16))._002Ector(0, 0, 0, 0);
				if (flag && num23 != 0 && ((BM.A(Bja.aXc, true) && !flag2) || BM.C(setting.A())))
				{
					if (Bjb)
					{
						num20 = num8 - num9 * ((long)num19 - (long)num21) / num23;
						if (num19 > num22)
						{
							val8 = BM.tc;
						}
					}
					else
					{
						num20 = num8 - num9 * ((long)num19 - (long)BjF[setting.A()]) / num23;
						if (num19 > Bjf[setting.A()])
						{
							val8 = BM.tc;
						}
					}
					if (num20 < num)
					{
						num20 = num;
					}
					((Rectangle)(ref val16))._002Ector(num18, (int)num20, num17, num8 - (int)num20);
					if (((Rectangle)(ref val16)).Height > 0)
					{
						if (Bjb)
						{
							int num27 = bS.A(BjD, setting.aS());
							int num28 = bS.A(Bjd, setting.aS());
							if ((num27 != 0 || num28 != 0) && (num19 < num27 || num19 > num28))
							{
								LinearGradientBrush val17 = new LinearGradientBrush(val16, Color.Red, Color.Pink, 180f);
								try
								{
									graphics.FillRectangle((Brush)(object)val17, val16);
								}
								finally
								{
									((System.IDisposable)val17)?.Dispose();
								}
							}
							else
							{
								SolidBrush val18 = new SolidBrush(val8);
								try
								{
									graphics.FillRectangle((Brush)(object)val18, val16);
								}
								finally
								{
									((System.IDisposable)val18)?.Dispose();
								}
							}
						}
						else if (BjH.Count > j && Bjh.Count > j && (BjH[j] != 0 || Bjh[j] != 0) && (num19 < BjH[j] || num19 > Bjh[j]))
						{
							LinearGradientBrush val19 = new LinearGradientBrush(val16, Color.Red, Color.Pink, 180f);
							try
							{
								graphics.FillRectangle((Brush)(object)val19, val16);
							}
							finally
							{
								((System.IDisposable)val19)?.Dispose();
							}
						}
						else
						{
							SolidBrush val20 = new SolidBrush(val8);
							try
							{
								graphics.FillRectangle((Brush)(object)val20, val16);
							}
							finally
							{
								((System.IDisposable)val20)?.Dispose();
							}
						}
					}
				}
				RectangleF clipBounds = graphics.ClipBounds;
				graphics.Clip = new Region(val16);
				SolidBrush val21 = ((!flag) ? new SolidBrush(Color.Gray) : new SolidBrush(Color.Black));
				graphics.TranslateTransform((float)num18, (float)num8);
				graphics.RotateTransform(-90f);
				graphics.DrawString(text2, val13, (Brush)(object)val21, 0f, 0f);
				graphics.ResetTransform();
				graphics.Clip = new Region(clipBounds);
				int num29 = num8 - (int)((SizeF)(ref val15)).Width;
				if (BjL && flag && ((BM.A(Bja.aXc, true) && !BM.aE()) || BM.C(setting.A())))
				{
					ValueTuple<string, string, bool> val22 = setting.A(num19, -1);
					SizeF val23 = graphics.MeasureString(val22.Item1, val13);
					int num30 = (int)num20 + (int)((SizeF)(ref val23)).Width + 2;
					if (num29 + 3 > num30)
					{
						graphics.TranslateTransform((float)num18, (float)num30);
						graphics.RotateTransform(-90f);
						graphics.DrawString(val22.Item1, val13, (Brush)(object)val21, 0f, 0f);
						graphics.ResetTransform();
					}
				}
				((Brush)val21).Dispose();
				val13.Dispose();
			}
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBA(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
		}

		private void A(out int P_0, out int P_1)
		{
			if (Bjb)
			{
				P_0 = 0;
				P_1 = 0;
				return;
			}
			int num = 10;
			int num2 = ((Control)this).Height - 10 - 1;
			int num3 = num2 - num - 20;
			if (BjE.Count == 0)
			{
				P_0 = num2 - 10 - num3;
				P_1 = num2 - 10;
				return;
			}
			Setting setting = BjE[Bjk];
			int num4 = setting.aR();
			int num5 = setting.ar();
			if (num4 == 0 && num5 == 0)
			{
				num5 = 100;
			}
			int num6 = num5 - num4;
			if (num6 == 0)
			{
				P_0 = num2 - 10 - num3;
				P_1 = num2 - 10;
			}
			else
			{
				P_0 = (int)((long)num2 - 10L - ((long)Bjf[setting.A()] - (long)num4) * num3 / num6);
				P_1 = (int)((long)num2 - 10L - ((long)BjF[setting.A()] - (long)num4) * num3 / num6);
			}
		}

		protected override void MouseDownHandler(object sender, MouseEventArgs e)
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Invalid comparison between Unknown and I4
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			if (BjE.Count != 0)
			{
				int num = ((Control)this).Width - 10 - 1;
				int num2 = 10;
				int num3 = ((Control)this).Height - 10 - 1;
				A(out var num4, out var num5);
				Rectangle val = default(Rectangle);
				((Rectangle)(ref val))._002Ector(num - 10, num2, 10, num3 - num2);
				if (((Rectangle)(ref val)).Contains(e.Location))
				{
					BjN = e.Y;
					Bjn = num4;
					BjO = num5;
					if (!Bjb && BjN > num2 && BjN < num3)
					{
						if (BjN < num2 + 10 || BjN > num3 - 10)
						{
							Setting setting = BjE[Bjk];
							int num6 = setting.aR();
							int num7 = setting.ar();
							if (num6 == 0 && num7 == 0)
							{
								num7 = 100;
							}
							BjF[setting.A()] = num6;
							Bjf[setting.A()] = num7;
							Bjg[Bjk].A((float)num6);
							Bjg[Bjk].a((float)num7);
							Bjg[Bjk].H();
							((Control)this).Invalidate();
							return;
						}
						if (BjN > num4 && BjN < num4 + 10)
						{
							BjM = true;
							return;
						}
						if (BjN > num4 + 10 && BjN < num5 - 10)
						{
							Bjl = true;
							return;
						}
						if (BjN > num5 - 10 && BjN < num5)
						{
							Bjm = true;
							return;
						}
					}
				}
				else
				{
					if ((int)e.Button != 1048576)
					{
						return;
					}
					int num8 = 10;
					int num9 = num2 + 8;
					int num10 = num3 - 28 - num9;
					int num11 = (num - 60 - num8) / BjE.Count;
					Rectangle val2 = default(Rectangle);
					for (int i = 0; i < BjE.Count; i++)
					{
						int num12 = num8 + i * num11;
						((Rectangle)(ref val2))._002Ector(num12, num9, num11, num10);
						if (((Rectangle)(ref val2)).Contains(e.Location))
						{
							Bjk = i;
							((Control)this).Invalidate();
						}
					}
				}
			}
			base.MouseDownHandler(sender, e);
		}

		protected override void MouseMoveHandler(object sender, MouseEventArgs e)
		{
			if (!Bjb && (Bjl || BjM || Bjm))
			{
				int num = 10;
				int num2 = ((Control)this).Height - 10 - 1;
				Setting setting = BjE[Bjk];
				int num3 = setting.aR();
				int num4 = setting.ar();
				if (num3 == 0 && num4 == 0)
				{
					num4 = 100;
				}
				int num5 = num4 - num3;
				int num6 = num2 - num - 20;
				if (Bjl)
				{
					int num7 = e.Y - BjN;
					int num8 = BjO - Bjn;
					int num9 = Bjn + num7;
					int num10 = BjO + num7;
					if (num9 < num + 10)
					{
						num9 = num + 10;
						num10 = num9 + num8;
					}
					else if (num10 > num2 - 10)
					{
						num10 = num2 - 10;
						num9 = num10 - num8;
					}
					BjF[setting.A()] = Math.Max(num3, num3 + (num2 - 10 - num10) * num5 / num6);
					Bjf[setting.A()] = Math.Min(num4, num3 + (num2 - 10 - num9) * num5 / num6);
				}
				else if (BjM)
				{
					A(out var _, out var num12);
					Bjf[setting.A()] = Math.Min(num4, num3 + (num6 - (Math.Min(e.Y, num12 - 20) - (num + 10))) * num5 / num6);
				}
				else if (Bjm)
				{
					A(out var num13, out var _);
					BjF[setting.A()] = Math.Max(num3, num3 + (num6 - (Math.Max(e.Y, num13 + 20) - (num + 10))) * num5 / num6);
				}
				Bjg[Bjk].A((float)BjF[setting.A()]);
				Bjg[Bjk].a((float)Bjf[setting.A()]);
				Bjg[Bjk].H();
				((Control)this).Invalidate();
			}
			else
			{
				base.MouseMoveHandler(sender, e);
			}
		}

		protected override void MouseUpHandler(object sender, MouseEventArgs e)
		{
			base.MouseUpHandler(sender, e);
			Bjl = false;
			BjM = false;
			Bjm = false;
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			if (BjF.Count != 0 && Bjf.Count != 0)
			{
				int num = 10;
				int num2 = ((Control)this).Height - 10 - 1;
				int num3 = num + 8;
				int num4 = num2 - 28;
				for (int i = 0; i < BjE.Count; i++)
				{
					Bjg[i].B((float)num4);
					Bjg[i].b((float)num3);
					Bjg[i].H();
				}
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			Setting setting = P_0 as Setting;
			int num = BjE.IndexOf(setting);
			if (setting == null || num == -1 || setting == null || !((SettingOrSpecialObject)setting).l() || !PortFunction.A(setting))
			{
				return;
			}
			bool flag = BM.aE();
			if ((BM.A(Bja.aXc, true) && !flag) || (BM.C(setting.A()) && aC.gF != 0))
			{
				try
				{
					int num2 = setting.ax();
					if (BjI[num].Count >= 30)
					{
						int num3 = 30 - BjI[num].Count;
						for (int i = 0; i < num3 + 1; i++)
						{
							BjI[num].RemoveAt(i);
						}
					}
					BjI[num].Add(num2);
					if (BjI[num].Count >= 30)
					{
						Enumerator<int> enumerator = BjI[num].GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								_ = enumerator.Current;
								if (num2 > Bji[num])
								{
									Bji[num] = num2;
									Bjj[num] = 0;
									BjK[num] = 255;
									BjJ[num].Enabled = true;
									BjJ[num].Start();
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
				}
				catch
				{
				}
			}
			else
			{
				B();
			}
			((Control)this).Invalidate();
		}

		private void a(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		private void a()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			BjH.Clear();
			Bjh.Clear();
			Enumerator<Setting> enumerator = BjE.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (BM.Qj.ContainsKey(current.A()))
					{
						Bl bl = BM.Qj[current.A()];
						BjH.Add(bl.Qi);
						Bjh.Add(bl.QJ);
					}
					else
					{
						BjH.Add(current.aP());
						Bjh.Add(current.ap());
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			a();
			((Control)this).Invalidate();
		}

		private void b(object P_0, EventArgs P_1)
		{
			((Component)this).Dispose();
			BM.QQ.rl.a(false);
		}

		private void C(object P_0, EventArgs P_1)
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Invalid comparison between Unknown and I4
			BO bO = new BO(BjE, Bjb, BjC, Bjc, BjD, Bjd, BjF, Bjf, BjH, Bjh, BjG, BjB / 1000);
			if ((int)((Form)bO).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				BjG = bO.d();
				BjB = bO.F() * 1000;
				Bjb = bO.A();
				if (Bjb)
				{
					BjC = bO.a();
					Bjc = bO.B();
					BjD = bO.b();
					Bjd = bO.C();
				}
				else
				{
					BjF = bO.c();
					Bjf = bO.D();
				}
				for (int i = 0; i < BjE.Count; i++)
				{
					if (Bjb)
					{
						int num = BjE[i].aS();
						int num2 = bS.A(BjC, num);
						int num3 = bS.A(Bjc, num);
						Bjg[i].A((float)num2);
						Bjg[i].a((float)num3);
						Bjg[i].H();
					}
					else
					{
						Setting setting = BjE[i];
						BM.A(setting.A(), bO.c()[setting.A()], bO.D()[setting.A()], bO.E()[i], bO.e()[i]);
						Bjg[i].A((float)BjF[setting.A()]);
						Bjg[i].a((float)Bjf[setting.A()]);
						Bjg[i].H();
					}
				}
				if (!Bjb)
				{
					BjH = bO.E();
					Bjh = bO.e();
				}
				B();
				((Control)this).Invalidate();
				BM.a();
			}
			((Component)bO).Dispose();
		}

		private new void B()
		{
			for (int i = 0; i < BjE.Count; i++)
			{
				Bjj[i] = 0;
				BjK[i] = 0;
				Bji[i] = -2147483648;
				BjJ[i].Stop();
				BjJ[i].Enabled = false;
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			Timer val = (Timer)((P_0 is Timer) ? P_0 : null);
			int num = BjJ.IndexOf(val);
			if (num == -1)
			{
				return;
			}
			List<int> bjj = Bjj;
			int num2 = num;
			bjj[num2] += (int)val.Interval;
			if (Bjj[num] >= BjB * 2)
			{
				Bjj[num] = 0;
				Bji[num] = 0;
				BjK[num] = 0;
				val.Stop();
				val.Enabled = false;
			}
			else
			{
				int num3 = Bjj[num] - BjB;
				if (num3 >= 0)
				{
					BjK[num] = 255 - (int)(255.0 * ((double)num3 / (double)BjB));
				}
				else
				{
					BjK[num] = 255;
				}
			}
		}

		internal void D(object P_0, EventArgs P_1)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Expected O, but got Unknown
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Expected O, but got Unknown
			//IL_0322: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a6: Expected O, but got Unknown
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Expected O, but got Unknown
			//IL_0416: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Expected O, but got Unknown
			//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
			Dictionary<int, int> val = new Dictionary<int, int>();
			Enumerator<int, int> enumerator = BjF.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> current = enumerator.Current;
					val.Add(current.Key, current.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Dictionary<int, int> val2 = new Dictionary<int, int>();
			enumerator = Bjf.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> current2 = enumerator.Current;
					val2.Add(current2.Key, current2.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			List<int> val3 = new List<int>();
			Enumerator<int> enumerator2 = BjH.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current3 = enumerator2.Current;
					val3.Add(current3);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			List<int> val4 = new List<int>();
			enumerator2 = Bjh.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current4 = enumerator2.Current;
					val4.Add(current4);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			List<o> val5 = new List<o>();
			Enumerator<o> enumerator3 = Bjg.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					o current5 = enumerator3.Current;
					val5.Add(current5);
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			List<int> val6 = new List<int>();
			Enumerator<Setting> enumerator4 = BjE.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					Setting current6 = enumerator4.Current;
					val6.Add(current6.A());
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			Dictionary<int, int> val7 = new Dictionary<int, int>();
			enumerator = BjG.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> current7 = enumerator.Current;
					val7.Add(current7.Key, current7.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			List<int> val8 = BY.A((IWin32Window)(object)BM.QQ, Bja, val6, 20);
			if (val8 != null)
			{
				enumerator4 = BjE.GetEnumerator();
				try
				{
					while (enumerator4.MoveNext())
					{
						enumerator4.Current.a(new EventHandler(A));
					}
				}
				finally
				{
					((System.IDisposable)enumerator4).Dispose();
				}
				Enumerator<Timer> enumerator5 = BjJ.GetEnumerator();
				try
				{
					while (enumerator5.MoveNext())
					{
						enumerator5.Current.Elapsed -= new ElapsedEventHandler(c);
					}
				}
				finally
				{
					((System.IDisposable)enumerator5).Dispose();
				}
				BjE.Clear();
				Bje.Clear();
				BjF.Clear();
				Bjf.Clear();
				BjH.Clear();
				Bjh.Clear();
				Bjg.Clear();
				BjG.Clear();
				BjI.Clear();
				Bji.Clear();
				Bjj.Clear();
				BjJ.Clear();
				BjK.Clear();
				if (val8.Count != 0)
				{
					enumerator2 = val8.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							int current8 = enumerator2.Current;
							Setting setting = Bja.A(current8);
							if (setting == null)
							{
								continue;
							}
							BjE.Add(setting);
							Bje.Add(current8);
							BjI.Add(new List<int>());
							Bji.Add(-2147483648);
							Bjj.Add(0);
							BjK.Add(0);
							Timer val9 = new Timer();
							val9.Interval = 100.0;
							val9.Elapsed += new ElapsedEventHandler(c);
							BjJ.Add(val9);
							string text = ((SettingOrSpecialObject)setting).H();
							if (!string.IsNullOrWhiteSpace(text))
							{
								_ = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + ((SettingOrSpecialObject)setting).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
							}
							else
							{
								((SettingOrSpecialObject)setting).A(bz.aYT);
							}
							setting.A(new EventHandler(A));
							int num = val6.IndexOf(current8);
							if (num == -1)
							{
								int num2;
								int num3;
								int num4;
								int num5;
								if (BM.Qj.ContainsKey(setting.A()))
								{
									Bl bl = BM.Qj[setting.A()];
									num2 = bl.Qh;
									num3 = bl.QI;
									num4 = bl.Qi;
									num5 = bl.QJ;
								}
								else
								{
									num2 = setting.aQ();
									num3 = setting.aq();
									num4 = setting.aP();
									num5 = setting.ap();
								}
								BjF.Add(setting.A(), num2);
								Bjf.Add(setting.A(), num3);
								BjH.Add(num4);
								Bjh.Add(num5);
								int num6 = 10;
								int num7 = ((Control)this).Height - 10 - 1;
								int num8 = num6 + 8;
								int num9 = num7 - 28;
								o o = new o();
								o.A(setting.aS());
								if (Bjb)
								{
									int num10 = setting.aS();
									int num11 = bS.A(BjC, num10);
									int num12 = bS.A(Bjc, num10);
									o.A((float)num11);
									o.a((float)num12);
								}
								else
								{
									o.A((float)num2);
									o.a((float)num3);
								}
								o.B((float)num9);
								o.b((float)num8);
								o.C(15f);
								o.c(20f);
								o.H();
								Bjg.Add(o);
								for (int i = 0; i < BjA.Length; i++)
								{
									bool flag = false;
									Enumerator<int, int> enumerator6 = BjG.Values.GetEnumerator();
									try
									{
										while (enumerator6.MoveNext())
										{
											if (enumerator6.Current == i)
											{
												flag = true;
												break;
											}
										}
									}
									finally
									{
										((System.IDisposable)enumerator6).Dispose();
									}
									if (!flag)
									{
										BjG.Add(setting.A(), i);
										break;
									}
								}
							}
							else
							{
								BjG.Add(setting.A(), val7[setting.A()]);
								BjF.Add(setting.A(), val[setting.A()]);
								Bjf.Add(setting.A(), val2[setting.A()]);
								BjH.Add(val3[num]);
								Bjh.Add(val4[num]);
								Bjg.Add(val5[num]);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
					Bjk = Math.Min(Bjk, BjE.Count - 1);
				}
				else
				{
					Bjk = 0;
				}
				B();
				((Control)this).Invalidate();
			}
			BM.QQ.rl.a(false);
		}

		private void d(object P_0, EventArgs P_1)
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
					((ToolStripItem)val).Enabled = BjE.Count != 0;
				}
				else if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBa())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
				}
			}
		}

		private new ContextMenuStrip b()
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
			((ToolStripDropDown)val).Opened += new EventHandler(d);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ev();
			((ToolStripItem)val2).Click += new EventHandler(D);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem();
			((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((ToolStripItem)val3).Click += new EventHandler(C);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBa();
			((ToolStripItem)val4).Click += new EventHandler(b);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBB());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBb() + BjB);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBC() + Bjb);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBc() + BjC);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBD() + Bjc);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBd() + BjD);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBE() + Bjd);
			if (Bje.Count == BjF.Count && Bje.Count == Bjf.Count && Bje.Count == BjG.Count)
			{
				for (int i = 0; i < Bje.Count; i++)
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf() + Bje[i]);
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag() + BjF[Bje[i]]);
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH() + Bjf[Bje[i]]);
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBe() + BjG[Bje[i]]);
				}
			}
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Unknown result type (might be due to invalid IL or missing references)
			string text;
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf()))
				{
					int num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf().Length));
					Bje.Add(num);
					Setting setting = Bja.A(num);
					if (setting != null)
					{
						BjE.Add(setting);
						BjI.Add(new List<int>());
						Bji.Add(-2147483648);
						Bjj.Add(0);
						BjK.Add(0);
						Timer val = new Timer();
						val.Interval = 100.0;
						val.Elapsed += new ElapsedEventHandler(c);
						BjJ.Add(val);
						setting.A(new EventHandler(A));
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag()))
				{
					int num2 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag().Length));
					BjF.Add(Bje[Bje.Count - 1], num2);
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH()))
				{
					int num3 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH().Length));
					Bjf.Add(Bje[Bje.Count - 1], num3);
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBe()))
				{
					int num4 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBe().Length));
					BjG.Add(Bje[Bje.Count - 1], num4);
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBC()))
				{
					Bjb = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBC().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBc()))
				{
					BjC = double.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBc().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBD()))
				{
					Bjc = double.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBD().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBd()))
				{
					BjD = double.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBd().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBE()))
				{
					Bjd = double.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBE().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBb()))
				{
					BjB = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBb().Length));
				}
				else if (string.IsNullOrWhiteSpace(text))
				{
					break;
				}
			}
			a();
			Bjg.Clear();
			if (BjF.Count != 0 && Bjf.Count != 0)
			{
				int num5 = 10;
				int num6 = ((Control)this).Height - 10 - 1;
				int num7 = num5 + 8;
				int num8 = num6 - 28;
				Enumerator<Setting> enumerator = BjE.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Setting current = enumerator.Current;
						o o = new o();
						o.A(current.aS());
						if (Bjb)
						{
							int num9 = o.A();
							int num10 = bS.A(BjC, num9);
							int num11 = bS.A(Bjc, num9);
							o.A((float)num10);
							o.a((float)num11);
						}
						else
						{
							o.A((float)BjF[current.A()]);
							o.a((float)Bjf[current.A()]);
						}
						o.B((float)num8);
						o.b((float)num7);
						o.C(15f);
						o.c(20f);
						o.H();
						Bjg.Add(o);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			((Control)this).Invalidate();
		}
	}
}
namespace C
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class CM
	{
		private static ResourceManager BCN;

		private static CultureInfo BCn;

		[EditorBrowsable(/*Could not decode attribute arguments.*/)]
		internal static ResourceManager bbn
		{
			get
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				if (BCN == null)
				{
					BCN = new ResourceManager("C.CM", typeof(CM).Assembly);
				}
				return BCN;
			}
		}

		[EditorBrowsable(/*Could not decode attribute arguments.*/)]
		internal static CultureInfo bbO
		{
			get
			{
				return BCn;
			}
			set
			{
				BCn = value;
			}
		}

		internal CM()
		{
		}

		[SpecialName]
		internal static Bitmap B()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbn.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVR(), BCn);
		}

		[SpecialName]
		internal static Bitmap b()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbn.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVr(), BCn);
		}

		[SpecialName]
		internal static Bitmap C()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbn.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVS(), BCn);
		}
	}
	internal class Cm
	{
		internal enum A
		{
			BsO,
			Bso
		}

		private Stopwatch BCp = new Stopwatch();

		internal MemoryStream BCQ;

		internal string BCq = string.Empty;

		private ZipArchive BCR;

		private ZipArchiveEntry BCr;

		private Stream BCS;

		private object BCs = new object();

		private List<Setting> BCT = new List<Setting>();

		internal List<string> BCt = new List<string>();

		private string BCU;

		private string BCu;

		private A BCV;

		private int BCv;

		internal Cm(A P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			BCV = P_0;
			if (P_0 == Cm.A.Bso)
			{
				BCv = 2048;
				BCu = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVv();
				BCU = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVW();
			}
			else
			{
				BCv = 1024;
				BCu = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SK();
				BCU = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVw();
			}
		}

		internal void A()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0582: Unknown result type (might be due to invalid IL or missing references)
			//IL_0587: Unknown result type (might be due to invalid IL or missing references)
			string text = this.b();
			a();
			string text2 = BCU + N.A(false);
			string text3 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
			if (File.Exists(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + text3))
			{
				text2 = BCU + N.A(true);
				text3 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
			}
			try
			{
				BCQ = new MemoryStream();
				BCq = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + text3;
				BCR = new ZipArchive((Stream)(object)BCQ, (ZipArchiveMode)1);
				Stream val = BCR.CreateEntry(text2 + bx.a(BM.Qz.awZ, BM.Qz.awz, BM.Qz.aXA) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()).Open();
				string text4 = string.Concat(new string[6]
				{
					BM.Qq,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa(),
					BM.Qy,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(),
					BCU,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVX()
				});
				new CR(text4, BM.Qz, true).A();
				byte[] array = File.ReadAllBytes(text4);
				foreach (byte b in array)
				{
					val.WriteByte(b);
				}
				File.Delete(text4);
				val.Close();
				BCr = BCR.CreateEntry(text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK());
				BCS = BCr.Open();
				BCS.WriteByte((byte)1);
				uint num = 73u;
				BCS.WriteByte((byte)((num >> 24) & 0xFFu));
				BCS.WriteByte((byte)((num >> 16) & 0xFFu));
				BCS.WriteByte((byte)((num >> 8) & 0xFFu));
				BCS.WriteByte((byte)(num & 0xFFu));
				BCS.WriteByte((byte)72);
				BCS.WriteByte((byte)65);
				BCS.WriteByte((byte)76);
				BCS.WriteByte((byte)84);
				BCS.WriteByte((byte)69);
				BCS.WriteByte((byte)67);
				BCS.WriteByte((byte)72);
				BCS.WriteByte((byte)49);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				if (!string.IsNullOrEmpty(BM.Qz.aXc) && BM.Qz.aXc.Length <= 32)
				{
					for (int j = 0; j < BM.Qz.aXc.Length; j++)
					{
						BCS.WriteByte((byte)BM.Qz.aXc[j]);
					}
					for (int k = BM.Qz.aXc.Length; k < 32; k++)
					{
						BCS.WriteByte((byte)0);
					}
				}
				else
				{
					for (int l = 0; l < 32; l++)
					{
						BCS.WriteByte((byte)0);
					}
				}
				System.DateTime now = System.DateTime.Now;
				BCS.WriteByte((byte)now.Hour);
				BCS.WriteByte((byte)now.Minute);
				BCS.WriteByte((byte)now.Second);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)((uint)(now.Year >> 8) & 0xFFu));
				BCS.WriteByte((byte)((uint)now.Year & 0xFFu));
				BCS.WriteByte((byte)now.Month);
				BCS.WriteByte((byte)now.Day);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)0);
				BCS.WriteByte((byte)6);
				BCT.Clear();
				Enumerator<Setting> enumerator = BM.Qz.aWt.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Setting current = enumerator.Current;
						if (((SettingOrSpecialObject)current).l() && current.aC() && !current.al() && PortFunction.A(current))
						{
							BCT.Add(current);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				uint num2 = (uint)(5 + 2 * BCT.Count);
				BCS.WriteByte((byte)((num2 >> 24) & 0xFFu));
				BCS.WriteByte((byte)((num2 >> 16) & 0xFFu));
				BCS.WriteByte((byte)((num2 >> 8) & 0xFFu));
				BCS.WriteByte((byte)(num2 & 0xFFu));
				List<ushort> val2 = new List<ushort>();
				enumerator = BCT.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ushort num3 = (ushort)enumerator.Current.A();
						BCS.WriteByte((byte)((uint)(num3 >> 8) & 0xFFu));
						BCS.WriteByte((byte)(num3 & 0xFFu));
						val2.Add(num3);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				List<List<ushort>> val3 = new List<List<ushort>>();
				val3.Add(val2);
				A(BCS, val3);
				if (!BCp.IsRunning)
				{
					BCp.Start();
				}
				else
				{
					BCp.Restart();
				}
				lock (BM.qh)
				{
					BM.qI |= BCv;
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVx() + ex.Message, true);
			}
		}

		internal void a()
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			if ((BM.qI & BCv) != 0)
			{
				lock (BM.qh)
				{
					BM.qI &= ~BCv;
				}
				BackgroundWorker val = new BackgroundWorker();
				val.DoWork += new DoWorkEventHandler(A);
				val.RunWorkerAsync();
			}
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			if (BCQ == null || BCS == null)
			{
				return;
			}
			Thread.Sleep(500);
			try
			{
				BCS.Close();
			}
			catch
			{
			}
			BCS = null;
			try
			{
				BCR.Dispose();
			}
			catch
			{
			}
			BCR = null;
			BCT.Clear();
			try
			{
				FileStream val = new FileStream(BCq, (FileMode)2);
				try
				{
					S.A(BCQ.ToArray(), M.B(), (Stream)(object)val, S.Dj);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				((Stream)BCQ).Close();
				((Stream)BCQ).Dispose();
			}
			catch
			{
			}
			BCQ = null;
			BCt.Add(BCq);
			int num = BCq.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + BCu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()) + (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + BCu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()).Length;
			if (num == (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + BCu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()).Length - 1)
			{
				num = BCq.IndexOf(BM.Qy) + BM.Qy.Length;
			}
			if (num != BM.Qy.Length - 1)
			{
				string text = BCq.Substring(0, num);
				string text2 = BCq.Substring(num, BCq.Length - num - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej().Length);
				Be.a(text, text2, null, -1);
			}
			BCq = string.Empty;
		}

		internal static void A(Stream P_0, List<List<ushort>> P_1)
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			bool flag = P_1.Count > 16;
			for (int i = 0; i < P_1.Count; i++)
			{
				if (P_1[i].Count == 0)
				{
					continue;
				}
				uint num = 0u;
				uint num2 = 0u;
				if (flag)
				{
					P_0.WriteByte((byte)13);
				}
				else
				{
					P_0.WriteByte((byte)(9u | (byte)(16 * i)));
				}
				num2++;
				do
				{
					Enumerator<ushort> enumerator = P_1[i].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ushort current = enumerator.Current;
							Setting setting = BM.Qz.A((int)current);
							if (num != 0)
							{
								ushort num3 = 0;
								if (setting != null)
								{
									num3 = (ushort)setting.aS();
								}
								P_0.WriteByte((byte)((uint)(num3 >> 8) & 0xFFu));
								P_0.WriteByte((byte)(num3 & 0xFFu));
							}
							else
							{
								num2 += 2;
							}
							if (num != 0)
							{
								sbyte b = 0;
								if (setting != null)
								{
									b = (sbyte)setting.@as();
								}
								P_0.WriteByte((byte)b);
							}
							else
							{
								num2++;
							}
							if (num != 0)
							{
								int num4 = 0;
								int num5 = 0;
								if (setting != null && setting.aJ())
								{
									num4 = setting.aQ();
									num5 = setting.aq();
								}
								P_0.WriteByte((byte)((uint)(num4 >> 24) & 0xFFu));
								P_0.WriteByte((byte)((uint)(num4 >> 16) & 0xFFu));
								P_0.WriteByte((byte)((uint)(num4 >> 8) & 0xFFu));
								P_0.WriteByte((byte)((uint)num4 & 0xFFu));
								P_0.WriteByte((byte)((uint)(num5 >> 24) & 0xFFu));
								P_0.WriteByte((byte)((uint)(num5 >> 16) & 0xFFu));
								P_0.WriteByte((byte)((uint)(num5 >> 8) & 0xFFu));
								P_0.WriteByte((byte)((uint)num5 & 0xFFu));
							}
							else
							{
								num2 += 8;
							}
							string text = ((setting == null) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fB() : ((SettingOrSpecialObject)setting).A(bz.aYT));
							if (num != 0)
							{
								for (int j = 0; j < text.Length; j++)
								{
									P_0.WriteByte((byte)text[j]);
								}
								P_0.WriteByte((byte)0);
							}
							else
							{
								num2 += (uint)(text.Length + 1);
							}
							string text2 = ((setting == null) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fa() : ((SettingOrSpecialObject)setting).A(true));
							if (num != 0)
							{
								for (int k = 0; k < text2.Length; k++)
								{
									P_0.WriteByte((byte)text2[k]);
								}
								P_0.WriteByte((byte)0);
							}
							else
							{
								num2 += (uint)(text2.Length + 1);
							}
							string text3 = ((setting == null) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT() : ((SettingOrSpecialObject)setting).A(bz.aYU));
							if (num != 0)
							{
								for (int l = 0; l < text3.Length; l++)
								{
									P_0.WriteByte((byte)text3[l]);
								}
								P_0.WriteByte((byte)0);
							}
							else
							{
								num2 += (uint)(text3.Length + 1);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					if (num == 0)
					{
						if (flag)
						{
							num2 += 2;
						}
						num2 += 4;
						P_0.WriteByte((byte)((num2 >> 24) & 0xFFu));
						P_0.WriteByte((byte)((num2 >> 16) & 0xFFu));
						P_0.WriteByte((byte)((num2 >> 8) & 0xFFu));
						P_0.WriteByte((byte)(num2 & 0xFFu));
						if (flag)
						{
							P_0.WriteByte((byte)((uint)((ushort)i >> 8) & 0xFFu));
							P_0.WriteByte((byte)((ushort)i & 0xFFu));
						}
					}
					num++;
				}
				while (num < 2);
			}
		}

		internal void B()
		{
			if (BCT.Count == 0)
			{
				return;
			}
			lock (BCs)
			{
				if (BCQ == null || BCS == null)
				{
					return;
				}
				BCS.WriteByte((byte)7);
				uint num = (uint)(9 + 4 * BCT.Count);
				BCS.WriteByte((byte)((num >> 24) & 0xFFu));
				BCS.WriteByte((byte)((num >> 16) & 0xFFu));
				BCS.WriteByte((byte)((num >> 8) & 0xFFu));
				BCS.WriteByte((byte)(num & 0xFFu));
				uint num2 = (uint)(BCp.ElapsedMilliseconds & 0xFFFFFFFFu);
				BCS.WriteByte((byte)((num2 >> 24) & 0xFFu));
				BCS.WriteByte((byte)((num2 >> 16) & 0xFFu));
				BCS.WriteByte((byte)((num2 >> 8) & 0xFFu));
				BCS.WriteByte((byte)(num2 & 0xFFu));
				bool flag = BM.A(BM.Qz.aXc, true);
				byte[] array = new byte[BCT.Count * 4];
				int num3 = 0;
				for (int i = 0; i < BCT.Count; i++)
				{
					if (flag)
					{
						Setting setting = BCT[i];
						if (BM.Qz.aWR)
						{
							for (int j = 0; j < 4; j++)
							{
								array[num3] = setting.l(j);
								num3++;
							}
							continue;
						}
						for (int num4 = 3; num4 >= 0; num4--)
						{
							array[num3] = setting.l(num4);
							num3++;
						}
					}
					else
					{
						for (int k = 0; k < 4; k++)
						{
							array[num3] = 0;
							num3++;
						}
					}
				}
				BCS.Write(array, 0, array.Length);
			}
		}

		internal void A(uint[,] P_0, ushort P_1)
		{
			lock (BCs)
			{
				if (BCQ == null || BCS == null)
				{
					return;
				}
				BCS.WriteByte((byte)10);
				uint num = 16011u;
				BCS.WriteByte((byte)((num >> 24) & 0xFFu));
				BCS.WriteByte((byte)((num >> 16) & 0xFFu));
				BCS.WriteByte((byte)((num >> 8) & 0xFFu));
				BCS.WriteByte((byte)(num & 0xFFu));
				uint num2 = (uint)(BCp.ElapsedMilliseconds & 0xFFFFFFFFu);
				BCS.WriteByte((byte)((num2 >> 24) & 0xFFu));
				BCS.WriteByte((byte)((num2 >> 16) & 0xFFu));
				BCS.WriteByte((byte)((num2 >> 8) & 0xFFu));
				BCS.WriteByte((byte)(num2 & 0xFFu));
				BCS.WriteByte((byte)((uint)(P_1 >> 8) & 0xFFu));
				BCS.WriteByte((byte)(P_1 & 0xFFu));
				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 1000; j++)
					{
						BCS.WriteByte((byte)((P_0[i, j] >> 24) & 0xFFu));
						BCS.WriteByte((byte)((P_0[i, j] >> 16) & 0xFFu));
						BCS.WriteByte((byte)((P_0[i, j] >> 8) & 0xFFu));
						BCS.WriteByte((byte)(P_0[i, j] & 0xFFu));
					}
				}
			}
		}

		private string b()
		{
			string empty = string.Empty;
			if (BM.Qz.A(ref empty))
			{
				string text = BM.A(empty, BM.Qz.aXc);
				if (string.IsNullOrEmpty(text))
				{
					try
					{
						string text2 = empty;
						List<string> obj = new List<string>();
						obj.Add(BM.Qz.aXc);
						text = BM.a(text2, obj);
						BM.Qz.aXD = text;
						string text3 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + BCu;
						if (!Directory.Exists(text3))
						{
							Directory.CreateDirectory(text3);
						}
						return text3;
					}
					catch
					{
						return BM.Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + BM.Qy;
					}
				}
				string text4 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + BCu;
				if (!Directory.Exists(text4))
				{
					Directory.CreateDirectory(text4);
				}
				return text4;
			}
			return BM.Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + BM.Qy;
		}

		internal void C()
		{
			if (BCV == Cm.A.BsO)
			{
				return;
			}
			string text = BM.Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + BM.Qy;
			string[] array = null;
			try
			{
				array = Directory.GetFiles(text, BCU + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVY(), (SearchOption)1);
			}
			catch
			{
				return;
			}
			if (array == null)
			{
				return;
			}
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (File.GetLastWriteTimeUtc(text2).AddDays((double)Be.nV) < System.DateTime.UtcNow && File.Exists(text2))
				{
					try
					{
						File.Delete(text2);
					}
					catch
					{
					}
				}
			}
		}
	}
}
