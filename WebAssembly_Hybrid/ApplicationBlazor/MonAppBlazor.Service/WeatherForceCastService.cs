using MonAppBlazzor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAppBlazor.Service
{
    public class WeatherForceCastService
    {
        public async Task<WeatherForeCast[]> GetForeCastsAsync()
        {
            // Simulate asynchronous loading to demonstrate streaming rendering
            await Task.Delay(1000);

            var startDate = DateOnly.FromDateTime(DateTime.Now);
            var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            return Enumerable.Range(1, 5).Select(index => new WeatherForeCast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray();
        }
    }
}
