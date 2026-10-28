using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ns7;

namespace ns0;

internal class Class34
{
	private static byte[] byte_0 = Encoding.ASCII.GetBytes(Class333.smethod_208());

	private const int int_0 = 1000;

	internal static string smethod_0(string string_0, string string_1, byte[] byte_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException(Class333.smethod_203());
		}
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException(Class333.smethod_204());
		}
		string text = null;
		Aes aes = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, byte_0, 1000, HashAlgorithmName.SHA1);
			aes = Aes.Create();
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			if (byte_1 != null)
			{
				aes.IV = byte_1;
			}
			ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
			using MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(BitConverter.GetBytes(aes.IV.Length), 0, 4);
			memoryStream.Write(aes.IV, 0, aes.IV.Length);
			using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
			{
				using StreamWriter streamWriter = new StreamWriter(stream);
				streamWriter.Write(string_0);
			}
			return Convert.ToBase64String(memoryStream.ToArray());
		}
		finally
		{
			aes?.Clear();
		}
	}

	internal static string smethod_1(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException(Class333.smethod_205());
		}
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException(Class333.smethod_204());
		}
		Aes aes = null;
		string text = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, byte_0, 1000, HashAlgorithmName.SHA1);
			using MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(string_0));
			aes = Aes.Create();
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = smethod_5(memoryStream);
			ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			using StreamReader streamReader = new StreamReader(stream);
			return streamReader.ReadToEnd();
		}
		finally
		{
			aes?.Clear();
		}
	}

	internal static void smethod_2(byte[] byte_1, string string_0, Stream stream_0, byte[] byte_2)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException(Class333.smethod_203());
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException(Class333.smethod_204());
		}
		Aes aes = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_0, byte_0, 1000, HashAlgorithmName.SHA1);
			aes = Aes.Create();
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			if (byte_2 != null)
			{
				aes.IV = byte_2;
			}
			ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
			stream_0.Write(BitConverter.GetBytes(aes.IV.Length), 0, 4);
			stream_0.Write(aes.IV, 0, aes.IV.Length);
			using CryptoStream stream = new CryptoStream(stream_0, transform, CryptoStreamMode.Write);
			using MemoryStream memoryStream = new MemoryStream(byte_1);
			memoryStream.WriteTo(stream);
		}
		finally
		{
			aes?.Clear();
		}
	}

	internal static void smethod_3(Stream stream_0, string string_0, Stream stream_1)
	{
		if (stream_0 == null)
		{
			throw new ArgumentNullException(Class333.smethod_205());
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException(Class333.smethod_204());
		}
		Aes aes = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_0, byte_0, 1000, HashAlgorithmName.SHA1);
			aes = Aes.Create();
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = smethod_5(stream_0);
			ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
			using CryptoStream stream_2 = new CryptoStream(stream_0, transform, CryptoStreamMode.Read);
			smethod_4(stream_2, stream_1);
		}
		finally
		{
			aes?.Clear();
		}
	}

	internal static void smethod_4(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[32768];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) > 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	private static byte[] smethod_5(Stream stream_0)
	{
		byte[] array = new byte[4];
		if (!Class23.smethod_14(stream_0, array, 0, array.Length))
		{
			throw new SystemException(Class333.smethod_206());
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
		if (!Class23.smethod_14(stream_0, array2, 0, array2.Length))
		{
			throw new SystemException(Class333.smethod_207());
		}
		return array2;
	}
}
