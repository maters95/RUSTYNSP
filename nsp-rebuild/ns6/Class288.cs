using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns7;

namespace ns6;

internal class Class288
{
	private string BcG;

	private Stream Bcg;

	internal Class288(string string_0)
	{
		BcG = string_0;
	}

	internal Class288(Stream stream_0)
	{
		Bcg = stream_0;
	}

	internal Class286 method_0()
	{
		XmlReader xmlReader = null;
		Stream stream = null;
		Stream stream_ = null;
		if (BcG == null && Bcg == null)
		{
			return null;
		}
		if (BcG != null)
		{
			stream = File.OpenRead(BcG);
		}
		else if (Bcg != null)
		{
			stream = Bcg;
		}
		bool flag;
		try
		{
			flag = Class31.smethod_7(stream);
		}
		catch
		{
			flag = false;
		}
		if (flag)
		{
			if (!Class31.smethod_5(stream, Class333.aWP(), out stream_, Class19.smethod_1()))
			{
				stream.Close();
				return null;
			}
		}
		else
		{
			stream_ = stream;
		}
		xmlReader = XmlReader.Create(stream_);
		Class286 @class = new Class286();
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
				bool flag2 = true;
				string name = xmlReader.Name;
				if (!(name == Class333.aGX()))
				{
					if (!(name == Class333.smethod_796()))
					{
						if (!(name == Class333.aWp()))
						{
							flag2 = false;
						}
						else
						{
							xmlReader.Read();
							@class.BCw = xmlReader.Value;
							xmlReader.Skip();
						}
					}
					else if (!xmlReader.IsEmptyElement)
					{
						method_3(xmlReader, @class);
					}
				}
				else if (!xmlReader.IsEmptyElement)
				{
					method_1(xmlReader, @class);
				}
				if (!flag2)
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
		stream_?.Close();
		stream?.Close();
		return @class;
	}

	private void method_1(XmlReader xmlReader_0, Class286 class286_0)
	{
		while (xmlReader_0.IsStartElement())
		{
			string name = xmlReader_0.Name;
			if (name != null)
			{
				switch (name.Length)
				{
				case 18:
					switch (name[11])
					{
					case 'V':
						if (name == Class333.aWS())
						{
							xmlReader_0.Read();
							class286_0.BcA = int.Parse(xmlReader_0.Value);
							xmlReader_0.Skip();
						}
						break;
					case 'P':
						if (name == Class333.aWr())
						{
							xmlReader_0.Read();
							class286_0.BCz = int.Parse(xmlReader_0.Value);
							xmlReader_0.Skip();
						}
						break;
					}
					break;
				case 3:
					switch (name[1])
					{
					case 'x':
						if (name == Class333.aWU())
						{
							method_2(xmlReader_0, class286_0);
						}
						break;
					case 'a':
						if (name == Class333.aGx())
						{
							string attribute2 = xmlReader_0.GetAttribute(Class333.ahQ());
							xmlReader_0.Read();
							class286_0.Bcb.Add(attribute2, xmlReader_0.Value);
							xmlReader_0.Skip();
						}
						break;
					}
					break;
				case 4:
					if (name == Class333.aWQ())
					{
						xmlReader_0.Read();
						class286_0.BCX = xmlReader_0.Value;
						xmlReader_0.Skip();
					}
					break;
				case 7:
					switch (name[1])
					{
					case 'r':
						if (name == Class333.aWT())
						{
							xmlReader_0.Read();
							class286_0.BCy = xmlReader_0.Value;
							xmlReader_0.Skip();
						}
						break;
					case 'a':
						if (name == Class333.aWs())
						{
							xmlReader_0.Read();
							class286_0.BCx = int.Parse(xmlReader_0.Value);
							xmlReader_0.Skip();
						}
						break;
					}
					break;
				case 8:
					if (name == Class333.aWt())
					{
						xmlReader_0.Read();
						class286_0.Bca = xmlReader_0.Value;
						xmlReader_0.Skip();
					}
					break;
				case 11:
					if (name == Class333.aWq())
					{
						xmlReader_0.Read();
						class286_0.BCY = Version.Parse(xmlReader_0.Value);
						xmlReader_0.Skip();
					}
					break;
				case 13:
					if (name == Class333.ahj())
					{
						string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
						xmlReader_0.Read();
						if (attribute != null && attribute == Class333.aWu())
						{
							class286_0.BcB = xmlReader_0.Value;
						}
						xmlReader_0.Skip();
					}
					break;
				case 15:
					if (name == Class333.aWR())
					{
						xmlReader_0.Read();
						class286_0.BCZ = new Class14(xmlReader_0.Value, bool_0: false);
						xmlReader_0.Skip();
					}
					break;
				}
			}
			xmlReader_0.Read();
		}
	}

	private void method_2(XmlReader xmlReader_0, Class286 class286_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.aWV());
		Class286.Struct48 value = default;
		xmlReader_0.Read();
		while (xmlReader_0.NodeType != XmlNodeType.Element)
		{
			xmlReader_0.Read();
		}
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aWU()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.aWv())
			{
				xmlReader_0.Read();
				value.BsP = xmlReader_0.Value;
				xmlReader_0.Skip();
			}
			else if (xmlReader_0.Name == Class333.aWW())
			{
				xmlReader_0.Read();
				value.Bsp = xmlReader_0.Value;
				xmlReader_0.Skip();
			}
			else if (xmlReader_0.Name == Class333.aWw())
			{
				xmlReader_0.Read();
				value.BsQ = xmlReader_0.Value;
				xmlReader_0.Skip();
			}
			xmlReader_0.Read();
		}
		class286_0.BcC.Add(attribute, value);
	}

	private void method_3(XmlReader xmlReader_0, Class286 class286_0)
	{
		while (xmlReader_0.IsStartElement())
		{
			string name = xmlReader_0.Name;
			if (!(name == Class333.aGi()) && !(name == Class333.aWX()))
			{
				if (name == Class333.smethod_1323())
				{
					method_5(xmlReader_0, class286_0);
				}
			}
			else
			{
				method_4(xmlReader_0, class286_0);
			}
			xmlReader_0.Read();
		}
	}

	private void method_4(XmlReader xmlReader_0, Class286 class286_0)
	{
		int num = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
		int attrId = int.Parse(xmlReader_0.GetAttribute(Class333.aWx()));
		string attribute = xmlReader_0.GetAttribute(Class333.aWY());
		if (!string.IsNullOrEmpty(attribute))
		{
			class286_0.Bce[num] = attribute;
		}
		xmlReader_0.Read();
		byte[] value = Class24.smethod_1(xmlReader_0.Value);
		class286_0.Bcc[new DataIdAndAttrId(num, attrId)] = value;
		xmlReader_0.Skip();
	}

	private void method_5(XmlReader xmlReader_0, Class286 class286_0)
	{
		int key = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
		string attribute = xmlReader_0.GetAttribute(Class333.aWy());
		int num = ((!string.IsNullOrEmpty(attribute)) ? int.Parse(attribute) : 0);
		string attribute2 = xmlReader_0.GetAttribute(Class333.aWZ());
		int num2 = ((!string.IsNullOrEmpty(attribute2)) ? int.Parse(attribute2) : 0);
		xmlReader_0.Read();
		byte[] value = Class24.smethod_1(xmlReader_0.Value);
		if (num != 0)
		{
			if (!class286_0.BcE.ContainsKey(num))
			{
				class286_0.BcE.Add(num, new Dictionary<int, byte[]>());
			}
			class286_0.BcE[num][key] = value;
		}
		else if (num2 != 0)
		{
			if (!class286_0.Bcd.ContainsKey(num2))
			{
				class286_0.Bcd.Add(num2, new Dictionary<int, byte[]>());
			}
			class286_0.Bcd[num2][key] = value;
		}
		else
		{
			class286_0.BcD[key] = value;
		}
		xmlReader_0.Skip();
	}

	internal static void smethod_0(Class287 class287_0, Framework framework_0)
	{
		if (class287_0 == null || class287_0.BcF == null || string.IsNullOrEmpty(class287_0.Bcf) || !class287_0.Bcf.EndsWith(Class333.smethod_1965()))
		{
			return;
		}
		Stream stream = null;
		try
		{
			stream = File.OpenRead(class287_0.Bcf);
			if (!Class31.smethod_7(stream))
			{
				return;
			}
		}
		catch
		{
			return;
		}
		if (stream == null)
		{
			return;
		}
		List<string> list = null;
		try
		{
			list = Class31.smethod_8(stream, Class19.smethod_1());
		}
		catch
		{
			return;
		}
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				string text = list[i];
				try
				{
					if (!text.StartsWith(Class333.smethod_2009()) || text.Length <= Class333.smethod_2009().Length + 1)
					{
						continue;
					}
					Stream stream_ = null;
					if (Class31.smethod_5(stream, text, out stream_, Class19.smethod_1()))
					{
						byte[] byte_ = null;
						using (MemoryStream memoryStream = new MemoryStream())
						{
							stream_.CopyTo(memoryStream);
							byte_ = memoryStream.ToArray();
						}
						int startIndex = Class333.smethod_2009().Length + 1;
						string text2 = text.Substring(startIndex);
						int num = text2.IndexOfAny(new char[2] { '\\', '/' });
						if (num != -1)
						{
							string text3 = text2.Substring(0, num);
							int length = (Class333.aWz() + text3 + Class333.smethod_177()).Length;
							if (length < text.Length)
							{
								string string_ = text.Substring(length);
								if (!Form23.smethod_20(Form23.string_10, string_, byte_, text3, out var string_2))
								{
									Class23.smethod_3(string_2);
								}
							}
						}
					}
					stream_?.Close();
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.awA() + text + Class333.smethod_1802() + ex.Message);
				}
			}
		}
		try
		{
			stream.Close();
		}
		catch
		{
		}
	}

	internal static Image smethod_1(Class287 class287_0)
	{
		if (class287_0 != null && class287_0.BcF != null && !string.IsNullOrEmpty(class287_0.Bcf) && !string.IsNullOrEmpty(class287_0.BcF.BcB))
		{
			try
			{
				if (class287_0.Bcf.ToLower().EndsWith(Class333.smethod_1965()))
				{
					Stream stream = File.OpenRead(class287_0.Bcf);
					if (Class31.smethod_7(stream))
					{
						if (Class31.smethod_5(stream, class287_0.BcF.BcB, out var stream_, Class19.smethod_1()))
						{
							Image result = Image.FromStream(stream_);
							stream_.Close();
							stream.Close();
							return result;
						}
						stream.Close();
					}
					else
					{
						stream.Close();
					}
				}
				else if (class287_0.Bcf.ToLower().EndsWith(Class333.awa()))
				{
					string bcB = class287_0.BcF.BcB;
					string path = Path.Combine(Path.GetDirectoryName(class287_0.Bcf), bcB);
					if (File.Exists(path))
					{
						Image result2;
						using (FileStream stream2 = File.Open(path, FileMode.Open))
						{
							result2 = Image.FromStream(stream2);
						}
						return result2;
					}
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.awB() + ex.Message);
			}
		}
		return null;
	}

	internal static void smethod_2()
	{
		string[] array = null;
		if (Directory.Exists(Form23.string_17))
		{
			try
			{
				array = Directory.GetDirectories(Form23.string_17);
			}
			catch
			{
				array = null;
			}
		}
		if (array == null)
		{
			return;
		}
		string[] array2 = array;
		foreach (string path in array2)
		{
			string[] array3 = null;
			try
			{
				array3 = Directory.GetFiles(path, Class333.smethod_1963());
			}
			catch
			{
				array3 = null;
			}
			if (array3 != null)
			{
				string[] array4 = array3;
				foreach (string path2 in array4)
				{
					try
					{
						string name = new DirectoryInfo(Path.GetDirectoryName(path2)).Name;
						string fileName = Path.GetFileName(path2);
						if (File.Exists(Form23.string_16 + name + Class333.smethod_177() + fileName))
						{
							File.Delete(path2);
						}
					}
					catch (Exception ex)
					{
						Class23.smethod_3(Class333.awb() + ex.Message);
					}
				}
			}
			try
			{
				if (Directory.GetFiles(path).Length == 0)
				{
					Directory.Delete(path);
				}
			}
			catch (Exception ex2)
			{
				Class23.smethod_3(Class333.awb() + ex2.Message);
			}
		}
	}

	internal static Dictionary<string, Class287> smethod_3(List<string> list_0)
	{
		Dictionary<string, Class287> dictionary = new Dictionary<string, Class287>();
		string[] array = null;
		if (Directory.Exists(Form23.string_16))
		{
			try
			{
				array = Directory.GetDirectories(Form23.string_16);
			}
			catch
			{
				array = null;
			}
		}
		string[] array2 = null;
		if (Directory.Exists(Form23.string_17))
		{
			try
			{
				array2 = Directory.GetDirectories(Form23.string_17);
			}
			catch
			{
				array2 = null;
			}
		}
		List<string> list = new List<string>();
		if (array != null)
		{
			list.AddRange(array);
		}
		if (array2 != null)
		{
			list.AddRange(array2);
		}
		foreach (string item in list)
		{
			string[] array3 = null;
			try
			{
				array3 = Directory.GetFiles(item, Class333.smethod_1963());
			}
			catch
			{
				array3 = null;
			}
			if (array3 == null)
			{
				continue;
			}
			string[] array4 = array3;
			foreach (string text in array4)
			{
				try
				{
					if (list_0 == null || list_0.Contains(Path.GetFullPath(text)))
					{
						Class286 @class = new Class288(text).method_0();
						if (@class != null && !dictionary.ContainsKey(@class.BCw))
						{
							Class287 class2 = new Class287();
							class2.BcF = @class;
							class2.Bcf = text;
							dictionary.Add(@class.BCw, class2);
						}
					}
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.awC() + text + Class333.smethod_1802() + ex.Message);
				}
			}
		}
		return dictionary;
	}
}
