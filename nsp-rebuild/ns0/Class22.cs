using System.IO;
using ns7;

namespace ns0;

internal static class Class22
{
	internal enum Enum18
	{
		Bgs,
		BgT,
		Bgt
	}

	internal static void smethod_0(string string_0, string string_1, bool bool_0, Enum18 enum18_0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
		if (!directoryInfo.Exists)
		{
			return;
		}
		if (!Directory.Exists(string_1))
		{
			Directory.CreateDirectory(string_1);
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			string text = Path.Combine(string_1, fileInfo.Name);
			if (File.Exists(text))
			{
				switch (enum18_0)
				{
				case Enum18.BgT:
					try
					{
						if (File.GetLastWriteTime(fileInfo.FullName) > File.GetLastWriteTime(text))
						{
							fileInfo.CopyTo(text, overwrite: true);
						}
					}
					catch
					{
					}
					break;
				case Enum18.Bgt:
					fileInfo.CopyTo(text, overwrite: true);
					break;
				}
			}
			else
			{
				fileInfo.CopyTo(text);
			}
		}
		if (bool_0)
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				string string_2 = Path.Combine(string_1, directoryInfo2.Name);
				smethod_0(directoryInfo2.FullName, string_2, bool_0, enum18_0);
			}
		}
	}

	internal static string smethod_1(string string_0, string string_1, bool bool_0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
		FileInfo[] files = directoryInfo.GetFiles();
		int num = 0;
		FileInfo fileInfo;
		while (true)
		{
			if (num < files.Length)
			{
				fileInfo = files[num];
				if (fileInfo.Name == string_1)
				{
					break;
				}
				num++;
				continue;
			}
			if (bool_0)
			{
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				for (num = 0; num < directories.Length; num++)
				{
					string text = smethod_1(directories[num].FullName, string_1, bool_0: true);
					if (text != null)
					{
						return text;
					}
				}
			}
			return null;
		}
		return fileInfo.FullName;
	}

	internal static bool smethod_2(string string_0)
	{
		if (!string_0.Contains(Class333.smethod_176()) && !string_0.Contains(Class333.smethod_177()) && !string_0.Contains(Class333.smethod_134()) && !string_0.Contains(Class333.smethod_178()) && !string_0.Contains(Class333.smethod_179()) && !string_0.Contains(Class333.smethod_180()) && !string_0.Contains(Class333.smethod_181()) && !string_0.Contains(Class333.smethod_182()))
		{
			return string_0.Contains(Class333.smethod_183());
		}
		return true;
	}
}
