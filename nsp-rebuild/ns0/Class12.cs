using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using ns7;

namespace ns0;

internal class Class12
{
	private struct Struct5
	{
		public string BGV;

		public string BGv;

		public bool BGW;
	}

	private enum Enum17
	{
		BGw = 16,
		BGX = 32,
		BGx = 255
	}

	private struct Struct6
	{
		public byte[] BGY;

		public uint BGy;
	}

	[CompilerGenerated]
	private sealed class Class13
	{
		public string BGZ;

		internal void method_0(object sender, DataReceivedEventArgs e)
		{
			BGZ += e.Data;
		}
	}

	private const uint uint_0 = 1472u;

	private const uint uint_1 = 508u;

	private const uint uint_2 = 8832u;

	private const uint uint_3 = 1472u;

	private const uint uint_4 = 17u;

	private const uint uint_5 = 0u;

	private const uint uint_6 = 2u;

	private const uint uint_7 = 3u;

	private const uint uint_8 = 4u;

	private const uint uint_9 = 5u;

	private const uint uint_10 = 6u;

	private const uint uint_11 = 7u;

	private const uint uint_12 = 1u;

	private const uint uint_13 = 8u;

	private const int int_0 = 32;

	private const int int_1 = 3;

	private UdpClient udpClient_0;

	private IPEndPoint ipendPoint_0;

	private Enum11 enum11_0;

	private string string_0;

	private int int_2;

	private ManagementClass managementClass_0 = new ManagementClass(Class333.smethod_89());

	internal Class12(Enum11 enum11_1, string string_1, int int_3)
	{
		enum11_0 = enum11_1;
		string_0 = string_1;
		int_2 = int_3;
	}

	private bool method_0(out string[] string_1)
	{
		ManagementObjectCollection instances = managementClass_0.GetInstances();
		List<string> list = new List<string>();
		bool result = true;
		foreach (ManagementObject item in instances)
		{
			if ((bool)item[Class333.smethod_90()])
			{
				string text = item[Class333.smethod_91()].ToString().ToLower();
				if ((enum11_0 == Enum11.const_2 && text.Contains(Class333.smethod_92())) || (enum11_0 == Enum11.const_1 && (text.Contains(Class333.smethod_93()) || text.Contains(Class333.smethod_94()) || text.Contains(Class333.smethod_70()))))
				{
					list.Add(item[Class333.smethod_95()].ToString());
				}
			}
		}
		string_1 = list.ToArray();
		if (list.Count == 0)
		{
			result = false;
		}
		return result;
	}

	internal bool method_1(List<string> list_0, ref string string_1)
	{
		if (method_0(out var string_2))
		{
			udpClient_0 = new UdpClient(0);
			if (IPAddress.TryParse(string_0, out IPAddress address))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
				defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_96());
				defaultInterpolatedStringHandler.AppendFormatted(address);
				Class1.smethod_86(defaultInterpolatedStringHandler.ToStringAndClear());
				ipendPoint_0 = new IPEndPoint(address, int_2);
			}
			else
			{
				Class1.smethod_86(Class333.smethod_97());
			}
			if (enum11_0 == Enum11.const_2)
			{
				if (string_2 != null && string_2.Length != 0)
				{
					string_1 = Class333.smethod_98() + string_2[0];
				}
			}
			else
			{
				if (enum11_0 != Enum11.const_1)
				{
					throw new Exception(Class333.smethod_101());
				}
				if (string_2 != null && string_2.Length != 0)
				{
					string_1 = Class333.smethod_99() + string_2[0] + Class333.smethod_100();
					if (!method_2(ref string_1, string_2[0]))
					{
						string_1 = string.Empty;
					}
				}
			}
			if (!string.IsNullOrEmpty(string_1) && !list_0.Contains(string_1))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool method_2(ref string string_1, string string_2)
	{
		if (method_3(ref string_1))
		{
			return true;
		}
		if (method_4(ref string_1, string_2))
		{
			return true;
		}
		return false;
	}

	private bool method_3(ref string string_1)
	{
		bool result = false;
		byte[] byte_ = new byte[8];
		byte[] byte_2 = new byte[32];
		smethod_1(ref byte_, 0u, Enum17.BGX, 165, 1, 1);
		uint num = 0u;
		uint num2 = 0u;
		for (uint num3 = 0u; num3 < 1; num3++)
		{
			try
			{
				num = (uint)udpClient_0.Send(byte_, byte_.Length, ipendPoint_0);
			}
			catch
			{
				num = 0u;
			}
			num2 = ((num != 0) ? method_8(ref byte_2, 0u, 165, 30u) : 0u);
			if (num2 != 0)
			{
				break;
			}
		}
		if (num2 != 0)
		{
			string text = Class333.smethod_102();
			byte[] array = byte_2;
			foreach (byte b in array)
			{
				text += b.ToString(Class333.smethod_103());
			}
			string_1 += text;
			result = true;
		}
		return result;
	}

	private bool method_4(ref string string_1, string string_2)
	{
		bool result = false;
		Process process = new Process();
		process.StartInfo = smethod_0(Class333.smethod_104(), Class333.smethod_105());
		string BGZ = null;
		process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
		{
			BGZ += e.Data;
		};
		try
		{
			process.Start();
			process.BeginErrorReadLine();
			string input = process.StandardOutput.ReadToEnd();
			Thread.Sleep(100);
			process.WaitForExit();
			_ = process.ExitCode;
			string pattern = Class333.smethod_106();
			string[] array = Regex.Split(input, pattern);
			string[] array2 = new string[array.Length];
			uint num = 0u;
			for (uint num2 = 0u; num2 < array.Length - 1; num2++)
			{
				if (Regex.IsMatch(array[num2], pattern))
				{
					array2[num] = array[num2 + 1];
					num2++;
					num++;
				}
			}
			Struct5[] array3 = new Struct5[num];
			for (uint num3 = 0u; num3 < num; num3++)
			{
				array3[num3].BGW = false;
				if (Regex.IsMatch(array2[num3], Class333.smethod_107()) && Regex.IsMatch(array2[num3], Class333.smethod_108()) && Regex.IsMatch(array2[num3], Class333.smethod_109()))
				{
					MatchCollection matchCollection = new Regex(Class333.smethod_110()).Matches(array2[num3]);
					if (matchCollection.Count == 1 && matchCollection[0].Groups.Count == 2 && matchCollection[0].Groups[1].ToString().ToLower() == Class333.smethod_111())
					{
						matchCollection = new Regex(Class333.smethod_112()).Matches(array2[num3]);
						if (matchCollection.Count == 1 && matchCollection[0].Groups.Count == 2)
						{
							array3[num3].BGV = matchCollection[0].Groups[1].ToString().ToUpper();
							matchCollection = new Regex(Class333.smethod_113()).Matches(array2[num3]);
							if (matchCollection.Count == 1 && matchCollection[0].Groups.Count == 2)
							{
								array3[num3].BGv = matchCollection[0].Groups[1].ToString().ToUpper();
								array3[num3].BGW = true;
							}
						}
					}
				}
				if (array3[num3].BGW && array3[num3].BGV == string_2)
				{
					string_1 += array3[num3].BGv;
					result = true;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Class1.smethod_86(Class333.smethod_114() + ex.Message);
			return false;
		}
		return result;
	}

	private static ProcessStartInfo smethod_0(string string_1, string string_2)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		if (string_1 != null)
		{
			processStartInfo.FileName = string_1;
		}
		if (string_2 != null)
		{
			processStartInfo.Arguments = string_2;
		}
		processStartInfo.UseShellExecute = false;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		return processStartInfo;
	}

	internal void method_5(int int_3 = 0)
	{
		if (int_3 > 0)
		{
			Thread.Sleep(int_3);
		}
		try
		{
			while (udpClient_0 != null && udpClient_0.Client != null && udpClient_0.Client.Available > 0)
			{
				IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
				udpClient_0.Receive(ref remoteEP);
			}
		}
		catch
		{
		}
	}

	internal bool method_6(byte[] byte_0, uint uint_14, out uint uint_15, Stopwatch stopwatch_0)
	{
		uint_15 = 0u;
		byte[] byte_1 = new byte[uint_14 + 8];
		if (smethod_1(ref byte_1, uint_14, Enum17.BGw, byte_0[1], 1, 1))
		{
			Array.Copy(byte_0, 0L, byte_1, 8L, uint_14);
			try
			{
				if (udpClient_0 != null && udpClient_0.Client != null)
				{
					uint_15 = (uint)udpClient_0.Send(byte_1, byte_1.Length, ipendPoint_0);
				}
			}
			catch
			{
				uint_15 = 0u;
			}
			stopwatch_0.Restart();
			if (uint_15 != byte_1.Length)
			{
				uint_15 = 0u;
				return false;
			}
			uint_15 -= 8u;
			return true;
		}
		return false;
	}

	internal bool method_7(ref byte[] byte_0, uint uint_14, out uint uint_15, byte byte_1, uint uint_16)
	{
		uint num = 0u;
		uint_15 = 0u;
		do
		{
			num++;
			uint num2 = method_8(ref byte_0, uint_15, byte_1, uint_16);
			if (num2 != 0)
			{
				uint_15 += num2;
				continue;
			}
			Class1.smethod_86(Class333.smethod_115() + num);
			method_5((int)uint_16);
			return false;
		}
		while (uint_15 < uint_14);
		return true;
	}

	private static bool smethod_1(ref byte[] byte_0, uint uint_14, Enum17 enum17_0, byte byte_1, byte byte_2, byte byte_3)
	{
		if (byte_0.Length >= 8L)
		{
			byte_0[0] = (byte)((int)uint_14 >> 8);
			byte_0[1] = (byte)uint_14;
			byte_0[2] = (byte)enum17_0;
			byte_0[3] = byte_1;
			byte_0[4] = byte_2;
			byte_0[5] = byte_3;
			byte_0[6] = smethod_3(byte_0, 6u);
			byte_0[7] = 0;
			return true;
		}
		return false;
	}

	private static bool smethod_2(byte[] byte_0, bool bool_0 = false, uint uint_14 = 0u, uint uint_15 = 0u)
	{
		bool result = false;
		uint num = 0u;
		if (smethod_3(byte_0, 6u) == byte_0[6] && byte_0[4] <= byte_0[5] && byte_0[4] > 0 && (uint)byte_0[5] <= 17u)
		{
			if (bool_0)
			{
				num = (uint)(byte_0[0] << 8);
				num += byte_0[1];
				if (uint_15 == byte_0[3] && uint_14 == num)
				{
					result = true;
				}
			}
			else
			{
				result = true;
			}
		}
		return result;
	}

	private static byte smethod_3(byte[] byte_0, uint uint_14)
	{
		byte b = 55;
		for (uint num = 0u; num < uint_14; num++)
		{
			b += byte_0[num];
		}
		return b;
	}

	private uint method_8(ref byte[] byte_0, uint uint_14, byte byte_1, uint uint_15)
	{
		if (udpClient_0 != null && udpClient_0.Client != null && uint_14 < byte_0.Length)
		{
			uint num = 0u;
			byte b = 0;
			uint num2 = 65535u;
			uint num3 = 0u;
			bool flag = false;
			Struct6[] array = new Struct6[17];
			for (uint num4 = 0u; num4 < 17; num4++)
			{
				array[num4].BGY = new byte[1472];
			}
			uint num5 = 0u;
			bool flag2 = true;
			uint num6 = 0u;
			try
			{
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				while (udpClient_0 != null && udpClient_0.Client != null && udpClient_0.Client.Available == 0)
				{
					if (stopwatch.ElapsedMilliseconds < uint_15)
					{
						Thread.Sleep(1);
						continue;
					}
					flag = true;
					break;
				}
				if (udpClient_0 != null && udpClient_0.Client != null && !flag)
				{
					IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
					byte[] array2 = udpClient_0.Receive(ref remoteEP);
					if (enum11_0 == Enum11.const_1)
					{
						if (smethod_2(array2))
						{
							b = array2[3];
							if (b != byte_1)
							{
								Thread.Sleep(20);
								while (b != byte_1 && udpClient_0.Client.Available > 0)
								{
									array2 = udpClient_0.Receive(ref remoteEP);
									b = array2[3];
								}
							}
							if (b != byte_1)
							{
								Class1.smethod_86(Class333.smethod_116());
								num = 0u;
								flag2 = true;
								method_5(20);
							}
							else
							{
								num = (uint)(array2[0] << 8);
								num += array2[1];
								num2 = array2[4];
								num3 = array2[5];
								if (num <= (uint)(byte_0.Length - uint_14) && num2 >= 1 && num != 0 && array2.Length > 8L)
								{
									if (num2 == num3 && num2 == 1)
									{
										Array.Copy(array2, 8L, byte_0, uint_14, num);
										flag2 = true;
									}
									else
									{
										num2--;
										flag2 = false;
										num5 |= (uint)(1 << (int)num2);
										array[num2].BGy = (uint)(array2.Length - 8);
										Array.Copy(array2, 8L, array[num2].BGY, 0L, array[num2].BGy);
									}
								}
								else
								{
									Class1.smethod_86(Class333.smethod_117());
									num = 0u;
									flag2 = true;
									method_5(20);
								}
							}
						}
						else
						{
							Class1.smethod_86(Class333.smethod_118());
							num = 0u;
							flag2 = true;
							method_5(20);
						}
					}
					else
					{
						Array.Copy(array2, 8L, byte_0, uint_14, array2.Length - 8L);
						num = (uint)(array2.Length - 8);
						flag2 = true;
					}
					Stopwatch stopwatch2 = new Stopwatch();
					stopwatch.Restart();
					while (!flag2 && !flag)
					{
						if (stopwatch.ElapsedMilliseconds < uint_15)
						{
							stopwatch2.Restart();
							while (udpClient_0.Client.Available == 0)
							{
								if (stopwatch2.ElapsedMilliseconds >= uint_15 / 2)
								{
									if (num6 >= 3)
									{
										Class1.smethod_86(Class333.smethod_119() + 3 + Class333.smethod_120());
										flag = true;
										num = 0u;
										flag2 = true;
										method_5(20);
										break;
									}
									method_9(byte_1);
									num6++;
									stopwatch2.Restart();
								}
								Thread.Sleep(1);
							}
							if (flag)
							{
								break;
							}
							array2 = udpClient_0.Receive(ref remoteEP);
							if (smethod_2(array2, bool_0: true, num, byte_1))
							{
								num2 = (uint)(array2[4] - 1);
								num5 |= (uint)(1 << (int)num2);
								array[num2].BGy = (uint)(array2.Length - 8);
								Array.Copy(array2, 8L, array[num2].BGY, 0L, array[num2].BGy);
								if (num5 == (1 << (int)num3) - 1)
								{
									flag2 = true;
									uint num7 = uint_14;
									for (uint num8 = 0u; num8 < num3; num8++)
									{
										Array.Copy(array[num8].BGY, 0L, byte_0, num7, array[num8].BGy);
										num7 += array[num8].BGy;
									}
									num = num7 - uint_14;
								}
							}
							else
							{
								Class1.smethod_86(Class333.smethod_121());
							}
							continue;
						}
						flag = true;
						break;
					}
				}
				if (flag)
				{
					num = 0u;
					Class1.smethod_86(Class333.smethod_122());
					method_5();
				}
				return num;
			}
			catch (Exception ex)
			{
				Class1.smethod_86(Class333.smethod_123() + ex.Message);
				method_5(20);
				return 0u;
			}
		}
		return 0u;
	}

	private void method_9(byte byte_0)
	{
		try
		{
			byte[] byte_1 = new byte[8];
			smethod_1(ref byte_1, 0u, Enum17.BGx, byte_0, 1, 1);
			udpClient_0.Send(byte_1, byte_1.Length, ipendPoint_0);
		}
		catch
		{
			Class1.smethod_86(Class333.smethod_124());
		}
	}

	internal void method_10()
	{
		if (udpClient_0 != null)
		{
			udpClient_0.Dispose();
		}
	}
}
