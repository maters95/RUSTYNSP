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

	internal StateMachineStage(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	[SpecialName]
	internal string method_71()
	{
		return bAb;
	}

	[SpecialName]
	internal void method_72(string string_0)
	{
		bAb = string_0;
	}

	[SpecialName]
	internal int method_73()
	{
		return Bzv;
	}

	[SpecialName]
	internal void method_74(int int_0)
	{
		Bzv = int_0;
	}

	internal void method_75(int int_0)
	{
		BzX.Add(int_0);
	}

	[SpecialName]
	internal List<int> method_76()
	{
		return BzX;
	}

	[SpecialName]
	internal bool method_77()
	{
		return BzY;
	}

	[SpecialName]
	internal void method_78(bool bool_0)
	{
		BzY = bool_0;
	}

	[SpecialName]
	internal int method_79()
	{
		return Bzx;
	}

	[SpecialName]
	internal void method_80(int int_0)
	{
		Bzx = int_0;
	}

	[SpecialName]
	internal int method_81()
	{
		return BzW;
	}

	[SpecialName]
	internal void method_82(int int_0)
	{
		BzW = int_0;
	}

	[SpecialName]
	internal int method_83()
	{
		return Bzw;
	}

	[SpecialName]
	internal void method_84(int int_0)
	{
		Bzw = int_0;
	}

	[SpecialName]
	internal bool method_85()
	{
		return Bzy;
	}

	[SpecialName]
	internal void method_86(bool bool_0)
	{
		Bzy = bool_0;
	}

	[SpecialName]
	internal bool method_87()
	{
		return BzZ;
	}

	[SpecialName]
	internal void method_88(bool bool_0)
	{
		BzZ = bool_0;
	}

	[SpecialName]
	internal string method_89()
	{
		return Bzz;
	}

	[SpecialName]
	internal void method_90(string string_0)
	{
		Bzz = string_0;
	}

	[SpecialName]
	internal string method_91()
	{
		return bAA;
	}

	[SpecialName]
	internal void method_92(string string_0)
	{
		bAA = string_0;
	}

	[SpecialName]
	internal string method_93()
	{
		return bAa;
	}

	[SpecialName]
	internal void method_94(string string_0)
	{
		bAa = string_0;
	}

	[SpecialName]
	internal string method_95()
	{
		return bAB;
	}

	[SpecialName]
	internal void method_96(string string_0)
	{
		bAB = string_0;
	}
}
