using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using B;

namespace NSP.UserInterface;

public class ThemedComboBox : ComboBox
{
	private ThemedTextBox jf = new ThemedTextBox();

	public ThemedComboBox()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		((Control)jf).Visible = true;
		((Control)jf).TextChanged += new EventHandler(A);
		((Control)jf).MouseEnter += new EventHandler(a);
		((Control)jf).Leave += new EventHandler(B);
		((Control)jf).KeyDown += new KeyEventHandler(A);
		((Control)jf).KeyPress += new KeyPressEventHandler(A);
		((Control)jf).GotFocus += new EventHandler(b);
		((Control)this).MouseWheel += new MouseEventHandler(A);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).DoubleBuffered = true;
		((ComboBox)this).DrawMode = (DrawMode)1;
		((Control)this).BackColor = BM.to;
		((Control)this).ForeColor = BM.te;
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!((ComboBox)this).DroppedDown)
		{
			((HandledMouseEventArgs)P_1).Handled = true;
		}
	}

	protected override void OnDropDownStyleChanged(EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		((ComboBox)this).OnDropDownStyleChanged(e);
		if ((int)((ComboBox)this).DropDownStyle == 2)
		{
			((Control)jf).Visible = false;
		}
		else
		{
			((Control)jf).Visible = ((Control)this).Visible;
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		((Control)this).OnVisibleChanged(e);
		if (((Control)this).Visible)
		{
			((Control)jf).Visible = (int)((ComboBox)this).DropDownStyle != 2;
		}
		else
		{
			((Control)jf).Visible = false;
		}
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((Control)this).OnEnabledChanged(e);
		((Control)jf).Enabled = ((Control)this).Enabled;
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
		((Control)jf).Height = ((Control)this).Height;
		((Control)jf).Width = ((Control)this).Width - 19;
	}

	protected override void OnLocationChanged(EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnLocationChanged(e);
		((Control)jf).Location = ((Control)this).Location;
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		((ComboBox)this).OnForeColorChanged(e);
		((Control)jf).ForeColor = ((Control)this).ForeColor;
	}

	protected override void OnBackColorChanged(EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		((ComboBox)this).OnBackColorChanged(e);
		((Control)jf).BackColor = ((Control)this).BackColor;
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((ComboBox)this).OnFontChanged(e);
		((Control)jf).Font = ((Control)this).Font;
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
		((ComboBox)this).OnSelectedIndexChanged(e);
		if (((ComboBox)this).Items.Count != 0 && ((ListControl)this).SelectedIndex >= 0)
		{
			string text = ((((ComboBox)this).DataSource == null) ? ((string)((ComboBox)this).Items[((ListControl)this).SelectedIndex]) : ((ListControl)this).GetItemText(((ComboBox)this).Items[((ListControl)this).SelectedIndex]));
			((Control)jf).Text = text;
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((ComboBox)this).OnTextChanged(e);
		((Control)jf).Text = ((Control)this).Text;
	}

	private void A(object P_0, EventArgs P_1)
	{
		((Control)this).Text = ((Control)jf).Text;
	}

	private void a(object P_0, EventArgs P_1)
	{
		((Control)this).OnMouseEnter(P_1);
	}

	private void B(object P_0, EventArgs P_1)
	{
		((Control)this).OnLeave(P_1);
	}

	private void A(object P_0, KeyEventArgs P_1)
	{
		((Control)this).OnKeyDown(P_1);
	}

	private void A(object P_0, KeyPressEventArgs P_1)
	{
		((Control)this).OnKeyPress(P_1);
	}

	private void b(object P_0, EventArgs P_1)
	{
		((TextBoxBase)jf).SelectAll();
	}

	protected override void Dispose(bool disposing)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		try
		{
			((Control)jf).TextChanged -= new EventHandler(A);
			((Control)jf).MouseEnter -= new EventHandler(a);
			((Control)jf).Leave -= new EventHandler(B);
			((Control)jf).KeyDown -= new KeyEventHandler(A);
			((Control)jf).KeyPress -= new KeyPressEventHandler(A);
			((Control)jf).GotFocus -= new EventHandler(b);
			((Control)this).MouseWheel -= new MouseEventHandler(A);
			((Component)jf).Dispose();
			((ComboBox)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		SolidBrush val = new SolidBrush(BM.to);
		try
		{
			e.Graphics.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).Width, ((Control)this).Height);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
		Pen val2 = new Pen(Brushes.Gray, 1f);
		try
		{
			e.Graphics.DrawRectangle(val2, 0, 0, ((Control)this).Width - 1, ((Control)this).Height - 3);
			e.Graphics.DrawLine(val2, ((Control)this).Width - 20, 0, ((Control)this).Width - 20, ((Control)this).Height - 3);
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
		Color backColor = ((Control)this).BackColor;
		if (!((Control)this).Enabled && ((Control)this).BackColor != BM.tD)
		{
			SolidBrush val3 = new SolidBrush(BM.tQ);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val3, 2, 2, ((Control)this).Width - 22, ((Control)this).Height - 5);
				backColor = BM.tQ;
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		else if (((Control)this).Focused)
		{
			SolidBrush val4 = new SolidBrush(Color.DodgerBlue);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val4, 3, 3, ((Control)this).Width - 23, ((Control)this).Height - 6);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
		}
		else if (((Control)this).BackColor != BM.to)
		{
			SolidBrush val5 = new SolidBrush(((Control)this).BackColor);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val5, 3, 3, ((Control)this).Width - 23, ((Control)this).Height - 6);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
		}
		e.Graphics.SmoothingMode = (SmoothingMode)2;
		Point[] array = (Point[])(object)new Point[3]
		{
			new Point(((Control)this).Width - 18 + 8, 13),
			new Point(((Control)this).Width - 18 + 2, 6),
			new Point(((Control)this).Width - 18 + 13, 6)
		};
		if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
		{
			e.Graphics.FillPolygon(Brushes.Gray, array);
		}
		else
		{
			SolidBrush val6 = new SolidBrush(BM.tM);
			try
			{
				e.Graphics.FillPolygon((Brush)(object)val6, array);
			}
			finally
			{
				((System.IDisposable)val6)?.Dispose();
			}
		}
		Color foreColor = BM.te;
		if (((ListControl)this).SelectedIndex >= 0)
		{
			Rectangle val7 = default(Rectangle);
			((Rectangle)(ref val7))._002Ector(3, 3, ((Control)this).Width - 23, ((Control)this).Height - 6);
			string text = ((((ComboBox)this).DataSource == null) ? ((string)((ComboBox)this).Items[((ListControl)this).SelectedIndex]) : ((ListControl)this).GetItemText(((ComboBox)this).Items[((ListControl)this).SelectedIndex]));
			if (!((Control)this).Enabled)
			{
				TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, text, ((Control)this).Font, val7, BM.tq, (TextFormatFlags)2048);
				foreColor = BM.tq;
			}
			else
			{
				TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, text, ((Control)this).Font, val7, BM.te, (TextFormatFlags)2048);
			}
		}
		if (((Control)this).Parent != null && !(((Control)this).Parent is ToolStrip))
		{
			if (!((Control)this).Parent.Controls.Contains((Control)(object)jf))
			{
				((Control)this).Parent.Controls.Add((Control)(object)jf);
				((Control)jf).BringToFront();
			}
			if (((Control)jf).Visible)
			{
				((Control)jf).BackColor = backColor;
				((Control)jf).ForeColor = foreColor;
				((Control)jf).Invalidate();
			}
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
		{
			e.DrawBackground();
		}
		else if ((e.State & 0x10) != 0 || (e.State & 0x40) != 0)
		{
			SolidBrush val = new SolidBrush(Color.DodgerBlue);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val, e.Bounds);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		else
		{
			SolidBrush val2 = new SolidBrush(BM.to);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val2, e.Bounds);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		if (e.Index >= 0)
		{
			string text = ((((ComboBox)this).DataSource == null) ? ((string)((ComboBox)this).Items[e.Index]) : ((ListControl)this).GetItemText(((ComboBox)this).Items[e.Index]));
			TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, text, ((Control)this).Font, e.Bounds, BM.te, (TextFormatFlags)2048);
		}
		e.DrawFocusRectangle();
		((ComboBox)this).OnDrawItem(e);
	}

	internal void A()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		foreach (object item in ((ComboBox)this).Items)
		{
			Size val = TextRenderer.MeasureText(item.ToString(), ((Control)this).Font);
			int width = ((Size)(ref val)).Width;
			if (width > num)
			{
				num = width;
			}
		}
		num += 4;
		num += 20;
		((Control)this).Width = num;
		((Control)this).Refresh();
	}
}
