using System;
using System.Drawing;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns1;
using ns2;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns3;

internal class Class112 : Class109
{
	private delegate void Delegate8(object sender, EventArgs e);

	private delegate void Delegate9(object sender, EventArgs e);

	private Framework BUj;

	private Class258 BUK;

	private Setting BUk;

	private Rectangle BUL;

	private float BUl = 1f;

	private ThemedButton BUM;

	internal Class112(Class258 class258_0, Framework framework_0, Rectangle rectangle_0, bool bool_0, bool bool_1, float float_0 = 1f)
		: base(rectangle_0, bool_0, bool_1)
	{
		BUj = framework_0;
		BUK = class258_0;
		BUK.method_3(method_15);
		BUL = rectangle_0;
		BUl = float_0;
		if (BUK.method_10() > 0)
		{
			BUk = BUj.method_31(BUK.method_10());
			if (BUk != null)
			{
				BUk.method_264(method_23);
			}
		}
	}

	public override string ToString()
	{
		string text = Class333.Bef();
		if (BUK != null && !string.IsNullOrEmpty(BUK.method_8()))
		{
			text = text + Class333.smethod_571() + BUK.method_8();
		}
		return text;
	}

	private void method_15(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate8 method = method_15;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (method_12().Controls.Count != 0)
		{
			method_16(bool_0: false);
		}
	}

	internal void method_16(bool bool_0)
	{
		SuspendLayout();
		method_12().SuspendLayout();
		int int_ = 5;
		int int_2 = 10;
		method_17(ref int_, ref int_2);
		method_18(ref int_, ref int_2);
		method_19(ref int_, ref int_2);
		method_20(ref int_, ref int_2);
		if (BUK.method_9() == Enum97.ayA && BUk != null)
		{
			method_21(bool_0, ref int_, ref int_2);
		}
		method_22();
		if (BUL != Rectangle.Empty)
		{
			if (bool_0)
			{
				Width = BUL.Width;
				Height = BUL.Height;
				Left = BUL.Left;
				Top = BUL.Top;
			}
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control control in method_12().Controls)
			{
				num = Math.Max(num, control.Right + 10);
				num2 = Math.Max(num2, control.Bottom + 10);
			}
			if (Width != num)
			{
				Width = num;
			}
			if (Height != num2)
			{
				Height = num2;
			}
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
		if (BUK.method_1() == Enum98.ayb)
		{
			Width = 0;
			Height = 0;
			Visible = false;
		}
		else if (!string.IsNullOrEmpty(BUK.method_8()))
		{
			if (method_12().Controls.Count > 1)
			{
				Visible = true;
				method_14();
			}
			else
			{
				Width = 0;
				Height = 0;
				Visible = false;
			}
		}
		else if (method_12().Controls.Count > 0)
		{
			Visible = true;
			method_14();
		}
		else
		{
			Width = 0;
			Height = 0;
			Visible = false;
		}
	}

	private void method_17(ref int int_3, ref int int_4)
	{
		if (!string.IsNullOrEmpty(BUK.method_8()))
		{
			string text = Class333.BeG();
			Label label = null;
			if (method_12().Controls.ContainsKey(text))
			{
				label = method_12().Controls[text] as Label;
			}
			else
			{
				label = new Label();
				label.Name = text;
				label.Text = BUK.method_8();
				label.ForeColor = Form23.color_14;
				label.Font = new Font(label.Font.FontFamily, 8f * BUl, FontStyle.Bold);
				label.BackColor = Color.Transparent;
				label.AutoSize = true;
				method_12().Controls.Add(label);
			}
			label.Left = int_3;
			label.Top = int_4;
			int_4 = label.Bottom + 2;
		}
	}

	private void method_18(ref int int_3, ref int int_4)
	{
		string text = Class333.Beg();
		if (BUK.method_12().Count == 1)
		{
			Setting setting = BUj.method_31(BUK.method_12()[0]);
			if (setting != null)
			{
				string text2 = text + setting.method_64();
				Control10 control = null;
				if (method_12().Controls.ContainsKey(text2))
				{
					control = method_12().Controls[text2] as Control10;
				}
				else
				{
					control = new Control10(setting.method_64(), bool_1: false, BUj, BUl);
					control.Name = text2;
					method_12().Controls.Add(control);
				}
				control.Left = 330;
				control.Top = 10;
			}
			return;
		}
		foreach (int item in BUK.method_12())
		{
			Setting setting2 = BUj.method_31(item);
			if (setting2 != null)
			{
				string text3 = text + setting2.method_64();
				Control10 control2 = null;
				if (method_12().Controls.ContainsKey(text3))
				{
					control2 = method_12().Controls[text3] as Control10;
				}
				else
				{
					control2 = new Control10(setting2.method_64(), bool_1: true, BUj, BUl);
					control2.Name = text3;
					method_12().Controls.Add(control2);
				}
				control2.Left = int_3;
				control2.Top = int_4;
				int_4 = control2.Bottom;
			}
		}
	}

	private void method_19(ref int int_3, ref int int_4)
	{
		if (BUK.method_13().Count == 0)
		{
			return;
		}
		int_4 += 3;
		foreach (int item in BUK.method_13())
		{
			Setting setting = BUj.method_31(item);
			if (setting == null || setting.method_219())
			{
				continue;
			}
			Class286 class286_ = null;
			MenuNode menuNode = MenuNode.smethod_2(BUj.awj, setting.method_69());
			if (menuNode != null)
			{
				MenuNode menuNode2 = menuNode.method_83(setting);
				if (menuNode2 != null)
				{
					class286_ = menuNode2.method_80().BcF;
				}
			}
			string text = Class333.BeH() + setting.method_64();
			Control control = null;
			if (method_12().Controls.ContainsKey(text))
			{
				control = method_12().Controls[text];
			}
			if (!setting.method_212() && !setting.method_220())
			{
				if (setting.method_154())
				{
					if (control == null)
					{
						Control15 control2 = new Control15(setting.method_69(), BUj, null, class286_, bool_2: false);
						control2.Name = text;
						control2.Left = int_3;
						control2.Top = int_4;
						int_4 = control2.Bottom;
						method_12().Controls.Add(control2);
					}
					else
					{
						control.Top = int_4;
						int_4 += control.Height;
					}
				}
				else if (setting.method_103().Count != 0)
				{
					if (control == null)
					{
						Control17 control3 = new Control17(setting.method_69(), BUj, null, class286_, bool_2: false, bool_3: true, bool_4: false);
						control3.Name = text;
						control3.Left = int_3;
						control3.Top = int_4 + 2;
						int_4 = control3.Bottom + 3;
						method_12().Controls.Add(control3);
					}
					else
					{
						control.Top = int_4 + 2;
						int_4 += control.Height + 3;
					}
				}
				else if (control == null)
				{
					Control21 control4 = new Control21(setting.method_69(), BUj, null, class286_, bool_2: false, bool_3: true, bool_4: false);
					control4.Name = text;
					control4.Left = int_3;
					control4.Top = int_4 + 2;
					int_4 = control4.Bottom + 3;
					method_12().Controls.Add(control4);
				}
				else
				{
					control.Top = int_4 + 2;
					int_4 += control.Height + 3;
				}
			}
			else
			{
				control?.Dispose();
			}
		}
	}

	private void method_20(ref int int_3, ref int int_4)
	{
		string text = Class333.Beh();
		for (int i = 0; i < BUK.method_2().Count; i++)
		{
			string text2 = text + i;
			Label label = null;
			if (method_12().Controls.ContainsKey(text2))
			{
				label = method_12().Controls[text2] as Label;
			}
			else
			{
				label = new Label();
				label.Name = text2;
				label.Font = new Font(label.Font.FontFamily, 5f * BUl, FontStyle.Bold);
				label.BackColor = Color.Transparent;
				label.ForeColor = Form23.color_7;
				label.AutoSize = true;
				method_12().Controls.Add(label);
			}
			label.Text = BUK.method_2()[i];
			label.Left = int_3;
			label.Top = int_4;
			int_4 = label.Bottom + 4;
			label.BringToFront();
		}
		for (int num = method_12().Controls.Count - 1; num >= 0; num--)
		{
			Control control = method_12().Controls[num];
			if (control.Name.StartsWith(text) && int.Parse(control.Name.Substring(text.Length)) >= BUK.method_2().Count)
			{
				control.Dispose();
			}
		}
	}

	private void method_21(bool bool_0, ref int int_3, ref int int_4)
	{
		if (bool_0)
		{
			BUM = new ThemedButton();
			BUM.Font = new Font(BUM.Font.FontFamily, 6f * BUl);
			BUM.AutoSize = false;
			BUM.Width = 80;
			BUM.Height = 33;
			BUM.Text = Class333.BeI();
			BUM.Click += BUM_Click;
			method_12().Controls.Add(BUM);
		}
		if (BUM != null)
		{
			BUM.Left = int_3;
			BUM.Top = int_4;
			int_4 = BUM.Bottom + 10;
		}
	}

	private void method_22()
	{
		string text = Class333.Bei();
		PictureBox pictureBox = null;
		if (method_12().Controls.ContainsKey(text))
		{
			pictureBox = method_12().Controls[text] as PictureBox;
		}
		else
		{
			pictureBox = new PictureBox();
			pictureBox.Name = text;
			pictureBox.BackColor = Color.Transparent;
			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox.Width = 32;
			pictureBox.Height = 32;
			pictureBox.Left = 510;
			pictureBox.Top = 10;
			method_12().Controls.Add(pictureBox);
		}
		switch (BUK.method_1())
		{
		default:
			pictureBox.Image = null;
			break;
		case Enum98.ayC:
			pictureBox.Image = GeneralResources.ChecklistWaiting;
			break;
		case Enum98.ayc:
			pictureBox.Image = GeneralResources.ChecklistTick;
			break;
		case Enum98.ayD:
			pictureBox.Image = GeneralResources.ChecklistCross;
			break;
		}
	}

	private void method_23(object sender, EventArgs e)
	{
		if (BUk == null || BUM == null)
		{
			return;
		}
		if (InvokeRequired)
		{
			try
			{
				Delegate9 method = method_23;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (BUk.method_256() == 0)
		{
			BUM.Text = Class333.BeI();
		}
		else
		{
			BUM.Text = Class333.BeJ();
		}
	}

	private void BUM_Click(object sender, EventArgs e)
	{
		if (BUk == null)
		{
			return;
		}
		if (BUk.method_256() == 0)
		{
			if (BUK.method_14() != null)
			{
				BUK.method_14().method_7(bool_0: false);
			}
			foreach (Class259 item in BUK.method_16())
			{
				item.method_7(bool_0: false);
			}
			BUK.method_0();
			BUk.method_272(1, bool_0: true);
			Form23.smethod_74(BUk.method_64());
			return;
		}
		BUk.method_272(0, bool_0: true);
		Form23.smethod_74(BUk.method_64());
		if (BUK.method_14() != null && !string.IsNullOrEmpty(BUK.method_14().method_2()))
		{
			if (Form54.smethod_6(Form23.form23_0, BUK.method_14().method_2(), Class333.smethod_2153(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				BUK.method_14().method_5(Class333.Bej());
			}
			else
			{
				BUK.method_14().method_5(Class333.BeK());
			}
			BUK.method_14().method_7(bool_0: true);
			return;
		}
		foreach (Class259 item2 in BUK.method_16())
		{
			if (!string.IsNullOrEmpty(item2.method_2()))
			{
				if (Form54.smethod_6(Form23.form23_0, item2.method_2(), Class333.smethod_2153(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					item2.method_5(Class333.Bej());
				}
				else
				{
					item2.method_5(Class333.BeK());
				}
				item2.method_7(bool_0: true);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			BUK.method_4(method_15);
			if (BUk != null)
			{
				BUk.method_265(method_23);
			}
			if (BUM != null)
			{
				BUM.Click -= BUM_Click;
				if (BUk != null && BUk.method_256() != 0)
				{
					BUk.method_272(0, bool_0: true);
					Form23.smethod_74(BUk.method_64());
				}
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
