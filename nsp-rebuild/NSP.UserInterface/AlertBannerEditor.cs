using System;
using System.ComponentModel;
using System.Drawing;
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
	private readonly DataGridView grid = new DataGridView();
	private readonly Panel canvas = new Panel();
	private Point dragStart;
	private Rectangle original;
	private bool resizing;
	private bool dragging;
	private NSP.AlertBanner Selected => grid.CurrentRow?.DataBoundItem as NSP.AlertBanner;

	internal AlertBannerEditor(Framework currentFramework, string focusText = null)
	{
		framework = currentFramework;
		banners = new BindingList<NSP.AlertBanner>(NSP.AlertMedia.Read(
			Path.Combine(Form23.string_10, "images", NSP.AlertMedia.ManifestName)));
		Text = "iC-7 alert GIF banners and placement";
		Width = 1000;
		Height = 760;
		MinimumSize = new Size(920, 680);
		StartPosition = FormStartPosition.CenterParent;
		BackColor = Form23.color_10;
		ForeColor = Form23.color_12;

		var layout = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 4, ColumnCount = 1 };
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 190));
		layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
		Controls.Add(layout);
		layout.Controls.Add(new Label {
			Dock = DockStyle.Fill,
			Text = "Match the alarm's exact Message text (as shown on the dash, case-sensitive). Colour, priority and clearing remain controlled by the dash.\r\n" +
				"Drag a rectangle to move; drag its bottom-right corner to resize. Numeric values use the 860 x 480 dash canvas. GIFs animate in this preview.\r\n" +
				"Tick \"GIF only\" to hide the coloured banner and text; if the GIF cannot load, the dash restores the stock warning."
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
				Width = name == "Text" || name == "Source" ? 260 : 65, ReadOnly = name == "Source"
			});
		grid.Columns.Add(new DataGridViewCheckBoxColumn {
			DataPropertyName = "GifOnly", HeaderText = "GIF only (hide text/banner)", Width = 110
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
			MessageBox.Show(this, "Coordinates and dimensions must be whole numbers.", Text,
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
		AddButton(buttons, "Save / apply", SaveBanners);
		layout.Controls.Add(buttons);
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

	private void AddButton(Control parent, string text, Action action)
	{
		var button = new Button { Text = text, AutoSize = true };
		button.Click += (_, _) => {
			try
			{
				if (!grid.EndEdit())
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
		byte[] manifest = NSP.AlertMedia.Serialize(banners.ToList());
		bool online = Form23.smethod_28(framework.aXc, true);
		foreach (var source in banners.Where(banner => banner.Source.Length != 0)
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
			if (online && source.StartsWith("u/", StringComparison.Ordinal))
				Form23.UploadImageResource(source, image);
		}
		if (!Form23.smethod_20(Form23.string_10, NSP.AlertMedia.ManifestName, manifest, "images", out string error)
			|| !Form23.smethod_18(framework, NSP.AlertMedia.ManifestName, manifest, "images", out error))
			throw new IOException("Cannot save alert configuration: " + error);
		if (online)
			Form23.UploadImageResource("u/" + NSP.AlertMedia.ManifestName, manifest);
		MessageBox.Show(this, "Alert overrides saved to user resources. Save the map under a new name.\r\n" +
			"Upload/apply the map resources and reboot the dash/emulator, or reopen the map's desktop renderer, to reload them.",
			Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
