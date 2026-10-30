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
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? MessageDataId { get; set; }
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int[] Screens { get; set; }
	[JsonIgnore]
	public string ScreensText
	{
		get => Screens == null ? "All" : string.Join(", ", Screens);
		set
		{
			if (string.Equals(value?.Trim(), "All", StringComparison.OrdinalIgnoreCase))
			{
				Screens = null;
				return;
			}
			string[] parts = (value ?? "").Split(',');
			if (parts.Any(part => !int.TryParse(part.Trim(), out int screen) || screen < 1 || screen > 5))
				throw new InvalidDataException("Screens must be All or comma-separated screen numbers from 1 to 5.");
			int[] screens = parts.Select(part => int.Parse(part.Trim())).ToArray();
			if (screens.Distinct().Count() != screens.Length)
				throw new InvalidDataException("Choose each screen only once.");
			Screens = screens;
		}
	}
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

	// The dash application sends at most this many characters of an alarm's Message text.
	internal const int DashNameLength = 20;

	// The text the popup compares a rule with: the first 20 characters of the fixed-width
	// Message the dash sends, trimmed as HalAlarmPopup trims it.
	internal static string DashName(string message)
	{
		string text = (message ?? "").TrimEnd('\0');
		if (text.Length > DashNameLength)
			text = text.Substring(0, DashNameLength);
		return text.Trim();
	}

	// Stricter than the manifest format (which older manifests rely on): a rule the dash can
	// never match, or one whose quote would break the dash's alarm list, is reported in the editor.
	internal static string NameProblem(string text)
	{
		if (string.IsNullOrWhiteSpace(text))
			return "Enter the alarm's Message text.";
		if (text != text.Trim())
			return "Remove leading and trailing spaces; the dash ignores them.";
		if (text.IndexOf('"') >= 0)
			return "Alarm text cannot contain a double quote (\"); the dash's alarm list does not accept it. Change the alarm's Message instead.";
		if (text.Length > DashNameLength)
			return "The dash sends only the first " + DashNameLength + " characters of an alarm's Message, so this rule could never match. Use \""
				+ DashName(text) + "\" or shorten the Message.";
		return null;
	}

	internal static void Validate(IEnumerable<AlertBanner> banners)
	{
		HashSet<string> names = new HashSet<string>(StringComparer.Ordinal);
		HashSet<int> messageIds = new HashSet<int>();
		int count = 0;
		foreach (AlertBanner banner in banners)
		{
			if (banner == null || string.IsNullOrWhiteSpace(banner.Text) || banner.Text.Length > 200
				|| !names.Add(banner.Text) || ++count > 100)
				throw new InvalidDataException("Alert names must be nonempty and unique (at most 100 banners).");
			if (banner.MessageDataId.HasValue && (banner.MessageDataId.Value < 1 || !messageIds.Add(banner.MessageDataId.Value)))
				throw new InvalidDataException("Alarm Message bindings must identify unique, valid settings.");
			if (banner.Screens != null && (banner.Screens.Length == 0 || banner.Screens.Length > 5
				|| banner.Screens.Any(screen => screen < 1 || screen > 5)
				|| banner.Screens.Distinct().Count() != banner.Screens.Length))
				throw new InvalidDataException("Choose one or more distinct screens from 1 to 5, or All.");
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

	internal static bool RenameMessages(List<AlertBanner> banners, IReadOnlyDictionary<int, string> messages)
	{
		bool changed = false;
		foreach (AlertBanner banner in banners)
		{
			if (banner.MessageDataId.HasValue && messages.TryGetValue(banner.MessageDataId.Value, out string text)
				&& banner.Text != text)
			{
				banner.Text = text;
				changed = true;
			}
		}
		if (changed)
			Validate(banners);
		return changed;
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
