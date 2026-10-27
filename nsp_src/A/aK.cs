using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using B;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;

namespace a;

internal class aK : UserControl
{
	private delegate void A(object P_0, EventArgs P_1);

	private Framework ig;

	private SettingOrSpecialObject iH;

	private SettingWriteTaskObject ih;

	private ThemedButton iI = new ThemedButton();

	internal aK(SettingOrSpecialObject P_0, SettingWriteTaskObject P_1, Framework P_2)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		iH = P_0;
		ih = P_1;
		ig = P_2;
		iH.A(new EventHandler(A));
		string text = iH.A(bz.aYu);
		if (text != null)
		{
			((Control)iI).Text = text;
		}
		((Control)iI).Left = 0;
		((Control)iI).Top = 0;
		((Control)iI).AutoSize = true;
		((Control)iI).Click += new EventHandler(a);
		A();
		((Control)this).Controls.Add((Control)(object)iI);
		((Control)this).AutoSize = false;
		((Control)this).Height = ((Control)iI).Height;
		((Control)this).Width = ((Control)iI).Width;
	}

	private void A()
	{
		((Control)iI).Enabled = iH.l() && ig.C();
		((Control)this).TabStop = ((Control)iI).Enabled;
		((Control)iI).TabStop = ((Control)this).TabStop;
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = A;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		A();
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		try
		{
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Button)
				{
					((val is Button) ? val : null).Click -= new EventHandler(a);
				}
			}
			iH.a(new EventHandler(A));
			((ContainerControl)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		ih.B();
	}
}
internal class ak : SplitContainer
{
	public ak()
	{
		((Control)this).DoubleBuffered = true;
		((Control)this).ResizeRedraw = true;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		((SplitContainer)this).OnPaint(e);
		Brush val = (Brush)new SolidBrush(BM.td);
		try
		{
			e.Graphics.FillRectangle(val, ((SplitContainer)this).SplitterRectangle);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}
}
