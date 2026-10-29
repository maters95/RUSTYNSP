using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NSP;

internal sealed class AlertBanner
{
	[JsonRequired] public string Text { get; set; } = "";
	[JsonRequired] public string Source { get; set; } = "";
	[JsonRequired] public int X { get; set; }
	[JsonRequired] public int Y { get; set; } = 420;
	[JsonRequired] public int Width { get; set; } = 860;
	[JsonRequired] public int Height { get; set; } = 60;
	// Optional for older manifests: show only the image, without the stock colour and text.
	public bool GifOnly { get; set; }
}

internal static class AlertMedia
{
	internal const string ManifestName = "ic7_alerts.json";
	private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
	{
		PropertyNamingPolicy = JsonNamingPolicy.CamelCase
	};

	private sealed class Manifest
	{
		[JsonRequired] public int Version { get; set; } = 1;
		[JsonRequired] public List<AlertBanner> Banners { get; set; } = new List<AlertBanner>();
	}

	internal static void Validate(IEnumerable<AlertBanner> banners)
	{
		HashSet<string> names = new HashSet<string>(StringComparer.Ordinal);
		int count = 0;
		foreach (AlertBanner banner in banners)
		{
			if (banner == null || string.IsNullOrWhiteSpace(banner.Text) || banner.Text.Length > 200
				|| !names.Add(banner.Text) || ++count > 100)
				throw new InvalidDataException("Alert names must be nonempty and unique (at most 100 banners).");
			if (banner.X < 0 || banner.Y < 0 || banner.Width < 1 || banner.Height < 60
				|| banner.Width > 860 || banner.Height > 480
				|| banner.X > 860 - banner.Width || banner.Y > 480 - banner.Height)
				throw new InvalidDataException("Alert rectangles must fit the 860 x 480 canvas and be at least 60 pixels high.");
			if (banner.Source == null)
				throw new InvalidDataException("Choose an alert image or leave its source empty for a positioned stock banner.");
			if (banner.GifOnly && banner.Source.Length == 0)
				throw new InvalidDataException("\"" + banner.Text + "\": GIF only needs a GIF or image; choose one or untick GIF only.");
			if (banner.Source.Length != 0)
			{
				SplashMedia.CreateManifest(banner.Source, false);
				string extension = Path.GetExtension(banner.Source).ToLowerInvariant();
				if (extension != ".gif" && extension != ".png" && extension != ".jpg"
					&& extension != ".jpeg" && extension != ".bmp")
					throw new InvalidDataException("Alert banners support GIF and static images, not MP4.");
			}
		}
	}

	internal static byte[] Serialize(List<AlertBanner> banners)
	{
		Validate(banners);
		return JsonSerializer.SerializeToUtf8Bytes(new Manifest { Banners = banners }, Options);
	}

	internal static List<AlertBanner> Read(string path)
	{
		if (!File.Exists(path))
			return new List<AlertBanner>();
		Manifest manifest = JsonSerializer.Deserialize<Manifest>(File.ReadAllBytes(path), Options);
		if (manifest == null || manifest.Version != 1 || manifest.Banners == null)
			throw new InvalidDataException("Unsupported alert-media manifest.");
		Validate(manifest.Banners);
		return manifest.Banners;
	}
}
