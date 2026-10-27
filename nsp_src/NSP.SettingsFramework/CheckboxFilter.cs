using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace NSP.SettingsFramework;

public class CheckboxFilter : IFilter
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A ByY = new A();

		public static Func<Setting.ListItems.A, ValueTuple<int, string>> Byy;

		public static Func<ValueTuple<int, string>, int> ByZ;

		public static Func<ValueTuple<int, string>, string> Byz;

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
			return OptionsStr.Split(',', (StringSplitOptions)0);
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
		int num = default(int);
		if (!string.IsNullOrEmpty(EnumSrcDataId) && int.TryParse(EnumSrcDataId, ref num))
		{
			List<string> val = Enumerable.ToList<string>(Enumerable.Select<ValueTuple<int, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<int, string>>)Enumerable.OrderBy<ValueTuple<int, string>, int>((System.Collections.Generic.IEnumerable<ValueTuple<int, string>>)Enumerable.ToList<ValueTuple<int, string>>(Enumerable.Select<Setting.ListItems.A, ValueTuple<int, string>>((System.Collections.Generic.IEnumerable<Setting.ListItems.A>)framework.A(num).d(0), (Func<Setting.ListItems.A, ValueTuple<int, string>>)((Setting.ListItems.A P_0) => new ValueTuple<int, string>(P_0.bBv, P_0.bBV)))), (Func<ValueTuple<int, string>, int>)((ValueTuple<int, string> x) => x.Item1)), (Func<ValueTuple<int, string>, string>)((ValueTuple<int, string> x) => x.Item2)));
			OptionsStr = string.Join(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ(), (System.Collections.Generic.IEnumerable<string>)val);
		}
	}
}
