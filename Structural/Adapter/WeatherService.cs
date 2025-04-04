using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class WeatherService
    {
        public string GetWeatherReport()
        {
            return "The weather is sunny.";
        }
    }
}
