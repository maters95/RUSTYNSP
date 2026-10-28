using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns4;

namespace NSP.UserInterface;

public class ThemedComboBox : ComboBox
{
	private ThemedTextBox themedTextBox_0 = new ThemedTextBox();

	public ThemedComboBox()
	{
		themedTextBox_0.Visible = true;
		themedTextBox_0.TextChanged += themedTextBox_0_TextChanged;
		themedTextBox_0.MouseEnter += themedTextBox_0_MouseEnter;
		themedTextBox_0.Leave += themedTextBox_0_Leave;
		themedTextBox_0.KeyDown += themedTextBox_0_KeyDown;
		themedTextBox_0.KeyPress += themedTextBox_0_KeyPress;
		themedTextBox_0.GotFocus += themedTextBox_0_GotFocus;
		MouseWheel += ThemedComboBox_MouseWheel;
		SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
		SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
		SetStyle(ControlStyles.UserPaint, value: true);
		DoubleBuffered = true;
		DrawMode = DrawMode.OwnerDrawFixed;
		BackColor = Form23.color_32;
		ForeColor = Form23.color_12;
	}

	private void ThemedComboBox_MouseWheel(object sender, MouseEventArgs e)
	{
		if (!DroppedDown)
		{
			((HandledMouseEventArgs)e).Handled = true;
		}
	}

	protected override void OnDropDownStyleChanged(EventArgs eventArgs_0)
	{
		base.OnDropDownStyleChanged(eventArgs_0);
		if (DropDownStyle == ComboBoxStyle.DropDownList)
		{
			themedTextBox_0.Visible = false;
		}
		else
		{
			themedTextBox_0.Visible = Visible;
		}
	}

	protected override void OnVisibleChanged(EventArgs eventArgs_0)
	{
		base.OnVisibleChanged(eventArgs_0);
		if (Visible)
		{
			themedTextBox_0.Visible = DropDownStyle != ComboBoxStyle.DropDownList;
		}
		else
		{
			themedTextBox_0.Visible = false;
		}
	}

	protected override void OnEnabledChanged(EventArgs eventArgs_0)
	{
		base.OnEnabledChanged(eventArgs_0);
		themedTextBox_0.Enabled = Enabled;
	}

	protected override void OnSizeChanged(EventArgs eventArgs_0)
	{
		base.OnSizeChanged(eventArgs_0);
		themedTextBox_0.Height = Height;
		themedTextBox_0.Width = Width - 19;
	}

	protected override void OnLocationChanged(EventArgs eventArgs_0)
	{
		base.OnLocationChanged(eventArgs_0);
		themedTextBox_0.Location = Location;
	}

	protected override void OnForeColorChanged(EventArgs eventArgs_0)
	{
		base.OnForeColorChanged(eventArgs_0);
		themedTextBox_0.ForeColor = ForeColor;
	}

	protected override void OnBackColorChanged(EventArgs eventArgs_0)
	{
		base.OnBackColorChanged(eventArgs_0);
		themedTextBox_0.BackColor = BackColor;
	}

	protected override void OnFontChanged(EventArgs eventArgs_0)
	{
		base.OnFontChanged(eventArgs_0);
		themedTextBox_0.Font = Font;
	}

	protected override void OnSelectedIndexChanged(EventArgs eventArgs_0)
	{
		base.OnSelectedIndexChanged(eventArgs_0);
		if (Items.Count != 0 && SelectedIndex >= 0)
		{
			string text = ((DataSource == null) ? ((string)Items[SelectedIndex]) : GetItemText(Items[SelectedIndex]));
			themedTextBox_0.Text = text;
		}
	}

	protected override void OnTextChanged(EventArgs eventArgs_0)
	{
		base.OnTextChanged(eventArgs_0);
		themedTextBox_0.Text = Text;
	}

	private void themedTextBox_0_TextChanged(object sender, EventArgs e)
	{
		Text = themedTextBox_0.Text;
	}

	private void themedTextBox_0_MouseEnter(object sender, EventArgs e)
	{
		OnMouseEnter(e);
	}

	private void themedTextBox_0_Leave(object sender, EventArgs e)
	{
		OnLeave(e);
	}

	private void themedTextBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		OnKeyDown(e);
	}

	private void themedTextBox_0_KeyPress(object sender, KeyPressEventArgs e)
	{
		OnKeyPress(e);
	}

	private void themedTextBox_0_GotFocus(object sender, EventArgs e)
	{
		themedTextBox_0.SelectAll();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			themedTextBox_0.TextChanged -= themedTextBox_0_TextChanged;
			themedTextBox_0.MouseEnter -= themedTextBox_0_MouseEnter;
			themedTextBox_0.Leave -= themedTextBox_0_Leave;
			themedTextBox_0.KeyDown -= themedTextBox_0_KeyDown;
			themedTextBox_0.KeyPress -= themedTextBox_0_KeyPress;
			themedTextBox_0.GotFocus -= themedTextBox_0_GotFocus;
			MouseWheel -= ThemedComboBox_MouseWheel;
			themedTextBox_0.Dispose();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		using (SolidBrush brush = new SolidBrush(Form23.color_32))
		{
			paintEventArgs_0.Graphics.FillRectangle(brush, 0, 0, Width, Height);
		}
		using (Pen pen = new Pen(Brushes.Gray, 1f))
		{
			paintEventArgs_0.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 3);
			paintEventArgs_0.Graphics.DrawLine(pen, Width - 20, 0, Width - 20, Height - 3);
		}
		Color backColor = BackColor;
		if (!Enabled && BackColor != Form23.color_9)
		{
			using SolidBrush brush2 = new SolidBrush(Form23.color_35);
			paintEventArgs_0.Graphics.FillRectangle(brush2, 2, 2, Width - 22, Height - 5);
			backColor = Form23.color_35;
		}
		else if (Focused)
		{
			using SolidBrush brush3 = new SolidBrush(Color.DodgerBlue);
			paintEventArgs_0.Graphics.FillRectangle(brush3, 3, 3, Width - 23, Height - 6);
		}
		else if (BackColor != Form23.color_32)
		{
			using SolidBrush brush4 = new SolidBrush(BackColor);
			paintEventArgs_0.Graphics.FillRectangle(brush4, 3, 3, Width - 23, Height - 6);
		}
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		Point[] points = new Point[3]
		{
			new Point(Width - 18 + 8, 13),
			new Point(Width - 18 + 2, 6),
			new Point(Width - 18 + 13, 6)
		};
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			using SolidBrush brush5 = new SolidBrush(Form23.color_27);
			paintEventArgs_0.Graphics.FillPolygon(brush5, points);
		}
		else
		{
			paintEventArgs_0.Graphics.FillPolygon(Brushes.Gray, points);
		}
		Color foreColor = Form23.color_12;
		if (SelectedIndex >= 0)
		{
			Rectangle bounds = new Rectangle(3, 3, Width - 23, Height - 6);
			string text = ((DataSource == null) ? ((string)Items[SelectedIndex]) : GetItemText(Items[SelectedIndex]));
			if (!Enabled)
			{
				TextRenderer.DrawText(paintEventArgs_0.Graphics, text, Font, bounds, Form23.color_36, TextFormatFlags.NoPrefix);
				foreColor = Form23.color_36;
			}
			else
			{
				TextRenderer.DrawText(paintEventArgs_0.Graphics, text, Font, bounds, Form23.color_12, TextFormatFlags.NoPrefix);
			}
		}
		if (Parent != null && !(Parent is ToolStrip))
		{
			if (!Parent.Controls.Contains(themedTextBox_0))
			{
				Parent.Controls.Add(themedTextBox_0);
				themedTextBox_0.BringToFront();
			}
			if (themedTextBox_0.Visible)
			{
				themedTextBox_0.BackColor = backColor;
				themedTextBox_0.ForeColor = foreColor;
				themedTextBox_0.Invalidate();
			}
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs drawItemEventArgs_0)
	{
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			if ((drawItemEventArgs_0.State & DrawItemState.Focus) == 0 && (drawItemEventArgs_0.State & DrawItemState.HotLight) == 0)
			{
				using SolidBrush brush = new SolidBrush(Form23.color_32);
				drawItemEventArgs_0.Graphics.FillRectangle(brush, drawItemEventArgs_0.Bounds);
			}
			else
			{
				using SolidBrush brush2 = new SolidBrush(Color.DodgerBlue);
				drawItemEventArgs_0.Graphics.FillRectangle(brush2, drawItemEventArgs_0.Bounds);
			}
		}
		else
		{
			drawItemEventArgs_0.DrawBackground();
		}
		if (drawItemEventArgs_0.Index >= 0)
		{
			TextRenderer.DrawText(text: (DataSource == null) ? ((string)Items[drawItemEventArgs_0.Index]) : GetItemText(Items[drawItemEventArgs_0.Index]), dc: drawItemEventArgs_0.Graphics, font: Font, bounds: drawItemEventArgs_0.Bounds, foreColor: Form23.color_12, flags: TextFormatFlags.NoPrefix);
		}
		drawItemEventArgs_0.DrawFocusRectangle();
		base.OnDrawItem(drawItemEventArgs_0);
	}

	internal void method_0()
	{
		int num = 0;
		foreach (object item in Items)
		{
			int width = TextRenderer.MeasureText(item.ToString(), Font).Width;
			if (width > num)
			{
				num = width;
			}
		}
		num += 4;
		num += 20;
		Width = num;
		Refresh();
	}
}
