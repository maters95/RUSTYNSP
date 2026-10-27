using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;

namespace a;

internal class aH : Panel
{
	internal class A : PictureBox
	{
		private aH BMk;

		internal A(aH P_0)
		{
			BMk = P_0;
			((Control)this).SetStyle((ControlStyles)512, true);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			((PictureBox)this).OnPaint(e);
			if (!(((Control)this).Tag is int) || (int)((Control)this).Tag != BMk.a())
			{
				return;
			}
			e.Graphics.SmoothingMode = (SmoothingMode)2;
			GraphicsPath val = ThemedButton.A(new Rectangle(2, 2, ((Control)this).Width - 5, ((Control)this).Height - 5), 6);
			try
			{
				Pen val2 = new Pen(Color.DodgerBlue, 4f);
				try
				{
					e.Graphics.DrawPath(val2, val);
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
	}

	private const int Ia = 3;

	private const int IB = 140;

	private const int Ib = 10;

	private const int IC = 25;

	private List<Image> Ic = new List<Image>();

	private List<string> ID = new List<string>();

	private List<object> Id = new List<object>();

	private aF IE = new aF();

	[CompilerGenerated]
	private EventHandler Ie;

	private int IF = -1;

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = Ie;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref Ie, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = Ie;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref Ie, val3, val2);
		}
		while (val != val2);
	}

	internal aH()
	{
		((Control)this).SetStyle((ControlStyles)512, true);
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).DoubleBuffered = true;
		((Control)this).AutoSize = false;
		((Control)IE).AutoSize = false;
		((Control)IE).Height = 180;
		((Control)IE).Width = 252;
		((Control)this).Height = 3 + ((Control)IE).Height + 20;
		((Control)this).Width = 25 + ((Control)IE).Width + 25;
		((Control)IE).Top = 3;
		((Control)IE).Left = 25;
		((Control)this).Controls.Add((Control)(object)IE);
	}

	internal void A()
	{
		IE.a();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		if (a() > 0)
		{
			e.Graphics.DrawImage(BM.tR, 1, 80);
		}
		if (a() < b() - 1)
		{
			e.Graphics.DrawImage(BM.tr, ((Control)this).Width - 1 - BM.tr.Width, 80);
		}
		e.Graphics.SmoothingMode = (SmoothingMode)2;
		int num = b();
		if (num <= 1)
		{
			return;
		}
		SolidBrush val = new SolidBrush(BM.te);
		try
		{
			Pen val2 = new Pen(BM.te);
			try
			{
				int num2 = A(num);
				int num3 = ((Control)this).Height - 15;
				int num4 = A(num, num2);
				for (int i = 0; i < num; i++)
				{
					int num5 = num4 + i * num2;
					if (a() == i)
					{
						e.Graphics.FillEllipse((Brush)(object)val, num5, num3, 10, 10);
					}
					else
					{
						e.Graphics.DrawEllipse(val2, num5, num3, 10, 10);
					}
				}
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

	protected override void OnMouseClick(MouseEventArgs e)
	{
		if (e.Y < ((Control)this).Height - 20)
		{
			if (e.X < 25)
			{
				if (a() > 0)
				{
					int num = a();
					a(num - 1);
				}
				return;
			}
			if (e.X > ((Control)this).Width - 25)
			{
				if (a() < b() - 1)
				{
					int num = a();
					a(num + 1);
				}
				return;
			}
		}
		else if (b() > 1)
		{
			int num2 = b();
			int num3 = A(num2);
			int num4 = A(num2, num3);
			for (int i = 0; i < num2; i++)
			{
				int num5 = num4 + i * num3;
				if (e.X >= num5 - 2 && e.X <= num5 + 10 + 2)
				{
					a(i);
					break;
				}
			}
			return;
		}
		((Control)this).OnMouseClick(e);
	}

	private int A(int P_0)
	{
		return Math.Min(Math.Max((((Control)this).Width - 30) / (P_0 - 1), 15), 30);
	}

	private int A(int P_0, int P_1)
	{
		return (((Control)this).Width - (P_0 - 1) * P_1) / 2 - 5;
	}

	protected override void OnGotFocus(EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		((Control)this).OnGotFocus(e);
		foreach (Control item in (ArrangedElementCollection)((Control)IE).Controls)
		{
			Control val = item;
			if (val is A && val.Tag is int && ((int)val.Tag == a() || (a() == -1 && (int)val.Tag == 0)))
			{
				val.Select();
				val.Focus();
				((ScrollableControl)IE).ScrollControlIntoView(val);
			}
			val.Invalidate();
		}
		A();
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal int a()
	{
		return IF;
	}

	[SpecialName]
	internal void a(int P_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		foreach (Control item in (ArrangedElementCollection)((Control)IE).Controls)
		{
			Control val = item;
			if (val is Label)
			{
				if (P_0 == -1)
				{
					val.ForeColor = BM.te;
				}
				else if (val.Tag is int && (int)val.Tag == P_0)
				{
					val.ForeColor = Color.DodgerBlue;
				}
				else
				{
					val.ForeColor = BM.te;
				}
			}
			else if (val is A && val.Tag is int && (int)val.Tag == P_0)
			{
				val.Select();
				val.Focus();
				((ScrollableControl)IE).ScrollControlIntoView(val);
			}
			val.Invalidate();
		}
		A();
		if (P_0 != IF)
		{
			IF = P_0;
			if (Ie != null)
			{
				Ie.Invoke((object)this, (EventArgs)null);
			}
		}
		((Control)this).Invalidate();
	}

	internal void A(Image P_0, string P_1, object P_2)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		int count = Ic.Count;
		Ic.Add(P_0);
		ID.Add(P_1);
		Id.Add(P_2);
		A a = new A(this);
		((Control)a).Tag = count;
		((PictureBox)a).SizeMode = (PictureBoxSizeMode)4;
		((Control)a).Size = new Size(140, 140);
		((PictureBox)a).Image = P_0;
		((Control)a).Left = count * 150;
		((Control)a).Top = 0;
		((Control)IE).Controls.Add((Control)(object)a);
		((Control)a).Click += new EventHandler(A);
		((Control)a).PreviewKeyDown += new PreviewKeyDownEventHandler(A);
		Label val = new Label();
		((Control)val).Tag = count;
		((Control)val).ForeColor = BM.te;
		((Control)val).AutoSize = false;
		val.TextAlign = (ContentAlignment)32;
		((Control)val).Width = ((Control)a).Width;
		((Control)val).Height = 20;
		((Control)val).Text = P_1;
		((Control)val).Left = ((Control)a).Left;
		((Control)val).Top = ((Control)a).Height;
		((Control)IE).Controls.Add((Control)(object)val);
		((Control)val).Click += new EventHandler(A);
		((Control)val).PreviewKeyDown += new PreviewKeyDownEventHandler(A);
	}

	internal void B()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		IF = -1;
		for (int num = b() - 1; num >= 0; num--)
		{
			Image val = Ic[num];
			Ic.RemoveAt(num);
			ID.RemoveAt(num);
			Id.RemoveAt(num);
			for (int num2 = ((ArrangedElementCollection)((Control)IE).Controls).Count - 1; num2 >= 0; num2--)
			{
				Control val2 = ((Control)IE).Controls[num2];
				if ((val2 is A || val2 is Label) && val2.Tag is int && (int)val2.Tag == num)
				{
					val2.Click -= new EventHandler(A);
					val2.PreviewKeyDown -= new PreviewKeyDownEventHandler(A);
					((Control)IE).Controls.RemoveAt(num2);
					if (val2 is A)
					{
						((PictureBox)(val2 as A)).Image = null;
					}
					((Component)val2).Dispose();
				}
			}
			if (val != null)
			{
				val.Dispose();
			}
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		Control val = (Control)((P_0 is Control) ? P_0 : null);
		if (val.Tag != null)
		{
			int num = (int)val.Tag;
			a(num);
		}
	}

	private void A(object P_0, PreviewKeyDownEventArgs P_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		((Control)this).OnPreviewKeyDown(P_1);
		if ((int)P_1.KeyData == 37)
		{
			P_1.IsInputKey = true;
			if (a() > 0)
			{
				int num = a();
				a(num - 1);
			}
		}
		if ((int)P_1.KeyData == 39)
		{
			P_1.IsInputKey = true;
			if (a() < b() - 1)
			{
				int num = a();
				a(num + 1);
			}
		}
	}

	internal Image B(int P_0)
	{
		if (P_0 >= 0 && P_0 < Ic.Count)
		{
			return Ic[P_0];
		}
		return null;
	}

	internal string b(int P_0)
	{
		if (P_0 >= 0 && P_0 < ID.Count)
		{
			return ID[P_0];
		}
		return null;
	}

	internal object C(int P_0)
	{
		if (P_0 >= 0 && P_0 < Id.Count)
		{
			return Id[P_0];
		}
		return null;
	}

	[SpecialName]
	internal int b()
	{
		return Ic.Count;
	}
}
internal class ah : UserControl
{
	private delegate void A(object P_0, EventArgs P_1);

	private delegate void a(object P_0, EventArgs P_1);

	private delegate void B(object P_0, EventArgs P_1);

	private delegate void b(object P_0, EventArgs P_1);

	private delegate void C(object P_0, EventArgs P_1);

	private Framework If;

	private Framework IG;

	private ConditionalActivator Ig;

	private Setting IH;

	private Setting Ih;

	private Setting II;

	private string Ii;

	private Setting IJ;

	private Setting Ij;

	private Setting IK;

	private Setting Ik;

	private Setting IL;

	private Setting Il;

	private Setting IM;

	private bool Im;

	private aP IN = new aP();

	private aI In = new aI();

	private Label IO = new Label();

	private ThemedComboBox Io = new ThemedComboBox();

	private ThemedTextBox IP = new ThemedTextBox();

	private ThemedComboBox Ip = new ThemedComboBox();

	private Label IQ = new Label();

	private PictureBox Iq = new PictureBox();

	private bool IR;

	private bool Ir;

	private bool IS;

	internal ah(ConditionalActivator P_0, Framework P_1, Framework P_2)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		A(P_0, P_1, P_2);
	}

	private void A(ConditionalActivator P_0, Framework P_1, Framework P_2)
	{
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected O, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected O, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2e: Expected O, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected O, but got Unknown
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Expected O, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected O, but got Unknown
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Expected O, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Expected O, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		If = P_1;
		IG = P_2;
		Ig = P_0;
		In.A(If);
		if (Ig.EnablerSettingId != 0)
		{
			IH = If.A(Ig.EnablerSettingId);
		}
		Ih = If.A(Ig.ChannelSettingId);
		II = If.A(Ih.ax());
		Ii = Ig.JoinText;
		IJ = If.A(Ig.OperatorSettingId);
		Ij = If.A(Ig.ThresholdSettingId);
		if (IG != null)
		{
			if (IH != null)
			{
				IK = IG.A(IH.A());
			}
			if (Ih != null)
			{
				Ik = IG.A(Ih.A());
			}
			if (Ik != null)
			{
				IL = IG.A(Ik.ax());
			}
			if (IJ != null)
			{
				Il = IG.A(IJ.A());
			}
			if (Ij != null)
			{
				IM = IG.A(Ij.A());
			}
		}
		IR = If.B() && If.b() && ((IH != null && IH.J()) || (Ih != null && Ih.J()) || (IJ != null && IJ.J()) || (Ij != null && Ij.J()));
		Ir = IG != null && IG.B() && IG.b() && ((IK != null && IK.J()) || (Ik != null && Ik.J()) || (Il != null && Il.J()) || (IM != null && IM.J()));
		bool flag = ((BM.QO != BM.b.BpG || IG == null) ? IR : Ir);
		BM.QQ.B(new EventHandler(b));
		Im = false;
		if (IH != null)
		{
			IH.A(new EventHandler(g));
			((SettingOrSpecialObject)IH).A(new EventHandler(C));
		}
		if (Ih != null)
		{
			Ih.A(new EventHandler(H));
			((SettingOrSpecialObject)Ih).A(new EventHandler(C));
		}
		if (IJ != null)
		{
			IJ.A(new EventHandler(h));
		}
		if (Ij != null)
		{
			Ij.A(new EventHandler(G));
			((SettingOrSpecialObject)Ij).A(new EventHandler(C));
		}
		((Control)this).SuspendLayout();
		bool flag2 = BM.QO == BM.b.BpF && (IR || Ir) && IG != null;
		if (flag || flag2)
		{
			Label val = new Label();
			if (flag2)
			{
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fP();
			}
			else
			{
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fp();
			}
			((Control)val).ForeColor = BM.te;
			((Control)val).Left = 0;
			((Control)val).Top = 2;
			((Control)val).AutoSize = true;
			((Control)this).Controls.Add((Control)(object)val);
			((Control)this).AutoSize = false;
			((Control)this).Height = ((Control)In).Height;
			((Control)this).Width = 800;
		}
		else
		{
			if (IH != null)
			{
				((Control)IN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eb();
				if (BM.QO == BM.b.BpG && IK != null)
				{
					IN.jd = true;
					((CheckBox)IN).Checked = IK.ax() != 0;
				}
				else
				{
					IN.jd = false;
					((CheckBox)IN).Checked = IH.ax() != 0;
				}
				((Control)IN).Left = 0;
				((Control)IN).Top = 1;
				((Control)IN).Width = 70;
				((CheckBox)IN).CheckedChanged += new EventHandler(D);
				((Control)this).Controls.Add((Control)(object)IN);
			}
			In.A(new EventHandler(c));
			if (BM.QO == BM.b.BpG)
			{
				if (IL == null)
				{
					In.A(0);
				}
				else
				{
					In.A(IL.A());
				}
			}
			else if (II == null)
			{
				In.A(0);
			}
			else
			{
				In.A(II.A());
			}
			if (IH == null)
			{
				((Control)In).Left = 0;
			}
			else
			{
				((Control)In).Left = ((Control)IN).Right + 5;
			}
			((Control)In).Top = 0;
			((Control)this).Controls.Add((Control)(object)In);
			((Control)IO).Text = Ii;
			((Control)IO).ForeColor = BM.te;
			((Control)IO).Left = ((Control)In).Right + 5;
			((Control)IO).Top = 3;
			((Control)IO).Height = 16;
			((Control)IO).Width = 15;
			((Control)this).Controls.Add((Control)(object)IO);
			D();
			((ComboBox)Io).DropDownStyle = (ComboBoxStyle)2;
			((Control)Io).Left = ((Control)IO).Right + 5;
			((Control)Io).Top = 0;
			((Control)Io).Width = 180;
			((ComboBox)Io).SelectedIndexChanged += new EventHandler(d);
			((Control)this).Controls.Add((Control)(object)Io);
			((Control)IP).Left = ((Control)Io).Right + 5;
			((Control)IP).Top = 0;
			((Control)IP).Width = 180;
			((Control)IP).GotFocus += new EventHandler(e);
			((Control)IP).KeyDown += new KeyEventHandler(A);
			((Control)IP).KeyPress += new KeyPressEventHandler(A);
			((Control)IP).Leave += new EventHandler(f);
			((Control)this).Controls.Add((Control)(object)IP);
			((ComboBox)Ip).DropDownStyle = (ComboBoxStyle)1;
			((Control)Ip).GotFocus += new EventHandler(F);
			((ComboBox)Ip).SelectedIndexChanged += new EventHandler(E);
			((Control)Ip).Left = ((Control)Io).Right + 5;
			((Control)Ip).Top = 0;
			((Control)Ip).Width = 180;
			((Control)Ip).KeyDown += new KeyEventHandler(A);
			((Control)Ip).KeyPress += new KeyPressEventHandler(A);
			((Control)Ip).Leave += new EventHandler(f);
			((Control)this).Controls.Add((Control)(object)Ip);
			((ComboBox)Ip).Items.Clear();
			Setting setting = ((BM.QO != BM.b.BpG) ? II : IL);
			((ComboBox)Ip).Items.Clear();
			if (setting != null && setting.d(0).Count != 0)
			{
				List<Setting.ListItems.A> val2 = setting.d(0);
				int num = 0;
				string[] array = new string[val2.Count];
				Graphics val3 = ((Control)this).CreateGraphics();
				try
				{
					for (int i = 0; i < val2.Count; i++)
					{
						array[i] = val2[i].bBV;
						Size val4 = TextRenderer.MeasureText((IDeviceContext)(object)val3, array[i], ((Control)Ip).Font);
						num = Math.Max(((Size)(ref val4)).Width, num);
					}
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
				ObjectCollection items = ((ComboBox)Ip).Items;
				object[] array2 = array;
				items.AddRange(array2);
				if (num > ((ComboBox)Ip).DropDownWidth - 130)
				{
					((ComboBox)Ip).DropDownWidth = num + 130;
				}
				if (((ComboBox)Ip).Items.Count > 20)
				{
					((ComboBox)Ip).DropDownHeight = 360;
				}
				((Control)Ip).Visible = true;
				((Control)IP).Visible = false;
			}
			else
			{
				((Control)IP).Visible = true;
				((Control)Ip).Visible = false;
			}
			((Control)IQ).ForeColor = BM.te;
			((Control)IQ).Left = ((Control)IP).Right + 5;
			((Control)IQ).Top = 3;
			((Control)IQ).Height = 16;
			((Control)IQ).Width = 120;
			((Control)this).Controls.Add((Control)(object)IQ);
			((Control)Iq).Tag = Ij;
			((Control)Iq).Width = 18;
			((Control)Iq).Height = 18;
			((Control)Iq).Left = ((Control)IQ).Right;
			((Control)Iq).Top = 1;
			Iq.SizeMode = (PictureBoxSizeMode)1;
			((Control)Iq).Click += new EventHandler(B);
			((Control)this).Controls.Add((Control)(object)Iq);
			((Control)Iq).Visible = false;
			((Control)IP).MouseEnter += new EventHandler(A);
			((Control)Ip).MouseEnter += new EventHandler(A);
			((Control)IQ).MouseEnter += new EventHandler(A);
			((Control)Iq).MouseEnter += new EventHandler(A);
			((Control)this).MouseLeave += new EventHandler(a);
		}
		c();
		if (!flag && !flag2)
		{
			((Control)this).AutoSize = false;
			((Control)this).Height = ((Control)In).Height;
			((Control)this).Width = ((Control)Iq).Right;
		}
		((Control)this).ResumeLayout(true);
	}

	[SpecialName]
	internal Setting A()
	{
		return IJ;
	}

	[SpecialName]
	internal Setting a()
	{
		return Ij;
	}

	[SpecialName]
	internal ThemedComboBox B()
	{
		return Io;
	}

	[SpecialName]
	internal ThemedTextBox b()
	{
		return IP;
	}

	[SpecialName]
	internal ThemedComboBox C()
	{
		return Ip;
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (BM.SR != Iq)
		{
			if (!BM.Sr && BM.SR != null)
			{
				((Control)BM.SR).Visible = false;
			}
			BM.Sr = (((SettingOrSpecialObject)Ij).l() && !Ij.O()) || (((SettingOrSpecialObject)Ih).l() && !Ih.O());
			BM.SR = Iq;
		}
		((Control)Iq).Visible = true;
	}

	private void a(object P_0, EventArgs P_1)
	{
		((Control)Iq).Visible = Iq.Image != null && ((((SettingOrSpecialObject)Ij).l() && !Ij.O()) || (((SettingOrSpecialObject)Ih).l() && !Ih.O()));
	}

	private void c()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		bool flag = IR || Ir;
		if (IH != null)
		{
			if (flag || IK == null || IH.A(IK))
			{
				((Control)IN).ForeColor = BM.te;
			}
			else
			{
				((Control)IN).ForeColor = BM.tD;
			}
			if (BM.QO == BM.b.BpG)
			{
				((Control)IN).Enabled = false;
			}
			else
			{
				((Control)IN).Enabled = ((SettingOrSpecialObject)IH).l() && If.C();
			}
		}
		if (BM.QO == BM.b.BpG)
		{
			if (IL != null)
			{
				if (((Control)IP).Visible)
				{
					((Control)IP).Text = E();
				}
				else if (((Control)Ip).Visible)
				{
					((Control)Ip).Text = E();
					List<Setting.ListItems.A> val = IL.d(0);
					for (int i = 0; i < val.Count; i++)
					{
						if (val[i].bBV == ((Control)Ip).Text)
						{
							((ListControl)Ip).SelectedIndex = i;
							break;
						}
					}
				}
			}
		}
		else if (II != null)
		{
			if (((Control)IP).Visible)
			{
				((Control)IP).Text = d();
			}
			else if (((Control)Ip).Visible)
			{
				((Control)Ip).Text = d();
				List<Setting.ListItems.A> val2 = II.d(0);
				for (int j = 0; j < val2.Count; j++)
				{
					if (val2[j].bBV == ((Control)Ip).Text)
					{
						((ListControl)Ip).SelectedIndex = j;
						break;
					}
				}
			}
		}
		if (BM.QO != BM.b.BpG && ((SettingOrSpecialObject)Ij).l() && If.C() && !Ij.O())
		{
			((Control)IP).Enabled = true;
			((Control)Ip).Enabled = true;
			switch (Ij.P())
			{
			case IllegalitySeverityLevel.Error:
				((Control)Ip).BackColor = Color.Red;
				((Control)IP).BackColor = Color.Red;
				Iq.Image = (Image)(object)GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				((Control)Ip).BackColor = Color.Orange;
				((Control)IP).BackColor = Color.Orange;
				Iq.Image = (Image)(object)GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (BM.A(If.aXc, true))
				{
					((Control)Ip).BackColor = Color.Red;
					((Control)IP).BackColor = Color.Red;
					Iq.Image = (Image)(object)GeneralResources.RedError;
				}
				else
				{
					((Control)Ip).BackColor = Color.Orange;
					((Control)IP).BackColor = Color.Orange;
					Iq.Image = (Image)(object)GeneralResources.YellowWarning;
				}
				break;
			default:
				((Control)Ip).BackColor = Color.Red;
				((Control)IP).BackColor = Color.Red;
				Iq.Image = (Image)(object)GeneralResources.RedError;
				break;
			}
			((Control)Iq).Visible = true;
		}
		else
		{
			if (BM.QO == BM.b.BpG)
			{
				((Control)IP).Enabled = false;
				((Control)Ip).Enabled = false;
			}
			else
			{
				((Control)IP).Enabled = ((SettingOrSpecialObject)Ij).l() && If.C();
				((Control)Ip).Enabled = ((Control)IP).Enabled;
			}
			if (IM != null && !flag && !Ij.A(IM))
			{
				((Control)Ip).BackColor = BM.tD;
				((Control)IP).BackColor = BM.tD;
			}
			else if (((Control)IP).Enabled)
			{
				((Control)Ip).BackColor = BM.to;
				((Control)IP).BackColor = BM.to;
			}
			else
			{
				((Control)Ip).BackColor = BM.tQ;
				((Control)IP).BackColor = BM.tQ;
			}
			((Control)Iq).Visible = false;
			Iq.Image = (Image)(object)GeneralResources.QuestionMark;
		}
		if (((Control)IP).Enabled || ((Control)IP).BackColor == BM.tD)
		{
			((Control)IP).ForeColor = BM.te;
			((Control)Ip).ForeColor = BM.te;
		}
		else
		{
			((Control)IP).ForeColor = BM.tq;
			((Control)Ip).ForeColor = BM.tq;
		}
		aI @in = In;
		Label iO = IO;
		ThemedComboBox io = Io;
		bool flag3 = (((Control)IQ).Enabled = ((SettingOrSpecialObject)IJ).l() && ((Control)IP).Enabled && If.C());
		bool flag5 = (((Control)io).Enabled = flag3);
		bool enabled = (((Control)iO).Enabled = flag5);
		((Control)@in).Enabled = enabled;
		In.A();
		if (BM.QO != BM.b.BpG && ((Control)In).Enabled && If.C() && !Ih.O())
		{
			Iq.Image = (Image)(object)GeneralResources.RedError;
			((Control)Iq).Visible = true;
		}
		if (((Control)Io).Enabled && !IJ.O())
		{
			switch (IJ.P())
			{
			case IllegalitySeverityLevel.Error:
				((Control)Io).BackColor = Color.Red;
				break;
			case IllegalitySeverityLevel.Warning:
				((Control)Io).BackColor = Color.Orange;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (BM.A(If.aXc, true))
				{
					((Control)Io).BackColor = Color.Red;
				}
				else
				{
					((Control)Io).BackColor = Color.Orange;
				}
				break;
			default:
				((Control)Io).BackColor = Color.Red;
				break;
			}
		}
		else if (Il != null && !flag && !IJ.A(Il))
		{
			((Control)Io).BackColor = BM.tD;
		}
		else if (((Control)Io).Enabled)
		{
			((Control)Io).BackColor = BM.to;
		}
		else
		{
			((Control)Io).BackColor = BM.tQ;
		}
		if (((Control)Io).Enabled || ((Control)Io).BackColor == BM.tD)
		{
			((Control)Io).ForeColor = BM.te;
		}
		else
		{
			((Control)Io).ForeColor = BM.tq;
		}
		((Control)Io).Invalidate();
		((Control)IP).Invalidate();
		((Control)Ip).Invalidate();
		if (BM.QO == BM.b.BpG)
		{
			if (IL != null)
			{
				int num = IL.aS();
				((Control)IQ).Text = bS.A(IL.@as(), num, false, 0);
			}
		}
		else if (II != null)
		{
			int num2 = II.aS();
			((Control)IQ).Text = bS.A(II.@as(), num2, false, 0);
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (((Control)In).Enabled && !Ih.O())
		{
			BM.A(Ih, (Control)(object)this);
		}
		else
		{
			BM.A(Ij, (Control)(object)this);
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (IR || Ir)
		{
			F();
			int width = ((Control)this).Width;
			int height = ((Control)this).Height;
			((Control)this).Parent.SuspendLayout();
			((Control)this).SuspendLayout();
			((Control)this).Controls.Clear();
			((Control)this).ResumeLayout(true);
			A(Ig, If, IG);
			if (!((Control)this).AutoSize)
			{
				((Control)this).Width = width;
				((Control)this).Height = height;
			}
			((Control)this).Parent.ResumeLayout(true);
			return;
		}
		if (BM.QO == BM.b.BpG)
		{
			if (IK != null)
			{
				IN.jd = true;
				if (((CheckBox)IN).Checked != (IK.ax() != 0))
				{
					((CheckBox)IN).Checked = IK.ax() != 0;
				}
			}
			if (IL == null)
			{
				In.A(0);
			}
			else
			{
				In.A(IL.A());
			}
		}
		else
		{
			if (IH != null)
			{
				IN.jd = false;
				if (((CheckBox)IN).Checked != (IH.ax() != 0))
				{
					((CheckBox)IN).Checked = IH.ax() != 0;
				}
			}
			if (II == null)
			{
				In.A(0);
			}
			else
			{
				In.A(II.A());
			}
		}
		D();
		c();
	}

	private void D()
	{
		((ComboBox)Io).Items.Clear();
		Setting setting = ((BM.QO != BM.b.BpG) ? IJ : Il);
		int selectedIndex = -1;
		int num = setting.ax();
		List<Setting.ListItems.A> val = setting.d(0);
		for (int i = 0; i < val.Count; i++)
		{
			((ComboBox)Io).Items.Add((object)val[i].bBV);
			if (val[i].bBv == num)
			{
				selectedIndex = i;
			}
		}
		((ListControl)Io).SelectedIndex = selectedIndex;
	}

	private void C(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = C;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		c();
	}

	private void c(object P_0, EventArgs P_1)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		if (Ih.ax() != In.a())
		{
			Ck ck = BM.aM();
			ck?.A(Ih.C());
			Ih.a(In.a(), true);
			ck?.B();
		}
		((ComboBox)Ip).Items.Clear();
		if (II != null && II.d(0).Count != 0)
		{
			List<Setting.ListItems.A> val = II.d(0);
			int num = 0;
			string[] array = new string[val.Count];
			Graphics val2 = ((Control)this).CreateGraphics();
			try
			{
				for (int i = 0; i < val.Count; i++)
				{
					array[i] = val[i].bBV;
					Size val3 = TextRenderer.MeasureText((IDeviceContext)(object)val2, array[i], ((Control)Ip).Font);
					num = Math.Max(((Size)(ref val3)).Width, num);
				}
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			ObjectCollection items = ((ComboBox)Ip).Items;
			object[] array2 = array;
			items.AddRange(array2);
			if (num > ((ComboBox)Ip).DropDownWidth - 130)
			{
				((ComboBox)Ip).DropDownWidth = num + 130;
			}
			else
			{
				((ComboBox)Ip).DropDownWidth = ((Control)Ip).Width;
			}
			if (((ComboBox)Ip).Items.Count > 20)
			{
				((ComboBox)Ip).DropDownHeight = 360;
			}
			((Control)Ip).Visible = true;
			((Control)IP).Visible = false;
		}
		else
		{
			((Control)IP).Visible = true;
			((Control)Ip).Visible = false;
		}
		BM.A(Ih.C());
		c();
	}

	private void D(object P_0, EventArgs P_1)
	{
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		CheckBox val = (CheckBox)((P_0 is CheckBox) ? P_0 : null);
		if ((!val.Checked || IH.ax() != 1) && (val.Checked || IH.ax() != 0))
		{
			Ck ck = BM.aM();
			ck?.A(IH.C());
			if (val.Checked)
			{
				IH.a(1, true);
			}
			else
			{
				IH.a(0, true);
			}
			ck?.B();
			BM.A(IH.C());
		}
	}

	private void d(object P_0, EventArgs P_1)
	{
		if (BM.QO != BM.b.BpG)
		{
			int selectedIndex = ((ListControl)Io).SelectedIndex;
			if (selectedIndex != -1 && IJ.ax() != IJ.d(0)[selectedIndex].bBv)
			{
				Ck ck = BM.aM();
				ck?.A(IJ.C());
				IJ.a(IJ.d(0)[selectedIndex].bBv, true);
				ck?.B();
				BM.A(IJ.C());
			}
		}
	}

	private string d()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (II == null)
		{
			return string.Empty;
		}
		int num = Ij.ax();
		return II.A(num, -1).Item1;
	}

	private string E()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IL == null)
		{
			return string.Empty;
		}
		int num = IM.ax();
		return IL.A(num, -1).Item1;
	}

	private void E(object P_0, EventArgs P_1)
	{
		if (BM.QO != BM.b.BpG && II != null && ((ListControl)Ip).SelectedIndex != -1 && Ij.ax() != II.d(0)[((ListControl)Ip).SelectedIndex].bBv)
		{
			Ck ck = BM.aM();
			ck?.A(Ij.C());
			Ij.a(II.d(0)[((ListControl)Ip).SelectedIndex].bBv, true);
			ck?.B();
			BM.A(Ij.C());
		}
	}

	internal void e()
	{
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)IP).Disposing || ((Control)Ip).Disposing || BM.QP || BM.sX || BM.QO == BM.b.BpG)
		{
			return;
		}
		string text = string.Empty;
		if (((Control)IP).Visible)
		{
			text = ((Control)IP).Text;
		}
		else if (((Control)Ip).Visible)
		{
			text = ((Control)Ip).Text;
		}
		Im = false;
		string text2 = d();
		if (text2 == text)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			if (((Control)IP).Visible)
			{
				((Control)IP).Text = text2;
			}
			else if (((Control)Ip).Visible)
			{
				((Control)Ip).Text = text2;
			}
			return;
		}
		try
		{
			int num = bS.A(text, II.aS());
			if (Ij.aG() == 2)
			{
				if (Ij.ag())
				{
					if (num < -32768)
					{
						num = -32768;
					}
					else if (num > 32767)
					{
						num = 32767;
					}
				}
				else if (num < 0)
				{
					num = 0;
				}
				else if (num > 65535)
				{
					num = 65535;
				}
			}
			else if (Ij.aG() == 1)
			{
				if (Ij.ag())
				{
					if (num < -128)
					{
						num = -128;
					}
					else if (num > 127)
					{
						num = 127;
					}
				}
				else if (num < 0)
				{
					num = 0;
				}
				else if (num > 255)
				{
					num = 255;
				}
			}
			int num2 = II.aR();
			int num3 = II.ar();
			if (num2 != 0 || num3 != 0)
			{
				num = Math.Min(Math.Max(num, num2), num3);
			}
			Ck ck = BM.aM();
			ck?.A(Ij.C());
			Ij.a(num, true);
			ck?.B();
			BM.A(Ij.C());
		}
		catch
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void e(object P_0, EventArgs P_1)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		BM.QQ.rL.A(Ij);
		if (IG != null && ((Control)IP).BackColor == BM.tD)
		{
			BM.A(Ij, (Control)(object)this);
		}
	}

	private void F(object P_0, EventArgs P_1)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		BM.QQ.rL.A(Ij);
		((ComboBox)Ip).SelectAll();
		if (IG != null && ((Control)Ip).BackColor == BM.tD)
		{
			BM.A(Ij, (Control)(object)this);
		}
	}

	private void A(object P_0, KeyEventArgs P_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if ((P_1.Control && (int)P_1.KeyCode == 33) || (int)P_1.KeyData == 33 || (P_1.Shift && (int)P_1.KeyCode == 33) || (P_1.Control && (int)P_1.KeyCode == 34) || (int)P_1.KeyData == 34 || (P_1.Shift && (int)P_1.KeyCode == 34))
		{
			IS = true;
			P_1.Handled = true;
		}
		else if ((int)P_1.KeyCode == 13 || (int)P_1.KeyCode == 13)
		{
			e();
		}
		else if ((P_1.KeyData & 0x20000) == 0)
		{
			Im = true;
		}
	}

	private void A(object P_0, KeyPressEventArgs P_1)
	{
		if (IS)
		{
			P_1.Handled = true;
			IS = false;
			Im = false;
		}
	}

	private void f(object P_0, EventArgs P_1)
	{
		e();
	}

	private void G(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = G;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO == BM.b.BpG || Im)
		{
			return;
		}
		if (((Control)IP).Visible)
		{
			string text = d();
			if (((Control)IP).Text != text)
			{
				int selectionStart = ((TextBoxBase)IP).SelectionStart;
				int selectionLength = ((TextBoxBase)IP).SelectionLength;
				((Control)IP).Text = text;
				((TextBoxBase)IP).SelectionStart = selectionStart;
				((TextBoxBase)IP).SelectionLength = selectionLength;
			}
			if (IM != null)
			{
				c();
			}
		}
		else
		{
			if (!((Control)Ip).Visible)
			{
				return;
			}
			bool flag = false;
			if (II != null)
			{
				int num = Ij.ax();
				List<Setting.ListItems.A> val = II.d(0);
				for (int i = 0; i < val.Count; i++)
				{
					if (val[i].bBv == num)
					{
						((ListControl)Ip).SelectedIndex = i;
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				string text2 = d();
				if (((Control)Ip).Text != text2)
				{
					int selectionStart2 = ((ComboBox)Ip).SelectionStart;
					int selectionLength2 = ((ComboBox)Ip).SelectionLength;
					((Control)Ip).Text = text2;
					((ComboBox)Ip).SelectionStart = selectionStart2;
					((ComboBox)Ip).SelectionLength = selectionLength2;
				}
				if (IM != null)
				{
					c();
				}
			}
		}
	}

	internal bool A(KeyEventArgs P_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG)
		{
			return false;
		}
		if ((!P_0.Control || (int)P_0.KeyCode != 33) && (int)P_0.KeyData != 33 && (!P_0.Shift || (int)P_0.KeyCode != 33) && (!P_0.Control || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 34 && (!P_0.Shift || (int)P_0.KeyCode != 34))
		{
			return false;
		}
		Im = false;
		int num = II.aS();
		int num2 = II.aR();
		int num3 = II.ar();
		int num4 = Ij.ax();
		int num5 = num4;
		if (P_0.Control && (int)P_0.KeyCode == 33)
		{
			num5 += bS.b(num);
		}
		else if ((int)P_0.KeyData == 33)
		{
			num5 += bS.C(num);
		}
		else if (P_0.Shift && (int)P_0.KeyCode == 33)
		{
			num5 += bS.c(num);
		}
		else if (P_0.Control && (int)P_0.KeyCode == 34)
		{
			num5 -= bS.b(num);
		}
		else if ((int)P_0.KeyData == 34)
		{
			num5 -= bS.C(num);
		}
		else if (P_0.Shift && (int)P_0.KeyCode == 34)
		{
			num5 -= bS.c(num);
		}
		if (num5 != num4)
		{
			if (num2 != 0 || num3 != 0)
			{
				num5 = Math.Min(num3, Math.Max(num2, num5));
			}
			if (num5 != num4)
			{
				if (((Control)IP).Visible)
				{
					((Control)IP).Text = bS.a(num5, num, -1);
				}
				else if (((Control)Ip).Visible)
				{
					((Control)Ip).Text = bS.a(num5, num, -1);
				}
				e();
			}
		}
		return true;
	}

	private void g(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b = g;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO != BM.b.BpG)
		{
			int num = IH.ax();
			if (((CheckBox)IN).Checked != (num != 0))
			{
				((CheckBox)IN).Checked = num != 0;
			}
		}
	}

	private void H(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				b b = H;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO != BM.b.BpG)
		{
			int num = Ih.ax();
			if (In.a() != num)
			{
				In.A(num);
			}
			II = If.A(num);
			c();
		}
	}

	private void h(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				C c = h;
				((Control)this).Invoke((System.Delegate)c, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO == BM.b.BpG || ((ComboBox)Io).DroppedDown)
		{
			return;
		}
		int num = -1;
		int num2 = IJ.ax();
		List<Setting.ListItems.A> val = IJ.d(0);
		for (int i = 0; i < val.Count; i++)
		{
			if (val[i].bBv == num2)
			{
				num = i;
				break;
			}
		}
		if (((ListControl)Io).SelectedIndex != num && num != -1)
		{
			((ListControl)Io).SelectedIndex = num;
		}
		if (Il != null)
		{
			this.c();
		}
	}

	private void F()
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
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		try
		{
			((CheckBox)IN).CheckedChanged -= new EventHandler(D);
			In.a(new EventHandler(c));
			((ComboBox)Io).SelectedIndexChanged -= new EventHandler(d);
			((Control)IP).MouseEnter -= new EventHandler(A);
			((Control)IP).GotFocus -= new EventHandler(e);
			((Control)IP).KeyDown -= new KeyEventHandler(A);
			((Control)IP).KeyPress -= new KeyPressEventHandler(A);
			((Control)IP).Leave -= new EventHandler(f);
			((Control)Ip).MouseEnter -= new EventHandler(A);
			((Control)Ip).GotFocus -= new EventHandler(F);
			((ComboBox)Ip).SelectedIndexChanged -= new EventHandler(E);
			((Control)Ip).KeyDown -= new KeyEventHandler(A);
			((Control)Ip).KeyPress -= new KeyPressEventHandler(A);
			((Control)Ip).Leave -= new EventHandler(f);
			((Control)IQ).MouseEnter -= new EventHandler(A);
			((Control)Iq).MouseEnter -= new EventHandler(A);
			((Control)this).MouseLeave -= new EventHandler(a);
			((Control)Iq).Click -= new EventHandler(B);
			if (IH != null)
			{
				IH.a(new EventHandler(g));
				((SettingOrSpecialObject)IH).a(new EventHandler(C));
			}
			if (Ih != null)
			{
				Ih.a(new EventHandler(H));
				((SettingOrSpecialObject)Ih).a(new EventHandler(C));
			}
			if (IJ != null)
			{
				IJ.a(new EventHandler(h));
			}
			if (Ij != null)
			{
				Ij.a(new EventHandler(G));
				((SettingOrSpecialObject)Ij).a(new EventHandler(C));
			}
			BM.QQ.b(new EventHandler(b));
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		F();
		if (BM.SR == Iq)
		{
			BM.SR = null;
		}
		try
		{
			((ContainerControl)this).Dispose(disposing);
		}
		catch
		{
		}
	}
}
