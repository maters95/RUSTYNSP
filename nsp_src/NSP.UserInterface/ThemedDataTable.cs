using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using NSP.SettingsFramework;
using NSP.Utils;
using a;

namespace NSP.UserInterface;

public class ThemedDataTable : UserControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A BNX = new A();

		public static Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>> BNx;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>> BNY;

		internal Dictionary<string, string> A(KeyValuePair<string, Dictionary<string, string>> P_0)
		{
			return P_0.Value;
		}

		internal Dictionary<string, string> a(KeyValuePair<string, Dictionary<string, string>> P_0)
		{
			return P_0.Value;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public IFilter BNy;

		public ThemedDataTable BNZ;
	}

	[CompilerGenerated]
	private sealed class B
	{
		public ThemedSearchBox BNz;

		public a BnA;

		internal void A(object? s, EventArgs P_1)
		{
			BnA.BNZ.A(BnA.BNy, (Control)(object)BNz, P_1);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public CheckboxFilter Bna;

		public ap BnB;

		public a Bnb;

		internal void A(object? s, ItemCheckEventArgs P_1)
		{
			Bnb.BNZ.A(Bnb.BNy, (Control)(object)BnB, (EventArgs)(object)P_1);
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public int BnC;

		public b Bnc;

		internal void A(object? s, EventArgs P_1)
		{
			Bnc.Bnb.BNZ.A(Bnc.Bna, BnC);
		}
	}

	[CompilerGenerated]
	private sealed class c
	{
		public ThemedDataTable BnD;

		public int Bnd;

		internal bool A(Dictionary<string, string> P_0)
		{
			return P_0[BnD.ji.IdColName] == BnD.jH[Bnd][BnD.ji.IdColName];
		}
	}

	[CompilerGenerated]
	private sealed class D
	{
		public Setting BnE;

		internal bool A(CK P_0)
		{
			return P_0.BCF.DataId == BnE.C().DataId;
		}
	}

	[CompilerGenerated]
	private sealed class d
	{
		public SearchFilter Bne;

		public ThemedDataTable BnF;

		internal bool A(Dictionary<string, string> P_0)
		{
			return BnF.A(Bne.Headers, P_0).Contains(BnF.A(Bne.Value));
		}
	}

	[CompilerGenerated]
	private sealed class E
	{
		public CheckboxFilter Bnf;

		public ThemedDataTable BnG;

		internal bool A(Dictionary<string, string> P_0)
		{
			return BnG.A(Bnf, P_0);
		}
	}

	[CompilerGenerated]
	private sealed class e
	{
		public List<Dictionary<string, string>> Bng;

		internal bool A(Dictionary<string, string> P_0)
		{
			return Bng.Contains(P_0);
		}
	}

	[CompilerGenerated]
	private EventHandler<string> jG;

	private List<Dictionary<string, string>> jg;

	private List<Dictionary<string, string>> jH;

	private Dictionary<string, Tuple<string, BindingData>> jh = new Dictionary<string, Tuple<string, BindingData>>();

	private bool jI = true;

	private DataTableObject ji;

	private Framework jJ;

	private Font jj = new Font(Control.DefaultFont.FontFamily, 9f, (FontStyle)0);

	private Font jK = new Font(Control.DefaultFont.FontFamily, 9f, (FontStyle)4);

	private bool jk = true;

	private bool jL;

	private Cj jl;

	private Stack<Cj> jM = new Stack<Cj>();

	private Stack<Cj> jm = new Stack<Cj>();

	private bool jN;

	private IContainer jn;

	private TableLayoutPanel jO;

	private DataGridViewWithThemedScrollBars jo;

	private TableLayoutPanel jP;

	public event EventHandler<string> ItemsSelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler<string> val = jG;
			EventHandler<string> val2;
			do
			{
				val2 = val;
				EventHandler<string> val3 = (EventHandler<string>)(object)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler<string>>(ref jG, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<string> val = jG;
			EventHandler<string> val2;
			do
			{
				val2 = val;
				EventHandler<string> val3 = (EventHandler<string>)(object)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler<string>>(ref jG, val3, val2);
			}
			while (val != val2);
		}
	}

	public ThemedDataTable(DataTableObject tableInfo, Framework framework)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (tableInfo != null && tableInfo.Columns != null && tableInfo.Data != null)
		{
			ji = tableInfo;
			jJ = framework;
			jo = new DataGridViewWithThemedScrollBars();
			((Control)this).Resize += (EventHandler)([CompilerGenerated] (object? s, EventArgs P_1) =>
			{
				jo.C();
			});
			C();
			((DataGridView)jo).RowHeadersVisible = false;
			((DataGridView)jo).AllowUserToResizeColumns = true;
			((DataGridView)jo).SelectionMode = (DataGridViewSelectionMode)1;
			((DataGridView)jo).MultiSelect = true;
			((DataGridView)jo).EditMode = (DataGridViewEditMode)0;
			((DataGridView)jo).AllowUserToResizeRows = true;
			((DataGridView)jo).AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)0;
			((DataGridView)jo).ShowCellToolTips = true;
			((Control)jO).Padding = new Padding(10, 0, 10, 0);
			SetTheme();
			CreateFilters();
			BuildData();
			BuildColumns();
			A();
			RefreshAllBindings(fromUndoRedo: false);
			RefreshDataTable();
			jk = false;
		}
	}

	public void Dispose()
	{
		a();
		jJ = null;
	}

	public void SetTheme()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		((Control)this).BackColor = BM.tg;
		((Control)this).ForeColor = BM.te;
		((DataGridView)jo).BackgroundColor = BM.tg;
		((Control)jo).ForeColor = BM.te;
		((DataGridView)jo).ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
		{
			BackColor = BM.tg,
			ForeColor = BM.te
		};
		((DataGridView)jo).DefaultCellStyle = new DataGridViewCellStyle
		{
			BackColor = BM.to,
			ForeColor = BM.te,
			Font = jj
		};
		((DataGridView)jo).BorderStyle = (BorderStyle)0;
	}

	public void CreateFilters()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		jP.ColumnCount = ji.Filters.Count;
		for (int i = 0; i < jP.ColumnCount; i++)
		{
			jP.ColumnStyles.Add(new ColumnStyle((SizeType)0));
		}
		ContextMenuStrip val = new ContextMenuStrip();
		((ToolStrip)val).BackColor = BM.tg;
		((ToolStrip)val).ForeColor = BM.te;
		int num = 0;
		Enumerator<IFilter> enumerator = ji.Filters.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				IFilter BNy = enumerator.Current;
				if (BNy == null)
				{
					break;
				}
				Label val2 = new Label();
				((Control)val2).Text = BNy.Text;
				((Control)val2).Font = new Font(Control.DefaultFont.FontFamily, 10f, (FontStyle)1);
				((Control)val2).ForeColor = BM.te;
				((Control)val2).Dock = (DockStyle)5;
				val2.TextAlign = (ContentAlignment)32;
				((ControlCollection)jP.Controls).Add((Control)(object)val2);
				jP.SetRow((Control)(object)val2, 0);
				jP.SetColumn((Control)(object)val2, num);
				if (BNy is SearchFilter)
				{
					ThemedSearchBox BNz = new ThemedSearchBox();
					((Control)BNz).ForeColor = BM.te;
					((Control)BNz).BackColor = BM.to;
					((Control)BNz).Dock = (DockStyle)5;
					((UserControl)BNz).TextChanged += (EventHandler)delegate(object? s, EventArgs P_1)
					{
						A(BNy, (Control)(object)BNz, P_1);
					};
					((ControlCollection)jP.Controls).Add((Control)(object)BNz);
					jP.SetRow((Control)(object)BNz, 1);
					jP.SetColumn((Control)(object)BNz, num);
				}
				else if (BNy is CheckboxFilter)
				{
					ap BnB = new ap();
					((Control)BnB).ForeColor = BM.te;
					((Control)BnB).BackColor = BM.to;
					((CheckedListBox)BnB).CheckOnClick = true;
					BnB.A(true);
					CheckboxFilter Bna = BNy as CheckboxFilter;
					ToolStripLabel val3 = new ToolStripLabel(Bna.Text ?? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
					if (Bna.BulkEdit)
					{
						((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
					}
					if (Bna.Options.Length != 0)
					{
						((ObjectCollection)((CheckedListBox)BnB).Items).Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gv());
					}
					ObjectCollection items = ((CheckedListBox)BnB).Items;
					object[] options = Bna.Options;
					((ObjectCollection)items).AddRange(options);
					for (int j = 0; j < ((ObjectCollection)((CheckedListBox)BnB).Items).Count; j++)
					{
						if (Bna.ItemStates == null)
						{
							Bna.ItemStates = (CheckState[])(object)new CheckState[((ObjectCollection)((CheckedListBox)BnB).Items).Count];
						}
						Bna.ItemStates[j] = (CheckState)1;
						((CheckedListBox)BnB).SetItemCheckState(j, (CheckState)1);
						if (j != 0)
						{
							ToolStripMenuItem val4 = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GW() + Bna.Options[j - 1]);
							int BnC = j - 1;
							((ToolStripItem)val4).Click += (EventHandler)delegate
							{
								A(Bna, BnC);
							};
							if (Bna.BulkEdit)
							{
								((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
							}
						}
					}
					if (Bna.BulkEdit)
					{
						((ToolStrip)val).Items.Add((ToolStripItem)new ToolStripSeparator());
					}
					((CheckedListBox)BnB).ItemCheck += (ItemCheckEventHandler)delegate(object? s, ItemCheckEventArgs P_1)
					{
						A(BNy, (Control)(object)BnB, (EventArgs)(object)P_1);
					};
					((ControlCollection)jP.Controls).Add((Control)(object)BnB);
					jP.SetRow((Control)(object)BnB, 1);
					jP.SetColumn((Control)(object)BnB, num);
					BnB.a();
				}
				num++;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		((Control)jo).ContextMenuStrip = val;
	}

	public void BuildColumns()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		Enumerator<DataTableColumn> enumerator = ji.Columns.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataTableColumn current = enumerator.Current;
				switch (current.Type)
				{
				case DataTableColumnType.Text:
				{
					DataGridViewTextBoxColumn val2 = new DataGridViewTextBoxColumn
					{
						HeaderText = current.HeaderText,
						Name = current.HeaderText,
						ToolTipText = ((current.Tooltip != null) ? current.Tooltip.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gw(), Environment.NewLine) : null)
					};
					((DataGridViewBand)val2).Visible = current.Visible;
					if (current.EnumValues != null)
					{
						((DataGridViewColumn)val2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
						((DataGridViewColumn)val2).Width = CalcBestColumnWidth(current.HeaderText, current.EnumValues);
					}
					else
					{
						((DataGridViewColumn)val2).AutoSizeMode = current.AutoSize;
					}
					((DataGridView)jo).Columns.Add((DataGridViewColumn)(object)val2);
					if (current.BindingData != null)
					{
						jh.Add(current.HeaderText, new Tuple<string, BindingData>(current.BindingData.BindingDataId, current.BindingData));
					}
					break;
				}
				case DataTableColumnType.Enum:
				{
					DataGridViewComboBoxColumn val = new DataGridViewComboBoxColumn
					{
						HeaderText = current.HeaderText,
						Name = current.HeaderText,
						FlatStyle = (FlatStyle)0,
						ToolTipText = ((current.Tooltip != null) ? current.Tooltip.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gw(), Environment.NewLine) : null)
					};
					jh.Add(current.HeaderText, new Tuple<string, BindingData>(current.BindingData.BindingDataId, current.BindingData));
					((DataGridViewBand)val).Visible = current.Visible;
					((DataGridViewColumn)val).AutoSizeMode = (DataGridViewAutoSizeColumnMode)10;
					((DataGridView)jo).Columns.Add((DataGridViewColumn)(object)val);
					break;
				}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void A()
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
		((DataGridView)jo).CurrentCellDirtyStateChanged += new EventHandler(A);
		((DataGridView)jo).CellValueChanged += new DataGridViewCellEventHandler(b);
		((DataGridView)jo).CellContentDoubleClick += new DataGridViewCellEventHandler(B);
		((DataGridView)jo).CellEnter += new DataGridViewCellEventHandler(a);
		((DataGridView)jo).CellMouseEnter += new DataGridViewCellEventHandler(A);
	}

	private void a()
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
		((DataGridView)jo).CurrentCellDirtyStateChanged -= new EventHandler(A);
		((DataGridView)jo).CellValueChanged -= new DataGridViewCellEventHandler(b);
		((DataGridView)jo).CellContentDoubleClick -= new DataGridViewCellEventHandler(B);
		((DataGridView)jo).CellEnter -= new DataGridViewCellEventHandler(a);
		((DataGridView)jo).CellMouseEnter -= new DataGridViewCellEventHandler(A);
	}

	private void A(object P_0, DataGridViewCellEventArgs P_1)
	{
		if (P_1.RowIndex >= 0 && P_1.RowIndex < jH.Count)
		{
			if (jH[P_1.RowIndex].ContainsKey(ji.SelectedItemDataName))
			{
				((Control)jo).Cursor = Cursors.Hand;
			}
			else
			{
				((Control)jo).Cursor = Cursors.Default;
			}
		}
	}

	private void a(object P_0, DataGridViewCellEventArgs P_1)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		bool flag = P_1.RowIndex != -1 && P_1.ColumnIndex != -1;
		if (((DataGridView)jo).Columns[P_1.ColumnIndex] is DataGridViewComboBoxColumn && flag)
		{
			((DataGridView)jo).BeginEdit(true);
			((ComboBox)((DataGridView)jo).EditingControl).DroppedDown = true;
		}
	}

	private void B(object P_0, DataGridViewCellEventArgs P_1)
	{
		if (jk)
		{
			return;
		}
		bool flag = false;
		if (ji.Columns.Count > P_1.ColumnIndex && ji.Columns[P_1.ColumnIndex].MenuLink != null)
		{
			flag = true;
		}
		if (flag && jH[P_1.RowIndex].ContainsKey(ji.SelectedItemDataName))
		{
			string text = jH[P_1.RowIndex][ji.SelectedItemDataName];
			if (jG != null)
			{
				jG.Invoke((object)this, text);
			}
		}
	}

	private void b(object P_0, DataGridViewCellEventArgs P_1)
	{
		if (!jk)
		{
			string headerText = ((DataGridView)jo).Columns[P_1.ColumnIndex].HeaderText;
			DataGridViewCell val = ((DataGridView)jo).Rows[P_1.RowIndex].Cells[P_1.ColumnIndex];
			object new_value = val.Value;
			if (val is DataGridViewComboBoxCell)
			{
				DataGridViewComboBoxCell val2 = (DataGridViewComboBoxCell)(object)((val is DataGridViewComboBoxCell) ? val : null);
				new_value = Enumerable.ToList<object>(Enumerable.Cast<object>((System.Collections.IEnumerable)val2.Items)).IndexOf(((DataGridViewCell)val2).Value);
			}
			RefreshSingleBindingByIndex(P_1.RowIndex, headerText, new_value, fromUndoRedo: false);
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (!jk && ((DataGridView)jo).IsCurrentCellDirty)
		{
			((DataGridView)jo).CommitEdit((DataGridViewDataErrorContexts)512);
		}
	}

	public void BuildData()
	{
		if (ji.GroupDataName != null)
		{
			Dictionary<string, Pair<string, int>> val = new Dictionary<string, Pair<string, int>>();
			List<Dictionary<string, string>> val2 = Enumerable.ToList<Dictionary<string, string>>(Enumerable.Select<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, Dictionary<string, string>>>)ji.Data, (Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>>)((KeyValuePair<string, Dictionary<string, string>> P_0) => P_0.Value)));
			for (int i = 0; i < val2.Count; i++)
			{
				if (val2[i].ContainsKey(ji.GroupDataName))
				{
					if (val.ContainsKey(val2[i][ji.GroupDataName]))
					{
						Pair<string, int> pair = val[val2[i][ji.GroupDataName]];
						string text = val2[i][ji.IdColName];
						pair.First = pair.First + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + text;
						val2[pair.Second][ji.IdColName] = pair.First;
						val2.RemoveAt(i);
						i--;
					}
					else
					{
						val.Add(val2[i][ji.GroupDataName], new Pair<string, int>
						{
							First = val2[i][ji.IdColName],
							Second = i
						});
						val2[i][ji.GroupDescDataName] = val2[i][ji.GroupDataName];
					}
				}
			}
			jg = val2;
			jH = new List<Dictionary<string, string>>((System.Collections.Generic.IEnumerable<Dictionary<string, string>>)jg);
		}
		else
		{
			jg = Enumerable.ToList<Dictionary<string, string>>(Enumerable.Select<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, Dictionary<string, string>>>)ji.Data, (Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>>)((KeyValuePair<string, Dictionary<string, string>> P_0) => P_0.Value)));
			jH = new List<Dictionary<string, string>>((System.Collections.Generic.IEnumerable<Dictionary<string, string>>)jg);
		}
	}

	public void SetPreferredWidth(int width)
	{
		((Control)jo).Width = width;
		((Control)this).Width = width;
	}

	public int CalcBestColumnWidth(string headerText, string[] options)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Size val = TextRenderer.MeasureText(headerText, jj);
		int num = 0;
		for (int i = 0; i < options.Length; i++)
		{
			Size val2 = TextRenderer.MeasureText(options[i], jj);
			if (((Size)(ref val2)).Width > num)
			{
				num = ((Size)(ref val2)).Width;
			}
		}
		return (int)((float)((num > ((Size)(ref val)).Width) ? num : ((Size)(ref val)).Width) + 10f);
	}

	public void RefreshAllBindings(bool fromUndoRedo)
	{
		for (int i = 0; i < jg.Count; i++)
		{
			RefreshSingleBinding(jg[i], fromUndoRedo);
		}
	}

	public void RefreshSingleBindingByIndex(int index, string headerText, object new_value, bool fromUndoRedo)
	{
		if (!jI && index >= 0 && index < jH.Count)
		{
			Dictionary<string, string> val = Enumerable.FirstOrDefault<Dictionary<string, string>>(Enumerable.Where<Dictionary<string, string>>((System.Collections.Generic.IEnumerable<Dictionary<string, string>>)jg, (Func<Dictionary<string, string>, bool>)((Dictionary<string, string> P_0) => P_0[ji.IdColName] == jH[index][ji.IdColName])));
			if (val.ContainsKey(headerText))
			{
				val[headerText] = new_value.ToString();
			}
			RefreshSingleBinding(val, fromUndoRedo);
		}
	}

	public void RefreshSingleBinding(Dictionary<string, string> row, bool fromUndoRedo)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (jh.Count == 0)
		{
			return;
		}
		Enumerator<string, Tuple<string, BindingData>> enumerator = jh.GetEnumerator();
		try
		{
			int num2 = default(int);
			int num3 = default(int);
			byte b = default(byte);
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, Tuple<string, BindingData>> current = enumerator.Current;
				int num = -1;
				if (current.Value.Item2.IsMapped && row.ContainsKey(ji.SettingMapColName) && int.TryParse(row[ji.SettingMapColName], ref num2))
				{
					num = num2;
				}
				else if (row.ContainsKey(ji.IndexColName) && !int.TryParse(row[ji.IndexColName], ref num))
				{
					break;
				}
				if (!int.TryParse(current.Value.Item1, ref num3))
				{
					continue;
				}
				Setting BnE = jJ.A(num3);
				byte[] array = BnE.aY();
				int num4 = array[num];
				if (!row.ContainsKey(current.Key))
				{
					row.Add(current.Key, num4.ToString());
				}
				else if (current.Value.Item2.BindingType == DataTableBindType.TwoWay && byte.TryParse(row[current.Key], ref b) && !fromUndoRedo)
				{
					if (b == num4)
					{
						continue;
					}
					if (!jL)
					{
						Cj cj = new Cj();
						cj.A(BnE);
						cj.A(BnE, 0, array.Length);
						jM.Push(cj);
						jm.Clear();
					}
					else
					{
						if (jl == null)
						{
							jl = new Cj();
						}
						if (!Enumerable.Any<CK>(Enumerable.Where<CK>((System.Collections.Generic.IEnumerable<CK>)jl.A(), (Func<CK, bool>)((CK P_0) => P_0.BCF.DataId == BnE.C().DataId))))
						{
							jl.A(BnE);
						}
						jl.A(BnE, 0, array.Length);
					}
					BnE.A(num, b, true);
				}
				else if (current.Value.Item2.BindingType == DataTableBindType.OneWay || fromUndoRedo)
				{
					row[current.Key] = num4.ToString();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void RefreshDataTable()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		jI = true;
		((DataGridView)jo).Rows.Clear();
		Enumerator<Dictionary<string, string>> enumerator = jH.GetEnumerator();
		try
		{
			int num2 = default(int);
			int num3 = default(int);
			while (enumerator.MoveNext())
			{
				Dictionary<string, string> current = enumerator.Current;
				int num = ((DataGridView)jo).Rows.Add();
				Enumerator<DataTableColumn> enumerator2 = ji.Columns.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						DataTableColumn current2 = enumerator2.Current;
						if (!current.ContainsKey(current2.HeaderText))
						{
							continue;
						}
						if (current2.Type == DataTableColumnType.Enum)
						{
							DataGridViewComboBoxCell val = (DataGridViewComboBoxCell)((DataGridView)jo).Rows[num].Cells[current2.HeaderText];
							val.Items.Clear();
							string[] enumValues = current2.EnumValues;
							foreach (string text in enumValues)
							{
								val.Items.Add((object)text);
							}
							if (!int.TryParse(((object)current[current2.HeaderText]).ToString(), ref num2))
							{
								throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GX() + current2.HeaderText + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ() + current[current2.HeaderText]);
							}
							((DataGridViewCell)val).Value = current2.EnumValues[num2];
						}
						else
						{
							if (current2.MenuLink != null && current.ContainsKey(current2.MenuLink))
							{
								((DataGridView)jo).Rows[num].Cells[current2.HeaderText].Style.Font = jK;
							}
							string text2 = current[current2.HeaderText];
							if (current2.EnumValues != null && int.TryParse(text2, ref num3))
							{
								text2 = current2.EnumValues[num3];
							}
							((DataGridView)jo).Rows[num].Cells[current2.HeaderText].Value = text2;
							((DataGridView)jo).Rows[num].Cells[current2.HeaderText].ReadOnly = true;
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
		jo.C();
		jI = false;
	}

	private void A(IFilter P_0, Control P_1, EventArgs P_2)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected I4, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (jN)
		{
			return;
		}
		jN = true;
		if (P_0 is SearchFilter)
		{
			SearchFilter obj = (SearchFilter)P_0;
			ThemedSearchBox themedSearchBox = P_1 as ThemedSearchBox;
			obj.Value = ((Control)themedSearchBox).Text;
		}
		else if (P_0 is CheckboxFilter)
		{
			CheckboxFilter checkboxFilter = (CheckboxFilter)P_0;
			CheckedListBox val = (CheckedListBox)(object)((P_1 is CheckedListBox) ? P_1 : null);
			ItemCheckEventArgs val2 = (ItemCheckEventArgs)(object)((P_2 is ItemCheckEventArgs) ? P_2 : null);
			checkboxFilter.ItemStates[val2.Index] = (CheckState)(int)val2.NewValue;
			if (val2.Index == 0)
			{
				if ((int)val2.NewValue == 1)
				{
					for (int i = 0; i < ((ObjectCollection)val.Items).Count; i++)
					{
						checkboxFilter.ItemStates[i] = (CheckState)1;
						val.SetItemCheckState(i, (CheckState)1);
					}
				}
				else if ((int)val2.NewValue == 0)
				{
					for (int j = 0; j < ((ObjectCollection)val.Items).Count; j++)
					{
						checkboxFilter.ItemStates[j] = (CheckState)0;
						val.SetItemCheckState(j, (CheckState)0);
					}
				}
			}
		}
		A(ji.Filters);
		jN = false;
	}

	private void A(List<IFilter> P_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		jk = true;
		jH = new List<Dictionary<string, string>>((System.Collections.Generic.IEnumerable<Dictionary<string, string>>)jg);
		Enumerator<IFilter> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				IFilter current = enumerator.Current;
				if (current is SearchFilter)
				{
					SearchFilter Bne = (SearchFilter)current;
					if (Bne.Value != string.Empty && Bne.Value != null)
					{
						jH = Enumerable.ToList<Dictionary<string, string>>(Enumerable.Where<Dictionary<string, string>>((System.Collections.Generic.IEnumerable<Dictionary<string, string>>)jH, (Func<Dictionary<string, string>, bool>)((Dictionary<string, string> P_0) => A(Bne.Headers, P_0).Contains(A(Bne.Value)))));
					}
				}
				else if (current is CheckboxFilter)
				{
					CheckboxFilter Bnf = (CheckboxFilter)current;
					jH = Enumerable.ToList<Dictionary<string, string>>(Enumerable.Where<Dictionary<string, string>>((System.Collections.Generic.IEnumerable<Dictionary<string, string>>)jH, (Func<Dictionary<string, string>, bool>)((Dictionary<string, string> P_0) => A(Bnf, P_0))));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		RefreshDataTable();
		jk = false;
	}

	private string A(string[] P_0, Dictionary<string, string> P_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		string text = string.Empty;
		Enumerator<string, string> enumerator = P_1.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, string> current = enumerator.Current;
				if (Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)P_0, current.Key))
				{
					text += ((object)current.Value).ToString();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return A(text);
	}

	private string A(string P_0)
	{
		if (P_0 != null)
		{
			return P_0.ToLowerInvariant().Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
		}
		return string.Empty;
	}

	private bool A(CheckboxFilter P_0, Dictionary<string, string> P_1)
	{
		bool result = false;
		int num = default(int);
		if (P_1.ContainsKey(P_0.Header) && int.TryParse(P_1[P_0.Header], ref num))
		{
			CheckState[] itemStates = P_0.ItemStates;
			if (itemStates != null && (int)itemStates[num + 1] == 1)
			{
				result = true;
			}
		}
		return result;
	}

	private void A(CheckboxFilter P_0, int P_1)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		List<Dictionary<string, string>> Bng = new List<Dictionary<string, string>>();
		foreach (DataGridViewRow item in (BaseCollection)((DataGridView)jo).SelectedRows)
		{
			DataGridViewRow val = item;
			if (((DataGridViewBand)val).Index >= 0 && ((DataGridViewBand)val).Index < jH.Count)
			{
				Bng.Add(jH[((DataGridViewBand)val).Index]);
			}
		}
		Enumerator<Dictionary<string, string>> enumerator2 = Enumerable.ToList<Dictionary<string, string>>(Enumerable.Where<Dictionary<string, string>>((System.Collections.Generic.IEnumerable<Dictionary<string, string>>)jg, (Func<Dictionary<string, string>, bool>)((Dictionary<string, string> P_0) => Bng.Contains(P_0)))).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Dictionary<string, string> current = enumerator2.Current;
				if (current.ContainsKey(P_0.Header) && P_1 < Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)P_0.Options))
				{
					current[P_0.Header] = P_1.ToString();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		jL = true;
		jl = null;
		RefreshAllBindings(fromUndoRedo: false);
		jM.Push(jl);
		jm.Clear();
		RefreshDataTable();
		jL = false;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 131162)
		{
			B();
			return true;
		}
		if ((int)keyData == 131161)
		{
			b();
			return true;
		}
		if ((int)keyData == 131104)
		{
			((DataGridView)jo).ClearSelection();
			return true;
		}
		return ((ContainerControl)this).ProcessCmdKey(ref msg, keyData);
	}

	private void B()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (!Enumerable.Any<Cj>((System.Collections.Generic.IEnumerable<Cj>)jM))
		{
			return;
		}
		Cj cj = jM.Pop();
		Enumerator<CK> enumerator = cj.A().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CK current = enumerator.Current;
				Setting setting = jJ.A(current.BCF);
				current.BCg = Enumerable.ToList<byte>((System.Collections.Generic.IEnumerable<byte>)setting.aY());
				setting.A(current.BCG.ToArray(), true);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		jm.Push(cj);
		RefreshAllBindings(fromUndoRedo: true);
		RefreshDataTable();
	}

	private void b()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!Enumerable.Any<Cj>((System.Collections.Generic.IEnumerable<Cj>)jm))
		{
			return;
		}
		Cj cj = jm.Pop();
		Enumerator<CK> enumerator = cj.A().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CK current = enumerator.Current;
				jJ.A(current.BCF).A(current.BCg.ToArray(), true);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		jM.Push(cj);
		RefreshAllBindings(fromUndoRedo: true);
		RefreshDataTable();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && jn != null)
		{
			((System.IDisposable)jn).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void C()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		jO = new TableLayoutPanel();
		jP = new TableLayoutPanel();
		((Control)jO).SuspendLayout();
		((ISupportInitialize)jo).BeginInit();
		((Control)this).SuspendLayout();
		jO.ColumnCount = 1;
		jO.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		jO.Controls.Add((Control)(object)jo, 0, 1);
		jO.Controls.Add((Control)(object)jP, 0, 0);
		((Control)jO).Dock = (DockStyle)5;
		((Control)jO).Location = new Point(0, 0);
		((Control)jO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gx();
		jO.RowCount = 2;
		jO.RowStyles.Add(new RowStyle((SizeType)2, 20f));
		jO.RowStyles.Add(new RowStyle((SizeType)2, 80f));
		jO.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		((Control)jO).Size = new Size(1170, 752);
		((Control)jO).TabIndex = 0;
		((DataGridView)jo).AllowUserToAddRows = false;
		((DataGridView)jo).AllowUserToDeleteRows = false;
		((DataGridView)jo).AllowUserToResizeRows = false;
		((DataGridView)jo).AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		((DataGridView)jo).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((Control)jo).Dock = (DockStyle)5;
		((Control)jo).Location = new Point(3, 153);
		((Control)jo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GY();
		((DataGridView)jo).RowHeadersVisible = false;
		((DataGridView)jo).ScrollBars = (ScrollBars)2;
		((DataGridView)jo).ShowCellToolTips = false;
		((Control)jo).Size = new Size(1164, 596);
		((Control)jo).TabIndex = 0;
		jP.ColumnCount = 1;
		jP.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		((Control)jP).Dock = (DockStyle)5;
		((Control)jP).Location = new Point(3, 3);
		((Control)jP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gy();
		jP.RowCount = 2;
		jP.RowStyles.Add(new RowStyle((SizeType)1, 30f));
		jP.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		((Control)jP).Size = new Size(1164, 144);
		((Control)jP).TabIndex = 0;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)jO);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GZ();
		((Control)this).Size = new Size(1170, 752);
		((Control)jO).ResumeLayout(false);
		((ISupportInitialize)jo).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[CompilerGenerated]
	private void a(object? s, EventArgs P_1)
	{
		jo.C();
	}
}
