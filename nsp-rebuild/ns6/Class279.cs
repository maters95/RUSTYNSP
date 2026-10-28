using System.Collections.Generic;
using NSP.SettingsFramework;
using ns7;

namespace ns6;

internal class Class279
{
	internal DataIdAndAttrId BCF;

	internal int BCf;

	internal List<byte> BCG = new List<byte>();

	internal List<byte> BCg = new List<byte>();

	public override string ToString()
	{
		return Class333.atb() + BCF.DataId + Class333.atC() + BCF.AttrId + Class333.atc() + BCf;
	}
}
