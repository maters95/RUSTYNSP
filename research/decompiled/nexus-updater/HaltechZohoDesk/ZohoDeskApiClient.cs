using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace HaltechZohoDesk;

internal sealed class ZohoDeskApiClient
{
	private const string BaseUrl = "https://desk.zoho.com/api/v1";

	private const string AuthUrl = "https://accounts.zoho.com/oauth/v2";

	private const string ClientId = "1000.MGDDO2YA3K1A8U4YK7Y0KISOT959TR";

	private const string Scope = "Desk.tickets.CREATE,Desk.tickets.UPDATE";

	private const string DepartmentId = "309315000000006907";

	private const string BetaTeamId = "309315000180748001";

	private const string ClientSecret = "4ee77d3265700f2fca0655e9c291df8e0330eae281";

	private const string RefreshToken = "1000.ee1d83da630739146848eccad3c454f3.aae767edddb0403f356c8da5bf113e77";

	private const string CategoryStr = "general";

	private const string SubCategoryStr = "Sub General";

	private const string PriorityStr = "Normal";

	private const string ClassificationStr = "";

	private const int DueDateDays = 4;

	private readonly HttpClient _httpClient;

	private TokenResponse _token;

	private static readonly Lazy<ZohoDeskApiClient> lazy = new Lazy<ZohoDeskApiClient>(() => new ZohoDeskApiClient());

	public static ZohoDeskApiClient Instance => lazy.Value;

	private ZohoDeskApiClient()
	{
		_httpClient = new HttpClient();
	}

	private async Task UpdateAuthorisationAsync()
	{
		if (_token == null || _token.ExpiresAt < DateTime.UtcNow.Subtract(TimeSpan.FromSeconds(60.0)))
		{
			_token = await RefreshTokenAsync();
		}
		if (_token == null)
		{
			throw new Exception("Failed to refresh token - response is empty");
		}
		_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token.AccessToken);
	}

	private async Task<TokenResponse> RefreshTokenAsync()
	{
		string tokenEndpoint = "https://accounts.zoho.com/oauth/v2/token?grant_type=refresh_token&scope=Desk.tickets.CREATE,Desk.tickets.UPDATE&client_secret=4ee77d3265700f2fca0655e9c291df8e0330eae281&client_id=1000.MGDDO2YA3K1A8U4YK7Y0KISOT959TR&refresh_token=1000.ee1d83da630739146848eccad3c454f3.aae767edddb0403f356c8da5bf113e77";
		HttpResponseMessage response = await _httpClient.PostAsync(tokenEndpoint, null);
		if (!response.IsSuccessStatusCode)
		{
			string errorContent = await response.Content.ReadAsStringAsync();
			throw new Exception($"Failed to refresh token. Status code: {response.StatusCode}, Error: {errorContent}");
		}
		TokenResponse tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(await response.Content.ReadAsStringAsync());
		tokenResponse.ExpiresAt = DateTime.UtcNow.Add(TimeSpan.FromSeconds((double)tokenResponse.ExpiresIn));
		return tokenResponse;
	}

	public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest ticketRequest, bool isBetaFeedback)
	{
		await UpdateAuthorisationAsync();
		if (isBetaFeedback)
		{
			ticketRequest.TeamId = "309315000180748001";
		}
		ticketRequest.DepartmentId = "309315000000006907";
		ticketRequest.Category = "general";
		ticketRequest.SubCategory = "Sub General";
		ticketRequest.Classification = "";
		ticketRequest.DueDate = DateTime.UtcNow.Add(TimeSpan.FromDays(4.0));
		ticketRequest.Priority = "Normal";
		ticketRequest.Channel = "Email";
		ticketRequest.Language = "English";
		ticketRequest.Status = "Open";
		ticketRequest.Email = ticketRequest.Contact.Email;
		ticketRequest.Phone = ticketRequest.Contact.Phone;
		StringContent content = new StringContent(JsonConvert.SerializeObject(ticketRequest), Encoding.UTF8, "application/json");
		HttpResponseMessage response = await _httpClient.PostAsync("https://desk.zoho.com/api/v1/tickets", content);
		if (!response.IsSuccessStatusCode)
		{
			string errorContent = await response.Content.ReadAsStringAsync();
			throw new Exception($"Failed to create ticket. Status code: {response.StatusCode}, Error: {errorContent}");
		}
		return JsonConvert.DeserializeObject<CreateTicketResponse>(await response.Content.ReadAsStringAsync());
	}

	public async Task<CreateAttachmentResponse> UploadAttachmentAsync(string ticketId, string creatorId, string filePath)
	{
		await UpdateAuthorisationAsync();
		string url = "https://desk.zoho.com/api/v1/tickets/" + ticketId + "/attachments";
		using MultipartFormDataContent form = new MultipartFormDataContent();
		string fileName = Path.GetFileName(filePath);
		long fileSize = new FileInfo(filePath).Length;
		string jsonContent = JsonConvert.SerializeObject(new CreateAttachmentRequest
		{
			Size = fileSize.ToString(),
			CreatorId = creatorId,
			Name = fileName,
			CreatedTime = DateTime.UtcNow,
			IsPublic = false
		});
		StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
		form.Add(content, "\"\"");
		ByteArrayContent fileContent = new ByteArrayContent(File.ReadAllBytes(filePath));
		fileContent.Headers.ContentType = new MediaTypeHeaderValue(MimeMapping.GetMimeMapping(fileName));
		form.Add(fileContent, "file", fileName);
		HttpResponseMessage response = await _httpClient.PostAsync(url, form);
		content.Dispose();
		fileContent.Dispose();
		if (!response.IsSuccessStatusCode)
		{
			string errorContent = await response.Content.ReadAsStringAsync();
			throw new Exception($"Failed to upload attachment. Status code: {response.StatusCode}, Error: {errorContent}");
		}
		return JsonConvert.DeserializeObject<CreateAttachmentResponse>(await response.Content.ReadAsStringAsync());
	}
}
