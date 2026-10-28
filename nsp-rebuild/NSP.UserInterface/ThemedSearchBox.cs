using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using ns0;
using ns4;
using ns7;

namespace NSP.UserInterface;

public class ThemedSearchBox : UserControl
{
	private PictureBox pictureBox_0 = new PictureBox();

	private ThemedTextBox themedTextBox_0 = new ThemedTextBox();

	private ThemedButton themedButton_0 = new ThemedButton();

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	public ThemedSearchBox()
	{
		method_0();
		BackColor = Form23.color_16;
		tableLayoutPanel_0.BackColor = Form23.color_16;
		tableLayoutPanel_0.Padding = new Padding(2);
		tableLayoutPanel_0.Margin = new Padding(2);
		pictureBox_0.BackColor = Form23.color_16;
		if (pictureBox_0.Image != null)
		{
			pictureBox_0.Image.Dispose();
		}
		pictureBox_0.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		themedTextBox_0.Font = new Font(Control.DefaultFont.FontFamily, themedTextBox_0.Font.Size);
		themedTextBox_0.Dock = DockStyle.Fill;
		themedTextBox_0.Height = tableLayoutPanel_0.Height - 2;
		themedTextBox_0.KeyUp += (object? sender, KeyEventArgs e) =>
		{
			Text = themedTextBox_0.Text;
		};
		themedButton_0.Text = Class333.smethod_330();
		themedButton_0.Font = new Font(Control.DefaultFont.FontFamily, 8f, FontStyle.Bold);
		themedButton_0.Click += (object? sender, EventArgs e) =>
		{
			themedTextBox_0.Text = string.Empty;
			Text = string.Empty;
		};
		tableLayoutPanel_0.Controls.Add(pictureBox_0, 0, 0);
		tableLayoutPanel_0.Controls.Add(themedTextBox_0, 1, 0);
		tableLayoutPanel_0.Controls.Add(themedButton_0, 2, 0);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		tableLayoutPanel_0 = new TableLayoutPanel();
		SuspendLayout();
		tableLayoutPanel_0.ColumnCount = 3;
		tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28f));
		tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28f));
		tableLayoutPanel_0.Dock = DockStyle.Fill;
		tableLayoutPanel_0.Location = new Point(0, 0);
		tableLayoutPanel_0.Name = Class333.smethod_672();
		tableLayoutPanel_0.RowCount = 1;
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 30f));
		tableLayoutPanel_0.Size = new Size(150, 30);
		tableLayoutPanel_0.TabIndex = 0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(tableLayoutPanel_0);
		Name = Class333.smethod_677();
		Size = new Size(150, 30);
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void themedTextBox_0_KeyUp(object? sender, KeyEventArgs e)
	{
		Text = themedTextBox_0.Text;
	}

	[CompilerGenerated]
	private void themedButton_0_Click(object? sender, EventArgs e)
	{
		themedTextBox_0.Text = string.Empty;
		Text = string.Empty;
	}
}
