using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using NSP.UnitConversion;
using ns0;
using ns4;
using ns7;

namespace ns5;

internal class Class233
{
	private static Dictionary<int, int> aCv = new Dictionary<int, int>();

	[CompilerGenerated]
	private static EventHandler aCW;

	internal static string[] aCw = new string[14]
	{
		Class333.aGL(),
		Class333.aGl(),
		Class333.aGM(),
		Class333.adk(),
		Class333.aGm(),
		Class333.aGN(),
		Class333.aGn(),
		Class333.aGO(),
		Class333.aGo(),
		Class333.aGP(),
		Class333.aGp(),
		Class333.aGQ(),
		Class333.aGq(),
		Class333.smethod_939()
	};

	internal static string[][] aCX = new string[14][]
	{
		new string[6]
		{
			Class333.aGR(),
			Class333.aGr(),
			Class333.aGS(),
			Class333.aGs(),
			Class333.aGT(),
			Class333.aGt()
		},
		new string[8]
		{
			Class333.aEw(),
			Class333.aEX(),
			Class333.aea(),
			Class333.aeT(),
			Class333.aeh(),
			Class333.aeI(),
			Class333.aej(),
			Class333.aei()
		},
		new string[2]
		{
			Class333.aFs(),
			Class333.aFT()
		},
		new string[4]
		{
			Class333.aFx(),
			Class333.aGU(),
			Class333.aGu(),
			Class333.aGV()
		},
		new string[2]
		{
			Class333.afF(),
			Class333.aff()
		},
		new string[3]
		{
			Class333.afK(),
			Class333.afL(),
			Class333.afl()
		},
		new string[2]
		{
			Class333.afm(),
			Class333.afN()
		},
		new string[3]
		{
			Class333.afP(),
			Class333.afq(),
			Class333.afT()
		},
		new string[3]
		{
			Class333.afW(),
			Class333.afw(),
			Class333.afX()
		},
		new string[2]
		{
			Class333.afx(),
			Class333.afY()
		},
		new string[2]
		{
			Class333.aGa(),
			Class333.aGv()
		},
		new string[3]
		{
			Class333.aGC(),
			Class333.aGD(),
			Class333.aGd()
		},
		new string[2]
		{
			Class333.aGE(),
			Class333.aGF()
		},
		new string[2]
		{
			Class333.smethod_960(),
			Class333.aDx()
		}
	};

	internal static int[] aCx = new int[1 + aCw.Length];

	internal static List<Class231> aCY;

	private static void smethod_0()
	{
		try
		{
			if (!File.Exists(Form23.string_9))
			{
				return;
			}
			using StreamReader streamReader = File.OpenText(Form23.string_9);
			int num = -1;
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.acY()))
				{
					num = int.Parse(text.Substring(Class333.acY().Length));
					if (!aCv.ContainsKey(num))
					{
						aCv.Add(num, -1);
					}
				}
				else if (num != -1 && aCv.ContainsKey(num) && text.StartsWith(Class333.acy()))
				{
					int value = int.Parse(text.Substring(Class333.acy().Length));
					aCv[num] = value;
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.acZ() + ex.Message);
		}
	}

	internal static int smethod_1(int int_0)
	{
		if (aCv.ContainsKey(int_0))
		{
			return aCv[int_0];
		}
		return -1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_2(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = aCW;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref aCW, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_3(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = aCW;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref aCW, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal static void smethod_4(int int_0, int int_1)
	{
		if (aCv.ContainsKey(int_0))
		{
			aCv[int_0] = int_1;
		}
		else
		{
			aCv.Add(int_0, int_1);
		}
		if (aCW != null)
		{
			aCW(null, null);
		}
		try
		{
			if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
			{
				Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
			}
			File.Create(Form23.string_9).Close();
			List<string> list = new List<string>();
			foreach (int key in aCv.Keys)
			{
				if (aCv[key] != -1)
				{
					list.Add(Class333.acY() + key);
					list.Add(Class333.acy() + aCv[key]);
					list.Add(Class333.smethod_102());
				}
			}
			File.AppendAllLines(Form23.string_9, list);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.acz() + ex.Message);
		}
	}

	private static void smethod_5()
	{
		if (Class36.enum20_0 == Class36.Enum20.BHd)
		{
			aCx[0] = 0;
			aCx[1] = 0;
			aCx[2] = 0;
			aCx[3] = 0;
			aCx[4] = 0;
			aCx[5] = 0;
			aCx[6] = 0;
			aCx[7] = 0;
			aCx[8] = 0;
			aCx[9] = 0;
			aCx[10] = 0;
			aCx[11] = 0;
			aCx[12] = 0;
			aCx[13] = 0;
			aCx[14] = 1;
		}
		else
		{
			aCx[0] = 0;
			aCx[1] = 2;
			aCx[2] = 6;
			aCx[3] = 1;
			aCx[4] = 1;
			aCx[5] = 1;
			aCx[6] = 1;
			aCx[7] = 1;
			aCx[8] = 2;
			aCx[9] = 2;
			aCx[10] = 1;
			aCx[11] = 1;
			aCx[12] = 0;
			aCx[13] = 0;
			aCx[14] = 1;
		}
	}

	private static void smethod_6()
	{
		smethod_5();
		if (!File.Exists(Form58.aBJ))
		{
			return;
		}
		using StreamReader streamReader = File.OpenText(Form58.aBJ);
		for (int i = 0; i < aCw.Length; i++)
		{
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.aBi() + i + Class333.smethod_571()))
				{
					aCx[i + 1] = int.Parse(text.Substring((Class333.aBi() + i + Class333.smethod_571()).Length));
					break;
				}
			}
		}
	}

	internal static void smethod_7()
	{
		if (aCY == null)
		{
			smethod_0();
			smethod_6();
			aCY = new List<Class231>();
			smethod_8();
			smethod_9();
			smethod_10();
			smethod_11();
			smethod_12();
			smethod_13();
			smethod_14();
			smethod_15();
			smethod_16();
			smethod_17();
			smethod_18();
			smethod_19();
			smethod_20();
			smethod_21();
			smethod_22();
		}
	}

	private static void smethod_8()
	{
		Class231 @class = new Class231(UnitType.Raw, UnitsGroup.NoGroup, 0, Class333.aDA(), Class333.smethod_325());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_325()));
		@class.abw.Add(new Class231.Class232(1000, 1000.0, Class333.smethod_325()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Position, UnitsGroup.NoGroup, 0, Class333.aDa(), Class333.aDa());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDa()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aDa()));
		aCY.Add(@class);
		@class = new Class231(UnitType.EngineSpeed, UnitsGroup.NoGroup, 0, Class333.aDB(), Class333.aDB());
		@class.abu = 50;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDB()));
		@class.abw.Add(new Class231.Class232(100, 100.0, Class333.aDB()));
		aCY.Add(@class);
		@class = new Class231(UnitType.EngineAcceleration, UnitsGroup.NoGroup, 0, Class333.aDb(), Class333.aDC());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDC()));
		@class.abw.Add(new Class231.Class232(100, 100.0, Class333.aDC()));
		aCY.Add(@class);
		@class = new Class231(UnitType.RPMx1000, UnitsGroup.NoGroup, 0, Class333.aDc(), Class333.aDB());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDB()));
		@class.abw.Add(new Class231.Class232(1000, 100000.0, Class333.aDB()));
		aCY.Add(@class);
		@class = new Class231(UnitType.CompRatio, UnitsGroup.NoGroup, 0, Class333.aDD(), Class333.aDD());
		@class.abu = 1000;
		@class.abV = 500;
		@class.abv = 100;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aDD()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDD()));
		aCY.Add(@class);
		@class = new Class231(UnitType.BoostToFuelFlowRate, UnitsGroup.NoGroup, 0, Class333.aDd(), Class333.aDd());
		@class.abu = 1000;
		@class.abV = 500;
		@class.abv = 100;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDd()));
		@class.abw.Add(new Class231.Class232(1000, 55.769, Class333.aDd()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Voltage, UnitsGroup.NoGroup, 0, Class333.smethod_879(), Class333.smethod_879());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_879()));
		@class.abw.Add(new Class231.Class232(1023, 5.0, Class333.smethod_879()));
		aCY.Add(@class);
		@class = new Class231(UnitType.BatteryVoltage, UnitsGroup.NoGroup, 0, Class333.aDE(), Class333.smethod_879());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_879()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.smethod_879()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerVolt, UnitsGroup.NoGroup, 0, Class333.aDe(), Class333.aDF(), Class333.aDf(), Class333.aDG(), Class333.aDg());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDF(), Class333.aDf(), Class333.aDG(), Class333.aDg()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aDF(), Class333.aDf(), Class333.aDG(), Class333.aDg()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Current, UnitsGroup.NoGroup, 0, Class333.smethod_685(), Class333.aDH());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDH()));
		@class.abw.Add(new Class231.Class232(100, 100.0, Class333.aDH()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Current_uA_as_mA, UnitsGroup.NoGroup, 0, Class333.aDh(), Class333.aDH());
		@class.abW = 3;
		@class.abu = 30;
		@class.abV = 5;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDH()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aDH()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Current_mA_as_A, UnitsGroup.NoGroup, 0, Class333.aDI(), Class333.smethod_1331());
		@class.abW = 1;
		@class.abu = 5000;
		@class.abV = 1000;
		@class.abv = 500;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_1331()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.smethod_1331()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Resistance, UnitsGroup.NoGroup, 0, Class333.aDi(), Class333.aDJ());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDJ()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aDJ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Decibel, UnitsGroup.NoGroup, 0, Class333.aDj(), Class333.aDj());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDj()));
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.aDj()));
		aCY.Add(@class);
		@class = new Class231(UnitType.FuelEcomony, UnitsGroup.NoGroup, 0, Class333.aDK(), Class333.aDk());
		@class.abu = 30;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDk()));
		@class.abw.Add(new Class231.Class232(100, 10.0, Class333.aDk()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Percentage, UnitsGroup.NoGroup, 0, Class333.aDL(), Class333.smethod_681());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_681()));
		@class.abw.Add(new Class231.Class232(1000, 100.0, Class333.smethod_681()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerRpm, UnitsGroup.NoGroup, 0, Class333.aDl(), Class333.aDM(), Class333.aDm(), Class333.aDN(), Class333.aDn());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDM(), Class333.aDm(), Class333.aDN(), Class333.aDn()));
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.aDM(), Class333.aDm(), Class333.aDN(), Class333.aDn()));
		aCY.Add(@class);
		@class = new Class231(UnitType.DegreesPerRpm, UnitsGroup.NoGroup, 0, Class333.aDO(), Class333.aDo(), Class333.aDP(), Class333.aDp(), Class333.aDQ());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDo(), Class333.aDP(), Class333.aDp(), Class333.aDQ()));
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.aDo(), Class333.aDP(), Class333.aDp(), Class333.aDQ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerDegree, UnitsGroup.NoGroup, 0, Class333.aDq(), Class333.aDR(), Class333.aDr(), Class333.aDS(), Class333.aDs());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDR(), Class333.aDr(), Class333.aDS(), Class333.aDs()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aDR(), Class333.aDr(), Class333.aDS(), Class333.aDs()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerPercent, UnitsGroup.NoGroup, 0, Class333.aDT(), Class333.aDt(), Class333.aDU(), Class333.aDu(), Class333.aDV());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDt(), Class333.aDU(), Class333.aDu(), Class333.aDV()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aDt(), Class333.aDU(), Class333.aDu(), Class333.aDV()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_h, UnitsGroup.NoGroup, 0, Class333.aDv(), Class333.smethod_400());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_400()));
		@class.abw.Add(new Class231.Class232(3600, 1.0, Class333.smethod_400()));
		@class.abW = 2;
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_h_m_formatted, UnitsGroup.NoGroup, 0, Class333.aDW(), Class333.aDw());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDw()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aDw()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_s, UnitsGroup.NoGroup, 0, Class333.smethod_2059(), Class333.smethod_960());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_960()));
		@class.abw.Add(new Class231.Class232(1000, 1000.0, Class333.smethod_960()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_ms, UnitsGroup.NoGroup, 0, Class333.aDX(), Class333.aDx());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDx()));
		@class.abw.Add(new Class231.Class232(1000, 1000.0, Class333.aDx()));
		aCY.Add(@class);
		@class = new Class231(UnitType.TimeUsAsUs, UnitsGroup.NoGroup, 0, Class333.aDY(), Class333.aDy());
		@class.abu = 50;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 0;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDy()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aDy()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Ratio, UnitsGroup.NoGroup, 0, Class333.aDZ(), Class333.aDD());
		@class.abW = 3;
		@class.abv = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDD()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aDD()));
		aCY.Add(@class);
		@class = new Class231(UnitType.RelativeLoad, UnitsGroup.NoGroup, 0, Class333.aDz(), Class333.adA());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adA()));
		@class.abw.Add(new Class231.Class232(1000, 100.0, Class333.adA()));
		aCY.Add(@class);
		@class = new Class231(UnitType.SM_Steps, UnitsGroup.NoGroup, 0, Class333.ada(), Class333.ada());
		@class.abu = 20;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.ada()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.ada()));
		aCY.Add(@class);
		@class = new Class231(UnitType.StepRate, UnitsGroup.NoGroup, 0, Class333.adB(), Class333.adb());
		@class.abu = 20;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adb()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.adb()));
		aCY.Add(@class);
		@class = new Class231(UnitType.msPerEngCyl, UnitsGroup.NoGroup, 0, Class333.adC(), Class333.adc());
		@class.abu = 100;
		@class.abV = 50;
		@class.abv = 10;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adc()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.adc()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Frequency, UnitsGroup.NoGroup, 0, Class333.adD(), Class333.add());
		@class.abu = 100;
		@class.abV = 50;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.add()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.add()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Percentage1For1, UnitsGroup.NoGroup, 0, Class333.adE(), Class333.smethod_681());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_681()));
		@class.abw.Add(new Class231.Class232(100, 100.0, Class333.smethod_681()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentageInjAirTempCorr, UnitsGroup.NoGroup, 0, Class333.ade(), Class333.smethod_681());
		@class.abu = 10;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(125, 0.0, Class333.smethod_681()));
		@class.abw.Add(new Class231.Class232(0, -12.5, Class333.smethod_681()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentageInjBaroCorr, UnitsGroup.NoGroup, 0, Class333.adF(), Class333.smethod_681());
		@class.abu = 10;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(100, 0.0, Class333.smethod_681()));
		@class.abw.Add(new Class231.Class232(0, -50.0, Class333.smethod_681()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_us4For1, UnitsGroup.NoGroup, 0, Class333.adf(), Class333.aDx());
		@class.abu = 1000;
		@class.abV = 500;
		@class.abv = 250;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(1000, 4.0, Class333.aDx()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDx()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Percentage4For1, UnitsGroup.NoGroup, 0, Class333.adG(), Class333.smethod_681());
		@class.abu = 20;
		@class.abV = 4;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(1, 0.25, Class333.smethod_681()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_681()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AngleIgnSprt2K, UnitsGroup.NoGroup, 0, Class333.adg(), Class333.adH());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, -20.0, Class333.adH()));
		@class.abw.Add(new Class231.Class232(200, 0.0, Class333.adH()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AngleOffset10deg, UnitsGroup.NoGroup, 0, Class333.adh(), Class333.adH());
		@class.abu = 20;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, -10.0, Class333.adH()));
		@class.abw.Add(new Class231.Class232(100, 0.0, Class333.adH()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_s20For1, UnitsGroup.NoGroup, 0, Class333.adI(), Class333.smethod_960());
		@class.abu = 20;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_960()));
		@class.abw.Add(new Class231.Class232(1, 0.05000000074505806, Class333.smethod_960()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_s10For1, UnitsGroup.NoGroup, 0, Class333.adi(), Class333.smethod_960());
		@class.abu = 20;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_960()));
		@class.abw.Add(new Class231.Class232(1, 0.10000000149011612, Class333.smethod_960()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_s200For1, UnitsGroup.NoGroup, 0, Class333.adJ(), Class333.smethod_960());
		@class.abu = 20;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_960()));
		@class.abw.Add(new Class231.Class232(1, 0.004999999888241291, Class333.smethod_960()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Percentage2For1, UnitsGroup.NoGroup, 0, Class333.adj(), Class333.smethod_681());
		@class.abu = 25;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(1, 0.5, Class333.smethod_681()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_681()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Stoichiometry, UnitsGroup.NoGroup, 0, Class333.adK(), Class333.adk());
		@class.abu = 2000;
		@class.abV = 1000;
		@class.abv = 100;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.adk()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adk()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentageMapCorr, UnitsGroup.NoGroup, 0, Class333.adL(), Class333.smethod_681());
		@class.abu = 10;
		@class.abV = 2;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(200, 0.0, Class333.smethod_681()));
		@class.abw.Add(new Class231.Class232(0, -100.0, Class333.smethod_681()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentageEGTCorr, UnitsGroup.NoGroup, 0, Class333.adl(), Class333.smethod_681());
		@class.abu = 10;
		@class.abV = 2;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(100, 0.0, Class333.smethod_681()));
		@class.abw.Add(new Class231.Class232(0, -100.0, Class333.smethod_681()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_s100For1, UnitsGroup.NoGroup, 0, Class333.adM(), Class333.smethod_960());
		@class.abu = 10;
		@class.abV = 2;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.smethod_960()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_960()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_ms1For10, UnitsGroup.NoGroup, 0, Class333.adm(), Class333.smethod_960());
		@class.abu = 500;
		@class.abV = 100;
		@class.abv = 50;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_960()));
		@class.abw.Add(new Class231.Class232(1, 0.009999999776482582, Class333.smethod_960()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_ms1For5, UnitsGroup.NoGroup, 0, Class333.adN(), Class333.aDx());
		@class.abu = 250;
		@class.abV = 50;
		@class.abv = 25;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDx()));
		@class.abw.Add(new Class231.Class232(1, 5.0, Class333.aDx()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_ms200For1, UnitsGroup.NoGroup, 0, Class333.adn(), Class333.aDx());
		@class.abu = 20;
		@class.abV = 10;
		@class.abv = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDx()));
		@class.abw.Add(new Class231.Class232(1, 5.0, Class333.aDx()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Gear, UnitsGroup.NoGroup, 0, Class333.adO(), Class333.ado());
		@class.abu = 2;
		@class.abV = 1;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.ado()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.ado()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_ms_as_s, UnitsGroup.NoGroup, 0, Class333.adP(), Class333.smethod_960());
		@class.abu = 1000;
		@class.abV = 500;
		@class.abv = 100;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_960()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.smethod_960()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID500, UnitsGroup.NoGroup, 0, Class333.adp(), Class333.smethod_102());
		@class.abu = 50;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(500, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID1000, UnitsGroup.NoGroup, 0, Class333.adQ(), Class333.smethod_102());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(1000, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID2000, UnitsGroup.NoGroup, 0, Class333.adq(), Class333.smethod_102());
		@class.abu = 200;
		@class.abV = 20;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(2000, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID2500, UnitsGroup.NoGroup, 0, Class333.adR(), Class333.smethod_102());
		@class.abu = 250;
		@class.abV = 25;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(2500, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID5000, UnitsGroup.NoGroup, 0, Class333.adr(), Class333.smethod_102());
		@class.abu = 500;
		@class.abV = 50;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(5000, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID50000, UnitsGroup.NoGroup, 0, Class333.adS(), Class333.smethod_102());
		@class.abu = 5000;
		@class.abV = 500;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(50000, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID25000, UnitsGroup.NoGroup, 0, Class333.ads(), Class333.smethod_102());
		@class.abu = 2500;
		@class.abV = 250;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(25000, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID10000, UnitsGroup.NoGroup, 0, Class333.adT(), Class333.smethod_102());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(10000, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID40, UnitsGroup.NoGroup, 0, Class333.adt(), Class333.smethod_102());
		@class.abu = 4;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(40, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID20000, UnitsGroup.NoGroup, 0, Class333.adU(), Class333.smethod_102());
		@class.abu = 2000;
		@class.abV = 200;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(20000, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PID3000, UnitsGroup.NoGroup, 0, Class333.adu(), Class333.smethod_102());
		@class.abu = 300;
		@class.abV = 30;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(3000, 100.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Angle, UnitsGroup.NoGroup, 0, Class333.adV(), Class333.adH());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adH()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.adH()));
		aCY.Add(@class);
		@class = new Class231(UnitType.RetardAngle, UnitsGroup.NoGroup, 0, Class333.adv(), Class333.adH());
		@class.abu = -100;
		@class.abV = -10;
		@class.abv = -2;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adH()));
		@class.abw.Add(new Class231.Class232(10, -1.0, Class333.adH()));
		aCY.Add(@class);
		@class = new Class231(UnitType.RetardAngularVelocity, UnitsGroup.NoGroup, 0, Class333.adW(), Class333.adw());
		@class.abu = -100;
		@class.abV = -10;
		@class.abv = -1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adw()));
		@class.abw.Add(new Class231.Class232(1000, -100.0, Class333.adw()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AngularVelocity, UnitsGroup.NoGroup, 0, Class333.adX(), Class333.adw());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adw()));
		@class.abw.Add(new Class231.Class232(1000, 100.0, Class333.adw()));
		aCY.Add(@class);
		@class = new Class231(UnitType.degPerEngCyl, UnitsGroup.NoGroup, 0, Class333.adx(), Class333.adY());
		@class.abu = 10;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adY()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.adY()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerEngineCycle, UnitsGroup.NoGroup, 0, Class333.ady(), Class333.adZ());
		@class.abu = 10;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.adz()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.adz()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Latitude, UnitsGroup.NoGroup, 0, Class333.adH(), Class333.adH());
		@class.abW = 7;
		@class.abw.Add(new Class231.Class232(-900000000, 90.0, Class333.aEA()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEA()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEa()));
		@class.abw.Add(new Class231.Class232(900000000, 90.0, Class333.aEa()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Longitude, UnitsGroup.NoGroup, 0, Class333.adH(), Class333.adH());
		@class.abW = 7;
		@class.abw.Add(new Class231.Class232(-1800000000, 180.0, Class333.aEB()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEB()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEb()));
		@class.abw.Add(new Class231.Class232(1800000000, 180.0, Class333.aEb()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Raw2DecimalPlace, UnitsGroup.NoGroup, 0, Class333.aEC(), Class333.smethod_325());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_325()));
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.smethod_325()));
		aCY.Add(@class);
		@class = new Class231(UnitType.CubicFeetMin, UnitsGroup.NoGroup, 0, Class333.aEc(), Class333.aED());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aED()));
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.aED()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PulsesPerRevolution, UnitsGroup.NoGroup, 0, Class333.aEd(), Class333.aEE());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEE()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aEE()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Hexadecimal, UnitsGroup.NoGroup, 0, Class333.smethod_736(), Class333.smethod_102());
		@class.abW = 0;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_102()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.smethod_102()));
		aCY.Add(@class);
		@class = new Class231(UnitType.ByteCount, UnitsGroup.NoGroup, 0, Class333.smethod_2052(), Class333.smethod_2052());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_2242()));
		@class.abw.Add(new Class231.Class232(1023, 1023.0, Class333.smethod_2242()));
		@class.abw.Add(new Class231.Class232(1024, 1.0, Class333.aEe()));
		@class.abw.Add(new Class231.Class232(1048575, 1023.9990234375, Class333.aEe()));
		@class.abw.Add(new Class231.Class232(1048576, 1.0, Class333.aEF()));
		@class.abw.Add(new Class231.Class232(1073741823, 1024.0, Class333.aEF()));
		@class.abw.Add(new Class231.Class232(1073741824, 1.0, Class333.aEf()));
		@class.abw.Add(new Class231.Class232(1610612736, 1.5, Class333.aEf()));
		aCY.Add(@class);
		@class = new Class231(UnitType.BarToMinorTick, UnitsGroup.NoGroup, 0, Class333.aEG(), Class333.aEG());
		@class.abu = 10;
		@class.abV = 2;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 1.0, Class333.aEG()));
		@class.abw.Add(new Class231.Class232(100, 101.0, Class333.aEG()));
		aCY.Add(@class);
	}

	private static void smethod_9()
	{
		Class231 @class = new Class231(UnitType.FuelVolume, UnitsGroup.FuelVolumeGroup, 0, Class333.smethod_1310(), Class333.smethod_1310());
		@class.abu = 1000;
		@class.abV = 300;
		@class.abv = 30;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_1310()));
		@class.abw.Add(new Class231.Class232(10000, 100.0, Class333.smethod_1310()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaFuelVolume, UnitsGroup.FuelVolumeGroup, 0, Class333.aEg(), Class333.smethod_1310());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_1310()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.smethod_1310()));
		aCY.Add(@class);
		@class = new Class231(UnitType.InjFuelVolume, UnitsGroup.FuelVolumeGroup, 0, Class333.aEH(), Class333.aEh());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEh()));
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.aEh()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flow, UnitsGroup.FuelVolumeGroup, 0, Class333.aEI(), Class333.aEI());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEI()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aEI()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flowx10, UnitsGroup.FuelVolumeGroup, 0, Class333.aEi(), Class333.aEI());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEI()));
		@class.abw.Add(new Class231.Class232(1, 10.0, Class333.aEI()));
		aCY.Add(@class);
		@class = new Class231(UnitType.FuelVolume, UnitsGroup.FuelVolumeGroup, 1, Class333.aEJ(), Class333.aEJ());
		@class.abu = 1000;
		@class.abV = 300;
		@class.abv = 30;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEJ()));
		@class.abw.Add(new Class231.Class232(10000, 26.420000076293945, Class333.aEJ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.FuelVolume, UnitsGroup.FuelVolumeGroup, 3, Class333.aEJ(), Class333.aEJ());
		@class.abu = 1000;
		@class.abV = 300;
		@class.abv = 30;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEJ()));
		@class.abw.Add(new Class231.Class232(10000, 26.420000076293945, Class333.aEJ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaFuelVolume, UnitsGroup.FuelVolumeGroup, 1, Class333.aEj(), Class333.aEJ());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEJ()));
		@class.abw.Add(new Class231.Class232(10, 0.2641720473766327, Class333.aEJ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaFuelVolume, UnitsGroup.FuelVolumeGroup, 3, Class333.aEj(), Class333.aEJ());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEJ()));
		@class.abw.Add(new Class231.Class232(10, 0.2641720473766327, Class333.aEJ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.InjFuelVolume, UnitsGroup.FuelVolumeGroup, 1, Class333.aEH(), Class333.aEK());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 4;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEK()));
		@class.abw.Add(new Class231.Class232(100, 3.381402348168194E-05, Class333.aEK()));
		aCY.Add(@class);
		@class = new Class231(UnitType.InjFuelVolume, UnitsGroup.FuelVolumeGroup, 3, Class333.aEH(), Class333.aEK());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 4;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEK()));
		@class.abw.Add(new Class231.Class232(100, 3.381402348168194E-05, Class333.aEK()));
		aCY.Add(@class);
		@class = new Class231(UnitType.InjFuelVolume, UnitsGroup.FuelVolumeGroup, 1, Class333.aEk(), Class333.aEL());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 4;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEL()));
		@class.abw.Add(new Class231.Class232(492892, 1.0, Class333.aEL()));
		aCY.Add(@class);
		@class = new Class231(UnitType.InjFuelVolume, UnitsGroup.FuelVolumeGroup, 3, Class333.aEk(), Class333.aEL());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 4;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEL()));
		@class.abw.Add(new Class231.Class232(492892, 1.0, Class333.aEL()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flow, UnitsGroup.FuelVolumeGroup, 1, Class333.aEl(), Class333.aEl());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEl()));
		@class.abw.Add(new Class231.Class232(1000, 15.850322723388672, Class333.aEl()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flowx10, UnitsGroup.FuelVolumeGroup, 1, Class333.aEM(), Class333.aEl());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEl()));
		@class.abw.Add(new Class231.Class232(1000, 158.50323486328125, Class333.aEl()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flow, UnitsGroup.FuelVolumeGroup, 3, Class333.aEm(), Class333.aEm());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEm()));
		@class.abw.Add(new Class231.Class232(1000, 0.2641719877719879, Class333.aEm()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flowx10, UnitsGroup.FuelVolumeGroup, 3, Class333.aEN(), Class333.aEm());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEm()));
		@class.abw.Add(new Class231.Class232(1000, 2.6417200565338135, Class333.aEm()));
		aCY.Add(@class);
		@class = new Class231(UnitType.FuelRate, UnitsGroup.FuelVolumeGroup, 0, Class333.aEn(), Class333.aEO());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEO()));
		@class.abw.Add(new Class231.Class232(1000, 10.0, Class333.aEO()));
		aCY.Add(@class);
		@class = new Class231(UnitType.FuelRate, UnitsGroup.FuelVolumeGroup, 1, Class333.aEo(), Class333.aEl());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEl()));
		@class.abw.Add(new Class231.Class232(1000, 2.6419999599456787, Class333.aEl()));
		aCY.Add(@class);
		@class = new Class231(UnitType.FuelRate, UnitsGroup.FuelVolumeGroup, 3, Class333.aEP(), Class333.aEm());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 2;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEm()));
		@class.abw.Add(new Class231.Class232(10000, 0.4403333067893982, Class333.aEm()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flow, UnitsGroup.FuelVolumeGroup, 2, Class333.aEp(), Class333.aEp());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEp()));
		@class.abw.Add(new Class231.Class232(1000, 95.23809814453125, Class333.aEp()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flowx10, UnitsGroup.FuelVolumeGroup, 2, Class333.aEQ(), Class333.aEp());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEp()));
		@class.abw.Add(new Class231.Class232(1000, 952.3809814453125, Class333.aEp()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flow, UnitsGroup.FuelVolumeGroup, 4, Class333.aEq(), Class333.aEq());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEq()));
		@class.abw.Add(new Class231.Class232(1000, 1.5873016119003296, Class333.aEq()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flowx10, UnitsGroup.FuelVolumeGroup, 4, Class333.aER(), Class333.aEq());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEq()));
		@class.abw.Add(new Class231.Class232(1000, 15.873015403747559, Class333.aEq()));
		aCY.Add(@class);
		@class = new Class231(UnitType.InjFuelVolume, UnitsGroup.FuelVolumeGroup, 2, Class333.aEr(), Class333.aEr());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEr()));
		@class.abw.Add(new Class231.Class232(100, 11.109999656677246, Class333.aEr()));
		aCY.Add(@class);
		@class = new Class231(UnitType.InjFuelVolume, UnitsGroup.FuelVolumeGroup, 4, Class333.aEr(), Class333.aEr());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEr()));
		@class.abw.Add(new Class231.Class232(100, 11.109999656677246, Class333.aEr()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flow, UnitsGroup.FuelVolumeGroup, 5, Class333.aES(), Class333.aES());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aES()));
		@class.abw.Add(new Class231.Class232(1000, 104.7370834350586, Class333.aES()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Flowx10, UnitsGroup.FuelVolumeGroup, 5, Class333.aEs(), Class333.aES());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aES()));
		@class.abw.Add(new Class231.Class232(1000, 1047.370849609375, Class333.aES()));
		aCY.Add(@class);
		@class = new Class231(UnitType.InjFuelVolume, UnitsGroup.FuelVolumeGroup, 5, Class333.aET(), Class333.aEt());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEt()));
		@class.abw.Add(new Class231.Class232(100, 12.219342231750488, Class333.aEt()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Mileage, UnitsGroup.FuelVolumeGroup, 0, Class333.aEU(), Class333.aEu());
		@class.abu = 50;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEu()));
		@class.abw.Add(new Class231.Class232(100, 10.0, Class333.aEu()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Mileage, UnitsGroup.FuelVolumeGroup, 1, Class333.aEV(), Class333.aEv());
		@class.abu = 50;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEv()));
		@class.abw.Add(new Class231.Class232(100, 23.521499633789062, Class333.aEv()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Mileage, UnitsGroup.FuelVolumeGroup, 3, Class333.aEV(), Class333.aEv());
		@class.abu = 50;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEv()));
		@class.abw.Add(new Class231.Class232(100, 23.521499633789062, Class333.aEv()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Mileage, UnitsGroup.FuelVolumeGroup, 2, Class333.aEW(), Class333.aEv());
		@class.abu = 50;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEv()));
		@class.abw.Add(new Class231.Class232(100, 23.521499633789062, Class333.aEv()));
		aCY.Add(@class);
	}

	private static void smethod_10()
	{
		Class231 @class = new Class231(UnitType.Pressure, UnitsGroup.PressureGroup, 0, Class333.aEw(), Class333.aEw());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(1013, 0.0, Class333.aEw()));
		@class.abw.Add(new Class231.Class232(2013, 100.0, Class333.aEw()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Pressure, UnitsGroup.PressureGroup, 1, Class333.aEX(), Class333.aEx());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEx()));
		@class.abw.Add(new Class231.Class232(1000, 100.0, Class333.aEx()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKPa, UnitsGroup.PressureGroup, 0, Class333.aEY(), Class333.aEy(), Class333.aEZ(), Class333.aEz(), Class333.aeA());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEy(), Class333.aEZ(), Class333.aEz(), Class333.aeA()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aEy(), Class333.aEZ(), Class333.aEz(), Class333.aeA()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKPa, UnitsGroup.PressureGroup, 1, Class333.aEY(), Class333.aEy(), Class333.aEZ(), Class333.aEz(), Class333.aeA());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEy(), Class333.aEZ(), Class333.aEz(), Class333.aeA()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aEy(), Class333.aEZ(), Class333.aEz(), Class333.aeA()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Pressure, UnitsGroup.PressureGroup, 2, Class333.aea(), Class333.aeB());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeB()));
		@class.abw.Add(new Class231.Class232(1013, 1013.0, Class333.aeB()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Pressure, UnitsGroup.PressureGroup, 3, Class333.aeb(), Class333.aeC());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeC()));
		@class.abw.Add(new Class231.Class232(1013, 1.0130000114440918, Class333.aeC()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKPa, UnitsGroup.PressureGroup, 2, Class333.aec(), Class333.aeD(), Class333.aed(), Class333.aeE(), Class333.aee());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 4;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeD(), Class333.aed(), Class333.aeE(), Class333.aee()));
		@class.abw.Add(new Class231.Class232(10000, 1.0, Class333.aeD(), Class333.aed(), Class333.aeE(), Class333.aee()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKPa, UnitsGroup.PressureGroup, 3, Class333.aec(), Class333.aeD(), Class333.aed(), Class333.aeE(), Class333.aee());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 4;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeD(), Class333.aed(), Class333.aeE(), Class333.aee()));
		@class.abw.Add(new Class231.Class232(10000, 1.0, Class333.aeD(), Class333.aed(), Class333.aeE(), Class333.aee()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKPa, UnitsGroup.PressureGroup, 4, Class333.aeF(), Class333.aef(), Class333.aeG(), Class333.aeg(), Class333.aeH());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aef(), Class333.aeG(), Class333.aeg(), Class333.aeH()));
		@class.abw.Add(new Class231.Class232(10, 1.02, Class333.aef(), Class333.aeG(), Class333.aeg(), Class333.aeH()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Pressure, UnitsGroup.PressureGroup, 4, Class333.aeh(), Class333.aeh());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(1013, 0.0, Class333.aeh()));
		@class.abw.Add(new Class231.Class232(2013, 1.0199999809265137, Class333.aeh()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Pressure, UnitsGroup.PressureGroup, 5, Class333.aeI(), Class333.aeI());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(1013, 0.0, Class333.aeI()));
		@class.abw.Add(new Class231.Class232(2013, 14.5, Class333.aeI()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Pressure, UnitsGroup.PressureGroup, 7, Class333.aei(), Class333.aeJ());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeJ()));
		@class.abw.Add(new Class231.Class232(1013, 14.5, Class333.aeJ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Pressure, UnitsGroup.PressureGroup, 6, Class333.aej(), Class333.aeK());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(13, -29.530000686645508, Class333.aek()));
		@class.abw.Add(new Class231.Class232(1013, 0.0, Class333.aek()));
		@class.abw.Add(new Class231.Class232(1013, 0.0, Class333.aeI()));
		@class.abw.Add(new Class231.Class232(2013, 14.5, Class333.aeI()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKPa, UnitsGroup.PressureGroup, 5, Class333.aeL(), Class333.ael(), Class333.aeM(), Class333.aem(), Class333.aeN());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.ael(), Class333.aeM(), Class333.aem(), Class333.aeN()));
		@class.abw.Add(new Class231.Class232(1000, 6.89655, Class333.ael(), Class333.aeM(), Class333.aem(), Class333.aeN()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKPa, UnitsGroup.PressureGroup, 6, Class333.aeL(), Class333.ael(), Class333.aeM(), Class333.aem(), Class333.aeN());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.ael(), Class333.aeM(), Class333.aem(), Class333.aeN()));
		@class.abw.Add(new Class231.Class232(1000, 6.89655, Class333.ael(), Class333.aeM(), Class333.aem(), Class333.aeN()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaPressure, UnitsGroup.PressureGroup, 0, Class333.aen(), Class333.aEw());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abw.Add(new Class231.Class232(101, 0.0, Class333.aEw()));
		@class.abw.Add(new Class231.Class232(201, 100.0, Class333.aEw()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaPressure, UnitsGroup.PressureGroup, 1, Class333.aeO(), Class333.aEx());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEx()));
		@class.abw.Add(new Class231.Class232(100, 100.0, Class333.aEx()));
		@class = new Class231(UnitType.MegaPressure, UnitsGroup.PressureGroup, 2, Class333.aeo(), Class333.aeB());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeB()));
		@class.abw.Add(new Class231.Class232(201, 2010.0, Class333.aeB()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaPressure, UnitsGroup.PressureGroup, 3, Class333.aeP(), Class333.aeC());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeC()));
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.aeC()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaPressure, UnitsGroup.PressureGroup, 4, Class333.aep(), Class333.aeh());
		@class.abw.Add(new Class231.Class232(101, 0.0, Class333.aeh()));
		@class.abw.Add(new Class231.Class232(201, 1.0199999809265137, Class333.aeh()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaPressure, UnitsGroup.PressureGroup, 5, Class333.aeQ(), Class333.aeI());
		@class.abw.Add(new Class231.Class232(101, 0.0, Class333.aeI()));
		@class.abw.Add(new Class231.Class232(201, 14.5, Class333.aeI()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaPressure, UnitsGroup.PressureGroup, 7, Class333.aeQ(), Class333.aeJ());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeI()));
		@class.abw.Add(new Class231.Class232(101, 14.5, Class333.aeI()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MegaPressure, UnitsGroup.PressureGroup, 6, Class333.aeq(), Class333.aeK());
		@class.abw.Add(new Class231.Class232(0, -29.530000686645508, Class333.aek()));
		@class.abw.Add(new Class231.Class232(101, 0.0, Class333.aek()));
		@class.abw.Add(new Class231.Class232(101, 0.0, Class333.aeI()));
		@class.abw.Add(new Class231.Class232(201, 14.5, Class333.aeI()));
		aCY.Add(@class);
		@class = new Class231(UnitType.OffsetPressure, UnitsGroup.PressureGroup, 0, Class333.aeR(), Class333.aEw());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEw()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aEw()));
		aCY.Add(@class);
		@class = new Class231(UnitType.OffsetPressure, UnitsGroup.PressureGroup, 1, Class333.aeR(), Class333.aEw());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEw()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aEw()));
		aCY.Add(@class);
		@class = new Class231(UnitType.OffsetPressure, UnitsGroup.PressureGroup, 2, Class333.aer(), Class333.aeS());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeS()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aeS()));
		aCY.Add(@class);
		@class = new Class231(UnitType.OffsetPressure, UnitsGroup.PressureGroup, 3, Class333.aes(), Class333.aeT());
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeT()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aeT()));
		aCY.Add(@class);
		@class = new Class231(UnitType.OffsetPressure, UnitsGroup.PressureGroup, 4, Class333.aet(), Class333.aeh());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeh()));
		@class.abw.Add(new Class231.Class232(1000, 1.0199999809265137, Class333.aeh()));
		aCY.Add(@class);
		@class = new Class231(UnitType.OffsetPressure, UnitsGroup.PressureGroup, 5, Class333.aeU(), Class333.aeI());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeI()));
		@class.abw.Add(new Class231.Class232(1000, 14.5, Class333.aeI()));
		aCY.Add(@class);
		@class = new Class231(UnitType.OffsetPressure, UnitsGroup.PressureGroup, 6, Class333.aeu(), Class333.aeK());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeI()));
		@class.abw.Add(new Class231.Class232(1000, 14.5, Class333.aeI()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressure, UnitsGroup.PressureGroup, 0, Class333.aEX(), Class333.aEx());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEx()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aEx()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressure, UnitsGroup.PressureGroup, 1, Class333.aEX(), Class333.aEx());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aEx()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aEx()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressure, UnitsGroup.PressureGroup, 2, Class333.aeV(), Class333.aeB());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeB()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aeB()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressure, UnitsGroup.PressureGroup, 3, Class333.aeb(), Class333.aeC());
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeC()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aeC()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressure, UnitsGroup.PressureGroup, 4, Class333.aev(), Class333.aeW());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeW()));
		@class.abw.Add(new Class231.Class232(1000, 1.0199999809265137, Class333.aeW()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressure, UnitsGroup.PressureGroup, 5, Class333.aei(), Class333.aeJ());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeJ()));
		@class.abw.Add(new Class231.Class232(1000, 14.5, Class333.aeJ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressure, UnitsGroup.PressureGroup, 6, Class333.aei(), Class333.aeJ());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeJ()));
		@class.abw.Add(new Class231.Class232(1000, 14.5, Class333.aeJ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressure, UnitsGroup.PressureGroup, 7, Class333.aei(), Class333.aeJ());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeJ()));
		@class.abw.Add(new Class231.Class232(1000, 14.5, Class333.aeJ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressurePerSecond, UnitsGroup.PressureGroup, 0, Class333.aew(), Class333.aeX());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeX()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aeX()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressurePerSecond, UnitsGroup.PressureGroup, 1, Class333.aew(), Class333.aeX());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeX()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aeX()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressurePerSecond, UnitsGroup.PressureGroup, 2, Class333.aex(), Class333.aeY());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeY()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aeY()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressurePerSecond, UnitsGroup.PressureGroup, 3, Class333.aey(), Class333.aeZ());
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aeZ()));
		@class.abw.Add(new Class231.Class232(1013, 1.0130000114440918, Class333.aeZ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressurePerSecond, UnitsGroup.PressureGroup, 4, Class333.aez(), Class333.aFA());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFA()));
		@class.abw.Add(new Class231.Class232(1000, 1.0199999809265137, Class333.aFA()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressurePerSecond, UnitsGroup.PressureGroup, 5, Class333.aFa(), Class333.aFB());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFB()));
		@class.abw.Add(new Class231.Class232(1000, 14.5, Class333.aFB()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AbsPressurePerSecond, UnitsGroup.PressureGroup, 6, Class333.aFa(), Class333.aFB());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFB()));
		@class.abw.Add(new Class231.Class232(1000, 14.5, Class333.aFB()));
		aCY.Add(@class);
		@class = new Class231(UnitType.CurrentPerKPa, UnitsGroup.PressureGroup, 0, Class333.aFb(), Class333.aFC(), Class333.aFc(), Class333.aFD(), Class333.aFd());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFC(), Class333.aFc(), Class333.aFD(), Class333.aFd()));
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.aFC(), Class333.aFc(), Class333.aFD(), Class333.aFd()));
		aCY.Add(@class);
		@class = new Class231(UnitType.CurrentPerKPa, UnitsGroup.PressureGroup, 1, Class333.aFb(), Class333.aFC(), Class333.aFc(), Class333.aFD(), Class333.aFd());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFC(), Class333.aFc(), Class333.aFD(), Class333.aFd()));
		@class.abw.Add(new Class231.Class232(100, 1.0, Class333.aFC(), Class333.aFc(), Class333.aFD(), Class333.aFd()));
		aCY.Add(@class);
		@class = new Class231(UnitType.CurrentPerKPa, UnitsGroup.PressureGroup, 2, Class333.aFE(), Class333.aFe(), Class333.aFF(), Class333.aFf(), Class333.aFG());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFe(), Class333.aFF(), Class333.aFf(), Class333.aFG()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aFe(), Class333.aFF(), Class333.aFf(), Class333.aFG()));
		aCY.Add(@class);
		@class = new Class231(UnitType.CurrentPerKPa, UnitsGroup.PressureGroup, 3, Class333.aFE(), Class333.aFe(), Class333.aFF(), Class333.aFf(), Class333.aFG());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFe(), Class333.aFF(), Class333.aFf(), Class333.aFG()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aFe(), Class333.aFF(), Class333.aFf(), Class333.aFG()));
		aCY.Add(@class);
		@class = new Class231(UnitType.CurrentPerKPa, UnitsGroup.PressureGroup, 4, Class333.aFg(), Class333.aFH(), Class333.aFh(), Class333.aFI(), Class333.aFi());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 0;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFH(), Class333.aFh(), Class333.aFI(), Class333.aFi()));
		@class.abw.Add(new Class231.Class232(1, 1.02, Class333.aFH(), Class333.aFh(), Class333.aFI(), Class333.aFi()));
		aCY.Add(@class);
		@class = new Class231(UnitType.CurrentPerKPa, UnitsGroup.PressureGroup, 5, Class333.aFJ(), Class333.aFj(), Class333.aFK(), Class333.aFk(), Class333.aFL());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFj(), Class333.aFK(), Class333.aFk(), Class333.aFL()));
		@class.abw.Add(new Class231.Class232(100, 6.89655, Class333.aFj(), Class333.aFK(), Class333.aFk(), Class333.aFL()));
		aCY.Add(@class);
		@class = new Class231(UnitType.CurrentPerKPa, UnitsGroup.PressureGroup, 6, Class333.aFJ(), Class333.aFj(), Class333.aFK(), Class333.aFk(), Class333.aFL());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFj(), Class333.aFK(), Class333.aFk(), Class333.aFL()));
		@class.abw.Add(new Class231.Class232(100, 6.89655, Class333.aFj(), Class333.aFK(), Class333.aFk(), Class333.aFL()));
		aCY.Add(@class);
	}

	private static void smethod_11()
	{
		Class231 @class = new Class231(UnitType.Speed, UnitsGroup.DistanceGroup, 0, Class333.aFl(), Class333.aFl());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFl()));
		@class.abw.Add(new Class231.Class232(1000, 100.0, Class333.aFl()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKmph, UnitsGroup.DistanceGroup, 0, Class333.aFM(), Class333.aFm(), Class333.aFN(), Class333.aFn(), Class333.aFO());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFm(), Class333.aFN(), Class333.aFn(), Class333.aFO()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aFm(), Class333.aFN(), Class333.aFn(), Class333.aFO()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKmph, UnitsGroup.DistanceGroup, 1, Class333.aFo(), Class333.aFP(), Class333.aFp(), Class333.aFQ(), Class333.aFq());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFP(), Class333.aFp(), Class333.aFQ(), Class333.aFq()));
		@class.abw.Add(new Class231.Class232(1000, 1.60934, Class333.aFP(), Class333.aFp(), Class333.aFQ(), Class333.aFq()));
		aCY.Add(@class);
		@class = new Class231(UnitType.GearRatio, UnitsGroup.DistanceGroup, 0, Class333.aFR(), Class333.aFR());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFR()));
		@class.abw.Add(new Class231.Class232(1000, 100.0, Class333.aFR()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Speed, UnitsGroup.DistanceGroup, 1, Class333.aFr(), Class333.aFr());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFr()));
		@class.abw.Add(new Class231.Class232(1000, 62.13711929321289, Class333.aFr()));
		aCY.Add(@class);
		@class = new Class231(UnitType.GearRatio, UnitsGroup.DistanceGroup, 1, Class333.aFS(), Class333.aFS());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFS()));
		@class.abw.Add(new Class231.Class232(1000, 62.13711929321289, Class333.aFS()));
		aCY.Add(@class);
		@class = new Class231(UnitType.LongDistance, UnitsGroup.DistanceGroup, 0, Class333.aFs(), Class333.aFs());
		@class.abu = 500;
		@class.abV = 100;
		@class.abv = 50;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFs()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aFs()));
		aCY.Add(@class);
		@class = new Class231(UnitType.LongDistance, UnitsGroup.DistanceGroup, 1, Class333.aFT(), Class333.aFt());
		@class.abu = 500;
		@class.abV = 100;
		@class.abv = 50;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFt()));
		@class.abw.Add(new Class231.Class232(10000, 6213.7119140625, Class333.aFt()));
		aCY.Add(@class);
		@class = new Class231(UnitType.ShortDistance, UnitsGroup.DistanceGroup, 0, Class333.aFU(), Class333.aFU());
		@class.abu = 10;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFU()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aFU()));
		aCY.Add(@class);
		@class = new Class231(UnitType.ShortDistance, UnitsGroup.DistanceGroup, 1, Class333.aFu(), Class333.aFV());
		@class.abu = 10;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 0;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFV()));
		@class.abw.Add(new Class231.Class232(10, 3.28084, Class333.aFV()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PulsesPerLongDistance, UnitsGroup.DistanceGroup, 0, Class333.aFv(), Class333.aFW());
		@class.abu = 500;
		@class.abV = 100;
		@class.abv = 50;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFW()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aFW()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PulsesPerLongDistance, UnitsGroup.DistanceGroup, 1, Class333.aFw(), Class333.aFX());
		@class.abu = 500;
		@class.abV = 100;
		@class.abv = 50;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFX()));
		@class.abw.Add(new Class231.Class232(10000, 16093.4404296875, Class333.aFX()));
		aCY.Add(@class);
		@class = new Class231(UnitType.DrivenDistance, UnitsGroup.DistanceGroup, 0, Class333.aFs(), Class333.aFs());
		@class.abu = 100000;
		@class.abV = 10000;
		@class.abv = 1000;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFs()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aFs()));
		aCY.Add(@class);
		@class = new Class231(UnitType.DrivenDistance, UnitsGroup.DistanceGroup, 1, Class333.aFT(), Class333.aFt());
		@class.abu = 500;
		@class.abV = 100;
		@class.abv = 50;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aFt()));
		@class.abw.Add(new Class231.Class232(10000000, 6213.7119140625, Class333.aFt()));
		aCY.Add(@class);
	}

	private static void smethod_12()
	{
		Class231 @class = new Class231(UnitType.AFR, UnitsGroup.AFRGroup, 0, Class333.aFx(), Class333.aFY());
		@class.abu = 500;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(680, 0.6800000071525574, Class333.aFY()));
		@class.abw.Add(new Class231.Class232(1360, 1.3600000143051147, Class333.aFY()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AFR, UnitsGroup.AFRGroup, 1, Class333.aFy(), Class333.adk());
		@class.abu = 68;
		@class.abV = 34;
		@class.abv = 17;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(680, 10.0, Class333.adk()));
		@class.abw.Add(new Class231.Class232(1360, 20.0, Class333.adk()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AFR, UnitsGroup.AFRGroup, 2, Class333.aFZ(), Class333.adk());
		@class.abu = 77;
		@class.abV = 39;
		@class.abv = 19;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(680, 4.400000095367432, Class333.adk()));
		@class.abw.Add(new Class231.Class232(1360, 8.800000190734863, Class333.adk()));
		aCY.Add(@class);
		@class = new Class231(UnitType.AFR, UnitsGroup.AFRGroup, 3, Class333.aFz(), Class333.adk());
		@class.abu = 77;
		@class.abV = 39;
		@class.abv = 19;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(680, 6.119999885559082, Class333.adk()));
		@class.abw.Add(new Class231.Class232(1360, 12.239999771118164, Class333.adk()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerLambda, UnitsGroup.AFRGroup, 0, Class333.afA(), Class333.afa(), Class333.afB(), Class333.afb(), Class333.afC());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afa(), Class333.afB(), Class333.afb(), Class333.afC()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.afa(), Class333.afB(), Class333.afb(), Class333.afC()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerLambda, UnitsGroup.AFRGroup, 1, Class333.afc(), Class333.afD(), Class333.afd(), Class333.afE(), Class333.afe());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afD(), Class333.afd(), Class333.afE(), Class333.afe()));
		@class.abw.Add(new Class231.Class232(1470, 10.0, Class333.afD(), Class333.afd(), Class333.afE(), Class333.afe()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerLambda, UnitsGroup.AFRGroup, 2, Class333.afc(), Class333.afD(), Class333.afd(), Class333.afE(), Class333.afe());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afD(), Class333.afd(), Class333.afE(), Class333.afe()));
		@class.abw.Add(new Class231.Class232(647, 10.0, Class333.afD(), Class333.afd(), Class333.afE(), Class333.afe()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerLambda, UnitsGroup.AFRGroup, 3, Class333.afc(), Class333.afD(), Class333.afd(), Class333.afE(), Class333.afe());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afD(), Class333.afd(), Class333.afE(), Class333.afe()));
		@class.abw.Add(new Class231.Class232(900, 10.0, Class333.afD(), Class333.afd(), Class333.afE(), Class333.afe()));
		aCY.Add(@class);
	}

	private static void smethod_13()
	{
		Class231 @class = new Class231(UnitType.Temperature, UnitsGroup.TemperatureGroup, 0, Class333.afF(), Class333.afF());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abw.Add(new Class231.Class232(2731, 0.0, Class333.afF()));
		@class.abw.Add(new Class231.Class232(3731, 100.0, Class333.afF()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Temperature, UnitsGroup.TemperatureGroup, 1, Class333.aff(), Class333.aff());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abw.Add(new Class231.Class232(2731, 32.0, Class333.aff()));
		@class.abw.Add(new Class231.Class232(3731, 212.0, Class333.aff()));
		aCY.Add(@class);
		@class = new Class231(UnitType.TemperatureRelative, UnitsGroup.TemperatureGroup, 0, Class333.afF(), Class333.afF());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afF()));
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.afF()));
		aCY.Add(@class);
		@class = new Class231(UnitType.TemperatureRelative, UnitsGroup.TemperatureGroup, 1, Class333.aff(), Class333.aff());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aff()));
		@class.abw.Add(new Class231.Class232(100, 18.0, Class333.aff()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKelvin, UnitsGroup.TemperatureGroup, 0, Class333.afG(), Class333.afG());
		@class.abu = 1000;
		@class.abV = 100;
		@class.abv = 10;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afG(), Class333.afg(), Class333.afH(), Class333.afh()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afG(), Class333.afg(), Class333.afH(), Class333.afh()));
		aCY.Add(@class);
		@class = new Class231(UnitType.PercentPerKelvin, UnitsGroup.TemperatureGroup, 1, Class333.afI(), Class333.afI());
		@class.abu = 1800;
		@class.abV = 180;
		@class.abv = 18;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afI(), Class333.afi(), Class333.afJ(), Class333.afj()));
		@class.abw.Add(new Class231.Class232(9000, 5.0, Class333.afI(), Class333.afi(), Class333.afJ(), Class333.afj()));
		aCY.Add(@class);
	}

	private static void smethod_14()
	{
		Class231 @class = new Class231(UnitType.EngineVolume, UnitsGroup.EngineVolumeGroup, 0, Class333.afK(), Class333.afk());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afk()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.afk()));
		aCY.Add(@class);
		@class = new Class231(UnitType.EngineVolume, UnitsGroup.EngineVolumeGroup, 1, Class333.afL(), Class333.smethod_1310());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_1310()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.smethod_1310()));
		aCY.Add(@class);
		@class = new Class231(UnitType.EngineVolume, UnitsGroup.EngineVolumeGroup, 2, Class333.afl(), Class333.afM());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afM()));
		@class.abw.Add(new Class231.Class232(1000, 61.02374267578125, Class333.afM()));
		aCY.Add(@class);
	}

	private static void smethod_15()
	{
		Class231 @class = new Class231(UnitType.Acceleration, UnitsGroup.AccelerationGroup, 0, Class333.afm(), Class333.afm());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afm()));
		@class.abw.Add(new Class231.Class232(1000, 100.0, Class333.afm()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Acceleration, UnitsGroup.AccelerationGroup, 1, Class333.afN(), Class333.afn());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afn()));
		@class.abw.Add(new Class231.Class232(981, 10.0, Class333.afn()));
		aCY.Add(@class);
	}

	private static void smethod_16()
	{
		Class231 @class = new Class231(UnitType.Mass, UnitsGroup.MassFlowGroup, 0, Class333.afO(), Class333.afn());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afn()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afn()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassOverTime, UnitsGroup.MassFlowGroup, 0, Class333.afo(), Class333.afP());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afP()));
		@class.abw.Add(new Class231.Class232(1000, 10.0, Class333.afP()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassPerCyl, UnitsGroup.MassFlowGroup, 0, Class333.afp(), Class333.afQ());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afQ()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afQ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassOverTime, UnitsGroup.MassFlowGroup, 1, Class333.afq(), Class333.afq());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afq()));
		@class.abw.Add(new Class231.Class232(1000, 36.0, Class333.afq()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassPerRev, UnitsGroup.MassFlowGroup, 0, Class333.afR(), Class333.afr());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afr()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afr()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Mass, UnitsGroup.MassFlowGroup, 1, Class333.afS(), Class333.afn());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afn()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afn()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassPerCyl, UnitsGroup.MassFlowGroup, 1, Class333.afs(), Class333.afQ());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afQ()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afQ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassOverTime, UnitsGroup.MassFlowGroup, 2, Class333.afT(), Class333.afT());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afT()));
		@class.abw.Add(new Class231.Class232(1000, 79.36640167236328, Class333.afT()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassPerRev, UnitsGroup.MassFlowGroup, 1, Class333.afR(), Class333.afr());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afr()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afr()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Mass, UnitsGroup.MassFlowGroup, 2, Class333.aft(), Class333.aft());
		@class.abu = 10;
		@class.abV = 1;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aft()));
		@class.abw.Add(new Class231.Class232(1000, 15.432358741760254, Class333.aft()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassPerCyl, UnitsGroup.MassFlowGroup, 2, Class333.afU(), Class333.afu());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afu()));
		@class.abw.Add(new Class231.Class232(1000, 15.432358741760254, Class333.afu()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassPerRev, UnitsGroup.MassFlowGroup, 2, Class333.afV(), Class333.afv());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afv()));
		@class.abw.Add(new Class231.Class232(1000, 15.432358741760254, Class333.afv()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassFlow, UnitsGroup.MassFlowGroup, 0, Class333.afo(), Class333.afP());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afP()));
		@class.abw.Add(new Class231.Class232(1000, 0.2777777910232544, Class333.afP()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassFlow, UnitsGroup.MassFlowGroup, 1, Class333.afq(), Class333.afq());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afq()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afq()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassFlow, UnitsGroup.MassFlowGroup, 2, Class333.afT(), Class333.afT());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afT()));
		@class.abw.Add(new Class231.Class232(1000, 2.204619884490967, Class333.afT()));
		aCY.Add(@class);
	}

	private static void smethod_17()
	{
		Class231 @class = new Class231(UnitType.ShorterDistance, UnitsGroup.ShorterDistanceGroup, 0, Class333.afW(), Class333.afW());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afW()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afW()));
		aCY.Add(@class);
		@class = new Class231(UnitType.ShorterDistance, UnitsGroup.ShorterDistanceGroup, 1, Class333.afw(), Class333.afw());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afw()));
		@class.abw.Add(new Class231.Class232(10000, 1.0, Class333.afw()));
		aCY.Add(@class);
		@class = new Class231(UnitType.ShorterDistance, UnitsGroup.ShorterDistanceGroup, 2, Class333.afX(), Class333.afX());
		@class.abu = 100;
		@class.abV = 10;
		@class.abv = 1;
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afX()));
		@class.abw.Add(new Class231.Class232(25400, 1.0, Class333.afX()));
		aCY.Add(@class);
	}

	private static void smethod_18()
	{
		Class231 @class = new Class231(UnitType.Power, UnitsGroup.PowerGroup, 0, Class333.afx(), Class333.afx());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afx()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.afx()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Power, UnitsGroup.PowerGroup, 1, Class333.afY(), Class333.afY());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afY()));
		@class.abw.Add(new Class231.Class232(1000, 1.3410199880599976, Class333.afY()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Torque, UnitsGroup.PowerGroup, 0, Class333.afy(), Class333.afy());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afy()));
		@class.abw.Add(new Class231.Class232(1000, 100.0, Class333.afy()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Torque, UnitsGroup.PowerGroup, 1, Class333.afZ(), Class333.afZ());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afZ()));
		@class.abw.Add(new Class231.Class232(1000, 73.756, Class333.afZ()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Force, UnitsGroup.PowerGroup, 0, Class333.afz(), Class333.afz());
		@class.abW = 0;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.afz()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.afz()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Force, UnitsGroup.PowerGroup, 1, Class333.aGA(), Class333.aGA());
		@class.abW = 0;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aGA()));
		@class.abw.Add(new Class231.Class232(1, 0.224809, Class333.aGA()));
		aCY.Add(@class);
	}

	private static void smethod_19()
	{
		Class231 @class = new Class231(UnitType.MassPerEnergy, UnitsGroup.BSFCGroup, 0, Class333.aGa(), Class333.aGa());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aGa()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aGa()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassPerEnergy, UnitsGroup.BSFCGroup, 1, Class333.aGB(), Class333.aGB());
		@class.abW = 2;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aGB()));
		@class.abw.Add(new Class231.Class232(1, 0.001643999945372343, Class333.aGB()));
		aCY.Add(@class);
	}

	private static void smethod_20()
	{
		Class231 @class = new Class231(UnitType.MassRatio, UnitsGroup.MassRatioGroup, 0, Class333.aGb(), Class333.aGC());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aGC()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aGC()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassRatio, UnitsGroup.MassRatioGroup, 1, Class333.aGc(), Class333.aGD());
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aGD()));
		@class.abw.Add(new Class231.Class232(1, 1.0, Class333.aGD()));
		aCY.Add(@class);
		@class = new Class231(UnitType.MassRatio, UnitsGroup.MassRatioGroup, 2, Class333.aGd(), Class333.aGd());
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aGd()));
		@class.abw.Add(new Class231.Class232(1, 0.007000000216066837, Class333.aGd()));
		aCY.Add(@class);
	}

	private static void smethod_21()
	{
		Class231 @class = new Class231(UnitType.Density, UnitsGroup.DensityGroup, 0, Class333.aGE(), Class333.aGE());
		@class.abu = 25;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aGE()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aGE()));
		aCY.Add(@class);
		@class = new Class231(UnitType.DensitySmall, UnitsGroup.DensityGroup, 0, Class333.aGe(), Class333.aGe());
		@class.abu = 25;
		@class.abV = 5;
		@class.abv = 1;
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aGe()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aGe()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Density, UnitsGroup.DensityGroup, 1, Class333.aGF(), Class333.aGF());
		@class.abu = 25;
		@class.abV = 5;
		@class.abv = 1;
		@class.abW = 1;
		@class.abw.Add(new Class231.Class232(10, 1.0, Class333.aGF()));
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aGF()));
		aCY.Add(@class);
	}

	private static void smethod_22()
	{
		Class231 @class = new Class231(UnitType.Time_us, UnitsGroup.TimeUsGroup, 0, Class333.smethod_2059(), Class333.smethod_960());
		@class.abu = 500;
		@class.abV = 50;
		@class.abv = 4;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.smethod_960()));
		@class.abw.Add(new Class231.Class232(1000000, 1.0, Class333.smethod_960()));
		aCY.Add(@class);
		@class = new Class231(UnitType.Time_us, UnitsGroup.TimeUsGroup, 1, Class333.aDX(), Class333.aDx());
		@class.abu = 500;
		@class.abV = 50;
		@class.abv = 4;
		@class.abW = 3;
		@class.abw.Add(new Class231.Class232(0, 0.0, Class333.aDx()));
		@class.abw.Add(new Class231.Class232(1000, 1.0, Class333.aDx()));
		aCY.Add(@class);
	}

	internal static int smethod_23(int int_0)
	{
		int num = 0;
		Class231 @class;
		while (true)
		{
			if (num < aCY.Count)
			{
				@class = aCY[num];
				if (@class.abq == (UnitType)int_0)
				{
					if (@class.abR == UnitsGroup.NoGroup)
					{
						return 0;
					}
					if (@class.abr == aCx[(int)@class.abR])
					{
						if (int_0 != 27)
						{
							break;
						}
						if (@class.abr == 0 || @class.abr == 1)
						{
							return 0;
						}
						if (@class.abr == 2)
						{
							return 1;
						}
						if (@class.abr == 3)
						{
							return 2;
						}
						if (@class.abr == 4)
						{
							return 3;
						}
						if (@class.abr == 5 || @class.abr == 6 || @class.abr == 7)
						{
							return 4;
						}
					}
				}
				num++;
				continue;
			}
			return 0;
		}
		return @class.abr;
	}

	internal static Class231 smethod_24(int int_0, int int_1 = -1)
	{
		int num = 0;
		Class231 @class;
		while (true)
		{
			if (num < aCY.Count)
			{
				@class = aCY[num];
				if (@class.abq == (UnitType)int_0)
				{
					if (@class.abR == UnitsGroup.NoGroup)
					{
						return @class;
					}
					if (int_1 == -1)
					{
						if (@class.abr == aCx[(int)@class.abR])
						{
							return @class;
						}
					}
					else if (int_0 == 27)
					{
						if ((int_1 == 0 && @class.abr == 1) || (int_1 == 1 && @class.abr == 2) || (int_1 == 2 && @class.abr == 3) || (int_1 == 3 && @class.abr == 4) || (int_1 == 4 && @class.abr == 7))
						{
							return @class;
						}
					}
					else if (@class.abr == int_1)
					{
						break;
					}
				}
				num++;
				continue;
			}
			if (int_1 != -1)
			{
				return smethod_24(int_0);
			}
			return null;
		}
		return @class;
	}

	internal static int smethod_25(string string_0, int int_0, int int_1 = -1)
	{
		if (int_0 == 102 && string_0.StartsWith(Class333.smethod_381()))
		{
			string_0.Remove(0, 2);
			return Convert.ToInt32(string_0, 16);
		}
		switch (int_0)
		{
		case 118:
		{
			int result6 = 0;
			double result9;
			if (string_0.Contains(':'))
			{
				string[] array = string_0.Split(':');
				if (array.Length == 2 && int.TryParse(array[0], out var result7) && int.TryParse(array[1], out var result8))
				{
					result6 = result7 * 60 * 60 + result8 * 60;
				}
			}
			else if (double.TryParse(string_0, out result9))
			{
				result6 = (int)(result9 * 60.0 * 60.0);
			}
			return result6;
		}
		case 94:
		{
			if (!string_0.EndsWith(Class333.aGf(), StringComparison.OrdinalIgnoreCase) && !string_0.EndsWith(Class333.aGG(), StringComparison.OrdinalIgnoreCase) && !string_0.EndsWith(Class333.aGg(), StringComparison.OrdinalIgnoreCase))
			{
				if (!string_0.EndsWith(Class333.aGh(), StringComparison.OrdinalIgnoreCase) && !string_0.EndsWith(Class333.smethod_218(), StringComparison.OrdinalIgnoreCase) && !string_0.EndsWith(Class333.aEF(), StringComparison.OrdinalIgnoreCase))
				{
					if (!string_0.EndsWith(Class333.aGI(), StringComparison.OrdinalIgnoreCase) && !string_0.EndsWith(Class333.aGi(), StringComparison.OrdinalIgnoreCase) && !string_0.EndsWith(Class333.aEf(), StringComparison.OrdinalIgnoreCase))
					{
						if (string_0.EndsWith(Class333.smethod_2242(), StringComparison.OrdinalIgnoreCase))
						{
							string_0 = Regex.Replace(string_0, Class333.aGH(), Class333.smethod_102());
							if (double.TryParse(string_0, NumberStyles.Any, CultureInfo.CurrentCulture, out var result))
							{
								return (int)result;
							}
							return 0;
						}
						if (int.TryParse(string_0, out var result2))
						{
							return result2;
						}
						return 0;
					}
					string_0 = Regex.Replace(string_0, Class333.aGH(), Class333.smethod_102());
					if (double.TryParse(string_0, NumberStyles.Any, CultureInfo.CurrentCulture, out var result3))
					{
						return (int)(result3 * 1024.0 * 1024.0 * 1024.0);
					}
					return 0;
				}
				string_0 = Regex.Replace(string_0, Class333.aGH(), Class333.smethod_102());
				if (double.TryParse(string_0, NumberStyles.Any, CultureInfo.CurrentCulture, out var result4))
				{
					return (int)(result4 * 1024.0 * 1024.0);
				}
				return 0;
			}
			string_0 = Regex.Replace(string_0, Class333.aGH(), Class333.smethod_102());
			if (double.TryParse(string_0, NumberStyles.Any, CultureInfo.CurrentCulture, out var result5))
			{
				return (int)(result5 * 1024.0);
			}
			return 0;
		}
		default:
		{
			Class231 @class = smethod_24(int_0, int_1);
			if (@class == null)
			{
				return 0;
			}
			double num = double.Parse(string_0, NumberStyles.Any, CultureInfo.CurrentCulture);
			smethod_27(num, @class, out var class232_, out var class232_2);
			if (num < class232_.BRx + 9.999999747378752E-05 && num > class232_.BRx - 9.999999747378752E-05)
			{
				return class232_.BRX;
			}
			if (num < class232_2.BRx + 9.999999747378752E-05 && num > class232_2.BRx - 9.999999747378752E-05)
			{
				return class232_2.BRX;
			}
			return smethod_33(num, class232_, class232_2);
		}
		}
	}

	internal static int smethod_26(double double_0, int int_0, int int_1 = -1)
	{
		Class231 @class = smethod_24(int_0, int_1);
		if (@class == null)
		{
			return 0;
		}
		smethod_27(double_0, @class, out var class232_, out var class232_2);
		if (double_0 < class232_.BRx + 9.999999747378752E-05 && double_0 > class232_.BRx - 9.999999747378752E-05)
		{
			return class232_.BRX;
		}
		if (double_0 < class232_2.BRx + 9.999999747378752E-05 && double_0 > class232_2.BRx - 9.999999747378752E-05)
		{
			return class232_2.BRX;
		}
		return smethod_33(double_0, class232_, class232_2);
	}

	private static void smethod_27(double double_0, Class231 class231_0, out Class231.Class232 class232_0, out Class231.Class232 class232_1)
	{
		class232_0 = (class232_1 = null);
		if (double_0 <= class231_0.abw[0].BRx)
		{
			class232_0 = class231_0.abw[0];
			class232_1 = class231_0.abw[1];
			return;
		}
		if (double_0 >= class231_0.abw[class231_0.abw.Count - 1].BRx)
		{
			class232_0 = class231_0.abw[class231_0.abw.Count - 1];
			class232_1 = class231_0.abw[class231_0.abw.Count - 2];
			return;
		}
		Class231.Class232 @class = null;
		foreach (Class231.Class232 item in class231_0.abw)
		{
			if (item.BRx < double_0)
			{
				@class = item;
				continue;
			}
			class232_0 = item;
			class232_1 = @class;
			break;
		}
	}

	internal static double smethod_28(int int_0, int int_1, int int_2 = -1)
	{
		double num = int_0;
		Class231 @class = smethod_24(int_1, int_2);
		if (@class == null)
		{
			return num;
		}
		int num2 = 1;
		Class231.Class232 class2;
		while (true)
		{
			if (num2 < @class.abw.Count)
			{
				class2 = @class.abw[num2];
				if (!((double)class2.BRX <= num))
				{
					break;
				}
				num2++;
				continue;
			}
			class2 = @class.abw[@class.abw.Count - 2];
			return smethod_32(num, class2, @class.abw[@class.abw.Count - 1]);
		}
		return smethod_32(num, class2, @class.abw[num2 - 1]);
	}

	internal static string smethod_29(int int_0, int int_1, int int_2 = -1)
	{
		return smethod_31(int_0, int_1, -1, int_2);
	}

	internal static string smethod_30(int int_0, int int_1, int int_2, int int_3 = -1)
	{
		return smethod_31(int_0, int_1, int_2, int_3);
	}

	private static string smethod_31(int int_0, int int_1, int int_2, int int_3)
	{
		double num = int_0;
		double num2 = num;
		switch (int_1)
		{
		case 102:
			return Class333.smethod_381() + string.Format(Class333.aGJ(), int_0);
		case 118:
		{
			string value = ((int_0 < 0) ? Class333.smethod_186() : Class333.smethod_102());
			TimeSpan timeSpan = TimeSpan.FromSeconds(Math.Abs(int_0));
			int value2 = timeSpan.Days * 24 + timeSpan.Hours;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 3);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_134());
			defaultInterpolatedStringHandler.AppendFormatted(timeSpan.Minutes.ToString(Class333.smethod_136()));
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		default:
		{
			Class231 @class = smethod_24(int_1, int_3);
			if (@class == null)
			{
				return string.Format(Class333.aGj(), num);
			}
			int num3 = 1;
			Class231.Class232 class2;
			int num4;
			while (true)
			{
				if (num3 < @class.abw.Count)
				{
					class2 = @class.abw[num3];
					if (!((double)class2.BRX <= num))
					{
						break;
					}
					num3++;
					continue;
				}
				class2 = @class.abw[@class.abw.Count - 2];
				num2 = smethod_32(num, class2, @class.abw[@class.abw.Count - 1]);
				num4 = ((int_2 == -1) ? @class.abW : int_2);
				return string.Format(Class333.aGK() + num4 + Class333.aGk(), num2);
			}
			num2 = smethod_32(num, class2, @class.abw[num3 - 1]);
			num4 = ((int_2 == -1) ? @class.abW : int_2);
			return string.Format(Class333.aGK() + num4 + Class333.aGk(), num2);
		}
		}
	}

	private static double smethod_32(double double_0, Class231.Class232 class232_0, Class231.Class232 class232_1)
	{
		double num = (class232_1.BRx - class232_0.BRx) / ((double)class232_1.BRX - (double)class232_0.BRX);
		double num2 = class232_0.BRx - num * (double)class232_0.BRX;
		return num * double_0 + num2;
	}

	private static int smethod_33(double double_0, Class231.Class232 class232_0, Class231.Class232 class232_1)
	{
		double num = ((double)class232_1.BRX - (double)class232_0.BRX) / (class232_1.BRx - class232_0.BRx);
		double num2 = (double)class232_0.BRX - num * class232_0.BRx;
		return (int)Math.Round(num * double_0 + num2);
	}

	internal static string smethod_34(int int_0, int int_1 = -1)
	{
		Class231 @class = smethod_24(int_0, int_1);
		if (@class == null)
		{
			return string.Empty;
		}
		return @class.abS;
	}

	internal static string smethod_35(int int_0, int int_1, bool bool_0, int int_2, int int_3 = -1)
	{
		Class231 @class = smethod_24(int_1, int_3);
		if (@class != null)
		{
			if (!bool_0 && int_1 != 94)
			{
				switch (int_0)
				{
				case 0:
					return @class.abs;
				case -1:
					return @class.abT;
				case -2:
					return @class.abt;
				case 1:
					return @class.abU;
				}
			}
			else
			{
				for (int i = 1; i < @class.abw.Count; i++)
				{
					Class231.Class232 class2 = @class.abw[i];
					if (int_2 <= class2.BRX || i == @class.abw.Count - 1)
					{
						switch (int_0)
						{
						case 0:
							return class2.BRY;
						case -1:
							return class2.BRy;
						case -2:
							return class2.BRZ;
						case 1:
							return class2.BRz;
						}
					}
				}
			}
		}
		return string.Empty;
	}

	internal static int smethod_36(int int_0, int int_1 = -1)
	{
		return smethod_24(int_0, int_1)?.abv ?? 1;
	}

	internal static int smethod_37(int int_0, int int_1 = -1)
	{
		return smethod_24(int_0, int_1)?.abV ?? 1;
	}

	internal static int smethod_38(int int_0, int int_1 = -1)
	{
		return smethod_24(int_0, int_1)?.abu ?? 1;
	}

	internal static int smethod_39(int int_0, int int_1 = -1)
	{
		return smethod_24(int_0, int_1)?.abW ?? 0;
	}
}
