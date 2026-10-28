using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns5;
using ns7;

namespace ns4;

internal class Form20 : Form
{
	private double double_0;

	private string string_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private List<Setting.ListItems.Struct45> list_0;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private GroupBox groupBox_0;

	private ThemedComboBox themedComboBox_0;

	private Label label_0;

	private Label label_1;

	private ThemedTextBox themedTextBox_0;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Class148 class148_0;

	private Class148 class148_1;

	private Label label_6;

	private ThemedComboBox themedComboBox_1;

	internal Form20(int int_4, int int_5, int int_6, int int_7, int int_8, List<Setting.ListItems.Struct45> list_1)
	{
		method_9();
		BackColor = Form23.color_10;
		foreach (Control control3 in groupBox_0.Controls)
		{
			if (control3 is Label)
			{
				control3.ForeColor = Form23.color_12;
			}
		}
		foreach (Control control4 in Controls)
		{
			if (control4 is Label || control4 is CheckBox)
			{
				control4.ForeColor = Form23.color_12;
			}
		}
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
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
		label_3.Text = Class233.smethod_35(int_6, int_5, bool_0: false, 0);
		int_3 = int_5;
		int_1 = int_7;
		int_2 = int_8;
		label_0.Text = Class233.smethod_29(int_1, int_5);
		label_1.Text = Class233.smethod_29(int_2, int_5);
		if (list_0 != null && list_0.Count != 0)
		{
			themedComboBox_0.Text = Class233.smethod_29(int_4, int_5);
			foreach (Setting.ListItems.Struct45 item in list_0)
			{
				if (item.bBv == int_4)
				{
					themedComboBox_0.Text = item.bBV;
				}
			}
			themedComboBox_0.Visible = true;
			themedComboBox_0.Focus();
			themedComboBox_0.Select(themedComboBox_0.Text.Length, 0);
			themedTextBox_0.Visible = false;
		}
		else
		{
			themedTextBox_0.Visible = true;
			themedTextBox_0.Text = Class233.smethod_29(int_4, int_5);
			themedTextBox_0.Focus();
			themedTextBox_0.Select(themedTextBox_0.Text.Length, 0);
			themedComboBox_0.Visible = false;
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

	[SpecialName]
	internal bool method_3()
	{
		return class148_1.Checked;
	}

	[SpecialName]
	internal void method_4(bool bool_0)
	{
		class148_1.Checked = bool_0;
	}

	[SpecialName]
	internal bool method_5()
	{
		return class148_0.Checked;
	}

	[SpecialName]
	internal void method_6(bool bool_0)
	{
		class148_0.Checked = bool_0;
	}

	[SpecialName]
	internal int method_7()
	{
		return themedComboBox_1.SelectedIndex;
	}

	[SpecialName]
	internal void method_8(int int_4)
	{
		themedComboBox_1.SelectedIndex = int_4;
	}

	private void Form20_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		try
		{
			if (list_0 != null && list_0.Count != 0)
			{
				foreach (Setting.ListItems.Struct45 item in list_0)
				{
					if (themedComboBox_0.Text == item.bBV)
					{
						string_0 = item.bBV;
						int_0 = item.bBv;
						return;
					}
				}
				int num = Class233.smethod_25(themedComboBox_0.Text, int_3);
				if (num < int_1 || num > int_2)
				{
					throw new Exception();
				}
				double_0 = double.Parse(themedComboBox_0.Text, NumberStyles.Any, CultureInfo.CurrentCulture);
			}
			else
			{
				string text = themedTextBox_0.Text;
				int num2 = Class233.smethod_25(text, int_3);
				if (num2 < int_1 || num2 > int_2)
				{
					throw new Exception();
				}
				if (text.StartsWith(Class333.smethod_381()))
				{
					text.Remove(0, 2);
					double_0 = Convert.ToInt32(text, 16);
				}
				else
				{
					double_0 = double.Parse(text, NumberStyles.Any, CultureInfo.CurrentCulture);
				}
			}
		}
		catch (Exception)
		{
			Form54.smethod_6(this, Class333.smethod_1220(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_9()
	{
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		groupBox_0 = new GroupBox();
		themedComboBox_0 = new ThemedComboBox();
		label_0 = new Label();
		label_1 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		class148_0 = new Class148();
		class148_1 = new Class148();
		label_6 = new Label();
		themedComboBox_1 = new ThemedComboBox();
		groupBox_0.SuspendLayout();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_0.Location = new Point(217, 210);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(100, 30);
		themedButton_0.TabIndex = 2;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_1.Location = new Point(331, 210);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(100, 30);
		themedButton_1.TabIndex = 3;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		groupBox_0.Controls.Add(themedComboBox_0);
		groupBox_0.Controls.Add(label_0);
		groupBox_0.Controls.Add(label_1);
		groupBox_0.Controls.Add(themedTextBox_0);
		groupBox_0.Controls.Add(label_2);
		groupBox_0.Controls.Add(label_3);
		groupBox_0.Controls.Add(label_4);
		groupBox_0.Controls.Add(label_5);
		groupBox_0.Location = new Point(16, 60);
		groupBox_0.Name = Class333.smethod_1051();
		groupBox_0.Size = new Size(415, 104);
		groupBox_0.TabIndex = 2;
		groupBox_0.TabStop = false;
		themedComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedComboBox_0.FormattingEnabled = true;
		themedComboBox_0.Location = new Point(114, 17);
		themedComboBox_0.MaxDropDownItems = 100;
		themedComboBox_0.Name = Class333.smethod_1054();
		themedComboBox_0.Size = new Size(180, 23);
		themedComboBox_0.TabIndex = 0;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.Location = new Point(83, 72);
		label_0.Name = Class333.smethod_1055();
		label_0.Size = new Size(65, 13);
		label_0.TabIndex = 13;
		label_0.Text = Class333.smethod_1221();
		label_1.AutoSize = true;
		label_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_1.Location = new Point(83, 46);
		label_1.Name = Class333.smethod_1057();
		label_1.Size = new Size(66, 13);
		label_1.TabIndex = 12;
		label_1.Text = Class333.smethod_1222();
		themedTextBox_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedTextBox_0.Location = new Point(114, 17);
		themedTextBox_0.Name = Class333.smethod_1059();
		themedTextBox_0.Size = new Size(180, 22);
		themedTextBox_0.TabIndex = 0;
		label_2.AutoSize = true;
		label_2.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_2.Location = new Point(16, 72);
		label_2.Name = Class333.smethod_621();
		label_2.Size = new Size(30, 13);
		label_2.TabIndex = 10;
		label_2.Text = Class333.smethod_1223();
		label_3.AutoSize = true;
		label_3.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_3.Location = new Point(300, 20);
		label_3.Name = Class333.smethod_1060();
		label_3.Size = new Size(40, 13);
		label_3.TabIndex = 9;
		label_3.Text = Class333.smethod_1061();
		label_4.AutoSize = true;
		label_4.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_4.Location = new Point(16, 46);
		label_4.Name = Class333.smethod_620();
		label_4.Size = new Size(31, 13);
		label_4.TabIndex = 8;
		label_4.Text = Class333.smethod_1224();
		label_5.AutoSize = true;
		label_5.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_5.Location = new Point(16, 20);
		label_5.Name = Class333.smethod_618();
		label_5.Size = new Size(93, 13);
		label_5.TabIndex = 7;
		label_5.Text = Class333.smethod_1225();
		class148_0.AutoSize = true;
		class148_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class148_0.Location = new Point(16, 39);
		class148_0.Name = Class333.smethod_1226();
		class148_0.Size = new Size(55, 17);
		class148_0.TabIndex = 1;
		class148_0.Text = Class333.smethod_1227();
		class148_0.UseVisualStyleBackColor = true;
		class148_1.AutoSize = true;
		class148_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class148_1.Location = new Point(16, 12);
		class148_1.Name = Class333.smethod_1228();
		class148_1.Size = new Size(85, 17);
		class148_1.TabIndex = 0;
		class148_1.Text = Class333.smethod_1229();
		class148_1.UseVisualStyleBackColor = true;
		label_6.AutoSize = true;
		label_6.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_6.Location = new Point(13, 177);
		label_6.Name = Class333.smethod_623();
		label_6.Size = new Size(138, 13);
		label_6.TabIndex = 11;
		label_6.Text = Class333.smethod_1230();
		themedComboBox_1.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedComboBox_1.FormattingEnabled = true;
		themedComboBox_1.Items.AddRange(Class333.smethod_1231(), Class333.smethod_1232(), Class333.smethod_1233());
		themedComboBox_1.Location = new Point(154, 174);
		themedComboBox_1.Name = Class333.smethod_1234();
		themedComboBox_1.Size = new Size(121, 23);
		themedComboBox_1.TabIndex = 3;
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(447, 249);
		Controls.Add(themedComboBox_1);
		Controls.Add(label_6);
		Controls.Add(class148_1);
		Controls.Add(class148_0);
		Controls.Add(groupBox_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1235();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1236();
		FormClosing += Form20_FormClosing;
		groupBox_0.ResumeLayout(performLayout: false);
		groupBox_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
