using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns5;
using ns7;

namespace ns4;

internal class Form32 : Form
{
	private Framework framework_0;

	private IContainer icontainer_0;

	private Label label_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_1;

	private ThemedTextBox themedTextBox_0;

	private ThemedButton themedButton_2;

	private Label label_2;

	internal Form32()
	{
		method_0();
	}

	internal Form32(Framework framework_1, bool bool_0, bool bool_1)
	{
		method_0();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		label_2.ForeColor = Form23.color_9;
		label_2.Visible = bool_1;
		themedButton_2.Visible = bool_0;
		framework_0 = framework_1;
	}

	private void Form32_Shown(object sender, EventArgs e)
	{
		BringToFront();
		themedTextBox_0.Focus();
	}

	private void Form32_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(themedTextBox_0.Text))
			{
				Form54.smethod_6(this, Class333.smethod_2164(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Cancel = true;
			}
			else if (!framework_0.method_62(themedTextBox_0.Text))
			{
				Form54.smethod_6(this, Class333.smethod_2166(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				themedTextBox_0.SelectAll();
				e.Cancel = true;
			}
		}
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
		label_0 = new Label();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_1 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		themedButton_2 = new ThemedButton();
		label_2 = new Label();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(10, 9);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(431, 13);
		label_0.TabIndex = 0;
		label_0.Text = Class333.smethod_2186();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(81, 82);
		themedButton_0.Name = Class333.smethod_2187();
		themedButton_0.Size = new Size(130, 40);
		themedButton_0.TabIndex = 1;
		themedButton_0.Text = Class333.smethod_2188();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(364, 82);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(130, 40);
		themedButton_1.TabIndex = 3;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		label_1.AutoSize = true;
		label_1.Location = new Point(10, 35);
		label_1.Name = Class333.smethod_2173();
		label_1.Size = new Size(90, 13);
		label_1.TabIndex = 7;
		label_1.Text = Class333.smethod_2174();
		themedTextBox_0.Location = new Point(103, 32);
		themedTextBox_0.MaxLength = 100;
		themedTextBox_0.Name = Class333.smethod_2171();
		themedTextBox_0.PasswordChar = '*';
		themedTextBox_0.Size = new Size(452, 22);
		themedTextBox_0.TabIndex = 0;
		themedButton_2.DialogResult = DialogResult.Ignore;
		themedButton_2.Location = new Point(217, 82);
		themedButton_2.Name = Class333.smethod_2189();
		themedButton_2.Size = new Size(141, 40);
		themedButton_2.TabIndex = 2;
		themedButton_2.Text = Class333.smethod_2190();
		themedButton_2.UseVisualStyleBackColor = true;
		label_2.AutoSize = true;
		label_2.Location = new Point(10, 61);
		label_2.Name = Class333.smethod_2191();
		label_2.Size = new Size(555, 13);
		label_2.TabIndex = 8;
		label_2.Text = Class333.smethod_2192();
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(570, 131);
		Controls.Add(label_2);
		Controls.Add(themedButton_2);
		Controls.Add(label_1);
		Controls.Add(themedTextBox_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Controls.Add(label_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2193();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2194();
		FormClosing += Form32_FormClosing;
		Shown += Form32_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
