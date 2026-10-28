using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using HaltechComms;
using ns0;
using ns7;

namespace ns1;

internal class Class11 : IDisposable, Interface2
{
	private SerialPort BGm;

	private const int BGN = 200;

	private uint BGn = 200u;

	private const int BGO = 30;

	private int BGo;

	private bool BGP = true;

	private string BGp;

	[CompilerGenerated]
	private EventHandler BGQ;

	[CompilerGenerated]
	private EventHandler BGq;

	[CompilerGenerated]
	private EventHandler BGR;

	[CompilerGenerated]
	private bool BGr;

	public override string ToString()
	{
		return Class333.BAb() + BGp;
	}

	private bool method_0(string string_0)
	{
		try
		{
			BGm = new SerialPort(string_0);
			if (BGm != null)
			{
				imethod_12(BGn);
				BGm.ReadBufferSize = 32768;
				BGm.WriteBufferSize = 32768;
				BGm.Open();
				return true;
			}
			return false;
		}
		catch
		{
			BGm = null;
			return false;
		}
	}

	public bool imethod_0(List<string> list_0)
	{
		string[] array = method_1();
		try
		{
			List<string> list = new List<string>(SerialPort.GetPortNames());
			List<string> list2;
			if (array != null && array.Length != 0)
			{
				list2 = new List<string>();
				string[] array2 = array;
				foreach (string item in array2)
				{
					if (list.Contains(item))
					{
						list2.Add(item);
					}
				}
				foreach (string item2 in list)
				{
					if (!list2.Contains(item2))
					{
						list2.Add(item2);
					}
				}
			}
			else
			{
				list2 = list;
			}
			List<Win32DeviceMgmt.DeviceInfo> deviceInfoPerCOMPort = Win32DeviceMgmt.GetDeviceInfoPerCOMPort();
			foreach (string item3 in list2)
			{
				foreach (Win32DeviceMgmt.DeviceInfo item4 in deviceInfoPerCOMPort)
				{
					if (item4.Name == item3)
					{
						if ((item4.BusDescription.Contains(Class333.smethod_733()) || item4.Description.Contains(Class333.smethod_733())) && item4.BusDescription.ToUpper() != Class333.BAC())
						{
							BGp = item3;
							if ((list_0 == null || !list_0.Contains(BGp)) && method_0(BGp))
							{
								return true;
							}
							break;
						}
						break;
					}
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void imethod_1()
	{
		method_3();
	}

	public bool imethod_2(Class5 class5_0)
	{
		method_2();
		return true;
	}

	private string[] method_1()
	{
		string[] result = null;
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (!Directory.Exists(folderPath + Class333.smethod_557()))
			{
				Directory.CreateDirectory(folderPath + Class333.smethod_557());
			}
			else
			{
				string path = folderPath + Class333.BAc();
				if (File.Exists(path))
				{
					result = File.ReadAllLines(path);
				}
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	private void method_2()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (!Directory.Exists(folderPath + Class333.smethod_557()))
			{
				Directory.CreateDirectory(folderPath + Class333.smethod_557());
			}
			string path = folderPath + Class333.BAc();
			if (File.Exists(path))
			{
				if (!new List<string>(File.ReadAllLines(path)).Contains(BGp))
				{
					string[] contents = new string[1] { BGp };
					File.AppendAllLines(path, contents);
				}
			}
			else
			{
				string[] contents2 = new string[1] { BGp };
				File.WriteAllLines(path, contents2);
			}
		}
		catch
		{
		}
	}

	private void method_3()
	{
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class333.BAc();
			if (File.Exists(path))
			{
				List<string> list = new List<string>(File.ReadAllLines(path));
				if (list.Contains(BGp))
				{
					list.Remove(BGp);
					File.WriteAllLines(path, list);
				}
			}
		}
		catch
		{
		}
	}

	public bool imethod_3()
	{
		if (BGm != null)
		{
			if (imethod_4())
			{
				BGm.Dispose();
				return method_0(BGp);
			}
			return false;
		}
		return method_0(BGp);
	}

	private void method_4(int int_0 = 0)
	{
		if (int_0 > 0)
		{
			Thread.Sleep(int_0);
		}
		if (BGm != null && BGm.IsOpen)
		{
			try
			{
				BGm.DiscardInBuffer();
				BGm.DiscardOutBuffer();
			}
			catch
			{
			}
		}
	}

	public void imethod_23()
	{
		if (BGm == null)
		{
			return;
		}
		Thread.Sleep(5);
		try
		{
			while (method_5())
			{
				int num;
				try
				{
					num = BGm.Read(new byte[1024], 0, 1024);
				}
				catch
				{
					num = 0;
				}
				if (num != 0)
				{
					Thread.Sleep(5);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		method_4();
	}

	public bool imethod_24()
	{
		return BGP;
	}

	public bool imethod_25()
	{
		return false;
	}

	public void imethod_26()
	{
		if (!BGP)
		{
			BGP = true;
			if (BGR != null)
			{
				BGR(this, EventArgs.Empty);
			}
		}
	}

	public void imethod_27()
	{
		if (BGP)
		{
			BGP = false;
			if (BGq != null)
			{
				BGq(this, EventArgs.Empty);
			}
		}
	}

	public void imethod_28(int int_0, int int_1)
	{
	}

	public uint imethod_29()
	{
		return 1000u;
	}

	public uint[,] imethod_30()
	{
		return null;
	}

	public uint imethod_31()
	{
		return 0u;
	}

	public uint imethod_32()
	{
		return 0u;
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_6(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BGQ;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BGQ, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_7(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BGQ;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BGQ, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_8(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BGq;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BGq, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_9(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BGq;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BGq, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_10(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BGR;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BGR, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_11(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BGR;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BGR, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	public string imethod_5()
	{
		return BGp;
	}

	public void imethod_12(uint uint_0)
	{
		BGn = uint_0;
		if (BGm != null)
		{
			try
			{
				BGm.ReadTimeout = (int)BGn;
				BGm.WriteTimeout = (int)BGn;
			}
			catch
			{
			}
		}
	}

	public void imethod_13()
	{
		imethod_12(200u);
	}

	[SpecialName]
	[CompilerGenerated]
	public bool imethod_14()
	{
		return BGr;
	}

	[SpecialName]
	[CompilerGenerated]
	public void imethod_15(bool bool_0)
	{
		BGr = bool_0;
	}

	private bool method_5()
	{
		bool flag = false;
		if (BGm != null)
		{
			if (BGm.IsOpen)
			{
				flag = true;
			}
			else
			{
				try
				{
					Class1.smethod_86(Class333.BAD());
					BGm.Open();
					flag = BGm.IsOpen;
				}
				catch
				{
					flag = false;
				}
			}
		}
		if (!flag)
		{
			Class1.smethod_86(Class333.BAd());
		}
		return flag;
	}

	public bool imethod_16(byte[] byte_0, uint uint_0, out uint uint_1)
	{
		if (!method_5())
		{
			if (!imethod_14() && BGQ != null)
			{
				BGQ(this, EventArgs.Empty);
			}
			uint_1 = 0u;
			return false;
		}
		try
		{
			BGm.Write(byte_0, 0, (int)uint_0);
			uint_1 = uint_0;
			return true;
		}
		catch (Exception ex)
		{
			if (ex is TimeoutException)
			{
				BGo++;
			}
			method_4();
			if (!imethod_14())
			{
				if (BGm != null && BGm.IsOpen && Enumerable.Contains(SerialPort.GetPortNames(), BGm.PortName))
				{
					if (BGo > 30 && BGP)
					{
						BGP = false;
						Class1.smethod_86(Class333.BAe());
						if (BGq != null)
						{
							BGq(this, EventArgs.Empty);
						}
					}
				}
				else
				{
					Class1.smethod_86(Class333.BAE());
					if (BGQ != null)
					{
						BGQ(this, EventArgs.Empty);
					}
				}
			}
			uint_1 = 0u;
			return false;
		}
	}

	public bool imethod_17(ref byte[] byte_0, uint uint_0, out uint uint_1, byte byte_1)
	{
		if (!method_5())
		{
			if (!imethod_14() && BGQ != null)
			{
				BGQ(this, EventArgs.Empty);
			}
			uint_1 = 0u;
			return false;
		}
		try
		{
			int num = 0;
			int num2 = 0;
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			do
			{
				if (BGm != null)
				{
					num = BGm.BytesToRead;
				}
				flag = num != 0 && (num == num2 || num >= uint_0);
				num2 = num;
				if (num == 0)
				{
					Thread.Sleep(0);
				}
				else if (!flag)
				{
					Thread.Sleep(20);
				}
			}
			while (stopwatch.ElapsedMilliseconds < BGn && !flag);
			stopwatch.Stop();
			if (num < uint_0)
			{
				throw new TimeoutException(Class333.BAF());
			}
			uint_1 = (uint)BGm.Read(byte_0, 0, (int)uint_0);
			BGo = 0;
			if (!BGP)
			{
				BGP = true;
				Class1.smethod_86(Class333.BAf());
				if (BGR != null)
				{
					BGR(this, EventArgs.Empty);
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			if (ex is TimeoutException)
			{
				BGo++;
			}
			method_4();
			if (!imethod_14())
			{
				if (BGm != null && BGm.IsOpen && Enumerable.Contains(SerialPort.GetPortNames(), BGm.PortName))
				{
					if (BGo > 30 && BGP)
					{
						BGP = false;
						Class1.smethod_86(Class333.BAg());
						if (BGq != null)
						{
							BGq(this, EventArgs.Empty);
						}
					}
				}
				else
				{
					Class1.smethod_86(Class333.BAG());
					if (BGQ != null)
					{
						BGQ(this, EventArgs.Empty);
					}
				}
			}
			uint_1 = 0u;
			return false;
		}
	}

	public uint imethod_18()
	{
		return uint.MaxValue;
	}

	public bool imethod_19()
	{
		return true;
	}

	public void imethod_20(bool bool_0)
	{
	}

	public void imethod_21(ref uint uint_0)
	{
	}

	public uint imethod_22()
	{
		return uint.MaxValue;
	}

	public bool imethod_4()
	{
		try
		{
			if (BGm.IsOpen)
			{
				BGm.Close();
				while (BGm.IsOpen)
				{
					Thread.Sleep(50);
				}
			}
			return !BGm.IsOpen;
		}
		catch
		{
			return false;
		}
	}

	public void Dispose()
	{
		if (BGm != null)
		{
			try
			{
				imethod_4();
				BGm.Dispose();
			}
			catch
			{
			}
			BGm = null;
		}
	}
}
