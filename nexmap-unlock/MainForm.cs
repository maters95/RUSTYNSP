using System.Text;

namespace NexmapUnlock;

public sealed class MainForm : Form
{
    private readonly Label _dropLabel;
    private readonly TextBox _log;
    private readonly Button _browseButton;
    private readonly CheckBox _inPlaceSuffix;

    public MainForm(string[]? initialFiles = null)
    {
        Text = "Nexmap Password Remover";
        MinimumSize = new Size(560, 420);
        Size = new Size(620, 480);
        StartPosition = FormStartPosition.CenterScreen;
        AllowDrop = true;
        Font = new Font("Segoe UI", 9f);

        var dropPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 130,
            BackColor = Color.FromArgb(245, 247, 250),
            Margin = new Padding(0),
            AllowDrop = true,
        };
        _dropLabel = new Label
        {
            Dock = DockStyle.Fill,
            Text = "Drag one or more .nexmap files here to remove password protection",
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
            ForeColor = Color.FromArgb(60, 70, 85),
            AllowDrop = true,
        };
        dropPanel.Controls.Add(_dropLabel);

        var buttonBar = new Panel { Dock = DockStyle.Top, Height = 44 };
        _browseButton = new Button
        {
            Text = "Choose files\u2026",
            Left = 10,
            Top = 8,
            Width = 120,
            Height = 28,
        };
        _browseButton.Click += (_, _) => BrowseAndUnlock();

        _inPlaceSuffix = new CheckBox
        {
            Text = "Write \"<name> (unlocked).nexmap\" (uncheck to overwrite original)",
            Left = 145,
            Top = 11,
            Width = 440,
            Checked = true,
        };

        buttonBar.Controls.Add(_browseButton);
        buttonBar.Controls.Add(_inPlaceSuffix);

        _log = new TextBox
        {
            Dock = DockStyle.Fill,
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            BackColor = Color.White,
            Font = new Font("Consolas", 9f),
        };

        // Add in reverse so docking stacks correctly (Fill first, then Top bars).
        Controls.Add(_log);
        Controls.Add(buttonBar);
        Controls.Add(dropPanel);

        foreach (Control c in new Control[] { this, dropPanel, _dropLabel })
        {
            c.DragEnter += OnDragEnter;
            c.DragDrop += OnDragDrop;
        }

        Log($"Ready. Archive key loaded.");
        Log("Drop a protected .nexmap to produce an unlocked copy NSP can open.");

        if (initialFiles is { Length: > 0 })
        {
            BeginInvoke(new Action(() => ProcessFiles(initialFiles)));
        }
    }

    private void OnDragEnter(object? sender, DragEventArgs e)
    {
        if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            e.Effect = DragDropEffects.Copy;
    }

    private void OnDragDrop(object? sender, DragEventArgs e)
    {
        if (e.Data?.GetData(DataFormats.FileDrop) is string[] files)
            ProcessFiles(files);
    }

    private void BrowseAndUnlock()
    {
        using var dlg = new OpenFileDialog
        {
            Title = "Select .nexmap file(s)",
            Filter = "Nexmap files (*.nexmap)|*.nexmap|All files (*.*)|*.*",
            Multiselect = true,
        };
        if (dlg.ShowDialog(this) == DialogResult.OK)
            ProcessFiles(dlg.FileNames);
    }

    private void ProcessFiles(IEnumerable<string> files)
    {
        int ok = 0, skipped = 0, failed = 0;
        foreach (string path in files)
        {
            string name = Path.GetFileName(path);
            try
            {
                if (!File.Exists(path))
                {
                    Log($"[skip] {name}: not a file");
                    skipped++;
                    continue;
                }

                string outPath = _inPlaceSuffix.Checked
                    ? BuildOutputPath(path)
                    : path;

                // When overwriting in place, unlock to a temp file first, then replace.
                if (!_inPlaceSuffix.Checked)
                {
                    string tmp = path + ".tmp-unlock";
                    var r = NexmapUnlocker.Unlock(path, tmp);
                    File.Copy(tmp, path, overwrite: true);
                    File.Delete(tmp);
                    Log(r.WasProtected
                        ? $"[ok]   {name}: protection removed (overwritten)"
                        : $"[ok]   {name}: was not protected (rewritten in place)");
                }
                else
                {
                    var r = NexmapUnlocker.Unlock(path, outPath);
                    Log(r.WasProtected
                        ? $"[ok]   {name}: protection removed -> {Path.GetFileName(outPath)}"
                        : $"[ok]   {name}: was not protected -> {Path.GetFileName(outPath)}");
                }
                ok++;
            }
            catch (Exception ex)
            {
                Log($"[fail] {name}: {ex.Message}");
                failed++;
            }
        }

        Log($"Done. {ok} unlocked, {skipped} skipped, {failed} failed.");
        Log(new string('-', 50));
    }

    public static string BuildOutputPath(string inputPath)
    {
        string dir = Path.GetDirectoryName(Path.GetFullPath(inputPath)) ?? ".";
        string file = Path.GetFileName(inputPath);

        // Preserve the full compound extension, e.g. ".nexHondaEP3-1-36-2.nexmap".
        int firstDot = file.IndexOf('.');
        string stem = firstDot < 0 ? file : file[..firstDot];
        string exts = firstDot < 0 ? string.Empty : file[firstDot..];
        return Path.Combine(dir, $"{stem} (unlocked){exts}");
    }

    private void Log(string line)
    {
        if (InvokeRequired)
        {
            BeginInvoke(new Action(() => Log(line)));
            return;
        }
        _log.AppendText(line + Environment.NewLine);
    }
}
