using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns1;

internal class Class86 : MovableResizablePanel, Interface3
{
	private delegate void Delegate4(object sender, OutputTestStateChangeEventArgs e);

	private delegate void Delegate5(object sender, EventArgs e);

	private delegate void Delegate6(object sender, EventArgs e);

	private Framework BHj;

	private Framework BHK;

	private SpecialObject BHk;

	private List<Setting> BHL = new List<Setting>();

	private Setting BHl;

	private Rectangle BHM;

	private bool BHm;

	private bool BHN;

	private bool BHn;

	private ThemedButton BHO;

	private string BHo;

	internal int BHP;

	[SpecialName]
	internal int method_12()
	{
		return BHk.method_68().ProcessId;
	}

	[SpecialName]
	internal SpecialObject method_13()
	{
		return BHk;
	}

	internal Class86(SpecialObject specialObject_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: false)
	{
		BHj = framework_0;
		BHK = framework_1;
		BHk = specialObject_0;
		BHM = rectangle_0;
		foreach (int preApplySettingDataId in BHk.method_68().PreApplySettingDataIds)
		{
			BHL.Add(BHj.method_31(preApplySettingDataId));
		}
		BHl = BHj.method_31(BHk.method_68().StatusChannelDataId);
		BHl.method_264(method_19);
		BHk.method_40(method_15);
		Class128.smethod_12();
		Class128.smethod_2(method_15);
		Class128.smethod_0(method_14);
		Form23.form23_0.method_9(method_16);
		BHn = BHL.Count == 0 && PortFunction.smethod_27(BHk.method_6());
		if (BHk.method_6() != null)
		{
			PortFunction.Class273 @class = BHk.method_6().method_12().method_12();
			BHP = (int)PortFunction.smethod_16(@class.BSQ, @class.BSq, @class.BSR);
			bool bool_1 = Class128.smethod_6(BHP, BHl);
			Class128.smethod_18(BHl, BHP, bool_1);
		}
	}

	private void method_14(object sender, OutputTestStateChangeEventArgs e)
	{
		if (e.PortValue != BHP)
		{
			return;
		}
		if (InvokeRequired)
		{
			try
			{
				Delegate4 method = method_14;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (BHO != null && !BHO.Disposing && !BHO.IsDisposed)
		{
			if (e.State && BHl.method_256() != 0 && e.PortValue == BHl.method_256())
			{
				BHO.Text = BHk.method_68().ActiveText;
			}
			else if (BHo != null)
			{
				BHO.Text = BHo;
			}
			else
			{
				BHO.Text = BHk.method_68().IdleText;
			}
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate5 method = method_15;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_18();
	}

	private void method_16(object sender, EventArgs e)
	{
		while (Controls.Count != 0)
		{
			Class30.smethod_0(Controls[0]);
		}
		method_17();
	}

	internal void method_17(bool bool_0 = false, bool bool_1 = true, string string_0 = null, int int_3 = 0)
	{
		SuspendLayout();
		int left = 5;
		int top = 5;
		HashSet<DataIdAndAttrId> idsContained = BHk.method_68().GetIdsContained();
		BHm = BHj.method_2() && BHj.method_3() && idsContained.Count != 0 && BHj.method_32(idsContained.First()).method_96();
		BHN = BHK != null && BHK.method_2() && BHK.method_3() && idsContained.Count != 0 && BHK.method_32(idsContained.First()).method_96();
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BHK == null) ? BHm : BHN)
		{
			Label label = new Label();
			label.Text = Class333.smethod_180() + BHk.method_60(Enum96.aYt) + Class333.BAO();
			label.ForeColor = Form23.color_12;
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = left;
			label.Top = top;
			Controls.Add(label);
		}
		else
		{
			if (BHO == null || BHO.Disposing || BHO.IsDisposed)
			{
				BHO = new ThemedButton();
			}
			if (!bool_1)
			{
				BHP |= int_3;
			}
			if (BHn)
			{
				bool flag = BHk.method_2().Contains(Class333.smethod_886());
				BackColor = Form23.color_15;
				BackColor = Form23.color_15;
				BHO.AutoSize = false;
				BHO.Left = 0;
				if (bool_0)
				{
					BHO.Width = 55;
					BHO.Height = 20;
					BHO.Top = 0;
				}
				else
				{
					BHO.Width = (flag ? 60 : 120);
					BHO.Height = 23;
					BHO.Top = 10;
				}
				if (!bool_1)
				{
					BHo = string_0;
					if (BHo != null)
					{
						BHO.Text = BHo;
					}
					else
					{
						BHO.Text = BHk.method_68().IdleText;
					}
				}
				else if (Class128.smethod_6(BHP, BHl))
				{
					BHO.Text = BHk.method_68().ActiveText;
				}
				else
				{
					BHO.Text = BHk.method_68().IdleText;
				}
				if (BHo == null)
				{
					if (Class128.smethod_6(BHP, BHl))
					{
						BHO.Text = BHk.method_68().ActiveText;
					}
					else
					{
						BHO.Text = BHk.method_68().IdleText;
					}
				}
				method_18();
				if (BHk.method_68().HoldToExecuteOutputTest)
				{
					BHO.MouseDown += BHO_MouseDown;
					BHO.MouseUp += BHO_MouseUp;
				}
				else
				{
					BHO.Click += BHO_Click;
				}
				Controls.Add(BHO);
			}
			else
			{
				string text = BHk.method_60(Enum96.aYu);
				if (string.IsNullOrEmpty(text))
				{
					text = BHk.method_60(Enum96.aYt);
				}
				if (BHk.method_68().InjectorStageIndex != -1 && BHk.method_68().InjectorOutputWithinStage != -1)
				{
					text = PortFunction.smethod_49(BHj, BHk.method_68().InjectorStageIndex, BHk.method_68().InjectorOutputWithinStage, text);
				}
				if (!string.IsNullOrEmpty(text))
				{
					Label label2 = new Label();
					label2.ForeColor = Form23.color_14;
					label2.Font = new Font(Font.FontFamily, 10f, FontStyle.Bold);
					label2.AutoSize = true;
					label2.Text = text;
					label2.Left = left;
					label2.Top = top;
					Controls.Add(label2);
					top = label2.Bottom + 10;
				}
				foreach (Setting item in BHL)
				{
					if (item != null)
					{
						Control21 control = new Control21(item.method_69(), BHj, BHK, null, bool_2: false, bool_3: false, bool_4: false);
						control.Left = left;
						control.Top = top;
						Controls.Add(control);
						top = control.Bottom + 8;
					}
				}
				BHO.AutoSize = true;
				if (Class128.smethod_6(BHP, BHl))
				{
					BHO.Text = BHk.method_68().ActiveText;
				}
				else
				{
					BHO.Text = BHk.method_68().IdleText;
				}
				BHO.Left = left;
				BHO.Top = top;
				method_18();
				if (BHk.method_68().HoldToExecuteOutputTest)
				{
					BHO.MouseDown += BHO_MouseDown;
					BHO.MouseUp += BHO_MouseUp;
				}
				else
				{
					BHO.Click += BHO_Click;
				}
				Controls.Add(BHO);
			}
		}
		if (BHM != Rectangle.Empty)
		{
			Width = BHM.Width;
			Height = BHM.Height;
			Left = BHM.Left;
			Top = BHM.Top;
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control control2 in Controls)
			{
				num = Math.Max(num, control2.Right + (BHn ? 1 : 5));
				num2 = Math.Max(num2, control2.Bottom + (BHn ? 1 : 5));
			}
			Width = num;
			Height = num2;
		}
		ResumeLayout(performLayout: true);
	}

	internal void method_18()
	{
		bool flag = BHk.method_2().Contains(Class333.smethod_886());
		BHO.Enabled = BHj.method_4() && BHk.method_35() && (Form23.enum60_0 != Form23.Enum60.BpG || BHK == null) && (!flag || !Class128.smethod_4());
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			BHl.method_265(method_19);
			BHk.method_41(method_15);
			Class128.smethod_1(method_14);
			Class128.smethod_3(method_15);
			Class128.smethod_13();
			foreach (Control control in Controls)
			{
				if (control is Button)
				{
					(control as Button).MouseUp -= BHO_MouseUp;
					(control as Button).MouseDown -= BHO_MouseDown;
					(control as Button).Click -= BHO_Click;
				}
			}
			Form23.form23_0.method_10(method_16);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (BHn)
		{
			paintEventArgs_0.Graphics.Clear(BackColor);
		}
		else
		{
			base.OnPaint(paintEventArgs_0);
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate6 method = method_19;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (BHO == null || BHO.Disposing || BHO.IsDisposed)
		{
			return;
		}
		if (BHk.method_2().Contains(Class333.smethod_886()))
		{
			if (Class128.smethod_6(BHP, BHl))
			{
				BHO.Text = BHk.method_68().ActiveText;
			}
			else if (BHo != null)
			{
				BHO.Text = BHo;
			}
			else
			{
				BHO.Text = BHk.method_68().IdleText;
			}
		}
		else if (BHl.method_256() == 1)
		{
			BHO.Text = BHk.method_68().ActiveText;
		}
		else
		{
			BHO.Text = BHk.method_68().IdleText;
		}
	}

	private void BHO_Click(object sender, EventArgs e)
	{
		if (!Form23.smethod_28(BHj.aXc, bool_53: true) || !BHj.method_4() || BHl.method_256() == 1)
		{
			return;
		}
		bool flag = BHk.method_2().Contains(Class333.smethod_886());
		string confirmationText = BHk.method_68().ConfirmationText;
		if (flag && BHl.method_256() == BHP)
		{
			Class128.smethod_18(BHl, BHP, bool_1: false);
		}
		else if (BHl.method_256() == 0)
		{
			if (string.IsNullOrEmpty(confirmationText) || Form54.smethod_6(Form23.form23_0, confirmationText, Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				if (flag)
				{
					Class128.smethod_18(BHl, BHP, bool_1: true);
				}
				else
				{
					BHl.method_272(1, bool_0: true);
				}
			}
		}
		else if (flag && BHl.method_256() != BHP && (string.IsNullOrEmpty(confirmationText) || Form54.smethod_6(Form23.form23_0, confirmationText, Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
		{
			Class128.smethod_18(BHl, BHP, bool_1: true);
		}
	}

	public void BHO_MouseDown(object sender, EventArgs e)
	{
		if (!Form23.smethod_28(BHj.aXc, bool_53: true) || !BHj.method_4())
		{
			return;
		}
		if (BHk.method_2().Contains(Class333.smethod_886()))
		{
			Class128.smethod_18(BHl, BHP, bool_1: true);
		}
		else if (BHl.method_256() != 1)
		{
			string confirmationText = BHk.method_68().ConfirmationText;
			if (string.IsNullOrEmpty(confirmationText) || Form54.smethod_6(Form23.form23_0, confirmationText, Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				BHl.method_272(1, bool_0: true);
			}
		}
	}

	private void BHO_MouseUp(object sender, EventArgs e)
	{
		if (BHk.method_2().Contains(Class333.smethod_886()))
		{
			Class128.smethod_18(BHl, BHP, bool_1: false);
		}
	}

	public Control imethod_0(DataIdAndAttrId dataIdAndAttrId_0)
	{
		foreach (Control control in Controls)
		{
			if (control is Control21 && (control as Control21).method_0().method_69() == dataIdAndAttrId_0)
			{
				return control;
			}
		}
		return null;
	}

	public Control imethod_1()
	{
		foreach (Control control in Controls)
		{
			if (control is Control21)
			{
				return control;
			}
		}
		return null;
	}
}
