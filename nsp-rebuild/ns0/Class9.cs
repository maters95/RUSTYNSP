using System;
using System.Collections.Generic;
using System.Threading;
using ns1;
using ns7;

namespace ns0;

internal class Class9
{
	private enum Enum14 : byte
	{
		BfN = 0,
		Bfn = 3,
		BfO = 4,
		Bfo = 5,
		BfP = 6,
		Bfp = 7,
		BfQ = 8,
		Bfq = 9,
		BfR = 10,
		Bfr = 11,
		BfS = 12,
		Bfs = 32,
		BfT = 33,
		Bft = 34,
		BfU = 48,
		Bfu = 49,
		BfV = 50,
		Bfv = 51,
		BfW = 52,
		Bfw = 53,
		BfX = 54,
		Bfx = 55,
		BfY = 56,
		Bfy = 57,
		BfZ = 64,
		Bfz = 65,
		BGA = byte.MaxValue,
		BGa = 170,
		BGB = 204,
		BGb = 221,
		BGC = 254
	}

	private enum Enum15 : byte
	{
		BGc = 1,
		BGD,
		BGd,
		BGE,
		BGe,
		BGF,
		BGf,
		BGG,
		BGg,
		BGH,
		BGh,
		BGI,
		BGi,
		BGJ,
		BGj,
		BGK,
		BGk
	}

	private enum Enum16 : byte
	{
		BGL,
		BGl,
		BGM
	}

	private static byte[] byte_0 = new byte[16]
	{
		141, 215, 160, 13, 216, 151, 132, 195, 22, 217,
		15, 10, 64, 193, 137, 226
	};

	private static byte[] byte_1 = new byte[4] { 255, 170, 204, 221 };

	private const byte byte_2 = 170;

	private const byte byte_3 = 85;

	private const byte byte_4 = 119;

	private const int int_0 = 16;

	private const int int_1 = 64;

	private const int int_2 = 3;

	private const int int_3 = 1;

	private const byte byte_5 = 192;

	private const byte byte_6 = 254;

	private const int int_4 = 9;

	private const int int_5 = 4096;

	private bool bool_0;

	private Class8 class8_0;

	internal Class9(Class8 class8_1)
	{
		class8_0 = class8_1;
	}

	private void method_0()
	{
		if (!bool_0)
		{
			byte[] array = new byte[16];
			byte b = byte_1[new Random(DateTime.Now.Millisecond).Next(4)];
			for (int i = 0; i < 16; i++)
			{
				array[i] = b;
			}
			if (method_4(array, 16))
			{
				Thread.Sleep(0);
				byte[] byte_ = new byte[4096];
				method_5(ref byte_, out var _, out var _);
			}
		}
	}

	private bool method_1(byte byte_7)
	{
		byte[] array = byte_1;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (array[num] == byte_7)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private bool method_2(byte byte_7)
	{
		if (byte_7 == 254)
		{
			return true;
		}
		return method_1(byte_7);
	}

	private int method_3(byte[] byte_7, int int_6)
	{
		int i = 0;
		int num = 0;
		for (; i < int_6 && (method_2(byte_7[i]) || byte_7[i] == 0 || !bool_0); i++)
		{
			byte b = byte_7[i];
			if (method_1(b))
			{
				bool_0 = true;
				num++;
			}
			else if (b == 254)
			{
				bool_0 = false;
				num++;
			}
		}
		return num;
	}

	private bool method_4(byte[] byte_7, int int_6)
	{
		int num = int_6 % 16;
		if (num != 0)
		{
			num = 16 - num;
		}
		if (num >= 0)
		{
			byte b = byte_1[new Random(DateTime.Now.Millisecond).Next(4)];
			for (int i = 0; i < num; i++)
			{
				if (int_6 < byte_7.Length)
				{
					byte_7[int_6] = b;
					int_6++;
					continue;
				}
				return false;
			}
		}
		byte[] byte_8 = new byte[4096];
		method_6(byte_7, int_6, byte_0, 9);
		if (method_8(byte_7, int_6, out var int_7, byte_8))
		{
			if (class8_0.imethod_16(byte_8, (uint)int_7, out var uint_))
			{
				if (uint_ == int_7)
				{
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private bool method_5(ref byte[] byte_7, out bool bool_1, out int int_6)
	{
		byte[] byte_8 = new byte[4096];
		bool flag = false;
		int_6 = 0;
		bool_1 = false;
		if (class8_0.method_3(ref byte_8, out var uint_))
		{
			flag = true;
		}
		else
		{
			flag = false;
			bool_1 = true;
		}
		int num = 0;
		if (flag && uint_ != 0)
		{
			int int_7 = 0;
			int num2 = -1;
			int int_8 = 0;
			while (int_7 != -1 && num2 != int_7)
			{
				num2 = int_7;
				byte[] array = new byte[4096];
				method_9(byte_8, int_7, (int)uint_, out int_7, out int_8, array);
				if (int_8 > 0)
				{
					method_7(array, int_8, byte_0, 9);
					Array.Copy(array, 0, byte_7, num, int_8);
					num += int_8;
				}
			}
			int_6 = method_3(byte_7, num);
		}
		else
		{
			flag = false;
		}
		return flag;
	}

	private void method_6(byte[] byte_7, int int_6, byte[] byte_8, int int_7)
	{
		uint num = 2654435769u;
		int num2 = int_6 / 8;
		if (int_6 % 8 != 0)
		{
			throw new Exception(Class333.smethod_81());
		}
		uint num3 = (uint)((byte_8[0] << 24) + (byte_8[1] << 16) + (byte_8[2] << 8) + byte_8[3]);
		uint num4 = (uint)((byte_8[4] << 24) + (byte_8[5] << 16) + (byte_8[6] << 8) + byte_8[7]);
		uint num5 = (uint)((byte_8[8] << 24) + (byte_8[9] << 16) + (byte_8[10] << 8) + byte_8[11]);
		uint num6 = (uint)((byte_8[12] << 24) + (byte_8[13] << 16) + (byte_8[14] << 8) + byte_8[15]);
		for (int i = 0; i < num2; i++)
		{
			int num7 = 8 * i;
			int num8 = num7 + 4;
			uint num9 = (uint)((byte_7[num7] << 24) + (byte_7[num7 + 1] << 16) + (byte_7[num7 + 2] << 8) + byte_7[num7 + 3]);
			uint num10 = (uint)((byte_7[num8] << 24) + (byte_7[num8 + 1] << 16) + (byte_7[num8 + 2] << 8) + byte_7[num8 + 3]);
			uint num11 = 0u;
			for (int j = 0; j < int_7; j++)
			{
				num11 += num;
				num9 += ((num10 << 4) + num3) ^ (num10 + num11) ^ ((num10 >> 5) + num4);
				num10 += ((num9 << 4) + num5) ^ (num9 + num11) ^ ((num9 >> 5) + num6);
			}
			byte_7[num7] = (byte)(num9 >> 24);
			byte_7[num7 + 1] = (byte)(num9 >> 16);
			byte_7[num7 + 2] = (byte)(num9 >> 8);
			byte_7[num7 + 3] = (byte)num9;
			byte_7[num8] = (byte)(num10 >> 24);
			byte_7[num8 + 1] = (byte)(num10 >> 16);
			byte_7[num8 + 2] = (byte)(num10 >> 8);
			byte_7[num8 + 3] = (byte)num10;
		}
	}

	private void method_7(byte[] byte_7, int int_6, byte[] byte_8, int int_7)
	{
		uint num = 2654435769u;
		int num2 = int_6 / 8;
		if (int_6 % 8 != 0)
		{
			throw new Exception(Class333.smethod_82());
		}
		uint num3 = (uint)((byte_8[0] << 24) + (byte_8[1] << 16) + (byte_8[2] << 8) + byte_8[3]);
		uint num4 = (uint)((byte_8[4] << 24) + (byte_8[5] << 16) + (byte_8[6] << 8) + byte_8[7]);
		uint num5 = (uint)((byte_8[8] << 24) + (byte_8[9] << 16) + (byte_8[10] << 8) + byte_8[11]);
		uint num6 = (uint)((byte_8[12] << 24) + (byte_8[13] << 16) + (byte_8[14] << 8) + byte_8[15]);
		for (int i = 0; i < num2; i++)
		{
			int num7 = 8 * i;
			int num8 = num7 + 4;
			uint num9 = (uint)((byte_7[num7] << 24) + (byte_7[num7 + 1] << 16) + (byte_7[num7 + 2] << 8) + byte_7[num7 + 3]);
			uint num10 = (uint)((byte_7[num8] << 24) + (byte_7[num8 + 1] << 16) + (byte_7[num8 + 2] << 8) + byte_7[num8 + 3]);
			uint num11 = num * (uint)int_7;
			for (int j = 0; j < int_7; j++)
			{
				num10 -= ((num9 << 4) + num5) ^ (num9 + num11) ^ ((num9 >> 5) + num6);
				num9 -= ((num10 << 4) + num3) ^ (num10 + num11) ^ ((num10 >> 5) + num4);
				num11 -= num;
			}
			byte_7[num7] = (byte)(num9 >> 24);
			byte_7[num7 + 1] = (byte)(num9 >> 16);
			byte_7[num7 + 2] = (byte)(num9 >> 8);
			byte_7[num7 + 3] = (byte)num9;
			byte_7[num8] = (byte)(num10 >> 24);
			byte_7[num8 + 1] = (byte)(num10 >> 16);
			byte_7[num8 + 2] = (byte)(num10 >> 8);
			byte_7[num8 + 3] = (byte)num10;
		}
	}

	private bool method_8(byte[] byte_7, int int_6, out int int_7, byte[] byte_8)
	{
		int_7 = 0;
		byte_8[int_7] = 170;
		int_7++;
		int num = 0;
		while (true)
		{
			if (num < int_6)
			{
				if (num != 0 && num % 64 == 0)
				{
					if (int_7 + 1 >= byte_8.Length)
					{
						return false;
					}
					byte_8[int_7] = 85;
					int_7++;
					byte_8[int_7] = 170;
					int_7++;
				}
				byte b = byte_7[num];
				if (b == 170 || b == 85 || b == 119)
				{
					if (int_7 >= byte_8.Length)
					{
						break;
					}
					byte_8[int_7] = 119;
					int_7++;
				}
				if (int_7 < byte_8.Length)
				{
					byte_8[int_7] = b;
					int_7++;
					num++;
					continue;
				}
				return false;
			}
			if (int_7 < byte_8.Length)
			{
				byte_8[int_7] = 85;
				int_7++;
				return true;
			}
			return false;
		}
		return false;
	}

	private void method_9(byte[] byte_7, int int_6, int int_7, out int int_8, out int int_9, byte[] byte_8)
	{
		int_9 = 0;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		int_8 = -1;
		for (int i = int_6; i < int_7; i++)
		{
			byte b = byte_7[i];
			if (i == int_6 && b == 170)
			{
				flag = true;
				continue;
			}
			if (b == 119 && !flag3)
			{
				flag3 = true;
				continue;
			}
			if (b == 85 && !flag3)
			{
				flag2 = true;
				continue;
			}
			if (b != 170 || flag3)
			{
				if (int_9 < 64)
				{
					byte_8[int_9] = b;
					int_9++;
					flag3 = false;
				}
				continue;
			}
			int_8 = i;
			if (!flag2)
			{
				int_9 = 0;
			}
			break;
		}
		if (!(flag & flag2) || int_9 % 16 != 0)
		{
			int_9 = 0;
			if (flag && !flag2 && int_8 == -1)
			{
				int_8 = int_6;
			}
		}
	}

	private int method_10(byte[] byte_7, int int_6)
	{
		int num = int_6;
		do
		{
			Enum14 @enum = (Enum14)byte_7[num];
			if (@enum != Enum14.BfS || num + 2 >= byte_7.Length || byte_7[num + 1] < 192 || byte_7[num + 1] > 254)
			{
				if (!method_2((byte)@enum) && @enum != Enum14.BfN)
				{
					break;
				}
				num++;
			}
			else
			{
				byte b = byte_7[num + 2];
				num += 3 + b + 1;
			}
		}
		while (num < byte_7.Length);
		return num;
	}

	internal bool method_11(out byte[] byte_7)
	{
		if (!bool_0)
		{
			method_0();
		}
		byte_7 = null;
		if (!bool_0)
		{
			return false;
		}
		int int_ = 3;
		byte[] array = new byte[4096];
		array[0] = 54;
		array[1] = 1;
		byte b = 0;
		for (int i = 0; i < 2; i++)
		{
			b += array[i];
		}
		array[2] = b;
		bool result = false;
		if (method_4(array, int_))
		{
			Thread.Sleep(0);
			byte[] byte_8 = new byte[4096];
			if (method_5(ref byte_8, out var _, out var int_2))
			{
				try
				{
					int num = method_10(byte_8, int_2);
					if (num < byte_8.Length && byte_8[num] == 54)
					{
						if (!bool_0)
						{
							return false;
						}
						byte b2 = byte_8[num + 2];
						b = 0;
						for (int j = 0; j < 3 + b2; j++)
						{
							b += byte_8[num + j];
						}
						byte_7 = new byte[b2];
						for (int k = 0; k < b2; k++)
						{
							byte_7[k] = byte_8[num + 3 + k];
						}
						if (b == byte_8[num + 3 + b2])
						{
							result = true;
						}
					}
				}
				catch
				{
				}
			}
		}
		bool_0 = result;
		return result;
	}

	internal void method_12()
	{
		if (!bool_0)
		{
			method_0();
		}
		if (bool_0)
		{
			int int_ = 3;
			byte[] array = new byte[4096];
			array[0] = 7;
			array[1] = 1;
			byte b = 0;
			for (int i = 0; i < 2; i++)
			{
				b += array[i];
			}
			array[2] = b;
			if (!method_4(array, int_))
			{
				bool_0 = false;
			}
		}
	}

	internal void method_13()
	{
		if (!bool_0)
		{
			method_0();
		}
		if (bool_0)
		{
			int int_ = 11;
			byte[] array = new byte[4096];
			array[0] = 57;
			array[1] = 1;
			array[2] = 7;
			byte[] array2 = new byte[7] { 81, 85, 65, 82, 84, 69, 84 };
			for (int i = 0; i < 7; i++)
			{
				array[3 + i] = array2[i];
			}
			byte b = 0;
			for (int j = 0; j < 10; j++)
			{
				b += array[j];
			}
			array[10] = b;
			if (!method_4(array, int_))
			{
				bool_0 = false;
			}
		}
	}

	internal bool method_14(byte byte_7, uint uint_0, uint uint_1, uint uint_2, byte byte_8, byte byte_9, byte byte_10, byte byte_11, out int int_6)
	{
		int_6 = 65535;
		if (!bool_0)
		{
			method_0();
		}
		if (!bool_0)
		{
			return false;
		}
		int int_7 = 22;
		byte[] array = new byte[4096];
		array[0] = 12;
		array[1] = 1;
		array[2] = 18;
		array[3] = 14;
		array[4] = byte_7;
		array[5] = (byte)(uint_0 >> 24);
		array[6] = (byte)(uint_0 >> 16);
		array[7] = (byte)(uint_0 >> 8);
		array[8] = (byte)uint_0;
		array[9] = (byte)(uint_1 >> 24);
		array[10] = (byte)(uint_1 >> 16);
		array[11] = (byte)(uint_1 >> 8);
		array[12] = (byte)uint_1;
		array[13] = (byte)(uint_2 >> 24);
		array[14] = (byte)(uint_2 >> 16);
		array[15] = (byte)(uint_2 >> 8);
		array[16] = (byte)uint_2;
		array[17] = byte_8;
		array[18] = byte_9;
		array[19] = byte_10;
		array[20] = byte_11;
		byte b = 0;
		for (int i = 0; i < 21; i++)
		{
			b += array[i];
		}
		array[21] = b;
		bool flag = false;
		bool result = false;
		if (method_4(array, int_7))
		{
			Thread.Sleep(0);
			byte[] byte_12 = new byte[4096];
			if (method_5(ref byte_12, out var _, out var int_8))
			{
				try
				{
					int num = method_10(byte_12, int_8);
					if (num < byte_12.Length)
					{
						byte b2 = byte_12[num];
						Enum15 @enum = (Enum15)byte_12[num + 3];
						if (b2 == 12 && @enum == Enum15.BGJ)
						{
							if (!bool_0)
							{
								return false;
							}
							byte b3 = byte_12[num + 2];
							byte b4 = 0;
							for (int j = 0; j < 3 + b3; j++)
							{
								b4 += byte_12[num + j];
							}
							if (b4 == byte_12[num + 3 + b3])
							{
								flag = true;
								if (byte_12[num + 3 + 1] == 0)
								{
									int_6 = (ushort)((ushort)(byte_12[num + 5] << 8) + byte_12[num + 6]);
									result = true;
								}
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		bool_0 = flag;
		return result;
	}

	internal bool method_15(byte byte_7, byte byte_8, byte byte_9, byte byte_10, byte byte_11, byte byte_12)
	{
		if (!bool_0)
		{
			method_0();
		}
		if (!bool_0)
		{
			return false;
		}
		int int_ = 11;
		byte[] array = new byte[4096];
		array[0] = 12;
		array[1] = 1;
		array[2] = 7;
		array[3] = 16;
		array[4] = byte_7;
		array[5] = byte_8;
		array[6] = byte_9;
		array[7] = byte_10;
		array[8] = byte_11;
		array[9] = byte_12;
		byte b = 0;
		for (int i = 0; i < 10; i++)
		{
			b += array[i];
		}
		array[10] = b;
		bool flag = false;
		bool result = false;
		if (method_4(array, int_))
		{
			Thread.Sleep(0);
			byte[] byte_13 = new byte[4096];
			if (method_5(ref byte_13, out var _, out var int_2))
			{
				try
				{
					int num = method_10(byte_13, int_2);
					if (num < byte_13.Length)
					{
						byte b2 = byte_13[num];
						Enum15 @enum = (Enum15)byte_13[num + 3];
						if (b2 == 12 && @enum == Enum15.BGK)
						{
							if (!bool_0)
							{
								return false;
							}
							byte b3 = byte_13[num + 2];
							byte b4 = 0;
							for (int j = 0; j < 3 + b3; j++)
							{
								b4 += byte_13[num + j];
							}
							if (b4 == byte_13[num + 3 + b3])
							{
								flag = true;
								if (byte_13[num + 3 + 1] == 0)
								{
									result = true;
								}
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		bool_0 = flag;
		return result;
	}

	internal bool method_16()
	{
		if (!bool_0)
		{
			method_0();
		}
		if (!bool_0)
		{
			return false;
		}
		int int_ = 11;
		byte[] array = new byte[4096];
		array[0] = 32;
		array[1] = 1;
		array[2] = 7;
		byte[] array2 = new byte[7] { 72, 65, 76, 84, 69, 67, 72 };
		for (int i = 0; i < 7; i++)
		{
			array[3 + i] = array2[i];
		}
		byte b = 0;
		for (int j = 0; j < 10; j++)
		{
			b += array[j];
		}
		array[10] = b;
		bool flag = false;
		bool result = false;
		if (method_4(array, int_))
		{
			Thread.Sleep(0);
			byte[] byte_ = new byte[4096];
			if (method_5(ref byte_, out var _, out var int_2))
			{
				try
				{
					int num = method_10(byte_, int_2);
					if (num < byte_.Length && byte_[num] == 32)
					{
						if (!bool_0)
						{
							return false;
						}
						byte b2 = byte_[num + 2];
						byte b3 = 0;
						for (int k = 0; k < 3 + b2; k++)
						{
							b3 += byte_[num + k];
						}
						if (b3 == byte_[num + 3 + b2])
						{
							flag = true;
							if (byte_[num + 3] == 0)
							{
								result = true;
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		bool_0 = flag;
		return result;
	}

	internal bool method_17()
	{
		if (!bool_0)
		{
			method_0();
		}
		if (!bool_0)
		{
			return false;
		}
		int int_ = 3;
		byte[] array = new byte[4096];
		array[0] = 33;
		array[1] = 1;
		byte b = 0;
		for (int i = 0; i < 2; i++)
		{
			b += array[i];
		}
		array[2] = b;
		bool flag = false;
		bool result = false;
		if (method_4(array, int_))
		{
			Thread.Sleep(0);
			byte[] byte_ = new byte[4096];
			if (method_5(ref byte_, out var _, out var int_2))
			{
				try
				{
					int num = method_10(byte_, int_2);
					if (num < byte_.Length && byte_[num] == 33)
					{
						if (!bool_0)
						{
							return false;
						}
						byte b2 = byte_[num + 2];
						byte b3 = 0;
						for (int j = 0; j < 3 + b2; j++)
						{
							b3 += byte_[num + j];
						}
						if (b3 == byte_[num + 3 + b2])
						{
							flag = true;
							if (byte_[num + 3] == 0)
							{
								result = true;
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		bool_0 = flag;
		return result;
	}

	internal bool method_18(List<uint> list_0, List<byte[]> list_1, List<uint> list_2)
	{
		int count = list_0.Count;
		if (count == list_1.Count && count == list_2.Count)
		{
			bool[] array = new bool[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = false;
			}
			int num = 100;
			while (true)
			{
				if (!bool_0)
				{
					method_0();
				}
				if (bool_0)
				{
					int num2 = 0;
					for (int j = 0; j < count; j++)
					{
						if (!array[j])
						{
							uint num3 = list_2[j];
							num2 += (int)(9 + num3 + 1);
						}
					}
					byte[] array2 = new byte[4096];
					int num4 = 0;
					for (int k = 0; k < count; k++)
					{
						if (!array[k])
						{
							byte b = (byte)list_2[k];
							byte b2 = (byte)(2 + k);
							array2[num4] = 12;
							array2[num4 + 1] = b2;
							array2[num4 + 2] = (byte)(b + 6);
							array2[num4 + 3] = 15;
							array2[num4 + 4] = (byte)(list_0[k] >> 24);
							array2[num4 + 5] = (byte)(list_0[k] >> 16);
							array2[num4 + 6] = (byte)(list_0[k] >> 8);
							array2[num4 + 7] = (byte)list_0[k];
							array2[num4 + 8] = b;
							for (byte b3 = 0; b3 < b; b3++)
							{
								array2[num4 + 3 + 6 + b3] = list_1[k][b3];
							}
							byte b4 = 0;
							for (int l = 0; l < 9 + b; l++)
							{
								b4 += array2[num4 + l];
							}
							array2[num4 + 3 + 6 + b] = b4;
							num4 += 9 + b + 1;
						}
					}
					if (!method_4(array2, num2))
					{
						break;
					}
					Thread.Sleep(0);
					byte[] byte_ = new byte[4096];
					if (method_5(ref byte_, out var _, out var int_))
					{
						try
						{
							int num5 = int_;
							do
							{
								Enum14 @enum = (Enum14)byte_[num5];
								if (@enum == Enum14.BfN)
								{
									break;
								}
								if (@enum == Enum14.BfS && num5 + 2 < byte_.Length && byte_[num5 + 1] >= 192 && byte_[num5 + 1] <= 254)
								{
									byte b5 = byte_[num5 + 2];
									num5 += 3 + b5 + 1;
									continue;
								}
								if (method_2((byte)@enum))
								{
									num5++;
									continue;
								}
								Enum15 enum2 = (Enum15)byte_[num5 + 3];
								if (@enum == Enum14.BfS && enum2 == Enum15.BGj)
								{
									byte b6 = byte_[num5 + 2];
									byte b7 = 0;
									for (int m = 0; m < 3 + b6; m++)
									{
										b7 += byte_[num5 + m];
									}
									if (b7 == byte_[num5 + 3 + b6])
									{
										if (byte_[num5 + 3 + 1] == 0)
										{
											int num6 = byte_[num5 + 1] - 2;
											array[num6] = true;
										}
										num5 += 3 + b6 + 1;
										continue;
									}
									bool_0 = false;
									return false;
								}
								bool_0 = false;
								return false;
							}
							while (num5 < byte_.Length);
							bool flag = true;
							for (int n = 0; n < count; n++)
							{
								if (!array[n])
								{
									flag = false;
									break;
								}
							}
							if (flag)
							{
								return true;
							}
						}
						catch
						{
							bool_0 = false;
							return false;
						}
						num--;
						if (num == 0)
						{
							return false;
						}
						continue;
					}
					bool_0 = false;
					return false;
				}
				return false;
			}
			bool_0 = false;
			return false;
		}
		return false;
	}
}
