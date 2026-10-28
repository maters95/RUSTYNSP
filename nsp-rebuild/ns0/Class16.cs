using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;
using System.Windows.Forms;
using NSP.Properties;
using ns1;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns0;

[SupportedOSPlatform("windows")]
internal static class Class16
{
	[CompilerGenerated]
	private static class Class17
	{
		public static UnhandledExceptionEventHandler BgL;

		public static ThreadExceptionEventHandler Bgl;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		Class242.smethod_0();
		bool flag = false;
		foreach (string text in args)
		{
			if (text.StartsWith(Class333.smethod_144()))
			{
				flag = bool.Parse(text.Substring(Class333.smethod_144().Length));
			}
		}
		if (!flag)
		{
			Settings.Default.Upgrade();
			Settings.Default.Save();
			Class23.smethod_0();
			Application.SetDefaultFont(new Font(Class333.smethod_145(), 8.25f));
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		}
		bool flag2 = false;
		bool bool_ = false;
		string string_ = null;
		bool bool_2 = false;
		string string_2 = null;
		bool bool_3 = false;
		if (!(flag2 = smethod_4(args, ref bool_, ref string_, ref bool_2)))
		{
			flag2 = smethod_5(args, ref bool_, ref string_2, ref bool_3);
		}
		if (!flag2)
		{
			smethod_13(args);
		}
		Form23 form = new Form23(flag, !bool_);
		if (!flag2)
		{
			flag2 = smethod_2(args, form);
		}
		if (!flag2)
		{
			smethod_3(args);
		}
		if (!flag2)
		{
			flag2 = smethod_1(args, form);
		}
		if (!flag2)
		{
			flag2 = smethod_6(args, form);
		}
		if (!flag2)
		{
			flag2 = smethod_7(args, form);
		}
		if (!flag2)
		{
			flag2 = smethod_8(args, form);
		}
		if (!flag2)
		{
			flag2 = smethod_9(args, form);
		}
		if (!flag2)
		{
			flag2 = smethod_12(args, form);
		}
		if (!flag2)
		{
			flag2 = smethod_10(args, form);
		}
		if (!flag2)
		{
			flag2 = smethod_11(args, form);
		}
		if (!flag2)
		{
			smethod_0(args, form);
		}
		form.string_25 = string_;
		form.bool_6 = bool_2;
		form.string_26 = string_2;
		form.bool_7 = bool_3;
		if (Form23.bool_14)
		{
			if (!string.IsNullOrEmpty(string_))
			{
				new Class290(string_, bool_2).method_0();
			}
			if (!string.IsNullOrEmpty(string_2))
			{
				new Class293(string_2, bool_3).method_0();
			}
		}
		try
		{
			if (Form23.bool_14)
			{
				Application.Run();
			}
			else
			{
				Application.Run(form);
			}
		}
		finally
		{
			if (!flag)
			{
				Class23.smethod_1();
			}
			AppDomain.CurrentDomain.UnhandledException -= smethod_15;
			Application.ThreadException -= smethod_16;
		}
	}

	private static void smethod_0(string[] string_0, Form23 form23_0)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < string_0.Length)
			{
				text = string_0[num];
				if (text.EndsWith(Class333.smethod_146()))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		form23_0.string_32 = text;
	}

	private static bool smethod_1(string[] string_0, Form23 form23_0)
	{
		foreach (string text in string_0)
		{
			if (text.StartsWith(Class333.smethod_147()))
			{
				form23_0.string_27 = text.Substring(Class333.smethod_147().Length);
				break;
			}
		}
		if (form23_0.string_27 != null)
		{
			foreach (string text2 in string_0)
			{
				if (text2.StartsWith(Class333.smethod_148()))
				{
					form23_0.bool_8 = bool.Parse(text2.Substring(Class333.smethod_148().Length));
				}
				else if (text2.StartsWith(Class333.smethod_149()))
				{
					form23_0.bool_9 = bool.Parse(text2.Substring(Class333.smethod_149().Length));
				}
				else if (text2.StartsWith(Class333.smethod_150()))
				{
					form23_0.bool_10 = bool.Parse(text2.Substring(Class333.smethod_150().Length));
				}
				else if (text2.StartsWith(Class333.smethod_151()))
				{
					string[] array = text2.Substring(Class333.smethod_151().Length).Split(',');
					foreach (string item in array)
					{
						form23_0.list_1.Add(item);
					}
				}
			}
			return true;
		}
		return false;
	}

	private static bool smethod_2(string[] string_0, Form23 form23_0)
	{
		bool flag = false;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] == Class333.smethod_152())
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			try
			{
				foreach (string text in string_0)
				{
					if (text.StartsWith(Class333.smethod_153()))
					{
						form23_0.string_21 = text.Substring(Class333.smethod_153().Length);
						if (!string.IsNullOrEmpty(form23_0.string_21))
						{
							flag2 = true;
						}
					}
					else if (text.StartsWith(Class333.smethod_154()))
					{
						form23_0.string_22 = text.Substring(Class333.smethod_154().Length);
						if (!string.IsNullOrEmpty(form23_0.string_22))
						{
							flag3 = true;
						}
					}
					else if (text.StartsWith(Class333.smethod_155()))
					{
						form23_0.string_23 = text.Substring(Class333.smethod_155().Length);
						if (!string.IsNullOrEmpty(form23_0.string_23))
						{
							flag4 = true;
						}
					}
				}
				if (flag2 & flag3 & flag4)
				{
					form23_0.bool_4 = true;
				}
			}
			catch
			{
			}
			return true;
		}
		return false;
	}

	private static void smethod_3(string[] string_0)
	{
		foreach (string text in string_0)
		{
			if (text.StartsWith(Class333.smethod_156()))
			{
				Class1.smethod_29(byte.Parse(text.Substring(Class333.smethod_156().Length)));
			}
			else if (text.StartsWith(Class333.smethod_157()))
			{
				Class1.smethod_31(byte.Parse(text.Substring(Class333.smethod_157().Length)));
			}
		}
	}

	private static bool smethod_4(string[] string_0, ref bool bool_0, ref string string_1, ref bool bool_1)
	{
		return false;
	}

	private static bool smethod_5(string[] string_0, ref bool bool_0, ref string string_1, ref bool bool_1)
	{
		return false;
	}

	private static bool smethod_6(string[] string_0, Form23 form23_0)
	{
		string text = null;
		foreach (string text2 in string_0)
		{
			if (text2.ToLower().StartsWith(Class333.smethod_158()))
			{
				if (text2.Length > Class333.smethod_158().Length)
				{
					text = text2.Substring(Class333.smethod_158().Length);
				}
				break;
			}
		}
		if (text != null)
		{
			foreach (string text3 in string_0)
			{
				if (text3.ToLower().StartsWith(Class333.smethod_159()))
				{
					string[] array = text3.Substring(Class333.smethod_159().Length).Split('.');
					form23_0.class14_0 = new Class14(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]), int.Parse(array[3]), 0);
					form23_0.string_24 = text;
				}
				else if (text3 == Class333.smethod_160())
				{
					form23_0.bool_5 = true;
				}
				else if (text3.ToLower().StartsWith(Class333.smethod_161()))
				{
					string[] array2 = text3.Substring(Class333.smethod_161().Length).Split(',');
					int key = int.Parse(array2[0].Substring(Class333.smethod_162().Length));
					int value = int.Parse(array2[1].Substring(Class333.smethod_163().Length));
					if (form23_0.dictionary_2 == null)
					{
						form23_0.dictionary_2 = new Dictionary<int, int>();
					}
					form23_0.dictionary_2.Add(key, value);
				}
				else
				{
					if (!text3.ToLower().StartsWith(Class333.smethod_164()))
					{
						continue;
					}
					string[] array3 = text3.Substring(Class333.smethod_164().Length).Split(',');
					int key2 = int.Parse(array3[0].Substring(Class333.smethod_162().Length));
					List<int> list = new List<int>();
					for (int k = 1; k < array3.Length; k++)
					{
						if (k == 1)
						{
							list.Add(int.Parse(array3[k].Substring(Class333.smethod_165().Length)));
						}
						else
						{
							list.Add(int.Parse(array3[k]));
						}
					}
					if (form23_0.dictionary_3 == null)
					{
						form23_0.dictionary_3 = new Dictionary<int, List<int>>();
					}
					form23_0.dictionary_3.Add(key2, list);
				}
			}
			return true;
		}
		return false;
	}

	private static bool smethod_7(string[] string_0, Form23 form23_0)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < string_0.Length)
			{
				text = string_0[num];
				if (text.StartsWith(Class333.smethod_166()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		form23_0.string_28 = text.Substring(Class333.smethod_166().Length);
		return true;
	}

	private static bool smethod_8(string[] string_0, Form23 form23_0)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] == Class333.smethod_167())
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		form23_0.bool_11 = true;
		return true;
	}

	private static bool smethod_9(string[] string_0, Form23 form23_0)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < string_0.Length)
			{
				text = string_0[num];
				if (text.StartsWith(Class333.smethod_168()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		form23_0.string_29 = text.Substring(Class333.smethod_168().Length);
		return true;
	}

	private static bool smethod_10(string[] string_0, Form23 form23_0)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < string_0.Length)
			{
				text = string_0[num];
				if (text.StartsWith(Class333.smethod_169()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		form23_0.string_30 = text.Substring(Class333.smethod_169().Length);
		return true;
	}

	private static bool smethod_11(string[] string_0, Form23 form23_0)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] == Class333.smethod_170())
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		form23_0.bool_13 = true;
		return true;
	}

	private static bool smethod_12(string[] string_0, Form23 form23_0)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < string_0.Length)
			{
				text = string_0[num];
				if (text.StartsWith(Class333.smethod_171()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		form23_0.string_31 = text.Substring(Class333.smethod_171().Length);
		return true;
	}

	private static void smethod_13(string[] string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num].Contains(Class333.smethod_172()))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Class88.BIg = true;
	}

	private static void smethod_14(Exception exception_0)
	{
		Class23.smethod_3(exception_0.Message);
		if (exception_0.StackTrace != null)
		{
			Class23.smethod_3(exception_0.StackTrace);
		}
		if (exception_0.InnerException != null)
		{
			Class23.smethod_3(exception_0.InnerException.Message);
			if (exception_0.InnerException.StackTrace != null)
			{
				Class23.smethod_3(exception_0.InnerException.StackTrace);
			}
		}
	}

	private static void smethod_15(object sender, UnhandledExceptionEventArgs e)
	{
		if (e.ExceptionObject is Exception)
		{
			smethod_14(e.ExceptionObject as Exception);
		}
		Application.Exit();
	}

	private static void smethod_16(object sender, ThreadExceptionEventArgs e)
	{
		if (e.Exception != null)
		{
			smethod_14(e.Exception);
		}
		Application.Exit();
	}
}
