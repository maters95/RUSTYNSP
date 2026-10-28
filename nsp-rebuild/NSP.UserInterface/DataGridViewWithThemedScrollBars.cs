using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns2;
using ns4;

namespace NSP.UserInterface;

public class DataGridViewWithThemedScrollBars : DataGridView
{
	private delegate void Delegate14();

	private Control23 control23_0 = new Control23();

	private Control26 control26_0 = new Control26();

	private Panel panel_0 = new Panel();

	private bool bool_0;

	private bool bool_1;

	public DataGridViewWithThemedScrollBars()
	{
		ShowCellToolTips = false;
		DoubleBuffered = true;
		_ = control23_0.Handle;
		_ = control26_0.Handle;
		_ = panel_0.Handle;
		_ = Handle;
	}

	private int method_0()
	{
		int num = 0;
		for (int i = 0; i < ColumnCount; i++)
		{
			if (Columns[i].Visible)
			{
				num += Columns[i].Width;
			}
		}
		return (RowHeadersVisible ? RowHeadersWidth : 0) + num;
	}

	private int method_1()
	{
		int num = 0;
		for (int i = 0; i < RowCount; i++)
		{
			if (Rows[i].Visible)
			{
				num += Rows[i].Height;
			}
		}
		return (ColumnHeadersVisible ? ColumnHeadersHeight : 0) + num;
	}

	private HScrollBar method_2()
	{
		foreach (Control control in Controls)
		{
			if (control is HScrollBar)
			{
				return control as HScrollBar;
			}
		}
		return null;
	}

	private VScrollBar method_3()
	{
		foreach (Control control in Controls)
		{
			if (control is VScrollBar)
			{
				return control as VScrollBar;
			}
		}
		return null;
	}

	internal void method_4()
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate14 method = method_4;
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
		int num3 = 0;
		int num4 = 0;
		try
		{
			num3 = method_0();
			num4 = method_1();
		}
		catch
		{
		}
		HScrollBar hScrollBar = method_2();
		VScrollBar vScrollBar = method_3();
		bool flag = ((hScrollBar != null && hScrollBar.Visible) || num3 > Width) && (ScrollBars == ScrollBars.Both || ScrollBars == ScrollBars.Horizontal);
		bool flag2 = ((vScrollBar != null && vScrollBar.Visible) || num4 > Height) && (ScrollBars == ScrollBars.Both || ScrollBars == ScrollBars.Vertical);
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			if (flag)
			{
				try
				{
					if (!control23_0.IsDisposed && !control23_0.Disposing)
					{
						control23_0.Visible = Visible;
						control23_0.Left = num;
						control23_0.Top = num2 + (Height - control23_0.Height);
						control23_0.Width = (flag2 ? (Width - control26_0.Width) : Width);
						control23_0.method_1(method_5);
						control23_0.method_0(method_5);
						control23_0.method_7(0);
						control23_0.method_5(Width / 40);
						control23_0.method_3((int)((float)Width / 3f));
						control23_0.method_9(num3 - Width + control23_0.method_2());
						if (flag2)
						{
							Control23 control = control23_0;
							control.method_9(control.method_8() + control26_0.Width);
						}
						control23_0.method_11(hScrollBar.Value);
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
			if (flag2)
			{
				try
				{
					if (!control26_0.IsDisposed && !control26_0.Disposing)
					{
						control26_0.Visible = Visible;
						control26_0.Left = num + (Width - control26_0.Width);
						control26_0.Top = num2;
						control26_0.Height = (flag ? (Height - control23_0.Height) : Height);
						control26_0.method_1(method_6);
						control26_0.method_0(method_6);
						control26_0.method_7(0);
						control26_0.method_5(Height / 40);
						control26_0.method_3((int)((float)Height / 3f));
						control26_0.method_9(num4 - Height + control26_0.method_2());
						if (flag)
						{
							Control26 control2 = control26_0;
							control2.method_9(control2.method_8() + control23_0.Height);
						}
						control26_0.method_11(vScrollBar.Value);
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
			if (flag & flag2)
			{
				try
				{
					if (!panel_0.IsDisposed && !panel_0.Disposing)
					{
						panel_0.Visible = Visible;
						panel_0.BorderStyle = BorderStyle.None;
						panel_0.BackColor = Form23.color_26;
						panel_0.Size = new Size(control26_0.Width, control23_0.Height);
						panel_0.Left = control23_0.Right;
						panel_0.Top = control26_0.Bottom;
						if (parent != null && !parent.Controls.Contains(panel_0))
						{
							parent.Controls.Add(panel_0);
						}
						panel_0.BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!panel_0.IsDisposed && !panel_0.Disposing)
			{
				try
				{
					panel_0.Visible = false;
				}
				catch
				{
				}
			}
			SelectionChanged -= DataGridViewWithThemedScrollBars_SelectionChanged;
			SelectionChanged += DataGridViewWithThemedScrollBars_SelectionChanged;
			MouseWheel -= DataGridViewWithThemedScrollBars_MouseWheel;
			MouseWheel += DataGridViewWithThemedScrollBars_MouseWheel;
			VisibleChanged -= DataGridViewWithThemedScrollBars_VisibleChanged;
			VisibleChanged += DataGridViewWithThemedScrollBars_VisibleChanged;
			Layout -= DataGridViewWithThemedScrollBars_Resize;
			Layout += DataGridViewWithThemedScrollBars_Resize;
			Resize -= DataGridViewWithThemedScrollBars_Resize;
			Resize += DataGridViewWithThemedScrollBars_Resize;
		}
		else
		{
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
			if (!panel_0.IsDisposed && !panel_0.Disposing)
			{
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
		}
		bool_0 = flag;
		bool_1 = flag2;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			control23_0.method_1(method_5);
			control26_0.method_1(method_6);
			SelectionChanged -= DataGridViewWithThemedScrollBars_SelectionChanged;
			MouseWheel -= DataGridViewWithThemedScrollBars_MouseWheel;
			VisibleChanged -= DataGridViewWithThemedScrollBars_VisibleChanged;
			Layout -= DataGridViewWithThemedScrollBars_Resize;
			Resize -= DataGridViewWithThemedScrollBars_Resize;
		}
		catch
		{
		}
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
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

	private void method_5(object sender, EventArgs e)
	{
		HScrollBar hScrollBar = method_2();
		if (hScrollBar != null)
		{
			hScrollBar.Value = Math.Max(Math.Min(control23_0.method_10(), hScrollBar.Maximum), hScrollBar.Minimum);
			int num = 0;
			for (int i = 0; i < ColumnCount; i++)
			{
				if (hScrollBar.Value > num)
				{
					if (Columns[i].Visible)
					{
						num += Columns[i].Width;
					}
					continue;
				}
				if (Columns[i].Visible)
				{
					FirstDisplayedScrollingColumnIndex = i;
				}
				if (i == 0)
				{
					HorizontalScrollingOffset = 0;
				}
				break;
			}
			control23_0.Invalidate();
		}
		Invalidate();
	}

	private void method_6(object sender, EventArgs e)
	{
		VScrollBar vScrollBar = method_3();
		if (vScrollBar != null)
		{
			vScrollBar.Value = Math.Max(Math.Min(control26_0.method_10(), vScrollBar.Maximum), vScrollBar.Minimum);
			int num = 0;
			for (int i = 0; i < RowCount; i++)
			{
				if (vScrollBar.Value > num)
				{
					if (Rows[i].Visible)
					{
						num += Rows[i].Height;
					}
					continue;
				}
				if (Rows[i].Visible)
				{
					FirstDisplayedScrollingRowIndex = i;
				}
				break;
			}
			control26_0.Invalidate();
		}
		Invalidate();
	}

	private void DataGridViewWithThemedScrollBars_SelectionChanged(object sender, EventArgs e)
	{
		HScrollBar hScrollBar = method_2();
		VScrollBar vScrollBar = method_3();
		if (hScrollBar != null)
		{
			control23_0.method_11(hScrollBar.Value);
		}
		if (vScrollBar != null)
		{
			control26_0.method_11(vScrollBar.Value);
		}
	}

	private void DataGridViewWithThemedScrollBars_MouseWheel(object sender, MouseEventArgs e)
	{
		method_4();
		Invalidate();
	}

	private void DataGridViewWithThemedScrollBars_VisibleChanged(object sender, EventArgs e)
	{
		if (!Visible)
		{
			control23_0.Visible = false;
			control26_0.Visible = false;
			panel_0.Visible = false;
		}
		else
		{
			method_4();
		}
	}

	private void DataGridViewWithThemedScrollBars_Resize(object sender, EventArgs e)
	{
		method_4();
	}

	[SpecialName]
	internal bool method_7()
	{
		return bool_0;
	}

	[SpecialName]
	internal bool method_8()
	{
		return bool_1;
	}
}
