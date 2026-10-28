using System;
using System.Linq;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns0;
using ns6;
using ns7;

namespace ns5;

internal class Class235
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class236
	{
		public static readonly Class236 BrA = new Class236();

		public static Func<byte, string> Bra;

		internal string method_0(byte byte_0)
		{
			return byte_0.ToString(Class333.smethod_330());
		}
	}

	private Enum88 aWf;

	private Class14 aWG;

	private byte aWg;

	private byte[] aWH;

	internal Class235(Enum88 enum88_0)
	{
		aWf = enum88_0;
	}

	public override string ToString()
	{
		return Class333.agu() + aWf;
	}

	[SpecialName]
	internal Enum88 method_0()
	{
		return aWf;
	}

	[SpecialName]
	internal Class14 method_1()
	{
		return aWG;
	}

	[SpecialName]
	internal void method_2(Class14 class14_0)
	{
		aWG = class14_0;
	}

	[SpecialName]
	internal string method_3()
	{
		if (aWH == null)
		{
			return Class333.smethod_102();
		}
		return string.Join(Class333.smethod_102(), aWH.Select((byte byte_0) => byte_0.ToString(Class333.smethod_330())));
	}

	[SpecialName]
	internal void method_4(byte[] byte_0)
	{
		aWH = byte_0.ToArray();
	}

	[SpecialName]
	internal byte method_5()
	{
		return aWg;
	}

	[SpecialName]
	internal void method_6(byte byte_0)
	{
		aWg = byte_0;
	}

	internal bool method_7()
	{
		return aWg == 0;
	}

	internal bool method_8()
	{
		return (aWg & 1) != 0;
	}

	internal bool method_9()
	{
		return (aWg & 2) != 0;
	}

	internal bool method_10()
	{
		return (aWg & 4) != 0;
	}

	internal bool method_11()
	{
		return (aWg & 8) != 0;
	}

	internal bool method_12()
	{
		return (aWg & 0x10) != 0;
	}

	internal bool method_13()
	{
		if (method_12())
		{
			return method_10();
		}
		return false;
	}

	internal string method_14()
	{
		return aWf switch
		{
			Enum88.aWA => Class333.aHc(), 
			Enum88.avk => Class333.agV(), 
			Enum88.avL => Class333.agv(), 
			Enum88.avl => Class333.agw(), 
			Enum88.avM => Class333.agX(), 
			Enum88.avm => Class333.agx(), 
			Enum88.avN => Class333.agY(), 
			Enum88.avn => Class333.agz(), 
			Enum88.avO => Class333.agZ(), 
			Enum88.avp => Class333.aHA(), 
			Enum88.avQ => Class333.aHa(), 
			Enum88.avq => Class333.aHB(), 
			Enum88.avR => Class333.agW(), 
			Enum88.avr => Class333.aHb(), 
			Enum88.avS => Class333.aHb(), 
			Enum88.avs => Class333.aHC(), 
			Enum88.avT => Class333.aHC(), 
			Enum88.avt => Class333.agy(), 
			Enum88.avU => Class333.aHD(), 
			Enum88.avu => Class333.aHd(), 
			Enum88.avV => Class333.aHE(), 
			Enum88.avv => Class333.aHe(), 
			Enum88.avW => Class333.aHF(), 
			Enum88.avw => Class333.aHf(), 
			Enum88.avX => Class333.aHG(), 
			Enum88.avx => Class333.aHg(), 
			Enum88.avY => Class333.aHH(), 
			Enum88.avy => Class333.aHh(), 
			_ => null, 
		};
	}

	internal static Enum104 smethod_0(Enum88 enum88_0)
	{
		return enum88_0 switch
		{
			Enum88.aWA => Enum104.BAr, 
			Enum88.avk => Enum104.BAC, 
			Enum88.avL => Enum104.BAc, 
			Enum88.avl => Enum104.BAD, 
			Enum88.avM => Enum104.BAd, 
			Enum88.avm => Enum104.BAE, 
			Enum88.avN => Enum104.BAe, 
			Enum88.avn => Enum104.BAF, 
			Enum88.avO => Enum104.BAf, 
			Enum88.avo => Enum104.BAH, 
			Enum88.avp => Enum104.BAh, 
			Enum88.avQ => Enum104.BAI, 
			Enum88.avq => Enum104.BAi, 
			Enum88.avR => Enum104.BAj, 
			Enum88.avr => Enum104.BAK, 
			Enum88.avS => Enum104.BAk, 
			Enum88.avs => Enum104.BAL, 
			Enum88.avT => Enum104.BAl, 
			Enum88.avU => Enum104.BAm, 
			Enum88.avu => Enum104.BAN, 
			Enum88.avV => Enum104.BAn, 
			Enum88.avv => Enum104.BAO, 
			Enum88.avW => Enum104.BAQ, 
			Enum88.avw => Enum104.BAq, 
			Enum88.avX => Enum104.BAR, 
			Enum88.avx => Enum104.BAR, 
			Enum88.avY => Enum104.BAR, 
			Enum88.avy => Enum104.BAR, 
			_ => Enum104.BAB, 
		};
	}

	internal string method_15()
	{
		return smethod_1(aWf);
	}

	internal string method_16()
	{
		return smethod_2(aWf);
	}

	internal static string smethod_1(Enum88 enum88_0)
	{
		return enum88_0 switch
		{
			Enum88.aWA => Class333.aHi(), 
			Enum88.avk => PortFunction.smethod_2(Enum104.BAC, null), 
			Enum88.avL => PortFunction.smethod_2(Enum104.BAc, null), 
			Enum88.avl => PortFunction.smethod_2(Enum104.BAD, null), 
			Enum88.avM => PortFunction.smethod_2(Enum104.BAd, null), 
			Enum88.avm => PortFunction.smethod_2(Enum104.BAE, null), 
			Enum88.avN => PortFunction.smethod_2(Enum104.BAe, null), 
			Enum88.avn => PortFunction.smethod_2(Enum104.BAF, null), 
			Enum88.avO => PortFunction.smethod_2(Enum104.BAf, null), 
			Enum88.avo => PortFunction.smethod_2(Enum104.BAH, null), 
			Enum88.avp => PortFunction.smethod_2(Enum104.BAh, null), 
			Enum88.avQ => PortFunction.smethod_2(Enum104.BAI, null), 
			Enum88.avq => PortFunction.smethod_2(Enum104.BAi, null), 
			Enum88.avR => PortFunction.smethod_2(Enum104.BAj, null), 
			Enum88.avr => PortFunction.smethod_2(Enum104.BAK, null), 
			Enum88.avS => PortFunction.smethod_2(Enum104.BAk, null), 
			Enum88.avs => PortFunction.smethod_2(Enum104.BAL, null), 
			Enum88.avT => PortFunction.smethod_2(Enum104.BAl, null), 
			Enum88.avt => Class333.aHI(), 
			Enum88.avU => PortFunction.smethod_2(Enum104.BAm, null), 
			Enum88.avu => PortFunction.smethod_2(Enum104.BAN, null), 
			Enum88.avV => PortFunction.smethod_2(Enum104.BAn, null), 
			Enum88.avv => PortFunction.smethod_2(Enum104.BAO, null), 
			Enum88.avW => PortFunction.smethod_2(Enum104.BAQ, null), 
			Enum88.avw => PortFunction.smethod_2(Enum104.BAq, null), 
			Enum88.avX => Class333.aHJ(), 
			Enum88.avx => Class333.aHj(), 
			Enum88.avY => Class333.aHK(), 
			Enum88.avy => Class333.aHk(), 
			_ => string.Empty, 
		};
	}

	internal static string smethod_2(Enum88 enum88_0)
	{
		return enum88_0 switch
		{
			Enum88.aWA => Class333.aHl(), 
			Enum88.avk => PortFunction.smethod_3(Enum104.BAC, null), 
			Enum88.avL => PortFunction.smethod_3(Enum104.BAc, null), 
			Enum88.avl => PortFunction.smethod_3(Enum104.BAD, null), 
			Enum88.avM => PortFunction.smethod_3(Enum104.BAd, null), 
			Enum88.avm => PortFunction.smethod_3(Enum104.BAE, null), 
			Enum88.avN => PortFunction.smethod_3(Enum104.BAe, null), 
			Enum88.avn => PortFunction.smethod_3(Enum104.BAF, null), 
			Enum88.avO => PortFunction.smethod_3(Enum104.BAf, null), 
			Enum88.avo => PortFunction.smethod_3(Enum104.BAH, null), 
			Enum88.avp => PortFunction.smethod_3(Enum104.BAh, null), 
			Enum88.avQ => PortFunction.smethod_3(Enum104.BAI, null), 
			Enum88.avq => PortFunction.smethod_3(Enum104.BAi, null), 
			Enum88.avR => PortFunction.smethod_3(Enum104.BAj, null), 
			Enum88.avr => PortFunction.smethod_3(Enum104.BAK, null), 
			Enum88.avS => PortFunction.smethod_3(Enum104.BAk, null), 
			Enum88.avs => PortFunction.smethod_3(Enum104.BAL, null), 
			Enum88.avT => PortFunction.smethod_3(Enum104.BAl, null), 
			Enum88.avt => Class333.aHL(), 
			Enum88.avU => PortFunction.smethod_3(Enum104.BAm, null), 
			Enum88.avu => PortFunction.smethod_3(Enum104.BAN, null), 
			Enum88.avV => PortFunction.smethod_3(Enum104.BAn, null), 
			Enum88.avv => PortFunction.smethod_3(Enum104.BAO, null), 
			Enum88.avW => PortFunction.smethod_3(Enum104.BAQ, null), 
			Enum88.avw => PortFunction.smethod_3(Enum104.BAq, null), 
			Enum88.avX => Class333.aHM(), 
			Enum88.avx => Class333.aHm(), 
			Enum88.avY => Class333.aHN(), 
			Enum88.avy => Class333.aHn(), 
			_ => string.Empty, 
		};
	}
}
