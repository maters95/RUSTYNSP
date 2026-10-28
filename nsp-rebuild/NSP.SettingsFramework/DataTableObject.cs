using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NSP.SettingsFramework;

public class DataTableObject
{
	[CompilerGenerated]
	private string aZE;

	[CompilerGenerated]
	private bool aZe;

	[CompilerGenerated]
	private DTCErrors aZF;

	[CompilerGenerated]
	private List<DataTableColumn> aZf;

	[CompilerGenerated]
	private List<IFilter> aZG;

	[CompilerGenerated]
	private Dictionary<string, Dictionary<string, string>> aZg;

	[CompilerGenerated]
	private string aZH;

	[CompilerGenerated]
	private string aZh;

	[CompilerGenerated]
	private string aZI;

	[CompilerGenerated]
	private int[] aZi;

	[CompilerGenerated]
	private string aZJ;

	[CompilerGenerated]
	private string aZj;

	[CompilerGenerated]
	private string aZK;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return aZE;
		}
		[CompilerGenerated]
		set
		{
			aZE = value;
		}
	}

	public bool IsErrorTable
	{
		[CompilerGenerated]
		get
		{
			return aZe;
		}
		[CompilerGenerated]
		set
		{
			aZe = value;
		}
	}

	public DTCErrors ErrorData
	{
		[CompilerGenerated]
		get
		{
			return aZF;
		}
		[CompilerGenerated]
		set
		{
			aZF = value;
		}
	}

	public List<DataTableColumn> Columns
	{
		[CompilerGenerated]
		get
		{
			return aZf;
		}
		[CompilerGenerated]
		set
		{
			aZf = value;
		}
	}

	public List<IFilter> Filters
	{
		[CompilerGenerated]
		get
		{
			return aZG;
		}
		[CompilerGenerated]
		set
		{
			aZG = value;
		}
	}

	public Dictionary<string, Dictionary<string, string>> Data
	{
		[CompilerGenerated]
		get
		{
			return aZg;
		}
		[CompilerGenerated]
		set
		{
			aZg = value;
		}
	}

	public string IndexColName
	{
		[CompilerGenerated]
		get
		{
			return aZH;
		}
		[CompilerGenerated]
		set
		{
			aZH = value;
		}
	}

	public string IdColName
	{
		[CompilerGenerated]
		get
		{
			return aZh;
		}
		[CompilerGenerated]
		set
		{
			aZh = value;
		}
	}

	public string SettingMapColName
	{
		[CompilerGenerated]
		get
		{
			return aZI;
		}
		[CompilerGenerated]
		set
		{
			aZI = value;
		}
	}

	public int[] DataToSettingMap
	{
		[CompilerGenerated]
		get
		{
			return aZi;
		}
		[CompilerGenerated]
		set
		{
			aZi = value;
		}
	}

	public string SelectedItemDataName
	{
		[CompilerGenerated]
		get
		{
			return aZJ;
		}
		[CompilerGenerated]
		set
		{
			aZJ = value;
		}
	}

	public string GroupDataName
	{
		[CompilerGenerated]
		get
		{
			return aZj;
		}
		[CompilerGenerated]
		set
		{
			aZj = value;
		}
	}

	public string GroupDescDataName
	{
		[CompilerGenerated]
		get
		{
			return aZK;
		}
		[CompilerGenerated]
		set
		{
			aZK = value;
		}
	}

	public DataTableObject()
	{
		Columns = new List<DataTableColumn>();
		Filters = new List<IFilter>();
	}
}
