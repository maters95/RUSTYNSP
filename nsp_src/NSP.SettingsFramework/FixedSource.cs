using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace NSP.SettingsFramework;

public class FixedSource : ISignalSource
{
	[CompilerGenerated]
	private string BSI;

	[CompilerGenerated]
	private int BSi;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return BSI;
		}
		[CompilerGenerated]
		set
		{
			BSI = value;
		}
	}

	public int Value
	{
		[CompilerGenerated]
		get
		{
			return BSi;
		}
		[CompilerGenerated]
		set
		{
			BSi = value;
		}
	}

	public FixedSource(int val)
	{
		Value = val;
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEI());
		defaultInterpolatedStringHandler.AppendFormatted<int>(val);
		Name = defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
