using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns2;

internal class Class138 : SplitContainer
{
	public Class138()
	{
		DoubleBuffered = true;
		ResizeRedraw = true;
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		using Brush brush = new SolidBrush(Form23.color_10);
		paintEventArgs_0.Graphics.FillRectangle(brush, SplitterRectangle);
	}
}
