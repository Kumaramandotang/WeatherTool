using CustomWeatherTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWeatherTool.Abstraction
{
    public interface IFileServices
    {
        public CityModel GetItemByName(string CityName);
    }
}
