using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns7;

namespace NSP.UserInterface;

internal sealed class AlertBannerEditor : Form
{
	private readonly Framework framework;
	private readonly BindingList<NSP.AlertBanner> banners;
	private readonly System.Collections.Generic.List<NSP.AlertBanner> otherBanners;
	private readonly DataGridView grid = new DataGridView();
	private readonly Panel canvas = new Panel();
	private readonly Label status = new Label { AutoSize = true, Dock = DockStyle.Fill };
	private readonly CheckBox applyToDash = new CheckBox { Text = "Also upload to connected dash", AutoSize = true };
	private Point dragStart;
	private Rectangle original;
	private bool resizing;
	private bool dragging;
	private NSP.AlertBanner Selected => grid.CurrentRow?.DataBoundItem as NSP.AlertBanner;

	internal AlertBannerEditor(Framework currentFramework, string focusText = null)
	{
		framework = currentFramework;
		var savedBanners = NSP.AlertMedia.Read(
			Path.Combine(Form23.string_10, "images", NSP.AlertMedia.ManifestName));
		bool focused = !string.IsNullOrWhiteSpace(focusText);
		otherBanners = focused
			? savedBanners.Where(banner => banner.Text != focusText).ToList()
			: new System.Collections.Generic.List<NSP.AlertBanner>();
		banners = new BindingList<NSP.AlertBanner>(focused
			? savedBanners.Where(banner => banner.Text == focusText).ToList()
			: savedBanners);
		Text = focused ? "Alarm appearance - " + focusText : "Alarm appearance";
		Width = 1000;
		Height = 760;
		MinimumSize = new Size(920, 680);
		StartPosition = FormStartPosition.CenterParent;
		BackColor = Form23.color_10;
		ForeColor = Form23.color_12;

		var layout = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 5, ColumnCount = 1 };
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 190));
		layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
		Controls.Add(layout);
		layout.Controls.Add(new Label {
			Dock = DockStyle.Fill,
			Text = (focused ? "Appearance for " + focusText + ". Colour, priority and clearing remain controlled by the dash.\r\n"
				: "Choose an alarm's Message text. Colour, priority and clearing remain controlled by the dash.\r\n") +
				"Drag a rectangle to move; drag its bottom-right corner to resize. Numeric values use the 860 x 480 dash canvas. GIFs animate in this preview.\r\n" +
				"Tick \"GIF only\" to hide the coloured banner and text; if the GIF cannot load, the dash restores the stock warning.\r\n" +
				"Screens: All, a single number (5), or a list (1, 3, 5). Restrictions hide the popup only; native alarm and LED logic is unchanged."
		});
		grid.Dock = DockStyle.Fill;
		grid.AutoGenerateColumns = false;
		grid.AllowUserToAddRows = false;
		grid.AllowUserToDeleteRows = false;
		grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		grid.MultiSelect = false;
		foreach (string name in new[] { "Text", "Source", "X", "Y", "Width", "Height" })
			grid.Columns.Add(new DataGridViewTextBoxColumn {
				DataPropertyName = name, HeaderText = name == "Text" ? "Exact alarm text" : name,
				Width = name == "Text" || name == "Source" ? 260 : 65,
				ReadOnly = name == "Source" || (focused && name == "Text")
			});
		grid.Columns.Add(new DataGridViewCheckBoxColumn {
			DataPropertyName = "GifOnly", HeaderText = "GIF only (hide text/banner)", Width = 110
		});
		grid.Columns.Add(new DataGridViewTextBoxColumn {
			DataPropertyName = "ScreensText", HeaderText = "Screens (All or 1, 3, 5)", Width = 155
		});
		grid.DataSource = banners;
		grid.CurrentCellDirtyStateChanged += (_, _) => {
			if (grid.IsCurrentCellDirty && grid.CurrentCell is DataGridViewCheckBoxCell)
				grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
		};
		grid.SelectionChanged += (_, _) => canvas.Invalidate();
		grid.CellValueChanged += (_, _) => canvas.Invalidate();
		grid.CellValidating += (_, e) => {
			string property = grid.Columns[e.ColumnIndex].DataPropertyName;
			if (property == "ScreensText")
			{
				try { new NSP.AlertBanner { ScreensText = Convert.ToString(e.FormattedValue) }; }
				catch (InvalidDataException error)
				{
					e.Cancel = true;
					MessageBox.Show(this, error.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				return;
			}
			if (property != "X" && property != "Y" && property != "Width" && property != "Height")
				return;
			int minimum = property == "Height" ? 60 : property == "Width" ? 1 : 0;
			int maximum = property == "X" ? 859 : property == "Y" ? 420 : property == "Width" ? 860 : 480;
			if (!int.TryParse(Convert.ToString(e.FormattedValue), out int value) || value < minimum || value > maximum)
			{
				e.Cancel = true;
				MessageBox.Show(this, property + " must be a whole number between " + minimum + " and " + maximum + ".",
					Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		};
		grid.DataError += (_, e) => {
			e.ThrowException = false;
			MessageBox.Show(this, "Use whole-number coordinates and dimensions. Screens must be All or distinct numbers from 1 to 5.", Text,
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		};
		layout.Controls.Add(grid);

		canvas.Dock = DockStyle.Fill;
		canvas.BackColor = Color.Black;
		canvas.Paint += PaintCanvas;
		canvas.MouseDown += BeginDrag;
		canvas.MouseMove += MoveBanner;
		canvas.MouseUp += (_, _) => { dragging = false; canvas.Capture = false; };
		layout.Controls.Add(canvas);

		var buttons = new FlowLayoutPanel { Dock = DockStyle.Fill };
		var names = new ComboBox { Width = 210, DropDownStyle = ComboBoxStyle.DropDown };
		names.Text = focusText ?? "";
		names.Enabled = !focused;
		if (framework.awp != null)
			foreach (var alarm in framework.awp.method_73())
			{
				string name = AlarmText(alarm);
				if (!string.IsNullOrWhiteSpace(name) && !names.Items.Contains(name))
					names.Items.Add(name);
			}
		buttons.Controls.Add(names);
		AddButton(buttons, "Add alarm", () => {
			string text = names.Text;
			if (string.IsNullOrWhiteSpace(text) || banners.Any(banner => banner.Text == text))
				throw new InvalidDataException("Choose a nonempty, unique alarm name.");
			banners.Add(new NSP.AlertBanner { Text = text });
			grid.CurrentCell = grid.Rows[banners.Count - 1].Cells[0];
		});
		AddButton(buttons, "Choose GIF/image", ChooseImage);
		AddButton(buttons, "Stock background", () => {
			if (Selected == null)
				throw new InvalidOperationException("Select an alert first.");
			Selected.Source = "";
			Selected.GifOnly = false;
			grid.Refresh();
			canvas.Invalidate();
		});
		AddButton(buttons, "Remove override", () => {
			if (Selected != null)
				banners.Remove(Selected);
			canvas.Invalidate();
		});
		AddButton(buttons, "Apply", SaveBanners);
		AcceptButton = AddButton(buttons, "OK", () => { SaveBanners(); DialogResult = DialogResult.OK; Close(); });
		CancelButton = AddButton(buttons, "Cancel", () => { DialogResult = DialogResult.Cancel; Close(); }, false);
		applyToDash.Enabled = Form23.smethod_28(framework.aXc, true);
		buttons.Controls.Add(applyToDash);
		layout.Controls.Add(buttons);
		status.Text = "Apply updates this map and its desktop preview. Save the map normally to keep changes.";
		layout.Controls.Add(status);
		FormClosed += (_, _) => ClearPreviewImages();
		if (!string.IsNullOrWhiteSpace(focusText))
		{
			int index = banners.ToList().FindIndex(banner => banner.Text == focusText);
			if (index < 0)
			{
				banners.Add(new NSP.AlertBanner { Text = focusText });
				index = banners.Count - 1;
			}
			Shown += (_, _) => grid.CurrentCell = grid.Rows[index].Cells[0];
		}
	}

	// The dash receives the alarm's Message text, not the tree name ("Alarm 1").
	internal static string AlarmText(SettingOrSpecialObject alarm)
	{
		var strings = Descendants(alarm).OfType<Setting>().Where(setting => setting.method_70() != 0).ToList();
		Setting message = strings.FirstOrDefault(setting =>
				(setting.method_22(false) ?? "").IndexOf("message", StringComparison.OrdinalIgnoreCase) >= 0)
			?? strings.FirstOrDefault(setting => setting != alarm.method_19())
			?? strings.FirstOrDefault();
		return message?.method_260()?.TrimEnd('\0').Trim() ?? "";
	}

	internal static Setting AlarmTextSetting(SettingOrSpecialObject alarm)
	{
		var strings = Descendants(alarm).OfType<Setting>().Where(setting => setting.method_70() != 0).ToList();
		return strings.FirstOrDefault(setting =>
				(setting.method_22(false) ?? "").IndexOf("message", StringComparison.OrdinalIgnoreCase) >= 0)
			?? strings.FirstOrDefault(setting => setting != alarm.method_19())
			?? strings.FirstOrDefault();
	}

	private static System.Collections.Generic.IEnumerable<SettingOrSpecialObject> Descendants(SettingOrSpecialObject root)
	{
		foreach (var child in root.method_1())
		{
			yield return child;
			foreach (var descendant in Descendants(child))
				yield return descendant;
		}
	}

	private readonly System.Collections.Generic.Dictionary<string, (Image image, Stream stream)> previewImages =
		new System.Collections.Generic.Dictionary<string, (Image image, Stream stream)>(StringComparer.Ordinal);

	private void ClearPreviewImages()
	{
		foreach (var entry in previewImages.Values)
		{
			if (entry.image != null)
			{
				ImageAnimator.StopAnimate(entry.image, AnimatePreview);
				entry.image.Dispose();
			}
			entry.stream?.Dispose();
		}
		previewImages.Clear();
	}

	private void AnimatePreview(object sender, EventArgs e)
	{
		if (!IsDisposed && canvas.IsHandleCreated)
			canvas.BeginInvoke((Action)canvas.Invalidate);
	}

	private string SourcePath(string source) => source.StartsWith("u/", StringComparison.Ordinal)
		? Path.Combine(Form23.string_10, "images", source.Substring(2))
		: Form23.string_3 + Class333.smethod_1474() + source.Substring(2);

	private Image PreviewImage(string source)
	{
		if (string.IsNullOrEmpty(source))
			return null;
		if (previewImages.TryGetValue(source, out var cached))
			return cached.image;
		Image image = null;
		Stream stream = null;
		try
		{
			// GDI+ reads GIF frames lazily, so the stream must outlive the image.
			stream = new MemoryStream(File.ReadAllBytes(SourcePath(source)));
			image = Image.FromStream(stream);
			if (ImageAnimator.CanAnimate(image))
				ImageAnimator.Animate(image, AnimatePreview);
		}
		catch (Exception error)
		{
			Class23.smethod_3("Alert banner preview: " + source + ": " + error.Message, bool_1: false);
			image?.Dispose();
			stream?.Dispose();
			image = null;
			stream = null;
		}
		previewImages[source] = (image, stream);
		return image;
	}

	private ThemedButton AddButton(Control parent, string text, Action action, bool validate = true)
	{
		var button = new ThemedButton { Text = text, AutoSize = true, CausesValidation = validate };
		button.Click += (_, _) => {
			try
			{
				if (validate && !grid.EndEdit())
					throw new InvalidDataException("Correct the current cell before continuing.");
				action();
			}
			catch (Exception error)
			{
				Class23.smethod_3("Alert banner editor: " + error.Message);
				MessageBox.Show(this, error.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		};
		parent.Controls.Add(button);
		return button;
	}

	private void ChooseImage()
	{
		if (Selected == null)
			throw new InvalidOperationException("Add or select an alert first.");
		using var picker = new Form40(framework, false, false,
			framework.aww[Class1.Enum5.BFH], Class1.Enum5.BFH);
		if (picker.ShowDialog(this) != DialogResult.OK)
			return;
		string source = (picker.bool_2 ? "u/" : "h/") + picker.string_9;
		NSP.AlertMedia.Validate(new[] { new NSP.AlertBanner { Text = Selected.Text, Source = source } });
		Selected.Source = source;
		grid.Refresh();
		canvas.Invalidate();
	}

	private void SaveBanners()
	{
		if (!ValidateChildren())
			throw new InvalidDataException("Correct the highlighted value before applying.");
		grid.EndEdit();
		BindingContext[banners].EndCurrentEdit();
		var allBanners = otherBanners.Concat(banners).ToList();
		if (framework.awp != null)
		{
			var messages = framework.awp.method_73()
				.Select(alarm => new { Text = AlarmText(alarm), Setting = AlarmTextSetting(alarm) })
				.Where(message => message.Setting != null).ToList();
			foreach (var banner in allBanners)
			{
				var matches = messages.Where(message => message.Text == banner.Text).ToList();
				banner.MessageDataId = matches.Count == 1 ? matches[0].Setting.method_64() : null;
			}
		}
		byte[] manifest = NSP.AlertMedia.Serialize(allBanners);
		bool online = applyToDash.Checked;
		if (online && !Form23.smethod_28(framework.aXc, true))
			throw new IOException("The dash is disconnected. Untick upload to apply changes to the map only.");
		var markerSettings = new System.Collections.Generic.Dictionary<string, Setting>();
		var markerEdits = new System.Collections.Generic.Dictionary<string, string>();
		int screenCount = 0;
		if (allBanners.Any(banner => banner.Screens != null))
		{
			var settings = framework.aWs.Values
				.Where(setting => framework.method_31(setting.method_64()) == setting)
				.Where(setting => setting.method_2() == "NUM_SCREENS"
					|| setting.method_2()?.StartsWith("SCREEN_", StringComparison.Ordinal) == true)
				.ToDictionary(setting => setting.method_2(), setting => setting);
			if (!settings.TryGetValue("NUM_SCREENS", out Setting numberOfScreens))
				throw new InvalidDataException("The map has no native screen-count setting.");
			screenCount = numberOfScreens.method_256();
			if (allBanners.Any(banner => banner.Screens != null && banner.Screens.Any(screen => screen > screenCount)))
				throw new InvalidDataException("Choose only screens that exist in this map.");
			markerSettings = settings.Where(entry => entry.Key.StartsWith("SCREEN_", StringComparison.Ordinal))
				.ToDictionary(entry => entry.Key, entry => entry.Value);
			markerEdits = NSP.AlarmScreenMarkers.Plan(markerSettings.ToDictionary(entry => entry.Key,
				entry => entry.Value.method_70() != 0 ? entry.Value.method_260()
					: entry.Value.method_256().ToString(CultureInfo.InvariantCulture)), screenCount);
			if (markerEdits.Count > 0 && !online && Form23.smethod_28(framework.aXc, false))
				throw new InvalidOperationException("Screen tracking needs new map components. Disconnect the dash first, or tick Also upload to connected dash to apply the native setting changes.");
		}
		var images = new System.Collections.Generic.List<(string source, byte[] bytes)>();
		foreach (var source in allBanners.Where(banner => banner.Source.Length != 0)
			.Select(banner => banner.Source).Distinct(StringComparer.Ordinal))
		{
			string path = source.StartsWith("u/", StringComparison.Ordinal)
				? Path.Combine(Form23.string_10, "images", source.Substring(2))
				: Form23.string_3 + Class333.smethod_1474() + source.Substring(2);
			if (!File.Exists(path))
				throw new FileNotFoundException("Selected alert image is missing; reselect it.", path);
			byte[] image = File.ReadAllBytes(path);
			if (NSP.MediaResource.HasMp4Header(image))
				throw new InvalidDataException("Alert banners require a GIF or static image, not an MP4 alias.");
			NSP.SplashMedia.IsAnimated(path, image);
			images.Add((source, image));
		}
		foreach (var image in images.Where(image => image.source.StartsWith("u/", StringComparison.Ordinal)))
			Form23.SaveMediaResource(framework, image.source.Substring(2), image.bytes);
		for (int screen = 1; screen <= screenCount; screen++)
		{
			string source = NSP.AlarmScreenMarkers.Source(screen);
			Form23.SaveMediaResource(framework, source.Substring(2), NSP.AlarmScreenMarkers.Image);
			images.Add((source, NSP.AlarmScreenMarkers.Image));
		}
		if (markerEdits.Count > 0)
		{
			var undo = Form23.smethod_95();
			undo?.method_1();
			bool notify = framework.method_53();
			framework.method_55();
			try
			{
				foreach (var edit in markerEdits)
				{
					Setting setting = markerSettings[edit.Key];
					if (setting.method_70() != 0)
						setting.method_262(edit.Value, true);
					else
						setting.method_272(int.Parse(edit.Value, CultureInfo.InvariantCulture), true);
				}
				framework.aXd = true;
			}
			finally
			{
				undo?.method_4();
				if (notify)
					framework.method_54(true);
			}
		}
		Form23.SaveMediaResource(framework, NSP.AlertMedia.ManifestName, manifest);
		bool previewRunning = Form23.RefreshMediaPreview(framework);
		if (online)
		{
			foreach (var image in images.Where(image => image.source.StartsWith("u/", StringComparison.Ordinal)))
				Form23.UploadImageResource(image.source, image.bytes);
			Form23.UploadImageResource("u/" + NSP.AlertMedia.ManifestName, manifest);
		}
		status.Text = "Applied to map" + (previewRunning ? " and desktop preview" : " (desktop preview not running)")
			+ (online ? "; uploaded to dash." : ".") + " Save the map normally to keep changes.";
	}

	private float ScaleFactor => Math.Min(canvas.ClientSize.Width / 860f, canvas.ClientSize.Height / 480f);

	private void PaintCanvas(object sender, PaintEventArgs e)
	{
		float scale = ScaleFactor;
		if (scale <= 0)
			return;
		e.Graphics.ScaleTransform(scale, scale);
		e.Graphics.DrawRectangle(Pens.DimGray, 0, 0, 859, 479);
		ImageAnimator.UpdateFrames();
		using var textFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
		using var bannerFont = new Font(FontFamily.GenericSansSerif, 22f, FontStyle.Bold, GraphicsUnit.Pixel);
		foreach (var banner in banners)
		{
			var bounds = new Rectangle(banner.X, banner.Y, Math.Max(1, banner.Width), Math.Max(1, banner.Height));
			Image image = PreviewImage(banner.Source);
			bool mediaOnly = banner.GifOnly && image != null;
			if (!mediaOnly)
				e.Graphics.FillRectangle(Brushes.DarkSlateGray, bounds);
			if (image != null && image.Width > 0 && image.Height > 0)
			{
				// Matches HalImage PreserveAspectFit on the dash.
				float fit = Math.Min((float)bounds.Width / image.Width, (float)bounds.Height / image.Height);
				int width = Math.Max(1, (int)(image.Width * fit));
				int height = Math.Max(1, (int)(image.Height * fit));
				e.Graphics.DrawImage(image, bounds.X + (bounds.Width - width) / 2, bounds.Y + (bounds.Height - height) / 2, width, height);
			}
			using (var outline = new Pen(banner == Selected ? Color.Cyan : Color.White) { DashStyle = mediaOnly ? System.Drawing.Drawing2D.DashStyle.Dash : System.Drawing.Drawing2D.DashStyle.Solid })
				e.Graphics.DrawRectangle(outline, bounds);
			if (!mediaOnly)
				e.Graphics.DrawString((banner.Text ?? "").ToUpperInvariant(), bannerFont, Brushes.White, bounds, textFormat);
			if (banner == Selected)
				e.Graphics.FillRectangle(Brushes.Cyan, bounds.Right - 12, bounds.Bottom - 12, 12, 12);
		}
	}

	private void BeginDrag(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left || ScaleFactor <= 0)
			return;
		grid.EndEdit();
		var point = new Point((int)(e.X / ScaleFactor), (int)(e.Y / ScaleFactor));
		for (int index = banners.Count - 1; index >= 0; index--)
		{
			var banner = banners[index];
			var bounds = new Rectangle(banner.X, banner.Y, banner.Width, banner.Height);
			if (!bounds.Contains(point))
				continue;
			grid.CurrentCell = grid.Rows[index].Cells[0];
			dragStart = point;
			original = bounds;
			resizing = point.X >= bounds.Right - 16 && point.Y >= bounds.Bottom - 16;
			dragging = true;
			canvas.Capture = true;
			break;
		}
	}

	private void MoveBanner(object sender, MouseEventArgs e)
	{
		if (!dragging || Selected == null || ScaleFactor <= 0)
			return;
		int dx = (int)(e.X / ScaleFactor) - dragStart.X;
		int dy = (int)(e.Y / ScaleFactor) - dragStart.Y;
		if (resizing)
		{
			Selected.Width = Math.Clamp(original.Width + dx, 1, 860 - Math.Clamp(original.X, 0, 859));
			Selected.Height = Math.Clamp(original.Height + dy, 60, 480 - Math.Clamp(original.Y, 0, 420));
		}
		else
		{
			Selected.X = Math.Clamp(original.X + dx, 0, Math.Max(0, 860 - Selected.Width));
			Selected.Y = Math.Clamp(original.Y + dy, 0, Math.Max(0, 480 - Selected.Height));
		}
		grid.Refresh();
		canvas.Invalidate();
	}
}
