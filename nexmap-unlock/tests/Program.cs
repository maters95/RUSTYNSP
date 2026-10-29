using NexmapUnlock;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        foreach (float scale in new[] { 1f, 1.5f, 2f })
        {
            using var form = new MainForm();
            form.Show();
            if (scale != 1f)
                form.Scale(new SizeF(scale, scale));

            var minimum = form.MinimumSize;
            foreach (var size in new[] { form.Size, minimum, new Size(minimum.Width * 2, minimum.Height * 2) })
            {
                form.Size = size;
                form.PerformLayout();
                Application.DoEvents();
                CheckLayout(form);
                using var bitmap = new Bitmap(form.Width, form.Height);
                form.DrawToBitmap(bitmap, form.ClientRectangle);
            }

            var controls = Descendants(form).ToArray();
            var min = controls.OfType<Button>().Single(c => c.AccessibleName == "Minimise");
            min.PerformClick();
            Require(form.WindowState == FormWindowState.Minimized, "Minimise did not minimise the window.");
            form.WindowState = FormWindowState.Normal;

            var toggle = controls.Single(c => c.GetType().Name == "ToggleSwitch");
            var on = toggle.GetType().GetProperty("On")!;
            Require(on.GetValue(toggle) is true, "Saving a copy must remain the default.");
            on.SetValue(toggle, false);
            Require(controls.Any(c => c.Text == "Overwrite the original file"), "Overwrite label did not update.");
            on.SetValue(toggle, true);
            Require(controls.Any(c => c.Text.Contains("(unlocked)")), "Copy label did not update.");

            controls.OfType<Button>().Single(c => c.AccessibleName == "Close").PerformClick();
            Require(form.IsDisposed, "Close did not close the window.");
        }
        Console.WriteLine("PASS: layout, painting, title-bar buttons, logo, and copy toggle.");
    }

    private static void CheckLayout(MainForm form)
    {
        var controls = Descendants(form).ToArray();
        foreach (var control in controls)
        {
            Require(control.Width > 0 && control.Height > 0, $"Empty control: {control.GetType().Name}");
            Require(control.Parent!.ClientRectangle.Contains(control.Bounds),
                $"Clipped control: {control.GetType().Name} ({control.Text})");
            Require(!control.Text.Contains('\u2014'), "An em dash is displayed in the UI.");
            if (control is Label label)
            {
                var required = TextRenderer.MeasureText(label.Text, label.Font);
                Require(required.Width <= label.Width && required.Height <= label.Height,
                    $"Clipped label: {label.Text}");
            }
        }

        var min = controls.Single(c => c.AccessibleName == "Minimise");
        var close = controls.Single(c => c.AccessibleName == "Close");
        Require(min.Parent == close.Parent && min.Right == close.Left, "Window buttons are in the wrong order.");
        Require(close.Right == close.Parent!.ClientSize.Width, "Close must be the rightmost window button.");
        Require(form.Icon is not null, "Window icon is missing.");
        Require(controls.OfType<PictureBox>().Single().Image?.Size == new Size(256, 256), "App logo is missing.");

        var drop = controls.Single(c => c.GetType().Name == "DropZone");
        var log = controls.OfType<RichTextBox>().Single();
        Require(drop.Left == log.Left && drop.Width == log.Width, "Drop zone and log must align.");
    }

    private static IEnumerable<Control> Descendants(Control parent)
    {
        foreach (Control child in parent.Controls)
        {
            yield return child;
            foreach (var descendant in Descendants(child))
                yield return descendant;
        }
    }

    private static void Require(bool condition, string message)
    {
        if (!condition)
            throw new InvalidOperationException(message);
    }
}
