using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using B;
using D;
using NSP.UserInterface;
using a;

namespace A;

internal static class Q
{
	internal const float cX = 8.25f;

	internal const int cx = 3;

	internal const int cY = 2;

	internal const int cy = 3;

	internal const int cZ = 2;

	internal const int cz = 3;

	internal const int DA = 2;

	internal const int Da = 13;

	internal const int DB = 2;

	internal const int Db = 13;

	internal const int DC = 0;

	internal const int Dc = 3;
}
internal static class q
{
	internal static void A(Control P_0)
	{
		if (P_0.IsDisposed || P_0 is VirtualDashAppPanel)
		{
			return;
		}
		if (P_0.Controls != null)
		{
			int count = ((ArrangedElementCollection)P_0.Controls).Count;
			for (int num = 0; num < count; num++)
			{
				if (((ArrangedElementCollection)P_0.Controls).Count != 0)
				{
					A(P_0.Controls[0]);
				}
			}
		}
		try
		{
			((Component)P_0).Dispose();
		}
		catch
		{
		}
	}

	internal static void a(Control P_0)
	{
		if (P_0.IsDisposed)
		{
			return;
		}
		if (P_0.Controls != null)
		{
			int count = ((ArrangedElementCollection)P_0.Controls).Count;
			for (int num = 0; num < count; num++)
			{
				a(P_0.Controls[num]);
			}
		}
		P_0.SuspendLayout();
	}

	internal static void A(Control P_0, bool P_1)
	{
		if (P_0.IsDisposed)
		{
			return;
		}
		P_0.ResumeLayout(P_1);
		if (P_0.Controls != null)
		{
			int count = ((ArrangedElementCollection)P_0.Controls).Count;
			for (int num = 0; num < count; num++)
			{
				A(P_0.Controls[num], P_1);
			}
		}
	}

	internal static Control B(Control P_0)
	{
		Control val = P_0;
		for (ContainerControl val2 = (ContainerControl)(object)((val is ContainerControl) ? val : null); val2 != null; val2 = (ContainerControl)(object)((val is ContainerControl) ? val : null))
		{
			val = val2.ActiveControl;
			if (val.Focused)
			{
				return val;
			}
		}
		return null;
	}

	internal static bool A(Form P_0, Keys P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		if ((int)P_1 == 131162)
		{
			BM.QQ.ak(null, null);
			return true;
		}
		if ((int)P_1 == 131161)
		{
			BM.QQ.aL(null, null);
			return true;
		}
		if ((P_1 & 0x21) == 33 || (P_1 & 0x22) == 34)
		{
			Control val = B((Control)(object)P_0);
			if (val is ThemedTextBox)
			{
				if (val.Parent is DE)
				{
					return (val.Parent as DE).A(new KeyEventArgs(P_1));
				}
				if (val.Parent is Dd)
				{
					return (val.Parent as Dd).A(new KeyEventArgs(P_1));
				}
				if (val.Parent is ah)
				{
					return (val.Parent as ah).A(new KeyEventArgs(P_1));
				}
			}
		}
		return false;
	}

	[DllImport("user32.dll", EntryPoint = "GetKeyState")]
	public static extern short A(Keys P_0);

	internal static List<Keys> A()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		System.Array values = System.Enum.GetValues(typeof(Keys));
		List<Keys> val = new List<Keys>();
		foreach (Keys item in values)
		{
			if ((int)item != 0 && ((uint)q.A(item) & 0x8000u) != 0)
			{
				val.Add(item);
			}
		}
		return val;
	}
}
