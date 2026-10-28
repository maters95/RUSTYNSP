using System.Collections.Generic;
using ns7;

namespace NSP.SettingsFramework;

public class QuantityType
{
	public int UnitType;

	public List<Unit> UnitsList = new List<Unit>();

	public override string ToString()
	{
		return Class333.atE() + UnitType + Class333.ate() + UnitsList.Count + Class333.atF();
	}
}
