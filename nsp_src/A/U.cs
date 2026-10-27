using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using NSP.SettingsFramework;
using NSP.UserInterface.Forms;
using b;
using c;

namespace A;

internal class U : UserControl
{
	internal enum A
	{
		BhF = -1,
		Bhf,
		BhG,
		Bhg,
		BhH,
		Bhh,
		BhI
	}

	private delegate void a(object P_0, EventArgs P_1);

	private delegate void B(object P_0, EventArgs P_1);

	private delegate void b(object P_0, EventArgs P_1);

	private const int dU = 5;

	private const int du = 20;

	private const int dV = 10;

	private const int dv = 3;

	private List<SpecialObject> dW = new List<SpecialObject>();

	private Setting dw;

	private Framework dX;

	private MenuNode dx;

	private bool dY;

	[SpecialName]
	private int A()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		Size val = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DI(), new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)1));
		return ((Size)(ref val)).Width;
	}

	[SpecialName]
	private int a()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		if (dY && dw != null)
		{
			num += 2;
		}
		Size val = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di(), new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)1));
		return ((Size)(ref val)).Height * num + 5 * (num - 1);
	}

	internal U(MenuNode P_0, int P_1, Framework P_2, bool P_3)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		dX = P_2;
		dw = dX.A(P_1);
		dx = P_0;
		dY = P_3;
		if (dw == null)
		{
			dY = false;
		}
		else
		{
			dw.A(new EventHandler(A));
		}
		global::A.A.A((D)B);
		BM.D(new EventHandler(B));
		BM.E(new EventHandler(B));
		((Control)this).Width = A();
		((Control)this).Height = a();
		((UserControl)this).BorderStyle = (BorderStyle)0;
	}

	private Setting A(SpecialObject P_0)
	{
		Setting setting = dX.A(P_0.c().ChannelSettingId);
		if (setting == null)
		{
			return null;
		}
		return dX.A(setting.ax());
	}

	internal void A(bool P_0)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		b();
		((Control)this).SuspendLayout();
		int num = 10;
		if (!P_0)
		{
			if (((Control)this).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DJ()))
			{
				num += ((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DJ()].Height + 5;
			}
		}
		else
		{
			Label val = new Label();
			((Control)val).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DJ();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dj();
			((Control)val).ForeColor = BM.te;
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, ((Control)val).Font.Size, (FontStyle)1);
			((Control)val).Left = 5;
			((Control)val).Top = num;
			((Control)val).Height = 16;
			((Control)val).AutoSize = true;
			num += ((Control)val).Height + 5;
			((Control)this).Controls.Add((Control)(object)val);
		}
		for (int num2 = 0; num2 < dW.Count; num2++)
		{
			Label val2 = null;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val3 = item;
				if (val3 is Label && val3.Name.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DK() + num2))
				{
					val2 = (Label)val3;
				}
			}
			SpecialObject specialObject = dW[num2];
			Setting setting = A(specialObject);
			Setting setting2 = dX.A(specialObject.c().ThresholdSettingId);
			Setting setting3 = dX.A(specialObject.c().OperatorSettingId);
			if (setting == null || setting2 == null || setting3 == null)
			{
				continue;
			}
			if (!((SettingOrSpecialObject)setting3).l() || !((SettingOrSpecialObject)setting2).l() || !((SettingOrSpecialObject)setting).l())
			{
				if (val2 != null)
				{
					((Component)val2).Dispose();
				}
				continue;
			}
			setting.A(new EventHandler(a));
			string text = ((SettingOrSpecialObject)setting).A(true);
			if (text.Length > 20)
			{
				text = ((SettingOrSpecialObject)setting).A(bz.aYT);
			}
			Label val4 = new Label();
			((Control)val4).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DK() + num2;
			((Control)val4).ForeColor = BM.te;
			((Control)val4).Left = 5;
			((Control)val4).Top = num;
			((Control)val4).Height = 16;
			((Control)val4).AutoSize = true;
			num += ((Control)val4).Height + 5;
			if (!P_0)
			{
				if (val2 == null)
				{
					((Control)val4).Tag = specialObject;
					((Control)val4).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dk();
					((Control)this).Controls.Add((Control)(object)val4);
				}
				else
				{
					((Control)val2).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dk();
					((Component)val4).Dispose();
				}
			}
			else
			{
				((Control)val4).Tag = specialObject;
				((Control)val4).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dk();
				((Control)this).Controls.Add((Control)(object)val4);
			}
		}
		if (dY && dW.Count >= 2 && dw != null)
		{
			Label val5 = new Label();
			((Control)val5).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DL();
			if (B())
			{
				((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
			}
			else
			{
				((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dl();
			}
			((Control)val5).ForeColor = BM.te;
			((Control)val5).Font = new Font(((Control)val5).Font.FontFamily, ((Control)val5).Font.Size, (FontStyle)1);
			((Control)val5).Left = 5;
			((Control)val5).Top = num;
			((Control)val5).Height = 16;
			((Control)val5).AutoSize = true;
			num += ((Control)val5).Height + 5;
			if (P_0)
			{
				((Control)this).Controls.Add((Control)(object)val5);
			}
			else
			{
				if (((Control)this).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DL()))
				{
					((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DL()].Top = ((Control)val5).Top;
				}
				((Component)val5).Dispose();
			}
			Label val6 = new Label();
			((Control)val6).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DM();
			((Control)val6).Tag = dw;
			if (B())
			{
				((Control)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
			}
			else
			{
				((Control)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dm();
			}
			((Control)val6).ForeColor = BM.te;
			((Control)val6).Left = 5;
			((Control)val6).Top = num;
			((Control)val6).Height = 16;
			((Control)val6).AutoSize = true;
			if (P_0)
			{
				((Control)this).Controls.Add((Control)(object)val6);
			}
			else
			{
				if (((Control)this).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DM()))
				{
					((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DM()].Top = num;
				}
				((Component)val6).Dispose();
			}
		}
		else
		{
			foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val7 = item2;
				if (val7 is Label)
				{
					Label val8 = (Label)val7;
					if (((Control)val8).Name.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DL()))
					{
						((Component)val8).Dispose();
					}
					if (((Control)val8).Name.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DM()))
					{
						((Component)val8).Dispose();
					}
				}
			}
		}
		((Control)this).Height = a();
		((Control)this).ResumeLayout();
	}

	private bool B()
	{
		Setting setting = dX.A(13);
		if (setting != null)
		{
			return setting.ax() == 1;
		}
		return false;
	}

	private void b()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		dW.Clear();
		Enumerator<MenuNode> enumerator = dx.c().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				MenuNode current = enumerator.Current;
				if (!current.J())
				{
					continue;
				}
				int num = current.b();
				SettingOrSpecialObject settingOrSpecialObject = dX.a(num);
				if (settingOrSpecialObject != null)
				{
					CG cG = settingOrSpecialObject.e();
					if (cG != null && cG is ConditionalActivator)
					{
						dW.Add(settingOrSpecialObject as SpecialObject);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a2 = A;
				((Control)this).Invoke((System.Delegate)a2, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (!(P_0 is Setting))
		{
			return;
		}
		Label val = null;
		Label val2 = null;
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val3 = item;
			if (!(val3 is Label))
			{
				continue;
			}
			Label val4 = (Label)val3;
			if (((Control)val4).Tag is Setting)
			{
				if ((Setting)((Control)val4).Tag == dw)
				{
					val2 = (Label)(object)((val3 is Label) ? val3 : null);
				}
			}
			else if (((Control)val4).Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DL())
			{
				val = (Label)(object)((val3 is Label) ? val3 : null);
			}
		}
		if (val == null || val2 == null)
		{
			return;
		}
		if ((BM.A(dX.aXc, true) && !BM.aE()) || BM.C(dw.A()))
		{
			if (B())
			{
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
			}
			else
			{
				ValueTuple<string, string, bool> val5 = dw.aX();
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dl();
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DN() + val5.Item1;
			}
		}
		else
		{
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dl();
			((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dm();
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b2 = a;
				((Control)this).Invoke((System.Delegate)b2, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (!(P_0 is Setting))
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val = item;
			if (!(val is Label))
			{
				continue;
			}
			Label val2 = (Label)val;
			if (!(((Control)val2).Tag is SpecialObject))
			{
				continue;
			}
			SpecialObject specialObject = ((Control)val2).Tag as SpecialObject;
			Setting setting = A(specialObject);
			if (setting == null || setting != P_0 as Setting)
			{
				continue;
			}
			Setting setting2 = dX.A(specialObject.c().ThresholdSettingId);
			Setting setting3 = dX.A(specialObject.c().OperatorSettingId);
			if (setting2 == null || setting3 == null)
			{
				continue;
			}
			string empty = string.Empty;
			if ((BM.A(dX.aXc, true) && !BM.aE()) || BM.C(setting.A()))
			{
				empty = ((SettingOrSpecialObject)setting).A(true);
				if (empty.Length > 20)
				{
					empty = ((SettingOrSpecialObject)setting).A(bz.aYT);
				}
				empty += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dn();
				int num = setting.ax();
				ValueTuple<string, string, bool> val3 = setting.A(num, -1);
				empty = string.Concat(new string[6]
				{
					empty,
					val3.Item1,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
					val3.Item2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DO(),
					((object)A(setting2.ax(), num, A(setting3))).ToString()
				});
				((Control)val2).Text = empty;
			}
			else
			{
				empty = ((SettingOrSpecialObject)setting).A(true);
				if (empty.Length > 20)
				{
					empty = ((SettingOrSpecialObject)setting).A(bz.aYT);
				}
				((Control)val2).Text = empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dk();
			}
		}
	}

	private A A(Setting P_0)
	{
		return (A)P_0.ax();
	}

	private void B(object P_0, EventArgs P_1)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		if (((Control)this).InvokeRequired)
		{
			try
			{
				b b2 = B;
				((Control)this).BeginInvoke((System.Delegate)b2, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.A(dX.aXc, true) && !BM.aE())
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val = item;
			if (!(val is Label))
			{
				continue;
			}
			Label val2 = (Label)val;
			if (((Control)val2).Tag is Setting)
			{
				if ((Setting)((Control)val2).Tag == dw)
				{
					((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dm();
				}
			}
			else if (((Control)val2).Tag is SpecialObject)
			{
				SpecialObject specialObject = (SpecialObject)((Control)val2).Tag;
				Setting setting = A(specialObject);
				string empty = string.Empty;
				if (setting != null)
				{
					empty = ((SettingOrSpecialObject)setting).A(true);
					if (empty.Length > 20)
					{
						empty = ((SettingOrSpecialObject)setting).A(bz.aYT);
					}
					((Control)val2).Text = empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dk();
				}
			}
			else if (((Control)val2).Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DL())
			{
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dl();
			}
		}
	}

	internal string A(int P_0, int P_1, A P_2)
	{
		string result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Do();
		switch (P_2)
		{
		case U.A.BhF:
			result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DP();
			break;
		case U.A.Bhf:
			if (P_0 == P_1)
			{
				result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dp();
			}
			break;
		case U.A.BhG:
			if (P_0 != P_1)
			{
				result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dp();
			}
			break;
		case U.A.Bhg:
			if (P_1 > P_0)
			{
				result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dp();
			}
			break;
		case U.A.BhH:
			if (P_1 < P_0)
			{
				result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dp();
			}
			break;
		case U.A.Bhh:
			if (P_1 >= P_0)
			{
				result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dp();
			}
			break;
		case U.A.BhI:
			if (P_1 <= P_0)
			{
				result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dp();
			}
			break;
		}
		return result;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		((Control)this).OnPaint(e);
		if ((int)((UserControl)this).BorderStyle != 2)
		{
			e.Graphics.DrawLine(Pens.Gray, 0, 10, 0, ((Control)this).Bottom - 10);
		}
	}

	protected override void Dispose(bool disposing)
	{
		C();
		try
		{
			((ContainerControl)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	private void C()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		try
		{
			if (dw != null)
			{
				dw.a(new EventHandler(A));
			}
			Enumerator<SpecialObject> enumerator = dW.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					SpecialObject current = enumerator.Current;
					A(current)?.a(new EventHandler(a));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			global::A.A.a((D)B);
			BM.d(new EventHandler(B));
			BM.e(new EventHandler(B));
		}
		catch
		{
		}
	}
}
internal class u : ToolStripDropDown
{
	private List<int> dy = new List<int>();

	private ToolStripMenuItem dZ;

	private ToolStripMenuItem dz;

	private ToolStripMenuItem EA;

	private ToolStripMenuItem Ea;

	private ToolStripMenuItem EB;

	private ToolStripMenuItem Eb;

	private ch EC;

	private Point Ec;

	public u(ch P_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		EC = P_0;
		((ToolStrip)this).BackColor = BM.tG;
		((ToolStrip)this).ForeColor = BM.te;
		if (EC != null && EC.Bhi != null && EC.Bhi.awP.H())
		{
			dZ = D();
			dz = B();
			Ea = c();
			EA = b();
			Eb = C();
		}
		EB = A();
	}

	protected override void Dispose(bool disposing)
	{
		EC = null;
		try
		{
			if (dZ != null)
			{
				((Component)dZ).Dispose();
			}
			if (dz != null)
			{
				((Component)dz).Dispose();
			}
			if (Ea != null)
			{
				((Component)Ea).Dispose();
			}
			if (EB != null)
			{
				((Component)EB).Dispose();
			}
			if (EA != null)
			{
				((Component)EA).Dispose();
			}
			if (Eb != null)
			{
				((Component)Eb).Dispose();
			}
		}
		catch
		{
		}
		try
		{
			((ToolStripDropDown)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	private ToolStripMenuItem A()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		ToolStripMenuItem val = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DQ());
		((ToolStripItem)val).Font = ((Control)this).Font;
		((ToolStripItem)val).BackColor = BM.tG;
		((ToolStripItem)val).ForeColor = BM.te;
		ToolStripMenuItem[] array = a();
		foreach (ToolStripMenuItem val2 in array)
		{
			((ToolStripItem)val2).Click += new EventHandler(D);
			((ToolStripDropDownItem)val).DropDownItems.Add((ToolStripItem)(object)val2);
		}
		return val;
	}

	private ToolStripMenuItem[] a()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		List<ToolStripMenuItem> val = new List<ToolStripMenuItem>();
		try
		{
			ToolStripMenuItem val2 = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dq());
			((ToolStripItem)val2).Font = ((Control)this).Font;
			((ToolStripItem)val2).BackColor = BM.tG;
			((ToolStripItem)val2).ForeColor = BM.te;
			((ToolStripItem)val2).Tag = true;
			val.Add(val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DR());
			((ToolStripItem)val3).Font = ((Control)this).Font;
			((ToolStripItem)val3).BackColor = BM.tG;
			((ToolStripItem)val3).ForeColor = BM.te;
			((ToolStripItem)val3).Tag = false;
			val.Add(val3);
		}
		catch (System.Exception ex)
		{
			_ = ex.Message;
		}
		return val.ToArray();
	}

	private List<int> A(Point P_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		dy.Clear();
		dy = EC.A(P_0);
		return dy;
	}

	internal void A(Point P_0, int P_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		((ToolStrip)this).Items.Clear();
		Ec = P_0;
		dy = A(Ec);
		if (dZ != null)
		{
			((ToolStrip)this).Items.Add((ToolStripItem)(object)dZ);
		}
		if (P_1 >= 0)
		{
			if (EA != null)
			{
				((ToolStrip)this).Items.Add((ToolStripItem)(object)EA);
			}
			if (dz != null)
			{
				((ToolStrip)this).Items.Add((ToolStripItem)(object)dz);
			}
			if (Ea != null)
			{
				((ToolStrip)this).Items.Add((ToolStripItem)(object)Ea);
			}
			((ToolStrip)this).Items.Add((ToolStripItem)(object)A(dy, new EventHandler(b)));
		}
		else if (dy.Count > 0)
		{
			((ToolStrip)this).Items.Add((ToolStripItem)(object)A(dy, new EventHandler(b)));
		}
		if (EC != null && EC.Bhi != null && EC.Bhi.awP != null && !EC.b() && EC.Bhi.awP.f() && Eb != null)
		{
			((ToolStrip)this).Items.Add((ToolStripItem)(object)Eb);
		}
		if (EB != null)
		{
			((ToolStrip)this).Items.Add((ToolStripItem)(object)EB);
		}
	}

	private ToolStripMenuItem B()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		ToolStripMenuItem val = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dr());
		((ToolStripItem)val).Click += new EventHandler(B);
		((ToolStripItem)val).Font = ((Control)this).Font;
		((ToolStripItem)val).BackColor = BM.tG;
		((ToolStripItem)val).ForeColor = BM.te;
		return val;
	}

	private ToolStripMenuItem b()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		ToolStripMenuItem val = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DS());
		((ToolStripItem)val).Click += new EventHandler(A);
		((ToolStripItem)val).Font = ((Control)this).Font;
		((ToolStripItem)val).BackColor = BM.tG;
		((ToolStripItem)val).ForeColor = BM.te;
		return val;
	}

	private ToolStripMenuItem C()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		ToolStripMenuItem val = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ds());
		((ToolStripItem)val).Click += new EventHandler(a);
		((ToolStripItem)val).Font = ((Control)this).Font;
		((ToolStripItem)val).BackColor = BM.tG;
		((ToolStripItem)val).ForeColor = BM.te;
		return val;
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (EC != null)
		{
			EC.c();
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		if (EC != null)
		{
			EC.D();
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		BM.QQ.rl.h();
		if (EC != null)
		{
			EC.a(((Point)(ref Ec)).X, ((Point)(ref Ec)).Y);
		}
	}

	private ToolStripMenuItem A(List<int> P_0, EventHandler P_1)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		ToolStripMenuItem val = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DT());
		((ToolStripItem)val).Font = ((Control)this).Font;
		((ToolStripItem)val).BackColor = BM.tG;
		((ToolStripItem)val).ForeColor = BM.te;
		ToolStripMenuItem[] array = a(P_0);
		foreach (ToolStripMenuItem val2 in array)
		{
			((ToolStripItem)val2).Click += P_1;
			((ToolStripDropDownItem)val).DropDownItems.Add((ToolStripItem)(object)val2);
		}
		return val;
	}

	private ToolStripMenuItem a(List<int> P_0, EventHandler P_1)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		ToolStripMenuItem val = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dt());
		((ToolStripItem)val).Font = ((Control)this).Font;
		((ToolStripItem)val).BackColor = BM.tG;
		((ToolStripItem)val).ForeColor = BM.te;
		ToolStripMenuItem[] array = a(P_0);
		foreach (ToolStripMenuItem val2 in array)
		{
			((ToolStripItem)val2).Click += P_1;
			((ToolStripDropDownItem)val).DropDownItems.Add((ToolStripItem)(object)val2);
		}
		return val;
	}

	private ToolStripMenuItem c()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		ToolStripMenuItem val = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dt());
		((ToolStripItem)val).Click += new EventHandler(C);
		((ToolStripItem)val).Font = ((Control)this).Font;
		((ToolStripItem)val).BackColor = BM.tG;
		((ToolStripItem)val).ForeColor = BM.te;
		((ToolStripItem)val).Tag = -1;
		return val;
	}

	private void b(object P_0, EventArgs P_1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		ToolStripMenuItem val = (ToolStripMenuItem)((P_0 is ToolStripMenuItem) ? P_0 : null);
		Enumerator<int> enumerator = dy.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				if (((ToolStripItem)val).Tag == null || (int)((ToolStripItem)val).Tag == current)
				{
					EC.a(current);
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void C(object P_0, EventArgs P_1)
	{
		BM.Qz.awP.F();
	}

	private ToolStripMenuItem D()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Expected O, but got Unknown
		ToolStripMenuItem val = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DU())
		{
			Font = ((Control)this).Font,
			BackColor = BM.tG,
			ForeColor = BM.te
		};
		((ToolStripItem)val).Click += new EventHandler(c);
		return val;
	}

	private ToolStripMenuItem[] A(List<int> P_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		List<ToolStripMenuItem> val = new List<ToolStripMenuItem>();
		try
		{
			Enumerator<int> enumerator = P_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					ToolStripMenuItem val2 = new ToolStripMenuItem(current + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Du());
					((ToolStripItem)val2).Font = ((Control)this).Font;
					((ToolStripItem)val2).BackColor = BM.tG;
					((ToolStripItem)val2).ForeColor = BM.te;
					((ToolStripItem)val2).Tag = current;
					val.Add(val2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		catch (System.Exception ex)
		{
			_ = ex.Message;
		}
		return val.ToArray();
	}

	private ToolStripMenuItem[] a(List<int> P_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		List<ToolStripMenuItem> val = new List<ToolStripMenuItem>();
		List<string> val2 = EC.A(P_0);
		try
		{
			for (int num = 0; num < val2.Count; num++)
			{
				ToolStripMenuItem val3 = new ToolStripMenuItem(val2[num]);
				((ToolStripItem)val3).Font = ((Control)this).Font;
				((ToolStripItem)val3).BackColor = BM.tG;
				((ToolStripItem)val3).ForeColor = BM.te;
				((ToolStripItem)val3).Tag = P_0[num];
				val.Add(val3);
			}
		}
		catch (System.Exception ex)
		{
			_ = ex.Message;
		}
		return val.ToArray();
	}

	private void c(object P_0, EventArgs P_1)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		if (EC != null)
		{
			int num = 0;
			AddComponentForm addComponentForm = new AddComponentForm(EC.Bhm);
			if ((int)((Form)addComponentForm).ShowDialog() == 1)
			{
				num = addComponentForm.A();
				EC.A(num, ((Point)(ref Ec)).X, ((Point)(ref Ec)).Y);
			}
			((Component)addComponentForm).Dispose();
		}
	}

	private void D(object P_0, EventArgs P_1)
	{
		bool flag = (bool)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		EC.A(flag);
	}
}
