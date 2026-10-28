using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal abstract class Form6 : Form
{
	protected enum Enum51
	{
		BOQ,
		BOq
	}

	protected class Class183
	{
		internal SettingOrSpecialObject BOR;

		internal WiringPin BOr;
	}

	protected delegate void Delegate100(object sender, EventArgs e);

	protected delegate void Delegate101(object sender, EventArgs e);

	[Serializable]
	[CompilerGenerated]
	private sealed class Class184
	{
		public static readonly Class184 BOS = new Class184();

		public static Func<Label, bool> BOs;

		internal bool method_0(Label label_0)
		{
			return label_0.Text.Contains('\n');
		}
	}

	protected const int int_0 = 10;

	protected const int int_1 = 7;

	protected const int int_2 = 7;

	protected const int int_3 = 35;

	protected const int int_4 = 40;

	protected const int int_5 = 38;

	protected const int int_6 = 12;

	protected const int int_7 = 85;

	protected const int int_8 = 400;

	protected const int int_9 = 610;

	protected const int int_10 = 1030;

	protected const int int_11 = 160;

	protected const int int_12 = 30;

	protected const int int_13 = 1;

	protected const int int_14 = 2;

	protected const int int_15 = 3;

	internal bool bool_0;

	internal Class244 class244_0;

	protected bool bool_1 = true;

	protected Class185 class185_0;

	protected Class131 class131_0 = new Class131();

	protected int int_16;

	protected List<Label> list_0 = new List<Label>();

	protected List<Label> list_1 = new List<Label>();

	protected List<List<int>> list_2 = new List<List<int>>();

	protected List<List<float>> list_3 = new List<List<float>>();

	protected List<List<string>> list_4 = new List<List<string>>();

	protected List<List<int>> list_5 = new List<List<int>>();

	protected List<List<bool>> list_6 = new List<List<bool>>();

	internal bool bool_2 = true;

	internal bool bool_3 = true;

	protected Enum104 enum104_0;

	protected bool bool_4 = true;

	protected Enum105 enum105_0;

	protected bool bool_5 = true;

	protected Enum104 enum104_1;

	protected Enum105 enum105_1;

	protected byte byte_0;

	protected ushort ushort_0;

	protected WiringPin wiringPin_0;

	protected HashSet<Setting> hashSet_0 = new HashSet<Setting>();

	protected static Enum51 enum51_0;

	protected static Enum51 enum51_1;

	internal Class280 class280_0;

	internal static Form6 form6_0;

	protected Stopwatch stopwatch_0 = new Stopwatch();

	internal abstract string vmethod_0();

	protected virtual void vmethod_1()
	{
		class131_0.SuspendLayout();
		method_3();
		if (method_18() == Enum51.BOq)
		{
			method_0();
		}
		else if (method_18() == Enum51.BOQ)
		{
			if (bool_0)
			{
				if (bool_3)
				{
					method_2();
					int_16 += 40;
				}
				if (bool_2)
				{
					method_1();
				}
			}
			else
			{
				if (bool_2)
				{
					method_1();
					int_16 += 40;
				}
				if (bool_3)
				{
					method_2();
				}
			}
		}
		class131_0.ResumeLayout(performLayout: true);
		method_4();
		method_19(bool_6: false);
		if (class185_0 != null)
		{
			class185_0.method_0();
		}
	}

	protected void method_0()
	{
		Label label = new Label();
		label.Text = Class333.smethod_873();
		label.ForeColor = Form23.color_12;
		label.Font = new Font(label.Font.FontFamily, 8f, FontStyle.Bold);
		label.AutoSize = true;
		label.Left = 10;
		label.Top = int_16 + 6;
		class131_0.Controls.Add(label);
		Label label2 = new Label();
		label2.Text = Class333.smethod_874();
		label2.ForeColor = Form23.color_12;
		label2.Font = new Font(label2.Font.FontFamily, 8f, FontStyle.Bold);
		label2.AutoSize = true;
		label2.Left = 610;
		label2.Top = int_16 + 6;
		class131_0.Controls.Add(label2);
		int_16 += 25;
		Label label3 = new Label();
		label3.AutoSize = false;
		label3.Height = 1;
		label3.Width = class131_0.Width;
		label3.Left = 0;
		label3.Top = int_16;
		label3.BorderStyle = BorderStyle.FixedSingle;
		class131_0.Controls.Add(label3);
		for (int i = 0; i < PortFunction.smethod_5().Length; i++)
		{
			Enum104 key = PortFunction.smethod_5()[i];
			if (!Form23.framework_1.awb.ContainsKey(key))
			{
				continue;
			}
			string text = PortFunction.smethod_1(key, Form23.framework_1);
			string text2 = PortFunction.smethod_2(key, Form23.framework_1);
			if (!string.IsNullOrEmpty(text))
			{
				text2 = text + Class333.smethod_497() + text2 + Class333.smethod_875();
			}
			foreach (Connector item in Form23.framework_1.awb[key])
			{
				int top = int_16 + 16;
				int_16 += 35;
				bool bool_ = false;
				for (int j = 0; j < item.ayS.Count; j++)
				{
					WiringPin wiringPin = item.ayS.Values[j];
					if (!wiringPin.Bbq.method_35())
					{
						continue;
					}
					List<WiringPin.Class276> list = wiringPin.method_4();
					if (list.Count == 0)
					{
						continue;
					}
					Enum104 bsk = list[list.Count - 1].Bsk;
					Enum105 bsL = list[list.Count - 1].BsL;
					byte bsl = list[list.Count - 1].Bsl;
					ushort bsM = list[list.Count - 1].BsM;
					SettingOrSpecialObject settingOrSpecialObject = PortFunction.smethod_36(Form23.framework_1, bsk, bsL, bsl, bsM);
					if (settingOrSpecialObject == null || !settingOrSpecialObject.method_35() || (bsL == Enum105.BaF && !bool_0) || !method_15(bsk, bsL))
					{
						continue;
					}
					List<bool> list2 = new List<bool>();
					List<string> list3 = PortFunction.smethod_45(Form23.framework_1, bsk, bsL, bsl, bsM, bool_0: true, list2);
					if (list3 == null)
					{
						string text3 = PortFunction.smethod_47(Form23.framework_1, bsk, bsL, bsl, bsM);
						if (text3 != null)
						{
							if (bool_0)
							{
								continue;
							}
							list3 = new List<string> { text3 };
						}
					}
					if (((bool_2 && list3 != null) || (bool_3 && list3 == null)) && (!bool_0 || PortFunction.smethod_40(settingOrSpecialObject, class244_0)))
					{
						method_8(bool_6: true, settingOrSpecialObject, list3, wiringPin, bsk, bsL, bsl, bsM, ref bool_);
					}
				}
				if (!bool_)
				{
					int_16 -= 35;
					continue;
				}
				Label label4 = new Label();
				label4.Text = item.ayr + Class333.smethod_876() + text2 + Class333.smethod_134();
				label4.ForeColor = Form23.color_12;
				label4.Font = new Font(label4.Font.FontFamily, 10f);
				label4.AutoSize = true;
				label4.Left = 10;
				label4.Top = top;
				class131_0.Controls.Add(label4);
			}
		}
	}

	protected void method_1()
	{
		Label label = new Label();
		label.Text = Class333.smethod_877();
		label.ForeColor = Form23.color_12;
		label.Font = new Font(label.Font.FontFamily, 12f, FontStyle.Bold);
		label.AutoSize = true;
		label.Left = 10;
		label.Top = int_16;
		class131_0.Controls.Add(label);
		int_16 += 30;
		Label label2 = new Label();
		label2.Text = Class333.smethod_873();
		label2.ForeColor = Form23.color_12;
		label2.Font = new Font(label2.Font.FontFamily, 8f, FontStyle.Bold);
		label2.AutoSize = true;
		label2.Left = 10;
		label2.Top = int_16 + 6;
		class131_0.Controls.Add(label2);
		Label label3 = new Label();
		label3.Text = Class333.smethod_874();
		label3.ForeColor = Form23.color_12;
		label3.Font = new Font(label3.Font.FontFamily, 8f, FontStyle.Bold);
		label3.AutoSize = true;
		label3.Left = 610;
		label3.Top = int_16 + 6;
		class131_0.Controls.Add(label3);
		int_16 += 25;
		Label label4 = new Label();
		label4.AutoSize = false;
		label4.Height = 1;
		label4.Width = class131_0.Width;
		label4.Left = 0;
		label4.Top = int_16;
		label4.BorderStyle = BorderStyle.FixedSingle;
		class131_0.Controls.Add(label4);
		for (int i = 0; i < PortFunction.smethod_5().Length; i++)
		{
			Enum104 @enum = PortFunction.smethod_5()[i];
			string text = PortFunction.smethod_1(@enum, Form23.framework_1);
			string text2 = PortFunction.smethod_2(@enum, Form23.framework_1);
			if (!string.IsNullOrEmpty(text))
			{
				text2 = text + Class333.smethod_497() + text2 + Class333.smethod_875();
			}
			for (int j = 0; j < PortFunction.smethod_6().Length; j++)
			{
				Enum105 enum2 = PortFunction.smethod_6()[j];
				int top = int_16 + 16;
				int_16 += 35;
				if (!method_7(bool_6: true, @enum, enum2))
				{
					int_16 -= 35;
				}
				else if (bool_5 || enum2 == enum105_0)
				{
					Label label5 = new Label();
					if (@enum == Enum104.BAM)
					{
						label5.Text = PortFunction.smethod_4(enum2) + Class333.smethod_134();
					}
					else
					{
						label5.Text = PortFunction.smethod_4(enum2) + Class333.smethod_876() + text2 + Class333.smethod_134();
					}
					label5.ForeColor = Form23.color_12;
					label5.Font = new Font(label5.Font.FontFamily, 10f);
					label5.AutoSize = true;
					label5.Left = 10;
					label5.Top = top;
					class131_0.Controls.Add(label5);
				}
			}
		}
	}

	protected void method_2()
	{
		Label label = new Label();
		label.Text = Class333.smethod_878();
		label.ForeColor = Form23.color_12;
		label.Font = new Font(label.Font.FontFamily, 12f, FontStyle.Bold);
		label.AutoSize = true;
		label.Left = 10;
		label.Top = int_16;
		class131_0.Controls.Add(label);
		int_16 += 30;
		Label label2 = new Label();
		label2.Text = Class333.smethod_873();
		label2.ForeColor = Form23.color_12;
		label2.Font = new Font(label2.Font.FontFamily, 8f, FontStyle.Bold);
		label2.AutoSize = true;
		label2.Left = 10;
		label2.Top = int_16 + 6;
		class131_0.Controls.Add(label2);
		int_16 += 25;
		Label label3 = new Label();
		label3.AutoSize = false;
		label3.Height = 1;
		label3.Width = class131_0.Width;
		label3.Left = 0;
		label3.Top = int_16;
		label3.BorderStyle = BorderStyle.FixedSingle;
		class131_0.Controls.Add(label3);
		for (int i = 0; i < PortFunction.smethod_5().Length; i++)
		{
			Enum104 @enum = PortFunction.smethod_5()[i];
			string text = PortFunction.smethod_1(@enum, Form23.framework_1);
			string text2 = PortFunction.smethod_2(@enum, Form23.framework_1);
			if (!string.IsNullOrEmpty(text))
			{
				text2 = text + Class333.smethod_497() + text2 + Class333.smethod_875();
			}
			for (int j = 0; j < PortFunction.smethod_6().Length; j++)
			{
				Enum105 enum2 = PortFunction.smethod_6()[j];
				int top = int_16 + 16;
				int_16 += 35;
				if (!method_7(bool_6: false, @enum, enum2))
				{
					int_16 -= 35;
				}
				else if (bool_5 || enum2 == enum105_0)
				{
					Label label4 = new Label();
					if (@enum == Enum104.BAM)
					{
						label4.Text = PortFunction.smethod_4(enum2) + Class333.smethod_134();
					}
					else
					{
						label4.Text = PortFunction.smethod_4(enum2) + Class333.smethod_876() + text2 + Class333.smethod_134();
					}
					label4.ForeColor = Form23.color_12;
					label4.Font = new Font(label4.Font.FontFamily, 10f);
					label4.AutoSize = true;
					label4.Left = 10;
					label4.Top = top;
					class131_0.Controls.Add(label4);
				}
			}
		}
	}

	protected void method_3()
	{
		while (class131_0.Controls.Count != 0)
		{
			Class30.smethod_0(class131_0.Controls[0]);
		}
		list_0.Clear();
		list_1.Clear();
		list_2.Clear();
		list_3.Clear();
		list_6.Clear();
		class131_0.AutoScrollPosition = new Point(0, 0);
		int_16 = 10;
	}

	protected void method_4()
	{
		list_4.Clear();
		list_5.Clear();
		foreach (Label item in list_0)
		{
			List<string> list = new List<string>();
			List<int> list2 = new List<int>();
			SettingOrSpecialObject bOR = ((Class183)item.Tag).BOR;
			Enum104 bSQ = bOR.method_12().method_12().BSQ;
			Enum105 bSq = bOR.method_12().method_12().BSq;
			byte bSR = bOR.method_12().method_12().BSR;
			ushort bSr = bOR.method_12().method_12().BSr;
			List<Class244> list3 = PortFunction.smethod_44(Form23.framework_1, bSQ, bSq, bSR, bSr, bool_0: false);
			List<int> list4 = null;
			if (list3 != null && list3.Count == 1)
			{
				list4 = list3[0].method_12().method_2();
			}
			for (int i = 0; i < bOR.method_12().method_1().Count; i++)
			{
				Setting setting = bOR.method_12().method_1()[i];
				int bBZ = setting.method_12().BBZ;
				if (bBZ == -1 || list4 == null || list4.Contains(bBZ))
				{
					setting.method_265(method_6);
					setting.method_264(method_6);
					int num = setting.method_231();
					list.Add(Class233.smethod_35(setting.method_232(), num, bool_0: false, 0));
					list2.Add(i);
				}
			}
			list_4.Add(list);
			list_5.Add(list2);
		}
	}

	protected void method_5(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate100 method = method_5;
				BeginInvoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.smethod_28(Form23.framework_1.aXc, bool_53: true) && !Form23.smethod_80())
		{
			return;
		}
		foreach (Label item in list_0)
		{
			item.Text = Class333.smethod_612();
		}
		foreach (Label item2 in list_1)
		{
			item2.Text = Class333.smethod_325();
		}
	}

	protected void method_6(object sender, EventArgs e)
	{
		if (!stopwatch_0.IsRunning)
		{
			stopwatch_0.Start();
		}
		else
		{
			if (stopwatch_0.ElapsedMilliseconds < 800L)
			{
				return;
			}
			if (InvokeRequired)
			{
				try
				{
					Delegate101 method = method_6;
					Invoke(method, sender, e);
					return;
				}
				catch
				{
					return;
				}
			}
			Setting setting = sender as Setting;
			SettingOrSpecialObject settingOrSpecialObject = ((setting.method_12().method_12().BSQ != Enum104.BAM) ? setting.method_6() : setting);
			int num = 0;
			foreach (Label item in list_0)
			{
				while (list_6.Count < list_0.Count)
				{
					list_6.Add(null);
				}
				if (((Class183)item.Tag).BOR != settingOrSpecialObject)
				{
					num++;
					continue;
				}
				bool flag;
				if (flag = list_6[num] == null)
				{
					list_6[num] = new List<bool>();
				}
				bool flag2 = false;
				for (int i = 0; i < settingOrSpecialObject.method_12().method_1().Count; i++)
				{
					if (Form23.smethod_84(settingOrSpecialObject.method_12().method_1()[i].method_64()))
					{
						flag2 = true;
						break;
					}
				}
				Label label = list_1[list_0.IndexOf(item)];
				if ((!Form23.smethod_28(Form23.framework_1.aXc, bool_53: true) || Form23.smethod_80()) && !flag2)
				{
					item.Text = Class333.smethod_612();
					label.Text = Class333.smethod_325();
					if (flag)
					{
						for (int j = 0; j < settingOrSpecialObject.method_12().method_1().Count; j++)
						{
							list_6[num].Add(item: false);
						}
					}
					break;
				}
				StringBuilder stringBuilder = new StringBuilder();
				bool flag3 = false;
				for (int k = 0; k < settingOrSpecialObject.method_12().method_1().Count; k++)
				{
					if (flag)
					{
						list_6[num].Add(item: false);
					}
					if (!list_5[num].Contains(k))
					{
						continue;
					}
					Setting setting2 = settingOrSpecialObject.method_12().method_1()[k];
					if (flag || item.Text == Class333.smethod_612())
					{
						list_6[num][k] = setting2.method_35() && PortFunction.smethod_52(setting2);
					}
					if (!list_6[num][k])
					{
						continue;
					}
					int num2 = setting2.method_256();
					int num3 = setting2.method_229() - setting2.method_228();
					if (num3 != 0)
					{
						if (list_2[num].Count <= k)
						{
							while (list_2[num].Count <= k)
							{
								list_2[num].Add(0);
							}
							list_2[num][k] = num2;
							while (list_3[num].Count <= k)
							{
								list_3[num].Add(0f);
							}
						}
						else
						{
							int num4 = num2 - list_2[num][k];
							list_2[num][k] = num2;
							if (num4 == int.MinValue)
							{
								num4 = int.MaxValue;
							}
							float val = (float)Math.Abs(num4) / (float)num3;
							val = Math.Min(val, 0.3f);
							if (val > list_3[num][k])
							{
								list_3[num][k] = val;
							}
							else
							{
								list_3[num][k] *= 0.95f;
							}
							if (list_3[num][k] > 0.03f)
							{
								flag3 = true;
							}
						}
					}
					(string, string, bool) tuple = setting2.method_253(num2);
					string text = setting2.method_60(Enum96.aYu);
					if (!string.IsNullOrEmpty(text))
					{
						stringBuilder.Append(text + Class333.smethod_571());
					}
					stringBuilder.Append(tuple.Item1);
					int num5 = list_5[num].IndexOf(k);
					if (!string.IsNullOrEmpty(tuple.Item2))
					{
						if (list_4[num][num5] == Class333.smethod_879())
						{
							stringBuilder.Append(Class333.smethod_880());
						}
						else
						{
							stringBuilder.Append(Class333.smethod_325() + list_4[num][num5]);
						}
					}
					if (num5 != list_5[num].Count - 1)
					{
						stringBuilder.Append(Class333.smethod_881());
					}
				}
				string text2 = stringBuilder.ToString();
				if (text2.EndsWith(Class333.smethod_881()))
				{
					text2 = text2.Substring(0, text2.Length - 3);
				}
				if (item.Parent != null)
				{
					Panel panel = (Panel)item.Parent;
					if (flag3)
					{
						label.Text = Class333.smethod_882();
						foreach (Control control4 in panel.Controls)
						{
							if (control4 is Label)
							{
								Label label2 = control4 as Label;
								if (label2.ForeColor != Color.Green)
								{
									label2.ForeColor = Color.Green;
								}
							}
						}
					}
					else
					{
						label.Text = Class333.smethod_325();
						if (panel.BorderStyle == BorderStyle.Fixed3D)
						{
							foreach (Control control5 in panel.Controls)
							{
								if (control5 is Label)
								{
									Label label3 = control5 as Label;
									if (label3.ForeColor != Color.DeepSkyBlue)
									{
										label3.ForeColor = Color.DeepSkyBlue;
									}
								}
							}
						}
						else
						{
							foreach (Control control6 in panel.Controls)
							{
								if (control6 is Label)
								{
									Label label4 = control6 as Label;
									if (label4.ForeColor != Form23.color_12)
									{
										label4.ForeColor = Form23.color_12;
									}
								}
							}
						}
					}
				}
				item.Text = text2;
				break;
			}
		}
	}

	protected bool method_7(bool bool_6, Enum104 enum104_2, Enum105 enum105_2)
	{
		bool bool_7 = false;
		for (int i = 0; i < Form23.framework_1.awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.awD[i];
			if (!settingOrSpecialObject.method_35())
			{
				continue;
			}
			Enum104 bSQ = settingOrSpecialObject.method_12().method_12().BSQ;
			Enum105 bSq = settingOrSpecialObject.method_12().method_12().BSq;
			byte bSR = settingOrSpecialObject.method_12().method_12().BSR;
			ushort bSr = settingOrSpecialObject.method_12().method_12().BSr;
			if ((bSq == Enum105.BaF && !bool_0) || bSQ != enum104_2 || bSq != enum105_2 || !method_15(enum104_2, bSq))
			{
				continue;
			}
			List<bool> list = new List<bool>();
			List<string> list2 = PortFunction.smethod_45(Form23.framework_1, bSQ, bSq, bSR, bSr, bool_0 || !bool_6, list);
			if (list2 == null)
			{
				string text = PortFunction.smethod_47(Form23.framework_1, bSQ, bSq, bSR, bSr);
				if (text != null)
				{
					if (bool_0)
					{
						continue;
					}
					list2 = new List<string> { text };
				}
			}
			if (((bool_6 && list2 != null) || (!bool_6 && list2 == null)) && (!bool_0 || PortFunction.smethod_40(settingOrSpecialObject, class244_0)))
			{
				method_8(bool_6, settingOrSpecialObject, list2, null, bSQ, bSq, bSR, bSr, ref bool_7);
			}
		}
		return bool_7;
	}

	protected void method_8(bool bool_6, SettingOrSpecialObject settingOrSpecialObject_0, List<string> list_7, WiringPin wiringPin_1, Enum104 enum104_2, Enum105 enum105_2, byte byte_1, ushort ushort_1, ref bool bool_7)
	{
		List<PictureBox> list = new List<PictureBox>();
		List<Label> list2 = new List<Label>();
		List<ThemedButton> list3 = new List<ThemedButton>();
		string text = string.Empty;
		List<WiringPin> list4 = WiringPin.smethod_0(Form23.framework_1, enum104_2, enum105_2, byte_1, ushort_1);
		List<ApplyAndExecuteProcess> list5 = method_9(bool_6, settingOrSpecialObject_0, enum104_2, enum105_2, byte_1, ushort_1);
		if (enum105_2 != Enum105.Bal && list4.Count != 0)
		{
			bool flag = list4.Count > 1;
			if (wiringPin_1 != null)
			{
				list4 = new List<WiringPin> { wiringPin_1 };
			}
			foreach (WiringPin item in list4)
			{
				Class183 tag;
				if (wiringPin_1 != null)
				{
					tag = new Class183
					{
						BOR = settingOrSpecialObject_0,
						BOr = wiringPin_1
					};
				}
				else
				{
					tag = ((!flag) ? new Class183
					{
						BOR = settingOrSpecialObject_0,
						BOr = null
					} : new Class183
					{
						BOR = settingOrSpecialObject_0,
						BOr = item
					});
				}
				PictureBox pictureBox = new PictureBox();
				pictureBox.BackColor = Color.Transparent;
				pictureBox.Tag = tag;
				pictureBox.MouseClick += method_21;
				pictureBox.DoubleClick += vmethod_2;
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
				pictureBox.Left = 5;
				list.Add(pictureBox);
				ThemedButton themedButton = null;
				if (item.method_13())
				{
					themedButton = new ThemedButton();
					themedButton.Text = Class333.smethod_884();
					themedButton.Tag = tag;
					themedButton.AutoSize = false;
					themedButton.Width = 85;
					themedButton.Height = 23;
					themedButton.Left = pictureBox.Right + 3;
					themedButton.MouseClick += method_22;
				}
				list3.Add(themedButton);
				Label label = new Label();
				label.Tag = tag;
				label.MouseClick += method_21;
				label.DoubleClick += vmethod_2;
				label.Text = item.method_11(flag);
				label.ForeColor = Form23.color_12;
				label.AutoSize = true;
				label.Left = pictureBox.Right + 3 + 85 + 2;
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
				if (themedButton != null)
				{
					themedButton.Top = pictureBox.Top;
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
			pictureBox2.BackColor = Color.Transparent;
			pictureBox2.Tag = new Class183
			{
				BOR = settingOrSpecialObject_0,
				BOr = wiringPin_1
			};
			pictureBox2.MouseClick += method_21;
			pictureBox2.DoubleClick += vmethod_2;
			if (enum105_2 == Enum105.Bal)
			{
				pictureBox2.Image = WiringPin.smethod_3(Color.Transparent, Color.Transparent, bool_0: false, bool_1: true, bool_2: false);
			}
			else
			{
				pictureBox2.Image = PortFunction.smethod_8(enum104_2, enum105_2);
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
			pictureBox2.Left = 5;
			list.Add(pictureBox2);
			list3.Add(null);
			Label label2 = new Label();
			label2.Tag = new Class183
			{
				BOR = settingOrSpecialObject_0,
				BOr = wiringPin_1
			};
			label2.MouseClick += method_21;
			label2.DoubleClick += vmethod_2;
			if (enum105_2 == Enum105.Bal)
			{
				label2.Text = Class333.smethod_883();
			}
			label2.ForeColor = Form23.color_12;
			label2.AutoSize = true;
			label2.Left = pictureBox2.Right + 3 + 85 + 2;
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
		label3.AutoSize = true;
		string text2 = PortFunction.smethod_37(settingOrSpecialObject_0);
		if (text2 != null)
		{
			label3.Tag = new Class183
			{
				BOR = settingOrSpecialObject_0,
				BOr = wiringPin_1
			};
			label3.MouseClick += method_21;
			label3.DoubleClick += vmethod_2;
			label3.Text = text2;
			label3.ForeColor = Form23.color_12;
			label3.Top = 0;
			label3.Left = 400;
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
		List<Label> list6 = new List<Label>();
		if (list_7 != null)
		{
			foreach (string item2 in list_7)
			{
				Label label5 = new Label();
				label5.Tag = new Class183
				{
					BOR = settingOrSpecialObject_0,
					BOr = wiringPin_1
				};
				label5.MouseClick += method_21;
				label5.DoubleClick += vmethod_2;
				label5.Text = item2;
				label5.ForeColor = Form23.color_12;
				label5.AutoSize = true;
				if (settingOrSpecialObject_0.method_12().method_1().Count != 0)
				{
					label5.Top = -10;
				}
				else
				{
					label5.Top = 0;
				}
				label5.Left = 610;
				list6.Add(label5);
			}
		}
		Label label6 = null;
		Label label7 = null;
		if (settingOrSpecialObject_0.method_12().method_1().Count != 0)
		{
			label6 = new Label();
			label6.Tag = new Class183
			{
				BOR = settingOrSpecialObject_0,
				BOr = wiringPin_1
			};
			label6.MouseClick += method_21;
			label6.DoubleClick += vmethod_2;
			label6.Text = Class333.smethod_612();
			label6.ForeColor = Form23.color_12;
			label6.AutoSize = false;
			if (bool_6 && list_7 != null && list_7.Count != 0)
			{
				label6.Top = 9;
			}
			else
			{
				bool flag2 = false;
				foreach (SettingOrSpecialObject item3 in settingOrSpecialObject_0.method_1())
				{
					if (item3.method_2().Contains(Class333.smethod_886()))
					{
						flag2 = true;
						break;
					}
				}
				label6.Top = (flag2 ? 9 : 0);
			}
			label6.Left = 610;
			label6.Width = class131_0.Width - 18 - 160 - 610;
			label6.Height = (int)((float)label6.Height * 0.7f);
			list_0.Add(label6);
			list_3.Add(new List<float>());
			list_2.Add(new List<int>());
			label7 = new Label();
			label7.Tag = new Class183
			{
				BOR = settingOrSpecialObject_0,
				BOr = wiringPin_1
			};
			label7.MouseClick += method_21;
			label7.DoubleClick += vmethod_2;
			label7.Text = Class333.smethod_325();
			label7.ForeColor = Color.Green;
			label7.AutoSize = false;
			label7.Top = label6.Top;
			label7.Left = class131_0.Width - 18 - 160;
			label7.Width = 160;
			label7.Height = (int)((float)label7.Height * 0.7f);
			list_1.Add(label7);
		}
		List<string> list7 = new List<string>(list6.Count);
		foreach (Label item4 in list6)
		{
			list7.Add(item4.Text);
		}
		List<string> list8 = new List<string>(list2.Count);
		foreach (Label item5 in list2)
		{
			list8.Add(item5.Text);
		}
		if (!smethod_0(vmethod_0(), enum105_2, enum104_2, label3.Text, list7, list8))
		{
			return;
		}
		bool_7 = true;
		int num = list6.Where((Label label_0) => label_0.Text.Contains('\n')).Count();
		int int_ = 38 + num * 12;
		int num2 = smethod_1(list, list2, list3, list6, label6, label4, int_, bool_6: false);
		Panel panel = new Panel();
		panel.SuspendLayout();
		panel.BorderStyle = BorderStyle.FixedSingle;
		panel.BackColor = class131_0.BackColor;
		panel.Location = new Point(-1, int_16);
		panel.Size = new Size(class131_0.Width, num2 + 1);
		panel.Tag = new Class183
		{
			BOR = settingOrSpecialObject_0,
			BOr = wiringPin_1
		};
		panel.MouseClick += method_21;
		panel.DoubleClick += vmethod_2;
		int_16 += num2;
		smethod_2(list, list2, list3, list6, null, label6, label7, label3, label4, num2, 38, bool_6: false);
		foreach (Label item6 in list6)
		{
			panel.Controls.Add(item6);
		}
		if (label6 != null)
		{
			panel.Controls.Add(label6);
		}
		if (label7 != null)
		{
			panel.Controls.Add(label7);
		}
		foreach (PictureBox item7 in list)
		{
			panel.Controls.Add(item7);
		}
		foreach (Label item8 in list2)
		{
			panel.Controls.Add(item8);
		}
		for (int num3 = 0; num3 < list3.Count; num3++)
		{
			if (list3[num3] != null)
			{
				panel.Controls.Add(list3[num3]);
			}
		}
		panel.Controls.Add(label3);
		if (label4 != null)
		{
			panel.Controls.Add(label4);
		}
		int num4 = 0;
		for (int num5 = 0; num5 < list5.Count; num5++)
		{
			string string_ = null;
			string text3 = Class333.smethod_887();
			string text4 = Class333.smethod_888();
			int num6 = 0;
			int num7 = 0;
			bool holdToExecuteOutputTest = list5[num5].HoldToExecuteOutputTest;
			bool flag3 = list5[num5].OwnerObject.method_2().Contains(Class333.smethod_889());
			bool flag4 = list5[num5].OwnerObject.method_5().Contains(Class333.smethod_890());
			num7 = ((!(!bool_6 & holdToExecuteOutputTest) || flag3 || flag4) ? 1 : 2);
			for (int num8 = 0; num8 < num7; num8++)
			{
				if (!bool_6)
				{
					if (flag3)
					{
						string_ = (holdToExecuteOutputTest ? text4 : null);
						num6 = (holdToExecuteOutputTest ? 2 : 3);
					}
					else if (flag4)
					{
						string_ = (holdToExecuteOutputTest ? text3 : null);
						num6 = (holdToExecuteOutputTest ? 1 : 3);
					}
					else if (holdToExecuteOutputTest)
					{
						string_ = ((num8 == 0) ? text3 : text4);
						num6 = ((num8 == 0) ? 1 : 2);
					}
					else
					{
						num6 = 3;
					}
				}
				Class86 @class = new Class86(list5[num5].OwnerObject, Form23.framework_1, Form23.framework_0, Rectangle.Empty, bool_0: false);
				@class.method_17(bool_0: true, bool_6, string_, num6);
				@class.Top = 0;
				@class.Left = 1030 + num4 * @class.Width;
				panel.Controls.Add(@class);
				num4++;
			}
		}
		panel.ResumeLayout(performLayout: false);
		class131_0.Controls.Add(panel);
	}

	private List<ApplyAndExecuteProcess> method_9(bool bool_6, SettingOrSpecialObject settingOrSpecialObject_0, Enum104 enum104_2, Enum105 enum105_2, byte byte_1, ushort ushort_1)
	{
		List<Class244> list = PortFunction.smethod_44(Form23.framework_1, enum104_2, enum105_2, byte_1, ushort_1, bool_0: false);
		PortFunction.Class272 class272_ = PortFunction.smethod_46(Form23.framework_1, enum104_2, enum105_2, byte_1, ushort_1);
		List<ApplyAndExecuteProcess> list2 = new List<ApplyAndExecuteProcess>();
		foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_1())
		{
			if (!item.method_2().Contains(Class333.smethod_886()) || !(item is SpecialObject specialObject) || (specialObject.method_68().IdleText == null && specialObject.method_68().PreApplySettingDataIds.Count == 0))
			{
				continue;
			}
			if (!bool_6)
			{
				list2.Add(specialObject.method_68());
				continue;
			}
			bool flag = false;
			if (list != null && list.Count != 0)
			{
				foreach (Class244 item2 in list)
				{
					if (PortFunction.smethod_51(item, item2, null))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				flag = PortFunction.smethod_51(item, null, class272_);
			}
			if (flag)
			{
				list2.Add(specialObject.method_68());
			}
		}
		return list2;
	}

	protected void method_10()
	{
		bool_2 = true;
		bool_3 = false;
		vmethod_1();
	}

	protected void method_11()
	{
		bool_2 = false;
		bool_3 = true;
		vmethod_1();
	}

	protected void method_12()
	{
		bool_2 = true;
		bool_3 = true;
		vmethod_1();
	}

	protected void method_13(bool bool_6, string string_0)
	{
		if (bool_6)
		{
			bool_4 = true;
			if (class185_0 != null)
			{
				class185_0.method_2();
			}
		}
		else
		{
			bool_4 = false;
			Enum104[] array = PortFunction.smethod_5();
			foreach (Enum104 @enum in array)
			{
				if (string_0 == PortFunction.smethod_2(@enum, Form23.framework_1))
				{
					enum104_0 = @enum;
					if (class185_0 != null)
					{
						class185_0.method_1(@enum);
					}
					break;
				}
			}
		}
		vmethod_1();
	}

	protected void method_14(bool bool_6, string string_0)
	{
		if (bool_6)
		{
			bool_5 = true;
		}
		else
		{
			bool_5 = false;
			Enum105[] array = PortFunction.smethod_6();
			foreach (Enum105 @enum in array)
			{
				if (string_0 == PortFunction.smethod_4(@enum))
				{
					enum105_0 = @enum;
					break;
				}
			}
		}
		vmethod_1();
	}

	internal bool method_15(Enum104 enum104_2, Enum105 enum105_2)
	{
		if (!bool_4 && enum104_2 != enum104_0)
		{
			return false;
		}
		if (!bool_5)
		{
			return enum105_2 == enum105_0;
		}
		return true;
	}

	protected void method_16(object sender, EventArgs e)
	{
		Point autoScrollPosition = class131_0.AutoScrollPosition;
		vmethod_1();
		class131_0.AutoScrollPosition = new Point(-autoScrollPosition.X, -autoScrollPosition.Y);
		class131_0.method_2();
	}

	protected void method_17(Enum51 enum51_2)
	{
		if (bool_0)
		{
			enum51_0 = enum51_2;
		}
		else
		{
			enum51_1 = enum51_2;
		}
		vmethod_1();
	}

	protected Enum51 method_18()
	{
		if (bool_0)
		{
			return enum51_0;
		}
		return enum51_1;
	}

	private void method_19(bool bool_6)
	{
		if (class185_0 != null)
		{
			if (enum104_1 != Enum104.BAB && enum104_1 != Enum104.BAM && enum105_1 != Enum105.BAU)
			{
				SettingOrSpecialObject settingOrSpecialObject_ = PortFunction.smethod_36(Form23.framework_1, enum104_1, enum105_1, byte_0, ushort_0);
				class185_0.method_7(settingOrSpecialObject_, wiringPin_0);
			}
			else
			{
				class185_0.method_8();
			}
		}
		foreach (Control control3 in class131_0.Controls)
		{
			if (!(control3 is Panel))
			{
				continue;
			}
			if (control3.Tag is Class183)
			{
				SettingOrSpecialObject bOR = ((Class183)control3.Tag).BOR;
				Enum104 bSQ = bOR.method_12().method_12().BSQ;
				Enum105 bSq = bOR.method_12().method_12().BSq;
				byte bSR = bOR.method_12().method_12().BSR;
				ushort bSr = bOR.method_12().method_12().BSr;
				if (bSQ == Enum104.BAM)
				{
					if (bSQ == enum104_1 && bSq == enum105_1 && bSr == ushort_0)
					{
						(control3 as Panel).BorderStyle = BorderStyle.Fixed3D;
						if (bool_6)
						{
							class131_0.ScrollControlIntoView(control3);
						}
					}
					else
					{
						(control3 as Panel).BorderStyle = BorderStyle.FixedSingle;
					}
				}
				else if (bSQ == enum104_1 && bSq == enum105_1 && bSR == byte_0)
				{
					(control3 as Panel).BorderStyle = BorderStyle.Fixed3D;
					if (bool_6 && (wiringPin_0 == null || ((Class183)control3.Tag).BOr == null || ((Class183)control3.Tag).BOr == wiringPin_0))
					{
						class131_0.ScrollControlIntoView(control3);
					}
				}
				else
				{
					(control3 as Panel).BorderStyle = BorderStyle.FixedSingle;
				}
			}
			foreach (Control control4 in control3.Controls)
			{
				if (!(control4 is Label) || !(control4.Tag is Class183))
				{
					continue;
				}
				SettingOrSpecialObject bOR2 = ((Class183)control4.Tag).BOR;
				Enum104 bSQ2 = bOR2.method_12().method_12().BSQ;
				Enum105 bSq2 = bOR2.method_12().method_12().BSq;
				byte bSR2 = bOR2.method_12().method_12().BSR;
				ushort bSr2 = bOR2.method_12().method_12().BSr;
				if (bSQ2 == Enum104.BAM)
				{
					if (bSQ2 == enum104_1 && bSq2 == enum105_1 && bSr2 == ushort_0)
					{
						control4.ForeColor = Color.DeepSkyBlue;
						control4.Font = new Font(control4.Font.FontFamily, control4.Font.Size, FontStyle.Bold);
					}
					else
					{
						control4.ForeColor = Form23.color_12;
						control4.Font = new Font(control4.Font.FontFamily, control4.Font.Size);
					}
				}
				else if (bSQ2 == enum104_1 && bSq2 == enum105_1 && bSR2 == byte_0)
				{
					control4.ForeColor = Color.DeepSkyBlue;
					if (WiringPin.smethod_0(Form23.framework_1, bSQ2, bSq2, bSR2, bSr2).Count == 1)
					{
						control4.Font = new Font(control4.Font.FontFamily, control4.Font.Size, FontStyle.Bold);
					}
					else if (wiringPin_0 != null && ((Class183)control4.Tag).BOr == wiringPin_0)
					{
						control4.Font = new Font(control4.Font.FontFamily, control4.Font.Size, FontStyle.Bold | FontStyle.Italic);
					}
					else
					{
						control4.Font = new Font(control4.Font.FontFamily, control4.Font.Size);
					}
				}
				else
				{
					control4.ForeColor = Form23.color_12;
					control4.Font = new Font(control4.Font.FontFamily, control4.Font.Size);
				}
			}
		}
	}

	internal void method_20(WiringPin wiringPin_1)
	{
		List<WiringPin.Class276> list = wiringPin_1.method_4();
		if (list.Count != 0)
		{
			wiringPin_0 = wiringPin_1;
			enum104_1 = list[list.Count - 1].Bsk;
			enum105_1 = list[list.Count - 1].BsL;
			byte_0 = list[list.Count - 1].Bsl;
			ushort_0 = list[list.Count - 1].BsM;
			method_19(bool_6: true);
		}
	}

	protected void method_21(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			SettingOrSpecialObject bOR = ((Class183)(sender as Control).Tag).BOR;
			if (bOR != null)
			{
				wiringPin_0 = ((Class183)(sender as Control).Tag).BOr;
				enum104_1 = bOR.method_12().method_12().BSQ;
				enum105_1 = bOR.method_12().method_12().BSq;
				byte_0 = bOR.method_12().method_12().BSR;
				ushort_0 = bOR.method_12().method_12().BSr;
				method_19(bool_6: true);
				class131_0.Focus();
			}
		}
	}

	protected void method_22(object sender, MouseEventArgs e)
	{
		if (((Class183)(sender as Control).Tag).BOR == null)
		{
			return;
		}
		method_21(sender, e);
		WiringPin wiringPin = null;
		if (wiringPin_0 != null)
		{
			wiringPin = wiringPin_0;
		}
		else
		{
			List<WiringPin> list = WiringPin.smethod_0(Form23.framework_1, enum104_1, enum105_1, byte_0, ushort_0);
			if (list.Count == 1)
			{
				wiringPin = list[0];
			}
		}
		if (wiringPin == null || !wiringPin.method_13())
		{
			return;
		}
		Form64 form = new Form64(wiringPin);
		if (form.ShowDialog(this) == DialogResult.OK)
		{
			byte abd = form.abd;
			byte abE = form.abE;
			if (wiringPin.method_14() != WiringPin.smethod_4(WiringPin.BCd[abd - 1]) || wiringPin.method_15() != WiringPin.smethod_4(WiringPin.BCd[abE - 1]))
			{
				wiringPin.method_18(abd, abE);
				Point autoScrollPosition = class131_0.AutoScrollPosition;
				vmethod_1();
				class131_0.AutoScrollPosition = new Point(-autoScrollPosition.X, -autoScrollPosition.Y);
				class131_0.method_2();
			}
		}
		form.Dispose();
	}

	protected virtual void vmethod_2(object sender, EventArgs e)
	{
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		if (class131_0.Focused)
		{
			switch (keyData)
			{
			case Keys.Right:
			case Keys.Down:
				method_24();
				return true;
			case Keys.Left:
			case Keys.Up:
				method_23();
				return true;
			}
		}
		return Class30.smethod_4(this, keyData);
	}

	private void method_23()
	{
		if (enum104_1 == Enum104.BAB)
		{
			return;
		}
		int num = method_25() - 1;
		Panel panel;
		while (true)
		{
			if (num >= 0)
			{
				panel = class131_0.Controls[num] as Panel;
				if (panel != null)
				{
					break;
				}
				num--;
				continue;
			}
			return;
		}
		method_21(panel, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
	}

	private void method_24()
	{
		if (enum104_1 == Enum104.BAB)
		{
			return;
		}
		int num = method_25() + 1;
		Panel panel;
		while (true)
		{
			if (num < class131_0.Controls.Count)
			{
				panel = class131_0.Controls[num] as Panel;
				if (panel != null)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		method_21(panel, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
	}

	private int method_25()
	{
		foreach (Control control in class131_0.Controls)
		{
			if (!(control is Panel) || !(control.Tag is Class183))
			{
				continue;
			}
			SettingOrSpecialObject bOR = ((Class183)control.Tag).BOR;
			Enum104 bSQ = bOR.method_12().method_12().BSQ;
			Enum105 bSq = bOR.method_12().method_12().BSq;
			byte bSR = bOR.method_12().method_12().BSR;
			ushort bSr = bOR.method_12().method_12().BSr;
			if (bSQ == Enum104.BAM)
			{
				if (bSQ == enum104_1 && bSq == enum105_1 && bSr == ushort_0)
				{
					return class131_0.Controls.IndexOf(control);
				}
			}
			else if (bSQ == enum104_1 && bSq == enum105_1 && bSR == byte_0)
			{
				WiringPin bOr = ((Class183)control.Tag).BOr;
				if (wiringPin_0 == null || bOr == wiringPin_0)
				{
					return class131_0.Controls.IndexOf(control);
				}
			}
		}
		return -1;
	}

	internal static bool smethod_0(string string_0, Enum105 enum105_2, Enum104 enum104_2, string string_1, List<string> list_7, List<string> list_8)
	{
		bool result = true;
		List<string> list = new List<string>();
		if (string_0 != string.Empty)
		{
			for (int i = 1; i < string_0.Length; i++)
			{
				if (string_0[i] >= '0' && string_0[i] <= '9' && string_0[i - 1] != ' ' && (string_0[i - 1] < '0' || string_0[i - 1] > '9'))
				{
					string_0 = string_0.Substring(0, i) + Class333.smethod_325() + string_0.Substring(i, string_0.Length - i);
					i++;
				}
			}
			string[] array = string_0.Split(' ', ',');
			for (int j = 0; j < array.Length; j++)
			{
				list.Add(array[j].ToLower());
			}
		}
		if (list.Count != 0)
		{
			foreach (string item in list)
			{
				bool flag;
				if (!(flag = string_1.ToLower().Contains(item)))
				{
					flag = PortFunction.smethod_4(enum105_2).ToLower().Contains(item);
				}
				if (!flag && list_7 != null)
				{
					foreach (string item2 in list_7)
					{
						if (item2.ToLower().Contains(item))
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag && list_8 != null)
				{
					foreach (string item3 in list_8)
					{
						if (item3.ToLower().Contains(item))
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					string text = PortFunction.smethod_1(enum104_2, Form23.framework_1);
					if (!string.IsNullOrEmpty(text) && text.ToLower().Contains(item))
					{
						flag = true;
					}
				}
				if (!flag)
				{
					result = false;
					break;
				}
			}
		}
		return result;
	}

	internal static int smethod_1(List<PictureBox> list_7, List<Label> list_8, List<ThemedButton> list_9, List<Label> list_10, Label label_0, Label label_1, int int_17, bool bool_6)
	{
		int num = 0;
		if (bool_6)
		{
			if (list_7.Count == 1 && list_7[0].Height + 16 > int_17 - 3)
			{
				num = list_7[0].Height + 20;
			}
			else
			{
				num = ((list_8.Count < 2) ? int_17 : (int_17 + 23 * (list_8.Count - 1)));
			}
		}
		else if (list_7.Count == 1 && list_7[0].Height > int_17 - 3)
		{
			num = list_7[0].Height + 4;
		}
		else
		{
			num = ((list_8.Count < 2) ? int_17 : (int_17 + 23 * (list_8.Count - 1)));
		}
		if (list_10 != null && list_10.Count > 1)
		{
			int num2 = ((label_0 == null) ? (list_10[0].Height * list_10.Count) : (list_10[0].Height * list_10.Count + label_0.Height));
			if (num2 > num - 3)
			{
				num = num2 + 4;
			}
		}
		if (label_1 != null)
		{
			num += 30;
		}
		return num;
	}

	internal static void smethod_2(List<PictureBox> list_7, List<Label> list_8, List<ThemedButton> list_9, List<Label> list_10, List<PictureBox> list_11, Label label_0, Label label_1, Label label_2, Label label_3, int int_17, int int_18, bool bool_6)
	{
		int num = ((label_3 != null) ? (int_17 - 30) : int_17) / 2;
		if (list_8.Count == 0)
		{
			if (list_10 != null)
			{
				if (list_10.Count == 1)
				{
					list_10[0].Top += num - 7;
					if (list_11 != null && list_11.Count == 1)
					{
						list_11[0].Top += num - 7;
					}
					if (label_0 != null)
					{
						label_0.Top += num - 7;
						if (label_1 != null)
						{
							label_1.Top = label_0.Top;
						}
					}
				}
				else if (list_10.Count != 0)
				{
					for (int i = 0; i < list_10.Count; i++)
					{
						list_10[i].Top = 2 + i * list_10[0].Height;
						if (list_11 != null && list_11.Count == list_10.Count)
						{
							list_11[i].Top = 2 + i * list_10[0].Height;
						}
					}
					if (label_0 != null)
					{
						label_0.Top = 2 + list_10[0].Height * list_10.Count;
						if (label_1 != null)
						{
							label_1.Top = label_0.Top;
						}
					}
				}
				else if (label_0 != null)
				{
					label_0.Top += num - 7;
					if (label_1 != null)
					{
						label_1.Top = label_0.Top;
					}
				}
			}
			if (bool_6 && list_7.Count != 0)
			{
				label_2.Top = 3;
			}
			else
			{
				label_2.Top += num - 7;
			}
		}
		else if (list_8.Count == 1)
		{
			if (list_7.Count == 1)
			{
				if (list_7[0].Height > int_18 - 3)
				{
					int num2 = list_7[0].Height / 2 - 7;
					if (bool_6)
					{
						list_8[0].Top += num2 + 16;
						list_7[0].Top += 16;
						if (list_9 != null && list_9.Count == 1 && list_9[0] != null)
						{
							list_9[0].Top += 16;
						}
						if (list_10 != null)
						{
							if (list_10.Count == 1)
							{
								if (list_10[0].Text.Contains(Class333.smethod_570()))
								{
									list_10[0].Top += num2 - 2;
								}
								else
								{
									list_10[0].Top += num2 + 8;
								}
								if (list_11 != null && list_11.Count == 1)
								{
									list_11[0].Top += num2 + 8;
								}
								if (label_0 != null)
								{
									label_0.Top += num2 + 8;
									if (label_1 != null)
									{
										label_1.Top = label_0.Top;
									}
								}
							}
							else if (list_10.Count != 0)
							{
								for (int j = 0; j < list_10.Count; j++)
								{
									list_10[j].Top = 2 + j * list_10[0].Height;
									if (list_11 != null && list_11.Count == list_10.Count)
									{
										list_11[j].Top = 2 + j * list_10[0].Height;
									}
								}
								if (label_0 != null)
								{
									label_0.Top = 2 + list_10[0].Height * list_10.Count;
									if (label_1 != null)
									{
										label_1.Top = label_0.Top;
									}
								}
							}
							else if (label_0 != null)
							{
								label_0.Top += num2 + 8;
								if (label_1 != null)
								{
									label_1.Top = label_0.Top;
								}
							}
						}
						label_2.Top = 3;
					}
					else
					{
						list_8[0].Top += num2;
						if (list_10 != null)
						{
							if (list_10.Count == 1)
							{
								if (list_10[0].Text.Contains(Class333.smethod_570()))
								{
									list_10[0].Top += num2 - 10;
								}
								else
								{
									list_10[0].Top += num2;
								}
								if (list_11 != null && list_11.Count == 1)
								{
									list_11[0].Top += num2;
								}
								if (label_0 != null)
								{
									label_0.Top += num2;
									if (label_1 != null)
									{
										label_1.Top = label_0.Top;
									}
								}
							}
							else if (list_10.Count != 0)
							{
								for (int k = 0; k < list_10.Count; k++)
								{
									list_10[k].Top = 2 + k * list_10[0].Height;
									if (list_11 != null && list_11.Count == list_10.Count)
									{
										list_11[k].Top = 2 + k * list_10[0].Height;
									}
								}
								if (label_0 != null)
								{
									label_0.Top = 2 + list_10[0].Height * list_10.Count;
									if (label_1 != null)
									{
										label_1.Top = label_0.Top;
									}
								}
							}
							else if (label_0 != null)
							{
								label_0.Top += num2;
								if (label_1 != null)
								{
									label_1.Top = label_0.Top;
								}
							}
						}
						label_2.Top += num2;
					}
				}
				else if (bool_6)
				{
					list_8[0].Top += num - 7 + 8;
					list_7[0].Top = num - list_7[0].Height / 2 + 8;
					if (list_9 != null && list_9.Count == 1 && list_9[0] != null)
					{
						list_9[0].Top = list_7[0].Top;
					}
					if (list_10 != null)
					{
						if (list_10.Count == 1)
						{
							if (list_10[0].Text.Contains(Class333.smethod_570()))
							{
								list_10[0].Top += num - 17;
							}
							else
							{
								list_10[0].Top += num - 7;
							}
							if (list_11 != null && list_11.Count == 1)
							{
								list_11[0].Top += num - 7;
							}
							if (label_0 != null)
							{
								label_0.Top += num - 7;
								if (label_1 != null)
								{
									label_1.Top = label_0.Top;
								}
							}
						}
						else if (list_10.Count != 0)
						{
							for (int l = 0; l < list_10.Count; l++)
							{
								list_10[l].Top = 2 + l * list_10[0].Height;
								if (list_11 != null && list_11.Count == list_10.Count)
								{
									list_11[l].Top = 2 + l * list_10[0].Height;
								}
							}
							if (label_0 != null)
							{
								label_0.Top = 2 + list_10[0].Height * list_10.Count;
								if (label_1 != null)
								{
									label_1.Top = label_0.Top;
								}
							}
						}
						else if (label_0 != null)
						{
							label_0.Top += num - 7;
							if (label_1 != null)
							{
								label_1.Top = label_0.Top;
							}
						}
					}
					label_2.Top = 3;
				}
				else
				{
					list_8[0].Top += num - 7;
					list_7[0].Top = num - list_7[0].Height / 2;
					if (list_9 != null && list_9.Count == 1 && list_9[0] != null)
					{
						list_9[0].Top = list_7[0].Top;
					}
					if (list_10 != null)
					{
						if (list_10.Count == 1)
						{
							int num3 = 0;
							if (list_10[0].Text.Contains(Class333.smethod_570()))
							{
								list_10[0].Top += num - 13;
								num3 = 6;
							}
							else
							{
								list_10[0].Top += num - 7;
							}
							if (list_11 != null && list_11.Count == 1)
							{
								list_11[0].Top += num - 7;
							}
							if (label_0 != null)
							{
								label_0.Top += num - 7 + num3;
								if (label_1 != null)
								{
									label_1.Top = label_0.Top;
								}
							}
						}
						else if (list_10.Count != 0)
						{
							for (int m = 0; m < list_10.Count; m++)
							{
								list_10[m].Top = 2 + m * list_10[0].Height;
								if (list_11 != null && list_11.Count == list_10.Count)
								{
									list_11[m].Top = 2 + m * list_10[0].Height;
								}
							}
							if (label_0 != null)
							{
								label_0.Top = 2 + list_10[0].Height * list_10.Count;
								if (label_1 != null)
								{
									label_1.Top = label_0.Top;
								}
							}
						}
						else if (label_0 != null)
						{
							label_0.Top += num - 7;
							if (label_1 != null)
							{
								label_1.Top = label_0.Top;
							}
						}
					}
					label_2.Top += num - 7;
				}
			}
		}
		else
		{
			int num4;
			if (bool_6)
			{
				if (list_10 != null)
				{
					if (list_10.Count == 1)
					{
						list_10[0].Top += num - 7;
						if (list_11 != null && list_11.Count == 1)
						{
							list_11[0].Top += num - 7;
						}
						if (label_0 != null)
						{
							label_0.Top += num - 7;
							if (label_1 != null)
							{
								label_1.Top = label_0.Top;
							}
						}
					}
					else if (list_10.Count != 0)
					{
						for (int n = 0; n < list_10.Count; n++)
						{
							list_10[n].Top = 2 + n * list_10[0].Height;
							if (list_11 != null && list_11.Count == list_10.Count)
							{
								list_11[n].Top = 2 + n * list_10[0].Height;
							}
						}
						if (label_0 != null)
						{
							label_0.Top = 2 + list_10[0].Height * list_10.Count;
							if (label_1 != null)
							{
								label_1.Top = label_0.Top;
							}
						}
					}
					else if (label_0 != null)
					{
						label_0.Top += num - 7;
						if (label_1 != null)
						{
							label_1.Top = label_0.Top;
						}
					}
				}
				label_2.Top = 3;
				num4 = num - 7 - list_8[0].Height * (list_8.Count - 1) / 2 + 8;
			}
			else
			{
				if (list_10 != null)
				{
					if (list_10.Count == 1)
					{
						list_10[0].Top += num - 7;
						if (list_11 != null && list_11.Count == 1)
						{
							list_11[0].Top += num - 7;
						}
						if (label_0 != null)
						{
							label_0.Top += num - 7;
							if (label_1 != null)
							{
								label_1.Top = label_0.Top;
							}
						}
					}
					else if (list_10.Count != 0)
					{
						for (int num5 = 0; num5 < list_10.Count; num5++)
						{
							list_10[num5].Top = 2 + num5 * list_10[0].Height;
							if (list_11 != null && list_11.Count == list_10.Count)
							{
								list_11[num5].Top = 2 + num5 * list_10[0].Height;
							}
						}
						if (label_0 != null)
						{
							label_0.Top = 2 + list_10[0].Height * list_10.Count;
							if (label_1 != null)
							{
								label_1.Top = label_0.Top;
							}
						}
					}
					else if (label_0 != null)
					{
						label_0.Top += num - 7;
						if (label_1 != null)
						{
							label_1.Top = label_0.Top;
						}
					}
				}
				label_2.Top += num - 7;
				num4 = num - 7 - list_8[0].Height * (list_8.Count - 1) / 2;
			}
			foreach (Label item in list_8)
			{
				item.Top += num4;
			}
			foreach (PictureBox item2 in list_7)
			{
				item2.Top += num4;
			}
			if (list_9 != null)
			{
				for (int num6 = 0; num6 < list_9.Count; num6++)
				{
					if (list_9[num6] != null)
					{
						list_9[num6].Top += num4;
					}
				}
			}
		}
		if (label_3 == null)
		{
			return;
		}
		if (label_2 != null)
		{
			label_2.Top += 30;
		}
		if (label_0 != null)
		{
			label_0.Top += 30;
		}
		if (label_1 != null)
		{
			label_1.Top += 30;
		}
		if (list_10 != null && list_10.Count != 0)
		{
			for (int num7 = 0; num7 < list_10.Count; num7++)
			{
				list_10[num7].Top += 30;
			}
			if (list_11 != null && list_11.Count == list_10.Count)
			{
				for (int num8 = 0; num8 < list_11.Count; num8++)
				{
					list_11[num8].Top += 30;
				}
			}
		}
		if (list_7 != null && list_7.Count != 0)
		{
			for (int num9 = 0; num9 < list_7.Count; num9++)
			{
				list_7[num9].Top += 30;
			}
		}
		if (list_8 != null && list_8.Count != 0)
		{
			for (int num10 = 0; num10 < list_8.Count; num10++)
			{
				list_8[num10].Top += 30;
			}
		}
		if (list_9 == null || list_9.Count == 0)
		{
			return;
		}
		for (int num11 = 0; num11 < list_9.Count; num11++)
		{
			if (list_9[num11] != null)
			{
				list_9[num11].Top += 30;
			}
		}
	}
}
