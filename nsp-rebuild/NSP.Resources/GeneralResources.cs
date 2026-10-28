using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ns7;

namespace NSP.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class GeneralResources
{
	private static ResourceManager BCJ;

	private static CultureInfo BCj;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (BCJ == null)
			{
				BCJ = new ResourceManager("NSP.Resources.GeneralResources", typeof(GeneralResources).Assembly);
			}
			return BCJ;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return BCj;
		}
		set
		{
			BCj = value;
		}
	}

	public static Bitmap BackArrow => (Bitmap)ResourceManager.GetObject(Class333.atg(), BCj);

	public static Bitmap ChecklistCross => (Bitmap)ResourceManager.GetObject(Class333.atH(), BCj);

	public static Bitmap ChecklistTick => (Bitmap)ResourceManager.GetObject(Class333.ath(), BCj);

	public static Bitmap ChecklistWaiting => (Bitmap)ResourceManager.GetObject(Class333.atI(), BCj);

	public static Bitmap ForwardArrow => (Bitmap)ResourceManager.GetObject(Class333.ati(), BCj);

	public static Bitmap HaltechSmallLogo => (Bitmap)ResourceManager.GetObject(Class333.atJ(), BCj);

	public static Bitmap IconBasicUSB => (Bitmap)ResourceManager.GetObject(Class333.atj(), BCj);

	public static Bitmap IconChecklist => (Bitmap)ResourceManager.GetObject(Class333.atK(), BCj);

	public static Bitmap IconCANBusViewer => (Bitmap)ResourceManager.GetObject(Class333.atk(), BCj);

	public static Bitmap IconCompareMaps => (Bitmap)ResourceManager.GetObject(Class333.atL(), BCj);

	public static Bitmap IconCopy => (Bitmap)ResourceManager.GetObject(Class333.atl(), BCj);

	public static Bitmap IconDownloadFromCloud => (Bitmap)ResourceManager.GetObject(Class333.atM(), BCj);

	public static Bitmap IconDTCsCEL => (Bitmap)ResourceManager.GetObject(Class333.atm(), BCj);

	public static Bitmap IconEmail => (Bitmap)ResourceManager.GetObject(Class333.atN(), BCj);

	public static Bitmap IconError => (Bitmap)ResourceManager.GetObject(Class333.atn(), BCj);

	public static Bitmap IconErrorConfig => (Bitmap)ResourceManager.GetObject(Class333.atO(), BCj);

	public static Bitmap IconFontLibrary => (Bitmap)ResourceManager.GetObject(Class333.ato(), BCj);

	public static Bitmap IconFWUpdate => (Bitmap)ResourceManager.GetObject(Class333.atP(), BCj);

	public static Bitmap IconHelp => (Bitmap)ResourceManager.GetObject(Class333.atp(), BCj);

	public static Bitmap IconImportMap => (Bitmap)ResourceManager.GetObject(Class333.atQ(), BCj);

	public static Bitmap IconNavigationTree => (Bitmap)ResourceManager.GetObject(Class333.atq(), BCj);

	public static Bitmap IconNewMap => (Bitmap)ResourceManager.GetObject(Class333.atR(), BCj);

	public static Bitmap IconOffline => (Bitmap)ResourceManager.GetObject(Class333.atr(), BCj);

	public static Bitmap IconOnlineUSB => (Bitmap)ResourceManager.GetObject(Class333.atS(), BCj);

	public static Bitmap IconOnlineUSBPower => (Bitmap)ResourceManager.GetObject(Class333.ats(), BCj);

	public static Bitmap IconOnlineWiFi => (Bitmap)ResourceManager.GetObject(Class333.atT(), BCj);

	public static Bitmap IconOpenLog => (Bitmap)ResourceManager.GetObject(Class333.att(), BCj);

	public static Bitmap IconOpenMap => (Bitmap)ResourceManager.GetObject(Class333.atU(), BCj);

	public static Bitmap IconPassword => (Bitmap)ResourceManager.GetObject(Class333.atu(), BCj);

	public static Bitmap IconPaste => (Bitmap)ResourceManager.GetObject(Class333.atV(), BCj);

	public static Bitmap IconRebootECU => (Bitmap)ResourceManager.GetObject(Class333.atv(), BCj);

	public static Bitmap IconRedo => (Bitmap)ResourceManager.GetObject(Class333.atW(), BCj);

	public static Bitmap IconResourceLibrary => (Bitmap)ResourceManager.GetObject(Class333.atw(), BCj);

	public static Bitmap IconSaveMap => (Bitmap)ResourceManager.GetObject(Class333.atX(), BCj);

	public static Bitmap IconScope => (Bitmap)ResourceManager.GetObject(Class333.atx(), BCj);

	public static Bitmap IconSWUpdate => (Bitmap)ResourceManager.GetObject(Class333.atY(), BCj);

	public static Bitmap IconTableProperties => (Bitmap)ResourceManager.GetObject(Class333.aty(), BCj);

	public static Bitmap IconTechSupport => (Bitmap)ResourceManager.GetObject(Class333.atZ(), BCj);

	public static Bitmap IconUndo => (Bitmap)ResourceManager.GetObject(Class333.atz(), BCj);

	public static Bitmap IconWarning => (Bitmap)ResourceManager.GetObject(Class333.aUA(), BCj);

	public static Bitmap IconWiring => (Bitmap)ResourceManager.GetObject(Class333.aUa(), BCj);

	public static Bitmap LogPlaybackDecSpeed => (Bitmap)ResourceManager.GetObject(Class333.aUB(), BCj);

	public static Bitmap LogPlaybackExit => (Bitmap)ResourceManager.GetObject(Class333.aUb(), BCj);

	public static Bitmap LogPlaybackIncSpeed => (Bitmap)ResourceManager.GetObject(Class333.aUC(), BCj);

	public static Bitmap LogPlaybackPause => (Bitmap)ResourceManager.GetObject(Class333.aUc(), BCj);

	public static Bitmap LogPlaybackPlay => (Bitmap)ResourceManager.GetObject(Class333.aUD(), BCj);

	public static Bitmap LogPlaybackPlay2 => (Bitmap)ResourceManager.GetObject(Class333.aUd(), BCj);

	public static Bitmap LogPlaybackStop => (Bitmap)ResourceManager.GetObject(Class333.aUE(), BCj);

	public static Bitmap QuestionMark => (Bitmap)ResourceManager.GetObject(Class333.aUe(), BCj);

	public static Bitmap RedError => (Bitmap)ResourceManager.GetObject(Class333.aUF(), BCj);

	public static Bitmap Search => (Bitmap)ResourceManager.GetObject(Class333.smethod_1256(), BCj);

	public static Bitmap YellowWarning => (Bitmap)ResourceManager.GetObject(Class333.aUf(), BCj);

	internal GeneralResources()
	{
	}
}
