using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.UserInterface;
using ns1;
using ns5;
using ns7;

namespace ns4;

internal class Form27 : Form
{
	private bool bool_0;

	private string string_0;

	private List<string> list_0 = new List<string>();

	private string string_1 = Class333.smethod_2086();

	private Enum65 enum65_0;

	private IContainer icontainer_0;

	private Label label_0;

	private ThemedTextBox themedTextBox_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_1;

	private ThemedComboBox themedComboBox_0;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private ThemedButton themedButton_2;

	private Label label_5;

	private ThemedComboBox themedComboBox_1;

	private Label label_6;

	internal Form27()
	{
		method_5();
	}

	[SpecialName]
	internal string method_0()
	{
		return string_1;
	}

	[SpecialName]
	internal Enum65 method_1()
	{
		return enum65_0;
	}

	[SpecialName]
	internal string method_2()
	{
		return string_0;
	}

	[SpecialName]
	internal bool method_3()
	{
		return bool_0;
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		themedButton_0.PerformClick();
	}

	private void method_4()
	{
		themedComboBox_1.Items.Clear();
		list_0.Clear();
		if (Directory.Exists(Control25.BlX))
		{
			string[] array = null;
			try
			{
				array = Directory.GetFiles(Control25.BlX, Class333.smethod_1915());
			}
			catch
			{
				array = null;
			}
			if (array != null)
			{
				string[] array2 = array;
				foreach (string text in array2)
				{
					themedComboBox_1.Items.Add(Path.GetFileNameWithoutExtension(text));
					list_0.Add(text);
				}
			}
		}
		themedComboBox_1.SelectedIndex = -1;
	}

	private void themedComboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (themedComboBox_1.SelectedIndex != -1 && list_0.Count > themedComboBox_1.SelectedIndex)
		{
			string_0 = list_0[themedComboBox_1.SelectedIndex];
		}
		else
		{
			string_0 = null;
		}
	}

	private void Form27_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult == DialogResult.OK && !bool_0 && string.IsNullOrEmpty(string_0))
		{
			if (themedTextBox_0.Text.Length == 0)
			{
				Form54.smethod_6(this, Class333.smethod_2087(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Cancel = true;
			}
			else if (themedComboBox_0.SelectedIndex != 0 && themedComboBox_0.SelectedIndex != 1)
			{
				Form54.smethod_6(this, Class333.smethod_2088(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Cancel = true;
			}
			else
			{
				string_1 = themedTextBox_0.Text;
				enum65_0 = (Enum65)themedComboBox_0.SelectedIndex;
			}
		}
	}

	private void Form27_Shown(object sender, EventArgs e)
	{
		bool_0 = false;
		string_0 = null;
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		themedComboBox_1.BackColor = Form23.color_32;
		themedComboBox_1.ForeColor = Form23.color_12;
		themedComboBox_0.BackColor = Form23.color_32;
		themedComboBox_0.ForeColor = Form23.color_12;
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		method_4();
		themedComboBox_0.SelectedIndex = (int)enum65_0;
		themedComboBox_1.Focus();
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form27));
		label_0 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_1 = new Label();
		themedComboBox_0 = new ThemedComboBox();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		themedButton_2 = new ThemedButton();
		label_5 = new Label();
		themedComboBox_1 = new ThemedComboBox();
		label_6 = new Label();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(10, 134);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(142, 13);
		label_0.TabIndex = 0;
		label_0.Text = Class333.smethod_2089();
		themedTextBox_0.Location = new Point(12, 150);
		themedTextBox_0.Name = Class333.smethod_2090();
		themedTextBox_0.Size = new Size(257, 22);
		themedTextBox_0.TabIndex = 2;
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(33, 372);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(100, 30);
		themedButton_0.TabIndex = 4;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(151, 372);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(100, 30);
		themedButton_1.TabIndex = 5;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		label_1.AutoSize = true;
		label_1.Location = new Point(10, 179);
		label_1.Name = Class333.smethod_620();
		label_1.Size = new Size(123, 13);
		label_1.TabIndex = 4;
		label_1.Text = Class333.smethod_2091();
		themedComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_0.FormattingEnabled = true;
		themedComboBox_0.Items.AddRange(Class333.smethod_2092(), Class333.smethod_2093());
		themedComboBox_0.Location = new Point(12, 195);
		themedComboBox_0.MaxDropDownItems = 2;
		themedComboBox_0.Name = Class333.smethod_2094();
		themedComboBox_0.Size = new Size(257, 23);
		themedComboBox_0.TabIndex = 3;
		label_2.AutoSize = true;
		label_2.Location = new Point(5, 225);
		label_2.MaximumSize = new Size(273, 0);
		label_2.Name = Class333.smethod_621();
		label_2.Size = new Size(273, 78);
		label_2.TabIndex = 6;
		label_2.Text = componentResourceManager.GetString(Class333.smethod_2095());
		label_3.AutoSize = true;
		label_3.Location = new Point(5, 310);
		label_3.MaximumSize = new Size(273, 0);
		label_3.Name = Class333.smethod_635();
		label_3.Size = new Size(267, 52);
		label_3.TabIndex = 11;
		label_3.Text = Class333.smethod_2096();
		label_4.AutoSize = true;
		label_4.Location = new Point(99, 55);
		label_4.Name = Class333.smethod_623();
		label_4.Size = new Size(94, 13);
		label_4.TabIndex = 13;
		label_4.Text = Class333.smethod_2097();
		themedButton_2.Location = new Point(67, 70);
		themedButton_2.Name = Class333.smethod_2098();
		themedButton_2.Size = new Size(156, 25);
		themedButton_2.TabIndex = 1;
		themedButton_2.Text = Class333.smethod_2099();
		themedButton_2.UseVisualStyleBackColor = true;
		themedButton_2.Click += themedButton_2_Click;
		label_5.AutoSize = true;
		label_5.Location = new Point(66, 114);
		label_5.Name = Class333.smethod_862();
		label_5.Size = new Size(158, 13);
		label_5.TabIndex = 19;
		label_5.Text = Class333.smethod_2100();
		themedComboBox_1.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_1.FormattingEnabled = true;
		themedComboBox_1.Location = new Point(12, 23);
		themedComboBox_1.MaxDropDownItems = 100;
		themedComboBox_1.Name = Class333.smethod_2101();
		themedComboBox_1.Size = new Size(257, 23);
		themedComboBox_1.TabIndex = 0;
		themedComboBox_1.SelectedIndexChanged += themedComboBox_1_SelectedIndexChanged;
		label_6.AutoSize = true;
		label_6.Location = new Point(10, 7);
		label_6.Name = Class333.smethod_864();
		label_6.Size = new Size(115, 13);
		label_6.TabIndex = 22;
		label_6.Text = Class333.smethod_2102();
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(282, 410);
		Controls.Add(label_6);
		Controls.Add(themedComboBox_1);
		Controls.Add(label_5);
		Controls.Add(themedButton_2);
		Controls.Add(label_4);
		Controls.Add(label_3);
		Controls.Add(label_2);
		Controls.Add(themedComboBox_0);
		Controls.Add(label_1);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Controls.Add(themedTextBox_0);
		Controls.Add(label_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2103();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2104();
		FormClosing += Form27_FormClosing;
		Shown += Form27_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
