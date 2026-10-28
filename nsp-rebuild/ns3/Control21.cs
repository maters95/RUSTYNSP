using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns3;

internal class Control21 : Control19
{
	private delegate void Delegate70(object sender, EventArgs e);

	private delegate void Delegate71(object sender, EventArgs e);

	private delegate void Delegate72(object sender, EventArgs e);

	internal const int BWy = 100;

	internal const int BWZ = 160;

	internal const int BWz = 220;

	internal const int BwA = 320;

	internal const int Bwa = 60;

	internal const int BwB = 100;

	internal const int Bwb = 180;

	internal const int BwC = 300;

	internal const int Bwc = 200;

	internal const int BwD = 120;

	internal const int Bwd = 120;

	private Setting BwE;

	private Setting Bwe;

	private Setting BwF;

	private Setting Bwf;

	private bool BwG;

	private Label Bwg = new Label();

	private Label BwH = new Label();

	private ThemedButton Bwh;

	private bool BwI;

	private bool Bwi;

	private Timer BwJ = new Timer();

	private bool Bwj;

	private bool BwK;

	private bool Bwk;

	private bool BwL;

	private bool Bwl;

	private bool BwM;

	[SpecialName]
	internal int method_8()
	{
		return Bwg.Width;
	}

	internal Control21(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_2, bool bool_3, bool bool_4)
	{
		method_9(dataIdAndAttrId_1, framework_2, framework_3, class286_0, bool_2, bool_3, bool_4);
		BwJ.Interval = 400;
		BwJ.Tick += BwJ_Tick;
	}

	private void method_9(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_2, bool bool_3, bool bool_4)
	{
		vmethod_0(framework_2, framework_3);
		vmethod_1(dataIdAndAttrId_1);
		if (setting_0.method_98() != 0)
		{
			BwE = framework_0.method_31(setting_0.method_98());
			BwF = framework_0.method_31(BwE.method_256());
		}
		if (framework_1 != null && setting_1 != null && setting_1.method_98() != 0)
		{
			Bwe = framework_1.method_31(setting_1.method_98());
			Bwf = framework_1.method_31(Bwe.method_256());
		}
		BNQ = class286_0;
		if (BNQ != null)
		{
			BNq = bool_2;
			Bwi = bool_3;
			int[] array = BNQ.method_3(setting_0);
			if (array != null && array.Length == 1)
			{
				BNR = array[0];
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
		Form23.form23_0.method_9(method_17);
		BwG = setting_0.method_70() != 0;
		BNp = false;
		Bwg.Font = new Font(Bwg.Font.FontFamily, 8.25f, Bwg.Font.Style);
		BwH.Font = new Font(BwH.Font.FontFamily, 8.25f, BwH.Font.Style);
		BNP.Font = new Font(BNP.Font.FontFamily, 8.25f, BNP.Font.Style);
		SuspendLayout();
		bool flag2;
		if (flag2 = Form23.enum60_0 == Form23.Enum60.BpF && (bool_0 || bool_1) && framework_1 != null)
		{
			Bwg.Text = Class333.Bci() + setting_0.method_22(bool_0: true) + Class333.smethod_180();
		}
		else if (flag)
		{
			Bwg.Text = Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO();
		}
		else if (BNQ != null && setting_0.method_78() && Bwi && !string.IsNullOrEmpty(setting_0.method_80()))
		{
			Bwg.Text = setting_0.method_80();
		}
		else
		{
			Bwg.Text = setting_0.method_22(bool_0: false);
		}
		BwI = bool_4;
		BNP.Width = method_11();
		Bwg.Left = 0;
		Bwg.Top = 3;
		if (BwI)
		{
			Bwg.AutoSize = true;
			Bwg.MinimumSize = new Size(60, 0);
			Bwg.MaximumSize = new Size(0, 0);
			BNP.Left = 0;
			BNP.Top = Bwg.Top + 14;
		}
		else
		{
			Bwg.Height = 16;
			Bwg.Width = method_10();
			BNP.Left = Bwg.Right + 10;
			BNP.Top = 0;
		}
		list.Add(Bwg);
		if (!Controls.Contains(Bwg))
		{
			Controls.Add(Bwg);
		}
		if (BwG && setting_0.method_242()[2] > 32)
		{
			BNP.MinimumSize = new Size(300, 200);
			BNP.MaximumSize = BNP.MinimumSize;
			BNP.Multiline = true;
		}
		if (!flag && !flag2)
		{
			BNP.Tag = setting_0.method_198().BYl;
			BNP.GotFocus += method_16;
			BNP.KeyDown += method_21;
			BNP.KeyPress += method_22;
			BNP.Leave += method_23;
			setting_0.method_264(method_24);
			setting_0.method_40(method_18);
			list.Add(BNP);
			if (!Controls.Contains(BNP))
			{
				Controls.Add(BNP);
			}
			if (BwE != null)
			{
				BwE.method_264(method_25);
				BwE.method_40(method_18);
			}
			MouseEnter += vmethod_4;
			Bwg.MouseEnter += vmethod_4;
			BNP.MouseEnter += vmethod_4;
			BwH.MouseEnter += vmethod_4;
			pictureBox_0.MouseEnter += vmethod_4;
			BNP.MouseLeave += vmethod_5;
			MouseLeave += vmethod_5;
		}
		AutoSize = false;
		bool flag3;
		if (flag3 = framework_1 != null && (bool_0 || bool_1))
		{
			if (BwI)
			{
				Width = TextRenderer.MeasureText(Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO(), Bwg.Font).Width;
			}
			else
			{
				Width = method_10() + 10 + method_11() + 10 + 120;
			}
		}
		if (BwI)
		{
			if (flag3)
			{
				Height = 17 + BNP.Height;
			}
			else
			{
				Width = Bwg.Width;
				Height = BNP.Bottom;
			}
		}
		else if (flag3)
		{
			Height = BNP.Height;
		}
		else
		{
			Width = BNP.Right;
			Height = BNP.Height;
		}
		if (!flag && !flag2)
		{
			if (!BwG)
			{
				if (BwI)
				{
					BwH.Left = BNP.Right + 5;
					BwH.Top = BNP.Top + 3;
					BwH.Height = 16;
					BwH.Width = 55;
					list.Add(BwH);
					if (!Controls.Contains(BwH))
					{
						Controls.Add(BwH);
					}
				}
				else
				{
					BwH.Left = BNP.Right + 10;
					BwH.Top = 3;
					BwH.Height = 16;
					BwH.Width = 120;
					list.Add(BwH);
					if (!Controls.Contains(BwH))
					{
						Controls.Add(BwH);
					}
					if (!flag3)
					{
						Width = BwH.Right;
					}
				}
				if (setting_0.method_198().BYl != 0)
				{
					if (Bwh == null)
					{
						Bwh = new ThemedButton();
						Bwh.Click += Bwh_Click;
					}
					Bwh.Text = setting_0.method_198().BYM;
					Bwh.Left = BwH.Right + 5;
					Bwh.Top = 0;
					Bwh.Height = BNP.Height;
					Bwh.Width = 120;
					list.Add(Bwh);
					if (!Controls.Contains(Bwh))
					{
						Controls.Add(Bwh);
					}
					if (!flag3)
					{
						Width = Bwh.Right;
					}
				}
			}
			pictureBox_0.Tag = setting_0;
			pictureBox_0.Width = 18;
			pictureBox_0.Height = 18;
			pictureBox_0.Left = Width;
			pictureBox_0.Top = 1;
			pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox_0.Click += method_15;
			list.Add(pictureBox_0);
			if (!Controls.Contains(pictureBox_0))
			{
				Controls.Add(pictureBox_0);
			}
			if (!flag3)
			{
				Width = Math.Max(pictureBox_0.Right, BwH.Right);
			}
			pictureBox_0.Visible = false;
		}
		for (int num = Controls.Count - 1; num >= 0; num--)
		{
			if (!list.Contains(Controls[num]))
			{
				Controls.RemoveAt(num);
			}
		}
		method_13();
		method_26();
		ResumeLayout(performLayout: true);
	}

	private int method_10()
	{
		if (string.IsNullOrWhiteSpace(Bwg.Text))
		{
			return 2;
		}
		int width = TextRenderer.MeasureText(Bwg.Text, Bwg.Font).Width;
		if (width < 100)
		{
			return 100;
		}
		if (width < 160)
		{
			return 160;
		}
		if (width < 220)
		{
			return 220;
		}
		if (width < 320)
		{
			return 320;
		}
		return width;
	}

	private int method_11()
	{
		if (BwG)
		{
			if (setting_0.method_242()[2] <= 32)
			{
				return 180;
			}
			return 300;
		}
		if (BwI)
		{
			return 60;
		}
		bool flag = false;
		int num = 0;
		int num2 = 0;
		if (BwF != null)
		{
			num = BwF.method_228();
			num2 = BwF.method_229();
			if (num != 0 || num2 != 0)
			{
				int int_ = BwF.method_231();
				string text = Class233.smethod_29(num, int_);
				string text2 = Class233.smethod_29(num2, int_);
				flag = text.Length * 6 <= 53 && text2.Length * 6 <= 53;
			}
		}
		else
		{
			if (BNQ != null && setting_0.method_78() && Bwi)
			{
				num = setting_0.method_222();
				num2 = setting_0.method_223();
			}
			if (num == 0 && num2 == 0)
			{
				num = setting_0.method_228();
				num2 = setting_0.method_229();
			}
			if (num != 0 || num2 != 0)
			{
				int int_2 = setting_0.method_231();
				int int_3 = setting_0.method_100();
				string text3 = Class233.smethod_29(num, int_2, int_3);
				string text4 = Class233.smethod_29(num2, int_2, int_3);
				flag = text3.Length * 6 <= 53 && text4.Length * 6 <= 53;
			}
			if (flag && setting_2 != null)
			{
				num = setting_2.method_228();
				num2 = setting_2.method_229();
				if (num != 0 || num2 != 0)
				{
					int int_4 = setting_2.method_231();
					int int_5 = setting_2.method_100();
					string text5 = Class233.smethod_29(num, int_4, int_5);
					string text6 = Class233.smethod_29(num2, int_4, int_5);
					flag = text5.Length * 6 <= 53 && text6.Length * 6 <= 53;
				}
			}
		}
		if (flag)
		{
			return 60;
		}
		return 100;
	}

	internal void method_12(int int_1)
	{
		if (BwI)
		{
			return;
		}
		int num = int_1 - Bwg.Width;
		if (num > 0)
		{
			Bwg.Width += num;
			BNP.Left += num;
			BwH.Left += num;
			if (Bwh != null)
			{
				Bwh.Left += num;
			}
			pictureBox_0.Left += num;
			Width += num;
		}
	}

	private void method_13()
	{
		if (setting_0.method_35() && framework_0.method_4())
		{
			Bwg.ForeColor = Form23.color_12;
			BwH.ForeColor = Form23.color_12;
		}
		else
		{
			Bwg.ForeColor = Form23.color_36;
			BwH.ForeColor = Form23.color_36;
		}
		bool flag;
		if (Form23.enum60_0 == Form23.Enum60.BpG && setting_1 != null)
		{
			flag = false;
			BNP.Text = method_19(setting_1);
		}
		else
		{
			flag = setting_0.method_35() && framework_0.method_4();
			BNP.Text = method_19(setting_0);
		}
		if (Bwh != null)
		{
			Bwh.Enabled = flag;
		}
		if (flag && !setting_0.method_122())
		{
			BNP.Enabled = true;
			if (Form48.smethod_2() && setting_0.method_64() == 1501 && string.IsNullOrEmpty(setting_0.method_260()))
			{
				BNP.BackColor = Form23.color_32;
				pictureBox_0.Visible = false;
				pictureBox_0.Image = GeneralResources.QuestionMark;
			}
			else
			{
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
		}
		else
		{
			BNP.Enabled = flag;
			bool flag2 = bool_0 || bool_1;
			if (setting_1 != null && !flag2 && !setting_0.method_282(setting_1))
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
		if (Bwh != null)
		{
			Bwh.TabStop = TabStop;
		}
		BNP.Invalidate();
		method_14();
	}

	private void method_14()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			if (Bwf != null)
			{
				int int_ = Bwf.method_231();
				BwH.Text = Class233.smethod_35(Bwf.method_232(), int_, bool_0: false, 0);
			}
			else if (setting_1 != null)
			{
				int int_2 = setting_1.method_231();
				int int_3 = setting_1.method_100();
				BwH.Text = Class233.smethod_35(setting_1.method_232(), int_2, bool_0: false, setting_1.method_256(), int_3);
			}
			else
			{
				int int_4 = setting_0.method_231();
				int int_5 = setting_0.method_100();
				BwH.Text = Class233.smethod_35(setting_0.method_232(), int_4, bool_0: false, setting_0.method_256(), int_5);
			}
		}
		else if (BwF != null)
		{
			int int_6 = BwF.method_231();
			BwH.Text = Class233.smethod_35(BwF.method_232(), int_6, bool_0: false, 0);
		}
		else
		{
			int int_7 = setting_0.method_231();
			int int_8 = setting_0.method_100();
			BwH.Text = Class233.smethod_35(setting_0.method_232(), int_7, bool_0: false, setting_0.method_256(), int_8);
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		Form23.smethod_50(setting_0, this);
	}

	private void method_16(object sender, EventArgs e)
	{
		Form23.form23_0.control4_0.method_59(setting_0);
		if (framework_1 != null)
		{
			if (BNP.BackColor == Form23.color_9)
			{
				Form23.smethod_50(setting_0, this);
			}
		}
		else
		{
			if (!BwG || !BNP.Enabled || setting_0.method_64() != 1501 || !string.IsNullOrEmpty(BNP.Text) || Bwj || !Form23.smethod_28(framework_0.aXc, bool_53: true))
			{
				return;
			}
			string text = Form23.smethod_98(framework_0.aXc);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			string text2 = new DirectoryInfo(text).Name;
			int num = text2.IndexOf('_');
			if (num != -1)
			{
				text2 = text2.Substring(0, num);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				BNP.GotFocus -= method_16;
				Bwj = true;
				if (Form54.smethod_6(Form23.form23_0, Class333.aBt() + text2 + Class333.aBU() + text2 + Class333.smethod_2378(), Class333.aBu(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					BNP.Text = text2;
					method_20(bool_2: false);
					framework_0.aXD = text;
				}
				Bwj = false;
			}
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		if (!bool_0 && !bool_1)
		{
			method_13();
		}
		else
		{
			vmethod_8();
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate70 method = method_18;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_13();
	}

	private string method_19(Setting setting_5)
	{
		if (setting_5.method_70() != 0)
		{
			return setting_5.method_260();
		}
		int num = setting_5.method_256();
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			if (setting_1 != null && Bwf != null)
			{
				return Class233.smethod_29(num, Bwf.method_231());
			}
		}
		else if (BwF != null)
		{
			return Class233.smethod_29(num, BwF.method_231());
		}
		int num2 = setting_5.method_221();
		if (num2 > 1)
		{
			num = Class23.smethod_12(num, num2);
		}
		if (BNQ != null && setting_5.method_78() && Bwi)
		{
			num -= BNR;
			if (setting_5.method_84())
			{
				int num3 = setting_5.method_228();
				int num4 = setting_5.method_229();
				int num5 = setting_5.method_222();
				int num6 = setting_5.method_223();
				if (num > num6)
				{
					num -= num4 + 1 - num3;
				}
				else if (num < num5)
				{
					num += num4 + 1 - num3;
				}
			}
		}
		int int_ = setting_5.method_100();
		return Class233.smethod_29(num, setting_5.method_231(), int_);
	}

	internal void method_20(bool bool_2)
	{
		if (BNP.Disposing || Form23.bool_2 || Form23.enum60_0 == Form23.Enum60.BpG || Form23.bool_35)
		{
			return;
		}
		string text = BNP.Text;
		BNp = false;
		string text2 = method_19(setting_0);
		if (text2 == text && (!Bwk || bool_2))
		{
			return;
		}
		Bwk = bool_2;
		if (BwG && setting_0.method_64() == 1501 && !Bwj && !bool_2)
		{
			Bwj = true;
			Form23.smethod_102(text2, text, framework_0);
			Bwj = false;
		}
		if (string.IsNullOrWhiteSpace(text) && !BwG)
		{
			BNP.Text = text2;
		}
		else if (setting_0.method_25())
		{
			if (!BwG)
			{
				try
				{
					int num;
					int num2;
					if (BwF != null)
					{
						num = BwF.method_228();
						num2 = BwF.method_229();
					}
					else
					{
						num = setting_0.method_228();
						num2 = setting_0.method_229();
					}
					int int_ = setting_0.method_100();
					int num6;
					if (BNQ != null && setting_0.method_78() && Bwi)
					{
						int num3 = Class233.smethod_25(text, setting_0.method_231(), int_);
						int num4 = setting_0.method_222();
						int num5 = setting_0.method_223();
						if (num4 != 0 || num5 != 0)
						{
							num3 = Math.Min(num5, Math.Max(num4, num3));
						}
						num6 = num3 + BNR;
						if (setting_0.method_84() && (num != 0 || num2 != 0))
						{
							num6 = (num6 - (num2 + 1)) % (num2 + 1 - num) + num;
							if (num6 < num)
							{
								num6 += num2 + 1 - num;
							}
							else if (num6 > num2)
							{
								num6 -= num2 + 1 - num;
							}
						}
					}
					else
					{
						num6 = ((BwF == null) ? Class233.smethod_25(text, setting_0.method_231(), int_) : Class233.smethod_25(text, BwF.method_231()));
						if (setting_0.method_199() == 2)
						{
							if (setting_0.method_201())
							{
								if (num6 < -32768)
								{
									num6 = -32768;
								}
								else if (num6 > 32767)
								{
									num6 = 32767;
								}
							}
							else if (num6 < 0)
							{
								num6 = 0;
							}
							else if (num6 > 65535)
							{
								num6 = 65535;
							}
						}
						else if (setting_0.method_199() == 1)
						{
							if (setting_0.method_201())
							{
								if (num6 < -128)
								{
									num6 = -128;
								}
								else if (num6 > 127)
								{
									num6 = 127;
								}
							}
							else if (num6 < 0)
							{
								num6 = 0;
							}
							else if (num6 > 255)
							{
								num6 = 255;
							}
						}
					}
					if (BwF == null)
					{
						int num7 = setting_0.method_221();
						if (num7 > 1)
						{
							num6 = Class23.smethod_12(num6, num7);
						}
					}
					if (num != 0 || num2 != 0)
					{
						num6 = Math.Min(Math.Max(num6, num), num2);
					}
					Class280 @class = Form23.smethod_95();
					@class?.method_3(setting_0.method_69());
					setting_0.method_272(num6, bool_0: true);
					@class?.method_4();
					Form23.smethod_75(setting_0.method_69());
					return;
				}
				catch
				{
					BwK = true;
					Form54.smethod_6(Form23.form23_0, Class333.smethod_605(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					BwK = false;
					BNP.Text = text2;
					return;
				}
			}
			Class280 class2 = Form23.smethod_95();
			if (!bool_2)
			{
				class2?.method_3(setting_0.method_69());
			}
			setting_0.method_262(text, bool_0: true);
			if (!bool_2)
			{
				class2?.method_4();
			}
			Form23.smethod_75(setting_0.method_69());
		}
		else
		{
			BNP.Text = text2;
		}
	}

	private void method_21(object sender, KeyEventArgs e)
	{
		if (BwG)
		{
			bool flag = Encoding.GetEncoding(setting_0.method_70()).GetBytes(BNP.Text).Length >= setting_0.method_242()[2];
			if (BNP.Multiline)
			{
				if (e.KeyData == (Keys.Return | Keys.Shift))
				{
					if (flag)
					{
						BwM = true;
					}
				}
				else if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Return)
				{
					if (flag && e.KeyCode != Keys.Back)
					{
						BwM = true;
					}
				}
				else
				{
					Bwl = true;
					e.Handled = true;
					method_20(bool_2: false);
				}
			}
			else if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Return)
			{
				if (flag && e.KeyCode != Keys.Back)
				{
					BwM = true;
				}
			}
			else
			{
				method_20(bool_2: false);
			}
		}
		else if ((!e.Control || e.KeyCode != Keys.Prior) && e.KeyData != Keys.Prior && (!e.Shift || e.KeyCode != Keys.Prior) && (!e.Control || e.KeyCode != Keys.Next) && e.KeyData != Keys.Next && (!e.Shift || e.KeyCode != Keys.Next))
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
				method_20(bool_2: false);
			}
		}
		else
		{
			BwL = true;
			e.Handled = true;
		}
		BwJ.Stop();
		BwJ.Start();
	}

	private void method_22(object sender, KeyPressEventArgs e)
	{
		if (BwL)
		{
			e.Handled = true;
			BwL = false;
			BNp = false;
		}
		else if (BwG)
		{
			if (BNP.Multiline && Bwl)
			{
				e.Handled = true;
				Bwl = false;
			}
			else if (BwM)
			{
				e.Handled = true;
				BwM = false;
			}
		}
		else if (e.KeyChar == '.')
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

	private void BwJ_Tick(object sender, EventArgs e)
	{
		BwJ.Stop();
		if (BwG && setting_0 != null && Form48.smethod_2() && setting_0.method_64() == 1501)
		{
			method_20(bool_2: true);
		}
	}

	private void method_23(object sender, EventArgs e)
	{
		if (!BwK && !Bwj)
		{
			method_20(bool_2: false);
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate71 method = method_24;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_26();
		if (Form23.enum60_0 != Form23.Enum60.BpG && !BNp)
		{
			int selectionStart = BNP.SelectionStart;
			int selectionLength = BNP.SelectionLength;
			string text = method_19(setting_0);
			if (BNP.Text != text)
			{
				BNP.Text = text;
			}
			BNP.SelectionStart = selectionStart;
			BNP.SelectionLength = selectionLength;
			if (setting_1 != null)
			{
				method_13();
			}
		}
	}

	private void method_25(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate72 method = method_25;
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
			int num = BwE.method_256();
			if (BwF == null || num != BwF.method_64())
			{
				BwF = framework_0.method_31(num);
				Form23.smethod_75(BwE.method_69());
				method_13();
			}
		}
	}

	private void method_26()
	{
		FontStyle fontStyle = FontStyle.Regular;
		if (BNQ != null && !BwG && BNq)
		{
			Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
			if (setting.method_256() != BNR)
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
		if (Bwg.Font.Style != fontStyle)
		{
			Font font2 = Bwg.Font;
			Bwg.Font = new Font(Bwg.Font.FontFamily, Bwg.Font.Size, fontStyle);
			font2.Dispose();
		}
	}

	private void Bwh_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			int num = (int)BNP.Tag;
			Setting setting = framework_0.method_31(num);
			BNP.Text = Class233.smethod_29(setting.method_256(), setting_0.method_231());
			method_20(bool_2: false);
		}
	}

	[SpecialName]
	internal ThemedButton method_27()
	{
		return Bwh;
	}

	public override string ToString()
	{
		return setting_0.method_22(bool_0: true);
	}

	internal bool method_28(KeyEventArgs keyEventArgs_0)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return false;
		}
		if (!BwG && ((keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Prior) || keyEventArgs_0.KeyData == Keys.Prior || (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Prior) || (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Next) || keyEventArgs_0.KeyData == Keys.Next || (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Next)))
		{
			BNp = false;
			int int_;
			int num;
			int num2;
			if (BwF != null)
			{
				int_ = BwF.method_231();
				num = BwF.method_228();
				num2 = BwF.method_229();
			}
			else
			{
				int_ = setting_0.method_231();
				num = setting_0.method_228();
				num2 = setting_0.method_229();
			}
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
				int int_2 = setting_0.method_100();
				if (BNQ != null && setting_0.method_78() && Bwi)
				{
					int val = num4 - BNR;
					int num5 = setting_0.method_222();
					int num6 = setting_0.method_223();
					if (num5 != 0 || num6 != 0)
					{
						val = Math.Min(num6, Math.Max(num5, val));
					}
					BNP.Text = Class233.smethod_29(val, int_, int_2);
					method_20(bool_2: false);
				}
				else
				{
					if (num != 0 || num2 != 0)
					{
						num4 = Math.Min(num2, Math.Max(num, num4));
					}
					if (num4 != num3)
					{
						BNP.Text = Class233.smethod_29(num4, int_, int_2);
						method_20(bool_2: false);
					}
				}
			}
			return true;
		}
		return false;
	}

	protected override void vmethod_8()
	{
		method_29();
		int width = Bwg.Width;
		if (Parent != null)
		{
			Parent.SuspendLayout();
		}
		method_9(dataIdAndAttrId_0, framework_0, framework_1, BNQ, BNq, Bwi, BwI);
		method_12(Math.Max(width, Bwg.Width));
		if (Parent != null)
		{
			Parent.ResumeLayout(performLayout: true);
		}
	}

	private void method_29()
	{
		try
		{
			if (Bwh != null)
			{
				Bwh.Click -= Bwh_Click;
			}
			BNP.GotFocus -= method_16;
			BNP.KeyDown -= method_21;
			BNP.KeyPress -= method_22;
			BNP.Leave -= method_23;
			MouseEnter -= vmethod_4;
			Bwg.MouseEnter -= vmethod_4;
			BNP.MouseEnter -= vmethod_4;
			BwH.MouseEnter -= vmethod_4;
			pictureBox_0.MouseEnter -= vmethod_4;
			BNP.MouseLeave -= vmethod_5;
			MouseLeave -= vmethod_5;
			pictureBox_0.Click -= method_15;
			setting_0.method_265(method_24);
			setting_0.method_41(method_18);
			if (BwE != null)
			{
				BwE.method_265(method_25);
				BwE.method_41(method_18);
			}
			if (setting_3 != null)
			{
				setting_3.method_41(vmethod_6);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(vmethod_7);
			}
			Form23.form23_0.method_10(method_17);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_29();
		if (Form23.pictureBox_1 == pictureBox_0)
		{
			Form23.pictureBox_1 = null;
		}
		BwJ.Tick -= BwJ_Tick;
		BwJ.Dispose();
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
