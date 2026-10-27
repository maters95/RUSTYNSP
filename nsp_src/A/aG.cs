using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;

namespace a;

internal class aG : UserControl
{
	private class A : ListViewItem
	{
		internal bool BMH;

		internal bool BMh;

		internal bool BMI;

		internal A(string[] P_0, bool P_1, bool P_2, bool P_3)
			: base(P_0)
		{
			BMH = P_1;
			BMh = P_2;
			BMI = P_3;
		}
	}

	private delegate void a(object P_0, EventArgs P_1);

	private delegate void B(object P_0, EventArgs P_1);

	private delegate void b(object P_0, EventArgs P_1);

	private class C : IComparer
	{
		private int BMi;

		private bool BMJ;

		internal C(int P_0, bool P_1)
		{
			BMi = P_0;
			BMJ = P_1;
		}

		public int Compare(object listViewItem1, object listViewItem2)
		{
			A a = (A)listViewItem1;
			A a2 = (A)listViewItem2;
			if ((((ListViewItem)a).Tag == null && !a.BMh && !a.BMI) || (((ListViewItem)a2).Tag == null && !a2.BMh && !a2.BMI))
			{
				if (((ListViewItem)a).Tag != null || a.BMh || a.BMI)
				{
					return 1;
				}
				return -1;
			}
			if (a.BMh)
			{
				if (a2.BMH)
				{
					if (a2.BMI)
					{
						return -1;
					}
					return 1;
				}
				return -1;
			}
			if (a2.BMh)
			{
				if (a.BMH)
				{
					if (a.BMI)
					{
						return 1;
					}
					return -1;
				}
				return 1;
			}
			if (a.BMI)
			{
				if (a2.BMH)
				{
					return 1;
				}
				return -1;
			}
			if (a2.BMI)
			{
				if (a.BMH)
				{
					return -1;
				}
				return 1;
			}
			if ((a.BMH && a2.BMH) || (!a.BMH && !a2.BMH))
			{
				if (!string.IsNullOrWhiteSpace(((ListViewItem)a).SubItems[BMi].Text) && !string.IsNullOrWhiteSpace(((ListViewItem)a2).SubItems[BMi].Text) && char.IsDigit(((ListViewItem)a).SubItems[BMi].Text.Trim()[0]) && char.IsDigit(((ListViewItem)a2).SubItems[BMi].Text.Trim()[0]))
				{
					int num = int.Parse(((object)Regex.Match(((ListViewItem)a).SubItems[BMi].Text.Trim(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCv())).ToString());
					int num2 = int.Parse(((object)Regex.Match(((ListViewItem)a2).SubItems[BMi].Text.Trim(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCv())).ToString());
					if (BMJ)
					{
						return num2 - num;
					}
					return num - num2;
				}
				if (BMJ)
				{
					return string.Compare(((ListViewItem)a2).SubItems[BMi].Text, ((ListViewItem)a).SubItems[BMi].Text);
				}
				return string.Compare(((ListViewItem)a).SubItems[BMi].Text, ((ListViewItem)a2).SubItems[BMi].Text);
			}
			if (a.BMH && !a2.BMH)
			{
				return -1;
			}
			return 1;
		}
	}

	private MenuNode hk;

	private Setting hL;

	private string hl;

	private List<ValueTuple<CO, string>> hM;

	private Timer hm = new Timer();

	private bool hN;

	private int hn = -1;

	private bool hO;

	private bool ho;

	private bool hP;

	[CompilerGenerated]
	private EventHandler hp;

	[CompilerGenerated]
	private EventHandler hQ;

	private IContainer hq;

	private ThemedTextBox hR;

	private PictureBox hr;

	private ThemedButton hS;

	private ab hs;

	private Label hT;

	private ag ht;

	private Label hU;

	private aP hu;

	private ThemedButton hV;

	private PictureBox hv;

	internal aG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		f();
	}

	[SpecialName]
	internal MenuNode A()
	{
		return hk;
	}

	internal void A(MenuNode P_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		hm.Interval = 400;
		hm.Tick += new EventHandler(E);
		((Control)this).BackColor = BM.td;
		((Control)hs).BackColor = BM.tH;
		((Control)hs).ForeColor = BM.te;
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val = item;
			if (val is Label)
			{
				((val is Label) ? val : null).ForeColor = BM.te;
			}
		}
		((Control)hu).ForeColor = BM.te;
		((Control)hr).BackColor = ((Control)this).BackColor;
		if (hr.Image != null)
		{
			hr.Image.Dispose();
		}
		hr.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		((Control)hR).BackColor = BM.to;
		((Control)hR).ForeColor = BM.te;
		((Control)ht).BackColor = BM.tH;
		((Control)ht).ForeColor = BM.te;
		hk = P_0;
		hL = hk.a().A(hk.W());
		bool flag = false;
		hM = Cn.A(hk, hL, flag);
		if (!C())
		{
			a();
		}
		d();
		((Control)this).Visible = ((SettingOrSpecialObject)hL).l() || (((Control)this).Parent != null && ((Control)this).Parent is BR);
		hL.a(new EventHandler(a));
		hL.A(new EventHandler(a));
		((SettingOrSpecialObject)hL).a(new EventHandler(B));
		((SettingOrSpecialObject)hL).A(new EventHandler(B));
		BM.f(new EventHandler(A));
		BM.F(new EventHandler(A));
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			a a = A;
			((Control)this).BeginInvoke((System.Delegate)a, new object[2] { P_0, P_1 });
		}
		else
		{
			bool flag = false;
			hM = Cn.A(hk, hL, flag);
			string text = hl;
			hP = true;
			this.a();
			A(text);
			hP = false;
		}
	}

	private void a()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		if (((ListView)hs).Columns.Count != 0)
		{
			hl = null;
			D();
			((ListView)hs).Items.Clear();
		}
		if (hM.Count == 0)
		{
			hs.a();
			return;
		}
		bool flag = false;
		List<string> val = new List<string>();
		List<string> val2 = new List<string>();
		CO cO = null;
		Enumerator<ValueTuple<CO, string>> enumerator = hM.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CO item = enumerator.Current.Item1;
				if (val.Count == 0 && hk.a().awF.ContainsKey(item.BcF.BCx))
				{
					val.AddRange((System.Collections.Generic.IEnumerable<string>)hk.a().awF[item.BcF.BCx].D());
				}
				if (val2.Count == 0 && hk.a().awF.ContainsKey(item.BcF.BCx))
				{
					val2.AddRange((System.Collections.Generic.IEnumerable<string>)hk.a().awF[item.BcF.BCx].d());
				}
				if (cO == null || item.BcF.Bcb.Count > cO.BcF.Bcb.Count)
				{
					cO = item;
				}
				if (!flag && hk.a().awF.ContainsKey(item.BcF.BCx) && hk.a().awF[item.BcF.BCx].F())
				{
					flag = true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		List<string> val3 = new List<string>();
		Enumerator<string, string> enumerator2 = cO.BcF.Bcb.Keys.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				string current = enumerator2.Current;
				if (!val.Contains(current) && !val2.Contains(current))
				{
					val3.Add(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		enumerator = hM.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CO item2 = enumerator.Current.Item1;
				if (item2 == cO)
				{
					continue;
				}
				enumerator2 = item2.BcF.Bcb.Keys.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						if (!val3.Contains(current2) && !val.Contains(current2) && !val2.Contains(current2))
						{
							val3.Add(current2);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		int num = 1;
		if (flag)
		{
			num++;
		}
		if (((ListView)hs).Columns.Count == 0)
		{
			ColumnHeader val4 = new ColumnHeader();
			val4.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cv();
			((ListView)hs).Columns.Add(val4);
			if (flag)
			{
				ColumnHeader val5 = new ColumnHeader();
				val5.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT();
				((ListView)hs).Columns.Add(val5);
			}
			Enumerator<string> enumerator3 = val3.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					string current3 = enumerator3.Current;
					ColumnHeader val6 = new ColumnHeader();
					val6.Text = Cn.A(current3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu());
					((ListView)hs).Columns.Add(val6);
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
		}
		Dictionary<string, int> val7 = new Dictionary<string, int>();
		for (int i = 0; i < val3.Count; i++)
		{
			val7.Add(val3[i], num + i);
		}
		string[] array = new string[num + val3.Count];
		if (!hk.l())
		{
			array[0] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FU();
			A obj = new A(array, true, false, false);
			((ListViewItem)obj).Tag = null;
			((ListViewItem)obj).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fv() + hk.E() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FW();
			A a = obj;
			((ListView)hs).Items.Add((ListViewItem)(object)a);
		}
		else if (hk.a().awP.H())
		{
			array[0] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fw();
			A obj2 = new A(array, true, false, false);
			((ListViewItem)obj2).Tag = null;
			((ListViewItem)obj2).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FX() + hk.E() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fx();
			A a2 = obj2;
			((ListView)hs).Items.Add((ListViewItem)(object)a2);
		}
		bool flag2 = false;
		enumerator = hM.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CO item3 = enumerator.Current.Item1;
				if (!((CheckBox)hu).Checked && !item3.BcF.A())
				{
					continue;
				}
				string[] array2 = new string[num + val3.Count];
				array2[0] = item3.BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].Bsp;
				if (flag)
				{
					array2[1] = item3.BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsQ;
				}
				string text = string.Concat(new string[5]
				{
					item3.BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FY(),
					((object)item3.BcF.BCY).ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy(),
					item3.BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsQ
				});
				Enumerator<string> enumerator3 = val3.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						string current4 = enumerator3.Current;
						if (item3.BcF.Bcb.ContainsKey(current4))
						{
							array2[val7[current4]] = item3.BcF.Bcb[current4];
							text = string.Concat(new string[5]
							{
								text,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy(),
								Cn.A(current4, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ(),
								item3.BcF.Bcb[current4]
							});
						}
						else
						{
							array2[val7[current4]] = string.Empty;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
				bool flag3 = A(item3.BcF);
				if (!flag3)
				{
					flag2 = true;
				}
				A obj3 = new A(array2, flag3, false, false);
				((ListViewItem)obj3).Tag = item3;
				((ListViewItem)obj3).ToolTipText = text;
				A a3 = obj3;
				((ListView)hs).Items.Add((ListViewItem)(object)a3);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (flag2)
		{
			A obj4 = new A(new string[num + val3.Count], true, true, false);
			((ListViewItem)obj4).Tag = null;
			((ListViewItem)obj4).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fz();
			A a4 = obj4;
			((ListView)hs).Items.Add((ListViewItem)(object)a4);
			A obj5 = new A(new string[num + val3.Count], true, false, true);
			((ListViewItem)obj5).Tag = null;
			((ListViewItem)obj5).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fz();
			A a5 = obj5;
			((ListView)hs).Items.Add((ListViewItem)(object)a5);
		}
		B();
		if (((ListView)hs).Columns.Count != 0)
		{
			A(false, E());
		}
		hs.a();
		if (hP)
		{
			return;
		}
		b();
		if (((ListView)hs).SelectedIndices.Count != 0)
		{
			return;
		}
		int num2 = 0;
		foreach (A item4 in ((ListView)hs).Items)
		{
			if (((ListViewItem)item4).Tag != null && item4.BMH)
			{
				num2++;
			}
		}
		if (num2 != 1)
		{
			return;
		}
		foreach (A item5 in ((ListView)hs).Items)
		{
			if (((ListViewItem)item5).Tag != null && item5.BMH)
			{
				((ListViewItem)item5).Selected = true;
				((ListView)hs).FocusedItem = (ListViewItem)(object)item5;
				break;
			}
		}
	}

	private void B()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (((ListView)hs).Columns.Count == 0)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < ((ListView)hs).Columns.Count; i++)
		{
			Size val = TextRenderer.MeasureText(((ListView)hs).Columns[i].Text, ((Control)hs).Font);
			int num2 = ((Size)(ref val)).Width + 5;
			foreach (A item in ((ListView)hs).Items)
			{
				int num3 = num2;
				val = TextRenderer.MeasureText(((ListViewItem)item).SubItems[i].Text, ((ListViewItem)item).Font);
				num2 = Math.Max(num3, ((Size)(ref val)).Width + 5);
			}
			num2 = Math.Min(num2, 300);
			((ListView)hs).Columns[i].Width = num2;
			num += num2;
		}
		int num4 = ((Control)hs).Width - 18;
		if (num > num4)
		{
			int width = num4 / ((ListView)hs).Columns.Count;
			for (int j = 0; j < ((ListView)hs).Columns.Count; j++)
			{
				((ListView)hs).Columns[j].Width = width;
			}
		}
		else if (num < num4)
		{
			int num5 = (num4 - num) / ((ListView)hs).Columns.Count;
			for (int k = 0; k < ((ListView)hs).Columns.Count; k++)
			{
				ColumnHeader obj = ((ListView)hs).Columns[k];
				obj.Width += num5;
			}
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b = a;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		this.b();
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				b b = B;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		((Control)this).Visible = ((SettingOrSpecialObject)hL).l() || (((Control)this).Parent != null && ((Control)this).Parent is BR);
	}

	private void b()
	{
		if (hL != null)
		{
			string text = n.A(hL.aY());
			if (text != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV())
			{
				ho = true;
				A(text);
				ho = false;
			}
		}
	}

	private void A(string P_0)
	{
		bool flag = P_0 == null || P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV();
		foreach (A item in ((ListView)hs).Items)
		{
			CO cO = ((ListViewItem)item).Tag as CO;
			if ((!flag && cO != null && P_0 == cO.BcF.BCw) || (flag && cO == null))
			{
				if (!((ListViewItem)item).Selected)
				{
					((ListViewItem)item).Selected = true;
				}
				((ListView)hs).FocusedItem = (ListViewItem)(object)item;
				((ListViewItem)item).EnsureVisible();
				break;
			}
		}
	}

	private bool A(Cn P_0)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		if (!string.IsNullOrEmpty(((Control)hR).Text))
		{
			string[] array = ((Control)hR).Text.ToLower().Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
			foreach (string text in array)
			{
				Cn.A a = P_0.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()];
				if ((!string.IsNullOrEmpty(a.BsP) && a.BsP.ToLower().Contains(text)) || (!string.IsNullOrEmpty(a.Bsp) && a.Bsp.ToLower().Contains(text)) || (!string.IsNullOrEmpty(a.BsQ) && a.BsQ.ToLower().Contains(text)))
				{
					continue;
				}
				bool flag = false;
				Enumerator<string, string> enumerator = P_0.Bcb.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.ToLower().Contains(text))
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
					result = false;
					break;
				}
			}
		}
		return result;
	}

	private bool C()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		if (hL != null && hk.a().awF.ContainsKey(((SettingOrSpecialObject)hL).d()))
		{
			DO dO = hk.a().awF[((SettingOrSpecialObject)hL).d()];
			if (dO.G().Keys.Count != 0)
			{
				Enumerator<int, string[]> enumerator = dO.G().Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						Setting setting = hk.a().A(current);
						if (setting == null)
						{
							continue;
						}
						string text = n.A(setting.aY());
						if (!(text != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV()))
						{
							continue;
						}
						Cn cn = null;
						lock (BM.qb)
						{
							if (BM.qB.ContainsKey(text))
							{
								cn = BM.qB[text].BcF;
							}
						}
						if (cn == null)
						{
							continue;
						}
						string[] array = dO.G()[current];
						foreach (string text2 in array)
						{
							string text3 = null;
							if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fA()))
							{
								string text4 = text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fA().Length);
								if (!string.IsNullOrEmpty(text4) && cn.Bcb.ContainsKey(text4))
								{
									text3 = cn.Bcb[text4];
								}
							}
							else if (text2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fa())
							{
								text3 = cn.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP;
							}
							else if (text2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fB())
							{
								text3 = cn.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].Bsp;
							}
							if (!string.IsNullOrEmpty(text3))
							{
								if (string.IsNullOrEmpty(((Control)hR).Text))
								{
									((Control)hR).Text = text3;
								}
								else
								{
									ThemedTextBox themedTextBox = hR;
									((Control)themedTextBox).Text = ((Control)themedTextBox).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + text3;
								}
								result = true;
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}
		return result;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = hp;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref hp, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = hp;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref hp, val3, val2);
		}
		while (val != val2);
	}

	private void A(object P_0, ListViewItemSelectionChangedEventArgs P_1)
	{
		if (((ListView)hs).SelectedIndices.Count == 0)
		{
			hl = null;
			D();
		}
		else if (P_1.Item.Selected)
		{
			if ((P_1.Item as A).BMh || (P_1.Item as A).BMI)
			{
				D();
				((Control)hT).Text = string.Empty;
				((Control)ht).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fb();
				d();
				hl = null;
			}
			else if (P_1.Item.Tag == null)
			{
				D();
				if (hk.a().awZ != 21)
				{
					((Control)hT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fC();
					((Control)ht).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fc() + hk.E() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FW();
				}
				else
				{
					((Control)hT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fD();
					((Control)ht).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fd() + hk.E() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fx();
				}
				d();
				hl = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV();
				if ((Bz.A() || !ho) && !hP && hO)
				{
					F();
				}
			}
			else
			{
				CO cO = P_1.Item.Tag as CO;
				A(cO);
				hl = cO.BcF.BCw;
				if ((Bz.A() || !ho) && !hP && hO)
				{
					F();
				}
			}
		}
		if (hp != null)
		{
			hp.Invoke((object)null, (EventArgs)null);
		}
	}

	[SpecialName]
	internal string c()
	{
		return hl;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void B(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = hQ;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref hQ, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void b(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = hQ;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref hQ, val3, val2);
		}
		while (val != val2);
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (hQ != null)
		{
			hQ.Invoke(P_0, P_1);
		}
	}

	private void D()
	{
		((Control)hT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fE();
		((Control)hU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fe();
		((Control)ht).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fF();
		((Control)hV).Enabled = false;
		((Control)hV).Tag = null;
		((Control)hv).Visible = false;
		hv.Image = null;
		d();
	}

	private void A(CO P_0)
	{
		((Control)hT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fE() + P_0.BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP;
		((Control)hU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fe() + ((object)P_0.BcF.BCY).ToString();
		((Control)ht).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ff() + P_0.BcF.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsQ;
		if (!string.IsNullOrEmpty(P_0.BcF.Bca))
		{
			((Control)hV).Enabled = true;
			((Control)hV).Tag = P_0.BcF;
		}
		else
		{
			((Control)hV).Enabled = false;
			((Control)hV).Tag = null;
		}
		Image val = Co.A(P_0);
		if (val != null)
		{
			hv.Image = val;
			((Control)hv).Visible = true;
		}
		else
		{
			((Control)hv).Visible = false;
			hv.Image = null;
		}
		d();
	}

	private void d()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		Size val;
		int num;
		if (hO)
		{
			val = ((Control)this).Size;
			num = ((Size)(ref val)).Height - 4;
		}
		else
		{
			val = ((Control)this).Size;
			num = ((Size)(ref val)).Height - 55;
		}
		((RichTextBox)ht).ScrollBars = (RichTextBoxScrollBars)0;
		if (((Control)hv).Visible)
		{
			val = TextRenderer.MeasureText(((Control)ht).Text, ((Control)ht).Font, new Size(((Control)ht).Width - 20, -1), (TextFormatFlags)16);
			int num2 = ((Size)(ref val)).Height + 20;
			int num3;
			int num4;
			int num5;
			if (num - (((Control)ht).Top + num2 + 9) >= 150)
			{
				num3 = num2;
				num4 = ((Control)ht).Top + num3 + 9;
				num5 = num - num4;
			}
			else
			{
				num5 = 150;
				num4 = num - num5;
				num3 = num4 - 9 - ((Control)ht).Top;
				if (num3 < 60)
				{
					num3 = 60;
					num4 = ((Control)ht).Top + num3 + 9;
					num5 = num - num4;
				}
			}
			((Control)ht).Height = num3;
			((Control)hv).Top = num4;
			((Control)hv).Height = num5;
		}
		else
		{
			((Control)ht).Height = num - ((Control)ht).Top;
		}
		((RichTextBox)ht).ScrollBars = (RichTextBoxScrollBars)2;
		ht.A();
	}

	private void C(object P_0, EventArgs P_1)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		if (((Control)((P_0 is Button) ? P_0 : null)).Tag == null)
		{
			return;
		}
		Cn cn = ((Control)((P_0 is Button) ? P_0 : null)).Tag as Cn;
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
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fH() + ex.Message, true);
				return;
			}
		}
		Uri val = null;
		try
		{
			val = new Uri(m.A(BM.Qw, cn.Bca + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fh(), true));
		}
		catch
		{
			val = null;
		}
		if (val != (Uri)null)
		{
			if (BM.sI)
			{
				BM.QQ.r();
			}
			else
			{
				BM.QQ.s();
			}
			BM.sj.A(val);
		}
	}

	private int E()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		if (hL != null && hk.a().awF.ContainsKey(((SettingOrSpecialObject)hL).d()))
		{
			DO dO = hk.a().awF[((SettingOrSpecialObject)hL).d()];
			if (dO != null && !string.IsNullOrEmpty(dO.f()))
			{
				string text = Cn.A(dO.f(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu());
				foreach (ColumnHeader column in ((ListView)hs).Columns)
				{
					ColumnHeader val = column;
					if (val.Text == text)
					{
						return ((ListView)hs).Columns.IndexOf(val);
					}
				}
			}
		}
		return 0;
	}

	private void A(object P_0, ColumnClickEventArgs P_1)
	{
		A(true, P_1.Column);
	}

	private void A(bool P_0, int P_1)
	{
		if (P_0)
		{
			if (P_1 != hn)
			{
				hN = false;
			}
			else
			{
				hN = !hN;
			}
		}
		((ListView)hs).ListViewItemSorter = (IComparer)(object)new C(P_1, hN);
		hn = P_1;
		((Control)hs).Refresh();
	}

	private void A(object P_0, DrawListViewColumnHeaderEventArgs P_1)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		P_1.DrawBackground();
		TextFormatFlags val = (TextFormatFlags)2052;
		HorizontalAlignment textAlign = P_1.Header.TextAlign;
		switch ((int)textAlign)
		{
		case 0:
			val = (TextFormatFlags)(val | 0);
			break;
		case 2:
			val = (TextFormatFlags)(val | 1);
			break;
		case 1:
			val = (TextFormatFlags)(val | 2);
			break;
		}
		TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, P_1.Header.Text, ((Control)hs).Font, P_1.Bounds, Color.Black, val);
		if (P_1.ColumnIndex != hn)
		{
			return;
		}
		P_1.Graphics.SmoothingMode = (SmoothingMode)2;
		Rectangle bounds = P_1.Bounds;
		int left = ((Rectangle)(ref bounds)).Left;
		bounds = P_1.Bounds;
		int num = (left + ((Rectangle)(ref bounds)).Right) / 2;
		int num2 = num - 5;
		int num3 = num + 5;
		bounds = P_1.Bounds;
		int num4 = ((Rectangle)(ref bounds)).Top + 1;
		bounds = P_1.Bounds;
		int num5 = ((Rectangle)(ref bounds)).Top + 6;
		Pen val2 = new Pen(Brushes.Black, 2f);
		try
		{
			if (hN)
			{
				P_1.Graphics.DrawLine(val2, num, num5, num2, num4);
				P_1.Graphics.DrawLine(val2, num - 1, num5, num3 - 1, num4);
			}
			else
			{
				P_1.Graphics.DrawLine(val2, num, num4, num2, num5);
				P_1.Graphics.DrawLine(val2, num - 1, num4, num3 - 1, num5);
			}
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
	}

	private void A(object P_0, DrawListViewItemEventArgs P_1)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		A a = P_1.Item as A;
		Rectangle bounds;
		if (a.BMh)
		{
			P_1.DrawDefault = false;
			P_1.DrawBackground();
			P_1.DrawFocusRectangle();
			SolidBrush val = new SolidBrush(((Control)hs).ForeColor);
			try
			{
				Graphics graphics = P_1.Graphics;
				bounds = ((ListViewItem)a).Bounds;
				int left = ((Rectangle)(ref bounds)).Left;
				bounds = ((ListViewItem)a).Bounds;
				graphics.FillRectangle((Brush)(object)val, left, ((Rectangle)(ref bounds)).Top + 7, ((Control)hs).Width - 20, 3);
				return;
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		if (a.BMI)
		{
			P_1.DrawDefault = false;
			P_1.DrawBackground();
			P_1.DrawFocusRectangle();
			SolidBrush val2 = new SolidBrush(((Control)hs).ForeColor);
			try
			{
				Graphics graphics2 = P_1.Graphics;
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fI();
				Font font = ((Control)hs).Font;
				bounds = ((ListViewItem)a).Bounds;
				float num = ((Rectangle)(ref bounds)).Left + 3;
				bounds = ((ListViewItem)a).Bounds;
				graphics2.DrawString(text, font, (Brush)(object)val2, num, (float)((Rectangle)(ref bounds)).Top);
				return;
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		P_1.DrawDefault = true;
	}

	private void A(object P_0, DrawListViewSubItemEventArgs P_1)
	{
		A a = P_1.Item as A;
		if (a.BMh || a.BMI)
		{
			P_1.DrawDefault = false;
		}
		else
		{
			P_1.DrawDefault = true;
		}
	}

	private void c(object P_0, EventArgs P_1)
	{
		string text = hl;
		hP = true;
		a();
		A(text);
		hP = false;
	}

	private void D(object P_0, EventArgs P_1)
	{
		((Control)hR).Text = string.Empty;
	}

	private void d(object P_0, EventArgs P_1)
	{
		hm.Stop();
		hm.Start();
	}

	private void E(object P_0, EventArgs P_1)
	{
		hm.Stop();
		bool num = ((Control)hR).Text == string.Empty;
		a();
		if (num)
		{
			((Control)hR).Focus();
		}
	}

	internal void e()
	{
		((Control)hR).Focus();
	}

	private void e(object P_0, EventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		Size size = ((Control)this).Size;
		int num = ((Size)(ref size)).Width - 6;
		((Control)hT).Left = num - ((Control)hT).Width;
		((Control)hV).Left = num - ((Control)hV).Width;
		((Control)hU).Left = num - ((Control)hU).Width;
		((Control)ht).Left = num - ((Control)ht).Width;
		((Control)hv).Left = num - ((Control)hv).Width;
		((Control)hs).Width = ((Control)hT).Left - 6 - ((Control)hs).Left;
		ab obj = hs;
		size = ((Control)this).Size;
		((Control)obj).Height = ((Size)(ref size)).Height - ((Control)hs).Top - 4;
		hs.a();
		B();
		d();
	}

	[SpecialName]
	internal void A(bool P_0)
	{
		hO = P_0;
		e(null, null);
	}

	internal void F()
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		bool num = hl == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FV();
		hk.a().C(hk.a().aWS);
		hk.a().M();
		hk.A().a();
		if (num)
		{
			if (hL != null)
			{
				if (Bz.A() && hk.a().awF.ContainsKey(((SettingOrSpecialObject)hL).d()))
				{
					DO dO = hk.a().awF[((SettingOrSpecialObject)hL).d()];
					Cursor.Current = Cursors.WaitCursor;
					Enumerator<Setting> enumerator = dO.A(hk, true).GetEnumerator();
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
				hL.J(true);
				hk.y();
				hk.i(false);
				hk.G(false);
				BM.b(hL.A());
			}
		}
		else
		{
			Cn cn = null;
			lock (BM.qb)
			{
				if (BM.qB.ContainsKey(hl))
				{
					cn = BM.qB[hl].BcF;
				}
			}
			if (cn != null && hL != null)
			{
				Cursor.Current = Cursors.WaitCursor;
				if (hk.a().awv.Count != 0)
				{
					Co.A(new CO
					{
						BcF = cn,
						Bcf = BM.qB[hl].Bcf
					}, hk.a());
				}
				byte[] array = n.A(hl);
				hL.A(array, true);
				cn.A(hk);
				BM.b(hL.A());
				Cursor.Current = Cursors.WaitCursor;
			}
		}
		hk.a().A(true);
		hk.a().c(hk.a().aWS);
		hk.A().B();
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
		if (hL != null)
		{
			hL.a(new EventHandler(a));
			((SettingOrSpecialObject)hL).a(new EventHandler(B));
		}
		BM.f(new EventHandler(A));
		hm.Tick -= new EventHandler(E);
		if (disposing && hq != null)
		{
			((System.IDisposable)hq).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void f()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected O, but got Unknown
		hR = new ThemedTextBox();
		hr = new PictureBox();
		hS = new ThemedButton();
		hs = new ab();
		hT = new Label();
		ht = new ag();
		hU = new Label();
		hu = new aP();
		hV = new ThemedButton();
		hv = new PictureBox();
		((ISupportInitialize)hr).BeginInit();
		((ISupportInitialize)hv).BeginInit();
		((Control)this).SuspendLayout();
		((Control)hR).Location = new Point(29, 5);
		((Control)hR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fi();
		((Control)hR).Size = new Size(300, 22);
		((Control)hR).TabIndex = 0;
		((Control)hR).TextChanged += new EventHandler(d);
		((Control)hr).Location = new Point(4, 4);
		((Control)hr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fJ();
		((Control)hr).Size = new Size(24, 24);
		hr.TabIndex = 3;
		hr.TabStop = false;
		((Control)hS).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)hS).Location = new Point(332, 3);
		((Control)hS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fj();
		((Control)hS).Size = new Size(24, 25);
		((Control)hS).TabIndex = 1;
		((Control)hS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
		((ButtonBase)hS).UseVisualStyleBackColor = true;
		((Control)hS).Click += new EventHandler(D);
		((Control)hu).AutoSize = true;
		((Control)hu).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9.5f);
		((Control)hu).Location = new Point(530, 5);
		((Control)hu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fK();
		((Control)hu).Size = new Size(136, 21);
		((Control)hu).TabIndex = 2;
		((Control)hu).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fk();
		((ButtonBase)hu).UseVisualStyleBackColor = true;
		((CheckBox)hu).CheckedChanged += new EventHandler(c);
		((ListView)hs).BorderStyle = (BorderStyle)1;
		((ListView)hs).FullRowSelect = true;
		((ListView)hs).HideSelection = false;
		((Control)hs).Location = new Point(4, 31);
		((ListView)hs).MultiSelect = false;
		((Control)hs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fL();
		((ListView)hs).OwnerDraw = true;
		((ListView)hs).ShowItemToolTips = true;
		((Control)hs).Size = new Size(878, 586);
		((Control)hs).TabIndex = 3;
		((ListView)hs).UseCompatibleStateImageBehavior = false;
		((ListView)hs).View = (View)1;
		((ListView)hs).ColumnClick += new ColumnClickEventHandler(A);
		((ListView)hs).DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(A);
		((ListView)hs).DrawItem += new DrawListViewItemEventHandler(A);
		((ListView)hs).DrawSubItem += new DrawListViewSubItemEventHandler(A);
		((ListView)hs).ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(A);
		((Control)hs).DoubleClick += new EventHandler(b);
		((Control)hT).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
		((Control)hT).Location = new Point(889, 7);
		((Control)hT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fl();
		((Control)hT).Size = new Size(290, 20);
		((Control)hT).TabIndex = 5;
		((Control)hT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fE();
		((Control)hV).Enabled = false;
		((Control)hV).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9.5f);
		((Control)hV).Location = new Point(889, 28);
		((Control)hV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fM();
		((Control)hV).Size = new Size(290, 28);
		((Control)hV).TabIndex = 4;
		((Control)hV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fm();
		((ButtonBase)hV).UseVisualStyleBackColor = true;
		((Control)hV).Click += new EventHandler(C);
		((Control)hU).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
		((Control)hU).Location = new Point(889, 62);
		((Control)hU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fN();
		((Control)hU).Size = new Size(290, 20);
		((Control)hU).TabIndex = 6;
		((Control)hU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fe();
		((TextBoxBase)ht).BorderStyle = (BorderStyle)0;
		((TextBoxBase)ht).ReadOnly = true;
		((Control)ht).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
		((Control)ht).Location = new Point(889, 87);
		((Control)ht).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fn();
		((Control)ht).Size = new Size(290, 100);
		((Control)ht).TabIndex = 7;
		((Control)ht).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fF();
		((RichTextBox)ht).ScrollBars = (RichTextBoxScrollBars)2;
		((Control)hv).Location = new Point(889, 196);
		((Control)hv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fO();
		((Control)hv).Size = new Size(290, 370);
		hv.SizeMode = (PictureBoxSizeMode)4;
		hv.TabIndex = 8;
		hv.TabStop = false;
		((Control)hv).Visible = false;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)hv);
		((Control)this).Controls.Add((Control)(object)hV);
		((Control)this).Controls.Add((Control)(object)hu);
		((Control)this).Controls.Add((Control)(object)hU);
		((Control)this).Controls.Add((Control)(object)ht);
		((Control)this).Controls.Add((Control)(object)hT);
		((Control)this).Controls.Add((Control)(object)hs);
		((Control)this).Controls.Add((Control)(object)hS);
		((Control)this).Controls.Add((Control)(object)hr);
		((Control)this).Controls.Add((Control)(object)hR);
		((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fo();
		((Control)this).Size = new Size(1184, 621);
		((Control)this).Resize += new EventHandler(e);
		((ISupportInitialize)hr).EndInit();
		((ISupportInitialize)hv).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
internal class ag : RichTextBox
{
	[StructLayout(0)]
	internal class A
	{
		internal int BMj;

		internal int BMK;

		internal A()
		{
		}

		internal A(int P_0, int P_1)
		{
			BMj = P_0;
			BMK = P_1;
		}
	}

	private delegate void a();

	private aR hW = new aR();

	private aQ hw = new aQ();

	private Panel hX = new Panel();

	private const int hx = -16;

	private const int hY = 1048576;

	private const int hy = 2097152;

	private const int hZ = 0;

	private const int hz = 1;

	private const int IA = 1246;

	internal ag()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		((Control)this).MouseWheel += new MouseEventHandler(A);
		((Control)this).VisibleChanged += new EventHandler(b);
		((RichTextBox)this).SelectionChanged += new EventHandler(B);
		_ = ((Control)hw).Handle;
		_ = ((Control)hW).Handle;
		_ = ((Control)hX).Handle;
		_ = ((Control)this).Handle;
		((TextBoxBase)this).BorderStyle = (BorderStyle)0;
	}

	[DllImport("user32.dll", CharSet = 4, EntryPoint = "GetWindowLong")]
	private static extern int A(nint P_0, int P_1);

	[DllImport("user32", CharSet = 4, EntryPoint = "GetScrollRange")]
	private static extern bool A(nint P_0, int P_1, out int P_2, out int P_3);

	[DllImport("user32", CharSet = 4, EntryPoint = "SendMessage")]
	private static extern nint A(nint P_0, int P_1, int P_2, A P_3);

	internal void A()
	{
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = A;
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
			bool flag;
			bool flag2;
			try
			{
				int num3 = A(((Control)this).Handle, -16);
				flag = (num3 & 0x100000) != 0;
				flag2 = (num3 & 0x200000) != 0;
			}
			catch
			{
				return;
			}
			if (flag)
			{
				try
				{
					if (!((Control)hw).IsDisposed && !((Control)hw).Disposing)
					{
						A(((Control)this).Handle, 0, out var _, out var num5);
						int num6 = num5;
						((Control)hw).Visible = ((Control)this).Visible;
						((Control)hw).Left = num;
						((Control)hw).Top = num2 + (((Control)this).Height - ((Control)hw).Height) - 1;
						((Control)hw).Width = (flag2 ? (((Control)this).Width - ((Control)hW).Width) : ((Control)this).Width);
						hw.a(new EventHandler(A));
						hw.A(new EventHandler(A));
						hw.B(0);
						hw.a(((Control)this).Width / 40);
						hw.A((int)((float)((Control)this).Width / 3f));
						hw.b(num6 - ((Control)this).Width + hw.A());
						if (flag2)
						{
							aQ obj3 = hw;
							obj3.b(obj3.b() + ((Control)hW).Width);
						}
						hw.C((int)(B() * (float)hw.b()));
						if (parent != null && !parent.Controls.Contains((Control)(object)hw))
						{
							parent.Controls.Add((Control)(object)hw);
						}
						((Control)hw).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)hw).IsDisposed && !((Control)hw).Disposing)
			{
				try
				{
					((Control)hw).Visible = false;
				}
				catch
				{
				}
			}
			if (flag2)
			{
				try
				{
					if (!((Control)hW).IsDisposed && !((Control)hW).Disposing)
					{
						A(((Control)this).Handle, 1, out var _, out var num8);
						int num9 = num8 + 20;
						((Control)hW).Visible = ((Control)this).Visible;
						((Control)hW).Left = num + (((Control)this).Width - ((Control)hW).Width) - 1;
						((Control)hW).Top = num2;
						((Control)hW).Height = (flag ? (((Control)this).Height - ((Control)hw).Height) : ((Control)this).Height);
						hW.a(new EventHandler(this.a));
						hW.A(new EventHandler(this.a));
						hW.B(0);
						hW.a(((Control)this).Height / 40);
						hW.A((int)((float)((Control)this).Height / 3f));
						hW.b(num9 - ((Control)this).Height + hW.A());
						if (flag)
						{
							aR obj6 = hW;
							obj6.b(obj6.b() + ((Control)hw).Height);
						}
						hW.C((int)(this.a() * (float)hW.b()));
						if (parent != null && !parent.Controls.Contains((Control)(object)hW))
						{
							parent.Controls.Add((Control)(object)hW);
						}
						((Control)hW).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)hW).IsDisposed && !((Control)hW).Disposing)
			{
				try
				{
					((Control)hW).Visible = false;
				}
				catch
				{
				}
			}
			if (flag && flag2)
			{
				try
				{
					if (!((Control)hX).IsDisposed && !((Control)hX).Disposing)
					{
						((Control)hX).Visible = ((Control)this).Visible;
						hX.BorderStyle = (BorderStyle)0;
						((Control)hX).BackColor = BM.tl;
						((Control)hX).Size = new Size(((Control)hW).Width - 1, ((Control)hw).Height - 1);
						((Control)hX).Left = ((Control)hw).Right;
						((Control)hX).Top = ((Control)hW).Bottom;
						if (parent != null && !parent.Controls.Contains((Control)(object)hX))
						{
							parent.Controls.Add((Control)(object)hX);
						}
						((Control)hX).BringToFront();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			if (!((Control)hX).IsDisposed && !((Control)hX).Disposing)
			{
				try
				{
					((Control)hX).Visible = false;
					return;
				}
				catch
				{
					return;
				}
			}
			return;
		}
		if (!((Control)hw).IsDisposed && !((Control)hw).Disposing)
		{
			try
			{
				((Control)hw).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)hw))
				{
					parent.Controls.Remove((Control)(object)hw);
				}
			}
			catch
			{
			}
		}
		if (!((Control)hW).IsDisposed && !((Control)hW).Disposing)
		{
			try
			{
				((Control)hW).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)hW))
				{
					parent.Controls.Remove((Control)(object)hW);
				}
			}
			catch
			{
			}
		}
		if (((Control)hX).IsDisposed || ((Control)hX).Disposing)
		{
			return;
		}
		try
		{
			((Control)hX).Visible = false;
		}
		catch
		{
		}
		try
		{
			if (parent != null && parent.Controls.Contains((Control)(object)hX))
			{
				parent.Controls.Remove((Control)(object)hX);
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
			((Control)this).VisibleChanged -= new EventHandler(b);
			((RichTextBox)this).SelectionChanged -= new EventHandler(B);
		}
		catch
		{
		}
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			try
			{
				hw.a(new EventHandler(A));
				hW.a(new EventHandler(a));
			}
			catch
			{
			}
			try
			{
				((Component)hW).Dispose();
			}
			catch
			{
			}
			try
			{
				((Component)hw).Dispose();
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

	internal float a()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		int charIndexFromPosition = ((TextBoxBase)this).GetCharIndexFromPosition(new Point(1, 1));
		int lineFromCharIndex = ((TextBoxBase)this).GetLineFromCharIndex(charIndexFromPosition);
		int charIndexFromPosition2 = ((TextBoxBase)this).GetCharIndexFromPosition(new Point(1, ((Control)this).Height - 1));
		int lineFromCharIndex2 = ((TextBoxBase)this).GetLineFromCharIndex(charIndexFromPosition2);
		int lineFromCharIndex3 = ((TextBoxBase)this).GetLineFromCharIndex(((Control)this).Text.Length - 1);
		int num = lineFromCharIndex2 - lineFromCharIndex;
		if (lineFromCharIndex3 != 0)
		{
			return (float)lineFromCharIndex / (float)(lineFromCharIndex3 - num);
		}
		return 0f;
	}

	internal float B()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int selectionStart = ((TextBoxBase)this).SelectionStart;
		int lineFromCharIndex = ((TextBoxBase)this).GetLineFromCharIndex(selectionStart);
		int firstCharIndexFromLine = ((TextBoxBase)this).GetFirstCharIndexFromLine(lineFromCharIndex);
		Point positionFromCharIndex = ((TextBoxBase)this).GetPositionFromCharIndex(firstCharIndexFromLine);
		int num = 100 * (1 - ((Point)(ref positionFromCharIndex)).X);
		Size clientSize = ((Control)this).ClientSize;
		return num / ((Size)(ref clientSize)).Width;
	}

	private void A(object P_0, EventArgs P_1)
	{
		A(((Control)this).Handle, 1246, 0, new A(hw.C(), 0));
		((Control)hw).Invalidate();
	}

	private void a(object P_0, EventArgs P_1)
	{
		A(((Control)this).Handle, 1246, 0, new A(0, hW.C()));
		((Control)hW).Invalidate();
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		A();
	}

	private void B(object P_0, EventArgs P_1)
	{
		A();
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (!((Control)this).Visible)
		{
			((Control)hw).Visible = false;
			((Control)hW).Visible = false;
			((Control)hX).Visible = false;
		}
		else
		{
			A();
		}
	}

	internal void A(string P_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		((RichTextBox)this).SelectionFont = ((Control)this).Font;
		int num = 0;
		bool flag = false;
		bool flag2 = false;
		StringBuilder val = new StringBuilder();
		do
		{
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			if (num <= P_0.Length - 4)
			{
				if (P_0[num] == '<' && P_0[num + 1] == '/' && P_0[num + 2] == 'b' && P_0[num + 3] == '>')
				{
					num += 4;
					flag4 = true;
					flag3 = true;
				}
				else if (P_0[num] == '<' && P_0[num + 1] == '/' && P_0[num + 2] == 'i' && P_0[num + 3] == '>')
				{
					num += 4;
					flag5 = true;
					flag3 = true;
				}
			}
			if (num <= P_0.Length - 3)
			{
				if (P_0[num] == '<' && P_0[num + 1] == 'b' && P_0[num + 2] == '>')
				{
					flag = true;
					num += 3;
					flag3 = true;
				}
				else if (P_0[num] == '<' && P_0[num + 1] == 'i' && P_0[num + 2] == '>')
				{
					flag2 = true;
					num += 3;
					flag3 = true;
				}
			}
			if (!flag3)
			{
				val.Append(P_0.Substring(num, 1));
				num++;
			}
			if (!flag3 && num != P_0.Length)
			{
				continue;
			}
			string text = ((object)val).ToString();
			int length = text.Length;
			if (length != 0)
			{
				int length2 = ((Control)this).Text.Length;
				((TextBoxBase)this).AppendText(text);
				val.Clear();
				((TextBoxBase)this).Select(length2, length);
				if (flag && flag4)
				{
					((RichTextBox)this).SelectionFont = new Font(((Control)this).Font.FontFamily, ((Control)this).Font.Size, (FontStyle)1);
					((TextBoxBase)this).SelectionLength = 0;
					((RichTextBox)this).SelectionFont = ((Control)this).Font;
					flag = false;
				}
				else if (flag2 && flag5)
				{
					((RichTextBox)this).SelectionFont = new Font(((Control)this).Font.FontFamily, ((Control)this).Font.Size, (FontStyle)2);
					((TextBoxBase)this).SelectionLength = 0;
					((RichTextBox)this).SelectionFont = ((Control)this).Font;
					flag2 = false;
				}
				else
				{
					((RichTextBox)this).SelectionFont = ((Control)this).Font;
					((TextBoxBase)this).SelectionLength = 0;
				}
			}
		}
		while (num < P_0.Length);
	}
}
