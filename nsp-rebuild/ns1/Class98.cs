using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns4;
using ns5;
using ns7;

namespace ns1;

internal class Class98 : MovableResizablePanel
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

	internal static Color[] BjA = new Color[20];

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

	private List<Class26> Bjg = new List<Class26>();

	private List<int> BjH = new List<int>();

	private List<int> Bjh = new List<int>();

	private List<List<int>> BjI = new List<List<int>>();

	private List<int> Bji = new List<int>();

	private List<System.Timers.Timer> BjJ = new List<System.Timers.Timer>();

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

	internal Class98(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		Bja = framework_0;
		ContextMenuStrip = method_23();
		Class1.smethod_10(method_14);
		Class1.smethod_12(method_14);
		Form23.smethod_30(method_14);
		Form23.smethod_78(method_14);
		Form23.smethod_0(method_16);
		DoubleBuffered = true;
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
		method_15();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			foreach (Setting item in BjE)
			{
				item.method_265(method_13);
			}
			foreach (ToolStripMenuItem item2 in ContextMenuStrip.Items)
			{
				item2.Click -= method_21;
				item2.Click -= method_18;
				item2.Click -= method_17;
			}
			ContextMenuStrip.Opened -= method_22;
			Class1.smethod_11(method_14);
			Class1.smethod_13(method_14);
			Form23.smethod_31(method_14);
			Form23.smethod_79(method_14);
			Form23.smethod_1(method_16);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		return text + Class333.aMY() + BjE.Count + Class333.BaU() + Left + Class333.BAz() + Top;
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		base.OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.Graphics;
		graphics.SmoothingMode = SmoothingMode.Default;
		int num = 10;
		int num2 = Height - 10 - 1;
		int height = num2 - 10;
		int num3 = 10;
		int num4 = Width - 10 - 1;
		int width = num4 - 10;
		int num5 = num2 - 28;
		int num6 = num5 - 18;
		int num7 = num4 - 60 - 10;
		graphics.FillRectangle(Brushes.Black, 10, 10, width, height);
		using (Pen pen = new Pen(Color.Gray, 1f))
		{
			graphics.DrawRectangle(pen, num3, num, width, height);
		}
		using (Pen pen2 = new Pen(Color.White, 1f))
		{
			graphics.DrawLine(pen2, num4 - 60, num, num4 - 60, num2);
			graphics.DrawLine(pen2, num4 - 10, num, num4 - 10, num2);
		}
		if (Bjk < BjE.Count && BjG.ContainsKey(BjE[Bjk].method_64()))
		{
			using (Font font = new Font(Font.FontFamily, 8f))
			{
				using SolidBrush brush = new SolidBrush(BjA[BjG[BjE[Bjk].method_64()]]);
				using Pen pen3 = new Pen(Color.DimGray, 1f);
				pen3.DashStyle = DashStyle.Dot;
				for (int i = 0; i < Bjg[Bjk].method_22().Length; i++)
				{
					float num8 = Bjg[Bjk].method_21()[i];
					int num9 = (int)Bjg[Bjk].method_22()[i];
					if (num9 >= num + 1)
					{
						graphics.SmoothingMode = SmoothingMode.None;
						graphics.DrawLine(pen3, num3, num9, num4 - 60 + 4, num9);
						graphics.SmoothingMode = SmoothingMode.HighQuality;
					}
					if (num9 - 6 >= num + 1)
					{
						graphics.DrawString(num8.ToString(Class333.BAQ()), font, brush, num4 - 60 + 7, num9 - 6);
					}
				}
			}
			if (!Bjb)
			{
				try
				{
					method_12(out var int_, out var int_2);
					int num10 = num4 - 10 + 2;
					int num11 = num4 - 2;
					using (SolidBrush brush2 = new SolidBrush(BjA[BjG[BjE[Bjk].method_64()]]))
					{
						graphics.FillRectangle(brush2, num10, int_, num11 - num10, int_2 - int_);
					}
					graphics.DrawLine(Pens.Black, num10, int_ + 10, num11, int_ + 10);
					graphics.DrawLine(Pens.Black, num10, int_2 - 10, num11, int_2 - 10);
					graphics.DrawLine(Pens.Gray, num4 - 10, num + 10, num4, num + 10);
					graphics.DrawLine(Pens.Gray, num4 - 10, num2 - 10, num4, num2 - 10);
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
		int num12 = num7 / BjE.Count;
		for (int j = 0; j < BjE.Count; j++)
		{
			if (num12 <= 0)
			{
				continue;
			}
			int num13 = num3 + 1 + j * num12;
			Setting setting = BjE[j];
			Color color = BjA[BjG[setting.method_64()]];
			if (setting == null)
			{
				continue;
			}
			int num14 = setting.method_256();
			long num15 = 0L;
			bool flag = setting.method_35() && PortFunction.smethod_52(setting);
			bool flag2 = Form23.smethod_80();
			int num16 = 0;
			int num17 = 0;
			int num18;
			if (Bjb)
			{
				num16 = Class233.smethod_26(BjC, setting.method_231());
				num17 = Class233.smethod_26(Bjc, setting.method_231());
				num18 = num17 - num16;
			}
			else
			{
				num18 = Bjf[setting.method_64()] - BjF[setting.method_64()];
			}
			if (flag && BjK[j] >= 0 && num18 != 0 && ((Form23.smethod_28(Bja.aXc, bool_53: true) && !flag2) || (Form23.smethod_84(setting.method_64()) && Control3.enum34_0 != Control3.Enum34.BLV)) && BjI[j].Count >= 30 && BjB > 0)
			{
				int num19 = Bji[j];
				long num20 = ((!Bjb) ? (num5 - num6 * ((long)num19 - (long)BjF[setting.method_64()]) / num18) : (num5 - num6 * ((long)num19 - (long)num16) / num18));
				int num21 = 10;
				if (num20 + 10L <= num5 && num20 >= num)
				{
					Rectangle rect = new Rectangle(num13, (int)num20, num12, num21);
					Rectangle rect2 = new Rectangle(num13, (int)num20, num12, num21 + 1);
					if (rect.Height > 0)
					{
						Color color2 = Color.FromArgb(BjK[j], color);
						try
						{
							using LinearGradientBrush brush3 = new LinearGradientBrush(rect2, color2, Color.Black, 90f);
							graphics.FillRectangle(brush3, rect);
						}
						catch
						{
						}
					}
				}
			}
			string text = setting.method_18();
			string text2 = (string.IsNullOrWhiteSpace(text) ? setting.method_60(Enum96.aYT) : (text + Class333.smethod_497() + setting.method_60(Enum96.aYT) + Class333.smethod_9()));
			Font font2 = new Font(Font.FontFamily, 8f);
			SolidBrush solidBrush = ((!flag) ? new SolidBrush(Color.White) : new SolidBrush(Color.White));
			SizeF sizeF = graphics.MeasureString(text2, font2);
			graphics.TranslateTransform(num13, num5);
			graphics.RotateTransform(-90f);
			graphics.DrawString(text2, font2, solidBrush, 0f, 0f);
			graphics.ResetTransform();
			solidBrush.Dispose();
			Rectangle rect3 = new Rectangle(0, 0, 0, 0);
			if (flag && num18 != 0 && ((Form23.smethod_28(Bja.aXc, bool_53: true) && !flag2) || Form23.smethod_84(setting.method_64())))
			{
				if (Bjb)
				{
					num15 = num5 - num6 * ((long)num14 - (long)num16) / num18;
					if (num14 > num17)
					{
						color = Form23.color_8;
					}
				}
				else
				{
					num15 = num5 - num6 * ((long)num14 - (long)BjF[setting.method_64()]) / num18;
					if (num14 > Bjf[setting.method_64()])
					{
						color = Form23.color_8;
					}
				}
				if (num15 < num)
				{
					num15 = num;
				}
				rect3 = new Rectangle(num13, (int)num15, num12, num5 - (int)num15);
				if (rect3.Height > 0)
				{
					if (Bjb)
					{
						int num22 = Class233.smethod_26(BjD, setting.method_231());
						int num23 = Class233.smethod_26(Bjd, setting.method_231());
						if ((num22 == 0 && num23 == 0) || (num14 >= num22 && num14 <= num23))
						{
							using SolidBrush brush4 = new SolidBrush(color);
							graphics.FillRectangle(brush4, rect3);
						}
						else
						{
							using LinearGradientBrush brush5 = new LinearGradientBrush(rect3, Color.Red, Color.Pink, 180f);
							graphics.FillRectangle(brush5, rect3);
						}
					}
					else if (BjH.Count > j && Bjh.Count > j && (BjH[j] != 0 || Bjh[j] != 0) && (num14 < BjH[j] || num14 > Bjh[j]))
					{
						using LinearGradientBrush brush6 = new LinearGradientBrush(rect3, Color.Red, Color.Pink, 180f);
						graphics.FillRectangle(brush6, rect3);
					}
					else
					{
						using SolidBrush brush7 = new SolidBrush(color);
						graphics.FillRectangle(brush7, rect3);
					}
				}
			}
			RectangleF clipBounds = graphics.ClipBounds;
			graphics.Clip = new Region(rect3);
			SolidBrush solidBrush2 = ((!flag) ? new SolidBrush(Color.Gray) : new SolidBrush(Color.Black));
			graphics.TranslateTransform(num13, num5);
			graphics.RotateTransform(-90f);
			graphics.DrawString(text2, font2, solidBrush2, 0f, 0f);
			graphics.ResetTransform();
			graphics.Clip = new Region(clipBounds);
			int num24 = num5 - (int)sizeF.Width;
			if ((BjL & flag) && ((Form23.smethod_28(Bja.aXc, bool_53: true) && !Form23.smethod_80()) || Form23.smethod_84(setting.method_64())))
			{
				(string, string, bool) tuple = setting.method_253(num14);
				int num25 = (int)num15 + (int)graphics.MeasureString(tuple.Item1, font2).Width + 2;
				if (num24 + 3 > num25)
				{
					graphics.TranslateTransform(num13, num25);
					graphics.RotateTransform(-90f);
					graphics.DrawString(tuple.Item1, font2, solidBrush2, 0f, 0f);
					graphics.ResetTransform();
				}
			}
			solidBrush2.Dispose();
			font2.Dispose();
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.BBA(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
	}

	private void method_12(out int int_3, out int int_4)
	{
		if (Bjb)
		{
			int_3 = 0;
			int_4 = 0;
			return;
		}
		int num = Height - 10 - 1;
		int num2 = num - 10 - 20;
		if (BjE.Count == 0)
		{
			int_3 = num - 10 - num2;
			int_4 = num - 10;
			return;
		}
		Setting setting = BjE[Bjk];
		int num3 = setting.method_228();
		int num4 = setting.method_229();
		if (num3 == 0 && num4 == 0)
		{
			num4 = 100;
		}
		int num5 = num4 - num3;
		if (num5 == 0)
		{
			int_3 = num - 10 - num2;
			int_4 = num - 10;
		}
		else
		{
			int_3 = (int)(num - 10L - ((long)Bjf[setting.method_64()] - (long)num3) * num2 / num5);
			int_4 = (int)(num - 10L - ((long)BjF[setting.method_64()] - (long)num3) * num2 / num5);
		}
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		if (BjE.Count != 0)
		{
			int num = Width - 10 - 1;
			int num2 = 10;
			int num3 = Height - 10 - 1;
			method_12(out var int_, out var int_2);
			if (new Rectangle(num - 10, 10, 10, num3 - 10).Contains(e.Location))
			{
				BjN = e.Y;
				Bjn = int_;
				BjO = int_2;
				if (!Bjb && BjN > num2 && BjN < num3)
				{
					if (BjN < num2 + 10 || BjN > num3 - 10)
					{
						Setting setting = BjE[Bjk];
						int num4 = setting.method_228();
						int num5 = setting.method_229();
						if (num4 == 0 && num5 == 0)
						{
							num5 = 100;
						}
						BjF[setting.method_64()] = num4;
						Bjf[setting.method_64()] = num5;
						Bjg[Bjk].method_7(num4);
						Bjg[Bjk].method_9(num5);
						Bjg[Bjk].method_27();
						Invalidate();
						return;
					}
					if (BjN > int_ && BjN < int_ + 10)
					{
						BjM = true;
						return;
					}
					if (BjN > int_ + 10 && BjN < int_2 - 10)
					{
						Bjl = true;
						return;
					}
					if (BjN > int_2 - 10 && BjN < int_2)
					{
						Bjm = true;
						return;
					}
				}
			}
			else
			{
				if (e.Button != MouseButtons.Left)
				{
					return;
				}
				int num6 = 10;
				int num7 = num2 + 8;
				int height = num3 - 28 - num7;
				int num8 = (num - 60 - 10) / BjE.Count;
				for (int i = 0; i < BjE.Count; i++)
				{
					int x = num6 + i * num8;
					if (new Rectangle(x, num7, num8, height).Contains(e.Location))
					{
						Bjk = i;
						Invalidate();
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
			int num2 = Height - 10 - 1;
			Setting setting = BjE[Bjk];
			int num3 = setting.method_228();
			int num4 = setting.method_229();
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
				BjF[setting.method_64()] = Math.Max(num3, num3 + (num2 - 10 - num10) * num5 / num6);
				Bjf[setting.method_64()] = Math.Min(num4, num3 + (num2 - 10 - num9) * num5 / num6);
			}
			else if (BjM)
			{
				method_12(out var _, out var int_2);
				Bjf[setting.method_64()] = Math.Min(num4, num3 + (num6 - (Math.Min(e.Y, int_2 - 20) - (num + 10))) * num5 / num6);
			}
			else if (Bjm)
			{
				method_12(out var int_3, out var _);
				BjF[setting.method_64()] = Math.Max(num3, num3 + (num6 - (Math.Max(e.Y, int_3 + 20) - (num + 10))) * num5 / num6);
			}
			Bjg[Bjk].method_7(BjF[setting.method_64()]);
			Bjg[Bjk].method_9(Bjf[setting.method_64()]);
			Bjg[Bjk].method_27();
			Invalidate();
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
			int num = Height - 10 - 1;
			int num2 = 18;
			int num3 = num - 28;
			for (int i = 0; i < BjE.Count; i++)
			{
				Bjg[i].method_11(num3);
				Bjg[i].method_13(num2);
				Bjg[i].method_27();
			}
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		Setting setting = sender as Setting;
		int num = BjE.IndexOf(setting);
		if (setting == null || num == -1 || setting == null || !setting.method_35() || !PortFunction.smethod_52(setting))
		{
			return;
		}
		bool flag = Form23.smethod_80();
		if ((Form23.smethod_28(Bja.aXc, bool_53: true) && !flag) || (Form23.smethod_84(setting.method_64()) && Control3.enum34_0 != Control3.Enum34.BLV))
		{
			try
			{
				int num2 = setting.method_256();
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
					foreach (int item in BjI[num])
					{
						_ = item;
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
			}
			catch
			{
			}
		}
		else
		{
			method_19();
		}
		Invalidate();
	}

	private void method_14(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void method_15()
	{
		BjH.Clear();
		Bjh.Clear();
		foreach (Setting item in BjE)
		{
			if (Form23.dictionary_0.ContainsKey(item.method_64()))
			{
				Class209 @class = Form23.dictionary_0[item.method_64()];
				BjH.Add(@class.int_3);
				Bjh.Add(@class.int_4);
			}
			else
			{
				BjH.Add(item.method_224());
				Bjh.Add(item.method_225());
			}
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		method_15();
		Invalidate();
	}

	private void method_17(object sender, EventArgs e)
	{
		Dispose();
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_18(object sender, EventArgs e)
	{
		Form25 form = new Form25(BjE, Bjb, BjC, Bjc, BjD, Bjd, BjF, Bjf, BjH, Bjh, BjG, BjB / 1000);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			BjG = form.method_8();
			BjB = form.method_11() * 1000;
			Bjb = form.method_1();
			if (Bjb)
			{
				BjC = form.method_2();
				Bjc = form.method_3();
				BjD = form.method_4();
				Bjd = form.method_5();
			}
			else
			{
				BjF = form.method_6();
				Bjf = form.method_7();
			}
			for (int i = 0; i < BjE.Count; i++)
			{
				if (Bjb)
				{
					int num = BjE[i].method_231();
					int num2 = Class233.smethod_26(BjC, num);
					int num3 = Class233.smethod_26(Bjc, num);
					Bjg[i].method_7(num2);
					Bjg[i].method_9(num3);
					Bjg[i].method_27();
				}
				else
				{
					Setting setting = BjE[i];
					Form23.smethod_4(setting.method_64(), form.method_6()[setting.method_64()], form.method_7()[setting.method_64()], form.method_9()[i], form.method_10()[i]);
					Bjg[i].method_7(BjF[setting.method_64()]);
					Bjg[i].method_9(Bjf[setting.method_64()]);
					Bjg[i].method_27();
				}
			}
			if (!Bjb)
			{
				BjH = form.method_9();
				Bjh = form.method_10();
			}
			method_19();
			Invalidate();
			Form23.smethod_3();
		}
		form.Dispose();
	}

	private void method_19()
	{
		for (int i = 0; i < BjE.Count; i++)
		{
			Bjj[i] = 0;
			BjK[i] = 0;
			Bji[i] = int.MinValue;
			BjJ[i].Stop();
			BjJ[i].Enabled = false;
		}
	}

	private void method_20(object sender, EventArgs e)
	{
		System.Timers.Timer timer = sender as System.Timers.Timer;
		int num = BjJ.IndexOf(timer);
		if (num == -1)
		{
			return;
		}
		Bjj[num] += (int)timer.Interval;
		if (Bjj[num] >= BjB * 2)
		{
			Bjj[num] = 0;
			Bji[num] = 0;
			BjK[num] = 0;
			timer.Stop();
			timer.Enabled = false;
		}
		else
		{
			int num2 = Bjj[num] - BjB;
			if (num2 >= 0)
			{
				BjK[num] = 255 - (int)(255.0 * ((double)num2 / (double)BjB));
			}
			else
			{
				BjK[num] = 255;
			}
		}
	}

	internal void method_21(object sender, EventArgs e)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> item3 in BjF)
		{
			dictionary.Add(item3.Key, item3.Value);
		}
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> item4 in Bjf)
		{
			dictionary2.Add(item4.Key, item4.Value);
		}
		List<int> list = new List<int>();
		foreach (int item5 in BjH)
		{
			list.Add(item5);
		}
		List<int> list2 = new List<int>();
		foreach (int item6 in Bjh)
		{
			list2.Add(item6);
		}
		List<Class26> list3 = new List<Class26>();
		foreach (Class26 item7 in Bjg)
		{
			list3.Add(item7);
		}
		List<int> list4 = new List<int>();
		foreach (Setting item8 in BjE)
		{
			list4.Add(item8.method_64());
		}
		Dictionary<int, int> dictionary3 = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> item9 in BjG)
		{
			dictionary3.Add(item9.Key, item9.Value);
		}
		List<int> list5 = Form45.smethod_0(Form23.form23_0, Bja, list4, 20);
		if (list5 != null)
		{
			foreach (Setting item10 in BjE)
			{
				item10.method_265(method_13);
			}
			foreach (System.Timers.Timer item11 in BjJ)
			{
				item11.Elapsed -= method_20;
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
			if (list5.Count != 0)
			{
				foreach (int item12 in list5)
				{
					Setting setting = Bja.method_31(item12);
					if (setting == null)
					{
						continue;
					}
					BjE.Add(setting);
					Bje.Add(item12);
					BjI.Add(new List<int>());
					Bji.Add(int.MinValue);
					Bjj.Add(0);
					BjK.Add(0);
					System.Timers.Timer timer = new System.Timers.Timer();
					timer.Interval = 100.0;
					timer.Elapsed += method_20;
					BjJ.Add(timer);
					string text = setting.method_18();
					if (!string.IsNullOrWhiteSpace(text))
					{
						_ = text + Class333.smethod_497() + setting.method_60(Enum96.aYT) + Class333.smethod_9();
					}
					else
					{
						setting.method_60(Enum96.aYT);
					}
					setting.method_264(method_13);
					int num = list4.IndexOf(item12);
					if (num == -1)
					{
						int num2;
						int num3;
						int item;
						int item2;
						if (Form23.dictionary_0.ContainsKey(setting.method_64()))
						{
							Class209 @class = Form23.dictionary_0[setting.method_64()];
							num2 = @class.int_1;
							num3 = @class.int_2;
							item = @class.int_3;
							item2 = @class.int_4;
						}
						else
						{
							num2 = setting.method_226();
							num3 = setting.method_227();
							item = setting.method_224();
							item2 = setting.method_225();
						}
						BjF.Add(setting.method_64(), num2);
						Bjf.Add(setting.method_64(), num3);
						BjH.Add(item);
						Bjh.Add(item2);
						int num4 = Height - 10 - 1;
						int num5 = 18;
						int num6 = num4 - 28;
						Class26 class2 = new Class26();
						class2.method_5(setting.method_231());
						if (Bjb)
						{
							int num7 = setting.method_231();
							int num8 = Class233.smethod_26(BjC, num7);
							int num9 = Class233.smethod_26(Bjc, num7);
							class2.method_7(num8);
							class2.method_9(num9);
						}
						else
						{
							class2.method_7(num2);
							class2.method_9(num3);
						}
						class2.method_11(num6);
						class2.method_13(num5);
						class2.method_15(15f);
						class2.method_17(20f);
						class2.method_27();
						Bjg.Add(class2);
						for (int i = 0; i < BjA.Length; i++)
						{
							bool flag = false;
							foreach (int value in BjG.Values)
							{
								if (value == i)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								BjG.Add(setting.method_64(), i);
								break;
							}
						}
					}
					else
					{
						BjG.Add(setting.method_64(), dictionary3[setting.method_64()]);
						BjF.Add(setting.method_64(), dictionary[setting.method_64()]);
						Bjf.Add(setting.method_64(), dictionary2[setting.method_64()]);
						BjH.Add(list[num]);
						Bjh.Add(list2[num]);
						Bjg.Add(list3[num]);
					}
				}
				Bjk = Math.Min(Bjk, BjE.Count - 1);
			}
			else
			{
				Bjk = 0;
			}
			method_19();
			Invalidate();
		}
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_22(object sender, EventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.smethod_1176())
			{
				item.Enabled = BjE.Count != 0;
			}
			else if (item.Text == Class333.BBa())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
			}
		}
	}

	private ContextMenuStrip method_23()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opened += method_22;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.smethod_512();
		toolStripMenuItem.Click += method_21;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.smethod_1176();
		toolStripMenuItem2.Click += method_18;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
		toolStripMenuItem3.Text = Class333.BBa();
		toolStripMenuItem3.Click += method_17;
		contextMenuStrip.Items.Add(toolStripMenuItem3);
		return contextMenuStrip;
	}

	internal void method_24(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BBB());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.BBb() + BjB);
		list.Add(Class333.BBC() + Bjb);
		list.Add(Class333.BBc() + BjC);
		list.Add(Class333.BBD() + Bjc);
		list.Add(Class333.BBd() + BjD);
		list.Add(Class333.BBE() + Bjd);
		if (Bje.Count == BjF.Count && Bje.Count == Bjf.Count && Bje.Count == BjG.Count)
		{
			for (int i = 0; i < Bje.Count; i++)
			{
				list.Add(Class333.Baf() + Bje[i]);
				list.Add(Class333.Bag() + BjF[Bje[i]]);
				list.Add(Class333.BaH() + Bjf[Bje[i]]);
				list.Add(Class333.BBe() + BjG[Bje[i]]);
			}
		}
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_25(StreamReader streamReader_0)
	{
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.Baf()))
			{
				int item = int.Parse(text.Substring(Class333.Baf().Length));
				Bje.Add(item);
				Setting setting = Bja.method_31(item);
				if (setting != null)
				{
					BjE.Add(setting);
					BjI.Add(new List<int>());
					Bji.Add(int.MinValue);
					Bjj.Add(0);
					BjK.Add(0);
					System.Timers.Timer timer = new System.Timers.Timer();
					timer.Interval = 100.0;
					timer.Elapsed += method_20;
					BjJ.Add(timer);
					setting.method_264(method_13);
				}
			}
			else if (text.StartsWith(Class333.Bag()))
			{
				int value = int.Parse(text.Substring(Class333.Bag().Length));
				BjF.Add(Bje[Bje.Count - 1], value);
			}
			else if (text.StartsWith(Class333.BaH()))
			{
				int value2 = int.Parse(text.Substring(Class333.BaH().Length));
				Bjf.Add(Bje[Bje.Count - 1], value2);
			}
			else if (text.StartsWith(Class333.BBe()))
			{
				int value3 = int.Parse(text.Substring(Class333.BBe().Length));
				BjG.Add(Bje[Bje.Count - 1], value3);
			}
			else if (text.StartsWith(Class333.BBC()))
			{
				Bjb = bool.Parse(text.Substring(Class333.BBC().Length));
			}
			else if (text.StartsWith(Class333.BBc()))
			{
				BjC = double.Parse(text.Substring(Class333.BBc().Length));
			}
			else if (text.StartsWith(Class333.BBD()))
			{
				Bjc = double.Parse(text.Substring(Class333.BBD().Length));
			}
			else if (text.StartsWith(Class333.BBd()))
			{
				BjD = double.Parse(text.Substring(Class333.BBd().Length));
			}
			else if (text.StartsWith(Class333.BBE()))
			{
				Bjd = double.Parse(text.Substring(Class333.BBE().Length));
			}
			else if (text.StartsWith(Class333.BBb()))
			{
				BjB = int.Parse(text.Substring(Class333.BBb().Length));
			}
			else if (string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
		method_15();
		Bjg.Clear();
		if (BjF.Count != 0 && Bjf.Count != 0)
		{
			int num = Height - 10 - 1;
			int num2 = 18;
			int num3 = num - 28;
			foreach (Setting item2 in BjE)
			{
				Class26 @class = new Class26();
				@class.method_5(item2.method_231());
				if (Bjb)
				{
					int num4 = @class.method_4();
					int num5 = Class233.smethod_26(BjC, num4);
					int num6 = Class233.smethod_26(Bjc, num4);
					@class.method_7(num5);
					@class.method_9(num6);
				}
				else
				{
					@class.method_7(BjF[item2.method_64()]);
					@class.method_9(Bjf[item2.method_64()]);
				}
				@class.method_11(num3);
				@class.method_13(num2);
				@class.method_15(15f);
				@class.method_17(20f);
				@class.method_27();
				Bjg.Add(@class);
			}
		}
		Invalidate();
	}
}
