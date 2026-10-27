using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.SettingsFramework;

namespace NSP.UserInterface.Forms;

public class DTCManagerForm : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A BPf = new A();

		public static Func<KeyValuePair<string, Dictionary<string, string>>, bool> BPG;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, string> BPg;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>> BPH;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, bool> BPh;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, string> BPI;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>> BPi;

		internal bool A(KeyValuePair<string, Dictionary<string, string>> P_0)
		{
			return !P_0.Value.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kw());
		}

		internal string a(KeyValuePair<string, Dictionary<string, string>> P_0)
		{
			return P_0.Key;
		}

		internal Dictionary<string, string> B(KeyValuePair<string, Dictionary<string, string>> P_0)
		{
			return P_0.Value;
		}

		internal bool b(KeyValuePair<string, Dictionary<string, string>> P_0)
		{
			return P_0.Value.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kw());
		}

		internal string C(KeyValuePair<string, Dictionary<string, string>> P_0)
		{
			return P_0.Key;
		}

		internal Dictionary<string, string> c(KeyValuePair<string, Dictionary<string, string>> P_0)
		{
			return P_0.Value;
		}
	}

	private Framework oq;

	private DataTableObject oR;

	private ThemedDataTable or;

	private IContainer oS;

	private TableLayoutPanel os;

	private ThemedButton oT;

	private TableLayoutPanel ot;

	public DTCManagerForm(Framework framework, DataTableObject data)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		a();
		((Control)this).BackColor = BM.tg;
		((Control)this).ForeColor = BM.te;
		oq = framework;
		Dictionary<string, Dictionary<string, string>> val = Enumerable.ToDictionary<KeyValuePair<string, Dictionary<string, string>>, string, Dictionary<string, string>>(Enumerable.Where<KeyValuePair<string, Dictionary<string, string>>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, Dictionary<string, string>>>)data.Data, (Func<KeyValuePair<string, Dictionary<string, string>>, bool>)((KeyValuePair<string, Dictionary<string, string>> P_0) => !P_0.Value.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kw()))), (Func<KeyValuePair<string, Dictionary<string, string>>, string>)((KeyValuePair<string, Dictionary<string, string>> P_0) => P_0.Key), (Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>>)((KeyValuePair<string, Dictionary<string, string>> P_0) => P_0.Value));
		Enumerator<string, Dictionary<string, string>> enumerator = Enumerable.ToDictionary<KeyValuePair<string, Dictionary<string, string>>, string, Dictionary<string, string>>(Enumerable.Where<KeyValuePair<string, Dictionary<string, string>>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, Dictionary<string, string>>>)data.Data, (Func<KeyValuePair<string, Dictionary<string, string>>, bool>)((KeyValuePair<string, Dictionary<string, string>> P_0) => P_0.Value.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kw()))), (Func<KeyValuePair<string, Dictionary<string, string>>, string>)((KeyValuePair<string, Dictionary<string, string>> P_0) => P_0.Key), (Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>>)((KeyValuePair<string, Dictionary<string, string>> P_0) => P_0.Value)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, Dictionary<string, string>> current = enumerator.Current;
				string text = null;
				try
				{
					text = current.Value[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kw()];
					T.A(ref text, framework);
					if (T.A(ref text))
					{
						val.Add(current.Key, current.Value);
					}
				}
				catch (System.Exception)
				{
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		oR = data;
		oR.Data = val;
		oR.IndexColName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KX();
		oR.IdColName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kx();
		oR.SettingMapColName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KY();
		oR.DataToSettingMap = oq.aWW.ErrorToSettingMap;
		oR.GroupDataName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ky();
		oR.GroupDescDataName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT();
		oR.SelectedItemDataName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KZ();
		Enumerator<DataTableColumn> enumerator2 = oR.Columns.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				DataTableColumn current2 = enumerator2.Current;
				if (string.IsNullOrEmpty(current2.EnumValueStr) && !string.IsNullOrEmpty(current2.BindingData?.BindingDataId))
				{
					current2.PopulateEnumStrFromSettingEnums(oq);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		Enumerator<IFilter> enumerator3 = oR.Filters.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				IFilter current3 = enumerator3.Current;
				if (current3 is CheckboxFilter && string.IsNullOrEmpty((current3 as CheckboxFilter).OptionsStr))
				{
					(current3 as CheckboxFilter).PopulateOptionsStrFromSettingEnums(oq);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator3).Dispose();
		}
		or = new ThemedDataTable(data, framework);
		((Control)or).Dock = (DockStyle)5;
		((ControlCollection)os.Controls).Add((Control)(object)or);
		os.SetColumn((Control)(object)or, 0);
		os.SetRow((Control)(object)or, 0);
		((Control)this).Controls.Add((Control)(object)os);
		((Control)this).Width = 875;
		or.SetPreferredWidth(((Control)this).Width);
		or.ItemsSelected += A;
		BM.C(new EventHandler(A));
		((Form)this).FormClosing += new FormClosingEventHandler(A);
	}

	private void A(object P_0, EventArgs P_1)
	{
		((Form)this).Close();
	}

	private void A(object P_0, FormClosingEventArgs P_1)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		or.ItemsSelected -= A;
		((Control)or).Enabled = false;
		or.Dispose();
		BM.c(new EventHandler(A));
	}

	private void A(object P_0, string P_1)
	{
		int num = default(int);
		if (P_1 != null && int.TryParse(P_1, ref num))
		{
			BM.QQ.rL.a(num);
			A();
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		A();
	}

	private void A()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		((Control)this).BeginInvoke((System.Delegate)(MethodInvoker)([CompilerGenerated] () =>
		{
			((Form)this).Close();
		}));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && oS != null)
		{
			((System.IDisposable)oS).Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void a()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		os = new TableLayoutPanel();
		ot = new TableLayoutPanel();
		oT = new ThemedButton();
		((Control)os).SuspendLayout();
		((Control)ot).SuspendLayout();
		((Control)this).SuspendLayout();
		os.ColumnCount = 1;
		os.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		os.Controls.Add((Control)(object)ot, 0, 1);
		((Control)os).Dock = (DockStyle)5;
		((Control)os).Location = new Point(0, 0);
		((Control)os).Margin = new Padding(4);
		((Control)os).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gx();
		os.RowCount = 2;
		os.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		os.RowStyles.Add(new RowStyle((SizeType)1, 65f));
		((Control)os).Size = new Size(912, 1030);
		((Control)os).TabIndex = 0;
		ot.ColumnCount = 2;
		ot.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		ot.ColumnStyles.Add(new ColumnStyle((SizeType)1, 10f));
		ot.Controls.Add((Control)(object)oT, 0, 0);
		((Control)ot).Dock = (DockStyle)5;
		((Control)ot).Location = new Point(3, 968);
		((Control)ot).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CU();
		ot.RowCount = 2;
		ot.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		ot.RowStyles.Add(new RowStyle((SizeType)1, 10f));
		((Control)ot).Size = new Size(906, 59);
		((Control)ot).TabIndex = 1;
		((Control)oT).Dock = (DockStyle)4;
		((Control)oT).Location = new Point(759, 4);
		((Control)oT).Margin = new Padding(4);
		((Control)oT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kz();
		((Control)oT).Size = new Size(133, 41);
		((Control)oT).TabIndex = 0;
		((Control)oT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
		((ButtonBase)oT).UseVisualStyleBackColor = true;
		((Control)oT).Click += new EventHandler(a);
		((ContainerControl)this).AutoScaleDimensions = new SizeF(8f, 19f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(912, 1030);
		((Control)this).Controls.Add((Control)(object)os);
		((Form)this).Margin = new Padding(4);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kA();
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ka();
		((Control)os).ResumeLayout(false);
		((Control)ot).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[CompilerGenerated]
	private void B()
	{
		((Form)this).Close();
	}
}
