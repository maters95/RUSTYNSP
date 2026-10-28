using System;
using System.IO;
using ns7;

namespace ns0;

internal static class Class35
{
	private static byte[] byte_0 = new byte[5] { 72, 69, 80, 83, 0 };

	internal static byte[] byte_1 = new byte[16]
	{
		91, 30, 184, 1, 219, 12, 55, 70, 83, 182,
		199, 243, 52, 30, 7, 7
	};

	internal static void smethod_0(byte[] byte_2, string string_0, Stream stream_0, byte[] byte_3)
	{
		stream_0.Write(byte_0, 0, byte_0.Length);
		Class34.smethod_2(byte_2, string_0, stream_0, byte_3);
	}

	internal static void smethod_1(string string_0, string string_1)
	{
		if (!File.Exists(string_0))
		{
			return;
		}
		string text = Path.GetFileNameWithoutExtension(string_0) + Class333.smethod_209() + Path.GetExtension(string_0);
		string text2 = Path.GetDirectoryName(string_0) + Class333.smethod_176() + text;
		FileStream fileStream = null;
		try
		{
			fileStream = new FileStream(text2, FileMode.Create, FileAccess.Write);
			fileStream.Write(byte_0, 0, byte_0.Length);
			Class34.smethod_2(File.ReadAllBytes(string_0), string_1, fileStream, byte_1);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_210() + ex.Message);
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
				fileStream.Dispose();
			}
		}
		if (File.Exists(text2))
		{
			File.Delete(string_0);
			File.Move(text2, string_0);
		}
	}

	internal static bool smethod_2(string string_0)
	{
		byte[] array = File.ReadAllBytes(string_0);
		if (array != null && array.Length != 0)
		{
			return smethod_3(array);
		}
		return false;
	}

	internal static bool smethod_3(byte[] byte_2)
	{
		int num = 0;
		for (num = 0; num < byte_0.Length && num < byte_2.Length; num++)
		{
			if (byte_2[num] != byte_0[num])
			{
				return false;
			}
		}
		return num == byte_0.Length;
	}

	internal static bool smethod_4(Stream stream_0)
	{
		long position = stream_0.Position;
		stream_0.Seek(0L, SeekOrigin.Begin);
		bool result = true;
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (stream_0.ReadByte() != byte_0[i])
			{
				result = false;
				break;
			}
		}
		stream_0.Seek(position, SeekOrigin.Begin);
		return result;
	}

	internal static void smethod_5(byte[] byte_2, string string_0, Stream stream_0)
	{
		if (!smethod_3(byte_2))
		{
			throw new Exception(Class333.smethod_211());
		}
		Class34.smethod_3(new MemoryStream(byte_2)
		{
			Position = byte_0.Length
		}, string_0, stream_0);
	}

	internal static void smethod_6(Stream stream_0, string string_0, Stream stream_1)
	{
		if (!smethod_4(stream_0))
		{
			throw new Exception(Class333.smethod_211());
		}
		stream_0.Position = byte_0.Length;
		Class34.smethod_3(stream_0, string_0, stream_1);
	}

	internal static MemoryStream smethod_7(string string_0, string string_1)
	{
		byte[] array = File.ReadAllBytes(string_0);
		MemoryStream memoryStream = null;
		if (smethod_3(array))
		{
			memoryStream = new MemoryStream(array.Length);
			smethod_5(array, string_1, memoryStream);
		}
		else
		{
			memoryStream = new MemoryStream(array);
		}
		return memoryStream;
	}

	internal static Stream smethod_8(Stream stream_0, string string_0)
	{
		Stream stream = stream_0;
		if (smethod_4(stream_0))
		{
			stream = new MemoryStream();
			smethod_6(stream_0, string_0, stream);
		}
		return stream;
	}
}
