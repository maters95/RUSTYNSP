using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns7;

namespace NSP.SettingsFramework;

public class CheckboxFilter : IFilter
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class265
	{
		public static readonly Class265 ByY = new Class265();

		public static Func<Setting.ListItems.Struct45, (int ListItemValue, string ListItemText)> Byy;

		public static Func<(int index, string text), int> ByZ;

		public static Func<(int index, string text), string> Byz;

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
	private string BSc;

	[CompilerGenerated]
	private string BSD;

	[CompilerGenerated]
	private string BSd;

	[CompilerGenerated]
	private string BSE;

	[CompilerGenerated]
	private CheckState[] BSe;

	[CompilerGenerated]
	private bool BSF;

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return BSc;
		}
		[CompilerGenerated]
		set
		{
			BSc = value;
		}
	}

	public string Header
	{
		[CompilerGenerated]
		get
		{
			return BSD;
		}
		[CompilerGenerated]
		set
		{
			BSD = value;
		}
	}

	public string OptionsStr
	{
		[CompilerGenerated]
		get
		{
			return BSd;
		}
		[CompilerGenerated]
		set
		{
			BSd = value;
		}
	}

	public string[] Options
	{
		get
		{
			if (string.IsNullOrEmpty(OptionsStr))
			{
				return null;
			}
			return OptionsStr.Split(',');
		}
	}

	public string EnumSrcDataId
	{
		[CompilerGenerated]
		get
		{
			return BSE;
		}
		[CompilerGenerated]
		set
		{
			BSE = value;
		}
	}

	public CheckState[] ItemStates
	{
		[CompilerGenerated]
		get
		{
			return BSe;
		}
		[CompilerGenerated]
		set
		{
			BSe = value;
		}
	}

	public bool BulkEdit
	{
		[CompilerGenerated]
		get
		{
			return BSF;
		}
		[CompilerGenerated]
		set
		{
			BSF = value;
		}
	}

	public void PopulateOptionsStrFromSettingEnums(Framework framework)
	{
		if (!string.IsNullOrEmpty(EnumSrcDataId) && int.TryParse(EnumSrcDataId, out var result))
		{
			List<string> values = (from struct45_0 in framework.method_31(result).method_102()
				select (ListItemValue: struct45_0.bBv, ListItemText: struct45_0.bBV)).ToList().OrderBy(((int index, string text) valueTuple_0) => valueTuple_0.index).Select(((int index, string text) valueTuple_0) => valueTuple_0.text)
				.ToList();
			OptionsStr = string.Join(Class333.smethod_189(), values);
		}
	}
}
