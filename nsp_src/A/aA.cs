using System.Drawing;
using System.Runtime.CompilerServices;
using B;

namespace a;

internal enum aA
{
	fX,
	fx,
	fY,
	fy,
	fZ,
	fz,
	GA,
	Ga
}
internal class aa
{
	[CompilerGenerated]
	private Color GB;

	[CompilerGenerated]
	private bool Gb;

	[CompilerGenerated]
	private bool GC;

	[SpecialName]
	[CompilerGenerated]
	internal Color A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GB;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(Color P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GB = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool a()
	{
		return Gb;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(bool P_0)
	{
		Gb = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool B()
	{
		return GC;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(bool P_0)
	{
		GC = P_0;
	}

	internal aa()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		A(A(0));
		A(false);
		a(false);
	}

	public static Color A(int P_0)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		return (Color)((aA)P_0 switch
		{
			aA.fx => Color.Blue, 
			aA.fY => Color.FromArgb(0, 255, 0), 
			aA.fZ => Color.Red, 
			aA.Ga => Color.White, 
			aA.GA => Color.Yellow, 
			aA.fy => Color.Cyan, 
			aA.fz => Color.Magenta, 
			_ => BM.td, 
		});
	}
}
