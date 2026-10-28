using System.Runtime.CompilerServices;

namespace NSP.SettingsFramework;

public class SearchFilter : IFilter
{
	[CompilerGenerated]
	private string BSa;

	[CompilerGenerated]
	private string BSB;

	[CompilerGenerated]
	private int BSb;

	[CompilerGenerated]
	private string BSC;

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return BSa;
		}
		[CompilerGenerated]
		set
		{
			BSa = value;
		}
	}

	public string HeaderStr
	{
		[CompilerGenerated]
		get
		{
			return BSB;
		}
		[CompilerGenerated]
		set
		{
			BSB = value;
		}
	}

	public string[] Headers
	{
		get
		{
			if (string.IsNullOrEmpty(HeaderStr))
			{
				return null;
			}
			return HeaderStr.Split(',');
		}
	}

	public int MaxChars
	{
		[CompilerGenerated]
		get
		{
			return BSb;
		}
		[CompilerGenerated]
		set
		{
			BSb = value;
		}
	}

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return BSC;
		}
		[CompilerGenerated]
		set
		{
			BSC = value;
		}
	}
}
