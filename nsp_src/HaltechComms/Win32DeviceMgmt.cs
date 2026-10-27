using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

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

	private struct B
	{
		public uint BGS;

		public Guid BGs;

		public uint BGT;

		public nuint BGt;
	}

	private struct b
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

	private const uint CI = 1u;

	private const uint Ci = 1u;

	private const uint CJ = 1u;

	private const int Cj = 1024;

	private const int CK = 2;

	private static b Ck;

	[DllImport("setupapi.dll", EntryPoint = "SetupDiDestroyDeviceInfoList")]
	private static extern int A(nint P_0);

	[DllImport("setupapi.dll", EntryPoint = "SetupDiEnumDeviceInfo", SetLastError = true)]
	private static extern bool A(nint P_0, uint P_1, ref B P_2);

	[DllImport("setupapi.dll", EntryPoint = "SetupDiGetClassDevs", SetLastError = true)]
	private static extern nint A(ref Guid P_0, uint P_1, uint P_2, DiGetClassFlags P_3);

	[DllImport("Setupapi", CharSet = 4, EntryPoint = "SetupDiOpenDevRegKey", SetLastError = true)]
	private static extern nint A(nint P_0, ref B P_1, uint P_2, uint P_3, uint P_4, uint P_5);

	[DllImport("advapi32.dll", CharSet = 3, EntryPoint = "RegQueryValueExW", SetLastError = true)]
	private static extern int A(nint P_0, string P_1, int P_2, out uint P_3, byte[] P_4, ref uint P_5);

	[DllImport("advapi32.dll", CharSet = 2, EntryPoint = "RegCloseKey", ExactSpelling = true, SetLastError = true)]
	private static extern int a(nint P_0);

	[DllImport("kernel32.dll", EntryPoint = "GetLastError")]
	private static extern int A();

	[DllImport("setupapi.dll", EntryPoint = "SetupDiClassGuidsFromName", SetLastError = true)]
	private static extern bool A(string P_0, ref Guid P_1, uint P_2, out uint P_3);

	[DllImport("setupapi.dll", EntryPoint = "SetupDiClassNameFromGuid")]
	private static extern int A(ref Guid P_0, StringBuilder P_1, int P_2, ref int P_3);

	[DllImport("setupapi.dll", CharSet = 4, EntryPoint = "SetupDiGetDeviceRegistryProperty", SetLastError = true)]
	private static extern bool A(nint P_0, ref B P_1, SPDRP P_2, out uint P_3, byte[] P_4, uint P_5, out uint P_6);

	[DllImport("setupapi.dll", EntryPoint = "SetupDiGetDevicePropertyW", SetLastError = true)]
	private static extern bool A(nint P_0, [In] ref B P_1, [In] ref b P_2, out uint P_3, byte[] P_4, uint P_5, out uint P_6, uint P_7);

	static Win32DeviceMgmt()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Ck = default(b);
		Ck.BGU = new Guid(1410045054u, (ushort)35648, (ushort)17852, (byte)168, (byte)162, (byte)106, (byte)11, (byte)137, (byte)76, (byte)189, (byte)162);
		Ck.BGu = 4u;
	}

	public static List<DeviceInfo> GetDeviceInfoPerCOMPort()
	{
		Guid[] array = A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aR());
		List<DeviceInfo> val = new List<DeviceInfo>();
		for (int i = 0; i < array.Length; i++)
		{
			nint num = A(ref array[i], 0u, 0u, DiGetClassFlags.DIGCF_PRESENT);
			if (num == (nint)System.IntPtr.Zero)
			{
				continue;
			}
			try
			{
				uint num2 = 0u;
				while (true)
				{
					B b = default(B);
					b.BGS = (uint)Marshal.SizeOf(typeof(B));
					if (!A(num, num2, ref b))
					{
						break;
					}
					DeviceInfo deviceInfo = default(DeviceInfo);
					deviceInfo.Name = A(num, b);
					deviceInfo.Description = a(num, b);
					deviceInfo.BusDescription = B(num, b);
					val.Add(deviceInfo);
					num2++;
				}
			}
			finally
			{
				A(num);
			}
		}
		return val;
	}

	private static string A(nint P_0, B P_1)
	{
		nint num = A(P_0, ref P_1, 1u, 0u, 1u, 1u);
		if (num != (nint)System.IntPtr.Zero)
		{
			byte[] array = new byte[1024];
			uint num2 = (uint)array.Length;
			try
			{
				A(num, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ar(), 0, out var _, array, ref num2);
			}
			finally
			{
				a(num);
			}
			return Encoding.Unicode.GetString(array, 0, (int)(num2 - 2));
		}
		return string.Empty;
	}

	private static string a(nint P_0, B P_1)
	{
		byte[] array = new byte[1024];
		if (A(P_0, ref P_1, SPDRP.SPDRP_DEVICEDESC, out var _, array, 1024u, out var num2))
		{
			return Encoding.Unicode.GetString(array, 0, (int)(num2 - 2));
		}
		return string.Empty;
	}

	private static string B(nint P_0, B P_1)
	{
		byte[] array = new byte[1024];
		if (A(P_0, ref P_1, ref Ck, out var _, array, 1024u, out var num2, 0u))
		{
			return Encoding.Unicode.GetString(array, 0, (int)(num2 - 2));
		}
		return string.Empty;
	}

	private static Guid[] A(string P_0)
	{
		uint num = 0u;
		Guid[] array = (Guid[])(object)new Guid[1];
		if (A(P_0, ref array[0], 1u, out num) && 1 < num)
		{
			array = (Guid[])(object)new Guid[num];
			A(P_0, ref array[0], num, out num);
		}
		return array;
	}
}
