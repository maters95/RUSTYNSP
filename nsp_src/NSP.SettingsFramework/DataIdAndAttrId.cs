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

	public bool Equals(object obj)
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

	public static bool operator ==(DataIdAndAttrId a, DataIdAndAttrId b)
	{
		return ((object)a).Equals((object)b);
	}

	public static bool operator !=(DataIdAndAttrId a, DataIdAndAttrId b)
	{
		return !((object)a).Equals((object)b);
	}

	public int GetHashCode()
	{
		return (AttrId << 24) | DataId;
	}
}
