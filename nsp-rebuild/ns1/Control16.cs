using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Properties;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Control16 : Control11
{
	private delegate void Delegate62(object sender, EventArgs e);

	private delegate void Delegate63(object sender, EventArgs e);

	private const int BmU = 20;

	internal const int Bmu = 160;

	internal const int BmV = 220;

	internal const int Bmv = 320;

	private const int BmW = 40;

	private bool Bmw;

	private Label BmX = new Label();

	private Panel Bmx = new Panel();

	private ThemedTextBox BmY = new ThemedTextBox();

	private Label Bmy = new Label();

	private Class286 BmZ;

	private int Bmz;

	private bool BNA;

	[SpecialName]
	internal int method_2()
	{
		return BmX.Width;
	}

	internal Control16(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0)
	{
		method_3(dataIdAndAttrId_1, framework_2, framework_3, class286_0);
	}

	private void method_3(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0)
	{
		vmethod_0(framework_2, framework_3);
		vmethod_1(dataIdAndAttrId_1);
		BmZ = class286_0;
		if (BmZ != null)
		{
			int[] array = BmZ.method_3(setting_0);
			if (array != null && array.Length == 1)
			{
				Bmz = array[0];
			}
			else
			{
				BmZ = null;
			}
		}
		vmethod_2();
		bool flag = vmethod_3();
		List<Control> list = new List<Control>();
		Form23.form23_0.method_9(method_7);
		Bmw = false;
		SuspendLayout();
		BmX.Font = new Font(BmX.Font.FontFamily, 8.25f, BmX.Font.Style);
		BmY.Font = new Font(BmY.Font.FontFamily, 8.25f, BmY.Font.Style);
		Bmy.Font = new Font(Bmy.Font.FontFamily, 8.25f, Bmy.Font.Style);
		bool flag2;
		if (flag2 = Form23.enum60_0 == Form23.Enum60.BpF && (bool_0 || bool_1) && framework_1 != null)
		{
			BmX.Text = Class333.Bci() + setting_0.method_22(bool_0: true) + Class333.smethod_180();
		}
		else if (flag)
		{
			BmX.Text = Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO();
		}
		else
		{
			BmX.Text = setting_0.method_22(bool_0: false);
		}
		Bmx.Width = 20;
		Bmx.Height = 20;
		Bmx.BorderStyle = BorderStyle.FixedSingle;
		BmX.Left = 0;
		BmX.Top = 3;
		BmX.Height = 16;
		BmX.Width = method_4();
		Bmx.Left = BmX.Right + 10;
		Bmx.Top = 0;
		BmY.Left = BmX.Right + 10 + 20 + 10;
		BmY.Top = 0;
		BmY.Width = 40;
		Bmy.Text = Class333.smethod_681();
		Bmy.Left = BmX.Right + 10 + 20 + 10 + 40 + 10;
		Bmy.Top = 3;
		Bmy.Height = 16;
		Bmy.Width = 15;
		list.Add(BmX);
		if (!Controls.Contains(BmX))
		{
			Controls.Add(BmX);
		}
		if (!flag && !flag2)
		{
			BmY.KeyDown += BmY_KeyDown;
			BmY.KeyPress += BmY_KeyPress;
			BmY.Leave += BmY_Leave;
			setting_0.method_264(method_12);
			setting_0.method_40(method_8);
			Bmx.Click += Bmx_Click;
			list.Add(Bmx);
			if (!Controls.Contains(Bmx))
			{
				Controls.Add(Bmx);
			}
			list.Add(BmY);
			if (!Controls.Contains(BmY))
			{
				Controls.Add(BmY);
			}
			list.Add(Bmy);
			if (!Controls.Contains(Bmy))
			{
				Controls.Add(Bmy);
			}
		}
		for (int num = Controls.Count - 1; num >= 0; num--)
		{
			if (!list.Contains(Controls[num]))
			{
				Controls.RemoveAt(num);
			}
		}
		AutoSize = false;
		bool flag3;
		if (flag3 = framework_1 != null && (bool_0 || bool_1))
		{
			Width = method_4() + 10 + Bmx.Width + 10 + 40 + 10 + 15;
		}
		Height = BmY.Height;
		if (!flag3)
		{
			Width = Bmy.Right;
		}
		if (!flag && !flag2 && !flag3)
		{
			Width = Bmy.Right + 10;
		}
		method_6();
		ResumeLayout(performLayout: true);
	}

	private int method_4()
	{
		if (string.IsNullOrWhiteSpace(BmX.Text))
		{
			return 2;
		}
		int width = TextRenderer.MeasureText(BmX.Text, BmX.Font).Width;
		if (width < 160)
		{
			return 160;
		}
		if (width < 220)
		{
			return 220;
		}
		return 320;
	}

	internal void method_5(int int_1)
	{
		int num = int_1 - BmX.Width;
		if (num > 0)
		{
			BmX.Width += num;
			Bmx.Left += num;
			Width += num;
		}
	}

	private void method_6()
	{
		if (setting_0.method_35() && framework_0.method_4())
		{
			BmX.ForeColor = Form23.color_12;
		}
		else
		{
			BmX.ForeColor = Form23.color_36;
		}
		Bmy.ForeColor = BmX.ForeColor;
		bool flag;
		if (Form23.enum60_0 == Form23.Enum60.BpG && setting_1 != null)
		{
			flag = false;
			Bmx.Enabled = false;
			Bmx.BackColor = method_9(setting_1);
			BmY.Enabled = false;
			BmY.Text = method_10(setting_1);
		}
		else
		{
			flag = setting_0.method_35() && framework_0.method_4();
			Bmx.Enabled = flag;
			Bmx.BackColor = method_9(setting_0);
			BmY.Enabled = flag;
			BmY.Text = method_10(setting_0);
		}
		if (flag && !setting_0.method_122())
		{
			switch (setting_0.method_124())
			{
			default:
				BmY.BackColor = Color.Red;
				break;
			case IllegalitySeverityLevel.Error:
				BmY.BackColor = Color.Red;
				break;
			case IllegalitySeverityLevel.Warning:
				BmY.BackColor = Color.Orange;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					BmY.BackColor = Color.Red;
				}
				else
				{
					BmY.BackColor = Color.Orange;
				}
				break;
			}
		}
		else
		{
			bool flag2 = bool_0 || bool_1;
			if (setting_1 != null && !flag2 && !setting_0.method_282(setting_1))
			{
				BmY.BackColor = Form23.color_9;
			}
			else if (flag)
			{
				BmY.BackColor = Form23.color_32;
			}
			else
			{
				BmY.BackColor = Form23.color_35;
			}
		}
		if (!BmY.Enabled && !(BmY.BackColor == Form23.color_9))
		{
			BmY.ForeColor = Form23.color_36;
		}
		else
		{
			BmY.ForeColor = Form23.color_12;
		}
		TabStop = Bmx.Enabled;
		Bmx.TabStop = TabStop;
		BmY.TabStop = TabStop;
		Bmx.Invalidate();
		BmY.Invalidate();
	}

	private void method_7(object sender, EventArgs e)
	{
		if (!bool_0 && !bool_1)
		{
			method_6();
		}
		else
		{
			vmethod_8();
		}
	}

	private void Bmx_Click(object sender, EventArgs e)
	{
		if (Bmx.Disposing || Form23.bool_2 || Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		Color color = method_9(setting_0);
		ColorDialog colorDialog = new ColorDialog();
		colorDialog.Color = color;
		colorDialog.AllowFullOpen = true;
		colorDialog.FullOpen = true;
		colorDialog.AnyColor = true;
		colorDialog.ShowHelp = false;
		colorDialog.SolidColorOnly = false;
		colorDialog.CustomColors = Settings.Default.ColourPickerCustomColors;
		if (colorDialog.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			Settings.Default.ColourPickerCustomColors = colorDialog.CustomColors;
			Settings.Default.Save();
			if (!Form23.bool_2)
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_3(setting_0.method_69());
				framework_0.method_55();
				setting_0.method_270(1, colorDialog.Color.R, bool_0: true);
				setting_0.method_270(2, colorDialog.Color.G, bool_0: true);
				setting_0.method_270(3, colorDialog.Color.B, bool_0: true);
				framework_0.method_54(bool_0: true, setting_0);
				Bmx.BackColor = Color.FromArgb(255, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
				@class?.method_4();
			}
			Form23.smethod_75(setting_0.method_69());
		}
		colorDialog.Dispose();
	}

	private void method_8(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate62 method = method_8;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_6();
	}

	private Color method_9(Setting setting_5)
	{
		byte red = setting_5.method_254(1);
		byte green = setting_5.method_254(2);
		byte blue = setting_5.method_254(3);
		return Color.FromArgb(255, red, green, blue);
	}

	private string method_10(Setting setting_5)
	{
		byte b = setting_5.method_254(0);
		return ((int)Math.Round(100f * (float)(int)b / 255f, 0)).ToString();
	}

	internal void method_11()
	{
		if (BmY.Disposing || Form23.bool_2 || Form23.enum60_0 == Form23.Enum60.BpG || Form23.bool_35)
		{
			return;
		}
		string text = BmY.Text;
		Bmw = false;
		string text2 = method_10(setting_0);
		if (text2 == text)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			BmY.Text = text2;
			return;
		}
		try
		{
			byte byte_ = (byte)Math.Min(Math.Max((int)(255f * float.Parse(text) / 100f), 0), 255);
			Class280 @class = Form23.smethod_95();
			@class?.method_3(setting_0.method_69());
			setting_0.method_270(0, byte_, bool_0: true);
			@class?.method_4();
			Form23.smethod_75(setting_0.method_69());
		}
		catch
		{
			BNA = true;
			Form54.smethod_6(Form23.form23_0, Class333.smethod_605(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			BNA = false;
			BmY.Text = text2;
		}
	}

	private void BmY_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Return)
		{
			if (!e.Control)
			{
				Bmw = true;
			}
		}
		else
		{
			method_11();
		}
	}

	private void BmY_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '.')
		{
			if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator != Class333.smethod_190())
			{
				e.Handled = true;
			}
		}
		else if (e.KeyChar == ',' && CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator != Class333.smethod_189())
		{
			e.Handled = true;
		}
	}

	private void BmY_Leave(object sender, EventArgs e)
	{
		if (!BNA)
		{
			method_11();
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate63 method = method_12;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 != Form23.Enum60.BpG && !Bmw)
		{
			int selectionStart = BmY.SelectionStart;
			int selectionLength = BmY.SelectionLength;
			Color color = method_9(setting_0);
			string text = method_10(setting_0);
			if (Bmx.BackColor != color || BmY.Text != text)
			{
				Bmx.BackColor = color;
				BmY.Text = text;
				Form23.smethod_75(setting_0.method_69());
			}
			BmY.SelectionStart = selectionStart;
			BmY.SelectionLength = selectionLength;
			if (setting_1 != null)
			{
				method_6();
			}
		}
	}

	public override string ToString()
	{
		return setting_0.method_22(bool_0: true);
	}

	protected override void vmethod_8()
	{
		method_13();
		int width = BmX.Width;
		if (Parent != null)
		{
			Parent.SuspendLayout();
		}
		method_3(dataIdAndAttrId_0, framework_0, framework_1, BmZ);
		method_5(Math.Max(width, BmX.Width));
		if (Parent != null)
		{
			Parent.ResumeLayout(performLayout: true);
		}
	}

	private void method_13()
	{
		try
		{
			BmY.KeyDown -= BmY_KeyDown;
			BmY.KeyPress -= BmY_KeyPress;
			BmY.Leave -= BmY_Leave;
			setting_0.method_265(method_12);
			setting_0.method_41(method_8);
			Bmx.Click -= Bmx_Click;
			if (setting_3 != null)
			{
				setting_3.method_41(vmethod_6);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(vmethod_7);
			}
			Form23.form23_0.method_10(method_7);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_13();
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
