using BlazorSandbox.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSandbox.Core.Services
{

    public interface IWeatherService
    {
        List<WeatherForecast> GetForecasts();
    }

    public class WeatherService : IWeatherService
    {
        public List<WeatherForecast> GetForecasts()
        {
            return new List<WeatherForecast>
            {
                new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(1),
                    TemperatureC = 1,
                    TemperatureF = 33,
                    Summary = "Chilly"
                },
                new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(2),
                    TemperatureC = 14,
                    TemperatureF = 57,
                    Summary = "Cool"
                },
                new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(3),
                    TemperatureC = -1,
                    TemperatureF = 28,
                    Summary = "Freezing"
                }
            };
        }
    }
}
