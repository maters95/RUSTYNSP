using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns1;
using ns4;
using ns7;

namespace ns3;

internal class Class121 : Class109
{
	private Rectangle BxO;

	internal Class121(Rectangle rectangle_0, bool bool_0, bool bool_1)
		: base(rectangle_0, bool_0, bool_1)
	{
		BxO = rectangle_0;
	}

	internal void method_15(bool bool_0)
	{
		SuspendLayout();
		method_12().SuspendLayout();
		int left = 5;
		int num = 5;
		Label label = new Label();
		label.Text = Class333.smethod_1195();
		label.ForeColor = Form23.color_14;
		label.Font = new Font(label.Font.FontFamily, 8f, FontStyle.Bold);
		label.BackColor = Color.Transparent;
		label.AutoSize = true;
		label.Left = 5;
		label.Top = 5;
		num = label.Bottom + 10;
		if (bool_0)
		{
			method_12().Controls.Add(label);
		}
		else
		{
			label.Dispose();
		}
		List<int> list = new List<int>();
		list.Add(1501);
		list.Add(1502);
		list.Add(3800);
		for (int i = 0; i < list.Count; i++)
		{
			Setting setting = Form23.framework_1.method_31(list[i]);
			if (setting == null || setting.method_219() || setting.method_212() || setting.method_220())
			{
				continue;
			}
			if (setting.method_154())
			{
				Control15 control = new Control15(setting.method_69(), Form23.framework_1, Form23.framework_0, null, bool_2: false);
				control.Left = left;
				control.Top = num - 3;
				num = control.Bottom + 2;
				if (bool_0)
				{
					method_12().Controls.Add(control);
				}
				else
				{
					control.Dispose();
				}
			}
			else if (setting.method_103().Count != 0)
			{
				Control17 control2 = new Control17(setting.method_69(), Form23.framework_1, Form23.framework_0, null, bool_2: false, bool_3: true, bool_4: false);
				control2.Left = left;
				control2.Top = num;
				num = control2.Bottom + 7;
				if (bool_0)
				{
					method_12().Controls.Add(control2);
				}
				else
				{
					control2.Dispose();
				}
			}
			else
			{
				Control21 control3 = new Control21(setting.method_69(), Form23.framework_1, Form23.framework_0, null, bool_2: false, bool_3: false, bool_4: false);
				control3.Left = left;
				control3.Top = num;
				num = control3.Bottom + 7;
				if (bool_0)
				{
					method_12().Controls.Add(control3);
				}
				else
				{
					control3.Dispose();
				}
			}
		}
		method_16();
		if (bool_0)
		{
			if (BxO != Rectangle.Empty)
			{
				Width = BxO.Width;
				Height = BxO.Height;
				Left = BxO.Left;
				Top = BxO.Top;
			}
			else
			{
				int num2 = 0;
				int num3 = 0;
				foreach (Control control4 in method_12().Controls)
				{
					num2 = Math.Max(num2, control4.Right + 10);
					num3 = Math.Max(num3, control4.Bottom + 10);
				}
				Width = num2;
				Height = num3;
			}
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
	}

	private void method_16()
	{
		int num = int.MinValue;
		int num2 = int.MaxValue;
		foreach (Control control5 in method_12().Controls)
		{
			if (control5 is Control17)
			{
				Control17 control2 = (Control17)control5;
				if (control2.method_2() > num)
				{
					num = control2.method_2();
				}
				if (control2.method_2() < num2)
				{
					num2 = control2.method_2();
				}
			}
			else if (control5 is Control21)
			{
				Control21 control3 = (Control21)control5;
				if (control3.method_8() > num)
				{
					num = control3.method_8();
				}
				if (control3.method_8() < num2)
				{
					num2 = control3.method_8();
				}
			}
		}
		if (num2 == num || num == int.MinValue)
		{
			return;
		}
		foreach (Control control6 in method_12().Controls)
		{
			if (control6 is Control17)
			{
				((Control17)control6).method_6(num);
			}
			else if (control6 is Control21)
			{
				((Control21)control6).method_12(num);
			}
		}
	}
}
