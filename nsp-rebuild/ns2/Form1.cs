using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;
using NSP.UserInterface;
using ns0;
using ns4;
using ns7;

namespace ns2;

internal class Form1 : Form
{
	private string string_0;

	private IContainer icontainer_0;

	private Class134 class134_0;

	private Label label_0;

	private Label label_1;

	private ThemedButton themedButton_0;

	private PictureBox pictureBox_0;

	private Label label_2;

	internal Form1()
	{
		method_1();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				(control as Label).ForeColor = Form23.color_12;
			}
		}
		class134_0.BackColor = Form23.color_17;
		class134_0.ForeColor = Form23.color_12;
		Version version = Assembly.GetEntryAssembly().GetName().Version;
		label_0.Text = Form23.string_1 + Class333.smethod_706() + smethod_0(version);
		label_2.Text = Class333.smethod_707() + smethod_1();
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Refresh();
		try
		{
			string text = smethod_2(Assembly.GetEntryAssembly().GetName().Version);
			if (!string.IsNullOrEmpty(text))
			{
				using (StreamReader streamReader = File.OpenText(text))
				{
					string_0 = streamReader.ReadToEnd();
					method_0();
					return;
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_708() + ex.Message);
		}
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	internal static string smethod_0(Version version_0)
	{
		List<string> list = new List<string>(version_0.ToString().Split('.'));
		if (list.Count > 3)
		{
			list.RemoveRange(3, list.Count - 3);
			return string.Join(Class333.smethod_190(), list.ToArray());
		}
		return version_0.ToString();
	}

	public static string smethod_1()
	{
		string text = Class333.smethod_709();
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default))
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey(Class333.smethod_710());
				if (registryKey2 != null)
				{
					text = (string)registryKey2.GetValue(Class333.smethod_194());
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	internal static string smethod_2(Version version_0)
	{
		string result = null;
		try
		{
			string[] files = Directory.GetFiles(Form23.string_4 + Class333.smethod_711(), Class333.smethod_712(), SearchOption.AllDirectories);
			Version version = new Version(0, 0, 0);
			string[] array = files;
			foreach (string text in array)
			{
				string[] array2 = Path.GetFileNameWithoutExtension(text).Split('_');
				if (array2.Length < 2 || !Version.TryParse(array2[1].Remove(0, 1), out Version result2))
				{
					continue;
				}
				if (version_0 == null)
				{
					if (result2 > version)
					{
						version = result2;
						result = text;
					}
				}
				else if (result2.Major == version_0.Major && result2.Minor == version_0.Minor && result2.Build == version_0.Build)
				{
					result = text;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			result = null;
			Class23.smethod_3(Class333.smethod_713() + ex.Message);
		}
		return result;
	}

	private void method_0()
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			if (!themedButton_0.Focused)
			{
				themedButton_0.Focus();
			}
			class134_0.ScrollBars = RichTextBoxScrollBars.None;
			class134_0.method_5(string_0);
			class134_0.ScrollBars = RichTextBoxScrollBars.Vertical;
			class134_0.method_0();
		}
	}

	private void class134_0_LinkClicked(object sender, LinkClickedEventArgs e)
	{
		Process.Start(e.LinkText);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_1()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		class134_0 = new Class134();
		label_0 = new Label();
		label_1 = new Label();
		themedButton_0 = new ThemedButton();
		pictureBox_0 = new PictureBox();
		label_2 = new Label();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class134_0.BorderStyle = BorderStyle.None;
		class134_0.Font = new Font(Class333.smethod_145(), 8.25f);
		class134_0.Location = new Point(14, 52);
		class134_0.Name = Class333.smethod_714();
		class134_0.ReadOnly = true;
		class134_0.ScrollBars = RichTextBoxScrollBars.Vertical;
		class134_0.Size = new Size(346, 292);
		class134_0.TabIndex = 1;
		class134_0.Text = Class333.smethod_102();
		class134_0.LinkClicked += class134_0_LinkClicked;
		label_0.AutoSize = true;
		label_0.Location = new Point(12, 9);
		label_0.Name = Class333.smethod_715();
		label_0.Size = new Size(139, 13);
		label_0.TabIndex = 7;
		label_0.Text = Class333.smethod_716();
		label_1.AutoSize = true;
		label_1.Location = new Point(13, 37);
		label_1.Name = Class333.smethod_618();
		label_1.Size = new Size(80, 13);
		label_1.TabIndex = 8;
		label_1.Text = Class333.smethod_717();
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Location = new Point(147, 375);
		themedButton_0.Name = Class333.smethod_718();
		themedButton_0.Size = new Size(80, 25);
		themedButton_0.TabIndex = 0;
		themedButton_0.Text = Class333.smethod_719();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		pictureBox_0.BackColor = Color.Transparent;
		pictureBox_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_720());
		pictureBox_0.Location = new Point(261, 6);
		pictureBox_0.Name = Class333.smethod_721();
		pictureBox_0.Size = new Size(107, 20);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 10;
		pictureBox_0.TabStop = false;
		label_2.AutoSize = true;
		label_2.Location = new Point(12, 354);
		label_2.Name = Class333.smethod_722();
		label_2.Size = new Size(115, 13);
		label_2.TabIndex = 11;
		label_2.Text = Class333.smethod_723();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(374, 409);
		Controls.Add(label_2);
		Controls.Add(pictureBox_0);
		Controls.Add(themedButton_0);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(class134_0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_724();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_725();
		Shown += Form1_Shown;
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
