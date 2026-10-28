using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using ns0;
using ns4;
using ns7;

namespace ns6;

internal static class Class305
{
	private class Class306
	{
		internal int BsY;

		internal List<int> Bsy = new List<int>();

		internal List<int> BsZ = new List<int>();

		internal Class14 Bsz;

		internal string BTA;

		public override string ToString()
		{
			string text = (string.IsNullOrEmpty(BTA) ? string.Empty : (Class333.BEq() + BTA));
			return Class333.BER() + BsY + Class333.BEr() + Bsy.Count + Class333.BES() + Bsz.ToString() + text;
		}
	}

	private static readonly string BDF = Form23.string_4 + Class333.axw();

	private static readonly string BDf = Form23.string_4 + Class333.axX();

	private static List<Class306> BDG = new List<Class306>();

	private static readonly object BDg = new object();

	internal static void smethod_0()
	{
		lock (BDg)
		{
			BDG.Clear();
			try
			{
				if (File.Exists(BDf))
				{
					byte[] array = File.ReadAllBytes(BDf);
					byte[] array2 = new byte[12];
					Array.Copy(array, 0, array2, 0, 12);
					int num = array.Length - 12 - 16;
					byte[] array3 = new byte[num];
					byte[] array4 = new byte[16];
					Array.Copy(array, 12, array3, 0, num);
					Array.Copy(array, 12 + num, array4, 0, 16);
					byte[] array5 = new byte[num];
					using (AesGcm aesGcm = new AesGcm(new byte[16]
					{
						71, 150, 100, 53, 107, 52, 71, 229, 74, 103,
						82, 60, 86, 82, 71, 65
					}, 16))
					{
						aesGcm.Decrypt(array2, array3, array4, array5);
					}
					MemoryStream memoryStream = new MemoryStream(array5);
					smethod_1(memoryStream);
					memoryStream.Close();
				}
				else if (File.Exists(BDF))
				{
					FileStream fileStream = new FileStream(BDF, FileMode.Open);
					smethod_1(fileStream);
					fileStream.Close();
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.axU() + ex.Message);
			}
		}
	}

	private static void smethod_1(Stream stream_0)
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
				if (xmlReader.Name == Class333.axu())
				{
					smethod_2(xmlReader);
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
	}

	private static void smethod_2(XmlReader xmlReader_0)
	{
		Class306 @class = new Class306();
		@class.BsY = int.Parse(xmlReader_0.GetAttribute(Class333.acm()));
		string attribute = xmlReader_0.GetAttribute(Class333.acN());
		if (!string.IsNullOrEmpty(attribute))
		{
			string[] array = attribute.Split(',');
			foreach (string s in array)
			{
				@class.Bsy.Add(int.Parse(s));
			}
		}
		string attribute2 = xmlReader_0.GetAttribute(Class333.axV());
		if (!string.IsNullOrEmpty(attribute2))
		{
			string[] array = attribute2.Split(',');
			foreach (string s2 in array)
			{
				@class.BsZ.Add(int.Parse(s2));
			}
		}
		@class.Bsz = new Class14(xmlReader_0.GetAttribute(Class333.axv()), bool_0: false);
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.axu()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.axW())
			{
				smethod_3(xmlReader_0, @class);
			}
			xmlReader_0.Read();
		}
		BDG.Add(@class);
	}

	private static void smethod_3(XmlReader xmlReader_0, Class306 class306_0)
	{
		xmlReader_0.Read();
		if (xmlReader_0.Name == Class333.axW() && xmlReader_0.NodeType == XmlNodeType.EndElement)
		{
			class306_0.BTA = string.Empty;
			return;
		}
		class306_0.BTA = xmlReader_0.Value;
		xmlReader_0.Skip();
	}

	internal static bool smethod_4(Class316 class316_0, out string string_0, out bool bool_0)
	{
		lock (BDg)
		{
			string_0 = string.Empty;
			bool_0 = true;
			foreach (Class306 item in BDG)
			{
				if (item.BsY == class316_0.BdC.axS && item.Bsz == class316_0.BdC.axT && (item.Bsy.Count == 0 || item.Bsy.Contains(class316_0.BdC.axs)))
				{
					bool flag = false;
					if (item.BsZ.Count != 0 && class316_0.Bdc.Count != 0)
					{
						bool_0 = false;
						foreach (ushort item2 in class316_0.Bdc)
						{
							if (item.BsZ.Contains(item2))
							{
								flag = true;
								break;
							}
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						if (!string.IsNullOrWhiteSpace(item.BTA))
						{
							string_0 = item.BTA;
						}
						return true;
					}
				}
				bool_0 = true;
			}
			return false;
		}
	}

	internal static void smethod_5()
	{
		if (!Directory.Exists(Class320.Bdl) || BDG.Count == 0)
		{
			return;
		}
		string[] files = Directory.GetFiles(Class320.Bdl, Class333.aCe());
		for (int num = files.Length - 1; num >= 0; num--)
		{
			string string_ = files[num];
			Class318 @class = Class307.smethod_0(string_);
			if (@class != null)
			{
				foreach (Class316 item in @class.BdF)
				{
					if (smethod_4(item, out var _, out var bool_) && bool_)
					{
						Class307.smethod_2(string_, bool_0: false);
						break;
					}
				}
			}
		}
		Class307.smethod_7();
	}
}
