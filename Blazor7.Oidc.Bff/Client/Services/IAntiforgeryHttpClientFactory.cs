namespace Blazor7.Bff.Client.Services;

public interface IAntiforgeryHttpClientFactory
{
    Task<HttpClient> CreateClientAsync(string clientName = "authorizedClient");
}
