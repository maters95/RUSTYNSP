using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ns7;

namespace NSP.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class Resources
{
	private static ResourceManager BCO;

	private static CultureInfo BCo;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (BCO == null)
			{
				BCO = new ResourceManager("NSP.Properties.Resources", typeof(Resources).Assembly);
			}
			return BCO;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return BCo;
		}
		set
		{
			BCo = value;
		}
	}

	public static Bitmap HaltechBigLogo => (Bitmap)ResourceManager.GetObject(Class333.aVs(), BCo);

	internal Resources()
	{
	}
}
