using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns5;
using ns7;

namespace ns4;

internal class Form17 : Form
{
	private Setting setting_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_0;

	private ThemedTextBox themedTextBox_0;

	private ThemedTextBox themedTextBox_1;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private ThemedTextBox themedTextBox_2;

	private ThemedTextBox themedTextBox_3;

	private Label label_5;

	private Class148 class148_0;

	private Label label_6;

	internal Form17()
	{
		method_5();
	}

	internal Form17(Setting setting_1, int int_4, int int_5, int int_6, int int_7)
	{
		method_5();
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
		int_0 = int_4;
		int_1 = int_5;
		int_2 = int_6;
		int_3 = int_7;
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
			themedTextBox_0.Text = Class233.smethod_29(int_0, num);
			themedTextBox_1.Text = Class233.smethod_29(int_1, num);
			themedTextBox_3.Text = Class233.smethod_29(int_2, num);
			themedTextBox_2.Text = Class233.smethod_29(int_3, num);
			themedTextBox_0.Visible = true;
			themedTextBox_1.Visible = true;
			themedTextBox_3.Visible = true;
			themedTextBox_2.Visible = true;
		}
		else
		{
			label_0.Text = string.Empty;
			themedTextBox_0.Visible = false;
			themedTextBox_1.Visible = false;
			themedTextBox_3.Visible = false;
			themedTextBox_2.Visible = false;
		}
	}

	[SpecialName]
	internal bool method_0()
	{
		return class148_0.Checked;
	}

	[SpecialName]
	internal int method_1()
	{
		return int_0;
	}

	[SpecialName]
	internal int method_2()
	{
		return int_1;
	}

	[SpecialName]
	internal int method_3()
	{
		return int_2;
	}

	[SpecialName]
	internal int method_4()
	{
		return int_3;
	}

	private void Form17_FormClosing(object sender, FormClosingEventArgs e)
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
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		try
		{
			int num4 = Class233.smethod_25(themedTextBox_0.Text, num);
			int num5 = Class233.smethod_25(themedTextBox_1.Text, num);
			int num6 = Class233.smethod_25(themedTextBox_3.Text, num);
			int num7 = Class233.smethod_25(themedTextBox_2.Text, num);
			if (num4 >= num5)
			{
				flag = true;
				throw new Exception();
			}
			if (num2 != 0 || num3 != 0)
			{
				if (num4 < num2)
				{
					flag2 = true;
					throw new Exception();
				}
				if (num5 > num3)
				{
					flag3 = true;
					throw new Exception();
				}
				if (num6 < num2 || num6 > num3)
				{
					flag4 = true;
					throw new Exception();
				}
				if (num7 < num2 || num7 > num3)
				{
					flag5 = true;
					throw new Exception();
				}
			}
			int_0 = num4;
			int_1 = num5;
			int_2 = num6;
			int_3 = num7;
		}
		catch
		{
			if (flag)
			{
				Form54.smethod_6(this, Class333.smethod_1154(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				string text;
				if (flag2)
				{
					text = Class333.smethod_1155();
				}
				else if (flag3)
				{
					text = Class333.smethod_1156();
				}
				else if (flag4)
				{
					text = Class333.smethod_1157();
				}
				else
				{
					text = ((!flag5) ? Class333.smethod_1159() : Class333.smethod_1158());
				}
				string arg = Class233.smethod_29(num2, num);
				string arg2 = Class233.smethod_29(num3, num);
				Form54.smethod_6(this, string.Format(Class333.smethod_1160() + text + Class333.smethod_1161(), arg, arg2), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
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

	private void method_5()
	{
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_0 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		themedTextBox_1 = new ThemedTextBox();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		themedTextBox_2 = new ThemedTextBox();
		themedTextBox_3 = new ThemedTextBox();
		label_5 = new Label();
		class148_0 = new Class148();
		label_6 = new Label();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(30, 256);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(89, 34);
		themedButton_0.TabIndex = 5;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(126, 256);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(89, 34);
		themedButton_1.TabIndex = 6;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		label_0.AutoSize = true;
		label_0.Location = new Point(10, 10);
		label_0.Name = Class333.smethod_1162();
		label_0.Size = new Size(98, 13);
		label_0.TabIndex = 2;
		label_0.Text = Class333.smethod_1163();
		themedTextBox_0.Location = new Point(19, 54);
		themedTextBox_0.Name = Class333.smethod_1164();
		themedTextBox_0.Size = new Size(100, 22);
		themedTextBox_0.TabIndex = 0;
		themedTextBox_1.Location = new Point(125, 54);
		themedTextBox_1.Name = Class333.smethod_1165();
		themedTextBox_1.Size = new Size(100, 22);
		themedTextBox_1.TabIndex = 1;
		label_1.AutoSize = true;
		label_1.Location = new Point(21, 38);
		label_1.Name = Class333.smethod_633();
		label_1.Size = new Size(95, 13);
		label_1.TabIndex = 32;
		label_1.Text = Class333.smethod_1166();
		label_2.AutoSize = true;
		label_2.Location = new Point(127, 38);
		label_2.Name = Class333.smethod_635();
		label_2.Size = new Size(96, 13);
		label_2.TabIndex = 33;
		label_2.Text = Class333.smethod_1167();
		label_3.AutoSize = true;
		label_3.Location = new Point(127, 198);
		label_3.Name = Class333.smethod_618();
		label_3.Size = new Size(80, 13);
		label_3.TabIndex = 37;
		label_3.Text = Class333.smethod_1168();
		label_4.AutoSize = true;
		label_4.Location = new Point(21, 198);
		label_4.Name = Class333.smethod_620();
		label_4.Size = new Size(76, 13);
		label_4.TabIndex = 36;
		label_4.Text = Class333.smethod_1169();
		themedTextBox_2.Location = new Point(125, 214);
		themedTextBox_2.Name = Class333.smethod_1170();
		themedTextBox_2.Size = new Size(100, 22);
		themedTextBox_2.TabIndex = 4;
		themedTextBox_3.Location = new Point(19, 214);
		themedTextBox_3.Name = Class333.smethod_1171();
		themedTextBox_3.Size = new Size(100, 22);
		themedTextBox_3.TabIndex = 3;
		label_5.Location = new Point(10, 137);
		label_5.Name = Class333.smethod_621();
		label_5.Size = new Size(231, 58);
		label_5.TabIndex = 38;
		label_5.Text = Class333.smethod_1172();
		class148_0.Location = new Point(26, 91);
		class148_0.Name = Class333.smethod_1173();
		class148_0.Size = new Size(20, 17);
		class148_0.TabIndex = 2;
		class148_0.UseVisualStyleBackColor = true;
		label_6.Location = new Point(50, 80);
		label_6.Name = Class333.smethod_623();
		label_6.Size = new Size(180, 49);
		label_6.TabIndex = 40;
		label_6.Text = Class333.smethod_1174();
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(244, 297);
		Controls.Add(label_6);
		Controls.Add(class148_0);
		Controls.Add(label_5);
		Controls.Add(label_3);
		Controls.Add(label_4);
		Controls.Add(themedTextBox_2);
		Controls.Add(themedTextBox_3);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(themedTextBox_1);
		Controls.Add(themedTextBox_0);
		Controls.Add(label_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1175();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1176();
		FormClosing += Form17_FormClosing;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
