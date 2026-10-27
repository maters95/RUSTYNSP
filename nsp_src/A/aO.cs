using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;
using c;

namespace a;

internal class aO : Panel
{
	private SpecialObject JE;

	private Framework Je;

	private DataGridView JF;

	private DataGridView Jf;

	private ThemedButton JG;

	private List<aN> Jg = new List<aN>();

	private List<an> JH = new List<an>();

	private List<SettingOrSpecialObject> Jh = new List<SettingOrSpecialObject>();

	private SettingOrSpecialObject JI;

	private ContextMenuStrip Ji = new ContextMenuStrip();

	private const int JJ = 200;

	private const int Jj = 250;

	internal const int JK = 20;

	private int Jk = -1;

	private int JL = -1;

	private Label Jl;

	private int JM = -1;

	private int Jm;

	private int JN = -1;

	private Timer Jn = new Timer();

	private static List<int> JO = new List<int>();

	private int Jo = -1;

	private int JP = -1;

	private const string Jp = "Duplicate";

	private const string JQ = "Insert New Above";

	private const string Jq = "Delete";

	internal aO(SpecialObject P_0, Framework P_1, Rectangle P_2)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gm();
		((Panel)this).BorderStyle = (BorderStyle)0;
		JE = P_0;
		Je = P_1;
		A(P_2);
		A();
		D();
		JF.CellPainting += new DataGridViewCellPaintingEventHandler(A);
		JF.CellMouseDown += new DataGridViewCellMouseEventHandler(A);
		((Control)JF).MouseDown += new MouseEventHandler(a);
		((Control)JF).MouseMove += new MouseEventHandler(B);
		((Control)JF).MouseUp += new MouseEventHandler(b);
		JF.Scroll += new ScrollEventHandler(A);
		((Control)JF).KeyDown += new KeyEventHandler(A);
		JF.ColumnWidthChanged += new DataGridViewColumnEventHandler(A);
		JF.RowPostPaint += new DataGridViewRowPostPaintEventHandler(A);
		((Control)JG).MouseClick += new MouseEventHandler(A);
		Jf.CellPainting += new DataGridViewCellPaintingEventHandler(a);
		Jf.SelectionChanged += new EventHandler(B);
		d();
		B();
		A((object)null, (EventArgs)null);
	}

	protected override void Dispose(bool disposing)
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		JF.CellPainting -= new DataGridViewCellPaintingEventHandler(A);
		JF.CellMouseDown -= new DataGridViewCellMouseEventHandler(A);
		((Control)JF).MouseDown -= new MouseEventHandler(a);
		((Control)JF).MouseMove -= new MouseEventHandler(B);
		((Control)JF).MouseUp -= new MouseEventHandler(b);
		JF.Scroll -= new ScrollEventHandler(A);
		((Control)JF).KeyDown -= new KeyEventHandler(A);
		JF.ColumnWidthChanged -= new DataGridViewColumnEventHandler(A);
		JF.RowPostPaint -= new DataGridViewRowPostPaintEventHandler(A);
		JF.Columns.Clear();
		JF.Rows.Clear();
		((Control)JG).MouseClick -= new MouseEventHandler(A);
		Jf.CellPainting -= new DataGridViewCellPaintingEventHandler(a);
		Jf.SelectionChanged -= new EventHandler(B);
		Jn.Elapsed -= new ElapsedEventHandler(A);
		((Component)Jn).Dispose();
		Jf.Rows.Clear();
		Jf.Columns.Clear();
		Jg.Clear();
		JO.Clear();
		JH.Clear();
		((Component)Ji).Dispose();
		((Control)this).Dispose(disposing);
	}

	private void A()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val = item;
			if (val is DataGridView)
			{
				Control obj = ((val is DataGridView) ? val : null);
				((DataGridView)obj).ReadOnly = true;
				((DataGridView)obj).SelectionMode = (DataGridViewSelectionMode)1;
				((DataGridView)obj).MultiSelect = false;
				((DataGridView)obj).BorderStyle = (BorderStyle)0;
				((DataGridView)obj).AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)1;
				((DataGridView)obj).AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)0;
				obj.ForeColor = BM.te;
				((DataGridView)obj).BackgroundColor = BM.ti;
				((DataGridView)obj).EnableHeadersVisualStyles = false;
				((DataGridView)obj).AllowUserToOrderColumns = false;
				((DataGridView)obj).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)1;
				((DataGridView)obj).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				((DataGridView)obj).ColumnHeadersDefaultCellStyle.BackColor = BM.ti;
				((DataGridView)obj).ColumnHeadersDefaultCellStyle.ForeColor = BM.te;
				((DataGridView)obj).ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)64;
				((DataGridView)obj).ColumnHeadersDefaultCellStyle.WrapMode = (DataGridViewTriState)1;
				((DataGridView)obj).RowHeadersVisible = false;
				((DataGridView)obj).AllowUserToAddRows = false;
				((DataGridView)obj).AllowUserToDeleteRows = false;
				((DataGridView)obj).AllowUserToResizeRows = false;
				((DataGridView)obj).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
				((DataGridView)obj).RowHeadersDefaultCellStyle.BackColor = JF.BackgroundColor;
				((DataGridView)obj).RowHeadersDefaultCellStyle.ForeColor = BM.te;
				((DataGridView)obj).RowHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)64;
				((DataGridView)obj).RowsDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				((DataGridView)obj).DefaultCellStyle.BackColor = BM.td;
				((DataGridView)obj).DefaultCellStyle.ForeColor = BM.te;
				((DataGridView)obj).DefaultCellStyle.SelectionForeColor = BM.tK;
				((DataGridView)obj).DefaultCellStyle.SelectionBackColor = BM.tJ;
			}
			else if (!(val is ThemedButton))
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GN());
			}
		}
	}

	private Image A(am P_0, int P_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		int num = 20;
		Bitmap val = new Bitmap(P_1 - 1, P_1 - 1, (PixelFormat)137224);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			SolidBrush val3 = new SolidBrush(BM.td);
			try
			{
				val2.FillRectangle((Brush)(object)val3, new Rectangle(0, 0, P_1 - 1, num * 2));
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
		if (P_0.iX == aL.iu && P_0.iY == CH.BaF && P_0.iZ is cW)
		{
			P_0.iz = ((P_0.iz != al.iv) ? al.iv : al.iV);
			return (Image)(object)(P_0.iZ as cW).A(P_0.iz);
		}
		return (Image)(object)val;
	}

	private void A(Rectangle P_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		new ComponentResourceManager(typeof(aY));
		JF = new DataGridView();
		Jf = new DataGridView();
		JG = new ThemedButton();
		((Control)this).SuspendLayout();
		((ISupportInitialize)JF).BeginInit();
		((ISupportInitialize)Jf).BeginInit();
		if (JE.b().ExtraSummaryObjectId > 0)
		{
			int num = 30;
			Jf.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
			((Control)Jf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gn();
			Jf.ShowCellToolTips = false;
			((Control)Jf).Size = new Size(((Rectangle)(ref P_0)).Width, num);
			((Control)Jf).TabIndex = 11;
			((Control)Jf).Anchor = (AnchorStyles)12;
		}
		JF.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((Control)JF).Location = new Point(0, 0);
		((Control)JF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GO();
		JF.ShowCellToolTips = false;
		((Control)JF).TabIndex = 11;
		JF.ColumnHeadersHeight = 50;
		JF.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		((Control)JF).Anchor = (AnchorStyles)13;
		JF.GridColor = Color.LightGray;
		((Button)JG).DialogResult = (DialogResult)1;
		((Control)JG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Go();
		((Control)JG).Size = new Size(80, 23);
		((Control)JG).TabIndex = 3;
		((Control)JG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GP();
		((ButtonBase)JG).UseCompatibleTextRendering = true;
		((ButtonBase)JG).UseVisualStyleBackColor = true;
		((Control)JG).BringToFront();
		((Control)this).ClientSize = new Size(((Rectangle)(ref P_0)).Width, ((Rectangle)(ref P_0)).Height);
		((Control)this).Controls.Add((Control)(object)JF);
		((Control)this).Controls.Add((Control)(object)JG);
		if (JE.b().ExtraSummaryObjectId > 0)
		{
			((Control)this).Controls.Add((Control)(object)Jf);
		}
		((ISupportInitialize)JF).EndInit();
		((ISupportInitialize)Jf).EndInit();
		C();
		((Control)this).ResumeLayout(true);
	}

	private void a()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		Jn.Interval = 250.0;
		Jn.SynchronizingObject = (ISynchronizeInvoke)(object)this;
		Jn.Elapsed += new ElapsedEventHandler(A);
		Jn.AutoReset = true;
		Jn.Enabled = true;
		Jn.Start();
	}

	private void A(object P_0, ElapsedEventArgs P_1)
	{
		int num = -1;
		if (JH.Count == 0)
		{
			return;
		}
		for (int i = 0; i < Jg.Count; i++)
		{
			if (JH[0].Jd[i].iZ != null && JH[0].Jd[i].iZ is cW)
			{
				num = i;
			}
		}
		if (num == -1)
		{
			return;
		}
		for (int j = 0; j < JH.Count; j++)
		{
			if (JH[j].Jd[num].JA)
			{
				A(j, aL.iu);
			}
		}
	}

	internal void B()
	{
		try
		{
			_ = Jg.Count;
			JF.Rows.Clear();
			e();
			b();
			C();
		}
		catch
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gp());
		}
		if (!Jn.Enabled)
		{
			a();
		}
	}

	private void b()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		JF.Rows.Clear();
		int num = 1;
		for (int i = 0; i < JH.Count; i++)
		{
			if (!JH[i].JD)
			{
				continue;
			}
			DataGridViewRow val = new DataGridViewRow();
			for (int j = 0; j < Jg.Count; j++)
			{
				DataGridViewCell val2;
				switch (Jg[j].B())
				{
				case aL.iT:
				case aL.it:
				case aL.iU:
					val2 = (DataGridViewCell)new DataGridViewTextBoxCell();
					val2.Value = JH[i].Jd[j].iy;
					break;
				case aL.iu:
					val2 = (DataGridViewCell)new DataGridViewImageCell();
					val2.Value = A(JH[i].Jd[j], Jg[j].a());
					break;
				default:
					val2 = (DataGridViewCell)new DataGridViewTextBoxCell();
					if (j == 0)
					{
						JH[i].Jd[j].ix = num++;
						val2.Value = JH[i].Jd[j].ix.ToString();
						val2.Style.Alignment = (DataGridViewContentAlignment)32;
					}
					else
					{
						val2.Value = JH[i].Jd[j].iy;
					}
					break;
				}
				val.Cells.Add(val2);
			}
			JF.Rows.Add(val);
		}
		if (JI != null)
		{
			E();
		}
		if (Jo >= 0 && Jo < JF.RowCount)
		{
			JF.FirstDisplayedScrollingRowIndex = Jo;
		}
		JF.ColumnWidthChanged -= new DataGridViewColumnEventHandler(A);
		c();
		JF.ColumnWidthChanged += new DataGridViewColumnEventHandler(A);
	}

	private void A(int P_0, aL P_1)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		int num = -1;
		for (int i = 0; i < JH.Count; i++)
		{
			if (!JH[i].JD)
			{
				continue;
			}
			num++;
			if (i != P_0)
			{
				continue;
			}
			for (int j = 0; j < Jg.Count; j++)
			{
				if (Jg[j].B() == P_1 && Jg[j].B() == aL.iu)
				{
					DataGridViewCell val = (DataGridViewCell)new DataGridViewImageCell();
					val.Value = A(JH[i].Jd[j], Jg[j].a());
					JF.Rows[num].Cells[j] = val;
					JF.InvalidateRow(num);
				}
			}
		}
	}

	private void C()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		((Control)JF).Height = JF.ColumnHeadersHeight + ((JF.RowCount > 0) ? (JF.Rows[0].Height * JF.RowCount) : 0);
		((Control)JG).Location = new Point(0, ((Control)JF).Bottom + 5);
		((Control)JG).BringToFront();
		((Control)this).Height = ((Control)JG).Bottom + 5;
		if (Jf != null)
		{
			Point location = default(Point);
			((Point)(ref location))._002Ector(0, ((Control)this).Height);
			((Control)this).Height = ((Control)this).Height + ((Control)Jf).Height;
			((Control)Jf).Location = location;
		}
		JF.ClearSelection();
	}

	private void c()
	{
		for (int i = 0; i < JF.ColumnCount; i++)
		{
			JF.Columns[i].Width = JO[i];
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		for (int i = 0; i < JF.ColumnCount; i++)
		{
			if (i < JO.Count)
			{
				JO[i] = JF.Columns[i].Width;
			}
			else
			{
				JO.Add(JF.Columns[i].Width);
			}
		}
		if (((Control)this).Parent != null && ((Control)this).Parent.Parent != null && ((Control)this).Parent.Parent.Parent != null)
		{
			((Control)this).Width = Math.Max(((Control)this).Parent.Parent.Parent.Width - 20, Enumerable.Sum((System.Collections.Generic.IEnumerable<int>)JO) + 100);
		}
		else
		{
			((Control)this).Width = Enumerable.Sum((System.Collections.Generic.IEnumerable<int>)JO) + 100;
		}
		if (((Control)this).Parent != null && ((Control)this).Parent is aF)
		{
			((Control)this).Parent.Width = ((Control)this).Width;
			if (((Control)this).Parent.Parent != null)
			{
				((Control)this).Parent.Parent.Width = ((Control)this).Parent.Width + 10;
			}
		}
		((Control)JF).Width = ((Control)this).Width;
		E();
		((Control)this).Refresh();
	}

	private void D()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		((Component)Ji).Dispose();
		Ji = new ContextMenuStrip();
		((ToolStrip)Ji).BackColor = BM.tG;
		((ToolStrip)Ji).ForeColor = BM.te;
		ToolStripMenuItem val = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GQ(), (Image)null, new EventHandler(a));
		ToolStripMenuItem val2 = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gq(), (Image)null, new EventHandler(a));
		ToolStripMenuItem val3 = new ToolStripMenuItem(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GR(), (Image)null, new EventHandler(a));
		((ToolStrip)Ji).Items.Add((ToolStripItem)(object)val);
		((ToolStrip)Ji).Items.Add((ToolStripItem)(object)val2);
		((ToolStrip)Ji).Items.Add((ToolStripItem)(object)val3);
		((Control)JF).ContextMenuStrip = Ji;
	}

	private aL A(Setting P_0, int P_1)
	{
		if (P_0.c() != 0)
		{
			return aL.iT;
		}
		if (P_0.v())
		{
			return aL.it;
		}
		if (P_0 is Dn)
		{
			return aL.iu;
		}
		if (P_1 != 0)
		{
			return aL.iU;
		}
		return aL.@is;
	}

	private void d()
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		Jg.Clear();
		if (JE.b().Reorderable)
		{
			aN aN2 = new aN(JE.b().ReorderableText, 40, aL.@is);
			Jg.Add(aN2);
		}
		SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)JE).a()[0];
		if (settingOrSpecialObject is SpecialObject)
		{
			SpecialObject specialObject = (SpecialObject)settingOrSpecialObject;
			int num = 0;
			for (int i = 0; i < specialObject.B().CurrentUIListSettingsIdsAndIndents.Count; i++)
			{
				Setting setting = Je.A(specialObject.B().CurrentUIListSettingsIdsAndIndents[i].DataId);
				if (setting != null)
				{
					string text = ((SettingOrSpecialObject)setting).A(bz.aYv);
					if (string.IsNullOrEmpty(text))
					{
						text = ((SettingOrSpecialObject)setting).A(bz.aYu);
					}
					string text2 = (string.IsNullOrEmpty(text) ? ((SettingOrSpecialObject)setting).A(bz.aYt) : text);
					aL aL2 = A(setting, num);
					if (aL2 == aL.it)
					{
						num = 1;
					}
					Jg.Add(new aN(text2, 40, aL2));
				}
			}
		}
		int num2 = 0;
		bool flag = false;
		if (Enumerable.Count<int>((System.Collections.Generic.IEnumerable<int>)JO) == 0)
		{
			flag = true;
		}
		Enumerator<aN> enumerator = Jg.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				aN current = enumerator.Current;
				if (flag)
				{
					switch (current.B())
					{
					case aL.iT:
					case aL.it:
						current.A(120);
						break;
					case aL.iu:
						current.A(430);
						break;
					case aL.iU:
						current.A(70);
						break;
					default:
						current.A(40);
						break;
					}
					JO.Add(current.a());
				}
				else
				{
					current.A(JO[num2++]);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		for (int j = 0; j < Jg.Count; j++)
		{
			JF.Columns.Add(Jg[j].A(), Jg[j].A());
			((DataGridViewCell)JF.Columns[j].HeaderCell).Style.Alignment = (DataGridViewContentAlignment)32;
			JF.Columns[j].SortMode = (DataGridViewColumnSortMode)0;
			JF.Columns[j].Width = JO[j];
			JF.Columns[j].MinimumWidth = 20;
			if (Jg[j].B() == aL.iu)
			{
				((DataGridViewBand)JF.Columns[j]).Resizable = (DataGridViewTriState)2;
			}
		}
	}

	private void E()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		if (JI == null)
		{
			return;
		}
		List<Dl> val = (JI as DM).a();
		int[] array = new int[Je.awq.Count];
		for (int i = 0; i < Je.awq.Count; i++)
		{
			if (val[i].a() != null)
			{
				array[i] = val[i].a().ax();
			}
		}
		cW cW = new cW(Je.awq.Count, array, 2147483647, cW.BNt, 20);
		DataGridViewCell val2 = (DataGridViewCell)new DataGridViewTextBoxCell();
		DataGridViewCell val3 = (DataGridViewCell)new DataGridViewImageCell();
		val2.Value = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gr();
		val3.Value = cW.A(al.iV);
		Jf.Rows.Clear();
		Jf.Columns.Clear();
		Jf.Columns.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gr());
		Jf.Columns.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gs(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GT());
		foreach (DataGridViewColumn item in (BaseCollection)Jf.Columns)
		{
			((DataGridViewBand)item).Resizable = (DataGridViewTriState)2;
		}
		int num = 0;
		for (int j = 0; j < JO.Count - 1; j++)
		{
			num += JO[j];
		}
		Jf.Columns[0].Width = num;
		Jf.Columns[1].Width = Jg[Jg.Count - 1].a();
		Jf.ColumnHeadersVisible = false;
		DataGridViewRow val4 = new DataGridViewRow();
		val4.Cells.Add(val2);
		val4.Cells.Add(val3);
		Jf.Rows.Add(val4);
		((Control)Jf).Refresh();
	}

	private void e()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		JH.Clear();
		bool flag = false;
		if (Jh.Count == 0)
		{
			flag = true;
		}
		if (flag && JE.b().ExtraSummaryObjectId > 0)
		{
			JI = Je.a(JE.b().ExtraSummaryObjectId);
		}
		Enumerator<SettingOrSpecialObject> enumerator = ((SettingOrSpecialObject)JE).a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				an an2 = new an();
				int num = 0;
				int num2 = 0;
				an2.Jd = new List<am>();
				am am2 = new am
				{
					Ja = 0,
					iX = aL.@is
				};
				an2.Jd.Add(am2);
				SpecialObject specialObject = (SpecialObject)current;
				if (specialObject.B().RowIncludeSetting != 0)
				{
					Setting setting = Je.A(specialObject.B().RowIncludeSetting);
					if (setting != null)
					{
						an2.JD = setting.ax() == 1;
						an2.Jc = specialObject.B();
						if (flag && an2.Jc.RowObjectId != 0)
						{
							SettingOrSpecialObject settingOrSpecialObject = Je.a(an2.Jc.RowObjectId);
							Jh.Add(settingOrSpecialObject);
						}
					}
				}
				for (int i = 1; i <= specialObject.B().CurrentUIListSettingsIdsAndIndents.Count; i++)
				{
					int dataId = specialObject.B().CurrentUIListSettingsIdsAndIndents[i - 1].DataId;
					SettingOrSpecialObject settingOrSpecialObject2 = Je.A(dataId);
					am am3 = new am();
					am3.Ja = dataId;
					am3.iY = PortFunction.a((uint)(settingOrSpecialObject2 as Setting).ax());
					am3.iX = Jg[i].B();
					am3.JA = false;
					if (am3.iX == aL.@is)
					{
						aL iX;
						Jg[i].A(iX = aL.iU);
						am3.iX = iX;
					}
					switch (am3.iX)
					{
					case aL.iT:
						am3.iy = (settingOrSpecialObject2 as Setting).ay();
						break;
					case aL.it:
					{
						int num3 = (settingOrSpecialObject2 as Setting).ax();
						Setting setting3 = Je.A(num3);
						if (setting3 != null)
						{
							am3.iy = ((SettingOrSpecialObject)setting3).A(false);
							num = setting3.aS();
							num2 = setting3.@as();
						}
						break;
					}
					case aL.@is:
					case aL.iU:
					{
						Setting setting2 = settingOrSpecialObject2 as Setting;
						if (((SettingOrSpecialObject)setting2).l())
						{
							am3.iy = bS.a(setting2.ax(), num, -1) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(num2, num, true, setting2.ax());
						}
						else
						{
							am3.iy = string.Empty;
						}
						break;
					}
					case aL.iu:
						am3.iY = PortFunction.a((uint)(settingOrSpecialObject2 as Setting).ax());
						if (am3.iY == CH.BaF)
						{
							DJ dJ = settingOrSpecialObject2.D() as DJ;
							cW cW = (cW)(am3.iZ = new cW(Je.awq.Count, dJ.C().ax(), dJ.B().ax(), dJ.b().ax(), Jg[i].a(), 20));
							am3.iz = al.iV;
							am3.JA = cW.A();
						}
						break;
					}
					an2.Jd.Add(am3);
				}
				JH.Add(an2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void A(int P_0)
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		for (int i = 0; i < JH.Count; i++)
		{
			if (JH[i].JD)
			{
				num++;
			}
		}
		if (P_0 < 0 || P_0 >= Jh.Count || P_0 >= num)
		{
			return;
		}
		Ck ck = BM.aM();
		ck?.a();
		Je.M();
		for (int j = P_0; j < JH.Count - 1; j++)
		{
			Jh[j].a(Jh[j + 1], true);
		}
		JH[num - 1].JD = false;
		Je.A(JH[num - 1].Jc.RowIncludeSetting)?.a(0, true);
		Enumerator<UIListSettingDataIdAndIndent> enumerator = JH[JH.Count - 1].Jc.CurrentUIListSettingsIdsAndIndents.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				UIListSettingDataIdAndIndent current = enumerator.Current;
				Je.A(current.DataId)?.I(true);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Je.A(true);
		ck?.B();
		a(P_0, num - 1);
		B();
	}

	private void A(int P_0, int P_1)
	{
		if (P_0 >= 0 && P_0 < Jh.Count && P_1 >= 0 && P_1 < Jh.Count)
		{
			Ck ck = BM.aM();
			ck?.a();
			Je.M();
			SettingOrSpecialObject settingOrSpecialObject = Jh[P_0];
			int num = A(true);
			if (num != -1)
			{
				Jh[num].a(settingOrSpecialObject, true);
				A(num, P_1, true);
			}
			Je.A(true);
			ck?.B();
			B();
		}
	}

	private void A(int P_0, int P_1, bool P_2 = false)
	{
		SettingOrSpecialObject.A(Je, Jh, P_0, P_1, !P_2);
		if (!P_2)
		{
			B();
		}
	}

	private int A(bool P_0 = false)
	{
		if (JH.Count > 0 && JH[JH.Count - 1].JD)
		{
			return -1;
		}
		Cursor current = Cursor.Current;
		Cursor.Current = Cursors.WaitCursor;
		int num = -1;
		Ck ck = BM.aM();
		if (!P_0)
		{
			ck?.a();
			Je.M();
		}
		for (int i = 0; i < JH.Count; i++)
		{
			if (JH[i].JD)
			{
				continue;
			}
			Setting setting = Je.A(JH[i].Jc.RowIncludeSetting);
			if (setting != null)
			{
				setting.a(1, true);
				BM.b(setting.A());
				JH[i].JD = false;
				if (Jh[i] != null)
				{
					Jh[i].h().A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gt(), true);
				}
			}
			num = i;
			break;
		}
		Cursor.Current = current;
		if (!P_0)
		{
			Je.A(true);
			ck?.B();
		}
		if (num != -1)
		{
			a(num, num);
		}
		return num;
	}

	private void a(int P_0, int P_1)
	{
		for (int i = Math.Min(P_0, P_1); i <= Math.Max(P_1, P_0); i++)
		{
			SettingOrSpecialObject.A(Jh[i]);
		}
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)P_1.Button == 1048576)
		{
			A(false);
		}
		JF.ClearSelection();
		((Control)JF).Focus();
	}

	private void A(object P_0, ScrollEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)P_1.ScrollOrientation == 1)
		{
			Jo = P_1.NewValue;
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		string text = ((ToolStripItem)(ToolStripMenuItem)P_0).Text;
		if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GQ()))
		{
			if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gq()))
			{
				if (text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GR() && JP != -1)
				{
					A(JP);
					JP = -1;
				}
			}
			else
			{
				int num = A(false);
				if (num != -1 && JP != -1)
				{
					A(num, JP, false);
					JP = -1;
				}
			}
		}
		else if (JP != -1)
		{
			A(JP, JP);
			JP = -1;
		}
		JF.ClearSelection();
	}

	private void A(object P_0, KeyEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		Keys keyCode = P_1.KeyCode;
		if ((int)keyCode <= 46)
		{
			if ((int)keyCode != 45)
			{
				if ((int)keyCode == 46 && JP != -1)
				{
					A(JP);
				}
				return;
			}
			int num = A(false);
			if (num != -1 && JP != -1)
			{
				A(num, JP, false);
			}
		}
		else if ((int)keyCode != 67)
		{
			if ((int)keyCode != 86)
			{
				return;
			}
			int jP = JP;
			if ((Control.ModifierKeys & 0x20000) == 131072 && JM != -1 && jP != -1 && JM < JF.RowCount)
			{
				A(JM, jP);
				if (jP < JM)
				{
					JM++;
				}
			}
		}
		else if ((Control.ModifierKeys & 0x20000) == 131072)
		{
			JM = JP;
		}
	}

	private void A(object P_0, DataGridViewCellPaintingEventArgs P_1)
	{
		if (P_1.RowIndex != -1 && P_1.ColumnIndex < Jg.Count - 1)
		{
			P_1.AdvancedBorderStyle.Right = (DataGridViewAdvancedCellBorderStyle)1;
		}
	}

	private void a(object P_0, DataGridViewCellPaintingEventArgs P_1)
	{
		if (P_1.RowIndex != -1)
		{
			int num = 0;
			if (P_0.Equals((object)Jf))
			{
				num = 2;
			}
			if (P_1.ColumnIndex < num - 1)
			{
				P_1.AdvancedBorderStyle.Right = (DataGridViewAdvancedCellBorderStyle)1;
			}
		}
	}

	private void A(object P_0, DataGridViewRowPostPaintEventArgs P_1)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		if (P_1.RowIndex == JL && JL != Jk)
		{
			_ = JF.RowHeadersWidth;
			Rectangle rowBounds;
			Rectangle val = default(Rectangle);
			if (JL < Jk)
			{
				rowBounds = P_1.RowBounds;
				int left = ((Rectangle)(ref rowBounds)).Left;
				rowBounds = P_1.RowBounds;
				((Rectangle)(ref val))._002Ector(left, ((Rectangle)(ref rowBounds)).Top, JF.Columns.GetColumnsWidth((DataGridViewElementStates)64), 2);
			}
			else
			{
				rowBounds = P_1.RowBounds;
				int left2 = ((Rectangle)(ref rowBounds)).Left;
				rowBounds = P_1.RowBounds;
				((Rectangle)(ref val))._002Ector(left2, ((Rectangle)(ref rowBounds)).Bottom - 2, JF.Columns.GetColumnsWidth((DataGridViewElementStates)64), 2);
			}
			Pen val2 = new Pen(Color.DodgerBlue, 3f);
			try
			{
				P_1.Graphics.DrawLine(val2, ((Rectangle)(ref val)).Left, ((Rectangle)(ref val)).Top, ((Rectangle)(ref val)).Right, ((Rectangle)(ref val)).Top);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
	}

	private void a(object P_0, MouseEventArgs P_1)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		((Control)Ji).Enabled = false;
		HitTestInfo val = JF.HitTest(P_1.X, P_1.Y);
		JP = val.RowIndex;
		if ((int)P_1.Button == 2097152 && (int)val.Type != 0)
		{
			if (JP >= 0 && JP < JF.RowCount)
			{
				((Control)Ji).Enabled = true;
				((ToolStripDropDown)Ji).Show((Control)(object)JF, new Point(P_1.X, P_1.Y));
			}
		}
		else
		{
			((ToolStripDropDown)Ji).Close();
		}
	}

	private void A(object P_0, DataGridViewCellMouseEventArgs P_1)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		if (P_1.ColumnIndex >= 0 && P_1.RowIndex >= 0 && (int)((MouseEventArgs)P_1).Button == 1048576 && JF.RowCount > 1)
		{
			Jk = P_1.RowIndex;
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (P_0 is DataGridView)
		{
			object obj = ((P_0 is DataGridView) ? P_0 : null);
			((DataGridView)obj).ClearSelection();
			((DataGridView)obj).CurrentCell = null;
		}
	}

	private void a(int P_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 < 0)
		{
			return;
		}
		List<TreeNode> val = BM.QQ.rL.A().a();
		TreeNode val2 = null;
		Enumerator<am> enumerator = JH[P_0].Jd.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				am current = enumerator.Current;
				if (current.Ja != 0)
				{
					val2 = BM.QQ.rL.A(val, new DataIdAndAttrId(current.Ja), true, false, false);
					if (val2 != null)
					{
						break;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (val2 != null)
		{
			BM.QQ.rL.A().A(val2);
		}
	}

	private void B(object P_0, MouseEventArgs P_1)
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		HitTestInfo val = JF.HitTest(P_1.X, P_1.Y);
		if (Jl == null && Jk != -1)
		{
			Jl = new Label();
			((Control)Jl).Width = 200;
			((Control)Jl).BackColor = BM.te;
			((Control)Jl).ForeColor = BM.td;
			((Control)Jl).Font = new Font(((Control)Jl).Font.FontFamily, 9.75f, (FontStyle)1);
			((Control)Jl).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GU() + JF[1, Jk].Value.ToString();
			((Control)Jl).Parent = (Control)(object)JF;
			((Control)Jl).Location = P_1.Location;
		}
		if ((int)P_1.Button != 1048576 || Jl == null)
		{
			return;
		}
		((Control)Jl).Location = P_1.Location;
		if ((int)val.Type != 0 && val.RowIndex != JL)
		{
			if (JL != -1)
			{
				JF.InvalidateRow(JL);
			}
			if (val.RowIndex != -1)
			{
				JF.InvalidateRow(val.RowIndex);
			}
			JL = val.RowIndex;
			((Control)JF).Refresh();
		}
	}

	private void b(object P_0, MouseEventArgs P_1)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		HitTestInfo val = JF.HitTest(P_1.X, P_1.Y);
		int tickCount = Environment.TickCount;
		if (tickCount - Jm < 300 && val.RowIndex >= 0 && JN == val.RowIndex && (int)P_1.Button == 1048576)
		{
			a(val.RowIndex);
			Jm = tickCount;
			if (Jl != null)
			{
				((Component)Jl).Dispose();
				Jl = null;
			}
			return;
		}
		Jm = tickCount;
		JN = val.RowIndex;
		if (Jl != null)
		{
			int num = val.RowIndex;
			if (num == -1)
			{
				if (P_1.Y < 0)
				{
					num = 0;
				}
				else if (P_1.Y > JF.Rows.Count * 20)
				{
					num = JF.Rows.Count - 1;
				}
			}
			if (num != -1 && Jk >= 0)
			{
				int num2 = num;
				if (num2 != -1 && Jk != -1 && num2 != Jk)
				{
					A(Jk, num2, false);
					JF.ClearSelection();
				}
			}
			((Component)Jl).Dispose();
			Jl = null;
		}
		Jk = -1;
		JL = -1;
	}
}
internal enum ao
{
	jC,
	jc,
	jD
}
