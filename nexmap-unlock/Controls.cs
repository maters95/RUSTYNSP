using System.Drawing.Drawing2D;

namespace NexmapUnlock;

/// <summary>Flat, Haltech-styled button. Primary = yellow fill; otherwise outlined.</summary>
internal sealed class HaltechButton : Button
{
    public bool Primary { get; set; } = true;
    private bool _hover;
    private bool _down;

    public HaltechButton()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = Color.Transparent;
        Cursor = Cursors.Hand;
        Font = new Font("Segoe UI Semibold", 9.5f, FontStyle.Bold);
        Height = 40;
    }

    protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
    protected override void OnMouseLeave(EventArgs e) { _hover = false; _down = false; Invalidate(); base.OnMouseLeave(e); }
    protected override void OnMouseDown(MouseEventArgs e) { _down = true; Invalidate(); base.OnMouseDown(e); }
    protected override void OnMouseUp(MouseEventArgs e) { _down = false; Invalidate(); base.OnMouseUp(e); }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        var r = new Rectangle(0, 0, Width - 1, Height - 1);

        if (Primary)
        {
            Color fill = _down ? Theme.YellowDim : _hover ? Theme.YellowBright : Theme.Yellow;
            Theme.FillRounded(g, r, 8, fill);
            TextRenderer.DrawText(g, Text, Font, r, Theme.Ink,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        else
        {
            using var path = Theme.RoundedRect(r, 8);
            using var bg = new SolidBrush(_down ? Theme.Panel : _hover ? Theme.PanelHi : Theme.Panel);
            g.FillPath(bg, path);
            using var pen = new Pen(_hover ? Theme.Yellow : Theme.Line, 1.4f);
            g.DrawPath(pen, path);
            TextRenderer.DrawText(g, Text, Font, r, _hover ? Theme.Yellow : Theme.Text,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}

/// <summary>Small chrome button (minimize / close) for the custom title bar.</summary>
internal sealed class ChromeButton : Button
{
    public bool IsClose { get; set; }
    private bool _hover;

    public ChromeButton()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer, true);
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = Theme.Ink;
        Size = new Size(40, 30);
        TabStop = false;
        Cursor = Cursors.Hand;
    }

    protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
    protected override void OnMouseLeave(EventArgs e) { _hover = false; Invalidate(); base.OnMouseLeave(e); }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(_hover ? (IsClose ? Theme.Bad : Theme.PanelHi) : Theme.Ink);

        Color glyph = _hover && IsClose ? Color.White : Theme.Text;
        int cx = Width / 2, cy = Height / 2;
        using var pen = new Pen(glyph, 1.6f);
        if (IsClose)
        {
            g.DrawLine(pen, cx - 5, cy - 5, cx + 5, cy + 5);
            g.DrawLine(pen, cx + 5, cy - 5, cx - 5, cy + 5);
        }
        else
        {
            g.DrawLine(pen, cx - 5, cy + 4, cx + 5, cy + 4);
        }
    }
}

/// <summary>iOS-style toggle switch in Haltech yellow.</summary>
internal sealed class ToggleSwitch : Control
{
    private bool _on = true;
    public bool On
    {
        get => _on;
        set { _on = value; Invalidate(); OnToggled(EventArgs.Empty); }
    }

    public event EventHandler? Toggled;
    private void OnToggled(EventArgs e) => Toggled?.Invoke(this, e);

    public ToggleSwitch()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
        Size = new Size(46, 24);
        Cursor = Cursors.Hand;
    }

    protected override void OnClick(EventArgs e) { On = !On; base.OnClick(e); }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        var track = new Rectangle(0, (Height - 22) / 2, 46, 22);
        Theme.FillRounded(g, track, 11, _on ? Theme.Yellow : Theme.Line);

        int knob = 18;
        int x = _on ? track.Right - knob - 2 : track.Left + 2;
        var knobRect = new Rectangle(x, track.Top + 2, knob, knob);
        using var b = new SolidBrush(_on ? Theme.Ink : Theme.TextDim);
        g.FillEllipse(b, knobRect);
    }
}
