using System;
using System.IO;

namespace NSP;

internal static class MediaResource
{
	internal static bool Save(string directory, string name, byte[] payload)
	{
		if (string.IsNullOrEmpty(name) || name == "." || name == ".."
			|| name.IndexOfAny(new[] { '/', '\\', '\0' }) >= 0)
			throw new InvalidDataException("Invalid media resource filename.");
		Directory.CreateDirectory(directory);
		string target = Path.Combine(directory, name);
		if (File.Exists(target) && File.ReadAllBytes(target).AsSpan().SequenceEqual(payload))
			return false;
		string temporary = Path.Combine(directory, "." + name + "." + Guid.NewGuid().ToString("N") + ".tmp");
		try
		{
			File.WriteAllBytes(temporary, payload);
			File.Move(temporary, target, overwrite: true);
		}
		finally
		{
			File.Delete(temporary);
		}
		return true;
	}

	// Advisory only: the dash decodes GIFs in software on the i.MX6 and receives resources over
	// the comms link, so very large media is slow to transfer and costly to animate.
	internal const long LargeMediaBytes = 4L * 1024 * 1024;
	internal const int CanvasWidth = 860;
	internal const int CanvasHeight = 480;

	internal static string LargeMediaWarning(string fileName, long length, int width, int height, int frames)
	{
		var reasons = new System.Collections.Generic.List<string>();
		if (length > LargeMediaBytes)
			reasons.Add("it is " + (length / (1024.0 * 1024.0)).ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)
				+ " MB (over " + LargeMediaBytes / (1024 * 1024) + " MB), so it takes longer to transfer");
		if (frames > 1 && (width > CanvasWidth || height > CanvasHeight))
			reasons.Add("its frames (" + width + " x " + height + ") are larger than the dash's "
				+ CanvasWidth + " x " + CanvasHeight + " canvas, so every frame is decoded and scaled down");
		if (reasons.Count == 0)
			return null;
		return fileName + " may play slowly on the dash: " + string.Join("; ", reasons)
			+ ". Reduce its size or frame dimensions for smoother playback. Import it anyway?";
	}

	internal static bool IsManagedResource(string fileName)
	{
		return fileName != null && System.Text.RegularExpressions.Regex.IsMatch(fileName,
			@"^ic7_screen_[1-5]\.png$", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
	}

	internal static bool HasMp4Header(ReadOnlySpan<byte> data)
	{
		return data.Length >= 12 && data[4] == (byte)'f' && data[5] == (byte)'t'
			&& data[6] == (byte)'y' && data[7] == (byte)'p';
	}

	internal static bool IsVideo(string path, Stream stream)
	{
		if (string.Equals(Path.GetExtension(path), ".mp4", StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		if (!string.Equals(Path.GetExtension(path), ".png", StringComparison.OrdinalIgnoreCase)
			|| !Path.GetFileName(path).StartsWith("ic7_video_", StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		long position = stream.Position;
		try
		{
			Span<byte> header = stackalloc byte[12];
			int length = stream.ReadAtLeast(header, header.Length, throwOnEndOfStream: false);
			return HasMp4Header(header.Slice(0, length));
		}
		finally
		{
			stream.Position = position;
		}
	}
}
