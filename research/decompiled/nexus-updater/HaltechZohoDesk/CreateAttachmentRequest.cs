using System;
using Newtonsoft.Json;

namespace HaltechZohoDesk;

public class CreateAttachmentRequest
{
	[JsonProperty("size")]
	public string Size { get; set; }

	[JsonProperty("creatorId")]
	public string CreatorId { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("createdTime")]
	[JsonConverter(typeof(IsoDateTimeNoMsConverter))]
	public DateTime CreatedTime { get; set; }

	[JsonProperty("isPublic")]
	public bool IsPublic { get; set; }
}
