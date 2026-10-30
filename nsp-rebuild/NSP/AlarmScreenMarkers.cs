using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace NSP;

internal static class AlarmScreenMarkers
{
	internal static readonly byte[] Image = Convert.FromBase64String(
		"iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR4nGNgYGBgAAAABQABpfZFQAAAAABJRU5ErkJggg==");

	internal static string Source(int screen) => "u/ic7_screen_" + screen + ".png";

	// Plan every edit before touching the map, so a full screen cannot leave a partial bridge.
	internal static Dictionary<string, string> Plan(IReadOnlyDictionary<string, string> settings, int count)
	{
		if (count < 1 || count > 5)
			throw new InvalidDataException("Screen-scoped alarms require an iC-7 map with 1 to 5 screens.");
		var edits = new Dictionary<string, string>();
		for (int screen = 0; screen < count; screen++)
		{
			string start = "SCREEN_" + screen + "_COMP_";
			var slots = settings.Keys.Where(name => name.StartsWith(start, StringComparison.Ordinal)
				&& name.EndsWith("_GAUGE_TYPE", StringComparison.Ordinal))
				.OrderByDescending(name => int.Parse(name.Substring(start.Length).Split('_')[0], CultureInfo.InvariantCulture))
				.Select(name => name.Substring(0, name.Length - "GAUGE_TYPE".Length)).ToList();
			var markers = slots.Where(slot => settings.TryGetValue(slot + "IMAGE_SRC", out string image)
				&& Regex.IsMatch(image, @"^u/ic7_screen_[1-5]\.png$")).ToList();
			string target = markers.FirstOrDefault()
				?? slots.FirstOrDefault(slot => settings[slot + "GAUGE_TYPE"] == "0")
				?? throw new InvalidDataException("Screen " + (screen + 1) + " needs one free image component for alarm screen tracking.");
			foreach (string duplicate in markers.Skip(1))
			{
				edits[duplicate + "GAUGE_TYPE"] = "0";
				edits[duplicate + "IMAGE_SRC"] = "";
			}
			foreach (var field in new Dictionary<string, string> {
				["IMAGE_SRC"] = Source(screen + 1), ["X_POS"] = "0", ["Y_POS"] = "0",
				["Z_POS"] = "0", ["X_SIZE"] = "1", ["Y_SIZE"] = "1",
				["DAY_OPACITY"] = "0", ["NIGHT_OPACITY"] = "0", ["GAUGE_TYPE"] = "2"
			})
			{
				string name = target + field.Key;
				if (!settings.ContainsKey(name))
					throw new InvalidDataException("The map definition is missing screen-tracking setting " + name + ".");
				edits[name] = field.Value;
			}
		}
		return edits.Where(edit => settings[edit.Key] != edit.Value)
			.ToDictionary(edit => edit.Key, edit => edit.Value);
	}
}
