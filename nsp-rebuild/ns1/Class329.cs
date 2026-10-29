using System;
using System.Runtime.CompilerServices;
using System.Threading;
using NSP.SettingsFramework;
using ns0;
using ns7;

namespace ns1;

internal class Class329
{
	[CompilerGenerated]
	private static class Class330
	{
		public static EventHandler BtN;
	}

	internal const int Bdt = 3;

	internal const int BdU = 12;

	internal const int Bdu = 4;

	private static Class331 BdV;

	private static string Bdv = Class333.azg();

	internal static int BdW = 32768;

	internal static int Bdw = 0;

	internal static int BdX = 0;

	internal static int Bdx = 0;

	internal static int BdY = 0;

	internal static Class51 Bdy = null;

	private static Framework BdZ = null;

	internal static byte[] Bdz;

	internal static void smethod_0(Framework framework_0, Class51 class51_0)
	{
		if (BdZ != null)
		{
			BdZ.method_51(smethod_2);
		}
		BdZ = framework_0;
		Class5 @class = Class1.smethod_26(BdZ.aXc);
		if (@class == null)
		{
			@class = smethod_1(BdZ);
		}
		Bdw = (int)@class.struct1_0[35].uint_0;
		BdX = (int)@class.struct1_0[35].uint_1;
		Bdx = (int)@class.struct1_0[33].uint_0;
		BdY = (int)@class.struct1_0[33].uint_1;
		BdW = BdY + 12 + 4;
		Bdz = new byte[BdW];
		Bdy = class51_0;
		if (BdV == null)
		{
			BdV = new Class331(Bdv);
		}
		if (BdZ != null)
		{
			BdZ.method_51(smethod_2);
			BdZ.method_50(smethod_2);
		}
	}

	private static Class5 smethod_1(Framework framework_0)
	{
		byte[] array = new byte[1024];
		array[0] = (byte)framework_0.aXA.method_0();
		array[1] = (byte)framework_0.aXA.method_1();
		array[2] = (byte)framework_0.aXA.method_2();
		array[3] = (byte)framework_0.aXA.method_3();
		array[4] = (byte)((framework_0.aXA.method_4() >> 24) & 0xFF);
		array[5] = (byte)((framework_0.aXA.method_4() >> 16) & 0xFF);
		array[6] = (byte)((framework_0.aXA.method_4() >> 8) & 0xFF);
		array[7] = (byte)(framework_0.aXA.method_4() & 0xFF);
		array[8] = 21;
		for (int i = 9; i < 1024; i++)
		{
			array[i] = byte.MaxValue;
		}
		Class5 @class = new Class5();
		@class.method_0(array);
		@class.method_4(null);
		return @class;
	}

	private static void smethod_2(object sender, EventArgs e)
	{
		if (BdZ != null && smethod_3())
		{
			if (sender is Setting)
			{
				smethod_4(sender as Setting);
			}
			else
			{
				smethod_5();
			}
		}
	}

	internal static bool smethod_3()
	{
		if (BdV != null)
		{
			return BdV.method_0();
		}
		return false;
	}

	internal static void smethod_4(Setting setting_0)
	{
		if (BdZ == null || BdX == 0)
		{
			return;
		}
		if (BdV != null && !BdV.method_0())
		{
			BdV.method_1();
		}
		if (!smethod_3())
		{
			return;
		}
		byte[] byte_ = setting_0.method_259();
		int num = 0;
		bool flag;
		do
		{
			if (!(flag = smethod_7(byte_, setting_0.method_65())))
			{
				num++;
				Thread.Sleep(20);
			}
		}
		while (!flag && num < 3);
	}

	internal static void smethod_5()
	{
		if (BdZ == null || BdX == 0)
		{
			return;
		}
		if (BdV != null && !BdV.method_0())
		{
			BdV.method_1();
		}
		if (!smethod_3() || BdZ == null)
		{
			return;
		}
		int num = 0;
		bool flag;
		do
		{
			if (!(flag = smethod_8(BdZ.method_21())))
			{
				num++;
				Thread.Sleep(20);
			}
		}
		while (!flag && num < 3 && BdZ != null);
	}

	internal static void smethod_6(bool bool_0 = false)
	{
		if (BdZ == null || BdX == 0 || (Bdy != null && Bdy.class55_0 != null && Bdy.class55_0.BiE && !bool_0))
		{
			return;
		}
		if (BdV != null && !BdV.method_0())
		{
			BdV.method_1();
		}
		if (!smethod_3() || BdZ == null)
		{
			return;
		}
		int num = 0;
		bool flag;
		do
		{
			if (!(flag = smethod_9(BdZ.method_23())))
			{
				num++;
				Thread.Sleep(20);
			}
		}
		while (!flag && num < 3 && BdZ != null);
	}

	internal static bool smethod_7(byte[] byte_0, int int_0)
	{
		if (BdX == 0)
		{
			return false;
		}
		if (BdV != null && !BdV.method_0())
		{
			BdV.method_1();
		}
		if (BdV != null && BdV.method_0())
		{
			return BdV.method_4(byte_0, 0, byte_0.Length, Bdw + int_0, bool_0: true);
		}
		return false;
	}

	internal static bool smethod_8(byte[] byte_0)
	{
		if (BdX == 0)
		{
			return false;
		}
		if (BdV != null && !BdV.method_0())
		{
			BdV.method_1();
		}
		if (BdV != null && BdV.method_0())
		{
			bool flag = true;
			int num = 0;
			do
			{
				int num2 = Math.Min(BdW - 16, BdX - num);
				flag &= BdV.method_4(byte_0, num, num2, Bdw, bool_0: true);
				num += num2;
			}
			while (num < BdX);
			return flag;
		}
		return false;
	}

	internal static bool smethod_9(byte[] byte_0)
	{
		if (BdZ != null && BdY != 0)
		{
			if (BdV != null && !BdV.method_0())
			{
				BdV.method_1();
			}
			try
			{
				bool simulating = Bdy != null && Bdy.class55_0 != null && Bdy.class55_0.BiE;
				if (simulating)
				{
					Array.Clear(Bdz, 0, Bdz.Length);
					Bdy.method_7(ref Bdz);
				}
				NSP.LiveDataMirror.Publish(Bdx, simulating ? Bdz : byte_0, BdY, simulating);
				if (BdV != null && BdV.method_0())
				{
					bool flag = false;
					return (Bdy == null || Bdy.class55_0 == null || !Bdy.class55_0.BiE) ? BdV.method_4(byte_0, 0, BdY, Bdx) : BdV.method_4(Bdz, 0, BdY, Bdx);
				}
				return false;
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.azG() + ex.Message);
				return false;
			}
		}
		return false;
	}

	internal static void smethod_10()
	{
		if (BdV != null)
		{
			BdV.method_8();
		}
	}

	internal static void smethod_11(bool bool_0 = true)
	{
		if (BdZ != null)
		{
			BdZ.method_51(smethod_2);
			BdZ = null;
		}
		Bdy = null;
		if (BdV != null)
		{
			if (BdV.method_0() & bool_0)
			{
				BdV.method_7();
			}
			BdV.method_3();
		}
	}

	internal static bool smethod_12()
	{
		if (BdV != null)
		{
			return BdV.method_6();
		}
		return false;
	}
}
