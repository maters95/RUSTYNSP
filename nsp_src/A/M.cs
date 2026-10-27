using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace A;

internal class M
{
	internal delegate string A(object P_0);

	internal static class a
	{
		internal static void A(uint[] P_0, uint[] P_1)
		{
			uint num = P_0[0];
			uint num2 = P_0[1];
			uint num3 = 0u;
			uint num4 = 2654435769u;
			uint num5 = 32u;
			while (num5-- != 0)
			{
				num += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num3 + P_1[num3 & 3]);
				num3 += num4;
				num2 += (((num << 4) ^ (num >> 5)) + num) ^ (num3 + P_1[(num3 >> 11) & 3]);
			}
			P_0[0] = num;
			P_0[1] = num2;
		}

		internal static byte[] A(string P_0, object P_1, object P_2, object P_3, object P_4)
		{
			return Encoding.ASCII.GetBytes(((A)P_2)(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAI(), (object)((A)P_3)(P_0), (object)((A)P_1)(P_0), (object)((A)P_4)(P_0))));
		}

		internal static void A(byte[] P_0, int P_1, byte[] P_2, int P_3)
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

		internal static void a(byte[] P_0, int P_1, byte[] P_2, int P_3)
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
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class B
	{
		public static readonly B BgM = new B();

		public static A Bgm;

		public static A BgN;

		public static A Bgn;

		public static A BgO;

		public static A Bgo;

		public static A BgP;

		public static A Bgp;

		public static A BgQ;

		public static A Bgq;

		public static A BgR;

		public static A Bgr;

		public static A BgS;

		internal string A(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAi() + (string)P_0;
		}

		internal string a(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAJ() + (string)P_0;
		}

		internal string B(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAj() + (string)P_0;
		}

		internal string b(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAK() + (string)P_0;
		}

		internal string C(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAk() + (string)P_0;
		}

		internal string c(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAL() + (string)P_0;
		}

		internal string D(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAl() + (string)P_0;
		}

		internal string d(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAM() + (string)P_0;
		}

		internal string E(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gf() + (string)P_0;
		}

		internal string e(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAm() + (string)P_0;
		}

		internal string F(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAN() + (string)P_0;
		}

		internal string f(object P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JR() + (string)P_0;
		}
	}

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

	internal static string A()
	{
		MD5 val = MD5.Create();
		byte[] array = M.a.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bI(), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAi() + (string)P_0), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAJ() + (string)P_0), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAj() + (string)P_0), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAK() + (string)P_0));
		byte[] array2 = ((HashAlgorithm)val).ComputeHash(array, 0, array.Length);
		((HashAlgorithm)val).Dispose();
		return A(array2);
	}

	internal static string a()
	{
		MD5 val = MD5.Create();
		byte[] array = M.a.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bi(), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAk() + (string)P_0), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAL() + (string)P_0), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAl() + (string)P_0), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAM() + (string)P_0));
		byte[] array2 = ((HashAlgorithm)val).ComputeHash(array, 0, array.Length);
		((HashAlgorithm)val).Dispose();
		return A(array2);
	}

	internal static string B()
	{
		MD5 val = MD5.Create();
		byte[] array = M.a.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bJ(), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gf() + (string)P_0), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAm() + (string)P_0), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAN() + (string)P_0), (A)((object P_0) => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JR() + (string)P_0));
		byte[] array2 = ((HashAlgorithm)val).ComputeHash(array, 0, array.Length);
		((HashAlgorithm)val).Dispose();
		return A(array2);
	}
}
internal static class m
{
	internal enum A
	{
		Bgs,
		BgT,
		Bgt
	}

	internal static void A(string P_0, string P_1, bool P_2, A P_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		DirectoryInfo val = new DirectoryInfo(P_0);
		if (!((FileSystemInfo)val).Exists)
		{
			return;
		}
		if (!Directory.Exists(P_1))
		{
			Directory.CreateDirectory(P_1);
		}
		FileInfo[] files = val.GetFiles();
		foreach (FileInfo val2 in files)
		{
			string text = Path.Combine(P_1, ((FileSystemInfo)val2).Name);
			if (File.Exists(text))
			{
				switch (P_3)
				{
				case m.A.Bgt:
					val2.CopyTo(text, true);
					break;
				case m.A.BgT:
					try
					{
						if (File.GetLastWriteTime(((FileSystemInfo)val2).FullName) > File.GetLastWriteTime(text))
						{
							val2.CopyTo(text, true);
						}
					}
					catch
					{
					}
					break;
				}
			}
			else
			{
				val2.CopyTo(text);
			}
		}
		if (P_2)
		{
			DirectoryInfo[] directories = val.GetDirectories();
			foreach (DirectoryInfo val3 in directories)
			{
				string text2 = Path.Combine(P_1, ((FileSystemInfo)val3).Name);
				A(((FileSystemInfo)val3).FullName, text2, P_2, P_3);
			}
		}
	}

	internal static string A(string P_0, string P_1, bool P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		DirectoryInfo val = new DirectoryInfo(P_0);
		FileInfo[] files = val.GetFiles();
		foreach (FileInfo val2 in files)
		{
			if (((FileSystemInfo)val2).Name == P_1)
			{
				return ((FileSystemInfo)val2).FullName;
			}
		}
		if (P_2)
		{
			DirectoryInfo[] directories = val.GetDirectories();
			for (int num = 0; num < directories.Length; num++)
			{
				string text = A(((FileSystemInfo)directories[num]).FullName, P_1, true);
				if (text != null)
				{
					return text;
				}
			}
		}
		return null;
	}

	internal static bool A(string P_0)
	{
		if (!P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bk()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bL()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bM()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bm()))
		{
			return P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bN());
		}
		return true;
	}
}
