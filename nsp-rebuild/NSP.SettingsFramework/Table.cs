using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using NSP.UnitConversion;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class Table : Setting, Interface4
{
	internal class Class274
	{
		internal Dictionary<AxisType, int> bbJ = new Dictionary<AxisType, int>();

		internal Dictionary<AxisType, AxisBehaviour> bbj = new Dictionary<AxisType, AxisBehaviour>();

		internal Dictionary<AxisType, List<int>> bbK = new Dictionary<AxisType, List<int>>();

		internal UnitType bbk;

		internal List<List<List<int>>> bbL;
	}

	private Setting bAC;

	private TableAxis bAc;

	private TableAxis bAD;

	private TableAxis bAd;

	private bool bAE;

	private bool bAe;

	private int bAF;

	private List<Point> bAf = new List<Point>();

	private Point bAG = new Point(-1, -1);

	private bool bAg = true;

	private bool bAH;

	private int bAh = 1;

	private bool bAI = true;

	private const int bAi = 28;

	private const int bAJ = 35;

	private const float bAj = (float)Math.PI / 180f;

	private float bAK = 28f;

	private float bAk = 35f;

	private float bAL = 0.4886922f;

	private float bAl = 0.61086524f;

	private float bAM = (float)Math.Sin(0.48869219422340393);

	private float bAm = (float)Math.Cos(0.48869219422340393);

	private float bAN = (float)Math.Sin(0.6108652353286743);

	private float bAn = (float)Math.Cos(0.6108652353286743);

	public const string MONOTONICITY_ERROR_STRING = "The values in this table must be monotonic";

	public const string RISING_MONOTONICITY_ERROR_STRING = "The values in this table must be rising monotonic";

	public const string FALLING_MONOTONICITY_ERROR_STRING = "The values in this table must be falling monotonic";

	[CompilerGenerated]
	private EventHandler bAO;

	[CompilerGenerated]
	private EventHandler bAo;

	[CompilerGenerated]
	private EventHandler bAP;

	[CompilerGenerated]
	private EventHandler bAp;

	[CompilerGenerated]
	private EventHandler bAQ;

	[CompilerGenerated]
	private EventHandler bAq;

	[CompilerGenerated]
	private EventHandler bAR;

	public TableAxis HorizAxis
	{
		get
		{
			if (bAH)
			{
				return bAD;
			}
			return bAc;
		}
	}

	public TableAxis VertAxis
	{
		get
		{
			if (bAH)
			{
				return bAc;
			}
			return bAD;
		}
	}

	public TableAxis ColumnAxis => bAc;

	public TableAxis RowAxis => bAD;

	public TableAxis SliceAxis => bAd;

	public Setting TableDataSetting => bAC;

	public bool AllCellsOnFirstColumnMustBeZero
	{
		get
		{
			return bAE;
		}
		set
		{
			bAE = value;
		}
	}

	public bool AllCellsOnFirstRowMustBeZero
	{
		get
		{
			return bAe;
		}
		set
		{
			bAe = value;
		}
	}

	public bool InvertRows
	{
		get
		{
			return bAg;
		}
		set
		{
			if (bAg != value)
			{
				bAg = value;
				if (bAO != null)
				{
					bAO(this, null);
				}
			}
		}
	}

	public bool SwapColumnsAndRows
	{
		get
		{
			return bAH;
		}
		set
		{
			if (bAH != value)
			{
				bAH = value;
				if (bAo != null)
				{
					bAo(this, null);
				}
			}
		}
	}

	public int UserSliceIndex
	{
		get
		{
			return bAF;
		}
		set
		{
			if (bAF != value)
			{
				bAF = value;
				if (bAP != null)
				{
					bAP(this, null);
				}
			}
		}
	}

	public Point UserCurrentCellHorizVertIndex
	{
		get
		{
			return bAG;
		}
		set
		{
			bAG = value;
		}
	}

	public List<Point> HorizVertIndexPerUserSelectedCell
	{
		get
		{
			return bAf;
		}
		set
		{
			bAf = value;
			if (bAp != null)
			{
				bAp(this, null);
			}
		}
	}

	public int UserZoomLevel
	{
		get
		{
			return bAh;
		}
		set
		{
			if (bAh != value)
			{
				bAh = value;
				if (bAQ != null)
				{
					bAQ(this, null);
				}
			}
		}
	}

	public bool ShowBars
	{
		get
		{
			return bAI;
		}
		set
		{
			if (bAI != value)
			{
				bAI = value;
				if (bAq != null)
				{
					bAq(this, null);
				}
			}
		}
	}

	public float RotationXAngleDegrees
	{
		get
		{
			return bAK;
		}
		set
		{
			bAK = value;
			bAL = bAK * ((float)Math.PI / 180f);
			bAM = (float)Math.Sin(bAL);
			bAm = (float)Math.Cos(bAL);
		}
	}

	public float RotationYAngleDegrees
	{
		get
		{
			return bAk;
		}
		set
		{
			bAk = value;
			bAl = bAk * ((float)Math.PI / 180f);
			bAN = (float)Math.Sin(bAl);
			bAn = (float)Math.Cos(bAl);
			if (bAR != null)
			{
				bAR(this, null);
			}
		}
	}

	public float SinXFor3DView => bAM;

	public float CosXFor3DView => bAm;

	public float SinYFor3DView => bAN;

	public float CosYFor3DView => bAn;

	public event EventHandler OnInvertRows
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = bAO;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAO, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = bAO;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAO, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler OnSwapColumnsAndRows
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = bAo;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAo, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = bAo;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAo, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler OnUserSliceIndexChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = bAP;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAP, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = bAP;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAP, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler OnUserSelectionChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = bAp;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAp, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = bAp;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAp, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler OnUserZoomLevelChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = bAQ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAQ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = bAQ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAQ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler OnShowHideBarsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = bAq;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAq, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = bAq;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAq, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler OnViewingAngleChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = bAR;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAR, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = bAR;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref bAR, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Table(Framework framework, string name, int int_0, int byteAddress, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, bool_0: false, name, int_0, byteAddress, parentSettingOrSpecialObject, parentModuleName)
	{
		switch (Class104.BvE)
		{
		default:
			bAg = true;
			break;
		case Enum71.const_1:
			bAg = false;
			break;
		case Enum71.const_0:
			bAg = true;
			break;
		}
	}

	public bool ColumnsEnabled()
	{
		if (bAc != null)
		{
			return bAc.method_73();
		}
		return false;
	}

	public bool RowsEnabled()
	{
		if (bAD != null)
		{
			return bAD.method_73();
		}
		return false;
	}

	public bool HorizAxisEnabled()
	{
		if (bAH)
		{
			return RowsEnabled();
		}
		return ColumnsEnabled();
	}

	public bool VertAxisEnabled()
	{
		if (bAH)
		{
			return ColumnsEnabled();
		}
		return RowsEnabled();
	}

	public bool SlicesEnabled()
	{
		if (bAd != null)
		{
			return bAd.method_73();
		}
		return false;
	}

	public List<int> GetDataIdsOfChannelsPerEnabledAxis()
	{
		List<int> list = new List<int>();
		if (HorizAxis != null && HorizAxis.method_90() != null && HorizAxisEnabled())
		{
			Setting setting = HorizAxis.method_92();
			if (setting != null)
			{
				list.Add(setting.method_64());
			}
		}
		if (VertAxis != null && VertAxis.method_90() != null && VertAxisEnabled())
		{
			Setting setting2 = VertAxis.method_92();
			if (setting2 != null)
			{
				list.Add(setting2.method_64());
			}
		}
		if (SliceAxis != null && SliceAxis.method_90() != null && SlicesEnabled())
		{
			Setting setting3 = SliceAxis.method_92();
			if (setting3 != null)
			{
				list.Add(setting3.method_64());
			}
		}
		return list;
	}

	public TableAxis GetAxisUsingChannel(int channelDataId)
	{
		if (ColumnsEnabled() && bAc.method_90() != null && bAc.method_92() != null && bAc.method_92().method_64() == channelDataId)
		{
			return bAc;
		}
		if (RowsEnabled() && bAD.method_90() != null && bAD.method_92() != null && bAD.method_92().method_64() == channelDataId)
		{
			return bAD;
		}
		if (SlicesEnabled() && bAd.method_90() != null && bAd.method_92() != null && bAd.method_92().method_64() == channelDataId)
		{
			return bAd;
		}
		return null;
	}

	public int ColumnCount()
	{
		int result = 1;
		if (ColumnsEnabled())
		{
			result = bAc.method_74();
		}
		return result;
	}

	public int RowCount()
	{
		int result = 1;
		if (RowsEnabled())
		{
			result = bAD.method_74();
		}
		return result;
	}

	public int HorizAxisCount()
	{
		if (bAH)
		{
			return RowCount();
		}
		return ColumnCount();
	}

	public int VertAxisCount()
	{
		if (bAH)
		{
			return ColumnCount();
		}
		return RowCount();
	}

	public int SliceCount()
	{
		int result = 1;
		if (SlicesEnabled())
		{
			result = bAd.method_74();
		}
		return result;
	}

	public void GetColumnIndexAndRowIndex(int horizIndex, int vertIndex, out int columnIndex, out int rowIndex)
	{
		if (bAH)
		{
			rowIndex = horizIndex;
			if (bAg)
			{
				columnIndex = ColumnCount() - 1 - vertIndex;
			}
			else
			{
				columnIndex = vertIndex;
			}
		}
		else
		{
			columnIndex = horizIndex;
			if (bAg)
			{
				rowIndex = RowCount() - 1 - vertIndex;
			}
			else
			{
				rowIndex = vertIndex;
			}
		}
	}

	public void FindComponents()
	{
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject.method_2() == Class333.smethod_796())
			{
				bAC = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject is TableAxis)
			{
				TableAxis tableAxis = settingOrSpecialObject as TableAxis;
				if (tableAxis.method_71() == AxisType.Column)
				{
					bAc = tableAxis;
				}
				else if (tableAxis.method_71() == AxisType.Row)
				{
					bAD = tableAxis;
				}
				else if (tableAxis.method_71() == AxisType.Slice)
				{
					bAd = tableAxis;
				}
				tableAxis.method_94();
			}
		}
	}

	public void DeleteFromHorizAxis(int horizIndex)
	{
		bAC.method_268();
		for (int i = horizIndex + 1; i < HorizAxis.method_88().method_256(); i++)
		{
			HorizAxis.method_89().method_274(i - 1, HorizAxis.method_89().method_258(i), bool_0: true);
			for (int j = 0; j < SliceCount(); j++)
			{
				for (int k = 0; k < VertAxisCount(); k++)
				{
					if (bAH)
					{
						bAC.method_273(k, i - 1, j, bAC.method_257(k, i, j), bool_0: true);
					}
					else
					{
						bAC.method_273(i - 1, k, j, bAC.method_257(i, k, j), bool_0: true);
					}
				}
			}
		}
		HorizAxis.method_88().method_272(HorizAxis.method_88().method_256() - 1, bool_0: true);
		bAC.method_267(bool_0: true);
		if (m_framework.awo == null || bAH)
		{
			return;
		}
		Setting setting = m_framework.awo.method_2(method_64());
		Setting setting2 = m_framework.awo.method_3(method_64());
		Setting setting3 = m_framework.awo.method_4(method_64());
		if (setting == null || setting2 == null || setting3 == null)
		{
			return;
		}
		int num = setting2.method_256();
		int num2 = setting3.method_256();
		if (num == num2 && num2 == horizIndex)
		{
			m_framework.awo.method_1(method_64());
			return;
		}
		if (num > horizIndex)
		{
			setting2.method_272(num - 1, bool_0: true);
		}
		if (num2 > horizIndex)
		{
			setting3.method_272(num2 - 1, bool_0: true);
		}
	}

	public void DeleteFromVertAxis(int vertIndex)
	{
		bAC.method_268();
		for (int i = vertIndex + 1; i < VertAxis.method_88().method_256(); i++)
		{
			VertAxis.method_89().method_274(i - 1, VertAxis.method_89().method_258(i), bool_0: true);
			for (int j = 0; j < SliceCount(); j++)
			{
				for (int k = 0; k < HorizAxisCount(); k++)
				{
					if (bAH)
					{
						bAC.method_273(i - 1, k, j, bAC.method_257(i, k, j), bool_0: true);
					}
					else
					{
						bAC.method_273(k, i - 1, j, bAC.method_257(k, i, j), bool_0: true);
					}
				}
			}
		}
		VertAxis.method_88().method_272(VertAxis.method_88().method_256() - 1, bool_0: true);
		bAC.method_267(bool_0: true);
		if (m_framework.awo == null || bAH)
		{
			return;
		}
		Setting setting = m_framework.awo.method_2(method_64());
		if (setting != null)
		{
			int num = setting.method_256();
			if (num == vertIndex)
			{
				m_framework.awo.method_1(method_64());
			}
			else if (num > vertIndex)
			{
				setting.method_272(num - 1, bool_0: true);
			}
		}
	}

	public void DeleteSlice(int sliceIndex)
	{
		bAC.method_268();
		for (int i = sliceIndex + 1; i < bAd.method_88().method_256(); i++)
		{
			bAd.method_89().method_274(i - 1, bAd.method_89().method_258(i), bool_0: true);
			for (int j = 0; j < HorizAxisCount(); j++)
			{
				for (int k = 0; k < VertAxisCount(); k++)
				{
					if (bAH)
					{
						bAC.method_273(k, j, i - 1, bAC.method_257(k, j, i), bool_0: true);
					}
					else
					{
						bAC.method_273(j, k, i - 1, bAC.method_257(j, k, i), bool_0: true);
					}
				}
			}
		}
		bAd.method_88().method_272(bAd.method_88().method_256() - 1, bool_0: true);
		bAC.method_267(bool_0: true);
	}

	public bool ValueExistsOnHorizAxis(int rawAxisValue)
	{
		int num = 0;
		while (true)
		{
			if (num >= HorizAxisCount())
			{
				return false;
			}
			int num2 = ((!bAH) ? bAc.method_89().method_258(num) : bAD.method_89().method_258(num));
			if (num2 == rawAxisValue)
			{
				break;
			}
			num++;
		}
		return true;
	}

	public bool ValueExistsOnVertAxis(int rawAxisValue)
	{
		int num = 0;
		while (true)
		{
			if (num >= VertAxisCount())
			{
				return false;
			}
			int num2 = ((!bAH) ? bAD.method_89().method_258(num) : bAc.method_89().method_258(num));
			if (num2 == rawAxisValue)
			{
				break;
			}
			num++;
		}
		return true;
	}

	public bool ValueExistsOnSliceAxis(int rawAxisValue)
	{
		int num = 0;
		while (true)
		{
			if (num < SliceCount())
			{
				if (bAd.method_89().method_258(num) == rawAxisValue)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public int InsertIntoHorizAxis(int newRawAxisValue)
	{
		int num = 0;
		int num2 = HorizAxisCount() - 1;
		while (num2 >= 0)
		{
			int num3 = HorizAxis.method_89().method_258(num2);
			if (newRawAxisValue <= num3)
			{
				num2--;
				continue;
			}
			num = num2 + 1;
			break;
		}
		bAC.method_268();
		if (bAH)
		{
			for (int num4 = bAD.method_88().method_256() - 1; num4 >= num; num4--)
			{
				bAD.method_89().method_274(num4 + 1, bAD.method_89().method_258(num4), bool_0: true);
				for (int i = 0; i < SliceCount(); i++)
				{
					for (int j = 0; j < VertAxisCount(); j++)
					{
						bAC.method_273(j, num4 + 1, i, bAC.method_257(j, num4, i), bool_0: true);
					}
				}
			}
			bAD.method_89().method_274(num, newRawAxisValue, bool_0: true);
			for (int k = 0; k < SliceCount(); k++)
			{
				for (int l = 0; l < VertAxisCount(); l++)
				{
					if (num == 0)
					{
						bAC.method_273(l, 0, k, bAC.method_257(l, 1, k), bool_0: true);
					}
					else if (num == HorizAxisCount())
					{
						bAC.method_273(l, num, k, bAC.method_257(l, num - 1, k), bool_0: true);
					}
					else
					{
						LineariseLeftToRight(l, num - 1, num + 1, null, forHorizAxisInsertion: true);
					}
				}
			}
			bAD.method_88().method_272(bAD.method_88().method_256() + 1, bool_0: true);
		}
		else
		{
			for (int num5 = bAc.method_88().method_256() - 1; num5 >= num; num5--)
			{
				bAc.method_89().method_274(num5 + 1, bAc.method_89().method_258(num5), bool_0: true);
				for (int m = 0; m < SliceCount(); m++)
				{
					for (int n = 0; n < VertAxisCount(); n++)
					{
						bAC.method_273(num5 + 1, n, m, bAC.method_257(num5, n, m), bool_0: true);
					}
				}
			}
			bAc.method_89().method_274(num, newRawAxisValue, bool_0: true);
			for (int num6 = 0; num6 < SliceCount(); num6++)
			{
				for (int num7 = 0; num7 < VertAxisCount(); num7++)
				{
					if (num == 0)
					{
						bAC.method_273(0, num7, num6, bAC.method_257(1, num7, num6), bool_0: true);
					}
					else if (num == HorizAxisCount())
					{
						bAC.method_273(num, num7, num6, bAC.method_257(num - 1, num7, num6), bool_0: true);
					}
					else
					{
						LineariseLeftToRight(num7, num - 1, num + 1, null, forHorizAxisInsertion: true);
					}
				}
			}
			bAc.method_88().method_272(bAc.method_88().method_256() + 1, bool_0: true);
		}
		bAC.method_267(bool_0: true);
		if (m_framework.awo != null && !bAH)
		{
			Setting setting = m_framework.awo.method_2(method_64());
			Setting setting2 = m_framework.awo.method_3(method_64());
			Setting setting3 = m_framework.awo.method_4(method_64());
			if (setting != null && setting2 != null && setting3 != null)
			{
				int num8 = setting2.method_256();
				int num9 = setting3.method_256();
				if (num9 >= num)
				{
					setting3.method_272(num9 + 1, bool_0: true);
				}
				if (num8 >= num)
				{
					setting2.method_272(num8 + 1, bool_0: true);
				}
			}
		}
		return num;
	}

	public int InsertIntoVertAxis(int newRawAxisValue)
	{
		int num = 0;
		int num2 = VertAxisCount() - 1;
		while (num2 >= 0)
		{
			int num3 = VertAxis.method_89().method_258(num2);
			if (newRawAxisValue <= num3)
			{
				num2--;
				continue;
			}
			num = num2 + 1;
			break;
		}
		bAC.method_268();
		if (bAH)
		{
			for (int num4 = bAc.method_88().method_256() - 1; num4 >= num; num4--)
			{
				bAc.method_89().method_274(num4 + 1, bAc.method_89().method_258(num4), bool_0: true);
				for (int i = 0; i < SliceCount(); i++)
				{
					for (int j = 0; j < HorizAxisCount(); j++)
					{
						bAC.method_273(num4 + 1, j, i, bAC.method_257(num4, j, i), bool_0: true);
					}
				}
			}
			bAc.method_89().method_274(num, newRawAxisValue, bool_0: true);
			for (int k = 0; k < SliceCount(); k++)
			{
				for (int l = 0; l < HorizAxisCount(); l++)
				{
					if (num == 0)
					{
						bAC.method_273(0, l, k, bAC.method_257(1, l, k), bool_0: true);
					}
					else if (num == VertAxisCount())
					{
						bAC.method_273(num, l, k, bAC.method_257(num - 1, l, k), bool_0: true);
					}
					else if (bAg)
					{
						int num5 = VertAxisCount() - 1 - num;
						LineariseTopToBottom(l, num5 - 1, num5 + 1, null);
					}
					else
					{
						LineariseTopToBottom(l, num - 1, num + 1, null);
					}
				}
			}
			bAc.method_88().method_272(bAc.method_88().method_256() + 1, bool_0: true);
		}
		else
		{
			for (int num6 = bAD.method_88().method_256() - 1; num6 >= num; num6--)
			{
				bAD.method_89().method_274(num6 + 1, bAD.method_89().method_258(num6), bool_0: true);
				for (int m = 0; m < SliceCount(); m++)
				{
					for (int n = 0; n < HorizAxisCount(); n++)
					{
						bAC.method_273(n, num6 + 1, m, bAC.method_257(n, num6, m), bool_0: true);
					}
				}
			}
			bAD.method_89().method_274(num, newRawAxisValue, bool_0: true);
			for (int num7 = 0; num7 < SliceCount(); num7++)
			{
				for (int num8 = 0; num8 < HorizAxisCount(); num8++)
				{
					if (num == 0)
					{
						bAC.method_273(num8, 0, num7, bAC.method_257(num8, 1, num7), bool_0: true);
					}
					else if (num == VertAxisCount())
					{
						bAC.method_273(num8, num, num7, bAC.method_257(num8, num - 1, num7), bool_0: true);
					}
					else if (bAg)
					{
						int num9 = VertAxisCount() - 1 - num;
						LineariseTopToBottom(num8, num9 - 1, num9 + 1, null);
					}
					else
					{
						LineariseTopToBottom(num8, num - 1, num + 1, null);
					}
				}
			}
			bAD.method_88().method_272(bAD.method_88().method_256() + 1, bool_0: true);
		}
		bAC.method_267(bool_0: true);
		if (m_framework.awo != null && !bAH)
		{
			Setting setting = m_framework.awo.method_2(method_64());
			if (setting != null)
			{
				int num10 = setting.method_256();
				if (num10 >= num)
				{
					setting.method_272(num10 + 1, bool_0: true);
				}
			}
		}
		return num;
	}

	public int InsertSlice(int newRawSliceValue)
	{
		int num = 0;
		int num2 = SliceCount() - 1;
		while (num2 >= 0)
		{
			int num3 = bAd.method_89().method_258(num2);
			if (newRawSliceValue <= num3)
			{
				num2--;
				continue;
			}
			num = num2 + 1;
			break;
		}
		bAC.method_268();
		for (int num4 = bAd.method_88().method_256() - 1; num4 >= num; num4--)
		{
			bAd.method_89().method_274(num4 + 1, bAd.method_89().method_258(num4), bool_0: true);
			for (int i = 0; i < HorizAxisCount(); i++)
			{
				for (int j = 0; j < VertAxisCount(); j++)
				{
					if (bAH)
					{
						bAC.method_273(j, i, num4 + 1, bAC.method_257(j, i, num4), bool_0: true);
					}
					else
					{
						bAC.method_273(i, j, num4 + 1, bAC.method_257(i, j, num4), bool_0: true);
					}
				}
			}
		}
		bAd.method_89().method_274(num, newRawSliceValue, bool_0: true);
		for (int k = 0; k < HorizAxisCount(); k++)
		{
			for (int l = 0; l < VertAxisCount(); l++)
			{
				if (num == 0)
				{
					if (bAH)
					{
						bAC.method_273(l, k, 0, bAC.method_257(l, k, 1), bool_0: true);
					}
					else
					{
						bAC.method_273(k, l, 0, bAC.method_257(k, l, 1), bool_0: true);
					}
				}
				else if (num == SliceCount())
				{
					if (bAH)
					{
						bAC.method_273(l, k, num, bAC.method_257(l, k, num - 1), bool_0: true);
					}
					else
					{
						bAC.method_273(k, l, num, bAC.method_257(k, l, num - 1), bool_0: true);
					}
				}
				else if (bAH)
				{
					int num5 = bAC.method_257(l, k, num + 1) - bAC.method_257(l, k, num - 1);
					int num6 = bAd.method_89().method_258(num + 1) - bAd.method_89().method_258(num - 1);
					double num7 = (double)num5 / (double)num6;
					int num8 = bAC.method_257(l, k, num - 1) - (int)Math.Round(num7 * (double)bAd.method_89().method_258(num - 1));
					int num9 = bAd.method_89().method_258(num);
					int int_ = (int)Math.Round(num7 * (double)num9 + (double)num8);
					bAC.method_273(l, k, num, int_, bool_0: true);
				}
				else
				{
					int num10 = bAC.method_257(k, l, num + 1) - bAC.method_257(k, l, num - 1);
					int num11 = bAd.method_89().method_258(num + 1) - bAd.method_89().method_258(num - 1);
					double num12 = (double)num10 / (double)num11;
					int num13 = bAC.method_257(k, l, num - 1) - (int)Math.Round(num12 * (double)bAd.method_89().method_258(num - 1));
					int num14 = bAd.method_89().method_258(num);
					int int_2 = (int)Math.Round(num12 * (double)num14 + (double)num13);
					bAC.method_273(k, l, num, int_2, bool_0: true);
				}
			}
		}
		bAd.method_88().method_272(bAd.method_88().method_256() + 1, bool_0: true);
		bAC.method_267(bool_0: true);
		return num;
	}

	public void GetOperatingPoint(ref int currentHoriz, ref int currentVert, ref int currentSlice)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		int num = HorizAxisCount();
		int num2 = VertAxisCount();
		int num3 = SliceCount();
		currentHoriz = 0;
		if (HorizAxisEnabled())
		{
			Setting setting = HorizAxis.method_92();
			if (setting != null)
			{
				int num4 = setting.method_256();
				for (int i = 0; i < num; i++)
				{
					int num5 = HorizAxis.method_89().method_258(i);
					int num6 = ((i != 0) ? HorizAxis.method_89().method_258(i - 1) : num5);
					int num7 = ((i != num - 1) ? HorizAxis.method_89().method_258(i + 1) : num5);
					if ((i == 0 && num4 < num6) || (i == num - 1 && num4 > num7) || (num4 >= num6 + (num5 - num6) / 2 && num4 <= num5 + (num7 - num5) / 2))
					{
						currentHoriz = i;
						break;
					}
				}
			}
		}
		if (bAg)
		{
			currentVert = num2 - 1;
		}
		else
		{
			currentVert = 0;
		}
		if (VertAxisEnabled())
		{
			Setting setting2 = VertAxis.method_92();
			if (setting2 != null)
			{
				int num8 = setting2.method_256();
				for (int j = 0; j < num2; j++)
				{
					if (bAg)
					{
						int num9 = VertAxis.method_89().method_258(num2 - 1 - j);
						int num10 = ((j != 0) ? VertAxis.method_89().method_258(num2 - 1 - (j - 1)) : num9);
						int num11 = ((j != num2 - 1) ? VertAxis.method_89().method_258(num2 - 1 - (j + 1)) : num9);
						if ((j == 0 && num8 > num10) || (j == num2 - 1 && num8 < num11) || (num8 <= num9 + (num10 - num9) / 2 && num8 >= num9 - (num9 - num11) / 2))
						{
							currentVert = j;
							break;
						}
					}
					else
					{
						int num9 = VertAxis.method_89().method_258(j);
						int num10 = ((j != 0) ? VertAxis.method_89().method_258(j - 1) : num9);
						int num11 = ((j != num2 - 1) ? VertAxis.method_89().method_258(j + 1) : num9);
						if ((j == 0 && num8 < num10) || (j == num2 - 1 && num8 > num11) || (num8 >= num10 + (num9 - num10) / 2 && num8 <= num9 + (num11 - num9) / 2))
						{
							currentVert = j;
							break;
						}
					}
				}
			}
		}
		currentSlice = 0;
		if (!SlicesEnabled())
		{
			return;
		}
		Setting setting3 = SliceAxis.method_92();
		if (setting3 == null)
		{
			return;
		}
		int num12 = setting3.method_256();
		int num13 = 0;
		while (true)
		{
			if (num13 < num3)
			{
				int num14 = SliceAxis.method_89().method_258(num13);
				int num15 = ((num13 != 0) ? SliceAxis.method_89().method_258(num13 - 1) : num14);
				int num16 = ((num13 != num3 - 1) ? SliceAxis.method_89().method_258(num13 + 1) : num14);
				if ((num13 == 0 && num12 < num15) || (num13 == num3 - 1 && num12 > num16) || (num12 >= num15 + (num14 - num15) / 2 && num12 <= num14 + (num16 - num14) / 2))
				{
					break;
				}
				num13++;
				continue;
			}
			return;
		}
		currentSlice = num13;
	}

	public void IncreaseOrDecreaseSelectedCellValues(KeyEventArgs keyEventArgs_0)
	{
		int int_ = bAC.method_231();
		int val = method_228();
		int val2 = method_229();
		int int_2 = 0;
		if (SlicesEnabled())
		{
			int_2 = UserSliceIndex;
		}
		bAC.method_268();
		foreach (Point item in HorizVertIndexPerUserSelectedCell)
		{
			GetColumnIndexAndRowIndex(item.X, item.Y, out var columnIndex, out var rowIndex);
			int num = bAC.method_257(columnIndex, rowIndex, int_2);
			if ((keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Prior) || keyEventArgs_0.KeyData == Keys.OemPeriod)
			{
				num += Class233.smethod_36(int_);
			}
			else if (keyEventArgs_0.KeyData != Keys.Prior && keyEventArgs_0.KeyData != Keys.Oem7)
			{
				if ((keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Prior) || keyEventArgs_0.KeyData == Keys.OemCloseBrackets)
				{
					num += Class233.smethod_38(int_);
				}
				else if ((keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Next) || keyEventArgs_0.KeyData == Keys.Oemcomma)
				{
					num -= Class233.smethod_36(int_);
				}
				else if (keyEventArgs_0.KeyData != Keys.Next && keyEventArgs_0.KeyData != Keys.OemSemicolon)
				{
					if ((keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Next) || keyEventArgs_0.KeyData == Keys.OemOpenBrackets)
					{
						num -= Class233.smethod_38(int_);
					}
				}
				else
				{
					num -= Class233.smethod_37(int_);
				}
			}
			else
			{
				num += Class233.smethod_37(int_);
			}
			num = Math.Min(val2, Math.Max(val, num));
			if (bAE && columnIndex == 0)
			{
				num = 0;
			}
			if (bAe && rowIndex == 0)
			{
				num = 0;
			}
			bAC.method_273(columnIndex, rowIndex, int_2, num, bool_0: true);
			if (m_framework.awo != null && !bAH)
			{
				Setting setting = m_framework.awo.method_2(method_64());
				if (setting != null && setting.method_256() == rowIndex)
				{
					m_framework.awo.method_1(method_64());
				}
			}
		}
		bAC.method_267(bool_0: true);
	}

	public void GetSelectedLeftRightTopBottomIndices(out int leftSelectedHoriz, out int rightSelectedHoriz, out int topSelectedVert, out int bottomSelectedVert)
	{
		leftSelectedHoriz = int.MaxValue;
		rightSelectedHoriz = int.MinValue;
		topSelectedVert = int.MaxValue;
		bottomSelectedVert = int.MinValue;
		foreach (Point item in HorizVertIndexPerUserSelectedCell)
		{
			leftSelectedHoriz = Math.Min(leftSelectedHoriz, item.X);
			rightSelectedHoriz = Math.Max(rightSelectedHoriz, item.X);
			topSelectedVert = Math.Min(topSelectedVert, item.Y);
			bottomSelectedVert = Math.Max(bottomSelectedVert, item.Y);
		}
	}

	public void MoveSelectionLeft(Table tableForCompare)
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == 0)
		{
			return;
		}
		int y = UserCurrentCellHorizVertIndex.Y;
		UserCurrentCellHorizVertIndex = new Point(leftSelectedHoriz - 1, y);
		List<Point> list = new List<Point>();
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			for (int j = leftSelectedHoriz - 1; j < rightSelectedHoriz; j++)
			{
				list.Add(new Point(j, i));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void MoveSelectionRight(Table tableForCompare)
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG || tableForCompare == null) ? this : tableForCompare);
		if (rightSelectedHoriz == table.HorizAxisCount() - 1)
		{
			return;
		}
		int y = UserCurrentCellHorizVertIndex.Y;
		UserCurrentCellHorizVertIndex = new Point(rightSelectedHoriz + 1, y);
		List<Point> list = new List<Point>();
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			for (int j = leftSelectedHoriz + 1; j <= rightSelectedHoriz + 1; j++)
			{
				list.Add(new Point(j, i));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void MoveSelectionUp(Table tableForCompare)
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == 0)
		{
			return;
		}
		int x = UserCurrentCellHorizVertIndex.X;
		UserCurrentCellHorizVertIndex = new Point(x, topSelectedVert - 1);
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert - 1; j < bottomSelectedVert; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void MoveSelectionDown(Table tableForCompare)
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG || tableForCompare == null) ? this : tableForCompare);
		if (bottomSelectedVert == table.VertAxisCount() - 1)
		{
			return;
		}
		int x = UserCurrentCellHorizVertIndex.X;
		UserCurrentCellHorizVertIndex = new Point(x, bottomSelectedVert + 1);
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert + 1; j <= bottomSelectedVert + 1; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void IncreaseSelectionSizeOnLeft(Table tableForCompare)
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == 0)
		{
			return;
		}
		int y = UserCurrentCellHorizVertIndex.Y;
		UserCurrentCellHorizVertIndex = new Point(leftSelectedHoriz - 1, y);
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz - 1; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void IncreaseSelectionSizeOnRight(Table tableForCompare)
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG || tableForCompare == null) ? this : tableForCompare);
		if (rightSelectedHoriz == table.HorizAxisCount() - 1)
		{
			return;
		}
		int y = UserCurrentCellHorizVertIndex.Y;
		UserCurrentCellHorizVertIndex = new Point(rightSelectedHoriz + 1, y);
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz + 1; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void IncreaseSelectionSizeOnTop(Table tableForCompare)
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == 0)
		{
			return;
		}
		int x = UserCurrentCellHorizVertIndex.X;
		UserCurrentCellHorizVertIndex = new Point(x, topSelectedVert - 1);
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert - 1; j <= bottomSelectedVert; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void IncreaseSelectionSizeOnBottom(Table tableForCompare)
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG || tableForCompare == null) ? this : tableForCompare);
		if (bottomSelectedVert == table.VertAxisCount() - 1)
		{
			return;
		}
		int x = UserCurrentCellHorizVertIndex.X;
		UserCurrentCellHorizVertIndex = new Point(x, bottomSelectedVert + 1);
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert + 1; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void DecreaseSelectionSizeOnLeft()
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == rightSelectedHoriz)
		{
			return;
		}
		int x = UserCurrentCellHorizVertIndex.X;
		int y = UserCurrentCellHorizVertIndex.Y;
		if (x == leftSelectedHoriz)
		{
			UserCurrentCellHorizVertIndex = new Point(x + 1, y);
		}
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz + 1; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void DecreaseSelectionSizeOnRight()
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == rightSelectedHoriz)
		{
			return;
		}
		int x = UserCurrentCellHorizVertIndex.X;
		int y = UserCurrentCellHorizVertIndex.Y;
		if (x == rightSelectedHoriz)
		{
			UserCurrentCellHorizVertIndex = new Point(x - 1, y);
		}
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz - 1; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void DecreaseSelectionSizeOnTop()
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			return;
		}
		int x = UserCurrentCellHorizVertIndex.X;
		int y = UserCurrentCellHorizVertIndex.Y;
		if (y == topSelectedVert)
		{
			UserCurrentCellHorizVertIndex = new Point(x, y + 1);
		}
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert + 1; j <= bottomSelectedVert; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	public void DecreaseSelectionSizeOnBottom()
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			return;
		}
		int x = UserCurrentCellHorizVertIndex.X;
		int y = UserCurrentCellHorizVertIndex.Y;
		if (y == bottomSelectedVert)
		{
			UserCurrentCellHorizVertIndex = new Point(x, y - 1);
		}
		List<Point> list = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert - 1; j++)
			{
				list.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = list;
	}

	internal void method_294(Table table_0, List<Class104.Struct10>[,,] list_0)
	{
		int num = VertAxisCount();
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == 0 || leftSelectedHoriz != rightSelectedHoriz)
		{
			return;
		}
		MoveSelectionLeft(table_0);
		int num2 = 0;
		if (SlicesEnabled())
		{
			num2 = UserSliceIndex;
		}
		int num3 = bAC.method_231();
		Class280 @class = Form23.smethod_95();
		@class?.method_2(bAC.method_64());
		bAC.method_268();
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			if (bAH)
			{
				if (bAg)
				{
					int int_ = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(num - 1 - i, leftSelectedHoriz, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, leftSelectedHoriz, num - 1 - i, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(leftSelectedHoriz - 1) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(num - 1 - i) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
					if (bAE && num - 1 - i == 0)
					{
						int_ = 0;
					}
					if (bAe && leftSelectedHoriz - 1 == 0)
					{
						int_ = 0;
					}
					bAC.method_273(num - 1 - i, leftSelectedHoriz - 1, num2, int_, bool_0: true);
					if (list_0 != null)
					{
						list_0[num2, i, leftSelectedHoriz - 1].Clear();
					}
				}
				else
				{
					int int_2 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(i, leftSelectedHoriz, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, leftSelectedHoriz, i, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(leftSelectedHoriz - 1) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(i) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
					if (bAE && i == 0)
					{
						int_2 = 0;
					}
					if (bAe && leftSelectedHoriz - 1 == 0)
					{
						int_2 = 0;
					}
					bAC.method_273(i, leftSelectedHoriz - 1, num2, int_2, bool_0: true);
					if (list_0 != null)
					{
						list_0[num2, i, leftSelectedHoriz - 1].Clear();
					}
				}
				continue;
			}
			if (bAg)
			{
				int int_3 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(leftSelectedHoriz, num - 1 - i, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, leftSelectedHoriz, num - 1 - i, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(leftSelectedHoriz - 1) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(num - 1 - i) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
				if (bAE && leftSelectedHoriz - 1 == 0)
				{
					int_3 = 0;
				}
				if (bAe && num - 1 - i == 0)
				{
					int_3 = 0;
				}
				bAC.method_273(leftSelectedHoriz - 1, num - 1 - i, num2, int_3, bool_0: true);
				if (list_0 != null)
				{
					list_0[num2, i, leftSelectedHoriz - 1].Clear();
				}
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.method_2(method_64());
					if (setting != null && setting.method_256() == num - 1 - i)
					{
						m_framework.awo.method_1(method_64());
					}
				}
				continue;
			}
			int int_4 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(leftSelectedHoriz, i, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, leftSelectedHoriz, i, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(leftSelectedHoriz - 1) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(i) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
			if (bAE && leftSelectedHoriz - 1 == 0)
			{
				int_4 = 0;
			}
			if (bAe && i == 0)
			{
				int_4 = 0;
			}
			bAC.method_273(leftSelectedHoriz - 1, i, num2, int_4, bool_0: true);
			if (list_0 != null)
			{
				list_0[num2, i, leftSelectedHoriz - 1].Clear();
			}
			if (m_framework.awo != null)
			{
				Setting setting2 = m_framework.awo.method_2(method_64());
				if (setting2 != null && setting2.method_256() == i)
				{
					m_framework.awo.method_1(method_64());
				}
			}
		}
		bAC.method_267(bool_0: true);
		@class?.method_4();
		Form23.smethod_74(bAC.method_64());
	}

	internal void method_295(Table table_0, List<Class104.Struct10>[,,] list_0)
	{
		int num = VertAxisCount();
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (rightSelectedHoriz == HorizAxisCount() - 1 || leftSelectedHoriz != rightSelectedHoriz)
		{
			return;
		}
		MoveSelectionRight(table_0);
		int num2 = 0;
		if (SlicesEnabled())
		{
			num2 = UserSliceIndex;
		}
		int num3 = bAC.method_231();
		Class280 @class = Form23.smethod_95();
		@class?.method_2(bAC.method_64());
		bAC.method_268();
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			if (bAH)
			{
				if (bAg)
				{
					int int_ = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(num - 1 - i, rightSelectedHoriz, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, rightSelectedHoriz, num - 1 - i, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(rightSelectedHoriz + 1) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(num - 1 - i) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
					if (bAE && num - 1 - i == 0)
					{
						int_ = 0;
					}
					if (bAe && rightSelectedHoriz + 1 == 0)
					{
						int_ = 0;
					}
					bAC.method_273(num - 1 - i, rightSelectedHoriz + 1, num2, int_, bool_0: true);
					if (list_0 != null)
					{
						list_0[num2, i, rightSelectedHoriz + 1].Clear();
					}
				}
				else
				{
					int int_2 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(i, rightSelectedHoriz, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, rightSelectedHoriz, i, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(rightSelectedHoriz + 1) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(i) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
					if (bAE && i == 0)
					{
						int_2 = 0;
					}
					if (bAe && rightSelectedHoriz + 1 == 0)
					{
						int_2 = 0;
					}
					bAC.method_273(i, rightSelectedHoriz + 1, num2, int_2, bool_0: true);
					if (list_0 != null)
					{
						list_0[num2, i, rightSelectedHoriz + 1].Clear();
					}
				}
				continue;
			}
			if (bAg)
			{
				int int_3 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(rightSelectedHoriz, num - 1 - i, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, rightSelectedHoriz, num - 1 - i, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(rightSelectedHoriz + 1) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(num - 1 - i) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
				if (bAE && rightSelectedHoriz + 1 == 0)
				{
					int_3 = 0;
				}
				if (bAe && num - 1 - i == 0)
				{
					int_3 = 0;
				}
				bAC.method_273(rightSelectedHoriz + 1, num - 1 - i, num2, int_3, bool_0: true);
				if (list_0 != null)
				{
					list_0[num2, i, rightSelectedHoriz + 1].Clear();
				}
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.method_2(method_64());
					if (setting != null && setting.method_256() == num - 1 - i)
					{
						m_framework.awo.method_1(method_64());
					}
				}
				continue;
			}
			int int_4 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(rightSelectedHoriz, i, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, rightSelectedHoriz, i, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(rightSelectedHoriz + 1) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(i) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
			if (bAE && rightSelectedHoriz + 1 == 0)
			{
				int_4 = 0;
			}
			if (bAe && i == 0)
			{
				int_4 = 0;
			}
			bAC.method_273(rightSelectedHoriz + 1, i, num2, int_4, bool_0: true);
			if (list_0 != null)
			{
				list_0[num2, i, rightSelectedHoriz + 1].Clear();
			}
			if (m_framework.awo != null)
			{
				Setting setting2 = m_framework.awo.method_2(method_64());
				if (setting2 != null && setting2.method_256() == i)
				{
					m_framework.awo.method_1(method_64());
				}
			}
		}
		bAC.method_267(bool_0: true);
		@class?.method_4();
		Form23.smethod_74(bAC.method_64());
	}

	internal void method_296(Table table_0, List<Class104.Struct10>[,,] list_0)
	{
		int num = VertAxisCount();
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == 0 || topSelectedVert != bottomSelectedVert)
		{
			return;
		}
		MoveSelectionUp(table_0);
		int num2 = 0;
		if (SlicesEnabled())
		{
			num2 = UserSliceIndex;
		}
		int num3 = bAC.method_231();
		Class280 @class = Form23.smethod_95();
		@class?.method_2(bAC.method_64());
		bAC.method_268();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			if (bAH)
			{
				if (bAg)
				{
					int int_ = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(num - 1 - topSelectedVert, i, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, i, num - 1 - topSelectedVert, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(i) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(num - 1 - (topSelectedVert - 1)) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
					if (bAE && num - 1 - (topSelectedVert - 1) == 0)
					{
						int_ = 0;
					}
					if (bAe && i == 0)
					{
						int_ = 0;
					}
					bAC.method_273(num - 1 - (topSelectedVert - 1), i, num2, int_, bool_0: true);
					if (list_0 != null)
					{
						list_0[num2, topSelectedVert - 1, i].Clear();
					}
				}
				else
				{
					int int_2 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(topSelectedVert, i, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, i, topSelectedVert, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(i) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(topSelectedVert - 1) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
					if (bAE && topSelectedVert - 1 == 0)
					{
						int_2 = 0;
					}
					if (bAe && i == 0)
					{
						int_2 = 0;
					}
					bAC.method_273(topSelectedVert - 1, i, num2, int_2, bool_0: true);
					if (list_0 != null)
					{
						list_0[num2, topSelectedVert - 1, i].Clear();
					}
				}
				continue;
			}
			if (bAg)
			{
				int int_3 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(i, num - 1 - topSelectedVert, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, i, num - 1 - topSelectedVert, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(i) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(num - 1 - (topSelectedVert - 1)) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
				if (bAE && i == 0)
				{
					int_3 = 0;
				}
				if (bAe && num - 1 - (topSelectedVert - 1) == 0)
				{
					int_3 = 0;
				}
				bAC.method_273(i, num - 1 - (topSelectedVert - 1), num2, int_3, bool_0: true);
				if (list_0 != null)
				{
					list_0[num2, topSelectedVert - 1, i].Clear();
				}
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.method_2(method_64());
					if (setting != null && setting.method_256() == num - 1 - (topSelectedVert - 1))
					{
						m_framework.awo.method_1(method_64());
					}
				}
				continue;
			}
			int int_4 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(i, topSelectedVert, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, i, topSelectedVert, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(i) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(topSelectedVert - 1) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
			if (bAE && i == 0)
			{
				int_4 = 0;
			}
			if (bAe && topSelectedVert - 1 == 0)
			{
				int_4 = 0;
			}
			bAC.method_273(i, topSelectedVert - 1, num2, int_4, bool_0: true);
			if (list_0 != null)
			{
				list_0[num2, topSelectedVert - 1, i].Clear();
			}
			if (m_framework.awo != null)
			{
				Setting setting2 = m_framework.awo.method_2(method_64());
				if (setting2 != null && setting2.method_256() == topSelectedVert - 1)
				{
					m_framework.awo.method_1(method_64());
				}
			}
		}
		bAC.method_267(bool_0: true);
		@class?.method_4();
		Form23.smethod_74(bAC.method_64());
	}

	internal void method_297(Table table_0, List<Class104.Struct10>[,,] list_0)
	{
		int num = VertAxisCount();
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (bottomSelectedVert == VertAxisCount() - 1 || topSelectedVert != bottomSelectedVert)
		{
			return;
		}
		MoveSelectionDown(table_0);
		int num2 = 0;
		if (SlicesEnabled())
		{
			num2 = UserSliceIndex;
		}
		int num3 = bAC.method_231();
		Class280 @class = Form23.smethod_95();
		@class?.method_2(bAC.method_64());
		bAC.method_268();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			if (bAH)
			{
				if (bAg)
				{
					int int_ = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(num - 1 - bottomSelectedVert, i, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, i, num - 1 - bottomSelectedVert, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(i) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(num - 1 - (bottomSelectedVert + 1)) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
					if (bAE && num - 1 - (bottomSelectedVert + 1) == 0)
					{
						int_ = 0;
					}
					if (bAe && i == 0)
					{
						int_ = 0;
					}
					bAC.method_273(num - 1 - (bottomSelectedVert + 1), i, num2, int_, bool_0: true);
					if (list_0 != null)
					{
						list_0[num2, bottomSelectedVert + 1, i].Clear();
					}
				}
				else
				{
					int int_2 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(bottomSelectedVert, i, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, i, bottomSelectedVert, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(i) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(bottomSelectedVert + 1) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
					if (bAE && bottomSelectedVert + 1 == 0)
					{
						int_2 = 0;
					}
					if (bAe && i == 0)
					{
						int_2 = 0;
					}
					bAC.method_273(bottomSelectedVert + 1, i, num2, int_2, bool_0: true);
					if (list_0 != null)
					{
						list_0[num2, bottomSelectedVert + 1, i].Clear();
					}
				}
				continue;
			}
			if (bAg)
			{
				int int_3 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(i, num - 1 - bottomSelectedVert, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, i, num - 1 - bottomSelectedVert, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(i) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(num - 1 - (bottomSelectedVert + 1)) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
				if (bAE && i == 0)
				{
					int_3 = 0;
				}
				if (bAe && num - 1 - (bottomSelectedVert + 1) == 0)
				{
					int_3 = 0;
				}
				bAC.method_273(i, num - 1 - (bottomSelectedVert + 1), num2, int_3, bool_0: true);
				if (list_0 != null)
				{
					list_0[num2, bottomSelectedVert + 1, i].Clear();
				}
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.method_2(method_64());
					if (setting != null && setting.method_256() == num - 1 - (bottomSelectedVert + 1))
					{
						m_framework.awo.method_1(method_64());
					}
				}
				continue;
			}
			int int_4 = ((Form23.enum60_0 != Form23.Enum60.BpF || table_0 == null) ? bAC.method_257(i, bottomSelectedVert, num2) : Class233.smethod_26(GetCellDifferenceDisplayValue(table_0, i, bottomSelectedVert, num2, out var _, out var _) + Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.method_89().method_258(i) : 0, VertAxisEnabled() ? VertAxis.method_89().method_258(bottomSelectedVert + 1) : 0, SlicesEnabled() ? SliceAxis.method_89().method_258(num2) : 0), num3), num3));
			if (bAE && i == 0)
			{
				int_4 = 0;
			}
			if (bAe && bottomSelectedVert + 1 == 0)
			{
				int_4 = 0;
			}
			bAC.method_273(i, bottomSelectedVert + 1, num2, int_4, bool_0: true);
			if (list_0 != null)
			{
				list_0[num2, bottomSelectedVert + 1, i].Clear();
			}
			if (m_framework.awo != null)
			{
				Setting setting2 = m_framework.awo.method_2(method_64());
				if (setting2 != null && setting2.method_256() == bottomSelectedVert + 1)
				{
					m_framework.awo.method_1(method_64());
				}
			}
		}
		bAC.method_267(bool_0: true);
		@class?.method_4();
		Form23.smethod_74(bAC.method_64());
	}

	public double GetCellDifferenceDisplayValue(Table tableForCompare, int horizIndex, int vertIndex, int sliceIndex, out int currentTableRawCellValue, out int compareTableRawCellValue)
	{
		if (tableForCompare != null)
		{
			int horizRawValue = 0;
			if (HorizAxisEnabled())
			{
				horizRawValue = HorizAxis.method_89().method_258(horizIndex);
			}
			int vertRawValue = 0;
			if (VertAxisEnabled())
			{
				vertRawValue = VertAxis.method_89().method_258(vertIndex);
			}
			int sliceRawValue = 0;
			if (SlicesEnabled())
			{
				sliceRawValue = SliceAxis.method_89().method_258(sliceIndex);
			}
			currentTableRawCellValue = GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue);
			compareTableRawCellValue = tableForCompare.GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue);
			int int_ = TableDataSetting.method_231();
			double num = Class233.smethod_28(currentTableRawCellValue, int_);
			double num2 = Class233.smethod_28(compareTableRawCellValue, int_);
			return num - num2;
		}
		currentTableRawCellValue = 0;
		compareTableRawCellValue = 0;
		return 0.0;
	}

	public double GetCellDifferenceDisplayValue(double[,,] cellsPerSliceRowColumnForCompare, int[] columnAxisValuesForCompare, int[] rowAxisValuesForCompare, int[] sliceAxisValuesForCompare, int horizIndex, int vertIndex, int sliceIndex, int vertCount)
	{
		if (cellsPerSliceRowColumnForCompare != null)
		{
			int horizRawValue = 0;
			if (HorizAxisEnabled())
			{
				horizRawValue = HorizAxis.method_89().method_258(horizIndex);
			}
			int vertRawValue = 0;
			if (VertAxisEnabled())
			{
				vertRawValue = ((!bAg) ? VertAxis.method_89().method_258(vertIndex) : VertAxis.method_89().method_258(vertCount - 1 - vertIndex));
			}
			int num = 0;
			if (SlicesEnabled())
			{
				num = SliceAxis.method_89().method_258(sliceIndex);
			}
			int interpolatedTableDataRawValue = GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, num);
			GetColumnIndexAndRowIndex(horizIndex, vertIndex, out var columnIndex, out var rowIndex);
			int columnLookupValue = 0;
			if (ColumnsEnabled())
			{
				columnLookupValue = ColumnAxis.method_89().method_258(columnIndex);
			}
			int rowLookupValue = 0;
			if (RowsEnabled())
			{
				rowLookupValue = RowAxis.method_89().method_258(rowIndex);
			}
			int int_ = (int)GetInterpolatedValue(cellsPerSliceRowColumnForCompare, columnAxisValuesForCompare, rowAxisValuesForCompare, sliceAxisValuesForCompare, columnLookupValue, rowLookupValue, num);
			int int_2 = TableDataSetting.method_231();
			double num2 = Class233.smethod_28(interpolatedTableDataRawValue, int_2);
			double num3 = Class233.smethod_28(int_, int_2);
			return num2 - num3;
		}
		return 0.0;
	}

	public void CopyCellValuesToClipboard(Table tableForCompare)
	{
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		int num = 0;
		if (SlicesEnabled())
		{
			num = UserSliceIndex;
		}
		int num2 = VertAxisCount();
		int num3 = bAC.method_231();
		string text = string.Empty;
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			for (int j = leftSelectedHoriz; j <= rightSelectedHoriz; j++)
			{
				int num4 = 0;
				if (tableForCompare != null)
				{
					num4 = ((!bAg) ? Class233.smethod_26(GetCellDifferenceDisplayValue(tableForCompare, j, i, num, out var _, out var _), num3) : Class233.smethod_26(GetCellDifferenceDisplayValue(tableForCompare, j, num2 - 1 - i, num, out var _, out var _), num3));
				}
				int int_;
				if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
				{
					int_ = num4;
				}
				else
				{
					GetColumnIndexAndRowIndex(j, i, out var columnIndex, out var rowIndex);
					int_ = bAC.method_257(columnIndex, rowIndex, num);
				}
				text += Class233.smethod_29(int_, num3);
				if (j != rightSelectedHoriz)
				{
					text += Class333.alU();
				}
			}
			if (i != bottomSelectedVert)
			{
				text += Class333.smethod_570();
			}
		}
		try
		{
			if (!string.IsNullOrEmpty(text))
			{
				Clipboard.SetText(text);
			}
		}
		catch
		{
		}
	}

	internal void method_298(Table table_0, List<Class104.Struct10>[,,] list_0)
	{
		string text = null;
		int num = 0;
		int num2 = 0;
		try
		{
			if (Clipboard.ContainsText())
			{
				text = Clipboard.GetText();
			}
			if (!text.EndsWith(Class333.BiJ()) && !text.EndsWith(Class333.smethod_537()))
			{
				if (text.EndsWith(Class333.smethod_2225()) || text.EndsWith(Class333.smethod_570()))
				{
					text = text.Substring(0, text.Length - 1);
				}
			}
			else
			{
				text = text.Substring(0, text.Length - 2);
			}
			num = text.Split('\n').Length;
			num2 = 0;
			for (int i = 0; i < num; i++)
			{
				int num3 = text.Split('\n')[i].Split('\t').Length;
				if (i == 0)
				{
					num2 = num3;
				}
				else if (num3 != num2)
				{
					throw new Exception();
				}
			}
		}
		catch
		{
			text = null;
		}
		if (text == null)
		{
			return;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(bAC.method_64());
		bAC.method_268();
		int num4 = bAC.method_231();
		int val = method_228();
		int val2 = method_229();
		int num5 = 0;
		if (SlicesEnabled())
		{
			num5 = UserSliceIndex;
		}
		int val3 = HorizAxisCount();
		int num6 = VertAxisCount();
		int num7 = int.MaxValue;
		int num8 = int.MaxValue;
		foreach (Point item in HorizVertIndexPerUserSelectedCell)
		{
			num7 = Math.Min(num7, item.X);
			num8 = Math.Min(num8, item.Y);
		}
		int num9 = Math.Min(val3, num7 + num2) - 1;
		int num10 = Math.Min(num6, num8 + num) - 1;
		for (int j = num8; j <= num10; j++)
		{
			for (int k = num7; k <= num9; k++)
			{
				string text2 = text.Split('\n')[j - num8].Split('\t')[k - num7];
				if (text2.EndsWith(Class333.smethod_2225()))
				{
					text2 = text2.Substring(0, text2.Length - 1);
				}
				try
				{
					int val4;
					if (Form23.enum60_0 == Form23.Enum60.BpF && table_0 != null)
					{
						int horizRawValue = ((HorizAxis != null && HorizAxis.method_89() != null) ? HorizAxis.method_89().method_258(k) : 0);
						int vertRawValue = ((VertAxis != null && VertAxis.method_89() != null) ? ((!bAg) ? VertAxis.method_89().method_258(j) : VertAxis.method_89().method_258(num6 - 1 - j)) : 0);
						int sliceRawValue = ((SliceAxis != null && SliceAxis.method_89() != null) ? SliceAxis.method_89().method_258(num5) : 0);
						double num11 = Class233.smethod_28(table_0.GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue), num4);
						double num12 = double.Parse(text2, NumberStyles.Any, CultureInfo.CurrentCulture);
						val4 = Class233.smethod_26(num11 + num12, num4);
					}
					else
					{
						val4 = Class233.smethod_25(text2, num4);
					}
					val4 = Math.Min(Math.Max(val4, val), val2);
					GetColumnIndexAndRowIndex(k, j, out var columnIndex, out var rowIndex);
					bAC.method_273(columnIndex, rowIndex, num5, val4, bool_0: true);
					if (list_0 != null)
					{
						list_0[num5, j, k].Clear();
					}
					if (m_framework.awo != null && !bAH)
					{
						Setting setting = m_framework.awo.method_2(method_64());
						if (setting != null && setting.method_256() == rowIndex)
						{
							m_framework.awo.method_1(method_64());
						}
					}
				}
				catch
				{
				}
			}
		}
		bAC.method_267(bool_0: true);
		@class?.method_4();
		Form23.smethod_74(bAC.method_64());
	}

	internal void method_299()
	{
		try
		{
			string text = string.Empty;
			TableAxis[] array = new TableAxis[3] { SliceAxis, RowAxis, ColumnAxis };
			int num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					TableAxis tableAxis = array[num];
					if (tableAxis != null && tableAxis.method_73())
					{
						text = ((tableAxis.method_90() == null) ? (text + Class333.Bij() + (int)tableAxis.method_71() + Class333.BiK()) : (text + Class333.Bij() + (int)tableAxis.method_71() + Class333.smethod_571() + tableAxis.method_90().method_256() + Class333.smethod_570()));
						text = ((tableAxis.method_91() == null) ? (text + Class333.Bik() + (int)tableAxis.method_71() + Class333.BiL()) : (text + Class333.Bik() + (int)tableAxis.method_71() + Class333.smethod_571() + tableAxis.method_91().method_256() + Class333.smethod_570()));
						if (tableAxis.method_89() == null)
						{
							break;
						}
						text = text + Class333.Bil() + (int)tableAxis.method_71() + Class333.smethod_134();
						int num2 = tableAxis.method_74();
						for (int i = 0; i < num2; i++)
						{
							text = text + Class333.alU() + tableAxis.method_89().method_258(i);
						}
						text += Class333.smethod_570();
						text += Class333.smethod_570();
					}
					num++;
					continue;
				}
				text = text + Class333.BiM() + bAC.method_231() + Class333.smethod_1812();
				text += Class333.Bim();
				int num3 = SliceCount();
				int num4 = RowCount();
				int num5 = ColumnCount();
				for (int j = 0; j < num3; j++)
				{
					for (int k = 0; k < num4; k++)
					{
						for (int l = 0; l < num5; l++)
						{
							text += bAC.method_257(l, k, j);
							if (l < num5 - 1)
							{
								text += Class333.alU();
							}
						}
						text += Class333.smethod_570();
					}
					text += Class333.smethod_570();
				}
				if (!string.IsNullOrEmpty(text))
				{
					Clipboard.SetText(text);
				}
				break;
			}
		}
		catch
		{
		}
	}

	internal Class274 method_300()
	{
		try
		{
			if (Clipboard.ContainsText())
			{
				string text = Clipboard.GetText();
				Class274 @class = new Class274();
				int num = text.IndexOf(Class333.BiM());
				if (num != -1)
				{
					int num2 = num + Class333.BiM().Length;
					int length = text.IndexOf(Class333.smethod_570(), num2) - num2;
					@class.bbk = (UnitType)int.Parse(text.Substring(num2, length));
					int num3 = 0;
					do
					{
						int num4 = text.IndexOf(Class333.Bij(), num3);
						if (num4 == -1)
						{
							num3 = -1;
							continue;
						}
						int key = int.Parse(text.Substring(num4 + Class333.Bij().Length, 1));
						int num5 = num4 + Class333.Bij().Length + 3;
						int length2 = text.IndexOf(Class333.smethod_570(), num5) - num5;
						int value = int.Parse(text.Substring(num5, length2));
						@class.bbJ[(AxisType)key] = value;
						num3 = num4 + Class333.Bij().Length;
					}
					while (num3 != -1);
					num3 = 0;
					do
					{
						int num6 = text.IndexOf(Class333.Bik(), num3);
						if (num6 == -1)
						{
							num3 = -1;
							continue;
						}
						int key2 = int.Parse(text.Substring(num6 + Class333.Bik().Length, 1));
						int value2 = int.Parse(text.Substring(num6 + Class333.Bik().Length + 3, 1));
						@class.bbj[(AxisType)key2] = (AxisBehaviour)value2;
						num3 = num6 + Class333.Bik().Length;
					}
					while (num3 != -1);
					num3 = 0;
					do
					{
						int num7 = text.IndexOf(Class333.Bil(), num3);
						if (num7 == -1)
						{
							num3 = -1;
							continue;
						}
						int key3 = int.Parse(text.Substring(num7 + Class333.Bil().Length, 1));
						int num8 = num7 + Class333.Bil().Length + 3;
						int length3 = text.IndexOf(Class333.smethod_570(), num8) - num8;
						string[] array = text.Substring(num8, length3).Split(Class333.alU());
						@class.bbK[(AxisType)key3] = new List<int>();
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							int item = int.Parse(array2[i]);
							@class.bbK[(AxisType)key3].Add(item);
						}
						num3 = num7 + Class333.Bil().Length;
					}
					while (num3 != -1);
					int num9 = text.IndexOf(Class333.Bim());
					if (num9 != -1)
					{
						string text2 = text.Substring(num9 + Class333.Bim().Length);
						@class.bbL = new List<List<List<int>>>();
						int num10 = 0;
						int num11 = 0;
						int num12 = 0;
						num3 = 0;
						do
						{
							int num13 = text2.IndexOf(Class333.smethod_570(), num3);
							if (num13 == -1)
							{
								num3 = -1;
								continue;
							}
							if (@class.bbL.Count == num10)
							{
								@class.bbL.Add(new List<List<int>>());
							}
							int num14 = num13 - num3;
							if (num14 != 0)
							{
								if (@class.bbL[num10].Count == num11)
								{
									@class.bbL[num10].Add(new List<int>());
								}
								string[] array2 = text2.Substring(num3, num14).Split(Class333.alU());
								for (int i = 0; i < array2.Length; i++)
								{
									int item2 = int.Parse(array2[i]);
									@class.bbL[num10][num11].Add(item2);
									num12++;
								}
								num11++;
								num12 = 0;
							}
							else
							{
								num10++;
								num11 = 0;
								num12 = 0;
							}
							num3 = num13 + 1;
						}
						while (num3 != -1);
						return @class;
					}
				}
			}
		}
		catch
		{
		}
		return null;
	}

	internal bool method_301(Class274 class274_0, out string string_0)
	{
		string_0 = null;
		try
		{
			if (class274_0.bbk != (UnitType)bAC.method_231())
			{
				string_0 = Class333.BiN();
				return false;
			}
			TableAxis[] array = new TableAxis[3] { SliceAxis, RowAxis, ColumnAxis };
			foreach (AxisType key in class274_0.bbK.Keys)
			{
				if (array[(int)key] != null && array[(int)key].method_89() != null)
				{
					if (class274_0.bbK[key].Count <= bAC.method_242()[(int)key])
					{
						if (array[(int)key].method_84() == 0)
						{
							continue;
						}
						for (int i = 0; i < class274_0.bbK[key].Count; i++)
						{
							if (class274_0.bbK[key][i] != array[(int)key].method_89().method_258(i))
							{
								string_0 = Class333.Bio();
								return false;
							}
						}
						continue;
					}
					string_0 = Class333.BiO();
					return false;
				}
				string_0 = Class333.Bin();
				return false;
			}
			foreach (AxisType key2 in class274_0.bbJ.Keys)
			{
				if (array[(int)key2] != null && array[(int)key2].method_90() != null)
				{
					if (array[(int)key2].method_86() != 0 && class274_0.bbJ[key2] != array[(int)key2].method_90().method_256())
					{
						string_0 = Class333.BiP();
						return false;
					}
					continue;
				}
				string_0 = Class333.Bin();
				return false;
			}
			if (class274_0.bbL.Count != 0 && class274_0.bbL[0].Count != 0 && class274_0.bbL[0][0].Count != 0)
			{
				if (class274_0.bbL.Count <= bAC.method_242()[0] && class274_0.bbL[0].Count <= bAC.method_242()[1] && class274_0.bbL[0][0].Count <= bAC.method_242()[2])
				{
					int num = 0;
					while (true)
					{
						if (num < class274_0.bbL.Count)
						{
							if (class274_0.bbL[num].Count != class274_0.bbL[0].Count)
							{
								break;
							}
							for (int j = 0; j < class274_0.bbL[num].Count; j++)
							{
								if (class274_0.bbL[num][j].Count != class274_0.bbL[0][0].Count)
								{
									string_0 = Class333.Biq();
									return false;
								}
							}
							num++;
							continue;
						}
						return true;
					}
					string_0 = Class333.Biq();
					return false;
				}
				string_0 = Class333.BiQ();
				return false;
			}
			string_0 = Class333.Bip();
			return false;
		}
		catch
		{
			string_0 = Class333.Biq();
			return false;
		}
	}

	internal void method_302(Class274 class274_0)
	{
		if (class274_0 == null)
		{
			return;
		}
		TableAxis[] array = new TableAxis[3] { SliceAxis, RowAxis, ColumnAxis };
		foreach (TableAxis tableAxis in array)
		{
			if (tableAxis == null)
			{
				continue;
			}
			if (class274_0.bbK.ContainsKey(tableAxis.method_71()) && class274_0.bbK[tableAxis.method_71()].Count != 0)
			{
				if (tableAxis.method_87() != null)
				{
					tableAxis.method_87().method_272(1, bool_0: true);
				}
				if (tableAxis.method_90() != null)
				{
					tableAxis.method_90().method_272(class274_0.bbJ[tableAxis.method_71()], bool_0: true);
				}
				if (tableAxis.method_91() != null)
				{
					tableAxis.method_91().method_272((int)class274_0.bbj[tableAxis.method_71()], bool_0: true);
				}
				if (tableAxis.method_89() != null && tableAxis.method_88() != null)
				{
					tableAxis.method_88().method_272(class274_0.bbK[tableAxis.method_71()].Count, bool_0: true);
					tableAxis.method_89().method_268();
					for (int j = 0; j < class274_0.bbK[tableAxis.method_71()].Count; j++)
					{
						tableAxis.method_89().method_274(j, class274_0.bbK[tableAxis.method_71()][j], bool_0: true);
					}
					tableAxis.method_89().method_267(bool_0: true);
				}
			}
			else if (tableAxis.method_87() != null)
			{
				tableAxis.method_87().method_272(0, bool_0: true);
			}
		}
		if (bAC == null)
		{
			return;
		}
		bAC.method_268();
		for (int k = 0; k < class274_0.bbL.Count; k++)
		{
			for (int l = 0; l < class274_0.bbL[k].Count; l++)
			{
				for (int m = 0; m < class274_0.bbL[k][l].Count; m++)
				{
					bAC.method_273(m, l, k, class274_0.bbL[k][l][m], bool_0: true);
				}
			}
		}
		bAC.method_267(bool_0: true);
	}

	public void LineariseTopToBottom(int horizIndex, int selectionStartVertIndex, int selectionEndVertIndex, Table tableForCompare)
	{
		int num = 0;
		if (SlicesEnabled())
		{
			num = UserSliceIndex;
		}
		int num2 = Math.Max(selectionStartVertIndex, selectionEndVertIndex);
		int num3 = Math.Min(selectionStartVertIndex, selectionEndVertIndex);
		int num4 = num2 - num3 + 1;
		int num5 = VertAxisCount();
		int num6 = num3;
		if (bAg)
		{
			num2 = num5 - 1 - num2;
			num6 = num5 - 1 - num3;
		}
		double num7;
		double num8;
		if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
		{
			num7 = GetCellDifferenceDisplayValue(tableForCompare, horizIndex, num6, num, out var currentTableRawCellValue, out var compareTableRawCellValue);
			num8 = GetCellDifferenceDisplayValue(tableForCompare, horizIndex, num2, num, out currentTableRawCellValue, out compareTableRawCellValue);
		}
		else if (bAH)
		{
			num7 = bAC.method_257(num6, horizIndex, num);
			num8 = bAC.method_257(num2, horizIndex, num);
		}
		else
		{
			num7 = bAC.method_257(horizIndex, num6, num);
			num8 = bAC.method_257(horizIndex, num2, num);
		}
		double num9 = num8 - num7;
		double num10 = VertAxis.method_89().method_258(num2) - VertAxis.method_89().method_258(num6);
		double num11 = num9 / num10;
		double num12 = ((Form23.enum60_0 != Form23.Enum60.BpF || tableForCompare == null) ? (num7 - Math.Round(num11 * (double)VertAxis.method_89().method_258(num6))) : (num7 - num11 * (double)VertAxis.method_89().method_258(num6)));
		int num13 = bAC.method_231();
		for (int i = 1; i < num4 - 1; i++)
		{
			int num14 = ((!bAg) ? (num3 + i) : (num5 - 1 - (num3 + i)));
			int num15 = VertAxis.method_89().method_258(num14);
			int int_;
			if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
			{
				GetCellDifferenceDisplayValue(tableForCompare, horizIndex, num14, num, out var _, out var compareTableRawCellValue2);
				double num16 = Class233.smethod_28(compareTableRawCellValue2, num13);
				double num17 = num11 * (double)num15 + num12;
				int_ = Class233.smethod_26(num16 + num17, num13);
			}
			else
			{
				int_ = (int)Math.Round(num11 * (double)num15 + num12);
			}
			if (bAH)
			{
				bAC.method_273(num14, horizIndex, num, int_, bool_0: true);
			}
			else
			{
				bAC.method_273(horizIndex, num14, num, int_, bool_0: true);
			}
			if (m_framework.awo != null && !bAH)
			{
				Setting setting = m_framework.awo.method_2(method_64());
				if (setting != null && setting.method_256() == num14)
				{
					m_framework.awo.method_1(method_64());
				}
			}
		}
	}

	public void LineariseLeftToRight(int vertIndex, int selectionStartHorizIndex, int selectionEndHorizIndex, Table tableForCompare, bool forHorizAxisInsertion)
	{
		int num = 0;
		if (SlicesEnabled())
		{
			num = UserSliceIndex;
		}
		int num2 = Math.Max(selectionStartHorizIndex, selectionEndHorizIndex);
		int num3 = Math.Min(selectionStartHorizIndex, selectionEndHorizIndex);
		int num4 = num2 - num3 + 1;
		int num5 = VertAxisCount();
		int num6 = ((!bAg) ? vertIndex : (num5 - 1 - vertIndex));
		double num7;
		double num8;
		if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
		{
			num7 = GetCellDifferenceDisplayValue(tableForCompare, num3, num6, num, out var currentTableRawCellValue, out var compareTableRawCellValue);
			num8 = GetCellDifferenceDisplayValue(tableForCompare, num2, num6, num, out currentTableRawCellValue, out compareTableRawCellValue);
		}
		else if (bAH)
		{
			num7 = bAC.method_257(num6, num3, num);
			num8 = bAC.method_257(num6, num2, num);
		}
		else
		{
			num7 = bAC.method_257(num3, num6, num);
			num8 = bAC.method_257(num2, num6, num);
		}
		double num9 = num8 - num7;
		double num10 = HorizAxis.method_89().method_258(num2) - HorizAxis.method_89().method_258(num3);
		double num11 = num9 / num10;
		double num12 = ((Form23.enum60_0 != Form23.Enum60.BpF || tableForCompare == null) ? (num7 - Math.Round(num11 * (double)HorizAxis.method_89().method_258(num3))) : (num7 - num11 * (double)HorizAxis.method_89().method_258(num3)));
		int num13 = bAC.method_231();
		for (int i = 1; i < num4 - 1; i++)
		{
			int num14 = HorizAxis.method_89().method_258(num3 + i);
			int int_;
			if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
			{
				GetCellDifferenceDisplayValue(tableForCompare, num3 + i, num6, num, out var _, out var compareTableRawCellValue2);
				double num15 = Class233.smethod_28(compareTableRawCellValue2, num13);
				double num16 = num11 * (double)num14 + num12;
				int_ = Class233.smethod_26(num15 + num16, num13);
			}
			else
			{
				int_ = (int)Math.Round(num11 * (double)num14 + num12);
			}
			if (bAH)
			{
				bAC.method_273(num6, num3 + i, num, int_, bool_0: true);
			}
			else
			{
				bAC.method_273(num3 + i, num6, num, int_, bool_0: true);
			}
			if (!forHorizAxisInsertion && m_framework.awo != null && !bAH)
			{
				Setting setting = m_framework.awo.method_2(method_64());
				if (setting != null && setting.method_256() == num6)
				{
					m_framework.awo.method_1(method_64());
				}
			}
		}
	}

	public void LineariseRange(int selectionStartHorizIndex, int selectionEndHorizIndex, int selectionStartVertIndex, int selectionEndVertIndex, Table tableForCompare)
	{
		int num = 0;
		if (SlicesEnabled())
		{
			num = UserSliceIndex;
		}
		int num2 = Math.Max(selectionStartHorizIndex, selectionEndHorizIndex);
		int num3 = Math.Min(selectionStartHorizIndex, selectionEndHorizIndex);
		int num4 = num2 - num3 + 1;
		int num5 = Math.Max(selectionStartVertIndex, selectionEndVertIndex);
		int num6 = Math.Min(selectionStartVertIndex, selectionEndVertIndex);
		int num7 = num5 - num6 + 1;
		int num8 = VertAxisCount();
		if (bAg)
		{
			num5 = num8 - 1 - num5;
		}
		int num9 = bAC.method_231();
		if (bAH)
		{
			for (int i = 0; i < num7; i++)
			{
				int num10 = ((!bAg) ? (num6 + i) : (num8 - 1 - (num6 + i)));
				double num11;
				double num12;
				if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
				{
					num11 = GetCellDifferenceDisplayValue(tableForCompare, num3, num10, num, out var currentTableRawCellValue, out var compareTableRawCellValue);
					num12 = GetCellDifferenceDisplayValue(tableForCompare, num2, num10, num, out currentTableRawCellValue, out compareTableRawCellValue);
				}
				else
				{
					num11 = bAC.method_257(num10, num3, num);
					num12 = bAC.method_257(num10, num2, num);
				}
				double num13 = num12 - num11;
				double num14 = bAD.method_89().method_258(num2) - bAD.method_89().method_258(num3);
				double num15 = num13 / num14;
				double num16 = ((Form23.enum60_0 != Form23.Enum60.BpF || tableForCompare == null) ? (num11 - Math.Round(num15 * (double)bAD.method_89().method_258(num3))) : (num11 - num15 * (double)bAD.method_89().method_258(num3)));
				for (int j = 1; j < num4 - 1; j++)
				{
					int num17 = bAD.method_89().method_258(num3 + j);
					int int_;
					if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
					{
						GetCellDifferenceDisplayValue(tableForCompare, num3 + j, num10, num, out var _, out var compareTableRawCellValue2);
						double num18 = Class233.smethod_28(compareTableRawCellValue2, num9);
						double num19 = num15 * (double)num17 + num16;
						int_ = Class233.smethod_26(num18 + num19, num9);
					}
					else
					{
						int_ = (int)Math.Round(num15 * (double)num17 + num16);
					}
					bAC.method_273(num10, num3 + j, num, int_, bool_0: true);
				}
			}
			for (int k = 0; k < num4; k++)
			{
				int num20 = num3 + k;
				int num21 = ((!bAg) ? num6 : (num8 - 1 - num6));
				double num22;
				double num23;
				if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
				{
					num22 = GetCellDifferenceDisplayValue(tableForCompare, num20, num21, num, out var currentTableRawCellValue3, out var compareTableRawCellValue3);
					num23 = GetCellDifferenceDisplayValue(tableForCompare, num20, num5, num, out currentTableRawCellValue3, out compareTableRawCellValue3);
				}
				else
				{
					num22 = bAC.method_257(num21, num20, num);
					num23 = bAC.method_257(num5, num20, num);
				}
				double num24 = num23 - num22;
				double num25 = bAc.method_89().method_258(num5) - bAc.method_89().method_258(num21);
				double num26 = num24 / num25;
				double num27 = ((Form23.enum60_0 != Form23.Enum60.BpF || tableForCompare == null) ? (num22 - Math.Round(num26 * (double)bAc.method_89().method_258(num21))) : (num22 - num26 * (double)bAc.method_89().method_258(num21)));
				for (int l = 1; l < num7 - 1; l++)
				{
					int num28 = ((!bAg) ? (num6 + l) : (num8 - 1 - (num6 + l)));
					int num29 = bAc.method_89().method_258(num28);
					int int_2;
					if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
					{
						GetCellDifferenceDisplayValue(tableForCompare, num20, num28, num, out var _, out var compareTableRawCellValue4);
						double num30 = Class233.smethod_28(compareTableRawCellValue4, num9);
						double num31 = num26 * (double)num29 + num27;
						int_2 = Class233.smethod_26(num30 + num31, num9);
					}
					else
					{
						int_2 = (int)Math.Round(num26 * (double)num29 + num27);
					}
					bAC.method_273(num28, num20, num, int_2, bool_0: true);
				}
			}
			return;
		}
		for (int m = 0; m < num7; m++)
		{
			int num32 = ((!bAg) ? (num6 + m) : (num8 - 1 - (num6 + m)));
			double num33;
			double num34;
			if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
			{
				num33 = GetCellDifferenceDisplayValue(tableForCompare, num3, num32, num, out var currentTableRawCellValue5, out var compareTableRawCellValue5);
				num34 = GetCellDifferenceDisplayValue(tableForCompare, num2, num32, num, out currentTableRawCellValue5, out compareTableRawCellValue5);
			}
			else
			{
				num33 = bAC.method_257(num3, num32, num);
				num34 = bAC.method_257(num2, num32, num);
			}
			double num35 = num34 - num33;
			double num36 = bAc.method_89().method_258(num2) - bAc.method_89().method_258(num3);
			double num37 = num35 / num36;
			double num38 = ((Form23.enum60_0 != Form23.Enum60.BpF || tableForCompare == null) ? (num33 - Math.Round(num37 * (double)bAc.method_89().method_258(num3))) : (num33 - num37 * (double)bAc.method_89().method_258(num3)));
			for (int n = 1; n < num4 - 1; n++)
			{
				int num39 = bAc.method_89().method_258(num3 + n);
				int int_3;
				if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
				{
					GetCellDifferenceDisplayValue(tableForCompare, num3 + n, num32, num, out var _, out var compareTableRawCellValue6);
					double num40 = Class233.smethod_28(compareTableRawCellValue6, num9);
					double num41 = num37 * (double)num39 + num38;
					int_3 = Class233.smethod_26(num40 + num41, num9);
				}
				else
				{
					int_3 = (int)Math.Round(num37 * (double)num39 + num38);
				}
				bAC.method_273(num3 + n, num32, num, int_3, bool_0: true);
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.method_2(method_64());
					if (setting != null && setting.method_256() == num32)
					{
						m_framework.awo.method_1(method_64());
					}
				}
			}
		}
		for (int num42 = 0; num42 < num4; num42++)
		{
			int num43 = num3 + num42;
			int num44 = ((!bAg) ? num6 : (num8 - 1 - num6));
			double num45;
			double num46;
			if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
			{
				num45 = GetCellDifferenceDisplayValue(tableForCompare, num43, num44, num, out var currentTableRawCellValue7, out var compareTableRawCellValue7);
				num46 = GetCellDifferenceDisplayValue(tableForCompare, num43, num5, num, out currentTableRawCellValue7, out compareTableRawCellValue7);
			}
			else
			{
				num45 = bAC.method_257(num43, num44, num);
				num46 = bAC.method_257(num43, num5, num);
			}
			double num47 = num46 - num45;
			double num48 = bAD.method_89().method_258(num5) - bAD.method_89().method_258(num44);
			double num49 = num47 / num48;
			double num50 = ((Form23.enum60_0 != Form23.Enum60.BpF || tableForCompare == null) ? (num45 - Math.Round(num49 * (double)bAD.method_89().method_258(num44))) : (num45 - num49 * (double)bAD.method_89().method_258(num44)));
			for (int num51 = 1; num51 < num7 - 1; num51++)
			{
				int num52 = ((!bAg) ? (num6 + num51) : (num8 - 1 - (num6 + num51)));
				int num53 = bAD.method_89().method_258(num52);
				int int_4;
				if (Form23.enum60_0 == Form23.Enum60.BpF && tableForCompare != null)
				{
					GetCellDifferenceDisplayValue(tableForCompare, num43, num52, num, out var _, out var compareTableRawCellValue8);
					double num54 = Class233.smethod_28(compareTableRawCellValue8, num9);
					double num55 = num49 * (double)num53 + num50;
					int_4 = Class233.smethod_26(num54 + num55, num9);
				}
				else
				{
					int_4 = (int)Math.Round(num49 * (double)num53 + num50);
				}
				bAC.method_273(num43, num52, num, int_4, bool_0: true);
				if (m_framework.awo != null)
				{
					Setting setting2 = m_framework.awo.method_2(method_64());
					if (setting2 != null && setting2.method_256() == num52)
					{
						m_framework.awo.method_1(method_64());
					}
				}
			}
		}
	}

	private void method_303(TableAxis tableAxis_0, bool bool_0, int int_0, int int_1, out int int_2, out int int_3, out float float_0)
	{
		int_2 = 0;
		int_3 = 0;
		float_0 = 0f;
		if (!bool_0 || int_0 <= 1)
		{
			return;
		}
		int num = tableAxis_0.method_89().method_258(0);
		int num2 = tableAxis_0.method_89().method_258(int_0 - 1);
		if (int_1 <= num)
		{
			int_2 = 0;
			int_3 = 0;
			return;
		}
		if (int_1 >= num2)
		{
			int_2 = int_0 - 1;
			int_3 = int_0 - 1;
			return;
		}
		int num3 = 0;
		int num4;
		int num5;
		while (true)
		{
			if (num3 < int_0 - 1)
			{
				num4 = tableAxis_0.method_89().method_258(num3);
				num5 = tableAxis_0.method_89().method_258(num3 + 1);
				if (int_1 <= num5)
				{
					break;
				}
				num3++;
				continue;
			}
			return;
		}
		int_2 = num3;
		int_3 = num3 + 1;
		double num6 = num4;
		double num7 = num5;
		if (int_1 == num4)
		{
			float_0 = 0f;
		}
		else
		{
			float_0 = (float)(((double)int_1 - num6) / (num7 - num6));
		}
	}

	public int GetInterpolatedTableDataRawValue(int horizRawValue, int vertRawValue, int sliceRawValue)
	{
		int int_ = HorizAxisCount();
		int int_2 = VertAxisCount();
		int int_3 = SliceCount();
		method_303(HorizAxis, HorizAxisEnabled(), int_, horizRawValue, out var int_4, out var int_5, out var float_);
		method_303(VertAxis, VertAxisEnabled(), int_2, vertRawValue, out var int_6, out var int_7, out var float_2);
		method_303(bAd, SlicesEnabled(), int_3, sliceRawValue, out var int_8, out var int_9, out var float_3);
		double num;
		double num2;
		double num3;
		double num4;
		double num5;
		double num6;
		double num7;
		double num8;
		if (bAH)
		{
			num = bAC.method_257(int_6, int_4, int_8);
			num2 = bAC.method_257(int_6, int_5, int_8);
			num3 = bAC.method_257(int_7, int_4, int_8);
			num4 = bAC.method_257(int_7, int_5, int_8);
			num5 = bAC.method_257(int_6, int_4, int_9);
			num6 = bAC.method_257(int_6, int_5, int_9);
			num7 = bAC.method_257(int_7, int_4, int_9);
			num8 = bAC.method_257(int_7, int_5, int_9);
		}
		else
		{
			num = bAC.method_257(int_4, int_6, int_8);
			num2 = bAC.method_257(int_5, int_6, int_8);
			num3 = bAC.method_257(int_4, int_7, int_8);
			num4 = bAC.method_257(int_5, int_7, int_8);
			num5 = bAC.method_257(int_4, int_6, int_9);
			num6 = bAC.method_257(int_5, int_6, int_9);
			num7 = bAC.method_257(int_4, int_7, int_9);
			num8 = bAC.method_257(int_5, int_7, int_9);
		}
		double num9 = ((int_4 == int_5) ? num : (num + (double)(float_ * (float)(num2 - num))));
		double num10 = ((int_4 == int_5) ? num3 : (num3 + (double)(float_ * (float)(num4 - num3))));
		double num11 = ((int_6 == int_7) ? num9 : (num9 + (double)(float_2 * (float)(num10 - num9))));
		double num12 = ((int_4 == int_5) ? num5 : (num5 + (double)(float_ * (float)(num6 - num5))));
		double num13 = ((int_4 == int_5) ? num7 : (num7 + (double)(float_ * (float)(num8 - num7))));
		double num14 = ((int_6 == int_7) ? num12 : (num12 + (double)(float_2 * (float)(num13 - num12))));
		return (int)Math.Round((int_8 == int_9) ? num11 : (num11 + (double)(float_3 * (float)(num14 - num11))));
	}

	private static void smethod_4(int[] int_0, int int_1, int int_2, out int int_3, out int int_4, out float float_0)
	{
		int_3 = 0;
		int_4 = 0;
		float_0 = 0f;
		if (int_1 <= 1)
		{
			return;
		}
		int num = int_0[0];
		int num2 = int_0[int_1 - 1];
		if (int_2 <= num)
		{
			int_3 = 0;
			int_4 = 0;
			return;
		}
		if (int_2 >= num2)
		{
			int_3 = int_1 - 1;
			int_4 = int_1 - 1;
			return;
		}
		int num3 = 0;
		int num4;
		int num5;
		while (true)
		{
			if (num3 < int_1 - 1)
			{
				num4 = int_0[num3];
				num5 = int_0[num3 + 1];
				if (int_2 <= num5)
				{
					break;
				}
				num3++;
				continue;
			}
			return;
		}
		int_3 = num3;
		int_4 = num3 + 1;
		double num6 = num4;
		double num7 = num5;
		if (int_2 == num4)
		{
			float_0 = 0f;
		}
		else
		{
			float_0 = (float)(((double)int_2 - num6) / (num7 - num6));
		}
	}

	public static double GetInterpolatedValue(double[,,] cellsPerSliceRowColumn, int[] columnAxisValues, int[] rowAxisValues, int[] sliceAxisValues, int columnLookupValue, int rowLookupValue, int sliceLookupValue)
	{
		int int_ = columnAxisValues?.Length ?? 0;
		int int_2 = rowAxisValues?.Length ?? 0;
		int int_3 = sliceAxisValues?.Length ?? 0;
		smethod_4(columnAxisValues, int_, columnLookupValue, out var int_4, out var int_5, out var float_);
		smethod_4(rowAxisValues, int_2, rowLookupValue, out var int_6, out var int_7, out var float_2);
		smethod_4(sliceAxisValues, int_3, sliceLookupValue, out var int_8, out var int_9, out var float_3);
		double num = cellsPerSliceRowColumn[int_8, int_6, int_4];
		double num2 = cellsPerSliceRowColumn[int_8, int_6, int_5];
		double num3 = cellsPerSliceRowColumn[int_8, int_7, int_4];
		double num4 = cellsPerSliceRowColumn[int_8, int_7, int_5];
		double num5 = cellsPerSliceRowColumn[int_9, int_6, int_4];
		double num6 = cellsPerSliceRowColumn[int_9, int_6, int_5];
		double num7 = cellsPerSliceRowColumn[int_9, int_7, int_4];
		double num8 = cellsPerSliceRowColumn[int_9, int_7, int_5];
		double num9 = ((int_4 == int_5) ? num : (num + (double)(float_ * (float)(num2 - num))));
		double num10 = ((int_4 == int_5) ? num3 : (num3 + (double)(float_ * (float)(num4 - num3))));
		double num11 = ((int_6 == int_7) ? num9 : (num9 + (double)(float_2 * (float)(num10 - num9))));
		double num12 = ((int_4 == int_5) ? num5 : (num5 + (double)(float_ * (float)(num6 - num5))));
		double num13 = ((int_4 == int_5) ? num7 : (num7 + (double)(float_ * (float)(num8 - num7))));
		double num14 = ((int_6 == int_7) ? num12 : (num12 + (double)(float_2 * (float)(num13 - num12))));
		if (int_8 != int_9)
		{
			return num11 + (double)(float_3 * (float)(num14 - num11));
		}
		return num11;
	}

	public bool SortByAxis(AxisType axisType, bool markForWrite)
	{
		TableAxis tableAxis = null;
		int num = 0;
		if (axisType == AxisType.Column)
		{
			tableAxis = ColumnAxis;
			num = ColumnCount();
		}
		else
		{
			if (axisType != AxisType.Row)
			{
				return false;
			}
			tableAxis = RowAxis;
			num = RowCount();
		}
		if (tableAxis != null && tableAxis.method_89() != null)
		{
			int num2 = SliceCount();
			int num3 = num;
			bool flag = false;
			do
			{
				flag = false;
				for (int i = 1; i < num3; i++)
				{
					int num4 = tableAxis.method_89().method_258(i - 1);
					int num5 = tableAxis.method_89().method_258(i);
					if (num4 <= num5)
					{
						continue;
					}
					tableAxis.method_89().method_274(i, num4, markForWrite);
					tableAxis.method_89().method_274(i - 1, num5, markForWrite);
					int num6 = ((axisType == AxisType.Column) ? RowCount() : ColumnCount());
					for (int j = 0; j < num6; j++)
					{
						for (int k = 0; k < num2; k++)
						{
							switch (axisType)
							{
							case AxisType.Column:
							{
								int int_3 = bAC.method_257(i - 1, j, k);
								int int_4 = bAC.method_257(i, j, k);
								bAC.method_273(i, j, k, int_3, markForWrite);
								bAC.method_273(i - 1, j, k, int_4, markForWrite);
								break;
							}
							case AxisType.Row:
							{
								int int_ = bAC.method_257(j, i - 1, k);
								int int_2 = bAC.method_257(j, i, k);
								bAC.method_273(j, i, k, int_, markForWrite);
								bAC.method_273(j, i - 1, k, int_2, markForWrite);
								break;
							}
							}
						}
					}
					flag = true;
				}
				num3--;
			}
			while (flag);
			return true;
		}
		return false;
	}

	public string GetSelectionRangeString(Setting horizAxisSourceChannel, Setting vertAxisSourceChannel)
	{
		int num = HorizAxisCount();
		string text = string.Empty;
		if (horizAxisSourceChannel != null && HorizAxisEnabled())
		{
			string text2 = Class233.smethod_35(horizAxisSourceChannel.method_232(), horizAxisSourceChannel.method_231(), bool_0: false, 0);
			int num2 = -1;
			int num3 = -1;
			for (int i = 0; i < num; i++)
			{
				foreach (Point item in HorizVertIndexPerUserSelectedCell)
				{
					if (item.X == i)
					{
						if (num2 == -1)
						{
							num2 = i;
						}
						num3 = i;
						break;
					}
				}
			}
			if (num2 != -1 && num3 != -1)
			{
				if (num2 == num3)
				{
					int int_ = HorizAxis.method_89().method_258(num2);
					(string, string, bool) tuple = horizAxisSourceChannel.method_253(int_);
					text = string.Format(Class333.BAq(), tuple.Item1, text2);
				}
				else
				{
					int int_2 = HorizAxis.method_89().method_258(num2);
					(string, string, bool) tuple2 = horizAxisSourceChannel.method_253(int_2);
					int int_3 = HorizAxis.method_89().method_258(num3);
					(string, string, bool) tuple3 = horizAxisSourceChannel.method_253(int_3);
					text = string.Format(Class333.BiR(), tuple2.Item1, tuple3.Item1, text2);
				}
			}
		}
		int num4 = VertAxisCount();
		string text3 = string.Empty;
		if (vertAxisSourceChannel != null && VertAxisEnabled())
		{
			string text4 = Class233.smethod_35(vertAxisSourceChannel.method_232(), vertAxisSourceChannel.method_231(), bool_0: false, 0);
			int num5 = -1;
			int num6 = -1;
			for (int j = 0; j < num4; j++)
			{
				foreach (Point item2 in HorizVertIndexPerUserSelectedCell)
				{
					if (item2.Y == j)
					{
						if (num5 == -1)
						{
							num5 = j;
						}
						num6 = j;
						break;
					}
				}
			}
			if (num5 != -1 && num6 != -1)
			{
				if (num5 == num6)
				{
					int int_4 = ((!bAg) ? VertAxis.method_89().method_258(num5) : VertAxis.method_89().method_258(num4 - 1 - num5));
					(string, string, bool) tuple4 = vertAxisSourceChannel.method_253(int_4);
					text3 = string.Format(Class333.BAq(), tuple4.Item1, text4);
				}
				else
				{
					int int_5;
					int int_6;
					if (bAg)
					{
						int_5 = VertAxis.method_89().method_258(num4 - 1 - num5);
						int_6 = VertAxis.method_89().method_258(num4 - 1 - num6);
					}
					else
					{
						int_5 = VertAxis.method_89().method_258(num5);
						int_6 = VertAxis.method_89().method_258(num6);
					}
					(string, string, bool) tuple5 = vertAxisSourceChannel.method_253(int_5);
					(string, string, bool) tuple6 = vertAxisSourceChannel.method_253(int_6);
					text3 = string.Format(Class333.BiR(), tuple5.Item1, tuple6.Item1, text4);
				}
			}
		}
		if (text != string.Empty && text3 != string.Empty)
		{
			return text + Class333.aMY() + text3;
		}
		if (text != string.Empty)
		{
			return text;
		}
		return text3;
	}

	public string GetCellValueString()
	{
		string text = Class333.Bir();
		if (HorizVertIndexPerUserSelectedCell.Count == 0)
		{
			return text;
		}
		int int_ = 0;
		if (SlicesEnabled())
		{
			int_ = UserSliceIndex;
		}
		int num = HorizAxisCount();
		int num2 = VertAxisCount();
		int num3 = int.MaxValue;
		int num4 = int.MinValue;
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num; j++)
			{
				if (HorizVertIndexPerUserSelectedCell.Contains(new Point(j, i)))
				{
					int num5;
					if (bAH)
					{
						num5 = ((!InvertRows) ? bAC.method_257(i, j, int_) : bAC.method_257(num2 - 1 - i, j, int_));
					}
					else
					{
						num5 = ((!bAg) ? bAC.method_257(j, i, int_) : bAC.method_257(j, num2 - 1 - i, int_));
					}
					if (num5 > num4)
					{
						num4 = num5;
					}
					if (num5 < num3)
					{
						num3 = num5;
					}
				}
			}
		}
		string text2 = Class233.smethod_35(method_232(), method_231(), bool_0: false, 0);
		if (num3 == num4)
		{
			return text + Class233.smethod_29(num3, method_231()) + Class333.smethod_325() + text2;
		}
		return text + Class233.smethod_29(num3, method_231()) + Class333.smethod_1824() + Class233.smethod_29(num4, method_231()) + Class333.smethod_325() + text2;
	}

	public bool ColumnAxisMonotonicityIsValid()
	{
		if (ColumnAxis == null)
		{
			return true;
		}
		if (!ColumnAxis.method_76() && !ColumnAxis.method_78())
		{
			return true;
		}
		int num = ColumnCount();
		if (num <= 1)
		{
			return true;
		}
		int num2 = SliceCount();
		int num3 = RowCount();
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num3; j++)
			{
				int num4 = 0;
				for (int k = 0; k < num; k++)
				{
					int num5 = TableDataSetting.method_257(k, j, i);
					if (k != 0)
					{
						if (num5 > num4)
						{
							flag = true;
						}
						else if (num5 < num4)
						{
							flag2 = true;
						}
						if (ColumnAxis.method_76() && ColumnAxis.method_78())
						{
							if (flag & flag2)
							{
								return false;
							}
						}
						else if (ColumnAxis.method_76())
						{
							if (flag2)
							{
								return false;
							}
						}
						else if (ColumnAxis.method_78() && flag)
						{
							return false;
						}
					}
					num4 = num5;
				}
			}
		}
		return true;
	}

	public bool RowAxisMonotonicityIsValid()
	{
		if (RowAxis == null)
		{
			return true;
		}
		if (!RowAxis.method_76() && !RowAxis.method_78())
		{
			return true;
		}
		int num = RowCount();
		if (num <= 1)
		{
			return true;
		}
		int num2 = SliceCount();
		int num3 = ColumnCount();
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num3; j++)
			{
				int num4 = 0;
				for (int k = 0; k < num; k++)
				{
					int num5 = TableDataSetting.method_257(j, k, i);
					if (k != 0)
					{
						if (num5 > num4)
						{
							flag = true;
						}
						else if (num5 < num4)
						{
							flag2 = true;
						}
						if (RowAxis.method_76() && RowAxis.method_78())
						{
							if (flag & flag2)
							{
								return false;
							}
						}
						else if (RowAxis.method_76())
						{
							if (flag2)
							{
								return false;
							}
						}
						else if (RowAxis.method_78() && flag)
						{
							return false;
						}
					}
					num4 = num5;
				}
			}
		}
		return true;
	}

	public List<string> GetAxesErrorStrings()
	{
		List<string> list = new List<string>();
		if (!ColumnAxisMonotonicityIsValid())
		{
			if (ColumnAxis.method_76() && ColumnAxis.method_78())
			{
				list.Add(Class333.BfJ());
			}
			else if (ColumnAxis.method_76())
			{
				list.Add(Class333.Bfj());
			}
			else if (ColumnAxis.method_78())
			{
				list.Add(Class333.BfK());
			}
		}
		if (!RowAxisMonotonicityIsValid())
		{
			if (RowAxis.method_76() && RowAxis.method_78())
			{
				list.Add(Class333.BfJ());
			}
			else if (RowAxis.method_76())
			{
				list.Add(Class333.Bfj());
			}
			else if (RowAxis.method_78())
			{
				list.Add(Class333.BfK());
			}
		}
		return list;
	}

	public List<string> GetAxesWarningStrings()
	{
		List<string> list = new List<string>();
		if (ColumnsEnabled())
		{
			Setting setting = ColumnAxis.method_92();
			if (setting == null || !setting.method_35() || !PortFunction.smethod_52(setting))
			{
				if (setting == null)
				{
					list.Add(Class333.BiS());
				}
				else
				{
					list.Add(setting.method_60(Enum96.aYt) + Class333.Bis());
				}
			}
		}
		if (RowsEnabled())
		{
			Setting setting2 = RowAxis.method_92();
			if (setting2 == null || !setting2.method_35() || !PortFunction.smethod_52(setting2))
			{
				if (setting2 == null)
				{
					list.Add(Class333.BiS());
				}
				else
				{
					list.Add(setting2.method_60(Enum96.aYt) + Class333.Bis());
				}
			}
		}
		if (SlicesEnabled())
		{
			Setting setting3 = SliceAxis.method_92();
			if (setting3 == null || !setting3.method_35() || !PortFunction.smethod_52(setting3))
			{
				if (setting3 == null)
				{
					list.Add(Class333.BiS());
				}
				else
				{
					list.Add(setting3.method_60(Enum96.aYt) + Class333.Bis());
				}
			}
		}
		return list;
	}

	internal void method_304(int int_0, int int_1)
	{
		Setting setting = m_framework.method_31(464);
		Setting setting2 = m_framework.method_31(6481);
		if (setting == null || setting2 == null)
		{
			return;
		}
		int num = setting.method_256();
		int num2 = setting2.method_256();
		if (num <= 0 || num2 <= 0)
		{
			return;
		}
		int num3 = ColumnCount();
		int num4 = RowCount();
		int num5 = SliceCount();
		for (int i = 0; i < num3; i++)
		{
			for (int j = 0; j < num4; j++)
			{
				for (int k = 0; k < num5; k++)
				{
					if (int_0 == 6469 && (int_1 == 6750 || int_1 == 463))
					{
						double num6 = bAC.method_257(i, j, k) * 60 * num2;
						int int_2 = (int)Math.Round(10.0 * num6 / (double)num);
						bAC.method_273(i, j, k, int_2, bool_0: true);
					}
					else if (int_1 == 6469 && (int_0 == 6750 || int_0 == 463))
					{
						int int_3 = (int)Math.Round((float)bAC.method_257(i, j, k) * (float)num / (600f * (float)num2));
						bAC.method_273(i, j, k, int_3, bool_0: true);
					}
				}
			}
		}
	}

	internal void method_305()
	{
		TableAxis tableAxis = null;
		int num = 0;
		if (ColumnsEnabled() && ColumnAxis.method_90() != null && ColumnAxis.method_92() != null)
		{
			num = ColumnAxis.method_92().method_64();
			if (num == 407)
			{
				tableAxis = ColumnAxis;
			}
		}
		int num2 = 0;
		if (RowsEnabled() && RowAxis.method_90() != null && RowAxis.method_92() != null)
		{
			num2 = RowAxis.method_92().method_64();
			if (num2 == 407)
			{
				tableAxis = RowAxis;
			}
		}
		int num3 = 0;
		if (SlicesEnabled() && SliceAxis.method_90() != null && SliceAxis.method_92() != null)
		{
			num3 = SliceAxis.method_92().method_64();
			if (num3 == 407)
			{
				tableAxis = SliceAxis;
			}
		}
		if (tableAxis == null || tableAxis.method_84() != 0 || tableAxis.method_88() == null || tableAxis.method_89() == null)
		{
			return;
		}
		Setting setting = m_framework.method_31(15995);
		Table table = m_framework.method_31(128) as Table;
		if (setting == null || table == null)
		{
			return;
		}
		double num4 = Math.Pow((double)setting.method_256() / 1000.0, 1.399999976158142);
		int[] array = new int[tableAxis.method_88().method_256()];
		for (int i = 0; i < tableAxis.method_88().method_256(); i++)
		{
			int num5 = (int)Math.Round((double)tableAxis.method_89().method_258(i) / (1.0 * num4));
			array[i] = num5;
		}
		TableAxis tableAxis2 = ((num != 0) ? table.GetAxisUsingChannel(num) : null);
		TableAxis tableAxis3 = ((num2 != 0) ? table.GetAxisUsingChannel(num2) : null);
		TableAxis tableAxis4 = ((num3 != 0) ? table.GetAxisUsingChannel(num3) : null);
		TableAxis axisUsingChannel = table.GetAxisUsingChannel(15985);
		if (axisUsingChannel == null)
		{
			axisUsingChannel = table.GetAxisUsingChannel(224);
		}
		if (axisUsingChannel == null)
		{
			axisUsingChannel = table.GetAxisUsingChannel(385);
		}
		if (axisUsingChannel == null)
		{
			return;
		}
		int num6 = SliceCount();
		int num7 = RowCount();
		int num8 = ColumnCount();
		int[,,] array2 = new int[num6, num7, num8];
		for (int j = 0; j < num6; j++)
		{
			int num9 = ((SliceAxis != null) ? SliceAxis.method_89().method_258(j) : 0);
			for (int k = 0; k < num7; k++)
			{
				int num10 = ((RowAxis != null) ? RowAxis.method_89().method_258(k) : 0);
				for (int l = 0; l < num8; l++)
				{
					int num11 = ((ColumnAxis != null) ? ColumnAxis.method_89().method_258(l) : 0);
					int num12 = int.MaxValue;
					int num13 = int.MaxValue;
					int sliceRawValue = int.MaxValue;
					if (tableAxis2 != null || tableAxis3 != null || tableAxis4 != null)
					{
						if (tableAxis2 == null && tableAxis3 == null)
						{
							if (tableAxis4.method_71() == AxisType.Column)
							{
								num12 = num9;
							}
							else if (tableAxis4.method_71() == AxisType.Row)
							{
								num13 = num9;
							}
							else if (tableAxis4.method_71() == AxisType.Slice)
							{
								sliceRawValue = num9;
							}
						}
						else if (tableAxis3 == null && tableAxis4 == null)
						{
							if (tableAxis2.method_71() == AxisType.Column)
							{
								num12 = num11;
							}
							else if (tableAxis2.method_71() == AxisType.Row)
							{
								num13 = num11;
							}
							else if (tableAxis2.method_71() == AxisType.Slice)
							{
								sliceRawValue = num11;
							}
						}
						else if (tableAxis2 == null && tableAxis4 == null)
						{
							if (tableAxis3.method_71() == AxisType.Column)
							{
								num12 = num10;
							}
							else if (tableAxis3.method_71() == AxisType.Row)
							{
								num13 = num10;
							}
							else if (tableAxis3.method_71() == AxisType.Slice)
							{
								sliceRawValue = num10;
							}
						}
						else if (tableAxis2 == null)
						{
							if (tableAxis3.method_71() == AxisType.Column && tableAxis4.method_71() == AxisType.Row)
							{
								num12 = num10;
								num13 = num9;
							}
							else if (tableAxis3.method_71() == AxisType.Row && tableAxis4.method_71() == AxisType.Slice)
							{
								num13 = num10;
								sliceRawValue = num9;
							}
							else if (tableAxis3.method_71() == AxisType.Column && tableAxis4.method_71() == AxisType.Slice)
							{
								num12 = num10;
								sliceRawValue = num9;
							}
						}
						else if (tableAxis3 == null)
						{
							if (tableAxis2.method_71() == AxisType.Column && tableAxis4.method_71() == AxisType.Row)
							{
								num12 = num11;
								num13 = num9;
							}
							else if (tableAxis2.method_71() == AxisType.Row && tableAxis4.method_71() == AxisType.Slice)
							{
								num13 = num11;
								sliceRawValue = num9;
							}
							else if (tableAxis2.method_71() == AxisType.Column && tableAxis4.method_71() == AxisType.Slice)
							{
								num12 = num11;
								sliceRawValue = num9;
							}
						}
						else if (tableAxis4 == null)
						{
							if (tableAxis2.method_71() == AxisType.Column && tableAxis3.method_71() == AxisType.Row)
							{
								num12 = num11;
								num13 = num10;
							}
							else if (tableAxis2.method_71() == AxisType.Row && tableAxis3.method_71() == AxisType.Slice)
							{
								num13 = num11;
								sliceRawValue = num10;
							}
							else if (tableAxis2.method_71() == AxisType.Column && tableAxis3.method_71() == AxisType.Slice)
							{
								num12 = num11;
								sliceRawValue = num10;
							}
						}
						else if (tableAxis2.method_71() == AxisType.Column && tableAxis3.method_71() == AxisType.Row && tableAxis4.method_71() == AxisType.Slice)
						{
							num12 = num11;
							num13 = num10;
							sliceRawValue = num9;
						}
						else if (tableAxis2.method_71() == AxisType.Row && tableAxis3.method_71() == AxisType.Column && tableAxis4.method_71() == AxisType.Slice)
						{
							num12 = num10;
							num13 = num11;
							sliceRawValue = num9;
						}
						else if (tableAxis2.method_71() == AxisType.Row && tableAxis3.method_71() == AxisType.Slice && tableAxis4.method_71() == AxisType.Column)
						{
							num12 = num9;
							num13 = num11;
							sliceRawValue = num10;
						}
						else if (tableAxis2.method_71() == AxisType.Slice && tableAxis3.method_71() == AxisType.Row && tableAxis4.method_71() == AxisType.Column)
						{
							num12 = num9;
							num13 = num10;
							sliceRawValue = num11;
						}
						else if (tableAxis2.method_71() == AxisType.Slice && tableAxis3.method_71() == AxisType.Column && tableAxis4.method_71() == AxisType.Row)
						{
							num12 = num10;
							num13 = num9;
							sliceRawValue = num11;
						}
						else if (tableAxis2.method_71() == AxisType.Column && tableAxis3.method_71() == AxisType.Slice && tableAxis4.method_71() == AxisType.Row)
						{
							num12 = num11;
							num13 = num9;
							sliceRawValue = num10;
						}
					}
					int num14 = 0;
					if (tableAxis.method_71() == AxisType.Column)
					{
						num14 = array[l];
					}
					else if (tableAxis.method_71() == AxisType.Row)
					{
						num14 = array[k];
					}
					else if (tableAxis.method_71() == AxisType.Slice)
					{
						num14 = array[j];
					}
					if (axisUsingChannel.method_71() == AxisType.Column)
					{
						num12 = num14;
					}
					else if (axisUsingChannel.method_71() == AxisType.Row)
					{
						num13 = num14;
					}
					else if (axisUsingChannel.method_71() == AxisType.Slice)
					{
						sliceRawValue = num14;
					}
					int horizRawValue = ((!table.SwapColumnsAndRows) ? num12 : num13);
					int vertRawValue = ((!table.SwapColumnsAndRows) ? num13 : num12);
					double num15 = (double)table.GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue) / 1000.0;
					int num16 = (int)Math.Round((double)num14 * num15 * num4);
					if (tableAxis.method_71() == AxisType.Column)
					{
						num11 = num16;
					}
					else if (tableAxis.method_71() == AxisType.Row)
					{
						num10 = num16;
					}
					else if (tableAxis.method_71() == AxisType.Slice)
					{
						num9 = num16;
					}
					int horizRawValue2 = ((!bAH) ? num11 : num10);
					int vertRawValue2 = ((!bAH) ? num10 : num11);
					array2[j, k, l] = GetInterpolatedTableDataRawValue(horizRawValue2, vertRawValue2, num9);
				}
			}
		}
		for (int m = 0; m < tableAxis.method_88().method_256(); m++)
		{
			tableAxis.method_89().method_274(m, array[m], bool_0: true);
		}
		for (int n = 0; n < num6; n++)
		{
			for (int num17 = 0; num17 < num7; num17++)
			{
				for (int num18 = 0; num18 < num8; num18++)
				{
					bAC.method_273(num18, num17, n, array2[n, num17, num18], bool_0: true);
				}
			}
		}
	}

	public void ResetViewingAngleToDefault()
	{
		RotationXAngleDegrees = 28f;
		RotationYAngleDegrees = 35f;
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		hashSet.Add(new DataIdAndAttrId(method_64()));
		hashSet.Add(new DataIdAndAttrId(TableDataSetting.method_64()));
		if (bAc != null)
		{
			if (bAc.method_87() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAc.method_87().method_64()));
			}
			if (bAc.method_88() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAc.method_88().method_64()));
			}
			if (bAc.method_89() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAc.method_89().method_64()));
			}
			if (bAc.method_90() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAc.method_90().method_64()));
			}
			if (bAc.method_91() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAc.method_91().method_64()));
			}
		}
		if (bAD != null)
		{
			if (bAD.method_87() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAD.method_87().method_64()));
			}
			if (bAD.method_88() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAD.method_88().method_64()));
			}
			if (bAD.method_89() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAD.method_89().method_64()));
			}
			if (bAD.method_90() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAD.method_90().method_64()));
			}
			if (bAD.method_91() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAD.method_91().method_64()));
			}
		}
		if (bAd != null)
		{
			if (bAd.method_87() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAd.method_87().method_64()));
			}
			if (bAd.method_88() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAd.method_88().method_64()));
			}
			if (bAd.method_89() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAd.method_89().method_64()));
			}
			if (bAd.method_90() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAd.method_90().method_64()));
			}
			if (bAd.method_91() != null)
			{
				hashSet.Add(new DataIdAndAttrId(bAd.method_91().method_64()));
			}
		}
		return hashSet;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(this, Enum38.const_5, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		node.Text += Class333.BiT();
		node.Checked = method_96();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			m_framework.method_32(item)?.method_97(node.Checked);
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		node.Text += Class333.BiT();
		Setting setting = fromFramework.method_31(method_64());
		if (setting != null && setting is Table)
		{
			Table table = setting as Table;
			if (TableDataSetting.method_240() <= table.TableDataSetting.method_240() && TableDataSetting.method_277() <= table.TableDataSetting.method_277())
			{
				skipThisTreeNode = true;
				return;
			}
			int num = table.TableDataSetting.method_240();
			int num2 = table.TableDataSetting.method_242()[2];
			int num3 = ((num <= 1) ? 1 : table.TableDataSetting.method_242()[1]);
			int num4 = ((num <= 2) ? 1 : table.TableDataSetting.method_242()[0]);
			string text = num2 + Class333.smethod_486() + num3 + Class333.smethod_486() + num4;
			int num5 = TableDataSetting.method_240();
			int num6 = TableDataSetting.method_242()[2];
			int num7 = ((num5 <= 1) ? 1 : TableDataSetting.method_242()[1]);
			int num8 = ((num5 <= 2) ? 1 : TableDataSetting.method_242()[0]);
			string text2 = num6 + Class333.smethod_486() + num7 + Class333.smethod_486() + num8;
			node.Tag = Class333.BiU() + text + Class333.smethod_1824() + text2 + Class333.Bih();
			if (!table.method_35())
			{
				node.ForeColor = Color.Gray;
			}
		}
		else
		{
			node.Tag = Class333.Bit();
		}
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		if (PortFunction.smethod_27(method_6()))
		{
			skipThisTreeNode = true;
			return;
		}
		Setting setting = importFramework.method_31(method_64());
		if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && method_96()) || (importFrameworkLocked && (setting == null || setting.method_96()))))
		{
			skipThisTreeNode = true;
			return;
		}
		node.Text += Class333.BiT();
		userAccessibleIdsInDestFramework.Add(method_69());
		if (setting != null && setting is Table)
		{
			Table table = setting as Table;
			if (!bAC.method_282(table.TableDataSetting))
			{
				treeNodesWithDifferences.Add(node);
			}
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		if (PortFunction.smethod_27(method_6()))
		{
			skipThisTreeNode = true;
			return;
		}
		if ((!bothFrameworksUnlockedOrPasswordsMatch & importFrameworkLocked) && method_96())
		{
			skipThisTreeNode = true;
			return;
		}
		node.Text += Class333.BiT();
		userAccessibleIdsInImportFramework.Add(method_69());
		if (!userAccessibleIdsInDestFramework.Contains(method_69()))
		{
			equivalentNodeExistsInDestMap = false;
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		return !userAccessibleIdsInImportFramework.Contains(method_69());
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		if (bAC.method_72())
		{
			return;
		}
		bAC.method_113(importFramework, markForWrite);
		if (bAc != null)
		{
			if (bAc.method_87() != null)
			{
				bAc.method_87().method_113(importFramework, markForWrite);
			}
			if (bAc.method_88() != null)
			{
				bAc.method_88().method_113(importFramework, markForWrite);
				int num = bAC.method_242()[2];
				if (bAc.method_88().method_256() > num)
				{
					bAc.method_88().method_272(num, markForWrite);
				}
			}
			if (bAc.method_89() != null)
			{
				bAc.method_89().method_113(importFramework, markForWrite);
			}
			if (bAc.method_90() != null)
			{
				bAc.method_90().method_113(importFramework, markForWrite);
			}
			if (bAc.method_91() != null)
			{
				bAc.method_91().method_113(importFramework, markForWrite);
			}
		}
		if (bAD != null)
		{
			if (bAD.method_87() != null)
			{
				bAD.method_87().method_113(importFramework, markForWrite);
			}
			if (bAD.method_88() != null)
			{
				bAD.method_88().method_113(importFramework, markForWrite);
				int num2 = bAC.method_242()[1];
				if (bAD.method_88().method_256() > num2)
				{
					bAD.method_88().method_272(num2, markForWrite);
				}
			}
			if (bAD.method_89() != null)
			{
				bAD.method_89().method_113(importFramework, markForWrite);
			}
			if (bAD.method_90() != null)
			{
				bAD.method_90().method_113(importFramework, markForWrite);
			}
			if (bAD.method_91() != null)
			{
				bAD.method_91().method_113(importFramework, markForWrite);
			}
		}
		if (bAd != null)
		{
			if (bAd.method_87() != null)
			{
				bAd.method_87().method_113(importFramework, markForWrite);
			}
			if (bAd.method_88() != null)
			{
				bAd.method_88().method_113(importFramework, markForWrite);
				int num3 = bAC.method_242()[0];
				if (bAd.method_88().method_256() > num3)
				{
					bAd.method_88().method_272(num3, markForWrite);
				}
			}
			if (bAd.method_89() != null)
			{
				bAd.method_89().method_113(importFramework, markForWrite);
			}
			if (bAd.method_90() != null)
			{
				bAd.method_90().method_113(importFramework, markForWrite);
			}
			if (bAd.method_91() != null)
			{
				bAd.method_91().method_113(importFramework, markForWrite);
			}
		}
		if (bAC.method_64() == 14206 && !BezierCurve.ETCBezierToTableRedundancyIsOK(importFramework, m_framework))
		{
			method_306(markForWrite);
		}
	}

	internal void method_306(bool bool_0)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = m_framework.method_32(item);
			if (setting != null && setting != this)
			{
				setting.method_246(bool_0);
			}
		}
	}

	public void CopyFromAnotherTable(Table sourceTable, bool markForWrite)
	{
		if (bAC.method_278() != sourceTable.TableDataSetting.method_278())
		{
			return;
		}
		if (bAc != null && sourceTable.ColumnAxis != null)
		{
			if (bAc.method_87() != null && sourceTable.ColumnAxis.method_87() != null)
			{
				bAc.method_87().method_116(sourceTable.ColumnAxis.method_87(), markForWrite);
				Form23.smethod_74(bAc.method_87().method_64());
			}
			if (bAc.method_88() != null && sourceTable.ColumnAxis.method_88() != null)
			{
				bAc.method_88().method_116(sourceTable.ColumnAxis.method_88(), markForWrite);
				Form23.smethod_74(bAc.method_88().method_64());
			}
			if (bAc.method_89() != null && sourceTable.ColumnAxis.method_89() != null)
			{
				bAc.method_89().method_116(sourceTable.ColumnAxis.method_89(), markForWrite);
				Form23.smethod_74(bAc.method_89().method_64());
			}
			if (bAc.method_90() != null && sourceTable.ColumnAxis.method_90() != null)
			{
				bAc.method_90().method_116(sourceTable.ColumnAxis.method_90(), markForWrite);
				Form23.smethod_74(bAc.method_90().method_64());
			}
			if (bAc.method_91() != null && sourceTable.ColumnAxis.method_91() != null)
			{
				bAc.method_91().method_116(sourceTable.ColumnAxis.method_91(), markForWrite);
				Form23.smethod_74(bAc.method_91().method_64());
			}
		}
		if (bAD != null && sourceTable.RowAxis != null)
		{
			if (bAD.method_87() != null && sourceTable.RowAxis.method_87() != null)
			{
				bAD.method_87().method_116(sourceTable.RowAxis.method_87(), markForWrite);
				Form23.smethod_74(bAD.method_87().method_64());
			}
			if (bAD.method_88() != null && sourceTable.RowAxis.method_88() != null)
			{
				bAD.method_88().method_116(sourceTable.RowAxis.method_88(), markForWrite);
				Form23.smethod_74(bAD.method_88().method_64());
			}
			if (bAD.method_89() != null && sourceTable.RowAxis.method_89() != null)
			{
				bAD.method_89().method_116(sourceTable.RowAxis.method_89(), markForWrite);
				Form23.smethod_74(bAD.method_89().method_64());
			}
			if (bAD.method_90() != null && sourceTable.RowAxis.method_90() != null)
			{
				bAD.method_90().method_116(sourceTable.RowAxis.method_90(), markForWrite);
				Form23.smethod_74(bAD.method_90().method_64());
			}
			if (bAD.method_91() != null && sourceTable.RowAxis.method_91() != null)
			{
				bAD.method_91().method_116(sourceTable.RowAxis.method_91(), markForWrite);
				Form23.smethod_74(bAD.method_91().method_64());
			}
		}
		if (bAd != null && sourceTable.SliceAxis != null)
		{
			if (bAd.method_87() != null && sourceTable.SliceAxis.method_87() != null)
			{
				bAd.method_87().method_116(sourceTable.SliceAxis.method_87(), markForWrite);
				Form23.smethod_74(bAd.method_87().method_64());
			}
			if (bAd.method_88() != null && sourceTable.SliceAxis.method_88() != null)
			{
				bAd.method_88().method_116(sourceTable.SliceAxis.method_88(), markForWrite);
				Form23.smethod_74(bAd.method_88().method_64());
			}
			if (bAd.method_89() != null && sourceTable.SliceAxis.method_89() != null)
			{
				bAd.method_89().method_116(sourceTable.SliceAxis.method_89(), markForWrite);
				Form23.smethod_74(bAd.method_89().method_64());
			}
			if (bAd.method_90() != null && sourceTable.SliceAxis.method_90() != null)
			{
				bAd.method_90().method_116(sourceTable.SliceAxis.method_90(), markForWrite);
				Form23.smethod_74(bAd.method_90().method_64());
			}
			if (bAd.method_91() != null && sourceTable.SliceAxis.method_91() != null)
			{
				bAd.method_91().method_116(sourceTable.SliceAxis.method_91(), markForWrite);
				Form23.smethod_74(bAd.method_91().method_64());
			}
		}
		bAC.method_116(sourceTable.TableDataSetting, markForWrite);
		Form23.smethod_74(bAC.method_64());
	}

	public void CompareWithAnotherCorrespondingTable(Table compareTable, StringBuilder resultsStringBuilder)
	{
		if (resultsStringBuilder == null)
		{
			return;
		}
		int num = bAC.method_278();
		int num2 = compareTable.bAC.method_278();
		if (num != num2)
		{
			resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.BiV() + num + Class333.BdL() + num2 + Class333.Bdl());
			return;
		}
		Setting setting = null;
		if (ColumnAxis != null && ColumnAxis.method_90() != null)
		{
			setting = ColumnAxis.method_92();
		}
		Setting setting2 = null;
		if (RowAxis != null && RowAxis.method_90() != null)
		{
			setting2 = RowAxis.method_92();
		}
		Setting setting3 = null;
		if (SliceAxis != null && SliceAxis.method_90() != null)
		{
			setting3 = SliceAxis.method_92();
		}
		Setting setting4 = null;
		if (compareTable.ColumnAxis != null && compareTable.ColumnAxis.method_90() != null)
		{
			setting4 = compareTable.ColumnAxis.method_92();
		}
		Setting setting5 = null;
		if (compareTable.RowAxis != null && compareTable.RowAxis.method_90() != null)
		{
			setting5 = compareTable.RowAxis.method_92();
		}
		Setting setting6 = null;
		if (compareTable.SliceAxis != null && compareTable.SliceAxis.method_90() != null)
		{
			setting6 = compareTable.SliceAxis.method_92();
		}
		if ((setting != null && setting4 == null) || (setting == null && setting4 != null) || (setting != null && setting4 != null && setting.method_64() != setting4.method_64()))
		{
			string text = ((setting != null) ? (Class333.smethod_1394() + setting.method_60(Enum96.aYt) + Class333.smethod_1394()) : Class333.Biv());
			string text2 = ((setting4 != null) ? (Class333.smethod_1394() + setting4.method_60(Enum96.aYt) + Class333.smethod_1394()) : Class333.Biv());
			resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.BiW() + text + Class333.BdL() + text2 + Class333.Bdl());
		}
		if ((setting2 != null && setting5 == null) || (setting2 == null && setting5 != null) || (setting2 != null && setting5 != null && setting2.method_64() != setting5.method_64()))
		{
			string text3 = ((setting2 != null) ? (Class333.smethod_1394() + setting2.method_60(Enum96.aYt) + Class333.smethod_1394()) : Class333.Biv());
			string text4 = ((setting5 != null) ? (Class333.smethod_1394() + setting5.method_60(Enum96.aYt) + Class333.smethod_1394()) : Class333.Biv());
			resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.Biw() + text3 + Class333.BdL() + text4 + Class333.Bdl());
		}
		if ((setting3 != null && setting6 == null) || (setting3 == null && setting6 != null) || (setting3 != null && setting6 != null && setting3.method_64() != setting6.method_64()))
		{
			string text5 = ((setting3 != null) ? (Class333.smethod_1394() + setting3.method_60(Enum96.aYt) + Class333.smethod_1394()) : Class333.Biv());
			string text6 = ((setting6 != null) ? (Class333.smethod_1394() + setting6.method_60(Enum96.aYt) + Class333.smethod_1394()) : Class333.Biv());
			resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.BiX() + text5 + Class333.BdL() + text6 + Class333.Bdl());
		}
		int num3 = ColumnCount();
		int num4 = RowCount();
		int num5 = SliceCount();
		int num6 = compareTable.ColumnCount();
		int num7 = compareTable.RowCount();
		int num8 = compareTable.SliceCount();
		if (num3 != num6)
		{
			resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.Bix() + num3 + Class333.BiY() + num6 + Class333.Bdl());
		}
		if (num4 != num7)
		{
			resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.Bix() + num4 + Class333.Biy() + num7 + Class333.Bdl());
		}
		if (num5 != num8)
		{
			resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.Bix() + num5 + Class333.BiZ() + num8 + Class333.Bdl());
		}
		int num9 = Math.Max(num3, num6);
		int num10 = Math.Max(num4, num7);
		int num11 = Math.Max(num5, num8);
		if (ColumnAxis != null && compareTable.ColumnAxis != null && ColumnAxis.method_89() != null && compareTable.ColumnAxis.method_89() != null)
		{
			for (int i = 0; i < num9; i++)
			{
				int num12 = ColumnAxis.method_89().method_258(i);
				int num13 = compareTable.ColumnAxis.method_89().method_258(i);
				if (num12 != num13)
				{
					resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.Biz() + i + Class333.Bdo() + num12 + Class333.BdP() + num13 + Class333.Bdp());
				}
			}
		}
		if (RowAxis != null && compareTable.RowAxis != null && RowAxis.method_89() != null && compareTable.RowAxis.method_89() != null)
		{
			for (int j = 0; j < num10; j++)
			{
				int num14 = RowAxis.method_89().method_258(j);
				int num15 = compareTable.RowAxis.method_89().method_258(j);
				if (num14 != num15)
				{
					resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.BJA() + j + Class333.Bdo() + num14 + Class333.BdP() + num15 + Class333.Bdp());
				}
			}
		}
		if (SliceAxis != null && compareTable.SliceAxis != null && SliceAxis.method_89() != null && compareTable.SliceAxis.method_89() != null)
		{
			for (int k = 0; k < num11; k++)
			{
				int num16 = SliceAxis.method_89().method_258(k);
				int num17 = compareTable.SliceAxis.method_89().method_258(k);
				if (num16 != num17)
				{
					resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.BJa() + k + Class333.Bdo() + num16 + Class333.BdP() + num17 + Class333.Bdp());
				}
			}
		}
		int num18 = 0;
		for (int l = 0; l < num11; l++)
		{
			for (int m = 0; m < num10; m++)
			{
				for (int n = 0; n < num9; n++)
				{
					int num19 = bAC.method_257(n, m, l);
					int num20 = compareTable.bAC.method_257(n, m, l);
					if (num19 == num20)
					{
						continue;
					}
					num18++;
					if (num18 <= 64)
					{
						string text7 = string.Empty;
						if (num11 > 1 && num10 > 1 && num9 > 1)
						{
							text7 = Class333.BJB() + l + Class333.BJb() + m + Class333.BJC() + n;
						}
						else if (num10 > 1 && num9 > 1)
						{
							text7 = Class333.BJc() + m + Class333.BJC() + n;
						}
						else if (num10 > 1)
						{
							text7 = Class333.BJc() + m;
						}
						else if (num9 > 1)
						{
							text7 = Class333.BJD() + n;
						}
						resultsStringBuilder.Append(Class333.Biu() + method_60(Enum96.aYt) + Class333.BdK() + method_64() + Class333.BJd() + text7 + Class333.Bdo() + num19 + Class333.BdP() + num20 + Class333.Bdp());
					}
				}
			}
		}
		if (num18 > 64)
		{
			resultsStringBuilder.Append(Class333.BJE() + (num18 - 64) + Class333.BJe());
		}
	}
}
