using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

public class FolderPicker
{
	[ComImport]
	[Guid("DC1C5A9C-E88A-4dde-A5A1-60F82A20AEF7")]
	private class A
	{
	}

	[ComImport]
	[Guid("42f85136-db7e-439c-85f1-e4075d135fc8")]
	[InterfaceType(/*Could not decode attribute arguments.*/)]
	private interface a
	{
		[PreserveSig]
		int A(nint P_0);

		[PreserveSig]
		int A();

		[PreserveSig]
		int A(int P_0);

		[PreserveSig]
		int A(out int P_0);

		[PreserveSig]
		int a();

		[PreserveSig]
		int B();

		[PreserveSig]
		int A(C P_0);

		[PreserveSig]
		int A(out C P_0);

		[PreserveSig]
		int A(B P_0);

		[PreserveSig]
		int a(B P_0);

		[PreserveSig]
		int A(out B P_0);

		[PreserveSig]
		int a(out B P_0);

		[PreserveSig]
		int A([MarshalAs(21)] string P_0);

		[PreserveSig]
		int A([MarshalAs(21)] out string P_0);

		[PreserveSig]
		int a([MarshalAs(21)] string P_0);

		[PreserveSig]
		int B([MarshalAs(21)] string P_0);

		[PreserveSig]
		int b([MarshalAs(21)] string P_0);

		[PreserveSig]
		int B(out B P_0);

		[PreserveSig]
		int A(B P_0, int P_1);

		[PreserveSig]
		int C([MarshalAs(21)] string P_0);

		[PreserveSig]
		int a(int P_0);

		[PreserveSig]
		int b();

		[PreserveSig]
		int C();

		[PreserveSig]
		int A([MarshalAs(25)] object P_0);

		[PreserveSig]
		int A([MarshalAs(25)] out object P_0);

		[PreserveSig]
		int a([MarshalAs(25)] out object P_0);
	}

	[ComImport]
	[Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
	[InterfaceType(/*Could not decode attribute arguments.*/)]
	private interface B
	{
		[PreserveSig]
		int A();

		[PreserveSig]
		int a();

		[PreserveSig]
		int A(b P_0, [MarshalAs(21)] out string P_1);

		[PreserveSig]
		int B();

		[PreserveSig]
		int b();
	}

	private enum b : uint
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
	private enum C
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
		BeK = -2147483648
	}

	[CompilerGenerated]
	private string m_A;

	[CompilerGenerated]
	private string m_a;

	[CompilerGenerated]
	private string m_B;

	[CompilerGenerated]
	private bool m_b;

	[CompilerGenerated]
	private string m_C;

	[CompilerGenerated]
	private string c;

	[CompilerGenerated]
	private string D;

	private const int d = -2147023673;

	public virtual string ResultPath
	{
		[CompilerGenerated]
		get
		{
			return this.m_A;
		}
		[CompilerGenerated]
		protected set
		{
			this.m_A = value;
		}
	}

	public virtual string ResultName
	{
		[CompilerGenerated]
		get
		{
			return this.m_a;
		}
		[CompilerGenerated]
		protected set
		{
			this.m_a = value;
		}
	}

	public virtual string InputPath
	{
		[CompilerGenerated]
		get
		{
			return this.m_B;
		}
		[CompilerGenerated]
		set
		{
			this.m_B = value;
		}
	}

	public virtual bool ForceFileSystem
	{
		[CompilerGenerated]
		get
		{
			return this.m_b;
		}
		[CompilerGenerated]
		set
		{
			this.m_b = value;
		}
	}

	public virtual string Title
	{
		[CompilerGenerated]
		get
		{
			return this.m_C;
		}
		[CompilerGenerated]
		set
		{
			this.m_C = value;
		}
	}

	public virtual string OkButtonLabel
	{
		[CompilerGenerated]
		get
		{
			return c;
		}
		[CompilerGenerated]
		set
		{
			c = value;
		}
	}

	public virtual string FileNameLabel
	{
		[CompilerGenerated]
		get
		{
			return D;
		}
		[CompilerGenerated]
		set
		{
			D = value;
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
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		a a = (a)new A();
		if (!string.IsNullOrEmpty(InputPath))
		{
			if (A(A(InputPath, null, typeof(B).GUID, out var b), throwOnError) != 0)
			{
				return null;
			}
			a.a(b);
		}
		C options = FolderPicker.C.Bea;
		options = (C)SetOptions((int)options);
		a.A(options);
		if (Title != null)
		{
			a.a(Title);
		}
		if (OkButtonLabel != null)
		{
			a.B(OkButtonLabel);
		}
		if (FileNameLabel != null)
		{
			a.A(FileNameLabel);
		}
		if (owner == (nint)System.IntPtr.Zero)
		{
			owner = Process.GetCurrentProcess().MainWindowHandle;
			if (owner == (nint)System.IntPtr.Zero)
			{
				owner = A();
			}
		}
		int num = a.A(owner);
		if (num == -2147023673)
		{
			return null;
		}
		if (A(num, throwOnError) != 0)
		{
			return null;
		}
		if (A(a.B(out var b2), throwOnError) != 0)
		{
			return null;
		}
		if (A(b2.A(FolderPicker.b.BEV, out var text), throwOnError) != 0)
		{
			return null;
		}
		ResultPath = text;
		if (A(b2.A(FolderPicker.b.BEu, out text), false) == 0)
		{
			ResultName = text;
		}
		return true;
	}

	private static int A(int P_0, bool P_1)
	{
		if (P_0 != 0 && P_1)
		{
			Marshal.ThrowExceptionForHR(P_0);
		}
		return P_0;
	}

	[DllImport("shell32", EntryPoint = "SHCreateItemFromParsingName")]
	private static extern int A([MarshalAs(21)] string P_0, IBindCtx P_1, [MarshalAs(43)] Guid P_2, out B P_3);

	[DllImport("user32", EntryPoint = "GetDesktopWindow")]
	private static extern nint A();
}
