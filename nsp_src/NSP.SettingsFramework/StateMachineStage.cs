using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NSP.SettingsFramework;

public class StateMachineStage : SpecialObject
{
	private int Bzv;

	private int BzW;

	private int Bzw;

	private List<int> BzX = new List<int>();

	private int Bzx;

	private bool BzY;

	private bool Bzy;

	private bool BzZ;

	private string Bzz;

	private string bAA;

	private string bAa;

	private string bAB;

	private string bAb;

	internal StateMachineStage(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	[SpecialName]
	internal new string A()
	{
		return bAb;
	}

	[SpecialName]
	internal new void A(string P_0)
	{
		bAb = P_0;
	}

	[SpecialName]
	internal new int a()
	{
		return Bzv;
	}

	[SpecialName]
	internal new void A(int P_0)
	{
		Bzv = P_0;
	}

	internal new void a(int P_0)
	{
		BzX.Add(P_0);
	}

	[SpecialName]
	internal new List<int> B()
	{
		return BzX;
	}

	[SpecialName]
	internal new bool b()
	{
		return BzY;
	}

	[SpecialName]
	internal new void A(bool P_0)
	{
		BzY = P_0;
	}

	[SpecialName]
	internal new int C()
	{
		return Bzx;
	}

	[SpecialName]
	internal new void B(int P_0)
	{
		Bzx = P_0;
	}

	[SpecialName]
	internal new int c()
	{
		return BzW;
	}

	[SpecialName]
	internal new void b(int P_0)
	{
		BzW = P_0;
	}

	[SpecialName]
	internal new int D()
	{
		return Bzw;
	}

	[SpecialName]
	internal new void C(int P_0)
	{
		Bzw = P_0;
	}

	[SpecialName]
	internal new bool d()
	{
		return Bzy;
	}

	[SpecialName]
	internal new void a(bool P_0)
	{
		Bzy = P_0;
	}

	[SpecialName]
	internal new bool E()
	{
		return BzZ;
	}

	[SpecialName]
	internal void B(bool P_0)
	{
		BzZ = P_0;
	}

	[SpecialName]
	internal new string e()
	{
		return Bzz;
	}

	[SpecialName]
	internal new void a(string P_0)
	{
		Bzz = P_0;
	}

	[SpecialName]
	internal new string F()
	{
		return bAA;
	}

	[SpecialName]
	internal new void B(string P_0)
	{
		bAA = P_0;
	}

	[SpecialName]
	internal new string f()
	{
		return bAa;
	}

	[SpecialName]
	internal new void b(string P_0)
	{
		bAa = P_0;
	}

	[SpecialName]
	internal new string G()
	{
		return bAB;
	}

	[SpecialName]
	internal new void C(string P_0)
	{
		bAB = P_0;
	}
}
