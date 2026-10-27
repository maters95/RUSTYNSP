using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface.Forms;
using b;

namespace NSP.UserInterface;

public class CANSignalEditor : UserControl
{
	internal const int dB = 120;

	private const int db = 0;

	private const int dC = 1;

	private const int dc = 2;

	private const int dD = 3;

	private const int dd = 4;

	private const int dE = 5;

	private const int de = 6;

	private const int dF = 7;

	private const int df = 8;

	private const int dG = 9;

	private const int dg = 10;

	private const int dH = 11;

	private const int dh = 12;

	private static int[] dI = new int[13];

	private BindingList<CANSignalModel> di = new BindingList<CANSignalModel>();

	private bool dJ;

	private int dj = -1;

	private bool dK;

	[CompilerGenerated]
	private EventHandler<List<CANSignalModel>> dk;

	[CompilerGenerated]
	private EventHandler dL;

	private IContainer dl;

	private DataGridViewWithThemedScrollBars dM;

	private BindingSource dm;

	private ThemedButton dN;

	private DataGridViewTextBoxColumn dn;

	private DataGridViewComboBoxColumn dO;

	private DataGridViewTextBoxColumn @do;

	private DataGridViewTextBoxColumn dP;

	private DataGridViewComboBoxColumn dp;

	private DataGridViewButtonColumn dQ;

	private DataGridViewTextBoxColumn dq;

	private DataGridViewComboBoxColumn dR;

	private DataGridViewTextBoxColumn dr;

	private DataGridViewTextBoxColumn dS;

	private DataGridViewTextBoxColumn ds;

	private DataGridViewButtonColumn dT;

	private DataGridViewButtonColumn dt;

	public event EventHandler<List<CANSignalModel>> SignalsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<List<CANSignalModel>> val = dk;
			EventHandler<List<CANSignalModel>> val2;
			do
			{
				val2 = val;
				EventHandler<List<CANSignalModel>> val3 = (EventHandler<List<CANSignalModel>>)(object)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler<List<CANSignalModel>>>(ref dk, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<List<CANSignalModel>> val = dk;
			EventHandler<List<CANSignalModel>> val2;
			do
			{
				val2 = val;
				EventHandler<List<CANSignalModel>> val3 = (EventHandler<List<CANSignalModel>>)(object)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler<List<CANSignalModel>>>(ref dk, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler SignalSelectionChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = dL;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref dL, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = dL;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref dL, val3, val2);
			}
			while (val != val2);
		}
	}

	public CANSignalEditor()
	{
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		C();
		((DataGridViewColumn)dp).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ci();
		((DataGridViewColumn)dp).ValueType = typeof(int);
		dp.DisplayMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cJ();
		dp.ValueMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
		((DataGridViewColumn)dp).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ci();
		((DataGridViewColumn)dO).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cK();
		((DataGridViewColumn)dO).ValueType = typeof(int);
		dO.DisplayMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cJ();
		dO.ValueMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
		((DataGridViewColumn)dO).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cK();
		((DataGridViewColumn)dR).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ck();
		((DataGridViewColumn)dR).ValueType = typeof(int);
		dR.DisplayMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cJ();
		dR.ValueMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
		((DataGridViewColumn)dR).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ck();
		B();
		di.AllowEdit = true;
		di.AllowNew = true;
		di.AllowRemove = true;
		((Control)this).DataContext = this;
		((DataGridView)dM).DataSource = di;
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)dM).Columns)
		{
			DataGridViewColumn val = item;
			if (((DataGridViewBand)val).Index < dI.Length && dI[((DataGridViewBand)val).Index] != 0)
			{
				val.Width = dI[((DataGridViewBand)val).Index];
			}
		}
		((DataGridView)dM).CellEndEdit += new DataGridViewCellEventHandler(a);
		((DataGridView)dM).RowsRemoved += new DataGridViewRowsRemovedEventHandler(A);
		((DataGridView)dM).CellClick += new DataGridViewCellEventHandler(B);
		((DataGridView)dM).DataError += new DataGridViewDataErrorEventHandler(A);
		((DataGridView)dM).CurrentCellDirtyStateChanged += new EventHandler(b);
		((DataGridView)dM).CellEnter += new DataGridViewCellEventHandler(A);
		((DataGridView)dM).CellToolTipTextNeeded += new DataGridViewCellToolTipTextNeededEventHandler(A);
		((DataGridView)dM).CellPainting += new DataGridViewCellPaintingEventHandler(A);
		((DataGridView)dM).EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(A);
		((Control)dM).LostFocus += new EventHandler(C);
		((DataGridView)dM).ColumnWidthChanged += new DataGridViewColumnEventHandler(a);
		((DataGridView)dM).CellMouseEnter += (DataGridViewCellEventHandler)([CompilerGenerated] (object? o, DataGridViewCellEventArgs P_1) =>
		{
			((DataGridView)dM).ShowCellToolTips = true;
		});
		((DataGridView)dM).CellMouseLeave += (DataGridViewCellEventHandler)([CompilerGenerated] (object? o, DataGridViewCellEventArgs P_1) =>
		{
			((DataGridView)dM).ShowCellToolTips = false;
		});
		dM.C();
		((Control)dN).Click += new EventHandler(B);
		((Control)this).Resize += new EventHandler(A);
		((Control)this).Layout += new LayoutEventHandler(A);
	}

	private void A(object P_0, EventArgs P_1)
	{
		((Control)dM).Width = ((Control)this).Width - 5;
		((Control)dM).Height = ((Control)this).Height - ((Control)dM).Top - 10;
		dM.C();
	}

	internal int A()
	{
		int num = ((Control)dM).Left;
		for (int i = 0; i < ((BaseCollection)((DataGridView)dM).Columns).Count; i++)
		{
			if (((DataGridViewBand)((DataGridView)dM).Columns[i]).Visible)
			{
				num += ((DataGridView)dM).Columns[i].Width;
			}
		}
		return num + 6 + 18;
	}

	internal int a()
	{
		int num = ((Control)dM).Top + ((DataGridView)dM).ColumnHeadersHeight;
		for (int i = 0; i < ((DataGridView)dM).Rows.Count; i++)
		{
			num += ((DataGridView)dM).Rows[i].Height;
		}
		return Math.Max(num + 2 + 18, 120);
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)dM).Columns)
		{
			DataGridViewColumn val = item;
			if (((DataGridViewBand)val).Index < dI.Length)
			{
				dI[((DataGridViewBand)val).Index] = val.Width;
			}
		}
		dM.C();
	}

	public void ApplySignComboBoxDataSource(List<ValueAndDisplay> signDataSource)
	{
		dp.DataSource = signDataSource;
	}

	public void ApplyFormatComboBoxDataSource(List<ValueAndDisplay> formatDataSource)
	{
		dO.DataSource = formatDataSource;
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (di == null)
		{
			return;
		}
		CANSignalModel cANSignalModel = new CANSignalModel
		{
			Id = -1,
			Index = -1
		};
		((Collection<CANSignalModel>)(object)di).Add(cANSignalModel);
		if (dk != null)
		{
			List<CANSignalModel> val = Enumerable.ToList<CANSignalModel>((System.Collections.Generic.IEnumerable<CANSignalModel>)di);
			((Control)this).Invoke((System.Delegate)(object)dk, new object[2] { this, val });
			if (val.Contains(cANSignalModel))
			{
				A(val.IndexOf(cANSignalModel));
			}
			else
			{
				((Collection<CANSignalModel>)(object)di).Remove(cANSignalModel);
			}
		}
		dM.C();
		A(true);
	}

	private void A(object P_0, DataGridViewEditingControlShowingEventArgs P_1)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridView)dM).CurrentCell != null && ((DataGridView)dM).CurrentCell.ColumnIndex == 7)
		{
			P_1.CellStyle.BackColor = BM.to;
			P_1.CellStyle.ForeColor = BM.te;
		}
	}

	private void A(object P_0, DataGridViewCellPaintingEventArgs P_1)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (P_1.RowIndex < 0 || di == null || P_1.RowIndex >= ((Collection<CANSignalModel>)(object)di).Count || P_1.RowIndex >= ((DataGridView)dM).Rows.Count)
		{
			return;
		}
		Rectangle cellBounds;
		if (P_1.ColumnIndex == 5)
		{
			P_1.PaintBackground(P_1.CellBounds, true);
			DataGridViewCell val = ((DataGridView)dM).Rows[P_1.RowIndex].Cells[5];
			if (val.Value != null)
			{
				Font val2 = new Font(((Control)dM).Font, (FontStyle)4);
				try
				{
					cellBounds = P_1.CellBounds;
					int num = ((Rectangle)(ref cellBounds)).Left + 1;
					cellBounds = P_1.CellBounds;
					int top = ((Rectangle)(ref cellBounds)).Top;
					cellBounds = P_1.CellBounds;
					Point val3 = default(Point);
					((Point)(ref val3))._002Ector(num, top + ((Rectangle)(ref cellBounds)).Height / 2);
					Color val4 = (val.Selected ? Color.White : BM.te);
					TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, val.Value.ToString(), val2, val3, val4, Color.Transparent, (TextFormatFlags)4);
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			((HandledEventArgs)P_1).Handled = true;
		}
		else if (P_1.ColumnIndex == 11)
		{
			P_1.PaintBackground(P_1.CellBounds, true);
			Pen val5 = new Pen(BM.te, 2f);
			try
			{
				cellBounds = P_1.CellBounds;
				int left = ((Rectangle)(ref cellBounds)).Left;
				cellBounds = P_1.CellBounds;
				int num2 = left + ((Rectangle)(ref cellBounds)).Width / 2 - 6 - 1;
				int num3 = num2 + 12;
				cellBounds = P_1.CellBounds;
				int top2 = ((Rectangle)(ref cellBounds)).Top;
				cellBounds = P_1.CellBounds;
				int num4 = top2 + ((Rectangle)(ref cellBounds)).Height / 2 - 6 - 1;
				int num5 = num4 + 12;
				P_1.Graphics.DrawLine(val5, num2, num4, num3, num5);
				P_1.Graphics.DrawLine(val5, num2, num5, num3, num4);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
			((HandledEventArgs)P_1).Handled = true;
		}
		else if (P_1.ColumnIndex == 12)
		{
			P_1.PaintBackground(P_1.CellBounds, true);
			cellBounds = P_1.CellBounds;
			int left2 = ((Rectangle)(ref cellBounds)).Left;
			cellBounds = P_1.CellBounds;
			int num6 = left2 + ((Rectangle)(ref cellBounds)).Width / 2 - 9 - 1;
			cellBounds = P_1.CellBounds;
			int top3 = ((Rectangle)(ref cellBounds)).Top;
			cellBounds = P_1.CellBounds;
			int num7 = top3 + ((Rectangle)(ref cellBounds)).Height / 2 - 9 - 1;
			if (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].HasSignalNameError || ((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].HasBitOverlapError || ((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].HasBeyondEndOfFrameError || ((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].InvalidUnits || (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].FrameDirection == CANFrameModel.Direction.Transmit && ((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].Source == null))
			{
				P_1.Graphics.DrawImage((Image)(object)GeneralResources.RedError, num6, num7, 18, 18);
			}
			else if (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].HasZeroMultiplierWarning)
			{
				P_1.Graphics.DrawImage((Image)(object)GeneralResources.YellowWarning, num6, num7, 18, 18);
			}
			((HandledEventArgs)P_1).Handled = true;
		}
	}

	private void A(object P_0, DataGridViewCellToolTipTextNeededEventArgs P_1)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridViewCellEventArgs)P_1).ColumnIndex == 11 && ((DataGridViewCellEventArgs)P_1).RowIndex >= 0)
		{
			P_1.ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cL();
		}
		else if (((DataGridViewCellEventArgs)P_1).ColumnIndex == 12 && ((DataGridViewCellEventArgs)P_1).RowIndex >= 0)
		{
			P_1.ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cl();
		}
		else if (((DataGridViewCellEventArgs)P_1).RowIndex != -1 && ((DataGridViewCellEventArgs)P_1).ColumnIndex != -1)
		{
			Point val = ((Control)dM).PointToClient(Cursor.Position);
			HitTestInfo val2 = ((DataGridView)dM).HitTest(((Point)(ref val)).X, ((Point)(ref val)).Y);
			if (val2.RowIndex != ((DataGridViewCellEventArgs)P_1).RowIndex || val2.ColumnIndex != ((DataGridViewCellEventArgs)P_1).ColumnIndex)
			{
				((DataGridView)dM).ShowCellToolTips = false;
			}
			P_1.ToolTipText = string.Empty;
		}
		else
		{
			P_1.ToolTipText = string.Empty;
		}
	}

	private void A(object P_0, DataGridViewRowsRemovedEventArgs P_1)
	{
		if (!dJ && dk != null && di != null)
		{
			((Control)this).Invoke((System.Delegate)(object)dk, new object[2]
			{
				this,
				Enumerable.ToList<CANSignalModel>((System.Collections.Generic.IEnumerable<CANSignalModel>)di)
			});
			dM.C();
			A(true);
			if (dL != null)
			{
				((Control)this).Invoke((System.Delegate)(object)dL, new object[2] { this, null });
			}
		}
	}

	private void A(int P_0, int P_1)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 == 1 && P_0 < ((Collection<CANSignalModel>)(object)di).Count)
		{
			dj = ((Collection<CANSignalModel>)(object)di)[P_0].Format;
		}
		((DataGridView)dM).BeginEdit(true);
		((ComboBox)((DataGridView)dM).EditingControl).DroppedDown = true;
	}

	private void A(object P_0, DataGridViewCellEventArgs P_1)
	{
		if (!dJ)
		{
			if (P_1.RowIndex != -1 && P_1.ColumnIndex != -1 && ((DataGridView)dM).Columns[P_1.ColumnIndex] is DataGridViewComboBoxColumn && !dK)
			{
				A(P_1.RowIndex, P_1.ColumnIndex);
			}
			if (dL != null)
			{
				((Control)this).Invoke((System.Delegate)(object)dL, new object[2] { this, null });
			}
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (dJ || !((DataGridView)dM).IsCurrentCellDirty)
		{
			return;
		}
		((DataGridView)dM).CommitEdit((DataGridViewDataErrorContexts)512);
		if (((DataGridView)dM).CurrentCell == null || ((DataGridView)dM).CurrentCell.RowIndex == -1 || ((DataGridView)dM).CurrentCell.ColumnIndex == -1 || !(((DataGridView)dM).Columns[((DataGridView)dM).CurrentCell.ColumnIndex] is DataGridViewComboBoxColumn))
		{
			return;
		}
		if (((DataGridView)dM).CurrentCell.ColumnIndex == 1 && ((DataGridView)dM).CurrentCell.RowIndex < ((Collection<CANSignalModel>)(object)di).Count)
		{
			CANSignalModel cANSignalModel = ((Collection<CANSignalModel>)(object)di)[((DataGridView)dM).CurrentCell.RowIndex];
			if (dj == -1 || dj != cANSignalModel.Format)
			{
				cANSignalModel.UpdateStartBitAfterFormatChange();
				dj = cANSignalModel.Format;
			}
		}
		a((object)null, (DataGridViewCellEventArgs)null);
	}

	private void a(object P_0, DataGridViewCellEventArgs P_1)
	{
		if (!dJ && dk != null && di != null)
		{
			((Control)this).Invoke((System.Delegate)(object)dk, new object[2]
			{
				this,
				Enumerable.ToList<CANSignalModel>((System.Collections.Generic.IEnumerable<CANSignalModel>)di)
			});
			A(true);
		}
	}

	private void A(object P_0, DataGridViewDataErrorEventArgs P_1)
	{
	}

	private void B(object P_0, DataGridViewCellEventArgs P_1)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		if (P_1.RowIndex < 0 || P_1.ColumnIndex < 0 || di == null || P_1.RowIndex > ((Collection<CANSignalModel>)(object)di).Count)
		{
			return;
		}
		if (((DataGridView)dM).Columns[P_1.ColumnIndex] is DataGridViewComboBoxColumn)
		{
			A(P_1.RowIndex, P_1.ColumnIndex);
		}
		if (P_1.ColumnIndex == 5)
		{
			CANSourceSelectionForm cANSourceSelectionForm = new CANSourceSelectionForm();
			cANSourceSelectionForm.Source = ((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].Source;
			if ((int)((Form)cANSourceSelectionForm).ShowDialog() == 1 && P_1.RowIndex >= 0 && P_1.RowIndex < ((Collection<CANSignalModel>)(object)di).Count)
			{
				((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].Source = cANSourceSelectionForm.Source;
				A(P_1.RowIndex);
				a((object)null, (DataGridViewCellEventArgs)null);
			}
			((Component)cANSourceSelectionForm).Dispose();
		}
		else if (P_1.ColumnIndex == 11)
		{
			((Collection<CANSignalModel>)(object)di).RemoveAt(P_1.RowIndex);
		}
		else
		{
			if (P_1.ColumnIndex != 12)
			{
				return;
			}
			_ = ((DataGridView)dM).Rows[P_1.RowIndex].Cells[12];
			List<string> val = new List<string>();
			List<Color> val2 = new List<Color>();
			if (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].HasSignalNameError)
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cM());
				val2.Add(BM.tC);
			}
			if (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].HasBitOverlapError)
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cm());
				val2.Add(BM.tC);
			}
			if (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].HasBeyondEndOfFrameError)
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cN());
				val2.Add(BM.tC);
			}
			if (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].FrameDirection == CANFrameModel.Direction.Transmit && ((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].Source == null)
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cn());
				val2.Add(BM.tC);
			}
			if (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].InvalidUnits)
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cO());
				val2.Add(BM.tC);
			}
			if (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].HasZeroMultiplierWarning)
			{
				if (((Collection<CANSignalModel>)(object)di)[P_1.RowIndex].FrameDirection == CANFrameModel.Direction.Transmit)
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.co());
				}
				else
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cP());
				}
				val2.Add(Color.Orange);
			}
			if (val.Count == 0 || val2.Count != val.Count)
			{
				return;
			}
			if (val.Count > 1)
			{
				for (int i = 0; i < val.Count; i++)
				{
					val[i] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cp() + val[i];
				}
			}
			int num = ((Control)dM).Top + ((DataGridView)dM).ColumnHeadersHeight;
			for (int j = 0; j < P_1.RowIndex; j++)
			{
				num += ((DataGridView)dM).Rows[j].Height;
			}
			num -= ((DataGridView)dM).VerticalScrollingOffset;
			int num2 = ((Control)dM).Left;
			for (int k = 0; k < ((BaseCollection)((DataGridView)dM).Columns).Count; k++)
			{
				if (((DataGridViewBand)((DataGridView)dM).Columns[k]).Visible)
				{
					num2 += ((DataGridView)dM).Columns[k].Width;
				}
			}
			num2 -= ((DataGridView)dM).HorizontalScrollingOffset;
			BM.A(val, val2, (Control)(object)dM, ((Collection<CANSignalModel>)(object)di)[P_1.RowIndex], num2 + 5, num);
		}
	}

	private void C(object P_0, EventArgs P_1)
	{
		if (dL != null)
		{
			((Control)this).Invoke((System.Delegate)(object)dL, new object[2] { this, null });
		}
	}

	public void SelectSignal(CANSignalModel signalToSelect)
	{
		for (int i = 0; i < ((Collection<CANSignalModel>)(object)di).Count && i < ((DataGridView)dM).Rows.Count; i++)
		{
			if (((Collection<CANSignalModel>)(object)di)[i] != signalToSelect)
			{
				continue;
			}
			if (((DataGridView)dM).CurrentCell == null || ((DataGridView)dM).CurrentCell.RowIndex != i)
			{
				int num = 0;
				if (((DataGridView)dM).CurrentCell != null)
				{
					num = ((DataGridView)dM).CurrentCell.ColumnIndex;
				}
				dK = true;
				((DataGridView)dM).CurrentCell = ((DataGridView)dM).Rows[i].Cells[num];
				dK = false;
				((Control)dM).Refresh();
			}
			break;
		}
	}

	public CANSignalModel GetSelectedSignal()
	{
		if (((DataGridView)dM).CurrentCell != null && ((DataGridView)dM).CurrentCell.RowIndex < ((DataGridView)dM).Rows.Count && ((DataGridView)dM).CurrentCell.RowIndex < ((Collection<CANSignalModel>)(object)di).Count)
		{
			return ((Collection<CANSignalModel>)(object)di)[((DataGridView)dM).CurrentCell.RowIndex];
		}
		return null;
	}

	internal void A(bool P_0 = true)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ((Collection<CANSignalModel>)(object)di).Count; i++)
		{
			CANSignalModel cANSignalModel = ((Collection<CANSignalModel>)(object)di)[i];
			int num = ((cANSignalModel.FrameDirection == CANFrameModel.Direction.Transmit) ? 9 : 8);
			int num2 = ((cANSignalModel.FrameDirection == CANFrameModel.Direction.Transmit) ? 8 : 9);
			if (cANSignalModel.HasSignalNameError)
			{
				((DataGridView)dM).Rows[i].Cells[0].Style.BackColor = BM.tC;
			}
			else
			{
				((DataGridView)dM).Rows[i].Cells[0].Style.BackColor = BM.to;
			}
			if (cANSignalModel.HasBitOverlapError || cANSignalModel.HasBeyondEndOfFrameError)
			{
				((DataGridView)dM).Rows[i].Cells[2].Style.BackColor = BM.tC;
			}
			else
			{
				((DataGridView)dM).Rows[i].Cells[2].Style.BackColor = BM.to;
			}
			if (cANSignalModel.HasBitOverlapError || cANSignalModel.HasBeyondEndOfFrameError)
			{
				((DataGridView)dM).Rows[i].Cells[3].Style.BackColor = BM.tC;
			}
			else
			{
				((DataGridView)dM).Rows[i].Cells[3].Style.BackColor = BM.to;
			}
			if (cANSignalModel.HasZeroMultiplierWarning)
			{
				((DataGridView)dM).Rows[i].Cells[num].Style.BackColor = Color.Orange;
			}
			else
			{
				((DataGridView)dM).Rows[i].Cells[num].Style.BackColor = BM.to;
			}
			((DataGridView)dM).Rows[i].Cells[num2].Style.BackColor = BM.to;
			if (cANSignalModel.ValueOverflowedBitLength())
			{
				((DataGridView)dM).Rows[i].Cells[10].Style.BackColor = BM.tC;
			}
			else
			{
				((DataGridView)dM).Rows[i].Cells[10].Style.BackColor = BM.to;
			}
			if (cANSignalModel.FrameDirection == CANFrameModel.Direction.Transmit && cANSignalModel.Source == null)
			{
				((DataGridView)dM).Rows[i].Cells[5].Style.BackColor = BM.tC;
			}
			else
			{
				((DataGridView)dM).Rows[i].Cells[5].Style.BackColor = BM.to;
			}
			if (cANSignalModel.InvalidUnits)
			{
				((DataGridView)dM).Rows[i].Cells[7].Style.BackColor = BM.tC;
			}
			else
			{
				((DataGridView)dM).Rows[i].Cells[7].Style.BackColor = BM.to;
			}
		}
		if (P_0)
		{
			((Control)dM).Refresh();
		}
	}

	internal void A(List<CANSignalModel> P_0, CANFrameModel.Direction P_1)
	{
		DataGridViewCell currentCell = ((DataGridView)dM).CurrentCell;
		int num = ((currentCell != null) ? currentCell.RowIndex : 0);
		DataGridViewCell currentCell2 = ((DataGridView)dM).CurrentCell;
		int num2 = ((currentCell2 != null) ? currentCell2.ColumnIndex : 0);
		dJ = true;
		if (P_1 == CANFrameModel.Direction.Transmit)
		{
			((DataGridView)dM).Columns[10].HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cQ();
			((DataGridView)dM).Columns[6].HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cq();
			((DataGridViewBand)((DataGridView)dM).Columns[5]).Visible = true;
			((DataGridView)dM).Columns[8].HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cR();
			((DataGridViewColumn)dr).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cr();
			((DataGridView)dM).Columns[9].HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cS();
			((DataGridViewColumn)dS).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cs();
		}
		else
		{
			((DataGridView)dM).Columns[10].HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cT();
			((DataGridView)dM).Columns[6].HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ct();
			((DataGridViewBand)((DataGridView)dM).Columns[5]).Visible = false;
			((DataGridView)dM).Columns[8].HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cs();
			((DataGridViewColumn)dr).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cs();
			((DataGridView)dM).Columns[9].HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cr();
			((DataGridViewColumn)dS).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cr();
		}
		if (P_0 == null)
		{
			((Collection<CANSignalModel>)(object)di).Clear();
			dJ = false;
			dM.C();
			return;
		}
		di = new BindingList<CANSignalModel>((System.Collections.Generic.IList<CANSignalModel>)P_0);
		((DataGridView)dM).DataSource = di;
		for (int i = 0; i < ((Collection<CANSignalModel>)(object)di).Count && i < ((DataGridView)dM).Rows.Count; i++)
		{
			A(i);
		}
		if (num < ((DataGridView)dM).Rows.Count && num < ((Collection<CANSignalModel>)(object)di).Count && num2 < ((BaseCollection)((DataGridView)dM).Rows[num].Cells).Count && ((DataGridView)dM).Rows[num].Cells[num2].Visible)
		{
			((DataGridView)dM).CurrentCell = ((DataGridView)dM).Rows[num].Cells[num2];
		}
		dJ = false;
		((Control)dM).Refresh();
		dM.C();
	}

	private void A(int P_0)
	{
		List<ValueAndDisplay> unitsListDataSource = ((Collection<CANSignalModel>)(object)di)[P_0].GetUnitsListDataSource();
		if (unitsListDataSource == null)
		{
			return;
		}
		DataGridViewCell obj = ((DataGridView)dM).Rows[P_0].Cells[7];
		DataGridViewComboBoxCell val = (DataGridViewComboBoxCell)(object)((obj is DataGridViewComboBoxCell) ? obj : null);
		if (val != null)
		{
			val.DataSource = unitsListDataSource;
			((DataGridViewCell)val).ValueType = typeof(int);
			val.DisplayMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cJ();
			val.ValueMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
			if (unitsListDataSource.Count == 1)
			{
				((DataGridViewCell)val).Value = unitsListDataSource[0].Value;
			}
		}
	}

	private void B()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).BackColor = BM.tg;
		((Control)this).ForeColor = BM.te;
		((DataGridView)dM).BackgroundColor = BM.tg;
		((Control)dM).ForeColor = BM.te;
		((DataGridView)dM).ColumnHeadersDefaultCellStyle.BackColor = BM.tg;
		((DataGridView)dM).ColumnHeadersDefaultCellStyle.ForeColor = BM.te;
		((DataGridView)dM).DefaultCellStyle.BackColor = BM.to;
		((DataGridView)dM).DefaultCellStyle.ForeColor = BM.te;
		((DataGridViewBand)dQ).DefaultCellStyle.Font = new Font(((Control)this).Font, (FontStyle)4);
		((DataGridViewBand)dp).DefaultCellStyle.BackColor = BM.to;
		((DataGridViewBand)dp).DefaultCellStyle.ForeColor = BM.te;
		dp.FlatStyle = (FlatStyle)0;
		((DataGridViewBand)dR).DefaultCellStyle.BackColor = BM.to;
		((DataGridViewBand)dR).DefaultCellStyle.ForeColor = BM.te;
		dR.FlatStyle = (FlatStyle)0;
		((DataGridViewBand)dO).DefaultCellStyle.BackColor = BM.to;
		((DataGridViewBand)dO).DefaultCellStyle.ForeColor = BM.te;
		dO.FlatStyle = (FlatStyle)0;
		((DataGridView)dM).BorderStyle = (BorderStyle)0;
	}

	public void UpdateRawValue(long val)
	{
		for (int i = 0; i < ((Collection<CANSignalModel>)(object)di).Count; i++)
		{
			((Collection<CANSignalModel>)(object)di)[i].RawValue = val.ToString();
		}
		((Control)dM).Invalidate();
		A(false);
	}

	public bool IsFocused()
	{
		return ((Control)dM).Focused;
	}

	private bool b()
	{
		if (((DataGridView)dM).CurrentCell != null && (((DataGridView)dM).CurrentCell.ColumnIndex == 2 || ((DataGridView)dM).CurrentCell.ColumnIndex == 3 || ((DataGridView)dM).CurrentCell.ColumnIndex == 7 || ((DataGridView)dM).CurrentCell.ColumnIndex == 8 || ((DataGridView)dM).CurrentCell.ColumnIndex == 9))
		{
			return true;
		}
		return false;
	}

	internal bool A(KeyEventArgs P_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		if (!b())
		{
			return false;
		}
		int num = 0;
		object value = ((DataGridView)dM).CurrentCell.Value;
		float num2;
		if ((P_0.Control && (int)P_0.KeyCode == 33) || (int)P_0.KeyData == 190)
		{
			num2 = bS.b(num);
		}
		else if ((int)P_0.KeyData == 33 || (int)P_0.KeyData == 222)
		{
			num2 = bS.C(num);
		}
		else if ((P_0.Shift && (int)P_0.KeyCode == 33) || (int)P_0.KeyData == 221)
		{
			num2 = bS.c(num);
		}
		else if ((P_0.Control && (int)P_0.KeyCode == 34) || (int)P_0.KeyData == 188)
		{
			num2 = -bS.b(num);
		}
		else if ((int)P_0.KeyData == 34 || (int)P_0.KeyData == 186)
		{
			num2 = -bS.C(num);
		}
		else
		{
			if ((!P_0.Shift || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 219)
			{
				return false;
			}
			num2 = -bS.c(num);
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
		((DataGridView)dM).CurrentCell.Value = obj;
		((Control)this).Invoke((System.Delegate)(object)dk, new object[2]
		{
			this,
			Enumerable.ToList<CANSignalModel>((System.Collections.Generic.IEnumerable<CANSignalModel>)di)
		});
		P_0.Handled = true;
		P_0.SuppressKeyPress = true;
		return true;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && dl != null)
		{
			((System.IDisposable)dl).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void C()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		dl = (IContainer)new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		dN = new ThemedButton();
		dm = new BindingSource(dl);
		dM = new DataGridViewWithThemedScrollBars();
		dn = new DataGridViewTextBoxColumn();
		dO = new DataGridViewComboBoxColumn();
		@do = new DataGridViewTextBoxColumn();
		dP = new DataGridViewTextBoxColumn();
		dp = new DataGridViewComboBoxColumn();
		dQ = new DataGridViewButtonColumn();
		dq = new DataGridViewTextBoxColumn();
		dR = new DataGridViewComboBoxColumn();
		dr = new DataGridViewTextBoxColumn();
		dS = new DataGridViewTextBoxColumn();
		ds = new DataGridViewTextBoxColumn();
		dT = new DataGridViewButtonColumn();
		dt = new DataGridViewButtonColumn();
		((ISupportInitialize)dm).BeginInit();
		((ISupportInitialize)dM).BeginInit();
		((Control)this).SuspendLayout();
		((Control)dN).Location = new Point(5, 0);
		((Control)dN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cU();
		((Control)dN).Size = new Size(100, 25);
		((Control)dN).TabIndex = 0;
		((Control)dN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cu();
		dm.DataSource = typeof(CANSignalModel);
		((DataGridView)dM).AllowUserToAddRows = false;
		((DataGridView)dM).AllowUserToDeleteRows = false;
		((DataGridView)dM).AllowUserToResizeRows = false;
		((DataGridView)dM).AutoGenerateColumns = false;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dM).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dM).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dM).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[13]
		{
			(DataGridViewColumn)dn,
			(DataGridViewColumn)dO,
			(DataGridViewColumn)@do,
			(DataGridViewColumn)dP,
			(DataGridViewColumn)dp,
			(DataGridViewColumn)dQ,
			(DataGridViewColumn)dq,
			(DataGridViewColumn)dR,
			(DataGridViewColumn)dr,
			(DataGridViewColumn)dS,
			(DataGridViewColumn)ds,
			(DataGridViewColumn)dT,
			(DataGridViewColumn)dt
		});
		((DataGridView)dM).DataSource = dm;
		((Control)dM).Location = new Point(0, 30);
		((Control)dM).Margin = new Padding(2);
		((DataGridView)dM).MultiSelect = false;
		((Control)dM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cV();
		((DataGridView)dM).RowHeadersVisible = false;
		((DataGridView)dM).ScrollBars = (ScrollBars)3;
		((DataGridView)dM).ShowCellToolTips = true;
		((Control)dM).Size = new Size(930, 180);
		((Control)dM).TabIndex = 1;
		((DataGridViewColumn)dn).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cv();
		((DataGridViewColumn)dn).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cW();
		((DataGridViewColumn)dn).MinimumWidth = 40;
		((DataGridViewColumn)dn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cw();
		((DataGridViewColumn)dn).Width = 60;
		((DataGridViewColumn)dO).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cK();
		((DataGridViewColumn)dO).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cK();
		((DataGridViewColumn)dO).MinimumWidth = 50;
		((DataGridViewColumn)dO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cX();
		((DataGridViewBand)dO).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dO).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dO).Width = 150;
		((DataGridViewColumn)@do).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cx();
		((DataGridViewColumn)@do).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cY();
		((DataGridViewColumn)@do).MinimumWidth = 30;
		((DataGridViewColumn)@do).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cy();
		((DataGridViewColumn)@do).Width = 40;
		((DataGridViewColumn)dP).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cZ();
		((DataGridViewColumn)dP).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cz();
		((DataGridViewColumn)dP).MinimumWidth = 30;
		((DataGridViewColumn)dP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DA();
		((DataGridViewColumn)dP).Width = 50;
		((DataGridViewColumn)dp).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ci();
		((DataGridViewColumn)dp).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ci();
		((DataGridViewColumn)dp).MinimumWidth = 50;
		((DataGridViewColumn)dp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Da();
		((DataGridViewBand)dp).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dp).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dp).Width = 80;
		((DataGridViewColumn)dQ).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DB();
		((DataGridViewColumn)dQ).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Db();
		((DataGridViewColumn)dQ).MinimumWidth = 40;
		((DataGridViewColumn)dQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DC();
		((DataGridViewBand)dQ).ReadOnly = true;
		((DataGridViewColumn)dq).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dc();
		((DataGridViewColumn)dq).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DD();
		((DataGridViewColumn)dq).MinimumWidth = 50;
		((DataGridViewColumn)dq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dd();
		((DataGridViewBand)dq).ReadOnly = true;
		((DataGridViewColumn)dq).Width = 70;
		((DataGridViewColumn)dR).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ck();
		dR.DropDownWidth = 220;
		((DataGridViewColumn)dR).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ck();
		((DataGridViewColumn)dR).MinimumWidth = 40;
		((DataGridViewColumn)dR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DE();
		((DataGridViewColumn)dR).Width = 120;
		((DataGridViewColumn)dr).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cs();
		((DataGridViewColumn)dr).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cs();
		((DataGridViewColumn)dr).MinimumWidth = 40;
		((DataGridViewColumn)dr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.De();
		((DataGridViewColumn)dr).Width = 65;
		((DataGridViewColumn)dS).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cr();
		((DataGridViewColumn)dS).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cr();
		((DataGridViewColumn)dS).MinimumWidth = 40;
		((DataGridViewColumn)dS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DF();
		((DataGridViewColumn)dS).Width = 50;
		((DataGridViewColumn)ds).DataPropertyName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
		((DataGridViewColumn)ds).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
		((DataGridViewColumn)ds).MinimumWidth = 50;
		((DataGridViewColumn)ds).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Df();
		((DataGridViewBand)ds).ReadOnly = true;
		((DataGridViewColumn)ds).Width = 70;
		((DataGridViewColumn)dT).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
		((DataGridViewColumn)dT).MinimumWidth = 25;
		((DataGridViewColumn)dT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dg();
		((DataGridViewBand)dT).ReadOnly = true;
		((DataGridViewBand)dT).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dT).Width = 25;
		((DataGridViewColumn)dt).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
		((DataGridViewColumn)dt).MinimumWidth = 25;
		((DataGridViewColumn)dt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DH();
		((DataGridViewBand)dt).ReadOnly = true;
		((DataGridViewBand)dt).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dt).Width = 25;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)dN);
		((Control)this).Controls.Add((Control)(object)dM);
		((Control)this).Margin = new Padding(2);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dh();
		((Control)this).Size = new Size(935, 220);
		((ISupportInitialize)dm).EndInit();
		((ISupportInitialize)dM).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[CompilerGenerated]
	private void b(object? o, DataGridViewCellEventArgs P_1)
	{
		((DataGridView)dM).ShowCellToolTips = true;
	}

	[CompilerGenerated]
	private void C(object? o, DataGridViewCellEventArgs P_1)
	{
		((DataGridView)dM).ShowCellToolTips = false;
	}
}
