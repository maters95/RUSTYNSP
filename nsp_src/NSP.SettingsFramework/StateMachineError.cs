using System.Runtime.CompilerServices;

namespace NSP.SettingsFramework;

public class StateMachineError : SpecialObject
{
	private int BzU;

	private string Bzu;

	private string BzV;

	internal StateMachineError(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	[SpecialName]
	internal new int A()
	{
		return BzU;
	}

	[SpecialName]
	internal new void A(int P_0)
	{
		BzU = P_0;
	}

	[SpecialName]
	internal new string a()
	{
		return Bzu;
	}

	[SpecialName]
	internal new void A(string P_0)
	{
		Bzu = P_0;
	}

	[SpecialName]
	internal new string B()
	{
		return BzV;
	}

	[SpecialName]
	internal new void a(string P_0)
	{
		BzV = P_0;
	}
}
