using System.Runtime.CompilerServices;
using ns7;

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
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral(Class333.BEI());
		defaultInterpolatedStringHandler.AppendFormatted(val);
		Name = defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
