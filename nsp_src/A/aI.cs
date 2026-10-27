using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;

namespace a;

internal class aI : UserControl
{
	private int Is;

	private Framework IT;

	[CompilerGenerated]
	private EventHandler It;

	private IContainer IU;

	private ThemedButton Iu;

	private Label IV;

	private TableLayoutPanel Iv;

	public aI()
	{
		B();
		A();
	}

	[SpecialName]
	internal void A(Framework P_0)
	{
		IT = P_0;
		if (IT != null && !IT.C())
		{
			((Control)this).Enabled = false;
		}
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((Control)this).OnEnabledChanged(e);
		A();
	}

	internal void A()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).Enabled)
		{
			if (IT != null)
			{
				Setting setting = IT.A(Is);
				if (setting == null || !((SettingOrSpecialObject)setting).l() || !PortFunction.A(setting))
				{
					((Control)IV).BackColor = Color.Red;
				}
				else
				{
					((Control)IV).BackColor = BM.to;
				}
			}
			else
			{
				((Control)IV).BackColor = BM.to;
			}
			((Control)IV).ForeColor = BM.te;
		}
		else
		{
			((Control)IV).BackColor = BM.tQ;
			((Control)IV).ForeColor = BM.tq;
		}
	}

	private void A(object P_0, PaintEventArgs P_1)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)IV).Enabled)
		{
			TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, ((Control)IV).Text, ((Control)IV).Font, new Point(0, 3), BM.tq, BM.tQ);
		}
	}

	[SpecialName]
	internal void A(int P_0)
	{
		if (Is == P_0)
		{
			return;
		}
		Is = P_0;
		if (Is != 0)
		{
			Setting setting = IT.A(Is);
			if (setting != null)
			{
				string text = ((SettingOrSpecialObject)setting).H();
				if (!string.IsNullOrWhiteSpace(text))
				{
					((Control)IV).Text = text;
				}
				else
				{
					string text2 = ((SettingOrSpecialObject)setting).A(bz.aYt);
					if (text2.Length <= 25)
					{
						((Control)IV).Text = text2;
					}
					else
					{
						((Control)IV).Text = ((SettingOrSpecialObject)setting).A(bz.aYT);
					}
				}
			}
			else
			{
				((Control)IV).Text = string.Empty;
			}
		}
		else
		{
			((Control)IV).Text = string.Empty;
		}
		A();
	}

	[SpecialName]
	internal int a()
	{
		return Is;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = It;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref It, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = It;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref It, val3, val2);
		}
		while (val != val2);
	}

	private void A(object P_0, EventArgs P_1)
	{
		int num = Bx.A((IWin32Window)(object)((ContainerControl)this).ParentForm, IT, Is);
		if (num != 0)
		{
			A(num);
			if (It != null)
			{
				It.Invoke((object)this, (EventArgs)null);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && IU != null)
		{
			((System.IDisposable)IU).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void B()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		ComponentResourceManager val = new ComponentResourceManager(typeof(aI));
		IV = new Label();
		Iv = new TableLayoutPanel();
		Iu = new ThemedButton();
		((Control)Iv).SuspendLayout();
		((Control)this).SuspendLayout();
		val.ApplyResources((object)IV, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fq());
		((Control)IV).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)IV).BackColor = SystemColors.Window;
		IV.BorderStyle = (BorderStyle)1;
		((Control)IV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fq();
		((Control)IV).Click += new EventHandler(A);
		((Control)IV).Paint += new PaintEventHandler(A);
		val.ApplyResources((object)Iv, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CU());
		Iv.Controls.Add((Control)(object)IV, 0, 0);
		Iv.Controls.Add((Control)(object)Iu, 1, 0);
		((Control)Iv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CU();
		val.ApplyResources((object)Iu, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fR());
		((Control)Iu).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Iu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fR();
		((ButtonBase)Iu).UseVisualStyleBackColor = true;
		((Control)Iu).Click += new EventHandler(A);
		val.ApplyResources((object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fr());
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)Iv);
		((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fS();
		((Control)Iv).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
internal class ai : UserControl
{
	private delegate void A(object P_0, EventArgs P_1);

	private Framework IW;

	private SettingOrSpecialObject Iw;

	private ThemedButton IX = new ThemedButton();

	internal ai(SettingOrSpecialObject P_0, Framework P_1)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		IW = P_1;
		Iw = P_0;
		Iw.A(new EventHandler(A));
		string text = Iw.A(bz.aYu);
		if (text != null)
		{
			((Control)IX).Text = text;
		}
		((Control)IX).Left = 0;
		((Control)IX).Top = 0;
		((Control)IX).AutoSize = true;
		((Control)IX).Click += new EventHandler(a);
		A();
		((Control)this).Controls.Add((Control)(object)IX);
		((Control)this).AutoSize = false;
		((Control)this).Height = ((Control)IX).Height;
		((Control)this).Width = ((Control)IX).Width;
	}

	private void A()
	{
		((Control)IX).Enabled = Iw.l() && IW.C();
		((Control)this).TabStop = ((Control)IX).Enabled;
		((Control)IX).TabStop = ((Control)this).TabStop;
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
			Iw.a(new EventHandler(A));
			((ContainerControl)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		Iw.j();
	}
}
