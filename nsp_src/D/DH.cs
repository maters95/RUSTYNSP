using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;
using c;

namespace D;

internal class DH : cq
{
	private Rectangle BxO;

	internal DH(Rectangle P_0, bool P_1, bool P_2)
		: base(P_0, P_1, P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		BxO = P_0;
	}

	internal new void A(bool P_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		int left = 5;
		int num = 5;
		Label val = new Label();
		((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LZ();
		((Control)val).ForeColor = BM.tf;
		((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8f, (FontStyle)1);
		((Control)val).BackColor = Color.Transparent;
		((Control)val).AutoSize = true;
		((Control)val).Left = 5;
		((Control)val).Top = 5;
		num = ((Control)val).Bottom + 10;
		if (P_0)
		{
			((Control)base.B()).Controls.Add((Control)(object)val);
		}
		else
		{
			((Component)val).Dispose();
		}
		List<int> val2 = new List<int>();
		val2.Add(1501);
		val2.Add(1502);
		val2.Add(3800);
		for (int i = 0; i < val2.Count; i++)
		{
			Setting setting = BM.Qz.A(val2[i]);
			if (setting == null || setting.am() || setting.al() || setting.aN())
			{
				continue;
			}
			if (setting.U())
			{
				ct ct = new ct(setting.C(), BM.Qz, BM.Qn, null, false);
				((Control)ct).Left = left;
				((Control)ct).Top = num - 3;
				num = ((Control)ct).Bottom + 2;
				if (P_0)
				{
					((Control)base.B()).Controls.Add((Control)(object)ct);
				}
				else
				{
					((Component)ct).Dispose();
				}
			}
			else if (setting.L().Count != 0)
			{
				cu cu = new cu(setting.C(), BM.Qz, BM.Qn, null, false, true, false);
				((Control)cu).Left = left;
				((Control)cu).Top = num;
				num = ((Control)cu).Bottom + 7;
				if (P_0)
				{
					((Control)base.B()).Controls.Add((Control)(object)cu);
				}
				else
				{
					((Component)cu).Dispose();
				}
			}
			else
			{
				DE dE = new DE(setting.C(), BM.Qz, BM.Qn, null, false, false, false);
				((Control)dE).Left = left;
				((Control)dE).Top = num;
				num = ((Control)dE).Bottom + 7;
				if (P_0)
				{
					((Control)base.B()).Controls.Add((Control)(object)dE);
				}
				else
				{
					((Component)dE).Dispose();
				}
			}
		}
		B();
		if (P_0)
		{
			if (BxO != Rectangle.Empty)
			{
				((Control)this).Width = ((Rectangle)(ref BxO)).Width;
				((Control)this).Height = ((Rectangle)(ref BxO)).Height;
				((Control)this).Left = ((Rectangle)(ref BxO)).Left;
				((Control)this).Top = ((Rectangle)(ref BxO)).Top;
			}
			else
			{
				int num2 = 0;
				int num3 = 0;
				foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
				{
					Control val3 = item;
					num2 = Math.Max(num2, val3.Right + 10);
					num3 = Math.Max(num3, val3.Bottom + 10);
				}
				((Control)this).Width = num2;
				((Control)this).Height = num3;
			}
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
	}

	private new void B()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		int num = -2147483648;
		int num2 = 2147483647;
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is cu)
			{
				cu cu = (cu)(object)val;
				if (cu.b() > num)
				{
					num = cu.b();
				}
				if (cu.b() < num2)
				{
					num2 = cu.b();
				}
			}
			else if (val is DE)
			{
				DE dE = (DE)(object)val;
				if (dE.b() > num)
				{
					num = dE.b();
				}
				if (dE.b() < num2)
				{
					num2 = dE.b();
				}
			}
		}
		if (num2 == num || num == -2147483648)
		{
			return;
		}
		foreach (Control item2 in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val2 = item2;
			if (val2 is cu)
			{
				((cu)(object)val2).A(num);
			}
			else if (val2 is DE)
			{
				((DE)(object)val2).A(num);
			}
		}
	}
}
internal class Dh : cq
{
	private new delegate void A(object P_0, EventArgs P_1);

	private new delegate void a(object P_0, EventArgs P_1);

	private new delegate void B(object P_0, EventArgs P_1);

	private new delegate void b(object P_0, EventArgs P_1);

	internal new class C : Form
	{
		private delegate void A(object P_0, EventArgs P_1);

		private delegate void a(object P_0, EventArgs P_1);

		private Framework bBQ;

		private Setting bBq;

		private Label bBR;

		private Panel bBr;

		private RadioButton bBS;

		private RadioButton bBs;

		private Dh bBT;

		private ThemedButton bBt;

		private ThemedButton bBU;

		internal C(Framework P_0, Setting P_1)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected O, but got Unknown
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Expected O, but got Unknown
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Unknown result type (might be due to invalid IL or missing references)
			global::A.A.A((global::A.D)A);
			BM.D(new EventHandler(A));
			bBQ = P_0;
			bBq = P_1;
			bBq.A(new EventHandler(a));
			((Control)this).BackColor = BM.td;
			((Control)this).ForeColor = BM.te;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJM();
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).ControlBox = false;
			((Form)this).MinimizeBox = false;
			((Form)this).MaximizeBox = false;
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			bBR = new Label();
			((Control)bBR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJm();
			((Control)bBR).ForeColor = BM.te;
			((Control)bBR).AutoSize = true;
			((Control)bBR).Left = 5;
			((Control)bBR).Top = 10;
			((Control)this).Controls.Add((Control)(object)bBR);
			bBr = new Panel();
			bBr.BorderStyle = (BorderStyle)0;
			((Control)bBr).Left = 5;
			((Control)bBr).Top = ((Control)bBR).Top + ((Control)bBR).Height + 5;
			bBS = new RadioButton();
			((Control)bBS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJN();
			((Control)bBS).ForeColor = BM.te;
			((Control)bBS).AutoSize = true;
			((Control)bBS).Left = 5;
			((Control)bBS).Top = 5;
			bBS.Checked = false;
			bBS.CheckedChanged += new EventHandler(B);
			((Control)bBr).Controls.Add((Control)(object)bBS);
			bBs = new RadioButton();
			((Control)bBs).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJn();
			((Control)bBs).ForeColor = BM.te;
			((Control)bBs).AutoSize = true;
			((Control)bBs).Left = 5;
			((Control)bBs).Top = ((Control)bBS).Top + ((Control)bBS).Height + 5;
			bBs.Checked = true;
			bBs.CheckedChanged += new EventHandler(b);
			((Control)bBr).Controls.Add((Control)(object)bBs);
			((Control)bBr).Width = ((Control)bBS).Left + ((Control)bBS).Width + 5;
			((Control)bBr).Height = ((Control)bBs).Top + ((Control)bBs).Height + 5;
			((Control)this).Controls.Add((Control)(object)bBr);
			bBT = new Dh(bBQ, Rectangle.Empty, false);
			bBT.b();
			((Control)bBT).Left = 5;
			((Control)bBT).Top = ((Control)bBr).Top + ((Control)bBr).Height + 5;
			((Control)this).Controls.Add((Control)(object)bBT);
			bBU = new ThemedButton();
			((Button)bBU).DialogResult = (DialogResult)2;
			((Control)bBU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yF();
			((Control)bBU).Enabled = true;
			((Control)bBU).Size = new Size(80, 30);
			((Control)bBU).Left = 5 + ((Control)bBT).Width - ((Control)bBU).Width;
			((Control)bBU).Top = ((Control)bBT).Top + ((Control)bBT).Height + 10;
			((Control)this).Controls.Add((Control)(object)bBU);
			bBt = new ThemedButton();
			((Button)bBt).DialogResult = (DialogResult)1;
			((Control)bBt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((Control)bBt).Enabled = false;
			((Control)bBt).Size = new Size(80, 30);
			((Control)bBt).Left = ((Control)bBU).Left - 5 - ((Control)bBt).Width;
			((Control)bBt).Top = ((Control)bBU).Top;
			((Control)this).Controls.Add((Control)(object)bBt);
			((Form)this).ClientSize = new Size(5 + ((Control)bBT).Width + 5, ((Control)bBt).Top + ((Control)bBt).Height + 5);
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			try
			{
				global::A.A.a((global::A.D)A);
				BM.d(new EventHandler(A));
				bBq.a(new EventHandler(a));
				bBS.CheckedChanged -= new EventHandler(B);
				bBs.CheckedChanged -= new EventHandler(b);
				((Form)this).Dispose(disposing);
			}
			catch
			{
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = A;
					((Control)this).BeginInvoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (!BM.A(bBQ.aXc, true) && !((Control)this).IsDisposed)
			{
				((Form)this).Close();
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = this.a;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			bool flag = bBq.ax() == 0;
			bool flag2 = bBq.ax() == 2;
			bBS.Checked = flag;
			bBs.Checked = !flag;
			((Control)bBt).Enabled = !flag2;
		}

		private void B(object P_0, EventArgs P_1)
		{
			if (((RadioButton)((P_0 is RadioButton) ? P_0 : null)).Checked)
			{
				bBq.a(0, true);
			}
			else
			{
				bBq.a(2, true);
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (((RadioButton)((P_0 is RadioButton) ? P_0 : null)).Checked)
			{
				bBq.a(2, true);
			}
			else
			{
				bBq.a(0, true);
			}
		}
	}

	private Framework Bxo;

	private Rectangle BxP;

	private Setting Bxp;

	private Setting BxQ;

	private Setting Bxq;

	private Label BxR = new Label();

	private ThemedTextBox Bxr = new ThemedTextBox();

	private Label BxS = new Label();

	private ThemedTextBox Bxs = new ThemedTextBox();

	private ThemedButton BxT = new ThemedButton();

	private Label Bxt = new Label();

	private Label BxU = new Label();

	private bool Bxu;

	private string BxV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHY();

	private string Bxv = string.Empty;

	internal Dh(Framework P_0, Rectangle P_1, bool P_2)
		: base(P_1, P_2, false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		global::A.A.A((global::A.D)B);
		BM.D(new EventHandler(B));
		Bxo = P_0;
		BxP = P_1;
		Bxp = Bxo.A(10195);
		if (Bxp != null)
		{
			if (Bxo.B() && Bxo.b() && Bxp.J())
			{
				Bxu = true;
			}
			else
			{
				Bxp.A(new EventHandler(b));
			}
		}
		BxQ = Bxo.A(9869);
		if (BxQ != null && !Bxu)
		{
			BxQ.A(new EventHandler(C));
		}
		Bxq = Bxo.A(9828);
		if (Bxq != null && !Bxu)
		{
			Bxq.A(new EventHandler(c));
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		try
		{
			global::A.A.a((global::A.D)B);
			BM.d(new EventHandler(B));
			((Control)BxT).Click -= new EventHandler(D);
			if (Bxp != null && !Bxu)
			{
				Bxp.a(new EventHandler(b));
			}
			if (BxQ != null && !Bxu)
			{
				BxQ.a(new EventHandler(C));
			}
			if (Bxq != null && !Bxu)
			{
				Bxq.a(new EventHandler(c));
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private new string B()
	{
		string result = null;
		if (Bxq != null)
		{
			try
			{
				Encoding encoding = Encoding.GetEncoding(20127);
				byte[] array = new byte[32];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Bxq.l(i);
				}
				result = encoding.GetString(array).TrimEnd('\0');
			}
			catch
			{
				result = null;
			}
		}
		return result;
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = B;
				((Control)this).BeginInvoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (!BM.A(Bxo.aXc, true))
		{
			((Control)Bxt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = b;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		bool flag = Bxp != null && Bxp.ax() != 0;
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			item.Enabled = flag;
		}
		if (flag)
		{
			string text = B();
			if (text != null)
			{
				((Control)Bxr).Text = text;
			}
		}
		if (((Control)Bxr).Enabled)
		{
			((Control)Bxr).BackColor = BM.to;
			((Control)Bxr).ForeColor = BM.te;
		}
		else
		{
			((Control)Bxr).BackColor = BM.tQ;
			((Control)Bxr).ForeColor = BM.tq;
		}
		if (((Control)Bxs).Enabled)
		{
			((Control)Bxs).BackColor = BM.to;
			((Control)Bxs).ForeColor = BM.te;
		}
		else
		{
			((Control)Bxs).BackColor = BM.tQ;
			((Control)Bxs).ForeColor = BM.tq;
		}
	}

	private void C(object P_0, EventArgs P_1)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b = C;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BxQ != null)
		{
			((Control)Bxt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHy() + BxQ.aX().Item1;
		}
	}

	private void c(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				b b = c;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (Bxq != null)
		{
			string text = B();
			if (Bxp != null && Bxp.ax() != 0 && text != null && ((Control)Bxr).Text != text && Bxv != text)
			{
				((Control)Bxr).Text = text;
			}
			Bxv = text;
		}
	}

	internal new void b()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		int top = 5;
		bool enabled = Bxp != null && Bxp.ax() != 0 && !Bxu;
		Label val = new Label();
		if (Bxu)
		{
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHZ();
		}
		else
		{
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHz();
		}
		((Control)val).ForeColor = BM.te;
		((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8f, (FontStyle)1);
		((Control)val).AutoSize = true;
		((Control)val).Left = 5;
		((Control)val).Top = top;
		((Control)val).Enabled = enabled;
		((Control)base.B()).Controls.Add((Control)(object)val);
		top = ((Control)val).Bottom + 20;
		((Control)BxR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhA();
		((Control)BxR).ForeColor = BM.te;
		((Control)BxR).Height = (int)((float)((Control)BxR).Height * 0.7f);
		((Control)BxR).Width = 80;
		((Control)BxR).Left = 5;
		((Control)BxR).Top = top + 3;
		((Control)BxR).Enabled = enabled;
		((Control)base.B()).Controls.Add((Control)(object)BxR);
		string text = B();
		((TextBoxBase)Bxr).MaxLength = 32;
		if (text != null)
		{
			((Control)Bxr).Text = text;
		}
		((Control)Bxr).Left = 100;
		((Control)Bxr).Top = top;
		((Control)Bxr).Width = 200;
		((Control)Bxr).Enabled = enabled;
		if (((Control)Bxr).Enabled)
		{
			((Control)Bxr).BackColor = BM.to;
			((Control)Bxr).ForeColor = BM.te;
		}
		else
		{
			((Control)Bxr).BackColor = BM.tQ;
			((Control)Bxr).ForeColor = BM.tq;
		}
		((Control)base.B()).Controls.Add((Control)(object)Bxr);
		top = ((Control)Bxr).Bottom + 10;
		((Control)BxS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGz();
		((Control)BxS).ForeColor = BM.te;
		((Control)BxS).Height = (int)((float)((Control)BxS).Height * 0.7f);
		((Control)BxS).Width = 80;
		((Control)BxS).Left = 5;
		((Control)BxS).Top = top + 3;
		((Control)BxS).Enabled = enabled;
		((Control)base.B()).Controls.Add((Control)(object)BxS);
		((TextBox)Bxs).UseSystemPasswordChar = true;
		((TextBoxBase)Bxs).MaxLength = 64;
		((Control)Bxs).Left = 100;
		((Control)Bxs).Top = top;
		((Control)Bxs).Width = 200;
		((Control)Bxs).Enabled = enabled;
		if (((Control)Bxs).Enabled)
		{
			((Control)Bxs).BackColor = BM.to;
			((Control)Bxs).ForeColor = BM.te;
		}
		else
		{
			((Control)Bxs).BackColor = BM.tQ;
			((Control)Bxs).ForeColor = BM.tq;
		}
		((Control)base.B()).Controls.Add((Control)(object)Bxs);
		top = ((Control)Bxs).Bottom + 10;
		((Control)Bxt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BHy();
		((Control)Bxt).ForeColor = BM.te;
		((Control)Bxt).Height = (int)((float)((Control)Bxt).Height * 0.7f);
		((Control)Bxt).Width = ((Control)Bxs).Left + ((Control)Bxs).Width;
		((Control)Bxt).Left = 5;
		((Control)Bxt).Top = top + 3;
		((Control)Bxt).Enabled = enabled;
		((Control)base.B()).Controls.Add((Control)(object)Bxt);
		top = ((Control)Bxt).Bottom + 10;
		((Control)BxU).Text = BxV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
		((Control)BxU).ForeColor = BM.te;
		((Control)BxU).Height = 2 * (int)((float)((Control)BxU).Height * 0.7f);
		((Control)BxU).Width = ((Control)Bxt).Width;
		((Control)BxU).Left = 5;
		((Control)BxU).Top = top + 3;
		((Control)BxU).Enabled = enabled;
		((Control)base.B()).Controls.Add((Control)(object)BxU);
		top = ((Control)BxU).Bottom + 5;
		((Control)BxT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bha();
		((Control)BxT).Width = 170;
		((Control)BxT).Height = 30;
		((Control)BxT).Left = 5;
		((Control)BxT).Top = top + 10;
		((Control)BxT).Click += new EventHandler(D);
		((Control)BxT).Enabled = enabled;
		((Control)base.B()).Controls.Add((Control)(object)BxT);
		if (BxP != Rectangle.Empty)
		{
			((Control)this).Width = ((Rectangle)(ref BxP)).Width;
			((Control)this).Height = ((Rectangle)(ref BxP)).Height;
			((Control)this).Left = ((Rectangle)(ref BxP)).Left;
			((Control)this).Top = ((Rectangle)(ref BxP)).Top;
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val2 = item;
				num = Math.Max(num, val2.Right + 20);
				num2 = Math.Max(num2, val2.Bottom + 20);
			}
			((Control)this).Width = num;
			((Control)this).Height = num2;
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
	}

	private void D(object P_0, EventArgs P_1)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		if (!BM.A(Bxo.aXc, true))
		{
			((Control)BxU).Text = BxV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhB();
		}
		else
		{
			if (Bxu)
			{
				return;
			}
			((Control)BxU).Text = BxV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
			string text = ((Control)Bxr).Text;
			string text2 = ((Control)Bxs).Text;
			if (text.Length == 0)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhb(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (cB.A(text))
			{
				string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
				for (int i = 0; i < cB.Bds.Length; i++)
				{
					System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(text3);
					System.ReadOnlySpan<char> readOnlySpan2 = string.op_Implicit(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG());
					char c = cB.Bds[i];
					text3 = string.Concat(readOnlySpan, readOnlySpan2, new System.ReadOnlySpan<char>(ref c));
				}
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhC() + text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			bool flag = true;
			for (int j = 0; j < text.Length; j++)
			{
				if (text[j] != ' ')
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhc(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (text2.Length < 8)
			{
				bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhD(), (object)8), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			global::A.A.A(Bxo.aXc, text, text2, out var _);
			if (cB.a(text, text2))
			{
				((Control)BxU).Text = BxV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g();
			}
			else
			{
				((Control)BxU).Text = BxV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhd();
			}
		}
	}

	internal static void A(Framework P_0, out bool P_1)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		P_1 = false;
		if (P_0 == null)
		{
			return;
		}
		Setting setting = P_0.A(10195);
		if (setting != null && !setting.am() && setting.d(0).Count == 3 && setting.ax() == 2 && setting.t() != null)
		{
			C obj = new C(P_0, setting);
			if ((int)((Form)obj).ShowDialog((IWin32Window)(object)BM.QQ) == 2)
			{
				P_1 = true;
			}
			((Component)obj).Dispose();
		}
	}
}
