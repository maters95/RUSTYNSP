using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.Resources;

namespace NSP.UserInterface;

public class StartupOptionsPanel : UserControl
{
	private IContainer ii;

	private LinkLabel iJ;

	private LinkLabel ij;

	private Label iK;

	private Label ik;

	private Label iL;

	private Label il;

	private Label iM;

	private Label im;

	private Label iN;

	private Label @in;

	private Label iO;

	private Label io;

	private Label iP;

	private Label ip;

	private Label iQ;

	private Label iq;

	private PictureBox iR;

	private PictureBox ir;

	private PictureBox iS;

	public BorderStyle BorderStyle
	{
		get
		{
			return (BorderStyle)0;
		}
		set
		{
		}
	}

	public StartupOptionsPanel()
	{
		a();
	}

	internal void A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).BackColor = BM.tH;
		((Control)this).ForeColor = BM.te;
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val = item;
			if (val is LinkLabel)
			{
				((LinkLabel)((val is LinkLabel) ? val : null)).LinkColor = BM.te;
			}
			else if (val is Label)
			{
				((val is Label) ? val : null).ForeColor = BM.te;
			}
		}
		((Control)iM).ForeColor = BM.tf;
		Image image = iS.Image;
		iS.Image = (Image)(object)O.A((Image)(object)GeneralResources.IconBasicUSB, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (image != null)
		{
			image.Dispose();
		}
		Image image2 = iR.Image;
		iR.Image = (Image)(object)O.A((Image)(object)GeneralResources.IconNewMap, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (image2 != null)
		{
			image2.Dispose();
		}
		Image image3 = ir.Image;
		ir.Image = (Image)(object)O.A((Image)(object)GeneralResources.IconOpenMap, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (image3 != null)
		{
			image3.Dispose();
		}
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		e.Graphics.Clear(BM.td);
		e.Graphics.SmoothingMode = (SmoothingMode)2;
		GraphicsPath val = ThemedButton.A(new Rectangle(0, 0, ((Control)this).Width - 1, ((Control)this).Height - 1), 7);
		try
		{
			Brush val2 = (Brush)new SolidBrush(BM.tH);
			try
			{
				e.Graphics.FillPath(val2, val);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (((Control)this).Visible)
		{
			A();
		}
	}

	private void A(object P_0, LinkLabelLinkClickedEventArgs P_1)
	{
		BM.QQ.ac(null, null);
	}

	private void a(object P_0, LinkLabelLinkClickedEventArgs P_1)
	{
		BM.QQ.ad(null, null);
	}

	private void a(object P_0, EventArgs P_1)
	{
		BM.QQ.ac(null, null);
	}

	private void B(object P_0, EventArgs P_1)
	{
		BM.QQ.ad(null, null);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && ii != null)
		{
			((System.IDisposable)ii).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void a()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected O, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected O, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected O, but got Unknown
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2d: Expected O, but got Unknown
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Expected O, but got Unknown
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected O, but got Unknown
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Expected O, but got Unknown
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected O, but got Unknown
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected O, but got Unknown
		ComponentResourceManager val = new ComponentResourceManager(typeof(StartupOptionsPanel));
		iJ = new LinkLabel();
		ij = new LinkLabel();
		iK = new Label();
		ik = new Label();
		iL = new Label();
		il = new Label();
		iM = new Label();
		im = new Label();
		iN = new Label();
		@in = new Label();
		iO = new Label();
		io = new Label();
		iP = new Label();
		ip = new Label();
		iQ = new Label();
		iq = new Label();
		iR = new PictureBox();
		ir = new PictureBox();
		iS = new PictureBox();
		((ISupportInitialize)iR).BeginInit();
		((ISupportInitialize)ir).BeginInit();
		((ISupportInitialize)iS).BeginInit();
		((Control)this).SuspendLayout();
		((Control)iJ).AutoSize = true;
		((Control)iJ).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)iJ).Location = new Point(162, 134);
		((Control)iJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fu();
		((Control)iJ).Size = new Size(222, 21);
		((Control)iJ).TabIndex = 0;
		iJ.TabStop = true;
		((Control)iJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fV();
		iJ.LinkClicked += new LinkLabelLinkClickedEventHandler(A);
		((Control)ij).AutoSize = true;
		((Control)ij).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)ij).Location = new Point(162, 209);
		((Control)ij).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fv();
		((Control)ij).Size = new Size(273, 21);
		((Control)ij).TabIndex = 1;
		ij.TabStop = true;
		((Control)ij).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fW();
		ij.LinkClicked += new LinkLabelLinkClickedEventHandler(a);
		((Control)iK).AutoSize = true;
		((Control)iK).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)iK).Location = new Point(79, 156);
		((Control)iK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
		((Control)iK).Size = new Size(272, 21);
		((Control)iK).TabIndex = 2;
		((Control)iK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fX();
		((Control)ik).AutoSize = true;
		((Control)ik).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)ik).Location = new Point(79, 231);
		((Control)ik).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
		((Control)ik).Size = new Size(272, 21);
		((Control)ik).TabIndex = 3;
		((Control)ik).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fX();
		((Control)iL).AutoSize = true;
		((Control)iL).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)iL).Location = new Point(79, 209);
		((Control)iL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
		((Control)iL).Size = new Size(80, 21);
		((Control)iL).TabIndex = 4;
		((Control)iL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fy();
		((Control)il).AutoSize = true;
		((Control)il).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)il).Location = new Point(79, 81);
		((Control)il).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
		((Control)il).Size = new Size(452, 21);
		((Control)il).TabIndex = 5;
		((Control)il).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fz();
		((Control)iM).AutoSize = true;
		((Control)iM).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)iM).Location = new Point(16, 14);
		((Control)iM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GA();
		((Control)iM).Size = new Size(219, 21);
		((Control)iM).TabIndex = 8;
		((Control)iM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ga();
		((Control)im).AutoSize = true;
		((Control)im).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)im).Location = new Point(79, 59);
		((Control)im).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GB();
		((Control)im).Size = new Size(80, 21);
		((Control)im).TabIndex = 9;
		((Control)im).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gb();
		((Control)iN).AutoSize = true;
		((Control)iN).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)iN).Location = new Point(79, 134);
		((Control)iN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GC();
		((Control)iN).Size = new Size(80, 21);
		((Control)iN).TabIndex = 10;
		((Control)iN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gc();
		((Control)@in).AutoSize = true;
		((Control)@in).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)@in).Location = new Point(162, 59);
		((Control)@in).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GD();
		((Control)@in).Size = new Size(210, 21);
		((Control)@in).TabIndex = 11;
		((Control)@in).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gd();
		((Control)iO).AutoSize = true;
		((Control)iO).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)iO).Location = new Point(347, 156);
		((Control)iO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GE();
		((Control)iO).Size = new Size(34, 21);
		((Control)iO).TabIndex = 12;
		((Control)iO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ge();
		((Control)io).AutoSize = true;
		((Control)io).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)io).Location = new Point(347, 231);
		((Control)io).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GF();
		((Control)io).Size = new Size(34, 21);
		((Control)io).TabIndex = 13;
		((Control)io).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ge();
		((Control)iP).AutoSize = true;
		((Control)iP).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)iP).Location = new Point(488, 156);
		((Control)iP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gf();
		((Control)iP).Size = new Size(45, 21);
		((Control)iP).TabIndex = 14;
		((Control)iP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GG();
		((Control)ip).AutoSize = true;
		((Control)ip).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)ip).Location = new Point(488, 231);
		((Control)ip).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gg();
		((Control)ip).Size = new Size(51, 21);
		((Control)ip).TabIndex = 15;
		((Control)ip).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GH();
		((Control)iQ).AutoSize = true;
		((Control)iQ).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)iQ).Location = new Point(377, 156);
		((Control)iQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gh();
		((Control)iQ).Size = new Size(115, 21);
		((Control)iQ).TabIndex = 16;
		((Control)iQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GI();
		((Control)iq).AutoSize = true;
		((Control)iq).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)iq).Location = new Point(377, 231);
		((Control)iq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gi();
		((Control)iq).Size = new Size(115, 21);
		((Control)iq).TabIndex = 17;
		((Control)iq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GI();
		((Control)iR).BackColor = Color.Transparent;
		((Control)iR).Cursor = Cursors.Hand;
		iR.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GJ());
		((Control)iR).Location = new Point(20, 134);
		((Control)iR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gj();
		((Control)iR).Size = new Size(48, 48);
		iR.SizeMode = (PictureBoxSizeMode)4;
		iR.TabIndex = 18;
		iR.TabStop = false;
		((Control)iR).Click += new EventHandler(a);
		((Control)ir).BackColor = Color.Transparent;
		((Control)ir).Cursor = Cursors.Hand;
		ir.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GK());
		((Control)ir).Location = new Point(20, 209);
		((Control)ir).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gk();
		((Control)ir).Size = new Size(48, 48);
		ir.SizeMode = (PictureBoxSizeMode)4;
		ir.TabIndex = 19;
		ir.TabStop = false;
		((Control)ir).Click += new EventHandler(B);
		((Control)iS).BackColor = Color.Transparent;
		iS.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GL());
		((Control)iS).Location = new Point(20, 59);
		((Control)iS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gl();
		((Control)iS).Size = new Size(48, 48);
		iS.SizeMode = (PictureBoxSizeMode)4;
		iS.TabIndex = 20;
		iS.TabStop = false;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)iS);
		((Control)this).Controls.Add((Control)(object)ir);
		((Control)this).Controls.Add((Control)(object)iR);
		((Control)this).Controls.Add((Control)(object)iq);
		((Control)this).Controls.Add((Control)(object)iQ);
		((Control)this).Controls.Add((Control)(object)ip);
		((Control)this).Controls.Add((Control)(object)iP);
		((Control)this).Controls.Add((Control)(object)io);
		((Control)this).Controls.Add((Control)(object)iO);
		((Control)this).Controls.Add((Control)(object)@in);
		((Control)this).Controls.Add((Control)(object)iN);
		((Control)this).Controls.Add((Control)(object)im);
		((Control)this).Controls.Add((Control)(object)iM);
		((Control)this).Controls.Add((Control)(object)il);
		((Control)this).Controls.Add((Control)(object)iL);
		((Control)this).Controls.Add((Control)(object)ik);
		((Control)this).Controls.Add((Control)(object)iK);
		((Control)this).Controls.Add((Control)(object)ij);
		((Control)this).Controls.Add((Control)(object)iJ);
		((Control)this).DoubleBuffered = true;
		((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GM();
		((Control)this).Size = new Size(549, 275);
		((Control)this).VisibleChanged += new EventHandler(A);
		((ISupportInitialize)iR).EndInit();
		((ISupportInitialize)ir).EndInit();
		((ISupportInitialize)iS).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
