using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns4;
using ns5;
using ns7;

namespace ns2;

internal class Control3 : UserControl
{
	internal struct Struct12
	{
		internal int[] BLO;

		internal uint BLo;
	}

	internal struct Struct13
	{
		internal List<Struct12> BLP;

		internal List<int> BLp;

		internal List<int> BLQ;
	}

	private struct Struct14
	{
		internal uint[,] BLq;

		internal ushort BLR;

		internal uint BLr;
	}

	internal struct Struct15
	{
		internal Point BLS;

		internal Point BLs;

		internal byte BLT;

		internal int BLt;

		internal short BLU;

		internal Color BLu;

		public override string ToString()
		{
			return Class333.Bba() + BLS.X + Class333.aMY() + BLS.Y + Class333.BbB() + BLs.X + Class333.aMY() + BLs.Y;
		}
	}

	internal enum Enum34
	{
		BLV,
		BLv,
		BLW
	}

	internal enum Enum35
	{
		BLw,
		BLX,
		BLx
	}

	internal class EventArgs3 : EventArgs
	{
		[CompilerGenerated]
		private Enum35 BLY;

		internal EventArgs3(Enum35 enum35_0)
		{
			method_1(enum35_0);
		}

		[SpecialName]
		[CompilerGenerated]
		internal Enum35 method_0()
		{
			return BLY;
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_1(Enum35 enum35_0)
		{
			BLY = enum35_0;
		}
	}

	private delegate void Delegate22();

	private delegate void Delegate23(object sender, EventArgs e);

	internal enum Enum36
	{
		BLy,
		BLZ,
		BLz
	}

	internal const int int_0 = 10;

	private const int int_1 = 5;

	private const int int_2 = 3;

	private const int int_3 = 50;

	internal static double double_0 = 1.0;

	internal static bool bool_0 = true;

	internal static bool bool_1 = false;

	internal static string string_0 = Form23.string_2 + Class333.smethod_522() + Form23.string_18 + Class333.smethod_523();

	internal static List<List<ushort>> list_0 = new List<List<ushort>>();

	internal static List<bool> list_1 = new List<bool>();

	internal static bool bool_2 = false;

	private static MemoryStream memoryStream_0 = null;

	private static ZipArchive zipArchive_0 = null;

	private static ZipArchiveEntry zipArchiveEntry_0 = null;

	private static Stream stream_0 = null;

	private static string string_1 = string.Empty;

	internal static Stopwatch stopwatch_0 = new Stopwatch();

	internal static int int_4 = 0;

	internal static int int_5 = -1;

	internal static int int_6 = -1;

	internal static int int_7 = -1;

	internal static int int_8 = -1;

	internal static int int_9 = 0;

	private static int int_10 = 0;

	private static int int_11 = 0;

	internal static bool bool_3 = false;

	internal static bool bool_4 = false;

	private static bool bool_5 = false;

	private static bool bool_6 = false;

	private static bool bool_7 = false;

	private static bool bool_8 = false;

	private static int int_12 = 0;

	private static int int_13 = 0;

	private static int int_14 = 0;

	internal static List<int> list_2 = new List<int>();

	internal static int int_15 = -1;

	private static List<List<int>> list_3 = new List<List<int>>();

	private static List<List<Color>> list_4 = new List<List<Color>>();

	private static Color[] color_0 = new Color[10];

	private static ushort[] ushort_0 = new ushort[9] { 384, 224, 8018, 229, 228, 225, 397, 6425, 2421 };

	internal static List<Struct13> list_5;

	private static List<Struct14> list_6;

	private static List<List<Struct15>> list_7 = new List<List<Struct15>>();

	private static BackgroundWorker backgroundWorker_0 = new BackgroundWorker();

	internal static Enum34 enum34_0 = Enum34.BLV;

	[CompilerGenerated]
	private static EventHandler eventHandler_0;

	[CompilerGenerated]
	private static EventHandler<EventArgs3> eventHandler_1;

	private static object object_0 = new object();

	private static int int_16 = 0;

	private static int int_17 = 0;

	private static int int_18 = 0;

	private static bool bool_9;

	private static bool bool_10;

	private static int int_19;

	private static int int_20;

	private const int int_21 = 1;

	private const int int_22 = 10;

	private const int int_23 = 50;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private ThemedButton themedButton_2;

	private ThemedButton themedButton_3;

	private ThemedButton themedButton_4;

	private Label label_0;

	private Label label_1;

	private Class60 class60_0;

	private ImageList imageList_0;

	private ContextMenuStrip contextMenuStrip_0;

	private ToolStripMenuItem toolStripMenuItem_0;

	internal Panel panel_0;

	internal ThemedButton themedButton_5;

	internal Control3()
	{
		method_17();
		if (ushort_0.Length > 10)
		{
			throw new Exception(Class333.smethod_479());
		}
		color_0[0] = Color.Red;
		color_0[1] = Color.SkyBlue;
		color_0[2] = Color.LightGreen;
		color_0[3] = Color.Yellow;
		color_0[4] = Color.PeachPuff;
		color_0[5] = Color.LightCoral;
		color_0[6] = Color.PaleTurquoise;
		color_0[7] = Color.White;
		color_0[8] = Color.Orange;
		color_0[9] = Color.Pink;
		backgroundWorker_0.DoWork += method_9;
		backgroundWorker_0.RunWorkerAsync();
		panel_0.MouseDown += panel_0_MouseDown;
		panel_0.MouseMove += panel_0_MouseMove;
		panel_0.MouseUp += panel_0_MouseUp;
	}

	internal void method_0()
	{
		panel_0.BackColor = Form23.color_10;
		label_1.ForeColor = Form23.color_12;
		label_0.ForeColor = Form23.color_12;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_0(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_1(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	protected virtual void vmethod_0()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, null);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_2(EventHandler<EventArgs3> eventHandler_2)
	{
		EventHandler<EventArgs3> eventHandler = eventHandler_1;
		EventHandler<EventArgs3> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs3> value = (EventHandler<EventArgs3>)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_3(EventHandler<EventArgs3> eventHandler_2)
	{
		EventHandler<EventArgs3> eventHandler = eventHandler_1;
		EventHandler<EventArgs3> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs3> value = (EventHandler<EventArgs3>)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	protected virtual void vmethod_1(Enum35 enum35_0)
	{
		EventArgs3 e = new EventArgs3(enum35_0);
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, e);
		}
	}

	private bool method_1(List<string> list_8)
	{
		if (list_5.Count != list_0.Count)
		{
			list_8.Add(Class333.smethod_480());
			return false;
		}
		for (int i = 0; i < list_5.Count; i++)
		{
			Struct13 @struct = list_5[i];
			int count = list_0[i].Count;
			for (int j = 0; j < @struct.BLP.Count; j++)
			{
				if (@struct.BLP[j].BLO.Length != count)
				{
					list_8.Add(Class333.smethod_481());
					return false;
				}
			}
		}
		return true;
	}

	private void Control3_VisibleChanged(object sender, EventArgs e)
	{
		bool_4 = false;
		int_9 = 0;
		double_0 = 1.0;
		bool_0 = true;
		bool_1 = false;
		if (Visible)
		{
			list_3.Clear();
			list_4.Clear();
			int num = 0;
			for (int i = 0; i < list_0.Count; i++)
			{
				num += list_0[i].Count;
			}
			if (num <= 10)
			{
				int num2 = 0;
				for (int j = 0; j < list_0.Count; j++)
				{
					list_3.Add(new List<int>());
					list_4.Add(new List<Color>());
					for (int k = 0; k < list_0[j].Count; k++)
					{
						ushort item = list_0[j][k];
						Setting setting = Form23.framework_1.method_31(item);
						if (setting != null && setting.method_35() && PortFunction.smethod_52(setting))
						{
							list_3[j].Add(item);
							list_4[j].Add(color_0[num2]);
							num2++;
						}
					}
				}
			}
			else
			{
				HashSet<ushort> hashSet = new HashSet<ushort>();
				int num3 = 0;
				for (int l = 0; l < list_0.Count; l++)
				{
					list_3.Add(new List<int>());
					list_4.Add(new List<Color>());
					for (int m = 0; m < list_0[l].Count; m++)
					{
						ushort num4 = list_0[l][m];
						if (hashSet.Contains(num4))
						{
							continue;
						}
						hashSet.Add(num4);
						ushort[] array = ushort_0;
						foreach (int num5 in array)
						{
							if (num4 == num5)
							{
								Setting setting2 = Form23.framework_1.method_31(num4);
								if (setting2 != null && setting2.method_35() && PortFunction.smethod_52(setting2))
								{
									list_3[l].Add(num4);
									list_4[l].Add(color_0[num3]);
									num3++;
								}
								break;
							}
						}
						if (num3 >= 10)
						{
							break;
						}
					}
				}
			}
			double num6 = (double)(int_6 - int_5) / 1000.0;
			label_1.Text = Class333.smethod_482() + string.Format(Class333.smethod_483(), num6) + Class333.smethod_484();
			label_0.Text = Class333.smethod_485() + string.Format(Class333.smethod_483(), double_0) + Class333.smethod_486();
			themedButton_4.Enabled = true;
			themedButton_2.Enabled = false;
			themedButton_5.Enabled = false;
			themedButton_1.Enabled = true;
			themedButton_0.Enabled = true;
			toolStripMenuItem_0.Enabled = true;
			list_2.Clear();
			int_15 = -1;
			if (stopwatch_0.IsRunning)
			{
				stopwatch_0.Reset();
			}
			Rectangle rectangle = new Rectangle(0, 4, class60_0.Width, class60_0.Height - 10);
			smethod_4(rectangle, 0, 0, list_3, null, null, list_4, list_7, int_5, int_6);
			Invalidate(rectangle);
		}
		else
		{
			method_2();
		}
	}

	internal void method_2()
	{
		try
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
				memoryStream_0.Close();
				memoryStream_0 = null;
			}
		}
		catch
		{
		}
	}

	private void method_3()
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate22 method = method_3;
				BeginInvoke(method);
			}
			catch
			{
			}
		}
		else
		{
			int num = int_6 - int_5;
			double num2 = (double)(int_4 - int_5) / 1000.0;
			double num3 = (double)num / 1000.0;
			label_1.Text = string.Format(Class333.smethod_483(), num2) + Class333.smethod_487() + string.Format(Class333.smethod_483(), num3) + Class333.smethod_484();
			class60_0.Invalidate();
		}
		if (enum34_0 == Enum34.BLW)
		{
			if (int_4 >= int_8)
			{
				vmethod_1(Enum35.BLX);
			}
			else
			{
				vmethod_1(Enum35.BLw);
			}
		}
		else
		{
			vmethod_1(Enum35.BLw);
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < list_3.Count; i++)
		{
			foreach (int item2 in list_3[i])
			{
				list.Add(item2);
			}
		}
		List<int> list2 = Form45.smethod_0(Form23.form23_0, Form23.framework_1, list, 10);
		if (list2 == null)
		{
			return;
		}
		list_3.Clear();
		list_4.Clear();
		HashSet<ushort> hashSet = new HashSet<ushort>();
		int num = 0;
		for (int j = 0; j < list_0.Count; j++)
		{
			list_3.Add(new List<int>());
			list_4.Add(new List<Color>());
			for (int k = 0; k < list_0[j].Count; k++)
			{
				ushort item = list_0[j][k];
				if (!hashSet.Contains(item))
				{
					hashSet.Add(item);
					if (list2.Contains(item))
					{
						list_3[j].Add(item);
						list_4[j].Add(color_0[num]);
						num++;
					}
					if (num >= 10)
					{
						break;
					}
				}
			}
		}
		Rectangle rectangle = new Rectangle(0, 4, class60_0.Width, class60_0.Height - 10);
		smethod_4(rectangle, 0, 0, list_3, null, null, list_4, list_7, int_5, int_6);
		Invalidate(rectangle);
		method_10();
	}

	private void method_4()
	{
		bool flag = int_4 >= int_8;
		bool flag2 = int_4 >= int_6;
		if (flag & flag2)
		{
			if (enum34_0 == Enum34.BLv)
			{
				int_9 = int_7;
			}
			else if (enum34_0 == Enum34.BLW)
			{
				int_9 = int_5;
				int num = int_14 - int_13;
				int_10 = int_5;
				int_11 = num;
			}
		}
		else if (flag)
		{
			if (enum34_0 == Enum34.BLv)
			{
				int_9 = int_7;
			}
		}
		else if (int_9 == 0)
		{
			if (enum34_0 == Enum34.BLv)
			{
				int_9 = int_7;
			}
			else if (enum34_0 == Enum34.BLW)
			{
				int_9 = int_5;
			}
		}
		int_12 = int_9;
		int_13 = int_10;
		int_14 = int_11;
		if (!stopwatch_0.IsRunning)
		{
			stopwatch_0.Start();
		}
		else if (bool_0)
		{
			stopwatch_0.Restart();
		}
		else if (bool_1)
		{
			stopwatch_0.Start();
		}
		bool_0 = false;
		bool_1 = false;
		themedButton_4.Enabled = false;
		themedButton_2.Enabled = true;
		themedButton_5.Enabled = true;
		themedButton_1.Enabled = false;
		themedButton_0.Enabled = false;
		toolStripMenuItem_0.Enabled = false;
	}

	private void themedButton_4_Click(object sender, EventArgs e)
	{
		enum34_0 = Enum34.BLv;
		method_4();
	}

	private void method_5(object sender, EventArgs e)
	{
		enum34_0 = Enum34.BLW;
		method_4();
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		if (stopwatch_0.IsRunning && !bool_1)
		{
			stopwatch_0.Stop();
			bool_1 = true;
		}
		themedButton_4.Enabled = true;
		themedButton_2.Enabled = false;
		themedButton_5.Enabled = true;
		themedButton_1.Enabled = false;
		themedButton_0.Enabled = false;
		toolStripMenuItem_0.Enabled = false;
	}

	internal void themedButton_5_Click(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate23 method = themedButton_5_Click;
				Invoke(method, sender, e);
			}
			catch
			{
			}
		}
		else
		{
			if (!bool_0)
			{
				list_2.Clear();
				int_15 = -1;
				if (sender != null)
				{
					if (enum34_0 == Enum34.BLv)
					{
						int_9 = int_7;
						int_4 = int_7;
					}
					else if (enum34_0 == Enum34.BLW)
					{
						int_9 = int_5;
						int_4 = int_5;
						int num = int_14 - int_13;
						int_10 = int_5;
						int_11 = num;
						int_7 = int_5;
						int_8 = num;
					}
				}
				else if (enum34_0 == Enum34.BLv)
				{
					int_9 = int_12;
				}
				else if (enum34_0 == Enum34.BLW)
				{
					int_9 = 0;
					int num2 = int_14 - int_13;
					int_10 = 0;
					int_11 = num2;
				}
				stopwatch_0.Reset();
				bool_0 = true;
				bool_1 = false;
				method_6();
			}
			themedButton_4.Enabled = true;
			themedButton_2.Enabled = false;
			themedButton_5.Enabled = false;
			themedButton_1.Enabled = true;
			themedButton_0.Enabled = true;
			toolStripMenuItem_0.Enabled = true;
			Form23.form23_0.Refresh();
		}
		enum34_0 = Enum34.BLV;
	}

	private void method_6()
	{
		if (memoryStream_0 == null || stream_0 == null)
		{
			return;
		}
		if (stream_0 is FileStream)
		{
			stream_0.Position = 0L;
			return;
		}
		method_2();
		if (string.IsNullOrEmpty(string_1))
		{
			return;
		}
		try
		{
			memoryStream_0 = Class35.smethod_7(string_1, Class19.smethod_3());
			if (memoryStream_0.CanRead && string_1.EndsWith(Class333.smethod_488()))
			{
				zipArchive_0 = new ZipArchive(memoryStream_0, ZipArchiveMode.Read);
				foreach (ZipArchiveEntry entry in zipArchive_0.Entries)
				{
					if (entry.Name.EndsWith(Class333.smethod_489()))
					{
						zipArchiveEntry_0 = entry;
						break;
					}
				}
				if (zipArchiveEntry_0 != null)
				{
					stream_0 = zipArchiveEntry_0.Open();
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_490() + ex.Message);
		}
		list_2.Clear();
		int_15 = -1;
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		if (double_0 > 0.125)
		{
			double_0 /= 2.0;
			label_0.Text = Class333.smethod_485() + string.Format(Class333.smethod_483(), double_0) + Class333.smethod_486();
		}
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		if (double_0 < 8.0)
		{
			double_0 *= 2.0;
			label_0.Text = Class333.smethod_485() + string.Format(Class333.smethod_483(), double_0) + Class333.smethod_486();
		}
	}

	private int method_7(ref uint uint_0, bool bool_11)
	{
		int num = stream_0.ReadByte();
		int num2 = 1;
		if (num != -1)
		{
			if (num != 255)
			{
				byte[] array = null;
				byte[] array2 = new byte[4];
				if (!Class23.smethod_14(stream_0, array2, 0, 4))
				{
					return 0;
				}
				uint num3 = (uint)((array2[0] << 24) | ((array2[1] << 16) & 0xFF0000) | ((array2[2] << 8) & 0xFF00) | (array2[3] & 0xFF));
				num2 += 4;
				if (num3 == uint.MaxValue || num3 == 0 || (num3 > 131072 && num != 2 && (num & 0xF) != 9 && num != 13))
				{
					return 0;
				}
				int num4 = 0;
				if ((num & 0xF) == 6)
				{
					num4 = (num >> 4) & 0xF;
				}
				List<ushort> list = null;
				if ((num & 0xF) == 6 || num == 11)
				{
					list = new List<ushort>();
				}
				if ((num & 0xF) != 7 && num != 12)
				{
					if (num == 10)
					{
						bool_2 = true;
						byte[] array3 = new byte[4];
						if (!Class23.smethod_14(stream_0, array3, 0, 4))
						{
							return 0;
						}
						uint bLr = (uint)((array3[0] << 24) | ((array3[1] << 16) & 0xFF0000) | ((array3[2] << 8) & 0xFF00) | (array3[3] & 0xFF));
						num2 += 4;
						byte[] array4 = new byte[2];
						if (!Class23.smethod_14(stream_0, array4, 0, 2))
						{
							return 0;
						}
						ushort bLR = (ushort)(((array4[0] << 8) & 0xFF00) | (array4[1] & 0xFF));
						num2 += 2;
						Struct14 item = new Struct14
						{
							BLr = bLr,
							BLR = bLR,
							BLq = new uint[4, 1000]
						};
						int num5 = 16000;
						byte[] array5 = new byte[16000];
						if (!Class23.smethod_14(stream_0, array5, 0, 16000))
						{
							return 0;
						}
						num2 += num5;
						uint num6 = 0u;
						for (int i = 0; i < num5; i++)
						{
							uint num7 = (uint)(array5[i] & 0xFF);
							switch (i % 4)
							{
							case 0:
								num6 = num7 << 24;
								break;
							case 1:
								num6 |= num7 << 16;
								break;
							case 2:
								num6 |= num7 << 8;
								break;
							case 3:
							{
								num6 |= num7;
								int num8 = i / 4000;
								int num9 = i % 4000 / 4;
								item.BLq[num8, num9] = num6;
								break;
							}
							}
						}
						list_6.Add(item);
					}
					else
					{
						byte[] array6 = new byte[num3 - 5];
						if (!Class23.smethod_14(stream_0, array6, 0, (int)(num3 - 5)))
						{
							return 0;
						}
						num2 += (int)(num3 - 5);
						for (int j = 5; j < num3; j++)
						{
							byte b = array6[j - 5];
							if ((num & 0xF) == 1)
							{
								if ((j == 5 && b != 72) || (j == 6 && b != 65) || (j == 7 && b != 76) || (j == 8 && b != 84) || (j == 9 && b != 69) || (j == 10 && b != 67) || (j == 11 && b != 72) || (j == 12 && b != 48 && b != 49))
								{
									throw new Exception();
								}
							}
							else if ((num & 0xF) == 2)
							{
								if (!bool_11)
								{
									if (j == 5)
									{
										array = new byte[num3 - 5];
									}
									array[j - 5] = b;
									if (j == num3 - 1)
									{
										File.WriteAllBytes(string_0, array);
									}
								}
							}
							else
							{
								if ((num & 0xF) != 6 && num != 11)
								{
									continue;
								}
								if (num == 11)
								{
									switch (j)
									{
									case 5:
										num4 |= (b << 8) & 0xFF00;
										break;
									case 6:
										num4 |= b & 0xFF;
										break;
									}
								}
								if ((num & 0xF) == 6 || (num == 11 && j >= 7))
								{
									if ((j & 1) == 1)
									{
										list.Add((ushort)((b << 8) & 0xFF00));
									}
									else
									{
										list[list.Count - 1] |= (ushort)(b & 0xFF);
									}
								}
							}
						}
					}
				}
				else
				{
					int num10;
					if (num == 12)
					{
						byte[] array7 = new byte[2];
						if (!Class23.smethod_14(stream_0, array7, 0, 2))
						{
							return 0;
						}
						num10 = ((array7[0] << 8) & 0xFF00) | (array7[1] & 0xFF);
						num2 += 2;
					}
					else
					{
						num10 = (num >> 4) & 0xF;
					}
					byte[] array8 = new byte[4];
					if (!Class23.smethod_14(stream_0, array8, 0, 4))
					{
						return 0;
					}
					uint num11 = (uint)((array8[0] << 24) | ((array8[1] << 16) & 0xFF0000) | ((array8[2] << 8) & 0xFF00) | (array8[3] & 0xFF));
					num2 += 4;
					int_6 = (int)num11;
					if (int_5 == -1)
					{
						int_5 = (int)num11;
					}
					int num12 = 0;
					while (list_5.Count <= num10)
					{
						Struct13 item2 = new Struct13
						{
							BLP = new List<Struct12>(),
							BLp = new List<int>(),
							BLQ = new List<int>()
						};
						list_5.Add(item2);
					}
					Struct12 item3 = new Struct12
					{
						BLo = num11,
						BLO = new int[list_0[num10].Count]
					};
					uint num13 = ((num != 12) ? (num3 - 9) : (num3 - 11));
					byte[] array9 = new byte[num13];
					if (!Class23.smethod_14(stream_0, array9, 0, (int)num13))
					{
						return 0;
					}
					num2 += (int)num13;
					for (int k = 0; k < num13; k++)
					{
						uint num14 = (uint)(array9[k] & 0xFF);
						switch (k % 4)
						{
						case 0:
							num12 = (int)(num14 << 24);
							break;
						case 1:
							num12 |= (int)(num14 << 16);
							break;
						case 2:
							num12 |= (int)(num14 << 8);
							break;
						case 3:
						{
							num12 |= (int)num14;
							int num15 = k >> 2;
							item3.BLO[num15] = num12;
							while (list_5[num10].BLp.Count <= num15)
							{
								list_5[num10].BLp.Add(int.MaxValue);
							}
							list_5[num10].BLp[num15] = Math.Min(list_5[num10].BLp[num15], num12);
							while (list_5[num10].BLQ.Count <= num15)
							{
								list_5[num10].BLQ.Add(int.MinValue);
							}
							list_5[num10].BLQ[num15] = Math.Max(list_5[num10].BLQ[num15], num12);
							break;
						}
						}
					}
					if (uint_0 != uint.MaxValue && num11 < uint_0)
					{
						throw new Exception();
					}
					uint_0 = num11;
					list_5[num10].BLP.Add(item3);
				}
				if ((num & 0xF) == 6 || num == 11)
				{
					while (list_0.Count < num4)
					{
						list_0.Add(new List<ushort>());
					}
					if (list_0.Count <= num4)
					{
						list_0.Add(list);
					}
				}
			}
			return num2;
		}
		return 0;
	}

	internal bool method_8(string string_2, BackgroundWorker backgroundWorker_1, out string string_3)
	{
		backgroundWorker_1.ReportProgress(5);
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		list_0.Clear();
		if (list_5 != null)
		{
			list_5.Clear();
		}
		list_5 = new List<Struct13>();
		bool_2 = false;
		if (list_6 != null)
		{
			list_6.Clear();
		}
		list_6 = new List<Struct14>();
		int_5 = -1;
		int_6 = -1;
		bool flag = true;
		List<string> list = new List<string>();
		method_2();
		for (int i = 0; i < 10; i++)
		{
			try
			{
				if (File.Exists(string_2))
				{
					string_1 = string_2;
					memoryStream_0 = Class35.smethod_7(string_2, Class19.smethod_3());
				}
				if (memoryStream_0 != null)
				{
					break;
				}
			}
			catch
			{
				list.Add(Class333.smethod_491());
				Thread.Sleep(1000);
			}
		}
		try
		{
			if (memoryStream_0 != null && memoryStream_0.CanRead)
			{
				bool flag2 = false;
				long num = 0L;
				if (string_2.EndsWith(Class333.smethod_488()))
				{
					zipArchive_0 = new ZipArchive(memoryStream_0, ZipArchiveMode.Read);
					foreach (ZipArchiveEntry entry in zipArchive_0.Entries)
					{
						if (entry.Name.EndsWith(Class333.smethod_489()))
						{
							zipArchiveEntry_0 = entry;
							if (flag2)
							{
								break;
							}
						}
						else
						{
							if (!entry.Name.EndsWith(Class333.smethod_146()))
							{
								continue;
							}
							using Stream stream = entry.Open();
							long length = entry.Length;
							byte[] array = new byte[length];
							for (int j = 0; j < length; j++)
							{
								array[j] = (byte)stream.ReadByte();
							}
							File.WriteAllBytes(string_0, array);
							flag2 = true;
						}
					}
					if (zipArchiveEntry_0 != null)
					{
						stream_0 = zipArchiveEntry_0.Open();
						num = zipArchiveEntry_0.Length;
					}
				}
				else
				{
					stream_0 = memoryStream_0;
					num = memoryStream_0.Length;
				}
				int num2 = 0;
				long num3 = 0L;
				int num4 = 5;
				uint uint_ = uint.MaxValue;
				do
				{
					num2 = method_7(ref uint_, flag2);
					num3 += num2;
					int num5 = (int)(5L + num3 * 90L / num);
					if (num5 % 2 == 0 && num5 != num4)
					{
						backgroundWorker_1.ReportProgress(num5);
						Thread.Sleep(0);
					}
					num4 = num5;
				}
				while (num2 != 0);
				method_6();
			}
			else
			{
				list.Add(Class333.smethod_492());
				flag = false;
			}
		}
		catch
		{
			list.Add(Class333.smethod_493());
			flag = false;
		}
		if (flag)
		{
			flag = method_1(list);
			list_1.Clear();
			if (flag)
			{
				int num6 = -1;
				for (int k = 0; k < list_0.Count; k++)
				{
					foreach (ushort item in list_0[k])
					{
						num6 = Math.Max(item, num6);
					}
				}
				if (num6 != -1)
				{
					for (int l = 0; l <= num6; l++)
					{
						list_1.Add(item: false);
					}
					for (int m = 0; m < list_0.Count; m++)
					{
						foreach (ushort item2 in list_0[m])
						{
							list_1[item2] = true;
						}
					}
				}
				else
				{
					flag = false;
				}
				int_7 = int_5;
				int_8 = int_6;
				vmethod_0();
			}
		}
		backgroundWorker_1.ReportProgress(100);
		string_3 = Class333.smethod_102();
		if (list.Count > 0)
		{
			string_3 += Class333.smethod_183();
		}
		foreach (string item3 in list)
		{
			string_3 = string_3 + item3 + Class333.smethod_183();
		}
		return flag;
	}

	private void method_9(object sender, DoWorkEventArgs e)
	{
		Thread.CurrentThread.Name = Class333.smethod_494();
		while (true)
		{
			if (memoryStream_0 != null && stream_0 != null && !bool_1 && !bool_0 && (Form23.int_0 & 0x1000) != 0)
			{
				method_10();
				Thread.Sleep(20);
			}
			else
			{
				Thread.Sleep(500);
			}
		}
	}

	internal void method_10()
	{
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(object_0, ref lockTaken);
			if (!lockTaken)
			{
				return;
			}
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			int num = int_6 - int_5;
			int num2 = int_4 - int_7;
			int num3 = (int)((double)int_9 + (double)(int)stopwatch_0.ElapsedMilliseconds * double_0);
			int num4 = int_10;
			int num5 = int_11;
			if (enum34_0 == Enum34.BLW && num3 >= int_8 && !smethod_5())
			{
				num5 = num3;
				num4 = num3 - num2;
			}
			for (int i = 0; i < Form23.framework_1.aWt.Count; i++)
			{
				Form23.framework_1.aWt[i].method_268();
			}
			for (int j = 0; j < list_5.Count; j++)
			{
				while (list_2.Count <= j)
				{
					list_2.Add(-1);
				}
				if (list_2[j] > num3)
				{
					continue;
				}
				Struct13 @struct = list_5[j];
				int count = @struct.BLP.Count;
				int num6 = 0;
				if (count > 1000 && !bool_4 && !bool_3)
				{
					num6 = Math.Max(0, (int)((double)(num3 - int_5) / (double)num * (double)count) - count / 100);
				}
				for (int k = num6; k < count; k++)
				{
					if (@struct.BLP[k].BLo <= num3)
					{
						continue;
					}
					Struct12 struct2 = @struct.BLP[k - 1];
					int bLo = (int)struct2.BLo;
					for (int l = 0; l < struct2.BLO.Length; l++)
					{
						Setting setting = Form23.framework_1.method_31(list_0[j][l]);
						if (setting != null)
						{
							int num7 = struct2.BLO[l];
							setting.method_272(num7, bool_0: false);
						}
					}
					while (list_2.Count <= j)
					{
						list_2.Add(-1);
					}
					list_2[j] = bLo;
					break;
				}
			}
			for (int m = 0; m < Form23.framework_1.aWt.Count; m++)
			{
				Form23.framework_1.aWt[m].method_267(bool_0: false);
			}
			if (bool_2 && Form23.form43_0 != null && Form23.form43_0.Visible && int_15 <= num3)
			{
				int count2 = list_6.Count;
				for (int n = 0; n < count2; n++)
				{
					if (list_6[n].BLr > num3 && n >= 1)
					{
						Form23.form43_0.method_21(list_6[n - 1].BLq, list_6[n - 1].BLR);
						int_15 = (int)list_6[n - 1].BLr;
						break;
					}
				}
			}
			if (!bool_4 && !bool_3)
			{
				if (enum34_0 != Enum34.BLv && !smethod_5())
				{
					if (enum34_0 == Enum34.BLW)
					{
						int_7 = num4;
						int_8 = num5;
						if (num5 < int_6)
						{
							int_4 = num3;
						}
						else
						{
							int_4 = int_6;
							themedButton_5_Click(null, null);
						}
					}
				}
				else if (num3 < int_8)
				{
					int_4 = num3;
				}
				else
				{
					int_4 = int_8;
					themedButton_5_Click(null, null);
				}
			}
			method_3();
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.smethod_495(), stopwatch.ElapsedMilliseconds), bool_1: false);
		}
		catch
		{
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(object_0);
			}
		}
	}

	internal static void smethod_4(Rectangle rectangle_0, int int_24, int int_25, List<List<int>> list_8, List<List<int>> list_9, List<List<int>> list_10, List<List<Color>> list_11, List<List<Struct15>> list_12, int int_26, int int_27)
	{
		list_12.Clear();
		bool flag = list_9 != null && list_10 != null;
		int num = int_27 - int_26;
		if (num == 0)
		{
			num = 1;
		}
		if (list_8.Count == 0 || num == 0)
		{
			return;
		}
		for (int i = 0; i < list_5.Count; i++)
		{
			Struct13 @struct = list_5[i];
			if (@struct.BLP.Count == 0)
			{
				continue;
			}
			List<int> bLp = @struct.BLp;
			List<int> bLQ = @struct.BLQ;
			int num2 = 0;
			int num3 = @struct.BLP[0].BLO.Length;
			int[] array = new int[num3];
			int[] array2 = new int[num3];
			for (int j = 0; j < num3; j++)
			{
				array[j] = int.MaxValue;
			}
			for (int k = 0; k < num3; k++)
			{
				array2[k] = int.MinValue;
			}
			int[] array3 = new int[num3];
			int[] array4 = new int[num3];
			int[] array5 = new int[list_8[i].Count];
			for (int l = 0; l < list_8[i].Count; l++)
			{
				int num4 = list_0[i].IndexOf((ushort)list_8[i][l]);
				array5[l] = num4;
			}
			for (int m = 0; m < @struct.BLP.Count; m++)
			{
				Struct12 struct2 = @struct.BLP[m];
				int num5 = (int)((struct2.BLo - int_26) * rectangle_0.Width / num);
				if (num5 < 0)
				{
					for (int n = 0; n < list_8[i].Count; n++)
					{
						int num6 = struct2.BLO[array5[n]];
						array[array5[n]] = num6;
						array2[array5[n]] = num6;
					}
				}
				else
				{
					if (num5 > rectangle_0.Width)
					{
						continue;
					}
					if (num5 != num2)
					{
						HashSet<int> hashSet = new HashSet<int>();
						for (int num7 = 0; num7 < struct2.BLO.Length; num7++)
						{
							for (int num8 = 0; num8 < list_8[i].Count; num8++)
							{
								int num9 = list_8[i][num8];
								if (list_0[i][num7] != num9 || hashSet.Contains(num9))
								{
									continue;
								}
								hashSet.Add(num9);
								int num10 = bLp[num7];
								int num11 = bLQ[num7];
								if (flag)
								{
									num10 = list_9[i][num8];
									num11 = list_10[i][num8];
									_ = list_11[i][num8];
								}
								if (num5 == num2 + 1)
								{
									int num14;
									int num15;
									if (num11 - num10 != 0)
									{
										int num12 = rectangle_0.Bottom - rectangle_0.Height * (array[num7] - num10) / (num11 - num10);
										int num13 = rectangle_0.Bottom - rectangle_0.Height * (array2[num7] - num10) / (num11 - num10);
										if (num12 > num13)
										{
											num14 = num13;
											num15 = num12;
										}
										else if (num12 < num13)
										{
											num14 = num12;
											num15 = num13;
										}
										else
										{
											num14 = num12;
											num15 = num12 + 1;
										}
									}
									else
									{
										num14 = rectangle_0.Top + rectangle_0.Height / 2;
										num15 = num14 + 1;
									}
									if (num2 != 0)
									{
										if (num15 < array3[num7])
										{
											num15 = array3[num7];
										}
										if (num14 > array4[num7])
										{
											num14 = array4[num7];
										}
									}
									if (num14 != num15)
									{
										if (num14 < rectangle_0.Top - int_24)
										{
											num14 = rectangle_0.Top - int_24;
										}
										if (num14 > rectangle_0.Bottom + int_25)
										{
											num14 = rectangle_0.Bottom + int_25;
										}
										if (num15 < rectangle_0.Top - int_24)
										{
											num15 = rectangle_0.Top - int_24;
										}
										if (num15 > rectangle_0.Bottom + int_25)
										{
											num15 = rectangle_0.Bottom + int_25;
										}
									}
									while (list_12.Count < num8 + 1)
									{
										list_12.Add(new List<Struct15>());
									}
									Struct15 item = new Struct15
									{
										BLS = new Point(num2 + rectangle_0.Left, num15),
										BLs = new Point(num2 + rectangle_0.Left, num14),
										BLT = (byte)num8,
										BLU = (short)i,
										BLt = num9,
										BLu = list_11[i][num8]
									};
									list_12[num8].Add(item);
									array3[num7] = num14;
									array4[num7] = num15;
								}
								else
								{
									int num16;
									int num18;
									if (num11 - num10 != 0)
									{
										num16 = rectangle_0.Bottom - rectangle_0.Height * (array[num7] - num10) / (num11 - num10);
										int num17 = struct2.BLO[num7];
										num18 = rectangle_0.Bottom - rectangle_0.Height * (num17 - num10) / (num11 - num10);
									}
									else
									{
										num16 = (num18 = rectangle_0.Top + rectangle_0.Height / 2);
									}
									while (list_12.Count < num8 + 1)
									{
										list_12.Add(new List<Struct15>());
									}
									Struct15 item2 = new Struct15
									{
										BLS = new Point(num2 + rectangle_0.Left, num16),
										BLs = new Point(num5 + rectangle_0.Left, num18),
										BLT = (byte)num8,
										BLt = num9,
										BLU = (short)i,
										BLu = list_11[i][num8]
									};
									list_12[num8].Add(item2);
									array3[num7] = Math.Min(num16, num18);
									array4[num7] = Math.Max(num16, num18);
								}
								break;
							}
						}
						num2 = num5;
						for (int num19 = 0; num19 < array.Length; num19++)
						{
							array[num19] = int.MaxValue;
						}
						for (int num20 = 0; num20 < array2.Length; num20++)
						{
							array2[num20] = int.MinValue;
						}
					}
					for (int num21 = 0; num21 < list_8[i].Count; num21++)
					{
						int num22 = struct2.BLO[array5[num21]];
						if (num22 < array[array5[num21]])
						{
							array[array5[num21]] = num22;
						}
						if (num22 > array2[array5[num21]])
						{
							array2[array5[num21]] = num22;
						}
					}
				}
			}
		}
	}

	private void class60_0_Paint(object sender, PaintEventArgs e)
	{
		int num = int_6 - int_5;
		if (list_3.Count == 0 || num == 0)
		{
			return;
		}
		for (int i = 0; i < list_7.Count; i++)
		{
			foreach (Struct15 item in list_7[i])
			{
				if (i == item.BLT)
				{
					using (Pen pen = new Pen(item.BLu, 1f))
					{
						try
						{
							e.Graphics.DrawLine(pen, item.BLS.X, item.BLS.Y, item.BLs.X, item.BLs.Y);
						}
						catch
						{
						}
					}
					continue;
				}
				throw new Exception(Class333.smethod_496());
			}
		}
		method_11(e.Graphics, class60_0, num);
		using (Pen pen2 = new Pen(Color.White, 1f))
		{
			pen2.DashStyle = DashStyle.Dash;
			int num2 = (int)((long)(int_4 - int_5) * (long)class60_0.Width / num);
			e.Graphics.DrawLine(pen2, num2, 0, num2, class60_0.Height);
		}
		using Font font = new Font(Font.FontFamily, 8f);
		StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		stringFormat.LineAlignment = StringAlignment.Center;
		int num3 = 0;
		for (int j = 0; j < list_0.Count; j++)
		{
			for (int k = 0; k < list_3[j].Count; k++)
			{
				Setting setting = Form23.framework_1.method_31(list_3[j][k]);
				int num4 = class60_0.Width / 10;
				if (setting != null)
				{
					using SolidBrush brush = new SolidBrush(list_4[j][k]);
					string text = setting.method_18();
					string text2 = (string.IsNullOrWhiteSpace(text) ? setting.method_60(Enum96.aYT) : (text + Class333.smethod_497() + setting.method_60(Enum96.aYT) + Class333.smethod_9()));
					SizeF sizeF = e.Graphics.MeasureString(text2, font);
					RectangleF rectangleF = new RectangleF(4 + num3 * num4, 6f, sizeF.Width, sizeF.Height - 4f);
					e.Graphics.FillRectangle(Brushes.Black, rectangleF);
					e.Graphics.DrawString(text2, font, brush, rectangleF, stringFormat);
					num3++;
				}
			}
		}
		stringFormat.Dispose();
	}

	private void method_11(Graphics graphics_0, Class60 class60_1, int int_24)
	{
		if (int_8 == int_6 && int_7 == int_5)
		{
			return;
		}
		using SolidBrush brush = new SolidBrush(Color.FromArgb(100, Color.Red));
		int num = (int)((long)(int_7 - int_5) * (long)class60_0.Width / int_24);
		int num2 = (int)((long)(int_8 - int_5) * (long)class60_0.Width / int_24);
		graphics_0.FillRectangle(brush, new Rectangle(new Point(num, 0), new Size(num2 - num, Height)));
	}

	private static bool smethod_5()
	{
		if (int_7 == int_5)
		{
			return int_8 == int_6;
		}
		return false;
	}

	private void class60_0_MouseDown(object sender, MouseEventArgs e)
	{
		class60_0.Focus();
		bool_4 = true;
		int_16 = e.X;
		if (stopwatch_0.IsRunning)
		{
			themedButton_5_Click(null, null);
			stopwatch_0.Reset();
		}
		if (bool_5)
		{
			int_17 = method_12(int_8);
		}
		else if (bool_6)
		{
			int_18 = method_12(int_7);
		}
		if (bool_7)
		{
			int_4 = int_5 + (int)((long)e.X * (long)(int_6 - int_5) / class60_0.Width);
			int_9 = int_4;
			method_10();
			if (smethod_5())
			{
				bool_8 = true;
			}
			else
			{
				int_18 = int_16 - method_12(int_7);
				int_17 = method_12(int_8) - int_16;
			}
		}
		else
		{
			int_4 = int_5 + (int)((long)e.X * (long)(int_6 - int_5) / class60_0.Width);
			int_9 = int_4;
			int_7 = int_5;
			int_8 = int_6;
			int_10 = int_7;
			int_11 = int_8;
		}
		list_2.Clear();
		int_15 = -1;
	}

	private int method_12(int int_24)
	{
		int result = 0;
		if (int_6 - int_5 != 0)
		{
			result = (int)((long)(int_24 - int_5) * (long)class60_0.Width / (int_6 - int_5));
		}
		return result;
	}

	private void class60_0_MouseMove(object sender, MouseEventArgs e)
	{
		if (bool_4)
		{
			if (Math.Abs(int_16 - e.X) < 3)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			if (bool_5)
			{
				num = int_5 + (int)((long)e.X * (long)(int_6 - int_5) / class60_0.Width);
				num2 = int_5 + (int)((long)int_17 * (long)(int_6 - int_5) / class60_0.Width);
				int_7 = ((num < num2) ? num : num2);
				int_8 = ((num2 > num) ? num2 : num);
				if (int_7 < int_5)
				{
					int_7 = int_5;
				}
				if (int_8 > int_6)
				{
					int_8 = int_6;
				}
				int_10 = int_7;
				int_11 = int_8;
				if (int_4 < int_7 || int_4 > int_8)
				{
					int_4 = int_7;
					int_9 = int_4;
				}
				class60_0.Invalidate();
				return;
			}
			if (bool_6)
			{
				num2 = int_5 + (int)((long)e.X * (long)(int_6 - int_5) / class60_0.Width);
				num = int_5 + (int)((long)int_18 * (long)(int_6 - int_5) / class60_0.Width);
				int_7 = ((num < num2) ? num : num2);
				int_8 = ((num2 > num) ? num2 : num);
				if (int_7 < int_5)
				{
					int_7 = int_5;
				}
				if (int_8 > int_6)
				{
					int_8 = int_6;
				}
				int_10 = int_7;
				int_11 = int_8;
				if (int_4 < int_7 || int_4 > int_8)
				{
					int_4 = int_8;
					int_9 = int_4;
				}
				class60_0.Invalidate();
				return;
			}
			if (bool_7)
			{
				if (bool_8)
				{
					num = int_5 + (int)((double)method_12(int_4) / (double)class60_0.Width * (double)(int_6 - int_5));
					num2 = int_5 + (int)((long)e.X * (long)(int_6 - int_5) / class60_0.Width);
					int_7 = ((num < num2) ? num : num2);
					int_8 = ((num2 > num) ? num2 : num);
					if (int_7 < int_5)
					{
						int_7 = int_5;
					}
					if (int_8 > int_6)
					{
						int_8 = int_6;
					}
					int_10 = int_7;
					int_11 = int_8;
				}
				else
				{
					num = int_5 + (int)((long)(e.X - int_18) * (long)(int_6 - int_5) / class60_0.Width);
					num2 = int_5 + (int)((long)(e.X + int_17) * (long)(int_6 - int_5) / class60_0.Width);
					int num3 = ((num < num2) ? num : num2);
					int num4 = ((num2 > num) ? num2 : num);
					int num5 = num4 - num3;
					if (num3 < int_5)
					{
						num3 = int_5;
						num4 = int_5 + num5;
					}
					else if (num4 > int_6)
					{
						num4 = int_6;
						num3 = int_6 - num5;
					}
					int_7 = num3;
					int_8 = num4;
					if (int_7 < int_5)
					{
						int_7 = int_5;
					}
					if (int_8 > int_6)
					{
						int_8 = int_6;
					}
					int_4 = int_5 + (int)((long)e.X * (long)(int_6 - int_5) / class60_0.Width);
					int_10 = int_7;
					int_11 = int_8;
					int_9 = int_4;
				}
			}
			else
			{
				num = int_4;
				num2 = int_5 + (int)((long)e.X * (long)(int_6 - int_5) / class60_0.Width);
				int_7 = ((num < num2) ? num : num2);
				int_8 = ((num2 > num) ? num2 : num);
				if (int_7 < int_5)
				{
					int_7 = int_5;
				}
				if (int_8 > int_6)
				{
					int_8 = int_6;
				}
				int_10 = int_7;
				int_11 = int_8;
				int_4 = int_5 + (int)((long)int_16 * (long)(int_6 - int_5) / class60_0.Width);
				int_9 = int_4;
			}
			class60_0.Invalidate();
			return;
		}
		int num6 = int_6 - int_5;
		if (num6 == 0)
		{
			return;
		}
		int num7 = (int)((long)(int_7 - int_5) * (long)class60_0.Width / num6);
		int num8 = (int)((long)(int_8 - int_5) * (long)class60_0.Width / num6);
		_ = (long)(int_4 - int_5) * (long)class60_0.Width / num6;
		bool_5 = false;
		bool_6 = false;
		bool_7 = false;
		if (num7 != num8)
		{
			if (e.X >= num7 + 5 && e.X <= num8 - 5)
			{
				Cursor = Cursors.Default;
				bool_7 = true;
			}
			if (e.X >= num7 - 5 && e.X <= num7 + 5 && num7 != 0)
			{
				Cursor = Cursors.VSplit;
				bool_5 = true;
			}
			else if (e.X >= num8 - 5 && e.X <= num8 + 5 && num8 != class60_0.Right)
			{
				Cursor = Cursors.VSplit;
				bool_6 = true;
			}
			else
			{
				Cursor = Cursors.Default;
			}
		}
	}

	private void class60_0_MouseUp(object sender, MouseEventArgs e)
	{
		if (bool_4)
		{
			bool_8 = false;
			method_10();
			if (int_4 == int_8)
			{
				method_6();
			}
			vmethod_1(Enum35.BLX);
			bool_4 = false;
		}
	}

	private void class60_0_MouseWheel(object sender, MouseEventArgs e)
	{
		if (e.Delta > 0)
		{
			method_16(bool_11: true);
		}
		else if (e.Delta < 0)
		{
			method_16(bool_11: false);
		}
	}

	private void themedButton_3_Click(object sender, EventArgs e)
	{
		Form23.smethod_83();
	}

	private void Control3_Resize(object sender, EventArgs e)
	{
		if (!Visible)
		{
			return;
		}
		if (Height > panel_0.Height + 20)
		{
			bool_9 = false;
			class60_0.Left = 0;
			class60_0.Top = 0;
			class60_0.Width = Width;
			class60_0.Height = Height;
			panel_0.BringToFront();
			if (panel_0.Top < 0)
			{
				panel_0.Top = 0;
			}
			if (panel_0.Left < 0)
			{
				panel_0.Left = 0;
			}
		}
		else
		{
			bool_9 = true;
			panel_0.Left = 0;
			panel_0.Top = 0;
			class60_0.Left = panel_0.Right + 1;
			class60_0.Top = 0;
			class60_0.Width = Width - class60_0.Left;
			class60_0.Height = Height;
			panel_0.Show();
		}
		smethod_4(new Rectangle(0, 4, class60_0.Width, class60_0.Height - 10), 0, 0, list_3, null, null, list_4, list_7, int_5, int_6);
		Invalidate();
	}

	private void panel_0_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			panel_0.BringToFront();
			if (!bool_9)
			{
				bool_10 = true;
				int_19 = e.X;
				int_20 = e.Y;
			}
		}
	}

	private void panel_0_MouseMove(object sender, MouseEventArgs e)
	{
		int num = e.X - int_19;
		int num2 = e.Y - int_20;
		if (bool_10)
		{
			int num3 = panel_0.Left + num;
			int num4 = panel_0.Top + num2;
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (num4 < 0)
			{
				num4 = 0;
			}
			if (num3 + panel_0.Width > class60_0.Right)
			{
				num3 = class60_0.Right - panel_0.Width;
			}
			if (num4 + panel_0.Height > Bottom)
			{
				num4 = Bottom - panel_0.Height;
			}
			panel_0.Left = num3;
			panel_0.Top = num4;
		}
	}

	private void panel_0_MouseUp(object sender, MouseEventArgs e)
	{
		bool_10 = false;
	}

	internal void method_13()
	{
		if (themedButton_4.Image != null)
		{
			themedButton_4.Image.Dispose();
		}
		themedButton_4.Image = Class25.smethod_0(GeneralResources.LogPlaybackPlay, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		if (themedButton_2.Image != null)
		{
			themedButton_2.Image.Dispose();
		}
		themedButton_2.Image = Class25.smethod_0(GeneralResources.LogPlaybackPause, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		if (themedButton_5.Image != null)
		{
			themedButton_5.Image.Dispose();
		}
		themedButton_5.Image = Class25.smethod_0(GeneralResources.LogPlaybackStop, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		if (themedButton_1.Image != null)
		{
			themedButton_1.Image.Dispose();
		}
		themedButton_1.Image = Class25.smethod_0(GeneralResources.LogPlaybackDecSpeed, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		if (themedButton_0.Image != null)
		{
			themedButton_0.Image.Dispose();
		}
		themedButton_0.Image = Class25.smethod_0(GeneralResources.LogPlaybackIncSpeed, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		if (themedButton_3.Image != null)
		{
			themedButton_3.Image.Dispose();
		}
		themedButton_3.Image = Class25.smethod_0(GeneralResources.LogPlaybackExit, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
	}

	private void class60_0_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
	{
		e.IsInputKey = true;
		if ((Form23.int_0 & 0x1000) != 0)
		{
			if (e.KeyCode == Keys.Up)
			{
				method_16(bool_11: true);
			}
			else if (e.KeyCode == Keys.Down)
			{
				method_16(bool_11: false);
			}
			else if (e.Shift && e.KeyCode == Keys.Left)
			{
				method_14(Enum36.BLz, bool_11: true);
			}
			else if (e.Shift && e.KeyCode == Keys.Right)
			{
				method_14(Enum36.BLz, bool_11: false);
			}
			else if (e.Control && e.KeyCode == Keys.Left)
			{
				method_14(Enum36.BLy, bool_11: true);
			}
			else if (e.Control && e.KeyCode == Keys.Right)
			{
				method_14(Enum36.BLy, bool_11: false);
			}
			else if (e.KeyCode == Keys.Left)
			{
				method_14(Enum36.BLZ, bool_11: true);
			}
			else if (e.KeyCode == Keys.Right)
			{
				method_14(Enum36.BLZ, bool_11: false);
			}
		}
	}

	internal void method_14(Enum36 enum36_0, bool bool_11)
	{
		int num = 0;
		num = enum36_0 switch
		{
			Enum36.BLy => method_15(1), 
			Enum36.BLZ => method_15(10), 
			Enum36.BLz => method_15(50), 
			_ => 0, 
		};
		int num2 = (bool_11 ? (int_4 - num) : (int_4 + num));
		if (num2 < int_7)
		{
			int num3 = int_8 - int_7;
			int num4 = num2;
			int num5 = num2 + num3;
			if (num4 >= int_5)
			{
				int_7 = num4;
				int_8 = num5;
			}
			else
			{
				int_7 = int_5;
				int_8 = int_7 + num3;
			}
			int_4 = int_7;
		}
		else if (num2 > int_8)
		{
			int num6 = int_8 - int_7;
			int num7 = num2 - num6;
			int num8 = num2;
			if (num8 <= int_6)
			{
				int_7 = num7;
				int_8 = num8;
			}
			else
			{
				int_8 = int_6;
				int_7 = int_8 - num6;
			}
			int_4 = int_8;
		}
		else
		{
			int_4 = num2;
		}
		int_9 = int_4;
		class60_0.Invalidate();
		method_10();
		vmethod_1(Enum35.BLX);
		list_2.Clear();
		int_15 = -1;
	}

	private int method_15(int int_24)
	{
		int num = int_8 - int_7;
		if (num == 0)
		{
			return 0;
		}
		int num2 = (int)((double)int_24 / (double)class60_0.Width * (double)num);
		if (num2 != 0)
		{
			return num2;
		}
		return 1;
	}

	internal void method_16(bool bool_11)
	{
		int num = int_8 - int_7;
		int num2 = int_7;
		int num3 = int_8;
		if (bool_11)
		{
			int num4 = num >> 2;
			num2 = int_4 - num4;
			num3 = int_4 + num4;
			if (num3 - num2 <= 50)
			{
				return;
			}
		}
		else
		{
			int num5 = num >> 1;
			num2 = int_7 - num5;
			num3 = int_8 + num5;
		}
		if (num2 < int_5)
		{
			int_7 = int_5;
		}
		else
		{
			int_7 = num2;
		}
		if (num3 > int_6)
		{
			int_8 = int_6;
		}
		else
		{
			int_8 = num3;
		}
		class60_0.Invalidate();
		method_10();
		vmethod_1(Enum35.BLX);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_17()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Control3));
		label_1 = new Label();
		label_0 = new Label();
		imageList_0 = new ImageList(icontainer_0);
		contextMenuStrip_0 = new ContextMenuStrip(icontainer_0);
		toolStripMenuItem_0 = new ToolStripMenuItem();
		panel_0 = new Panel();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		themedButton_2 = new ThemedButton();
		themedButton_3 = new ThemedButton();
		themedButton_5 = new ThemedButton();
		themedButton_4 = new ThemedButton();
		class60_0 = new Class60();
		contextMenuStrip_0.SuspendLayout();
		panel_0.SuspendLayout();
		SuspendLayout();
		label_1.AutoSize = true;
		label_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_1.Location = new Point(0, 0);
		label_1.Name = Class333.smethod_498();
		label_1.Size = new Size(105, 13);
		label_1.TabIndex = 7;
		label_1.Text = Class333.smethod_499();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.Location = new Point(116, -1);
		label_0.Name = Class333.smethod_500();
		label_0.Size = new Size(124, 13);
		label_0.TabIndex = 6;
		label_0.Text = Class333.smethod_501();
		imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject(Class333.smethod_502());
		imageList_0.TransparentColor = Color.Transparent;
		imageList_0.Images.SetKeyName(0, Class333.smethod_503());
		imageList_0.Images.SetKeyName(1, Class333.smethod_504());
		imageList_0.Images.SetKeyName(2, Class333.smethod_505());
		imageList_0.Images.SetKeyName(3, Class333.smethod_506());
		imageList_0.Images.SetKeyName(4, Class333.smethod_507());
		imageList_0.Images.SetKeyName(5, Class333.smethod_508());
		imageList_0.Images.SetKeyName(6, Class333.smethod_509());
		contextMenuStrip_0.ImageScalingSize = new Size(20, 20);
		contextMenuStrip_0.Items.AddRange(toolStripMenuItem_0);
		contextMenuStrip_0.Name = Class333.smethod_510();
		contextMenuStrip_0.Size = new Size(158, 26);
		toolStripMenuItem_0.Name = Class333.smethod_511();
		toolStripMenuItem_0.Size = new Size(157, 22);
		toolStripMenuItem_0.Text = Class333.smethod_512();
		toolStripMenuItem_0.Click += toolStripMenuItem_0_Click;
		panel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		panel_0.BorderStyle = BorderStyle.FixedSingle;
		panel_0.Controls.Add(label_1);
		panel_0.Controls.Add(label_0);
		panel_0.Controls.Add(themedButton_0);
		panel_0.Controls.Add(themedButton_1);
		panel_0.Controls.Add(themedButton_2);
		panel_0.Controls.Add(themedButton_3);
		panel_0.Controls.Add(themedButton_5);
		panel_0.Controls.Add(themedButton_4);
		panel_0.Location = new Point(139, 141);
		panel_0.Name = Class333.smethod_513();
		panel_0.Size = new Size(248, 50);
		panel_0.TabIndex = 0;
		themedButton_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_0.ImageIndex = 5;
		themedButton_0.ImageList = imageList_0;
		themedButton_0.Location = new Point(160, 15);
		themedButton_0.Name = Class333.smethod_514();
		themedButton_0.Size = new Size(30, 30);
		themedButton_0.TabIndex = 5;
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		themedButton_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_1.ImageIndex = 4;
		themedButton_1.ImageList = imageList_0;
		themedButton_1.Location = new Point(124, 15);
		themedButton_1.Name = Class333.smethod_515();
		themedButton_1.Size = new Size(30, 30);
		themedButton_1.TabIndex = 4;
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		themedButton_2.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_2.ImageIndex = 2;
		themedButton_2.ImageList = imageList_0;
		themedButton_2.Location = new Point(39, 15);
		themedButton_2.Name = Class333.smethod_516();
		themedButton_2.Size = new Size(30, 30);
		themedButton_2.TabIndex = 2;
		themedButton_2.UseVisualStyleBackColor = true;
		themedButton_2.Click += themedButton_2_Click;
		themedButton_3.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_3.ImageIndex = 6;
		themedButton_3.ImageList = imageList_0;
		themedButton_3.Location = new Point(210, 15);
		themedButton_3.Name = Class333.smethod_517();
		themedButton_3.Size = new Size(30, 30);
		themedButton_3.TabIndex = 6;
		themedButton_3.UseVisualStyleBackColor = true;
		themedButton_3.Click += themedButton_3_Click;
		themedButton_5.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_5.ImageIndex = 3;
		themedButton_5.ImageList = imageList_0;
		themedButton_5.Location = new Point(75, 15);
		themedButton_5.Name = Class333.smethod_518();
		themedButton_5.Size = new Size(30, 30);
		themedButton_5.TabIndex = 3;
		themedButton_5.UseVisualStyleBackColor = true;
		themedButton_5.Click += themedButton_5_Click;
		themedButton_4.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_4.ImageIndex = 0;
		themedButton_4.ImageList = imageList_0;
		themedButton_4.Location = new Point(3, 15);
		themedButton_4.Name = Class333.smethod_519();
		themedButton_4.Size = new Size(30, 30);
		themedButton_4.TabIndex = 0;
		themedButton_4.UseVisualStyleBackColor = true;
		themedButton_4.Click += themedButton_4_Click;
		class60_0.BackColor = Color.Black;
		class60_0.BorderStyle = BorderStyle.FixedSingle;
		class60_0.ContextMenuStrip = contextMenuStrip_0;
		class60_0.Location = new Point(250, 5);
		class60_0.Name = Class333.smethod_520();
		class60_0.Size = new Size(1043, 52);
		class60_0.TabIndex = 1;
		class60_0.Paint += class60_0_Paint;
		class60_0.MouseDown += class60_0_MouseDown;
		class60_0.MouseMove += class60_0_MouseMove;
		class60_0.MouseUp += class60_0_MouseUp;
		class60_0.MouseWheel += class60_0_MouseWheel;
		class60_0.PreviewKeyDown += class60_0_PreviewKeyDown;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(class60_0);
		Controls.Add(panel_0);
		Name = Class333.smethod_521();
		Size = new Size(1296, 304);
		VisibleChanged += Control3_VisibleChanged;
		Resize += Control3_Resize;
		contextMenuStrip_0.ResumeLayout(performLayout: false);
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
