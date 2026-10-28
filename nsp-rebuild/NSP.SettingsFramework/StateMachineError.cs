using System.Runtime.CompilerServices;

namespace NSP.SettingsFramework;

public class StateMachineError : SpecialObject
{
	private int BzU;

	private string Bzu;

	private string BzV;

	internal StateMachineError(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	[SpecialName]
	internal int method_71()
	{
		return BzU;
	}

	[SpecialName]
	internal void method_72(int int_0)
	{
		BzU = int_0;
	}

	[SpecialName]
	internal string method_73()
	{
		return Bzu;
	}

	[SpecialName]
	internal void method_74(string string_0)
	{
		Bzu = string_0;
	}

	[SpecialName]
	internal string method_75()
	{
		return BzV;
	}

	[SpecialName]
	internal void method_76(string string_0)
	{
		BzV = string_0;
	}
}
