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
	private string Fi = string.Empty;

	[XmlElement]
	public string OnlineURL
	{
		[CompilerGenerated]
		get
		{
			return Fi;
		}
		[CompilerGenerated]
		set
		{
			Fi = value;
		}
	}
}
