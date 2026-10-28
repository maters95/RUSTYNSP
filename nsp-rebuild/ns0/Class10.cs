using System;
using System.Runtime.CompilerServices;
using System.Text;
using ns7;

namespace ns0;

internal class Class10
{
	private readonly Encoding encoding_0 = Encoding.GetEncoding(65001);

	internal const int int_0 = 50;

	internal const int int_1 = 60;

	internal byte[] byte_0 = new byte[50];

	internal Class1.Enum5 enum5_0;

	internal uint uint_0;

	internal uint uint_1;

	internal byte[] method_0()
	{
		byte[] array = new byte[60];
		Array.Copy(byte_0, 0, array, 0, 50);
		array[50] = (byte)enum5_0;
		array[51] = 0;
		array[52] = (byte)((uint_0 >> 24) & 0xFF);
		array[53] = (byte)((uint_0 >> 16) & 0xFF);
		array[54] = (byte)((uint_0 >> 8) & 0xFF);
		array[55] = (byte)(uint_0 & 0xFF);
		array[56] = (byte)((uint_1 >> 24) & 0xFF);
		array[57] = (byte)((uint_1 >> 16) & 0xFF);
		array[58] = (byte)((uint_1 >> 8) & 0xFF);
		array[59] = (byte)(uint_1 & 0xFF);
		return array;
	}

	internal void method_1(byte[] byte_1)
	{
		Array.Copy(byte_1, 0, byte_0, 0, 50);
		enum5_0 = (Class1.Enum5)byte_1[50];
		uint_0 = (uint)((byte_1[52] << 24) | ((byte_1[53] << 16) & 0xFF0000) | ((byte_1[54] << 8) & 0xFF00) | (byte_1[55] & 0xFF));
		uint_1 = (uint)((byte_1[56] << 24) | ((byte_1[57] << 16) & 0xFF0000) | ((byte_1[58] << 8) & 0xFF00) | (byte_1[59] & 0xFF));
	}

	[SpecialName]
	internal string method_2()
	{
		string text = encoding_0.GetString(byte_0);
		int num = text.IndexOf('\0');
		if (num == -1)
		{
			num = text.Length;
		}
		return text.Substring(0, num);
	}

	[SpecialName]
	internal void method_3(string string_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_0);
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (i < bytes.Length)
			{
				byte_0[i] = bytes[i];
			}
			else
			{
				byte_0[i] = 0;
			}
		}
	}

	public override string ToString()
	{
		return Class333.smethod_83() + method_2() + Class333.smethod_84() + enum5_0.ToString() + Class333.smethod_85() + uint_0 + Class333.smethod_86() + uint_1;
	}
}
