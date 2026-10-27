using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;

namespace NSP.UserInterface;

public class CANRawDataView : UserControl
{
	private IContainer Dq;

	private TableLayoutPanel DR;

	private Label Dr;

	private Label DS;

	private TableLayoutPanel Ds;

	private Label DT;

	private Label Dt;

	private Label DU;

	private Label Du;

	private Label DV;

	private Label Dv;

	private Label DW;

	private Label Dw;

	private ThemedTextBox DX;

	private ThemedTextBox Dx;

	private ThemedTextBox DY;

	private ThemedTextBox Dy;

	private ThemedTextBox DZ;

	private ThemedTextBox Dz;

	private ThemedTextBox dA;

	private ThemedTextBox da;

	public CANRawDataView()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		A();
		((Control)Dr).ForeColor = BM.tq;
		((Control)DS).ForeColor = BM.tq;
		((Control)Dw).ForeColor = BM.tq;
		((Control)DW).ForeColor = BM.tq;
		((Control)Dv).ForeColor = BM.tq;
		((Control)DV).ForeColor = BM.tq;
		((Control)Du).ForeColor = BM.tq;
		((Control)DU).ForeColor = BM.tq;
		((Control)Dt).ForeColor = BM.tq;
		((Control)DT).ForeColor = BM.tq;
		((Control)DX).ForeColor = BM.te;
		((Control)DX).BackColor = BM.to;
		((Control)Dx).ForeColor = BM.te;
		((Control)Dx).BackColor = BM.to;
		((Control)DY).ForeColor = BM.te;
		((Control)DY).BackColor = BM.to;
		((Control)Dy).ForeColor = BM.te;
		((Control)Dy).BackColor = BM.to;
		((Control)DZ).ForeColor = BM.te;
		((Control)DZ).BackColor = BM.to;
		((Control)Dz).ForeColor = BM.te;
		((Control)Dz).BackColor = BM.to;
		((Control)dA).ForeColor = BM.te;
		((Control)dA).BackColor = BM.to;
		((Control)da).ForeColor = BM.te;
		((Control)da).BackColor = BM.to;
	}

	public void EnableOrDisable(bool enable, uint length = 8u)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		Color te = BM.te;
		Color tq = BM.tq;
		if (enable)
		{
			((Control)Dr).ForeColor = te;
			((Control)DS).ForeColor = te;
			((Control)Dw).ForeColor = ((length >= 1) ? te : tq);
			((Control)DW).ForeColor = ((length >= 2) ? te : tq);
			((Control)Dv).ForeColor = ((length >= 3) ? te : tq);
			((Control)DV).ForeColor = ((length >= 4) ? te : tq);
			((Control)Du).ForeColor = ((length >= 5) ? te : tq);
			((Control)DU).ForeColor = ((length >= 6) ? te : tq);
			((Control)Dt).ForeColor = ((length >= 7) ? te : tq);
			((Control)DT).ForeColor = ((length >= 8) ? te : tq);
		}
		else
		{
			((Control)Dr).ForeColor = tq;
			((Control)DS).ForeColor = tq;
			((Control)Dw).ForeColor = tq;
			((Control)DW).ForeColor = tq;
			((Control)Dv).ForeColor = tq;
			((Control)DV).ForeColor = tq;
			((Control)Du).ForeColor = tq;
			((Control)DU).ForeColor = tq;
			((Control)Dt).ForeColor = tq;
			((Control)DT).ForeColor = tq;
		}
		((Control)DX).Enabled = length >= 1 && enable;
		((Control)Dx).Enabled = length >= 2 && enable;
		((Control)DY).Enabled = length >= 3 && enable;
		((Control)Dy).Enabled = length >= 4 && enable;
		((Control)DZ).Enabled = length >= 5 && enable;
		((Control)Dz).Enabled = length >= 6 && enable;
		((Control)dA).Enabled = length >= 7 && enable;
		((Control)da).Enabled = length >= 8 && enable;
	}

	public void UpdateValue(long val)
	{
		byte[] bytes = BitConverter.GetBytes(val);
		if (bytes.Length == 8)
		{
			((Control)DX).Text = bytes[0].ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
			((Control)Dx).Text = bytes[1].ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
			((Control)DY).Text = bytes[2].ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
			((Control)Dy).Text = bytes[3].ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
			((Control)DZ).Text = bytes[4].ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
			((Control)Dz).Text = bytes[5].ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
			((Control)dA).Text = bytes[6].ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
			((Control)da).Text = bytes[7].ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Dq != null)
		{
			((System.IDisposable)Dq).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
		DR = new TableLayoutPanel();
		DS = new Label();
		Ds = new TableLayoutPanel();
		DT = new Label();
		Dt = new Label();
		DU = new Label();
		Du = new Label();
		DV = new Label();
		Dv = new Label();
		DW = new Label();
		Dw = new Label();
		DX = new ThemedTextBox();
		Dx = new ThemedTextBox();
		DY = new ThemedTextBox();
		Dy = new ThemedTextBox();
		DZ = new ThemedTextBox();
		Dz = new ThemedTextBox();
		dA = new ThemedTextBox();
		da = new ThemedTextBox();
		Dr = new Label();
		((Control)DR).SuspendLayout();
		((Control)Ds).SuspendLayout();
		((Control)this).SuspendLayout();
		DR.ColumnCount = 2;
		DR.ColumnStyles.Add(new ColumnStyle((SizeType)1, 116f));
		DR.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		DR.Controls.Add((Control)(object)DS, 0, 0);
		DR.Controls.Add((Control)(object)Ds, 1, 0);
		DR.Controls.Add((Control)(object)Dr, 0, 1);
		((Control)DR).Dock = (DockStyle)5;
		((Control)DR).Location = new Point(0, 0);
		((Control)DR).Margin = new Padding(0);
		((Control)DR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CU();
		DR.RowCount = 2;
		DR.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		DR.RowStyles.Add(new RowStyle((SizeType)1, 44f));
		((Control)DR).Size = new Size(472, 96);
		((Control)DR).TabIndex = 0;
		((Control)DS).Dock = (DockStyle)5;
		((Control)DS).Location = new Point(4, 0);
		((Control)DS).Margin = new Padding(0);
		((Control)DS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cu();
		((Control)DS).Size = new Size(86, 52);
		((Control)DS).TabIndex = 2;
		((Control)DS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CV();
		DS.TextAlign = (ContentAlignment)32;
		Ds.ColumnCount = 8;
		Ds.ColumnStyles.Add(new ColumnStyle((SizeType)1, 55f));
		Ds.ColumnStyles.Add(new ColumnStyle((SizeType)1, 55f));
		Ds.ColumnStyles.Add(new ColumnStyle((SizeType)1, 55f));
		Ds.ColumnStyles.Add(new ColumnStyle((SizeType)1, 55f));
		Ds.ColumnStyles.Add(new ColumnStyle((SizeType)1, 55f));
		Ds.ColumnStyles.Add(new ColumnStyle((SizeType)1, 55f));
		Ds.ColumnStyles.Add(new ColumnStyle((SizeType)1, 55f));
		Ds.ColumnStyles.Add(new ColumnStyle((SizeType)1, 55f));
		Ds.Controls.Add((Control)(object)DT, 7, 0);
		Ds.Controls.Add((Control)(object)Dt, 6, 0);
		Ds.Controls.Add((Control)(object)DU, 5, 0);
		Ds.Controls.Add((Control)(object)Du, 4, 0);
		Ds.Controls.Add((Control)(object)DV, 3, 0);
		Ds.Controls.Add((Control)(object)Dv, 2, 0);
		Ds.Controls.Add((Control)(object)DW, 1, 0);
		Ds.Controls.Add((Control)(object)Dw, 0, 0);
		Ds.Controls.Add((Control)(object)DX, 0, 1);
		Ds.Controls.Add((Control)(object)Dx, 1, 1);
		Ds.Controls.Add((Control)(object)DY, 2, 1);
		Ds.Controls.Add((Control)(object)Dy, 3, 1);
		Ds.Controls.Add((Control)(object)DZ, 4, 1);
		Ds.Controls.Add((Control)(object)Dz, 5, 1);
		Ds.Controls.Add((Control)(object)dA, 6, 1);
		Ds.Controls.Add((Control)(object)da, 7, 1);
		((Control)Ds).Dock = (DockStyle)5;
		((Control)Ds).Location = new Point(94, 0);
		((Control)Ds).Margin = new Padding(0);
		((Control)Ds).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cv();
		Ds.RowCount = 2;
		DR.SetRowSpan((Control)(object)Ds, 2);
		Ds.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		Ds.RowStyles.Add(new RowStyle((SizeType)1, 44f));
		((Control)Ds).Size = new Size(378, 96);
		((Control)Ds).TabIndex = 1;
		((Control)DT).AutoSize = false;
		((Control)DT).Location = new Point(332, 0);
		((Control)DT).Margin = new Padding(0);
		((Control)DT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CW();
		((Control)DT).Size = new Size(39, 52);
		((Control)DT).TabIndex = 15;
		((Control)DT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cw();
		DT.TextAlign = (ContentAlignment)32;
		((Control)Dt).AutoSize = false;
		((Control)Dt).Location = new Point(285, 0);
		((Control)Dt).Margin = new Padding(0);
		((Control)Dt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CX();
		((Control)Dt).Size = new Size(39, 52);
		((Control)Dt).TabIndex = 14;
		((Control)Dt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cx();
		Dt.TextAlign = (ContentAlignment)32;
		((Control)DU).AutoSize = false;
		((Control)DU).Location = new Point(238, 0);
		((Control)DU).Margin = new Padding(0);
		((Control)DU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CY();
		((Control)DU).Size = new Size(39, 52);
		((Control)DU).TabIndex = 13;
		((Control)DU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cy();
		DU.TextAlign = (ContentAlignment)32;
		((Control)Du).AutoSize = false;
		((Control)Du).Location = new Point(191, 0);
		((Control)Du).Margin = new Padding(0);
		((Control)Du).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CZ();
		((Control)Du).Size = new Size(39, 52);
		((Control)Du).TabIndex = 12;
		((Control)Du).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cz();
		Du.TextAlign = (ContentAlignment)32;
		((Control)DV).AutoSize = false;
		((Control)DV).Location = new Point(144, 0);
		((Control)DV).Margin = new Padding(0);
		((Control)DV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cA();
		((Control)DV).Size = new Size(39, 52);
		((Control)DV).TabIndex = 11;
		((Control)DV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ca();
		DV.TextAlign = (ContentAlignment)32;
		((Control)Dv).AutoSize = false;
		((Control)Dv).Location = new Point(97, 0);
		((Control)Dv).Margin = new Padding(0);
		((Control)Dv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cB();
		((Control)Dv).Size = new Size(39, 52);
		((Control)Dv).TabIndex = 10;
		((Control)Dv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cb();
		Dv.TextAlign = (ContentAlignment)32;
		((Control)DW).AutoSize = false;
		((Control)DW).Location = new Point(50, 0);
		((Control)DW).Margin = new Padding(0);
		((Control)DW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cC();
		((Control)DW).Size = new Size(39, 52);
		((Control)DW).TabIndex = 9;
		((Control)DW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ();
		DW.TextAlign = (ContentAlignment)32;
		((Control)Dw).AutoSize = false;
		((Control)Dw).Location = new Point(3, 0);
		((Control)Dw).Margin = new Padding(0);
		((Control)Dw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cc();
		((Control)Dw).Size = new Size(39, 52);
		((Control)Dw).TabIndex = 8;
		((Control)Dw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn();
		Dw.TextAlign = (ContentAlignment)32;
		((Control)DX).Location = new Point(4, 57);
		((Control)DX).Margin = new Padding(0);
		((Control)DX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cD();
		((TextBoxBase)DX).ReadOnly = true;
		((Control)DX).Size = new Size(38, 29);
		((Control)DX).TabIndex = 0;
		((Control)DX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		((TextBox)DX).TextAlign = (HorizontalAlignment)2;
		((Control)Dx).Location = new Point(51, 57);
		((Control)Dx).Margin = new Padding(0);
		((Control)Dx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cd();
		((TextBoxBase)Dx).ReadOnly = true;
		((Control)Dx).Size = new Size(38, 29);
		((Control)Dx).TabIndex = 1;
		((Control)Dx).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		((TextBox)Dx).TextAlign = (HorizontalAlignment)2;
		((Control)DY).Location = new Point(98, 57);
		((Control)DY).Margin = new Padding(0);
		((Control)DY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cE();
		((TextBoxBase)DY).ReadOnly = true;
		((Control)DY).Size = new Size(38, 29);
		((Control)DY).TabIndex = 2;
		((Control)DY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		((TextBox)DY).TextAlign = (HorizontalAlignment)2;
		((Control)Dy).Location = new Point(145, 57);
		((Control)Dy).Margin = new Padding(0);
		((Control)Dy).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ce();
		((TextBoxBase)Dy).ReadOnly = true;
		((Control)Dy).Size = new Size(38, 29);
		((Control)Dy).TabIndex = 3;
		((Control)Dy).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		((TextBox)Dy).TextAlign = (HorizontalAlignment)2;
		((Control)DZ).Location = new Point(192, 57);
		((Control)DZ).Margin = new Padding(0);
		((Control)DZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cF();
		((TextBoxBase)DZ).ReadOnly = true;
		((Control)DZ).Size = new Size(38, 29);
		((Control)DZ).TabIndex = 4;
		((Control)DZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		((TextBox)DZ).TextAlign = (HorizontalAlignment)2;
		((Control)Dz).Location = new Point(239, 57);
		((Control)Dz).Margin = new Padding(0);
		((Control)Dz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cf();
		((TextBoxBase)Dz).ReadOnly = true;
		((Control)Dz).Size = new Size(38, 29);
		((Control)Dz).TabIndex = 5;
		((Control)Dz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		((TextBox)Dz).TextAlign = (HorizontalAlignment)2;
		((Control)dA).Location = new Point(286, 57);
		((Control)dA).Margin = new Padding(0);
		((Control)dA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cG();
		((TextBoxBase)dA).ReadOnly = true;
		((Control)dA).Size = new Size(38, 29);
		((Control)dA).TabIndex = 6;
		((Control)dA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		((TextBox)dA).TextAlign = (HorizontalAlignment)2;
		((Control)da).Location = new Point(333, 57);
		((Control)da).Margin = new Padding(0);
		((Control)da).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cg();
		((TextBoxBase)da).ReadOnly = true;
		((Control)da).Size = new Size(38, 29);
		((Control)da).TabIndex = 7;
		((Control)da).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		((TextBox)da).TextAlign = (HorizontalAlignment)2;
		((Control)Dr).Dock = (DockStyle)5;
		((Control)Dr).Location = new Point(4, 52);
		((Control)Dr).Margin = new Padding(0);
		((Control)Dr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cH();
		((Control)Dr).Size = new Size(86, 44);
		((Control)Dr).TabIndex = 0;
		((Control)Dr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ch();
		Dr.TextAlign = (ContentAlignment)32;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(9f, 23f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)DR);
		((Control)this).Margin = new Padding(0);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cI();
		((Control)this).Size = new Size(472, 96);
		((Control)DR).ResumeLayout(false);
		((Control)Ds).ResumeLayout(false);
		((Control)Ds).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
