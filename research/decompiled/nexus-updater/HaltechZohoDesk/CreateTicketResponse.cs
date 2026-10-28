using Newtonsoft.Json;

namespace HaltechZohoDesk;

internal class CreateTicketResponse
{
	[JsonProperty("id")]
	public string Id { get; set; }

	[JsonProperty("contactId")]
	public string ContactId { get; set; }
}
