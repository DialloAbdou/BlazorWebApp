using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InitBlazor.Models;

namespace InitBlazor.Services
{
    public class WeatherForecastService
    {
        public async Task<WeatherForecast[]> GetWeatherForecastAsync()
        {
            // Simulate asynchronous loading to demonstrate a loading indicator
            await Task.Delay(1000);
            var startDate = DateOnly.FromDateTime(DateTime.Now);
            var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
           var forecast =    Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray();

            return forecast;
        }

    }
}
