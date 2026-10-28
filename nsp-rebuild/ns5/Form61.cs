using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns4;
using ns7;

namespace ns5;

internal class Form61 : Form
{
	private Framework aBT;

	private string aBt;

	private IContainer aBU;

	private ThemedButton aBu;

	private ThemedButton aBV;

	private ThemedTextBox aBv;

	private Label aBW;

	internal Form61(Framework framework_0)
	{
		method_0();
		aBT = framework_0;
	}

	private void Form61_Shown(object sender, EventArgs e)
	{
		BackColor = Form23.color_10;
		aBW.ForeColor = Form23.color_12;
		aBv.BackColor = Form23.color_32;
		aBv.ForeColor = Form23.color_12;
		aBv.Focus();
		string text = Form23.smethod_98(aBT.aXc);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = new DirectoryInfo(text).Name;
			int num = text2.IndexOf('_');
			if (num != -1)
			{
				text2 = text2.Substring(0, num);
			}
			if (!string.IsNullOrEmpty(text2) && Form54.smethod_6(Form23.form23_0, Class333.aBt() + text2 + Class333.aBU() + text2 + Class333.smethod_2378(), Class333.aBu(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				aBt = text2;
				aBv.Text = text2;
			}
		}
	}

	private void Form61_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		if ((!string.IsNullOrEmpty(aBt) && aBv.Text == aBt) || Form23.smethod_102(string.Empty, aBv.Text, aBT))
		{
			aBT.method_31(1501).method_262(aBv.Text, bool_0: true);
			Form23.smethod_74(1501);
			return;
		}
		if (!string.IsNullOrWhiteSpace(aBv.Text))
		{
			Form54.smethod_6(this, Class333.aBV(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		e.Cancel = true;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aBU != null)
		{
			aBU.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form61));
		aBu = new ThemedButton();
		aBV = new ThemedButton();
		aBv = new ThemedTextBox();
		aBW = new Label();
		SuspendLayout();
		aBu.DialogResult = DialogResult.OK;
		componentResourceManager.ApplyResources(aBu, Class333.smethod_829());
		aBu.Name = Class333.smethod_829();
		aBu.UseVisualStyleBackColor = true;
		aBV.DialogResult = DialogResult.Cancel;
		componentResourceManager.ApplyResources(aBV, Class333.smethod_830());
		aBV.Name = Class333.smethod_830();
		aBV.UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(aBv, Class333.aBv());
		aBv.Name = Class333.aBv();
		componentResourceManager.ApplyResources(aBW, Class333.smethod_2195());
		aBW.Name = Class333.smethod_2195();
		AcceptButton = aBu;
		componentResourceManager.ApplyResources(this, Class333.smethod_608());
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = aBV;
		Controls.Add(aBu);
		Controls.Add(aBV);
		Controls.Add(aBv);
		Controls.Add(aBW);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aBW();
		ShowInTaskbar = false;
		FormClosing += Form61_FormClosing;
		Shown += Form61_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
