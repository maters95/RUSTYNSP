using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NSP.Resources;
using ns0;
using ns4;

namespace ns2;

internal class Class164 : ToolStripButton
{
	private const int int_0 = 2000;

	private Image image_0;

	private Image image_1;

	private Stopwatch stopwatch_0 = new Stopwatch();

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
		image_0 = Class25.smethod_0(GeneralResources.IconDTCsCEL, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
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
		image_1 = Class25.smethod_0(GeneralResources.IconDTCsCEL, 1f, 0f, 0f, 0f, 0f, 1f, 0.6f, 0f);
		if (flag)
		{
			Image = image_1;
		}
	}

	internal void method_1()
	{
		Image = image_0;
	}

	internal void method_2()
	{
		if (Image != image_0)
		{
			Image = image_0;
		}
		BackColor = Form23.form23_0.toolStrip_0.BackColor;
		stopwatch_0.Reset();
	}

	internal void method_3()
	{
		if (Image != image_1)
		{
			Image = image_1;
		}
		stopwatch_0.Restart();
		BackColor = Color.FromArgb(200, 0, 0);
	}

	internal void method_4()
	{
		if (Image == image_1)
		{
			if (stopwatch_0.IsRunning)
			{
				if (stopwatch_0.ElapsedMilliseconds >= 2000L)
				{
					BackColor = Form23.form23_0.toolStrip_0.BackColor;
				}
				else
				{
					float num = 1f - (float)(int)stopwatch_0.ElapsedMilliseconds / 2000f;
					int r = Form23.form23_0.toolStrip_0.BackColor.R;
					int g = Form23.form23_0.toolStrip_0.BackColor.G;
					int b = Form23.form23_0.toolStrip_0.BackColor.B;
					Color backColor = Color.FromArgb(r + (int)(num * (float)(200 - r)), g - (int)(num * (float)g), b - (int)(num * (float)b));
					BackColor = backColor;
				}
			}
			else
			{
				stopwatch_0.Restart();
				BackColor = Color.FromArgb(200, 0, 0);
			}
		}
		else
		{
			BackColor = Form23.form23_0.toolStrip_0.BackColor;
			stopwatch_0.Reset();
		}
		Invalidate();
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		if (Tag == null)
		{
			return;
		}
		int num = (int)Tag;
		if (num == 0)
		{
			return;
		}
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		Rectangle rectangle = new Rectangle(paintEventArgs_0.ClipRectangle.Width - 27, -2, 30, 30);
		Rectangle rect = new Rectangle(paintEventArgs_0.ClipRectangle.Width - 24, 1, 22, 22);
		paintEventArgs_0.Graphics.FillEllipse(Brushes.Red, rect);
		using StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		stringFormat.LineAlignment = StringAlignment.Center;
		using Font font = new Font(Font.FontFamily, 9f, FontStyle.Bold);
		paintEventArgs_0.Graphics.DrawString(num.ToString(), font, Brushes.White, rectangle, stringFormat);
	}
}
