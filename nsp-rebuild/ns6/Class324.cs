using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using ns0;
using ns5;
using ns7;

namespace ns6;

internal static class Class324
{
	internal static bool smethod_0(Class320.Class321 class321_0, Class5 class5_0, BackgroundWorker backgroundWorker_0, DoWorkEventArgs doWorkEventArgs_0, Class320.Class322 class322_0, out bool bool_0)
	{
		return smethod_2(bool_0: true, bool_1: false, class321_0, class5_0, backgroundWorker_0, doWorkEventArgs_0, class322_0, out bool_0);
	}

	internal static bool smethod_1(Class320.Class321 class321_0, Class5 class5_0, BackgroundWorker backgroundWorker_0, DoWorkEventArgs doWorkEventArgs_0, Class320.Class322 class322_0)
	{
		bool bool_;
		return smethod_2(bool_0: false, bool_1: true, class321_0, class5_0, backgroundWorker_0, doWorkEventArgs_0, class322_0, out bool_);
	}

	private static bool smethod_2(bool bool_0, bool bool_1, Class320.Class321 class321_0, Class5 class5_0, BackgroundWorker backgroundWorker_0, DoWorkEventArgs doWorkEventArgs_0, Class320.Class322 class322_0, out bool bool_2)
	{
		DateTime now = DateTime.Now;
		bool bool_3 = false;
		bool_2 = true;
		foreach (Class319 item in class321_0.BTV)
		{
			bool flag = item.BdK != Enum88.avK;
			if (!string.IsNullOrEmpty(item.BdJ))
			{
				if (bool_1)
				{
					continue;
				}
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
					continue;
				}
				if (item.BdJ == Class333.aZf())
				{
					bool_3 = true;
				}
				else if (item.BdJ == Class333.aZG())
				{
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(0, num3);
					}
					if (!Class320.smethod_48(class5_0, bool_0: false))
					{
						Class320.smethod_46(class5_0);
					}
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(100, num3);
						Thread.Sleep(500);
					}
				}
				else if (item.BdJ == Class333.aZg())
				{
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(0, num3);
					}
					if (Class320.smethod_48(class5_0, bool_0: false))
					{
						Class320.smethod_47(class5_0);
					}
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(100, num3);
						Thread.Sleep(500);
					}
				}
				else if (item.BdJ == Class333.aZH())
				{
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(0, num3);
					}
					if (!smethod_4(item, class321_0))
					{
						bool_2 = false;
						string text = Class333.aZh();
						if (string.IsNullOrEmpty(class322_0.Btd))
						{
							class322_0.Btd = text;
						}
						else
						{
							class322_0.Btd = class322_0.Btd + Class333.smethod_1812() + text;
						}
						doWorkEventArgs_0.Result = class322_0;
						Class1.smethod_77(class5_0.string_0);
						return false;
					}
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(100, num3);
						Thread.Sleep(500);
					}
				}
				else
				{
					if (!(item.BdJ == Class333.aZI()))
					{
						continue;
					}
					if (item.Bdj)
					{
						backgroundWorker_0.ReportProgress(0, num3);
					}
					if (num3 == 0 || DateTime.Now - now < TimeSpan.FromMilliseconds(2000L))
					{
						Thread.Sleep(2000);
					}
					Class1.smethod_76(class5_0.string_0, 20000u);
					if (Class1.smethod_63(class5_0.string_0, out var _))
					{
						if (item.Bdj)
						{
							backgroundWorker_0.ReportProgress(100, num3);
							Thread.Sleep(500);
						}
						continue;
					}
					bool_2 = false;
					string text2 = Class333.aZi();
					if (string.IsNullOrEmpty(class322_0.Btd))
					{
						class322_0.Btd = text2;
					}
					else
					{
						class322_0.Btd = class322_0.Btd + Class333.smethod_1812() + text2;
					}
					if (item.Bdk)
					{
						doWorkEventArgs_0.Result = class322_0;
						Class1.smethod_77(class5_0.string_0);
						return false;
					}
					Thread.Sleep(500);
				}
				continue;
			}
			if (item.Bdg != null)
			{
				if ((bool_0 & flag) || (bool_1 && !flag))
				{
					continue;
				}
				string text3 = Class333.aSX();
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
					int int_ = num4 - num5;
					if (flag && class321_0.BTq == Enum88.avK && class321_0.BTV.Count - class321_0.BTv != 0 && !class321_0.BTO)
					{
						int_ += 3;
					}
					if (bool_3 && num4 >= 1 && class321_0.BTV[num4 - 1].Bdj)
					{
						int_--;
					}
					backgroundWorker_0.ReportProgress(0, int_);
					text3 = class321_0.BTW[int_];
					if ((!flag) ? smethod_3(item, class321_0, ref bool_3, backgroundWorker_0, ref int_) : smethod_6(item, class321_0, backgroundWorker_0, int_))
					{
						backgroundWorker_0.ReportProgress(100, int_);
						Thread.Sleep(500);
						continue;
					}
					bool_2 = false;
					string text4 = (text3.EndsWith(Class333.smethod_134()) ? text3.Substring(0, text3.Length - 1) : text3);
					if (flag)
					{
						string text5 = Class333.aZJ() + text4 + Class333.aZj();
						if (string.IsNullOrEmpty(class322_0.BtE))
						{
							class322_0.BtE = text5;
						}
						else
						{
							class322_0.BtE = class322_0.BtE + Class333.smethod_1812() + text5;
						}
						continue;
					}
					if (!item.Bdk)
					{
						string text6 = Class333.aZJ() + text4 + Class333.aZj();
						if (!string.IsNullOrEmpty(item.BdL))
						{
							text6 = text6 + Class333.smethod_570() + item.BdL;
						}
						if (string.IsNullOrEmpty(class322_0.Btd))
						{
							class322_0.Btd = text6;
						}
						else
						{
							class322_0.Btd = class322_0.Btd + Class333.smethod_1812() + text6;
						}
						Thread.Sleep(500);
						continue;
					}
					string text7 = Class333.aZK() + text4;
					if (string.IsNullOrEmpty(class322_0.Btd))
					{
						class322_0.Btd = text7;
					}
					else
					{
						class322_0.Btd = class322_0.Btd + Class333.smethod_1812() + text7;
					}
					doWorkEventArgs_0.Result = class322_0;
					Class1.smethod_77(class5_0.string_0);
					return false;
				}
				if (!flag)
				{
					bool_3 = false;
					int num6 = class321_0.BTV.IndexOf(item);
					int int_;
					if (item.BdG.BDu == Enum112.BDL)
					{
						bool_3 = true;
						int_ = num6;
						backgroundWorker_0.ReportProgress(0, int_);
					}
					else
					{
						if (!class321_0.BTw || !class321_0.BTX)
						{
							int_ = num6;
						}
						else
						{
							int_ = ((num6 >= class321_0.BTW.Count - 5) ? (1 + num6) : num6);
						}
						if (item.BdG.BDu == Enum112.BDn)
						{
							if (int_ == 0 || DateTime.Now - now < TimeSpan.FromMilliseconds(2000L))
							{
								Thread.Sleep(2000);
							}
							Class1.smethod_76(class5_0.string_0, 20000u);
							if (!Class1.smethod_63(class5_0.string_0, out var _))
							{
								bool_2 = false;
								class322_0.Btd = Class333.aZL();
								doWorkEventArgs_0.Result = class322_0;
								Class1.smethod_77(class5_0.string_0);
								return false;
							}
						}
						backgroundWorker_0.ReportProgress(0, int_);
					}
					text3 = class321_0.BTW[int_];
					if (smethod_3(item, class321_0, ref bool_3, backgroundWorker_0, ref int_))
					{
						backgroundWorker_0.ReportProgress(100, int_);
						Thread.Sleep(500);
						if (smethod_4(item, class321_0))
						{
							continue;
						}
						bool_2 = false;
						class322_0.Btd = Class333.aZM();
						doWorkEventArgs_0.Result = class322_0;
						Class1.smethod_77(class5_0.string_0);
						return false;
					}
					bool_2 = false;
					string text8 = (text3.EndsWith(Class333.smethod_134()) ? text3.Substring(0, text3.Length - 1) : text3);
					class322_0.Btd = Class333.aZl() + text8;
					doWorkEventArgs_0.Result = class322_0;
					Class1.smethod_77(class5_0.string_0);
					return false;
				}
				bool_2 = false;
				class322_0.BtE = Class333.aZk();
				doWorkEventArgs_0.Result = class322_0;
				Class1.smethod_77(class5_0.string_0);
				return false;
			}
			if (flag)
			{
				class322_0.BtE = Class333.aZm();
			}
			else
			{
				class322_0.Btd = Class333.aZN();
			}
			bool_2 = false;
			doWorkEventArgs_0.Result = class322_0;
			Class1.smethod_77(class5_0.string_0);
			return false;
		}
		if (bool_1)
		{
			return bool_2;
		}
		return true;
	}

	private static bool smethod_3(Class319 class319_0, Class320.Class321 class321_0, ref bool bool_0, BackgroundWorker backgroundWorker_0, ref int int_0)
	{
		uint num = (uint)class319_0.Bdg.Length;
		uint bDW = class319_0.BdG.BDW;
		uint bdh = class319_0.Bdh;
		uint bDx = class319_0.BdG.BDx;
		Class5 bTm = class321_0.BTm;
		Class1.smethod_76(bTm.string_0, bDx);
		uint num2 = 0u;
		while (true)
		{
			if (num2 < num / bdh)
			{
				byte[] array = new byte[bdh];
				Array.Copy(class319_0.Bdg, num2 * bdh, array, 0L, bdh);
				bool bool_2;
				if (bool_0)
				{
					lock (bTm)
					{
						Class1.smethod_42(bTm.string_0, Enum10.const_0, bDW + num2 * bdh, array, out var _);
						bool_2 = false;
						for (int i = 0; i < 13; i++)
						{
							if (Class1.smethod_43(bTm.string_0, out bool_2))
							{
								break;
							}
							backgroundWorker_0.ReportProgress(i * 3, int_0);
						}
					}
					backgroundWorker_0.ReportProgress(100, int_0);
					Thread.Sleep(500);
					bool_0 = false;
					int_0++;
				}
				else
				{
					bool_2 = Class1.smethod_39(bTm.string_0, Enum10.const_0, bDW + num2 * bdh, array, out var _);
				}
				if (!bool_2)
				{
					break;
				}
				int percentProgress = (int)((long)(100 * num2) * (long)bdh / num);
				backgroundWorker_0.ReportProgress(percentProgress, int_0);
				num2++;
				continue;
			}
			uint num3 = num % bdh;
			if (num3 != 0)
			{
				byte[] array2 = new byte[num3];
				Array.Copy(class319_0.Bdg, num2 * bdh, array2, 0L, num3);
				bool bool_2;
				if (!(bool_2 = Class1.smethod_39(bTm.string_0, Enum10.const_0, bDW + num2 * bdh, array2, out var _)))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	private static bool smethod_4(Class319 class319_0, Class320.Class321 class321_0)
	{
		if (class319_0.BdI != byte.MaxValue || (class319_0.BdG != null && (class319_0.BdG.BDu == Enum112.BDL || class319_0.BdG.BDu == Enum112.BDl || class319_0.BdG.BDu == Enum112.BDs)))
		{
			Class5 bTm = class321_0.BTm;
			Class1.smethod_76(bTm.string_0, 2000u);
			byte b = byte.MaxValue;
			uint uint_ = 0u;
			int int_ = 0;
			byte[] array = null;
			if (class319_0.BdI != byte.MaxValue)
			{
				b = class319_0.BdI;
				int num = class321_0.BTV.IndexOf(class319_0) - 1;
				while (num >= 0)
				{
					if (class321_0.BTV[num].Bdg == null || class321_0.BTV[num].BdG == null)
					{
						num--;
						continue;
					}
					uint_ = class321_0.BTV[num].BdG.BDW;
					int_ = class321_0.BTV[num].Bdg.Length;
					array = class321_0.BTV[num].BdG.BDY;
					break;
				}
			}
			else
			{
				b = ((class319_0.BdG.BDu == Enum112.BDl) ? ((byte)1) : ((byte)0));
				uint_ = class319_0.BdG.BDW;
				int_ = class319_0.Bdg.Length;
				array = class319_0.BdG.BDY;
			}
			if (array == null || !Class1.smethod_65(bTm.string_0, b, uint_, int_, array, out var _))
			{
				return false;
			}
		}
		return true;
	}

	internal static uint smethod_5(Enum88 enum88_0, bool bool_0)
	{
		if ((enum88_0 == Enum88.avx) & bool_0)
		{
			return 393216u;
		}
		switch (enum88_0)
		{
		case Enum88.avn:
		case Enum88.avO:
		case Enum88.avp:
		case Enum88.avQ:
		case Enum88.avq:
			return 262144u;
		default:
			return 0u;
		case Enum88.avk:
		case Enum88.avL:
		case Enum88.avl:
		case Enum88.avM:
		case Enum88.avm:
		case Enum88.avN:
		case Enum88.avU:
		case Enum88.avu:
		case Enum88.avV:
		case Enum88.avv:
		case Enum88.avW:
		case Enum88.avw:
		case Enum88.avX:
		case Enum88.avx:
			return 0u;
		}
	}

	private static bool smethod_6(Class319 class319_0, Class320.Class321 class321_0, BackgroundWorker backgroundWorker_0, int int_0)
	{
		Class5 bTm = class321_0.BTm;
		uint num = (uint)class319_0.Bdg.Length;
		uint num2 = smethod_5(class319_0.BdK, class321_0.BTQ);
		uint num3 = num2;
		bool bool_ = false;
		byte[] byte_ = null;
		byte[] byte_2 = new byte[14]
		{
			0,
			16,
			(byte)(num2 >> 24),
			(byte)(num2 >> 16),
			(byte)(num2 >> 8),
			(byte)num2,
			(byte)(num >> 24),
			(byte)(num >> 16),
			(byte)(num >> 8),
			(byte)num,
			(byte)(num3 >> 24),
			(byte)(num3 >> 16),
			(byte)(num3 >> 8),
			(byte)num3
		};
		if (Class1.smethod_38(bTm.string_0, (byte)class319_0.BdK, Enum10.const_0, 0u, byte_2, out bool_))
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Restart();
			while (true)
			{
				if (stopwatch.ElapsedMilliseconds < 10000L)
				{
					if (Class1.smethod_49(bTm.string_0, (byte)class319_0.BdK, out byte_, out bool_) && byte_.Length != 0)
					{
						if (byte_[0] == 2)
						{
							backgroundWorker_0.ReportProgress(Math.Min(5, (int)(stopwatch.ElapsedMilliseconds * 5L / 1000L)), int_0);
							Thread.Sleep(10);
							continue;
						}
						backgroundWorker_0.ReportProgress(5, int_0);
						break;
					}
					return false;
				}
				byte_ = null;
				break;
			}
		}
		if (byte_ != null && byte_.Length != 0 && byte_[0] == 0)
		{
			uint bdh = class319_0.Bdh;
			uint bDx = class319_0.BdG.BDx;
			uint bDW = class319_0.BdG.BDW;
			Class1.smethod_76(bTm.string_0, bDx);
			uint num4 = 0u;
			while (true)
			{
				if (num4 < num / bdh)
				{
					byte[] array = new byte[bdh];
					Array.Copy(class319_0.Bdg, num4 * bdh, array, 0L, bdh);
					if (!Class1.smethod_38(bTm.string_0, (byte)class319_0.BdK, Enum10.const_0, bDW + num4 * bdh, array, out bool_))
					{
						break;
					}
					int percentProgress = 5 + (int)((long)(95 * num4) * (long)bdh / num);
					backgroundWorker_0.ReportProgress(percentProgress, int_0);
					num4++;
					continue;
				}
				uint num5 = num % bdh;
				if (num5 != 0)
				{
					byte[] array2 = new byte[num5];
					Array.Copy(class319_0.Bdg, num4 * bdh, array2, 0L, num5);
					if (!Class1.smethod_38(bTm.string_0, (byte)class319_0.BdK, Enum10.const_0, bDW + num4 * bdh, array2, out bool_))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
		return false;
	}
}
