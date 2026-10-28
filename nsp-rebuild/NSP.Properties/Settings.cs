using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns7;

namespace NSP.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.10.0.0")]
public sealed class Settings : ApplicationSettingsBase
{
	private static Settings BCP = (Settings)SettingsBase.Synchronized(new Settings());

	public static Settings Default => BCP;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfInt xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <int>255</int>\r\n  <int>2934783</int>\r\n  <int>127</int>\r\n</ArrayOfInt>")]
	public int[] ColourPickerCustomColors
	{
		get
		{
			return (int[])this[Class333.aVT()];
		}
		set
		{
			this[Class333.aVT()] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserEmail
	{
		get
		{
			return (string)this[Class333.aVt()];
		}
		set
		{
			this[Class333.aVt()] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserFirstName
	{
		get
		{
			return (string)this[Class333.aVU()];
		}
		set
		{
			this[Class333.aVU()] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserLastName
	{
		get
		{
			return (string)this[Class333.aVu()];
		}
		set
		{
			this[Class333.aVu()] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserPhone
	{
		get
		{
			return (string)this[Class333.aVV()];
		}
		set
		{
			this[Class333.aVV()] = value;
		}
	}
}
