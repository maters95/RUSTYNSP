using System.Collections.Generic;
using ns7;

namespace NSP.SettingsFramework;

public class Units
{
	public Dictionary<int, QuantityType> QuantityTypesPerUnitType = new Dictionary<int, QuantityType>();

	public override string ToString()
	{
		return Class333.atD() + QuantityTypesPerUnitType.Keys.Count + Class333.atd();
	}
}
