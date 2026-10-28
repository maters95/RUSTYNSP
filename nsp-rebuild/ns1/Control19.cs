using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns4;
using ns6;
using ns7;

namespace ns1;

internal abstract class Control19 : Control11
{
	protected ThemedTextBox BNP = new ThemedTextBox();

	protected bool BNp;

	protected Class286 BNQ;

	protected bool BNq;

	protected int BNR;

	[SpecialName]
	internal ThemedTextBox method_2()
	{
		return BNP;
	}

	protected override ContextMenuStrip vmethod_9()
	{
		ContextMenuStrip contextMenuStrip = null;
		if (framework_0.method_4() && !vmethod_3())
		{
			contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.Opening += method_3;
			contextMenuStrip.BackColor = Form23.color_15;
			contextMenuStrip.ForeColor = Form23.color_12;
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem.Text = Class333.smethod_613();
			toolStripMenuItem.Click += method_1;
			contextMenuStrip.Items.Add(toolStripMenuItem);
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
			toolStripMenuItem2.Text = Class333.BcT();
			toolStripMenuItem2.Click += method_4;
			contextMenuStrip.Items.Add(toolStripMenuItem2);
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
			toolStripMenuItem3.Text = Class333.smethod_1270();
			toolStripMenuItem3.Click += method_5;
			contextMenuStrip.Items.Add(toolStripMenuItem3);
			ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
			toolStripMenuItem4.Text = Class333.smethod_1272();
			toolStripMenuItem4.Click += method_6;
			contextMenuStrip.Items.Add(toolStripMenuItem4);
			ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem();
			toolStripMenuItem5.Text = Class333.Bct();
			toolStripMenuItem5.Click += method_7;
			contextMenuStrip.Items.Add(toolStripMenuItem5);
		}
		return contextMenuStrip;
	}

	private void method_3(object sender, CancelEventArgs e)
	{
		foreach (ToolStripMenuItem item in (sender as ContextMenuStrip).Items)
		{
			string text = item.Text;
			if (!(text == Class333.BcT()))
			{
				if (!(text == Class333.smethod_1270()))
				{
					if (!(text == Class333.smethod_1272()))
					{
						if (text == Class333.Bct())
						{
							item.Enabled = BNP.Text.Length > 0;
						}
					}
					else
					{
						item.Enabled = Clipboard.ContainsText();
					}
				}
				else
				{
					item.Enabled = BNP.SelectionLength > 0;
				}
			}
			else
			{
				item.Enabled = BNP.SelectionLength > 0;
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		BNP.Cut();
	}

	private void method_5(object sender, EventArgs e)
	{
		BNP.Copy();
	}

	private void method_6(object sender, EventArgs e)
	{
		if (Clipboard.ContainsText())
		{
			BNP.Paste();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		BNP.SelectAll();
	}

	protected override void Dispose(bool disposing)
	{
		if (BNP.ContextMenuStrip != null)
		{
			foreach (ToolStripMenuItem item in BNP.ContextMenuStrip.Items)
			{
				item.Click -= method_1;
				item.Click -= method_4;
				item.Click -= method_5;
				item.Click -= method_6;
				item.Click -= method_7;
			}
			BNP.ContextMenuStrip.Dispose();
		}
		if (ContextMenuStrip != null)
		{
			foreach (ToolStripMenuItem item2 in ContextMenuStrip.Items)
			{
				item2.Click -= method_1;
				item2.Click -= method_4;
				item2.Click -= method_5;
				item2.Click -= method_6;
				item2.Click -= method_7;
			}
			ContextMenuStrip.Dispose();
			ContextMenuStrip = null;
		}
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
