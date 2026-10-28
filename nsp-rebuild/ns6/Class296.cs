using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using NSP.SettingsFramework;
using ns0;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns6;

internal class Class296
{
	private string BcM;

	private Stream Bcm;

	private Framework BcN;

	internal Class296(string string_0, Framework framework_0)
	{
		BcM = string_0;
		BcN = framework_0;
	}

	internal Class296(Stream stream_0, Framework framework_0)
	{
		Bcm = stream_0;
		BcN = framework_0;
	}

	internal bool method_0(out string string_0)
	{
		return method_1(out string_0, bool_0: false, bool_1: false, bool_2: false);
	}

	internal bool method_1(out string string_0, bool bool_0, bool bool_1, bool bool_2)
	{
		XmlReader xmlReader = null;
		Stream stream = null;
		Stream stream_ = null;
		string_0 = null;
		bool flag = true;
		if (BcM != null)
		{
			stream = File.OpenRead(BcM);
			try
			{
				flag = Class31.smethod_7(stream);
			}
			catch (Exception)
			{
				flag = false;
			}
			if (flag)
			{
				if (!Class31.smethod_5(stream, Class333.aGw(), out stream_, Class19.smethod_1()))
				{
					stream.Close();
					string_0 = Class333.awR();
					return false;
				}
			}
			else
			{
				stream_ = stream;
			}
			xmlReader = XmlReader.Create(stream_);
		}
		else
		{
			if (Bcm == null)
			{
				string_0 = Class333.awr();
				return false;
			}
			xmlReader = XmlReader.Create(Bcm);
		}
		string string_1 = null;
		bool flag2 = false;
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
				bool flag3 = true;
				string name = xmlReader.Name;
				if (!(name == Class333.aGX()))
				{
					if (!(name == Class333.smethod_796()))
					{
						flag3 = false;
					}
					else if (!xmlReader.IsEmptyElement)
					{
						method_4(xmlReader, bool_0);
					}
				}
				else if (!xmlReader.IsEmptyElement && !method_3(xmlReader, bool_0, out string_1))
				{
					flag2 = true;
				}
				if (!flag3)
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
		if (stream != null)
		{
			if ((BcM != null) & flag)
			{
				method_5(stream);
				if (!bool_0 && BcN.awv.Count != 0)
				{
					method_6(stream, bool_1, bool_2);
				}
			}
			stream.Close();
		}
		if (flag2)
		{
			string_0 = Class333.awS();
			return false;
		}
		bool flag4 = false;
		if (Class242.smethod_12(BcN.awZ) && BcN.aXA.method_0() < 3)
		{
			flag4 = true;
		}
		if (bool_0 | flag4)
		{
			return true;
		}
		if (string.IsNullOrWhiteSpace(string_1))
		{
			string_0 = Class333.aws();
			return false;
		}
		if (method_2(string_1))
		{
			return true;
		}
		string_0 = Class333.awT();
		return false;
	}

	private bool method_2(string string_0)
	{
		byte[] buffer = BcN.method_18();
		bool result = false;
		using (MD5 mD = MD5.Create())
		{
			string s = Class24.smethod_0(mD.ComputeHash(buffer));
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			byte[] array = Class24.smethod_1(string_0);
			if (bytes.Length == array.Length)
			{
				result = true;
				for (int i = 0; i < bytes.Length; i++)
				{
					if (bytes[i] != array[i])
					{
						result = false;
						break;
					}
				}
			}
		}
		return result;
	}

	private bool method_3(XmlReader xmlReader_0, bool bool_0, out string string_0)
	{
		string_0 = null;
		bool result = true;
		for (; xmlReader_0.IsStartElement(); xmlReader_0.Read())
		{
			string name = xmlReader_0.Name;
			if (name == null)
			{
				continue;
			}
			int int_;
			Setting setting;
			byte[] array3;
			byte[] array4;
			switch (name.Length)
			{
			case 3:
				switch (name[0])
				{
				case 'T':
					if (name == Class333.aGx())
					{
						xmlReader_0.Skip();
					}
					break;
				case 'M':
					if (name == Class333.aGY())
					{
						xmlReader_0.Read();
						string_0 = xmlReader_0.Value;
						xmlReader_0.Skip();
					}
					break;
				}
				continue;
			case 7:
			{
				char c = name[1];
				if (c != 'a')
				{
					if (c != 'e' || !(name == Class333.smethod_194()))
					{
						continue;
					}
				}
				else if (!(name == Class333.agg()))
				{
					continue;
				}
				goto IL_0367;
			}
			case 8:
			{
				char c = name[0];
				if (c != 'F')
				{
					if (c == 'H')
					{
						if (!(name == Class333.aGZ()))
						{
							continue;
						}
						xmlReader_0.Read();
						string value = xmlReader_0.Value;
						xmlReader_0.Skip();
						byte[] array = Class24.smethod_1(value);
						byte[] array2 = BcN.method_11();
						for (int i = 0; i < 16; i++)
						{
							if (array2[i] != array[i])
							{
								result = false;
								break;
							}
						}
						continue;
					}
					if (c != 'P' || !(name == Class333.aGz()))
					{
						continue;
					}
				}
				else if (!(name == Class333.agA()))
				{
					continue;
				}
				goto IL_0367;
			}
			case 9:
				if (!(name == Class333.agG()))
				{
					continue;
				}
				goto IL_0367;
			case 10:
				if (name == Class333.aGy())
				{
					xmlReader_0.Skip();
				}
				continue;
			case 11:
			{
				char c = name[0];
				if (c != 'I')
				{
					if (c != 'P' || !(name == Class333.agB()))
					{
						continue;
					}
				}
				else if (!(name == Class333.aga()))
				{
					continue;
				}
				goto IL_0367;
			}
			case 12:
				if (name == Class333.smethod_2615())
				{
					BcN.aXc = xmlReader_0.ReadElementContentAsString();
				}
				continue;
			case 14:
			{
				char c = name[7];
				if (c != 'E')
				{
					if (c != 'N' || !(name == Class333.agc()))
					{
						continue;
					}
				}
				else if (!(name == Class333.agC()))
				{
					continue;
				}
				goto IL_0367;
			}
			case 15:
				if (!(name == Class333.agb()))
				{
					continue;
				}
				goto IL_0367;
			case 17:
				if (!(name == Class333.agd()))
				{
					continue;
				}
				goto IL_0367;
			case 18:
				if (!(name == Class333.agD()))
				{
					continue;
				}
				goto IL_0367;
			case 20:
				if (!(name == Class333.agF()))
				{
					continue;
				}
				break;
			case 21:
			{
				char c = name[7];
				if (c != 'D')
				{
					if (c != 'S' || !(name == Class333.age()))
					{
						continue;
					}
					break;
				}
				if (!(name == Class333.agE()))
				{
					continue;
				}
				goto IL_0367;
			}
			case 27:
				if (!(name == Class333.agf()))
				{
					continue;
				}
				break;
			default:
				continue;
				IL_0367:
				int_ = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
				setting = BcN.method_31(int_);
				xmlReader_0.Read();
				array3 = Class24.smethod_1(xmlReader_0.Value);
				array4 = (BcN.aWR ? array3 : Class23.smethod_7(array3, setting.method_199()));
				if (bool_0)
				{
					setting.method_245(new byte[setting.method_278()]);
					for (int j = 0; j < setting.method_244().Length; j++)
					{
						if (j >= array4.Length)
						{
							setting.method_244()[j] = 0;
						}
						else
						{
							setting.method_244()[j] = array4[j];
						}
					}
				}
				else
				{
					setting.method_275(array4, bool_0: false);
				}
				xmlReader_0.Skip();
				continue;
			}
			xmlReader_0.Skip();
		}
		return result;
	}

	private void method_4(XmlReader xmlReader_0, bool bool_0)
	{
		while (xmlReader_0.IsStartElement())
		{
			string name = xmlReader_0.Name;
			if (name == Class333.aGi() || name == Class333.aWX())
			{
				int dataId = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
				int attrId = int.Parse(xmlReader_0.GetAttribute(Class333.aWx()));
				Setting setting = BcN.method_32(new DataIdAndAttrId(dataId, attrId));
				if (setting != null)
				{
					xmlReader_0.Read();
					byte[] array = Class24.smethod_1(xmlReader_0.Value);
					byte[] array2 = (BcN.aWR ? array : Class23.smethod_7(array, setting.method_199()));
					if (bool_0)
					{
						setting.method_245(new byte[setting.method_278()]);
						for (int i = 0; i < setting.method_244().Length; i++)
						{
							if (i >= array2.Length)
							{
								setting.method_244()[i] = 0;
							}
							else
							{
								setting.method_244()[i] = array2[i];
							}
						}
					}
					else
					{
						setting.method_275(array2, bool_0: false);
					}
					xmlReader_0.Skip();
				}
			}
			xmlReader_0.Read();
		}
	}

	private void method_5(Stream stream_0)
	{
		try
		{
			List<string> list = Class31.smethod_8(stream_0, Class19.smethod_1());
			if (list.Count <= 1)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				string text = list[i];
				if (!text.EndsWith(Class333.smethod_1965()))
				{
					continue;
				}
				Stream stream_1 = null;
				if (Class31.smethod_5(stream_0, text, out stream_1, Class19.smethod_1()))
				{
					byte[] bytes = null;
					using (MemoryStream memoryStream = new MemoryStream())
					{
						stream_1.CopyTo(memoryStream);
						bytes = memoryStream.ToArray();
					}
					Class286 @class = new Class288(stream_1).method_0();
					if (@class != null && BcN.awF.ContainsKey(@class.BCx))
					{
						lock (Form23.object_0)
						{
							if (!Form23.dictionary_1.ContainsKey(@class.BCw))
							{
								Class256 class2 = BcN.awF[@class.BCx];
								string text2 = Form23.string_17 + class2.method_81();
								if (!Directory.Exists(text2))
								{
									Directory.CreateDirectory(text2);
								}
								string text3 = text2 + Class333.smethod_177() + text;
								if (File.Exists(text3))
								{
									text3 = text2 + Class333.smethod_177() + Path.GetFileNameWithoutExtension(text3) + Class333.smethod_325() + @class.BCX + Class333.smethod_1965();
								}
								File.WriteAllBytes(text3, bytes);
								Class287 class3 = new Class287();
								class3.BcF = @class;
								class3.Bcf = text3;
								Form23.smethod_91(@class.BCw, class3);
							}
						}
					}
				}
				stream_1?.Close();
			}
		}
		catch
		{
		}
	}

	private void method_6(Stream stream_0, bool bool_0, bool bool_1)
	{
		List<string> list = null;
		try
		{
			list = Class31.smethod_8(stream_0, Class19.smethod_1());
		}
		catch
		{
			return;
		}
		if (list == null || list.Count <= 1)
		{
			return;
		}
		string string_ = null;
		if (bool_0)
		{
			Form23.smethod_19(Form23.string_11, out string_);
		}
		else if (bool_1)
		{
			Form23.smethod_19(Form23.string_12, out string_);
		}
		else
		{
			Form23.smethod_19(Form23.string_10, out string_);
		}
		if (string_ != null)
		{
			Class23.smethod_3(string_);
		}
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i];
			try
			{
				if (!text.StartsWith(Class333.smethod_2009()) || text.Length <= Class333.smethod_2009().Length + 1)
				{
					continue;
				}
				Stream stream_1 = null;
				if (Class31.smethod_5(stream_0, text, out stream_1, Class19.smethod_1()))
				{
					byte[] byte_ = null;
					using (MemoryStream memoryStream = new MemoryStream())
					{
						stream_1.CopyTo(memoryStream);
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
							string text4 = text.Substring(length);
							if (bool_0)
							{
								Form23.smethod_20(Form23.string_11, text4, byte_, text3, out string_);
							}
							else if (bool_1)
							{
								Form23.smethod_20(Form23.string_12, text4, byte_, text3, out string_);
							}
							else
							{
								Form23.smethod_20(Form23.string_10, text4, byte_, text3, out string_);
								if (string_ != null)
								{
									Class23.smethod_3(string_);
								}
								Form23.smethod_18(BcN, text4, byte_, text3, out string_);
							}
							if (string_ != null)
							{
								Class23.smethod_3(string_);
							}
						}
					}
				}
				stream_1?.Close();
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.awt() + text + Class333.smethod_1802() + ex.Message);
			}
		}
	}

	internal static Class240 smethod_0(string string_0)
	{
		XmlReader xmlReader = null;
		Stream stream = File.OpenRead(string_0);
		Stream stream_ = null;
		bool flag;
		try
		{
			flag = Class31.smethod_7(stream);
		}
		catch (Exception)
		{
			flag = false;
		}
		if (flag)
		{
			if (!Class31.smethod_5(stream, Class333.aGw(), out stream_, Class19.smethod_1()))
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
		xmlReader.Read();
		while (xmlReader.NodeType != XmlNodeType.Element)
		{
			xmlReader.Read();
		}
		Class14 @class = null;
		int axS = -1;
		int axs = -1;
		byte[] array = null;
		bool flag2 = false;
		bool flag3 = false;
		if (!xmlReader.IsEmptyElement)
		{
			xmlReader.Read();
			while (xmlReader.IsStartElement())
			{
				bool flag4 = true;
				if (xmlReader.Name == Class333.aGX())
				{
					if (!xmlReader.IsEmptyElement)
					{
						for (; xmlReader.IsStartElement() && (@class == null || array == null || !flag2 || !flag3); xmlReader.Read())
						{
							string name = xmlReader.Name;
							if (name == null)
							{
								continue;
							}
							switch (name.Length)
							{
							case 3:
							{
								char c = name[0];
								if (c != 'M')
								{
									if (c != 'T' || !(name == Class333.aGx()))
									{
										continue;
									}
								}
								else if (!(name == Class333.aGY()))
								{
									continue;
								}
								goto IL_037c;
							}
							case 7:
								switch (name[1])
								{
								case 'e':
									if (name == Class333.smethod_194())
									{
										xmlReader.Read();
										string text = string.Empty;
										byte[] array2 = Class24.smethod_1(xmlReader.Value);
										foreach (byte b in array2)
										{
											text += (char)b;
										}
										@class = new Class14(text, bool_0: false);
										xmlReader.Skip();
									}
									break;
								case 'a':
									if (name == Class333.agg())
									{
										xmlReader.Read();
										axs = int.Parse(xmlReader.Value, NumberStyles.AllowHexSpecifier);
										flag3 = true;
										xmlReader.Skip();
									}
									break;
								}
								continue;
							case 8:
							{
								char c = name[0];
								if (c != 'F')
								{
									if (c == 'H')
									{
										if (name == Class333.aGZ())
										{
											xmlReader.Read();
											string value = xmlReader.Value;
											xmlReader.Skip();
											array = Class24.smethod_1(value);
										}
										continue;
									}
									if (c != 'P' || !(name == Class333.aGz()))
									{
										continue;
									}
								}
								else if (!(name == Class333.agA()))
								{
									continue;
								}
								break;
							}
							case 9:
								if (name == Class333.agG())
								{
									xmlReader.Read();
									axS = int.Parse(xmlReader.Value, NumberStyles.AllowHexSpecifier);
									flag2 = true;
									xmlReader.Skip();
								}
								continue;
							case 10:
								if (!(name == Class333.aGy()))
								{
									continue;
								}
								goto IL_037c;
							case 11:
							{
								char c = name[0];
								if (c != 'I')
								{
									if (c != 'P' || !(name == Class333.agB()))
									{
										continue;
									}
								}
								else if (!(name == Class333.aga()))
								{
									continue;
								}
								break;
							}
							case 12:
								if (!(name == Class333.smethod_2615()))
								{
									continue;
								}
								goto IL_037c;
							case 14:
							{
								char c = name[7];
								if (c != 'E')
								{
									if (c != 'N' || !(name == Class333.agc()))
									{
										continue;
									}
								}
								else if (!(name == Class333.agC()))
								{
									continue;
								}
								break;
							}
							case 15:
								if (!(name == Class333.agb()))
								{
									continue;
								}
								break;
							case 17:
								if (!(name == Class333.agd()))
								{
									continue;
								}
								break;
							case 18:
								if (!(name == Class333.agD()))
								{
									continue;
								}
								break;
							case 20:
								if (!(name == Class333.agF()))
								{
									continue;
								}
								break;
							case 21:
							{
								char c = name[7];
								if (c != 'D')
								{
									if (c != 'S' || !(name == Class333.age()))
									{
										continue;
									}
								}
								else if (!(name == Class333.agE()))
								{
									continue;
								}
								break;
							}
							case 27:
								if (!(name == Class333.agf()))
								{
									continue;
								}
								break;
							default:
								continue;
								IL_037c:
								xmlReader.Skip();
								continue;
							}
							xmlReader.Read();
							xmlReader.Skip();
						}
					}
				}
				else
				{
					flag4 = false;
				}
				if (!flag4)
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
		Class240 result = null;
		if (@class != null && array != null)
		{
			result = new Class240
			{
				axS = axS,
				axs = axs,
				axT = @class,
				axt = array
			};
		}
		return result;
	}
}
