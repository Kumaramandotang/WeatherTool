using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTool.Abstraction;
using WeatherTool.Model;

namespace WeatherTool.Services
{
    public class DisplayService : IDIsplayService
    {
        public void DisplayResponse(WeatherModel Item, string CityName)
        {
            Console.WriteLine($"\n\n------------Report-------------\n\n");
            Console.WriteLine($"Weather roprt for {CityName} are as follows:-\n");
            Console.WriteLine($"Temprature ---- {Item.current_weather.temperature} Degree Celsius\n");
            Console.WriteLine($"Wind Speed ---- {Item.current_weather.windspeed}Km/Hour\n");
            Console.WriteLine($"Wind Direction ---- {Item.current_weather.winddirection}\n");
        }
    }
}
