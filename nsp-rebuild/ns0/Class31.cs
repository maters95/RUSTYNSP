using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using Ionic.Zip;
using ns7;

namespace ns0;

internal class Class31
{
	private ZipFile zipFile_0;

	private string string_0 = string.Empty;

	private string string_1 = string.Empty;

	private string string_2 = string.Empty;

	private string string_3 = string.Empty;

	private string string_4 = string.Empty;

	internal static DateTime dateTime_0 = new DateTime(1982, 1, 23, 23, 23, 23, 23, DateTimeKind.Utc);

	private bool bool_0 = true;

	internal static Class31 smethod_0(string string_5, string string_6, IEnumerable<string> ienumerable_0, string string_7)
	{
		ZipFile zipFile = new ZipFile();
		if (string_6 != null)
		{
			zipFile.Password = string_6;
			zipFile.Encryption = EncryptionAlgorithm.WinZipAes256;
		}
		foreach (string item in ienumerable_0)
		{
			string directoryName = Path.GetDirectoryName(item.Substring(string_7.Length));
			zipFile.AddFile(item, directoryName);
		}
		return new Class31(zipFile, string_5, string_6);
	}

	internal static void smethod_1(string string_5, string string_6, string string_7, FileInfo[] fileInfo_0)
	{
		smethod_2(string_5, string_6, string_7, fileInfo_0, bool_1: true);
	}

	internal static void smethod_2(string string_5, string string_6, string string_7, FileInfo[] fileInfo_0, bool bool_1)
	{
		using ZipFile zipFile = new ZipFile();
		zipFile.EmitTimesInWindowsFormatWhenSaving = true;
		if (string_7 != null)
		{
			zipFile.Password = string_7;
			zipFile.Encryption = EncryptionAlgorithm.WinZipAes256;
		}
		foreach (FileInfo fileInfo in fileInfo_0)
		{
			zipFile.AddFile(fileInfo.FullName, Class333.smethod_102());
		}
		if (bool_1)
		{
			foreach (ZipEntry entry in zipFile.Entries)
			{
				entry.SetEntryTimes(dateTime_0, dateTime_0, dateTime_0);
			}
		}
		zipFile.Save(string_5);
	}

	internal static void smethod_3(string string_5, string string_6, bool bool_1, params KeyValuePair<string, byte[]>[] dataList)
	{
		using ZipFile zipFile = new ZipFile();
		zipFile.EmitTimesInWindowsFormatWhenSaving = true;
		if (string_6 != null)
		{
			zipFile.Password = string_6;
			zipFile.Encryption = EncryptionAlgorithm.WinZipAes256;
		}
		for (int i = 0; i < dataList.Length; i++)
		{
			KeyValuePair<string, byte[]> keyValuePair = dataList[i];
			zipFile.AddEntry(keyValuePair.Key, keyValuePair.Value);
		}
		if (bool_1)
		{
			foreach (ZipEntry entry in zipFile.Entries)
			{
				entry.SetEntryTimes(dateTime_0, dateTime_0, dateTime_0);
			}
		}
		zipFile.Save(string_5);
	}

	internal static bool smethod_4(string string_5, string string_6, out Stream stream_0, string string_7)
	{
		stream_0 = null;
		bool result = false;
		using (ZipFile zipFile = new ZipFile(string_5))
		{
			zipFile.EmitTimesInWindowsFormatWhenSaving = true;
			if (string_7 != null)
			{
				zipFile.Password = string_7;
			}
			if (zipFile.ContainsEntry(string_6))
			{
				result = true;
				stream_0 = zipFile[string_6].OpenReader();
			}
		}
		return result;
	}

	internal static bool smethod_5(Stream stream_0, string string_5, out Stream stream_1, string string_6)
	{
		stream_1 = null;
		bool result = false;
		stream_0.Seek(0L, SeekOrigin.Begin);
		using (ZipFile zipFile = ZipFile.Read(stream_0))
		{
			zipFile.EmitTimesInWindowsFormatWhenSaving = true;
			if (string_6 != null)
			{
				zipFile.Password = string_6;
			}
			if (zipFile.ContainsEntry(string_5))
			{
				result = true;
				stream_1 = new MemoryStream();
				zipFile[string_5].Extract(stream_1);
				stream_1.Flush();
				stream_1.Seek(0L, SeekOrigin.Begin);
			}
		}
		return result;
	}

	internal static bool smethod_6(string string_5)
	{
		return ZipFile.IsZipFile(string_5);
	}

	internal static bool smethod_7(Stream stream_0)
	{
		long position = stream_0.Position;
		stream_0.Seek(0L, SeekOrigin.Begin);
		bool result = ZipFile.IsZipFile(stream_0, testExtract: false);
		stream_0.Seek(position, SeekOrigin.Begin);
		return result;
	}

	internal Class31(Stream stream_0, string string_5, string string_6)
		: this(stream_0, string_5, null, string_6)
	{
	}

	internal Class31(Stream stream_0, string string_5, string string_6, string string_7)
	{
		string_0 = string_5;
		zipFile_0 = ZipFile.Read(stream_0);
		if (string_6 != null)
		{
			zipFile_0.Password = string_6;
		}
		zipFile_0.EmitTimesInWindowsFormatWhenSaving = true;
		bool flag = true;
		string text = string.Empty;
		ZipEntry zipEntry = zipFile_0[method_16(Class333.smethod_192())];
		if (zipEntry != null)
		{
			XmlReader xmlReader = XmlReader.Create(zipEntry.OpenReader());
			while (xmlReader.Read())
			{
				if (!xmlReader.IsStartElement())
				{
					continue;
				}
				string name = xmlReader.Name;
				if (!(name == Class333.smethod_193()))
				{
					if (!(name == Class333.smethod_194()))
					{
						if (!(name == Class333.smethod_91()))
						{
							if (name == Class333.smethod_195())
							{
								string_4 = xmlReader.GetAttribute(Class333.smethod_197());
								xmlReader.Read();
								string_3 = xmlReader.Value;
							}
						}
						else
						{
							xmlReader.Read();
							string_2 = xmlReader.Value;
						}
					}
					else
					{
						xmlReader.Read();
						string_1 = xmlReader.Value;
					}
				}
				else
				{
					text = xmlReader.GetAttribute(Class333.smethod_196());
					flag = text == string_0;
				}
			}
			xmlReader.Close();
		}
		if (string_3 != string.Empty || string_7 != null)
		{
			string[] array = method_1(string_3, string_7);
			if (array.Length < 1)
			{
				throw new Exception(string.Format(Class333.smethod_198(), string_5, text));
			}
			if (array.Length != zipFile_0.Count * 2)
			{
				throw new Exception(string.Format(Class333.smethod_198(), string_5, text));
			}
			for (int i = 2; i < array.Length - 1; i++)
			{
				ZipEntry zipEntry2 = zipFile_0[array[i++]];
				if (zipEntry2 == null || zipEntry2.Crc.ToString() != array[i])
				{
					throw new Exception(string.Format(Class333.smethod_198(), string_5, text));
				}
			}
		}
		if (!flag)
		{
			throw new Exception(string.Format(Class333.smethod_198(), string_5, text));
		}
	}

	private Class31(ZipFile zipFile_1, string string_5, string string_6)
	{
		string_0 = string_5;
		zipFile_0 = zipFile_1;
		if (string_6 != null)
		{
			zipFile_0.Password = string_6;
		}
		zipFile_0.EmitTimesInWindowsFormatWhenSaving = true;
	}

	private string method_0(ZipEntry zipEntry_0, string string_5, byte[] byte_0)
	{
		string text = string.Empty;
		foreach (ZipEntry entry in zipFile_0.Entries)
		{
			if (entry != zipEntry_0)
			{
				text = text + Class333.smethod_199() + entry.FileName + Class333.smethod_199() + entry.Crc;
			}
		}
		return Class34.smethod_0(Class333.smethod_200() + text, string_5, byte_0);
	}

	private string[] method_1(string string_5, string string_6)
	{
		if (string_6 != null && string_5.Length >= 30)
		{
			return Class34.smethod_1(string_5, string_6).Split(';');
		}
		return new string[0];
	}

	internal IEnumerable<string> method_2(params string[] excludingExtensions)
	{
		foreach (ZipEntry entry in zipFile_0.Entries)
		{
			string fileName = entry.FileName;
			if (fileName.EndsWith(vmethod_0()))
			{
				continue;
			}
			bool flag = false;
			foreach (string value in excludingExtensions)
			{
				if (fileName.EndsWith(value))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				yield return fileName;
			}
		}
	}

	internal static List<string> smethod_8(Stream stream_0, string string_5)
	{
		List<string> list = new List<string>();
		stream_0.Seek(0L, SeekOrigin.Begin);
		using ZipFile zipFile = ZipFile.Read(stream_0);
		if (string_5 != null)
		{
			zipFile.Password = string_5;
		}
		foreach (ZipEntry entry in zipFile.Entries)
		{
			list.Add(entry.FileName);
		}
		return list;
	}

	internal bool method_3(string string_5)
	{
		return zipFile_0.ContainsEntry(string_5);
	}

	internal bool method_4(string string_5)
	{
		return zipFile_0.ContainsEntry(method_16(string_5));
	}

	internal MemoryStream method_5(string string_5)
	{
		string fileName = method_16(string_5);
		MemoryStream memoryStream = null;
		lock (zipFile_0)
		{
			ZipEntry zipEntry = zipFile_0[fileName];
			if (zipEntry != null)
			{
				memoryStream = new MemoryStream();
				zipEntry.Extract(memoryStream);
				memoryStream.Seek(0L, SeekOrigin.Begin);
			}
		}
		return memoryStream;
	}

	internal MemoryStream method_6(string string_5)
	{
		MemoryStream memoryStream = null;
		lock (zipFile_0)
		{
			ZipEntry zipEntry = zipFile_0[string_5];
			if (zipEntry != null)
			{
				memoryStream = new MemoryStream();
				zipEntry.Extract(memoryStream);
				memoryStream.Seek(0L, SeekOrigin.Begin);
			}
		}
		return memoryStream;
	}

	internal MemoryStream method_7(int int_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		lock (zipFile_0)
		{
			zipFile_0[int_0].Extract(memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}
	}

	internal IEnumerable<KeyValuePair<string, int>> method_8()
	{
		int num = 0;
		foreach (ZipEntry entry in zipFile_0.Entries)
		{
			yield return new KeyValuePair<string, int>(entry.FileName, num++);
		}
	}

	internal void method_9(DateTime dateTime_1, DateTime dateTime_2, DateTime dateTime_3)
	{
		foreach (ZipEntry entry in zipFile_0.Entries)
		{
			entry.SetEntryTimes(dateTime_1, dateTime_2, dateTime_3);
		}
	}

	internal void method_10(string string_5, Stream stream_0)
	{
		zipFile_0.UpdateEntry(string_5, stream_0);
	}

	internal int method_11(string string_5)
	{
		return zipFile_0[string_5].Crc;
	}

	internal void method_12(Stream stream_0)
	{
		if (bool_0)
		{
			method_9(dateTime_0, dateTime_0, dateTime_0);
		}
		zipFile_0.Save(stream_0);
	}

	internal void method_13()
	{
		if (bool_0)
		{
			method_9(dateTime_0, dateTime_0, dateTime_0);
		}
		zipFile_0.Save();
	}

	[SpecialName]
	internal string method_14()
	{
		return string_1;
	}

	[SpecialName]
	internal string method_15()
	{
		return string_2;
	}

	internal string method_16(string string_5)
	{
		return string.Format(Class333.smethod_201(), Path.GetFileNameWithoutExtension(string_5), vmethod_0());
	}

	internal virtual string vmethod_0()
	{
		return Class333.smethod_202();
	}

	internal void method_17()
	{
		zipFile_0.Dispose();
	}
}
