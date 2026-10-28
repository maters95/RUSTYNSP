namespace NexmapUnlock;

internal static class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();

        // Allow "open with" / command-line usage: unlock each path in place next to the original.
        if (args.Length > 0)
        {
            foreach (string path in args)
            {
                try
                {
                    if (File.Exists(path))
                    {
                        string outPath = MainForm.BuildOutputPath(path);
                        NexmapUnlocker.Unlock(path, outPath);
                    }
                }
                catch
                {
                    // Fall through to GUI so the user sees the error there.
                    Application.Run(new MainForm(args));
                    return;
                }
            }
        }

        Application.Run(new MainForm(args));
    }
}
