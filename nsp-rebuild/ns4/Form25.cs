using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns1;
using ns2;
using ns5;
using ns7;

namespace ns4;

internal class Form25 : Form
{
	internal class Class150 : ThemedComboBox
	{
		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			if (SelectedIndex >= 0)
			{
				using SolidBrush brush = new SolidBrush(Class98.BjA[SelectedIndex]);
				paintEventArgs_0.Graphics.FillRectangle(brush, paintEventArgs_0.ClipRectangle);
			}
			using Pen pen = new Pen(Brushes.Black, 1f);
			paintEventArgs_0.Graphics.DrawRectangle(pen, paintEventArgs_0.ClipRectangle.X, paintEventArgs_0.ClipRectangle.Y, paintEventArgs_0.ClipRectangle.Width - 1, paintEventArgs_0.ClipRectangle.Height - 1);
		}
	}

	private const int int_0 = 5;

	private List<Setting> list_0;

	private double double_0;

	private double double_1;

	private double double_2;

	private double double_3;

	private Dictionary<int, int> dictionary_0 = new Dictionary<int, int>();

	private Dictionary<int, int> dictionary_1 = new Dictionary<int, int>();

	private Dictionary<int, int> dictionary_2 = new Dictionary<int, int>();

	private List<int> list_1 = new List<int>();

	private List<int> list_2 = new List<int>();

	private int int_1;

	private List<TextBox> list_3 = new List<TextBox>();

	private List<TextBox> list_4 = new List<TextBox>();

	private List<TextBox> list_5 = new List<TextBox>();

	private List<TextBox> list_6 = new List<TextBox>();

	private List<Class150> list_7 = new List<Class150>();

	private IContainer icontainer_0;

	private Label label_0;

	private Label label_1;

	private NumericUpDown numericUpDown_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private ThemedTextBox themedTextBox_0;

	private ThemedTextBox themedTextBox_1;

	private Class148 class148_0;

	private Label label_9;

	private Label label_10;

	private ThemedTextBox themedTextBox_2;

	private ThemedTextBox themedTextBox_3;

	internal Form25()
	{
		method_14();
	}

	internal Form25(List<Setting> list_8, bool bool_0, double double_4, double double_5, double double_6, double double_7, Dictionary<int, int> dictionary_3, Dictionary<int, int> dictionary_4, List<int> list_9, List<int> list_10, Dictionary<int, int> dictionary_5, int int_2)
	{
		method_14();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
			else if (control is Class148)
			{
				control.ForeColor = Form23.color_12;
			}
			else if (control is ThemedTextBox)
			{
				control.BackColor = Form23.color_32;
				control.ForeColor = Form23.color_12;
			}
		}
		double_0 = double_4;
		double_1 = double_5;
		double_2 = double_6;
		double_3 = double_7;
		list_0 = list_8;
		foreach (KeyValuePair<int, int> item in dictionary_3)
		{
			dictionary_0.Add(item.Key, item.Value);
		}
		foreach (KeyValuePair<int, int> item2 in dictionary_4)
		{
			dictionary_1.Add(item2.Key, item2.Value);
		}
		foreach (KeyValuePair<int, int> item3 in dictionary_5)
		{
			dictionary_2.Add(item3.Key, item3.Value);
		}
		foreach (int item4 in list_9)
		{
			list_1.Add(item4);
		}
		foreach (int item5 in list_10)
		{
			list_2.Add(item5);
		}
		int_1 = int_2;
		method_0(bool_0);
	}

	private void method_0(bool bool_0)
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
		int num3 = label_4.Bottom + 5;
		int num4 = 0;
		foreach (Setting item2 in list_0)
		{
			int num5 = item2.method_231();
			int num6 = list_0.IndexOf(item2);
			int num7 = 5;
			Label label = new Label();
			label.Left = 5;
			label.Top = num3;
			label.Text = list[num6];
			label.AutoSize = true;
			label.Tag = num6;
			num7 = num;
			Controls.Add(label);
			ThemedTextBox themedTextBox = new ThemedTextBox();
			themedTextBox.Left = num7;
			themedTextBox.Top = num3;
			themedTextBox.Width = 100;
			themedTextBox.Tag = num6;
			themedTextBox.Name = Class333.smethod_2056() + num6;
			themedTextBox.Text = Class233.smethod_29(dictionary_0[item2.method_64()], num5);
			label_4.Left = num7;
			Controls.Add(themedTextBox);
			list_3.Add(themedTextBox);
			num7 += themedTextBox.Width + 5;
			ThemedTextBox themedTextBox2 = new ThemedTextBox();
			themedTextBox2.Left = num7;
			themedTextBox2.Top = num3;
			themedTextBox2.Width = 100;
			themedTextBox2.Tag = num6;
			themedTextBox2.Name = Class333.smethod_2057() + num6;
			themedTextBox2.Text = Class233.smethod_29(dictionary_1[item2.method_64()], num5);
			label_3.Left = num7;
			Controls.Add(themedTextBox2);
			list_4.Add(themedTextBox2);
			num7 += themedTextBox2.Width + 5;
			ThemedTextBox themedTextBox3 = new ThemedTextBox();
			themedTextBox3.Left = num7;
			themedTextBox3.Top = num3;
			themedTextBox3.Width = 100;
			themedTextBox3.Tag = num6;
			themedTextBox3.Name = Class333.smethod_1339() + num6;
			themedTextBox3.Text = Class233.smethod_29(list_1[num6], num5);
			label_6.Left = num7;
			Controls.Add(themedTextBox3);
			list_5.Add(themedTextBox3);
			num7 += themedTextBox3.Width + 5;
			ThemedTextBox themedTextBox4 = new ThemedTextBox();
			themedTextBox4.Left = num7;
			themedTextBox4.Top = num3;
			themedTextBox4.Width = 100;
			themedTextBox4.Tag = num6;
			themedTextBox4.Name = Class333.smethod_1340() + num6;
			themedTextBox4.Text = Class233.smethod_29(list_2[num6], num5);
			label_5.Left = num7;
			Controls.Add(themedTextBox4);
			list_6.Add(themedTextBox4);
			num7 += themedTextBox4.Width + 5;
			Class150 @class = new Class150();
			@class.Left = num7;
			@class.Top = num3;
			@class.Width = 47;
			@class.Tag = num6;
			@class.Name = Class333.smethod_2058() + num6;
			for (int i = 0; i < Class98.BjA.Length; i++)
			{
				@class.Items.Add(Class98.BjA[i].ToString());
			}
			@class.SelectedIndex = dictionary_2[item2.method_64()];
			@class.DrawMode = DrawMode.OwnerDrawFixed;
			@class.DropDownStyle = ComboBoxStyle.DropDownList;
			@class.DrawItem += method_13;
			label_2.Left = num7;
			Controls.Add(@class);
			list_7.Add(@class);
			num3 += label.Height + 10;
			num4 = @class.Right + 20;
		}
		num3 += 10;
		class148_0.Top = num3;
		label_8.Top = class148_0.Top + 20;
		label_7.Top = label_8.Top;
		label_10.Top = label_8.Top;
		label_9.Top = label_8.Top;
		themedTextBox_1.Top = label_8.Top + 18;
		themedTextBox_0.Top = themedTextBox_1.Top;
		themedTextBox_3.Top = themedTextBox_1.Top;
		themedTextBox_2.Top = themedTextBox_1.Top;
		numericUpDown_0.Top = themedTextBox_1.Top + 38;
		label_1.Left = 5;
		label_1.Top = numericUpDown_0.Top + 3;
		label_0.Top = label_1.Top;
		numericUpDown_0.Left = label_1.Right + 5;
		label_0.Left = numericUpDown_0.Right + 5;
		themedButton_1.Top = class148_0.Top + 67;
		themedButton_0.Top = themedButton_1.Top;
		themedButton_0.Left = num4 - themedButton_0.Width - 20;
		themedButton_1.Left = themedButton_0.Left - themedButton_1.Width - 5;
		numericUpDown_0.Value = int_1;
		Width = num4;
		Height = themedButton_1.Bottom + 50;
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
			else if (control is Class148)
			{
				control.ForeColor = Form23.color_12;
			}
			else if (control is ThemedTextBox)
			{
				control.BackColor = Form23.color_32;
				control.ForeColor = Form23.color_12;
			}
		}
		themedTextBox_1.Text = double_0.ToString();
		themedTextBox_0.Text = double_1.ToString();
		themedTextBox_3.Text = double_2.ToString();
		themedTextBox_2.Text = double_3.ToString();
		class148_0.Checked = bool_0;
	}

	private void class148_0_CheckedChanged(object sender, EventArgs e)
	{
		themedTextBox_1.Enabled = class148_0.Checked;
		themedTextBox_0.Enabled = class148_0.Checked;
		themedTextBox_3.Enabled = class148_0.Checked;
		themedTextBox_2.Enabled = class148_0.Checked;
		foreach (TextBox item in list_3)
		{
			item.Enabled = !class148_0.Checked;
		}
		foreach (TextBox item2 in list_4)
		{
			item2.Enabled = !class148_0.Checked;
		}
		foreach (TextBox item3 in list_5)
		{
			item3.Enabled = !class148_0.Checked;
		}
		foreach (TextBox item4 in list_6)
		{
			item4.Enabled = !class148_0.Checked;
		}
	}

	[SpecialName]
	internal bool method_1()
	{
		return class148_0.Checked;
	}

	[SpecialName]
	internal double method_2()
	{
		return double_0;
	}

	[SpecialName]
	internal double method_3()
	{
		return double_1;
	}

	[SpecialName]
	internal double method_4()
	{
		return double_2;
	}

	[SpecialName]
	internal double method_5()
	{
		return double_3;
	}

	[SpecialName]
	internal Dictionary<int, int> method_6()
	{
		return dictionary_0;
	}

	[SpecialName]
	internal Dictionary<int, int> method_7()
	{
		return dictionary_1;
	}

	[SpecialName]
	internal Dictionary<int, int> method_8()
	{
		return dictionary_2;
	}

	[SpecialName]
	internal List<int> method_9()
	{
		return list_1;
	}

	[SpecialName]
	internal List<int> method_10()
	{
		return list_2;
	}

	[SpecialName]
	internal int method_11()
	{
		return int_1;
	}

	private void Form25_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		string text = null;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		string arg = string.Empty;
		string arg2 = string.Empty;
		try
		{
			if (class148_0.Checked)
			{
				double num = double.Parse(themedTextBox_1.Text);
				double num2 = double.Parse(themedTextBox_0.Text);
				double num3 = double.Parse(themedTextBox_3.Text);
				double num4 = double.Parse(themedTextBox_2.Text);
				if (num >= num2)
				{
					flag = true;
					throw new Exception();
				}
				double_0 = num;
				double_1 = num2;
				double_2 = num3;
				double_3 = num4;
			}
			else
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					Setting setting = list_0[i];
					int num5 = setting.method_231();
					int num6 = setting.method_228();
					int num7 = setting.method_229();
					int num8 = int.MinValue;
					int num9 = int.MinValue;
					int num10 = int.MinValue;
					int num11 = int.MinValue;
					flag = false;
					flag2 = false;
					flag3 = false;
					flag4 = false;
					flag5 = false;
					arg = Class233.smethod_29(num6, num5);
					arg2 = Class233.smethod_29(num7, num5);
					text = null;
					foreach (Control control3 in Controls)
					{
						if (control3.Tag is int && (int)control3.Tag == i && control3 is Label)
						{
							text = (control3 as Label).Text;
							break;
						}
					}
					foreach (Control control4 in Controls)
					{
						if (control4.Tag is int && (int)control4.Tag == i && control4 is ThemedTextBox)
						{
							ThemedTextBox themedTextBox = control4 as ThemedTextBox;
							if (themedTextBox.Name.StartsWith(Class333.smethod_2056()))
							{
								num8 = Class233.smethod_25(themedTextBox.Text, num5);
							}
							if (themedTextBox.Name.StartsWith(Class333.smethod_2057()))
							{
								num9 = Class233.smethod_25(themedTextBox.Text, num5);
							}
							if (themedTextBox.Name.StartsWith(Class333.smethod_1339()))
							{
								num10 = Class233.smethod_25(themedTextBox.Text, num5);
							}
							if (themedTextBox.Name.StartsWith(Class333.smethod_1340()))
							{
								num11 = Class233.smethod_25(themedTextBox.Text, num5);
							}
						}
					}
					if (num8 < num9)
					{
						if (num6 != 0 || num7 != 0)
						{
							if (num8 < num6)
							{
								flag2 = true;
								throw new Exception();
							}
							if (num9 > num7)
							{
								flag3 = true;
								throw new Exception();
							}
							if (num10 < num6 || num10 > num7)
							{
								flag4 = true;
								throw new Exception();
							}
							if (num11 < num6 || num11 > num7)
							{
								flag5 = true;
								throw new Exception();
							}
						}
						dictionary_0[setting.method_64()] = num8;
						dictionary_1[setting.method_64()] = num9;
						list_1[i] = num10;
						list_2[i] = num11;
						continue;
					}
					flag = true;
					throw new Exception();
				}
			}
			for (int j = 0; j < list_0.Count; j++)
			{
				dictionary_2[list_0[j].method_64()] = list_7[j].SelectedIndex;
			}
			int_1 = (int)numericUpDown_0.Value;
		}
		catch
		{
			if (flag)
			{
				Form54.smethod_6(this, Class333.smethod_1154(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (flag2 | flag3 | flag4 | flag5)
			{
				string text2 = string.Empty;
				if (flag2)
				{
					text2 = Class333.smethod_1155();
				}
				else if (flag3)
				{
					text2 = Class333.smethod_1156();
				}
				else if (flag4)
				{
					text2 = Class333.smethod_1157();
				}
				else if (flag5)
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

	private void method_12(Class150 class150_0, int int_2, DrawItemEventArgs drawItemEventArgs_0)
	{
		if (class150_0.DroppedDown)
		{
			using (SolidBrush brush = new SolidBrush(Class98.BjA[drawItemEventArgs_0.Index]))
			{
				drawItemEventArgs_0.Graphics.FillRectangle(brush, drawItemEventArgs_0.Bounds);
				return;
			}
		}
		using (SolidBrush brush2 = new SolidBrush(Class98.BjA[class150_0.SelectedIndex]))
		{
			drawItemEventArgs_0.Graphics.FillRectangle(brush2, drawItemEventArgs_0.Bounds);
		}
		using Pen pen = new Pen(Brushes.Black, 1f);
		drawItemEventArgs_0.Graphics.DrawRectangle(pen, drawItemEventArgs_0.Bounds.X, drawItemEventArgs_0.Bounds.Y, drawItemEventArgs_0.Bounds.Width - 1, drawItemEventArgs_0.Bounds.Height - 1);
	}

	private void method_13(object sender, DrawItemEventArgs e)
	{
		Class150 @class = sender as Class150;
		method_12(sender as Class150, (int)@class.Tag, e);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_14()
	{
		label_0 = new Label();
		label_1 = new Label();
		numericUpDown_0 = new NumericUpDown();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		themedTextBox_1 = new ThemedTextBox();
		class148_0 = new Class148();
		label_9 = new Label();
		label_10 = new Label();
		themedTextBox_2 = new ThemedTextBox();
		themedTextBox_3 = new ThemedTextBox();
		((ISupportInitialize)numericUpDown_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(275, 378);
		label_0.Name = Class333.smethod_638();
		label_0.Size = new Size(50, 13);
		label_0.TabIndex = 84;
		label_0.Text = Class333.smethod_2059();
		label_1.AutoSize = true;
		label_1.Location = new Point(9, 378);
		label_1.Name = Class333.smethod_636();
		label_1.Size = new Size(192, 13);
		label_1.TabIndex = 83;
		label_1.Text = Class333.smethod_2060();
		numericUpDown_0.Location = new Point(197, 376);
		numericUpDown_0.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		numericUpDown_0.Name = Class333.smethod_2061();
		numericUpDown_0.Size = new Size(72, 22);
		numericUpDown_0.TabIndex = 80;
		numericUpDown_0.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label_2.AutoSize = true;
		label_2.Location = new Point(275, 9);
		label_2.Name = Class333.smethod_2062();
		label_2.Size = new Size(42, 13);
		label_2.TabIndex = 88;
		label_2.Text = Class333.smethod_2063();
		label_3.AutoSize = true;
		label_3.Location = new Point(66, 9);
		label_3.Name = Class333.smethod_2064();
		label_3.Size = new Size(56, 13);
		label_3.TabIndex = 87;
		label_3.Text = Class333.smethod_1020();
		label_4.AutoSize = true;
		label_4.Location = new Point(12, 9);
		label_4.Name = Class333.smethod_2065();
		label_4.Size = new Size(55, 13);
		label_4.TabIndex = 86;
		label_4.Text = Class333.smethod_2066();
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
		label_5.AutoSize = true;
		label_5.Location = new Point(195, 9);
		label_5.Name = Class333.smethod_1345();
		label_5.Size = new Size(80, 13);
		label_5.TabIndex = 90;
		label_5.Text = Class333.smethod_1168();
		label_6.AutoSize = true;
		label_6.Location = new Point(122, 9);
		label_6.Name = Class333.smethod_1346();
		label_6.Size = new Size(76, 13);
		label_6.TabIndex = 89;
		label_6.Text = Class333.smethod_1169();
		label_7.AutoSize = true;
		label_7.Location = new Point(122, 324);
		label_7.Name = Class333.smethod_2067();
		label_7.Size = new Size(56, 13);
		label_7.TabIndex = 95;
		label_7.Text = Class333.smethod_1020();
		label_8.AutoSize = true;
		label_8.Location = new Point(16, 324);
		label_8.Name = Class333.smethod_2068();
		label_8.Size = new Size(55, 13);
		label_8.TabIndex = 94;
		label_8.Text = Class333.smethod_2066();
		themedTextBox_0.Enabled = false;
		themedTextBox_0.Location = new Point(120, 340);
		themedTextBox_0.Name = Class333.smethod_2069();
		themedTextBox_0.Size = new Size(100, 22);
		themedTextBox_0.TabIndex = 93;
		themedTextBox_1.Enabled = false;
		themedTextBox_1.Location = new Point(14, 340);
		themedTextBox_1.Name = Class333.smethod_2070();
		themedTextBox_1.Size = new Size(100, 22);
		themedTextBox_1.TabIndex = 92;
		class148_0.AutoSize = true;
		class148_0.Location = new Point(12, 304);
		class148_0.Name = Class333.smethod_2071();
		class148_0.Size = new Size(220, 17);
		class148_0.TabIndex = 91;
		class148_0.Text = Class333.smethod_2072();
		class148_0.UseVisualStyleBackColor = true;
		class148_0.CheckedChanged += class148_0_CheckedChanged;
		label_9.AutoSize = true;
		label_9.Location = new Point(343, 324);
		label_9.Name = Class333.smethod_2073();
		label_9.Size = new Size(80, 13);
		label_9.TabIndex = 99;
		label_9.Text = Class333.smethod_1168();
		label_10.AutoSize = true;
		label_10.Location = new Point(237, 324);
		label_10.Name = Class333.smethod_2074();
		label_10.Size = new Size(76, 13);
		label_10.TabIndex = 98;
		label_10.Text = Class333.smethod_1169();
		themedTextBox_2.Enabled = false;
		themedTextBox_2.Location = new Point(341, 340);
		themedTextBox_2.Name = Class333.smethod_2075();
		themedTextBox_2.Size = new Size(100, 22);
		themedTextBox_2.TabIndex = 97;
		themedTextBox_3.Enabled = false;
		themedTextBox_3.Location = new Point(235, 340);
		themedTextBox_3.Name = Class333.smethod_2076();
		themedTextBox_3.Size = new Size(100, 22);
		themedTextBox_3.TabIndex = 96;
		AcceptButton = themedButton_1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(800, 450);
		Controls.Add(label_9);
		Controls.Add(label_10);
		Controls.Add(themedTextBox_2);
		Controls.Add(themedTextBox_3);
		Controls.Add(label_7);
		Controls.Add(label_8);
		Controls.Add(themedTextBox_0);
		Controls.Add(themedTextBox_1);
		Controls.Add(class148_0);
		Controls.Add(label_5);
		Controls.Add(label_6);
		Controls.Add(label_2);
		Controls.Add(label_3);
		Controls.Add(label_4);
		Controls.Add(label_0);
		Controls.Add(label_1);
		Controls.Add(numericUpDown_0);
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2077();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2078();
		FormClosing += Form25_FormClosing;
		((ISupportInitialize)numericUpDown_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
