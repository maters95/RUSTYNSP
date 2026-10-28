using Newtonsoft.Json;

namespace HaltechZohoDesk;

public class Contact
{
	[JsonProperty("firstName")]
	public string FirstName { get; set; }

	[JsonProperty("lastName")]
	public string LastName { get; set; }

	[JsonProperty("email")]
	public string Email { get; set; }

	[JsonProperty("phone")]
	public string Phone { get; set; }
}
