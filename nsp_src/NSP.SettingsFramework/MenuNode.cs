using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using b;

namespace NSP.SettingsFramework;

public class MenuNode
{
	private List<MenuNode> aXq = new List<MenuNode>();

	private string aXR;

	private bool aXr;

	private bool aXS;

	private bool aXs = true;

	private bool aXT;

	private int aXt = -1;

	private int aXU = -1;

	private bool aXu;

	private bool aXV;

	private bool aXv;

	private bool aXW;

	private int aXw = -1;

	private int aXX = -1;

	private int aXx = -1;

	private bool aXY;

	private bool aXy;

	private string aXZ;

	private int aXz;

	private int axA = -1;

	private int axa;

	private string axB;

	private string axb;

	private string axC;

	private string axc;

	private string axD;

	private List<string> axd = new List<string>();

	private int axE = -1;

	private bool axe;

	private bool axF;

	private bool axf;

	private bool axG = true;

	private bool axg = true;

	private bool axH;

	private bool axh = true;

	private bool axI;

	private string axi;

	private CO axJ;

	private int axj;

	private bool axK;

	private MenuNode axk;

	private string axL;

	private HashSet<DataIdAndAttrId> axl = new HashSet<DataIdAndAttrId>();

	private HashSet<DataIdAndAttrId> axM = new HashSet<DataIdAndAttrId>();

	private List<int> axm = new List<int>();

	private Framework axN;

	private bu axn;

	private int axO;

	private bool axo = true;

	private int axP = -1;

	private List<ModifyOnChange> axp = new List<ModifyOnChange>();

	[CompilerGenerated]
	private readonly Ck axQ;

	[SpecialName]
	[CompilerGenerated]
	internal Ck A()
	{
		return axQ;
	}

	internal MenuNode(Framework P_0, bu P_1, MenuNode P_2, bool P_3, bool P_4, string P_5)
	{
		axN = P_0;
		axn = P_1;
		axk = P_2;
		aXr = P_3;
		aXS = P_4;
		aXZ = P_5;
		axQ = new Ck(P_0);
	}

	public virtual string ToString()
	{
		if (J())
		{
			return string.Concat(new string[9]
			{
				aXR,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMX(),
				aXt.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMx(),
				aXU.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY(),
				aXq.Count.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMy(),
				aXu ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMz() : (aXV ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMZ() : string.Empty)
			});
		}
		return string.Concat(new string[5]
		{
			aXR,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY(),
			aXq.Count.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMy(),
			aXu ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMz() : (aXV ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMZ() : string.Empty)
		});
	}

	[SpecialName]
	internal Framework a()
	{
		return axN;
	}

	[SpecialName]
	internal bu B()
	{
		return axn;
	}

	[SpecialName]
	internal int b()
	{
		return aXz;
	}

	[SpecialName]
	internal void A(int P_0)
	{
		aXz = P_0;
	}

	[SpecialName]
	internal MenuNode C()
	{
		return axk;
	}

	[SpecialName]
	internal List<MenuNode> c()
	{
		return aXq;
	}

	internal bool D()
	{
		return aXr;
	}

	[SpecialName]
	internal string d()
	{
		return axB;
	}

	[SpecialName]
	internal void A(string P_0)
	{
		axB = P_0;
	}

	[SpecialName]
	internal string E()
	{
		if (aXR == null)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
		}
		if (axN != null)
		{
			bool flag = true;
			for (int i = 0; i < aXR.Length; i++)
			{
				if (aXR[i] < '0' || aXR[i] > '9')
				{
					flag = false;
					break;
				}
			}
			if (flag && aXR != string.Empty)
			{
				int num = int.Parse(aXR);
				if (num != 0 && num == aXz)
				{
					SettingOrSpecialObject settingOrSpecialObject = axN.a(num);
					aXR = settingOrSpecialObject.A(true);
				}
			}
		}
		return aXR;
	}

	[SpecialName]
	internal void a(string P_0)
	{
		aXR = P_0;
	}

	[SpecialName]
	internal int e()
	{
		return axj;
	}

	[SpecialName]
	internal void a(int P_0)
	{
		axj = P_0;
	}

	[SpecialName]
	internal bool F()
	{
		return axK;
	}

	[SpecialName]
	internal void A(bool P_0)
	{
		axK = P_0;
	}

	[SpecialName]
	internal bool f()
	{
		return aXS;
	}

	[SpecialName]
	internal bool G()
	{
		return aXT;
	}

	[SpecialName]
	internal void a(bool P_0)
	{
		aXT = P_0;
	}

	[SpecialName]
	internal string g()
	{
		return aXZ;
	}

	[SpecialName]
	internal int H()
	{
		return axA;
	}

	[SpecialName]
	internal void B(int P_0)
	{
		axA = P_0;
	}

	[SpecialName]
	internal int h()
	{
		return axa;
	}

	[SpecialName]
	internal void b(int P_0)
	{
		axa = P_0;
	}

	[SpecialName]
	internal int I()
	{
		return aXt;
	}

	[SpecialName]
	internal void C(int P_0)
	{
		aXt = P_0;
	}

	[SpecialName]
	internal int i()
	{
		return aXU;
	}

	[SpecialName]
	internal void c(int P_0)
	{
		aXU = P_0;
	}

	internal bool J()
	{
		if (aXt != -1)
		{
			return aXU != -1;
		}
		return false;
	}

	[SpecialName]
	internal bool j()
	{
		return aXu;
	}

	[SpecialName]
	internal void B(bool P_0)
	{
		aXu = P_0;
	}

	[SpecialName]
	internal bool K()
	{
		return aXV;
	}

	[SpecialName]
	internal void b(bool P_0)
	{
		aXV = P_0;
	}

	[SpecialName]
	internal bool k()
	{
		return aXv;
	}

	[SpecialName]
	internal void C(bool P_0)
	{
		aXv = P_0;
	}

	[SpecialName]
	internal bool L()
	{
		return aXW;
	}

	[SpecialName]
	internal void c(bool P_0)
	{
		aXW = P_0;
	}

	[SpecialName]
	internal bool l()
	{
		return aXw != -1;
	}

	[SpecialName]
	internal bool M()
	{
		return aXX != -1;
	}

	[SpecialName]
	internal int m()
	{
		return aXw;
	}

	[SpecialName]
	internal void D(int P_0)
	{
		aXw = P_0;
	}

	[SpecialName]
	internal int N()
	{
		return aXX;
	}

	[SpecialName]
	internal void d(int P_0)
	{
		aXX = P_0;
	}

	[SpecialName]
	internal bool n()
	{
		return this == axN.awS;
	}

	[SpecialName]
	internal bool O()
	{
		return this == axN.awR;
	}

	[SpecialName]
	internal bool o()
	{
		return aXx != -1;
	}

	[SpecialName]
	internal int P()
	{
		return aXx;
	}

	[SpecialName]
	internal void E(int P_0)
	{
		aXx = P_0;
	}

	[SpecialName]
	internal string p()
	{
		return axL;
	}

	[SpecialName]
	internal void B(string P_0)
	{
		axL = P_0;
	}

	[SpecialName]
	internal bool Q()
	{
		return aXs;
	}

	[SpecialName]
	internal void D(bool P_0)
	{
		aXs = P_0;
	}

	[SpecialName]
	internal bool q()
	{
		return aXY;
	}

	[SpecialName]
	internal void d(bool P_0)
	{
		aXY = P_0;
	}

	[SpecialName]
	internal bool R()
	{
		return aXy;
	}

	[SpecialName]
	internal void E(bool P_0)
	{
		aXy = P_0;
	}

	[SpecialName]
	internal int r()
	{
		return axO;
	}

	[SpecialName]
	internal void e(int P_0)
	{
		axO = P_0;
	}

	[SpecialName]
	internal bool S()
	{
		return axo;
	}

	[SpecialName]
	internal void e(bool P_0)
	{
		axo = P_0;
	}

	[SpecialName]
	internal int s()
	{
		return axP;
	}

	[SpecialName]
	internal void F(int P_0)
	{
		axP = P_0;
	}

	[SpecialName]
	internal string T()
	{
		return axb;
	}

	[SpecialName]
	internal void b(string P_0)
	{
		axb = P_0;
	}

	[SpecialName]
	internal string t()
	{
		return axC;
	}

	[SpecialName]
	internal void C(string P_0)
	{
		axC = P_0;
	}

	[SpecialName]
	internal string U()
	{
		return axc;
	}

	[SpecialName]
	internal void c(string P_0)
	{
		axc = P_0;
	}

	[SpecialName]
	internal string u()
	{
		return axD;
	}

	[SpecialName]
	internal void D(string P_0)
	{
		axD = P_0;
	}

	[SpecialName]
	internal List<string> V()
	{
		return axd;
	}

	[SpecialName]
	internal string v()
	{
		return axi;
	}

	[SpecialName]
	internal void d(string P_0)
	{
		axi = P_0;
	}

	[SpecialName]
	internal int W()
	{
		return axE;
	}

	[SpecialName]
	internal void f(int P_0)
	{
		axE = P_0;
	}

	[SpecialName]
	internal bool w()
	{
		return axe;
	}

	[SpecialName]
	internal void F(bool P_0)
	{
		axe = P_0;
	}

	[SpecialName]
	internal bool X()
	{
		return axF;
	}

	[SpecialName]
	internal void f(bool P_0)
	{
		axF = P_0;
	}

	[SpecialName]
	internal bool x()
	{
		return axE != -1;
	}

	[SpecialName]
	internal CO Y()
	{
		return axJ;
	}

	internal void y()
	{
		lock (BM.qb)
		{
			axJ = null;
			if (!x())
			{
				return;
			}
			Setting setting = axN.A(axE);
			if (setting != null)
			{
				string text = global::A.n.A(setting.aY());
				if (BM.qB.ContainsKey(text))
				{
					axJ = BM.qB[text];
				}
			}
		}
	}

	internal bool Z()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (axJ != null && axJ.BcF != null)
		{
			HashSet<DataIdAndAttrId> val = A(this, false);
			Enumerator<DataIdAndAttrId, byte[]> enumerator = axJ.BcF.Bcc.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataIdAndAttrId current = enumerator.Current;
					val.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<DataIdAndAttrId> enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					DataIdAndAttrId current2 = enumerator2.Current;
					Setting setting = axN.A(current2);
					if (setting != null && !setting.E() && !setting.am() && !setting.aJ())
					{
						int[] array = axJ.BcF.a(setting);
						if (array != null && !setting.a(array))
						{
							axI = true;
							return true;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}
		axI = false;
		return false;
	}

	internal MenuNode A(Setting P_0)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MenuNode menuNode = this;
		bool flag = false;
		do
		{
			if (menuNode.x() && menuNode.Y() != null && menuNode.Y().BcF != null && menuNode.Y().BcF.a(P_0) != null)
			{
				return menuNode;
			}
			if (menuNode.C() != null)
			{
				menuNode = menuNode.C();
			}
			else
			{
				flag = true;
			}
		}
		while (!flag);
		Enumerator<int, MenuNode> enumerator = axN.awX.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				MenuNode current = enumerator.Current;
				if (current.Y() != null && current.Y().BcF != null && current.Y().BcF.Bcc.ContainsKey(P_0.C()))
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

	[SpecialName]
	internal bool z()
	{
		return axg;
	}

	[SpecialName]
	internal void G(bool P_0)
	{
		axg = P_0;
	}

	[SpecialName]
	internal bool aA()
	{
		return axf;
	}

	[SpecialName]
	internal void g(bool P_0)
	{
		axf = P_0;
	}

	[SpecialName]
	internal bool aa()
	{
		return axG;
	}

	[SpecialName]
	internal void H(bool P_0)
	{
		axG = P_0;
	}

	[SpecialName]
	internal bool aB()
	{
		return axH;
	}

	[SpecialName]
	internal void h(bool P_0)
	{
		axH = P_0;
		if (axH)
		{
			axg = false;
		}
	}

	[SpecialName]
	internal bool ab()
	{
		return axh;
	}

	[SpecialName]
	internal void I(bool P_0)
	{
		axh = P_0;
	}

	[SpecialName]
	internal bool aC()
	{
		return axI;
	}

	[SpecialName]
	internal void i(bool P_0)
	{
		axI = P_0;
	}

	internal void A(ModifyOnChange P_0)
	{
		axp.Add(P_0);
	}

	[SpecialName]
	internal List<ModifyOnChange> ac()
	{
		return axp;
	}

	internal bool A(out Setting P_0)
	{
		P_0 = null;
		bool result = false;
		if (axa != 0)
		{
			P_0 = axN.A(axa);
			result = ((axa != 10195) ? (P_0 != null && P_0.ax() != 1) : (P_0 != null && P_0.ax() == 0));
		}
		return result;
	}

	internal void aD()
	{
		for (int i = 0; i < aXq.Count; i++)
		{
			aXq[i].aD();
		}
		A().E();
	}

	internal string A(bool P_0, bool P_1)
	{
		if (axn != null)
		{
			return E();
		}
		string text = string.Empty;
		List<MenuNode> val = new List<MenuNode>();
		val.Add(this);
		MenuNode menuNode = this;
		bool flag = false;
		do
		{
			if (menuNode.C() != null)
			{
				val.Insert(0, menuNode.C());
				menuNode = menuNode.C();
			}
			else
			{
				flag = true;
			}
		}
		while (!flag);
		for (int i = 0; i < val.Count; i++)
		{
			if (i != 0 || P_0)
			{
				MenuNode menuNode2 = val[i];
				if (text != string.Empty)
				{
					text = ((!P_1) ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh()) : (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()));
				}
				text += menuNode2.E();
			}
		}
		return text;
	}

	internal bool J(bool P_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = j(false).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = axN.A(current);
				if (setting != null && (((SettingOrSpecialObject)setting).l() || !P_0) && ((!setting.al() && !setting.am() && !setting.aN()) || axN.awX.ContainsKey(setting.A())))
				{
					return false;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return true;
	}

	internal bool ad()
	{
		if (!string.IsNullOrEmpty(d()) && axN.awn.ContainsKey(d()))
		{
			return axN.awn[d()].G();
		}
		return false;
	}

	internal static bool A(MenuNode P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.ad())
		{
			return true;
		}
		Enumerator<MenuNode> enumerator = P_0.c().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				if (A(enumerator.Current))
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

	[SpecialName]
	internal List<int> aE()
	{
		return axm;
	}

	internal HashSet<DataIdAndAttrId> j(bool P_0)
	{
		if (P_0)
		{
			return axM;
		}
		return axl;
	}

	internal static HashSet<DataIdAndAttrId> A(MenuNode P_0, bool P_1 = false)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		val.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)P_0.j(false));
		if (P_1)
		{
			Enumerator<int> enumerator = P_0.aE().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					val.Add(new DataIdAndAttrId(current));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		Enumerator<MenuNode> enumerator2 = P_0.c().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				HashSet<DataIdAndAttrId> val2 = A(enumerator2.Current, P_1);
				val.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)val2);
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	internal static MenuNode A(List<MenuNode> P_0, DataIdAndAttrId P_1)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			MenuNode menuNode = P_0[i];
			if (menuNode != null && menuNode.j(false).Contains(P_1))
			{
				return menuNode;
			}
			MenuNode menuNode2 = A(P_0[i].c(), P_1);
			if (menuNode2 != null)
			{
				return menuNode2;
			}
		}
		return null;
	}

	internal void ae()
	{
		axl.Clear();
		axM.Clear();
		if (this == BM.qA)
		{
			axl.Add(new DataIdAndAttrId(1501));
			axM.Add(new DataIdAndAttrId(1501));
			return;
		}
		if (axa != 0)
		{
			axl.Add(new DataIdAndAttrId(axa));
			axM.Add(new DataIdAndAttrId(axa));
		}
		if (axN == null)
		{
			return;
		}
		SettingOrSpecialObject settingOrSpecialObject = axN.a(aXz);
		SettingOrSpecialObject settingOrSpecialObject2 = axN.a(axA);
		if (settingOrSpecialObject2 != null)
		{
			List<Do> val = new List<Do>();
			PortFunction.A(settingOrSpecialObject2, false, true, val, true);
			for (int i = 0; i < val.Count; i++)
			{
				Do @do = val[i];
				axl.Add(@do.C());
				axM.Add(@do.C());
			}
			List<Dn> val2 = new List<Dn>();
			PortFunction.A(settingOrSpecialObject2, false, val2, true);
			for (int j = 0; j < val2.Count; j++)
			{
				Dn dn = val2[j];
				axl.Add(dn.C());
				axM.Add(dn.C());
				List<Setting> val3 = new List<Setting>();
				PortFunction.A(dn, val3, false, true);
				for (int k = 0; k < val3.Count; k++)
				{
					Setting setting = val3[k];
					axl.Add(setting.C());
					axM.Add(setting.C());
				}
			}
			List<Table> val4 = new List<Table>();
			PortFunction.A(settingOrSpecialObject2, false, val4, false);
			for (int l = 0; l < val4.Count; l++)
			{
				Table table = val4[l];
				HashSet<DataIdAndAttrId> idsContained = table.GetIdsContained();
				axl.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)idsContained);
				HashSet<DataIdAndAttrId> idsContainedForShowingDiffs = table.GetIdsContainedForShowingDiffs();
				axM.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)idsContainedForShowingDiffs);
			}
			return;
		}
		if (settingOrSpecialObject != null)
		{
			CG cG = settingOrSpecialObject.e();
			if (cG != null)
			{
				HashSet<DataIdAndAttrId> idsContained2 = cG.GetIdsContained();
				axl.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)idsContained2);
				HashSet<DataIdAndAttrId> idsContainedForShowingDiffs2 = cG.GetIdsContainedForShowingDiffs();
				axM.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)idsContainedForShowingDiffs2);
			}
			else
			{
				if (settingOrSpecialObject.a().Count == 0)
				{
					return;
				}
				for (int m = 0; m < settingOrSpecialObject.a().Count; m++)
				{
					SettingOrSpecialObject settingOrSpecialObject3 = settingOrSpecialObject.a()[m];
					if (settingOrSpecialObject3 is Setting)
					{
						DataIdAndAttrId dataIdAndAttrId = (settingOrSpecialObject3 as Setting).C();
						axM.Add(dataIdAndAttrId);
						axl.Add(dataIdAndAttrId);
					}
				}
			}
			return;
		}
		for (int n = 0; n < aXq.Count; n++)
		{
			MenuNode menuNode = aXq[n];
			bool flag = aXu || menuNode.J();
			if (!flag)
			{
				MenuNode menuNode2 = this;
				bool flag2 = false;
				do
				{
					if (menuNode2.aXV)
					{
						flag = true;
					}
					else if (menuNode2.C() != null)
					{
						menuNode2 = menuNode2.C();
					}
					else
					{
						flag2 = true;
					}
				}
				while (!flag2 && !flag);
			}
			if (flag)
			{
				axl.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)menuNode.j(false));
				axM.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)menuNode.j(true));
			}
		}
	}
}
