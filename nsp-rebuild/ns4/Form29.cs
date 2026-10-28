using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form29 : Form
{
	private struct Struct42
	{
		internal ThemedTextBox Bqx;

		internal ThemedTextBox BqY;

		internal ThemedTextBox Bqy;
	}

	private Class256 class256_0;

	private MenuNode menuNode_0;

	private Setting setting_0;

	private List<Control> list_0 = new List<Control>();

	private Dictionary<string, Struct42> dictionary_0 = new Dictionary<string, Struct42>();

	private Image image_0;

	private string string_0;

	private PictureBox pictureBox_0;

	private int int_0;

	private Version version_0;

	private string string_1;

	private IContainer icontainer_0;

	private ThemedTextBox themedTextBox_0;

	private Label label_0;

	private ThemedTextBox themedTextBox_1;

	private Label label_1;

	private ThemedTextBox themedTextBox_2;

	private Label label_2;

	private ThemedTextBox themedTextBox_3;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_3;

	private Label label_4;

	private ThemedTextBox themedTextBox_4;

	private ThemedButton themedButton_2;

	private ThemedButton themedButton_3;

	private Class85 class85_0;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ThemedButton themedButton_4;

	internal Form29(Class256 class256_1, MenuNode menuNode_1)
	{
		method_3();
		Text = Class333.smethod_2106() + menuNode_1.method_10() + Class333.smethod_1394();
		BackColor = Form23.color_10;
		class256_0 = class256_1;
		menuNode_0 = menuNode_1;
		setting_0 = menuNode_0.method_1().method_31(menuNode_0.method_73());
		method_1();
		int num = label_0.Top - label_3.Top;
		int num2 = label_4.Top + num;
		int num3 = themedTextBox_4.Top + num;
		int num4 = themedTextBox_4.TabIndex + 1;
		for (int i = 0; i < class256_0.method_77().Count; i++)
		{
			string text = class256_0.method_77()[i];
			Label value = new Label
			{
				Font = label_3.Font,
				AutoSize = true,
				Text = Class286.smethod_12(text, Class333.smethod_562()) + Class333.smethod_134(),
				Left = label_3.Left,
				Top = num2
			};
			num2 += num;
			Controls.Add(value);
			Control control;
			if (class256_0.method_80().ContainsKey(text))
			{
				control = new ThemedComboBox();
				(control as ThemedComboBox).DropDownStyle = ComboBoxStyle.DropDown;
				ComboBox.ObjectCollection items = (control as ThemedComboBox).Items;
				object[] items2 = class256_0.method_80()[text];
				items.AddRange(items2);
				if (class256_0.method_80()[text].Length == 1)
				{
					control.Text = class256_0.method_80()[text][0];
				}
			}
			else
			{
				control = new ThemedTextBox();
			}
			control.Font = themedTextBox_2.Font;
			control.Size = themedTextBox_2.Size;
			control.Tag = text;
			control.Left = themedTextBox_2.Left;
			control.Top = num3;
			num3 += num;
			control.TabIndex = num4;
			num4++;
			list_0.Add(control);
			Controls.Add(control);
		}
		for (int j = 0; j < class256_0.method_78().Count; j++)
		{
			string text2 = class256_0.method_78()[j];
			if (class256_0.method_77().Contains(text2))
			{
				continue;
			}
			Label value2 = new Label
			{
				Font = label_3.Font,
				AutoSize = true,
				Text = Class286.smethod_12(text2, Class333.smethod_562()) + Class333.smethod_134(),
				Left = label_3.Left,
				Top = num2
			};
			num2 += num;
			Controls.Add(value2);
			Control control2;
			if (class256_0.method_80().ContainsKey(text2))
			{
				control2 = new ThemedComboBox();
				(control2 as ThemedComboBox).DropDownStyle = ComboBoxStyle.DropDown;
				ComboBox.ObjectCollection items3 = (control2 as ThemedComboBox).Items;
				object[] items2 = class256_0.method_80()[text2];
				items3.AddRange(items2);
				if (class256_0.method_80()[text2].Length == 1)
				{
					control2.Text = class256_0.method_80()[text2][0];
				}
			}
			else
			{
				control2 = new ThemedTextBox();
			}
			control2.Font = themedTextBox_2.Font;
			control2.Size = themedTextBox_2.Size;
			control2.Tag = text2;
			control2.Left = themedTextBox_2.Left;
			control2.Top = num3;
			num3 += num;
			control2.TabIndex = num4;
			num4++;
			list_0.Add(control2);
			Controls.Add(control2);
		}
		for (int k = 0; k < class256_0.method_79().Count; k++)
		{
			string text3 = class256_0.method_79()[k];
			if (class256_0.method_77().Contains(text3))
			{
				continue;
			}
			Label value3 = new Label
			{
				Font = label_3.Font,
				AutoSize = true,
				Text = Class286.smethod_12(text3, Class333.smethod_562()) + Class333.smethod_134(),
				Left = label_3.Left,
				Top = num2
			};
			num2 += num;
			Controls.Add(value3);
			Control control3;
			if (class256_0.method_80().ContainsKey(text3))
			{
				control3 = new ThemedComboBox();
				(control3 as ThemedComboBox).DropDownStyle = ComboBoxStyle.DropDown;
				ComboBox.ObjectCollection items4 = (control3 as ThemedComboBox).Items;
				object[] items2 = class256_0.method_80()[text3];
				items4.AddRange(items2);
				if (class256_0.method_80()[text3].Length == 1)
				{
					control3.Text = class256_0.method_80()[text3][0];
				}
			}
			else
			{
				control3 = new ThemedTextBox();
			}
			control3.Font = themedTextBox_2.Font;
			control3.Size = themedTextBox_2.Size;
			control3.Tag = text3;
			control3.Left = themedTextBox_2.Left;
			control3.Top = num3;
			num3 += num;
			control3.TabIndex = num4;
			num4++;
			list_0.Add(control3);
			Controls.Add(control3);
		}
		string[] array = new string[1] { Class333.smethod_562() };
		foreach (string text4 in array)
		{
			Struct42 value4 = default;
			Label value5 = new Label
			{
				Font = label_3.Font,
				AutoSize = true,
				Text = Class333.smethod_2107() + text4 + Class333.smethod_2108(),
				Left = label_3.Left,
				Top = num2
			};
			num2 += num;
			Controls.Add(value5);
			ThemedTextBox themedTextBox = new ThemedTextBox
			{
				Font = themedTextBox_2.Font,
				Size = themedTextBox_2.Size,
				Left = themedTextBox_2.Left,
				Top = num3
			};
			num3 += num;
			themedTextBox.TabIndex = num4;
			num4++;
			value4.Bqx = themedTextBox;
			Controls.Add(themedTextBox);
			Label value6 = new Label
			{
				Font = label_3.Font,
				AutoSize = true,
				Text = Class333.smethod_2109() + text4 + Class333.smethod_2108(),
				Left = label_3.Left,
				Top = num2
			};
			num2 += num;
			Controls.Add(value6);
			ThemedTextBox themedTextBox2 = new ThemedTextBox
			{
				Font = themedTextBox_2.Font,
				Size = themedTextBox_2.Size,
				Left = themedTextBox_2.Left,
				Top = num3
			};
			num3 += num;
			themedTextBox2.TabIndex = num4;
			num4++;
			value4.BqY = themedTextBox2;
			Controls.Add(themedTextBox2);
			Label value7 = new Label
			{
				Font = label_3.Font,
				AutoSize = true,
				Text = Class333.smethod_2110() + text4 + Class333.smethod_2108(),
				Left = label_3.Left,
				Top = num2
			};
			num2 += num * 4;
			Controls.Add(value7);
			ThemedTextBox themedTextBox3 = new ThemedTextBox
			{
				Font = themedTextBox_2.Font,
				Multiline = true,
				AcceptsReturn = true,
				Width = themedTextBox_2.Width,
				Height = num * 4 - (num - themedTextBox_2.Height),
				Left = themedTextBox_2.Left,
				Top = num3
			};
			num3 += num * 4;
			themedTextBox3.TabIndex = num4;
			num4++;
			value4.Bqy = themedTextBox3;
			Controls.Add(themedTextBox3);
			dictionary_0.Add(text4, value4);
		}
		themedButton_0.TabIndex = num4;
		themedButton_1.TabIndex = themedButton_0.TabIndex + 1;
		themedButton_4.TabIndex = themedButton_1.TabIndex + 1;
		themedButton_2.TabIndex = themedButton_4.TabIndex + 1;
		themedButton_3.TabIndex = themedButton_2.TabIndex + 1;
		class85_0.TabIndex = themedButton_3.TabIndex + 1;
		foreach (Control control4 in Controls)
		{
			if (control4 is ThemedTextBox)
			{
				(control4 as ThemedTextBox).BackColor = Form23.color_32;
				(control4 as ThemedTextBox).ForeColor = Form23.color_12;
			}
			else if (control4 is Label)
			{
				(control4 as Label).ForeColor = Form23.color_12;
			}
		}
		class85_0.BackColor = Form23.color_17;
		class85_0.ForeColor = Form23.color_12;
		int_0 = ClientSize.Width;
		if (menuNode_0.method_80() != null && menuNode_0.method_80().BcF != null)
		{
			method_0(menuNode_0.method_80());
		}
	}

	private void Form29_Shown(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			string_1 = Guid.NewGuid().ToString();
			version_0 = null;
			Version version = new Version(class256_0.method_71(), 0, 0);
			themedTextBox_0.Text = version.ToString();
		}
		else if (Form54.smethod_7(this, Class333.smethod_2111(), Class333.smethod_2112(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, new string[2]
		{
			Class333.smethod_1522(),
			Class333.smethod_2113()
		}) == DialogResult.Yes)
		{
			string_1 = Guid.NewGuid().ToString();
			version_0 = null;
			Version version2 = new Version(class256_0.method_71(), 0, 0);
			themedTextBox_0.Text = version2.ToString();
		}
		else
		{
			themedTextBox_1.Enabled = false;
			if (menuNode_0.method_94())
			{
				Version version3 = new Version(version_0.Major, version_0.Minor + 1, 0);
				themedTextBox_0.Text = version3.ToString();
			}
			else
			{
				Version version4 = new Version(version_0.Major, version_0.Minor, version_0.Build + 1);
				themedTextBox_0.Text = version4.ToString();
			}
		}
		themedTextBox_3.Focus();
	}

	private void method_0(Class287 class287_0)
	{
		string_1 = class287_0.BcF.BCX;
		version_0 = class287_0.BcF.BCY;
		themedTextBox_3.Text = Path.GetFileNameWithoutExtension(class287_0.Bcf);
		themedTextBox_1.Text = class287_0.BcF.BCy;
		themedTextBox_2.Text = class287_0.BcF.Bca;
		if (!string.IsNullOrEmpty(class287_0.BcF.BcB))
		{
			image_0 = Class288.smethod_1(class287_0);
			if (image_0 != null)
			{
				string_0 = class287_0.BcF.BcB;
				if (pictureBox_0 == null)
				{
					pictureBox_0 = new PictureBox();
					Controls.Add(pictureBox_0);
				}
				pictureBox_0.Top = 10;
				pictureBox_0.Left = class85_0.Left + class85_0.Width + 20;
				pictureBox_0.Height = Math.Min(ClientSize.Height - 20, image_0.Height);
				pictureBox_0.Width = image_0.Width * pictureBox_0.Height / image_0.Height;
				pictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox_0.Image = image_0;
				ClientSize = new Size(pictureBox_0.Left + pictureBox_0.Width + 10, ClientSize.Height);
				pictureBox_0.Visible = true;
			}
		}
		foreach (Control item in list_0)
		{
			string key = item.Tag as string;
			if (class287_0.BcF.Bcb.ContainsKey(key))
			{
				item.Text = class287_0.BcF.Bcb[key];
			}
		}
		foreach (string key2 in dictionary_0.Keys)
		{
			if (class287_0.BcF.BcC.ContainsKey(key2))
			{
				Class286.Struct48 @struct = class287_0.BcF.BcC[key2];
				dictionary_0[key2].Bqx.Text = @struct.BsP;
				dictionary_0[key2].BqY.Text = @struct.Bsp;
				dictionary_0[key2].Bqy.Text = @struct.BsQ;
			}
		}
	}

	private void method_1()
	{
		List<Setting> list = class256_0.method_88(menuNode_0);
		foreach (string item in Class285.smethod_2(null, menuNode_0, list, bool_0: true))
		{
			string[] array = new string[2];
			if (item.Contains(','))
			{
				array[0] = item.Substring(0, item.IndexOf(','));
				array[1] = item.Substring(item.IndexOf(',') + 1);
			}
			else
			{
				array[0] = item;
				array[1] = string.Empty;
			}
			class85_0.Items.Add(new ListViewItem(array));
		}
	}

	private void themedButton_4_Click(object sender, EventArgs e)
	{
		Class286 @class = method_2(out var _);
		if (@class == null)
		{
			return;
		}
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Title = Class333.smethod_2114();
		saveFileDialog.Filter = Class333.smethod_2115();
		saveFileDialog.InitialDirectory = Path.GetFullPath(Form23.string_17 + class256_0.method_81());
		if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
		{
			List<string> list = Class285.smethod_0(@class);
			list.Add(string.Empty);
			list.AddRange(Class285.smethod_1(@class, menuNode_0, bool_0: true));
			try
			{
				File.WriteAllLines(saveFileDialog.FileName, list);
			}
			catch (Exception ex)
			{
				Form54.smethod_6(this, Class333.smethod_2116() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		saveFileDialog.Dispose();
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = Class333.smethod_2117();
		string text = Form23.string_17 + class256_0.method_81() + Class333.smethod_177();
		if (Directory.Exists(text))
		{
			openFileDialog.InitialDirectory = text;
		}
		if (openFileDialog.ShowDialog(this) == DialogResult.OK)
		{
			themedTextBox_4.Text = openFileDialog.FileName;
			try
			{
				image_0 = Image.FromFile(themedTextBox_4.Text);
				string_0 = Path.GetFileName(themedTextBox_4.Text);
				if (pictureBox_0 == null)
				{
					pictureBox_0 = new PictureBox();
					Controls.Add(pictureBox_0);
				}
				pictureBox_0.Top = 10;
				pictureBox_0.Left = class85_0.Left + class85_0.Width + 20;
				pictureBox_0.Height = Math.Min(ClientSize.Height - 20, image_0.Height);
				pictureBox_0.Width = image_0.Width * pictureBox_0.Height / image_0.Height;
				pictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox_0.Image = image_0;
				ClientSize = new Size(pictureBox_0.Left + pictureBox_0.Width + 10, ClientSize.Height);
				pictureBox_0.Visible = true;
			}
			catch
			{
				if (pictureBox_0 != null)
				{
					pictureBox_0.Visible = false;
					pictureBox_0.Image = null;
					ClientSize = new Size(int_0, ClientSize.Height);
				}
				image_0 = null;
				string_0 = null;
				Form54.smethod_6(this, Class333.smethod_2118() + themedTextBox_4.Text, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				themedTextBox_4.Text = string.Empty;
			}
		}
		openFileDialog.Dispose();
	}

	private void themedButton_3_Click(object sender, EventArgs e)
	{
		if (pictureBox_0 != null)
		{
			pictureBox_0.Visible = false;
			pictureBox_0.Image = null;
			ClientSize = new Size(int_0, ClientSize.Height);
		}
		image_0 = null;
		string_0 = null;
		themedTextBox_4.Text = string.Empty;
	}

	private Class286 method_2(out string string_2)
	{
		Class286 @class = new Class286();
		string text = themedTextBox_3.Text;
		string_2 = null;
		try
		{
			if (string.IsNullOrEmpty(text))
			{
				throw new Exception();
			}
			if (text.EndsWith(Class333.smethod_1965()))
			{
				text = text.Substring(0, text.Length - Class333.smethod_1965().Length);
			}
		}
		catch
		{
			Form54.smethod_6(this, Class333.smethod_2119(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return null;
		}
		if (!text.Contains(Class333.smethod_176()) && !text.Contains(Class333.smethod_177()) && !text.Contains(Class333.smethod_134()) && !text.Contains(Class333.smethod_178()) && !text.Contains(Class333.smethod_179()) && !text.Contains(Class333.smethod_180()) && !text.Contains(Class333.smethod_182()) && !text.Contains(Class333.smethod_181()) && !text.Contains(Class333.smethod_183()))
		{
			string text2 = Form23.string_17 + class256_0.method_81();
			string_2 = text2 + Class333.smethod_177() + text + Class333.smethod_1965();
			if (Directory.Exists(text2))
			{
				if (File.Exists(string_2))
				{
					Form54.smethod_6(this, Class333.smethod_2121(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return null;
				}
			}
			else
			{
				try
				{
					Directory.CreateDirectory(text2);
				}
				catch
				{
					Form54.smethod_6(this, Class333.smethod_2122() + text2, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return null;
				}
			}
			@class.BCx = setting_0.method_8();
			@class.BCZ = Form23.framework_1.aXA;
			@class.BCz = Form23.framework_1.awZ;
			@class.BcA = Form23.framework_1.awz;
			if (string.IsNullOrEmpty(string_1))
			{
				Form54.smethod_6(this, Class333.smethod_2123(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return null;
			}
			@class.BCX = string_1;
			if (string.IsNullOrEmpty(themedTextBox_0.Text))
			{
				Form54.smethod_6(this, Class333.smethod_2124(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return null;
			}
			Version version = null;
			try
			{
				version = new Version(themedTextBox_0.Text);
			}
			catch
			{
				Form54.smethod_6(this, Class333.smethod_2125(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return null;
			}
			if (version_0 != null && version <= version_0)
			{
				Form54.smethod_6(this, Class333.smethod_2126(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return null;
			}
			@class.BCY = version;
			if (string.IsNullOrEmpty(themedTextBox_1.Text))
			{
				Form54.smethod_6(this, Class333.smethod_2127(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return null;
			}
			@class.BCy = themedTextBox_1.Text;
			if (string.IsNullOrEmpty(themedTextBox_4.Text))
			{
				if (image_0 != null && !string.IsNullOrEmpty(string_0))
				{
					@class.BcB = string_0;
				}
			}
			else
			{
				try
				{
					image_0 = Image.FromFile(themedTextBox_4.Text);
					string_0 = Path.GetFileName(themedTextBox_4.Text);
					@class.BcB = string_0;
				}
				catch
				{
					if (pictureBox_0 != null)
					{
						pictureBox_0.Visible = false;
						pictureBox_0.Image = null;
						ClientSize = new Size(int_0, ClientSize.Height);
					}
					image_0 = null;
					string_0 = null;
					Form54.smethod_6(this, Class333.smethod_2118() + themedTextBox_4.Text, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					themedTextBox_4.Text = string.Empty;
					return null;
				}
			}
			@class.Bca = themedTextBox_2.Text;
			foreach (Control item in list_0)
			{
				@class.Bcb.Add(item.Tag as string, item.Text);
			}
			{
				foreach (string key in dictionary_0.Keys)
				{
					if (!string.IsNullOrEmpty(dictionary_0[key].Bqx.Text))
					{
						if (!string.IsNullOrEmpty(dictionary_0[key].BqY.Text))
						{
							if (!string.IsNullOrEmpty(dictionary_0[key].Bqy.Text))
							{
								Class286.Struct48 value = new Class286.Struct48
								{
									BsP = dictionary_0[key].Bqx.Text,
									Bsp = dictionary_0[key].BqY.Text,
									BsQ = dictionary_0[key].Bqy.Text
								};
								@class.BcC.Add(key, value);
								continue;
							}
							Form54.smethod_6(this, Class333.smethod_2130(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return null;
						}
						Form54.smethod_6(this, Class333.smethod_2129(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return null;
					}
					Form54.smethod_6(this, Class333.smethod_2128(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return null;
				}
				return @class;
			}
		}
		Form54.smethod_6(this, Class333.smethod_2120(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		return null;
	}

	private void Form29_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		Class286 @class = method_2(out var string_);
		if (@class != null)
		{
			lock (Form23.object_0)
			{
				new Class289(string_, @class, Form23.framework_1, menuNode_0, bool_0: true, image_0).method_0();
				Class286 class2 = new Class288(string_).method_0();
				if (class2 != null)
				{
					Class287 class3 = new Class287();
					class3.BcF = class2;
					class3.Bcf = string_;
					Form23.smethod_91(class2.BCw, class3);
				}
			}
			string text = Class333.smethod_2131() + string_;
			Form54.smethod_6(this, text, Class333.smethod_2132(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else
		{
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
		themedTextBox_0 = new ThemedTextBox();
		label_0 = new Label();
		themedTextBox_1 = new ThemedTextBox();
		label_1 = new Label();
		themedTextBox_2 = new ThemedTextBox();
		label_2 = new Label();
		themedTextBox_3 = new ThemedTextBox();
		label_3 = new Label();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_4 = new Label();
		themedTextBox_4 = new ThemedTextBox();
		themedButton_2 = new ThemedButton();
		themedButton_3 = new ThemedButton();
		class85_0 = new Class85();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		themedButton_4 = new ThemedButton();
		SuspendLayout();
		themedTextBox_0.Location = new Point(136, 32);
		themedTextBox_0.Name = Class333.smethod_2133();
		themedTextBox_0.Size = new Size(386, 22);
		themedTextBox_0.TabIndex = 1;
		label_0.AutoSize = true;
		label_0.Location = new Point(6, 35);
		label_0.Name = Class333.smethod_620();
		label_0.Size = new Size(109, 13);
		label_0.TabIndex = 2;
		label_0.Text = Class333.smethod_2134();
		themedTextBox_1.Location = new Point(136, 58);
		themedTextBox_1.Name = Class333.smethod_2135();
		themedTextBox_1.Size = new Size(386, 22);
		themedTextBox_1.TabIndex = 2;
		label_1.AutoSize = true;
		label_1.Location = new Point(6, 61);
		label_1.Name = Class333.smethod_621();
		label_1.Size = new Size(80, 13);
		label_1.TabIndex = 4;
		label_1.Text = Class333.smethod_2136();
		themedTextBox_2.Location = new Point(136, 84);
		themedTextBox_2.Name = Class333.smethod_2137();
		themedTextBox_2.Size = new Size(386, 22);
		themedTextBox_2.TabIndex = 3;
		label_2.AutoSize = true;
		label_2.Location = new Point(6, 87);
		label_2.Name = Class333.smethod_623();
		label_2.Size = new Size(101, 13);
		label_2.TabIndex = 6;
		label_2.Text = Class333.smethod_2138();
		themedTextBox_3.Location = new Point(136, 6);
		themedTextBox_3.Name = Class333.smethod_1024();
		themedTextBox_3.Size = new Size(386, 22);
		themedTextBox_3.TabIndex = 0;
		label_3.AutoSize = true;
		label_3.Location = new Point(6, 9);
		label_3.Name = Class333.smethod_618();
		label_3.Size = new Size(121, 13);
		label_3.TabIndex = 9;
		label_3.Text = Class333.smethod_2139();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(706, 561);
		themedButton_0.Name = Class333.smethod_857();
		themedButton_0.Size = new Size(128, 42);
		themedButton_0.TabIndex = 5;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(844, 561);
		themedButton_1.Name = Class333.smethod_859();
		themedButton_1.Size = new Size(128, 42);
		themedButton_1.TabIndex = 6;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		label_4.AutoSize = true;
		label_4.Location = new Point(6, 113);
		label_4.Name = Class333.smethod_862();
		label_4.Size = new Size(117, 13);
		label_4.TabIndex = 10;
		label_4.Text = Class333.smethod_2140();
		themedTextBox_4.Location = new Point(135, 110);
		themedTextBox_4.Name = Class333.smethod_2141();
		themedTextBox_4.Size = new Size(194, 22);
		themedTextBox_4.TabIndex = 4;
		themedButton_2.Location = new Point(335, 108);
		themedButton_2.Name = Class333.smethod_2142();
		themedButton_2.Size = new Size(81, 25);
		themedButton_2.TabIndex = 11;
		themedButton_2.Text = Class333.smethod_1363();
		themedButton_2.UseVisualStyleBackColor = true;
		themedButton_2.Click += themedButton_2_Click;
		themedButton_3.Location = new Point(421, 108);
		themedButton_3.Name = Class333.smethod_2143();
		themedButton_3.Size = new Size(98, 25);
		themedButton_3.TabIndex = 12;
		themedButton_3.Text = Class333.smethod_2144();
		themedButton_3.UseVisualStyleBackColor = true;
		themedButton_3.Click += themedButton_3_Click;
		class85_0.BorderStyle = BorderStyle.FixedSingle;
		class85_0.Columns.AddRange(columnHeader_0, columnHeader_1);
		class85_0.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		class85_0.LabelWrap = false;
		class85_0.Location = new Point(528, 6);
		class85_0.MultiSelect = false;
		class85_0.Name = Class333.smethod_2145();
		class85_0.Size = new Size(450, 549);
		class85_0.TabIndex = 13;
		class85_0.UseCompatibleStateImageBehavior = false;
		class85_0.View = View.Details;
		columnHeader_0.Text = Class333.smethod_2146();
		columnHeader_0.Width = 270;
		columnHeader_1.Text = Class333.smethod_684();
		columnHeader_1.Width = 150;
		themedButton_4.Location = new Point(528, 561);
		themedButton_4.Name = Class333.smethod_2147();
		themedButton_4.Size = new Size(128, 42);
		themedButton_4.TabIndex = 14;
		themedButton_4.Text = Class333.smethod_2148();
		themedButton_4.UseVisualStyleBackColor = true;
		themedButton_4.Click += themedButton_4_Click;
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(984, 611);
		Controls.Add(themedButton_4);
		Controls.Add(class85_0);
		Controls.Add(themedButton_3);
		Controls.Add(themedButton_2);
		Controls.Add(themedTextBox_4);
		Controls.Add(label_4);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Controls.Add(label_3);
		Controls.Add(themedTextBox_3);
		Controls.Add(themedTextBox_2);
		Controls.Add(label_2);
		Controls.Add(themedTextBox_1);
		Controls.Add(label_1);
		Controls.Add(themedTextBox_0);
		Controls.Add(label_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2149();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2150();
		FormClosing += Form29_FormClosing;
		Shown += Form29_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
