using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSandbox.Core.Models
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public double TemperatureC { get; set; }
        public double TemperatureF { get; set; }
        public string Summary { get; set; }
    }
}
