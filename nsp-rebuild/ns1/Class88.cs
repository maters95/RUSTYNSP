using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Class88 : MovableResizablePanel
{
	internal enum Enum23
	{
		BUm,
		BUN,
		BUn,
		BUO,
		BUo,
		BUP,
		BUp,
		BUQ,
		BUq
	}

	internal enum Enum24
	{
		BUR,
		BUr,
		BUS
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class44
	{
		public static readonly Class44 BUs = new Class44();

		public static Action BUT;

		internal void method_0()
		{
			Bhk.method_0();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Struct8
	{
		public Class88 BUt;

		public Class243 BUU;

		public int BUu;

		public int BUV;

		public int BUv;

		public int BUW;

		public int BUw;

		public int BUX;
	}

	[CompilerGenerated]
	private sealed class Class45
	{
		public Class88 BUx;

		public int BUY;

		public int BUy;

		public Size BUZ;

		internal void method_0()
		{
			BUx.Width = BUY;
			BUx.Height = BUy;
			Bhk.Size = BUZ;
		}

		internal void method_1()
		{
			BUx.Refresh();
		}

		internal void method_2()
		{
			Bhl.Top = BUx.Top + BUx.Height + 10;
		}
	}

	[CompilerGenerated]
	private sealed class Class46
	{
		public bool BUz;

		public Class88 BuA;

		internal void method_0()
		{
			BUz = Form23.form23_0.control25_0.method_24(BuA);
		}
	}

	internal Framework Bhi;

	private Rectangle BhJ;

	private int Bhj = -1;

	internal const string BhK = "dash_virtual";

	internal static VirtualDashAppPanel Bhk = null;

	internal TransparentPanel BhL = new TransparentPanel();

	internal static Class124 Bhl = null;

	private Class51 BhM;

	internal List<Setting.ListItems.Struct45> Bhm;

	private Dictionary<int, string> BhN = new Dictionary<int, string>();

	private List<int> Bhn = new List<int>();

	private const string BhO = "Dial Gauges";

	private bool Bho;

	private bool BhP;

	private bool Bhp;

	private bool BhQ;

	private float Bhq;

	private int BhR;

	private int Bhr;

	private int BhS;

	private int Bhs = -1;

	private float BhT = 1f;

	private const int Bht = 200;

	private int BhU = Environment.TickCount;

	private Cursor Bhu = System.Windows.Forms.Cursor.Current;

	private Cursor BhV;

	private const int Bhv = 500;

	private int BhW = 1280;

	private int Bhw = 480;

	private const int BhX = -1;

	private Class108 Bhx;

	private Point BhY = new Point(0, 0);

	private int Bhy;

	private int BhZ;

	private int Bhz;

	private int BIA;

	private int BIa;

	private int BIB;

	private bool BIb;

	private int BIC = -1;

	private Class280 BIc;

	private int BID = -1;

	private int BId = -1;

	private System.Timers.Timer BIE;

	private static bool BIe = true;

	private double BIF = 1.0;

	private bool BIf;

	private Class43 BIG;

	internal static bool BIg = false;

	private const int BIH = 10;

	private static int BIh = -1;

	private Enum23 BII;

	internal static int smethod_0(Framework framework_0)
	{
		if (framework_0.awZ == 21 && framework_0.awz == 11)
		{
			return 860;
		}
		if (framework_0.awZ == 21 && framework_0.awz == 12)
		{
			return 1280;
		}
		if (framework_0.awZ != 21 || framework_0.awz != 41)
		{
			throw new Exception(Class333.BAR());
		}
		return 2560;
	}

	internal static int smethod_1(Framework framework_0)
	{
		if (framework_0.awZ == 21 && framework_0.awz == 11)
		{
			return 480;
		}
		if (framework_0.awZ == 21 && framework_0.awz == 12)
		{
			return 480;
		}
		if (framework_0.awZ != 21 || framework_0.awz != 41)
		{
			throw new Exception(Class333.BAr());
		}
		return 720;
	}

	internal Class250 method_12()
	{
		return Bhi.awP.method_79()[Bhj];
	}

	private void method_13(int int_3 = -1)
	{
		Focus();
		Class250 @class = method_12();
		int num = -32767;
		BID = -1;
		int count = @class.method_72().Count;
		int int_4 = -BhW;
		int int_5 = -Bhw;
		int int_6 = BhW * 2;
		int int_7 = Bhw * 2;
		for (int i = 0; i < count; i++)
		{
			Class243 class2 = @class.method_72()[i];
			if (@class.method_72()[i].method_297().method_256() <= 0)
			{
				continue;
			}
			int num2 = class2.method_302().method_256();
			int num3 = class2.method_303().method_256();
			int num4 = class2.method_299().method_256();
			int num5 = class2.method_300().method_256();
			if (Bhy > num4 - 10 && Bhy < num4 + num2 + 10 && BhZ > num5 - 10 && BhZ < num5 + num3 + 10)
			{
				int num6 = class2.method_301().method_256();
				int num7 = class2.method_306().method_256();
				if ((num6 > num || (smethod_2(num4, int_4, int_6) && smethod_2(num4 + num2, int_4, int_6) && smethod_2(num5, int_5, int_7) && smethod_2(num5 + num3, int_5, int_7))) && num7 != BID)
				{
					BIa = num2;
					BIB = num3;
					num = num6;
					BID = i + 1;
					Bhz = Bhy;
					BIA = BhZ;
					int_4 = num4;
					int_5 = num5;
					int_6 = num4 + num2;
					int_7 = num5 + num3;
				}
			}
		}
		if (BID == -1)
		{
			method_44(0);
			BId = -1;
			BhM.method_5(null);
			return;
		}
		method_44(BID);
		method_16(BID - 1);
		Form23.form23_0.control4_0.method_55(Bhj, BID - 1);
		BIb = false;
		Class243 class3 = @class.method_72()[BID - 1];
		if (class3.method_305().method_256() > 0)
		{
			class3.method_305().method_256();
			BhM.method_5(class3);
		}
	}

	private bool method_14(Point point_0, int int_3, int int_4)
	{
		bool result = false;
		Class243 @class = method_12().method_72()[int_3 - 1];
		if (@class.method_297().method_256() > 0)
		{
			int num = @class.method_302().method_256();
			int num2 = @class.method_303().method_256();
			int num3 = @class.method_299().method_256();
			int num4 = @class.method_300().method_256();
			int num5 = int_4;
			int num6 = int_4;
			switch (BII)
			{
			case Enum23.BUO:
			case Enum23.BUo:
				num5 = 0;
				break;
			case Enum23.BUN:
			case Enum23.BUn:
				num6 = 0;
				break;
			}
			if (point_0.X > num3 - num5 && point_0.X < num3 + num + num5 && point_0.Y > num4 - num6 && point_0.Y < num4 + num2 + num6)
			{
				result = true;
			}
		}
		return result;
	}

	internal void method_15(int int_3)
	{
		try
		{
			Class250 @class = method_12();
			if (int_3 > -1 && int_3 < @class.method_72().Count)
			{
				method_44(0);
				bool bool_ = BID != int_3 + 1;
				BID = int_3 + 1;
				method_44(BID);
				method_16(int_3, bool_);
				Class243 class2 = @class.method_72()[BID - 1];
				if (class2.method_305().method_256() > 0)
				{
					BhM.method_5(class2);
				}
				Form23.form23_0.control4_0.method_55(Bhj, BID - 1);
			}
		}
		catch
		{
		}
	}

	private void method_16(int int_3, bool bool_0 = true)
	{
		if (Bhl != null && int_3 >= 0)
		{
			Bhl.method_17(int_3);
		}
		BId = int_3;
		if (bool_0)
		{
			Focus();
		}
	}

	internal List<int> method_17(Point point_0)
	{
		List<int> list = new List<int>();
		Focus();
		Class250 @class = method_12();
		for (int i = 0; i < @class.method_72().Count; i++)
		{
			Class243 class2 = @class.method_72()[i];
			if (@class.method_72()[i].method_297().method_256() > 0)
			{
				int num = class2.method_302().method_256();
				int num2 = class2.method_303().method_256();
				int num3 = class2.method_299().method_256();
				int num4 = class2.method_300().method_256();
				if (point_0.X > num3 && point_0.X < num3 + num && point_0.Y > num4 && point_0.Y < num4 + num2)
				{
					list.Add(i);
				}
			}
		}
		return list;
	}

	internal List<string> method_18(List<int> list_0)
	{
		string text = Class333.smethod_102();
		List<string> list = new List<string>();
		Class250 @class = method_12();
		foreach (int item in list_0)
		{
			Class243 class2 = @class.method_72()[item];
			int num = class2.method_297().method_256();
			text = class2.method_286();
			if (num > 0)
			{
				string text2 = class2.method_304().method_260();
				if (text2.Length <= 0)
				{
					text2 = Class333.aJz() + class2.method_299().method_256() + Class333.smethod_189() + class2.method_300().method_256() + Class333.smethod_189() + class2.method_302().method_256() + Class333.smethod_189() + class2.method_303().method_256() + Class333.aGk();
				}
				if (string.IsNullOrEmpty(text))
				{
					text = (BhN.ContainsKey(num) ? BhN[num] : Class333.BAS());
				}
				text2 = text2 + Class333.smethod_497() + text + Class333.smethod_9();
				list.Add(text2);
			}
		}
		return list;
	}

	private void method_19(int int_3, int int_4)
	{
		if (!BIf && (!Bho || Bhl.ContainsFocus))
		{
			return;
		}
		if (BID == -1)
		{
			method_13();
			return;
		}
		method_44(BID);
		Class250 @class = method_12();
		for (int i = 0; i < @class.method_72().Count; i++)
		{
			Class243 class2 = @class.method_72()[i];
			int num = @class.method_72()[i].method_297().method_256();
			int num2 = @class.method_72()[i].method_306().method_256();
			if (num > 0 && (i == BID - 1 || num2 == BID))
			{
				int num3 = int_3 - Bhz;
				int num4 = int_4 - BIA;
				if ((num3 != 0 || num4 != 0) && Math.Abs(num3) < BhW / 2 && Math.Abs(num4) < Bhw / 2)
				{
					int num5 = class2.method_299().method_256();
					int num6 = class2.method_300().method_256();
					int num7 = num5 + num3;
					int num8 = num6 + num4;
					class2.method_299().method_272(num7, bool_0: true);
					class2.method_300().method_272(num8, bool_0: true);
				}
			}
		}
		Bhz = int_3;
		BIA = int_4;
	}

	private void method_20()
	{
		Class250 @class = method_12();
		BID = -1;
		foreach (Class243 item in @class.method_72())
		{
			item.method_297().method_272(0, bool_0: true);
			Form23.smethod_74(item.method_297().method_64());
		}
	}

	internal bool method_21()
	{
		Class250 @class = method_12();
		if (@class != null)
		{
			return @class.method_73() >= @class.method_72().Count;
		}
		return true;
	}

	internal void method_22()
	{
		if (method_21() || BID == -1)
		{
			return;
		}
		Class250 @class = method_12();
		int num = -1;
		for (int i = 0; i < @class.method_72().Count; i++)
		{
			if (@class.method_72()[i].method_297().method_256() == 0)
			{
				num = i;
				break;
			}
		}
		if (num >= 0)
		{
			Class243 class2 = @class.method_72()[num];
			Class280 class3 = Form23.smethod_95();
			class3?.method_1();
			Class243 settingOrSpecialObject_ = @class.method_72()[BID - 1];
			class2.method_29(settingOrSpecialObject_, bool_0: true);
			class2.method_304().method_262(class2.method_304().method_260() + Class333.smethod_100() + num, bool_0: true);
			int num2 = method_26(class2);
			class2.method_301().method_272(num2, bool_0: true);
			class3?.method_4();
			Form23.smethod_76();
			while (Form23.smethod_77())
			{
				Application.DoEvents();
			}
			method_15(num);
		}
	}

	internal void method_23()
	{
		if (Bhi != null && Bhi.awP != null && BID > 0)
		{
			Bhi.awP.method_91(Bhj, BID - 1);
		}
	}

	internal void method_24()
	{
		if (method_21())
		{
			return;
		}
		Class250 @class = method_12();
		int num = -1;
		for (int i = 0; i < @class.method_72().Count; i++)
		{
			if (@class.method_72()[i].method_297().method_256() == 0)
			{
				num = i;
				break;
			}
		}
		if (num < 0 || Bhi == null || Bhi.awP == null)
		{
			return;
		}
		Class243 class2 = Bhi.awP.method_93(Bhj, num);
		if (class2 != null)
		{
			class2.method_299().method_272(Bhy, bool_0: true);
			class2.method_300().method_272(BhZ, bool_0: true);
			int num2 = method_26(class2);
			class2.method_301().method_272(num2, bool_0: true);
			class2.method_304().method_262(class2.method_304().method_260() + Class333.smethod_100() + num, bool_0: true);
			Form23.smethod_76();
			while (Form23.smethod_77())
			{
				Application.DoEvents();
			}
			method_15(num);
		}
	}

	internal void method_25(int int_3, int int_4, int int_5)
	{
		if (method_21())
		{
			return;
		}
		Class250 @class = method_12();
		int int_6 = -1;
		for (int i = 0; i < @class.method_72().Count; i++)
		{
			Class243 class2 = @class.method_72()[i];
			if (class2.method_297().method_256() == 0)
			{
				Class280 class3 = Form23.smethod_95();
				class3?.method_1();
				class2.method_297().method_272(int_3, bool_0: true);
				Form23.smethod_74(class2.method_297().method_64());
				while (Form23.smethod_77())
				{
					Application.DoEvents();
				}
				class2.method_295();
				class2.method_299().method_272(int_4, bool_0: true);
				Form23.smethod_74(class2.method_299().method_64());
				class2.method_300().method_272(int_5, bool_0: true);
				Form23.smethod_74(class2.method_300().method_64());
				class2.method_298().method_272(0, bool_0: true);
				Form23.smethod_74(class2.method_298().method_64());
				int num = method_26(class2);
				class2.method_301().method_272(num, bool_0: true);
				Form23.smethod_74(class2.method_301().method_64());
				string text = (BhN.ContainsKey(int_3) ? BhN[int_3] : Class333.BAS());
				class2.method_304().method_262(text + Class333.smethod_100() + i, bool_0: true);
				class3?.method_4();
				int_6 = i;
				break;
			}
		}
		method_15(int_6);
	}

	private int method_26(Class243 class243_0)
	{
		int num = 0;
		int val = 1;
		if (class243_0 != null && class243_0 != null)
		{
			int num2 = class243_0.method_302().method_256();
			int num3 = class243_0.method_303().method_256();
			int num4 = class243_0.method_299().method_256();
			int num5 = class243_0.method_300().method_256();
			val = class243_0.method_301().method_229();
			for (int i = 0; i < method_12().method_72().Count; i++)
			{
				Class243 @class = method_12().method_72()[i];
				if (@class != class243_0 && method_12().method_72()[i].method_297().method_256() > 0)
				{
					int num6 = @class.method_302().method_256();
					int num7 = @class.method_303().method_256();
					int num8 = @class.method_299().method_256();
					int num9 = @class.method_300().method_256();
					int val2 = @class.method_301().method_256();
					if ((smethod_3(num4, num8, num8 + num6) && smethod_3(num5, num9, num9 + num7)) || (smethod_3(num4 + num2, num8, num8 + num6) && smethod_3(num5, num9, num9 + num7)) || (smethod_3(num4, num8, num8 + num6) && smethod_3(num5 + num3, num9, num9 + num7)) || (smethod_3(num4 + num2, num8, num8 + num6) && smethod_3(num5 + num3, num9, num9 + num7)) || (smethod_3(num8, num4, num4 + num2) && smethod_3(num9, num5, num5 + num3)) || (smethod_3(num8 + num6, num4, num4 + num2) && smethod_3(num9, num5, num5 + num3)) || (smethod_3(num8, num4, num4 + num2) && smethod_3(num9 + num7, num5, num5 + num3)) || (smethod_3(num8 + num6, num4, num4 + num2) && smethod_3(num9 + num7, num5, num5 + num3)))
					{
						num = Math.Max(num, val2);
					}
				}
			}
		}
		return Math.Min(val, num + 1);
	}

	internal void method_27()
	{
		if (BID == -1)
		{
			method_13();
		}
		if (!method_42())
		{
			return;
		}
		int num = BID - 1;
		Class250 @class = method_12();
		if (num < @class.method_72().Count && @class.method_73() > 0)
		{
			Class243 class2 = @class.method_72()[num];
			Class280 class3 = Form23.smethod_95();
			class3?.method_1();
			class2.method_297().method_272(0, bool_0: true);
			Form23.smethod_74(class2.method_297().method_64());
			class3?.method_4();
			BID = -1;
			if (Bhl != null)
			{
				Bhl.method_16(0);
			}
			method_44(0);
			Thread.Sleep(10);
		}
	}

	private void method_28(int int_3)
	{
		if (BID == -1)
		{
			method_13();
		}
		if (BID != -1)
		{
			Class243 @class = method_12().method_72()[BID - 1];
			@class.method_297().method_256();
			int num = @class.method_302().method_256();
			int num2 = @class.method_303().method_256();
			Class280 class2 = Form23.smethod_95();
			class2?.method_1();
			double num3 = (double)int_3 / 100.0;
			@class.method_302().method_272((int)((double)num * num3), bool_0: true);
			Form23.smethod_74(@class.method_302().method_64());
			@class.method_303().method_272((int)((double)num2 * num3), bool_0: true);
			Form23.smethod_74(@class.method_303().method_64());
			class2?.method_4();
		}
	}

	private void method_29(int int_3, int int_4, Enum23 enum23_0)
	{
		Struct8 struct8_ = default;
		struct8_.BUt = this;
		struct8_.BUu = int_3;
		struct8_.BUW = int_4;
		if (BID == -1)
		{
			method_13();
		}
		if (BID == -1)
		{
			return;
		}
		BhQ = false;
		Class250 @class = method_12();
		struct8_.BUU = @class.method_72()[BID - 1];
		int item = struct8_.BUU.method_297().method_256();
		if (Bhn.Contains(item) || enum23_0 == Enum23.BUp || enum23_0 == Enum23.BUP || enum23_0 == Enum23.BUq || enum23_0 == Enum23.BUQ)
		{
			BhQ = true;
		}
		int num = struct8_.BUU.method_302().method_256();
		int num2 = struct8_.BUU.method_303().method_256();
		struct8_.BUV = struct8_.BUU.method_299().method_256();
		struct8_.BUX = struct8_.BUU.method_300().method_256();
		struct8_.BUv = struct8_.BUV + num;
		struct8_.BUw = struct8_.BUX + num2;
		switch (enum23_0)
		{
		case Enum23.BUN:
			method_56(ref struct8_);
			break;
		case Enum23.BUn:
			method_55(ref struct8_);
			break;
		case Enum23.BUO:
			method_57(ref struct8_);
			break;
		case Enum23.BUo:
			method_58(ref struct8_);
			break;
		case Enum23.BUP:
		{
			if (!BhP && !BhQ)
			{
				method_57(ref struct8_);
				method_56(ref struct8_);
				break;
			}
			int int_5 = Math.Abs(struct8_.BUu - struct8_.BUv);
			int num3 = method_52(int_5, ref struct8_);
			struct8_.BUU.method_299().method_272(Math.Min(struct8_.BUu, struct8_.BUv), bool_0: true);
			struct8_.BUU.method_300().method_272(struct8_.BUw - num3, bool_0: true);
			struct8_.BUU.method_303().method_272(num3, bool_0: true);
			struct8_.BUU.method_302().method_272(int_5, bool_0: true);
			method_54(int_5, ref struct8_);
			break;
		}
		case Enum23.BUp:
			method_56(ref struct8_);
			if (!BhP && !BhQ)
			{
				method_58(ref struct8_);
			}
			break;
		case Enum23.BUQ:
			method_57(ref struct8_);
			if (!BhP && !BhQ)
			{
				method_55(ref struct8_);
			}
			break;
		case Enum23.BUq:
			method_55(ref struct8_);
			if (!BhP && !BhQ)
			{
				method_58(ref struct8_);
			}
			break;
		}
	}

	private void method_30(int int_3)
	{
		BID = -1;
		method_44(0);
		Bho = false;
		BIF = (double)int_3 / 100.0;
		if (BhM != null)
		{
			BhM.method_0(int_3);
		}
		method_12();
		Bhi.awP.method_78().method_272(int_3, bool_0: true);
		Form23.smethod_74(Bhi.awP.method_78().method_64());
		int BUY = Math.Max((int)((double)BhW * BIF), 470);
		int BUy = (int)((double)Bhw * BIF) + 26;
		Size BUZ = new Size((int)((double)BhW * BIF), BUy - 26);
		if (Bhk.InvokeRequired)
		{
			Bhk.Invoke(() =>
			{
				Width = BUY;
				Height = BUy;
				Bhk.Size = BUZ;
			});
		}
		else
		{
			Width = BUY;
			Height = BUy;
			Bhk.Size = BUZ;
		}
		method_38();
		method_39();
		if (Bhx != null)
		{
			Bhx.method_13(BIF);
		}
		if (Bhk.InvokeRequired)
		{
			Bhk.Invoke(() =>
			{
				Refresh();
			});
		}
		else
		{
			Refresh();
		}
		if (Bhl != null && Parent != null)
		{
			if (Bhl.InvokeRequired)
			{
				Bhl.Invoke(() =>
				{
					Bhl.Top = Top + Height + 10;
				});
			}
			else
			{
				Bhl.Top = Top + Height + 10;
			}
		}
		Thread.Sleep(100);
	}

	internal void method_31(int int_3)
	{
		method_28(int_3);
	}

	internal void method_32(int int_3)
	{
		method_30(int_3);
		Class329.smethod_6();
	}

	internal void method_33(bool bool_0)
	{
		BIe = bool_0;
		if (!BIe)
		{
			method_32(100);
		}
	}

	private void method_34()
	{
		if (BIE != null)
		{
			BIE.Close();
			BIE = null;
		}
		BIE = new System.Timers.Timer();
		BIE.Interval = 500.0;
		BIE.SynchronizingObject = this;
		BIE.Elapsed += BIE_Elapsed;
		BIE.AutoReset = true;
		BIE.Enabled = true;
		BIE.Start();
	}

	private void method_35()
	{
		if (Parent == null || !(Parent is Class131))
		{
			return;
		}
		int num = Math.Min((int)(BIF * 100.0), 100);
		int val = 100;
		if (Width > Parent.Width - 20 || Width < BhW)
		{
			val = (Parent.Width - 40) * 100 / BhW;
			val = Math.Min(val, 100);
			val = Math.Max(val, 60);
		}
		int val2 = 100;
		if (Bhl != null)
		{
			int num2 = Parent.Height - (Bhl.Top - (Parent as Class131).AutoScrollPosition.Y);
			if (num2 >= 200 && num2 <= 220)
			{
				val2 = num;
			}
			else
			{
				int num3 = Height - 26;
				val2 = (num3 - (220 - num2)) * 100 / num3;
				val2 = val2 * num3 / Bhw;
			}
			val2 = Math.Min(val2, 100);
			val2 = Math.Max(val2, 60);
		}
		int num4 = Math.Min(val2, val);
		if (num4 >= num - 5 && num4 <= num + 5)
		{
			if (Bhi.awP.method_78().method_256() != num)
			{
				Bhi.awP.method_78().method_272(num, bool_0: true);
			}
		}
		else
		{
			method_32(num4);
		}
	}

	private void method_36()
	{
		if (!method_42())
		{
			return;
		}
		Class250 @class = method_12();
		if (@class != null)
		{
			Class243 class2 = @class.method_72()[BID - 1];
			if (class2 != null && class2.method_297().method_256() <= 0)
			{
				method_44(0);
			}
		}
	}

	private bool method_37()
	{
		bool BUz = false;
		if (Form23.form23_0.control25_0.InvokeRequired)
		{
			Form23.form23_0.control25_0.Invoke(() =>
			{
				BUz = Form23.form23_0.control25_0.method_24(this);
			});
		}
		else
		{
			BUz = Form23.form23_0.control25_0.method_24(this);
		}
		return BUz;
	}

	private void BIE_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (method_37() && (!Class329.smethod_3() || Class329.Bdy != BhM))
		{
			if (Process.GetProcessesByName(Class333.smethod_360()).Length == 0)
			{
				return;
			}
			Class329.smethod_0(Bhi, BhM);
			Class329.smethod_6();
			Class329.smethod_5();
		}
		if (BIe && Visible && method_37())
		{
			method_35();
		}
		if (Bhi != null && Bhi.awP.method_97())
		{
			method_36();
		}
		if (Bhk == null)
		{
			return;
		}
		if (Bhk.InvokeRequired)
		{
			Bhk.Invoke(() =>
			{
				Bhk.method_0();
			});
		}
		else
		{
			Bhk.method_0();
		}
		if (BhL.InvokeRequired)
		{
			BhL.Invoke(() =>
			{
				BhL.BringToFront();
			});
		}
		else
		{
			BhL.BringToFront();
		}
		if (BhM.InvokeRequired)
		{
			BhM.Invoke(() =>
			{
				BhM.BringToFront();
			});
		}
		else
		{
			BhM.BringToFront();
		}
	}

	private void method_38()
	{
		if (BhL.InvokeRequired)
		{
			BhL.Invoke(() =>
			{
				BhL.Left = 0;
				BhL.Top = 0;
				BhL.Width = (int)((double)BhW * BIF);
				BhL.Height = Height - 26;
			});
		}
		else
		{
			BhL.Left = 0;
			BhL.Top = 0;
			BhL.Width = (int)((double)BhW * BIF);
			BhL.Height = Height - 26;
		}
	}

	private void method_39()
	{
		if (BhM.InvokeRequired)
		{
			BhM.Invoke(() =>
			{
				BhM.Left = 0;
				BhM.Top = BhL.Height;
				BhM.Width = Width;
				BhM.Height = 26;
			});
		}
		else
		{
			BhM.Left = 0;
			BhM.Top = BhL.Height;
			BhM.Width = Width;
			BhM.Height = 26;
		}
	}

	private void Class88_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if ((uint)(keyCode - 37) <= 3u || keyCode == Keys.Delete)
		{
			e.IsInputKey = true;
		}
	}

	private void method_40(object sender, KeyEventArgs e)
	{
		if (Focused && method_42())
		{
			BIf = true;
			int num = 5;
			if (Control.ModifierKeys.HasFlag(Keys.Control))
			{
				num = 1;
			}
			else if (Control.ModifierKeys.HasFlag(Keys.Shift))
			{
				num = 10;
			}
			Class243 @class = method_12().method_72()[BID - 1];
			switch (e.KeyValue)
			{
			case 67:
				if (Control.ModifierKeys.HasFlag(Keys.Control) && Bhi != null && Bhi.awP.method_97() && Form23.form23_0.control4_0.method_0().method_3() != null && Form23.form23_0.control4_0.method_0().method_3().Tag is MenuNode && (Form23.form23_0.control4_0.method_0().method_3().Tag as MenuNode).method_38() && Form23.form23_0.control4_0.method_0().method_3().Parent != null && Form23.form23_0.control4_0.method_0().method_3().Parent.Tag is MenuNode && (Form23.form23_0.control4_0.method_0().method_3().Parent.Tag as MenuNode).method_37())
				{
					method_23();
				}
				e.Handled = true;
				break;
			case 46:
				if (Form23.form23_0.control4_0.method_0().method_3() != null && Form23.form23_0.control4_0.method_0().method_3().Tag is MenuNode && (Form23.form23_0.control4_0.method_0().method_3().Tag as MenuNode).method_38() && Form23.form23_0.control4_0.method_0().method_3().Parent != null && Form23.form23_0.control4_0.method_0().method_3().Parent.Tag is MenuNode && (Form23.form23_0.control4_0.method_0().method_3().Parent.Tag as MenuNode).method_37())
				{
					Form23.form23_0.control4_0.method_0().method_4(Form23.form23_0.control4_0.method_0().method_3().Parent);
				}
				method_27();
				e.Handled = true;
				break;
			case 37:
			{
				Class280 class4 = Form23.smethod_95();
				class4?.method_1();
				method_19(Bhz - num, BIA);
				class4?.method_4();
				Form23.smethod_74(@class.method_299().method_64());
				Form23.smethod_74(@class.method_300().method_64());
				e.Handled = true;
				break;
			}
			case 38:
			{
				Class280 class3 = Form23.smethod_95();
				class3?.method_1();
				method_19(Bhz, BIA - num);
				class3?.method_4();
				Form23.smethod_74(@class.method_299().method_64());
				Form23.smethod_74(@class.method_300().method_64());
				e.Handled = true;
				break;
			}
			case 39:
			{
				Class280 class5 = Form23.smethod_95();
				class5?.method_1();
				method_19(Bhz + num, BIA);
				class5?.method_4();
				Form23.smethod_74(@class.method_299().method_64());
				Form23.smethod_74(@class.method_300().method_64());
				e.Handled = true;
				break;
			}
			case 40:
			{
				Class280 class2 = Form23.smethod_95();
				class2?.method_1();
				method_19(Bhz, BIA + num);
				class2?.method_4();
				Form23.smethod_74(@class.method_299().method_64());
				Form23.smethod_74(@class.method_300().method_64());
				e.Handled = true;
				break;
			}
			}
		}
		if (Focused && Bhi != null && Bhi.awP.method_97() && Control.ModifierKeys.HasFlag(Keys.Control) && e.KeyValue == 86)
		{
			method_24();
			e.Handled = true;
		}
		BIf = false;
	}

	private void BhL_MouseDown(object sender, MouseEventArgs e)
	{
		if (!method_37())
		{
			return;
		}
		int left = BhL.Left;
		int top = BhL.Top;
		int width = BhL.Width;
		int height = BhL.Height;
		Bhy = (int)((double)(e.X + left) / BIF);
		BhZ = (int)((double)(e.Y + top) / BIF);
		BII = Enum23.BUm;
		if (e.Button == MouseButtons.Left)
		{
			Bho = true;
			BhP = (Control.ModifierKeys & Keys.Shift) == Keys.Shift;
			Bhp = (Control.ModifierKeys & Keys.Control) == Keys.Control;
			BhY = PointToScreen(new Point(BhL.Left, BhL.Top));
			int num = ((Bhi.awP.method_76() == null) ? (-1) : Bhi.awP.method_76().method_256());
			if (num != -1)
			{
				BID = num;
				method_13(BID);
			}
			if (BID == -1 || num == -1)
			{
				method_13();
			}
			if (method_42())
			{
				Bhu = System.Windows.Forms.Cursor.Current;
				System.Windows.Forms.Cursor.Current = Cursors.Cross;
				BhV = System.Windows.Forms.Cursor.Current;
				Class243 @class = method_12().method_72()[BID - 1];
				Bhz = Bhy;
				BIA = BhZ;
				width = @class.method_302().method_256();
				height = @class.method_303().method_256();
				int num2 = @class.method_299().method_256();
				int num3 = @class.method_300().method_256();
				int num4 = num2 + width;
				int num5 = num3 + height;
				BhT = (float)height / (float)width;
				int item = @class.method_297().method_256();
				if (Bhn.Contains(item))
				{
					BhQ = true;
				}
				else
				{
					BhQ = false;
				}
				Bhq = width;
				BhR = @class.method_315().method_256();
				Bhr = @class.method_316().method_256();
				BhS = @class.method_317().method_256();
				if (Math.Abs(Bhy - num4) <= 10)
				{
					if (Math.Abs(BhZ - num3) <= 10)
					{
						BII = Enum23.BUQ;
						System.Windows.Forms.Cursor.Current = Cursors.SizeNESW;
						BhV = System.Windows.Forms.Cursor.Current;
					}
					else if (Math.Abs(BhZ - num5) <= 10)
					{
						BII = Enum23.BUq;
						System.Windows.Forms.Cursor.Current = Cursors.SizeNWSE;
						BhV = System.Windows.Forms.Cursor.Current;
					}
					else
					{
						BII = Enum23.BUn;
						System.Windows.Forms.Cursor.Current = Cursors.SizeWE;
						BhV = System.Windows.Forms.Cursor.Current;
					}
				}
				else if (Math.Abs(Bhy - num2) <= 10)
				{
					if (Math.Abs(BhZ - num3) <= 10)
					{
						BII = Enum23.BUP;
						System.Windows.Forms.Cursor.Current = Cursors.SizeNWSE;
						BhV = System.Windows.Forms.Cursor.Current;
					}
					else if (Math.Abs(BhZ - num5) <= 10)
					{
						BII = Enum23.BUp;
						System.Windows.Forms.Cursor.Current = Cursors.SizeNESW;
						BhV = System.Windows.Forms.Cursor.Current;
					}
					else
					{
						BII = Enum23.BUN;
						System.Windows.Forms.Cursor.Current = Cursors.SizeWE;
						BhV = System.Windows.Forms.Cursor.Current;
					}
				}
				else if (Math.Abs(BhZ - num3) <= 10)
				{
					BII = Enum23.BUO;
					System.Windows.Forms.Cursor.Current = Cursors.SizeNS;
					BhV = System.Windows.Forms.Cursor.Current;
				}
				else if (Math.Abs(BhZ - num5) <= 10)
				{
					BII = Enum23.BUo;
					System.Windows.Forms.Cursor.Current = Cursors.SizeNS;
					BhV = System.Windows.Forms.Cursor.Current;
				}
				@class.method_299().method_44();
				@class.method_300().method_44();
				@class.method_302().method_44();
				@class.method_303().method_44();
			}
			else
			{
				Bho = false;
				method_44(0);
				System.Windows.Forms.Cursor.Current = Bhu;
				BhV = System.Windows.Forms.Cursor.Current;
			}
			return;
		}
		try
		{
			if (Bho && BID == -1)
			{
				Bho = false;
				method_44(0);
				return;
			}
			Class250 class2 = method_12();
			if (BID <= -1 || BID >= class2.method_72().Count || (class2 != null && class2.method_72()[BID - 1] != null && class2.method_72()[BID - 1].method_297().method_256() == 0))
			{
				BID = -1;
			}
			BIG.method_3(new Point(Bhy, BhZ), BID);
			BIG.Show(this, e.Location);
		}
		catch
		{
		}
	}

	internal void method_41(int int_3, int int_4)
	{
		if (!method_37())
		{
			return;
		}
		Class250 @class = method_12();
		int num = -32767;
		int num2 = Bhs;
		int count = @class.method_72().Count;
		int int_5 = -BhW;
		int int_6 = -Bhw;
		int int_7 = BhW * 2;
		int int_8 = Bhw * 2;
		int num3 = BhW * 2;
		int num4 = Bhw * 2;
		for (int i = 0; i < count; i++)
		{
			Class243 class2 = @class.method_72()[i];
			if (@class.method_72()[i].method_297().method_256() <= 0)
			{
				continue;
			}
			int num5 = class2.method_302().method_256();
			int num6 = class2.method_303().method_256();
			int num7 = class2.method_299().method_256();
			int num8 = class2.method_300().method_256();
			if (smethod_4(int_3, num7, num7 + num5) && smethod_4(int_4, num8, num8 + num6))
			{
				int num9 = class2.method_301().method_256();
				int num10 = class2.method_306().method_256();
				if (num9 > num || (smethod_4(num7, int_5, int_7) && smethod_4(num7 + num5, int_5, int_7) && smethod_4(num8, int_6, int_8) && smethod_4(num8 + num6, int_6, int_8) && num10 != num2 && num5 < num3 && num6 < num4))
				{
					num3 = (BIa = num5);
					num4 = (BIB = num6);
					num = num9;
					num2 = i + 1;
					int_5 = num7;
					int_6 = num8;
					int_7 = num7 + num5;
					int_8 = num8 + num6;
				}
			}
		}
		if (num2 != Bhs || num2 == -1)
		{
			method_45(num2);
		}
		BhU = Environment.TickCount;
	}

	private bool method_42()
	{
		return BID != -1;
	}

	private void BhL_MouseMove(object sender, MouseEventArgs e)
	{
		if (!method_37() || !DisplayRectangle.Contains(new Point(e.X, e.Y)))
		{
			return;
		}
		int left = BhL.Left;
		int top = BhL.Top;
		int num = (int)((double)(e.X + left) / BIF);
		int num2 = (int)((double)(e.Y + top) / BIF);
		if (Environment.TickCount - BhU > 200 && !Bho)
		{
			method_41(num, num2);
		}
		if (Bhi.awP.method_76() != null)
		{
			Bhi.awP.method_76().method_256();
		}
		if (BIb || !method_42())
		{
			return;
		}
		BIb = true;
		int num3 = (int)((double)e.X / BIF);
		int num4 = (int)((double)e.Y / BIF);
		if (Bho && method_14(new Point(num3, num4), BID, 100))
		{
			if ((Math.Abs(num - Bhy) != 0 || Math.Abs(num2 - BhZ) != 0) && BIc == null && BIC != -1)
			{
				BIc = Form23.smethod_95();
				if (BIc != null)
				{
					BIc.method_1();
				}
			}
			if (BII != Enum23.BUm)
			{
				if (BIC != BID && Math.Abs(num3 - Bhz) <= 5 && Math.Abs(num4 - BIA) <= 5)
				{
					BIC = BID;
				}
				else
				{
					method_29(num3, num4, BII);
				}
			}
			else if (System.Windows.Forms.Cursor.Current == Cursors.Cross && method_14(new Point(num3, num4), BID, 10) && (BIC == BID || Math.Abs(num3 - Bhz) > 5 || Math.Abs(num4 - BIA) > 5))
			{
				method_19(num3, num4);
			}
			else
			{
				BIC = BID;
				BIb = false;
			}
		}
		else if (BID != -1 && method_14(new Point(num3, num4), BID, 10))
		{
			Class243 @class = method_12().method_72()[BID - 1];
			int num5 = @class.method_302().method_256();
			int num6 = @class.method_303().method_256();
			int num7 = @class.method_299().method_256();
			int num8 = @class.method_300().method_256();
			int num9 = num7 + num5;
			int num10 = num8 + num6;
			if (Math.Abs(num3 - num9) <= 10)
			{
				if (Math.Abs(num4 - num8) <= 10)
				{
					BII = Enum23.BUQ;
					System.Windows.Forms.Cursor.Current = Cursors.SizeNESW;
					BhV = System.Windows.Forms.Cursor.Current;
				}
				else if (Math.Abs(num4 - num10) <= 10)
				{
					BII = Enum23.BUq;
					System.Windows.Forms.Cursor.Current = Cursors.SizeNWSE;
					BhV = System.Windows.Forms.Cursor.Current;
				}
				else
				{
					BII = Enum23.BUn;
					System.Windows.Forms.Cursor.Current = Cursors.SizeWE;
					BhV = System.Windows.Forms.Cursor.Current;
				}
			}
			else if (Math.Abs(num3 - num7) <= 10)
			{
				if (Math.Abs(num4 - num8) <= 10)
				{
					BII = Enum23.BUP;
					System.Windows.Forms.Cursor.Current = Cursors.SizeNWSE;
					BhV = System.Windows.Forms.Cursor.Current;
				}
				else if (Math.Abs(num4 - num10) <= 10)
				{
					BII = Enum23.BUp;
					System.Windows.Forms.Cursor.Current = Cursors.SizeNESW;
					BhV = System.Windows.Forms.Cursor.Current;
				}
				else
				{
					BII = Enum23.BUN;
					System.Windows.Forms.Cursor.Current = Cursors.SizeWE;
					BhV = System.Windows.Forms.Cursor.Current;
				}
			}
			else if (Math.Abs(num4 - num8) <= 10)
			{
				BII = Enum23.BUO;
				System.Windows.Forms.Cursor.Current = Cursors.SizeNS;
				BhV = System.Windows.Forms.Cursor.Current;
			}
			else if (Math.Abs(num4 - num10) <= 10)
			{
				BII = Enum23.BUo;
				System.Windows.Forms.Cursor.Current = Cursors.SizeNS;
				BhV = System.Windows.Forms.Cursor.Current;
			}
			else
			{
				System.Windows.Forms.Cursor.Current = Bhu;
				BhV = System.Windows.Forms.Cursor.Current;
			}
		}
		else if (BID != -1 && BII != Enum23.BUm && !method_14(new Point(num3, num4), BID, 10))
		{
			BII = Enum23.BUm;
			System.Windows.Forms.Cursor.Current = Bhu;
			BIC = -1;
		}
		BIb = false;
	}

	private void BhL_MouseUp(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left)
		{
			return;
		}
		if (method_42() && Bho)
		{
			Class243 @class = method_12().method_72()[BID - 1];
			@class.method_299().method_43();
			@class.method_300().method_43();
			@class.method_302().method_43();
			@class.method_303().method_43();
			if (BIc != null)
			{
				BIc.method_4();
				Form23.smethod_74(@class.method_299().method_64());
				Form23.smethod_74(@class.method_300().method_64());
				Form23.smethod_74(@class.method_302().method_64());
				Form23.smethod_74(@class.method_303().method_64());
			}
		}
		Bho = false;
		BIc = null;
		BIC = -1;
		BIb = false;
		System.Windows.Forms.Cursor.Current = Bhu;
		BhV = System.Windows.Forms.Cursor.Current;
	}

	private void method_43(object sender, EventArgs e)
	{
		Bho = false;
	}

	private void method_44(int int_3)
	{
		if (int_3 >= 0 && method_37())
		{
			Bhi.awP.method_75().method_272(int_3, bool_0: true);
			Class329.smethod_6(BhM != null && BhM.class55_0 != null && BhM.class55_0.BiE);
		}
	}

	private void method_45(int int_3)
	{
		if (int_3 >= -1 && method_37())
		{
			if (Bhi.awP.method_76() != null)
			{
				Bhi.awP.method_76().method_272(int_3, bool_0: true);
			}
			Class329.smethod_6(BhM != null && BhM.class55_0 != null && BhM.class55_0.BiE);
			Bhs = int_3;
		}
	}

	private void method_46(int int_3)
	{
		if (method_42())
		{
			Class243 @class = method_12().method_72()[BID - 1];
			int num = @class.method_301().method_256();
			@class.method_301().method_272(num + int_3, bool_0: true);
			Form23.smethod_74(@class.method_301().method_64());
			Bhi.method_22()[@class.method_301().method_65()] = Enum93.aYK;
		}
	}

	private void method_47(int int_3)
	{
		if (int_3 >= 0)
		{
			Bho = false;
			BID = -1;
			Bhj = int_3;
			Bhi.awP.method_74().method_272(int_3, bool_0: true);
			method_44(0);
			method_45(0);
		}
	}

	private void method_48(object sender, EventArgs e)
	{
		int int_ = Bhi.awP.method_74().method_256();
		if (BIh != Form23.form23_0.control25_0.SelectedIndex)
		{
			BIh = Form23.form23_0.control25_0.SelectedIndex;
			Form23.form23_0.control4_0.method_50(int_);
			if (method_37())
			{
				Class329.smethod_5();
			}
		}
	}

	private void method_49(object sender, EventArgs e)
	{
		int num = Bhi.awP.method_74().method_256();
		if (BIh != Form23.form23_0.control25_0.SelectedIndex || num != Bhj)
		{
			BIh = Form23.form23_0.control25_0.SelectedIndex;
			Form23.form23_0.control4_0.method_49(num);
			if (method_37())
			{
				Class329.smethod_5();
			}
		}
	}

	private void Class88_HandleDestroyed(object sender, EventArgs e)
	{
		if (Bhk != null)
		{
			Controls.Remove(Bhk);
		}
		Controls.Remove(BhL);
		Controls.Remove(BhM);
		method_51();
	}

	private void method_50()
	{
		BhL.MouseDown += BhL_MouseDown;
		BhL.MouseUp += BhL_MouseUp;
		BhL.LostFocus += BhL_LostFocus;
		HandleDestroyed += Class88_HandleDestroyed;
		if (Bhi.awP.method_97())
		{
			BhL.MouseMove += BhL_MouseMove;
			Form23.form23_0.KeyDown += method_40;
		}
		PreviewKeyDown += Class88_PreviewKeyDown;
	}

	private void BhL_LostFocus(object sender, EventArgs e)
	{
		BIb = false;
	}

	private void method_51()
	{
		BhL.MouseDown -= BhL_MouseDown;
		BhL.MouseUp -= BhL_MouseUp;
		BhL.LostFocus -= BhL_LostFocus;
		HandleDestroyed -= Class88_HandleDestroyed;
		if (Bhi.awP.method_97())
		{
			BhL.MouseMove -= BhL_MouseMove;
			Form23.form23_0.KeyDown -= method_40;
		}
		PreviewKeyDown -= Class88_PreviewKeyDown;
		if (BIE != null)
		{
			BIE.Stop();
			BIE.Elapsed -= BIE_Elapsed;
			BIE.Dispose();
			BIE = null;
		}
	}

	protected override void Dispose(bool disposing)
	{
		Bhi.awP.method_74().method_265(method_49);
		Form23.form23_0.control25_0.method_1(method_48);
		try
		{
			Bhi.awP.method_75().method_272(0, bool_0: true);
			Class329.smethod_6();
			if (BhM != null)
			{
				BhM.Dispose();
			}
			if (BIG != null)
			{
				BIG.Dispose();
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	internal Class88(Class250 class250_0, Framework framework_0, Rectangle rectangle_0, bool bool_0, Class108 class108_0)
		: base(rectangle_0, bool_0, bool_1: true, bool_2: false)
	{
		Bhi = framework_0;
		BhJ = rectangle_0;
		Bhx = class108_0;
		BhW = smethod_0(Bhi);
		Bhw = smethod_1(Bhi);
		Bhj = Bhi.awP.method_79().IndexOf(class250_0);
		BhM = new Class51(Bhi, Bhx);
		Bhm = Bhi.awP.method_96();
		foreach (Setting.ListItems.Struct45 item in Bhm)
		{
			BhN.Add(item.bBv, item.bBV);
			if (Bhi.awP.method_97() && item.bBx.Contains(Class333.BAs()))
			{
				Bhn.Add(item.bBv);
			}
		}
		GC.Collect();
		int num = Bhi.awP.method_78().method_256();
		if (num == 0)
		{
			num = 100;
		}
		BIF = (double)num / 100.0;
		BhM.method_0(num);
		Width = Math.Max((int)((double)BhW * BIF), 470);
		Height = (int)((double)Bhw * BIF) + 26;
		if (Bhx != null)
		{
			Bhx.method_13(BIF);
		}
		if (Bhk == null || Bhk.Disposing || Bhk.IsDisposed)
		{
			Bhk = new VirtualDashAppPanel();
		}
		if (!BIg)
		{
			Bhk.Location = new Point(0, 0);
			Bhk.Name = Class333.BAT();
			Bhk.Size = new Size((int)((double)BhW * BIF), Height - 26);
			Bhk.TabIndex = 0;
			if (!Controls.Contains(Bhk))
			{
				Controls.Add(Bhk);
			}
			Bhk.method_1(Bhk);
		}
		SetStyle(ControlStyles.DoubleBuffer, value: true);
		SetStyle(ControlStyles.UserPaint, value: true);
		SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
		if (!Controls.Contains(BhM))
		{
			Controls.Add(BhM);
		}
		if (!Controls.Contains(BhL))
		{
			Controls.Add(BhL);
		}
		method_38();
		method_39();
		if (Bhl != null && Parent != null)
		{
			Bhl.Top = Top + Height + 10;
		}
		BhL.BringToFront();
		BhM.BringToFront();
		method_50();
		method_34();
		method_47(Bhj);
		BIG = new Class43(this);
		Bhi.awP.method_74().method_264(method_49);
		Form23.form23_0.control25_0.method_0(method_48);
	}

	[CompilerGenerated]
	internal static bool smethod_2(int int_3, int int_4, int int_5)
	{
		if (int_3 <= int_5)
		{
			return int_3 >= int_4;
		}
		return false;
	}

	[CompilerGenerated]
	internal static bool smethod_3(int int_3, int int_4, int int_5)
	{
		if (int_3 <= int_5)
		{
			return int_3 >= int_4;
		}
		return false;
	}

	[CompilerGenerated]
	private int method_52(int int_3, ref Struct8 struct8_0)
	{
		return (int)((float)int_3 * BhT);
	}

	[CompilerGenerated]
	private int method_53(int int_3, ref Struct8 struct8_0)
	{
		return (int)((float)int_3 / BhT);
	}

	[CompilerGenerated]
	private void method_54(int int_3, ref Struct8 struct8_0)
	{
		float num = (float)int_3 / Bhq;
		struct8_0.BUU.method_315().method_272(Math.Max(1, (int)((float)BhR * num)), bool_0: true);
		struct8_0.BUU.method_316().method_272(Math.Max(1, (int)((float)Bhr * num)), bool_0: true);
		struct8_0.BUU.method_317().method_272(Math.Max(1, (int)((float)BhS * num)), bool_0: true);
	}

	[CompilerGenerated]
	private void method_55(ref Struct8 struct8_0)
	{
		int int_ = Math.Abs(struct8_0.BUu - struct8_0.BUV);
		struct8_0.BUU.method_299().method_272(Math.Min(struct8_0.BUu, struct8_0.BUV), bool_0: true);
		struct8_0.BUU.method_302().method_272(int_, bool_0: true);
		if (BhP || BhQ)
		{
			int num = method_52(int_, ref struct8_0);
			struct8_0.BUU.method_303().method_272(num, bool_0: true);
			method_54(int_, ref struct8_0);
		}
	}

	[CompilerGenerated]
	private void method_56(ref Struct8 struct8_0)
	{
		int int_ = Math.Abs(struct8_0.BUu - struct8_0.BUv);
		struct8_0.BUU.method_299().method_272(Math.Min(struct8_0.BUu, struct8_0.BUv), bool_0: true);
		struct8_0.BUU.method_302().method_272(int_, bool_0: true);
		if (BhP || BhQ)
		{
			int num = method_52(int_, ref struct8_0);
			struct8_0.BUU.method_303().method_272(num, bool_0: true);
			method_54(int_, ref struct8_0);
		}
	}

	[CompilerGenerated]
	private void method_57(ref Struct8 struct8_0)
	{
		struct8_0.BUU.method_300().method_272(Math.Min(struct8_0.BUW, struct8_0.BUw), bool_0: true);
		struct8_0.BUU.method_303().method_272(Math.Abs(struct8_0.BUW - struct8_0.BUw), bool_0: true);
		if (BhP || BhQ)
		{
			int int_ = method_53(Math.Abs(struct8_0.BUW - struct8_0.BUw), ref struct8_0);
			struct8_0.BUU.method_302().method_272(int_, bool_0: true);
			method_54(int_, ref struct8_0);
		}
	}

	[CompilerGenerated]
	private void method_58(ref Struct8 struct8_0)
	{
		struct8_0.BUU.method_300().method_272(Math.Min(struct8_0.BUW, struct8_0.BUX), bool_0: true);
		struct8_0.BUU.method_303().method_272(Math.Abs(struct8_0.BUW - struct8_0.BUX), bool_0: true);
		if (BhP || BhQ)
		{
			int int_ = method_53(Math.Abs(struct8_0.BUW - struct8_0.BUX), ref struct8_0);
			struct8_0.BUU.method_302().method_272(int_, bool_0: true);
			method_54(int_, ref struct8_0);
		}
	}

	[CompilerGenerated]
	private void method_59()
	{
		BhL.BringToFront();
	}

	[CompilerGenerated]
	private void method_60()
	{
		BhM.BringToFront();
	}

	[CompilerGenerated]
	private void method_61()
	{
		BhL.Left = 0;
		BhL.Top = 0;
		BhL.Width = (int)((double)BhW * BIF);
		BhL.Height = Height - 26;
	}

	[CompilerGenerated]
	private void method_62()
	{
		BhM.Left = 0;
		BhM.Top = BhL.Height;
		BhM.Width = Width;
		BhM.Height = 26;
	}

	[CompilerGenerated]
	internal static bool smethod_4(int int_3, int int_4, int int_5)
	{
		if (int_3 <= int_5)
		{
			return int_3 >= int_4;
		}
		return false;
	}
}
