using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using c;

namespace A;

internal class K
{
	private struct A
	{
		public string BGV;

		public string BGv;

		public bool BGW;
	}

	private enum a
	{
		BGw = 16,
		BGX = 32,
		BGx = 255
	}

	private struct B
	{
		public byte[] BGY;

		public uint BGy;
	}

	[CompilerGenerated]
	private sealed class b
	{
		public string BGZ;

		internal void A(object P_0, DataReceivedEventArgs P_1)
		{
			BGZ += P_1.Data;
		}
	}

	private const uint CL = 1472u;

	private const uint Cl = 508u;

	private const uint CM = 8832u;

	private const uint Cm = 1472u;

	private const uint CN = 17u;

	private const uint Cn = 0u;

	private const uint CO = 2u;

	private const uint Co = 3u;

	private const uint CP = 4u;

	private const uint Cp = 5u;

	private const uint CQ = 6u;

	private const uint Cq = 7u;

	private const uint CR = 1u;

	private const uint Cr = 8u;

	private const int CS = 32;

	private const int Cs = 3;

	private UdpClient CT;

	private IPEndPoint Ct;

	private g CU;

	private string Cu;

	private int CV;

	private ManagementClass Cv = new ManagementClass(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aS());

	internal K(g P_0, string P_1, int P_2)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		CU = P_0;
		Cu = P_1;
		CV = P_2;
	}

	private bool A(out string[] P_0)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		ManagementObjectCollection instances = Cv.GetInstances();
		List<string> val = new List<string>();
		bool result = true;
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.Current;
				if ((bool)((ManagementBaseObject)val2)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.@as()])
				{
					string text = ((ManagementBaseObject)val2)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT()].ToString().ToLower();
					if ((CU == g.BJ && text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.at())) || (CU == g.Bi && (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aU()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.au()) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ai()))))
					{
						val.Add(((ManagementBaseObject)val2)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aV()].ToString());
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0 = val.ToArray();
		if (val.Count == 0)
		{
			result = false;
		}
		return result;
	}

	internal bool A(List<string> P_0, ref string P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		if (A(out var array))
		{
			CT = new UdpClient(0);
			IPAddress val = default(IPAddress);
			if (IPAddress.TryParse(Cu, ref val))
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(40, 1);
				defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.av());
				defaultInterpolatedStringHandler.AppendFormatted<IPAddress>(val);
				global::A.A.k(defaultInterpolatedStringHandler.ToStringAndClear());
				Ct = new IPEndPoint(val, CV);
			}
			else
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aW());
			}
			if (CU == g.BJ)
			{
				if (array != null && array.Length != 0)
				{
					P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aw() + array[0];
				}
			}
			else
			{
				if (CU != g.Bi)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aY());
				}
				if (array != null && array.Length != 0)
				{
					P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aX() + array[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax();
					if (!A(ref P_1, array[0]))
					{
						P_1 = string.Empty;
					}
				}
			}
			if (!string.IsNullOrEmpty(P_1) && !P_0.Contains(P_1))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool A(ref string P_0, string P_1)
	{
		if (A(ref P_0))
		{
			return true;
		}
		if (a(ref P_0, P_1))
		{
			return true;
		}
		return false;
	}

	private bool A(ref string P_0)
	{
		bool result = false;
		byte[] array = new byte[8];
		byte[] array2 = new byte[32];
		A(ref array, 0u, K.a.BGX, 165, 1, 1);
		uint num = 0u;
		uint num2 = 0u;
		for (uint num3 = 0u; num3 < 1; num3++)
		{
			try
			{
				num = (uint)CT.Send(array, array.Length, Ct);
			}
			catch
			{
				num = 0u;
			}
			num2 = ((num != 0) ? A(ref array2, 0u, 165, 30u) : 0u);
			if (num2 != 0)
			{
				break;
			}
		}
		if (num2 != 0)
		{
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
			byte[] array3 = array2;
			foreach (byte b2 in array3)
			{
				text += b2.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
			}
			P_0 += text;
			result = true;
		}
		return result;
	}

	private bool a(ref string P_0, string P_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		Process val = new Process();
		val.StartInfo = A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.az(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BA());
		string BGZ = null;
		val.ErrorDataReceived += (DataReceivedEventHandler)delegate(object P_0, DataReceivedEventArgs P_1)
		{
			BGZ += P_1.Data;
		};
		try
		{
			val.Start();
			val.BeginErrorReadLine();
			string text = ((TextReader)val.StandardOutput).ReadToEnd();
			Thread.Sleep(100);
			val.WaitForExit();
			_ = val.ExitCode;
			string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ba();
			string[] array = Regex.Split(text, text2);
			string[] array2 = new string[array.Length];
			uint num = 0u;
			for (uint num2 = 0u; num2 < array.Length - 1; num2++)
			{
				if (Regex.IsMatch(array[num2], text2))
				{
					array2[num] = array[num2 + 1];
					num2++;
					num++;
				}
			}
			A[] array3 = new A[num];
			for (uint num3 = 0u; num3 < num; num3++)
			{
				array3[num3].BGW = false;
				if (Regex.IsMatch(array2[num3], D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BB()) && Regex.IsMatch(array2[num3], D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bb()) && Regex.IsMatch(array2[num3], D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BC()))
				{
					MatchCollection val2 = new Regex(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bc()).Matches(array2[num3]);
					if (val2.Count == 1 && val2[0].Groups.Count == 2 && ((object)val2[0].Groups[1]).ToString().ToLower() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BD())
					{
						val2 = new Regex(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bd()).Matches(array2[num3]);
						if (val2.Count == 1 && val2[0].Groups.Count == 2)
						{
							array3[num3].BGV = ((object)val2[0].Groups[1]).ToString().ToUpper();
							val2 = new Regex(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BE()).Matches(array2[num3]);
							if (val2.Count == 1 && val2[0].Groups.Count == 2)
							{
								array3[num3].BGv = ((object)val2[0].Groups[1]).ToString().ToUpper();
								array3[num3].BGW = true;
							}
						}
					}
				}
				if (array3[num3].BGW && array3[num3].BGV == P_1)
				{
					P_0 += array3[num3].BGv;
					result = true;
					break;
				}
			}
		}
		catch (System.Exception ex)
		{
			global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Be() + ex.Message);
			return false;
		}
		return result;
	}

	private static ProcessStartInfo A(string P_0, string P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ProcessStartInfo val = new ProcessStartInfo();
		if (P_0 != null)
		{
			val.FileName = P_0;
		}
		if (P_1 != null)
		{
			val.Arguments = P_1;
		}
		val.UseShellExecute = false;
		val.WindowStyle = (ProcessWindowStyle)1;
		val.CreateNoWindow = true;
		val.RedirectStandardOutput = true;
		val.RedirectStandardError = true;
		return val;
	}

	internal void A(int P_0 = 0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (P_0 > 0)
		{
			Thread.Sleep(P_0);
		}
		try
		{
			while (CT != null && CT.Client != null && CT.Client.Available > 0)
			{
				IPEndPoint val = new IPEndPoint(IPAddress.Any, 0);
				CT.Receive(ref val);
			}
		}
		catch
		{
		}
	}

	internal bool A(byte[] P_0, uint P_1, out uint P_2, Stopwatch P_3)
	{
		P_2 = 0u;
		byte[] array = new byte[P_1 + 8];
		if (A(ref array, P_1, K.a.BGw, P_0[1], 1, 1))
		{
			System.Array.Copy((System.Array)P_0, 0L, (System.Array)array, 8L, (long)P_1);
			try
			{
				if (CT != null && CT.Client != null)
				{
					P_2 = (uint)CT.Send(array, array.Length, Ct);
				}
			}
			catch
			{
				P_2 = 0u;
			}
			P_3.Restart();
			if (P_2 != array.Length)
			{
				P_2 = 0u;
				return false;
			}
			P_2 -= 8u;
			return true;
		}
		return false;
	}

	internal bool A(ref byte[] P_0, uint P_1, out uint P_2, byte P_3, uint P_4)
	{
		uint num = 0u;
		P_2 = 0u;
		do
		{
			num++;
			uint num2 = A(ref P_0, P_2, P_3, P_4);
			if (num2 == 0)
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BF() + num);
				A((int)P_4);
				return false;
			}
			P_2 += num2;
		}
		while (P_2 < P_1);
		return true;
	}

	private static bool A(ref byte[] P_0, uint P_1, a P_2, byte P_3, byte P_4, byte P_5)
	{
		if ((long)P_0.Length >= 8L)
		{
			P_0[0] = (byte)((int)P_1 >> 8);
			P_0[1] = (byte)P_1;
			P_0[2] = (byte)P_2;
			P_0[3] = P_3;
			P_0[4] = P_4;
			P_0[5] = P_5;
			P_0[6] = A(P_0, 6u);
			P_0[7] = 0;
			return true;
		}
		return false;
	}

	private static bool A(byte[] P_0, bool P_1 = false, uint P_2 = 0u, uint P_3 = 0u)
	{
		bool result = false;
		uint num = 0u;
		if (A(P_0, 6u) == P_0[6] && P_0[4] <= P_0[5] && P_0[4] > 0 && (uint)P_0[5] <= 17u)
		{
			if (P_1)
			{
				num = (uint)(P_0[0] << 8);
				num += P_0[1];
				if (P_3 == P_0[3] && P_2 == num)
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

	private static byte A(byte[] P_0, uint P_1)
	{
		byte b2 = 55;
		for (uint num = 0u; num < P_1; num++)
		{
			b2 += P_0[num];
		}
		return b2;
	}

	private uint A(ref byte[] P_0, uint P_1, byte P_2, uint P_3)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if (CT == null || CT.Client == null || P_1 >= P_0.Length)
		{
			return 0u;
		}
		uint num = 0u;
		byte b2 = 0;
		uint num2 = 65535u;
		uint num3 = 0u;
		bool flag = false;
		B[] array = new B[17];
		for (uint num4 = 0u; num4 < 17; num4++)
		{
			array[num4].BGY = new byte[1472];
		}
		uint num5 = 0u;
		bool flag2 = true;
		uint num6 = 0u;
		try
		{
			Stopwatch val = new Stopwatch();
			val.Start();
			while (CT != null && CT.Client != null && CT.Client.Available == 0)
			{
				if (val.ElapsedMilliseconds >= P_3)
				{
					flag = true;
					break;
				}
				Thread.Sleep(1);
			}
			if (CT != null && CT.Client != null && !flag)
			{
				IPEndPoint val2 = new IPEndPoint(IPAddress.Any, 0);
				byte[] array2 = CT.Receive(ref val2);
				if (CU == g.Bi)
				{
					if (A(array2))
					{
						b2 = array2[3];
						if (b2 != P_2)
						{
							Thread.Sleep(20);
							while (b2 != P_2 && CT.Client.Available > 0)
							{
								array2 = CT.Receive(ref val2);
								b2 = array2[3];
							}
						}
						if (b2 != P_2)
						{
							global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bf());
							num = 0u;
							flag2 = true;
							A(20);
						}
						else
						{
							num = (uint)(array2[0] << 8);
							num += array2[1];
							num2 = array2[4];
							num3 = array2[5];
							if (num <= (uint)(P_0.Length - P_1) && num2 >= 1 && num != 0 && (long)array2.Length > 8L)
							{
								if (num2 == num3 && num2 == 1)
								{
									System.Array.Copy((System.Array)array2, 8L, (System.Array)P_0, (long)P_1, (long)num);
									flag2 = true;
								}
								else
								{
									num2--;
									flag2 = false;
									num5 |= (uint)(1 << (int)num2);
									array[num2].BGy = (uint)(array2.Length - 8);
									System.Array.Copy((System.Array)array2, 8L, (System.Array)array[num2].BGY, 0L, (long)array[num2].BGy);
								}
							}
							else
							{
								global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BG());
								num = 0u;
								flag2 = true;
								A(20);
							}
						}
					}
					else
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bg());
						num = 0u;
						flag2 = true;
						A(20);
					}
				}
				else
				{
					System.Array.Copy((System.Array)array2, 8L, (System.Array)P_0, (long)P_1, (long)array2.Length - 8L);
					num = (uint)(array2.Length - 8);
					flag2 = true;
				}
				Stopwatch val3 = new Stopwatch();
				val.Restart();
				while (!flag2 && !flag)
				{
					if (val.ElapsedMilliseconds >= P_3)
					{
						flag = true;
						break;
					}
					val3.Restart();
					while (CT.Client.Available == 0)
					{
						if (val3.ElapsedMilliseconds >= P_3 / 2)
						{
							if (num6 >= 3)
							{
								global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BH() + 3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bh());
								flag = true;
								num = 0u;
								flag2 = true;
								A(20);
								break;
							}
							A(P_2);
							num6++;
							val3.Restart();
						}
						Thread.Sleep(1);
					}
					if (flag)
					{
						break;
					}
					array2 = CT.Receive(ref val2);
					if (A(array2, true, num, P_2))
					{
						num2 = (uint)(array2[4] - 1);
						num5 |= (uint)(1 << (int)num2);
						array[num2].BGy = (uint)(array2.Length - 8);
						System.Array.Copy((System.Array)array2, 8L, (System.Array)array[num2].BGY, 0L, (long)array[num2].BGy);
						if (num5 == (1 << (int)num3) - 1)
						{
							flag2 = true;
							uint num7 = P_1;
							for (uint num8 = 0u; num8 < num3; num8++)
							{
								System.Array.Copy((System.Array)array[num8].BGY, 0L, (System.Array)P_0, (long)num7, (long)array[num8].BGy);
								num7 += array[num8].BGy;
							}
							num = num7 - P_1;
						}
					}
					else
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BI());
					}
				}
			}
			if (flag)
			{
				num = 0u;
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bi());
				A(0);
			}
			return num;
		}
		catch (System.Exception ex)
		{
			global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJ() + ex.Message);
			A(20);
			return 0u;
		}
	}

	private void A(byte P_0)
	{
		try
		{
			byte[] array = new byte[8];
			A(ref array, 0u, K.a.BGx, P_0, 1, 1);
			CT.Send(array, array.Length, Ct);
		}
		catch
		{
			global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bj());
		}
	}

	internal void A()
	{
		if (CT != null)
		{
			CT.Dispose();
		}
	}
}
internal class k
{
	private int CW;

	private int Cw;

	private int CX;

	private int Cx;

	private int CY;

	internal k(string P_0, bool P_1)
	{
		string text = P_0.ToLower();
		string text2 = ((text == null || text.Length <= 1 || text[0] != 'v') ? text : text.Substring(1, text.Length - 1));
		string[] array = text2.Split(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BK().ToCharArray());
		int num = 0;
		if (P_1)
		{
			num = 1;
		}
		CW = int.Parse(array[num++].Trim());
		Cw = int.Parse(array[num++].Trim());
		CX = 0;
		if (array.Length > num)
		{
			CX = int.Parse(array[num++].Trim());
		}
		if (array.Length > num)
		{
			int cx = default(int);
			if (int.TryParse(array[num++].Trim(), ref cx))
			{
				Cx = cx;
			}
			else if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bk()))
			{
				Cx = 0;
			}
			else
			{
				string text3 = null;
				int num2 = 0;
				if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BL()))
				{
					text3 = text2.Substring(text2.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BL()) + 5);
				}
				else if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bl()))
				{
					text3 = text2.Substring(text2.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bl()) + 4);
					num2 = 100;
				}
				else if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BM()))
				{
					text3 = text2.Substring(text2.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BM()) + 12);
					num2 = 200;
				}
				if (text3 != null)
				{
					if (text3.Contains(':'))
					{
						text3 = text3.Substring(0, text3.IndexOf(':'));
					}
					else if (text3.Contains('-'))
					{
						text3 = text3.Substring(0, text3.IndexOf('-'));
					}
					Cx = int.Parse(text3.Trim()) + num2;
				}
			}
		}
		else
		{
			Cx = 0;
		}
		int cY = 0;
		if (text2.Contains(':'))
		{
			cY = int.Parse(text2.Substring(text2.IndexOf(':') + 1).Trim());
		}
		else if (array.Length == 5)
		{
			cY = int.Parse(array[4]);
		}
		CY = cY;
	}

	internal k(int P_0, int P_1, int P_2, int P_3, int P_4)
	{
		CW = P_0;
		Cw = P_1;
		CX = P_2;
		Cx = P_3;
		CY = P_4;
	}

	public virtual string ToString()
	{
		string text;
		if (Cx == 0)
		{
			text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bm();
		}
		else if (Cx <= 100)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BN());
			defaultInterpolatedStringHandler.AppendFormatted<int>(Cx);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else if (Cx <= 200)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bn());
			defaultInterpolatedStringHandler.AppendFormatted<int>(Cx - 100);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BO());
			defaultInterpolatedStringHandler.AppendFormatted<int>(Cx - 200);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		string text2 = string.Empty;
		if (CY != 0)
		{
			text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo() + CY;
		}
		string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BP();
		cE<object> buffer = default(cE<object>);
		cc.a<cE<object>, object>(ref buffer, 0) = CW;
		cc.a<cE<object>, object>(ref buffer, 1) = Cw.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bp());
		cc.a<cE<object>, object>(ref buffer, 2) = CX;
		cc.a<cE<object>, object>(ref buffer, 3) = text;
		cc.a<cE<object>, object>(ref buffer, 4) = text2;
		return string.Format(text3, cc.A<cE<object>, object>(in buffer, 5));
	}

	[SpecialName]
	internal int A()
	{
		return CW;
	}

	[SpecialName]
	internal int a()
	{
		return Cw;
	}

	[SpecialName]
	internal int B()
	{
		return CX;
	}

	[SpecialName]
	internal int b()
	{
		return Cx;
	}

	[SpecialName]
	internal int C()
	{
		return CY;
	}

	[SpecialName]
	internal string c()
	{
		if (Cx == 0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bm();
		}
		if (Cx <= 100)
		{
			return string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BQ(), (object)Cx);
		}
		if (Cx <= 200)
		{
			return string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bq(), (object)(Cx - 100));
		}
		return string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BR(), (object)(Cx - 200));
	}

	[SpecialName]
	internal string D()
	{
		if (Cx == 0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Br();
		}
		if (Cx <= 100)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BS();
		}
		if (Cx <= 200)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bs();
		}
		return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BT();
	}

	[SpecialName]
	internal bool d()
	{
		return Cx == 0;
	}

	[SpecialName]
	internal bool E()
	{
		if (CW == 0 && Cw == 0 && CX == 0 && Cx == 0)
		{
			return CX == 0;
		}
		return false;
	}

	public static bool operator ==(k P_0, k P_1)
	{
		if ((object)P_0 == null || (object)P_1 == null)
		{
			return (object)P_0 == P_1;
		}
		if (P_0.A() == P_1.A() && P_0.a() == P_1.a() && P_0.B() == P_1.B() && P_0.b() == P_1.b())
		{
			return P_0.C() == P_1.C();
		}
		return false;
	}

	public static bool operator !=(k P_0, k P_1)
	{
		return !(P_0 == P_1);
	}

	private static int A(int P_0)
	{
		int num = P_0;
		if (num == 0)
		{
			num = 201;
		}
		else if (num >= 201)
		{
			num++;
		}
		return num;
	}

	public static bool operator >(k P_0, k P_1)
	{
		if (P_0.A() <= P_1.A() && (P_0.A() != P_1.A() || P_0.a() <= P_1.a()) && (P_0.A() != P_1.A() || P_0.a() != P_1.a() || P_0.B() <= P_1.B()) && (P_0.A() != P_1.A() || P_0.a() != P_1.a() || P_0.B() != P_1.B() || A(P_0.b()) <= A(P_1.b())))
		{
			if (P_0.A() == P_1.A() && P_0.a() == P_1.a() && P_0.B() == P_1.B() && A(P_0.b()) == A(P_1.b()))
			{
				return P_0.C() > P_1.C();
			}
			return false;
		}
		return true;
	}

	public static bool operator >=(k P_0, k P_1)
	{
		if (P_0.A() <= P_1.A() && (P_0.A() != P_1.A() || P_0.a() <= P_1.a()) && (P_0.A() != P_1.A() || P_0.a() != P_1.a() || P_0.B() <= P_1.B()) && (P_0.A() != P_1.A() || P_0.a() != P_1.a() || P_0.B() != P_1.B() || A(P_0.b()) <= A(P_1.b())))
		{
			if (P_0.A() == P_1.A() && P_0.a() == P_1.a() && P_0.B() == P_1.B() && A(P_0.b()) == A(P_1.b()))
			{
				return P_0.C() >= P_1.C();
			}
			return false;
		}
		return true;
	}

	public static bool operator <(k P_0, k P_1)
	{
		if (P_0.A() >= P_1.A() && (P_0.A() != P_1.A() || P_0.a() >= P_1.a()) && (P_0.A() != P_1.A() || P_0.a() != P_1.a() || P_0.B() >= P_1.B()) && (P_0.A() != P_1.A() || P_0.a() != P_1.a() || P_0.B() != P_1.B() || A(P_0.b()) >= A(P_1.b())))
		{
			if (P_0.A() == P_1.A() && P_0.a() == P_1.a() && P_0.B() == P_1.B() && A(P_0.b()) == A(P_1.b()))
			{
				return P_0.C() < P_1.C();
			}
			return false;
		}
		return true;
	}

	public static bool operator <=(k P_0, k P_1)
	{
		if (P_0.A() >= P_1.A() && (P_0.A() != P_1.A() || P_0.a() >= P_1.a()) && (P_0.A() != P_1.A() || P_0.a() != P_1.a() || P_0.B() >= P_1.B()) && (P_0.A() != P_1.A() || P_0.a() != P_1.a() || P_0.B() != P_1.B() || A(P_0.b()) >= A(P_1.b())))
		{
			if (P_0.A() == P_1.A() && P_0.a() == P_1.a() && P_0.B() == P_1.B() && A(P_0.b()) == A(P_1.b()))
			{
				return P_0.C() <= P_1.C();
			}
			return false;
		}
		return true;
	}

	public virtual bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (obj == null)
		{
			return false;
		}
		if (obj is k)
		{
			return this == obj as k;
		}
		return false;
	}

	public virtual int GetHashCode()
	{
		return ((byte)A() << 24) | ((byte)a() << 16) | ((byte)B() << 8) | (byte)b();
	}
}
