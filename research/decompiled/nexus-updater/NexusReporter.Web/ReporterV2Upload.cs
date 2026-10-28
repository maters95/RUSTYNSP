using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using NexusReporter.Runtime;
using NexusUpdaterAWS.Runtime;
using RestSharp;

namespace NexusReporter.Web;

public static class ReporterV2Upload
{
	public static void Send(bool writeDebugStatusFile)
	{
		int queueSize = ReporterV2Data.DeviceReg_PerFile.Count;
		if (queueSize != ReporterV2Data.FWStats_PerFile.Count || queueSize != ReporterV2Data.Settings_PerFile.Count)
		{
			ReporterV2Data.ClearAll();
			return;
		}
		ReporterV2Data.PopulateAdditionalMiscData();
		List<string> filePaths = new List<string>();
		foreach (string filePath in ReporterV2Data.DeviceReg_PerFile.Keys)
		{
			filePaths.Add(filePath);
		}
		foreach (string filePath2 in filePaths)
		{
			string json;
			try
			{
				json = ReporterV2Data.GetJSONPayloadString_Flat(filePath2);
			}
			catch (Exception ex)
			{
				if (SvcRuntime.DebugMode && SvcRuntime.EventLog != null)
				{
					SvcRuntime.EventLog.WriteEntry("ReporterV2Data.GetJSONPayloadString_Flat threw the following exception for the file '" + filePath2 + "': " + ex.Message, (EventLogEntryType)2);
				}
				continue;
			}
			string debugStatusFileName = null;
			if (writeDebugStatusFile)
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/Haltech/";
				string debugJsonFilePath = folderPath + "ReporterV2_JSON_" + Path.GetFileNameWithoutExtension(filePath2) + ".txt";
				try
				{
					if (File.Exists(debugJsonFilePath))
					{
						File.Delete(debugJsonFilePath);
					}
					if (!File.Exists(debugJsonFilePath))
					{
						File.WriteAllText(debugJsonFilePath, json);
					}
				}
				catch
				{
				}
				debugStatusFileName = folderPath + "ReporterV2_Status_" + Path.GetFileNameWithoutExtension(filePath2) + ".txt";
				try
				{
					if (File.Exists(debugStatusFileName))
					{
						File.Delete(debugStatusFileName);
					}
				}
				catch
				{
				}
			}
			RestClient client = new RestClient("https://dlp.haltech.com/device/data");
			client.Timeout = -1;
			RestRequest request = null;
			IRestResponse response = null;
			List<string> report = new List<string>();
			try
			{
				request = new RestRequest(Method.POST);
				request.AddHeader("Content-Type", "text/plain");
				request.AddParameter("text/plain", json, ParameterType.RequestBody);
				response = client.Execute(request);
				report.Add("Request: " + request.ToString());
				report.Add("Status Code: " + response.StatusCode);
				report.Add("Status Desc: " + response.StatusDescription);
				report.Add("Status Content: " + response.ResponseStatus);
				report.Add("Server: " + client.BaseUrl.OriginalString);
			}
			catch (Exception ex2)
			{
				report.Add("(Error)Request: " + request.ToString());
				report.Add("(Error)Server: " + client.BaseUrl.OriginalString);
				report.Add("(Error)Exception: " + ex2.Message);
			}
			if (response != null && response.IsSuccessful)
			{
				try
				{
					if (File.Exists(filePath2))
					{
						File.Delete(filePath2);
					}
				}
				catch
				{
				}
			}
			ReporterV2Data.RemoveFromQueue(filePath2);
			if (!writeDebugStatusFile)
			{
				continue;
			}
			try
			{
				using StreamWriter sw = File.AppendText(debugStatusFileName);
				foreach (string s in report)
				{
					sw.WriteLine(s + Environment.NewLine);
				}
			}
			catch
			{
			}
		}
	}
}
