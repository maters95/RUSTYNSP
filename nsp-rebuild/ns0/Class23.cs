using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using ns7;

namespace ns0;

internal static class Class23
{
	private static Stream stream_0;

	private static TextWriter textWriter_0;

	private static Stream stream_1;

	private static TextWriter textWriter_1;

	internal static bool bool_0;

	internal static void smethod_0()
	{
	}

	internal static void smethod_1()
	{
	}

	private static void smethod_2(object sender, EventArgs0 e)
	{
		smethod_3(e.string_0, bool_1: false);
	}

	internal static void smethod_3(string string_0, bool bool_1 = true)
	{
	}

	internal static int[] smethod_4(byte[] byte_0, int int_0, bool bool_1, bool bool_2)
	{
		int num = byte_0.Length / int_0;
		int[] array = new int[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = smethod_5(byte_0, i * int_0, int_0, bool_1, bool_2);
		}
		return array;
	}

	internal static int smethod_5(byte[] byte_0, int int_0, int int_1, bool bool_1, bool bool_2)
	{
		int result = 0;
		switch (int_1)
		{
		case 1:
			result = ((!bool_1) ? (byte_0[int_0] & 0xFF) : ((sbyte)byte_0[int_0]));
			break;
		case 2:
		{
			int num5 = ((!bool_2) ? 1 : 0);
			int num6 = (bool_2 ? 1 : 0);
			result = ((!bool_1) ? ((byte_0[int_0 + num5] << 8) | (byte_0[int_0 + num6] & 0xFF)) : ((short)((byte_0[int_0 + num5] << 8) | (byte_0[int_0 + num6] & 0xFF))));
			break;
		}
		case 4:
		{
			int num = ((!bool_2) ? 3 : 0);
			int num2 = (bool_2 ? 1 : 2);
			int num3 = ((!bool_2) ? 1 : 2);
			int num4 = (bool_2 ? 3 : 0);
			result = (byte_0[int_0 + num] << 24) | ((byte_0[int_0 + num2] << 16) & 0xFF0000) | ((byte_0[int_0 + num3] << 8) & 0xFF00) | (byte_0[int_0 + num4] & 0xFF);
			break;
		}
		}
		return result;
	}

	internal static bool smethod_6(int int_0, byte[] byte_0, int int_1, int int_2, bool bool_1)
	{
		bool result = false;
		switch (int_2)
		{
		case 1:
		{
			byte b7 = (byte)(int_0 & 0xFF);
			if (byte_0[int_1] != b7)
			{
				byte_0[int_1] = b7;
				result = true;
			}
			break;
		}
		case 2:
		{
			int num5 = ((!bool_1) ? 1 : 0);
			int num6 = (bool_1 ? 1 : 0);
			byte b5 = (byte)((int_0 >> 8) & 0xFF);
			byte b6 = (byte)(int_0 & 0xFF);
			if (byte_0[int_1 + num5] != b5)
			{
				byte_0[int_1 + num5] = b5;
				result = true;
			}
			if (byte_0[int_1 + num6] != b6)
			{
				byte_0[int_1 + num6] = b6;
				result = true;
			}
			break;
		}
		case 4:
		{
			int num = ((!bool_1) ? 3 : 0);
			int num2 = (bool_1 ? 1 : 2);
			int num3 = ((!bool_1) ? 1 : 2);
			int num4 = (bool_1 ? 3 : 0);
			byte b = (byte)((int_0 >> 24) & 0xFF);
			byte b2 = (byte)((int_0 >> 16) & 0xFF);
			byte b3 = (byte)((int_0 >> 8) & 0xFF);
			byte b4 = (byte)(int_0 & 0xFF);
			if (byte_0[int_1 + num] != b)
			{
				byte_0[int_1 + num] = b;
				result = true;
			}
			if (byte_0[int_1 + num2] != b2)
			{
				byte_0[int_1 + num2] = b2;
				result = true;
			}
			if (byte_0[int_1 + num3] != b3)
			{
				byte_0[int_1 + num3] = b3;
				result = true;
			}
			if (byte_0[int_1 + num4] != b4)
			{
				byte_0[int_1 + num4] = b4;
				result = true;
			}
			break;
		}
		}
		return result;
	}

	internal static byte[] smethod_7(byte[] byte_0, int int_0)
	{
		byte[] array = new byte[byte_0.Length];
		for (int i = 0; i < byte_0.Length; i++)
		{
			int num = i / int_0 * int_0 + (int_0 - 1 - i % int_0);
			array[i] = byte_0[num];
		}
		return array;
	}

	internal static string smethod_8(DateTime dateTime_0, bool bool_1)
	{
		return smethod_9(dateTime_0, bool_1, bool_2: true);
	}

	internal static string smethod_9(DateTime dateTime_0, bool bool_1, bool bool_2)
	{
		string text = dateTime_0.Year.ToString();
		string text2 = dateTime_0.Month.ToString();
		if (text2.Length == 1)
		{
			text2 = text2.Insert(0, Class333.smethod_184());
		}
		string text3 = dateTime_0.Day.ToString();
		if (text3.Length == 1)
		{
			text3 = text3.Insert(0, Class333.smethod_184());
		}
		string text4;
		string text5;
		string text6;
		if (bool_2 && DateTimeFormatInfo.CurrentInfo.ShortTimePattern.Contains(Class333.smethod_185()))
		{
			text4 = dateTime_0.Hour.ToString();
			if (text4.Length == 1)
			{
				text4 = text4.Insert(0, Class333.smethod_184());
			}
			text5 = dateTime_0.Minute.ToString();
			if (text5.Length == 1)
			{
				text5 = text5.Insert(0, Class333.smethod_184());
			}
			text6 = ((!bool_1) ? string.Empty : Class333.smethod_186());
		}
		else
		{
			text4 = ((dateTime_0.Hour <= 12) ? dateTime_0.Hour.ToString() : (dateTime_0.Hour - 12).ToString());
			if (text4.Length == 1)
			{
				text4 = text4.Insert(0, Class333.smethod_184());
			}
			text5 = dateTime_0.Minute.ToString();
			if (text5.Length == 1)
			{
				text5 = text5.Insert(0, Class333.smethod_184());
			}
			text6 = ((dateTime_0.Hour < 12) ? Class333.smethod_188() : Class333.smethod_187());
		}
		string text7 = Class333.smethod_102();
		if (bool_1)
		{
			text7 = dateTime_0.Second.ToString();
			if (text7.Length == 1)
			{
				text7 = text7.Insert(0, Class333.smethod_184());
			}
		}
		return text + Class333.smethod_186() + text2 + Class333.smethod_186() + text3 + Class333.smethod_100() + text4 + text5 + text6 + text7;
	}

	internal static string smethod_10(bool bool_1)
	{
		return smethod_8(DateTime.Now, bool_1);
	}

	internal static string smethod_11(string string_0)
	{
		string numberDecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		string result = string_0;
		if (string_0.Contains(Class333.smethod_189()) && numberDecimalSeparator != Class333.smethod_189())
		{
			result = string_0.Replace(Class333.smethod_189(), numberDecimalSeparator);
		}
		else if (string_0.Contains(Class333.smethod_190()) && numberDecimalSeparator != Class333.smethod_190())
		{
			result = string_0.Replace(Class333.smethod_190(), numberDecimalSeparator);
		}
		return result;
	}

	internal static int smethod_12(int int_0, int int_1)
	{
		return (int)Math.Round((double)int_0 / (double)int_1, MidpointRounding.AwayFromZero) * int_1;
	}

	internal static int smethod_13(int int_0, int int_1)
	{
		return (int_0 + int_1 - 1) / int_1 * int_1;
	}

	internal static bool smethod_14(Stream stream_2, byte[] byte_0, int int_0, int int_1)
	{
		try
		{
			stream_2.ReadExactly(byte_0, int_0, int_1);
			return true;
		}
		catch
		{
			return false;
		}
	}

	internal static Dictionary<T, Dictionary<U, V>> smethod_15<T, U, V>(Dictionary<T, Dictionary<U, V>> dictionary_0)
	{
		if (dictionary_0 == null)
		{
			return null;
		}
		Dictionary<T, Dictionary<U, V>> dictionary = new Dictionary<T, Dictionary<U, V>>();
		foreach (KeyValuePair<T, Dictionary<U, V>> item in dictionary_0)
		{
			Dictionary<U, V> dictionary2 = new Dictionary<U, V>();
			foreach (KeyValuePair<U, V> item2 in item.Value)
			{
				dictionary2.Add(item2.Key, item2.Value);
			}
			dictionary.Add(item.Key, dictionary2);
		}
		return dictionary;
	}

	internal static byte[] smethod_16(string string_0)
	{
		try
		{
			if (File.Exists(string_0))
			{
				byte[] buffer = File.ReadAllBytes(string_0);
				byte[] result = null;
				using (MD5 mD = MD5.Create())
				{
					result = mD.ComputeHash(buffer);
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
