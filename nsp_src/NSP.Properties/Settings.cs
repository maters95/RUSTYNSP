using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace NSP.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.10.0.0")]
public sealed class Settings : ApplicationSettingsBase
{
	private static Settings BCP = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => BCP;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfInt xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <int>255</int>\r\n  <int>2934783</int>\r\n  <int>127</int>\r\n</ArrayOfInt>")]
	public int[] ColourPickerCustomColors
	{
		get
		{
			return (int[])((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVT()];
		}
		set
		{
			((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVT()] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserEmail
	{
		get
		{
			return (string)((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVt()];
		}
		set
		{
			((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVt()] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserFirstName
	{
		get
		{
			return (string)((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVU()];
		}
		set
		{
			((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVU()] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserLastName
	{
		get
		{
			return (string)((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVu()];
		}
		set
		{
			((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVu()] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserPhone
	{
		get
		{
			return (string)((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVV()];
		}
		set
		{
			((SettingsBase)this)[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVV()] = value;
		}
	}
}
