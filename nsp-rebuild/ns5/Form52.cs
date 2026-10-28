using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.UserInterface;
using ns4;
using ns7;

namespace ns5;

internal class Form52 : Form
{
	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private List<int> list_0 = new List<int>();

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private ThemedTextBox themedTextBox_0;

	private ThemedTextBox themedTextBox_1;

	private ThemedTextBox themedTextBox_2;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	internal Form52(int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, int int_12)
	{
		method_2();
		BackColor = Form23.color_10;
		label_0.ForeColor = Form23.color_12;
		label_1.ForeColor = Form23.color_12;
		label_2.ForeColor = Form23.color_12;
		label_7.ForeColor = Form23.color_12;
		label_6.ForeColor = Form23.color_12;
		label_5.ForeColor = Form23.color_12;
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		themedTextBox_1.BackColor = Form23.color_32;
		themedTextBox_1.ForeColor = Form23.color_12;
		themedTextBox_2.BackColor = Form23.color_32;
		themedTextBox_2.ForeColor = Form23.color_12;
		int_0 = int_6;
		int_1 = int_9;
		int_2 = int_10;
		int_3 = int_11;
		int_4 = int_12;
		int_5 = int_7;
		label_7.Text = (label_6.Text = (label_5.Text = Class233.smethod_35(int_8, int_7, bool_0: false, 0)));
	}

	[SpecialName]
	internal List<int> method_0()
	{
		return list_0;
	}

	private void method_1()
	{
		label_8.Visible = false;
		label_4.Visible = false;
		label_3.Visible = false;
		label_9.Visible = false;
		label_10.Visible = false;
		if (double.TryParse(themedTextBox_0.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out var result) && double.TryParse(themedTextBox_1.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out var result2))
		{
			int num = Class233.smethod_26(result, int_5);
			int num2 = Class233.smethod_26(result2, int_5);
			if (num > num2)
			{
				label_8.Visible = true;
				return;
			}
		}
		if (double.TryParse(themedTextBox_0.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out result) && double.TryParse(themedTextBox_1.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out result2) && double.TryParse(themedTextBox_2.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out var result3))
		{
			int num3 = Class233.smethod_26(result, int_5);
			int num4 = Class233.smethod_26(result2, int_5);
			int num5 = Class233.smethod_26(result3, int_5) - Class233.smethod_26(0.0, int_5);
			if (num5 != 0)
			{
				int num6 = num4 - num3;
				if (num6 / num5 + 1 > int_0)
				{
					label_4.Visible = true;
					return;
				}
				if (num5 > num6)
				{
					label_9.Visible = true;
					return;
				}
				if (num6 % num5 != 0)
				{
					label_3.Visible = true;
					return;
				}
			}
		}
		if (double.TryParse(themedTextBox_0.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out result))
		{
			int num7 = Class233.smethod_26(result, int_5);
			if (num7 < int_1 || num7 > int_2)
			{
				label_9.Visible = true;
				return;
			}
			if (num7 < int_3 || num7 > int_4)
			{
				label_10.Visible = true;
				return;
			}
		}
		if (!double.TryParse(themedTextBox_1.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out result2))
		{
			return;
		}
		int num8 = Class233.smethod_26(result2, int_5);
		if (num8 >= int_1 && num8 <= int_2)
		{
			if (num8 < int_3 || num8 > int_4)
			{
				label_10.Visible = true;
			}
		}
		else
		{
			label_9.Visible = true;
		}
	}

	private void themedTextBox_0_Leave(object sender, EventArgs e)
	{
		method_1();
	}

	private void themedTextBox_1_Leave(object sender, EventArgs e)
	{
		method_1();
	}

	private void themedTextBox_2_Leave(object sender, EventArgs e)
	{
		method_1();
	}

	private void Form52_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		list_0.Clear();
		if (!double.TryParse(themedTextBox_0.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out var result))
		{
			Form54.smethod_6(this, Class333.aAA(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
			return;
		}
		if (!double.TryParse(themedTextBox_1.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out var result2))
		{
			Form54.smethod_6(this, Class333.aAa(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
			return;
		}
		if (!double.TryParse(themedTextBox_2.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out var result3))
		{
			Form54.smethod_6(this, Class333.aAB(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
			return;
		}
		int num = Class233.smethod_26(result, int_5);
		int num2 = Class233.smethod_26(result2, int_5);
		int num3 = Class233.smethod_26(result3, int_5) - Class233.smethod_26(0.0, int_5);
		if (num > num2)
		{
			Form54.smethod_6(this, Class333.aAb(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
			return;
		}
		int num4 = num2 - num;
		if (num3 == 0)
		{
			Form54.smethod_6(this, Class333.smethod_605(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
			return;
		}
		if (num4 / num3 + 1 > int_0)
		{
			Form54.smethod_6(this, Class333.aAC(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
			return;
		}
		if (num3 <= num4 && num >= int_1 && num <= int_2 && num2 >= int_1 && num2 <= int_2)
		{
			try
			{
				int num5 = num;
				for (int i = 0; i <= num4 / num3; i++)
				{
					list_0.Add(num5);
					if (i != num4 / num3)
					{
						num5 += num3;
					}
				}
				if (num5 != num2)
				{
					list_0.Add(num2);
				}
				return;
			}
			catch
			{
				Form54.smethod_6(this, Class333.smethod_605(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Cancel = true;
				return;
			}
		}
		Form54.smethod_6(this, Class333.aAc(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		e.Cancel = true;
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
		themedTextBox_0 = new ThemedTextBox();
		themedTextBox_1 = new ThemedTextBox();
		themedTextBox_2 = new ThemedTextBox();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		label_9 = new Label();
		label_10 = new Label();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Location = new Point(166, 136);
		themedButton_0.Name = Class333.smethod_830();
		themedButton_0.Size = new Size(92, 30);
		themedButton_0.TabIndex = 4;
		themedButton_0.Text = Class333.smethod_823();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.OK;
		themedButton_1.Location = new Point(67, 136);
		themedButton_1.Name = Class333.smethod_829();
		themedButton_1.Size = new Size(93, 30);
		themedButton_1.TabIndex = 3;
		themedButton_1.Text = Class333.smethod_821();
		themedButton_1.UseVisualStyleBackColor = true;
		themedTextBox_0.Location = new Point(130, 9);
		themedTextBox_0.Name = Class333.aAD();
		themedTextBox_0.Size = new Size(100, 22);
		themedTextBox_0.TabIndex = 0;
		themedTextBox_0.Leave += themedTextBox_0_Leave;
		themedTextBox_1.Location = new Point(130, 37);
		themedTextBox_1.Name = Class333.aAd();
		themedTextBox_1.Size = new Size(100, 22);
		themedTextBox_1.TabIndex = 1;
		themedTextBox_1.Leave += themedTextBox_1_Leave;
		themedTextBox_2.Location = new Point(130, 65);
		themedTextBox_2.Name = Class333.aAE();
		themedTextBox_2.Size = new Size(100, 22);
		themedTextBox_2.TabIndex = 2;
		themedTextBox_2.Leave += themedTextBox_2_Leave;
		label_0.AutoSize = true;
		label_0.Location = new Point(11, 13);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(88, 13);
		label_0.TabIndex = 31;
		label_0.Text = Class333.aAe();
		label_1.AutoSize = true;
		label_1.Location = new Point(11, 41);
		label_1.Name = Class333.smethod_620();
		label_1.Size = new Size(84, 13);
		label_1.TabIndex = 32;
		label_1.Text = Class333.aAF();
		label_2.AutoSize = true;
		label_2.Location = new Point(11, 69);
		label_2.Name = Class333.smethod_621();
		label_2.Size = new Size(115, 13);
		label_2.TabIndex = 33;
		label_2.Text = Class333.aAf();
		label_3.AutoSize = true;
		label_3.ForeColor = Color.Orange;
		label_3.Location = new Point(12, 99);
		label_3.MaximumSize = new Size(300, 0);
		label_3.Name = Class333.aAG();
		label_3.Size = new Size(299, 26);
		label_3.TabIndex = 34;
		label_3.Text = Class333.aAg();
		label_3.Visible = false;
		label_4.AutoSize = true;
		label_4.ForeColor = Color.Red;
		label_4.Location = new Point(12, 105);
		label_4.Name = Class333.aAH();
		label_4.Size = new Size(207, 13);
		label_4.TabIndex = 35;
		label_4.Text = Class333.aAC();
		label_4.Visible = false;
		label_5.AutoSize = true;
		label_5.Location = new Point(236, 69);
		label_5.Name = Class333.aAh();
		label_5.Size = new Size(34, 13);
		label_5.TabIndex = 38;
		label_5.Text = Class333.smethod_282();
		label_6.AutoSize = true;
		label_6.Location = new Point(236, 41);
		label_6.Name = Class333.aAI();
		label_6.Size = new Size(34, 13);
		label_6.TabIndex = 37;
		label_6.Text = Class333.smethod_282();
		label_7.AutoSize = true;
		label_7.Location = new Point(236, 13);
		label_7.Name = Class333.aAi();
		label_7.Size = new Size(34, 13);
		label_7.TabIndex = 36;
		label_7.Text = Class333.smethod_282();
		label_8.AutoSize = true;
		label_8.ForeColor = Color.Red;
		label_8.Location = new Point(12, 105);
		label_8.Name = Class333.aAJ();
		label_8.Size = new Size(265, 13);
		label_8.TabIndex = 39;
		label_8.Text = Class333.aAb();
		label_8.Visible = false;
		label_9.AutoSize = true;
		label_9.ForeColor = Color.Red;
		label_9.Location = new Point(12, 105);
		label_9.Name = Class333.aAj();
		label_9.Size = new Size(188, 13);
		label_9.TabIndex = 40;
		label_9.Text = Class333.aAc();
		label_9.Visible = false;
		label_10.AutoSize = true;
		label_10.ForeColor = Color.Orange;
		label_10.Location = new Point(12, 105);
		label_10.Name = Class333.aAK();
		label_10.Size = new Size(244, 13);
		label_10.TabIndex = 41;
		label_10.Text = Class333.aAk();
		label_10.Visible = false;
		AcceptButton = themedButton_1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(324, 176);
		Controls.Add(label_10);
		Controls.Add(label_9);
		Controls.Add(label_8);
		Controls.Add(label_5);
		Controls.Add(label_6);
		Controls.Add(label_7);
		Controls.Add(label_4);
		Controls.Add(label_3);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(themedTextBox_2);
		Controls.Add(themedTextBox_1);
		Controls.Add(themedTextBox_0);
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Font = new Font(Class333.smethod_145(), 8.25f);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aAL();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.aAl();
		FormClosing += Form52_FormClosing;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
