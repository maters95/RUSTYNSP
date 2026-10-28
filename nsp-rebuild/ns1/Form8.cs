using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Form8 : Form6
{
	private class Class208
	{
		private const int BxW = 295;

		private const int Bxw = 475;

		private Form8 BxX;

		private int Bxx;

		private int BxY;

		private int Bxy;

		private int BxZ;

		private int Bxz;

		private int BYA;

		private int BYa;

		private int BYB;

		private bool BYb;

		private bool BYC;

		private bool BYc;

		private bool BYD;

		private int BYd;

		private List<Connector> BYE = new List<Connector>();

		private int BYe;

		private bool BYF;

		private bool BYf;

		internal Class208(Form8 form8_0)
		{
			BxX = form8_0;
		}

		internal void method_0()
		{
			try
			{
				BxY = 1;
				Bxy = 0;
				BxZ = 0;
				Bxz = 0;
				BYA = 0;
				BYa = 0;
				BYB = 0;
				BYb = false;
				BYC = false;
				BYc = false;
				BYD = false;
				BYd = 0;
				BYE.Clear();
				BYe = 0;
				BYF = false;
				BYf = false;
				PrintDialog printDialog = new PrintDialog();
				PrintDocument printDocument = new PrintDocument();
				printDocument.PrintPage += method_1;
				PageSettings pageSettings = new PageSettings();
				pageSettings.Landscape = false;
				pageSettings.Margins = new Margins(50, 50, 50, 50);
				printDocument.DefaultPageSettings = pageSettings;
				printDocument.PrinterSettings = printDialog.PrinterSettings;
				if (printDialog.ShowDialog(BxX) == DialogResult.OK)
				{
					printDocument.Print();
				}
				printDialog.Dispose();
			}
			catch (Exception)
			{
				Form54.smethod_6(BxX, Class333.BhH(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void method_1(object sender, PrintPageEventArgs e)
		{
			e.Graphics.Clear(Color.White);
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			int num = e.MarginBounds.Top;
			int left = e.MarginBounds.Left;
			using (Font font = new Font(BxX.Font.FontFamily, 12f, FontStyle.Bold))
			{
				string text = Class333.Bhh() + BxY;
				int num2 = (int)e.Graphics.MeasureString(text, font).Height;
				e.Graphics.DrawString(text, font, Brushes.Black, left + 3, num);
				num += num2 + 5;
				using Font font2 = new Font(BxX.Font.FontFamily, 12f, FontStyle.Regular);
				string string_ = string.Empty;
				if (Form23.framework_1.method_28(ref string_) && !string.IsNullOrEmpty(string_))
				{
					e.Graphics.DrawString(Class333.BhI(), font2, Brushes.Black, left + 3, num);
					num2 = (int)e.Graphics.MeasureString(string_, font).Height;
					e.Graphics.DrawString(string_, font, Brushes.Black, left + 140, num);
					num += num2 + 2;
				}
				string text2 = Form23.framework_1.awy;
				if (text2.EndsWith(Class333.smethod_190()))
				{
					text2 = text2.Substring(0, text2.Length - 1);
				}
				e.Graphics.DrawString(Class333.agM(), font2, Brushes.Black, left + 3, num);
				num2 = (int)e.Graphics.MeasureString(text2, font).Height;
				e.Graphics.DrawString(text2, font, Brushes.Black, left + 140, num);
				num += num2 + 15;
			}
			Bxx = num;
			if (!method_2(e.Graphics, e.MarginBounds))
			{
				BxY++;
				e.HasMorePages = true;
			}
		}

		private bool method_2(Graphics graphics_0, Rectangle rectangle_0)
		{
			if (BxX.method_18() == Enum51.BOq)
			{
				method_3(graphics_0, rectangle_0);
			}
			else if (BxX.method_18() == Enum51.BOQ)
			{
				if (BxX.bool_2)
				{
					bool bool_ = false;
					method_4(graphics_0, rectangle_0, ref bool_);
					if (bool_)
					{
						return false;
					}
				}
				if (BxX.bool_3)
				{
					method_5(graphics_0, rectangle_0);
				}
			}
			if (BxX.method_18() == Enum51.BOQ && ((BYb && BYc) || !BxX.bool_2) && ((BYC && BYD) || !BxX.bool_3))
			{
				return true;
			}
			if (BxX.method_18() == Enum51.BOq)
			{
				return BYf;
			}
			return false;
		}

		private void method_3(Graphics graphics_0, Rectangle rectangle_0)
		{
			int left = rectangle_0.Left;
			int width = rectangle_0.Width;
			if (!BYF)
			{
				using (Font font = new Font(BxX.Font.FontFamily, 8f, FontStyle.Bold))
				{
					graphics_0.DrawString(Class333.smethod_873(), font, Brushes.Black, left + 10, Bxx + 6);
					graphics_0.DrawString(Class333.smethod_874(), font, Brushes.Black, left + 475, Bxx + 6);
				}
				Bxx += 25;
				graphics_0.DrawLine(Pens.Black, left, Bxx, left + width, Bxx);
				BYF = true;
			}
			if (BYf)
			{
				return;
			}
			for (int i = BYd; i < PortFunction.smethod_5().Length; i++)
			{
				Enum104 @enum = PortFunction.smethod_5()[i];
				if (Form23.framework_1.awb.ContainsKey(@enum))
				{
					string text = PortFunction.smethod_1(@enum, Form23.framework_1);
					string text2 = PortFunction.smethod_2(@enum, Form23.framework_1);
					if (!string.IsNullOrEmpty(text))
					{
						text2 = text + Class333.smethod_497() + text2 + Class333.smethod_875();
					}
					bool flag = true;
					foreach (Connector item in Form23.framework_1.awb[@enum])
					{
						if (BYE.Contains(item))
						{
							continue;
						}
						int bxx = Bxx;
						Bxx += 35;
						bool bool_ = false;
						bool bool_2 = false;
						for (int j = BYe; j < item.ayS.Count; j++)
						{
							WiringPin wiringPin = item.ayS.Values[j];
							if (!wiringPin.Bbq.method_35())
							{
								continue;
							}
							List<WiringPin.Class276> list = wiringPin.method_4();
							if (list.Count == 0)
							{
								BYe++;
								continue;
							}
							Enum104 bsk = list[list.Count - 1].Bsk;
							Enum105 bsL = list[list.Count - 1].BsL;
							byte bsl = list[list.Count - 1].Bsl;
							ushort bsM = list[list.Count - 1].BsM;
							SettingOrSpecialObject settingOrSpecialObject = PortFunction.smethod_36(Form23.framework_1, bsk, bsL, bsl, bsM);
							if (settingOrSpecialObject != null && settingOrSpecialObject.method_35() && bsL != Enum105.BaF && BxX.method_15(bsk, bsL))
							{
								List<bool> list_ = new List<bool>();
								List<string> list2 = PortFunction.smethod_45(Form23.framework_1, bsk, bsL, bsl, bsM, bool_0: true, list_);
								if (list2 == null)
								{
									string text3 = PortFunction.smethod_47(Form23.framework_1, bsk, bsL, bsl, bsM);
									if (text3 != null)
									{
										list2 = new List<string> { text3 };
									}
								}
								if ((BxX.bool_2 && list2 != null) || (BxX.bool_3 && list2 == null))
								{
									method_7(graphics_0, rectangle_0, bool_0: true, settingOrSpecialObject, list2, wiringPin, bsk, bsL, bsl, bsM, ref bool_, ref bool_2);
									if (bool_2)
									{
										break;
									}
								}
								else
								{
									BYe++;
								}
							}
							else
							{
								BYe++;
							}
						}
						if (!bool_)
						{
							Bxx -= 35;
						}
						else
						{
							using (Font font2 = new Font(BxX.Font.FontFamily, 8f))
							{
								graphics_0.DrawString(item.ayr + Class333.smethod_876() + text2 + Class333.smethod_134(), font2, Brushes.Black, left + 10, bxx + 20);
							}
							graphics_0.DrawLine(Pens.Black, left, bxx + 35, left + width, bxx + 35);
						}
						if (!bool_2)
						{
							BYe = 0;
							BYE.Add(item);
							continue;
						}
						flag = false;
						break;
					}
					if (!flag)
					{
						break;
					}
					BYe = 0;
					BYd++;
					BYE.Clear();
					BYf = BYd == PortFunction.smethod_5().Length;
				}
				else
				{
					BYe = 0;
					BYd++;
					BYE.Clear();
					BYf = BYd == PortFunction.smethod_5().Length;
				}
			}
		}

		private void method_4(Graphics graphics_0, Rectangle rectangle_0, ref bool bool_0)
		{
			int left = rectangle_0.Left;
			int width = rectangle_0.Width;
			if (!BYb)
			{
				using (Font font = new Font(BxX.Font.FontFamily, 12f, FontStyle.Bold))
				{
					graphics_0.DrawString(Class333.smethod_877(), font, Brushes.Black, left + 10, Bxx);
				}
				Bxx += 30;
				using (Font font2 = new Font(BxX.Font.FontFamily, 8f, FontStyle.Bold))
				{
					graphics_0.DrawString(Class333.smethod_873(), font2, Brushes.Black, left + 10, Bxx + 6);
					graphics_0.DrawString(Class333.smethod_874(), font2, Brushes.Black, left + 475, Bxx + 6);
				}
				Bxx += 25;
				graphics_0.DrawLine(Pens.Black, left, Bxx, left + width, Bxx);
				BYb = true;
			}
			if (BYc)
			{
				return;
			}
			for (int i = Bxy; i < PortFunction.smethod_5().Length; i++)
			{
				Enum104 @enum = PortFunction.smethod_5()[i];
				string text = PortFunction.smethod_1(@enum, Form23.framework_1);
				string text2 = PortFunction.smethod_2(@enum, Form23.framework_1);
				if (!string.IsNullOrEmpty(text))
				{
					text2 = text + Class333.smethod_497() + text2 + Class333.smethod_875();
				}
				bool flag = true;
				for (int j = Bxz; j < PortFunction.smethod_6().Length; j++)
				{
					Enum105 enum2 = PortFunction.smethod_6()[j];
					int bxx = Bxx;
					Bxx += 35;
					if (!method_6(bool_0: true, @enum, enum2, graphics_0, rectangle_0, out var bool_1))
					{
						Bxx -= 35;
					}
					else if (BxX.bool_5 || enum2 == BxX.enum105_0)
					{
						using (Font font3 = new Font(BxX.Font.FontFamily, 8f))
						{
							if (@enum == Enum104.BAM)
							{
								graphics_0.DrawString(PortFunction.smethod_4(enum2) + Class333.smethod_134(), font3, Brushes.Black, left + 10, bxx + 20);
							}
							else
							{
								graphics_0.DrawString(PortFunction.smethod_4(enum2) + Class333.smethod_876() + text2 + Class333.smethod_134(), font3, Brushes.Black, left + 10, bxx + 20);
							}
						}
						graphics_0.DrawLine(Pens.Black, left, bxx + 35, left + width, bxx + 35);
					}
					if (!bool_1)
					{
						BYa = 0;
						Bxz++;
						continue;
					}
					flag = false;
					break;
				}
				if (flag)
				{
					BYa = 0;
					Bxy++;
					Bxz = 0;
					bool bYc;
					if ((bYc = Bxy == PortFunction.smethod_5().Length) && !BYc)
					{
						bool_0 = true;
					}
					BYc = bYc;
					continue;
				}
				break;
			}
		}

		private void method_5(Graphics graphics_0, Rectangle rectangle_0)
		{
			int left = rectangle_0.Left;
			int width = rectangle_0.Width;
			if (!BYC && (BYc || !BxX.bool_2))
			{
				using (Font font = new Font(BxX.Font.FontFamily, 12f, FontStyle.Bold))
				{
					graphics_0.DrawString(Class333.smethod_878(), font, Brushes.Black, left + 10, Bxx);
				}
				Bxx += 30;
				using (Font font2 = new Font(BxX.Font.FontFamily, 8f, FontStyle.Bold))
				{
					graphics_0.DrawString(Class333.smethod_873(), font2, Brushes.Black, left + 10, Bxx + 6);
				}
				Bxx += 25;
				graphics_0.DrawLine(Pens.Black, left, Bxx, left + width, Bxx);
				BYC = true;
			}
			if (BYD || !BYC)
			{
				return;
			}
			for (int i = BxZ; i < PortFunction.smethod_5().Length; i++)
			{
				Enum104 @enum = PortFunction.smethod_5()[i];
				string text = PortFunction.smethod_1(@enum, Form23.framework_1);
				string text2 = PortFunction.smethod_2(@enum, Form23.framework_1);
				if (!string.IsNullOrEmpty(text))
				{
					text2 = text + Class333.smethod_497() + text2 + Class333.smethod_875();
				}
				bool flag = true;
				for (int j = BYA; j < PortFunction.smethod_6().Length; j++)
				{
					Enum105 enum2 = PortFunction.smethod_6()[j];
					int bxx = Bxx;
					Bxx += 35;
					if (!method_6(bool_0: false, @enum, enum2, graphics_0, rectangle_0, out var bool_))
					{
						Bxx -= 35;
					}
					else if (BxX.bool_5 || enum2 == BxX.enum105_0)
					{
						using (Font font3 = new Font(BxX.Font.FontFamily, 8f))
						{
							if (@enum == Enum104.BAM)
							{
								graphics_0.DrawString(PortFunction.smethod_4(enum2) + Class333.smethod_134(), font3, Brushes.Black, left + 10, bxx + 20);
							}
							else
							{
								graphics_0.DrawString(PortFunction.smethod_4(enum2) + Class333.smethod_876() + text2 + Class333.smethod_134(), font3, Brushes.Black, left + 10, bxx + 20);
							}
						}
						graphics_0.DrawLine(Pens.Black, left, bxx + 35, left + width, bxx + 35);
					}
					if (!bool_)
					{
						BYB = 0;
						BYA++;
						continue;
					}
					flag = false;
					break;
				}
				if (flag)
				{
					BYB = 0;
					BxZ++;
					BYA = 0;
					BYD = BxZ == PortFunction.smethod_5().Length;
					continue;
				}
				break;
			}
		}

		private bool method_6(bool bool_0, Enum104 enum104_0, Enum105 enum105_0, Graphics graphics_0, Rectangle rectangle_0, out bool bool_1)
		{
			bool bool_2 = false;
			bool_1 = false;
			int num = ((!bool_0) ? BYB : BYa);
			for (int i = num; i < Form23.framework_1.awD.Count; i++)
			{
				SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.awD[i];
				if (!settingOrSpecialObject.method_35())
				{
					if (bool_0)
					{
						BYa++;
					}
					else
					{
						BYB++;
					}
					continue;
				}
				Enum104 bSQ = settingOrSpecialObject.method_12().method_12().BSQ;
				Enum105 bSq = settingOrSpecialObject.method_12().method_12().BSq;
				byte bSR = settingOrSpecialObject.method_12().method_12().BSR;
				ushort bSr = settingOrSpecialObject.method_12().method_12().BSr;
				if (bSQ == enum104_0 && bSq == enum105_0 && BxX.method_15(bSQ, bSq))
				{
					List<bool> list_ = new List<bool>();
					List<string> list = PortFunction.smethod_45(Form23.framework_1, bSQ, bSq, bSR, bSr, !bool_0, list_);
					if (list == null)
					{
						string text = PortFunction.smethod_47(Form23.framework_1, bSQ, bSq, bSR, bSr);
						if (text != null)
						{
							list = new List<string> { text };
						}
					}
					if ((bool_0 && list != null) || (!bool_0 && list == null))
					{
						method_7(graphics_0, rectangle_0, bool_0, settingOrSpecialObject, list, null, bSQ, bSq, bSR, bSr, ref bool_2, ref bool_1);
						if (bool_1)
						{
							break;
						}
					}
					else if (bool_0)
					{
						BYa++;
					}
					else
					{
						BYB++;
					}
				}
				else if (bool_0)
				{
					BYa++;
				}
				else
				{
					BYB++;
				}
			}
			return bool_2;
		}

		private void method_7(Graphics graphics_0, Rectangle rectangle_0, bool bool_0, SettingOrSpecialObject settingOrSpecialObject_0, List<string> list_0, WiringPin wiringPin_0, Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0, ref bool bool_1, ref bool bool_2)
		{
			List<PictureBox> list = new List<PictureBox>();
			List<Label> list2 = new List<Label>();
			string text = string.Empty;
			List<WiringPin> list3 = WiringPin.smethod_0(Form23.framework_1, enum104_0, enum105_0, byte_0, ushort_0);
			if (enum105_0 != Enum105.Bal && list3.Count != 0)
			{
				bool bool_3 = list3.Count > 1;
				if (wiringPin_0 != null)
				{
					list3 = new List<WiringPin> { wiringPin_0 };
				}
				foreach (WiringPin item in list3)
				{
					PictureBox pictureBox = new PictureBox();
					pictureBox.Image = item.method_10();
					if (pictureBox.Image != null)
					{
						pictureBox.Height = pictureBox.Image.Height;
						pictureBox.Width = pictureBox.Image.Width;
					}
					else
					{
						pictureBox.Height = 35;
						pictureBox.Width = 100;
					}
					pictureBox.Left = rectangle_0.Left + 10;
					list.Add(pictureBox);
					Label label = new Label();
					label.Text = item.method_11(bool_3);
					label.Left = pictureBox.Right + 20;
					label.Top = list2.Count * label.Height;
					list2.Add(label);
					if (pictureBox.Height > 35)
					{
						pictureBox.Top = 2;
					}
					else
					{
						pictureBox.Top = label.Top - 3;
					}
					if (!string.IsNullOrEmpty(item.method_12()))
					{
						text = text + item.method_12() + Class333.smethod_885();
					}
				}
			}
			else
			{
				PictureBox pictureBox2 = new PictureBox();
				if (enum105_0 == Enum105.Bal)
				{
					pictureBox2.Image = WiringPin.smethod_3(Color.Transparent, Color.Transparent, bool_0: false, bool_1: true, bool_2: false);
				}
				else
				{
					pictureBox2.Image = PortFunction.smethod_8(enum104_0, enum105_0);
				}
				if (pictureBox2.Image != null)
				{
					pictureBox2.Height = pictureBox2.Image.Height;
					pictureBox2.Width = pictureBox2.Image.Width;
				}
				else
				{
					pictureBox2.Height = 35;
					pictureBox2.Width = 100;
				}
				pictureBox2.Left = rectangle_0.Left + 10;
				list.Add(pictureBox2);
				Label label2 = new Label();
				if (enum105_0 == Enum105.Bal)
				{
					label2.Text = Class333.smethod_883();
				}
				label2.Left = pictureBox2.Right + 20;
				label2.Top = 0;
				list2.Add(label2);
				if (pictureBox2.Height > 35)
				{
					pictureBox2.Top = 2;
				}
				else
				{
					pictureBox2.Top = label2.Top - 3;
				}
			}
			Label label3 = new Label();
			string text2 = PortFunction.smethod_37(settingOrSpecialObject_0);
			if (text2 != null)
			{
				label3.Text = text2;
				label3.Top = 0;
				label3.Left = rectangle_0.Left + 295;
			}
			Label label4 = null;
			if (!string.IsNullOrEmpty(text))
			{
				label4 = new Label();
				label4.Text = text;
				label4.ForeColor = Color.DarkOrange;
				label4.Left = 5;
				label4.Top = 5;
				label4.AutoSize = true;
			}
			List<Label> list4 = new List<Label>();
			if (list_0 != null)
			{
				foreach (string item2 in list_0)
				{
					Label label5 = new Label();
					label5.Text = item2;
					label5.Top = 0;
					label5.Left = rectangle_0.Left + 475;
					list4.Add(label5);
				}
			}
			List<string> list5 = new List<string>(list4.Count);
			foreach (Label item3 in list4)
			{
				list5.Add(item3.Text);
			}
			List<string> list6 = new List<string>(list2.Count);
			foreach (Label item4 in list2)
			{
				list6.Add(item4.Text);
			}
			if (!Form6.smethod_0(BxX.vmethod_0(), enum105_0, enum104_0, label3.Text, list5, list6))
			{
				return;
			}
			int num = Form6.smethod_1(list, list2, null, list4, null, label4, 38, bool_6: false);
			Panel panel = new Panel();
			panel.Location = new Point(-1, Bxx);
			panel.Size = new Size(BxX.class131_0.Width, num + 1);
			Bxx += num;
			Form6.smethod_2(list, list2, null, list4, null, null, null, label3, label4, num, 38, bool_6: false);
			if (Bxx > rectangle_0.Top + rectangle_0.Height)
			{
				bool_2 = true;
				return;
			}
			if (wiringPin_0 != null)
			{
				BYe++;
			}
			else if (bool_0)
			{
				BYa++;
			}
			else
			{
				BYB++;
			}
			bool_1 = true;
			using Font font = new Font(BxX.Font.FontFamily, BxX.Font.Size * 0.8f);
			if (label4 != null)
			{
				graphics_0.DrawString(label4.Text, font, Brushes.DarkOrange, label4.Left, panel.Top + label4.Top);
			}
			foreach (Label item5 in list4)
			{
				graphics_0.DrawString(item5.Text, font, Brushes.Black, item5.Left, panel.Top + item5.Top);
			}
			foreach (PictureBox item6 in list)
			{
				if (item6.Image != null)
				{
					graphics_0.DrawImage(item6.Image, item6.Left, panel.Top + item6.Top, (int)((float)item6.Image.Width * 0.95f), (int)((float)item6.Image.Height * 0.95f));
				}
			}
			foreach (Label item7 in list2)
			{
				graphics_0.DrawString(item7.Text, font, Brushes.Black, item7.Left, panel.Top + item7.Top);
			}
			graphics_0.DrawString(label3.Text, font, Brushes.Black, label3.Left, panel.Top + label3.Top);
			graphics_0.DrawLine(Pens.Black, rectangle_0.Left, Bxx, rectangle_0.Left + rectangle_0.Width, Bxx);
		}
	}

	[CompilerGenerated]
	private static EventHandler BPt;

	private IContainer BPU;

	private PictureBox BPu;

	private ThemedTextBox BPV;

	private ThemedButton BPv;

	private Label BPW;

	private ThemedComboBox BPw;

	private Label BPX;

	private ThemedComboBox BPx;

	private ThemedButton BPY;

	private ThemedButton BPy;

	private ThemedButton BPZ;

	private Label BPz;

	private ThemedComboBox BpA;

	private ThemedButton Bpa;

	private ThemedButton BpB;

	private System.Windows.Forms.Timer Bpb;

	internal Form8()
	{
		bool_0 = false;
		method_28();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		BPu.BackColor = BackColor;
		if (BPu.Image != null)
		{
			BPu.Image.Dispose();
		}
		BPu.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		BPV.BackColor = Form23.color_32;
		BPV.ForeColor = Form23.color_12;
		BPV.method_0(method_26);
		if (Form23.framework_1.awC.Count != 0)
		{
			class185_0 = new Class185(this);
			class185_0.BorderStyle = BorderStyle.FixedSingle;
			class185_0.BackColor = Form23.color_15;
			class185_0.Left = 10;
			class185_0.Width = ClientRectangle.Width - 20;
			class185_0.Top = BPZ.Bottom + 7;
			Controls.Add(class185_0);
		}
		class131_0.BorderStyle = BorderStyle.FixedSingle;
		class131_0.BackColor = Form23.color_15;
		class131_0.Left = 10;
		class131_0.Width = ClientRectangle.Width - 20;
		if (Form23.framework_1.awC.Count != 0)
		{
			class131_0.Top = class185_0.Top + class185_0.Height + 7;
		}
		else
		{
			class131_0.Top = BPZ.Bottom + 7;
		}
		class131_0.Height = BpB.Top - 10 - class131_0.Top;
		Controls.Add(class131_0);
		BPw.Items.Add(Class333.BDm());
		Enum104[] array = PortFunction.smethod_5();
		foreach (Enum104 @enum in array)
		{
			BPw.Items.Add(PortFunction.smethod_2(@enum, Form23.framework_1));
		}
		BPw.SelectedIndex = 0;
		BPx.Items.Add(Class333.BDN());
		Enum105[] array2 = PortFunction.smethod_6();
		foreach (Enum105 enum2 in array2)
		{
			BPx.Items.Add(PortFunction.smethod_4(enum2));
		}
		BPx.SelectedIndex = 0;
		ComboBox.ObjectCollection items = BpA.Items;
		object[] items2 = new string[2]
		{
			Class333.BDn(),
			Class333.BDO()
		};
		items.AddRange(items2);
		BpA.SelectedIndex = (int)Form6.enum51_1;
		BPz.Visible = (BpA.Visible = Form23.framework_1.awe);
		Class1.smethod_12(method_5);
		Form23.smethod_30(method_5);
		Form23.smethod_7(method_27);
		vmethod_1();
		Form6.form6_0 = this;
		class280_0 = new Class280(Form23.framework_1);
		foreach (WiringPin item in Form23.framework_1.awc)
		{
			if (item.method_13())
			{
				hashSet_0.Add(Form23.framework_1.method_31(item.Bbx));
			}
		}
		foreach (Setting item2 in hashSet_0)
		{
			item2.method_264(method_16);
		}
		bool_1 = false;
	}

	private void BPY_Click(object sender, EventArgs e)
	{
		method_10();
	}

	private void BPy_Click(object sender, EventArgs e)
	{
		method_11();
	}

	private void BPZ_Click(object sender, EventArgs e)
	{
		method_12();
	}

	private void BPw_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			method_13(BPw.SelectedIndex == 0, BPw.Text);
		}
	}

	private void BPx_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			method_14(BPx.SelectedIndex == 0, BPx.Text);
		}
	}

	private void BpA_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1 && BpA.SelectedIndex != -1)
		{
			method_17((Enum51)BpA.SelectedIndex);
		}
	}

	private void BPV_TextChanged(object sender, EventArgs e)
	{
		Bpb.Stop();
		Bpb.Start();
	}

	private void method_26(object sender, ThemedTextBox.EventArgs4 e)
	{
		Bpb.Stop();
		Bpb.Start();
	}

	private void Bpb_Tick(object sender, EventArgs e)
	{
		Bpb.Stop();
		vmethod_1();
	}

	private void BPv_Click(object sender, EventArgs e)
	{
		BPV.Text = string.Empty;
	}

	internal override string vmethod_0()
	{
		return BPV.Text;
	}

	private void method_27(object sender, EventArgs e)
	{
		Close();
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_3(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BPt;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BPt, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_4(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BPt;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BPt, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void Form8_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form6.form6_0 = null;
		foreach (Control control3 in class131_0.Controls)
		{
			control3.MouseClick -= method_21;
			control3.DoubleClick -= vmethod_2;
			foreach (Control control4 in control3.Controls)
			{
				control4.MouseClick -= method_21;
				control4.DoubleClick -= vmethod_2;
				control4.MouseClick -= method_22;
			}
		}
		Class1.smethod_13(method_5);
		Form23.smethod_31(method_5);
		Form23.smethod_8(method_27);
		foreach (Label item in list_0)
		{
			SettingOrSpecialObject bOR = ((Class183)item.Tag).BOR;
			for (int i = 0; i < bOR.method_12().method_1().Count; i++)
			{
				bOR.method_12().method_1()[i].method_265(method_6);
			}
		}
		foreach (Setting item2 in hashSet_0)
		{
			item2.method_265(method_16);
		}
		hashSet_0.Clear();
		if (stopwatch_0.IsRunning)
		{
			stopwatch_0.Stop();
		}
		if (BPt != null)
		{
			BPt(this, null);
		}
	}

	private void Form8_Resize(object sender, EventArgs e)
	{
		Bpa.Left = Width - 251;
		BpB.Left = Bpa.Right + 19;
		ThemedButton bpa = Bpa;
		int top = (BpB.Top = Height - 79);
		bpa.Top = top;
		BPz.Top = Height - 72;
		BpA.Top = Height - 76;
		if (class185_0 != null)
		{
			class185_0.Width = ClientRectangle.Width - 20;
		}
		class131_0.Width = ClientRectangle.Width - 20;
		class131_0.Height = BpB.Top - 10 - class131_0.Top;
	}

	private void Bpa_Click(object sender, EventArgs e)
	{
		new Class208(this).method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && BPU != null)
		{
			BPU.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_28()
	{
		BPU = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form8));
		BPu = new PictureBox();
		BPV = new ThemedTextBox();
		BPv = new ThemedButton();
		BPW = new Label();
		BPw = new ThemedComboBox();
		BPX = new Label();
		BPx = new ThemedComboBox();
		BPY = new ThemedButton();
		BPy = new ThemedButton();
		BPZ = new ThemedButton();
		BPz = new Label();
		BpA = new ThemedComboBox();
		Bpa = new ThemedButton();
		BpB = new ThemedButton();
		Bpb = new System.Windows.Forms.Timer(BPU);
		((ISupportInitialize)BPu).BeginInit();
		SuspendLayout();
		BPu.Image = (Image)componentResourceManager.GetObject(Class333.BDo());
		BPu.Location = new Point(7, 7);
		BPu.Name = Class333.smethod_591();
		BPu.Size = new Size(24, 24);
		BPu.TabIndex = 21;
		BPu.TabStop = false;
		BPV.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPV.Location = new Point(36, 8);
		BPV.Name = Class333.smethod_590();
		BPV.Size = new Size(137, 22);
		BPV.TabIndex = 0;
		BPV.TextChanged += BPV_TextChanged;
		BPv.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BPv.Location = new Point(175, 7);
		BPv.Name = Class333.smethod_592();
		BPv.Size = new Size(22, 24);
		BPv.TabIndex = 1;
		BPv.Text = Class333.smethod_330();
		BPv.UseVisualStyleBackColor = true;
		BPv.Click += BPv_Click;
		BPW.AutoSize = true;
		BPW.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPW.Location = new Point(211, 11);
		BPW.Name = Class333.BDP();
		BPW.Size = new Size(48, 13);
		BPW.TabIndex = 18;
		BPW.Text = Class333.BDp();
		BPw.DrawMode = DrawMode.OwnerDrawFixed;
		BPw.DropDownStyle = ComboBoxStyle.DropDownList;
		BPw.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPw.FormattingEnabled = true;
		BPw.Location = new Point(262, 7);
		BPw.MaxDropDownItems = 50;
		BPw.Name = Class333.BDQ();
		BPw.Size = new Size(206, 23);
		BPw.TabIndex = 2;
		BPw.SelectedIndexChanged += BPw_SelectedIndexChanged;
		BPX.AutoSize = true;
		BPX.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPX.Location = new Point(482, 11);
		BPX.Name = Class333.BDq();
		BPX.Size = new Size(101, 13);
		BPX.TabIndex = 13;
		BPX.Text = Class333.BDR();
		BPx.DrawMode = DrawMode.OwnerDrawFixed;
		BPx.DropDownStyle = ComboBoxStyle.DropDownList;
		BPx.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPx.FormattingEnabled = true;
		BPx.Location = new Point(586, 7);
		BPx.MaxDropDownItems = 50;
		BPx.Name = Class333.BDr();
		BPx.Size = new Size(194, 23);
		BPx.TabIndex = 3;
		BPx.SelectedIndexChanged += BPx_SelectedIndexChanged;
		BPY.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPY.Location = new Point(836, 5);
		BPY.Name = Class333.BDS();
		BPY.Size = new Size(120, 25);
		BPY.TabIndex = 4;
		BPY.Text = Class333.BDs();
		BPY.UseVisualStyleBackColor = true;
		BPY.Click += BPY_Click;
		BPy.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPy.Location = new Point(958, 5);
		BPy.Name = Class333.BDT();
		BPy.Size = new Size(120, 25);
		BPy.TabIndex = 5;
		BPy.Text = Class333.BDt();
		BPy.UseVisualStyleBackColor = true;
		BPy.Click += BPy_Click;
		BPZ.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPZ.Location = new Point(1080, 5);
		BPZ.Name = Class333.BDU();
		BPZ.Size = new Size(120, 25);
		BPZ.TabIndex = 6;
		BPZ.Text = Class333.BDu();
		BPZ.UseVisualStyleBackColor = true;
		BPZ.Click += BPZ_Click;
		BPz.AutoSize = true;
		BPz.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPz.Location = new Point(7, 570);
		BPz.Name = Class333.BDV();
		BPz.Size = new Size(60, 13);
		BPz.TabIndex = 26;
		BPz.Text = Class333.BDv();
		BpA.DrawMode = DrawMode.OwnerDrawFixed;
		BpA.DropDownStyle = ComboBoxStyle.DropDownList;
		BpA.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BpA.FormattingEnabled = true;
		BpA.Location = new Point(55, 566);
		BpA.MaxDropDownItems = 2;
		BpA.Name = Class333.BDW();
		BpA.Size = new Size(180, 23);
		BpA.TabIndex = 7;
		BpA.SelectedIndexChanged += BpA_SelectedIndexChanged;
		Bpa.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Bpa.Location = new Point(1010, 563);
		Bpa.Name = Class333.BDx();
		Bpa.Size = new Size(106, 30);
		Bpa.TabIndex = 8;
		Bpa.Text = Class333.BDY();
		Bpa.UseVisualStyleBackColor = true;
		Bpa.Click += Bpa_Click;
		BpB.DialogResult = DialogResult.OK;
		BpB.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BpB.Location = new Point(1135, 563);
		BpB.Name = Class333.smethod_829();
		BpB.Size = new Size(100, 30);
		BpB.TabIndex = 9;
		BpB.Text = Class333.smethod_821();
		BpB.UseVisualStyleBackColor = true;
		Bpb.Interval = 400;
		Bpb.Tick += Bpb_Tick;
		AcceptButton = BpB;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = BpB;
		ClientSize = new Size(1245, 604);
		Controls.Add(BPu);
		Controls.Add(BPV);
		Controls.Add(BPv);
		Controls.Add(BPW);
		Controls.Add(BPw);
		Controls.Add(BPX);
		Controls.Add(BPx);
		Controls.Add(BPY);
		Controls.Add(BPy);
		Controls.Add(BPZ);
		Controls.Add(BPz);
		Controls.Add(BpA);
		Controls.Add(Bpa);
		Controls.Add(BpB);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MinimizeBox = false;
		Name = Class333.BDy();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.BDZ();
		FormClosing += Form8_FormClosing;
		Resize += Form8_Resize;
		((ISupportInitialize)BPu).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
