using System;
using System.Runtime.CompilerServices;

namespace A;

internal delegate void C(object P_0, c P_1);
internal class c : EventArgs
{
	public uint R;

	public uint r;

	[SpecialName]
	public int A()
	{
		return (int)((long)R * 100L / (R + r));
	}
}
