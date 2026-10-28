using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns5;
using ns7;

namespace ns4;

internal class Form28 : Form
{
	private Setting setting_0;

	private int int_0;

	private int int_1;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private ThemedTextBox themedTextBox_0;

	private ThemedTextBox themedTextBox_1;

	private Label label_3;

	internal Form28()
	{
		method_2();
	}

	internal Form28(Setting setting_1, int int_2, int int_3)
	{
		method_2();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
			if (control is ThemedTextBox)
			{
				control.BackColor = Form23.color_32;
				control.ForeColor = Form23.color_12;
			}
		}
		setting_0 = setting_1;
		int_0 = int_2;
		int_1 = int_3;
		if (setting_0 != null)
		{
			int num = setting_0.method_231();
			string text = setting_0.method_18();
			if (!string.IsNullOrWhiteSpace(text))
			{
				if (num != 0 && num != 82)
				{
					label_0.Text = text + Class333.smethod_497() + Class233.smethod_35(setting_0.method_232(), num, bool_0: false, 0) + Class333.smethod_9();
				}
				else
				{
					label_0.Text = text;
				}
			}
			else if (num != 0 && num != 82)
			{
				label_0.Text = setting_0.method_60(Enum96.aYT) + Class333.smethod_497() + Class233.smethod_35(setting_0.method_232(), num, bool_0: false, 0) + Class333.smethod_9();
			}
			else
			{
				label_0.Text = setting_0.method_60(Enum96.aYT);
			}
			themedTextBox_1.Text = Class233.smethod_29(int_0, num);
			themedTextBox_0.Text = Class233.smethod_29(int_1, num);
			themedTextBox_1.Visible = true;
			themedTextBox_0.Visible = true;
		}
		else
		{
			label_0.Text = string.Empty;
			themedTextBox_1.Visible = false;
			themedTextBox_0.Visible = false;
		}
	}

	[SpecialName]
	internal int method_0()
	{
		return int_0;
	}

	[SpecialName]
	internal int method_1()
	{
		return int_1;
	}

	private void Form28_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK || setting_0 == null)
		{
			return;
		}
		int num = setting_0.method_231();
		int num2 = setting_0.method_228();
		int num3 = setting_0.method_229();
		bool flag = false;
		bool flag2 = false;
		try
		{
			int num4 = Class233.smethod_25(themedTextBox_1.Text, num);
			int num5 = Class233.smethod_25(themedTextBox_0.Text, num);
			if (num2 != 0 || num3 != 0)
			{
				if (num4 < num2 || num4 > num3)
				{
					flag = true;
					throw new Exception();
				}
				if (num5 < num2 || num5 > num3)
				{
					flag2 = true;
					throw new Exception();
				}
			}
			int_0 = num4;
			int_1 = num5;
		}
		catch
		{
			string text;
			if (flag)
			{
				text = Class333.smethod_1157();
			}
			else
			{
				text = ((!flag2) ? Class333.smethod_1159() : Class333.smethod_1158());
			}
			string arg = Class233.smethod_29(num2, num);
			string arg2 = Class233.smethod_29(num3, num);
			Form54.smethod_6(this, string.Format(Class333.smethod_1160() + text + Class333.smethod_1161(), arg, arg2), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
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

	private void method_2()
	{
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		themedTextBox_1 = new ThemedTextBox();
		label_3 = new Label();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(30, 163);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(89, 34);
		themedButton_0.TabIndex = 2;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(125, 163);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(89, 34);
		themedButton_1.TabIndex = 3;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		label_0.AutoSize = true;
		label_0.Location = new Point(10, 10);
		label_0.Name = Class333.smethod_1162();
		label_0.Size = new Size(98, 13);
		label_0.TabIndex = 2;
		label_0.Text = Class333.smethod_1163();
		label_1.AutoSize = true;
		label_1.Location = new Point(127, 106);
		label_1.Name = Class333.smethod_618();
		label_1.Size = new Size(80, 13);
		label_1.TabIndex = 37;
		label_1.Text = Class333.smethod_1168();
		label_2.AutoSize = true;
		label_2.Location = new Point(21, 106);
		label_2.Name = Class333.smethod_620();
		label_2.Size = new Size(76, 13);
		label_2.TabIndex = 36;
		label_2.Text = Class333.smethod_1169();
		themedTextBox_0.Location = new Point(125, 122);
		themedTextBox_0.Name = Class333.smethod_1170();
		themedTextBox_0.Size = new Size(100, 22);
		themedTextBox_0.TabIndex = 1;
		themedTextBox_1.Location = new Point(19, 122);
		themedTextBox_1.Name = Class333.smethod_1171();
		themedTextBox_1.Size = new Size(100, 22);
		themedTextBox_1.TabIndex = 0;
		label_3.Location = new Point(10, 39);
		label_3.Name = Class333.smethod_621();
		label_3.Size = new Size(231, 62);
		label_3.TabIndex = 38;
		label_3.Text = Class333.smethod_1172();
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(244, 207);
		Controls.Add(label_3);
		Controls.Add(label_1);
		Controls.Add(label_2);
		Controls.Add(themedTextBox_0);
		Controls.Add(themedTextBox_1);
		Controls.Add(label_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2105();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1176();
		FormClosing += Form28_FormClosing;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
