using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace NSP.UserInterface;

[Serializable]
public class LocalArticle
{
	[XmlElement]
	public string LocalURL = string.Empty;

	[XmlAttribute]
	public string Name = string.Empty;

	[CompilerGenerated]
	private string string_0 = string.Empty;

	[XmlElement]
	public string OnlineURL
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}
}
