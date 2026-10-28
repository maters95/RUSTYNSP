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

internal class Form4 : Form
{
	private Table table_0;

	private Enum50 enum50_0;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private RadioButton radioButton_0;

	private RadioButton radioButton_1;

	private RadioButton radioButton_2;

	internal Form4(Table table_1, bool bool_0)
	{
		method_3();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label || control is RadioButton)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		Form23.smethod_7(method_2);
		table_0 = table_1;
		if (bool_0)
		{
			Text = Class333.smethod_827();
		}
		else
		{
			Text = Class333.smethod_828();
		}
		radioButton_0.Paint += radioButton_2_Paint;
		radioButton_1.Paint += radioButton_2_Paint;
		radioButton_2.Paint += radioButton_2_Paint;
		if (table_0.HorizAxisEnabled() && table_0.HorizAxis.method_90() != null)
		{
			Setting setting = table_0.HorizAxis.method_92();
			if (setting != null)
			{
				int num = setting.method_231();
				if (num != 0 && num != 82)
				{
					string text = Class233.smethod_35(setting.method_232(), num, bool_0: false, 0);
					radioButton_0.Text = setting.method_60(Enum96.aYt) + Class333.smethod_497() + text + Class333.smethod_9();
				}
				else
				{
					radioButton_0.Text = setting.method_60(Enum96.aYt);
				}
			}
			else
			{
				radioButton_0.Enabled = false;
			}
		}
		else
		{
			radioButton_0.Enabled = false;
		}
		if (table_0.VertAxisEnabled() && table_0.VertAxis.method_90() != null)
		{
			Setting setting2 = table_0.VertAxis.method_92();
			if (setting2 != null)
			{
				int num2 = setting2.method_231();
				if (num2 != 0 && num2 != 82)
				{
					string text2 = Class233.smethod_35(setting2.method_232(), num2, bool_0: false, 0);
					radioButton_1.Text = setting2.method_60(Enum96.aYt) + Class333.smethod_497() + text2 + Class333.smethod_9();
				}
				else
				{
					radioButton_1.Text = setting2.method_60(Enum96.aYt);
				}
			}
			else
			{
				radioButton_1.Enabled = false;
			}
		}
		else
		{
			radioButton_1.Enabled = false;
		}
		if (table_0.SlicesEnabled() && table_0.SliceAxis.method_90() != null)
		{
			Setting setting3 = table_0.SliceAxis.method_92();
			if (setting3 != null)
			{
				int num3 = setting3.method_231();
				if (num3 != 0 && num3 != 82)
				{
					string text3 = Class233.smethod_35(setting3.method_232(), num3, bool_0: false, 0);
					radioButton_2.Text = setting3.method_60(Enum96.aYt) + Class333.smethod_497() + text3 + Class333.smethod_9();
				}
				else
				{
					radioButton_2.Text = setting3.method_60(Enum96.aYt);
				}
			}
			else
			{
				radioButton_2.Enabled = false;
			}
		}
		else
		{
			radioButton_2.Enabled = false;
		}
		if (radioButton_0.Enabled)
		{
			radioButton_0.Checked = true;
		}
		else if (radioButton_1.Enabled)
		{
			radioButton_1.Checked = true;
		}
		else if (radioButton_2.Enabled)
		{
			radioButton_2.Checked = true;
		}
		method_1();
	}

	internal Form4()
	{
		method_3();
	}

	[SpecialName]
	internal Enum50 method_0()
	{
		return enum50_0;
	}

	private void method_1()
	{
		if (radioButton_0.Checked)
		{
			enum50_0 = Enum50.const_0;
		}
		else if (radioButton_1.Checked)
		{
			enum50_0 = Enum50.const_1;
		}
		else if (radioButton_2.Checked)
		{
			enum50_0 = Enum50.const_2;
		}
	}

	private void radioButton_0_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void radioButton_1_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void radioButton_2_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void radioButton_2_Paint(object sender, PaintEventArgs e)
	{
		if (Form23.enum62_0 == Form23.Enum62.BqG || Form23.enum62_0 == Form23.Enum62.Bqh)
		{
			return;
		}
		RadioButton radioButton = sender as RadioButton;
		if (!radioButton.Enabled)
		{
			using (SolidBrush brush = new SolidBrush(BackColor))
			{
				e.Graphics.FillRectangle(brush, 17, 0, radioButton.Width - 17, radioButton.Height);
			}
			TextRenderer.DrawText(pt: new Point(17, 2), dc: e.Graphics, text: radioButton.Text, font: radioButton.Font, foreColor: Color.Gray, flags: TextFormatFlags.NoPrefix);
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.smethod_8(method_2);
		radioButton_0.Paint -= radioButton_2_Paint;
		radioButton_1.Paint -= radioButton_2_Paint;
		radioButton_2.Paint -= radioButton_2_Paint;
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
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		radioButton_0 = new RadioButton();
		radioButton_1 = new RadioButton();
		radioButton_2 = new RadioButton();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(82, 93);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(101, 37);
		themedButton_0.TabIndex = 3;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(191, 93);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(101, 37);
		themedButton_1.TabIndex = 4;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		radioButton_0.AutoSize = true;
		radioButton_0.Checked = true;
		radioButton_0.Location = new Point(12, 12);
		radioButton_0.Name = Class333.smethod_831();
		radioButton_0.Size = new Size(14, 13);
		radioButton_0.TabIndex = 0;
		radioButton_0.TabStop = true;
		radioButton_0.UseVisualStyleBackColor = true;
		radioButton_0.CheckedChanged += radioButton_0_CheckedChanged;
		radioButton_1.AutoSize = true;
		radioButton_1.Location = new Point(12, 35);
		radioButton_1.Name = Class333.smethod_832();
		radioButton_1.Size = new Size(14, 13);
		radioButton_1.TabIndex = 1;
		radioButton_1.UseVisualStyleBackColor = true;
		radioButton_1.CheckedChanged += radioButton_1_CheckedChanged;
		radioButton_2.AutoSize = true;
		radioButton_2.Location = new Point(12, 58);
		radioButton_2.Name = Class333.smethod_833();
		radioButton_2.Size = new Size(14, 13);
		radioButton_2.TabIndex = 2;
		radioButton_2.UseVisualStyleBackColor = true;
		radioButton_2.CheckedChanged += radioButton_2_CheckedChanged;
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(304, 142);
		Controls.Add(radioButton_2);
		Controls.Add(radioButton_1);
		Controls.Add(radioButton_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_834();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_835();
		FormClosing += Form4_FormClosing;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
