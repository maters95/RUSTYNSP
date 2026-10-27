using System.Runtime.CompilerServices;

namespace NSP.Utils;

public class Pair<T1, T2>
{
	[CompilerGenerated]
	private T1 DK;

	[CompilerGenerated]
	private T2 Dk;

	public T1 First
	{
		[CompilerGenerated]
		get
		{
			return DK;
		}
		[CompilerGenerated]
		set
		{
			DK = value;
		}
	}

	public T2 Second
	{
		[CompilerGenerated]
		get
		{
			return Dk;
		}
		[CompilerGenerated]
		set
		{
			Dk = value;
		}
	}
}
