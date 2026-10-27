using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NSP.UserInterface;

[Serializable]
public class LocalCategory
{
	[XmlAttribute]
	public string Name;

	[XmlAttribute]
	public int Level = -32768;

	[XmlAttribute]
	public int Idx = -32768;

	public List<LocalArticle> Articles;

	public List<LocalCategory> ChildCategories;
}
