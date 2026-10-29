namespace NexmapUnlock;

internal static class AppBrand
{
    public static Image Logo { get; } = LoadLogo();
    public static Icon Icon { get; } = LoadIcon();

    private static Image LoadLogo()
    {
        using var stream = typeof(AppBrand).Assembly.GetManifestResourceStream("NexmapUnlock.Assets.logo.png")
            ?? throw new InvalidOperationException("The app logo resource is missing.");
        using var image = Image.FromStream(stream);
        return new Bitmap(image);
    }

    private static Icon LoadIcon()
    {
        using var stream = typeof(AppBrand).Assembly.GetManifestResourceStream("NexmapUnlock.Assets.app.ico")
            ?? throw new InvalidOperationException("The app icon resource is missing.");
        using var icon = new Icon(stream);
        return (Icon)icon.Clone();
    }
}
