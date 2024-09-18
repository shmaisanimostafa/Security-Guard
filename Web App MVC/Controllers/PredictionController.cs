using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity; // Ensure Newtonsoft.Json is installed via NuGet

public class PredictionController : Controller
{
    private readonly FastApiService _fastApiService;
    private readonly DBContext _context;

    public PredictionController(FastApiService fastApiService, DBContext context)
    {
        _fastApiService = fastApiService;
        _context = context;
    }

    // Display the form
    public IActionResult Index()
    {
        return View();
    }

    // Handle form submission and show predictions
    [HttpPost]
    public async Task<IActionResult> Predict(string text, string userName, string userFeedback)
    {
        if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(userName))
        {
            ViewBag.Error = "Text and username cannot be empty.";
            return View("Index");
        }

        try
        {
            // Predict using various models
            var bertResultJson = await _fastApiService.PredictPhishingBertAsync(text);
            var bertResult = JObject.Parse(bertResultJson);
            ViewBag.BertResult = new
            {
                predicted_class = bertResult["predicted_class"],
                confidence_score = bertResult["confidence_score"]
            };

            var newModelResultJson = await _fastApiService.PredictNewModelAsync(text);
            var newModelResult = JObject.Parse(newModelResultJson);
            ViewBag.NewModelResult = new
            {
                predicted_class = newModelResult["predicted_class"],
                confidence_score = newModelResult["confidence_score"]
            };

            var phishingNewResultJson = await _fastApiService.PredictPhishingNewAsync(text);
            var phishingNewResult = JObject.Parse(phishingNewResultJson);
            ViewBag.PhishingNewResult = new
            {
                predicted_class = phishingNewResult["predicted_class"],
                confidence_score = phishingNewResult["confidence_score"]
            };

            // Retrieve user information (replace with actual user retrieval logic)
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName);
            if (user == null)
            {
                ViewBag.Error = "User not found.";
                return View("Index");
            }

            // Create and save PhishingEmail instance
            var phishingEmail = new PhishingEmail
            { 
                User = user,
                UserName = userName,
                EmailMessage = text,
                PredictedClass = (int)phishingNewResult["predicted_class"],
                ConfidenceScore = (float)phishingNewResult["confidence_score"],
                DateTime = DateTime.UtcNow,
                IPAddress = HttpContext.Connection.RemoteIpAddress?.ToString(),
                ModelVersion = "v1.0",
                UserFeedback = userFeedback,
                ReClassification = null
            };

            _context.PhishingEmails.Add(phishingEmail);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            ViewBag.Error = $"An error occurred: {ex.Message}";
        }

        return View("Index");
    }

}
