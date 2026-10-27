using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace NSP.UserInterface;

public class ThemedToolStripComboBox : ToolStripControlHost
{
	[CompilerGenerated]
	private EventHandler KD;

	public ThemedComboBox ComboBox => ((ToolStripControlHost)this).Control as ThemedComboBox;

	public ComboBoxStyle DropDownStyle
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((ComboBox)ComboBox).DropDownStyle;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((ComboBox)ComboBox).DropDownStyle = value;
		}
	}

	public int DropDownWidth
	{
		get
		{
			return ((ComboBox)ComboBox).DropDownWidth;
		}
		set
		{
			((ComboBox)ComboBox).DropDownWidth = value;
		}
	}

	public ObjectCollection Items => ((ComboBox)ComboBox).Items;

	public int MaxDropDownItems
	{
		get
		{
			return ((ComboBox)ComboBox).MaxDropDownItems;
		}
		set
		{
			((ComboBox)ComboBox).MaxDropDownItems = value;
		}
	}

	public int SelectedIndex
	{
		get
		{
			return ((ListControl)ComboBox).SelectedIndex;
		}
		set
		{
			((ListControl)ComboBox).SelectedIndex = value;
		}
	}

	public event EventHandler SelectedIndexChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = KD;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref KD, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = KD;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref KD, val3, val2);
			}
			while (val != val2);
		}
	}

	public ThemedToolStripComboBox()
		: base((Control)(object)new ThemedComboBox())
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		((ComboBox)ComboBox).SelectedIndexChanged += new EventHandler(A);
	}

	protected override void Dispose(bool disposing)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((ComboBox)ComboBox).SelectedIndexChanged -= new EventHandler(A);
		((ToolStripControlHost)this).Dispose(disposing);
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (KD != null)
		{
			KD.Invoke(P_0, P_1);
		}
	}
}
