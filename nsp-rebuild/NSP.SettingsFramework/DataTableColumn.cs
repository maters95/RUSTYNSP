using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns7;

namespace NSP.SettingsFramework;

public class DataTableColumn
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class264
	{
		public static readonly Class264 Bry = new Class264();

		public static Func<Setting.ListItems.Struct45, (int ListItemValue, string ListItemText)> BrZ;

		public static Func<(int index, string text), int> Brz;

		public static Func<(int index, string text), string> BSA;

		internal (int ListItemValue, string ListItemText) method_0(Setting.ListItems.Struct45 struct45_0)
		{
			return (ListItemValue: struct45_0.bBv, ListItemText: struct45_0.bBV);
		}

		internal int method_1((int index, string text) valueTuple_0)
		{
			return valueTuple_0.index;
		}

		internal string method_2((int index, string text) valueTuple_0)
		{
			return valueTuple_0.text;
		}
	}

	[CompilerGenerated]
	private string aZM;

	[CompilerGenerated]
	private DataTableColumnType aZm;

	[CompilerGenerated]
	private string aZN;

	[CompilerGenerated]
	private BindingData aZn;

	[CompilerGenerated]
	private string aZO;

	[CompilerGenerated]
	private bool aZo;

	[CompilerGenerated]
	private string aZP;

	[CompilerGenerated]
	private DataGridViewAutoSizeColumnMode aZp;

	[CompilerGenerated]
	private string aZQ;

	public string HeaderText
	{
		[CompilerGenerated]
		get
		{
			return aZM;
		}
		[CompilerGenerated]
		set
		{
			aZM = value;
		}
	}

	public DataTableColumnType Type
	{
		[CompilerGenerated]
		get
		{
			return aZm;
		}
		[CompilerGenerated]
		set
		{
			aZm = value;
		}
	}

	public string PFieldId
	{
		[CompilerGenerated]
		get
		{
			return aZN;
		}
		[CompilerGenerated]
		set
		{
			aZN = value;
		}
	}

	public BindingData BindingData
	{
		[CompilerGenerated]
		get
		{
			return aZn;
		}
		[CompilerGenerated]
		set
		{
			aZn = value;
		}
	}

	public string EnumValueStr
	{
		[CompilerGenerated]
		get
		{
			return aZO;
		}
		[CompilerGenerated]
		set
		{
			aZO = value;
		}
	}

	public string[] EnumValues
	{
		get
		{
			if (EnumValueStr != null)
			{
				return EnumValueStr.Split(',');
			}
			return null;
		}
	}

	public bool Visible
	{
		[CompilerGenerated]
		get
		{
			return aZo;
		}
		[CompilerGenerated]
		set
		{
			aZo = value;
		}
	}

	public string MenuLink
	{
		[CompilerGenerated]
		get
		{
			return aZP;
		}
		[CompilerGenerated]
		set
		{
			aZP = value;
		}
	}

	public DataGridViewAutoSizeColumnMode AutoSize
	{
		[CompilerGenerated]
		get
		{
			return aZp;
		}
		[CompilerGenerated]
		set
		{
			aZp = value;
		}
	}

	public string Tooltip
	{
		[CompilerGenerated]
		get
		{
			return aZQ;
		}
		[CompilerGenerated]
		set
		{
			aZQ = value;
		}
	}

	public void PopulateEnumStrFromSettingEnums(Framework framework)
	{
		if (!string.IsNullOrEmpty(BindingData.BindingDataId) && int.TryParse(BindingData.BindingDataId, out var result))
		{
			List<string> values = (from struct45_0 in framework.method_31(result).method_102()
				select (ListItemValue: struct45_0.bBv, ListItemText: struct45_0.bBV)).ToList().OrderBy(((int index, string text) valueTuple_0) => valueTuple_0.index).Select(((int index, string text) valueTuple_0) => valueTuple_0.text)
				.ToList();
			EnumValueStr = string.Join(Class333.smethod_189(), values);
		}
	}
}
