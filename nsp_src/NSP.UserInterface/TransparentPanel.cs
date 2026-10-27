using System;
using System.Drawing;
using System.Windows.Forms;

namespace NSP.UserInterface;

public class TransparentPanel : Panel
{
	private int ko;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Panel)this).CreateParams;
			createParams.ExStyle |= 0x20;
			return createParams;
		}
	}

	public TransparentPanel()
	{
		((Control)this).SetStyle((ControlStyles)2048, true);
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		SolidBrush val = new SolidBrush(Color.FromArgb(ko * 255 / 100, ((Control)this).BackColor));
		try
		{
			e.Graphics.FillRectangle((Brush)(object)val, ((Control)this).ClientRectangle);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
		((Control)this).OnPaint(e);
	}

	public void setOpacity(int val)
	{
		ko = val;
	}

	public void setStyle(ControlStyles c)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle(c, true);
	}
}
