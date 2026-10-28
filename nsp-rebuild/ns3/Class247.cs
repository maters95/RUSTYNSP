using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns4;
using ns6;
using ns7;

namespace ns3;

internal class Class247 : SpecialObject
{
	internal const string BYZ = "user_resources";

	internal const string BYz = "images";

	internal const string ByA = "fonts";

	internal const string Bya = "u/";

	internal const string ByB = "h/";

	private Setting Byb;

	private Setting ByC;

	private Setting Byc;

	private Setting ByD;

	private Setting Byd;

	private Setting ByE;

	private Setting Bye;

	private List<Class250> ByF = new List<Class250>();

	private const uint Byf = 1u;

	[CompilerGenerated]
	private EventHandler ByG;

	private List<List<int>> Byg = new List<List<int>>();

	private List<List<int>> ByH = new List<List<int>>();

	internal Class247(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	internal void method_71()
	{
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject is Class250)
			{
				Class250 @class = settingOrSpecialObject as Class250;
				ByF.Add(@class);
				@class.method_71();
			}
			else if (settingOrSpecialObject is Setting)
			{
				if (settingOrSpecialObject.method_2() == Class333.Bhi())
				{
					Byb = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2() == Class333.BhJ())
				{
					ByC = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2() == Class333.Bhj())
				{
					Byc = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2() == Class333.BhK())
				{
					ByD = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2() == Class333.Bhk())
				{
					ByE = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2() == Class333.BhL())
				{
					Byd = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2() == Class333.Bhl())
				{
					Bye = settingOrSpecialObject as Setting;
				}
			}
		}
	}

	[SpecialName]
	internal Setting method_72()
	{
		return Byb;
	}

	[SpecialName]
	internal Setting method_73()
	{
		return ByC;
	}

	[SpecialName]
	internal Setting method_74()
	{
		return Byc;
	}

	[SpecialName]
	internal Setting method_75()
	{
		return ByD;
	}

	[SpecialName]
	internal Setting method_76()
	{
		return Byd;
	}

	[SpecialName]
	internal Setting method_77()
	{
		return Bye;
	}

	[SpecialName]
	internal Setting method_78()
	{
		return ByE;
	}

	[SpecialName]
	internal List<Class250> method_79()
	{
		return ByF;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_80(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = ByG;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref ByG, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_81(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = ByG;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref ByG, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal bool method_82(int int_0)
	{
		return method_83(int_0, bool_0: false);
	}

	private bool method_83(int int_0, bool bool_0)
	{
		int num = Byb.method_256();
		if (num == ByF.Count)
		{
			return false;
		}
		Class280 @class = Form23.smethod_95();
		if (!bool_0)
		{
			@class?.method_1();
			m_framework.method_55();
		}
		if (int_0 >= num)
		{
			ByF[int_0].method_74(bool_0: true);
			ByF[int_0].method_76();
			ByF[int_0].method_19()?.method_262(Class333.aof() + (int_0 + 1), bool_0: true);
		}
		else
		{
			for (int num2 = num - 1; num2 >= int_0; num2--)
			{
				ByF[num2 + 1].method_29(ByF[num2], bool_0: true);
			}
			ByF[int_0].method_74(bool_0: true);
			ByF[int_0].method_76();
			ByF[int_0].method_19()?.method_262(Class333.aof() + (int_0 + 1), bool_0: true);
			if (ByC != null)
			{
				int num3 = ByC.method_256();
				if (num3 >= int_0)
				{
					ByC.method_272(num3 + 1, bool_0: true);
				}
			}
		}
		Byb.method_272(num + 1, bool_0: true);
		if (!bool_0)
		{
			m_framework.method_54(bool_0: true);
			@class?.method_4();
			method_94();
			if (ByG != null)
			{
				ByG(null, null);
			}
			Form23.smethod_76();
		}
		return true;
	}

	internal void method_84()
	{
		Form23.form23_0.control25_0.method_31();
	}

	internal void method_85()
	{
		Form23.form23_0.control25_0.method_32();
	}

	internal bool method_86(int int_0)
	{
		string[] files = Directory.GetFiles(Form23.string_13);
		int num = Byb.method_256();
		if (num <= 1L)
		{
			return true;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_1();
		Class329.smethod_12();
		if (Form23.smethod_28(m_framework.aXc, bool_53: true))
		{
			Class1.smethod_66(m_framework.aXc, out var _);
		}
		m_framework.method_55();
		for (int i = int_0 + 1; i < num; i++)
		{
			ByF[i - 1].method_29(ByF[i], bool_0: true);
			if (method_98())
			{
				File.Copy(files[i], files[i - 1], overwrite: true);
			}
		}
		if (ByC != null)
		{
			int num2 = ByC.method_256();
			if (num2 > int_0)
			{
				ByC.method_272(num2 - 1, bool_0: true);
			}
			else if (num2 == int_0)
			{
				ByC.method_272(-1, bool_0: true);
			}
		}
		if (Byc.method_256() >= num - 1)
		{
			Byc.method_272(num - 2, bool_0: true);
		}
		Byb.method_272(num - 1, bool_0: true);
		m_framework.method_54(bool_0: true);
		@class?.method_4();
		method_94();
		if (ByG != null)
		{
			ByG(null, null);
		}
		Form23.smethod_76();
		return true;
	}

	internal bool method_87(int int_0, int int_1)
	{
		if (Byb.method_256() < 2)
		{
			return false;
		}
		if (int_0 == int_1)
		{
			return true;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_1();
		Class329.smethod_12();
		if (Form23.smethod_28(m_framework.aXc, bool_53: true))
		{
			Class1.smethod_66(m_framework.aXc, out var _);
		}
		m_framework.method_55();
		List<List<int>> list_ = new List<List<int>>();
		SettingOrSpecialObject.smethod_2(ByF[int_0], list_);
		string text = Form23.string_13 + Class333.BhM();
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		string[] files = Directory.GetFiles(Form23.string_13);
		if (method_98() && files.Length > int_0)
		{
			File.Copy(files[int_0], text, overwrite: true);
		}
		if (int_0 > int_1)
		{
			for (int num = int_0; num > int_1; num--)
			{
				ByF[num].method_29(ByF[num - 1], bool_0: true);
				if (method_98() && files.Length > int_0)
				{
					File.Copy(files[num - 1], files[num], overwrite: true);
				}
			}
			if (method_98() && files.Length > int_1 && File.Exists(text))
			{
				File.Copy(text, files[int_1], overwrite: true);
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			int int_2 = 0;
			SettingOrSpecialObject.smethod_3(ByF[int_1], list_, ref int_2, bool_0: true);
			if (ByC != null)
			{
				int num2 = ByC.method_256();
				if (num2 == int_0)
				{
					ByC.method_272(int_1, bool_0: true);
				}
				else if (num2 >= int_1 && num2 < int_0)
				{
					ByC.method_272(num2 + 1, bool_0: true);
				}
			}
		}
		else if (int_0 < int_1)
		{
			for (int i = int_0; i < int_1; i++)
			{
				ByF[i].method_29(ByF[i + 1], bool_0: true);
				if (method_98() && files.Length > int_1)
				{
					File.Copy(files[i + 1], files[i], overwrite: true);
				}
			}
			if (method_98() && files.Length > int_1 && File.Exists(text))
			{
				File.Copy(text, files[int_1], overwrite: true);
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			int int_3 = 0;
			SettingOrSpecialObject.smethod_3(ByF[int_1], list_, ref int_3, bool_0: true);
			if (ByC != null)
			{
				int num3 = ByC.method_256();
				if (num3 == int_0)
				{
					ByC.method_272(int_1, bool_0: true);
				}
				else if (num3 > int_0 && num3 <= int_1)
				{
					ByC.method_272(num3 - 1, bool_0: true);
				}
			}
		}
		m_framework.method_54(bool_0: true);
		@class?.method_4();
		method_94();
		if (ByG != null)
		{
			ByG(null, null);
		}
		Form23.smethod_76();
		return true;
	}

	internal bool method_88(int int_0)
	{
		int num = Byb.method_256();
		if (num != 0 && int_0 < num && num != ByF.Count)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			Class329.smethod_12();
			if (Form23.smethod_28(m_framework.aXc, bool_53: true))
			{
				Class1.smethod_66(m_framework.aXc, out var _);
			}
			m_framework.method_55();
			method_83(int_0 + 1, bool_0: true);
			ByF[int_0 + 1].method_29(ByF[int_0], bool_0: true);
			if (method_98())
			{
				string[] files = Directory.GetFiles(Form23.string_13);
				for (int num2 = files.Length - 1; num2 > int_0; num2--)
				{
					File.Copy(files[num2 - 1], files[num2], overwrite: true);
				}
			}
			m_framework.method_54(bool_0: true);
			@class?.method_4();
			method_94();
			if (ByG != null)
			{
				ByG(null, null);
			}
			Form23.smethod_76();
			return true;
		}
		return false;
	}

	internal bool method_89(int int_0)
	{
		int num = Byb.method_256();
		if (num != 0 && int_0 >= 0 && int_0 < num)
		{
			Byg.Clear();
			SettingOrSpecialObject.smethod_2(ByF[int_0], Byg);
			return true;
		}
		return false;
	}

	internal bool method_90(int int_0)
	{
		int num = Byb.method_256();
		if (int_0 < num && num != ByF.Count)
		{
			if (Byg.Count == 0)
			{
				return false;
			}
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			Class329.smethod_12();
			if (Form23.smethod_28(m_framework.aXc, bool_53: true))
			{
				Class1.smethod_66(m_framework.aXc, out var _);
			}
			m_framework.method_55();
			if (int_0 != -1)
			{
				method_83(int_0 + 1, bool_0: true);
				int int_1 = 0;
				SettingOrSpecialObject.smethod_3(ByF[int_0 + 1], Byg, ref int_1, bool_0: true);
			}
			else
			{
				int_0 = num;
				method_83(num, bool_0: true);
				int int_2 = 0;
				SettingOrSpecialObject.smethod_3(ByF[int_0], Byg, ref int_2, bool_0: true);
			}
			m_framework.method_54(bool_0: true);
			@class?.method_4();
			method_94();
			if (ByG != null)
			{
				ByG(null, null);
			}
			Form23.smethod_76();
			return true;
		}
		return false;
	}

	internal bool method_91(int int_0, int int_1)
	{
		int num = Byb.method_256();
		if (num != 0 && int_0 >= 0 && int_0 < num && ByF[int_0] != null)
		{
			if (ByF[int_0].method_72().Count != 0 && int_1 >= 0 && int_1 < ByF[int_0].method_72().Count)
			{
				ByH.Clear();
				SettingOrSpecialObject.smethod_2(ByF[int_0].method_72()[int_1], ByH);
				return true;
			}
			return false;
		}
		return false;
	}

	internal bool method_92()
	{
		return ByH.Count > 0;
	}

	internal Class243 method_93(int int_0, int int_1)
	{
		int num = Byb.method_256();
		if (num != 0 && int_0 >= 0 && int_0 < num && ByF[int_0] != null)
		{
			if (ByF[int_0].method_72().Count != 0 && int_1 >= 0 && int_1 < ByF[int_0].method_72().Count)
			{
				if (ByH.Count == 0)
				{
					return null;
				}
				Class280 @class = Form23.smethod_95();
				@class?.method_1();
				Class329.smethod_12();
				if (Form23.smethod_28(m_framework.aXc, bool_53: true))
				{
					Class1.smethod_66(m_framework.aXc, out var _);
				}
				m_framework.method_55();
				Class243 class2 = ByF[int_0].method_72()[int_1];
				int int_2 = 0;
				SettingOrSpecialObject.smethod_3(class2, ByH, ref int_2, bool_0: true);
				m_framework.method_54(bool_0: true);
				@class?.method_4();
				return class2;
			}
			return null;
		}
		return null;
	}

	private void method_94()
	{
		for (int i = 0; i < m_framework.awR.method_6().Count; i++)
		{
			MenuNode menuNode = m_framework.awR.method_6()[i];
			if (menuNode.method_37())
			{
				menuNode.method_81();
			}
		}
	}

	internal List<Setting> method_95(string string_0, Class1.Enum5 enum5_0, bool bool_0)
	{
		List<Setting> list = new List<Setting>();
		foreach (Setting item in m_framework.awv)
		{
			if (!item.method_35() || item.method_174() != enum5_0)
			{
				continue;
			}
			string text = item.method_260();
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			if (text.StartsWith(Class333.smethod_1469()))
			{
				if (bool_0 && text.Substring(Class333.smethod_1469().Length) == string_0)
				{
					list.Add(item);
				}
			}
			else if (!bool_0)
			{
				string text2 = ((!text.StartsWith(Class333.smethod_1472())) ? text : text.Substring(Class333.smethod_1472().Length));
				if (text2 == string_0)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	internal static void smethod_4(Setting setting_0, bool bool_0)
	{
		string text = setting_0.method_260();
		if (!text.StartsWith(Class333.smethod_1469()))
		{
			return;
		}
		string text2 = smethod_7(setting_0.method_174());
		if (string.IsNullOrWhiteSpace(text2))
		{
			return;
		}
		string text3 = Form23.string_11 + Class333.smethod_176() + text2 + Class333.smethod_176();
		string text4 = Form23.string_10 + Class333.smethod_176() + text2 + Class333.smethod_176();
		string text5 = text.Substring(Class333.smethod_1469().Length);
		if (string.IsNullOrWhiteSpace(text5))
		{
			return;
		}
		string text6 = text5.Substring(text5.LastIndexOf(Class333.smethod_190()));
		string text7 = text5.Substring(0, text5.LastIndexOf(Class333.smethod_190()));
		string text8 = text5;
		int num = 0;
		while (true)
		{
			if (num != 0)
			{
				text8 = text7 + num + text6;
			}
			if (!File.Exists(text4 + text8))
			{
				break;
			}
			bool flag = false;
			try
			{
				byte[] array = File.ReadAllBytes(text3 + text5);
				byte[] array2 = File.ReadAllBytes(text4 + text8);
				if (array.Length == array2.Length && Enumerable.SequenceEqual(array2, array))
				{
					flag = true;
				}
			}
			catch
			{
				flag = false;
			}
			if (flag)
			{
				break;
			}
			num++;
		}
		if (Form23.smethod_21(text5, text8, text2, out var string_))
		{
			string text9 = Class333.smethod_1469() + text8;
			if (text9 != text)
			{
				setting_0.method_262(text9, bool_0);
			}
		}
		else
		{
			Class23.smethod_3(string_);
		}
	}

	internal List<Setting.ListItems.Struct45> method_96()
	{
		List<Setting.ListItems.Struct45> result = new List<Setting.ListItems.Struct45>();
		if (method_79().Count > 0 && method_79()[0].method_72().Count > 0)
		{
			result = method_79()[0].method_72()[0].method_297().method_102();
		}
		return result;
	}

	internal bool method_97()
	{
		if (m_framework != null)
		{
			return m_framework.aXA >= new Class14(2, 30, 0, 1, 0);
		}
		return false;
	}

	internal bool method_98()
	{
		if (m_framework != null)
		{
			return m_framework.aXA >= new Class14(2, 31, 0, 1, 0);
		}
		return false;
	}

	internal static string smethod_5(Class1.Enum5 enum5_0)
	{
		return enum5_0 switch
		{
			Class1.Enum5.BFH => Class333.ahJ(), 
			Class1.Enum5.BFh => Class333.Bhm(), 
			_ => null, 
		};
	}

	internal static string smethod_6(Class1.Enum5 enum5_0)
	{
		return enum5_0 switch
		{
			Class1.Enum5.BFH => Class333.BhN(), 
			Class1.Enum5.BFh => Class333.Bhn(), 
			_ => null, 
		};
	}

	internal static string smethod_7(Class1.Enum5 enum5_0)
	{
		return enum5_0 switch
		{
			Class1.Enum5.BFH => Class333.BhO(), 
			Class1.Enum5.BFh => Class333.Bho(), 
			_ => null, 
		};
	}

	internal static Class1.Enum5 smethod_8(string string_0)
	{
		if (string_0 == Class333.BhO())
		{
			return Class1.Enum5.BFH;
		}
		if (string_0 == Class333.Bho())
		{
			return Class1.Enum5.BFh;
		}
		return Class1.Enum5.BFI;
	}
}
