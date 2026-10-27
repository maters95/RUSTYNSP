using System.Runtime.CompilerServices;

namespace NSP.SettingsFramework;

public class BindingData
{
	[CompilerGenerated]
	private string aZk;

	[CompilerGenerated]
	private DataTableBindType aZL;

	[CompilerGenerated]
	private bool aZl;

	public string BindingDataId
	{
		[CompilerGenerated]
		get
		{
			return aZk;
		}
		[CompilerGenerated]
		set
		{
			aZk = value;
		}
	}

	public DataTableBindType BindingType
	{
		[CompilerGenerated]
		get
		{
			return aZL;
		}
		[CompilerGenerated]
		set
		{
			aZL = value;
		}
	}

	public bool IsMapped
	{
		[CompilerGenerated]
		get
		{
			return aZl;
		}
		[CompilerGenerated]
		set
		{
			aZl = value;
		}
	}
}
