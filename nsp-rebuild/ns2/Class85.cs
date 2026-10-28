using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns4;
using ns7;

namespace ns2;

internal class Class85 : ListView
{
	private delegate void Delegate21();

	private Control26 control26_0 = new Control26();

	private Control23 control23_0 = new Control23();

	private Panel panel_0 = new Panel();

	private const int int_0 = -16;

	private const int int_1 = 1048576;

	private const int int_2 = 2097152;

	private const int int_3 = 0;

	private const int int_4 = 1;

	private const int int_5 = 4096;

	private const int int_6 = 4116;

	private int int_7;

	internal Class85()
	{
		DoubleBuffered = true;
		Scrollable = true;
		SelectedIndexChanged += Class85_SelectedIndexChanged;
		MouseWheel += Class85_MouseWheel;
		VisibleChanged += Class85_VisibleChanged;
		KeyDown += Class85_KeyDown;
		_ = control23_0.Handle;
		_ = control26_0.Handle;
		_ = panel_0.Handle;
		_ = Handle;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			SelectedIndexChanged -= Class85_SelectedIndexChanged;
			MouseWheel -= Class85_MouseWheel;
			VisibleChanged -= Class85_VisibleChanged;
			KeyDown -= Class85_KeyDown;
		}
		catch
		{
		}
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			try
			{
				control23_0.method_1(method_2);
				control26_0.method_1(method_3);
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

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int GetWindowLong(nint intptr_0, int int_8);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern int GetScrollPos(nint intptr_0, int int_8);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern nint SendMessage(nint intptr_0, int int_8, nint intptr_1, nint intptr_2);

	private int method_0()
	{
		int num = 0;
		foreach (ColumnHeader column in Columns)
		{
			num += column.Width;
		}
		return num;
	}

	internal void method_1()
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate21 method = method_1;
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
			bool flag;
			bool flag2;
			try
			{
				int windowLong = GetWindowLong(Handle, -16);
				flag = (windowLong & 0x100000) != 0;
				flag2 = (windowLong & 0x200000) != 0;
			}
			catch
			{
				return;
			}
			if (flag)
			{
				try
				{
					if (!control23_0.IsDisposed && !control23_0.Disposing)
					{
						int num3 = method_0();
						control23_0.Visible = Visible;
						control23_0.Left = num;
						control23_0.Top = num2 + (Height - control23_0.Height) - 1;
						control23_0.Width = (flag2 ? (Width - control26_0.Width) : Width);
						control23_0.method_1(method_2);
						control23_0.method_0(method_2);
						control23_0.method_7(0);
						control23_0.method_5(10);
						control23_0.method_3(50);
						control23_0.method_9(num3 - Width + control23_0.method_2());
						if (flag2)
						{
							Control23 control = control23_0;
							control.method_9(control.method_8() + control26_0.Width);
						}
						control23_0.method_11(GetScrollPos(Handle, 0));
						int_7 = control23_0.method_10();
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
						control26_0.Left = num + (Width - control26_0.Width) - 1;
						control26_0.Top = num2;
						control26_0.Height = (flag ? (Height - control23_0.Height) : Height);
						control26_0.method_1(method_3);
						control26_0.method_0(method_3);
						control26_0.method_7(0);
						control26_0.method_5(1);
						control26_0.method_3(10);
						if (Items.Count >= 2)
						{
							int num4 = Items[1].Bounds.Top - Items[0].Bounds.Top;
							if (num4 != 0)
							{
								int num5 = (Height - 20) / num4;
								control26_0.method_9(Items.Count - num5 + control26_0.method_2());
								if (flag)
								{
									Control26 control2 = control26_0;
									control2.method_9(control2.method_8() + control23_0.Height);
								}
								control26_0.method_11(GetScrollPos(Handle, 1));
							}
						}
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

	private void method_2(object sender, EventArgs e)
	{
		int num = control23_0.method_10() - int_7;
		SendMessage(Handle, 4116, num, IntPtr.Zero);
		int_7 = control23_0.method_10();
		control23_0.Invalidate();
	}

	private void method_3(object sender, EventArgs e)
	{
		TopItem = Items[Math.Min(Math.Max(control26_0.method_10(), 0), Items.Count - 1)];
		control26_0.Invalidate();
	}

	private void Class85_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void Class85_MouseWheel(object sender, MouseEventArgs e)
	{
		method_1();
	}

	private void Class85_VisibleChanged(object sender, EventArgs e)
	{
		if (!Visible)
		{
			control23_0.Visible = false;
			control26_0.Visible = false;
			panel_0.Visible = false;
		}
		else
		{
			method_1();
		}
	}

	private void Class85_KeyDown(object sender, KeyEventArgs e)
	{
		if (!e.Control || e.KeyCode != Keys.A)
		{
			return;
		}
		foreach (ListViewItem item in Items)
		{
			item.Selected = true;
		}
	}

	protected override void OnItemDrag(ItemDragEventArgs itemDragEventArgs_0)
	{
		base.OnItemDrag(itemDragEventArgs_0);
		DoDragDrop(SelectedItems, DragDropEffects.Move);
	}

	protected override void OnDragEnter(DragEventArgs dragEvent)
	{
		base.OnDragEnter(dragEvent);
		int num = dragEvent.Data.GetFormats().Length - 1;
		for (int i = 0; i <= num; i++)
		{
			if (dragEvent.Data.GetFormats()[i].Equals(Class333.smethod_478()))
			{
				dragEvent.Effect = DragDropEffects.Move;
			}
		}
	}

	protected override void OnDragDrop(DragEventArgs dragEvent)
	{
		if (SelectedItems.Count == 0)
		{
			return;
		}
		Point point = PointToClient(new Point(dragEvent.X, dragEvent.Y));
		ListViewItem itemAt = GetItemAt(point.X, point.Y);
		if (itemAt == null)
		{
			return;
		}
		int index = itemAt.Index;
		ListViewItem[] array = new ListViewItem[SelectedItems.Count];
		for (int i = 0; i < SelectedItems.Count; i++)
		{
			array[i] = SelectedItems[i];
		}
		for (int j = 0; j < array.GetLength(0); j++)
		{
			ListViewItem listViewItem = array[j];
			int num = index;
			if (num == listViewItem.Index)
			{
				return;
			}
			num = ((listViewItem.Index >= num) ? (index + j) : (num + 1));
			ListViewItem item = (ListViewItem)listViewItem.Clone();
			Items.Insert(num, item);
			Items.Remove(listViewItem);
		}
		base.OnDragDrop(dragEvent);
	}
}
