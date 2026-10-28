using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NSP.UserInterface;
using ns4;
using ns7;

namespace ns2;

internal class Form2 : Form
{
	private IContainer icontainer_0;

	private Class148 class148_0;

	private ThemedTextBox themedTextBox_0;

	private Label label_0;

	private ThemedButton themedButton_0;

	private Label label_1;

	internal Form2()
	{
		method_0();
	}

	private void Form2_Shown(object sender, EventArgs e)
	{
		Text = Class333.smethod_726();
		BackColor = Form23.color_11;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		class148_0.ForeColor = Form23.color_12;
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		Form10.smethod_0();
		class148_0.Checked = Form10.bool_2;
		themedTextBox_0.Text = Form10.int_19.ToString();
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (int.TryParse(themedTextBox_0.Text, out var result))
		{
			Form10.int_19 = result;
		}
		Form10.smethod_1();
		if (!Form10.bool_2 && (Form23.int_0 & 0x800) != 0)
		{
			Form23.class284_1.method_1();
		}
	}

	private void class148_0_CheckedChanged(object sender, EventArgs e)
	{
		Form10.bool_2 = class148_0.Checked;
		Form10.smethod_1();
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void themedTextBox_0_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
		{
			e.Handled = true;
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
		themedTextBox_0 = new ThemedTextBox();
		class148_0 = new Class148();
		themedButton_0 = new ThemedButton();
		label_1 = new Label();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(9, 38);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(138, 13);
		label_0.TabIndex = 2;
		label_0.Text = Class333.smethod_727();
		themedTextBox_0.Location = new Point(149, 34);
		themedTextBox_0.Name = Class333.smethod_728();
		themedTextBox_0.Size = new Size(70, 22);
		themedTextBox_0.TabIndex = 1;
		themedTextBox_0.KeyPress += themedTextBox_0_KeyPress;
		class148_0.AutoSize = true;
		class148_0.Location = new Point(12, 12);
		class148_0.Name = Class333.smethod_729();
		class148_0.Size = new Size(151, 17);
		class148_0.TabIndex = 0;
		class148_0.Text = Class333.smethod_730();
		class148_0.UseVisualStyleBackColor = true;
		class148_0.CheckedChanged += class148_0_CheckedChanged;
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Location = new Point(78, 67);
		themedButton_0.Name = Class333.smethod_718();
		themedButton_0.Size = new Size(105, 34);
		themedButton_0.TabIndex = 11;
		themedButton_0.Text = Class333.smethod_719();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		label_1.AutoSize = true;
		label_1.Location = new Point(221, 38);
		label_1.Name = Class333.smethod_620();
		label_1.Size = new Size(30, 13);
		label_1.TabIndex = 12;
		label_1.Text = Class333.smethod_731();
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(261, 107);
		Controls.Add(label_1);
		Controls.Add(themedButton_0);
		Controls.Add(label_0);
		Controls.Add(themedTextBox_0);
		Controls.Add(class148_0);
		Font = new Font(Class333.smethod_145(), 8.25f);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_732();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_726();
		FormClosing += Form2_FormClosing;
		Shown += Form2_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
