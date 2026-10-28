using System.Runtime.CompilerServices;
using ns7;

namespace NSP.SettingsFramework;

public class CounterSource : ISignalSource
{
	[CompilerGenerated]
	private string BSJ;

	[CompilerGenerated]
	private int BSj;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return BSJ;
		}
		[CompilerGenerated]
		set
		{
			BSJ = value;
		}
	}

	public int Value
	{
		[CompilerGenerated]
		get
		{
			return BSj;
		}
		[CompilerGenerated]
		set
		{
			BSj = value;
		}
	}

	public CounterSource()
	{
		Value = 0;
		Name = Class333.smethod_818();
	}
}
