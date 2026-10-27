using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

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
		Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hs();
	}
}
