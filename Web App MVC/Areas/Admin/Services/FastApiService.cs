using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class FastApiService
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl = "http://127.0.0.1:8000"; // Change this to your FastAPI URL

    public FastApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> PredictPhishingBertAsync(string text)
    {
        var requestContent = new { text = text };
        return await PostRequestAsync("/predict-phishing-bert", requestContent);
    }

    public async Task<string> PredictNewModelAsync(string text)
    {
        var requestContent = new { text = text };
        return await PostRequestAsync("/predict-spam", requestContent);
    }

    public async Task<string> PredictPhishingNewAsync(string text)
    {
        var requestContent = new { text = text };
        return await PostRequestAsync("/predict-phishing-new", requestContent);
    }

    private async Task<string> PostRequestAsync(string endpoint, object data)
    {
        var requestJson = JsonConvert.SerializeObject(data);
        var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(_baseUrl + endpoint, requestContent);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}
