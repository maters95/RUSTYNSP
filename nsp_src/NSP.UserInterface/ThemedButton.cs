using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using B;

namespace NSP.UserInterface;

public class ThemedButton : Button
{
	private bool jb;

	protected override void OnMouseEnter(EventArgs e)
	{
		((Button)this).OnMouseEnter(e);
		jb = true;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Button)this).OnMouseLeave(e);
		jb = false;
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
		{
			try
			{
				((ButtonBase)this).OnPaint(e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (((Control)this).Parent != null)
		{
			SolidBrush val = new SolidBrush(((Control)this).Parent.BackColor);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).Width, ((Control)this).Height);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		e.Graphics.SmoothingMode = (SmoothingMode)2;
		Rectangle displayRectangle = ((Control)this).DisplayRectangle;
		int num = ((Rectangle)(ref displayRectangle)).Width - 2;
		displayRectangle = ((Control)this).DisplayRectangle;
		Rectangle val2 = default(Rectangle);
		((Rectangle)(ref val2))._002Ector(1, 1, num, ((Rectangle)(ref displayRectangle)).Height - 2);
		if (((Control)this).Focused)
		{
			GraphicsPath val3 = A(val2, 2);
			try
			{
				e.Graphics.FillPath(Brushes.DodgerBlue, val3);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		else
		{
			GraphicsPath val4 = A(val2, 2);
			try
			{
				SolidBrush val5 = new SolidBrush(BM.tP);
				try
				{
					e.Graphics.FillPath((Brush)(object)val5, val4);
				}
				finally
				{
					((System.IDisposable)val5)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
		}
		GraphicsPath val6 = A(val2, 2);
		try
		{
			if (jb)
			{
				e.Graphics.DrawPath(Pens.DodgerBlue, val6);
			}
			else
			{
				Pen val7 = new Pen(BM.tp, 1f);
				try
				{
					e.Graphics.DrawPath(val7, val6);
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)val6)?.Dispose();
		}
		if (((ButtonBase)this).Image != null)
		{
			try
			{
				e.Graphics.DrawImage(((ButtonBase)this).Image, ((Control)this).Width / 2 - ((ButtonBase)this).Image.Width / 2, ((Control)this).Height / 2 - ((ButtonBase)this).Image.Height / 2);
			}
			catch
			{
			}
			if (!((Control)this).Enabled)
			{
				SolidBrush val8 = new SolidBrush(Color.FromArgb(120, 0, 0, 0));
				try
				{
					e.Graphics.FillRectangle((Brush)(object)val8, val2);
					return;
				}
				finally
				{
					((System.IDisposable)val8)?.Dispose();
				}
			}
			return;
		}
		displayRectangle = ((Control)this).DisplayRectangle;
		int num2 = ((Rectangle)(ref displayRectangle)).Width - 6;
		displayRectangle = ((Control)this).DisplayRectangle;
		Rectangle val9 = default(Rectangle);
		((Rectangle)(ref val9))._002Ector(3, 3, num2, ((Rectangle)(ref displayRectangle)).Height - 6);
		if (((Control)this).Enabled)
		{
			if (((Control)this).ForeColor == Color.Red || ((Control)this).ForeColor == BM.tC)
			{
				TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, ((Control)this).Text, ((Control)this).Font, val9, ((Control)this).ForeColor, (TextFormatFlags)2069);
			}
			else
			{
				TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, ((Control)this).Text, ((Control)this).Font, val9, BM.te, (TextFormatFlags)2069);
			}
		}
		else
		{
			TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, ((Control)this).Text, ((Control)this).Font, val9, BM.tq, (TextFormatFlags)2069);
		}
	}

	internal static GraphicsPath A(Rectangle P_0, int P_1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		int num = P_1 * 2;
		Size val = default(Size);
		((Size)(ref val))._002Ector(num, num);
		Rectangle val2 = default(Rectangle);
		((Rectangle)(ref val2))._002Ector(((Rectangle)(ref P_0)).Location, val);
		GraphicsPath val3 = new GraphicsPath();
		if (P_1 == 0)
		{
			val3.AddRectangle(P_0);
			return val3;
		}
		val3.AddArc(val2, 180f, 90f);
		((Rectangle)(ref val2)).X = ((Rectangle)(ref P_0)).Right - num;
		val3.AddArc(val2, 270f, 90f);
		((Rectangle)(ref val2)).Y = ((Rectangle)(ref P_0)).Bottom - num;
		val3.AddArc(val2, 0f, 90f);
		((Rectangle)(ref val2)).X = ((Rectangle)(ref P_0)).Left;
		val3.AddArc(val2, 90f, 90f);
		val3.CloseFigure();
		return val3;
	}
}
