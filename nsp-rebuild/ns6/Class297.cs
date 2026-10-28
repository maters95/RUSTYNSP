using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns7;

namespace ns6;

internal class Class297
{
	private string Bcn;

	private Framework BcO;

	private bool Bco;

	internal Class297(string string_0, Framework framework_0, bool bool_0)
	{
		Bcn = string_0;
		BcO = framework_0;
		Bco = bool_0;
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
		byte[] array = null;
		xmlWriter.WriteStartElement(Class333.awc());
		xmlWriter.WriteStartElement(Class333.aGX());
		xmlWriter.WriteStartElement(Class333.aGx());
		array = Encoding.ASCII.GetBytes(Class333.awU());
		xmlWriter.WriteBinHex(array, 0, array.Length);
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.aGY());
		byte[] buffer = BcO.method_18();
		using (MD5 mD = MD5.Create())
		{
			string s = Class24.smethod_0(mD.ComputeHash(buffer));
			array = Encoding.ASCII.GetBytes(s);
			xmlWriter.WriteBinHex(array, 0, array.Length);
		}
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.smethod_2615());
		xmlWriter.WriteString(BcO.aXc);
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.aGy());
		byte[] array2 = new byte[4] { 0, 0, 0, 4 };
		xmlWriter.WriteBinHex(array2, 0, array2.Length);
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.aGZ());
		xmlWriter.WriteBinHex(BcO.method_11(), 0, BcO.method_11().Length);
		xmlWriter.WriteEndElement();
		foreach (Setting item in BcO.aWu)
		{
			xmlWriter.WriteStartElement(item.method_148());
			xmlWriter.WriteAttributeString(Class333.aIP(), item.method_64().ToString());
			xmlWriter.WriteAttributeString(Class333.aWx(), item.method_67().ToString());
			byte[] array3 = item.method_259();
			byte[] array4 = (BcO.aWR ? array3 : Class23.smethod_7(array3, item.method_199()));
			xmlWriter.WriteBinHex(array4, 0, array4.Length);
			xmlWriter.WriteEndElement();
		}
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement(Class333.smethod_796());
		method_1(xmlWriter, BcO.aWS);
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndElement();
		xmlWriter.Close();
		memoryStream.Flush();
		if (Bco)
		{
			List<KeyValuePair<string, byte[]>> list = method_2();
			List<KeyValuePair<string, byte[]>> list2 = method_3();
			KeyValuePair<string, byte[]>[] array5 = new KeyValuePair<string, byte[]>[1 + list.Count + list2.Count];
			array5[0] = new KeyValuePair<string, byte[]>(Class333.aGw(), memoryStream.ToArray());
			for (int i = 0; i < list.Count; i++)
			{
				KeyValuePair<string, byte[]> keyValuePair = list[i];
				array5[1 + i] = keyValuePair;
			}
			for (int j = 0; j < list2.Count; j++)
			{
				KeyValuePair<string, byte[]> keyValuePair2 = list2[j];
				array5[1 + list.Count + j] = keyValuePair2;
			}
			Class31.smethod_3(Bcn, Class19.smethod_1(), bool_1: true, array5);
		}
		else
		{
			using StreamWriter streamWriter = new StreamWriter(Bcn);
			memoryStream.Position = 0L;
			string value = new StreamReader(memoryStream).ReadToEnd();
			streamWriter.Write(value);
		}
		memoryStream.Close();
	}

	private void method_1(XmlWriter xmlWriter_0, List<SettingOrSpecialObject> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			method_1(xmlWriter_0, settingOrSpecialObject.method_1());
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if (setting.method_148().Length == 0 && setting.method_205())
				{
					xmlWriter_0.WriteStartElement(Class333.aGi());
					xmlWriter_0.WriteAttributeString(Class333.aIP(), setting.method_64().ToString());
					xmlWriter_0.WriteAttributeString(Class333.aWx(), setting.method_67().ToString());
					byte[] array = setting.method_259();
					byte[] array2 = (BcO.aWR ? array : Class23.smethod_7(array, setting.method_199()));
					xmlWriter_0.WriteBinHex(array2, 0, array2.Length);
					xmlWriter_0.WriteEndElement();
				}
			}
		}
	}

	private List<KeyValuePair<string, byte[]>> method_2()
	{
		List<KeyValuePair<string, byte[]>> list = new List<KeyValuePair<string, byte[]>>();
		List<string> list2 = new List<string>();
		foreach (MenuNode value2 in BcO.awX.Values)
		{
			if (value2.method_80() != null && value2.method_80().BcF != null && !string.IsNullOrEmpty(value2.method_80().Bcf) && value2.method_80().Bcf.EndsWith(Class333.smethod_1965()))
			{
				list2.Add(value2.method_80().Bcf);
			}
		}
		foreach (string item in list2)
		{
			try
			{
				string fileName = Path.GetFileName(item);
				bool flag = false;
				foreach (KeyValuePair<string, byte[]> item2 in list)
				{
					if (item2.Key == fileName)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					byte[] value = File.ReadAllBytes(item);
					list.Add(new KeyValuePair<string, byte[]>(fileName, value));
				}
			}
			catch
			{
			}
		}
		return list;
	}

	private List<KeyValuePair<string, byte[]>> method_3()
	{
		List<KeyValuePair<string, byte[]>> list = new List<KeyValuePair<string, byte[]>>();
		if (BcO.awv.Count != 0 && Directory.Exists(Form23.string_10))
		{
			string[] array = null;
			try
			{
				array = Directory.GetDirectories(Form23.string_10);
			}
			catch (Exception ex)
			{
				array = null;
				Class23.smethod_3(Class333.awu() + Form23.string_10 + Class333.smethod_2015() + ex.Message);
			}
			if (array != null)
			{
				string[] array2 = array;
				foreach (string text in array2)
				{
					string[] array3 = null;
					try
					{
						array3 = Directory.GetFiles(text);
					}
					catch (Exception ex2)
					{
						array3 = null;
						Class23.smethod_3(Class333.awV() + text + Class333.smethod_2015() + ex2.Message);
					}
					if (array3 == null)
					{
						continue;
					}
					string[] array4 = array3;
					foreach (string text2 in array4)
					{
						try
						{
							byte[] value = File.ReadAllBytes(text2);
							string name = new DirectoryInfo(text).Name;
							string fileName = Path.GetFileName(text2);
							string key = Class333.aWz() + name + Class333.smethod_177() + fileName;
							list.Add(new KeyValuePair<string, byte[]>(key, value));
						}
						catch (Exception ex3)
						{
							Class23.smethod_3(Class333.awv() + text2 + Class333.smethod_2015() + ex3.Message);
						}
					}
				}
			}
		}
		return list;
	}
}
