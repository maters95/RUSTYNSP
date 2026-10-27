using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.SettingsFramework;

namespace NSP.UserInterface.Forms;

public class AddComponentForm : Form
{
	internal class A
	{
		internal Label BOB;

		internal List<a> BOb;
	}

	internal class a : Panel
	{
		private bool BOC;

		private bool BOc;

		internal int BOD;

		internal a()
		{
		}

		[SpecialName]
		internal bool A()
		{
			return BOC;
		}

		[SpecialName]
		internal void A(bool P_0)
		{
			BOC = P_0;
			((Control)this).Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			if (A())
			{
				e.Graphics.Clear(Color.DodgerBlue);
			}
			else
			{
				e.Graphics.Clear(Color.WhiteSmoke);
			}
			if (BOc)
			{
				Pen val = new Pen(Color.DodgerBlue, 2f);
				try
				{
					e.Graphics.DrawRectangle(val, 1, 1, ((Control)this).Width - 2, ((Control)this).Height - 2);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			((Control)this).OnPaint(e);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			((Control)this).OnMouseClick(e);
		}
	}

	private const int MP = 10;

	private const int Mp = 20;

	private a MQ;

	[CompilerGenerated]
	private int Mq;

	private int MR;

	private int Mr;

	private int MS;

	private int Ms;

	private List<Setting.ListItems.A> MT;

	private List<A> Mt = new List<A>();

	private const int MU = 0;

	private IContainer Mu;

	private TableLayoutPanelWithThemedScrollBars MV;

	private Panel Mv;

	private ThemedButton MW;

	private ThemedButton Mw;

	private W MX;

	[SpecialName]
	[CompilerGenerated]
	internal int A()
	{
		return Mq;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(int P_0)
	{
		Mq = P_0;
	}

	internal AddComponentForm(List<Setting.ListItems.A> P_0)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		e();
		((Control)this).BackColor = BM.td;
		((Control)this).ForeColor = BM.te;
		((Control)MV).BackColor = ((Control)this).BackColor;
		((Control)Mv).BackColor = ((Control)this).BackColor;
		((Control)MX).BackColor = BM.tg;
		MT = P_0;
		MQ = null;
		A(0);
	}

	private void a()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<A> enumerator = Mt.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				((Component)current.BOB).Dispose();
				Enumerator<a> enumerator2 = current.BOb.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						a current2 = enumerator2.Current;
						A((Control)(object)current2);
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
	}

	private void A(List<Setting.ListItems.A> P_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		List<string> val = new List<string>();
		List<int> val2 = new List<int>();
		Enumerator<Setting.ListItems.A> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Setting.ListItems.A current = enumerator.Current;
				if (current.bBx != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ib() && current.bBx != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay() && current.bBX != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
				{
					if (!val.Contains(current.bBx))
					{
						val.Add(current.bBx);
						val2.Add(0);
					}
					int num = val.IndexOf(current.bBx);
					int num2 = num;
					int num3 = val2[num2];
					val2[num2] = num3 + 1;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		List<int> val3 = new List<int>();
		for (int i = 0; i < val.Count; i++)
		{
			val3.Add(0);
		}
		MR = 0;
		Mr = 0;
		enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Setting.ListItems.A current2 = enumerator.Current;
				if (current2.bBX != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay() && current2.bBx != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ib() && current2.bBx != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay() && val.Contains(current2.bBx))
				{
					Image val4 = BM.Qz.a(current2.bBX);
					if (val4 != null)
					{
						MR = Math.Max(MR, val4.Width);
						Mr = Math.Max(Mr, val4.Height);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Mr += 20;
		int num4 = 0;
		for (int j = 0; j < val.Count; j++)
		{
			num4 = Math.Max(num4, val2[j]);
		}
		Font font = new Font(((Control)this).Font.FontFamily, 12f, (FontStyle)1);
		for (int k = 0; k < val.Count; k++)
		{
			if (val2[k] > 0)
			{
				Label bOB = new Label
				{
					Height = ((k == 0) ? 20 : 40),
					Text = ((object)val[k]).ToString(),
					TextAlign = (ContentAlignment)256,
					AutoSize = false,
					BackColor = ((Control)MX).BackColor,
					Width = MR,
					Font = font,
					ForeColor = BM.te
				};
				A a = new A();
				a.BOB = bOB;
				a.BOb = new List<a>();
				Mt.Add(a);
			}
		}
		enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Setting.ListItems.A current3 = enumerator.Current;
				if (current3.bBX != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay() && current3.bBx != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ib() && current3.bBx != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay() && val.Contains(current3.bBx))
				{
					Image val5 = BM.Qz.a(current3.bBX);
					if (val5 != null)
					{
						int num5 = val.IndexOf(current3.bBx);
						PictureBox val6 = new PictureBox
						{
							Size = new Size(MR, Mr - 20),
							SizeMode = (PictureBoxSizeMode)3,
							Image = val5,
							Location = new Point(0, 0)
						};
						Label val7 = new Label
						{
							Size = new Size(MR, 20),
							Location = new Point(0, Mr - 20),
							Text = current3.bBV,
							TextAlign = (ContentAlignment)32,
							BackColor = ((Control)MX).BackColor,
							ForeColor = BM.te
						};
						a obj = new a();
						((Control)obj).Size = new Size(MR, Mr);
						((Control)obj).BackColor = ((Control)MX).BackColor;
						((Panel)obj).BorderStyle = (BorderStyle)1;
						((Control)obj).Tag = current3.bBv;
						a a2 = obj;
						((Control)a2).Controls.Add((Control)(object)val7);
						((Control)a2).Controls.Add((Control)(object)val6);
						Mt[num5].BOb.Add(a2);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		b();
	}

	private void A(Control P_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		if (P_0 is a)
		{
			foreach (Control item in (ArrangedElementCollection)P_0.Controls)
			{
				item.Click -= new EventHandler(a);
				item.DoubleClick -= new EventHandler(b);
				((Component)item).Dispose();
			}
			P_0.Click -= new EventHandler(a);
			P_0.DoubleClick -= new EventHandler(b);
			((Component)P_0).Dispose();
		}
		else
		{
			((Component)P_0).Dispose();
		}
	}

	private void B()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		((Control)MX).AutoSize = false;
		Enumerator<A> enumerator = Mt.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				Ms = Math.Max(Ms, current.BOb.Count);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		int num = ((MR <= 0) ? 1 : Math.Min(Ms, ((Control)MX).Width / MR));
		if (((ArrangedElementCollection)((Control)MX).Controls).Count > 0 && MS == num)
		{
			return;
		}
		MS = num;
		while (((ArrangedElementCollection)((Control)MX).Controls).Count > 0)
		{
			((Component)((Control)MX).Controls[0]).Dispose();
		}
		enumerator = Mt.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current2 = enumerator.Current;
				((Control)MX).Controls.Add((Control)(object)current2.BOB);
				Panel val = new Panel
				{
					Size = new Size(0, 0),
					Margin = new Padding(0, 0, 0, 0),
					BorderStyle = (BorderStyle)0
				};
				((Control)MX).Controls.Add((Control)(object)val);
				((FlowLayoutPanel)MX).SetFlowBreak((Control)(object)current2.BOB, true);
				a a = null;
				Enumerator<a> enumerator2 = current2.BOb.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						a current3 = enumerator2.Current;
						((Control)MX).Controls.Add((Control)(object)current3);
						a = current3;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				if (a != null)
				{
					((FlowLayoutPanel)MX).SetFlowBreak((Control)(object)a, true);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		((ScrollableControl)MX).AutoScroll = false;
		((ScrollProperties)((ScrollableControl)MX).HorizontalScroll).Enabled = false;
		((ScrollableControl)MX).AutoScroll = true;
	}

	private void b()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		((Control)MX).SuspendLayout();
		this.a();
		A(MT);
		((Control)this).MinimumSize = new Size(MR + 18, Mr * 2);
		B();
		if (((ArrangedElementCollection)((Control)MX).Controls).Count != 0)
		{
			for (int i = 0; i < ((ArrangedElementCollection)((Control)MX).Controls).Count; i++)
			{
				if (!(((Control)MX).Controls[i] is a a))
				{
					continue;
				}
				((Control)a).Click += new EventHandler(this.a);
				((Control)a).DoubleClick += new EventHandler(b);
				foreach (Control item in (ArrangedElementCollection)((Control)a).Controls)
				{
					item.Click += new EventHandler(this.a);
					item.DoubleClick += new EventHandler(b);
				}
			}
		}
		((Control)MX).ResumeLayout(true);
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		a a = null;
		if (P_0 is PictureBox)
		{
			a = ((Control)((P_0 is PictureBox) ? P_0 : null)).Parent as a;
		}
		else if (P_0 is Label)
		{
			a = ((Control)((P_0 is Label) ? P_0 : null)).Parent as a;
		}
		else if (P_0 is a)
		{
			a = P_0 as a;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)MX).Controls)
		{
			if (item is a a2 && a2 == a)
			{
				if (MQ != null)
				{
					((Control)MQ).BackColor = ((Control)MX).BackColor;
					((Panel)MQ).BorderStyle = (BorderStyle)1;
					MQ.A(false);
				}
				MQ = a2;
				a2.A(true);
				((Panel)MQ).BorderStyle = (BorderStyle)2;
				((Control)MQ).BackColor = Color.DodgerBlue;
				((Control)Mw).Enabled = true;
			}
		}
		((Control)MX).Focus();
		((ScrollableControl)MX).ScrollControlIntoView((Control)(object)a);
		MX.a();
	}

	private void C()
	{
		((Form)this).DialogResult = (DialogResult)1;
		if (MQ != null)
		{
			A((int)((Control)MQ).Tag);
		}
		a();
		((Form)this).Close();
	}

	private void B(object P_0, EventArgs P_1)
	{
		C();
	}

	private void b(object P_0, EventArgs P_1)
	{
		a(P_0, P_1);
		C();
	}

	private void C(object P_0, EventArgs P_1)
	{
		((Form)this).DialogResult = (DialogResult)2;
		a();
		((Form)this).Close();
	}

	private void A(object P_0, PreviewKeyDownEventArgs P_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		if (((ArrangedElementCollection)((Control)this).Controls).Count != 0)
		{
			P_1.IsInputKey = true;
			if ((int)P_1.KeyData == 27)
			{
				C(P_0, null);
			}
			else if ((int)P_1.KeyData == 13 || (int)P_1.KeyData == 13)
			{
				B(null, null);
			}
			else if ((int)P_1.KeyData == 9 || (int)P_1.KeyData == 39)
			{
				D();
			}
			else if ((int)P_1.KeyData == 65545 || (int)P_1.KeyData == 37)
			{
				c();
			}
			else if ((int)P_1.KeyData == 40)
			{
				E();
			}
			else if ((int)P_1.KeyData == 38)
			{
				d();
			}
		}
	}

	private void c()
	{
		if (MQ != null)
		{
			int num = ((Control)MX).Controls.IndexOf((Control)(object)MQ) - 1;
			while (num >= 0 && !(((Control)MX).Controls[num] is a))
			{
				num--;
			}
			if (num >= 0 && ((Control)MX).Controls[num] is a)
			{
				a(((Control)MX).Controls[num], null);
			}
		}
	}

	private void D()
	{
		if (MQ != null)
		{
			int i;
			for (i = ((Control)MX).Controls.IndexOf((Control)(object)MQ) + 1; i < ((ArrangedElementCollection)((Control)MX).Controls).Count - 1 && !(((Control)MX).Controls[i] is a); i++)
			{
			}
			if (i < ((ArrangedElementCollection)((Control)MX).Controls).Count && ((Control)MX).Controls[i] is a)
			{
				a(((Control)MX).Controls[i], null);
			}
		}
	}

	private void d()
	{
		if (MQ != null)
		{
			int num = ((Control)MX).Controls.IndexOf((Control)(object)MQ);
			while (num > 0 && num <= ((ArrangedElementCollection)((Control)MX).Controls).Count - 1 && ((Control)MX).Controls[num] is a)
			{
				num--;
			}
			while (num > 0 && num <= ((ArrangedElementCollection)((Control)MX).Controls).Count - 1 && !(((Control)MX).Controls[num] is a))
			{
				num--;
			}
			while (num > 0 && num <= ((ArrangedElementCollection)((Control)MX).Controls).Count - 1 && ((Control)MX).Controls[num] is a)
			{
				num--;
			}
			num++;
			if (num >= 0 && ((Control)MX).Controls[num] is a)
			{
				a(((Control)MX).Controls[num], null);
			}
		}
	}

	private void E()
	{
		if (MQ != null)
		{
			int i;
			for (i = ((Control)MX).Controls.IndexOf((Control)(object)MQ); i < ((ArrangedElementCollection)((Control)MX).Controls).Count - 1 && ((Control)MX).Controls[i] is a; i++)
			{
			}
			for (; i < ((ArrangedElementCollection)((Control)MX).Controls).Count - 1 && !(((Control)MX).Controls[i] is a); i++)
			{
			}
			if (i < ((ArrangedElementCollection)((Control)MX).Controls).Count - 1 && ((Control)MX).Controls[i] is a)
			{
				a(((Control)MX).Controls[i], null);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Mu != null)
		{
			((System.IDisposable)Mu).Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void e()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		MV = new TableLayoutPanelWithThemedScrollBars();
		Mv = new Panel();
		MW = new ThemedButton();
		Mw = new ThemedButton();
		MX = new W();
		((Control)MV).SuspendLayout();
		((Control)Mv).SuspendLayout();
		((Control)this).SuspendLayout();
		((TableLayoutPanel)MV).ColumnCount = 1;
		((TableLayoutPanel)MV).ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		((TableLayoutPanel)MV).Controls.Add((Control)(object)Mv, 0, 1);
		((TableLayoutPanel)MV).Controls.Add((Control)(object)MX, 0, 0);
		((Control)MV).Dock = (DockStyle)5;
		((Control)MV).Location = new Point(0, 0);
		((Control)MV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IC();
		((TableLayoutPanel)MV).RowCount = 2;
		((TableLayoutPanel)MV).RowStyles.Add(new RowStyle((SizeType)2, 100f));
		((TableLayoutPanel)MV).RowStyles.Add(new RowStyle((SizeType)1, 50f));
		((Control)MV).Size = new Size(1084, 621);
		((Control)MV).TabIndex = 8;
		((Control)Mv).Controls.Add((Control)(object)MW);
		((Control)Mv).Controls.Add((Control)(object)Mw);
		((Control)Mv).Dock = (DockStyle)5;
		((Control)Mv).Location = new Point(0, 571);
		((Control)Mv).Margin = new Padding(0);
		((Control)Mv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ic();
		((Control)Mv).Size = new Size(1084, 50);
		((Control)Mv).TabIndex = 0;
		((Control)MW).Anchor = (AnchorStyles)9;
		((Button)MW).DialogResult = (DialogResult)2;
		((Control)MW).Location = new Point(972, 9);
		((Control)MW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
		((Control)MW).Size = new Size(100, 30);
		((Control)MW).TabIndex = 3;
		((Control)MW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
		((ButtonBase)MW).UseVisualStyleBackColor = true;
		((Control)MW).Click += new EventHandler(C);
		((Control)Mw).Anchor = (AnchorStyles)9;
		((Control)Mw).Enabled = false;
		((Control)Mw).Location = new Point(862, 9);
		((Control)Mw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ID();
		((Control)Mw).Size = new Size(100, 30);
		((Control)Mw).TabIndex = 2;
		((Control)Mw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
		((Control)Mw).Visible = true;
		((ButtonBase)Mw).UseVisualStyleBackColor = true;
		((Control)Mw).Click += new EventHandler(B);
		((ScrollableControl)MX).AutoScroll = true;
		((Control)MX).BackColor = Color.White;
		((Panel)MX).BorderStyle = (BorderStyle)1;
		((Control)MX).Dock = (DockStyle)5;
		((Control)MX).Location = new Point(10, 10);
		((Control)MX).Margin = new Padding(0);
		((Control)MX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Id();
		((Control)MX).Size = new Size(1064, 621);
		((Control)MX).TabIndex = 4;
		((Control)MX).PreviewKeyDown += new PreviewKeyDownEventHandler(A);
		((Panel)MX).TabStop = true;
		((Control)this).AllowDrop = true;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)MW;
		((Form)this).ClientSize = new Size(1084, 621);
		((Control)this).Controls.Add((Control)(object)MV);
		((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).MinimizeBox = false;
		((Control)this).MinimumSize = new Size(500, 500);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IE();
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DU();
		((Form)this).Shown += new EventHandler(A);
		((Control)MV).ResumeLayout(false);
		((Control)Mv).ResumeLayout(false);
		((Control)Mv).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
