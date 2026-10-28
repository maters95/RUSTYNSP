using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class EventArgs1 : EventArgs
{
	public uint uint_0;

	public uint uint_1;

	[SpecialName]
	public int method_0()
	{
		return (int)((long)uint_0 * 100L / (uint_0 + uint_1));
	}
}
