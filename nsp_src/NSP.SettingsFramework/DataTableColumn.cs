using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace NSP.SettingsFramework;

public class DataTableColumn
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A Bry = new A();

		public static Func<Setting.ListItems.A, ValueTuple<int, string>> BrZ;

		public static Func<ValueTuple<int, string>, int> Brz;

		public static Func<ValueTuple<int, string>, string> BSA;

		internal ValueTuple<int, string> A(Setting.ListItems.A P_0)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<int, string>(P_0.bBv, P_0.bBV);
		}

		internal int A(ValueTuple<int, string> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return x.Item1;
		}

		internal string a(ValueTuple<int, string> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return x.Item2;
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
				return EnumValueStr.Split(',', (StringSplitOptions)0);
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
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return aZp;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
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
		int num = default(int);
		if (!string.IsNullOrEmpty(BindingData.BindingDataId) && int.TryParse(BindingData.BindingDataId, ref num))
		{
			List<string> val = Enumerable.ToList<string>(Enumerable.Select<ValueTuple<int, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<int, string>>)Enumerable.OrderBy<ValueTuple<int, string>, int>((System.Collections.Generic.IEnumerable<ValueTuple<int, string>>)Enumerable.ToList<ValueTuple<int, string>>(Enumerable.Select<Setting.ListItems.A, ValueTuple<int, string>>((System.Collections.Generic.IEnumerable<Setting.ListItems.A>)framework.A(num).d(0), (Func<Setting.ListItems.A, ValueTuple<int, string>>)((Setting.ListItems.A P_0) => new ValueTuple<int, string>(P_0.bBv, P_0.bBV)))), (Func<ValueTuple<int, string>, int>)((ValueTuple<int, string> x) => x.Item1)), (Func<ValueTuple<int, string>, string>)((ValueTuple<int, string> x) => x.Item2)));
			EnumValueStr = string.Join(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ(), (System.Collections.Generic.IEnumerable<string>)val);
		}
	}
}
