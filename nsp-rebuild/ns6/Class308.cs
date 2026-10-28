using System.Collections.Generic;
using System.IO;
using System.Xml;
using ns0;
using ns5;
using ns7;

namespace ns6;

internal class Class308
{
	internal class Class309
	{
		internal string BTa;

		internal string BTB;

		internal string BTb;

		internal byte BTC = byte.MaxValue;

		internal string BTc;

		internal bool BTD;

		internal bool BTd = true;

		internal string BTE;

		public override string ToString()
		{
			return BTa;
		}
	}

	internal class Class310
	{
		internal string BTe;

		internal int BTF;

		internal int BTf;

		internal List<ushort> BTG = new List<ushort>();

		internal string BTg;

		internal string BTH;

		internal List<Class309> BTh = new List<Class309>();

		public override string ToString()
		{
			return ((!string.IsNullOrEmpty(BTe)) ? BTe : (Class333.BEs() + BTF + Class333.smethod_76() + BTf)) + Class333.aMY() + BTh.Count + Class333.BET();
		}
	}

	internal class Class311
	{
		internal string BTI;

		internal List<Enum88> BTi = new List<Enum88>();

		internal string BTJ;

		internal List<Class309> BTj = new List<Class309>();

		public override string ToString()
		{
			string text = ((!string.IsNullOrEmpty(BTI)) ? (BTI + Class333.aMY()) : string.Empty);
			foreach (Enum88 item in BTi)
			{
				text = text + Class333.BEt() + item.ToString() + Class333.aMY();
			}
			return text + BTj.Count + Class333.BET();
		}
	}

	internal class Class312
	{
		internal string BTK;

		internal List<Enum88> BTk = new List<Enum88>();

		internal List<int> BTL = new List<int>();

		internal List<Class309> BTl = new List<Class309>();

		public override string ToString()
		{
			string text = ((!string.IsNullOrEmpty(BTK)) ? (BTK + Class333.aMY()) : string.Empty);
			foreach (Enum88 item in BTk)
			{
				text = text + Class333.BEt() + item.ToString() + Class333.aMY();
			}
			foreach (int item2 in BTL)
			{
				text = text + Class333.BEU() + item2 + Class333.aMY();
			}
			return text + BTl.Count + Class333.BET();
		}
	}

	internal byte BDI;

	internal Class14 BDi;

	internal List<Class310> BDJ = new List<Class310>();

	internal List<Class311> BDj = new List<Class311>();

	internal List<Class312> BDK = new List<Class312>();

	public override string ToString()
	{
		return Class333.aYD() + BDi?.ToString() + Class333.aMY() + BDJ.Count + Class333.aYd() + BDj.Count + Class333.aYE() + BDK.Count + Class333.aYe();
	}

	internal Class308(Stream stream_0)
	{
		XmlReader xmlReader = XmlReader.Create(stream_0);
		xmlReader.Read();
		while (xmlReader.NodeType != XmlNodeType.Element)
		{
			xmlReader.Read();
		}
		if (!xmlReader.IsEmptyElement)
		{
			xmlReader.Read();
			while (xmlReader.IsStartElement())
			{
				bool flag = true;
				string name = xmlReader.Name;
				if (!(name == Class333.aYF()))
				{
					if (!(name == Class333.aYf()))
					{
						if (!(name == Class333.axz()))
						{
							if (!(name == Class333.aYA()))
							{
								if (!(name == Class333.aYG()))
								{
									flag = false;
								}
								else
								{
									method_2(xmlReader);
								}
							}
							else
							{
								method_1(xmlReader);
							}
						}
						else
						{
							method_0(xmlReader);
						}
					}
					else
					{
						xmlReader.Read();
						BDi = new Class14(xmlReader.Value, bool_0: false);
						xmlReader.Skip();
					}
				}
				else
				{
					xmlReader.Read();
					BDI = byte.Parse(xmlReader.Value);
					xmlReader.Skip();
				}
				if (!flag)
				{
					xmlReader.Skip();
				}
				else
				{
					xmlReader.Read();
				}
			}
		}
		xmlReader.Close();
		stream_0.Close();
	}

	private void method_0(XmlReader xmlReader_0)
	{
		Class310 @class = new Class310();
		@class.BTe = xmlReader_0.GetAttribute(Class333.ahQ());
		@class.BTF = int.Parse(xmlReader_0.GetAttribute(Class333.acm()));
		@class.BTf = int.Parse(xmlReader_0.GetAttribute(Class333.acN()));
		string[] array = xmlReader_0.GetAttribute(Class333.axV()).Split(',');
		foreach (string s in array)
		{
			@class.BTG.Add(ushort.Parse(s));
		}
		@class.BTg = xmlReader_0.GetAttribute(Class333.aYg());
		string attribute = xmlReader_0.GetAttribute(Class333.aYH());
		if (!string.IsNullOrEmpty(attribute))
		{
			@class.BTH = attribute;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.axz()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.aYh())
			{
				method_3(xmlReader_0, @class.BTh, bool_0: false);
			}
			else if (xmlReader_0.Name == Class333.aYI())
			{
				Class309 item = method_4(xmlReader_0, bool_0: false);
				@class.BTh.Add(item);
			}
			xmlReader_0.Read();
		}
		BDJ.Add(@class);
	}

	private void method_1(XmlReader xmlReader_0)
	{
		Class311 @class = new Class311();
		@class.BTI = xmlReader_0.GetAttribute(Class333.ahQ());
		string[] array = xmlReader_0.GetAttribute(Class333.aYi()).Split(',');
		foreach (string s in array)
		{
			@class.BTi.Add((Enum88)byte.Parse(s));
		}
		string attribute = xmlReader_0.GetAttribute(Class333.aYH());
		if (!string.IsNullOrEmpty(attribute))
		{
			@class.BTJ = attribute;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aYA()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.aYh())
			{
				method_3(xmlReader_0, @class.BTj, bool_0: true);
			}
			else if (xmlReader_0.Name == Class333.aYI())
			{
				Class309 item = method_4(xmlReader_0, bool_0: true);
				@class.BTj.Add(item);
			}
			xmlReader_0.Read();
		}
		BDj.Add(@class);
	}

	private void method_2(XmlReader xmlReader_0)
	{
		Class312 @class = new Class312();
		@class.BTK = xmlReader_0.GetAttribute(Class333.ahQ());
		string[] array = xmlReader_0.GetAttribute(Class333.aYi()).Split(',');
		foreach (string s in array)
		{
			@class.BTk.Add((Enum88)byte.Parse(s));
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aYG()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.aYh())
			{
				method_3(xmlReader_0, @class.BTl, bool_0: true);
			}
			else if (xmlReader_0.Name == Class333.aYI())
			{
				Class309 item = method_4(xmlReader_0, bool_0: true);
				@class.BTl.Add(item);
			}
			else if (xmlReader_0.Name == Class333.aYJ())
			{
				method_5(xmlReader_0, @class);
			}
			xmlReader_0.Read();
		}
		BDK.Add(@class);
	}

	private void method_3(XmlReader xmlReader_0, List<Class309> list_0, bool bool_0)
	{
		Class309 @class = new Class309();
		string attribute = xmlReader_0.GetAttribute(Class333.aYj());
		if (string.IsNullOrEmpty(attribute))
		{
			@class.BTd = !bool_0;
		}
		else
		{
			@class.BTd = bool.Parse(attribute);
		}
		string attribute2 = xmlReader_0.GetAttribute(Class333.aYK());
		if (!string.IsNullOrEmpty(attribute2))
		{
			@class.BTE = attribute2;
		}
		@class.BTD = true;
		@class.BTB = xmlReader_0.GetAttribute(Class333.ahQ());
		@class.BTa = xmlReader_0.GetAttribute(Class333.aYk());
		string attribute3 = xmlReader_0.GetAttribute(Class333.aIB());
		if (!string.IsNullOrEmpty(attribute3))
		{
			@class.BTb = attribute3;
		}
		list_0.Add(@class);
		int num = list_0.Count - 1;
		if (xmlReader_0.IsEmptyElement)
		{
			return;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aYh()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.aYL())
			{
				Class309 class2 = method_4(xmlReader_0, bool_0);
				if (class2.BTb == null)
				{
					class2.BTb = @class.BTb;
				}
				list_0.Insert(num, class2);
				num++;
			}
			else if (xmlReader_0.Name == Class333.aYl())
			{
				Class309 class3 = method_4(xmlReader_0, bool_0);
				if (class3.BTb == null)
				{
					class3.BTb = @class.BTb;
				}
				list_0.Add(class3);
			}
			xmlReader_0.Read();
		}
	}

	private Class309 method_4(XmlReader xmlReader_0, bool bool_0)
	{
		Class309 @class = new Class309();
		string attribute = xmlReader_0.GetAttribute(Class333.aYj());
		if (string.IsNullOrEmpty(attribute))
		{
			@class.BTd = !bool_0;
		}
		else
		{
			@class.BTd = bool.Parse(attribute);
		}
		string attribute2 = xmlReader_0.GetAttribute(Class333.aYK());
		if (!string.IsNullOrEmpty(attribute2))
		{
			@class.BTE = attribute2;
		}
		@class.BTa = xmlReader_0.GetAttribute(Class333.aYk());
		@class.BTD = bool.Parse(xmlReader_0.GetAttribute(Class333.aYM()));
		@class.BTc = xmlReader_0.GetAttribute(Class333.ahQ());
		string attribute3 = xmlReader_0.GetAttribute(Class333.aIB());
		if (!string.IsNullOrEmpty(attribute3))
		{
			@class.BTb = attribute3;
		}
		string attribute4 = xmlReader_0.GetAttribute(Class333.aYm());
		if (!string.IsNullOrEmpty(attribute4))
		{
			@class.BTC = byte.Parse(attribute4);
		}
		return @class;
	}

	private void method_5(XmlReader xmlReader_0, Class312 class312_0)
	{
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aYJ()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.aYN() && int.TryParse(xmlReader_0.GetAttribute(Class333.smethod_1159()), out var result))
			{
				class312_0.BTL.Add(result);
			}
			xmlReader_0.Read();
		}
	}
}
