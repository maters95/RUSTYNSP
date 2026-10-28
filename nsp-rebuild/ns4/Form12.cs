using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns1;
using ns5;
using ns7;

namespace ns4;

internal class Form12 : Form
{
	private double double_0;

	private string string_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private List<Setting.ListItems.Struct45> list_0;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private GroupBox groupBox_0;

	private ThemedTextBox themedTextBox_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private ThemedComboBox themedComboBox_0;

	private Label label_4;

	internal Form12(string string_1, Keys keys_0, string string_2, int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, List<Setting.ListItems.Struct45> list_1)
	{
		method_3();
		BackColor = Form23.color_10;
		foreach (Control control in groupBox_0.Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		Text = string_1;
		list_0 = list_1;
		if (list_0 != null && list_0.Count != 0)
		{
			int num = 0;
			string[] array = new string[list_0.Count];
			using (Graphics dc = CreateGraphics())
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					array[i] = list_0[i].bBV;
					num = Math.Max(TextRenderer.MeasureText(dc, array[i], themedComboBox_0.Font).Width, num);
				}
			}
			ComboBox.ObjectCollection items = themedComboBox_0.Items;
			object[] items2 = array;
			items.AddRange(items2);
			if (num > themedComboBox_0.DropDownWidth - 130)
			{
				themedComboBox_0.DropDownWidth = num + 130;
			}
			if (themedComboBox_0.Items.Count > 20)
			{
				themedComboBox_0.DropDownHeight = 360;
			}
		}
		switch (keys_0)
		{
		case Keys.None:
			if (string_2 != null)
			{
				themedTextBox_0.Text = string_2;
				themedComboBox_0.Text = string_2;
			}
			else
			{
				themedTextBox_0.Text = string.Empty;
				themedComboBox_0.Text = string.Empty;
			}
			break;
		case Keys.D0:
		case Keys.D1:
		case Keys.D2:
		case Keys.D3:
		case Keys.D4:
		case Keys.D5:
		case Keys.D6:
		case Keys.D7:
		case Keys.D8:
		case Keys.D9:
			themedTextBox_0.Text = ((int)(keys_0 - 48)).ToString();
			themedComboBox_0.Text = ((int)(keys_0 - 48)).ToString();
			break;
		default:
			if (keys_0 >= Keys.NumPad0 && keys_0 <= Keys.NumPad9)
			{
				themedTextBox_0.Text = ((int)(keys_0 - 96)).ToString();
				themedComboBox_0.Text = ((int)(keys_0 - 96)).ToString();
			}
			else if (keys_0 == Keys.OemMinus || keys_0 == Keys.Subtract)
			{
				themedTextBox_0.Text = Class333.smethod_186();
				themedComboBox_0.Text = Class333.smethod_186();
			}
			break;
		}
		label_0.Text = Class233.smethod_35(int_7, int_6, bool_0: false, 0);
		int_5 = int_6;
		int_1 = int_8;
		int_2 = int_9;
		int_3 = int_10;
		int_4 = int_11;
		if (int_1 == int_3 && int_2 == int_4)
		{
			label_2.Text = Class333.smethod_1046() + Class233.smethod_29(int_3, int_6);
			label_3.Text = Class333.smethod_1047() + Class233.smethod_29(int_4, int_6);
		}
		else
		{
			label_2.Text = Class333.smethod_1044() + Class233.smethod_29(int_3, int_6);
			label_3.Text = Class333.smethod_1045() + Class233.smethod_29(int_4, int_6);
		}
	}

	[SpecialName]
	internal double method_0()
	{
		return double_0;
	}

	[SpecialName]
	internal string method_1()
	{
		return string_0;
	}

	[SpecialName]
	internal int method_2()
	{
		return int_0;
	}

	private void Form12_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		string text = Class333.smethod_1048();
		try
		{
			if (list_0 != null && list_0.Count != 0)
			{
				text = themedComboBox_0.Text;
				foreach (Setting.ListItems.Struct45 item in list_0)
				{
					if (text == item.bBV)
					{
						string_0 = item.bBV;
						int_0 = item.bBv;
						return;
					}
				}
				int num = Class233.smethod_25(text, int_5);
				if (num < int_1 || num > int_2)
				{
					throw new Exception();
				}
				double_0 = double.Parse(text, NumberStyles.Any, CultureInfo.CurrentCulture);
			}
			else
			{
				text = themedTextBox_0.Text;
				int num2 = Class233.smethod_25(text, int_5);
				if (num2 < int_1 || num2 > int_2)
				{
					throw new Exception();
				}
				double_0 = double.Parse(text, NumberStyles.Any, CultureInfo.CurrentCulture);
			}
		}
		catch
		{
			string text2 = Class233.smethod_29(int_3, int_5);
			string text3 = Class233.smethod_29(int_4, int_5);
			if (int_1 == int_3 && int_2 == int_4)
			{
				Form54.smethod_6(this, string.Format(Class333.smethod_1050(), text, text2, text3), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				string text4 = Class233.smethod_29(int_1, int_5);
				string text5 = Class233.smethod_29(int_2, int_5);
				string format = Class333.smethod_1049();
				Struct65<object> gparam_ = default;
				Class332.smethod_1<Struct65<object>, object>(ref gparam_, 0) = text;
				Class332.smethod_1<Struct65<object>, object>(ref gparam_, 1) = text2;
				Class332.smethod_1<Struct65<object>, object>(ref gparam_, 2) = text3;
				Class332.smethod_1<Struct65<object>, object>(ref gparam_, 3) = text4;
				Class332.smethod_1<Struct65<object>, object>(ref gparam_, 4) = text5;
				Form54.smethod_6(this, string.Format(format, Class332.smethod_0<Struct65<object>, object>(in gparam_, 5)), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (list_0 != null && list_0.Count != 0)
			{
				themedComboBox_0.SelectAll();
			}
			else
			{
				themedTextBox_0.SelectAll();
			}
			e.Cancel = true;
		}
	}

	private void Form12_Shown(object sender, EventArgs e)
	{
		if (list_0 != null && list_0.Count != 0)
		{
			label_4.Visible = true;
			themedTextBox_0.Visible = false;
			themedComboBox_0.Visible = true;
			themedComboBox_0.Focus();
			themedComboBox_0.Select(themedComboBox_0.Text.Length, 0);
		}
		else
		{
			label_4.Visible = false;
			themedComboBox_0.Visible = false;
			themedTextBox_0.Visible = true;
			themedTextBox_0.Focus();
			themedTextBox_0.Select(themedTextBox_0.Text.Length, 0);
		}
	}

	private void themedTextBox_0_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '.')
		{
			if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator != Class333.smethod_190())
			{
				e.Handled = true;
			}
		}
		else if (e.KeyChar == ',' && CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator != Class333.smethod_189())
		{
			e.Handled = true;
		}
	}

	private void themedTextBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			themedButton_0.PerformClick();
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
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		groupBox_0 = new GroupBox();
		label_4 = new Label();
		themedComboBox_0 = new ThemedComboBox();
		label_2 = new Label();
		label_3 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		label_0 = new Label();
		label_1 = new Label();
		groupBox_0.SuspendLayout();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_0.Location = new Point(201, 112);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(95, 30);
		themedButton_0.TabIndex = 2;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_1.Location = new Point(302, 112);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(95, 30);
		themedButton_1.TabIndex = 3;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		groupBox_0.Controls.Add(label_4);
		groupBox_0.Controls.Add(themedComboBox_0);
		groupBox_0.Controls.Add(label_2);
		groupBox_0.Controls.Add(label_3);
		groupBox_0.Controls.Add(themedTextBox_0);
		groupBox_0.Controls.Add(label_0);
		groupBox_0.Controls.Add(label_1);
		groupBox_0.Location = new Point(7, 2);
		groupBox_0.Name = Class333.smethod_1051();
		groupBox_0.Size = new Size(390, 104);
		groupBox_0.TabIndex = 7;
		groupBox_0.TabStop = false;
		label_4.AutoSize = true;
		label_4.Location = new Point(210, 47);
		label_4.MaximumSize = new Size(170, 50);
		label_4.MinimumSize = new Size(170, 50);
		label_4.Name = Class333.smethod_1052();
		label_4.Size = new Size(170, 50);
		label_4.TabIndex = 15;
		label_4.Text = Class333.smethod_1053();
		label_4.Visible = false;
		themedComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_0.FormattingEnabled = true;
		themedComboBox_0.Location = new Point(84, 17);
		themedComboBox_0.MaxDropDownItems = 100;
		themedComboBox_0.Name = Class333.smethod_1054();
		themedComboBox_0.Size = new Size(180, 23);
		themedComboBox_0.TabIndex = 1;
		themedComboBox_0.KeyPress += themedTextBox_0_KeyPress;
		label_2.AutoSize = true;
		label_2.Location = new Point(16, 73);
		label_2.Name = Class333.smethod_1055();
		label_2.Size = new Size(129, 13);
		label_2.TabIndex = 13;
		label_2.Text = Class333.smethod_1056();
		label_3.AutoSize = true;
		label_3.Location = new Point(16, 48);
		label_3.Name = Class333.smethod_1057();
		label_3.Size = new Size(131, 13);
		label_3.TabIndex = 12;
		label_3.Text = Class333.smethod_1058();
		themedTextBox_0.Location = new Point(84, 17);
		themedTextBox_0.Name = Class333.smethod_1059();
		themedTextBox_0.Size = new Size(180, 22);
		themedTextBox_0.TabIndex = 0;
		themedTextBox_0.KeyDown += themedTextBox_0_KeyDown;
		themedTextBox_0.KeyPress += themedTextBox_0_KeyPress;
		label_0.AutoSize = true;
		label_0.Location = new Point(270, 20);
		label_0.Name = Class333.smethod_1060();
		label_0.Size = new Size(40, 13);
		label_0.TabIndex = 9;
		label_0.Text = Class333.smethod_1061();
		label_1.AutoSize = true;
		label_1.Location = new Point(16, 20);
		label_1.Name = Class333.smethod_618();
		label_1.Size = new Size(64, 13);
		label_1.TabIndex = 7;
		label_1.Text = Class333.smethod_1062();
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(404, 149);
		Controls.Add(groupBox_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1063();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1064();
		FormClosing += Form12_FormClosing;
		Shown += Form12_Shown;
		groupBox_0.ResumeLayout(performLayout: false);
		groupBox_0.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
