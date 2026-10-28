using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
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

internal class Control25 : Control24
{
	private delegate Class90 Delegate27();

	internal const int BlG = 800;

	internal const int Blg = 600;

	internal const int BlH = 500;

	internal const int Blh = 300;

	internal const int BlI = 300;

	internal const int Bli = 200;

	internal const int BlJ = 300;

	internal const int Blj = 200;

	internal const int BlK = 120;

	internal const int Blk = 150;

	internal const int BlL = 120;

	internal const int Bll = 200;

	internal const int BlM = 350;

	internal const int Blm = 250;

	internal const int BlN = 200;

	internal const int Bln = 200;

	internal const int BlO = 100;

	internal const int Blo = 100;

	internal const int BlP = 220;

	internal const int Blp = 250;

	internal const int BlQ = 200;

	internal const int Blq = 100;

	internal const int BlR = 350;

	internal const int Blr = 250;

	internal const int BlS = 600;

	internal const int Bls = 250;

	internal const int BlT = 600;

	internal const int Blt = 140;

	internal const int BlU = 600;

	internal const int Blu = 220;

	internal const int BlV = 1070;

	internal const int Blv = 570;

	[CompilerGenerated]
	private EventHandler BlW;

	private static readonly string Blw = Form23.string_2 + Class333.BCu();

	internal static readonly string BlX = Blw + Class333.BCV();

	private bool Blx;

	private Form27 BlY = new Form27();

	private Form39 Bly = new Form39();

	private List<Panel> BlZ = new List<Panel>();

	private List<string> Blz = new List<string>();

	private List<int> BMA = new List<int>();

	private List<Class131> BMa = new List<Class131>();

	private List<Size> BMB = new List<Size>();

	private ContextMenuStrip BMb;

	private int BMC = -1;

	private int BMc = -1;

	private ToolStripMenuItem BMD = new ToolStripMenuItem();

	private ToolStripMenuItem BMd = new ToolStripMenuItem();

	private ToolStripMenuItem BME = new ToolStripMenuItem();

	private ToolStripMenuItem BMe = new ToolStripMenuItem();

	private ToolStripMenuItem BMF = new ToolStripMenuItem();

	private ToolStripMenuItem BMf = new ToolStripMenuItem();

	private ToolStripMenuItem BMG = new ToolStripMenuItem();

	private ToolStripMenuItem BMg = new ToolStripMenuItem();

	[SpecialName]
	[CompilerGenerated]
	internal void method_0(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BlW;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BlW, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BlW;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BlW, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal Control25()
	{
		MouseDown += Control25_MouseDown;
		MouseMove += Control25_MouseMove;
		MouseUp += Control25_MouseUp;
	}

	internal void method_2()
	{
		method_8();
		method_4();
		if (BMb == null)
		{
			BMb = method_63();
			return;
		}
		BMb.BackColor = Form23.color_15;
		BMb.ForeColor = Form23.color_12;
	}

	internal static bool smethod_0()
	{
		if (Directory.Exists(Blw))
		{
			try
			{
				return Directory.GetFiles(Blw, Class333.smethod_1915()).Length == 0;
			}
			catch
			{
				return true;
			}
		}
		return true;
	}

	internal static void smethod_1()
	{
		if (File.Exists(BlX + Class333.Bbb()))
		{
			try
			{
				string[] array = File.ReadAllLines(BlX + Class333.Bbb());
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (File.Exists(BlX + Class333.smethod_176() + text))
					{
						string text2 = Blw + Class333.smethod_176();
						File.Copy(destFileName: (i >= 10) ? (text2 + i + Class333.smethod_325() + text) : (text2 + Class333.smethod_184() + i + Class333.smethod_325() + text), sourceFileName: BlX + Class333.smethod_176() + text);
					}
				}
				return;
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.BbC() + ex.Message);
				return;
			}
		}
		if (File.Exists(BlX + Class333.Bbc()))
		{
			try
			{
				File.Copy(BlX + Class333.Bbc(), Blw + Class333.BbD());
			}
			catch (Exception ex2)
			{
				Class23.smethod_3(Class333.BbC() + ex2.Message);
			}
		}
	}

	internal int method_3()
	{
		int num = 0;
		while (true)
		{
			if (num < TabPages.Count - 1)
			{
				if ((TabPages[num] as Class130).method_2())
				{
					break;
				}
				num++;
				continue;
			}
			return 0;
		}
		return num;
	}

	internal void method_4()
	{
		SelectedIndex = method_3();
	}

	internal Panel method_5(int int_1)
	{
		if (BlZ.Count > int_1)
		{
			return BlZ[int_1];
		}
		return null;
	}

	internal void method_6()
	{
		method_7(bool_0: true);
	}

	internal void method_7(bool bool_0)
	{
		if (bool_0)
		{
			method_12(bool_0: false);
		}
		BlZ.Clear();
		Blz.Clear();
		BMA.Clear();
		BMa.Clear();
		BMB.Clear();
		while (TabCount > 2)
		{
			Class30.smethod_0(TabPages[1]);
		}
		while (TabPages[0].Controls.Count != 0)
		{
			Class30.smethod_0(TabPages[0].Controls[0]);
		}
		(TabPages[0] as Class130).method_3(bool_2: true);
		SelectedIndex = 0;
	}

	private void method_8()
	{
		Blx = true;
		method_7(bool_0: true);
		bool flag = false;
		int num = 10;
		do
		{
			Class131 @class = new Class131();
			@class.BackColor = Form23.color_10;
			@class.BorderStyle = BorderStyle.None;
			@class.ContextMenuStrip = method_56();
			@class.Location = new Point(0, 0);
			@class.Width = TabPages[0].Width;
			@class.Height = TabPages[0].Height;
			@class.method_1(bool_1: false);
			TabPages[0].Controls.Add(@class);
			BMa.Add(@class);
			BMB.Add(new Size(0, 0));
			(TabPages[0] as Class130).method_1(Enum65.const_0);
			MovableResizablePanel item = new MovableResizablePanel(new Rectangle(0, 0, 800, 600), bool_0: true, bool_1: false, bool_2: false);
			BlZ.Add(item);
			Blz.Add(string.Empty);
			BMA.Add(-1);
			@class.Controls.Add(BlZ[0]);
			BMa.Add(null);
			BMB.Add(new Size(0, 0));
			TabPages[0].BackColor = Form23.color_10;
			TabPages[1].BackColor = Form23.color_10;
			TabPages[0].BorderStyle = (Form23.bool_43 ? BorderStyle.FixedSingle : BorderStyle.None);
			TabPages[1].BorderStyle = (Form23.bool_43 ? BorderStyle.FixedSingle : BorderStyle.None);
			int num2 = 0;
			string[] array = null;
			try
			{
				if (Directory.Exists(Blw))
				{
					array = Directory.GetFiles(Blw, Class333.smethod_1915());
					Array.Sort(array);
					if (array.Length != 0 && array[0].EndsWith(Class333.Bbd()))
					{
						for (int i = 0; i < array.Length; i++)
						{
							string string_ = array[i];
							method_9(string_, i, bool_0: false, bool_1: false);
							num2++;
						}
					}
				}
				Blx = false;
				if (BMA[0] != -1)
				{
					Form23.form23_0.control4_0.method_48(BMA[0]);
				}
				else if (!string.IsNullOrEmpty(Blz[0]))
				{
					Form23.form23_0.control4_0.method_58(Blz[0]);
				}
				flag = true;
			}
			catch
			{
				flag = false;
				if (num != 0)
				{
					num--;
				}
			}
			if (flag)
			{
				continue;
			}
			method_7(bool_0: false);
			if (num != 0)
			{
				continue;
			}
			if (array != null && num2 < array.Length)
			{
				if (Form54.smethod_6(Form23.form23_0, Class333.BbE() + array[num2] + Class333.Bbe(), Class333.BbF(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
				{
					break;
				}
			}
			else if (Form54.smethod_6(Form23.form23_0, Class333.Bbf(), Class333.BbF(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
			{
				break;
			}
		}
		while (!flag);
	}

	private void method_9(string string_0, int int_1, bool bool_0, bool bool_1)
	{
		if (string_0.EndsWith(Class333.BbG()))
		{
			using StreamReader streamReader = File.OpenText(string_0);
			string string_1 = string.Empty;
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.Bbg()))
				{
					string_1 = text.Substring(Class333.Bbg().Length);
				}
				else if (text.StartsWith(Class333.BbH()))
				{
					if (int_1 != 0)
					{
						Enum65 enum65_ = ((!bool.Parse(text.Substring(Class333.BbH().Length))) ? Enum65.const_1 : Enum65.const_0);
						method_26(string_1, enum65_, bool_0: false);
					}
				}
				else if (text.StartsWith(Class333.Bbh()))
				{
					if (!bool_0)
					{
						bool bool_2 = bool.Parse(text.Substring(Class333.Bbh().Length));
						(TabPages[TabCount - 2] as Class130).method_3(bool_2);
					}
				}
				else if (text.StartsWith(Class333.BbI()))
				{
					bool bool_3 = bool.Parse(text.Substring(Class333.BbI().Length));
					(TabPages[TabCount - 2] as Class130).method_5(bool_3);
				}
				else if (text.StartsWith(Class333.Bbi()))
				{
					BMB[int_1] = new Size(int.Parse(text.Substring(Class333.Bbi().Length)), BMB[int_1].Height);
				}
				else if (text.StartsWith(Class333.BbJ()))
				{
					BMB[int_1] = new Size(BMB[int_1].Width, int.Parse(text.Substring(Class333.BbJ().Length)));
				}
				else if (text.StartsWith(Class333.Bbj()))
				{
					BMA[int_1] = int.Parse(text.Substring(Class333.Bbj().Length));
				}
				else if (text.StartsWith(Class333.BbK()))
				{
					Blz[int_1] = text.Substring(Class333.BbK().Length);
				}
				else if (text.StartsWith(Class333.Bbk()))
				{
					int left = int.Parse(text.Substring(Class333.Bbk().Length));
					BlZ[int_1].Left = left;
				}
				else if (text.StartsWith(Class333.BbL()))
				{
					int top = int.Parse(text.Substring(Class333.BbL().Length));
					BlZ[int_1].Top = top;
				}
				else if (text.StartsWith(Class333.Bbl()))
				{
					int width = int.Parse(text.Substring(Class333.Bbl().Length));
					BlZ[int_1].Width = width;
				}
				else if (text.StartsWith(Class333.BbM()))
				{
					int height = int.Parse(text.Substring(Class333.BbM().Length));
					BlZ[int_1].Height = height;
				}
				else
				{
					if (!text.StartsWith(Class333.Bbm()))
					{
						continue;
					}
					Rectangle rectangle = method_10(streamReader);
					string text2 = text.Substring(Class333.Bbm().Length);
					if (text2 == null)
					{
						continue;
					}
					switch (text2.Length)
					{
					case 8:
						if (text2 == Class333.BbS())
						{
							Class91 class4 = new Class91(Form23.framework_1, rectangle, bool_0: true);
							class4.method_29(streamReader);
							BMa[int_1].Controls.Add(class4);
							class4.method_13();
						}
						break;
					case 9:
						switch (text2[0])
						{
						case 'T':
							if (text2 == Class333.BbT())
							{
								Class105 class13 = new Class105(Form23.framework_1, rectangle, bool_0: true);
								class13.method_28(streamReader);
								BMa[int_1].Controls.Add(class13);
								class13.Invalidate();
							}
							break;
						case 'D':
							if (text2 == Class333.Bbs())
							{
								Class92 class12 = new Class92(Form23.framework_1, rectangle, bool_0: true);
								class12.method_29(streamReader);
								BMa[int_1].Controls.Add(class12);
								class12.method_13();
							}
							break;
						}
						break;
					case 11:
						switch (text2[5])
						{
						case 'i':
							if (text2 == Class333.BbR())
							{
								Class97 class10 = new Class97(Form23.framework_1, rectangle, bool_0: true);
								class10.method_24(streamReader);
								BMa[int_1].Controls.Add(class10);
								class10.method_12();
							}
							break;
						case '3':
						{
							if (!(text2 == Class333.Bbq()))
							{
								break;
							}
							Class103 class9 = new Class103(Form23.framework_1, Form23.framework_0, rectangle, bool_0: true);
							class9.method_45(streamReader);
							BMa[int_1].Controls.Add(class9);
							if ((TabPages[int_1] as Class130).method_0() == Enum65.const_0 && BlZ[int_1] != null)
							{
								Rectangle rectangle5 = new Rectangle(BlZ[int_1].Left, BlZ[int_1].Top, BlZ[int_1].Width, BlZ[int_1].Height);
								if (rectangle == rectangle5)
								{
									Panel panel4 = BlZ[int_1];
									BlZ[int_1] = class9;
									panel4.Dispose();
								}
							}
							break;
						}
						case '2':
						{
							if (!(text2 == Class333.BbQ()))
							{
								break;
							}
							Class102 class8 = new Class102(Form23.framework_1, Form23.framework_0, rectangle, bool_0: true);
							class8.method_41(streamReader);
							BMa[int_1].Controls.Add(class8);
							if ((TabPages[int_1] as Class130).method_0() == Enum65.const_0 && BlZ[int_1] != null)
							{
								Rectangle rectangle4 = new Rectangle(BlZ[int_1].Left, BlZ[int_1].Top, BlZ[int_1].Width, BlZ[int_1].Height);
								if (rectangle == rectangle4)
								{
									Panel panel3 = BlZ[int_1];
									BlZ[int_1] = class8;
									panel3.Dispose();
								}
							}
							break;
						}
						}
						break;
					case 13:
						switch (text2[0])
						{
						case 'T':
						{
							if (!(text2 == Class333.Bbo()))
							{
								break;
							}
							Class104 class6 = new Class104(Form23.framework_1, Form23.framework_0, rectangle, bool_0: true);
							class6.method_94(streamReader);
							BMa[int_1].Controls.Add(class6);
							if ((TabPages[int_1] as Class130).method_0() == Enum65.const_0 && BlZ[int_1] != null)
							{
								Rectangle rectangle3 = new Rectangle(BlZ[int_1].Left, BlZ[int_1].Top, BlZ[int_1].Width, BlZ[int_1].Height);
								if (rectangle == rectangle3)
								{
									Panel panel2 = BlZ[int_1];
									BlZ[int_1] = class6;
									panel2.Dispose();
								}
							}
							class6.method_26();
							break;
						}
						case 'N':
							if (text2 == Class333.Bbp())
							{
								Class99 class7 = new Class99(Form23.framework_1, rectangle, bool_0: true);
								class7.method_24(streamReader);
								BMa[int_1].Controls.Add(class7);
								class7.method_12();
							}
							break;
						case 'M':
							if (text2 == Class333.BbP())
							{
								Class98 class5 = new Class98(Form23.framework_1, rectangle, bool_0: true);
								class5.method_25(streamReader);
								BMa[int_1].Controls.Add(class5);
								class5.Invalidate();
							}
							break;
						}
						break;
					case 14:
						if (text2 == Class333.Bbt())
						{
							Class93 class16 = new Class93(Form23.framework_1, rectangle, bool_0: true);
							class16.method_22(streamReader);
							BMa[int_1].Controls.Add(class16);
							class16.method_12();
						}
						break;
					case 16:
						switch (text2[5])
						{
						case 'S':
							if (text2 == Class333.BbU())
							{
								Class95 class15 = new Class95(Form23.framework_1, rectangle, bool_0: true);
								class15.method_16(streamReader);
								BMa[int_1].Controls.Add(class15);
								class15.Invalidate();
							}
							break;
						case 'E':
							if (text2 == Class333.Bbu())
							{
								Class94 class14 = new Class94(Form23.framework_1, rectangle, bool_0: true);
								class14.method_16(streamReader);
								BMa[int_1].Controls.Add(class14);
								class14.Invalidate();
							}
							break;
						}
						break;
					case 18:
						if (text2 == Class333.Bbr())
						{
							Class100 class11 = new Class100(Form23.framework_1, rectangle, bool_0: true);
							class11.method_21(streamReader);
							BMa[int_1].Controls.Add(class11);
						}
						break;
					case 19:
						if (text2 == Class333.BbN())
						{
							Class118 class3 = new Class118(Form23.framework_1, Form23.framework_0, rectangle, bool_0: true, bool_1: false, bool_2: false);
							int dataId = class3.method_46(streamReader);
							MenuNode menuNode = MenuNode.smethod_2(Form23.framework_1.awj, new DataIdAndAttrId(dataId));
							if (menuNode != null)
							{
								class3.method_15(menuNode);
								BMa[int_1].Controls.Add(class3);
								class3.method_21(bool_0: true);
							}
							else
							{
								class3.Dispose();
							}
						}
						break;
					case 21:
						switch (text2[0])
						{
						case 'K':
							if (text2 == Class333.BbO())
							{
								Class96 class2 = new Class96(Form23.framework_1, rectangle, bool_0: true);
								class2.method_16(streamReader);
								BMa[int_1].Controls.Add(class2);
								class2.Invalidate();
							}
							break;
						case 'G':
						{
							if (!(text2 == Class333.Bbn()))
							{
								break;
							}
							Class106 @class = new Class106(null, Form23.framework_1, rectangle, bool_0: true, bool_1: false);
							@class.method_21(streamReader);
							BMa[int_1].Controls.Add(@class);
							if ((TabPages[int_1] as Class130).method_0() == Enum65.const_0 && BlZ[int_1] != null)
							{
								Rectangle rectangle2 = new Rectangle(BlZ[int_1].Left, BlZ[int_1].Top, BlZ[int_1].Width, BlZ[int_1].Height);
								if (rectangle == rectangle2)
								{
									Panel panel = BlZ[int_1];
									BlZ[int_1] = @class;
									panel.Dispose();
								}
							}
							@class.method_13();
							break;
						}
						}
						break;
					}
				}
			}
		}
		else if (string_0.EndsWith(Class333.BbV()))
		{
			bool flag = File.ReadAllText(string_0).Contains(Class333.Bbv());
			using StreamReader streamReader2 = File.OpenText(string_0);
			string fileName = Path.GetFileName(string_0);
			string string_2 = fileName.Substring(0, fileName.Length - Class333.BbV().Length);
			Enum65 enum65_2 = ((!flag) ? Enum65.const_1 : Enum65.const_0);
			method_26(string_2, enum65_2, bool_0: false);
			string text3;
			while ((text3 = streamReader2.ReadLine()) != null)
			{
				if (text3.Contains(Class333.BbW()) || text3.Contains(Class333.Bbw()) || !text3.Contains(Class333.BbX()))
				{
					continue;
				}
				string text4 = text3.Substring(text3.IndexOf(Class333.BbX()) + Class333.BbX().Length);
				Rectangle rectangle_ = method_11(streamReader2);
				if (text4 == null)
				{
					continue;
				}
				switch (text4.Length)
				{
				case 20:
					if (text4 == Class333.BCb())
					{
						Class99 class23 = new Class99(Form23.framework_1, rectangle_, bool_0: true);
						class23.method_24(streamReader2);
						BMa[int_1].Controls.Add(class23);
						class23.method_12();
					}
					break;
				case 5:
					if (text4 == Class333.Bby())
					{
						Class103 class26 = new Class103(Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
						class26.method_45(streamReader2);
						BMa[int_1].Controls.Add(class26);
					}
					break;
				case 6:
					if (text4 == Class333.BbY())
					{
						Class102 class25 = new Class102(Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
						class25.method_41(streamReader2);
						BMa[int_1].Controls.Add(class25);
					}
					break;
				case 8:
					if (text4 == Class333.Bbx())
					{
						BlZ[int_1].Left = rectangle_.Left;
						BlZ[int_1].Top = rectangle_.Top;
						BlZ[int_1].Width = rectangle_.Width;
						BlZ[int_1].Height = rectangle_.Height;
						Class104 class24 = new Class104(Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
						class24.method_94(streamReader2);
						if (class24.method_16() != null)
						{
							BMA[int_1] = class24.method_16().method_64();
						}
						class24.Dispose();
					}
					break;
				case 11:
					if (text4 == Class333.BbR())
					{
						Class97 class22 = new Class97(Form23.framework_1, rectangle_, bool_0: true);
						class22.method_24(streamReader2);
						BMa[int_1].Controls.Add(class22);
						class22.method_12();
					}
					break;
				case 12:
					switch (text4[7])
					{
					case 'T':
						if (text4 == Class333.BCB())
						{
							Class105 class20 = new Class105(Form23.framework_1, rectangle_, bool_0: true);
							class20.method_28(streamReader2);
							BMa[int_1].Controls.Add(class20);
							class20.Invalidate();
						}
						break;
					case 'L':
						if (text4 == Class333.BCa())
						{
							Class93 class21 = new Class93(Form23.framework_1, rectangle_, bool_0: true);
							class21.method_22(streamReader2);
							BMa[int_1].Controls.Add(class21);
							class21.method_12();
						}
						break;
					case 'G':
						if (text4 == Class333.BCA())
						{
							Class92 class19 = new Class92(Form23.framework_1, rectangle_, bool_0: true);
							class19.method_29(streamReader2);
							BMa[int_1].Controls.Add(class19);
							class19.method_13();
						}
						break;
					}
					break;
				case 15:
					switch (text4[0])
					{
					case 'E':
						if (text4 == Class333.BbZ())
						{
							Class100 class18 = new Class100(Form23.framework_1, rectangle_, bool_0: true);
							class18.method_21(streamReader2);
							BMa[int_1].Controls.Add(class18);
						}
						break;
					case 'C':
						if (text4 == Class333.Bbz())
						{
							Class91 class17 = new Class91(Form23.framework_1, rectangle_, bool_0: true);
							class17.method_29(streamReader2);
							BMa[int_1].Controls.Add(class17);
							class17.method_13();
						}
						break;
					}
					break;
				}
			}
		}
		method_65(int_1, bool_0: false);
		method_23(int_1, 0);
		if (bool_1)
		{
			SelectedIndex = int_1;
		}
	}

	private Rectangle method_10(StreamReader streamReader_0)
	{
		int x = 0;
		int y = 0;
		int width = 0;
		int height = 0;
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.Bad()))
			{
				x = int.Parse(text.Substring(Class333.Bad().Length));
			}
			else if (text.StartsWith(Class333.BaE()))
			{
				y = int.Parse(text.Substring(Class333.BaE().Length));
			}
			else if (text.StartsWith(Class333.Bae()))
			{
				width = int.Parse(text.Substring(Class333.Bae().Length));
			}
			else if (text.StartsWith(Class333.BaF()))
			{
				height = int.Parse(text.Substring(Class333.BaF().Length));
				break;
			}
		}
		return new Rectangle(x, y, width, height);
	}

	private Rectangle method_11(StreamReader streamReader_0)
	{
		int x = 0;
		int y = 0;
		int width = 0;
		int height = 0;
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.Contains(Class333.BCC()))
			{
				x = int.Parse(text.Substring(text.IndexOf(Class333.BCC()) + Class333.BCC().Length));
			}
			else if (text.Contains(Class333.BCc()))
			{
				y = int.Parse(text.Substring(text.IndexOf(Class333.BCc()) + Class333.BCc().Length));
			}
			else if (text.Contains(Class333.BCD()))
			{
				width = int.Parse(text.Substring(text.IndexOf(Class333.BCD()) + Class333.BCD().Length));
			}
			else if (text.Contains(Class333.BCd()))
			{
				height = int.Parse(text.Substring(text.IndexOf(Class333.BCd()) + Class333.BCd().Length));
				break;
			}
		}
		return new Rectangle(x, y, width, height);
	}

	internal void method_12(bool bool_0)
	{
		if (BlZ.Count == 0 || BMa.Count == 0)
		{
			return;
		}
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		string text = Class23.smethod_10(bool_1: true);
		string text2 = Blw + Class333.smethod_1961() + text + Class333.smethod_176();
		try
		{
			if (!Directory.Exists(Blw))
			{
				Directory.CreateDirectory(Blw);
			}
			else
			{
				if (!Directory.Exists(Blw + Class333.smethod_1962()))
				{
					Directory.CreateDirectory(Blw + Class333.smethod_1962());
				}
				string[] files = Directory.GetFiles(Blw, Class333.smethod_1915());
				if (Directory.Exists(text2))
				{
					Directory.Delete(text2);
				}
				Directory.CreateDirectory(text2);
				string[] array = files;
				foreach (string obj in array)
				{
					string text3 = obj.Substring(Blw.Length + 1);
					File.Move(obj, text2 + text3);
				}
			}
			for (int j = 0; j < TabPages.Count - 1; j++)
			{
				string text4 = TabPages[j].Text;
				string text5 = Blw + Class333.smethod_176();
				text5 = ((j >= 10) ? (text5 + j + Class333.smethod_325() + text4 + Class333.BbG()) : (text5 + Class333.smethod_184() + j + Class333.smethod_325() + text4 + Class333.BbG()));
				File.Create(text5).Close();
				File.SetAttributes(text5, FileAttributes.Normal);
				method_13(text5, j);
			}
			if (!bool_0)
			{
				Directory.Delete(text2, recursive: true);
			}
		}
		catch
		{
			if (Directory.Exists(text2))
			{
				string[] files2 = Directory.GetFiles(text2, Class333.smethod_1915());
				if (files2.Length != 0)
				{
					string[] array = Directory.GetFiles(Blw, Class333.smethod_1915());
					for (int i = 0; i < array.Length; i++)
					{
						File.Delete(array[i]);
					}
					array = files2;
					foreach (string obj3 in array)
					{
						File.Move(obj3, string.Concat(str2: obj3.Substring(text2.Length), str0: Blw, str1: Class333.smethod_176()));
					}
					Directory.Delete(text2, recursive: true);
				}
			}
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.BCE(), stopwatch.ElapsedMilliseconds));
	}

	private void method_13(string string_0, int int_1)
	{
		Class131 @class = BMa[int_1];
		int x = @class.AutoScrollPosition.X;
		int y = @class.AutoScrollPosition.Y;
		string text = TabPages[int_1].Text;
		bool flag = (TabPages[int_1] as Class130).method_0() == Enum65.const_0;
		bool flag2 = (TabPages[int_1] as Class130).method_2();
		bool flag3 = (TabPages[int_1] as Class130).method_4();
		List<string> list = new List<string>();
		list.Add(Class333.Bbg() + text);
		list.Add(Class333.BbH() + flag);
		list.Add(Class333.Bbh() + flag2);
		list.Add(Class333.BbI() + flag3);
		list.Add(Class333.Bbi() + @class.Width);
		list.Add(Class333.BbJ() + @class.Height);
		if (flag && Form23.form23_0.control4_0.method_0().method_2().Count != 0)
		{
			if (BMA[int_1] != -1)
			{
				list.Add(Class333.Bbj() + BMA[int_1]);
			}
			else
			{
				list.Add(Class333.BbK() + Blz[int_1]);
			}
		}
		if (BlZ[int_1] != null)
		{
			int num = BlZ[int_1].Left - x;
			int num2 = BlZ[int_1].Top - y;
			list.Add(Class333.Bbk() + num);
			list.Add(Class333.BbL() + num2);
			list.Add(Class333.Bbl() + BlZ[int_1].Width);
			list.Add(Class333.BbM() + BlZ[int_1].Height);
		}
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
		foreach (Control control in @class.Controls)
		{
			if (control is Class118 && !flag)
			{
				(control as Class118).method_45(string_0, x, y);
			}
			else if (control is Class104)
			{
				(control as Class104).method_93(string_0, x, y);
			}
			else if (control is Class102)
			{
				(control as Class102).method_40(string_0, x, y);
			}
			else if (control is Class103)
			{
				(control as Class103).method_44(string_0, x, y);
			}
			else if (control is Class100)
			{
				(control as Class100).method_20(string_0, x, y);
			}
			else if (control is Class91)
			{
				(control as Class91).method_28(string_0, x, y);
			}
			else if (control is Class98)
			{
				(control as Class98).method_24(string_0, x, y);
			}
			else if (control is Class92)
			{
				(control as Class92).method_28(string_0, x, y);
			}
			else if (control is Class93)
			{
				(control as Class93).method_21(string_0, x, y);
			}
			else if (control is Class99)
			{
				(control as Class99).method_23(string_0, x, y);
			}
			else if (control is Class97)
			{
				(control as Class97).method_23(string_0, x, y);
			}
			else if (control is Class105)
			{
				(control as Class105).method_27(string_0, x, y);
			}
			else if (control is Class95)
			{
				(control as Class95).method_15(string_0, x, y);
			}
			else if (control is Class96)
			{
				(control as Class96).method_15(string_0, x, y);
			}
			else if (control is Class94)
			{
				(control as Class94).method_15(string_0, x, y);
			}
			else if (control is Class106)
			{
				(control as Class106).method_20(string_0, x, y);
			}
		}
	}

	[SpecialName]
	internal List<string> method_14()
	{
		return Blz;
	}

	[SpecialName]
	internal List<int> method_15()
	{
		return BMA;
	}

	protected override void OnSelectedIndexChanged(EventArgs eventArgs_0)
	{
		if (!Blx)
		{
			base.OnSelectedIndexChanged(eventArgs_0);
			Form23.smethod_53(null, null);
			Form23.bool_26 = true;
			if (SelectedIndex == TabCount - 1)
			{
				BMD_Click(null, null);
			}
			else
			{
				method_16();
			}
			if (BlW != null)
			{
				BlW(this, null);
			}
		}
	}

	private void method_16()
	{
		if (BMa.Count == 0)
		{
			return;
		}
		if ((SelectedTab as Class130).method_0() == Enum65.const_0)
		{
			if (BMA[SelectedIndex] != -1)
			{
				Form23.form23_0.control4_0.method_48(BMA[SelectedIndex]);
			}
			else if (!string.IsNullOrEmpty(Blz[SelectedIndex]))
			{
				Form23.form23_0.control4_0.method_58(Blz[SelectedIndex]);
			}
		}
		foreach (Control control in BMa[SelectedIndex].Controls)
		{
			if (control is Class104)
			{
				((Class104)control).UpdateLayout(resizingOnly: false);
				((Class104)control).method_26();
			}
			else if (control is Class102)
			{
				((Class102)control).UpdateLayout(resizingOnly: false);
			}
			else if (control is Class103)
			{
				((Class103)control).UpdateLayout(resizingOnly: false);
			}
			else if (control is Class100)
			{
				((Class100)control).UpdateLayout(resizingOnly: false);
			}
		}
		method_27();
	}

	internal void method_17(int int_1)
	{
		foreach (Class131 item in BMa)
		{
			if (item == null)
			{
				continue;
			}
			foreach (Control control in item.Controls)
			{
				if (control is Class91)
				{
					Class91 @class = control as Class91;
					if (@class.method_12() == int_1)
					{
						@class.method_14(bool_0: true);
					}
				}
				if (control is Class92)
				{
					Class92 class2 = control as Class92;
					if (class2.method_12() == int_1)
					{
						class2.method_14(bool_0: true);
					}
				}
			}
		}
	}

	internal void method_18(float float_0)
	{
		Class104.Bvd = float_0;
		foreach (Class131 item in BMa)
		{
			if (item == null)
			{
				continue;
			}
			foreach (Control control in item.Controls)
			{
				if (control is Class104)
				{
					((Class104)control).method_28();
					((Class104)control).UpdateLayout(resizingOnly: false);
					((Class104)control).method_26();
				}
			}
		}
	}

	internal void method_19()
	{
		if (BMa.Count == 0)
		{
			return;
		}
		foreach (Control control in BMa[SelectedIndex].Controls)
		{
			if (control is Class104)
			{
				((Class104)control).Invalidate();
				((Class104)control).method_17().Invalidate();
			}
		}
	}

	internal void method_20()
	{
		if (BMa.Count == 0)
		{
			return;
		}
		foreach (Control control in BMa[SelectedIndex].Controls)
		{
			if (control is Class104)
			{
				((Class104)control).method_26();
				((Class104)control).Invalidate();
				((Class104)control).method_17().Invalidate();
			}
		}
	}

	internal void method_21()
	{
		if (BMa.Count == 0)
		{
			return;
		}
		foreach (Control control in BMa[SelectedIndex].Controls)
		{
			if (control is Class103)
			{
				((Class103)control).UpdateLayout(resizingOnly: false);
				((Class103)control).Invalidate();
			}
		}
	}

	internal void method_22()
	{
		if (BMa.Count == 0)
		{
			return;
		}
		foreach (Control control in BMa[SelectedIndex].Controls)
		{
			if (control is Class102)
			{
				((Class102)control).Invalidate();
			}
		}
	}

	private void method_23(int int_1, int int_2)
	{
		if (BMa.Count <= int_1 || BMa[int_1] == null)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (Control control3 in BMa[int_1].Controls)
		{
			if (control3 is Class104)
			{
				Class104 @class = control3 as Class104;
				if (@class.method_16() != null)
				{
					list.Add(@class.method_16().method_64());
				}
			}
		}
		foreach (Control control4 in BMa[int_1].Controls)
		{
			if (control4 is Class102)
			{
				Class102 class2 = control4 as Class102;
				if (class2.method_12() != null && (int_2 == 0 || int_2 == class2.method_12().method_64()) && !list.Contains(class2.method_12().method_64()))
				{
					class2.method_14(bool_0: true);
				}
			}
			else if (control4 is Class103)
			{
				Class103 class3 = control4 as Class103;
				if (class3.method_12() != null && (int_2 == 0 || int_2 == class3.method_12().method_64()) && !list.Contains(class3.method_12().method_64()))
				{
					class3.method_14(bool_0: true);
				}
			}
		}
	}

	internal bool method_24(Control control_0)
	{
		if (BMa.Count > SelectedIndex && SelectedIndex != -1 && SelectedIndex != BMa.Count - 1)
		{
			Control control = control_0;
			do
			{
				if (!BMa[SelectedIndex].Controls.Contains(control))
				{
					control = control.Parent;
					continue;
				}
				return true;
			}
			while ((!(control is Class131) || !BMa.Contains(control as Class131)) && control != null);
		}
		return false;
	}

	internal bool method_25(Control control_0)
	{
		Control control = control_0;
		do
		{
			for (int i = 0; i < BMa.Count; i++)
			{
				Class131 @class = BMa[i];
				if (@class != null && @class.Controls.Contains(control))
				{
					return (TabPages[i] as Class130).method_4();
				}
			}
			control = control.Parent;
		}
		while ((!(control is Class131) || !BMa.Contains(control as Class131)) && control != null);
		return false;
	}

	private void method_26(string string_0, Enum65 enum65_0, bool bool_0)
	{
		Class130 @class = new Class130(string_0);
		@class.AutoScroll = false;
		Class131 class2 = new Class131();
		class2.BackColor = Form23.color_10;
		class2.BorderStyle = BorderStyle.None;
		class2.ContextMenuStrip = method_56();
		@class.method_1(enum65_0);
		@class.BorderStyle = (Form23.bool_43 ? BorderStyle.FixedSingle : BorderStyle.None);
		@class.BackColor = Form23.color_10;
		class2.Location = new Point(0, 0);
		@class.Width = TabPages[0].Width;
		@class.Height = TabPages[0].Height;
		class2.Width = @class.Width;
		class2.Height = @class.Height;
		class2.method_1(bool_1: false);
		@class.Controls.Add(class2);
		int index = TabCount - 1;
		TabPages.Insert(index, @class);
		BMa.Insert(index, class2);
		BMB.Insert(index, new Size(0, 0));
		if (enum65_0 == Enum65.const_0)
		{
			MovableResizablePanel movableResizablePanel = new MovableResizablePanel(new Rectangle(0, 0, 800, 600), bool_0: true, bool_1: false, bool_2: false);
			BlZ.Add(movableResizablePanel);
			class2.Controls.Add(movableResizablePanel);
		}
		else
		{
			BlZ.Add(null);
		}
		Blz.Add(string.Empty);
		BMA.Add(-1);
		if (bool_0)
		{
			SelectedIndex = TabCount - 2;
		}
	}

	internal void method_27()
	{
		if (BMa.Count == 0)
		{
			return;
		}
		Control control = null;
		if (Form23.dataIdAndAttrId_0.DataId != 0)
		{
			foreach (Control control8 in BMa[SelectedIndex].Controls)
			{
				if (!(control8 is Class104) || (control8 as Class104).method_16() == null || (!((control8 as Class104).method_16().method_69() == Form23.dataIdAndAttrId_0) && !((control8 as Class104).method_16().TableDataSetting.method_69() == Form23.dataIdAndAttrId_0)))
				{
					if (control8 is Interface3)
					{
						control = (control8 as Interface3).imethod_0(Form23.dataIdAndAttrId_0);
						if (control != null)
						{
							break;
						}
					}
					continue;
				}
				foreach (Control control9 in control8.Controls)
				{
					if (control9 is DataGridViewWithThemedScrollBars)
					{
						control = control9;
						break;
					}
				}
				break;
			}
			if (control == null)
			{
				foreach (Control control10 in BMa[SelectedIndex].Controls)
				{
					if (!(control10 is Class102) || (control10 as Class102).method_12() == null || (!((control10 as Class102).method_12().method_69() == Form23.dataIdAndAttrId_0) && !((control10 as Class102).method_12().TableDataSetting.method_69() == Form23.dataIdAndAttrId_0)))
					{
						if (control10 is Class103 && (control10 as Class103).method_12() != null && ((control10 as Class103).method_12().method_69() == Form23.dataIdAndAttrId_0 || (control10 as Class103).method_12().TableDataSetting.method_69() == Form23.dataIdAndAttrId_0))
						{
							control = control10 as Class103;
							break;
						}
						continue;
					}
					control = control10 as Class102;
					break;
				}
			}
			if (!Form23.bool_3)
			{
				Form23.dataIdAndAttrId_0 = new DataIdAndAttrId(0, 0);
			}
		}
		if (control == null && BMa.Count > SelectedIndex && SelectedIndex != -1 && SelectedIndex != BMa.Count - 1)
		{
			foreach (Control control11 in BMa[SelectedIndex].Controls)
			{
				if (!(control11 is Class90))
				{
					if (control11 is Class111)
					{
						control = (control11 as Class111).method_18();
						continue;
					}
					if (!(control11 is Class89))
					{
						if (!(control11 is Class104))
						{
							if (!(control11 is Interface3))
							{
								continue;
							}
							control = (control11 as Interface3).imethod_1();
							break;
						}
						foreach (Control control12 in control11.Controls)
						{
							if (control12 is DataGridViewWithThemedScrollBars)
							{
								control = control12;
								break;
							}
						}
						break;
					}
					control = control11 as Class89;
					break;
				}
				control = (control11 as Class90).method_13();
				break;
			}
			if (control == null)
			{
				foreach (Control control13 in BMa[SelectedIndex].Controls)
				{
					if (!(control13 is Class102))
					{
						if (control13 is Class103)
						{
							control = control13 as Class103;
							break;
						}
						continue;
					}
					control = control13 as Class102;
					break;
				}
			}
		}
		control?.Focus();
	}

	internal void method_28(SettingOrSpecialObject settingOrSpecialObject_0, Enum38 enum38_0, object object_0, MenuNode menuNode_0, bool bool_0)
	{
		if (BMa.Count == 0)
		{
			return;
		}
		if (enum38_0 == Enum38.const_5)
		{
			if ((SelectedTab as Class130).method_0() == Enum65.const_0)
			{
				foreach (Control control in BMa[SelectedIndex].Controls)
				{
					if (control is Class104)
					{
						if (settingOrSpecialObject_0 != null && (control as Class104).method_16() != settingOrSpecialObject_0 as Table)
						{
							Class104 @class = new Class104(rectangle_0: new Rectangle(control.Left, control.Top, control.Width, control.Height), framework_0: Form23.framework_1, framework_1: Form23.framework_0, bool_0: true);
							@class.vmethod_2((settingOrSpecialObject_0 as Setting).method_64());
							BMa[SelectedIndex].Controls.Add(@class);
							if (control == BlZ[SelectedIndex])
							{
								BlZ[SelectedIndex] = @class;
							}
							control.Dispose();
							@class.BringToFront();
							@class.method_26();
						}
					}
					else if (control is Class102)
					{
						if (settingOrSpecialObject_0 != null && (control as Class102).method_12() != settingOrSpecialObject_0 as Table)
						{
							Class102 class2 = new Class102(rectangle_0: new Rectangle(control.Left, control.Top, control.Width, control.Height), framework_0: Form23.framework_1, framework_1: Form23.framework_0, bool_0: true);
							class2.vmethod_2((settingOrSpecialObject_0 as Setting).method_64());
							BMa[SelectedIndex].Controls.Add(class2);
							if (control == BlZ[SelectedIndex])
							{
								BlZ[SelectedIndex] = class2;
							}
							control.Dispose();
							class2.BringToFront();
						}
					}
					else if (control is Class103)
					{
						if (settingOrSpecialObject_0 != null && (control as Class103).method_12() != settingOrSpecialObject_0 as Table)
						{
							Class103 class3 = new Class103(rectangle_0: new Rectangle(control.Left, control.Top, control.Width, control.Height), framework_0: Form23.framework_1, framework_1: Form23.framework_0, bool_0: true);
							class3.vmethod_2((settingOrSpecialObject_0 as Setting).method_64());
							BMa[SelectedIndex].Controls.Add(class3);
							if (control == BlZ[SelectedIndex])
							{
								BlZ[SelectedIndex] = class3;
							}
							control.Dispose();
							class3.BringToFront();
						}
					}
					else if (control is Class100)
					{
						if (settingOrSpecialObject_0 != null && (control as Class100).method_13() != settingOrSpecialObject_0 as Table)
						{
							Class100 class4 = new Class100(rectangle_0: new Rectangle(control.Left, control.Top, control.Width, control.Height), framework_0: Form23.framework_1, bool_0: true);
							class4.method_12((settingOrSpecialObject_0 as Setting).method_64());
							BMa[SelectedIndex].Controls.Add(class4);
							control.Dispose();
							class4.BringToFront();
						}
					}
					else if (control == BlZ[SelectedIndex] && settingOrSpecialObject_0 != null)
					{
						Class104 class5 = new Class104(rectangle_0: new Rectangle(control.Left, control.Top, control.Width, control.Height), framework_0: Form23.framework_1, framework_1: Form23.framework_0, bool_0: true);
						class5.vmethod_2((settingOrSpecialObject_0 as Setting).method_64());
						BMa[SelectedIndex].Controls.Add(class5);
						BlZ[SelectedIndex] = class5;
						control.Dispose();
						class5.BringToFront();
						class5.method_26();
					}
				}
			}
			else
			{
				if (settingOrSpecialObject_0 != null)
				{
					int index = method_3();
					BMA[index] = (settingOrSpecialObject_0 as Setting).method_64();
					Blz[index] = string.Empty;
				}
				method_4();
				method_28(settingOrSpecialObject_0, enum38_0, object_0, menuNode_0, bool_0);
			}
		}
		else
		{
			if ((SelectedTab as Class130).method_0() == Enum65.const_1)
			{
				if (menuNode_0 != null)
				{
					TreeNode treeNode = Form23.form23_0.control4_0.method_35(menuNode_0.method_12());
					if (treeNode != null)
					{
						int index2 = method_3();
						Blz[index2] = Form23.form23_0.control4_0.method_47(treeNode, bool_7: true, bool_8: true);
						BMA[index2] = -1;
					}
				}
				method_4();
			}
			Panel panel = BlZ[SelectedIndex];
			Rectangle rectangle_ = new Rectangle(panel.Left, panel.Top, panel.Width, panel.Height);
			switch (enum38_0)
			{
			case Enum38.const_0:
			{
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class121).method_15(bool_0: false);
					break;
				}
				Class121 class20 = new Class121(rectangle_, bool_0: true, bool_1: false);
				BMa[SelectedIndex].Controls.Add(class20);
				BlZ[SelectedIndex] = class20;
				class20.method_15(bool_0: true);
				break;
			}
			case Enum38.const_1:
			{
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class113).method_35(bool_0: false);
					break;
				}
				Class113 class17 = new Class113(object_0 as Class235, rectangle_, bool_0: true);
				BMa[SelectedIndex].Controls.Add(class17);
				BlZ[SelectedIndex] = class17;
				class17.method_35(bool_0: true);
				break;
			}
			case Enum38.const_2:
			{
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class110).method_15();
					break;
				}
				Class110 class12 = new Class110(Form23.framework_1, rectangle_, bool_0: true);
				BMa[SelectedIndex].Controls.Add(class12);
				BlZ[SelectedIndex] = class12;
				class12.method_15();
				break;
			}
			case Enum38.const_3:
			{
				if (!bool_0 && (BlZ[SelectedIndex] as Class90).method_19())
				{
					(BlZ[SelectedIndex] as Class90).method_22(bool_0: false);
					break;
				}
				Class90 class16 = new Class90(Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
				BMa[SelectedIndex].Controls.Add(class16);
				BlZ[SelectedIndex] = class16;
				class16.method_22(bool_0: true);
				break;
			}
			case Enum38.const_4:
				if (bool_0)
				{
					Class111 class21 = new Class111(rectangle_, Form23.framework_1, Form23.framework_0, bool_0: true);
					BMa[SelectedIndex].Controls.Add(class21);
					BlZ[SelectedIndex] = class21;
					if (menuNode_0 != null && menuNode_0.method_48() != null)
					{
						class21.method_20(menuNode_0.method_48());
						menuNode_0.method_49(null);
					}
				}
				break;
			case Enum38.const_6:
			{
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class115).method_23(bool_0: false);
					break;
				}
				Class115 class9 = new Class115(settingOrSpecialObject_0, menuNode_0, Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
				BMa[SelectedIndex].Controls.Add(class9);
				BlZ[SelectedIndex] = class9;
				class9.method_23(bool_0: true);
				break;
			}
			case Enum38.const_7:
			{
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class117).method_15(bool_0: false);
					break;
				}
				string string_ = string.Empty;
				if (menuNode_0 != null && menuNode_0.method_50())
				{
					string_ = menuNode_0.method_100(bool_0: false, bool_1: false);
				}
				Class117 class10 = new Class117(settingOrSpecialObject_0 as SpecialObject, string_, menuNode_0, Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true, bool_1: false);
				BMa[SelectedIndex].Controls.Add(class10);
				BlZ[SelectedIndex] = class10;
				class10.method_15(bool_0: true);
				break;
			}
			case Enum38.const_8:
				if (bool_0)
				{
					Class123 class23 = new Class123(settingOrSpecialObject_0 as SensorCalibration, menuNode_0, Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
					BMa[SelectedIndex].Controls.Add(class23);
					BlZ[SelectedIndex] = class23;
					class23.method_16();
				}
				break;
			case Enum38.const_9:
			{
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class87).Invalidate();
					break;
				}
				Class87 class18 = new Class87(settingOrSpecialObject_0 as BezierCurve, Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
				BMa[SelectedIndex].Controls.Add(class18);
				BlZ[SelectedIndex] = class18;
				class18.Invalidate();
				break;
			}
			case Enum38.const_10:
			{
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class116).method_17();
					break;
				}
				Class116 class13 = new Class116(settingOrSpecialObject_0 as StateMachine, Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
				BMa[SelectedIndex].Controls.Add(class13);
				BlZ[SelectedIndex] = class13;
				class13.method_17();
				break;
			}
			case Enum38.const_11:
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class107).Invalidate();
				}
				else if (settingOrSpecialObject_0 != null)
				{
					Class107 class7 = new Class107(settingOrSpecialObject_0 as KnockDetection, Form23.framework_1, rectangle_, bool_0: true);
					BMa[SelectedIndex].Controls.Add(class7);
					BlZ[SelectedIndex] = class7;
					class7.Invalidate();
				}
				break;
			case Enum38.const_12:
				if (bool_0)
				{
					Class86 class22 = new Class86(settingOrSpecialObject_0 as SpecialObject, Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
					BMa[SelectedIndex].Controls.Add(class22);
					BlZ[SelectedIndex] = class22;
					class22.method_17();
				}
				break;
			case Enum38.const_13:
				if (bool_0 && settingOrSpecialObject_0 != null)
				{
					Class114 class19 = new Class114(settingOrSpecialObject_0 as OnOffSwitchingPoint, Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
					BMa[SelectedIndex].Controls.Add(class19);
					BlZ[SelectedIndex] = class19;
					class19.method_17();
				}
				break;
			case Enum38.const_14:
				if (bool_0)
				{
					if (settingOrSpecialObject_0.method_13().HasGroups())
					{
						Class120 class14 = new Class120(settingOrSpecialObject_0.method_13(), Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
						BMa[SelectedIndex].Controls.Add(class14);
						BlZ[SelectedIndex] = class14;
						class14.method_16();
					}
					else
					{
						Class119 class15 = new Class119(settingOrSpecialObject_0.method_13(), Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
						BMa[SelectedIndex].Controls.Add(class15);
						BlZ[SelectedIndex] = class15;
						class15.method_16();
					}
				}
				break;
			case Enum38.const_15:
			{
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class89).method_14(bool_0: false);
					break;
				}
				Class89 class11 = new Class89(Form23.framework_1, rectangle_, bool_0: true);
				BMa[SelectedIndex].Controls.Add(class11);
				BlZ[SelectedIndex] = class11;
				class11.method_14(bool_0: true);
				break;
			}
			case Enum38.const_16:
			{
				if (!bool_0)
				{
					(BlZ[SelectedIndex] as Class122).method_20();
					break;
				}
				Class122 class8 = new Class122(Form23.framework_1, rectangle_, bool_0: true);
				BMa[SelectedIndex].Controls.Add(class8);
				BlZ[SelectedIndex] = class8;
				class8.method_20();
				break;
			}
			case Enum38.const_17:
				if (bool_0)
				{
					Class106 class6 = new Class106(menuNode_0, Form23.framework_1, rectangle_, bool_0: true, bool_1: false);
					BMa[SelectedIndex].Controls.Add(class6);
					BlZ[SelectedIndex] = class6;
					class6.method_13();
				}
				break;
			}
			BMa[SelectedIndex].Controls[BMa[SelectedIndex].Controls.Count - 1].BringToFront();
			if (bool_0 || (enum38_0 == Enum38.const_3 && !(panel as Class90).method_19()))
			{
				panel.Dispose();
			}
		}
		if (enum38_0 == Enum38.const_5)
		{
			if (settingOrSpecialObject_0 != null)
			{
				BMA[SelectedIndex] = (settingOrSpecialObject_0 as Setting).method_64();
			}
			Blz[SelectedIndex] = string.Empty;
		}
		else
		{
			Blz[SelectedIndex] = Form23.form23_0.control4_0.method_47(Form23.form23_0.control4_0.method_0().method_3(), bool_7: true, bool_8: true);
			BMA[SelectedIndex] = -1;
		}
	}

	internal void method_29(MenuNode menuNode_0, bool bool_0)
	{
		if (BMa.Count == 0 || SelectedIndex >= BlZ.Count)
		{
			return;
		}
		if ((SelectedTab as Class130).method_0() == Enum65.const_1)
		{
			TreeNode treeNode = Form23.form23_0.control4_0.method_35(menuNode_0.method_12());
			if (treeNode != null)
			{
				int index = method_3();
				Blz[index] = Form23.form23_0.control4_0.method_47(treeNode, bool_7: true, bool_8: true);
				BMA[index] = -1;
			}
			method_4();
		}
		Panel panel = BlZ[SelectedIndex];
		Rectangle rectangle_ = new Rectangle(panel.Left, panel.Top, panel.Width, panel.Height);
		if (menuNode_0.method_29())
		{
			if (bool_0)
			{
				Class124 @class = new Class124(Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true, bool_1: false);
				@class.method_12(menuNode_0);
				BMa[SelectedIndex].Controls.Add(@class);
				BlZ[SelectedIndex] = @class;
				@class.method_18(bool_0: true);
				@class.BringToFront();
			}
			else
			{
				(BlZ[SelectedIndex] as Class124).method_18(bool_0: false);
			}
		}
		else if (bool_0)
		{
			Class118 class2 = new Class118(Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true, bool_1: false, bool_2: false);
			class2.method_15(menuNode_0);
			BMa[SelectedIndex].Controls.Add(class2);
			BlZ[SelectedIndex] = class2;
			class2.method_21(bool_0: true);
			class2.BringToFront();
		}
		else if (BlZ[SelectedIndex] is Class118 class3)
		{
			class3.method_21(bool_0: false);
		}
		if (bool_0)
		{
			panel.Dispose();
		}
		Blz[SelectedIndex] = Form23.form23_0.control4_0.method_47(Form23.form23_0.control4_0.method_0().method_3(), bool_7: true, bool_8: true);
		BMA[SelectedIndex] = -1;
	}

	internal void method_30(int int_1)
	{
		if (BlZ[SelectedIndex] is Class118)
		{
			Class118 @class = BlZ[SelectedIndex] as Class118;
			if (@class.method_41() != null)
			{
				@class.method_41().method_15(int_1);
			}
		}
	}

	internal void method_31()
	{
		if (BlZ[SelectedIndex] is Class118)
		{
			Class118 @class = BlZ[SelectedIndex] as Class118;
			if (@class.method_41() != null)
			{
				@class.method_41().method_27();
			}
		}
	}

	internal void method_32()
	{
		if (BlZ[SelectedIndex] is Class118)
		{
			Class118 @class = BlZ[SelectedIndex] as Class118;
			if (@class.method_41() != null)
			{
				@class.method_41().method_22();
			}
		}
	}

	internal Class90 method_33()
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate27 method = method_33;
				return Invoke(method) as Class90;
			}
			catch
			{
				return null;
			}
		}
		if (SelectedIndex != -1 && BlZ.Count > SelectedIndex)
		{
			return BlZ[SelectedIndex] as Class90;
		}
		return null;
	}

	internal void method_34()
	{
		if (BMa.Count <= SelectedIndex || SelectedIndex == -1 || SelectedIndex == BMa.Count - 1)
		{
			return;
		}
		foreach (Control control in BMa[SelectedIndex].Controls)
		{
			if (control is Class104)
			{
				(control as Class104).method_40();
			}
		}
	}

	internal void method_35(Point point_0, MenuNode menuNode_0)
	{
		if (TabPages[SelectedIndex] is Class130 && (TabPages[SelectedIndex] as Class130).method_4())
		{
			Form54.smethod_6(this, Class333.BCe(), Class333.BCF(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(menuNode_0.method_3());
		bool flag = false;
		if (settingOrSpecialObject is Table)
		{
			Table table = settingOrSpecialObject as Table;
			foreach (Control control in BMa[SelectedIndex].Controls)
			{
				Rectangle rectangle_ = new Rectangle(control.Left, control.Top, control.Width, control.Height);
				if (!rectangle_.Contains(point_0))
				{
					continue;
				}
				if (!(control is Class104))
				{
					if (!(control is Class102))
					{
						if (!(control is Class103))
						{
							if (control is Class100)
							{
								Class100 @class = new Class100(Form23.framework_1, rectangle_, bool_0: true);
								@class.method_12(table.method_64());
								BMa[SelectedIndex].Controls.Add(@class);
								@class.BringToFront();
								flag = true;
								control.Dispose();
								break;
							}
							continue;
						}
						Class103 class2 = new Class103(Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
						class2.vmethod_2(table.method_64());
						BMa[SelectedIndex].Controls.Add(class2);
						class2.BringToFront();
						flag = true;
						if ((SelectedTab as Class130).method_0() == Enum65.const_0 && BlZ[SelectedIndex] == control)
						{
							BlZ[SelectedIndex] = class2;
						}
						Class30.smethod_0(control);
						class2.Focus();
						break;
					}
					Class102 class3 = new Class102(Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
					class3.vmethod_2(table.method_64());
					BMa[SelectedIndex].Controls.Add(class3);
					class3.BringToFront();
					flag = true;
					if ((SelectedTab as Class130).method_0() == Enum65.const_0 && BlZ[SelectedIndex] == control)
					{
						BlZ[SelectedIndex] = class3;
					}
					Class30.smethod_0(control);
					class3.Focus();
					break;
				}
				Class104 class4 = new Class104(Form23.framework_1, Form23.framework_0, rectangle_, bool_0: true);
				class4.vmethod_2(table.method_64());
				BMa[SelectedIndex].Controls.Add(class4);
				class4.BringToFront();
				class4.method_26();
				flag = true;
				if ((SelectedTab as Class130).method_0() == Enum65.const_0 && BlZ[SelectedIndex] == control)
				{
					BlZ[SelectedIndex] = class4;
				}
				Class30.smethod_0(control);
				class4.Focus();
				break;
			}
		}
		if (!flag)
		{
			if (settingOrSpecialObject != null)
			{
				if (settingOrSpecialObject is Table)
				{
					Table table2 = settingOrSpecialObject as Table;
					Class104 class5 = new Class104(rectangle_0: new Rectangle(point_0.X, point_0.Y, 500, 300), framework_0: Form23.framework_1, framework_1: Form23.framework_0, bool_0: true);
					class5.vmethod_2(table2.method_64());
					BMa[SelectedIndex].Controls.Add(class5);
					class5.BringToFront();
					class5.method_26();
					class5.Focus();
				}
				else if (settingOrSpecialObject is Class255)
				{
					Class106 class6 = new Class106(rectangle_0: new Rectangle(point_0.X, point_0.Y, 1070, 570), menuNode_0: menuNode_0, framework_0: Form23.framework_1, bool_0: true, bool_1: false);
					BMa[SelectedIndex].Controls.Add(class6);
					class6.method_13();
					class6.BringToFront();
					class6.Focus();
				}
			}
			else
			{
				foreach (MenuNode item in menuNode_0.method_6())
				{
					if (item.method_28())
					{
						Class118 class7 = new Class118(rectangle_0: new Rectangle(point_0.X, point_0.Y, 800, 600), framework_0: Form23.framework_1, framework_1: Form23.framework_0, bool_0: true, bool_1: false, bool_2: false);
						class7.method_15(menuNode_0);
						BMa[SelectedIndex].Controls.Add(class7);
						class7.method_21(bool_0: true);
						class7.BringToFront();
						break;
					}
				}
			}
		}
		method_12(bool_0: false);
	}

	internal void method_36(Point point_0, MenuNode menuNode_0)
	{
		if (!(Form23.framework_1.method_33(menuNode_0.method_3()) is Table))
		{
			return;
		}
		foreach (Control control in BMa[SelectedIndex].Controls)
		{
			if (control is Class104 || control is Class102 || control is Class103 || control is Class100)
			{
				Rectangle rectangle = new Rectangle(control.Left, control.Top, control.Width, control.Height);
				((MovableResizablePanel)control).method_11(rectangle.Contains(point_0));
			}
		}
	}

	internal void method_37(Control control_0)
	{
		Rectangle rectangle_ = new Rectangle(control_0.Left, control_0.Top, control_0.Width, control_0.Height);
		if (control_0 is Class104)
		{
			Class104 @class = control_0 as Class104;
			Class103 class2 = method_43(@class.method_16(), rectangle_);
			if (class2 != null)
			{
				class2.method_14(bool_0: true);
				if ((SelectedTab as Class130).method_0() == Enum65.const_0 && BlZ[SelectedIndex] == @class)
				{
					BlZ[SelectedIndex] = class2;
				}
				Class30.smethod_0(@class);
				class2.Focus();
			}
		}
		else if (control_0 is Class103)
		{
			Class103 class3 = control_0 as Class103;
			Class102 class4 = method_41(class3.method_12(), rectangle_);
			if (class4 != null)
			{
				class4.method_14(bool_0: true);
				if ((SelectedTab as Class130).method_0() == Enum65.const_0 && BlZ[SelectedIndex] == class3)
				{
					BlZ[SelectedIndex] = class4;
				}
				Class30.smethod_0(class3);
				class4.Focus();
			}
		}
		else if (control_0 is Class102)
		{
			Class102 class5 = control_0 as Class102;
			Class104 class6 = method_39(class5.method_12(), rectangle_);
			if (class6 != null)
			{
				if ((SelectedTab as Class130).method_0() == Enum65.const_0 && BlZ[SelectedIndex] == class5)
				{
					BlZ[SelectedIndex] = class6;
				}
				Class30.smethod_0(class5);
				if (class6.method_17() != null)
				{
					class6.method_17().Focus();
				}
			}
		}
		method_12(bool_0: false);
	}

	internal Point method_38(object object_0)
	{
		Point result = default;
		if (object_0 != null && SelectedTab != null && BMa[SelectedIndex].ContextMenuStrip != null)
		{
			result = PointToClient(BMa[SelectedIndex].ContextMenuStrip.Bounds.Location);
			result.X -= BMa[SelectedIndex].Left + SelectedTab.Left;
			result.Y -= BMa[SelectedIndex].Top + SelectedTab.Top;
		}
		else
		{
			result.X = 0;
			result.Y = 0;
		}
		return result;
	}

	internal Class104 method_39(Table table_0, Rectangle rectangle_0)
	{
		Class104 @class = new Class104(Form23.framework_1, Form23.framework_0, rectangle_0, bool_0: true);
		int int_ = 0;
		if (table_0 != null)
		{
			int_ = table_0.method_64();
		}
		@class.vmethod_2(int_);
		BMa[SelectedIndex].Controls.Add(@class);
		@class.BringToFront();
		@class.method_26();
		return @class;
	}

	internal void method_40(object sender, EventArgs e)
	{
		if (Form23.framework_1 == null)
		{
			return;
		}
		Point point = method_38(sender);
		Rectangle rectangle_ = new Rectangle(point.X, point.Y, 500, 300);
		if ((SelectedTab as Class130).method_0() == Enum65.const_0)
		{
			SettingOrSpecialObject settingOrSpecialObject = Form23.form23_0.control4_0.method_67();
			if (settingOrSpecialObject != null && !(settingOrSpecialObject is Table))
			{
				settingOrSpecialObject = null;
			}
			method_39(settingOrSpecialObject as Table, rectangle_);
		}
		else
		{
			int num = Form46.smethod_0(Form23.form23_0, Form23.framework_1);
			if (num != 0)
			{
				Setting setting = Form23.framework_1.method_31(num);
				if (setting != null)
				{
					method_39(setting as Table, rectangle_);
				}
			}
		}
		method_12(bool_0: false);
	}

	internal Class102 method_41(Table table_0, Rectangle rectangle_0)
	{
		Class102 @class = new Class102(Form23.framework_1, Form23.framework_0, rectangle_0, bool_0: true);
		int int_ = 0;
		if (table_0 != null)
		{
			int_ = table_0.method_64();
		}
		@class.vmethod_2(int_);
		BMa[SelectedIndex].Controls.Add(@class);
		@class.BringToFront();
		if (table_0 != null)
		{
			method_23(SelectedIndex, table_0.method_64());
		}
		return @class;
	}

	internal void method_42(object sender, EventArgs e)
	{
		if (Form23.framework_1 == null)
		{
			return;
		}
		Point point = method_38(sender);
		Rectangle rectangle_ = new Rectangle(point.X, point.Y, 300, 200);
		if ((SelectedTab as Class130).method_0() == Enum65.const_0)
		{
			SettingOrSpecialObject settingOrSpecialObject = Form23.form23_0.control4_0.method_67();
			if (settingOrSpecialObject != null && !(settingOrSpecialObject is Table))
			{
				settingOrSpecialObject = null;
			}
			method_41(settingOrSpecialObject as Table, rectangle_);
		}
		else
		{
			int num = Form46.smethod_0(Form23.form23_0, Form23.framework_1);
			if (num != 0)
			{
				Setting setting = Form23.framework_1.method_31(num);
				if (setting != null)
				{
					method_41(setting as Table, rectangle_);
				}
			}
		}
		method_12(bool_0: false);
	}

	internal Class103 method_43(Table table_0, Rectangle rectangle_0)
	{
		Class103 @class = new Class103(Form23.framework_1, Form23.framework_0, rectangle_0, bool_0: true);
		int int_ = 0;
		if (table_0 != null)
		{
			int_ = table_0.method_64();
		}
		@class.vmethod_2(int_);
		BMa[SelectedIndex].Controls.Add(@class);
		@class.BringToFront();
		if (table_0 != null)
		{
			method_23(SelectedIndex, table_0.method_64());
		}
		return @class;
	}

	internal void method_44(object sender, EventArgs e)
	{
		if (Form23.framework_1 == null)
		{
			return;
		}
		Point point = method_38(sender);
		Rectangle rectangle_ = new Rectangle(point.X, point.Y, 300, 200);
		if ((SelectedTab as Class130).method_0() == Enum65.const_0)
		{
			SettingOrSpecialObject settingOrSpecialObject = Form23.form23_0.control4_0.method_67();
			if (settingOrSpecialObject != null && !(settingOrSpecialObject is Table))
			{
				settingOrSpecialObject = null;
			}
			method_43(settingOrSpecialObject as Table, rectangle_);
		}
		else
		{
			int num = Form46.smethod_0(Form23.form23_0, Form23.framework_1);
			if (num != 0)
			{
				Setting setting = Form23.framework_1.method_31(num);
				if (setting != null)
				{
					method_43(setting as Table, rectangle_);
				}
			}
		}
		method_12(bool_0: false);
	}

	internal void method_45(object sender, EventArgs e)
	{
		if (Form23.framework_1 == null)
		{
			return;
		}
		Point point = method_38(sender);
		Rectangle rectangle_ = new Rectangle(point.X, point.Y, 120, 150);
		if ((SelectedTab as Class130).method_0() == Enum65.const_0)
		{
			bool flag = false;
			foreach (Control control in BMa[SelectedIndex].Controls)
			{
				if (control is Class100)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				Form54.smethod_6(Form23.form23_0, Class333.BCf(), Class333.BCG(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				SettingOrSpecialObject settingOrSpecialObject = Form23.form23_0.control4_0.method_67();
				if (settingOrSpecialObject != null && !(settingOrSpecialObject is Table))
				{
					settingOrSpecialObject = null;
				}
				Class100 @class = new Class100(Form23.framework_1, rectangle_, bool_0: true);
				int int_ = 0;
				if (settingOrSpecialObject != null)
				{
					int_ = (settingOrSpecialObject as Table).method_64();
				}
				@class.method_12(int_);
				BMa[SelectedIndex].Controls.Add(@class);
				@class.BringToFront();
			}
		}
		else
		{
			int num = Form46.smethod_0(Form23.form23_0, Form23.framework_1);
			if (num != 0)
			{
				Setting setting = Form23.framework_1.method_31(num);
				Class100 class2 = new Class100(Form23.framework_1, rectangle_, bool_0: true);
				class2.method_12(setting.method_64());
				BMa[SelectedIndex].Controls.Add(class2);
				class2.BringToFront();
			}
		}
		method_12(bool_0: false);
	}

	internal void method_46(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class91 @class = new Class91(rectangle_0: new Rectangle(point.X, point.Y, 120, 200), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.method_13();
			@class.method_24(null, null);
		}
	}

	internal void method_47(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class98 @class = new Class98(rectangle_0: new Rectangle(point.X, point.Y, 350, 250), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.Invalidate();
			@class.method_21(null, null);
		}
	}

	internal void method_48(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class92 @class = new Class92(rectangle_0: new Rectangle(point.X, point.Y, 200, 200), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.method_13();
			@class.method_24(null, null);
		}
	}

	internal void method_49(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class93 @class = new Class93(rectangle_0: new Rectangle(point.X, point.Y, 100, 100), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.method_12();
			@class.method_18(null, null);
		}
	}

	internal void method_50(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class99 @class = new Class99(rectangle_0: new Rectangle(point.X, point.Y, 200, 100), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.method_12();
			@class.method_19(null, null);
		}
	}

	internal void method_51(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class97 @class = new Class97(rectangle_0: new Rectangle(point.X, point.Y, 220, 250), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.method_12();
			@class.method_19(null, null);
		}
	}

	internal void method_52(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class105 @class = new Class105(rectangle_0: new Rectangle(point.X, point.Y, 350, 250), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.Invalidate();
			@class.method_24(null, null);
		}
	}

	internal void method_53(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class95 @class = new Class95(rectangle_0: new Rectangle(point.X, point.Y, 600, 250), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.Invalidate();
		}
	}

	internal void method_54(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class96 @class = new Class96(rectangle_0: new Rectangle(point.X, point.Y, 600, 140), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.Invalidate();
		}
	}

	internal void method_55(object sender, EventArgs e)
	{
		if (Form23.framework_1 != null)
		{
			Point point = method_38(sender);
			Class94 @class = new Class94(rectangle_0: new Rectangle(point.X, point.Y, 600, 220), framework_0: Form23.framework_1, bool_0: true);
			BMa[SelectedIndex].Controls.Add(@class);
			@class.BringToFront();
			@class.Invalidate();
		}
	}

	private ContextMenuStrip method_56()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.Opening += method_57;
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.BCg();
		toolStripMenuItem.Click += method_61;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.BCH();
		toolStripMenuItem2.Click += method_59;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		contextMenuStrip.Items.Add(new ToolStripSeparator());
		ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
		toolStripMenuItem3.Text = Class333.BCh();
		toolStripMenuItem3.Click += method_40;
		contextMenuStrip.Items.Add(toolStripMenuItem3);
		ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
		toolStripMenuItem4.Text = Class333.BCI();
		toolStripMenuItem4.Click += method_42;
		contextMenuStrip.Items.Add(toolStripMenuItem4);
		ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem();
		toolStripMenuItem5.Text = Class333.BCi();
		toolStripMenuItem5.Click += method_44;
		contextMenuStrip.Items.Add(toolStripMenuItem5);
		ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem();
		toolStripMenuItem6.Text = Class333.BCJ();
		toolStripMenuItem6.Click += method_45;
		contextMenuStrip.Items.Add(toolStripMenuItem6);
		ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem();
		toolStripMenuItem7.Text = Class333.BCj();
		toolStripMenuItem7.Click += method_46;
		contextMenuStrip.Items.Add(toolStripMenuItem7);
		ToolStripMenuItem toolStripMenuItem8 = new ToolStripMenuItem();
		toolStripMenuItem8.Text = Class333.BCK();
		toolStripMenuItem8.Click += method_47;
		contextMenuStrip.Items.Add(toolStripMenuItem8);
		ToolStripMenuItem toolStripMenuItem9 = new ToolStripMenuItem();
		toolStripMenuItem9.Text = Class333.BCk();
		toolStripMenuItem9.Click += method_48;
		contextMenuStrip.Items.Add(toolStripMenuItem9);
		ToolStripMenuItem toolStripMenuItem10 = new ToolStripMenuItem();
		toolStripMenuItem10.Text = Class333.aAx();
		toolStripMenuItem10.Click += method_49;
		contextMenuStrip.Items.Add(toolStripMenuItem10);
		ToolStripMenuItem toolStripMenuItem11 = new ToolStripMenuItem();
		toolStripMenuItem11.Text = Class333.BCL();
		toolStripMenuItem11.Click += method_51;
		contextMenuStrip.Items.Add(toolStripMenuItem11);
		ToolStripMenuItem toolStripMenuItem12 = new ToolStripMenuItem();
		toolStripMenuItem12.Text = Class333.BCl();
		toolStripMenuItem12.Click += method_50;
		contextMenuStrip.Items.Add(toolStripMenuItem12);
		ToolStripMenuItem toolStripMenuItem13 = new ToolStripMenuItem();
		toolStripMenuItem13.Text = Class333.BAm();
		toolStripMenuItem13.Click += method_52;
		contextMenuStrip.Items.Add(toolStripMenuItem13);
		if (Form23.framework_1 != null && Form23.framework_1.awO != null)
		{
			ToolStripMenuItem toolStripMenuItem14 = new ToolStripMenuItem();
			toolStripMenuItem14.Text = Class333.BCM();
			toolStripMenuItem14.Click += method_53;
			contextMenuStrip.Items.Add(toolStripMenuItem14);
			ToolStripMenuItem toolStripMenuItem15 = new ToolStripMenuItem();
			toolStripMenuItem15.Text = Class333.BCm();
			toolStripMenuItem15.Click += method_54;
			contextMenuStrip.Items.Add(toolStripMenuItem15);
			if (Form23.framework_1.awO.DataIdsOfAngleBucketChannels != null && Form23.framework_1.awO.DataIdsOfAngleBucketChannels.Count != 0)
			{
				ToolStripMenuItem toolStripMenuItem16 = new ToolStripMenuItem();
				toolStripMenuItem16.Text = Class333.smethod_466();
				toolStripMenuItem16.Click += method_55;
				contextMenuStrip.Items.Add(toolStripMenuItem16);
			}
		}
		return contextMenuStrip;
	}

	private void method_57(object sender, CancelEventArgs e)
	{
		ContextMenuStrip contextMenuStrip = sender as ContextMenuStrip;
		if (TabPages[SelectedIndex] is Class130 && (TabPages[SelectedIndex] as Class130).method_4())
		{
			foreach (object item in contextMenuStrip.Items)
			{
				if (item is ToolStripMenuItem toolStripMenuItem)
				{
					if (!(toolStripMenuItem.Text == Class333.BCH()) && !(toolStripMenuItem.Text == Class333.BCN()))
					{
						toolStripMenuItem.Enabled = false;
					}
					else
					{
						toolStripMenuItem.Text = Class333.BCN();
					}
				}
			}
			return;
		}
		foreach (object item2 in contextMenuStrip.Items)
		{
			if (item2 is ToolStripMenuItem toolStripMenuItem2)
			{
				if (!(toolStripMenuItem2.Text == Class333.BCH()) && !(toolStripMenuItem2.Text == Class333.BCN()))
				{
					toolStripMenuItem2.Enabled = true;
				}
				else
				{
					toolStripMenuItem2.Text = Class333.BCH();
				}
			}
		}
	}

	private void BMD_Click(object sender, EventArgs e)
	{
		if (BlY.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			if (BlY.method_3())
			{
				BMF_Click(null, null);
				return;
			}
			if (!string.IsNullOrEmpty(BlY.method_2()))
			{
				method_58(BlY.method_2());
				return;
			}
			method_26(BlY.method_0(), BlY.method_1(), bool_0: true);
			method_12(bool_0: false);
		}
		else if (SelectedIndex == TabCount - 1)
		{
			method_4();
		}
	}

	private void method_58(string string_0)
	{
		bool flag = false;
		try
		{
			using StreamReader streamReader = File.OpenText(string_0);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.Bbg()))
				{
					if (text.Substring(Class333.Bbg().Length).Equals(Class333.smethod_1718()))
					{
						flag = true;
					}
					break;
				}
			}
		}
		catch
		{
			Form54.smethod_6(Form23.form23_0, Class333.BCn(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (flag)
		{
			if (Form54.smethod_9(Form23.form23_0, Class333.BCO(), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
			{
				Class333.BCo(),
				Class333.BCP()
			}) == DialogResult.Yes)
			{
				MovableResizablePanel value = new MovableResizablePanel(new Rectangle(0, 0, 800, 600), bool_0: true, bool_1: false, bool_2: false);
				BlZ[0] = value;
				while (BMa[0].Controls.Count != 0)
				{
					Class30.smethod_0(BMa[0].Controls[0]);
				}
				BMa[0].Controls.Add(value);
				method_9(string_0, 0, bool_0: true, bool_1: true);
			}
			else
			{
				int int_ = TabCount - 1;
				method_9(string_0, int_, bool_0: true, bool_1: true);
			}
		}
		else
		{
			int int_2 = TabCount - 1;
			method_9(string_0, int_2, bool_0: true, bool_1: true);
		}
		method_12(bool_0: false);
	}

	private void BMF_Click(object sender, EventArgs e)
	{
		if (!Directory.Exists(BlX))
		{
			Directory.CreateDirectory(BlX);
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = Class333.BCp();
		openFileDialog.Filter = Class333.BCQ();
		openFileDialog.InitialDirectory = BlX;
		DialogResult dialogResult = openFileDialog.ShowDialog(Form23.form23_0);
		openFileDialog.Dispose();
		if (dialogResult == DialogResult.OK)
		{
			method_58(openFileDialog.FileName);
		}
		else if (SelectedIndex == TabCount - 1)
		{
			method_4();
		}
	}

	private void BMf_Click(object sender, EventArgs e)
	{
		if (!Directory.Exists(BlX))
		{
			Directory.CreateDirectory(BlX);
		}
		int num = (int)BMb.Tag;
		string text = TabPages[num].Text;
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Title = Class333.BCq();
		saveFileDialog.Filter = Class333.BCR();
		saveFileDialog.InitialDirectory = BlX;
		saveFileDialog.FileName = text + Class333.BbG();
		if (saveFileDialog.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			File.Create(saveFileDialog.FileName).Close();
			File.SetAttributes(saveFileDialog.FileName, FileAttributes.Normal);
			method_13(saveFileDialog.FileName, num);
		}
		saveFileDialog.Dispose();
	}

	private void BMg_Click(object sender, EventArgs e)
	{
		method_60((int)BMb.Tag);
	}

	private void method_59(object sender, EventArgs e)
	{
		method_60(SelectedIndex);
	}

	private void method_60(int int_1)
	{
		if (int_1 != TabPages.Count - 1 && TabPages[int_1] is Class130 @class)
		{
			@class.method_5(!@class.method_4());
			Invalidate();
			method_12(bool_0: false);
		}
	}

	private void BMG_Click(object sender, EventArgs e)
	{
		method_65((int)BMb.Tag, bool_0: true);
	}

	private void method_61(object sender, EventArgs e)
	{
		method_65(SelectedIndex, bool_0: true);
	}

	private void BMd_Click(object sender, EventArgs e)
	{
		int index = (int)BMb.Tag;
		TabPage tabPage = TabPages[index];
		if (Form54.smethod_6(Form23.form23_0, Class333.BCr() + tabPage.Text + Class333.smethod_2378(), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return;
		}
		foreach (ToolStripItem item in BMa[index].ContextMenuStrip.Items)
		{
			item.Click -= method_61;
			item.Click -= method_59;
			item.Click -= method_40;
			item.Click -= method_42;
			item.Click -= method_44;
			item.Click -= method_45;
			item.Click -= method_46;
			item.Click -= method_47;
			item.Click -= method_48;
			item.Click -= method_49;
			item.Click -= method_51;
			item.Click -= method_50;
			item.Click -= method_52;
			item.Click -= method_53;
			item.Click -= method_54;
			item.Click -= method_55;
		}
		BMa[index].ContextMenuStrip.Opening -= method_57;
		Class30.smethod_0(tabPage);
		BMa.RemoveAt(index);
		BlZ.RemoveAt(index);
		Blz.RemoveAt(index);
		BMA.RemoveAt(index);
		method_12(bool_0: false);
	}

	private void BME_Click(object sender, EventArgs e)
	{
		int index = (int)BMb.Tag;
		TabPage tabPage = TabPages[index];
		Bly.method_1(tabPage.Text);
		if (Bly.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			tabPage.Text = Bly.method_0();
			method_12(bool_0: false);
		}
	}

	private void BMe_Click(object sender, EventArgs e)
	{
		int num = (int)BMb.Tag;
		for (int i = 0; i < TabPages.Count - 1; i++)
		{
			if (i == num)
			{
				(TabPages[i] as Class130).method_3(bool_2: true);
			}
			else
			{
				(TabPages[i] as Class130).method_3(bool_2: false);
			}
		}
		Invalidate();
		method_12(bool_0: false);
	}

	private void method_62(int int_1, int int_2)
	{
		if (int_1 == 0 || int_1 == TabPages.Count - 1 || int_2 == 0)
		{
			return;
		}
		TabPage value = TabPages[int_1];
		Panel value2 = BlZ[int_1];
		string value3 = Blz[int_1];
		int value4 = BMA[int_1];
		Class131 value5 = BMa[int_1];
		if (int_1 > int_2)
		{
			for (int num = int_1; num > int_2; num--)
			{
				TabPages[num] = TabPages[num - 1];
				BlZ[num] = BlZ[num - 1];
				Blz[num] = Blz[num - 1];
				BMA[num] = BMA[num - 1];
				BMa[num] = BMa[num - 1];
			}
			TabPages[int_2] = value;
			BlZ[int_2] = value2;
			Blz[int_2] = value3;
			BMA[int_2] = value4;
			BMa[int_2] = value5;
			SelectedIndex = int_2;
			method_12(bool_0: false);
		}
		else if (int_1 < int_2)
		{
			for (int i = int_1; i < int_2 - 1; i++)
			{
				TabPages[i] = TabPages[i + 1];
				BlZ[i] = BlZ[i + 1];
				Blz[i] = Blz[i + 1];
				BMA[i] = BMA[i + 1];
				BMa[i] = BMa[i + 1];
			}
			TabPages[int_2 - 1] = value;
			BlZ[int_2 - 1] = value2;
			Blz[int_2 - 1] = value3;
			BMA[int_2 - 1] = value4;
			BMa[int_2 - 1] = value5;
			SelectedIndex = int_2 - 1;
			method_12(bool_0: false);
		}
	}

	private ContextMenuStrip method_63()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip
		{
			BackColor = Form23.color_15,
			ForeColor = Form23.color_12
		};
		BMD.Text = Class333.BCS();
		BMD.Click += BMD_Click;
		contextMenuStrip.Items.Add(BMD);
		BMd.Text = Class333.BCs();
		BMd.Click += BMd_Click;
		contextMenuStrip.Items.Add(BMd);
		BME.Text = Class333.smethod_2319();
		BME.Click += BME_Click;
		contextMenuStrip.Items.Add(BME);
		BMe.Text = Class333.BCT();
		BMe.Click += BMe_Click;
		contextMenuStrip.Items.Add(BMe);
		BMF.Text = Class333.BCt();
		BMF.Click += BMF_Click;
		contextMenuStrip.Items.Add(BMF);
		BMf.Text = Class333.BCU();
		BMf.Click += BMf_Click;
		contextMenuStrip.Items.Add(BMf);
		BMG.Text = Class333.BCg();
		BMG.Click += BMG_Click;
		contextMenuStrip.Items.Add(BMG);
		BMg.Click += BMg_Click;
		contextMenuStrip.Items.Add(BMg);
		return contextMenuStrip;
	}

	private void Control25_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
		{
			return;
		}
		Point point = PointToClient(Control.MousePosition);
		int num = 0;
		while (true)
		{
			if (num >= TabPages.Count)
			{
				return;
			}
			if (GetTabRect(num).Contains(point))
			{
				if (e.Button == MouseButtons.Right)
				{
					Class130 @class = TabPages[num] as Class130;
					bool flag = @class.method_2();
					bool flag2 = @class.method_0() == Enum65.const_0;
					BMd.Enabled = num != 0 && num != TabPages.Count - 1 && !flag;
					BME.Enabled = num != 0 && num != TabPages.Count - 1;
					BMf.Enabled = num != TabPages.Count - 1;
					BMe.Enabled = flag2 && !flag && num != TabPages.Count - 1;
					BMG.Enabled = !@class.method_4() && num != TabPages.Count - 1;
					if (num != TabPages.Count - 1)
					{
						BMg.Enabled = true;
						if (@class.method_4())
						{
							BMg.Text = Class333.BCN();
						}
						else
						{
							BMg.Text = Class333.BCH();
						}
					}
					else
					{
						BMg.Text = Class333.BCH();
						BMg.Enabled = false;
					}
					BMb.Tag = num;
					BMb.Show(TabPages[num], point);
					return;
				}
				if (e.Button == MouseButtons.Left)
				{
					break;
				}
			}
			num++;
		}
		if (num != 0 && num != TabPages.Count - 1)
		{
			BMC = num;
			int_0 = num;
		}
	}

	private void Control25_MouseMove(object sender, MouseEventArgs e)
	{
		if (BMC == -1 || e.Button != MouseButtons.Left)
		{
			return;
		}
		Point pt = PointToClient(Control.MousePosition);
		for (int i = 1; i < TabPages.Count; i++)
		{
			if (GetTabRect(i).Contains(pt))
			{
				int_0 = i;
				break;
			}
		}
		if (int_0 != BMc)
		{
			Invalidate();
			BMc = int_0;
		}
	}

	private void Control25_MouseUp(object sender, MouseEventArgs e)
	{
		if (BMC != -1 && int_0 != -1)
		{
			if (BMC != int_0)
			{
				method_62(BMC, int_0);
			}
			Invalidate();
		}
		BMC = -1;
		int_0 = -1;
		BMc = -1;
	}

	protected override void OnResize(EventArgs eventargs)
	{
		base.OnResize(eventargs);
		method_64();
	}

	internal void method_64()
	{
		if (BMa.Count != 0 && SelectedIndex != -1)
		{
			for (int i = 0; i < TabPages.Count - 1; i++)
			{
				Class131 @class = BMa[i];
				@class.Width = SelectedTab.Width;
				@class.Height = SelectedTab.Height;
			}
		}
	}

	internal void method_65(int int_1, bool bool_0)
	{
		if (int_1 < 0 || BMa.Count <= int_1)
		{
			return;
		}
		Class131 @class = BMa[int_1];
		if (@class == null)
		{
			return;
		}
		int x = @class.AutoScrollPosition.X;
		int y = @class.AutoScrollPosition.Y;
		int num = 0;
		int num2 = 0;
		foreach (Control control3 in @class.Controls)
		{
			num = Math.Max(num, control3.Right - x);
			num2 = Math.Max(num2, control3.Bottom - y);
		}
		int num3 = @class.Width - 10;
		int num4 = @class.Height - 10;
		int num5 = 0;
		int num6 = 0;
		bool flag;
		if (BMB[int_1].Width != 0 && BMB[int_1].Height != 0 && !bool_0)
		{
			num5 = BMB[int_1].Width - 20;
			num6 = BMB[int_1].Height - 20;
			flag = true;
		}
		else
		{
			num5 = num;
			num6 = num2;
			flag = false;
		}
		int num7 = 0;
		int num8 = 0;
		if ((float)num5 / (float)num3 > (float)num6 / (float)num4)
		{
			if (num5 <= num3 && num5 >= num3 - 30)
			{
				return;
			}
			num7 = num3;
			num8 = num5 + 30;
		}
		else
		{
			if (num6 <= num4 && num6 >= num4 - 30)
			{
				return;
			}
			num7 = num4;
			num8 = num6 + 30;
		}
		if (flag && num8 > num7 && num < num3 - 10 && num2 < num4 - 10)
		{
			return;
		}
		@class.SuspendLayout();
		for (int i = 0; i < @class.Controls.Count; i++)
		{
			Control control2 = @class.Controls[i];
			control2.SuspendLayout();
			int left = control2.Left;
			int top = control2.Top;
			int right = control2.Right;
			int bottom = control2.Bottom;
			int num9 = (left - x) * num7 / num8;
			control2.Left = num9 + x;
			int num10 = (top - y) * num7 / num8;
			control2.Top = num10 + y;
			int num11 = (right - x) * num7 / num8;
			control2.Width = num11 + x - (num9 + x);
			int num12 = (bottom - y) * num7 / num8;
			control2.Height = num12 + y - (num10 + y);
			control2.ResumeLayout(performLayout: true);
			if (control2 is MovableResizablePanel)
			{
				(control2 as MovableResizablePanel).UpdateLayout(resizingOnly: true);
			}
			control2.Invalidate();
		}
		@class.ResumeLayout(performLayout: true);
	}

	protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		if (BMa.Count != 0 && SelectedIndex >= 0)
		{
			foreach (Control control in BMa[SelectedIndex].Controls)
			{
				if (control is Class104)
				{
					if (control.ContainsFocus && (control as Class104).method_92(keyEventArgs_0))
					{
						return;
					}
				}
				else if (control is Class103)
				{
					if (control.ContainsFocus && (control as Class103).method_51(keyEventArgs_0))
					{
						return;
					}
				}
				else if (control is Class102)
				{
					if (control.ContainsFocus && (control as Class102).method_46(keyEventArgs_0))
					{
						return;
					}
				}
				else if (control is Class106 && control.ContainsFocus && (control as Class106).method_22(keyEventArgs_0))
				{
					return;
				}
			}
			if (((keyEventArgs_0.KeyData & Keys.Prior) == Keys.Prior || (keyEventArgs_0.KeyData & Keys.Next) == Keys.Next) && Class30.smethod_4(Form23.form23_0, keyEventArgs_0.KeyData))
			{
				return;
			}
		}
		base.OnKeyDown(keyEventArgs_0);
	}
}
