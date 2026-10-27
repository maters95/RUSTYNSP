using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.SettingsFramework;
using b;

namespace a;

internal class aJ : UserControl
{
	private delegate void A(object P_0, EventArgs P_1);

	private delegate void a(object P_0, EventArgs P_1);

	private delegate void B(object P_0, EventArgs P_1);

	private Framework Ix;

	private Setting IY;

	private Label Iy = new Label();

	private string IZ = string.Empty;

	private bool Iz = true;

	private float iA = 1f;

	internal aJ(int P_0, bool P_1, Framework P_2, float P_3 = 1f)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		A(P_0, P_1, P_2, P_3);
	}

	private void A(int P_0, bool P_1, Framework P_2, float P_3)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		Ix = P_2;
		Iz = P_1;
		iA = P_3;
		IY = Ix.A(P_0);
		IY.A(new EventHandler(a));
		((SettingOrSpecialObject)IY).A(new EventHandler(A));
		global::A.A.A((global::A.D)B);
		BM.D(new EventHandler(B));
		((Control)Iy).Font = new Font(((Control)Iy).Font.FontFamily, 8.25f * iA);
		((Control)Iy).ForeColor = BM.te;
		((Control)Iy).AutoSize = false;
		if (Iz)
		{
			if (iA < 1.1f)
			{
				((Control)Iy).Width = 350;
			}
			else
			{
				((Control)Iy).Width = 490;
			}
		}
		else
		{
			((Control)Iy).Width = 170;
		}
		((Control)Iy).Height = (int)(17f * iA);
		((Control)Iy).Left = 0;
		((Control)Iy).Top = 5;
		((Control)this).Controls.Add((Control)(object)Iy);
		A();
		((Control)this).AutoSize = false;
		((Control)this).Height = ((Control)Iy).Height + 10;
		((Control)this).Width = ((Control)Iy).Width;
	}

	private void A()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Visible = ((SettingOrSpecialObject)IY).l() && PortFunction.A(IY);
		if (!((Control)this).Visible)
		{
			return;
		}
		if (Iz)
		{
			string text = ((SettingOrSpecialObject)IY).A(bz.aYt);
			int num = IY.aS();
			string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(IY.@as(), num, false, 0);
			Size val = TextRenderer.MeasureText(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fs() + text2, ((Control)Iy).Font);
			int num2 = ((Size)(ref val)).Width;
			List<Setting.ListItems.A> val2 = IY.d(0);
			if (val2.Count != 0)
			{
				int num3 = 0;
				for (int i = 0; i < val2.Count; i++)
				{
					val = TextRenderer.MeasureText(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fT() + val2[i].bBV, ((Control)Iy).Font);
					num3 = Math.Max(((Size)(ref val)).Width, num3);
				}
				num2 = Math.Max(num2, num3);
			}
			if (num2 < ((Control)Iy).Width - 20)
			{
				IZ = text;
			}
			else
			{
				IZ = ((SettingOrSpecialObject)IY).A(bz.aYT);
			}
		}
		else
		{
			IZ = string.Empty;
		}
		a();
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
		this.a();
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
		a();
	}

	private void a()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		string text = (string.IsNullOrEmpty(IZ) ? string.Empty : (IZ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fT()));
		if (!BM.A(Ix.aXc, true) || BM.aE())
		{
			text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
		}
		else
		{
			ValueTuple<string, string, bool> val = IY.aX();
			text = text + val.Item1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + val.Item2;
		}
		((Control)Iy).Text = text;
	}

	private void B()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		try
		{
			IY.a(new EventHandler(a));
			((SettingOrSpecialObject)IY).a(new EventHandler(A));
			global::A.A.a((global::A.D)B);
			BM.d(new EventHandler(B));
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		B();
		try
		{
			((ContainerControl)this).Dispose(disposing);
		}
		catch
		{
		}
	}
}
internal abstract class aj : UserControl
{
	protected delegate void A(object P_0, EventArgs P_1);

	protected delegate void a(object P_0, EventArgs P_1);

	internal const int ia = 10;

	protected Framework iB;

	protected Framework ib;

	protected DataIdAndAttrId iC;

	protected Setting ic;

	protected Setting iD;

	protected Setting id;

	protected Setting iE;

	protected Setting ie;

	protected bool iF;

	protected bool @if;

	protected PictureBox iG = new PictureBox();

	protected virtual void A(Framework P_0, Framework P_1)
	{
		iB = P_0;
		ib = P_1;
	}

	protected virtual void A(DataIdAndAttrId P_0)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		iC = P_0;
		id = null;
		Setting setting = iB.A(P_0);
		if (setting.aD() != 0 && setting.ad() != 0)
		{
			iE = iB.A(setting.ad());
			if (iE != null)
			{
				((SettingOrSpecialObject)iE).A(new EventHandler(B));
				Setting setting2 = null;
				if (iE.aE() != 0)
				{
					ie = iB.A(iE.aE());
					if (ie != null)
					{
						ie.A(new EventHandler(b));
						setting2 = iB.A(ie.ax());
					}
				}
				else if (iE.ae() != 0)
				{
					setting2 = iB.A(iE.ae());
				}
				if (setting2 != null)
				{
					Setting setting3 = iB.A(new DataIdAndAttrId(setting2.A(), setting.aD()));
					if (setting3 != null)
					{
						if (iE.ax() == 0)
						{
							id = setting;
							setting = setting3;
						}
						else
						{
							id = setting3;
						}
					}
				}
			}
		}
		ic = setting;
		if (ib != null)
		{
			iD = ib.A(ic.C());
		}
	}

	[SpecialName]
	internal Setting b()
	{
		return ic;
	}

	protected virtual void C()
	{
		iF = iB.B() && iB.b() && ic.J();
		@if = ib != null && ib.B() && ib.b() && iD != null && iD.J();
		if (((Control)this).ContextMenuStrip == null)
		{
			((Control)this).ContextMenuStrip = a();
		}
	}

	protected virtual bool c()
	{
		if (BM.QO == BM.b.BpG && ib != null)
		{
			return @if;
		}
		return iF;
	}

	protected virtual void A(object P_0, EventArgs P_1)
	{
		if (BM.SR != iG)
		{
			if (!BM.Sr && BM.SR != null)
			{
				((Control)BM.SR).Visible = false;
			}
			BM.Sr = ((SettingOrSpecialObject)ic).l() && !ic.O();
			BM.SR = iG;
		}
		((Control)iG).Visible = true;
	}

	protected virtual void a(object P_0, EventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Rectangle clientRectangle = ((Control)this).ClientRectangle;
		if (!((Rectangle)(ref clientRectangle)).Contains(((Control)this).PointToClient(Cursor.Position)))
		{
			((Control)iG).Visible = iG.Image != null && ((SettingOrSpecialObject)ic).l() && !ic.O();
		}
	}

	protected virtual void B(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = B;
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

	protected virtual void b(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = b;
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

	protected abstract void A();

	protected virtual ContextMenuStrip a()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		ContextMenuStrip val = null;
		if (iB.C() && !c())
		{
			val = new ContextMenuStrip();
			((ToolStrip)val).BackColor = BM.tG;
			((ToolStrip)val).ForeColor = BM.te;
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fU();
			((ToolStripItem)val2).Click += new EventHandler(C);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
		}
		return val;
	}

	protected virtual void B()
	{
		Ck ck = BM.aM();
		ck?.A(ic.C());
		if (ic.c() != 0)
		{
			ic.A(ic.aw(), true);
		}
		else
		{
			ic.I(true);
		}
		ck?.B();
		BM.A(ic.C());
	}

	protected void C(object P_0, EventArgs P_1)
	{
		B();
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (((Control)this).ContextMenuStrip != null)
		{
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				((ToolStripItem)item).Click -= new EventHandler(C);
			}
			((Component)((Control)this).ContextMenuStrip).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}
}
