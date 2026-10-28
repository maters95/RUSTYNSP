using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.UserInterface;
using ns7;

namespace ns4;

internal class Form33 : Form
{
	private float float_0;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private ThemedTextBox themedTextBox_0;

	private Label label_0;

	private Label label_1;

	internal Form33()
	{
		method_1();
	}

	[SpecialName]
	internal float method_0()
	{
		return float_0;
	}

	private void Form33_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult == DialogResult.OK && !float.TryParse(themedTextBox_0.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out float_0))
		{
			e.Cancel = true;
		}
	}

	private void Form33_VisibleChanged(object sender, EventArgs e)
	{
		themedTextBox_0.Text = Class333.smethod_184();
		themedTextBox_0.SelectAll();
	}

	private void Form33_Shown(object sender, EventArgs e)
	{
		BackColor = Form23.color_10;
		label_0.ForeColor = Form23.color_12;
		label_1.ForeColor = Form23.color_12;
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		themedTextBox_0.Focus();
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form33));
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		themedTextBox_0 = new ThemedTextBox();
		label_0 = new Label();
		label_1 = new Label();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.OK;
		componentResourceManager.ApplyResources(themedButton_0, Class333.smethod_829());
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		componentResourceManager.ApplyResources(themedButton_1, Class333.smethod_830());
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(themedTextBox_0, Class333.smethod_1059());
		themedTextBox_0.Name = Class333.smethod_1059();
		componentResourceManager.ApplyResources(label_0, Class333.smethod_2195());
		label_0.Name = Class333.smethod_2195();
		componentResourceManager.ApplyResources(label_1, Class333.smethod_2196());
		label_1.Name = Class333.smethod_2196();
		AcceptButton = themedButton_0;
		componentResourceManager.ApplyResources(this, Class333.smethod_608());
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		Controls.Add(label_1);
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedTextBox_0);
		Controls.Add(label_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2197();
		ShowInTaskbar = false;
		FormClosing += Form33_FormClosing;
		Shown += Form33_Shown;
		VisibleChanged += Form33_VisibleChanged;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
