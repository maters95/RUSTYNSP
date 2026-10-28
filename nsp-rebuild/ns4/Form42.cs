using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns7;

namespace ns4;

internal class Form42 : Form
{
	private static readonly string string_0 = Form23.string_3 + Class333.smethod_2416();

	private IContainer icontainer_0;

	private Class148 class148_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_0;

	private Label label_1;

	internal Form42(MenuNode menuNode_0)
	{
		method_0();
		if (menuNode_0.method_1() != null && menuNode_0.method_1().method_33(menuNode_0.method_3()) is Table)
		{
			label_0.Text = Class333.smethod_2409();
		}
		else
		{
			label_0.Text = Class333.smethod_2410();
		}
		label_1.Text = Class333.smethod_1394() + menuNode_0.method_100(menuNode_0.method_5() == null, bool_1: false) + Class333.smethod_1394();
		BackColor = Form23.color_10;
		class148_0.ForeColor = Form23.color_12;
		label_0.ForeColor = Form23.color_12;
		label_1.ForeColor = Form23.color_12;
	}

	private void Form42_Shown(object sender, EventArgs e)
	{
		class148_0.Checked = false;
		themedButton_0.Focus();
	}

	private void Form42_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult == DialogResult.OK && class148_0.Checked)
		{
			if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
			{
				Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
			}
			else if (!File.Exists(string_0))
			{
				File.Create(string_0).Close();
			}
			List<string> list = new List<string>();
			list.Add(Class333.smethod_2411() + class148_0.Checked);
			File.AppendAllLines(string_0, list);
		}
	}

	internal static bool smethod_0()
	{
		if (File.Exists(string_0))
		{
			using StreamReader streamReader = File.OpenText(string_0);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.smethod_2411()) && bool.Parse(text.Substring(Class333.smethod_2411().Length)))
				{
					return true;
				}
			}
		}
		return false;
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
		class148_0 = new Class148();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_0 = new Label();
		label_1 = new Label();
		SuspendLayout();
		class148_0.AutoSize = true;
		class148_0.Location = new Point(27, 59);
		class148_0.Name = Class333.smethod_1079();
		class148_0.Size = new Size(212, 17);
		class148_0.TabIndex = 2;
		class148_0.Text = Class333.smethod_1075();
		class148_0.UseVisualStyleBackColor = true;
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(266, 52);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(102, 30);
		themedButton_0.TabIndex = 0;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(383, 52);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(103, 30);
		themedButton_1.TabIndex = 1;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		label_0.AutoSize = true;
		label_0.Location = new Point(8, 9);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(491, 13);
		label_0.TabIndex = 7;
		label_0.Text = Class333.smethod_2410();
		label_1.AutoSize = true;
		label_1.Location = new Point(8, 31);
		label_1.Name = Class333.smethod_2412();
		label_1.Size = new Size(491, 13);
		label_1.TabIndex = 8;
		label_1.Text = Class333.smethod_2413();
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(506, 94);
		ControlBox = false;
		Controls.Add(label_0);
		Controls.Add(label_1);
		Controls.Add(class148_0);
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2414();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2415();
		FormClosing += Form42_FormClosing;
		Shown += Form42_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
