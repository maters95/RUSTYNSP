using System.Runtime.CompilerServices;

namespace NSP.SettingsFramework;

public class ChannelSource : ISignalSource
{
	[CompilerGenerated]
	private Setting BSH;

	[CompilerGenerated]
	private string BSh;

	public Setting Channel
	{
		[CompilerGenerated]
		get
		{
			return BSH;
		}
		[CompilerGenerated]
		set
		{
			BSH = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return BSh;
		}
		[CompilerGenerated]
		set
		{
			BSh = value;
		}
	}

	public int Value
	{
		get
		{
			if (Channel != null)
			{
				return Channel.method_64();
			}
			return 0;
		}
	}

	public ChannelSource(Setting chan)
	{
		Channel = chan;
		Name = chan.method_22(bool_0: false);
	}
}
