using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
	// Zero-based native dash screens this rule applies to; null applies it on every screen.
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public List<int> Screens { get; set; }

	// Editor text: "All" or one-based screen numbers, e.g. "1, 3".
	[JsonIgnore]
	public string ScreensText
	{
		get => Screens == null ? "All" : string.Join(", ", Screens.Select(screen => screen + 1));
		set => Screens = AlertMedia.ParseScreens(value);
	}
}

internal static class AlertMedia
{
	internal const string ManifestName = "ic7_alerts.json";
	// v2.36 UIMain always creates exactly five screens.
	internal const int ScreenCount = 5;
	private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
	{
		PropertyNamingPolicy = JsonNamingPolicy.CamelCase
	};

	private sealed class Manifest
	{
		[JsonRequired] public int Version { get; set; } = 1;
		[JsonRequired] public List<AlertBanner> Banners { get; set; } = new List<AlertBanner>();
	}

	internal static List<int> ParseScreens(string text)
	{
		if (string.IsNullOrWhiteSpace(text) || text.Trim().Equals("All", StringComparison.OrdinalIgnoreCase))
			return null;
		var screens = new List<int>();
		foreach (string part in text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries))
		{
			if (!int.TryParse(part, out int screen) || screen < 1 || screen > ScreenCount || screens.Contains(screen - 1))
				throw new FormatException("Screens must be \"All\" or distinct screen numbers from 1 to " + ScreenCount + ", e.g. \"1, 3\".");
			screens.Add(screen - 1);
		}
		return screens;
	}

	// The rule the dash uses on a zero-based screen (-1: no screen identified).
	internal static AlertBanner Resolve(IEnumerable<AlertBanner> banners, string text, int screen)
	{
		AlertBanner general = null;
		foreach (AlertBanner banner in banners)
		{
			if (banner.Text != text)
				continue;
			if (banner.Screens == null)
				general = banner;
			else if (screen >= 0 && banner.Screens.Contains(screen))
				return banner;
		}
		return general;
	}

	internal static void Validate(IEnumerable<AlertBanner> banners)
	{
		HashSet<string> allScreens = new HashSet<string>(StringComparer.Ordinal);
		HashSet<(string, int)> claimed = new HashSet<(string, int)>();
		int count = 0;
		foreach (AlertBanner banner in banners)
		{
			if (banner == null || string.IsNullOrWhiteSpace(banner.Text) || banner.Text.Length > 200 || ++count > 100)
				throw new InvalidDataException("Alert names must be nonempty (at most 100 banners).");
			if (banner.Screens == null)
			{
				if (!allScreens.Add(banner.Text))
					throw new InvalidDataException("\"" + banner.Text + "\" has more than one all-screens rule.");
			}
			else
			{
				if (banner.Screens.Count < 1 || banner.Screens.Count > ScreenCount
					|| banner.Screens.Any(screen => screen < 0 || screen >= ScreenCount)
					|| banner.Screens.Distinct().Count() != banner.Screens.Count)
					throw new InvalidDataException("\"" + banner.Text + "\": screens must be distinct numbers from 1 to " + ScreenCount + ".");
				foreach (int screen in banner.Screens)
					if (!claimed.Add((banner.Text, screen)))
						throw new InvalidDataException("\"" + banner.Text + "\" has more than one rule for screen " + (screen + 1) + ".");
			}
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
		// Version 1 keeps manifests without screen rules readable by the earlier alert component.
		int version = banners.Any(banner => banner.Screens != null) ? 2 : 1;
		return JsonSerializer.SerializeToUtf8Bytes(new Manifest { Version = version, Banners = banners }, Options);
	}

	internal static List<AlertBanner> Read(string path)
	{
		if (!File.Exists(path))
			return new List<AlertBanner>();
		Manifest manifest = JsonSerializer.Deserialize<Manifest>(File.ReadAllBytes(path), Options);
		if (manifest == null || (manifest.Version != 1 && manifest.Version != 2) || manifest.Banners == null
			|| (manifest.Version == 1 && manifest.Banners.Any(banner => banner?.Screens != null)))
			throw new InvalidDataException("Unsupported alert-media manifest.");
		Validate(manifest.Banners);
		return manifest.Banners;
	}
}
