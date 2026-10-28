using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using RestSharp;
using ns0;
using ns4;
using ns7;

namespace ns6;

internal class Class302
{
	private readonly string BcU = Class333.aXT();

	private readonly string Bcu = Class333.aXt();

	private const string BcV = "rmmus-haltech.screenconnect.com";

	private const string Bcv = "https://rmmus-haltech.screenconnect.com";

	private const string BcW = "http://rmmus-haltech.screenconnect.com";

	private const string Bcw = "ScreenConnect.Client";

	internal string BcX = Class333.aXU();

	internal string Bcx = string.Empty;

	internal bool BcY;

	private string Bcy = string.Empty;

	private Form37 BcZ;

	private const int Bcz = 60;

	internal bool method_0(Form37 form37_0)
	{
		BcZ = form37_0;
		BcZ.progressBar_0.Value = 0;
		string text = method_2();
		string text2 = method_1(text);
		bool result = false;
		if (!string.IsNullOrEmpty(text2))
		{
			result = method_3(text2, BcX, !string.IsNullOrEmpty(text));
		}
		return result;
	}

	private string method_1(string string_0)
	{
		Random random = new Random();
		string result = string.Empty;
		string text = string.Empty;
		Bcx = Class333.aXD();
		BcZ.method_1();
		BcY = !string.IsNullOrEmpty(string_0);
		try
		{
			text = random.Next(1, 999).ToString().PadLeft(3, '0');
			RestClient client = ((!BcY) ? new RestClient(Class333.aXe() + BcU + Class333.aXE()) : new RestClient(Class333.aXd() + BcU + Class333.aXE()));
			RestRequest restRequest = new RestRequest();
			restRequest.Method = Method.Post;
			if (BcY)
			{
				restRequest.AddHeader(Class333.aXF(), Class333.aXf());
				restRequest.AddHeader(Class333.aXG(), string_0);
			}
			else
			{
				restRequest.AddHeader(Class333.aXF(), Class333.aXg());
			}
			restRequest.AddParameter(Class333.aXg(), Class333.aXH() + text + Class333.aXh(), ParameterType.RequestBody);
			result = client.Execute(restRequest).Content.Replace(Class333.smethod_180(), Class333.smethod_102());
			Bcx = Class333.aXI();
			BcZ.progressBar_0.Value = 50;
			BcZ.method_1();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aXi() + ex.Message);
			BcZ.Close();
		}
		BcX = text;
		return result;
	}

	private string method_2()
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Class333.aXJ());
		try
		{
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = null;
				streamReader = ((httpWebResponse.CharacterSet != null) ? new StreamReader(responseStream, Encoding.GetEncoding(httpWebResponse.CharacterSet)) : new StreamReader(responseStream));
				string text = string.Empty;
				string text2;
				while ((text2 = streamReader.ReadLine()) != null)
				{
					if (text2.Contains(Class333.aXj()))
					{
						text = text2;
						break;
					}
				}
				httpWebResponse.Close();
				streamReader.Close();
				if (!string.IsNullOrEmpty(text))
				{
					string[] array = text.Split(',');
					string text3 = string.Empty;
					string[] array2 = array;
					foreach (string text4 in array2)
					{
						if (text4.StartsWith(Class333.aXj()))
						{
							text3 = text4;
							break;
						}
					}
					return text3.Substring(Class333.aXj().Length + 1, text3.Length - Class333.aXj().Length - 2);
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aXK() + ex.Message);
		}
		return string.Empty;
	}

	private bool method_3(string string_0, string string_1, bool bool_0)
	{
		Bcx = Class333.aXk();
		BcZ.method_1();
		if (!smethod_3())
		{
			return false;
		}
		string text = Form23.string_3 + Class333.smethod_355();
		string text2 = method_7();
		Bcy = text + Class333.aXL() + text2 + Class333.aXl();
		Uri address = ((!bool_0) ? new Uri(Class333.aXn() + Bcu + string_0 + Class333.aXm() + string_1 + Class333.aXN()) : new Uri(Class333.aXM() + Bcu + string_0 + Class333.aXm() + string_1 + Class333.aXN()));
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFileCompleted += method_5;
			webClient.DownloadProgressChanged += method_4;
			webClient.DownloadFileAsync(address, Bcy);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aXO() + ex.Message);
			BcZ.Close();
		}
		return true;
	}

	private void method_4(object sender, DownloadProgressChangedEventArgs e)
	{
		BcZ.progressBar_0.Value = 50 + (int)((float)e.ProgressPercentage / 100f * 50f);
	}

	private void method_5(object sender, AsyncCompletedEventArgs e)
	{
		Bcx = Class333.aXo();
		BcZ.method_1();
		if (!File.Exists(Bcy))
		{
			BcZ.Close();
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.CreateNoWindow = false;
		processStartInfo.UseShellExecute = false;
		processStartInfo.FileName = Bcy;
		processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		try
		{
			Process? process = Process.Start(processStartInfo);
			process.EnableRaisingEvents = true;
			process.Exited += method_6;
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aXP() + ex.Message);
			BcZ.Close();
		}
		int num = 60;
		while (true)
		{
			if (num > 0)
			{
				if (smethod_2())
				{
					break;
				}
				num--;
				Thread.Sleep(1000);
				continue;
			}
			Bcx = Class333.aXQ();
			BcZ.method_1();
			BcZ.method_2(bool_1: false);
			Thread.Sleep(1000);
			BcZ.Close();
			return;
		}
		Bcx = Class333.aXp();
		BcZ.method_1();
		BcZ.method_2(bool_1: false);
	}

	private void method_6(object sender, EventArgs e)
	{
		smethod_3();
	}

	internal static bool smethod_0()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead(Class333.aXq()))
			{
				return true;
			}
		}
		catch
		{
			return false;
		}
	}

	internal static bool smethod_1()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead(Class333.aXR()))
			{
				return true;
			}
		}
		catch
		{
			return false;
		}
	}

	internal static bool smethod_2()
	{
		return Process.GetProcessesByName(Class333.aXr()).Length != 0;
	}

	internal static bool smethod_3()
	{
		string path = Form23.string_3 + Class333.smethod_355();
		try
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aXS() + ex.Message);
			return false;
		}
		string[] files = Directory.GetFiles(path);
		foreach (string text in files)
		{
			if (text.Contains(Class333.aXL()) && text.EndsWith(Class333.aXl()))
			{
				try
				{
					File.Delete(text);
				}
				catch (Exception ex2)
				{
					Class23.smethod_3(Class333.aXS() + ex2.Message);
				}
			}
		}
		return true;
	}

	private string method_7()
	{
		string[] files = Directory.GetFiles(Form23.string_3 + Class333.smethod_355());
		int num = 0;
		string[] array = files;
		foreach (string text in array)
		{
			if (text.Contains(Class333.aXL()) && text.EndsWith(Class333.aXl()))
			{
				num++;
			}
		}
		if (num == 0)
		{
			return string.Empty;
		}
		return (num + 1).ToString();
	}

	internal void method_8()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(Class333.aXr());
			foreach (Process obj in processesByName)
			{
				obj.Kill();
				obj.WaitForExit();
				obj.Dispose();
			}
			processesByName = Process.GetProcessesByName(Class333.aXs());
			foreach (Process obj2 in processesByName)
			{
				obj2.Kill();
				obj2.WaitForExit();
				obj2.Dispose();
			}
		}
		catch
		{
		}
	}
}
