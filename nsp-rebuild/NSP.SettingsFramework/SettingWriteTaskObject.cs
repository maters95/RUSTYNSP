using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;
using ns4;
using ns5;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class SettingWriteTaskObject
{
	private string BbH;

	private string Bbh;

	private string BbI;

	private List<int> Bbi = new List<int>();

	private List<string> BbJ = new List<string>();

	private Framework Bbj;

	internal SettingWriteTaskObject(Framework framework_0)
	{
		Bbj = framework_0;
	}

	[SpecialName]
	internal void method_0(string string_0)
	{
		BbH = string_0;
	}

	[SpecialName]
	internal void method_1(string string_0)
	{
		Bbh = string_0;
	}

	[SpecialName]
	internal void method_2(string string_0)
	{
		BbI = string_0;
	}

	internal void method_3(int int_0, string string_0)
	{
		Bbi.Add(int_0);
		BbJ.Add(string_0);
	}

	[SpecialName]
	internal List<int> method_4()
	{
		return Bbi;
	}

	internal bool method_5()
	{
		foreach (int item in Bbi)
		{
			Setting setting = Bbj.method_31(item);
			if (setting != null && Bbj.method_2() && Bbj.method_3() && setting.method_96())
			{
				return true;
			}
		}
		return false;
	}

	internal void method_6()
	{
		string string_ = BbI;
		bool flag;
		if (string_ != null)
		{
			Class37.smethod_0(ref string_, Bbj);
			flag = Class37.smethod_10(ref string_);
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			Form54.smethod_6(Form23.form23_0, Bbh, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			if (Form54.smethod_6(Form23.form23_0, BbH, Class333.smethod_1130(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
			{
				return;
			}
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			for (int i = 0; i < Bbi.Count; i++)
			{
				string string_2 = BbJ[i];
				Class37.smethod_0(ref string_2, Bbj);
				int int_ = Class37.smethod_11(ref string_2);
				Setting setting = Bbj.method_31(Bbi[i]);
				for (int j = 0; j < setting.method_242()[2]; j++)
				{
					for (int k = 0; k < setting.method_242()[1]; k++)
					{
						for (int l = 0; l < setting.method_242()[0]; l++)
						{
							setting.method_273(j, k, l, int_, bool_0: true);
						}
					}
				}
			}
			@class?.method_4();
		}
	}
}
