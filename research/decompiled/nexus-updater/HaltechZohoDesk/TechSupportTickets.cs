using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Timers;
using System.Xml;
using NexusUpdaterAWS.Runtime;

namespace HaltechZohoDesk;

public class TechSupportTickets
{
	private Timer m_timer;

	private static bool UploadingTickets;

	public void StartTimer()
	{
		m_timer = new Timer();
		m_timer.Interval = 10000.0;
		m_timer.Elapsed += TimerElapsed;
		m_timer.Start();
	}

	private void TimerElapsed(object sender, ElapsedEventArgs e)
	{
		if (!UploadingTickets)
		{
			UploadPendingTickets();
		}
	}

	private async void UploadPendingTickets()
	{
		UploadingTickets = true;
		try
		{
			string progDataHaltechFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/Haltech/";
			if (!Directory.Exists(progDataHaltechFolderPath))
			{
				return;
			}
			string[] folderPaths;
			try
			{
				folderPaths = Directory.GetDirectories(progDataHaltechFolderPath);
			}
			catch
			{
				folderPaths = null;
			}
			if (folderPaths == null)
			{
				return;
			}
			string[] array = folderPaths;
			foreach (string folderWithinProgDataHaltechFolder in array)
			{
				bool isPendingSupportTicketFolder;
				try
				{
					isPendingSupportTicketFolder = new DirectoryInfo(folderWithinProgDataHaltechFolder).Name.StartsWith("PendingSupportTicket_");
				}
				catch
				{
					isPendingSupportTicketFolder = false;
				}
				if (!isPendingSupportTicketFolder)
				{
					continue;
				}
				string pendingTicketFolderPath = ((!folderWithinProgDataHaltechFolder.EndsWith("\\") && !folderWithinProgDataHaltechFolder.EndsWith("/")) ? (folderWithinProgDataHaltechFolder + "/") : folderWithinProgDataHaltechFolder);
				if (!File.Exists(pendingTicketFolderPath + "PendingTicket.xml"))
				{
					continue;
				}
				Dictionary<string, string> fields = GetFieldsFromPendingTicketXML(pendingTicketFolderPath + "PendingTicket.xml");
				if (fields == null || !fields.ContainsKey("IsBetaFeedback") || !fields.ContainsKey("Email") || !fields.ContainsKey("FirstName") || !fields.ContainsKey("LastName") || !fields.ContainsKey("Phone") || !fields.ContainsKey("Subject") || !fields.ContainsKey("Description") || !fields.ContainsKey("SoftwareVersion") || !fields.ContainsKey("Product") || !fields.ContainsKey("SerialNumber") || !fields.ContainsKey("FirmwareVersion"))
				{
					continue;
				}
				CreateTicketRequest ticketRequest = CreateNewTicketRequest(fields, replaceNewLinesWithBreaks: true);
				if (!bool.TryParse(fields["IsBetaFeedback"], out var isBetaFeedback))
				{
					isBetaFeedback = false;
				}
				try
				{
					ZohoDeskApiClient apiClient = ZohoDeskApiClient.Instance;
					CreateTicketResponse createTicketResponse = await apiClient.CreateTicketAsync(ticketRequest, isBetaFeedback);
					string attachmentsFolderPath = pendingTicketFolderPath + "Attachments/";
					if (Directory.Exists(attachmentsFolderPath))
					{
						string[] attachmentsFilePaths = Directory.GetFiles(attachmentsFolderPath);
						string[] array2 = attachmentsFilePaths;
						foreach (string attachmentPath in array2)
						{
							await apiClient.UploadAttachmentAsync(createTicketResponse.Id, createTicketResponse.ContactId, attachmentPath);
						}
					}
					Directory.Delete(pendingTicketFolderPath, recursive: true);
					if (SvcRuntime.DebugMode && SvcRuntime.EventLog != null)
					{
						SvcRuntime.EventLog.WriteEntry("UploadPendingTickets successfully submitted the support ticket for '" + pendingTicketFolderPath + "'", (EventLogEntryType)4);
					}
				}
				catch (Exception ex)
				{
					if (SvcRuntime.DebugMode && SvcRuntime.EventLog != null)
					{
						SvcRuntime.EventLog.WriteEntry("UploadPendingTickets threw the following exception when try to submit the support ticket for '" + pendingTicketFolderPath + "': " + ex.Message, (EventLogEntryType)1);
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (SvcRuntime.DebugMode && SvcRuntime.EventLog != null)
			{
				SvcRuntime.EventLog.WriteEntry("UploadPendingTickets threw the following exception: " + ex2.Message, (EventLogEntryType)1);
			}
		}
		finally
		{
			UploadingTickets = false;
		}
	}

	private CreateTicketRequest CreateNewTicketRequest(Dictionary<string, string> fields, bool replaceNewLinesWithBreaks)
	{
		return new CreateTicketRequest
		{
			Cf = new CustomFields
			{
				SerialNumber = fields["SerialNumber"],
				Product = fields["Product"],
				SoftwareVersion = fields["SoftwareVersion"],
				FirmwareVersion = fields["FirmwareVersion"]
			},
			Contact = new Contact
			{
				FirstName = fields["FirstName"],
				LastName = fields["LastName"],
				Email = fields["Email"],
				Phone = fields["Phone"]
			},
			Subject = fields["Subject"],
			Description = (replaceNewLinesWithBreaks ? ReplaceNewLinesWithBreaks(fields["Description"]) : fields["Description"])
		};
	}

	private static string ReplaceNewLinesWithBreaks(string input)
	{
		if (input != null)
		{
			return Regex.Replace(input, "\\r\\n|\\n\\r|\\r|\\n", "<br>");
		}
		return null;
	}

	private Dictionary<string, string> GetFieldsFromPendingTicketXML(string pendingTicketXMLFilePath)
	{
		try
		{
			Dictionary<string, string> fields = null;
			FileStream fileStream = new FileStream(pendingTicketXMLFilePath, FileMode.Open);
			if (fileStream.CanRead)
			{
				fields = new Dictionary<string, string>();
				XmlReader reader = XmlReader.Create(fileStream);
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
						fields.Add(reader.Name, reader.GetAttribute("value"));
						reader.Read();
					}
				}
				reader.Close();
			}
			fileStream.Close();
			return fields;
		}
		catch
		{
			return null;
		}
	}
}
