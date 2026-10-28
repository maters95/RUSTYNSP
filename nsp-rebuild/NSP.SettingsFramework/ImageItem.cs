using ns7;

namespace NSP.SettingsFramework;

public class ImageItem
{
	public string ImageHexString;

	public ImageItem(string img)
	{
		ImageHexString = img;
	}

	public override string ToString()
	{
		return Class333.aMw() + ImageHexString;
	}
}
