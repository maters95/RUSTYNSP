using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using NSP.UserInterface;
using b;
using c;

namespace B
{
	internal enum BP
	{
		uA,
		ua
	}
	internal class Bp : Form
	{
		private bool uB;

		private string ub;

		private List<string> uC = new List<string>();

		private string uc = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uc();

		private BP uD;

		private IContainer ud;

		private Label uE;

		private ThemedTextBox ue;

		private ThemedButton uF;

		private ThemedButton uf;

		private Label uG;

		private ThemedComboBox ug;

		private Label uH;

		private Label uh;

		private Label uI;

		private ThemedButton ui;

		private Label uJ;

		private ThemedComboBox uj;

		private Label uK;

		internal Bp()
		{
			c();
		}

		[SpecialName]
		internal string A()
		{
			return uc;
		}

		[SpecialName]
		internal BP a()
		{
			return uD;
		}

		[SpecialName]
		internal string B()
		{
			return ub;
		}

		[SpecialName]
		internal bool b()
		{
			return uB;
		}

		private void A(object P_0, EventArgs P_1)
		{
			uB = true;
			((Button)uF).PerformClick();
		}

		private void C()
		{
			((ComboBox)uj).Items.Clear();
			uC.Clear();
			if (Directory.Exists(cR.BlX))
			{
				string[] array = null;
				try
				{
					array = Directory.GetFiles(cR.BlX, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SV());
				}
				catch
				{
					array = null;
				}
				if (array != null)
				{
					string[] array2 = array;
					foreach (string text in array2)
					{
						((ComboBox)uj).Items.Add((object)Path.GetFileNameWithoutExtension(text));
						uC.Add(text);
					}
				}
			}
			((ListControl)uj).SelectedIndex = -1;
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (((ListControl)uj).SelectedIndex != -1 && uC.Count > ((ListControl)uj).SelectedIndex)
			{
				ub = uC[((ListControl)uj).SelectedIndex];
			}
			else
			{
				ub = null;
			}
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult == 1 && !uB && string.IsNullOrEmpty(ub))
			{
				if (((Control)ue).Text.Length == 0)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UD(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)P_1).Cancel = true;
				}
				else if (((ListControl)ug).SelectedIndex != 0 && ((ListControl)ug).SelectedIndex != 1)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ud(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)P_1).Cancel = true;
				}
				else
				{
					uc = ((Control)ue).Text;
					uD = (BP)((ListControl)ug).SelectedIndex;
				}
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			uB = false;
			ub = null;
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			((Control)uj).BackColor = BM.to;
			((Control)uj).ForeColor = BM.te;
			((Control)ug).BackColor = BM.to;
			((Control)ug).ForeColor = BM.te;
			((Control)ue).BackColor = BM.to;
			((Control)ue).ForeColor = BM.te;
			C();
			((ListControl)ug).SelectedIndex = (int)uD;
			((Control)uj).Focus();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && ud != null)
			{
				((System.IDisposable)ud).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void c()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_0511: Expected O, but got Unknown
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_054e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0604: Expected O, but got Unknown
			//IL_0619: Unknown result type (might be due to invalid IL or missing references)
			//IL_063d: Unknown result type (might be due to invalid IL or missing references)
			//IL_067b: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0798: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a2: Expected O, but got Unknown
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f4: Expected O, but got Unknown
			//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0806: Expected O, but got Unknown
			ComponentResourceManager val = new ComponentResourceManager(typeof(Bp));
			uE = new Label();
			ue = new ThemedTextBox();
			uF = new ThemedButton();
			uf = new ThemedButton();
			uG = new Label();
			ug = new ThemedComboBox();
			uH = new Label();
			uh = new Label();
			uI = new Label();
			ui = new ThemedButton();
			uJ = new Label();
			uj = new ThemedComboBox();
			uK = new Label();
			((Control)this).SuspendLayout();
			((Control)uE).AutoSize = true;
			((Control)uE).Location = new Point(10, 134);
			((Control)uE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)uE).Size = new Size(142, 13);
			((Control)uE).TabIndex = 0;
			((Control)uE).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UE();
			((Control)ue).Location = new Point(12, 150);
			((Control)ue).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ue();
			((Control)ue).Size = new Size(257, 22);
			((Control)ue).TabIndex = 2;
			((Button)uF).DialogResult = (DialogResult)1;
			((Control)uF).Location = new Point(33, 372);
			((Control)uF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)uF).Size = new Size(100, 30);
			((Control)uF).TabIndex = 4;
			((Control)uF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)uF).UseVisualStyleBackColor = true;
			((Button)uf).DialogResult = (DialogResult)2;
			((Control)uf).Location = new Point(151, 372);
			((Control)uf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)uf).Size = new Size(100, 30);
			((Control)uf).TabIndex = 5;
			((Control)uf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)uf).UseVisualStyleBackColor = true;
			((Control)uG).AutoSize = true;
			((Control)uG).Location = new Point(10, 179);
			((Control)uG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)uG).Size = new Size(123, 13);
			((Control)uG).TabIndex = 4;
			((Control)uG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UF();
			((ComboBox)ug).DrawMode = (DrawMode)1;
			((ComboBox)ug).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)ug).FormattingEnabled = true;
			((ComboBox)ug).Items.AddRange(new object[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uf(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UG()
			});
			((Control)ug).Location = new Point(12, 195);
			((ComboBox)ug).MaxDropDownItems = 2;
			((Control)ug).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ug();
			((Control)ug).Size = new Size(257, 23);
			((Control)ug).TabIndex = 3;
			((Control)uH).AutoSize = true;
			((Control)uH).Location = new Point(5, 225);
			((Control)uH).MaximumSize = new Size(273, 0);
			((Control)uH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)uH).Size = new Size(273, 78);
			((Control)uH).TabIndex = 6;
			((Control)uH).Text = ((ResourceManager)val).GetString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UH());
			((Control)uh).AutoSize = true;
			((Control)uh).Location = new Point(5, 310);
			((Control)uh).MaximumSize = new Size(273, 0);
			((Control)uh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GF();
			((Control)uh).Size = new Size(267, 52);
			((Control)uh).TabIndex = 11;
			((Control)uh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uh();
			((Control)uI).AutoSize = true;
			((Control)uI).Location = new Point(99, 55);
			((Control)uI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)uI).Size = new Size(94, 13);
			((Control)uI).TabIndex = 13;
			((Control)uI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UI();
			((Control)ui).Location = new Point(67, 70);
			((Control)ui).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ui();
			((Control)ui).Size = new Size(156, 25);
			((Control)ui).TabIndex = 1;
			((Control)ui).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UJ();
			((ButtonBase)ui).UseVisualStyleBackColor = true;
			((Control)ui).Click += new EventHandler(A);
			((Control)uJ).AutoSize = true;
			((Control)uJ).Location = new Point(66, 114);
			((Control)uJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Io();
			((Control)uJ).Size = new Size(158, 13);
			((Control)uJ).TabIndex = 19;
			((Control)uJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uj();
			((ComboBox)uj).DrawMode = (DrawMode)1;
			((ComboBox)uj).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)uj).FormattingEnabled = true;
			((Control)uj).Location = new Point(12, 23);
			((ComboBox)uj).MaxDropDownItems = 100;
			((Control)uj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UK();
			((Control)uj).Size = new Size(257, 23);
			((Control)uj).TabIndex = 0;
			((ComboBox)uj).SelectedIndexChanged += new EventHandler(a);
			((Control)uK).AutoSize = true;
			((Control)uK).Location = new Point(10, 7);
			((Control)uK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ip();
			((Control)uK).Size = new Size(115, 13);
			((Control)uK).TabIndex = 22;
			((Control)uK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Uk();
			((Form)this).AcceptButton = (IButtonControl)(object)uF;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)uf;
			((Form)this).ClientSize = new Size(282, 410);
			((Control)this).Controls.Add((Control)(object)uK);
			((Control)this).Controls.Add((Control)(object)uj);
			((Control)this).Controls.Add((Control)(object)uJ);
			((Control)this).Controls.Add((Control)(object)ui);
			((Control)this).Controls.Add((Control)(object)uI);
			((Control)this).Controls.Add((Control)(object)uh);
			((Control)this).Controls.Add((Control)(object)uH);
			((Control)this).Controls.Add((Control)(object)ug);
			((Control)this).Controls.Add((Control)(object)uG);
			((Control)this).Controls.Add((Control)(object)uf);
			((Control)this).Controls.Add((Control)(object)uF);
			((Control)this).Controls.Add((Control)(object)ue);
			((Control)this).Controls.Add((Control)(object)uE);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UL();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ul();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(B);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal enum bP
	{
		aCo,
		aCP,
		aCp
	}
	internal enum bp
	{
		aCQ,
		aCq
	}
}
