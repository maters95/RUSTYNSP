using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns2;
using ns4;
using ns6;
using ns7;

namespace ns1;

internal class Control18 : Control11
{
	private delegate void Delegate68(object sender, EventArgs e);

	private delegate void Delegate69(object sender, EventArgs e);

	private Label BNm = new Label();

	private Class136 BNN = new Class136();

	private Class286 BNn;

	private int BNO;

	private bool BNo;

	internal Control18(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0)
	{
		SetStyle(ControlStyles.Selectable, value: true);
		SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
		DoubleBuffered = true;
		method_2(dataIdAndAttrId_1, framework_2, framework_3, class286_0);
	}

	private void method_2(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0)
	{
		vmethod_0(framework_2, framework_3);
		vmethod_1(dataIdAndAttrId_1);
		BNn = class286_0;
		if (BNn != null)
		{
			int[] array = BNn.method_3(setting_0);
			if (array != null && array.Length == 1)
			{
				BNO = array[0];
			}
			else
			{
				BNn = null;
			}
		}
		vmethod_2();
		bool flag = vmethod_3();
		List<Control> list = new List<Control>();
		Form23.form23_0.method_9(method_4);
		setting_0.method_264(method_7);
		setting_0.method_40(method_6);
		bool flag2 = Form23.enum60_0 == Form23.Enum60.BpF && (bool_0 || bool_1) && framework_1 != null;
		SuspendLayout();
		if (flag2)
		{
			BNm.Text = Class333.Bci() + setting_0.method_22(bool_0: true) + Class333.smethod_180();
		}
		else if (flag)
		{
			BNm.Text = Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO();
		}
		else
		{
			BNm.Text = setting_0.method_22(bool_0: false);
		}
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
		int num = setting.method_256();
		BNN.method_8();
		int num2 = -1;
		List<Setting.ListItems.Struct45> list2 = setting.method_102();
		for (int i = 0; i < list2.Count; i++)
		{
			if (list2[i].bBv == num)
			{
				num2 = i;
			}
			Image image_ = setting.method_292(list2[i].bBv);
			BNN.method_7(image_, list2[i].bBV, null);
		}
		BNN.method_6((num2 < BNN.method_14()) ? num2 : (-1));
		BNm.Left = 0;
		BNm.Top = 3;
		BNm.AutoSize = true;
		BNN.Left = 0;
		BNN.Top = BNm.Top + 17;
		list.Add(BNm);
		if (!Controls.Contains(BNm))
		{
			Controls.Add(BNm);
		}
		if (!flag && !flag2)
		{
			BNN.method_0(method_8);
			BNN.GotFocus += BNN_GotFocus;
		}
		method_3();
		if (!flag && !flag2)
		{
			list.Add(BNN);
			if (!Controls.Contains(BNN))
			{
				Controls.Add(BNN);
			}
		}
		for (int num3 = Controls.Count - 1; num3 >= 0; num3--)
		{
			if (!list.Contains(Controls[num3]))
			{
				Controls.RemoveAt(num3);
			}
		}
		AutoSize = false;
		bool flag3;
		if (flag3 = framework_1 != null && (bool_0 || bool_1))
		{
			Width = TextRenderer.MeasureText(Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO(), BNm.Font).Width;
		}
		if (flag | flag2)
		{
			if (flag3)
			{
				Height = 20 + BNN.Height;
			}
			else
			{
				Width = BNm.Width;
				Height = BNm.Height * 2;
			}
		}
		else if (flag3)
		{
			Height = 20 + BNN.Height;
		}
		else
		{
			Width = Math.Max(BNm.Width, BNN.Width);
			Height = BNN.Bottom;
		}
		ResumeLayout(performLayout: true);
	}

	private void method_3()
	{
		if (setting_0.method_35() && framework_0.method_4())
		{
			BNm.ForeColor = Form23.color_12;
		}
		else
		{
			BNm.ForeColor = Form23.color_36;
		}
		bool flag = (Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) && setting_0.method_35() && framework_0.method_4();
		if (flag && !setting_0.method_122())
		{
			BNN.Enabled = true;
			switch (setting_0.method_124())
			{
			default:
				BNN.BackColor = Color.Red;
				break;
			case IllegalitySeverityLevel.Error:
				BNN.BackColor = Color.Red;
				break;
			case IllegalitySeverityLevel.Warning:
				BNN.BackColor = Color.Orange;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					BNN.BackColor = Color.Red;
				}
				else
				{
					BNN.BackColor = Color.Orange;
				}
				break;
			}
		}
		else
		{
			BNN.Enabled = flag;
			bool flag2 = bool_0 || bool_1;
			if (setting_1 != null && !flag2 && !setting_0.method_282(setting_1))
			{
				BNN.BackColor = Form23.color_9;
			}
			else if (BNN.Enabled)
			{
				BNN.BackColor = Form23.color_32;
			}
			else
			{
				BNN.BackColor = Form23.color_35;
			}
		}
		TabStop = BNN.Enabled;
		BNN.TabStop = TabStop;
		BNN.method_2();
		BNN.Invalidate();
	}

	protected override void OnGotFocus(EventArgs eventArgs_0)
	{
		base.OnGotFocus(eventArgs_0);
		BNN.Focus();
	}

	private void BNN_GotFocus(object sender, EventArgs e)
	{
		Form23.form23_0.control4_0.method_59(setting_0);
	}

	private void method_4(object sender, EventArgs e)
	{
		if (!bool_0 && !bool_1)
		{
			method_5();
			method_3();
		}
		else
		{
			vmethod_8();
		}
	}

	private void method_5()
	{
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
		int num = -1;
		int num2 = setting.method_256();
		List<Setting.ListItems.Struct45> list = setting.method_102();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].bBv == num2)
			{
				num = i;
				break;
			}
		}
		if (BNN.method_5() != num && num != -1 && num < BNN.method_14())
		{
			BNN.method_6(num);
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate68 method = method_6;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		List<Setting.ListItems.Struct45> list = setting_0.method_102();
		bool flag = false;
		if (list.Count != BNN.method_14())
		{
			flag = true;
		}
		else
		{
			for (int i = 0; i < BNN.method_14(); i++)
			{
				if (!(list[i].bBV != BNN.method_12(i)))
				{
					Image image = setting_0.method_292(list[i].bBv);
					Image image2 = BNN.method_11(i);
					byte[] array = null;
					byte[] array2 = null;
					if (image != null && image2 != null)
					{
						using (MemoryStream memoryStream = new MemoryStream())
						{
							image.Save(memoryStream, image.RawFormat);
							array = memoryStream.ToArray();
						}
						using MemoryStream memoryStream2 = new MemoryStream();
						image2.Save(memoryStream2, image2.RawFormat);
						array2 = memoryStream2.ToArray();
					}
					image?.Dispose();
					if (array != null && array2 != null && array.Length == array2.Length)
					{
						for (int j = 0; j < array.Length; j++)
						{
							if (array[j] != array2[j])
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							break;
						}
						continue;
					}
					flag = true;
					break;
				}
				flag = true;
				break;
			}
		}
		if (flag)
		{
			vmethod_8();
		}
		else
		{
			method_3();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate69 method = method_7;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			method_5();
			if (setting_1 != null)
			{
				method_3();
			}
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		if (Form23.bool_2)
		{
			Form23.smethod_75(setting_0.method_69());
		}
		else if (BNo)
		{
			BNo = false;
		}
		else
		{
			if (BNN.method_5() == -1)
			{
				return;
			}
			List<Setting.ListItems.Struct45> list = setting_0.method_102();
			if (setting_0.method_256() == list[BNN.method_5()].bBv)
			{
				return;
			}
			bool flag = false;
			string text = setting_0.method_47();
			if (text != null && list[BNN.method_5()].bBv != 0 && !Form13.smethod_0(setting_0, null))
			{
				Form13 form = new Form13(text, setting_0, null);
				if (form.ShowDialog(Form23.form23_0) != DialogResult.OK)
				{
					flag = true;
				}
				form.Dispose();
			}
			if (flag)
			{
				int num = 0;
				while (true)
				{
					if (num < list.Count)
					{
						if (list[num].bBv == setting_0.method_256())
						{
							break;
						}
						num++;
						continue;
					}
					return;
				}
				BNo = true;
				BNN.method_6((num < BNN.method_14()) ? num : (-1));
			}
			else
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_3(setting_0.method_69());
				setting_0.method_272(list[BNN.method_5()].bBv, bool_0: true);
				@class?.method_4();
				Form23.smethod_75(setting_0.method_69());
			}
		}
	}

	public override string ToString()
	{
		return setting_0.method_22(bool_0: true);
	}

	protected override void vmethod_8()
	{
		method_9();
		if (Parent != null)
		{
			Parent.SuspendLayout();
		}
		BNN.method_8();
		method_2(dataIdAndAttrId_0, framework_0, framework_1, BNn);
		if (Parent != null)
		{
			Parent.ResumeLayout(performLayout: true);
		}
	}

	private void method_9()
	{
		try
		{
			BNN.method_1(method_8);
			BNN.GotFocus -= BNN_GotFocus;
			setting_0.method_265(method_7);
			setting_0.method_41(method_6);
			if (setting_3 != null)
			{
				setting_3.method_41(vmethod_6);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(vmethod_7);
			}
			Form23.form23_0.method_10(method_4);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_9();
		BNN.method_8();
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
