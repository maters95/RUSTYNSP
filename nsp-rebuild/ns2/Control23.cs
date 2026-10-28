using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns4;
using ns7;

namespace ns2;

internal class Control23 : Control
{
	internal const int int_0 = 18;

	private int int_1;

	private int int_2 = 10;

	private int int_3 = 1;

	private int int_4;

	private int int_5 = 100;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private IContainer icontainer_0;

	[SpecialName]
	[CompilerGenerated]
	internal void method_0(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal Control23()
	{
		method_13();
		SuspendLayout();
		Name = Class333.smethod_676();
		MouseDown += Control23_MouseDown;
		MouseMove += Control23_MouseMove;
		MouseUp += Control23_MouseUp;
		MouseLeave += Control23_MouseLeave;
		ResumeLayout(performLayout: false);
		SetStyle(ControlStyles.ResizeRedraw, value: true);
		SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
		SetStyle(ControlStyles.DoubleBuffer, value: true);
		SetStyle(ControlStyles.UserPaint, value: true);
		Height = 18;
		int_1 = Height;
		base.MinimumSize = new Size(int_1 + int_1 + method_12(), int_1);
	}

	[SpecialName]
	internal int method_2()
	{
		return int_2;
	}

	[SpecialName]
	internal void method_3(int int_10)
	{
		int_2 = int_10;
		Invalidate();
	}

	[SpecialName]
	internal int method_4()
	{
		return int_3;
	}

	[SpecialName]
	internal void method_5(int int_10)
	{
		int_3 = int_10;
		Invalidate();
	}

	[SpecialName]
	internal int method_6()
	{
		return int_4;
	}

	[SpecialName]
	internal void method_7(int int_10)
	{
		int_4 = int_10;
		Invalidate();
	}

	[SpecialName]
	internal int method_8()
	{
		return int_5;
	}

	[SpecialName]
	internal void method_9(int int_10)
	{
		int_5 = int_10;
		Invalidate();
	}

	[SpecialName]
	internal int method_10()
	{
		return int_6;
	}

	[SpecialName]
	internal void method_11(int int_10)
	{
		int_6 = int_10;
		int num = Width - 2 * int_1 - method_12();
		int num2 = method_8() - method_6() - method_2();
		float num3 = 0f;
		if (num2 != 0)
		{
			num3 = (float)int_6 / (float)num2;
		}
		float num4 = num3 * (float)num;
		int_9 = Math.Max((int)num4, 0);
		if (int_9 > num)
		{
			int_9 = num;
			num3 = (float)int_9 / (float)num;
			int_6 = (int)(num3 * (float)(method_8() - method_2()));
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
		}
		Invalidate();
	}

	private int method_12()
	{
		int num = 10;
		if (method_8() == 0)
		{
			return num;
		}
		int num2 = Width - 2 * int_1;
		float val = (float)method_2() * (float)num2 / (float)method_8();
		return Convert.ToInt32(Math.Min(num2, Math.Max(val, num)));
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		using (SolidBrush brush = new SolidBrush(Form23.color_26))
		{
			paintEventArgs_0.Graphics.FillRectangle(brush, 0, 0, Width, Height);
		}
		Point[] points = new Point[3]
		{
			new Point(int_1 / 4, int_1 / 2 - 1),
			new Point(int_1 * 5 / 8, int_1 / 5 - 1),
			new Point(int_1 * 5 / 8, int_1 * 4 / 5 - 1)
		};
		if (bool_2)
		{
			using SolidBrush brush2 = new SolidBrush(Form23.color_29);
			paintEventArgs_0.Graphics.FillPolygon(brush2, points);
		}
		else if (bool_5)
		{
			using SolidBrush brush3 = new SolidBrush(Form23.color_28);
			paintEventArgs_0.Graphics.FillPolygon(brush3, points);
		}
		else
		{
			using SolidBrush brush4 = new SolidBrush(Form23.color_27);
			paintEventArgs_0.Graphics.FillPolygon(brush4, points);
		}
		Point[] points2 = new Point[3]
		{
			new Point(Width - int_1 + int_1 * 3 / 4, int_1 / 2 - 1),
			new Point(Width - int_1 + int_1 * 3 / 8, int_1 / 5 - 1),
			new Point(Width - int_1 + int_1 * 3 / 8, int_1 * 4 / 5 - 1)
		};
		if (bool_3)
		{
			using SolidBrush brush5 = new SolidBrush(Form23.color_29);
			paintEventArgs_0.Graphics.FillPolygon(brush5, points2);
		}
		else if (bool_6)
		{
			using SolidBrush brush6 = new SolidBrush(Form23.color_28);
			paintEventArgs_0.Graphics.FillPolygon(brush6, points2);
		}
		else
		{
			using SolidBrush brush7 = new SolidBrush(Form23.color_27);
			paintEventArgs_0.Graphics.FillPolygon(brush7, points2);
		}
		int num = method_12();
		if (int_1 + int_9 + num > Width - int_1)
		{
			num = Width - int_1 - (int_1 + int_9);
		}
		if (bool_0)
		{
			using (SolidBrush brush8 = new SolidBrush(Form23.color_29))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush8, int_1 + int_9, 3, num, Height - 8);
				return;
			}
		}
		if (bool_4)
		{
			using (SolidBrush brush9 = new SolidBrush(Form23.color_28))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush9, int_1 + int_9, 3, num, Height - 8);
				return;
			}
		}
		using SolidBrush brush10 = new SolidBrush(Form23.color_27);
		paintEventArgs_0.Graphics.FillRectangle(brush10, int_1 + int_9, 3, num, Height - 8);
	}

	private void Control23_MouseDown(object sender, MouseEventArgs e)
	{
		bool_4 = false;
		bool_5 = false;
		bool_6 = false;
		int num = method_12();
		int num2 = Width - 2 * int_1;
		Point pt = PointToClient(System.Windows.Forms.Cursor.Position);
		Rectangle rectangle = new Rectangle(new Point(int_1 + int_9, 0), new Size(num, Height));
		if (rectangle.Contains(pt))
		{
			int_7 = pt.X;
			int_8 = int_9;
			bool_0 = true;
			Invalidate();
			return;
		}
		if (new Rectangle(new Point(0, 0), new Size(int_1, int_1)).Contains(pt))
		{
			bool_2 = true;
			int num3 = method_8() - method_6() - method_2();
			int num4 = num2 - num;
			if (num3 > 0 && num4 > 0)
			{
				if (int_9 - method_4() < 0)
				{
					int_9 = 0;
				}
				else
				{
					int_9 -= method_4();
				}
				int_9 = Math.Max(int_9, 0);
				float num5 = (float)int_9 / (float)num4 * (float)(method_8() - method_2());
				int_6 = (int)num5;
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				Invalidate();
			}
			return;
		}
		Rectangle rectangle2 = new Rectangle(new Point(int_1 + num2, 0), new Size(int_1, int_1));
		if (rectangle2.Contains(pt))
		{
			bool_3 = true;
			int num6 = method_8() - method_6() - method_2();
			int num7 = num2 - num;
			if (num6 > 0 && num7 > 0)
			{
				if (int_9 + method_4() > num7)
				{
					int_9 = num7;
				}
				else
				{
					int_9 += method_4();
				}
				int_9 = Math.Max(int_9, 0);
				float num8 = (float)int_9 / (float)num7 * (float)(method_8() - method_2());
				int_6 = (int)num8;
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				Invalidate();
			}
		}
		else if (new Rectangle(new Point(int_1, 0), new Size(rectangle.Left - int_1, int_1)).Contains(pt))
		{
			int num9 = method_8() - method_6() - method_2();
			int num10 = num2 - num;
			if (num9 > 0 && num10 > 0)
			{
				if (int_9 - method_2() < 0)
				{
					int_9 = 0;
				}
				else
				{
					int_9 -= method_2();
				}
				int_9 = Math.Max(int_9, 0);
				float num11 = (float)int_9 / (float)num10 * (float)(method_8() - method_2());
				int_6 = (int)num11;
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				Invalidate();
			}
		}
		else
		{
			if (!new Rectangle(new Point(rectangle.Right, 0), new Size(rectangle2.Left - rectangle.Right, int_1)).Contains(pt))
			{
				return;
			}
			int num12 = method_8() - method_6() - method_2();
			int num13 = num2 - num;
			if (num12 > 0 && num13 > 0)
			{
				if (int_9 + method_2() > num13)
				{
					int_9 = num13;
				}
				else
				{
					int_9 += method_2();
				}
				int_9 = Math.Max(int_9, 0);
				float num14 = (float)int_9 / (float)num13 * (float)(method_8() - method_2());
				int_6 = (int)num14;
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				Invalidate();
			}
		}
	}

	private void Control23_MouseUp(object sender, MouseEventArgs e)
	{
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		Invalidate();
	}

	private void Control23_MouseLeave(object sender, EventArgs e)
	{
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		bool_4 = false;
		bool_5 = false;
		bool_6 = false;
		Invalidate();
	}

	private void Control23_MouseMove(object sender, MouseEventArgs e)
	{
		if (bool_0)
		{
			bool_1 = true;
		}
		if (bool_1)
		{
			int num = e.X - int_7;
			int num2 = method_12();
			int num3 = Width - 2 * int_1;
			int num4 = method_8() - method_6();
			int num5 = num3 - num2;
			if (bool_0 && num4 > 0 && num5 > 0)
			{
				int num6 = int_9;
				int num7 = int_8 + num;
				if (num7 < 0)
				{
					int_9 = 0;
				}
				else if (num7 > num5)
				{
					int_9 = num5;
				}
				else
				{
					int_9 = num7;
				}
				int_9 = Math.Max(int_9, 0);
				float num8 = (float)int_9 / (float)num5 * (float)(method_8() - method_2());
				int_6 = (int)num8;
				if (int_9 != num6 && eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				Invalidate();
			}
			return;
		}
		int width = method_12();
		int num9 = Width - 2 * int_1;
		Point pt = PointToClient(System.Windows.Forms.Cursor.Position);
		Rectangle rectangle = new Rectangle(new Point(int_1 + int_9, 0), new Size(width, Height));
		Rectangle rectangle2 = new Rectangle(new Point(0, 0), new Size(int_1, int_1));
		Rectangle rectangle3 = new Rectangle(new Point(int_1 + num9, 0), new Size(int_1, int_1));
		if (rectangle.Contains(pt))
		{
			bool_4 = true;
			bool_5 = false;
			bool_6 = false;
		}
		else if (rectangle2.Contains(pt))
		{
			bool_4 = false;
			bool_5 = true;
			bool_6 = false;
		}
		else if (rectangle3.Contains(pt))
		{
			bool_4 = false;
			bool_5 = false;
			bool_6 = true;
		}
		else
		{
			bool_4 = false;
			bool_5 = false;
			bool_6 = false;
		}
		Invalidate();
	}

	protected override void Dispose(bool disposing)
	{
		MouseDown -= Control23_MouseDown;
		MouseMove -= Control23_MouseMove;
		MouseUp -= Control23_MouseUp;
		MouseLeave -= Control23_MouseLeave;
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_13()
	{
		icontainer_0 = new Container();
	}
}
