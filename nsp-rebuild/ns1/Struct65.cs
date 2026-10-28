using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns1;

[StructLayout(LayoutKind.Auto)]
[InlineArray(5)]
internal struct Struct65<T>
{
	[CompilerGenerated]
	private T BEU;
}
