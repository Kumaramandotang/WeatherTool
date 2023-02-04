using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTool.Model;

namespace WeatherTool.Abstraction
{
    public interface IAPIServices
    {
        Task<WeatherModel> CallApiAsync(double lat, double lon);
    }
}
