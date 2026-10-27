using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace NSP.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class Resources
{
	private static ResourceManager BCO;

	private static CultureInfo BCo;

	[EditorBrowsable(/*Could not decode attribute arguments.*/)]
	public static ResourceManager ResourceManager
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			if (BCO == null)
			{
				BCO = new ResourceManager("NSP.Properties.Resources", typeof(Resources).Assembly);
			}
			return BCO;
		}
	}

	[EditorBrowsable(/*Could not decode attribute arguments.*/)]
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

	public static Bitmap HaltechBigLogo => (Bitmap)ResourceManager.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVs(), BCo);

	internal Resources()
	{
	}
}
