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

internal class Class162 : ToolStripButton
{
	internal enum Enum44
	{
		Bnl,
		BnM,
		Bnm,
		BnN
	}

	private const int int_0 = 2000;

	private const int int_1 = 15;

	private const int int_2 = 10;

	private const double double_0 = 0.8;

	private Enum44 enum44_0;

	private int int_3;

	private string string_0 = string.Empty;

	private string string_1 = string.Empty;

	private int int_4 = -90;

	private int int_5 = 315;

	private Timer timer_0;

	private Image image_0;

	private Image image_1;

	private Stopwatch stopwatch_0 = new Stopwatch();

	internal Class162()
	{
		Image = image_0;
	}

	[SpecialName]
	internal int method_0()
	{
		return (int)((double)(Height - 15) * 0.8);
	}

	internal void method_1()
	{
		int num = ((int_4 + 10 < 360) ? (int_4 + 10) : (360 - (int_4 + 10)));
		int_4 = num;
	}

	private void method_2()
	{
		if (timer_0 == null)
		{
			timer_0 = new Timer();
		}
		timer_0.Interval = 20;
		timer_0.Tick += timer_0_Tick;
		timer_0.Start();
	}

	private void method_3()
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			timer_0.Dispose();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		Invalidate();
	}

	internal void method_4()
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
		image_0 = Class25.smethod_0(GeneralResources.IconSWUpdate, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		if (flag)
		{
			Image = image_0;
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
		image_1 = Class25.smethod_0(GeneralResources.IconSWUpdate, 1f, 0f, 0f, 0f, 0f, 0f, 0.5f, 0f);
		if (flag)
		{
			Image = image_1;
		}
	}

	internal void method_5()
	{
		Image = image_0;
	}

	internal void method_6()
	{
		if (Image != image_0)
		{
			Image = image_0;
		}
		stopwatch_0.Reset();
		Text = Class333.smethod_679();
		ToolTipText = Text;
	}

	internal void method_7(Enum44 enum44_1, int int_6, string string_2, string string_3)
	{
		method_3();
		enum44_0 = enum44_1;
		switch (enum44_1)
		{
		case Enum44.Bnl:
			string_1 = string_3;
			Image = image_0;
			Text = Class333.smethod_679();
			BackColor = GetCurrentParent().BackColor;
			stopwatch_0.Reset();
			Invalidate();
			break;
		case Enum44.BnM:
			string_1 = string_3;
			Image = image_1;
			Text = Class333.smethod_680();
			BackColor = Color.FromArgb(0, 200, 0);
			stopwatch_0.Restart();
			Invalidate();
			break;
		case Enum44.Bnm:
			method_2();
			string_0 = string_2;
			string_1 = string_3;
			break;
		case Enum44.BnN:
			int_3 = int_6;
			string_0 = string_2;
			string_1 = string_3;
			Invalidate();
			break;
		}
		ToolTipText = string_1;
	}

	internal void method_8()
	{
		if (Image == image_1)
		{
			if (stopwatch_0.IsRunning)
			{
				if (stopwatch_0.ElapsedMilliseconds >= 2000L)
				{
					BackColor = Form23.form23_0.toolStrip_0.BackColor;
					return;
				}
				float num = 1f - (float)(int)stopwatch_0.ElapsedMilliseconds / 2000f;
				int r = Form23.form23_0.toolStrip_0.BackColor.R;
				int g = Form23.form23_0.toolStrip_0.BackColor.G;
				int b = Form23.form23_0.toolStrip_0.BackColor.B;
				Color backColor = Color.FromArgb(r - (int)(num * (float)r), g + (int)(num * (float)(200 - g)), b - (int)(num * (float)b));
				BackColor = backColor;
			}
			else
			{
				stopwatch_0.Restart();
				BackColor = Color.FromArgb(0, 200, 0);
			}
		}
		else
		{
			BackColor = Form23.form23_0.toolStrip_0.BackColor;
			stopwatch_0.Reset();
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		if (enum44_0 == Enum44.Bnl || enum44_0 == Enum44.BnM)
		{
			return;
		}
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		paintEventArgs_0.Graphics.Clear(BackColor);
		Rectangle rect = new Rectangle(new Point(Width / 2 - method_0() / 2, (Height - 15) / 2 - method_0() / 2), new Size(method_0(), method_0()));
		Rectangle rectangle = new Rectangle(new Point(0, 1), new Size(Width, Height - 15));
		Rectangle rectangle2 = new Rectangle(new Point(0, Height - 15), new Size(Width, 15));
		StringFormat stringFormat = new StringFormat();
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Alignment = StringAlignment.Center;
		if (enum44_0 == Enum44.Bnm)
		{
			method_1();
			using (Pen pen = new Pen(Color.Gray, 4f))
			{
				paintEventArgs_0.Graphics.DrawEllipse(pen, rect);
			}
			using (Brush brush = new SolidBrush(Form23.color_12))
			{
				using Font font = new Font(Font.FontFamily, 8f, FontStyle.Bold);
				paintEventArgs_0.Graphics.DrawString(string_0, font, brush, rectangle2, stringFormat);
			}
			using Pen pen2 = new Pen(Color.FromArgb(0, 200, 0), 5f);
			paintEventArgs_0.Graphics.DrawArc(pen2, rect, int_4, int_5);
		}
		else if (enum44_0 == Enum44.BnN)
		{
			using (Pen pen3 = new Pen(Color.Gray, 4f))
			{
				paintEventArgs_0.Graphics.DrawEllipse(pen3, rect);
			}
			using (Brush brush2 = new SolidBrush(Form23.color_12))
			{
				using Font font2 = new Font(Font.FontFamily, 8f, FontStyle.Bold);
				paintEventArgs_0.Graphics.DrawString(string_0, font2, brush2, rectangle2, stringFormat);
			}
			using (Pen pen4 = new Pen(Color.FromArgb(0, 200, 0), 5f))
			{
				float sweepAngle = (float)int_3 / 100f * 360f;
				paintEventArgs_0.Graphics.DrawArc(pen4, rect, -90f, sweepAngle);
			}
			using Brush brush3 = new SolidBrush(Form23.color_12);
			using Font font3 = new Font(Font.FontFamily, 8f, FontStyle.Bold);
			paintEventArgs_0.Graphics.DrawString(int_3 + Class333.smethod_681(), font3, brush3, rectangle, stringFormat);
		}
		stringFormat.Dispose();
	}
}
