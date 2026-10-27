using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.SettingsFramework;
using c;

namespace NSP.UserInterface;

public class VirtualDashAppPanel : Panel
{
	[CompilerGenerated]
	private static class A
	{
		public static ElapsedEventHandler BIi;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a BIJ = new a();

		public static Action BIj;

		internal void A()
		{
			if (((Control)ch.Bhk).Parent == null)
			{
				ch.Bhk.A((Control)(object)BM.QQ);
			}
			else
			{
				ch.Bhk.A((Control)(object)ch.Bhk);
			}
		}
	}

	private const string ED = "Qt5QWindowOwnDCIcon";

	private const string Ed = "./qml_components_data/qml";

	private const int EE = 54000;

	private const int Ee = 1000;

	private static nint EF = System.IntPtr.Zero;

	private static Timer Ef = null;

	internal static Framework EG = null;

	private const int Eg = -16;

	private const int EH = 4194304;

	private const int Eh = 262144;

	private const int EI = 0;

	private const int Ei = 1;

	private const int EJ = 4;

	private const int Ej = 5;

	private const int EK = 8;

	private const int Ek = 9;

	internal static void A()
	{
		EF = System.IntPtr.Zero;
		Ef = null;
		EG = null;
	}

	internal static bool a()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		if (ch.BIg)
		{
			return false;
		}
		EF = System.IntPtr.Zero;
		string text = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DV();
		ProcessStartInfo val = new ProcessStartInfo(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dv());
		val.WorkingDirectory = text;
		val.WindowStyle = (ProcessWindowStyle)1;
		string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DW();
		cd<object> buffer = default(cd<object>);
		cc.a<cd<object>, object>(ref buffer, 0) = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dw();
		cc.a<cd<object>, object>(ref buffer, 1) = 54000;
		cc.a<cd<object>, object>(ref buffer, 2) = EG.awZ;
		cc.a<cd<object>, object>(ref buffer, 3) = EG.awz;
		val.Arguments = string.Format(text2, cc.A<cd<object>, object>(in buffer, 4));
		bool result = false;
		try
		{
			Process val2 = Process.Start(val);
			if (val2 != null)
			{
				val2.WaitForInputIdle();
			}
			while (EF == (nint)System.IntPtr.Zero)
			{
				EF = A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DX(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dx());
				if (EF == (nint)System.IntPtr.Zero)
				{
					EF = A(string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dx());
				}
				if (EF != (nint)System.IntPtr.Zero)
				{
					int windowLong = GetWindowLong(EF, -16);
					SetWindowLong(EF, -16, windowLong & -4456449);
					if (ch.Bhk == null || ((Control)ch.Bhk).Disposing || ((Control)ch.Bhk).IsDisposed)
					{
						ch.Bhk = new VirtualDashAppPanel();
					}
					if (((Control)BM.QQ).InvokeRequired)
					{
						BM qQ = BM.QQ;
						object obj = VirtualDashAppPanel.a.BIj;
						if (obj == null)
						{
							Action val3 = delegate
							{
								if (((Control)ch.Bhk).Parent == null)
								{
									ch.Bhk.A((Control)(object)BM.QQ);
								}
								else
								{
									ch.Bhk.A((Control)(object)ch.Bhk);
								}
							};
							VirtualDashAppPanel.a.BIj = val3;
							obj = (object)val3;
						}
						((Control)qQ).Invoke((Action)obj);
					}
					else if (((Control)ch.Bhk).Parent == null)
					{
						ch.Bhk.A((Control)(object)BM.QQ);
					}
					else
					{
						ch.Bhk.A((Control)(object)ch.Bhk);
					}
					A(EF, 0, 0, 3, 3, true);
					A(EF, 5);
					result = true;
					break;
				}
				Thread.Sleep(200);
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DY() + ex.Message, true);
		}
		B();
		return result;
	}

	private static void B()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		if (!ch.BIg)
		{
			if (Ef != null)
			{
				b();
			}
			Ef = new Timer();
			Ef.Interval = 1000.0;
			Ef.SynchronizingObject = (ISynchronizeInvoke)(object)BM.QQ;
			Timer ef = Ef;
			object obj = VirtualDashAppPanel.A.BIi;
			if (obj == null)
			{
				ElapsedEventHandler val = A;
				VirtualDashAppPanel.A.BIi = val;
				obj = (object)val;
			}
			ef.Elapsed += (ElapsedEventHandler)obj;
			Ef.AutoReset = true;
			Ef.Enabled = true;
			Ef.Start();
		}
	}

	private static void A(object P_0, ElapsedEventArgs P_1)
	{
		if (Ef != null && Ef.Enabled && Process.GetProcessesByName(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dx()).Length == 0)
		{
			cb.a(false);
			b();
			a();
			cb.a(false);
			if (ch.Bhk != null)
			{
				ch.Bhk.A((Control)(object)ch.Bhk);
			}
		}
	}

	internal static void b()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		if (Ef != null)
		{
			Timer ef = Ef;
			object obj = VirtualDashAppPanel.A.BIi;
			if (obj == null)
			{
				ElapsedEventHandler val = A;
				VirtualDashAppPanel.A.BIi = val;
				obj = (object)val;
			}
			ef.Elapsed -= (ElapsedEventHandler)obj;
			Ef.Stop();
			Ef.Close();
			Ef = null;
		}
	}

	internal static bool C()
	{
		cb.a(true);
		b();
		bool result = true;
		Process[] processesByName = Process.GetProcessesByName(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dx());
		foreach (Process val in processesByName)
		{
			try
			{
				val.Kill();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dy() + ex.Message, true);
			}
			if (!val.WaitForExit(1000))
			{
				result = false;
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DZ(), true);
			}
		}
		return result;
	}

	[DllImport("user32.dll", CallingConvention = 3, CharSet = 3, EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true, SetLastError = true)]
	private static extern long A(long P_0, long P_1);

	[DllImport("user32.dll", EntryPoint = "SetParent", SetLastError = true)]
	private static extern long A(nint P_0, nint P_1);

	[DllImport("USER32.DLL")]
	public static extern int SetWindowLong(nint hWnd, int nIndex, int dwNewLong);

	[DllImport("USER32.DLL")]
	public static extern int GetWindowLong(nint hWnd, int nIndex);

	[DllImport("user32.dll", EntryPoint = "SetWindowPos", SetLastError = true)]
	private static extern long A(nint P_0, nint P_1, long P_2, long P_3, long P_4, long P_5, long P_6);

	[DllImport("user32.dll", EntryPoint = "MoveWindow", SetLastError = true)]
	private static extern bool A(nint P_0, int P_1, int P_2, int P_3, int P_4, bool P_5);

	[DllImport("USER32.DLL")]
	public static extern bool PostMessage(nint hWnd, uint Msg, int wParam, int lParam);

	[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
	private static extern int A(nint P_0, out Rectangle P_1);

	[DllImport("user32.dll", EntryPoint = "FindWindow")]
	private static extern nint A(string P_0, string P_1);

	[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
	private static extern nint A(int P_0, string P_1);

	[DllImport("User32.DLL", EntryPoint = "ShowWindow")]
	private static extern bool A(nint P_0, int P_1);

	protected override void OnSizeChanged(EventArgs e)
	{
		((Control)this).Invalidate();
		((Control)this).OnSizeChanged(e);
	}

	protected override void OnMove(EventArgs e)
	{
		c();
		((Control)this).OnMove(e);
	}

	protected override void OnResize(EventArgs e)
	{
		if (EF != (nint)System.IntPtr.Zero)
		{
			if (((Control)this).Parent is ch)
			{
				A(EF, 0, 0, ((Control)this).Width, ((Control)this).Height, true);
			}
			else
			{
				A(EF, 0, 0, 3, 3, true);
			}
		}
		((Panel)this).OnResize(e);
	}

	internal void c()
	{
		if (EF != (nint)System.IntPtr.Zero)
		{
			if (((Control)this).Parent is ch)
			{
				A(EF, 0, 0, ((Control)this).Width, ((Control)this).Height, true);
			}
			else
			{
				A(EF, 0, 0, 3, 3, true);
			}
			A(EF, 9);
		}
	}

	internal void A(Control P_0)
	{
		if (EF != (nint)System.IntPtr.Zero && P_0.Handle != System.IntPtr.Zero)
		{
			A(EF, P_0.Handle);
		}
	}
}
