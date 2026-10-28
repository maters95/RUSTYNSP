using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ns4;

namespace ns2;

internal class Class134 : RichTextBox
{
	[StructLayout(LayoutKind.Sequential)]
	internal class Class135
	{
		internal int BMj;

		internal int BMK;

		internal Class135()
		{
		}

		internal Class135(int int_0, int int_1)
		{
			BMj = int_0;
			BMK = int_1;
		}
	}

	private delegate void Delegate39();

	private Control26 control26_0 = new Control26();

	private Control23 control23_0 = new Control23();

	private Panel panel_0 = new Panel();

	private const int int_0 = -16;

	private const int int_1 = 1048576;

	private const int int_2 = 2097152;

	private const int int_3 = 0;

	private const int int_4 = 1;

	private const int int_5 = 1246;

	internal Class134()
	{
		MouseWheel += Class134_MouseWheel;
		VisibleChanged += Class134_VisibleChanged;
		SelectionChanged += Class134_SelectionChanged;
		_ = control23_0.Handle;
		_ = control26_0.Handle;
		_ = panel_0.Handle;
		_ = Handle;
		BorderStyle = BorderStyle.None;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int GetWindowLong(nint intptr_0, int int_6);

	[DllImport("user32", CharSet = CharSet.Auto)]
	private static extern bool GetScrollRange(nint intptr_0, int int_6, out int int_7, out int int_8);

	[DllImport("user32", CharSet = CharSet.Auto)]
	private static extern nint SendMessage(nint intptr_0, int int_6, int int_7, Class135 class135_0);

	internal void method_0()
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate39 method = method_0;
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
						GetScrollRange(Handle, 0, out var _, out var int_2);
						int num3 = int_2;
						control23_0.Visible = Visible;
						control23_0.Left = num;
						control23_0.Top = num2 + (Height - control23_0.Height) - 1;
						control23_0.Width = (flag2 ? (Width - control26_0.Width) : Width);
						control23_0.method_1(method_3);
						control23_0.method_0(method_3);
						control23_0.method_7(0);
						control23_0.method_5(Width / 40);
						control23_0.method_3((int)((float)Width / 3f));
						control23_0.method_9(num3 - Width + control23_0.method_2());
						if (flag2)
						{
							Control23 control = control23_0;
							control.method_9(control.method_8() + control26_0.Width);
						}
						control23_0.method_11((int)(method_2() * (float)control23_0.method_8()));
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
						GetScrollRange(Handle, 1, out var _, out var int_4);
						int num4 = int_4 + 20;
						control26_0.Visible = Visible;
						control26_0.Left = num + (Width - control26_0.Width) - 1;
						control26_0.Top = num2;
						control26_0.Height = (flag ? (Height - control23_0.Height) : Height);
						control26_0.method_1(method_4);
						control26_0.method_0(method_4);
						control26_0.method_7(0);
						control26_0.method_5(Height / 40);
						control26_0.method_3((int)((float)Height / 3f));
						control26_0.method_9(num4 - Height + control26_0.method_2());
						if (flag)
						{
							Control26 control2 = control26_0;
							control2.method_9(control2.method_8() + control23_0.Height);
						}
						control26_0.method_11((int)(method_1() * (float)control26_0.method_8()));
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

	protected override void Dispose(bool disposing)
	{
		try
		{
			MouseWheel -= Class134_MouseWheel;
			VisibleChanged -= Class134_VisibleChanged;
			SelectionChanged -= Class134_SelectionChanged;
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

	internal float method_1()
	{
		int charIndexFromPosition = GetCharIndexFromPosition(new Point(1, 1));
		int lineFromCharIndex = GetLineFromCharIndex(charIndexFromPosition);
		int charIndexFromPosition2 = GetCharIndexFromPosition(new Point(1, Height - 1));
		int lineFromCharIndex2 = GetLineFromCharIndex(charIndexFromPosition2);
		int lineFromCharIndex3 = GetLineFromCharIndex(Text.Length - 1);
		int num = lineFromCharIndex2 - lineFromCharIndex;
		if (lineFromCharIndex3 != 0)
		{
			return (float)lineFromCharIndex / (float)(lineFromCharIndex3 - num);
		}
		return 0f;
	}

	internal float method_2()
	{
		int selectionStart = SelectionStart;
		int lineFromCharIndex = GetLineFromCharIndex(selectionStart);
		int firstCharIndexFromLine = GetFirstCharIndexFromLine(lineFromCharIndex);
		return 100 * (1 - GetPositionFromCharIndex(firstCharIndexFromLine).X) / ClientSize.Width;
	}

	private void method_3(object sender, EventArgs e)
	{
		SendMessage(Handle, 1246, 0, new Class135(control23_0.method_10(), 0));
		control23_0.Invalidate();
	}

	private void method_4(object sender, EventArgs e)
	{
		SendMessage(Handle, 1246, 0, new Class135(0, control26_0.method_10()));
		control26_0.Invalidate();
	}

	private void Class134_MouseWheel(object sender, MouseEventArgs e)
	{
		method_0();
	}

	private void Class134_SelectionChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void Class134_VisibleChanged(object sender, EventArgs e)
	{
		if (!Visible)
		{
			control23_0.Visible = false;
			control26_0.Visible = false;
			panel_0.Visible = false;
		}
		else
		{
			method_0();
		}
	}

	internal void method_5(string string_0)
	{
		SelectionFont = Font;
		int num = 0;
		bool flag = false;
		bool flag2 = false;
		StringBuilder stringBuilder = new StringBuilder();
		do
		{
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			if (num <= string_0.Length - 4)
			{
				if (string_0[num] == '<' && string_0[num + 1] == '/' && string_0[num + 2] == 'b' && string_0[num + 3] == '>')
				{
					num += 4;
					flag4 = true;
					flag3 = true;
				}
				else if (string_0[num] == '<' && string_0[num + 1] == '/' && string_0[num + 2] == 'i' && string_0[num + 3] == '>')
				{
					num += 4;
					flag5 = true;
					flag3 = true;
				}
			}
			if (num <= string_0.Length - 3)
			{
				if (string_0[num] == '<' && string_0[num + 1] == 'b' && string_0[num + 2] == '>')
				{
					flag = true;
					num += 3;
					flag3 = true;
				}
				else if (string_0[num] == '<' && string_0[num + 1] == 'i' && string_0[num + 2] == '>')
				{
					flag2 = true;
					num += 3;
					flag3 = true;
				}
			}
			if (!flag3)
			{
				stringBuilder.Append(string_0.Substring(num, 1));
				num++;
			}
			if (!flag3 && num != string_0.Length)
			{
				continue;
			}
			string text = stringBuilder.ToString();
			int length = text.Length;
			if (length != 0)
			{
				int length2 = Text.Length;
				AppendText(text);
				stringBuilder.Clear();
				Select(length2, length);
				if (flag & flag4)
				{
					SelectionFont = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
					SelectionLength = 0;
					SelectionFont = Font;
					flag = false;
				}
				else if (flag2 & flag5)
				{
					SelectionFont = new Font(Font.FontFamily, Font.Size, FontStyle.Italic);
					SelectionLength = 0;
					SelectionFont = Font;
					flag2 = false;
				}
				else
				{
					SelectionFont = Font;
					SelectionLength = 0;
				}
			}
		}
		while (num < string_0.Length);
	}
}
