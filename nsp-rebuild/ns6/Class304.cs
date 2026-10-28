using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows.Forms;
using ns4;
using ns5;
using ns7;

namespace ns6;

internal class Class304
{
	private static readonly byte[] BDE = new byte[16]
	{
		191, 59, 162, 36, 108, 236, 18, 171, 197, 85,
		126, 158, 168, 41, 206, 179
	};

	private static readonly byte[] BDe = new byte[16]
	{
		40, 62, 248, 75, 217, 217, 141, 44, 150, 137,
		76, 37, 134, 148, 129, 51
	};

	internal static Stream smethod_0(Stream stream_0)
	{
		if (Form54.smethod_8(Form23.form23_0, Class333.axo(), Class333.axP(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
		{
			if (smethod_1())
			{
				string string_ = Form23.string_2 + Class333.axp();
				return smethod_3(stream_0, string_);
			}
			Form54.smethod_0(Form23.form23_0, Class333.axQ());
		}
		return null;
	}

	internal static bool smethod_1()
	{
		bool result = false;
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			for (int i = 0; i < allNetworkInterfaces.Length; i++)
			{
				string text = allNetworkInterfaces[i].GetPhysicalAddress().ToString().ToUpper();
				if (text == Class333.axq() || text == Class333.axR() || text == Class333.axr())
				{
					result = true;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Form54.smethod_0(Form23.form23_0, Class333.axS() + ex.Message);
		}
		return result;
	}

	internal static void smethod_2(string string_0, string string_1)
	{
		try
		{
			string path = string_0 + Class333.axs();
			using Aes aes = Aes.Create();
			byte[] key = ((string_1 != null) ? smethod_4(string_1) : BDe);
			aes.Key = key;
			aes.IV = BDE;
			aes.Padding = PaddingMode.PKCS7;
			ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
			using FileStream stream = new FileStream(path, FileMode.Create);
			using FileStream fileStream = new FileStream(string_0, FileMode.Open);
			using CryptoStream destination = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			fileStream.CopyTo(destination);
		}
		catch (Exception ex)
		{
			Form54.smethod_0(Form23.form23_0, Class333.axT() + ex.Message);
		}
	}

	internal static Stream smethod_3(Stream stream_0, string string_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			if (string_0 != null)
			{
				using (Aes aes = Aes.Create())
				{
					aes.Key = smethod_4(string_0);
					aes.IV = BDE;
					aes.Padding = PaddingMode.PKCS7;
					ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
					using (CryptoStream cryptoStream = new CryptoStream(stream_0, transform, CryptoStreamMode.Read))
					{
						cryptoStream.CopyTo(memoryStream);
					}
					memoryStream.Position = 0L;
					return memoryStream;
				}
			}
			return null;
		}
		catch
		{
			Form54.smethod_0(Form23.form23_0, Class333.axt());
		}
		return null;
	}

	private static byte[] smethod_4(string string_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		using Aes aes = Aes.Create();
		aes.Key = BDe;
		aes.IV = BDE;
		aes.Padding = PaddingMode.PKCS7;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using (FileStream stream = new FileStream(string_0, FileMode.Open))
		{
			using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			cryptoStream.CopyTo(memoryStream);
		}
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}
}
