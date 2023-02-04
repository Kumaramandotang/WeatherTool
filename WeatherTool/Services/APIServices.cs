using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherTool.Abstraction;
using WeatherTool.Model;

namespace WeatherTool.Services
{
    public class APIServices : IAPIServices
    {
        public async Task<WeatherModel> CallApiAsync(double lat, double lon)
        {
            try
            {
                var HttpClient = new HttpClient();
                HttpClient.BaseAddress = new Uri("https://api.open-meteo.com/v1/");               
                var response = await HttpClient.GetAsync($"forecast?latitude={lat}&longitude={lon}&current_weather=true");          
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return await response.Content.ReadFromJsonAsync<WeatherModel>();
                }
                else {
                    return new WeatherModel();
                }
               
            }
            catch (Exception ex) 
            {               
                     return new WeatherModel();
            }
        }
    }
}
