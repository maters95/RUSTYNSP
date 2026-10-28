using System;
using Newtonsoft.Json;

namespace HaltechZohoDesk;

public class CreateTicketRequest
{
	[JsonProperty("subCategory")]
	public string SubCategory { get; set; }

	[JsonProperty("cf")]
	public CustomFields Cf { get; set; }

	[JsonProperty("contact")]
	public Contact Contact { get; set; }

	[JsonProperty("subject")]
	public string Subject { get; set; }

	[JsonProperty("dueDate")]
	[JsonConverter(typeof(IsoDateTimeNoMsConverter))]
	public DateTime DueDate { get; set; }

	[JsonProperty("departmentId")]
	public string DepartmentId { get; set; }

	[JsonProperty("teamId")]
	public string TeamId { get; set; }

	[JsonProperty("channel")]
	public string Channel { get; set; }

	[JsonProperty("email")]
	public string Email { get; set; }

	[JsonProperty("phone")]
	public string Phone { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("language")]
	public string Language { get; set; }

	[JsonProperty("priority")]
	public string Priority { get; set; }

	[JsonProperty("classification")]
	public string Classification { get; set; }

	[JsonProperty("category")]
	public string Category { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
