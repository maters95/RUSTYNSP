using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using ns0;
using ns4;
using ns7;

namespace ns2;

internal class Class167 : ToolStripButton
{
	private Image image_0;

	private Image image_1;

	private Image image_2;

	private Image image_3;

	private Image image_4;

	private Image image_5;

	private Image image_6;

	private Image image_7;

	private Image image_8;

	private Image image_9;

	private bool bool_0;

	private int int_0;

	private Stopwatch stopwatch_0 = new Stopwatch();

	private bool bool_1;

	internal void method_0()
	{
		bool flag = false;
		if (Image == image_0)
		{
			Image = null;
			flag = true;
		}
		if (image_0 != null)
		{
			image_0.Dispose();
		}
		image_0 = Class25.smethod_0(GeneralResources.IconOffline, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f);
		if (flag)
		{
			Image = image_0;
		}
		flag = false;
		if (Image == image_8)
		{
			Image = null;
			flag = true;
		}
		if (image_8 != null)
		{
			image_8.Dispose();
		}
		image_8 = Class25.smethod_0(GeneralResources.IconOnlineUSB, 1f, 0f, 0f, 0f, 0f, 1f, 0.8f, 0f);
		if (flag)
		{
			Image = image_8;
		}
		flag = false;
		if (Image == image_9)
		{
			Image = null;
			flag = true;
		}
		if (image_9 != null)
		{
			image_9.Dispose();
		}
		image_9 = Class25.smethod_0(GeneralResources.IconOnlineWiFi, 1f, 0f, 0f, 0f, 0f, 1f, 0.8f, 0f);
		if (flag)
		{
			Image = image_9;
		}
		flag = false;
		if (Image == image_1)
		{
			Image = null;
			flag = true;
		}
		if (image_1 != null)
		{
			image_1.Dispose();
		}
		image_1 = Class25.smethod_0(GeneralResources.IconOffline, 1f, 0f, 0f, 0f, 0f, 0.376f, 0.376f, 1f);
		if (flag)
		{
			Image = image_1;
		}
		flag = false;
		if (Image == image_2)
		{
			Image = null;
			flag = true;
		}
		if (image_2 != null)
		{
			image_2.Dispose();
		}
		image_2 = Class25.smethod_0(GeneralResources.IconOnlineUSB, 1f, 0f, 0f, 0f, 0f, 0f, 0.5f, 0f);
		if (flag)
		{
			Image = image_2;
		}
		flag = false;
		if (Image == image_5)
		{
			Image = null;
			flag = true;
		}
		if (image_5 != null)
		{
			image_5.Dispose();
		}
		image_5 = Class25.smethod_0(GeneralResources.IconOnlineUSB, 1f, 0f, 0f, 0f, 0f, 0.376f, 0.376f, 1f);
		if (flag)
		{
			Image = image_5;
		}
		flag = false;
		if (Image == image_3)
		{
			Image = null;
			flag = true;
		}
		if (image_3 != null)
		{
			image_3.Dispose();
		}
		image_3 = Class25.smethod_0(GeneralResources.IconOnlineUSBPower, 1f, 0f, 0f, 0f, 0f, 1f, 0.8f, 0f);
		if (flag)
		{
			Image = image_3;
		}
		flag = false;
		if (Image == image_6)
		{
			Image = null;
			flag = true;
		}
		if (image_6 != null)
		{
			image_6.Dispose();
		}
		image_6 = Class25.smethod_0(GeneralResources.IconOnlineUSBPower, 1f, 0f, 0f, 0f, 0f, 0.376f, 0.376f, 1f);
		if (flag)
		{
			Image = image_6;
		}
		flag = false;
		if (Image == image_4)
		{
			Image = null;
			flag = true;
		}
		if (image_4 != null)
		{
			image_4.Dispose();
		}
		image_4 = Class25.smethod_0(GeneralResources.IconOnlineWiFi, 1f, 0f, 0f, 0f, 0f, 0f, 0.5f, 0f);
		if (flag)
		{
			Image = image_4;
		}
		flag = false;
		if (Image == image_7)
		{
			Image = null;
			flag = true;
		}
		if (image_7 != null)
		{
			image_7.Dispose();
		}
		image_7 = Class25.smethod_0(GeneralResources.IconOnlineWiFi, 1f, 0f, 0f, 0f, 0f, 0.376f, 0.376f, 1f);
		if (flag)
		{
			Image = image_7;
		}
	}

	internal void method_1()
	{
		if (Image != image_0)
		{
			Image = image_0;
		}
		Text = Class333.smethod_689();
		ToolTipText = Text;
	}

	internal void method_2()
	{
		if (Image != image_1)
		{
			Image = image_1;
		}
		Text = Class333.smethod_690();
		ToolTipText = Text;
	}

	internal void method_3()
	{
		if (Image != image_3)
		{
			Image = image_3;
		}
		Text = Class333.smethod_691();
		ToolTipText = Text;
	}

	internal void method_4()
	{
		if (Image != image_6)
		{
			Image = image_6;
		}
		Text = Class333.smethod_692();
		ToolTipText = Text;
	}

	internal void method_5()
	{
		if (Image != image_5)
		{
			Image = image_5;
		}
		Text = Class333.smethod_693();
		ToolTipText = Text;
	}

	internal void method_6()
	{
		if (Image != image_2)
		{
			Image = image_2;
		}
		Text = Class333.smethod_694();
		ToolTipText = Text;
	}

	internal void method_7()
	{
		if (Image != image_8)
		{
			Image = image_8;
		}
		Text = Class333.smethod_695();
		ToolTipText = Text;
	}

	internal void method_8()
	{
		if (Image != image_7)
		{
			Image = image_7;
		}
		Text = Class333.smethod_696();
		ToolTipText = Text;
	}

	internal void method_9()
	{
		if (Image != image_4)
		{
			Image = image_4;
		}
		Text = Class333.smethod_697();
		ToolTipText = Text;
	}

	internal void method_10()
	{
		if (Image != image_9)
		{
			Image = image_9;
		}
		Text = Class333.smethod_698();
		ToolTipText = Text;
	}

	[SpecialName]
	internal void method_11(bool bool_2)
	{
		bool flag;
		if ((flag = bool_2) && !bool_1)
		{
			stopwatch_0.Restart();
		}
		bool_1 = flag;
	}

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
		Color color;
		if (bool_0)
		{
			Rectangle rect = new Rectangle(0, 0, Width, Height);
			color = Color.FromArgb(194, 224, 255);
			using (SolidBrush brush = new SolidBrush(color))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, rect);
			}
			using Pen pen = new Pen(Color.FromArgb(51, 153, 255), 2f);
			paintEventArgs_0.Graphics.DrawRectangle(pen, rect);
		}
		else
		{
			color = BackColor;
			using SolidBrush brush2 = new SolidBrush(BackColor);
			Rectangle rect2 = new Rectangle(0, 0, Width, Height);
			paintEventArgs_0.Graphics.FillRectangle(brush2, rect2);
		}
		if (Image != null)
		{
			paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			GraphicsUnit pageUnit = GraphicsUnit.Pixel;
			Rectangle rectangle = new Rectangle(0, 0, Width, Height);
			paintEventArgs_0.Graphics.DrawImage(Image, rectangle, Image.GetBounds(ref pageUnit), GraphicsUnit.Pixel);
		}
		int num = 17;
		int num2 = 22;
		Rectangle rectangle2 = new Rectangle(14, 18, 70, 17);
		bool flag = (Form23.int_0 & 8) != 0 || (Form23.int_0 & 0x10) != 0 || (Form23.stopwatch_0.IsRunning && Form23.stopwatch_0.ElapsedMilliseconds < 500L);
		if ((Form23.int_0 & 4) == 0 && !flag)
		{
			int_0 = 0;
		}
		else if (int_0 >= rectangle2.Width - num2)
		{
			int_0 = 0;
		}
		else
		{
			int_0 += 8;
		}
		if (flag)
		{
			int num3 = rectangle2.Left + int_0;
			Point[] points = new Point[7]
			{
				new Point(num3 + 10, rectangle2.Top),
				new Point(num3 + num2, rectangle2.Top + num / 2),
				new Point(num3 + 10, rectangle2.Bottom),
				new Point(num3 + 10, rectangle2.Bottom - 4),
				new Point(num3, rectangle2.Bottom - 4),
				new Point(num3, rectangle2.Top + 4),
				new Point(num3 + 10, rectangle2.Top + 4)
			};
			paintEventArgs_0.Graphics.FillPolygon(Brushes.DodgerBlue, points);
			paintEventArgs_0.Graphics.DrawPolygon(Pens.LightGray, points);
		}
		else if ((Form23.int_0 & 0x20) != 0)
		{
			int num4 = rectangle2.Right - int_0;
			Point[] points2 = new Point[7]
			{
				new Point(num4 - 10, rectangle2.Top),
				new Point(num4 - num2, rectangle2.Top + num / 2),
				new Point(num4 - 10, rectangle2.Bottom),
				new Point(num4 - 10, rectangle2.Bottom - 4),
				new Point(num4, rectangle2.Bottom - 4),
				new Point(num4, rectangle2.Top + 4),
				new Point(num4 - 10, rectangle2.Top + 4)
			};
			paintEventArgs_0.Graphics.FillPolygon(Brushes.DodgerBlue, points2);
			paintEventArgs_0.Graphics.DrawPolygon(Pens.LightGray, points2);
		}
		else if (bool_1)
		{
			Rectangle rect3 = new Rectangle(Width / 2 - 14, Height / 2 - 16, 30, 31);
			using (SolidBrush brush3 = new SolidBrush(color))
			{
				paintEventArgs_0.Graphics.FillEllipse(brush3, rect3);
			}
			if (stopwatch_0.IsRunning && stopwatch_0.ElapsedMilliseconds < 4000L)
			{
				using (Pen pen2 = new Pen(Color.DodgerBlue, 3f))
				{
					paintEventArgs_0.Graphics.DrawArc(pen2, rect3, stopwatch_0.ElapsedMilliseconds * 360L / 1000L, 315f);
					return;
				}
			}
			using (Font font = new Font(Font.FontFamily, 7f, FontStyle.Regular))
			{
				using SolidBrush brush4 = new SolidBrush(Form23.color_12);
				using StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				int num5 = Width / 2 + 2;
				paintEventArgs_0.Graphics.DrawString(Class333.smethod_699(), font, brush4, num5, Height / 2 - 8, stringFormat);
				paintEventArgs_0.Graphics.DrawString(Class333.smethod_700(), font, brush4, num5, Height / 2, stringFormat);
				paintEventArgs_0.Graphics.DrawString(Class333.smethod_701(), font, brush4, num5, Height / 2 + 8, stringFormat);
			}
			if (stopwatch_0.IsRunning)
			{
				stopwatch_0.Stop();
			}
		}
		else if (stopwatch_0.IsRunning)
		{
			stopwatch_0.Stop();
		}
	}
}
