using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns3;
using ns6;
using ns7;

namespace ns4;

internal class Form47 : Form
{
	private delegate void Delegate115(object sender, ElapsedEventArgs e);

	private delegate void Delegate116(object sender, EventArgs e);

	private Framework framework_0;

	private ThemedButton themedButton_0 = new ThemedButton();

	private ThemedButton themedButton_1 = new ThemedButton();

	private ProgressBar progressBar_0 = new ProgressBar();

	private int int_0 = -1;

	internal static MenuNode menuNode_0 = null;

	private System.Timers.Timer timer_0 = new System.Timers.Timer();

	private static object object_0 = new object();

	private IContainer icontainer_0;

	internal Form47()
	{
		method_7();
		themedButton_0.Text = Class333.smethod_2551();
		themedButton_0.AutoSize = false;
		themedButton_0.Width = 100;
		themedButton_0.Height = 25;
		themedButton_0.Left = 5;
		themedButton_0.Top = ClientRectangle.Height - 5 - themedButton_0.Height;
		Controls.Add(themedButton_0);
		themedButton_0.Click += themedButton_0_Click;
		themedButton_1.AutoSize = false;
		themedButton_1.Width = 100;
		themedButton_1.Height = 25;
		themedButton_1.Left = ClientRectangle.Width - 5 - themedButton_1.Width;
		themedButton_1.Top = ClientRectangle.Height - 5 - themedButton_1.Height;
		Controls.Add(themedButton_1);
		themedButton_1.Click += themedButton_1_Click;
		progressBar_0.Minimum = 0;
		progressBar_0.Width = themedButton_1.Left - 70 - (themedButton_0.Right + 70);
		progressBar_0.Height = 10;
		progressBar_0.Left = themedButton_0.Right + 70;
		progressBar_0.Top = ClientRectangle.Height - 22;
		Controls.Add(progressBar_0);
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		int_0 = method_5();
		method_6();
		Form23.smethod_7(method_0);
		Form23.smethod_78(method_3);
		timer_0.Interval = 200.0;
		timer_0.SynchronizingObject = this;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.Start();
	}

	private void Form47_Shown(object sender, EventArgs e)
	{
		Form23.smethod_49(null, null);
		Form23.smethod_8(method_0);
		Form23.smethod_7(method_0);
		Form23.smethod_79(method_3);
		Form23.smethod_78(method_3);
		timer_0.Elapsed -= timer_0_Elapsed;
		timer_0.Elapsed += timer_0_Elapsed;
		method_6();
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void Form47_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.smethod_8(method_0);
		Form23.smethod_79(method_3);
		timer_0.Elapsed -= timer_0_Elapsed;
		menuNode_0 = null;
		Form23.smethod_49(null, null);
	}

	private void Form47_VisibleChanged(object sender, EventArgs e)
	{
		if (!Visible)
		{
			Form23.smethod_8(method_0);
			Form23.smethod_79(method_3);
			timer_0.Elapsed -= timer_0_Elapsed;
			menuNode_0 = null;
		}
		Form23.smethod_49(null, null);
	}

	[SpecialName]
	internal static bool smethod_0()
	{
		return menuNode_0 != null;
	}

	[SpecialName]
	internal Framework method_1()
	{
		return framework_0;
	}

	[SpecialName]
	internal void method_2(Framework framework_1)
	{
		framework_0 = framework_1;
		if (framework_0 != null)
		{
			Text = framework_0.awm.method_10();
			progressBar_0.Maximum = framework_0.awm.method_6().Count;
			if (int_0 == -1)
			{
				int_0 = method_5();
			}
			method_6();
		}
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (framework_0 == null)
		{
			return;
		}
		if (InvokeRequired)
		{
			try
			{
				Delegate115 method = timer_0_Elapsed;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(object_0, ref lockTaken);
			if (!lockTaken)
			{
				return;
			}
			foreach (Class258 value in framework_0.awn.Values)
			{
				value.method_5();
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(object_0);
			}
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate116 method = method_3;
				BeginInvoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_6();
	}

	private int method_4()
	{
		if (framework_0 != null)
		{
			int num = int_0 - 1;
			while (num >= 0)
			{
				if (framework_0.awm.method_6()[num].method_101(bool_0: true) && !MenuNode.smethod_0(framework_0.awm.method_6()[num]))
				{
					num--;
					continue;
				}
				return num;
			}
		}
		return int_0;
	}

	private int method_5()
	{
		if (framework_0 != null)
		{
			for (int i = int_0 + 1; i < framework_0.awm.method_6().Count; i++)
			{
				if (!framework_0.awm.method_6()[i].method_101(bool_0: true) || MenuNode.smethod_0(framework_0.awm.method_6()[i]))
				{
					return i;
				}
			}
		}
		return int_0;
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		int num = int_0;
		int_0 = method_4();
		if (int_0 < num)
		{
			method_6();
		}
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		int num = int_0;
		int_0 = method_5();
		if (int_0 > num)
		{
			method_6();
		}
		else
		{
			Hide();
		}
	}

	private void method_6()
	{
		if (int_0 < 0)
		{
			return;
		}
		if (int_0 <= progressBar_0.Maximum)
		{
			progressBar_0.Value = int_0;
		}
		SuspendLayout();
		while (Controls.Count > 3)
		{
			foreach (Control control in Controls)
			{
				if (control != themedButton_0 && control != themedButton_1 && control != progressBar_0)
				{
					control.Dispose();
					break;
				}
			}
		}
		ResumeLayout(performLayout: true);
		if (framework_0 == null || framework_0.awm.method_6().Count <= int_0)
		{
			return;
		}
		SuspendLayout();
		if (int_0 == method_5())
		{
			themedButton_1.Text = Class333.smethod_2552();
		}
		else
		{
			themedButton_1.Text = Class333.smethod_2553();
		}
		MenuNode menuNode = (menuNode_0 = framework_0.awm.method_6()[int_0]);
		if (Form23.smethod_80())
		{
			Label label = new Label();
			label.Text = Class333.smethod_2554();
			label.ForeColor = Form23.color_7;
			label.Font = new Font(label.Font.FontFamily, 8f, FontStyle.Bold);
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = 20;
			label.Top = 20;
			Controls.Add(label);
			Label label2 = new Label();
			label2.Text = Class333.smethod_2555();
			label2.ForeColor = Form23.color_7;
			label2.Font = new Font(label2.Font.FontFamily, 8f, FontStyle.Bold);
			label2.BackColor = Color.Transparent;
			label2.AutoSize = true;
			label2.Left = 20;
			label2.Top = 50;
			Controls.Add(label2);
			themedButton_0.Enabled = false;
			themedButton_1.Enabled = false;
		}
		else
		{
			string text = menuNode.method_8();
			int num = menuNode.method_3();
			SettingOrSpecialObject settingOrSpecialObject = framework_0.method_33(num);
			Rectangle rectangle_ = new Rectangle(5, 5, ClientRectangle.Width - 10, ClientRectangle.Height - 15 - themedButton_0.Height);
			if (!string.IsNullOrEmpty(text))
			{
				if (framework_0.awn.ContainsKey(text))
				{
					Class112 @class = new Class112(framework_0.awn[text], framework_0, rectangle_, bool_0: false, bool_1: false, 2f);
					Controls.Add(@class);
					@class.method_16(bool_0: true);
				}
			}
			else if (settingOrSpecialObject != null)
			{
				Interface4 @interface = settingOrSpecialObject.method_11();
				if (@interface != null)
				{
					if (@interface is UIListObject)
					{
						Class117 class2 = new Class117(settingOrSpecialObject as SpecialObject, string.Empty, menuNode, framework_0, null, rectangle_, bool_0: false, bool_1: false, 2f);
						Controls.Add(class2);
						class2.method_15(bool_0: true);
					}
					else if (@interface is StateMachine)
					{
						Class116 class3 = new Class116(settingOrSpecialObject as StateMachine, framework_0, null, rectangle_, bool_0: false);
						Controls.Add(class3);
						class3.method_17();
					}
				}
				else if (settingOrSpecialObject.method_1().Count != 0)
				{
					Class117 class4 = new Class117(settingOrSpecialObject as SpecialObject, string.Empty, menuNode, framework_0, null, rectangle_, bool_0: false, bool_1: false, 2f);
					Controls.Add(class4);
					class4.method_15(bool_0: true);
				}
			}
			else
			{
				foreach (MenuNode item in menuNode.method_6())
				{
					if (item.method_28())
					{
						Class118 class5 = new Class118(framework_0, null, rectangle_, bool_0: false, bool_1: false, bool_2: false, 2f);
						class5.method_15(menuNode);
						Controls.Add(class5);
						class5.method_21(bool_0: true);
						break;
					}
				}
			}
			themedButton_0.Enabled = method_4() < int_0;
			themedButton_1.Enabled = true;
		}
		ResumeLayout(performLayout: true);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return Class30.smethod_4(this, keyData);
	}

	protected override void Dispose(bool disposing)
	{
		themedButton_0.Click -= themedButton_0_Click;
		themedButton_1.Click -= themedButton_1_Click;
		Form23.smethod_79(method_3);
		timer_0.Elapsed -= timer_0_Elapsed;
		timer_0.Stop();
		timer_0.Dispose();
		menuNode_0 = null;
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_7()
	{
		SuspendLayout();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(604, 641);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2556();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.Manual;
		Text = Class333.smethod_1567();
		FormClosing += Form47_FormClosing;
		Shown += Form47_Shown;
		VisibleChanged += Form47_VisibleChanged;
		ResumeLayout(performLayout: false);
	}
}
