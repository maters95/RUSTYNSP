using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ns7;

namespace ns6;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Class283
{
	private static ResourceManager BCN;

	private static CultureInfo BCn;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager bbn
	{
		get
		{
			if (BCN == null)
			{
				BCN = new ResourceManager("ns6.Class283", typeof(Class283).Assembly);
			}
			return BCN;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo bbO
	{
		get
		{
			return BCn;
		}
		set
		{
			BCn = value;
		}
	}

	internal Class283()
	{
	}

	[SpecialName]
	internal static Bitmap smethod_0()
	{
		return (Bitmap)bbn.GetObject(Class333.aVR(), BCn);
	}

	[SpecialName]
	internal static Bitmap smethod_1()
	{
		return (Bitmap)bbn.GetObject(Class333.aVr(), BCn);
	}

	[SpecialName]
	internal static Bitmap smethod_2()
	{
		return (Bitmap)bbn.GetObject(Class333.aVS(), BCn);
	}
}
