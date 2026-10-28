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
        // ---- window chrome ----
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(560, 540);
        Size = new Size(660, 600);
        BackColor = Theme.Charcoal;
        Font = new Font("Segoe UI", 9f);
        Text = "Nexmap Unlock";
        DoubleBuffered = true;
        AllowDrop = true;

        var header = BuildHeader();
        var status = BuildStatusBar();
        _statusLeft = (Label)status.Controls["statusLeft"]!;

        // ---- body ----
        var body = new Panel { Dock = DockStyle.Fill, BackColor = Theme.Charcoal };

        var title = new Label
        {
            Text = "REMOVE MAP PASSWORD PROTECTION",
            ForeColor = Theme.Yellow,
            Font = new Font("Segoe UI Semibold", 10.5f, FontStyle.Bold),
            AutoSize = true,
            Location = new Point(24, 14),
        };
        var subtitle = new Label
        {
            Text = "Recover .nexmap files locked by an uncontactable tuner.",
            ForeColor = Theme.TextDim,
            Font = new Font("Segoe UI", 9f),
            AutoSize = true,
            Location = new Point(24, 38),
        };
        body.Controls.Add(title);
        body.Controls.Add(subtitle);

        _drop = new DropZone
        {
            Location = new Point(24, 68),
            Size = new Size(Width - 48, 168),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
        };
        _drop.FilesDropped += files => ProcessFiles(files);
        _drop.Clicked += (_, _) => BrowseAndUnlock();
        body.Controls.Add(_drop);

        var browse = new HaltechButton
        {
            Text = "CHOOSE FILES",
            Primary = true,
            Size = new Size(150, 40),
            Location = new Point(24, 250),
            Anchor = AnchorStyles.Top | AnchorStyles.Left,
        };
        browse.Click += (_, _) => BrowseAndUnlock();
        body.Controls.Add(browse);

        _suffixToggle = new ToggleSwitch
        {
            On = true,
            Location = new Point(Width - 48 - 46, 258),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
        };
        _toggleLabel = new Label
        {
            Text = "Save as a copy  \u201c(unlocked)\u201d",
            ForeColor = Theme.TextDim,
            Font = new Font("Segoe UI", 8.5f),
            AutoSize = true,
            TextAlign = ContentAlignment.MiddleRight,
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
        };
        _toggleLabel.Location = new Point(_suffixToggle.Left - 196, 262);
        _suffixToggle.Toggled += (_, _) =>
            _toggleLabel.Text = _suffixToggle.On ? "Save as a copy  \u201c(unlocked)\u201d" : "Overwrite the original file";
        body.Controls.Add(_suffixToggle);
        body.Controls.Add(_toggleLabel);

        var logLabel = new Label
        {
            Text = "ACTIVITY",
            ForeColor = Theme.TextDim,
            Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold),
            AutoSize = true,
            Location = new Point(24, 306),
            Anchor = AnchorStyles.Top | AnchorStyles.Left,
        };
        body.Controls.Add(logLabel);

        _log = new RichTextBox
        {
            Location = new Point(24, 326),
            Size = new Size(Width - 48, Height - 326 - 48 - 28 - 12),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            BorderStyle = BorderStyle.None,
            BackColor = Theme.Panel,
            ForeColor = Theme.Text,
            ReadOnly = true,
            Font = new Font("Consolas", 9f),
            WordWrap = false,
        };
        body.Controls.Add(_log);

        Controls.Add(body);
        Controls.Add(status);
        Controls.Add(header);

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
        header.Paint += (_, e) =>
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var b = new SolidBrush(Theme.Yellow))
                g.FillRectangle(b, 0, header.Height - 3, header.Width, 3);

            var mark = new Rectangle(14, 11, 24, 24);
            Theme.FillRounded(g, mark, 5, Theme.Yellow);
            DrawOpenLock(g, mark, Theme.Ink);

            TextRenderer.DrawText(g, "HALTECH", new Font("Segoe UI", 11f, FontStyle.Bold),
                new Point(47, 7), Theme.Text, TextFormatFlags.NoPadding);
            TextRenderer.DrawText(g, "NEXMAP UNLOCK", new Font("Segoe UI Semibold", 8f, FontStyle.Bold),
                new Point(48, 27), Theme.Yellow, TextFormatFlags.NoPadding);
        };
        header.MouseDown += DragMove;

        var close = new ChromeButton { IsClose = true, Dock = DockStyle.Right };
        close.Click += (_, _) => Close();
        var min = new ChromeButton { Dock = DockStyle.Right };
        min.Click += (_, _) => WindowState = FormWindowState.Minimized;
        header.Controls.Add(close);
        header.Controls.Add(min);
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
            Text = "v1.0.0  ",
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

    private static void DrawOpenLock(Graphics g, Rectangle box, Color color)
    {
        using var pen = new Pen(color, 2f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
        using var brush = new SolidBrush(color);
        var bodyRect = new Rectangle(box.X + 6, box.Y + 12, 12, 9);
        g.FillRectangle(brush, bodyRect);
        g.DrawArc(pen, box.X + 3, box.Y + 3, 9, 9, 150, 240);
        g.DrawLine(pen, box.X + 12, box.Y + 5, box.X + 12, box.Y + 9);
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
            var pos = PointToClient(new Point(m.LParam.ToInt32()));
            bool l = pos.X <= GRIP, r = pos.X >= ClientSize.Width - GRIP;
            bool t = pos.Y <= GRIP, b = pos.Y >= ClientSize.Height - GRIP;
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

        SetStatus($"Done \u2014 {ok} unlocked, {failed} failed");
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
                LogLine($"fail  {name}  \u2014 {ex.Message}", Theme.Bad);
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
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
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

        int cx = Width / 2, cy = Height / 2 - 20;
        DrawBigUnlock(g, new Rectangle(cx - 17, cy - 16, 34, 32), accent);

        string head = Enabled ? "Drag .nexmap files here" : "Working \u2026";
        string sub = Enabled ? "or click to browse" : "please wait";
        TextRenderer.DrawText(g, head, new Font("Segoe UI Semibold", 11f, FontStyle.Bold),
            new Rectangle(0, cy + 26, Width, 24), Enabled ? Theme.Text : Theme.TextDim,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        TextRenderer.DrawText(g, sub, new Font("Segoe UI", 9f),
            new Rectangle(0, cy + 50, Width, 20), Theme.TextDim,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private static void DrawBigUnlock(Graphics g, Rectangle box, Color color)
    {
        using var brush = new SolidBrush(color);
        using var pen = new Pen(color, 3f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
        var body = new Rectangle(box.X + 4, box.Y + 14, box.Width - 8, box.Height - 14);
        using (var p = Theme.RoundedRect(body, 4)) g.FillPath(brush, p);
        g.DrawArc(pen, box.X - 2, box.Y, 16, 16, 140, 250);
        g.DrawLine(pen, box.X + 13, box.Y + 4, box.X + 13, box.Y + 12);
        using var hole = new SolidBrush(Theme.Panel);
        g.FillEllipse(hole, box.X + box.Width / 2 - 2, box.Y + 20, 5, 5);
    }
}
