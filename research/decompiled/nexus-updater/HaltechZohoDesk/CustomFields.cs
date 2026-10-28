using Newtonsoft.Json;

namespace HaltechZohoDesk;

public class CustomFields
{
	[JsonProperty("cf_serial_number")]
	public string SerialNumber { get; set; }

	[JsonProperty("cf_product")]
	public string Product { get; set; }

	[JsonProperty("cf_software_version")]
	public string SoftwareVersion { get; set; }

	[JsonProperty("cf_firmware_version")]
	public string FirmwareVersion { get; set; }
}
