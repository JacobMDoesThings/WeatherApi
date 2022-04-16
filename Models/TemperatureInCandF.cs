using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApi.Models
{
    public struct TemperatureInCandF
    {
        [JsonPropertyName("c")]
        public int? Celsius { get; set; }
        [JsonPropertyName("f")]
        public int? Fahrenheit { get; set; }
    }
}
