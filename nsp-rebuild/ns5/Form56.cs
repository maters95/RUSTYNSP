using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns1;
using ns2;
using ns4;
using ns7;

namespace ns5;

internal class Form56 : Form
{
	private const int aAx = 5;

	private List<Setting> aAY;

	private double aAy;

	private double aAZ;

	private Dictionary<int, int> aAz = new Dictionary<int, int>();

	private Dictionary<int, int> aaA = new Dictionary<int, int>();

	private Dictionary<int, int> aaa = new Dictionary<int, int>();

	private int aaB;

	private List<Label> aab = new List<Label>();

	private List<TextBox> aaC = new List<TextBox>();

	private List<TextBox> aac = new List<TextBox>();

	private List<Class151> aaD = new List<Class151>();

	private IContainer aad;

	private ThemedButton aaE;

	private ThemedButton aae;

	private Label aaF;

	private Label aaf;

	private Label aaG;

	private Label aag;

	private Label aaH;

	private Label aah;

	private Label aaI;

	private Label aai;

	private Label aaJ;

	private Label aaj;

	private ThemedTextBox aaK;

	private ThemedTextBox aak;

	private ThemedTextBox aaL;

	private ThemedTextBox aal;

	private ThemedTextBox aaM;

	private ThemedTextBox aam;

	private ThemedTextBox aaN;

	private ThemedTextBox aan;

	private ThemedTextBox aaO;

	private ThemedTextBox aao;

	private ThemedTextBox aaP;

	private ThemedTextBox aap;

	private ThemedTextBox aaQ;

	private ThemedTextBox aaq;

	private ThemedTextBox aaR;

	private ThemedTextBox aar;

	private ThemedTextBox aaS;

	private ThemedTextBox aas;

	private ThemedTextBox aaT;

	private ThemedTextBox aat;

	private Label aaU;

	private Label aau;

	private NumericUpDown aaV;

	private Label aav;

	private Label aaW;

	private Label aaw;

	private Class151 aaX;

	private Class151 aax;

	private Class151 aaY;

	private Class151 aay;

	private Class151 aaZ;

	private Class151 aaz;

	private Class151 aBA;

	private Class151 aBa;

	private Class151 aBB;

	private Class151 aBb;

	private Class148 aBC;

	private Label aBc;

	private Label aBD;

	private ThemedTextBox aBd;

	private ThemedTextBox aBE;

	internal Form56()
	{
		method_8();
	}

	internal Form56(List<Setting> list_0, bool bool_0, double double_0, double double_1, Dictionary<int, int> dictionary_0, Dictionary<int, int> dictionary_1, Dictionary<int, int> dictionary_2, int int_0)
	{
		method_8();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
			else if (control is Class148)
			{
				control.ForeColor = Form23.color_12;
			}
			else if (control is ThemedTextBox)
			{
				control.BackColor = Form23.color_32;
				control.ForeColor = Form23.color_12;
			}
		}
		aAy = double_0;
		aAZ = double_1;
		aAY = list_0;
		foreach (KeyValuePair<int, int> item in dictionary_0)
		{
			aAz.Add(item.Key, item.Value);
		}
		foreach (KeyValuePair<int, int> item2 in dictionary_1)
		{
			aaA.Add(item2.Key, item2.Value);
		}
		foreach (KeyValuePair<int, int> item3 in dictionary_2)
		{
			aaa.Add(item3.Key, item3.Value);
		}
		aaB = int_0;
		aab.Add(aaF);
		aab.Add(aaf);
		aab.Add(aaG);
		aab.Add(aag);
		aab.Add(aaH);
		aab.Add(aah);
		aab.Add(aaI);
		aab.Add(aai);
		aab.Add(aaJ);
		aab.Add(aaj);
		aaC.Add(aaK);
		aaC.Add(aak);
		aaC.Add(aaL);
		aaC.Add(aal);
		aaC.Add(aaM);
		aaC.Add(aam);
		aaC.Add(aaN);
		aaC.Add(aan);
		aaC.Add(aaO);
		aaC.Add(aao);
		aac.Add(aat);
		aac.Add(aaT);
		aac.Add(aas);
		aac.Add(aaS);
		aac.Add(aar);
		aac.Add(aaR);
		aac.Add(aaq);
		aac.Add(aaQ);
		aac.Add(aap);
		aac.Add(aaP);
		aaD.Add(aaX);
		aaD.Add(aax);
		aaD.Add(aaY);
		aaD.Add(aay);
		aaD.Add(aaZ);
		aaD.Add(aaz);
		aaD.Add(aBA);
		aaD.Add(aBa);
		aaD.Add(aBB);
		aaD.Add(aBb);
		for (int i = 0; i < 10; i++)
		{
			for (int j = 0; j < Class105.BKu.Length; j++)
			{
				aaD[i].Items.Add(Class105.BKu[j].ToString());
			}
		}
		int num = 0;
		for (int k = 0; k < 10; k++)
		{
			if (aAY.Count > k)
			{
				Setting setting = aAY[k];
				int num2 = setting.method_231();
				string text = setting.method_18();
				if (!string.IsNullOrWhiteSpace(text))
				{
					if (num2 != 0 && num2 != 82)
					{
						aab[k].Text = text + Class333.smethod_497() + Class233.smethod_35(setting.method_232(), num2, bool_0: false, 0) + Class333.smethod_9();
					}
					else
					{
						aab[k].Text = text;
					}
				}
				else if (num2 != 0 && num2 != 82)
				{
					aab[k].Text = setting.method_60(Enum96.aYt) + Class333.smethod_497() + Class233.smethod_35(setting.method_232(), num2, bool_0: false, 0) + Class333.smethod_9();
				}
				else
				{
					aab[k].Text = setting.method_60(Enum96.aYt);
				}
				aaC[k].Text = Class233.smethod_29(aAz[setting.method_64()], num2);
				aac[k].Text = Class233.smethod_29(aaA[setting.method_64()], num2);
				aaC[k].Visible = true;
				aac[k].Visible = true;
				aaD[k].Visible = true;
				aaD[k].SelectedIndex = aaa[setting.method_64()];
				int width = TextRenderer.MeasureText(aab[k].Text, Font).Width;
				if (width > num)
				{
					num = width;
				}
			}
			else
			{
				aab[k].Text = string.Empty;
				aaC[k].Visible = false;
				aac[k].Visible = false;
				aaD[k].Visible = false;
			}
		}
		num += 75;
		int num3 = 0;
		int num4 = 5 + num;
		aaU.Left = 2 + num4;
		foreach (TextBox item4 in aaC)
		{
			item4.Left = num4;
		}
		int num5 = 5 + num + aaC[0].Width + 5;
		aau.Left = 2 + num5;
		foreach (TextBox item5 in aac)
		{
			item5.Left = num5;
		}
		int num6 = 5 + num + aaC[0].Width + 5 + aac[0].Width + 5;
		aaw.Left = 2 + num6;
		foreach (Class151 item6 in aaD)
		{
			item6.Left = num6;
			num3 = item6.Right + 20;
		}
		aBC.Top = aaK.Top + aAY.Count * (aak.Top - aaK.Top) + 10;
		aBD.Top = aBC.Top + 20;
		aBc.Top = aBD.Top;
		aBE.Top = aBD.Top + 18;
		aBd.Top = aBE.Top;
		aaV.Top = aBE.Top + 38;
		aav.Top = aaV.Top + 3;
		aaW.Top = aav.Top;
		decimal val = (decimal)aaB / 1000m;
		val = Math.Min(Math.Max(val, aaV.Minimum), aaV.Maximum);
		aaV.Value = val;
		aaE.Top = aBC.Top + 67;
		aae.Top = aaE.Top;
		aae.Left = num3 - aae.Width - 20;
		aaE.Left = aae.Left - aaE.Width - 5;
		Width = num3;
		Height = aaE.Bottom + 50;
		aBE.Text = aAy.ToString();
		aBd.Text = aAZ.ToString();
		aBC.Checked = bool_0;
	}

	private void aBC_CheckedChanged(object sender, EventArgs e)
	{
		aBE.Enabled = aBC.Checked;
		aBd.Enabled = aBC.Checked;
		foreach (TextBox item in aaC)
		{
			item.Enabled = !aBC.Checked;
		}
		foreach (TextBox item2 in aac)
		{
			item2.Enabled = !aBC.Checked;
		}
	}

	[SpecialName]
	internal bool method_0()
	{
		return aBC.Checked;
	}

	[SpecialName]
	internal double method_1()
	{
		return aAy;
	}

	[SpecialName]
	internal double method_2()
	{
		return aAZ;
	}

	[SpecialName]
	internal Dictionary<int, int> method_3()
	{
		return aAz;
	}

	[SpecialName]
	internal Dictionary<int, int> method_4()
	{
		return aaA;
	}

	[SpecialName]
	internal Dictionary<int, int> method_5()
	{
		return aaa;
	}

	[SpecialName]
	internal int method_6()
	{
		return aaB;
	}

	private void Form56_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		string text = null;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		string arg = string.Empty;
		string arg2 = string.Empty;
		try
		{
			if (aBC.Checked)
			{
				double num = double.Parse(aBE.Text);
				double num2 = double.Parse(aBd.Text);
				if (num >= num2)
				{
					flag = true;
					throw new Exception();
				}
				aAy = num;
				aAZ = num2;
			}
			else
			{
				for (int i = 0; i < aAY.Count; i++)
				{
					Setting setting = aAY[i];
					int num3 = setting.method_231();
					int num4 = setting.method_228();
					int num5 = setting.method_229();
					flag = false;
					flag2 = false;
					flag3 = false;
					arg = Class233.smethod_29(num4, num3);
					arg2 = Class233.smethod_29(num5, num3);
					text = aab[i].Text;
					int num6 = Class233.smethod_25(aaC[i].Text, num3);
					int num7 = Class233.smethod_25(aac[i].Text, num3);
					if (num6 < num7)
					{
						if (num4 != 0 || num5 != 0)
						{
							if (num6 < num4)
							{
								flag2 = true;
								throw new Exception();
							}
							if (num7 > num5)
							{
								flag3 = true;
								throw new Exception();
							}
						}
						aAz[setting.method_64()] = num6;
						aaA[setting.method_64()] = num7;
						continue;
					}
					flag = true;
					throw new Exception();
				}
			}
			for (int j = 0; j < aAY.Count; j++)
			{
				aaa[aAY[j].method_64()] = aaD[j].SelectedIndex;
			}
			aaB = (int)(aaV.Value * 1000m);
		}
		catch
		{
			if (flag)
			{
				Form54.smethod_6(this, Class333.smethod_1154(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (flag2 | flag3)
			{
				string text2 = string.Empty;
				if (flag2)
				{
					text2 = Class333.smethod_1155();
				}
				else if (flag3)
				{
					text2 = Class333.smethod_1156();
				}
				if (text == null)
				{
					Form54.smethod_6(this, string.Format(Class333.smethod_1341() + text2 + Class333.smethod_1342(), arg, arg2), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					Form54.smethod_6(this, string.Format(Class333.smethod_1341() + text2 + Class333.smethod_1343() + text + Class333.smethod_1342(), arg, arg2), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else if (text == null)
			{
				Form54.smethod_6(this, Class333.smethod_605(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1344() + text, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			e.Cancel = true;
		}
	}

	private void method_7(Class151 class151_0, int int_0, DrawItemEventArgs drawItemEventArgs_0)
	{
		if (class151_0.DroppedDown)
		{
			using (SolidBrush brush = new SolidBrush(Class105.BKu[drawItemEventArgs_0.Index]))
			{
				drawItemEventArgs_0.Graphics.FillRectangle(brush, drawItemEventArgs_0.Bounds);
				return;
			}
		}
		using (SolidBrush brush2 = new SolidBrush(Class105.BKu[aaD[int_0].SelectedIndex]))
		{
			drawItemEventArgs_0.Graphics.FillRectangle(brush2, drawItemEventArgs_0.Bounds);
		}
		using Pen pen = new Pen(Brushes.Black, 1f);
		drawItemEventArgs_0.Graphics.DrawRectangle(pen, drawItemEventArgs_0.Bounds.X, drawItemEventArgs_0.Bounds.Y, drawItemEventArgs_0.Bounds.Width - 1, drawItemEventArgs_0.Bounds.Height - 1);
	}

	private void aaX_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 0, e);
	}

	private void aax_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 1, e);
	}

	private void aaY_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 2, e);
	}

	private void aay_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 3, e);
	}

	private void aaZ_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 4, e);
	}

	private void aaz_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 5, e);
	}

	private void aBA_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 6, e);
	}

	private void aBa_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 7, e);
	}

	private void aBB_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 8, e);
	}

	private void aBb_DrawItem(object sender, DrawItemEventArgs e)
	{
		method_7(sender as Class151, 9, e);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aad != null)
		{
			aad.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_8()
	{
		aaE = new ThemedButton();
		aae = new ThemedButton();
		aaF = new Label();
		aaf = new Label();
		aaG = new Label();
		aag = new Label();
		aaH = new Label();
		aah = new Label();
		aaI = new Label();
		aai = new Label();
		aaJ = new Label();
		aaj = new Label();
		aaK = new ThemedTextBox();
		aak = new ThemedTextBox();
		aaL = new ThemedTextBox();
		aal = new ThemedTextBox();
		aaM = new ThemedTextBox();
		aam = new ThemedTextBox();
		aaN = new ThemedTextBox();
		aan = new ThemedTextBox();
		aaO = new ThemedTextBox();
		aao = new ThemedTextBox();
		aaP = new ThemedTextBox();
		aap = new ThemedTextBox();
		aaQ = new ThemedTextBox();
		aaq = new ThemedTextBox();
		aaR = new ThemedTextBox();
		aar = new ThemedTextBox();
		aaS = new ThemedTextBox();
		aas = new ThemedTextBox();
		aaT = new ThemedTextBox();
		aat = new ThemedTextBox();
		aaU = new Label();
		aau = new Label();
		aaV = new NumericUpDown();
		aav = new Label();
		aaW = new Label();
		aaw = new Label();
		aaX = new Class151();
		aax = new Class151();
		aaY = new Class151();
		aay = new Class151();
		aaZ = new Class151();
		aaz = new Class151();
		aBA = new Class151();
		aBa = new Class151();
		aBB = new Class151();
		aBb = new Class151();
		aBC = new Class148();
		aBc = new Label();
		aBD = new Label();
		aBd = new ThemedTextBox();
		aBE = new ThemedTextBox();
		((ISupportInitialize)aaV).BeginInit();
		SuspendLayout();
		aaE.DialogResult = DialogResult.OK;
		aaE.Location = new Point(388, 317);
		aaE.Name = Class333.smethod_829();
		aaE.Size = new Size(89, 34);
		aaE.TabIndex = 0;
		aaE.Text = Class333.smethod_821();
		aaE.UseVisualStyleBackColor = true;
		aae.DialogResult = DialogResult.Cancel;
		aae.Location = new Point(483, 317);
		aae.Name = Class333.smethod_830();
		aae.Size = new Size(89, 34);
		aae.TabIndex = 1;
		aae.Text = Class333.smethod_823();
		aae.UseVisualStyleBackColor = true;
		aaF.AutoSize = true;
		aaF.Location = new Point(9, 24);
		aaF.Name = Class333.smethod_618();
		aaF.Size = new Size(38, 13);
		aaF.TabIndex = 2;
		aaF.Text = Class333.smethod_618();
		aaf.AutoSize = true;
		aaf.Location = new Point(9, 46);
		aaf.Name = Class333.smethod_620();
		aaf.Size = new Size(38, 13);
		aaf.TabIndex = 3;
		aaf.Text = Class333.smethod_620();
		aaG.AutoSize = true;
		aaG.Location = new Point(9, 68);
		aaG.Name = Class333.smethod_621();
		aaG.Size = new Size(38, 13);
		aaG.TabIndex = 4;
		aaG.Text = Class333.smethod_621();
		aag.AutoSize = true;
		aag.Location = new Point(9, 90);
		aag.Name = Class333.smethod_623();
		aag.Size = new Size(38, 13);
		aag.TabIndex = 5;
		aag.Text = Class333.smethod_623();
		aaH.AutoSize = true;
		aaH.Location = new Point(9, 112);
		aaH.Name = Class333.smethod_862();
		aaH.Size = new Size(38, 13);
		aaH.TabIndex = 6;
		aaH.Text = Class333.smethod_862();
		aah.AutoSize = true;
		aah.Location = new Point(9, 134);
		aah.Name = Class333.smethod_864();
		aah.Size = new Size(38, 13);
		aah.TabIndex = 7;
		aah.Text = Class333.smethod_864();
		aaI.AutoSize = true;
		aaI.Location = new Point(9, 156);
		aaI.Name = Class333.smethod_866();
		aaI.Size = new Size(38, 13);
		aaI.TabIndex = 8;
		aaI.Text = Class333.smethod_866();
		aai.AutoSize = true;
		aai.Location = new Point(9, 178);
		aai.Name = Class333.smethod_627();
		aai.Size = new Size(38, 13);
		aai.TabIndex = 9;
		aai.Text = Class333.smethod_627();
		aaJ.AutoSize = true;
		aaJ.Location = new Point(9, 200);
		aaJ.Name = Class333.smethod_629();
		aaJ.Size = new Size(38, 13);
		aaJ.TabIndex = 10;
		aaJ.Text = Class333.smethod_629();
		aaj.AutoSize = true;
		aaj.Location = new Point(9, 222);
		aaj.Name = Class333.smethod_631();
		aaj.Size = new Size(44, 13);
		aaj.TabIndex = 11;
		aaj.Text = Class333.smethod_631();
		aaK.Location = new Point(308, 21);
		aaK.Name = Class333.aal();
		aaK.Size = new Size(100, 22);
		aaK.TabIndex = 2;
		aak.Location = new Point(308, 43);
		aak.Name = Class333.aaM();
		aak.Size = new Size(100, 22);
		aak.TabIndex = 5;
		aaL.Location = new Point(308, 65);
		aaL.Name = Class333.aam();
		aaL.Size = new Size(100, 22);
		aaL.TabIndex = 8;
		aal.Location = new Point(308, 87);
		aal.Name = Class333.aaN();
		aal.Size = new Size(100, 22);
		aal.TabIndex = 11;
		aaM.Location = new Point(308, 109);
		aaM.Name = Class333.aan();
		aaM.Size = new Size(100, 22);
		aaM.TabIndex = 14;
		aam.Location = new Point(308, 131);
		aam.Name = Class333.aaO();
		aam.Size = new Size(100, 22);
		aam.TabIndex = 17;
		aaN.Location = new Point(308, 153);
		aaN.Name = Class333.aao();
		aaN.Size = new Size(100, 22);
		aaN.TabIndex = 20;
		aan.Location = new Point(308, 175);
		aan.Name = Class333.aaP();
		aan.Size = new Size(100, 22);
		aan.TabIndex = 23;
		aaO.Location = new Point(308, 197);
		aaO.Name = Class333.aap();
		aaO.Size = new Size(100, 22);
		aaO.TabIndex = 26;
		aao.Location = new Point(308, 219);
		aao.Name = Class333.aaQ();
		aao.Size = new Size(100, 22);
		aao.TabIndex = 29;
		aaP.Location = new Point(414, 219);
		aaP.Name = Class333.aaq();
		aaP.Size = new Size(100, 22);
		aaP.TabIndex = 30;
		aap.Location = new Point(414, 197);
		aap.Name = Class333.aaR();
		aap.Size = new Size(100, 22);
		aap.TabIndex = 27;
		aaQ.Location = new Point(414, 175);
		aaQ.Name = Class333.aar();
		aaQ.Size = new Size(100, 22);
		aaQ.TabIndex = 24;
		aaq.Location = new Point(414, 153);
		aaq.Name = Class333.aaS();
		aaq.Size = new Size(100, 22);
		aaq.TabIndex = 21;
		aaR.Location = new Point(414, 131);
		aaR.Name = Class333.aas();
		aaR.Size = new Size(100, 22);
		aaR.TabIndex = 18;
		aar.Location = new Point(414, 109);
		aar.Name = Class333.aaT();
		aar.Size = new Size(100, 22);
		aar.TabIndex = 15;
		aaS.Location = new Point(414, 87);
		aaS.Name = Class333.aat();
		aaS.Size = new Size(100, 22);
		aaS.TabIndex = 12;
		aas.Location = new Point(414, 65);
		aas.Name = Class333.aaU();
		aas.Size = new Size(100, 22);
		aas.TabIndex = 9;
		aaT.Location = new Point(414, 43);
		aaT.Name = Class333.aau();
		aaT.Size = new Size(100, 22);
		aaT.TabIndex = 6;
		aat.Location = new Point(414, 21);
		aat.Name = Class333.aaV();
		aat.Size = new Size(100, 22);
		aat.TabIndex = 3;
		aaU.AutoSize = true;
		aaU.Location = new Point(310, 5);
		aaU.Name = Class333.aav();
		aaU.Size = new Size(55, 13);
		aaU.TabIndex = 32;
		aaU.Text = Class333.smethod_2066();
		aau.AutoSize = true;
		aau.Location = new Point(416, 5);
		aau.Name = Class333.aaW();
		aau.Size = new Size(56, 13);
		aau.TabIndex = 33;
		aau.Text = Class333.smethod_1020();
		aaV.DecimalPlaces = 1;
		aaV.Location = new Point(75, 324);
		aaV.Maximum = new decimal(new int[4] { 60, 0, 0, 0 });
		aaV.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		aaV.Name = Class333.aaw();
		aaV.Size = new Size(72, 22);
		aaV.TabIndex = 32;
		aaV.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		aav.AutoSize = true;
		aav.Location = new Point(9, 327);
		aav.Name = Class333.smethod_636();
		aav.Size = new Size(63, 13);
		aav.TabIndex = 35;
		aav.Text = Class333.aaX();
		aaW.AutoSize = true;
		aaW.Location = new Point(154, 327);
		aaW.Name = Class333.smethod_638();
		aaW.Size = new Size(50, 13);
		aaW.TabIndex = 36;
		aaW.Text = Class333.smethod_2059();
		aaw.AutoSize = true;
		aaw.Location = new Point(525, 5);
		aaw.Name = Class333.aax();
		aaw.Size = new Size(42, 13);
		aaw.TabIndex = 37;
		aaw.Text = Class333.smethod_2063();
		aaX.DrawMode = DrawMode.OwnerDrawFixed;
		aaX.DropDownStyle = ComboBoxStyle.DropDownList;
		aaX.FormattingEnabled = true;
		aaX.Location = new Point(523, 20);
		aaX.MaxDropDownItems = 10;
		aaX.Name = Class333.aaY();
		aaX.Size = new Size(47, 23);
		aaX.TabIndex = 4;
		aaX.DrawItem += aaX_DrawItem;
		aax.DrawMode = DrawMode.OwnerDrawFixed;
		aax.DropDownStyle = ComboBoxStyle.DropDownList;
		aax.FormattingEnabled = true;
		aax.Location = new Point(523, 42);
		aax.MaxDropDownItems = 10;
		aax.Name = Class333.aay();
		aax.Size = new Size(47, 23);
		aax.TabIndex = 7;
		aax.DrawItem += aax_DrawItem;
		aaY.DrawMode = DrawMode.OwnerDrawFixed;
		aaY.DropDownStyle = ComboBoxStyle.DropDownList;
		aaY.FormattingEnabled = true;
		aaY.Location = new Point(523, 64);
		aaY.MaxDropDownItems = 10;
		aaY.Name = Class333.aaZ();
		aaY.Size = new Size(47, 23);
		aaY.TabIndex = 10;
		aaY.DrawItem += aaY_DrawItem;
		aay.DrawMode = DrawMode.OwnerDrawFixed;
		aay.DropDownStyle = ComboBoxStyle.DropDownList;
		aay.FormattingEnabled = true;
		aay.Location = new Point(523, 86);
		aay.MaxDropDownItems = 10;
		aay.Name = Class333.aaz();
		aay.Size = new Size(47, 23);
		aay.TabIndex = 13;
		aay.DrawItem += aay_DrawItem;
		aaZ.DrawMode = DrawMode.OwnerDrawFixed;
		aaZ.DropDownStyle = ComboBoxStyle.DropDownList;
		aaZ.FormattingEnabled = true;
		aaZ.Location = new Point(523, 108);
		aaZ.MaxDropDownItems = 10;
		aaZ.Name = Class333.aBA();
		aaZ.Size = new Size(47, 23);
		aaZ.TabIndex = 16;
		aaZ.DrawItem += aaZ_DrawItem;
		aaz.DrawMode = DrawMode.OwnerDrawFixed;
		aaz.DropDownStyle = ComboBoxStyle.DropDownList;
		aaz.FormattingEnabled = true;
		aaz.Location = new Point(523, 130);
		aaz.MaxDropDownItems = 10;
		aaz.Name = Class333.aBa();
		aaz.Size = new Size(47, 23);
		aaz.TabIndex = 19;
		aaz.DrawItem += aaz_DrawItem;
		aBA.DrawMode = DrawMode.OwnerDrawFixed;
		aBA.DropDownStyle = ComboBoxStyle.DropDownList;
		aBA.FormattingEnabled = true;
		aBA.Location = new Point(523, 152);
		aBA.MaxDropDownItems = 10;
		aBA.Name = Class333.aBB();
		aBA.Size = new Size(47, 23);
		aBA.TabIndex = 22;
		aBA.DrawItem += aBA_DrawItem;
		aBa.DrawMode = DrawMode.OwnerDrawFixed;
		aBa.DropDownStyle = ComboBoxStyle.DropDownList;
		aBa.FormattingEnabled = true;
		aBa.Location = new Point(523, 174);
		aBa.MaxDropDownItems = 10;
		aBa.Name = Class333.aBb();
		aBa.Size = new Size(47, 23);
		aBa.TabIndex = 25;
		aBa.DrawItem += aBa_DrawItem;
		aBB.DrawMode = DrawMode.OwnerDrawFixed;
		aBB.DropDownStyle = ComboBoxStyle.DropDownList;
		aBB.FormattingEnabled = true;
		aBB.Location = new Point(523, 196);
		aBB.MaxDropDownItems = 10;
		aBB.Name = Class333.aBC();
		aBB.Size = new Size(47, 23);
		aBB.TabIndex = 28;
		aBB.DrawItem += aBB_DrawItem;
		aBb.DrawMode = DrawMode.OwnerDrawFixed;
		aBb.DropDownStyle = ComboBoxStyle.DropDownList;
		aBb.FormattingEnabled = true;
		aBb.Location = new Point(523, 218);
		aBb.MaxDropDownItems = 10;
		aBb.Name = Class333.aBc();
		aBb.Size = new Size(47, 23);
		aBb.TabIndex = 31;
		aBb.DrawItem += aBb_DrawItem;
		aBC.AutoSize = true;
		aBC.Location = new Point(10, 252);
		aBC.Name = Class333.smethod_2071();
		aBC.Size = new Size(220, 17);
		aBC.TabIndex = 38;
		aBC.Text = Class333.smethod_2072();
		aBC.UseVisualStyleBackColor = true;
		aBC.CheckedChanged += aBC_CheckedChanged;
		aBc.AutoSize = true;
		aBc.Location = new Point(120, 272);
		aBc.Name = Class333.smethod_2067();
		aBc.Size = new Size(56, 13);
		aBc.TabIndex = 42;
		aBc.Text = Class333.smethod_1020();
		aBD.AutoSize = true;
		aBD.Location = new Point(14, 272);
		aBD.Name = Class333.smethod_2068();
		aBD.Size = new Size(55, 13);
		aBD.TabIndex = 41;
		aBD.Text = Class333.smethod_2066();
		aBd.Enabled = false;
		aBd.Location = new Point(118, 288);
		aBd.Name = Class333.smethod_2069();
		aBd.Size = new Size(100, 22);
		aBd.TabIndex = 40;
		aBE.Enabled = false;
		aBE.Location = new Point(12, 288);
		aBE.Name = Class333.smethod_2070();
		aBE.Size = new Size(100, 22);
		aBE.TabIndex = 39;
		AcceptButton = aaE;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = aae;
		ClientSize = new Size(584, 361);
		Controls.Add(aBc);
		Controls.Add(aBD);
		Controls.Add(aBd);
		Controls.Add(aBE);
		Controls.Add(aBC);
		Controls.Add(aBb);
		Controls.Add(aBB);
		Controls.Add(aBa);
		Controls.Add(aBA);
		Controls.Add(aaz);
		Controls.Add(aaZ);
		Controls.Add(aay);
		Controls.Add(aaY);
		Controls.Add(aax);
		Controls.Add(aaX);
		Controls.Add(aaw);
		Controls.Add(aaW);
		Controls.Add(aav);
		Controls.Add(aaV);
		Controls.Add(aau);
		Controls.Add(aaU);
		Controls.Add(aaP);
		Controls.Add(aap);
		Controls.Add(aaQ);
		Controls.Add(aaq);
		Controls.Add(aaR);
		Controls.Add(aar);
		Controls.Add(aaS);
		Controls.Add(aas);
		Controls.Add(aaT);
		Controls.Add(aat);
		Controls.Add(aao);
		Controls.Add(aaO);
		Controls.Add(aan);
		Controls.Add(aaN);
		Controls.Add(aam);
		Controls.Add(aaM);
		Controls.Add(aal);
		Controls.Add(aaL);
		Controls.Add(aak);
		Controls.Add(aaK);
		Controls.Add(aaj);
		Controls.Add(aaJ);
		Controls.Add(aai);
		Controls.Add(aaI);
		Controls.Add(aah);
		Controls.Add(aaH);
		Controls.Add(aag);
		Controls.Add(aaG);
		Controls.Add(aaf);
		Controls.Add(aaF);
		Controls.Add(aae);
		Controls.Add(aaE);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aBD();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.aBd();
		FormClosing += Form56_FormClosing;
		((ISupportInitialize)aaV).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
