using System.Drawing;
using System.Windows.Forms;

namespace NSP.UserInterface;

public class TransparentPanel : Panel
{
	private int int_0;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.ExStyle |= 32;
			return createParams;
		}
	}

	public TransparentPanel()
	{
		SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
	}

	protected override void OnPaintBackground(PaintEventArgs paintEventArgs_0)
	{
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		using (SolidBrush brush = new SolidBrush(Color.FromArgb(int_0 * 255 / 100, BackColor)))
		{
			paintEventArgs_0.Graphics.FillRectangle(brush, ClientRectangle);
		}
		base.OnPaint(paintEventArgs_0);
	}

	public void setOpacity(int val)
	{
		int_0 = val;
	}

	public void setStyle(ControlStyles controlStyles_0)
	{
		SetStyle(controlStyles_0, value: true);
	}
}
