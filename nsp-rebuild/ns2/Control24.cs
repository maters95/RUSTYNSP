using System;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns2;

internal class Control24 : TabControl
{
	protected int int_0 = -1;

	internal Control24()
	{
		SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, value: true);
		DrawMode = TabDrawMode.OwnerDrawFixed;
	}

	protected override void OnPaintBackground(PaintEventArgs paintEventArgs_0)
	{
		Graphics graphics = paintEventArgs_0.Graphics;
		using (SolidBrush brush = new SolidBrush(Form23.color_10))
		{
			graphics.FillRectangle(brush, 0, 0, Width, Height);
		}
		for (int i = 0; i < TabPages.Count; i++)
		{
			TabPage tabPage;
			if (TabPages[i] is Class130)
			{
				tabPage = TabPages[i] as Class130;
			}
			else
			{
				tabPage = ((!(TabPages[i] is Class173)) ? TabPages[i] : (TabPages[i] as Class173));
			}
			Rectangle rect = GetTabRect(i);
			if (tabPage is Class173 && ((tabPage as Class173).method_0() || (tabPage as Class173).method_2()))
			{
				rect = new Rectangle(rect.X, rect.Y, rect.Width - 15, rect.Height);
			}
			if (i == SelectedIndex)
			{
				using (SolidBrush brush2 = new SolidBrush(Form23.color_21))
				{
					graphics.FillRectangle(brush2, rect.X + 1, rect.Y, rect.Width - 2, rect.Height);
				}
				if (Form23.bool_43)
				{
					using Pen pen = new Pen(Form23.color_25, 1f);
					graphics.DrawRectangle(pen, rect);
				}
			}
			else
			{
				using (SolidBrush brush3 = new SolidBrush(Form23.color_22))
				{
					graphics.FillRectangle(brush3, rect.X + 1, rect.Y + 2, rect.Width - 2, rect.Height - 2);
				}
				if (Form23.bool_43)
				{
					using Pen pen2 = new Pen(Form23.color_25, 1f);
					graphics.DrawRectangle(pen2, rect.X, rect.Y + 2, rect.Width, rect.Height - 2);
				}
			}
			if (tabPage is Class173 && (tabPage as Class173).method_0() && i < TabPages.Count - 1)
			{
				using Pen pen3 = new Pen(Form23.color_25, 1f);
				int num = rect.Top + rect.Height / 2 + 1;
				graphics.DrawLine(pen3, rect.Right + 3, num, rect.Right + 13, num);
				graphics.DrawLine(pen3, rect.Right + 10, num - 3, rect.Right + 13, num);
				graphics.DrawLine(pen3, rect.Right + 10, num + 3, rect.Right + 13, num);
			}
			if (tabPage is Class130 && i < TabPages.Count - 1)
			{
				Pen pen4 = ((i != SelectedIndex) ? new Pen(Form23.color_24, 1f) : new Pen(Form23.color_23, 1f));
				graphics.DrawRectangle(pen4, rect.Left + rect.Width - 4 - 7, rect.Top + rect.Height / 2, 6, 6);
				if ((tabPage as Class130).method_4())
				{
					graphics.DrawLine(pen4, rect.Left + rect.Width - 4 - 6, rect.Top + rect.Height / 2, rect.Left + rect.Width - 4 - 6, rect.Top + rect.Height / 2 - 1);
					graphics.DrawLine(pen4, rect.Left + rect.Width - 4 - 2, rect.Top + rect.Height / 2, rect.Left + rect.Width - 4 - 2, rect.Top + rect.Height / 2 - 1);
					graphics.DrawArc(pen4, rect.Left + rect.Width - 4 - 6, rect.Top + rect.Height / 2 - 4, 4, 4, 180, 180);
				}
				else
				{
					graphics.DrawLine(pen4, rect.Left + rect.Width - 4 - 6, rect.Top + rect.Height / 2, rect.Left + rect.Width - 4 - 6, rect.Top + rect.Height / 2 - 3);
					graphics.DrawArc(pen4, rect.Left + rect.Width - 4 - 6, rect.Top + rect.Height / 2 - 6, 4, 4, 180, 180);
				}
				pen4.Dispose();
			}
			string text = tabPage.Text;
			Size size = TextRenderer.MeasureText(text, Font);
			Point pt = ((!(tabPage is Class130) || i >= TabPages.Count - 1) ? new Point(rect.Left + rect.Width / 2 - size.Width / 2, 1 + rect.Top + rect.Height / 2 - size.Height / 2) : new Point(rect.Left + (rect.Width - 8) / 2 - size.Width / 2, 1 + rect.Top + rect.Height / 2 - size.Height / 2));
			if (tabPage is Class130 && (tabPage as Class130).method_2())
			{
				using Font font = new Font(Font, FontStyle.Italic);
				if (i == SelectedIndex)
				{
					TextRenderer.DrawText(graphics, text, font, pt, Form23.color_23, TextFormatFlags.NoPrefix);
				}
				else
				{
					TextRenderer.DrawText(graphics, text, font, pt, Form23.color_24, TextFormatFlags.NoPrefix);
				}
			}
			else if (i == SelectedIndex)
			{
				TextRenderer.DrawText(graphics, text, Font, pt, Form23.color_23, TextFormatFlags.NoPrefix);
			}
			else
			{
				TextRenderer.DrawText(graphics, text, Font, pt, Form23.color_24, TextFormatFlags.NoPrefix);
			}
			if (int_0 != -1 && i == int_0)
			{
				graphics.FillRectangle(Brushes.DodgerBlue, rect.Left, rect.Top, 5, rect.Height);
			}
		}
		int num2 = 0;
		for (int j = 0; j < TabPages.Count; j++)
		{
			num2 = Math.Max(num2, GetTabRect(j).Bottom);
		}
		if (Form23.bool_43)
		{
			graphics.DrawRectangle(Pens.Gray, 2, num2, Width - 5, Height - (num2 + 3));
		}
	}
}
