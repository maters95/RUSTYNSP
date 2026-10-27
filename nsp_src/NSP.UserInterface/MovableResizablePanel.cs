using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using B;
using D;
using a;
using c;

namespace NSP.UserInterface;

public class MovableResizablePanel : Panel
{
	[CompilerGenerated]
	private static class A
	{
		public static EventHandler Blb;
	}

	protected const int SNAP_CLOSENESS = 10;

	private const int Hm = 8;

	[CompilerGenerated]
	private readonly int HN = 40;

	[CompilerGenerated]
	private readonly int Hn = 40;

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
			return HN;
		}
	}

	protected virtual int MIN_HEIGHT
	{
		[CompilerGenerated]
		get
		{
			return Hn;
		}
	}

	internal MovableResizablePanel(Rectangle P_0, bool P_1, bool P_2, bool P_3)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		if (P_3)
		{
			((Control)this).SetStyle((ControlStyles)8192, true);
			((Control)this).SetStyle((ControlStyles)131072, true);
			((Control)this).SetStyle((ControlStyles)2, true);
		}
		m_allowMoveAndResize = P_1;
		m_partialBorder = P_2;
		if (P_0 != Rectangle.Empty)
		{
			((Control)this).Left = ((Rectangle)(ref P_0)).Left;
			((Control)this).Top = ((Rectangle)(ref P_0)).Top;
			((Control)this).Width = ((Rectangle)(ref P_0)).Width;
			((Control)this).Height = ((Rectangle)(ref P_0)).Height;
		}
		((Control)this).BackColor = BM.tE;
		if (m_partialBorder)
		{
			((Panel)this).BorderStyle = (BorderStyle)0;
		}
		else if (BM.TO)
		{
			((Panel)this).BorderStyle = (BorderStyle)1;
		}
		else
		{
			((Panel)this).BorderStyle = (BorderStyle)0;
		}
		((Control)this).MouseDown += new MouseEventHandler(MouseDownHandler);
		((Control)this).MouseUp += new MouseEventHandler(MouseUpHandler);
		((Control)this).MouseMove += new MouseEventHandler(MouseMoveHandler);
		((Control)this).MouseLeave += new EventHandler(MouseLeaveHandler);
		object obj = MovableResizablePanel.A.Blb;
		if (obj == null)
		{
			EventHandler val = BM.X;
			MovableResizablePanel.A.Blb = val;
			obj = (object)val;
		}
		((Control)this).Click += (EventHandler)obj;
		((Control)this).Click += new EventHandler(OnPanelClicked);
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		try
		{
			((Control)this).MouseDown -= new MouseEventHandler(MouseDownHandler);
			((Control)this).MouseUp -= new MouseEventHandler(MouseUpHandler);
			((Control)this).MouseMove -= new MouseEventHandler(MouseMoveHandler);
			((Control)this).MouseLeave -= new EventHandler(MouseLeaveHandler);
			object obj = MovableResizablePanel.A.Blb;
			if (obj == null)
			{
				EventHandler val = BM.X;
				MovableResizablePanel.A.Blb = val;
				obj = (object)val;
			}
			((Control)this).Click -= (EventHandler)obj;
			((Control)this).Click -= new EventHandler(OnPanelClicked);
			((Control)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	internal bool B()
	{
		return BM.QQ.rl.A((Control)(object)this);
	}

	protected virtual void OnPanelClicked(object sender, EventArgs e)
	{
		if (((Control)this).Parent != null && (((Control)this).Parent.Parent == null || !(((Control)this).Parent.Parent is TabPage)))
		{
			if (((Control)this).Parent.Parent != null && (((Control)this).Parent.Parent.Parent == null || !(((Control)this).Parent.Parent.Parent is TabPage)))
			{
				if (((Control)this).Parent.Parent.Parent != null && (((Control)this).Parent.Parent.Parent.Parent == null || !(((Control)this).Parent.Parent.Parent.Parent is TabPage)))
				{
					if (((Control)this).Parent.Parent.Parent is DF)
					{
						((MovableResizablePanel)(((Control)this).Parent.Parent.Parent as DF)).b();
					}
					else if (((Control)this).Parent.Parent.Parent is Df)
					{
						(((Control)this).Parent.Parent.Parent as Df).b();
					}
					else if (((Control)this).Parent.Parent.Parent is aF && ((Control)this).Parent.Parent.Parent.Parent != null && ((Control)this).Parent.Parent.Parent.Parent is cq)
					{
						(((Control)this).Parent.Parent.Parent.Parent as cq).b();
					}
				}
				else if (((Control)this).Parent.Parent is DF)
				{
					((MovableResizablePanel)(((Control)this).Parent.Parent as DF)).b();
				}
				else if (((Control)this).Parent.Parent is Df)
				{
					(((Control)this).Parent.Parent as Df).b();
				}
				else if (((Control)this).Parent.Parent is aF && ((Control)this).Parent.Parent.Parent != null && ((Control)this).Parent.Parent.Parent is cq)
				{
					(((Control)this).Parent.Parent.Parent as cq).b();
				}
			}
			else if (((Control)this).Parent is DF)
			{
				((MovableResizablePanel)(((Control)this).Parent as DF)).b();
			}
			else if (((Control)this).Parent is Df)
			{
				(((Control)this).Parent as Df).b();
			}
			else if (((Control)this).Parent is aF && ((Control)this).Parent.Parent != null && ((Control)this).Parent.Parent is cq)
			{
				(((Control)this).Parent.Parent as cq).b();
			}
		}
		else
		{
			b();
		}
	}

	internal void b()
	{
		if (this is cq)
		{
			cq cq = this as cq;
			A(((Control)cq.B()).Controls);
		}
		else
		{
			A(((Control)this).Controls);
		}
	}

	private void A(ControlCollection P_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)P_0)
		{
			Control val = item;
			if (val is DE)
			{
				DE dE = val as DE;
				if (((Control)((cv)dE).b()).Focused && ((Control)((cv)dE).b()).Enabled)
				{
					dE.A(false);
					((TextBoxBase)((cv)dE).b()).SelectionStart = ((Control)((cv)dE).b()).Text.Length;
					((TextBoxBase)((cv)dE).b()).SelectionLength = 0;
					break;
				}
			}
			else if (val is Dd)
			{
				Dd dd = val as Dd;
				if (((Control)dd.b()).Focused && ((Control)dd.b()).Enabled)
				{
					dd.C();
					((TextBoxBase)dd.b()).SelectionStart = ((Control)dd.b()).Text.Length;
					((TextBoxBase)dd.b()).SelectionLength = 0;
					break;
				}
			}
			else if (val is ah)
			{
				ah ah = val as ah;
				if (((Control)ah.b()).Focused && ((Control)ah.b()).Enabled)
				{
					ah.e();
					((TextBoxBase)ah.b()).SelectionStart = ((Control)ah.b()).Text.Length;
					((TextBoxBase)ah.b()).SelectionLength = 0;
					break;
				}
			}
			else if (val is DF)
			{
				((MovableResizablePanel)(val as DF)).b();
			}
			else
			{
				if (!(val is Df))
				{
					continue;
				}
				foreach (Control item2 in (ArrangedElementCollection)((Control)(val as Df).B()).Controls)
				{
					Control val2 = item2;
					if (val2 is DF)
					{
						((MovableResizablePanel)(val2 as DF)).b();
					}
					else if (val2 is Df)
					{
						(val2 as Df).b();
					}
				}
			}
		}
	}

	public virtual void UpdateLayout(bool resizingOnly)
	{
	}

	internal void A(MouseButtons P_0, int P_1, int P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		if ((int)P_0 != 1048576)
		{
			return;
		}
		((Control)this).BringToFront();
		if (m_allowMoveAndResize && !BM.QQ.rl.a((Control)(object)this))
		{
			m_mouseDownX = P_1;
			m_mouseDownY = P_2;
			m_mouseDownWidth = ((Control)this).Width;
			m_mouseDownHeight = ((Control)this).Height;
			if (m_mouseDownX < 8)
			{
				m_isBeingResizedLeft = true;
			}
			if (m_mouseDownX >= ((Control)this).Width - 8)
			{
				m_isBeingResizedRight = true;
			}
			if (m_mouseDownY < 8)
			{
				m_isBeingResizedTop = true;
			}
			if (m_mouseDownY >= ((Control)this).Height - 8)
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		A(e.Button, e.X, e.Y);
	}

	internal void A(int P_0, int P_1)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		if (!m_allowMoveAndResize || BM.QQ.rl.a((Control)(object)this))
		{
			return;
		}
		int num = P_0 - m_mouseDownX;
		int num2 = P_1 - m_mouseDownY;
		if (num == 0 && num2 == 0)
		{
			return;
		}
		if (m_isBeingDragged)
		{
			B(num, num2);
		}
		else
		{
			int left = ((Control)this).Left;
			int top = ((Control)this).Top;
			int width = ((Control)this).Width;
			int height = ((Control)this).Height;
			if (m_isBeingResizedLeft)
			{
				A(num, false, ref left, ref top, ref width, ref height);
			}
			if (m_isBeingResizedRight)
			{
				a(num, false, ref left, ref top, ref width, ref height);
			}
			if (m_isBeingResizedTop)
			{
				B(num2, false, ref left, ref top, ref width, ref height);
			}
			if (m_isBeingResizedBottom)
			{
				b(num2, false, ref left, ref top, ref width, ref height);
			}
			if (left != ((Control)this).Left || top != ((Control)this).Top)
			{
				((Control)this).Location = new Point(left, top);
			}
			if (width != ((Control)this).Width || height != ((Control)this).Height)
			{
				((Control)this).Size = new Size(width, height);
				UpdateLayout(resizingOnly: true);
				((Control)this).Invalidate();
			}
		}
		UpdateCursorType(P_0, P_1);
	}

	protected virtual void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		A(e.X, e.Y);
	}

	internal void a(int P_0, int P_1)
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		int num = P_0 - m_mouseDownX;
		int num2 = P_1 - m_mouseDownY;
		if (num == 0 && num2 == 0)
		{
			m_isBeingDragged = false;
			m_isBeingResizedLeft = (m_isBeingResizedRight = (m_isBeingResizedTop = (m_isBeingResizedBottom = false)));
			return;
		}
		bool num3 = m_isBeingDragged || m_isBeingResizedLeft || m_isBeingResizedRight || m_isBeingResizedTop || m_isBeingResizedBottom;
		if (m_isBeingDragged)
		{
			B(num, num2);
			m_isBeingDragged = false;
		}
		else
		{
			int left = ((Control)this).Left;
			int top = ((Control)this).Top;
			int width = ((Control)this).Width;
			int height = ((Control)this).Height;
			if (m_isBeingResizedLeft)
			{
				A(num, true, ref left, ref top, ref width, ref height);
				m_isBeingResizedLeft = false;
			}
			if (m_isBeingResizedRight)
			{
				a(num, true, ref left, ref top, ref width, ref height);
				m_isBeingResizedRight = false;
			}
			if (m_isBeingResizedTop)
			{
				B(num2, true, ref left, ref top, ref width, ref height);
				m_isBeingResizedTop = false;
			}
			if (m_isBeingResizedBottom)
			{
				b(num2, true, ref left, ref top, ref width, ref height);
				m_isBeingResizedBottom = false;
			}
			if (left != ((Control)this).Left || top != ((Control)this).Top)
			{
				((Control)this).Location = new Point(left, top);
			}
			if (width != ((Control)this).Width || height != ((Control)this).Height)
			{
				((Control)this).Size = new Size(width, height);
				UpdateLayout(resizingOnly: false);
				((Control)this).Invalidate();
			}
		}
		if (num3)
		{
			BM.QQ.rl.a(false);
		}
	}

	protected virtual void MouseUpHandler(object sender, MouseEventArgs e)
	{
		a(e.X, e.Y);
	}

	protected virtual void MouseLeaveHandler(object sender, EventArgs e)
	{
		((Control)this).Cursor = Cursors.Default;
	}

	private void B(int P_0, int P_1)
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		GetEdgePositionsOfNearestSiblingControls(((Control)this).Left, ((Control)this).Top, ((Control)this).Right, ((Control)this).Bottom, out var nearestToLeft, out var nearestToTop, out var nearestToRight, out var nearestToBottom);
		bool flag;
		try
		{
			flag = Math.Abs(((Control)this).Left + P_0 - nearestToLeft) <= 10;
		}
		catch
		{
			flag = false;
		}
		bool flag2;
		try
		{
			flag2 = Math.Abs(nearestToRight - (((Control)this).Right + P_0)) <= 10;
		}
		catch
		{
			flag2 = false;
		}
		bool flag3;
		try
		{
			flag3 = Math.Abs(((Control)this).Top + P_1 - nearestToTop) <= 10;
		}
		catch
		{
			flag3 = false;
		}
		bool flag4;
		try
		{
			flag4 = Math.Abs(nearestToBottom - (((Control)this).Bottom + P_1)) <= 10;
		}
		catch
		{
			flag4 = false;
		}
		int num = (flag ? Math.Max(0, nearestToLeft) : ((!flag2) ? Math.Max(0, ((Control)this).Left + P_0) : Math.Max(0, nearestToRight - ((Control)this).Width)));
		int num2 = (flag3 ? Math.Max(0, nearestToTop) : ((!flag4) ? Math.Max(0, ((Control)this).Top + P_1) : Math.Max(0, nearestToBottom - ((Control)this).Height)));
		if (num != ((Control)this).Left || num2 != ((Control)this).Top)
		{
			((Control)this).Location = new Point(num, num2);
		}
	}

	private void A(int P_0, bool P_1, ref int P_2, ref int P_3, ref int P_4, ref int P_5)
	{
		GetEdgePositionsOfNearestSiblingControls(P_2, P_3, P_2 + P_4, P_3 + P_5, out var nearestToLeft, out var _, out var _, out var _);
		bool flag;
		try
		{
			flag = Math.Abs(P_2 + P_0 - nearestToLeft) <= 10;
		}
		catch
		{
			flag = false;
		}
		if (flag)
		{
			int num = P_2 - nearestToLeft;
			P_2 = nearestToLeft;
			P_4 += num;
		}
		else if (P_4 - P_0 < MIN_WIDTH)
		{
			P_4 = MIN_WIDTH;
		}
		else
		{
			P_2 += P_0;
			P_4 -= P_0;
		}
	}

	private void a(int P_0, bool P_1, ref int P_2, ref int P_3, ref int P_4, ref int P_5)
	{
		P_4 = Math.Max(m_mouseDownWidth + P_0, MIN_WIDTH);
		GetEdgePositionsOfNearestSiblingControls(P_2, P_3, P_2 + P_4, P_3 + P_5, out var _, out var _, out var nearestToRight, out var _);
		bool flag;
		try
		{
			flag = Math.Abs(nearestToRight - (P_2 + P_4)) <= 10;
		}
		catch
		{
			flag = false;
		}
		if (flag)
		{
			P_4 = Math.Max(nearestToRight - P_2, MIN_WIDTH);
		}
	}

	private void B(int P_0, bool P_1, ref int P_2, ref int P_3, ref int P_4, ref int P_5)
	{
		GetEdgePositionsOfNearestSiblingControls(P_2, P_3, P_2 + P_4, P_3 + P_5, out var _, out var nearestToTop, out var _, out var _);
		bool flag;
		try
		{
			flag = Math.Abs(P_3 + P_0 - nearestToTop) <= 10;
		}
		catch
		{
			flag = false;
		}
		if (flag)
		{
			int num = P_3 - nearestToTop;
			P_3 = nearestToTop;
			P_5 += num;
		}
		else if (P_5 - P_0 < MIN_HEIGHT)
		{
			P_5 = MIN_HEIGHT;
		}
		else
		{
			P_3 += P_0;
			P_5 -= P_0;
		}
	}

	private void b(int P_0, bool P_1, ref int P_2, ref int P_3, ref int P_4, ref int P_5)
	{
		P_5 = Math.Max(m_mouseDownHeight + P_0, MIN_HEIGHT);
		GetEdgePositionsOfNearestSiblingControls(P_2, P_3, P_2 + P_4, P_3 + P_5, out var _, out var _, out var _, out var nearestToBottom);
		bool flag;
		try
		{
			flag = Math.Abs(nearestToBottom - (P_3 + P_5)) <= 10;
		}
		catch
		{
			flag = false;
		}
		if (flag)
		{
			P_5 = Math.Max(nearestToBottom - P_3, MIN_HEIGHT);
		}
	}

	protected virtual void UpdateCursorType(int x, int y)
	{
		if (BM.QQ.rl.a((Control)(object)this))
		{
			((Control)this).Cursor = Cursors.Default;
		}
		else if (x < 8 && y < 8)
		{
			((Control)this).Cursor = Cursors.SizeNWSE;
		}
		else if (x >= ((Control)this).Width - 8 && y >= ((Control)this).Height - 8)
		{
			((Control)this).Cursor = Cursors.SizeNWSE;
		}
		else if (x >= ((Control)this).Width - 8 && y < 8)
		{
			((Control)this).Cursor = Cursors.SizeNESW;
		}
		else if (y >= ((Control)this).Height - 8 && x < 8)
		{
			((Control)this).Cursor = Cursors.SizeNESW;
		}
		else if (x < 8 || x >= ((Control)this).Width - 8)
		{
			((Control)this).Cursor = Cursors.SizeWE;
		}
		else if (y < 8 || y >= ((Control)this).Height - 8)
		{
			((Control)this).Cursor = Cursors.SizeNS;
		}
		else
		{
			((Control)this).Cursor = Cursors.Default;
		}
	}

	protected void GetEdgePositionsOfNearestSiblingControls(int left, int top, int right, int bottom, out int nearestToLeft, out int nearestToTop, out int nearestToRight, out int nearestToBottom)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		nearestToLeft = 0;
		nearestToTop = 0;
		nearestToRight = 2147483647;
		nearestToBottom = 2147483647;
		if (((Control)this).Parent == null)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).Parent.Controls)
		{
			Control val = item;
			if (val == this)
			{
				continue;
			}
			Control val2 = val;
			if ((val2.Top >= top && val2.Top <= bottom) || (val2.Bottom >= top && val2.Bottom <= bottom) || (val2.Top <= top && val2.Bottom >= bottom))
			{
				if (val2.Right >= left - 10 && val2.Right <= left + 10)
				{
					nearestToLeft = Math.Max(nearestToLeft, val2.Right);
				}
				else if (val2.Left >= left - 10 && val2.Left <= left + 10)
				{
					nearestToLeft = Math.Max(nearestToLeft, val2.Left);
				}
				if (val2.Left >= right - 10 && val2.Left <= right + 10)
				{
					nearestToRight = Math.Min(nearestToRight, val2.Left);
				}
				else if (val2.Right >= right - 10 && val2.Right <= right + 10)
				{
					nearestToRight = Math.Min(nearestToRight, val2.Right);
				}
			}
			if ((val2.Left >= left && val2.Left <= right) || (val2.Right >= left && val2.Right <= right) || (val2.Left <= left && val2.Right >= right))
			{
				if (val2.Bottom >= top - 10 && val2.Bottom <= top + 10)
				{
					nearestToTop = Math.Max(nearestToTop, val2.Bottom);
				}
				else if (val2.Top >= top - 10 && val2.Top <= top + 10)
				{
					nearestToTop = Math.Max(nearestToTop, val2.Top);
				}
				if (val2.Top >= bottom - 10 && val2.Top <= bottom + 10)
				{
					nearestToBottom = Math.Min(nearestToBottom, val2.Top);
				}
				else if (val2.Bottom >= bottom - 10 && val2.Bottom <= bottom + 10)
				{
					nearestToBottom = Math.Min(nearestToBottom, val2.Bottom);
				}
			}
		}
	}

	[SpecialName]
	internal void A(bool P_0)
	{
		m_highlight = P_0;
		if (m_highlight)
		{
			((Panel)this).BorderStyle = (BorderStyle)2;
		}
		else if (m_partialBorder)
		{
			((Panel)this).BorderStyle = (BorderStyle)0;
		}
		else if (BM.TO)
		{
			((Panel)this).BorderStyle = (BorderStyle)1;
		}
		else
		{
			((Panel)this).BorderStyle = (BorderStyle)0;
		}
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnPaint(e);
		if ((int)((Panel)this).BorderStyle != 2)
		{
			if (m_partialBorder)
			{
				e.Graphics.DrawLine(Pens.Gray, 0, 5, 0, ((Control)this).Bottom - 5);
			}
			else if (!BM.TO)
			{
				ControlPaint.DrawBorder(e.Graphics, ((Control)this).ClientRectangle, BM.td, (ButtonBorderStyle)3);
			}
		}
	}
}
