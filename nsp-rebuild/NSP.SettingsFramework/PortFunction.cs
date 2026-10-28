using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class PortFunction
{
	internal class Class271
	{
		internal Enum106 BSK;

		internal Enum107 BSk;

		internal int BSL;

		internal Class271(ushort ushort_0, int int_0)
		{
			BSK = smethod_18(ushort_0);
			BSk = smethod_19(ushort_0);
			BSL = int_0;
		}

		public override string ToString()
		{
			return Class333.BEi() + BSK.ToString() + Class333.BEJ() + BSk;
		}
	}

	internal class Class272
	{
		internal Enum104 BSl;

		internal Enum105 BSM;

		internal byte BSm;

		internal ushort BSN;

		internal string BSn;

		internal bool BSO;

		internal Enum106 BSo;

		internal Enum107 BSP;

		internal int BSp;

		internal Class272(uint uint_0, string string_0, bool bool_0, ushort ushort_0, int int_0)
		{
			BSl = smethod_12(uint_0);
			BSM = smethod_13(uint_0);
			BSm = smethod_14(uint_0);
			BSN = smethod_15(uint_0);
			BSn = string_0;
			BSO = bool_0;
			BSo = smethod_18(ushort_0);
			BSP = smethod_19(ushort_0);
			BSp = int_0;
		}

		public override string ToString()
		{
			return Class333.BEj() + BSn;
		}
	}

	internal class Class273
	{
		internal Enum104 BSQ;

		internal Enum105 BSq;

		internal byte BSR;

		internal ushort BSr;

		internal string BSS;

		internal Enum104 BSs;

		internal Enum105 BST;

		internal byte BSt;

		internal ushort BSU;

		internal string BSu;

		internal Dictionary<int, Enum104> BSV;

		internal Dictionary<int, Enum105> BSv;

		internal Dictionary<int, byte> BSW;

		internal Dictionary<int, ushort> BSw;

		internal Dictionary<int, string> BSX;

		internal Class273()
		{
			BSV = new Dictionary<int, Enum104>();
			BSv = new Dictionary<int, Enum105>();
			BSW = new Dictionary<int, byte>();
			BSw = new Dictionary<int, ushort>();
			BSX = new Dictionary<int, string>();
		}

		internal void method_0(uint uint_0, string string_0, int int_0)
		{
			if (int_0 == -1)
			{
				BSs = smethod_12(uint_0);
				BSQ = BSs;
				BST = smethod_13(uint_0);
				BSq = BST;
				BSt = smethod_14(uint_0);
				BSR = BSt;
				BSU = smethod_15(uint_0);
				BSr = BSU;
				BSu = string_0;
				BSS = string_0;
			}
			else
			{
				BSV.Add(int_0, smethod_12(uint_0));
				BSv.Add(int_0, smethod_13(uint_0));
				BSW.Add(int_0, smethod_14(uint_0));
				BSw.Add(int_0, smethod_15(uint_0));
				BSX.Add(int_0, string_0);
			}
		}

		public override string ToString()
		{
			return Class333.BEK() + ((!string.IsNullOrWhiteSpace(BSS)) ? BSS : Class333.smethod_186()) + Class333.BEk() + BSQ.ToString() + Class333.BEL() + BSq.ToString() + Class333.BEl() + BSR + Class333.BEM() + BSr;
		}
	}

	private Class273 BBX = new Class273();

	private Class273 BBx = new Class273();

	private List<Setting> BBY = new List<Setting>();

	private List<int> BBy = new List<int>();

	internal int BBZ = -1;

	private List<Class272> BBz = new List<Class272>();

	private List<Class272> BbA = new List<Class272>();

	private List<Class271> Bba = new List<Class271>();

	private List<Class271> BbB = new List<Class271>();

	internal int Bbb = -1;

	internal int BbC;

	private string Bbc;

	private int BbD;

	internal bool Bbd;

	private SettingOrSpecialObject BbE;

	private Framework Bbe;

	private static Enum104[] BbF;

	private static Enum105[] Bbf;

	internal static Image BbG;

	internal static Image Bbg;

	internal PortFunction(Framework framework_0, SettingOrSpecialObject settingOrSpecialObject_0)
	{
		Bbe = framework_0;
		BbE = settingOrSpecialObject_0;
	}

	internal static Enum88 smethod_0(Enum104 enum104_0, Framework framework_0)
	{
		switch (enum104_0)
		{
		case Enum104.BAC:
			return Enum88.avk;
		case Enum104.BAc:
			return Enum88.avL;
		case Enum104.BAD:
			return Enum88.avl;
		case Enum104.BAd:
			return Enum88.avM;
		case Enum104.BAE:
			return Enum88.avm;
		case Enum104.BAe:
			return Enum88.avN;
		case Enum104.BAF:
			return Enum88.avn;
		case Enum104.BAf:
			return Enum88.avO;
		case Enum104.BAh:
			return Enum88.avp;
		case Enum104.BAI:
			return Enum88.avQ;
		case Enum104.BAi:
			return Enum88.avq;
		case Enum104.BAj:
			return Enum88.avR;
		case Enum104.BAK:
			return Enum88.avr;
		case Enum104.BAk:
			return Enum88.avS;
		case Enum104.BAL:
			return Enum88.avs;
		case Enum104.BAl:
			return Enum88.avT;
		case Enum104.BAm:
			return Enum88.avU;
		case Enum104.BAN:
			return Enum88.avu;
		case Enum104.BAn:
			return Enum88.avV;
		case Enum104.BAO:
			return Enum88.avv;
		case Enum104.BAQ:
			return Enum88.avW;
		case Enum104.BAq:
			return Enum88.avw;
		case Enum104.BAR:
			if (framework_0.method_27(Enum88.avX))
			{
				return Enum88.avX;
			}
			if (framework_0.method_27(Enum88.avx))
			{
				return Enum88.avx;
			}
			if (framework_0.method_27(Enum88.avY))
			{
				return Enum88.avY;
			}
			if (framework_0.method_27(Enum88.avy))
			{
				return Enum88.avy;
			}
			goto default;
		default:
			return Enum88.avK;
		case Enum104.BAr:
			return Enum88.aWA;
		}
	}

	internal static string smethod_1(Enum104 enum104_0, Framework framework_0)
	{
		Enum88 key = smethod_0(enum104_0, framework_0);
		if (framework_0.awf.ContainsKey((byte)key))
		{
			return framework_0.awf[(byte)key].method_18();
		}
		return null;
	}

	internal static string smethod_2(Enum104 enum104_0, Framework framework_0)
	{
		switch (enum104_0)
		{
		case Enum104.BAb:
			if (framework_0 != null && !string.IsNullOrEmpty(framework_0.awY))
			{
				return framework_0.awY;
			}
			return Class333.aSF();
		case Enum104.BAC:
			return Class333.aSf();
		case Enum104.BAc:
			return Class333.aSG();
		case Enum104.BAD:
			return Class333.aSh();
		case Enum104.BAd:
			return Class333.aSI();
		case Enum104.BAE:
			return Class333.aSg();
		case Enum104.BAe:
			return Class333.aSH();
		case Enum104.BAF:
			return Class333.aSj();
		case Enum104.BAf:
			return Class333.aSJ();
		case Enum104.BAG:
			return Class333.aSl();
		case Enum104.BAg:
			return Class333.aSM();
		case Enum104.BAH:
			return Class333.aSN();
		case Enum104.BAh:
			return Class333.aSK();
		case Enum104.BAI:
			return Class333.aSk();
		case Enum104.BAi:
			return Class333.aSL();
		case Enum104.BAJ:
			return Class333.aSn();
		case Enum104.BAj:
			return Class333.aSi();
		case Enum104.BAK:
			return Class333.aSO();
		case Enum104.BAk:
			return Class333.aSo();
		case Enum104.BAL:
			return Class333.aSP();
		case Enum104.BAl:
			return Class333.aSp();
		case Enum104.BAM:
			return Class333.smethod_2310();
		case Enum104.BAm:
			return Class333.aSQ();
		case Enum104.BAN:
			return Class333.aSq();
		case Enum104.BAn:
			return Class333.aSR();
		case Enum104.BAO:
			return Class333.aSr();
		case Enum104.BAo:
			return Class333.aSt();
		case Enum104.BAP:
			return Class333.aSU();
		case Enum104.BAp:
			return Class333.aSu();
		case Enum104.BAQ:
			return Class333.aSS();
		case Enum104.BAq:
			return Class333.aSs();
		case Enum104.BAR:
			if (framework_0 == null)
			{
				return Class333.aST();
			}
			if (framework_0.method_27(Enum88.avX))
			{
				return Class333.aHJ();
			}
			if (framework_0.method_27(Enum88.avx))
			{
				return Class333.aHj();
			}
			if (framework_0.method_27(Enum88.avY))
			{
				return Class333.aHK();
			}
			if (framework_0.method_27(Enum88.avy))
			{
				return Class333.aHk();
			}
			goto default;
		default:
			return Class333.aSX();
		case Enum104.BAr:
			return Class333.aSV();
		case Enum104.BAS:
			return Class333.aSm();
		case Enum104.BAs:
			return Class333.aSv();
		case Enum104.BAT:
			return Class333.aSW();
		case Enum104.BAt:
			return Class333.aSw();
		}
	}

	internal static string smethod_3(Enum104 enum104_0, Framework framework_0)
	{
		switch (enum104_0)
		{
		case Enum104.BAb:
			return Class333.aSF();
		case Enum104.BAC:
			return Class333.aSx();
		case Enum104.BAc:
			return Class333.aSY();
		case Enum104.BAD:
			return Class333.aSz();
		case Enum104.BAd:
			return Class333.asA();
		case Enum104.BAE:
			return Class333.aSy();
		case Enum104.BAe:
			return Class333.aSZ();
		case Enum104.BAF:
			return Class333.asb();
		case Enum104.BAf:
			return Class333.asB();
		case Enum104.BAG:
			return Class333.aSl();
		case Enum104.BAg:
			return Class333.aSM();
		case Enum104.BAH:
			return Class333.asd();
		case Enum104.BAh:
			return Class333.asC();
		case Enum104.BAI:
			return Class333.asc();
		case Enum104.BAi:
			return Class333.asD();
		case Enum104.BAJ:
			return Class333.aSn();
		case Enum104.BAj:
			return Class333.asa();
		case Enum104.BAK:
			return Class333.asE();
		case Enum104.BAk:
			return Class333.ase();
		case Enum104.BAL:
			return Class333.asF();
		case Enum104.BAl:
			return Class333.asf();
		case Enum104.BAM:
			return Class333.smethod_2310();
		case Enum104.BAm:
			return Class333.asG();
		case Enum104.BAN:
			return Class333.asg();
		case Enum104.BAn:
			return Class333.asH();
		case Enum104.BAO:
			return Class333.ash();
		case Enum104.BAo:
			return Class333.asj();
		case Enum104.BAP:
			return Class333.asK();
		case Enum104.BAp:
			return Class333.ask();
		case Enum104.BAQ:
			return Class333.asI();
		case Enum104.BAq:
			return Class333.asi();
		case Enum104.BAR:
			if (framework_0 == null)
			{
				return Class333.asJ();
			}
			if (framework_0.method_27(Enum88.avX))
			{
				return Class333.aHM();
			}
			if (framework_0.method_27(Enum88.avx))
			{
				return Class333.aHm();
			}
			if (framework_0.method_27(Enum88.avY))
			{
				return Class333.aHN();
			}
			if (framework_0.method_27(Enum88.avy))
			{
				return Class333.aHn();
			}
			goto default;
		default:
			return Class333.aoa();
		case Enum104.BAr:
			return Class333.aSV();
		case Enum104.BAS:
			return Class333.aSm();
		case Enum104.BAs:
			return Class333.aSv();
		case Enum104.BAT:
			return Class333.aSW();
		case Enum104.BAt:
			return Class333.aSw();
		}
	}

	internal static string smethod_4(Enum105 enum105_0)
	{
		return enum105_0 switch
		{
			Enum105.BaI => Class333.asV(), 
			Enum105.Bai => Class333.asU(), 
			Enum105.BaJ => Class333.ast(), 
			Enum105.Baj => Class333.asv(), 
			Enum105.Bak => Class333.aTC(), 
			Enum105.BAU => Class333.asW(), 
			Enum105.BAu => Class333.asm(), 
			Enum105.BAV => Class333.asN(), 
			Enum105.BAv => Class333.asn(), 
			Enum105.BAW => Class333.asu(), 
			Enum105.BAw => Class333.asr(), 
			Enum105.BAX => Class333.asS(), 
			Enum105.BAx => Class333.ass(), 
			Enum105.BAY => Class333.asT(), 
			Enum105.BAy => Class333.asy(), 
			Enum105.BAZ => Class333.asY(), 
			Enum105.BAz => Class333.asx(), 
			Enum105.BaA => Class333.asQ(), 
			Enum105.Baa => Class333.asl(), 
			Enum105.BaB => Class333.asM(), 
			Enum105.Bab => Class333.asL(), 
			Enum105.BaC => Class333.asq(), 
			Enum105.Bac => Class333.asR(), 
			Enum105.BaD => Class333.aTa(), 
			Enum105.Bad => Class333.aTB(), 
			Enum105.BaE => Class333.aTb(), 
			Enum105.Bae => Class333.smethod_2310(), 
			Enum105.BaF => Class333.aTc(), 
			Enum105.Baf => Class333.asO(), 
			Enum105.BaG => Class333.aso(), 
			Enum105.Bag => Class333.aTD(), 
			Enum105.BaH => Class333.asP(), 
			Enum105.Bah => Class333.asp(), 
			Enum105.BaN => Class333.asw(), 
			Enum105.BaL => Class333.asX(), 
			Enum105.Bal => Class333.asZ(), 
			Enum105.BaM => Class333.asz(), 
			Enum105.Bam => Class333.aTA(), 
			_ => Class333.aTd(), 
		};
	}

	[SpecialName]
	internal static Enum104[] smethod_5()
	{
		if (BbF == null)
		{
			Array values = Enum.GetValues(typeof(Enum104));
			BbF = new Enum104[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				BbF[i] = (Enum104)values.GetValue(i);
			}
		}
		return BbF;
	}

	[SpecialName]
	internal static Enum105[] smethod_6()
	{
		if (Bbf == null)
		{
			Array values = Enum.GetValues(typeof(Enum105));
			Bbf = new Enum105[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				Bbf[i] = (Enum105)values.GetValue(i);
			}
		}
		return Bbf;
	}

	internal static void smethod_7(float float_0, float float_1, float float_2)
	{
		if (BbG != null)
		{
			BbG.Dispose();
		}
		BbG = Class25.smethod_0(Class281.smethod_0(), 1f, 0f, 0f, 0f, 0f, float_0, float_1, float_2);
		if (Bbg != null)
		{
			Bbg.Dispose();
		}
		Bbg = Class25.smethod_0(Class281.smethod_3(), 1f, 0f, 0f, 0f, 0f, float_0, float_1, float_2);
	}

	internal static Image smethod_8(Enum104 enum104_0, Enum105 enum105_0)
	{
		switch (enum104_0)
		{
		case Enum104.BAG:
			return Bbg;
		default:
			if (!smethod_10(enum104_0) && !smethod_9(enum104_0, enum105_0) && !smethod_11(enum104_0))
			{
				return null;
			}
			break;
		case Enum104.BAg:
		case Enum104.BAS:
			break;
		}
		return BbG;
	}

	internal static bool smethod_9(Enum104 enum104_0, Enum105 enum105_0)
	{
		if (enum104_0 == Enum104.BAR)
		{
			return enum105_0 == Enum105.BaM;
		}
		return false;
	}

	internal static bool smethod_10(Enum104 enum104_0)
	{
		if (enum104_0 != Enum104.BAo && enum104_0 != Enum104.BAP)
		{
			return enum104_0 == Enum104.BAp;
		}
		return true;
	}

	internal static bool smethod_11(Enum104 enum104_0)
	{
		if (enum104_0 != Enum104.BAs && enum104_0 != Enum104.BAT)
		{
			return enum104_0 == Enum104.BAt;
		}
		return true;
	}

	internal void method_0()
	{
		BBY.Clear();
		if (BbE is Setting && (BbE as Setting).method_207() && BBX.BSQ == Enum104.BAM)
		{
			BBY.Add(BbE as Setting);
			return;
		}
		for (int i = 0; i < BbE.method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = BbE.method_1()[i];
			if (settingOrSpecialObject is Setting && settingOrSpecialObject.method_2().StartsWith(Class333.aTE()))
			{
				BBY.Add(settingOrSpecialObject as Setting);
			}
		}
	}

	[SpecialName]
	internal List<Setting> method_1()
	{
		return BBY;
	}

	[SpecialName]
	internal List<int> method_2()
	{
		return BBy;
	}

	internal void method_3(int int_0)
	{
		BbD = int_0;
	}

	internal void method_4(string string_0)
	{
		Bbc = string_0;
	}

	internal string method_5(Framework framework_0)
	{
		if (BbD != 0)
		{
			string text = framework_0.method_31(BbD).method_60(Enum96.aYv);
			if (string.IsNullOrEmpty(text))
			{
				text = framework_0.method_31(BbD).method_60(Enum96.aYu);
			}
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return framework_0.method_31(BbD).method_60(Enum96.aYt);
		}
		return Bbc;
	}

	internal void method_6(uint uint_0, string string_0, bool bool_0, ushort ushort_0, int int_0)
	{
		Class272 item = new Class272(uint_0, string_0, bool_0, ushort_0, int_0);
		BBz.Add(item);
	}

	internal List<Class272> method_7()
	{
		return BBz;
	}

	internal List<Class272> method_8()
	{
		return BbA;
	}

	internal void method_9(uint uint_0, string string_0, int int_0)
	{
		BBx.method_0(uint_0, string_0, int_0);
	}

	internal Class273 method_10()
	{
		return BBx;
	}

	internal void method_11(uint uint_0, string string_0, int int_0)
	{
		BBX.method_0(uint_0, string_0, int_0);
	}

	internal Class273 method_12()
	{
		return BBX;
	}

	internal static Enum104 smethod_12(uint uint_0)
	{
		return (Enum104)((uint_0 >> 24) & 0xFF);
	}

	internal static Enum105 smethod_13(uint uint_0)
	{
		return (Enum105)((uint_0 >> 16) & 0xFF);
	}

	internal static byte smethod_14(uint uint_0)
	{
		return (byte)((uint_0 >> 8) & 0xFF);
	}

	internal static ushort smethod_15(uint uint_0)
	{
		return (ushort)(uint_0 & 0xFFFF);
	}

	internal static uint smethod_16(Enum104 enum104_0, Enum105 enum105_0, byte byte_0)
	{
		return (((uint)enum104_0 << 24) & 0xFF000000u) | (((uint)enum105_0 << 16) & 0xFF0000) | (uint)((byte_0 << 8) & 0xFF00);
	}

	internal static uint smethod_17(Enum104 enum104_0, Enum105 enum105_0, ushort ushort_0)
	{
		return (((uint)enum104_0 << 24) & 0xFF000000u) | (((uint)enum105_0 << 16) & 0xFF0000) | (uint)(ushort_0 & 0xFFFF);
	}

	internal void method_13()
	{
		BbB.Clear();
		for (int i = 0; i < Bba.Count; i++)
		{
			Class271 @class = Bba[i];
			if (@class.BSL == -1)
			{
				BbB.Add(@class);
			}
		}
		BbA.Clear();
		for (int j = 0; j < BBz.Count; j++)
		{
			Class272 class2 = BBz[j];
			if (class2.BSp == -1)
			{
				BbA.Add(class2);
			}
		}
		BBX.BSQ = BBX.BSs;
		BBX.BSq = BBX.BST;
		BBX.BSR = BBX.BSt;
		BBX.BSr = BBX.BSU;
		BBX.BSS = BBX.BSu;
		BBx.BSQ = BBx.BSs;
		BBx.BSq = BBx.BST;
		BBx.BSR = BBx.BSt;
		BBx.BSr = BBx.BSU;
		BBx.BSS = BBx.BSu;
	}

	internal void method_14(int int_0)
	{
		for (int i = 0; i < Bba.Count; i++)
		{
			Class271 @class = Bba[i];
			if (@class.BSL == int_0)
			{
				BbB.Add(@class);
			}
		}
		for (int j = 0; j < BBz.Count; j++)
		{
			Class272 class2 = BBz[j];
			if (class2.BSp == int_0)
			{
				BbA.Add(class2);
			}
		}
		if (BBX.BSV.ContainsKey(int_0))
		{
			BBX.BSQ = BBX.BSV[int_0];
		}
		if (BBX.BSv.ContainsKey(int_0))
		{
			BBX.BSq = BBX.BSv[int_0];
		}
		if (BBX.BSW.ContainsKey(int_0))
		{
			BBX.BSR = BBX.BSW[int_0];
		}
		if (BBX.BSw.ContainsKey(int_0))
		{
			BBX.BSr = BBX.BSw[int_0];
		}
		if (BBX.BSX.ContainsKey(int_0))
		{
			BBX.BSS = BBX.BSX[int_0];
		}
		if (BBx.BSV.ContainsKey(int_0))
		{
			BBx.BSQ = BBx.BSV[int_0];
		}
		if (BBx.BSv.ContainsKey(int_0))
		{
			BBx.BSq = BBx.BSv[int_0];
		}
		if (BBx.BSW.ContainsKey(int_0))
		{
			BBx.BSR = BBx.BSW[int_0];
		}
		if (BBx.BSw.ContainsKey(int_0))
		{
			BBx.BSr = BBx.BSw[int_0];
		}
		if (BBx.BSX.ContainsKey(int_0))
		{
			BBx.BSS = BBx.BSX[int_0];
		}
	}

	internal void method_15(ushort ushort_0, int int_0)
	{
		Class271 item = new Class271(ushort_0, int_0);
		Bba.Add(item);
	}

	internal List<Class271> method_16()
	{
		return BbB;
	}

	internal static Enum106 smethod_18(ushort ushort_0)
	{
		return (Enum106)((ushort_0 >> 8) & 0xFF);
	}

	internal static Enum107 smethod_19(ushort ushort_0)
	{
		return (Enum107)(ushort_0 & 0xFF);
	}

	internal static void smethod_20(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0)
	{
		List<SettingOrSpecialObject> list = new List<SettingOrSpecialObject>();
		list.Add(settingOrSpecialObject_0);
		if (!bool_0 && settingOrSpecialObject_0.method_27().Count != 0)
		{
			foreach (int item in settingOrSpecialObject_0.method_27())
			{
				list.Add(settingOrSpecialObject_0.method_0().method_33(item));
			}
		}
		foreach (SettingOrSpecialObject item2 in list)
		{
			foreach (SettingOrSpecialObject item3 in item2.method_1())
			{
				if (!(item3 is Class244))
				{
					continue;
				}
				Class244 @class = item3 as Class244;
				foreach (SettingOrSpecialObject item4 in @class.method_1())
				{
					if (item4 is FilterOption)
					{
						(item4 as FilterOption).method_75(bool_0: false);
					}
				}
				foreach (SettingOrSpecialObject item5 in @class.method_1())
				{
					if (!(item5 is FilterOption) || !(item5 as FilterOption).method_74())
					{
						continue;
					}
					Class273 class2 = item5.method_12().method_10();
					int num = 0;
					num = (int)((class2.BSQ != Enum104.BAM) ? smethod_16(class2.BSQ, class2.BSq, class2.BSR) : smethod_17(class2.BSQ, class2.BSq, class2.BSr));
					if (num == 0)
					{
						continue;
					}
					int num2 = @class.method_256();
					if (num != num2)
					{
						@class.method_272(num, bool_0: true);
						if (num2 == 0)
						{
							@class.method_294();
						}
						Form23.smethod_74(@class.method_64());
					}
				}
			}
		}
	}

	internal static void smethod_21(Setting setting_0, out HashSet<DataIdAndAttrId> hashSet_0)
	{
		hashSet_0 = null;
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		List<Class244> list = new List<Class244>();
		foreach (FilterOption item in setting_0.method_134())
		{
			if (!(item.method_6() is Class244))
			{
				continue;
			}
			Class244 @class = item.method_6() as Class244;
			if (!item.method_74())
			{
				continue;
			}
			int num = @class.method_256();
			Class273 class2 = item.method_12().method_10();
			int num2 = 0;
			num2 = (int)((class2.BSQ != Enum104.BAM) ? smethod_16(class2.BSQ, class2.BSq, class2.BSR) : smethod_17(class2.BSQ, class2.BSq, class2.BSr));
			if (num2 == num)
			{
				continue;
			}
			if (num2 != 0)
			{
				if (@class.method_35())
				{
					@class.method_272(num2, bool_0: true);
					if (num == 0)
					{
						@class.method_294();
					}
					Form23.smethod_74(@class.method_64());
					if (hashSet_0 == null)
					{
						hashSet_0 = new HashSet<DataIdAndAttrId>();
					}
					hashSet_0.Add(@class.method_69());
				}
			}
			else if (!list.Contains(@class))
			{
				list.Add(@class);
			}
		}
		foreach (Class244 item2 in list)
		{
			int num3 = item2.method_256();
			if (num3 == 0)
			{
				continue;
			}
			Enum104 enum104_ = smethod_12((uint)num3);
			Enum105 enum105_ = smethod_13((uint)num3);
			byte byte_ = smethod_14((uint)num3);
			ushort ushort_ = smethod_15((uint)num3);
			SettingOrSpecialObject settingOrSpecialObject = smethod_36(item2.method_0(), enum104_, enum105_, byte_, ushort_);
			if (settingOrSpecialObject != null && !smethod_40(settingOrSpecialObject, item2))
			{
				item2.method_272(0, bool_0: true);
				Form23.smethod_74(item2.method_64());
				if (hashSet_0 == null)
				{
					hashSet_0 = new HashSet<DataIdAndAttrId>();
				}
				hashSet_0.Add(item2.method_69());
			}
		}
	}

	internal static Setting smethod_22(SettingOrSpecialObject settingOrSpecialObject_0)
	{
		foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_1())
		{
			if (item is Setting)
			{
				Setting setting = item as Setting;
				if (!setting.method_219() && !setting.method_207() && (setting.method_2().EndsWith(Class333.smethod_532()) || setting.method_2().EndsWith(Class333.smethod_533()) || setting.method_2().EndsWith(Class333.smethod_534())))
				{
					return setting;
				}
			}
		}
		return null;
	}

	internal static void smethod_23(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0, bool bool_1, List<Class245> list_0, bool bool_2 = false)
	{
		if (bool_1 && !bool_0)
		{
			SettingOrSpecialObject settingOrSpecialObject = null;
			if (settingOrSpecialObject_0.method_0().aWx.Contains(settingOrSpecialObject_0))
			{
				if (settingOrSpecialObject_0.method_6() != null)
				{
					foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_6().method_1())
					{
						if (item is SpecialObject && item != settingOrSpecialObject_0 && item.method_2() == settingOrSpecialObject_0.method_2())
						{
							settingOrSpecialObject = item;
							break;
						}
					}
				}
				else
				{
					foreach (SettingOrSpecialObject aW in settingOrSpecialObject_0.method_0().aWS)
					{
						if (aW is SpecialObject && aW != settingOrSpecialObject_0 && aW.method_5() == settingOrSpecialObject_0.method_5() && aW.method_2() == settingOrSpecialObject_0.method_2())
						{
							settingOrSpecialObject = aW;
							break;
						}
					}
				}
			}
			if (settingOrSpecialObject != null)
			{
				foreach (SettingOrSpecialObject item2 in settingOrSpecialObject.method_1())
				{
					if (!(item2 is Setting))
					{
						continue;
					}
					Setting setting = item2 as Setting;
					if (!setting.method_207() && setting.method_2() == Class333.aTe())
					{
						Class245 @class = setting as Class245;
						if ((bool_2 || !@class.method_219()) && !@class.method_212() && !@class.method_220() && !@class.method_154() && @class.method_102().Count != 0)
						{
							list_0.Add(@class);
						}
					}
				}
			}
		}
		foreach (SettingOrSpecialObject item3 in settingOrSpecialObject_0.method_1())
		{
			if (item3 is Class245)
			{
				Class245 class2 = item3 as Class245;
				if ((bool_2 || !class2.method_219()) && !class2.method_212() && !class2.method_220())
				{
					list_0.Add(class2);
				}
			}
		}
		if (bool_0 || settingOrSpecialObject_0.method_27().Count == 0)
		{
			return;
		}
		foreach (int item4 in settingOrSpecialObject_0.method_27())
		{
			smethod_23(settingOrSpecialObject_0.method_0().method_33(item4), bool_0: true, bool_1, list_0, bool_2);
		}
	}

	internal static void smethod_24(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0, List<Class244> list_0, bool bool_1 = false)
	{
		foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_1())
		{
			if (item is Class244)
			{
				Class244 @class = item as Class244;
				if (bool_1 || !@class.method_219())
				{
					list_0.Add(@class);
				}
			}
		}
		if (bool_0 || settingOrSpecialObject_0.method_27().Count == 0)
		{
			return;
		}
		foreach (int item2 in settingOrSpecialObject_0.method_27())
		{
			smethod_24(settingOrSpecialObject_0.method_0().method_33(item2), bool_0: true, list_0, bool_1);
		}
	}

	internal static void smethod_25(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0, List<Table> list_0, bool bool_1)
	{
		for (int i = 0; i < settingOrSpecialObject_0.method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = settingOrSpecialObject_0.method_1()[i];
			if (settingOrSpecialObject is Class244)
			{
				smethod_34(settingOrSpecialObject as Class244, list_0, bool_1);
			}
		}
		if (bool_0 || settingOrSpecialObject_0.method_27().Count == 0)
		{
			return;
		}
		foreach (int item in settingOrSpecialObject_0.method_27())
		{
			smethod_25(settingOrSpecialObject_0.method_0().method_33(item), bool_0: true, list_0, bool_1);
		}
	}

	internal static void smethod_26(Class244 class244_0, List<Setting> list_0, List<Table> list_1)
	{
		int num = class244_0.method_256();
		if (num == 0)
		{
			return;
		}
		Enum104 @enum = smethod_12((uint)num);
		if (@enum == Enum104.BAM)
		{
			return;
		}
		Enum105 enum2 = smethod_13((uint)num);
		byte b = smethod_14((uint)num);
		int num2 = 0;
		SettingOrSpecialObject settingOrSpecialObject;
		while (true)
		{
			if (num2 < class244_0.method_0().awD.Count)
			{
				settingOrSpecialObject = class244_0.method_0().awD[num2];
				if (settingOrSpecialObject.method_12().method_12().BSQ == @enum && settingOrSpecialObject.method_12().method_12().BSq == enum2 && settingOrSpecialObject.method_12().method_12().BSR == b)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		for (int i = 0; i < settingOrSpecialObject.method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject2 = settingOrSpecialObject.method_1()[i];
			if (!settingOrSpecialObject2.method_35())
			{
				continue;
			}
			if (settingOrSpecialObject2 is Table)
			{
				Table table = settingOrSpecialObject2 as Table;
				string text = table.method_2().Replace(Class333.smethod_184(), Class333.smethod_102()).Replace(Class333.smethod_227(), Class333.smethod_102())
					.Replace(Class333.smethod_264(), Class333.smethod_102())
					.Replace(Class333.smethod_262(), Class333.smethod_102())
					.Replace(Class333.smethod_260(), Class333.smethod_102())
					.Replace(Class333.smethod_258(), Class333.smethod_102())
					.Replace(Class333.smethod_256(), Class333.smethod_102())
					.Replace(Class333.smethod_254(), Class333.smethod_102())
					.Replace(Class333.smethod_2237(), Class333.smethod_102())
					.Replace(Class333.smethod_2239(), Class333.smethod_102());
				foreach (Table item in list_1)
				{
					string text2 = item.method_2().Replace(Class333.smethod_184(), Class333.smethod_102()).Replace(Class333.smethod_227(), Class333.smethod_102())
						.Replace(Class333.smethod_264(), Class333.smethod_102())
						.Replace(Class333.smethod_262(), Class333.smethod_102())
						.Replace(Class333.smethod_260(), Class333.smethod_102())
						.Replace(Class333.smethod_258(), Class333.smethod_102())
						.Replace(Class333.smethod_256(), Class333.smethod_102())
						.Replace(Class333.smethod_254(), Class333.smethod_102())
						.Replace(Class333.smethod_2237(), Class333.smethod_102())
						.Replace(Class333.smethod_2239(), Class333.smethod_102());
					if (text == text2 || text.EndsWith(text2) || text2.EndsWith(text) || (table.TableDataSetting.method_74() != 0 && table.TableDataSetting.method_74() == item.TableDataSetting.method_74()))
					{
						table.CopyFromAnotherTable(item, markForWrite: true);
						break;
					}
				}
			}
			else
			{
				if (!(settingOrSpecialObject2 is Setting setting) || setting.method_68() || setting.method_219() || class244_0.method_212() || class244_0.method_220() || setting.method_220() || setting.method_242()[0] != 1 || setting.method_242()[1] != 1 || setting.method_242()[2] != 1 || ((!setting.method_203() || !setting.method_204() || !setting.method_207()) && setting.method_207()))
				{
					continue;
				}
				foreach (Setting item2 in list_0)
				{
					if (settingOrSpecialObject2.method_2() == item2.method_2() || (setting.method_74() != 0 && setting.method_74() == item2.method_74()))
					{
						setting.method_272(item2.method_256(), bool_0: true);
						Form23.smethod_74(setting.method_64());
						break;
					}
				}
			}
		}
	}

	internal static bool smethod_27(SettingOrSpecialObject settingOrSpecialObject_0)
	{
		if (settingOrSpecialObject_0 != null)
		{
			if (settingOrSpecialObject_0.method_12().method_12().BSQ == Enum104.BAB)
			{
				return settingOrSpecialObject_0.method_12().method_12().BSq != Enum105.BAU;
			}
			return true;
		}
		return false;
	}

	internal static Class273 smethod_28(Setting setting_0, bool bool_0)
	{
		if (setting_0.method_6() != null)
		{
			if (smethod_27(setting_0.method_6()) && (bool_0 || !(setting_0 is Table)))
			{
				return setting_0.method_6().method_12().method_12();
			}
			if (bool_0)
			{
				if (setting_0.method_6() is Table)
				{
					Table table = setting_0.method_6() as Table;
					if (setting_0 == table.TableDataSetting && smethod_27(table.method_6()))
					{
						return table.method_6().method_12().method_12();
					}
				}
				else if (setting_0.method_6() is TableAxis)
				{
					Table table2 = (setting_0.method_6() as TableAxis).method_6() as Table;
					if (smethod_27(table2.method_6()))
					{
						return table2.method_6().method_12().method_12();
					}
				}
			}
		}
		return null;
	}

	internal static List<Setting> smethod_29(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0)
	{
		List<Setting> list = new List<Setting>();
		for (int i = 0; i < settingOrSpecialObject_0.method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = settingOrSpecialObject_0.method_1()[i];
			if (settingOrSpecialObject is Setting setting && (settingOrSpecialObject.method_35() || !bool_0) && !setting.method_68() && !setting.method_219() && setting.method_242()[0] == 1 && setting.method_242()[1] == 1 && setting.method_242()[2] == 1 && ((setting.method_203() && setting.method_204() && setting.method_207()) || !setting.method_207()))
			{
				list.Add(setting);
			}
		}
		return list;
	}

	internal static void smethod_30(int int_0, bool bool_0, bool bool_1, Framework framework_0, List<Setting> list_0, bool bool_2, bool bool_3 = false)
	{
		if (int_0 == 0)
		{
			return;
		}
		Enum104 @enum = smethod_12((uint)int_0);
		Enum105 enum2 = smethod_13((uint)int_0);
		byte b = smethod_14((uint)int_0);
		for (int i = 0; i < framework_0.awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = framework_0.awD[i];
			if (settingOrSpecialObject.method_12().method_12().BSQ != @enum || settingOrSpecialObject.method_12().method_12().BSq != enum2 || settingOrSpecialObject.method_12().method_12().BSR != b)
			{
				continue;
			}
			for (int j = 0; j < settingOrSpecialObject.method_1().Count; j++)
			{
				SettingOrSpecialObject settingOrSpecialObject2 = settingOrSpecialObject.method_1()[j];
				if (settingOrSpecialObject2 is Setting setting && (settingOrSpecialObject2.method_35() || !bool_2) && !setting.method_68() && (bool_3 || !setting.method_219()) && !bool_0 && !bool_1 && !setting.method_220() && setting.method_242()[0] == 1 && setting.method_242()[1] == 1 && setting.method_242()[2] == 1 && ((setting.method_203() && setting.method_204() && setting.method_207()) || !setting.method_207()))
				{
					list_0.Add(setting);
				}
			}
		}
	}

	internal static void smethod_31(Class244 class244_0, List<Setting> list_0, bool bool_0, bool bool_1 = false)
	{
		smethod_30(class244_0.method_256(), class244_0.method_212(), class244_0.method_220(), class244_0.method_0(), list_0, bool_0, bool_1);
	}

	internal static List<Table> smethod_32(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0)
	{
		List<Table> list = new List<Table>();
		for (int i = 0; i < settingOrSpecialObject_0.method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = settingOrSpecialObject_0.method_1()[i];
			if ((settingOrSpecialObject.method_35() || !bool_0) && settingOrSpecialObject is Table)
			{
				list.Add(settingOrSpecialObject as Table);
			}
		}
		return list;
	}

	internal static void smethod_33(int int_0, Framework framework_0, List<Table> list_0, bool bool_0)
	{
		if (int_0 == 0)
		{
			return;
		}
		Enum104 @enum = smethod_12((uint)int_0);
		Enum105 enum2 = smethod_13((uint)int_0);
		byte b = smethod_14((uint)int_0);
		for (int i = 0; i < framework_0.awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = framework_0.awD[i];
			if (settingOrSpecialObject.method_12().method_12().BSQ == @enum && settingOrSpecialObject.method_12().method_12().BSq == enum2 && settingOrSpecialObject.method_12().method_12().BSR == b)
			{
				list_0.AddRange(smethod_32(settingOrSpecialObject, bool_0));
			}
		}
	}

	internal static void smethod_34(Class244 class244_0, List<Table> list_0, bool bool_0)
	{
		smethod_33(class244_0.method_256(), class244_0.method_0(), list_0, bool_0);
	}

	internal static void smethod_35(MenuNode menuNode_0, SettingOrSpecialObject settingOrSpecialObject_0)
	{
		int num = -1;
		for (int i = 0; i < menuNode_0.method_6().Count; i++)
		{
			if (menuNode_0.method_6()[i].method_14())
			{
				menuNode_0.method_6()[i].method_4(-1);
				menuNode_0.method_6()[i].method_11(null);
				if (num == -1)
				{
					num = i;
				}
			}
		}
		if (num == -1)
		{
			return;
		}
		List<SettingOrSpecialObject> list = new List<SettingOrSpecialObject>();
		List<Class244> list2 = new List<Class244>();
		smethod_24(settingOrSpecialObject_0, bool_0: false, list2, bool_1: true);
		for (int j = 0; j < list2.Count; j++)
		{
			Class244 @class = list2[j];
			if (!@class.method_35())
			{
				continue;
			}
			uint num2 = (uint)@class.method_256();
			if (num2 != 0)
			{
				Enum104 enum104_ = smethod_12(num2);
				Enum105 enum105_ = smethod_13(num2);
				byte byte_ = smethod_14(num2);
				ushort ushort_ = smethod_15(num2);
				SettingOrSpecialObject settingOrSpecialObject = smethod_36(settingOrSpecialObject_0.method_0(), enum104_, enum105_, byte_, ushort_);
				if (settingOrSpecialObject != null && settingOrSpecialObject.method_35())
				{
					list.Add(settingOrSpecialObject);
				}
			}
		}
		foreach (Class272 item in settingOrSpecialObject_0.method_12().method_8())
		{
			Enum104 bSl = item.BSl;
			Enum105 bSM = item.BSM;
			byte bSm = item.BSm;
			ushort bSN = item.BSN;
			SettingOrSpecialObject settingOrSpecialObject2 = smethod_36(settingOrSpecialObject_0.method_0(), bSl, bSM, bSm, bSN);
			if (settingOrSpecialObject2 != null && settingOrSpecialObject2.method_35())
			{
				list.Add(settingOrSpecialObject2);
			}
		}
		int num3 = 0;
		foreach (SettingOrSpecialObject item2 in list)
		{
			for (int k = 0; k < item2.method_1().Count; k++)
			{
				SettingOrSpecialObject settingOrSpecialObject3 = item2.method_1()[k];
				if (settingOrSpecialObject3.method_35() && settingOrSpecialObject3 is Table)
				{
					if (num3 >= 20)
					{
						throw new Exception(string.Format(Class333.aTF(), settingOrSpecialObject_0.method_60(Enum96.aYt), 20));
					}
					MenuNode menuNode = menuNode_0.method_6()[num + num3];
					menuNode.method_4(settingOrSpecialObject3.method_57());
					menuNode.method_11(settingOrSpecialObject3.method_22(bool_0: true));
					num3++;
				}
			}
		}
	}

	internal static SettingOrSpecialObject smethod_36(Framework framework_0, Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0)
	{
		foreach (SettingOrSpecialObject item in framework_0.awD)
		{
			if (enum104_0 == Enum104.BAM)
			{
				if (item.method_12().method_12().BSQ == enum104_0 && item.method_12().method_12().BSq == enum105_0 && item.method_12().method_12().BSr == ushort_0)
				{
					return item;
				}
			}
			else if (item.method_12().method_12().BSQ == enum104_0 && item.method_12().method_12().BSq == enum105_0 && item.method_12().method_12().BSR == byte_0)
			{
				return item;
			}
		}
		return null;
	}

	internal static string smethod_37(SettingOrSpecialObject settingOrSpecialObject_0)
	{
		if (settingOrSpecialObject_0 != null)
		{
			if ((settingOrSpecialObject_0 is Setting && (settingOrSpecialObject_0 as Setting).method_207() && settingOrSpecialObject_0.method_12().method_12().BSQ == Enum104.BAM) || (settingOrSpecialObject_0 is SpecialObject && smethod_11(settingOrSpecialObject_0.method_12().method_12().BSQ)))
			{
				string text = settingOrSpecialObject_0.method_18();
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text + Class333.smethod_497() + settingOrSpecialObject_0.method_60(Enum96.aYT) + Class333.smethod_9();
				}
			}
			string text2 = settingOrSpecialObject_0.method_60(Enum96.aYv);
			if (string.IsNullOrEmpty(text2))
			{
				text2 = settingOrSpecialObject_0.method_60(Enum96.aYu);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				return text2;
			}
			return settingOrSpecialObject_0.method_60(Enum96.aYT);
		}
		return null;
	}

	internal static int smethod_38(Framework framework_0, bool bool_0, Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0)
	{
		int num = 0;
		foreach (Class244 item in framework_0.awd)
		{
			if (!item.method_35() && bool_0)
			{
				continue;
			}
			int uint_ = item.method_256();
			Enum104 @enum = smethod_12((uint)uint_);
			Enum105 enum2 = smethod_13((uint)uint_);
			byte b = smethod_14((uint)uint_);
			ushort num2 = smethod_15((uint)uint_);
			bool flag = false;
			if (enum104_0 == Enum104.BAM)
			{
				if (@enum == enum104_0 && enum2 == enum105_0 && num2 == ushort_0)
				{
					flag = true;
				}
			}
			else if (@enum == enum104_0 && enum2 == enum105_0 && b == byte_0)
			{
				flag = true;
			}
			if (!flag)
			{
				continue;
			}
			bool flag2 = true;
			if (bool_0)
			{
				int bbC = item.method_12().BbC;
				if (bbC != 0)
				{
					Setting setting = framework_0.method_31(bbC);
					if (setting != null)
					{
						flag2 = setting.method_256() == 1;
					}
				}
			}
			if (flag2)
			{
				num++;
			}
		}
		return num;
	}

	internal static bool smethod_39(Class244 class244_0)
	{
		for (int i = 0; i < class244_0.method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = class244_0.method_1()[i];
			if (!(settingOrSpecialObject is FilterOption))
			{
				continue;
			}
			FilterOption filterOption = settingOrSpecialObject as FilterOption;
			if (!filterOption.method_74())
			{
				continue;
			}
			List<FilterOption.Class266> list = filterOption.method_78();
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].bbE == Enum104.BAM)
				{
					return true;
				}
			}
		}
		return false;
	}

	internal static bool smethod_40(SettingOrSpecialObject settingOrSpecialObject_0, Class244 class244_0)
	{
		if (settingOrSpecialObject_0 != null && settingOrSpecialObject_0.method_35())
		{
			Enum104 bSQ = settingOrSpecialObject_0.method_12().method_12().BSQ;
			Enum105 bSq = settingOrSpecialObject_0.method_12().method_12().BSq;
			byte bSR = settingOrSpecialObject_0.method_12().method_12().BSR;
			ushort bSr = settingOrSpecialObject_0.method_12().method_12().BSr;
			for (int num = class244_0.method_1().Count - 1; num >= 0; num--)
			{
				SettingOrSpecialObject settingOrSpecialObject = class244_0.method_1()[num];
				if (settingOrSpecialObject is FilterOption)
				{
					FilterOption filterOption = settingOrSpecialObject as FilterOption;
					if (filterOption.method_74())
					{
						List<FilterOption.Class266> list = filterOption.method_78();
						int num2 = list.Count - 1;
						while (num2 >= 0)
						{
							FilterOption.Class266 @class = list[num2];
							Enum104 bbE = @class.bbE;
							Enum105 bbe = @class.bbe;
							byte bbF = @class.bbF;
							ushort bbf = @class.bbf;
							if (!((bSQ != Enum104.BAM) ? ((bSQ == bbE || bbE == Enum104.BAB) && (bSq == bbe || bbe == Enum105.BAU) && (bSR == bbF || bbF == byte.MaxValue)) : ((bSQ == bbE || bbE == Enum104.BAB) && (bSq == bbe || bbe == Enum105.BAU) && (bSr == bbf || bbf == 0))))
							{
								num2--;
								continue;
							}
							return @class.bbG;
						}
					}
				}
			}
			return false;
		}
		return false;
	}

	internal static void smethod_41(Framework framework_0, bool bool_0)
	{
		foreach (Class244 item in framework_0.awd)
		{
			if (item.method_219())
			{
				continue;
			}
			int num = item.method_256();
			if (num != 0)
			{
				Enum104 enum104_ = smethod_12((uint)num);
				Enum105 enum105_ = smethod_13((uint)num);
				byte byte_ = smethod_14((uint)num);
				ushort ushort_ = smethod_15((uint)num);
				if (!smethod_40(smethod_36(framework_0, enum104_, enum105_, byte_, ushort_), item))
				{
					item.method_272(0, bool_0);
				}
			}
		}
	}

	internal static void smethod_42(Framework framework_0, Enum104 enum104_0, Enum104 enum104_1)
	{
		if (enum104_0 == Enum104.BAB || enum104_1 == Enum104.BAB)
		{
			return;
		}
		foreach (SettingOrSpecialObject item in framework_0.awD)
		{
			Class273 @class = item.method_12().method_12();
			if (@class.BSQ != enum104_0)
			{
				continue;
			}
			List<Class244> list = smethod_44(framework_0, @class.BSQ, @class.BSq, @class.BSR, @class.BSr, bool_0: false);
			if (list == null || list.Count == 0)
			{
				continue;
			}
			foreach (Class244 item2 in list)
			{
				uint uint_ = (uint)item2.method_256();
				if (smethod_12(uint_) == enum104_0)
				{
					Enum105 enum105_ = smethod_13(uint_);
					byte byte_ = smethod_14(uint_);
					uint int_ = smethod_16(enum104_1, enum105_, byte_);
					List<Setting> list_ = new List<Setting>();
					smethod_31(item2, list_, bool_0: false);
					List<Table> list2 = new List<Table>();
					smethod_34(item2, list2, bool_0: false);
					item2.method_272((int)int_, bool_0: true);
					if (smethod_38(framework_0, bool_0: true, enum104_1, enum105_, byte_, 0) == 1)
					{
						smethod_26(item2, list_, list2);
					}
					Form23.smethod_74(item2.method_64());
				}
			}
		}
	}

	internal static bool smethod_43(Framework framework_0, Enum104 enum104_0)
	{
		foreach (SettingOrSpecialObject item in framework_0.awD)
		{
			if (item.method_35() && item.method_12().method_12().BSQ == enum104_0)
			{
				return true;
			}
		}
		return false;
	}

	internal static List<Class244> smethod_44(Framework framework_0, Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0, bool bool_0)
	{
		List<Class244> list = null;
		List<WiringPin> list2 = null;
		if (bool_0)
		{
			list2 = WiringPin.smethod_0(framework_0, enum104_0, enum105_0, byte_0, ushort_0);
		}
		for (int i = 0; i < framework_0.awd.Count; i++)
		{
			Class244 @class = framework_0.awd[i];
			bool flag;
			if (!(flag = @class.method_35()))
			{
				continue;
			}
			int bbC = @class.method_12().BbC;
			if (bbC != 0)
			{
				Setting setting = framework_0.method_31(bbC);
				if (setting != null)
				{
					flag = setting.method_256() == 1;
				}
			}
			if (!flag)
			{
				continue;
			}
			int uint_ = @class.method_256();
			Enum104 @enum = smethod_12((uint)uint_);
			Enum105 enum2 = smethod_13((uint)uint_);
			byte b = smethod_14((uint)uint_);
			ushort num = smethod_15((uint)uint_);
			bool flag2 = false;
			if (enum104_0 != Enum104.BAM && @enum == enum104_0 && enum2 == enum105_0 && b == byte_0)
			{
				flag2 = true;
			}
			else if (enum104_0 == Enum104.BAM && @enum == enum104_0 && enum2 == enum105_0 && num == ushort_0)
			{
				flag2 = true;
			}
			else if (bool_0)
			{
				foreach (WiringPin item in WiringPin.smethod_0(framework_0, @enum, enum2, b, num))
				{
					if (list2.Contains(item))
					{
						flag2 = true;
						break;
					}
				}
			}
			if (flag2)
			{
				if (list == null)
				{
					list = new List<Class244>();
				}
				list.Add(@class);
			}
		}
		return list;
	}

	internal static List<string> smethod_45(Framework framework_0, Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0, bool bool_0, List<bool> list_0)
	{
		List<string> list = null;
		if (enum104_0 == Enum104.BAg)
		{
			List<string> list2 = new List<string>(1);
			CollectionsMarshal.SetCount(list2, 1);
			CollectionsMarshal.AsSpan(list2)[0] = Class333.aSM();
			list = list2;
			list_0.Add(item: false);
			return list;
		}
		if (smethod_10(enum104_0))
		{
			List<string> list3 = new List<string>(1);
			CollectionsMarshal.SetCount(list3, 1);
			CollectionsMarshal.AsSpan(list3)[0] = Class333.aMg();
			list = list3;
			list_0.Add(item: false);
			return list;
		}
		if (enum104_0 == Enum104.BAS)
		{
			List<string> list4 = new List<string>(1);
			CollectionsMarshal.SetCount(list4, 1);
			CollectionsMarshal.AsSpan(list4)[0] = Class333.aSm();
			list = list4;
			list_0.Add(item: false);
			return list;
		}
		if (smethod_11(enum104_0))
		{
			List<string> list5 = new List<string>(1);
			CollectionsMarshal.SetCount(list5, 1);
			CollectionsMarshal.AsSpan(list5)[0] = Class333.aMF();
			list = list5;
			list_0.Add(item: false);
			return list;
		}
		List<WiringPin> list6 = WiringPin.smethod_0(framework_0, enum104_0, enum105_0, byte_0, ushort_0);
		for (int i = 0; i < framework_0.awd.Count; i++)
		{
			Class244 @class = framework_0.awd[i];
			bool flag;
			if (!(flag = @class.method_35()))
			{
				continue;
			}
			int bbC = @class.method_12().BbC;
			if (bbC != 0)
			{
				Setting setting = framework_0.method_31(bbC);
				if (setting != null)
				{
					flag = setting.method_256() == 1;
				}
			}
			if (!flag)
			{
				continue;
			}
			int uint_ = @class.method_256();
			Enum104 @enum = smethod_12((uint)uint_);
			Enum105 enum2 = smethod_13((uint)uint_);
			byte b = smethod_14((uint)uint_);
			ushort num = smethod_15((uint)uint_);
			bool flag2 = false;
			if (enum104_0 != Enum104.BAM && @enum == enum104_0 && enum2 == enum105_0 && b == byte_0)
			{
				flag2 = true;
			}
			else if (enum104_0 == Enum104.BAM && @enum == enum104_0 && enum2 == enum105_0 && num == ushort_0)
			{
				flag2 = true;
			}
			else if (bool_0)
			{
				foreach (WiringPin item2 in WiringPin.smethod_0(framework_0, @enum, enum2, b, num))
				{
					if (list6.Contains(item2))
					{
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				continue;
			}
			string text = @class.method_60(Enum96.aYv);
			if (string.IsNullOrEmpty(text))
			{
				text = @class.method_60(Enum96.aYu);
			}
			string text2 = (string.IsNullOrEmpty(text) ? @class.method_60(Enum96.aYt) : text);
			if (list == null)
			{
				list = new List<string>();
			}
			bool item = false;
			foreach (SettingOrSpecialObject item3 in @class.method_1())
			{
				if (item3 is FilterOption)
				{
					FilterOption filterOption = item3 as FilterOption;
					if (filterOption.method_74() && filterOption.method_71())
					{
						item = true;
						break;
					}
				}
			}
			string text3 = @class.method_18();
			if (!string.IsNullOrWhiteSpace(text3))
			{
				text2 = text3 + Class333.smethod_497() + text2 + Class333.smethod_9();
			}
			if (@class.method_4() != -1)
			{
				SettingOrSpecialObject settingOrSpecialObject = framework_0.method_33(@class.method_4());
				if (settingOrSpecialObject != null)
				{
					string text4 = settingOrSpecialObject.method_60(Enum96.aYt);
					if (string.IsNullOrEmpty(text4))
					{
						text4 = settingOrSpecialObject.method_60(Enum96.aYu);
					}
					if (string.IsNullOrEmpty(text4))
					{
						text4 = settingOrSpecialObject.method_60(Enum96.aYT);
					}
					string text5 = settingOrSpecialObject.method_18();
					if (!string.IsNullOrWhiteSpace(text5))
					{
						text4 = text5 + Class333.smethod_497() + text4 + Class333.smethod_9();
					}
					list.Add(text2 + Class333.aTf() + text4);
					list_0.Add(item);
				}
				else
				{
					list.Add(text2);
					list_0.Add(item);
				}
			}
			else
			{
				list.Add(text2);
				list_0.Add(item);
			}
		}
		return list;
	}

	internal static Class272 smethod_46(Framework framework_0, Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0)
	{
		for (int i = 0; i < framework_0.awE.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = framework_0.awE[i];
			if (!settingOrSpecialObject.method_35())
			{
				continue;
			}
			for (int j = 0; j < settingOrSpecialObject.method_12().method_8().Count; j++)
			{
				Class272 @class = settingOrSpecialObject.method_12().method_8()[j];
				Enum104 bSl = @class.BSl;
				Enum105 bSM = @class.BSM;
				byte bSm = @class.BSm;
				ushort bSN = @class.BSN;
				if (enum104_0 == Enum104.BAM)
				{
					if (bSl == enum104_0 && bSM == enum105_0 && bSN == ushort_0)
					{
						return @class;
					}
				}
				else if (bSl == enum104_0 && bSM == enum105_0 && bSm == byte_0)
				{
					return @class;
				}
			}
		}
		return null;
	}

	internal static string smethod_47(Framework framework_0, Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0)
	{
		Class272 @class = smethod_46(framework_0, enum104_0, enum105_0, byte_0, ushort_0);
		if (@class != null)
		{
			if (enum104_0 == Enum104.BAM)
			{
				return @class.BSn;
			}
			return enum105_0 switch
			{
				Enum105.Baa => smethod_48(framework_0, byte_0 + 1, @class.BSn), 
				Enum105.BaB => smethod_50(framework_0, byte_0 + 1, @class.BSn), 
				_ => @class.BSn, 
			};
		}
		return null;
	}

	internal static string smethod_48(Framework framework_0, int int_0, string string_0)
	{
		Setting setting = framework_0.method_31(93);
		Setting setting2 = framework_0.method_31(94);
		Setting setting3 = framework_0.method_31(95);
		Setting setting4 = framework_0.method_31(101);
		if (setting != null && setting2 != null && setting3 != null && setting4 != null)
		{
			if ((!setting.method_122() && setting.method_124() != IllegalitySeverityLevel.Warning) || (!setting2.method_122() && setting2.method_124() != IllegalitySeverityLevel.Warning) || (!setting3.method_122() && setting3.method_124() != IllegalitySeverityLevel.Warning) || (!setting4.method_122() && setting4.method_124() != IllegalitySeverityLevel.Warning))
			{
				return Class333.aTG();
			}
			int num = setting4.method_256();
			bool flag = false;
			if (Class242.smethod_12(framework_0.awZ))
			{
				Setting setting5 = framework_0.method_31(12212);
				if (setting5 != null)
				{
					flag = setting5.method_256() == 1;
				}
			}
			Setting[] array = new Setting[num];
			Setting[] array2 = new Setting[num];
			Setting[] array3 = new Setting[num];
			int[] array4 = new int[4] { 106, 109, 112, 115 };
			int[] array5 = new int[4] { 107, 110, 113, 116 };
			int[] array6 = new int[4] { 188, 190, 192, 197 };
			int num2 = 0;
			while (true)
			{
				if (num2 < num)
				{
					Setting setting6 = framework_0.method_31(array4[num2]);
					if (setting6 == null)
					{
						break;
					}
					array[num2] = setting6;
					Setting setting7 = framework_0.method_31(array5[num2]);
					if (setting7 != null)
					{
						array2[num2] = setting7;
						Setting setting8 = framework_0.method_31(array6[num2]);
						if (setting8 != null)
						{
							array3[num2] = setting8;
						}
						else if (flag)
						{
							return string_0;
						}
						num2++;
						continue;
					}
					return string_0;
				}
				bool flag2 = true;
				for (int i = 0; i < num; i++)
				{
					if (array[i].method_122() || array[i].method_124() == IllegalitySeverityLevel.Warning)
					{
						if (flag)
						{
							if (!array3[i].method_122() && array3[i].method_124() != IllegalitySeverityLevel.Warning)
							{
								flag2 = false;
								break;
							}
						}
						else if (!array2[i].method_122() && array2[i].method_124() != IllegalitySeverityLevel.Warning)
						{
							flag2 = false;
							break;
						}
						continue;
					}
					flag2 = false;
					break;
				}
				if (!flag2)
				{
					return Class333.aTG();
				}
				int num3 = setting.method_256();
				string text = ((num3 == 0 || num3 == 1) ? Class333.aTg() : Class333.aTH());
				int num4 = 0;
				int num5 = 0;
				int num6;
				while (true)
				{
					if (num5 < num)
					{
						num6 = array[num5].method_256();
						if (int_0 <= num4 + num6)
						{
							break;
						}
						num4 += num6;
						num5++;
						continue;
					}
					return Class333.aTG();
				}
				int num7 = num5 + 1;
				string text2 = string.Empty;
				if (num != 1)
				{
					text2 = text2 + Class333.aTh() + num7 + Class333.smethod_536();
				}
				if (flag)
				{
					switch (array3[num5].method_256())
					{
					default:
						return Class333.aTG();
					case 0:
						return text2 + Class333.aTI() + text + Class333.smethod_325() + (int_0 - num4);
					case 1:
						return text2 + Class333.aTi() + (int_0 - num4);
					case 2:
					{
						int num8 = setting2.method_256();
						int num9 = int_0 - 1 - num4;
						int num10 = setting3.method_258(num9);
						int int_1 = (num9 + num8 / 2) % num8;
						int num11 = setting3.method_258(int_1);
						return text2 + Class333.aTI() + text + Class333.aTJ() + num10 + Class333.aTj() + num11;
					}
					}
				}
				int num12 = array2[num5].method_256();
				int num13 = setting2.method_256();
				switch (num12)
				{
				default:
					return Class333.aTG();
				case 1:
					if (num6 == num13 / 2)
					{
						int num16 = int_0 - 1 - num4;
						int num17 = setting3.method_258(num16);
						int int_2 = (num16 + num13 / 2) % num13;
						int num18 = setting3.method_258(int_2);
						text2 = text2 + Class333.aTI() + text + Class333.aTJ() + num17 + Class333.aTj() + num18;
					}
					else if (num6 == num13)
					{
						text2 = text2 + Class333.aTI() + text + Class333.smethod_325() + (int_0 - num4);
					}
					return text2;
				case 2:
				case 3:
					return text2 + Class333.aTi() + (int_0 - num4);
				case 0:
				case 4:
				{
					if (num6 == num13)
					{
						return text2 + Class333.aTI() + text + Class333.smethod_325() + (int_0 - num4);
					}
					int num14 = int_0 - 1 - num4;
					int num15 = num6 / num13;
					return text2 + Class333.aTI() + text + Class333.smethod_325() + (num14 / num15 + 1);
				}
				}
			}
			return string_0;
		}
		return string_0;
	}

	internal static string smethod_49(Framework framework_0, int int_0, int int_1, string string_0)
	{
		Setting setting = framework_0.method_31(93);
		Setting setting2 = framework_0.method_31(94);
		Setting setting3 = framework_0.method_31(95);
		Setting setting4 = framework_0.method_31(101);
		if (setting != null && setting2 != null && setting3 != null && setting4 != null)
		{
			if ((!setting.method_122() && setting.method_124() != IllegalitySeverityLevel.Warning) || (!setting2.method_122() && setting2.method_124() != IllegalitySeverityLevel.Warning) || (!setting3.method_122() && setting3.method_124() != IllegalitySeverityLevel.Warning) || (!setting4.method_122() && setting4.method_124() != IllegalitySeverityLevel.Warning))
			{
				return Class333.aTK();
			}
			int num = setting4.method_256();
			bool flag = false;
			if (Class242.smethod_12(framework_0.awZ))
			{
				Setting setting5 = framework_0.method_31(12212);
				if (setting5 != null)
				{
					flag = setting5.method_256() == 1;
				}
			}
			int[] array = new int[4] { 106, 109, 112, 115 };
			int[] array2 = new int[4] { 107, 110, 113, 116 };
			int[] array3 = new int[4] { 188, 190, 192, 197 };
			Setting setting6 = framework_0.method_31(array[int_0]);
			if (setting6 == null)
			{
				return string_0;
			}
			Setting setting7 = framework_0.method_31(array2[int_0]);
			if (setting7 == null)
			{
				return string_0;
			}
			Setting setting8 = framework_0.method_31(array3[int_0]);
			if ((setting8 == null) & flag)
			{
				return string_0;
			}
			if (!setting6.method_122() && setting6.method_124() != IllegalitySeverityLevel.Warning)
			{
				return Class333.aTK();
			}
			if (flag)
			{
				if (!setting8.method_122() && setting8.method_124() != IllegalitySeverityLevel.Warning)
				{
					return Class333.aTK();
				}
			}
			else if (!setting7.method_122() && setting7.method_124() != IllegalitySeverityLevel.Warning)
			{
				return Class333.aTK();
			}
			int num2 = setting6.method_256();
			int num3 = setting.method_256();
			string text = ((num3 == 0 || num3 == 1) ? Class333.aTg() : Class333.aTH());
			int num4 = int_0 + 1;
			string text2 = string.Empty;
			if (num != 1)
			{
				text2 = text2 + Class333.aTh() + num4 + Class333.smethod_536();
			}
			if (flag)
			{
				switch (setting8.method_256())
				{
				default:
					return Class333.aTK();
				case 0:
					return text2 + text + Class333.smethod_325() + (int_1 + 1);
				case 1:
					return text2 + Class333.aTk() + (int_1 + 1);
				case 2:
				{
					int num5 = setting2.method_256();
					int num6 = setting3.method_258(int_1);
					int int_2 = (int_1 + num5 / 2) % num5;
					int num7 = setting3.method_258(int_2);
					return text2 + text + Class333.aTJ() + num6 + Class333.aTj() + num7;
				}
				}
			}
			int num8 = setting7.method_256();
			int num9 = setting2.method_256();
			switch (num8)
			{
			default:
				return Class333.aTK();
			case 1:
				if (num2 == num9 / 2)
				{
					int num11 = setting3.method_258(int_1);
					int int_3 = (int_1 + num9 / 2) % num9;
					int num12 = setting3.method_258(int_3);
					text2 = text2 + text + Class333.aTJ() + num11 + Class333.aTj() + num12;
				}
				else if (num2 == num9)
				{
					text2 = text2 + text + Class333.smethod_325() + (int_1 + 1);
				}
				return text2;
			case 2:
			case 3:
				return text2 + Class333.aTk() + (int_1 + 1);
			case 0:
			case 4:
			{
				if (num2 == num9)
				{
					return text2 + text + Class333.smethod_325() + (int_1 + 1);
				}
				int num10 = num2 / num9;
				return text2 + text + Class333.smethod_325() + (int_1 / num10 + 1);
			}
			}
		}
		return string_0;
	}

	internal static string smethod_50(Framework framework_0, int int_0, string string_0)
	{
		Setting setting = framework_0.method_31(93);
		Setting setting2 = framework_0.method_31(94);
		Setting setting3 = framework_0.method_31(95);
		Setting setting4 = framework_0.method_31(98);
		if (setting != null && setting2 != null && setting3 != null && setting4 != null)
		{
			if ((!setting.method_122() && setting.method_124() != IllegalitySeverityLevel.Warning) || (!setting2.method_122() && setting2.method_124() != IllegalitySeverityLevel.Warning) || (!setting3.method_122() && setting3.method_124() != IllegalitySeverityLevel.Warning) || (!setting4.method_122() && setting4.method_124() != IllegalitySeverityLevel.Warning))
			{
				return Class333.aTL();
			}
			switch (setting.method_256())
			{
			case 2:
			{
				int num5 = setting2.method_256();
				switch (setting4.method_256())
				{
				default:
					return string_0;
				case 0:
					if (int_0 <= num5)
					{
						return Class333.aTn() + int_0 + Class333.aTO();
					}
					return Class333.aTn() + (int_0 - num5) + Class333.aTo();
				case 1:
					if (int_0 <= num5 / 2)
					{
						int num6 = int_0 - 1;
						int num7 = setting3.method_258(num6);
						int int_2 = (num6 + num5 / 2) % num5;
						int num8 = setting3.method_258(int_2);
						return Class333.aTP() + num7 + Class333.aTj() + num8 + Class333.aTO();
					}
					if (int_0 > num5)
					{
						return Class333.aTn() + (int_0 - num5) + Class333.aTo();
					}
					return string_0;
				case 2:
					return Class333.aTm();
				case 3:
					return string_0;
				case 4:
					return string_0;
				}
			}
			default:
				return string_0;
			case 0:
			case 1:
			{
				int num = setting2.method_256();
				switch (setting4.method_256())
				{
				default:
					return string_0;
				case 0:
					return Class333.aTl() + int_0;
				case 1:
				{
					int num2 = int_0 - 1;
					int num3 = setting3.method_258(num2);
					int int_1 = (num2 + num / 2) % num;
					int num4 = setting3.method_258(int_1);
					return Class333.aTM() + num3 + Class333.aTj() + num4;
				}
				case 2:
					return Class333.aTm();
				case 3:
					return Class333.aTN() + int_0;
				case 4:
					return string_0;
				}
			}
			}
		}
		return string_0;
	}

	internal static bool smethod_51(SettingOrSpecialObject settingOrSpecialObject_0, Class244 class244_0, Class272 class272_0)
	{
		if (settingOrSpecialObject_0.method_12().method_16().Count != 0 && (class244_0 == null || class244_0.method_12().method_16().Count != 0) && (class272_0 == null || class272_0.BSO))
		{
			foreach (Class271 item in settingOrSpecialObject_0.method_12().method_16())
			{
				if (class244_0 != null)
				{
					foreach (Class271 item2 in class244_0.method_12().method_16())
					{
						if (item.BSK == item2.BSK && item.BSk == item2.BSk)
						{
							return true;
						}
					}
				}
				else if (class272_0 != null && item.BSK == class272_0.BSo && item.BSk == class272_0.BSP)
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	internal static bool smethod_52(Setting setting_0)
	{
		if (setting_0.method_12().method_16().Count != 0 && setting_0.method_6() != null && !(setting_0.method_6() is Setting) && (setting_0.method_6().method_12().method_12()
			.BSQ != Enum104.BAB || setting_0.method_6().method_12().method_12()
			.BSq != Enum105.BAU))
		{
			Class273 @class = setting_0.method_6().method_12().method_12();
			List<Class244> list = smethod_44(setting_0.method_0(), @class.BSQ, @class.BSq, @class.BSR, @class.BSr, bool_0: false);
			if (list != null && list.Count != 0)
			{
				foreach (Class244 item in list)
				{
					if (item.method_12().method_16().Count != 0)
					{
						foreach (Class271 item2 in setting_0.method_12().method_16())
						{
							foreach (Class271 item3 in item.method_12().method_16())
							{
								if (item2.BSK == item3.BSK && item2.BSk == item3.BSk)
								{
									return true;
								}
							}
						}
						continue;
					}
					return true;
				}
				return false;
			}
			Class272 class2 = smethod_46(setting_0.method_0(), @class.BSQ, @class.BSq, @class.BSR, @class.BSr);
			if (class2 != null && class2.BSO)
			{
				foreach (Class271 item4 in setting_0.method_12().method_16())
				{
					if (item4.BSK == class2.BSo && item4.BSk == class2.BSP)
					{
						return true;
					}
				}
				return false;
			}
			return true;
		}
		return true;
	}
}
