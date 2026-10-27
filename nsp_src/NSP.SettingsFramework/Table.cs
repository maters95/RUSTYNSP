using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using D;
using NSP.UnitConversion;
using a;
using b;

namespace NSP.SettingsFramework;

public class Table : Setting, CG
{
	internal new class A
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
					bAO.Invoke((object)this, (EventArgs)null);
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
					bAo.Invoke((object)this, (EventArgs)null);
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
					bAP.Invoke((object)this, (EventArgs)null);
				}
			}
		}
	}

	public Point UserCurrentCellHorizVertIndex
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return bAG;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
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
				bAp.Invoke((object)this, (EventArgs)null);
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
					bAQ.Invoke((object)this, (EventArgs)null);
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
					bAq.Invoke((object)this, (EventArgs)null);
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
			bAM = (float)Math.Sin((double)bAL);
			bAm = (float)Math.Cos((double)bAL);
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
			bAN = (float)Math.Sin((double)bAl);
			bAn = (float)Math.Cos((double)bAl);
			if (bAR != null)
			{
				bAR.Invoke((object)this, (EventArgs)null);
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
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAO;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAO, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAO;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAO, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler OnSwapColumnsAndRows
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAo;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAo, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAo;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAo, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler OnUserSliceIndexChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAP;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAP, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAP;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAP, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler OnUserSelectionChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAp;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAp, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAp;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAp, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler OnUserZoomLevelChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAQ;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAQ, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAQ;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAQ, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler OnShowHideBarsChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAq;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAq, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAq;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAq, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler OnViewingAngleChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAR;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAR, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = bAR;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref bAR, val3, val2);
			}
			while (val != val2);
		}
	}

	public Table(Framework framework, string name, int id, int byteAddress, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, false, name, id, byteAddress, parentSettingOrSpecialObject, parentModuleName)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		switch (DC.BvE)
		{
		case bD.zZ:
			bAg = true;
			break;
		case bD.zz:
			bAg = false;
			break;
		default:
			bAg = true;
			break;
		}
	}

	public bool ColumnsEnabled()
	{
		if (bAc != null)
		{
			return bAc.B();
		}
		return false;
	}

	public bool RowsEnabled()
	{
		if (bAD != null)
		{
			return bAD.B();
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
			return bAd.B();
		}
		return false;
	}

	public List<int> GetDataIdsOfChannelsPerEnabledAxis()
	{
		List<int> val = new List<int>();
		if (HorizAxis != null && HorizAxis.g() != null && HorizAxisEnabled())
		{
			Setting setting = HorizAxis.h();
			if (setting != null)
			{
				val.Add(setting.A());
			}
		}
		if (VertAxis != null && VertAxis.g() != null && VertAxisEnabled())
		{
			Setting setting2 = VertAxis.h();
			if (setting2 != null)
			{
				val.Add(setting2.A());
			}
		}
		if (SliceAxis != null && SliceAxis.g() != null && SlicesEnabled())
		{
			Setting setting3 = SliceAxis.h();
			if (setting3 != null)
			{
				val.Add(setting3.A());
			}
		}
		return val;
	}

	public TableAxis GetAxisUsingChannel(int channelDataId)
	{
		if (ColumnsEnabled() && bAc.g() != null && bAc.h() != null && bAc.h().A() == channelDataId)
		{
			return bAc;
		}
		if (RowsEnabled() && bAD.g() != null && bAD.h() != null && bAD.h().A() == channelDataId)
		{
			return bAD;
		}
		if (SlicesEnabled() && bAd.g() != null && bAd.h() != null && bAd.h().A() == channelDataId)
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
			result = bAc.b();
		}
		return result;
	}

	public int RowCount()
	{
		int result = 1;
		if (RowsEnabled())
		{
			result = bAD.b();
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
			result = bAd.b();
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
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh())
			{
				bAC = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject is TableAxis)
			{
				TableAxis tableAxis = settingOrSpecialObject as TableAxis;
				if (tableAxis.A() == AxisType.Column)
				{
					bAc = tableAxis;
				}
				else if (tableAxis.A() == AxisType.Row)
				{
					bAD = tableAxis;
				}
				else if (tableAxis.A() == AxisType.Slice)
				{
					bAd = tableAxis;
				}
				tableAxis.i();
			}
		}
	}

	public void DeleteFromHorizAxis(int horizIndex)
	{
		bAC.az();
		for (int i = horizIndex + 1; i < HorizAxis.f().ax(); i++)
		{
			HorizAxis.G().a(i - 1, HorizAxis.G().m(i), true);
			for (int j = 0; j < SliceCount(); j++)
			{
				for (int k = 0; k < VertAxisCount(); k++)
				{
					if (bAH)
					{
						bAC.A(k, i - 1, j, bAC.B(k, i, j), true);
					}
					else
					{
						bAC.A(i - 1, k, j, bAC.B(i, k, j), true);
					}
				}
			}
		}
		HorizAxis.f().a(HorizAxis.f().ax() - 1, true);
		bAC.i(true);
		if (m_framework.awo == null || bAH)
		{
			return;
		}
		Setting setting = m_framework.awo.a(base.A());
		Setting setting2 = m_framework.awo.B(base.A());
		Setting setting3 = m_framework.awo.b(base.A());
		if (setting == null || setting2 == null || setting3 == null)
		{
			return;
		}
		int num = setting2.ax();
		int num2 = setting3.ax();
		if (num == num2 && num2 == horizIndex)
		{
			m_framework.awo.A(base.A());
			return;
		}
		if (num > horizIndex)
		{
			setting2.a(num - 1, true);
		}
		if (num2 > horizIndex)
		{
			setting3.a(num2 - 1, true);
		}
	}

	public void DeleteFromVertAxis(int vertIndex)
	{
		bAC.az();
		for (int i = vertIndex + 1; i < VertAxis.f().ax(); i++)
		{
			VertAxis.G().a(i - 1, VertAxis.G().m(i), true);
			for (int j = 0; j < SliceCount(); j++)
			{
				for (int k = 0; k < HorizAxisCount(); k++)
				{
					if (bAH)
					{
						bAC.A(i - 1, k, j, bAC.B(i, k, j), true);
					}
					else
					{
						bAC.A(k, i - 1, j, bAC.B(k, i, j), true);
					}
				}
			}
		}
		VertAxis.f().a(VertAxis.f().ax() - 1, true);
		bAC.i(true);
		if (m_framework.awo == null || bAH)
		{
			return;
		}
		Setting setting = m_framework.awo.a(base.A());
		if (setting != null)
		{
			int num = setting.ax();
			if (num == vertIndex)
			{
				m_framework.awo.A(base.A());
			}
			else if (num > vertIndex)
			{
				setting.a(num - 1, true);
			}
		}
	}

	public void DeleteSlice(int sliceIndex)
	{
		bAC.az();
		for (int i = sliceIndex + 1; i < bAd.f().ax(); i++)
		{
			bAd.G().a(i - 1, bAd.G().m(i), true);
			for (int j = 0; j < HorizAxisCount(); j++)
			{
				for (int k = 0; k < VertAxisCount(); k++)
				{
					if (bAH)
					{
						bAC.A(k, j, i - 1, bAC.B(k, j, i), true);
					}
					else
					{
						bAC.A(j, k, i - 1, bAC.B(j, k, i), true);
					}
				}
			}
		}
		bAd.f().a(bAd.f().ax() - 1, true);
		bAC.i(true);
	}

	public bool ValueExistsOnHorizAxis(int rawAxisValue)
	{
		for (int i = 0; i < HorizAxisCount(); i++)
		{
			int num = ((!bAH) ? bAc.G().m(i) : bAD.G().m(i));
			if (num == rawAxisValue)
			{
				return true;
			}
		}
		return false;
	}

	public bool ValueExistsOnVertAxis(int rawAxisValue)
	{
		for (int i = 0; i < VertAxisCount(); i++)
		{
			int num = ((!bAH) ? bAD.G().m(i) : bAc.G().m(i));
			if (num == rawAxisValue)
			{
				return true;
			}
		}
		return false;
	}

	public bool ValueExistsOnSliceAxis(int rawAxisValue)
	{
		for (int i = 0; i < SliceCount(); i++)
		{
			if (bAd.G().m(i) == rawAxisValue)
			{
				return true;
			}
		}
		return false;
	}

	public int InsertIntoHorizAxis(int newRawAxisValue)
	{
		int num = 0;
		for (int num2 = HorizAxisCount() - 1; num2 >= 0; num2--)
		{
			int num3 = HorizAxis.G().m(num2);
			if (newRawAxisValue > num3)
			{
				num = num2 + 1;
				break;
			}
		}
		bAC.az();
		if (bAH)
		{
			for (int num4 = bAD.f().ax() - 1; num4 >= num; num4--)
			{
				bAD.G().a(num4 + 1, bAD.G().m(num4), true);
				for (int i = 0; i < SliceCount(); i++)
				{
					for (int j = 0; j < VertAxisCount(); j++)
					{
						bAC.A(j, num4 + 1, i, bAC.B(j, num4, i), true);
					}
				}
			}
			bAD.G().a(num, newRawAxisValue, true);
			for (int k = 0; k < SliceCount(); k++)
			{
				for (int l = 0; l < VertAxisCount(); l++)
				{
					if (num == 0)
					{
						bAC.A(l, 0, k, bAC.B(l, 1, k), true);
					}
					else if (num == HorizAxisCount())
					{
						bAC.A(l, num, k, bAC.B(l, num - 1, k), true);
					}
					else
					{
						LineariseLeftToRight(l, num - 1, num + 1, null, forHorizAxisInsertion: true);
					}
				}
			}
			bAD.f().a(bAD.f().ax() + 1, true);
		}
		else
		{
			for (int num5 = bAc.f().ax() - 1; num5 >= num; num5--)
			{
				bAc.G().a(num5 + 1, bAc.G().m(num5), true);
				for (int m = 0; m < SliceCount(); m++)
				{
					for (int n = 0; n < VertAxisCount(); n++)
					{
						bAC.A(num5 + 1, n, m, bAC.B(num5, n, m), true);
					}
				}
			}
			bAc.G().a(num, newRawAxisValue, true);
			for (int num6 = 0; num6 < SliceCount(); num6++)
			{
				for (int num7 = 0; num7 < VertAxisCount(); num7++)
				{
					if (num == 0)
					{
						bAC.A(0, num7, num6, bAC.B(1, num7, num6), true);
					}
					else if (num == HorizAxisCount())
					{
						bAC.A(num, num7, num6, bAC.B(num - 1, num7, num6), true);
					}
					else
					{
						LineariseLeftToRight(num7, num - 1, num + 1, null, forHorizAxisInsertion: true);
					}
				}
			}
			bAc.f().a(bAc.f().ax() + 1, true);
		}
		bAC.i(true);
		if (m_framework.awo != null && !bAH)
		{
			Setting setting = m_framework.awo.a(base.A());
			Setting setting2 = m_framework.awo.B(base.A());
			Setting setting3 = m_framework.awo.b(base.A());
			if (setting != null && setting2 != null && setting3 != null)
			{
				int num8 = setting2.ax();
				int num9 = setting3.ax();
				if (num9 >= num)
				{
					setting3.a(num9 + 1, true);
				}
				if (num8 >= num)
				{
					setting2.a(num8 + 1, true);
				}
			}
		}
		return num;
	}

	public int InsertIntoVertAxis(int newRawAxisValue)
	{
		int num = 0;
		for (int num2 = VertAxisCount() - 1; num2 >= 0; num2--)
		{
			int num3 = VertAxis.G().m(num2);
			if (newRawAxisValue > num3)
			{
				num = num2 + 1;
				break;
			}
		}
		bAC.az();
		if (bAH)
		{
			for (int num4 = bAc.f().ax() - 1; num4 >= num; num4--)
			{
				bAc.G().a(num4 + 1, bAc.G().m(num4), true);
				for (int i = 0; i < SliceCount(); i++)
				{
					for (int j = 0; j < HorizAxisCount(); j++)
					{
						bAC.A(num4 + 1, j, i, bAC.B(num4, j, i), true);
					}
				}
			}
			bAc.G().a(num, newRawAxisValue, true);
			for (int k = 0; k < SliceCount(); k++)
			{
				for (int l = 0; l < HorizAxisCount(); l++)
				{
					if (num == 0)
					{
						bAC.A(0, l, k, bAC.B(1, l, k), true);
					}
					else if (num == VertAxisCount())
					{
						bAC.A(num, l, k, bAC.B(num - 1, l, k), true);
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
			bAc.f().a(bAc.f().ax() + 1, true);
		}
		else
		{
			for (int num6 = bAD.f().ax() - 1; num6 >= num; num6--)
			{
				bAD.G().a(num6 + 1, bAD.G().m(num6), true);
				for (int m = 0; m < SliceCount(); m++)
				{
					for (int n = 0; n < HorizAxisCount(); n++)
					{
						bAC.A(n, num6 + 1, m, bAC.B(n, num6, m), true);
					}
				}
			}
			bAD.G().a(num, newRawAxisValue, true);
			for (int num7 = 0; num7 < SliceCount(); num7++)
			{
				for (int num8 = 0; num8 < HorizAxisCount(); num8++)
				{
					if (num == 0)
					{
						bAC.A(num8, 0, num7, bAC.B(num8, 1, num7), true);
					}
					else if (num == VertAxisCount())
					{
						bAC.A(num8, num, num7, bAC.B(num8, num - 1, num7), true);
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
			bAD.f().a(bAD.f().ax() + 1, true);
		}
		bAC.i(true);
		if (m_framework.awo != null && !bAH)
		{
			Setting setting = m_framework.awo.a(base.A());
			if (setting != null)
			{
				int num10 = setting.ax();
				if (num10 >= num)
				{
					setting.a(num10 + 1, true);
				}
			}
		}
		return num;
	}

	public int InsertSlice(int newRawSliceValue)
	{
		int num = 0;
		for (int num2 = SliceCount() - 1; num2 >= 0; num2--)
		{
			int num3 = bAd.G().m(num2);
			if (newRawSliceValue > num3)
			{
				num = num2 + 1;
				break;
			}
		}
		bAC.az();
		for (int num4 = bAd.f().ax() - 1; num4 >= num; num4--)
		{
			bAd.G().a(num4 + 1, bAd.G().m(num4), true);
			for (int i = 0; i < HorizAxisCount(); i++)
			{
				for (int j = 0; j < VertAxisCount(); j++)
				{
					if (bAH)
					{
						bAC.A(j, i, num4 + 1, bAC.B(j, i, num4), true);
					}
					else
					{
						bAC.A(i, j, num4 + 1, bAC.B(i, j, num4), true);
					}
				}
			}
		}
		bAd.G().a(num, newRawSliceValue, true);
		for (int k = 0; k < HorizAxisCount(); k++)
		{
			for (int l = 0; l < VertAxisCount(); l++)
			{
				if (num == 0)
				{
					if (bAH)
					{
						bAC.A(l, k, 0, bAC.B(l, k, 1), true);
					}
					else
					{
						bAC.A(k, l, 0, bAC.B(k, l, 1), true);
					}
				}
				else if (num == SliceCount())
				{
					if (bAH)
					{
						bAC.A(l, k, num, bAC.B(l, k, num - 1), true);
					}
					else
					{
						bAC.A(k, l, num, bAC.B(k, l, num - 1), true);
					}
				}
				else if (bAH)
				{
					int num5 = bAC.B(l, k, num + 1) - bAC.B(l, k, num - 1);
					int num6 = bAd.G().m(num + 1) - bAd.G().m(num - 1);
					double num7 = (double)num5 / (double)num6;
					int num8 = bAC.B(l, k, num - 1) - (int)Math.Round(num7 * (double)bAd.G().m(num - 1));
					int num9 = bAd.G().m(num);
					int num10 = (int)Math.Round(num7 * (double)num9 + (double)num8);
					bAC.A(l, k, num, num10, true);
				}
				else
				{
					int num11 = bAC.B(k, l, num + 1) - bAC.B(k, l, num - 1);
					int num12 = bAd.G().m(num + 1) - bAd.G().m(num - 1);
					double num13 = (double)num11 / (double)num12;
					int num14 = bAC.B(k, l, num - 1) - (int)Math.Round(num13 * (double)bAd.G().m(num - 1));
					int num15 = bAd.G().m(num);
					int num16 = (int)Math.Round(num13 * (double)num15 + (double)num14);
					bAC.A(k, l, num, num16, true);
				}
			}
		}
		bAd.f().a(bAd.f().ax() + 1, true);
		bAC.i(true);
		return num;
	}

	public void GetOperatingPoint(ref int currentHoriz, ref int currentVert, ref int currentSlice)
	{
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		int num = HorizAxisCount();
		int num2 = VertAxisCount();
		int num3 = SliceCount();
		currentHoriz = 0;
		if (HorizAxisEnabled())
		{
			Setting setting = HorizAxis.h();
			if (setting != null)
			{
				int num4 = setting.ax();
				for (int i = 0; i < num; i++)
				{
					int num5 = HorizAxis.G().m(i);
					int num6 = ((i != 0) ? HorizAxis.G().m(i - 1) : num5);
					int num7 = ((i != num - 1) ? HorizAxis.G().m(i + 1) : num5);
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
			Setting setting2 = VertAxis.h();
			if (setting2 != null)
			{
				int num8 = setting2.ax();
				for (int j = 0; j < num2; j++)
				{
					if (bAg)
					{
						int num9 = VertAxis.G().m(num2 - 1 - j);
						int num10 = ((j != 0) ? VertAxis.G().m(num2 - 1 - (j - 1)) : num9);
						int num11 = ((j != num2 - 1) ? VertAxis.G().m(num2 - 1 - (j + 1)) : num9);
						if ((j == 0 && num8 > num10) || (j == num2 - 1 && num8 < num11) || (num8 <= num9 + (num10 - num9) / 2 && num8 >= num9 - (num9 - num11) / 2))
						{
							currentVert = j;
							break;
						}
					}
					else
					{
						int num9 = VertAxis.G().m(j);
						int num10 = ((j != 0) ? VertAxis.G().m(j - 1) : num9);
						int num11 = ((j != num2 - 1) ? VertAxis.G().m(j + 1) : num9);
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
		Setting setting3 = SliceAxis.h();
		if (setting3 == null)
		{
			return;
		}
		int num12 = setting3.ax();
		for (int k = 0; k < num3; k++)
		{
			int num13 = SliceAxis.G().m(k);
			int num14 = ((k != 0) ? SliceAxis.G().m(k - 1) : num13);
			int num15 = ((k != num3 - 1) ? SliceAxis.G().m(k + 1) : num13);
			if ((k == 0 && num12 < num14) || (k == num3 - 1 && num12 > num15) || (num12 >= num14 + (num13 - num14) / 2 && num12 <= num13 + (num15 - num13) / 2))
			{
				currentSlice = k;
				break;
			}
		}
	}

	public void IncreaseOrDecreaseSelectedCellValues(KeyEventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Invalid comparison between Unknown and I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Invalid comparison between Unknown and I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between Unknown and I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Invalid comparison between Unknown and I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Invalid comparison between Unknown and I4
		int num = bAC.aS();
		int num2 = aR();
		int num3 = ar();
		int num4 = 0;
		if (SlicesEnabled())
		{
			num4 = UserSliceIndex;
		}
		bAC.az();
		Enumerator<Point> enumerator = HorizVertIndexPerUserSelectedCell.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Point current = enumerator.Current;
				GetColumnIndexAndRowIndex(((Point)(ref current)).X, ((Point)(ref current)).Y, out var columnIndex, out var rowIndex);
				int num5 = bAC.B(columnIndex, rowIndex, num4);
				if ((e.Control && (int)e.KeyCode == 33) || (int)e.KeyData == 190)
				{
					num5 += bS.b(num);
				}
				else if ((int)e.KeyData == 33 || (int)e.KeyData == 222)
				{
					num5 += bS.C(num);
				}
				else if ((e.Shift && (int)e.KeyCode == 33) || (int)e.KeyData == 221)
				{
					num5 += bS.c(num);
				}
				else if ((e.Control && (int)e.KeyCode == 34) || (int)e.KeyData == 188)
				{
					num5 -= bS.b(num);
				}
				else if ((int)e.KeyData == 34 || (int)e.KeyData == 186)
				{
					num5 -= bS.C(num);
				}
				else if ((e.Shift && (int)e.KeyCode == 34) || (int)e.KeyData == 219)
				{
					num5 -= bS.c(num);
				}
				num5 = Math.Min(num3, Math.Max(num2, num5));
				if (bAE && columnIndex == 0)
				{
					num5 = 0;
				}
				if (bAe && rowIndex == 0)
				{
					num5 = 0;
				}
				bAC.A(columnIndex, rowIndex, num4, num5, true);
				if (m_framework.awo != null && !bAH)
				{
					Setting setting = m_framework.awo.a(base.A());
					if (setting != null && setting.ax() == rowIndex)
					{
						m_framework.awo.A(base.A());
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		bAC.i(true);
	}

	public void GetSelectedLeftRightTopBottomIndices(out int leftSelectedHoriz, out int rightSelectedHoriz, out int topSelectedVert, out int bottomSelectedVert)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		leftSelectedHoriz = 2147483647;
		rightSelectedHoriz = -2147483648;
		topSelectedVert = 2147483647;
		bottomSelectedVert = -2147483648;
		Enumerator<Point> enumerator = HorizVertIndexPerUserSelectedCell.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Point current = enumerator.Current;
				leftSelectedHoriz = Math.Min(leftSelectedHoriz, ((Point)(ref current)).X);
				rightSelectedHoriz = Math.Max(rightSelectedHoriz, ((Point)(ref current)).X);
				topSelectedVert = Math.Min(topSelectedVert, ((Point)(ref current)).Y);
				bottomSelectedVert = Math.Max(bottomSelectedVert, ((Point)(ref current)).Y);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void MoveSelectionLeft(Table tableForCompare)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == 0)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).Y;
		UserCurrentCellHorizVertIndex = new Point(leftSelectedHoriz - 1, num);
		List<Point> val = new List<Point>();
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			for (int j = leftSelectedHoriz - 1; j < rightSelectedHoriz; j++)
			{
				val.Add(new Point(j, i));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void MoveSelectionRight(Table tableForCompare)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		Table table = ((BM.QO != BM.b.BpG || tableForCompare == null) ? this : tableForCompare);
		if (rightSelectedHoriz == table.HorizAxisCount() - 1)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).Y;
		UserCurrentCellHorizVertIndex = new Point(rightSelectedHoriz + 1, num);
		List<Point> val = new List<Point>();
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			for (int j = leftSelectedHoriz + 1; j <= rightSelectedHoriz + 1; j++)
			{
				val.Add(new Point(j, i));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void MoveSelectionUp(Table tableForCompare)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == 0)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).X;
		UserCurrentCellHorizVertIndex = new Point(num, topSelectedVert - 1);
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert - 1; j < bottomSelectedVert; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void MoveSelectionDown(Table tableForCompare)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		Table table = ((BM.QO != BM.b.BpG || tableForCompare == null) ? this : tableForCompare);
		if (bottomSelectedVert == table.VertAxisCount() - 1)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).X;
		UserCurrentCellHorizVertIndex = new Point(num, bottomSelectedVert + 1);
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert + 1; j <= bottomSelectedVert + 1; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void IncreaseSelectionSizeOnLeft(Table tableForCompare)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == 0)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).Y;
		UserCurrentCellHorizVertIndex = new Point(leftSelectedHoriz - 1, num);
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz - 1; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void IncreaseSelectionSizeOnRight(Table tableForCompare)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		Table table = ((BM.QO != BM.b.BpG || tableForCompare == null) ? this : tableForCompare);
		if (rightSelectedHoriz == table.HorizAxisCount() - 1)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).Y;
		UserCurrentCellHorizVertIndex = new Point(rightSelectedHoriz + 1, num);
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz + 1; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void IncreaseSelectionSizeOnTop(Table tableForCompare)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == 0)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).X;
		UserCurrentCellHorizVertIndex = new Point(num, topSelectedVert - 1);
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert - 1; j <= bottomSelectedVert; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void IncreaseSelectionSizeOnBottom(Table tableForCompare)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		Table table = ((BM.QO != BM.b.BpG || tableForCompare == null) ? this : tableForCompare);
		if (bottomSelectedVert == table.VertAxisCount() - 1)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).X;
		UserCurrentCellHorizVertIndex = new Point(num, bottomSelectedVert + 1);
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert + 1; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void DecreaseSelectionSizeOnLeft()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == rightSelectedHoriz)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).X;
		userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num2 = ((Point)(ref userCurrentCellHorizVertIndex)).Y;
		if (num == leftSelectedHoriz)
		{
			UserCurrentCellHorizVertIndex = new Point(num + 1, num2);
		}
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz + 1; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void DecreaseSelectionSizeOnRight()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == rightSelectedHoriz)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).X;
		userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num2 = ((Point)(ref userCurrentCellHorizVertIndex)).Y;
		if (num == rightSelectedHoriz)
		{
			UserCurrentCellHorizVertIndex = new Point(num - 1, num2);
		}
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz - 1; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void DecreaseSelectionSizeOnTop()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).X;
		userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num2 = ((Point)(ref userCurrentCellHorizVertIndex)).Y;
		if (num2 == topSelectedVert)
		{
			UserCurrentCellHorizVertIndex = new Point(num, num2 + 1);
		}
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert + 1; j <= bottomSelectedVert; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	public void DecreaseSelectionSizeOnBottom()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			return;
		}
		Point userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num = ((Point)(ref userCurrentCellHorizVertIndex)).X;
		userCurrentCellHorizVertIndex = UserCurrentCellHorizVertIndex;
		int num2 = ((Point)(ref userCurrentCellHorizVertIndex)).Y;
		if (num2 == bottomSelectedVert)
		{
			UserCurrentCellHorizVertIndex = new Point(num, num2 - 1);
		}
		List<Point> val = new List<Point>();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			for (int j = topSelectedVert; j <= bottomSelectedVert - 1; j++)
			{
				val.Add(new Point(i, j));
			}
		}
		HorizVertIndexPerUserSelectedCell = val;
	}

	internal void A(Table P_0, List<DC.A>[,,] P_1)
	{
		int num = VertAxisCount();
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (leftSelectedHoriz == 0 || leftSelectedHoriz != rightSelectedHoriz)
		{
			return;
		}
		MoveSelectionLeft(P_0);
		int num2 = 0;
		if (SlicesEnabled())
		{
			num2 = UserSliceIndex;
		}
		int num3 = bAC.aS();
		Ck ck = BM.aM();
		ck?.A(bAC.A());
		bAC.az();
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			if (bAH)
			{
				if (bAg)
				{
					int currentTableRawCellValue;
					int compareTableRawCellValue;
					int num4 = ((BM.QO != 0 || P_0 == null) ? bAC.B(num - 1 - i, leftSelectedHoriz, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, leftSelectedHoriz, num - 1 - i, num2, out currentTableRawCellValue, out compareTableRawCellValue) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(leftSelectedHoriz - 1) : 0, VertAxisEnabled() ? VertAxis.G().m(num - 1 - i) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
					if (bAE && num - 1 - i == 0)
					{
						num4 = 0;
					}
					if (bAe && leftSelectedHoriz - 1 == 0)
					{
						num4 = 0;
					}
					bAC.A(num - 1 - i, leftSelectedHoriz - 1, num2, num4, true);
					if (P_1 != null)
					{
						P_1[num2, i, leftSelectedHoriz - 1].Clear();
					}
				}
				else
				{
					int currentTableRawCellValue2;
					int compareTableRawCellValue2;
					int num5 = ((BM.QO != 0 || P_0 == null) ? bAC.B(i, leftSelectedHoriz, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, leftSelectedHoriz, i, num2, out currentTableRawCellValue2, out compareTableRawCellValue2) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(leftSelectedHoriz - 1) : 0, VertAxisEnabled() ? VertAxis.G().m(i) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
					if (bAE && i == 0)
					{
						num5 = 0;
					}
					if (bAe && leftSelectedHoriz - 1 == 0)
					{
						num5 = 0;
					}
					bAC.A(i, leftSelectedHoriz - 1, num2, num5, true);
					if (P_1 != null)
					{
						P_1[num2, i, leftSelectedHoriz - 1].Clear();
					}
				}
				continue;
			}
			if (bAg)
			{
				int currentTableRawCellValue3;
				int compareTableRawCellValue3;
				int num6 = ((BM.QO != 0 || P_0 == null) ? bAC.B(leftSelectedHoriz, num - 1 - i, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, leftSelectedHoriz, num - 1 - i, num2, out currentTableRawCellValue3, out compareTableRawCellValue3) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(leftSelectedHoriz - 1) : 0, VertAxisEnabled() ? VertAxis.G().m(num - 1 - i) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
				if (bAE && leftSelectedHoriz - 1 == 0)
				{
					num6 = 0;
				}
				if (bAe && num - 1 - i == 0)
				{
					num6 = 0;
				}
				bAC.A(leftSelectedHoriz - 1, num - 1 - i, num2, num6, true);
				if (P_1 != null)
				{
					P_1[num2, i, leftSelectedHoriz - 1].Clear();
				}
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.a(base.A());
					if (setting != null && setting.ax() == num - 1 - i)
					{
						m_framework.awo.A(base.A());
					}
				}
				continue;
			}
			int currentTableRawCellValue4;
			int compareTableRawCellValue4;
			int num7 = ((BM.QO != 0 || P_0 == null) ? bAC.B(leftSelectedHoriz, i, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, leftSelectedHoriz, i, num2, out currentTableRawCellValue4, out compareTableRawCellValue4) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(leftSelectedHoriz - 1) : 0, VertAxisEnabled() ? VertAxis.G().m(i) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
			if (bAE && leftSelectedHoriz - 1 == 0)
			{
				num7 = 0;
			}
			if (bAe && i == 0)
			{
				num7 = 0;
			}
			bAC.A(leftSelectedHoriz - 1, i, num2, num7, true);
			if (P_1 != null)
			{
				P_1[num2, i, leftSelectedHoriz - 1].Clear();
			}
			if (m_framework.awo != null)
			{
				Setting setting2 = m_framework.awo.a(base.A());
				if (setting2 != null && setting2.ax() == i)
				{
					m_framework.awo.A(base.A());
				}
			}
		}
		bAC.i(true);
		ck?.B();
		BM.b(bAC.A());
	}

	internal void a(Table P_0, List<DC.A>[,,] P_1)
	{
		int num = VertAxisCount();
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (rightSelectedHoriz == HorizAxisCount() - 1 || leftSelectedHoriz != rightSelectedHoriz)
		{
			return;
		}
		MoveSelectionRight(P_0);
		int num2 = 0;
		if (SlicesEnabled())
		{
			num2 = UserSliceIndex;
		}
		int num3 = bAC.aS();
		Ck ck = BM.aM();
		ck?.A(bAC.A());
		bAC.az();
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			if (bAH)
			{
				if (bAg)
				{
					int currentTableRawCellValue;
					int compareTableRawCellValue;
					int num4 = ((BM.QO != 0 || P_0 == null) ? bAC.B(num - 1 - i, rightSelectedHoriz, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, rightSelectedHoriz, num - 1 - i, num2, out currentTableRawCellValue, out compareTableRawCellValue) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(rightSelectedHoriz + 1) : 0, VertAxisEnabled() ? VertAxis.G().m(num - 1 - i) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
					if (bAE && num - 1 - i == 0)
					{
						num4 = 0;
					}
					if (bAe && rightSelectedHoriz + 1 == 0)
					{
						num4 = 0;
					}
					bAC.A(num - 1 - i, rightSelectedHoriz + 1, num2, num4, true);
					if (P_1 != null)
					{
						P_1[num2, i, rightSelectedHoriz + 1].Clear();
					}
				}
				else
				{
					int currentTableRawCellValue2;
					int compareTableRawCellValue2;
					int num5 = ((BM.QO != 0 || P_0 == null) ? bAC.B(i, rightSelectedHoriz, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, rightSelectedHoriz, i, num2, out currentTableRawCellValue2, out compareTableRawCellValue2) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(rightSelectedHoriz + 1) : 0, VertAxisEnabled() ? VertAxis.G().m(i) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
					if (bAE && i == 0)
					{
						num5 = 0;
					}
					if (bAe && rightSelectedHoriz + 1 == 0)
					{
						num5 = 0;
					}
					bAC.A(i, rightSelectedHoriz + 1, num2, num5, true);
					if (P_1 != null)
					{
						P_1[num2, i, rightSelectedHoriz + 1].Clear();
					}
				}
				continue;
			}
			if (bAg)
			{
				int currentTableRawCellValue3;
				int compareTableRawCellValue3;
				int num6 = ((BM.QO != 0 || P_0 == null) ? bAC.B(rightSelectedHoriz, num - 1 - i, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, rightSelectedHoriz, num - 1 - i, num2, out currentTableRawCellValue3, out compareTableRawCellValue3) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(rightSelectedHoriz + 1) : 0, VertAxisEnabled() ? VertAxis.G().m(num - 1 - i) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
				if (bAE && rightSelectedHoriz + 1 == 0)
				{
					num6 = 0;
				}
				if (bAe && num - 1 - i == 0)
				{
					num6 = 0;
				}
				bAC.A(rightSelectedHoriz + 1, num - 1 - i, num2, num6, true);
				if (P_1 != null)
				{
					P_1[num2, i, rightSelectedHoriz + 1].Clear();
				}
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.a(base.A());
					if (setting != null && setting.ax() == num - 1 - i)
					{
						m_framework.awo.A(base.A());
					}
				}
				continue;
			}
			int currentTableRawCellValue4;
			int compareTableRawCellValue4;
			int num7 = ((BM.QO != 0 || P_0 == null) ? bAC.B(rightSelectedHoriz, i, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, rightSelectedHoriz, i, num2, out currentTableRawCellValue4, out compareTableRawCellValue4) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(rightSelectedHoriz + 1) : 0, VertAxisEnabled() ? VertAxis.G().m(i) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
			if (bAE && rightSelectedHoriz + 1 == 0)
			{
				num7 = 0;
			}
			if (bAe && i == 0)
			{
				num7 = 0;
			}
			bAC.A(rightSelectedHoriz + 1, i, num2, num7, true);
			if (P_1 != null)
			{
				P_1[num2, i, rightSelectedHoriz + 1].Clear();
			}
			if (m_framework.awo != null)
			{
				Setting setting2 = m_framework.awo.a(base.A());
				if (setting2 != null && setting2.ax() == i)
				{
					m_framework.awo.A(base.A());
				}
			}
		}
		bAC.i(true);
		ck?.B();
		BM.b(bAC.A());
	}

	internal void B(Table P_0, List<DC.A>[,,] P_1)
	{
		int num = VertAxisCount();
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == 0 || topSelectedVert != bottomSelectedVert)
		{
			return;
		}
		MoveSelectionUp(P_0);
		int num2 = 0;
		if (SlicesEnabled())
		{
			num2 = UserSliceIndex;
		}
		int num3 = bAC.aS();
		Ck ck = BM.aM();
		ck?.A(bAC.A());
		bAC.az();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			if (bAH)
			{
				if (bAg)
				{
					int currentTableRawCellValue;
					int compareTableRawCellValue;
					int num4 = ((BM.QO != 0 || P_0 == null) ? bAC.B(num - 1 - topSelectedVert, i, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, i, num - 1 - topSelectedVert, num2, out currentTableRawCellValue, out compareTableRawCellValue) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(i) : 0, VertAxisEnabled() ? VertAxis.G().m(num - 1 - (topSelectedVert - 1)) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
					if (bAE && num - 1 - (topSelectedVert - 1) == 0)
					{
						num4 = 0;
					}
					if (bAe && i == 0)
					{
						num4 = 0;
					}
					bAC.A(num - 1 - (topSelectedVert - 1), i, num2, num4, true);
					if (P_1 != null)
					{
						P_1[num2, topSelectedVert - 1, i].Clear();
					}
				}
				else
				{
					int currentTableRawCellValue2;
					int compareTableRawCellValue2;
					int num5 = ((BM.QO != 0 || P_0 == null) ? bAC.B(topSelectedVert, i, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, i, topSelectedVert, num2, out currentTableRawCellValue2, out compareTableRawCellValue2) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(i) : 0, VertAxisEnabled() ? VertAxis.G().m(topSelectedVert - 1) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
					if (bAE && topSelectedVert - 1 == 0)
					{
						num5 = 0;
					}
					if (bAe && i == 0)
					{
						num5 = 0;
					}
					bAC.A(topSelectedVert - 1, i, num2, num5, true);
					if (P_1 != null)
					{
						P_1[num2, topSelectedVert - 1, i].Clear();
					}
				}
				continue;
			}
			if (bAg)
			{
				int currentTableRawCellValue3;
				int compareTableRawCellValue3;
				int num6 = ((BM.QO != 0 || P_0 == null) ? bAC.B(i, num - 1 - topSelectedVert, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, i, num - 1 - topSelectedVert, num2, out currentTableRawCellValue3, out compareTableRawCellValue3) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(i) : 0, VertAxisEnabled() ? VertAxis.G().m(num - 1 - (topSelectedVert - 1)) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
				if (bAE && i == 0)
				{
					num6 = 0;
				}
				if (bAe && num - 1 - (topSelectedVert - 1) == 0)
				{
					num6 = 0;
				}
				bAC.A(i, num - 1 - (topSelectedVert - 1), num2, num6, true);
				if (P_1 != null)
				{
					P_1[num2, topSelectedVert - 1, i].Clear();
				}
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.a(base.A());
					if (setting != null && setting.ax() == num - 1 - (topSelectedVert - 1))
					{
						m_framework.awo.A(base.A());
					}
				}
				continue;
			}
			int currentTableRawCellValue4;
			int compareTableRawCellValue4;
			int num7 = ((BM.QO != 0 || P_0 == null) ? bAC.B(i, topSelectedVert, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, i, topSelectedVert, num2, out currentTableRawCellValue4, out compareTableRawCellValue4) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(i) : 0, VertAxisEnabled() ? VertAxis.G().m(topSelectedVert - 1) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
			if (bAE && i == 0)
			{
				num7 = 0;
			}
			if (bAe && topSelectedVert - 1 == 0)
			{
				num7 = 0;
			}
			bAC.A(i, topSelectedVert - 1, num2, num7, true);
			if (P_1 != null)
			{
				P_1[num2, topSelectedVert - 1, i].Clear();
			}
			if (m_framework.awo != null)
			{
				Setting setting2 = m_framework.awo.a(base.A());
				if (setting2 != null && setting2.ax() == topSelectedVert - 1)
				{
					m_framework.awo.A(base.A());
				}
			}
		}
		bAC.i(true);
		ck?.B();
		BM.b(bAC.A());
	}

	internal void b(Table P_0, List<DC.A>[,,] P_1)
	{
		int num = VertAxisCount();
		GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (bottomSelectedVert == VertAxisCount() - 1 || topSelectedVert != bottomSelectedVert)
		{
			return;
		}
		MoveSelectionDown(P_0);
		int num2 = 0;
		if (SlicesEnabled())
		{
			num2 = UserSliceIndex;
		}
		int num3 = bAC.aS();
		Ck ck = BM.aM();
		ck?.A(bAC.A());
		bAC.az();
		for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
		{
			if (bAH)
			{
				if (bAg)
				{
					int currentTableRawCellValue;
					int compareTableRawCellValue;
					int num4 = ((BM.QO != 0 || P_0 == null) ? bAC.B(num - 1 - bottomSelectedVert, i, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, i, num - 1 - bottomSelectedVert, num2, out currentTableRawCellValue, out compareTableRawCellValue) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(i) : 0, VertAxisEnabled() ? VertAxis.G().m(num - 1 - (bottomSelectedVert + 1)) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
					if (bAE && num - 1 - (bottomSelectedVert + 1) == 0)
					{
						num4 = 0;
					}
					if (bAe && i == 0)
					{
						num4 = 0;
					}
					bAC.A(num - 1 - (bottomSelectedVert + 1), i, num2, num4, true);
					if (P_1 != null)
					{
						P_1[num2, bottomSelectedVert + 1, i].Clear();
					}
				}
				else
				{
					int currentTableRawCellValue2;
					int compareTableRawCellValue2;
					int num5 = ((BM.QO != 0 || P_0 == null) ? bAC.B(bottomSelectedVert, i, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, i, bottomSelectedVert, num2, out currentTableRawCellValue2, out compareTableRawCellValue2) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(i) : 0, VertAxisEnabled() ? VertAxis.G().m(bottomSelectedVert + 1) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
					if (bAE && bottomSelectedVert + 1 == 0)
					{
						num5 = 0;
					}
					if (bAe && i == 0)
					{
						num5 = 0;
					}
					bAC.A(bottomSelectedVert + 1, i, num2, num5, true);
					if (P_1 != null)
					{
						P_1[num2, bottomSelectedVert + 1, i].Clear();
					}
				}
				continue;
			}
			if (bAg)
			{
				int currentTableRawCellValue3;
				int compareTableRawCellValue3;
				int num6 = ((BM.QO != 0 || P_0 == null) ? bAC.B(i, num - 1 - bottomSelectedVert, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, i, num - 1 - bottomSelectedVert, num2, out currentTableRawCellValue3, out compareTableRawCellValue3) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(i) : 0, VertAxisEnabled() ? VertAxis.G().m(num - 1 - (bottomSelectedVert + 1)) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
				if (bAE && i == 0)
				{
					num6 = 0;
				}
				if (bAe && num - 1 - (bottomSelectedVert + 1) == 0)
				{
					num6 = 0;
				}
				bAC.A(i, num - 1 - (bottomSelectedVert + 1), num2, num6, true);
				if (P_1 != null)
				{
					P_1[num2, bottomSelectedVert + 1, i].Clear();
				}
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.a(base.A());
					if (setting != null && setting.ax() == num - 1 - (bottomSelectedVert + 1))
					{
						m_framework.awo.A(base.A());
					}
				}
				continue;
			}
			int currentTableRawCellValue4;
			int compareTableRawCellValue4;
			int num7 = ((BM.QO != 0 || P_0 == null) ? bAC.B(i, bottomSelectedVert, num2) : bS.A(GetCellDifferenceDisplayValue(P_0, i, bottomSelectedVert, num2, out currentTableRawCellValue4, out compareTableRawCellValue4) + bS.A(P_0.GetInterpolatedTableDataRawValue(HorizAxisEnabled() ? HorizAxis.G().m(i) : 0, VertAxisEnabled() ? VertAxis.G().m(bottomSelectedVert + 1) : 0, SlicesEnabled() ? SliceAxis.G().m(num2) : 0), num3, -1), num3));
			if (bAE && i == 0)
			{
				num7 = 0;
			}
			if (bAe && bottomSelectedVert + 1 == 0)
			{
				num7 = 0;
			}
			bAC.A(i, bottomSelectedVert + 1, num2, num7, true);
			if (P_1 != null)
			{
				P_1[num2, bottomSelectedVert + 1, i].Clear();
			}
			if (m_framework.awo != null)
			{
				Setting setting2 = m_framework.awo.a(base.A());
				if (setting2 != null && setting2.ax() == bottomSelectedVert + 1)
				{
					m_framework.awo.A(base.A());
				}
			}
		}
		bAC.i(true);
		ck?.B();
		BM.b(bAC.A());
	}

	public double GetCellDifferenceDisplayValue(Table tableForCompare, int horizIndex, int vertIndex, int sliceIndex, out int currentTableRawCellValue, out int compareTableRawCellValue)
	{
		if (tableForCompare != null)
		{
			int horizRawValue = 0;
			if (HorizAxisEnabled())
			{
				horizRawValue = HorizAxis.G().m(horizIndex);
			}
			int vertRawValue = 0;
			if (VertAxisEnabled())
			{
				vertRawValue = VertAxis.G().m(vertIndex);
			}
			int sliceRawValue = 0;
			if (SlicesEnabled())
			{
				sliceRawValue = SliceAxis.G().m(sliceIndex);
			}
			currentTableRawCellValue = GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue);
			compareTableRawCellValue = tableForCompare.GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue);
			int num = TableDataSetting.aS();
			double num2 = bS.A(currentTableRawCellValue, num, -1);
			double num3 = bS.A(compareTableRawCellValue, num, -1);
			return num2 - num3;
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
				horizRawValue = HorizAxis.G().m(horizIndex);
			}
			int vertRawValue = 0;
			if (VertAxisEnabled())
			{
				vertRawValue = ((!bAg) ? VertAxis.G().m(vertIndex) : VertAxis.G().m(vertCount - 1 - vertIndex));
			}
			int num = 0;
			if (SlicesEnabled())
			{
				num = SliceAxis.G().m(sliceIndex);
			}
			int interpolatedTableDataRawValue = GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, num);
			GetColumnIndexAndRowIndex(horizIndex, vertIndex, out var columnIndex, out var rowIndex);
			int columnLookupValue = 0;
			if (ColumnsEnabled())
			{
				columnLookupValue = ColumnAxis.G().m(columnIndex);
			}
			int rowLookupValue = 0;
			if (RowsEnabled())
			{
				rowLookupValue = RowAxis.G().m(rowIndex);
			}
			int num2 = (int)GetInterpolatedValue(cellsPerSliceRowColumnForCompare, columnAxisValuesForCompare, rowAxisValuesForCompare, sliceAxisValuesForCompare, columnLookupValue, rowLookupValue, num);
			int num3 = TableDataSetting.aS();
			double num4 = bS.A(interpolatedTableDataRawValue, num3, -1);
			double num5 = bS.A(num2, num3, -1);
			return num4 - num5;
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
		int num3 = bAC.aS();
		string text = string.Empty;
		for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
		{
			for (int j = leftSelectedHoriz; j <= rightSelectedHoriz; j++)
			{
				int num4 = 0;
				if (tableForCompare != null)
				{
					num4 = ((!bAg) ? bS.A(GetCellDifferenceDisplayValue(tableForCompare, j, i, num, out var _, out var _), num3) : bS.A(GetCellDifferenceDisplayValue(tableForCompare, j, num2 - 1 - i, num, out var _, out var _), num3));
				}
				int num5;
				if (BM.QO == BM.b.BpF && tableForCompare != null)
				{
					num5 = num4;
				}
				else
				{
					GetColumnIndexAndRowIndex(j, i, out var columnIndex, out var rowIndex);
					num5 = bAC.B(columnIndex, rowIndex, num);
				}
				text += bS.a(num5, num3, -1);
				if (j != rightSelectedHoriz)
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alU();
				}
			}
			if (i != bottomSelectedVert)
			{
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
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

	internal void C(Table P_0, List<DC.A>[,,] P_1)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		int num = 0;
		int num2 = 0;
		try
		{
			if (Clipboard.ContainsText())
			{
				text = Clipboard.GetText();
			}
			if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiJ()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI()))
			{
				text = text.Substring(0, text.Length - 2);
			}
			else if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VU()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()))
			{
				text = text.Substring(0, text.Length - 1);
			}
			num = text.Split('\n', (StringSplitOptions)0).Length;
			num2 = 0;
			for (int i = 0; i < num; i++)
			{
				int num3 = text.Split('\n', (StringSplitOptions)0)[i].Split('\t', (StringSplitOptions)0).Length;
				if (i == 0)
				{
					num2 = num3;
				}
				else if (num3 != num2)
				{
					throw new System.Exception();
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
		Ck ck = BM.aM();
		ck?.A(bAC.A());
		bAC.az();
		int num4 = bAC.aS();
		int num5 = aR();
		int num6 = ar();
		int num7 = 0;
		if (SlicesEnabled())
		{
			num7 = UserSliceIndex;
		}
		int num8 = HorizAxisCount();
		int num9 = VertAxisCount();
		int num10 = 2147483647;
		int num11 = 2147483647;
		Enumerator<Point> enumerator = HorizVertIndexPerUserSelectedCell.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Point current = enumerator.Current;
				num10 = Math.Min(num10, ((Point)(ref current)).X);
				num11 = Math.Min(num11, ((Point)(ref current)).Y);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		int num12 = Math.Min(num8, num10 + num2) - 1;
		int num13 = Math.Min(num9, num11 + num) - 1;
		for (int j = num11; j <= num13; j++)
		{
			for (int k = num10; k <= num12; k++)
			{
				string text2 = text.Split('\n', (StringSplitOptions)0)[j - num11].Split('\t', (StringSplitOptions)0)[k - num10];
				if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VU()))
				{
					text2 = text2.Substring(0, text2.Length - 1);
				}
				try
				{
					int num16;
					if (BM.QO == BM.b.BpF && P_0 != null)
					{
						int horizRawValue = ((HorizAxis != null && HorizAxis.G() != null) ? HorizAxis.G().m(k) : 0);
						int vertRawValue = ((VertAxis != null && VertAxis.G() != null) ? ((!bAg) ? VertAxis.G().m(j) : VertAxis.G().m(num9 - 1 - j)) : 0);
						int sliceRawValue = ((SliceAxis != null && SliceAxis.G() != null) ? SliceAxis.G().m(num7) : 0);
						double num14 = bS.A(P_0.GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue), num4, -1);
						double num15 = double.Parse(text2, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture);
						num16 = bS.A(num14 + num15, num4);
					}
					else
					{
						num16 = bS.A(text2, num4);
					}
					num16 = Math.Min(Math.Max(num16, num5), num6);
					GetColumnIndexAndRowIndex(k, j, out var columnIndex, out var rowIndex);
					bAC.A(columnIndex, rowIndex, num7, num16, true);
					if (P_1 != null)
					{
						P_1[num7, j, k].Clear();
					}
					if (m_framework.awo != null && !bAH)
					{
						Setting setting = m_framework.awo.a(base.A());
						if (setting != null && setting.ax() == rowIndex)
						{
							m_framework.awo.A(base.A());
						}
					}
				}
				catch
				{
				}
			}
		}
		bAC.i(true);
		ck?.B();
		BM.b(bAC.A());
	}

	internal new void A()
	{
		try
		{
			string text = string.Empty;
			TableAxis[] array = new TableAxis[3] { SliceAxis, RowAxis, ColumnAxis };
			foreach (TableAxis tableAxis in array)
			{
				if (tableAxis != null && tableAxis.B())
				{
					text = ((tableAxis.g() == null) ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bij() + (int)tableAxis.A() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiK()) : string.Concat(new string[6]
					{
						text,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bij(),
						((int)tableAxis.A()).ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ(),
						tableAxis.g().ax().ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()
					}));
					text = ((tableAxis.H() == null) ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bik() + (int)tableAxis.A() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiL()) : string.Concat(new string[6]
					{
						text,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bik(),
						((int)tableAxis.A()).ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ(),
						tableAxis.H().ax().ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()
					}));
					if (tableAxis.G() == null)
					{
						return;
					}
					text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bil() + (int)tableAxis.A() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
					int num = tableAxis.b();
					for (int j = 0; j < num; j++)
					{
						text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alU() + tableAxis.G().m(j);
					}
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
				}
			}
			text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiM() + bAC.aS() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
			text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bim();
			int num2 = SliceCount();
			int num3 = RowCount();
			int num4 = ColumnCount();
			for (int k = 0; k < num2; k++)
			{
				for (int l = 0; l < num3; l++)
				{
					for (int m = 0; m < num4; m++)
					{
						text += bAC.B(m, l, k);
						if (m < num4 - 1)
						{
							text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alU();
						}
					}
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
				}
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
			}
			if (!string.IsNullOrEmpty(text))
			{
				Clipboard.SetText(text);
			}
		}
		catch
		{
		}
	}

	internal new A a()
	{
		try
		{
			if (Clipboard.ContainsText())
			{
				string text = Clipboard.GetText();
				A a = new A();
				int num = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiM());
				if (num != -1)
				{
					int num2 = num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiM().Length;
					int num3 = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy(), num2) - num2;
					a.bbk = (UnitType)int.Parse(text.Substring(num2, num3));
					int num4 = 0;
					do
					{
						int num5 = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bij(), num4);
						if (num5 != -1)
						{
							int num6 = int.Parse(text.Substring(num5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bij().Length, 1));
							int num7 = num5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bij().Length + 3;
							int num8 = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy(), num7) - num7;
							int num9 = int.Parse(text.Substring(num7, num8));
							a.bbJ[(AxisType)num6] = num9;
							num4 = num5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bij().Length;
						}
						else
						{
							num4 = -1;
						}
					}
					while (num4 != -1);
					num4 = 0;
					do
					{
						int num10 = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bik(), num4);
						if (num10 != -1)
						{
							int num11 = int.Parse(text.Substring(num10 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bik().Length, 1));
							int num12 = int.Parse(text.Substring(num10 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bik().Length + 3, 1));
							a.bbj[(AxisType)num11] = (AxisBehaviour)num12;
							num4 = num10 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bik().Length;
						}
						else
						{
							num4 = -1;
						}
					}
					while (num4 != -1);
					num4 = 0;
					do
					{
						int num13 = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bil(), num4);
						if (num13 != -1)
						{
							int num14 = int.Parse(text.Substring(num13 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bil().Length, 1));
							int num15 = num13 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bil().Length + 3;
							int num16 = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy(), num15) - num15;
							string[] array = text.Substring(num15, num16).Split(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alU(), (StringSplitOptions)0);
							a.bbK[(AxisType)num14] = new List<int>();
							string[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								int num17 = int.Parse(array2[i]);
								a.bbK[(AxisType)num14].Add(num17);
							}
							num4 = num13 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bil().Length;
						}
						else
						{
							num4 = -1;
						}
					}
					while (num4 != -1);
					int num18 = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bim());
					if (num18 != -1)
					{
						string text2 = text.Substring(num18 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bim().Length);
						a.bbL = new List<List<List<int>>>();
						int num19 = 0;
						int num20 = 0;
						int num21 = 0;
						num4 = 0;
						do
						{
							int num22 = text2.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy(), num4);
							if (num22 != -1)
							{
								if (a.bbL.Count == num19)
								{
									a.bbL.Add(new List<List<int>>());
								}
								int num23 = num22 - num4;
								if (num23 != 0)
								{
									if (a.bbL[num19].Count == num20)
									{
										a.bbL[num19].Add(new List<int>());
									}
									string[] array2 = text2.Substring(num4, num23).Split(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alU(), (StringSplitOptions)0);
									for (int i = 0; i < array2.Length; i++)
									{
										int num24 = int.Parse(array2[i]);
										a.bbL[num19][num20].Add(num24);
										num21++;
									}
									num20++;
									num21 = 0;
								}
								else
								{
									num19++;
									num20 = 0;
									num21 = 0;
								}
								num4 = num22 + 1;
							}
							else
							{
								num4 = -1;
							}
						}
						while (num4 != -1);
						return a;
					}
				}
			}
		}
		catch
		{
		}
		return null;
	}

	internal bool A(A P_0, out string P_1)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		P_1 = null;
		try
		{
			if (P_0.bbk != (UnitType)bAC.aS())
			{
				P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiN();
				return false;
			}
			TableAxis[] array = new TableAxis[3] { SliceAxis, RowAxis, ColumnAxis };
			Enumerator<AxisType, List<int>> enumerator = P_0.bbK.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = (int)enumerator.Current;
					if (array[current] == null || array[current].G() == null)
					{
						P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bin();
						return false;
					}
					if (P_0.bbK[(AxisType)current].Count > bAC.av()[current])
					{
						P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiO();
						return false;
					}
					if (array[current].E() == 0)
					{
						continue;
					}
					for (int i = 0; i < P_0.bbK[(AxisType)current].Count; i++)
					{
						if (P_0.bbK[(AxisType)current][i] != array[current].G().m(i))
						{
							P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bio();
							return false;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<AxisType, int> enumerator2 = P_0.bbJ.Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current2 = (int)enumerator2.Current;
					if (array[current2] == null || array[current2].g() == null)
					{
						P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bin();
						return false;
					}
					if (array[current2].e() != 0 && P_0.bbJ[(AxisType)current2] != array[current2].g().ax())
					{
						P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiP();
						return false;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			if (P_0.bbL.Count == 0 || P_0.bbL[0].Count == 0 || P_0.bbL[0][0].Count == 0)
			{
				P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bip();
				return false;
			}
			if (P_0.bbL.Count > bAC.av()[0] || P_0.bbL[0].Count > bAC.av()[1] || P_0.bbL[0][0].Count > bAC.av()[2])
			{
				P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiQ();
				return false;
			}
			for (int j = 0; j < P_0.bbL.Count; j++)
			{
				if (P_0.bbL[j].Count != P_0.bbL[0].Count)
				{
					P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biq();
					return false;
				}
				for (int k = 0; k < P_0.bbL[j].Count; k++)
				{
					if (P_0.bbL[j][k].Count != P_0.bbL[0][0].Count)
					{
						P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biq();
						return false;
					}
				}
			}
			return true;
		}
		catch
		{
			P_1 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biq();
			return false;
		}
	}

	internal void A(A P_0)
	{
		if (P_0 == null)
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
			if (P_0.bbK.ContainsKey(tableAxis.A()) && P_0.bbK[tableAxis.A()].Count != 0)
			{
				if (tableAxis.F() != null)
				{
					tableAxis.F().a(1, true);
				}
				if (tableAxis.g() != null)
				{
					tableAxis.g().a(P_0.bbJ[tableAxis.A()], true);
				}
				if (tableAxis.H() != null)
				{
					tableAxis.H().a((int)P_0.bbj[tableAxis.A()], true);
				}
				if (tableAxis.G() != null && tableAxis.f() != null)
				{
					tableAxis.f().a(P_0.bbK[tableAxis.A()].Count, true);
					tableAxis.G().az();
					for (int j = 0; j < P_0.bbK[tableAxis.A()].Count; j++)
					{
						tableAxis.G().a(j, P_0.bbK[tableAxis.A()][j], true);
					}
					tableAxis.G().i(true);
				}
			}
			else if (tableAxis.F() != null)
			{
				tableAxis.F().a(0, true);
			}
		}
		if (bAC == null)
		{
			return;
		}
		bAC.az();
		for (int k = 0; k < P_0.bbL.Count; k++)
		{
			for (int l = 0; l < P_0.bbL[k].Count; l++)
			{
				for (int m = 0; m < P_0.bbL[k][l].Count; m++)
				{
					bAC.A(m, l, k, P_0.bbL[k][l][m], true);
				}
			}
		}
		bAC.i(true);
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
		if (BM.QO == BM.b.BpF && tableForCompare != null)
		{
			num7 = GetCellDifferenceDisplayValue(tableForCompare, horizIndex, num6, num, out var currentTableRawCellValue, out var compareTableRawCellValue);
			num8 = GetCellDifferenceDisplayValue(tableForCompare, horizIndex, num2, num, out currentTableRawCellValue, out compareTableRawCellValue);
		}
		else if (bAH)
		{
			num7 = bAC.B(num6, horizIndex, num);
			num8 = bAC.B(num2, horizIndex, num);
		}
		else
		{
			num7 = bAC.B(horizIndex, num6, num);
			num8 = bAC.B(horizIndex, num2, num);
		}
		double num9 = num8 - num7;
		double num10 = VertAxis.G().m(num2) - VertAxis.G().m(num6);
		double num11 = num9 / num10;
		double num12 = ((BM.QO != 0 || tableForCompare == null) ? (num7 - Math.Round(num11 * (double)VertAxis.G().m(num6))) : (num7 - num11 * (double)VertAxis.G().m(num6)));
		int num13 = bAC.aS();
		for (int i = 1; i < num4 - 1; i++)
		{
			int num14 = ((!bAg) ? (num3 + i) : (num5 - 1 - (num3 + i)));
			int num15 = VertAxis.G().m(num14);
			int num18;
			if (BM.QO == BM.b.BpF && tableForCompare != null)
			{
				GetCellDifferenceDisplayValue(tableForCompare, horizIndex, num14, num, out var _, out var compareTableRawCellValue2);
				double num16 = bS.A(compareTableRawCellValue2, num13, -1);
				double num17 = num11 * (double)num15 + num12;
				num18 = bS.A(num16 + num17, num13);
			}
			else
			{
				num18 = (int)Math.Round(num11 * (double)num15 + num12);
			}
			if (bAH)
			{
				bAC.A(num14, horizIndex, num, num18, true);
			}
			else
			{
				bAC.A(horizIndex, num14, num, num18, true);
			}
			if (m_framework.awo != null && !bAH)
			{
				Setting setting = m_framework.awo.a(base.A());
				if (setting != null && setting.ax() == num14)
				{
					m_framework.awo.A(base.A());
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
		if (BM.QO == BM.b.BpF && tableForCompare != null)
		{
			num7 = GetCellDifferenceDisplayValue(tableForCompare, num3, num6, num, out var currentTableRawCellValue, out var compareTableRawCellValue);
			num8 = GetCellDifferenceDisplayValue(tableForCompare, num2, num6, num, out currentTableRawCellValue, out compareTableRawCellValue);
		}
		else if (bAH)
		{
			num7 = bAC.B(num6, num3, num);
			num8 = bAC.B(num6, num2, num);
		}
		else
		{
			num7 = bAC.B(num3, num6, num);
			num8 = bAC.B(num2, num6, num);
		}
		double num9 = num8 - num7;
		double num10 = HorizAxis.G().m(num2) - HorizAxis.G().m(num3);
		double num11 = num9 / num10;
		double num12 = ((BM.QO != 0 || tableForCompare == null) ? (num7 - Math.Round(num11 * (double)HorizAxis.G().m(num3))) : (num7 - num11 * (double)HorizAxis.G().m(num3)));
		int num13 = bAC.aS();
		for (int i = 1; i < num4 - 1; i++)
		{
			int num14 = HorizAxis.G().m(num3 + i);
			int num17;
			if (BM.QO == BM.b.BpF && tableForCompare != null)
			{
				GetCellDifferenceDisplayValue(tableForCompare, num3 + i, num6, num, out var _, out var compareTableRawCellValue2);
				double num15 = bS.A(compareTableRawCellValue2, num13, -1);
				double num16 = num11 * (double)num14 + num12;
				num17 = bS.A(num15 + num16, num13);
			}
			else
			{
				num17 = (int)Math.Round(num11 * (double)num14 + num12);
			}
			if (bAH)
			{
				bAC.A(num6, num3 + i, num, num17, true);
			}
			else
			{
				bAC.A(num3 + i, num6, num, num17, true);
			}
			if (!forHorizAxisInsertion && m_framework.awo != null && !bAH)
			{
				Setting setting = m_framework.awo.a(base.A());
				if (setting != null && setting.ax() == num6)
				{
					m_framework.awo.A(base.A());
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
		int num9 = bAC.aS();
		if (bAH)
		{
			for (int i = 0; i < num7; i++)
			{
				int num10 = ((!bAg) ? (num6 + i) : (num8 - 1 - (num6 + i)));
				double num11;
				double num12;
				if (BM.QO == BM.b.BpF && tableForCompare != null)
				{
					num11 = GetCellDifferenceDisplayValue(tableForCompare, num3, num10, num, out var currentTableRawCellValue, out var compareTableRawCellValue);
					num12 = GetCellDifferenceDisplayValue(tableForCompare, num2, num10, num, out currentTableRawCellValue, out compareTableRawCellValue);
				}
				else
				{
					num11 = bAC.B(num10, num3, num);
					num12 = bAC.B(num10, num2, num);
				}
				double num13 = num12 - num11;
				double num14 = bAD.G().m(num2) - bAD.G().m(num3);
				double num15 = num13 / num14;
				double num16 = ((BM.QO != 0 || tableForCompare == null) ? (num11 - Math.Round(num15 * (double)bAD.G().m(num3))) : (num11 - num15 * (double)bAD.G().m(num3)));
				for (int j = 1; j < num4 - 1; j++)
				{
					int num17 = bAD.G().m(num3 + j);
					int num20;
					if (BM.QO == BM.b.BpF && tableForCompare != null)
					{
						GetCellDifferenceDisplayValue(tableForCompare, num3 + j, num10, num, out var _, out var compareTableRawCellValue2);
						double num18 = bS.A(compareTableRawCellValue2, num9, -1);
						double num19 = num15 * (double)num17 + num16;
						num20 = bS.A(num18 + num19, num9);
					}
					else
					{
						num20 = (int)Math.Round(num15 * (double)num17 + num16);
					}
					bAC.A(num10, num3 + j, num, num20, true);
				}
			}
			for (int k = 0; k < num4; k++)
			{
				int num21 = num3 + k;
				int num22 = ((!bAg) ? num6 : (num8 - 1 - num6));
				double num23;
				double num24;
				if (BM.QO == BM.b.BpF && tableForCompare != null)
				{
					num23 = GetCellDifferenceDisplayValue(tableForCompare, num21, num22, num, out var currentTableRawCellValue3, out var compareTableRawCellValue3);
					num24 = GetCellDifferenceDisplayValue(tableForCompare, num21, num5, num, out currentTableRawCellValue3, out compareTableRawCellValue3);
				}
				else
				{
					num23 = bAC.B(num22, num21, num);
					num24 = bAC.B(num5, num21, num);
				}
				double num25 = num24 - num23;
				double num26 = bAc.G().m(num5) - bAc.G().m(num22);
				double num27 = num25 / num26;
				double num28 = ((BM.QO != 0 || tableForCompare == null) ? (num23 - Math.Round(num27 * (double)bAc.G().m(num22))) : (num23 - num27 * (double)bAc.G().m(num22)));
				for (int l = 1; l < num7 - 1; l++)
				{
					int num29 = ((!bAg) ? (num6 + l) : (num8 - 1 - (num6 + l)));
					int num30 = bAc.G().m(num29);
					int num33;
					if (BM.QO == BM.b.BpF && tableForCompare != null)
					{
						GetCellDifferenceDisplayValue(tableForCompare, num21, num29, num, out var _, out var compareTableRawCellValue4);
						double num31 = bS.A(compareTableRawCellValue4, num9, -1);
						double num32 = num27 * (double)num30 + num28;
						num33 = bS.A(num31 + num32, num9);
					}
					else
					{
						num33 = (int)Math.Round(num27 * (double)num30 + num28);
					}
					bAC.A(num29, num21, num, num33, true);
				}
			}
			return;
		}
		for (int m = 0; m < num7; m++)
		{
			int num34 = ((!bAg) ? (num6 + m) : (num8 - 1 - (num6 + m)));
			double num35;
			double num36;
			if (BM.QO == BM.b.BpF && tableForCompare != null)
			{
				num35 = GetCellDifferenceDisplayValue(tableForCompare, num3, num34, num, out var currentTableRawCellValue5, out var compareTableRawCellValue5);
				num36 = GetCellDifferenceDisplayValue(tableForCompare, num2, num34, num, out currentTableRawCellValue5, out compareTableRawCellValue5);
			}
			else
			{
				num35 = bAC.B(num3, num34, num);
				num36 = bAC.B(num2, num34, num);
			}
			double num37 = num36 - num35;
			double num38 = bAc.G().m(num2) - bAc.G().m(num3);
			double num39 = num37 / num38;
			double num40 = ((BM.QO != 0 || tableForCompare == null) ? (num35 - Math.Round(num39 * (double)bAc.G().m(num3))) : (num35 - num39 * (double)bAc.G().m(num3)));
			for (int n = 1; n < num4 - 1; n++)
			{
				int num41 = bAc.G().m(num3 + n);
				int num44;
				if (BM.QO == BM.b.BpF && tableForCompare != null)
				{
					GetCellDifferenceDisplayValue(tableForCompare, num3 + n, num34, num, out var _, out var compareTableRawCellValue6);
					double num42 = bS.A(compareTableRawCellValue6, num9, -1);
					double num43 = num39 * (double)num41 + num40;
					num44 = bS.A(num42 + num43, num9);
				}
				else
				{
					num44 = (int)Math.Round(num39 * (double)num41 + num40);
				}
				bAC.A(num3 + n, num34, num, num44, true);
				if (m_framework.awo != null)
				{
					Setting setting = m_framework.awo.a(base.A());
					if (setting != null && setting.ax() == num34)
					{
						m_framework.awo.A(base.A());
					}
				}
			}
		}
		for (int num45 = 0; num45 < num4; num45++)
		{
			int num46 = num3 + num45;
			int num47 = ((!bAg) ? num6 : (num8 - 1 - num6));
			double num48;
			double num49;
			if (BM.QO == BM.b.BpF && tableForCompare != null)
			{
				num48 = GetCellDifferenceDisplayValue(tableForCompare, num46, num47, num, out var currentTableRawCellValue7, out var compareTableRawCellValue7);
				num49 = GetCellDifferenceDisplayValue(tableForCompare, num46, num5, num, out currentTableRawCellValue7, out compareTableRawCellValue7);
			}
			else
			{
				num48 = bAC.B(num46, num47, num);
				num49 = bAC.B(num46, num5, num);
			}
			double num50 = num49 - num48;
			double num51 = bAD.G().m(num5) - bAD.G().m(num47);
			double num52 = num50 / num51;
			double num53 = ((BM.QO != 0 || tableForCompare == null) ? (num48 - Math.Round(num52 * (double)bAD.G().m(num47))) : (num48 - num52 * (double)bAD.G().m(num47)));
			for (int num54 = 1; num54 < num7 - 1; num54++)
			{
				int num55 = ((!bAg) ? (num6 + num54) : (num8 - 1 - (num6 + num54)));
				int num56 = bAD.G().m(num55);
				int num59;
				if (BM.QO == BM.b.BpF && tableForCompare != null)
				{
					GetCellDifferenceDisplayValue(tableForCompare, num46, num55, num, out var _, out var compareTableRawCellValue8);
					double num57 = bS.A(compareTableRawCellValue8, num9, -1);
					double num58 = num52 * (double)num56 + num53;
					num59 = bS.A(num57 + num58, num9);
				}
				else
				{
					num59 = (int)Math.Round(num52 * (double)num56 + num53);
				}
				bAC.A(num46, num55, num, num59, true);
				if (m_framework.awo != null)
				{
					Setting setting2 = m_framework.awo.a(base.A());
					if (setting2 != null && setting2.ax() == num55)
					{
						m_framework.awo.A(base.A());
					}
				}
			}
		}
	}

	private void A(TableAxis P_0, bool P_1, int P_2, int P_3, out int P_4, out int P_5, out float P_6)
	{
		P_4 = 0;
		P_5 = 0;
		P_6 = 0f;
		if (!P_1 || P_2 <= 1)
		{
			return;
		}
		int num = P_0.G().m(0);
		int num2 = P_0.G().m(P_2 - 1);
		if (P_3 <= num)
		{
			P_4 = 0;
			P_5 = 0;
			return;
		}
		if (P_3 >= num2)
		{
			P_4 = P_2 - 1;
			P_5 = P_2 - 1;
			return;
		}
		for (int i = 0; i < P_2 - 1; i++)
		{
			int num3 = P_0.G().m(i);
			int num4 = P_0.G().m(i + 1);
			if (P_3 <= num4)
			{
				P_4 = i;
				P_5 = i + 1;
				double num5 = num3;
				double num6 = num4;
				if (P_3 == num3)
				{
					P_6 = 0f;
				}
				else
				{
					P_6 = (float)(((double)P_3 - num5) / (num6 - num5));
				}
				break;
			}
		}
	}

	public int GetInterpolatedTableDataRawValue(int horizRawValue, int vertRawValue, int sliceRawValue)
	{
		int num = HorizAxisCount();
		int num2 = VertAxisCount();
		int num3 = SliceCount();
		A(HorizAxis, HorizAxisEnabled(), num, horizRawValue, out var num4, out var num5, out var num6);
		A(VertAxis, VertAxisEnabled(), num2, vertRawValue, out var num7, out var num8, out var num9);
		A(bAd, SlicesEnabled(), num3, sliceRawValue, out var num10, out var num11, out var num12);
		double num13;
		double num14;
		double num15;
		double num16;
		double num17;
		double num18;
		double num19;
		double num20;
		if (bAH)
		{
			num13 = bAC.B(num7, num4, num10);
			num14 = bAC.B(num7, num5, num10);
			num15 = bAC.B(num8, num4, num10);
			num16 = bAC.B(num8, num5, num10);
			num17 = bAC.B(num7, num4, num11);
			num18 = bAC.B(num7, num5, num11);
			num19 = bAC.B(num8, num4, num11);
			num20 = bAC.B(num8, num5, num11);
		}
		else
		{
			num13 = bAC.B(num4, num7, num10);
			num14 = bAC.B(num5, num7, num10);
			num15 = bAC.B(num4, num8, num10);
			num16 = bAC.B(num5, num8, num10);
			num17 = bAC.B(num4, num7, num11);
			num18 = bAC.B(num5, num7, num11);
			num19 = bAC.B(num4, num8, num11);
			num20 = bAC.B(num5, num8, num11);
		}
		double num21 = ((num4 == num5) ? num13 : (num13 + (double)(num6 * (float)(num14 - num13))));
		double num22 = ((num4 == num5) ? num15 : (num15 + (double)(num6 * (float)(num16 - num15))));
		double num23 = ((num7 == num8) ? num21 : (num21 + (double)(num9 * (float)(num22 - num21))));
		double num24 = ((num4 == num5) ? num17 : (num17 + (double)(num6 * (float)(num18 - num17))));
		double num25 = ((num4 == num5) ? num19 : (num19 + (double)(num6 * (float)(num20 - num19))));
		double num26 = ((num7 == num8) ? num24 : (num24 + (double)(num9 * (float)(num25 - num24))));
		return (int)Math.Round((num10 == num11) ? num23 : (num23 + (double)(num12 * (float)(num26 - num23))));
	}

	private static void A(int[] P_0, int P_1, int P_2, out int P_3, out int P_4, out float P_5)
	{
		P_3 = 0;
		P_4 = 0;
		P_5 = 0f;
		if (P_1 <= 1)
		{
			return;
		}
		int num = P_0[0];
		int num2 = P_0[P_1 - 1];
		if (P_2 <= num)
		{
			P_3 = 0;
			P_4 = 0;
			return;
		}
		if (P_2 >= num2)
		{
			P_3 = P_1 - 1;
			P_4 = P_1 - 1;
			return;
		}
		for (int i = 0; i < P_1 - 1; i++)
		{
			int num3 = P_0[i];
			int num4 = P_0[i + 1];
			if (P_2 <= num4)
			{
				P_3 = i;
				P_4 = i + 1;
				double num5 = num3;
				double num6 = num4;
				if (P_2 == num3)
				{
					P_5 = 0f;
				}
				else
				{
					P_5 = (float)(((double)P_2 - num5) / (num6 - num5));
				}
				break;
			}
		}
	}

	public static double GetInterpolatedValue(double[,,] cellsPerSliceRowColumn, int[] columnAxisValues, int[] rowAxisValues, int[] sliceAxisValues, int columnLookupValue, int rowLookupValue, int sliceLookupValue)
	{
		int num = ((columnAxisValues != null) ? columnAxisValues.Length : 0);
		int num2 = ((rowAxisValues != null) ? rowAxisValues.Length : 0);
		int num3 = ((sliceAxisValues != null) ? sliceAxisValues.Length : 0);
		A(columnAxisValues, num, columnLookupValue, out var num4, out var num5, out var num6);
		A(rowAxisValues, num2, rowLookupValue, out var num7, out var num8, out var num9);
		A(sliceAxisValues, num3, sliceLookupValue, out var num10, out var num11, out var num12);
		double num13 = cellsPerSliceRowColumn[num10, num7, num4];
		double num14 = cellsPerSliceRowColumn[num10, num7, num5];
		double num15 = cellsPerSliceRowColumn[num10, num8, num4];
		double num16 = cellsPerSliceRowColumn[num10, num8, num5];
		double num17 = cellsPerSliceRowColumn[num11, num7, num4];
		double num18 = cellsPerSliceRowColumn[num11, num7, num5];
		double num19 = cellsPerSliceRowColumn[num11, num8, num4];
		double num20 = cellsPerSliceRowColumn[num11, num8, num5];
		double num21 = ((num4 == num5) ? num13 : (num13 + (double)(num6 * (float)(num14 - num13))));
		double num22 = ((num4 == num5) ? num15 : (num15 + (double)(num6 * (float)(num16 - num15))));
		double num23 = ((num7 == num8) ? num21 : (num21 + (double)(num9 * (float)(num22 - num21))));
		double num24 = ((num4 == num5) ? num17 : (num17 + (double)(num6 * (float)(num18 - num17))));
		double num25 = ((num4 == num5) ? num19 : (num19 + (double)(num6 * (float)(num20 - num19))));
		double num26 = ((num7 == num8) ? num24 : (num24 + (double)(num9 * (float)(num25 - num24))));
		if (num10 != num11)
		{
			return num23 + (double)(num12 * (float)(num26 - num23));
		}
		return num23;
	}

	public bool SortByAxis(AxisType axisType, bool markForWrite)
	{
		TableAxis tableAxis = null;
		int num = 0;
		switch (axisType)
		{
		case AxisType.Column:
			tableAxis = ColumnAxis;
			num = ColumnCount();
			break;
		case AxisType.Row:
			tableAxis = RowAxis;
			num = RowCount();
			break;
		default:
			return false;
		}
		if (tableAxis != null && tableAxis.G() != null)
		{
			int num2 = SliceCount();
			int num3 = num;
			bool flag = false;
			do
			{
				flag = false;
				for (int i = 1; i < num3; i++)
				{
					int num4 = tableAxis.G().m(i - 1);
					int num5 = tableAxis.G().m(i);
					if (num4 <= num5)
					{
						continue;
					}
					tableAxis.G().a(i, num4, markForWrite);
					tableAxis.G().a(i - 1, num5, markForWrite);
					int num6 = ((axisType == AxisType.Column) ? RowCount() : ColumnCount());
					for (int j = 0; j < num6; j++)
					{
						for (int k = 0; k < num2; k++)
						{
							switch (axisType)
							{
							case AxisType.Column:
							{
								int num9 = bAC.B(i - 1, j, k);
								int num10 = bAC.B(i, j, k);
								bAC.A(i, j, k, num9, markForWrite);
								bAC.A(i - 1, j, k, num10, markForWrite);
								break;
							}
							case AxisType.Row:
							{
								int num7 = bAC.B(j, i - 1, k);
								int num8 = bAC.B(j, i, k);
								bAC.A(j, i, k, num7, markForWrite);
								bAC.A(j, i - 1, k, num8, markForWrite);
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
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		int num = HorizAxisCount();
		string text = string.Empty;
		if (horizAxisSourceChannel != null && HorizAxisEnabled())
		{
			string text2 = bS.A(horizAxisSourceChannel.@as(), horizAxisSourceChannel.aS(), false, 0);
			int num2 = -1;
			int num3 = -1;
			for (int i = 0; i < num; i++)
			{
				Enumerator<Point> enumerator = HorizVertIndexPerUserSelectedCell.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Point current = enumerator.Current;
						if (((Point)(ref current)).X == i)
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
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (num2 != -1 && num3 != -1)
			{
				if (num2 == num3)
				{
					int num4 = HorizAxis.G().m(num2);
					ValueTuple<string, string, bool> val = horizAxisSourceChannel.A(num4, -1);
					text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAq(), (object)val.Item1, (object)text2);
				}
				else
				{
					int num5 = HorizAxis.G().m(num2);
					ValueTuple<string, string, bool> val2 = horizAxisSourceChannel.A(num5, -1);
					int num6 = HorizAxis.G().m(num3);
					ValueTuple<string, string, bool> val3 = horizAxisSourceChannel.A(num6, -1);
					text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiR(), (object)val2.Item1, (object)val3.Item1, (object)text2);
				}
			}
		}
		int num7 = VertAxisCount();
		string text3 = string.Empty;
		if (vertAxisSourceChannel != null && VertAxisEnabled())
		{
			string text4 = bS.A(vertAxisSourceChannel.@as(), vertAxisSourceChannel.aS(), false, 0);
			int num8 = -1;
			int num9 = -1;
			for (int j = 0; j < num7; j++)
			{
				Enumerator<Point> enumerator = HorizVertIndexPerUserSelectedCell.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Point current2 = enumerator.Current;
						if (((Point)(ref current2)).Y == j)
						{
							if (num8 == -1)
							{
								num8 = j;
							}
							num9 = j;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (num8 != -1 && num9 != -1)
			{
				if (num8 == num9)
				{
					int num10 = ((!bAg) ? VertAxis.G().m(num8) : VertAxis.G().m(num7 - 1 - num8));
					ValueTuple<string, string, bool> val4 = vertAxisSourceChannel.A(num10, -1);
					text3 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAq(), (object)val4.Item1, (object)text4);
				}
				else
				{
					int num11;
					int num12;
					if (bAg)
					{
						num11 = VertAxis.G().m(num7 - 1 - num8);
						num12 = VertAxis.G().m(num7 - 1 - num9);
					}
					else
					{
						num11 = VertAxis.G().m(num8);
						num12 = VertAxis.G().m(num9);
					}
					ValueTuple<string, string, bool> val5 = vertAxisSourceChannel.A(num11, -1);
					ValueTuple<string, string, bool> val6 = vertAxisSourceChannel.A(num12, -1);
					text3 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiR(), (object)val5.Item1, (object)val6.Item1, (object)text4);
				}
			}
		}
		if (text != string.Empty && text3 != string.Empty)
		{
			return text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + text3;
		}
		if (text != string.Empty)
		{
			return text;
		}
		return text3;
	}

	public string GetCellValueString()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bir();
		if (HorizVertIndexPerUserSelectedCell.Count == 0)
		{
			return text;
		}
		int num = 0;
		if (SlicesEnabled())
		{
			num = UserSliceIndex;
		}
		int num2 = HorizAxisCount();
		int num3 = VertAxisCount();
		int num4 = 2147483647;
		int num5 = -2147483648;
		for (int i = 0; i < num3; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				if (HorizVertIndexPerUserSelectedCell.Contains(new Point(j, i)))
				{
					int num6 = (bAH ? ((!InvertRows) ? bAC.B(i, j, num) : bAC.B(num3 - 1 - i, j, num)) : ((!bAg) ? bAC.B(j, i, num) : bAC.B(j, num3 - 1 - i, num)));
					if (num6 > num5)
					{
						num5 = num6;
					}
					if (num6 < num4)
					{
						num4 = num6;
					}
				}
			}
		}
		string text2 = bS.A(@as(), aS(), false, 0);
		if (num4 == num5)
		{
			return text + bS.a(num4, aS(), -1) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + text2;
		}
		return string.Concat(new string[6]
		{
			text,
			bS.a(num4, aS(), -1),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rb(),
			bS.a(num5, aS(), -1),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
			text2
		});
	}

	public bool ColumnAxisMonotonicityIsValid()
	{
		if (ColumnAxis == null)
		{
			return true;
		}
		if (ColumnAxis.C() || ColumnAxis.c())
		{
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
						int num5 = TableDataSetting.B(k, j, i);
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
							if (ColumnAxis.C() && ColumnAxis.c())
							{
								if (flag && flag2)
								{
									return false;
								}
							}
							else if (ColumnAxis.C())
							{
								if (flag2)
								{
									return false;
								}
							}
							else if (ColumnAxis.c() && flag)
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
		return true;
	}

	public bool RowAxisMonotonicityIsValid()
	{
		if (RowAxis == null)
		{
			return true;
		}
		if (RowAxis.C() || RowAxis.c())
		{
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
						int num5 = TableDataSetting.B(j, k, i);
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
							if (RowAxis.C() && RowAxis.c())
							{
								if (flag && flag2)
								{
									return false;
								}
							}
							else if (RowAxis.C())
							{
								if (flag2)
								{
									return false;
								}
							}
							else if (RowAxis.c() && flag)
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
		return true;
	}

	public List<string> GetAxesErrorStrings()
	{
		List<string> val = new List<string>();
		if (!ColumnAxisMonotonicityIsValid())
		{
			if (ColumnAxis.C() && ColumnAxis.c())
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfJ());
			}
			else if (ColumnAxis.C())
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfj());
			}
			else if (ColumnAxis.c())
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfK());
			}
		}
		if (!RowAxisMonotonicityIsValid())
		{
			if (RowAxis.C() && RowAxis.c())
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfJ());
			}
			else if (RowAxis.C())
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfj());
			}
			else if (RowAxis.c())
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfK());
			}
		}
		return val;
	}

	public List<string> GetAxesWarningStrings()
	{
		List<string> val = new List<string>();
		if (ColumnsEnabled())
		{
			Setting setting = ColumnAxis.h();
			if (setting == null || !((SettingOrSpecialObject)setting).l() || !PortFunction.A(setting))
			{
				if (setting == null)
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiS());
				}
				else
				{
					val.Add(((SettingOrSpecialObject)setting).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bis());
				}
			}
		}
		if (RowsEnabled())
		{
			Setting setting2 = RowAxis.h();
			if (setting2 == null || !((SettingOrSpecialObject)setting2).l() || !PortFunction.A(setting2))
			{
				if (setting2 == null)
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiS());
				}
				else
				{
					val.Add(((SettingOrSpecialObject)setting2).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bis());
				}
			}
		}
		if (SlicesEnabled())
		{
			Setting setting3 = SliceAxis.h();
			if (setting3 == null || !((SettingOrSpecialObject)setting3).l() || !PortFunction.A(setting3))
			{
				if (setting3 == null)
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiS());
				}
				else
				{
					val.Add(((SettingOrSpecialObject)setting3).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bis());
				}
			}
		}
		return val;
	}

	internal new void A(int P_0, int P_1)
	{
		Setting setting = m_framework.A(464);
		Setting setting2 = m_framework.A(6481);
		if (setting == null || setting2 == null)
		{
			return;
		}
		int num = setting.ax();
		int num2 = setting2.ax();
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
					if (P_0 == 6469 && (P_1 == 6750 || P_1 == 463))
					{
						double num6 = bAC.B(i, j, k) * 60 * num2;
						int num7 = (int)Math.Round(10.0 * num6 / (double)num);
						bAC.A(i, j, k, num7, true);
					}
					else if (P_1 == 6469 && (P_0 == 6750 || P_0 == 463))
					{
						int num8 = (int)Math.Round((double)((float)bAC.B(i, j, k) * (float)num / (600f * (float)num2)));
						bAC.A(i, j, k, num8, true);
					}
				}
			}
		}
	}

	internal new void B()
	{
		TableAxis tableAxis = null;
		int num = 0;
		if (ColumnsEnabled() && ColumnAxis.g() != null && ColumnAxis.h() != null)
		{
			num = ColumnAxis.h().A();
			if (num == 407)
			{
				tableAxis = ColumnAxis;
			}
		}
		int num2 = 0;
		if (RowsEnabled() && RowAxis.g() != null && RowAxis.h() != null)
		{
			num2 = RowAxis.h().A();
			if (num2 == 407)
			{
				tableAxis = RowAxis;
			}
		}
		int num3 = 0;
		if (SlicesEnabled() && SliceAxis.g() != null && SliceAxis.h() != null)
		{
			num3 = SliceAxis.h().A();
			if (num3 == 407)
			{
				tableAxis = SliceAxis;
			}
		}
		if (tableAxis == null || tableAxis.E() != 0 || tableAxis.f() == null || tableAxis.G() == null)
		{
			return;
		}
		Setting setting = m_framework.A(15995);
		Table table = m_framework.A(128) as Table;
		if (setting == null || table == null)
		{
			return;
		}
		double num4 = Math.Pow((double)setting.ax() / 1000.0, 1.399999976158142);
		int[] array = new int[tableAxis.f().ax()];
		for (int i = 0; i < tableAxis.f().ax(); i++)
		{
			int num5 = (int)Math.Round((double)tableAxis.G().m(i) / (1.0 * num4));
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
			int num9 = ((SliceAxis != null) ? SliceAxis.G().m(j) : 0);
			for (int k = 0; k < num7; k++)
			{
				int num10 = ((RowAxis != null) ? RowAxis.G().m(k) : 0);
				for (int l = 0; l < num8; l++)
				{
					int num11 = ((ColumnAxis != null) ? ColumnAxis.G().m(l) : 0);
					int num12 = 2147483647;
					int num13 = 2147483647;
					int sliceRawValue = 2147483647;
					if (tableAxis2 != null || tableAxis3 != null || tableAxis4 != null)
					{
						if (tableAxis2 == null && tableAxis3 == null)
						{
							if (tableAxis4.A() == AxisType.Column)
							{
								num12 = num9;
							}
							else if (tableAxis4.A() == AxisType.Row)
							{
								num13 = num9;
							}
							else if (tableAxis4.A() == AxisType.Slice)
							{
								sliceRawValue = num9;
							}
						}
						else if (tableAxis3 == null && tableAxis4 == null)
						{
							if (tableAxis2.A() == AxisType.Column)
							{
								num12 = num11;
							}
							else if (tableAxis2.A() == AxisType.Row)
							{
								num13 = num11;
							}
							else if (tableAxis2.A() == AxisType.Slice)
							{
								sliceRawValue = num11;
							}
						}
						else if (tableAxis2 == null && tableAxis4 == null)
						{
							if (tableAxis3.A() == AxisType.Column)
							{
								num12 = num10;
							}
							else if (tableAxis3.A() == AxisType.Row)
							{
								num13 = num10;
							}
							else if (tableAxis3.A() == AxisType.Slice)
							{
								sliceRawValue = num10;
							}
						}
						else if (tableAxis2 == null)
						{
							if (tableAxis3.A() == AxisType.Column && tableAxis4.A() == AxisType.Row)
							{
								num12 = num10;
								num13 = num9;
							}
							else if (tableAxis3.A() == AxisType.Row && tableAxis4.A() == AxisType.Slice)
							{
								num13 = num10;
								sliceRawValue = num9;
							}
							else if (tableAxis3.A() == AxisType.Column && tableAxis4.A() == AxisType.Slice)
							{
								num12 = num10;
								sliceRawValue = num9;
							}
						}
						else if (tableAxis3 == null)
						{
							if (tableAxis2.A() == AxisType.Column && tableAxis4.A() == AxisType.Row)
							{
								num12 = num11;
								num13 = num9;
							}
							else if (tableAxis2.A() == AxisType.Row && tableAxis4.A() == AxisType.Slice)
							{
								num13 = num11;
								sliceRawValue = num9;
							}
							else if (tableAxis2.A() == AxisType.Column && tableAxis4.A() == AxisType.Slice)
							{
								num12 = num11;
								sliceRawValue = num9;
							}
						}
						else if (tableAxis4 == null)
						{
							if (tableAxis2.A() == AxisType.Column && tableAxis3.A() == AxisType.Row)
							{
								num12 = num11;
								num13 = num10;
							}
							else if (tableAxis2.A() == AxisType.Row && tableAxis3.A() == AxisType.Slice)
							{
								num13 = num11;
								sliceRawValue = num10;
							}
							else if (tableAxis2.A() == AxisType.Column && tableAxis3.A() == AxisType.Slice)
							{
								num12 = num11;
								sliceRawValue = num10;
							}
						}
						else if (tableAxis2.A() == AxisType.Column && tableAxis3.A() == AxisType.Row && tableAxis4.A() == AxisType.Slice)
						{
							num12 = num11;
							num13 = num10;
							sliceRawValue = num9;
						}
						else if (tableAxis2.A() == AxisType.Row && tableAxis3.A() == AxisType.Column && tableAxis4.A() == AxisType.Slice)
						{
							num12 = num10;
							num13 = num11;
							sliceRawValue = num9;
						}
						else if (tableAxis2.A() == AxisType.Row && tableAxis3.A() == AxisType.Slice && tableAxis4.A() == AxisType.Column)
						{
							num12 = num9;
							num13 = num11;
							sliceRawValue = num10;
						}
						else if (tableAxis2.A() == AxisType.Slice && tableAxis3.A() == AxisType.Row && tableAxis4.A() == AxisType.Column)
						{
							num12 = num9;
							num13 = num10;
							sliceRawValue = num11;
						}
						else if (tableAxis2.A() == AxisType.Slice && tableAxis3.A() == AxisType.Column && tableAxis4.A() == AxisType.Row)
						{
							num12 = num10;
							num13 = num9;
							sliceRawValue = num11;
						}
						else if (tableAxis2.A() == AxisType.Column && tableAxis3.A() == AxisType.Slice && tableAxis4.A() == AxisType.Row)
						{
							num12 = num11;
							num13 = num9;
							sliceRawValue = num10;
						}
					}
					int num14 = 0;
					if (tableAxis.A() == AxisType.Column)
					{
						num14 = array[l];
					}
					else if (tableAxis.A() == AxisType.Row)
					{
						num14 = array[k];
					}
					else if (tableAxis.A() == AxisType.Slice)
					{
						num14 = array[j];
					}
					if (axisUsingChannel.A() == AxisType.Column)
					{
						num12 = num14;
					}
					else if (axisUsingChannel.A() == AxisType.Row)
					{
						num13 = num14;
					}
					else if (axisUsingChannel.A() == AxisType.Slice)
					{
						sliceRawValue = num14;
					}
					int horizRawValue = ((!table.SwapColumnsAndRows) ? num12 : num13);
					int vertRawValue = ((!table.SwapColumnsAndRows) ? num13 : num12);
					double num15 = (double)table.GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue) / 1000.0;
					int num16 = (int)Math.Round((double)num14 * num15 * num4);
					if (tableAxis.A() == AxisType.Column)
					{
						num11 = num16;
					}
					else if (tableAxis.A() == AxisType.Row)
					{
						num10 = num16;
					}
					else if (tableAxis.A() == AxisType.Slice)
					{
						num9 = num16;
					}
					int horizRawValue2 = ((!bAH) ? num11 : num10);
					int vertRawValue2 = ((!bAH) ? num10 : num11);
					array2[j, k, l] = GetInterpolatedTableDataRawValue(horizRawValue2, vertRawValue2, num9);
				}
			}
		}
		for (int m = 0; m < tableAxis.f().ax(); m++)
		{
			tableAxis.G().a(m, array[m], true);
		}
		for (int n = 0; n < num6; n++)
		{
			for (int num17 = 0; num17 < num7; num17++)
			{
				for (int num18 = 0; num18 < num8; num18++)
				{
					bAC.A(num18, num17, n, array2[n, num17, num18], true);
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
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		val.Add(new DataIdAndAttrId(base.A()));
		val.Add(new DataIdAndAttrId(TableDataSetting.A()));
		if (bAc != null)
		{
			if (bAc.F() != null)
			{
				val.Add(new DataIdAndAttrId(bAc.F().A()));
			}
			if (bAc.f() != null)
			{
				val.Add(new DataIdAndAttrId(bAc.f().A()));
			}
			if (bAc.G() != null)
			{
				val.Add(new DataIdAndAttrId(bAc.G().A()));
			}
			if (bAc.g() != null)
			{
				val.Add(new DataIdAndAttrId(bAc.g().A()));
			}
			if (bAc.H() != null)
			{
				val.Add(new DataIdAndAttrId(bAc.H().A()));
			}
		}
		if (bAD != null)
		{
			if (bAD.F() != null)
			{
				val.Add(new DataIdAndAttrId(bAD.F().A()));
			}
			if (bAD.f() != null)
			{
				val.Add(new DataIdAndAttrId(bAD.f().A()));
			}
			if (bAD.G() != null)
			{
				val.Add(new DataIdAndAttrId(bAD.G().A()));
			}
			if (bAD.g() != null)
			{
				val.Add(new DataIdAndAttrId(bAD.g().A()));
			}
			if (bAD.H() != null)
			{
				val.Add(new DataIdAndAttrId(bAD.H().A()));
			}
		}
		if (bAd != null)
		{
			if (bAd.F() != null)
			{
				val.Add(new DataIdAndAttrId(bAd.F().A()));
			}
			if (bAd.f() != null)
			{
				val.Add(new DataIdAndAttrId(bAd.f().A()));
			}
			if (bAd.G() != null)
			{
				val.Add(new DataIdAndAttrId(bAd.G().A()));
			}
			if (bAd.g() != null)
			{
				val.Add(new DataIdAndAttrId(bAd.g().A()));
			}
			if (bAd.H() != null)
			{
				val.Add(new DataIdAndAttrId(bAd.H().A()));
			}
		}
		return val;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(this, global::a.aE.HW, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiT();
		node.Checked = J();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				m_framework.A(current)?.c(node.Checked);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiT();
		Setting setting = fromFramework.A(base.A());
		if (setting == null || !(setting is Table))
		{
			node.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bit();
			return;
		}
		Table table = setting as Table;
		if (TableDataSetting.aV() > table.TableDataSetting.aV() || TableDataSetting.Ba() > table.TableDataSetting.Ba())
		{
			int num = table.TableDataSetting.aV();
			int num2 = table.TableDataSetting.av()[2];
			int num3 = ((num <= 1) ? 1 : table.TableDataSetting.av()[1]);
			int num4 = ((num <= 2) ? 1 : table.TableDataSetting.av()[0]);
			string text = string.Concat(new string[5]
			{
				num2.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ei(),
				num3.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ei(),
				num4.ToString()
			});
			int num5 = TableDataSetting.aV();
			int num6 = TableDataSetting.av()[2];
			int num7 = ((num5 <= 1) ? 1 : TableDataSetting.av()[1]);
			int num8 = ((num5 <= 2) ? 1 : TableDataSetting.av()[0]);
			string text2 = string.Concat(new string[5]
			{
				num6.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ei(),
				num7.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ei(),
				num8.ToString()
			});
			node.Tag = string.Concat(new string[5]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiU(),
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rb(),
				text2,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bih()
			});
			if (!((SettingOrSpecialObject)table).l())
			{
				node.ForeColor = Color.Gray;
			}
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		if (PortFunction.a(((SettingOrSpecialObject)this).D()))
		{
			skipThisTreeNode = true;
			return;
		}
		Setting setting = importFramework.A(base.A());
		if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && J()) || (importFrameworkLocked && (setting == null || setting.J()))))
		{
			skipThisTreeNode = true;
			return;
		}
		node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiT();
		userAccessibleIdsInDestFramework.Add(C());
		if (setting != null && setting is Table)
		{
			Table table = setting as Table;
			if (!bAC.A(table.TableDataSetting))
			{
				treeNodesWithDifferences.Add(node);
			}
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		if (PortFunction.a(((SettingOrSpecialObject)this).D()))
		{
			skipThisTreeNode = true;
			return;
		}
		if (!bothFrameworksUnlockedOrPasswordsMatch && importFrameworkLocked && J())
		{
			skipThisTreeNode = true;
			return;
		}
		node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiT();
		userAccessibleIdsInImportFramework.Add(C());
		if (!userAccessibleIdsInDestFramework.Contains(C()))
		{
			equivalentNodeExistsInDestMap = false;
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		return !userAccessibleIdsInImportFramework.Contains(C());
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		if (bAC.D())
		{
			return;
		}
		bAC.A(importFramework, markForWrite);
		if (bAc != null)
		{
			if (bAc.F() != null)
			{
				bAc.F().A(importFramework, markForWrite);
			}
			if (bAc.f() != null)
			{
				bAc.f().A(importFramework, markForWrite);
				int num = bAC.av()[2];
				if (bAc.f().ax() > num)
				{
					bAc.f().a(num, markForWrite);
				}
			}
			if (bAc.G() != null)
			{
				bAc.G().A(importFramework, markForWrite);
			}
			if (bAc.g() != null)
			{
				bAc.g().A(importFramework, markForWrite);
			}
			if (bAc.H() != null)
			{
				bAc.H().A(importFramework, markForWrite);
			}
		}
		if (bAD != null)
		{
			if (bAD.F() != null)
			{
				bAD.F().A(importFramework, markForWrite);
			}
			if (bAD.f() != null)
			{
				bAD.f().A(importFramework, markForWrite);
				int num2 = bAC.av()[1];
				if (bAD.f().ax() > num2)
				{
					bAD.f().a(num2, markForWrite);
				}
			}
			if (bAD.G() != null)
			{
				bAD.G().A(importFramework, markForWrite);
			}
			if (bAD.g() != null)
			{
				bAD.g().A(importFramework, markForWrite);
			}
			if (bAD.H() != null)
			{
				bAD.H().A(importFramework, markForWrite);
			}
		}
		if (bAd != null)
		{
			if (bAd.F() != null)
			{
				bAd.F().A(importFramework, markForWrite);
			}
			if (bAd.f() != null)
			{
				bAd.f().A(importFramework, markForWrite);
				int num3 = bAC.av()[0];
				if (bAd.f().ax() > num3)
				{
					bAd.f().a(num3, markForWrite);
				}
			}
			if (bAd.G() != null)
			{
				bAd.G().A(importFramework, markForWrite);
			}
			if (bAd.g() != null)
			{
				bAd.g().A(importFramework, markForWrite);
			}
			if (bAd.H() != null)
			{
				bAd.H().A(importFramework, markForWrite);
			}
		}
		if (bAC.A() == 14206 && !BezierCurve.ETCBezierToTableRedundancyIsOK(importFramework, m_framework))
		{
			A(markForWrite);
		}
	}

	internal new void A(bool P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = m_framework.A(current);
				if (setting != null && setting != this)
				{
					setting.I(P_0);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void CopyFromAnotherTable(Table sourceTable, bool markForWrite)
	{
		if (bAC.BB() != sourceTable.TableDataSetting.BB())
		{
			return;
		}
		if (bAc != null && sourceTable.ColumnAxis != null)
		{
			if (bAc.F() != null && sourceTable.ColumnAxis.F() != null)
			{
				bAc.F().A(sourceTable.ColumnAxis.F(), markForWrite);
				BM.b(bAc.F().A());
			}
			if (bAc.f() != null && sourceTable.ColumnAxis.f() != null)
			{
				bAc.f().A(sourceTable.ColumnAxis.f(), markForWrite);
				BM.b(bAc.f().A());
			}
			if (bAc.G() != null && sourceTable.ColumnAxis.G() != null)
			{
				bAc.G().A(sourceTable.ColumnAxis.G(), markForWrite);
				BM.b(bAc.G().A());
			}
			if (bAc.g() != null && sourceTable.ColumnAxis.g() != null)
			{
				bAc.g().A(sourceTable.ColumnAxis.g(), markForWrite);
				BM.b(bAc.g().A());
			}
			if (bAc.H() != null && sourceTable.ColumnAxis.H() != null)
			{
				bAc.H().A(sourceTable.ColumnAxis.H(), markForWrite);
				BM.b(bAc.H().A());
			}
		}
		if (bAD != null && sourceTable.RowAxis != null)
		{
			if (bAD.F() != null && sourceTable.RowAxis.F() != null)
			{
				bAD.F().A(sourceTable.RowAxis.F(), markForWrite);
				BM.b(bAD.F().A());
			}
			if (bAD.f() != null && sourceTable.RowAxis.f() != null)
			{
				bAD.f().A(sourceTable.RowAxis.f(), markForWrite);
				BM.b(bAD.f().A());
			}
			if (bAD.G() != null && sourceTable.RowAxis.G() != null)
			{
				bAD.G().A(sourceTable.RowAxis.G(), markForWrite);
				BM.b(bAD.G().A());
			}
			if (bAD.g() != null && sourceTable.RowAxis.g() != null)
			{
				bAD.g().A(sourceTable.RowAxis.g(), markForWrite);
				BM.b(bAD.g().A());
			}
			if (bAD.H() != null && sourceTable.RowAxis.H() != null)
			{
				bAD.H().A(sourceTable.RowAxis.H(), markForWrite);
				BM.b(bAD.H().A());
			}
		}
		if (bAd != null && sourceTable.SliceAxis != null)
		{
			if (bAd.F() != null && sourceTable.SliceAxis.F() != null)
			{
				bAd.F().A(sourceTable.SliceAxis.F(), markForWrite);
				BM.b(bAd.F().A());
			}
			if (bAd.f() != null && sourceTable.SliceAxis.f() != null)
			{
				bAd.f().A(sourceTable.SliceAxis.f(), markForWrite);
				BM.b(bAd.f().A());
			}
			if (bAd.G() != null && sourceTable.SliceAxis.G() != null)
			{
				bAd.G().A(sourceTable.SliceAxis.G(), markForWrite);
				BM.b(bAd.G().A());
			}
			if (bAd.g() != null && sourceTable.SliceAxis.g() != null)
			{
				bAd.g().A(sourceTable.SliceAxis.g(), markForWrite);
				BM.b(bAd.g().A());
			}
			if (bAd.H() != null && sourceTable.SliceAxis.H() != null)
			{
				bAd.H().A(sourceTable.SliceAxis.H(), markForWrite);
				BM.b(bAd.H().A());
			}
		}
		bAC.A(sourceTable.TableDataSetting, markForWrite);
		BM.b(bAC.A());
	}

	public void CompareWithAnotherCorrespondingTable(Table compareTable, StringBuilder resultsStringBuilder)
	{
		if (resultsStringBuilder == null)
		{
			return;
		}
		int num = bAC.BB();
		int num2 = compareTable.bAC.BB();
		if (num != num2)
		{
			resultsStringBuilder.Append(string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
				((SettingOrSpecialObject)this).A(bz.aYt),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
				base.A().ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiV(),
				num.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdL(),
				num2.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdl()
			}));
			return;
		}
		Setting setting = null;
		if (ColumnAxis != null && ColumnAxis.g() != null)
		{
			setting = ColumnAxis.h();
		}
		Setting setting2 = null;
		if (RowAxis != null && RowAxis.g() != null)
		{
			setting2 = RowAxis.h();
		}
		Setting setting3 = null;
		if (SliceAxis != null && SliceAxis.g() != null)
		{
			setting3 = SliceAxis.h();
		}
		Setting setting4 = null;
		if (compareTable.ColumnAxis != null && compareTable.ColumnAxis.g() != null)
		{
			setting4 = compareTable.ColumnAxis.h();
		}
		Setting setting5 = null;
		if (compareTable.RowAxis != null && compareTable.RowAxis.g() != null)
		{
			setting5 = compareTable.RowAxis.h();
		}
		Setting setting6 = null;
		if (compareTable.SliceAxis != null && compareTable.SliceAxis.g() != null)
		{
			setting6 = compareTable.SliceAxis.h();
		}
		if ((setting != null && setting4 == null) || (setting == null && setting4 != null) || (setting != null && setting4 != null && setting.A() != setting4.A()))
		{
			string text = ((setting != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu() + ((SettingOrSpecialObject)setting).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biv());
			string text2 = ((setting4 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu() + ((SettingOrSpecialObject)setting4).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biv());
			resultsStringBuilder.Append(string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
				((SettingOrSpecialObject)this).A(bz.aYt),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
				base.A().ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiW(),
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdL(),
				text2,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdl()
			}));
		}
		if ((setting2 != null && setting5 == null) || (setting2 == null && setting5 != null) || (setting2 != null && setting5 != null && setting2.A() != setting5.A()))
		{
			string text3 = ((setting2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu() + ((SettingOrSpecialObject)setting2).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biv());
			string text4 = ((setting5 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu() + ((SettingOrSpecialObject)setting5).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biv());
			resultsStringBuilder.Append(string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
				((SettingOrSpecialObject)this).A(bz.aYt),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
				base.A().ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biw(),
				text3,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdL(),
				text4,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdl()
			}));
		}
		if ((setting3 != null && setting6 == null) || (setting3 == null && setting6 != null) || (setting3 != null && setting6 != null && setting3.A() != setting6.A()))
		{
			string text5 = ((setting3 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu() + ((SettingOrSpecialObject)setting3).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biv());
			string text6 = ((setting6 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu() + ((SettingOrSpecialObject)setting6).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biv());
			resultsStringBuilder.Append(string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
				((SettingOrSpecialObject)this).A(bz.aYt),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
				base.A().ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiX(),
				text5,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdL(),
				text6,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdl()
			}));
		}
		int num3 = ColumnCount();
		int num4 = RowCount();
		int num5 = SliceCount();
		int num6 = compareTable.ColumnCount();
		int num7 = compareTable.RowCount();
		int num8 = compareTable.SliceCount();
		if (num3 != num6)
		{
			resultsStringBuilder.Append(string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
				((SettingOrSpecialObject)this).A(bz.aYt),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
				base.A().ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bix(),
				num3.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiY(),
				num6.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdl()
			}));
		}
		if (num4 != num7)
		{
			resultsStringBuilder.Append(string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
				((SettingOrSpecialObject)this).A(bz.aYt),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
				base.A().ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bix(),
				num4.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biy(),
				num7.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdl()
			}));
		}
		if (num5 != num8)
		{
			resultsStringBuilder.Append(string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
				((SettingOrSpecialObject)this).A(bz.aYt),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
				base.A().ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bix(),
				num5.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiZ(),
				num8.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdl()
			}));
		}
		int num9 = Math.Max(num3, num6);
		int num10 = Math.Max(num4, num7);
		int num11 = Math.Max(num5, num8);
		if (ColumnAxis != null && compareTable.ColumnAxis != null && ColumnAxis.G() != null && compareTable.ColumnAxis.G() != null)
		{
			for (int i = 0; i < num9; i++)
			{
				int num12 = ColumnAxis.G().m(i);
				int num13 = compareTable.ColumnAxis.G().m(i);
				if (num12 != num13)
				{
					resultsStringBuilder.Append(string.Concat(new string[11]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
						((SettingOrSpecialObject)this).A(bz.aYt),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
						base.A().ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biz(),
						i.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdo(),
						num12.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdP(),
						num13.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdp()
					}));
				}
			}
		}
		if (RowAxis != null && compareTable.RowAxis != null && RowAxis.G() != null && compareTable.RowAxis.G() != null)
		{
			for (int j = 0; j < num10; j++)
			{
				int num14 = RowAxis.G().m(j);
				int num15 = compareTable.RowAxis.G().m(j);
				if (num14 != num15)
				{
					resultsStringBuilder.Append(string.Concat(new string[11]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
						((SettingOrSpecialObject)this).A(bz.aYt),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
						base.A().ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJA(),
						j.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdo(),
						num14.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdP(),
						num15.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdp()
					}));
				}
			}
		}
		if (SliceAxis != null && compareTable.SliceAxis != null && SliceAxis.G() != null && compareTable.SliceAxis.G() != null)
		{
			for (int k = 0; k < num11; k++)
			{
				int num16 = SliceAxis.G().m(k);
				int num17 = compareTable.SliceAxis.G().m(k);
				if (num16 != num17)
				{
					resultsStringBuilder.Append(string.Concat(new string[11]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
						((SettingOrSpecialObject)this).A(bz.aYt),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
						base.A().ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJa(),
						k.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdo(),
						num16.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdP(),
						num17.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdp()
					}));
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
					int num19 = bAC.B(n, m, l);
					int num20 = compareTable.bAC.B(n, m, l);
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
							text7 = string.Concat(new string[6]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJB(),
								l.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJb(),
								m.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJC(),
								n.ToString()
							});
						}
						else if (num10 > 1 && num9 > 1)
						{
							text7 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJc() + m + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJC() + n;
						}
						else if (num10 > 1)
						{
							text7 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJc() + m;
						}
						else if (num9 > 1)
						{
							text7 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJD() + n;
						}
						resultsStringBuilder.Append(string.Concat(new string[11]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Biu(),
							((SettingOrSpecialObject)this).A(bz.aYt),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
							base.A().ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJd(),
							text7,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdo(),
							num19.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdP(),
							num20.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdp()
						}));
					}
				}
			}
		}
		if (num18 > 64)
		{
			resultsStringBuilder.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJE() + (num18 - 64) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJe());
		}
	}
}
