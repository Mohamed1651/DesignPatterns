using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class WeatherAdapter : INewWeatherProvider
    {
        private readonly WeatherService _weatherService;
        
        public WeatherAdapter(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public string GetWeatherReport()
        {
            return _weatherService.GetWeatherReport();
        }
    }
}
