using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using NSP.SettingsFramework;
using ns0;
using ns3;
using ns4;
using ns7;

namespace ns6;

internal class Class289
{
	private Class286 BcH;

	private string Bch;

	private Framework BcI;

	private bool Bci;

	private MenuNode BcJ;

	private Image Bcj;

	internal Class289(string string_0, Class286 class286_0, Framework framework_0, MenuNode menuNode_0, bool bool_0, Image image_0)
	{
		Bch = string_0;
		BcH = class286_0;
		BcI = framework_0;
		BcJ = menuNode_0;
		Bci = bool_0;
		Bcj = image_0;
	}

	internal void method_0()
	{
		MemoryStream memoryStream = new MemoryStream();
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.ConformanceLevel = ConformanceLevel.Document;
		xmlWriterSettings.CloseOutput = false;
		xmlWriterSettings.Indent = true;
		xmlWriterSettings.NewLineChars = Environment.NewLine;
		XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
		xmlWriter.WriteStartElement(Class333.awc());
		xmlWriter.WriteStartElement(Class333.aGX());
		xmlWriter.WriteStartElement(Class333.aWQ());
		xmlWriter.WriteString(BcH.BCX);
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.aWq());
		xmlWriter.WriteString(BcH.BCY.ToString());
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.aWR());
		xmlWriter.WriteString(BcH.BCZ.ToString());
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.aWr());
		xmlWriter.WriteString(BcH.BCz.ToString());
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.aWS());
		xmlWriter.WriteString(BcH.BcA.ToString());
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.aWs());
		xmlWriter.WriteString(BcH.BCx.ToString());
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.aWT());
		xmlWriter.WriteString(BcH.BCy);
		xmlWriter.WriteEndElement();
		if (!string.IsNullOrEmpty(BcH.BcB) && Bcj != null)
		{
			xmlWriter.WriteStartElement(Class333.ahj());
			xmlWriter.WriteAttributeString(Class333.ahQ(), Class333.aWu());
			xmlWriter.WriteString(BcH.BcB);
			xmlWriter.WriteEndElement();
		}
		xmlWriter.WriteStartElement(Class333.aWt());
		xmlWriter.WriteString(BcH.Bca);
		xmlWriter.WriteEndElement();
		foreach (KeyValuePair<string, string> item in BcH.Bcb)
		{
			xmlWriter.WriteStartElement(Class333.aGx());
			xmlWriter.WriteAttributeString(Class333.ahQ(), item.Key);
			xmlWriter.WriteString(item.Value);
			xmlWriter.WriteEndElement();
		}
		foreach (string key in BcH.BcC.Keys)
		{
			xmlWriter.WriteStartElement(Class333.aWU());
			xmlWriter.WriteAttributeString(Class333.aWV(), key);
			xmlWriter.WriteStartElement(Class333.aWv());
			xmlWriter.WriteString(BcH.BcC[key].BsP);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement(Class333.aWW());
			xmlWriter.WriteString(BcH.BcC[key].Bsp);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement(Class333.aWw());
			xmlWriter.WriteString(BcH.BcC[key].BsQ);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndElement();
		}
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.smethod_796());
		method_2(xmlWriter);
		xmlWriter.WriteEndElement();
		xmlWriter.Flush();
		BcH.BCw = Class24.smethod_0(method_6(memoryStream));
		xmlWriter.WriteStartElement(Class333.aWp());
		xmlWriter.WriteString(BcH.BCw);
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndElement();
		xmlWriter.Close();
		memoryStream.Flush();
		if (Bci)
		{
			List<KeyValuePair<string, byte[]>> list = new List<KeyValuePair<string, byte[]>>();
			list.Add(new KeyValuePair<string, byte[]>(Class333.aWP(), memoryStream.ToArray()));
			byte[] array = method_1();
			if (array != null)
			{
				list.Add(new KeyValuePair<string, byte[]>(BcH.BcB, array));
			}
			if (BcI.awv.Count != 0)
			{
				List<KeyValuePair<string, byte[]>> collection = method_7();
				list.AddRange(collection);
			}
			KeyValuePair<string, byte[]>[] dataList = list.ToArray();
			Class31.smethod_3(Bch, Class19.smethod_1(), bool_1: true, dataList);
		}
		else
		{
			memoryStream.Position = 0L;
			string value = new StreamReader(memoryStream).ReadToEnd();
			if (File.Exists(Bch))
			{
				File.Delete(Bch);
			}
			using (StreamWriter streamWriter = new StreamWriter(Bch))
			{
				streamWriter.Write(value);
			}
			byte[] array2 = method_1();
			if (array2 != null)
			{
				string path = Path.Combine(Path.GetDirectoryName(Bch), BcH.BcB);
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				File.WriteAllBytes(path, array2);
			}
		}
		memoryStream.Close();
	}

	private byte[] method_1()
	{
		try
		{
			if (!string.IsNullOrEmpty(BcH.BcB) && Bcj != null)
			{
				byte[] result = null;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using Image image = new Bitmap(Bcj);
					image.Save(memoryStream, Bcj.RawFormat);
					result = memoryStream.ToArray();
				}
				return result;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	private void method_2(XmlWriter xmlWriter_0)
	{
		if (!BcI.awF.ContainsKey(BcH.BCx))
		{
			return;
		}
		Class256 @class = BcI.awF[BcH.BCx];
		foreach (int item in @class.method_74())
		{
			method_3(xmlWriter_0, item);
		}
		if (@class.method_73().Count == 0 && @class.method_75().Count == 0 && @class.method_76().Count == 0)
		{
			return;
		}
		HashSet<DataIdAndAttrId> hashSet = MenuNode.smethod_1(BcJ);
		foreach (int item2 in @class.method_73())
		{
			method_4(xmlWriter_0, hashSet, item2);
		}
		foreach (int key in @class.method_75().Keys)
		{
			foreach (int item3 in @class.method_75()[key])
			{
				method_5(xmlWriter_0, hashSet, item3, key, 0);
			}
		}
		foreach (int key2 in @class.method_76().Keys)
		{
			Class244 class244_ = BcI.method_31(key2) as Class244;
			List<Setting> list = new List<Setting>();
			PortFunction.smethod_31(class244_, list, bool_0: false);
			foreach (Setting item4 in list)
			{
				hashSet.Add(item4.method_69());
			}
			List<Table> list2 = new List<Table>();
			PortFunction.smethod_34(class244_, list2, bool_0: false);
			foreach (Table item5 in list2)
			{
				foreach (DataIdAndAttrId item6 in item5.GetIdsContained())
				{
					hashSet.Add(item6);
				}
			}
			foreach (int item7 in @class.method_76()[key2])
			{
				method_5(xmlWriter_0, hashSet, item7, 0, key2);
			}
		}
	}

	private void method_3(XmlWriter xmlWriter_0, int int_0)
	{
		Setting setting = BcI.method_31(int_0);
		if (setting == null)
		{
			return;
		}
		xmlWriter_0.WriteStartElement(Class333.aGi());
		xmlWriter_0.WriteAttributeString(Class333.aIP(), setting.method_64().ToString());
		xmlWriter_0.WriteAttributeString(Class333.aWx(), setting.method_67().ToString());
		byte[] array = setting.method_259();
		if (BcI.awX.ContainsKey(int_0))
		{
			string key = Class24.smethod_0(array);
			if (Form23.dictionary_1.ContainsKey(key))
			{
				string bCX = Form23.dictionary_1[key].BcF.BCX;
				xmlWriter_0.WriteAttributeString(Class333.aWY(), bCX);
			}
		}
		byte[] array2 = (BcI.aWR ? array : Class23.smethod_7(array, setting.method_199()));
		xmlWriter_0.WriteBinHex(array2, 0, array2.Length);
		xmlWriter_0.WriteEndElement();
	}

	private void method_4(XmlWriter xmlWriter_0, HashSet<DataIdAndAttrId> hashSet_0, int int_0)
	{
		Setting setting = Class286.smethod_0(BcI, hashSet_0, int_0);
		if (setting != null)
		{
			xmlWriter_0.WriteStartElement(Class333.smethod_1323());
			xmlWriter_0.WriteAttributeString(Class333.aIP(), int_0.ToString());
			xmlWriter_0.WriteAttributeString(Class333.aWx(), Class333.smethod_184());
			byte[] array = setting.method_259();
			byte[] array2 = (BcI.aWR ? array : Class23.smethod_7(array, setting.method_199()));
			xmlWriter_0.WriteBinHex(array2, 0, array2.Length);
			xmlWriter_0.WriteEndElement();
		}
	}

	private void method_5(XmlWriter xmlWriter_0, HashSet<DataIdAndAttrId> hashSet_0, int int_0, int int_1, int int_2)
	{
		Setting setting = Class286.smethod_1(BcI, hashSet_0, int_0, int_1, int_2);
		if (setting != null)
		{
			xmlWriter_0.WriteStartElement(Class333.smethod_1323());
			xmlWriter_0.WriteAttributeString(Class333.aIP(), int_0.ToString());
			if (int_2 != 0)
			{
				xmlWriter_0.WriteAttributeString(Class333.aWZ(), int_2.ToString());
			}
			else if (int_1 != 0)
			{
				xmlWriter_0.WriteAttributeString(Class333.aWy(), int_1.ToString());
			}
			xmlWriter_0.WriteAttributeString(Class333.aWx(), Class333.smethod_184());
			byte[] array = setting.method_259();
			byte[] array2 = (BcI.aWR ? array : Class23.smethod_7(array, setting.method_199()));
			xmlWriter_0.WriteBinHex(array2, 0, array2.Length);
			xmlWriter_0.WriteEndElement();
		}
	}

	private byte[] method_6(MemoryStream memoryStream_0)
	{
		byte[] buffer = memoryStream_0.ToArray();
		MD5 mD = MD5.Create();
		byte[] result = mD.ComputeHash(buffer);
		mD.Dispose();
		return result;
	}

	private List<KeyValuePair<string, byte[]>> method_7()
	{
		List<KeyValuePair<string, byte[]>> list = new List<KeyValuePair<string, byte[]>>();
		if (BcI.awF.ContainsKey(BcH.BCx))
		{
			Class256 @class = BcI.awF[BcH.BCx];
			HashSet<DataIdAndAttrId> hashSet_ = MenuNode.smethod_1(BcJ);
			foreach (int item in @class.method_73())
			{
				Setting setting = Class286.smethod_0(BcI, hashSet_, item);
				if (setting == null || !setting.method_35() || !setting.method_171())
				{
					continue;
				}
				string text = setting.method_260();
				if (string.IsNullOrEmpty(text) || !text.StartsWith(Class333.smethod_1469()))
				{
					continue;
				}
				string text2 = text.Substring(Class333.smethod_1469().Length);
				if (string.IsNullOrEmpty(text2))
				{
					continue;
				}
				string text3 = Class247.smethod_7(setting.method_174());
				if (text3 == null)
				{
					continue;
				}
				string text4 = Class333.aWz() + text3 + Class333.smethod_177() + text2;
				bool flag = false;
				foreach (KeyValuePair<string, byte[]> item2 in list)
				{
					if (item2.Key == text4)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
				try
				{
					string text5 = Form23.string_10 + Class333.smethod_176() + text3 + Class333.smethod_176();
					if (File.Exists(text5 + text2))
					{
						byte[] value = File.ReadAllBytes(text5 + text2);
						list.Add(new KeyValuePair<string, byte[]>(text4, value));
					}
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.awD() + text + Class333.smethod_2015() + ex.Message);
				}
			}
		}
		return list;
	}
}
