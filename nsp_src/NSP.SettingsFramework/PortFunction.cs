using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using b;

namespace NSP.SettingsFramework;

public class PortFunction
{
	internal class A
	{
		internal Ch BSK;

		internal CI BSk;

		internal int BSL;

		internal A(ushort P_0, int P_1)
		{
			BSK = A(P_0);
			BSk = a(P_0);
			BSL = P_1;
		}

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEi() + ((object)BSK).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEJ() + ((object)BSk).ToString();
		}
	}

	internal class a
	{
		internal Cg BSl;

		internal CH BSM;

		internal byte BSm;

		internal ushort BSN;

		internal string BSn;

		internal bool BSO;

		internal Ch BSo;

		internal CI BSP;

		internal int BSp;

		internal a(uint P_0, string P_1, bool P_2, ushort P_3, int P_4)
		{
			BSl = A(P_0);
			BSM = a(P_0);
			BSm = B(P_0);
			BSN = b(P_0);
			BSn = P_1;
			BSO = P_2;
			BSo = A(P_3);
			BSP = a(P_3);
			BSp = P_4;
		}

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEj() + BSn;
		}
	}

	internal class B
	{
		internal Cg BSQ;

		internal CH BSq;

		internal byte BSR;

		internal ushort BSr;

		internal string BSS;

		internal Cg BSs;

		internal CH BST;

		internal byte BSt;

		internal ushort BSU;

		internal string BSu;

		internal Dictionary<int, Cg> BSV;

		internal Dictionary<int, CH> BSv;

		internal Dictionary<int, byte> BSW;

		internal Dictionary<int, ushort> BSw;

		internal Dictionary<int, string> BSX;

		internal B()
		{
			BSV = new Dictionary<int, Cg>();
			BSv = new Dictionary<int, CH>();
			BSW = new Dictionary<int, byte>();
			BSw = new Dictionary<int, ushort>();
			BSX = new Dictionary<int, string>();
		}

		internal void A(uint P_0, string P_1, int P_2)
		{
			if (P_2 == -1)
			{
				BSs = PortFunction.A(P_0);
				BSQ = BSs;
				BST = a(P_0);
				BSq = BST;
				BSt = B(P_0);
				BSR = BSt;
				BSU = b(P_0);
				BSr = BSU;
				BSu = P_1;
				BSS = P_1;
			}
			else
			{
				BSV.Add(P_2, PortFunction.A(P_0));
				BSv.Add(P_2, a(P_0));
				BSW.Add(P_2, B(P_0));
				BSw.Add(P_2, b(P_0));
				BSX.Add(P_2, P_1);
			}
		}

		public virtual string ToString()
		{
			return string.Concat(new string[10]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEK(),
				(!string.IsNullOrWhiteSpace(BSS)) ? BSS : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEk(),
				((object)BSQ).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEL(),
				((object)BSq).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEl(),
				BSR.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEM(),
				BSr.ToString()
			});
		}
	}

	private B BBX = new B();

	private B BBx = new B();

	private List<Setting> BBY = new List<Setting>();

	private List<int> BBy = new List<int>();

	internal int BBZ = -1;

	private List<a> BBz = new List<a>();

	private List<a> BbA = new List<a>();

	private List<A> Bba = new List<A>();

	private List<A> BbB = new List<A>();

	internal int Bbb = -1;

	internal int BbC;

	private string Bbc;

	private int BbD;

	internal bool Bbd;

	private SettingOrSpecialObject BbE;

	private Framework Bbe;

	private static Cg[] BbF;

	private static CH[] Bbf;

	internal static Image BbG;

	internal static Image Bbg;

	internal PortFunction(Framework P_0, SettingOrSpecialObject P_1)
	{
		Bbe = P_0;
		BbE = P_1;
	}

	internal static bt A(Cg P_0, Framework P_1)
	{
		switch (P_0)
		{
		case Cg.BAC:
			return bt.avk;
		case Cg.BAc:
			return bt.avL;
		case Cg.BAm:
			return bt.avU;
		case Cg.BAN:
			return bt.avu;
		case Cg.BAn:
			return bt.avV;
		case Cg.BAO:
			return bt.avv;
		case Cg.BAQ:
			return bt.avW;
		case Cg.BAq:
			return bt.avw;
		case Cg.BAR:
			if (P_1.A(bt.avX))
			{
				return bt.avX;
			}
			if (P_1.A(bt.avx))
			{
				return bt.avx;
			}
			if (P_1.A(bt.avY))
			{
				return bt.avY;
			}
			if (P_1.A(bt.avy))
			{
				return bt.avy;
			}
			break;
		case Cg.BAr:
			return bt.aWA;
		case Cg.BAf:
			return bt.avO;
		case Cg.BAF:
			return bt.avn;
		case Cg.BAh:
			return bt.avp;
		case Cg.BAI:
			return bt.avQ;
		case Cg.BAi:
			return bt.avq;
		case Cg.BAE:
			return bt.avm;
		case Cg.BAe:
			return bt.avN;
		case Cg.BAD:
			return bt.avl;
		case Cg.BAd:
			return bt.avM;
		case Cg.BAj:
			return bt.avR;
		case Cg.BAK:
			return bt.avr;
		case Cg.BAk:
			return bt.avS;
		case Cg.BAL:
			return bt.avs;
		case Cg.BAl:
			return bt.avT;
		}
		return bt.avK;
	}

	internal static string a(Cg P_0, Framework P_1)
	{
		bt bt = A(P_0, P_1);
		if (P_1.awf.ContainsKey((byte)bt))
		{
			return ((SettingOrSpecialObject)P_1.awf[(byte)bt]).H();
		}
		return null;
	}

	internal static string B(Cg P_0, Framework P_1)
	{
		switch (P_0)
		{
		case Cg.BAb:
			if (P_1 == null || string.IsNullOrEmpty(P_1.awY))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSF();
			}
			return P_1.awY;
		case Cg.BAC:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSf();
		case Cg.BAc:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSG();
		case Cg.BAE:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSg();
		case Cg.BAe:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSH();
		case Cg.BAD:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSh();
		case Cg.BAd:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSI();
		case Cg.BAj:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSi();
		case Cg.BAf:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSJ();
		case Cg.BAF:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSj();
		case Cg.BAh:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSK();
		case Cg.BAI:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSk();
		case Cg.BAi:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSL();
		case Cg.BAG:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSl();
		case Cg.BAg:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSM();
		case Cg.BAS:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSm();
		case Cg.BAH:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSN();
		case Cg.BAJ:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSn();
		case Cg.BAK:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSO();
		case Cg.BAk:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSo();
		case Cg.BAL:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSP();
		case Cg.BAl:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSp();
		case Cg.BAM:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wk();
		case Cg.BAm:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSQ();
		case Cg.BAN:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSq();
		case Cg.BAn:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSR();
		case Cg.BAO:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSr();
		case Cg.BAQ:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSS();
		case Cg.BAq:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSs();
		case Cg.BAR:
			if (P_1 == null)
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aST();
			}
			if (P_1.A(bt.avX))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHJ();
			}
			if (P_1.A(bt.avx))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHj();
			}
			if (P_1.A(bt.avY))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHK();
			}
			if (P_1.A(bt.avy))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHk();
			}
			break;
		case Cg.BAo:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSt();
		case Cg.BAP:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSU();
		case Cg.BAp:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSu();
		case Cg.BAr:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSV();
		case Cg.BAs:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSv();
		case Cg.BAT:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSW();
		case Cg.BAt:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSw();
		}
		return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSX();
	}

	internal static string b(Cg P_0, Framework P_1)
	{
		switch (P_0)
		{
		case Cg.BAb:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSF();
		case Cg.BAC:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSx();
		case Cg.BAc:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSY();
		case Cg.BAE:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSy();
		case Cg.BAe:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSZ();
		case Cg.BAD:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSz();
		case Cg.BAd:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asA();
		case Cg.BAj:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asa();
		case Cg.BAf:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asB();
		case Cg.BAF:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asb();
		case Cg.BAh:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asC();
		case Cg.BAI:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asc();
		case Cg.BAi:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asD();
		case Cg.BAG:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSl();
		case Cg.BAg:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSM();
		case Cg.BAS:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSm();
		case Cg.BAH:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asd();
		case Cg.BAJ:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSn();
		case Cg.BAK:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asE();
		case Cg.BAk:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ase();
		case Cg.BAL:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asF();
		case Cg.BAl:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asf();
		case Cg.BAM:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wk();
		case Cg.BAm:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asG();
		case Cg.BAN:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asg();
		case Cg.BAn:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asH();
		case Cg.BAO:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ash();
		case Cg.BAQ:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asI();
		case Cg.BAq:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asi();
		case Cg.BAR:
			if (P_1 == null)
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asJ();
			}
			if (P_1.A(bt.avX))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHM();
			}
			if (P_1.A(bt.avx))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHm();
			}
			if (P_1.A(bt.avY))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHN();
			}
			if (P_1.A(bt.avy))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHn();
			}
			break;
		case Cg.BAo:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asj();
		case Cg.BAP:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asK();
		case Cg.BAp:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ask();
		case Cg.BAr:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSV();
		case Cg.BAs:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSv();
		case Cg.BAT:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSW();
		case Cg.BAt:
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSw();
		}
		return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoa();
	}

	internal static string A(CH P_0)
	{
		return P_0 switch
		{
			CH.Bab => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asL(), 
			CH.Baa => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asl(), 
			CH.BaB => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asM(), 
			CH.BAu => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asm(), 
			CH.BAV => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asN(), 
			CH.BAv => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asn(), 
			CH.Baf => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asO(), 
			CH.BaG => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aso(), 
			CH.BaH => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asP(), 
			CH.Bah => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asp(), 
			CH.BaA => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asQ(), 
			CH.BaC => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asq(), 
			CH.Bac => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asR(), 
			CH.BAw => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asr(), 
			CH.BAX => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asS(), 
			CH.BAx => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ass(), 
			CH.BAY => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asT(), 
			CH.BaJ => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ast(), 
			CH.Bai => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asU(), 
			CH.BAW => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asu(), 
			CH.BaI => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asV(), 
			CH.Baj => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asv(), 
			CH.BAU => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asW(), 
			CH.BaN => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asw(), 
			CH.BaL => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asX(), 
			CH.BAz => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asx(), 
			CH.BAZ => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asY(), 
			CH.BAy => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asy(), 
			CH.Bal => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asZ(), 
			CH.BaM => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.asz(), 
			CH.Bam => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTA(), 
			CH.BaD => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTa(), 
			CH.Bad => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTB(), 
			CH.BaE => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTb(), 
			CH.Bae => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wk(), 
			CH.Bak => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTC(), 
			CH.BaF => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTc(), 
			CH.Bag => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTD(), 
			_ => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTd(), 
		};
	}

	[SpecialName]
	internal static Cg[] A()
	{
		if (BbF == null)
		{
			System.Array values = System.Enum.GetValues(typeof(Cg));
			BbF = new Cg[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				BbF[i] = (Cg)values.GetValue(i);
			}
		}
		return BbF;
	}

	[SpecialName]
	internal static CH[] a()
	{
		if (Bbf == null)
		{
			System.Array values = System.Enum.GetValues(typeof(CH));
			Bbf = new CH[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				Bbf[i] = (CH)values.GetValue(i);
			}
		}
		return Bbf;
	}

	internal static void A(float P_0, float P_1, float P_2)
	{
		if (BbG != null)
		{
			BbG.Dispose();
		}
		BbG = (Image)(object)O.A((Image)(object)CL.B(), 1f, 0f, 0f, 0f, 0f, P_0, P_1, P_2);
		if (Bbg != null)
		{
			Bbg.Dispose();
		}
		Bbg = (Image)(object)O.A((Image)(object)CL.c(), 1f, 0f, 0f, 0f, 0f, P_0, P_1, P_2);
	}

	internal static Image A(Cg P_0, CH P_1)
	{
		switch (P_0)
		{
		case Cg.BAG:
			return Bbg;
		default:
			if (!A(P_0) && !a(P_0, P_1) && !a(P_0))
			{
				return null;
			}
			goto case Cg.BAg;
		case Cg.BAg:
		case Cg.BAS:
			return BbG;
		}
	}

	internal static bool a(Cg P_0, CH P_1)
	{
		if (P_0 == Cg.BAR)
		{
			return P_1 == CH.BaM;
		}
		return false;
	}

	internal static bool A(Cg P_0)
	{
		if (P_0 != Cg.BAo && P_0 != Cg.BAP)
		{
			return P_0 == Cg.BAp;
		}
		return true;
	}

	internal static bool a(Cg P_0)
	{
		if (P_0 != Cg.BAs && P_0 != Cg.BAT)
		{
			return P_0 == Cg.BAt;
		}
		return true;
	}

	internal void B()
	{
		BBY.Clear();
		if (BbE is Setting && (BbE as Setting).aJ() && BBX.BSQ == Cg.BAM)
		{
			BBY.Add(BbE as Setting);
			return;
		}
		for (int i = 0; i < BbE.a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = BbE.a()[i];
			if (settingOrSpecialObject is Setting && settingOrSpecialObject.B().StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTE()))
			{
				BBY.Add(settingOrSpecialObject as Setting);
			}
		}
	}

	[SpecialName]
	internal List<Setting> b()
	{
		return BBY;
	}

	[SpecialName]
	internal List<int> C()
	{
		return BBy;
	}

	internal void A(int P_0)
	{
		BbD = P_0;
	}

	internal void A(string P_0)
	{
		Bbc = P_0;
	}

	internal string A(Framework P_0)
	{
		if (BbD != 0)
		{
			string text = ((SettingOrSpecialObject)P_0.A(BbD)).A(bz.aYv);
			if (string.IsNullOrEmpty(text))
			{
				text = ((SettingOrSpecialObject)P_0.A(BbD)).A(bz.aYu);
			}
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((SettingOrSpecialObject)P_0.A(BbD)).A(bz.aYt);
		}
		return Bbc;
	}

	internal void A(uint P_0, string P_1, bool P_2, ushort P_3, int P_4)
	{
		a a = new a(P_0, P_1, P_2, P_3, P_4);
		BBz.Add(a);
	}

	internal List<a> c()
	{
		return BBz;
	}

	internal List<a> D()
	{
		return BbA;
	}

	internal void A(uint P_0, string P_1, int P_2)
	{
		BBx.A(P_0, P_1, P_2);
	}

	internal B d()
	{
		return BBx;
	}

	internal void a(uint P_0, string P_1, int P_2)
	{
		BBX.A(P_0, P_1, P_2);
	}

	internal B E()
	{
		return BBX;
	}

	internal static Cg A(uint P_0)
	{
		return (Cg)((P_0 >> 24) & 0xFFu);
	}

	internal static CH a(uint P_0)
	{
		return (CH)((P_0 >> 16) & 0xFFu);
	}

	internal static byte B(uint P_0)
	{
		return (byte)((P_0 >> 8) & 0xFFu);
	}

	internal static ushort b(uint P_0)
	{
		return (ushort)(P_0 & 0xFFFFu);
	}

	internal static uint A(Cg P_0, CH P_1, byte P_2)
	{
		return (((uint)P_0 << 24) & 0xFF000000u) | (((uint)P_1 << 16) & 0xFF0000u) | ((uint)(P_2 << 8) & 0xFF00u);
	}

	internal static uint A(Cg P_0, CH P_1, ushort P_2)
	{
		return (((uint)P_0 << 24) & 0xFF000000u) | (((uint)P_1 << 16) & 0xFF0000u) | (P_2 & 0xFFFFu);
	}

	internal void e()
	{
		BbB.Clear();
		for (int i = 0; i < Bba.Count; i++)
		{
			A a = Bba[i];
			if (a.BSL == -1)
			{
				BbB.Add(a);
			}
		}
		BbA.Clear();
		for (int j = 0; j < BBz.Count; j++)
		{
			a a2 = BBz[j];
			if (a2.BSp == -1)
			{
				BbA.Add(a2);
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

	internal void a(int P_0)
	{
		for (int i = 0; i < Bba.Count; i++)
		{
			A a = Bba[i];
			if (a.BSL == P_0)
			{
				BbB.Add(a);
			}
		}
		for (int j = 0; j < BBz.Count; j++)
		{
			a a2 = BBz[j];
			if (a2.BSp == P_0)
			{
				BbA.Add(a2);
			}
		}
		if (BBX.BSV.ContainsKey(P_0))
		{
			BBX.BSQ = BBX.BSV[P_0];
		}
		if (BBX.BSv.ContainsKey(P_0))
		{
			BBX.BSq = BBX.BSv[P_0];
		}
		if (BBX.BSW.ContainsKey(P_0))
		{
			BBX.BSR = BBX.BSW[P_0];
		}
		if (BBX.BSw.ContainsKey(P_0))
		{
			BBX.BSr = BBX.BSw[P_0];
		}
		if (BBX.BSX.ContainsKey(P_0))
		{
			BBX.BSS = BBX.BSX[P_0];
		}
		if (BBx.BSV.ContainsKey(P_0))
		{
			BBx.BSQ = BBx.BSV[P_0];
		}
		if (BBx.BSv.ContainsKey(P_0))
		{
			BBx.BSq = BBx.BSv[P_0];
		}
		if (BBx.BSW.ContainsKey(P_0))
		{
			BBx.BSR = BBx.BSW[P_0];
		}
		if (BBx.BSw.ContainsKey(P_0))
		{
			BBx.BSr = BBx.BSw[P_0];
		}
		if (BBx.BSX.ContainsKey(P_0))
		{
			BBx.BSS = BBx.BSX[P_0];
		}
	}

	internal void A(ushort P_0, int P_1)
	{
		A a = new A(P_0, P_1);
		Bba.Add(a);
	}

	internal List<A> F()
	{
		return BbB;
	}

	internal static Ch A(ushort P_0)
	{
		return (Ch)((uint)(P_0 >> 8) & 0xFFu);
	}

	internal static CI a(ushort P_0)
	{
		return (CI)(P_0 & 0xFFu);
	}

	internal static void A(SettingOrSpecialObject P_0, bool P_1)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		List<SettingOrSpecialObject> val = new List<SettingOrSpecialObject>();
		val.Add(P_0);
		if (!P_1 && P_0.k().Count != 0)
		{
			Enumerator<int> enumerator = P_0.k().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					val.Add(P_0.A().a(current));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		Enumerator<SettingOrSpecialObject> enumerator2 = val.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Enumerator<SettingOrSpecialObject> enumerator3 = enumerator2.Current.a().GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						SettingOrSpecialObject current2 = enumerator3.Current;
						if (!(current2 is Dn))
						{
							continue;
						}
						Dn dn = current2 as Dn;
						Enumerator<SettingOrSpecialObject> enumerator4 = ((SettingOrSpecialObject)dn).a().GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								SettingOrSpecialObject current3 = enumerator4.Current;
								if (current3 is FilterOption)
								{
									(current3 as FilterOption).a(false);
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator4).Dispose();
						}
						enumerator4 = ((SettingOrSpecialObject)dn).a().GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								SettingOrSpecialObject current4 = enumerator4.Current;
								if (!(current4 is FilterOption) || !(current4 as FilterOption).a())
								{
									continue;
								}
								B b = current4.F().d();
								int num = 0;
								num = (int)((b.BSQ != Cg.BAM) ? A(b.BSQ, b.BSq, b.BSR) : A(b.BSQ, b.BSq, b.BSr));
								if (num == 0)
								{
									continue;
								}
								int num2 = dn.ax();
								if (num != num2)
								{
									dn.a(num, true);
									if (num2 == 0)
									{
										dn.A();
									}
									BM.b(((Setting)dn).A());
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator4).Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	internal static void A(Setting P_0, out HashSet<DataIdAndAttrId> P_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		P_1 = null;
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		List<Dn> val = new List<Dn>();
		Enumerator<FilterOption> enumerator = P_0.S().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				FilterOption current = enumerator.Current;
				if (!(current.D() is Dn))
				{
					continue;
				}
				Dn dn = current.D() as Dn;
				if (!current.a())
				{
					continue;
				}
				int num = dn.ax();
				B b = current.F().d();
				int num2 = 0;
				num2 = (int)((b.BSQ != Cg.BAM) ? A(b.BSQ, b.BSq, b.BSR) : A(b.BSQ, b.BSq, b.BSr));
				if (num2 == num)
				{
					continue;
				}
				if (num2 != 0)
				{
					if (((SettingOrSpecialObject)dn).l())
					{
						dn.a(num2, true);
						if (num == 0)
						{
							dn.A();
						}
						BM.b(((Setting)dn).A());
						if (P_1 == null)
						{
							P_1 = new HashSet<DataIdAndAttrId>();
						}
						P_1.Add(dn.C());
					}
				}
				else if (!val.Contains(dn))
				{
					val.Add(dn);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Enumerator<Dn> enumerator2 = val.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Dn current2 = enumerator2.Current;
				int num3 = current2.ax();
				if (num3 == 0)
				{
					continue;
				}
				Cg cg = A((uint)num3);
				CH cH = a((uint)num3);
				byte b2 = B((uint)num3);
				ushort num4 = PortFunction.b((uint)num3);
				SettingOrSpecialObject settingOrSpecialObject = A(((SettingOrSpecialObject)current2).A(), cg, cH, b2, num4);
				if (settingOrSpecialObject != null && !A(settingOrSpecialObject, current2))
				{
					current2.a(0, true);
					BM.b(((Setting)current2).A());
					if (P_1 == null)
					{
						P_1 = new HashSet<DataIdAndAttrId>();
					}
					P_1.Add(current2.C());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	internal static Setting A(SettingOrSpecialObject P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<SettingOrSpecialObject> enumerator = P_0.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (current is Setting)
				{
					Setting setting = current as Setting;
					if (!setting.am() && !setting.aJ() && (((SettingOrSpecialObject)setting).B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ff()) || ((SettingOrSpecialObject)setting).B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FG()) || ((SettingOrSpecialObject)setting).B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fg())))
					{
						return setting;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return null;
	}

	internal static void A(SettingOrSpecialObject P_0, bool P_1, bool P_2, List<Do> P_3, bool P_4 = false)
	{
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<SettingOrSpecialObject> enumerator;
		if (P_2 && !P_1)
		{
			SettingOrSpecialObject settingOrSpecialObject = null;
			if (P_0.A().aWx.Contains(P_0))
			{
				if (P_0.D() != null)
				{
					enumerator = P_0.D().a().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							SettingOrSpecialObject current = enumerator.Current;
							if (current is SpecialObject && current != P_0 && current.B() == P_0.B())
							{
								settingOrSpecialObject = current;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				else
				{
					enumerator = P_0.A().aWS.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							SettingOrSpecialObject current2 = enumerator.Current;
							if (current2 is SpecialObject && current2 != P_0 && current2.c() == P_0.c() && current2.B() == P_0.B())
							{
								settingOrSpecialObject = current2;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			if (settingOrSpecialObject != null)
			{
				enumerator = settingOrSpecialObject.a().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						SettingOrSpecialObject current3 = enumerator.Current;
						if (!(current3 is Setting))
						{
							continue;
						}
						Setting setting = current3 as Setting;
						if (!setting.aJ() && ((SettingOrSpecialObject)setting).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTe())
						{
							Do @do = setting as Do;
							if ((P_4 || !@do.am()) && !@do.al() && !@do.aN() && !@do.U() && @do.d(0).Count != 0)
							{
								P_3.Add(@do);
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}
		enumerator = P_0.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current4 = enumerator.Current;
				if (current4 is Do)
				{
					Do do2 = current4 as Do;
					if ((P_4 || !do2.am()) && !do2.al() && !do2.aN())
					{
						P_3.Add(do2);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (P_1 || P_0.k().Count == 0)
		{
			return;
		}
		Enumerator<int> enumerator2 = P_0.k().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				int current5 = enumerator2.Current;
				A(P_0.A().a(current5), true, P_2, P_3, P_4);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	internal static void A(SettingOrSpecialObject P_0, bool P_1, List<Dn> P_2, bool P_3 = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<SettingOrSpecialObject> enumerator = P_0.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (current is Dn)
				{
					Dn dn = current as Dn;
					if (P_3 || !dn.am())
					{
						P_2.Add(dn);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (P_1 || P_0.k().Count == 0)
		{
			return;
		}
		Enumerator<int> enumerator2 = P_0.k().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				int current2 = enumerator2.Current;
				A(P_0.A().a(current2), true, P_2, P_3);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	internal static void A(SettingOrSpecialObject P_0, bool P_1, List<Table> P_2, bool P_3)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < P_0.a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0.a()[i];
			if (settingOrSpecialObject is Dn)
			{
				A(settingOrSpecialObject as Dn, P_2, P_3);
			}
		}
		if (P_1 || P_0.k().Count == 0)
		{
			return;
		}
		Enumerator<int> enumerator = P_0.k().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				A(P_0.A().a(current), true, P_2, P_3);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static void A(Dn P_0, List<Setting> P_1, List<Table> P_2)
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		int num = P_0.ax();
		if (num == 0)
		{
			return;
		}
		Cg cg = A((uint)num);
		if (cg == Cg.BAM)
		{
			return;
		}
		CH cH = a((uint)num);
		byte b = B((uint)num);
		for (int i = 0; i < ((SettingOrSpecialObject)P_0).A().awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)P_0).A().awD[i];
			if (settingOrSpecialObject.F().E().BSQ != cg || settingOrSpecialObject.F().E().BSq != cH || settingOrSpecialObject.F().E().BSR != b)
			{
				continue;
			}
			for (int j = 0; j < settingOrSpecialObject.a().Count; j++)
			{
				SettingOrSpecialObject settingOrSpecialObject2 = settingOrSpecialObject.a()[j];
				if (!settingOrSpecialObject2.l())
				{
					continue;
				}
				if (settingOrSpecialObject2 is Table)
				{
					Table table = settingOrSpecialObject2 as Table;
					string text = ((SettingOrSpecialObject)table).B().Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay()).Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
						.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cb(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
						.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ca(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
						.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cz(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
						.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cy(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
						.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cx(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
						.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
						.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
						.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vB(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
					Enumerator<Table> enumerator = P_2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Table current = enumerator.Current;
							string text2 = ((SettingOrSpecialObject)current).B().Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay()).Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
								.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cb(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
								.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ca(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
								.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cz(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
								.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cy(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
								.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cx(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
								.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
								.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
								.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vB(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
							if (text == text2 || text.EndsWith(text2) || text2.EndsWith(text) || (table.TableDataSetting.d() != 0 && table.TableDataSetting.d() == current.TableDataSetting.d()))
							{
								table.CopyFromAnotherTable(current, markForWrite: true);
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				else
				{
					if (!(settingOrSpecialObject2 is Setting setting) || setting.b() || setting.am() || P_0.al() || P_0.aN() || setting.aN() || setting.av()[0] != 1 || setting.av()[1] != 1 || setting.av()[2] != 1 || ((!setting.aH() || !setting.ah() || !setting.aJ()) && setting.aJ()))
					{
						continue;
					}
					Enumerator<Setting> enumerator2 = P_1.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							Setting current2 = enumerator2.Current;
							if (settingOrSpecialObject2.B() == ((SettingOrSpecialObject)current2).B() || (setting.d() != 0 && setting.d() == current2.d()))
							{
								setting.a(current2.ax(), true);
								BM.b(setting.A());
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
			}
			break;
		}
	}

	internal static bool a(SettingOrSpecialObject P_0)
	{
		if (P_0 != null)
		{
			if (P_0.F().E().BSQ == Cg.BAB)
			{
				return P_0.F().E().BSq != CH.BAU;
			}
			return true;
		}
		return false;
	}

	internal static B A(Setting P_0, bool P_1)
	{
		if (((SettingOrSpecialObject)P_0).D() != null)
		{
			if (a(((SettingOrSpecialObject)P_0).D()) && (P_1 || !(P_0 is Table)))
			{
				return ((SettingOrSpecialObject)P_0).D().F().E();
			}
			if (P_1)
			{
				if (((SettingOrSpecialObject)P_0).D() is Table)
				{
					Table table = ((SettingOrSpecialObject)P_0).D() as Table;
					if (P_0 == table.TableDataSetting && a(((SettingOrSpecialObject)table).D()))
					{
						return ((SettingOrSpecialObject)table).D().F().E();
					}
				}
				else if (((SettingOrSpecialObject)P_0).D() is TableAxis)
				{
					Table table2 = ((SettingOrSpecialObject)(((SettingOrSpecialObject)P_0).D() as TableAxis)).D() as Table;
					if (a(((SettingOrSpecialObject)table2).D()))
					{
						return ((SettingOrSpecialObject)table2).D().F().E();
					}
				}
			}
		}
		return null;
	}

	internal static List<Setting> a(SettingOrSpecialObject P_0, bool P_1)
	{
		List<Setting> val = new List<Setting>();
		for (int i = 0; i < P_0.a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0.a()[i];
			if (settingOrSpecialObject is Setting setting && (settingOrSpecialObject.l() || !P_1) && !setting.b() && !setting.am() && setting.av()[0] == 1 && setting.av()[1] == 1 && setting.av()[2] == 1 && ((setting.aH() && setting.ah() && setting.aJ()) || !setting.aJ()))
			{
				val.Add(setting);
			}
		}
		return val;
	}

	internal static void A(int P_0, bool P_1, bool P_2, Framework P_3, List<Setting> P_4, bool P_5, bool P_6 = false)
	{
		if (P_0 == 0)
		{
			return;
		}
		Cg cg = A((uint)P_0);
		CH cH = a((uint)P_0);
		byte b = B((uint)P_0);
		for (int i = 0; i < P_3.awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_3.awD[i];
			if (settingOrSpecialObject.F().E().BSQ != cg || settingOrSpecialObject.F().E().BSq != cH || settingOrSpecialObject.F().E().BSR != b)
			{
				continue;
			}
			for (int j = 0; j < settingOrSpecialObject.a().Count; j++)
			{
				SettingOrSpecialObject settingOrSpecialObject2 = settingOrSpecialObject.a()[j];
				if (settingOrSpecialObject2 is Setting setting && (settingOrSpecialObject2.l() || !P_5) && !setting.b() && (P_6 || !setting.am()) && !P_1 && !P_2 && !setting.aN() && setting.av()[0] == 1 && setting.av()[1] == 1 && setting.av()[2] == 1 && ((setting.aH() && setting.ah() && setting.aJ()) || !setting.aJ()))
				{
					P_4.Add(setting);
				}
			}
		}
	}

	internal static void A(Dn P_0, List<Setting> P_1, bool P_2, bool P_3 = false)
	{
		A(P_0.ax(), P_0.al(), P_0.aN(), ((SettingOrSpecialObject)P_0).A(), P_1, P_2, P_3);
	}

	internal static List<Table> B(SettingOrSpecialObject P_0, bool P_1)
	{
		List<Table> val = new List<Table>();
		for (int i = 0; i < P_0.a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0.a()[i];
			if ((settingOrSpecialObject.l() || !P_1) && settingOrSpecialObject is Table)
			{
				val.Add(settingOrSpecialObject as Table);
			}
		}
		return val;
	}

	internal static void A(int P_0, Framework P_1, List<Table> P_2, bool P_3)
	{
		if (P_0 == 0)
		{
			return;
		}
		Cg cg = A((uint)P_0);
		CH cH = a((uint)P_0);
		byte b = B((uint)P_0);
		for (int i = 0; i < P_1.awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_1.awD[i];
			if (settingOrSpecialObject.F().E().BSQ == cg && settingOrSpecialObject.F().E().BSq == cH && settingOrSpecialObject.F().E().BSR == b)
			{
				P_2.AddRange((System.Collections.Generic.IEnumerable<Table>)B(settingOrSpecialObject, P_3));
			}
		}
	}

	internal static void A(Dn P_0, List<Table> P_1, bool P_2)
	{
		A(P_0.ax(), ((SettingOrSpecialObject)P_0).A(), P_1, P_2);
	}

	internal static void A(MenuNode P_0, SettingOrSpecialObject P_1)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		int num = -1;
		for (int i = 0; i < P_0.c().Count; i++)
		{
			if (P_0.c()[i].F())
			{
				P_0.c()[i].A(-1);
				P_0.c()[i].a(null);
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
		List<SettingOrSpecialObject> val = new List<SettingOrSpecialObject>();
		List<Dn> val2 = new List<Dn>();
		A(P_1, false, val2, true);
		for (int j = 0; j < val2.Count; j++)
		{
			Dn dn = val2[j];
			if (!((SettingOrSpecialObject)dn).l())
			{
				continue;
			}
			uint num2 = (uint)dn.ax();
			if (num2 != 0)
			{
				Cg cg = A(num2);
				CH cH = a(num2);
				byte b = B(num2);
				ushort num3 = PortFunction.b(num2);
				SettingOrSpecialObject settingOrSpecialObject = A(P_1.A(), cg, cH, b, num3);
				if (settingOrSpecialObject != null && settingOrSpecialObject.l())
				{
					val.Add(settingOrSpecialObject);
				}
			}
		}
		Enumerator<a> enumerator = P_1.F().D().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				a current = enumerator.Current;
				Cg bSl = current.BSl;
				CH bSM = current.BSM;
				byte bSm = current.BSm;
				ushort bSN = current.BSN;
				SettingOrSpecialObject settingOrSpecialObject2 = A(P_1.A(), bSl, bSM, bSm, bSN);
				if (settingOrSpecialObject2 != null && settingOrSpecialObject2.l())
				{
					val.Add(settingOrSpecialObject2);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		int num4 = 0;
		Enumerator<SettingOrSpecialObject> enumerator2 = val.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				SettingOrSpecialObject current2 = enumerator2.Current;
				for (int k = 0; k < current2.a().Count; k++)
				{
					SettingOrSpecialObject settingOrSpecialObject3 = current2.a()[k];
					if (settingOrSpecialObject3.l() && settingOrSpecialObject3 is Table)
					{
						if (num4 >= 20)
						{
							throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTF(), (object)P_1.A(bz.aYt), (object)20));
						}
						MenuNode menuNode = P_0.c()[num + num4];
						menuNode.A(settingOrSpecialObject3.r());
						menuNode.a(settingOrSpecialObject3.A(true));
						num4++;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	internal static SettingOrSpecialObject A(Framework P_0, Cg P_1, CH P_2, byte P_3, ushort P_4)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<SettingOrSpecialObject> enumerator = P_0.awD.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (P_1 == Cg.BAM)
				{
					if (current.F().E().BSQ == P_1 && current.F().E().BSq == P_2 && current.F().E().BSr == P_4)
					{
						return current;
					}
				}
				else if (current.F().E().BSQ == P_1 && current.F().E().BSq == P_2 && current.F().E().BSR == P_3)
				{
					return current;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return null;
	}

	internal static string B(SettingOrSpecialObject P_0)
	{
		if (P_0 != null)
		{
			if ((P_0 is Setting && (P_0 as Setting).aJ() && P_0.F().E().BSQ == Cg.BAM) || (P_0 is SpecialObject && a(P_0.F().E().BSQ)))
			{
				string text = P_0.H();
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + P_0.A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
				}
			}
			string text2 = P_0.A(bz.aYv);
			if (string.IsNullOrEmpty(text2))
			{
				text2 = P_0.A(bz.aYu);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				return text2;
			}
			return P_0.A(bz.aYT);
		}
		return null;
	}

	internal static int A(Framework P_0, bool P_1, Cg P_2, CH P_3, byte P_4, ushort P_5)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		Enumerator<Dn> enumerator = P_0.awd.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Dn current = enumerator.Current;
				if (!((SettingOrSpecialObject)current).l() && P_1)
				{
					continue;
				}
				int num2 = current.ax();
				Cg cg = A((uint)num2);
				CH cH = a((uint)num2);
				byte b = B((uint)num2);
				ushort num3 = PortFunction.b((uint)num2);
				bool flag = false;
				if (P_2 == Cg.BAM)
				{
					if (cg == P_2 && cH == P_3 && num3 == P_5)
					{
						flag = true;
					}
				}
				else if (cg == P_2 && cH == P_3 && b == P_4)
				{
					flag = true;
				}
				if (!flag)
				{
					continue;
				}
				bool flag2 = true;
				if (P_1)
				{
					int bbC = ((SettingOrSpecialObject)current).F().BbC;
					if (bbC != 0)
					{
						Setting setting = P_0.A(bbC);
						if (setting != null)
						{
							flag2 = setting.ax() == 1;
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
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static bool A(Dn P_0)
	{
		for (int i = 0; i < ((SettingOrSpecialObject)P_0).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)P_0).a()[i];
			if (!(settingOrSpecialObject is FilterOption))
			{
				continue;
			}
			FilterOption filterOption = settingOrSpecialObject as FilterOption;
			if (!filterOption.a())
			{
				continue;
			}
			List<FilterOption.A> val = filterOption.b();
			for (int j = 0; j < val.Count; j++)
			{
				if (val[j].bbE == Cg.BAM)
				{
					return true;
				}
			}
		}
		return false;
	}

	internal static bool A(SettingOrSpecialObject P_0, Dn P_1)
	{
		if (P_0 == null || !P_0.l())
		{
			return false;
		}
		Cg bSQ = P_0.F().E().BSQ;
		CH bSq = P_0.F().E().BSq;
		byte bSR = P_0.F().E().BSR;
		ushort bSr = P_0.F().E().BSr;
		for (int num = ((SettingOrSpecialObject)P_1).a().Count - 1; num >= 0; num--)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)P_1).a()[num];
			if (settingOrSpecialObject is FilterOption)
			{
				FilterOption filterOption = settingOrSpecialObject as FilterOption;
				if (filterOption.a())
				{
					List<FilterOption.A> val = filterOption.b();
					for (int num2 = val.Count - 1; num2 >= 0; num2--)
					{
						FilterOption.A a = val[num2];
						Cg bbE = a.bbE;
						CH bbe = a.bbe;
						byte bbF = a.bbF;
						ushort bbf = a.bbf;
						if ((bSQ != Cg.BAM) ? ((bSQ == bbE || bbE == Cg.BAB) && (bSq == bbe || bbe == CH.BAU) && (bSR == bbF || bbF == 255)) : ((bSQ == bbE || bbE == Cg.BAB) && (bSq == bbe || bbe == CH.BAU) && (bSr == bbf || bbf == 0)))
						{
							return a.bbG;
						}
					}
				}
			}
		}
		return false;
	}

	internal static void A(Framework P_0, bool P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<Dn> enumerator = P_0.awd.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Dn current = enumerator.Current;
				if (current.am())
				{
					continue;
				}
				int num = current.ax();
				if (num != 0)
				{
					Cg cg = A((uint)num);
					CH cH = a((uint)num);
					byte b = B((uint)num);
					ushort num2 = PortFunction.b((uint)num);
					if (!A(A(P_0, cg, cH, b, num2), current))
					{
						current.a(0, P_1);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static void A(Framework P_0, Cg P_1, Cg P_2)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 == Cg.BAB || P_2 == Cg.BAB)
		{
			return;
		}
		Enumerator<SettingOrSpecialObject> enumerator = P_0.awD.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				B b = enumerator.Current.F().E();
				if (b.BSQ != P_1)
				{
					continue;
				}
				List<Dn> val = A(P_0, b.BSQ, b.BSq, b.BSR, b.BSr, false);
				if (val == null || val.Count == 0)
				{
					continue;
				}
				Enumerator<Dn> enumerator2 = val.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Dn current = enumerator2.Current;
						uint num = (uint)current.ax();
						if (A(num) == P_1)
						{
							CH cH = a(num);
							byte b2 = B(num);
							uint num2 = A(P_2, cH, b2);
							List<Setting> val2 = new List<Setting>();
							A(current, val2, false);
							List<Table> val3 = new List<Table>();
							A(current, val3, false);
							current.a((int)num2, true);
							if (A(P_0, true, P_2, cH, b2, 0) == 1)
							{
								A(current, val2, val3);
							}
							BM.b(((Setting)current).A());
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static bool A(Framework P_0, Cg P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<SettingOrSpecialObject> enumerator = P_0.awD.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (current.l() && current.F().E().BSQ == P_1)
				{
					return true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return false;
	}

	internal static List<Dn> A(Framework P_0, Cg P_1, CH P_2, byte P_3, ushort P_4, bool P_5)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		List<Dn> val = null;
		List<WiringPin> val2 = null;
		if (P_5)
		{
			val2 = WiringPin.A(P_0, P_1, P_2, P_3, P_4);
		}
		for (int i = 0; i < P_0.awd.Count; i++)
		{
			Dn dn = P_0.awd[i];
			bool flag = ((SettingOrSpecialObject)dn).l();
			if (!flag)
			{
				continue;
			}
			int bbC = ((SettingOrSpecialObject)dn).F().BbC;
			if (bbC != 0)
			{
				Setting setting = P_0.A(bbC);
				if (setting != null)
				{
					flag = setting.ax() == 1;
				}
			}
			if (!flag)
			{
				continue;
			}
			int num = dn.ax();
			Cg cg = A((uint)num);
			CH cH = a((uint)num);
			byte b = B((uint)num);
			ushort num2 = PortFunction.b((uint)num);
			bool flag2 = false;
			if (P_1 != Cg.BAM && cg == P_1 && cH == P_2 && b == P_3)
			{
				flag2 = true;
			}
			else if (P_1 == Cg.BAM && cg == P_1 && cH == P_2 && num2 == P_4)
			{
				flag2 = true;
			}
			else if (P_5)
			{
				Enumerator<WiringPin> enumerator = WiringPin.A(P_0, cg, cH, b, num2).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						WiringPin current = enumerator.Current;
						if (val2.Contains(current))
						{
							flag2 = true;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (flag2)
			{
				if (val == null)
				{
					val = new List<Dn>();
				}
				val.Add(dn);
			}
		}
		return val;
	}

	internal static List<string> A(Framework P_0, Cg P_1, CH P_2, byte P_3, ushort P_4, bool P_5, List<bool> P_6)
	{
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		List<string> val = null;
		if (P_1 == Cg.BAg)
		{
			int num = 1;
			List<string> obj = new List<string>(num);
			CollectionsMarshal.SetCount<string>(obj, num);
			System.Span<string> span = CollectionsMarshal.AsSpan<string>(obj);
			int num2 = 0;
			span[num2] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSM();
			val = obj;
			P_6.Add(false);
			return val;
		}
		if (A(P_1))
		{
			int num2 = 1;
			List<string> obj2 = new List<string>(num2);
			CollectionsMarshal.SetCount<string>(obj2, num2);
			System.Span<string> span = CollectionsMarshal.AsSpan<string>(obj2);
			int num = 0;
			span[num] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMg();
			val = obj2;
			P_6.Add(false);
			return val;
		}
		if (P_1 == Cg.BAS)
		{
			int num = 1;
			List<string> obj3 = new List<string>(num);
			CollectionsMarshal.SetCount<string>(obj3, num);
			System.Span<string> span = CollectionsMarshal.AsSpan<string>(obj3);
			int num2 = 0;
			span[num2] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSm();
			val = obj3;
			P_6.Add(false);
			return val;
		}
		if (a(P_1))
		{
			int num2 = 1;
			List<string> obj4 = new List<string>(num2);
			CollectionsMarshal.SetCount<string>(obj4, num2);
			System.Span<string> span = CollectionsMarshal.AsSpan<string>(obj4);
			int num = 0;
			span[num] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMF();
			val = obj4;
			P_6.Add(false);
			return val;
		}
		List<WiringPin> val2 = WiringPin.A(P_0, P_1, P_2, P_3, P_4);
		for (int i = 0; i < P_0.awd.Count; i++)
		{
			Dn dn = P_0.awd[i];
			bool flag = ((SettingOrSpecialObject)dn).l();
			if (!flag)
			{
				continue;
			}
			int bbC = ((SettingOrSpecialObject)dn).F().BbC;
			if (bbC != 0)
			{
				Setting setting = P_0.A(bbC);
				if (setting != null)
				{
					flag = setting.ax() == 1;
				}
			}
			if (!flag)
			{
				continue;
			}
			int num3 = dn.ax();
			Cg cg = A((uint)num3);
			CH cH = a((uint)num3);
			byte b = B((uint)num3);
			ushort num4 = PortFunction.b((uint)num3);
			bool flag2 = false;
			if (P_1 != Cg.BAM && cg == P_1 && cH == P_2 && b == P_3)
			{
				flag2 = true;
			}
			else if (P_1 == Cg.BAM && cg == P_1 && cH == P_2 && num4 == P_4)
			{
				flag2 = true;
			}
			else if (P_5)
			{
				Enumerator<WiringPin> enumerator = WiringPin.A(P_0, cg, cH, b, num4).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						WiringPin current = enumerator.Current;
						if (val2.Contains(current))
						{
							flag2 = true;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (!flag2)
			{
				continue;
			}
			string text = ((SettingOrSpecialObject)dn).A(bz.aYv);
			if (string.IsNullOrEmpty(text))
			{
				text = ((SettingOrSpecialObject)dn).A(bz.aYu);
			}
			string text2 = (string.IsNullOrEmpty(text) ? ((SettingOrSpecialObject)dn).A(bz.aYt) : text);
			if (val == null)
			{
				val = new List<string>();
			}
			bool flag3 = false;
			Enumerator<SettingOrSpecialObject> enumerator2 = ((SettingOrSpecialObject)dn).a().GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					SettingOrSpecialObject current2 = enumerator2.Current;
					if (current2 is FilterOption)
					{
						FilterOption filterOption = current2 as FilterOption;
						if (filterOption.a() && filterOption.A())
						{
							flag3 = true;
							break;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			string text3 = ((SettingOrSpecialObject)dn).H();
			if (!string.IsNullOrWhiteSpace(text3))
			{
				text2 = text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
			if (((SettingOrSpecialObject)dn).C() != -1)
			{
				SettingOrSpecialObject settingOrSpecialObject = P_0.a(((SettingOrSpecialObject)dn).C());
				if (settingOrSpecialObject != null)
				{
					string text4 = settingOrSpecialObject.A(bz.aYt);
					if (string.IsNullOrEmpty(text4))
					{
						text4 = settingOrSpecialObject.A(bz.aYu);
					}
					if (string.IsNullOrEmpty(text4))
					{
						text4 = settingOrSpecialObject.A(bz.aYT);
					}
					string text5 = settingOrSpecialObject.H();
					if (!string.IsNullOrWhiteSpace(text5))
					{
						text4 = text5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					val.Add(text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTf() + text4);
					P_6.Add(flag3);
				}
				else
				{
					val.Add(text2);
					P_6.Add(flag3);
				}
			}
			else
			{
				val.Add(text2);
				P_6.Add(flag3);
			}
		}
		return val;
	}

	internal static a a(Framework P_0, Cg P_1, CH P_2, byte P_3, ushort P_4)
	{
		for (int i = 0; i < P_0.awE.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0.awE[i];
			if (!settingOrSpecialObject.l())
			{
				continue;
			}
			for (int j = 0; j < settingOrSpecialObject.F().D().Count; j++)
			{
				a a = settingOrSpecialObject.F().D()[j];
				Cg bSl = a.BSl;
				CH bSM = a.BSM;
				byte bSm = a.BSm;
				ushort bSN = a.BSN;
				if (P_1 == Cg.BAM)
				{
					if (bSl == P_1 && bSM == P_2 && bSN == P_4)
					{
						return a;
					}
				}
				else if (bSl == P_1 && bSM == P_2 && bSm == P_3)
				{
					return a;
				}
			}
		}
		return null;
	}

	internal static string B(Framework P_0, Cg P_1, CH P_2, byte P_3, ushort P_4)
	{
		a a = PortFunction.a(P_0, P_1, P_2, P_3, P_4);
		if (a != null)
		{
			if (P_1 == Cg.BAM)
			{
				return a.BSn;
			}
			return P_2 switch
			{
				CH.Baa => A(P_0, P_3 + 1, a.BSn), 
				CH.BaB => PortFunction.a(P_0, P_3 + 1, a.BSn), 
				_ => a.BSn, 
			};
		}
		return null;
	}

	internal static string A(Framework P_0, int P_1, string P_2)
	{
		Setting setting = P_0.A(93);
		Setting setting2 = P_0.A(94);
		Setting setting3 = P_0.A(95);
		Setting setting4 = P_0.A(101);
		if (setting != null && setting2 != null && setting3 != null && setting4 != null)
		{
			if ((!setting.O() && setting.P() != IllegalitySeverityLevel.Warning) || (!setting2.O() && setting2.P() != IllegalitySeverityLevel.Warning) || (!setting3.O() && setting3.P() != IllegalitySeverityLevel.Warning) || (!setting4.O() && setting4.P() != IllegalitySeverityLevel.Warning))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTG();
			}
			int num = setting4.ax();
			bool flag = false;
			if (bx.A(P_0.awZ))
			{
				Setting setting5 = P_0.A(12212);
				if (setting5 != null)
				{
					flag = setting5.ax() == 1;
				}
			}
			Setting[] array = new Setting[num];
			Setting[] array2 = new Setting[num];
			Setting[] array3 = new Setting[num];
			int[] array4 = new int[4];
			RuntimeHelpers.InitializeArray((System.Array)array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int[] array5 = array4;
			int[] array6 = new int[4];
			RuntimeHelpers.InitializeArray((System.Array)array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int[] array7 = array6;
			int[] array8 = new int[4];
			RuntimeHelpers.InitializeArray((System.Array)array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int[] array9 = array8;
			for (int i = 0; i < num; i++)
			{
				Setting setting6 = P_0.A(array5[i]);
				if (setting6 != null)
				{
					array[i] = setting6;
					Setting setting7 = P_0.A(array7[i]);
					if (setting7 != null)
					{
						array2[i] = setting7;
						Setting setting8 = P_0.A(array9[i]);
						if (setting8 != null)
						{
							array3[i] = setting8;
						}
						else if (flag)
						{
							return P_2;
						}
						continue;
					}
					return P_2;
				}
				return P_2;
			}
			bool flag2 = true;
			for (int j = 0; j < num; j++)
			{
				if (!array[j].O() && array[j].P() != IllegalitySeverityLevel.Warning)
				{
					flag2 = false;
					break;
				}
				if (flag)
				{
					if (!array3[j].O() && array3[j].P() != IllegalitySeverityLevel.Warning)
					{
						flag2 = false;
						break;
					}
				}
				else if (!array2[j].O() && array2[j].P() != IllegalitySeverityLevel.Warning)
				{
					flag2 = false;
					break;
				}
			}
			if (!flag2)
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTG();
			}
			int num2 = setting.ax();
			string text = ((num2 != 0 && num2 != 1) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTH() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTg());
			int num3 = 0;
			for (int k = 0; k < num; k++)
			{
				int num4 = array[k].ax();
				if (P_1 <= num3 + num4)
				{
					int num5 = k + 1;
					string text2 = string.Empty;
					if (num != 1)
					{
						text2 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTh() + num5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh();
					}
					if (flag)
					{
						switch (array3[k].ax())
						{
						case 0:
							return string.Concat(new string[5]
							{
								text2,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTI(),
								text,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
								(P_1 - num3).ToString()
							});
						case 1:
							return text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTi() + (P_1 - num3);
						case 2:
						{
							int num6 = setting2.ax();
							int num7 = P_1 - 1 - num3;
							int num8 = setting3.m(num7);
							int num9 = (num7 + num6 / 2) % num6;
							int num10 = setting3.m(num9);
							return string.Concat(new string[7]
							{
								text2,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTI(),
								text,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTJ(),
								num8.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTj(),
								num10.ToString()
							});
						}
						default:
							return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTG();
						}
					}
					int num11 = array2[k].ax();
					int num12 = setting2.ax();
					switch (num11)
					{
					case 0:
					case 4:
					{
						if (num4 == num12)
						{
							return string.Concat(new string[5]
							{
								text2,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTI(),
								text,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
								(P_1 - num3).ToString()
							});
						}
						int num17 = P_1 - 1 - num3;
						int num18 = num4 / num12;
						return string.Concat(new string[5]
						{
							text2,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTI(),
							text,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
							(num17 / num18 + 1).ToString()
						});
					}
					case 1:
						if (num4 == num12 / 2)
						{
							int num13 = P_1 - 1 - num3;
							int num14 = setting3.m(num13);
							int num15 = (num13 + num12 / 2) % num12;
							int num16 = setting3.m(num15);
							text2 = string.Concat(new string[7]
							{
								text2,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTI(),
								text,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTJ(),
								num14.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTj(),
								num16.ToString()
							});
						}
						else if (num4 == num12)
						{
							text2 = string.Concat(new string[5]
							{
								text2,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTI(),
								text,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
								(P_1 - num3).ToString()
							});
						}
						return text2;
					case 2:
					case 3:
						return text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTi() + (P_1 - num3);
					default:
						return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTG();
					}
				}
				num3 += num4;
			}
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTG();
		}
		return P_2;
	}

	internal static string A(Framework P_0, int P_1, int P_2, string P_3)
	{
		Setting setting = P_0.A(93);
		Setting setting2 = P_0.A(94);
		Setting setting3 = P_0.A(95);
		Setting setting4 = P_0.A(101);
		if (setting != null && setting2 != null && setting3 != null && setting4 != null)
		{
			if ((!setting.O() && setting.P() != IllegalitySeverityLevel.Warning) || (!setting2.O() && setting2.P() != IllegalitySeverityLevel.Warning) || (!setting3.O() && setting3.P() != IllegalitySeverityLevel.Warning) || (!setting4.O() && setting4.P() != IllegalitySeverityLevel.Warning))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTK();
			}
			int num = setting4.ax();
			bool flag = false;
			if (bx.A(P_0.awZ))
			{
				Setting setting5 = P_0.A(12212);
				if (setting5 != null)
				{
					flag = setting5.ax() == 1;
				}
			}
			int[] array = new int[4];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int[] array2 = array;
			int[] array3 = new int[4];
			RuntimeHelpers.InitializeArray((System.Array)array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int[] array4 = array3;
			int[] array5 = new int[4];
			RuntimeHelpers.InitializeArray((System.Array)array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int[] array6 = array5;
			Setting setting6 = P_0.A(array2[P_1]);
			if (setting6 == null)
			{
				return P_3;
			}
			Setting setting7 = P_0.A(array4[P_1]);
			if (setting7 == null)
			{
				return P_3;
			}
			Setting setting8 = P_0.A(array6[P_1]);
			if (setting8 == null && flag)
			{
				return P_3;
			}
			if (!setting6.O() && setting6.P() != IllegalitySeverityLevel.Warning)
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTK();
			}
			if (flag)
			{
				if (!setting8.O() && setting8.P() != IllegalitySeverityLevel.Warning)
				{
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTK();
				}
			}
			else if (!setting7.O() && setting7.P() != IllegalitySeverityLevel.Warning)
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTK();
			}
			int num2 = setting6.ax();
			int num3 = setting.ax();
			string text = ((num3 != 0 && num3 != 1) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTH() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTg());
			int num4 = P_1 + 1;
			string text2 = string.Empty;
			if (num != 1)
			{
				text2 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTh() + num4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh();
			}
			if (flag)
			{
				switch (setting8.ax())
				{
				case 0:
					return text2 + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + (P_2 + 1);
				case 1:
					return text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTk() + (P_2 + 1);
				case 2:
				{
					int num5 = setting2.ax();
					int num6 = setting3.m(P_2);
					int num7 = (P_2 + num5 / 2) % num5;
					int num8 = setting3.m(num7);
					return string.Concat(new string[6]
					{
						text2,
						text,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTJ(),
						num6.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTj(),
						num8.ToString()
					});
				}
				default:
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTK();
				}
			}
			int num9 = setting7.ax();
			int num10 = setting2.ax();
			switch (num9)
			{
			case 0:
			case 4:
			{
				if (num2 == num10)
				{
					return text2 + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + (P_2 + 1);
				}
				int num14 = num2 / num10;
				return text2 + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + (P_2 / num14 + 1);
			}
			case 1:
				if (num2 == num10 / 2)
				{
					int num11 = setting3.m(P_2);
					int num12 = (P_2 + num10 / 2) % num10;
					int num13 = setting3.m(num12);
					text2 = string.Concat(new string[6]
					{
						text2,
						text,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTJ(),
						num11.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTj(),
						num13.ToString()
					});
				}
				else if (num2 == num10)
				{
					text2 = text2 + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + (P_2 + 1);
				}
				return text2;
			case 2:
			case 3:
				return text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTk() + (P_2 + 1);
			default:
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTK();
			}
		}
		return P_3;
	}

	internal static string a(Framework P_0, int P_1, string P_2)
	{
		Setting setting = P_0.A(93);
		Setting setting2 = P_0.A(94);
		Setting setting3 = P_0.A(95);
		Setting setting4 = P_0.A(98);
		if (setting != null && setting2 != null && setting3 != null && setting4 != null)
		{
			if ((!setting.O() && setting.P() != IllegalitySeverityLevel.Warning) || (!setting2.O() && setting2.P() != IllegalitySeverityLevel.Warning) || (!setting3.O() && setting3.P() != IllegalitySeverityLevel.Warning) || (!setting4.O() && setting4.P() != IllegalitySeverityLevel.Warning))
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTL();
			}
			switch (setting.ax())
			{
			case 0:
			case 1:
			{
				int num6 = setting2.ax();
				switch (setting4.ax())
				{
				case 0:
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTl() + P_1;
				case 1:
				{
					int num7 = P_1 - 1;
					int num8 = setting3.m(num7);
					int num9 = (num7 + num6 / 2) % num6;
					int num10 = setting3.m(num9);
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTM() + num8 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTj() + num10;
				}
				case 2:
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTm();
				case 3:
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTN() + P_1;
				case 4:
					return P_2;
				default:
					return P_2;
				}
			}
			case 2:
			{
				int num = setting2.ax();
				switch (setting4.ax())
				{
				case 0:
					if (P_1 <= num)
					{
						return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTn() + P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTO();
					}
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTn() + (P_1 - num) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTo();
				case 1:
					if (P_1 <= num / 2)
					{
						int num2 = P_1 - 1;
						int num3 = setting3.m(num2);
						int num4 = (num2 + num / 2) % num;
						int num5 = setting3.m(num4);
						return string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTP(),
							num3.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTj(),
							num5.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTO()
						});
					}
					if (P_1 > num)
					{
						return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTn() + (P_1 - num) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTo();
					}
					return P_2;
				case 2:
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTm();
				case 3:
					return P_2;
				case 4:
					return P_2;
				default:
					return P_2;
				}
			}
			default:
				return P_2;
			}
		}
		return P_2;
	}

	internal static bool A(SettingOrSpecialObject P_0, Dn P_1, a P_2)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.F().F().Count == 0 || (P_1 != null && ((SettingOrSpecialObject)P_1).F().F().Count == 0) || (P_2 != null && !P_2.BSO))
		{
			return true;
		}
		Enumerator<A> enumerator = P_0.F().F().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				if (P_1 != null)
				{
					Enumerator<A> enumerator2 = ((SettingOrSpecialObject)P_1).F().F().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							A current2 = enumerator2.Current;
							if (current.BSK == current2.BSK && current.BSk == current2.BSk)
							{
								return true;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				else if (P_2 != null && current.BSK == P_2.BSo && current.BSk == P_2.BSP)
				{
					return true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return false;
	}

	internal static bool A(Setting P_0)
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		if (((SettingOrSpecialObject)P_0).F().F().Count == 0 || ((SettingOrSpecialObject)P_0).D() == null || ((SettingOrSpecialObject)P_0).D() is Setting || (((SettingOrSpecialObject)P_0).D().F().E()
			.BSQ == Cg.BAB && ((SettingOrSpecialObject)P_0).D().F().E()
			.BSq == CH.BAU))
		{
			return true;
		}
		B b = ((SettingOrSpecialObject)P_0).D().F().E();
		List<Dn> val = A(((SettingOrSpecialObject)P_0).A(), b.BSQ, b.BSq, b.BSR, b.BSr, false);
		if (val == null || val.Count == 0)
		{
			a a = PortFunction.a(((SettingOrSpecialObject)P_0).A(), b.BSQ, b.BSq, b.BSR, b.BSr);
			if (a == null || !a.BSO)
			{
				return true;
			}
			Enumerator<A> enumerator = ((SettingOrSpecialObject)P_0).F().F().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					A current = enumerator.Current;
					if (current.BSK == a.BSo && current.BSk == a.BSP)
					{
						return true;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return false;
		}
		Enumerator<Dn> enumerator2 = val.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Dn current2 = enumerator2.Current;
				if (((SettingOrSpecialObject)current2).F().F().Count == 0)
				{
					return true;
				}
				Enumerator<A> enumerator = ((SettingOrSpecialObject)P_0).F().F().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						A current3 = enumerator.Current;
						Enumerator<A> enumerator3 = ((SettingOrSpecialObject)current2).F().F().GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								A current4 = enumerator3.Current;
								if (current3.BSK == current4.BSK && current3.BSk == current4.BSk)
								{
									return true;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator3).Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		return false;
	}
}
