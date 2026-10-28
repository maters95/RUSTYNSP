using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns4;
using ns5;
using ns7;

namespace ns2;

internal class Control8 : UserControl
{
	private int int_0;

	private Framework framework_0;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private Label label_0;

	private TableLayoutPanel tableLayoutPanel_0;

	public Control8()
	{
		method_6();
		method_1();
	}

	[SpecialName]
	internal void method_0(Framework framework_1)
	{
		framework_0 = framework_1;
		if (framework_0 != null && !framework_0.method_4())
		{
			Enabled = false;
		}
	}

	protected override void OnEnabledChanged(EventArgs eventArgs_0)
	{
		base.OnEnabledChanged(eventArgs_0);
		method_1();
	}

	internal void method_1()
	{
		if (Enabled)
		{
			if (framework_0 != null)
			{
				Setting setting = framework_0.method_31(int_0);
				if (setting != null && setting.method_35() && PortFunction.smethod_52(setting))
				{
					label_0.BackColor = Form23.color_32;
				}
				else
				{
					label_0.BackColor = Color.Red;
				}
			}
			else
			{
				label_0.BackColor = Form23.color_32;
			}
			label_0.ForeColor = Form23.color_12;
		}
		else
		{
			label_0.BackColor = Form23.color_35;
			label_0.ForeColor = Form23.color_36;
		}
	}

	private void label_0_Paint(object sender, PaintEventArgs e)
	{
		if (!label_0.Enabled)
		{
			TextRenderer.DrawText(e.Graphics, label_0.Text, label_0.Font, new Point(0, 3), Form23.color_36, Form23.color_35);
		}
	}

	[SpecialName]
	internal void method_2(int int_1)
	{
		if (int_0 == int_1)
		{
			return;
		}
		int_0 = int_1;
		if (int_0 != 0)
		{
			Setting setting = framework_0.method_31(int_0);
			if (setting != null)
			{
				string text = setting.method_18();
				if (!string.IsNullOrWhiteSpace(text))
				{
					label_0.Text = text;
				}
				else
				{
					string text2 = setting.method_60(Enum96.aYt);
					if (text2.Length <= 25)
					{
						label_0.Text = text2;
					}
					else
					{
						label_0.Text = setting.method_60(Enum96.aYT);
					}
				}
			}
			else
			{
				label_0.Text = string.Empty;
			}
		}
		else
		{
			label_0.Text = string.Empty;
		}
		method_1();
	}

	[SpecialName]
	internal int method_3()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_4(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		int num = Form44.smethod_0(ParentForm, framework_0, int_0);
		if (num != 0)
		{
			method_2(num);
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, null);
			}
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

	private void method_6()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Control8));
		label_0 = new Label();
		tableLayoutPanel_0 = new TableLayoutPanel();
		themedButton_0 = new ThemedButton();
		tableLayoutPanel_0.SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(label_0, Class333.smethod_606());
		label_0.Font = new Font(Class333.smethod_145(), 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.BackColor = SystemColors.Window;
		label_0.BorderStyle = BorderStyle.FixedSingle;
		label_0.Name = Class333.smethod_606();
		label_0.Click += themedButton_0_Click;
		label_0.Paint += label_0_Paint;
		componentResourceManager.ApplyResources(tableLayoutPanel_0, Class333.smethod_249());
		tableLayoutPanel_0.Controls.Add(label_0, 0, 0);
		tableLayoutPanel_0.Controls.Add(themedButton_0, 1, 0);
		tableLayoutPanel_0.Name = Class333.smethod_249();
		componentResourceManager.ApplyResources(themedButton_0, Class333.smethod_607());
		themedButton_0.Font = new Font(Class333.smethod_145(), 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_0.Name = Class333.smethod_607();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		componentResourceManager.ApplyResources(this, Class333.smethod_608());
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(tableLayoutPanel_0);
		Font = new Font(Class333.smethod_145(), 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Name = Class333.smethod_609();
		tableLayoutPanel_0.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
