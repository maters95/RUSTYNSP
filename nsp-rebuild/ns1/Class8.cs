using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using FTD2XX_NET;
using ns0;
using ns7;

namespace ns1;

internal class Class8 : IDisposable, Interface2
{
	private enum Enum13
	{
		Btn,
		BtO,
		Bto,
		BtP
	}

	private const int BfC = 50;

	private const uint Bfc = 65536u;

	private const byte BfD = 2;

	private FTDI Bfd = new FTDI();

	private FTDI.FT_STATUS BfE = FTDI.FT_STATUS.FT_DEVICE_NOT_FOUND;

	private byte Bfe;

	private string BfF = string.Empty;

	private Enum13 Bff;

	private uint BfG = uint.MaxValue;

	private const uint Bfg = 10u;

	private uint BfH = 10u;

	private const uint Bfh = 5u;

	private uint[,] BfI = new uint[5, 2];

	private uint Bfi;

	private uint BfJ = 1000u;

	private uint Bfj = 50u;

	private bool BfK = true;

	private string Bfk;

	[CompilerGenerated]
	private EventHandler BfL;

	[CompilerGenerated]
	private EventHandler Bfl;

	[CompilerGenerated]
	private EventHandler BfM;

	[CompilerGenerated]
	private bool Bfm;

	public override string ToString()
	{
		return Class333.azl() + Bfk;
	}

	public bool imethod_0(List<string> list_0)
	{
		return method_0(list_0, null);
	}

	private bool method_0(List<string> list_0, string string_0)
	{
		if (list_0 == null)
		{
			Class1.smethod_86(Class333.azM());
		}
		else
		{
			Class1.smethod_86(Class333.azm());
		}
		uint devcount = 0u;
		int num = 5;
		do
		{
			BfE = Bfd.GetNumberOfDevices(ref devcount);
			if (BfE == FTDI.FT_STATUS.FT_OK)
			{
				break;
			}
			num--;
			Thread.Sleep(100);
		}
		while (num > 0);
		FTDI.FT_DEVICE_INFO_NODE[] array = null;
		if (devcount != 0)
		{
			num = 5;
			bool flag;
			do
			{
				try
				{
					array = new FTDI.FT_DEVICE_INFO_NODE[devcount];
					BfE = Bfd.GetDeviceList(array);
					flag = BfE == FTDI.FT_STATUS.FT_OK;
				}
				catch
				{
					BfE = Bfd.GetNumberOfDevices(ref devcount);
					flag = false;
				}
				if (!flag)
				{
					num--;
					Thread.Sleep(100);
				}
			}
			while (num > 0 && !flag);
			for (uint num2 = 0u; num2 < array.Length; num2++)
			{
				if (array[num2] == null)
				{
					continue;
				}
				if (array[num2].ID == 382734023 && array[num2].SerialNumber.EndsWith(Class333.smethod_1331()))
				{
					Bff = Enum13.BtO;
					string text = array[num2].SerialNumber.Remove(array[num2].SerialNumber.Length - 1);
					if (!string.IsNullOrEmpty(string_0) && string_0.Remove(string_0.Length - 1) != text)
					{
						continue;
					}
					uint num3 = 0u;
					uint num4;
					for (num4 = 0u; num4 < array.Length; num4++)
					{
						if (array[num4].ID == 382734023 && text.Equals(array[num4].SerialNumber.Remove(array[num4].SerialNumber.Length - 1)))
						{
							num3++;
							if ((array[num4].Flags & 1) == 1)
							{
								break;
							}
						}
					}
					if (num4 < array.Length)
					{
						continue;
					}
					switch (num3)
					{
					case 2u:
						Bfk = text + Class333.smethod_100() + array[num2].ID + Class333.smethod_100() + array[num2].LocId;
						if (list_0 != null && list_0.Contains(Bfk))
						{
							continue;
						}
						if (Bfd.IsOpen)
						{
							BfE = method_4();
						}
						if (BfE == FTDI.FT_STATUS.FT_OK || !Bfd.IsOpen)
						{
							string text2 = text + Class333.smethod_1331();
							string text3 = text + Class333.smethod_2242();
							BfE = Bfd.OpenBySerialNumber(text2);
							if (!Bfd.IsOpen || BfE != FTDI.FT_STATUS.FT_OK)
							{
								continue;
							}
							BfF = text2;
							Bfe = 0;
							BfE = Bfd.SetBitMode(byte.MaxValue, Bfe);
							BfE = method_4();
							if (BfE == FTDI.FT_STATUS.FT_OK || !Bfd.IsOpen)
							{
								BfE = Bfd.OpenBySerialNumber(text3);
								if (!Bfd.IsOpen || BfE != FTDI.FT_STATUS.FT_OK)
								{
									continue;
								}
								BfF = text3;
								Bfe = 0;
								BfE = Bfd.SetBitMode(byte.MaxValue, Bfe);
								BfE = Bfd.SetLatency(2);
								BfE = Bfd.InTransferSize(65536u);
								BfE = Bfd.SetFlowControl(256, 0, 0);
								imethod_13();
								method_1();
								Class1.smethod_86(Class333.azo());
								return true;
							}
							Class1.smethod_86(Class333.azO());
						}
						else
						{
							Class1.smethod_86(Class333.azO());
						}
						break;
					case 0u:
					case 1u:
						Class1.smethod_86(Class333.azN());
						break;
					default:
						Class1.smethod_86(Class333.azn());
						break;
					}
					break;
				}
				bool flag2 = array[num2].ID == 382734086;
				bool flag3 = array[num2].ID == 67330068 && array[num2].Description.Contains(Class333.azP());
				if (!(flag2 | flag3))
				{
					continue;
				}
				if (flag2)
				{
					Bff = Enum13.Bto;
				}
				else if (flag3)
				{
					Bff = Enum13.BtP;
				}
				if (!string.IsNullOrEmpty(string_0) && string_0 != array[num2].SerialNumber)
				{
					continue;
				}
				BfF = array[num2].SerialNumber;
				Bfk = BfF + Class333.smethod_100() + array[num2].ID + Class333.smethod_100() + array[num2].LocId;
				if (list_0 == null || !list_0.Contains(Bfk))
				{
					if (Bfd.IsOpen)
					{
						BfE = method_4();
					}
					if (BfE != FTDI.FT_STATUS.FT_OK && Bfd.IsOpen)
					{
						Class1.smethod_86(Class333.azO());
						break;
					}
					BfE = Bfd.OpenByIndex(num2);
					if (Bfd.IsOpen && BfE == FTDI.FT_STATUS.FT_OK)
					{
						Bfe = 0;
						BfE = Bfd.SetBitMode(byte.MaxValue, Bfe);
						BfE = Bfd.SetLatency(2);
						BfE = Bfd.InTransferSize(65536u);
						BfE = Bfd.SetFlowControl(256, 0, 0);
						imethod_13();
						method_1();
						Class1.smethod_86(Class333.azo());
						return true;
					}
				}
			}
		}
		else if (list_0 == null && string_0 != null)
		{
			Class1.smethod_86(Class333.azp());
		}
		if (list_0 == null && string_0 != null)
		{
			string text4 = string.Empty;
			try
			{
				if (array != null && array.Length != 0)
				{
					for (uint num5 = 0u; num5 < array.Length; num5++)
					{
						text4 = ((array[num5] == null) ? (text4 + Class333.azQ() + num5 + Class333.azS()) : (text4 + Class333.azQ() + num5 + Class333.azq() + array[num5].Description + Class333.azR() + array[num5].Flags + Class333.azr() + array[num5].SerialNumber));
					}
				}
			}
			catch
			{
			}
			Class1.smethod_86(Class333.azs() + Bfd.IsOpen + text4);
		}
		return false;
	}

	public void imethod_1()
	{
	}

	public bool imethod_2(Class5 class5_0)
	{
		if (Bff == Enum13.BtO)
		{
			if (class5_0.byte_7 == 0)
			{
				int num = 5;
				do
				{
					if (Bfd.IsOpen)
					{
						BfE = method_4();
					}
					if (BfE == FTDI.FT_STATUS.FT_OK || !Bfd.IsOpen)
					{
						string text = BfF.Remove(BfF.Length - 1) + Class333.smethod_1331();
						BfE = Bfd.OpenBySerialNumber(text);
						if (!Bfd.IsOpen || BfE != FTDI.FT_STATUS.FT_OK)
						{
							num--;
							continue;
						}
						BfF = text;
						Bfe = 64;
						BfE = Bfd.SetBitMode(byte.MaxValue, Bfe);
						BfE = Bfd.SetLatency(2);
						BfE = Bfd.InTransferSize(65536u);
						BfE = Bfd.SetFlowControl(256, 0, 0);
						imethod_13();
						method_1();
						break;
					}
					Class1.smethod_86(Class333.azT());
					return false;
				}
				while (num > 0);
				if (num == 0)
				{
					Class1.smethod_86(Class333.azt() + BfE.ToString() + Class333.azU());
					return false;
				}
			}
		}
		else if (Bff == Enum13.Bto)
		{
		}
		Class1.smethod_86(Class333.azu());
		return true;
	}

	public bool imethod_3()
	{
		if (Bfd.IsOpen && !imethod_4())
		{
			Class1.smethod_86(Class333.azV());
			return false;
		}
		int num = 5;
		do
		{
			if (!method_0(null, BfF))
			{
				num--;
				if (Bfd.IsOpen)
				{
					BfE = method_4();
				}
				if (BfE != FTDI.FT_STATUS.FT_OK && Bfd.IsOpen)
				{
					Class1.smethod_86(Class333.azV());
					break;
				}
				continue;
			}
			return true;
		}
		while (num > 0);
		Class1.smethod_86(Class333.azv());
		return false;
	}

	private void method_1(int int_0 = 0)
	{
		if (int_0 > 0)
		{
			Thread.Sleep(int_0);
		}
		if (Bfd.IsOpen)
		{
			BfE = Bfd.Purge(3u);
		}
	}

	public void imethod_23()
	{
		Thread.Sleep(5);
		while (method_2())
		{
			uint numBytesRead = 0u;
			BfE = Bfd.Read(new byte[65536], 65536u, ref numBytesRead);
			if (numBytesRead == 0)
			{
				break;
			}
			Thread.Sleep(5);
		}
		method_1();
	}

	public bool imethod_24()
	{
		return BfK;
	}

	public bool imethod_25()
	{
		return false;
	}

	public void imethod_26()
	{
		BfG = uint.MaxValue;
		BfH = 10u;
		for (int i = 0; i < 5L; i++)
		{
			BfI[i, 0] = 10u;
			BfI[i, 1] = 0u;
		}
		BfJ = 1000u;
		if (!BfK)
		{
			BfK = true;
			if (BfM != null)
			{
				BfM(this, EventArgs.Empty);
			}
		}
	}

	public void imethod_27()
	{
		BfG = 512u;
		BfH = 0u;
		for (int i = 0; i < 5L; i++)
		{
			BfI[i, 0] = 0u;
			BfI[i, 1] = 0u;
		}
		BfJ = 0u;
		if (BfK)
		{
			BfK = false;
			if (Bfl != null)
			{
				Bfl(this, EventArgs.Empty);
			}
		}
	}

	public void imethod_28(int int_0, int int_1)
	{
		BfI[Bfi, 0] = (uint)int_0;
		BfI[Bfi, 1] = (uint)int_1;
		Bfi = (Bfi + 1) % 5;
		uint num = 0u;
		uint num2 = 0u;
		for (int i = 0; i < 5L; i++)
		{
			num += BfI[i, 0];
			num2 += BfI[i, 1];
		}
		if (num != 0)
		{
			uint num3 = 0u;
			if (num2 <= num)
			{
				num3 = num - num2;
			}
			BfJ = num3 * 1000 / num;
		}
		else
		{
			BfJ = 1000u;
		}
		if (BfJ == 1000)
		{
			BfH++;
			if (BfH >= 10 && BfG != uint.MaxValue)
			{
				if (BfG >= 8192)
				{
					BfG = uint.MaxValue;
				}
				else if (BfG == 1008)
				{
					BfG = 2048u;
				}
				else
				{
					BfG *= 2u;
				}
			}
		}
		else
		{
			BfH = 0u;
		}
	}

	public void imethod_20(bool bool_0)
	{
		if (!bool_0 && BfG != 512)
		{
			if (BfG == uint.MaxValue)
			{
				BfG = 8192u;
			}
			else if (BfG > 2048)
			{
				BfG /= 2u;
			}
			else
			{
				BfG = 1008u;
			}
		}
	}

	public void imethod_21(ref uint uint_0)
	{
	}

	public uint imethod_22()
	{
		return BfG;
	}

	public uint imethod_29()
	{
		return BfJ;
	}

	public uint[,] imethod_30()
	{
		return BfI;
	}

	public uint imethod_31()
	{
		return Bfi;
	}

	public uint imethod_32()
	{
		return BfH;
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_6(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BfL;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BfL, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_7(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BfL;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BfL, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_8(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = Bfl;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref Bfl, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_9(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = Bfl;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref Bfl, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_10(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BfM;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BfM, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_11(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BfM;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BfM, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	public string imethod_5()
	{
		return Bfk;
	}

	public void imethod_12(uint uint_0)
	{
		Bfj = uint_0;
		BfE = Bfd.SetTimeouts(Bfj, Bfj);
	}

	public void imethod_13()
	{
		imethod_12(50u);
	}

	[SpecialName]
	[CompilerGenerated]
	public bool imethod_14()
	{
		return Bfm;
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_15(bool bool_0)
	{
		Bfm = bool_0;
	}

	private bool method_2()
	{
		bool flag = false;
		if (Bfd.IsOpen)
		{
			flag = true;
		}
		else if (!string.IsNullOrEmpty(BfF))
		{
			int num = 5;
			do
			{
				try
				{
					Class1.smethod_86(Class333.azW() + BfF);
					BfE = Bfd.OpenBySerialNumber(BfF);
					if (Bfd.IsOpen && BfE == FTDI.FT_STATUS.FT_OK)
					{
						flag = true;
						BfE = Bfd.SetBitMode(byte.MaxValue, Bfe);
						BfE = Bfd.SetLatency(2);
						BfE = Bfd.InTransferSize(65536u);
						BfE = Bfd.SetFlowControl(256, 0, 0);
						imethod_12(Bfj);
					}
				}
				catch
				{
					flag = false;
				}
				if (!flag)
				{
					Thread.Sleep(100);
					num--;
					Class1.smethod_86(Class333.azw() + num + Class333.smethod_54());
				}
			}
			while (num != 0 && !flag);
			if (flag)
			{
				Class1.smethod_86(Class333.azX() + num + Class333.smethod_54());
			}
		}
		else
		{
			Class1.smethod_86(Class333.azx());
		}
		if (!flag)
		{
			Class1.smethod_86(Class333.azY());
		}
		return flag;
	}

	public bool imethod_16(byte[] byte_0, uint uint_0, out uint uint_1)
	{
		if (!method_2())
		{
			if (BfL != null)
			{
				BfL(this, EventArgs.Empty);
			}
			uint_1 = 0u;
			return false;
		}
		uint num = (uint_0 - 1) / 65536 + 1;
		uint num2 = 0u;
		uint num3 = uint_0;
		uint_1 = 0u;
		uint num4 = 0u;
		FTDI.FT_STATUS bfE;
		while (true)
		{
			if (num4 < num)
			{
				uint num5 = ((num3 <= 65536) ? num3 : 65536u);
				byte[] array;
				if (uint_0 <= 65536)
				{
					array = byte_0;
				}
				else
				{
					array = new byte[num5];
					Array.Copy(byte_0, num2, array, 0L, num5);
				}
				uint numBytesWritten = 0u;
				int num6 = 5;
				do
				{
					BfE = Bfd.Write(array, num5, ref numBytesWritten);
					bfE = BfE;
					if (bfE != FTDI.FT_STATUS.FT_OK && numBytesWritten == 0)
					{
						num6--;
						if (num6 != 0)
						{
							method_1(80);
						}
					}
				}
				while (bfE != FTDI.FT_STATUS.FT_OK && numBytesWritten == 0 && num6 != 0);
				if (numBytesWritten == 0)
				{
					break;
				}
				num2 += numBytesWritten;
				num3 -= numBytesWritten;
				num4++;
				continue;
			}
			uint_1 = num2;
			return true;
		}
		method_1();
		if (bfE != FTDI.FT_STATUS.FT_OK)
		{
			Class1.smethod_86(Class333.azy() + bfE.ToString() + Class333.azZ());
			if (BfL != null)
			{
				BfL(this, EventArgs.Empty);
			}
		}
		else if (!imethod_14() && BfK)
		{
			BfK = false;
			Class1.smethod_86(Class333.azz());
			if (Bfl != null)
			{
				Bfl(this, EventArgs.Empty);
			}
		}
		return false;
	}

	public bool method_3(ref byte[] byte_0, out uint uint_0)
	{
		if (!method_2())
		{
			if (BfL != null)
			{
				BfL(this, EventArgs.Empty);
			}
			uint_0 = 0u;
			return false;
		}
		uint RxQueue = 0u;
		uint num = 0u;
		bool flag = false;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		do
		{
			BfE = Bfd.GetRxBytesAvailable(ref RxQueue);
			flag = RxQueue != 0 && RxQueue == num;
			num = RxQueue;
			if (RxQueue == 0)
			{
				Thread.Sleep(0);
			}
			else if (!flag)
			{
				Thread.Sleep(20);
			}
		}
		while (stopwatch.ElapsedMilliseconds < Bfj && !flag);
		stopwatch.Stop();
		uint_0 = 0u;
		if (RxQueue != 0 && RxQueue <= byte_0.Length)
		{
			return imethod_17(ref byte_0, RxQueue, out uint_0, 0);
		}
		return false;
	}

	public bool imethod_17(ref byte[] byte_0, uint uint_0, out uint uint_1, byte byte_1)
	{
		if (!method_2())
		{
			if (BfL != null)
			{
				BfL(this, EventArgs.Empty);
			}
			uint_1 = 0u;
			return false;
		}
		uint num = (uint_0 - 1) / 65536 + 1;
		uint num2 = 0u;
		uint num3 = uint_0;
		uint_1 = 0u;
		uint num4 = 0u;
		FTDI.FT_STATUS bfE;
		while (true)
		{
			if (num4 < num)
			{
				uint num5 = ((num3 <= 65536) ? num3 : 65536u);
				byte[] array = ((uint_0 > 65536) ? new byte[num5] : byte_0);
				uint numBytesRead = 0u;
				int num6 = 5;
				do
				{
					BfE = Bfd.Read(array, num5, ref numBytesRead);
					bfE = BfE;
					if (bfE != FTDI.FT_STATUS.FT_OK && numBytesRead == 0)
					{
						num6--;
						if (num6 != 0)
						{
							method_1(80);
						}
					}
				}
				while (bfE != FTDI.FT_STATUS.FT_OK && numBytesRead == 0 && num6 != 0);
				if (numBytesRead == 0)
				{
					break;
				}
				if (!BfK)
				{
					BfK = true;
					Class1.smethod_86(Class333.BAB());
					if (BfM != null)
					{
						BfM(this, EventArgs.Empty);
					}
				}
				if (byte_0.Length > 65536L)
				{
					Array.Copy(array, 0L, byte_0, num2, numBytesRead);
				}
				num2 += numBytesRead;
				num3 -= numBytesRead;
				num4++;
				continue;
			}
			uint_1 = num2;
			return true;
		}
		method_1();
		if (bfE != FTDI.FT_STATUS.FT_OK)
		{
			Class1.smethod_86(Class333.BAA() + bfE.ToString() + Class333.azZ());
			if (BfL != null)
			{
				BfL(this, EventArgs.Empty);
			}
		}
		else if (!imethod_14() && BfK)
		{
			BfK = false;
			Class1.smethod_86(Class333.BAa());
			if (Bfl != null)
			{
				Bfl(this, EventArgs.Empty);
			}
		}
		return false;
	}

	public uint imethod_18()
	{
		return 65536u;
	}

	public bool imethod_19()
	{
		return true;
	}

	private FTDI.FT_STATUS method_4()
	{
		int num = 2;
		do
		{
			try
			{
				if (Bfd.IsOpen)
				{
					return Bfd.Close();
				}
				return FTDI.FT_STATUS.FT_OK;
			}
			catch
			{
				Thread.Sleep(20);
				num--;
			}
		}
		while (num != 0);
		return FTDI.FT_STATUS.FT_OTHER_ERROR;
	}

	public bool imethod_4()
	{
		return method_4() == FTDI.FT_STATUS.FT_OK;
	}

	public void Dispose()
	{
		imethod_4();
	}
}
