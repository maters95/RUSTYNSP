using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;
using ns2;
using ns7;

namespace ns4;

internal class Form15 : Form
{
	private string string_0;

	private IContainer icontainer_0;

	private Class134 class134_0;

	[SpecialName]
	internal static Version smethod_0()
	{
		Version version = new Version(0, 0, 0);
		try
		{
			string[] files = Directory.GetFiles(Form23.string_4 + Class333.smethod_1095(), Class333.smethod_1096(), SearchOption.AllDirectories);
			for (int i = 0; i < files.Length; i++)
			{
				string[] array = Path.GetFileNameWithoutExtension(files[i]).Split('_');
				if (array.Length >= 2 && Version.TryParse(array[1].Remove(0, 1), out Version result) && result > version)
				{
					version = result;
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1097() + ex.Message);
		}
		return version;
	}

	internal static string smethod_1()
	{
		string result = null;
		try
		{
			Version version = new Version(0, 0, 0);
			string[] files = Directory.GetFiles(Form23.string_4 + Class333.smethod_1095(), Class333.smethod_1096(), SearchOption.AllDirectories);
			foreach (string text in files)
			{
				string[] array = Path.GetFileNameWithoutExtension(text).Split('_');
				if (array.Length >= 2 && Version.TryParse(array[1].Remove(0, 1), out Version result2) && result2 > version)
				{
					version = result2;
					result = text;
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1098() + ex.Message);
		}
		return result;
	}

	internal Form15()
	{
		method_1();
		BackColor = Form23.color_10;
		class134_0.BackColor = Form23.color_17;
		class134_0.ForeColor = Form23.color_12;
		class134_0.SelectionStart = 0;
	}

	private void class134_0_LinkClicked(object sender, LinkClickedEventArgs e)
	{
		Process.Start(e.LinkText);
	}

	private void Form15_Shown(object sender, EventArgs e)
	{
		Text = Class333.smethod_1099() + Form1.smethod_0(smethod_0());
		string text = smethod_1();
		if (string.IsNullOrEmpty(text))
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form15));
			string_0 = componentResourceManager.GetString(Class333.smethod_1100());
		}
		else
		{
			using StreamReader streamReader = File.OpenText(text);
			string_0 = streamReader.ReadToEnd();
		}
		method_0();
	}

	private void method_0()
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			class134_0.ScrollBars = RichTextBoxScrollBars.None;
			class134_0.method_5(string_0);
			class134_0.ScrollBars = RichTextBoxScrollBars.Vertical;
			class134_0.method_0();
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

	private void method_1()
	{
		new ComponentResourceManager(typeof(Form15));
		class134_0 = new Class134();
		SuspendLayout();
		class134_0.Font = new Font(Class333.smethod_145(), class134_0.Font.Size);
		class134_0.BorderStyle = BorderStyle.None;
		class134_0.Dock = DockStyle.Fill;
		class134_0.Location = new Point(0, 0);
		class134_0.Name = Class333.smethod_1101();
		class134_0.ReadOnly = true;
		class134_0.Size = new Size(378, 555);
		class134_0.TabIndex = 0;
		class134_0.Text = Class333.smethod_102();
		class134_0.LinkClicked += class134_0_LinkClicked;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(384, 561);
		Controls.Add(class134_0);
		FormBorderStyle = FormBorderStyle.FixedToolWindow;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1102();
		Padding = new Padding(3);
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1103();
		TopMost = true;
		Shown += Form15_Shown;
		ResumeLayout(performLayout: false);
	}
}
