using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq; // Ensure Newtonsoft.Json is installed via NuGet

public class PredictionController : Controller
{
    private readonly FastApiService _fastApiService;

    public PredictionController(FastApiService fastApiService)
    {
        _fastApiService = fastApiService;
    }

    // Display the form
    public IActionResult Index()
    {
        return View();
    }

    // Handle form submission and show predictions
    [HttpPost]
    public async Task<IActionResult> Predict(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            ViewBag.Error = "Text cannot be empty.";
            return View("Index");
        }

        try
        {
            // Predict using BERT model
            var bertResultJson = await _fastApiService.PredictPhishingBertAsync(text);
            var bertResult = JObject.Parse(bertResultJson);
            ViewBag.BertResult = new
            {
                predicted_class = bertResult["predicted_class"],
                confidence_score = bertResult["confidence_score"]
            };

            //Predict using New Model (currently commented out)
             var newModelResultJson = await _fastApiService.PredictNewModelAsync(text);
            var newModelResult = JObject.Parse(newModelResultJson);
            ViewBag.NewModelResult = new
            {
                predicted_class = newModelResult["predicted_class"],
                confidence_score = newModelResult["confidence_score"]
            };

            //Predict using Phishing New Model(currently commented out)
             var phishingNewResultJson = await _fastApiService.PredictPhishingNewAsync(text);
            var phishingNewResult = JObject.Parse(phishingNewResultJson);
            ViewBag.PhishingNewResult = new
            {
                predicted_class = phishingNewResult["predicted_class"],
                confidence_score = phishingNewResult["confidence_score"]
            };
        }
        catch (Exception ex)
        {
            ViewBag.Error = $"An error occurred: {ex.Message}";
        }

        return View("Index");
    }
}
