using System.Drawing.Drawing2D;

namespace NexmapUnlock;

/// <summary>Haltech-style palette and drawing helpers.</summary>
internal static class Theme
{
    // Haltech brand palette (sampled from NSP / stock-dash resources).
    public static readonly Color Yellow = Color.FromArgb(0xFF, 0xCB, 0x31);
    public static readonly Color YellowBright = Color.FromArgb(0xFF, 0xD8, 0x62);
    public static readonly Color YellowDim = Color.FromArgb(0xA4, 0x7B, 0x00);

    public static readonly Color Ink = Color.FromArgb(0x16, 0x14, 0x12); // near-black chrome
    public static readonly Color Charcoal = Color.FromArgb(0x1E, 0x1B, 0x18); // window body
    public static readonly Color Panel = Color.FromArgb(0x2A, 0x26, 0x22); // raised panels
    public static readonly Color PanelHi = Color.FromArgb(0x33, 0x2F, 0x2A);
    public static readonly Color Line = Color.FromArgb(0x3C, 0x37, 0x31);

    public static readonly Color Text = Color.FromArgb(0xF2, 0xEF, 0xEA);
    public static readonly Color TextDim = Color.FromArgb(0x9A, 0x92, 0x88);

    public static readonly Color Good = Color.FromArgb(0x37, 0xB3, 0x49);
    public static readonly Color Bad = Color.FromArgb(0xFF, 0x2F, 0x2F);

    public static GraphicsPath RoundedRect(Rectangle r, int radius)
    {
        int d = radius * 2;
        var path = new GraphicsPath();
        if (radius <= 0)
        {
            path.AddRectangle(r);
            path.CloseFigure();
            return path;
        }
        path.AddArc(r.X, r.Y, d, d, 180, 90);
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }

    public static void FillRounded(Graphics g, Rectangle r, int radius, Color color)
    {
        using var path = RoundedRect(r, radius);
        using var brush = new SolidBrush(color);
        g.FillPath(brush, path);
    }
}
