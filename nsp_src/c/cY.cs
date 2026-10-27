using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using C;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;

namespace c
{
	internal class cY : ThemedComboBox
	{
		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			if (((ListControl)this).SelectedIndex >= 0)
			{
				SolidBrush val = new SolidBrush(co.BKu[((ListControl)this).SelectedIndex]);
				try
				{
					e.Graphics.FillRectangle((Brush)(object)val, e.ClipRectangle);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			Pen val2 = new Pen(Brushes.Black, 1f);
			try
			{
				Graphics graphics = e.Graphics;
				Rectangle clipRectangle = e.ClipRectangle;
				int x = ((Rectangle)(ref clipRectangle)).X;
				clipRectangle = e.ClipRectangle;
				int y = ((Rectangle)(ref clipRectangle)).Y;
				clipRectangle = e.ClipRectangle;
				int num = ((Rectangle)(ref clipRectangle)).Width - 1;
				clipRectangle = e.ClipRectangle;
				graphics.DrawRectangle(val2, x, y, num, ((Rectangle)(ref clipRectangle)).Height - 1);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
	}
	internal class cy : Cc
	{
		internal cy(Framework P_0, string P_1)
			: base(P_0, null, P_1, null, null, -1, false)
		{
		}

		public override void A(Setting P_0, Framework P_1, Framework P_2, List<int[]> P_3, List<int[]> P_4, bool P_5)
		{
			if (A(P_0, P_4, P_1, P_2) && ((SettingOrSpecialObject)P_0).D() != null && ((SettingOrSpecialObject)P_0).D().D() != null && ((SettingOrSpecialObject)P_0).D() is TableAxis && ((SettingOrSpecialObject)P_0).D().D() is Table)
			{
				TableAxis tableAxis = ((SettingOrSpecialObject)P_0).D() as TableAxis;
				if (P_0 == tableAxis.G())
				{
					(((SettingOrSpecialObject)P_0).D().D() as Table).SortByAxis(tableAxis.A(), P_5);
				}
			}
		}
	}
}
namespace C
{
	internal class CY
	{
		internal string BdE;

		internal string Bde;

		internal List<CX> BdF = new List<CX>();

		internal List<Cx> Bdf = new List<Cx>();

		internal k A(int P_0, int P_1)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 == 22 && P_1 == 14)
			{
				P_1 = 13;
			}
			else if (P_0 == 22 && P_1 == 14)
			{
				P_1 = 20;
			}
			Enumerator<CX> enumerator = BdF.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CX current = enumerator.Current;
					if (current.BdC != null && current.BdC.axS == P_0 && current.BdC.axs == P_1)
					{
						return current.BdC.axT;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return null;
		}

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYP() + BdE;
		}
	}
	internal class Cy
	{
		internal Cv BdG;

		internal byte[] Bdg;

		internal string BdH;

		internal uint Bdh;

		internal byte BdI;

		internal string Bdi;

		internal string BdJ;

		internal bool Bdj;

		internal bt BdK;

		internal bool Bdk;

		internal string BdL;

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYp() + ((!string.IsNullOrEmpty(Bdi)) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ() + Bdi) : string.Empty);
		}

		internal Cy(Cv P_0, byte[] P_1, string P_2, uint P_3, byte P_4, string P_5, string P_6, bool P_7, bt P_8, bool P_9, string P_10)
		{
			BdG = P_0;
			Bdg = P_1;
			BdH = P_2;
			Bdh = P_3;
			BdI = P_4;
			Bdi = P_5;
			BdJ = P_6;
			Bdj = P_7;
			BdK = P_8;
			Bdk = P_9;
			BdL = P_10;
		}
	}
}
