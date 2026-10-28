using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.Utils;
using ns2;
using ns4;
using ns6;
using ns7;

namespace NSP.UserInterface;

public class ThemedDataTable : UserControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class152
	{
		public static readonly Class152 BNX = new Class152();

		public static Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>> BNx;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>> BNY;

		internal Dictionary<string, string> method_0(KeyValuePair<string, Dictionary<string, string>> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		internal Dictionary<string, string> method_1(KeyValuePair<string, Dictionary<string, string>> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}
	}

	[CompilerGenerated]
	private sealed class Class153
	{
		public IFilter BNy;

		public ThemedDataTable BNZ;
	}

	[CompilerGenerated]
	private sealed class Class154
	{
		public ThemedSearchBox BNz;

		public Class153 BnA;

		internal void method_0(object? sender, EventArgs e)
		{
			BnA.BNZ.method_2(BnA.BNy, BNz, e);
		}
	}

	[CompilerGenerated]
	private sealed class Class155
	{
		public CheckboxFilter Bna;

		public Class149 BnB;

		public Class153 Bnb;

		internal void method_0(object? sender, ItemCheckEventArgs e)
		{
			Bnb.BNZ.method_2(Bnb.BNy, BnB, e);
		}
	}

	[CompilerGenerated]
	private sealed class Class156
	{
		public int BnC;

		public Class155 Bnc;

		internal void method_0(object? sender, EventArgs e)
		{
			Bnc.Bnb.BNZ.method_7(Bnc.Bna, BnC);
		}
	}

	[CompilerGenerated]
	private sealed class Class157
	{
		public ThemedDataTable BnD;

		public int Bnd;

		internal bool method_0(Dictionary<string, string> dictionary_0)
		{
			return dictionary_0[BnD.dataTableObject_0.IdColName] == BnD.list_1[Bnd][BnD.dataTableObject_0.IdColName];
		}
	}

	[CompilerGenerated]
	private sealed class Class158
	{
		public Setting BnE;

		internal bool method_0(Class279 class279_0)
		{
			return class279_0.BCF.DataId == BnE.method_69().DataId;
		}
	}

	[CompilerGenerated]
	private sealed class Class159
	{
		public SearchFilter Bne;

		public ThemedDataTable BnF;

		internal bool method_0(Dictionary<string, string> dictionary_0)
		{
			return BnF.method_4(Bne.Headers, dictionary_0).Contains(BnF.method_5(Bne.Value));
		}
	}

	[CompilerGenerated]
	private sealed class Class160
	{
		public CheckboxFilter Bnf;

		public ThemedDataTable BnG;

		internal bool method_0(Dictionary<string, string> dictionary_0)
		{
			return BnG.method_6(Bnf, dictionary_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class161
	{
		public List<Dictionary<string, string>> Bng;

		internal bool method_0(Dictionary<string, string> dictionary_0)
		{
			return Bng.Contains(dictionary_0);
		}
	}

	[CompilerGenerated]
	private EventHandler<string> eventHandler_0;

	private List<Dictionary<string, string>> list_0;

	private List<Dictionary<string, string>> list_1;

	private Dictionary<string, Tuple<string, BindingData>> dictionary_0 = new Dictionary<string, Tuple<string, BindingData>>();

	private bool bool_0 = true;

	private DataTableObject dataTableObject_0;

	private Framework framework_0;

	private Font font_0 = new Font(Control.DefaultFont.FontFamily, 9f, FontStyle.Regular);

	private Font font_1 = new Font(Control.DefaultFont.FontFamily, 9f, FontStyle.Underline);

	private bool bool_1 = true;

	private bool bool_2;

	private Class278 class278_0;

	private Stack<Class278> stack_0 = new Stack<Class278>();

	private Stack<Class278> stack_1 = new Stack<Class278>();

	private bool bool_3;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_0;

	private TableLayoutPanel tableLayoutPanel_1;

	public event EventHandler<string> ItemsSelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler<string> eventHandler = eventHandler_0;
			EventHandler<string> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<string> value2 = (EventHandler<string>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<string> eventHandler = eventHandler_0;
			EventHandler<string> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<string> value2 = (EventHandler<string>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ThemedDataTable(DataTableObject tableInfo, Framework framework)
	{
		if (tableInfo != null && tableInfo.Columns != null && tableInfo.Data != null)
		{
			dataTableObject_0 = tableInfo;
			framework_0 = framework;
			dataGridViewWithThemedScrollBars_0 = new DataGridViewWithThemedScrollBars();
			Resize += (object? sender, EventArgs e) =>
			{
				dataGridViewWithThemedScrollBars_0.method_4();
			};
			method_10();
			dataGridViewWithThemedScrollBars_0.RowHeadersVisible = false;
			dataGridViewWithThemedScrollBars_0.AllowUserToResizeColumns = true;
			dataGridViewWithThemedScrollBars_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewWithThemedScrollBars_0.MultiSelect = true;
			dataGridViewWithThemedScrollBars_0.EditMode = DataGridViewEditMode.EditOnEnter;
			dataGridViewWithThemedScrollBars_0.AllowUserToResizeRows = true;
			dataGridViewWithThemedScrollBars_0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			dataGridViewWithThemedScrollBars_0.ShowCellToolTips = true;
			tableLayoutPanel_0.Padding = new Padding(10, 0, 10, 0);
			SetTheme();
			CreateFilters();
			BuildData();
			BuildColumns();
			method_0();
			RefreshAllBindings(fromUndoRedo: false);
			RefreshDataTable();
			bool_1 = false;
		}
	}

	public new void Dispose()
	{
		method_1();
		framework_0 = null;
	}

	public void SetTheme()
	{
		BackColor = Form23.color_16;
		ForeColor = Form23.color_12;
		dataGridViewWithThemedScrollBars_0.BackgroundColor = Form23.color_16;
		dataGridViewWithThemedScrollBars_0.ForeColor = Form23.color_12;
		dataGridViewWithThemedScrollBars_0.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
		{
			BackColor = Form23.color_16,
			ForeColor = Form23.color_12
		};
		dataGridViewWithThemedScrollBars_0.DefaultCellStyle = new DataGridViewCellStyle
		{
			BackColor = Form23.color_32,
			ForeColor = Form23.color_12,
			Font = font_0
		};
		dataGridViewWithThemedScrollBars_0.BorderStyle = BorderStyle.None;
	}

	public void CreateFilters()
	{
		tableLayoutPanel_1.ColumnCount = dataTableObject_0.Filters.Count;
		for (int i = 0; i < tableLayoutPanel_1.ColumnCount; i++)
		{
			tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
		}
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_16;
		contextMenuStrip.ForeColor = Form23.color_12;
		int num = 0;
		foreach (IFilter BNy in dataTableObject_0.Filters)
		{
			if (BNy == null)
			{
				break;
			}
			Label label = new Label();
			label.Text = BNy.Text;
			label.Font = new Font(Control.DefaultFont.FontFamily, 10f, FontStyle.Bold);
			label.ForeColor = Form23.color_12;
			label.Dock = DockStyle.Fill;
			label.TextAlign = ContentAlignment.MiddleCenter;
			tableLayoutPanel_1.Controls.Add(label);
			tableLayoutPanel_1.SetRow(label, 0);
			tableLayoutPanel_1.SetColumn(label, num);
			if (BNy is SearchFilter)
			{
				ThemedSearchBox BNz = new ThemedSearchBox();
				BNz.ForeColor = Form23.color_12;
				BNz.BackColor = Form23.color_32;
				BNz.Dock = DockStyle.Fill;
				BNz.TextChanged += (object? sender, EventArgs e) =>
				{
					method_2(BNy, BNz, e);
				};
				tableLayoutPanel_1.Controls.Add(BNz);
				tableLayoutPanel_1.SetRow(BNz, 1);
				tableLayoutPanel_1.SetColumn(BNz, num);
			}
			else if (BNy is CheckboxFilter)
			{
				Class149 BnB = new Class149();
				BnB.ForeColor = Form23.color_12;
				BnB.BackColor = Form23.color_32;
				BnB.CheckOnClick = true;
				BnB.method_1(bool_2: true);
				CheckboxFilter Bna = BNy as CheckboxFilter;
				ToolStripLabel value = new ToolStripLabel(Bna.Text ?? Class333.smethod_102());
				if (Bna.BulkEdit)
				{
					contextMenuStrip.Items.Add(value);
				}
				if (Bna.Options.Length != 0)
				{
					BnB.Items.Add(Class333.smethod_668());
				}
				CheckedListBox.ObjectCollection items = BnB.Items;
				object[] options = Bna.Options;
				items.AddRange(options);
				for (int num2 = 0; num2 < BnB.Items.Count; num2++)
				{
					if (Bna.ItemStates == null)
					{
						Bna.ItemStates = new CheckState[BnB.Items.Count];
					}
					Bna.ItemStates[num2] = CheckState.Checked;
					BnB.SetItemCheckState(num2, CheckState.Checked);
					if (num2 != 0)
					{
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_669() + Bna.Options[num2 - 1]);
						int BnC = num2 - 1;
						toolStripMenuItem.Click += (object? sender, EventArgs e) =>
						{
							method_7(Bna, BnC);
						};
						if (Bna.BulkEdit)
						{
							contextMenuStrip.Items.Add(toolStripMenuItem);
						}
					}
				}
				if (Bna.BulkEdit)
				{
					contextMenuStrip.Items.Add(new ToolStripSeparator());
				}
				BnB.ItemCheck += (object? sender, ItemCheckEventArgs e) =>
				{
					method_2(BNy, BnB, e);
				};
				tableLayoutPanel_1.Controls.Add(BnB);
				tableLayoutPanel_1.SetRow(BnB, 1);
				tableLayoutPanel_1.SetColumn(BnB, num);
				BnB.method_2();
			}
			num++;
		}
		dataGridViewWithThemedScrollBars_0.ContextMenuStrip = contextMenuStrip;
	}

	public void BuildColumns()
	{
		foreach (DataTableColumn column in dataTableObject_0.Columns)
		{
			switch (column.Type)
			{
			case DataTableColumnType.Enum:
			{
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn
				{
					HeaderText = column.HeaderText,
					Name = column.HeaderText,
					FlatStyle = FlatStyle.Flat,
					ToolTipText = ((column.Tooltip != null) ? column.Tooltip.Replace(Class333.smethod_670(), Environment.NewLine) : null)
				};
				dictionary_0.Add(column.HeaderText, new Tuple<string, BindingData>(column.BindingData.BindingDataId, column.BindingData));
				dataGridViewComboBoxColumn.Visible = column.Visible;
				dataGridViewComboBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
				dataGridViewWithThemedScrollBars_0.Columns.Add(dataGridViewComboBoxColumn);
				break;
			}
			case DataTableColumnType.Text:
			{
				DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
				{
					HeaderText = column.HeaderText,
					Name = column.HeaderText,
					ToolTipText = ((column.Tooltip != null) ? column.Tooltip.Replace(Class333.smethod_670(), Environment.NewLine) : null)
				};
				dataGridViewTextBoxColumn.Visible = column.Visible;
				if (column.EnumValues != null)
				{
					dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
					dataGridViewTextBoxColumn.Width = CalcBestColumnWidth(column.HeaderText, column.EnumValues);
				}
				else
				{
					dataGridViewTextBoxColumn.AutoSizeMode = column.AutoSize;
				}
				dataGridViewWithThemedScrollBars_0.Columns.Add(dataGridViewTextBoxColumn);
				if (column.BindingData != null)
				{
					dictionary_0.Add(column.HeaderText, new Tuple<string, BindingData>(column.BindingData.BindingDataId, column.BindingData));
				}
				break;
			}
			}
		}
	}

	private void method_0()
	{
		dataGridViewWithThemedScrollBars_0.CurrentCellDirtyStateChanged += dataGridViewWithThemedScrollBars_0_CurrentCellDirtyStateChanged;
		dataGridViewWithThemedScrollBars_0.CellValueChanged += dataGridViewWithThemedScrollBars_0_CellValueChanged;
		dataGridViewWithThemedScrollBars_0.CellContentDoubleClick += dataGridViewWithThemedScrollBars_0_CellContentDoubleClick;
		dataGridViewWithThemedScrollBars_0.CellEnter += dataGridViewWithThemedScrollBars_0_CellEnter;
		dataGridViewWithThemedScrollBars_0.CellMouseEnter += dataGridViewWithThemedScrollBars_0_CellMouseEnter;
	}

	private void method_1()
	{
		dataGridViewWithThemedScrollBars_0.CurrentCellDirtyStateChanged -= dataGridViewWithThemedScrollBars_0_CurrentCellDirtyStateChanged;
		dataGridViewWithThemedScrollBars_0.CellValueChanged -= dataGridViewWithThemedScrollBars_0_CellValueChanged;
		dataGridViewWithThemedScrollBars_0.CellContentDoubleClick -= dataGridViewWithThemedScrollBars_0_CellContentDoubleClick;
		dataGridViewWithThemedScrollBars_0.CellEnter -= dataGridViewWithThemedScrollBars_0_CellEnter;
		dataGridViewWithThemedScrollBars_0.CellMouseEnter -= dataGridViewWithThemedScrollBars_0_CellMouseEnter;
	}

	private void dataGridViewWithThemedScrollBars_0_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.RowIndex < list_1.Count)
		{
			if (list_1[e.RowIndex].ContainsKey(dataTableObject_0.SelectedItemDataName))
			{
				dataGridViewWithThemedScrollBars_0.Cursor = Cursors.Hand;
			}
			else
			{
				dataGridViewWithThemedScrollBars_0.Cursor = Cursors.Default;
			}
		}
	}

	private void dataGridViewWithThemedScrollBars_0_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		bool flag = e.RowIndex != -1 && e.ColumnIndex != -1;
		if ((dataGridViewWithThemedScrollBars_0.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn) & flag)
		{
			dataGridViewWithThemedScrollBars_0.BeginEdit(selectAll: true);
			((ComboBox)dataGridViewWithThemedScrollBars_0.EditingControl).DroppedDown = true;
		}
	}

	private void dataGridViewWithThemedScrollBars_0_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (bool_1)
		{
			return;
		}
		bool flag = false;
		if (dataTableObject_0.Columns.Count > e.ColumnIndex && dataTableObject_0.Columns[e.ColumnIndex].MenuLink != null)
		{
			flag = true;
		}
		if (flag && list_1[e.RowIndex].ContainsKey(dataTableObject_0.SelectedItemDataName))
		{
			string e2 = list_1[e.RowIndex][dataTableObject_0.SelectedItemDataName];
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, e2);
			}
		}
	}

	private void dataGridViewWithThemedScrollBars_0_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (!bool_1)
		{
			string headerText = dataGridViewWithThemedScrollBars_0.Columns[e.ColumnIndex].HeaderText;
			DataGridViewCell dataGridViewCell = dataGridViewWithThemedScrollBars_0.Rows[e.RowIndex].Cells[e.ColumnIndex];
			object new_value = dataGridViewCell.Value;
			if (dataGridViewCell is DataGridViewComboBoxCell)
			{
				DataGridViewComboBoxCell dataGridViewComboBoxCell = dataGridViewCell as DataGridViewComboBoxCell;
				new_value = dataGridViewComboBoxCell.Items.Cast<object>().ToList().IndexOf(dataGridViewComboBoxCell.Value);
			}
			RefreshSingleBindingByIndex(e.RowIndex, headerText, new_value, fromUndoRedo: false);
		}
	}

	private void dataGridViewWithThemedScrollBars_0_CurrentCellDirtyStateChanged(object sender, EventArgs e)
	{
		if (!bool_1 && dataGridViewWithThemedScrollBars_0.IsCurrentCellDirty)
		{
			dataGridViewWithThemedScrollBars_0.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}
	}

	public void BuildData()
	{
		if (dataTableObject_0.GroupDataName != null)
		{
			Dictionary<string, GClass0<string, int>> dictionary = new Dictionary<string, GClass0<string, int>>();
			List<Dictionary<string, string>> list = dataTableObject_0.Data.Select((KeyValuePair<string, Dictionary<string, string>> keyValuePair_0) => keyValuePair_0.Value).ToList();
			for (int num = 0; num < list.Count; num++)
			{
				if (list[num].ContainsKey(dataTableObject_0.GroupDataName))
				{
					if (dictionary.ContainsKey(list[num][dataTableObject_0.GroupDataName]))
					{
						GClass0<string, int> gClass = dictionary[list[num][dataTableObject_0.GroupDataName]];
						string text = list[num][dataTableObject_0.IdColName];
						gClass.First = gClass.First + Class333.smethod_189() + text;
						list[gClass.Second][dataTableObject_0.IdColName] = gClass.First;
						list.RemoveAt(num);
						num--;
					}
					else
					{
						dictionary.Add(list[num][dataTableObject_0.GroupDataName], new GClass0<string, int>
						{
							First = list[num][dataTableObject_0.IdColName],
							Second = num
						});
						list[num][dataTableObject_0.GroupDescDataName] = list[num][dataTableObject_0.GroupDataName];
					}
				}
			}
			list_0 = list;
			list_1 = new List<Dictionary<string, string>>(list_0);
		}
		else
		{
			list_0 = dataTableObject_0.Data.Select((KeyValuePair<string, Dictionary<string, string>> keyValuePair_0) => keyValuePair_0.Value).ToList();
			list_1 = new List<Dictionary<string, string>>(list_0);
		}
	}

	public void SetPreferredWidth(int width)
	{
		dataGridViewWithThemedScrollBars_0.Width = width;
		Width = width;
	}

	public int CalcBestColumnWidth(string headerText, string[] options)
	{
		Size size = TextRenderer.MeasureText(headerText, font_0);
		int num = 0;
		for (int i = 0; i < options.Length; i++)
		{
			Size size2 = TextRenderer.MeasureText(options[i], font_0);
			if (size2.Width > num)
			{
				num = size2.Width;
			}
		}
		return (int)((float)((num > size.Width) ? num : size.Width) + 10f);
	}

	public void RefreshAllBindings(bool fromUndoRedo)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			RefreshSingleBinding(list_0[i], fromUndoRedo);
		}
	}

	public void RefreshSingleBindingByIndex(int index, string headerText, object new_value, bool fromUndoRedo)
	{
		if (!bool_0 && index >= 0 && index < list_1.Count)
		{
			Dictionary<string, string> dictionary = list_0.Where((Dictionary<string, string> dictionary_0) => dictionary_0[dataTableObject_0.IdColName] == list_1[index][dataTableObject_0.IdColName]).FirstOrDefault();
			if (dictionary.ContainsKey(headerText))
			{
				dictionary[headerText] = new_value.ToString();
			}
			RefreshSingleBinding(dictionary, fromUndoRedo);
		}
	}

	public void RefreshSingleBinding(Dictionary<string, string> row, bool fromUndoRedo)
	{
		if (dictionary_0.Count == 0)
		{
			return;
		}
		foreach (KeyValuePair<string, Tuple<string, BindingData>> item in dictionary_0)
		{
			int result = -1;
			if (item.Value.Item2.IsMapped && row.ContainsKey(dataTableObject_0.SettingMapColName) && int.TryParse(row[dataTableObject_0.SettingMapColName], out var result2))
			{
				result = result2;
			}
			else if (row.ContainsKey(dataTableObject_0.IndexColName) && !int.TryParse(row[dataTableObject_0.IndexColName], out result))
			{
				break;
			}
			if (!int.TryParse(item.Value.Item1, out var result3))
			{
				continue;
			}
			Setting BnE = framework_0.method_31(result3);
			byte[] array = BnE.method_259();
			int num = array[result];
			byte result4;
			if (!row.ContainsKey(item.Key))
			{
				row.Add(item.Key, num.ToString());
			}
			else if (item.Value.Item2.BindingType == DataTableBindType.TwoWay && byte.TryParse(row[item.Key], out result4) && !fromUndoRedo)
			{
				if (result4 == num)
				{
					continue;
				}
				if (!bool_2)
				{
					Class278 @class = new Class278();
					@class.method_1(BnE);
					@class.method_2(BnE, 0, array.Length);
					stack_0.Push(@class);
					stack_1.Clear();
				}
				else
				{
					if (class278_0 == null)
					{
						class278_0 = new Class278();
					}
					if (!(from class279_0 in class278_0.method_4()
						where class279_0.BCF.DataId == BnE.method_69().DataId
						select class279_0).Any())
					{
						class278_0.method_1(BnE);
					}
					class278_0.method_2(BnE, 0, array.Length);
				}
				BnE.method_270(result, result4, bool_0: true);
			}
			else if ((item.Value.Item2.BindingType == DataTableBindType.OneWay) | fromUndoRedo)
			{
				row[item.Key] = num.ToString();
			}
		}
	}

	public void RefreshDataTable()
	{
		bool_0 = true;
		dataGridViewWithThemedScrollBars_0.Rows.Clear();
		foreach (Dictionary<string, string> item2 in list_1)
		{
			int index = dataGridViewWithThemedScrollBars_0.Rows.Add();
			foreach (DataTableColumn column in dataTableObject_0.Columns)
			{
				if (!item2.ContainsKey(column.HeaderText))
				{
					continue;
				}
				if (column.Type == DataTableColumnType.Enum)
				{
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)dataGridViewWithThemedScrollBars_0.Rows[index].Cells[column.HeaderText];
					dataGridViewComboBoxCell.Items.Clear();
					string[] enumValues = column.EnumValues;
					foreach (string item in enumValues)
					{
						dataGridViewComboBoxCell.Items.Add(item);
					}
					if (!int.TryParse(item2[column.HeaderText].ToString(), out var result))
					{
						throw new Exception(Class333.smethod_671() + column.HeaderText + Class333.smethod_571() + item2[column.HeaderText]);
					}
					dataGridViewComboBoxCell.Value = column.EnumValues[result];
				}
				else
				{
					if (column.MenuLink != null && item2.ContainsKey(column.MenuLink))
					{
						dataGridViewWithThemedScrollBars_0.Rows[index].Cells[column.HeaderText].Style.Font = font_1;
					}
					string text = item2[column.HeaderText];
					if (column.EnumValues != null && int.TryParse(text, out var result2))
					{
						text = column.EnumValues[result2];
					}
					dataGridViewWithThemedScrollBars_0.Rows[index].Cells[column.HeaderText].Value = text;
					dataGridViewWithThemedScrollBars_0.Rows[index].Cells[column.HeaderText].ReadOnly = true;
				}
			}
		}
		dataGridViewWithThemedScrollBars_0.method_4();
		bool_0 = false;
	}

	private void method_2(IFilter ifilter_0, Control control_0, EventArgs eventArgs_0)
	{
		if (bool_3)
		{
			return;
		}
		bool_3 = true;
		if (ifilter_0 is SearchFilter)
		{
			SearchFilter searchFilter = (SearchFilter)ifilter_0;
			ThemedSearchBox themedSearchBox = control_0 as ThemedSearchBox;
			searchFilter.Value = themedSearchBox.Text;
		}
		else if (ifilter_0 is CheckboxFilter)
		{
			CheckboxFilter checkboxFilter = (CheckboxFilter)ifilter_0;
			CheckedListBox checkedListBox = control_0 as CheckedListBox;
			ItemCheckEventArgs e = eventArgs_0 as ItemCheckEventArgs;
			checkboxFilter.ItemStates[e.Index] = e.NewValue;
			if (e.Index == 0)
			{
				if (e.NewValue == CheckState.Checked)
				{
					for (int i = 0; i < checkedListBox.Items.Count; i++)
					{
						checkboxFilter.ItemStates[i] = CheckState.Checked;
						checkedListBox.SetItemCheckState(i, CheckState.Checked);
					}
				}
				else if (e.NewValue == CheckState.Unchecked)
				{
					for (int j = 0; j < checkedListBox.Items.Count; j++)
					{
						checkboxFilter.ItemStates[j] = CheckState.Unchecked;
						checkedListBox.SetItemCheckState(j, CheckState.Unchecked);
					}
				}
			}
		}
		method_3(dataTableObject_0.Filters);
		bool_3 = false;
	}

	private void method_3(List<IFilter> list_2)
	{
		bool_1 = true;
		list_1 = new List<Dictionary<string, string>>(list_0);
		foreach (IFilter item in list_2)
		{
			if (item is SearchFilter)
			{
				SearchFilter Bne = (SearchFilter)item;
				if (Bne.Value != string.Empty && Bne.Value != null)
				{
					list_1 = list_1.Where((Dictionary<string, string> dictionary_0) => method_4(Bne.Headers, dictionary_0).Contains(method_5(Bne.Value))).ToList();
				}
			}
			else if (item is CheckboxFilter)
			{
				CheckboxFilter Bnf = (CheckboxFilter)item;
				list_1 = list_1.Where((Dictionary<string, string> dictionary_0) => method_6(Bnf, dictionary_0)).ToList();
			}
		}
		RefreshDataTable();
		bool_1 = false;
	}

	private string method_4(string[] string_0, Dictionary<string, string> dictionary_1)
	{
		string text = string.Empty;
		foreach (KeyValuePair<string, string> item in dictionary_1)
		{
			if (Enumerable.Contains(string_0, item.Key))
			{
				text += item.Value.ToString();
			}
		}
		return method_5(text);
	}

	private string method_5(string string_0)
	{
		if (string_0 != null)
		{
			return string_0.ToLowerInvariant().Replace(Class333.smethod_325(), Class333.smethod_102());
		}
		return string.Empty;
	}

	private bool method_6(CheckboxFilter checkboxFilter_0, Dictionary<string, string> dictionary_1)
	{
		bool result = false;
		if (dictionary_1.ContainsKey(checkboxFilter_0.Header) && int.TryParse(dictionary_1[checkboxFilter_0.Header], out var result2))
		{
			CheckState[] itemStates = checkboxFilter_0.ItemStates;
			if (itemStates != null && itemStates[result2 + 1] == CheckState.Checked)
			{
				result = true;
			}
		}
		return result;
	}

	private void method_7(CheckboxFilter checkboxFilter_0, int int_0)
	{
		List<Dictionary<string, string>> Bng = new List<Dictionary<string, string>>();
		foreach (DataGridViewRow selectedRow in dataGridViewWithThemedScrollBars_0.SelectedRows)
		{
			if (selectedRow.Index >= 0 && selectedRow.Index < list_1.Count)
			{
				Bng.Add(list_1[selectedRow.Index]);
			}
		}
		foreach (Dictionary<string, string> item in list_0.Where((Dictionary<string, string> dictionary_0) => Bng.Contains(dictionary_0)).ToList())
		{
			if (item.ContainsKey(checkboxFilter_0.Header) && int_0 < checkboxFilter_0.Options.Count())
			{
				item[checkboxFilter_0.Header] = int_0.ToString();
			}
		}
		bool_2 = true;
		class278_0 = null;
		RefreshAllBindings(fromUndoRedo: false);
		stack_0.Push(class278_0);
		stack_1.Clear();
		RefreshDataTable();
		bool_2 = false;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		switch (keyData)
		{
		case Keys.Z | Keys.Control:
			method_8();
			return true;
		case Keys.Y | Keys.Control:
			method_9();
			return true;
		case Keys.Space | Keys.Control:
			dataGridViewWithThemedScrollBars_0.ClearSelection();
			return true;
		default:
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}

	private void method_8()
	{
		if (!stack_0.Any())
		{
			return;
		}
		Class278 @class = stack_0.Pop();
		foreach (Class279 item in @class.method_4())
		{
			Setting setting = framework_0.method_32(item.BCF);
			item.BCg = setting.method_259().ToList();
			setting.method_275(item.BCG.ToArray(), bool_0: true);
		}
		stack_1.Push(@class);
		RefreshAllBindings(fromUndoRedo: true);
		RefreshDataTable();
	}

	private void method_9()
	{
		if (!stack_1.Any())
		{
			return;
		}
		Class278 @class = stack_1.Pop();
		foreach (Class279 item in @class.method_4())
		{
			framework_0.method_32(item.BCF).method_275(item.BCg.ToArray(), bool_0: true);
		}
		stack_0.Push(@class);
		RefreshAllBindings(fromUndoRedo: true);
		RefreshDataTable();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_10()
	{
		tableLayoutPanel_0 = new TableLayoutPanel();
		tableLayoutPanel_1 = new TableLayoutPanel();
		tableLayoutPanel_0.SuspendLayout();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_0).BeginInit();
		SuspendLayout();
		tableLayoutPanel_0.ColumnCount = 1;
		tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanel_0.Controls.Add(dataGridViewWithThemedScrollBars_0, 0, 1);
		tableLayoutPanel_0.Controls.Add(tableLayoutPanel_1, 0, 0);
		tableLayoutPanel_0.Dock = DockStyle.Fill;
		tableLayoutPanel_0.Location = new Point(0, 0);
		tableLayoutPanel_0.Name = Class333.smethod_672();
		tableLayoutPanel_0.RowCount = 2;
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 80f));
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		tableLayoutPanel_0.Size = new Size(1170, 752);
		tableLayoutPanel_0.TabIndex = 0;
		dataGridViewWithThemedScrollBars_0.AllowUserToAddRows = false;
		dataGridViewWithThemedScrollBars_0.AllowUserToDeleteRows = false;
		dataGridViewWithThemedScrollBars_0.AllowUserToResizeRows = false;
		dataGridViewWithThemedScrollBars_0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewWithThemedScrollBars_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewWithThemedScrollBars_0.Dock = DockStyle.Fill;
		dataGridViewWithThemedScrollBars_0.Location = new Point(3, 153);
		dataGridViewWithThemedScrollBars_0.Name = Class333.smethod_673();
		dataGridViewWithThemedScrollBars_0.RowHeadersVisible = false;
		dataGridViewWithThemedScrollBars_0.ScrollBars = ScrollBars.Vertical;
		dataGridViewWithThemedScrollBars_0.ShowCellToolTips = false;
		dataGridViewWithThemedScrollBars_0.Size = new Size(1164, 596);
		dataGridViewWithThemedScrollBars_0.TabIndex = 0;
		tableLayoutPanel_1.ColumnCount = 1;
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanel_1.Dock = DockStyle.Fill;
		tableLayoutPanel_1.Location = new Point(3, 3);
		tableLayoutPanel_1.Name = Class333.smethod_674();
		tableLayoutPanel_1.RowCount = 2;
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30f));
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanel_1.Size = new Size(1164, 144);
		tableLayoutPanel_1.TabIndex = 0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(tableLayoutPanel_0);
		Name = Class333.smethod_675();
		Size = new Size(1170, 752);
		tableLayoutPanel_0.ResumeLayout(performLayout: false);
		((ISupportInitialize)dataGridViewWithThemedScrollBars_0).EndInit();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void ThemedDataTable_Resize(object? sender, EventArgs e)
	{
		dataGridViewWithThemedScrollBars_0.method_4();
	}
}
