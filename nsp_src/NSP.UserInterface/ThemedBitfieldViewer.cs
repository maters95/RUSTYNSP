using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using NSP.SettingsFramework;
using c;

namespace NSP.UserInterface;

public class ThemedBitfieldViewer : UserControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A BNV = new A();

		public static Func<int, int> BNv;

		public static Func<int, int> BNW;

		public static Func<int, int> BNw;

		internal int A(int P_0)
		{
			return P_0 / 8;
		}

		internal int a(int P_0)
		{
			return P_0 / 8;
		}

		internal int B(int P_0)
		{
			return P_0 / 8;
		}
	}

	internal const int JT = 225;

	internal const int Jt = 150;

	private const int JU = 8;

	private const int Ju = 50;

	private const int JV = 20;

	private const int Jv = 5;

	private const int JW = 27;

	private List<CANSignalModel> Jw = new List<CANSignalModel>();

	private CANSignalModel JX;

	[CompilerGenerated]
	private EventHandler Jx;

	[CompilerGenerated]
	private EventHandler JY;

	private uint Jy;

	private ToolTip JZ = new ToolTip();

	private CANSignalModel Jz;

	private Color[] jA = (Color[])(object)new Color[64]
	{
		Color.Red,
		Color.Green,
		Color.Blue,
		Color.Yellow,
		Color.Magenta,
		Color.Cyan,
		Color.Orange,
		Color.Purple,
		Color.Teal,
		Color.Lime,
		Color.Indigo,
		Color.Violet,
		Color.Brown,
		Color.Olive,
		Color.Maroon,
		Color.Navy,
		Color.Turquoise,
		Color.Gold,
		Color.Pink,
		Color.DarkRed,
		Color.DarkGreen,
		Color.DarkBlue,
		Color.DarkCyan,
		Color.DarkMagenta,
		Color.DarkOrange,
		Color.DarkViolet,
		Color.DarkTurquoise,
		Color.MediumVioletRed,
		Color.MediumOrchid,
		Color.MediumBlue,
		Color.MediumSeaGreen,
		Color.MediumTurquoise,
		Color.MediumSlateBlue,
		Color.MediumSpringGreen,
		Color.DeepPink,
		Color.DeepSkyBlue,
		Color.LightSeaGreen,
		Color.LightCoral,
		Color.LightSalmon,
		Color.LightGreen,
		Color.LightSkyBlue,
		Color.Sienna,
		Color.SteelBlue,
		Color.Tomato,
		Color.SlateBlue,
		Color.SlateGray,
		Color.SeaGreen,
		Color.RoyalBlue,
		Color.Peru,
		Color.Plum,
		Color.PaleVioletRed,
		Color.Moccasin,
		Color.Khaki,
		Color.HotPink,
		Color.IndianRed,
		Color.Firebrick,
		Color.Crimson,
		Color.CadetBlue,
		Color.Chartreuse,
		Color.Chocolate,
		Color.Coral,
		Color.CornflowerBlue,
		Color.DarkSlateBlue,
		Color.DarkSlateGray
	};

	private int ja = -1;

	private IContainer jB;

	public event EventHandler SignalSelectionChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Jx;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref Jx, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Jx;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref Jx, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler SelectedSignalBitsChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = JY;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref JY, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = JY;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref JY, val3, val2);
			}
			while (val != val2);
		}
	}

	public ThemedBitfieldViewer()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		a();
		((Control)this).DoubleBuffered = true;
		((Control)this).ResizeRedraw = true;
		((Control)this).MouseDown += new MouseEventHandler(A);
		((Control)this).MouseMove += new MouseEventHandler(a);
		((Control)this).MouseUp += new MouseEventHandler(B);
		((Control)this).MouseLeave += new EventHandler(a);
		((Component)this).Disposed += (EventHandler)([CompilerGenerated] (object? s, EventArgs P_1) =>
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			((TabControl)BM.QQ.rl).SelectedIndexChanged -= new EventHandler(A);
			((Component)JZ).Dispose();
		});
		((TabControl)BM.QQ.rl).SelectedIndexChanged += new EventHandler(A);
	}

	private void A(object P_0, EventArgs P_1)
	{
		A();
	}

	public void UpdateSignals(CANFrameModel frame)
	{
		if (frame == null || frame.Signals == null)
		{
			Jw.Clear();
			Jy = 0u;
			((Control)this).Invalidate();
			ClearSignalSelection();
		}
		else
		{
			Jw = Enumerable.ToList<CANSignalModel>((System.Collections.Generic.IEnumerable<CANSignalModel>)frame.Signals);
			Jy = frame.Length;
			((Control)this).Invalidate();
			if (JX != null && !Jw.Contains(JX))
			{
				ClearSignalSelection();
			}
		}
		A();
	}

	public void SelectSignal(CANSignalModel signal)
	{
		if (JX != signal)
		{
			JX = signal;
			((Control)this).Invalidate();
			if (Jx != null)
			{
				((Control)this).Invoke((System.Delegate)(object)Jx, new object[2] { this, null });
			}
		}
	}

	public void ClearSignalSelection()
	{
		if (JX != null)
		{
			JX = null;
			((Control)this).Invalidate();
			if (Jx != null)
			{
				((Control)this).Invoke((System.Delegate)(object)Jx, new object[2] { this, null });
			}
		}
	}

	public CANSignalModel GetSelectedSignal()
	{
		return JX;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		A(e.Graphics);
		if (Jw != null && Jw.Count > 0)
		{
			A(e.Graphics, Jw);
		}
		a(e.Graphics);
	}

	private void A(Graphics P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Brush val = (Brush)new SolidBrush(BM.te);
		try
		{
			Brush val2 = (Brush)new SolidBrush(BM.tq);
			try
			{
				Pen val3 = new Pen(BM.td);
				try
				{
					Size clientSize = ((Control)this).ClientSize;
					int num = (((Size)(ref clientSize)).Width - 50) / 8;
					clientSize = ((Control)this).ClientSize;
					int num2 = (((Size)(ref clientSize)).Height - 20) / 8;
					for (int i = 0; i < 8; i++)
					{
						for (int j = 0; j < 8; j++)
						{
							int num3 = 50 + j * num;
							int num4 = 20 + i * num2;
							P_0.DrawRectangle(val3, num3, num4, num, num2);
							int num5 = i * 8 + (7 - j);
							Brush val4 = ((Jy >= i + 1) ? val : val2);
							P_0.DrawString(num5.ToString(), ((Control)this).Font, val4, (float)(num3 + 6), (float)(num4 + 2));
						}
					}
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private void a(Graphics P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		Brush val = (Brush)new SolidBrush(BM.te);
		try
		{
			Brush val2 = (Brush)new SolidBrush(BM.tq);
			try
			{
				Size clientSize = ((Control)this).ClientSize;
				int num = (((Size)(ref clientSize)).Width - 50) / 8;
				clientSize = ((Control)this).ClientSize;
				int num2 = (((Size)(ref clientSize)).Height - 20) / 8;
				for (int i = 0; i < 8; i++)
				{
					int num3 = 50 + i * num;
					string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gu() + (7 - i);
					SizeF val3 = P_0.MeasureString(text, ((Control)this).Font);
					Brush val4 = ((Jy != 0) ? val : val2);
					P_0.DrawString(text, ((Control)this).Font, val4, (float)num3 + ((float)num - ((SizeF)(ref val3)).Width) / 2f, (20f - ((SizeF)(ref val3)).Height) / 2f);
				}
				for (int j = 0; j < 8; j++)
				{
					int num4 = 20 + j * num2;
					string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GV() + j;
					Brush val5 = ((Jy >= j + 1) ? val : val2);
					P_0.DrawString(text2, ((Control)this).Font, val5, 4f, (float)(num4 + (num2 - ((Control)this).Font.Height) / 2));
				}
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private void A(Graphics P_0, List<CANSignalModel> P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		Size clientSize = ((Control)this).ClientSize;
		int num = (((Size)(ref clientSize)).Width - 50) / 8;
		clientSize = ((Control)this).ClientSize;
		int num2 = (((Size)(ref clientSize)).Height - 20) / 8;
		int num3 = 0;
		Enumerator<CANSignalModel> enumerator = P_1.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANSignalModel current = enumerator.Current;
				if (current.BitLength != 0)
				{
					A(current, P_0, Color.FromArgb(80, jA[num3++]), num, num2);
				}
				num3 %= jA.Length;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private List<int> A(CANSignalModel P_0)
	{
		List<int> val = new List<int>();
		switch ((CANSignalModel.SignalFormat)P_0.Format)
		{
		case CANSignalModel.SignalFormat.LittleEndian:
		{
			int num2 = (int)(P_0.StartBit + P_0.BitLength - 1);
			for (int j = (int)P_0.StartBit; j <= num2; j++)
			{
				val.Add(j);
			}
			break;
		}
		case CANSignalModel.SignalFormat.BigEndian:
		{
			int num = (int)P_0.StartBit;
			for (int i = 0; i < P_0.BitLength; i++)
			{
				val.Add(num);
				num = ((num % 8 != 0) ? (num - 1) : (num + 15));
			}
			break;
		}
		}
		return val;
	}

	private void A(CANSignalModel P_0, Graphics P_1, Color P_2, int P_3, int P_4)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		CANSignalModel.SignalFormat format = (CANSignalModel.SignalFormat)P_0.Format;
		System.Collections.Generic.IEnumerable<IGrouping<int, int>> enumerable = Enumerable.GroupBy<int, int>((System.Collections.Generic.IEnumerable<int>)A(P_0), (Func<int, int>)((int P_0) => P_0 / 8));
		int num = 1;
		bool flag = false;
		System.Collections.Generic.IEnumerator<IGrouping<int, int>> enumerator = enumerable.GetEnumerator();
		try
		{
			Point val8 = default(Point);
			Point val9 = default(Point);
			Point val10 = default(Point);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				IGrouping<int, int> current = enumerator.Current;
				int key = current.Key;
				if (key >= 8)
				{
					continue;
				}
				List<int> val = Enumerable.ToList<int>((System.Collections.Generic.IEnumerable<int>)current);
				int num2 = 7 - Enumerable.Min((System.Collections.Generic.IEnumerable<int>)val) % 8;
				int num3 = 7 - Enumerable.Max((System.Collections.Generic.IEnumerable<int>)val) % 8;
				int num4 = 50 + num3 * P_3;
				int num5 = 20 + key * P_4;
				int num6 = (num2 - num3 + 1) * P_3;
				Brush val2 = (Brush)new SolidBrush(P_2);
				try
				{
					P_1.FillRectangle(val2, num4, num5, num6, P_4);
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
				Pen val3 = new Pen(BM.te, 1f);
				try
				{
					Brush val4 = (Brush)new SolidBrush(BM.te);
					try
					{
						Brush val5 = (Brush)new SolidBrush(Color.Red);
						try
						{
							Pen val6 = new Pen(BM.td);
							try
							{
								Pen val7 = new Pen(Color.White, 2f);
								try
								{
									int num7 = num5 + (int)((double)P_4 * 0.7);
									int num8 = (int)((double)P_4 * 0.2);
									if (num == 1)
									{
										switch (format)
										{
										case CANSignalModel.SignalFormat.LittleEndian:
										{
											((Point)(ref val8))._002Ector(num4 + num6 - 5 - 2, num7 - num8);
											((Point)(ref val9))._002Ector(num4 + num6 - 2, num7);
											((Point)(ref val10))._002Ector(num4 + num6 - 5 - 2, num7 + num8);
											cD<Point> buffer2 = default(cD<Point>);
											cc.a<cD<Point>, Point>(ref buffer2, 0) = val9;
											cc.a<cD<Point>, Point>(ref buffer2, 1) = val8;
											cc.a<cD<Point>, Point>(ref buffer2, 2) = val10;
											P_1.FillPolygon(val5, cc.A<cD<Point>, Point>(in buffer2, 3));
											break;
										}
										case CANSignalModel.SignalFormat.BigEndian:
										{
											((Point)(ref val8))._002Ector(num4 + 2, num7 - num8);
											((Point)(ref val9))._002Ector(num4 + 2 + 5, num7);
											((Point)(ref val10))._002Ector(num4 + 2, num7 + num8);
											cD<Point> buffer = default(cD<Point>);
											cc.a<cD<Point>, Point>(ref buffer, 0) = val9;
											cc.a<cD<Point>, Point>(ref buffer, 1) = val8;
											cc.a<cD<Point>, Point>(ref buffer, 2) = val10;
											P_1.FillPolygon(val5, cc.A<cD<Point>, Point>(in buffer, 3));
											break;
										}
										}
									}
									if (num == Enumerable.Count<IGrouping<int, int>>(enumerable))
									{
										switch (format)
										{
										case CANSignalModel.SignalFormat.LittleEndian:
										{
											((Point)(ref val8))._002Ector(num4 + 2, num7 - num8);
											((Point)(ref val9))._002Ector(num4 + 2 + 5, num7);
											((Point)(ref val10))._002Ector(num4 + 2, num7 + num8);
											cD<Point> buffer4 = default(cD<Point>);
											cc.a<cD<Point>, Point>(ref buffer4, 0) = val9;
											cc.a<cD<Point>, Point>(ref buffer4, 1) = val8;
											cc.a<cD<Point>, Point>(ref buffer4, 2) = val10;
											P_1.FillPolygon(val5, cc.A<cD<Point>, Point>(in buffer4, 3));
											break;
										}
										case CANSignalModel.SignalFormat.BigEndian:
										{
											((Point)(ref val8))._002Ector(num4 + num6 - 5 - 2, num7 - num8);
											((Point)(ref val9))._002Ector(num4 + num6 - 2, num7);
											((Point)(ref val10))._002Ector(num4 + num6 - 5 - 2, num7 + num8);
											cD<Point> buffer3 = default(cD<Point>);
											cc.a<cD<Point>, Point>(ref buffer3, 0) = val9;
											cc.a<cD<Point>, Point>(ref buffer3, 1) = val8;
											cc.a<cD<Point>, Point>(ref buffer3, 2) = val10;
											P_1.FillPolygon(val5, cc.A<cD<Point>, Point>(in buffer3, 3));
											break;
										}
										}
									}
									num++;
									if (P_0 == JX)
									{
										P_1.DrawRectangle(val7, num4, num5, num6 - 1, P_4 - 1);
									}
									else
									{
										P_1.DrawRectangle(val6, num4, num5, num6, P_4);
									}
									if (flag)
									{
										continue;
									}
									string text = P_0.Name;
									bool flag2 = false;
									SizeF val11;
									while (true)
									{
										val11 = P_1.MeasureString(flag2 ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC()) : text, ((Control)this).Font);
										if (!(27f + ((SizeF)(ref val11)).Width >= (float)P_3) || text.Length <= 1)
										{
											break;
										}
										text = text.Substring(0, text.Length - 1);
										flag2 = true;
									}
									if (flag2)
									{
										text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC();
									}
									P_1.DrawString(text, ((Control)this).Font, val4, (float)(num4 + 27), (float)num5 + ((float)P_4 - ((SizeF)(ref val11)).Height) / 2f);
									flag = true;
								}
								finally
								{
									((System.IDisposable)val7)?.Dispose();
								}
							}
							finally
							{
								((System.IDisposable)val6)?.Dispose();
							}
						}
						finally
						{
							((System.IDisposable)val5)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		CANSignalModel cANSignalModel = null;
		if ((int)P_1.Button == 1048576 && Jw != null && Jw.Count > 0)
		{
			Size clientSize = ((Control)this).ClientSize;
			int num = (((Size)(ref clientSize)).Width - 50) / 8;
			clientSize = ((Control)this).ClientSize;
			int num2 = (((Size)(ref clientSize)).Height - 20) / 8;
			List<CANSignalModel> val = new List<CANSignalModel>(Jw.Count);
			if (JX != null)
			{
				val.Add(JX);
			}
			Enumerator<CANSignalModel> enumerator = Jw.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CANSignalModel current = enumerator.Current;
					if (current != JX)
					{
						val.Add(current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = val.GetEnumerator();
			try
			{
				Rectangle val3 = default(Rectangle);
				while (enumerator.MoveNext())
				{
					CANSignalModel current2 = enumerator.Current;
					if (current2.BitLength == 0)
					{
						continue;
					}
					CANSignalModel.SignalFormat format = (CANSignalModel.SignalFormat)current2.Format;
					System.Collections.Generic.IEnumerable<IGrouping<int, int>> enumerable = Enumerable.GroupBy<int, int>((System.Collections.Generic.IEnumerable<int>)A(current2), (Func<int, int>)((int P_0) => P_0 / 8));
					int num3 = 1;
					System.Collections.Generic.IEnumerator<IGrouping<int, int>> enumerator2 = enumerable.GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							IGrouping<int, int> current3 = enumerator2.Current;
							int key = current3.Key;
							if (key >= 8)
							{
								continue;
							}
							List<int> val2 = Enumerable.ToList<int>((System.Collections.Generic.IEnumerable<int>)current3);
							int num4 = 7 - Enumerable.Min((System.Collections.Generic.IEnumerable<int>)val2) % 8;
							int num5 = 7 - Enumerable.Max((System.Collections.Generic.IEnumerable<int>)val2) % 8;
							int num6 = 50 + num5 * num;
							int num7 = 20 + key * num2;
							int num8 = (num4 - num5 + 1) * num;
							((Rectangle)(ref val3))._002Ector(num6, num7, num8, num2);
							if (((Rectangle)(ref val3)).Contains(P_1.X, P_1.Y))
							{
								int num9 = 7 - (P_1.X - 50) / num;
								int num10 = 7 - num5;
								int num11 = 7 - num4;
								if (Enumerable.Count<IGrouping<int, int>>(enumerable) == 1)
								{
									if (num9 == num11)
									{
										ja = key * 8 + num10;
									}
									else if (num9 == num10)
									{
										ja = key * 8 + num11;
									}
								}
								else if (num3 == 1)
								{
									switch (format)
									{
									case CANSignalModel.SignalFormat.LittleEndian:
										if (num9 == num11)
										{
											int num13 = (int)(current2.StartBit + current2.BitLength - 1);
											ja = num13;
										}
										break;
									case CANSignalModel.SignalFormat.BigEndian:
										if (num9 == num10)
										{
											int num12 = (int)current2.StartBit;
											for (int i = 1; i < current2.BitLength; i++)
											{
												num12 = ((num12 % 8 != 0) ? (num12 - 1) : (num12 + 15));
											}
											ja = num12;
										}
										break;
									}
								}
								else if (num3 == Enumerable.Count<IGrouping<int, int>>(enumerable))
								{
									switch (format)
									{
									case CANSignalModel.SignalFormat.LittleEndian:
										if (num9 == num10)
										{
											ja = (int)current2.StartBit;
										}
										break;
									case CANSignalModel.SignalFormat.BigEndian:
										if (num9 == num11)
										{
											ja = (int)current2.StartBit;
										}
										break;
									}
								}
								if (ja != -1)
								{
									SelectSignal(current2);
									BM.aM()?.a();
									return;
								}
								if (cANSignalModel == null)
								{
									cANSignalModel = current2;
								}
							}
							num3++;
						}
					}
					finally
					{
						((System.IDisposable)enumerator2)?.Dispose();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (cANSignalModel != null && ja == -1)
			{
				SelectSignal(cANSignalModel);
				return;
			}
		}
		if (cANSignalModel == null)
		{
			ClearSignalSelection();
		}
	}

	private void a(object P_0, MouseEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if ((int)P_1.Button == 1048576 && JX != null && ja != -1)
		{
			A();
			Size clientSize = ((Control)this).ClientSize;
			int num = (((Size)(ref clientSize)).Width - 50) / 8;
			clientSize = ((Control)this).ClientSize;
			int num2 = (((Size)(ref clientSize)).Height - 20) / 8;
			Rectangle val = default(Rectangle);
			for (uint num3 = 0u; num3 < 64; num3++)
			{
				int num4 = 50 + (7 - (int)num3 % 8) * num;
				int num5 = 20 + (int)num3 / 8 * num2;
				((Rectangle)(ref val))._002Ector(num4, num5, num, num2);
				if (!((Rectangle)(ref val)).Contains(P_1.X, P_1.Y))
				{
					continue;
				}
				uint num6 = num3;
				uint num7;
				uint num8;
				if ((long)JX.Format == 1)
				{
					if (num6 < ja)
					{
						num7 = num6;
						num8 = (uint)(ja - (int)num7 + 1);
					}
					else
					{
						num7 = (uint)ja;
						num8 = num6 - num7 + 1;
					}
				}
				else
				{
					if (JX.Format != 0L)
					{
						break;
					}
					int num9 = (int)num6 / 8;
					int num10 = ja / 8;
					if (num9 == num10)
					{
						if (num6 < ja)
						{
							num7 = (uint)ja;
							num8 = num7 - num6 + 1;
						}
						else
						{
							num7 = num6;
							num8 = (uint)((int)num7 - ja + 1);
						}
					}
					else if (num9 < num10)
					{
						num7 = num6;
						num8 = 1u;
						for (uint num11 = num7; num11 != ja; num11 = ((num11 % 8 != 0) ? (num11 - 1) : (num11 + 15)))
						{
							num8++;
						}
					}
					else
					{
						num7 = (uint)ja;
						num8 = 1u;
						for (uint num12 = num7; num12 != num6; num12 = ((num12 % 8 != 0) ? (num12 - 1) : (num12 + 15)))
						{
							num8++;
						}
					}
				}
				if (JX.StartBit != num7 || JX.BitLength != num8)
				{
					JX.StartBit = num7;
					JX.BitLength = num8;
					((Control)this).Invalidate();
				}
				break;
			}
		}
		else
		{
			A(P_1);
		}
	}

	private void B(object P_0, MouseEventArgs P_1)
	{
		if (ja != -1)
		{
			if (JY != null)
			{
				((Control)this).Invoke((System.Delegate)(object)JY, new object[2] { this, null });
			}
			BM.aM()?.B();
			ja = -1;
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Point val = ((Control)this).PointToClient(Control.MousePosition);
		Rectangle clientRectangle = ((Control)this).ClientRectangle;
		if (!((Rectangle)(ref clientRectangle)).Contains(val))
		{
			A();
		}
	}

	private void A(MouseEventArgs P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		Size clientSize = ((Control)this).ClientSize;
		int num = (((Size)(ref clientSize)).Width - 50) / 8;
		clientSize = ((Control)this).ClientSize;
		int num2 = (((Size)(ref clientSize)).Height - 20) / 8;
		List<CANSignalModel> val = new List<CANSignalModel>(Jw.Count);
		if (JX != null)
		{
			val.Add(JX);
		}
		Enumerator<CANSignalModel> enumerator = Jw.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANSignalModel current = enumerator.Current;
				if (current != JX)
				{
					val.Add(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = val.GetEnumerator();
		try
		{
			Rectangle val3 = default(Rectangle);
			while (enumerator.MoveNext())
			{
				CANSignalModel current2 = enumerator.Current;
				if (current2.BitLength == 0)
				{
					continue;
				}
				_ = current2.Format;
				System.Collections.Generic.IEnumerator<IGrouping<int, int>> enumerator2 = Enumerable.GroupBy<int, int>((System.Collections.Generic.IEnumerable<int>)A(current2), (Func<int, int>)((int P_0) => P_0 / 8)).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						IGrouping<int, int> current3 = enumerator2.Current;
						int key = current3.Key;
						if (key >= 8)
						{
							continue;
						}
						List<int> val2 = Enumerable.ToList<int>((System.Collections.Generic.IEnumerable<int>)current3);
						int num3 = 7 - Enumerable.Min((System.Collections.Generic.IEnumerable<int>)val2) % 8;
						int num4 = 7 - Enumerable.Max((System.Collections.Generic.IEnumerable<int>)val2) % 8;
						int num5 = 50 + num4 * num;
						int num6 = 20 + key * num2;
						int num7 = (num3 - num4 + 1) * num;
						((Rectangle)(ref val3))._002Ector(num5, num6, num7, num2);
						if (((Rectangle)(ref val3)).Contains(P_0.X, P_0.Y))
						{
							if (current2 != Jz)
							{
								Jz = current2;
								JZ.ShowAlways = true;
								JZ.InitialDelay = 100;
								JZ.ReshowDelay = 100;
								JZ.Active = true;
								JZ.Show(current2.Name, (IWin32Window)(object)this, P_0.X, ((Rectangle)(ref val3)).Y + 3);
							}
							return;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		A();
	}

	internal void A()
	{
		Jz = null;
		JZ.Active = false;
		JZ.Hide((IWin32Window)(object)this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && jB != null)
		{
			((System.IDisposable)jB).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void a()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		jB = (IContainer)new Container();
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
	}

	[CompilerGenerated]
	private void B(object? s, EventArgs P_1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		((TabControl)BM.QQ.rl).SelectedIndexChanged -= new EventHandler(A);
		((Component)JZ).Dispose();
	}
}
