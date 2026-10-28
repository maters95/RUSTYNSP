using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns4;

namespace ns2;

internal class Class148 : CheckBox
{
	internal bool bool_0;

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		if (Parent != null)
		{
			using SolidBrush brush = new SolidBrush(Parent.BackColor);
			paintEventArgs_0.Graphics.FillRectangle(brush, 0, 0, Width, Height);
		}
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		int int_ = Height / 2 - 7;
		int y = Height / 2;
		smethod_1(paintEventArgs_0.Graphics, BackColor, 0, int_, Enabled, Focused, Checked ? Enum43.const_1 : Enum43.const_0, ClientRectangle.Contains(PointToClient(Control.MousePosition)), bool_0);
		if (Enabled || ForeColor == Form23.color_9)
		{
			TextRenderer.DrawText(pt: new Point(17, y), dc: paintEventArgs_0.Graphics, text: Text, font: Font, foreColor: ForeColor, flags: TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter);
			return;
		}
		TextRenderer.DrawText(pt: new Point(17, y), dc: paintEventArgs_0.Graphics, text: Text, font: Font, foreColor: Form23.color_36, flags: TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter);
	}

	internal static void smethod_0(Graphics graphics_0, Color color_0, int int_0, int int_1, bool bool_1, bool bool_2, Enum43 enum43_0, bool bool_3)
	{
		smethod_1(graphics_0, color_0, int_0, int_1, bool_1, bool_2, enum43_0, bool_3, bool_4: false);
	}

	internal static void smethod_1(Graphics graphics_0, Color color_0, int int_0, int int_1, bool bool_1, bool bool_2, Enum43 enum43_0, bool bool_3, bool bool_4)
	{
		SmoothingMode smoothingMode = graphics_0.SmoothingMode;
		graphics_0.SmoothingMode = SmoothingMode.HighQuality;
		Pen pen;
		if (bool_1)
		{
			if (bool_3)
			{
				pen = new Pen(Color.DodgerBlue, 1f);
			}
			else
			{
				pen = ((!bool_2) ? new Pen(Form23.color_12, 1f) : new Pen(Form23.color_12, 2f));
			}
		}
		else
		{
			pen = new Pen(Form23.color_36, 1f);
		}
		graphics_0.DrawArc(pen, int_0, int_1, 12, 12, 90, 180);
		graphics_0.DrawArc(pen, int_0 + 4, int_1, 12, 12, 270, 180);
		graphics_0.DrawLine(pen, int_0 + 6, int_1, int_0 + 10, int_1);
		graphics_0.DrawLine(pen, int_0 + 6, int_1 + 12, int_0 + 10, int_1 + 12);
		pen.Dispose();
		if (bool_1 | bool_4)
		{
			switch (enum43_0)
			{
			case Enum43.const_1:
			{
				using (SolidBrush brush6 = new SolidBrush(color_0))
				{
					graphics_0.FillEllipse(brush6, int_0 + 1, int_1 + 1, 10, 10);
				}
				using (SolidBrush brush7 = new SolidBrush(Form23.color_31))
				{
					graphics_0.FillEllipse(brush7, int_0 + 5, int_1 + 1, 10, 10);
				}
				break;
			}
			case Enum43.const_0:
			{
				using (SolidBrush brush4 = new SolidBrush(color_0))
				{
					graphics_0.FillEllipse(brush4, int_0 + 5, int_1 + 1, 10, 10);
				}
				using (SolidBrush brush5 = new SolidBrush(Form23.color_30))
				{
					graphics_0.FillEllipse(brush5, int_0 + 1, int_1 + 1, 10, 10);
				}
				break;
			}
			case Enum43.const_2:
			{
				using (SolidBrush brush = new SolidBrush(color_0))
				{
					graphics_0.FillEllipse(brush, int_0 + 1, int_1 + 1, 10, 10);
				}
				using (SolidBrush brush2 = new SolidBrush(Form23.color_30))
				{
					using GraphicsPath graphicsPath = new GraphicsPath();
					graphicsPath.AddArc(int_0 + 5, int_1 + 1, 10, 10, 270f, 180f);
					graphicsPath.CloseAllFigures();
					graphics_0.FillPath(brush2, graphicsPath);
				}
				using (SolidBrush brush3 = new SolidBrush(Form23.color_31))
				{
					using GraphicsPath graphicsPath2 = new GraphicsPath();
					graphicsPath2.AddArc(int_0 + 5, int_1 + 1, 10, 10, 90f, 180f);
					graphicsPath2.CloseAllFigures();
					graphics_0.FillPath(brush3, graphicsPath2);
				}
				break;
			}
			}
		}
		graphics_0.SmoothingMode = smoothingMode;
	}
}
