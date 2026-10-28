using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns4;
using ns7;

namespace ns2;

internal class Class166 : ToolStripDropDownButton
{
	private bool bool_0;

	private float float_0;

	protected override void OnMouseEnter(EventArgs eventArgs_0)
	{
		base.OnMouseEnter(eventArgs_0);
		bool_0 = true;
		Invalidate();
	}

	protected override void OnMouseLeave(EventArgs eventArgs_0)
	{
		base.OnMouseLeave(eventArgs_0);
		bool_0 = false;
		Invalidate();
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		Rectangle rect = new Rectangle(0, 0, Width, Height);
		if (bool_0)
		{
			using (SolidBrush brush = new SolidBrush(Color.FromArgb(194, 224, 255)))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, rect);
			}
			using Pen pen = new Pen(Color.FromArgb(51, 153, 255), 2f);
			paintEventArgs_0.Graphics.DrawRectangle(pen, rect);
		}
		else
		{
			using SolidBrush brush2 = new SolidBrush(BackColor);
			paintEventArgs_0.Graphics.FillRectangle(brush2, rect);
		}
		bool flag;
		bool flag2;
		string text;
		string text2;
		Color color;
		if ((Form23.int_0 & 0x400) != 0)
		{
			flag = false;
			flag2 = true;
			text = Class333.smethod_687();
			text2 = Class333.smethod_688();
			color = Color.FromArgb(96, 96, 255);
		}
		else if (Enabled)
		{
			int num = 0;
			if (Form23.framework_1 != null)
			{
				Setting setting = Form23.framework_1.method_31(9497);
				if (setting != null)
				{
					num = setting.method_256();
				}
			}
			if (num != 0 && !Form10.smethod_26() && Form10.smethod_27() != -1 && (Form23.int_0 & 0x100) == 0 && (Form23.int_0 & 0x200) == 0)
			{
				flag = true;
				flag2 = false;
				int num2 = Form10.smethod_29() - Form10.smethod_28();
				if (num2 <= 0)
				{
					num2 += num;
				}
				int num3 = (int)(Form10.smethod_30() * 100L / num2);
				text = Form10.smethod_27().ToString();
				text2 = num3 + Class333.smethod_681();
				color = Color.FromArgb((int)(Form23.float_4 * 255f), (int)(Form23.float_5 * 255f), (int)(Form23.float_6 * 255f));
			}
			else
			{
				flag = false;
				if (Form23.framework_1 != null && Form23.smethod_28(Form23.framework_1.aXc, bool_53: true) && !Form23.smethod_80() && (Form23.int_0 & 0x100) == 0)
				{
					Setting setting2 = Form23.framework_1.method_31(9501);
					Setting setting3 = Form23.framework_1.method_31(9500);
					if (setting2 != null && setting3 != null)
					{
						int num4 = setting2.method_256();
						int num5 = setting3.method_256();
						if (num5 == 12)
						{
							flag2 = false;
							text = null;
							text2 = null;
							color = Color.Orange;
						}
						else if (num4 != -1 && num5 != 0)
						{
							flag2 = true;
							text = Class333.smethod_688();
							text2 = num4.ToString();
							color = Color.FromArgb(96, 96, 255);
						}
						else
						{
							flag2 = false;
							text = null;
							text2 = null;
							color = Color.FromArgb((int)(Form23.float_4 * 255f), (int)(Form23.float_5 * 255f), (int)(Form23.float_6 * 255f));
						}
					}
					else
					{
						flag2 = false;
						text = null;
						text2 = null;
						color = Color.Gray;
					}
				}
				else
				{
					flag2 = false;
					text = null;
					text2 = null;
					color = Color.FromArgb((int)(Form23.float_4 * 255f), (int)(Form23.float_5 * 255f), (int)(Form23.float_6 * 255f));
				}
			}
		}
		else
		{
			flag = false;
			flag2 = false;
			text = null;
			text2 = null;
			color = Color.Gray;
		}
		using SolidBrush brush3 = new SolidBrush(color);
		using Pen pen2 = new Pen(color, 2f);
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		int num6 = 18;
		int num7 = 2;
		paintEventArgs_0.Graphics.FillEllipse(brush3, 2, 2, 18, 18);
		paintEventArgs_0.Graphics.FillEllipse(brush3, Width - 2 - 18, 2, 18, 18);
		paintEventArgs_0.Graphics.DrawLine(pen2, 4, 11, 4, 1 + (Height - 9) - 9);
		paintEventArgs_0.Graphics.DrawLine(pen2, Width - 2 - 2, 11, Width - 2 - 2, 1 + (Height - 9) - 9);
		paintEventArgs_0.Graphics.DrawArc(pen2, 4, Height - 9 - 18, 18, 18, 90, 90);
		paintEventArgs_0.Graphics.DrawArc(pen2, Width - 2 - 18 - 2, Height - 9 - 18, 18, 18, 0, 90);
		paintEventArgs_0.Graphics.DrawLine(pen2, 12, Height - 9, Width - 2 - 9 - 1, Height - 9);
		if (flag2)
		{
			if (float_0 >= 360f)
			{
				float_0 = 0f;
			}
			else
			{
				float_0 += 15f;
			}
		}
		else
		{
			float_0 = 0f;
		}
		Pen pen3 = ((!bool_0) ? new Pen(BackColor, 4f) : new Pen(Color.FromArgb(194, 224, 255), 4f));
		paintEventArgs_0.Graphics.DrawArc(pen3, num7 + 4, num7 + 4, num6 - 8, num6 - 8, 0f + float_0, 80f);
		paintEventArgs_0.Graphics.DrawArc(pen3, num7 + 4, num7 + 4, num6 - 8, num6 - 8, 120f + float_0, 80f);
		paintEventArgs_0.Graphics.DrawArc(pen3, num7 + 4, num7 + 4, num6 - 8, num6 - 8, 240f + float_0, 80f);
		paintEventArgs_0.Graphics.DrawArc(pen3, Width - (num7 + 4) - (num6 - 8), num7 + 4, num6 - 8, num6 - 8, 0f + float_0, 80f);
		paintEventArgs_0.Graphics.DrawArc(pen3, Width - (num7 + 4) - (num6 - 8), num7 + 4, num6 - 8, num6 - 8, 120f + float_0, 80f);
		paintEventArgs_0.Graphics.DrawArc(pen3, Width - (num7 + 4) - (num6 - 8), num7 + 4, num6 - 8, num6 - 8, 240f + float_0, 80f);
		pen3.Dispose();
		if (!Enabled && (Form23.int_0 & 0x400) == 0)
		{
			return;
		}
		int num8 = Width / 2;
		if (flag)
		{
			paintEventArgs_0.Graphics.FillRectangle(brush3, num8 - 3, 16, 6, 4);
			Point[] points = new Point[3]
			{
				new Point(num8 - 6, 17),
				new Point(num8 + 6, 17),
				new Point(num8, 10)
			};
			paintEventArgs_0.Graphics.FillPolygon(brush3, points);
		}
		if (text == null || text2 == null)
		{
			return;
		}
		using Font font = new Font(Font.FontFamily, 8f, FontStyle.Bold);
		using StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		stringFormat.LineAlignment = StringAlignment.Center;
		paintEventArgs_0.Graphics.DrawString(text, font, brush3, num8, 27f, stringFormat);
		paintEventArgs_0.Graphics.DrawString(text2, font, brush3, num8, 38f, stringFormat);
	}
}
