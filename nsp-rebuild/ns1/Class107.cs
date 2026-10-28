using System.Drawing;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;

namespace ns1;

internal class Class107 : MovableResizablePanel
{
	private const int BkZ = 600;

	private const int Bkz = 250;

	private const int BLA = 120;

	private const int BLa = 160;

	private const int BLB = 10;

	private Class78 BLb;

	private Class79 BLC;

	private Class77 BLc;

	private Rectangle BLD;

	internal Class107(KnockDetection knockDetection_0, Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BLb = new Class78(knockDetection_0, framework_0);
		Controls.Add(BLb);
		BLC = new Class79(knockDetection_0, framework_0);
		Controls.Add(BLC);
		if (knockDetection_0.DataIdsOfAngleBucketChannels != null && knockDetection_0.DataIdsOfAngleBucketChannels.Count != 0)
		{
			BLc = new Class77(knockDetection_0, framework_0);
			Controls.Add(BLc);
		}
		BLD = rectangle_0;
		if (BLD != Rectangle.Empty)
		{
			Width = rectangle_0.Width;
			Height = rectangle_0.Height;
			Left = rectangle_0.Left;
			Top = rectangle_0.Top;
		}
		else
		{
			Width = 600;
			if (BLc != null)
			{
				Height = 550;
			}
			else
			{
				Height = 380;
			}
		}
		UpdateLayout(resizingOnly: false);
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		BLb.Top = 0;
		BLb.Left = 0;
		BLb.Width = Width;
		BLC.Left = 0;
		BLC.Width = Width;
		if (BLc != null)
		{
			BLc.Left = 0;
			BLc.Width = Width;
		}
		if (BLD != Rectangle.Empty)
		{
			if (BLc != null)
			{
				BLb.Height = Height * 250 / 550;
				BLC.Height = Height * 120 / 550;
				BLc.Height = Height * 160 / 550;
			}
			else
			{
				BLb.Height = Height * 250 / 380;
				BLC.Height = Height * 120 / 380;
			}
		}
		else
		{
			BLb.Height = 250;
			BLC.Height = 120;
			if (BLc != null)
			{
				BLc.Height = 160;
			}
		}
		BLC.Top = BLb.Height + 10;
		if (BLc != null)
		{
			BLc.Top = BLb.Height + 10 + BLC.Height + 10;
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		ControlPaint.DrawBorder(paintEventArgs_0.Graphics, ClientRectangle, BackColor, ButtonBorderStyle.Solid);
	}
}
