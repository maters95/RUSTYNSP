using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using NSP.UserInterface;

namespace B
{
	internal class BC : Form
	{
		internal static readonly string Nl = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ih();

		private IContainer NM;

		private ThemedComboBox Nm;

		private Label NN;

		private ThemedButton Nn;

		internal BC()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
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
			((ListControl)Nm).SelectedIndex = (BM.SG ? 1 : 0);
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			BM.SG = ((ListControl)Nm).SelectedIndex == 1;
			if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
			{
				Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
			}
			((Stream)File.Create(Nl)).Close();
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iE() + BM.SG);
			File.AppendAllLines(Nl, (System.Collections.Generic.IEnumerable<string>)val);
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && NM != null)
			{
				((System.IDisposable)NM).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Expected O, but got Unknown
			Nm = new ThemedComboBox();
			NN = new Label();
			Nn = new ThemedButton();
			((Control)this).SuspendLayout();
			((ComboBox)Nm).DrawMode = (DrawMode)1;
			((ComboBox)Nm).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)Nm).FormattingEnabled = true;
			((ComboBox)Nm).Items.AddRange(new object[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ie(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iF()
			});
			((Control)Nm).Location = new Point(12, 25);
			((Control)Nm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.@if();
			((Control)Nm).Size = new Size(380, 23);
			((Control)Nm).TabIndex = 0;
			((Control)NN).AutoSize = true;
			((Control)NN).Location = new Point(12, 9);
			((Control)NN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)NN).Size = new Size(192, 13);
			((Control)NN).TabIndex = 9;
			((Control)NN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iG();
			((Button)Nn).DialogResult = (DialogResult)2;
			((Control)Nn).Location = new Point(150, 60);
			((Control)Nn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gu();
			((Control)Nn).Size = new Size(105, 34);
			((Control)Nn).TabIndex = 1;
			((Control)Nn).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gV();
			((ButtonBase)Nn).UseVisualStyleBackColor = true;
			((Control)Nn).Click += new EventHandler(A);
			((Form)this).AcceptButton = (IButtonControl)(object)Nn;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)Nn;
			((Form)this).ClientSize = new Size(404, 101);
			((Control)this).Controls.Add((Control)(object)Nn);
			((Control)this).Controls.Add((Control)(object)NN);
			((Control)this).Controls.Add((Control)(object)Nm);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ig();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iH();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal enum Bc
	{
		NO,
		No,
		NP
	}
}
namespace b
{
	internal enum bC
	{
		zW,
		zw,
		zX,
		zx
	}
	internal enum bc
	{
		zY,
		zy
	}
}
