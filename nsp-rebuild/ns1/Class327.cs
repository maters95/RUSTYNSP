using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using ns0;
using ns4;
using ns7;

namespace ns1;

internal class Class327
{
	[CompilerGenerated]
	private sealed class Class328
	{
		public string Btm;

		internal void method_0(object sender, DataReceivedEventArgs e)
		{
			Btm += e.Data;
		}
	}

	private static string Bdq = Form23.string_2 + Class333.smethod_522() + Form23.string_18;

	private static string BdR = Bdq + Class333.azF();

	private static string Bdr = Bdq + Class333.azf();

	private static char[] BdS = new char[10] { '[', ']', '^', '$', '.', '?', '*', '+', '(', ')' };

	internal static char[] Bds = new char[5] { '\\', '>', '<', '|', '&' };

	private static Encoding BdT = Encoding.GetEncoding(20127);

	private static ProcessStartInfo smethod_0(string string_0, string string_1)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		if (string_0 != null)
		{
			processStartInfo.FileName = string_0;
		}
		if (string_1 != null)
		{
			processStartInfo.Arguments = string_1;
		}
		processStartInfo.UseShellExecute = false;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		return processStartInfo;
	}

	internal static bool smethod_1(string string_0)
	{
		bool flag = false;
		for (int i = 0; i < Bds.Length; i++)
		{
			if (string_0.Contains(Bds[i]))
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			return true;
		}
		return false;
	}

	internal static bool smethod_2(string string_0, string string_1)
	{
		if (string_0.Length >= 1 && string_1.Length >= 8 && !smethod_1(string_0))
		{
			string text = BitConverter.ToString(BdT.GetBytes(string_0));
			text = text.Replace(Class333.smethod_186(), Class333.smethod_102());
			string contents = Class333.aZZ() + string_0 + Class333.aZz() + text + Class333.azA() + string_0 + Class333.aza() + string_1 + Class333.azB();
			try
			{
				File.WriteAllText(BdR, contents, BdT);
				bool result = smethod_3(BdR, string_0);
				File.Delete(BdR);
				return result;
			}
			catch (Exception ex)
			{
				Class23.smethod_3(ex.ToString());
				return false;
			}
		}
		return false;
	}

	private static bool smethod_3(string string_0, string string_1)
	{
		bool result = false;
		if (string_0 != null && string_1 != null && string_0.Length >= 1 && string_1.Length >= 1)
		{
			Process process = new Process();
			process.StartInfo = smethod_0(Class333.smethod_104(), Class333.azb() + string_0 + Class333.smethod_180());
			string Btm = null;
			string text = null;
			process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
			{
				Btm += e.Data;
			};
			try
			{
				process.Start();
				process.BeginErrorReadLine();
				text = process.StandardOutput.ReadToEnd();
				process.WaitForExit();
				_ = process.ExitCode;
				string text2 = Class333.azC();
				for (int num = 0; num < BdS.Length; num++)
				{
					text2 = text2 + Class333.smethod_176() + BdS[num];
				}
				text2 += Class333.azc();
				string[] array = Regex.Split(string_1, text2);
				string text3 = Class333.smethod_102();
				for (int num2 = 0; num2 < array.Length; num2++)
				{
					if (array[num2].Length <= 0)
					{
						continue;
					}
					bool flag = false;
					int num3 = 0;
					for (num3 = 0; num3 < BdS.Length; num3++)
					{
						if (array[num2][0] == BdS[num3])
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						array[num2] = Class333.smethod_176() + array[num2];
					}
					text3 += array[num2];
				}
				text3 = text3.Trim(' ');
				if (new Regex(Class333.azD() + text3 + Class333.azd(), RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled).Matches(text).Count > 0)
				{
					Class23.smethod_3(Class333.azE());
					result = true;
				}
				else
				{
					Class23.smethod_3(Class333.aze());
				}
				return result;
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.smethod_114() + ex.Message);
				return false;
			}
		}
		return false;
	}
}
