using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Acc2.models
{
    internal class Main
    {
        [JsonPropertyName("temp")]
        public double Температура {  get; set; }
        
        [JsonPropertyName("humidity")]
        public double Влажность {  get; set; }
        
        [JsonPropertyName("pressure")]
        public double Давление {  get; set; }
    }
}
