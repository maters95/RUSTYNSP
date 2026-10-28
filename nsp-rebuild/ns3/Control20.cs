using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns3;

internal class Control20 : Control19
{
	private delegate void Delegate52(object sender, EventArgs e);

	private delegate void Delegate53(object sender, EventArgs e);

	private bool BWW;

	private int BWw;

	private Label BWX = new Label();

	private bool BWx;

	private bool BWY;

	internal Control20(DataIdAndAttrId dataIdAndAttrId_1, bool bool_2, int int_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_3)
	{
		method_8(dataIdAndAttrId_1, bool_2, int_1, framework_2, framework_3, class286_0, bool_3);
	}

	private void method_8(DataIdAndAttrId dataIdAndAttrId_1, bool bool_2, int int_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_3)
	{
		BWW = bool_2;
		BWw = int_1;
		vmethod_0(framework_2, framework_3);
		vmethod_1(dataIdAndAttrId_1);
		BNQ = class286_0;
		if (BNQ != null)
		{
			BNq = bool_3;
			int[] array = BNQ.method_3(setting_0);
			int num = (BWW ? BWw : 0);
			if (array != null && array.Length > num)
			{
				BNR = array[num];
			}
			else
			{
				BNQ = null;
			}
		}
		vmethod_2();
		bool flag = vmethod_3();
		if (BNP.ContextMenuStrip == null)
		{
			BNP.ContextMenuStrip = vmethod_9();
		}
		List<Control> list = new List<Control>();
		Form23.form23_0.method_9(method_12);
		BNp = false;
		setting_0.method_264(method_19);
		setting_0.method_40(method_13);
		SuspendLayout();
		if (flag | (Form23.enum60_0 == Form23.Enum60.BpF && (bool_0 || bool_1) && framework_1 != null))
		{
			BWX.Text = Class333.BcI();
			BWX.ForeColor = Form23.color_12;
			BWX.Left = 0;
			BWX.Top = 2;
			BWX.AutoSize = true;
			list.Add(BWX);
			if (!Controls.Contains(BWX))
			{
				Controls.Add(BWX);
			}
			AutoSize = false;
			Height = BNP.Height + 2;
			Width = 100;
		}
		else
		{
			BNP.Font = new Font(BNP.Font.FontFamily, 8.25f, BNP.Font.Style);
			if (Form23.enum60_0 == Form23.Enum60.BpG && setting_1 != null)
			{
				BNP.Text = method_14(setting_1);
				BNP.Enabled = false;
			}
			else
			{
				BNP.Text = method_14(setting_0);
			}
			BNP.Left = 0;
			BNP.Top = 0;
			BNP.Width = 70;
			BNP.GotFocus += method_11;
			BNP.KeyDown += method_16;
			BNP.KeyPress += method_17;
			BNP.Leave += method_18;
			list.Add(BNP);
			if (!Controls.Contains(BNP))
			{
				Controls.Add(BNP);
			}
			AutoSize = false;
			Height = BNP.Height;
			pictureBox_0.Tag = setting_0;
			pictureBox_0.Width = 18;
			pictureBox_0.Height = 18;
			pictureBox_0.Left = BNP.Width + 5;
			pictureBox_0.Top = 1;
			pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox_0.Click += method_10;
			list.Add(pictureBox_0);
			if (!Controls.Contains(pictureBox_0))
			{
				Controls.Add(pictureBox_0);
			}
			Width = pictureBox_0.Right;
			pictureBox_0.Visible = false;
			MouseEnter += vmethod_4;
			BNP.MouseEnter += vmethod_4;
			pictureBox_0.MouseEnter += vmethod_4;
			BNP.MouseLeave += vmethod_5;
			MouseLeave += vmethod_5;
		}
		for (int num2 = Controls.Count - 1; num2 >= 0; num2--)
		{
			if (!list.Contains(Controls[num2]))
			{
				Controls.RemoveAt(num2);
			}
		}
		method_9();
		method_20();
		ResumeLayout(performLayout: true);
	}

	protected override void vmethod_4(object sender, EventArgs e)
	{
		if (Form23.pictureBox_1 != pictureBox_0)
		{
			if (!Form23.bool_28 && Form23.pictureBox_1 != null)
			{
				Form23.pictureBox_1.Visible = false;
			}
			bool flag = ((!BWW) ? setting_0.method_35() : setting_0.method_131()[0, 0, BWw]);
			Form23.bool_28 = flag && !setting_0.method_122();
			Form23.pictureBox_1 = pictureBox_0;
		}
		pictureBox_0.Visible = true;
	}

	protected override void vmethod_5(object sender, EventArgs e)
	{
		if (!ClientRectangle.Contains(PointToClient(System.Windows.Forms.Cursor.Position)))
		{
			bool flag = ((!BWW) ? setting_0.method_35() : setting_0.method_131()[0, 0, BWw]);
			pictureBox_0.Visible = ((pictureBox_0.Image != null) & flag) && !setting_0.method_122();
		}
	}

	private void method_9()
	{
		bool flag = framework_0.method_4() && Form23.enum60_0 != Form23.Enum60.BpG && ((!BWW) ? setting_0.method_35() : setting_0.method_131()[0, 0, BWw]);
		if (flag && !setting_0.method_122())
		{
			BNP.Enabled = true;
			switch (setting_0.method_124())
			{
			default:
				BNP.BackColor = Color.Red;
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Error:
				BNP.BackColor = Color.Red;
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				BNP.BackColor = Color.Orange;
				pictureBox_0.Image = GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					BNP.BackColor = Color.Red;
					pictureBox_0.Image = GeneralResources.RedError;
				}
				else
				{
					BNP.BackColor = Color.Orange;
					pictureBox_0.Image = GeneralResources.YellowWarning;
				}
				break;
			}
			pictureBox_0.Visible = true;
		}
		else
		{
			BNP.Enabled = flag;
			bool flag2 = bool_0 || bool_1;
			if (setting_1 != null && !flag2 && !setting_0.method_281(setting_1, BWw))
			{
				BNP.BackColor = Form23.color_9;
			}
			else if (flag)
			{
				BNP.BackColor = Form23.color_32;
			}
			else
			{
				BNP.BackColor = Form23.color_35;
			}
			pictureBox_0.Visible = false;
			pictureBox_0.Image = GeneralResources.QuestionMark;
		}
		if (!BNP.Enabled && !(BNP.BackColor == Form23.color_9))
		{
			BNP.ForeColor = Form23.color_36;
		}
		else
		{
			BNP.ForeColor = Form23.color_12;
		}
		TabStop = BNP.Enabled;
		BNP.TabStop = TabStop;
		BNP.Invalidate();
	}

	private void method_10(object sender, EventArgs e)
	{
		Form23.smethod_51(setting_0, BWw, this);
	}

	private void method_11(object sender, EventArgs e)
	{
		Form23.form23_0.control4_0.method_59(setting_0);
		if (framework_1 != null && BNP.BackColor == Form23.color_9)
		{
			Form23.smethod_51(setting_0, BWw, this);
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		if (!bool_0 && !bool_1)
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				if (setting_1 != null)
				{
					BNP.Text = method_14(setting_1);
				}
			}
			else
			{
				BNP.Text = method_14(setting_0);
			}
			method_9();
		}
		else
		{
			vmethod_8();
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate52 method = method_13;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_9();
	}

	private string method_14(Setting setting_5)
	{
		int num = ((!BWW) ? setting_5.method_256() : setting_5.method_258(BWw));
		return Class233.smethod_29(num, setting_5.method_231());
	}

	internal void method_15()
	{
		if (BNP.Disposing || Form23.bool_2 || Form23.enum60_0 == Form23.Enum60.BpG || Form23.bool_35)
		{
			return;
		}
		string text = BNP.Text;
		BNp = false;
		string text2 = method_14(setting_0);
		if (text2 == text)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			BNP.Text = text2;
			return;
		}
		if (setting_0.method_25())
		{
			try
			{
				int num = Class233.smethod_25(text, setting_0.method_231());
				if (setting_0.method_199() == 2)
				{
					if (setting_0.method_201())
					{
						if (num < -32768)
						{
							num = -32768;
						}
						else if (num > 32767)
						{
							num = 32767;
						}
					}
					else if (num < 0)
					{
						num = 0;
					}
					else if (num > 65535)
					{
						num = 65535;
					}
				}
				else if (setting_0.method_199() == 1)
				{
					if (setting_0.method_201())
					{
						if (num < -128)
						{
							num = -128;
						}
						else if (num > 127)
						{
							num = 127;
						}
					}
					else if (num < 0)
					{
						num = 0;
					}
					else if (num > 255)
					{
						num = 255;
					}
				}
				int num2 = setting_0.method_221();
				if (num2 > 1)
				{
					num = Class23.smethod_12(num, num2);
				}
				int num3 = setting_0.method_228();
				int num4 = setting_0.method_229();
				if (num3 != 0 || num4 != 0)
				{
					num = Math.Min(Math.Max(num, num3), num4);
				}
				Class280 @class = Form23.smethod_95();
				@class?.method_3(setting_0.method_69());
				if (BWW)
				{
					setting_0.method_274(BWw, num, bool_0: true);
				}
				else
				{
					setting_0.method_272(num, bool_0: true);
				}
				@class?.method_4();
				Form23.smethod_75(setting_0.method_69());
				return;
			}
			catch
			{
				BWx = true;
				Form54.smethod_6(Form23.form23_0, Class333.smethod_605(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				BWx = false;
				BNP.Text = text2;
				return;
			}
		}
		BNP.Text = text2;
	}

	private void method_16(object sender, KeyEventArgs e)
	{
		if ((!e.Control || e.KeyCode != Keys.Prior) && e.KeyData != Keys.Prior && (!e.Shift || e.KeyCode != Keys.Prior) && (!e.Control || e.KeyCode != Keys.Next) && e.KeyData != Keys.Next && (!e.Shift || e.KeyCode != Keys.Next))
		{
			if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Return)
			{
				if (!e.Control)
				{
					BNp = true;
				}
			}
			else
			{
				method_15();
			}
		}
		else
		{
			BWY = true;
			e.Handled = true;
		}
	}

	private void method_17(object sender, KeyPressEventArgs e)
	{
		if (BWY)
		{
			e.Handled = true;
			BWY = false;
			BNp = false;
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		if (!BWx)
		{
			method_15();
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate53 method = method_19;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_20();
		if (Form23.enum60_0 != Form23.Enum60.BpG && !BNp)
		{
			int selectionStart = BNP.SelectionStart;
			int selectionLength = BNP.SelectionLength;
			string text = method_14(setting_0);
			if (BNP.Text != text)
			{
				BNP.Text = text;
				Form23.smethod_75(setting_0.method_69());
			}
			BNP.SelectionStart = selectionStart;
			BNP.SelectionLength = selectionLength;
			if (setting_1 != null)
			{
				method_9();
			}
		}
	}

	private void method_20()
	{
		FontStyle fontStyle = FontStyle.Regular;
		if (BNQ != null && BNq)
		{
			Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
			if (BWW)
			{
				if (setting.method_258(BWw) != BNR)
				{
					fontStyle = FontStyle.Italic;
				}
			}
			else if (setting.method_256() != BNR)
			{
				fontStyle = FontStyle.Italic;
			}
		}
		if (BNP.Font.Style != fontStyle)
		{
			Font font = BNP.Font;
			BNP.Font = new Font(BNP.Font.FontFamily, BNP.Font.Size, fontStyle);
			font.Dispose();
		}
	}

	internal bool method_21(KeyEventArgs keyEventArgs_0)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return false;
		}
		if ((!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Prior) && keyEventArgs_0.KeyData != Keys.Prior && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Prior) && (!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Next) && keyEventArgs_0.KeyData != Keys.Next && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Next))
		{
			return false;
		}
		BNp = false;
		int int_ = setting_0.method_231();
		int num = setting_0.method_228();
		int num2 = setting_0.method_229();
		int num3 = setting_0.method_256();
		int num4 = num3;
		if (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Prior)
		{
			num4 += Class233.smethod_36(int_);
		}
		else if (keyEventArgs_0.KeyData == Keys.Prior)
		{
			num4 += Class233.smethod_37(int_);
		}
		else if (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Prior)
		{
			num4 += Class233.smethod_38(int_);
		}
		else if (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Next)
		{
			num4 -= Class233.smethod_36(int_);
		}
		else if (keyEventArgs_0.KeyData == Keys.Next)
		{
			num4 -= Class233.smethod_37(int_);
		}
		else if (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Next)
		{
			num4 -= Class233.smethod_38(int_);
		}
		if (num4 != num3)
		{
			if (num != 0 || num2 != 0)
			{
				num4 = Math.Min(num2, Math.Max(num, num4));
			}
			if (num4 != num3)
			{
				BNP.Text = Class233.smethod_29(num4, int_);
				method_15();
			}
		}
		return true;
	}

	protected override void vmethod_8()
	{
		method_22();
		if (Parent != null)
		{
			Parent.SuspendLayout();
		}
		method_8(dataIdAndAttrId_0, BWW, BWw, framework_0, framework_1, BNQ, BNq);
		if (Parent != null)
		{
			Parent.ResumeLayout(performLayout: true);
		}
	}

	protected override void vmethod_10()
	{
		Class280 @class = Form23.smethod_95();
		@class?.method_3(setting_0.method_69());
		if (BWW)
		{
			setting_0.method_247(BWw, bool_0: true);
		}
		else
		{
			setting_0.method_246(bool_0: true);
		}
		@class?.method_4();
		Form23.smethod_75(setting_0.method_69());
	}

	private void method_22()
	{
		try
		{
			BNP.GotFocus -= method_11;
			BNP.KeyDown -= method_16;
			BNP.KeyPress -= method_17;
			BNP.Leave -= method_18;
			MouseEnter -= vmethod_4;
			BNP.MouseEnter -= vmethod_4;
			pictureBox_0.MouseEnter -= vmethod_4;
			BNP.MouseLeave -= vmethod_5;
			pictureBox_0.Click -= method_10;
			setting_0.method_265(method_19);
			setting_0.method_41(method_13);
			if (setting_3 != null)
			{
				setting_3.method_41(vmethod_6);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(vmethod_7);
			}
			Form23.form23_0.method_10(method_12);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_22();
		if (Form23.pictureBox_1 == pictureBox_0)
		{
			Form23.pictureBox_1 = null;
		}
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
