using System;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;

namespace NSP.UserInterface;

public class OutputTestStateChangeEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly int HO;

	[CompilerGenerated]
	private readonly bool Ho;

	[CompilerGenerated]
	private readonly Setting HP;

	public int PortValue
	{
		[CompilerGenerated]
		get
		{
			return HO;
		}
	}

	public bool State
	{
		[CompilerGenerated]
		get
		{
			return Ho;
		}
	}

	public Setting StatusChannel
	{
		[CompilerGenerated]
		get
		{
			return HP;
		}
	}

	public OutputTestStateChangeEventArgs(Setting statuschannel, int portvalue, bool state)
	{
		HP = statuschannel;
		HO = portvalue;
		Ho = state;
	}
}
