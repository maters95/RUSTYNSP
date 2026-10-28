using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using ns7;

namespace ns0;

internal class Class19
{
	internal delegate string Delegate3(object object_0);

	internal static class Class20
	{
		internal static void smethod_0(uint[] uint_0, uint[] uint_1)
		{
			uint num = uint_0[0];
			uint num2 = uint_0[1];
			uint num3 = 0u;
			uint num4 = 2654435769u;
			uint num5 = 32u;
			while (num5-- != 0)
			{
				num += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num3 + uint_1[num3 & 3]);
				num3 += num4;
				num2 += (((num << 4) ^ (num >> 5)) + num) ^ (num3 + uint_1[(num3 >> 11) & 3]);
			}
			uint_0[0] = num;
			uint_0[1] = num2;
		}

		internal static byte[] smethod_1(string string_0, object object_0, object object_1, object object_2, object object_3)
		{
			return Encoding.ASCII.GetBytes(((Delegate3)object_1)(string.Format(Class333.BAI(), ((Delegate3)object_2)(string_0), ((Delegate3)object_0)(string_0), ((Delegate3)object_3)(string_0))));
		}

		internal static void smethod_2(byte[] byte_0, int int_0, byte[] byte_1, int int_1)
		{
			uint num = 2654435769u;
			int num2 = int_0 / 8;
			if (int_0 % 8 != 0)
			{
				throw new Exception(Class333.smethod_81());
			}
			uint num3 = (uint)((byte_1[0] << 24) + (byte_1[1] << 16) + (byte_1[2] << 8) + byte_1[3]);
			uint num4 = (uint)((byte_1[4] << 24) + (byte_1[5] << 16) + (byte_1[6] << 8) + byte_1[7]);
			uint num5 = (uint)((byte_1[8] << 24) + (byte_1[9] << 16) + (byte_1[10] << 8) + byte_1[11]);
			uint num6 = (uint)((byte_1[12] << 24) + (byte_1[13] << 16) + (byte_1[14] << 8) + byte_1[15]);
			for (int i = 0; i < num2; i++)
			{
				int num7 = 8 * i;
				int num8 = num7 + 4;
				uint num9 = (uint)((byte_0[num7] << 24) + (byte_0[num7 + 1] << 16) + (byte_0[num7 + 2] << 8) + byte_0[num7 + 3]);
				uint num10 = (uint)((byte_0[num8] << 24) + (byte_0[num8 + 1] << 16) + (byte_0[num8 + 2] << 8) + byte_0[num8 + 3]);
				uint num11 = 0u;
				for (int j = 0; j < int_1; j++)
				{
					num11 += num;
					num9 += ((num10 << 4) + num3) ^ (num10 + num11) ^ ((num10 >> 5) + num4);
					num10 += ((num9 << 4) + num5) ^ (num9 + num11) ^ ((num9 >> 5) + num6);
				}
				byte_0[num7] = (byte)(num9 >> 24);
				byte_0[num7 + 1] = (byte)(num9 >> 16);
				byte_0[num7 + 2] = (byte)(num9 >> 8);
				byte_0[num7 + 3] = (byte)num9;
				byte_0[num8] = (byte)(num10 >> 24);
				byte_0[num8 + 1] = (byte)(num10 >> 16);
				byte_0[num8 + 2] = (byte)(num10 >> 8);
				byte_0[num8 + 3] = (byte)num10;
			}
		}

		internal static void smethod_3(byte[] byte_0, int int_0, byte[] byte_1, int int_1)
		{
			uint num = 2654435769u;
			int num2 = int_0 / 8;
			if (int_0 % 8 != 0)
			{
				throw new Exception(Class333.smethod_82());
			}
			uint num3 = (uint)((byte_1[0] << 24) + (byte_1[1] << 16) + (byte_1[2] << 8) + byte_1[3]);
			uint num4 = (uint)((byte_1[4] << 24) + (byte_1[5] << 16) + (byte_1[6] << 8) + byte_1[7]);
			uint num5 = (uint)((byte_1[8] << 24) + (byte_1[9] << 16) + (byte_1[10] << 8) + byte_1[11]);
			uint num6 = (uint)((byte_1[12] << 24) + (byte_1[13] << 16) + (byte_1[14] << 8) + byte_1[15]);
			for (int i = 0; i < num2; i++)
			{
				int num7 = 8 * i;
				int num8 = num7 + 4;
				uint num9 = (uint)((byte_0[num7] << 24) + (byte_0[num7 + 1] << 16) + (byte_0[num7 + 2] << 8) + byte_0[num7 + 3]);
				uint num10 = (uint)((byte_0[num8] << 24) + (byte_0[num8 + 1] << 16) + (byte_0[num8 + 2] << 8) + byte_0[num8 + 3]);
				uint num11 = num * (uint)int_1;
				for (int j = 0; j < int_1; j++)
				{
					num10 -= ((num9 << 4) + num5) ^ (num9 + num11) ^ ((num9 >> 5) + num6);
					num9 -= ((num10 << 4) + num3) ^ (num10 + num11) ^ ((num10 >> 5) + num4);
					num11 -= num;
				}
				byte_0[num7] = (byte)(num9 >> 24);
				byte_0[num7 + 1] = (byte)(num9 >> 16);
				byte_0[num7 + 2] = (byte)(num9 >> 8);
				byte_0[num7 + 3] = (byte)num9;
				byte_0[num8] = (byte)(num10 >> 24);
				byte_0[num8 + 1] = (byte)(num10 >> 16);
				byte_0[num8 + 2] = (byte)(num10 >> 8);
				byte_0[num8 + 3] = (byte)num10;
			}
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class21
	{
		public static readonly Class21 BgM = new Class21();

		public static Delegate3 Bgm;

		public static Delegate3 BgN;

		public static Delegate3 Bgn;

		public static Delegate3 BgO;

		public static Delegate3 Bgo;

		public static Delegate3 BgP;

		public static Delegate3 Bgp;

		public static Delegate3 BgQ;

		public static Delegate3 Bgq;

		public static Delegate3 BgR;

		public static Delegate3 Bgr;

		public static Delegate3 BgS;

		internal string method_0(object object_0)
		{
			return Class333.BAi() + (string)object_0;
		}

		internal string method_1(object object_0)
		{
			return Class333.BAJ() + (string)object_0;
		}

		internal string method_2(object object_0)
		{
			return Class333.BAj() + (string)object_0;
		}

		internal string method_3(object object_0)
		{
			return Class333.BAK() + (string)object_0;
		}

		internal string method_4(object object_0)
		{
			return Class333.BAk() + (string)object_0;
		}

		internal string method_5(object object_0)
		{
			return Class333.BAL() + (string)object_0;
		}

		internal string method_6(object object_0)
		{
			return Class333.BAl() + (string)object_0;
		}

		internal string method_7(object object_0)
		{
			return Class333.BAM() + (string)object_0;
		}

		internal string method_8(object object_0)
		{
			return Class333.smethod_688() + (string)object_0;
		}

		internal string method_9(object object_0)
		{
			return Class333.BAm() + (string)object_0;
		}

		internal string method_10(object object_0)
		{
			return Class333.BAN() + (string)object_0;
		}

		internal string method_11(object object_0)
		{
			return Class333.smethod_971() + (string)object_0;
		}
	}

	internal static string smethod_0(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
		foreach (byte b in byte_0)
		{
			stringBuilder.AppendFormat(Class333.smethod_80(), b);
		}
		return stringBuilder.ToString();
	}

	internal static string smethod_1()
	{
		MD5 mD = MD5.Create();
		byte[] array = Class20.smethod_1(Class333.smethod_173(), (Delegate3)((object object_0) => Class333.BAi() + (string)object_0), (Delegate3)((object object_0) => Class333.BAJ() + (string)object_0), (Delegate3)((object object_0) => Class333.BAj() + (string)object_0), (Delegate3)((object object_0) => Class333.BAK() + (string)object_0));
		byte[] byte_ = mD.ComputeHash(array, 0, array.Length);
		mD.Dispose();
		return smethod_0(byte_);
	}

	internal static string smethod_2()
	{
		MD5 mD = MD5.Create();
		byte[] array = Class20.smethod_1(Class333.smethod_174(), (Delegate3)((object object_0) => Class333.BAk() + (string)object_0), (Delegate3)((object object_0) => Class333.BAL() + (string)object_0), (Delegate3)((object object_0) => Class333.BAl() + (string)object_0), (Delegate3)((object object_0) => Class333.BAM() + (string)object_0));
		byte[] byte_ = mD.ComputeHash(array, 0, array.Length);
		mD.Dispose();
		return smethod_0(byte_);
	}

	internal static string smethod_3()
	{
		MD5 mD = MD5.Create();
		byte[] array = Class20.smethod_1(Class333.smethod_175(), (Delegate3)((object object_0) => Class333.smethod_688() + (string)object_0), (Delegate3)((object object_0) => Class333.BAm() + (string)object_0), (Delegate3)((object object_0) => Class333.BAN() + (string)object_0), (Delegate3)((object object_0) => Class333.smethod_971() + (string)object_0));
		byte[] byte_ = mD.ComputeHash(array, 0, array.Length);
		mD.Dispose();
		return smethod_0(byte_);
	}
}
