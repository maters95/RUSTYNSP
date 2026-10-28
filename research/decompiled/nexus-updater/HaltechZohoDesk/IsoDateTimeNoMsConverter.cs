using System;
using Newtonsoft.Json;

namespace HaltechZohoDesk;

internal class IsoDateTimeNoMsConverter : JsonConverter
{
	private const string DateFormat = "yyyy-MM-ddTHH:mm:ssZ";

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		if (value is DateTime dateTime)
		{
			writer.WriteValue(dateTime.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
			return;
		}
		throw new JsonSerializationException("Expected DateTime object value.");
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(DateTime);
	}
}
