using System.Globalization;
using System.Text;
using ns7;

namespace ns0;

internal static class Class24
{
	internal static string smethod_0(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
		foreach (byte b in byte_0)
		{
			stringBuilder.AppendFormat(Class333.smethod_80(), b);
		}
		return stringBuilder.ToString();
	}

	internal static byte[] smethod_1(string string_0)
	{
		if (string_0 != null)
		{
			byte[] array = new byte[string_0.Length / 2];
			for (int i = 0; i < string_0.Length / 2; i++)
			{
				string s = string_0.Substring(2 * i, 2);
				array[i] = byte.Parse(s, NumberStyles.AllowHexSpecifier);
			}
			return array;
		}
		return null;
	}
}
