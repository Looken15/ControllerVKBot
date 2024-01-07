using System.Net;
using System.Net.Http.Headers;
using ControllerBot.Models;
using ControllerBot.VKAPI.Interfaces;
using Newtonsoft.Json;

namespace ControllerBot.VKAPI;

public partial class VKAPI : IVKAPI
{
    private readonly IConfiguration configuration;

    private readonly string accessToken;
    private readonly string apiVersion;
    private readonly string baseUrl = "https://api.vk.ru/method/{0}?{1}";

    public VKAPI(IConfiguration _configuration)
    {
        configuration = _configuration;
        accessToken = configuration["AccessToken"];
        apiVersion = configuration["APIVersion"];
    }

    public string GetToken()
    {
        return accessToken;
    }

    private async Task Get(string method, Dictionary<string, string> parameters)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        parameters.Add("v", apiVersion);
        var parameterString = string.Join('&', parameters.Select(kv => $"{kv.Key}={kv.Value}"));
        var url = string.Format(baseUrl, method, parameterString);
        await client.GetStringAsync(url);
    }
    
    private async Task<T?> Get<T>(string method, Dictionary<string, string> parameters)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        parameters.Add("v", apiVersion);
        var parameterString = string.Join('&', parameters.Select(kv => $"{kv.Key}={kv.Value}"));
        var url = string.Format(baseUrl, method, parameterString);
        var responseString = await client.GetStringAsync(url);
        return JsonConvert.DeserializeObject<T>(responseString);
    }
}