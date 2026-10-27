using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.SettingsFramework;

namespace a;

internal class aF : Panel
{
	private delegate void A();

	[CompilerGenerated]
	private bool hE = true;

	private aQ he = new aQ();

	private aR hF = new aR();

	private Panel hf = new Panel();

	[SpecialName]
	[CompilerGenerated]
	internal bool A()
	{
		return hE;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(bool P_0)
	{
		hE = P_0;
	}

	internal aF()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		((ScrollableControl)this).AutoScroll = true;
		((Control)this).MouseWheel += new MouseEventHandler(A);
		((Control)this).VisibleChanged += new EventHandler(B);
		((Control)this).Layout += new LayoutEventHandler(A);
		_ = ((Control)he).Handle;
		_ = ((Control)hF).Handle;
		_ = ((Control)hf).Handle;
		_ = ((Control)this).Handle;
	}

	[DllImport("user32.dll", EntryPoint = "GetKeyState")]
	public static extern short A(Keys P_0);

	protected override Point ScrollToControl(Control activeControl)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (A() || ((uint)A((Keys)9) & 0x8000u) != 0)
		{
			return ((ScrollableControl)this).ScrollToControl(activeControl);
		}
		return ((ScrollableControl)this).AutoScrollPosition;
	}

	internal void a()
	{
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = this.a;
				((Control)this).Invoke((System.Delegate)a);
				return;
			}
			catch
			{
				return;
			}
		}
		Control parent = ((Control)this).Parent;
		int num = ((Control)this).Left;
		int num2 = ((Control)this).Top;
		while (parent != null && (parent is FlowLayoutPanel || parent is TableLayoutPanel))
		{
			num += parent.Left;
			num2 += parent.Top;
			parent = parent.Parent;
		}
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			bool visible = ((ScrollProperties)((ScrollableControl)this).HorizontalScroll).Visible;
			bool visible2 = ((ScrollProperties)((ScrollableControl)this).VerticalScroll).Visible;
			Point autoScrollPosition;
			if (visible)
			{
				int num3 = 0;
				try
				{
					foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
					{
						Control val = item;
						int num4 = num3;
						int right = val.Right;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						num3 = Math.Max(num4, right - ((Point)(ref autoScrollPosition)).X);
					}
				}
				catch
				{
				}
				try
				{
					if (!((Control)he).IsDisposed && !((Control)he).Disposing)
					{
						((Control)he).Visible = ((Control)this).Visible;
						((Control)he).Left = num;
						((Control)he).Top = num2 + (((Control)this).Height - ((Control)he).Height) - 1;
						((Control)he).Width = (visible2 ? (((Control)this).Width - ((Control)hF).Width) : ((Control)this).Width);
						he.a(new EventHandler(A));
						he.A(new EventHandler(A));
						he.B(0);
						he.a(((Control)this).Width / 40);
						he.A((int)((float)((Control)this).Width / 3f));
						he.b(num3 - ((Control)this).Width + he.A());
						if (visible2)
						{
							aQ obj3 = he;
							obj3.b(obj3.b() + ((Control)hF).Width);
						}
						aQ obj4 = he;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						obj4.C(-((Point)(ref autoScrollPosition)).X);
						if (parent != null && !parent.Controls.Contains((Control)(object)he))
						{
							parent.Controls.Add((Control)(object)he);
						}
						((Control)he).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)he).IsDisposed && !((Control)he).Disposing)
			{
				try
				{
					((Control)he).Visible = false;
				}
				catch
				{
				}
			}
			if (visible2)
			{
				int num5 = 0;
				try
				{
					foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
					{
						Control val2 = item2;
						int num6 = num5;
						int bottom = val2.Bottom;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						num5 = Math.Max(num6, bottom - ((Point)(ref autoScrollPosition)).Y);
					}
				}
				catch
				{
				}
				try
				{
					if (!((Control)hF).IsDisposed && !((Control)hF).Disposing)
					{
						((Control)hF).Visible = ((Control)this).Visible;
						((Control)hF).Left = num + (((Control)this).Width - ((Control)hF).Width) - 1;
						((Control)hF).Top = num2;
						((Control)hF).Height = (visible ? (((Control)this).Height - ((Control)he).Height) : ((Control)this).Height);
						hF.a(new EventHandler(this.a));
						hF.A(new EventHandler(this.a));
						hF.B(0);
						hF.a(((Control)this).Height / 40);
						hF.A((int)((float)((Control)this).Height / 3f));
						hF.b(num5 - ((Control)this).Height + hF.A());
						if (visible)
						{
							aR obj8 = hF;
							obj8.b(obj8.b() + ((Control)he).Height);
						}
						aR obj9 = hF;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						obj9.C(-((Point)(ref autoScrollPosition)).Y);
						if (parent != null && !parent.Controls.Contains((Control)(object)hF))
						{
							parent.Controls.Add((Control)(object)hF);
						}
						((Control)hF).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)hF).IsDisposed && !((Control)hF).Disposing)
			{
				try
				{
					((Control)hF).Visible = false;
				}
				catch
				{
				}
			}
			if (visible && visible2)
			{
				try
				{
					if (!((Control)hf).IsDisposed && !((Control)hf).Disposing)
					{
						((Control)hf).Visible = ((Control)this).Visible;
						hf.BorderStyle = (BorderStyle)0;
						((Control)hf).BackColor = BM.tl;
						((Control)hf).Size = new Size(((Control)hF).Width - 1, ((Control)he).Height - 1);
						((Control)hf).Left = ((Control)he).Right;
						((Control)hf).Top = ((Control)hF).Bottom;
						if (parent != null && !parent.Controls.Contains((Control)(object)hf))
						{
							parent.Controls.Add((Control)(object)hf);
						}
						((Control)hf).BringToFront();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			if (!((Control)hf).IsDisposed && !((Control)hf).Disposing)
			{
				try
				{
					((Control)hf).Visible = false;
					return;
				}
				catch
				{
					return;
				}
			}
			return;
		}
		if (!((Control)he).IsDisposed && !((Control)he).Disposing)
		{
			try
			{
				((Control)he).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)he))
				{
					parent.Controls.Remove((Control)(object)he);
				}
			}
			catch
			{
			}
		}
		if (!((Control)hF).IsDisposed && !((Control)hF).Disposing)
		{
			try
			{
				((Control)hF).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)hF))
				{
					parent.Controls.Remove((Control)(object)hF);
				}
			}
			catch
			{
			}
		}
		if (((Control)hf).IsDisposed || ((Control)hf).Disposing)
		{
			return;
		}
		try
		{
			((Control)hf).Visible = false;
		}
		catch
		{
		}
		try
		{
			if (parent != null && parent.Controls.Contains((Control)(object)hf))
			{
				parent.Controls.Remove((Control)(object)hf);
			}
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		try
		{
			((Control)this).MouseWheel -= new MouseEventHandler(A);
			((Control)this).VisibleChanged -= new EventHandler(B);
			((Control)this).Layout -= new LayoutEventHandler(A);
		}
		catch
		{
		}
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			try
			{
				he.a(new EventHandler(A));
				hF.a(new EventHandler(a));
			}
			catch
			{
			}
			try
			{
				((Component)hF).Dispose();
			}
			catch
			{
			}
			try
			{
				((Component)he).Dispose();
			}
			catch
			{
			}
		}
		try
		{
			((Control)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((ScrollableControl)this).AutoScrollPosition = new Point(he.C(), ((Control)hF).Visible ? hF.C() : 0);
		((Control)he).Invalidate();
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((ScrollableControl)this).AutoScrollPosition = new Point(((Control)he).Visible ? he.C() : 0, hF.C());
		((Control)hF).Invalidate();
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		a();
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (!((Control)this).Visible)
		{
			((Control)he).Visible = false;
			((Control)hF).Visible = false;
			((Control)hf).Visible = false;
		}
		else
		{
			a();
		}
	}

	private void A(object P_0, LayoutEventArgs P_1)
	{
		a();
	}
}
internal class af : UserControl
{
	private delegate void A(object P_0, EventArgs P_1);

	private delegate void a(object P_0, EventArgs P_1);

	private delegate void B(object P_0, EventArgs P_1);

	private MenuNode hG;

	private Setting hg;

	private string hH;

	private List<ValueTuple<CO, string>> hh;

	private aH hI = new aH();

	private bool hi;

	private bool hJ;

	[CompilerGenerated]
	private EventHandler hj;

	private IContainer hK;

	public af()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		c();
		((Control)hI).Left = 0;
		((Control)hI).Top = 0;
		((Control)this).Controls.Add((Control)(object)hI);
		hI.A(new EventHandler(b));
	}

	[SpecialName]
	internal MenuNode A()
	{
		return hG;
	}

	internal void A(MenuNode P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		((Control)hI).BackColor = BM.to;
		hG = P_0;
		hg = hG.a().A(hG.W());
		a();
		hI.A();
		((Control)this).Width = ((Control)hI).Width;
		((Control)this).Height = ((Control)hI).Height;
		((Control)this).Visible = ((SettingOrSpecialObject)hg).l();
		hg.a(new EventHandler(a));
		hg.A(new EventHandler(a));
		((SettingOrSpecialObject)hg).a(new EventHandler(B));
		((SettingOrSpecialObject)hg).A(new EventHandler(B));
		BM.f(new EventHandler(A));
		BM.F(new EventHandler(A));
	}

	private void a()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		hh = Cn.A(hG, hg, false);
		hI.B();
		Bitmap val = new Bitmap(140, 140);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			Font val3 = new Font(((Control)this).Font.FontFamily, 20f);
			try
			{
				SolidBrush val4 = new SolidBrush(BM.te);
				try
				{
					StringFormat val5 = new StringFormat();
					try
					{
						val2.SmoothingMode = (SmoothingMode)2;
						val5.Alignment = (StringAlignment)1;
						val5.LineAlignment = (StringAlignment)1;
						val2.Clear(BM.to);
						val2.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FU(), val3, (Brush)(object)val4, 70f, 70f, val5);
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
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
		hI.A((Image)(object)val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FU(), null);
		Enumerator<ValueTuple<CO, string>> enumerator = hh.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CO item = enumerator.Current.Item1;
				if (item.BcF.A())
				{
					hI.A(Co.A(item), item.BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].Bsp, item);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (!hJ)
		{
			B();
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			A a = A;
			((Control)this).BeginInvoke((System.Delegate)a, new object[2] { P_0, P_1 });
		}
		else
		{
			string text = hH;
			hJ = true;
			this.a();
			A(text);
			hJ = false;
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = this.a;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		B();
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b = B;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		((Control)this).Visible = ((SettingOrSpecialObject)hg).l();
	}

	private void B()
	{
		if (hg != null)
		{
			string text = n.A(hg.aY());
			if (text != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV())
			{
				hi = true;
				A(text);
				hi = false;
			}
		}
	}

	private void A(string P_0)
	{
		bool flag = P_0 == null || P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV();
		for (int i = 0; i < hI.b(); i++)
		{
			CO cO = hI.C(i) as CO;
			if ((!flag && cO != null && P_0 == cO.BcF.BCw) || (flag && cO == null))
			{
				if (hI.a() != i)
				{
					hI.a(i);
				}
				break;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = hj;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref hj, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = hj;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref hj, val3, val2);
		}
		while (val != val2);
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (hI.a() != -1 && !hi && !hJ)
		{
			object obj = hI.C(hI.a());
			if (obj == null)
			{
				hH = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV();
				C();
			}
			else if (obj is CO)
			{
				CO cO = obj as CO;
				hH = cO.BcF.BCw;
				C();
			}
		}
		if (hj != null)
		{
			hj.Invoke((object)null, (EventArgs)null);
		}
	}

	[SpecialName]
	internal string b()
	{
		return hH;
	}

	private void C()
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		bool num = hH == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV();
		hG.a().C(hG.a().aWS);
		hG.a().M();
		hG.A().a();
		if (num)
		{
			if (hg != null)
			{
				if (Bz.A() && hG.a().awF.ContainsKey(((SettingOrSpecialObject)hg).d()))
				{
					DO dO = hG.a().awF[((SettingOrSpecialObject)hg).d()];
					Cursor.Current = Cursors.WaitCursor;
					Enumerator<Setting> enumerator = dO.A(hG, true).GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Setting current = enumerator.Current;
							if (!current.am() && (current.I(true) || current.S().Count != 0))
							{
								BM.A(current.C());
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				hg.J(true);
				hG.y();
				hG.i(false);
				hG.G(false);
				BM.b(hg.A());
			}
		}
		else
		{
			Cn cn = null;
			lock (BM.qb)
			{
				if (BM.qB.ContainsKey(hH))
				{
					cn = BM.qB[hH].BcF;
				}
			}
			if (cn != null && hg != null)
			{
				Cursor.Current = Cursors.WaitCursor;
				if (hG.a().awv.Count != 0)
				{
					Co.A(new CO
					{
						BcF = cn,
						Bcf = BM.qB[hH].Bcf
					}, hG.a());
				}
				byte[] array = n.A(hH);
				hg.A(array, true);
				cn.A(hG);
				BM.b(hg.A());
				Cursor.Current = Cursors.WaitCursor;
			}
		}
		hG.a().A(true);
		hG.a().c(hG.a().aWS);
		hG.A().B();
	}

	protected override void Dispose(bool disposing)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if (hg != null)
		{
			hg.a(new EventHandler(a));
			((SettingOrSpecialObject)hg).a(new EventHandler(B));
		}
		BM.f(new EventHandler(A));
		hI.a(new EventHandler(b));
		hI.B();
		if (disposing && hK != null)
		{
			((System.IDisposable)hK).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void c()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		hK = (IContainer)new Container();
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
	}
}
