using System;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;

namespace NSP.UserInterface;

public class OutputTestStateChangeEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly Setting setting_0;

	public int PortValue
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public bool State
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public Setting StatusChannel
	{
		[CompilerGenerated]
		get
		{
			return setting_0;
		}
	}

	public OutputTestStateChangeEventArgs(Setting statuschannel, int portvalue, bool state)
	{
		setting_0 = statuschannel;
		int_0 = portvalue;
		bool_0 = state;
	}
}
