using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns3;
using ns4;

namespace ns0;

internal static class Class30
{
	internal static void smethod_0(Control control_0)
	{
		if (control_0.IsDisposed || control_0 is VirtualDashAppPanel)
		{
			return;
		}
		if (control_0.Controls != null)
		{
			int count = control_0.Controls.Count;
			for (int i = 0; i < count; i++)
			{
				if (control_0.Controls.Count != 0)
				{
					smethod_0(control_0.Controls[0]);
				}
			}
		}
		try
		{
			control_0.Dispose();
		}
		catch
		{
		}
	}

	internal static void smethod_1(Control control_0)
	{
		if (control_0.IsDisposed)
		{
			return;
		}
		if (control_0.Controls != null)
		{
			int count = control_0.Controls.Count;
			for (int i = 0; i < count; i++)
			{
				smethod_1(control_0.Controls[i]);
			}
		}
		control_0.SuspendLayout();
	}

	internal static void smethod_2(Control control_0, bool bool_0)
	{
		if (control_0.IsDisposed)
		{
			return;
		}
		control_0.ResumeLayout(bool_0);
		if (control_0.Controls != null)
		{
			int count = control_0.Controls.Count;
			for (int i = 0; i < count; i++)
			{
				smethod_2(control_0.Controls[i], bool_0);
			}
		}
	}

	internal static Control smethod_3(Control control_0)
	{
		Control control = control_0;
		ContainerControl containerControl = control as ContainerControl;
		while (true)
		{
			if (containerControl != null)
			{
				control = containerControl.ActiveControl;
				if (control.Focused)
				{
					break;
				}
				containerControl = control as ContainerControl;
				continue;
			}
			return null;
		}
		return control;
	}

	internal static bool smethod_4(Form form_0, Keys keys_0)
	{
		switch (keys_0)
		{
		case Keys.Z | Keys.Control:
			Form23.form23_0.toolStripButton_2_Click(null, null);
			return true;
		case Keys.Y | Keys.Control:
			Form23.form23_0.toolStripButton_3_Click(null, null);
			return true;
		default:
			if ((keys_0 & Keys.Prior) == Keys.Prior || (keys_0 & Keys.Next) == Keys.Next)
			{
				Control control = smethod_3(form_0);
				if (control is ThemedTextBox)
				{
					if (control.Parent is Control21)
					{
						return (control.Parent as Control21).method_28(new KeyEventArgs(keys_0));
					}
					if (control.Parent is Control20)
					{
						return (control.Parent as Control20).method_21(new KeyEventArgs(keys_0));
					}
					if (control.Parent is Control7)
					{
						return (control.Parent as Control7).method_15(new KeyEventArgs(keys_0));
					}
				}
			}
			return false;
		}
	}

	[DllImport("user32.dll")]
	public static extern short GetKeyState(Keys keys_0);

	internal static List<Keys> smethod_5()
	{
		Array values = Enum.GetValues(typeof(Keys));
		List<Keys> list = new List<Keys>();
		foreach (Keys item in values)
		{
			if (item != Keys.None && (GetKeyState(item) & 0x8000) != 0)
			{
				list.Add(item);
			}
		}
		return list;
	}
}
