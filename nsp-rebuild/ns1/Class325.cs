using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using ns0;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal static class Class325
{
	internal static bool smethod_0(Class320.Class321 class321_0, Class5 class5_0, BackgroundWorker backgroundWorker_0, DoWorkEventArgs doWorkEventArgs_0, Class320.Class322 class322_0, out bool bool_0)
	{
		bool_0 = false;
		bool bool_1 = false;
		int int_ = 65535;
		foreach (Class319 item in class321_0.BTV)
		{
			if (!string.IsNullOrEmpty(item.BdJ))
			{
				int num = class321_0.BTV.IndexOf(item);
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					if (!class321_0.BTV[i].Bdj)
					{
						num2++;
					}
				}
				int num3 = num - num2;
				if (item.BdJ == Class333.aZF())
				{
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(0, num3);
					}
					bool_1 = false;
					int_ = 65535;
					if (num + 1 >= class321_0.BTV.Count)
					{
						class322_0.Btd = Class333.ayc();
						doWorkEventArgs_0.Result = class322_0;
						Class1.smethod_77(class5_0.string_0);
						return false;
					}
					if (!smethod_1(class321_0.BTV[num + 1], class321_0, backgroundWorker_0, num3, ref bool_1, ref int_))
					{
						class322_0.Btd = Class333.ayc();
						doWorkEventArgs_0.Result = class322_0;
						Class1.smethod_77(class5_0.string_0);
						return false;
					}
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(100, num3);
					}
				}
				else if (item.BdJ == Class333.aZG())
				{
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(0, num3);
					}
					if (!Class320.smethod_48(class5_0))
					{
						Class320.smethod_46(class5_0);
					}
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(100, num3);
					}
				}
				else if (item.BdJ == Class333.aZg())
				{
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(0, num3);
					}
					if (Class320.smethod_48(class5_0))
					{
						Class320.smethod_47(class5_0);
					}
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(100, num3);
					}
				}
				continue;
			}
			if (item.Bdg != null)
			{
				bool flag;
				if (flag = item.BdK != Enum88.avK)
				{
					continue;
				}
				if (item.BdG.BDU >= 2)
				{
					int num4 = class321_0.BTV.IndexOf(item);
					int num5 = 0;
					for (int j = 0; j < num4; j++)
					{
						if (!class321_0.BTV[j].Bdj)
						{
							num5++;
						}
					}
					int int_2 = num4 - num5;
					if (smethod_2(item, class321_0, backgroundWorker_0, int_2, bool_1, int_))
					{
						continue;
					}
					class322_0.Btd = Class333.ayc();
					doWorkEventArgs_0.Result = class322_0;
					Class1.smethod_77(class5_0.string_0);
					return false;
				}
				if (!flag)
				{
					int int_2 = class321_0.BTV.IndexOf(item) * 2;
					bool_1 = false;
					int_ = 65535;
					if (smethod_1(item, class321_0, backgroundWorker_0, int_2, ref bool_1, ref int_))
					{
						int_2++;
						if (smethod_2(item, class321_0, backgroundWorker_0, int_2, bool_1, int_))
						{
							continue;
						}
						class322_0.Btd = Class333.ayc();
						doWorkEventArgs_0.Result = class322_0;
						Class1.smethod_77(class5_0.string_0);
						return false;
					}
					class322_0.Btd = Class333.ayc();
					doWorkEventArgs_0.Result = class322_0;
					Class1.smethod_77(class5_0.string_0);
					return false;
				}
				class322_0.Btd = Class333.aZk();
				doWorkEventArgs_0.Result = class322_0;
				Class1.smethod_77(class5_0.string_0);
				return false;
			}
			class322_0.Btd = Class333.aZN();
			doWorkEventArgs_0.Result = class322_0;
			Class1.smethod_77(class5_0.string_0);
			return false;
		}
		bool_0 = true;
		return true;
	}

	private static bool smethod_1(Class319 class319_0, Class320.Class321 class321_0, BackgroundWorker backgroundWorker_0, int int_0, ref bool bool_0, ref int int_1)
	{
		backgroundWorker_0.ReportProgress(0, int_0);
		Class5 bTm = class321_0.BTm;
		if (!Class320.smethod_48(bTm) && !Class320.smethod_46(bTm))
		{
			return false;
		}
		uint bDx = class319_0.BdG.BDx;
		Class1.smethod_76(bTm.string_0, bDx);
		if (smethod_3(class319_0, bTm, out var int_2))
		{
			int_1 = int_2;
			bool_0 = int_1 != 65535;
			if (!smethod_4(class319_0, bTm, 0))
			{
				Class23.smethod_3(Class333.aZO());
				return false;
			}
			if (!smethod_5(bTm, backgroundWorker_0, int_0))
			{
				Class23.smethod_3(Class333.aZo());
				return false;
			}
			return true;
		}
		Class23.smethod_3(Class333.aZn());
		return false;
	}

	private static bool smethod_2(Class319 class319_0, Class320.Class321 class321_0, BackgroundWorker backgroundWorker_0, int int_0, bool bool_0, int int_1)
	{
		backgroundWorker_0.ReportProgress(0, int_0);
		Class5 bTm = class321_0.BTm;
		if (!smethod_6(class319_0, bTm, backgroundWorker_0, int_0, bool_0, int_1))
		{
			Class23.smethod_3(Class333.aZP());
			return false;
		}
		if (!smethod_4(class319_0, bTm, 1))
		{
			Class23.smethod_3(Class333.aZp());
			return false;
		}
		bool flag;
		if (class319_0.BdG.BDU >= 2)
		{
			int num = class321_0.BTV.IndexOf(class319_0);
			int count = class321_0.BTV.Count;
			flag = num == count - class321_0.BTv - 1;
		}
		else
		{
			flag = class319_0.BdG.BDu == Enum112.BDo || class319_0.BdG.BDu == Enum112.BDQ;
		}
		if (!flag && class319_0.BdK == Enum88.avK && !smethod_7(bTm))
		{
			return false;
		}
		backgroundWorker_0.ReportProgress(100, int_0);
		return true;
	}

	private static bool smethod_3(Class319 class319_0, Class5 class5_0, out int int_0)
	{
		int_0 = 65535;
		byte byte_;
		if (class319_0.BdG.BDU >= 2)
		{
			byte_ = class319_0.BdG.BDV;
		}
		else if (class319_0.BdG.BDu != Enum112.BDP && class319_0.BdG.BDu != Enum112.BDq)
		{
			if (class319_0.BdG.BDu != Enum112.BDo && class319_0.BdG.BDu != Enum112.BDQ)
			{
				return false;
			}
			byte_ = byte.MaxValue;
		}
		else
		{
			byte_ = 130;
		}
		uint bDW = class319_0.BdG.BDW;
		uint uint_ = (uint)class319_0.Bdg.Length;
		if (!Class1.smethod_69(class5_0.string_0, byte_, bDW, uint_, bDW, (byte)class319_0.BdG.BDv.method_0(), (byte)class319_0.BdG.BDv.method_1(), (byte)class319_0.BdG.BDv.method_2(), (byte)class319_0.BdG.BDv.method_3(), out int_0))
		{
			return false;
		}
		return true;
	}

	private static bool smethod_4(Class319 class319_0, Class5 class5_0, byte byte_0)
	{
		byte byte_1 = 0;
		bool flag = false;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		do
		{
			if (!(flag = Class1.smethod_72(class5_0.string_0, byte_0, byte_1, (byte)class319_0.BdG.BDv.method_0(), (byte)class319_0.BdG.BDv.method_1(), (byte)class319_0.BdG.BDv.method_2(), (byte)class319_0.BdG.BDv.method_3())))
			{
				Thread.Sleep(0);
			}
		}
		while (!flag && stopwatch.ElapsedMilliseconds < 6000L);
		stopwatch.Stop();
		if (!flag)
		{
			return false;
		}
		return true;
	}

	private static bool smethod_5(Class5 class5_0, BackgroundWorker backgroundWorker_0, int int_0)
	{
		int num = 10;
		bool flag = false;
		do
		{
			Class1.smethod_70(class5_0.string_0);
			backgroundWorker_0.ReportProgress(50, int_0);
			Thread.Sleep(200);
			if (Class1.smethod_71(class5_0.string_0))
			{
				flag = true;
			}
			num--;
		}
		while (num > 0 && !flag);
		if (!flag)
		{
			return false;
		}
		backgroundWorker_0.ReportProgress(100, int_0);
		return true;
	}

	private static bool smethod_6(Class319 class319_0, Class5 class5_0, BackgroundWorker backgroundWorker_0, int int_0, bool bool_0, int int_1)
	{
		uint num = (uint)class319_0.Bdg.Length;
		uint num2 = 0u;
		int num3 = 0;
		uint num4;
		if (class319_0.BdG.BDU >= 2)
		{
			num4 = class319_0.Bdh;
		}
		else if (class319_0.BdG.BDu != Enum112.BDP && class319_0.BdG.BDu != Enum112.BDq)
		{
			if (class319_0.BdG.BDu != Enum112.BDo && class319_0.BdG.BDu != Enum112.BDQ)
			{
				return false;
			}
			num4 = 80u;
		}
		else
		{
			num4 = 94u;
		}
		while (true)
		{
			List<uint> list = new List<uint>();
			List<byte[]> list2 = new List<byte[]>();
			List<uint> list3 = new List<uint>();
			int num5 = 28;
			for (int i = 0; i < num5; i++)
			{
				if (num2 >= num)
				{
					break;
				}
				uint num7;
				if (bool_0)
				{
					uint num6 = (num2 / (uint)int_1 + 1) * (uint)int_1;
					num7 = ((num2 + num4 <= num6) ? Math.Min(num - num2, num4) : Math.Min(num - num2, num6 - num2));
				}
				else
				{
					num7 = Math.Min(num - num2, num4);
				}
				byte[] array = new byte[num7];
				Array.Copy(class319_0.Bdg, num2, array, 0L, num7);
				list.Add(num2);
				list2.Add(array);
				list3.Add(num7);
				num2 += num7;
			}
			if (!Class1.smethod_68(class5_0.string_0, list, list2, list3))
			{
				break;
			}
			int num8 = (int)(100 * num2 / num);
			if (num8 != num3)
			{
				backgroundWorker_0.ReportProgress(num8, int_0);
				num3 = num8;
			}
			if (num2 >= num)
			{
				return true;
			}
		}
		return false;
	}

	private static bool smethod_7(Class5 class5_0)
	{
		Class23.smethod_3(Class333.aZQ() + class5_0.string_0 + Class333.smethod_9());
		Class1.smethod_44(class5_0.string_0);
		Thread.Sleep(700);
		Class5 @class = Class1.smethod_28(class5_0.string_0);
		if (@class != null)
		{
			if (Class320.smethod_48(@class))
			{
				Class23.smethod_3(Class333.aZq() + class5_0.string_0 + Class333.smethod_9());
				return true;
			}
			Class23.smethod_3(Class333.aZR() + class5_0.string_0 + Class333.aZr());
			Form23.smethod_32(bool_53: false);
			return false;
		}
		Class23.smethod_3(Class333.aZR() + class5_0.string_0 + Class333.aZS());
		Form23.smethod_32(bool_53: false);
		return false;
	}
}
