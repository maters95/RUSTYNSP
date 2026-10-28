using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface.Forms;
using ns4;
using ns5;
using ns7;

namespace NSP.UserInterface;

public class CANSignalEditor : UserControl
{
	internal const int int_0 = 120;

	private const int int_1 = 0;

	private const int int_2 = 1;

	private const int int_3 = 2;

	private const int int_4 = 3;

	private const int int_5 = 4;

	private const int int_6 = 5;

	private const int int_7 = 6;

	private const int int_8 = 7;

	private const int int_9 = 8;

	private const int int_10 = 9;

	private const int int_11 = 10;

	private const int int_12 = 11;

	private const int int_13 = 12;

	private static int[] int_14 = new int[13];

	private BindingList<CANSignalModel> bindingList_0 = new BindingList<CANSignalModel>();

	private bool bool_0;

	private int int_15 = -1;

	private bool bool_1;

	[CompilerGenerated]
	private EventHandler<List<CANSignalModel>> eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	private IContainer icontainer_0;

	private DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_0;

	private BindingSource bindingSource_0;

	private ThemedButton themedButton_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

	private DataGridViewButtonColumn dataGridViewButtonColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewButtonColumn dataGridViewButtonColumn_1;

	private DataGridViewButtonColumn dataGridViewButtonColumn_2;

	public event EventHandler<List<CANSignalModel>> SignalsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<List<CANSignalModel>> eventHandler = eventHandler_0;
			EventHandler<List<CANSignalModel>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<List<CANSignalModel>> value2 = (EventHandler<List<CANSignalModel>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<List<CANSignalModel>> eventHandler = eventHandler_0;
			EventHandler<List<CANSignalModel>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<List<CANSignalModel>> value2 = (EventHandler<List<CANSignalModel>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler SignalSelectionChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public CANSignalEditor()
	{
		method_9();
		dataGridViewComboBoxColumn_1.DataPropertyName = Class333.smethod_278();
		dataGridViewComboBoxColumn_1.ValueType = typeof(int);
		dataGridViewComboBoxColumn_1.DisplayMember = Class333.smethod_279();
		dataGridViewComboBoxColumn_1.ValueMember = Class333.smethod_280();
		dataGridViewComboBoxColumn_1.HeaderText = Class333.smethod_278();
		dataGridViewComboBoxColumn_0.DataPropertyName = Class333.smethod_281();
		dataGridViewComboBoxColumn_0.ValueType = typeof(int);
		dataGridViewComboBoxColumn_0.DisplayMember = Class333.smethod_279();
		dataGridViewComboBoxColumn_0.ValueMember = Class333.smethod_280();
		dataGridViewComboBoxColumn_0.HeaderText = Class333.smethod_281();
		dataGridViewComboBoxColumn_2.DataPropertyName = Class333.smethod_282();
		dataGridViewComboBoxColumn_2.ValueType = typeof(int);
		dataGridViewComboBoxColumn_2.DisplayMember = Class333.smethod_279();
		dataGridViewComboBoxColumn_2.ValueMember = Class333.smethod_280();
		dataGridViewComboBoxColumn_2.HeaderText = Class333.smethod_282();
		method_6();
		bindingList_0.AllowEdit = true;
		bindingList_0.AllowNew = true;
		bindingList_0.AllowRemove = true;
		DataContext = this;
		dataGridViewWithThemedScrollBars_0.DataSource = bindingList_0;
		foreach (DataGridViewColumn column in dataGridViewWithThemedScrollBars_0.Columns)
		{
			if (column.Index < int_14.Length && int_14[column.Index] != 0)
			{
				column.Width = int_14[column.Index];
			}
		}
		dataGridViewWithThemedScrollBars_0.CellEndEdit += dataGridViewWithThemedScrollBars_0_CellEndEdit;
		dataGridViewWithThemedScrollBars_0.RowsRemoved += dataGridViewWithThemedScrollBars_0_RowsRemoved;
		dataGridViewWithThemedScrollBars_0.CellClick += dataGridViewWithThemedScrollBars_0_CellClick;
		dataGridViewWithThemedScrollBars_0.DataError += dataGridViewWithThemedScrollBars_0_DataError;
		dataGridViewWithThemedScrollBars_0.CurrentCellDirtyStateChanged += dataGridViewWithThemedScrollBars_0_CurrentCellDirtyStateChanged;
		dataGridViewWithThemedScrollBars_0.CellEnter += dataGridViewWithThemedScrollBars_0_CellEnter;
		dataGridViewWithThemedScrollBars_0.CellToolTipTextNeeded += dataGridViewWithThemedScrollBars_0_CellToolTipTextNeeded;
		dataGridViewWithThemedScrollBars_0.CellPainting += dataGridViewWithThemedScrollBars_0_CellPainting;
		dataGridViewWithThemedScrollBars_0.EditingControlShowing += dataGridViewWithThemedScrollBars_0_EditingControlShowing;
		dataGridViewWithThemedScrollBars_0.LostFocus += dataGridViewWithThemedScrollBars_0_LostFocus;
		dataGridViewWithThemedScrollBars_0.ColumnWidthChanged += dataGridViewWithThemedScrollBars_0_ColumnWidthChanged;
		dataGridViewWithThemedScrollBars_0.CellMouseEnter += (object? sender, DataGridViewCellEventArgs e) =>
		{
			dataGridViewWithThemedScrollBars_0.ShowCellToolTips = true;
		};
		dataGridViewWithThemedScrollBars_0.CellMouseLeave += (object? sender, DataGridViewCellEventArgs e) =>
		{
			dataGridViewWithThemedScrollBars_0.ShowCellToolTips = false;
		};
		dataGridViewWithThemedScrollBars_0.method_4();
		themedButton_0.Click += themedButton_0_Click;
		Resize += CANSignalEditor_Layout;
		Layout += CANSignalEditor_Layout;
	}

	private void CANSignalEditor_Layout(object sender, EventArgs e)
	{
		dataGridViewWithThemedScrollBars_0.Width = Width - 5;
		dataGridViewWithThemedScrollBars_0.Height = Height - dataGridViewWithThemedScrollBars_0.Top - 10;
		dataGridViewWithThemedScrollBars_0.method_4();
	}

	internal int method_0()
	{
		int num = dataGridViewWithThemedScrollBars_0.Left;
		for (int i = 0; i < dataGridViewWithThemedScrollBars_0.Columns.Count; i++)
		{
			if (dataGridViewWithThemedScrollBars_0.Columns[i].Visible)
			{
				num += dataGridViewWithThemedScrollBars_0.Columns[i].Width;
			}
		}
		return num + 6 + 18;
	}

	internal int method_1()
	{
		int num = dataGridViewWithThemedScrollBars_0.Top + dataGridViewWithThemedScrollBars_0.ColumnHeadersHeight;
		for (int i = 0; i < dataGridViewWithThemedScrollBars_0.Rows.Count; i++)
		{
			num += dataGridViewWithThemedScrollBars_0.Rows[i].Height;
		}
		return Math.Max(num + 2 + 18, 120);
	}

	private void dataGridViewWithThemedScrollBars_0_ColumnWidthChanged(object sender, EventArgs e)
	{
		foreach (DataGridViewColumn column in dataGridViewWithThemedScrollBars_0.Columns)
		{
			if (column.Index < int_14.Length)
			{
				int_14[column.Index] = column.Width;
			}
		}
		dataGridViewWithThemedScrollBars_0.method_4();
	}

	public void ApplySignComboBoxDataSource(List<ValueAndDisplay> signDataSource)
	{
		dataGridViewComboBoxColumn_1.DataSource = signDataSource;
	}

	public void ApplyFormatComboBoxDataSource(List<ValueAndDisplay> formatDataSource)
	{
		dataGridViewComboBoxColumn_0.DataSource = formatDataSource;
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		if (bindingList_0 == null)
		{
			return;
		}
		CANSignalModel item = new CANSignalModel
		{
			Int32_0 = -1,
			Index = -1
		};
		bindingList_0.Add(item);
		if (eventHandler_0 != null)
		{
			List<CANSignalModel> list = bindingList_0.ToList();
			Invoke(eventHandler_0, this, list);
			if (list.Contains(item))
			{
				method_5(list.IndexOf(item));
			}
			else
			{
				bindingList_0.Remove(item);
			}
		}
		dataGridViewWithThemedScrollBars_0.method_4();
		method_3();
	}

	private void dataGridViewWithThemedScrollBars_0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		if (dataGridViewWithThemedScrollBars_0.CurrentCell != null && dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex == 7)
		{
			e.CellStyle.BackColor = Form23.color_32;
			e.CellStyle.ForeColor = Form23.color_12;
		}
	}

	private void dataGridViewWithThemedScrollBars_0_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		if (e.RowIndex < 0 || bindingList_0 == null || e.RowIndex >= bindingList_0.Count || e.RowIndex >= dataGridViewWithThemedScrollBars_0.Rows.Count)
		{
			return;
		}
		if (e.ColumnIndex == 5)
		{
			e.PaintBackground(e.CellBounds, cellsPaintSelectionBackground: true);
			DataGridViewCell dataGridViewCell = dataGridViewWithThemedScrollBars_0.Rows[e.RowIndex].Cells[5];
			if (dataGridViewCell.Value != null)
			{
				using Font font = new Font(dataGridViewWithThemedScrollBars_0.Font, FontStyle.Underline);
				Point pt = new Point(e.CellBounds.Left + 1, e.CellBounds.Top + e.CellBounds.Height / 2);
				Color foreColor = (dataGridViewCell.Selected ? Color.White : Form23.color_12);
				TextRenderer.DrawText(e.Graphics, dataGridViewCell.Value.ToString(), font, pt, foreColor, Color.Transparent, TextFormatFlags.VerticalCenter);
			}
			e.Handled = true;
		}
		else if (e.ColumnIndex == 11)
		{
			e.PaintBackground(e.CellBounds, cellsPaintSelectionBackground: true);
			using (Pen pen = new Pen(Form23.color_12, 2f))
			{
				int num = e.CellBounds.Left + e.CellBounds.Width / 2 - 6 - 1;
				int x = num + 12;
				int num2 = e.CellBounds.Top + e.CellBounds.Height / 2 - 6 - 1;
				int num3 = num2 + 12;
				e.Graphics.DrawLine(pen, num, num2, x, num3);
				e.Graphics.DrawLine(pen, num, num3, x, num2);
			}
			e.Handled = true;
		}
		else
		{
			if (e.ColumnIndex != 12)
			{
				return;
			}
			e.PaintBackground(e.CellBounds, cellsPaintSelectionBackground: true);
			int x2 = e.CellBounds.Left + e.CellBounds.Width / 2 - 9 - 1;
			int y = e.CellBounds.Top + e.CellBounds.Height / 2 - 9 - 1;
			if (!bindingList_0[e.RowIndex].HasSignalNameError && !bindingList_0[e.RowIndex].HasBitOverlapError && !bindingList_0[e.RowIndex].HasBeyondEndOfFrameError && !bindingList_0[e.RowIndex].InvalidUnits && (bindingList_0[e.RowIndex].FrameDirection != CANFrameModel.Direction.Transmit || bindingList_0[e.RowIndex].Source != null))
			{
				if (bindingList_0[e.RowIndex].HasZeroMultiplierWarning)
				{
					e.Graphics.DrawImage(GeneralResources.YellowWarning, x2, y, 18, 18);
				}
			}
			else
			{
				e.Graphics.DrawImage(GeneralResources.RedError, x2, y, 18, 18);
			}
			e.Handled = true;
		}
	}

	private void dataGridViewWithThemedScrollBars_0_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
	{
		if (e.ColumnIndex == 11 && e.RowIndex >= 0)
		{
			e.ToolTipText = Class333.smethod_283();
		}
		else if (e.ColumnIndex == 12 && e.RowIndex >= 0)
		{
			e.ToolTipText = Class333.smethod_284();
		}
		else if (e.RowIndex != -1 && e.ColumnIndex != -1)
		{
			Point point = dataGridViewWithThemedScrollBars_0.PointToClient(System.Windows.Forms.Cursor.Position);
			DataGridView.HitTestInfo hitTestInfo = dataGridViewWithThemedScrollBars_0.HitTest(point.X, point.Y);
			if (hitTestInfo.RowIndex != e.RowIndex || hitTestInfo.ColumnIndex != e.ColumnIndex)
			{
				dataGridViewWithThemedScrollBars_0.ShowCellToolTips = false;
			}
			e.ToolTipText = string.Empty;
		}
		else
		{
			e.ToolTipText = string.Empty;
		}
	}

	private void dataGridViewWithThemedScrollBars_0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		if (!bool_0 && eventHandler_0 != null && bindingList_0 != null)
		{
			Invoke(eventHandler_0, this, bindingList_0.ToList());
			dataGridViewWithThemedScrollBars_0.method_4();
			method_3();
			if (eventHandler_1 != null)
			{
				Invoke(eventHandler_1, this, null);
			}
		}
	}

	private void method_2(int int_16, int int_17)
	{
		if (int_17 == 1 && int_16 < bindingList_0.Count)
		{
			int_15 = bindingList_0[int_16].Format;
		}
		dataGridViewWithThemedScrollBars_0.BeginEdit(selectAll: true);
		((ComboBox)dataGridViewWithThemedScrollBars_0.EditingControl).DroppedDown = true;
	}

	private void dataGridViewWithThemedScrollBars_0_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (!bool_0)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1 && dataGridViewWithThemedScrollBars_0.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && !bool_1)
			{
				method_2(e.RowIndex, e.ColumnIndex);
			}
			if (eventHandler_1 != null)
			{
				Invoke(eventHandler_1, this, null);
			}
		}
	}

	private void dataGridViewWithThemedScrollBars_0_CurrentCellDirtyStateChanged(object sender, EventArgs e)
	{
		if (bool_0 || !dataGridViewWithThemedScrollBars_0.IsCurrentCellDirty)
		{
			return;
		}
		dataGridViewWithThemedScrollBars_0.CommitEdit(DataGridViewDataErrorContexts.Commit);
		if (dataGridViewWithThemedScrollBars_0.CurrentCell == null || dataGridViewWithThemedScrollBars_0.CurrentCell.RowIndex == -1 || dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex == -1 || !(dataGridViewWithThemedScrollBars_0.Columns[dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex] is DataGridViewComboBoxColumn))
		{
			return;
		}
		if (dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex == 1 && dataGridViewWithThemedScrollBars_0.CurrentCell.RowIndex < bindingList_0.Count)
		{
			CANSignalModel cANSignalModel = bindingList_0[dataGridViewWithThemedScrollBars_0.CurrentCell.RowIndex];
			if (int_15 == -1 || int_15 != cANSignalModel.Format)
			{
				cANSignalModel.UpdateStartBitAfterFormatChange();
				int_15 = cANSignalModel.Format;
			}
		}
		dataGridViewWithThemedScrollBars_0_CellEndEdit(null, null);
	}

	private void dataGridViewWithThemedScrollBars_0_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if (!bool_0 && eventHandler_0 != null && bindingList_0 != null)
		{
			Invoke(eventHandler_0, this, bindingList_0.ToList());
			method_3();
		}
	}

	private void dataGridViewWithThemedScrollBars_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
	}

	private void dataGridViewWithThemedScrollBars_0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0 || e.ColumnIndex < 0 || bindingList_0 == null || e.RowIndex > bindingList_0.Count)
		{
			return;
		}
		if (dataGridViewWithThemedScrollBars_0.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
		{
			method_2(e.RowIndex, e.ColumnIndex);
		}
		if (e.ColumnIndex == 5)
		{
			CANSourceSelectionForm cANSourceSelectionForm = new CANSourceSelectionForm();
			cANSourceSelectionForm.Source = bindingList_0[e.RowIndex].Source;
			if (cANSourceSelectionForm.ShowDialog() == DialogResult.OK && e.RowIndex >= 0 && e.RowIndex < bindingList_0.Count)
			{
				bindingList_0[e.RowIndex].Source = cANSourceSelectionForm.Source;
				method_5(e.RowIndex);
				dataGridViewWithThemedScrollBars_0_CellEndEdit(null, null);
			}
			cANSourceSelectionForm.Dispose();
		}
		else if (e.ColumnIndex == 11)
		{
			bindingList_0.RemoveAt(e.RowIndex);
		}
		else
		{
			if (e.ColumnIndex != 12)
			{
				return;
			}
			_ = dataGridViewWithThemedScrollBars_0.Rows[e.RowIndex].Cells[12];
			List<string> list = new List<string>();
			List<Color> list2 = new List<Color>();
			if (bindingList_0[e.RowIndex].HasSignalNameError)
			{
				list.Add(Class333.smethod_285());
				list2.Add(Form23.color_7);
			}
			if (bindingList_0[e.RowIndex].HasBitOverlapError)
			{
				list.Add(Class333.smethod_286());
				list2.Add(Form23.color_7);
			}
			if (bindingList_0[e.RowIndex].HasBeyondEndOfFrameError)
			{
				list.Add(Class333.smethod_287());
				list2.Add(Form23.color_7);
			}
			if (bindingList_0[e.RowIndex].FrameDirection == CANFrameModel.Direction.Transmit && bindingList_0[e.RowIndex].Source == null)
			{
				list.Add(Class333.smethod_288());
				list2.Add(Form23.color_7);
			}
			if (bindingList_0[e.RowIndex].InvalidUnits)
			{
				list.Add(Class333.smethod_289());
				list2.Add(Form23.color_7);
			}
			if (bindingList_0[e.RowIndex].HasZeroMultiplierWarning)
			{
				if (bindingList_0[e.RowIndex].FrameDirection == CANFrameModel.Direction.Transmit)
				{
					list.Add(Class333.smethod_290());
				}
				else
				{
					list.Add(Class333.smethod_291());
				}
				list2.Add(Color.Orange);
			}
			if (list.Count == 0 || list2.Count != list.Count)
			{
				return;
			}
			if (list.Count > 1)
			{
				for (int i = 0; i < list.Count; i++)
				{
					list[i] = Class333.smethod_292() + list[i];
				}
			}
			int num = dataGridViewWithThemedScrollBars_0.Top + dataGridViewWithThemedScrollBars_0.ColumnHeadersHeight;
			for (int j = 0; j < e.RowIndex; j++)
			{
				num += dataGridViewWithThemedScrollBars_0.Rows[j].Height;
			}
			num -= dataGridViewWithThemedScrollBars_0.VerticalScrollingOffset;
			int num2 = dataGridViewWithThemedScrollBars_0.Left;
			for (int k = 0; k < dataGridViewWithThemedScrollBars_0.Columns.Count; k++)
			{
				if (dataGridViewWithThemedScrollBars_0.Columns[k].Visible)
				{
					num2 += dataGridViewWithThemedScrollBars_0.Columns[k].Width;
				}
			}
			num2 -= dataGridViewWithThemedScrollBars_0.HorizontalScrollingOffset;
			Form23.smethod_52(list, list2, dataGridViewWithThemedScrollBars_0, bindingList_0[e.RowIndex], num2 + 5, num);
		}
	}

	private void dataGridViewWithThemedScrollBars_0_LostFocus(object sender, EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			Invoke(eventHandler_1, this, null);
		}
	}

	public void SelectSignal(CANSignalModel signalToSelect)
	{
		for (int i = 0; i < bindingList_0.Count && i < dataGridViewWithThemedScrollBars_0.Rows.Count; i++)
		{
			if (bindingList_0[i] != signalToSelect)
			{
				continue;
			}
			if (dataGridViewWithThemedScrollBars_0.CurrentCell == null || dataGridViewWithThemedScrollBars_0.CurrentCell.RowIndex != i)
			{
				int index = 0;
				if (dataGridViewWithThemedScrollBars_0.CurrentCell != null)
				{
					index = dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex;
				}
				bool_1 = true;
				dataGridViewWithThemedScrollBars_0.CurrentCell = dataGridViewWithThemedScrollBars_0.Rows[i].Cells[index];
				bool_1 = false;
				dataGridViewWithThemedScrollBars_0.Refresh();
			}
			break;
		}
	}

	public CANSignalModel GetSelectedSignal()
	{
		if (dataGridViewWithThemedScrollBars_0.CurrentCell != null && dataGridViewWithThemedScrollBars_0.CurrentCell.RowIndex < dataGridViewWithThemedScrollBars_0.Rows.Count && dataGridViewWithThemedScrollBars_0.CurrentCell.RowIndex < bindingList_0.Count)
		{
			return bindingList_0[dataGridViewWithThemedScrollBars_0.CurrentCell.RowIndex];
		}
		return null;
	}

	internal void method_3(bool bool_2 = true)
	{
		for (int i = 0; i < bindingList_0.Count; i++)
		{
			CANSignalModel cANSignalModel = bindingList_0[i];
			int index = ((cANSignalModel.FrameDirection == CANFrameModel.Direction.Transmit) ? 9 : 8);
			int index2 = ((cANSignalModel.FrameDirection == CANFrameModel.Direction.Transmit) ? 8 : 9);
			if (cANSignalModel.HasSignalNameError)
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[0].Style.BackColor = Form23.color_7;
			}
			else
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[0].Style.BackColor = Form23.color_32;
			}
			if (!cANSignalModel.HasBitOverlapError && !cANSignalModel.HasBeyondEndOfFrameError)
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[2].Style.BackColor = Form23.color_32;
			}
			else
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[2].Style.BackColor = Form23.color_7;
			}
			if (!cANSignalModel.HasBitOverlapError && !cANSignalModel.HasBeyondEndOfFrameError)
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[3].Style.BackColor = Form23.color_32;
			}
			else
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[3].Style.BackColor = Form23.color_7;
			}
			if (cANSignalModel.HasZeroMultiplierWarning)
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[index].Style.BackColor = Color.Orange;
			}
			else
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[index].Style.BackColor = Form23.color_32;
			}
			dataGridViewWithThemedScrollBars_0.Rows[i].Cells[index2].Style.BackColor = Form23.color_32;
			if (cANSignalModel.ValueOverflowedBitLength())
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[10].Style.BackColor = Form23.color_7;
			}
			else
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[10].Style.BackColor = Form23.color_32;
			}
			if (cANSignalModel.FrameDirection == CANFrameModel.Direction.Transmit && cANSignalModel.Source == null)
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[5].Style.BackColor = Form23.color_7;
			}
			else
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[5].Style.BackColor = Form23.color_32;
			}
			if (cANSignalModel.InvalidUnits)
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[7].Style.BackColor = Form23.color_7;
			}
			else
			{
				dataGridViewWithThemedScrollBars_0.Rows[i].Cells[7].Style.BackColor = Form23.color_32;
			}
		}
		if (bool_2)
		{
			dataGridViewWithThemedScrollBars_0.Refresh();
		}
	}

	internal void method_4(List<CANSignalModel> list_0, CANFrameModel.Direction direction_0)
	{
		int num = dataGridViewWithThemedScrollBars_0.CurrentCell?.RowIndex ?? 0;
		int num2 = dataGridViewWithThemedScrollBars_0.CurrentCell?.ColumnIndex ?? 0;
		bool_0 = true;
		if (direction_0 == CANFrameModel.Direction.Transmit)
		{
			dataGridViewWithThemedScrollBars_0.Columns[10].HeaderText = Class333.smethod_293();
			dataGridViewWithThemedScrollBars_0.Columns[6].HeaderText = Class333.smethod_294();
			dataGridViewWithThemedScrollBars_0.Columns[5].Visible = true;
			dataGridViewWithThemedScrollBars_0.Columns[8].HeaderText = Class333.smethod_295();
			dataGridViewTextBoxColumn_4.DataPropertyName = Class333.smethod_296();
			dataGridViewWithThemedScrollBars_0.Columns[9].HeaderText = Class333.smethod_297();
			dataGridViewTextBoxColumn_5.DataPropertyName = Class333.smethod_298();
		}
		else
		{
			dataGridViewWithThemedScrollBars_0.Columns[10].HeaderText = Class333.smethod_299();
			dataGridViewWithThemedScrollBars_0.Columns[6].HeaderText = Class333.smethod_300();
			dataGridViewWithThemedScrollBars_0.Columns[5].Visible = false;
			dataGridViewWithThemedScrollBars_0.Columns[8].HeaderText = Class333.smethod_298();
			dataGridViewTextBoxColumn_4.DataPropertyName = Class333.smethod_298();
			dataGridViewWithThemedScrollBars_0.Columns[9].HeaderText = Class333.smethod_296();
			dataGridViewTextBoxColumn_5.DataPropertyName = Class333.smethod_296();
		}
		if (list_0 == null)
		{
			bindingList_0.Clear();
			bool_0 = false;
			dataGridViewWithThemedScrollBars_0.method_4();
			return;
		}
		bindingList_0 = new BindingList<CANSignalModel>(list_0);
		dataGridViewWithThemedScrollBars_0.DataSource = bindingList_0;
		for (int i = 0; i < bindingList_0.Count && i < dataGridViewWithThemedScrollBars_0.Rows.Count; i++)
		{
			method_5(i);
		}
		if (num < dataGridViewWithThemedScrollBars_0.Rows.Count && num < bindingList_0.Count && num2 < dataGridViewWithThemedScrollBars_0.Rows[num].Cells.Count && dataGridViewWithThemedScrollBars_0.Rows[num].Cells[num2].Visible)
		{
			dataGridViewWithThemedScrollBars_0.CurrentCell = dataGridViewWithThemedScrollBars_0.Rows[num].Cells[num2];
		}
		bool_0 = false;
		dataGridViewWithThemedScrollBars_0.Refresh();
		dataGridViewWithThemedScrollBars_0.method_4();
	}

	private void method_5(int int_16)
	{
		List<ValueAndDisplay> unitsListDataSource = bindingList_0[int_16].GetUnitsListDataSource();
		if (unitsListDataSource != null && dataGridViewWithThemedScrollBars_0.Rows[int_16].Cells[7] is DataGridViewComboBoxCell dataGridViewComboBoxCell)
		{
			dataGridViewComboBoxCell.DataSource = unitsListDataSource;
			dataGridViewComboBoxCell.ValueType = typeof(int);
			dataGridViewComboBoxCell.DisplayMember = Class333.smethod_279();
			dataGridViewComboBoxCell.ValueMember = Class333.smethod_280();
			if (unitsListDataSource.Count == 1)
			{
				dataGridViewComboBoxCell.Value = unitsListDataSource[0].Value;
			}
		}
	}

	private void method_6()
	{
		BackColor = Form23.color_16;
		ForeColor = Form23.color_12;
		dataGridViewWithThemedScrollBars_0.BackgroundColor = Form23.color_16;
		dataGridViewWithThemedScrollBars_0.ForeColor = Form23.color_12;
		dataGridViewWithThemedScrollBars_0.ColumnHeadersDefaultCellStyle.BackColor = Form23.color_16;
		dataGridViewWithThemedScrollBars_0.ColumnHeadersDefaultCellStyle.ForeColor = Form23.color_12;
		dataGridViewWithThemedScrollBars_0.DefaultCellStyle.BackColor = Form23.color_32;
		dataGridViewWithThemedScrollBars_0.DefaultCellStyle.ForeColor = Form23.color_12;
		dataGridViewButtonColumn_0.DefaultCellStyle.Font = new Font(Font, FontStyle.Underline);
		dataGridViewComboBoxColumn_1.DefaultCellStyle.BackColor = Form23.color_32;
		dataGridViewComboBoxColumn_1.DefaultCellStyle.ForeColor = Form23.color_12;
		dataGridViewComboBoxColumn_1.FlatStyle = FlatStyle.Flat;
		dataGridViewComboBoxColumn_2.DefaultCellStyle.BackColor = Form23.color_32;
		dataGridViewComboBoxColumn_2.DefaultCellStyle.ForeColor = Form23.color_12;
		dataGridViewComboBoxColumn_2.FlatStyle = FlatStyle.Flat;
		dataGridViewComboBoxColumn_0.DefaultCellStyle.BackColor = Form23.color_32;
		dataGridViewComboBoxColumn_0.DefaultCellStyle.ForeColor = Form23.color_12;
		dataGridViewComboBoxColumn_0.FlatStyle = FlatStyle.Flat;
		dataGridViewWithThemedScrollBars_0.BorderStyle = BorderStyle.None;
	}

	public void UpdateRawValue(long val)
	{
		for (int i = 0; i < bindingList_0.Count; i++)
		{
			bindingList_0[i].RawValue = val.ToString();
		}
		dataGridViewWithThemedScrollBars_0.Invalidate();
		method_3(bool_2: false);
	}

	public bool IsFocused()
	{
		return dataGridViewWithThemedScrollBars_0.Focused;
	}

	private bool method_7()
	{
		if (dataGridViewWithThemedScrollBars_0.CurrentCell != null && (dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex == 2 || dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex == 3 || dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex == 7 || dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex == 8 || dataGridViewWithThemedScrollBars_0.CurrentCell.ColumnIndex == 9))
		{
			return true;
		}
		return false;
	}

	internal bool method_8(KeyEventArgs keyEventArgs_0)
	{
		if (!method_7())
		{
			return false;
		}
		int num = 0;
		object value = dataGridViewWithThemedScrollBars_0.CurrentCell.Value;
		float num2;
		if ((keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Prior) || keyEventArgs_0.KeyData == Keys.OemPeriod)
		{
			num2 = Class233.smethod_36(num);
		}
		else if (keyEventArgs_0.KeyData != Keys.Prior && keyEventArgs_0.KeyData != Keys.Oem7)
		{
			if ((keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Prior) || keyEventArgs_0.KeyData == Keys.OemCloseBrackets)
			{
				num2 = Class233.smethod_38(num);
			}
			else if ((keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Next) || keyEventArgs_0.KeyData == Keys.Oemcomma)
			{
				num2 = -Class233.smethod_36(num);
			}
			else if (keyEventArgs_0.KeyData != Keys.Next && keyEventArgs_0.KeyData != Keys.OemSemicolon)
			{
				if ((!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Next) && keyEventArgs_0.KeyData != Keys.OemOpenBrackets)
				{
					return false;
				}
				num2 = -Class233.smethod_38(num);
			}
			else
			{
				num2 = -Class233.smethod_37(num);
			}
		}
		else
		{
			num2 = Class233.smethod_37(num);
		}
		object obj = null;
		if (value is int num3)
		{
			obj = num3 + (int)num2;
		}
		else if (value is uint num4)
		{
			obj = num4 + (int)num2;
		}
		else
		{
			if (!(value is float num5))
			{
				return false;
			}
			obj = num5 + num2;
		}
		dataGridViewWithThemedScrollBars_0.CurrentCell.Value = obj;
		Invoke(eventHandler_0, this, bindingList_0.ToList());
		keyEventArgs_0.Handled = true;
		keyEventArgs_0.SuppressKeyPress = true;
		return true;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_9()
	{
		icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		themedButton_0 = new ThemedButton();
		bindingSource_0 = new BindingSource(icontainer_0);
		dataGridViewWithThemedScrollBars_0 = new DataGridViewWithThemedScrollBars();
		dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
		dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
		dataGridViewButtonColumn_0 = new DataGridViewButtonColumn();
		dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		dataGridViewComboBoxColumn_2 = new DataGridViewComboBoxColumn();
		dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		dataGridViewButtonColumn_1 = new DataGridViewButtonColumn();
		dataGridViewButtonColumn_2 = new DataGridViewButtonColumn();
		((ISupportInitialize)bindingSource_0).BeginInit();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_0).BeginInit();
		SuspendLayout();
		themedButton_0.Location = new Point(5, 0);
		themedButton_0.Name = Class333.smethod_301();
		themedButton_0.Size = new Size(100, 25);
		themedButton_0.TabIndex = 0;
		themedButton_0.Text = Class333.smethod_302();
		bindingSource_0.DataSource = typeof(CANSignalModel);
		dataGridViewWithThemedScrollBars_0.AllowUserToAddRows = false;
		dataGridViewWithThemedScrollBars_0.AllowUserToDeleteRows = false;
		dataGridViewWithThemedScrollBars_0.AllowUserToResizeRows = false;
		dataGridViewWithThemedScrollBars_0.AutoGenerateColumns = false;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font(Class333.smethod_145(), 8.25f);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		dataGridViewWithThemedScrollBars_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dataGridViewWithThemedScrollBars_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewWithThemedScrollBars_0.Columns.AddRange(dataGridViewTextBoxColumn_0, dataGridViewComboBoxColumn_0, dataGridViewTextBoxColumn_1, dataGridViewTextBoxColumn_2, dataGridViewComboBoxColumn_1, dataGridViewButtonColumn_0, dataGridViewTextBoxColumn_3, dataGridViewComboBoxColumn_2, dataGridViewTextBoxColumn_4, dataGridViewTextBoxColumn_5, dataGridViewTextBoxColumn_6, dataGridViewButtonColumn_1, dataGridViewButtonColumn_2);
		dataGridViewWithThemedScrollBars_0.DataSource = bindingSource_0;
		dataGridViewWithThemedScrollBars_0.Location = new Point(0, 30);
		dataGridViewWithThemedScrollBars_0.Margin = new Padding(2);
		dataGridViewWithThemedScrollBars_0.MultiSelect = false;
		dataGridViewWithThemedScrollBars_0.Name = Class333.smethod_303();
		dataGridViewWithThemedScrollBars_0.RowHeadersVisible = false;
		dataGridViewWithThemedScrollBars_0.ScrollBars = ScrollBars.Both;
		dataGridViewWithThemedScrollBars_0.ShowCellToolTips = true;
		dataGridViewWithThemedScrollBars_0.Size = new Size(930, 180);
		dataGridViewWithThemedScrollBars_0.TabIndex = 1;
		dataGridViewTextBoxColumn_0.DataPropertyName = Class333.smethod_304();
		dataGridViewTextBoxColumn_0.HeaderText = Class333.smethod_305();
		dataGridViewTextBoxColumn_0.MinimumWidth = 40;
		dataGridViewTextBoxColumn_0.Name = Class333.smethod_306();
		dataGridViewTextBoxColumn_0.Width = 60;
		dataGridViewComboBoxColumn_0.DataPropertyName = Class333.smethod_281();
		dataGridViewComboBoxColumn_0.HeaderText = Class333.smethod_281();
		dataGridViewComboBoxColumn_0.MinimumWidth = 50;
		dataGridViewComboBoxColumn_0.Name = Class333.smethod_307();
		dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
		dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
		dataGridViewComboBoxColumn_0.Width = 150;
		dataGridViewTextBoxColumn_1.DataPropertyName = Class333.smethod_308();
		dataGridViewTextBoxColumn_1.HeaderText = Class333.smethod_309();
		dataGridViewTextBoxColumn_1.MinimumWidth = 30;
		dataGridViewTextBoxColumn_1.Name = Class333.smethod_310();
		dataGridViewTextBoxColumn_1.Width = 40;
		dataGridViewTextBoxColumn_2.DataPropertyName = Class333.smethod_311();
		dataGridViewTextBoxColumn_2.HeaderText = Class333.smethod_312();
		dataGridViewTextBoxColumn_2.MinimumWidth = 30;
		dataGridViewTextBoxColumn_2.Name = Class333.smethod_313();
		dataGridViewTextBoxColumn_2.Width = 50;
		dataGridViewComboBoxColumn_1.DataPropertyName = Class333.smethod_278();
		dataGridViewComboBoxColumn_1.HeaderText = Class333.smethod_278();
		dataGridViewComboBoxColumn_1.MinimumWidth = 50;
		dataGridViewComboBoxColumn_1.Name = Class333.smethod_314();
		dataGridViewComboBoxColumn_1.Resizable = DataGridViewTriState.True;
		dataGridViewComboBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
		dataGridViewComboBoxColumn_1.Width = 80;
		dataGridViewButtonColumn_0.DataPropertyName = Class333.smethod_315();
		dataGridViewButtonColumn_0.HeaderText = Class333.smethod_316();
		dataGridViewButtonColumn_0.MinimumWidth = 40;
		dataGridViewButtonColumn_0.Name = Class333.smethod_317();
		dataGridViewButtonColumn_0.ReadOnly = true;
		dataGridViewTextBoxColumn_3.DataPropertyName = Class333.smethod_318();
		dataGridViewTextBoxColumn_3.HeaderText = Class333.smethod_319();
		dataGridViewTextBoxColumn_3.MinimumWidth = 50;
		dataGridViewTextBoxColumn_3.Name = Class333.smethod_320();
		dataGridViewTextBoxColumn_3.ReadOnly = true;
		dataGridViewTextBoxColumn_3.Width = 70;
		dataGridViewComboBoxColumn_2.DataPropertyName = Class333.smethod_282();
		dataGridViewComboBoxColumn_2.DropDownWidth = 220;
		dataGridViewComboBoxColumn_2.HeaderText = Class333.smethod_282();
		dataGridViewComboBoxColumn_2.MinimumWidth = 40;
		dataGridViewComboBoxColumn_2.Name = Class333.smethod_321();
		dataGridViewComboBoxColumn_2.Width = 120;
		dataGridViewTextBoxColumn_4.DataPropertyName = Class333.smethod_298();
		dataGridViewTextBoxColumn_4.HeaderText = Class333.smethod_298();
		dataGridViewTextBoxColumn_4.MinimumWidth = 40;
		dataGridViewTextBoxColumn_4.Name = Class333.smethod_322();
		dataGridViewTextBoxColumn_4.Width = 65;
		dataGridViewTextBoxColumn_5.DataPropertyName = Class333.smethod_296();
		dataGridViewTextBoxColumn_5.HeaderText = Class333.smethod_296();
		dataGridViewTextBoxColumn_5.MinimumWidth = 40;
		dataGridViewTextBoxColumn_5.Name = Class333.smethod_323();
		dataGridViewTextBoxColumn_5.Width = 50;
		dataGridViewTextBoxColumn_6.DataPropertyName = Class333.smethod_280();
		dataGridViewTextBoxColumn_6.HeaderText = Class333.smethod_280();
		dataGridViewTextBoxColumn_6.MinimumWidth = 50;
		dataGridViewTextBoxColumn_6.Name = Class333.smethod_324();
		dataGridViewTextBoxColumn_6.ReadOnly = true;
		dataGridViewTextBoxColumn_6.Width = 70;
		dataGridViewButtonColumn_1.HeaderText = Class333.smethod_325();
		dataGridViewButtonColumn_1.MinimumWidth = 25;
		dataGridViewButtonColumn_1.Name = Class333.smethod_326();
		dataGridViewButtonColumn_1.ReadOnly = true;
		dataGridViewButtonColumn_1.Resizable = DataGridViewTriState.False;
		dataGridViewButtonColumn_1.Width = 25;
		dataGridViewButtonColumn_2.HeaderText = Class333.smethod_325();
		dataGridViewButtonColumn_2.MinimumWidth = 25;
		dataGridViewButtonColumn_2.Name = Class333.smethod_327();
		dataGridViewButtonColumn_2.ReadOnly = true;
		dataGridViewButtonColumn_2.Resizable = DataGridViewTriState.False;
		dataGridViewButtonColumn_2.Width = 25;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(themedButton_0);
		Controls.Add(dataGridViewWithThemedScrollBars_0);
		Margin = new Padding(2);
		Name = Class333.smethod_328();
		Size = new Size(935, 220);
		((ISupportInitialize)bindingSource_0).EndInit();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_0).EndInit();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void dataGridViewWithThemedScrollBars_0_CellMouseEnter(object? sender, DataGridViewCellEventArgs e)
	{
		dataGridViewWithThemedScrollBars_0.ShowCellToolTips = true;
	}

	[CompilerGenerated]
	private void dataGridViewWithThemedScrollBars_0_CellMouseLeave(object? sender, DataGridViewCellEventArgs e)
	{
		dataGridViewWithThemedScrollBars_0.ShowCellToolTips = false;
	}
}
