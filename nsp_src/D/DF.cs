using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace D;

internal class DF : cq, Y
{
	private new class A : ThemedButton
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private List<Setting> bBN = new List<Setting>();

		private DF bBn;

		internal A(DF P_0)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			((Control)this).AutoSize = false;
			((Control)this).Width = 120;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJl();
			bBn = P_0;
			Enumerator<UIListSettingDataIdAndIndent> enumerator = bBn.BXD.B().CurrentUIListSettingsIdsAndIndents.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					UIListSettingDataIdAndIndent current = enumerator.Current;
					Setting setting = bBn.BXb.A(current.DataId);
					if (setting != null && setting.af().BYl != 0 && bBn.BXb.A(setting.af().BYl) != null)
					{
						bBN.Add(setting);
						((SettingOrSpecialObject)setting).A(new EventHandler(A));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			BM.QQ.B(new EventHandler(A));
			A(null, null);
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			BM.QQ.b(new EventHandler(A));
			Enumerator<Setting> enumerator = bBN.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((SettingOrSpecialObject)enumerator.Current).a(new EventHandler(A));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			bBN.Clear();
			((ButtonBase)this).Dispose(disposing);
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)this).InvokeRequired)
			{
				A a = A;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			if (BM.QO != BM.b.BpG && bBn.BXb.C())
			{
				Enumerator<Setting> enumerator = bBN.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						if (((SettingOrSpecialObject)enumerator.Current).l())
						{
							((Control)this).Enabled = true;
							return;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			((Control)this).Enabled = false;
		}

		protected override void OnClick(EventArgs e)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			((Button)this).OnClick(e);
			if (BM.QO == BM.b.BpG || !bBn.BXb.C())
			{
				return;
			}
			List<Setting> val = new List<Setting>();
			Enumerator<Setting> enumerator = bBN.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (((SettingOrSpecialObject)current).l())
					{
						val.Add(current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (val.Count == 0)
			{
				return;
			}
			Ck ck = BM.aM();
			ck?.a();
			enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current2 = enumerator.Current;
					Setting setting = bBn.BXb.A(current2.af().BYl);
					current2.a(setting.ax(), true);
					BM.A(current2.C());
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			ck?.B();
		}
	}

	private new class a : ThemedButton
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private Setting bBO;

		private DF bBo;

		internal a(Setting P_0, DF P_1)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			((Control)this).AutoSize = false;
			bBO = P_0;
			bBo = P_1;
			bBO.a(new EventHandler(A));
			bBO.A(new EventHandler(A));
			((SettingOrSpecialObject)bBO).a(new EventHandler(A));
			((SettingOrSpecialObject)bBO).A(new EventHandler(A));
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			bBO.a(new EventHandler(A));
			((SettingOrSpecialObject)bBO).a(new EventHandler(A));
			((ButtonBase)this).Dispose(disposing);
		}

		internal void A()
		{
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			lock (BM.qb)
			{
				string text = n.A(bBO.aY());
				if (BM.qB.ContainsKey(text) && BM.qB[text].BcF != null)
				{
					Cn bcF = BM.qB[text].BcF;
					((Control)this).Text = bcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].Bsp;
				}
				else
				{
					MenuNode menuNode = ((SettingOrSpecialObject)bBO).A().awX[bBO.A()];
					((Control)this).Text = Cn.A(((SettingOrSpecialObject)bBO).A(), menuNode, bBO);
				}
				Size val = TextRenderer.MeasureText(((Control)this).Text, ((Control)this).Font);
				((Control)this).Width = ((Size)(ref val)).Width + 20;
			}
		}

		protected override void OnClick(EventArgs e)
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Invalid comparison between Unknown and I4
			((Button)this).OnClick(e);
			Setting setting = ((SettingOrSpecialObject)bBO).A().A((int)((Control)this).Tag);
			if (setting == null || !((SettingOrSpecialObject)bBO).A().awX.ContainsKey(setting.A()))
			{
				return;
			}
			BR bR = new BR(((SettingOrSpecialObject)bBO).A().awX[setting.A()]);
			if ((int)((Form)bR).ShowDialog((IWin32Window)(object)this) == 1)
			{
				bBo.C();
				if (BM.QQ.rL.A().a().Count != 0)
				{
					BM.QQ.rL.A(false, true, true, true);
					BM.QQ.rL.B(false);
					if (BM.Qn != null)
					{
						BM.QQ.rL.b(false);
					}
				}
			}
			((Component)bR).Dispose();
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
	}

	[Serializable]
	[CompilerGenerated]
	private new sealed class B
	{
		public static readonly B bBP = new B();

		public static Func<SettingOrSpecialObject, bool> bBp;

		internal bool A(SettingOrSpecialObject P_0)
		{
			if (P_0 is Setting)
			{
				return (P_0 as Setting).U();
			}
			return false;
		}
	}

	private const int Bwy = 5;

	private const int BwZ = 2;

	private const int Bwz = 7;

	private const int BXA = 28;

	private const int BXa = 100;

	private const int BXB = 200;

	private Framework BXb;

	private Framework BXC;

	private MenuNode BXc;

	private SpecialObject BXD;

	private Setting BXd;

	private Rectangle BXE;

	private string BXe;

	private float BXF = 1f;

	private int BXf;

	internal DF(SpecialObject P_0, string P_1, MenuNode P_2, Framework P_3, Framework P_4, Rectangle P_5, bool P_6, bool P_7, float P_8 = 1f)
		: base(P_5, P_6, P_7)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		BXD = P_0;
		BXb = P_3;
		BXC = P_4;
		BXc = P_2;
		BXe = P_1;
		BXF = P_8;
		BXE = P_5;
	}

	internal DF(Setting P_0, string P_1, Framework P_2, Framework P_3, Rectangle P_4, bool P_5, bool P_6, float P_7 = 1f)
		: base(P_4, P_5, P_6)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		BXd = P_0;
		BXb = P_2;
		BXC = P_3;
		BXe = P_1;
		BXF = P_7;
		BXE = P_4;
	}

	public override string ToString()
	{
		string text = ((Panel)this).ToString();
		if (BXe != null)
		{
			text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + BXe;
		}
		if (BXD != null)
		{
			text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + BXD.A(true);
		}
		return text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + ((ArrangedElementCollection)((Control)base.B()).Controls).Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgm();
	}

	internal new void A(bool P_0)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		int left = 5;
		int num = 2;
		int num2 = 0;
		if (BXe != string.Empty)
		{
			Label val = new Label();
			((Control)val).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeG();
			((Control)val).Text = BXe;
			((Control)val).ForeColor = BM.tf;
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8f * BXF, (FontStyle)1);
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = left;
			((Control)val).Top = num;
			num = ((Control)val).Bottom + 3;
			num2 = num;
			if (P_0)
			{
				((Control)base.B()).Controls.Add((Control)(object)val);
			}
			else
			{
				((Component)val).Dispose();
			}
		}
		int num3 = 0;
		if (BXd != null || BXD.B().CurrentUIListSettingsIdsAndIndents.Count != 0)
		{
			A(ref left, ref num, P_0);
		}
		else if (BXD != null)
		{
			if (!BXD.b().EachListRowIsAnObject())
			{
				a(ref left, ref num, P_0);
			}
			B(ref left, ref num, P_0);
			if (BXD.b().DataIdsOfListSettings.Count != 0)
			{
				num3 = b(ref left, ref num, P_0);
			}
			else if (BXD.b().EachListRowIsAnObject())
			{
				if (BXD.b().ShowSummary)
				{
					a(P_0);
				}
				else
				{
					C(ref left, ref num, P_0);
				}
			}
			CG cG = BXD.e();
			if (cG != null && cG is ConditionalActivator)
			{
				c(ref left, ref num, P_0);
			}
		}
		B();
		if (BXE != Rectangle.Empty)
		{
			if (P_0)
			{
				((Control)this).Width = ((Rectangle)(ref BXE)).Width;
				((Control)this).Height = ((Rectangle)(ref BXE)).Height;
				((Control)this).Left = ((Rectangle)(ref BXE)).Left;
				((Control)this).Top = ((Rectangle)(ref BXE)).Top;
			}
		}
		else
		{
			int num4 = 0;
			int num5 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val2 = item;
				num4 = Math.Max(num4, val2.Right + 10);
				num5 = Math.Max(num5, val2.Bottom + 10);
			}
			if (((Control)this).Width != num4)
			{
				((Control)this).Width = num4;
			}
			if (num3 != 0 && num2 + num3 > num5)
			{
				if (((Control)this).Height != num2 + num3)
				{
					((Control)this).Height = num2 + num3;
				}
			}
			else if (((Control)this).Height != num5)
			{
				((Control)this).Height = num5;
			}
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
		if (BXc != null && BXc.J())
		{
			if (BXe != string.Empty)
			{
				if (((ArrangedElementCollection)((Control)base.B()).Controls).Count > 1)
				{
					((Control)this).Visible = true;
					base.C();
				}
				else
				{
					((Control)this).Width = 0;
					((Control)this).Height = 0;
					((Control)this).Visible = false;
				}
			}
			else if (((ArrangedElementCollection)((Control)base.B()).Controls).Count > 0)
			{
				((Control)this).Visible = true;
				base.C();
			}
			else
			{
				((Control)this).Width = 0;
				((Control)this).Height = 0;
				((Control)this).Visible = false;
			}
		}
		else
		{
			((Control)this).Visible = true;
			base.C();
		}
		if (P_0)
		{
			return;
		}
		bool flag = false;
		foreach (Control item2 in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val3 = item2;
			if (!val3.Visible)
			{
				continue;
			}
			foreach (Control item3 in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val4 = item3;
				if (val4 != val3 && val4.Visible)
				{
					Rectangle bounds = val4.Bounds;
					if (((Rectangle)(ref bounds)).IntersectsWith(val3.Bounds))
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				break;
			}
		}
		if (flag)
		{
			P_0 = true;
			C();
		}
	}

	private new void B()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		int num = -2147483648;
		int num2 = 2147483647;
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is cu)
			{
				cu cu = (cu)(object)val;
				if (cu.b() > num)
				{
					num = cu.b();
				}
				if (cu.b() < num2)
				{
					num2 = cu.b();
				}
			}
			else if (val is DE)
			{
				DE dE = (DE)(object)val;
				if (dE.b() > num)
				{
					num = dE.b();
				}
				if (dE.b() < num2)
				{
					num2 = dE.b();
				}
			}
			else if (val is cU)
			{
				cU cU = (cU)(object)val;
				if (cU.b() > num)
				{
					num = cU.b();
				}
				if (cU.b() < num2)
				{
					num2 = cU.b();
				}
			}
		}
		if (num2 == num || num == -2147483648)
		{
			return;
		}
		foreach (Control item2 in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val2 = item2;
			if (val2 is cu)
			{
				((cu)(object)val2).A(num);
			}
			else if (val2 is DE)
			{
				((DE)(object)val2).A(num);
			}
			else if (val2 is cU)
			{
				((cU)(object)val2).A(num);
			}
		}
	}

	internal new void b()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		aG aG = null;
		int num = 0;
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val.Visible)
			{
				int num2 = ((Control)base.B()).Height - 30 - val.Bottom;
				num = ((num != 0) ? Math.Min(num, num2) : num2);
				if (val is aG)
				{
					aG = val as aG;
				}
			}
		}
		if (num <= 0 || aG == null)
		{
			return;
		}
		((Control)this).SuspendLayout();
		foreach (Control item2 in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val2 = item2;
			if (val2.Visible && val2.Top > ((Control)aG).Top)
			{
				val2.Top += num;
			}
		}
		aG aG2 = aG;
		((Control)aG2).Height = ((Control)aG2).Height + num;
		((Control)this).ResumeLayout(true);
	}

	private void A(ref int P_0, ref int P_1, bool P_2)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		A a = null;
		List<DataIdAndAttrId> val = new List<DataIdAndAttrId>();
		if (BXD != null)
		{
			a = D(ref P_0, ref P_1, P_2);
			Enumerator<UIListSettingDataIdAndIndent> enumerator = BXD.B().CurrentUIListSettingsIdsAndIndents.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					UIListSettingDataIdAndIndent current = enumerator.Current;
					if (BM.qC == null || BM.qD.Contains(current.DataId))
					{
						val.Add(new DataIdAndAttrId(current.DataId));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		else if (BXd != null)
		{
			Enumerator<SettingOrSpecialObject> enumerator2 = ((SettingOrSpecialObject)BXd).a().GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current is Setting setting && setting.b())
					{
						val.Add(setting.C());
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}
		for (int i = 0; i < val.Count; i++)
		{
			Setting setting2 = null;
			if (BXD != null)
			{
				setting2 = BXb.A(val[i].DataId);
			}
			else if (BXd != null)
			{
				setting2 = BXb.A(val[i]);
			}
			if (setting2 == null || setting2.am())
			{
				continue;
			}
			Cn cn = null;
			bool flag = false;
			MenuNode menuNode = null;
			if (BXc != null)
			{
				menuNode = BXc.A(setting2);
			}
			if (menuNode != null)
			{
				cn = menuNode.Y().BcF;
				if (!Bz.A() && setting2.O() && !setting2.E())
				{
					flag = menuNode.z();
				}
			}
			if (flag)
			{
				continue;
			}
			string text = setting2.A() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + setting2.B();
			Control val2 = null;
			if (!P_2 && ((Control)base.B()).Controls.ContainsKey(text))
			{
				val2 = ((Control)base.B()).Controls[text];
			}
			if ((setting2.al() || setting2.aN()) && !BXb.awX.ContainsKey(setting2.A()))
			{
				if (val2 == null)
				{
					continue;
				}
				int top = val2.Top;
				((Control)base.B()).Controls.Remove(val2);
				int num = 2147483647;
				foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
				{
					Control val3 = item;
					if (val3.Top > top)
					{
						num = Math.Min(num, val3.Top);
					}
				}
				int num2 = num - top;
				foreach (Control item2 in (ArrangedElementCollection)((Control)base.B()).Controls)
				{
					Control val4 = item2;
					if (val4.Top > top)
					{
						val4.Top -= num2;
					}
				}
				continue;
			}
			int num3 = 0;
			if (BXD != null)
			{
				num3 = 18 * BXD.B().CurrentUIListSettingsIdsAndIndents[i].Indent;
			}
			if (setting2.aJ() && !setting2.ah())
			{
				((SettingOrSpecialObject)setting2).a(new EventHandler(b));
				((SettingOrSpecialObject)setting2).A(new EventHandler(b));
				if (((SettingOrSpecialObject)setting2).l() && PortFunction.A(setting2))
				{
					if (val2 == null)
					{
						aJ aJ = new aJ(setting2.A(), true, BXb, BXF);
						((Control)aJ).Name = text;
						((Control)aJ).Left = P_0 + num3;
						((Control)aJ).Top = P_1;
						P_1 = ((Control)aJ).Bottom;
						((Control)base.B()).Controls.Add((Control)(object)aJ);
					}
					else
					{
						P_1 += val2.Height;
					}
				}
				else if (val2 != null)
				{
					((Component)val2).Dispose();
					val2 = null;
				}
			}
			else if (setting2.U() && !Bz.A())
			{
				if (val2 == null)
				{
					ct ct = new ct(setting2.C(), BXb, BXC, cn, menuNode?.aa() ?? false);
					((Control)ct).Name = text;
					if (BXb.aWZ.Contains(setting2.A()))
					{
						((Control)ct.C()).Click += new EventHandler(B);
					}
					((Control)ct).Left = P_0 + num3;
					((Control)ct).Top = P_1;
					P_1 = ((Control)ct).Bottom;
					((Control)base.B()).Controls.Add((Control)(object)ct);
				}
				else
				{
					P_1 += val2.Height;
				}
				if (setting2.aE() != 0 || setting2.ae() != 0)
				{
					P_1 += 7;
				}
			}
			else if (setting2.v())
			{
				if (val2 == null)
				{
					cS cS = new cS(setting2.C(), BXb, BXC);
					((Control)cS).Name = text;
					((Control)cS).Left = P_0 + num3;
					((Control)cS).Top = P_1;
					P_1 = ((Control)cS).Bottom;
					((Control)base.B()).Controls.Add((Control)(object)cS);
				}
				else
				{
					P_1 += val2.Height;
				}
			}
			else if (setting2.Y())
			{
				if (val2 == null)
				{
					cU cU = new cU(setting2.C(), BXb, BXC, cn);
					((Control)cU).Name = text;
					((Control)cU).Left = P_0 + num3;
					((Control)cU).Top = P_1;
					P_1 = ((Control)cU).Bottom;
					((Control)base.B()).Controls.Add((Control)(object)cU);
				}
				else
				{
					P_1 += val2.Height;
				}
			}
			else if (setting2.y())
			{
				if (val2 == null)
				{
					cT cT = new cT(setting2.C(), BXb, BXC, cn, menuNode?.aa() ?? false, menuNode?.z() ?? false);
					((Control)cT).Name = text;
					((Control)cT).Left = P_0 + num3;
					((Control)cT).Top = P_1;
					P_1 = ((Control)cT).Bottom + 2;
					((Control)base.B()).Controls.Add((Control)(object)cT);
				}
				else
				{
					P_1 += val2.Height + 2;
				}
			}
			else if (BXb.awX.ContainsKey(setting2.A()))
			{
				if ((Bz.A() || Cn.b(setting2)) && !Cn.B(setting2))
				{
					MenuNode menuNode2 = BXb.awX[setting2.A()];
					if (BXD.B().CurrentUIListSettingsIdsAndIndents[i].PlacePartialMapSearchableListDirectlyOnPanel)
					{
						if (val2 == null)
						{
							aG aG = new aG();
							((Control)aG).Name = text;
							((Control)aG).Size = new Size(1184, 350);
							((Control)aG).Left = P_0 + num3;
							((Control)aG).Top = P_1;
							aG.A(true);
							aG.A(menuNode2);
							P_1 = ((Control)aG).Bottom + 13;
							((Control)base.B()).Controls.Add((Control)(object)aG);
						}
						else
						{
							P_1 += val2.Height + 13;
						}
					}
					else if (BXD.B().CurrentUIListSettingsIdsAndIndents[i].PlacePartialMapImageGalleryDirectlyOnPanel)
					{
						if (val2 == null)
						{
							af af = new af();
							((Control)af).Name = text;
							((Control)af).Left = P_0 + num3;
							((Control)af).Top = P_1;
							af.A(menuNode2);
							P_1 = ((Control)af).Bottom + 13;
							((Control)base.B()).Controls.Add((Control)(object)af);
						}
						else
						{
							P_1 += val2.Height + 13;
						}
					}
					else if (val2 == null)
					{
						a a2 = new a(setting2, this);
						((Control)a2).Tag = setting2.A();
						((Control)a2).Name = text;
						((Control)a2).Left = P_0 + num3;
						((Control)a2).Top = P_1;
						a2.A();
						P_1 = ((Control)a2).Bottom;
						((Control)base.B()).Controls.Add((Control)(object)a2);
					}
					else
					{
						(val2 as a).A();
						P_1 += val2.Height;
					}
				}
				else if (val2 != null)
				{
					((Component)val2).Dispose();
					val2 = null;
				}
			}
			else if (setting2.L().Count != 0)
			{
				if (setting2.BE())
				{
					if (val2 == null)
					{
						cV cV = new cV(setting2.C(), BXb, BXC, cn);
						((Control)cV).Name = text;
						((Control)cV).Left = P_0 + num3;
						((Control)cV).Top = P_1 + 2;
						P_1 = ((Control)cV).Bottom + 13;
						((Control)base.B()).Controls.Add((Control)(object)cV);
					}
					else
					{
						P_1 += val2.Height + 13;
					}
				}
				else if (val2 == null)
				{
					cu cu = new cu(setting2.C(), BXb, BXC, cn, menuNode?.aa() ?? false, true, false);
					((Control)cu).Name = text;
					((Control)cu).Left = P_0 + num3;
					((Control)cu).Top = P_1 + 2;
					P_1 = ((Control)cu).Bottom + 3;
					((Control)base.B()).Controls.Add((Control)(object)cu);
				}
				else
				{
					P_1 += val2.Height + 3;
				}
			}
			else if (val2 == null)
			{
				DE dE = new DE(setting2.C(), BXb, BXC, cn, menuNode?.aa() ?? false, menuNode?.z() ?? false, false);
				((Control)dE).Name = text;
				((Control)dE).Left = P_0 + num3;
				((Control)dE).Top = P_1 + 2;
				P_1 = ((Control)dE).Bottom + 3;
				((Control)base.B()).Controls.Add((Control)(object)dE);
				if (a != null && dE.e() != null)
				{
					((Control)a).Height = ((Control)dE.e()).Height;
					((Control)a).Left = Math.Max(((Control)a).Left, ((Control)dE).Left + ((Control)dE.e()).Left);
				}
			}
			else
			{
				P_1 += val2.Height + 3;
			}
		}
	}

	private void a(ref int P_0, ref int P_1, bool P_2)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		Enumerator<SettingOrSpecialObject> enumerator = ((SettingOrSpecialObject)BXD).a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				if (!(enumerator.Current is Setting setting) || setting.am() || (BM.qC != null && !BM.qD.Contains(setting.A())))
				{
					continue;
				}
				Cn cn = null;
				bool flag = false;
				MenuNode menuNode = null;
				if (BXc != null)
				{
					menuNode = BXc.A(setting);
				}
				if (menuNode != null)
				{
					cn = menuNode.Y().BcF;
					if (!Bz.A() && setting.O() && !setting.E())
					{
						flag = menuNode.z();
					}
				}
				if (flag)
				{
					continue;
				}
				string text = setting.A() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + setting.B();
				Control val = null;
				if (!P_2 && ((Control)base.B()).Controls.ContainsKey(text))
				{
					val = ((Control)base.B()).Controls[text];
				}
				if ((setting.al() || setting.aN()) && !BXb.awX.ContainsKey(setting.A()))
				{
					if (val != null)
					{
						((Control)base.B()).Controls.Remove(val);
					}
				}
				else if (setting.U() && !Bz.A())
				{
					if (val == null)
					{
						ct ct = new ct(setting.C(), BXb, BXC, cn, menuNode?.aa() ?? false);
						((Control)ct).Name = text;
						if (BXb.aWZ.Contains(setting.A()))
						{
							((Control)ct.C()).Click += new EventHandler(B);
						}
						((Control)ct).Left = P_0;
						((Control)ct).Top = P_1;
						P_1 = ((Control)ct).Bottom;
						((Control)base.B()).Controls.Add((Control)(object)ct);
					}
					else
					{
						P_1 += val.Height;
					}
					if (setting.aE() != 0 || setting.ae() != 0)
					{
						P_1 += 7;
					}
				}
				else if (setting.v())
				{
					if (val == null)
					{
						cS cS = new cS(setting.C(), BXb, BXC);
						((Control)cS).Name = text;
						((Control)cS).Left = P_0;
						((Control)cS).Top = P_1;
						P_1 = ((Control)cS).Bottom;
						((Control)base.B()).Controls.Add((Control)(object)cS);
					}
					else
					{
						P_1 += val.Height;
					}
				}
				else if (setting.Y())
				{
					if (val == null)
					{
						cU cU = new cU(setting.C(), BXb, BXC, cn);
						((Control)cU).Name = text;
						((Control)cU).Left = P_0;
						((Control)cU).Top = P_1;
						P_1 = ((Control)cU).Bottom;
						((Control)base.B()).Controls.Add((Control)(object)cU);
					}
					else
					{
						P_1 += val.Height;
					}
				}
				else if (setting.y())
				{
					if (val == null)
					{
						cT cT = new cT(setting.C(), BXb, BXC, cn, menuNode?.aa() ?? false, menuNode?.z() ?? false);
						((Control)cT).Name = text;
						((Control)cT).Left = P_0;
						((Control)cT).Top = P_1;
						P_1 = ((Control)cT).Bottom + 2;
						((Control)base.B()).Controls.Add((Control)(object)cT);
					}
					else
					{
						P_1 += val.Height + 2;
					}
				}
				else if (BXb.awX.ContainsKey(setting.A()))
				{
					if (Cn.b(setting) && !Cn.B(setting))
					{
						if (val == null)
						{
							a a = new a(setting, this);
							((Control)a).Tag = setting.A();
							((Control)a).Name = text;
							((Control)a).Left = P_0;
							((Control)a).Top = P_1;
							a.A();
							P_1 = ((Control)a).Bottom;
							((Control)base.B()).Controls.Add((Control)(object)a);
						}
						else
						{
							(val as a).A();
							P_1 += val.Height;
						}
					}
					else if (val != null)
					{
						((Component)val).Dispose();
						val = null;
					}
				}
				else if (setting.L().Count != 0)
				{
					if (setting.BE())
					{
						if (val == null)
						{
							cV cV = new cV(setting.C(), BXb, BXC, cn);
							((Control)cV).Name = text;
							((Control)cV).Left = P_0;
							((Control)cV).Top = P_1 + 2;
							P_1 = ((Control)cV).Bottom + 13;
							((Control)base.B()).Controls.Add((Control)(object)cV);
						}
						else
						{
							P_1 += val.Height + 13;
						}
					}
					else if (val == null)
					{
						cu cu = new cu(setting.C(), BXb, BXC, cn, menuNode?.aa() ?? false, true, false);
						((Control)cu).Name = text;
						((Control)cu).Left = P_0;
						((Control)cu).Top = P_1 + 2;
						P_1 = ((Control)cu).Bottom + 3;
						((Control)base.B()).Controls.Add((Control)(object)cu);
					}
					else
					{
						P_1 += val.Height + 3;
					}
				}
				else if (val == null)
				{
					DE dE = new DE(setting.C(), BXb, BXC, cn, menuNode?.aa() ?? false, menuNode?.z() ?? false, false);
					((Control)dE).Name = text;
					((Control)dE).Left = P_0;
					((Control)dE).Top = P_1 + 2;
					P_1 = ((Control)dE).Bottom + 3;
					((Control)base.B()).Controls.Add((Control)(object)dE);
				}
				else
				{
					P_1 += val.Height + 3;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void B(ref int P_0, ref int P_1, bool P_2)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (BXD.R() != null)
		{
			A(ref P_0, ref P_1, P_2, BXD.R());
			return;
		}
		Enumerator<string> enumerator = BXD.Q().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				a(ref P_0, ref P_1, P_2, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void A(ref int P_0, ref int P_1, bool P_2, string P_3)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		Setting setting = Enumerable.First<SettingOrSpecialObject>((System.Collections.Generic.IEnumerable<SettingOrSpecialObject>)((SettingOrSpecialObject)BXD).a(), (Func<SettingOrSpecialObject, bool>)((SettingOrSpecialObject P_0) => P_0 is Setting && (P_0 as Setting).U())) as Setting;
		if (!BXb.aWW.ErrorDefs.ContainsKey(P_3))
		{
			return;
		}
		Label val = null;
		Enumerator<ErrorPanelItem> enumerator = BXb.aWW.ErrorPanel.GetEnumerator();
		try
		{
			int num = default(int);
			while (enumerator.MoveNext())
			{
				ErrorPanelItem current = enumerator.Current;
				switch (current.Type)
				{
				case DataTableColumnType.Text:
					if (BXb.aWW.ErrorDefs[P_3].ContainsKey(current.ErrorDefKey))
					{
						string text = BXb.aWW.ErrorDefs[P_3][current.ErrorDefKey];
						Label val2 = new Label();
						((Control)val2).Text = current.Text + text;
						((Control)val2).ForeColor = (((SettingOrSpecialObject)setting).l() ? BM.te : BM.tq);
						((Control)val2).Left = P_0;
						((Control)val2).Top = P_1 + 3;
						((Control)val2).Height = (int)((float)((Control)val2).Height * 0.7f);
						((Control)val2).Width = 300;
						P_1 = ((Control)val2).Bottom + 5;
						val = val2;
						if (P_2)
						{
							((Control)base.B()).Controls.Add((Control)(object)val2);
						}
						else
						{
							((Component)val2).Dispose();
						}
					}
					break;
				case DataTableColumnType.Enum:
					if (int.TryParse(BXb.aWW.ErrorDefs[P_3][D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KX()], ref num) && current.DataId != -1)
					{
						DataIdAndAttrId dataIdAndAttrId = new DataIdAndAttrId(current.DataId);
						int num2 = BXb.aWW.ErrorToSettingMap[num];
						cu cu = new cu(dataIdAndAttrId, BXb, BXC, null, false, true, false, num2, setting.A(), val);
						((Control)cu).Left = P_0;
						((Control)cu).Top = P_1;
						P_1 = ((Control)cu).Bottom + 5;
						if (P_2)
						{
							((Control)base.B()).Controls.Add((Control)(object)cu);
						}
						else
						{
							((Component)cu).Dispose();
						}
					}
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void a(ref int P_0, ref int P_1, bool P_2, string P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		Label val = new Label();
		((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgN() + P_3;
		((Control)val).ForeColor = BM.te;
		((Control)val).Left = P_0;
		((Control)val).Top = P_1 + 3;
		((Control)val).Height = (int)((float)((Control)val).Height * 0.7f);
		((Control)val).Width = 300;
		P_1 = ((Control)val).Bottom + 5;
		if (P_2)
		{
			((Control)base.B()).Controls.Add((Control)(object)val);
		}
		else
		{
			((Component)val).Dispose();
		}
		if (!BXb.aWv.ContainsKey(P_3))
		{
			return;
		}
		Enumerator<SettingOrSpecialObject> enumerator = ((SettingOrSpecialObject)BXb.aWv[P_3]).a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (!(current is Setting) || !(current.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kW()))
				{
					continue;
				}
				Setting setting = current as Setting;
				Cn cn = null;
				bool flag = false;
				MenuNode menuNode = null;
				if (BXc != null)
				{
					menuNode = BXc.A(setting);
				}
				if (menuNode != null)
				{
					cn = menuNode.Y().BcF;
					if (!Bz.A() && setting.O() && !setting.E())
					{
						flag = menuNode.z();
					}
				}
				if (!flag)
				{
					cu cu = new cu(setting.C(), BXb, BXC, cn, menuNode?.aa() ?? false, true, false);
					((Control)cu).Left = P_0;
					((Control)cu).Top = P_1;
					P_1 = ((Control)cu).Bottom + 5;
					if (P_2)
					{
						((Control)base.B()).Controls.Add((Control)(object)cu);
					}
					else
					{
						((Component)cu).Dispose();
					}
				}
				break;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private int b(ref int P_0, ref int P_1, bool P_2)
	{
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		int num;
		int num2;
		if (BXD.b().FixedCountValue != 0)
		{
			num = BXD.b().FixedCountValue;
			num2 = BXD.b().FixedCountValue;
		}
		else
		{
			Setting setting;
			if (BM.QO == BM.b.BpG && BXC != null)
			{
				setting = BXC.A(BXD.b().DataIdOfListCountSetting);
				if (setting == null)
				{
					setting = BXb.A(BXD.b().DataIdOfListCountSetting);
				}
			}
			else
			{
				setting = BXb.A(BXD.b().DataIdOfListCountSetting);
			}
			num = setting.ax();
			num2 = setting.ar();
			if (num > num2 && num2 != 0)
			{
				num = num2;
			}
			if (num2 == 0)
			{
				num2 = num;
			}
		}
		if (BXf != num && !P_2)
		{
			int num3 = ((ArrangedElementCollection)((Control)base.B()).Controls).Count;
			int num4 = 0;
			while (num4 < num3)
			{
				Control val = ((Control)base.B()).Controls[num4];
				if (val.Tag is bool && (bool)val.Tag)
				{
					((Component)val).Dispose();
					num3--;
				}
				else
				{
					num4++;
				}
			}
		}
		bool[] array = new bool[BXD.b().DataIdsOfListSettings.Count];
		bool[] array2 = new bool[num2];
		bool[] array3 = new bool[BXD.b().DataIdsOfListSettings.Count];
		bool[] array4 = new bool[num2];
		List<Label> val2 = new List<Label>();
		int num5 = P_1;
		for (int i = 0; i <= BXD.b().DataIdsOfListSettings.Count; i++)
		{
			Label val3 = null;
			for (int j = 0; j <= num2; j++)
			{
				Label val4 = null;
				if (i == 0)
				{
					if (j != 0)
					{
						if (BXf != num || P_2)
						{
							if (j <= num)
							{
								val4 = new Label();
								((Control)val4).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgn() + j;
								((Control)val4).Tag = true;
								((Control)val4).Text = BXD.b().GetListLabelString(j);
								((Control)val4).ForeColor = BM.te;
								((Control)val4).Left = P_0;
								((Control)val4).Top = P_1 + 3;
								((Control)val4).Height = (int)((float)((Control)val4).Height * 0.7f);
								((Control)val4).Width = 70;
								((Control)base.B()).Controls.Add((Control)(object)val4);
							}
						}
						else if (!P_2 && ((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgn() + j))
						{
							val4 = (Label)((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgn() + j];
						}
						if (val4 != null)
						{
							val2.Add(val4);
						}
					}
				}
				else
				{
					int num6 = BXD.b().DataIdsOfListSettings[i - 1];
					Setting setting2 = BXb.A(num6);
					if (j == 0)
					{
						if (BXf != num || P_2)
						{
							val3 = new Label();
							((Control)val3).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgO() + i;
							((Control)val3).Tag = true;
							val3.TextAlign = (ContentAlignment)256;
							string text = ((SettingOrSpecialObject)setting2).A(bz.aYv);
							if (string.IsNullOrEmpty(text))
							{
								text = ((SettingOrSpecialObject)setting2).A(bz.aYu);
							}
							string text2 = (string.IsNullOrEmpty(text) ? ((SettingOrSpecialObject)setting2).A(bz.aYt) : text);
							int num7 = setting2.aS();
							if (num7 != 0 && num7 != 82)
							{
								text2 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting2.@as(), num7, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
							}
							((Control)val3).Text = text2;
							((Control)val3).ForeColor = BM.te;
							((Control)val3).Left = P_0;
							((Control)val3).Top = P_1 - 7;
							((Control)val3).Height = 2 * (int)((float)((Control)val3).Height * 0.7f);
							((Control)val3).Width = 80;
							((Control)base.B()).Controls.Add((Control)(object)val3);
						}
						else if (!P_2 && ((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgO() + i))
						{
							val3 = (Label)((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgO() + i];
						}
					}
					else
					{
						Cn cn = null;
						bool flag = false;
						MenuNode menuNode = null;
						if (BXc != null)
						{
							menuNode = BXc.A(setting2);
						}
						if (menuNode != null)
						{
							cn = menuNode.Y().BcF;
							if (!Bz.A() && setting2.O() && !setting2.E())
							{
								flag = menuNode.z();
							}
						}
						if (!flag && (BM.qC == null || BM.qD.Contains(num6)))
						{
							if (setting2.L().Count != 0)
							{
								cs cs = null;
								string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgo() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + i;
								if (BXf != num || P_2)
								{
									if (j <= num && !setting2.al() && !setting2.aN())
									{
										cs = new cs(new DataIdAndAttrId(num6), true, j - 1, BXb, BXC, cn, menuNode?.aa() ?? false);
										((Control)cs).Name = text3;
										((Control)cs).Tag = true;
										((Control)cs).Left = P_0;
										((Control)cs).Top = P_1;
										((Control)base.B()).Controls.Add((Control)(object)cs);
									}
								}
								else if (!P_2 && ((Control)base.B()).Controls.ContainsKey(text3))
								{
									cs = (cs)(object)((Control)base.B()).Controls[text3];
								}
								if (cs != null)
								{
									array[i - 1] = true;
									array2[j - 1] = true;
									if (((Control)cs.b()).Enabled)
									{
										array3[i - 1] = true;
										array4[j - 1] = true;
									}
								}
							}
							else
							{
								Dd dd = null;
								string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgp() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + i;
								if (BXf != num || P_2)
								{
									if (j <= num && !setting2.al() && !setting2.aN())
									{
										dd = new Dd(new DataIdAndAttrId(num6), true, j - 1, BXb, BXC, cn, menuNode?.aa() ?? false);
										((Control)dd).Name = text4;
										((Control)dd).Tag = true;
										((Control)dd).Left = P_0;
										((Control)dd).Top = P_1;
										((Control)base.B()).Controls.Add((Control)(object)dd);
									}
								}
								else if (!P_2 && ((Control)base.B()).Controls.ContainsKey(text4))
								{
									dd = (Dd)(object)((Control)base.B()).Controls[text4];
								}
								if (dd != null)
								{
									array[i - 1] = true;
									array2[j - 1] = true;
									if (((Control)dd.b()).Enabled)
									{
										array3[i - 1] = true;
										array4[j - 1] = true;
									}
								}
							}
						}
					}
				}
				P_1 += 28;
			}
			if (val3 != null && i != 0 && ((Control)base.B()).Controls.Contains((Control)(object)val3))
			{
				if (!array[i - 1])
				{
					((Component)val3).Dispose();
				}
				else if (array3[i - 1])
				{
					((Control)val3).ForeColor = BM.te;
				}
				else
				{
					((Control)val3).ForeColor = BM.tq;
				}
			}
			P_0 += 100;
			P_1 = num5;
		}
		for (int k = 0; k < val2.Count; k++)
		{
			Label val5 = val2[k];
			if (((Control)base.B()).Controls.Contains((Control)(object)val5))
			{
				if (!array2[k])
				{
					((Component)val5).Dispose();
				}
				else if (array4[k])
				{
					((Control)val5).ForeColor = BM.te;
				}
				else
				{
					((Control)val5).ForeColor = BM.tq;
				}
			}
		}
		BXf = num;
		return (1 + num2) * 28 + 10;
	}

	private void C(ref int P_0, ref int P_1, bool P_2)
	{
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		for (int i = 0; i < ((SettingOrSpecialObject)BXD).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)BXD).a()[i];
			if (settingOrSpecialObject is SpecialObject)
			{
				num = Math.Max((settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count, num);
			}
		}
		bool[] array = new bool[num];
		bool[] array2 = new bool[((SettingOrSpecialObject)BXD).a().Count];
		bool[] array3 = new bool[num];
		bool[] array4 = new bool[((SettingOrSpecialObject)BXD).a().Count];
		bool[] array5 = new bool[num];
		int[] array6 = new int[num];
		Label[] array7 = (Label[])(object)new Label[num];
		for (int j = 0; j <= ((SettingOrSpecialObject)BXD).a().Count; j++)
		{
			Label val = null;
			if (j != 0)
			{
				SettingOrSpecialObject settingOrSpecialObject2 = ((SettingOrSpecialObject)BXD).a()[j - 1];
				if (settingOrSpecialObject2 is SpecialObject)
				{
					for (int k = 0; k <= (settingOrSpecialObject2 as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count; k++)
					{
						Label val2 = null;
						if (k == 0)
						{
							if (P_2)
							{
								val = new Label();
								((Control)val).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgn() + j;
								((Control)val).Text = BXD.b().GetListLabelString(j);
								((Control)val).ForeColor = BM.te;
								((Control)val).Left = P_0;
								((Control)val).Top = P_1 + 3;
								((Control)val).Height = (int)((float)((Control)val).Height * 0.7f);
								((Control)val).Width = 80;
								((Control)base.B()).Controls.Add((Control)(object)val);
							}
							else if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgn() + j))
							{
								val = (Label)((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgn() + j];
								((Control)val).Left = P_0;
								((Control)val).Top = P_1 + 3;
							}
							P_0 += 100;
							continue;
						}
						Setting setting = BXb.A((settingOrSpecialObject2 as SpecialObject).B().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
						if (setting == null)
						{
							continue;
						}
						if (j == 1)
						{
							if (P_2)
							{
								val2 = new Label();
								((Control)val2).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgO() + k;
								val2.TextAlign = (ContentAlignment)256;
								string text = ((SettingOrSpecialObject)setting).A(bz.aYv);
								if (string.IsNullOrEmpty(text))
								{
									text = ((SettingOrSpecialObject)setting).A(bz.aYu);
								}
								string text2 = (string.IsNullOrEmpty(text) ? ((SettingOrSpecialObject)setting).A(bz.aYt) : text);
								int num2 = setting.aS();
								if (num2 != 0 && num2 != 82)
								{
									text2 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting.@as(), num2, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
								}
								((Control)val2).Text = text2;
								((Control)val2).ForeColor = BM.te;
								((Control)val2).Left = P_0;
								((Control)val2).Top = P_1 - 37;
								((Control)val2).Height = 2 * (int)((float)((Control)val2).Height * 0.7f);
								((Control)val2).Width = 80;
								((Control)base.B()).Controls.Add((Control)(object)val2);
							}
							else if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgO() + k))
							{
								val2 = (Label)((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgO() + k];
								((Control)val2).Left = P_0;
								((Control)val2).Top = P_1 - 37;
							}
							if (val2 != null)
							{
								array7[k - 1] = val2;
								array6[k - 1] = Math.Max(array6[k - 1], ((Control)val2).Width);
							}
						}
						Cn cn = null;
						bool flag = false;
						MenuNode menuNode = null;
						if (BXc != null)
						{
							menuNode = BXc.A(setting);
						}
						if (menuNode != null)
						{
							cn = menuNode.Y().BcF;
							if (!Bz.A() && setting.O() && !setting.E())
							{
								flag = menuNode.z();
							}
						}
						bool flag2 = BM.qC != null && !BM.qD.Contains(setting.A());
						bool flag3 = !setting.am() && !flag && !flag2 && ((!setting.al() && !setting.aN()) || BXb.awX.ContainsKey(setting.A()));
						if (BXb.awX.ContainsKey(setting.A()))
						{
							string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgQ() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + k;
							a a = null;
							if (((Control)base.B()).Controls.ContainsKey(text3))
							{
								a = (a)(object)((Control)base.B()).Controls[text3];
							}
							if (Cn.b(setting) && !Cn.B(setting))
							{
								if (a == null)
								{
									a = new a(setting, this);
									((Control)a).Tag = setting.A();
									((Control)a).Name = text3;
									((Control)a).Left = P_0;
									((Control)a).Top = P_1 - 1;
									if (flag3)
									{
										((Control)base.B()).Controls.Add((Control)(object)a);
									}
								}
								else
								{
									((Control)a).Left = P_0;
									((Control)a).Top = P_1 - 1;
								}
								a.A();
								((Control)a).Enabled = ((SettingOrSpecialObject)setting).l() && BXb.C() && BM.QO != BM.b.BpG;
								P_0 += ((Control)a).Width + 30;
								array6[k - 1] = Math.Max(array6[k - 1], ((Control)a).Width + 30);
								if (flag3)
								{
									array[k - 1] = true;
									array2[j - 1] = true;
									if (((Control)a).Enabled)
									{
										array3[k - 1] = true;
										array4[j - 1] = true;
									}
								}
								array5[k - 1] = true;
							}
							else if (a != null)
							{
								((Component)a).Dispose();
							}
							continue;
						}
						if (setting.L().Count != 0)
						{
							cs cs = null;
							string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgo() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + k;
							if (P_2)
							{
								cs = new cs(setting.C(), false, 0, BXb, BXC, cn, menuNode?.aa() ?? false);
								((Control)cs).Name = text4;
								((Control)cs).Left = P_0;
								((Control)cs).Top = P_1;
								if (flag3)
								{
									((Control)base.B()).Controls.Add((Control)(object)cs);
								}
							}
							else if (((Control)base.B()).Controls.ContainsKey(text4))
							{
								cs = (cs)(object)((Control)base.B()).Controls[text4];
								((Control)cs).Left = P_0;
								((Control)cs).Top = P_1;
							}
							P_0 += 200;
							array6[k - 1] = Math.Max(array6[k - 1], 200);
							if (flag3 && cs != null)
							{
								array[k - 1] = true;
								array2[j - 1] = true;
								if (((Control)cs.b()).Enabled)
								{
									array3[k - 1] = true;
									array4[j - 1] = true;
								}
							}
							continue;
						}
						Dd dd = null;
						string text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgp() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + k;
						if (P_2)
						{
							dd = new Dd(setting.C(), false, 0, BXb, BXC, cn, menuNode?.aa() ?? false);
							((Control)dd).Name = text5;
							((Control)dd).Left = P_0;
							((Control)dd).Top = P_1;
							if (flag3)
							{
								((Control)base.B()).Controls.Add((Control)(object)dd);
							}
						}
						else if (((Control)base.B()).Controls.ContainsKey(text5))
						{
							dd = (Dd)(object)((Control)base.B()).Controls[text5];
							((Control)dd).Left = P_0;
							((Control)dd).Top = P_1;
						}
						P_0 += 100;
						array6[k - 1] = Math.Max(array6[k - 1], 100);
						if (flag3 && dd != null)
						{
							array[k - 1] = true;
							array2[j - 1] = true;
							if (((Control)dd.b()).Enabled)
							{
								array3[k - 1] = true;
								array4[j - 1] = true;
							}
						}
					}
				}
				if (val != null && j != 0)
				{
					if (array4[j - 1])
					{
						((Control)val).ForeColor = BM.te;
					}
					else
					{
						((Control)val).ForeColor = BM.tq;
					}
					((Control)val).Visible = array2[j - 1];
				}
			}
			P_0 = 5;
			P_1 += 28;
		}
		for (int l = 0; l < array7.Length; l++)
		{
			Label val3 = array7[l];
			if (val3 != null)
			{
				if (array3[l])
				{
					((Control)val3).ForeColor = BM.te;
				}
				else
				{
					((Control)val3).ForeColor = BM.tq;
				}
				((Control)val3).Visible = array[l];
				if (array5[l])
				{
					((Control)val3).Visible = false;
				}
			}
			for (int m = 0; m < l; m++)
			{
				if (array[m])
				{
					continue;
				}
				int num3 = array6[m];
				if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgO() + (l + 1)))
				{
					Control obj = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgO() + (l + 1)];
					obj.Left -= num3;
				}
				for (int n = 1; n <= ((SettingOrSpecialObject)BXD).a().Count; n++)
				{
					if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgQ() + n + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + (l + 1)))
					{
						Control obj2 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgQ() + n + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + (l + 1)];
						obj2.Left -= num3;
					}
					if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgo() + n + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + (l + 1)))
					{
						Control obj3 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgo() + n + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + (l + 1)];
						obj3.Left -= num3;
					}
					if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgp() + n + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + (l + 1)))
					{
						Control obj4 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgp() + n + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgP() + (l + 1)];
						obj4.Left -= num3;
					}
				}
			}
		}
	}

	private void a(bool P_0)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		if (P_0)
		{
			aO aO = new aO(BXD, BXb, new Rectangle(0, 0, 900, 400));
			((Control)base.B()).Controls.Add((Control)(object)aO);
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is aO)
			{
				(val as aO).B();
				break;
			}
		}
	}

	private void c(ref int P_0, ref int P_1, bool P_2)
	{
		Setting setting = BXb.A(BXD.c().ThresholdSettingId);
		if (setting == null)
		{
			return;
		}
		bool flag = false;
		if (!Bz.A() && setting.O() && !setting.E())
		{
			MenuNode menuNode = null;
			if (BXc != null)
			{
				menuNode = BXc.A(setting);
			}
			if (menuNode != null && menuNode.z())
			{
				flag = true;
			}
		}
		if (!flag && (BM.qC == null || BM.qD.Contains(setting.A())))
		{
			ah ah = new ah(BXD.c(), BXb, BXC);
			((Control)ah).Left = P_0;
			((Control)ah).Top = P_1;
			P_1 = ((Control)ah).Bottom + 5;
			if (P_2)
			{
				((Control)base.B()).Controls.Add((Control)(object)ah);
			}
			else
			{
				((Component)ah).Dispose();
			}
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		LinkLabel val = (LinkLabel)((P_0 is LinkLabel) ? P_0 : null);
		if (((Control)val).Tag is int)
		{
			Setting setting = BXb.A((int)((Control)val).Tag);
			TreeNode val2 = BM.QQ.rL.A(BM.QQ.rL.A().a(), setting.C(), false);
			if (val2 != null)
			{
				BM.QQ.rL.A().A(val2);
			}
		}
	}

	private A D(ref int P_0, ref int P_1, bool P_2)
	{
		A a = null;
		if (BXD.B().ShowCalibrateAllButton && BM.qC == null)
		{
			if (!P_2 && ((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgq()))
			{
				a = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgq()] as A;
			}
			if (a == null)
			{
				a = new A(this);
				((Control)a).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgq();
				((Control)a).Top = 0;
				if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeG()))
				{
					((Control)a).Left = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeG()].Right;
				}
				else
				{
					((Control)a).Left = 5;
				}
				if (!(BXe != string.Empty))
				{
					P_1 = ((Control)a).Bottom + 3;
				}
				((Control)base.B()).Controls.Add((Control)(object)a);
			}
			else if (!(BXe != string.Empty))
			{
				P_1 += ((Control)a).Height + 3;
			}
		}
		return a;
	}

	private new void C()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		c();
		while (((ArrangedElementCollection)((Control)base.B()).Controls).Count != 0)
		{
			q.A(((Control)base.B()).Controls[0]);
		}
		if (BXE != Rectangle.Empty)
		{
			BXE = new Rectangle(((Control)this).Location, ((Control)this).Size);
		}
		A(true);
	}

	private void b(object P_0, EventArgs P_1)
	{
		C();
	}

	public Control A(DataIdAndAttrId P_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is ah)
			{
				ah ah = val as ah;
				if (ah.A().C() == P_0)
				{
					return (Control)(object)ah.B();
				}
				if (ah.a().C() == P_0)
				{
					return (Control)(object)ah.b();
				}
			}
			else if ((val is DE && ((aj)(val as DE)).b().C() == P_0) || (val is cu && ((aj)(val as cu)).b().C() == P_0) || (val is ct && (val as ct).b().C() == P_0) || (val is cU && ((aj)(val as cU)).b().C() == P_0) || (val is cV && (val as cV).b().C() == P_0) || (val is Dd && ((aj)(val as Dd)).b().C() == P_0) || (val is cs && ((aj)(val as cs)).b().C() == P_0))
			{
				return val;
			}
		}
		return null;
	}

	public Control A()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (!(val is Label))
			{
				return val;
			}
		}
		return null;
	}

	private void c()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is ct)
			{
				ct ct = val as ct;
				if (BXb.aWZ.Contains(ct.b().A()))
				{
					((Control)ct.C()).Click -= new EventHandler(B);
				}
			}
		}
		if (BXD != null)
		{
			for (int i = 0; i < BXD.B().CurrentUIListSettingsIdsAndIndents.Count; i++)
			{
				((SettingOrSpecialObject)BXb.A(BXD.B().CurrentUIListSettingsIdsAndIndents[i].DataId))?.a(new EventHandler(b));
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			c();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
internal class Df : cq, Y
{
	private new delegate void A(object P_0, EventArgs P_1);

	private const int BXG = 5;

	private const int BXg = 2;

	private const int BXH = 5;

	private Framework BXh;

	private Framework BXI;

	private MenuNode BXi;

	private Setting BXJ;

	private Setting BXj;

	private aP BXK;

	private PictureBox BXk;

	private ThemedButton BXL;

	private ThemedButton BXl;

	private Label BXM;

	private ThemedButton BXm;

	private bool BXN;

	private float BXn = 1f;

	private Rectangle BXO;

	internal bool BXo = true;

	internal Df(Framework P_0, Framework P_1, Rectangle P_2, bool P_3, bool P_4, bool P_5, float P_6 = 1f)
		: base(P_2, P_3, P_4)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		BXh = P_0;
		BXI = P_1;
		BXO = P_2;
		BXN = P_5;
		BXn = P_6;
		((Control)this).ContextMenuStrip = f();
		BM.QQ.B(new EventHandler(B));
	}

	[SpecialName]
	internal void A(MenuNode P_0)
	{
		BXi = P_0;
		if (BXi != null && BXi.h() != 0 && (BM.qC == null || BM.qD.Contains(BXi.h())))
		{
			BXJ = BXh.A(BXi.h());
			if (BXI != null)
			{
				BXj = BXI.A(BXi.h());
			}
		}
	}

	public override string ToString()
	{
		string text = ((Panel)this).ToString();
		if (BXi != null)
		{
			text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + BXi.E();
		}
		return text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + ((ArrangedElementCollection)((Control)base.B()).Controls).Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgm();
	}

	protected override void Dispose(bool disposing)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		try
		{
			B();
			if (BXL != null)
			{
				((Control)BXL).Click -= new EventHandler(F);
			}
			if (BXl != null)
			{
				((Control)BXl).Click -= new EventHandler(f);
			}
			if (BXm != null)
			{
				((Control)BXm).Click -= new EventHandler(e);
			}
			if (BXi != null)
			{
				((SettingOrSpecialObject)BXh.A(BXi.W()))?.a(new EventHandler(D));
			}
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val = item;
				if (val is DA || val is DF)
				{
					val.VisibleChanged -= new EventHandler(d);
					val.Layout -= new LayoutEventHandler(A);
				}
				if (val is LinkLabel)
				{
					val.Click -= new EventHandler(E);
				}
			}
			if (((Control)this).ContextMenuStrip != null)
			{
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opening -= new CancelEventHandler(A);
				foreach (ToolStripMenuItem item2 in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item2).Click -= new EventHandler(G);
				}
			}
			BM.QQ.b(new EventHandler(B));
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private new void B()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		if (BXJ != null)
		{
			if (BXK != null)
			{
				((CheckBox)BXK).CheckedChanged -= new EventHandler(b);
			}
			BXJ.a(new EventHandler(C));
		}
		if (BXk != null)
		{
			((Control)BXk).Click -= new EventHandler(c);
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		b();
	}

	private void b(object P_0, EventArgs P_1)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BXh.C())
		{
			return;
		}
		aP aP = P_0 as aP;
		Setting setting = BXh.A((int)((Control)aP).Tag);
		if (!BM.QP)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)setting).D();
			if (((CheckBox)aP).Checked)
			{
				Setting setting2 = null;
				MenuNode menuNode = null;
				string text = ((SettingOrSpecialObject)setting).P();
				if (text == null)
				{
					if (BXi.t() != null)
					{
						menuNode = BXi;
						text = menuNode.t();
					}
					else if (settingOrSpecialObject.o() != null)
					{
						text = settingOrSpecialObject.o().t();
						if (text != null)
						{
							menuNode = settingOrSpecialObject.o();
						}
					}
				}
				else
				{
					setting2 = setting;
				}
				Ck ck = BM.aM();
				if (text != null && !Bg.A(setting2, menuNode))
				{
					Bg bg = new Bg(text, setting2, menuNode);
					if ((int)((Form)bg).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
					{
						ck?.A(setting.A());
						if (setting.A() == 10195 && setting.d(0).Count == 3)
						{
							setting.a(2, true);
						}
						else
						{
							setting.a(1, true);
						}
					}
					else
					{
						((CheckBox)aP).Checked = false;
					}
					((Component)bg).Dispose();
				}
				else
				{
					ck?.A(setting.A());
					if (setting.A() == 10195 && setting.d(0).Count == 3)
					{
						setting.a(2, true);
					}
					else
					{
						setting.a(1, true);
					}
				}
				if (((CheckBox)aP).Checked)
				{
					PortFunction.A(settingOrSpecialObject, false);
					ck?.B();
				}
			}
			else
			{
				Ck ck2 = BM.aM();
				ck2?.A(setting.A());
				setting.a(0, true);
				if (BXk != null)
				{
					((Control)BXk).Visible = false;
				}
				ck2?.B();
			}
		}
		BM.b(setting.A());
	}

	private void C(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = C;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO == BM.b.BpG || BXJ.am())
		{
			return;
		}
		if (BXJ.A() == 10195)
		{
			if (((CheckBox)BXK).Checked != (BXJ.ax() != 0))
			{
				((CheckBox)BXK).Checked = BXJ.ax() != 0;
			}
		}
		else if (((CheckBox)BXK).Checked != (BXJ.ax() == 1))
		{
			((CheckBox)BXK).Checked = BXJ.ax() == 1;
		}
	}

	private void c(object P_0, EventArgs P_1)
	{
		PictureBox val = (PictureBox)((P_0 is PictureBox) ? P_0 : null);
		BM.A(BXh.A((int)((Control)val).Tag), (Control)(object)val);
	}

	private new void b()
	{
		if (BXJ == null || BXK == null)
		{
			return;
		}
		string text = ((!(((Control)this).Parent is Df)) ? BXi.A(false, false) : BXi.E());
		if (BM.QO == BM.b.BpG && BXj != null)
		{
			BXK.jd = true;
			((Control)BXK).Enabled = false;
			if (BXj.A() == 10195)
			{
				if (((CheckBox)BXK).Checked != (BXj.ax() != 0))
				{
					((CheckBox)BXK).Checked = !((CheckBox)BXK).Checked;
				}
			}
			else if (((CheckBox)BXK).Checked != (BXj.ax() == 1))
			{
				((CheckBox)BXK).Checked = !((CheckBox)BXK).Checked;
			}
			if (D())
			{
				((Control)BXK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGx() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGY();
			}
			else
			{
				((Control)BXK).Text = text;
			}
			return;
		}
		if (D())
		{
			BXK.jd = true;
			((Control)BXK).Enabled = false;
			if (BXJ.A() == 10195)
			{
				if (((CheckBox)BXK).Checked != (BXJ.ax() != 0))
				{
					((CheckBox)BXK).Checked = !((CheckBox)BXK).Checked;
				}
			}
			else if (((CheckBox)BXK).Checked != (BXJ.ax() == 1))
			{
				((CheckBox)BXK).Checked = !((CheckBox)BXK).Checked;
			}
			((Control)BXK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGx() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGY();
			return;
		}
		BXK.jd = false;
		((Control)BXK).Enabled = BXh.C();
		if (BXJ.A() == 10195)
		{
			if (((CheckBox)BXK).Checked != (BXJ.ax() != 0))
			{
				((CheckBox)BXK).Checked = !((CheckBox)BXK).Checked;
			}
		}
		else if (((CheckBox)BXK).Checked != (BXJ.ax() == 1))
		{
			((CheckBox)BXK).Checked = !((CheckBox)BXK).Checked;
		}
		((Control)BXK).Text = text;
	}

	private new void C()
	{
		if (BXk == null)
		{
			return;
		}
		if (((SettingOrSpecialObject)BXJ).l() && !BXJ.O())
		{
			switch (BXJ.P())
			{
			case IllegalitySeverityLevel.Error:
				BXk.Image = (Image)(object)GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				BXk.Image = (Image)(object)GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (BM.A(BXh.aXc, true))
				{
					BXk.Image = (Image)(object)GeneralResources.RedError;
				}
				else
				{
					BXk.Image = (Image)(object)GeneralResources.YellowWarning;
				}
				break;
			default:
				BXk.Image = (Image)(object)GeneralResources.RedError;
				break;
			}
			((Control)BXk).Visible = true;
		}
		else
		{
			((Control)BXk).Visible = false;
			BXk.Image = (Image)(object)GeneralResources.QuestionMark;
		}
	}

	internal new void A(bool P_0)
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_1990: Unknown result type (might be due to invalid IL or missing references)
		//IL_1995: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a18: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected O, but got Unknown
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected O, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected O, but got Unknown
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected O, but got Unknown
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_181f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1824: Unknown result type (might be due to invalid IL or missing references)
		//IL_183d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1842: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_196d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1874: Unknown result type (might be due to invalid IL or missing references)
		//IL_1879: Unknown result type (might be due to invalid IL or missing references)
		//IL_1884: Unknown result type (might be due to invalid IL or missing references)
		//IL_1889: Unknown result type (might be due to invalid IL or missing references)
		//IL_1892: Unknown result type (might be due to invalid IL or missing references)
		//IL_1897: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_170a: Unknown result type (might be due to invalid IL or missing references)
		//IL_170f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1728: Unknown result type (might be due to invalid IL or missing references)
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_175e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1763: Unknown result type (might be due to invalid IL or missing references)
		//IL_176e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1773: Unknown result type (might be due to invalid IL or missing references)
		//IL_177c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1039: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1047: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Unknown result type (might be due to invalid IL or missing references)
		//IL_120c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1225: Unknown result type (might be due to invalid IL or missing references)
		//IL_122a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1104: Unknown result type (might be due to invalid IL or missing references)
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1260: Unknown result type (might be due to invalid IL or missing references)
		//IL_126b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Unknown result type (might be due to invalid IL or missing references)
		//IL_1279: Unknown result type (might be due to invalid IL or missing references)
		//IL_127e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Unknown result type (might be due to invalid IL or missing references)
		//IL_1171: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1402: Unknown result type (might be due to invalid IL or missing references)
		//IL_1336: Unknown result type (might be due to invalid IL or missing references)
		//IL_133b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Unknown result type (might be due to invalid IL or missing references)
		//IL_1359: Unknown result type (might be due to invalid IL or missing references)
		//IL_1383: Unknown result type (might be due to invalid IL or missing references)
		//IL_1388: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_1398: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1585: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1600: Unknown result type (might be due to invalid IL or missing references)
		//IL_1605: Unknown result type (might be due to invalid IL or missing references)
		//IL_1637: Unknown result type (might be due to invalid IL or missing references)
		//IL_163c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1647: Unknown result type (might be due to invalid IL or missing references)
		//IL_164c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1655: Unknown result type (might be due to invalid IL or missing references)
		//IL_165a: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14db: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_150a: Unknown result type (might be due to invalid IL or missing references)
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_151a: Unknown result type (might be due to invalid IL or missing references)
		//IL_151f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1528: Unknown result type (might be due to invalid IL or missing references)
		//IL_152d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		int num = 2;
		if (!BXN || !BXi.l())
		{
			a(P_0, ref num);
			if (BM.qC == null || BM.qc == BXi || BM.qD.Contains(BXi.W()))
			{
				if (BXi.x() && !BXi.aA())
				{
					Setting setting = BXh.A(BXi.W());
					if (setting != null)
					{
						if (Cn.b(setting) && !Cn.B(setting))
						{
							if (BXi.w())
							{
								B(P_0, ref num);
							}
							else if (BXi.X())
							{
								b(P_0, ref num);
							}
							else
							{
								A(P_0, ref num, setting);
							}
						}
						((SettingOrSpecialObject)setting).A(new EventHandler(D));
					}
				}
				if (BXi.Y() != null && BXi.ab() && !BXi.w() && !BXi.X())
				{
					A(P_0, ref num);
				}
			}
		}
		int num2 = -1;
		int num3 = -1;
		Rectangle val = Rectangle.Empty;
		List<List<Rectangle>> val2 = new List<List<Rectangle>>();
		List<int> val3 = new List<int>();
		Enumerator<MenuNode> enumerator = E().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				MenuNode current = enumerator.Current;
				if (!current.J() || a(current))
				{
					continue;
				}
				int num4 = current.I();
				int num5 = current.i();
				bool flag = e();
				if (current.L() != flag)
				{
					continue;
				}
				int num6 = current.b();
				int num7 = current.H();
				SettingOrSpecialObject settingOrSpecialObject = BXh.a(num6);
				SettingOrSpecialObject settingOrSpecialObject2 = BXh.a(num7);
				if (settingOrSpecialObject is Table)
				{
					continue;
				}
				int num8 = 5;
				int num9 = num;
				A(num4, num5, num2, num3, val, val2, val3, ref num8, ref num9);
				Point autoScrollPosition;
				Size size;
				if (BXh.awR != null && BXh.awr != null && BXh.awr != BXh.awR && current == BXh.awr)
				{
					string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgR() + current.e();
					cI cI = null;
					if (P_0)
					{
						cI = new cI(BXh, Rectangle.Empty, false);
						((Control)cI).Name = text;
					}
					else if (((Control)base.B()).Controls.ContainsKey(text))
					{
						cI = ((Control)base.B()).Controls[text] as cI;
					}
					if (cI != null)
					{
						cI cI2 = cI;
						int num10 = num8;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)cI2).Left = num10 + ((Point)(ref autoScrollPosition)).X;
						cI cI3 = cI;
						int num11 = num9;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)cI3).Top = num11 + ((Point)(ref autoScrollPosition)).Y;
						if (P_0)
						{
							((Control)base.B()).Controls.Add((Control)(object)cI);
						}
						cI.A(P_0);
						int num12 = num8;
						int num13 = num9;
						size = ((Control)cI).Size;
						int width = ((Size)(ref size)).Width;
						size = ((Control)cI).Size;
						val = new Rectangle(num12, num13, width, ((Size)(ref size)).Height);
					}
					base.B().A(false);
				}
				else if (BXi.l() && current.E() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgr())
				{
					cQ cQ = null;
					ch ch = null;
					if (P_0)
					{
						ch = new ch(BM.Qz.awP.E()[BXi.m()], BM.Qz, Rectangle.Empty, false, cQ);
						((Control)ch).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgS();
						((Control)ch).Left = num8;
						((Control)ch).Top = num9;
						base.B().A(false);
						((Control)base.B()).Controls.Add((Control)(object)ch);
					}
					else
					{
						if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgc()))
						{
							cQ = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgc()] as cQ;
						}
						if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgS()))
						{
							ch = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgS()] as ch;
						}
						if (cQ != null)
						{
							cQ cQ2 = cQ;
							int num14 = num8;
							autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
							((Control)cQ2).Left = num14 + ((Point)(ref autoScrollPosition)).X;
							cQ cQ3 = cQ;
							int num15 = num9;
							autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
							((Control)cQ3).Top = num15 + ((Point)(ref autoScrollPosition)).Y;
							num9 += ((Control)cQ).Height + 5;
						}
						if (ch != null)
						{
							ch ch2 = ch;
							int num16 = num8;
							autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
							((Control)ch2).Left = num16 + ((Point)(ref autoScrollPosition)).X;
							ch ch3 = ch;
							int num17 = num9;
							autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
							((Control)ch3).Top = num17 + ((Point)(ref autoScrollPosition)).Y;
						}
					}
					if (ch != null)
					{
						val = ((cQ == null) ? new Rectangle(num8, num9, ((Control)ch).Width, ((Control)ch).Height) : new Rectangle(num8, num9 - (((Control)cQ).Height + 5), Math.Max(((Control)ch).Width, ((Control)cQ).Width), ((Control)cQ).Height + 5 + ((Control)ch).Height));
					}
				}
				else if (!string.IsNullOrEmpty(current.d()))
				{
					if (BXh.awn.ContainsKey(current.d()))
					{
						string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgs() + current.e();
						DA dA = null;
						if (P_0)
						{
							dA = new DA(BXh.awn[current.d()], BXh, Rectangle.Empty, false, true, BXn);
							((Control)dA).Name = text2;
						}
						else if (((Control)base.B()).Controls.ContainsKey(text2))
						{
							dA = ((Control)base.B()).Controls[text2] as DA;
						}
						if (dA != null)
						{
							((Control)dA).VisibleChanged -= new EventHandler(d);
							((Control)dA).Layout -= new LayoutEventHandler(A);
							DA dA2 = dA;
							int num18 = num8;
							autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
							((Control)dA2).Left = num18 + ((Point)(ref autoScrollPosition)).X;
							DA dA3 = dA;
							int num19 = num9;
							autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
							((Control)dA3).Top = num19 + ((Point)(ref autoScrollPosition)).Y;
							if (P_0)
							{
								((Control)base.B()).Controls.Add((Control)(object)dA);
							}
							dA.A(P_0);
							((Control)dA).VisibleChanged += new EventHandler(d);
							((Control)dA).Layout += new LayoutEventHandler(A);
							int num20 = num8;
							int num21 = num9;
							size = ((Control)dA).Size;
							int width2 = ((Size)(ref size)).Width;
							size = ((Control)dA).Size;
							val = new Rectangle(num20, num21, width2, ((Size)(ref size)).Height);
						}
					}
				}
				else if (settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count != 0)
				{
					string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgT() + current.e();
					DF dF = null;
					if (P_0)
					{
						string text4 = string.Empty;
						if (current.Q())
						{
							text4 = current.E();
						}
						dF = new DF(settingOrSpecialObject as SpecialObject, text4, current, BXh, BXI, Rectangle.Empty, false, true, BXn);
						((Control)dF).Name = text3;
					}
					else if (((Control)base.B()).Controls.ContainsKey(text3))
					{
						dF = ((Control)base.B()).Controls[text3] as DF;
					}
					if (dF != null)
					{
						((Control)dF).VisibleChanged -= new EventHandler(d);
						((Control)dF).Layout -= new LayoutEventHandler(A);
						DF dF2 = dF;
						int num22 = num8;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)dF2).Left = num22 + ((Point)(ref autoScrollPosition)).X;
						DF dF3 = dF;
						int num23 = num9;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)dF3).Top = num23 + ((Point)(ref autoScrollPosition)).Y;
						if (P_0)
						{
							((Control)base.B()).Controls.Add((Control)(object)dF);
						}
						dF.A(P_0);
						((Control)dF).VisibleChanged += new EventHandler(d);
						((Control)dF).Layout += new LayoutEventHandler(A);
						int num24 = num8;
						int num25 = num9;
						size = ((Control)dF).Size;
						int width3 = ((Size)(ref size)).Width;
						size = ((Control)dF).Size;
						val = new Rectangle(num24, num25, width3, ((Size)(ref size)).Height);
					}
				}
				else if (settingOrSpecialObject2 != null)
				{
					string text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgt() + current.e();
					DD dD = null;
					if (P_0)
					{
						dD = new DD(settingOrSpecialObject2, current, BXh, BXI, Rectangle.Empty, false);
						((Control)dD).Name = text5;
					}
					else if (((Control)base.B()).Controls.ContainsKey(text5))
					{
						dD = ((Control)base.B()).Controls[text5] as DD;
					}
					if (dD != null)
					{
						DD dD2 = dD;
						int num26 = num8;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)dD2).Left = num26 + ((Point)(ref autoScrollPosition)).X;
						DD dD3 = dD;
						int num27 = num9;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)dD3).Top = num27 + ((Point)(ref autoScrollPosition)).Y;
						if (P_0)
						{
							((Control)base.B()).Controls.Add((Control)(object)dD);
						}
						dD.A(P_0);
						int num28 = num8;
						int num29 = num9;
						size = ((Control)dD).Size;
						int width4 = ((Size)(ref size)).Width;
						size = ((Control)dD).Size;
						val = new Rectangle(num28, num29, width4, ((Size)(ref size)).Height);
					}
				}
				else if (settingOrSpecialObject != null)
				{
					if (settingOrSpecialObject is SpecialObject)
					{
						if (settingOrSpecialObject is OnOffSwitchingPoint)
						{
							string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgU() + current.e();
							Dc dc = null;
							if (P_0)
							{
								dc = new Dc(settingOrSpecialObject as OnOffSwitchingPoint, BXh, BXI, Rectangle.Empty, false);
								((Control)dc).Name = text6;
							}
							else if (((Control)base.B()).Controls.ContainsKey(text6))
							{
								dc = ((Control)base.B()).Controls[text6] as Dc;
							}
							if (dc != null)
							{
								Dc dc2 = dc;
								int num30 = num8;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)dc2).Left = num30 + ((Point)(ref autoScrollPosition)).X;
								Dc dc3 = dc;
								int num31 = num9;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)dc3).Top = num31 + ((Point)(ref autoScrollPosition)).Y;
								if (P_0)
								{
									((Control)base.B()).Controls.Add((Control)(object)dc);
									dc.B();
								}
								int num32 = num8;
								int num33 = num9;
								size = ((Control)dc).Size;
								int width5 = ((Size)(ref size)).Width;
								size = ((Control)dc).Size;
								val = new Rectangle(num32, num33, width5, ((Size)(ref size)).Height);
							}
						}
						else if (settingOrSpecialObject is StateMachine)
						{
							string text7 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgu() + current.e();
							De de = null;
							if (P_0)
							{
								de = new De(settingOrSpecialObject as StateMachine, BXh, BXI, Rectangle.Empty, false);
								((Control)de).Name = text7;
							}
							else if (((Control)base.B()).Controls.ContainsKey(text7))
							{
								de = ((Control)base.B()).Controls[text7] as De;
							}
							if (de != null)
							{
								De de2 = de;
								int num34 = num8;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)de2).Left = num34 + ((Point)(ref autoScrollPosition)).X;
								De de3 = de;
								int num35 = num9;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)de3).Top = num35 + ((Point)(ref autoScrollPosition)).Y;
								if (P_0)
								{
									((Control)base.B()).Controls.Add((Control)(object)de);
									de.b();
								}
								int num36 = num8;
								int num37 = num9;
								size = ((Control)de).Size;
								int width6 = ((Size)(ref size)).Width;
								size = ((Control)de).Size;
								val = new Rectangle(num36, num37, width6, ((Size)(ref size)).Height);
							}
						}
						else if (settingOrSpecialObject is WiFiSetup)
						{
							string text8 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgV() + current.e();
							Dh dh = null;
							if (P_0)
							{
								dh = new Dh(BXh, Rectangle.Empty, false);
								((Control)dh).Name = text8;
							}
							else if (((Control)base.B()).Controls.ContainsKey(text8))
							{
								dh = ((Control)base.B()).Controls[text8] as Dh;
							}
							if (dh != null)
							{
								Dh dh2 = dh;
								int num38 = num8;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)dh2).Left = num38 + ((Point)(ref autoScrollPosition)).X;
								Dh dh3 = dh;
								int num39 = num9;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)dh3).Top = num39 + ((Point)(ref autoScrollPosition)).Y;
								if (P_0)
								{
									((Control)base.B()).Controls.Add((Control)(object)dh);
									dh.b();
								}
								int num40 = num8;
								int num41 = num9;
								size = ((Control)dh).Size;
								int width7 = ((Size)(ref size)).Width;
								size = ((Control)dh).Size;
								val = new Rectangle(num40, num41, width7, ((Size)(ref size)).Height);
							}
						}
						else if (settingOrSpecialObject is BezierCurve)
						{
							string text9 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgv() + current.e();
							cH cH = null;
							if (P_0)
							{
								cH = new cH(settingOrSpecialObject as BezierCurve, BXh, BXI, Rectangle.Empty, false);
								((Control)cH).Name = text9;
							}
							else if (((Control)base.B()).Controls.ContainsKey(text9))
							{
								cH = ((Control)base.B()).Controls[text9] as cH;
							}
							if (cH != null)
							{
								cH cH2 = cH;
								int num42 = num8;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)cH2).Left = num42 + ((Point)(ref autoScrollPosition)).X;
								cH cH3 = cH;
								int num43 = num9;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)cH3).Top = num43 + ((Point)(ref autoScrollPosition)).Y;
								if (P_0)
								{
									((Control)base.B()).Controls.Add((Control)(object)cH);
									((Control)cH).Invalidate();
								}
								int num44 = num8;
								int num45 = num9;
								size = ((Control)cH).Size;
								int width8 = ((Size)(ref size)).Width;
								size = ((Control)cH).Size;
								val = new Rectangle(num44, num45, width8, ((Size)(ref size)).Height);
							}
						}
						else if ((settingOrSpecialObject as SpecialObject).C().IdleText != null || (settingOrSpecialObject as SpecialObject).C().PreApplySettingDataIds.Count != 0)
						{
							if (settingOrSpecialObject.l() || (settingOrSpecialObject as SpecialObject).C().InjectorStageIndex == -1)
							{
								string text10 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgW() + current.e();
								cg cg = null;
								if (P_0)
								{
									cg = new cg(settingOrSpecialObject as SpecialObject, BXh, BXI, Rectangle.Empty, false);
									((Control)cg).Name = text10;
								}
								else if (((Control)base.B()).Controls.ContainsKey(text10))
								{
									cg = ((Control)base.B()).Controls[text10] as cg;
								}
								if (cg != null)
								{
									cg cg2 = cg;
									int num46 = num8;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)cg2).Left = num46 + ((Point)(ref autoScrollPosition)).X;
									cg cg3 = cg;
									int num47 = num9;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)cg3).Top = num47 + ((Point)(ref autoScrollPosition)).Y;
									if (P_0)
									{
										((Control)base.B()).Controls.Add((Control)(object)cg);
										cg.A(false, true, null, 0);
									}
									int num48 = num8;
									int num49 = num9;
									size = ((Control)cg).Size;
									int width9 = ((Size)(ref size)).Width;
									size = ((Control)cg).Size;
									val = new Rectangle(num48, num49, width9, ((Size)(ref size)).Height);
								}
							}
						}
						else if (settingOrSpecialObject is KnockDetection)
						{
							string text11 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgw() + current.e();
							cp cp = null;
							if (P_0)
							{
								cp = new cp(settingOrSpecialObject as KnockDetection, BXh, Rectangle.Empty, false);
								((Control)cp).Name = text11;
							}
							else if (((Control)base.B()).Controls.ContainsKey(text11))
							{
								cp = ((Control)base.B()).Controls[text11] as cp;
							}
							if (cp != null)
							{
								cp cp2 = cp;
								int num50 = num8;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)cp2).Left = num50 + ((Point)(ref autoScrollPosition)).X;
								cp cp3 = cp;
								int num51 = num9;
								autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
								((Control)cp3).Top = num51 + ((Point)(ref autoScrollPosition)).Y;
								if (P_0)
								{
									((Control)base.B()).Controls.Add((Control)(object)cp);
									((Control)cp).Invalidate();
								}
								int num52 = num8;
								int num53 = num9;
								size = ((Control)cp).Size;
								int width10 = ((Size)(ref size)).Width;
								size = ((Control)cp).Size;
								val = new Rectangle(num52, num53, width10, ((Size)(ref size)).Height);
							}
						}
						else if (settingOrSpecialObject.f().DataIdOfChannelListSetting != 0)
						{
							if (settingOrSpecialObject.f().HasGroups())
							{
								string text12 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgX() + current.e();
								Dg dg = null;
								if (P_0)
								{
									dg = new Dg(settingOrSpecialObject.f(), BXh, BXI, Rectangle.Empty, false);
									((Control)dg).Name = text12;
								}
								else if (((Control)base.B()).Controls.ContainsKey(text12))
								{
									dg = ((Control)base.B()).Controls[text12] as Dg;
								}
								if (dg != null)
								{
									Dg dg2 = dg;
									int num54 = num8;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)dg2).Left = num54 + ((Point)(ref autoScrollPosition)).X;
									Dg dg3 = dg;
									int num55 = num9;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)dg3).Top = num55 + ((Point)(ref autoScrollPosition)).Y;
									if (P_0)
									{
										((Control)base.B()).Controls.Add((Control)(object)dg);
										dg.b();
									}
									int num56 = num8;
									int num57 = num9;
									size = ((Control)dg).Size;
									int width11 = ((Size)(ref size)).Width;
									size = ((Control)dg).Size;
									val = new Rectangle(num56, num57, width11, ((Size)(ref size)).Height);
								}
							}
							else
							{
								string text13 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgx() + current.e();
								DG dG = null;
								if (P_0)
								{
									dG = new DG(settingOrSpecialObject.f(), BXh, BXI, Rectangle.Empty, false);
									((Control)dG).Name = text13;
								}
								else if (((Control)base.B()).Controls.ContainsKey(text13))
								{
									dG = ((Control)base.B()).Controls[text13] as DG;
								}
								if (dG != null)
								{
									DG dG2 = dG;
									int num58 = num8;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)dG2).Left = num58 + ((Point)(ref autoScrollPosition)).X;
									DG dG3 = dG;
									int num59 = num9;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)dG3).Top = num59 + ((Point)(ref autoScrollPosition)).Y;
									if (P_0)
									{
										((Control)base.B()).Controls.Add((Control)(object)dG);
										dG.b();
									}
									int num60 = num8;
									int num61 = num9;
									size = ((Control)dG).Size;
									int width12 = ((Size)(ref size)).Width;
									size = ((Control)dG).Size;
									val = new Rectangle(num60, num61, width12, ((Size)(ref size)).Height);
								}
							}
						}
						else if (settingOrSpecialObject.K().A().Count != 0)
						{
							if (BM.qC == null && !settingOrSpecialObject.K().a())
							{
								string text14 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgY() + current.e();
								aK aK = null;
								if (P_0)
								{
									aK = new aK(settingOrSpecialObject, settingOrSpecialObject.K(), BXh);
									((Control)aK).Name = text14;
								}
								else if (((Control)base.B()).Controls.ContainsKey(text14))
								{
									aK = ((Control)base.B()).Controls[text14] as aK;
								}
								if (aK != null)
								{
									aK aK2 = aK;
									int num62 = num8;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)aK2).Left = num62 + ((Point)(ref autoScrollPosition)).X;
									aK aK3 = aK;
									int num63 = num9;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)aK3).Top = num63 + ((Point)(ref autoScrollPosition)).Y;
									if (P_0)
									{
										((Control)base.B()).Controls.Add((Control)(object)aK);
									}
									int num64 = num8;
									int num65 = num9;
									size = ((Control)aK).Size;
									int width13 = ((Size)(ref size)).Width;
									size = ((Control)aK).Size;
									val = new Rectangle(num64, num65, width13, ((Size)(ref size)).Height);
								}
							}
						}
						else
						{
							bool flag2 = false;
							Enumerator<InitialTaskObject> enumerator2 = settingOrSpecialObject.J().GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.a() == CE.azQ)
									{
										flag2 = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator2).Dispose();
							}
							if (flag2)
							{
								bool flag3 = false;
								enumerator2 = settingOrSpecialObject.J().GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										if (enumerator2.Current.C())
										{
											flag3 = true;
											break;
										}
									}
								}
								finally
								{
									((System.IDisposable)enumerator2).Dispose();
								}
								if (BM.qC == null && !flag3)
								{
									string text15 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgy() + current.e();
									ai ai = null;
									if (P_0)
									{
										ai = new ai(settingOrSpecialObject, BXh);
										((Control)ai).Name = text15;
									}
									else if (((Control)base.B()).Controls.ContainsKey(text15))
									{
										ai = ((Control)base.B()).Controls[text15] as ai;
									}
									if (ai != null)
									{
										ai ai2 = ai;
										int num66 = num8;
										autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
										((Control)ai2).Left = num66 + ((Point)(ref autoScrollPosition)).X;
										ai ai3 = ai;
										int num67 = num9;
										autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
										((Control)ai3).Top = num67 + ((Point)(ref autoScrollPosition)).Y;
										if (P_0)
										{
											((Control)base.B()).Controls.Add((Control)(object)ai);
										}
										int num68 = num8;
										int num69 = num9;
										size = ((Control)ai).Size;
										int width14 = ((Size)(ref size)).Width;
										size = ((Control)ai).Size;
										val = new Rectangle(num68, num69, width14, ((Size)(ref size)).Height);
									}
								}
							}
							else
							{
								string text16 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgT() + current.e();
								DF dF4 = null;
								if (P_0)
								{
									string text17 = string.Empty;
									if (current.Q())
									{
										text17 = current.E();
									}
									dF4 = new DF(settingOrSpecialObject as SpecialObject, text17, current, BXh, BXI, Rectangle.Empty, false, true, BXn);
									((Control)dF4).Name = text16;
								}
								else if (((Control)base.B()).Controls.ContainsKey(text16))
								{
									dF4 = ((Control)base.B()).Controls[text16] as DF;
								}
								if (dF4 != null)
								{
									DF dF5 = dF4;
									int num70 = num8;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)dF5).Left = num70 + ((Point)(ref autoScrollPosition)).X;
									DF dF6 = dF4;
									int num71 = num9;
									autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
									((Control)dF6).Top = num71 + ((Point)(ref autoScrollPosition)).Y;
									if (P_0)
									{
										((Control)base.B()).Controls.Add((Control)(object)dF4);
									}
									dF4.A(P_0);
									int num72 = num8;
									int num73 = num9;
									size = ((Control)dF4).Size;
									int width15 = ((Size)(ref size)).Width;
									size = ((Control)dF4).Size;
									val = new Rectangle(num72, num73, width15, ((Size)(ref size)).Height);
								}
							}
						}
					}
					else if (settingOrSpecialObject is SensorCalibration && (settingOrSpecialObject as SensorCalibration).CalibrationValuesSetting != null)
					{
						string text18 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgZ() + current.e();
						cr cr = null;
						if (P_0)
						{
							cr = new cr(settingOrSpecialObject as SensorCalibration, current, BXh, BXI, Rectangle.Empty, false);
							((Control)cr).Name = text18;
						}
						else if (((Control)base.B()).Controls.ContainsKey(text18))
						{
							cr = ((Control)base.B()).Controls[text18] as cr;
						}
						if (cr != null)
						{
							cr cr2 = cr;
							int num74 = num8;
							autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
							((Control)cr2).Left = num74 + ((Point)(ref autoScrollPosition)).X;
							cr cr3 = cr;
							int num75 = num9;
							autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
							((Control)cr3).Top = num75 + ((Point)(ref autoScrollPosition)).Y;
							if (P_0)
							{
								((Control)base.B()).Controls.Add((Control)(object)cr);
								cr.b();
							}
							int num76 = num8;
							int num77 = num9;
							size = ((Control)cr).Size;
							int width16 = ((Size)(ref size)).Width;
							size = ((Control)cr).Size;
							val = new Rectangle(num76, num77, width16, ((Size)(ref size)).Height);
						}
					}
				}
				else if (current.r() != 0)
				{
					string text19 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgz() + current.e();
					U u = null;
					if (P_0)
					{
						u = new U(BXi, current.r(), BXh, current.S());
						((Control)u).Name = text19;
					}
					else if (((Control)base.B()).Controls.ContainsKey(text19))
					{
						u = ((Control)base.B()).Controls[text19] as U;
					}
					if (u != null)
					{
						U u2 = u;
						int num78 = num8;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)u2).Left = num78 + ((Point)(ref autoScrollPosition)).X;
						U u3 = u;
						int num79 = num9;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)u3).Top = num79 + ((Point)(ref autoScrollPosition)).Y;
						if (P_0)
						{
							((Control)base.B()).Controls.Add((Control)(object)u);
						}
						u.A(P_0);
						int num80 = num8;
						int num81 = num9;
						size = ((Control)u).Size;
						int width17 = ((Size)(ref size)).Width;
						size = ((Control)u).Size;
						val = new Rectangle(num80, num81, width17, ((Size)(ref size)).Height);
					}
				}
				else if (current.j() || current.K())
				{
					a(P_0, current, num8, num9, ref val);
				}
				else
				{
					Enumerator<MenuNode> enumerator3 = current.c().GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							if (enumerator3.Current.J())
							{
								A(P_0, current, num8, num9, ref val);
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator3).Dispose();
					}
				}
				if (num4 == num2 && num5 == num3)
				{
					num2++;
					num4 = num2;
				}
				else
				{
					num2 = num4;
				}
				num3 = num5;
				if (current.R() || current.q())
				{
					val3.Add(num4);
				}
				while (num4 >= val2.Count)
				{
					val2.Add(new List<Rectangle>());
				}
				if (num5 >= val2[num4].Count)
				{
					val2[num4].Add(val);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (BXO != Rectangle.Empty)
		{
			if (P_0)
			{
				((Control)this).Width = ((Rectangle)(ref BXO)).Width;
				((Control)this).Height = ((Rectangle)(ref BXO)).Height;
				((Control)this).Left = ((Rectangle)(ref BXO)).Left;
				((Control)this).Top = ((Rectangle)(ref BXO)).Top;
			}
		}
		else
		{
			int num82 = 0;
			int num83 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val4 = item;
				num82 = Math.Max(num82, val4.Right + 10);
				num83 = Math.Max(num83, val4.Bottom + 10);
			}
			if (((Control)this).Width != num82 || ((Control)this).Height != num83)
			{
				((Control)this).Width = num82;
				((Control)this).Height = num83;
			}
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
		if (BXi.J())
		{
			string text20 = ((!(((Control)this).Parent is Df)) ? BXi.A(false, false) : BXi.E());
			if (BXi.Q() && !string.IsNullOrEmpty(text20))
			{
				if (((ArrangedElementCollection)((Control)base.B()).Controls).Count > 1)
				{
					((Control)this).Visible = true;
					base.C();
				}
				else
				{
					((Control)this).Width = 0;
					((Control)this).Height = 0;
					((Control)this).Visible = false;
				}
			}
			else if (((ArrangedElementCollection)((Control)base.B()).Controls).Count > 0)
			{
				((Control)this).Visible = true;
				base.C();
			}
			else
			{
				((Control)this).Width = 0;
				((Control)this).Height = 0;
				((Control)this).Visible = false;
			}
		}
		else
		{
			((Control)this).Visible = true;
			base.C();
		}
	}

	private bool a(MenuNode P_0)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (BM.qC != null && (!P_0.x() || (P_0 != BM.qc && !BM.qD.Contains(P_0.W()))))
		{
			if (BXi.l() && P_0.E() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgr())
			{
				return false;
			}
			HashSet<DataIdAndAttrId> obj = MenuNode.A(P_0, false);
			bool flag = false;
			Enumerator<DataIdAndAttrId> enumerator = obj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataIdAndAttrId current = enumerator.Current;
					if (BM.qD.Contains(current.DataId))
					{
						flag = true;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (!flag)
			{
				return true;
			}
		}
		return false;
	}

	private void D(object P_0, EventArgs P_1)
	{
		A(false);
	}

	private void d(object P_0, EventArgs P_1)
	{
		if (BXo)
		{
			Control val = (Control)((P_0 is Control) ? P_0 : null);
			if (val != null && !val.Disposing && !val.IsDisposed)
			{
				A(false);
			}
		}
	}

	private void A(object P_0, LayoutEventArgs P_1)
	{
		if (BXo)
		{
			A(false);
		}
	}

	internal void c()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		aG aG = null;
		int num = 0;
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val.Visible)
			{
				int num2 = ((Control)base.B()).Height - 30 - val.Bottom;
				num = ((num != 0) ? Math.Min(num, num2) : num2);
				if (val is aG)
				{
					aG = val as aG;
				}
			}
		}
		if (aG != null)
		{
			if (num <= 0)
			{
				return;
			}
			((Control)this).SuspendLayout();
			foreach (Control item2 in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val2 = item2;
				if (val2.Visible && val2.Top > ((Control)aG).Top)
				{
					val2.Top += num;
				}
			}
			aG aG2 = aG;
			((Control)aG2).Height = ((Control)aG2).Height + num;
			((Control)this).ResumeLayout(true);
		}
		else
		{
			if (num <= 0)
			{
				return;
			}
			foreach (Control item3 in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val3 = item3;
				if (!val3.Visible || !(val3 is DF))
				{
					continue;
				}
				DF dF = val3 as DF;
				foreach (Control item4 in (ArrangedElementCollection)((Control)dF.B()).Controls)
				{
					Control val4 = item4;
					if (!val4.Visible || !(val4 is aG))
					{
						continue;
					}
					aG = val4 as aG;
					((Control)this).SuspendLayout();
					((Control)dF).SuspendLayout();
					foreach (Control item5 in (ArrangedElementCollection)((Control)base.B()).Controls)
					{
						Control val5 = item5;
						if (val5.Visible && val5.Top > ((Control)dF).Top)
						{
							val5.Top += num;
						}
					}
					((Control)dF).Height = ((Control)dF).Height + num;
					foreach (Control item6 in (ArrangedElementCollection)((Control)dF.B()).Controls)
					{
						Control val6 = item6;
						if (val6.Visible && val6.Top > ((Control)aG).Top)
						{
							val6.Top += num;
						}
					}
					aG aG3 = aG;
					((Control)aG3).Height = ((Control)aG3).Height + num;
					((Control)dF).ResumeLayout(true);
					((Control)this).ResumeLayout(true);
					return;
				}
			}
		}
	}

	private bool D()
	{
		if (BM.QO == BM.b.BpG && BXj != null)
		{
			if (BXI.B() && BXI.b())
			{
				return BXj.J();
			}
			return false;
		}
		if (BXh.B() && BXh.b())
		{
			return BXJ.J();
		}
		return false;
	}

	private void A(bool P_0, ref int P_1)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected O, but got Unknown
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected O, but got Unknown
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected O, but got Unknown
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected O, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected O, but got Unknown
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected O, but got Unknown
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		P_1 += 5;
		int num = P_1;
		int num2 = 0;
		string bsP = BXi.Y().BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP;
		Point autoScrollPosition;
		Size val3;
		if (string.IsNullOrEmpty(BXi.Y().BcF.Bca))
		{
			if (P_0)
			{
				Label val = new Label();
				((Control)val).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHA();
				((Control)val).BackColor = Color.Transparent;
				((Control)val).ForeColor = BM.te;
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 9f);
				((Control)val).AutoSize = true;
				((Control)val).Text = bsP;
				((Control)val).Left = 5;
				((Control)val).Top = P_1;
				((Control)base.B()).Controls.Add((Control)(object)val);
			}
			else if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHA()))
			{
				Control obj = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHA()];
				Control obj2 = ((obj is Label) ? obj : null);
				autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
				obj2.Left = 5 + ((Point)(ref autoScrollPosition)).X;
				int num3 = P_1;
				autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
				obj2.Top = num3 + ((Point)(ref autoScrollPosition)).Y;
			}
			Font val2 = new Font(((Control)this).Font.FontFamily, 9f);
			try
			{
				val3 = TextRenderer.MeasureText(bsP, val2);
				num2 = Math.Max(5 + ((Size)(ref val3)).Width + 20, num2);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		else
		{
			if (P_0)
			{
				LinkLabel val4 = new LinkLabel();
				((Control)val4).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHa();
				((Control)val4).Tag = BXi.Y().BcF;
				((Control)val4).Font = new Font(((Control)val4).Font.FontFamily, 9f);
				val4.LinkBehavior = (LinkBehavior)1;
				val4.LinkColor = BM.tF;
				((Control)val4).AutoSize = true;
				((Control)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHB() + bsP;
				((Control)val4).Left = 5;
				((Control)val4).Top = P_1;
				((Control)val4).Click += new EventHandler(E);
				((Control)base.B()).Controls.Add((Control)(object)val4);
			}
			else if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHa()))
			{
				Control obj3 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHa()];
				Control obj4 = ((obj3 is LinkLabel) ? obj3 : null);
				autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
				obj4.Left = 5 + ((Point)(ref autoScrollPosition)).X;
				int num4 = P_1;
				autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
				obj4.Top = num4 + ((Point)(ref autoScrollPosition)).Y;
			}
			Font val5 = new Font(((Control)this).Font.FontFamily, 9f);
			try
			{
				val3 = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHB() + bsP, val5);
				num2 = Math.Max(5 + ((Size)(ref val3)).Width + 20, num2);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
		}
		P_1 += 23;
		string bsQ = BXi.Y().BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsQ;
		if (P_0)
		{
			Label val6 = new Label();
			((Control)val6).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHb();
			((Control)val6).BackColor = Color.Transparent;
			((Control)val6).ForeColor = BM.te;
			((Control)val6).Font = new Font(((Control)val6).Font.FontFamily, 9f);
			((Control)val6).AutoSize = true;
			((Control)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fF();
			((Control)val6).Left = 5;
			((Control)val6).Top = P_1;
			((Control)base.B()).Controls.Add((Control)(object)val6);
			Label val7 = new Label();
			((Control)val7).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHC();
			((Control)val7).BackColor = Color.Transparent;
			((Control)val7).ForeColor = BM.te;
			((Control)val7).Font = new Font(((Control)val7).Font.FontFamily, 9f);
			((Control)val7).AutoSize = true;
			((Control)val7).Text = bsQ;
			((Control)val7).Left = 150;
			((Control)val7).Top = P_1;
			((Control)base.B()).Controls.Add((Control)(object)val7);
		}
		else if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHb()) && ((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHC()))
		{
			Control obj5 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHb()];
			Control obj6 = ((obj5 is Label) ? obj5 : null);
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			obj6.Left = 5 + ((Point)(ref autoScrollPosition)).X;
			int num5 = P_1;
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			obj6.Top = num5 + ((Point)(ref autoScrollPosition)).Y;
			Control obj7 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHC()];
			Control obj8 = ((obj7 is Label) ? obj7 : null);
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			obj8.Left = 150 + ((Point)(ref autoScrollPosition)).X;
			int num6 = P_1;
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			obj8.Top = num6 + ((Point)(ref autoScrollPosition)).Y;
		}
		Font val8 = new Font(((Control)this).Font.FontFamily, 9f);
		try
		{
			val3 = TextRenderer.MeasureText(bsQ, val8);
			num2 = Math.Max(150 + ((Size)(ref val3)).Width + 20, num2);
		}
		finally
		{
			((System.IDisposable)val8)?.Dispose();
		}
		for (int i = 0; i < bsQ.Length; i++)
		{
			if (bsQ[i] == '\n')
			{
				P_1 += 15;
			}
		}
		P_1 += 20;
		string text = ((object)BXi.Y().BcF.BCY).ToString();
		if (P_0)
		{
			Label val9 = new Label();
			((Control)val9).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHc();
			((Control)val9).BackColor = Color.Transparent;
			((Control)val9).ForeColor = BM.te;
			((Control)val9).Font = new Font(((Control)val9).Font.FontFamily, 9f);
			((Control)val9).AutoSize = true;
			((Control)val9).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHD();
			((Control)val9).Left = 5;
			((Control)val9).Top = P_1;
			((Control)base.B()).Controls.Add((Control)(object)val9);
			Label val10 = new Label();
			((Control)val10).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHd();
			((Control)val10).BackColor = Color.Transparent;
			((Control)val10).ForeColor = BM.te;
			((Control)val10).Font = new Font(((Control)val10).Font.FontFamily, 9f);
			((Control)val10).AutoSize = true;
			((Control)val10).Text = text;
			((Control)val10).Left = 150;
			((Control)val10).Top = P_1;
			((Control)base.B()).Controls.Add((Control)(object)val10);
		}
		else if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHc()) && ((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHd()))
		{
			Control obj9 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHc()];
			Control obj10 = ((obj9 is Label) ? obj9 : null);
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			obj10.Left = 5 + ((Point)(ref autoScrollPosition)).X;
			int num7 = P_1;
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			obj10.Top = num7 + ((Point)(ref autoScrollPosition)).Y;
			Control obj11 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHd()];
			Control obj12 = ((obj11 is Label) ? obj11 : null);
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			obj12.Left = 150 + ((Point)(ref autoScrollPosition)).X;
			int num8 = P_1;
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			obj12.Top = num8 + ((Point)(ref autoScrollPosition)).Y;
		}
		Font val11 = new Font(((Control)this).Font.FontFamily, 9f);
		try
		{
			val3 = TextRenderer.MeasureText(text, val11);
			num2 = Math.Max(150 + ((Size)(ref val3)).Width + 20, num2);
		}
		finally
		{
			((System.IDisposable)val11)?.Dispose();
		}
		P_1 += 20;
		int num9 = 0;
		Enumerator<string, string> enumerator = BXi.Y().BcF.Bcb.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (BXi.a().awF.ContainsKey(BXi.Y().BcF.BCx) && BXi.a().awF[BXi.Y().BcF.BCx].d().Contains(current))
				{
					continue;
				}
				string text2 = BXi.Y().BcF.Bcb[current];
				if (P_0)
				{
					Label val12 = new Label();
					((Control)val12).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHE() + num9;
					((Control)val12).BackColor = Color.Transparent;
					((Control)val12).ForeColor = BM.te;
					((Control)val12).Font = new Font(((Control)val12).Font.FontFamily, 9f);
					((Control)val12).AutoSize = true;
					((Control)val12).Text = Cn.A(current, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
					((Control)val12).Left = 5;
					((Control)val12).Top = P_1;
					((Control)base.B()).Controls.Add((Control)(object)val12);
					Label val13 = new Label();
					((Control)val13).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHe() + num9;
					((Control)val13).BackColor = Color.Transparent;
					((Control)val13).ForeColor = BM.te;
					((Control)val13).Font = new Font(((Control)val13).Font.FontFamily, 9f);
					((Control)val13).AutoSize = true;
					((Control)val13).Text = text2;
					((Control)val13).Left = 150;
					((Control)val13).Top = P_1;
					((Control)base.B()).Controls.Add((Control)(object)val13);
				}
				else if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHE() + num9) && ((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHe() + num9))
				{
					Control obj13 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHE() + num9];
					Control obj14 = ((obj13 is Label) ? obj13 : null);
					autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
					obj14.Left = 5 + ((Point)(ref autoScrollPosition)).X;
					int num10 = P_1;
					autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
					obj14.Top = num10 + ((Point)(ref autoScrollPosition)).Y;
					Control obj15 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHe() + num9];
					Control obj16 = ((obj15 is Label) ? obj15 : null);
					autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
					obj16.Left = 150 + ((Point)(ref autoScrollPosition)).X;
					int num11 = P_1;
					autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
					obj16.Top = num11 + ((Point)(ref autoScrollPosition)).Y;
				}
				num9++;
				Font val14 = new Font(((Control)this).Font.FontFamily, 9f);
				try
				{
					val3 = TextRenderer.MeasureText(text2, val14);
					num2 = Math.Max(150 + ((Size)(ref val3)).Width + 20, num2);
				}
				finally
				{
					((System.IDisposable)val14)?.Dispose();
				}
				for (int j = 0; j < text2.Length; j++)
				{
					if (text2[j] == '\n')
					{
						P_1 += 15;
					}
				}
				P_1 += 20;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (P_0)
		{
			Image val15 = Co.A(BXi.Y());
			if (val15 != null)
			{
				PictureBox val16 = new PictureBox();
				((Control)val16).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHF();
				((Control)val16).Left = num2;
				((Control)val16).Top = num;
				((Control)val16).Height = Math.Min(Math.Max(280, P_1 - num), val15.Height);
				if (num + ((Control)val16).Height > P_1)
				{
					P_1 += num + ((Control)val16).Height - P_1;
				}
				((Control)val16).Width = val15.Width * ((Control)val16).Height / val15.Height;
				val16.SizeMode = (PictureBoxSizeMode)1;
				val16.Image = val15;
				((Control)base.B()).Controls.Add((Control)(object)val16);
			}
		}
		else if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHF()))
		{
			Control obj17 = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHF()];
			PictureBox val17 = (PictureBox)(object)((obj17 is PictureBox) ? obj17 : null);
			int num12 = num2;
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			((Control)val17).Left = num12 + ((Point)(ref autoScrollPosition)).X;
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			((Control)val17).Top = num + ((Point)(ref autoScrollPosition)).Y;
			if (num + ((Control)val17).Height > P_1)
			{
				P_1 += num + ((Control)val17).Height - P_1;
			}
		}
		P_1 += 5;
	}

	private void E(object P_0, EventArgs P_1)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		LinkLabel val = (LinkLabel)((P_0 is LinkLabel) ? P_0 : null);
		if (((Control)val).Tag == null)
		{
			return;
		}
		Cn cn = ((Control)val).Tag as Cn;
		if (string.IsNullOrEmpty(cn.Bca))
		{
			return;
		}
		if (cn.Bca.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fG()) || cn.Bca.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fg()))
		{
			try
			{
				Process.Start(x.D(), cn.Bca);
				return;
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHf() + ex.Message, true);
				return;
			}
		}
		Uri val2 = null;
		try
		{
			val2 = new Uri(m.A(BM.Qw, cn.Bca + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fh(), true));
		}
		catch
		{
			val2 = null;
		}
		if (val2 != (Uri)null)
		{
			if (BM.sI)
			{
				BM.QQ.r();
			}
			else
			{
				BM.QQ.s();
			}
			BM.sj.A(val2);
		}
	}

	private void a(bool P_0, ref int P_1)
	{
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		string text = ((!(((Control)this).Parent is Df)) ? BXi.A(false, false) : BXi.E());
		Point autoScrollPosition;
		if (BXJ != null)
		{
			if (!P_0)
			{
				if (BXK != null)
				{
					b();
				}
				if (BXk != null)
				{
					C();
					if (!BXJ.am())
					{
						PictureBox bXk = BXk;
						int num = 5 + ((Control)BXK).Width;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)bXk).Left = num + ((Point)(ref autoScrollPosition)).X;
						PictureBox bXk2 = BXk;
						int num2 = P_1 + 2;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)bXk2).Top = num2 + ((Point)(ref autoScrollPosition)).Y;
					}
					else if (BXi.Q())
					{
						P_1 += 27;
						PictureBox bXk3 = BXk;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)bXk3).Left = 5 + ((Point)(ref autoScrollPosition)).X;
						PictureBox bXk4 = BXk;
						int num3 = P_1 + 2;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)bXk4).Top = num3 + ((Point)(ref autoScrollPosition)).Y;
					}
					else
					{
						PictureBox bXk5 = BXk;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)bXk5).Left = 5 + ((Point)(ref autoScrollPosition)).X;
						PictureBox bXk6 = BXk;
						int num4 = P_1 + 2;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)bXk6).Top = num4 + ((Point)(ref autoScrollPosition)).Y;
					}
					P_1 += 25;
				}
			}
			else if (((SettingOrSpecialObject)BXJ).D() != null)
			{
				if (!BXJ.am())
				{
					BXK = new aP();
					((Control)BXK).Enabled = BXh.C();
					((Control)BXK).Font = new Font(((Control)BXK).Font.FontFamily, 10f, (FontStyle)1);
					((Control)BXK).ForeColor = BM.tf;
					b();
					((Control)BXK).Left = 5;
					((Control)BXK).Top = P_1;
					((Control)BXK).AutoSize = true;
					((Control)BXK).Tag = BXJ.A();
					((CheckBox)BXK).CheckedChanged += new EventHandler(b);
					BXJ.A(new EventHandler(C));
					((Control)base.B()).Controls.Add((Control)(object)BXK);
				}
				else if (BXi.Q())
				{
					Label val = new Label();
					((Control)val).Text = text;
					((Control)val).ForeColor = BM.tf;
					((Control)val).Font = new Font(((Control)val).Font.FontFamily, 10f, (FontStyle)1);
					((Control)val).BackColor = Color.Transparent;
					((Control)val).AutoSize = true;
					((Control)val).Left = 5;
					((Control)val).Top = P_1;
					P_1 += 27;
					((Control)base.B()).Controls.Add((Control)(object)val);
				}
				((Control)base.B()).ResumeLayout(true);
				((Control)this).ResumeLayout(true);
				((Control)this).SuspendLayout();
				((Control)base.B()).SuspendLayout();
				BXk = new PictureBox();
				((Control)BXk).Tag = BXJ.A();
				((Control)BXk).Width = 18;
				((Control)BXk).Height = 18;
				if (BXJ.am())
				{
					((Control)BXk).Left = 5;
				}
				else
				{
					((Control)BXk).Left = 5 + ((Control)BXK).Width;
				}
				((Control)BXk).Top = P_1 + 2;
				BXk.SizeMode = (PictureBoxSizeMode)1;
				((Control)BXk).Click += new EventHandler(c);
				C();
				((Control)base.B()).Controls.Add((Control)(object)BXk);
				((Control)BXk).BringToFront();
				P_1 += 25;
			}
		}
		else if (BXi.Q())
		{
			if (P_0)
			{
				Label val2 = new Label();
				((Control)val2).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeG();
				((Control)val2).Text = text;
				((Control)val2).ForeColor = BM.tf;
				((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 10f * BXn, (FontStyle)1);
				((Control)val2).BackColor = Color.Transparent;
				((Control)val2).AutoSize = true;
				((Control)val2).Left = 5;
				((Control)val2).Top = P_1;
				((Control)base.B()).Controls.Add((Control)(object)val2);
			}
			else if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeG()))
			{
				Control obj = ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeG()];
				Control obj2 = ((obj is Label) ? obj : null);
				autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
				obj2.Left = 5 + ((Point)(ref autoScrollPosition)).X;
				int num5 = P_1;
				autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
				obj2.Top = num5 + ((Point)(ref autoScrollPosition)).Y;
			}
			P_1 += (int)(22f * BXn);
			((Control)base.B()).ResumeLayout(true);
			((Control)this).ResumeLayout(true);
			((Control)this).SuspendLayout();
			((Control)base.B()).SuspendLayout();
		}
	}

	private void B(bool P_0, ref int P_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 != 2)
		{
			P_1 += 5;
		}
		aG aG = null;
		if (P_0)
		{
			aG = new aG();
			((Control)aG).Size = new Size(1184, 350);
			((Control)aG).Left = 5;
			((Control)aG).Top = P_1;
			aG.A(true);
			aG.A(BXi);
			((Control)base.B()).Controls.Add((Control)(object)aG);
		}
		else
		{
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				aG = item as aG;
				if (aG != null)
				{
					if (aG.A() == BXi)
					{
						aG aG2 = aG;
						Point autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)aG2).Left = 5 + ((Point)(ref autoScrollPosition)).X;
						aG aG3 = aG;
						int num = P_1;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)aG3).Top = num + ((Point)(ref autoScrollPosition)).Y;
						break;
					}
					aG = null;
				}
			}
		}
		if (aG != null)
		{
			P_1 += ((Control)aG).Height + 5 + 5;
		}
	}

	private void b(bool P_0, ref int P_1)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 != 2)
		{
			P_1 += 5;
		}
		af af = null;
		if (P_0)
		{
			af = new af();
			((Control)af).Left = 5;
			((Control)af).Top = P_1;
			af.A(BXi);
			((Control)base.B()).Controls.Add((Control)(object)af);
		}
		else
		{
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				af = item as af;
				if (af != null)
				{
					if (af.A() == BXi)
					{
						af af2 = af;
						Point autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)af2).Left = 5 + ((Point)(ref autoScrollPosition)).X;
						af af3 = af;
						int num = P_1;
						autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
						((Control)af3).Top = num + ((Point)(ref autoScrollPosition)).Y;
						break;
					}
					af = null;
				}
			}
		}
		if (af != null)
		{
			P_1 += ((Control)af).Height + 5;
		}
	}

	private void A(bool P_0, ref int P_1, Setting P_2)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		if (P_1 != 2)
		{
			P_1 += 5;
		}
		if (P_0)
		{
			BXL = new ThemedButton();
			((Control)BXL).Font = new Font(((Control)BXL).Font.FontFamily, 10f);
			((Control)BXL).Height = 30;
			((Control)BXL).AutoSize = true;
			A(P_2);
			((Control)BXL).Left = 5;
			((Control)BXL).Top = P_1;
			((Control)BXL).Click += new EventHandler(F);
			((Control)base.B()).Controls.Add((Control)(object)BXL);
			BXl = new ThemedButton();
			((Control)BXl).Font = new Font(((Control)BXl).Font.FontFamily, 10f);
			((Control)BXl).Height = 30;
			((Control)BXl).AutoSize = true;
			((Control)BXl).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHG();
			((Control)base.B()).ResumeLayout(true);
			((Control)this).ResumeLayout(true);
			((Control)this).SuspendLayout();
			((Control)base.B()).SuspendLayout();
			((Control)BXl).Left = ((Control)BXL).Right + 10;
			((Control)BXl).Top = P_1;
			((Control)BXl).Click += new EventHandler(f);
			((Control)base.B()).Controls.Add((Control)(object)BXl);
			BXM = new Label();
			((Control)BXM).BackColor = Color.Transparent;
			((Control)BXM).ForeColor = BM.te;
			((Control)BXM).Font = new Font(((Control)BXM).Font.FontFamily, 10f);
			((Control)BXM).AutoSize = true;
			((Control)base.B()).ResumeLayout(true);
			((Control)this).ResumeLayout(true);
			((Control)this).SuspendLayout();
			((Control)base.B()).SuspendLayout();
			((Control)BXM).Left = ((Control)BXl).Right + 10;
			((Control)BXM).Top = P_1 + 5;
			((Control)base.B()).Controls.Add((Control)(object)BXM);
			if (!BXi.aB())
			{
				BXm = new ThemedButton();
				((Control)BXm).Font = new Font(((Control)BXm).Font.FontFamily, 10f);
				((Control)BXm).Height = 30;
				((Control)BXm).AutoSize = true;
				((Control)BXm).Left = 5;
				((Control)BXm).Top = P_1 + 40;
				((Control)BXm).Click += new EventHandler(e);
				((Control)base.B()).Controls.Add((Control)(object)BXm);
			}
		}
		else if (BXL != null)
		{
			A(P_2);
		}
		if (BXi.Y() == null || BXi.Y().BcF == null)
		{
			if (P_2.Bb())
			{
				((Control)BXM).Text = string.Empty;
				((Control)BXM).Visible = false;
				((Control)BXl).Visible = false;
			}
			else
			{
				((Control)BXM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHg();
				((Control)BXM).Visible = true;
				((Control)BXl).Visible = true;
			}
			if (BXm != null)
			{
				((Control)BXm).Visible = false;
			}
			P_1 += 40;
			return;
		}
		string text = string.Empty;
		if (BXi.aC())
		{
			BXi.G(false);
			if (BXi.aa())
			{
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHH();
			}
		}
		string text2 = string.Empty;
		if (!BXi.Y().BcF.A())
		{
			text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHh();
		}
		((Control)BXM).Text = BXi.Y().BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP + text + text2;
		((Control)BXM).Visible = true;
		((Control)BXl).Visible = true;
		if (BXm != null)
		{
			if (BXi.z())
			{
				((Control)BXm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vl();
			}
			else
			{
				((Control)BXm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHI();
			}
			((Control)BXm).Visible = true;
			P_1 += 75;
		}
		else
		{
			P_1 += 40;
		}
	}

	private void A(Setting P_0)
	{
		if (P_0 != null && BXi != null)
		{
			((Control)BXL).Text = Cn.A(((SettingOrSpecialObject)P_0).A(), BXi, P_0);
		}
	}

	private void e(object P_0, EventArgs P_1)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		bool flag = false;
		if (BXi.aC() && !BXi.z())
		{
			string text = ((!(((Control)this).Parent is Df)) ? BXi.A(false, false) : BXi.E());
			string bsP = BXi.Y().BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP;
			if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Concat(new string[5]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHi(),
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHJ(),
				bsP,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ws()
			}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHj(), (MessageBoxButtons)1, (MessageBoxIcon)48) != 1)
			{
				return;
			}
			BXh.C(BXh.aWS);
			BXh.M();
			Cursor.Current = Cursors.WaitCursor;
			BXi.Y().BcF.A(BXi);
			Cursor.Current = Cursors.WaitCursor;
			BXh.A(true);
			BXh.c(BXh.aWS);
		}
		else
		{
			BXi.G(!BXi.z());
			flag = !BXi.z();
		}
		d();
		if (flag && BM.QQ.rL.A().a().Count != 0 && BM.QQ.rL.A(BXi.e()) != null)
		{
			BM.QQ.rL.A(BXi.Y().BcF, BM.QQ.rL.A().a());
		}
	}

	private void F(object P_0, EventArgs P_1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		BR bR = new BR(BXi);
		if ((int)((Form)bR).ShowDialog((IWin32Window)(object)this) == 1)
		{
			d();
		}
		((Component)bR).Dispose();
	}

	private void f(object P_0, EventArgs P_1)
	{
		BXi.A().a();
		Setting setting = BXh.A(BXi.W());
		setting.J(true);
		BXi.y();
		BXi.i(false);
		BXi.G(false);
		BM.b(setting.A());
		BXi.A().B();
		d();
	}

	private void d()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		B();
		if (BXL != null)
		{
			((Control)BXL).Click -= new EventHandler(F);
		}
		if (BXl != null)
		{
			((Control)BXl).Click -= new EventHandler(f);
		}
		if (BXm != null)
		{
			((Control)BXm).Click -= new EventHandler(e);
		}
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is DA || val is DF)
			{
				val.VisibleChanged -= new EventHandler(d);
				val.Layout -= new LayoutEventHandler(A);
			}
			if (val is LinkLabel)
			{
				val.Click -= new EventHandler(E);
			}
		}
		while (((ArrangedElementCollection)((Control)base.B()).Controls).Count != 0)
		{
			q.A(((Control)base.B()).Controls[0]);
		}
		if (BXO != Rectangle.Empty)
		{
			BXO = new Rectangle(((Control)this).Location, ((Control)this).Size);
		}
		A(true);
		if (BM.QQ.rL.A().a().Count != 0)
		{
			BM.QQ.rL.A(false, true, true, true);
			BM.QQ.rL.B(false);
			if (BM.Qn != null)
			{
				BM.QQ.rL.b(false);
			}
		}
	}

	private List<MenuNode> E()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		List<MenuNode> val = new List<MenuNode>();
		bool flag = true;
		Enumerator<MenuNode> enumerator = BXi.c().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.i() != 0)
				{
					flag = false;
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (flag)
		{
			enumerator = BXi.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					if (!current.J())
					{
						if (val.Count == 0)
						{
							val.Add(current);
						}
						else
						{
							val.Insert(0, current);
						}
						continue;
					}
					for (int i = 0; i <= val.Count; i++)
					{
						if (i < val.Count)
						{
							MenuNode menuNode = val[i];
							if (current.I() < menuNode.I())
							{
								val.Insert(i, current);
								break;
							}
							continue;
						}
						val.Add(current);
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		else
		{
			enumerator = BXi.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current2 = enumerator.Current;
					val.Add(current2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		return val;
	}

	private bool e()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (BXi.C() != null)
		{
			MenuNode menuNode = BXi.C();
			bool flag2 = false;
			do
			{
				if (menuNode.K())
				{
					flag = true;
					break;
				}
				if (menuNode.C() != null)
				{
					menuNode = menuNode.C();
				}
				else
				{
					flag2 = true;
				}
			}
			while (!flag2);
		}
		if (!flag)
		{
			Enumerator<MenuNode> enumerator = BXi.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.k())
					{
						if (BXN)
						{
							flag = true;
						}
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		return flag;
	}

	private void A(int P_0, int P_1, int P_2, int P_3, Rectangle P_4, List<List<Rectangle>> P_5, List<int> P_6, ref int P_7, ref int P_8)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (P_2 == -1 || P_3 == -1 || !(P_4 != Rectangle.Empty))
		{
			return;
		}
		Rectangle val2;
		if (P_1 == P_3)
		{
			P_7 = ((Rectangle)(ref P_4)).Left;
			int num = ((((Rectangle)(ref P_4)).Width != 0 && ((Rectangle)(ref P_4)).Height != 0) ? 5 : 0);
			P_8 = ((Rectangle)(ref P_4)).Bottom + num;
		}
		else if (P_1 != 0)
		{
			int num2 = 0;
			for (int i = P_0; i < P_5.Count; i++)
			{
				List<Rectangle> val = P_5[i];
				int count = val.Count;
				if (count != 0 && !P_6.Contains(i))
				{
					int num3 = Math.Min(P_1 - 1, count - 1);
					int num4 = num2;
					val2 = val[num3];
					num2 = Math.Max(num4, ((Rectangle)(ref val2)).Right);
				}
			}
			int num5 = ((num2 > 5) ? 5 : 0);
			P_7 = num2 + num5;
			if (P_0 == 0 || P_0 >= P_5.Count)
			{
				return;
			}
			int num6 = 0;
			for (int j = 0; j < P_0; j++)
			{
				Enumerator<Rectangle> enumerator = P_5[j].GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Rectangle current = enumerator.Current;
						num6 = Math.Max(num6, ((Rectangle)(ref current)).Bottom);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			P_8 = num6 + 5;
		}
		else if (P_0 == 0)
		{
			val2 = P_5[P_5.Count - 1][0];
			P_8 = ((Rectangle)(ref val2)).Bottom + 5;
		}
		else
		{
			if (P_2 >= P_5.Count)
			{
				return;
			}
			List<Rectangle> obj = P_5[P_5.Count - 1];
			int num7 = 0;
			Enumerator<Rectangle> enumerator = obj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Rectangle current2 = enumerator.Current;
					num7 = Math.Max(num7, ((Rectangle)(ref current2)).Bottom);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			P_8 = num7 + 5;
		}
	}

	private void A(bool P_0, MenuNode P_1, int P_2, int P_3, ref Rectangle P_4)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHK() + P_1.e();
		Df df = null;
		if (P_0)
		{
			df = new Df(BXh, BXI, Rectangle.Empty, false, true, false);
			df.A(P_1);
			((Control)df).Name = text;
		}
		else if (((Control)base.B()).Controls.ContainsKey(text))
		{
			df = ((Control)base.B()).Controls[text] as Df;
		}
		if (df != null)
		{
			Df df2 = df;
			Point autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			((Control)df2).Left = P_2 + ((Point)(ref autoScrollPosition)).X;
			Df df3 = df;
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			((Control)df3).Top = P_3 + ((Point)(ref autoScrollPosition)).Y;
			if (P_0)
			{
				((Control)base.B()).Controls.Add((Control)(object)df);
			}
			df.A(P_0);
			Size size = ((Control)df).Size;
			int width = ((Size)(ref size)).Width;
			size = ((Control)df).Size;
			P_4 = new Rectangle(P_2, P_3, width, ((Size)(ref size)).Height);
		}
	}

	private void a(bool P_0, MenuNode P_1, int P_2, int P_3, ref Rectangle P_4)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHk() + P_1.e();
		cw cw = null;
		if (P_0)
		{
			cw = new cw(BXh, BXI, Rectangle.Empty, false, false);
			cw.A(P_1);
			((Control)cw).Name = text;
		}
		else if (((Control)base.B()).Controls.ContainsKey(text))
		{
			cw = ((Control)base.B()).Controls[text] as cw;
		}
		if (cw != null)
		{
			cw cw2 = cw;
			Point autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			((Control)cw2).Left = P_2 + ((Point)(ref autoScrollPosition)).X;
			cw cw3 = cw;
			autoScrollPosition = ((ScrollableControl)base.B()).AutoScrollPosition;
			((Control)cw3).Top = P_3 + ((Point)(ref autoScrollPosition)).Y;
			if (P_0)
			{
				((Control)base.B()).Controls.Add((Control)(object)cw);
				ch.Bhl = cw;
			}
			cw.A(P_0);
			Size size = ((Control)cw).Size;
			int width = ((Size)(ref size)).Width;
			size = ((Control)cw).Size;
			P_4 = new Rectangle(P_2, P_3, width, ((Size)(ref size)).Height);
		}
	}

	public Control A(DataIdAndAttrId P_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is Y)
			{
				Control val2 = (val as Y).A(P_0);
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		return null;
	}

	public Control A()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		int num = 2147483647;
		int num2 = 2147483647;
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is Y)
			{
				num = Math.Min(num, val.Left);
				num2 = Math.Min(num2, val.Top);
			}
		}
		foreach (Control item2 in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val2 = item2;
			if (val2 is ch)
			{
				ch ch = val2 as ch;
				if (((Control)ch).Focused)
				{
					return (Control)(object)ch;
				}
			}
			else if (val2.Left == num && val2.Top == num2 && val2 is Y)
			{
				Control val3 = (val2 as Y).A();
				if (val3 != null)
				{
					return val3;
				}
			}
		}
		return null;
	}

	[SpecialName]
	internal ch F()
	{
		if (((Control)base.B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgS()))
		{
			return ((Control)base.B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgS()] as ch;
		}
		return null;
	}

	private void G(object P_0, EventArgs P_1)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		BP num = (((TabControl)BM.QQ.rl).SelectedTab as ae).A();
		int selectedIndex = ((TabControl)BM.QQ.rl).SelectedIndex;
		if (num == BP.ua || BM.QQ.rl.A(selectedIndex) != this)
		{
			q.A((Control)(object)this);
			BM.QQ.rl.a(false);
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfk(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfL(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void A(object P_0, CancelEventArgs P_1)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		if (ch.Bhk != null && ((Control)ch.Bhk).CanFocus)
		{
			P_1.Cancel = true;
		}
		else
		{
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				ToolStripMenuItem val = item;
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfn())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
					break;
				}
			}
		}
	}

	private ContextMenuStrip f()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		if (Bz.A())
		{
			return null;
		}
		ContextMenuStrip val = new ContextMenuStrip
		{
			BackColor = BM.tG,
			ForeColor = BM.te
		};
		((ToolStripDropDown)val).Opening += new CancelEventHandler(A);
		ToolStripMenuItem val2 = new ToolStripMenuItem();
		((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfn();
		((ToolStripItem)val2).Click += new EventHandler(G);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
		return val;
	}

	internal void A(string P_0, int P_1, int P_2)
	{
		List<string> val = new List<string>();
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHL());
		int num = ((Control)this).Left - P_1;
		int num2 = ((Control)this).Top - P_2;
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
		if (BXi != null && BXi.j(false).Count != 0)
		{
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHl() + Enumerable.First<DataIdAndAttrId>((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)BXi.j(false)).DataId);
		}
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
		File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
	}

	internal int A(StreamReader P_0)
	{
		string text;
		if ((text = ((TextReader)P_0).ReadLine()) != null && text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHl()))
		{
			return int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHl().Length));
		}
		return 0;
	}
}
