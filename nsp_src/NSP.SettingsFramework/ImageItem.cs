using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace NSP.SettingsFramework;

public class ImageItem
{
	public string ImageHexString;

	public ImageItem(string img)
	{
		ImageHexString = img;
	}

	public virtual string ToString()
	{
		return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMw() + ImageHexString;
	}
}
