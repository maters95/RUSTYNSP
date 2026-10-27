using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using c;

namespace A;

internal class J
{
	private enum A : byte
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
		BGA = 255,
		BGa = 170,
		BGB = 204,
		BGb = 221,
		BGC = 254
	}

	private enum a : byte
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

	private enum B : byte
	{
		BGL,
		BGl,
		BGM
	}

	private static byte[] bX;

	private static byte[] bx;

	private const byte bY = 170;

	private const byte by = 85;

	private const byte bZ = 119;

	private const int bz = 16;

	private const int CA = 64;

	private const int Ca = 3;

	private const int CB = 1;

	private const byte Cb = 192;

	private const byte CC = 254;

	private const int Cc = 9;

	private const int CD = 4096;

	private bool Cd;

	private cF CE;

	internal J(cF P_0)
	{
		CE = P_0;
	}

	private void A()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (!Cd)
		{
			byte[] array = new byte[16];
			byte b2 = bx[new Random(System.DateTime.Now.Millisecond).Next(4)];
			for (int num = 0; num < 16; num++)
			{
				array[num] = b2;
			}
			if (a(array, 16))
			{
				Thread.Sleep(0);
				byte[] array2 = new byte[4096];
				A(ref array2, out var _, out var _);
			}
		}
	}

	private bool A(byte P_0)
	{
		byte[] array = bx;
		for (int num = 0; num < array.Length; num++)
		{
			if (array[num] == P_0)
			{
				return true;
			}
		}
		return false;
	}

	private bool a(byte P_0)
	{
		if (P_0 == 254)
		{
			return true;
		}
		return A(P_0);
	}

	private int A(byte[] P_0, int P_1)
	{
		int num = 0;
		int num2 = 0;
		for (; num < P_1 && (a(P_0[num]) || P_0[num] == 0 || !Cd); num++)
		{
			byte b2 = P_0[num];
			if (A(b2))
			{
				Cd = true;
				num2++;
			}
			else if (b2 == 254)
			{
				Cd = false;
				num2++;
			}
		}
		return num2;
	}

	private bool a(byte[] P_0, int P_1)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		int num = P_1 % 16;
		if (num != 0)
		{
			num = 16 - num;
		}
		if (num >= 0)
		{
			byte b2 = bx[new Random(System.DateTime.Now.Millisecond).Next(4)];
			for (int num2 = 0; num2 < num; num2++)
			{
				if (P_1 < P_0.Length)
				{
					P_0[P_1] = b2;
					P_1++;
					continue;
				}
				return false;
			}
		}
		byte[] array = new byte[4096];
		A(P_0, P_1, bX, 9);
		if (A(P_0, P_1, out var num3, array))
		{
			if (CE.A(array, (uint)num3, out var num4))
			{
				if (num4 == num3)
				{
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private bool A(ref byte[] P_0, out bool P_1, out int P_2)
	{
		byte[] array = new byte[4096];
		bool flag = false;
		P_2 = 0;
		P_1 = false;
		if (CE.A(ref array, out var num))
		{
			flag = true;
		}
		else
		{
			flag = false;
			P_1 = true;
		}
		int num2 = 0;
		if (flag && num != 0)
		{
			int num3 = 0;
			int num4 = -1;
			int num5 = 0;
			while (num3 != -1 && num4 != num3)
			{
				num4 = num3;
				byte[] array2 = new byte[4096];
				A(array, num3, (int)num, out num3, out num5, array2);
				if (num5 > 0)
				{
					a(array2, num5, bX, 9);
					System.Array.Copy((System.Array)array2, 0, (System.Array)P_0, num2, num5);
					num2 += num5;
				}
			}
			P_2 = A(P_0, num2);
		}
		else
		{
			flag = false;
		}
		return flag;
	}

	private void A(byte[] P_0, int P_1, byte[] P_2, int P_3)
	{
		uint num = 2654435769u;
		int num2 = P_1 / 8;
		if (P_1 % 8 != 0)
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aO());
		}
		int num3 = 0;
		uint num4 = (uint)((P_2[num3] << 24) + (P_2[num3 + 1] << 16) + (P_2[num3 + 2] << 8) + P_2[num3 + 3]);
		num3 = 4;
		uint num5 = (uint)((P_2[num3] << 24) + (P_2[num3 + 1] << 16) + (P_2[num3 + 2] << 8) + P_2[num3 + 3]);
		num3 = 8;
		uint num6 = (uint)((P_2[num3] << 24) + (P_2[num3 + 1] << 16) + (P_2[num3 + 2] << 8) + P_2[num3 + 3]);
		num3 = 12;
		uint num7 = (uint)((P_2[num3] << 24) + (P_2[num3 + 1] << 16) + (P_2[num3 + 2] << 8) + P_2[num3 + 3]);
		for (int num8 = 0; num8 < num2; num8++)
		{
			int num9 = 8 * num8;
			int num10 = num9 + 4;
			uint num11 = (uint)((P_0[num9] << 24) + (P_0[num9 + 1] << 16) + (P_0[num9 + 2] << 8) + P_0[num9 + 3]);
			uint num12 = (uint)((P_0[num10] << 24) + (P_0[num10 + 1] << 16) + (P_0[num10 + 2] << 8) + P_0[num10 + 3]);
			uint num13 = 0u;
			for (int num14 = 0; num14 < P_3; num14++)
			{
				num13 += num;
				num11 += ((num12 << 4) + num4) ^ (num12 + num13) ^ ((num12 >> 5) + num5);
				num12 += ((num11 << 4) + num6) ^ (num11 + num13) ^ ((num11 >> 5) + num7);
			}
			P_0[num9] = (byte)(num11 >> 24);
			P_0[num9 + 1] = (byte)(num11 >> 16);
			P_0[num9 + 2] = (byte)(num11 >> 8);
			P_0[num9 + 3] = (byte)num11;
			P_0[num10] = (byte)(num12 >> 24);
			P_0[num10 + 1] = (byte)(num12 >> 16);
			P_0[num10 + 2] = (byte)(num12 >> 8);
			P_0[num10 + 3] = (byte)num12;
		}
	}

	private void a(byte[] P_0, int P_1, byte[] P_2, int P_3)
	{
		uint num = 2654435769u;
		int num2 = P_1 / 8;
		if (P_1 % 8 != 0)
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ao());
		}
		int num3 = 0;
		uint num4 = (uint)((P_2[num3] << 24) + (P_2[num3 + 1] << 16) + (P_2[num3 + 2] << 8) + P_2[num3 + 3]);
		num3 = 4;
		uint num5 = (uint)((P_2[num3] << 24) + (P_2[num3 + 1] << 16) + (P_2[num3 + 2] << 8) + P_2[num3 + 3]);
		num3 = 8;
		uint num6 = (uint)((P_2[num3] << 24) + (P_2[num3 + 1] << 16) + (P_2[num3 + 2] << 8) + P_2[num3 + 3]);
		num3 = 12;
		uint num7 = (uint)((P_2[num3] << 24) + (P_2[num3 + 1] << 16) + (P_2[num3 + 2] << 8) + P_2[num3 + 3]);
		for (int num8 = 0; num8 < num2; num8++)
		{
			int num9 = 8 * num8;
			int num10 = num9 + 4;
			uint num11 = (uint)((P_0[num9] << 24) + (P_0[num9 + 1] << 16) + (P_0[num9 + 2] << 8) + P_0[num9 + 3]);
			uint num12 = (uint)((P_0[num10] << 24) + (P_0[num10 + 1] << 16) + (P_0[num10 + 2] << 8) + P_0[num10 + 3]);
			uint num13 = num * (uint)P_3;
			for (int num14 = 0; num14 < P_3; num14++)
			{
				num12 -= ((num11 << 4) + num6) ^ (num11 + num13) ^ ((num11 >> 5) + num7);
				num11 -= ((num12 << 4) + num4) ^ (num12 + num13) ^ ((num12 >> 5) + num5);
				num13 -= num;
			}
			P_0[num9] = (byte)(num11 >> 24);
			P_0[num9 + 1] = (byte)(num11 >> 16);
			P_0[num9 + 2] = (byte)(num11 >> 8);
			P_0[num9 + 3] = (byte)num11;
			P_0[num10] = (byte)(num12 >> 24);
			P_0[num10 + 1] = (byte)(num12 >> 16);
			P_0[num10 + 2] = (byte)(num12 >> 8);
			P_0[num10 + 3] = (byte)num12;
		}
	}

	private bool A(byte[] P_0, int P_1, out int P_2, byte[] P_3)
	{
		P_2 = 0;
		P_3[P_2] = 170;
		P_2++;
		for (int num = 0; num < P_1; num++)
		{
			if (num != 0 && num % 64 == 0)
			{
				if (P_2 + 1 >= P_3.Length)
				{
					return false;
				}
				P_3[P_2] = 85;
				P_2++;
				P_3[P_2] = 170;
				P_2++;
			}
			byte b2 = P_0[num];
			if (b2 == 170 || b2 == 85 || b2 == 119)
			{
				if (P_2 >= P_3.Length)
				{
					return false;
				}
				P_3[P_2] = 119;
				P_2++;
			}
			if (P_2 < P_3.Length)
			{
				P_3[P_2] = b2;
				P_2++;
				continue;
			}
			return false;
		}
		if (P_2 < P_3.Length)
		{
			P_3[P_2] = 85;
			P_2++;
			return true;
		}
		return false;
	}

	private void A(byte[] P_0, int P_1, int P_2, out int P_3, out int P_4, byte[] P_5)
	{
		P_4 = 0;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		P_3 = -1;
		for (int num = P_1; num < P_2; num++)
		{
			byte b2 = P_0[num];
			if (num == P_1 && b2 == 170)
			{
				flag = true;
				continue;
			}
			if (b2 == 119 && !flag3)
			{
				flag3 = true;
				continue;
			}
			if (b2 == 85 && !flag3)
			{
				flag2 = true;
				continue;
			}
			if (b2 == 170 && !flag3)
			{
				P_3 = num;
				if (!flag2)
				{
					P_4 = 0;
				}
				break;
			}
			if (P_4 < 64)
			{
				P_5[P_4] = b2;
				P_4++;
				flag3 = false;
			}
		}
		if (!(flag && flag2) || P_4 % 16 != 0)
		{
			P_4 = 0;
			if (flag && !flag2 && P_3 == -1)
			{
				P_3 = P_1;
			}
		}
	}

	private int B(byte[] P_0, int P_1)
	{
		int num = P_1;
		do
		{
			A a2 = (A)P_0[num];
			if (a2 == J.A.BfS && num + 2 < P_0.Length && P_0[num + 1] >= 192 && P_0[num + 1] <= 254)
			{
				byte b2 = P_0[num + 2];
				num += 3 + b2 + 1;
				continue;
			}
			if (!a((byte)a2) && a2 != 0)
			{
				break;
			}
			num++;
		}
		while (num < P_0.Length);
		return num;
	}

	internal bool A(out byte[] P_0)
	{
		if (!Cd)
		{
			A();
		}
		P_0 = null;
		if (!Cd)
		{
			return false;
		}
		int num = 3;
		byte[] array = new byte[4096];
		array[0] = 54;
		array[1] = 1;
		byte b2 = 0;
		for (int num2 = 0; num2 < 2; num2++)
		{
			b2 += array[num2];
		}
		array[2] = b2;
		bool flag = false;
		if (a(array, num))
		{
			Thread.Sleep(0);
			byte[] array2 = new byte[4096];
			if (A(ref array2, out var _, out var num3))
			{
				try
				{
					int num4 = B(array2, num3);
					if (num4 < array2.Length && array2[num4] == 54)
					{
						if (!Cd)
						{
							return false;
						}
						byte b3 = array2[num4 + 2];
						b2 = 0;
						for (int num5 = 0; num5 < 3 + b3; num5++)
						{
							b2 += array2[num4 + num5];
						}
						P_0 = new byte[b3];
						for (int num6 = 0; num6 < b3; num6++)
						{
							P_0[num6] = array2[num4 + 3 + num6];
						}
						if (b2 == array2[num4 + 3 + b3])
						{
							flag = true;
						}
					}
				}
				catch
				{
				}
			}
		}
		Cd = flag;
		return flag;
	}

	internal void a()
	{
		if (!Cd)
		{
			A();
		}
		if (Cd)
		{
			int num = 3;
			byte[] array = new byte[4096];
			array[0] = 7;
			array[1] = 1;
			byte b2 = 0;
			for (int num2 = 0; num2 < 2; num2++)
			{
				b2 += array[num2];
			}
			array[2] = b2;
			if (!a(array, num))
			{
				Cd = false;
			}
		}
	}

	internal void B()
	{
		if (!Cd)
		{
			A();
		}
		if (Cd)
		{
			int num = 11;
			byte[] array = new byte[4096];
			array[0] = 57;
			array[1] = 1;
			array[2] = 7;
			byte[] array2 = new byte[7];
			RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] array3 = array2;
			for (int num2 = 0; num2 < 7; num2++)
			{
				array[3 + num2] = array3[num2];
			}
			byte b2 = 0;
			for (int num3 = 0; num3 < 10; num3++)
			{
				b2 += array[num3];
			}
			array[10] = b2;
			if (!a(array, num))
			{
				Cd = false;
			}
		}
	}

	internal bool A(byte P_0, uint P_1, uint P_2, uint P_3, byte P_4, byte P_5, byte P_6, byte P_7, out int P_8)
	{
		P_8 = 65535;
		if (!Cd)
		{
			A();
		}
		if (!Cd)
		{
			return false;
		}
		int num = 22;
		byte[] array = new byte[4096];
		array[0] = 12;
		array[1] = 1;
		array[2] = 18;
		array[3] = 14;
		array[4] = P_0;
		array[5] = (byte)(P_1 >> 24);
		array[6] = (byte)(P_1 >> 16);
		array[7] = (byte)(P_1 >> 8);
		array[8] = (byte)P_1;
		array[9] = (byte)(P_2 >> 24);
		array[10] = (byte)(P_2 >> 16);
		array[11] = (byte)(P_2 >> 8);
		array[12] = (byte)P_2;
		array[13] = (byte)(P_3 >> 24);
		array[14] = (byte)(P_3 >> 16);
		array[15] = (byte)(P_3 >> 8);
		array[16] = (byte)P_3;
		array[17] = P_4;
		array[18] = P_5;
		array[19] = P_6;
		array[20] = P_7;
		byte b2 = 0;
		for (int num2 = 0; num2 < 21; num2++)
		{
			b2 += array[num2];
		}
		array[21] = b2;
		bool cd = false;
		bool result = false;
		if (a(array, num))
		{
			Thread.Sleep(0);
			byte[] array2 = new byte[4096];
			if (A(ref array2, out var _, out var num3))
			{
				try
				{
					int num4 = B(array2, num3);
					if (num4 < array2.Length)
					{
						byte num5 = array2[num4];
						a a2 = (a)array2[num4 + 3];
						if (num5 == 12 && a2 == J.a.BGJ)
						{
							if (!Cd)
							{
								return false;
							}
							byte b3 = array2[num4 + 2];
							byte b4 = 0;
							for (int num6 = 0; num6 < 3 + b3; num6++)
							{
								b4 += array2[num4 + num6];
							}
							if (b4 == array2[num4 + 3 + b3])
							{
								cd = true;
								if (array2[num4 + 3 + 1] == 0)
								{
									P_8 = (ushort)((ushort)(array2[num4 + 5] << 8) + array2[num4 + 6]);
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
		Cd = cd;
		return result;
	}

	internal bool A(byte P_0, byte P_1, byte P_2, byte P_3, byte P_4, byte P_5)
	{
		if (!Cd)
		{
			A();
		}
		if (!Cd)
		{
			return false;
		}
		int num = 11;
		byte[] array = new byte[4096];
		array[0] = 12;
		array[1] = 1;
		array[2] = 7;
		array[3] = 16;
		array[4] = P_0;
		array[5] = P_1;
		array[6] = P_2;
		array[7] = P_3;
		array[8] = P_4;
		array[9] = P_5;
		byte b2 = 0;
		for (int num2 = 0; num2 < 10; num2++)
		{
			b2 += array[num2];
		}
		array[10] = b2;
		bool cd = false;
		bool result = false;
		if (a(array, num))
		{
			Thread.Sleep(0);
			byte[] array2 = new byte[4096];
			if (A(ref array2, out var _, out var num3))
			{
				try
				{
					int num4 = B(array2, num3);
					if (num4 < array2.Length)
					{
						byte num5 = array2[num4];
						a a2 = (a)array2[num4 + 3];
						if (num5 == 12 && a2 == J.a.BGK)
						{
							if (!Cd)
							{
								return false;
							}
							byte b3 = array2[num4 + 2];
							byte b4 = 0;
							for (int num6 = 0; num6 < 3 + b3; num6++)
							{
								b4 += array2[num4 + num6];
							}
							if (b4 == array2[num4 + 3 + b3])
							{
								cd = true;
								if (array2[num4 + 3 + 1] == 0)
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
		Cd = cd;
		return result;
	}

	internal bool b()
	{
		if (!Cd)
		{
			A();
		}
		if (!Cd)
		{
			return false;
		}
		int num = 11;
		byte[] array = new byte[4096];
		array[0] = 32;
		array[1] = 1;
		array[2] = 7;
		byte[] array2 = new byte[7];
		RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] array3 = array2;
		for (int num2 = 0; num2 < 7; num2++)
		{
			array[3 + num2] = array3[num2];
		}
		byte b2 = 0;
		for (int num3 = 0; num3 < 10; num3++)
		{
			b2 += array[num3];
		}
		array[10] = b2;
		bool cd = false;
		bool result = false;
		if (a(array, num))
		{
			Thread.Sleep(0);
			byte[] array4 = new byte[4096];
			if (A(ref array4, out var _, out var num4))
			{
				try
				{
					int num5 = B(array4, num4);
					if (num5 < array4.Length && array4[num5] == 32)
					{
						if (!Cd)
						{
							return false;
						}
						byte b3 = array4[num5 + 2];
						byte b4 = 0;
						for (int num6 = 0; num6 < 3 + b3; num6++)
						{
							b4 += array4[num5 + num6];
						}
						if (b4 == array4[num5 + 3 + b3])
						{
							cd = true;
							if (array4[num5 + 3] == 0)
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
		Cd = cd;
		return result;
	}

	internal bool C()
	{
		if (!Cd)
		{
			A();
		}
		if (!Cd)
		{
			return false;
		}
		int num = 3;
		byte[] array = new byte[4096];
		array[0] = 33;
		array[1] = 1;
		byte b2 = 0;
		for (int num2 = 0; num2 < 2; num2++)
		{
			b2 += array[num2];
		}
		array[2] = b2;
		bool cd = false;
		bool result = false;
		if (a(array, num))
		{
			Thread.Sleep(0);
			byte[] array2 = new byte[4096];
			if (A(ref array2, out var _, out var num3))
			{
				try
				{
					int num4 = B(array2, num3);
					if (num4 < array2.Length && array2[num4] == 33)
					{
						if (!Cd)
						{
							return false;
						}
						byte b3 = array2[num4 + 2];
						byte b4 = 0;
						for (int num5 = 0; num5 < 3 + b3; num5++)
						{
							b4 += array2[num4 + num5];
						}
						if (b4 == array2[num4 + 3 + b3])
						{
							cd = true;
							if (array2[num4 + 3] == 0)
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
		Cd = cd;
		return result;
	}

	internal bool A(List<uint> P_0, List<byte[]> P_1, List<uint> P_2)
	{
		int count = P_0.Count;
		if (count != P_1.Count || count != P_2.Count)
		{
			return false;
		}
		bool[] array = new bool[count];
		for (int num = 0; num < count; num++)
		{
			array[num] = false;
		}
		int num2 = 100;
		do
		{
			if (!Cd)
			{
				A();
			}
			if (!Cd)
			{
				return false;
			}
			int num3 = 0;
			for (int num4 = 0; num4 < count; num4++)
			{
				if (!array[num4])
				{
					uint num5 = P_2[num4];
					num3 += (int)(9 + num5 + 1);
				}
			}
			byte[] array2 = new byte[4096];
			int num6 = 0;
			for (int num7 = 0; num7 < count; num7++)
			{
				if (!array[num7])
				{
					byte b2 = (byte)P_2[num7];
					byte b3 = (byte)(2 + num7);
					array2[num6] = 12;
					array2[num6 + 1] = b3;
					array2[num6 + 2] = (byte)(b2 + 6);
					array2[num6 + 3] = 15;
					array2[num6 + 4] = (byte)(P_0[num7] >> 24);
					array2[num6 + 5] = (byte)(P_0[num7] >> 16);
					array2[num6 + 6] = (byte)(P_0[num7] >> 8);
					array2[num6 + 7] = (byte)P_0[num7];
					array2[num6 + 8] = b2;
					for (byte b4 = 0; b4 < b2; b4++)
					{
						array2[num6 + 3 + 6 + b4] = P_1[num7][b4];
					}
					byte b5 = 0;
					for (int num8 = 0; num8 < 9 + b2; num8++)
					{
						b5 += array2[num6 + num8];
					}
					array2[num6 + 3 + 6 + b2] = b5;
					num6 += 9 + b2 + 1;
				}
			}
			if (a(array2, num3))
			{
				Thread.Sleep(0);
				byte[] array3 = new byte[4096];
				if (A(ref array3, out var _, out var num9))
				{
					try
					{
						int num10 = num9;
						do
						{
							A a2 = (A)array3[num10];
							if (a2 == J.A.BfN)
							{
								break;
							}
							if (a2 == J.A.BfS && num10 + 2 < array3.Length && array3[num10 + 1] >= 192 && array3[num10 + 1] <= 254)
							{
								byte b6 = array3[num10 + 2];
								num10 += 3 + b6 + 1;
								continue;
							}
							if (a((byte)a2))
							{
								num10++;
								continue;
							}
							a a3 = (a)array3[num10 + 3];
							if (a2 == J.A.BfS && a3 == J.a.BGj)
							{
								byte b7 = array3[num10 + 2];
								byte b8 = 0;
								for (int num11 = 0; num11 < 3 + b7; num11++)
								{
									b8 += array3[num10 + num11];
								}
								if (b8 != array3[num10 + 3 + b7])
								{
									Cd = false;
									return false;
								}
								if (array3[num10 + 3 + 1] == 0)
								{
									int num12 = array3[num10 + 1] - 2;
									array[num12] = true;
								}
								num10 += 3 + b7 + 1;
								continue;
							}
							Cd = false;
							return false;
						}
						while (num10 < array3.Length);
						bool flag2 = true;
						for (int num13 = 0; num13 < count; num13++)
						{
							if (!array[num13])
							{
								flag2 = false;
								break;
							}
						}
						if (flag2)
						{
							return true;
						}
					}
					catch
					{
						Cd = false;
						return false;
					}
					num2--;
					continue;
				}
				Cd = false;
				return false;
			}
			Cd = false;
			return false;
		}
		while (num2 != 0);
		return false;
	}

	static J()
	{
		byte[] array = new byte[16];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		bX = array;
		byte[] array2 = new byte[4];
		RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		bx = array2;
	}
}
internal class j
{
	private readonly Encoding Ce = Encoding.GetEncoding(65001);

	internal const int CF = 50;

	internal const int Cf = 60;

	internal byte[] CG = new byte[50];

	internal A.C Cg;

	internal uint CH;

	internal uint Ch;

	internal byte[] A()
	{
		byte[] array = new byte[60];
		System.Array.Copy((System.Array)CG, 0, (System.Array)array, 0, 50);
		array[50] = (byte)Cg;
		array[51] = 0;
		array[52] = (byte)((CH >> 24) & 0xFFu);
		array[53] = (byte)((CH >> 16) & 0xFFu);
		array[54] = (byte)((CH >> 8) & 0xFFu);
		array[55] = (byte)(CH & 0xFFu);
		array[56] = (byte)((Ch >> 24) & 0xFFu);
		array[57] = (byte)((Ch >> 16) & 0xFFu);
		array[58] = (byte)((Ch >> 8) & 0xFFu);
		array[59] = (byte)(Ch & 0xFFu);
		return array;
	}

	internal void A(byte[] P_0)
	{
		System.Array.Copy((System.Array)P_0, 0, (System.Array)CG, 0, 50);
		Cg = (A.C)P_0[50];
		CH = (uint)(P_0[52] << 24) | ((uint)(P_0[53] << 16) & 0xFF0000u) | ((uint)(P_0[54] << 8) & 0xFF00u) | (P_0[55] & 0xFFu);
		Ch = (uint)(P_0[56] << 24) | ((uint)(P_0[57] << 16) & 0xFF0000u) | ((uint)(P_0[58] << 8) & 0xFF00u) | (P_0[59] & 0xFFu);
	}

	[SpecialName]
	internal string a()
	{
		string @string = Ce.GetString(CG);
		int num = @string.IndexOf('\0');
		if (num == -1)
		{
			num = @string.Length;
		}
		return @string.Substring(0, num);
	}

	[SpecialName]
	internal void A(string P_0)
	{
		byte[] bytes = Ce.GetBytes(P_0);
		for (int num = 0; num < CG.Length; num++)
		{
			if (num < bytes.Length)
			{
				CG[num] = bytes[num];
			}
			else
			{
				CG[num] = 0;
			}
		}
	}

	public virtual string ToString()
	{
		return string.Concat(new string[8]
		{
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aP(),
			a(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ap(),
			((object)Cg).ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aQ(),
			CH.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aq(),
			Ch.ToString()
		});
	}
}
