using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.UserInterface;
using ns0;
using ns2;
using ns4;
using ns7;

namespace ns5;

internal class Form49 : Form
{
	private string string_0;

	private Version version_0;

	private Version version_1;

	private IContainer icontainer_0;

	private Class134 class134_0;

	private Label label_0;

	private Label label_1;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private ThemedButton themedButton_2;

	private Class148 class148_0;

	private LinkLabel linkLabel_0;

	internal Form49(Version version_2, Version version_3)
	{
		method_1();
		version_0 = version_2;
		version_1 = version_3;
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
		class148_0.ForeColor = Form23.color_12;
		if (version_0 != null && version_1 != null)
		{
			label_0.Text = Class333.smethod_2572() + Form1.smethod_0(version_0) + Class333.smethod_2573() + Form1.smethod_0(version_1) + Class333.smethod_2574();
		}
		else if (version_0 != null && version_1 == null)
		{
			label_0.Text = Class333.smethod_2575() + Form1.smethod_0(version_0) + Class333.smethod_2576();
		}
		else if (version_0 == null && version_1 != null)
		{
			label_0.Text = Class333.smethod_2577() + Form1.smethod_0(version_1) + Class333.smethod_2576();
		}
		bool flag = Form23.form23_0.statsReporter_0.UserPrivacyOptionRegistryExists();
		bool flag2 = false;
		if (flag)
		{
			flag2 = Form23.form23_0.statsReporter_0.UserOptInPrivacy;
		}
		bool flag3 = false;
		if (!flag2)
		{
			if (Form23.form23_0.statsReporter_0.LastAgreedPrivacyDocVerRegistryEntryExists())
			{
				Version lastAgreedPrivacyDocumentVer = Form23.form23_0.statsReporter_0.LastAgreedPrivacyDocumentVer;
				if (Form15.smethod_0() > lastAgreedPrivacyDocumentVer)
				{
					flag3 = true;
				}
			}
			else
			{
				flag3 = true;
			}
		}
		if (flag3)
		{
			class148_0.Visible = true;
			class148_0.Enabled = true;
			linkLabel_0.Visible = true;
			linkLabel_0.Enabled = true;
			themedButton_0.Enabled = false;
			themedButton_1.Enabled = false;
			class134_0.Height = linkLabel_0.Top - class134_0.Top - 5;
		}
		else
		{
			themedButton_0.Enabled = true;
			themedButton_1.Enabled = true;
			class134_0.Height = themedButton_0.Top - class134_0.Top - 5;
		}
	}

	private void Form49_Shown(object sender, EventArgs e)
	{
		Refresh();
		try
		{
			string text = Form1.smethod_2(version_0);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			using StreamReader streamReader = File.OpenText(text);
			string_0 = streamReader.ReadToEnd();
			int num = string_0.IndexOf(Class333.smethod_2578());
			if (num != -1)
			{
				string_0 = string_0.Substring(0, num);
			}
			method_0();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_2579() + ex.Message);
		}
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

	private void class148_0_CheckedChanged(object sender, EventArgs e)
	{
		if (class148_0.Checked)
		{
			themedButton_0.Enabled = true;
			themedButton_1.Enabled = true;
		}
		else
		{
			themedButton_0.Enabled = false;
			themedButton_1.Enabled = false;
		}
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		new Form15().ShowDialog(this);
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
		class134_0 = new Class134();
		label_0 = new Label();
		label_1 = new Label();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		themedButton_2 = new ThemedButton();
		class148_0 = new Class148();
		linkLabel_0 = new LinkLabel();
		SuspendLayout();
		class134_0.BorderStyle = BorderStyle.None;
		class134_0.Font = new Font(Class333.smethod_145(), 8.25f);
		class134_0.Location = new Point(14, 63);
		class134_0.Name = Class333.smethod_714();
		class134_0.ReadOnly = true;
		class134_0.ScrollBars = RichTextBoxScrollBars.Vertical;
		class134_0.Size = new Size(367, 186);
		class134_0.TabIndex = 3;
		class134_0.Text = Class333.smethod_102();
		class134_0.LinkClicked += class134_0_LinkClicked;
		label_0.Location = new Point(12, 9);
		label_0.Name = Class333.smethod_625();
		label_0.Size = new Size(369, 38);
		label_0.TabIndex = 7;
		label_0.Text = Class333.smethod_2580();
		label_1.AutoSize = true;
		label_1.Location = new Point(14, 47);
		label_1.Name = Class333.smethod_618();
		label_1.Size = new Size(80, 13);
		label_1.TabIndex = 8;
		label_1.Text = Class333.smethod_2581();
		themedButton_0.DialogResult = DialogResult.Yes;
		themedButton_0.Enabled = false;
		themedButton_0.Location = new Point(14, 321);
		themedButton_0.Name = Class333.smethod_2582();
		themedButton_0.Size = new Size(90, 25);
		themedButton_0.TabIndex = 0;
		themedButton_0.Text = Class333.smethod_2583();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.No;
		themedButton_1.Enabled = false;
		themedButton_1.Location = new Point(124, 321);
		themedButton_1.Name = Class333.smethod_2584();
		themedButton_1.Size = new Size(160, 25);
		themedButton_1.TabIndex = 1;
		themedButton_1.Text = Class333.smethod_2585();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_2.DialogResult = DialogResult.Cancel;
		themedButton_2.Location = new Point(301, 321);
		themedButton_2.Name = Class333.smethod_830();
		themedButton_2.Size = new Size(80, 25);
		themedButton_2.TabIndex = 2;
		themedButton_2.Text = Class333.smethod_823();
		themedButton_2.UseVisualStyleBackColor = true;
		class148_0.Enabled = false;
		class148_0.Location = new Point(15, 289);
		class148_0.Name = Class333.smethod_2586();
		class148_0.Size = new Size(366, 26);
		class148_0.TabIndex = 9;
		class148_0.Text = Class333.smethod_2587();
		class148_0.TextAlign = ContentAlignment.TopLeft;
		class148_0.UseVisualStyleBackColor = true;
		class148_0.Visible = false;
		class148_0.CheckedChanged += class148_0_CheckedChanged;
		linkLabel_0.Enabled = false;
		linkLabel_0.LinkArea = new LinkArea(4, 4);
		linkLabel_0.Location = new Point(15, 253);
		linkLabel_0.Name = Class333.smethod_2588();
		linkLabel_0.Size = new Size(366, 40);
		linkLabel_0.TabIndex = 10;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class333.smethod_2589();
		linkLabel_0.UseCompatibleTextRendering = true;
		linkLabel_0.Visible = false;
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_2;
		ClientSize = new Size(393, 355);
		Controls.Add(linkLabel_0);
		Controls.Add(class148_0);
		Controls.Add(themedButton_2);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(class134_0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2590();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2591();
		Shown += Form49_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
