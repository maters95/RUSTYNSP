using ns7;

namespace NSP.SettingsFramework;

public struct UIListSettingDataIdAndIndent
{
	public int DataId;

	public int Indent;

	public bool PlacePartialMapSearchableListDirectlyOnPanel;

	public bool PlacePartialMapImageGalleryDirectlyOnPanel;

	public override string ToString()
	{
		return Class333.aTp() + DataId + Class333.aTQ() + Indent;
	}
}
