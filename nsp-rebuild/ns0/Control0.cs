using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns0;

internal class Control0 : UserControl
{
	internal enum Enum22
	{
		BhF = -1,
		Bhf,
		BhG,
		Bhg,
		BhH,
		Bhh,
		BhI
	}

	private delegate void Delegate10(object sender, EventArgs e);

	private delegate void Delegate11(object sender, EventArgs e);

	private delegate void Delegate12(object sender, EventArgs e);

	private const int int_0 = 5;

	private const int int_1 = 20;

	private const int int_2 = 10;

	private const int int_3 = 3;

	private List<SpecialObject> list_0 = new List<SpecialObject>();

	private Setting setting_0;

	private Framework framework_0;

	private MenuNode menuNode_0;

	private bool bool_0;

	[SpecialName]
	private int method_0()
	{
		return TextRenderer.MeasureText(Class333.smethod_329(), new Font(Font.FontFamily, 10f, FontStyle.Bold)).Width;
	}

	[SpecialName]
	private int method_1()
	{
		int num = 4;
		if (bool_0 && setting_0 != null)
		{
			num += 2;
		}
		return TextRenderer.MeasureText(Class333.smethod_330(), new Font(Font.FontFamily, 10f, FontStyle.Bold)).Height * num + 5 * (num - 1);
	}

	internal Control0(MenuNode menuNode_1, int int_4, Framework framework_1, bool bool_1)
	{
		framework_0 = framework_1;
		setting_0 = framework_0.method_31(int_4);
		menuNode_0 = menuNode_1;
		bool_0 = bool_1;
		if (setting_0 == null)
		{
			bool_0 = false;
		}
		else
		{
			setting_0.method_264(method_6);
		}
		Class1.smethod_12(method_9);
		Form23.smethod_30(method_9);
		Form23.smethod_78(method_9);
		Width = method_0();
		Height = method_1();
		BorderStyle = BorderStyle.None;
	}

	private Setting method_2(SpecialObject specialObject_0)
	{
		Setting setting = framework_0.method_31(specialObject_0.method_69().ChannelSettingId);
		if (setting == null)
		{
			return null;
		}
		return framework_0.method_31(setting.method_256());
	}

	internal void method_3(bool bool_1)
	{
		method_5();
		SuspendLayout();
		int num = 10;
		if (!bool_1)
		{
			if (Controls.ContainsKey(Class333.smethod_331()))
			{
				num += Controls[Class333.smethod_331()].Height + 5;
			}
		}
		else
		{
			Label label = new Label();
			label.Name = Class333.smethod_331();
			label.Text = Class333.smethod_332();
			label.ForeColor = Form23.color_12;
			label.Font = new Font(label.Font.FontFamily, label.Font.Size, FontStyle.Bold);
			label.Left = 5;
			label.Top = num;
			label.Height = 16;
			label.AutoSize = true;
			num += label.Height + 5;
			Controls.Add(label);
		}
		for (int i = 0; i < list_0.Count; i++)
		{
			Label label2 = null;
			foreach (Control control3 in Controls)
			{
				if (control3 is Label && control3.Name.EndsWith(Class333.smethod_333() + i))
				{
					label2 = (Label)control3;
				}
			}
			SpecialObject specialObject = list_0[i];
			Setting setting = method_2(specialObject);
			Setting setting2 = framework_0.method_31(specialObject.method_69().ThresholdSettingId);
			Setting setting3 = framework_0.method_31(specialObject.method_69().OperatorSettingId);
			if (setting == null || setting2 == null || setting3 == null)
			{
				continue;
			}
			if (setting3.method_35() && setting2.method_35() && setting.method_35())
			{
				setting.method_264(method_7);
				string text = setting.method_22(bool_0: true);
				if (text.Length > 20)
				{
					text = setting.method_60(Enum96.aYT);
				}
				Label label3 = new Label();
				label3.Name = Class333.smethod_333() + i;
				label3.ForeColor = Form23.color_12;
				label3.Left = 5;
				label3.Top = num;
				label3.Height = 16;
				label3.AutoSize = true;
				num += label3.Height + 5;
				if (!bool_1)
				{
					if (label2 == null)
					{
						label3.Tag = specialObject;
						label3.Text = text + Class333.smethod_334();
						Controls.Add(label3);
					}
					else
					{
						label2.Text = text + Class333.smethod_334();
						label3.Dispose();
					}
				}
				else
				{
					label3.Tag = specialObject;
					label3.Text = text + Class333.smethod_334();
					Controls.Add(label3);
				}
			}
			else
			{
				label2?.Dispose();
			}
		}
		if (bool_0 && list_0.Count >= 2 && setting_0 != null)
		{
			Label label4 = new Label();
			label4.Name = Class333.smethod_335();
			if (method_4())
			{
				label4.Text = Class333.smethod_325();
			}
			else
			{
				label4.Text = Class333.smethod_336();
			}
			label4.ForeColor = Form23.color_12;
			label4.Font = new Font(label4.Font.FontFamily, label4.Font.Size, FontStyle.Bold);
			label4.Left = 5;
			label4.Top = num;
			label4.Height = 16;
			label4.AutoSize = true;
			num += label4.Height + 5;
			if (bool_1)
			{
				Controls.Add(label4);
			}
			else
			{
				if (Controls.ContainsKey(Class333.smethod_335()))
				{
					Controls[Class333.smethod_335()].Top = label4.Top;
				}
				label4.Dispose();
			}
			Label label5 = new Label();
			label5.Name = Class333.smethod_337();
			label5.Tag = setting_0;
			if (method_4())
			{
				label5.Text = Class333.smethod_325();
			}
			else
			{
				label5.Text = Class333.smethod_338();
			}
			label5.ForeColor = Form23.color_12;
			label5.Left = 5;
			label5.Top = num;
			label5.Height = 16;
			label5.AutoSize = true;
			if (bool_1)
			{
				Controls.Add(label5);
			}
			else
			{
				if (Controls.ContainsKey(Class333.smethod_337()))
				{
					Controls[Class333.smethod_337()].Top = num;
				}
				label5.Dispose();
			}
		}
		else
		{
			foreach (Control control4 in Controls)
			{
				if (control4 is Label)
				{
					Label label6 = (Label)control4;
					if (label6.Name.Contains(Class333.smethod_335()))
					{
						label6.Dispose();
					}
					if (label6.Name.Contains(Class333.smethod_337()))
					{
						label6.Dispose();
					}
				}
			}
		}
		Height = method_1();
		ResumeLayout();
	}

	private bool method_4()
	{
		Setting setting = framework_0.method_31(13);
		if (setting != null)
		{
			return setting.method_256() == 1;
		}
		return false;
	}

	private void method_5()
	{
		list_0.Clear();
		foreach (MenuNode item in menuNode_0.method_6())
		{
			if (!item.method_28())
			{
				continue;
			}
			int num = item.method_3();
			SettingOrSpecialObject settingOrSpecialObject = framework_0.method_33(num);
			if (settingOrSpecialObject != null)
			{
				Interface4 @interface = settingOrSpecialObject.method_11();
				if (@interface != null && @interface is ConditionalActivator)
				{
					list_0.Add(settingOrSpecialObject as SpecialObject);
				}
			}
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate10 method = method_6;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (!(sender is Setting))
		{
			return;
		}
		Label label = null;
		Label label2 = null;
		foreach (Control control in Controls)
		{
			if (!(control is Label))
			{
				continue;
			}
			Label label3 = (Label)control;
			if (label3.Tag is Setting)
			{
				if ((Setting)label3.Tag == setting_0)
				{
					label2 = control as Label;
				}
			}
			else if (label3.Name == Class333.smethod_335())
			{
				label = control as Label;
			}
		}
		if (label == null || label2 == null)
		{
			return;
		}
		if ((Form23.smethod_28(framework_0.aXc, bool_53: true) && !Form23.smethod_80()) || Form23.smethod_84(setting_0.method_64()))
		{
			if (method_4())
			{
				label.Text = Class333.smethod_325();
				label2.Text = Class333.smethod_325();
			}
			else
			{
				(string, string, bool) tuple = setting_0.method_252();
				label.Text = Class333.smethod_336();
				label2.Text = Class333.smethod_339() + tuple.Item1;
			}
		}
		else
		{
			label.Text = Class333.smethod_336();
			label2.Text = Class333.smethod_338();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate11 method = method_7;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (!(sender is Setting))
		{
			return;
		}
		foreach (Control control in Controls)
		{
			if (!(control is Label))
			{
				continue;
			}
			Label label = (Label)control;
			if (!(label.Tag is SpecialObject))
			{
				continue;
			}
			SpecialObject specialObject = label.Tag as SpecialObject;
			Setting setting = method_2(specialObject);
			if (setting == null || setting != sender as Setting)
			{
				continue;
			}
			Setting setting2 = framework_0.method_31(specialObject.method_69().ThresholdSettingId);
			Setting setting3 = framework_0.method_31(specialObject.method_69().OperatorSettingId);
			if (setting2 == null || setting3 == null)
			{
				continue;
			}
			string empty = string.Empty;
			if ((Form23.smethod_28(framework_0.aXc, bool_53: true) && !Form23.smethod_80()) || Form23.smethod_84(setting.method_64()))
			{
				empty = setting.method_22(bool_0: true);
				if (empty.Length > 20)
				{
					empty = setting.method_60(Enum96.aYT);
				}
				empty += Class333.smethod_340();
				int int_ = setting.method_256();
				(string, string, bool) tuple = setting.method_253(int_);
				empty = empty + tuple.Item1 + Class333.smethod_325() + tuple.Item2 + Class333.smethod_341() + method_10(setting2.method_256(), int_, method_8(setting3)).ToString();
				label.Text = empty;
			}
			else
			{
				empty = setting.method_22(bool_0: true);
				if (empty.Length > 20)
				{
					empty = setting.method_60(Enum96.aYT);
				}
				label.Text = empty + Class333.smethod_334();
			}
		}
	}

	private Enum22 method_8(Setting setting_1)
	{
		return (Enum22)setting_1.method_256();
	}

	private void method_9(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate12 method = method_9;
				BeginInvoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.smethod_28(framework_0.aXc, bool_53: true) && !Form23.smethod_80())
		{
			return;
		}
		foreach (Control control in Controls)
		{
			if (!(control is Label))
			{
				continue;
			}
			Label label = (Label)control;
			if (label.Tag is Setting)
			{
				if ((Setting)label.Tag == setting_0)
				{
					label.Text = Class333.smethod_338();
				}
			}
			else if (label.Tag is SpecialObject)
			{
				SpecialObject specialObject_ = (SpecialObject)label.Tag;
				Setting setting = method_2(specialObject_);
				string empty = string.Empty;
				if (setting != null)
				{
					empty = setting.method_22(bool_0: true);
					if (empty.Length > 20)
					{
						empty = setting.method_60(Enum96.aYT);
					}
					label.Text = empty + Class333.smethod_334();
				}
			}
			else if (label.Name == Class333.smethod_335())
			{
				label.Text = Class333.smethod_336();
			}
		}
	}

	internal string method_10(int int_4, int int_5, Enum22 enum22_0)
	{
		string result = Class333.smethod_342();
		switch (enum22_0)
		{
		case Enum22.BhF:
			result = Class333.smethod_343();
			break;
		case Enum22.Bhf:
			if (int_4 == int_5)
			{
				result = Class333.smethod_344();
			}
			break;
		case Enum22.BhG:
			if (int_4 != int_5)
			{
				result = Class333.smethod_344();
			}
			break;
		case Enum22.Bhg:
			if (int_5 > int_4)
			{
				result = Class333.smethod_344();
			}
			break;
		case Enum22.BhH:
			if (int_5 < int_4)
			{
				result = Class333.smethod_344();
			}
			break;
		case Enum22.Bhh:
			if (int_5 >= int_4)
			{
				result = Class333.smethod_344();
			}
			break;
		case Enum22.BhI:
			if (int_5 <= int_4)
			{
				result = Class333.smethod_344();
			}
			break;
		}
		return result;
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		if (BorderStyle != BorderStyle.Fixed3D)
		{
			paintEventArgs_0.Graphics.DrawLine(Pens.Gray, 0, 10, 0, Bottom - 10);
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_11();
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void method_11()
	{
		try
		{
			if (setting_0 != null)
			{
				setting_0.method_265(method_6);
			}
			foreach (SpecialObject item in list_0)
			{
				method_2(item)?.method_265(method_7);
			}
			Class1.smethod_13(method_9);
			Form23.smethod_31(method_9);
			Form23.smethod_79(method_9);
		}
		catch
		{
		}
	}
}
