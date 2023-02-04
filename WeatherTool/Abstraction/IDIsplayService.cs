using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTool.Model;

namespace WeatherTool.Abstraction
{
    public interface IDIsplayService
    {
        public void DisplayResponse(WeatherModel Item, string CityName);
    }
}
