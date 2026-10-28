using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns5;
using ns7;

namespace ns6;

internal class Class284
{
	internal enum Enum109
	{
		BsO,
		Bso
	}

	private Stopwatch BCp = new Stopwatch();

	internal MemoryStream BCQ;

	internal string BCq = string.Empty;

	private ZipArchive BCR;

	private ZipArchiveEntry BCr;

	private Stream BCS;

	private object BCs = new object();

	private List<Setting> BCT = new List<Setting>();

	internal List<string> BCt = new List<string>();

	private string BCU;

	private string BCu;

	private Enum109 BCV;

	private int BCv;

	internal Class284(Enum109 enum109_0)
	{
		BCV = enum109_0;
		if (enum109_0 == Enum109.Bso)
		{
			BCv = 2048;
			BCu = Class333.aVv();
			BCU = Class333.aVW();
		}
		else
		{
			BCv = 1024;
			BCu = Class333.smethod_1893();
			BCU = Class333.aVw();
		}
	}

	internal void method_0()
	{
		string text = method_5();
		method_1();
		string text2 = BCU + Class23.smethod_10(bool_1: false);
		string text3 = text2 + Class333.smethod_488();
		if (File.Exists(text + Class333.smethod_176() + text3))
		{
			text2 = BCU + Class23.smethod_10(bool_1: true);
			text3 = text2 + Class333.smethod_488();
		}
		try
		{
			BCQ = new MemoryStream();
			BCq = text + Class333.smethod_176() + text3;
			BCR = new ZipArchive(BCQ, ZipArchiveMode.Create);
			Stream stream = BCR.CreateEntry(text2 + Class242.smethod_8(Form23.framework_1.awZ, Form23.framework_1.awz, Form23.framework_1.aXA) + Class333.smethod_146()).Open();
			string text4 = Form23.string_2 + Class333.smethod_522() + Form23.string_18 + Class333.smethod_176() + BCU + Class333.aVX();
			new Class297(text4, Form23.framework_1, bool_0: true).method_0();
			byte[] array = File.ReadAllBytes(text4);
			foreach (byte value in array)
			{
				stream.WriteByte(value);
			}
			File.Delete(text4);
			stream.Close();
			BCr = BCR.CreateEntry(text2 + Class333.smethod_489());
			BCS = BCr.Open();
			BCS.WriteByte(1);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(73);
			BCS.WriteByte(72);
			BCS.WriteByte(65);
			BCS.WriteByte(76);
			BCS.WriteByte(84);
			BCS.WriteByte(69);
			BCS.WriteByte(67);
			BCS.WriteByte(72);
			BCS.WriteByte(49);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			if (!string.IsNullOrEmpty(Form23.framework_1.aXc) && Form23.framework_1.aXc.Length <= 32)
			{
				for (int j = 0; j < Form23.framework_1.aXc.Length; j++)
				{
					BCS.WriteByte((byte)Form23.framework_1.aXc[j]);
				}
				for (int k = Form23.framework_1.aXc.Length; k < 32; k++)
				{
					BCS.WriteByte(0);
				}
			}
			else
			{
				for (int l = 0; l < 32; l++)
				{
					BCS.WriteByte(0);
				}
			}
			DateTime now = DateTime.Now;
			BCS.WriteByte((byte)now.Hour);
			BCS.WriteByte((byte)now.Minute);
			BCS.WriteByte((byte)now.Second);
			BCS.WriteByte(0);
			BCS.WriteByte((byte)((now.Year >> 8) & 0xFF));
			BCS.WriteByte((byte)(now.Year & 0xFF));
			BCS.WriteByte((byte)now.Month);
			BCS.WriteByte((byte)now.Day);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(6);
			BCT.Clear();
			foreach (Setting item in Form23.framework_1.aWt)
			{
				if (item.method_35() && item.method_184() && !item.method_212() && PortFunction.smethod_52(item))
				{
					BCT.Add(item);
				}
			}
			uint num = (uint)(5 + 2 * BCT.Count);
			BCS.WriteByte((byte)((num >> 24) & 0xFF));
			BCS.WriteByte((byte)((num >> 16) & 0xFF));
			BCS.WriteByte((byte)((num >> 8) & 0xFF));
			BCS.WriteByte((byte)(num & 0xFF));
			List<ushort> list = new List<ushort>();
			foreach (Setting item2 in BCT)
			{
				ushort num2 = (ushort)item2.method_64();
				BCS.WriteByte((byte)((num2 >> 8) & 0xFF));
				BCS.WriteByte((byte)(num2 & 0xFF));
				list.Add(num2);
			}
			List<List<ushort>> list2 = new List<List<ushort>>();
			list2.Add(list);
			smethod_0(BCS, list2);
			if (!BCp.IsRunning)
			{
				BCp.Start();
			}
			else
			{
				BCp.Restart();
			}
			lock (Form23.object_1)
			{
				Form23.int_0 |= BCv;
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aVx() + ex.Message);
		}
	}

	internal void method_1()
	{
		if ((Form23.int_0 & BCv) != 0)
		{
			lock (Form23.object_1)
			{
				Form23.int_0 &= ~BCv;
			}
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += method_2;
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void method_2(object sender, DoWorkEventArgs e)
	{
		if (BCQ == null || BCS == null)
		{
			return;
		}
		Thread.Sleep(500);
		try
		{
			BCS.Close();
		}
		catch
		{
		}
		BCS = null;
		try
		{
			BCR.Dispose();
		}
		catch
		{
		}
		BCR = null;
		BCT.Clear();
		try
		{
			using (FileStream stream_ = new FileStream(BCq, FileMode.Create))
			{
				Class35.smethod_0(BCQ.ToArray(), Class19.smethod_3(), stream_, Class35.byte_1);
			}
			BCQ.Close();
			BCQ.Dispose();
		}
		catch
		{
		}
		BCQ = null;
		BCt.Add(BCq);
		int num = BCq.IndexOf(Class333.smethod_176() + BCu + Class333.smethod_176()) + (Class333.smethod_176() + BCu + Class333.smethod_176()).Length;
		if (num == (Class333.smethod_176() + BCu + Class333.smethod_176()).Length - 1)
		{
			num = BCq.IndexOf(Form23.string_18) + Form23.string_18.Length;
		}
		if (num != Form23.string_18.Length - 1)
		{
			string string_ = BCq.Substring(0, num);
			string string_2 = BCq.Substring(num, BCq.Length - num - Class333.smethod_488().Length);
			Form10.smethod_36(string_, string_2, null, -1);
		}
		BCq = string.Empty;
	}

	internal static void smethod_0(Stream stream_0, List<List<ushort>> list_0)
	{
		bool flag = list_0.Count > 16;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Count == 0)
			{
				continue;
			}
			uint num = 0u;
			uint num2 = 0u;
			if (flag)
			{
				stream_0.WriteByte(13);
			}
			else
			{
				stream_0.WriteByte((byte)(9 | (byte)(16 * i)));
			}
			num2++;
			do
			{
				foreach (ushort item in list_0[i])
				{
					Setting setting = Form23.framework_1.method_31(item);
					if (num != 0)
					{
						ushort num3 = 0;
						if (setting != null)
						{
							num3 = (ushort)setting.method_231();
						}
						stream_0.WriteByte((byte)((num3 >> 8) & 0xFF));
						stream_0.WriteByte((byte)(num3 & 0xFF));
					}
					else
					{
						num2 += 2;
					}
					if (num != 0)
					{
						sbyte b = 0;
						if (setting != null)
						{
							b = (sbyte)setting.method_232();
						}
						stream_0.WriteByte((byte)b);
					}
					else
					{
						num2++;
					}
					if (num != 0)
					{
						int num4 = 0;
						int num5 = 0;
						if (setting != null && setting.method_207())
						{
							num4 = setting.method_226();
							num5 = setting.method_227();
						}
						stream_0.WriteByte((byte)((num4 >> 24) & 0xFF));
						stream_0.WriteByte((byte)((num4 >> 16) & 0xFF));
						stream_0.WriteByte((byte)((num4 >> 8) & 0xFF));
						stream_0.WriteByte((byte)(num4 & 0xFF));
						stream_0.WriteByte((byte)((num5 >> 24) & 0xFF));
						stream_0.WriteByte((byte)((num5 >> 16) & 0xFF));
						stream_0.WriteByte((byte)((num5 >> 8) & 0xFF));
						stream_0.WriteByte((byte)(num5 & 0xFF));
					}
					else
					{
						num2 += 8;
					}
					string text = ((setting == null) ? Class333.smethod_575() : setting.method_60(Enum96.aYT));
					if (num != 0)
					{
						for (int j = 0; j < text.Length; j++)
						{
							stream_0.WriteByte((byte)text[j]);
						}
						stream_0.WriteByte(0);
					}
					else
					{
						num2 += (uint)(text.Length + 1);
					}
					string text2 = ((setting == null) ? Class333.smethod_574() : setting.method_22(bool_0: true));
					if (num != 0)
					{
						for (int k = 0; k < text2.Length; k++)
						{
							stream_0.WriteByte((byte)text2[k]);
						}
						stream_0.WriteByte(0);
					}
					else
					{
						num2 += (uint)(text2.Length + 1);
					}
					string text3 = ((setting == null) ? Class333.smethod_91() : setting.method_60(Enum96.aYU));
					if (num != 0)
					{
						for (int l = 0; l < text3.Length; l++)
						{
							stream_0.WriteByte((byte)text3[l]);
						}
						stream_0.WriteByte(0);
					}
					else
					{
						num2 += (uint)(text3.Length + 1);
					}
				}
				if (num == 0)
				{
					if (flag)
					{
						num2 += 2;
					}
					num2 += 4;
					stream_0.WriteByte((byte)((num2 >> 24) & 0xFF));
					stream_0.WriteByte((byte)((num2 >> 16) & 0xFF));
					stream_0.WriteByte((byte)((num2 >> 8) & 0xFF));
					stream_0.WriteByte((byte)(num2 & 0xFF));
					if (flag)
					{
						stream_0.WriteByte((byte)(((ushort)i >> 8) & 0xFF));
						stream_0.WriteByte((byte)((ushort)i & 0xFF));
					}
				}
				num++;
			}
			while (num < 2);
		}
	}

	internal void method_3()
	{
		if (BCT.Count == 0)
		{
			return;
		}
		lock (BCs)
		{
			if (BCQ == null || BCS == null)
			{
				return;
			}
			BCS.WriteByte(7);
			uint num = (uint)(9 + 4 * BCT.Count);
			BCS.WriteByte((byte)((num >> 24) & 0xFF));
			BCS.WriteByte((byte)((num >> 16) & 0xFF));
			BCS.WriteByte((byte)((num >> 8) & 0xFF));
			BCS.WriteByte((byte)(num & 0xFF));
			uint num2 = (uint)(BCp.ElapsedMilliseconds & 0xFFFFFFFFL);
			BCS.WriteByte((byte)((num2 >> 24) & 0xFF));
			BCS.WriteByte((byte)((num2 >> 16) & 0xFF));
			BCS.WriteByte((byte)((num2 >> 8) & 0xFF));
			BCS.WriteByte((byte)(num2 & 0xFF));
			bool flag = Form23.smethod_28(Form23.framework_1.aXc, bool_53: true);
			byte[] array = new byte[BCT.Count * 4];
			int num3 = 0;
			for (int i = 0; i < BCT.Count; i++)
			{
				if (flag)
				{
					Setting setting = BCT[i];
					if (Form23.framework_1.aWR)
					{
						for (int j = 0; j < 4; j++)
						{
							array[num3] = setting.method_254(j);
							num3++;
						}
						continue;
					}
					for (int num4 = 3; num4 >= 0; num4--)
					{
						array[num3] = setting.method_254(num4);
						num3++;
					}
				}
				else
				{
					for (int k = 0; k < 4; k++)
					{
						array[num3] = 0;
						num3++;
					}
				}
			}
			BCS.Write(array, 0, array.Length);
		}
	}

	internal void method_4(uint[,] uint_0, ushort ushort_0)
	{
		lock (BCs)
		{
			if (BCQ == null || BCS == null)
			{
				return;
			}
			BCS.WriteByte(10);
			BCS.WriteByte(0);
			BCS.WriteByte(0);
			BCS.WriteByte(62);
			BCS.WriteByte(139);
			uint num = (uint)(BCp.ElapsedMilliseconds & 0xFFFFFFFFL);
			BCS.WriteByte((byte)((num >> 24) & 0xFF));
			BCS.WriteByte((byte)((num >> 16) & 0xFF));
			BCS.WriteByte((byte)((num >> 8) & 0xFF));
			BCS.WriteByte((byte)(num & 0xFF));
			BCS.WriteByte((byte)((ushort_0 >> 8) & 0xFF));
			BCS.WriteByte((byte)(ushort_0 & 0xFF));
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 1000; j++)
				{
					BCS.WriteByte((byte)((uint_0[i, j] >> 24) & 0xFF));
					BCS.WriteByte((byte)((uint_0[i, j] >> 16) & 0xFF));
					BCS.WriteByte((byte)((uint_0[i, j] >> 8) & 0xFF));
					BCS.WriteByte((byte)(uint_0[i, j] & 0xFF));
				}
			}
		}
	}

	private string method_5()
	{
		string string_ = string.Empty;
		if (Form23.framework_1.method_28(ref string_))
		{
			string text = Form23.smethod_99(string_, Form23.framework_1.aXc);
			if (string.IsNullOrEmpty(text))
			{
				try
				{
					text = Form23.smethod_100(string_, new List<string> { Form23.framework_1.aXc });
					Form23.framework_1.aXD = text;
					string text2 = text + Class333.smethod_176() + BCu;
					if (!Directory.Exists(text2))
					{
						Directory.CreateDirectory(text2);
					}
					return text2;
				}
				catch
				{
					return Form23.string_2 + Class333.smethod_522() + Form23.string_18;
				}
			}
			string text3 = text + Class333.smethod_176() + BCu;
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			return text3;
		}
		return Form23.string_2 + Class333.smethod_522() + Form23.string_18;
	}

	internal void method_6()
	{
		if (BCV == Enum109.BsO)
		{
			return;
		}
		string path = Form23.string_2 + Class333.smethod_522() + Form23.string_18;
		string[] array = null;
		try
		{
			array = Directory.GetFiles(path, BCU + Class333.aVY(), SearchOption.AllDirectories);
		}
		catch
		{
			return;
		}
		if (array == null)
		{
			return;
		}
		string[] array2 = array;
		foreach (string path2 in array2)
		{
			if (File.GetLastWriteTimeUtc(path2).AddDays(Form10.int_19) < DateTime.UtcNow && File.Exists(path2))
			{
				try
				{
					File.Delete(path2);
				}
				catch
				{
				}
			}
		}
	}
}
