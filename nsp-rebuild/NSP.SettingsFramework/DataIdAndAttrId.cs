namespace NSP.SettingsFramework;

public struct DataIdAndAttrId
{
	public int DataId;

	public int AttrId;

	public DataIdAndAttrId(int dataId, int attrId)
	{
		DataId = dataId;
		AttrId = attrId;
	}

	public DataIdAndAttrId(int dataId)
	{
		DataId = dataId;
		AttrId = 0;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		DataIdAndAttrId dataIdAndAttrId = (DataIdAndAttrId)obj;
		if (dataIdAndAttrId.DataId == DataId)
		{
			return dataIdAndAttrId.AttrId == AttrId;
		}
		return false;
	}

	public static bool operator ==(DataIdAndAttrId dataIdAndAttrId_0, DataIdAndAttrId dataIdAndAttrId_1)
	{
		return dataIdAndAttrId_0.Equals(dataIdAndAttrId_1);
	}

	public static bool operator !=(DataIdAndAttrId dataIdAndAttrId_0, DataIdAndAttrId dataIdAndAttrId_1)
	{
		return !dataIdAndAttrId_0.Equals(dataIdAndAttrId_1);
	}

	public override int GetHashCode()
	{
		return (AttrId << 24) | DataId;
	}
}
