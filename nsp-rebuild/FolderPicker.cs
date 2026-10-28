using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

public class FolderPicker
{
	[ComImport]
	[Guid("DC1C5A9C-E88A-4dde-A5A1-60F82A20AEF7")]
	private class Class0
	{
	}

	[ComImport]
	[Guid("42f85136-db7e-439c-85f1-e4075d135fc8")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface Interface0
	{
		[PreserveSig]
		int imethod_0(nint intptr_0);

		[PreserveSig]
		int imethod_1();

		[PreserveSig]
		int imethod_2(int int_0);

		[PreserveSig]
		int imethod_3(out int int_0);

		[PreserveSig]
		int imethod_4();

		[PreserveSig]
		int imethod_5();

		[PreserveSig]
		int imethod_6(Enum1 enum1_0);

		[PreserveSig]
		int imethod_7(out Enum1 enum1_0);

		[PreserveSig]
		int imethod_8(Interface1 interface1_0);

		[PreserveSig]
		int imethod_9(Interface1 interface1_0);

		[PreserveSig]
		int imethod_10(out Interface1 interface1_0);

		[PreserveSig]
		int imethod_11(out Interface1 interface1_0);

		[PreserveSig]
		int imethod_12([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[PreserveSig]
		int imethod_13([MarshalAs(UnmanagedType.LPWStr)] out string string_0);

		[PreserveSig]
		int imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[PreserveSig]
		int imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[PreserveSig]
		int imethod_16([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[PreserveSig]
		int imethod_17(out Interface1 interface1_0);

		[PreserveSig]
		int imethod_18(Interface1 interface1_0, int int_0);

		[PreserveSig]
		int imethod_19([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[PreserveSig]
		int imethod_20(int int_0);

		[PreserveSig]
		int imethod_21();

		[PreserveSig]
		int imethod_22();

		[PreserveSig]
		int imethod_23([MarshalAs(UnmanagedType.IUnknown)] object object_0);

		[PreserveSig]
		int imethod_24([MarshalAs(UnmanagedType.IUnknown)] out object object_0);

		[PreserveSig]
		int imethod_25([MarshalAs(UnmanagedType.IUnknown)] out object object_0);
	}

	[ComImport]
	[Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface Interface1
	{
		[PreserveSig]
		int imethod_0();

		[PreserveSig]
		int imethod_1();

		[PreserveSig]
		int imethod_2(Enum0 enum0_0, [MarshalAs(UnmanagedType.LPWStr)] out string string_0);

		[PreserveSig]
		int imethod_3();

		[PreserveSig]
		int imethod_4();
	}

	private enum Enum0 : uint
	{
		BEu = 2147794944u,
		BEV = 2147647488u,
		BEv = 2147844096u,
		BEW = 0u,
		BEw = 2148007937u,
		BEX = 2147684353u,
		BEx = 2147991553u,
		BEY = 2147581953u,
		BEy = 2147909632u
	}

	[Flags]
	private enum Enum1
	{
		BEZ = 2,
		BEz = 4,
		BeA = 8,
		Bea = 0x20,
		BeB = 0x40,
		Beb = 0x80,
		BeC = 0x100,
		Bec = 0x200,
		BeD = 0x800,
		Bed = 0x1000,
		BeE = 0x2000,
		Bee = 0x4000,
		BeF = 0x8000,
		Bef = 0x10000,
		BeG = 0x20000,
		Beg = 0x40000,
		BeH = 0x100000,
		Beh = 0x200000,
		BeI = 0x2000000,
		Bei = 0x10000000,
		BeJ = 0x20000000,
		Bej = 0x40000000,
		BeK = int.MinValue
	}

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private string string_4;

	[CompilerGenerated]
	private string string_5;

	private const int int_0 = -2147023673;

	public virtual string ResultPath
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		protected set
		{
			string_0 = value;
		}
	}

	public virtual string ResultName
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		protected set
		{
			string_1 = value;
		}
	}

	public virtual string InputPath
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public virtual bool ForceFileSystem
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public virtual string Title
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public virtual string OkButtonLabel
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	public virtual string FileNameLabel
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
		[CompilerGenerated]
		set
		{
			string_5 = value;
		}
	}

	protected virtual int SetOptions(int options)
	{
		if (ForceFileSystem)
		{
			options |= 0x40;
		}
		return options;
	}

	public virtual bool? ShowDialog(nint owner, bool throwOnError = false)
	{
		Interface0 @interface = (Interface0)new Class0();
		if (!string.IsNullOrEmpty(InputPath))
		{
			if (smethod_0(SHCreateItemFromParsingName(InputPath, null, typeof(Interface1).GUID, out var interface1_), throwOnError) != 0)
			{
				return null;
			}
			@interface.imethod_9(interface1_);
		}
		Enum1 @enum = Enum1.Bea;
		@enum = (Enum1)SetOptions(32);
		@interface.imethod_6(@enum);
		if (Title != null)
		{
			@interface.imethod_14(Title);
		}
		if (OkButtonLabel != null)
		{
			@interface.imethod_15(OkButtonLabel);
		}
		if (FileNameLabel != null)
		{
			@interface.imethod_12(FileNameLabel);
		}
		if (owner == IntPtr.Zero)
		{
			owner = Process.GetCurrentProcess().MainWindowHandle;
			if (owner == IntPtr.Zero)
			{
				owner = GetDesktopWindow();
			}
		}
		int num = @interface.imethod_0(owner);
		if (num == -2147023673)
		{
			return null;
		}
		if (smethod_0(num, throwOnError) != 0)
		{
			return null;
		}
		if (smethod_0(@interface.imethod_17(out var interface1_2), throwOnError) != 0)
		{
			return null;
		}
		if (smethod_0(interface1_2.imethod_2(Enum0.BEV, out var text), throwOnError) != 0)
		{
			return null;
		}
		ResultPath = text;
		if (smethod_0(interface1_2.imethod_2(Enum0.BEu, out text), bool_1: false) == 0)
		{
			ResultName = text;
		}
		return true;
	}

	private static int smethod_0(int int_1, bool bool_1)
	{
		if (int_1 != 0 && bool_1)
		{
			Marshal.ThrowExceptionForHR(int_1);
		}
		return int_1;
	}

	[DllImport("shell32")]
	private static extern int SHCreateItemFromParsingName([MarshalAs(UnmanagedType.LPWStr)] string string_6, IBindCtx ibindCtx_0, [MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, out Interface1 interface1_0);

	[DllImport("user32")]
	private static extern nint GetDesktopWindow();
}
