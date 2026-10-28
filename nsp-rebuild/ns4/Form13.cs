using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns7;

namespace ns4;

internal class Form13 : Form
{
	private static readonly string string_0 = Form23.string_3 + Class333.smethod_1077();

	private Setting setting_0;

	private MenuNode menuNode_0;

	private IContainer icontainer_0;

	private Class134 class134_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Class148 class148_0;

	internal Form13(string string_1, Setting setting_1, MenuNode menuNode_1)
	{
		method_0();
		BackColor = Form23.color_10;
		class148_0.ForeColor = Form23.color_12;
		class134_0.BackColor = Form23.color_10;
		class134_0.ForeColor = Form23.color_12;
		class134_0.Text = string_1;
		class134_0.method_0();
		setting_0 = setting_1;
		menuNode_0 = menuNode_1;
		if (setting_0 != null)
		{
			if (!string.IsNullOrEmpty(setting_0.method_92()))
			{
				themedButton_0.Visible = false;
			}
			else
			{
				themedButton_0.Visible = true;
			}
			if (setting_0.method_64() == 14691)
			{
				class148_0.Visible = false;
			}
			else if (setting_0.method_49())
			{
				class148_0.Visible = false;
			}
			else
			{
				class148_0.Visible = true;
			}
		}
		else
		{
			themedButton_0.Visible = true;
			class148_0.Visible = true;
		}
	}

	private void Form13_Shown(object sender, EventArgs e)
	{
		if (setting_0 == null || !setting_0.method_49())
		{
			class148_0.Checked = !class148_0.Visible;
		}
	}

	private void Form13_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (setting_0 != null && setting_0.method_49())
		{
			return;
		}
		if (DialogResult == DialogResult.OK && class148_0.Checked)
		{
			string[] array = null;
			if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
			{
				Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
			}
			else if (File.Exists(string_0))
			{
				array = File.ReadAllLines(string_0);
			}
			else
			{
				File.Create(string_0).Close();
			}
			List<string> list = null;
			if (array != null)
			{
				list = new List<string>(array);
			}
			List<string> list2 = new List<string>();
			if (menuNode_0 != null)
			{
				string item = Class333.smethod_1065() + menuNode_0.method_100(bool_0: false, bool_1: true);
				if (list == null || !list.Contains(item))
				{
					list2.Add(item);
				}
			}
			if (setting_0 != null)
			{
				if (setting_0.method_64() == 14691)
				{
					string item2 = Class333.smethod_1066() + setting_0.method_0().aXc;
					if (list == null || !list.Contains(item2))
					{
						list2.Add(item2);
					}
				}
				else if (!string.IsNullOrEmpty(setting_0.method_92()))
				{
					string item3 = Class333.smethod_1067() + setting_0.method_64();
					if (list == null || !list.Contains(item3))
					{
						list2.Add(item3);
					}
				}
				else
				{
					string item4 = Class333.smethod_1068() + setting_0.method_64();
					if (list == null || !list.Contains(item4))
					{
						list2.Add(item4);
					}
				}
			}
			File.AppendAllLines(string_0, list2);
		}
		else
		{
			if (setting_0 == null || setting_0.method_64() != 14691 || !File.Exists(string_0))
			{
				return;
			}
			List<string> list3 = new List<string>(File.ReadAllLines(string_0));
			int num = list3.Count;
			bool flag = false;
			for (int i = 0; i < num; i++)
			{
				if (list3[i] == Class333.smethod_1066() + setting_0.method_0().aXc)
				{
					list3.RemoveAt(i);
					num--;
					flag = true;
				}
			}
			if (flag)
			{
				File.WriteAllLines(string_0, list3);
			}
		}
	}

	internal static bool smethod_0(Setting setting_1, MenuNode menuNode_1)
	{
		if (setting_1 != null && setting_1.method_49())
		{
			return false;
		}
		if (File.Exists(string_0))
		{
			using StreamReader streamReader = File.OpenText(string_0);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (menuNode_1 != null)
				{
					if (text.StartsWith(Class333.smethod_1065()) && text.Substring(Class333.smethod_1065().Length) == menuNode_1.method_100(bool_0: false, bool_1: true))
					{
						return true;
					}
				}
				else
				{
					if (setting_1 == null)
					{
						continue;
					}
					if (setting_1.method_64() == 14691)
					{
						if (text.StartsWith(Class333.smethod_1066()) && text.Substring(Class333.smethod_1066().Length) == setting_1.method_0().aXc)
						{
							return true;
						}
					}
					else if (!string.IsNullOrEmpty(setting_1.method_92()))
					{
						if (text.StartsWith(Class333.smethod_1067()) && int.Parse(text.Substring(Class333.smethod_1067().Length)) == setting_1.method_64())
						{
							return true;
						}
					}
					else if (text.StartsWith(Class333.smethod_1068()) && int.Parse(text.Substring(Class333.smethod_1068().Length)) == setting_1.method_64())
					{
						return true;
					}
				}
			}
		}
		return false;
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

	private void method_0()
	{
		class134_0 = new Class134();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		class148_0 = new Class148();
		SuspendLayout();
		class134_0.BorderStyle = BorderStyle.None;
		class134_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class134_0.Location = new Point(13, 13);
		class134_0.Name = Class333.smethod_1069();
		class134_0.ReadOnly = true;
		class134_0.ScrollBars = RichTextBoxScrollBars.Vertical;
		class134_0.Size = new Size(559, 408);
		class134_0.TabIndex = 3;
		class134_0.Text = Class333.smethod_102();
		class134_0.LinkClicked += class134_0_LinkClicked;
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_0.Location = new Point(497, 426);
		themedButton_0.Name = Class333.smethod_1070();
		themedButton_0.Size = new Size(75, 30);
		themedButton_0.TabIndex = 0;
		themedButton_0.Text = Class333.smethod_1071();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.OK;
		themedButton_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_1.Location = new Point(416, 426);
		themedButton_1.Name = Class333.smethod_1072();
		themedButton_1.Size = new Size(75, 30);
		themedButton_1.TabIndex = 1;
		themedButton_1.Text = Class333.smethod_1073();
		themedButton_1.UseVisualStyleBackColor = true;
		class148_0.AutoSize = true;
		class148_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class148_0.Location = new Point(16, 433);
		class148_0.Name = Class333.smethod_1074();
		class148_0.Size = new Size(212, 17);
		class148_0.TabIndex = 2;
		class148_0.Text = Class333.smethod_1075();
		class148_0.UseVisualStyleBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(584, 462);
		ControlBox = false;
		Controls.Add(class148_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Controls.Add(class134_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1076();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1076();
		FormClosing += Form13_FormClosing;
		Shown += Form13_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
