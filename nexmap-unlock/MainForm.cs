using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace NexmapUnlock;

public sealed class MainForm : Form
{
    private readonly RichTextBox _log;
    private readonly DropZone _drop;
    private readonly ToggleSwitch _suffixToggle;
    private readonly Label _toggleLabel;
    private readonly Label _statusLeft;
    private bool _busy;

    public MainForm(string[]? initialFiles = null)
    {
        SuspendLayout();
        AutoScaleDimensions = new SizeF(96f, 96f);
        AutoScaleMode = AutoScaleMode.Dpi;
        // ---- window chrome ----
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(560, 540);
        Size = new Size(660, 600);
        BackColor = Theme.Charcoal;
        Font = new Font("Segoe UI", 9f);
        Text = "Nexmap Unlock";
        Icon = AppBrand.Icon;
        DoubleBuffered = true;
        AllowDrop = true;

        var header = BuildHeader();
        var status = BuildStatusBar();
        _statusLeft = (Label)status.Controls["statusLeft"]!;

        // ---- body ----
        var body = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            BackColor = Theme.Charcoal,
            Padding = new Padding(24, 14, 24, 16),
            ColumnCount = 1,
            RowCount = 6,
        };
        body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        body.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
        body.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
        body.RowStyles.Add(new RowStyle(SizeType.Absolute, 168));
        body.RowStyles.Add(new RowStyle(SizeType.Absolute, 64));
        body.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
        body.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

        var title = new Label
        {
            Text = "REMOVE MAP PASSWORD PROTECTION",
            ForeColor = Theme.Yellow,
            Font = new Font("Segoe UI Semibold", 10.5f, FontStyle.Bold),
            Dock = DockStyle.Fill,
            Margin = Padding.Empty,
        };
        var subtitle = new Label
        {
            Text = "Recover .nexmap files locked by an uncontactable tuner.",
            ForeColor = Theme.TextDim,
            Font = new Font("Segoe UI", 9f),
            Dock = DockStyle.Fill,
            Margin = Padding.Empty,
        };
        body.Controls.Add(title, 0, 0);
        body.Controls.Add(subtitle, 0, 1);

        _drop = new DropZone
        {
            Dock = DockStyle.Fill,
            Margin = Padding.Empty,
        };
        _drop.FilesDropped += files => ProcessFiles(files);
        _drop.Clicked += (_, _) => BrowseAndUnlock();
        body.Controls.Add(_drop, 0, 2);

        var actions = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            Margin = Padding.Empty,
            ColumnCount = 3,
            RowCount = 1,
        };
        actions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
        actions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        actions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46));
        actions.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

        var browse = new HaltechButton
        {
            Text = "CHOOSE FILES",
            Primary = true,
            Size = new Size(150, 40),
            Anchor = AnchorStyles.Left,
            Margin = Padding.Empty,
        };
        browse.Click += (_, _) => BrowseAndUnlock();
        actions.Controls.Add(browse, 0, 0);

        _suffixToggle = new ToggleSwitch
        {
            On = true,
            Anchor = AnchorStyles.Right,
            Margin = Padding.Empty,
        };
        _toggleLabel = new Label
        {
            Text = "Save as a copy  \u201c(unlocked)\u201d",
            ForeColor = Theme.TextDim,
            Font = new Font("Segoe UI", 8.5f),
            Dock = DockStyle.Fill,
            Margin = new Padding(8, 0, 10, 0),
            TextAlign = ContentAlignment.MiddleRight,
        };
        _suffixToggle.Toggled += (_, _) =>
            _toggleLabel.Text = _suffixToggle.On ? "Save as a copy  \u201c(unlocked)\u201d" : "Overwrite the original file";
        actions.Controls.Add(_toggleLabel, 1, 0);
        actions.Controls.Add(_suffixToggle, 2, 0);
        body.Controls.Add(actions, 0, 3);

        var logLabel = new Label
        {
            Text = "ACTIVITY",
            ForeColor = Theme.TextDim,
            Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft,
            Margin = Padding.Empty,
        };
        body.Controls.Add(logLabel, 0, 4);

        _log = new RichTextBox
        {
            Dock = DockStyle.Fill,
            Margin = Padding.Empty,
            BorderStyle = BorderStyle.None,
            BackColor = Theme.Panel,
            ForeColor = Theme.Text,
            ReadOnly = true,
            Font = new Font("Consolas", 9f),
            WordWrap = false,
        };
        body.Controls.Add(_log, 0, 5);

        Controls.Add(body);
        Controls.Add(status);
        Controls.Add(header);
        ResumeLayout(true);

        LogLine("Ready.", Theme.TextDim);
        LogLine("Archive key loaded \u00b7 WinZip AES-256.", Theme.TextDim);
        LogLine("Drop a protected .nexmap to produce an unlocked copy.", Theme.TextDim);

        if (initialFiles is { Length: > 0 })
            BeginInvoke(new Action(() => ProcessFiles(initialFiles)));
    }

    // ---------------------------------------------------------------- chrome

    private Panel BuildHeader()
    {
        var header = new Panel { Dock = DockStyle.Top, Height = 48, BackColor = Theme.Ink };
        var layout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 3,
            RowCount = 1,
            Margin = Padding.Empty,
        };
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

        var brand = new Panel { Dock = DockStyle.Fill, Margin = Padding.Empty };
        var logo = new PictureBox
        {
            Image = AppBrand.Logo,
            SizeMode = PictureBoxSizeMode.Zoom,
            Dock = DockStyle.Left,
            Width = 48,
            Padding = new Padding(10, 6, 6, 6),
        };
        var name = new Label
        {
            Text = "NEXMAP UNLOCK",
            ForeColor = Theme.Text,
            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
            Dock = DockStyle.Top,
            Height = 25,
            TextAlign = ContentAlignment.BottomLeft,
        };
        var detail = new Label
        {
            Text = "HALTECH MAP RECOVERY",
            ForeColor = Theme.Yellow,
            Font = new Font("Segoe UI", 7.5f),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.TopLeft,
        };
        brand.Controls.Add(detail);
        brand.Controls.Add(name);
        brand.Controls.Add(logo);
        header.MouseDown += DragMove;
        layout.MouseDown += DragMove;
        brand.MouseDown += DragMove;
        logo.MouseDown += DragMove;
        name.MouseDown += DragMove;
        detail.MouseDown += DragMove;

        var close = new ChromeButton
        {
            IsClose = true, Dock = DockStyle.Fill, Margin = Padding.Empty, AccessibleName = "Close",
        };
        close.Click += (_, _) => Close();
        var min = new ChromeButton
        {
            Dock = DockStyle.Fill, Margin = Padding.Empty, AccessibleName = "Minimise",
        };
        min.Click += (_, _) => WindowState = FormWindowState.Minimized;
        layout.Controls.Add(brand, 0, 0);
        layout.Controls.Add(min, 1, 0);
        layout.Controls.Add(close, 2, 0);
        header.Controls.Add(layout);
        header.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = Theme.Yellow });
        return header;
    }

    private Panel BuildStatusBar()
    {
        var bar = new Panel { Dock = DockStyle.Bottom, Height = 28, BackColor = Theme.Ink };
        bar.Paint += (_, e) =>
        {
            using var p = new Pen(Theme.Line);
            e.Graphics.DrawLine(p, 0, 0, bar.Width, 0);
        };
        var left = new Label
        {
            Name = "statusLeft",
            Text = "  Idle",
            ForeColor = Theme.TextDim,
            Font = new Font("Segoe UI", 8.5f),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft,
        };
        var right = new Label
        {
            Text = $"v{Application.ProductVersion.Split('+')[0]}  ",
            ForeColor = Theme.YellowDim,
            Font = new Font("Segoe UI", 8.5f),
            Width = 80,
            Dock = DockStyle.Right,
            TextAlign = ContentAlignment.MiddleRight,
        };
        bar.Controls.Add(left);
        bar.Controls.Add(right);
        return bar;
    }

    // Draggable + resizable borderless window.
    private const int WM_NCHITTEST = 0x84;
    private const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13,
                      HTTOPRIGHT = 14, HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;
    private const int GRIP = 6;

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_NCHITTEST)
        {
            base.WndProc(ref m);
            var pos = PointToClient(new Point(unchecked((int)m.LParam.ToInt64())));
            int grip = LogicalToDeviceUnits(GRIP);
            bool l = pos.X <= grip, r = pos.X >= ClientSize.Width - grip;
            bool t = pos.Y <= grip, b = pos.Y >= ClientSize.Height - grip;
            int hit = (t && l) ? HTTOPLEFT : (t && r) ? HTTOPRIGHT :
                      (b && l) ? HTBOTTOMLEFT : (b && r) ? HTBOTTOMRIGHT :
                      l ? HTLEFT : r ? HTRIGHT : t ? HTTOP : b ? HTBOTTOM : 0;
            if (hit != 0) m.Result = hit;
            return;
        }
        base.WndProc(ref m);
    }

    [DllImport("user32.dll")] private static extern bool ReleaseCapture();
    [DllImport("user32.dll")] private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    private void DragMove(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        ReleaseCapture();
        SendMessage(Handle, 0xA1, 0x2, 0); // WM_NCLBUTTONDOWN + HTCAPTION
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        base.OnPaintBackground(e);
        using var pen = new Pen(Theme.Line);
        e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
    }

    // ---------------------------------------------------------------- actions

    private void BrowseAndUnlock()
    {
        if (_busy) return;
        using var dlg = new OpenFileDialog
        {
            Title = "Select .nexmap file(s)",
            Filter = "Nexmap files (*.nexmap)|*.nexmap|All files (*.*)|*.*",
            Multiselect = true,
        };
        if (dlg.ShowDialog(this) == DialogResult.OK)
            ProcessFiles(dlg.FileNames);
    }

    private async void ProcessFiles(IEnumerable<string> files)
    {
        if (_busy) return;
        var list = files.ToArray();
        if (list.Length == 0) return;

        bool suffix = _suffixToggle.On;
        _busy = true;
        _drop.Enabled = false;
        SetStatus($"Working \u2026 {list.Length} file(s)");
        LogLine(new string('\u2500', 48), Theme.Line);

        var (ok, skipped, failed) = await Task.Run(() => RunBatch(list, suffix));

        SetStatus($"Done: {ok} unlocked, {failed} failed");
        LogLine($"Finished: {ok} unlocked, {skipped} skipped, {failed} failed.",
            failed > 0 ? Theme.Bad : Theme.Good);
        _drop.Enabled = true;
        _busy = false;
    }

    private (int ok, int skipped, int failed) RunBatch(string[] files, bool suffix)
    {
        int ok = 0, skipped = 0, failed = 0;
        foreach (string path in files)
        {
            string name = Path.GetFileName(path);
            try
            {
                if (!File.Exists(path)) { LogLine($"skip  {name}  (not a file)", Theme.TextDim); skipped++; continue; }

                if (suffix)
                {
                    string outPath = BuildOutputPath(path);
                    var res = NexmapUnlocker.Unlock(path, outPath);
                    LogLine(res.WasProtected
                        ? $"ok    {name}  \u2192  {Path.GetFileName(outPath)}"
                        : $"ok    {name}  (not protected)  \u2192  {Path.GetFileName(outPath)}",
                        res.WasProtected ? Theme.Good : Theme.TextDim);
                }
                else
                {
                    string tmp = path + ".tmp-unlock";
                    var res = NexmapUnlocker.Unlock(path, tmp);
                    File.Copy(tmp, path, overwrite: true);
                    File.Delete(tmp);
                    LogLine(res.WasProtected
                        ? $"ok    {name}  (protection removed, overwritten)"
                        : $"ok    {name}  (not protected, rewritten)",
                        res.WasProtected ? Theme.Good : Theme.TextDim);
                }
                ok++;
            }
            catch (Exception ex)
            {
                LogLine($"fail  {name}: {ex.Message}", Theme.Bad);
                failed++;
            }
        }
        return (ok, skipped, failed);
    }

    public static string BuildOutputPath(string inputPath)
    {
        string dir = Path.GetDirectoryName(Path.GetFullPath(inputPath)) ?? ".";
        string file = Path.GetFileName(inputPath);
        int firstDot = file.IndexOf('.');
        string stem = firstDot < 0 ? file : file[..firstDot];
        string exts = firstDot < 0 ? string.Empty : file[firstDot..];
        return Path.Combine(dir, $"{stem} (unlocked){exts}");
    }

    private void SetStatus(string text)
    {
        if (InvokeRequired) { BeginInvoke(new Action(() => SetStatus(text))); return; }
        _statusLeft.Text = "  " + text;
    }

    private void LogLine(string line, Color color)
    {
        if (InvokeRequired) { BeginInvoke(new Action(() => LogLine(line, color))); return; }
        _log.SelectionStart = _log.TextLength;
        _log.SelectionLength = 0;
        _log.SelectionColor = color;
        _log.AppendText(line + Environment.NewLine);
        _log.SelectionColor = _log.ForeColor;
        _log.ScrollToCaret();
    }
}

/// <summary>Custom drop zone: dashed rounded border, hover highlight, unlock glyph.</summary>
internal sealed class DropZone : Control
{
    private bool _hot;
    public event Action<string[]>? FilesDropped;
    public event EventHandler? Clicked;

    public DropZone()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor |
                 ControlStyles.ResizeRedraw, true);
        BackColor = Color.Transparent;
        AllowDrop = true;
        Cursor = Cursors.Hand;

        DragEnter += (_, e) =>
        {
            if (Enabled && e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            { e.Effect = DragDropEffects.Copy; _hot = true; Invalidate(); }
        };
        DragLeave += (_, _) => { _hot = false; Invalidate(); };
        DragDrop += (_, e) =>
        {
            _hot = false; Invalidate();
            if (Enabled && e.Data?.GetData(DataFormats.FileDrop) is string[] f)
                FilesDropped?.Invoke(f);
        };
        Click += (s, e) => { if (Enabled) Clicked?.Invoke(s, e); };
        MouseEnter += (_, _) => { if (Enabled) { _hot = true; Invalidate(); } };
        MouseLeave += (_, _) => { _hot = false; Invalidate(); };
    }

    protected override void OnEnabledChanged(EventArgs e) { _hot = false; Invalidate(); base.OnEnabledChanged(e); }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        var r = new Rectangle(1, 1, Width - 3, Height - 3);

        Color accent = !Enabled ? Theme.Line : _hot ? Theme.Yellow : Theme.YellowDim;

        using (var path = Theme.RoundedRect(r, 12))
        using (var fill = new SolidBrush(_hot && Enabled ? Theme.PanelHi : Theme.Panel))
            g.FillPath(fill, path);

        using (var path = Theme.RoundedRect(r, 12))
        using (var pen = new Pen(accent, 1.6f) { DashStyle = DashStyle.Dash, DashPattern = new[] { 4f, 3f } })
            g.DrawPath(pen, path);

        int cx = Width / 2, cy = Height / 2 - LogicalToDeviceUnits(20);
        int logoSize = LogicalToDeviceUnits(40);
        g.DrawImage(AppBrand.Logo, new Rectangle(cx - logoSize / 2, cy - logoSize / 2, logoSize, logoSize));

        string head = Enabled ? "Drag .nexmap files here" : "Working \u2026";
        string sub = Enabled ? "or click to browse" : "please wait";
        using var headFont = new Font("Segoe UI Semibold", 11f, FontStyle.Bold);
        using var subFont = new Font("Segoe UI", 9f);
        TextRenderer.DrawText(g, head, headFont,
            new Rectangle(0, cy + LogicalToDeviceUnits(26), Width, LogicalToDeviceUnits(24)), Enabled ? Theme.Text : Theme.TextDim,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        TextRenderer.DrawText(g, sub, subFont,
            new Rectangle(0, cy + LogicalToDeviceUnits(50), Width, LogicalToDeviceUnits(20)), Theme.TextDim,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
