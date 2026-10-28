using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns3;
using ns4;

namespace ns1;

internal class Class109 : MovableResizablePanel
{
	[CompilerGenerated]
	private static class Class126
	{
		public static EventHandler BWd;
	}

	private Class131 BlC = new Class131();

	private bool Blc;

	private int BlD;

	private int Bld;

	internal Class109(Rectangle rectangle_0, bool bool_0, bool bool_1)
		: base(rectangle_0, bool_0, bool_1, bool_2: false)
	{
		Resize += Class109_Resize;
		BlC.MouseDown += BlC_MouseDown;
		BlC.MouseUp += BlC_MouseUp;
		BlC.MouseMove += BlC_MouseMove;
		BlC.Click += Form23.smethod_53;
		BlC.Click += BlC_Click;
		BlC.BorderStyle = BorderStyle.None;
		BlC.Left = 5;
		BlC.Top = 5;
		method_13();
		Controls.Add(BlC);
	}

	[SpecialName]
	internal Class131 method_12()
	{
		return BlC;
	}

	private void Class109_Resize(object sender, EventArgs e)
	{
		method_13();
	}

	private void method_13()
	{
		BlC.Size = new Size(Width - 10, Height - 10);
	}

	internal void method_14()
	{
		BlC.method_2();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			Resize -= Class109_Resize;
			BlC.MouseDown -= BlC_MouseDown;
			BlC.MouseUp -= BlC_MouseUp;
			BlC.MouseMove -= BlC_MouseMove;
			BlC.Click -= Form23.smethod_53;
			BlC.Click -= BlC_Click;
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	protected override void OnPanelClicked(object sender, EventArgs e)
	{
	}

	private void BlC_Click(object sender, EventArgs e)
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

	protected override void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		base.MouseMoveHandler(sender, e);
		if (m_isBeingResizedLeft || m_isBeingResizedRight || m_isBeingResizedTop || m_isBeingResizedBottom)
		{
			method_13();
		}
	}

	private void BlC_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			BringToFront();
			if (m_allowMoveAndResize && !Form23.form23_0.control25_0.method_25(this))
			{
				BlD = e.X;
				Bld = e.Y;
				Blc = true;
			}
		}
	}

	private void BlC_MouseMove(object sender, MouseEventArgs e)
	{
		if (!m_allowMoveAndResize || Form23.form23_0.control25_0.method_25(this) || !Blc)
		{
			return;
		}
		int num = e.X - BlD;
		int num2 = e.Y - Bld;
		if (num != 0 || num2 != 0)
		{
			GetEdgePositionsOfNearestSiblingControls(Left, Top, Right, Bottom, out var nearestToLeft, out var nearestToTop, out var nearestToRight, out var nearestToBottom);
			bool flag;
			try
			{
				flag = Math.Abs(Left + num - nearestToLeft) <= 10;
			}
			catch
			{
				flag = false;
			}
			bool flag2;
			try
			{
				flag2 = Math.Abs(nearestToRight - (Right + num)) <= 10;
			}
			catch
			{
				flag2 = false;
			}
			bool flag3;
			try
			{
				flag3 = Math.Abs(Top + num2 - nearestToTop) <= 10;
			}
			catch
			{
				flag3 = false;
			}
			bool flag4;
			try
			{
				flag4 = Math.Abs(nearestToBottom - (Bottom + num2)) <= 10;
			}
			catch
			{
				flag4 = false;
			}
			int left = Left;
			if (flag)
			{
				left = Math.Max(0, nearestToLeft);
			}
			else
			{
				left = ((!flag2) ? Math.Max(0, Left + num) : Math.Max(0, nearestToRight - Width));
			}
			int top = Top;
			if (flag3)
			{
				top = Math.Max(0, nearestToTop);
			}
			else
			{
				top = ((!flag4) ? Math.Max(0, Top + num2) : Math.Max(0, nearestToBottom - Height));
			}
			if (left != Left || top != Top)
			{
				Location = new Point(left, top);
			}
		}
	}

	private void BlC_MouseUp(object sender, MouseEventArgs e)
	{
		bool blc = Blc;
		Blc = false;
		if (blc)
		{
			Form23.form23_0.control25_0.method_12(bool_0: false);
		}
	}
}
