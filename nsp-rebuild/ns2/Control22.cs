using System;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns5;

namespace ns2;

internal class Control22 : UserControl
{
	private delegate void Delegate73(object sender, EventArgs e);

	private Framework framework_0;

	private SettingOrSpecialObject settingOrSpecialObject_0;

	private SettingWriteTaskObject settingWriteTaskObject_0;

	private ThemedButton themedButton_0 = new ThemedButton();

	internal Control22(SettingOrSpecialObject settingOrSpecialObject_1, SettingWriteTaskObject settingWriteTaskObject_1, Framework framework_1)
	{
		settingOrSpecialObject_0 = settingOrSpecialObject_1;
		settingWriteTaskObject_0 = settingWriteTaskObject_1;
		framework_0 = framework_1;
		settingOrSpecialObject_0.method_40(method_1);
		string text = settingOrSpecialObject_0.method_60(Enum96.aYu);
		if (text != null)
		{
			themedButton_0.Text = text;
		}
		themedButton_0.Left = 0;
		themedButton_0.Top = 0;
		themedButton_0.AutoSize = true;
		themedButton_0.Click += themedButton_0_Click;
		method_0();
		Controls.Add(themedButton_0);
		AutoSize = false;
		Height = themedButton_0.Height;
		Width = themedButton_0.Width;
	}

	private void method_0()
	{
		themedButton_0.Enabled = settingOrSpecialObject_0.method_35() && framework_0.method_4();
		TabStop = themedButton_0.Enabled;
		themedButton_0.TabStop = TabStop;
	}

	private void method_1(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate73 method = method_1;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_0();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			foreach (Control control in Controls)
			{
				if (control is Button)
				{
					(control as Button).Click -= themedButton_0_Click;
				}
			}
			settingOrSpecialObject_0.method_41(method_1);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		settingWriteTaskObject_0.method_6();
	}
}
