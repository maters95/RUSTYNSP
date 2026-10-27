using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace A;

internal static class N
{
	private static Stream cd;

	private static TextWriter cE;

	private static Stream ce;

	private static TextWriter cF;

	internal static bool cf;

	internal static void A()
	{
	}

	internal static void a()
	{
	}

	private static void A(object P_0, B P_1)
	{
		A(P_1.o, false);
	}

	internal static void A(string P_0, bool P_1 = true)
	{
	}

	internal static int[] A(byte[] P_0, int P_1, bool P_2, bool P_3)
	{
		int num = P_0.Length / P_1;
		int[] array = new int[num];
		for (int num2 = 0; num2 < num; num2++)
		{
			array[num2] = A(P_0, num2 * P_1, P_1, P_2, P_3);
		}
		return array;
	}

	internal static int A(byte[] P_0, int P_1, int P_2, bool P_3, bool P_4)
	{
		int result = 0;
		switch (P_2)
		{
		case 1:
			result = ((!P_3) ? (P_0[P_1] & 0xFF) : ((sbyte)P_0[P_1]));
			break;
		case 2:
		{
			int num5 = ((!P_4) ? 1 : 0);
			int num6 = (P_4 ? 1 : 0);
			result = ((!P_3) ? ((P_0[P_1 + num5] << 8) | (P_0[P_1 + num6] & 0xFF)) : ((short)((P_0[P_1 + num5] << 8) | (P_0[P_1 + num6] & 0xFF))));
			break;
		}
		case 4:
		{
			int num = ((!P_4) ? 3 : 0);
			int num2 = (P_4 ? 1 : 2);
			int num3 = ((!P_4) ? 1 : 2);
			int num4 = (P_4 ? 3 : 0);
			result = (P_0[P_1 + num] << 24) | ((P_0[P_1 + num2] << 16) & 0xFF0000) | ((P_0[P_1 + num3] << 8) & 0xFF00) | (P_0[P_1 + num4] & 0xFF);
			break;
		}
		}
		return result;
	}

	internal static bool A(int P_0, byte[] P_1, int P_2, int P_3, bool P_4)
	{
		bool result = false;
		switch (P_3)
		{
		case 1:
		{
			byte b8 = (byte)((uint)P_0 & 0xFFu);
			if (P_1[P_2] != b8)
			{
				P_1[P_2] = b8;
				result = true;
			}
			break;
		}
		case 2:
		{
			int num5 = ((!P_4) ? 1 : 0);
			int num6 = (P_4 ? 1 : 0);
			byte b6 = (byte)((uint)(P_0 >> 8) & 0xFFu);
			byte b7 = (byte)((uint)P_0 & 0xFFu);
			if (P_1[P_2 + num5] != b6)
			{
				P_1[P_2 + num5] = b6;
				result = true;
			}
			if (P_1[P_2 + num6] != b7)
			{
				P_1[P_2 + num6] = b7;
				result = true;
			}
			break;
		}
		case 4:
		{
			int num = ((!P_4) ? 3 : 0);
			int num2 = (P_4 ? 1 : 2);
			int num3 = ((!P_4) ? 1 : 2);
			int num4 = (P_4 ? 3 : 0);
			byte b2 = (byte)((uint)(P_0 >> 24) & 0xFFu);
			byte b3 = (byte)((uint)(P_0 >> 16) & 0xFFu);
			byte b4 = (byte)((uint)(P_0 >> 8) & 0xFFu);
			byte b5 = (byte)((uint)P_0 & 0xFFu);
			if (P_1[P_2 + num] != b2)
			{
				P_1[P_2 + num] = b2;
				result = true;
			}
			if (P_1[P_2 + num2] != b3)
			{
				P_1[P_2 + num2] = b3;
				result = true;
			}
			if (P_1[P_2 + num3] != b4)
			{
				P_1[P_2 + num3] = b4;
				result = true;
			}
			if (P_1[P_2 + num4] != b5)
			{
				P_1[P_2 + num4] = b5;
				result = true;
			}
			break;
		}
		}
		return result;
	}

	internal static byte[] A(byte[] P_0, int P_1)
	{
		byte[] array = new byte[P_0.Length];
		for (int num = 0; num < P_0.Length; num++)
		{
			int num2 = num / P_1 * P_1 + (P_1 - 1 - num % P_1);
			array[num] = P_0[num2];
		}
		return array;
	}

	internal static string A(System.DateTime P_0, bool P_1)
	{
		return A(P_0, P_1, true);
	}

	internal static string A(System.DateTime P_0, bool P_1, bool P_2)
	{
		string text = P_0.Year.ToString();
		string text2 = P_0.Month.ToString();
		if (text2.Length == 1)
		{
			text2 = text2.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
		}
		string text3 = P_0.Day.ToString();
		if (text3.Length == 1)
		{
			text3 = text3.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
		}
		string text4;
		string text5;
		string text6;
		if (P_2 && DateTimeFormatInfo.CurrentInfo.ShortTimePattern.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bO()))
		{
			text4 = P_0.Hour.ToString();
			if (text4.Length == 1)
			{
				text4 = text4.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
			}
			text5 = P_0.Minute.ToString();
			if (text5.Length == 1)
			{
				text5 = text5.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
			}
			text6 = ((!P_1) ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo());
		}
		else
		{
			text4 = ((P_0.Hour <= 12) ? P_0.Hour.ToString() : (P_0.Hour - 12).ToString());
			if (text4.Length == 1)
			{
				text4 = text4.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
			}
			text5 = P_0.Minute.ToString();
			if (text5.Length == 1)
			{
				text5 = text5.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
			}
			text6 = ((P_0.Hour < 12) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bp() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bP());
		}
		string text7 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
		if (P_1)
		{
			text7 = P_0.Second.ToString();
			if (text7.Length == 1)
			{
				text7 = text7.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
			}
		}
		return string.Concat(new string[10]
		{
			text,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo(),
			text2,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo(),
			text3,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax(),
			text4,
			text5,
			text6,
			text7
		});
	}

	internal static string A(bool P_0)
	{
		return A(System.DateTime.Now, P_0);
	}

	internal static string A(string P_0)
	{
		string numberDecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		string result = P_0;
		if (P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ()) && numberDecimalSeparator != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ())
		{
			result = P_0.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ(), numberDecimalSeparator);
		}
		else if (P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()) && numberDecimalSeparator != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq())
		{
			result = P_0.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq(), numberDecimalSeparator);
		}
		return result;
	}

	internal static int A(int P_0, int P_1)
	{
		return (int)Math.Round((double)P_0 / (double)P_1, (MidpointRounding)1) * P_1;
	}

	internal static int a(int P_0, int P_1)
	{
		return (P_0 + P_1 - 1) / P_1 * P_1;
	}

	internal static bool A(Stream P_0, byte[] P_1, int P_2, int P_3)
	{
		try
		{
			P_0.ReadExactly(P_1, P_2, P_3);
			return true;
		}
		catch
		{
			return false;
		}
	}

	internal static Dictionary<A, Dictionary<a, B>> A<A, a, B>(Dictionary<A, Dictionary<a, B>> P_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 == null)
		{
			return null;
		}
		Dictionary<A, Dictionary<a, B>> val = new Dictionary<A, Dictionary<a, B>>();
		Enumerator<A, Dictionary<a, B>> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<A, Dictionary<a, B>> current = enumerator.Current;
				Dictionary<a, B> val2 = new Dictionary<a, B>();
				Enumerator<a, B> enumerator2 = current.Value.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<a, B> current2 = enumerator2.Current;
						val2.Add(current2.Key, current2.Value);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				val.Add(current.Key, val2);
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static byte[] a(string P_0)
	{
		try
		{
			if (File.Exists(P_0))
			{
				byte[] array = File.ReadAllBytes(P_0);
				byte[] result = null;
				MD5 val = MD5.Create();
				try
				{
					result = ((HashAlgorithm)val).ComputeHash(array);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				return result;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}
}
internal static class n
{
	internal static string A(byte[] P_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		StringBuilder val = new StringBuilder(P_0.Length * 2);
		foreach (byte b2 in P_0)
		{
			val.AppendFormat(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.an(), (object)b2);
		}
		return ((object)val).ToString();
	}

	internal static byte[] A(string P_0)
	{
		if (P_0 != null)
		{
			byte[] array = new byte[P_0.Length / 2];
			for (int num = 0; num < P_0.Length / 2; num++)
			{
				string text = P_0.Substring(2 * num, 2);
				array[num] = byte.Parse(text, (NumberStyles)512);
			}
			return array;
		}
		return null;
	}
}
