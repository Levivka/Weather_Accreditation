using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Acc2.models
{
    internal class Weather
    {
        [JsonPropertyName("weather")]
        public List<WeatherInfo>? WeatherList { get; set; }

        [JsonPropertyName("main")]
        public Main? Main { get; set; }
    }
}
