using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns1;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns0;

internal class Class51 : Panel
{
	private class Class52
	{
		internal Class248 BIT;

		internal int BIt;

		internal Class88.Enum24 BIU;

		internal DateTime BIu;

		internal bool BIV;
	}

	internal enum Enum25
	{
		BIv,
		BIW,
		BIw
	}

	internal enum Enum26
	{
		BIX,
		BIx
	}

	internal enum Enum27
	{
		BIY,
		BIy,
		BIZ
	}

	internal enum Enum28
	{
		BIz,
		BiA
	}

	internal class Class53
	{
		[CompilerGenerated]
		private sealed class Class54
		{
			public Class51 BuC;

			public int Buc;

			public int BuD;

			public MethodInvoker Bud;

			internal void method_0()
			{
				BuC.trackBar_0.Minimum = Buc;
				BuC.trackBar_0.Maximum = BuD;
			}

			internal void method_1()
			{
				BuC.trackBar_0.Minimum = Buc;
				BuC.trackBar_0.Maximum = BuD;
			}
		}

		private Framework Bia;

		public Enum26 BiB;

		public int Bib;

		public int BiC;

		public Class243 Bic;

		public Thread BiD;

		internal Class51 Bid;

		internal Class53(Framework framework_0, Class243 class243_0, Class51 class51_0)
		{
			Bia = framework_0;
			Bic = class243_0;
			Bid = class51_0;
			Bib = class243_0.method_305().method_256();
			BiB = Enum26.BIX;
			BiC = 0;
		}

		internal Class53(Framework framework_0, int int_0)
		{
			Bia = framework_0;
			Bic = null;
			Bib = int_0;
			BiB = Enum26.BIX;
			BiC = 0;
		}

		internal void method_0(object object_0)
		{
			if (Bib <= 0 || Bic == null)
			{
				return;
			}
			smethod_0(Bia, Bic, out var setting_, out var setting_2, out var setting_3);
			int Buc = setting_.method_256();
			int BuD = setting_2.method_256();
			int num = setting_3.method_256();
			Class51 BuC = object_0 as Class51;
			if (BuC.InvokeRequired)
			{
				BuC.Invoke((MethodInvoker)(() =>
				{
					BuC.trackBar_0.Minimum = Buc;
					BuC.trackBar_0.Maximum = BuD;
				}));
			}
			else
			{
				BuC.trackBar_0.Minimum = Buc;
				BuC.trackBar_0.Maximum = BuD;
			}
			int num2 = BuD - Buc;
			int num3 = ((num2 < 40 && num == 0) ? 1 : (num2 / 40));
			int num4 = Buc;
			int num5 = BuD;
			while (BiB != Enum26.BIX)
			{
				for (int num6 = num4; (num3 <= 0) ? (num6 >= num5) : (num6 <= num5); num6 += num3)
				{
					if (BiB == Enum26.BIX)
					{
						break;
					}
					BiC = num6;
					Class329.smethod_6(bool_0: true);
					Thread.Sleep(200);
					smethod_0(Bia, Bic, out var setting_4, out var setting_5, out var setting_6);
					if (setting_4.method_256() == Buc && setting_5.method_256() == BuD)
					{
						continue;
					}
					Buc = setting_4.method_256();
					BuD = setting_5.method_256();
					num4 = Buc;
					num5 = BuD;
					num = setting_6.method_256();
					if (BuC.InvokeRequired)
					{
						BuC.Invoke((MethodInvoker)(() =>
						{
							BuC.trackBar_0.Minimum = Buc;
							BuC.trackBar_0.Maximum = BuD;
						}));
					}
					else
					{
						BuC.trackBar_0.Minimum = Buc;
						BuC.trackBar_0.Maximum = BuD;
					}
					num2 = BuD - Buc;
					if (num3 <= 0)
					{
						num3 = ((num2 >= 40 || num != 0) ? (-num2 / 40) : (-1));
					}
					else
					{
						num3 = ((num2 < 40 && num == 0) ? 1 : (num2 / 40));
					}
					break;
				}
				if (num3 > 0)
				{
					num3 = -num3;
					int num7 = num4;
					num4 = num5;
					num5 = num7;
				}
				else
				{
					num3 = -num3;
				}
			}
		}

		internal void method_1()
		{
			if (BiD == null)
			{
				BiD = new Thread(method_0);
				BiB = Enum26.BIx;
				BiD.Start(Bid);
			}
		}

		internal void method_2()
		{
			try
			{
				if (BiD != null)
				{
					BiB = Enum26.BIX;
				}
			}
			catch
			{
			}
			BiD = null;
		}
	}

	internal class Class55
	{
		public bool BiE;

		public Enum27 Bie = Enum27.BIZ;

		public List<Class53> BiF = new List<Class53>();
	}

	private delegate bool Delegate13(ref byte[] byte_0);

	internal const int int_0 = 26;

	internal const int int_1 = 470;

	private Class148 class148_0;

	private Label label_0;

	private Label label_1;

	private TrackBar trackBar_0;

	private Class148 class148_1;

	private ThemedButton themedButton_0;

	private RadioButton radioButton_0;

	private RadioButton radioButton_1;

	private Class108 class108_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Framework framework_0;

	private Setting setting_0;

	internal Class55 class55_0 = new Class55();

	private int int_2 = 100;

	private List<Class52> list_0 = new List<Class52>();

	private int int_3;

	private Class243 class243_0;

	private const int int_4 = 30;

	private Enum25 enum25_0;

	internal void method_0(int int_5)
	{
		int_2 = int_5;
	}

	private void method_1()
	{
		radioButton_0 = new RadioButton();
		radioButton_1 = new RadioButton();
		label_0 = new Label();
		label_1 = new Label();
		trackBar_0 = new TrackBar();
		class148_1 = new Class148();
		themedButton_0 = new ThemedButton();
		class148_0 = new Class148();
		((ISupportInitialize)trackBar_0).BeginInit();
		SuspendLayout();
		class148_0.AutoSize = true;
		class148_0.Font = new Font(class148_0.Font.FontFamily, 9f);
		class148_0.Location = new Point(1, 4);
		class148_0.Name = Class333.smethod_364();
		class148_0.TabIndex = 0;
		class148_0.Text = Class333.smethod_365();
		class148_0.UseVisualStyleBackColor = true;
		label_0.AutoSize = true;
		label_0.Font = new Font(label_0.Font.FontFamily, 9f);
		label_0.Location = new Point(90, 5);
		label_0.Name = Class333.smethod_366();
		label_0.Text = Class333.smethod_367();
		label_1.AutoSize = true;
		label_1.Font = new Font(label_1.Font.FontFamily, 9f);
		label_1.Location = new Point(130, 5);
		label_1.Name = Class333.smethod_368();
		label_1.Text = Class333.smethod_325();
		trackBar_0.AutoSize = false;
		trackBar_0.TickStyle = TickStyle.None;
		trackBar_0.SmallChange = 1;
		trackBar_0.LargeChange = 10;
		trackBar_0.Location = new Point(170, 2);
		trackBar_0.Margin = new Padding(0);
		trackBar_0.Maximum = 100;
		trackBar_0.Name = Class333.smethod_369();
		trackBar_0.Size = new Size(440, 30);
		trackBar_0.TabIndex = 1;
		class148_1.AutoSize = true;
		class148_1.Font = new Font(class148_1.Font.FontFamily, 9f);
		class148_1.Location = new Point(580, 4);
		class148_1.Name = Class333.smethod_370();
		class148_1.TabIndex = 2;
		class148_1.Text = Class333.smethod_371();
		class148_1.UseVisualStyleBackColor = true;
		radioButton_0.AutoSize = true;
		radioButton_0.Font = new Font(radioButton_0.Font.FontFamily, 9f);
		radioButton_0.Location = new Point(640, 3);
		radioButton_0.Name = Class333.smethod_372();
		radioButton_0.TabIndex = 3;
		radioButton_0.TabStop = true;
		radioButton_0.Text = Class333.smethod_373();
		radioButton_0.UseVisualStyleBackColor = true;
		radioButton_1.AutoSize = true;
		radioButton_1.Font = new Font(radioButton_1.Font.FontFamily, 9f);
		radioButton_1.Location = new Point(680, 3);
		radioButton_1.Name = Class333.smethod_374();
		radioButton_1.TabIndex = 4;
		radioButton_1.TabStop = true;
		radioButton_1.Text = Class333.smethod_375();
		radioButton_1.UseVisualStyleBackColor = true;
		themedButton_0.AutoSize = false;
		themedButton_0.Width = 40;
		themedButton_0.Font = new Font(class148_1.Font.FontFamily, 9f);
		themedButton_0.Location = new Point(720, 2);
		themedButton_0.Name = Class333.smethod_376();
		themedButton_0.TabIndex = 2;
		themedButton_0.Text = Class333.smethod_377();
		themedButton_0.UseVisualStyleBackColor = true;
		Controls.Add(class148_0);
		Controls.Add(label_0);
		Controls.Add(label_1);
		Controls.Add(trackBar_0);
		Controls.Add(class148_1);
		Controls.Add(radioButton_0);
		Controls.Add(radioButton_1);
		Controls.Add(themedButton_0);
		((ISupportInitialize)trackBar_0).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void method_2()
	{
		class148_0.ForeColor = Form23.color_12;
		label_0.ForeColor = Form23.color_12;
		label_1.ForeColor = Form23.color_12;
		class148_1.ForeColor = Form23.color_12;
		radioButton_0.ForeColor = Form23.color_12;
		radioButton_1.ForeColor = Form23.color_12;
		themedButton_0.ForeColor = Form23.color_12;
	}

	private void method_3()
	{
		Resize += Class51_Resize;
		radioButton_0.Click += trackBar_0_ValueChanged;
		radioButton_1.Click += trackBar_0_ValueChanged;
		trackBar_0.ValueChanged += trackBar_0_ValueChanged;
		class148_1.Click += trackBar_0_ValueChanged;
		class148_0.Click += trackBar_0_ValueChanged;
		themedButton_0.Click += trackBar_0_ValueChanged;
	}

	private void method_4()
	{
		Resize -= Class51_Resize;
		radioButton_0.Click -= trackBar_0_ValueChanged;
		radioButton_1.Click -= trackBar_0_ValueChanged;
		trackBar_0.ValueChanged -= trackBar_0_ValueChanged;
		class148_1.Click -= trackBar_0_ValueChanged;
		class148_0.Click -= trackBar_0_ValueChanged;
		themedButton_0.Click -= trackBar_0_ValueChanged;
	}

	private void Class51_Resize(object sender, EventArgs e)
	{
		trackBar_0.Width = Width - 400;
		class148_1.Left = Width - 230;
		radioButton_0.Left = Width - 170;
		radioButton_1.Left = Width - 120;
		themedButton_0.Left = Width - 50;
	}

	private void trackBar_0_ValueChanged(object sender, EventArgs e)
	{
		Control control = (Control)sender;
		enum25_0 = Enum25.BIv;
		string name = control.Name;
		if (!(name == Class333.smethod_364()))
		{
			if (!(name == Class333.smethod_372()))
			{
				if (!(name == Class333.smethod_374()))
				{
					if (!(name == Class333.smethod_369()))
					{
						if (!(name == Class333.smethod_370()))
						{
							if (name == Class333.smethod_376())
							{
								if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
								{
									enum25_0 = Enum25.BIw;
								}
								else
								{
									enum25_0 = Enum25.BIW;
								}
								Class329.smethod_6(bool_0: true);
								Thread.Sleep(30);
							}
						}
						else if (int_3 > 0)
						{
							foreach (Class53 item in class55_0.BiF)
							{
								if (item.Bib == int_3)
								{
									if (((Class148)control).CheckState == CheckState.Checked)
									{
										item.BiB = Enum26.BIx;
										item.method_1();
									}
									else
									{
										item.BiB = Enum26.BIX;
										item.method_2();
									}
									break;
								}
							}
						}
					}
					else if (int_3 > 0 && class243_0 != null)
					{
						foreach (Class53 item2 in class55_0.BiF)
						{
							if (item2.Bib == int_3)
							{
								item2.BiC = ((TrackBar)control).Value;
								Setting setting = framework_0.method_31(int_3);
								smethod_0(framework_0, class243_0, out var setting_, out var setting_2, out var _);
								int num = setting_.method_256();
								int num2 = setting_2.method_256();
								if (trackBar_0.Minimum != num || trackBar_0.Maximum != num2)
								{
									trackBar_0.Minimum = num;
									trackBar_0.Maximum = num2;
								}
								int num3 = setting_2.method_100();
								if (setting != null)
								{
									label_1.Text = Class233.smethod_29(((TrackBar)control).Value, setting.method_231(), num3);
								}
								else
								{
									label_1.Text = Class333.smethod_186();
								}
								break;
							}
						}
					}
				}
				else
				{
					class55_0.Bie = Enum27.BIy;
					radioButton_0.Checked = false;
				}
			}
			else
			{
				class55_0.Bie = Enum27.BIY;
				radioButton_1.Checked = false;
			}
		}
		else if (((Class148)control).CheckState == CheckState.Checked)
		{
			class55_0.BiE = true;
			if (framework_0.awP != null && framework_0.awP.method_77() != null)
			{
				framework_0.awP.method_77().method_272(1, bool_0: true);
			}
			if (framework_0.awp != null)
			{
				framework_0.awp.method_77(1);
			}
			if (int_3 > 0)
			{
				foreach (Class53 item3 in class55_0.BiF)
				{
					if (item3.Bib == int_3 && item3.Bic != null)
					{
						method_6(item3.Bic, item3);
						method_5(item3.Bic);
						break;
					}
				}
			}
			else
			{
				framework_0.awP.method_75().method_272(0, bool_0: true);
			}
			label_0.Enabled = int_3 > 0 && class243_0 != null;
			label_1.Enabled = int_3 > 0 && class243_0 != null;
			class148_1.Enabled = int_3 > 0 && class243_0 != null;
			trackBar_0.Enabled = int_3 > 0 && class243_0 != null;
			radioButton_0.Enabled = true;
			radioButton_1.Enabled = true;
			themedButton_0.Enabled = setting_0 != null;
		}
		else
		{
			class55_0.BiE = false;
			if (framework_0.awP != null && framework_0.awP.method_77() != null)
			{
				framework_0.awP.method_77().method_272(0, bool_0: true);
			}
			if (framework_0.awp != null)
			{
				framework_0.awp.method_77(0);
			}
			if (class108_0 != null)
			{
				class108_0.method_19();
			}
			foreach (Class53 item4 in class55_0.BiF)
			{
				if (item4.Bic != null)
				{
					trackBar_0.Enabled = false;
					smethod_0(framework_0, item4.Bic, out var setting_4, out var setting_5, out var _);
					trackBar_0.Minimum = setting_4.method_256();
					trackBar_0.Maximum = setting_5.method_256();
					int biC = (trackBar_0.Value = trackBar_0.Minimum);
					item4.BiC = biC;
				}
			}
			label_0.Enabled = false;
			label_1.Enabled = false;
			class148_1.Enabled = false;
			radioButton_0.Enabled = false;
			radioButton_1.Enabled = false;
			themedButton_0.Enabled = false;
		}
		Class329.smethod_6(bool_0: true);
	}

	internal void method_5(Class243 class243_1)
	{
		if (class243_1 != null)
		{
			class243_0 = class243_1;
			int_3 = class243_1.method_305().method_256();
			bool flag = int_3 > 0 && class243_0 != null && class148_0.Checked;
			class148_1.Enabled = flag;
			trackBar_0.Enabled = flag;
			label_0.Enabled = flag;
			label_1.Enabled = flag;
			themedButton_0.Enabled = flag && setting_0 != null;
			bool flag2 = false;
			Class53 class53_ = null;
			foreach (Class53 item in class55_0.BiF)
			{
				if (item.Bib == int_3)
				{
					flag2 = true;
					class53_ = item;
					break;
				}
			}
			if (!flag2)
			{
				Class53 @class = new Class53(framework_0, class243_1, this);
				class55_0.BiF.Add(@class);
				class53_ = @class;
			}
			if (class243_1 != null && class148_0.Checked)
			{
				method_6(class243_1, class53_);
			}
		}
		else
		{
			framework_0.awP.method_75().method_272(0, bool_0: true);
		}
	}

	internal void method_6(Class243 class243_1, Class53 class53_0)
	{
		Setting setting = framework_0.method_31(int_3);
		if (setting != null && class243_0 != null)
		{
			trackBar_0.Enabled = true;
			smethod_0(framework_0, class243_1, out var setting_, out var setting_2, out var _);
			trackBar_0.Minimum = setting_.method_256();
			trackBar_0.Maximum = setting_2.method_256();
			if (class53_0 != null)
			{
				if (class53_0 != null && class53_0.BiC >= trackBar_0.Minimum && class53_0.BiC <= trackBar_0.Maximum)
				{
					trackBar_0.Value = class53_0.BiC;
				}
				else
				{
					trackBar_0.Value = (class53_0.BiC = trackBar_0.Minimum);
				}
				if (class53_0.BiB == Enum26.BIx)
				{
					class148_1.Checked = true;
				}
				else
				{
					class148_1.Checked = false;
				}
			}
			else
			{
				trackBar_0.Value = trackBar_0.Minimum;
			}
			int num = setting_2.method_100();
			label_1.Text = Class233.smethod_29(trackBar_0.Value, setting.method_231(), num);
		}
		else
		{
			label_1.Text = Class333.smethod_186();
		}
	}

	internal Class51(Framework framework_1, Class108 class108_1)
	{
		method_1();
		framework_0 = framework_1;
		class108_0 = class108_1;
		method_2();
		class148_0.Checked = false;
		class55_0.BiE = false;
		if (framework_0.awp != null)
		{
			framework_0.awp.method_77(0);
		}
		label_0.Enabled = false;
		label_1.Enabled = false;
		trackBar_0.Enabled = false;
		class148_1.Enabled = false;
		radioButton_0.Enabled = false;
		radioButton_1.Enabled = false;
		themedButton_0.Enabled = false;
		method_3();
		list_0.Clear();
		setting_0 = framework_0.method_31(60045);
	}

	protected override void Dispose(bool disposing)
	{
		method_4();
		foreach (Class53 item in class55_0.BiF)
		{
			if (item.BiD != null)
			{
				item.BiB = Enum26.BIX;
				item.BiD = null;
			}
		}
		base.Dispose(disposing);
	}

	internal bool method_7(ref byte[] byte_0)
	{
		if (InvokeRequired)
		{
			Delegate13 method = method_8;
			return (bool)Invoke(method, byte_0);
		}
		return method_8(ref byte_0);
	}

	private bool method_8(ref byte[] byte_0)
	{
		bool result = false;
		if (class55_0.BiE)
		{
			if (class243_0 != null)
			{
				smethod_0(framework_0, class243_0, out var setting_, out var setting_2, out var _);
				if (trackBar_0.Minimum != setting_.method_256())
				{
					trackBar_0.Minimum = setting_.method_256();
				}
				if (trackBar_0.Maximum != setting_2.method_256())
				{
					trackBar_0.Maximum = setting_2.method_256();
				}
			}
			using Mutex mutex = new Mutex(initiallyOwned: false, Class333.smethod_378());
			if (mutex.WaitOne(100))
			{
				if (framework_0.awp != null && framework_0.awp.method_72() != null)
				{
					Setting setting = framework_0.awp.method_72();
					setting.method_272(1, bool_0: true);
					Class23.smethod_6(setting.method_256(), byte_0, setting.method_65(), setting.method_199(), framework_0.aWR);
					Setting setting2 = framework_0.awP.method_77();
					if (setting2 != null)
					{
						Class23.smethod_6(1, byte_0, setting2.method_65(), 4, framework_0.aWR);
					}
				}
				Class23.smethod_6(int_2, byte_0, framework_0.awP.method_78().method_65(), framework_0.awP.method_78().method_199(), framework_0.aWR);
				if (class55_0.Bie != Enum27.BIZ)
				{
					Setting setting3 = framework_0.method_31(60002);
					int num = setting3.method_256();
					int bie = (int)class55_0.Bie;
					if (num != bie)
					{
						Class23.smethod_6(bie, byte_0, setting3.method_65(), 4, framework_0.aWR);
						result = true;
					}
				}
				foreach (Class53 item in class55_0.BiF)
				{
					Setting setting4 = framework_0.method_31(item.Bib);
					int biC = item.BiC;
					Class23.smethod_6(biC, byte_0, setting4.method_65(), 4, framework_0.aWR);
					result = true;
					if (class243_0 != null && item.Bib == int_3)
					{
						smethod_0(framework_0, class243_0, out var _, out var setting_5, out var _);
						int num2 = setting_5.method_100();
						string text = Class233.smethod_29(biC, setting4.method_231(), num2);
						if (text != label_1.Text)
						{
							label_1.Text = text;
						}
						trackBar_0.ValueChanged -= trackBar_0_ValueChanged;
						trackBar_0.Value = biC;
						trackBar_0.ValueChanged += trackBar_0_ValueChanged;
					}
				}
				if (setting_0 != null)
				{
					Class23.smethod_6((int)enum25_0, byte_0, setting_0.method_65(), 4, framework_0.aWR);
					enum25_0 = Enum25.BIv;
				}
				Setting setting5 = framework_0.awP.method_75();
				Class23.smethod_6(setting5.method_256(), byte_0, setting5.method_65(), 4, framework_0.aWR);
				Setting setting6 = framework_0.awP.method_76();
				if (setting6 != null)
				{
					Class23.smethod_6(setting6.method_256(), byte_0, setting6.method_65(), 4, framework_0.aWR);
				}
				setting5 = framework_0.awP.method_74();
				Class23.smethod_6(setting5.method_256(), byte_0, setting5.method_65(), 4, framework_0.aWR);
			}
		}
		return result;
	}

	private static void smethod_0(Framework framework_1, Class243 class243_1, out Setting setting_1, out Setting setting_2, out Setting setting_3)
	{
		setting_1 = class243_1.method_309();
		setting_2 = class243_1.method_310();
		setting_3 = class243_1.method_311();
		if (setting_1.method_187() == 0 || setting_1.method_189() == 0)
		{
			return;
		}
		Setting setting = framework_1.method_31(setting_1.method_189());
		if (setting == null)
		{
			return;
		}
		Setting setting2 = null;
		if (setting.method_191() != 0)
		{
			Setting setting3 = framework_1.method_31(setting.method_191());
			if (setting3 != null)
			{
				setting2 = framework_1.method_31(setting3.method_256());
			}
		}
		else if (setting.method_193() != 0)
		{
			setting2 = framework_1.method_31(setting.method_193());
		}
		if (setting2 == null)
		{
			return;
		}
		Setting setting4 = framework_1.method_32(new DataIdAndAttrId(setting2.method_64(), setting_1.method_187()));
		Setting setting5 = framework_1.method_32(new DataIdAndAttrId(setting2.method_64(), setting_2.method_187()));
		Setting setting6 = framework_1.method_32(new DataIdAndAttrId(setting2.method_64(), setting_3.method_187()));
		if (setting.method_256() == 0)
		{
			if (setting4 != null)
			{
				setting_1 = setting4;
			}
			if (setting5 != null)
			{
				setting_2 = setting5;
			}
			if (setting6 != null)
			{
				setting_3 = setting6;
			}
		}
	}
}
