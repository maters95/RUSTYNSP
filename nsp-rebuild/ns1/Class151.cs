using System.Drawing;
using System.Windows.Forms;
using NSP.UserInterface;

namespace ns1;

internal class Class151 : ThemedComboBox
{
	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (SelectedIndex >= 0)
		{
			using SolidBrush brush = new SolidBrush(Class105.BKu[SelectedIndex]);
			paintEventArgs_0.Graphics.FillRectangle(brush, paintEventArgs_0.ClipRectangle);
		}
		using Pen pen = new Pen(Brushes.Black, 1f);
		paintEventArgs_0.Graphics.DrawRectangle(pen, paintEventArgs_0.ClipRectangle.X, paintEventArgs_0.ClipRectangle.Y, paintEventArgs_0.ClipRectangle.Width - 1, paintEventArgs_0.ClipRectangle.Height - 1);
	}
}
