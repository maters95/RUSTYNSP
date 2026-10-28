using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form37 : Form
{
	private const int int_0 = 10;

	private const int int_1 = 10;

	private Form37 form37_0;

	private Class302 class302_0;

	private bool bool_0;

	private IContainer icontainer_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private ThemedButton themedButton_0;

	private LinkLabel linkLabel_0;

	private Class131 class131_0;

	private Label label_3;

	internal ProgressBar progressBar_0;

	internal Form37(Class302 class302_1, bool bool_1)
	{
		method_3();
		form37_0 = this;
		class302_0 = class302_1;
		bool_0 = bool_1;
		BackColor = Form23.color_10;
		class131_0.BackColor = Form23.color_17;
		label_1.ForeColor = Form23.color_12;
		label_0.Font = new Font(label_0.Font.FontFamily, label_0.Font.Size, FontStyle.Underline);
		label_0.ForeColor = Form23.color_12;
		label_2.ForeColor = Form23.color_12;
		linkLabel_0.ForeColor = Form23.color_12;
		label_3.ForeColor = Form23.color_12;
		progressBar_0.BackColor = Form23.color_11;
		progressBar_0.ForeColor = Form23.color_12;
		label_0.Text = class302_0.BcX;
		label_2.Text = class302_0.Bcx;
		method_0();
	}

	private void method_0()
	{
		label_1.Width = Width - 20;
		label_2.Width = Width - 20;
		linkLabel_0.Width = Width - 20;
		label_3.Width = Width - 20;
		label_1.Left = class131_0.Width / 2 - label_1.Width / 2;
		label_1.Top = 10;
		progressBar_0.Left = class131_0.Width / 2 - progressBar_0.Width / 2;
		progressBar_0.Top = class131_0.Height / 2 - progressBar_0.Height * 2 - 10;
		label_0.Left = class131_0.Width / 2 - label_0.Width / 2;
		label_0.Top = label_1.Bottom;
		label_2.Left = class131_0.Width / 2 - label_2.Width / 2;
		label_2.Top = progressBar_0.Bottom + 10;
		linkLabel_0.Left = class131_0.Width / 2 - linkLabel_0.Width / 2;
		linkLabel_0.Top = class131_0.Height - linkLabel_0.Height - 10;
		themedButton_0.Top = linkLabel_0.Top - 10 - themedButton_0.Height;
		themedButton_0.Left = class131_0.Width / 2 - themedButton_0.Width / 2;
		label_3.Top = themedButton_0.Top - 10 - label_3.Height;
		label_3.Left = class131_0.Width / 2 - label_3.Width / 2;
	}

	internal void method_1()
	{
		label_0.Text = class302_0.BcX;
		label_2.Text = class302_0.Bcx;
		linkLabel_0.Text = (class302_0.BcY ? Class333.smethod_2293() : Class333.smethod_2292());
		Refresh();
	}

	internal void method_2(bool bool_1)
	{
		if (bool_1)
		{
			label_1.Visible = false;
			label_0.Visible = false;
			linkLabel_0.Visible = false;
			themedButton_0.Visible = false;
			label_3.Visible = false;
			progressBar_0.Visible = true;
			label_2.Visible = true;
		}
		else
		{
			label_1.Visible = true;
			label_0.Visible = true;
			linkLabel_0.Visible = true;
			themedButton_0.Visible = true;
			label_3.Visible = true;
			progressBar_0.Visible = false;
			label_2.Visible = false;
		}
	}

	private void Form37_Shown(object sender, EventArgs e)
	{
		if (bool_0)
		{
			method_2(bool_1: false);
			return;
		}
		method_2(bool_1: true);
		if (!class302_0.method_0(form37_0))
		{
			Form54.smethod_6(Form23.form23_0, Class333.smethod_2294(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Close();
		}
	}

	private void Form37_Resize(object sender, EventArgs e)
	{
		method_0();
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(linkLabel_0.Text);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_3()
	{
		class131_0 = new Class131();
		label_3 = new Label();
		progressBar_0 = new ProgressBar();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		themedButton_0 = new ThemedButton();
		linkLabel_0 = new LinkLabel();
		class131_0.SuspendLayout();
		SuspendLayout();
		class131_0.AutoScroll = true;
		class131_0.Controls.Add(label_3);
		class131_0.Controls.Add(progressBar_0);
		class131_0.Controls.Add(label_0);
		class131_0.Controls.Add(label_1);
		class131_0.Controls.Add(label_2);
		class131_0.Controls.Add(themedButton_0);
		class131_0.Controls.Add(linkLabel_0);
		class131_0.Dock = DockStyle.Fill;
		class131_0.Location = new Point(0, 0);
		class131_0.Name = Class333.smethod_2295();
		class131_0.Size = new Size(384, 261);
		class131_0.TabIndex = 8;
		label_3.Location = new Point(15, 149);
		label_3.Name = Class333.smethod_2296();
		label_3.Size = new Size(269, 20);
		label_3.TabIndex = 8;
		label_3.Text = Class333.smethod_2297();
		label_3.TextAlign = ContentAlignment.MiddleCenter;
		progressBar_0.Location = new Point(36, 29);
		progressBar_0.Name = Class333.smethod_2298();
		progressBar_0.Size = new Size(217, 23);
		progressBar_0.TabIndex = 0;
		label_0.Font = new Font(Class333.smethod_2299(), 72f, FontStyle.Underline, GraphicsUnit.Point, 0);
		label_0.Location = new Point(3, 92);
		label_0.Name = Class333.smethod_2300();
		label_0.Size = new Size(223, 120);
		label_0.TabIndex = 1;
		label_0.Text = Class333.smethod_2301();
		label_0.TextAlign = ContentAlignment.MiddleCenter;
		label_1.Location = new Point(207, 92);
		label_1.Name = Class333.smethod_2302();
		label_1.Size = new Size(165, 20);
		label_1.TabIndex = 2;
		label_1.Text = Class333.smethod_2303();
		label_1.TextAlign = ContentAlignment.MiddleCenter;
		label_2.Location = new Point(33, 29);
		label_2.Name = Class333.smethod_2304();
		label_2.Size = new Size(203, 20);
		label_2.TabIndex = 3;
		label_2.Text = Class333.smethod_2305();
		label_2.TextAlign = ContentAlignment.MiddleCenter;
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(0, 0);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(75, 23);
		themedButton_0.TabIndex = 6;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		linkLabel_0.Location = new Point(88, 69);
		linkLabel_0.Name = Class333.smethod_2306();
		linkLabel_0.Size = new Size(184, 20);
		linkLabel_0.TabIndex = 7;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class333.smethod_2307();
		linkLabel_0.TextAlign = ContentAlignment.MiddleCenter;
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(384, 261);
		Controls.Add(class131_0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2308();
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2309();
		Shown += Form37_Shown;
		Resize += Form37_Resize;
		class131_0.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
