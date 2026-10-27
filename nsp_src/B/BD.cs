using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;

namespace B
{
	internal enum BD : byte
	{
		Np = 1,
		NQ = 2,
		Nq = 3,
		NR = 6,
		Nr = 7,
		NS = 8,
		Ns = 9,
		NT = 10,
		Nt = 11,
		NU = 12,
		Nu = 13,
		NV = 14,
		Nv = 15
	}
	internal enum Bd : byte
	{
		NW = 0,
		Nw = 1,
		NX = 2,
		Nx = 3,
		NY = 4,
		Ny = 5,
		NZ = 6,
		Nz = 7,
		nA = 8,
		na = 9,
		nB = 10,
		nb = 11,
		nC = 12,
		nc = 15,
		nD = 127
	}
}
namespace b
{
	internal enum bD
	{
		zZ,
		zz
	}
	internal class bd : Form
	{
		private bool aAA;

		private float[] aAa;

		private IContainer aAB;

		private ThemedComboBox aAb;

		private Label aAC;

		private ThemedButton aAc;

		private Label aAD;

		private ThemedComboBox aAd;

		private Label aAE;

		private ThemedComboBox aAe;

		private Label aAF;

		private ThemedComboBox aAf;

		internal bd()
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			float[] array = new float[17];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			aAa = array;
			((Form)this)._002Ector();
			aAA = true;
			A();
			((Control)this).BackColor = BM.tE;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			((ListControl)aAb).SelectedIndex = (int)DC.Bve;
			int selectedIndex = -1;
			for (int i = 0; i < aAa.Length; i++)
			{
				float num = aAa[i];
				((ComboBox)aAd).Items.Add((object)num.ToString());
				if (DC.Bvd > num - 0.0001f && DC.Bvd < num + 0.0001f)
				{
					selectedIndex = i;
				}
			}
			((ListControl)aAd).SelectedIndex = selectedIndex;
			((ListControl)aAe).SelectedIndex = (int)DC.BvF;
			((ListControl)aAf).SelectedIndex = (int)DC.BvE;
			aAA = false;
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (!aAA && ((ListControl)aAb).SelectedIndex != -1)
			{
				DC.Bve = (bC)((ListControl)aAb).SelectedIndex;
				BM.QQ.rl.F();
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (!aAA && ((ListControl)aAd).SelectedIndex != -1)
			{
				BM.QQ.rl.A(aAa[((ListControl)aAd).SelectedIndex]);
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			if (!aAA && ((ListControl)aAe).SelectedIndex != -1)
			{
				DC.BvF = (DC.Bvf = (bc)((ListControl)aAe).SelectedIndex);
				BM.QQ.rl.f();
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			if (aAA || ((ListControl)aAf).SelectedIndex == -1)
			{
				return;
			}
			DC.BvE = (bD)((ListControl)aAf).SelectedIndex;
			if (BM.Qz == null || !BM.Qz.c())
			{
				return;
			}
			Enumerator<Table> enumerator = BM.Qz.aWV.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Table current = enumerator.Current;
					switch (DC.BvE)
					{
					case bD.zZ:
						if (!current.InvertRows)
						{
							current.InvertRows = true;
						}
						break;
					case bD.zz:
						if (current.InvertRows)
						{
							current.InvertRows = false;
						}
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aAB != null)
			{
				((System.IDisposable)aAB).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected O, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected O, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Expected O, but got Unknown
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Expected O, but got Unknown
			//IL_0415: Unknown result type (might be due to invalid IL or missing references)
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_050b: Expected O, but got Unknown
			//IL_0522: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0605: Expected O, but got Unknown
			aAb = new ThemedComboBox();
			aAC = new Label();
			aAc = new ThemedButton();
			aAD = new Label();
			aAd = new ThemedComboBox();
			aAE = new Label();
			aAe = new ThemedComboBox();
			aAF = new Label();
			aAf = new ThemedComboBox();
			((Control)this).SuspendLayout();
			((ComboBox)aAb).DrawMode = (DrawMode)1;
			((ComboBox)aAb).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aAb).FormattingEnabled = true;
			((ComboBox)aAb).Items.AddRange(new object[4]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ib(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAM(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAm(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAN()
			});
			((Control)aAb).Location = new Point(183, 12);
			((Control)aAb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAn();
			((Control)aAb).Size = new Size(240, 23);
			((Control)aAb).TabIndex = 0;
			((ComboBox)aAb).SelectedIndexChanged += new EventHandler(A);
			((Control)aAC).AutoSize = true;
			((Control)aAC).Location = new Point(7, 16);
			((Control)aAC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)aAC).Size = new Size(102, 13);
			((Control)aAC).TabIndex = 3;
			((Control)aAC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAO();
			((Button)aAc).DialogResult = (DialogResult)2;
			((Control)aAc).Location = new Point(165, 138);
			((Control)aAc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gu();
			((Control)aAc).Size = new Size(105, 34);
			((Control)aAc).TabIndex = 4;
			((Control)aAc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gV();
			((ButtonBase)aAc).UseVisualStyleBackColor = true;
			((Control)aAc).Click += new EventHandler(C);
			((Control)aAD).AutoSize = true;
			((Control)aAD).Location = new Point(7, 47);
			((Control)aAD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)aAD).Size = new Size(143, 13);
			((Control)aAD).TabIndex = 4;
			((Control)aAD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAo();
			((ComboBox)aAd).DrawMode = (DrawMode)1;
			((ComboBox)aAd).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aAd).FormattingEnabled = true;
			((Control)aAd).Location = new Point(183, 43);
			((Control)aAd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAP();
			((Control)aAd).Size = new Size(240, 23);
			((Control)aAd).TabIndex = 1;
			((ComboBox)aAd).SelectedIndexChanged += new EventHandler(a);
			((Control)aAE).AutoSize = true;
			((Control)aAE).Location = new Point(7, 78);
			((Control)aAE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)aAE).Size = new Size(172, 13);
			((Control)aAE).TabIndex = 8;
			((Control)aAE).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAp();
			((ComboBox)aAe).DrawMode = (DrawMode)1;
			((ComboBox)aAe).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aAe).FormattingEnabled = true;
			((ComboBox)aAe).Items.AddRange(new object[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAQ(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAq()
			});
			((Control)aAe).Location = new Point(183, 74);
			((Control)aAe).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAR();
			((Control)aAe).Size = new Size(240, 23);
			((Control)aAe).TabIndex = 2;
			((ComboBox)aAe).SelectedIndexChanged += new EventHandler(B);
			((Control)aAF).AutoSize = true;
			((Control)aAF).Location = new Point(7, 109);
			((Control)aAF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)aAF).Size = new Size(107, 13);
			((Control)aAF).TabIndex = 12;
			((Control)aAF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAr();
			((ComboBox)aAf).DrawMode = (DrawMode)1;
			((ComboBox)aAf).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aAf).FormattingEnabled = true;
			((ComboBox)aAf).Items.AddRange(new object[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAS(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAs()
			});
			((Control)aAf).Location = new Point(182, 105);
			((Control)aAf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAT();
			((Control)aAf).Size = new Size(240, 23);
			((Control)aAf).TabIndex = 3;
			((ComboBox)aAf).SelectedIndexChanged += new EventHandler(b);
			((Form)this).AcceptButton = (IButtonControl)(object)aAc;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)aAc;
			((Form)this).ClientSize = new Size(434, 183);
			((Control)this).Controls.Add((Control)(object)aAf);
			((Control)this).Controls.Add((Control)(object)aAF);
			((Control)this).Controls.Add((Control)(object)aAE);
			((Control)this).Controls.Add((Control)(object)aAe);
			((Control)this).Controls.Add((Control)(object)aAD);
			((Control)this).Controls.Add((Control)(object)aAd);
			((Control)this).Controls.Add((Control)(object)aAc);
			((Control)this).Controls.Add((Control)(object)aAC);
			((Control)this).Controls.Add((Control)(object)aAb);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAt();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pg();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
