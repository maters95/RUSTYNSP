using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using ns7;

namespace ns2;

internal class Class81
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class82
	{
		public static readonly Class82 BLd = new Class82();

		public static Func<Class80, Color> BLE;

		public static Func<Class80, bool> BLe;

		public static Action<Class80> BLF;

		internal Color method_0(Class80 class80_0)
		{
			return class80_0.method_0();
		}

		internal bool method_1(Class80 class80_0)
		{
			return class80_0.method_4();
		}

		internal void method_2(Class80 class80_0)
		{
			class80_0.method_3(bool_2: false);
		}
	}

	[CompilerGenerated]
	private sealed class Class83
	{
		public bool BLf;

		internal void method_0(Class80 class80_0)
		{
			class80_0.method_3(BLf);
		}
	}

	[CompilerGenerated]
	private sealed class Class84
	{
		public Color BLG;

		internal void method_0(Class80 class80_0)
		{
			class80_0.method_1(BLG);
		}
	}

	private List<Class80> list_0;

	[CompilerGenerated]
	private bool bool_0;

	[SpecialName]
	internal int method_0()
	{
		return list_0.Count;
	}

	[SpecialName]
	internal List<Color> method_1()
	{
		return list_0.Select((Class80 class80_0) => class80_0.method_0()).ToList();
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool method_2()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(bool bool_1)
	{
		bool_0 = bool_1;
	}

	[SpecialName]
	internal List<bool> method_4()
	{
		return list_0.Select((Class80 class80_0) => class80_0.method_4()).ToList();
	}

	internal Class81(int int_0, Color[] color_0, bool bool_1, int int_1)
	{
		if (color_0.Length != int_0)
		{
			throw new Exception(Class333.smethod_477());
		}
		method_5(int_0);
		list_0.ForEach((Class80 class80_0) =>
		{
			class80_0.method_3(bool_1);
		});
		method_3(bool_1);
		for (int num = 0; num < int_0; num++)
		{
			list_0[num].method_5((int_1 & (1 << num)) > 0);
			list_0[num].method_1(color_0[num]);
		}
	}

	internal Class81(int int_0, int[] int_1, int int_2)
	{
		if (int_1.Length != int_0)
		{
			throw new Exception(Class333.smethod_477());
		}
		method_5(int_0);
		list_0.ForEach((Class80 class80_0) =>
		{
			class80_0.method_3(bool_2: false);
		});
		for (int num = 0; num < int_0; num++)
		{
			list_0[num].method_5((int_2 & (1 << num)) > 0);
			list_0[num].method_1(Class80.smethod_0(int_1[num]));
		}
	}

	internal Class81(int int_0, Color color_0, bool bool_1, int int_1)
		: this(int_0, Enumerable.Repeat(color_0, int_0).ToArray(), bool_1, int_1)
	{
	}

	internal Class81(int int_0, int int_1, int int_2, int int_3)
		: this(int_0, Class80.smethod_0(int_1), int_2 == 1, int_3)
	{
	}

	private void method_5(int int_0)
	{
		list_0 = new List<Class80>(int_0);
		for (int i = 0; i < int_0; i++)
		{
			list_0.Add(new Class80());
		}
	}

	internal void method_6(int int_0, bool bool_1)
	{
		list_0[int_0].method_5(bool_1);
	}

	internal int method_7()
	{
		int num = 0;
		for (int i = 0; i < list_0.Count; i++)
		{
			num |= (int)((list_0[i].method_4() ? 1u : 0u) << i);
		}
		return num;
	}

	internal void method_8(int int_0)
	{
		Color BLG = Class80.smethod_0(int_0);
		list_0.ForEach((Class80 class80_0) =>
		{
			class80_0.method_1(BLG);
		});
	}

	internal void method_9(int int_0, int int_1)
	{
		list_0[int_0].method_1(Class80.smethod_0(int_1));
	}

	internal Color method_10(int int_0)
	{
		if (!list_0[int_0].method_4())
		{
			return Class80.smethod_0(0);
		}
		return list_0[int_0].method_0();
	}
}
