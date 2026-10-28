using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns4;
using ns5;

namespace ns0;

internal class Class76 : Panel
{
	private Framework framework_0;

	private DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_0;

	private Setting setting_0;

	private Setting setting_1;

	private Setting setting_2;

	internal Class76(Framework framework_1, DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_1, Setting setting_3, Setting setting_4, Setting setting_5)
	{
		framework_0 = framework_1;
		dataGridViewWithThemedScrollBars_0 = dataGridViewWithThemedScrollBars_1;
		setting_0 = setting_3;
		setting_1 = setting_4;
		setting_2 = setting_5;
		DoubleBuffered = true;
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.Graphics;
		int num = setting_2.method_256();
		Brush brush = ((Form23.enum62_0 == Form23.Enum62.BqG || Form23.enum62_0 == Form23.Enum62.Bqh) ? new SolidBrush(Color.Gray) : new SolidBrush(Form23.color_10));
		graphics.FillRectangle(brush, 0, 0, Width, Height);
		brush.Dispose();
		if (num == 0)
		{
			return;
		}
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		Font font = new Font(Font.FontFamily, 9f, FontStyle.Bold);
		StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Far;
		StringFormat stringFormat2 = new StringFormat();
		stringFormat2.Alignment = StringAlignment.Center;
		Pen pen = new Pen(Color.White, 3f);
		int num2 = int.MaxValue;
		int num3 = int.MinValue;
		for (int i = 0; i < num; i++)
		{
			int num4 = setting_1.method_258(i);
			if (num4 < num2)
			{
				num2 = num4;
			}
			if (num4 > num3)
			{
				num3 = num4;
			}
		}
		int num5 = 18;
		if (num2 == 0 && num3 == 1000)
		{
			num5 = 11;
		}
		float num6 = ((float)Height - 50f) / (float)(num5 - 1);
		int int_ = setting_1.method_231();
		for (int j = 0; j < num5; j++)
		{
			int int_2;
			if (j != 0)
			{
				int_2 = ((j != num5 - 1) ? (num2 + (num3 - num2) * j / (num5 - 1)) : num3);
			}
			else
			{
				int_2 = num2;
			}
			string s = Class233.smethod_29(int_2, int_);
			float num7 = (float)(Height - 35) - num6 * (float)j;
			graphics.DrawString(s, font, Brushes.White, 60f, num7 - 7f, stringFormat);
			graphics.DrawLine(Pens.LightGray, 65f, num7, Width - 10, num7);
		}
		graphics.DrawLine(Pens.White, 65, 15, 65, Height - 35);
		int num8 = setting_0.method_258(0);
		int num9 = setting_0.method_258(num - 1);
		int int_3 = setting_0.method_231();
		float x = 0f;
		float y = 0f;
		float num10 = 0f;
		for (int k = 0; k < num; k++)
		{
			int num11 = setting_0.method_258(k);
			string text = Class233.smethod_29(num11, int_3);
			float num12 = ((num9 - num8 != 0) ? (75f + (float)((num11 - num8) * (Width - 105)) / (float)(num9 - num8)) : 75f);
			graphics.DrawLine(Pens.White, num12, Height - 28, num12, Height - 22);
			float num13 = graphics.MeasureString(text, font).Width / 2f;
			if (k == 0 || num12 - num13 > num10 + 5f)
			{
				graphics.DrawString(text, font, Brushes.White, num12, Height - 20, stringFormat2);
				num10 = num12 + num13;
			}
			int num14 = setting_1.method_258(k);
			float num15 = ((num3 - num2 != 0) ? ((float)(Height - 35) - (float)((num14 - num2) * (Height - 50)) / (float)(num3 - num2)) : ((float)(Height - 35)));
			if ((dataGridViewWithThemedScrollBars_0.Rows[0].Cells.Count > k && dataGridViewWithThemedScrollBars_0.Rows[0].Cells[k].Selected) || (dataGridViewWithThemedScrollBars_0.Rows[1].Cells.Count > k && dataGridViewWithThemedScrollBars_0.Rows[1].Cells[k].Selected))
			{
				graphics.DrawEllipse(pen, num12 - 4f, num15 - 4f, 8f, 8f);
			}
			else
			{
				graphics.DrawEllipse(pen, num12 - 2f, num15 - 2f, 4f, 4f);
			}
			if (k != 0)
			{
				graphics.DrawLine(Pens.White, x, y, num12, num15);
			}
			x = num12;
			y = num15;
		}
		font.Dispose();
		pen.Dispose();
	}
}
