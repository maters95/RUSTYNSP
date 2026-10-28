using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.UserInterface;
using ns7;

namespace ns4;

internal class Form9 : Form
{
	internal static readonly string string_0 = Form23.string_3 + Class333.smethod_900();

	private IContainer icontainer_0;

	private ThemedComboBox themedComboBox_0;

	private Label label_0;

	private ThemedButton themedButton_0;

	internal Form9()
	{
		method_0();
		BackColor = Form23.color_11;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		themedComboBox_0.SelectedIndex = (Form23.bool_21 ? 1 : 0);
	}

	private void Form9_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.bool_21 = themedComboBox_0.SelectedIndex == 1;
		if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
		{
			Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
		}
		File.Create(string_0).Close();
		List<string> list = new List<string>();
		list.Add(Class333.smethod_893() + Form23.bool_21);
		File.AppendAllLines(string_0, list);
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		Close();
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
		themedComboBox_0 = new ThemedComboBox();
		label_0 = new Label();
		themedButton_0 = new ThemedButton();
		SuspendLayout();
		themedComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_0.FormattingEnabled = true;
		themedComboBox_0.Items.AddRange(Class333.smethod_894(), Class333.smethod_895());
		themedComboBox_0.Location = new Point(12, 25);
		themedComboBox_0.Name = Class333.smethod_896();
		themedComboBox_0.Size = new Size(380, 23);
		themedComboBox_0.TabIndex = 0;
		label_0.AutoSize = true;
		label_0.Location = new Point(12, 9);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(192, 13);
		label_0.TabIndex = 9;
		label_0.Text = Class333.smethod_897();
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Location = new Point(150, 60);
		themedButton_0.Name = Class333.smethod_718();
		themedButton_0.Size = new Size(105, 34);
		themedButton_0.TabIndex = 1;
		themedButton_0.Text = Class333.smethod_719();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(404, 101);
		Controls.Add(themedButton_0);
		Controls.Add(label_0);
		Controls.Add(themedComboBox_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_898();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_899();
		FormClosing += Form9_FormClosing;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
