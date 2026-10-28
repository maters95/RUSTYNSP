using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns4;

namespace ns2;

internal class Class131 : Panel
{
	private delegate void Delegate28();

	[CompilerGenerated]
	private bool bool_0 = true;

	private Control23 control23_0 = new Control23();

	private Control26 control26_0 = new Control26();

	private Panel panel_0 = new Panel();

	[SpecialName]
	[CompilerGenerated]
	internal bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	internal Class131()
	{
		AutoScroll = true;
		MouseWheel += Class131_MouseWheel;
		VisibleChanged += Class131_VisibleChanged;
		Layout += Class131_Layout;
		_ = control23_0.Handle;
		_ = control26_0.Handle;
		_ = panel_0.Handle;
		_ = Handle;
	}

	[DllImport("user32.dll")]
	public static extern short GetKeyState(Keys keys_0);

	protected override Point ScrollToControl(Control activeControl)
	{
		if (!method_0() && (GetKeyState(Keys.Tab) & 0x8000) == 0)
		{
			return AutoScrollPosition;
		}
		return base.ScrollToControl(activeControl);
	}

	internal void method_2()
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate28 method = method_2;
				Invoke(method);
				return;
			}
			catch
			{
				return;
			}
		}
		Control parent = Parent;
		int num = Left;
		int num2 = Top;
		while (parent != null && (parent is FlowLayoutPanel || parent is TableLayoutPanel))
		{
			num += parent.Left;
			num2 += parent.Top;
			parent = parent.Parent;
		}
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			bool visible = HorizontalScroll.Visible;
			bool visible2 = VerticalScroll.Visible;
			if (visible)
			{
				int num3 = 0;
				try
				{
					foreach (Control control5 in Controls)
					{
						num3 = Math.Max(num3, control5.Right - AutoScrollPosition.X);
					}
				}
				catch
				{
				}
				try
				{
					if (!control23_0.IsDisposed && !control23_0.Disposing)
					{
						control23_0.Visible = Visible;
						control23_0.Left = num;
						control23_0.Top = num2 + (Height - control23_0.Height) - 1;
						control23_0.Width = (visible2 ? (Width - control26_0.Width) : Width);
						control23_0.method_1(method_3);
						control23_0.method_0(method_3);
						control23_0.method_7(0);
						control23_0.method_5(Width / 40);
						control23_0.method_3((int)((float)Width / 3f));
						control23_0.method_9(num3 - Width + control23_0.method_2());
						if (visible2)
						{
							Control23 control2 = control23_0;
							control2.method_9(control2.method_8() + control26_0.Width);
						}
						control23_0.method_11(-AutoScrollPosition.X);
						if (parent != null && !parent.Controls.Contains(control23_0))
						{
							parent.Controls.Add(control23_0);
						}
						control23_0.BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!control23_0.IsDisposed && !control23_0.Disposing)
			{
				try
				{
					control23_0.Visible = false;
				}
				catch
				{
				}
			}
			if (visible2)
			{
				int num4 = 0;
				try
				{
					foreach (Control control6 in Controls)
					{
						num4 = Math.Max(num4, control6.Bottom - AutoScrollPosition.Y);
					}
				}
				catch
				{
				}
				try
				{
					if (!control26_0.IsDisposed && !control26_0.Disposing)
					{
						control26_0.Visible = Visible;
						control26_0.Left = num + (Width - control26_0.Width) - 1;
						control26_0.Top = num2;
						control26_0.Height = (visible ? (Height - control23_0.Height) : Height);
						control26_0.method_1(method_4);
						control26_0.method_0(method_4);
						control26_0.method_7(0);
						control26_0.method_5(Height / 40);
						control26_0.method_3((int)((float)Height / 3f));
						control26_0.method_9(num4 - Height + control26_0.method_2());
						if (visible)
						{
							Control26 control4 = control26_0;
							control4.method_9(control4.method_8() + control23_0.Height);
						}
						control26_0.method_11(-AutoScrollPosition.Y);
						if (parent != null && !parent.Controls.Contains(control26_0))
						{
							parent.Controls.Add(control26_0);
						}
						control26_0.BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!control26_0.IsDisposed && !control26_0.Disposing)
			{
				try
				{
					control26_0.Visible = false;
				}
				catch
				{
				}
			}
			if (visible & visible2)
			{
				try
				{
					if (!panel_0.IsDisposed && !panel_0.Disposing)
					{
						panel_0.Visible = Visible;
						panel_0.BorderStyle = BorderStyle.None;
						panel_0.BackColor = Form23.color_26;
						panel_0.Size = new Size(control26_0.Width - 1, control23_0.Height - 1);
						panel_0.Left = control23_0.Right;
						panel_0.Top = control26_0.Bottom;
						if (parent != null && !parent.Controls.Contains(panel_0))
						{
							parent.Controls.Add(panel_0);
						}
						panel_0.BringToFront();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			if (!panel_0.IsDisposed && !panel_0.Disposing)
			{
				try
				{
					panel_0.Visible = false;
					return;
				}
				catch
				{
					return;
				}
			}
			return;
		}
		if (!control23_0.IsDisposed && !control23_0.Disposing)
		{
			try
			{
				control23_0.Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains(control23_0))
				{
					parent.Controls.Remove(control23_0);
				}
			}
			catch
			{
			}
		}
		if (!control26_0.IsDisposed && !control26_0.Disposing)
		{
			try
			{
				control26_0.Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains(control26_0))
				{
					parent.Controls.Remove(control26_0);
				}
			}
			catch
			{
			}
		}
		if (panel_0.IsDisposed || panel_0.Disposing)
		{
			return;
		}
		try
		{
			panel_0.Visible = false;
		}
		catch
		{
		}
		try
		{
			if (parent != null && parent.Controls.Contains(panel_0))
			{
				parent.Controls.Remove(panel_0);
			}
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			MouseWheel -= Class131_MouseWheel;
			VisibleChanged -= Class131_VisibleChanged;
			Layout -= Class131_Layout;
		}
		catch
		{
		}
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			try
			{
				control23_0.method_1(method_3);
				control26_0.method_1(method_4);
			}
			catch
			{
			}
			try
			{
				control26_0.Dispose();
			}
			catch
			{
			}
			try
			{
				control23_0.Dispose();
			}
			catch
			{
			}
		}
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		AutoScrollPosition = new Point(control23_0.method_10(), control26_0.Visible ? control26_0.method_10() : 0);
		control23_0.Invalidate();
	}

	private void method_4(object sender, EventArgs e)
	{
		AutoScrollPosition = new Point(control23_0.Visible ? control23_0.method_10() : 0, control26_0.method_10());
		control26_0.Invalidate();
	}

	private void Class131_MouseWheel(object sender, MouseEventArgs e)
	{
		method_2();
	}

	private void Class131_VisibleChanged(object sender, EventArgs e)
	{
		if (!Visible)
		{
			control23_0.Visible = false;
			control26_0.Visible = false;
			panel_0.Visible = false;
		}
		else
		{
			method_2();
		}
	}

	private void Class131_Layout(object sender, LayoutEventArgs e)
	{
		method_2();
	}
}
