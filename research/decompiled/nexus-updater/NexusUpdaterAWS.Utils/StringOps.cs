using System.Text.RegularExpressions;

namespace NexusUpdaterAWS.Utils;

internal class StringOps
{
	public static string TrimPath(string path)
	{
		string[] splits = Regex.Split(path, "haltech-release");
		if (splits.Length < 2)
		{
			return string.Empty;
		}
		return splits[1].Replace("haltech-release", "").Remove(0, 1);
	}
}
