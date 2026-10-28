using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns4;
using ns7;

namespace ns1;

internal class Class96 : MovableResizablePanel
{
	private Class79 BJg;

	internal Class96(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BJg = new Class79(framework_0.awO, framework_0);
		Controls.Add(BJg);
		UpdateLayout(resizingOnly: false);
		ContextMenuStrip = method_14();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
			{
				item.Click -= method_12;
			}
			ContextMenuStrip.Opened -= method_13;
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		return text + Class333.BAZ() + Left + Class333.BAz() + Top;
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		BJg.Left = 10;
		BJg.Top = 10;
		BJg.Width = Width - 20;
		BJg.Height = Height - 20;
		BJg.Invalidate();
	}

	private void method_12(object sender, EventArgs e)
	{
		Class30.smethod_0(this);
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_13(object sender, EventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.BaT())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
				break;
			}
		}
	}

	private ContextMenuStrip method_14()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opened += method_13;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.BaT();
		toolStripMenuItem.Click += method_12;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		return contextMenuStrip;
	}

	internal void method_15(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.Bat());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_16(StreamReader streamReader_0)
	{
		string value;
		while ((value = streamReader_0.ReadLine()) != null && !string.IsNullOrWhiteSpace(value))
		{
		}
	}
}
