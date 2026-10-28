using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using ns7;

namespace HaltechComms;

public static class Win32DeviceMgmt
{
	[Flags]
	public enum DiGetClassFlags : uint
	{
		DIGCF_DEFAULT = 1u,
		DIGCF_PRESENT = 2u,
		DIGCF_ALLCLASSES = 4u,
		DIGCF_PROFILE = 8u,
		DIGCF_DEVICEINTERFACE = 0x10u
	}

	public enum SPDRP : uint
	{
		SPDRP_DEVICEDESC,
		SPDRP_HARDWAREID,
		SPDRP_COMPATIBLEIDS,
		SPDRP_UNUSED0,
		SPDRP_SERVICE,
		SPDRP_UNUSED1,
		SPDRP_UNUSED2,
		SPDRP_CLASS,
		SPDRP_CLASSGUID,
		SPDRP_DRIVER,
		SPDRP_CONFIGFLAGS,
		SPDRP_MFG,
		SPDRP_FRIENDLYNAME,
		SPDRP_LOCATION_INFORMATION,
		SPDRP_PHYSICAL_DEVICE_OBJECT_NAME,
		SPDRP_CAPABILITIES,
		SPDRP_UI_NUMBER,
		SPDRP_UPPERFILTERS,
		SPDRP_LOWERFILTERS,
		SPDRP_BUSTYPEGUID,
		SPDRP_LEGACYBUSTYPE,
		SPDRP_BUSNUMBER,
		SPDRP_ENUMERATOR_NAME,
		SPDRP_SECURITY,
		SPDRP_SECURITY_SDS,
		SPDRP_DEVTYPE,
		SPDRP_EXCLUSIVE,
		SPDRP_CHARACTERISTICS,
		SPDRP_ADDRESS,
		SPDRP_UI_NUMBER_DESC_FORMAT,
		SPDRP_DEVICE_POWER_DATA,
		SPDRP_REMOVAL_POLICY,
		SPDRP_REMOVAL_POLICY_HW_DEFAULT,
		SPDRP_REMOVAL_POLICY_OVERRIDE,
		SPDRP_INSTALL_STATE,
		SPDRP_LOCATION_PATHS
	}

	private struct Struct3
	{
		public uint BGS;

		public Guid BGs;

		public uint BGT;

		public nuint BGt;
	}

	private struct Struct4
	{
		public Guid BGU;

		public uint BGu;
	}

	public struct DeviceInfo
	{
		public string Name;

		public string Description;

		public string BusDescription;
	}

	private const uint uint_0 = 1u;

	private const uint uint_1 = 1u;

	private const uint uint_2 = 1u;

	private const int int_0 = 1024;

	private const int int_1 = 2;

	private static Struct4 struct4_0;

	[DllImport("setupapi.dll")]
	private static extern int SetupDiDestroyDeviceInfoList(nint intptr_0);

	[DllImport("setupapi.dll", SetLastError = true)]
	private static extern bool SetupDiEnumDeviceInfo(nint intptr_0, uint uint_3, ref Struct3 struct3_0);

	[DllImport("setupapi.dll", SetLastError = true)]
	private static extern nint SetupDiGetClassDevs(ref Guid guid_0, uint uint_3, uint uint_4, DiGetClassFlags diGetClassFlags_0);

	[DllImport("Setupapi", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern nint SetupDiOpenDevRegKey(nint intptr_0, ref Struct3 struct3_0, uint uint_3, uint uint_4, uint uint_5, uint uint_6);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int RegQueryValueExW(nint intptr_0, string string_0, int int_2, out uint uint_3, byte[] byte_0, ref uint uint_4);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegCloseKey(nint intptr_0);

	[DllImport("kernel32.dll")]
	private static extern int GetLastError();

	[DllImport("setupapi.dll", SetLastError = true)]
	private static extern bool SetupDiClassGuidsFromName(string string_0, ref Guid guid_0, uint uint_3, out uint uint_4);

	[DllImport("setupapi.dll")]
	private static extern int SetupDiClassNameFromGuid(ref Guid guid_0, StringBuilder stringBuilder_0, int int_2, ref int int_3);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool SetupDiGetDeviceRegistryProperty(nint intptr_0, ref Struct3 struct3_0, SPDRP spdrp_0, out uint uint_3, byte[] byte_0, uint uint_4, out uint uint_5);

	[DllImport("setupapi.dll", SetLastError = true)]
	private static extern bool SetupDiGetDevicePropertyW(nint intptr_0, [In] ref Struct3 struct3_0, [In] ref Struct4 struct4_1, out uint uint_3, byte[] byte_0, uint uint_4, out uint uint_5, uint uint_6);

	static Win32DeviceMgmt()
	{
		struct4_0 = default;
		struct4_0.BGU = new Guid(1410045054u, 35648, 17852, 168, 162, 106, 11, 137, 76, 189, 162);
		struct4_0.BGu = 4u;
	}

	public static List<DeviceInfo> GetDeviceInfoPerCOMPort()
	{
		Guid[] array = smethod_3(Class333.smethod_87());
		List<DeviceInfo> list = new List<DeviceInfo>();
		for (int i = 0; i < array.Length; i++)
		{
			nint num = SetupDiGetClassDevs(ref array[i], 0u, 0u, DiGetClassFlags.DIGCF_PRESENT);
			if (num == IntPtr.Zero)
			{
				continue;
			}
			try
			{
				uint num2 = 0u;
				while (true)
				{
					Struct3 struct3_ = new Struct3
					{
						BGS = (uint)Marshal.SizeOf(typeof(Struct3))
					};
					if (SetupDiEnumDeviceInfo(num, num2, ref struct3_))
					{
						list.Add(new DeviceInfo
						{
							Name = smethod_0(num, struct3_),
							Description = smethod_1(num, struct3_),
							BusDescription = smethod_2(num, struct3_)
						});
						num2++;
						continue;
					}
					break;
				}
			}
			finally
			{
				SetupDiDestroyDeviceInfoList(num);
			}
		}
		return list;
	}

	private static string smethod_0(nint intptr_0, Struct3 struct3_0)
	{
		nint num = SetupDiOpenDevRegKey(intptr_0, ref struct3_0, 1u, 0u, 1u, 1u);
		if (num != IntPtr.Zero)
		{
			byte[] array = new byte[1024];
			uint uint_ = (uint)array.Length;
			try
			{
				RegQueryValueExW(num, Class333.smethod_88(), 0, out var _, array, ref uint_);
			}
			finally
			{
				RegCloseKey(num);
			}
			return Encoding.Unicode.GetString(array, 0, (int)(uint_ - 2));
		}
		return string.Empty;
	}

	private static string smethod_1(nint intptr_0, Struct3 struct3_0)
	{
		byte[] array = new byte[1024];
		if (SetupDiGetDeviceRegistryProperty(intptr_0, ref struct3_0, SPDRP.SPDRP_DEVICEDESC, out var _, array, 1024u, out var uint_2))
		{
			return Encoding.Unicode.GetString(array, 0, (int)(uint_2 - 2));
		}
		return string.Empty;
	}

	private static string smethod_2(nint intptr_0, Struct3 struct3_0)
	{
		byte[] array = new byte[1024];
		if (SetupDiGetDevicePropertyW(intptr_0, ref struct3_0, ref struct4_0, out var _, array, 1024u, out var uint_2, 0u))
		{
			return Encoding.Unicode.GetString(array, 0, (int)(uint_2 - 2));
		}
		return string.Empty;
	}

	private static Guid[] smethod_3(string string_0)
	{
		uint uint_ = 0u;
		Guid[] array = new Guid[1];
		if (SetupDiClassGuidsFromName(string_0, ref array[0], 1u, out uint_) && 1 < uint_)
		{
			array = new Guid[uint_];
			SetupDiClassGuidsFromName(string_0, ref array[0], uint_, out uint_);
		}
		return array;
	}
}
