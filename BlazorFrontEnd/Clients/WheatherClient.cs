using BlazorFrontEnd.Models;

namespace BlazorFrontEnd.Clients
{
    public class WheatherClient
    {
        private WeatherForecast[]? forecasts;


        public void seedForecasts()
        {
            var startDate = DateOnly.FromDateTime(DateTime.Now);
            var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray();
        }

        public WeatherForecast[] GetForecast()
        {
            if (forecasts == null)
            {
                seedForecasts();
            }
            return forecasts;
        }
    }
}
