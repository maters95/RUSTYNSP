using System.Runtime.CompilerServices;

namespace NSP.SettingsFramework;

public class ValueAndDisplay
{
	[CompilerGenerated]
	private int azl;

	[CompilerGenerated]
	private string azM;

	public int Value
	{
		[CompilerGenerated]
		get
		{
			return azl;
		}
		[CompilerGenerated]
		set
		{
			azl = value;
		}
	}

	public string Display
	{
		[CompilerGenerated]
		get
		{
			return azM;
		}
		[CompilerGenerated]
		set
		{
			azM = value;
		}
	}
}
