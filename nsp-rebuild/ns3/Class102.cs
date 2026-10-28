using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns2;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns3;

internal class Class102 : Class101
{
	private class Class62 : TrackBar
	{
		private Class102 baD;

		private int bad;

		private const int baE = 4;

		internal Class62(Class102 class102_0)
		{
			baD = class102_0;
			SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
			SetStyle(ControlStyles.UserPaint, value: true);
			Minimum = 0;
			Maximum = 3;
			TickFrequency = 1;
			SmallChange = 1;
			LargeChange = 1;
		}

		internal int method_0(int int_0)
		{
			int result = 1;
			switch (int_0)
			{
			case 0:
				result = 1;
				break;
			case 1:
				result = 2;
				break;
			case 2:
				result = 4;
				break;
			case 3:
				result = 8;
				break;
			}
			return result;
		}

		internal void method_1(int int_0)
		{
			int value = 0;
			switch (int_0)
			{
			case 8:
				value = 3;
				break;
			case 1:
				value = 0;
				break;
			case 2:
				value = 1;
				break;
			case 4:
				value = 2;
				break;
			}
			Value = value;
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			Graphics graphics = paintEventArgs_0.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			using (Font font = new Font(Font.FontFamily, 10f))
			{
				using SolidBrush brush = new SolidBrush(Form23.color_12);
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
				{
					using (Pen pen = new Pen(Color.White, 4f))
					{
						graphics.DrawLine(pen, 14, 10, Width - 11, 10);
					}
					for (int i = 0; i < 4; i++)
					{
						int num = 14 + i * (Width - 25) / 3;
						graphics.DrawLine(Pens.White, num, 12, num, 18);
						graphics.DrawString(method_0(i) + Class333.smethod_486(), font, brush, num, 26f, stringFormat);
					}
				}
				else
				{
					using (Pen pen2 = new Pen(Color.Gray, 4f))
					{
						graphics.DrawLine(pen2, 14, 10, Width - 11, 10);
					}
					for (int j = 0; j < 4; j++)
					{
						int num2 = 14 + j * (Width - 25) / 3;
						graphics.DrawLine(Pens.Gray, num2, 12, num2, 18);
						graphics.DrawString(method_0(j) + Class333.smethod_486(), font, brush, num2, 26f, stringFormat);
					}
				}
				graphics.DrawString(Class333.BJI(), font, brush, Width / 2, 40f, stringFormat);
				stringFormat.Dispose();
			}
			graphics.FillEllipse(Brushes.DodgerBlue, 14 + Value * (Width - 25) / 3 - 7, 3, 14, 14);
			if (Value != bad)
			{
				int userZoomLevel = method_0(Value);
				baD.BKE.UserZoomLevel = userZoomLevel;
				if (baD.BKe != null)
				{
					baD.BKe.UserZoomLevel = userZoomLevel;
				}
				bad = Value;
			}
		}

		protected override void OnGotFocus(EventArgs eventArgs_0)
		{
			baD.Focus();
		}
	}

	private const int Buj = 94;

	private const int BuK = 65;

	private const int Buk = 50;

	private const int BuL = 2;

	private const int Bul = 20;

	private bool BuM;

	private Class62 Bum;

	private string BuN;

	private string Bun;

	private static Pen[] BuO = new Pen[10]
	{
		Pens.Red,
		Pens.SkyBlue,
		Pens.LightGreen,
		Pens.Yellow,
		Pens.PeachPuff,
		Pens.LightCoral,
		Pens.PaleTurquoise,
		Pens.White,
		Pens.Orange,
		Pens.Pink
	};

	private int Buo = -1;

	private bool BuP;

	private int Bup;

	private int BuQ;

	private Rectangle Buq = Rectangle.Empty;

	private Dictionary<int, int> BuR = new Dictionary<int, int>();

	private Dictionary<int, int> Bur = new Dictionary<int, int>();

	private int BuS;

	private bool Bus;

	private Point BuT = new Point(0, 0);

	private Stopwatch But = new Stopwatch();

	private ToolStripMenuItem BuU;

	internal Class102(Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(framework_0, framework_1, rectangle_0, bool_0)
	{
		Bum = new Class62(this);
		_ = Bum.Handle;
		DoubleBuffered = true;
		GotFocus += Class102_GotFocus;
		LostFocus += Class102_LostFocus;
	}

	internal override void vmethod_2(int int_3)
	{
		Setting setting = BKD.method_31(int_3);
		if (setting != null)
		{
			BKE = setting as Table;
		}
		else
		{
			BKE = null;
		}
		if (BKE != null)
		{
			BKF = BKE.method_64();
			if (BKE != null && BKd != null)
			{
				BKe = BKd.method_31(int_3) as Table;
			}
			else
			{
				BKe = null;
			}
		}
		else
		{
			BKe = null;
		}
		if (BKE != null && BKe != null)
		{
			if (BKe.InvertRows != BKE.InvertRows)
			{
				BKe.InvertRows = BKE.InvertRows;
			}
			if (BKe.SwapColumnsAndRows != BKE.SwapColumnsAndRows)
			{
				BKe.SwapColumnsAndRows = BKE.SwapColumnsAndRows;
			}
			if (BKe.HorizVertIndexPerUserSelectedCell != BKE.HorizVertIndexPerUserSelectedCell)
			{
				BKe.HorizVertIndexPerUserSelectedCell = BKE.HorizVertIndexPerUserSelectedCell;
			}
		}
		BKi = BKD.method_2() && BKD.method_3() && BKE != null && BKE.method_96();
		BKJ = BKd != null && BKd.method_2() && BKd.method_3() && BKe != null && BKe.method_96();
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ)
		{
			Label label = new Label();
			label.Text = Class333.smethod_180() + BKE.method_60(Enum96.aYt) + Class333.BAO();
			label.ForeColor = Form23.color_12;
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = 10;
			label.Top = 10;
			Controls.Add(label);
			return;
		}
		if (BKE != null)
		{
			BKE.method_264(method_22);
			BKE.TableDataSetting.method_264(method_26);
			BKE.OnUserSelectionChanged += method_18;
			BKE.OnInvertRows += method_19;
			BKE.OnSwapColumnsAndRows += method_20;
			BKE.OnUserSliceIndexChanged += method_17;
			BKE.OnUserZoomLevelChanged += method_47;
			BKE.OnShowHideBarsChanged += method_37;
			Bum.method_1(BKE.UserZoomLevel);
			if (BKD.awo != null)
			{
				BKD.awo.method_2(BKE.method_64())?.method_264(method_24);
			}
		}
		Paint += Class102_Paint;
		Class1.smethod_10(method_25);
		Class1.smethod_12(method_25);
		Form23.smethod_30(method_25);
		Form23.smethod_78(method_25);
		method_13();
		UpdateLayout(resizingOnly: false);
		ContextMenuStrip = method_39();
	}

	protected override void vmethod_1()
	{
		try
		{
			Paint -= Class102_Paint;
			if (BKE != null)
			{
				BKE.method_265(method_22);
				BKE.TableDataSetting.method_265(method_26);
				BKE.OnUserSelectionChanged -= method_18;
				BKE.OnInvertRows -= method_19;
				BKE.OnSwapColumnsAndRows -= method_20;
				BKE.OnUserSliceIndexChanged -= method_17;
				BKE.OnUserZoomLevelChanged -= method_47;
				BKE.OnShowHideBarsChanged -= method_37;
				if (BKD.awo != null)
				{
					BKD.awo.method_2(BKE.method_64())?.method_265(method_24);
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_87() != null)
				{
					BKE.HorizAxis.method_87().method_265(method_26);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_87() != null)
				{
					BKE.VertAxis.method_87().method_265(method_26);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_87() != null)
				{
					BKE.SliceAxis.method_87().method_265(method_26);
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_88() != null)
				{
					BKE.HorizAxis.method_88().method_265(method_26);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_88() != null)
				{
					BKE.VertAxis.method_88().method_265(method_26);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_88() != null)
				{
					BKE.SliceAxis.method_88().method_265(method_26);
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_89() != null)
				{
					BKE.HorizAxis.method_89().method_265(method_26);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_89() != null)
				{
					BKE.VertAxis.method_89().method_265(method_26);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_89() != null)
				{
					BKE.SliceAxis.method_89().method_265(method_26);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_91() != null)
				{
					BKE.SliceAxis.method_91().method_265(method_26);
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_90() != null)
				{
					BKE.HorizAxis.method_90().method_265(method_21);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_90() != null)
				{
					BKE.VertAxis.method_90().method_265(method_21);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_90() != null)
				{
					BKE.SliceAxis.method_90().method_265(method_21);
				}
			}
			if (BKg != null)
			{
				BKg.method_265(method_23);
			}
			Class1.smethod_11(method_25);
			Class1.smethod_13(method_25);
			Form23.smethod_31(method_25);
			Form23.smethod_79(method_25);
			if (ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
			{
				item.Click -= vmethod_3;
				item.Click -= method_36;
				item.Click -= BuU_Click;
				item.Click -= method_35;
				item.Click -= method_33;
			}
			ContextMenuStrip.Opened -= method_38;
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		vmethod_1();
		try
		{
			GotFocus -= Class102_GotFocus;
			LostFocus -= Class102_LostFocus;
			Form23.form23_0.method_10(vmethod_0);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (BKE != null)
		{
			text = text + Class333.aMY() + BKE.ToString();
		}
		return text + Class333.BAZ() + Left + Class333.BAz() + Top;
	}

	[SpecialName]
	internal Table method_12()
	{
		return BKE;
	}

	private void method_13()
	{
		bool flag = ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ);
		if (flag || BKE == null)
		{
			return;
		}
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_87() != null)
		{
			BKE.HorizAxis.method_87().method_265(method_26);
			BKE.HorizAxis.method_87().method_264(method_26);
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_87() != null)
		{
			BKE.VertAxis.method_87().method_265(method_26);
			BKE.VertAxis.method_87().method_264(method_26);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_87() != null)
		{
			BKE.SliceAxis.method_87().method_265(method_26);
			BKE.SliceAxis.method_87().method_264(method_26);
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_88() != null)
		{
			BKE.HorizAxis.method_88().method_265(method_26);
			BKE.HorizAxis.method_88().method_264(method_26);
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_88() != null)
		{
			BKE.VertAxis.method_88().method_265(method_26);
			BKE.VertAxis.method_88().method_264(method_26);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_88() != null)
		{
			BKE.SliceAxis.method_88().method_265(method_26);
			BKE.SliceAxis.method_88().method_264(method_26);
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_89() != null)
		{
			BKE.HorizAxis.method_89().method_265(method_26);
			BKE.HorizAxis.method_89().method_264(method_26);
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_89() != null)
		{
			BKE.VertAxis.method_89().method_265(method_26);
			BKE.VertAxis.method_89().method_264(method_26);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_89() != null)
		{
			BKE.SliceAxis.method_89().method_265(method_26);
			BKE.SliceAxis.method_89().method_264(method_26);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_91() != null)
		{
			BKE.SliceAxis.method_91().method_265(method_26);
			BKE.SliceAxis.method_91().method_264(method_26);
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_90() != null)
		{
			BKE.HorizAxis.method_90().method_265(method_21);
			BKE.HorizAxis.method_90().method_264(method_21);
			BKf = BKE.HorizAxis.method_92();
			if (BKe != null && BKe.HorizAxis != null && BKe.HorizAxis.method_90() != null)
			{
				BKH = BKe.HorizAxis.method_92();
			}
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_90() != null)
		{
			BKE.VertAxis.method_90().method_265(method_21);
			BKE.VertAxis.method_90().method_264(method_21);
			BKG = BKE.VertAxis.method_92();
			if (BKe != null && BKe.VertAxis != null && BKe.VertAxis.method_90() != null)
			{
				BKh = BKe.VertAxis.method_92();
			}
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_90() != null)
		{
			BKE.SliceAxis.method_90().method_265(method_21);
			BKE.SliceAxis.method_90().method_264(method_21);
			BKg = BKE.SliceAxis.method_92();
			if (BKg != null)
			{
				BKg.method_265(method_23);
				BKg.method_264(method_23);
			}
			if (BKe != null && BKe.SliceAxis != null && BKe.SliceAxis.method_90() != null)
			{
				BKI = BKe.SliceAxis.method_92();
			}
		}
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		bool flag = ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ);
		if (!flag && BKE != null)
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG && BKe != null)
			{
				BuN = BKe.GetSelectionRangeString(BKH, BKh);
			}
			else
			{
				BuN = BKE.GetSelectionRangeString(BKf, BKG);
			}
			method_26(null, null);
			Bum.Width = 100;
			Bum.Height = 50;
			Bum.Left = Width - 5 - Bum.Width;
			Bum.Top = 10;
			if (!Controls.Contains(Bum))
			{
				Controls.Add(Bum);
			}
			Bum.Invalidate();
			Invalidate();
		}
	}

	[SpecialName]
	internal void method_14(bool bool_0)
	{
		if (BuM != bool_0)
		{
			BuM = bool_0;
			UpdateLayout(resizingOnly: false);
		}
	}

	private Color method_15(int int_3, Setting setting_0)
	{
		if (TableAxis.smethod_4(int_3, setting_0))
		{
			return Color.Red;
		}
		return Form23.color_12;
	}

	private void method_16(Graphics graphics_0)
	{
		bool flag2;
		bool flag = (flag2 = BKE.SlicesEnabled());
		if (BKe != null)
		{
			flag = BKe.SlicesEnabled();
		}
		if (flag2 | flag)
		{
			if (BuU != null)
			{
				BuU.Enabled = true;
			}
			if (BuM)
			{
				Table table;
				Setting setting;
				if (Form23.enum60_0 == Form23.Enum60.BpG)
				{
					table = BKe;
					setting = BKI;
				}
				else
				{
					table = BKE;
					setting = BKg;
				}
				if (table == null)
				{
					return;
				}
				if (!BKj.Visible)
				{
					BKj.Visible = true;
				}
				int num = table.SliceCount();
				int num2 = Height - (BKj.Height + 2);
				if (BKj.Top != num2)
				{
					BKj.Top = num2;
				}
				if (BKj.Left != 8)
				{
					BKj.Left = 8;
				}
				int num3 = Width - 10 - BKj.Left;
				if (BKj.Width != num3)
				{
					BKj.Width = num3;
				}
				if (BKj.BWB != num - 1)
				{
					BKj.BWB = num - 1;
				}
				if (table.UserSliceIndex > BKj.BWB)
				{
					table.UserSliceIndex = BKj.BWB;
				}
				if (BKj.BWb != table.UserSliceIndex)
				{
					BKj.BWb = table.UserSliceIndex;
				}
				if (!Controls.Contains(BKj))
				{
					Controls.Add(BKj);
				}
				int num4 = 0;
				if (setting != null)
				{
					num4 = setting.method_231();
				}
				BKj.Bvx.Clear();
				for (int i = 0; i < num; i++)
				{
					BKj.Bvx.Add(new Control1.Class66());
					int int_ = table.SliceAxis.method_89().method_258(i);
					string text = ((setting == null) ? string.Empty : setting.method_253(int_).DisplayValueString);
					BKj.Bvx[i].bat = text;
					if (BKe == null)
					{
						BKj.Bvx[i].baU = method_15(int_, BKg);
					}
					else if (!BKi && !BKJ)
					{
						if (table == BKE && BKe.SliceAxis.method_96(int_, text, num4) == -1)
						{
							BKj.Bvx[i].baU = Form23.color_9;
						}
						else if (table == BKe && BKE.SliceAxis.method_96(int_, text, num4) == -1)
						{
							BKj.Bvx[i].baU = Form23.color_9;
						}
						else
						{
							BKj.Bvx[i].baU = method_15(int_, BKg);
						}
					}
					else
					{
						BKj.Bvx[i].baU = Form23.color_12;
					}
				}
				if (Form23.enum60_0 == Form23.Enum60.BpG)
				{
					BKj.BWC.Visible = false;
				}
				else if (flag2 && BKE.SliceAxis.method_90() != null)
				{
					if (BKg != null)
					{
						BKj.BWC.Visible = !BKg.method_35() || !PortFunction.smethod_52(BKg);
					}
					else
					{
						BKj.BWC.Visible = false;
					}
				}
				else
				{
					BKj.BWC.Visible = false;
				}
				BKj.Invalidate();
			}
			else if (BKj.Visible)
			{
				BKj.Visible = false;
			}
		}
		else
		{
			if (BuU != null)
			{
				BuU.Enabled = false;
			}
			if (BKj.Visible)
			{
				BKj.Visible = false;
			}
			if (BKE.UserSliceIndex != 0)
			{
				BKE.UserSliceIndex = 0;
			}
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		UpdateLayout(resizingOnly: false);
	}

	private void method_18(object sender, EventArgs e)
	{
		UpdateLayout(resizingOnly: false);
	}

	private void method_19(object sender, EventArgs e)
	{
		method_13();
		UpdateLayout(resizingOnly: false);
	}

	private void method_20(object sender, EventArgs e)
	{
		method_13();
		UpdateLayout(resizingOnly: false);
	}

	private void method_21(object sender, EventArgs e)
	{
		method_13();
		UpdateLayout(resizingOnly: false);
	}

	private void method_22(object sender, EventArgs e)
	{
		if (method_0())
		{
			Invalidate(new Rectangle(0, 0, Width, 85));
		}
	}

	private void method_23(object sender, EventArgs e)
	{
		if (method_0() && BKj != null && BKj.Visible)
		{
			BKj.Invalidate();
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void method_25(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void method_26(object sender, EventArgs e)
	{
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		Bun = table.GetCellValueString();
		try
		{
			using Graphics graphics_ = CreateGraphics();
			method_16(graphics_);
		}
		catch
		{
		}
		if (method_0())
		{
			Invalidate();
		}
	}

	private void method_27(Table table_0)
	{
		if (table_0.UserZoomLevel != 1 && table_0.HorizVertIndexPerUserSelectedCell.Count != 0)
		{
			int num = int.MaxValue;
			int num2 = int.MinValue;
			foreach (Point item in table_0.HorizVertIndexPerUserSelectedCell)
			{
				num = Math.Min(num, item.X);
				num2 = Math.Max(num2, item.X);
			}
			Buo = (num + num2) / 2;
		}
		else
		{
			Buo = -1;
		}
	}

	private void method_28(Table table_0, out int[] int_3, out float[] float_0, out int int_4, out int int_5)
	{
		if (Buo == -1)
		{
			method_27(table_0);
		}
		int num = table_0.HorizAxisCount();
		int[] array = new int[num];
		float[] array2 = new float[num];
		int num2 = int.MaxValue;
		float num3 = 0f;
		int num4 = table_0.HorizAxis.method_89().method_258(0);
		int num5 = table_0.HorizAxis.method_89().method_258(num - 1);
		for (int i = 0; i < num; i++)
		{
			int num6 = (array[i] = table_0.HorizAxis.method_89().method_258(i));
			if (num5 - num4 == 0)
			{
				array2[i] = 75f;
			}
			else
			{
				array2[i] = 75f + (float)((num6 - num4) * (Width - 105)) / (float)(num5 - num4);
			}
			if (i != 0)
			{
				num2 = Math.Min(num2, (int)array2[i] - (int)num3);
			}
			num3 = array2[i];
		}
		if (table_0.UserZoomLevel != 1 && Buo != -1 && num > 8)
		{
			int num7 = (75 + (Width - 30)) / 2;
			float num8 = array2[Buo] - (float)num7;
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] -= num8;
			}
			num3 = 0f;
			int num9 = int.MaxValue;
			int num10 = (Width - 30 - 75) / table_0.UserZoomLevel;
			int num11 = num7 - num10 / 2;
			int num12 = num7 + num10 / 2;
			int_4 = -1;
			List<int> list = new List<int>();
			List<float> list2 = new List<float>();
			for (int k = 0; k < array2.Length; k++)
			{
				if (array2[k] > (float)num11 && array2[k] < (float)num12)
				{
					list.Add(array[k]);
					float num13 = 75f + (array2[k] - (float)num11) * (float)table_0.UserZoomLevel;
					list2.Add(num13);
					if (int_4 == -1)
					{
						int_4 = k;
					}
					if (list2.Count > 1)
					{
						num9 = Math.Min(num9, (int)num13 - (int)num3);
					}
					num3 = num13;
				}
			}
			if (int_4 != -1)
			{
				int_3 = list.ToArray();
				float_0 = list2.ToArray();
				int_5 = num9;
			}
			else
			{
				int_3 = array;
				float_0 = array2;
				int_4 = 0;
				int_5 = num2;
			}
		}
		else
		{
			int_3 = array;
			float_0 = array2;
			int_4 = 0;
			int_5 = num2;
		}
	}

	private int method_29()
	{
		if (BKj != null && BKj.Visible)
		{
			return BKj.Height + 50;
		}
		return 50;
	}

	private void Class102_Paint(object sender, PaintEventArgs e)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			Table table;
			Setting setting;
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				table = BKe;
				setting = BKH;
			}
			else
			{
				table = BKE;
				setting = BKf;
			}
			if (table == null)
			{
				return;
			}
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			int num = table.HorizAxisCount();
			int num2 = table.VertAxisCount();
			int num3 = table.SliceCount();
			method_30(graphics, table);
			if (e.ClipRectangle.Top != 0 || e.ClipRectangle.Height > 85)
			{
				Font font = new Font(Font.FontFamily, 8f);
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Far;
				StringFormat stringFormat2 = new StringFormat();
				stringFormat2.Alignment = StringAlignment.Center;
				if (!table.HorizAxisEnabled() && !table.VertAxisEnabled())
				{
					font.Dispose();
					stringFormat.Dispose();
					stringFormat2.Dispose();
					return;
				}
				int num4 = method_29();
				int num5 = Height - num4;
				int num6 = (num5 - 94) / 15;
				if (num6 <= 1)
				{
					font.Dispose();
					stringFormat.Dispose();
					stringFormat2.Dispose();
					return;
				}
				float num7 = ((float)Height - (float)(94 + num4)) / (float)(num6 - 1);
				method_28(table, out var int_, out var float_, out var int_2, out var int_3);
				int num8 = int.MaxValue;
				int num9 = int.MinValue;
				int num10 = int.MaxValue;
				int num11 = int.MinValue;
				for (int i = 0; i < num3; i++)
				{
					for (int j = 0; j < num2; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num12 = ((!table.SwapColumnsAndRows) ? table.TableDataSetting.method_257(k, j, i) : table.TableDataSetting.method_257(j, k, i));
							if (num12 > num9)
							{
								num9 = num12;
							}
							if (num12 < num8)
							{
								num8 = num12;
							}
							if (k >= int_2 && k < int_2 + int_.Length)
							{
								if (num12 > num11)
								{
									num11 = num12;
								}
								if (num12 < num10)
								{
									num10 = num12;
								}
							}
						}
					}
				}
				int num13 = ((num10 != num11) ? (num5 - (num5 - 94) * -num10 / (num11 - num10)) : num5);
				Brush brush = Brushes.Black;
				switch (Form23.enum62_0)
				{
				case Form23.Enum62.Bqg:
					brush = Brushes.White;
					break;
				case Form23.Enum62.BqH:
					brush = Brushes.White;
					break;
				case Form23.Enum62.BqG:
				case Form23.Enum62.Bqh:
					brush = Brushes.Black;
					break;
				}
				Pen pen = Pens.LightGray;
				switch (Form23.enum62_0)
				{
				case Form23.Enum62.Bqg:
					pen = Pens.Gray;
					break;
				case Form23.Enum62.BqH:
					pen = Pens.Gray;
					break;
				case Form23.Enum62.BqG:
				case Form23.Enum62.Bqh:
					pen = Pens.LightGray;
					break;
				}
				int num14 = table.TableDataSetting.method_231();
				for (int l = 0; l < num6; l++)
				{
					int num15;
					if (l != 0)
					{
						num15 = ((l != num6 - 1) ? (num10 + (num11 - num10) * l / (num6 - 1)) : num11);
					}
					else
					{
						num15 = num10;
					}
					string s = Class233.smethod_29(num15, num14);
					float num16 = (float)num5 - num7 * (float)l;
					graphics.DrawString(s, font, brush, 60f, num16 - 7f, stringFormat);
					graphics.DrawLine(pen, 65f, num16, Width - 10, num16);
				}
				pen = Pens.Black;
				switch (Form23.enum62_0)
				{
				case Form23.Enum62.Bqg:
					pen = Pens.White;
					break;
				case Form23.Enum62.BqH:
					pen = Pens.White;
					break;
				case Form23.Enum62.BqG:
				case Form23.Enum62.Bqh:
					pen = Pens.Black;
					break;
				}
				graphics.DrawLine(pen, 65, 94, 65, num5);
				if (num13 > 94 && num13 < num5)
				{
					graphics.DrawLine(pen, 65, num13, Width - 10, num13);
				}
				if (table.HorizAxisEnabled())
				{
					string text = string.Empty;
					if (setting.method_231() != 0 && setting.method_231() != 82)
					{
						text = Class333.smethod_497() + Class233.smethod_35(setting.method_232(), setting.method_231(), bool_0: false, 0) + Class333.smethod_9();
					}
					string text2 = setting.method_18();
					string text3 = (string.IsNullOrWhiteSpace(text2) ? setting.method_60(Enum96.aYt) : text2);
					graphics.DrawString(text3 + text, font, brush, 65 + (Width - 10 - 65) / 2, Height - num4 + 30, stringFormat2);
				}
				method_31(graphics, table, ref pen, brush, font, stringFormat2, num4, num5, num13, num2, setting, int_2, int_, float_, int_3, num10, num11, num8, num9);
				font.Dispose();
				stringFormat.Dispose();
				stringFormat2.Dispose();
				if (BuP && Buq != Rectangle.Empty)
				{
					graphics.DrawRectangle(Pens.DodgerBlue, Buq);
				}
			}
		}
		catch
		{
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.BFS(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
	}

	private void method_30(Graphics graphics_0, Table table_0)
	{
		Color color = ((!BKE.method_35()) ? Color.Gray : Form23.color_12);
		using SolidBrush brush = new SolidBrush(color);
		using Font font = new Font(Font.FontFamily, 10f);
		int num = table_0.method_231();
		string text = table_0.method_18();
		string s = (string.IsNullOrWhiteSpace(text) ? table_0.method_60(Enum96.aYt) : text);
		if (Focused)
		{
			using Font font2 = new Font(Font.FontFamily, 10f, FontStyle.Bold);
			graphics_0.DrawString(s, font2, brush, 8f, 8f);
		}
		else
		{
			graphics_0.DrawString(s, font, brush, 8f, 8f);
		}
		graphics_0.DrawString(BuN, font, brush, 8f, 27f);
		graphics_0.DrawString(Bun, font, brush, 8f, 46f);
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			string text2 = string.Empty;
			if (num != 0 && num != 82)
			{
				text2 = Class333.smethod_325() + Class233.smethod_35(table_0.method_232(), num, bool_0: false, 0);
			}
			if ((!Form23.smethod_28(BKD.aXc, bool_53: true) || Form23.smethod_80()) && !Form23.smethod_84(table_0.method_64()))
			{
				graphics_0.DrawString(Class333.BFs() + text2, font, brush, 8f, 65f);
				return;
			}
			(string, string, bool) tuple = BKE.method_252();
			graphics_0.DrawString(Class333.BFT() + tuple.Item1 + (tuple.Item3 ? string.Empty : text2), font, brush, 8f, 65f);
		}
	}

	private void method_31(Graphics graphics_0, Table table_0, ref Pen pen_0, Brush brush_0, Font font_0, StringFormat stringFormat_0, int int_3, int int_4, int int_5, int int_6, Setting setting_0, int int_7, int[] int_8, float[] float_0, int int_9, int int_10, int int_11, int int_12, int int_13)
	{
		int num = 0;
		if (table_0.HorizAxisEnabled() && setting_0 != null)
		{
			num = setting_0.method_231();
		}
		int userSliceIndex = table_0.UserSliceIndex;
		int num2 = Math.Max(Math.Min(int_9 - 2, 20), 2);
		bool flag = false;
		int num3 = Form23.int_45 * 255 / 100;
		int num4 = Form23.int_44 * 255 / 100;
		int num5 = Form23.int_46 * 255 / 100;
		int num6 = Form23.int_47 * 255 / 100;
		Setting setting = null;
		Setting setting2 = null;
		Setting setting3 = null;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		if (BKD.awo != null && !table_0.SwapColumnsAndRows)
		{
			setting = BKD.awo.method_2(table_0.method_64());
			setting2 = BKD.awo.method_3(table_0.method_64());
			setting3 = BKD.awo.method_4(table_0.method_64());
			if (setting != null && setting2 != null && setting3 != null)
			{
				num7 = setting.method_256();
				num8 = setting2.method_256();
				num9 = setting3.method_256();
			}
		}
		for (int i = 0; i < int_6; i++)
		{
			float x = 0f;
			float y = 0f;
			float num10 = 0f;
			float x2 = 0f;
			float y2 = 0f;
			for (int j = 0; j < int_8.Length; j++)
			{
				int num11 = int_8[j];
				float num12 = float_0[j];
				if (table_0.HorizAxisEnabled() && i == 0)
				{
					switch (Form23.enum62_0)
					{
					case Form23.Enum62.Bqg:
						pen_0 = Pens.White;
						break;
					case Form23.Enum62.BqH:
						pen_0 = Pens.White;
						break;
					case Form23.Enum62.BqG:
					case Form23.Enum62.Bqh:
						pen_0 = Pens.Black;
						break;
					}
					graphics_0.DrawLine(pen_0, num12, Height - int_3 + 7, num12, Height - int_3 + 13);
					List<Setting.ListItems.Struct45> list = setting_0.method_102();
					bool flag2 = false;
					for (int k = 0; k < list.Count; k++)
					{
						if (list[k].bBv == num11)
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						string text = Class233.smethod_29(num11, num);
						float num13 = graphics_0.MeasureString(text, font_0).Width / 2f;
						if (j == 0 || num12 - num13 > num10 + 5f)
						{
							graphics_0.DrawString(text, font_0, brush_0, num12, Height - int_3 + 15, stringFormat_0);
							num10 = num12 + num13;
						}
					}
					if ((num7 != 0 || num8 != 0 || num9 != 0) && int_7 + j >= num8 && int_7 + j <= num9)
					{
						float num14;
						if (int_10 == int_11)
						{
							num14 = int_4;
						}
						else
						{
							int num15 = table_0.TableDataSetting.method_257(int_7 + j, num7, userSliceIndex);
							num14 = (float)int_4 - (float)((num15 - int_10) * (Height - (94 + int_3))) / (float)(int_11 - int_10);
						}
						if (int_7 + j != num8)
						{
							using Pen pen = new Pen(Color.Red, 1f);
							pen.DashStyle = DashStyle.Dash;
							graphics_0.DrawLine(pen, x2, y2, num12, num14);
						}
						x2 = num12;
						y2 = num14;
					}
				}
				bool flag3 = false;
				foreach (Point item in table_0.HorizVertIndexPerUserSelectedCell)
				{
					if (item.X == int_7 + j)
					{
						flag3 = true;
						break;
					}
				}
				int num16 = int.MaxValue;
				int num17 = int.MinValue;
				bool flag4 = false;
				foreach (Point item2 in BKE.HorizVertIndexPerUserSelectedCell)
				{
					num16 = Math.Min(num16, item2.Y);
					num17 = Math.Max(num17, item2.Y);
					if (item2.Y == i)
					{
						flag4 = true;
					}
				}
				if (!flag4)
				{
					continue;
				}
				table_0.GetColumnIndexAndRowIndex(int_7 + j, i, out var columnIndex, out var rowIndex);
				int num18 = table_0.TableDataSetting.method_257(columnIndex, rowIndex, userSliceIndex);
				Color color = Color.Black;
				if (table_0.ShowBars)
				{
					if (flag3)
					{
						color = Color.Blue;
					}
					else if (int_12 == int_13)
					{
						color = Class18.smethod_0(num6, num4, num3);
					}
					else
					{
						int num19;
						if (Form23.bool_50)
						{
							num19 = ((num5 >= num6) ? (num5 + (255 - (num5 - num6)) * (num18 - int_12) / (int_13 - int_12)) : (num5 - (255 - (num6 - num5)) * (num18 - int_12) / (int_13 - int_12)));
						}
						else
						{
							num19 = num5 + (num6 - num5) * (num18 - int_12) / (int_13 - int_12);
						}
						if (num19 < 0)
						{
							num19 += 255;
						}
						else if (num19 > 255)
						{
							num19 -= 255;
						}
						color = Class18.smethod_0(num19, num4, num3);
					}
				}
				float num20 = ((int_10 != int_11) ? ((float)int_4 - (float)((num18 - int_10) * (Height - (94 + int_3))) / (float)(int_11 - int_10)) : ((float)int_4));
				int num21 = (int)Math.Max(Math.Min(int_5, num20), 94f);
				int num22 = (int)Math.Min(Math.Max(int_5, num20), int_4);
				int num23 = num22 - num21;
				int num24 = (int)num12 - num2 / 2;
				int num25 = num24 + num2;
				bool flag5 = false;
				if (Form23.enum60_0 != Form23.Enum60.BpG && BuT.X != 0 && BuT.Y != 0 && !BuP && BuT.X >= num24 && BuT.X <= num25)
				{
					if (num20 < (float)int_5)
					{
						if (BuT.Y >= num21 - 5 && BuT.Y <= num21 + num23 / 2)
						{
							flag5 = true;
						}
					}
					else if (BuT.Y >= num22 - num23 / 2 && BuT.Y <= num22 + 5)
					{
						flag5 = true;
					}
				}
				if (table_0.ShowBars && !flag)
				{
					if (flag5 && BuR.Count == 0)
					{
						graphics_0.FillRectangle(Brushes.DodgerBlue, num24, num21, num2, num23);
					}
					else
					{
						using SolidBrush brush = new SolidBrush(color);
						graphics_0.FillRectangle(brush, num24, num21, num2, num23);
					}
					switch (Form23.enum62_0)
					{
					case Form23.Enum62.Bqg:
						pen_0 = Pens.White;
						break;
					case Form23.Enum62.BqH:
						pen_0 = Pens.White;
						break;
					case Form23.Enum62.BqG:
					case Form23.Enum62.Bqh:
						pen_0 = Pens.Black;
						break;
					}
					graphics_0.DrawRectangle(pen_0, num24, num21, num2, num23);
				}
				if (!flag)
				{
					if (flag3 && BuR.Count != 0)
					{
						graphics_0.FillEllipse(brush_0, num12 - 3f, BuR[int_7 + j] - 3, 6f, 6f);
					}
					else if (flag5)
					{
						graphics_0.FillEllipse(brush_0, num12 - 3f, num20 - 3f, 6f, 6f);
					}
					else if (flag3)
					{
						graphics_0.FillEllipse(Brushes.DodgerBlue, num12 - 3f, num20 - 3f, 6f, 6f);
					}
					else if (!table_0.ShowBars)
					{
						graphics_0.FillEllipse(brush_0, num12 - 2f, num20 - 2f, 4f, 4f);
					}
				}
				flag = j == int_8.Length - 1;
				if (j != 0)
				{
					Pen pen2 = pen_0;
					if (num17 - num16 + 1 > 1)
					{
						pen2 = (((num7 == 0 && num8 == 0 && num9 == 0) || int_7 + j < num8 || int_7 + j > num9) ? BuO[(i - num16) % BuO.Length] : BuO[1 + (i - num16) % (BuO.Length - 1)]);
					}
					graphics_0.DrawLine(pen2, x, y, num12, num20);
				}
				x = num12;
				y = num20;
			}
		}
	}

	private void method_32(int int_3, int int_4, bool bool_0)
	{
		if (int_3 == -1 || int_4 == -1)
		{
			return;
		}
		List<Point> list = new List<Point>();
		list.Add(new Point(int_3, int_4));
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			BKe.UserCurrentCellHorizVertIndex = new Point(int_3, int_4);
			BKe.HorizVertIndexPerUserSelectedCell = list;
			BKE.UserCurrentCellHorizVertIndex = new Point(int_3, int_4);
			BKE.HorizVertIndexPerUserSelectedCell = list;
		}
		else
		{
			BKE.UserCurrentCellHorizVertIndex = new Point(int_3, int_4);
			BKE.HorizVertIndexPerUserSelectedCell = list;
			if (BKe != null)
			{
				BKe.UserCurrentCellHorizVertIndex = new Point(int_3, int_4);
				BKe.HorizVertIndexPerUserSelectedCell = list;
			}
		}
		if (bool_0)
		{
			method_27(BKE);
		}
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		Focus();
		Bus = false;
		BuP = false;
		Buq = Rectangle.Empty;
		if (!BKD.method_4() || e.Button != MouseButtons.Left)
		{
			return;
		}
		int num = method_29();
		int num2 = Height - num;
		if (e.X <= 65 || e.X >= Width - 10 || e.Y <= 89 || e.Y >= num2)
		{
			base.MouseDownHandler(sender, e);
		}
		else
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG || BKE == null || !BKE.method_35() || !BKE.HorizAxisEnabled())
			{
				return;
			}
			for (int i = 1; i < BKE.HorizVertIndexPerUserSelectedCell.Count; i++)
			{
				if (BKE.HorizVertIndexPerUserSelectedCell[i].Y != BKE.HorizVertIndexPerUserSelectedCell[0].Y)
				{
					return;
				}
			}
			if (BKE.HorizVertIndexPerUserSelectedCell.Count == 0)
			{
				return;
			}
			Bup = e.X;
			BuQ = e.Y;
			BuP = true;
			Buq = new Rectangle(e.X, e.Y, 2, 2);
			BuS = e.Y;
			int num3 = BKE.VertAxisCount();
			int num4 = BKE.SliceCount();
			int y = BKE.HorizVertIndexPerUserSelectedCell[0].Y;
			int userSliceIndex = BKE.UserSliceIndex;
			method_28(BKE, out var int_, out var float_, out var int_2, out var int_3);
			int num5 = int.MaxValue;
			int num6 = int.MinValue;
			for (int j = 0; j < num4; j++)
			{
				for (int k = 0; k < num3; k++)
				{
					for (int l = int_2; l < int_2 + int_.Length; l++)
					{
						int num7 = ((!BKE.SwapColumnsAndRows) ? BKE.TableDataSetting.method_257(l, k, j) : BKE.TableDataSetting.method_257(k, l, j));
						if (num7 > num6)
						{
							num6 = num7;
						}
						if (num7 < num5)
						{
							num5 = num7;
						}
					}
				}
			}
			int num8 = Math.Max(Math.Min(int_3 - 2, 20), 2);
			int num9 = ((num5 != num6) ? (num2 - (num2 - 94) * -num5 / (num6 - num5)) : num2);
			BuR.Clear();
			Bur.Clear();
			List<int> list = new List<int>();
			for (int m = 0; m < int_.Length; m++)
			{
				BKE.GetColumnIndexAndRowIndex(int_2 + m, y, out var columnIndex, out var rowIndex);
				int num10 = BKE.TableDataSetting.method_257(columnIndex, rowIndex, userSliceIndex);
				float num11 = ((num5 != num6) ? ((float)num2 - (float)((num10 - num5) * (Height - (94 + num))) / (float)(num6 - num5)) : ((float)num2));
				int item = (int)Math.Max(Math.Min(num9, num11), 94f);
				int item2 = (int)Math.Min(Math.Max(num9, num11), num2);
				if (num11 < (float)num9)
				{
					list.Add(item);
				}
				else
				{
					list.Add(item2);
				}
			}
			for (int n = 0; n < int_.Length; n++)
			{
				float num12 = float_[n];
				BKE.GetColumnIndexAndRowIndex(int_2 + n, y, out var columnIndex2, out var rowIndex2);
				int num13 = BKE.TableDataSetting.method_257(columnIndex2, rowIndex2, userSliceIndex);
				float num14 = ((num5 != num6) ? ((float)num2 - (float)((num13 - num5) * (Height - (94 + num))) / (float)(num6 - num5)) : ((float)num2));
				int num15 = (int)Math.Max(Math.Min(num9, num14), 94f);
				int num16 = (int)Math.Min(Math.Max(num9, num14), num2);
				int num17 = num16 - num15;
				int num18 = (int)num12 - num8 / 2;
				int num19 = num18 + num8;
				if (e.X < num18 || e.X > num19)
				{
					continue;
				}
				bool flag = false;
				bool flag2 = false;
				if (num14 < (float)num9)
				{
					if (e.Y >= num15 - 5 && e.Y <= num15 + num17 / 2)
					{
						bool flag3 = false;
						foreach (Point item3 in BKE.HorizVertIndexPerUserSelectedCell)
						{
							if (item3.X == int_2 + n)
							{
								flag3 = true;
								break;
							}
						}
						if (flag2 = !flag3)
						{
							BuR.Add(int_2 + n, num15);
							Bur.Add(int_2 + n, num15);
						}
						else
						{
							foreach (Point item4 in BKE.HorizVertIndexPerUserSelectedCell)
							{
								BuR.Add(item4.X, list[item4.X - int_2]);
								Bur.Add(item4.X, list[item4.X - int_2]);
							}
							BuP = false;
						}
						flag = true;
					}
					else if (e.Y <= num16)
					{
						flag2 = true;
					}
				}
				else if (e.Y >= num16 - num17 / 2 && e.Y <= num16 + 5)
				{
					bool flag4 = false;
					foreach (Point item5 in BKE.HorizVertIndexPerUserSelectedCell)
					{
						if (item5.X == int_2 + n)
						{
							flag4 = true;
							break;
						}
					}
					if (flag2 = !flag4)
					{
						BuR.Add(int_2 + n, num16);
						Bur.Add(int_2 + n, num16);
					}
					else
					{
						foreach (Point item6 in BKE.HorizVertIndexPerUserSelectedCell)
						{
							BuR.Add(item6.X, list[item6.X - int_2]);
							Bur.Add(item6.X, list[item6.X - int_2]);
						}
						BuP = false;
					}
					flag = true;
				}
				else if (e.Y >= num15)
				{
					flag2 = true;
				}
				if (flag2)
				{
					if (flag)
					{
						BuP = false;
						Buq = Rectangle.Empty;
					}
					method_32(int_2 + n, BKE.HorizVertIndexPerUserSelectedCell[0].Y, bool_0: false);
				}
				if (flag)
				{
					MenuNode.smethod_2(BKD.awj, BKE.TableDataSetting.method_69())?.method_0().method_2(BKE.TableDataSetting.method_64());
				}
				Invalidate();
				break;
			}
			BringToFront();
		}
	}

	protected override void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		if (BuR.Count == 0 || Form23.enum60_0 == Form23.Enum60.BpG)
		{
			base.MouseMoveHandler(sender, e);
		}
		if (BKE != null && BKE.method_35() && BKE.HorizAxisEnabled())
		{
			int num = 1;
			while (true)
			{
				if (num < BKE.HorizVertIndexPerUserSelectedCell.Count)
				{
					if (BKE.HorizVertIndexPerUserSelectedCell[num].Y != BKE.HorizVertIndexPerUserSelectedCell[0].Y)
					{
						break;
					}
					num++;
					continue;
				}
				if (!BKD.method_4() || BKE.HorizVertIndexPerUserSelectedCell.Count == 0)
				{
					return;
				}
				if (!But.IsRunning)
				{
					But.Start();
				}
				else
				{
					if (But.ElapsedMilliseconds <= 50L)
					{
						return;
					}
					But.Restart();
					if (e.Button == MouseButtons.Left)
					{
						if (BuP)
						{
							Buq = new Rectangle(Math.Min(e.X, Bup), Math.Min(e.Y, BuQ), Math.Abs(e.X - Bup), Math.Abs(e.Y - BuQ));
							method_28(BKE, out var int_, out var float_, out var int_2, out var _);
							List<Point> list = new List<Point>();
							for (int i = 0; i < int_.Length; i++)
							{
								float num2 = float_[i];
								if (num2 >= (float)Buq.Left && num2 <= (float)Buq.Right)
								{
									list.Add(new Point(int_2 + i, BKE.HorizVertIndexPerUserSelectedCell[0].Y));
								}
							}
							if (list.Count != 0)
							{
								Point userCurrentCellHorizVertIndex = new Point(list[0].X, list[0].Y);
								if (Form23.enum60_0 == Form23.Enum60.BpG)
								{
									BKe.UserCurrentCellHorizVertIndex = userCurrentCellHorizVertIndex;
									BKe.HorizVertIndexPerUserSelectedCell = list;
									BKE.UserCurrentCellHorizVertIndex = userCurrentCellHorizVertIndex;
									BKE.HorizVertIndexPerUserSelectedCell = list;
								}
								else
								{
									BKE.UserCurrentCellHorizVertIndex = userCurrentCellHorizVertIndex;
									BKE.HorizVertIndexPerUserSelectedCell = list;
									if (BKe != null)
									{
										BKe.UserCurrentCellHorizVertIndex = userCurrentCellHorizVertIndex;
										BKe.HorizVertIndexPerUserSelectedCell = list;
									}
								}
							}
						}
						else if (BuR.Count != 0)
						{
							int num3 = e.Y - BuS;
							if (Bus || num3 != 0)
							{
								Bus = true;
								method_28(BKE, out var int_4, out var _, out var int_5, out var _);
								int num4 = BKE.VertAxisCount();
								int num5 = BKE.SliceCount();
								int num6 = int.MaxValue;
								int num7 = int.MinValue;
								for (int j = 0; j < num5; j++)
								{
									for (int k = 0; k < num4; k++)
									{
										for (int l = int_5; l < int_5 + int_4.Length; l++)
										{
											int num8 = ((!BKE.SwapColumnsAndRows) ? BKE.TableDataSetting.method_257(l, k, j) : BKE.TableDataSetting.method_257(k, l, j));
											if (num8 > num7)
											{
												num7 = num8;
											}
											if (num8 < num6)
											{
												num6 = num8;
											}
										}
									}
								}
								int num9 = BKE.method_228();
								int num10 = BKE.method_229();
								int y = BKE.HorizVertIndexPerUserSelectedCell[0].Y;
								int userSliceIndex = BKE.UserSliceIndex;
								int num11 = method_29();
								BKE.TableDataSetting.method_268();
								foreach (Point item in BKE.HorizVertIndexPerUserSelectedCell)
								{
									BuR[item.X] = Bur[item.X] + num3;
									int num12 = Height - num11;
									int num13 = num6 + (num12 - BuR[item.X]) * (num7 - num6) / (Height - (94 + num11));
									if (num13 >= num9 && num13 <= num10)
									{
										BKE.GetColumnIndexAndRowIndex(item.X, y, out var columnIndex, out var rowIndex);
										if ((!BKE.AllCellsOnFirstColumnMustBeZero || columnIndex != 0) && (!BKE.AllCellsOnFirstRowMustBeZero || rowIndex != 0))
										{
											BKE.TableDataSetting.method_273(columnIndex, rowIndex, userSliceIndex, num13, bool_0: true);
										}
									}
								}
								BKE.TableDataSetting.method_267(bool_0: true);
							}
						}
					}
					BuT.X = e.X;
					BuT.Y = e.Y;
					Invalidate();
				}
				return;
			}
			ref Point buT = ref BuT;
			BuT.Y = 0;
			buT.X = 0;
			base.MouseMoveHandler(sender, e);
		}
		else
		{
			ref Point buT2 = ref BuT;
			BuT.Y = 0;
			buT2.X = 0;
			base.MouseMoveHandler(sender, e);
		}
	}

	protected override void MouseUpHandler(object sender, MouseEventArgs e)
	{
		base.MouseUpHandler(sender, e);
		if (!BKD.method_4() || BKE == null || !BKE.method_35())
		{
			return;
		}
		if (But.IsRunning)
		{
			But.Reset();
		}
		BuP = false;
		Buq = Rectangle.Empty;
		if (BuR.Count != 0)
		{
			if (Bus)
			{
				int num = method_29();
				int num2 = Height - num;
				int num3 = BKE.VertAxisCount();
				int num4 = BKE.SliceCount();
				method_28(BKE, out var int_, out var _, out var int_2, out var _);
				int num5 = int.MaxValue;
				int num6 = int.MinValue;
				for (int i = 0; i < num4; i++)
				{
					for (int j = 0; j < num3; j++)
					{
						for (int k = int_2; k < int_2 + int_.Length; k++)
						{
							int num7 = ((!BKE.SwapColumnsAndRows) ? BKE.TableDataSetting.method_257(k, j, i) : BKE.TableDataSetting.method_257(j, k, i));
							if (num7 > num6)
							{
								num6 = num7;
							}
							if (num7 < num5)
							{
								num5 = num7;
							}
						}
					}
				}
				int num8 = BKE.method_228();
				int num9 = BKE.method_229();
				int y = BKE.HorizVertIndexPerUserSelectedCell[0].Y;
				int userSliceIndex = BKE.UserSliceIndex;
				BKE.TableDataSetting.method_268();
				foreach (Point item in BKE.HorizVertIndexPerUserSelectedCell)
				{
					int num10 = num5 + (num2 - BuR[item.X]) * (num6 - num5) / (Height - (94 + num));
					if (num10 < num8 || num10 > num9)
					{
						continue;
					}
					BKE.GetColumnIndexAndRowIndex(item.X, y, out var columnIndex, out var rowIndex);
					if ((BKE.AllCellsOnFirstColumnMustBeZero && columnIndex == 0) || (BKE.AllCellsOnFirstRowMustBeZero && rowIndex == 0))
					{
						continue;
					}
					BKE.TableDataSetting.method_273(columnIndex, rowIndex, userSliceIndex, num10, bool_0: true);
					if (BKD.awo != null)
					{
						Setting setting = BKD.awo.method_2(BKE.method_64());
						if (setting != null && setting.method_256() == rowIndex)
						{
							BKD.awo.method_1(BKE.method_64());
						}
					}
				}
				BKE.TableDataSetting.method_267(bool_0: true);
				Form23.smethod_74(BKE.TableDataSetting.method_64());
			}
			MenuNode.smethod_2(BKD.awj, BKE.TableDataSetting.method_69())?.method_0().method_4();
			BuR.Clear();
			Bur.Clear();
		}
		Bus = false;
		method_27(BKE);
		Invalidate();
	}

	private void Class102_GotFocus(object sender, EventArgs e)
	{
		if (BKE != null)
		{
			if (BKE.HorizVertIndexPerUserSelectedCell.Count == 0)
			{
				BKE.UserCurrentCellHorizVertIndex = new Point(0, 0);
				BKE.HorizVertIndexPerUserSelectedCell.Add(new Point(0, 0));
			}
			Form23.smethod_12(this);
		}
		Invalidate();
	}

	private void Class102_LostFocus(object sender, EventArgs e)
	{
		Form23.smethod_13();
		Invalidate();
	}

	private void method_33(object sender, EventArgs e)
	{
		Enum65 @enum = (Form23.form23_0.control25_0.SelectedTab as Class130).method_0();
		int selectedIndex = Form23.form23_0.control25_0.SelectedIndex;
		if (@enum != Enum65.const_1 && Form23.form23_0.control25_0.method_5(selectedIndex) == this)
		{
			Form54.smethod_6(Form23.form23_0, Class333.BFt(), Class333.BFU(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Class30.smethod_0(this);
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_34(object sender, EventArgs e)
	{
		int num = Form46.smethod_0(Form23.form23_0, BKD);
		if (num != 0)
		{
			Setting setting = BKD.method_31(num);
			if (setting != null)
			{
				Form23.form23_0.control25_0.method_41(setting as Table, new Rectangle(Left, Top, Width, Height));
				method_33(null, null);
			}
		}
	}

	private void method_35(object sender, EventArgs e)
	{
		Form23.form23_0.control25_0.method_37(this);
	}

	internal override void vmethod_3(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || BKE == null || !BKE.method_35())
		{
			return;
		}
		Form51 form = new Form51(BKE);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			HashSet<DataIdAndAttrId> idsContained = BKE.GetIdsContained();
			BKD.method_42(idsContained);
			BKD.method_40(idsContained, BKd, Form23.hashSet_0);
			BKD.method_38(idsContained);
			Form23.form23_0.control4_0.method_14(bool_7: false, bool_8: true, bool_9: false, bool_10: false);
			Form23.smethod_43();
			Form23.form23_0.control4_0.method_39(bool_7: false);
			if (Form23.framework_0 != null)
			{
				Form23.form23_0.control4_0.method_40(bool_7: false);
			}
			method_13();
			UpdateLayout(resizingOnly: false);
			Focus();
		}
		form.Dispose();
	}

	private void method_36(object sender, EventArgs e)
	{
		if (BKE != null)
		{
			BKE.ShowBars = !BKE.ShowBars;
		}
	}

	private void method_37(object sender, EventArgs e)
	{
		if (BKE != null && BKe != null)
		{
			BKe.ShowBars = BKE.ShowBars;
		}
		Invalidate();
	}

	private void BuU_Click(object sender, EventArgs e)
	{
		method_14(!BuM);
	}

	private void method_38(object sender, EventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.BFu())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
				break;
			}
		}
	}

	private ContextMenuStrip method_39()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opened += method_38;
		if ((Form23.form23_0.control25_0.SelectedTab as Class130).method_0() == Enum65.const_1)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem.Text = Class333.BFV();
			toolStripMenuItem.Click += method_34;
			contextMenuStrip.Items.Add(toolStripMenuItem);
		}
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.BFv();
		toolStripMenuItem2.ShortcutKeyDisplayString = Class333.smethod_1285();
		toolStripMenuItem2.Click += method_35;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		if (BKD.method_4())
		{
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
			toolStripMenuItem3.Text = Class333.smethod_1570();
			toolStripMenuItem3.ShortcutKeys = Keys.F3;
			toolStripMenuItem3.Click += vmethod_3;
			contextMenuStrip.Items.Add(toolStripMenuItem3);
		}
		ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
		toolStripMenuItem4.Text = Class333.BFW();
		toolStripMenuItem4.Click += method_36;
		contextMenuStrip.Items.Add(toolStripMenuItem4);
		BuU = new ToolStripMenuItem();
		BuU.Text = Class333.BFw();
		BuU.Click += BuU_Click;
		contextMenuStrip.Items.Add(BuU);
		ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem();
		toolStripMenuItem5.Text = Class333.BFu();
		toolStripMenuItem5.Click += method_33;
		contextMenuStrip.Items.Add(toolStripMenuItem5);
		return contextMenuStrip;
	}

	internal void method_40(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BFX());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.BBi() + BKF);
		if (BKE != null)
		{
			list.Add(Class333.BBJ() + BKE.InvertRows);
			list.Add(Class333.BBj() + BKE.SwapColumnsAndRows);
			list.Add(Class333.BFx() + BKE.ShowBars);
		}
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_41(StreamReader streamReader_0)
	{
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.BBi()))
			{
				BKF = int.Parse(text.Substring(Class333.BBi().Length));
				if (BKD.method_31(BKF) != null)
				{
					vmethod_2(BKF);
				}
			}
			else if (text.Contains(Class333.BBK()))
			{
				BKF = int.Parse(text.Substring(text.IndexOf(Class333.BBK()) + Class333.BBK().Length));
				if (BKD.method_31(BKF) != null)
				{
					vmethod_2(BKF);
				}
			}
			else if (text.StartsWith(Class333.BBJ()))
			{
				if (BKE != null)
				{
					BKE.InvertRows = bool.Parse(text.Substring(Class333.BBJ().Length));
				}
			}
			else if (text.StartsWith(Class333.BBj()))
			{
				if (BKE != null)
				{
					BKE.SwapColumnsAndRows = bool.Parse(text.Substring(Class333.BBj().Length));
				}
			}
			else if (text.StartsWith(Class333.BFx()))
			{
				if (BKE != null)
				{
					BKE.ShowBars = bool.Parse(text.Substring(Class333.BFx().Length));
				}
			}
			else if (text.Contains(Class333.BFY()))
			{
				if (BKE != null)
				{
					BKE.ShowBars = bool.Parse(text.Substring(text.IndexOf(Class333.BFY()) + Class333.BFY().Length));
				}
			}
			else if (!text.Contains(Class333.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}

	private void method_42()
	{
		int currentHoriz = 0;
		int currentVert = 0;
		int currentSlice = 0;
		BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
		method_32(currentHoriz, currentVert, bool_0: true);
		BKE.UserSliceIndex = currentSlice;
	}

	private void method_43()
	{
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
			{
				BKE.TableDataSetting.method_268();
				BKE.LineariseLeftToRight(topSelectedVert, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
				BKE.TableDataSetting.method_267(bool_0: true);
				Invalidate();
			}
		}
		else if (leftSelectedHoriz == rightSelectedHoriz)
		{
			if (bottomSelectedVert - topSelectedVert + 1 >= 3)
			{
				BKE.TableDataSetting.method_268();
				BKE.LineariseTopToBottom(leftSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
				BKE.TableDataSetting.method_267(bool_0: true);
				Invalidate();
			}
		}
		else
		{
			BKE.TableDataSetting.method_268();
			BKE.LineariseRange(leftSelectedHoriz, rightSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
			BKE.TableDataSetting.method_267(bool_0: true);
			Invalidate();
		}
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
	}

	private void method_44()
	{
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
		{
			BKE.TableDataSetting.method_268();
			for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
			{
				BKE.LineariseLeftToRight(i, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
			}
			BKE.TableDataSetting.method_267(bool_0: true);
			Invalidate();
		}
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
	}

	private void method_45()
	{
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (bottomSelectedVert - topSelectedVert + 1 >= 3)
		{
			BKE.TableDataSetting.method_268();
			for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
			{
				BKE.LineariseTopToBottom(i, topSelectedVert, bottomSelectedVert, BKe);
			}
			BKE.TableDataSetting.method_267(bool_0: true);
			Invalidate();
		}
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
	}

	internal bool method_46(KeyEventArgs keyEventArgs_0)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return false;
		}
		if (!BKD.method_4())
		{
			return false;
		}
		if ((!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Prior) && keyEventArgs_0.KeyData != Keys.Prior && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Prior) && (!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Next) && keyEventArgs_0.KeyData != Keys.Next && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Next) && keyEventArgs_0.KeyData != Keys.OemOpenBrackets && keyEventArgs_0.KeyData != Keys.OemCloseBrackets && keyEventArgs_0.KeyData != Keys.OemSemicolon && keyEventArgs_0.KeyData != Keys.Oem7 && keyEventArgs_0.KeyData != Keys.Oemcomma && keyEventArgs_0.KeyData != Keys.OemPeriod)
		{
			return false;
		}
		if (!BKE.method_35())
		{
			return true;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.IncreaseOrDecreaseSelectedCellValues(keyEventArgs_0);
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
		return true;
	}

	protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs previewKeyDownEventArgs_0)
	{
		previewKeyDownEventArgs_0.IsInputKey = previewKeyDownEventArgs_0.KeyData == Keys.D || (previewKeyDownEventArgs_0.Control && previewKeyDownEventArgs_0.KeyCode == Keys.Prior) || (previewKeyDownEventArgs_0.Control && previewKeyDownEventArgs_0.KeyCode == Keys.Next) || (previewKeyDownEventArgs_0.Shift && previewKeyDownEventArgs_0.KeyCode == Keys.Prior) || (previewKeyDownEventArgs_0.Shift && previewKeyDownEventArgs_0.KeyCode == Keys.Next) || previewKeyDownEventArgs_0.KeyData == Keys.Prior || previewKeyDownEventArgs_0.KeyData == Keys.Next || previewKeyDownEventArgs_0.KeyData == Keys.OemOpenBrackets || previewKeyDownEventArgs_0.KeyData == Keys.OemCloseBrackets || previewKeyDownEventArgs_0.KeyData == Keys.OemSemicolon || previewKeyDownEventArgs_0.KeyData == Keys.Oem7 || previewKeyDownEventArgs_0.KeyData == Keys.Oemcomma || previewKeyDownEventArgs_0.KeyData == Keys.OemPeriod || previewKeyDownEventArgs_0.KeyData == Keys.Left || previewKeyDownEventArgs_0.KeyData == Keys.Up || previewKeyDownEventArgs_0.KeyData == Keys.Right || previewKeyDownEventArgs_0.KeyData == Keys.Down || previewKeyDownEventArgs_0.KeyData == (Keys.Left | Keys.Shift) || previewKeyDownEventArgs_0.KeyData == (Keys.Up | Keys.Shift) || previewKeyDownEventArgs_0.KeyData == (Keys.Right | Keys.Shift) || previewKeyDownEventArgs_0.KeyData == (Keys.Down | Keys.Shift) || previewKeyDownEventArgs_0.KeyData == (Keys.Left | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Up | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Right | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Down | Keys.Control) || (previewKeyDownEventArgs_0.Control && previewKeyDownEventArgs_0.KeyCode == Keys.Space) || previewKeyDownEventArgs_0.KeyData == Keys.Escape || previewKeyDownEventArgs_0.KeyData == Keys.F3 || previewKeyDownEventArgs_0.KeyData == (Keys.Z | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Y | Keys.Control) || previewKeyDownEventArgs_0.KeyData == Keys.L || previewKeyDownEventArgs_0.KeyData == Keys.H || previewKeyDownEventArgs_0.KeyData == Keys.V || previewKeyDownEventArgs_0.KeyData == Keys.Space || previewKeyDownEventArgs_0.KeyData == (Keys.C | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.V | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Left | Keys.Shift | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Up | Keys.Shift | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Right | Keys.Shift | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Down | Keys.Shift | Keys.Control);
	}

	protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		if (BKe != null && (BKi || BKJ) && Form23.enum60_0 == Form23.Enum60.BpF)
		{
			return;
		}
		if (keyEventArgs_0.KeyData == Keys.D)
		{
			method_35(null, null);
		}
		if ((BKE != null && BKE.HorizVertIndexPerUserSelectedCell.Count == 0) || !BKD.method_4() || (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Prior) || (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Next) || (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Prior) || (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Next) || keyEventArgs_0.KeyData == Keys.Prior || keyEventArgs_0.KeyData == Keys.Next || keyEventArgs_0.KeyData == Keys.OemOpenBrackets || keyEventArgs_0.KeyData == Keys.OemCloseBrackets || keyEventArgs_0.KeyData == Keys.OemSemicolon || keyEventArgs_0.KeyData == Keys.Oem7 || keyEventArgs_0.KeyData == Keys.Oemcomma || keyEventArgs_0.KeyData == Keys.OemPeriod || BKE == null)
		{
			return;
		}
		if (keyEventArgs_0.KeyData == Keys.Left)
		{
			BKE.MoveSelectionLeft(BKe);
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == Keys.Up)
		{
			BKE.MoveSelectionUp(BKe);
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == Keys.Right)
		{
			BKE.MoveSelectionRight(BKe);
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == Keys.Down)
		{
			BKE.MoveSelectionDown(BKe);
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Shift))
		{
			BKE.IncreaseSelectionSizeOnLeft(BKe);
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Up | Keys.Shift))
		{
			BKE.IncreaseSelectionSizeOnTop(BKe);
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Shift))
		{
			BKE.IncreaseSelectionSizeOnRight(BKe);
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Down | Keys.Shift))
		{
			BKE.IncreaseSelectionSizeOnBottom(BKe);
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Control))
		{
			BKE.DecreaseSelectionSizeOnRight();
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Up | Keys.Control))
		{
			BKE.DecreaseSelectionSizeOnBottom();
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Control))
		{
			BKE.DecreaseSelectionSizeOnLeft();
			method_27(BKE);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Down | Keys.Control))
		{
			BKE.DecreaseSelectionSizeOnTop();
			method_27(BKE);
		}
		else if ((keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Space) || keyEventArgs_0.KeyData == Keys.Escape)
		{
			method_32(BKE.UserCurrentCellHorizVertIndex.X, BKE.UserCurrentCellHorizVertIndex.Y, bool_0: true);
		}
		else
		{
			if (!BKE.method_35() || Form23.enum60_0 == Form23.Enum60.BpG)
			{
				return;
			}
			if (keyEventArgs_0.KeyData == Keys.F3)
			{
				vmethod_3(null, null);
			}
			else if (keyEventArgs_0.KeyData == (Keys.Z | Keys.Control))
			{
				Form23.form23_0.toolStripButton_2_Click(null, null);
			}
			else if (keyEventArgs_0.KeyData == (Keys.Y | Keys.Control))
			{
				Form23.form23_0.toolStripButton_3_Click(null, null);
			}
			else if (keyEventArgs_0.KeyData == Keys.L)
			{
				method_43();
			}
			else if (keyEventArgs_0.KeyData == Keys.H)
			{
				method_44();
			}
			else if (keyEventArgs_0.KeyData == Keys.V)
			{
				method_45();
			}
			else if (keyEventArgs_0.KeyData == Keys.Space)
			{
				method_42();
			}
			else if (keyEventArgs_0.KeyData == (Keys.C | Keys.Control))
			{
				BKE.CopyCellValuesToClipboard(BKe);
			}
			else if (keyEventArgs_0.KeyData == (Keys.V | Keys.Control))
			{
				BKE.method_298(BKe, null);
			}
			else if (BKe != null || (!BKi && !BKJ) || Form23.enum60_0 != Form23.Enum60.BpF)
			{
				if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Shift | Keys.Control))
				{
					BKE.method_294(BKe, null);
					method_27(BKE);
				}
				else if (keyEventArgs_0.KeyData == (Keys.Up | Keys.Shift | Keys.Control))
				{
					BKE.method_296(BKe, null);
					method_27(BKE);
				}
				else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Shift | Keys.Control))
				{
					BKE.method_295(BKe, null);
					method_27(BKE);
				}
				else if (keyEventArgs_0.KeyData == (Keys.Down | Keys.Shift | Keys.Control))
				{
					BKE.method_297(BKe, null);
					method_27(BKE);
				}
			}
		}
	}

	private void method_47(object sender, EventArgs e)
	{
		if (BKE != null)
		{
			Bum.method_1(BKE.UserZoomLevel);
			Bum.Invalidate();
			Invalidate();
		}
	}
}
