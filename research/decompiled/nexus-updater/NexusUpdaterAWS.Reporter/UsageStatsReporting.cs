using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Xml;
using NexusReporter.Runtime;
using NexusReporter.Web;
using NexusUpdaterAWS.Runtime;

namespace NexusUpdaterAWS.Reporter;

public class UsageStatsReporting
{
	public static readonly object StatsLockingObject = new object();

	private Timer m_timer;

	private static bool UploadingStats = false;

	public void StartTimer()
	{
		m_timer = new Timer();
		m_timer.Interval = 10000.0;
		m_timer.Elapsed += TimerElapsed;
		m_timer.Start();
	}

	private void TimerElapsed(object sender, ElapsedEventArgs e)
	{
		if (!UploadingStats)
		{
			UploadingStats = true;
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += UploadPendingStatsToWebService_Task;
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void UploadPendingStatsToWebService_Task(object sender, DoWorkEventArgs e)
	{
		lock (StatsLockingObject)
		{
			DeleteOldReporterFiles();
			bool haveDataForReporterV2 = LoadReporterV2DataFromFiles();
			try
			{
				if (haveDataForReporterV2)
				{
					ReporterV2Upload.Send(SvcRuntime.DebugMode);
				}
			}
			catch (Exception ex)
			{
				if (SvcRuntime.DebugMode && SvcRuntime.EventLog != null)
				{
					SvcRuntime.EventLog.WriteEntry("UploadPendingStatsToWebService_Task (reporter V2 part) threw the following exception: " + ex.Message, (EventLogEntryType)2);
				}
			}
			finally
			{
				UploadingStats = false;
			}
			UploadingStats = false;
		}
	}

	private bool LoadReporterV2DataFromFiles()
	{
		bool haveDataForReporterV2 = false;
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/Haltech/";
			if (!Directory.Exists(folderPath))
			{
				return false;
			}
			string[] files = Directory.GetFiles(folderPath, "*.nrd");
			foreach (string filePath in files)
			{
				haveDataForReporterV2 = true;
				try
				{
					byte[] encryptedBytes = File.ReadAllBytes(filePath);
					using Aes aes = Aes.Create();
					aes.Key = Encoding.UTF8.GetBytes("572935eba8389ef189a4d056ab23107c");
					aes.IV = new byte[16];
					aes.Padding = PaddingMode.Zeros;
					using ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
					using MemoryStream msDecrypt = new MemoryStream(encryptedBytes);
					using CryptoStream cryptoStream = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
					XmlReader reader = XmlReader.Create(cryptoStream);
					reader.Read();
					while (reader.NodeType != XmlNodeType.Element)
					{
						reader.Read();
					}
					if (!reader.IsEmptyElement)
					{
						reader.Read();
						while (reader.IsStartElement())
						{
							bool handled = true;
							switch (reader.Name)
							{
							case "DeviceReg_KVPs":
							{
								List<KeyValuePair<string, object>> kvpList = ReadReporterV2KVPList(reader);
								if (kvpList != null)
								{
									ReporterV2Data.DeviceReg_PerFile[filePath] = kvpList;
								}
								break;
							}
							case "FWStats_KVPs":
							{
								List<KeyValuePair<string, object>> kvpList = ReadReporterV2KVPList(reader);
								if (kvpList != null)
								{
									ReporterV2Data.FWStats_PerFile[filePath] = kvpList;
								}
								break;
							}
							case "Settings_KVPs":
							{
								List<KeyValuePair<string, object>> kvpList = ReadReporterV2KVPList(reader);
								if (kvpList != null)
								{
									ReporterV2Data.Settings_PerFile[filePath] = kvpList;
								}
								break;
							}
							default:
								handled = false;
								break;
							}
							if (!handled)
							{
								reader.Skip();
							}
							else
							{
								reader.Read();
							}
						}
					}
					reader.Close();
				}
				catch (Exception ex)
				{
					if (SvcRuntime.DebugMode && SvcRuntime.EventLog != null)
					{
						SvcRuntime.EventLog.WriteEntry("LoadReporterV2DataFromFiles threw the following exception: \"" + ex.Message + "\"", (EventLogEntryType)2);
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (SvcRuntime.DebugMode && SvcRuntime.EventLog != null)
			{
				SvcRuntime.EventLog.WriteEntry("LoadReporterV2DataFromFiles threw the following exception: \"" + ex2.Message + "\"", (EventLogEntryType)2);
			}
		}
		return haveDataForReporterV2;
	}

	private static List<KeyValuePair<string, object>> ReadReporterV2KVPList(XmlReader reader)
	{
		List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>();
		reader.Read();
		while ((reader.IsStartElement() || reader.NodeType == XmlNodeType.EndElement || reader.NodeType == XmlNodeType.Whitespace) && (!reader.Name.EndsWith("_KVPs") || reader.NodeType != XmlNodeType.EndElement))
		{
			if (reader.Name == "KeyValuePair")
			{
				string key = reader.GetAttribute("key");
				object value = null;
				string valueAsString = reader.GetAttribute("valueAsString");
				string valueAsInt = reader.GetAttribute("valueAsInt");
				string valueAsIntArray = reader.GetAttribute("valueAsIntArray");
				if (valueAsString != null)
				{
					value = valueAsString;
				}
				else if (!string.IsNullOrEmpty(valueAsInt))
				{
					value = int.Parse(valueAsInt);
				}
				else if (!string.IsNullOrEmpty(valueAsIntArray))
				{
					string[] cells = valueAsIntArray.Substring(1, valueAsIntArray.Length - 2).Split(new char[1] { ',' });
					int[] array = new int[cells.Length];
					for (int c = 0; c < cells.Length; c++)
					{
						array[c] = int.Parse(cells[c]);
					}
					value = array;
				}
				kvpList.Add(new KeyValuePair<string, object>(key, value));
			}
			reader.Read();
		}
		return kvpList;
	}

	private void DeleteOldReporterFiles()
	{
		string folderPath;
		try
		{
			folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/Haltech/";
		}
		catch
		{
			folderPath = null;
		}
		if (folderPath == null || !Directory.Exists(folderPath))
		{
			return;
		}
		string[] oldReporterFilePaths;
		try
		{
			oldReporterFilePaths = Directory.GetFiles(folderPath, "*.ord");
		}
		catch
		{
			oldReporterFilePaths = null;
		}
		if (oldReporterFilePaths == null)
		{
			return;
		}
		string[] array = oldReporterFilePaths;
		foreach (string filePath in array)
		{
			try
			{
				File.Delete(filePath);
			}
			catch
			{
			}
		}
	}
}
