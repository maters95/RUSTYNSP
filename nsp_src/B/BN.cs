using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;

namespace B
{
	internal class BN
	{
		[CompilerGenerated]
		private string tx;

		[CompilerGenerated]
		private string tY;

		[CompilerGenerated]
		private Bm ty;

		[SpecialName]
		[CompilerGenerated]
		public string A()
		{
			return tx;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(string P_0)
		{
			tx = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public string a()
		{
			return tY;
		}

		[SpecialName]
		[CompilerGenerated]
		public void a(string P_0)
		{
			tY = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public Bm B()
		{
			return ty;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(Bm P_0)
		{
			ty = P_0;
		}

		public virtual int GetHashCode()
		{
			return (17 * 23 + (((object)A())?.GetHashCode() ?? 0)) * 23 + ((object)B()).GetHashCode();
		}
	}
	internal class Bn : Form
	{
		private IContainer tZ;

		private Label tz;

		private Label UA;

		private NumericUpDown Ua;

		private Label UB;

		private Label Ub;

		private Label UC;

		internal Bn()
		{
			A();
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (BM.SI.Count == 1)
			{
				global::A.A.A(BM.SI[0].BpS.ao, (uint)Ua.Value);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && tZ != null)
			{
				((System.IDisposable)tZ).Dispose();
			}
			((Form)this).Dispose(disposing);
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
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			tz = new Label();
			UA = new Label();
			Ua = new NumericUpDown();
			UB = new Label();
			Ub = new Label();
			UC = new Label();
			((ISupportInitialize)Ua).BeginInit();
			((Control)this).SuspendLayout();
			((Control)tz).AutoSize = true;
			((Control)tz).Location = new Point(12, 9);
			((Control)tz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)tz).Size = new Size(565, 13);
			((Control)tz).TabIndex = 0;
			((Control)tz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tj();
			((Control)UA).AutoSize = true;
			((Control)UA).Location = new Point(12, 27);
			((Control)UA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)UA).Size = new Size(551, 13);
			((Control)UA).TabIndex = 1;
			((Control)UA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tK();
			Ua.Increment = new decimal(new int[4] { 1024, 0, 0, 0 });
			((Control)Ua).Location = new Point(286, 49);
			Ua.Maximum = new decimal(new int[4] { 1048576, 0, 0, 0 });
			((Control)Ua).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tk();
			((Control)Ua).Size = new Size(102, 20);
			((Control)Ua).TabIndex = 0;
			Ua.ValueChanged += new EventHandler(A);
			((Control)UB).AutoSize = true;
			((Control)UB).Location = new Point(158, 52);
			((Control)UB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)UB).Size = new Size(123, 13);
			((Control)UB).TabIndex = 3;
			((Control)UB).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tL();
			((Control)Ub).AutoSize = true;
			((Control)Ub).Location = new Point(395, 52);
			((Control)Ub).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)Ub).Size = new Size(33, 13);
			((Control)Ub).TabIndex = 4;
			((Control)Ub).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tl();
			((Control)UC).AutoSize = true;
			((Control)UC).Location = new Point(177, 76);
			((Control)UC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Io();
			((Control)UC).Size = new Size(232, 13);
			((Control)UC).TabIndex = 5;
			((Control)UC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tM();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(587, 104);
			((Control)this).Controls.Add((Control)(object)UC);
			((Control)this).Controls.Add((Control)(object)Ub);
			((Control)this).Controls.Add((Control)(object)UB);
			((Control)this).Controls.Add((Control)(object)Ua);
			((Control)this).Controls.Add((Control)(object)UA);
			((Control)this).Controls.Add((Control)(object)tz);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tm();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tN();
			((ISupportInitialize)Ua).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal enum bN
	{
		aCj,
		aCK
	}
	internal enum bn
	{
		aCk,
		aCL,
		aCl
	}
}
