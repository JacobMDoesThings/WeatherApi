using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApi.Models
{
    
    public record CurrentWeather
    {
        [JsonPropertyName("dayhour")]
        public string? DayHour { get; set; }
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
        [JsonPropertyName("humidity")]
        public string? Humidity { get; set; }
        [JsonPropertyName("precip")]
        public string? Precipitation { get; set; }
        [JsonPropertyName("temp")]
        public TemperatureInCandF CurrentTemp { get; set; }
        [JsonPropertyName("wind")]
        public WindInKmAndMph Wind { get; set; }
        [JsonPropertyName("iconURL")]
        public string? IconUrl { get; set; }
    }
}
