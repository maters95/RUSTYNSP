using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns1;

[StructLayout(LayoutKind.Auto)]
[InlineArray(4)]
internal struct Struct64<T>
{
	[CompilerGenerated]
	private T BEt;
}
