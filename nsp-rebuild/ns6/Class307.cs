using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using ns0;
using ns5;
using ns7;

namespace ns6;

internal static class Class307
{
	private static readonly string BDH = Class320.Bdl + Class333.aYc();

	private static List<Class318> BDh = new List<Class318>();

	internal static Class318 smethod_0(string string_0)
	{
		for (int i = 0; i < BDh.Count; i++)
		{
			Class318 @class = BDh[i];
			try
			{
				if (!(@class.BdE == string_0))
				{
					continue;
				}
				if (File.Exists(string_0))
				{
					string bde = @class.Bde;
					DateTime creationTime = File.GetCreationTime(string_0);
					DateTime lastWriteTime = File.GetLastWriteTime(string_0);
					string text = Class23.smethod_9((lastWriteTime > creationTime) ? lastWriteTime : creationTime, bool_1: true, bool_2: false);
					if (bde != text)
					{
						BDh.RemoveAt(i);
						return null;
					}
					bool flag = false;
					foreach (Class316 item in @class.BdF)
					{
						if (item.BdC != null && item.BdC.axt != null)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						return @class;
					}
					BDh.RemoveAt(i);
					return null;
				}
				BDh.RemoveAt(i);
				return null;
			}
			catch
			{
			}
		}
		return null;
	}

	internal static void smethod_1(Class318 class318_0, bool bool_0)
	{
		BDh.Add(class318_0);
		if (bool_0)
		{
			smethod_7();
		}
	}

	internal static void smethod_2(string string_0, bool bool_0)
	{
		int num = BDh.Count - 1;
		while (num >= 0)
		{
			if (!(BDh[num].BdE == string_0))
			{
				num--;
				continue;
			}
			BDh.RemoveAt(num);
			break;
		}
		try
		{
			File.Delete(string_0);
		}
		catch
		{
		}
		if (bool_0)
		{
			smethod_7();
		}
	}

	internal static void smethod_3()
	{
		BDh.Clear();
		if (!File.Exists(BDH))
		{
			return;
		}
		try
		{
			FileStream fileStream = new FileStream(BDH, FileMode.Open);
			XmlReader xmlReader = XmlReader.Create(fileStream);
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
					if (xmlReader.Name == Class333.axx())
					{
						smethod_4(xmlReader);
					}
					else
					{
						flag = false;
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
			fileStream.Close();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.axY() + ex.Message);
		}
	}

	private static void smethod_4(XmlReader xmlReader_0)
	{
		Class318 @class = new Class318();
		@class.BdE = xmlReader_0.GetAttribute(Class333.axy());
		@class.Bde = xmlReader_0.GetAttribute(Class333.axZ());
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.axx()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.axz())
			{
				smethod_5(xmlReader_0, @class);
			}
			else if (xmlReader_0.Name == Class333.aYA())
			{
				smethod_6(xmlReader_0, @class);
			}
			xmlReader_0.Read();
		}
		BDh.Add(@class);
	}

	private static void smethod_5(XmlReader xmlReader_0, Class318 class318_0)
	{
		Class316 @class = new Class316();
		@class.BdC = new Class240
		{
			axS = int.Parse(xmlReader_0.GetAttribute(Class333.acm())),
			axs = int.Parse(xmlReader_0.GetAttribute(Class333.acN())),
			axT = new Class14(xmlReader_0.GetAttribute(Class333.axv()), bool_0: false)
		};
		string attribute = xmlReader_0.GetAttribute(Class333.aYa());
		if (!string.IsNullOrEmpty(attribute))
		{
			@class.BdC.axt = Class24.smethod_1(attribute);
		}
		@class.Bdc = new List<ushort>();
		string[] array = xmlReader_0.GetAttribute(Class333.axV()).Split(',');
		foreach (string s in array)
		{
			@class.Bdc.Add(ushort.Parse(s));
		}
		class318_0.BdF.Add(@class);
	}

	private static void smethod_6(XmlReader xmlReader_0, Class318 class318_0)
	{
		Class317 @class = new Class317();
		@class.BdD = (Enum88)byte.Parse(xmlReader_0.GetAttribute(Class333.aYB()));
		@class.Bdd = new Class14(xmlReader_0.GetAttribute(Class333.axv()), bool_0: false);
		class318_0.Bdf.Add(@class);
	}

	internal static void smethod_7()
	{
		try
		{
			if (File.Exists(BDH))
			{
				File.Delete(BDH);
			}
			if (BDh.Count == 0)
			{
				return;
			}
			MemoryStream memoryStream = new MemoryStream();
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.ConformanceLevel = ConformanceLevel.Document;
			xmlWriterSettings.CloseOutput = false;
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.NewLineChars = Environment.NewLine;
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
			xmlWriter.WriteStartElement(Class333.aYb());
			foreach (Class318 item in BDh)
			{
				smethod_8(xmlWriter, item);
			}
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
			memoryStream.Flush();
			using (StreamWriter streamWriter = new StreamWriter(BDH))
			{
				memoryStream.Position = 0L;
				string value = new StreamReader(memoryStream).ReadToEnd();
				streamWriter.Write(value);
			}
			File.SetAttributes(BDH, FileAttributes.Hidden);
			memoryStream.Close();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aYC() + ex.Message);
		}
	}

	private static void smethod_8(XmlWriter xmlWriter_0, Class318 class318_0)
	{
		xmlWriter_0.WriteStartElement(Class333.axx());
		xmlWriter_0.WriteAttributeString(Class333.axy(), class318_0.BdE);
		xmlWriter_0.WriteAttributeString(Class333.axZ(), class318_0.Bde);
		foreach (Class316 item in class318_0.BdF)
		{
			xmlWriter_0.WriteStartElement(Class333.axz());
			xmlWriter_0.WriteAttributeString(Class333.acm(), item.BdC.axS.ToString());
			xmlWriter_0.WriteAttributeString(Class333.acN(), item.BdC.axs.ToString());
			xmlWriter_0.WriteAttributeString(Class333.axv(), item.BdC.axT.ToString());
			if (item.BdC.axt != null)
			{
				xmlWriter_0.WriteAttributeString(Class333.aYa(), Class24.smethod_0(item.BdC.axt));
			}
			string text = string.Empty;
			foreach (ushort item2 in item.Bdc)
			{
				text = ((!string.IsNullOrEmpty(text)) ? (text + Class333.smethod_189() + item2) : (text + item2));
			}
			xmlWriter_0.WriteAttributeString(Class333.axV(), text);
			xmlWriter_0.WriteEndElement();
		}
		foreach (Class317 item3 in class318_0.Bdf)
		{
			xmlWriter_0.WriteStartElement(Class333.aYA());
			string localName = Class333.aYB();
			byte bdD = (byte)item3.BdD;
			xmlWriter_0.WriteAttributeString(localName, bdD.ToString());
			xmlWriter_0.WriteAttributeString(Class333.axv(), item3.Bdd.ToString());
			xmlWriter_0.WriteEndElement();
		}
		xmlWriter_0.WriteEndElement();
	}
}
