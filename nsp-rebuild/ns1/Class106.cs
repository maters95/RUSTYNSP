using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns1;

internal class Class106 : MovableResizablePanel
{
	private GenericCANConfigControl Bkw;

	private Rectangle BkX;

	private Framework Bkx;

	private MenuNode BkY;

	private string Bky;

	internal Class106(MenuNode menuNode_0, Framework framework_0, Rectangle rectangle_0, bool bool_0, bool bool_1)
		: base(rectangle_0, bool_0, bool_1, bool_2: false)
	{
		Bkx = framework_0;
		BkY = menuNode_0;
		Bky = string.Empty;
		BkX = rectangle_0;
		ContextMenuStrip = method_19();
	}

	protected override void Dispose(bool disposing)
	{
		if (Bkw != null)
		{
			Bkw.Close();
		}
		if (ContextMenuStrip != null)
		{
			ContextMenuStrip.Opening -= method_18;
			foreach (ToolStripItem item in ContextMenuStrip.Items)
			{
				item.Click -= method_17;
			}
		}
		base.Dispose(disposing);
	}

	internal Class255 method_12()
	{
		string bky = Bky;
		if (!(bky == Class333.aMG()))
		{
			if (!(bky == Class333.aMf()))
			{
				if (!(bky == Class333.aMg()))
				{
					return null;
				}
				return Bkx.awt;
			}
			return Bkx.aws;
		}
		return Bkx.awT;
	}

	internal void method_13()
	{
		SuspendLayout();
		if (Bky == string.Empty)
		{
			Bky = BkY?.method_5()?.method_10();
		}
		TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars = new TableLayoutPanelWithThemedScrollBars();
		tableLayoutPanelWithThemedScrollBars.Left = 5;
		tableLayoutPanelWithThemedScrollBars.Top = 5;
		tableLayoutPanelWithThemedScrollBars.Name = Class333.BBu();
		tableLayoutPanelWithThemedScrollBars.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
		tableLayoutPanelWithThemedScrollBars.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
		tableLayoutPanelWithThemedScrollBars.BackColor = BackColor;
		tableLayoutPanelWithThemedScrollBars.ColumnCount = 1;
		tableLayoutPanelWithThemedScrollBars.RowCount = 2;
		tableLayoutPanelWithThemedScrollBars.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
		tableLayoutPanelWithThemedScrollBars.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars.MouseDown += method_14;
		tableLayoutPanelWithThemedScrollBars.MouseMove += method_15;
		tableLayoutPanelWithThemedScrollBars.MouseUp += method_16;
		Label label = new Label();
		label.Text = Bky + Class333.BBV();
		label.ForeColor = Form23.color_14;
		label.Font = new Font(label.Font.FontFamily, 10f, FontStyle.Bold);
		label.BackColor = Color.Transparent;
		label.AutoSize = true;
		label.Left = 5;
		label.Top = 2;
		tableLayoutPanelWithThemedScrollBars.Controls.Add(label);
		Class255 @class = method_12();
		Setting setting = @class?.BZK;
		if (Bkx.method_2() && Bkx.method_3() && setting != null && setting.method_96())
		{
			Label label2 = new Label();
			label2.Text = Class333.smethod_180() + Bky + Class333.BBv();
			label2.ForeColor = Form23.color_12;
			label2.BackColor = Color.Transparent;
			label2.AutoSize = true;
			label2.Left = 10;
			label2.Top = 10;
			tableLayoutPanelWithThemedScrollBars.Controls.Add(label2);
		}
		else if (setting != null)
		{
			Bkw = new GenericCANConfigControl(Bkx, @class, Bky);
			Bkw.Dock = DockStyle.Fill;
			tableLayoutPanelWithThemedScrollBars.Controls.Add(Bkw);
		}
		Controls.Add(tableLayoutPanelWithThemedScrollBars);
		if (BkX != Rectangle.Empty)
		{
			Width = BkX.Width;
			Height = BkX.Height;
			Left = BkX.Left;
			Top = BkX.Top;
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control control in tableLayoutPanelWithThemedScrollBars.Controls)
			{
				num = Math.Max(num, control.Right + 10);
				num2 = Math.Max(num2, control.Bottom + 10);
			}
			if (Width != num || Height != num2)
			{
				Width = num;
				Height = num2;
			}
		}
		ResumeLayout(performLayout: true);
		if (Bkw != null)
		{
			tableLayoutPanelWithThemedScrollBars.AutoScrollMinSize = new Size(0, Bkw.Top + Bkw.MinimumSize.Height);
		}
		tableLayoutPanelWithThemedScrollBars.Size = new Size(Width - 10, Height - 10);
	}

	protected override void OnResize(EventArgs eventargs)
	{
		base.OnResize(eventargs);
		if (Controls.ContainsKey(Class333.BBu()))
		{
			(Controls[Class333.BBu()] as TableLayoutPanelWithThemedScrollBars).Size = new Size(Width - 10, Height - 10);
		}
	}

	private void method_14(object sender, MouseEventArgs e)
	{
		BringToFront();
		if (e.Button == MouseButtons.Left)
		{
			TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars = sender as TableLayoutPanelWithThemedScrollBars;
			method_3(e.Button, tableLayoutPanelWithThemedScrollBars.Left + e.X, tableLayoutPanelWithThemedScrollBars.Top + e.Y);
		}
	}

	private void method_15(object sender, MouseEventArgs e)
	{
		TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars = sender as TableLayoutPanelWithThemedScrollBars;
		method_4(tableLayoutPanelWithThemedScrollBars.Left + e.X, tableLayoutPanelWithThemedScrollBars.Top + e.Y);
	}

	private void method_16(object sender, MouseEventArgs e)
	{
		TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars = sender as TableLayoutPanelWithThemedScrollBars;
		method_5(tableLayoutPanelWithThemedScrollBars.Left + e.X, tableLayoutPanelWithThemedScrollBars.Top + e.Y);
	}

	private void method_17(object sender, EventArgs e)
	{
		Enum65 @enum = (Form23.form23_0.control25_0.SelectedTab as Class130).method_0();
		int selectedIndex = Form23.form23_0.control25_0.SelectedIndex;
		if (@enum != Enum65.const_1 && Form23.form23_0.control25_0.method_5(selectedIndex) == this)
		{
			Form54.smethod_6(Form23.form23_0, Class333.BBW(), Class333.BBw(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Class30.smethod_0(this);
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_18(object sender, CancelEventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.BBX())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
				break;
			}
		}
	}

	private ContextMenuStrip method_19()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opening += method_18;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.BBX();
		toolStripMenuItem.Click += method_17;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		return contextMenuStrip;
	}

	internal void method_20(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BBx());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.BBY() + Bky);
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_21(StreamReader streamReader_0)
	{
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.BBY()))
			{
				Bky = text.Substring(Class333.BBY().Length);
			}
			else if (string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}

	internal bool method_22(KeyEventArgs keyEventArgs_0)
	{
		if (Bkw != null)
		{
			return Bkw.method_25(keyEventArgs_0);
		}
		return false;
	}
}
