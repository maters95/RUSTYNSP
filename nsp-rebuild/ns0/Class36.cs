using System;
using System.Globalization;
using Microsoft.Win32;
using ns7;

namespace ns0;

internal class Class36
{
	public enum Enum20
	{
		BHd,
		BHE
	}

	public static Enum20 enum20_0;

	public static void smethod_0()
	{
		int? num = smethod_1();
		if (num.HasValue)
		{
			enum20_0 = (Enum20)num.Value;
			return;
		}
		if (RegionInfo.CurrentRegion.IsMetric)
		{
			enum20_0 = Enum20.BHd;
		}
		else
		{
			enum20_0 = Enum20.BHE;
		}
		smethod_2(enum20_0);
	}

	private static int? smethod_1()
	{
		int? result = null;
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(Class333.smethod_212());
			if (registryKey2 != null)
			{
				object value = registryKey2.GetValue(Class333.smethod_213());
				if (value != null && value.GetType() == typeof(int))
				{
					result = (int)value;
					return result;
				}
				return result;
			}
			Class23.smethod_3(Class333.smethod_214());
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_215() + ex.Message);
		}
		return result;
	}

	private static void smethod_2(Enum20 enum20_1)
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
			using RegistryKey registryKey2 = registryKey.CreateSubKey(Class333.smethod_212(), writable: true);
			if (registryKey2 != null)
			{
				registryKey2.SetValue(Class333.smethod_213(), (int)enum20_1);
			}
			else
			{
				Class23.smethod_3(Class333.smethod_216());
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_217() + ex.Message);
		}
	}
}
