using System;
using System.Drawing;
using System.Windows.Forms;
using NSP.Resources;
using ns0;
using ns4;
using ns7;

namespace ns2;

internal class Class163 : ToolStripDropDownButton
{
	private Image image_0;

	private Image image_1;

	private static bool bool_0;

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
		image_0 = Class25.smethod_0(GeneralResources.IconCompareMaps, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
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
		image_1 = Class25.smethod_0(GeneralResources.IconCompareMaps, 1f, 0f, 0f, 0f, 0f, (float)(int)Form23.color_9.R / 255f, (float)(int)Form23.color_9.G / 255f, (float)(int)Form23.color_9.B / 255f);
		if (flag)
		{
			Image = image_1;
		}
	}

	internal void method_1()
	{
		if (Image != image_0)
		{
			Image = image_0;
		}
	}

	internal void method_2()
	{
		if (Image != image_1)
		{
			Image = image_1;
		}
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
		if (Form23.framework_0 == null)
		{
			return;
		}
		if (bool_0)
		{
			Rectangle rect = new Rectangle(0, 0, Width, Height);
			using (SolidBrush brush = new SolidBrush(Color.FromArgb(194, 224, 255)))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, rect);
			}
			using Pen pen = new Pen(Color.FromArgb(51, 153, 255), 2f);
			paintEventArgs_0.Graphics.DrawRectangle(pen, rect);
		}
		else
		{
			Rectangle rect2 = new Rectangle(1, 1, Width - 2, Height - 3);
			using (SolidBrush brush2 = new SolidBrush(BackColor))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush2, rect2);
			}
			using Pen pen2 = new Pen(Form23.color_9, 4f);
			paintEventArgs_0.Graphics.DrawRectangle(pen2, rect2);
		}
		using Font font = new Font(Font.FontFamily, 7f, FontStyle.Bold);
		using SolidBrush brush3 = new SolidBrush(Form23.color_12);
		StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		stringFormat.LineAlignment = StringAlignment.Center;
		int num = Width / 2;
		if (Form23.enum60_0 == Form23.Enum60.BpF)
		{
			paintEventArgs_0.Graphics.DrawString(Class333.smethod_682(), font, brush3, num, 17f, stringFormat);
			paintEventArgs_0.Graphics.DrawString(Class333.smethod_683(), font, brush3, num, 26f, stringFormat);
			paintEventArgs_0.Graphics.DrawString(Class333.smethod_684(), font, brush3, num, 35f, stringFormat);
		}
		else if (Form23.enum60_0 == Form23.Enum60.Bpf)
		{
			paintEventArgs_0.Graphics.DrawString(Class333.smethod_682(), font, brush3, num, 17f, stringFormat);
			paintEventArgs_0.Graphics.DrawString(Class333.smethod_685(), font, brush3, num, 26f, stringFormat);
			paintEventArgs_0.Graphics.DrawString(Class333.smethod_684(), font, brush3, num, 35f, stringFormat);
		}
		else if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			paintEventArgs_0.Graphics.DrawString(Class333.smethod_682(), font, brush3, num, 17f, stringFormat);
			paintEventArgs_0.Graphics.DrawString(Class333.smethod_686(), font, brush3, num, 26f, stringFormat);
			paintEventArgs_0.Graphics.DrawString(Class333.smethod_684(), font, brush3, num, 35f, stringFormat);
		}
		stringFormat.Dispose();
	}
}
