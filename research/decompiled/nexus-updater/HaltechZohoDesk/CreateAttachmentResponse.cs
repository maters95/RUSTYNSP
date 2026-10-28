using Newtonsoft.Json;

namespace HaltechZohoDesk;

internal class CreateAttachmentResponse
{
	[JsonProperty("id")]
	public string Id { get; set; }

	[JsonProperty("creatorId")]
	public string CreatorId { get; set; }
}
