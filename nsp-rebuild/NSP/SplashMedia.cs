using System;
using System.IO;
using System.Text.Json;

namespace NSP;

internal static class SplashMedia
{
	internal const string ManifestName = "ic7_splash.json";
	internal const int DurationMs = 3300;

	internal static bool IsAnimated(string path, ReadOnlySpan<byte> data)
	{
		bool gif = data.Length >= 6 && (data.Slice(0, 6).SequenceEqual("GIF87a"u8)
			|| data.Slice(0, 6).SequenceEqual("GIF89a"u8));
		bool mp4 = MediaResource.HasMp4Header(data);
		string extension = Path.GetExtension(path);
		if ((extension.Equals(".gif", StringComparison.OrdinalIgnoreCase) && !gif)
			|| (extension.Equals(".mp4", StringComparison.OrdinalIgnoreCase) && !mp4))
		{
			throw new InvalidDataException("The selected splash has an invalid GIF or MP4 header.");
		}
		string filename = Path.GetFileName(path);
		bool png = extension.Equals(".png", StringComparison.OrdinalIgnoreCase);
		if ((gif && !extension.Equals(".gif", StringComparison.OrdinalIgnoreCase)
				&& !(png && filename.StartsWith("ic7_animation_", StringComparison.OrdinalIgnoreCase)))
			|| (mp4 && !extension.Equals(".mp4", StringComparison.OrdinalIgnoreCase)
				&& !(png && filename.StartsWith("ic7_video_", StringComparison.OrdinalIgnoreCase))))
		{
			throw new InvalidDataException("Startup media must use .gif/.mp4 or the matching ic7_animation_/ic7_video_ PNG alias.");
		}
		return gif || mp4;
	}

	internal static byte[] CreateManifest(string source, bool animated)
	{
		if (source.Length < 3 || (source[0] != 'u' && source[0] != 'h') || source[1] != '/'
			|| source.Substring(2).IndexOfAny(new[] { '/', '\\', '\0' }) >= 0
			|| source.Substring(2) == "." || source.Substring(2) == ".."
			|| source.Substring(2).Equals(ManifestName, StringComparison.OrdinalIgnoreCase))
		{
			throw new InvalidDataException("Invalid splash resource name: " + source);
		}
		return JsonSerializer.SerializeToUtf8Bytes(new
		{
			version = 1,
			source = animated ? source : "",
			durationMs = DurationMs
		});
	}

	internal static void SaveManifest(string imageDirectory, byte[] manifest)
	{
		Directory.CreateDirectory(imageDirectory);
		string target = Path.Combine(imageDirectory, ManifestName);
		string temporary = target + ".tmp";
		try
		{
			File.WriteAllBytes(temporary, manifest);
			File.Move(temporary, target, overwrite: true);
		}
		finally
		{
			File.Delete(temporary);
		}
	}
}
