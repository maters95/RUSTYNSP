using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns5;
using ns7;

namespace ns2;

internal class Control10 : UserControl
{
	private delegate void Delegate55(object sender, EventArgs e);

	private delegate void Delegate56(object sender, EventArgs e);

	private delegate void Delegate57(object sender, EventArgs e);

	private Framework framework_0;

	private Setting setting_0;

	private Label label_0 = new Label();

	private string string_0 = string.Empty;

	private bool bool_0 = true;

	private float float_0 = 1f;

	internal Control10(int int_0, bool bool_1, Framework framework_1, float float_1 = 1f)
	{
		method_0(int_0, bool_1, framework_1, float_1);
	}

	private void method_0(int int_0, bool bool_1, Framework framework_1, float float_1)
	{
		framework_0 = framework_1;
		bool_0 = bool_1;
		float_0 = float_1;
		setting_0 = framework_0.method_31(int_0);
		setting_0.method_264(method_3);
		setting_0.method_40(method_2);
		Class1.smethod_12(method_4);
		Form23.smethod_30(method_4);
		label_0.Font = new Font(label_0.Font.FontFamily, 8.25f * float_0);
		label_0.ForeColor = Form23.color_12;
		label_0.AutoSize = false;
		if (bool_0)
		{
			if (float_0 < 1.1f)
			{
				label_0.Width = 350;
			}
			else
			{
				label_0.Width = 490;
			}
		}
		else
		{
			label_0.Width = 170;
		}
		label_0.Height = (int)(17f * float_0);
		label_0.Left = 0;
		label_0.Top = 5;
		Controls.Add(label_0);
		method_1();
		AutoSize = false;
		Height = label_0.Height + 10;
		Width = label_0.Width;
	}

	private void method_1()
	{
		Visible = setting_0.method_35() && PortFunction.smethod_52(setting_0);
		if (!Visible)
		{
			return;
		}
		if (bool_0)
		{
			string text = setting_0.method_60(Enum96.aYt);
			int int_ = setting_0.method_231();
			string text2 = Class333.smethod_325() + Class233.smethod_35(setting_0.method_232(), int_, bool_0: false, 0);
			int num = TextRenderer.MeasureText(text + Class333.smethod_610() + text2, label_0.Font).Width;
			List<Setting.ListItems.Struct45> list = setting_0.method_102();
			if (list.Count != 0)
			{
				int val = 0;
				for (int i = 0; i < list.Count; i++)
				{
					val = Math.Max(TextRenderer.MeasureText(text + Class333.smethod_611() + list[i].bBV, label_0.Font).Width, val);
				}
				num = Math.Max(num, val);
			}
			if (num < label_0.Width - 20)
			{
				string_0 = text;
			}
			else
			{
				string_0 = setting_0.method_60(Enum96.aYT);
			}
		}
		else
		{
			string_0 = string.Empty;
		}
		method_5();
	}

	private void method_2(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate55 method = method_2;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_1();
	}

	private void method_3(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate56 method = method_3;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_5();
	}

	private void method_4(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate57 method = method_4;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_5();
	}

	private void method_5()
	{
		string text = (string.IsNullOrEmpty(string_0) ? string.Empty : (string_0 + Class333.smethod_611()));
		if (Form23.smethod_28(framework_0.aXc, bool_53: true) && !Form23.smethod_80())
		{
			(string, string, bool) tuple = setting_0.method_252();
			text = text + tuple.Item1 + Class333.smethod_325() + tuple.Item2;
		}
		else
		{
			text += Class333.smethod_612();
		}
		label_0.Text = text;
	}

	private void method_6()
	{
		try
		{
			setting_0.method_265(method_3);
			setting_0.method_41(method_2);
			Class1.smethod_13(method_4);
			Form23.smethod_31(method_4);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_6();
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
