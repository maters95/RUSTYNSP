using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns1;
using ns2;
using ns3;
using ns4;

namespace NSP.UserInterface;

public class MovableResizablePanel : Panel
{
	[CompilerGenerated]
	private static class Class125
	{
		public static EventHandler Blb;
	}

	protected const int SNAP_CLOSENESS = 10;

	private const int int_0 = 8;

	[CompilerGenerated]
	private readonly int int_1 = 40;

	[CompilerGenerated]
	private readonly int int_2 = 40;

	protected bool m_isBeingDragged;

	protected bool m_isBeingResizedLeft;

	protected bool m_isBeingResizedRight;

	protected bool m_isBeingResizedTop;

	protected bool m_isBeingResizedBottom;

	protected int m_mouseDownX;

	protected int m_mouseDownY;

	protected int m_mouseDownWidth;

	protected int m_mouseDownHeight;

	protected bool m_highlight;

	protected bool m_allowMoveAndResize;

	protected bool m_partialBorder;

	protected virtual int MIN_WIDTH
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
	}

	protected virtual int MIN_HEIGHT
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
	}

	internal MovableResizablePanel(Rectangle rectangle_0, bool bool_0, bool bool_1, bool bool_2)
	{
		if (bool_2)
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
			SetStyle(ControlStyles.UserPaint, value: true);
		}
		m_allowMoveAndResize = bool_0;
		m_partialBorder = bool_1;
		if (rectangle_0 != Rectangle.Empty)
		{
			Left = rectangle_0.Left;
			Top = rectangle_0.Top;
			Width = rectangle_0.Width;
			Height = rectangle_0.Height;
		}
		BackColor = Form23.color_11;
		if (m_partialBorder)
		{
			BorderStyle = BorderStyle.None;
		}
		else if (Form23.bool_43)
		{
			BorderStyle = BorderStyle.FixedSingle;
		}
		else
		{
			BorderStyle = BorderStyle.None;
		}
		MouseDown += MouseDownHandler;
		MouseUp += MouseUpHandler;
		MouseMove += MouseMoveHandler;
		MouseLeave += MouseLeaveHandler;
		Click += Form23.smethod_53;
		Click += OnPanelClicked;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			MouseDown -= MouseDownHandler;
			MouseUp -= MouseUpHandler;
			MouseMove -= MouseMoveHandler;
			MouseLeave -= MouseLeaveHandler;
			Click -= Form23.smethod_53;
			Click -= OnPanelClicked;
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	internal bool method_0()
	{
		return Form23.form23_0.control25_0.method_24(this);
	}

	protected virtual void OnPanelClicked(object sender, EventArgs e)
	{
		if (Parent != null && (Parent.Parent == null || !(Parent.Parent is TabPage)))
		{
			if (Parent.Parent != null && (Parent.Parent.Parent == null || !(Parent.Parent.Parent is TabPage)))
			{
				if (Parent.Parent.Parent != null && (Parent.Parent.Parent.Parent == null || !(Parent.Parent.Parent.Parent is TabPage)))
				{
					if (Parent.Parent.Parent is Class117)
					{
						(Parent.Parent.Parent as Class117).method_1();
					}
					else if (Parent.Parent.Parent is Class118)
					{
						(Parent.Parent.Parent as Class118).method_1();
					}
					else if (Parent.Parent.Parent is Class131 && Parent.Parent.Parent.Parent != null && Parent.Parent.Parent.Parent is Class109)
					{
						(Parent.Parent.Parent.Parent as Class109).method_1();
					}
				}
				else if (Parent.Parent is Class117)
				{
					(Parent.Parent as Class117).method_1();
				}
				else if (Parent.Parent is Class118)
				{
					(Parent.Parent as Class118).method_1();
				}
				else if (Parent.Parent is Class131 && Parent.Parent.Parent != null && Parent.Parent.Parent is Class109)
				{
					(Parent.Parent.Parent as Class109).method_1();
				}
			}
			else if (Parent is Class117)
			{
				(Parent as Class117).method_1();
			}
			else if (Parent is Class118)
			{
				(Parent as Class118).method_1();
			}
			else if (Parent is Class131 && Parent.Parent != null && Parent.Parent is Class109)
			{
				(Parent.Parent as Class109).method_1();
			}
		}
		else
		{
			method_1();
		}
	}

	internal void method_1()
	{
		if (this is Class109)
		{
			Class109 @class = this as Class109;
			method_2(@class.method_12().Controls);
		}
		else
		{
			method_2(Controls);
		}
	}

	private void method_2(ControlCollection controlCollection_0)
	{
		foreach (Control item in controlCollection_0)
		{
			if (item is Control21)
			{
				Control21 control2 = item as Control21;
				if (control2.method_2().Focused && control2.method_2().Enabled)
				{
					control2.method_20(bool_2: false);
					control2.method_2().SelectionStart = control2.method_2().Text.Length;
					control2.method_2().SelectionLength = 0;
					break;
				}
			}
			else if (item is Control20)
			{
				Control20 control3 = item as Control20;
				if (control3.method_2().Focused && control3.method_2().Enabled)
				{
					control3.method_15();
					control3.method_2().SelectionStart = control3.method_2().Text.Length;
					control3.method_2().SelectionLength = 0;
					break;
				}
			}
			else if (item is Control7)
			{
				Control7 control4 = item as Control7;
				if (control4.method_4().Focused && control4.method_4().Enabled)
				{
					control4.method_13();
					control4.method_4().SelectionStart = control4.method_4().Text.Length;
					control4.method_4().SelectionLength = 0;
					break;
				}
			}
			else if (item is Class117)
			{
				(item as Class117).method_1();
			}
			else
			{
				if (!(item is Class118))
				{
					continue;
				}
				foreach (Control control5 in (item as Class118).method_12().Controls)
				{
					if (control5 is Class117)
					{
						(control5 as Class117).method_1();
					}
					else if (control5 is Class118)
					{
						(control5 as Class118).method_1();
					}
				}
			}
		}
	}

	public virtual void UpdateLayout(bool resizingOnly)
	{
	}

	internal void method_3(MouseButtons mouseButtons_0, int int_3, int int_4)
	{
		if (mouseButtons_0 != MouseButtons.Left)
		{
			return;
		}
		BringToFront();
		if (m_allowMoveAndResize && !Form23.form23_0.control25_0.method_25(this))
		{
			m_mouseDownX = int_3;
			m_mouseDownY = int_4;
			m_mouseDownWidth = Width;
			m_mouseDownHeight = Height;
			if (m_mouseDownX < 8)
			{
				m_isBeingResizedLeft = true;
			}
			if (m_mouseDownX >= Width - 8)
			{
				m_isBeingResizedRight = true;
			}
			if (m_mouseDownY < 8)
			{
				m_isBeingResizedTop = true;
			}
			if (m_mouseDownY >= Height - 8)
			{
				m_isBeingResizedBottom = true;
			}
			if (!m_isBeingResizedLeft && !m_isBeingResizedRight && !m_isBeingResizedTop && !m_isBeingResizedBottom)
			{
				m_isBeingDragged = true;
			}
		}
	}

	protected virtual void MouseDownHandler(object sender, MouseEventArgs e)
	{
		method_3(e.Button, e.X, e.Y);
	}

	internal void method_4(int int_3, int int_4)
	{
		if (!m_allowMoveAndResize || Form23.form23_0.control25_0.method_25(this))
		{
			return;
		}
		int num = int_3 - m_mouseDownX;
		int num2 = int_4 - m_mouseDownY;
		if (num == 0 && num2 == 0)
		{
			return;
		}
		if (m_isBeingDragged)
		{
			method_6(num, num2);
		}
		else
		{
			int int_5 = Left;
			int int_6 = Top;
			int int_7 = Width;
			int int_8 = Height;
			if (m_isBeingResizedLeft)
			{
				method_7(num, bool_0: false, ref int_5, ref int_6, ref int_7, ref int_8);
			}
			if (m_isBeingResizedRight)
			{
				method_8(num, bool_0: false, ref int_5, ref int_6, ref int_7, ref int_8);
			}
			if (m_isBeingResizedTop)
			{
				method_9(num2, bool_0: false, ref int_5, ref int_6, ref int_7, ref int_8);
			}
			if (m_isBeingResizedBottom)
			{
				method_10(num2, bool_0: false, ref int_5, ref int_6, ref int_7, ref int_8);
			}
			if (int_5 != Left || int_6 != Top)
			{
				Location = new Point(int_5, int_6);
			}
			if (int_7 != Width || int_8 != Height)
			{
				Size = new Size(int_7, int_8);
				UpdateLayout(resizingOnly: true);
				Invalidate();
			}
		}
		UpdateCursorType(int_3, int_4);
	}

	protected virtual void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		method_4(e.X, e.Y);
	}

	internal void method_5(int int_3, int int_4)
	{
		int num = int_3 - m_mouseDownX;
		int num2 = int_4 - m_mouseDownY;
		if (num == 0 && num2 == 0)
		{
			m_isBeingDragged = false;
			m_isBeingResizedBottom = false;
			m_isBeingResizedTop = false;
			m_isBeingResizedRight = false;
			m_isBeingResizedLeft = false;
			return;
		}
		bool num3 = m_isBeingDragged || m_isBeingResizedLeft || m_isBeingResizedRight || m_isBeingResizedTop || m_isBeingResizedBottom;
		if (m_isBeingDragged)
		{
			method_6(num, num2);
			m_isBeingDragged = false;
		}
		else
		{
			int int_5 = Left;
			int int_6 = Top;
			int int_7 = Width;
			int int_8 = Height;
			if (m_isBeingResizedLeft)
			{
				method_7(num, bool_0: true, ref int_5, ref int_6, ref int_7, ref int_8);
				m_isBeingResizedLeft = false;
			}
			if (m_isBeingResizedRight)
			{
				method_8(num, bool_0: true, ref int_5, ref int_6, ref int_7, ref int_8);
				m_isBeingResizedRight = false;
			}
			if (m_isBeingResizedTop)
			{
				method_9(num2, bool_0: true, ref int_5, ref int_6, ref int_7, ref int_8);
				m_isBeingResizedTop = false;
			}
			if (m_isBeingResizedBottom)
			{
				method_10(num2, bool_0: true, ref int_5, ref int_6, ref int_7, ref int_8);
				m_isBeingResizedBottom = false;
			}
			if (int_5 != Left || int_6 != Top)
			{
				Location = new Point(int_5, int_6);
			}
			if (int_7 != Width || int_8 != Height)
			{
				Size = new Size(int_7, int_8);
				UpdateLayout(resizingOnly: false);
				Invalidate();
			}
		}
		if (num3)
		{
			Form23.form23_0.control25_0.method_12(bool_0: false);
		}
	}

	protected virtual void MouseUpHandler(object sender, MouseEventArgs e)
	{
		method_5(e.X, e.Y);
	}

	protected virtual void MouseLeaveHandler(object sender, EventArgs e)
	{
		Cursor = Cursors.Default;
	}

	private void method_6(int int_3, int int_4)
	{
		GetEdgePositionsOfNearestSiblingControls(Left, Top, Right, Bottom, out var nearestToLeft, out var nearestToTop, out var nearestToRight, out var nearestToBottom);
		bool flag;
		try
		{
			flag = Math.Abs(Left + int_3 - nearestToLeft) <= 10;
		}
		catch
		{
			flag = false;
		}
		bool flag2;
		try
		{
			flag2 = Math.Abs(nearestToRight - (Right + int_3)) <= 10;
		}
		catch
		{
			flag2 = false;
		}
		bool flag3;
		try
		{
			flag3 = Math.Abs(Top + int_4 - nearestToTop) <= 10;
		}
		catch
		{
			flag3 = false;
		}
		bool flag4;
		try
		{
			flag4 = Math.Abs(nearestToBottom - (Bottom + int_4)) <= 10;
		}
		catch
		{
			flag4 = false;
		}
		int num;
		if (flag)
		{
			num = Math.Max(0, nearestToLeft);
		}
		else
		{
			num = ((!flag2) ? Math.Max(0, Left + int_3) : Math.Max(0, nearestToRight - Width));
		}
		int num2;
		if (flag3)
		{
			num2 = Math.Max(0, nearestToTop);
		}
		else
		{
			num2 = ((!flag4) ? Math.Max(0, Top + int_4) : Math.Max(0, nearestToBottom - Height));
		}
		if (num != Left || num2 != Top)
		{
			Location = new Point(num, num2);
		}
	}

	private void method_7(int int_3, bool bool_0, ref int int_4, ref int int_5, ref int int_6, ref int int_7)
	{
		GetEdgePositionsOfNearestSiblingControls(int_4, int_5, int_4 + int_6, int_5 + int_7, out var nearestToLeft, out var _, out var _, out var _);
		bool flag;
		try
		{
			flag = Math.Abs(int_4 + int_3 - nearestToLeft) <= 10;
		}
		catch
		{
			flag = false;
		}
		if (flag)
		{
			int num = int_4 - nearestToLeft;
			int_4 = nearestToLeft;
			int_6 += num;
		}
		else if (int_6 - int_3 < MIN_WIDTH)
		{
			int_6 = MIN_WIDTH;
		}
		else
		{
			int_4 += int_3;
			int_6 -= int_3;
		}
	}

	private void method_8(int int_3, bool bool_0, ref int int_4, ref int int_5, ref int int_6, ref int int_7)
	{
		int_6 = Math.Max(m_mouseDownWidth + int_3, MIN_WIDTH);
		GetEdgePositionsOfNearestSiblingControls(int_4, int_5, int_4 + int_6, int_5 + int_7, out var _, out var _, out var nearestToRight, out var _);
		bool flag;
		try
		{
			flag = Math.Abs(nearestToRight - (int_4 + int_6)) <= 10;
		}
		catch
		{
			flag = false;
		}
		if (flag)
		{
			int_6 = Math.Max(nearestToRight - int_4, MIN_WIDTH);
		}
	}

	private void method_9(int int_3, bool bool_0, ref int int_4, ref int int_5, ref int int_6, ref int int_7)
	{
		GetEdgePositionsOfNearestSiblingControls(int_4, int_5, int_4 + int_6, int_5 + int_7, out var _, out var nearestToTop, out var _, out var _);
		bool flag;
		try
		{
			flag = Math.Abs(int_5 + int_3 - nearestToTop) <= 10;
		}
		catch
		{
			flag = false;
		}
		if (flag)
		{
			int num = int_5 - nearestToTop;
			int_5 = nearestToTop;
			int_7 += num;
		}
		else if (int_7 - int_3 < MIN_HEIGHT)
		{
			int_7 = MIN_HEIGHT;
		}
		else
		{
			int_5 += int_3;
			int_7 -= int_3;
		}
	}

	private void method_10(int int_3, bool bool_0, ref int int_4, ref int int_5, ref int int_6, ref int int_7)
	{
		int_7 = Math.Max(m_mouseDownHeight + int_3, MIN_HEIGHT);
		GetEdgePositionsOfNearestSiblingControls(int_4, int_5, int_4 + int_6, int_5 + int_7, out var _, out var _, out var _, out var nearestToBottom);
		bool flag;
		try
		{
			flag = Math.Abs(nearestToBottom - (int_5 + int_7)) <= 10;
		}
		catch
		{
			flag = false;
		}
		if (flag)
		{
			int_7 = Math.Max(nearestToBottom - int_5, MIN_HEIGHT);
		}
	}

	protected virtual void UpdateCursorType(int int_3, int int_4)
	{
		if (Form23.form23_0.control25_0.method_25(this))
		{
			Cursor = Cursors.Default;
		}
		else if (int_3 < 8 && int_4 < 8)
		{
			Cursor = Cursors.SizeNWSE;
		}
		else if (int_3 >= Width - 8 && int_4 >= Height - 8)
		{
			Cursor = Cursors.SizeNWSE;
		}
		else if (int_3 >= Width - 8 && int_4 < 8)
		{
			Cursor = Cursors.SizeNESW;
		}
		else if (int_4 >= Height - 8 && int_3 < 8)
		{
			Cursor = Cursors.SizeNESW;
		}
		else if (int_3 >= 8 && int_3 < Width - 8)
		{
			if (int_4 >= 8 && int_4 < Height - 8)
			{
				Cursor = Cursors.Default;
			}
			else
			{
				Cursor = Cursors.SizeNS;
			}
		}
		else
		{
			Cursor = Cursors.SizeWE;
		}
	}

	protected void GetEdgePositionsOfNearestSiblingControls(int left, int top, int right, int bottom, out int nearestToLeft, out int nearestToTop, out int nearestToRight, out int nearestToBottom)
	{
		nearestToLeft = 0;
		nearestToTop = 0;
		nearestToRight = int.MaxValue;
		nearestToBottom = int.MaxValue;
		if (Parent == null)
		{
			return;
		}
		foreach (Control control3 in Parent.Controls)
		{
			if (control3 == this)
			{
				continue;
			}
			Control control2 = control3;
			if ((control2.Top >= top && control2.Top <= bottom) || (control2.Bottom >= top && control2.Bottom <= bottom) || (control2.Top <= top && control2.Bottom >= bottom))
			{
				if (control2.Right >= left - 10 && control2.Right <= left + 10)
				{
					nearestToLeft = Math.Max(nearestToLeft, control2.Right);
				}
				else if (control2.Left >= left - 10 && control2.Left <= left + 10)
				{
					nearestToLeft = Math.Max(nearestToLeft, control2.Left);
				}
				if (control2.Left >= right - 10 && control2.Left <= right + 10)
				{
					nearestToRight = Math.Min(nearestToRight, control2.Left);
				}
				else if (control2.Right >= right - 10 && control2.Right <= right + 10)
				{
					nearestToRight = Math.Min(nearestToRight, control2.Right);
				}
			}
			if ((control2.Left >= left && control2.Left <= right) || (control2.Right >= left && control2.Right <= right) || (control2.Left <= left && control2.Right >= right))
			{
				if (control2.Bottom >= top - 10 && control2.Bottom <= top + 10)
				{
					nearestToTop = Math.Max(nearestToTop, control2.Bottom);
				}
				else if (control2.Top >= top - 10 && control2.Top <= top + 10)
				{
					nearestToTop = Math.Max(nearestToTop, control2.Top);
				}
				if (control2.Top >= bottom - 10 && control2.Top <= bottom + 10)
				{
					nearestToBottom = Math.Min(nearestToBottom, control2.Top);
				}
				else if (control2.Bottom >= bottom - 10 && control2.Bottom <= bottom + 10)
				{
					nearestToBottom = Math.Min(nearestToBottom, control2.Bottom);
				}
			}
		}
	}

	[SpecialName]
	internal void method_11(bool bool_0)
	{
		m_highlight = bool_0;
		if (m_highlight)
		{
			BorderStyle = BorderStyle.Fixed3D;
		}
		else if (m_partialBorder)
		{
			BorderStyle = BorderStyle.None;
		}
		else if (Form23.bool_43)
		{
			BorderStyle = BorderStyle.FixedSingle;
		}
		else
		{
			BorderStyle = BorderStyle.None;
		}
		Invalidate();
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		if (BorderStyle != BorderStyle.Fixed3D)
		{
			if (m_partialBorder)
			{
				paintEventArgs_0.Graphics.DrawLine(Pens.Gray, 0, 5, 0, Bottom - 5);
			}
			else if (!Form23.bool_43)
			{
				ControlPaint.DrawBorder(paintEventArgs_0.Graphics, ClientRectangle, Form23.color_10, ButtonBorderStyle.Solid);
			}
		}
	}
}
