using BlazorSandbox.App.Models;
using System;
using System.Collections.Generic;

namespace BlazorSandbox.App.Services
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
                    Summary = "Chilly"
                },
                new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(2),
                    TemperatureC = 14,
                    Summary = "Cool"
                },
                new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(3),
                    TemperatureC = -1,
                    Summary = "Freezing"
                }
            };
        }
    }
}
