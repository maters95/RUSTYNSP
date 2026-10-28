using System;
using System.IO;

namespace NSP;

internal static class MediaResource
{
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
