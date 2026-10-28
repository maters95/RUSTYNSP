using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns4;

namespace ns2;

internal class Class149 : CheckedListBox
{
	[CompilerGenerated]
	private bool bool_0;

	private bool bool_1;

	private const int int_0 = 17;

	[SpecialName]
	[CompilerGenerated]
	public bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(bool bool_2)
	{
		bool_0 = bool_2;
	}

	public Class149()
	{
		BackColor = Form23.color_16;
		SelectionMode = SelectionMode.One;
		BorderStyle = BorderStyle.FixedSingle;
		DrawMode = DrawMode.OwnerDrawFixed;
		ItemCheck += Class149_ItemCheck;
	}

	public void method_2()
	{
		int num = 0;
		foreach (object item in Items)
		{
			Size size = TextRenderer.MeasureText(item.ToString(), Font);
			if (size.Width > num)
			{
				num = size.Width;
			}
		}
		if (num > Width)
		{
			Width = num + 17 + 10;
		}
	}

	private void Class149_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		ClearSelected();
		if (!method_0() || bool_1)
		{
			return;
		}
		bool_1 = true;
		CheckState checkState = CheckState.Indeterminate;
		int num = 1;
		while (true)
		{
			if (num < Items.Count)
			{
				if (num == 1)
				{
					checkState = ((num != e.Index) ? GetItemCheckState(num) : e.NewValue);
				}
				else if (num == e.Index)
				{
					if (e.NewValue != checkState)
					{
						SetItemCheckState(0, CheckState.Indeterminate);
						return;
					}
				}
				else if (GetItemCheckState(num) != checkState)
				{
					break;
				}
				num++;
				continue;
			}
			SetItemCheckState(0, checkState);
			bool_1 = false;
			return;
		}
		SetItemCheckState(0, CheckState.Indeterminate);
	}

	private void method_3(object sender, MouseEventArgs e)
	{
		int num = IndexFromPoint(e.Location);
		if (num != -1)
		{
			Rectangle itemRectangle = GetItemRectangle(num);
			if (new Rectangle(itemRectangle.X + 2, itemRectangle.Y + 2, 16, 16).Contains(e.Location))
			{
				bool value = !GetItemChecked(num);
				SetItemChecked(num, value);
			}
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs drawItemEventArgs_0)
	{
		_ = drawItemEventArgs_0.Graphics;
		drawItemEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		drawItemEventArgs_0.DrawBackground();
		CheckState itemCheckState = GetItemCheckState(drawItemEventArgs_0.Index);
		Enum43 enum43_ = Enum43.const_0;
		switch (itemCheckState)
		{
		case CheckState.Unchecked:
			enum43_ = Enum43.const_0;
			break;
		case CheckState.Checked:
			enum43_ = Enum43.const_1;
			break;
		case CheckState.Indeterminate:
			enum43_ = Enum43.const_2;
			break;
		}
		Rectangle bounds = drawItemEventArgs_0.Bounds;
		int x = bounds.X;
		int y = bounds.Y;
		Class148.smethod_1(drawItemEventArgs_0.Graphics, BackColor, x, y, Enabled, Focused, enum43_, ClientRectangle.Contains(PointToClient(Control.MousePosition)), bool_4: false);
		Point pt = new Point(17, y + bounds.Height / 2);
		if (!Enabled && !(ForeColor == Form23.color_9))
		{
			TextRenderer.DrawText(drawItemEventArgs_0.Graphics, Items[drawItemEventArgs_0.Index].ToString(), Font, pt, Form23.color_36, TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter);
		}
		else
		{
			TextRenderer.DrawText(drawItemEventArgs_0.Graphics, Items[drawItemEventArgs_0.Index].ToString(), Font, pt, ForeColor, TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter);
		}
		drawItemEventArgs_0.DrawFocusRectangle();
	}
}
