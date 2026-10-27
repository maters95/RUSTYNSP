using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NSP.SettingsFramework;

public class DTCErrors
{
	[CompilerGenerated]
	private bool aZq;

	[CompilerGenerated]
	private int aZR = -1;

	[CompilerGenerated]
	private int aZr = -1;

	[CompilerGenerated]
	private int aZS = -1;

	[CompilerGenerated]
	private int[] aZs;

	public Dictionary<int, string> ErrorIndexToCodeMap = new Dictionary<int, string>();

	[CompilerGenerated]
	private Dictionary<string, Dictionary<string, string>> aZT = new Dictionary<string, Dictionary<string, string>>();

	[CompilerGenerated]
	private List<ErrorPanelItem> aZt = new List<ErrorPanelItem>();

	public bool Visible
	{
		[CompilerGenerated]
		get
		{
			return aZq;
		}
		[CompilerGenerated]
		set
		{
			aZq = value;
		}
	}

	public int SeverityArrayDataId
	{
		[CompilerGenerated]
		get
		{
			return aZR;
		}
		[CompilerGenerated]
		set
		{
			aZR = value;
		}
	}

	public int ModeArrayDataId
	{
		[CompilerGenerated]
		get
		{
			return aZr;
		}
		[CompilerGenerated]
		set
		{
			aZr = value;
		}
	}

	public int StatusArrayDataId
	{
		[CompilerGenerated]
		get
		{
			return aZS;
		}
		[CompilerGenerated]
		set
		{
			aZS = value;
		}
	}

	public int[] ErrorToSettingMap
	{
		[CompilerGenerated]
		get
		{
			return aZs;
		}
		[CompilerGenerated]
		set
		{
			aZs = value;
		}
	}

	public Dictionary<string, Dictionary<string, string>> ErrorDefs
	{
		[CompilerGenerated]
		get
		{
			return aZT;
		}
		[CompilerGenerated]
		set
		{
			aZT = value;
		}
	}

	public List<ErrorPanelItem> ErrorPanel
	{
		[CompilerGenerated]
		get
		{
			return aZt;
		}
		[CompilerGenerated]
		set
		{
			aZt = value;
		}
	}

	public bool IsValid
	{
		get
		{
			if (SeverityArrayDataId != -1 && ModeArrayDataId != -1 && StatusArrayDataId != -1 && ErrorToSettingMap != null && ErrorDefs != null && ErrorDefs.Count > 0)
			{
				return Visible;
			}
			return false;
		}
	}
}
