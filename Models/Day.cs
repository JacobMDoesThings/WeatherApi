using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApi.Models
{
    
    public record Day
    {
        [JsonPropertyName("day")]
        public string DayOfWeek { get; set; } = string.Empty;
        [JsonPropertyName("comment")]
        public string Comment { get; set; } = string.Empty;
        [JsonPropertyName("min_temp")]

        public TemperatureInCandF MinTemp { get; set; }
        [JsonPropertyName("max_temp")]
        public TemperatureInCandF MaxTemp { get; set; }
        [JsonPropertyName("iconURL")]
        public string IconUrl { get; set; } = string.Empty;

    }
}

