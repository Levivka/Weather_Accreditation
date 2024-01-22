using Acc2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Acc2
{
    internal class WeatherController
    {
        HttpClient httpClient = new HttpClient();

        public async Task<Weather> getWeather(string city)
        {
            try
            {
                var res = await httpClient.GetFromJsonAsync<Weather>(
                    $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=505fe5292e0d1ce6fff26fc219e7b3aa&lang=ru&units=metric");
                return res;
            }
            catch 
            {
                return null;
            }
        }
    }
}
