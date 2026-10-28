using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using NSP.SettingsFramework;
using NSP.UnitConversion;
using NSP.UserInterface;
using ns0;
using ns2;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form10 : Form
{
	internal class Class188
	{
		internal Enum55 BOy;

		internal int BOZ;
	}

	internal class Class189
	{
		internal List<int> BOz;

		internal byte BoA;

		internal bool Boa;

		internal int BoB;

		internal List<DateTime> Bob;

		internal int BoC;

		internal int Boc;

		internal int BoD;

		internal int Bod;

		internal string BoE;

		public override string ToString()
		{
			if (BOz.Count > 1)
			{
				return Class333.BDA() + BOz[0] + Class333.smethod_1824() + BOz[BOz.Count - 1];
			}
			if (BOz.Count == 1)
			{
				return Class333.BDa() + BOz[0];
			}
			return base.ToString();
		}
	}

	private struct Struct21
	{
		internal int Boe;

		internal Enum52 BoF;
	}

	private enum Enum56
	{
		Bof,
		BoG,
		Bog,
		BoH,
		Boh,
		BoI
	}

	private delegate void Delegate102(object sender, EventArgs e);

	private delegate void Delegate103(Class189 class189_0, bool bool_0, ListViewItem listViewItem_0);

	internal struct Struct22
	{
		internal string Boi;

		internal string BoJ;

		internal string Boj;

		internal Class188 BoK;

		internal int Bok;
	}

	internal struct Struct23
	{
		internal string BoL;

		internal Class188 Bol;

		internal int BoM;
	}

	internal static class Class190
	{
		internal static void smethod_0()
		{
			dictionary_0.Clear();
			dictionary_1.Clear();
			dictionary_2.Clear();
			dictionary_3.Clear();
			dictionary_4.Clear();
			dictionary_5.Clear();
			dictionary_6.Clear();
			dictionary_7.Clear();
			if (Form23.framework_1 == null)
			{
				return;
			}
			string aXD = Form23.framework_1.aXD;
			if (aXD == string.Empty)
			{
				return;
			}
			string path = aXD + Class333.BDB();
			if (!File.Exists(path))
			{
				return;
			}
			try
			{
				FileStream fileStream = new FileStream(path, FileMode.Open);
				XmlReader xmlReader = XmlReader.Create(fileStream);
				xmlReader.Read();
				while (xmlReader.NodeType != XmlNodeType.Element)
				{
					xmlReader.Read();
				}
				if (!xmlReader.IsEmptyElement)
				{
					xmlReader.Read();
					while (xmlReader.IsStartElement())
					{
						bool flag = true;
						string name = xmlReader.Name;
						if (!(name == Class333.BDb()))
						{
							if (!(name == Class333.BDC()))
							{
								flag = false;
							}
							else
							{
								smethod_2(xmlReader);
							}
						}
						else
						{
							smethod_1(xmlReader, aXD);
						}
						if (!flag)
						{
							xmlReader.Skip();
						}
						else
						{
							xmlReader.Read();
						}
					}
				}
				xmlReader.Close();
				fileStream.Close();
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.BDc() + ex.Message);
			}
		}

		private static void smethod_1(XmlReader xmlReader_0, string string_0)
		{
			string[] array = xmlReader_0.GetAttribute(Class333.BDD()).Split(',');
			List<int> list = new List<int>();
			string[] array2 = array;
			foreach (string s in array2)
			{
				list.Add(int.Parse(s));
			}
			string[] array3 = xmlReader_0.GetAttribute(Class333.BDd()).Split(',');
			List<DateTime> list2 = new List<DateTime>();
			array2 = array3;
			foreach (string s2 in array2)
			{
				list2.Add(DateTime.Parse(s2));
			}
			Class189 @class = new Class189
			{
				BOz = list,
				BoA = byte.Parse(xmlReader_0.GetAttribute(Class333.BDE())),
				Boa = bool.Parse(xmlReader_0.GetAttribute(Class333.smethod_967())),
				BoB = int.Parse(xmlReader_0.GetAttribute(Class333.BDe())),
				Bob = list2,
				BoC = int.Parse(xmlReader_0.GetAttribute(Class333.BDF())),
				Boc = int.Parse(xmlReader_0.GetAttribute(Class333.BDf())),
				BoE = xmlReader_0.GetAttribute(Class333.BDG())
			};
			string attribute = xmlReader_0.GetAttribute(Class333.BDg());
			if (attribute != null)
			{
				@class.BoD = int.Parse(attribute);
			}
			string attribute2 = xmlReader_0.GetAttribute(Class333.BDH());
			if (attribute2 != null)
			{
				@class.Bod = int.Parse(attribute2);
			}
			if (@class.Boa && !string.IsNullOrEmpty(@class.BoE) && File.Exists(string_0 + Class333.smethod_975() + @class.BoE + Class333.smethod_488()))
			{
				if (@class.BOz.Count == 1)
				{
					dictionary_0[@class.BOz[0]] = @class;
					dictionary_4[@class.BOz[0]] = @class.Bob[0];
					dictionary_5[@class.BOz[0]] = @class.BoC;
					dictionary_6[@class.BOz[0]] = @class.BoD;
					dictionary_7[@class.BOz[0]] = @class.Bod;
				}
				dictionary_1[@class.BoE] = @class;
				dictionary_2[@class.BoE] = @class.BOz;
				dictionary_3[@class.BoE] = @class.BoA;
			}
		}

		private static void smethod_2(XmlReader xmlReader_0)
		{
			int key = int.Parse(xmlReader_0.GetAttribute(Class333.BDh()));
			dictionary_4[key] = DateTime.Parse(xmlReader_0.GetAttribute(Class333.BDI()));
			dictionary_5[key] = int.Parse(xmlReader_0.GetAttribute(Class333.BDF()));
			string attribute = xmlReader_0.GetAttribute(Class333.BDg());
			if (attribute != null)
			{
				dictionary_6[key] = int.Parse(attribute);
			}
			else
			{
				dictionary_6[key] = 0;
			}
			string attribute2 = xmlReader_0.GetAttribute(Class333.BDH());
			if (attribute2 != null)
			{
				dictionary_7[key] = int.Parse(attribute2);
			}
			else
			{
				dictionary_7[key] = 0;
			}
		}

		internal static void smethod_3()
		{
			try
			{
				if (Form23.framework_1 == null)
				{
					return;
				}
				string aXD = Form23.framework_1.aXD;
				if (aXD == string.Empty)
				{
					return;
				}
				string path = aXD + Class333.BDB();
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				if (dictionary_1.Count == 0 && dictionary_5.Count == 0)
				{
					return;
				}
				MemoryStream memoryStream = new MemoryStream();
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.ConformanceLevel = ConformanceLevel.Document;
				xmlWriterSettings.CloseOutput = false;
				xmlWriterSettings.Indent = true;
				xmlWriterSettings.NewLineChars = Environment.NewLine;
				XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
				xmlWriter.WriteStartElement(Class333.BDi());
				List<int> list = new List<int>();
				foreach (Class189 value2 in dictionary_1.Values)
				{
					if (value2.Boa)
					{
						smethod_4(xmlWriter, value2);
						if (value2.BOz.Count == 1)
						{
							list.Add(value2.BOz[0]);
						}
					}
				}
				foreach (int key in dictionary_5.Keys)
				{
					if (!list.Contains(key) && dictionary_4.ContainsKey(key))
					{
						DateTime dateTime_ = dictionary_4[key];
						int int_ = dictionary_5[key];
						int int_2 = dictionary_6[key];
						int int_3 = dictionary_7[key];
						smethod_5(xmlWriter, key, dateTime_, int_, int_2, int_3);
					}
				}
				xmlWriter.WriteEndElement();
				xmlWriter.Close();
				memoryStream.Flush();
				using (StreamWriter streamWriter = new StreamWriter(path))
				{
					memoryStream.Position = 0L;
					string value = new StreamReader(memoryStream).ReadToEnd();
					streamWriter.Write(value);
				}
				File.SetAttributes(path, FileAttributes.Hidden);
				memoryStream.Close();
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.BDJ() + ex.Message);
			}
		}

		private static void smethod_4(XmlWriter xmlWriter_0, Class189 class189_0)
		{
			xmlWriter_0.WriteStartElement(Class333.BDb());
			string text = string.Empty;
			foreach (int item in class189_0.BOz)
			{
				text = ((!string.IsNullOrEmpty(text)) ? (text + Class333.smethod_189() + item) : (text + item));
			}
			xmlWriter_0.WriteAttributeString(Class333.BDD(), text);
			xmlWriter_0.WriteAttributeString(Class333.BDE(), class189_0.BoA.ToString());
			xmlWriter_0.WriteAttributeString(Class333.smethod_967(), class189_0.Boa.ToString());
			xmlWriter_0.WriteAttributeString(Class333.BDe(), class189_0.BoB.ToString());
			string text2 = string.Empty;
			foreach (DateTime item2 in class189_0.Bob)
			{
				text2 = ((!string.IsNullOrEmpty(text2)) ? (text2 + Class333.smethod_189() + item2) : (text2 + item2));
			}
			xmlWriter_0.WriteAttributeString(Class333.BDd(), text2);
			xmlWriter_0.WriteAttributeString(Class333.BDF(), class189_0.BoC.ToString());
			xmlWriter_0.WriteAttributeString(Class333.BDf(), class189_0.Boc.ToString());
			if (string.IsNullOrEmpty(class189_0.BoE))
			{
				xmlWriter_0.WriteAttributeString(Class333.BDG(), string.Empty);
			}
			else
			{
				xmlWriter_0.WriteAttributeString(Class333.BDG(), class189_0.BoE);
			}
			xmlWriter_0.WriteAttributeString(Class333.BDg(), class189_0.BoD.ToString());
			xmlWriter_0.WriteAttributeString(Class333.BDH(), class189_0.Bod.ToString());
			xmlWriter_0.WriteEndElement();
		}

		private static void smethod_5(XmlWriter xmlWriter_0, int int_0, DateTime dateTime_0, int int_1, int int_2, int int_3)
		{
			xmlWriter_0.WriteStartElement(Class333.BDC());
			xmlWriter_0.WriteAttributeString(Class333.BDh(), int_0.ToString());
			xmlWriter_0.WriteAttributeString(Class333.BDI(), dateTime_0.ToString());
			xmlWriter_0.WriteAttributeString(Class333.BDF(), int_1.ToString());
			xmlWriter_0.WriteAttributeString(Class333.BDg(), int_2.ToString());
			xmlWriter_0.WriteAttributeString(Class333.BDH(), int_3.ToString());
			xmlWriter_0.WriteEndElement();
		}
	}

	[CompilerGenerated]
	private static class Class191
	{
		public static DoWorkEventHandler Bom;

		public static RunWorkerCompletedEventHandler BoN;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class192
	{
		public static readonly Class192 Bon = new Class192();

		public static Func<FileInfo, DateTime> BoO;

		public static Func<FileInfo, string> Boo;

		public static Action BoP;

		public static Action Bop;

		internal DateTime method_0(FileInfo fileInfo_0)
		{
			return fileInfo_0.LastWriteTime;
		}

		internal string method_1(FileInfo fileInfo_0)
		{
			return fileInfo_0.FullName;
		}

		internal void method_2()
		{
			foreach (ListViewItem item in class85_0.Items)
			{
				if (item.SubItems.Count > int_22)
				{
					Class189 @class = (Class189)item.Tag;
					if (@class.BoA != 0 && !@class.Boa)
					{
						item.SubItems[int_22].Text = Class333.smethod_325();
					}
				}
			}
		}

		internal void method_3()
		{
			foreach (ListViewItem item in class85_0.Items)
			{
				Class189 @class = (Class189)item.Tag;
				if (@class.BOz.Count == 1 && @class.BOz[0] == int_3)
				{
					if (item.SubItems.Count > int_22)
					{
						item.SubItems[int_22].Text = Class333.BDj();
						@class.Boa = false;
						item.Tag = @class;
					}
					break;
				}
			}
			if (class85_0 != null)
			{
				class85_0.Invalidate();
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class193
	{
		public Form10 BoQ;

		public Struct21 Boq;
	}

	[CompilerGenerated]
	private sealed class Class194
	{
		public Class189 BoR;

		public int Bor;

		public int BoS;

		public int Bos;

		public int BoT;

		public int Bot;

		public int BoU;

		public int Bou;

		public int BoV;

		public Class193 Bov;

		internal void method_0()
		{
			if (Bov.BoQ.class85_1.Items.Count == 0)
			{
				return;
			}
			foreach (ListViewItem item in Bov.BoQ.class85_1.Items)
			{
				BoR = (Class189)item.Tag;
				if (BoR.BOz.Count == 1 && BoR.BOz[0] == Bov.Boq.Boe)
				{
					BoR.BoB = int_18;
					BoR.Bob = new List<DateTime>();
					BoR.Bob.Add(new DateTime(Bor, BoS, Bos, BoT, Bot, BoU));
					BoR.BoC = Bou;
					BoR.Boc = Bou - BoV;
					BoR.BoE = string.Empty;
					Bov.BoQ.method_25(BoR, bool_5: false, item);
					backgroundWorker_1 = new BackgroundWorker();
					backgroundWorker_1.WorkerSupportsCancellation = true;
					backgroundWorker_1.DoWork += Bov.BoQ.method_23;
					backgroundWorker_1.RunWorkerAsync();
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class195
	{
		public Form10 BoW;

		public string Bow;

		internal void method_0()
		{
			BoW.Text = Class333.BDK() + Bow + Class333.smethod_1394();
		}
	}

	[CompilerGenerated]
	private sealed class Class196
	{
		public Form10 BoX;

		public string Box;

		internal void method_0()
		{
			Form54.smethod_6(BoX, Class333.BDk() + Box, Class333.BDL(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	[CompilerGenerated]
	private sealed class Class197
	{
		public Form10 BoY;

		public int Boy;

		internal void method_0()
		{
			for (int num = BoY.class85_1.Items.Count - 1; num >= 0; num--)
			{
				Class189 @class = (Class189)BoY.class85_1.Items[num].Tag;
				if (@class.BoA != 0 && @class.BOz.Count == 1)
				{
					Boy = Math.Min(Boy, @class.BOz[0]);
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class198
	{
		public Form10 BoZ;

		public Class189 Boz;

		internal void method_0()
		{
			if (BoZ.class85_1.Items.Count == 0)
			{
				return;
			}
			foreach (ListViewItem item in BoZ.class85_1.Items)
			{
				if ((Class189)item.Tag == Boz)
				{
					BoZ.method_25(Boz, bool_5: false, item);
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class199
	{
		public Form10 BPA;

		public int BPa;

		public Action BPB;

		internal void method_0()
		{
			for (int num = BPA.class85_1.Items.Count - 1; num >= 0; num--)
			{
				Class189 @class = (Class189)BPA.class85_1.Items[num].Tag;
				bool flag = @class.BoA != 0;
				if (((@class.BOz.Count == 1 && @class.BOz[0] < BPa) & flag) && !@class.Boa)
				{
					smethod_6(@class.BOz[0]);
					BPA.class85_1.Items[num].Tag = null;
					BPA.class85_1.Items.RemoveAt(num);
					if (dictionary_0.ContainsKey(@class.BOz[0]))
					{
						dictionary_0.Remove(@class.BOz[0]);
					}
					if (dictionary_4.ContainsKey(@class.BOz[0]))
					{
						dictionary_4.Remove(@class.BOz[0]);
					}
					if (dictionary_5.ContainsKey(@class.BOz[0]))
					{
						dictionary_5.Remove(@class.BOz[0]);
					}
					if (dictionary_6.ContainsKey(@class.BOz[0]))
					{
						dictionary_6.Remove(@class.BOz[0]);
					}
					if (dictionary_7.ContainsKey(@class.BOz[0]))
					{
						dictionary_7.Remove(@class.BOz[0]);
					}
				}
			}
			BPA.class85_1.method_1();
			BPA.class85_1.Invalidate();
		}
	}

	[CompilerGenerated]
	private sealed class Class200
	{
		public int BPb;

		internal void method_0()
		{
			foreach (ListViewItem item in class85_0.Items)
			{
				Class189 @class = (Class189)item.Tag;
				if (@class.BOz.Count == 1 && @class.BOz[0] == int_3)
				{
					if (item.SubItems.Count > int_22)
					{
						item.SubItems[int_22].Text = Class333.BDl() + BPb + Class333.smethod_681();
					}
					break;
				}
			}
			if (class85_0 != null)
			{
				class85_0.Invalidate();
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class201
	{
		public int BPC;

		public string BPc;

		internal void method_0()
		{
			foreach (ListViewItem item in class85_0.Items)
			{
				Class189 @class = (Class189)item.Tag;
				if (@class.BOz.Count == 1 && @class.BOz[0] == BPC)
				{
					if (item.SubItems.Count > int_22 && item.SubItems.Count > int_26)
					{
						item.SubItems[int_22].Text = Class333.BDM();
						item.SubItems[int_26].Text = BPc;
						@class.Boa = true;
						@class.BoE = BPc;
						item.Tag = @class;
					}
					dictionary_1[BPc] = @class;
					dictionary_2[BPc] = @class.BOz;
					dictionary_3[BPc] = @class.BoA;
					break;
				}
			}
			if (class85_0 != null)
			{
				class85_0.Invalidate();
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class202
	{
		public int BPD;

		public string BPd;

		public Class188 BPE;

		internal void method_0()
		{
			foreach (ListViewItem item in class85_0.Items)
			{
				Class189 @class = (Class189)item.Tag;
				if (@class.BOz.Count != 1 || @class.BOz[0] != BPD)
				{
					continue;
				}
				if (item.SubItems.Count <= int_22 || item.SubItems.Count <= int_26)
				{
					break;
				}
				item.SubItems[int_22].Text = Class333.smethod_967();
				item.SubItems[int_26].Text = BPd;
				@class.Boa = true;
				@class.BoE = BPd;
				item.Tag = @class;
				if (BPE != null && BPE.BOZ == BPD)
				{
					if (BPE.BOy == Enum55.const_1)
					{
						form10_0.method_6(@class);
					}
					else if (BPE.BOy == Enum55.const_2)
					{
						form10_0.method_7(@class.BoE);
					}
				}
				break;
			}
			if (class85_0 != null)
			{
				class85_0.Invalidate();
			}
		}
	}

	internal static readonly string string_0 = Form23.string_3 + Class333.smethod_1035();

	private static string string_1 = null;

	private static string string_2 = null;

	internal const int int_0 = 3;

	private static int int_1 = 0;

	private static int int_2;

	private static MemoryStream memoryStream_0 = null;

	private static ZipArchive zipArchive_0 = null;

	private static ZipArchiveEntry zipArchiveEntry_0 = null;

	private static Stream stream_0 = null;

	private static int int_3 = -1;

	private static int int_4 = -1;

	private static int int_5 = -1;

	private static int int_6 = -1;

	private static int int_7 = -1;

	private static int int_8 = -1;

	private static int int_9 = -1;

	private static int int_10 = 0;

	private static DateTime dateTime_0;

	private static bool bool_0 = false;

	private static int int_11 = -1;

	private static int int_12 = -1;

	private static int int_13 = -1;

	private static int int_14 = -1;

	private static int int_15 = -1;

	private static int int_16 = -1;

	private static int int_17 = -1;

	private static int int_18 = 0;

	private static bool bool_1 = false;

	private static List<Class188> list_0 = new List<Class188>();

	private static Enum6 enum6_0;

	private static Enum52 enum52_0 = Enum52.const_0;

	internal static int int_19 = 30;

	internal static bool bool_2 = true;

	private static List<string> list_1 = new List<string>();

	private static ListViewItem listViewItem_0 = null;

	private static object object_0 = new object();

	private static BackgroundWorker backgroundWorker_0;

	private static BackgroundWorker backgroundWorker_1;

	private static Dictionary<int, Class189> dictionary_0 = new Dictionary<int, Class189>();

	private static Dictionary<string, Class189> dictionary_1 = new Dictionary<string, Class189>();

	private static Dictionary<string, List<int>> dictionary_2 = new Dictionary<string, List<int>>();

	private static Dictionary<string, byte> dictionary_3 = new Dictionary<string, byte>();

	private static Dictionary<int, DateTime> dictionary_4 = new Dictionary<int, DateTime>();

	private static Dictionary<int, int> dictionary_5 = new Dictionary<int, int>();

	private static Dictionary<int, int> dictionary_6 = new Dictionary<int, int>();

	private static Dictionary<int, int> dictionary_7 = new Dictionary<int, int>();

	private static DateTime dateTime_1 = new DateTime(1980, 1, 1, 1, 1, 1);

	private static bool bool_3 = false;

	private static Class85 class85_0;

	internal static bool bool_4 = false;

	internal static Form10 form10_0;

	private ToolStripMenuItem toolStripMenuItem_0 = new ToolStripMenuItem();

	private ToolStripMenuItem toolStripMenuItem_1 = new ToolStripMenuItem();

	private ToolStripMenuItem toolStripMenuItem_2 = new ToolStripMenuItem();

	private ToolStripMenuItem toolStripMenuItem_3 = new ToolStripMenuItem();

	private ToolStripMenuItem toolStripMenuItem_4 = new ToolStripMenuItem();

	private static Point point_0 = new Point(0, 0);

	private static int int_20 = -1;

	private static int int_21 = -1;

	private static int int_22 = -1;

	private static int int_23 = -1;

	private static int int_24 = -1;

	private static int int_25 = -1;

	private static int int_26 = -1;

	private static int int_27 = 0;

	private static int int_28 = -1;

	private IContainer icontainer_0;

	private Class148 class148_0;

	private ThemedComboBox themedComboBox_0;

	private Label label_0;

	private Class85 class85_1;

	private Label label_1;

	private ThemedComboBox themedComboBox_1;

	private ThemedTextBox themedTextBox_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private ThemedButton themedButton_2;

	private ThemedButton themedButton_3;

	private Label label_2;

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(nint intptr_0);

	internal Form10(string string_3, bool bool_5)
	{
		method_27();
		_ = class85_1.Handle;
		class85_0 = class85_1;
		form10_0 = this;
		string_2 = string_3;
		bool_3 = bool_5;
		class85_1.UseCompatibleStateImageBehavior = false;
		class85_1.OwnerDraw = true;
		class85_1.DrawItem += class85_1_DrawItem;
		class85_1.DrawSubItem += class85_1_DrawSubItem;
		class85_1.DrawColumnHeader += class85_1_DrawColumnHeader;
		Form23.smethod_7(method_1);
		class85_1.ContextMenuStrip = method_0();
		class85_1.ContextMenuStrip.Opening += method_5;
		Class190.smethod_0();
	}

	private ContextMenuStrip method_0()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip
		{
			BackColor = Form23.color_15,
			ForeColor = Form23.color_12
		};
		toolStripMenuItem_0.Text = Class333.smethod_901();
		toolStripMenuItem_0.Click += toolStripMenuItem_0_Click;
		contextMenuStrip.Items.Add(toolStripMenuItem_0);
		toolStripMenuItem_1.Text = Class333.smethod_902();
		toolStripMenuItem_1.Click += toolStripMenuItem_1_Click;
		contextMenuStrip.Items.Add(toolStripMenuItem_1);
		toolStripMenuItem_2.Text = Class333.smethod_903();
		toolStripMenuItem_2.Click += toolStripMenuItem_2_Click;
		contextMenuStrip.Items.Add(toolStripMenuItem_2);
		toolStripMenuItem_3.Text = Class333.smethod_904();
		toolStripMenuItem_3.Click += toolStripMenuItem_3_Click;
		contextMenuStrip.Items.Add(toolStripMenuItem_3);
		toolStripMenuItem_4.Text = Class333.smethod_905();
		toolStripMenuItem_4.Click += toolStripMenuItem_4_Click;
		contextMenuStrip.Items.Add(toolStripMenuItem_4);
		return contextMenuStrip;
	}

	internal static void smethod_0()
	{
		if (File.Exists(string_0))
		{
			using (StreamReader streamReader = File.OpenText(string_0))
			{
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					if (text.StartsWith(Class333.smethod_906()))
					{
						bool_1 = bool.Parse(text.Substring(Class333.smethod_906().Length));
					}
					else if (text.StartsWith(Class333.smethod_907()))
					{
						Class1.enum6_0 = (Enum6)int.Parse(text.Substring(Class333.smethod_907().Length));
						enum6_0 = Class1.enum6_0;
					}
					else if (text.StartsWith(Class333.smethod_908()))
					{
						bool_2 = bool.Parse(text.Substring(Class333.smethod_908().Length));
					}
					else if (text.StartsWith(Class333.smethod_909()))
					{
						int_19 = int.Parse(text.Substring(Class333.smethod_909().Length));
					}
					else if (text.StartsWith(Class333.smethod_910()))
					{
						enum52_0 = (Enum52)int.Parse(text.Substring(Class333.smethod_910().Length));
					}
				}
				return;
			}
		}
		bool_1 = false;
		bool_2 = true;
		int_19 = 30;
		enum52_0 = Enum52.const_0;
	}

	internal static void smethod_1()
	{
		try
		{
			if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
			{
				Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
			}
			File.Create(string_0).Close();
			List<string> list = new List<string>();
			list.Add(Class333.smethod_906() + bool_1);
			string text = Class333.smethod_907();
			int num = (int)enum6_0;
			list.Add(text + num);
			list.Add(Class333.smethod_908() + bool_2);
			list.Add(Class333.smethod_909() + int_19);
			string text2 = Class333.smethod_910();
			num = (int)enum52_0;
			list.Add(text2 + num);
			File.AppendAllLines(string_0, list);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_911() + ex.Message);
		}
	}

	[SpecialName]
	internal static string smethod_2()
	{
		string result = null;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class333.smethod_912(), writable: true);
		if (registryKey != null)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey(Application.CompanyName, writable: true);
			if (registryKey2 != null)
			{
				RegistryKey registryKey3 = registryKey2.OpenSubKey(Class333.smethod_913(), writable: true);
				if (registryKey3 != null)
				{
					result = registryKey3.GetValue(Class333.smethod_914()) as string;
				}
			}
		}
		return result;
	}

	[SpecialName]
	internal static string smethod_3()
	{
		string result = null;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class333.smethod_912(), writable: false);
		if (registryKey != null)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey(Application.CompanyName, writable: false);
			if (registryKey2 != null)
			{
				RegistryKey registryKey3 = registryKey2.OpenSubKey(Class333.smethod_915(), writable: false);
				if (registryKey3 != null)
				{
					result = registryKey3.GetValue(Class333.smethod_914()) as string;
				}
			}
		}
		return result;
	}

	private void Form10_Shown(object sender, EventArgs e)
	{
		Text = Class333.smethod_916();
		BackColor = Form23.color_10;
		class148_0.ForeColor = Form23.color_12;
		class85_1.BackColor = Form23.color_17;
		class85_1.ForeColor = Form23.color_12;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		smethod_0();
		class148_0.Checked = bool_1;
		themedComboBox_0.SelectedIndex = (int)enum6_0;
		themedComboBox_1.SelectedIndex = (int)enum52_0;
		method_2();
		bool_4 = true;
	}

	private void method_1(object sender, EventArgs e)
	{
		Close();
	}

	private void Form10_FormClosing(object sender, FormClosingEventArgs e)
	{
		class85_1.DrawItem -= class85_1_DrawItem;
		class85_1.DrawSubItem -= class85_1_DrawSubItem;
		class85_1.DrawColumnHeader -= class85_1_DrawColumnHeader;
		Form23.smethod_8(method_1);
		smethod_1();
		Setting setting = null;
		if (Form23.framework_1 != null)
		{
			setting = Form23.framework_1.method_31(9500);
		}
		setting?.method_265(method_24);
		Class190.smethod_3();
		class85_1.Items.Clear();
		class85_0 = null;
		if (backgroundWorker_0 != null)
		{
			backgroundWorker_0.CancelAsync();
		}
		if (backgroundWorker_1 != null)
		{
			backgroundWorker_1.CancelAsync();
		}
		bool_4 = false;
	}

	private void method_2()
	{
		class148_0.Enabled = !bool_3;
		themedComboBox_0.Enabled = !bool_3 && class148_0.Checked;
		themedComboBox_0.Invalidate();
		themedComboBox_0.Visible = themedComboBox_0.Enabled;
		label_0.Visible = themedComboBox_0.Visible;
		label_2.Visible = themedComboBox_0.Visible;
		bool flag = method_3();
		themedButton_0.Enabled = !bool_3 & flag;
		themedButton_1.Enabled = !bool_3 & flag;
		themedButton_2.Enabled = !bool_3 & flag;
		themedButton_3.Enabled = !bool_3 & flag;
		themedTextBox_0.Enabled = !bool_3;
	}

	private bool method_3()
	{
		int num = class85_1.Items.Count - 1;
		while (true)
		{
			if (num >= 0)
			{
				Class189 @class = (Class189)class85_1.Items[num].Tag;
				bool flag = @class.BoA != 0;
				if (((@class.BOz.Count == 1) & flag) && !@class.Boa)
				{
					break;
				}
				num--;
				continue;
			}
			return false;
		}
		return true;
	}

	private void class148_0_CheckedChanged(object sender, EventArgs e)
	{
		themedComboBox_0.Enabled = !bool_3 && class148_0.Checked;
		themedComboBox_0.Visible = themedComboBox_0.Enabled;
		label_0.Visible = themedComboBox_0.Visible;
		label_2.Visible = themedComboBox_0.Visible;
		list_0.Clear();
		bool_1 = class148_0.Checked;
		smethod_1();
		if (bool_1)
		{
			foreach (ListViewItem item in class85_1.Items)
			{
				if (item.SubItems.Count > int_22 && ((Class189)item.Tag).BoA != 0 && item.SubItems[int_22].Text == Class333.smethod_325())
				{
					item.SubItems[int_22].Text = Class333.smethod_917();
				}
			}
		}
		class85_1.Invalidate();
	}

	private void themedComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (themedComboBox_0.SelectedIndex != -1)
		{
			enum6_0 = (Enum6)themedComboBox_0.SelectedIndex;
			smethod_1();
		}
	}

	private void themedComboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (themedComboBox_1.SelectedIndex != -1)
		{
			enum52_0 = (Enum52)themedComboBox_1.SelectedIndex;
			Struct21 struct21_ = new Struct21
			{
				Boe = -1,
				BoF = enum52_0
			};
			method_10(struct21_);
		}
	}

	private static bool smethod_4(int int_29)
	{
		foreach (Class188 item in list_0)
		{
			if (item.BOZ == int_29)
			{
				return true;
			}
		}
		return false;
	}

	private static void smethod_5(int int_29, Enum55 enum55_0)
	{
		foreach (Class188 item in list_0)
		{
			if (item.BOZ == int_29)
			{
				return;
			}
		}
		Class188 @class = new Class188();
		@class.BOZ = int_29;
		@class.BOy = enum55_0;
		list_0.Add(@class);
	}

	private static Class188 smethod_6(int int_29)
	{
		Class188 result = null;
		int num = list_0.Count - 1;
		while (num >= 0)
		{
			if (list_0[num].BOZ != int_29)
			{
				num--;
				continue;
			}
			result = list_0[num];
			list_0.RemoveAt(num);
			break;
		}
		if (list_0.Count == 0)
		{
			Class1.enum6_0 = enum6_0;
		}
		return result;
	}

	private void class85_1_MouseMove(object sender, MouseEventArgs e)
	{
		if (class85_1.Items.Count != 0)
		{
			ListViewItem listViewItem = class85_1.Items[class85_1.Items.Count - 1];
			if (listViewItem.SubItems.Count > int_24)
			{
				if (e.Y >= 20 && e.Y <= listViewItem.SubItems[0].Bounds.Bottom && e.X >= listViewItem.SubItems[int_22].Bounds.Right)
				{
					class85_1.Cursor = Cursors.Hand;
				}
				else
				{
					class85_1.Cursor = Cursors.Default;
				}
			}
			else
			{
				class85_1.Cursor = Cursors.Default;
			}
		}
		else
		{
			class85_1.Cursor = Cursors.Default;
		}
		point_0.X = e.X;
		point_0.Y = e.Y;
		class85_1.Invalidate();
	}

	private void method_4()
	{
		if (string_1 != null && Directory.Exists(string_1))
		{
			if (themedTextBox_0.Text.EndsWith(Class333.smethod_488()))
			{
				themedTextBox_0.Text = themedTextBox_0.Text.Substring(0, themedTextBox_0.Text.Length - Class333.smethod_488().Length);
			}
			else if (themedTextBox_0.Text.EndsWith(Class333.smethod_489()))
			{
				themedTextBox_0.Text = themedTextBox_0.Text.Substring(0, themedTextBox_0.Text.Length - Class333.smethod_489().Length);
			}
			bool flag = false;
			string[] files = Directory.GetFiles(string_1);
			foreach (string text in files)
			{
				if (text.EndsWith(Class333.smethod_177() + themedTextBox_0.Text + Class333.smethod_489()) || text.EndsWith(Class333.smethod_176() + themedTextBox_0.Text + Class333.smethod_489()) || text.EndsWith(Class333.smethod_177() + themedTextBox_0.Text + Class333.smethod_488()) || text.EndsWith(Class333.smethod_176() + themedTextBox_0.Text + Class333.smethod_488()))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				Form54.smethod_6(this, Class333.smethod_918(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				try
				{
					foreach (string item in list_1)
					{
						int length = 0;
						int num = item.Length - 2;
						while (num >= 0)
						{
							if (item[num] != '/' && item[num] != '\\')
							{
								num--;
								continue;
							}
							length = num + 1;
							break;
						}
						string text2 = string.Empty;
						if (item.EndsWith(Class333.smethod_488()))
						{
							text2 = Class333.smethod_488();
						}
						else if (item.EndsWith(Class333.smethod_489()))
						{
							text2 = Class333.smethod_489();
						}
						else if (item.EndsWith(Class333.smethod_919()))
						{
							text2 = Class333.smethod_919();
						}
						string destFileName = item.Substring(0, length) + themedTextBox_0.Text + text2;
						File.Move(item, destFileName);
					}
					if (class85_1 != null && class85_1.IsHandleCreated && listViewItem_0 != null && listViewItem_0.SubItems.Count > int_26)
					{
						listViewItem_0.SubItems[int_26].Text = themedTextBox_0.Text;
						Class189 @class = (Class189)listViewItem_0.Tag;
						if (dictionary_1.ContainsKey(@class.BoE))
						{
							dictionary_1.Remove(@class.BoE);
						}
						if (dictionary_2.ContainsKey(@class.BoE))
						{
							dictionary_2.Remove(@class.BoE);
						}
						if (dictionary_3.ContainsKey(@class.BoE))
						{
							dictionary_3.Remove(@class.BoE);
						}
						@class.BoE = themedTextBox_0.Text;
						dictionary_1[themedTextBox_0.Text] = @class;
						dictionary_2[themedTextBox_0.Text] = @class.BOz;
						dictionary_3[themedTextBox_0.Text] = @class.BoA;
						Class190.smethod_3();
					}
				}
				catch
				{
					Form54.smethod_6(this, Class333.smethod_920(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		themedTextBox_0.Visible = false;
		themedTextBox_0.Text = string.Empty;
		listViewItem_0 = null;
		list_1.Clear();
		class85_1.Invalidate();
	}

	private void class85_1_MouseClick(object sender, MouseEventArgs e)
	{
		if (themedTextBox_0.Visible && listViewItem_0 != null)
		{
			if (themedTextBox_0.Text != string.Empty)
			{
				method_4();
				return;
			}
			themedTextBox_0.Visible = false;
			listViewItem_0 = null;
			list_1.Clear();
			class85_1.Invalidate();
		}
		else
		{
			if (e.Button != MouseButtons.Left || point_0.X == 0 || point_0.Y == 0)
			{
				return;
			}
			foreach (ListViewItem item in class85_1.Items)
			{
				if (point_0.Y > item.Bounds.Top && point_0.Y < item.Bounds.Bottom)
				{
					if (item.SubItems.Count > int_23 && point_0.X > item.SubItems[int_23].Bounds.Left && point_0.X < item.SubItems[int_23].Bounds.Right)
					{
						toolStripMenuItem_0_Click(item, null);
					}
					else if (item.SubItems.Count > int_24 && point_0.X > item.SubItems[int_24].Bounds.Left && point_0.X < item.SubItems[int_24].Bounds.Right)
					{
						toolStripMenuItem_2_Click(item, null);
					}
					else if (item.SubItems.Count > int_25 && point_0.X > item.SubItems[int_25].Bounds.Left && point_0.X < item.SubItems[int_25].Bounds.Right)
					{
						toolStripMenuItem_3_Click(item, null);
					}
					break;
				}
			}
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		ListViewItem listViewItem = ((!(sender is ListViewItem)) ? (toolStripMenuItem_0.Tag as ListViewItem) : (sender as ListViewItem));
		Class189 @class = (Class189)listViewItem.Tag;
		bool flag = @class.BoA == 0;
		bool flag2 = @class.Boa | flag;
		if (!bool_1 && !flag2 && @class.BOz.Count == 1)
		{
			smethod_5(@class.BOz[0], Enum55.const_0);
			listViewItem.SubItems[int_22].Text = Class333.smethod_917();
		}
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		ListViewItem listViewItem = ((!(sender is ListViewItem)) ? (toolStripMenuItem_1.Tag as ListViewItem) : (sender as ListViewItem));
		Class189 @class = (Class189)listViewItem.Tag;
		bool flag = @class.BoA == 0;
		if (@class.Boa | flag)
		{
			string text;
			string text2;
			string text3;
			if (flag)
			{
				string boE = @class.BoE;
				text = smethod_10(boE);
				text2 = smethod_8(boE);
				text3 = smethod_12(boE);
			}
			else
			{
				text = smethod_11(@class.BOz);
				text2 = smethod_9(@class.BOz);
				text3 = smethod_13(@class.BOz);
			}
			listViewItem_0 = listViewItem;
			list_1.Clear();
			if (text != null)
			{
				list_1.Add(text);
			}
			if (text2 != null)
			{
				list_1.Add(text2);
			}
			if (text3 != null)
			{
				list_1.Add(text3);
			}
			if (text2 == null && text == null)
			{
				Form54.smethod_6(this, Class333.smethod_921(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string path = ((text2 == null) ? text : text2);
			themedTextBox_0.Text = Path.GetFileNameWithoutExtension(path);
			themedTextBox_0.Left = class85_1.Left + listViewItem.SubItems[int_26].Bounds.Left;
			themedTextBox_0.Top = class85_1.Top + listViewItem.SubItems[int_26].Bounds.Top;
			themedTextBox_0.Visible = true;
			themedTextBox_0.BringToFront();
			themedTextBox_0.Focus();
			themedTextBox_0.SelectAll();
		}
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		ListViewItem listViewItem = ((!(sender is ListViewItem)) ? (toolStripMenuItem_2.Tag as ListViewItem) : (sender as ListViewItem));
		Class189 @class = (Class189)listViewItem.Tag;
		bool flag = @class.BoA == 0;
		if (@class.Boa | flag)
		{
			method_6(@class);
			return;
		}
		if (!flag && @class.BOz.Count == 1)
		{
			if (listViewItem.SubItems[int_22].Text == Class333.smethod_325())
			{
				listViewItem.SubItems[int_22].Text = Class333.smethod_917();
			}
			smethod_5(@class.BOz[0], Enum55.const_1);
			class85_1.Invalidate();
		}
		UseWaitCursor = true;
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		ListViewItem listViewItem = ((!(sender is ListViewItem)) ? (toolStripMenuItem_3.Tag as ListViewItem) : (sender as ListViewItem));
		Class189 @class = (Class189)listViewItem.Tag;
		bool flag = @class.BoA == 0;
		if (@class.Boa | flag)
		{
			method_7(@class.BoE);
			return;
		}
		if (!flag && @class.BOz.Count == 1)
		{
			if (listViewItem.SubItems[int_22].Text == Class333.smethod_325())
			{
				listViewItem.SubItems[int_22].Text = Class333.smethod_917();
			}
			smethod_5(@class.BOz[0], Enum55.const_2);
			class85_1.Invalidate();
		}
		UseWaitCursor = true;
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		ListViewItem listViewItem = ((!(sender is ListViewItem)) ? (toolStripMenuItem_4.Tag as ListViewItem) : (sender as ListViewItem));
		Class189 @class = (Class189)listViewItem.Tag;
		bool flag = @class.BoA == 0;
		if (!(@class.Boa | flag))
		{
			return;
		}
		string text = null;
		if (flag)
		{
			string boE = @class.BoE;
			text = smethod_10(boE);
			if (string.IsNullOrEmpty(text))
			{
				text = smethod_8(boE);
			}
			if (string.IsNullOrEmpty(text))
			{
				text = smethod_12(boE);
			}
		}
		else
		{
			text = smethod_11(@class.BOz);
			if (string.IsNullOrEmpty(text))
			{
				text = smethod_9(@class.BOz);
			}
			if (string.IsNullOrEmpty(text))
			{
				text = smethod_13(@class.BOz);
			}
		}
		if (string_1 != null && Directory.Exists(string_1))
		{
			if (!string.IsNullOrEmpty(text) && File.Exists(text))
			{
				try
				{
					Process.Start(new ProcessStartInfo(Class333.smethod_922(), string_1));
					return;
				}
				catch (Exception ex)
				{
					Form54.smethod_6(this, Class333.smethod_923() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			Form54.smethod_6(this, Class333.smethod_921(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_924(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_5(object sender, CancelEventArgs e)
	{
		Point point = class85_1.PointToClient(Control.MousePosition);
		foreach (ListViewItem item in class85_1.Items)
		{
			if (point.Y >= item.Bounds.Top && point.Y < item.Bounds.Bottom)
			{
				toolStripMenuItem_0.Tag = item;
				toolStripMenuItem_1.Tag = item;
				toolStripMenuItem_2.Tag = item;
				toolStripMenuItem_3.Tag = item;
				toolStripMenuItem_4.Tag = item;
				Class189 @class = (Class189)item.Tag;
				bool flag = @class.BoA == 0;
				bool flag2 = @class.Boa | flag;
				toolStripMenuItem_0.Enabled = !bool_1 && !flag2 && @class.BOz.Count == 1;
				toolStripMenuItem_1.Enabled = flag2;
				toolStripMenuItem_2.Enabled = flag2 || (!flag && @class.BOz.Count == 1);
				toolStripMenuItem_3.Enabled = flag2 || (!flag && @class.BOz.Count == 1);
				toolStripMenuItem_4.Enabled = flag2;
				return;
			}
		}
		e.Cancel = true;
	}

	private void method_6(Class189 class189_0)
	{
		string text = method_8(class189_0);
		if (text != null)
		{
			Close();
			Form23.form23_0.method_160(text, bool_53: false);
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_921(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		UseWaitCursor = false;
	}

	private void method_7(string string_3)
	{
		bool flag = false;
		bool flag2 = false;
		if (File.Exists(smethod_3()))
		{
			flag = true;
			flag2 = true;
		}
		else if (File.Exists(smethod_2()))
		{
			flag = false;
			flag2 = true;
		}
		if (!flag2)
		{
			Form54.smethod_6(this, Class333.smethod_925(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			UseWaitCursor = false;
			return;
		}
		if (flag)
		{
			string text = smethod_8(string_3);
			if (File.Exists(text))
			{
				if (!Class35.smethod_2(text))
				{
					Class35.smethod_1(text, Class19.smethod_3());
				}
				smethod_7(smethod_3(), text);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_926(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			string text2 = smethod_12(string_3);
			if (text2 != null && File.Exists(text2))
			{
				smethod_7(smethod_2(), text2);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_927(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		UseWaitCursor = false;
	}

	internal static void smethod_7(string string_3, string string_4)
	{
		Process process = new Process();
		process.StartInfo.FileName = string_3;
		process.StartInfo.Arguments = Class333.smethod_928() + string_4 + Class333.smethod_180();
		process.Start();
		nint num = IntPtr.Zero;
		DateTime dateTime = DateTime.Now.AddSeconds(30.0);
		while (!process.HasExited && num == IntPtr.Zero && DateTime.Now < dateTime)
		{
			num = process.MainWindowHandle;
			if (num == IntPtr.Zero)
			{
				Thread.Sleep(1000);
			}
		}
		if (num != IntPtr.Zero)
		{
			SetForegroundWindow(num);
		}
	}

	private string method_8(Class189 class189_0)
	{
		string text;
		if (class189_0.BoA == 0)
		{
			text = smethod_10(class189_0.BoE);
			if (text == null)
			{
				text = smethod_8(class189_0.BoE);
			}
		}
		else
		{
			text = smethod_11(class189_0.BOz);
			if (text == null)
			{
				text = smethod_9(class189_0.BOz);
			}
		}
		return text;
	}

	private void class85_1_DoubleClick(object sender, EventArgs e)
	{
		if (point_0.X == 0 || point_0.Y == 0)
		{
			return;
		}
		foreach (ListViewItem item in class85_1.Items)
		{
			if (point_0.Y > item.Bounds.Top && point_0.Y < item.Bounds.Bottom)
			{
				if (item.SubItems.Count > int_26 && point_0.X > item.SubItems[int_26].Bounds.Left && point_0.X < item.SubItems[int_26].Bounds.Right)
				{
					toolStripMenuItem_1_Click(item, null);
				}
				break;
			}
		}
	}

	private void themedTextBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			themedTextBox_0.Visible = false;
			themedTextBox_0.Text = string.Empty;
			listViewItem_0 = null;
			list_1.Clear();
			class85_1.Invalidate();
		}
		else if ((e.KeyCode == Keys.Return || e.KeyCode == Keys.Return) && themedTextBox_0.Visible && themedTextBox_0.Text != string.Empty && listViewItem_0 != null)
		{
			method_4();
			class85_1.Invalidate();
		}
	}

	private static string smethod_8(string string_3)
	{
		string text = string_1 + Class333.smethod_176() + string_3 + Class333.smethod_488();
		if (File.Exists(text))
		{
			return text;
		}
		return null;
	}

	private static string smethod_9(List<int> list_2)
	{
		if (string_1 != null && Directory.Exists(string_1))
		{
			if (list_2.Count == 1 && dictionary_0.ContainsKey(list_2[0]))
			{
				Class189 @class = dictionary_0[list_2[0]];
				if (!string.IsNullOrEmpty(@class.BoE))
				{
					string text = string_1 + Class333.smethod_176() + @class.BoE + Class333.smethod_488();
					if (File.Exists(text))
					{
						return text;
					}
				}
			}
			string[] files = Directory.GetFiles(string_1, Class333.smethod_929());
			string[] array;
			if (list_2.Count == 1)
			{
				array = files;
				foreach (string text2 in array)
				{
					if (text2.EndsWith(Class333.smethod_930() + list_2[0] + Class333.smethod_488()) || text2.EndsWith(Class333.smethod_931() + list_2[0] + Class333.smethod_488()))
					{
						return text2;
					}
				}
			}
			array = files;
			foreach (string text3 in array)
			{
				if (!text3.EndsWith(Class333.smethod_488()))
				{
					continue;
				}
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text3);
				List<int> list;
				byte byte_;
				if (dictionary_1.ContainsKey(fileNameWithoutExtension))
				{
					Class189 class2 = dictionary_1[fileNameWithoutExtension];
					list = class2.BOz;
					byte_ = class2.BoA;
				}
				else if (dictionary_2.ContainsKey(fileNameWithoutExtension) && dictionary_3.ContainsKey(fileNameWithoutExtension))
				{
					list = dictionary_2[fileNameWithoutExtension];
					byte_ = dictionary_3[fileNameWithoutExtension];
				}
				else
				{
					list = smethod_14(text3, out var _, out byte_);
					dictionary_2[fileNameWithoutExtension] = list;
					dictionary_3[fileNameWithoutExtension] = byte_;
				}
				bool flag = true;
				foreach (int item in list_2)
				{
					if (!list.Contains(item))
					{
						flag = false;
						break;
					}
				}
				if (flag && list_2.Count == list.Count && byte_ != 0)
				{
					return text3;
				}
			}
		}
		return null;
	}

	private static string smethod_10(string string_3)
	{
		string text = string_1 + Class333.smethod_176() + string_3 + Class333.smethod_489();
		if (File.Exists(text))
		{
			return text;
		}
		return null;
	}

	private static string smethod_11(List<int> list_2)
	{
		if (string_1 != null && Directory.Exists(string_1))
		{
			if (list_2.Count == 1 && dictionary_0.ContainsKey(list_2[0]))
			{
				Class189 @class = dictionary_0[list_2[0]];
				if (!string.IsNullOrEmpty(@class.BoE))
				{
					string text = string_1 + Class333.smethod_176() + @class.BoE + Class333.smethod_489();
					if (File.Exists(text))
					{
						return text;
					}
				}
			}
			string[] files = Directory.GetFiles(string_1, Class333.smethod_932());
			string[] array;
			if (list_2.Count == 1)
			{
				array = files;
				foreach (string text2 in array)
				{
					if (text2.EndsWith(Class333.smethod_930() + list_2[0] + Class333.smethod_489()) || text2.EndsWith(Class333.smethod_931() + list_2[0] + Class333.smethod_489()))
					{
						return text2;
					}
				}
			}
			array = files;
			foreach (string text3 in array)
			{
				if (!text3.EndsWith(Class333.smethod_489()))
				{
					continue;
				}
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text3);
				List<int> list;
				byte byte_;
				if (dictionary_1.ContainsKey(fileNameWithoutExtension))
				{
					Class189 class2 = dictionary_1[fileNameWithoutExtension];
					list = class2.BOz;
					byte_ = class2.BoA;
				}
				else if (dictionary_2.ContainsKey(fileNameWithoutExtension) && dictionary_3.ContainsKey(fileNameWithoutExtension))
				{
					list = dictionary_2[fileNameWithoutExtension];
					byte_ = dictionary_3[fileNameWithoutExtension];
				}
				else
				{
					list = smethod_14(text3, out var _, out byte_);
					dictionary_2[fileNameWithoutExtension] = list;
					dictionary_3[fileNameWithoutExtension] = byte_;
				}
				bool flag = true;
				foreach (int item in list_2)
				{
					if (!list.Contains(item))
					{
						flag = false;
						break;
					}
				}
				if (flag && list_2.Count == list.Count && byte_ != 0)
				{
					return text3;
				}
			}
		}
		return null;
	}

	private static string smethod_12(string string_3)
	{
		string text = string_1 + Class333.smethod_176() + string_3 + Class333.smethod_919();
		if (File.Exists(text))
		{
			return text;
		}
		return null;
	}

	private static string smethod_13(List<int> list_2)
	{
		if (string_1 != null && Directory.Exists(string_1))
		{
			string[] files = Directory.GetFiles(string_1, Class333.smethod_933());
			string[] array;
			if (list_2.Count == 1)
			{
				array = files;
				foreach (string text in array)
				{
					if (text.EndsWith(Class333.smethod_930() + list_2[0] + Class333.smethod_919()) || text.EndsWith(Class333.smethod_931() + list_2[0] + Class333.smethod_919()))
					{
						return text;
					}
				}
			}
			array = files;
			foreach (string text2 in array)
			{
				if (!text2.EndsWith(Class333.smethod_919()))
				{
					continue;
				}
				List<int> list = smethod_14(text2, out var _, out var byte_);
				bool flag = true;
				foreach (int item in list_2)
				{
					if (!list.Contains(item))
					{
						flag = false;
						break;
					}
				}
				if (flag && list_2.Count == list.Count && byte_ != 0)
				{
					return text2;
				}
			}
		}
		return null;
	}

	internal static List<int> smethod_14(string string_3, out DateTime dateTime_2, out byte byte_0)
	{
		List<int> list = new List<int>();
		dateTime_2 = dateTime_1;
		byte_0 = 0;
		MemoryStream memoryStream = null;
		ZipArchive zipArchive = null;
		ZipArchiveEntry zipArchiveEntry = null;
		Stream stream = null;
		try
		{
			if (string_3.EndsWith(Class333.smethod_919()))
			{
				using (StreamReader streamReader = File.OpenText(string_3))
				{
					bool flag = false;
					bool flag2 = false;
					string text;
					while ((text = streamReader.ReadLine()) != null)
					{
						if (text.StartsWith(Class333.smethod_934()))
						{
							flag2 = true;
							list.Add(int.Parse(text.Substring(Class333.smethod_934().Length)));
						}
						else if (text.StartsWith(Class333.smethod_935()))
						{
							flag = true;
							byte_0 = byte.Parse(text.Substring(Class333.smethod_935().Length));
							if (flag2)
							{
								break;
							}
						}
						else if (flag & flag2)
						{
							break;
						}
					}
				}
				return list;
			}
			memoryStream = Class35.smethod_7(string_3, Class19.smethod_3());
			if (memoryStream.CanRead)
			{
				if (string_3.EndsWith(Class333.smethod_488()))
				{
					zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Read);
					foreach (ZipArchiveEntry entry in zipArchive.Entries)
					{
						if (entry.Name.EndsWith(Class333.smethod_489()))
						{
							zipArchiveEntry = entry;
							break;
						}
					}
					if (zipArchiveEntry != null)
					{
						stream = zipArchiveEntry.Open();
					}
				}
				else
				{
					stream = new FileStream(string_3, FileMode.Open);
				}
				while (true)
				{
					int num = stream.ReadByte();
					switch (num)
					{
					case 255:
						continue;
					case -1:
						goto end_IL_0474;
					}
					byte[] array = new byte[4];
					if (!Class23.smethod_14(stream, array, 0, 4))
					{
						break;
					}
					uint num2 = (uint)((array[0] << 24) | ((array[1] << 16) & 0xFF0000) | ((array[2] << 8) & 0xFF00) | (array[3] & 0xFF));
					if (num2 == uint.MaxValue || num2 == 0 || (num2 > 131072 && num != 2 && (num & 0xF) != 9 && num != 13))
					{
						break;
					}
					uint num3 = 0u;
					uint num4 = 0u;
					int num5 = 0;
					int num6 = 1;
					int num7 = 1;
					int num8 = 1;
					int num9 = 1;
					int num10 = 1;
					byte[] array2 = new byte[num2 - 5];
					if (Class23.smethod_14(stream, array2, 0, (int)(num2 - 5)))
					{
						for (int i = 5; i < num2; i++)
						{
							byte b = array2[i - 5];
							switch (num)
							{
							case 14:
								switch ((i - 5) % 4)
								{
								case 0:
									num3 = (uint)((b << 24) & -16777216);
									break;
								case 1:
									num3 |= (uint)((b << 16) & 0xFF0000);
									break;
								case 2:
									num3 |= (uint)((b << 8) & 0xFF00);
									break;
								case 3:
									num3 |= (uint)(b & 0xFF);
									list.Add((int)num3);
									break;
								}
								break;
							case 1:
								if ((i != 5 || b == 72) && (i != 6 || b == 65) && (i != 7 || b == 76) && (i != 8 || b == 84) && (i != 9 || b == 69) && (i != 10 || b == 67) && (i != 11 || b == 72) && (i != 12 || b == 48 || b == 49))
								{
									switch (i)
									{
									case 53:
										num5 = (b << 8) & 0xFF00;
										break;
									case 54:
										num5 |= b & 0xFF;
										break;
									case 55:
										num6 = b;
										break;
									case 56:
										num7 = b;
										break;
									case 49:
										num8 = b;
										break;
									case 50:
										num9 = b;
										break;
									case 51:
										num10 = b;
										break;
									}
									if (i == 56)
									{
										if (num5 >= 1 && num5 <= 9999 && num6 >= 1 && num6 <= 12 && num7 >= 1 && num7 <= 31 && num8 >= 0 && num8 <= 23 && num9 >= 0 && num9 <= 59 && num10 >= 0 && num10 <= 59)
										{
											dateTime_2 = new DateTime(num5, num6, num7, num8, num9, num10);
										}
										else
										{
											dateTime_2 = dateTime_1;
										}
									}
									if (list.Count == 0)
									{
										switch (i)
										{
										case 57:
											num4 |= (uint)(b << 24);
											break;
										case 58:
											num4 |= (uint)((b << 16) & 0xFF0000);
											break;
										case 59:
											num4 |= (uint)((b << 8) & 0xFF00);
											break;
										case 60:
											num4 |= (uint)(b & 0xFF);
											list.Add((int)num4);
											break;
										}
									}
									if (i == 65)
									{
										byte_0 = b;
										return list;
									}
									break;
								}
								return list;
							}
						}
						continue;
					}
					return list;
					continue;
					end_IL_0474:
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_936() + ex.Message);
		}
		finally
		{
			stream?.Close();
			zipArchive?.Dispose();
			memoryStream?.Close();
		}
		return list;
	}

	private bool method_9(int int_29)
	{
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(object_0, int_29, ref lockTaken);
			return lockTaken;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(object_0);
			}
		}
	}

	private static bool smethod_15()
	{
		if (Form23.framework_1 != null)
		{
			if (!Class242.smethod_12(Form23.framework_1.awZ))
			{
				return Form23.framework_1.awZ == 21;
			}
			return true;
		}
		return false;
	}

	private void method_10(Struct21 struct21_0)
	{
		if (backgroundWorker_0 != null)
		{
			backgroundWorker_0.CancelAsync();
		}
		if (backgroundWorker_1 != null)
		{
			backgroundWorker_1.CancelAsync();
		}
		bool flag = method_9(500);
		if (struct21_0.Boe == -1)
		{
			class85_1.Items.Clear();
			class85_1.method_1();
			if (class85_1.Columns.Count == 0)
			{
				bool flag2 = smethod_15();
				int num = 0;
				int num2 = 0;
				ColumnHeader columnHeader = new ColumnHeader
				{
					TextAlign = HorizontalAlignment.Right,
					Text = Class333.smethod_937(),
					Width = 50
				};
				class85_1.Columns.Add(columnHeader);
				num = 1;
				num2 = 0 + columnHeader.Width;
				if (!flag2)
				{
					ColumnHeader columnHeader2 = new ColumnHeader
					{
						TextAlign = HorizontalAlignment.Right,
						Text = Class333.smethod_938(),
						Width = 80
					};
					class85_1.Columns.Add(columnHeader2);
					num++;
					num2 += columnHeader2.Width;
					ColumnHeader columnHeader3 = new ColumnHeader
					{
						TextAlign = HorizontalAlignment.Right,
						Text = Class333.smethod_939(),
						Width = 70
					};
					class85_1.Columns.Add(columnHeader3);
					num++;
					num2 += columnHeader3.Width;
				}
				ColumnHeader columnHeader4 = new ColumnHeader
				{
					TextAlign = HorizontalAlignment.Right,
					Text = Class333.smethod_940(),
					Width = 70
				};
				class85_1.Columns.Add(columnHeader4);
				num++;
				num2 += columnHeader4.Width;
				ColumnHeader columnHeader5 = new ColumnHeader
				{
					TextAlign = HorizontalAlignment.Right,
					Text = Class333.smethod_941(),
					Width = 118
				};
				class85_1.Columns.Add(columnHeader5);
				num++;
				num2 += columnHeader5.Width;
				ColumnHeader columnHeader6 = new ColumnHeader
				{
					TextAlign = HorizontalAlignment.Right,
					Text = Class333.smethod_942(),
					Width = (flag2 ? 93 : 59)
				};
				class85_1.Columns.Add(columnHeader6);
				int_20 = num;
				num++;
				num2 += columnHeader6.Width;
				ColumnHeader columnHeader7 = new ColumnHeader
				{
					TextAlign = HorizontalAlignment.Right,
					Text = Class333.smethod_943(),
					Width = (flag2 ? 93 : 59)
				};
				class85_1.Columns.Add(columnHeader7);
				int_21 = num;
				num++;
				num2 += columnHeader7.Width;
				ColumnHeader columnHeader8 = new ColumnHeader
				{
					TextAlign = HorizontalAlignment.Right,
					Text = Class333.smethod_944(),
					Width = 100
				};
				class85_1.Columns.Add(columnHeader8);
				int_22 = num;
				num++;
				num2 += columnHeader8.Width;
				ColumnHeader columnHeader9 = new ColumnHeader
				{
					Text = string.Empty,
					Width = 24
				};
				class85_1.Columns.Add(columnHeader9);
				int_23 = num;
				num++;
				num2 += columnHeader9.Width;
				ColumnHeader columnHeader10 = new ColumnHeader
				{
					Text = string.Empty,
					Width = 24
				};
				class85_1.Columns.Add(columnHeader10);
				int_24 = num;
				num++;
				num2 += columnHeader10.Width;
				ColumnHeader columnHeader11 = new ColumnHeader
				{
					Text = string.Empty,
					Width = 24
				};
				class85_1.Columns.Add(columnHeader11);
				int_25 = num;
				num++;
				num2 += columnHeader11.Width;
				ColumnHeader columnHeader12 = new ColumnHeader
				{
					Text = Class333.smethod_945(),
					Width = (flag2 ? 260 : 190)
				};
				themedTextBox_0.Width = columnHeader12.Width;
				class85_1.Columns.Add(columnHeader12);
				int_26 = num;
				num++;
				num2 += columnHeader12.Width;
			}
		}
		if (flag)
		{
			backgroundWorker_0 = new BackgroundWorker();
			backgroundWorker_0.WorkerSupportsCancellation = true;
			backgroundWorker_0.DoWork += method_11;
			if (struct21_0.Boe == -1)
			{
				backgroundWorker_0.RunWorkerCompleted += method_12;
			}
			backgroundWorker_0.RunWorkerAsync(struct21_0);
		}
	}

	private void method_11(object sender, DoWorkEventArgs e)
	{
		lock (object_0)
		{
			int_11 = -1;
			int_12 = -1;
			int_13 = -1;
			int_14 = -1;
			int_18 = 0;
			if (backgroundWorker_0.CancellationPending)
			{
				e.Result = Enum56.BoG;
				return;
			}
			Struct21 Boq = (Struct21)e.Argument;
			if (bool_3)
			{
				method_17(Boq);
				method_21();
				e.Result = Enum56.Bof;
				return;
			}
			if (!method_13(out var string_))
			{
				e.Result = Enum56.Bog;
				return;
			}
			if (backgroundWorker_0.CancellationPending)
			{
				e.Result = Enum56.BoG;
				return;
			}
			if (Boq.Boe == -1)
			{
				if (Boq.BoF == Enum52.const_0)
				{
					method_18(bool_5: true);
				}
				else if (Boq.BoF == Enum52.const_1)
				{
					method_18(bool_5: false);
					method_21();
					Class190.smethod_3();
					e.Result = Enum56.Bof;
					return;
				}
			}
			while (!backgroundWorker_0.CancellationPending)
			{
				try
				{
					if (Form23.framework_1.method_31(9500).method_256() != 0)
					{
						e.Result = Enum56.BoH;
						return;
					}
					int_1 = Form23.framework_1.method_31(9497).method_256();
					int_2 = Form23.framework_1.method_31(9510).method_256();
					int num = Form23.framework_1.method_31(9501).method_256();
					int num2 = Form23.framework_1.method_31(9508).method_256();
					int int_ = Form23.framework_1.method_31(9509).method_256();
					method_14(num, string_);
					if (num == -1)
					{
						method_19(Boq.BoF);
						method_21();
						Class190.smethod_3();
						e.Result = Enum56.Bof;
						return;
					}
					if (num >= 0 && int_1 != 0)
					{
						if (backgroundWorker_0.CancellationPending)
						{
							e.Result = Enum56.BoG;
							return;
						}
						if (int_12 == -1 || int_11 == -1 || int_13 == -1 || int_14 == -1)
						{
							if (!smethod_18(ref int_, num2))
							{
								e.Result = Enum56.Boh;
								return;
							}
							if (!smethod_19(num, int_, num2))
							{
								e.Result = Enum56.Boh;
								return;
							}
							if (int_12 == 0 && int_13 == 0 && int_14 == 0 && int_16 == -1 && int_15 == -1)
							{
								method_19(Boq.BoF);
								method_21();
								Class190.smethod_3();
								e.Result = Enum56.Bof;
								return;
							}
						}
						if (backgroundWorker_0.CancellationPending)
						{
							e.Result = Enum56.BoG;
							return;
						}
						int num3 = ((int_14 <= int_13) ? (int_1 - int_12) : (int_14 - int_13));
						if (int_12 + num3 > int_1)
						{
							num3 = int_1 - int_12;
						}
						if ((int_14 > int_13 || int_12 < int_14) && int_12 + num3 > int_14)
						{
							num3 = int_14 - int_12;
						}
						int_18 += num3;
						int_12 += num3;
						if (int_12 == int_1)
						{
							int_12 = 0;
						}
						bool flag = int_11 != num;
						if (int_12 != num2 && (!flag || int_12 != int_17))
						{
							continue;
						}
						if (backgroundWorker_0.CancellationPending)
						{
							e.Result = Enum56.BoG;
							return;
						}
						Class189 BoR = null;
						if (Boq.Boe == -1 && dictionary_0.ContainsKey(int_11))
						{
							Class189 @class = dictionary_0[int_11];
							if (@class.BOz.Count == 1 && @class.Bob.Count == 1 && !string.IsNullOrEmpty(@class.BoE) && dictionary_1.ContainsKey(@class.BoE))
							{
								BoR = @class;
							}
						}
						if (backgroundWorker_0.CancellationPending)
						{
							e.Result = Enum56.BoG;
							return;
						}
						int BoV = 0;
						int Bou = 0;
						int Bor = 0;
						int BoS = 0;
						int Bos = 0;
						int BoT = 0;
						int Bot = 0;
						int BoU = 0;
						if (BoR == null)
						{
							Enum56 @enum = method_15(ref BoV, ref Bou, ref Bor, ref BoS, ref Bos, ref BoT, ref Bot, ref BoU);
							if (@enum == Enum56.BoG || @enum == Enum56.Boh)
							{
								e.Result = @enum;
								return;
							}
						}
						if (Boq.Boe != -1)
						{
							class85_1.Invoke(() =>
							{
								if (class85_1.Items.Count != 0)
								{
									foreach (ListViewItem item in class85_1.Items)
									{
										BoR = (Class189)item.Tag;
										if (BoR.BOz.Count == 1 && BoR.BOz[0] == Boq.Boe)
										{
											BoR.BoB = int_18;
											BoR.Bob = new List<DateTime>();
											BoR.Bob.Add(new DateTime(Bor, BoS, Bos, BoT, Bot, BoU));
											BoR.BoC = Bou;
											BoR.Boc = Bou - BoV;
											BoR.BoE = string.Empty;
											method_25(BoR, bool_5: false, item);
											backgroundWorker_1 = new BackgroundWorker();
											backgroundWorker_1.WorkerSupportsCancellation = true;
											backgroundWorker_1.DoWork += method_23;
											backgroundWorker_1.RunWorkerAsync();
											break;
										}
									}
								}
							});
							e.Result = Enum56.Bof;
							return;
						}
						bool bool_ = false;
						if (string_ != string.Empty)
						{
							string path = string_ + Class333.smethod_946();
							if (File.Exists(path))
							{
								try
								{
									using StreamReader streamReader = File.OpenText(path);
									string s;
									while ((s = streamReader.ReadLine()) != null)
									{
										if (int.Parse(s) == int_11)
										{
											bool_ = true;
											break;
										}
									}
								}
								catch
								{
								}
							}
						}
						if (backgroundWorker_0.CancellationPending)
						{
							e.Result = Enum56.BoG;
							return;
						}
						if (BoR == null)
						{
							BoR = method_16(bool_, BoV, Bou, Bor, BoS, Bos, BoT, Bot, BoU);
						}
						else
						{
							dictionary_2[BoR.BoE] = BoR.BOz;
							dictionary_3[BoR.BoE] = BoR.BoA;
						}
						method_25(BoR, bool_5: false, null);
						if (backgroundWorker_0.CancellationPending)
						{
							e.Result = Enum56.BoG;
							return;
						}
						int_11--;
						if (int_11 >= 0 && int_18 < int_1 && int_15 != -1 && int_16 != -1 && int_16 < int_11 + 1)
						{
							if (!smethod_20(num2))
							{
								e.Result = Enum56.Boh;
								return;
							}
							continue;
						}
						e.Result = Enum56.Bof;
						method_19(Boq.BoF);
						method_21();
						Class190.smethod_3();
						return;
					}
					e.Result = Enum56.BoI;
					return;
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.smethod_947() + ex.Message);
					e.Result = Enum56.BoI;
					return;
				}
			}
			e.Result = Enum56.BoG;
		}
	}

	private void method_12(object sender, RunWorkerCompletedEventArgs e)
	{
		try
		{
			if ((Enum56)e.Result == Enum56.Bof)
			{
				Setting setting = Form23.framework_1.method_31(9500);
				if (setting != null)
				{
					setting.method_265(method_24);
					setting.method_264(method_24);
				}
			}
			else
			{
				if ((Enum56)e.Result == Enum56.BoG)
				{
					return;
				}
				if ((Enum56)e.Result == Enum56.Bog)
				{
					if (Form54.smethod_6(this, Class333.smethod_948(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
					{
						Form61 form = new Form61(Form23.framework_1);
						DialogResult dialogResult = form.ShowDialog(this);
						form.Dispose();
						if (dialogResult == DialogResult.OK)
						{
							Close();
							Form23.form23_0.class166_0_Click(null, null);
						}
						else
						{
							Close();
						}
					}
					else
					{
						Close();
					}
				}
				else if ((Enum56)e.Result == Enum56.BoH)
				{
					Form54.smethod_6(this, Class333.smethod_949(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Close();
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_950(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Close();
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_951() + ex.Message);
		}
	}

	private bool method_13(out string string_3)
	{
		string_1 = null;
		string_3 = string.Empty;
		string Bow = string.Empty;
		if (Form23.framework_1.method_28(ref Bow))
		{
			try
			{
				Invoke(() =>
				{
					Text = Class333.BDK() + Bow + Class333.smethod_1394();
				});
			}
			catch
			{
			}
			string_3 = Form23.framework_1.aXD;
			if (string.IsNullOrEmpty(string_3))
			{
				string_3 = Form23.smethod_99(Bow, Form23.framework_1.aXc);
				try
				{
					if (string.IsNullOrEmpty(string_3))
					{
						string_3 = Form23.smethod_100(Bow, new List<string> { Form23.framework_1.aXc });
					}
					Form23.framework_1.aXD = string_3;
				}
				catch
				{
					return false;
				}
			}
			string_1 = string_3 + Class333.smethod_952();
			Directory.CreateDirectory(string_1);
			return true;
		}
		return false;
	}

	private void method_14(int int_29, string string_3)
	{
		if (!(string_3 != string.Empty))
		{
			return;
		}
		string path = string_3 + Class333.smethod_946();
		if (!File.Exists(path))
		{
			return;
		}
		int num = -1;
		try
		{
			using StreamReader streamReader = File.OpenText(path);
			string s;
			while ((s = streamReader.ReadLine()) != null)
			{
				num = Math.Max(num, int.Parse(s));
			}
		}
		catch
		{
		}
		if (num != -1 && int_29 < num)
		{
			string Box = string_3 + Class333.smethod_953() + Class23.smethod_10(bool_1: false);
			Invoke(() =>
			{
				Form54.smethod_6(this, Class333.BDk() + Box, Class333.BDL(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			});
			dictionary_0.Clear();
			dictionary_1.Clear();
			dictionary_2.Clear();
			dictionary_3.Clear();
			dictionary_4.Clear();
			dictionary_5.Clear();
			dictionary_6.Clear();
			dictionary_7.Clear();
			try
			{
				Directory.Move(string_1, Box);
				Directory.CreateDirectory(string_1);
			}
			catch
			{
			}
		}
	}

	private Enum56 method_15(ref int int_29, ref int int_30, ref int int_31, ref int int_32, ref int int_33, ref int int_34, ref int int_35, ref int int_36)
	{
		byte[] byte_ = null;
		byte[] byte_2 = null;
		bool flag;
		do
		{
			Enum6 @enum = Class1.enum6_0;
			Class1.enum6_0 = Enum6.const_3;
			flag = Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_12, (uint)int_13, Math.Min(16384u, (uint)int_2), out byte_, out var flag2);
			Class1.enum6_0 = @enum;
			if (!backgroundWorker_0.CancellationPending)
			{
				if (!flag)
				{
					continue;
				}
				if (dictionary_4.ContainsKey(int_11) && dictionary_5.ContainsKey(int_11))
				{
					flag = true;
				}
				else
				{
					int num;
					for (num = int_13 + int_18 - int_2; num >= int_1; num -= int_1)
					{
					}
					Enum6 enum2 = Class1.enum6_0;
					Class1.enum6_0 = Enum6.const_3;
					flag = Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_12, (uint)num, (uint)int_2, out byte_2, out flag2);
					Class1.enum6_0 = enum2;
				}
				if (backgroundWorker_0.CancellationPending)
				{
					return Enum56.BoG;
				}
				continue;
			}
			return Enum56.BoG;
		}
		while (!flag && bool_4);
		if (!flag)
		{
			return Enum56.Boh;
		}
		int_29 = smethod_16(byte_);
		if (byte_2 != null)
		{
			int_30 = smethod_17(byte_2);
		}
		else if (dictionary_5.ContainsKey(int_11))
		{
			int_30 = dictionary_5[int_11];
		}
		if (byte_2 != null)
		{
			if (byte_2[3] == 1 && byte_2[8] == 72 && byte_2[9] == 65 && byte_2[10] == 76 && byte_2[11] == 84 && byte_2[12] == 69 && byte_2[13] == 67 && byte_2[14] == 72 && (byte_2[15] == 48 || byte_2[15] == 49))
			{
				int_31 = ((byte_2[56] << 8) & 0xFF00) | (byte_2[57] & 0xFF);
				int_32 = byte_2[58];
				int_33 = byte_2[59];
				int_34 = byte_2[52];
				int_35 = byte_2[53];
				int_36 = byte_2[54];
			}
		}
		else if (dictionary_4.ContainsKey(int_11))
		{
			DateTime dateTime = dictionary_4[int_11];
			int_31 = dateTime.Year;
			int_32 = dateTime.Month;
			int_33 = dateTime.Day;
			int_34 = dateTime.Hour;
			int_35 = dateTime.Minute;
			int_36 = dateTime.Second;
		}
		if (int_31 < 1 || int_31 > 9999 || int_32 < 1 || int_32 > 12 || int_33 < 1 || int_33 > 31 || int_34 < 0 || int_34 > 23 || int_35 < 0 || int_35 > 59 || int_36 < 0 || int_36 > 59)
		{
			int_31 = dateTime_1.Year;
			int_32 = dateTime_1.Month;
			int_33 = dateTime_1.Day;
			int_34 = dateTime_1.Hour;
			int_35 = dateTime_1.Minute;
			int_36 = dateTime_1.Second;
		}
		if (backgroundWorker_0.CancellationPending)
		{
			return Enum56.BoG;
		}
		return Enum56.Bof;
	}

	private Class189 method_16(bool bool_5, int int_29, int int_30, int int_31, int int_32, int int_33, int int_34, int int_35, int int_36)
	{
		List<int> list = new List<int>();
		list.Add(int_11);
		string text = smethod_9(list);
		if (text == null)
		{
			text = smethod_11(list);
		}
		if (text == null)
		{
			text = string.Empty;
		}
		Class189 @class = new Class189
		{
			BOz = new List<int>(),
			BoA = (byte)Form23.framework_1.awZ,
			Boa = bool_5,
			BoB = int_18,
			Bob = new List<DateTime>(),
			BoC = int_30,
			Boc = int_30 - int_29,
			BoD = 0,
			Bod = 0,
			BoE = Path.GetFileNameWithoutExtension(text)
		};
		@class.BOz.Add(int_11);
		@class.Bob.Add(new DateTime(int_31, int_32, int_33, int_34, int_35, int_36));
		dictionary_0[int_11] = @class;
		dictionary_4[int_11] = @class.Bob[0];
		dictionary_5[int_11] = @class.BoC;
		dictionary_6[int_11] = @class.BoD;
		dictionary_7[int_11] = @class.Bod;
		if (!string.IsNullOrEmpty(text))
		{
			dictionary_1[@class.BoE] = @class;
			dictionary_2[@class.BoE] = @class.BOz;
			dictionary_3[@class.BoE] = @class.BoA;
		}
		return @class;
	}

	private void method_17(Struct21 struct21_0)
	{
		string_1 = string_2;
		if (struct21_0.BoF == Enum52.const_0)
		{
			method_18(bool_5: true);
			method_19(Enum52.const_0);
		}
		else if (struct21_0.BoF == Enum52.const_1)
		{
			method_18(bool_5: false);
		}
		else if (struct21_0.BoF == Enum52.const_2)
		{
			method_19(struct21_0.BoF);
		}
		Class190.smethod_3();
	}

	private void method_18(bool bool_5)
	{
		if (string_1 == null || !Directory.Exists(string_1))
		{
			return;
		}
		string[] files = Directory.GetFiles(string_1);
		foreach (string text in files)
		{
			if (!backgroundWorker_0.CancellationPending)
			{
				if ((text.EndsWith(Class333.smethod_489()) || text.EndsWith(Class333.smethod_488())) && (Form23.class284_0.BCt.Contains(text) || !bool_5))
				{
					method_20(text, bool_5: true, bool_6: true, -1);
				}
				continue;
			}
			break;
		}
	}

	private void method_19(Enum52 enum52_1)
	{
		if (string_1 == null || !Directory.Exists(string_1) || backgroundWorker_0.CancellationPending)
		{
			return;
		}
		int Boy = int.MaxValue;
		class85_1.Invoke(() =>
		{
			for (int num2 = class85_1.Items.Count - 1; num2 >= 0; num2--)
			{
				Class189 @class = (Class189)class85_1.Items[num2].Tag;
				if (@class.BoA != 0 && @class.BOz.Count == 1)
				{
					Boy = Math.Min(Boy, @class.BOz[0]);
				}
			}
		});
		bool bool_ = enum52_1 == Enum52.const_0;
		string[] files = Directory.GetFiles(string_1);
		foreach (string text in files)
		{
			if (!backgroundWorker_0.CancellationPending)
			{
				if ((text.EndsWith(Class333.smethod_489()) || text.EndsWith(Class333.smethod_488())) && !Form23.class284_0.BCt.Contains(text))
				{
					method_20(text, bool_5: false, bool_, Boy);
				}
				continue;
			}
			break;
		}
	}

	private void method_20(string string_3, bool bool_5, bool bool_6, int int_29)
	{
		byte b = byte.MaxValue;
		List<int> list = new List<int>();
		List<DateTime> list2 = new List<DateTime>();
		MemoryStream memoryStream = null;
		ZipArchive zipArchive = null;
		ZipArchiveEntry zipArchiveEntry = null;
		Stream stream = null;
		try
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_3);
			if (dictionary_1.ContainsKey(fileNameWithoutExtension))
			{
				Class189 @class = dictionary_1[fileNameWithoutExtension];
				bool flag = @class.BoA == 0;
				if ((!bool_5 || flag) && (!flag || bool_6) && (@class.BOz.Count != 1 || flag || int_29 == -1 || @class.BOz[0] < int_29))
				{
					method_25(@class, bool_5: false, null);
				}
				return;
			}
			memoryStream = Class35.smethod_7(string_3, Class19.smethod_3());
			if (backgroundWorker_0.CancellationPending)
			{
				return;
			}
			if (memoryStream.CanRead)
			{
				int boB = 0;
				if (string_3.EndsWith(Class333.smethod_488()))
				{
					zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Read);
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
					foreach (ZipArchiveEntry entry in zipArchive.Entries)
					{
						if (entry.Name.EndsWith(Class333.smethod_489()))
						{
							zipArchiveEntry = entry;
							break;
						}
					}
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
					if (zipArchiveEntry != null)
					{
						stream = zipArchiveEntry.Open();
						boB = (int)zipArchiveEntry.Length;
					}
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
				}
				else
				{
					stream = new FileStream(string_3, FileMode.Open);
					boB = (int)memoryStream.Length;
				}
				int num = -1;
				int num2 = 0;
				bool flag2 = false;
				int num3;
				do
				{
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
					num3 = stream.ReadByte();
					if (num3 == -1)
					{
						break;
					}
					if (num3 != 255)
					{
						byte[] array = new byte[4];
						if (!Class23.smethod_14(stream, array, 0, 4))
						{
							break;
						}
						uint num4 = (uint)((array[0] << 24) | ((array[1] << 16) & 0xFF0000) | ((array[2] << 8) & 0xFF00) | (array[3] & 0xFF));
						if (num4 == uint.MaxValue || num4 == 0 || (num4 > 131072 && num3 != 2 && (num3 & 0xF) != 9 && num3 != 13))
						{
							break;
						}
						if (num3 == 14)
						{
							uint num5 = 0u;
							byte[] array2 = new byte[num4 - 5];
							if (!Class23.smethod_14(stream, array2, 0, (int)(num4 - 5)))
							{
								flag2 = true;
							}
							else
							{
								for (int i = 5; i < num4; i++)
								{
									if (!backgroundWorker_0.CancellationPending)
									{
										byte b2 = array2[i - 5];
										switch ((i - 5) % 4)
										{
										case 0:
											num5 = (uint)((b2 << 24) & -16777216);
											break;
										case 1:
											num5 |= (uint)((b2 << 16) & 0xFF0000);
											break;
										case 2:
											num5 |= (uint)((b2 << 8) & 0xFF00);
											break;
										case 3:
											num5 |= (uint)(b2 & 0xFF);
											list.Add((int)num5);
											break;
										}
										continue;
									}
									return;
								}
							}
						}
						else if (num3 == 1)
						{
							uint num6 = 0u;
							int num7 = 0;
							int num8 = 1;
							int num9 = 1;
							int num10 = 1;
							int num11 = 1;
							int num12 = 1;
							byte[] array3 = new byte[num4 - 5];
							if (!Class23.smethod_14(stream, array3, 0, (int)(num4 - 5)))
							{
								flag2 = true;
							}
							else
							{
								for (int j = 5; j < num4; j++)
								{
									if (backgroundWorker_0.CancellationPending)
									{
										return;
									}
									byte b3 = array3[j - 5];
									if ((j == 5 && b3 != 72) || (j == 6 && b3 != 65) || (j == 7 && b3 != 76) || (j == 8 && b3 != 84) || (j == 9 && b3 != 69) || (j == 10 && b3 != 67) || (j == 11 && b3 != 72) || (j == 12 && b3 != 48 && b3 != 49))
									{
										flag2 = true;
										continue;
									}
									switch (j)
									{
									case 53:
										num7 = (b3 << 8) & 0xFF00;
										break;
									case 54:
										num7 |= b3 & 0xFF;
										break;
									case 55:
										num8 = b3;
										break;
									case 56:
										num9 = b3;
										break;
									case 49:
										num10 = b3;
										break;
									case 50:
										num11 = b3;
										break;
									case 51:
										num12 = b3;
										break;
									}
									if (j == 56)
									{
										DateTime item = ((num7 < 1 || num7 > 9999 || num8 < 1 || num8 > 12 || num9 < 1 || num9 > 31 || num10 < 0 || num10 > 23 || num11 < 0 || num11 > 59 || num12 < 0 || num12 > 59) ? dateTime_1 : new DateTime(num7, num8, num9, num10, num11, num12));
										if (!list2.Contains(item))
										{
											list2.Add(item);
										}
									}
									switch (j)
									{
									case 57:
										num6 |= (uint)(b3 << 24);
										break;
									case 58:
										num6 |= (uint)((b3 << 16) & 0xFF0000);
										break;
									case 59:
										num6 |= (uint)((b3 << 8) & 0xFF00);
										break;
									case 60:
										num6 |= (uint)(b3 & 0xFF);
										if (!list.Contains((int)num6))
										{
											list.Add((int)num6);
										}
										break;
									}
									if (j == 65 && b == byte.MaxValue)
									{
										b = b3;
										bool flag3 = b == 0;
										if ((bool_5 && !flag3) || (flag3 && !bool_6) || (list.Count == 1 && !flag3 && int_29 != -1 && list[0] >= int_29))
										{
											return;
										}
									}
								}
							}
						}
						else if ((num3 & 0xF) != 7 && num3 != 12)
						{
							byte[] byte_ = new byte[num4 - 5];
							if (!Class23.smethod_14(stream, byte_, 0, (int)(num4 - 5)))
							{
								flag2 = true;
								break;
							}
						}
						else
						{
							if (num3 == 12)
							{
								byte[] byte_2 = new byte[2];
								if (!Class23.smethod_14(stream, byte_2, 0, 2))
								{
									break;
								}
							}
							byte[] array4 = new byte[4];
							if (!Class23.smethod_14(stream, array4, 0, 4))
							{
								break;
							}
							num2 = (array4[0] << 24) | ((array4[1] << 16) & 0xFF0000) | ((array4[2] << 8) & 0xFF00) | (array4[3] & 0xFF);
							if (num == -1)
							{
								num = num2;
							}
							uint num13 = ((num3 != 12) ? (num4 - 9) : (num4 - 11));
							byte[] byte_3 = new byte[num13];
							if (!Class23.smethod_14(stream, byte_3, 0, (int)num13))
							{
								flag2 = true;
								break;
							}
						}
					}
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
				}
				while (num3 != -1 && !flag2);
				if (list.Count != 0 && b != byte.MaxValue && num != -1 && num2 != 0)
				{
					Class189 class2 = new Class189
					{
						BOz = new List<int>(),
						BoA = b,
						Boa = true,
						BoB = boB,
						Bob = new List<DateTime>(),
						BoC = num2,
						Boc = num2 - num,
						BoD = 0,
						Bod = 0,
						BoE = fileNameWithoutExtension
					};
					class2.BOz.AddRange(list);
					class2.Bob.AddRange(list2);
					if (list.Count == 1)
					{
						dictionary_0[list[0]] = class2;
						dictionary_4[list[0]] = class2.Bob[0];
						dictionary_5[list[0]] = class2.BoC;
					}
					dictionary_1[class2.BoE] = class2;
					dictionary_2[class2.BoE] = class2.BOz;
					dictionary_3[class2.BoE] = class2.BoA;
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
					method_25(class2, bool_5: false, null);
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_954() + ex.Message);
		}
		finally
		{
			stream?.Close();
			zipArchive?.Dispose();
			memoryStream?.Close();
		}
		Thread.Sleep(0);
	}

	private void method_21()
	{
		if (string_1 == null || !Directory.Exists(string_1))
		{
			return;
		}
		List<string> list = null;
		try
		{
			list = (from fileInfo_0 in new DirectoryInfo(string_1).GetFiles()
				orderby fileInfo_0.LastWriteTime
				select fileInfo_0.FullName).ToList();
		}
		catch
		{
			list = null;
		}
		if (list == null)
		{
			return;
		}
		foreach (string item in list)
		{
			if (!backgroundWorker_0.CancellationPending)
			{
				if (item.EndsWith(Class333.smethod_489()) || item.EndsWith(Class333.smethod_488()))
				{
					method_22(item);
				}
				continue;
			}
			break;
		}
	}

	private void method_22(string string_3)
	{
		List<int> list = new List<int>();
		MemoryStream memoryStream = null;
		ZipArchive zipArchive = null;
		ZipArchiveEntry zipArchiveEntry = null;
		Stream stream = null;
		int num = 0;
		int num2 = 0;
		int num3 = -1;
		int num4 = -1;
		int num5 = -1;
		int num6 = -1;
		try
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_3);
			if (dictionary_1.ContainsKey(fileNameWithoutExtension))
			{
				Class189 @class = dictionary_1[fileNameWithoutExtension];
				if (@class.BoD != 0 || @class.Bod != 0)
				{
					return;
				}
			}
			memoryStream = Class35.smethod_7(string_3, Class19.smethod_3());
			if (backgroundWorker_0.CancellationPending)
			{
				return;
			}
			if (memoryStream.CanRead)
			{
				if (string_3.EndsWith(Class333.smethod_488()))
				{
					zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Read);
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
					foreach (ZipArchiveEntry entry in zipArchive.Entries)
					{
						if (entry.Name.EndsWith(Class333.smethod_489()))
						{
							zipArchiveEntry = entry;
							break;
						}
					}
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
					if (zipArchiveEntry != null)
					{
						stream = zipArchiveEntry.Open();
						_ = zipArchiveEntry.Length;
					}
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
				}
				else
				{
					stream = new FileStream(string_3, FileMode.Open);
					_ = memoryStream.Length;
				}
				bool flag = false;
				int num7;
				do
				{
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
					num7 = stream.ReadByte();
					if (num7 == -1)
					{
						break;
					}
					if (num7 != 255)
					{
						byte[] array = new byte[4];
						if (!Class23.smethod_14(stream, array, 0, 4))
						{
							break;
						}
						uint num8 = (uint)((array[0] << 24) | ((array[1] << 16) & 0xFF0000) | ((array[2] << 8) & 0xFF00) | (array[3] & 0xFF));
						if (num8 == uint.MaxValue || num8 == 0 || (num8 > 131072 && num7 != 2 && (num7 & 0xF) != 9 && num7 != 13))
						{
							break;
						}
						if (num7 == 14)
						{
							uint num9 = 0u;
							byte[] array2 = new byte[num8 - 5];
							if (!Class23.smethod_14(stream, array2, 0, (int)(num8 - 5)))
							{
								flag = true;
							}
							else
							{
								for (int i = 5; i < num8; i++)
								{
									if (!backgroundWorker_0.CancellationPending)
									{
										byte b = array2[i - 5];
										switch ((i - 5) % 4)
										{
										case 0:
											num9 = (uint)((b << 24) & -16777216);
											break;
										case 1:
											num9 |= (uint)((b << 16) & 0xFF0000);
											break;
										case 2:
											num9 |= (uint)((b << 8) & 0xFF00);
											break;
										case 3:
											num9 |= (uint)(b & 0xFF);
											list.Add((int)num9);
											break;
										}
										continue;
									}
									return;
								}
							}
						}
						else if (num7 == 1)
						{
							uint num10 = 0u;
							byte[] array3 = new byte[num8 - 5];
							if (!Class23.smethod_14(stream, array3, 0, (int)(num8 - 5)))
							{
								flag = true;
							}
							else
							{
								for (int j = 5; j < num8; j++)
								{
									if (backgroundWorker_0.CancellationPending)
									{
										return;
									}
									byte b2 = array3[j - 5];
									if ((j == 5 && b2 != 72) || (j == 6 && b2 != 65) || (j == 7 && b2 != 76) || (j == 8 && b2 != 84) || (j == 9 && b2 != 69) || (j == 10 && b2 != 67) || (j == 11 && b2 != 72) || (j == 12 && b2 != 48 && b2 != 49))
									{
										flag = true;
										continue;
									}
									switch (j)
									{
									case 57:
										num10 |= (uint)(b2 << 24);
										break;
									case 58:
										num10 |= (uint)((b2 << 16) & 0xFF0000);
										break;
									case 59:
										num10 |= (uint)((b2 << 8) & 0xFF00);
										break;
									case 60:
										num10 |= (uint)(b2 & 0xFF);
										if (!list.Contains((int)num10))
										{
											list.Add((int)num10);
										}
										break;
									}
								}
							}
						}
						else if ((num7 & 0xF) != 6 && num7 != 11)
						{
							if ((num7 & 0xF) != 7 && num7 != 12)
							{
								byte[] byte_ = new byte[num8 - 5];
								if (!Class23.smethod_14(stream, byte_, 0, (int)(num8 - 5)))
								{
									flag = true;
									break;
								}
							}
							else
							{
								int num11;
								if (num7 == 12)
								{
									byte[] array4 = new byte[2];
									if (!Class23.smethod_14(stream, array4, 0, 2))
									{
										break;
									}
									num11 = ((array4[0] << 8) & 0xFF00) | (array4[1] & 0xFF);
								}
								else
								{
									num11 = (num7 >> 4) & 0xF;
								}
								byte[] byte_2 = new byte[4];
								if (!Class23.smethod_14(stream, byte_2, 0, 4))
								{
									break;
								}
								uint num12 = ((num7 != 12) ? (num8 - 9) : (num8 - 11));
								byte[] array5 = new byte[num12];
								if (!Class23.smethod_14(stream, array5, 0, (int)num12))
								{
									flag = true;
									break;
								}
								if (num3 != -1 && num5 != -1 && num11 == num3)
								{
									int val = (array5[4 * num5] << 24) | ((array5[4 * num5 + 1] << 16) & 0xFF0000) | ((array5[4 * num5 + 2] << 8) & 0xFF00) | (array5[4 * num5 + 3] & 0xFF);
									num = Math.Max(num, val);
								}
								if (num4 != -1 && num6 != -1 && num11 == num4)
								{
									int val2 = (array5[4 * num6] << 24) | ((array5[4 * num6 + 1] << 16) & 0xFF0000) | ((array5[4 * num6 + 2] << 8) & 0xFF00) | (array5[4 * num6 + 3] & 0xFF);
									num2 = Math.Max(num2, val2);
								}
							}
						}
						else
						{
							int num13;
							if (num7 == 11)
							{
								byte[] array6 = new byte[2];
								if (!Class23.smethod_14(stream, array6, 0, 2))
								{
									break;
								}
								num13 = ((array6[0] << 8) & 0xFF00) | (array6[1] & 0xFF);
							}
							else
							{
								num13 = (num7 >> 4) & 0xF;
							}
							uint num14 = ((num7 != 11) ? (num8 - 5) : (num8 - 7));
							byte[] array7 = new byte[num14];
							if (!Class23.smethod_14(stream, array7, 0, (int)num14))
							{
								flag = true;
								break;
							}
							uint num15 = num14 / 2;
							for (int k = 0; k < num15; k++)
							{
								switch ((ushort)(((array7[2 * k] << 8) & 0xFF00) | (array7[2 * k + 1] & 0xFF)))
								{
								case 384:
									num3 = num13;
									num5 = k;
									break;
								case 224:
									num4 = num13;
									num6 = k;
									break;
								}
							}
						}
					}
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
				}
				while (num7 != -1 && !flag);
				if (list.Count != 0 && num3 != -1 && num4 != -1 && (num != 0 || num2 != 0))
				{
					if (dictionary_1.ContainsKey(fileNameWithoutExtension))
					{
						Class189 Boz = dictionary_1[fileNameWithoutExtension];
						Boz.BoD = num;
						Boz.Bod = num2;
						class85_1.Invoke(() =>
						{
							if (class85_1.Items.Count != 0)
							{
								foreach (ListViewItem item in class85_1.Items)
								{
									if ((Class189)item.Tag == Boz)
									{
										method_25(Boz, bool_5: false, item);
										break;
									}
								}
							}
						});
					}
					if (list.Count == 1)
					{
						dictionary_6[list[0]] = num;
						dictionary_7[list[0]] = num2;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_955() + ex.Message);
		}
		finally
		{
			stream?.Close();
			zipArchive?.Dispose();
			memoryStream?.Close();
		}
		Thread.Sleep(0);
	}

	private void method_23(object sender, DoWorkEventArgs e)
	{
		if (!Monitor.TryEnter(object_0, 1000))
		{
			return;
		}
		try
		{
			int_11 = -1;
			int_12 = -1;
			int_13 = -1;
			int_14 = -1;
			int_18 = 0;
			int BPa = int.MaxValue;
			while (!backgroundWorker_1.CancellationPending)
			{
				try
				{
					if (Form23.framework_1.method_31(9500).method_256() != 0)
					{
						break;
					}
					int_1 = Form23.framework_1.method_31(9497).method_256();
					int_2 = Form23.framework_1.method_31(9510).method_256();
					int num = Form23.framework_1.method_31(9501).method_256();
					int num2 = Form23.framework_1.method_31(9508).method_256();
					int int_ = Form23.framework_1.method_31(9509).method_256();
					if (num < 0 || int_1 == 0 || backgroundWorker_1.CancellationPending || ((int_12 == -1 || int_11 == -1 || int_13 == -1 || int_14 == -1) && (!smethod_18(ref int_, num2) || !smethod_19(num, int_, num2))) || backgroundWorker_1.CancellationPending)
					{
						break;
					}
					int num3 = ((int_14 <= int_13) ? (int_1 - int_12) : (int_14 - int_13));
					if (int_12 + num3 > int_1)
					{
						num3 = int_1 - int_12;
					}
					if ((int_14 > int_13 || int_12 < int_14) && int_12 + num3 > int_14)
					{
						num3 = int_14 - int_12;
					}
					int_18 += num3;
					int_12 += num3;
					if (int_12 == int_1)
					{
						int_12 = 0;
					}
					bool flag = int_11 != num;
					if (int_12 != num2 && (!flag || int_12 != int_17))
					{
						continue;
					}
					BPa = int_11;
					int_11--;
					if (int_11 >= 0 && int_18 < int_1 && int_15 != -1 && int_16 != -1 && int_16 < int_11 + 1)
					{
						if (backgroundWorker_1.CancellationPending || !smethod_20(num2))
						{
							break;
						}
						continue;
					}
					if (backgroundWorker_1.CancellationPending)
					{
						break;
					}
					class85_1.Invoke(() =>
					{
						for (int num4 = class85_1.Items.Count - 1; num4 >= 0; num4--)
						{
							Class189 @class = (Class189)class85_1.Items[num4].Tag;
							bool flag2 = @class.BoA != 0;
							if (((@class.BOz.Count == 1 && @class.BOz[0] < BPa) & flag2) && !@class.Boa)
							{
								smethod_6(@class.BOz[0]);
								class85_1.Items[num4].Tag = null;
								class85_1.Items.RemoveAt(num4);
								if (dictionary_0.ContainsKey(@class.BOz[0]))
								{
									dictionary_0.Remove(@class.BOz[0]);
								}
								if (dictionary_4.ContainsKey(@class.BOz[0]))
								{
									dictionary_4.Remove(@class.BOz[0]);
								}
								if (dictionary_5.ContainsKey(@class.BOz[0]))
								{
									dictionary_5.Remove(@class.BOz[0]);
								}
								if (dictionary_6.ContainsKey(@class.BOz[0]))
								{
									dictionary_6.Remove(@class.BOz[0]);
								}
								if (dictionary_7.ContainsKey(@class.BOz[0]))
								{
									dictionary_7.Remove(@class.BOz[0]);
								}
							}
						}
						class85_1.method_1();
						class85_1.Invalidate();
					});
					break;
				}
				catch
				{
					break;
				}
			}
		}
		finally
		{
			Monitor.Exit(object_0);
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate102 method = method_24;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (themedComboBox_1.SelectedIndex == 1 || !(sender is Setting))
		{
			return;
		}
		int num = (sender as Setting).method_256();
		Setting setting = Form23.framework_1.method_31(9501);
		if (setting != null)
		{
			int num2 = setting.method_256();
			if (num2 != -1)
			{
				if (num != 0 && num != 12 && int_27 == 0)
				{
					Class189 @class = new Class189
					{
						BOz = new List<int>(),
						BoA = (byte)Form23.framework_1.awZ,
						Boa = false,
						BoB = -1,
						Bob = new List<DateTime>(),
						BoC = -1,
						Boc = -1,
						BoD = 0,
						Bod = 0,
						BoE = string.Empty
					};
					@class.BOz.Add(num2);
					@class.Bob.Add(DateTime.Now);
					dictionary_0[num2] = @class;
					method_25(@class, bool_5: true, null);
				}
				else if (num == 0 && int_27 != 0 && int_27 != 12)
				{
					Struct21 struct21_ = new Struct21
					{
						Boe = num2,
						BoF = (Enum52)themedComboBox_1.SelectedIndex
					};
					method_10(struct21_);
				}
			}
		}
		int_27 = num;
	}

	private void method_25(Class189 class189_0, bool bool_5, ListViewItem listViewItem_1)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate103 method = method_25;
				BeginInvoke(method, class189_0, bool_5, listViewItem_1);
				return;
			}
			catch
			{
				return;
			}
		}
		bool flag = smethod_15();
		bool flag2 = class189_0.BoA == 0;
		string[] array = method_26(class189_0, flag, bool_5, flag2);
		bool flag3 = false;
		if (flag2)
		{
			string item = string.Empty;
			if (!string.IsNullOrEmpty(string_1) && !string.IsNullOrEmpty(class189_0.BoE))
			{
				item = string_1 + Class333.smethod_176() + class189_0.BoE + Class333.smethod_488();
			}
			flag3 = Form23.class284_0.BCt.Contains(item);
		}
		if (listViewItem_1 == null)
		{
			ListViewItem listViewItem = new ListViewItem(array)
			{
				Tag = class189_0
			};
			if (bool_5)
			{
				class85_1.Items.Insert(0, listViewItem);
			}
			else if (class85_1.Items.Count == 0)
			{
				class85_1.Items.Add(listViewItem);
			}
			else
			{
				for (int i = 0; i < class85_1.Items.Count; i++)
				{
					Class189 @class = (Class189)class85_1.Items[i].Tag;
					bool flag4 = @class.BoA == 0;
					bool flag5 = false;
					if (flag4)
					{
						string item2 = string.Empty;
						if (!string.IsNullOrEmpty(string_1) && !string.IsNullOrEmpty(@class.BoE))
						{
							item2 = string_1 + Class333.smethod_176() + @class.BoE + Class333.smethod_488();
						}
						flag5 = Form23.class284_0.BCt.Contains(item2);
					}
					bool flag6 = class189_0.Bob[class189_0.Bob.Count - 1] >= @class.Bob[@class.Bob.Count - 1];
					bool flag7 = class189_0.BOz[class189_0.BOz.Count - 1] >= @class.BOz[@class.BOz.Count - 1];
					if (!(flag ? (flag3 ? (!flag4 | flag6) : ((!(flag2 & flag4)) ? (flag7 && !flag5) : (flag6 && !flag5))) : (((class189_0.Bob[class189_0.Bob.Count - 1] != dateTime_1) & (@class.Bob[@class.Bob.Count - 1] != dateTime_1)) ? flag6 : ((!flag2 && !flag4) ? flag7 : ((!flag2) ? (!flag5) : flag3)))))
					{
						if (i == class85_1.Items.Count - 1)
						{
							class85_1.Items.Add(listViewItem);
							break;
						}
						continue;
					}
					class85_1.Items.Insert(i, listViewItem);
					break;
				}
			}
			class85_1.method_1();
			class85_1.Invalidate();
			method_2();
			return;
		}
		listViewItem_1.Tag = class189_0;
		if (listViewItem_1.SubItems.Count == array.Length)
		{
			for (int j = 0; j < listViewItem_1.SubItems.Count; j++)
			{
				listViewItem_1.SubItems[j].Text = array[j];
			}
		}
	}

	private string[] method_26(Class189 class189_0, bool bool_5, bool bool_6, bool bool_7)
	{
		string text = null;
		string text2 = null;
		if (!bool_5)
		{
			DateTime now = DateTime.Now;
			if (class189_0.Bob.Count <= 1)
			{
				if (class189_0.Bob[0].Year == now.Year && class189_0.Bob[0].Month == now.Month && class189_0.Bob[0].Day == now.Day)
				{
					text = Class333.smethod_957();
				}
				else
				{
					text = ((!(class189_0.Bob[0] == dateTime_1)) ? string.Format(Class333.smethod_958(), class189_0.Bob[0]) : string.Empty);
				}
				text2 = ((!(class189_0.Bob[0] == dateTime_1)) ? class189_0.Bob[0].ToString(DateTimeFormatInfo.CurrentInfo.ShortTimePattern) : string.Empty);
			}
			else
			{
				text = Class333.smethod_956();
				text2 = Class333.smethod_956();
			}
		}
		string text3 = ((!bool_6) ? string.Format(Class333.smethod_959(), (float)class189_0.BoB / 1048576f) : Class333.smethod_325());
		string text4;
		if (bool_6)
		{
			text4 = Class333.smethod_325();
		}
		else
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(class189_0.Boc);
			if (class189_0.Boc < 60000)
			{
				text4 = timeSpan.Seconds + Class333.smethod_960();
			}
			else
			{
				text4 = ((class189_0.Boc >= 3600000) ? (timeSpan.Hours + Class333.smethod_962() + ((timeSpan.Minutes < 10) ? Class333.smethod_184() : string.Empty) + timeSpan.Minutes + Class333.smethod_961() + ((timeSpan.Seconds < 10) ? Class333.smethod_184() : string.Empty) + timeSpan.Seconds + Class333.smethod_960()) : (timeSpan.Minutes + Class333.smethod_961() + ((timeSpan.Seconds < 10) ? Class333.smethod_184() : string.Empty) + timeSpan.Seconds + Class333.smethod_960()));
			}
			if (class189_0.Boc < class189_0.BoC - 1000)
			{
				text4 += Class333.smethod_963();
			}
		}
		string text5 = Class333.smethod_325();
		if (class189_0.BoD != 0)
		{
			text5 = Class233.smethod_29(class189_0.BoD, 1);
		}
		string text6 = Class333.smethod_325();
		if (class189_0.Bod != 0)
		{
			text6 = Class233.smethod_29(class189_0.Bod, 3);
		}
		bool flag;
		string text7;
		if (flag = class189_0.BOz.Count > 1)
		{
			text7 = Class333.smethod_964();
		}
		else if (bool_7)
		{
			text7 = Class333.smethod_965();
		}
		else if (bool_6)
		{
			text7 = Class333.smethod_966();
		}
		else if (class189_0.Boa)
		{
			text7 = Class333.smethod_967();
		}
		else
		{
			text7 = ((!bool_1) ? Class333.smethod_325() : Class333.smethod_917());
		}
		string boE = class189_0.BoE;
		string text8 = Class333.smethod_325();
		if (!bool_7)
		{
			if (flag)
			{
				int val = int.MaxValue;
				int val2 = int.MinValue;
				foreach (int item in class189_0.BOz)
				{
					val = Math.Min(val, item);
					val2 = Math.Max(val2, item);
				}
				text8 = val + Class333.smethod_186() + val2;
			}
			else if (class189_0.BOz.Count == 1)
			{
				text8 = class189_0.BOz[0].ToString();
			}
		}
		string text9 = (File.Exists(smethod_3()) ? Class333.smethod_969() : Class333.smethod_968());
		if (bool_5)
		{
			return new string[10]
			{
				text8,
				text3,
				text4,
				text5,
				text6,
				text7,
				Class333.smethod_970(),
				Class333.smethod_971(),
				text9,
				boE
			};
		}
		return new string[12]
		{
			text8,
			text,
			text2,
			text3,
			text4,
			text5,
			text6,
			text7,
			Class333.smethod_970(),
			Class333.smethod_971(),
			text9,
			boE
		};
	}

	private void class85_1_DrawItem(object sender, DrawListViewItemEventArgs e)
	{
		if (class85_1.SelectedItems.Contains(e.Item))
		{
			e.Graphics.FillRectangle(Brushes.DodgerBlue, e.Bounds);
			e.DrawFocusRectangle();
			return;
		}
		using SolidBrush brush = new SolidBrush(class85_1.BackColor);
		e.Graphics.FillRectangle(brush, e.Bounds);
	}

	private void class85_1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
	{
		TextFormatFlags textFormatFlags = TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter;
		switch (e.Header.TextAlign)
		{
		case HorizontalAlignment.Left:
			textFormatFlags |= TextFormatFlags.Default;
			break;
		case HorizontalAlignment.Right:
			textFormatFlags |= TextFormatFlags.Right;
			break;
		case HorizontalAlignment.Center:
			textFormatFlags |= TextFormatFlags.HorizontalCenter;
			break;
		}
		if (e.ColumnIndex >= int_23)
		{
			Class189 @class = (Class189)e.Item.Tag;
			bool flag = @class.BoA == 0;
			if ((@class.BOz.Count != 1 && e.ColumnIndex == int_23) || (flag && e.ColumnIndex == int_23))
			{
				return;
			}
			bool flag2 = @class.Boa | flag;
			bool flag3 = false;
			if (e.ColumnIndex == int_23)
			{
				flag3 = bool_1 || @class.Boa;
			}
			else if (e.ColumnIndex == int_26)
			{
				flag3 = !flag2;
			}
			if (e.ColumnIndex == int_26)
			{
				using (Font font = new Font(class85_1.Font.FontFamily, class85_1.Font.Size, FontStyle.Underline))
				{
					if (flag3)
					{
						TextRenderer.DrawText(e.Graphics, e.SubItem.Text, font, e.Bounds, Color.Gray, textFormatFlags);
					}
					else if (point_0.X != 0 && point_0.Y != 0 && point_0.X > e.SubItem.Bounds.Left && point_0.X < e.SubItem.Bounds.Right && point_0.Y > e.SubItem.Bounds.Top && point_0.Y < e.SubItem.Bounds.Bottom)
					{
						TextRenderer.DrawText(e.Graphics, e.SubItem.Text, font, e.Bounds, Color.LightBlue, textFormatFlags);
					}
					else
					{
						TextRenderer.DrawText(e.Graphics, e.SubItem.Text, font, e.Bounds, class85_1.ForeColor, textFormatFlags);
					}
					return;
				}
			}
			Image image = null;
			if (e.ColumnIndex == int_23)
			{
				image = Class283.smethod_0();
			}
			else if (e.ColumnIndex == int_24)
			{
				image = Class283.smethod_2();
			}
			else if (e.ColumnIndex == int_25)
			{
				image = Class283.smethod_1();
			}
			if (image == null)
			{
				return;
			}
			int num = (e.Bounds.Width - image.Width) / 2;
			int num2 = (e.Bounds.Height - image.Height) / 2;
			if (!flag3)
			{
				if (point_0.X != 0 && point_0.Y != 0 && point_0.X > e.SubItem.Bounds.Left && point_0.X < e.SubItem.Bounds.Right && point_0.Y > e.SubItem.Bounds.Top && point_0.Y < e.SubItem.Bounds.Bottom)
				{
					e.Graphics.DrawRectangle(Pens.LightBlue, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
				}
				using Image image2 = Class25.smethod_0(image, 1f, 0f, 0f, 0f, 0f, (int)class85_1.ForeColor.R, (int)class85_1.ForeColor.G, (int)class85_1.ForeColor.B);
				e.Graphics.DrawImageUnscaled(image2, e.Bounds.X + num, e.Bounds.Y + num2);
			}
		}
		else
		{
			TextRenderer.DrawText(e.Graphics, e.SubItem.Text, class85_1.Font, e.Bounds, class85_1.ForeColor, textFormatFlags);
		}
	}

	private void class85_1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
	{
		e.DrawBackground();
		TextFormatFlags textFormatFlags = TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter;
		switch (e.Header.TextAlign)
		{
		case HorizontalAlignment.Left:
			textFormatFlags |= TextFormatFlags.Default;
			break;
		case HorizontalAlignment.Right:
			textFormatFlags |= TextFormatFlags.Right;
			break;
		case HorizontalAlignment.Center:
			textFormatFlags |= TextFormatFlags.HorizontalCenter;
			break;
		}
		TextRenderer.DrawText(e.Graphics, e.Header.Text, class85_1.Font, e.Bounds, Color.Black, textFormatFlags);
	}

	private static int smethod_16(byte[] byte_0)
	{
		int num = 0;
		int result = 0;
		bool flag = false;
		do
		{
			byte b = byte_0[num];
			num++;
			if (b != byte.MaxValue)
			{
				byte b2 = byte_0[num];
				byte b3 = byte_0[num + 1];
				byte b4 = byte_0[num + 2];
				byte b5 = byte_0[num + 3];
				num += 4;
				uint num2 = (uint)((b2 << 24) | ((b3 << 16) & 0xFF0000) | ((b4 << 8) & 0xFF00) | (b5 & 0xFF));
				if (num2 != uint.MaxValue && num2 != 0 && (num2 <= 131072 || b == 2 || (b & 0xF) == 9 || b == 13))
				{
					if ((b & 0xF) != 7 && b != 12)
					{
						num += (int)(num2 - 5);
					}
					else
					{
						if (b == 12)
						{
							num += 2;
						}
						byte b6 = byte_0[num];
						byte b7 = byte_0[num + 1];
						byte b8 = byte_0[num + 2];
						byte b9 = byte_0[num + 3];
						result = (b6 << 24) | ((b7 << 16) & 0xFF0000) | ((b8 << 8) & 0xFF00) | (b9 & 0xFF);
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (num >= byte_0.Length)
			{
				flag = true;
			}
		}
		while (!flag);
		return result;
	}

	private static int smethod_17(byte[] byte_0)
	{
		int num = 0;
		int result = 0;
		bool flag = false;
		do
		{
			byte b = byte_0[num];
			num++;
			if (b != byte.MaxValue)
			{
				byte b2 = byte_0[num];
				byte b3 = byte_0[num + 1];
				byte b4 = byte_0[num + 2];
				byte b5 = byte_0[num + 3];
				num += 4;
				uint num2 = (uint)((b2 << 24) | ((b3 << 16) & 0xFF0000) | ((b4 << 8) & 0xFF00) | (b5 & 0xFF));
				if (num2 != uint.MaxValue && num2 != 0 && (num2 <= 131072 || b == 2 || (b & 0xF) == 9 || b == 13))
				{
					if ((b & 0xF) != 7 && b != 12)
					{
						num += (int)(num2 - 5);
					}
					else
					{
						if (b == 12)
						{
							num += 2;
						}
						byte b6 = byte_0[num];
						byte b7 = byte_0[num + 1];
						byte b8 = byte_0[num + 2];
						byte b9 = byte_0[num + 3];
						num += 4;
						result = (b6 << 24) | ((b7 << 16) & 0xFF0000) | ((b8 << 8) & 0xFF00) | (b9 & 0xFF);
						num = ((b != 12) ? (num + (int)(num2 - 9)) : (num + (int)(num2 - 11)));
					}
				}
				else
				{
					flag = true;
				}
			}
			if (num >= byte_0.Length)
			{
				flag = true;
			}
		}
		while (!flag);
		return result;
	}

	private static bool smethod_18(ref int int_29, int int_30)
	{
		byte[] array = null;
		int num = int_30 - int_2;
		if (num < 0)
		{
			num += int_1;
		}
		bool flag;
		do
		{
			if (!(flag = Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_12, (uint)num, 80u, out var byte_, out var _)))
			{
				if (!Form23.smethod_28(Form23.framework_1.aXc, bool_53: true))
				{
					break;
				}
			}
			else
			{
				array = byte_;
			}
		}
		while (!flag && bool_4);
		if (flag)
		{
			int num2 = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
			int_29 = int_30;
			for (int i = 0; i < num2 + 1; i++)
			{
				int_29 -= int_2;
				if (int_29 < 0)
				{
					int_29 += int_1;
				}
				if (int_29 == int_30)
				{
					break;
				}
			}
			return true;
		}
		return false;
	}

	private static bool smethod_19(int int_29, int int_30, int int_31)
	{
		byte[] array = null;
		int num = int_30 - int_2;
		if (num < 0)
		{
			num += int_1;
		}
		bool flag;
		do
		{
			if (!(flag = Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_12, (uint)num, 80u, out var byte_, out var _)))
			{
				if (!Form23.smethod_28(Form23.framework_1.aXc, bool_53: true))
				{
					break;
				}
			}
			else
			{
				array = byte_;
			}
		}
		while (!flag && bool_4);
		if (flag)
		{
			int_11 = int_29;
			int_18 = 0;
			int_12 = int_30;
			int_13 = int_30;
			int_14 = int_31;
			int_16 = (array[60] << 24) | ((array[61] << 16) & 0xFF0000) | ((array[62] << 8) & 0xFF00) | (array[63] & 0xFF);
			int_15 = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
			return true;
		}
		return false;
	}

	private static bool smethod_20(int int_29)
	{
		int_14 = int_13;
		int_12 = int_14;
		for (int i = 0; i < int_15 + 1; i++)
		{
			int_12 -= int_2;
			if (int_12 < 0)
			{
				int_12 += int_1;
			}
			if (int_12 == int_29)
			{
				break;
			}
		}
		int_17 = int_13;
		int_13 = int_12;
		int_18 = 0;
		byte[] array = null;
		int num = int_13 - int_2;
		if (num < 0)
		{
			num += int_1;
		}
		bool flag;
		do
		{
			if (!(flag = Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_12, (uint)num, 80u, out var byte_, out var _)))
			{
				if (!Form23.smethod_28(Form23.framework_1.aXc, bool_53: true))
				{
					break;
				}
			}
			else
			{
				array = byte_;
			}
		}
		while (!flag && bool_4);
		if (flag)
		{
			int_16 = (array[60] << 24) | ((array[61] << 16) & 0xFF0000) | ((array[62] << 8) & 0xFF00) | (array[63] & 0xFF);
			int_15 = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
			return true;
		}
		return false;
	}

	internal static void smethod_21()
	{
		if (int_3 != -1)
		{
			if (class85_0 != null && class85_0.IsHandleCreated)
			{
				class85_0.Invoke(() =>
				{
					foreach (ListViewItem item in class85_0.Items)
					{
						if (item.SubItems.Count > int_22)
						{
							Class189 @class = (Class189)item.Tag;
							if (@class.BoA != 0 && !@class.Boa)
							{
								item.SubItems[int_22].Text = Class333.smethod_325();
							}
						}
					}
				});
			}
			int_3 = -1;
		}
		int_4 = -1;
		int_5 = -1;
		int_6 = -1;
		int_10 = 0;
		bool_0 = false;
	}

	private static bool smethod_22(int int_29, int int_30, int int_31)
	{
		byte[] array = null;
		int num = int_30 - int_2;
		if (num < 0)
		{
			num += int_1;
		}
		bool flag;
		do
		{
			if (!(flag = Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_12, (uint)num, 80u, out var byte_, out var _)))
			{
				if (!Form23.smethod_28(Form23.framework_1.aXc, bool_53: true))
				{
					break;
				}
			}
			else
			{
				array = byte_;
			}
		}
		while (!flag && bool_4);
		if (flag)
		{
			int_3 = int_29;
			int_10 = 0;
			bool_0 = false;
			int_4 = int_30;
			int_5 = int_30;
			int_6 = int_31;
			int_8 = (array[60] << 24) | ((array[61] << 16) & 0xFF0000) | ((array[62] << 8) & 0xFF00) | (array[63] & 0xFF);
			int_7 = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
			return true;
		}
		return false;
	}

	private static bool smethod_23(string string_3)
	{
		string aXD = Form23.framework_1.aXD;
		if (aXD == string.Empty)
		{
			smethod_21();
			return false;
		}
		if (!bool_1 && !smethod_4(int_3))
		{
			return true;
		}
		string path = aXD + Class333.smethod_946();
		if (File.Exists(path))
		{
			try
			{
				using StreamReader streamReader = File.OpenText(path);
				string s;
				while ((s = streamReader.ReadLine()) != null)
				{
					if (int.Parse(s) == int_3)
					{
						return true;
					}
				}
			}
			catch
			{
			}
		}
		if (int_10 != 0)
		{
			smethod_21();
			return false;
		}
		try
		{
			string text = Class333.smethod_688() + int_3;
			memoryStream_0 = new MemoryStream();
			zipArchive_0 = new ZipArchive(memoryStream_0, ZipArchiveMode.Create);
			Stream stream = zipArchive_0.CreateEntry(Class333.smethod_972() + int_3 + Class242.smethod_8(Form23.framework_1.awZ, Form23.framework_1.awz, Form23.framework_1.aXA) + Class333.smethod_146()).Open();
			string path2 = Form23.string_2 + Class333.smethod_522() + Form23.string_18 + Class333.smethod_973();
			bool flag = File.Exists(path2);
			if (Form23.framework_1.aXE || !flag)
			{
				if (flag)
				{
					File.Delete(path2);
				}
				new Class297(path2, Form23.framework_1, bool_0: true).method_0();
				Form23.framework_1.aXE = false;
			}
			byte[] array = File.ReadAllBytes(path2);
			foreach (byte value in array)
			{
				stream.WriteByte(value);
			}
			stream.Close();
			zipArchiveEntry_0 = zipArchive_0.CreateEntry(text + Class333.smethod_489());
			stream_0 = zipArchiveEntry_0.Open();
			if (class85_0 != null && class85_0.IsHandleCreated)
			{
				class85_0.Invoke(() =>
				{
					foreach (ListViewItem item in class85_0.Items)
					{
						Class189 @class = (Class189)item.Tag;
						if (@class.BOz.Count == 1 && @class.BOz[0] == int_3)
						{
							if (item.SubItems.Count > int_22)
							{
								item.SubItems[int_22].Text = Class333.BDj();
								@class.Boa = false;
								item.Tag = @class;
							}
							break;
						}
					}
					if (class85_0 != null)
					{
						class85_0.Invalidate();
					}
				});
			}
			return true;
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_974() + ex.Message);
			if (!Form23.bool_18)
			{
				smethod_25();
			}
			smethod_21();
			return false;
		}
	}

	private static void smethod_24(string string_3)
	{
		if (!Form23.bool_18)
		{
			smethod_25();
		}
		Class188 class188_ = smethod_6(int_3);
		string aXD = Form23.framework_1.aXD;
		if (aXD == string.Empty)
		{
			return;
		}
		string text = Class333.smethod_688() + int_3;
		string text2 = aXD + Class333.smethod_975() + text + Class333.smethod_976();
		if (!File.Exists(text2))
		{
			return;
		}
		try
		{
			string text3 = ((smethod_15() || dateTime_0 == dateTime_1) ? Class23.smethod_10(bool_1: false) : Class23.smethod_8(dateTime_0, bool_1: false));
			text = text3 + Class333.smethod_100() + text;
			if (bool_0)
			{
				text += Class333.smethod_977();
				string text4 = aXD + Class333.smethod_975() + text + Class333.smethod_488();
				if (File.Exists(text4))
				{
					File.Delete(text4);
				}
				File.Move(text2, text4);
				bool_0 = false;
			}
			else
			{
				string text5 = aXD + Class333.smethod_975() + text + Class333.smethod_488();
				if (File.Exists(text5))
				{
					File.Delete(text5);
				}
				File.Move(text2, text5);
			}
			File.AppendAllLines(aXD + Class333.smethod_946(), new List<string> { int_3.ToString() });
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_978() + ex.Message);
		}
		smethod_35(aXD + Class333.smethod_975(), text, class188_, int_3);
	}

	internal static void smethod_25()
	{
		if (stream_0 != null)
		{
			stream_0.Close();
			stream_0 = null;
		}
		if (zipArchive_0 != null)
		{
			zipArchive_0.Dispose();
			zipArchive_0 = null;
		}
		if (memoryStream_0 != null)
		{
			using (FileStream fileStream = new FileStream(string.Concat(Form23.framework_1.aXD, str2: Class333.smethod_688() + int_3, str1: Class333.smethod_975(), str3: Class333.smethod_976()), FileMode.Create))
			{
				Class35.smethod_0(memoryStream_0.ToArray(), Class19.smethod_3(), fileStream, Class35.byte_1);
			}
			memoryStream_0.Close();
			memoryStream_0 = null;
		}
	}

	internal static bool smethod_26()
	{
		return memoryStream_0 == null;
	}

	[SpecialName]
	internal static int smethod_27()
	{
		return int_3;
	}

	[SpecialName]
	internal static int smethod_28()
	{
		return int_5;
	}

	[SpecialName]
	internal static int smethod_29()
	{
		return int_6;
	}

	[SpecialName]
	internal static int smethod_30()
	{
		return int_10;
	}

	private static bool smethod_31(int int_29)
	{
		int_6 = int_5;
		int_4 = int_6;
		for (int i = 0; i < int_7 + 1; i++)
		{
			int_4 -= int_2;
			if (int_4 < 0)
			{
				int_4 += int_1;
			}
			if (int_4 == int_29)
			{
				break;
			}
		}
		int_9 = int_5;
		int_5 = int_4;
		int_10 = 0;
		bool_0 = false;
		byte[] array = null;
		int num = int_5 - int_2;
		if (num < 0)
		{
			num += int_1;
		}
		bool flag;
		do
		{
			if (!(flag = Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_12, (uint)num, 80u, out var byte_, out var _)))
			{
				if (!Form23.smethod_28(Form23.framework_1.aXc, bool_53: true))
				{
					break;
				}
			}
			else
			{
				array = byte_;
			}
		}
		while (!flag && bool_4);
		if (flag)
		{
			int_8 = (array[60] << 24) | ((array[61] << 16) & 0xFF0000) | ((array[62] << 8) & 0xFF00) | (array[63] & 0xFF);
			int_7 = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
		}
		return flag;
	}

	private static void smethod_32()
	{
		if (class85_0 == null || !class85_0.IsHandleCreated)
		{
			return;
		}
		int num = int_6 - int_5;
		if (num <= 0)
		{
			num += int_1;
		}
		int BPb = (int)(int_10 * 100L / num);
		if (BPb == int_28)
		{
			return;
		}
		class85_0.Invoke(() =>
		{
			foreach (ListViewItem item in class85_0.Items)
			{
				Class189 @class = (Class189)item.Tag;
				if (@class.BOz.Count == 1 && @class.BOz[0] == int_3)
				{
					if (item.SubItems.Count > int_22)
					{
						item.SubItems[int_22].Text = Class333.BDl() + BPb + Class333.smethod_681();
					}
					break;
				}
			}
			if (class85_0 != null)
			{
				class85_0.Invalidate();
			}
		});
		int_28 = BPb;
	}

	internal static void smethod_33(string string_3)
	{
		if ((Form23.int_0 & 0x100) == 0 && (Form23.int_0 & 0x200) == 0 && !Form23.bool_18 && !Form23.bool_23 && (list_0.Count != 0 || bool_1))
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			if (list_0.Count > 0)
			{
				Class1.enum6_0 = Enum6.const_3;
			}
			else
			{
				Class1.enum6_0 = enum6_0;
			}
			uint num = ((list_0.Count > 0) ? 80u : (Class1.enum6_0 switch
			{
				Enum6.const_0 => 2u, 
				Enum6.const_1 => 5u, 
				Enum6.const_2 => 10u, 
				Enum6.const_3 => 13u, 
				_ => 10u, 
			}));
			do
			{
				try
				{
					if (Form23.framework_1.method_31(9500).method_256() != 0)
					{
						if (!Form23.bool_18)
						{
							smethod_25();
						}
						smethod_21();
						return;
					}
					string text = Form23.framework_1.aXD;
					if (string.IsNullOrEmpty(text))
					{
						text = Form23.smethod_99(string_3, Form23.framework_1.aXc);
						try
						{
							if (string.IsNullOrEmpty(text))
							{
								text = Form23.smethod_100(string_3, new List<string> { Form23.framework_1.aXc });
							}
							Form23.framework_1.aXD = text;
						}
						catch
						{
							smethod_21();
							return;
						}
					}
					Directory.CreateDirectory(text + Class333.smethod_952());
					int_1 = Form23.framework_1.method_31(9497).method_256();
					Form10.int_2 = Form23.framework_1.method_31(9510).method_256();
					int num2 = Form23.framework_1.method_31(9501).method_256();
					int num3 = Form23.framework_1.method_31(9508).method_256();
					int int_ = Form23.framework_1.method_31(9509).method_256();
					if (num2 < 0 || int_1 == 0 || ((int_4 == -1 || int_3 == -1 || int_5 == -1 || int_6 == -1) && (!smethod_18(ref int_, num3) || !smethod_22(num2, int_, num3))) || (memoryStream_0 == null && !smethod_23(string_3)))
					{
						return;
					}
					int num4;
					if (int_4 == int_5)
					{
						num4 = Math.Min(Form10.int_2, (int)Class1.smethod_73(Form23.framework_1.aXc, Enum10.const_12));
					}
					else if (memoryStream_0 != null)
					{
						num4 = (int)Class1.smethod_73(Form23.framework_1.aXc, Enum10.const_12);
					}
					else
					{
						num4 = ((int_6 <= int_5) ? (int_1 - int_4) : (int_6 - int_5));
					}
					if (int_4 + num4 > int_1)
					{
						num4 = int_1 - int_4;
					}
					if ((int_6 > int_5 || int_4 < int_6) && int_4 + num4 > int_6)
					{
						num4 = int_6 - int_4;
					}
					byte[] array = null;
					bool flag = false;
					if (memoryStream_0 != null)
					{
						array = null;
						do
						{
							if (!(flag = Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_12, (uint)int_4, (uint)num4, out var byte_, out var _)))
							{
								if (!Form23.smethod_28(Form23.framework_1.aXc, bool_53: true))
								{
									break;
								}
							}
							else
							{
								array = byte_;
							}
						}
						while (!flag && bool_4);
					}
					if (!flag && memoryStream_0 != null)
					{
						return;
					}
					if (memoryStream_0 == null)
					{
						int_10 += num4;
					}
					else
					{
						if (int_4 == int_5)
						{
							if (array[3] != 1)
							{
								bool_0 = true;
								stream_0.Write(array, 0, num4);
								int_10 += num4;
							}
							else
							{
								int num5 = 3 + ((array[4] << 24) | ((array[5] << 16) & 0xFF0000) | ((array[6] << 8) & 0xFF00) | (array[7] & 0xFF));
								int num6 = ((array[56] << 8) & 0xFF00) | (array[57] & 0xFF);
								int num7 = array[58];
								int num8 = array[59];
								int num9 = array[52];
								int num10 = array[53];
								int num11 = array[54];
								if (num6 >= 1 && num6 <= 9999 && num7 >= 1 && num7 <= 12 && num8 >= 1 && num8 <= 31 && num9 >= 0 && num9 <= 23 && num10 >= 0 && num10 <= 59 && num11 >= 0 && num11 <= 59)
								{
									dateTime_0 = new DateTime(num6, num7, num8, num9, num10, num11);
								}
								else
								{
									dateTime_0 = dateTime_1;
								}
								List<List<ushort>> list = smethod_34(array, num5, out var int_2, out var bool_);
								if (bool_)
								{
									bool_0 = true;
								}
								int num12 = int_2 - num5;
								if (!bool_0)
								{
									array[68] = (byte)Form23.framework_1.awZ;
									stream_0.Write(array, 0, num5);
									int_10 += num5;
									stream_0.Write(array, num5, num12);
									int_10 += num12;
									Class284.smethod_0(stream_0, list);
									stream_0.Write(array, num5 + num12, num4 - (num5 + num12));
									int_10 += num4 - (num5 + num12);
								}
								else
								{
									stream_0.Write(array, 0, num4);
									int_10 += num4;
								}
							}
						}
						else
						{
							stream_0.Write(array, 0, num4);
							int_10 += num4;
						}
						smethod_32();
					}
					int_4 += num4;
					if (int_4 == int_1)
					{
						int_4 = 0;
					}
					bool flag3 = int_3 != num2;
					if (int_4 == num3 || (flag3 && int_4 == int_9))
					{
						if (memoryStream_0 != null)
						{
							smethod_24(string_3);
						}
						int_3--;
						if (int_3 < 0 || int_10 >= int_1 || int_7 == -1 || int_8 == -1 || int_8 >= int_3 + 1)
						{
							int_3 = -1;
							return;
						}
						if (!smethod_31(num3))
						{
							return;
						}
					}
					continue;
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.smethod_979() + ex.Message);
					smethod_21();
				}
			}
			while (stopwatch.ElapsedMilliseconds < num);
			stopwatch.Stop();
		}
		else
		{
			if (!Form23.bool_18)
			{
				smethod_25();
			}
			smethod_21();
		}
	}

	internal static List<List<ushort>> smethod_34(byte[] byte_0, int int_29, out int int_30, out bool bool_5)
	{
		List<List<ushort>> list = new List<List<ushort>>();
		bool_5 = false;
		int num = int_29;
		do
		{
			byte b = byte_0[num];
			if (b == byte.MaxValue)
			{
				num++;
				continue;
			}
			if ((b & 0xF) == 6 || b == 11)
			{
				int num2 = 0;
				int num3 = 0;
				if ((b & 0xF) == 6)
				{
					num2 = 5;
					num3 = (b >> 4) & 0xF;
				}
				int num4 = (byte_0[num + 1] << 24) | ((byte_0[num + 2] << 16) & 0xFF0000) | ((byte_0[num + 3] << 8) & 0xFF00) | (byte_0[num + 4] & 0xFF);
				if (b == 11)
				{
					num2 = 7;
					num3 = ((byte_0[num + 5] << 8) & 0xFF00) | (byte_0[num + 6] & 0xFF);
				}
				List<ushort> list2 = new List<ushort>();
				for (int i = num2; i < num4; i++)
				{
					if ((i & 1) == 1)
					{
						list2.Add((ushort)((byte_0[num + i] << 8) & 0xFF00));
					}
					else
					{
						list2[list2.Count - 1] |= (ushort)(byte_0[num + i] & 0xFF);
					}
				}
				while (list.Count < num3)
				{
					list.Add(new List<ushort>());
				}
				list.Add(list2);
				num += num4;
				continue;
			}
			if (list.Count == 0)
			{
				bool_5 = true;
			}
			break;
		}
		while (num < byte_0.Length);
		int_30 = num;
		return list;
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		Close();
		Form23.form23_0.method_54(Enum55.const_1, bool_53: false, bool_54: false, bool_55: false);
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		Close();
		Form23.form23_0.method_54(Enum55.const_2, bool_53: false, bool_54: false, bool_55: false);
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		Close();
		Form23.form23_0.method_54(Enum55.const_0, bool_53: false, bool_54: false, bool_55: false);
	}

	private void themedButton_3_Click(object sender, EventArgs e)
	{
		if (!Form23.form23_0.method_68(this, Enum55.const_0, null, null))
		{
			return;
		}
		try
		{
			class85_1.Invoke(() =>
			{
				for (int num = class85_1.Items.Count - 1; num >= 0; num--)
				{
					Class189 @class = (Class189)class85_1.Items[num].Tag;
					bool flag = @class.BoA != 0;
					if (((@class.BOz.Count == 1) & flag) && !@class.Boa)
					{
						smethod_6(@class.BOz[0]);
						class85_1.Items[num].Tag = null;
						class85_1.Items.RemoveAt(num);
						if (dictionary_0.ContainsKey(@class.BOz[0]))
						{
							dictionary_0.Remove(@class.BOz[0]);
						}
						if (dictionary_4.ContainsKey(@class.BOz[0]))
						{
							dictionary_4.Remove(@class.BOz[0]);
						}
						if (dictionary_5.ContainsKey(@class.BOz[0]))
						{
							dictionary_5.Remove(@class.BOz[0]);
						}
						if (dictionary_6.ContainsKey(@class.BOz[0]))
						{
							dictionary_6.Remove(@class.BOz[0]);
						}
						if (dictionary_7.ContainsKey(@class.BOz[0]))
						{
							dictionary_7.Remove(@class.BOz[0]);
						}
					}
				}
				class85_1.method_1();
				class85_1.Invalidate();
			});
			method_2();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_980() + ex.Message);
			Close();
		}
	}

	internal static void smethod_35(string string_3, string string_4, Class188 class188_0, int int_29)
	{
		string text = string_3 + string_4 + Class333.smethod_488();
		if (!File.Exists(text))
		{
			return;
		}
		if (class85_0 != null && class85_0.IsHandleCreated)
		{
			class85_0.Invoke(() =>
			{
				foreach (ListViewItem item in class85_0.Items)
				{
					Class189 @class = (Class189)item.Tag;
					if (@class.BOz.Count == 1 && @class.BOz[0] == int_29)
					{
						if (item.SubItems.Count > int_22 && item.SubItems.Count > int_26)
						{
							item.SubItems[int_22].Text = Class333.BDM();
							item.SubItems[int_26].Text = string_4;
							@class.Boa = true;
							@class.BoE = string_4;
							item.Tag = @class;
						}
						dictionary_1[string_4] = @class;
						dictionary_2[string_4] = @class.BOz;
						dictionary_3[string_4] = @class.BoA;
						break;
					}
				}
				if (class85_0 != null)
				{
					class85_0.Invalidate();
				}
			});
		}
		smethod_36(string_3, string_4, class188_0, int_29);
		if (form10_0 != null)
		{
			form10_0.method_22(text);
		}
	}

	internal static void smethod_36(string string_3, string string_4, Class188 class188_0, int int_29)
	{
		string boj = string_3 + string_4 + Class333.smethod_488();
		Struct22 @struct = new Struct22
		{
			Boi = string_3,
			BoJ = string_4,
			Boj = boj,
			BoK = class188_0,
			Bok = int_29
		};
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.DoWork += smethod_37;
		backgroundWorker.RunWorkerCompleted += smethod_38;
		backgroundWorker.RunWorkerAsync(@struct);
	}

	internal static void smethod_37(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		if (backgroundWorker.WorkerReportsProgress)
		{
			backgroundWorker.ReportProgress(0);
		}
		Struct22 @struct = (Struct22)e.Argument;
		string boi = @struct.Boi;
		string boJ = @struct.BoJ;
		string boj = @struct.Boj;
		string text = boi + boJ + Class333.smethod_919();
		ZipArchive zipArchive = null;
		ZipArchiveEntry zipArchiveEntry = null;
		Stream stream = null;
		MemoryStream memoryStream = null;
		StreamWriter streamWriter = null;
		List<uint> list = new List<uint> { 0u };
		try
		{
			streamWriter = new StreamWriter(File.Open(text, FileMode.Create, FileAccess.Write));
			streamWriter.WriteLine(Class333.smethod_981());
			streamWriter.WriteLine(Class333.smethod_982());
			streamWriter.WriteLine(string.Format(Class333.smethod_983(), Form23.string_1));
			streamWriter.WriteLine(string.Format(Class333.smethod_984(), default(ReadOnlySpan<object>)));
			streamWriter.WriteLine(string.Format(Class333.smethod_985(), DateTime.Now));
			if (backgroundWorker.WorkerReportsProgress)
			{
				backgroundWorker.ReportProgress(5);
			}
			byte b = 0;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			memoryStream = Class35.smethod_7(boj, Class19.smethod_3());
			if (memoryStream.CanRead)
			{
				zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Read);
				foreach (ZipArchiveEntry entry in zipArchive.Entries)
				{
					if (entry.Name.EndsWith(Class333.smethod_489()))
					{
						zipArchiveEntry = entry;
						break;
					}
				}
				if (zipArchiveEntry != null)
				{
					stream = zipArchiveEntry.Open();
				}
				if (backgroundWorker.WorkerReportsProgress)
				{
					backgroundWorker.ReportProgress(10);
				}
				List<List<ushort>> list2 = new List<List<ushort>>();
				byte b2 = 0;
				bool flag = false;
				do
				{
					int num8 = stream.ReadByte();
					switch (num8)
					{
					default:
						if ((num8 & 0xF) != 7 && num8 != 12 && (num8 & 0xF) != 9 && num8 != 13 && num8 != 10)
						{
							byte[] array = new byte[4];
							if (!Class23.smethod_14(stream, array, 0, 4))
							{
								break;
							}
							uint num9 = (uint)((array[0] << 24) | ((array[1] << 16) & 0xFF0000) | ((array[2] << 8) & 0xFF00) | (array[3] & 0xFF));
							if (num9 == uint.MaxValue || num9 == 0 || (num9 > 131072 && num8 != 2 && (num8 & 0xF) != 9 && num8 != 13))
							{
								break;
							}
							int num10 = 0;
							if ((num8 & 0xF) == 6)
							{
								num10 = (num8 >> 4) & 0xF;
							}
							List<ushort> list3 = null;
							if ((num8 & 0xF) == 6 || num8 == 11)
							{
								list3 = new List<ushort>();
							}
							byte[] array2 = new byte[num9 - 5];
							if (!Class23.smethod_14(stream, array2, 0, (int)(num9 - 5)))
							{
								flag = true;
							}
							else
							{
								for (int i = 5; i < num9; i++)
								{
									byte b3 = array2[i - 5];
									if ((num8 & 0xF) == 1)
									{
										if ((i == 5 && b3 != 72) || (i == 6 && b3 != 65) || (i == 7 && b3 != 76) || (i == 8 && b3 != 84) || (i == 9 && b3 != 69) || (i == 10 && b3 != 67) || (i == 11 && b3 != 72) || (i == 12 && b3 != 48 && b3 != 49))
										{
											throw new Exception();
										}
										if (i == 53)
										{
											num = (b3 << 8) & 0xFF00;
										}
										if (i == 54)
										{
											num |= b3 & 0xFF;
										}
										if (i == 55)
										{
											num2 = b3;
										}
										if (i == 56)
										{
											num3 = b3;
										}
										if (i == 49)
										{
											num4 = b3;
										}
										if (i == 50)
										{
											num5 = b3;
										}
										if (i == 51)
										{
											num6 = b3;
										}
										switch (i)
										{
										case 57:
											list[0] = (uint)(b3 << 24);
											break;
										case 58:
											list[0] |= (uint)((b3 << 16) & 0xFF0000);
											break;
										case 59:
											list[0] |= (uint)((b3 << 8) & 0xFF00);
											break;
										case 60:
											list[0] |= (uint)(b3 & 0xFF);
											break;
										}
										if (i == 65)
										{
											b = b3;
										}
									}
									else
									{
										if ((num8 & 0xF) != 6 && num8 != 11)
										{
											continue;
										}
										if (num8 == 11)
										{
											switch (i)
											{
											case 5:
												num10 |= (b3 << 8) & 0xFF00;
												break;
											case 6:
												num10 |= b3 & 0xFF;
												break;
											}
										}
										if ((num8 & 0xF) == 6 || (num8 == 11 && i >= 7))
										{
											if ((i & 1) == 1)
											{
												list3.Add((ushort)((b3 << 8) & 0xFF00));
											}
											else
											{
												list3[list3.Count - 1] |= (ushort)(b3 & 0xFF);
											}
										}
									}
								}
							}
							if ((num8 & 0xF) == 6 || num8 == 11)
							{
								while (list2.Count < num10)
								{
									list2.Add(new List<ushort>());
								}
								list2.Add(list3);
							}
							continue;
						}
						b2 = (byte)num8;
						break;
					case 255:
						continue;
					case -1:
						break;
					}
					break;
				}
				while (!flag);
				if (backgroundWorker.WorkerReportsProgress)
				{
					backgroundWorker.ReportProgress(15);
				}
				if (list2.Count == 0)
				{
					throw new Exception();
				}
				for (int j = 0; j < list2.Count; j++)
				{
					foreach (ushort item in list2[j])
					{
						Setting setting = Form23.framework_1.method_31(item);
						if (setting != null)
						{
							streamWriter.WriteLine(string.Format(Class333.smethod_986(), setting.method_22(bool_0: true)));
							streamWriter.WriteLine(string.Format(Class333.smethod_987(), setting.method_64()));
							streamWriter.WriteLine(string.Format(Class333.smethod_988(), ((UnitType)setting.method_231()/*cast due to constrained. prefix*/).ToString()));
							if (setting.method_207())
							{
								int num11 = setting.method_226();
								int num12 = setting.method_227();
								if (num11 != 0 || num12 != 0)
								{
									streamWriter.WriteLine(string.Format(Class333.smethod_989(), num12, num11));
								}
							}
						}
						else
						{
							streamWriter.WriteLine(Class333.smethod_990());
							streamWriter.WriteLine(Class333.smethod_991());
							streamWriter.WriteLine(Class333.smethod_992());
						}
					}
				}
				if (backgroundWorker.WorkerReportsProgress)
				{
					backgroundWorker.ReportProgress(20);
				}
				if (num < 1 || num > 9999 || num2 < 1 || num2 > 12 || num3 < 1 || num3 > 31 || num4 < 0 || num4 > 23 || num5 < 0 || num5 > 59 || num6 < 0 || num6 > 59)
				{
					num = dateTime_1.Year;
					num2 = dateTime_1.Month;
					num3 = dateTime_1.Day;
					num4 = dateTime_1.Hour;
					num5 = dateTime_1.Minute;
					num6 = dateTime_1.Second;
				}
				streamWriter.WriteLine(string.Format(Class333.smethod_993(), b));
				streamWriter.WriteLine(string.Format(Class333.smethod_994(), list[0]));
				DateTime dateTime = new DateTime(num, num2, num3, num4, num5, num6);
				streamWriter.WriteLine(string.Format(Class333.smethod_995(), dateTime));
				bool flag2 = true;
				uint num13 = 0u;
				if (list.Count != 0)
				{
					num13 = list[0];
				}
				uint num14 = uint.MaxValue;
				List<List<string>> list4 = new List<List<string>>();
				for (int k = 0; k < list2.Count; k++)
				{
					List<string> list5 = new List<string>();
					for (int l = 0; l < list2[k].Count; l++)
					{
						list5.Add(Class333.smethod_189());
					}
					list4.Add(list5);
				}
				if (backgroundWorker.WorkerReportsProgress)
				{
					backgroundWorker.ReportProgress(25);
				}
				int num15 = 25;
				uint num16 = 0u;
				flag = false;
				while (true)
				{
					int num8;
					if (b2 == 0)
					{
						num8 = stream.ReadByte();
					}
					else
					{
						num8 = b2;
						b2 = 0;
					}
					switch (num8)
					{
					default:
					{
						byte[] array3 = new byte[4];
						if (!Class23.smethod_14(stream, array3, 0, 4))
						{
							goto end_IL_0d81;
						}
						uint num17 = (uint)((array3[0] << 24) | ((array3[1] << 16) & 0xFF0000) | ((array3[2] << 8) & 0xFF00) | (array3[3] & 0xFF));
						if (num17 == uint.MaxValue || num17 == 0 || (num17 > 131072 && num8 != 2 && (num8 & 0xF) != 9 && num8 != 13))
						{
							goto end_IL_0d81;
						}
						if ((num8 & 0xF) != 7 && num8 != 12)
						{
							uint num18 = 0u;
							int num19 = 0;
							int num20 = 0;
							int num21 = 0;
							int num22 = 0;
							int num23 = 0;
							int num24 = 0;
							byte[] array4 = new byte[num17 - 5];
							if (!Class23.smethod_14(stream, array4, 0, (int)(num17 - 5)))
							{
								flag = true;
							}
							else
							{
								for (int m = 5; m < num17; m++)
								{
									if (num8 == 1)
									{
										byte b4 = array4[m - 5];
										if (m == 53)
										{
											num19 = (b4 << 8) & 0xFF00;
										}
										if (m == 54)
										{
											num19 |= b4 & 0xFF;
										}
										if (m == 55)
										{
											num20 = b4;
										}
										if (m == 56)
										{
											num21 = b4;
										}
										if (m == 49)
										{
											num22 = b4;
										}
										if (m == 50)
										{
											num23 = b4;
										}
										if (m == 51)
										{
											num24 = b4;
										}
										switch (m)
										{
										case 57:
											num18 = (uint)(b4 << 24);
											break;
										case 58:
											num18 |= (uint)((b4 << 16) & 0xFF0000);
											break;
										case 59:
											num18 |= (uint)((b4 << 8) & 0xFF00);
											break;
										case 60:
											num18 |= (uint)(b4 & 0xFF);
											break;
										}
										if (m == 60 && num18 != num13)
										{
											num13 = num18;
											list.Add(num13);
											streamWriter.WriteLine(string.Format(arg0: (num19 < 1 || num19 > 9999 || num20 < 1 || num20 > 12 || num21 < 1 || num21 > 31 || num22 < 0 || num22 > 23 || num23 < 0 || num23 > 59 || num24 < 0 || num24 > 59) ? dateTime_1 : new DateTime(num19, num20, num21, num22, num23, num24), format: Class333.smethod_995()));
											flag2 = true;
										}
									}
								}
							}
						}
						else
						{
							num16 += num17;
							int num25;
							if (num8 == 12)
							{
								byte[] array5 = new byte[2];
								if (!Class23.smethod_14(stream, array5, 0, 2))
								{
									goto end_IL_0d81;
								}
								num25 = ((array5[0] << 8) & 0xFF00) | (array5[1] & 0xFF);
							}
							else
							{
								num25 = (num8 >> 4) & 0xF;
							}
							byte[] array6 = new byte[4];
							if (!Class23.smethod_14(stream, array6, 0, 4))
							{
								goto end_IL_0d81;
							}
							uint num26 = (uint)((array6[0] << 24) | ((array6[1] << 16) & 0xFF0000) | ((array6[2] << 8) & 0xFF00) | (array6[3] & 0xFF));
							if (num14 != uint.MaxValue && num26 != num14)
							{
								if (num26 < num14)
								{
									throw new Exception();
								}
								StringBuilder stringBuilder = new StringBuilder(string.Format(Class333.smethod_996(), dateTime.AddMilliseconds(num14 - num7)));
								for (int n = 0; n < list2.Count; n++)
								{
									for (int num27 = 0; num27 < list2[n].Count; num27++)
									{
										stringBuilder.Append(list4[n][num27]);
										list4[n][num27] = Class333.smethod_189();
									}
								}
								string text2 = stringBuilder.ToString();
								if (flag2)
								{
									while (text2.Contains(Class333.smethod_997()))
									{
										text2 = text2.Replace(Class333.smethod_997(), Class333.smethod_998());
									}
									if (text2.StartsWith(Class333.smethod_189()))
									{
										text2 = Class333.smethod_184() + text2;
									}
									if (text2.EndsWith(Class333.smethod_189()))
									{
										text2 += Class333.smethod_184();
									}
									flag2 = false;
								}
								streamWriter.WriteLine(text2);
							}
							num14 = num26;
							if (num25 >= list2.Count || (((num8 & 0xF) != 7 || num17 != 9 + 4 * list2[num25].Count) && (num8 != 12 || num17 != 11 + 4 * list2[num25].Count)))
							{
								break;
							}
							int num28 = 0;
							uint num29 = ((num8 != 12) ? (num17 - 9) : (num17 - 11));
							byte[] array7 = new byte[num29];
							if (!Class23.smethod_14(stream, array7, 0, (int)num29))
							{
								flag = true;
							}
							else
							{
								for (int num30 = 0; num30 < num29; num30++)
								{
									int num31 = num30 % 4;
									byte b5 = array7[num30];
									switch (num31)
									{
									case 0:
										num28 = b5 << 24;
										break;
									case 1:
										num28 |= (b5 << 16) & 0xFF0000;
										break;
									case 2:
										num28 |= (b5 << 8) & 0xFF00;
										break;
									case 3:
										num28 |= b5 & 0xFF;
										list4[num25][num30 / 4] = Class333.smethod_189() + num28;
										break;
									}
								}
							}
							if (backgroundWorker.WorkerReportsProgress)
							{
								uint num32 = (uint)Math.Min(90L, 25L + (long)num16 * 65L / zipArchiveEntry.Length);
								if (num32 != num15)
								{
									num15 = (int)num32;
									backgroundWorker.ReportProgress((int)num32);
								}
							}
						}
						goto case 255;
					}
					case 255:
						if (num8 != -1 && !flag)
						{
							continue;
						}
						goto end_IL_0d81;
					case -1:
						goto end_IL_0d81;
					}
					flag = true;
					break;
					continue;
					end_IL_0d81:
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_999() + ex.Message);
		}
		finally
		{
			stream?.Close();
			zipArchive?.Dispose();
			memoryStream?.Close();
			e.Result = new Struct23
			{
				BoL = boJ,
				Bol = @struct.BoK,
				BoM = @struct.Bok
			};
		}
		streamWriter?.Close();
		if (list.Count > 1)
		{
			StreamReader streamReader = null;
			streamWriter = null;
			string text3 = boi + boJ + Class333.smethod_1000();
			try
			{
				streamWriter = new StreamWriter(File.Open(text3, FileMode.Create, FileAccess.Write));
				streamReader = File.OpenText(text);
				string text4 = null;
				do
				{
					text4 = streamReader.ReadLine();
					if (text4 == null)
					{
						continue;
					}
					if (text4.StartsWith(Class333.smethod_934()))
					{
						foreach (uint item2 in list)
						{
							streamWriter.WriteLine(string.Format(Class333.smethod_994(), (int)item2));
						}
					}
					else
					{
						streamWriter.WriteLine(text4);
					}
				}
				while (text4 != null);
			}
			catch (Exception ex2)
			{
				Class23.smethod_3(Class333.smethod_999() + ex2.Message);
			}
			finally
			{
				streamReader?.Close();
				streamWriter?.Close();
			}
			try
			{
				File.Delete(text);
				File.Move(text3, text);
			}
			catch (Exception ex3)
			{
				Class23.smethod_3(Class333.smethod_999() + ex3.Message);
			}
		}
		if (backgroundWorker.WorkerReportsProgress)
		{
			backgroundWorker.ReportProgress(100);
			Thread.Sleep(100);
		}
	}

	private static void smethod_38(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct23 @struct = (Struct23)e.Result;
		string BPd = @struct.BoL;
		Class188 BPE = @struct.Bol;
		int BPD = @struct.BoM;
		if (BPD == -1 || class85_0 == null || !class85_0.IsHandleCreated)
		{
			return;
		}
		try
		{
			class85_0.Invoke(() =>
			{
				foreach (ListViewItem item in class85_0.Items)
				{
					Class189 @class = (Class189)item.Tag;
					if (@class.BOz.Count == 1 && @class.BOz[0] == BPD)
					{
						if (item.SubItems.Count > int_22 && item.SubItems.Count > int_26)
						{
							item.SubItems[int_22].Text = Class333.smethod_967();
							item.SubItems[int_26].Text = BPd;
							@class.Boa = true;
							@class.BoE = BPd;
							item.Tag = @class;
							if (BPE != null && BPE.BOZ == BPD)
							{
								if (BPE.BOy == Enum55.const_1)
								{
									form10_0.method_6(@class);
								}
								else if (BPE.BOy == Enum55.const_2)
								{
									form10_0.method_7(@class.BoE);
								}
							}
						}
						break;
					}
				}
				if (class85_0 != null)
				{
					class85_0.Invalidate();
				}
			});
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1001() + ex.Message);
		}
	}

	internal static void smethod_39(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		if (backgroundWorker.WorkerReportsProgress)
		{
			backgroundWorker.ReportProgress(0);
		}
		string text = (string)e.Argument;
		StreamReader streamReader = null;
		string path = text.Substring(0, text.Length - 4) + Class333.smethod_1002();
		StreamWriter streamWriter = null;
		bool flag = false;
		try
		{
			streamWriter = new StreamWriter(File.Open(path, FileMode.Create, FileAccess.Write));
			streamReader = File.OpenText(text);
			List<string> list = new List<string>();
			List<int> list2 = new List<int>();
			List<int> list3 = new List<int>();
			string text2 = streamReader.ReadLine();
			if (text2 != null && text2 == Class333.smethod_981())
			{
				flag = true;
				long length = streamReader.BaseStream.Length;
				long num = 0L;
				int num2 = 0;
				int num3 = -1;
				bool flag2 = false;
				int[] array = null;
				long num4 = -1L;
				do
				{
					text2 = streamReader.ReadLine();
					if (text2 == null)
					{
						continue;
					}
					if (flag2)
					{
						if (text2.StartsWith(Class333.smethod_1003()))
						{
							continue;
						}
						string[] array2 = text2.Split(',');
						int num5 = int.Parse(array2[0].Substring(0, 2));
						int num6 = int.Parse(array2[0].Substring(3, 2));
						int num7 = int.Parse(array2[0].Substring(6, 2));
						int num8 = int.Parse(array2[0].Substring(9, 3));
						long num9 = num5 * 3600000 + num6 * 60000 + num7 * 1000 + num8;
						if (num4 == -1L)
						{
							num4 = num9;
						}
						num9 -= num4;
						string text3 = string.Format(Class333.smethod_1004(), (float)num9 / 1000f);
						for (int i = 1; i < array2.Length; i++)
						{
							int num10 = list3[i - 1];
							if (!string.IsNullOrEmpty(array2[i]))
							{
								string s = array2[i];
								int num11;
								try
								{
									num11 = int.Parse(s);
								}
								catch
								{
									num11 = (int)float.Parse(s);
								}
								string text4 = Class233.smethod_29(num11, num10);
								text3 = text3 + text4 + Class333.smethod_189();
								array[i - 1] = num11;
							}
							else
							{
								string text5 = Class233.smethod_29(array[i - 1], num10);
								text3 = text3 + text5 + Class333.smethod_189();
							}
						}
						streamWriter.WriteLine(text3);
						if (backgroundWorker.WorkerReportsProgress)
						{
							num++;
							if (num2 == 0)
							{
								num2 = list.Count * 3;
							}
							int num12 = Math.Min(100, (int)(100L * num * num2 / length));
							if (num12 != num3)
							{
								backgroundWorker.ReportProgress(num12);
							}
							num3 = num12;
						}
					}
					else if (text2.StartsWith(Class333.smethod_1005()))
					{
						list.Add(text2.Substring(Class333.smethod_1005().Length));
					}
					else if (text2.StartsWith(Class333.smethod_1006()))
					{
						list2.Add(int.Parse(text2.Substring(Class333.smethod_1006().Length)));
					}
					else if (text2.StartsWith(Class333.smethod_1007()))
					{
						list3.Add((int)Enum.Parse(typeof(UnitType), text2.Substring(Class333.smethod_1007().Length)));
					}
					else
					{
						if (!text2.StartsWith(Class333.smethod_1003()))
						{
							continue;
						}
						string text6 = Class333.smethod_1008();
						foreach (string item in list)
						{
							text6 = text6 + item + Class333.smethod_189();
						}
						streamWriter.WriteLine(text6);
						array = new int[list.Count];
						flag2 = true;
					}
				}
				while (text2 != null);
			}
			if (backgroundWorker.WorkerReportsProgress)
			{
				backgroundWorker.ReportProgress(100);
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1009() + ex.Message);
		}
		finally
		{
			streamReader?.Close();
			streamWriter?.Close();
			try
			{
				if (!flag)
				{
					File.Delete(path);
				}
			}
			catch
			{
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		class85_1.DrawItem -= class85_1_DrawItem;
		class85_1.DrawSubItem -= class85_1_DrawSubItem;
		class85_1.DrawColumnHeader -= class85_1_DrawColumnHeader;
		class85_1.ContextMenuStrip.Opening -= method_5;
		toolStripMenuItem_0.Click -= toolStripMenuItem_0_Click;
		toolStripMenuItem_1.Click -= toolStripMenuItem_1_Click;
		toolStripMenuItem_2.Click -= toolStripMenuItem_2_Click;
		toolStripMenuItem_3.Click -= toolStripMenuItem_3_Click;
		toolStripMenuItem_4.Click -= toolStripMenuItem_4_Click;
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_27()
	{
		label_0 = new Label();
		label_1 = new Label();
		themedComboBox_1 = new ThemedComboBox();
		class85_1 = new Class85();
		themedComboBox_0 = new ThemedComboBox();
		class148_0 = new Class148();
		themedTextBox_0 = new ThemedTextBox();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		themedButton_2 = new ThemedButton();
		themedButton_3 = new ThemedButton();
		label_2 = new Label();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(12, 24);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(212, 13);
		label_0.TabIndex = 3;
		label_0.Text = Class333.smethod_1010();
		label_1.AutoSize = true;
		label_1.Location = new Point(12, 67);
		label_1.Name = Class333.smethod_621();
		label_1.Size = new Size(113, 13);
		label_1.TabIndex = 11;
		label_1.Text = Class333.smethod_1011();
		themedComboBox_1.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_1.FormattingEnabled = true;
		themedComboBox_1.Items.AddRange(Class333.smethod_1012(), Class333.smethod_1013(), Class333.smethod_1014());
		themedComboBox_1.Location = new Point(158, 64);
		themedComboBox_1.Name = Class333.smethod_1015();
		themedComboBox_1.Size = new Size(230, 23);
		themedComboBox_1.TabIndex = 2;
		themedComboBox_1.SelectedIndexChanged += themedComboBox_1_SelectedIndexChanged;
		class85_1.BorderStyle = BorderStyle.FixedSingle;
		class85_1.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class85_1.FullRowSelect = true;
		class85_1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		class85_1.Location = new Point(12, 92);
		class85_1.Name = Class333.smethod_1016();
		class85_1.ShowItemToolTips = true;
		class85_1.Size = new Size(890, 500);
		class85_1.TabIndex = 5;
		class85_1.UseCompatibleStateImageBehavior = false;
		class85_1.View = View.Details;
		class85_1.DoubleClick += class85_1_DoubleClick;
		class85_1.MouseClick += class85_1_MouseClick;
		class85_1.MouseMove += class85_1_MouseMove;
		themedComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_0.FormattingEnabled = true;
		themedComboBox_0.Items.AddRange(Class333.smethod_1017(), Class333.smethod_1018(), Class333.smethod_1019(), Class333.smethod_1020());
		themedComboBox_0.Location = new Point(228, 21);
		themedComboBox_0.Name = Class333.smethod_1021();
		themedComboBox_0.Size = new Size(230, 23);
		themedComboBox_0.TabIndex = 1;
		themedComboBox_0.SelectedIndexChanged += themedComboBox_0_SelectedIndexChanged;
		class148_0.AutoSize = true;
		class148_0.Checked = true;
		class148_0.CheckState = CheckState.Checked;
		class148_0.Location = new Point(12, 3);
		class148_0.Name = Class333.smethod_1022();
		class148_0.Size = new Size(456, 17);
		class148_0.TabIndex = 0;
		class148_0.Text = Class333.smethod_1023();
		class148_0.UseVisualStyleBackColor = true;
		class148_0.CheckedChanged += class148_0_CheckedChanged;
		themedTextBox_0.Location = new Point(542, 250);
		themedTextBox_0.Name = Class333.smethod_1024();
		themedTextBox_0.Size = new Size(190, 22);
		themedTextBox_0.TabIndex = 6;
		themedTextBox_0.Visible = false;
		themedTextBox_0.KeyDown += themedTextBox_0_KeyDown;
		themedButton_0.Location = new Point(500, 0);
		themedButton_0.Name = Class333.smethod_1025();
		themedButton_0.Size = new Size(400, 23);
		themedButton_0.TabIndex = 14;
		themedButton_0.Text = Class333.smethod_1026();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		themedButton_1.Location = new Point(500, 23);
		themedButton_1.Name = Class333.smethod_1027();
		themedButton_1.Size = new Size(400, 23);
		themedButton_1.TabIndex = 15;
		themedButton_1.Text = Class333.smethod_1028();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		themedButton_2.Location = new Point(500, 46);
		themedButton_2.Name = Class333.smethod_1029();
		themedButton_2.Size = new Size(400, 23);
		themedButton_2.TabIndex = 16;
		themedButton_2.Text = Class333.smethod_1030();
		themedButton_2.UseVisualStyleBackColor = true;
		themedButton_2.Click += themedButton_2_Click;
		themedButton_3.Location = new Point(500, 69);
		themedButton_3.Name = Class333.smethod_1031();
		themedButton_3.Size = new Size(400, 23);
		themedButton_3.TabIndex = 17;
		themedButton_3.Text = Class333.smethod_1032();
		themedButton_3.UseVisualStyleBackColor = true;
		themedButton_3.Click += themedButton_3_Click;
		label_2.AutoSize = true;
		label_2.Location = new Point(12, 45);
		label_2.Name = Class333.smethod_620();
		label_2.Size = new Size(316, 13);
		label_2.TabIndex = 20;
		label_2.Text = Class333.smethod_1033();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(914, 601);
		Controls.Add(label_2);
		Controls.Add(themedButton_3);
		Controls.Add(themedButton_2);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Controls.Add(themedComboBox_1);
		Controls.Add(label_1);
		Controls.Add(themedTextBox_0);
		Controls.Add(class85_1);
		Controls.Add(label_0);
		Controls.Add(themedComboBox_0);
		Controls.Add(class148_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1034();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_916();
		FormClosing += Form10_FormClosing;
		Shown += Form10_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_28()
	{
		for (int num = class85_1.Items.Count - 1; num >= 0; num--)
		{
			Class189 @class = (Class189)class85_1.Items[num].Tag;
			bool flag = @class.BoA != 0;
			if (((@class.BOz.Count == 1) & flag) && !@class.Boa)
			{
				smethod_6(@class.BOz[0]);
				class85_1.Items[num].Tag = null;
				class85_1.Items.RemoveAt(num);
				if (dictionary_0.ContainsKey(@class.BOz[0]))
				{
					dictionary_0.Remove(@class.BOz[0]);
				}
				if (dictionary_4.ContainsKey(@class.BOz[0]))
				{
					dictionary_4.Remove(@class.BOz[0]);
				}
				if (dictionary_5.ContainsKey(@class.BOz[0]))
				{
					dictionary_5.Remove(@class.BOz[0]);
				}
				if (dictionary_6.ContainsKey(@class.BOz[0]))
				{
					dictionary_6.Remove(@class.BOz[0]);
				}
				if (dictionary_7.ContainsKey(@class.BOz[0]))
				{
					dictionary_7.Remove(@class.BOz[0]);
				}
			}
		}
		class85_1.method_1();
		class85_1.Invalidate();
	}
}
