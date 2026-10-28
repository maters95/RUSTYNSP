using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Timers;
using System.Xml;
using Microsoft.Win32;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns7;

namespace NSP.Internet;

public class StatsReporter
{
	private enum Enum110
	{
		Bst,
		BsU,
		Bsu,
		BsV
	}

	private enum Enum111
	{
		Bsv,
		BsW,
		Bsw
	}

	private class Class303
	{
		public string BsX;

		public object Bsx;
	}

	private int[] BDA = new int[4] { 1501, 1502, 1503, 3800 };

	private int[] BDa = new int[5] { 4, 4158, 4159, 16433, 16434 };

	private System.Timers.Timer BDB;

	private List<KeyValuePair<string, object>> BDb;

	private List<KeyValuePair<string, object>> BDC;

	private List<KeyValuePair<string, object>> BDc;

	private static readonly object BDD = new object();

	private static bool BDd = false;

	public bool UserOptInPrivacy
	{
		get
		{
			return method_0();
		}
		set
		{
			method_1(value);
		}
	}

	public Version LastAgreedPrivacyDocumentVer
	{
		get
		{
			return method_2();
		}
		set
		{
			method_3(value);
		}
	}

	public static bool StatsStorageInProgress => BDd;

	private bool method_0()
	{
		try
		{
			int num = 0;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey(Class333.smethod_212());
				if (registryKey2 != null)
				{
					object value = registryKey2.GetValue(Class333.aXu());
					if (value != null)
					{
						num = (int)value;
					}
				}
				else
				{
					Class23.smethod_3(Class333.aXV());
				}
			}
			return num == 1;
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aXv() + ex.Message);
			return false;
		}
	}

	private void method_1(bool bool_0)
	{
		int num = (bool_0 ? 1 : 0);
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
			using RegistryKey registryKey2 = registryKey.CreateSubKey(Class333.smethod_212(), writable: true);
			if (registryKey2 != null)
			{
				registryKey2.SetValue(Class333.aXu(), num);
			}
			else
			{
				Class23.smethod_3(Class333.aXW());
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aXw() + ex.Message);
		}
	}

	public bool UserPrivacyOptionRegistryExists()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(Class333.smethod_212());
			if (registryKey2 != null)
			{
				return registryKey2.GetValue(Class333.aXu()) != null;
			}
			Class23.smethod_3(Class333.aXX());
			return false;
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aXx() + ex.Message);
			return false;
		}
	}

	private Version method_2()
	{
		try
		{
			Version result = null;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey(Class333.smethod_212());
				if (registryKey2 != null)
				{
					object value = registryKey2.GetValue(Class333.aXY());
					if (value != null && !Version.TryParse((string)value, out result))
					{
						result = null;
					}
				}
				else
				{
					Class23.smethod_3(Class333.aXy());
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aXZ() + ex.Message);
			return null;
		}
	}

	private void method_3(Version version_0)
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
			using RegistryKey registryKey2 = registryKey.CreateSubKey(Class333.smethod_212(), writable: true);
			if (registryKey2 != null)
			{
				registryKey2.SetValue(Class333.aXY(), version_0);
			}
			else
			{
				Class23.smethod_3(Class333.aXz());
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.axA() + ex.Message);
		}
	}

	public bool LastAgreedPrivacyDocVerRegistryEntryExists()
	{
		try
		{
			Version result = null;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey(Class333.smethod_212());
				if (registryKey2 != null)
				{
					object value = registryKey2.GetValue(Class333.aXY());
					if (value != null && !Version.TryParse((string)value, out result))
					{
						result = null;
					}
				}
				else
				{
					Class23.smethod_3(Class333.axa());
				}
			}
			return result != null;
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.axB() + ex.Message);
			return false;
		}
	}

	public void DeleteLastAgreedPrivacyDocVerRegistryEntry()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(Class333.smethod_212(), writable: true);
			if (registryKey2 != null)
			{
				registryKey2.DeleteValue(Class333.aXY());
			}
			else
			{
				Class23.smethod_3(Class333.axb());
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.axC() + ex.Message);
		}
	}

	public StatsReporter()
	{
		BDB = new System.Timers.Timer();
		BDB.Interval = 10000.0;
		BDB.Elapsed += BDB_Elapsed;
		BDB.Start();
	}

	private static Class303 smethod_0(string string_0, object object_0)
	{
		return new Class303
		{
			BsX = string_0,
			Bsx = object_0
		};
	}

	private void method_4()
	{
		string aXc = Form23.framework_1.aXc;
		int awZ = Form23.framework_1.awZ;
		int awz = Form23.framework_1.awz;
		string object_ = Class333.axc();
		if (UserOptInPrivacy)
		{
			object_ = aXc;
		}
		List<Class303> list = new List<Class303>();
		list.Add(smethod_0(Class333.avt(), object_));
		list.Add(smethod_0(Class333.axD(), awZ));
		list.Add(smethod_0(Class333.agI(), awz));
		list.Add(smethod_0(Class333.axd(), -1));
		list.Add(smethod_0(Class333.axE(), 0));
		BDb = new List<KeyValuePair<string, object>>(method_8(list));
	}

	private void method_5()
	{
		List<Class303> list = new List<Class303>();
		list.Add(smethod_0(Class333.axe(), Form23.framework_1.aXA.method_0()));
		list.Add(smethod_0(Class333.axF(), Form23.framework_1.aXA.method_1()));
		list.Add(smethod_0(Class333.axf(), Form23.framework_1.aXA.method_2()));
		list.Add(smethod_0(Class333.axG(), Form23.framework_1.aXA.method_3()));
		list.Add(smethod_0(Class333.axg(), Form23.framework_1.aXA.method_4()));
		list.Add(smethod_0(Class333.axH(), -1));
		BDC = new List<KeyValuePair<string, object>>(method_8(list));
	}

	private void method_6(List<SettingOrSpecialObject> list_0, List<Class303> list_1)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				int num = setting.method_277();
				bool flag = setting.method_6() is Table || setting.method_6() is TableAxis;
				bool flag2 = Enumerable.Contains(BDA, setting.method_64());
				bool flag3 = Enumerable.Contains(BDa, setting.method_64());
				if (!flag2 && !flag && !setting.method_169() && (flag3 || !setting.method_207()))
				{
					if (setting.method_70() == 0)
					{
						if (num == 1)
						{
							list_1.Add(smethod_0(setting.method_64().ToString(), setting.method_256()));
						}
						else
						{
							int[] array = new int[num];
							for (int j = 0; j < num; j++)
							{
								array[j] = setting.method_258(j);
							}
							list_1.Add(smethod_0(setting.method_64().ToString(), array));
						}
					}
					else
					{
						string text = setting.method_260();
						if (string.IsNullOrEmpty(text))
						{
							text = Class333.smethod_186();
						}
						list_1.Add(smethod_0(setting.method_64().ToString(), text));
					}
				}
			}
			method_6(settingOrSpecialObject.method_1(), list_1);
		}
	}

	private void method_7()
	{
		List<Class303> list = new List<Class303>();
		method_6(Form23.framework_1.aWS, list);
		BDc = new List<KeyValuePair<string, object>>(method_8(list));
	}

	private List<KeyValuePair<string, object>> method_8(List<Class303> list_0)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
		foreach (Class303 item3 in list_0)
		{
			if (item3.BsX == Class333.smethod_2615())
			{
				item3.BsX = Class333.avt();
			}
			KeyValuePair<string, object> item = new KeyValuePair<string, object>(item3.BsX, item3.Bsx);
			list.Add(item);
		}
		string value = DateTime.UtcNow.ToString(Class333.ahR());
		KeyValuePair<string, object> item2 = new KeyValuePair<string, object>(Class333.axh(), value);
		list.Add(item2);
		return list;
	}

	private void BDB_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (Form23.framework_1 == null || !Form23.framework_1.method_5() || !Form23.smethod_28(Form23.framework_1.aXc, bool_53: true) || (Form23.int_0 & 0x20) != 0)
		{
			return;
		}
		bool flag = false;
		for (int i = 1; i < Form23.framework_1.aXc.Length; i++)
		{
			if (Form23.framework_1.aXc[i] != Form23.framework_1.aXc[i - 1])
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += method_9;
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void method_9(object sender, DoWorkEventArgs e)
	{
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(BDD, ref lockTaken);
			if (lockTaken)
			{
				method_4();
				method_5();
				method_7();
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.axI() + ex.Message);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(BDD);
			}
		}
	}

	public void StorePendingStats()
	{
		if (BDb != null && BDC != null && BDc != null && !BDd)
		{
			BDd = true;
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += method_10;
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void method_10(object sender, DoWorkEventArgs e)
	{
		lock (BDD)
		{
			method_11();
			BDd = false;
		}
	}

	private void method_11()
	{
		try
		{
			string text = Form23.string_4 + Class333.aBL();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string path = text + Class23.smethod_10(bool_1: true) + Class333.axi();
			MemoryStream memoryStream = new MemoryStream();
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.ConformanceLevel = ConformanceLevel.Document;
			xmlWriterSettings.CloseOutput = false;
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.NewLineChars = Environment.NewLine;
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
			xmlWriter.WriteStartElement(Class333.axJ());
			xmlWriter.WriteStartElement(Class333.axj());
			smethod_1(xmlWriter, BDb);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement(Class333.axK());
			smethod_1(xmlWriter, BDC);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement(Class333.axk());
			smethod_1(xmlWriter, BDc);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
			memoryStream.Flush();
			memoryStream.Position = 0L;
			using (StreamReader streamReader = new StreamReader(memoryStream))
			{
				string value = streamReader.ReadToEnd();
				using Aes aes = Aes.Create();
				aes.Key = Encoding.UTF8.GetBytes(Class333.axL());
				aes.IV = new byte[16];
				aes.Padding = PaddingMode.Zeros;
				using ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
				using MemoryStream memoryStream2 = new MemoryStream();
				using CryptoStream stream = new CryptoStream(memoryStream2, transform, CryptoStreamMode.Write);
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					streamWriter.Write(value);
				}
				byte[] bytes = memoryStream2.ToArray();
				File.WriteAllBytes(path, bytes);
			}
			File.SetAttributes(path, FileAttributes.Hidden);
			memoryStream.Close();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.axl() + ex.Message + Class333.smethod_180());
		}
	}

	private static void smethod_1(XmlWriter xmlWriter_0, List<KeyValuePair<string, object>> list_0)
	{
		foreach (KeyValuePair<string, object> item in list_0)
		{
			xmlWriter_0.WriteStartElement(Class333.axM());
			xmlWriter_0.WriteAttributeString(Class333.smethod_196(), item.Key);
			if (item.Value is string)
			{
				string text = item.Value as string;
				text = text.Replace('\\', ' ').Replace('/', ' ').Replace('<', ' ')
					.Replace('>', ' ')
					.Replace('\0', ' ');
				xmlWriter_0.WriteAttributeString(Class333.axm(), text);
			}
			else if (item.Value is int)
			{
				xmlWriter_0.WriteAttributeString(Class333.axN(), ((int)item.Value).ToString());
			}
			else if (item.Value is int[])
			{
				int[] array = item.Value as int[];
				string text2 = Class333.aJz();
				for (int i = 0; i < array.Length; i++)
				{
					text2 += array[i];
					if (i != array.Length - 1)
					{
						text2 += Class333.smethod_189();
					}
				}
				text2 += Class333.aGk();
				xmlWriter_0.WriteAttributeString(Class333.axn(), text2);
			}
			else
			{
				xmlWriter_0.WriteAttributeString(Class333.axO(), item.Value.ToString());
			}
			xmlWriter_0.WriteEndElement();
		}
	}
}
