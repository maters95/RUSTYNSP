using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns4;

namespace NSP.UserInterface;

public class ThemedButton : Button
{
	private bool bool_0;

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
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			if (Parent != null)
			{
				using SolidBrush brush = new SolidBrush(Parent.BackColor);
				paintEventArgs_0.Graphics.FillRectangle(brush, 0, 0, Width, Height);
			}
			paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			Rectangle rectangle = new Rectangle(1, 1, DisplayRectangle.Width - 2, DisplayRectangle.Height - 2);
			if (Focused)
			{
				using GraphicsPath path = smethod_0(rectangle, 2);
				paintEventArgs_0.Graphics.FillPath(Brushes.DodgerBlue, path);
			}
			else
			{
				using GraphicsPath path2 = smethod_0(rectangle, 2);
				using SolidBrush brush2 = new SolidBrush(Form23.color_33);
				paintEventArgs_0.Graphics.FillPath(brush2, path2);
			}
			using (GraphicsPath path3 = smethod_0(rectangle, 2))
			{
				if (!bool_0)
				{
					using Pen pen = new Pen(Form23.color_34, 1f);
					paintEventArgs_0.Graphics.DrawPath(pen, path3);
				}
				else
				{
					paintEventArgs_0.Graphics.DrawPath(Pens.DodgerBlue, path3);
				}
			}
			if (Image != null)
			{
				try
				{
					paintEventArgs_0.Graphics.DrawImage(Image, Width / 2 - Image.Width / 2, Height / 2 - Image.Height / 2);
				}
				catch
				{
				}
				if (!Enabled)
				{
					using (SolidBrush brush3 = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
					{
						paintEventArgs_0.Graphics.FillRectangle(brush3, rectangle);
						return;
					}
				}
				return;
			}
			Rectangle bounds = new Rectangle(3, 3, DisplayRectangle.Width - 6, DisplayRectangle.Height - 6);
			if (Enabled)
			{
				if (!(ForeColor == Color.Red) && !(ForeColor == Form23.color_7))
				{
					TextRenderer.DrawText(paintEventArgs_0.Graphics, Text, Font, bounds, Form23.color_12, TextFormatFlags.HorizontalCenter | TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
				}
				else
				{
					TextRenderer.DrawText(paintEventArgs_0.Graphics, Text, Font, bounds, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
				}
			}
			else
			{
				TextRenderer.DrawText(paintEventArgs_0.Graphics, Text, Font, bounds, Form23.color_36, TextFormatFlags.HorizontalCenter | TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
			}
			return;
		}
		try
		{
			base.OnPaint(paintEventArgs_0);
		}
		catch
		{
		}
	}

	internal static GraphicsPath smethod_0(Rectangle rectangle_0, int int_0)
	{
		int num = int_0 * 2;
		Rectangle rect = new Rectangle(size: new Size(num, num), location: rectangle_0.Location);
		GraphicsPath graphicsPath = new GraphicsPath();
		if (int_0 == 0)
		{
			graphicsPath.AddRectangle(rectangle_0);
			return graphicsPath;
		}
		graphicsPath.AddArc(rect, 180f, 90f);
		rect.X = rectangle_0.Right - num;
		graphicsPath.AddArc(rect, 270f, 90f);
		rect.Y = rectangle_0.Bottom - num;
		graphicsPath.AddArc(rect, 0f, 90f);
		rect.X = rectangle_0.Left;
		graphicsPath.AddArc(rect, 90f, 90f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}
}
