using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns4;
using ns7;

namespace NSP.UserInterface;

public class VirtualDashAppPanel : Panel
{
	[CompilerGenerated]
	private static class Class47
	{
		public static ElapsedEventHandler BIi;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class48
	{
		public static readonly Class48 BIJ = new Class48();

		public static Action BIj;

		internal void method_0()
		{
			if (Class88.Bhk.Parent == null)
			{
				Class88.Bhk.method_1(Form23.form23_0);
			}
			else
			{
				Class88.Bhk.method_1(Class88.Bhk);
			}
		}
	}

	private const string string_0 = "Qt5QWindowOwnDCIcon";

	private const string string_1 = "./qml_components_data/qml";

	private const int int_0 = 54000;

	private const int int_1 = 1000;

	private static nint intptr_0 = IntPtr.Zero;

	private static System.Timers.Timer timer_0 = null;

	internal static Framework framework_0 = null;

	private const int int_2 = -16;

	private const int int_3 = 4194304;

	private const int int_4 = 262144;

	private const int int_5 = 0;

	private const int int_6 = 1;

	private const int int_7 = 4;

	private const int int_8 = 5;

	private const int int_9 = 8;

	private const int int_10 = 9;

	internal static void smethod_0()
	{
		intptr_0 = IntPtr.Zero;
		timer_0 = null;
		framework_0 = null;
	}

	internal static bool smethod_1()
	{
		if (Class88.BIg)
		{
			return false;
		}
		intptr_0 = IntPtr.Zero;
		string text = Form23.string_3 + Class333.smethod_355();
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text + Class333.smethod_356());
		processStartInfo.WorkingDirectory = text;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		string format = Class333.smethod_357();
		Struct64<object> gparam_ = default;
		Class332.smethod_1<Struct64<object>, object>(ref gparam_, 0) = Class333.smethod_358();
		Class332.smethod_1<Struct64<object>, object>(ref gparam_, 1) = 54000;
		Class332.smethod_1<Struct64<object>, object>(ref gparam_, 2) = framework_0.awZ;
		Class332.smethod_1<Struct64<object>, object>(ref gparam_, 3) = framework_0.awz;
		processStartInfo.Arguments = string.Format(format, Class332.smethod_0<Struct64<object>, object>(in gparam_, 4));
		bool result = false;
		Process renderer = null;
		try
		{
			if (framework_0.awZ == 21 && framework_0.awz == 11)
			{
				try
				{
					NSP.NativeMediaRenderer.Prepare(processStartInfo, Path.Combine(AppContext.BaseDirectory, "ic7-media-runtime"));
				}
				catch (Exception mediaError)
				{
					// Keep the stock renderer usable; only GIF/MP4/splash/alert previews need the add-on.
					Class23.smethod_3("Native media preview unavailable; using the stock dash renderer: " + mediaError.Message);
				}
			}
			renderer = Process.Start(processStartInfo)
				?? throw new InvalidOperationException("The NSP dash renderer did not start.");
			renderer.WaitForInputIdle(10000);
			Stopwatch startup = Stopwatch.StartNew();
			while (intptr_0 == IntPtr.Zero)
			{
				if (renderer.HasExited || startup.ElapsedMilliseconds >= 15000)
				{
					throw new InvalidOperationException("The NSP dash renderer exited or did not create its window. Check its Qt log and the matching native media runtime.");
				}
				intptr_0 = FindWindow(Class333.smethod_359(), Class333.smethod_360());
				if (intptr_0 == IntPtr.Zero)
				{
					intptr_0 = FindWindow(string.Empty, Class333.smethod_360());
				}
				if (intptr_0 == IntPtr.Zero)
				{
					Thread.Sleep(200);
					continue;
				}
				int windowLong = GetWindowLong(intptr_0, -16);
				SetWindowLong(intptr_0, -16, windowLong & -4456449);
				if (Class88.Bhk == null || Class88.Bhk.Disposing || Class88.Bhk.IsDisposed)
				{
					Class88.Bhk = new VirtualDashAppPanel();
				}
				if (Form23.form23_0.InvokeRequired)
				{
					Form23.form23_0.Invoke(() =>
					{
						if (Class88.Bhk.Parent == null)
						{
							Class88.Bhk.method_1(Form23.form23_0);
						}
						else
						{
							Class88.Bhk.method_1(Class88.Bhk);
						}
					});
				}
				else if (Class88.Bhk.Parent == null)
				{
					Class88.Bhk.method_1(Form23.form23_0);
				}
				else
				{
					Class88.Bhk.method_1(Class88.Bhk);
				}
				MoveWindow(intptr_0, 0, 0, 3, 3, bool_0: true);
				ShowWindow(intptr_0, 5);
				result = true;
				break;
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_361() + ex.Message);
			try
			{
				if (renderer != null && !renderer.HasExited)
				{
					renderer.Kill();
				}
			}
			catch (InvalidOperationException cleanupError)
			{
				Class23.smethod_3("Native renderer cleanup: " + cleanupError.Message);
			}
			catch (System.ComponentModel.Win32Exception cleanupError)
			{
				Class23.smethod_3("Native renderer cleanup: " + cleanupError.Message);
			}
		}
		finally
		{
			renderer?.Dispose();
		}
		if (result)
		{
			smethod_2();
		}
		return result;
	}

	private static void smethod_2()
	{
		if (!Class88.BIg)
		{
			if (timer_0 != null)
			{
				smethod_4();
			}
			timer_0 = new System.Timers.Timer();
			timer_0.Interval = 1000.0;
			timer_0.SynchronizingObject = Form23.form23_0;
			timer_0.Elapsed += smethod_3;
			timer_0.AutoReset = true;
			timer_0.Enabled = true;
			timer_0.Start();
		}
	}

	private static void smethod_3(object sender, ElapsedEventArgs e)
	{
		if (timer_0 != null && timer_0.Enabled && Process.GetProcessesByName(Class333.smethod_360()).Length == 0)
		{
			Class329.smethod_11(bool_0: false);
			smethod_4();
			smethod_1();
			Class329.smethod_11(bool_0: false);
			if (Class88.Bhk != null)
			{
				Class88.Bhk.method_1(Class88.Bhk);
			}
		}
	}

	internal static void smethod_4()
	{
		if (timer_0 != null)
		{
			timer_0.Elapsed -= smethod_3;
			timer_0.Stop();
			timer_0.Close();
			timer_0 = null;
		}
	}

	internal static bool smethod_5()
	{
		Class329.smethod_11();
		smethod_4();
		bool result = true;
		Process[] processesByName = Process.GetProcessesByName(Class333.smethod_360());
		foreach (Process process in processesByName)
		{
			try
			{
				process.Kill();
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.smethod_362() + ex.Message);
			}
			if (!process.WaitForExit(1000))
			{
				result = false;
				Class23.smethod_3(Class333.smethod_363());
			}
		}
		return result;
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern long GetWindowThreadProcessId(long long_0, long long_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern long SetParent(nint intptr_1, nint intptr_2);

	[DllImport("USER32.DLL")]
	public static extern int SetWindowLong(nint hWnd, int nIndex, int dwNewLong);

	[DllImport("USER32.DLL")]
	public static extern int GetWindowLong(nint hWnd, int nIndex);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern long SetWindowPos(nint intptr_1, nint intptr_2, long long_0, long long_1, long long_2, long long_3, long long_4);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool MoveWindow(nint intptr_1, int int_11, int int_12, int int_13, int int_14, bool bool_0);

	[DllImport("USER32.DLL")]
	public static extern bool PostMessage(nint hWnd, uint Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	private static extern int GetWindowRect(nint intptr_1, out Rectangle rectangle_0);

	[DllImport("user32.dll")]
	private static extern nint FindWindow(string string_2, string string_3);

	[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
	private static extern nint FindWindow_1(int int_11, string string_2);

	[DllImport("User32.DLL")]
	private static extern bool ShowWindow(nint intptr_1, int int_11);

	protected override void OnSizeChanged(EventArgs eventArgs_0)
	{
		Invalidate();
		base.OnSizeChanged(eventArgs_0);
	}

	protected override void OnMove(EventArgs eventArgs_0)
	{
		method_0();
		base.OnMove(eventArgs_0);
	}

	protected override void OnResize(EventArgs eventargs)
	{
		if (intptr_0 != IntPtr.Zero)
		{
			if (Parent is Class88)
			{
				MoveWindow(intptr_0, 0, 0, Width, Height, bool_0: true);
			}
			else
			{
				MoveWindow(intptr_0, 0, 0, 3, 3, bool_0: true);
			}
		}
		base.OnResize(eventargs);
	}

	internal void method_0()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			if (Parent is Class88)
			{
				MoveWindow(intptr_0, 0, 0, Width, Height, bool_0: true);
			}
			else
			{
				MoveWindow(intptr_0, 0, 0, 3, 3, bool_0: true);
			}
			ShowWindow(intptr_0, 9);
		}
	}

	internal void method_1(Control control_0)
	{
		if (intptr_0 != IntPtr.Zero && control_0.Handle != IntPtr.Zero)
		{
			SetParent(intptr_0, control_0.Handle);
		}
	}
}
