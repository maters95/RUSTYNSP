using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns4;
using ns5;
using ns7;

namespace ns1;

internal class Class105 : MovableResizablePanel
{
	internal const int BKm = 10;

	private const int BKN = 1000;

	private const int BKn = 30;

	private const int BKO = 50;

	private const int BKo = 10;

	private const int BKP = 8;

	private const int BKp = 10;

	private const int BKQ = 115;

	private const int BKq = 2;

	private const int BKR = 2;

	private const int BKr = 15;

	private const int BKS = 26;

	private const int BKs = 15;

	private const int BKT = 3;

	private const int BKt = 1000000000;

	private const int BKU = -1000000000;

	internal static Color[] BKu = new Color[10];

	private Framework BKV;

	private int BKv = 115;

	private int BKW = 2;

	private int BKw = 2;

	private int BKX = 10000;

	private bool BKx;

	private double BKY;

	private double BKy;

	private List<Setting> BKZ = new List<Setting>();

	private List<int> BKz = new List<int>();

	private Dictionary<int, int> BkA = new Dictionary<int, int>();

	private Dictionary<int, int> Bka = new Dictionary<int, int>();

	private Dictionary<int, int> BkB = new Dictionary<int, int>();

	private List<bool> Bkb = new List<bool>();

	private List<Class26> BkC = new List<Class26>();

	private int Bkc;

	private Stopwatch BkD = new Stopwatch();

	private int[,] Bkd = new int[10, 1000];

	private int[] BkE = new int[1000];

	private List<List<Control3.Struct15>> Bke = new List<List<Control3.Struct15>>();

	private List<List<int>> BkF = new List<List<int>>();

	private List<List<Color>> Bkf = new List<List<Color>>();

	private List<List<int>> BkG = new List<List<int>>();

	private List<List<int>> Bkg = new List<List<int>>();

	private Rectangle BkH;

	private long Bkh;

	private int BkI;

	private int Bki;

	private bool BkJ;

	private bool Bkj;

	private bool BkK;

	private int Bkk;

	private int BkL;

	private bool Bkl;

	private bool BkM;

	private int Bkm = 2;

	private int BkN = 2;

	private static Stopwatch Bkn = new Stopwatch();

	internal Class105(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BKV = framework_0;
		ContextMenuStrip = method_26();
		Class1.smethod_10(method_21);
		Class1.smethod_12(method_21);
		Form23.smethod_30(method_21);
		Form23.smethod_78(method_21);
		DoubleBuffered = true;
		BKu[0] = Color.Red;
		BKu[1] = Color.SkyBlue;
		BKu[2] = Color.LightGreen;
		BKu[3] = Color.Yellow;
		BKu[4] = Color.PeachPuff;
		BKu[5] = Color.LightCoral;
		BKu[6] = Color.PaleTurquoise;
		BKu[7] = Color.White;
		BKu[8] = Color.Orange;
		BKu[9] = Color.Pink;
		Control3.smethod_0(method_17);
		Control3.smethod_2(method_18);
		PreviewKeyDown += Class105_PreviewKeyDown;
		BkH = new Rectangle(10, 18, Width - 20 - 50 - 10 - 1, Height - 20 - 30 - 8 - 1);
	}

	private void Class105_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
	{
		e.IsInputKey = true;
		if ((Form23.int_0 & 0x1000) != 0)
		{
			Control3 control3_ = Form23.form23_0.control3_0;
			if (e.KeyCode == Keys.Up)
			{
				control3_.method_16(bool_11: true);
			}
			else if (e.KeyCode == Keys.Down)
			{
				control3_.method_16(bool_11: false);
			}
			else if (e.Shift && e.KeyCode == Keys.Left)
			{
				control3_.method_14(Control3.Enum36.BLz, bool_11: true);
			}
			else if (e.Shift && e.KeyCode == Keys.Right)
			{
				control3_.method_14(Control3.Enum36.BLz, bool_11: false);
			}
			else if (e.Control && e.KeyCode == Keys.Left)
			{
				control3_.method_14(Control3.Enum36.BLy, bool_11: true);
			}
			else if (e.Control && e.KeyCode == Keys.Right)
			{
				control3_.method_14(Control3.Enum36.BLy, bool_11: false);
			}
			else if (e.KeyCode == Keys.Left)
			{
				control3_.method_14(Control3.Enum36.BLZ, bool_11: true);
			}
			else if (e.KeyCode == Keys.Right)
			{
				control3_.method_14(Control3.Enum36.BLZ, bool_11: false);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			foreach (Setting item in BKZ)
			{
				item.method_265(method_20);
			}
			foreach (ToolStripMenuItem item2 in ContextMenuStrip.Items)
			{
				item2.Click -= method_24;
				item2.Click -= method_23;
				item2.Click -= method_22;
			}
			ContextMenuStrip.Opened -= method_25;
			Class1.smethod_11(method_21);
			Class1.smethod_13(method_21);
			Form23.smethod_31(method_21);
			Form23.smethod_79(method_21);
			Control3.smethod_1(method_17);
			Control3.smethod_3(method_18);
			PreviewKeyDown -= Class105_PreviewKeyDown;
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		return text + Class333.aMY() + BKZ.Count + Class333.BaU() + Left + Class333.BAz() + Top;
	}

	private int method_12(int int_3, int int_4)
	{
		int num = 0;
		if (int_3 < 100)
		{
			num = 10;
		}
		else if (int_3 <= 1000 && int_3 > 100)
		{
			num = 100;
		}
		else if (int_3 <= 10000 && int_3 > 1000)
		{
			num = 1000;
		}
		else
		{
			num = ((int_3 > 100000 || int_3 <= 10000) ? 100000 : 10000);
		}
		int num2 = int_4 / (TextRenderer.MeasureText(Class333.BBk(), Font).Width * 2);
		while (int_3 / num < num2 && num % 2 <= 0)
		{
			num /= 2;
		}
		return num;
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		base.OnPaint(paintEventArgs_0);
		method_15();
		Graphics graphics = paintEventArgs_0.Graphics;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		int num = 10;
		int num2 = Height - 10 - 1;
		int height = num2 - 10;
		int num3 = 10;
		int num4 = Width - 10 - 1;
		int num5 = num4 - 10;
		int num6 = num2 - 30;
		int num7 = num6 - 18;
		int num8 = Control3.int_8 - Control3.int_7;
		if (num8 == 0)
		{
			num8 = 1;
		}
		graphics.FillRectangle(Brushes.Black, num3, num, num5, height);
		using (Pen pen = new Pen(Color.Gray, 1f))
		{
			graphics.DrawRectangle(pen, num3, num, num5, height);
		}
		if ((Form23.int_0 & 0x1000) != 0)
		{
			int num9 = num5 - 60;
			int num10 = num3 + num9;
			int num11 = method_12(num8, num9);
			int num12 = num11 + (Control3.int_7 - Control3.int_5) / num11 * num11;
			using Font font = new Font(Font.FontFamily, 8f);
			using StringFormat stringFormat = new StringFormat();
			using SolidBrush brush = new SolidBrush(Color.White);
			using Pen pen2 = new Pen(Color.White, 1f);
			stringFormat.Alignment = StringAlignment.Center;
			graphics.DrawLine(pen2, num4 - 60, num, num4 - 60, num2);
			graphics.DrawLine(pen2, num4 - 10, num, num4 - 10, num2);
			int num13 = num12;
			for (int i = num3; i <= num10; i++)
			{
				float num14 = (float)(i - num3) / (float)num9;
				float num15 = (float)(i - num3 + 1) / (float)num9;
				int num16 = (int)((float)(Control3.int_7 - Control3.int_5) + num14 * (float)num8);
				int num17 = (int)((float)(Control3.int_7 - Control3.int_5) + num15 * (float)num8);
				if (num13 >= num16 && num13 < num17)
				{
					graphics.DrawLine(pen2, i, num6, i, num6 + 4);
					string s = string.Format(Class333.BBL(), (float)num13 / 1000f);
					graphics.DrawString(s, font, brush, i, num6 + 5, stringFormat);
					num13 += num11;
				}
			}
		}
		else
		{
			using (Pen pen3 = new Pen(Color.White, 1f))
			{
				for (int j = 1; j < 10; j++)
				{
					int num18 = num3 + j * (num5 - 60) / 10;
					graphics.DrawLine(pen3, num18, num6, num18, num6 + 4);
				}
				graphics.DrawLine(pen3, num4 - 60, num, num4 - 60, num2);
				graphics.DrawLine(pen3, num4 - 10, num, num4 - 10, num2);
			}
			using Font font2 = new Font(Font.FontFamily, 8f);
			using StringFormat stringFormat2 = new StringFormat();
			using SolidBrush brush2 = new SolidBrush(Color.White);
			stringFormat2.Alignment = StringAlignment.Center;
			for (int k = 1; k < 10; k++)
			{
				float num19 = (float)BKX * (float)k / 10f / 1000f;
				string s2 = string.Format(Class333.BBl(), num19);
				graphics.DrawString(s2, font2, brush2, num3 + (10 - k) * (num5 - 60) / 10, num6 + 5, stringFormat2);
			}
			graphics.DrawString(Class333.smethod_472(), font2, brush2, num3 + (num5 - 60) / 2, num6 + 16, stringFormat2);
		}
		if (Bkc < BKZ.Count && BkB.ContainsKey(BKZ[Bkc].method_64()))
		{
			using (Font font3 = new Font(Font.FontFamily, 8f))
			{
				using SolidBrush brush3 = new SolidBrush(BKu[BkB[BKZ[Bkc].method_64()]]);
				using Pen pen4 = new Pen(Color.DimGray, 1f);
				pen4.DashStyle = DashStyle.Dot;
				for (int l = 0; l < BkC[Bkc].method_22().Length; l++)
				{
					float num20 = BkC[Bkc].method_21()[l];
					int num21 = (int)BkC[Bkc].method_22()[l];
					if (num21 >= num + 1)
					{
						graphics.SmoothingMode = SmoothingMode.None;
						graphics.DrawLine(pen4, num3, num21, num4 - 60 + 4, num21);
						graphics.SmoothingMode = SmoothingMode.HighQuality;
					}
					if (num21 - 6 >= num + 1)
					{
						graphics.DrawString(num20.ToString(Class333.BAQ()), font3, brush3, num4 - 60 + 7, num21 - 6);
					}
				}
			}
			if (!BKx)
			{
				try
				{
					method_19(out var int_, out var int_2);
					int num22 = num4 - 10 + 2;
					int num23 = num4 - 2;
					using (SolidBrush brush4 = new SolidBrush(BKu[BkB[BKZ[Bkc].method_64()]]))
					{
						graphics.FillRectangle(brush4, num22, int_, num23 - num22, int_2 - int_);
					}
					graphics.DrawLine(Pens.Black, num22, int_ + 10, num23, int_ + 10);
					graphics.DrawLine(Pens.Black, num22, int_2 - 10, num23, int_2 - 10);
					graphics.DrawLine(Pens.Gray, num4 - 10, num + 10, num4, num + 10);
					graphics.DrawLine(Pens.Gray, num4 - 10, num2 - 10, num4, num2 - 10);
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.BBM() + ex.Message);
				}
			}
		}
		List<int> list = new List<int>();
		for (int m = 0; m < BKZ.Count; m++)
		{
			if (m != Bkc)
			{
				list.Add(m);
			}
		}
		list.Add(Bkc);
		bool[] array = new bool[BKZ.Count];
		bool flag = Form23.smethod_80();
		if ((Form23.int_0 & 0x1000) != 0)
		{
			if (BKZ.Count > 0)
			{
				Rectangle rect = new Rectangle(num3, num - 1, num5 - 60, num6 - num + 2);
				graphics.SetClip(rect, CombineMode.Replace);
				method_14(paintEventArgs_0.Graphics, BKZ[Bkc].method_64(), BKu[BkB[BKZ[Bkc].method_64()]]);
				graphics.ResetClip();
			}
			for (int n = 0; n < BKZ.Count; n++)
			{
				int index = list[n];
				Setting setting = BKZ[index];
				array[n] = setting.method_35() && PortFunction.smethod_52(setting);
			}
		}
		else
		{
			for (int num24 = 0; num24 < BKZ.Count; num24++)
			{
				int num25 = list[num24];
				Setting setting2 = BKZ[num25];
				array[num24] = setting2.method_35() && PortFunction.smethod_52(setting2);
				if (!array[num24] || !Bkb[num25] || ((!Form23.smethod_28(BKV.aXc, bool_53: true) || flag) && !Form23.smethod_84(setting2.method_64())))
				{
					continue;
				}
				using Pen pen5 = new Pen(BKu[BkB[setting2.method_64()]], 1f);
				Rectangle rect2 = new Rectangle(num3, num - 1, num5 - 60, num6 - num + 2);
				graphics.SetClip(rect2, CombineMode.Replace);
				int num26 = 0;
				int y = 0;
				int num27 = 0;
				long num28;
				if (BKx)
				{
					num27 = Class233.smethod_26(BKY, setting2.method_231());
					num28 = (long)Class233.smethod_26(BKy, setting2.method_231()) - (long)num27;
				}
				else
				{
					num28 = (long)Bka[setting2.method_64()] - (long)BkA[setting2.method_64()];
				}
				if (num28 == 0L)
				{
					num28 = 1L;
				}
				int num29 = 0;
				using (GraphicsPath graphicsPath = new GraphicsPath())
				{
					int num30 = 999;
					while (num30 >= 0 && BkE[num30] != 0 && (num26 == 0 || num26 > num3))
					{
						int num31 = Bkd[num25, num30];
						int num32 = num4 - 60 - num29 * (num5 - 60) / BKX;
						int val = (int)((!BKx) ? (num6 - num7 * ((long)num31 - (long)BkA[setting2.method_64()]) / num28) : (num6 - num7 * ((long)num31 - (long)num27) / num28));
						val = Math.Min(Math.Max(val, -1000000000), 1000000000);
						if (num30 != 999)
						{
							graphicsPath.AddLine(num26, y, num32, val);
							num29 += BkE[num30];
						}
						num26 = num32;
						y = val;
						num30--;
					}
					try
					{
						graphics.DrawPath(pen5, graphicsPath);
					}
					catch (Exception ex2)
					{
						Class23.smethod_3(Class333.BBm() + ex2.Message);
					}
				}
				graphics.ResetClip();
			}
		}
		if ((Form23.int_0 & 0x1000) != 0 && BKZ.Count > 0)
		{
			using Pen pen6 = new Pen(Color.White, 1f);
			pen6.DashStyle = DashStyle.Dash;
			try
			{
				int num33 = (int)((long)(Control3.int_4 - Control3.int_7) * (long)BkH.Width / num8);
				if (num33 + BkH.Left < BkH.Right && num33 + BkH.Left > BkH.Left)
				{
					paintEventArgs_0.Graphics.DrawLine(pen6, num33 + BkH.Left, 10, num33 + BkH.Left, BkH.Bottom);
				}
			}
			catch (Exception ex3)
			{
				Class23.smethod_3(Class333.BBN() + ex3.Message);
			}
		}
		List<string> list2 = new List<string>();
		string[] array2 = new string[BKZ.Count];
		BKv = 115;
		int num34 = 25;
		int num35 = 25;
		using (Font font4 = new Font(Font.FontFamily, 8f))
		{
			for (int num36 = 0; num36 < BKZ.Count; num36++)
			{
				Setting setting3 = BKZ[num36];
				array2[num36] = string.Empty;
				if (array[list.IndexOf(num36)] && ((Form23.smethod_28(BKV.aXc, bool_53: true) && !flag) || Form23.smethod_84(setting3.method_64())))
				{
					array2[num36] = setting3.method_252().DisplayValueString;
				}
				string text = setting3.method_18();
				if (!string.IsNullOrWhiteSpace(text))
				{
					list2.Add(text + Class333.smethod_497() + setting3.method_60(Enum96.aYT) + Class333.smethod_9());
				}
				else
				{
					list2.Add(setting3.method_60(Enum96.aYT));
				}
				num35 = Math.Max(num35, (int)graphics.MeasureString(list2[num36], font4).Width);
				num34 = Math.Max(num34, (int)graphics.MeasureString(array2[num36], font4).Width);
			}
		}
		BKv = 17 + num35 + 26 + num34 + 8;
		method_13(graphics, num3, num, num35, list2, array2);
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.BBn(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
	}

	private void method_13(Graphics graphics_0, int int_3, int int_4, int int_5, List<string> list_0, string[] string_0)
	{
		for (int i = 0; i < BKZ.Count; i++)
		{
			int num = int_4 + BKw + i * 15;
			if (i == Bkc)
			{
				using SolidBrush brush = new SolidBrush(Color.FromArgb(50, 50, 0));
				graphics_0.FillRectangle(brush, int_3 + BKW, num, BKv, 16);
			}
			else
			{
				graphics_0.FillRectangle(Brushes.Black, int_3 + BKW, num, BKv, 16);
			}
			using Font font = new Font(Font.FontFamily, 8f);
			Setting setting = BKZ[i];
			using SolidBrush solidBrush = new SolidBrush(BKu[BkB[setting.method_64()]]);
			using (Pen pen = new Pen(solidBrush.Color))
			{
				int num2 = num + 7 + 1;
				int num3 = int_3 + BKW + 7 + 1;
				graphics_0.DrawArc(pen, num3 - 11, num2 - 3, 24, 24, 230, 80);
				graphics_0.DrawArc(pen, num3 - 11, num2 + 3 - 24, 24, 24, 50, 80);
				if (Bkb[i])
				{
					graphics_0.DrawEllipse(pen, num3 - 2, num2 - 3, 6, 6);
					graphics_0.DrawEllipse(pen, num3, num2 - 1, 2, 2);
				}
				else
				{
					graphics_0.DrawLine(pen, num3 - 5, num2, num3 + 7, num2);
				}
			}
			graphics_0.DrawString(list_0[i], font, solidBrush, int_3 + BKW + 15 + 2, num + 2);
			if (!string.IsNullOrEmpty(string_0[i]))
			{
				graphics_0.DrawString(string_0[i], font, solidBrush, int_3 + BKW + 15 + 2 + int_5 + 26, num + 2);
			}
		}
		using Pen pen2 = new Pen(Color.Gray, 1f);
		graphics_0.DrawRectangle(pen2, int_3 + BKW, int_4 + BKw, BKv, BKZ.Count * 15);
	}

	private void method_14(Graphics graphics_0, int int_3, Color color_0)
	{
		List<Control3.Struct15> list = new List<Control3.Struct15>();
		for (int i = 0; i < Bke.Count; i++)
		{
			List<Control3.Struct15> list2 = Bke[i];
			if (list2.Count != 0)
			{
				bool flag = false;
				for (int j = 0; j < BKZ.Count; j++)
				{
					if (BKZ[j].method_64() == list2[0].BLt && !Bkb[j])
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (list2[k].BLu == color_0 && list2[k].BLt == int_3)
				{
					list.Add(list2[k]);
					continue;
				}
				if (i == list2[k].BLT)
				{
					using (Pen pen = new Pen(list2[k].BLu, 1f))
					{
						int y = Math.Min(Math.Max(list2[k].BLS.Y, -1000000000), 1000000000);
						int y2 = Math.Min(Math.Max(list2[k].BLs.Y, -1000000000), 1000000000);
						try
						{
							graphics_0.DrawLine(pen, list2[k].BLS.X, y, list2[k].BLs.X, y2);
						}
						catch (Exception ex)
						{
							Class23.smethod_3(Class333.BBO() + ex.Message);
						}
					}
					continue;
				}
				throw new Exception(Class333.smethod_496());
			}
		}
		foreach (Control3.Struct15 item in list)
		{
			using Pen pen2 = new Pen(item.BLu, 1f);
			int y3 = Math.Min(Math.Max(item.BLS.Y, -1000000000), 1000000000);
			int y4 = Math.Min(Math.Max(item.BLs.Y, -1000000000), 1000000000);
			try
			{
				graphics_0.DrawLine(pen2, item.BLS.X, y3, item.BLs.X, y4);
			}
			catch (Exception ex2)
			{
				Class23.smethod_3(Class333.BBO() + ex2.Message);
			}
		}
	}

	private void method_15()
	{
		if (Form23.form23_0.control3_0.Visible && (Control3.bool_4 || Control3.bool_0))
		{
			for (int i = 0; i < 1000; i++)
			{
				BkE[i] = 0;
				for (int j = 0; j < 10; j++)
				{
					Bkd[j, i] = 0;
				}
			}
			Bkh = 0L;
			return;
		}
		if (Form23.form23_0.control3_0.Visible && Control3.bool_1)
		{
			Bkh += BkD.ElapsedMilliseconds;
			return;
		}
		int num = 0;
		if (BkD.IsRunning)
		{
			BkD.Stop();
			num = (int)(BkD.ElapsedMilliseconds - Bkh);
			num = Math.Max(num, 10);
			if (Control3.double_0 != 1.0)
			{
				num = (int)((double)num * Control3.double_0);
			}
			BkD.Reset();
		}
		BkD.Start();
		for (int k = 0; k < 1000; k++)
		{
			if (k == 999)
			{
				BkE[k] = num;
			}
			else
			{
				BkE[k] = BkE[k + 1];
			}
		}
		for (int l = 0; l < 10; l++)
		{
			if (l < BKZ.Count)
			{
				int num2 = BKZ[l].method_256();
				for (int m = 0; m < 1000; m++)
				{
					if (m == 999)
					{
						Bkd[l, m] = num2;
					}
					else
					{
						Bkd[l, m] = Bkd[l, m + 1];
					}
				}
			}
			else
			{
				for (int n = 0; n < 1000; n++)
				{
					Bkd[l, n] = 0;
				}
			}
		}
		Bkh = 0L;
	}

	private void method_16()
	{
		int num = 0;
		BkF.Clear();
		Bkf.Clear();
		BkG.Clear();
		Bkg.Clear();
		for (int i = 0; i < Control3.list_0.Count; i++)
		{
			BkF.Add(new List<int>());
			Bkf.Add(new List<Color>());
			BkG.Add(new List<int>());
			Bkg.Add(new List<int>());
			for (int j = 0; j < Control3.list_0[i].Count; j++)
			{
				ushort num2 = Control3.list_0[i][j];
				Setting setting = Form23.framework_1.method_31(num2);
				if (setting != null && BKZ.Contains(setting))
				{
					BkF[i].Add(num2);
					Bkf[i].Add(BKu[BkB[num2]]);
					if (BKx)
					{
						int item = Class233.smethod_26(BKY, setting.method_231());
						int item2 = Class233.smethod_26(BKy, setting.method_231());
						BkG[i].Add(item);
						Bkg[i].Add(item2);
					}
					else
					{
						BkG[i].Add(BkA[num2]);
						Bkg[i].Add(Bka[num2]);
					}
					num++;
				}
			}
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		method_16();
		Control3.smethod_4(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, Control3.int_7, Control3.int_8);
		Invalidate();
	}

	private void method_18(object sender, Control3.EventArgs3 e)
	{
		if (e.method_0() == Control3.Enum35.BLX)
		{
			method_16();
			Control3.smethod_4(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, Control3.int_7, Control3.int_8);
		}
		Invalidate();
	}

	private void method_19(out int int_3, out int int_4)
	{
		if (BKx)
		{
			int_3 = 0;
			int_4 = 0;
			return;
		}
		int num = Height - 10 - 1;
		int num2 = num - 10 - 20;
		if (BKZ.Count == 0)
		{
			int_3 = num - 10 - num2;
			int_4 = num - 10;
			return;
		}
		Setting setting = BKZ[Bkc];
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
			int_3 = (int)(num - 10L - ((long)Bka[setting.method_64()] - (long)num3) * num2 / num5);
			int_4 = (int)(num - 10L - ((long)BkA[setting.method_64()] - (long)num3) * num2 / num5);
		}
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		Focus();
		if (Control3.stopwatch_0.IsRunning || Control3.bool_1)
		{
			Form23.form23_0.control3_0.themedButton_5_Click(null, null);
			Control3.stopwatch_0.Reset();
		}
		BkI = e.X;
		Bki = e.Y;
		if (BKZ.Count != 0)
		{
			int num = 10;
			int num2 = Width - 10 - 1;
			int num3 = 10;
			int num4 = Height - 10 - 1;
			method_19(out var int_, out var int_2);
			if (new Rectangle(num2 - 10, 10, 10, num4 - 10).Contains(e.Location))
			{
				Bkk = int_;
				BkL = int_2;
				if (!BKx && Bki > num3 && Bki < num4)
				{
					if (Bki < num3 + 10 || Bki > num4 - 10)
					{
						Setting setting = BKZ[Bkc];
						int num5 = setting.method_228();
						int num6 = setting.method_229();
						if (num5 == 0 && num6 == 0)
						{
							num6 = 100;
						}
						BkA[setting.method_64()] = num5;
						Bka[setting.method_64()] = num6;
						BkC[Bkc].method_7(num5);
						BkC[Bkc].method_9(num6);
						BkC[Bkc].method_27();
						method_16();
						Control3.smethod_4(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, Control3.int_7, Control3.int_8);
						Invalidate();
						return;
					}
					if (Bki > int_ && Bki < int_ + 10)
					{
						Bkj = true;
						return;
					}
					if (Bki > int_ + 10 && Bki < int_2 - 10)
					{
						BkJ = true;
						return;
					}
					if (Bki > int_2 - 10 && Bki < int_2)
					{
						BkK = true;
						return;
					}
				}
			}
			else
			{
				if (new Rectangle(num + BKW, num3 + BKw, BKv, BKZ.Count * 15).Contains(e.Location))
				{
					Bkm = BKW;
					BkN = BKw;
					Bkl = true;
					return;
				}
				if ((Form23.int_0 & 0x1000) != 0 && BkH.Contains(e.Location))
				{
					Control3.bool_3 = true;
					Control3.int_4 = (int)((double)(e.X - BkH.Left) / (double)BkH.Width * (double)(Control3.int_8 - Control3.int_7)) + Control3.int_7;
					Control3.int_9 = Control3.int_4;
					Form23.form23_0.control3_0.method_10();
					Control3.list_2.Clear();
					Control3.int_15 = -1;
					return;
				}
			}
		}
		base.MouseDownHandler(sender, e);
	}

	protected override void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		int num = 10;
		int num2 = Height - 10 - 1;
		int num3 = Width - 10 - 1;
		if (!BKx && (BkJ || Bkj || BkK))
		{
			Setting setting = BKZ[Bkc];
			int num4 = setting.method_228();
			int num5 = setting.method_229();
			if (num4 == 0 && num5 == 0)
			{
				num5 = 100;
			}
			int num6 = num5 - num4;
			int num7 = num2 - num - 20;
			if (BkJ)
			{
				int num8 = e.Y - Bki;
				int num9 = BkL - Bkk;
				int num10 = Bkk + num8;
				int num11 = BkL + num8;
				if (num10 < num + 10)
				{
					num10 = num + 10;
					num11 = num10 + num9;
				}
				else if (num11 > num2 - 10)
				{
					num11 = num2 - 10;
					num10 = num11 - num9;
				}
				BkA[setting.method_64()] = Math.Max(num4, num4 + (num2 - 10 - num11) * num6 / num7);
				Bka[setting.method_64()] = Math.Min(num5, num4 + (num2 - 10 - num10) * num6 / num7);
			}
			else if (Bkj)
			{
				method_19(out var _, out var int_2);
				Bka[setting.method_64()] = Math.Min(num5, num4 + (num7 - (Math.Min(e.Y, int_2 - 20) - (num + 10))) * num6 / num7);
			}
			else if (BkK)
			{
				method_19(out var int_3, out var _);
				BkA[setting.method_64()] = Math.Max(num4, num4 + (num7 - (Math.Max(e.Y, int_3 + 20) - (num + 10))) * num6 / num7);
			}
			BkC[Bkc].method_7(BkA[setting.method_64()]);
			BkC[Bkc].method_9(Bka[setting.method_64()]);
			BkC[Bkc].method_27();
			method_16();
			Control3.smethod_4(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, Control3.int_7, Control3.int_8);
			Invalidate();
		}
		else if (BkH.Contains(e.Location))
		{
			if (Control3.bool_3)
			{
				if (!Bkn.IsRunning)
				{
					Bkn.Start();
				}
				else if (Bkn.ElapsedMilliseconds > 80L)
				{
					if (e.X >= BkH.Left && e.X < BkH.Right)
					{
						Control3.int_4 = (int)((double)(e.X - BkH.Left) / (double)BkH.Width * (double)(Control3.int_8 - Control3.int_7)) + Control3.int_7;
						Control3.int_9 = Control3.int_4;
						Form23.form23_0.control3_0.method_10();
						Control3.list_2.Clear();
						Control3.int_15 = -1;
					}
					Bkn.Restart();
				}
			}
			else if (Bkl)
			{
				int num12 = e.X - BkI;
				int num13 = e.Y - Bki;
				if (BkM || num12 != 0 || num13 != 0)
				{
					BkM = true;
					int val = num2 - 30 - BKZ.Count * 15;
					int val2 = num3 - 60 - BKv;
					BKW = Math.Min(Math.Max(Bkm + num12, 2), val2);
					BKw = Math.Min(Math.Max(BkN + num13, 2), val);
					Invalidate();
				}
			}
			else if ((Form23.int_0 & 0x1000) != 0)
			{
				int num14 = Control3.int_8 - Control3.int_7;
				if (num14 <= 0)
				{
					num14 = 1;
				}
				int num15 = Control3.int_4 * BkH.Width / num14 + BkH.Left;
				if (e.X >= num15 - 3 && e.X <= num15 + 3)
				{
					Cursor = Cursors.VSplit;
				}
				else
				{
					Cursor = Cursors.Default;
				}
			}
			else
			{
				base.MouseMoveHandler(sender, e);
			}
		}
		else if (!Control3.bool_3)
		{
			base.MouseMoveHandler(sender, e);
		}
	}

	protected override void MouseUpHandler(object sender, MouseEventArgs e)
	{
		base.MouseUpHandler(sender, e);
		BkJ = false;
		Bkj = false;
		BkK = false;
		Bkl = false;
		if (!BkM)
		{
			int x = e.X;
			int y = e.Y;
			int num = 10;
			int num2 = 10;
			for (int i = 0; i < BKZ.Count; i++)
			{
				if (new Rectangle(num2 + BKW, num + BKw + i * 15, BKv, 15).Contains(x, y))
				{
					if (x <= num2 + BKW + 15 + 1)
					{
						Bkb[i] = !Bkb[i];
					}
					else
					{
						Bkc = i;
					}
					Control3.smethod_4(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, Control3.int_7, Control3.int_8);
					Invalidate();
					return;
				}
			}
		}
		else
		{
			BkM = false;
		}
		if (Control3.bool_3)
		{
			Control3.bool_3 = false;
			Form23.form23_0.Refresh();
		}
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		if (BkA.Count != 0 && Bka.Count != 0)
		{
			int num = Height - 10 - 1;
			int num2 = 18;
			int num3 = num - 30;
			for (int i = 0; i < BKZ.Count; i++)
			{
				BkC[i].method_11(num3);
				BkC[i].method_13(num2);
				BkC[i].method_27();
			}
		}
		BkH = new Rectangle(10, 18, Width - 20 - 50 - 10 - 1, Height - 20 - 30 - 8 - 1);
		if ((Form23.int_0 & 0x1000) != 0)
		{
			method_16();
			Control3.smethod_4(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, Control3.int_7, Control3.int_8);
		}
	}

	private void method_20(object sender, EventArgs e)
	{
		if ((Form23.int_0 & 0x1000) == 0)
		{
			if (method_0() && Form23.form23_0.WindowState != FormWindowState.Minimized)
			{
				Invalidate();
			}
			else
			{
				method_15();
			}
		}
	}

	private void method_21(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void method_22(object sender, EventArgs e)
	{
		Dispose();
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_23(object sender, EventArgs e)
	{
		Form56 form = new Form56(BKZ, BKx, BKY, BKy, BkA, Bka, BkB, BKX);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			BkB = form.method_5();
			BKX = form.method_6();
			BKx = form.method_0();
			if (BKx)
			{
				BKY = form.method_1();
				BKy = form.method_2();
			}
			else
			{
				BkA = form.method_3();
				Bka = form.method_4();
			}
			for (int i = 0; i < BKZ.Count; i++)
			{
				if (BKx)
				{
					int num = BKZ[i].method_231();
					int num2 = Class233.smethod_26(BKY, num);
					int num3 = Class233.smethod_26(BKy, num);
					BkC[i].method_7(num2);
					BkC[i].method_9(num3);
					BkC[i].method_27();
					continue;
				}
				Setting setting = BKZ[i];
				int int_;
				int int_2;
				if (Form23.dictionary_0.ContainsKey(setting.method_64()))
				{
					Class209 @class = Form23.dictionary_0[setting.method_64()];
					int_ = @class.int_3;
					int_2 = @class.int_4;
				}
				else
				{
					int_ = setting.method_224();
					int_2 = setting.method_225();
				}
				Form23.smethod_4(setting.method_64(), form.method_3()[setting.method_64()], form.method_4()[setting.method_64()], int_, int_2);
				BkC[i].method_7(BkA[setting.method_64()]);
				BkC[i].method_9(Bka[setting.method_64()]);
				BkC[i].method_27();
			}
			method_16();
			Control3.smethod_4(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, Control3.int_7, Control3.int_8);
			Invalidate();
			Form23.smethod_3();
		}
		form.Dispose();
	}

	internal void method_24(object sender, EventArgs e)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> item in BkA)
		{
			dictionary.Add(item.Key, item.Value);
		}
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> item2 in Bka)
		{
			dictionary2.Add(item2.Key, item2.Value);
		}
		List<Class26> list = new List<Class26>();
		foreach (Class26 item3 in BkC)
		{
			list.Add(item3);
		}
		List<int> list2 = new List<int>();
		foreach (Setting item4 in BKZ)
		{
			list2.Add(item4.method_64());
		}
		Dictionary<int, int> dictionary3 = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> item5 in BkB)
		{
			dictionary3.Add(item5.Key, item5.Value);
		}
		List<bool> list3 = new List<bool>();
		foreach (bool item6 in Bkb)
		{
			list3.Add(item6);
		}
		List<int> list4 = Form45.smethod_0(Form23.form23_0, BKV, list2, 10);
		if (list4 != null)
		{
			foreach (Setting item7 in BKZ)
			{
				item7.method_265(method_20);
			}
			BKZ.Clear();
			BKz.Clear();
			BkA.Clear();
			Bka.Clear();
			BkC.Clear();
			BkB.Clear();
			Bkb.Clear();
			if (list4.Count != 0)
			{
				bool flag = false;
				foreach (int item8 in list4)
				{
					Setting setting = BKV.method_31(item8);
					if (setting == null)
					{
						continue;
					}
					BKZ.Add(setting);
					BKz.Add(item8);
					if (!flag)
					{
						setting.method_264(method_20);
						flag = true;
					}
					int num = list2.IndexOf(item8);
					if (num == -1)
					{
						int num2;
						int num3;
						if (Form23.dictionary_0.ContainsKey(setting.method_64()))
						{
							Class209 @class = Form23.dictionary_0[setting.method_64()];
							num2 = @class.int_1;
							num3 = @class.int_2;
						}
						else
						{
							num2 = setting.method_226();
							num3 = setting.method_227();
						}
						BkA.Add(setting.method_64(), num2);
						Bka.Add(setting.method_64(), num3);
						int num4 = Height - 10 - 1;
						int num5 = 18;
						int num6 = num4 - 30;
						Class26 class2 = new Class26();
						class2.method_5(setting.method_231());
						if (BKx)
						{
							int num7 = setting.method_231();
							int num8 = Class233.smethod_26(BKY, num7);
							int num9 = Class233.smethod_26(BKy, num7);
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
						BkC.Add(class2);
						Bkb.Add(item: true);
						for (int i = 0; i < BKu.Length; i++)
						{
							bool flag2 = false;
							foreach (int value in BkB.Values)
							{
								if (value == i)
								{
									flag2 = true;
									break;
								}
							}
							if (!flag2)
							{
								BkB.Add(setting.method_64(), i);
								break;
							}
						}
					}
					else
					{
						BkB.Add(setting.method_64(), dictionary3[setting.method_64()]);
						BkA.Add(setting.method_64(), dictionary[setting.method_64()]);
						Bka.Add(setting.method_64(), dictionary2[setting.method_64()]);
						BkC.Add(list[num]);
						Bkb.Add(list3[num]);
					}
				}
				Bkc = Math.Min(Bkc, BKZ.Count - 1);
			}
			else
			{
				Bkc = 0;
			}
			method_16();
			Control3.smethod_4(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, Control3.int_7, Control3.int_8);
			Invalidate();
		}
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_25(object sender, EventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.smethod_1176())
			{
				item.Enabled = BKZ.Count != 0;
			}
			else if (item.Text == Class333.BBo())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
			}
		}
	}

	private ContextMenuStrip method_26()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opened += method_25;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.smethod_512();
		toolStripMenuItem.Click += method_24;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.smethod_1176();
		toolStripMenuItem2.Click += method_23;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
		toolStripMenuItem3.Text = Class333.BBo();
		toolStripMenuItem3.Click += method_22;
		contextMenuStrip.Items.Add(toolStripMenuItem3);
		return contextMenuStrip;
	}

	internal void method_27(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BBP());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.BBp() + BKW);
		list.Add(Class333.BBQ() + BKw);
		list.Add(Class333.BBq() + BKX);
		list.Add(Class333.BBC() + BKx);
		list.Add(Class333.BBc() + BKY);
		list.Add(Class333.BBD() + BKy);
		if (BKz.Count == BkA.Count && BKz.Count == Bka.Count && BKz.Count == BkB.Count)
		{
			for (int i = 0; i < BKz.Count; i++)
			{
				list.Add(Class333.Baf() + BKz[i]);
				list.Add(Class333.Bag() + BkA[BKz[i]]);
				list.Add(Class333.BaH() + Bka[BKz[i]]);
				list.Add(Class333.BBe() + BkB[BKz[i]]);
			}
		}
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_28(StreamReader streamReader_0)
	{
		bool flag = false;
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.Baf()))
			{
				int item = int.Parse(text.Substring(Class333.Baf().Length));
				BKz.Add(item);
				Setting setting = BKV.method_31(item);
				if (setting != null)
				{
					BKZ.Add(setting);
					Bkb.Add(item: true);
					if (!flag)
					{
						setting.method_264(method_20);
						flag = true;
					}
				}
			}
			else if (text.Contains(Class333.BaI()))
			{
				string text2 = text.Substring(text.IndexOf(Class333.BaI()) + Class333.BaI().Length);
				if (string.IsNullOrEmpty(text2))
				{
					continue;
				}
				string[] array = text2.Split(',');
				for (int i = 0; i < array.Length; i++)
				{
					string text3 = array[i].Trim();
					if (!int.TryParse(text3, out var result))
					{
						string value = text3.Substring(1, text3.Length - 2);
						try
						{
							result = (int)(Enum87)Enum.Parse(typeof(Enum87), value);
						}
						catch
						{
							result = -1;
						}
					}
					list.Add(result);
					if (result != -1)
					{
						BKz.Add(result);
						Setting setting2 = BKV.method_31(result);
						if (setting2 != null)
						{
							BKZ.Add(setting2);
							Bkb.Add(item: true);
							setting2.method_264(method_20);
						}
					}
				}
				if (list.Count != list2.Count)
				{
					continue;
				}
				for (int j = 0; j < list2.Count; j++)
				{
					if (list[j] != -1)
					{
						BkB.Add(list[j], list2[j]);
					}
				}
			}
			else if (text.StartsWith(Class333.Bag()))
			{
				int value2 = int.Parse(text.Substring(Class333.Bag().Length));
				BkA.Add(BKz[BKz.Count - 1], value2);
			}
			else if (text.StartsWith(Class333.BaH()))
			{
				int value3 = int.Parse(text.Substring(Class333.BaH().Length));
				Bka.Add(BKz[BKz.Count - 1], value3);
			}
			else if (text.Contains(Class333.BBR()))
			{
				string[] array2 = text.Substring(text.IndexOf(Class333.BBR()) + Class333.BBR().Length).Split(',');
				for (int k = 0; k < array2.Length; k++)
				{
					if (k < list.Count && list[k] != -1)
					{
						string[] array3 = array2[k].Trim().Split(':');
						if (!int.TryParse(array3[0], out var result2))
						{
							result2 = (int)Math.Round(float.Parse(array3[0]));
						}
						BkA.Add(list[k], result2);
						if (!int.TryParse(array3[1], out var result3))
						{
							result3 = (int)Math.Round(float.Parse(array3[1]));
						}
						Bka.Add(list[k], result3);
					}
				}
			}
			else if (text.StartsWith(Class333.BBe()))
			{
				int value4 = int.Parse(text.Substring(Class333.BBe().Length));
				BkB.Add(BKz[BKz.Count - 1], value4);
			}
			else if (text.Contains(Class333.BBr()))
			{
				string[] array = text.Substring(text.IndexOf(Class333.BBr()) + Class333.BBr().Length).Split(',');
				foreach (string text4 in array)
				{
					list2.Add(int.Parse(text4.Trim()));
				}
			}
			else if (text.StartsWith(Class333.BBC()))
			{
				BKx = bool.Parse(text.Substring(Class333.BBC().Length));
			}
			else if (text.StartsWith(Class333.BBc()))
			{
				BKY = double.Parse(text.Substring(Class333.BBc().Length));
			}
			else if (text.StartsWith(Class333.BBD()))
			{
				BKy = double.Parse(text.Substring(Class333.BBD().Length));
			}
			else if (text.StartsWith(Class333.BBp()))
			{
				BKW = int.Parse(text.Substring(Class333.BBp().Length));
			}
			else if (text.StartsWith(Class333.BBQ()))
			{
				BKw = int.Parse(text.Substring(Class333.BBQ().Length));
			}
			else if (text.StartsWith(Class333.BBq()))
			{
				BKX = int.Parse(text.Substring(Class333.BBq().Length));
			}
			else if (text.Contains(Class333.BBS()))
			{
				BKX = int.Parse(text.Substring(text.IndexOf(Class333.BBS()) + Class333.BBS().Length));
			}
			else if (!text.Contains(Class333.BBs()) && !text.Contains(Class333.BBT()) && !text.Contains(Class333.BBt()) && !text.Contains(Class333.BBU()) && !text.Contains(Class333.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
		BkC.Clear();
		if (BkA.Count != 0 && Bka.Count != 0)
		{
			int num = Height - 10 - 1;
			int num2 = 18;
			int num3 = num - 30;
			foreach (Setting item2 in BKZ)
			{
				Class26 @class = new Class26();
				@class.method_5(item2.method_231());
				if (BKx)
				{
					int num4 = @class.method_4();
					int num5 = Class233.smethod_26(BKY, num4);
					int num6 = Class233.smethod_26(BKy, num4);
					@class.method_7(num5);
					@class.method_9(num6);
				}
				else
				{
					@class.method_7(BkA[item2.method_64()]);
					@class.method_9(Bka[item2.method_64()]);
				}
				@class.method_11(num3);
				@class.method_13(num2);
				@class.method_15(15f);
				@class.method_17(20f);
				@class.method_27();
				BkC.Add(@class);
			}
		}
		if (Control3.list_5 != null)
		{
			method_16();
			Control3.smethod_4(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, Control3.int_7, Control3.int_8);
			Invalidate();
		}
	}
}
