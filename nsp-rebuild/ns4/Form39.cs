using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.UserInterface;
using ns5;
using ns7;

namespace ns4;

internal class Form39 : Form
{
	private string string_0 = Class333.smethod_2316();

	private IContainer icontainer_0;

	private Label label_0;

	private ThemedTextBox themedTextBox_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	internal Form39()
	{
		method_2();
	}

	[SpecialName]
	internal string method_0()
	{
		return string_0;
	}

	[SpecialName]
	internal void method_1(string string_1)
	{
		string_0 = string_1;
	}

	private void Form39_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult == DialogResult.OK)
		{
			if (themedTextBox_0.Text.Length == 0)
			{
				Form54.smethod_6(this, Class333.smethod_2087(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Cancel = true;
			}
			else
			{
				string_0 = themedTextBox_0.Text;
			}
		}
	}

	private void Form39_Shown(object sender, EventArgs e)
	{
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
		themedTextBox_0.Text = string_0;
		themedTextBox_0.Focus();
		themedTextBox_0.SelectAll();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_2()
	{
		label_0 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(10, 9);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(117, 13);
		label_0.TabIndex = 0;
		label_0.Text = Class333.smethod_2317();
		themedTextBox_0.Location = new Point(13, 25);
		themedTextBox_0.Name = Class333.smethod_2090();
		themedTextBox_0.Size = new Size(228, 22);
		themedTextBox_0.TabIndex = 1;
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(20, 57);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(100, 30);
		themedButton_0.TabIndex = 2;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(134, 57);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(100, 30);
		themedButton_1.TabIndex = 3;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(255, 100);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Controls.Add(themedTextBox_0);
		Controls.Add(label_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2318();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2319();
		FormClosing += Form39_FormClosing;
		Shown += Form39_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
