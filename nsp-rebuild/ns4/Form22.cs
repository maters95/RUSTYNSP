using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns5;
using ns7;

namespace ns4;

internal class Form22 : Form
{
	private const int int_0 = 5;

	private List<Setting> list_0;

	private List<int> list_1 = new List<int>();

	private List<int> list_2 = new List<int>();

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	internal Form22()
	{
		method_3();
	}

	internal Form22(List<Setting> list_3, List<int> list_4, List<int> list_5)
	{
		method_3();
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
		list_0 = list_3;
		foreach (int item in list_4)
		{
			list_1.Add(item);
		}
		foreach (int item2 in list_5)
		{
			list_2.Add(item2);
		}
		method_0();
	}

	private void method_0()
	{
		List<string> list = new List<string>();
		int num = 0;
		foreach (Setting item in list_0)
		{
			string empty = string.Empty;
			int num2 = item.method_231();
			string text = item.method_18();
			if (string.IsNullOrWhiteSpace(text))
			{
				empty = ((num2 == 0 || num2 == 82) ? item.method_60(Enum96.aYt) : (item.method_60(Enum96.aYt) + Class333.smethod_497() + Class233.smethod_35(item.method_232(), num2, bool_0: false, 0) + Class333.smethod_9()));
			}
			else
			{
				empty = ((num2 == 0 || num2 == 82) ? text : (text + Class333.smethod_497() + Class233.smethod_35(item.method_232(), num2, bool_0: false, 0) + Class333.smethod_9()));
			}
			list.Add(empty);
			int width = TextRenderer.MeasureText(empty, Font).Width;
			if (width > num)
			{
				num = width;
			}
		}
		num += 50;
		int num3 = label_1.Bottom + 5;
		int num4 = 0;
		foreach (Setting item2 in list_0)
		{
			int int_ = item2.method_231();
			int num5 = list_0.IndexOf(item2);
			int num6 = 5;
			Label label = new Label();
			label.Left = 5;
			label.Top = num3;
			label.Text = list[num5];
			label.AutoSize = true;
			label.Tag = num5;
			num6 = num;
			Controls.Add(label);
			ThemedTextBox themedTextBox = new ThemedTextBox();
			themedTextBox.Left = num6;
			themedTextBox.Top = num3;
			themedTextBox.Width = 100;
			themedTextBox.Tag = num5;
			themedTextBox.Name = Class333.smethod_1339() + num5;
			themedTextBox.Text = Class233.smethod_29(list_1[num5], int_);
			label_1.Left = num6;
			Controls.Add(themedTextBox);
			num6 += themedTextBox.Width + 5;
			ThemedTextBox themedTextBox2 = new ThemedTextBox();
			themedTextBox2.Left = num6;
			themedTextBox2.Top = num3;
			themedTextBox2.Width = 100;
			themedTextBox2.Tag = num5;
			themedTextBox2.Name = Class333.smethod_1340() + num5;
			themedTextBox2.Text = Class233.smethod_29(list_2[num5], int_);
			label_0.Left = num6;
			Controls.Add(themedTextBox2);
			num3 += label.Height + 10;
			num4 = themedTextBox2.Right + 20;
		}
		num3 += 10;
		label_2.Top = num3;
		label_2.Width = num4 - label_2.Left * 4;
		num3 = label_2.Bottom;
		themedButton_1.Top = num3;
		themedButton_0.Top = themedButton_1.Top;
		themedButton_0.Left = num4 - themedButton_0.Width - 20;
		themedButton_1.Left = themedButton_0.Left - themedButton_1.Width - 5;
		Width = num4;
		Height = themedButton_1.Bottom + 45;
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
	}

	[SpecialName]
	internal List<int> method_1()
	{
		return list_1;
	}

	[SpecialName]
	internal List<int> method_2()
	{
		return list_2;
	}

	private void Form22_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		string text = null;
		bool flag = false;
		bool flag2 = false;
		string arg = string.Empty;
		string arg2 = string.Empty;
		try
		{
			int num = 0;
			while (true)
			{
				if (num >= list_0.Count)
				{
					return;
				}
				Setting setting = list_0[num];
				int int_ = setting.method_231();
				int num2 = setting.method_228();
				int num3 = setting.method_229();
				int num4 = int.MinValue;
				int num5 = int.MinValue;
				flag = false;
				flag2 = false;
				arg = Class233.smethod_29(num2, int_);
				arg2 = Class233.smethod_29(num3, int_);
				text = null;
				foreach (Control control3 in Controls)
				{
					if (control3.Tag is int && (int)control3.Tag == num && control3 is Label)
					{
						text = (control3 as Label).Text;
						break;
					}
				}
				foreach (Control control4 in Controls)
				{
					if (control4.Tag is int && (int)control4.Tag == num && control4 is ThemedTextBox)
					{
						ThemedTextBox themedTextBox = control4 as ThemedTextBox;
						if (themedTextBox.Name.StartsWith(Class333.smethod_1339()))
						{
							num4 = Class233.smethod_25(themedTextBox.Text, int_);
						}
						if (themedTextBox.Name.StartsWith(Class333.smethod_1340()))
						{
							num5 = Class233.smethod_25(themedTextBox.Text, int_);
						}
					}
				}
				if (num2 != 0 || num3 != 0)
				{
					if (num4 < num2 || num4 > num3)
					{
						break;
					}
					if (num5 < num2 || num5 > num3)
					{
						flag2 = true;
						throw new Exception();
					}
				}
				list_1[num] = num4;
				list_2[num] = num5;
				num++;
			}
			flag = true;
			throw new Exception();
		}
		catch
		{
			if (flag | flag2)
			{
				string text2 = string.Empty;
				if (flag)
				{
					text2 = Class333.smethod_1157();
				}
				else if (flag2)
				{
					text2 = Class333.smethod_1158();
				}
				if (text == null)
				{
					Form54.smethod_6(this, string.Format(Class333.smethod_1341() + text2 + Class333.smethod_1342(), arg, arg2), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					Form54.smethod_6(this, string.Format(Class333.smethod_1341() + text2 + Class333.smethod_1343() + text + Class333.smethod_1342(), arg, arg2), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else if (text == null)
			{
				Form54.smethod_6(this, Class333.smethod_605(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1344() + text, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

	private void method_3()
	{
		label_0 = new Label();
		label_1 = new Label();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_2 = new Label();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(66, 9);
		label_0.Name = Class333.smethod_1345();
		label_0.Size = new Size(80, 13);
		label_0.TabIndex = 87;
		label_0.Text = Class333.smethod_1168();
		label_1.AutoSize = true;
		label_1.Location = new Point(12, 9);
		label_1.Name = Class333.smethod_1346();
		label_1.Size = new Size(76, 13);
		label_1.TabIndex = 86;
		label_1.Text = Class333.smethod_1169();
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Location = new Point(107, 404);
		themedButton_0.Name = Class333.smethod_830();
		themedButton_0.Size = new Size(89, 34);
		themedButton_0.TabIndex = 39;
		themedButton_0.Text = Class333.smethod_823();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.OK;
		themedButton_1.Location = new Point(12, 404);
		themedButton_1.Name = Class333.smethod_829();
		themedButton_1.Size = new Size(89, 34);
		themedButton_1.TabIndex = 38;
		themedButton_1.Text = Class333.smethod_821();
		themedButton_1.UseVisualStyleBackColor = true;
		label_2.Location = new Point(9, 348);
		label_2.Name = Class333.smethod_1347();
		label_2.Size = new Size(333, 53);
		label_2.TabIndex = 88;
		label_2.Text = Class333.smethod_1172();
		AcceptButton = themedButton_1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(800, 450);
		Controls.Add(label_2);
		Controls.Add(label_0);
		Controls.Add(label_1);
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1348();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1176();
		FormClosing += Form22_FormClosing;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
