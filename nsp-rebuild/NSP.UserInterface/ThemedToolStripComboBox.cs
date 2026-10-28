using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace NSP.UserInterface;

public class ThemedToolStripComboBox : ToolStripControlHost
{
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	public ThemedComboBox ComboBox => Control as ThemedComboBox;

	public ComboBoxStyle DropDownStyle
	{
		get
		{
			return ComboBox.DropDownStyle;
		}
		set
		{
			ComboBox.DropDownStyle = value;
		}
	}

	public int DropDownWidth
	{
		get
		{
			return ComboBox.DropDownWidth;
		}
		set
		{
			ComboBox.DropDownWidth = value;
		}
	}

	public ComboBox.ObjectCollection Items => ComboBox.Items;

	public int MaxDropDownItems
	{
		get
		{
			return ComboBox.MaxDropDownItems;
		}
		set
		{
			ComboBox.MaxDropDownItems = value;
		}
	}

	public int SelectedIndex
	{
		get
		{
			return ComboBox.SelectedIndex;
		}
		set
		{
			ComboBox.SelectedIndex = value;
		}
	}

	public event EventHandler SelectedIndexChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ThemedToolStripComboBox()
		: base(new ThemedComboBox())
	{
		ComboBox.SelectedIndexChanged += method_0;
	}

	protected override void Dispose(bool disposing)
	{
		ComboBox.SelectedIndexChanged -= method_0;
		base.Dispose(disposing);
	}

	private void method_0(object sender, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(sender, e);
		}
	}
}
