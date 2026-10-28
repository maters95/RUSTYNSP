using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns4;
using ns5;
using ns7;

namespace ns1;

internal class Class100 : MovableResizablePanel
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

	internal Class100(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BKC = framework_0;
		DoubleBuffered = true;
	}

	internal void method_12(int int_3)
	{
		Setting setting = BKC.method_31(int_3);
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
			BjZ = Bjy.method_64();
			if (!Bjy.method_35())
			{
				Bjy = null;
			}
		}
		if (BKC.method_2() && BKC.method_3() && Bjy != null && Bjy.method_96())
		{
			Label label = new Label();
			label.Text = Class333.smethod_180() + Bjy.method_60(Enum96.aYt) + Class333.BAO();
			label.ForeColor = Form23.color_12;
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = 10;
			label.Top = 10;
			Controls.Add(label);
			BKc = true;
			return;
		}
		if (Bjy != null)
		{
			Bjy.method_264(method_15);
			Bjy.TableDataSetting.method_264(method_15);
			Bjy.OnUserSelectionChanged += Bjy_OnUserSelectionChanged;
			Bjy.OnInvertRows += Bjy_OnInvertRows;
			Bjy.OnSwapColumnsAndRows += Bjy_OnSwapColumnsAndRows;
			Bjy.OnUserSliceIndexChanged += Bjy_OnUserSliceIndexChanged;
		}
		Paint += Class100_Paint;
		Class1.smethod_10(method_16);
		Class1.smethod_12(method_16);
		Form23.smethod_30(method_16);
		Form23.smethod_78(method_16);
		switch (Form23.enum62_0)
		{
		case Form23.Enum62.Bqg:
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
		case Form23.Enum62.BqH:
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
		BKB.DashStyle = DashStyle.Dash;
		UpdateLayout(resizingOnly: false);
		ContextMenuStrip = method_19();
	}

	protected override void Dispose(bool disposing)
	{
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
				Paint -= Class100_Paint;
				if (Bjy != null)
				{
					Bjy.method_265(method_15);
					Bjy.TableDataSetting.method_265(method_15);
					Bjy.OnUserSelectionChanged -= Bjy_OnUserSelectionChanged;
					Bjy.OnInvertRows -= Bjy_OnInvertRows;
					Bjy.OnSwapColumnsAndRows -= Bjy_OnSwapColumnsAndRows;
					Bjy.OnUserSliceIndexChanged -= Bjy_OnUserSliceIndexChanged;
					if (Bjy.HorizAxis != null && Bjy.HorizAxis.method_87() != null)
					{
						Bjy.HorizAxis.method_87().method_265(method_15);
					}
					if (Bjy.VertAxis != null && Bjy.VertAxis.method_87() != null)
					{
						Bjy.VertAxis.method_87().method_265(method_15);
					}
					if (Bjy.HorizAxis != null && Bjy.HorizAxis.method_88() != null)
					{
						Bjy.HorizAxis.method_88().method_265(method_15);
					}
					if (Bjy.VertAxis != null && Bjy.VertAxis.method_88() != null)
					{
						Bjy.VertAxis.method_88().method_265(method_15);
					}
					if (Bjy.HorizAxis != null && Bjy.HorizAxis.method_89() != null)
					{
						Bjy.HorizAxis.method_89().method_265(method_15);
					}
					if (Bjy.VertAxis != null && Bjy.VertAxis.method_89() != null)
					{
						Bjy.VertAxis.method_89().method_265(method_15);
					}
					if (Bjy.HorizAxis != null && Bjy.HorizAxis.method_90() != null)
					{
						Bjy.HorizAxis.method_90().method_265(method_14);
					}
					if (Bjy.VertAxis != null && Bjy.VertAxis.method_90() != null)
					{
						Bjy.VertAxis.method_90().method_265(method_14);
					}
				}
				if (Bjz != null)
				{
					Bjz.method_265(method_15);
				}
				if (BKA != null)
				{
					BKA.method_265(method_15);
				}
				Class1.smethod_11(method_16);
				Class1.smethod_13(method_16);
				Form23.smethod_31(method_16);
				Form23.smethod_79(method_16);
				if (ContextMenuStrip != null)
				{
					foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
					{
						item.Click -= method_17;
					}
					ContextMenuStrip.Opened -= method_18;
				}
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	[SpecialName]
	internal Table method_13()
	{
		return Bjy;
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (Bjy != null)
		{
			text = text + Class333.aMY() + Bjy.ToString();
		}
		return text + Class333.BAZ() + Left + Class333.BAz() + Top;
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		if (BKc || Bjy == null)
		{
			return;
		}
		if (Bjy.HorizAxis != null && Bjy.HorizAxis.method_87() != null)
		{
			Bjy.HorizAxis.method_87().method_265(method_15);
			Bjy.HorizAxis.method_87().method_264(method_15);
		}
		if (Bjy.VertAxis != null && Bjy.VertAxis.method_87() != null)
		{
			Bjy.VertAxis.method_87().method_265(method_15);
			Bjy.VertAxis.method_87().method_264(method_15);
		}
		if (Bjy.HorizAxis != null && Bjy.HorizAxis.method_88() != null)
		{
			Bjy.HorizAxis.method_88().method_265(method_15);
			Bjy.HorizAxis.method_88().method_264(method_15);
		}
		if (Bjy.VertAxis != null && Bjy.VertAxis.method_88() != null)
		{
			Bjy.VertAxis.method_88().method_265(method_15);
			Bjy.VertAxis.method_88().method_264(method_15);
		}
		if (Bjy.HorizAxis != null && Bjy.HorizAxis.method_89() != null)
		{
			Bjy.HorizAxis.method_89().method_265(method_15);
			Bjy.HorizAxis.method_89().method_264(method_15);
		}
		if (Bjy.VertAxis != null && Bjy.VertAxis.method_89() != null)
		{
			Bjy.VertAxis.method_89().method_265(method_15);
			Bjy.VertAxis.method_89().method_264(method_15);
		}
		if (Bjy.HorizAxis != null && Bjy.HorizAxis.method_90() != null)
		{
			Bjy.HorizAxis.method_90().method_265(method_14);
			Bjy.HorizAxis.method_90().method_264(method_14);
			Bjz = Bjy.HorizAxis.method_92();
			if (Bjz != null)
			{
				Bjz.method_265(method_15);
				Bjz.method_264(method_15);
			}
		}
		if (Bjy.VertAxis != null && Bjy.VertAxis.method_90() != null)
		{
			Bjy.VertAxis.method_90().method_265(method_14);
			Bjy.VertAxis.method_90().method_264(method_14);
			BKA = Bjy.VertAxis.method_92();
			if (BKA != null)
			{
				BKA.method_265(method_15);
				BKA.method_264(method_15);
			}
		}
		Invalidate();
	}

	private void Bjy_OnUserSliceIndexChanged(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void Bjy_OnUserSelectionChanged(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void Bjy_OnInvertRows(object sender, EventArgs e)
	{
		UpdateLayout(resizingOnly: false);
	}

	private void Bjy_OnSwapColumnsAndRows(object sender, EventArgs e)
	{
		UpdateLayout(resizingOnly: false);
	}

	private void method_14(object sender, EventArgs e)
	{
		UpdateLayout(resizingOnly: false);
	}

	private void method_15(object sender, EventArgs e)
	{
		if (method_0())
		{
			Invalidate();
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void Class100_Paint(object sender, PaintEventArgs e)
	{
		if (Bjy == null)
		{
			return;
		}
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			int num2;
			using (SolidBrush brush = new SolidBrush(Form23.color_12))
			{
				using Font font = new Font(Font.FontFamily, 10f);
				int num = Bjy.method_231();
				string text = string.Empty;
				if (num != 0 && num != 82)
				{
					text = Class333.smethod_497() + Class233.smethod_35(Bjy.method_232(), num, bool_0: false, 0) + Class333.smethod_9();
				}
				string text2 = Bjy.method_18();
				string text3 = (string.IsNullOrWhiteSpace(text2) ? Bjy.method_60(Enum96.aYt) : text2);
				string text4 = text3 + text;
				num2 = (int)graphics.MeasureString(text4, font, Width - 10).Height;
				Rectangle rectangle = new Rectangle(8, 8, Width - 10, num2);
				graphics.DrawString(text4, font, brush, rectangle);
			}
			int num3 = 8 + num2 + 10;
			int num4 = Height - 10;
			int num5 = num4 - num3;
			int num6 = 10;
			int num7 = Width - 10;
			int width = num7 - 10;
			int num8 = Width / 2;
			int num9 = num3 + num5 / 2;
			graphics.DrawRectangle(BKa, 10, num3, width, num5);
			graphics.DrawLine(BKB, num8 - 10, num3, num8 - 10, num4);
			graphics.DrawLine(BKB, num8 + 10, num3, num8 + 10, num4);
			graphics.DrawLine(BKB, 10, num9 - 10, num7, num9 - 10);
			graphics.DrawLine(BKB, 10, num9 + 10, num7, num9 + 10);
			if (Bjy == null)
			{
				return;
			}
			bool flag = Bjy.HorizAxisEnabled();
			bool flag2 = Bjy.VertAxisEnabled();
			if (((Form23.smethod_28(BKC.aXc, bool_53: true) && !Form23.smethod_80()) || (Form23.smethod_84(Bjz.method_64()) && Form23.smethod_84(BKA.method_64()))) && Bjy.HorizVertIndexPerUserSelectedCell.Count != 0 && (flag | flag2))
			{
				int num10 = Bjy.HorizAxisCount();
				int num11 = Bjy.VertAxisCount();
				int num12 = int.MaxValue;
				int num13 = int.MinValue;
				int num14 = int.MaxValue;
				int num15 = int.MinValue;
				foreach (Point item in Bjy.HorizVertIndexPerUserSelectedCell)
				{
					num12 = Math.Min(num12, item.X);
					num13 = Math.Max(num13, item.X);
					num14 = Math.Min(num14, item.Y);
					num15 = Math.Max(num15, item.Y);
				}
				int num16 = Math.Max(0, num12 - 1);
				int num17 = Math.Min(num10 - 1, num13 + 1);
				int num18 = Math.Max(0, num14 - 1);
				int num19 = Math.Min(num11 - 1, num15 + 1);
				int num20 = Bjy.HorizAxis.method_89().method_258(num16);
				int num21 = Bjy.HorizAxis.method_89().method_258(num17);
				int num22;
				int num23;
				if (Bjy.InvertRows)
				{
					num22 = Bjy.VertAxis.method_89().method_258(num11 - 1 - num18);
					num23 = Bjy.VertAxis.method_89().method_258(num11 - 1 - num19);
				}
				else
				{
					num22 = Bjy.VertAxis.method_89().method_258(num18);
					num23 = Bjy.VertAxis.method_89().method_258(num19);
				}
				int num24 = (Bjy.HorizAxis.method_89().method_258(num12) + Bjy.HorizAxis.method_89().method_258(num13)) / 2;
				int num25 = ((!Bjy.InvertRows) ? ((Bjy.VertAxis.method_89().method_258(num14) + Bjy.VertAxis.method_89().method_258(num15)) / 2) : ((Bjy.VertAxis.method_89().method_258(num11 - 1 - num14) + Bjy.VertAxis.method_89().method_258(num11 - 1 - num15)) / 2));
				int num26 = num8 - num6;
				int num27 = num24 - num20;
				if (num27 == 0)
				{
					num27 = num21 - num24;
				}
				int num28 = num9 - num3;
				int num29 = num25 - num22;
				if (num29 == 0)
				{
					num29 = num23 - num25;
				}
				int num30 = Bjz.method_256();
				int num31 = BKA.method_256();
				int num32 = ((num27 == 0 || !flag) ? num8 : (num8 - (num24 - num30) * num26 / num27));
				int num33 = ((num29 == 0 || !flag2) ? num9 : (num9 - (num25 - num31) * num28 / num29));
				BKb.EndCap = LineCap.ArrowAnchor;
				if (num32 != num8 || num33 != num9)
				{
					graphics.DrawLine(BKb, num32, num33, num8, num9);
				}
				if (num30 >= num20 && num30 <= num21 && ((!Bjy.InvertRows && num31 >= num22 && num31 <= num23) || (Bjy.InvertRows && num31 <= num22 && num31 >= num23)))
				{
					if ((flag && (num30 < num24 - num24 / 80 || num30 > num24 + num24 / 80)) || (flag2 && (num31 < num25 - num25 / 80 || num31 > num25 + num25 / 80)))
					{
						using Pen pen = new Pen(Color.Red, 3f);
						graphics.DrawEllipse(pen, num32 - 10, num33 - 10, 20, 20);
					}
					else
					{
						graphics.FillEllipse(Brushes.Green, num32 - 10, num33 - 10, 20, 20);
					}
				}
			}
		}
		catch
		{
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.BBH(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
	}

	private void method_17(object sender, EventArgs e)
	{
		Class30.smethod_0(this);
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_18(object sender, EventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.BBh())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
				break;
			}
		}
	}

	private ContextMenuStrip method_19()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opened += method_18;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.BBh();
		toolStripMenuItem.Click += method_17;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		return contextMenuStrip;
	}

	internal void method_20(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BBI());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.BBi() + BjZ);
		if (Bjy != null)
		{
			list.Add(Class333.BBJ() + Bjy.InvertRows);
			list.Add(Class333.BBj() + Bjy.SwapColumnsAndRows);
		}
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_21(StreamReader streamReader_0)
	{
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.BBi()))
			{
				BjZ = int.Parse(text.Substring(Class333.BBi().Length));
				if (BKC.method_31(BjZ) != null)
				{
					method_12(BjZ);
				}
			}
			else if (text.Contains(Class333.BBK()))
			{
				BjZ = int.Parse(text.Substring(text.IndexOf(Class333.BBK()) + Class333.BBK().Length));
				if (BKC.method_31(BjZ) != null)
				{
					method_12(BjZ);
				}
			}
			else if (text.StartsWith(Class333.BBJ()))
			{
				if (Bjy != null)
				{
					Bjy.InvertRows = bool.Parse(text.Substring(Class333.BBJ().Length));
				}
			}
			else if (text.StartsWith(Class333.BBj()))
			{
				if (Bjy != null)
				{
					Bjy.SwapColumnsAndRows = bool.Parse(text.Substring(Class333.BBj().Length));
				}
			}
			else if (!text.Contains(Class333.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}
}
