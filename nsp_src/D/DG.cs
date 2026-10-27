using System;
using System.Collections;
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
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace D;

internal class DG : cq, Y
{
	private new delegate void A(object P_0, EventArgs P_1);

	private new delegate void a(object P_0, EventArgs P_1);

	private Framework BXP;

	private Framework BXp;

	private UserLog BXQ;

	private bool BXq;

	private Rectangle BXR;

	private bool BXr;

	private bool BXS;

	private int BXs;

	private Setting BXT;

	private Setting BXt;

	private Setting BXU;

	private Setting BXu;

	private ThemedButton BXV = new ThemedButton();

	private Label BXv = new Label();

	private Label BXW = new Label();

	private Label BXw = new Label();

	private List<ThemedComboBox> BXX = new List<ThemedComboBox>();

	private List<Label> BXx = new List<Label>();

	private ab BXY = new ab();

	private bool BXy;

	internal DG(UserLog P_0, Framework P_1, Framework P_2, Rectangle P_3, bool P_4)
		: base(P_3, P_4, false)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		BXP = P_1;
		BXp = P_2;
		BXQ = P_0;
		BXq = BXP.A(BXQ.DataIdOfChannelRateSetting).Ba() == 1;
		BM.QQ.B(new EventHandler(B));
		BXR = P_3;
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		B();
		try
		{
			BM.QQ.b(new EventHandler(B));
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private new void B()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		try
		{
			((Control)BXV).Click -= new EventHandler(D);
			Enumerator<ThemedComboBox> enumerator = BXX.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ComboBox)enumerator.Current).SelectedIndexChanged -= new EventHandler(c);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (BXT != null)
			{
				BXT.a(new EventHandler(b));
			}
			if (BXt != null)
			{
				BXt.a(new EventHandler(C));
			}
		}
		catch
		{
		}
	}

	internal new void b()
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		BXr = BXP.B() && BXP.b() && BXP.A(BXQ.DataIdOfChannelListSetting).J();
		BXS = BXp != null && BXp.B() && BXp.b() && BXp.A(BXQ.DataIdOfChannelListSetting).J();
		if ((BM.QO != BM.b.BpG || BXp == null) ? BXr : BXS)
		{
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHM();
			((Control)val).ForeColor = BM.te;
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = 5;
			((Control)val).Top = 5;
			((Control)base.B()).Controls.Add((Control)(object)val);
		}
		else
		{
			BXT = BXP.A(BXQ.DataIdOfChannelListSetting);
			BXt = BXP.A(BXQ.DataIdOfChannelRateSetting);
			if (BXp != null)
			{
				BXU = BXp.A(BXQ.DataIdOfChannelListSetting);
				BXu = BXp.A(BXQ.DataIdOfChannelRateSetting);
			}
			((Control)BXw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHm();
			((Control)BXw).ForeColor = BM.te;
			((Control)BXw).Height = 16;
			((Control)BXw).Width = 200;
			int left = 5;
			int num = 5;
			if (BXq)
			{
				((Control)BXY).BackColor = BM.tH;
				((Control)BXY).ForeColor = BM.te;
				((ListView)BXY).FullRowSelect = false;
				((ListView)BXY).HeaderStyle = (ColumnHeaderStyle)1;
				((ListView)BXY).UseCompatibleStateImageBehavior = false;
				((ListView)BXY).View = (View)1;
				ColumnHeader val2 = new ColumnHeader();
				val2.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wk();
				((ListView)BXY).Columns.Add(val2);
				((Control)base.B()).Controls.Add((Control)(object)BXY);
				((Control)BXw).Left = left;
				((Control)BXw).Top = num + 3;
				((Control)base.B()).Controls.Add((Control)(object)BXw);
				num = ((Control)BXw).Bottom;
				ThemedComboBox themedComboBox = new ThemedComboBox();
				((Control)themedComboBox).Enabled = BXP.C();
				Setting setting = ((BM.QO != BM.b.BpG || BXu == null) ? BXt : BXu);
				int selectedIndex = 0;
				int num2 = setting.ax();
				List<Setting.ListItems.A> val3 = setting.d(0);
				for (int i = 0; i < val3.Count; i++)
				{
					((ComboBox)themedComboBox).Items.Add((object)val3[i].bBV);
					if (val3[i].bBv == num2)
					{
						selectedIndex = i;
					}
				}
				((ListControl)themedComboBox).SelectedIndex = selectedIndex;
				((ComboBox)themedComboBox).DropDownStyle = (ComboBoxStyle)2;
				((Control)themedComboBox).Tag = 0;
				((Control)themedComboBox).Left = left;
				((Control)themedComboBox).Top = num;
				((Control)themedComboBox).Width = 200;
				((ComboBox)themedComboBox).SelectedIndexChanged += new EventHandler(c);
				((Control)base.B()).Controls.Add((Control)(object)themedComboBox);
				num = ((Control)themedComboBox).Bottom + 10;
				BXX.Add(themedComboBox);
			}
			((Control)BXV).Enabled = BXP.C();
			((Control)BXV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHN();
			((Control)BXV).Left = left;
			((Control)BXV).Top = num;
			((Control)BXV).Width = 180;
			((Control)BXV).Height = 25;
			((Control)BXV).Click += new EventHandler(D);
			((Control)base.B()).Controls.Add((Control)(object)BXV);
			num = ((Control)BXV).Bottom;
			((Control)BXv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHn();
			((Control)BXv).ForeColor = BM.te;
			((Control)BXv).Left = left;
			((Control)BXv).Top = num + 3;
			((Control)BXv).Width = 500;
			((Control)BXv).Height = 16;
			((Control)base.B()).Controls.Add((Control)(object)BXv);
			num = ((Control)BXv).Bottom + 10;
			((Control)BXW).ForeColor = BM.te;
			((Control)BXW).Left = left;
			((Control)BXW).Top = num + 3;
			((Control)BXW).Height = 16;
			((Control)BXW).Width = 400;
			((Control)base.B()).Controls.Add((Control)(object)BXW);
			if (BXq)
			{
				num = ((Control)BXW).Bottom + 10;
			}
			else
			{
				left = ((Control)BXW).Right;
				((Control)BXw).Left = left;
				((Control)BXw).Top = num + 3;
				((Control)base.B()).Controls.Add((Control)(object)BXw);
				left = 5;
				num = ((Control)BXw).Bottom + 10;
			}
			BXs = num;
			if (BM.QO == BM.b.BpG && BXp != null)
			{
				A(BXp, this, BXQ);
			}
			else
			{
				A(BXP, this, BXQ);
			}
			BXT.A(new EventHandler(b));
			BXt.A(new EventHandler(C));
			C();
		}
		if (BXR != Rectangle.Empty)
		{
			((Control)this).Width = ((Rectangle)(ref BXR)).Width;
			((Control)this).Height = ((Rectangle)(ref BXR)).Height;
			((Control)this).Left = ((Rectangle)(ref BXR)).Left;
			((Control)this).Top = ((Rectangle)(ref BXR)).Top;
		}
		else
		{
			int num3 = 0;
			int num4 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val4 = item;
				num3 = Math.Max(num3, val4.Right + 10);
				num4 = Math.Max(num4, val4.Bottom + 30);
			}
			((Control)this).Width = num3;
			((Control)this).Height = num4;
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
	}

	private void B(object P_0, EventArgs P_1)
	{
		bool flag = false;
		switch (BM.QO)
		{
		case BM.b.BpF:
			flag = BXr != BXS;
			break;
		case BM.b.Bpf:
			flag = false;
			break;
		case BM.b.BpG:
			flag = BXr != BXS;
			break;
		}
		if (flag)
		{
			B();
			((Control)base.B()).Controls.Clear();
			b();
		}
		else if ((BM.QO != BM.b.BpG && !BXr) || (BM.QO == BM.b.BpG && !BXS))
		{
			c();
			if (BM.QO == BM.b.BpG && BXp != null)
			{
				A(BXp, this, BXQ);
			}
			else
			{
				A(BXP, this, BXQ);
			}
			C();
		}
	}

	private new void C()
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!BXq)
		{
			return;
		}
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHO();
		string text2 = ((Control)BXW).Text;
		if ((BM.QO != BM.b.BpG && !BXr) || (BM.QO == BM.b.BpG && !BXS))
		{
			if (BXU != null && !BXT.A(BXU))
			{
				((Control)BXW).ForeColor = BM.tD;
				if (!text2.EndsWith(text))
				{
					Label bXW = BXW;
					((Control)bXW).Text = ((Control)bXW).Text + text;
				}
			}
			else
			{
				((Control)BXW).ForeColor = BM.te;
				if (text2.EndsWith(text))
				{
					((Control)BXW).Text = text2.Substring(0, text2.IndexOf(text));
				}
			}
			if (BXu != null && !BXt.A(BXu))
			{
				((Control)BXX[0]).BackColor = BM.tD;
			}
			else
			{
				((Control)BXX[0]).BackColor = BM.to;
			}
		}
		else
		{
			((Control)BXW).ForeColor = BM.te;
			if (text2.EndsWith(text))
			{
				((Control)BXW).Text = text2.Substring(0, text2.IndexOf(text));
			}
			((Control)BXX[0]).BackColor = BM.to;
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = b;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		bool flag = ((Control)base.B()).Controls.Contains((Control)(object)BXY);
		for (int i = 0; i < BXT.av()[2]; i++)
		{
			if (BXT.m(i) != 0 && BXT.m(i) != BXT.aU())
			{
				if (flag && i < ((ListView)BXY).Items.Count)
				{
					Setting setting = BXP.A(BXT.m(i));
					if (((ListView)BXY).Items[i].Tag != setting)
					{
						A(BXP, this, BXQ);
						break;
					}
					continue;
				}
				if (!flag && i < BXx.Count)
				{
					Setting setting2 = BXP.A(BXT.m(i));
					if (((Control)BXx[i]).Tag != setting2)
					{
						A(BXP, this, BXQ);
						break;
					}
					continue;
				}
				A(BXP, this, BXQ);
				break;
			}
			if (flag)
			{
				if (((ListView)BXY).Items.Count != i)
				{
					A(BXP, this, BXQ);
				}
				break;
			}
			if (!flag)
			{
				if (BXx.Count != i)
				{
					A(BXP, this, BXQ);
				}
				break;
			}
		}
		C();
	}

	private void C(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = C;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO != BM.b.BpG)
		{
			c();
			C();
		}
	}

	private void c()
	{
		Setting setting;
		Setting setting2;
		if (BM.QO == BM.b.BpG && BXU != null && BXu != null)
		{
			setting = BXU;
			setting2 = BXu;
		}
		else
		{
			setting = BXT;
			setting2 = BXt;
		}
		if (BXq)
		{
			if (((ComboBox)BXX[0]).DroppedDown)
			{
				return;
			}
			int num = -1;
			int num2 = setting2.ax();
			List<Setting.ListItems.A> val = setting2.d(0);
			for (int i = 0; i < val.Count; i++)
			{
				if (val[i].bBv == num2)
				{
					num = i;
					break;
				}
			}
			if (((ListControl)BXX[0]).SelectedIndex != num && num != -1)
			{
				((ListControl)BXX[0]).SelectedIndex = num;
			}
			return;
		}
		for (int j = 0; j < setting.av()[2] && setting.m(j) != 0 && setting.m(j) != setting.aU(); j++)
		{
			if (j >= BXX.Count || ((ComboBox)BXX[j]).DroppedDown)
			{
				continue;
			}
			int num3 = -1;
			int num4 = setting2.m(j);
			List<Setting.ListItems.A> val2 = setting2.d(0);
			for (int k = 0; k < val2.Count; k++)
			{
				if (val2[k].bBv == num4)
				{
					num3 = k;
					break;
				}
			}
			if (((ListControl)BXX[j]).SelectedIndex != num3 && num3 != -1)
			{
				((ListControl)BXX[j]).SelectedIndex = num3;
			}
		}
	}

	private static void A(Framework P_0, DG P_1, UserLog P_2)
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		if (P_1 == null || (BM.QO != BM.b.BpG && P_1.BXr) || (BM.QO == BM.b.BpG && P_1.BXS))
		{
			return;
		}
		int left = 5;
		int num = P_1.BXs;
		bool flag = P_0.A(P_2.DataIdOfChannelRateSetting).Ba() == 1;
		((Control)P_1).SuspendLayout();
		((Control)((cq)P_1).B()).SuspendLayout();
		Setting setting;
		Setting setting2;
		if (BM.QO == BM.b.BpG && P_1.BXU != null && P_1.BXu != null)
		{
			setting = P_1.BXU;
			setting2 = P_1.BXu;
			((Control)P_1.BXV).Enabled = false;
			if (flag && P_1.BXX.Count == 1)
			{
				((Control)P_1.BXX[0]).Enabled = false;
			}
		}
		else
		{
			setting = P_1.BXT;
			setting2 = P_1.BXt;
			((Control)P_1.BXV).Enabled = P_0.C();
			if (flag && P_1.BXX.Count == 1)
			{
				((Control)P_1.BXX[0]).Enabled = P_0.C();
			}
		}
		int num2 = 0;
		for (int i = 0; i < setting.av()[2] && setting.m(i) != 0 && setting.m(i) != setting.aU(); i++)
		{
			num2++;
		}
		((Control)P_1.BXW).Text = num2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHo();
		if (!flag)
		{
			Enumerator<Label> enumerator = P_1.BXx.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Label current = enumerator.Current;
					((Control)((cq)P_1).B()).Controls.Remove((Control)(object)current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		else
		{
			((ListView)P_1.BXY).BeginUpdate();
			((ListView)P_1.BXY).Items.Clear();
		}
		P_1.BXx.Clear();
		if (!flag)
		{
			Enumerator<ThemedComboBox> enumerator2 = P_1.BXX.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					ThemedComboBox current2 = enumerator2.Current;
					((ComboBox)current2).SelectedIndexChanged -= new EventHandler(P_1.c);
					((Control)((cq)P_1).B()).Controls.Remove((Control)(object)current2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			P_1.BXX.Clear();
		}
		List<ListViewItem> val = new List<ListViewItem>();
		for (int j = 0; j < setting.av()[2] && setting.m(j) != 0 && setting.m(j) != setting.aU(); j++)
		{
			Setting setting3 = P_0.A(setting.m(j));
			if (flag)
			{
				if (((Control)P_1.BXY).Left == 0 || ((Control)P_1.BXY).Top == 0)
				{
					((Control)P_1.BXY).Left = left;
					((Control)P_1.BXY).Top = num;
					((Control)P_1.BXY).Width = 300;
					((Control)P_1.BXY).Height = 200;
					((ListView)P_1.BXY).Columns[0].Width = ((Control)P_1.BXY).Width - 25;
				}
				string text = ((setting3 == null) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHP() : ((SettingOrSpecialObject)setting3).A(bz.aYt));
				ListViewItem val2 = new ListViewItem(new string[1] { text });
				val2.Tag = setting3;
				val.Add(val2);
				continue;
			}
			Label val3 = new Label();
			((Control)val3).Tag = setting3;
			if (setting3 != null)
			{
				((Control)val3).Text = ((SettingOrSpecialObject)setting3).A(bz.aYt);
			}
			else
			{
				((Control)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHP();
			}
			((Control)val3).ForeColor = BM.te;
			((Control)val3).Left = left;
			((Control)val3).Top = num + 3;
			((Control)val3).Height = 16;
			((Control)val3).Width = 400;
			((Control)((cq)P_1).B()).Controls.Add((Control)(object)val3);
			P_1.BXx.Add(val3);
			left = ((Control)val3).Right;
			ThemedComboBox themedComboBox = new ThemedComboBox();
			int selectedIndex = 0;
			int num3 = setting2.m(j);
			List<Setting.ListItems.A> val4 = setting2.d(0);
			for (int k = 0; k < val4.Count; k++)
			{
				((ComboBox)themedComboBox).Items.Add((object)val4[k].bBV);
				if (val4[k].bBv == num3)
				{
					selectedIndex = k;
				}
			}
			((ListControl)themedComboBox).SelectedIndex = selectedIndex;
			((ComboBox)themedComboBox).DropDownStyle = (ComboBoxStyle)2;
			((Control)themedComboBox).Tag = j;
			((Control)themedComboBox).Left = left;
			((Control)themedComboBox).Top = num;
			((Control)themedComboBox).Width = 200;
			((ComboBox)themedComboBox).SelectedIndexChanged += new EventHandler(P_1.c);
			((Control)((cq)P_1).B()).Controls.Add((Control)(object)themedComboBox);
			P_1.BXX.Add(themedComboBox);
			num = ((Control)themedComboBox).Bottom;
			left = 5;
		}
		if (flag)
		{
			((ListView)P_1.BXY).Items.AddRange(val.ToArray());
			((ListView)P_1.BXY).EndUpdate();
			P_1.BXY.a();
		}
		if (P_1.BXR == Rectangle.Empty)
		{
			int num4 = 0;
			int num5 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)((cq)P_1).B()).Controls)
			{
				Control val5 = item;
				num4 = Math.Max(num4, val5.Right + 10);
				num5 = Math.Max(num5, val5.Bottom + 30);
			}
			((Control)P_1).Width = num4;
			((Control)P_1).Height = num5;
		}
		((Control)((cq)P_1).B()).ResumeLayout(true);
		((Control)P_1).ResumeLayout(true);
	}

	private void c(object P_0, EventArgs P_1)
	{
		if (BXy)
		{
			BXy = false;
		}
		else
		{
			if (BM.QO == BM.b.BpG)
			{
				return;
			}
			ThemedComboBox themedComboBox = P_0 as ThemedComboBox;
			int selectedIndex = ((ListControl)themedComboBox).SelectedIndex;
			Setting setting = BXP.A(BXQ.DataIdOfChannelRateSetting);
			if (((SettingOrSpecialObject)setting).j())
			{
				Ck ck = BM.aM();
				ck?.A(setting.A());
				setting.a((int)((Control)themedComboBox).Tag, setting.d(0)[selectedIndex].bBv, true);
				ck?.B();
				BM.b(setting.A());
				return;
			}
			int num = setting.m((int)((Control)themedComboBox).Tag);
			List<Setting.ListItems.A> val = setting.d(0);
			for (int i = 0; i < val.Count; i++)
			{
				if (val[i].bBv == num)
				{
					BXy = true;
					((ListControl)themedComboBox).SelectedIndex = i;
					break;
				}
			}
		}
	}

	private void D(object P_0, EventArgs P_1)
	{
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		List<int> val = new List<int>();
		for (int i = 0; i < BXT.av()[2] && BXT.m(i) != 0 && BXT.m(i) != BXT.aU(); i++)
		{
			val.Add(BXT.m(i));
		}
		List<int> val2 = BY.A((IWin32Window)(object)BM.QQ, BXP, val, BXT.av()[2]);
		if (val2 == null || !((SettingOrSpecialObject)BXT).j())
		{
			return;
		}
		Ck ck = BM.aM();
		ck?.A(BXT.A());
		BXT.az();
		for (int j = 0; j < val2.Count; j++)
		{
			BXT.a(j, val2[j], true);
			if (BXq)
			{
				continue;
			}
			bool flag = false;
			for (int k = 0; k < val.Count; k++)
			{
				if (val[k] == val2[j])
				{
					int num = BXt.m(k);
					BXt.a(j, num, true);
					flag = true;
					break;
				}
			}
			if (!flag && BXt.m(j) == 0)
			{
				BXt.a(j, 50, true);
			}
		}
		int num2 = BXT.aU();
		for (int l = val2.Count; l < BXT.av()[2]; l++)
		{
			BXT.a(l, num2, true);
		}
		BXT.i(true);
		if (!BXq)
		{
			int num3 = BXt.aU();
			for (int m = val2.Count; m < BXt.av()[2]; m++)
			{
				BXt.a(m, num3, true);
			}
		}
		ck?.B();
		BM.b(BXT.A());
		A(BXP, this, BXQ);
	}

	public Control A(DataIdAndAttrId P_0)
	{
		if (((Control)BXY).Visible && ((Control)base.B()).Controls.Contains((Control)(object)BXY) && BXT != null && P_0.DataId == BXT.A())
		{
			return (Control)(object)BXY;
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
}
internal class Dg : cq, Y
{
	private new delegate void A(object P_0, EventArgs P_1);

	private new delegate void a(object P_0, EventArgs P_1);

	private new delegate void B(object P_0, EventArgs P_1);

	private const int BXZ = 140;

	private const int BXz = 260;

	private const int BxA = 210;

	private Framework Bxa;

	private Framework BxB;

	private UserLog Bxb;

	private Rectangle BxC;

	private bool Bxc;

	private bool BxD;

	private Setting Bxd;

	private Setting BxE;

	private Setting Bxe;

	private Setting BxF;

	private ct Bxf;

	private Label BxG = new Label();

	private Label Bxg = new Label();

	private PictureBox BxH = new PictureBox();

	private ThemedTextBox Bxh = new ThemedTextBox();

	private ThemedButton BxI = new ThemedButton();

	private Timer Bxi = new Timer();

	private List<ThemedComboBox> BxJ = new List<ThemedComboBox>();

	private List<ab> Bxj = new List<ab>();

	private List<Label> BxK = new List<Label>();

	private List<ThemedButton> Bxk = new List<ThemedButton>();

	private List<ThemedButton> BxL = new List<ThemedButton>();

	private ab Bxl = new ab();

	private Label BxM = new Label();

	private SortedList<string, Setting> Bxm = new SortedList<string, Setting>();

	private List<int> BxN = new List<int>();

	private int Bxn;

	internal Dg(UserLog P_0, Framework P_1, Framework P_2, Rectangle P_3, bool P_4)
		: base(P_3, P_4, false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		Bxa = P_1;
		BxB = P_2;
		Bxb = P_0;
		BM.QQ.B(new EventHandler(d));
		BxC = P_3;
		BxH.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		((Control)BxH).Width = 24;
		((Control)BxH).Height = 24;
		((Control)Bxh).TextChanged += new EventHandler(c);
		((Control)Bxh).BackColor = BM.to;
		((Control)Bxh).ForeColor = BM.te;
		((Control)BxI).Click += new EventHandler(C);
		((Control)BxI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
		((Control)BxI).Font = new Font(((Control)BxI).Font.FontFamily, 8f, (FontStyle)1);
		((Control)BxI).Width = 22;
		Bxi.Interval = 400;
		Bxi.Tick += new EventHandler(D);
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		B();
		try
		{
			BM.QQ.b(new EventHandler(d));
			((Control)Bxh).TextChanged -= new EventHandler(c);
			((Control)BxI).Click -= new EventHandler(C);
			Bxi.Tick -= new EventHandler(D);
			((Component)Bxi).Dispose();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private new void B()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		try
		{
			if (Bxf != null)
			{
				Bxf.b().a(new EventHandler(G));
			}
			Enumerator<ThemedButton> enumerator = Bxk.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Click -= new EventHandler(B);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = BxL.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Click -= new EventHandler(b);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<ThemedComboBox> enumerator2 = BxJ.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					((ComboBox)enumerator2.Current).SelectedIndexChanged -= new EventHandler(f);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			if (Bxd != null)
			{
				Bxd.a(new EventHandler(E));
			}
			if (BxE != null)
			{
				BxE.a(new EventHandler(e));
				((SettingOrSpecialObject)BxE).a(new EventHandler(F));
			}
			((ListView)Bxl).ItemSelectionChanged -= new ListViewItemSelectionChangedEventHandler(A);
			Enumerator<ab> enumerator3 = Bxj.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					((ListView)enumerator3.Current).ItemSelectionChanged -= new ListViewItemSelectionChangedEventHandler(A);
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			if (((Control)this).Parent != null && ((Control)this).Parent is aF)
			{
				((Control)this).Parent.Layout -= new LayoutEventHandler(A);
			}
		}
		catch
		{
		}
	}

	internal new void b()
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected O, but got Unknown
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected O, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected O, but got Unknown
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		Bxc = Bxa.B() && Bxa.b() && Bxa.A(Bxb.DataIdOfChannelListSetting).J();
		BxD = BxB != null && BxB.B() && BxB.b() && BxB.A(Bxb.DataIdOfChannelListSetting).J();
		if ((BM.QO != BM.b.BpG || BxB == null) ? Bxc : BxD)
		{
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHM();
			((Control)val).ForeColor = BM.te;
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = 5;
			((Control)val).Top = 5;
			((Control)base.B()).Controls.Add((Control)(object)val);
		}
		else
		{
			Bxd = Bxa.A(Bxb.DataIdOfChannelListSetting);
			BxE = Bxa.A(Bxb.DataIdOfChannelRateSetting);
			if (BxB != null)
			{
				Bxe = BxB.A(Bxb.DataIdOfChannelListSetting);
				BxF = BxB.A(Bxb.DataIdOfChannelRateSetting);
			}
			Framework framework = ((BM.QO != BM.b.BpG || Bxe == null) ? Bxa : BxB);
			Bxm.Clear();
			List<string> val2 = new List<string>();
			Enumerator<Setting> enumerator = framework.aWt.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (!((SettingOrSpecialObject)current).l() || !current.aC() || current.al() || !PortFunction.A(current))
					{
						continue;
					}
					string text = ((SettingOrSpecialObject)current).A(true);
					if (Bxm.ContainsKey(text))
					{
						if (!val2.Contains(text))
						{
							val2.Add(text);
						}
					}
					else
					{
						Bxm.Add(text, current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (val2.Count != 0)
			{
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yo();
				Enumerator<string> enumerator2 = val2.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						text2 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy() + current2;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				bE.A((IWin32Window)(object)BM.QQ, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			int num = 5;
			int top = 5;
			Setting setting = Bxa.A(12201);
			if (setting != null)
			{
				ct bxf = Bxf;
				Bxf = new ct(setting.C(), Bxa, BxB, null, false);
				((Control)Bxf).Enabled = Bxa.C();
				setting.a(new EventHandler(G));
				setting.A(new EventHandler(G));
				((Control)Bxf).Left = num;
				((Control)Bxf).Top = top;
				((Control)base.B()).Controls.Add((Control)(object)Bxf);
				top = ((Control)Bxf).Bottom + 5;
				if (bxf != null)
				{
					((Component)bxf).Dispose();
				}
			}
			((Control)BxM).ForeColor = BM.tD;
			((Control)BxM).AutoSize = true;
			((Control)BxM).Visible = false;
			((Control)BxM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHp();
			if (setting != null)
			{
				((Control)BxM).Left = ((Control)Bxf).Right + 10;
				((Control)BxM).Top = ((Control)Bxf).Top;
			}
			else
			{
				((Control)BxM).Left = num;
				((Control)BxM).Top = top;
			}
			((Control)base.B()).Controls.Add((Control)(object)BxM);
			((Control)BxG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHn();
			((Control)BxG).ForeColor = BM.te;
			((Control)BxG).Left = num;
			((Control)BxG).Top = top;
			((Control)BxG).Width = 500;
			((Control)BxG).Height = 16;
			((Control)base.B()).Controls.Add((Control)(object)BxG);
			top = ((Control)BxG).Bottom + 5;
			Bxn = Bxd.av()[1];
			((Control)Bxg).Text = c();
			((Control)Bxg).ForeColor = BM.te;
			((Control)Bxg).Left = num;
			((Control)Bxg).Top = top;
			((Control)Bxg).Width = 500;
			((Control)Bxg).Height = 16;
			((Control)base.B()).Controls.Add((Control)(object)Bxg);
			top = ((Control)Bxg).Bottom + 5;
			int num2 = ((((Control)this).Parent == null || !(((Control)this).Parent is aF)) ? 140 : Math.Max(140, (((Control)this).Parent.Width - 20) / (1 + Bxn)));
			((Control)BxH).Left = num;
			((Control)BxH).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)BxH);
			((Control)Bxh).Left = ((Control)BxH).Right + 1;
			((Control)Bxh).Top = top;
			((Control)Bxh).Width = num2 - (((Control)BxH).Width + ((Control)BxI).Width + 7);
			((Control)base.B()).Controls.Add((Control)(object)Bxh);
			((Control)BxI).Left = ((Control)Bxh).Left + ((Control)Bxh).Width + 3;
			((Control)BxI).Top = ((Control)Bxh).Top - 1;
			((Control)BxI).Height = ((Control)Bxh).Height + 2;
			((Control)base.B()).Controls.Add((Control)(object)BxI);
			((ListView)Bxl).ItemSelectionChanged -= new ListViewItemSelectionChangedEventHandler(A);
			((ListView)Bxl).ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(A);
			((ListView)Bxl).ShowItemToolTips = true;
			((Control)Bxl).BackColor = BM.tH;
			((Control)Bxl).ForeColor = BM.te;
			((ListView)Bxl).FullRowSelect = false;
			((ListView)Bxl).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)Bxl).UseCompatibleStateImageBehavior = false;
			((ListView)Bxl).View = (View)1;
			ColumnHeader val3 = new ColumnHeader();
			val3.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHQ();
			((ListView)Bxl).Columns.Add(val3);
			((Control)Bxl).Width = num2 - 5;
			((Control)Bxl).Left = num;
			((Control)Bxl).Top = top + 25;
			if (((Control)this).Parent != null && ((Control)this).Parent is aF)
			{
				((Control)Bxl).Height = Math.Max(260, ((Control)this).Parent.Height - 30 - ((Control)this).Top - ((Control)Bxl).Top);
			}
			else
			{
				((Control)Bxl).Height = 260;
			}
			((ListView)Bxl).Columns[0].Width = ((Control)Bxl).Width - 22;
			((Control)base.B()).Controls.Add((Control)(object)Bxl);
			num += num2;
			BxN.Clear();
			for (int i = 0; i < Bxn; i++)
			{
				A(i, num2, num, top);
				num += num2;
			}
			A(false);
			Bxd.A(new EventHandler(E));
			BxE.A(new EventHandler(e));
			((SettingOrSpecialObject)BxE).A(new EventHandler(F));
			C();
		}
		if (BxC != Rectangle.Empty)
		{
			((Control)this).Width = ((Rectangle)(ref BxC)).Width;
			((Control)this).Height = ((Rectangle)(ref BxC)).Height;
			((Control)this).Left = ((Rectangle)(ref BxC)).Left;
			((Control)this).Top = ((Rectangle)(ref BxC)).Top;
		}
		else
		{
			int num3 = 0;
			int num4 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val4 = item;
				num3 = Math.Max(num3, val4.Right + 15);
				num4 = Math.Max(num4, val4.Bottom + 15);
			}
			((Control)this).Width = num3;
			((Control)this).Height = num4;
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
		if (((Control)this).Parent != null && ((Control)this).Parent is aF)
		{
			((Control)this).Parent.Layout += new LayoutEventHandler(A);
		}
	}

	private void A(int P_0, int P_1, int P_2, int P_3)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		ThemedComboBox themedComboBox = new ThemedComboBox();
		((Control)themedComboBox).Enabled = BM.QO != BM.b.BpG && Bxa.C();
		((Control)themedComboBox).Tag = P_0;
		((ComboBox)themedComboBox).DropDownStyle = (ComboBoxStyle)2;
		((Control)themedComboBox).Width = 110;
		((Control)themedComboBox).Left = P_2 + (P_1 - 5 - ((Control)themedComboBox).Width) / 2;
		((Control)themedComboBox).Top = P_3;
		Setting setting = ((BM.QO != BM.b.BpG || BxF == null) ? BxE : BxF);
		int selectedIndex = 0;
		int num = setting.m(P_0);
		List<Setting.ListItems.A> val = setting.d(0);
		for (int i = 0; i < val.Count; i++)
		{
			((ComboBox)themedComboBox).Items.Add((object)val[i].bBV);
			if (val[i].bBv == num)
			{
				selectedIndex = i;
			}
		}
		((ListControl)themedComboBox).SelectedIndex = selectedIndex;
		((ComboBox)themedComboBox).SelectedIndexChanged += new EventHandler(f);
		if (BxJ.Count > P_0)
		{
			ThemedComboBox themedComboBox2 = BxJ[P_0];
			BxJ[P_0] = themedComboBox;
			((ComboBox)themedComboBox2).SelectedIndexChanged -= new EventHandler(f);
			((Component)themedComboBox2).Dispose();
		}
		else
		{
			BxJ.Add(themedComboBox);
		}
		((Control)base.B()).Controls.Add((Control)(object)themedComboBox);
		ab ab = new ab();
		((ListView)ab).ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(A);
		((ListView)ab).ShowItemToolTips = true;
		((Control)ab).BackColor = BM.tH;
		((Control)ab).ForeColor = BM.te;
		((ListView)ab).FullRowSelect = false;
		((ListView)ab).HeaderStyle = (ColumnHeaderStyle)1;
		((ListView)ab).UseCompatibleStateImageBehavior = false;
		((ListView)ab).View = (View)1;
		ColumnHeader val2 = new ColumnHeader();
		val2.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHq();
		((ListView)ab).Columns.Add(val2);
		((Control)ab).Width = P_1 - 5;
		((Control)ab).Height = ((Control)Bxl).Height - 66;
		((Control)ab).Left = P_2;
		((Control)ab).Top = P_3 + 25;
		((ListView)ab).Columns[0].Width = ((Control)ab).Width - 22;
		if (Bxj.Count > P_0)
		{
			ab ab2 = Bxj[P_0];
			Bxj[P_0] = ab;
			((ListView)ab2).ItemSelectionChanged -= new ListViewItemSelectionChangedEventHandler(A);
			((Component)ab2).Dispose();
		}
		else
		{
			Bxj.Add(ab);
		}
		((Control)base.B()).Controls.Add((Control)(object)ab);
		Label val3 = new Label();
		((Control)val3).ForeColor = BM.te;
		val3.TextAlign = (ContentAlignment)32;
		((Control)val3).AutoSize = false;
		((Control)val3).Width = P_1 - 5;
		((Control)val3).Height = 16;
		((Control)val3).Left = P_2;
		((Control)val3).Top = ((Control)ab).Bottom;
		if (BxK.Count > P_0)
		{
			Label obj = BxK[P_0];
			BxK[P_0] = val3;
			((Component)obj).Dispose();
		}
		else
		{
			BxK.Add(val3);
		}
		((Control)base.B()).Controls.Add((Control)(object)val3);
		A(P_0, false);
		ThemedButton themedButton = new ThemedButton();
		((Control)themedButton).Click += new EventHandler(B);
		((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHR();
		((Control)themedButton).Font = new Font(((Control)themedButton).Font.FontFamily, 8f);
		((Control)themedButton).Width = P_1 - 5;
		((Control)themedButton).Left = P_2;
		((Control)themedButton).Top = ((Control)ab).Bottom + 18;
		((Control)themedButton).Enabled = false;
		if (Bxk.Count > P_0)
		{
			ThemedButton themedButton2 = Bxk[P_0];
			Bxk[P_0] = themedButton;
			((Control)themedButton2).Click -= new EventHandler(B);
			((Component)themedButton2).Dispose();
		}
		else
		{
			Bxk.Add(themedButton);
		}
		((Control)base.B()).Controls.Add((Control)(object)themedButton);
		ThemedButton themedButton3 = new ThemedButton();
		((Control)themedButton3).Click += new EventHandler(b);
		((Control)themedButton3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHr();
		((Control)themedButton3).Font = new Font(((Control)themedButton3).Font.FontFamily, 8f);
		((Control)themedButton3).Width = P_1 - 5;
		((Control)themedButton3).Left = P_2;
		((Control)themedButton3).Top = ((Control)themedButton).Bottom + 1;
		((Control)themedButton3).Enabled = false;
		if (BxL.Count > P_0)
		{
			ThemedButton themedButton4 = BxL[P_0];
			BxL[P_0] = themedButton3;
			((Control)themedButton4).Click -= new EventHandler(b);
			((Component)themedButton4).Dispose();
		}
		else
		{
			BxL.Add(themedButton3);
		}
		((Control)base.B()).Controls.Add((Control)(object)themedButton3);
	}

	private void A(object P_0, LayoutEventArgs P_1)
	{
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		Bxc = Bxa.B() && Bxa.b() && Bxa.A(Bxb.DataIdOfChannelListSetting).J();
		BxD = BxB != null && BxB.B() && BxB.b() && BxB.A(Bxb.DataIdOfChannelListSetting).J();
		if (!((BM.QO != BM.b.BpG || BxB == null) ? Bxc : BxD))
		{
			int num = 5;
			if (Bxf != null)
			{
				_ = ((Control)Bxf).Bottom;
			}
			int num2 = ((Control)Bxl).Width + 5;
			int num3 = ((((Control)this).Parent == null || !(((Control)this).Parent is aF)) ? 140 : Math.Max(140, (((Control)this).Parent.Width - 20) / (1 + Bxn)));
			((Control)Bxh).Width = num3 - (((Control)BxH).Width + ((Control)BxI).Width + 7);
			((Control)BxI).Left = ((Control)Bxh).Left + ((Control)Bxh).Width + 3;
			((Control)Bxl).Width = num3 - 5;
			if (((Control)this).Parent != null && ((Control)this).Parent is aF)
			{
				((Control)Bxl).Height = Math.Max(260, ((Control)this).Parent.Height - 30 - ((Control)this).Top - ((Control)Bxl).Top);
			}
			else
			{
				((Control)Bxl).Height = 260;
			}
			((ListView)Bxl).Columns[0].Width = ((Control)Bxl).Width - 22;
			Bxl.a();
			num += num3;
			for (int i = 0; i < Bxn; i++)
			{
				ThemedComboBox themedComboBox = BxJ[i];
				((Control)themedComboBox).Left = num + (num3 - 5 - ((Control)themedComboBox).Width) / 2;
				ab ab = Bxj[i];
				((Control)ab).Width = num3 - 5;
				((Control)ab).Height = ((Control)Bxl).Height - 66;
				((Control)ab).Left = num;
				((ListView)ab).Columns[0].Width = ((Control)ab).Width - 22;
				ab.a();
				Label obj = BxK[i];
				((Control)obj).Width = num3 - 5;
				((Control)obj).Left = num;
				((Control)obj).Top = ((Control)ab).Bottom;
				ThemedButton themedButton = Bxk[i];
				((Control)themedButton).Width = num3 - 5;
				((Control)themedButton).Left = num;
				((Control)themedButton).Top = ((Control)ab).Bottom + 18;
				ThemedButton themedButton2 = BxL[i];
				((Control)themedButton2).Width = num3 - 5;
				((Control)themedButton2).Left = num;
				((Control)themedButton2).Top = ((Control)themedButton).Bottom + 1;
				num += num3;
			}
			if (num2 >= 210 != num3 >= 210)
			{
				for (int j = 0; j < Bxn; j++)
				{
					A(j, true);
				}
				A(true);
			}
		}
		if (BxC == Rectangle.Empty)
		{
			int num4 = 0;
			int num5 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val = item;
				num4 = Math.Max(num4, val.Right + 15);
				num5 = Math.Max(num5, val.Bottom + 15);
			}
			((Control)this).Width = num4;
			((Control)this).Height = num5;
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
	}

	private void A(object P_0, ListViewItemSelectionChangedEventArgs P_1)
	{
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		for (int i = 0; i < Bxn; i++)
		{
			if (((Control)Bxl).Focused && ((ListView)Bxl).SelectedItems.Count != 0)
			{
				((Control)Bxk[i]).Enabled = Bxa.C();
			}
			else if (((Control)Bxj[i]).Focused && ((ListView)Bxj[i]).SelectedItems.Count != 0)
			{
				((Control)Bxk[i]).Enabled = false;
			}
			else
			{
				bool flag = false;
				for (int j = 0; j < Bxn; j++)
				{
					if (j != i && ((Control)Bxj[j]).Focused && ((ListView)Bxj[j]).SelectedItems.Count != 0)
					{
						flag = true;
						break;
					}
				}
				((Control)Bxk[i]).Enabled = flag && Bxa.C();
			}
			((Control)BxL[i]).Enabled = ((Control)Bxj[i]).Focused && ((ListView)Bxj[i]).SelectedItems.Count != 0 && Bxa.C();
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Invalid comparison between Unknown and I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO == BM.b.BpG || !Bxa.C())
		{
			return;
		}
		int num = Bxk.IndexOf(P_0 as ThemedButton);
		int num2 = -1;
		List<int> val = new List<int>();
		if (((ListView)Bxl).SelectedItems.Count == 0)
		{
			for (int i = 0; i < Bxj.Count; i++)
			{
				if (((ListView)Bxj[i]).SelectedItems.Count != 0)
				{
					num2 = i;
					break;
				}
			}
			if (num2 == -1 || num2 == num)
			{
				return;
			}
			foreach (ListViewItem selectedItem in ((ListView)Bxj[num2]).SelectedItems)
			{
				ListViewItem val2 = selectedItem;
				if (val2.Tag != null)
				{
					val.Add((int)val2.Tag);
				}
			}
		}
		else
		{
			foreach (ListViewItem selectedItem2 in ((ListView)Bxl).SelectedItems)
			{
				ListViewItem val3 = selectedItem2;
				if (val3.Tag != null)
				{
					val.Add((int)val3.Tag);
				}
			}
		}
		List<int> val4 = new List<int>();
		Enumerator<int> enumerator2 = val.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				int current = enumerator2.Current;
				Setting setting = Bxa.A(current);
				if (setting is Table)
				{
					Table table = setting as Table;
					val4.AddRange((System.Collections.Generic.IEnumerable<int>)table.GetDataIdsOfChannelsPerEnabledAxis());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		int num3 = BxE.m(num);
		for (int j = 0; j < Bxn; j++)
		{
			int num4 = BxE.m(j);
			for (int k = 0; k < Bxd.av()[2]; k++)
			{
				int num5 = Bxd.B(k, j, 0);
				if (num5 == 0 || num5 == Bxd.aU())
				{
					break;
				}
				if (val4.Contains(num5) && num4 <= num3)
				{
					val4.Remove(num5);
				}
			}
		}
		val.AddRange((System.Collections.Generic.IEnumerable<int>)val4);
		int num6 = 0;
		for (int l = 0; l < Bxd.av()[2]; l++)
		{
			int num7 = Bxd.B(l, num, 0);
			if (num7 == 0 || num7 == Bxd.aU())
			{
				break;
			}
			num6++;
		}
		if (num6 + val.Count > Bxd.av()[2])
		{
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHS();
			if (val4.Count == 0)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHs(), text, (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (num6 + val.Count - val4.Count > Bxd.av()[2])
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHs(), text, (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHT(), text, (MessageBoxButtons)1, (MessageBoxIcon)48, new string[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHt()
			}) == 1)
			{
				return;
			}
			enumerator2 = val4.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current2 = enumerator2.Current;
					val.Remove(current2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			val4.Clear();
		}
		((Control)Bxk[num]).Enabled = false;
		Ck ck = BM.aM();
		ck?.A(Bxd.A());
		Bxd.az();
		bool num8 = Bxa.l();
		Bxa.M();
		A(val, num);
		a(val, num2);
		B(val4, num);
		if (num8)
		{
			Bxa.A(true, Bxd);
		}
		Bxd.i(true);
		ck?.B();
		BM.b(Bxd.A());
	}

	private void A(List<int> P_0, int P_1)
	{
		List<int> val = new List<int>();
		val.AddRange((System.Collections.Generic.IEnumerable<int>)P_0);
		for (int i = 0; i < Bxd.av()[2]; i++)
		{
			int num = Bxd.B(i, P_1, 0);
			if (num == 0 || num == Bxd.aU())
			{
				break;
			}
			if (!val.Contains(num))
			{
				val.Add(num);
			}
		}
		for (int j = 0; j < val.Count; j++)
		{
			Bxd.A(j, P_1, 0, val[j], true);
		}
		for (int k = val.Count; k < Bxd.av()[2]; k++)
		{
			Bxd.A(k, P_1, 0, Bxd.aU(), true);
		}
	}

	private void a(List<int> P_0, int P_1)
	{
		if (P_1 == -1)
		{
			return;
		}
		List<int> val = new List<int>();
		for (int i = 0; i < Bxd.av()[2]; i++)
		{
			int num = Bxd.B(i, P_1, 0);
			if (num == 0 || num == Bxd.aU())
			{
				break;
			}
			if (!P_0.Contains(num))
			{
				val.Add(num);
			}
		}
		for (int j = 0; j < val.Count; j++)
		{
			Bxd.A(j, P_1, 0, val[j], true);
		}
		for (int k = val.Count; k < Bxd.av()[2]; k++)
		{
			Bxd.A(k, P_1, 0, Bxd.aU(), true);
		}
	}

	private void B(List<int> P_0, int P_1)
	{
		for (int i = 0; i < Bxn; i++)
		{
			if (i == P_1)
			{
				continue;
			}
			List<int> val = new List<int>();
			for (int j = 0; j < Bxd.av()[2]; j++)
			{
				int num = Bxd.B(j, i, 0);
				if (num == 0 || num == Bxd.aU())
				{
					break;
				}
				if (!P_0.Contains(num) && !val.Contains(num))
				{
					val.Add(num);
				}
			}
			for (int k = 0; k < val.Count; k++)
			{
				Bxd.A(k, i, 0, val[k], true);
			}
			for (int l = val.Count; l < Bxd.av()[2]; l++)
			{
				Bxd.A(l, i, 0, Bxd.aU(), true);
			}
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		if (BM.QO == BM.b.BpG || !Bxa.C())
		{
			return;
		}
		int num = BxL.IndexOf(P_0 as ThemedButton);
		if (((ListView)Bxj[num]).SelectedItems.Count == 0)
		{
			return;
		}
		for (int i = 0; i < BxL.Count; i++)
		{
			((Control)BxL[i]).Enabled = false;
		}
		List<int> val = new List<int>();
		foreach (ListViewItem selectedItem in ((ListView)Bxj[num]).SelectedItems)
		{
			ListViewItem val2 = selectedItem;
			if (val2.Tag != null)
			{
				val.Add((int)val2.Tag);
			}
		}
		Ck ck = BM.aM();
		ck?.A(Bxd.A());
		Bxd.az();
		bool flag = Bxa.l();
		Bxa.M();
		List<int> val3 = new List<int>();
		for (int j = 0; j < Bxd.av()[2]; j++)
		{
			int num2 = Bxd.B(j, num, 0);
			if (num2 == 0 || num2 == Bxd.aU())
			{
				break;
			}
			if (!val.Contains(num2))
			{
				val3.Add(num2);
			}
		}
		for (int k = 0; k < val3.Count; k++)
		{
			Bxd.A(k, num, 0, val3[k], true);
		}
		for (int l = val3.Count; l < Bxd.av()[2]; l++)
		{
			Bxd.A(l, num, 0, Bxd.aU(), true);
		}
		if (flag)
		{
			Bxa.A(true, Bxd);
		}
		Bxd.i(true);
		ck?.B();
		BM.b(Bxd.A());
	}

	private void C(object P_0, EventArgs P_1)
	{
		((Control)Bxh).Text = string.Empty;
	}

	private void c(object P_0, EventArgs P_1)
	{
		Bxi.Stop();
		Bxi.Start();
	}

	private void D(object P_0, EventArgs P_1)
	{
		Bxi.Stop();
		for (int i = 0; i < Bxn; i++)
		{
			A(i, false);
		}
		A(false);
	}

	private void d(object P_0, EventArgs P_1)
	{
		B();
		((Control)base.B()).Controls.Clear();
		b();
	}

	private new void C()
	{
		bool visible = false;
		if (!Bxc && !BxD && Bxe != null && !Bxd.A(Bxe))
		{
			visible = true;
		}
		((Control)BxM).Visible = visible;
		for (int i = 0; i < Bxn; i++)
		{
			a(i);
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = E;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		bool flag = false;
		if (!string.IsNullOrEmpty(((Control)Bxh).Text))
		{
			flag = true;
		}
		else
		{
			for (int i = 0; i < Bxn; i++)
			{
				for (int j = 0; j < Bxd.av()[2]; j++)
				{
					int num = Bxd.B(j, i, 0);
					if (num != 0 && num != Bxd.aU())
					{
						if (j < ((ListView)Bxj[i]).Items.Count)
						{
							Bxa.A(num);
							if (((ListView)Bxj[i]).Items[j].Tag != null && (int)((ListView)Bxj[i]).Items[j].Tag != num)
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
					if (((ListView)Bxj[i]).Items.Count != j)
					{
						flag = true;
					}
					break;
				}
				if (flag)
				{
					break;
				}
			}
		}
		if (flag)
		{
			BxN.Clear();
			for (int k = 0; k < Bxn; k++)
			{
				A(k, false);
			}
		}
		A(true);
		C();
		((Control)Bxg).Text = c();
	}

	private void e(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = e;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO != BM.b.BpG)
		{
			for (int i = 0; i < Bxn; i++)
			{
				B(i);
			}
			C();
			((Control)Bxg).Text = c();
		}
	}

	private void F(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b = F;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		for (int i = 0; i < Bxn; i++)
		{
			a(i);
		}
	}

	private void a(int P_0)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		ThemedComboBox themedComboBox = BxJ[P_0];
		if ((BM.QO != BM.b.BpG && !Bxc) || (BM.QO == BM.b.BpG && !BxD))
		{
			if (!BxE.O())
			{
				if (BxE.m(P_0) == 0 && Bxd.B(0, P_0, 0) != Bxd.aU())
				{
					((Control)themedComboBox).BackColor = Color.Orange;
				}
				else
				{
					((Control)themedComboBox).BackColor = BM.to;
				}
			}
			else if (BxF != null && !BxE.A(BxF, P_0))
			{
				((Control)themedComboBox).BackColor = BM.tD;
			}
			else
			{
				((Control)themedComboBox).BackColor = BM.to;
			}
		}
		else
		{
			((Control)themedComboBox).BackColor = BM.to;
		}
	}

	private void B(int P_0)
	{
		ThemedComboBox themedComboBox = BxJ[P_0];
		if (((ComboBox)themedComboBox).DroppedDown)
		{
			return;
		}
		int num = -1;
		int num2 = BxE.m(P_0);
		List<Setting.ListItems.A> val = BxE.d(0);
		for (int i = 0; i < val.Count; i++)
		{
			if (val[i].bBv == num2)
			{
				num = i;
				break;
			}
		}
		if (((ListControl)themedComboBox).SelectedIndex != num && num != -1)
		{
			((ListControl)themedComboBox).SelectedIndex = num;
		}
	}

	private void A(int P_0, bool P_1)
	{
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		Framework framework;
		Setting setting;
		if (BM.QO == BM.b.BpG && Bxe != null)
		{
			framework = BxB;
			setting = Bxe;
		}
		else
		{
			framework = Bxa;
			setting = Bxd;
		}
		ab ab = Bxj[P_0];
		int num = 0;
		if (P_1 && ((ListView)ab).TopItem != null)
		{
			num = ((ListView)ab).TopItem.Index;
		}
		((ListView)ab).BeginUpdate();
		((ListView)ab).Items.Clear();
		List<ListViewItem> val = new List<ListViewItem>();
		int num2 = 0;
		string[] array = ((Control)Bxh).Text.ToUpper().Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
		for (int i = 0; i < setting.av()[2]; i++)
		{
			int num3 = setting.B(i, P_0, 0);
			if (num3 == 0 || num3 == setting.aU())
			{
				break;
			}
			Setting setting2 = framework.A(num3);
			bool flag = true;
			string text;
			if (setting2 != null)
			{
				BxN.Add(setting2.A());
				text = ((SettingOrSpecialObject)setting2).A(true);
				if (!string.IsNullOrEmpty(((Control)Bxh).Text))
				{
					string text2 = text;
					string text3 = ((SettingOrSpecialObject)setting2).A(bz.aYT);
					if (text3 == null)
					{
						text3 = ((SettingOrSpecialObject)setting2).B();
					}
					string text4 = text3.ToUpper();
					string text5 = text2.ToUpper();
					string[] array2 = array;
					foreach (string text6 in array2)
					{
						if (text5.Contains(text6) || text4.Contains(text6))
						{
							continue;
						}
						bool flag2 = false;
						Enumerator<string> enumerator = ((SettingOrSpecialObject)setting2).i().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.ToUpper().Contains(text6))
								{
									flag2 = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						if (!flag2)
						{
							flag = false;
							break;
						}
					}
				}
			}
			else
			{
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHP();
				flag = string.IsNullOrEmpty(((Control)Bxh).Text);
			}
			if (flag)
			{
				string[] array3 = ((((Control)ab).Width + 5 >= 210) ? new string[1] { text } : ((setting2 == null) ? new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoa() } : new string[1] { ((SettingOrSpecialObject)setting2).A(bz.aYT) }));
				ListViewItem val2 = new ListViewItem(array3);
				val2.ToolTipText = text;
				val2.Tag = num3;
				val.Add(val2);
			}
			num2++;
		}
		((ListView)ab).Items.AddRange(val.ToArray());
		((ListView)ab).EndUpdate();
		if (P_1 && ((ListView)ab).Items.Count != 0 && num < ((ListView)ab).Items.Count)
		{
			((ListView)ab).TopItem = ((ListView)ab).Items[num];
		}
		ab.a();
		((Control)BxK[P_0]).Text = num2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eJ() + setting.av()[2] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHU();
	}

	private new void A(bool P_0)
	{
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (P_0 && ((ListView)Bxl).TopItem != null)
		{
			num = ((ListView)Bxl).TopItem.Index;
		}
		((ListView)Bxl).BeginUpdate();
		((ListView)Bxl).Items.Clear();
		string[] array = ((Control)Bxh).Text.ToUpper().Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
		List<ListViewItem> val = new List<ListViewItem>();
		System.Collections.Generic.IEnumerator<Setting> enumerator = ((System.Collections.Generic.IEnumerable<Setting>)Bxm.Values).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				Setting current = enumerator.Current;
				if (BxN.Contains(current.A()))
				{
					continue;
				}
				bool flag = true;
				if (!string.IsNullOrEmpty(((Control)Bxh).Text))
				{
					string text = ((SettingOrSpecialObject)current).A(true);
					string text2 = ((SettingOrSpecialObject)current).A(bz.aYT);
					if (text2 == null)
					{
						text2 = ((SettingOrSpecialObject)current).B();
					}
					string text3 = text2.ToUpper();
					string text4 = text.ToUpper();
					string[] array2 = array;
					foreach (string text5 in array2)
					{
						if (text4.Contains(text5) || text3.Contains(text5))
						{
							continue;
						}
						bool flag2 = false;
						Enumerator<string> enumerator2 = ((SettingOrSpecialObject)current).i().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.ToUpper().Contains(text5))
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
						if (!flag2)
						{
							flag = false;
							break;
						}
					}
				}
				if (flag)
				{
					string text6 = Bxm.Keys[Bxm.IndexOfValue(current)];
					string[] array3 = ((((Control)Bxl).Width + 5 < 210) ? new string[1] { ((SettingOrSpecialObject)current).A(bz.aYT) } : new string[1] { text6 });
					ListViewItem val2 = new ListViewItem(array3);
					val2.ToolTipText = text6;
					val2.Tag = current.A();
					val.Add(val2);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		((ListView)Bxl).Items.AddRange(val.ToArray());
		((ListView)Bxl).EndUpdate();
		if (P_0 && ((ListView)Bxl).Items.Count != 0 && num < ((ListView)Bxl).Items.Count)
		{
			((ListView)Bxl).TopItem = ((ListView)Bxl).Items[num];
		}
		Bxl.a();
	}

	private void f(object P_0, EventArgs P_1)
	{
		if (BM.QO != BM.b.BpG && BxE != null && Bxa.C())
		{
			ThemedComboBox themedComboBox = P_0 as ThemedComboBox;
			Ck ck = BM.aM();
			ck?.A(BxE.A());
			BxE.a((int)((Control)themedComboBox).Tag, BxE.d(0)[((ListControl)themedComboBox).SelectedIndex].bBv, true);
			ck?.B();
			BM.b(BxE.A());
		}
	}

	private void G(object P_0, EventArgs P_1)
	{
		if (BM.QO != BM.b.BpG && (P_0 as Setting).ax() != 0)
		{
			BM.sw = true;
		}
	}

	private string c()
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		if (Bxn == 0 || Bxd == null || BxE == null)
		{
			return string.Empty;
		}
		int num = 0;
		for (int i = 0; i < Bxn; i++)
		{
			int num2 = 0;
			for (int j = 0; j < Bxd.av()[2]; j++)
			{
				int num3 = Bxd.B(j, i, 0);
				if (num3 != 0 && num3 != Bxd.aU())
				{
					num2++;
				}
			}
			int num4 = 9 + num2 * 4;
			int num5 = BxE.m(i);
			if (num5 != 0)
			{
				num += num4 * 1000 / num5;
			}
		}
		if (num == 0)
		{
			return string.Empty;
		}
		int num6 = Bxa.A(9497).ax();
		if (num6 == 0)
		{
			return string.Empty;
		}
		int num7 = 1000 * (int)((long)num6 * 80L / num / 100);
		TimeSpan val = TimeSpan.FromMilliseconds((long)num7, 0L);
		string text = ((num7 < 60000) ? (((TimeSpan)(ref val)).Seconds + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHu()) : ((num7 < 120000) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHV() + ((TimeSpan)(ref val)).Seconds + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHv() + ((((TimeSpan)(ref val)).Seconds == 1) ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl())) : ((num7 >= 3600000) ? string.Concat(new string[7]
		{
			((TimeSpan)(ref val)).Hours.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHw(),
			(((TimeSpan)(ref val)).Hours == 1) ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
			((TimeSpan)(ref val)).Minutes.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHX(),
			(((TimeSpan)(ref val)).Minutes == 1) ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl()
		}) : (((TimeSpan)(ref val)).Minutes + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHW()))));
		return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MF() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHx();
	}

	public Control A(DataIdAndAttrId P_0)
	{
		if (((Control)Bxl).Visible && ((Control)base.B()).Controls.Contains((Control)(object)Bxl) && ((Bxd != null && P_0.DataId == Bxd.A()) || (BxE != null && P_0.DataId == BxE.A())))
		{
			return (Control)(object)Bxl;
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
}
