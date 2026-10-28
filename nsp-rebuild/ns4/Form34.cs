using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns7;

namespace ns4;

internal class Form34 : Form
{
	private static readonly string string_0 = Form23.string_3 + Class333.smethod_2202();

	private IContainer icontainer_0;

	private Class148 class148_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_0;

	internal Form34()
	{
		method_0();
		BackColor = Form23.color_10;
		label_0.ForeColor = Form23.color_12;
		class148_0.ForeColor = Form23.color_12;
	}

	private void Form34_FormClosing(object sender, FormClosingEventArgs e)
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
			list.Add(Class333.smethod_2198() + class148_0.Checked);
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
				if (text.StartsWith(Class333.smethod_2198()))
				{
					return bool.Parse(text.Substring(Class333.smethod_2198().Length));
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form34));
		class148_0 = new Class148();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_0 = new Label();
		SuspendLayout();
		class148_0.AutoSize = true;
		class148_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class148_0.Location = new Point(15, 66);
		class148_0.Name = Class333.smethod_1079();
		class148_0.Size = new Size(212, 17);
		class148_0.TabIndex = 4;
		class148_0.Text = Class333.smethod_1075();
		class148_0.UseVisualStyleBackColor = true;
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_0.Location = new Point(256, 59);
		themedButton_0.Name = Class333.smethod_859();
		themedButton_0.Size = new Size(75, 30);
		themedButton_0.TabIndex = 6;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_1.Location = new Point(337, 59);
		themedButton_1.Name = Class333.smethod_857();
		themedButton_1.Size = new Size(75, 30);
		themedButton_1.TabIndex = 5;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		label_0.AutoSize = true;
		label_0.Location = new Point(12, 9);
		label_0.MaximumSize = new Size(400, 0);
		label_0.MinimumSize = new Size(400, 0);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(400, 39);
		label_0.TabIndex = 7;
		label_0.Text = componentResourceManager.GetString(Class333.smethod_2199());
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(424, 101);
		ControlBox = false;
		Controls.Add(label_0);
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Controls.Add(class148_0);
		Font = new Font(Class333.smethod_145(), 8.25f);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2200();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2201();
		FormClosing += Form34_FormClosing;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
